using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Threading;

namespace ServoMotorDriver {
    public partial class MainInterface : Form {
        /*==================================================== THREADS AND FORMS ====================================================*/
        public static MainInterface instance;
        public static bool deadbandSettingsOpen = false;
        public static bool testDataSettingsOpen = false;
        public static bool realtimeDataSettingsOpen = false;
        public static bool graphingOpen = false;

        // Threading
        Thread commsThread;

        // Sub-Forms
        DeadBandSettingsForm deadbandSettings = null;
        GraphingForm graphs = null;

        #region Variables and Control/Communication Properties
        // DAC variables from Excel trendline
        private DAC dac1 = new DAC(0.1206m, -15.697m);
        public int binaryMax = 255, binaryMin = 5;

        /*==================================================== POSITION, VELOCITY AND ACCELERATION ====================================================*/
        // Decoder Position Variables
        public int encoderResolution = 2000; // Counts per resolution
        public int decoderResetMax = 20000, decoderResetMin = -20000;
        public KeyValuePair<Int32, Int16> decoderValue;
        public Int16 currentPos = 0;
        public Int16 lastPos = 0;
        public int currentRotationPos = 0;
        public Int64 totalPos = 0;
        public Int64 lastTotalPos = 0;

        // Velocity Variables
        public double velocity = 0;
        public Int64 lastPosition = 0;
        public int positionIndex = 0;
        public int numPositionSamples = 500;
        List<KeyValuePair<Int64, Int32>> lastPositions = new List<KeyValuePair<Int64, Int32>>();

        // Acceleration variables
        public double acceleration = 0.0;
        public double lastVelocity = 0.0;
        public int velocityIndex = 0;
        public int numVelocitySamples = 500;
        List<KeyValuePair<Double, Int32>> lastVelocities = new List<KeyValuePair<Double, Int32>>();

        /*==================================================== PID ====================================================*/
        Int64 error = 0, errorLast = 0;
        double errorIntegral = 0, errorDerivative;
        int errorIntegralMax = 750, errorIntegralMin = -750;

        // Proportional, Integral and Derivative multipliers
        double kp = 0.0045;
        double ki = 0;
        double kd = 0;

        // Desired postion and velocity variables
        public int desiredPos = 0;
        public double desiredVelocity = 0.0;

        /*==================================================== Stopwatches ====================================================*/
        // Stopwatches for determinining elapsed times
        Stopwatch uptimeSW = new Stopwatch();
        Stopwatch testingSW = new Stopwatch();
        Stopwatch accelerationSW = new Stopwatch();
        Random rand = new Random();

        /*==================================================== CONTROL ENUMS ====================================================*/
        // Enums for current selected modes of operation
        ControlEnums.DATAMODE currentDataMode = ControlEnums.DATAMODE.DECODER;
        ControlEnums.BASEUNITS currentPositionUnit = ControlEnums.BASEUNITS.COUNTS;
        ControlEnums.BASEUNITS currentVelocityUnit = ControlEnums.BASEUNITS.COUNTS;
        ControlEnums.BASEUNITS currentAccelerationUnit = ControlEnums.BASEUNITS.COUNTS;

        /*==================================================== CIRCLE PLOT ====================================================*/
        // Circle Plot Variables
        private BufferedGraphicsContext circlePlotContext;
        private BufferedGraphics circlePlotBuffer;
        private Bitmap circlePlotSurface;
        private Rectangle[] circleRectangles = new Rectangle[2];
        private Rectangle circleBounds;
        private Pen[] circlePlotPens = new Pen[2];
        private Pen outerCirclePlotPen;
        private float[] circleDiameters = new float[2], circleRadii = new float[2];

        #endregion

        #region Interface Intialization
        // Interface intiialization method
        public MainInterface() {
            Debug.WriteLine("Servo Motor Driver Starting Up...");
            InitializeComponent();
            instance = this;

            /* Start the uptime stopwatch, which records system uptime */
            uptimeSW.Start();

            /*==================================================== THREADS ====================================================*/
            // Start the communication thread to communicate with the arduino at a specified rate
            commsThread = new Thread(new ThreadStart(Communicate));
            commsThread.Start();

            /*==================================================== COMBO-BOXES ====================================================*/
            // Add the DATAMODE enums to the dropdown data mode selection box
            foreach (ControlEnums.DATAMODE dataMode in Enum.GetValues(typeof(ControlEnums.DATAMODE)))
                DataModeSelectionBox.Items.Add(ControlEnums.GetAttribute(dataMode).disp);
            DataModeSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Data Mode Selection Options");

            // Add the POSITIONUNITS enums to the dropdown position unit selection box
            foreach (ControlEnums.BASEUNITS unit in Enum.GetValues(typeof(ControlEnums.BASEUNITS)))
                CurrentPositionUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            CurrentPositionUnitSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Position Unit Selection Options");

            // Add the VELOCITYUNTIS enums to the dropdown velocity unit selection box
            foreach (ControlEnums.BASEUNITS unit in Enum.GetValues(typeof(ControlEnums.BASEUNITS)))
                CurrentVelocityUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            CurrentVelocityUnitSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Velocity Unit Selection Options");

            // Add the ACCELERATIONUNITS enums to the dropdown acceleration unit selection box
            foreach (ControlEnums.BASEUNITS unit in Enum.GetValues(typeof(ControlEnums.BASEUNITS)))
                CurrentAccelerationUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            CurrentAccelerationUnitSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Acceleration Unit Selection Options");

            // Add available COM ports to the dropdown port selection box
            COMPortSelectionBox.DataSource = SerialPort.GetPortNames();
            WriteMessage("Added COM Port Selection Options");

            /*==================================================== INITIAL VALUES ====================================================*/
            // Set NumericUpDown Bounds
            VoltageControlUpDown.Maximum = CalculateVoltageFromBinary(binaryMax);
            VoltageControlUpDown.Minimum = CalculateVoltageFromBinary(binaryMin);
            BinaryControlUpDown.Value = CalculateBinaryFromVoltage(0m);

            OutputsGroupBox.Font = new Font("Microsoft Sans-Serif", 12, FontStyle.Bold);

            // Add Circle plot stuff
            InitializeCirclePlot();
        }
        #endregion

        #region Program Loop

        // Send-Recieve method, runs every 10 ticks
        private void ProgramLoop(object sender, EventArgs e) {
            // Update variables each loop
            currentPos = decoderValue.Value;
            currentRotationPos = (Int16)(currentPos % encoderResolution);
            totalPos += (currentPos - lastPos);

            lastPos = currentPos;
            lastTotalPos = lastPos;

            // Update interface
            CurrentBinaryTextBox.Text = Communications.dacCurrentValue.ToString();
            CurrentVoltageTextBox.Text = CalculateVoltageFromBinary(Communications.dacCurrentValue).ToString();

            // Write low byte, high byte and position values to the interface
            HighByteTextBox.Text = ((byte)(decoderValue.Value >> 8)).ToString();
            LowByteTextBox.Text = ((byte)(decoderValue.Value)).ToString();
            PositionIntegerUpDown.Value = currentPos;

            // Calculate the velocity and accelertion
            CalculateVelocity();
            CalculateAcceleration();

            // Calculate current position (in deg, rad, counts or revs) and write to the interface
            CurrentPositionTextBox.Text = CalculatePositionDisplay();

            // Calculate current velocity (in deg/s, rad/s, counts/s or RPM) and write to the interface
            CurrentVelocityTextBox.Text = CalculateVelocityDisplay();

            // Calculate current acceleration (in deg/s², rad/s², counts/s² or RPM/s) and write to the interface
            CurrentAccelerationTextBox.Text = CalculateAccelerationDisplay();

            // Send data to the graphs
            if (graphingOpen && graphs != null)
                graphs.AddGraphingEntry(new GraphingEntry(uptimeSW.ElapsedMilliseconds).setVoltage((double)CalculateVoltageFromBinary(Communications.dacCurrentValue))
                                                                                       .setBinary(Communications.dacCurrentValue)
                                                                                       .setPosition(totalPos).setRotationPosition(currentRotationPos).setVelocity(velocity)
                                                                                       .setAcceleration(acceleration));
            
            // If there is a mismatch between desired binary value and the actual value on the arduino, resend the desired value.
            if (Communications.dacCurrentValue != BinaryControlUpDown.Value) {
                Communications.SendOutgoingData(Communications.cmdSetDAC, 1, new byte[] { (byte)BinaryControlUpDown.Value });
            }
            
            // Perform the PID control if the Position Control is enabled.
            if (PositionControlRadioButton.Checked) 
                PID();

            // Draw the motor visualisation circle
            drawCirclePlot();

        }

        #endregion

        #region PID Control
        // Performs the PID control.
        public void PID() {
            // Variables
            int stopPoint = CalculateBinaryFromVoltage(0m);
            errorLast = error;
            error = desiredPos - totalPos;

            double PID = 0.0;
            double dt = ProgramLoopTimer.Interval / 1000.0;

            if (Math.Abs(error) <= AllowableOffsetUpDown.Value) {
                PID = stopPoint;
                errorIntegral = 0;
                WriteMessage("Found 0 error");
            }
            else {
                // Add the error integral to the running sum.
                errorIntegral += (error * dt);

                // Limit the error integral.
                if (errorIntegral > errorIntegralMax)
                    errorIntegral = errorIntegralMax;
                if (errorIntegral < errorIntegralMin)
                    errorIntegral = errorIntegralMin;

                // Calculate the error derivative
                errorDerivative = (error - errorLast) / dt;

                // Calculate the PID value
                PID = (kp * error) + (ki * errorIntegral) + (kd * errorDerivative);

                // Publish PID term effects to interface.
                KpModifierTextBox.Text = (kp * error).ToString();
                KiModifierTextBox.Text = (ki * errorIntegral).ToString();
                KdModifierTextBox.Text = (kd * errorDerivative).ToString();

                // Convert PID from -Infinity -> +Infinity to -127 -> 127 (ish)
                if (PID > (binaryMax - stopPoint))
                    PID = binaryMax - stopPoint;
                else if (PID < (0 - stopPoint))
                    PID = 0 - stopPoint;

                // Convert PID from -127 -> 127 to 0 -> 255
                PID += stopPoint;

                // Compensate PID for deadband, so that the motor still moves when the PID value says it should.
                if (PID > DeadBandSettingsForm.min && PID < DeadBandSettingsForm.max)
                {
                    if (PID < stopPoint - 0.5)
                        PID = DeadBandSettingsForm.min;
                    if (PID > stopPoint + 0.5)
                        PID = DeadBandSettingsForm.max;
                }
            }  

            // Send the PID value to the interface and the arduino.
            if (BinaryControlUpDown.Value != BoundBinary((int)(PID)))
                BinaryControlUpDown.Value = BoundBinary((int)(PID));
            else
                Communications.SendOutgoingData(Communications.cmdSetDAC, 1, new byte[] { BoundBinary((int)(PID)) });
        }
        #endregion

        #region Threaded Methods
        // Reads from the arduino at a specified rate
        public void Communicate() {
            while (true) {
                if(SerialComPort.IsOpen) {
                    // If the data mode is DECODER, read the decoder value.
                    if (currentDataMode == ControlEnums.DATAMODE.DECODER) {
                        decoderValue = Communications.ReadDecoder();
                    }
                    if (currentDataMode != ControlEnums.DATAMODE.DECODER) {
                        decoderValue = new KeyValuePair<int, short>(0, currentPos);
                    }

                    // Send the reset command if position is not between -20000 and +20000
                    if (currentPos >= decoderResetMax) {
                        Communications.SendResetCommand();
                        lastPos = 0;
                        decoderValue = new KeyValuePair<int, short>(0, 0);
                    }
                    else if (currentPos <= decoderResetMin) {
                        Communications.SendResetCommand();
                        lastPos = 0;
                        decoderValue = new KeyValuePair<int, short>(0, 0);
                    }
                    Communications.ReadDAC();
                }
                // Run communication thread at 100Hz independent of the main interface
                Thread.Sleep(10);
            }
        }

        #endregion

        #region Interface Helper Methods
        /*==================================================== COMMUNICATIONS ====================================================*/
        // Called when the COM port selection is changed, updates COM port in use for serial communication
        private void OnComPortSelectionChanged(object sender, EventArgs e) {
            WriteMessage("COM Port selection modified, updating serial communication");
            if(COMPortSelectionBox.Items.Count > 0) {
                COMPortConnectButton.Enabled = true;
                SerialComPort.PortName = COMPortSelectionBox.SelectedItem.ToString();
            }
        }

        // Called when the Connect button is clicked. Connects the serial connection with the desired COM port.
        private void OnConnectButtonClick(object sender, EventArgs e) {
            // Ensure the selected port name is actually a COM port.
            if(SerialComPort.PortName.Length > 3) {
                Communications.TryOpenSerialCommunication(SerialComPort.PortName);
            }
            if (SerialComPort.IsOpen) {
                COMPortStatusTextBox.Text = "Connected";
                COMPortConnectButton.Enabled = false;
                COMPortDisconnectButton.Enabled = true;
                COMPortRefreshButton.Enabled = false;
                COMPortSelectionBox.Enabled = false;
            }
            else
                COMPortStatusTextBox.Text = "Failed";
        }

        // Called when the Disconnect button is clicked. Disconnects the serial connection with the desired COM port.
        private void OnDisconnectButtonClick(object sender, EventArgs e) {
            if(SerialComPort.IsOpen) {
                SerialComPort.Close();
                COMPortConnectButton.Enabled = true;
                COMPortDisconnectButton.Enabled = false;
                COMPortRefreshButton.Enabled = true;
                COMPortSelectionBox.Enabled = true;
                COMPortStatusTextBox.Text = "Disconnected";
            }
        }

        // Called when the Refresh button is clicked. Reacquires the available COM ports.
        private void OnComPortRefreshButtonClick(object sender, EventArgs e) {
            COMPortSelectionBox.DataSource = SerialPort.GetPortNames();
        }

        /*==================================================== OPERATION MODES ====================================================*/

        // Called when the data mode selection is changed, updates the current data mode
        private void OnDataModeSelectionChanged(object sender, EventArgs e) {
            foreach(ControlEnums.DATAMODE dataMode in Enum.GetValues(typeof(ControlEnums.DATAMODE))) {
                if(DataModeSelectionBox.Text == ControlEnums.GetAttribute(dataMode).disp) {
                    currentDataMode = dataMode;
                    break;
                }
            }
            WriteMessage("Selected data mode updated to " + ControlEnums.GetAttribute(currentDataMode).disp);

            if (currentDataMode == ControlEnums.DATAMODE.MANUAL) PositionIntegerUpDown.ReadOnly = false;
            else PositionIntegerUpDown.ReadOnly = true;
        }

        // Called when the position unit selection is changed
        private void OnPositionUnitSelectionChanged(object sender, EventArgs e) {
            foreach(ControlEnums.BASEUNITS unit in Enum.GetValues(typeof(ControlEnums.BASEUNITS))) {
                if (CurrentPositionUnitSelectionBox.Text == ControlEnums.GetAttribute(unit).disp) {
                    currentPositionUnit = unit;
                    break;
                }
            }
            WriteMessage("Selected Position Unit updated to " + ControlEnums.GetAttribute(currentPositionUnit).disp);
        }

        // Called when the velocity unit selection is changed
        private void OnVelocityUnitSelectionChanged(object sender, EventArgs e) {
            foreach(ControlEnums.BASEUNITS unit in Enum.GetValues(typeof(ControlEnums.BASEUNITS))) {
                if(CurrentVelocityUnitSelectionBox.Text == ControlEnums.GetAttribute(unit).disp) {
                    currentVelocityUnit = unit;
                    break;
                }
            }
            WriteMessage("Selected Velocity Unit updated to " + ControlEnums.GetAttribute(currentVelocityUnit).disp);
        }

        // Called when the acceleration unit selection is changed
        private void OnAccelerationUnitSelectionChanged(object sender, EventArgs e) {
            foreach (ControlEnums.BASEUNITS unit in Enum.GetValues(typeof(ControlEnums.BASEUNITS))) {
                if (CurrentAccelerationUnitSelectionBox.Text == ControlEnums.GetAttribute(unit).disp) {
                    currentAccelerationUnit = unit;
                    break;
                }
            }
            WriteMessage("Selected Acceleration Unit updated to " + ControlEnums.GetAttribute(currentAccelerationUnit).disp);
        }

        // Called when the mode radio buttons are clicked, enables/disables the different control modes.
        private void OnModeCheckChanged(object sender, EventArgs e) {
            BinaryControlUpDown.Enabled = false;
            VoltageControlUpDown.Enabled = false;
            PositionControlUpDown.Enabled = false;
            VelocityControlUpDown.Enabled = false;
            if (BinaryControlRadioButton.Checked)
                BinaryControlUpDown.Enabled = true;
            if (VoltageControlRadioButton.Checked)
                VoltageControlUpDown.Enabled = true;
            if (PositionControlRadioButton.Checked)
                PositionControlUpDown.Enabled = true;
            if (VelocityControlRadioButton.Checked)
                VelocityControlUpDown.Enabled = true;
        }

        /*==================================================== MENU-STRIP ====================================================*/
        // Called when the Dead Band Settings button is clicked from the context menu
        private void OnDeadBandSettingsMenuClicked(object sender, EventArgs e) {
            if (deadbandSettings == null || !deadbandSettingsOpen)
                deadbandSettings = new DeadBandSettingsForm();
            deadbandSettings.Show();
            deadbandSettings.BringToFront();
        }

        // Called when the View->Graphs menu item is clicked. Opens the Graphing form.
        private void OnGraphsMenuClicked(object sender, EventArgs e) {
            if (graphs == null || !graphingOpen)
                graphs = new GraphingForm();
            graphs.Show();
            graphs.BringToFront();
        }

        /*==================================================== NUMERIC-INPUTS ====================================================*/

        // Called when the binary output value is changed, and sends the value to the arduino
        private void OnBinaryControlValueChanged(object sender, EventArgs e) {
            RawBinaryChart.Series["Series1"].Points[0].YValues = new double[]{(double)BinaryControlUpDown.Value};
            RawBinaryChart.Update();

            byte compensated = (byte)BinaryControlUpDown.Value;
            if(DeadBandCompensationCheckBox.Checked && BinaryControlUpDown.Value > DeadBandSettingsForm.min && BinaryControlUpDown.Value < DeadBandSettingsForm.max) {
                if (BinaryControlUpDown.Value > CalculateBinaryFromVoltage(0))
                    compensated = (byte)DeadBandSettingsForm.max;
                else if (BinaryControlUpDown.Value == CalculateBinaryFromVoltage(0)) {
                    compensated = CalculateBinaryFromVoltage(0);
                }
                else compensated = (byte)DeadBandSettingsForm.min;
            }

            VoltageControlUpDown.Value = CalculateVoltageFromBinary(BinaryControlUpDown.Value);
            Communications.SendOutgoingData(Communications.cmdSetDAC, 1, new byte[] { compensated });
        }

        // Called when the voltage control up-down is changed, calculates the binary equivalent
        private void OnVoltageControlValueChanged(object sender, EventArgs e) {
            UpdateVoltageCharts(VoltageControlUpDown.Value);
            BinaryControlUpDown.Value = CalculateBinaryFromVoltage(VoltageControlUpDown.Value);
        }

        // Called when the velocity set point is changed. Updates the desired velocity.
        private void OnVelocitySetPointChanged(object sender, EventArgs e) {
            GraphingForm.velocityLineY = (double)VelocityControlUpDown.Value;
        }

        // Called when the acceleration set point is changed. Updates the max/min acceleration.
        private void OnAccelerationSetPointChanged(object sender, EventArgs e) {
            GraphingForm.accelerationLineY = (double)AccelerationControlUpDown.Value;
        }

        /*==================================================== MOTOR DATA AND CONTROL ====================================================*/

        // Called when the Stop Motor button is clicked. Stop the motor and return to binary control.
        private void OnStopButtonClick(object sender, EventArgs e) {
            BinaryControlRadioButton.Checked = true;
            if (BinaryControlUpDown.Value != CalculateBinaryFromVoltage(0m))
                BinaryControlUpDown.Value = CalculateBinaryFromVoltage(0m);
            else Communications.SendOutgoingData(Communications.cmdSetDAC, 1, new byte[] { CalculateBinaryFromVoltage(0m) });
        }

        // Called when the Full Forward button is clicked. Sends the max binary value to the motor.
        private void OnFullForwardButtonClick(object sender, EventArgs e) {
            BinaryControlUpDown.Value = binaryMax;
        }

        // Called when the Full Reverse button is clicked. Sends the minimum binary value to the motor.
        private void OnFullReverseButtonClick(object sender, EventArgs e) {
            BinaryControlUpDown.Value = binaryMin;
        }

        // Updates the graphical chart displaying the current DAC voltage value
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

        // Called when the manual position value is changed, updates the currentPos
        private void OnPositionIntegerValueChanged(object sender, EventArgs e) {
            if (currentDataMode != ControlEnums.DATAMODE.MANUAL)
                return;
            currentPos = (Int16)PositionIntegerUpDown.Value;
        }

        /*==================================================== PID CONTROL ====================================================*/

        // Called when the desired position numeric up-down is changed
        private void OnDesiredPositionChanged(object sender, EventArgs e) {
            desiredPos = (int)(PositionControlUpDown.Value);
            GraphingForm.positionLineY = (int)(PositionControlUpDown.Value);
        }

        // Called when the proportional gain value is changed. Gain is Value x10^-6
        private void OnProportionalChanged(object sender, EventArgs e) {
            kp = (double)PositionPUpDown.Value / 1000000.0;
        }

        // Called when the derivative gain value is changed. Gain is value x10^-6
        private void OnDerivativeChanged(object sender, EventArgs e) {
            kd = (double)PositionDUpDown.Value / 1000000.0;
        }

        // Called when the integral gain value is changed. Gain is value x10^-6
        private void OnIntegralChanged(object sender, EventArgs e) {
            ki = (double)PositionIUpDown.Value / 10000.0;
        }

        /*==================================================== FORM OPEN/CLOSE ====================================================*/

        // Called when the form is closed, aborts the testDataThread to prevent it from continuing
        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            commsThread.Abort();

            // Close any still-open subforms
            if (deadbandSettings != null || deadbandSettingsOpen)
                deadbandSettings.Close();
            if (graphs != null || graphingOpen)
                graphs.Close();

            if (SerialComPort.IsOpen)
                SerialComPort.Close();
        }

        #endregion

        #region Data Calculation Methods

        /*==================================================== DAC PROCESSING ====================================================*/
        // Calcultes the DAC output voltage from an input binary value
        public decimal CalculateVoltageFromBinary(decimal binary) {
            decimal voltage = dac1.gradient * binary + dac1.intercept;
            return Math.Round(voltage, 2);
            
        }

        // Calculates the DAC input binary value from an output voltage
        public byte CalculateBinaryFromVoltage(decimal voltage) {
            decimal binary = Math.Round((voltage - dac1.intercept) / dac1.gradient);
            return BoundBinary((int)Math.Round(binary));
        }

        // Ensure an integer does not exceeds the limits of a byte (0 to 255)
        public byte BoundBinary(int binary) {
            int b = binary;
            if (b > 255) b = 255;
            if (b < 5) b = 5;
            return (byte)b;
        }

        // Calculates the velocity as a moving average with a certain number of samples.
        public void CalculateVelocity()
        {

            // Ensure a position isn't being added if it hasn't changed.
            if (totalPos != lastTotalPos)
            {
                lastPositions.Add(new KeyValuePair<long, int>(totalPos, decoderValue.Key));

                // Remove the first position if the count exceeds the desired number.
                if (lastPositions.Count >= (numPositionSamples / ProgramLoopTimer.Interval))
                {
                    lastPositions.RemoveAt(0);
                    positionIndex++;
                }

                // Calculate moving average every 10 additions
                if (positionIndex >= 10)
                {
                    positionIndex = 0;

                    List<double> velocities = new List<double>();
                    // Calculate each velocity point and add to list.
                    foreach (KeyValuePair<long, int> posPair in lastPositions)
                    {
                        if (posPair.Value != 0)
                        {
                            double velocity1 = (posPair.Key - lastPosition) / (posPair.Value / 1000.0);
                            velocities.Add(velocity1);
                            lastPosition = posPair.Key;
                        }
                    }

                    double avgVelocity = 0.0;
                    // Calculate average velocity.
                    foreach (double vel in velocities)
                    {
                        avgVelocity += vel;
                    }

                    avgVelocity /= velocities.Count;
                    // Publish average velocity to global variable.
                    velocity = avgVelocity;
                }
            }
        }

        // Calculates the acceleration as a moving average with a certain number of samples.
        public void CalculateAcceleration()
        {
            lastVelocities.Add(new KeyValuePair<double, int>(velocity, decoderValue.Key));

            // Remove the first velocity if the count exceeds the desired number.
            if (lastVelocities.Count > (numVelocitySamples / ProgramLoopTimer.Interval))
            {
                lastVelocities.RemoveAt(0);
                velocityIndex++;
            }

            // Calculate moving average every 10 additions
            if (velocityIndex >= 10)
            {
                velocityIndex = 0;

                List<double> accelerations = new List<double>();
                // Calculate each acceleration point and add to list.
                foreach (KeyValuePair<double, int> velPair in lastVelocities)
                {
                    if (velPair.Value != 0)
                    {
                        double acceleration1 = (velPair.Key - lastVelocity) / (velPair.Value / 1000.0);
                        accelerations.Add(acceleration1);
                        lastVelocity = velPair.Key;
                    }

                }

                double avgAcceleration = 0.0;
                // Calculate average acceleration.
                foreach (double accel in accelerations)
                    avgAcceleration += accel;

                avgAcceleration /= accelerations.Count;
                // Publish average acceleration to global variable.
                acceleration = avgAcceleration;
            }
        }

        /*==================================================== UNIT CONVERSION ====================================================*/

        // Calculates the Position value to display for the currently selected position unit
        public string CalculatePositionDisplay() {
            if (currentPositionUnit == ControlEnums.BASEUNITS.COUNTS)
                return totalPos.ToString();
            if (currentPositionUnit == ControlEnums.BASEUNITS.DEG)
                return Math.Round((360.0 * (double)(currentRotationPos / 2000.0)), 2).ToString();
            if (currentPositionUnit == ControlEnums.BASEUNITS.RAD)
                return Math.Round(2.0 * (double)(currentRotationPos / 2000.0), 2) + " π";
            if (currentPositionUnit == ControlEnums.BASEUNITS.REVS)
                return Math.Round(((totalPos) / 2000.0), 2).ToString();
            return "0";
        }

        public string CalculateVelocityDisplay() {
            if (currentVelocityUnit == ControlEnums.BASEUNITS.COUNTS)
                return Math.Round(velocity, 2).ToString();
            if (currentVelocityUnit == ControlEnums.BASEUNITS.DEG)
                return Math.Round((360.0 * (velocity / 2000.0)), 2).ToString();
            if (currentVelocityUnit == ControlEnums.BASEUNITS.RAD)
                return Math.Round(2.0 * (velocity / 2000.0), 2) + " π/s";
            if (currentVelocityUnit == ControlEnums.BASEUNITS.REVS)
                return Math.Round(((velocity / 2000.0) * 60.0), 2).ToString();
            return "0";
        }

        public string CalculateAccelerationDisplay() {
            if (currentAccelerationUnit == ControlEnums.BASEUNITS.COUNTS)
                return Math.Round(acceleration, 2).ToString();
            if (currentAccelerationUnit == ControlEnums.BASEUNITS.DEG)
                return Math.Round((360.0 * (acceleration / 2000.0)), 2).ToString();
            if (currentAccelerationUnit == ControlEnums.BASEUNITS.RAD)
                return Math.Round(2.0 * (acceleration / 2000.0), 2) + " π/s²";
            if (currentAccelerationUnit == ControlEnums.BASEUNITS.REVS)
                return Math.Round(((acceleration / 2000.0) * 60.0), 2).ToString();
            return "0";
        }

        #endregion

        #region Data Plotting Methods
        // Sets up the properties of the motor position visualisation circle
        private void InitializeCirclePlot() {
            circlePlotSurface = new Bitmap(circlePlotPanel.ClientRectangle.Width, circlePlotPanel.ClientRectangle.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            circleBounds = new Rectangle(0, 0, circlePlotSurface.Width, circlePlotSurface.Height);
            circleBounds.Inflate(-1, -1);

            float xCenter = (float)(circleBounds.Width / 2.0);
            float yCenter = (float)(circleBounds.Height / 2.0);

            // Pen types for circle lines and position points
            circlePlotPens[0] = new Pen(Color.Red, 4);
            circlePlotPens[1] = new Pen(Color.Green, 4);
            outerCirclePlotPen = new Pen(Color.Black, 1);

            // Diameters of the 2 different circles
            circleDiameters[0] = (float)(circlePlotSurface.Width / 1.1);
            circleDiameters[1] = (float)(circlePlotSurface.Width / 1.2);

            for (int i = 0; i < 2; i++) {
                circleRadii[i] = (float)(circleDiameters[i] / 2.0);
                circleRectangles[i] = new Rectangle((int)Math.Round(xCenter - circleRadii[i]),
                    (int)Math.Round(yCenter - circleRadii[i]), (int)Math.Round(circleDiameters[i]), (int)Math.Round(circleDiameters[i]));
            }
            WriteMessage("Initialisation of circle plot complete");
        }

        // Draws the motor visualisation circle to the interface
        private void drawCirclePlot() {
            circlePlotContext = new BufferedGraphicsContext();
            circlePlotBuffer = circlePlotContext.Allocate(Graphics.FromImage(circlePlotSurface), circleBounds);
            circlePlotBuffer.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            circlePlotBuffer.Graphics.Clear(SystemColors.Control);

            float xCenter = (float)(circleBounds.Width / 2.0);
            float yCenter = (float)(circleBounds.Height / 2.0);

            circlePlotBuffer.Graphics.DrawEllipse(outerCirclePlotPen, circleRectangles[0]);
            circlePlotBuffer.Graphics.DrawEllipse(circlePlotPens[0], (float)(circleRadii[0] * Math.Cos(currentPos * 2 * Math.PI / 2000.0) + xCenter) - 2, 
                                                    (float)(-circleRadii[0] * Math.Sin(currentPos * 2 * Math.PI / 2000.0) + yCenter) - 2, 4, 4);

            circlePlotBuffer.Graphics.DrawEllipse(outerCirclePlotPen, circleRectangles[1]);
            circlePlotBuffer.Graphics.DrawEllipse(circlePlotPens[1], (float)(circleRadii[1] * Math.Cos(desiredPos * 2 * Math.PI / 2000.0) + xCenter) - 2,
                                                    (float)(-circleRadii[1] * Math.Sin(desiredPos * 2 * Math.PI / 2000.0) + yCenter) - 2, 4, 4);

            circlePlotBuffer.Render(circlePlotPanel.CreateGraphics());
            circlePlotBuffer.Dispose();
            circlePlotContext.Dispose();
        }

        #endregion

        #region Debugging
        // Writes a non-error info message to the interface and the console output
        public void WriteMessage(string message) {
            Debug.WriteLine("\t" + message);
            MessageLogStatusStrip.Text = message;
        }

        // Writes an error message to the interface and the console output
        public void WriteError(string message) {
            Debug.WriteLine("\t[ERROR] " + message);
            MessageLogStatusStrip.Text = message;
        }
        #endregion

    }
}
