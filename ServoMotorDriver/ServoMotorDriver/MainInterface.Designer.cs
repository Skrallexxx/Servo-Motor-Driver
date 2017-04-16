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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea61 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series61 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea62 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series62 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea63 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series63 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint33 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea64 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series64 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea65 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series65 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea66 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series66 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SerialComPort = new System.IO.Ports.SerialPort(this.components);
            this.ProgramLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.ComPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MessageLogStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.ModeSelectionBox = new System.Windows.Forms.ComboBox();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.ModeSelectionLabel = new System.Windows.Forms.Label();
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputsGroupBox = new System.Windows.Forms.GroupBox();
            this.RawControlGroupBox = new System.Windows.Forms.GroupBox();
            this.RawCurrentVoltageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RawVoltageTextBox = new System.Windows.Forms.TextBox();
            this.RawControlCurrentValueLabel = new System.Windows.Forms.Label();
            this.RawControlCurrentTextBox = new System.Windows.Forms.TextBox();
            this.RawControlDecimalLabel = new System.Windows.Forms.Label();
            this.RawControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.RawBinaryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PositionControlGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DegRadioButton = new System.Windows.Forms.RadioButton();
            this.RadiansRadioButton = new System.Windows.Forms.RadioButton();
            this.CountsRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentPositionLabel = new System.Windows.Forms.Label();
            this.CurrentPositionTextBox = new System.Windows.Forms.TextBox();
            this.DesiredPositionLabel = new System.Windows.Forms.Label();
            this.DesiredPositionUpDown = new System.Windows.Forms.NumericUpDown();
            this.DLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.PositionIUpDown = new System.Windows.Forms.NumericUpDown();
            this.PositionDUpDown = new System.Windows.Forms.NumericUpDown();
            this.PLabel = new System.Windows.Forms.Label();
            this.PositionPUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeedControlGroupBox = new System.Windows.Forms.GroupBox();
            this.VoltageControlNegativeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VoltageControlPositiveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VoltageControlSpeedLabel = new System.Windows.Forms.Label();
            this.VoltageControlSpeedTextBox = new System.Windows.Forms.TextBox();
            this.VoltageControlVoltageLabel = new System.Windows.Forms.Label();
            this.VoltageControlVoltageUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeadBandCompensationCheckBox = new System.Windows.Forms.CheckBox();
            this.DeadBandTestingGroupBox = new System.Windows.Forms.GroupBox();
            this.DeadBandTestingRangeLabel = new System.Windows.Forms.Label();
            this.DeadBandUpperUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeadBandTestingToLabel = new System.Windows.Forms.Label();
            this.DeadBandLowerUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeadBandTestingLoadButton = new System.Windows.Forms.Button();
            this.DeadBandTestingPositionTextBox = new System.Windows.Forms.TextBox();
            this.DeadBandTestingPositionLabel = new System.Windows.Forms.Label();
            this.DeadBandTestingVoltageTextBox = new System.Windows.Forms.TextBox();
            this.DeadBandTestingSaveButton = new System.Windows.Forms.Button();
            this.DeadBandTestingVoltageLabel = new System.Windows.Forms.Label();
            this.DeadBandTestingStartButton = new System.Windows.Forms.Button();
            this.PositionPlotGroupBox = new System.Windows.Forms.GroupBox();
            this.PositionPlotRevsRadioButton = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PositionPlotCountsRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionPlotRadRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionPlotDegRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionPlotCurrentTextBox = new System.Windows.Forms.TextBox();
            this.PositionPlotCurrentLabel = new System.Windows.Forms.Label();
            this.VelocityPlotGroupBox = new System.Windows.Forms.GroupBox();
            this.VelocityPlotRPMRadioButton = new System.Windows.Forms.RadioButton();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VelocityPlotCountsRadioButton = new System.Windows.Forms.RadioButton();
            this.VelocityPlotRadRadioButton = new System.Windows.Forms.RadioButton();
            this.VelocityPlotDegRadioButton = new System.Windows.Forms.RadioButton();
            this.VelocityPlotCurrentTextBox = new System.Windows.Forms.TextBox();
            this.VelocityPlotCurrentLabel = new System.Windows.Forms.Label();
            this.AccelerationPlotGroupBox = new System.Windows.Forms.GroupBox();
            this.AccelerationPlotRPMRadioButton = new System.Windows.Forms.RadioButton();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AccelerationPlotCountsRadioButton = new System.Windows.Forms.RadioButton();
            this.AccelerationPlotRadRadioButton = new System.Windows.Forms.RadioButton();
            this.AccelerationPlotDegRadioButton = new System.Windows.Forms.RadioButton();
            this.AccelerationPlotCurrentTextBox = new System.Windows.Forms.TextBox();
            this.AccelerationPlotCurrentLabel = new System.Windows.Forms.Label();
            this.GraphsGroupBox = new System.Windows.Forms.GroupBox();
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDataSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadBandSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StatusStrip.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.OutputsGroupBox.SuspendLayout();
            this.RawControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RawControlUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawBinaryChart)).BeginInit();
            this.PositionControlGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesiredPositionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionPUpDown)).BeginInit();
            this.SpeedControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlNegativeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlPositiveChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlVoltageUpDown)).BeginInit();
            this.DeadBandTestingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeadBandUpperUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeadBandLowerUpDown)).BeginInit();
            this.PositionPlotGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.VelocityPlotGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.AccelerationPlotGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.GraphsGroupBox.SuspendLayout();
            this.IncomingDataGroupBox.SuspendLayout();
            this.IncomingByteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIntegerUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialComPort
            // 
            this.SerialComPort.BaudRate = 57600;
            // 
            // ProgramLoopTimer
            // 
            this.ProgramLoopTimer.Enabled = true;
            this.ProgramLoopTimer.Interval = 8;
            this.ProgramLoopTimer.Tick += new System.EventHandler(this.ProgramLoop);
            // 
            // ComPortSelectionBox
            // 
            this.ComPortSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortSelectionBox.FormattingEnabled = true;
            this.ComPortSelectionBox.Location = new System.Drawing.Point(65, 16);
            this.ComPortSelectionBox.Name = "ComPortSelectionBox";
            this.ComPortSelectionBox.Size = new System.Drawing.Size(202, 21);
            this.ComPortSelectionBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ComPortSelectionBox, "The COM port to use for communication with the microcontroller");
            this.ComPortSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnComPortSelectionChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLogStatusStrip});
            this.StatusStrip.Location = new System.Drawing.Point(0, 528);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1284, 22);
            this.StatusStrip.TabIndex = 1;
            // 
            // MessageLogStatusStrip
            // 
            this.MessageLogStatusStrip.Name = "MessageLogStatusStrip";
            this.MessageLogStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // ModeSelectionBox
            // 
            this.ModeSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelectionBox.FormattingEnabled = true;
            this.ModeSelectionBox.Location = new System.Drawing.Point(65, 43);
            this.ModeSelectionBox.Name = "ModeSelectionBox";
            this.ModeSelectionBox.Size = new System.Drawing.Size(202, 21);
            this.ModeSelectionBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.ModeSelectionBox, "The motor operation mode");
            this.ModeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnModeSelectionChanged);
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Location = new System.Drawing.Point(6, 19);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(53, 13);
            this.ComPortLabel.TabIndex = 6;
            this.ComPortLabel.Text = "COM Port";
            this.toolTip1.SetToolTip(this.ComPortLabel, "The COM port to use for communication with the microcontroller");
            // 
            // ModeSelectionLabel
            // 
            this.ModeSelectionLabel.AutoSize = true;
            this.ModeSelectionLabel.Location = new System.Drawing.Point(6, 46);
            this.ModeSelectionLabel.Name = "ModeSelectionLabel";
            this.ModeSelectionLabel.Size = new System.Drawing.Size(34, 13);
            this.ModeSelectionLabel.TabIndex = 7;
            this.ModeSelectionLabel.Text = "Mode";
            this.toolTip1.SetToolTip(this.ModeSelectionLabel, "The motor operation mode");
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Controls.Add(this.ComPortLabel);
            this.ConfigurationGroupBox.Controls.Add(this.ComPortSelectionBox);
            this.ConfigurationGroupBox.Controls.Add(this.ModeSelectionLabel);
            this.ConfigurationGroupBox.Controls.Add(this.ModeSelectionBox);
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(12, 27);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(273, 72);
            this.ConfigurationGroupBox.TabIndex = 9;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Controller Configuration";
            // 
            // OutputsGroupBox
            // 
            this.OutputsGroupBox.Controls.Add(this.RawControlGroupBox);
            this.OutputsGroupBox.Controls.Add(this.PositionControlGroupBox);
            this.OutputsGroupBox.Controls.Add(this.SpeedControlGroupBox);
            this.OutputsGroupBox.Controls.Add(this.DeadBandTestingGroupBox);
            this.OutputsGroupBox.Location = new System.Drawing.Point(12, 217);
            this.OutputsGroupBox.Name = "OutputsGroupBox";
            this.OutputsGroupBox.Size = new System.Drawing.Size(538, 287);
            this.OutputsGroupBox.TabIndex = 10;
            this.OutputsGroupBox.TabStop = false;
            this.OutputsGroupBox.Text = "Outputs";
            // 
            // RawControlGroupBox
            // 
            this.RawControlGroupBox.Controls.Add(this.RawCurrentVoltageTextBox);
            this.RawControlGroupBox.Controls.Add(this.label2);
            this.RawControlGroupBox.Controls.Add(this.label1);
            this.RawControlGroupBox.Controls.Add(this.RawVoltageTextBox);
            this.RawControlGroupBox.Controls.Add(this.RawControlCurrentValueLabel);
            this.RawControlGroupBox.Controls.Add(this.RawControlCurrentTextBox);
            this.RawControlGroupBox.Controls.Add(this.RawControlDecimalLabel);
            this.RawControlGroupBox.Controls.Add(this.RawControlUpDown);
            this.RawControlGroupBox.Controls.Add(this.RawBinaryChart);
            this.RawControlGroupBox.Enabled = false;
            this.RawControlGroupBox.Location = new System.Drawing.Point(9, 19);
            this.RawControlGroupBox.Name = "RawControlGroupBox";
            this.RawControlGroupBox.Size = new System.Drawing.Size(258, 121);
            this.RawControlGroupBox.TabIndex = 11;
            this.RawControlGroupBox.TabStop = false;
            this.RawControlGroupBox.Text = "Raw DAC Control";
            // 
            // RawCurrentVoltageTextBox
            // 
            this.RawCurrentVoltageTextBox.Location = new System.Drawing.Point(132, 71);
            this.RawCurrentVoltageTextBox.Name = "RawCurrentVoltageTextBox";
            this.RawCurrentVoltageTextBox.ReadOnly = true;
            this.RawCurrentVoltageTextBox.Size = new System.Drawing.Size(120, 20);
            this.RawCurrentVoltageTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Current Value (V)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Voltage Value (V)";
            // 
            // RawVoltageTextBox
            // 
            this.RawVoltageTextBox.Location = new System.Drawing.Point(6, 71);
            this.RawVoltageTextBox.Name = "RawVoltageTextBox";
            this.RawVoltageTextBox.ReadOnly = true;
            this.RawVoltageTextBox.Size = new System.Drawing.Size(120, 20);
            this.RawVoltageTextBox.TabIndex = 15;
            // 
            // RawControlCurrentValueLabel
            // 
            this.RawControlCurrentValueLabel.AutoSize = true;
            this.RawControlCurrentValueLabel.Location = new System.Drawing.Point(157, 16);
            this.RawControlCurrentValueLabel.Name = "RawControlCurrentValueLabel";
            this.RawControlCurrentValueLabel.Size = new System.Drawing.Size(71, 13);
            this.RawControlCurrentValueLabel.TabIndex = 11;
            this.RawControlCurrentValueLabel.Text = "Current Value";
            // 
            // RawControlCurrentTextBox
            // 
            this.RawControlCurrentTextBox.Location = new System.Drawing.Point(132, 32);
            this.RawControlCurrentTextBox.Name = "RawControlCurrentTextBox";
            this.RawControlCurrentTextBox.ReadOnly = true;
            this.RawControlCurrentTextBox.Size = new System.Drawing.Size(120, 20);
            this.RawControlCurrentTextBox.TabIndex = 11;
            // 
            // RawControlDecimalLabel
            // 
            this.RawControlDecimalLabel.AutoSize = true;
            this.RawControlDecimalLabel.Location = new System.Drawing.Point(33, 16);
            this.RawControlDecimalLabel.Name = "RawControlDecimalLabel";
            this.RawControlDecimalLabel.Size = new System.Drawing.Size(66, 13);
            this.RawControlDecimalLabel.TabIndex = 11;
            this.RawControlDecimalLabel.Text = "Binary Value";
            // 
            // RawControlUpDown
            // 
            this.RawControlUpDown.Location = new System.Drawing.Point(6, 32);
            this.RawControlUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RawControlUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RawControlUpDown.Name = "RawControlUpDown";
            this.RawControlUpDown.Size = new System.Drawing.Size(120, 20);
            this.RawControlUpDown.TabIndex = 11;
            this.RawControlUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RawControlUpDown.ValueChanged += new System.EventHandler(this.OnRawControlValueChanged);
            // 
            // RawBinaryChart
            // 
            this.RawBinaryChart.BackColor = System.Drawing.SystemColors.Control;
            this.RawBinaryChart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea61.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea61.AxisX.MajorGrid.Enabled = false;
            chartArea61.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea61.AxisX2.MajorGrid.Enabled = false;
            chartArea61.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea61.AxisY.MajorGrid.Enabled = false;
            chartArea61.AxisY.Maximum = 255D;
            chartArea61.AxisY.Minimum = 5D;
            chartArea61.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea61.AxisY2.MajorGrid.Enabled = false;
            chartArea61.BackColor = System.Drawing.SystemColors.Control;
            chartArea61.Name = "ChartArea1";
            chartArea61.Position.Auto = false;
            chartArea61.Position.Height = 100F;
            chartArea61.Position.Width = 100F;
            this.RawBinaryChart.ChartAreas.Add(chartArea61);
            this.RawBinaryChart.Location = new System.Drawing.Point(6, 95);
            this.RawBinaryChart.Margin = new System.Windows.Forms.Padding(0);
            this.RawBinaryChart.Name = "RawBinaryChart";
            series61.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series61.ChartArea = "ChartArea1";
            series61.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series61.Name = "Series1";
            series61.Points.Add(dataPoint31);
            this.RawBinaryChart.Series.Add(series61);
            this.RawBinaryChart.Size = new System.Drawing.Size(246, 20);
            this.RawBinaryChart.TabIndex = 15;
            this.RawBinaryChart.Text = "chart1";
            // 
            // PositionControlGroupBox
            // 
            this.PositionControlGroupBox.Controls.Add(this.panel1);
            this.PositionControlGroupBox.Controls.Add(this.CurrentPositionLabel);
            this.PositionControlGroupBox.Controls.Add(this.CurrentPositionTextBox);
            this.PositionControlGroupBox.Controls.Add(this.DesiredPositionLabel);
            this.PositionControlGroupBox.Controls.Add(this.DesiredPositionUpDown);
            this.PositionControlGroupBox.Controls.Add(this.DLabel);
            this.PositionControlGroupBox.Controls.Add(this.ILabel);
            this.PositionControlGroupBox.Controls.Add(this.PositionIUpDown);
            this.PositionControlGroupBox.Controls.Add(this.PositionDUpDown);
            this.PositionControlGroupBox.Controls.Add(this.PLabel);
            this.PositionControlGroupBox.Controls.Add(this.PositionPUpDown);
            this.PositionControlGroupBox.Enabled = false;
            this.PositionControlGroupBox.Location = new System.Drawing.Point(273, 146);
            this.PositionControlGroupBox.Name = "PositionControlGroupBox";
            this.PositionControlGroupBox.Size = new System.Drawing.Size(258, 134);
            this.PositionControlGroupBox.TabIndex = 11;
            this.PositionControlGroupBox.TabStop = false;
            this.PositionControlGroupBox.Text = "Position Control";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DegRadioButton);
            this.panel1.Controls.Add(this.RadiansRadioButton);
            this.panel1.Controls.Add(this.CountsRadioButton);
            this.panel1.Location = new System.Drawing.Point(6, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 30);
            this.panel1.TabIndex = 11;
            // 
            // DegRadioButton
            // 
            this.DegRadioButton.AutoSize = true;
            this.DegRadioButton.Checked = true;
            this.DegRadioButton.Location = new System.Drawing.Point(3, 8);
            this.DegRadioButton.Name = "DegRadioButton";
            this.DegRadioButton.Size = new System.Drawing.Size(45, 17);
            this.DegRadioButton.TabIndex = 11;
            this.DegRadioButton.TabStop = true;
            this.DegRadioButton.Text = "Deg";
            this.DegRadioButton.UseVisualStyleBackColor = true;
            // 
            // RadiansRadioButton
            // 
            this.RadiansRadioButton.AutoSize = true;
            this.RadiansRadioButton.Location = new System.Drawing.Point(94, 8);
            this.RadiansRadioButton.Name = "RadiansRadioButton";
            this.RadiansRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RadiansRadioButton.TabIndex = 11;
            this.RadiansRadioButton.Text = "Rad";
            this.RadiansRadioButton.UseVisualStyleBackColor = true;
            // 
            // CountsRadioButton
            // 
            this.CountsRadioButton.AutoSize = true;
            this.CountsRadioButton.Location = new System.Drawing.Point(185, 8);
            this.CountsRadioButton.Name = "CountsRadioButton";
            this.CountsRadioButton.Size = new System.Drawing.Size(58, 17);
            this.CountsRadioButton.TabIndex = 11;
            this.CountsRadioButton.Text = "Counts";
            this.CountsRadioButton.UseVisualStyleBackColor = true;
            // 
            // CurrentPositionLabel
            // 
            this.CurrentPositionLabel.AutoSize = true;
            this.CurrentPositionLabel.Location = new System.Drawing.Point(152, 91);
            this.CurrentPositionLabel.Name = "CurrentPositionLabel";
            this.CurrentPositionLabel.Size = new System.Drawing.Size(81, 13);
            this.CurrentPositionLabel.TabIndex = 11;
            this.CurrentPositionLabel.Text = "Current Position";
            // 
            // CurrentPositionTextBox
            // 
            this.CurrentPositionTextBox.Location = new System.Drawing.Point(132, 107);
            this.CurrentPositionTextBox.Name = "CurrentPositionTextBox";
            this.CurrentPositionTextBox.ReadOnly = true;
            this.CurrentPositionTextBox.Size = new System.Drawing.Size(120, 20);
            this.CurrentPositionTextBox.TabIndex = 11;
            // 
            // DesiredPositionLabel
            // 
            this.DesiredPositionLabel.AutoSize = true;
            this.DesiredPositionLabel.Location = new System.Drawing.Point(28, 91);
            this.DesiredPositionLabel.Name = "DesiredPositionLabel";
            this.DesiredPositionLabel.Size = new System.Drawing.Size(83, 13);
            this.DesiredPositionLabel.TabIndex = 11;
            this.DesiredPositionLabel.Text = "Desired Position";
            // 
            // DesiredPositionUpDown
            // 
            this.DesiredPositionUpDown.Location = new System.Drawing.Point(9, 107);
            this.DesiredPositionUpDown.Name = "DesiredPositionUpDown";
            this.DesiredPositionUpDown.Size = new System.Drawing.Size(120, 20);
            this.DesiredPositionUpDown.TabIndex = 11;
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(211, 16);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(15, 13);
            this.DLabel.TabIndex = 11;
            this.DLabel.Text = "D";
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(124, 16);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(10, 13);
            this.ILabel.TabIndex = 11;
            this.ILabel.Text = "I";
            // 
            // PositionIUpDown
            // 
            this.PositionIUpDown.Location = new System.Drawing.Point(95, 32);
            this.PositionIUpDown.Name = "PositionIUpDown";
            this.PositionIUpDown.Size = new System.Drawing.Size(68, 20);
            this.PositionIUpDown.TabIndex = 11;
            // 
            // PositionDUpDown
            // 
            this.PositionDUpDown.Location = new System.Drawing.Point(184, 32);
            this.PositionDUpDown.Name = "PositionDUpDown";
            this.PositionDUpDown.Size = new System.Drawing.Size(68, 20);
            this.PositionDUpDown.TabIndex = 11;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(33, 16);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(14, 13);
            this.PLabel.TabIndex = 11;
            this.PLabel.Text = "P";
            // 
            // PositionPUpDown
            // 
            this.PositionPUpDown.Location = new System.Drawing.Point(6, 32);
            this.PositionPUpDown.Name = "PositionPUpDown";
            this.PositionPUpDown.Size = new System.Drawing.Size(68, 20);
            this.PositionPUpDown.TabIndex = 11;
            // 
            // SpeedControlGroupBox
            // 
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlNegativeChart);
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlPositiveChart);
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlSpeedLabel);
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlSpeedTextBox);
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlVoltageLabel);
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlVoltageUpDown);
            this.SpeedControlGroupBox.Controls.Add(this.DeadBandCompensationCheckBox);
            this.SpeedControlGroupBox.Enabled = false;
            this.SpeedControlGroupBox.Location = new System.Drawing.Point(9, 146);
            this.SpeedControlGroupBox.Name = "SpeedControlGroupBox";
            this.SpeedControlGroupBox.Size = new System.Drawing.Size(258, 134);
            this.SpeedControlGroupBox.TabIndex = 11;
            this.SpeedControlGroupBox.TabStop = false;
            this.SpeedControlGroupBox.Text = "Speed/Voltage Control";
            // 
            // VoltageControlNegativeChart
            // 
            this.VoltageControlNegativeChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea62.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea62.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea62.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea62.AxisY.IsReversed = true;
            chartArea62.AxisY.Maximum = 16D;
            chartArea62.AxisY.Minimum = 0D;
            chartArea62.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea62.BackColor = System.Drawing.SystemColors.Control;
            chartArea62.Name = "ChartArea1";
            chartArea62.Position.Auto = false;
            chartArea62.Position.Height = 100F;
            chartArea62.Position.Width = 100F;
            this.VoltageControlNegativeChart.ChartAreas.Add(chartArea62);
            this.VoltageControlNegativeChart.Location = new System.Drawing.Point(6, 78);
            this.VoltageControlNegativeChart.Name = "VoltageControlNegativeChart";
            series62.ChartArea = "ChartArea1";
            series62.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series62.Name = "Series1";
            dataPoint32.Color = System.Drawing.Color.Red;
            series62.Points.Add(dataPoint32);
            this.VoltageControlNegativeChart.Series.Add(series62);
            this.VoltageControlNegativeChart.Size = new System.Drawing.Size(123, 20);
            this.VoltageControlNegativeChart.TabIndex = 16;
            this.VoltageControlNegativeChart.Text = "chart2";
            // 
            // VoltageControlPositiveChart
            // 
            this.VoltageControlPositiveChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea63.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea63.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea63.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea63.AxisY.Maximum = 16D;
            chartArea63.AxisY.Minimum = 0D;
            chartArea63.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea63.BackColor = System.Drawing.SystemColors.Control;
            chartArea63.Name = "ChartArea1";
            chartArea63.Position.Auto = false;
            chartArea63.Position.Height = 100F;
            chartArea63.Position.Width = 100F;
            this.VoltageControlPositiveChart.ChartAreas.Add(chartArea63);
            this.VoltageControlPositiveChart.Location = new System.Drawing.Point(129, 78);
            this.VoltageControlPositiveChart.Name = "VoltageControlPositiveChart";
            series63.ChartArea = "ChartArea1";
            series63.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series63.Name = "Series1";
            series63.Points.Add(dataPoint33);
            this.VoltageControlPositiveChart.Series.Add(series63);
            this.VoltageControlPositiveChart.Size = new System.Drawing.Size(123, 20);
            this.VoltageControlPositiveChart.TabIndex = 15;
            this.VoltageControlPositiveChart.Text = "chart1";
            // 
            // VoltageControlSpeedLabel
            // 
            this.VoltageControlSpeedLabel.AutoSize = true;
            this.VoltageControlSpeedLabel.Location = new System.Drawing.Point(147, 39);
            this.VoltageControlSpeedLabel.Name = "VoltageControlSpeedLabel";
            this.VoltageControlSpeedLabel.Size = new System.Drawing.Size(90, 13);
            this.VoltageControlSpeedLabel.TabIndex = 15;
            this.VoltageControlSpeedLabel.Text = "Speed (Counts/s)";
            // 
            // VoltageControlSpeedTextBox
            // 
            this.VoltageControlSpeedTextBox.Location = new System.Drawing.Point(132, 55);
            this.VoltageControlSpeedTextBox.Name = "VoltageControlSpeedTextBox";
            this.VoltageControlSpeedTextBox.ReadOnly = true;
            this.VoltageControlSpeedTextBox.Size = new System.Drawing.Size(120, 20);
            this.VoltageControlSpeedTextBox.TabIndex = 15;
            // 
            // VoltageControlVoltageLabel
            // 
            this.VoltageControlVoltageLabel.AutoSize = true;
            this.VoltageControlVoltageLabel.Location = new System.Drawing.Point(37, 39);
            this.VoltageControlVoltageLabel.Name = "VoltageControlVoltageLabel";
            this.VoltageControlVoltageLabel.Size = new System.Drawing.Size(59, 13);
            this.VoltageControlVoltageLabel.TabIndex = 15;
            this.VoltageControlVoltageLabel.Text = "Voltage (V)";
            // 
            // VoltageControlVoltageUpDown
            // 
            this.VoltageControlVoltageUpDown.DecimalPlaces = 2;
            this.VoltageControlVoltageUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.VoltageControlVoltageUpDown.Location = new System.Drawing.Point(6, 55);
            this.VoltageControlVoltageUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.VoltageControlVoltageUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            -2147483648});
            this.VoltageControlVoltageUpDown.Name = "VoltageControlVoltageUpDown";
            this.VoltageControlVoltageUpDown.Size = new System.Drawing.Size(120, 20);
            this.VoltageControlVoltageUpDown.TabIndex = 12;
            this.VoltageControlVoltageUpDown.ValueChanged += new System.EventHandler(this.OnVoltageControlValueChanged);
            // 
            // DeadBandCompensationCheckBox
            // 
            this.DeadBandCompensationCheckBox.AutoSize = true;
            this.DeadBandCompensationCheckBox.Location = new System.Drawing.Point(42, 19);
            this.DeadBandCompensationCheckBox.Name = "DeadBandCompensationCheckBox";
            this.DeadBandCompensationCheckBox.Size = new System.Drawing.Size(186, 17);
            this.DeadBandCompensationCheckBox.TabIndex = 11;
            this.DeadBandCompensationCheckBox.Text = "Enable Dead-Band Compensation";
            this.DeadBandCompensationCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeadBandTestingGroupBox
            // 
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingRangeLabel);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandUpperUpDown);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingToLabel);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandLowerUpDown);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingLoadButton);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingPositionTextBox);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingPositionLabel);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingVoltageTextBox);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingSaveButton);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingVoltageLabel);
            this.DeadBandTestingGroupBox.Controls.Add(this.DeadBandTestingStartButton);
            this.DeadBandTestingGroupBox.Enabled = false;
            this.DeadBandTestingGroupBox.Location = new System.Drawing.Point(273, 19);
            this.DeadBandTestingGroupBox.Name = "DeadBandTestingGroupBox";
            this.DeadBandTestingGroupBox.Size = new System.Drawing.Size(258, 121);
            this.DeadBandTestingGroupBox.TabIndex = 11;
            this.DeadBandTestingGroupBox.TabStop = false;
            this.DeadBandTestingGroupBox.Text = "Dead-Band Testing";
            // 
            // DeadBandTestingRangeLabel
            // 
            this.DeadBandTestingRangeLabel.AutoSize = true;
            this.DeadBandTestingRangeLabel.Location = new System.Drawing.Point(60, 74);
            this.DeadBandTestingRangeLabel.Name = "DeadBandTestingRangeLabel";
            this.DeadBandTestingRangeLabel.Size = new System.Drawing.Size(139, 13);
            this.DeadBandTestingRangeLabel.TabIndex = 19;
            this.DeadBandTestingRangeLabel.Text = "Dead-Band Range in Binary";
            // 
            // DeadBandUpperUpDown
            // 
            this.DeadBandUpperUpDown.Location = new System.Drawing.Point(162, 90);
            this.DeadBandUpperUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DeadBandUpperUpDown.Name = "DeadBandUpperUpDown";
            this.DeadBandUpperUpDown.Size = new System.Drawing.Size(90, 20);
            this.DeadBandUpperUpDown.TabIndex = 12;
            this.DeadBandUpperUpDown.ValueChanged += new System.EventHandler(this.OnDeadBandMaxValueChanged);
            // 
            // DeadBandTestingToLabel
            // 
            this.DeadBandTestingToLabel.AutoSize = true;
            this.DeadBandTestingToLabel.Location = new System.Drawing.Point(121, 92);
            this.DeadBandTestingToLabel.Name = "DeadBandTestingToLabel";
            this.DeadBandTestingToLabel.Size = new System.Drawing.Size(16, 13);
            this.DeadBandTestingToLabel.TabIndex = 12;
            this.DeadBandTestingToLabel.Text = "to";
            // 
            // DeadBandLowerUpDown
            // 
            this.DeadBandLowerUpDown.Location = new System.Drawing.Point(6, 90);
            this.DeadBandLowerUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DeadBandLowerUpDown.Name = "DeadBandLowerUpDown";
            this.DeadBandLowerUpDown.Size = new System.Drawing.Size(90, 20);
            this.DeadBandLowerUpDown.TabIndex = 12;
            this.DeadBandLowerUpDown.ValueChanged += new System.EventHandler(this.OnDeadBandMinValueChanged);
            // 
            // DeadBandTestingLoadButton
            // 
            this.DeadBandTestingLoadButton.Location = new System.Drawing.Point(52, 48);
            this.DeadBandTestingLoadButton.Name = "DeadBandTestingLoadButton";
            this.DeadBandTestingLoadButton.Size = new System.Drawing.Size(40, 23);
            this.DeadBandTestingLoadButton.TabIndex = 18;
            this.DeadBandTestingLoadButton.Text = "Load";
            this.DeadBandTestingLoadButton.UseVisualStyleBackColor = true;
            // 
            // DeadBandTestingPositionTextBox
            // 
            this.DeadBandTestingPositionTextBox.Location = new System.Drawing.Point(178, 50);
            this.DeadBandTestingPositionTextBox.Name = "DeadBandTestingPositionTextBox";
            this.DeadBandTestingPositionTextBox.ReadOnly = true;
            this.DeadBandTestingPositionTextBox.Size = new System.Drawing.Size(74, 20);
            this.DeadBandTestingPositionTextBox.TabIndex = 17;
            // 
            // DeadBandTestingPositionLabel
            // 
            this.DeadBandTestingPositionLabel.AutoSize = true;
            this.DeadBandTestingPositionLabel.Location = new System.Drawing.Point(129, 53);
            this.DeadBandTestingPositionLabel.Name = "DeadBandTestingPositionLabel";
            this.DeadBandTestingPositionLabel.Size = new System.Drawing.Size(44, 13);
            this.DeadBandTestingPositionLabel.TabIndex = 16;
            this.DeadBandTestingPositionLabel.Text = "Position";
            // 
            // DeadBandTestingVoltageTextBox
            // 
            this.DeadBandTestingVoltageTextBox.Location = new System.Drawing.Point(178, 21);
            this.DeadBandTestingVoltageTextBox.Name = "DeadBandTestingVoltageTextBox";
            this.DeadBandTestingVoltageTextBox.ReadOnly = true;
            this.DeadBandTestingVoltageTextBox.Size = new System.Drawing.Size(74, 20);
            this.DeadBandTestingVoltageTextBox.TabIndex = 15;
            // 
            // DeadBandTestingSaveButton
            // 
            this.DeadBandTestingSaveButton.Location = new System.Drawing.Point(6, 48);
            this.DeadBandTestingSaveButton.Name = "DeadBandTestingSaveButton";
            this.DeadBandTestingSaveButton.Size = new System.Drawing.Size(40, 23);
            this.DeadBandTestingSaveButton.TabIndex = 14;
            this.DeadBandTestingSaveButton.Text = "Save";
            this.DeadBandTestingSaveButton.UseVisualStyleBackColor = true;
            // 
            // DeadBandTestingVoltageLabel
            // 
            this.DeadBandTestingVoltageLabel.AutoSize = true;
            this.DeadBandTestingVoltageLabel.Location = new System.Drawing.Point(129, 24);
            this.DeadBandTestingVoltageLabel.Name = "DeadBandTestingVoltageLabel";
            this.DeadBandTestingVoltageLabel.Size = new System.Drawing.Size(43, 13);
            this.DeadBandTestingVoltageLabel.TabIndex = 13;
            this.DeadBandTestingVoltageLabel.Text = "Voltage";
            // 
            // DeadBandTestingStartButton
            // 
            this.DeadBandTestingStartButton.Location = new System.Drawing.Point(6, 19);
            this.DeadBandTestingStartButton.Name = "DeadBandTestingStartButton";
            this.DeadBandTestingStartButton.Size = new System.Drawing.Size(86, 23);
            this.DeadBandTestingStartButton.TabIndex = 12;
            this.DeadBandTestingStartButton.Text = "Start";
            this.DeadBandTestingStartButton.UseVisualStyleBackColor = true;
            // 
            // PositionPlotGroupBox
            // 
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotRevsRadioButton);
            this.PositionPlotGroupBox.Controls.Add(this.chart1);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotCountsRadioButton);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotRadRadioButton);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotDegRadioButton);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotCurrentTextBox);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotCurrentLabel);
            this.PositionPlotGroupBox.Location = new System.Drawing.Point(6, 19);
            this.PositionPlotGroupBox.Name = "PositionPlotGroupBox";
            this.PositionPlotGroupBox.Size = new System.Drawing.Size(453, 140);
            this.PositionPlotGroupBox.TabIndex = 12;
            this.PositionPlotGroupBox.TabStop = false;
            this.PositionPlotGroupBox.Text = "Position";
            // 
            // PositionPlotRevsRadioButton
            // 
            this.PositionPlotRevsRadioButton.AutoSize = true;
            this.PositionPlotRevsRadioButton.Location = new System.Drawing.Point(389, 14);
            this.PositionPlotRevsRadioButton.Name = "PositionPlotRevsRadioButton";
            this.PositionPlotRevsRadioButton.Size = new System.Drawing.Size(50, 17);
            this.PositionPlotRevsRadioButton.TabIndex = 17;
            this.PositionPlotRevsRadioButton.TabStop = true;
            this.PositionPlotRevsRadioButton.Text = "Revs";
            this.PositionPlotRevsRadioButton.UseVisualStyleBackColor = true;
            this.PositionPlotRevsRadioButton.CheckedChanged += new System.EventHandler(this.OnPositionRadioChanged);
            // 
            // chart1
            // 
            chartArea64.AxisX.MajorGrid.Enabled = false;
            chartArea64.AxisY.MajorGrid.Interval = 2000D;
            chartArea64.AxisY.MajorGrid.IntervalOffset = 1D;
            chartArea64.AxisY.Maximum = 2000D;
            chartArea64.AxisY.Minimum = -2000D;
            chartArea64.Name = "ChartArea1";
            chartArea64.Position.Auto = false;
            chartArea64.Position.Height = 100F;
            chartArea64.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea64);
            this.chart1.Location = new System.Drawing.Point(9, 35);
            this.chart1.Name = "chart1";
            series64.ChartArea = "ChartArea1";
            series64.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series64.Name = "Series1";
            this.chart1.Series.Add(series64);
            this.chart1.Size = new System.Drawing.Size(438, 99);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // PositionPlotCountsRadioButton
            // 
            this.PositionPlotCountsRadioButton.AutoSize = true;
            this.PositionPlotCountsRadioButton.Location = new System.Drawing.Point(317, 14);
            this.PositionPlotCountsRadioButton.Name = "PositionPlotCountsRadioButton";
            this.PositionPlotCountsRadioButton.Size = new System.Drawing.Size(58, 17);
            this.PositionPlotCountsRadioButton.TabIndex = 15;
            this.PositionPlotCountsRadioButton.TabStop = true;
            this.PositionPlotCountsRadioButton.Text = "Counts";
            this.PositionPlotCountsRadioButton.UseVisualStyleBackColor = true;
            this.PositionPlotCountsRadioButton.CheckedChanged += new System.EventHandler(this.OnPositionRadioChanged);
            // 
            // PositionPlotRadRadioButton
            // 
            this.PositionPlotRadRadioButton.AutoSize = true;
            this.PositionPlotRadRadioButton.Location = new System.Drawing.Point(258, 14);
            this.PositionPlotRadRadioButton.Name = "PositionPlotRadRadioButton";
            this.PositionPlotRadRadioButton.Size = new System.Drawing.Size(45, 17);
            this.PositionPlotRadRadioButton.TabIndex = 13;
            this.PositionPlotRadRadioButton.Text = "Rad";
            this.PositionPlotRadRadioButton.UseVisualStyleBackColor = true;
            this.PositionPlotRadRadioButton.CheckedChanged += new System.EventHandler(this.OnPositionRadioChanged);
            // 
            // PositionPlotDegRadioButton
            // 
            this.PositionPlotDegRadioButton.AutoSize = true;
            this.PositionPlotDegRadioButton.Checked = true;
            this.PositionPlotDegRadioButton.Location = new System.Drawing.Point(199, 14);
            this.PositionPlotDegRadioButton.Name = "PositionPlotDegRadioButton";
            this.PositionPlotDegRadioButton.Size = new System.Drawing.Size(45, 17);
            this.PositionPlotDegRadioButton.TabIndex = 13;
            this.PositionPlotDegRadioButton.TabStop = true;
            this.PositionPlotDegRadioButton.Text = "Deg";
            this.PositionPlotDegRadioButton.UseVisualStyleBackColor = true;
            this.PositionPlotDegRadioButton.CheckedChanged += new System.EventHandler(this.OnPositionRadioChanged);
            // 
            // PositionPlotCurrentTextBox
            // 
            this.PositionPlotCurrentTextBox.Location = new System.Drawing.Point(93, 13);
            this.PositionPlotCurrentTextBox.Name = "PositionPlotCurrentTextBox";
            this.PositionPlotCurrentTextBox.ReadOnly = true;
            this.PositionPlotCurrentTextBox.Size = new System.Drawing.Size(100, 20);
            this.PositionPlotCurrentTextBox.TabIndex = 14;
            // 
            // PositionPlotCurrentLabel
            // 
            this.PositionPlotCurrentLabel.AutoSize = true;
            this.PositionPlotCurrentLabel.Location = new System.Drawing.Point(6, 16);
            this.PositionPlotCurrentLabel.Name = "PositionPlotCurrentLabel";
            this.PositionPlotCurrentLabel.Size = new System.Drawing.Size(81, 13);
            this.PositionPlotCurrentLabel.TabIndex = 13;
            this.PositionPlotCurrentLabel.Text = "Current Position";
            // 
            // VelocityPlotGroupBox
            // 
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotRPMRadioButton);
            this.VelocityPlotGroupBox.Controls.Add(this.chart2);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotCountsRadioButton);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotRadRadioButton);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotDegRadioButton);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotCurrentTextBox);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotCurrentLabel);
            this.VelocityPlotGroupBox.Location = new System.Drawing.Point(6, 165);
            this.VelocityPlotGroupBox.Name = "VelocityPlotGroupBox";
            this.VelocityPlotGroupBox.Size = new System.Drawing.Size(453, 140);
            this.VelocityPlotGroupBox.TabIndex = 13;
            this.VelocityPlotGroupBox.TabStop = false;
            this.VelocityPlotGroupBox.Text = "Velocity";
            // 
            // VelocityPlotRPMRadioButton
            // 
            this.VelocityPlotRPMRadioButton.AutoSize = true;
            this.VelocityPlotRPMRadioButton.Location = new System.Drawing.Point(389, 14);
            this.VelocityPlotRPMRadioButton.Name = "VelocityPlotRPMRadioButton";
            this.VelocityPlotRPMRadioButton.Size = new System.Drawing.Size(49, 17);
            this.VelocityPlotRPMRadioButton.TabIndex = 18;
            this.VelocityPlotRPMRadioButton.TabStop = true;
            this.VelocityPlotRPMRadioButton.Text = "RPM";
            this.VelocityPlotRPMRadioButton.UseVisualStyleBackColor = true;
            this.VelocityPlotRPMRadioButton.CheckedChanged += new System.EventHandler(this.OnVelocityRadioChanged);
            // 
            // chart2
            // 
            chartArea65.AxisX.MajorGrid.Enabled = false;
            chartArea65.AxisY.MajorGrid.Interval = 2000D;
            chartArea65.AxisY.MajorGrid.IntervalOffset = 1D;
            chartArea65.AxisY.Maximum = 1D;
            chartArea65.AxisY.Minimum = -1D;
            chartArea65.Name = "ChartArea1";
            chartArea65.Position.Auto = false;
            chartArea65.Position.Height = 100F;
            chartArea65.Position.Width = 100F;
            this.chart2.ChartAreas.Add(chartArea65);
            this.chart2.Location = new System.Drawing.Point(9, 35);
            this.chart2.Name = "chart2";
            series65.ChartArea = "ChartArea1";
            series65.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series65.Name = "Series1";
            this.chart2.Series.Add(series65);
            this.chart2.Size = new System.Drawing.Size(438, 99);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            // 
            // VelocityPlotCountsRadioButton
            // 
            this.VelocityPlotCountsRadioButton.AutoSize = true;
            this.VelocityPlotCountsRadioButton.Location = new System.Drawing.Point(317, 14);
            this.VelocityPlotCountsRadioButton.Name = "VelocityPlotCountsRadioButton";
            this.VelocityPlotCountsRadioButton.Size = new System.Drawing.Size(68, 17);
            this.VelocityPlotCountsRadioButton.TabIndex = 4;
            this.VelocityPlotCountsRadioButton.TabStop = true;
            this.VelocityPlotCountsRadioButton.Text = "Counts/s";
            this.VelocityPlotCountsRadioButton.UseVisualStyleBackColor = true;
            this.VelocityPlotCountsRadioButton.CheckedChanged += new System.EventHandler(this.OnVelocityRadioChanged);
            // 
            // VelocityPlotRadRadioButton
            // 
            this.VelocityPlotRadRadioButton.AutoSize = true;
            this.VelocityPlotRadRadioButton.Location = new System.Drawing.Point(258, 14);
            this.VelocityPlotRadRadioButton.Name = "VelocityPlotRadRadioButton";
            this.VelocityPlotRadRadioButton.Size = new System.Drawing.Size(55, 17);
            this.VelocityPlotRadRadioButton.TabIndex = 3;
            this.VelocityPlotRadRadioButton.TabStop = true;
            this.VelocityPlotRadRadioButton.Text = "Rad/s";
            this.VelocityPlotRadRadioButton.UseVisualStyleBackColor = true;
            this.VelocityPlotRadRadioButton.CheckedChanged += new System.EventHandler(this.OnVelocityRadioChanged);
            // 
            // VelocityPlotDegRadioButton
            // 
            this.VelocityPlotDegRadioButton.AutoSize = true;
            this.VelocityPlotDegRadioButton.Location = new System.Drawing.Point(199, 14);
            this.VelocityPlotDegRadioButton.Name = "VelocityPlotDegRadioButton";
            this.VelocityPlotDegRadioButton.Size = new System.Drawing.Size(55, 17);
            this.VelocityPlotDegRadioButton.TabIndex = 2;
            this.VelocityPlotDegRadioButton.TabStop = true;
            this.VelocityPlotDegRadioButton.Text = "Deg/s";
            this.VelocityPlotDegRadioButton.UseVisualStyleBackColor = true;
            this.VelocityPlotDegRadioButton.CheckedChanged += new System.EventHandler(this.OnVelocityRadioChanged);
            // 
            // VelocityPlotCurrentTextBox
            // 
            this.VelocityPlotCurrentTextBox.Location = new System.Drawing.Point(92, 13);
            this.VelocityPlotCurrentTextBox.Name = "VelocityPlotCurrentTextBox";
            this.VelocityPlotCurrentTextBox.ReadOnly = true;
            this.VelocityPlotCurrentTextBox.Size = new System.Drawing.Size(100, 20);
            this.VelocityPlotCurrentTextBox.TabIndex = 1;
            // 
            // VelocityPlotCurrentLabel
            // 
            this.VelocityPlotCurrentLabel.AutoSize = true;
            this.VelocityPlotCurrentLabel.Location = new System.Drawing.Point(6, 16);
            this.VelocityPlotCurrentLabel.Name = "VelocityPlotCurrentLabel";
            this.VelocityPlotCurrentLabel.Size = new System.Drawing.Size(81, 13);
            this.VelocityPlotCurrentLabel.TabIndex = 0;
            this.VelocityPlotCurrentLabel.Text = "Current Velocity";
            // 
            // AccelerationPlotGroupBox
            // 
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotRPMRadioButton);
            this.AccelerationPlotGroupBox.Controls.Add(this.chart3);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotCountsRadioButton);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotRadRadioButton);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotDegRadioButton);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotCurrentTextBox);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotCurrentLabel);
            this.AccelerationPlotGroupBox.Location = new System.Drawing.Point(6, 311);
            this.AccelerationPlotGroupBox.Name = "AccelerationPlotGroupBox";
            this.AccelerationPlotGroupBox.Size = new System.Drawing.Size(453, 140);
            this.AccelerationPlotGroupBox.TabIndex = 14;
            this.AccelerationPlotGroupBox.TabStop = false;
            this.AccelerationPlotGroupBox.Text = "Acceleration";
            // 
            // AccelerationPlotRPMRadioButton
            // 
            this.AccelerationPlotRPMRadioButton.AutoSize = true;
            this.AccelerationPlotRPMRadioButton.Location = new System.Drawing.Point(389, 14);
            this.AccelerationPlotRPMRadioButton.Name = "AccelerationPlotRPMRadioButton";
            this.AccelerationPlotRPMRadioButton.Size = new System.Drawing.Size(59, 17);
            this.AccelerationPlotRPMRadioButton.TabIndex = 20;
            this.AccelerationPlotRPMRadioButton.TabStop = true;
            this.AccelerationPlotRPMRadioButton.Text = "RPM/s";
            this.AccelerationPlotRPMRadioButton.UseVisualStyleBackColor = true;
            this.AccelerationPlotRPMRadioButton.CheckedChanged += new System.EventHandler(this.OnAccelerationRadioChanged);
            // 
            // chart3
            // 
            chartArea66.AxisX.MajorGrid.Enabled = false;
            chartArea66.AxisY.MajorGrid.Interval = 2000D;
            chartArea66.AxisY.MajorGrid.IntervalOffset = 1D;
            chartArea66.AxisY.Maximum = 0.1D;
            chartArea66.AxisY.Minimum = -0.1D;
            chartArea66.Name = "ChartArea1";
            chartArea66.Position.Auto = false;
            chartArea66.Position.Height = 100F;
            chartArea66.Position.Width = 100F;
            this.chart3.ChartAreas.Add(chartArea66);
            this.chart3.Location = new System.Drawing.Point(9, 37);
            this.chart3.Name = "chart3";
            series66.ChartArea = "ChartArea1";
            series66.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series66.Name = "Series1";
            this.chart3.Series.Add(series66);
            this.chart3.Size = new System.Drawing.Size(438, 99);
            this.chart3.TabIndex = 18;
            this.chart3.Text = "chart3";
            // 
            // AccelerationPlotCountsRadioButton
            // 
            this.AccelerationPlotCountsRadioButton.AutoSize = true;
            this.AccelerationPlotCountsRadioButton.Location = new System.Drawing.Point(317, 14);
            this.AccelerationPlotCountsRadioButton.Name = "AccelerationPlotCountsRadioButton";
            this.AccelerationPlotCountsRadioButton.Size = new System.Drawing.Size(71, 17);
            this.AccelerationPlotCountsRadioButton.TabIndex = 19;
            this.AccelerationPlotCountsRadioButton.TabStop = true;
            this.AccelerationPlotCountsRadioButton.Text = "Counts/s²";
            this.AccelerationPlotCountsRadioButton.UseVisualStyleBackColor = true;
            this.AccelerationPlotCountsRadioButton.CheckedChanged += new System.EventHandler(this.OnAccelerationRadioChanged);
            // 
            // AccelerationPlotRadRadioButton
            // 
            this.AccelerationPlotRadRadioButton.AutoSize = true;
            this.AccelerationPlotRadRadioButton.Location = new System.Drawing.Point(258, 14);
            this.AccelerationPlotRadRadioButton.Name = "AccelerationPlotRadRadioButton";
            this.AccelerationPlotRadRadioButton.Size = new System.Drawing.Size(58, 17);
            this.AccelerationPlotRadRadioButton.TabIndex = 18;
            this.AccelerationPlotRadRadioButton.TabStop = true;
            this.AccelerationPlotRadRadioButton.Text = "Rad/s²";
            this.AccelerationPlotRadRadioButton.UseVisualStyleBackColor = true;
            this.AccelerationPlotRadRadioButton.CheckedChanged += new System.EventHandler(this.OnAccelerationRadioChanged);
            // 
            // AccelerationPlotDegRadioButton
            // 
            this.AccelerationPlotDegRadioButton.AutoSize = true;
            this.AccelerationPlotDegRadioButton.Location = new System.Drawing.Point(198, 14);
            this.AccelerationPlotDegRadioButton.Name = "AccelerationPlotDegRadioButton";
            this.AccelerationPlotDegRadioButton.Size = new System.Drawing.Size(58, 17);
            this.AccelerationPlotDegRadioButton.TabIndex = 17;
            this.AccelerationPlotDegRadioButton.TabStop = true;
            this.AccelerationPlotDegRadioButton.Text = "Deg/s²";
            this.AccelerationPlotDegRadioButton.UseVisualStyleBackColor = true;
            this.AccelerationPlotDegRadioButton.CheckedChanged += new System.EventHandler(this.OnAccelerationRadioChanged);
            // 
            // AccelerationPlotCurrentTextBox
            // 
            this.AccelerationPlotCurrentTextBox.Location = new System.Drawing.Point(92, 13);
            this.AccelerationPlotCurrentTextBox.Name = "AccelerationPlotCurrentTextBox";
            this.AccelerationPlotCurrentTextBox.ReadOnly = true;
            this.AccelerationPlotCurrentTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccelerationPlotCurrentTextBox.TabIndex = 16;
            // 
            // AccelerationPlotCurrentLabel
            // 
            this.AccelerationPlotCurrentLabel.AutoSize = true;
            this.AccelerationPlotCurrentLabel.Location = new System.Drawing.Point(6, 16);
            this.AccelerationPlotCurrentLabel.Name = "AccelerationPlotCurrentLabel";
            this.AccelerationPlotCurrentLabel.Size = new System.Drawing.Size(74, 13);
            this.AccelerationPlotCurrentLabel.TabIndex = 15;
            this.AccelerationPlotCurrentLabel.Text = "Current Accel.";
            // 
            // GraphsGroupBox
            // 
            this.GraphsGroupBox.Controls.Add(this.PositionPlotGroupBox);
            this.GraphsGroupBox.Controls.Add(this.AccelerationPlotGroupBox);
            this.GraphsGroupBox.Controls.Add(this.VelocityPlotGroupBox);
            this.GraphsGroupBox.Location = new System.Drawing.Point(726, 47);
            this.GraphsGroupBox.Name = "GraphsGroupBox";
            this.GraphsGroupBox.Size = new System.Drawing.Size(466, 457);
            this.GraphsGroupBox.TabIndex = 15;
            this.GraphsGroupBox.TabStop = false;
            this.GraphsGroupBox.Text = "Graphs";
            // 
            // circlePlotPanel
            // 
            this.circlePlotPanel.Location = new System.Drawing.Point(321, 27);
            this.circlePlotPanel.Name = "circlePlotPanel";
            this.circlePlotPanel.Size = new System.Drawing.Size(184, 184);
            this.circlePlotPanel.TabIndex = 19;
            // 
            // IncomingDataGroupBox
            // 
            this.IncomingDataGroupBox.Controls.Add(this.DataModeLabel);
            this.IncomingDataGroupBox.Controls.Add(this.DataModeSelectionBox);
            this.IncomingDataGroupBox.Controls.Add(this.IncomingByteGroupBox);
            this.IncomingDataGroupBox.Location = new System.Drawing.Point(12, 105);
            this.IncomingDataGroupBox.Name = "IncomingDataGroupBox";
            this.IncomingDataGroupBox.Size = new System.Drawing.Size(273, 106);
            this.IncomingDataGroupBox.TabIndex = 21;
            this.IncomingDataGroupBox.TabStop = false;
            this.IncomingDataGroupBox.Text = "Incoming Data Controls";
            // 
            // DataModeLabel
            // 
            this.DataModeLabel.AutoSize = true;
            this.DataModeLabel.Location = new System.Drawing.Point(6, 19);
            this.DataModeLabel.Name = "DataModeLabel";
            this.DataModeLabel.Size = new System.Drawing.Size(87, 13);
            this.DataModeLabel.TabIndex = 1;
            this.DataModeLabel.Text = "Data Input Mode";
            this.toolTip1.SetToolTip(this.DataModeLabel, "The mode to be used for the incoming motor data");
            // 
            // DataModeSelectionBox
            // 
            this.DataModeSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataModeSelectionBox.FormattingEnabled = true;
            this.DataModeSelectionBox.Location = new System.Drawing.Point(99, 16);
            this.DataModeSelectionBox.Name = "DataModeSelectionBox";
            this.DataModeSelectionBox.Size = new System.Drawing.Size(168, 21);
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
            20000,
            0,
            0,
            0});
            this.PositionIntegerUpDown.Minimum = new decimal(new int[] {
            20000,
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
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testDataSettingsToolStripMenuItem,
            this.deadBandSettingsToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.configurationToolStripMenuItem.Text = "Settings";
            // 
            // testDataSettingsToolStripMenuItem
            // 
            this.testDataSettingsToolStripMenuItem.Name = "testDataSettingsToolStripMenuItem";
            this.testDataSettingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.testDataSettingsToolStripMenuItem.Text = "Test Data Settings";
            this.testDataSettingsToolStripMenuItem.ToolTipText = "Opens the Test Data settings window";
            this.testDataSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnTestDataSettingsMenuClick);
            // 
            // deadBandSettingsToolStripMenuItem
            // 
            this.deadBandSettingsToolStripMenuItem.Name = "deadBandSettingsToolStripMenuItem";
            this.deadBandSettingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deadBandSettingsToolStripMenuItem.Text = "Dead Band Settings";
            this.deadBandSettingsToolStripMenuItem.ToolTipText = "Opens the Dead Band settings window";
            this.deadBandSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnDeadBandSettingsMenuClicked);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1284, 550);
            this.Controls.Add(this.IncomingDataGroupBox);
            this.Controls.Add(this.circlePlotPanel);
            this.Controls.Add(this.GraphsGroupBox);
            this.Controls.Add(this.OutputsGroupBox);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.RawControlGroupBox.ResumeLayout(false);
            this.RawControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RawControlUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawBinaryChart)).EndInit();
            this.PositionControlGroupBox.ResumeLayout(false);
            this.PositionControlGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesiredPositionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionPUpDown)).EndInit();
            this.SpeedControlGroupBox.ResumeLayout(false);
            this.SpeedControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlNegativeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlPositiveChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlVoltageUpDown)).EndInit();
            this.DeadBandTestingGroupBox.ResumeLayout(false);
            this.DeadBandTestingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeadBandUpperUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeadBandLowerUpDown)).EndInit();
            this.PositionPlotGroupBox.ResumeLayout(false);
            this.PositionPlotGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.VelocityPlotGroupBox.ResumeLayout(false);
            this.VelocityPlotGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.AccelerationPlotGroupBox.ResumeLayout(false);
            this.AccelerationPlotGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.GraphsGroupBox.ResumeLayout(false);
            this.IncomingDataGroupBox.ResumeLayout(false);
            this.IncomingDataGroupBox.PerformLayout();
            this.IncomingByteGroupBox.ResumeLayout(false);
            this.IncomingByteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIntegerUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialComPort;
        private System.Windows.Forms.Timer ProgramLoopTimer;
        private System.Windows.Forms.ComboBox ComPortSelectionBox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MessageLogStatusStrip;
        private System.Windows.Forms.ComboBox ModeSelectionBox;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.Label ModeSelectionLabel;
        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.GroupBox OutputsGroupBox;
        private System.Windows.Forms.GroupBox RawControlGroupBox;
        private System.Windows.Forms.NumericUpDown RawControlUpDown;
        private System.Windows.Forms.Label RawControlDecimalLabel;
        private System.Windows.Forms.TextBox RawControlCurrentTextBox;
        private System.Windows.Forms.Label RawControlCurrentValueLabel;
        private System.Windows.Forms.GroupBox SpeedControlGroupBox;
        private System.Windows.Forms.NumericUpDown VoltageControlVoltageUpDown;
        private System.Windows.Forms.CheckBox DeadBandCompensationCheckBox;
        private System.Windows.Forms.GroupBox PositionControlGroupBox;
        private System.Windows.Forms.NumericUpDown PositionIUpDown;
        private System.Windows.Forms.NumericUpDown PositionDUpDown;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.NumericUpDown PositionPUpDown;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.RadioButton CountsRadioButton;
        private System.Windows.Forms.RadioButton RadiansRadioButton;
        private System.Windows.Forms.RadioButton DegRadioButton;
        private System.Windows.Forms.Label DesiredPositionLabel;
        private System.Windows.Forms.NumericUpDown DesiredPositionUpDown;
        private System.Windows.Forms.TextBox CurrentPositionTextBox;
        private System.Windows.Forms.Label CurrentPositionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox DeadBandTestingGroupBox;
        private System.Windows.Forms.Label DeadBandTestingRangeLabel;
        private System.Windows.Forms.NumericUpDown DeadBandUpperUpDown;
        private System.Windows.Forms.Label DeadBandTestingToLabel;
        private System.Windows.Forms.NumericUpDown DeadBandLowerUpDown;
        private System.Windows.Forms.Button DeadBandTestingLoadButton;
        private System.Windows.Forms.TextBox DeadBandTestingPositionTextBox;
        private System.Windows.Forms.Label DeadBandTestingPositionLabel;
        private System.Windows.Forms.TextBox DeadBandTestingVoltageTextBox;
        private System.Windows.Forms.Button DeadBandTestingSaveButton;
        private System.Windows.Forms.Label DeadBandTestingVoltageLabel;
        private System.Windows.Forms.Button DeadBandTestingStartButton;
        private System.Windows.Forms.GroupBox PositionPlotGroupBox;
        private System.Windows.Forms.RadioButton PositionPlotCountsRadioButton;
        private System.Windows.Forms.RadioButton PositionPlotRadRadioButton;
        private System.Windows.Forms.RadioButton PositionPlotDegRadioButton;
        private System.Windows.Forms.TextBox PositionPlotCurrentTextBox;
        private System.Windows.Forms.Label PositionPlotCurrentLabel;
        private System.Windows.Forms.GroupBox VelocityPlotGroupBox;
        private System.Windows.Forms.RadioButton VelocityPlotCountsRadioButton;
        private System.Windows.Forms.RadioButton VelocityPlotRadRadioButton;
        private System.Windows.Forms.RadioButton VelocityPlotDegRadioButton;
        private System.Windows.Forms.TextBox VelocityPlotCurrentTextBox;
        private System.Windows.Forms.Label VelocityPlotCurrentLabel;
        private System.Windows.Forms.GroupBox AccelerationPlotGroupBox;
        private System.Windows.Forms.RadioButton AccelerationPlotCountsRadioButton;
        private System.Windows.Forms.RadioButton AccelerationPlotRadRadioButton;
        private System.Windows.Forms.RadioButton AccelerationPlotDegRadioButton;
        private System.Windows.Forms.TextBox AccelerationPlotCurrentTextBox;
        private System.Windows.Forms.Label AccelerationPlotCurrentLabel;
        private System.Windows.Forms.Label VoltageControlSpeedLabel;
        private System.Windows.Forms.TextBox VoltageControlSpeedTextBox;
        private System.Windows.Forms.Label VoltageControlVoltageLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart RawBinaryChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageControlNegativeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageControlPositiveChart;
        private System.Windows.Forms.TextBox RawCurrentVoltageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RawVoltageTextBox;
        private System.Windows.Forms.GroupBox GraphsGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
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
        private System.Windows.Forms.RadioButton PositionPlotRevsRadioButton;
        private System.Windows.Forms.RadioButton VelocityPlotRPMRadioButton;
        private System.Windows.Forms.RadioButton AccelerationPlotRPMRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testDataSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadBandSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

