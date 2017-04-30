using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace ServoMotorDriver {
    public partial class MainInterface : Form {
        public static MainInterface instance;
        public static bool deadbandSettingsOpen = false;
        public static bool testDataSettingsOpen = false;
        public static bool realtimeDataSettingsOpen = false;
        public static bool graphingOpen = false;

        #region Variables and Control/Communication Properties
        // Tuning and Deadband Variables
        public decimal binaryMax = 255, binaryMin = 5;

        // Decoder Position Variables
        public Int16 currentPos = 0;
        public int currentPosAtomic = 0;
        public int currentRotationPos = 0;
        public Int64 totalPos = 0;
        public Int64 totalPosAtomic = 0;

        // Velocity Variables
        public double velocity = 0;

        // Acceleration variables
        public double acceleration = 0;

        // Desired postion variables
        public int desiredPos = 0;
        public int desiredRotationPos = 0;

        // Circle Plot Variables
        private BufferedGraphicsContext circlePlotContext;
        private BufferedGraphics circlePlotBuffer;
        private Bitmap circlePlotSurface;
        private Rectangle[] circleRectangles = new Rectangle[2];
        private Rectangle circleBounds;
        private Pen[] circlePlotPens = new Pen[2];
        private Pen outerCirclePlotPen;
        private float[] circleDiameters = new float[2], circleRadii = new float[2];

        // Stopwatches for determinining elapsed times
        Stopwatch uptimeSW = new Stopwatch();
        Random rand = new Random();

        // Enums for current selected modes of operation
        ControlEnums.MODE currentMode = ControlEnums.MODE.FREESPIN;
        ControlEnums.DATAMODE currentDataMode = ControlEnums.DATAMODE.DECODER;
        ControlEnums.POSITIONUNITS currentPositionUnit = ControlEnums.POSITIONUNITS.COUNTS;
        ControlEnums.VELOCITYUNITS currentVelocityUnit = ControlEnums.VELOCITYUNITS.COUNTS;
        ControlEnums.ACCELERATIONUNITS currentAccelerationUnit = ControlEnums.ACCELERATIONUNITS.COUNTS;

        // DAC Object, stores Binary <> Voltage Gradient and Intercept
        private DAC dac1 = new DAC(0.1206m, -15.697m);

        // Threading
        Thread testDataThread;
        Thread velocityThread;
        Thread accelerationThread;
        Thread plottingThread;

        // Sub-Forms
        TestDataSettingsForm testDataSettings = null;
        DeadBandSettingsForm deadbandSettings = null;
        RealtimeDataSettingsForm realtimeDataSettings = null;
        GraphingForm graphs = null;

        #endregion

        #region Interface Intialization
        // Interface intiialization method
        public MainInterface() {
            Debug.WriteLine("Servo Motor Driver Starting Up...");
            InitializeComponent();
            instance = this;

            uptimeSW.Start();

            // Start the test data thread to incremement data without affecting GUI performance
            testDataThread = new Thread(new ThreadStart(IncrementTestData));
            testDataThread.Start();

            // Start the velocity sampling thread
            velocityThread = new Thread(new ThreadStart(CalculateVelocity));
            velocityThread.Start();

            // Start the acceleration sampling thread
            accelerationThread = new Thread(new ThreadStart(CalculateAcceleration));
            accelerationThread.Start();

            plottingThread = new Thread(new ThreadStart(PlotData));
            plottingThread.Start();

            // Add the MODE enums to the dropdown mode selection box
            foreach (ControlEnums.MODE mode in Enum.GetValues(typeof(ControlEnums.MODE)))
                ModeSelectionBox.Items.Add(ControlEnums.GetAttribute(mode).disp);
            ModeSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Mode Selection Options");

            // Add the DATAMODE enums to the dropdown data mode selection box
            foreach(ControlEnums.DATAMODE dataMode in Enum.GetValues(typeof(ControlEnums.DATAMODE)))
                DataModeSelectionBox.Items.Add(ControlEnums.GetAttribute(dataMode).disp);
            DataModeSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Data Mode Selection Options");

            // Add the POSITIONUNITS enums to the dropdown position unit selection box
            foreach (ControlEnums.POSITIONUNITS unit in Enum.GetValues(typeof(ControlEnums.POSITIONUNITS)))
                CurrentPositionUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            CurrentPositionUnitSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Position Unit Selection Options");

            // Add the VELOCITYUNTIS enums to the dropdown velocity unit selection box
            foreach (ControlEnums.VELOCITYUNITS unit in Enum.GetValues(typeof(ControlEnums.VELOCITYUNITS)))
                CurrentVelocityUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            CurrentVelocityUnitSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Velocity Unit Selection Options");

            // Add the ACCELERATIONUNITS enums to the dropdown acceleration unit selection box
            foreach (ControlEnums.ACCELERATIONUNITS unit in Enum.GetValues(typeof(ControlEnums.ACCELERATIONUNITS)))
                CurrentAccelerationUnitSelectionBox.Items.Add(ControlEnums.GetAttribute(unit).disp);
            CurrentAccelerationUnitSelectionBox.SelectedIndex = 0;
            WriteMessage("Added Acceleration Unit Selection Options");

            // Add available COM ports to the dropdown port selection box
            ComPortSelectionBox.DataSource = SerialPort.GetPortNames();
            WriteMessage("Added COM Port Selection Options");

            // Establish connection using selected COM port
            if (ComPortSelectionBox.Items.Count > 0)
                Communications.TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString());
            else WriteError("No Available COM Ports");

            // Set NumericUpDown Bounds
            VoltageControlVoltageUpDown.Maximum = CalculateVoltageFromBinary(binaryMax);
            VoltageControlVoltageUpDown.Minimum = CalculateVoltageFromBinary(binaryMin);

            // Add Circle plot stuff
            InitializeCirclePlot();
        }

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

        #endregion

        #region Program Loop

        // Send-Recieve method, runs every 10 ticks
        private void ProgramLoop(object sender, EventArgs e) {
            if (!SerialComPort.IsOpen && ComPortSelectionBox.Items.Count > 0)
                Communications.TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString());

            // Modify current position dependent on current data mode
            if (currentDataMode == ControlEnums.DATAMODE.DECODER)
                Communications.ReadIncomingData();
            if (currentDataMode == ControlEnums.DATAMODE.TEST || currentDataMode == ControlEnums.DATAMODE.TESTRAND)
                currentPos = (Int16)currentPosAtomic;

            // Calculate low and high bytes if not in decoder mode
            if (currentDataMode != ControlEnums.DATAMODE.DECODER) {
                Communications.decoderHigh = (byte)(currentPos >> 8);
                Communications.decoderLow = (byte)(currentPos);
            }

            // Assemble 2 bytes into 16bit integer and determine current rotation position
            currentPos = (Int16)((Communications.decoderHigh << 8) | Communications.decoderLow);
            currentRotationPos = (Int16)(currentPos % 2000);

            if (currentPos >= 20000 || currentPos <= -20000) {
                Communications.SendResetCommand();
                totalPosAtomic += currentPos;
            }

            // Reset currentPos after 10 rotations in either direction
            if (currentDataMode != ControlEnums.DATAMODE.DECODER && (currentPos >= 20000 || currentPos <= -20000)) {
                totalPos += currentPos;
                currentPos = 0;
            }
            totalPos = totalPosAtomic;

            // Write low byte, high byte and position values to the interface
            HighByteTextBox.Text = Communications.decoderHigh.ToString();
            LowByteTextBox.Text = Communications.decoderLow.ToString();
            PositionIntegerUpDown.Value = currentPos;

            // Calculate current position (in deg, rad, counts or revs) and write to the interface
            CurrentPositionTextBox.Text = CalculatePositionDisplay();

            // Calculate current velocity (in deg/s, rad/s, counts/s or RPM) and write to the interface
            CurrentVelocityTextBox.Text = CalculateVelocityDisplay();

            // Calculate current acceleration (in deg/s², rad/s², counts/s² or RPM/s) and write to the interface
            CurrentAccelerationTextBox.Text = CalculateAccelerationDisplay();

            // Send data to the graphs


            // Draw the motor visualisation circle
            drawCirclePlot();

            /*

            currentRotationPos = (Int16)(currentPos % 2000);

            textBox1.Text = decoderHigh.ToString();
            textBox2.Text = decoderLow.ToString();
            textBox3.Text = ((Int16)((decoderHigh << 8) | decoderLow)).ToString();

            AddPositionPointToChart((double)uptimeSW.ElapsedMilliseconds, Double.Parse(textBox3.Text));

            if(positionPoints.Count > 4) {
                List<DataPoint> pastPositionPoints = GetPastPositionPoints(5);
                double overallPositionChange = 0;

                for(int i = 0; i < pastPositionPoints.Count - 2; i++) {
                    overallPositionChange += pastPositionPoints[i + 1].YValues[0] - pastPositionPoints[i].YValues[0];
                }

                double velocity = overallPositionChange / (pastPositionPoints[pastPositionPoints.Count - 1].XValue - pastPositionPoints[0].XValue);
                AddVelocityPointToChart((double)uptimeSW.ElapsedMilliseconds, velocity);
            }

            if(velocityPoints.Count > 4) {
                List<DataPoint> pastVelocityPoints = GetPastVelocityPoints(5);
                double overallVelocityChange = 0;

                for(int i = 0; i < pastVelocityPoints.Count - 2; i++) {
                    overallVelocityChange += pastVelocityPoints[i + 1].YValues[0] - pastVelocityPoints[i].YValues[0];
                }
                double acceleration = overallVelocityChange / (pastVelocityPoints[pastVelocityPoints.Count - 1].XValue - pastVelocityPoints[0].XValue);
                AddAccelerationPointToChart((double)uptimeSW.ElapsedMilliseconds, acceleration);
            }

            SetChartXAxesMaximums();
            chart1.Update();
            chart2.Update();
            chart3.Update();

            drawCirclePlot();

            */
        }

        #endregion

        #region Threaded Methods
        // Increments the test data (with randomness if in random mode). Runs in a separate thread.
        public void IncrementTestData() {
            Stopwatch uptimeSW = Stopwatch.StartNew();
            long currentUptime = uptimeSW.ElapsedMilliseconds;

            while (true) {
                while (currentDataMode == ControlEnums.DATAMODE.TEST || currentDataMode == ControlEnums.DATAMODE.TESTRAND) {
                    if (uptimeSW.ElapsedMilliseconds - currentUptime >= TestDataSettingsForm.interval) {
                        currentUptime = uptimeSW.ElapsedMilliseconds;

                        if (currentDataMode == ControlEnums.DATAMODE.TESTRAND)
                            Interlocked.Add(ref currentPosAtomic, rand.Next(TestDataSettingsForm.randMinIncrement, TestDataSettingsForm.randMaxIncrement));
                        else Interlocked.Add(ref currentPosAtomic, TestDataSettingsForm.increment);

                        if(currentPosAtomic >= 20000) {
                            Interlocked.Exchange(ref currentPosAtomic, 0);
                            Interlocked.Add(ref totalPosAtomic, 20000);
                        }
                        if(currentPosAtomic <= -20000) {
                            Interlocked.Exchange(ref currentPosAtomic, 0);
                            Interlocked.Add(ref totalPosAtomic, -20000);
                        }
                    }
                }
            }
        }

        // Calculates the velocity over a certain number of samples (and sample-period). Runs in a separate thread to more easily configure sample period
        public void CalculateVelocity() {
            Stopwatch positionSW = Stopwatch.StartNew();
            List<Int64> lastPositions = new List<Int64>();
            int lastPositionsIndex = 0;

            while(true) {
                lastPositions.Insert(lastPositionsIndex, totalPos + currentPos);
                lastPositionsIndex++;
                if (lastPositionsIndex >= RealtimeDataSettingsForm.velocitySamples) {
                    lastPositionsIndex = 0;
                    positionSW.Stop();

                    //double avgPositionChange = (lastPositions[RealtimeDataSettingsForm.velocitySamples - 1] - lastPositions[0]) / (double)RealtimeDataSettingsForm.velocitySamples;
                    double avgPositionChange = 0.0;
                    for (int i = 0; i < RealtimeDataSettingsForm.velocitySamples - 1; i++ ) {
                        avgPositionChange += lastPositions[i+1] - lastPositions[i];
                    }
                    avgPositionChange /= (double)RealtimeDataSettingsForm.velocitySamples;

                    Interlocked.Exchange(ref velocity, avgPositionChange * RealtimeDataSettingsForm.velocitySamples / (positionSW.ElapsedMilliseconds / 1000.0));
                    positionSW.Restart();
                }
                Thread.Sleep(RealtimeDataSettingsForm.velocityPeriod);
            }
        }

        public void CalculateAcceleration() {
            Stopwatch accelerationSW = Stopwatch.StartNew();
            List<Double> lastVelocities = new List<Double>();
            int lastVelocitiesIndex = 0;

            while(true) {
                lastVelocities.Insert(lastVelocitiesIndex, velocity);
                lastVelocitiesIndex++;
                if(lastVelocitiesIndex >= RealtimeDataSettingsForm.accelerationSamples) {
                    lastVelocitiesIndex = 0;
                    accelerationSW.Stop();
                    //double avgVelocityChange = (lastVelocities[RealtimeDataSettingsForm.accelerationSamples - 1] - lastVelocities[0]) / (double)RealtimeDataSettingsForm.accelerationSamples;
                    double avgVelocityChange = 0.0;
                    for (int i = 0; i < RealtimeDataSettingsForm.accelerationSamples - 1; i++ ){
                        avgVelocityChange += lastVelocities[i+1] - lastVelocities[i];
                    }
                    avgVelocityChange /= (double)RealtimeDataSettingsForm.accelerationSamples;

                    Interlocked.Exchange(ref acceleration, avgVelocityChange * RealtimeDataSettingsForm.accelerationSamples / (accelerationSW.ElapsedMilliseconds / 1000.0));
                    accelerationSW.Restart();
                }
                Thread.Sleep(RealtimeDataSettingsForm.accelerationPeriod);
            }
        }

        public void PlotData() {
            while(true) {
                if (graphingOpen && graphs != null)
                    graphs.AddGraphingEntry(new GraphingDataEntry(uptimeSW.ElapsedMilliseconds).setVoltage((double)CalculateVoltageFromBinary(Communications.dacCurrentValue))
                                                                                           .setBinary(Communications.dacCurrentValue)
                                                                                           .setPosition(totalPos + currentPos).setRotationPosition(currentRotationPos).setVelocity(velocity)
                                                                                           .setAcceleration(acceleration));
                Thread.Sleep(33); 
            }
        }

        #endregion

        #region Interface Helper Methods

        // Called when the COM port selection is changed, updates COM port in use for serial communication
        private void OnComPortSelectionChanged(object sender, EventArgs e) {
            WriteMessage("COM Port selection modified, updating serial communication");
            Communications.TryOpenSerialCommunication(ComPortSelectionBox.SelectedItem.ToString(), true);
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
        }

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
            foreach(ControlEnums.POSITIONUNITS unit in Enum.GetValues(typeof(ControlEnums.POSITIONUNITS))) {
                if (CurrentPositionUnitSelectionBox.Text == ControlEnums.GetAttribute(unit).disp) {
                    currentPositionUnit = unit;
                    break;
                }
            }
            WriteMessage("Selected Position Unit updated to " + ControlEnums.GetAttribute(currentPositionUnit).disp);
        }

        // Called when the velocity unit selection is changed
        private void OnVelocityUnitSelectionChanged(object sender, EventArgs e) {
            foreach(ControlEnums.VELOCITYUNITS unit in Enum.GetValues(typeof(ControlEnums.VELOCITYUNITS))) {
                if(CurrentVelocityUnitSelectionBox.Text == ControlEnums.GetAttribute(unit).disp) {
                    currentVelocityUnit = unit;
                    break;
                }
            }
            WriteMessage("Selected Velocity Unit updated to " + ControlEnums.GetAttribute(currentVelocityUnit).disp);
        }

        // Called when the acceleration unit selection is changed
        private void OnAccelerationUnitSelectionChanged(object sender, EventArgs e) {
            foreach (ControlEnums.ACCELERATIONUNITS unit in Enum.GetValues(typeof(ControlEnums.ACCELERATIONUNITS))) {
                if (CurrentAccelerationUnitSelectionBox.Text == ControlEnums.GetAttribute(unit).disp) {
                    currentAccelerationUnit = unit;
                    break;
                }
            }
            WriteMessage("Selected Acceleration Unit updated to " + ControlEnums.GetAttribute(currentAccelerationUnit).disp);
        }

        // Called when the binary output value is changed, and sends the value to the arduino
        private void OnRawControlValueChanged(object sender, EventArgs e) {
            RawBinaryChart.Series["Series1"].Points[0].YValues = new double[]{(double)RawControlUpDown.Value};
            RawBinaryChart.Update();

            byte compensated = (byte)RawControlUpDown.Value;
            if(DeadBandCompensationCheckBox.Checked && RawControlUpDown.Value > DeadBandSettingsForm.min && RawControlUpDown.Value < DeadBandSettingsForm.max) {
                if (RawControlUpDown.Value > CalculateBinaryFromVoltage(0))
                    compensated = (byte)DeadBandSettingsForm.max;
                else if (RawControlUpDown.Value == CalculateBinaryFromVoltage(0)) {
                    compensated = CalculateBinaryFromVoltage(0);
                }
                else compensated = (byte)DeadBandSettingsForm.min;
            }

            VoltageControlVoltageUpDown.Value = CalculateVoltageFromBinary(RawControlUpDown.Value);
            Communications.SendOutgoingData(Communications.DACPort, compensated);
            RawVoltageTextBox.Text = CalculateVoltageFromBinary(compensated).ToString();
        }

        // Called when the voltage control up-down is changed, calculates the binary equivalent
        private void OnVoltageControlValueChanged(object sender, EventArgs e) {
            UpdateVoltageCharts(VoltageControlVoltageUpDown.Value);
            RawControlUpDown.Value = CalculateBinaryFromVoltage(VoltageControlVoltageUpDown.Value);
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

        // Called when the Test Data Settings button is clicked from the context menu
        private void OnTestDataSettingsMenuClick(object sender, EventArgs e) {
            if(testDataSettings == null || !testDataSettingsOpen)
                testDataSettings = new TestDataSettingsForm();
            testDataSettings.Show();
            testDataSettings.BringToFront();
        }

        // Called when the Dead Band Settings button is clicked from the context menu
        private void OnDeadBandSettingsMenuClicked(object sender, EventArgs e) {
            if(deadbandSettings == null || !deadbandSettingsOpen)
                deadbandSettings = new DeadBandSettingsForm();
            deadbandSettings.Show();
            deadbandSettings.BringToFront();
        }

        private void OnRealtimeDataSettingsMenuClicked(object sender, EventArgs e) {
            if (realtimeDataSettings == null || !realtimeDataSettingsOpen)
                realtimeDataSettings = new RealtimeDataSettingsForm();
            realtimeDataSettings.Show();
            realtimeDataSettings.BringToFront();
        }

        private void OnGraphsMenuClicked(object sender, EventArgs e) {
            if (graphs == null || !graphingOpen)
                graphs = new GraphingForm();
            graphs.Show();
            graphs.BringToFront();
        }

        // Called when the form is closed, aborts the testDataThread to prevent it from continuing
        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            testDataThread.Abort();
            velocityThread.Abort();
            accelerationThread.Abort();
            plottingThread.Abort();

            // Close any still-open subforms
            if(testDataSettings != null || testDataSettingsOpen)
                testDataSettings.Close();
            if (deadbandSettings != null || deadbandSettingsOpen)
                deadbandSettings.Close();
            if (realtimeDataSettings != null || realtimeDataSettingsOpen)
                realtimeDataSettings.Close();
            if (graphs != null || graphingOpen)
                graphs.Close();
        }

        #endregion

        #region Data Calculation Methods
        // Calcultes the DAC output voltage from an input binary value
        public decimal CalculateVoltageFromBinary(decimal binary) {
            decimal voltage = dac1.gradient * binary + dac1.intercept;
            return Math.Round(voltage, 2);
        }

        // Calculates the DAC input binary value from an output voltage
        public byte CalculateBinaryFromVoltage(decimal voltage) {
            decimal binary = Math.Round((voltage - dac1.intercept) / dac1.gradient);
            if (binary > 255) binary = 255;
            if (binary < 5) binary = 5;
            return (byte)Math.Round(binary);
        }

        // Calculates the Position value to display for the currently selected position unit
        public string CalculatePositionDisplay() {
            if (currentPositionUnit == ControlEnums.POSITIONUNITS.COUNTS)
                return (totalPos + currentPos).ToString();
            if (currentPositionUnit == ControlEnums.POSITIONUNITS.DEG)
                return Math.Round((360.0 * (double)(currentRotationPos / 2000.0)), 2).ToString();
            if (currentPositionUnit == ControlEnums.POSITIONUNITS.RAD)
                return Math.Round(2.0 * (double)(currentRotationPos / 2000.0), 2) + " π";
            if (currentPositionUnit == ControlEnums.POSITIONUNITS.REVS)
                return Math.Round(((totalPos + currentPos) / 2000.0), 2).ToString();
            return "0";
        }

        public string CalculateVelocityDisplay() {
            if (currentVelocityUnit == ControlEnums.VELOCITYUNITS.COUNTS)
                return Math.Round(velocity, 2).ToString();
            if (currentVelocityUnit == ControlEnums.VELOCITYUNITS.DEG)
                return Math.Round((360.0 * (velocity / 2000.0)), 2).ToString();
            if (currentVelocityUnit == ControlEnums.VELOCITYUNITS.RAD)
                return Math.Round(2.0 * (velocity / 2000.0), 2) + " π/s";
            if (currentVelocityUnit == ControlEnums.VELOCITYUNITS.RPM)
                return Math.Round(((velocity / 2000.0) * 60.0), 2).ToString();
            return "0";
        }

        public string CalculateAccelerationDisplay() {
            if (currentAccelerationUnit == ControlEnums.ACCELERATIONUNITS.COUNTS)
                return Math.Round(acceleration, 2).ToString();
            if (currentAccelerationUnit == ControlEnums.ACCELERATIONUNITS.DEG)
                return Math.Round((360.0 * (acceleration / 2000.0)), 2).ToString();
            if (currentAccelerationUnit == ControlEnums.ACCELERATIONUNITS.RAD)
                return Math.Round(2.0 * (acceleration / 2000.0), 2) + " π/s²";
            if (currentAccelerationUnit == ControlEnums.ACCELERATIONUNITS.RPM)
                return Math.Round(((acceleration / 2000.0) * 60.0), 2).ToString();
            return "0";
        }
        #endregion

        #region Data Plotting Methods
        // Draws the motor visualisation circle to the interface
        private void drawCirclePlot() {
            circlePlotContext = new BufferedGraphicsContext();
            circlePlotBuffer = circlePlotContext.Allocate(Graphics.FromImage(circlePlotSurface), circleBounds);
            circlePlotBuffer.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            circlePlotBuffer.Graphics.Clear(SystemColors.Control);

            float xCenter = (float)(circleBounds.Width / 2.0);
            float yCenter = (float)(circleBounds.Height / 2.0);

            circlePlotBuffer.Graphics.DrawEllipse(outerCirclePlotPen, circleRectangles[0]);
            circlePlotBuffer.Graphics.DrawEllipse(circlePlotPens[0], (float)(circleRadii[0] * Math.Cos(currentRotationPos * 2 * Math.PI / 2000.0) + xCenter) - 2, 
                                                    (float)(-circleRadii[0] * Math.Sin(currentRotationPos * 2 * Math.PI / 2000.0) + yCenter) - 2, 4, 4);

            circlePlotBuffer.Graphics.DrawEllipse(outerCirclePlotPen, circleRectangles[1]);
            circlePlotBuffer.Graphics.DrawEllipse(circlePlotPens[1], (float)(circleRadii[1] * Math.Cos(desiredRotationPos * 2 * Math.PI / 2000.0) + xCenter) - 2,
                                                    (float)(-circleRadii[1] * Math.Sin(desiredRotationPos * 2 * Math.PI / 2000.0) + yCenter) - 2, 4, 4);

            circlePlotBuffer.Render(circlePlotPanel.CreateGraphics());
            circlePlotBuffer.Dispose();
            circlePlotContext.Dispose();
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
