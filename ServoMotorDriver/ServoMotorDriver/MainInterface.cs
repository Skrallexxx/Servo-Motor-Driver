using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using static ServoMotorDriver.ControlEnums;

namespace ServoMotorDriver {
    public partial class MainInterface : Form {

        #region Variables and Control/Communication Properties
        // Received inputs and outgoing outputs
        private int DecoderA = 0, DecoderB = 0, DacCurrentValue = 0;
        private byte[] Inputs = new byte[4];
        private byte[] Outputs = new byte[4];
        const byte DecoderAPort = 0, DecoderBPort = 1, DACPort = 2, DACCheckPort = 3;
        const byte START = 255, REQ = 0;

        // Current selected mode and direction
        MODE currentMode = MODE.FREESPIN;
        DIRECTION currentDirection = DIRECTION.CLOCKWISE;

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
                ModeSelectionBox.Items.Add(GetAttribute(mode).disp);
            }
            ModeSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Mode Selection Options");

            // Add the DIRECTION enums to the dropdown direction selection box
            foreach(DIRECTION direction in Enum.GetValues(typeof(DIRECTION))) {
                DirectionSelectionBox.Items.Add(GetAttribute(direction).disp);
            }
            DirectionSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Direction Selection Options");

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
            if (!SerialComPort.IsOpen)
                TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString());

            // Check for any incoming data packets
            ReadIncomingData();
        }

        #endregion

        #region Communication Send/Receive

        void TryOpenSerialCommunication(string portName, bool reOpen = false) {
            // Check if the bluetooth has been connected
            if (SerialComPort.PortName == portName && SerialComPort.IsOpen) {
                WriteMessage("Communication is already established on the selected COM port");
                return;
            }
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

        void ReadIncomingData() {
            if (!SerialComPort.IsOpen) return;

            // Send an update request for incoming values
            SendOutgoingData(DecoderAPort, REQ);
            SendOutgoingData(DecoderBPort, REQ);
            SendOutgoingData(DACCheckPort, REQ);

            if(SerialComPort.BytesToRead >= 4) {
                Inputs[0] = (byte)SerialComPort.ReadByte();
                if (Inputs[0] != START) return;
                Inputs[1] = (byte)SerialComPort.ReadByte();
                Inputs[2] = (byte)SerialComPort.ReadByte();
                Inputs[3] = (byte)SerialComPort.ReadByte();

                byte checksum = (byte)(Inputs[0] + Inputs[1] + Inputs[2]);
                if (Inputs[3] != checksum) {
                    WriteError("Received invalid data packet");
                    return;
                }

                if (Inputs[1] == DecoderAPort)
                    DecoderA = Inputs[2];
                else if (Inputs[1] == DecoderBPort)
                    DecoderB = Inputs[2];
                else if (Inputs[1] == DACCheckPort) {
                    DacCurrentValue = Inputs[2];
                    RawControlCurrentTextBox.Text = DacCurrentValue.ToString();
                }
                else WriteError("Received invalid PORT byte " + Inputs[2]);
            }
        }

        void SendOutgoingData(byte PORT, byte DATA) {
            Outputs[0] = START;
            Outputs[1] = PORT;
            Outputs[2] = DATA;
            Outputs[3] = (byte)(START + PORT + DATA);
            if (!SerialComPort.IsOpen) return;
            SerialComPort.Write(Outputs, 0, 4);
        }

        #endregion

        #region Interface Helper Methods

        // Called when the COM port selection is changed, updates COM port in use for serial communication
        private void OnComPortSelectionChanged(object sender, EventArgs e) {
            WriteMessage("COM Port selection modified, updating serial communication");
            TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString(), true);
        }

        // Called when the mode selection is changed, updates the current operation mode
        private void OnModeSelectionChanged(object sender, EventArgs e) {
            foreach(MODE mode in Enum.GetValues(typeof(MODE))) {
                if(ModeSelectionBox.Text == GetAttribute(mode).disp) {
                    currentMode = mode;
                    break;
                }
            }
            WriteMessage("Selected mode updated to " + GetAttribute(currentMode).disp);

            if (currentMode == MODE.BINARY) RawControlGroupBox.Enabled = true;
            else RawControlGroupBox.Enabled = false;

            if (currentMode == MODE.MANUAL_SPEED || currentMode == MODE.MANUAL_SPEED_COMP) SpeedControlGroupBox.Enabled = true;
            else SpeedControlGroupBox.Enabled = false;

            if (currentMode == MODE.POSITIONAL) PositionControlGroupBox.Enabled = true;
            else PositionControlGroupBox.Enabled = false;
        }

        // Called when the direction selection is changed, updates the current direction
        private void OnDirectionSelectionChanged(object sender, EventArgs e) {
            foreach(DIRECTION direction in Enum.GetValues(typeof(DIRECTION))) {
                if(DirectionSelectionBox.Text == GetAttribute(direction).disp) {
                    currentDirection = direction;
                    break;
                }
            }
            WriteMessage("Selected direction updated to " + GetAttribute(currentDirection).disp);
        }

        private void OnRawControlValueChanged(object sender, EventArgs e) {
            RawControlProgressBar.Value = (int)RawControlUpDown.Value;
            SendOutgoingData(DACPort, (byte)RawControlUpDown.Value);
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
