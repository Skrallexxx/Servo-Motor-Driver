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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
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
            this.label1 = new System.Windows.Forms.Label();
            this.RawVoltageTextBox = new System.Windows.Forms.TextBox();
            this.RawControlDecimalLabel = new System.Windows.Forms.Label();
            this.RawControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.RawBinaryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PositionControlGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DegRadioButton = new System.Windows.Forms.RadioButton();
            this.RadiansRadioButton = new System.Windows.Forms.RadioButton();
            this.CountsRadioButton = new System.Windows.Forms.RadioButton();
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
            this.VoltageControlVoltageLabel = new System.Windows.Forms.Label();
            this.VoltageControlVoltageUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeadBandCompensationCheckBox = new System.Windows.Forms.CheckBox();
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
            this.testDataSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.IncomingDataGroupBox.SuspendLayout();
            this.IncomingByteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionIntegerUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.MotorDataGroupBox.SuspendLayout();
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
            this.StatusStrip.Location = new System.Drawing.Point(0, 480);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(732, 22);
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
            this.OutputsGroupBox.Location = new System.Drawing.Point(12, 217);
            this.OutputsGroupBox.Name = "OutputsGroupBox";
            this.OutputsGroupBox.Size = new System.Drawing.Size(707, 258);
            this.OutputsGroupBox.TabIndex = 10;
            this.OutputsGroupBox.TabStop = false;
            this.OutputsGroupBox.Text = "Outputs";
            // 
            // RawControlGroupBox
            // 
            this.RawControlGroupBox.Controls.Add(this.label1);
            this.RawControlGroupBox.Controls.Add(this.RawVoltageTextBox);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Voltage Value (V)";
            // 
            // RawVoltageTextBox
            // 
            this.RawVoltageTextBox.Location = new System.Drawing.Point(132, 32);
            this.RawVoltageTextBox.Name = "RawVoltageTextBox";
            this.RawVoltageTextBox.ReadOnly = true;
            this.RawVoltageTextBox.Size = new System.Drawing.Size(120, 20);
            this.RawVoltageTextBox.TabIndex = 15;
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
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 255D;
            chartArea1.AxisY.Minimum = 5D;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.RawBinaryChart.ChartAreas.Add(chartArea1);
            this.RawBinaryChart.Location = new System.Drawing.Point(6, 95);
            this.RawBinaryChart.Margin = new System.Windows.Forms.Padding(0);
            this.RawBinaryChart.Name = "RawBinaryChart";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            this.RawBinaryChart.Series.Add(series1);
            this.RawBinaryChart.Size = new System.Drawing.Size(246, 20);
            this.RawBinaryChart.TabIndex = 15;
            this.RawBinaryChart.Text = "chart1";
            // 
            // PositionControlGroupBox
            // 
            this.PositionControlGroupBox.Controls.Add(this.panel1);
            this.PositionControlGroupBox.Controls.Add(this.DesiredPositionLabel);
            this.PositionControlGroupBox.Controls.Add(this.DesiredPositionUpDown);
            this.PositionControlGroupBox.Controls.Add(this.DLabel);
            this.PositionControlGroupBox.Controls.Add(this.ILabel);
            this.PositionControlGroupBox.Controls.Add(this.PositionIUpDown);
            this.PositionControlGroupBox.Controls.Add(this.PositionDUpDown);
            this.PositionControlGroupBox.Controls.Add(this.PLabel);
            this.PositionControlGroupBox.Controls.Add(this.PositionPUpDown);
            this.PositionControlGroupBox.Enabled = false;
            this.PositionControlGroupBox.Location = new System.Drawing.Point(273, 19);
            this.PositionControlGroupBox.Name = "PositionControlGroupBox";
            this.PositionControlGroupBox.Size = new System.Drawing.Size(258, 136);
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
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlVoltageLabel);
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlVoltageUpDown);
            this.SpeedControlGroupBox.Controls.Add(this.DeadBandCompensationCheckBox);
            this.SpeedControlGroupBox.Enabled = false;
            this.SpeedControlGroupBox.Location = new System.Drawing.Point(9, 146);
            this.SpeedControlGroupBox.Name = "SpeedControlGroupBox";
            this.SpeedControlGroupBox.Size = new System.Drawing.Size(258, 104);
            this.SpeedControlGroupBox.TabIndex = 11;
            this.SpeedControlGroupBox.TabStop = false;
            this.SpeedControlGroupBox.Text = "Speed/Voltage Control";
            // 
            // VoltageControlNegativeChart
            // 
            this.VoltageControlNegativeChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.IsReversed = true;
            chartArea2.AxisY.Maximum = 16D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.VoltageControlNegativeChart.ChartAreas.Add(chartArea2);
            this.VoltageControlNegativeChart.Location = new System.Drawing.Point(6, 78);
            this.VoltageControlNegativeChart.Name = "VoltageControlNegativeChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Name = "Series1";
            dataPoint2.Color = System.Drawing.Color.Red;
            series2.Points.Add(dataPoint2);
            this.VoltageControlNegativeChart.Series.Add(series2);
            this.VoltageControlNegativeChart.Size = new System.Drawing.Size(123, 20);
            this.VoltageControlNegativeChart.TabIndex = 16;
            this.VoltageControlNegativeChart.Text = "chart2";
            // 
            // VoltageControlPositiveChart
            // 
            this.VoltageControlPositiveChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.Maximum = 16D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 100F;
            this.VoltageControlPositiveChart.ChartAreas.Add(chartArea3);
            this.VoltageControlPositiveChart.Location = new System.Drawing.Point(129, 78);
            this.VoltageControlPositiveChart.Name = "VoltageControlPositiveChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Name = "Series1";
            series3.Points.Add(dataPoint3);
            this.VoltageControlPositiveChart.Series.Add(series3);
            this.VoltageControlPositiveChart.Size = new System.Drawing.Size(123, 20);
            this.VoltageControlPositiveChart.TabIndex = 15;
            this.VoltageControlPositiveChart.Text = "chart1";
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
            // circlePlotPanel
            // 
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
            this.viewToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
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
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.graphsToolStripMenuItem.Text = "Graphs";
            this.graphsToolStripMenuItem.Click += new System.EventHandler(this.OnGraphsMenuClicked);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realtimeDataSettingsToolStripMenuItem,
            this.testDataSettingsToolStripMenuItem,
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
            // testDataSettingsToolStripMenuItem
            // 
            this.testDataSettingsToolStripMenuItem.Name = "testDataSettingsToolStripMenuItem";
            this.testDataSettingsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.testDataSettingsToolStripMenuItem.Text = "Test Data Settings";
            this.testDataSettingsToolStripMenuItem.ToolTipText = "Opens the Test Data settings window";
            this.testDataSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnTestDataSettingsMenuClick);
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
            this.label10.Location = new System.Drawing.Point(147, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Current Voltage (V)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Current Binary";
            // 
            // CurrentVoltageTextBox
            // 
            this.CurrentVoltageTextBox.Location = new System.Drawing.Point(140, 32);
            this.CurrentVoltageTextBox.Name = "CurrentVoltageTextBox";
            this.CurrentVoltageTextBox.ReadOnly = true;
            this.CurrentVoltageTextBox.Size = new System.Drawing.Size(110, 20);
            this.CurrentVoltageTextBox.TabIndex = 13;
            // 
            // CurrentBinaryTextBox
            // 
            this.CurrentBinaryTextBox.Location = new System.Drawing.Point(6, 32);
            this.CurrentBinaryTextBox.Name = "CurrentBinaryTextBox";
            this.CurrentBinaryTextBox.ReadOnly = true;
            this.CurrentBinaryTextBox.Size = new System.Drawing.Size(110, 20);
            this.CurrentBinaryTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Unit";
            // 
            // CurrentAccelerationUnitSelectionBox
            // 
            this.CurrentAccelerationUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentAccelerationUnitSelectionBox.FormattingEnabled = true;
            this.CurrentAccelerationUnitSelectionBox.Location = new System.Drawing.Point(160, 149);
            this.CurrentAccelerationUnitSelectionBox.Name = "CurrentAccelerationUnitSelectionBox";
            this.CurrentAccelerationUnitSelectionBox.Size = new System.Drawing.Size(90, 21);
            this.CurrentAccelerationUnitSelectionBox.TabIndex = 10;
            this.CurrentAccelerationUnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnAccelerationUnitSelectionChanged);
            // 
            // CurrentAccelerationTextBox
            // 
            this.CurrentAccelerationTextBox.Location = new System.Drawing.Point(6, 149);
            this.CurrentAccelerationTextBox.Name = "CurrentAccelerationTextBox";
            this.CurrentAccelerationTextBox.ReadOnly = true;
            this.CurrentAccelerationTextBox.Size = new System.Drawing.Size(148, 20);
            this.CurrentAccelerationTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Acceleration";
            // 
            // CurrentVelocityUnitSelectionBox
            // 
            this.CurrentVelocityUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.label6.Location = new System.Drawing.Point(199, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Velocity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position";
            // 
            // CurrentPositionUnitSelectionBox
            // 
            this.CurrentPositionUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentPositionUnitSelectionBox.FormattingEnabled = true;
            this.CurrentPositionUnitSelectionBox.Location = new System.Drawing.Point(160, 71);
            this.CurrentPositionUnitSelectionBox.Name = "CurrentPositionUnitSelectionBox";
            this.CurrentPositionUnitSelectionBox.Size = new System.Drawing.Size(90, 21);
            this.CurrentPositionUnitSelectionBox.TabIndex = 2;
            this.CurrentPositionUnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnPositionUnitSelectionChanged);
            // 
            // CurrentVelocityTextBox
            // 
            this.CurrentVelocityTextBox.Location = new System.Drawing.Point(6, 110);
            this.CurrentVelocityTextBox.Name = "CurrentVelocityTextBox";
            this.CurrentVelocityTextBox.ReadOnly = true;
            this.CurrentVelocityTextBox.Size = new System.Drawing.Size(148, 20);
            this.CurrentVelocityTextBox.TabIndex = 1;
            // 
            // CurrentPositionTextBox
            // 
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
            this.ClientSize = new System.Drawing.Size(732, 502);
            this.Controls.Add(this.MotorDataGroupBox);
            this.Controls.Add(this.IncomingDataGroupBox);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VoltageControlVoltageLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart RawBinaryChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageControlNegativeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageControlPositiveChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RawVoltageTextBox;
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
        private System.Windows.Forms.ToolStripMenuItem testDataSettingsToolStripMenuItem;
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
    }
}

