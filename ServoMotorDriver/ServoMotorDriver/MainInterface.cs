using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using ServoMotorDriver;

namespace ServoMotorDriver {
    public partial class MainInterface : Form {

        #region Variables and Control/Communication Properties
        // Received inputs and outgoing outputs
        private int decoderHigh = 0, decoderLow = 0, dacCurrentValue = 0;
        private byte[] Inputs = new byte[4];
        private byte[] Outputs = new byte[4];

        // Communication Variables
        const byte decoderHighPort = 0, decoderLowPort = 1, DACPort = 2, DACCheckPort = 3;
        const byte START = 255, REQ = 0;

        // Tuning and Deadband Variables
        private decimal binaryMax = 255, binaryMin = 5;
        private byte deadBandMin = 113, deadBandMax = 146;

        // Decoder Position, Velocity and Acceleration Variables
        Int16 currentPos = 0;
        Int16 totalPos = 0;
        Int16 startTime = 0;
        Int16 currentTime = 0;

        System.DateTime time = new System.DateTime();

        // Current selected mode and direction
        ControlEnums.MODE currentMode = ControlEnums.MODE.FREESPIN;
        ControlEnums.DIRECTION currentDirection = ControlEnums.DIRECTION.CLOCKWISE;

        // DAC Object, stores Binary <> Voltage Gradient and Intercept
        private DAC dac1 = new DAC(0.1206m, -15.697m);

        #endregion

        #region Interface Intialization
        // Interface intiialization method
        public MainInterface() {
            Debug.WriteLine("Servo Motor Driver Starting Up...");
            InitializeComponent();
            startTime = (Int16)time.Second;

            // Add the MODE enums to the dropdown mode selection box
            foreach (ControlEnums.MODE mode in Enum.GetValues(typeof(ControlEnums.MODE))) {
                ModeSelectionBox.Items.Add(ControlEnums.GetAttribute(mode).disp);
            }
            ModeSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Mode Selection Options");

            // Add the DIRECTION enums to the dropdown direction selection box
            foreach (ControlEnums.DIRECTION direction in Enum.GetValues(typeof(ControlEnums.DIRECTION))) {
                DirectionSelectionBox.Items.Add(ControlEnums.GetAttribute(direction).disp);
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

            // Set NumericUpDown Bounds
            VoltageControlVoltageUpDown.Maximum = CalculateVoltageFromBinary(binaryMax);
            VoltageControlVoltageUpDown.Minimum = CalculateVoltageFromBinary(binaryMin);

            // Set Bar Chart Bounds
            VoltageControlNegativeChart.ChartAreas["ChartArea1"].Axes[1].Maximum = (double)(0 - CalculateVoltageFromBinary(binaryMin));
            VoltageControlPositiveChart.ChartAreas["ChartArea1"].Axes[1].Maximum = (double)CalculateVoltageFromBinary(binaryMax);

            // Set Dead-Band Bounds
            DeadBandLowerUpDown.Value = deadBandMin;
            DeadBandUpperUpDown.Value = deadBandMax;
        }

        #endregion

        #region Program Loop

        // Send-Recieve method, runs every 10 ticks
        private void SendReceiveUpdate(object sender, EventArgs e) {
            if (!SerialComPort.IsOpen && ComPortSelectionBox.Items.Count > 0)
                TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString());

            // Check for any incoming data packets
            ReadIncomingData();

            textBox3.Text = ((Int16)((decoderHigh << 8) | decoderLow)).ToString();
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
            SendOutgoingData(decoderHighPort, REQ);
            SendOutgoingData(decoderLowPort, REQ);
            SendOutgoingData(DACCheckPort, REQ);

            while(SerialComPort.BytesToRead >= 4) {
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

                if (Inputs[1] == decoderHighPort) {
                    decoderHigh = Inputs[2];
                    textBox1.Text = decoderHigh.ToString();
                }
                else if (Inputs[1] == decoderLowPort) {
                    decoderLow = Inputs[2];
                    textBox2.Text = decoderLow.ToString();
                }
                else if (Inputs[1] == DACCheckPort) {
                    dacCurrentValue = Inputs[2];
                    RawControlCurrentTextBox.Text = dacCurrentValue.ToString();
                    RawCurrentVoltageTextBox.Text = CalculateVoltageFromBinary(dacCurrentValue).ToString();
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
            foreach (ControlEnums.MODE mode in Enum.GetValues(typeof(ControlEnums.MODE))) {
                if (ModeSelectionBox.Text == ControlEnums.GetAttribute(mode).disp) {
                    currentMode = mode;
                    break;
                }
            }
            WriteMessage("Selected mode updated to " + ControlEnums.GetAttribute(currentMode).disp);

            if (currentMode == ControlEnums.MODE.BINARY || currentMode == ControlEnums.MODE.MANUAL_SPEED) RawControlGroupBox.Enabled = true;
            else RawControlGroupBox.Enabled = false;

            if (currentMode == ControlEnums.MODE.MANUAL_SPEED) SpeedControlGroupBox.Enabled = true;
            else SpeedControlGroupBox.Enabled = false;

            if (currentMode == ControlEnums.MODE.POSITIONAL) PositionControlGroupBox.Enabled = true;
            else PositionControlGroupBox.Enabled = false;

            if (currentMode == ControlEnums.MODE.DEAD_BAND_TEST) DeadBandTestingGroupBox.Enabled = true;
            else DeadBandTestingGroupBox.Enabled = false;
        }

        // Called when the direction selection is changed, updates the current direction
        private void OnDirectionSelectionChanged(object sender, EventArgs e) {
            foreach (ControlEnums.DIRECTION direction in Enum.GetValues(typeof(ControlEnums.DIRECTION))) {
                if (DirectionSelectionBox.Text == ControlEnums.GetAttribute(direction).disp) {
                    currentDirection = direction;
                    break;
                }
            }
            WriteMessage("Selected direction updated to " + ControlEnums.GetAttribute(currentDirection).disp);
        }

        // Called when the binary output value is changed, and sends the value to the arduino
        private void OnRawControlValueChanged(object sender, EventArgs e) {
            RawBinaryChart.Series["Series1"].Points[0].YValues = new double[]{(double)RawControlUpDown.Value};
            RawBinaryChart.Update();

            byte compensated = (byte)RawControlUpDown.Value;
            if(DeadBandCompensationCheckBox.Checked && RawControlUpDown.Value > deadBandMin && RawControlUpDown.Value < deadBandMax) {
                if (RawControlUpDown.Value > CalculateBinaryFromVoltage(0))
                    compensated = deadBandMax;
                else if (RawControlUpDown.Value == CalculateBinaryFromVoltage(0)) {
                    compensated = CalculateBinaryFromVoltage(0);
                }
                else compensated = deadBandMin;
            }

            VoltageControlVoltageUpDown.Value = CalculateVoltageFromBinary(RawControlUpDown.Value);
            //UpdateVoltageCharts(CalculateVoltageFromBinary(RawControlUpDown.Value));
            SendOutgoingData(DACPort, compensated);
            RawVoltageTextBox.Text = CalculateVoltageFromBinary(compensated).ToString();
        }

        // 
        private void OnVoltageControlValueChanged(object sender, EventArgs e) {
            UpdateVoltageCharts(VoltageControlVoltageUpDown.Value);
            RawControlUpDown.Value = CalculateBinaryFromVoltage(VoltageControlVoltageUpDown.Value);
        }

        private void UpdateVoltageCharts(decimal dataValue) {
            if (dataValue < 0) {
                VoltageControlNegativeChart.Series["Series1"].Points[0].YValues = new double[] { (double)(0 - dataValue) };
                VoltageControlPositiveChart.Series["Series1"].Points[0].YValues = new double[] { 0 };
            }
            else {
                VoltageControlPositiveChart.Series["Series1"].Points[0].YValues = new double[] { (double)(dataValue) };
                VoltageControlNegativeChart.Series["Series1"].Points[0].YValues = new double[] { 0 };
            }

            VoltageControlPositiveChart.Update();
            VoltageControlNegativeChart.Update();
        }

        private void OnDeadBandMinValueChanged(object sender, EventArgs e) {
            deadBandMin = (byte)DeadBandLowerUpDown.Value;
        }

        private void OnDeadBandMaxValueChanged(object sender, EventArgs e) {
            deadBandMax = (byte)DeadBandUpperUpDown.Value;
        }

        #endregion

        #region Data Calculation Methods
        private decimal CalculateVoltageFromBinary(decimal binary) {
            decimal voltage = dac1.gradient * binary + dac1.intercept;
            return Math.Round(voltage, 2);
        }

        private byte CalculateBinaryFromVoltage(decimal voltage) {
            decimal binary = Math.Round((voltage - dac1.intercept) / dac1.gradient);
            if (binary > 255) binary = 255;
            if (binary < 5) binary = 5;
            return (byte)Math.Round(binary);
        }
        #endregion

        #region Data Plotting Methods
        private void PlotPosition(Int16 startTime, Int16 currentTime, String data) {
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
