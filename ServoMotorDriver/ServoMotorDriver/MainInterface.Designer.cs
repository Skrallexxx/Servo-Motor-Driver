namespace ServoMotorDriver
{
    partial class MainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.SerialComPort = new System.IO.Ports.SerialPort(this.components);
            this.ProgramLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.COMPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MessageLogStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.COMPortRefreshButton = new System.Windows.Forms.Button();
            this.COMPortStatusTextBox = new System.Windows.Forms.TextBox();
            this.COMPortDisconnectButton = new System.Windows.Forms.Button();
            this.COMPortConnectButton = new System.Windows.Forms.Button();
            this.OutputsGroupBox = new System.Windows.Forms.GroupBox();
            this.VoltageControlPositiveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VoltageControlNegativeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.AccelerationControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AllowableOffsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PositionPUpDown = new System.Windows.Forms.NumericUpDown();
            this.PLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.PositionDUpDown = new System.Windows.Forms.NumericUpDown();
            this.PositionIUpDown = new System.Windows.Forms.NumericUpDown();
            this.DLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeadBandCompensationCheckBox = new System.Windows.Forms.CheckBox();
            this.VelocityControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.RawBinaryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VelocityControlRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionControlRadioButton = new System.Windows.Forms.RadioButton();
            this.VoltageControlRadioButton = new System.Windows.Forms.RadioButton();
            this.BinaryControlRadioButton = new System.Windows.Forms.RadioButton();
            this.BinaryControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.VoltageControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.PositionControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.circlePlotPanel = new System.Windows.Forms.Panel();
            this.IncomingDataGroupBox = new System.Windows.Forms.GroupBox();
            this.DataModeLabel = new System.Windows.Forms.Label();
            this.DataModeSelectionBox = new System.Windows.Forms.ComboBox();
            this.IncomingByteGroupBox = new System.Windows.Forms.GroupBox();
            this.LowByteTextBox = new System.Windows.Forms.TextBox();
            this.HighByteTextBox = new System.Windows.Forms.TextBox();
            this.PositionIntegerLabel = new System.Windows.Forms.Label();
            this.HighByteLabel = new System.Windows.Forms.Label();
            this.PositionIntegerUpDown = new System.Windows.Forms.NumericUpDown();
            this.LowByteLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realtimeDataSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadBandSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MotorDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentVoltageTextBox = new System.Windows.Forms.TextBox();
            this.CurrentBinaryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CurrentAccelerationUnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.CurrentAccelerationTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CurrentVelocityUnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentPositionUnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.CurrentVelocityTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPositionTextBox = new System.Windows.Forms.TextBox();
            this.StatusStrip.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.OutputsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlPositiveChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlNegativeChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationControlUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowableOffsetUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionPUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityControlUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawBinaryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryControlUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionControlUpDown)).BeginInit();
            this.IncomingDataGroupBox.SuspendLayout();
            this.IncomingByteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIntegerUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.MotorDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialComPort
            // 
            this.SerialComPort.BaudRate = 115200;
            // 
            // ProgramLoopTimer
            // 
            this.ProgramLoopTimer.Enabled = true;
            this.ProgramLoopTimer.Interval = 25;
            this.ProgramLoopTimer.Tick += new System.EventHandler(this.ProgramLoop);
            // 
            // COMPortSelectionBox
            // 
            this.COMPortSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPortSelectionBox.FormattingEnabled = true;
            this.COMPortSelectionBox.Location = new System.Drawing.Point(65, 16);
            this.COMPortSelectionBox.Name = "COMPortSelectionBox";
            this.COMPortSelectionBox.Size = new System.Drawing.Size(173, 21);
            this.COMPortSelectionBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.COMPortSelectionBox, "The COM port to use for communication with the microcontroller");
            this.COMPortSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnComPortSelectionChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLogStatusStrip});
            this.StatusStrip.Location = new System.Drawing.Point(0, 492);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(730, 22);
            this.StatusStrip.TabIndex = 1;
            // 
            // MessageLogStatusStrip
            // 
            this.MessageLogStatusStrip.Name = "MessageLogStatusStrip";
            this.MessageLogStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPortLabel.Location = new System.Drawing.Point(6, 19);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(53, 13);
            this.ComPortLabel.TabIndex = 6;
            this.ComPortLabel.Text = "COM Port";
            this.toolTip1.SetToolTip(this.ComPortLabel, "The COM port to use for communication with the microcontroller");
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Controls.Add(this.COMPortRefreshButton);
            this.ConfigurationGroupBox.Controls.Add(this.COMPortStatusTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.COMPortDisconnectButton);
            this.ConfigurationGroupBox.Controls.Add(this.COMPortConnectButton);
            this.ConfigurationGroupBox.Controls.Add(this.ComPortLabel);
            this.ConfigurationGroupBox.Controls.Add(this.COMPortSelectionBox);
            this.ConfigurationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(12, 27);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(273, 72);
            this.ConfigurationGroupBox.TabIndex = 9;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Comms Configuration";
            // 
            // COMPortRefreshButton
            // 
            this.COMPortRefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPortRefreshButton.Image = global::ServoMotorDriver.Properties.Resources.Refresh_icon_14x14;
            this.COMPortRefreshButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.COMPortRefreshButton.Location = new System.Drawing.Point(244, 16);
            this.COMPortRefreshButton.Name = "COMPortRefreshButton";
            this.COMPortRefreshButton.Size = new System.Drawing.Size(23, 23);
            this.COMPortRefreshButton.TabIndex = 22;
            this.COMPortRefreshButton.UseVisualStyleBackColor = true;
            this.COMPortRefreshButton.Click += new System.EventHandler(this.OnComPortRefreshButtonClick);
            // 
            // COMPortStatusTextBox
            // 
            this.COMPortStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPortStatusTextBox.Location = new System.Drawing.Point(168, 45);
            this.COMPortStatusTextBox.Name = "COMPortStatusTextBox";
            this.COMPortStatusTextBox.ReadOnly = true;
            this.COMPortStatusTextBox.Size = new System.Drawing.Size(99, 20);
            this.COMPortStatusTextBox.TabIndex = 21;
            this.COMPortStatusTextBox.Text = "Disconnected";
            this.COMPortStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COMPortDisconnectButton
            // 
            this.COMPortDisconnectButton.Enabled = false;
            this.COMPortDisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPortDisconnectButton.Location = new System.Drawing.Point(87, 43);
            this.COMPortDisconnectButton.Name = "COMPortDisconnectButton";
            this.COMPortDisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.COMPortDisconnectButton.TabIndex = 20;
            this.COMPortDisconnectButton.Text = "Disconnect";
            this.COMPortDisconnectButton.UseVisualStyleBackColor = true;
            this.COMPortDisconnectButton.Click += new System.EventHandler(this.OnDisconnectButtonClick);
            // 
            // COMPortConnectButton
            // 
            this.COMPortConnectButton.Enabled = false;
            this.COMPortConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPortConnectButton.Location = new System.Drawing.Point(6, 43);
            this.COMPortConnectButton.Name = "COMPortConnectButton";
            this.COMPortConnectButton.Size = new System.Drawing.Size(75, 23);
            this.COMPortConnectButton.TabIndex = 7;
            this.COMPortConnectButton.Text = "Connect";
            this.COMPortConnectButton.UseVisualStyleBackColor = true;
            this.COMPortConnectButton.Click += new System.EventHandler(this.OnConnectButtonClick);
            // 
            // OutputsGroupBox
            // 
            this.OutputsGroupBox.Controls.Add(this.VoltageControlPositiveChart);
            this.OutputsGroupBox.Controls.Add(this.VoltageControlNegativeChart);
            this.OutputsGroupBox.Controls.Add(this.comboBox2);
            this.OutputsGroupBox.Controls.Add(this.comboBox1);
            this.OutputsGroupBox.Controls.Add(this.groupBox1);
            this.OutputsGroupBox.Controls.Add(this.VelocityControlUpDown);
            this.OutputsGroupBox.Controls.Add(this.RawBinaryChart);
            this.OutputsGroupBox.Controls.Add(this.VelocityControlRadioButton);
            this.OutputsGroupBox.Controls.Add(this.PositionControlRadioButton);
            this.OutputsGroupBox.Controls.Add(this.VoltageControlRadioButton);
            this.OutputsGroupBox.Controls.Add(this.BinaryControlRadioButton);
            this.OutputsGroupBox.Controls.Add(this.BinaryControlUpDown);
            this.OutputsGroupBox.Controls.Add(this.VoltageControlUpDown);
            this.OutputsGroupBox.Controls.Add(this.PositionControlUpDown);
            this.OutputsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputsGroupBox.Location = new System.Drawing.Point(12, 217);
            this.OutputsGroupBox.Name = "OutputsGroupBox";
            this.OutputsGroupBox.Size = new System.Drawing.Size(707, 264);
            this.OutputsGroupBox.TabIndex = 10;
            this.OutputsGroupBox.TabStop = false;
            this.OutputsGroupBox.Text = "Outputs";
            // 
            // VoltageControlPositiveChart
            // 
            this.VoltageControlPositiveChart.BackColor = System.Drawing.SystemColors.Control;
            this.VoltageControlPositiveChart.BorderlineColor = System.Drawing.SystemColors.ControlText;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.Maximum = 16D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 100F;
            chartArea4.Position.Width = 100F;
            this.VoltageControlPositiveChart.ChartAreas.Add(chartArea4);
            this.VoltageControlPositiveChart.Location = new System.Drawing.Point(114, 137);
            this.VoltageControlPositiveChart.Name = "VoltageControlPositiveChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Name = "Series1";
            series4.Points.Add(dataPoint4);
            this.VoltageControlPositiveChart.Series.Add(series4);
            this.VoltageControlPositiveChart.Size = new System.Drawing.Size(111, 20);
            this.VoltageControlPositiveChart.TabIndex = 25;
            this.VoltageControlPositiveChart.Text = "chart1";
            // 
            // VoltageControlNegativeChart
            // 
            this.VoltageControlNegativeChart.BackColor = System.Drawing.SystemColors.Control;
            this.VoltageControlNegativeChart.BorderlineColor = System.Drawing.SystemColors.ControlText;
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY.IsReversed = true;
            chartArea5.AxisY.Maximum = 16D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.BackColor = System.Drawing.SystemColors.Control;
            chartArea5.Name = "ChartArea1";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 100F;
            chartArea5.Position.Width = 100F;
            this.VoltageControlNegativeChart.ChartAreas.Add(chartArea5);
            this.VoltageControlNegativeChart.Location = new System.Drawing.Point(6, 137);
            this.VoltageControlNegativeChart.Name = "VoltageControlNegativeChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Name = "Series1";
            dataPoint5.Color = System.Drawing.Color.Red;
            series5.Points.Add(dataPoint5);
            this.VoltageControlNegativeChart.Series.Add(series5);
            this.VoltageControlNegativeChart.Size = new System.Drawing.Size(111, 20);
            this.VoltageControlNegativeChart.TabIndex = 27;
            this.VoltageControlNegativeChart.Text = "chart2";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(132, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(228, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 236);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.AccelerationControlUpDown);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.AllowableOffsetUpDown);
            this.groupBox4.Location = new System.Drawing.Point(162, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 128);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(201, 62);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(96, 21);
            this.comboBox4.TabIndex = 15;
            // 
            // AccelerationControlUpDown
            // 
            this.AccelerationControlUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.AccelerationControlUpDown.Location = new System.Drawing.Point(98, 63);
            this.AccelerationControlUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.AccelerationControlUpDown.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.AccelerationControlUpDown.Name = "AccelerationControlUpDown";
            this.AccelerationControlUpDown.Size = new System.Drawing.Size(97, 20);
            this.AccelerationControlUpDown.TabIndex = 13;
            this.AccelerationControlUpDown.ValueChanged += new System.EventHandler(this.OnAccelerationSetPointChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 26);
            this.label13.TabIndex = 14;
            this.label13.Text = "Max Absolute \r\nAcceleration:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(201, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(96, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allowable Offset:";
            // 
            // AllowableOffsetUpDown
            // 
            this.AllowableOffsetUpDown.Location = new System.Drawing.Point(98, 19);
            this.AllowableOffsetUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AllowableOffsetUpDown.Name = "AllowableOffsetUpDown";
            this.AllowableOffsetUpDown.Size = new System.Drawing.Size(97, 20);
            this.AllowableOffsetUpDown.TabIndex = 12;
            this.AllowableOffsetUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.PositionPUpDown);
            this.groupBox3.Controls.Add(this.PLabel);
            this.groupBox3.Controls.Add(this.ILabel);
            this.groupBox3.Controls.Add(this.PositionDUpDown);
            this.groupBox3.Controls.Add(this.PositionIUpDown);
            this.groupBox3.Controls.Add(this.DLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 128);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID Gains";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "x10^-6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "x10^-6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "x10^-6";
            // 
            // PositionPUpDown
            // 
            this.PositionPUpDown.Location = new System.Drawing.Point(32, 19);
            this.PositionPUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PositionPUpDown.Name = "PositionPUpDown";
            this.PositionPUpDown.Size = new System.Drawing.Size(68, 20);
            this.PositionPUpDown.TabIndex = 11;
            this.PositionPUpDown.Value = new decimal(new int[] {
            4500,
            0,
            0,
            0});
            this.PositionPUpDown.ValueChanged += new System.EventHandler(this.OnProportionalChanged);
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(6, 21);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(20, 13);
            this.PLabel.TabIndex = 11;
            this.PLabel.Text = "Kp";
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(6, 62);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(16, 13);
            this.ILabel.TabIndex = 11;
            this.ILabel.Text = "Ki";
            // 
            // PositionDUpDown
            // 
            this.PositionDUpDown.Location = new System.Drawing.Point(32, 101);
            this.PositionDUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PositionDUpDown.Name = "PositionDUpDown";
            this.PositionDUpDown.Size = new System.Drawing.Size(68, 20);
            this.PositionDUpDown.TabIndex = 11;
            this.PositionDUpDown.ValueChanged += new System.EventHandler(this.OnDerivativeChanged);
            // 
            // PositionIUpDown
            // 
            this.PositionIUpDown.Location = new System.Drawing.Point(32, 60);
            this.PositionIUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PositionIUpDown.Name = "PositionIUpDown";
            this.PositionIUpDown.Size = new System.Drawing.Size(68, 20);
            this.PositionIUpDown.TabIndex = 11;
            this.PositionIUpDown.ValueChanged += new System.EventHandler(this.OnIntegralChanged);
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(6, 103);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(20, 13);
            this.DLabel.TabIndex = 11;
            this.DLabel.Text = "Kd";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.DeadBandCompensationCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 77);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Full Reverse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnFullReverseButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Full Forward";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnFullForwardButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stop Motor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnStopButtonClick);
            // 
            // DeadBandCompensationCheckBox
            // 
            this.DeadBandCompensationCheckBox.AutoSize = true;
            this.DeadBandCompensationCheckBox.Location = new System.Drawing.Point(143, 51);
            this.DeadBandCompensationCheckBox.Name = "DeadBandCompensationCheckBox";
            this.DeadBandCompensationCheckBox.Size = new System.Drawing.Size(186, 17);
            this.DeadBandCompensationCheckBox.TabIndex = 11;
            this.DeadBandCompensationCheckBox.Text = "Enable Dead-Band Compensation";
            this.DeadBandCompensationCheckBox.UseVisualStyleBackColor = true;
            // 
            // VelocityControlUpDown
            // 
            this.VelocityControlUpDown.Enabled = false;
            this.VelocityControlUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VelocityControlUpDown.Location = new System.Drawing.Point(6, 235);
            this.VelocityControlUpDown.Name = "VelocityControlUpDown";
            this.VelocityControlUpDown.Size = new System.Drawing.Size(120, 20);
            this.VelocityControlUpDown.TabIndex = 17;
            // 
            // RawBinaryChart
            // 
            this.RawBinaryChart.BackColor = System.Drawing.SystemColors.Control;
            this.RawBinaryChart.BorderlineColor = System.Drawing.SystemColors.ControlText;
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisX2.MajorGrid.Enabled = false;
            chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY.Maximum = 255D;
            chartArea6.AxisY.Minimum = 5D;
            chartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY2.MajorGrid.Enabled = false;
            chartArea6.BackColor = System.Drawing.SystemColors.Control;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 100F;
            chartArea6.Position.Width = 100F;
            this.RawBinaryChart.ChartAreas.Add(chartArea6);
            this.RawBinaryChart.Location = new System.Drawing.Point(3, 65);
            this.RawBinaryChart.Margin = new System.Windows.Forms.Padding(0);
            this.RawBinaryChart.Name = "RawBinaryChart";
            series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Name = "Series1";
            series6.Points.Add(dataPoint6);
            this.RawBinaryChart.Series.Add(series6);
            this.RawBinaryChart.Size = new System.Drawing.Size(222, 20);
            this.RawBinaryChart.TabIndex = 26;
            this.RawBinaryChart.Text = "chart1";
            // 
            // VelocityControlRadioButton
            // 
            this.VelocityControlRadioButton.AutoSize = true;
            this.VelocityControlRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VelocityControlRadioButton.Location = new System.Drawing.Point(65, 212);
            this.VelocityControlRadioButton.Name = "VelocityControlRadioButton";
            this.VelocityControlRadioButton.Size = new System.Drawing.Size(98, 17);
            this.VelocityControlRadioButton.TabIndex = 16;
            this.VelocityControlRadioButton.TabStop = true;
            this.VelocityControlRadioButton.Text = "Velocity Control";
            this.VelocityControlRadioButton.UseVisualStyleBackColor = true;
            this.VelocityControlRadioButton.CheckedChanged += new System.EventHandler(this.OnModeCheckChanged);
            // 
            // PositionControlRadioButton
            // 
            this.PositionControlRadioButton.AutoSize = true;
            this.PositionControlRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionControlRadioButton.Location = new System.Drawing.Point(65, 163);
            this.PositionControlRadioButton.Name = "PositionControlRadioButton";
            this.PositionControlRadioButton.Size = new System.Drawing.Size(98, 17);
            this.PositionControlRadioButton.TabIndex = 15;
            this.PositionControlRadioButton.Text = "Position Control";
            this.PositionControlRadioButton.UseVisualStyleBackColor = true;
            this.PositionControlRadioButton.CheckedChanged += new System.EventHandler(this.OnModeCheckChanged);
            // 
            // VoltageControlRadioButton
            // 
            this.VoltageControlRadioButton.AutoSize = true;
            this.VoltageControlRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltageControlRadioButton.Location = new System.Drawing.Point(66, 88);
            this.VoltageControlRadioButton.Name = "VoltageControlRadioButton";
            this.VoltageControlRadioButton.Size = new System.Drawing.Size(97, 17);
            this.VoltageControlRadioButton.TabIndex = 14;
            this.VoltageControlRadioButton.Text = "Voltage Control";
            this.VoltageControlRadioButton.UseVisualStyleBackColor = true;
            this.VoltageControlRadioButton.CheckedChanged += new System.EventHandler(this.OnModeCheckChanged);
            // 
            // BinaryControlRadioButton
            // 
            this.BinaryControlRadioButton.AutoSize = true;
            this.BinaryControlRadioButton.Checked = true;
            this.BinaryControlRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryControlRadioButton.Location = new System.Drawing.Point(69, 19);
            this.BinaryControlRadioButton.Name = "BinaryControlRadioButton";
            this.BinaryControlRadioButton.Size = new System.Drawing.Size(90, 17);
            this.BinaryControlRadioButton.TabIndex = 13;
            this.BinaryControlRadioButton.TabStop = true;
            this.BinaryControlRadioButton.Text = "Binary Control";
            this.BinaryControlRadioButton.UseVisualStyleBackColor = true;
            this.BinaryControlRadioButton.CheckedChanged += new System.EventHandler(this.OnModeCheckChanged);
            // 
            // BinaryControlUpDown
            // 
            this.BinaryControlUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryControlUpDown.Location = new System.Drawing.Point(54, 42);
            this.BinaryControlUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BinaryControlUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BinaryControlUpDown.Name = "BinaryControlUpDown";
            this.BinaryControlUpDown.Size = new System.Drawing.Size(120, 20);
            this.BinaryControlUpDown.TabIndex = 11;
            this.BinaryControlUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BinaryControlUpDown.ValueChanged += new System.EventHandler(this.OnBinaryControlValueChanged);
            // 
            // VoltageControlUpDown
            // 
            this.VoltageControlUpDown.DecimalPlaces = 2;
            this.VoltageControlUpDown.Enabled = false;
            this.VoltageControlUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltageControlUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.VoltageControlUpDown.Location = new System.Drawing.Point(54, 111);
            this.VoltageControlUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.VoltageControlUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            -2147483648});
            this.VoltageControlUpDown.Name = "VoltageControlUpDown";
            this.VoltageControlUpDown.Size = new System.Drawing.Size(120, 20);
            this.VoltageControlUpDown.TabIndex = 12;
            this.VoltageControlUpDown.ValueChanged += new System.EventHandler(this.OnVoltageControlValueChanged);
            // 
            // PositionControlUpDown
            // 
            this.PositionControlUpDown.Enabled = false;
            this.PositionControlUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionControlUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PositionControlUpDown.Location = new System.Drawing.Point(6, 186);
            this.PositionControlUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.PositionControlUpDown.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.PositionControlUpDown.Name = "PositionControlUpDown";
            this.PositionControlUpDown.Size = new System.Drawing.Size(120, 20);
            this.PositionControlUpDown.TabIndex = 11;
            this.PositionControlUpDown.ValueChanged += new System.EventHandler(this.OnDesiredPositionChanged);
            // 
            // circlePlotPanel
            // 
            this.circlePlotPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circlePlotPanel.Location = new System.Drawing.Point(256, 16);
            this.circlePlotPanel.Name = "circlePlotPanel";
            this.circlePlotPanel.Size = new System.Drawing.Size(162, 162);
            this.circlePlotPanel.TabIndex = 19;
            // 
            // IncomingDataGroupBox
            // 
            this.IncomingDataGroupBox.Controls.Add(this.DataModeLabel);
            this.IncomingDataGroupBox.Controls.Add(this.DataModeSelectionBox);
            this.IncomingDataGroupBox.Controls.Add(this.IncomingByteGroupBox);
            this.IncomingDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingDataGroupBox.Location = new System.Drawing.Point(12, 105);
            this.IncomingDataGroupBox.Name = "IncomingDataGroupBox";
            this.IncomingDataGroupBox.Size = new System.Drawing.Size(273, 106);
            this.IncomingDataGroupBox.TabIndex = 21;
            this.IncomingDataGroupBox.TabStop = false;
            this.IncomingDataGroupBox.Text = "Incoming Data";
            // 
            // DataModeLabel
            // 
            this.DataModeLabel.AutoSize = true;
            this.DataModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataModeLabel.Location = new System.Drawing.Point(6, 19);
            this.DataModeLabel.Name = "DataModeLabel";
            this.DataModeLabel.Size = new System.Drawing.Size(97, 13);
            this.DataModeLabel.TabIndex = 1;
            this.DataModeLabel.Text = "Data Input Source:";
            this.toolTip1.SetToolTip(this.DataModeLabel, "The mode to be used for the incoming motor data");
            // 
            // DataModeSelectionBox
            // 
            this.DataModeSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataModeSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataModeSelectionBox.FormattingEnabled = true;
            this.DataModeSelectionBox.Location = new System.Drawing.Point(109, 16);
            this.DataModeSelectionBox.Name = "DataModeSelectionBox";
            this.DataModeSelectionBox.Size = new System.Drawing.Size(158, 21);
            this.DataModeSelectionBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.DataModeSelectionBox, "The mode to be used for the incoming motor data");
            this.DataModeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnDataModeSelectionChanged);
            // 
            // IncomingByteGroupBox
            // 
            this.IncomingByteGroupBox.Controls.Add(this.LowByteTextBox);
            this.IncomingByteGroupBox.Controls.Add(this.HighByteTextBox);
            this.IncomingByteGroupBox.Controls.Add(this.PositionIntegerLabel);
            this.IncomingByteGroupBox.Controls.Add(this.HighByteLabel);
            this.IncomingByteGroupBox.Controls.Add(this.PositionIntegerUpDown);
            this.IncomingByteGroupBox.Controls.Add(this.LowByteLabel);
            this.IncomingByteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingByteGroupBox.Location = new System.Drawing.Point(6, 43);
            this.IncomingByteGroupBox.Name = "IncomingByteGroupBox";
            this.IncomingByteGroupBox.Size = new System.Drawing.Size(261, 57);
            this.IncomingByteGroupBox.TabIndex = 22;
            this.IncomingByteGroupBox.TabStop = false;
            this.IncomingByteGroupBox.Text = "Incoming Bytes";
            // 
            // LowByteTextBox
            // 
            this.LowByteTextBox.Location = new System.Drawing.Point(95, 31);
            this.LowByteTextBox.Name = "LowByteTextBox";
            this.LowByteTextBox.ReadOnly = true;
            this.LowByteTextBox.Size = new System.Drawing.Size(70, 20);
            this.LowByteTextBox.TabIndex = 23;
            this.toolTip1.SetToolTip(this.LowByteTextBox, "The low byte of the 16-bit integer");
            // 
            // HighByteTextBox
            // 
            this.HighByteTextBox.Location = new System.Drawing.Point(6, 31);
            this.HighByteTextBox.Name = "HighByteTextBox";
            this.HighByteTextBox.ReadOnly = true;
            this.HighByteTextBox.Size = new System.Drawing.Size(70, 20);
            this.HighByteTextBox.TabIndex = 22;
            this.toolTip1.SetToolTip(this.HighByteTextBox, "The high byte of the 16-bit integer");
            // 
            // PositionIntegerLabel
            // 
            this.PositionIntegerLabel.AutoSize = true;
            this.PositionIntegerLabel.Location = new System.Drawing.Point(190, 16);
            this.PositionIntegerLabel.Name = "PositionIntegerLabel";
            this.PositionIntegerLabel.Size = new System.Drawing.Size(59, 13);
            this.PositionIntegerLabel.TabIndex = 19;
            this.PositionIntegerLabel.Text = "Position Int";
            this.toolTip1.SetToolTip(this.PositionIntegerLabel, "The current (not total) position as a 16-bit integer");
            // 
            // HighByteLabel
            // 
            this.HighByteLabel.AutoSize = true;
            this.HighByteLabel.Location = new System.Drawing.Point(105, 16);
            this.HighByteLabel.Name = "HighByteLabel";
            this.HighByteLabel.Size = new System.Drawing.Size(51, 13);
            this.HighByteLabel.TabIndex = 23;
            this.HighByteLabel.Text = "Low Byte";
            this.toolTip1.SetToolTip(this.HighByteLabel, "The low byte of the 16-bit integer");
            // 
            // PositionIntegerUpDown
            // 
            this.PositionIntegerUpDown.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PositionIntegerUpDown.Location = new System.Drawing.Point(184, 31);
            this.PositionIntegerUpDown.Maximum = new decimal(new int[] {
            2200000,
            0,
            0,
            0});
            this.PositionIntegerUpDown.Minimum = new decimal(new int[] {
            2200000,
            0,
            0,
            -2147483648});
            this.PositionIntegerUpDown.Name = "PositionIntegerUpDown";
            this.PositionIntegerUpDown.ReadOnly = true;
            this.PositionIntegerUpDown.Size = new System.Drawing.Size(70, 20);
            this.PositionIntegerUpDown.TabIndex = 22;
            this.toolTip1.SetToolTip(this.PositionIntegerUpDown, "The current (not total) position as a 16-bit integer");
            this.PositionIntegerUpDown.ValueChanged += new System.EventHandler(this.OnPositionIntegerValueChanged);
            // 
            // LowByteLabel
            // 
            this.LowByteLabel.AutoSize = true;
            this.LowByteLabel.Location = new System.Drawing.Point(15, 16);
            this.LowByteLabel.Name = "LowByteLabel";
            this.LowByteLabel.Size = new System.Drawing.Size(53, 13);
            this.LowByteLabel.TabIndex = 17;
            this.LowByteLabel.Text = "High Byte";
            this.toolTip1.SetToolTip(this.LowByteLabel, "The high byte of the 16-bit integer");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.graphsToolStripMenuItem.Text = "Graphs";
            this.graphsToolStripMenuItem.Click += new System.EventHandler(this.OnGraphsMenuClicked);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realtimeDataSettingsToolStripMenuItem,
            this.deadBandSettingsToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.configurationToolStripMenuItem.Text = "Settings";
            // 
            // realtimeDataSettingsToolStripMenuItem
            // 
            this.realtimeDataSettingsToolStripMenuItem.Name = "realtimeDataSettingsToolStripMenuItem";
            this.realtimeDataSettingsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.realtimeDataSettingsToolStripMenuItem.Text = "Realtime Data Settings";
            this.realtimeDataSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnRealtimeDataSettingsMenuClicked);
            // 
            // deadBandSettingsToolStripMenuItem
            // 
            this.deadBandSettingsToolStripMenuItem.Name = "deadBandSettingsToolStripMenuItem";
            this.deadBandSettingsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deadBandSettingsToolStripMenuItem.Text = "Dead Band Settings";
            this.deadBandSettingsToolStripMenuItem.ToolTipText = "Opens the Dead Band settings window";
            this.deadBandSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnDeadBandSettingsMenuClicked);
            // 
            // MotorDataGroupBox
            // 
            this.MotorDataGroupBox.Controls.Add(this.label10);
            this.MotorDataGroupBox.Controls.Add(this.label9);
            this.MotorDataGroupBox.Controls.Add(this.circlePlotPanel);
            this.MotorDataGroupBox.Controls.Add(this.CurrentVoltageTextBox);
            this.MotorDataGroupBox.Controls.Add(this.CurrentBinaryTextBox);
            this.MotorDataGroupBox.Controls.Add(this.label8);
            this.MotorDataGroupBox.Controls.Add(this.CurrentAccelerationUnitSelectionBox);
            this.MotorDataGroupBox.Controls.Add(this.CurrentAccelerationTextBox);
            this.MotorDataGroupBox.Controls.Add(this.label7);
            this.MotorDataGroupBox.Controls.Add(this.CurrentVelocityUnitSelectionBox);
            this.MotorDataGroupBox.Controls.Add(this.label6);
            this.MotorDataGroupBox.Controls.Add(this.label5);
            this.MotorDataGroupBox.Controls.Add(this.label4);
            this.MotorDataGroupBox.Controls.Add(this.label3);
            this.MotorDataGroupBox.Controls.Add(this.CurrentPositionUnitSelectionBox);
            this.MotorDataGroupBox.Controls.Add(this.CurrentVelocityTextBox);
            this.MotorDataGroupBox.Controls.Add(this.CurrentPositionTextBox);
            this.MotorDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorDataGroupBox.Location = new System.Drawing.Point(294, 27);
            this.MotorDataGroupBox.Name = "MotorDataGroupBox";
            this.MotorDataGroupBox.Size = new System.Drawing.Size(425, 184);
            this.MotorDataGroupBox.TabIndex = 23;
            this.MotorDataGroupBox.TabStop = false;
            this.MotorDataGroupBox.Text = "Realtime Motor Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(147, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Current Voltage (V)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Current Binary";
            // 
            // CurrentVoltageTextBox
            // 
            this.CurrentVoltageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentVoltageTextBox.Location = new System.Drawing.Point(140, 32);
            this.CurrentVoltageTextBox.Name = "CurrentVoltageTextBox";
            this.CurrentVoltageTextBox.ReadOnly = true;
            this.CurrentVoltageTextBox.Size = new System.Drawing.Size(110, 20);
            this.CurrentVoltageTextBox.TabIndex = 13;
            // 
            // CurrentBinaryTextBox
            // 
            this.CurrentBinaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBinaryTextBox.Location = new System.Drawing.Point(6, 32);
            this.CurrentBinaryTextBox.Name = "CurrentBinaryTextBox";
            this.CurrentBinaryTextBox.ReadOnly = true;
            this.CurrentBinaryTextBox.Size = new System.Drawing.Size(110, 20);
            this.CurrentBinaryTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(192, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Unit";
            // 
            // CurrentAccelerationUnitSelectionBox
            // 
            this.CurrentAccelerationUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentAccelerationUnitSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAccelerationUnitSelectionBox.FormattingEnabled = true;
            this.CurrentAccelerationUnitSelectionBox.Location = new System.Drawing.Point(160, 149);
            this.CurrentAccelerationUnitSelectionBox.Name = "CurrentAccelerationUnitSelectionBox";
            this.CurrentAccelerationUnitSelectionBox.Size = new System.Drawing.Size(90, 21);
            this.CurrentAccelerationUnitSelectionBox.TabIndex = 10;
            this.CurrentAccelerationUnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnAccelerationUnitSelectionChanged);
            // 
            // CurrentAccelerationTextBox
            // 
            this.CurrentAccelerationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAccelerationTextBox.Location = new System.Drawing.Point(6, 149);
            this.CurrentAccelerationTextBox.Name = "CurrentAccelerationTextBox";
            this.CurrentAccelerationTextBox.ReadOnly = true;
            this.CurrentAccelerationTextBox.Size = new System.Drawing.Size(148, 20);
            this.CurrentAccelerationTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Acceleration";
            // 
            // CurrentVelocityUnitSelectionBox
            // 
            this.CurrentVelocityUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentVelocityUnitSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentVelocityUnitSelectionBox.FormattingEnabled = true;
            this.CurrentVelocityUnitSelectionBox.Location = new System.Drawing.Point(160, 110);
            this.CurrentVelocityUnitSelectionBox.Name = "CurrentVelocityUnitSelectionBox";
            this.CurrentVelocityUnitSelectionBox.Size = new System.Drawing.Size(90, 21);
            this.CurrentVelocityUnitSelectionBox.TabIndex = 7;
            this.CurrentVelocityUnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnVelocityUnitSelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Velocity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position";
            // 
            // CurrentPositionUnitSelectionBox
            // 
            this.CurrentPositionUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentPositionUnitSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPositionUnitSelectionBox.FormattingEnabled = true;
            this.CurrentPositionUnitSelectionBox.Location = new System.Drawing.Point(160, 71);
            this.CurrentPositionUnitSelectionBox.Name = "CurrentPositionUnitSelectionBox";
            this.CurrentPositionUnitSelectionBox.Size = new System.Drawing.Size(90, 21);
            this.CurrentPositionUnitSelectionBox.TabIndex = 2;
            this.CurrentPositionUnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnPositionUnitSelectionChanged);
            // 
            // CurrentVelocityTextBox
            // 
            this.CurrentVelocityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentVelocityTextBox.Location = new System.Drawing.Point(6, 110);
            this.CurrentVelocityTextBox.Name = "CurrentVelocityTextBox";
            this.CurrentVelocityTextBox.ReadOnly = true;
            this.CurrentVelocityTextBox.Size = new System.Drawing.Size(148, 20);
            this.CurrentVelocityTextBox.TabIndex = 1;
            // 
            // CurrentPositionTextBox
            // 
            this.CurrentPositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPositionTextBox.Location = new System.Drawing.Point(6, 71);
            this.CurrentPositionTextBox.Name = "CurrentPositionTextBox";
            this.CurrentPositionTextBox.ReadOnly = true;
            this.CurrentPositionTextBox.Size = new System.Drawing.Size(148, 20);
            this.CurrentPositionTextBox.TabIndex = 0;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(730, 514);
            this.Controls.Add(this.MotorDataGroupBox);
            this.Controls.Add(this.IncomingDataGroupBox);
            this.Controls.Add(this.OutputsGroupBox);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(746, 553);
            this.MinimumSize = new System.Drawing.Size(746, 553);
            this.Name = "MainInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servo Motor Driver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.OutputsGroupBox.ResumeLayout(false);
            this.OutputsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlPositiveChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlNegativeChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationControlUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowableOffsetUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionPUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityControlUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawBinaryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryControlUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionControlUpDown)).EndInit();
            this.IncomingDataGroupBox.ResumeLayout(false);
            this.IncomingDataGroupBox.PerformLayout();
            this.IncomingByteGroupBox.ResumeLayout(false);
            this.IncomingByteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIntegerUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MotorDataGroupBox.ResumeLayout(false);
            this.MotorDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialComPort;
        public System.Windows.Forms.Timer ProgramLoopTimer;
        private System.Windows.Forms.ComboBox COMPortSelectionBox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MessageLogStatusStrip;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.GroupBox OutputsGroupBox;
        private System.Windows.Forms.NumericUpDown BinaryControlUpDown;
        private System.Windows.Forms.NumericUpDown VoltageControlUpDown;
        private System.Windows.Forms.CheckBox DeadBandCompensationCheckBox;
        private System.Windows.Forms.NumericUpDown PositionIUpDown;
        private System.Windows.Forms.NumericUpDown PositionDUpDown;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.NumericUpDown PositionPUpDown;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.NumericUpDown PositionControlUpDown;
        private System.Windows.Forms.Panel circlePlotPanel;
        private System.Windows.Forms.GroupBox IncomingDataGroupBox;
        private System.Windows.Forms.Label DataModeLabel;
        private System.Windows.Forms.ComboBox DataModeSelectionBox;
        private System.Windows.Forms.Label LowByteLabel;
        private System.Windows.Forms.Label HighByteLabel;
        private System.Windows.Forms.NumericUpDown PositionIntegerUpDown;
        private System.Windows.Forms.Label PositionIntegerLabel;
        private System.Windows.Forms.GroupBox IncomingByteGroupBox;
        private System.Windows.Forms.TextBox LowByteTextBox;
        private System.Windows.Forms.TextBox HighByteTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadBandSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.GroupBox MotorDataGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CurrentPositionUnitSelectionBox;
        private System.Windows.Forms.TextBox CurrentVelocityTextBox;
        private System.Windows.Forms.TextBox CurrentPositionTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CurrentVoltageTextBox;
        private System.Windows.Forms.TextBox CurrentBinaryTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CurrentAccelerationUnitSelectionBox;
        private System.Windows.Forms.TextBox CurrentAccelerationTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CurrentVelocityUnitSelectionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem realtimeDataSettingsToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown AllowableOffsetUpDown;
        private System.Windows.Forms.NumericUpDown AccelerationControlUpDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageControlNegativeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageControlPositiveChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RawBinaryChart;
        private System.Windows.Forms.RadioButton PositionControlRadioButton;
        private System.Windows.Forms.RadioButton VoltageControlRadioButton;
        private System.Windows.Forms.RadioButton BinaryControlRadioButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown VelocityControlUpDown;
        private System.Windows.Forms.RadioButton VelocityControlRadioButton;
        private System.Windows.Forms.TextBox COMPortStatusTextBox;
        private System.Windows.Forms.Button COMPortDisconnectButton;
        private System.Windows.Forms.Button COMPortConnectButton;
        private System.Windows.Forms.Button COMPortRefreshButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

