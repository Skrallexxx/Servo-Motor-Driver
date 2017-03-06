using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using static ServoMotorDriver.ControlEnums;

namespace ServoMotorDriver {
    public partial class MainInterface : Form {

        #region Variables and Control/Communication Properties
        // Received inputs and outgoing outputs
        private int Input = 0;
        private byte[] Inputs = new byte[4];
        private byte[] Outputs = new byte[4];

        // Transmission constants
        private const byte START = 255, ZERO = 0;

        // DAC Object
        private DAC dac = new DAC();

        #endregion

        #region Interface Intialization
        // Interface intiialization method
        public MainInterface() {
            Debug.WriteLine("Servo Motor Driver Starting Up...");
            InitializeComponent();

            // Add the MODE enums to the dropdown mode selection box
            foreach(MODE mode in Enum.GetValues(typeof(MODE))) {
                ModeSelectionBox.Items.Add(ControlEnums.GetAttribute(mode).disp);
            }
            WriteMessage("Added Mode Selection Options");

            // Add available COM ports to the dropdown port selection box
            ComPortSelectionBox.DataSource = SerialPort.GetPortNames();
            WriteMessage("Added COM Port Selection Options");

            // Establish connection using selected COM port
            if (ComPortSelectionBox.Items.Count > 0)
                TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString());
            else WriteError("No Available COM Ports");
        }

        #endregion

        #region Program Loop

        // Send-Recieve method, runs every 10 ticks
        private void SendReceiveUpdate(object sender, EventArgs e) {

        }

        #endregion

        #region Communication Send/Receive

        void TryOpenSerialCommunication(string portName, bool reOpen = false) {
            // Check if the bluetooth has been connected
            if (reOpen = true && SerialComPort.IsOpen)
                SerialComPort.Close();
            if (!SerialComPort.IsOpen) {
                if (portName.Length == 0)
                    return;
                SerialComPort.PortName = portName;
                try {
                    //Try to connect to the bluetooth
                    WriteMessage("Attempting to open communication on " + portName);
                    SerialComPort.Open();
                    WriteMessage("Communication successfully opened on " + portName);
                }
                catch {
                    //If the bluetooth does not connect return an error
                    WriteError("Failed to open communication on " + portName);
                }
            }
        }

        #endregion

        #region Interface Helper Methods

        // Called when the COM port selection is changed, updates COM port in use for serial communication
        private void OnComPortSelectionChanged(object sender, EventArgs e) {

        }

        #endregion

        #region Debugging
        // Writes a non-error info message to the interface and the console output
        private void WriteMessage(string message) {
            Debug.WriteLine("\t" + message);
            MessageLogStatusStrip.Text = message;
        }

        // Writes an error message to the interface and the console output
        private void WriteError(string message) {
            Debug.WriteLine("\t[ERROR] " + message);
            MessageLogStatusStrip.Text = message;
        }
        #endregion
    }
}
