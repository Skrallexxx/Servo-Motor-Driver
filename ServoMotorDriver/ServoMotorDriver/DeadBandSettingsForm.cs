using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using comms = ServoMotorDriver.MainInterface.Communications;

namespace ServoMotorDriver {
    public partial class DeadBandSettingsForm : Form {
        MainInterface instance = MainInterface.instance;

        public static int min = 113, defaultMin = 113;
        public static int max = 146, defaultMax = 146;
        public static int mass = 0, defaultMass = 0;

        public static bool deadbandTestRunning = false;

        private static Dictionary<int, DeadbandEntry> deadbandEntries = new Dictionary<int, DeadbandEntry>();
        string jsonFilePath = AppDomain.CurrentDomain.BaseDirectory + "DeadbandSettings.json";

        Thread deadbandTestThread;

        public DeadBandSettingsForm() {
            InitializeComponent();
            MainInterface.deadbandSettingsOpen = true;

            // Ensure the file exists to prevent errors
            if (!File.Exists(jsonFilePath)) {
                FileStream fs = new FileStream(jsonFilePath, FileMode.CreateNew);
                fs.Close();
            }

            MinUpDown.Value = min;
            MaxUpDown.Value = max;
            MassUpDown.Value = mass;

            // Attempt to load the file and save the loaded values if they exist
            Dictionary<int, DeadbandEntry> deadbandEntriesToLoad = ReadFromJson(jsonFilePath);
            if (deadbandEntriesToLoad != null) {
                deadbandEntries = deadbandEntriesToLoad;
                toolStripStatusLabel1.Text = "Loaded list of " + deadbandEntries.Count + " saved deadband entries.";

                if(deadbandEntries.ContainsKey((int)MassUpDown.Value)) {
                    DeadbandEntry defaultEntry;
                    deadbandEntries.TryGetValue((int)MassUpDown.Value, out defaultEntry);
                    MinUpDown.Value = BoundBinaryUpDown(defaultEntry.min);
                    MaxUpDown.Value = BoundBinaryUpDown(defaultEntry.max);
                }
            }
            else {
                toolStripStatusLabel1.Text = "No existing deadband entries to load";
            }
        }

        // Ensures that a binary numeric up-down cannot exceed the 0-255 range when loading
        private int BoundBinaryUpDown(int value) {
            if (value < 0)
                return 0;
            if (value > 255)
                return 255;
            return value;
        }

        #region Button Methods

        // Called when the save button is clicked, saves the current values to file
        private void OnSaveButtonClick(object sender, EventArgs e) {
            if(deadbandEntries.ContainsKey((int)MassUpDown.Value)) {
                DeadbandEntry existingEntry;
                deadbandEntries.TryGetValue((int)MassUpDown.Value, out existingEntry);
                existingEntry.min = (int)MinUpDown.Value;
                existingEntry.max = (int)MaxUpDown.Value;
                toolStripStatusLabel1.Text = "Updated entry for mass " + existingEntry.mass + "g: " + existingEntry.min + " to " + existingEntry.max;
            }
            else {
                DeadbandEntry newEntry = new DeadbandEntry((int)MassUpDown.Value, (int)MinUpDown.Value, (int)MaxUpDown.Value);
                deadbandEntries.Add((int)MassUpDown.Value, newEntry);
                toolStripStatusLabel1.Text = "Saved new entry for mass " + newEntry.mass + "g: " + newEntry.min + " to " + newEntry.max;
            }
            WriteToJson(jsonFilePath, deadbandEntries);
        }

        // Called when the load button is clicked, loads the entry for the current mass if it exists
        private void OnLoadButtonClick(object sender, EventArgs e) {
            if (deadbandEntries.ContainsKey((int)MassUpDown.Value)) {
                DeadbandEntry existingEntry;
                deadbandEntries.TryGetValue((int)MassUpDown.Value, out existingEntry);
                MinUpDown.Value = existingEntry.min;
                MaxUpDown.Value = existingEntry.max;
                toolStripStatusLabel1.Text = "Loaded entry for mass " + existingEntry.mass + "g: " + existingEntry.min + " to " + existingEntry.max;
            }
            else {
                toolStripStatusLabel1.Text = "No saved entry found for mass " + (int)MassUpDown.Value + "g, save one first";
            }
        }

        // Called when the reset button is clicked, returns values to their defaults
        private void OnResetButtonClick(object sender, EventArgs e) {
            MinUpDown.Value = defaultMin;
            MaxUpDown.Value = defaultMax;
            MassUpDown.Value = defaultMass;
        }

        // Called when the start button is clicked, starts testing for the deadband range
        private void OnStartButtonClick(object sender, EventArgs e) {
            Int64 totalPos1 = instance.totalPos;
            BinaryTextBox.Text = instance.CalculateBinaryFromVoltage(comms.dacCurrentValue).ToString();
            PositionTextBox.Text = totalPos1.ToString();

            TestingStartButton.Enabled = false;
            SaveButton.Enabled = false;
            LoadButton.Enabled = false;
            TestingStopButton.Enabled = true;

            comms.SendOutgoingData(comms.cmdSetDAC, 1, new byte[] { instance.CalculateBinaryFromVoltage(0m) });

            deadbandTestRunning = true;
            deadbandTestThread = new Thread(new ThreadStart(StartDeadbandTest));
            deadbandTestThread.Start();
        }

        // Called when the stop button is clicked, stops the deadband testing thread
        private void OnStopButtonClick(object sender, EventArgs e) {
            deadbandTestThread.Abort();
            if (deadbandTestRunning)
                toolStripStatusLabel1.Text = "Aborted deadband test";
            else toolStripStatusLabel1.Text = "Can't abort deadband test because it's not started";

            TestingStartButton.Enabled = true;
            SaveButton.Enabled = true;
            LoadButton.Enabled = true;
            TestingStopButton.Enabled = false;
        }

        #endregion

        #region Other Interface Helper Methods
        // Called when the minimum deadband value changes
        private void OnMinValueChanged(object sender, EventArgs e) {
            min = (int)MinUpDown.Value;
        }

        // Called when the maximum deadband value changes
        private void OnMaxValueChanged(object sender, EventArgs e) {
            max = (int)MaxUpDown.Value;
        }

        private void OnMassValueChanged(object sender, EventArgs e) {
            mass = (int)MassUpDown.Value;
        }

        // Called when the window is closed, stops the deadband testing thread if it's running
        private void OnDeadbandFormClosed(object sender, FormClosedEventArgs e) {
            MainInterface.deadbandSettingsOpen = false;
            if (deadbandTestRunning)
                deadbandTestThread.Abort();
        }

        #endregion

        #region Read/Write Methods
        // Writes the dictionary of deadband entries to the file
        public static void WriteToJson(string file, Dictionary<int, DeadbandEntry> entriesToWrite, bool append = false) {
            TextWriter writer = null;
            try {
                string contentsToWrite = JsonConvert.SerializeObject(entriesToWrite, Formatting.Indented);
                writer = new StreamWriter(file, append);
                writer.WriteLine(contentsToWrite);
            }
            finally {
                if (writer != null)
                    writer.Close();
            }
        }


        // Reads a dictionary of deadband entries from the file
        public static Dictionary<int, DeadbandEntry> ReadFromJson(string file) {
            TextReader reader = null;
            try {
                reader = new StreamReader(file);
                string fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Dictionary<int, DeadbandEntry>>(fileContents);
            }
            finally {
                if (reader != null)
                    reader.Close();
            }
        }
        #endregion

        #region Automatic Deadband Testing Methods
        // Begins the automatic testing for the deadband range
        public void StartDeadbandTest() {
            Stopwatch sw = Stopwatch.StartNew();
            Int64 startPos = instance.totalPos;
            int binaryVal = instance.CalculateBinaryFromVoltage(0m);

            // Testing configuration variables. Potentially move to interface if necessary
            int interval = 1;
            int sleepTime = 500;

            Console.Write("deadband test thread started");

            // Determine maximum deadband binary value
            while (binaryVal < 255 && instance.totalPos <= (startPos + 1000)) {
                toolStripStatusLabel1.Text = "Stage 1/2";
                binaryVal += interval;
                startPos = instance.totalPos;
                comms.SendOutgoingData(comms.cmdSetDAC, 1, new byte[] { (byte)binaryVal });
                Invoke((Action)delegate () { UpdateControls(binaryVal); });
                Thread.Sleep(sleepTime);
            }

            // Reset some values for the reverse deadband test
            startPos = instance.totalPos;
            binaryVal = instance.CalculateBinaryFromVoltage(0m);
            comms.SendOutgoingData(comms.cmdSetDAC, 1, new byte[] { (byte)binaryVal});

            // Determine minimum deadband binary value
            while(binaryVal > 0 && instance.totalPos >= (startPos - 1000)) {
                toolStripStatusLabel1.Text = "Stage 2/2";
                binaryVal -= interval;
                startPos = instance.totalPos;
                comms.SendOutgoingData(comms.cmdSetDAC, 1, new byte[] { (byte)binaryVal });
                Invoke((Action)delegate() { UpdateControls(binaryVal); });
                Thread.Sleep(sleepTime);
            }

            sw.Stop();
            toolStripStatusLabel1.Text = "Deadband testing completed in " + sw.ElapsedMilliseconds + "ms";
            deadbandTestRunning = false;
            Invoke((Action)delegate () { UpdateControls(binaryVal); });
        }

        // Updates the interface controls, called from the testing thread in order to maintain thread safety
        private void UpdateControls(int binaryValue) {
            Int64 totalPos1 = instance.totalPos;
            BinaryTextBox.Text = binaryValue.ToString();
            PositionTextBox.Text = totalPos1.ToString();

            // Deadband test is running and testing the max value
            if (deadbandTestRunning && binaryValue >= instance.CalculateBinaryFromVoltage(0m)) {
                MaxUpDown.Value = binaryValue;
                TestingProgressBar.Maximum = 255;
                TestingProgressBar.Minimum = instance.CalculateBinaryFromVoltage(0m);
                TestingProgressBar.Value = binaryValue;
            }

            // Deadband test is running and testing the min value
            if (deadbandTestRunning && binaryValue <= instance.CalculateBinaryFromVoltage(0m)) {
                MinUpDown.Value = binaryValue;
                TestingProgressBar.Maximum = instance.CalculateBinaryFromVoltage(0m);
                TestingProgressBar.Minimum = 0;
                TestingProgressBar.Value = (int)(instance.CalculateBinaryFromVoltage(0m) - binaryValue);
            }

            // Deadband test is not running and the thread is about to end
            if(!deadbandTestRunning) {
                TestingStartButton.Enabled = true;
                SaveButton.Enabled = true;
                LoadButton.Enabled = true;
                TestingStopButton.Enabled = false;
            }
        }
        #endregion

        [Serializable]
        public class DeadbandEntry {
            public int mass;
            public int min;
            public int max;

            public DeadbandEntry(int mass, int min, int max) {
                this.mass = mass;
                this.min = min;
                this.max = max;
            }

            public DeadbandEntry() { }
        }
    }
}
