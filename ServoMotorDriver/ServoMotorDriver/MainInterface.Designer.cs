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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SerialComPort = new System.IO.Ports.SerialPort(this.components);
            this.SendReceiveTimer = new System.Windows.Forms.Timer(this.components);
            this.ComPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MessageLogStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.ModeSelectionBox = new System.Windows.Forms.ComboBox();
            this.DirectionSelectionBox = new System.Windows.Forms.ComboBox();
            this.PositionGraph = new ZedGraph.ZedGraphControl();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.ModeSelectionLabel = new System.Windows.Forms.Label();
            this.DirectionSelectionLabel = new System.Windows.Forms.Label();
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
            this.PositionPlotCountsRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionPlotRadRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionPlotDegRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionPlotCurrentTextBox = new System.Windows.Forms.TextBox();
            this.PositionPlotCurrentLabel = new System.Windows.Forms.Label();
            this.VelocityPlotGroupBox = new System.Windows.Forms.GroupBox();
            this.VelocityGraph = new ZedGraph.ZedGraphControl();
            this.VelocityPlotCountsRadioButton = new System.Windows.Forms.RadioButton();
            this.VelocityPlotRadRadioButton = new System.Windows.Forms.RadioButton();
            this.VelocityPlotDegRadioButton = new System.Windows.Forms.RadioButton();
            this.VelocityPlotCurrentTextBox = new System.Windows.Forms.TextBox();
            this.VelocityPlotCurrentLabel = new System.Windows.Forms.Label();
            this.AccelerationPlotGroupBox = new System.Windows.Forms.GroupBox();
            this.AccelerationGraph = new ZedGraph.ZedGraphControl();
            this.AccelerationPlotCountsRadioButton = new System.Windows.Forms.RadioButton();
            this.AccelerationPlotRadRadioButton = new System.Windows.Forms.RadioButton();
            this.AccelerationPlotDegRadioButton = new System.Windows.Forms.RadioButton();
            this.AccelerationPlotCurrentTextBox = new System.Windows.Forms.TextBox();
            this.AccelerationPlotCurrentLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.VelocityPlotGroupBox.SuspendLayout();
            this.AccelerationPlotGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // SendReceiveTimer
            // 
            this.SendReceiveTimer.Enabled = true;
            this.SendReceiveTimer.Tick += new System.EventHandler(this.SendReceiveUpdate);
            // 
            // ComPortSelectionBox
            // 
            this.ComPortSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortSelectionBox.FormattingEnabled = true;
            this.ComPortSelectionBox.Location = new System.Drawing.Point(65, 16);
            this.ComPortSelectionBox.Name = "ComPortSelectionBox";
            this.ComPortSelectionBox.Size = new System.Drawing.Size(202, 21);
            this.ComPortSelectionBox.TabIndex = 0;
            this.ComPortSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnComPortSelectionChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLogStatusStrip});
            this.StatusStrip.Location = new System.Drawing.Point(0, 574);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(854, 22);
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
            this.ModeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnModeSelectionChanged);
            // 
            // DirectionSelectionBox
            // 
            this.DirectionSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DirectionSelectionBox.FormattingEnabled = true;
            this.DirectionSelectionBox.Location = new System.Drawing.Point(65, 70);
            this.DirectionSelectionBox.Name = "DirectionSelectionBox";
            this.DirectionSelectionBox.Size = new System.Drawing.Size(202, 21);
            this.DirectionSelectionBox.TabIndex = 4;
            this.DirectionSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnDirectionSelectionChanged);
            // 
            // PositionGraph
            // 
            this.PositionGraph.IsShowCursorValues = true;
            this.PositionGraph.Location = new System.Drawing.Point(9, 37);
            this.PositionGraph.Name = "PositionGraph";
            this.PositionGraph.ScrollGrace = 0D;
            this.PositionGraph.ScrollMaxX = 0D;
            this.PositionGraph.ScrollMaxY = 0D;
            this.PositionGraph.ScrollMaxY2 = 0D;
            this.PositionGraph.ScrollMinX = 0D;
            this.PositionGraph.ScrollMinY = 0D;
            this.PositionGraph.ScrollMinY2 = 0D;
            this.PositionGraph.Size = new System.Drawing.Size(405, 97);
            this.PositionGraph.TabIndex = 5;
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Location = new System.Drawing.Point(6, 19);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(53, 13);
            this.ComPortLabel.TabIndex = 6;
            this.ComPortLabel.Text = "COM Port";
            // 
            // ModeSelectionLabel
            // 
            this.ModeSelectionLabel.AutoSize = true;
            this.ModeSelectionLabel.Location = new System.Drawing.Point(6, 46);
            this.ModeSelectionLabel.Name = "ModeSelectionLabel";
            this.ModeSelectionLabel.Size = new System.Drawing.Size(34, 13);
            this.ModeSelectionLabel.TabIndex = 7;
            this.ModeSelectionLabel.Text = "Mode";
            // 
            // DirectionSelectionLabel
            // 
            this.DirectionSelectionLabel.AutoSize = true;
            this.DirectionSelectionLabel.Location = new System.Drawing.Point(6, 73);
            this.DirectionSelectionLabel.Name = "DirectionSelectionLabel";
            this.DirectionSelectionLabel.Size = new System.Drawing.Size(49, 13);
            this.DirectionSelectionLabel.TabIndex = 8;
            this.DirectionSelectionLabel.Text = "Direction";
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Controls.Add(this.ComPortLabel);
            this.ConfigurationGroupBox.Controls.Add(this.DirectionSelectionLabel);
            this.ConfigurationGroupBox.Controls.Add(this.ComPortSelectionBox);
            this.ConfigurationGroupBox.Controls.Add(this.ModeSelectionLabel);
            this.ConfigurationGroupBox.Controls.Add(this.ModeSelectionBox);
            this.ConfigurationGroupBox.Controls.Add(this.DirectionSelectionBox);
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(12, 22);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(273, 100);
            this.ConfigurationGroupBox.TabIndex = 9;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Controller Configuration";
            // 
            // OutputsGroupBox
            // 
            this.OutputsGroupBox.Controls.Add(this.RawControlGroupBox);
            this.OutputsGroupBox.Controls.Add(this.PositionControlGroupBox);
            this.OutputsGroupBox.Controls.Add(this.SpeedControlGroupBox);
            this.OutputsGroupBox.Location = new System.Drawing.Point(12, 137);
            this.OutputsGroupBox.Name = "OutputsGroupBox";
            this.OutputsGroupBox.Size = new System.Drawing.Size(273, 432);
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
            chartArea9.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.AxisX.MajorGrid.Enabled = false;
            chartArea9.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.AxisX2.MajorGrid.Enabled = false;
            chartArea9.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.AxisY.MajorGrid.Enabled = false;
            chartArea9.AxisY.Maximum = 255D;
            chartArea9.AxisY.Minimum = 5D;
            chartArea9.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.AxisY2.MajorGrid.Enabled = false;
            chartArea9.BackColor = System.Drawing.SystemColors.Control;
            chartArea9.Name = "ChartArea1";
            chartArea9.Position.Auto = false;
            chartArea9.Position.Height = 100F;
            chartArea9.Position.Width = 100F;
            this.RawBinaryChart.ChartAreas.Add(chartArea9);
            this.RawBinaryChart.Location = new System.Drawing.Point(6, 95);
            this.RawBinaryChart.Margin = new System.Windows.Forms.Padding(0);
            this.RawBinaryChart.Name = "RawBinaryChart";
            series9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series9.Name = "Series1";
            series9.Points.Add(dataPoint7);
            this.RawBinaryChart.Series.Add(series9);
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
            this.PositionControlGroupBox.Location = new System.Drawing.Point(9, 291);
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
            this.SpeedControlGroupBox.Location = new System.Drawing.Point(9, 164);
            this.SpeedControlGroupBox.Name = "SpeedControlGroupBox";
            this.SpeedControlGroupBox.Size = new System.Drawing.Size(258, 103);
            this.SpeedControlGroupBox.TabIndex = 11;
            this.SpeedControlGroupBox.TabStop = false;
            this.SpeedControlGroupBox.Text = "Speed/Voltage Control";
            // 
            // VoltageControlNegativeChart
            // 
            this.VoltageControlNegativeChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea10.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea10.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea10.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea10.AxisY.IsReversed = true;
            chartArea10.AxisY.Maximum = 16D;
            chartArea10.AxisY.Minimum = 0D;
            chartArea10.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea10.BackColor = System.Drawing.SystemColors.Control;
            chartArea10.Name = "ChartArea1";
            chartArea10.Position.Auto = false;
            chartArea10.Position.Height = 100F;
            chartArea10.Position.Width = 100F;
            this.VoltageControlNegativeChart.ChartAreas.Add(chartArea10);
            this.VoltageControlNegativeChart.Location = new System.Drawing.Point(6, 78);
            this.VoltageControlNegativeChart.Name = "VoltageControlNegativeChart";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series10.Name = "Series1";
            dataPoint8.Color = System.Drawing.Color.Red;
            series10.Points.Add(dataPoint8);
            this.VoltageControlNegativeChart.Series.Add(series10);
            this.VoltageControlNegativeChart.Size = new System.Drawing.Size(123, 20);
            this.VoltageControlNegativeChart.TabIndex = 16;
            this.VoltageControlNegativeChart.Text = "chart2";
            // 
            // VoltageControlPositiveChart
            // 
            this.VoltageControlPositiveChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea11.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea11.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea11.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea11.AxisY.Maximum = 16D;
            chartArea11.AxisY.Minimum = 0D;
            chartArea11.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea11.BackColor = System.Drawing.SystemColors.Control;
            chartArea11.Name = "ChartArea1";
            chartArea11.Position.Auto = false;
            chartArea11.Position.Height = 100F;
            chartArea11.Position.Width = 100F;
            this.VoltageControlPositiveChart.ChartAreas.Add(chartArea11);
            this.VoltageControlPositiveChart.Location = new System.Drawing.Point(129, 78);
            this.VoltageControlPositiveChart.Name = "VoltageControlPositiveChart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.Name = "Series1";
            series11.Points.Add(dataPoint9);
            this.VoltageControlPositiveChart.Series.Add(series11);
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
            this.DeadBandTestingGroupBox.Location = new System.Drawing.Point(291, 12);
            this.DeadBandTestingGroupBox.Name = "DeadBandTestingGroupBox";
            this.DeadBandTestingGroupBox.Size = new System.Drawing.Size(244, 119);
            this.DeadBandTestingGroupBox.TabIndex = 11;
            this.DeadBandTestingGroupBox.TabStop = false;
            this.DeadBandTestingGroupBox.Text = "Dead-Band Testing";
            // 
            // DeadBandTestingRangeLabel
            // 
            this.DeadBandTestingRangeLabel.AutoSize = true;
            this.DeadBandTestingRangeLabel.Location = new System.Drawing.Point(53, 74);
            this.DeadBandTestingRangeLabel.Name = "DeadBandTestingRangeLabel";
            this.DeadBandTestingRangeLabel.Size = new System.Drawing.Size(139, 13);
            this.DeadBandTestingRangeLabel.TabIndex = 19;
            this.DeadBandTestingRangeLabel.Text = "Dead-Band Range in Binary";
            // 
            // DeadBandUpperUpDown
            // 
            this.DeadBandUpperUpDown.Location = new System.Drawing.Point(148, 90);
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
            this.DeadBandTestingToLabel.Location = new System.Drawing.Point(114, 92);
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
            this.DeadBandTestingPositionTextBox.Location = new System.Drawing.Point(164, 50);
            this.DeadBandTestingPositionTextBox.Name = "DeadBandTestingPositionTextBox";
            this.DeadBandTestingPositionTextBox.ReadOnly = true;
            this.DeadBandTestingPositionTextBox.Size = new System.Drawing.Size(74, 20);
            this.DeadBandTestingPositionTextBox.TabIndex = 17;
            // 
            // DeadBandTestingPositionLabel
            // 
            this.DeadBandTestingPositionLabel.AutoSize = true;
            this.DeadBandTestingPositionLabel.Location = new System.Drawing.Point(113, 53);
            this.DeadBandTestingPositionLabel.Name = "DeadBandTestingPositionLabel";
            this.DeadBandTestingPositionLabel.Size = new System.Drawing.Size(44, 13);
            this.DeadBandTestingPositionLabel.TabIndex = 16;
            this.DeadBandTestingPositionLabel.Text = "Position";
            // 
            // DeadBandTestingVoltageTextBox
            // 
            this.DeadBandTestingVoltageTextBox.Location = new System.Drawing.Point(164, 21);
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
            this.DeadBandTestingVoltageLabel.Location = new System.Drawing.Point(114, 24);
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
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotCountsRadioButton);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotRadRadioButton);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotDegRadioButton);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotCurrentTextBox);
            this.PositionPlotGroupBox.Controls.Add(this.PositionGraph);
            this.PositionPlotGroupBox.Controls.Add(this.PositionPlotCurrentLabel);
            this.PositionPlotGroupBox.Location = new System.Drawing.Point(291, 137);
            this.PositionPlotGroupBox.Name = "PositionPlotGroupBox";
            this.PositionPlotGroupBox.Size = new System.Drawing.Size(420, 140);
            this.PositionPlotGroupBox.TabIndex = 12;
            this.PositionPlotGroupBox.TabStop = false;
            this.PositionPlotGroupBox.Text = "Position";
            // 
            // PositionPlotCountsRadioButton
            // 
            this.PositionPlotCountsRadioButton.AutoSize = true;
            this.PositionPlotCountsRadioButton.Location = new System.Drawing.Point(326, 14);
            this.PositionPlotCountsRadioButton.Name = "PositionPlotCountsRadioButton";
            this.PositionPlotCountsRadioButton.Size = new System.Drawing.Size(58, 17);
            this.PositionPlotCountsRadioButton.TabIndex = 15;
            this.PositionPlotCountsRadioButton.TabStop = true;
            this.PositionPlotCountsRadioButton.Text = "Counts";
            this.PositionPlotCountsRadioButton.UseVisualStyleBackColor = true;
            // 
            // PositionPlotRadRadioButton
            // 
            this.PositionPlotRadRadioButton.AutoSize = true;
            this.PositionPlotRadRadioButton.Location = new System.Drawing.Point(262, 14);
            this.PositionPlotRadRadioButton.Name = "PositionPlotRadRadioButton";
            this.PositionPlotRadRadioButton.Size = new System.Drawing.Size(45, 17);
            this.PositionPlotRadRadioButton.TabIndex = 13;
            this.PositionPlotRadRadioButton.Text = "Rad";
            this.PositionPlotRadRadioButton.UseVisualStyleBackColor = true;
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
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityGraph);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotCountsRadioButton);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotRadRadioButton);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotDegRadioButton);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotCurrentTextBox);
            this.VelocityPlotGroupBox.Controls.Add(this.VelocityPlotCurrentLabel);
            this.VelocityPlotGroupBox.Location = new System.Drawing.Point(291, 283);
            this.VelocityPlotGroupBox.Name = "VelocityPlotGroupBox";
            this.VelocityPlotGroupBox.Size = new System.Drawing.Size(420, 140);
            this.VelocityPlotGroupBox.TabIndex = 13;
            this.VelocityPlotGroupBox.TabStop = false;
            this.VelocityPlotGroupBox.Text = "Velocity";
            // 
            // VelocityGraph
            // 
            this.VelocityGraph.Location = new System.Drawing.Point(9, 39);
            this.VelocityGraph.Name = "VelocityGraph";
            this.VelocityGraph.ScrollGrace = 0D;
            this.VelocityGraph.ScrollMaxX = 0D;
            this.VelocityGraph.ScrollMaxY = 0D;
            this.VelocityGraph.ScrollMaxY2 = 0D;
            this.VelocityGraph.ScrollMinX = 0D;
            this.VelocityGraph.ScrollMinY = 0D;
            this.VelocityGraph.ScrollMinY2 = 0D;
            this.VelocityGraph.Size = new System.Drawing.Size(405, 95);
            this.VelocityGraph.TabIndex = 0;
            // 
            // VelocityPlotCountsRadioButton
            // 
            this.VelocityPlotCountsRadioButton.AutoSize = true;
            this.VelocityPlotCountsRadioButton.Location = new System.Drawing.Point(326, 14);
            this.VelocityPlotCountsRadioButton.Name = "VelocityPlotCountsRadioButton";
            this.VelocityPlotCountsRadioButton.Size = new System.Drawing.Size(68, 17);
            this.VelocityPlotCountsRadioButton.TabIndex = 4;
            this.VelocityPlotCountsRadioButton.TabStop = true;
            this.VelocityPlotCountsRadioButton.Text = "Counts/s";
            this.VelocityPlotCountsRadioButton.UseVisualStyleBackColor = true;
            // 
            // VelocityPlotRadRadioButton
            // 
            this.VelocityPlotRadRadioButton.AutoSize = true;
            this.VelocityPlotRadRadioButton.Location = new System.Drawing.Point(262, 14);
            this.VelocityPlotRadRadioButton.Name = "VelocityPlotRadRadioButton";
            this.VelocityPlotRadRadioButton.Size = new System.Drawing.Size(55, 17);
            this.VelocityPlotRadRadioButton.TabIndex = 3;
            this.VelocityPlotRadRadioButton.TabStop = true;
            this.VelocityPlotRadRadioButton.Text = "Rad/s";
            this.VelocityPlotRadRadioButton.UseVisualStyleBackColor = true;
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
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationGraph);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotCountsRadioButton);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotRadRadioButton);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotDegRadioButton);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotCurrentTextBox);
            this.AccelerationPlotGroupBox.Controls.Add(this.AccelerationPlotCurrentLabel);
            this.AccelerationPlotGroupBox.Location = new System.Drawing.Point(291, 429);
            this.AccelerationPlotGroupBox.Name = "AccelerationPlotGroupBox";
            this.AccelerationPlotGroupBox.Size = new System.Drawing.Size(420, 140);
            this.AccelerationPlotGroupBox.TabIndex = 14;
            this.AccelerationPlotGroupBox.TabStop = false;
            this.AccelerationPlotGroupBox.Text = "Acceleration";
            // 
            // AccelerationGraph
            // 
            this.AccelerationGraph.Location = new System.Drawing.Point(9, 39);
            this.AccelerationGraph.Name = "AccelerationGraph";
            this.AccelerationGraph.ScrollGrace = 0D;
            this.AccelerationGraph.ScrollMaxX = 0D;
            this.AccelerationGraph.ScrollMaxY = 0D;
            this.AccelerationGraph.ScrollMaxY2 = 0D;
            this.AccelerationGraph.ScrollMinX = 0D;
            this.AccelerationGraph.ScrollMinY = 0D;
            this.AccelerationGraph.ScrollMinY2 = 0D;
            this.AccelerationGraph.Size = new System.Drawing.Size(405, 95);
            this.AccelerationGraph.TabIndex = 20;
            // 
            // AccelerationPlotCountsRadioButton
            // 
            this.AccelerationPlotCountsRadioButton.AutoSize = true;
            this.AccelerationPlotCountsRadioButton.Location = new System.Drawing.Point(326, 14);
            this.AccelerationPlotCountsRadioButton.Name = "AccelerationPlotCountsRadioButton";
            this.AccelerationPlotCountsRadioButton.Size = new System.Drawing.Size(71, 17);
            this.AccelerationPlotCountsRadioButton.TabIndex = 19;
            this.AccelerationPlotCountsRadioButton.TabStop = true;
            this.AccelerationPlotCountsRadioButton.Text = "Counts/s²";
            this.AccelerationPlotCountsRadioButton.UseVisualStyleBackColor = true;
            // 
            // AccelerationPlotRadRadioButton
            // 
            this.AccelerationPlotRadRadioButton.AutoSize = true;
            this.AccelerationPlotRadRadioButton.Location = new System.Drawing.Point(262, 14);
            this.AccelerationPlotRadRadioButton.Name = "AccelerationPlotRadRadioButton";
            this.AccelerationPlotRadRadioButton.Size = new System.Drawing.Size(58, 17);
            this.AccelerationPlotRadRadioButton.TabIndex = 18;
            this.AccelerationPlotRadRadioButton.TabStop = true;
            this.AccelerationPlotRadRadioButton.Text = "Rad/s²";
            this.AccelerationPlotRadRadioButton.UseVisualStyleBackColor = true;
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
            // chart1
            // 
            chartArea12.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea12.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea12.AxisY.MajorGrid.Enabled = false;
            chartArea12.AxisY.MajorTickMark.Enabled = false;
            chartArea12.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea12.Name = "ChartArea1";
            chartArea12.Position.Auto = false;
            chartArea12.Position.Height = 94F;
            chartArea12.Position.Width = 100F;
            chartArea12.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea12);
            this.chart1.Location = new System.Drawing.Point(542, 16);
            this.chart1.Name = "chart1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Name = "Series1";
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(300, 97);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(854, 596);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.AccelerationPlotGroupBox);
            this.Controls.Add(this.VelocityPlotGroupBox);
            this.Controls.Add(this.PositionPlotGroupBox);
            this.Controls.Add(this.DeadBandTestingGroupBox);
            this.Controls.Add(this.OutputsGroupBox);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.StatusStrip);
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servo Motor Driver";
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
            this.VelocityPlotGroupBox.ResumeLayout(false);
            this.VelocityPlotGroupBox.PerformLayout();
            this.AccelerationPlotGroupBox.ResumeLayout(false);
            this.AccelerationPlotGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialComPort;
        private System.Windows.Forms.Timer SendReceiveTimer;
        private System.Windows.Forms.ComboBox ComPortSelectionBox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MessageLogStatusStrip;
        private System.Windows.Forms.ComboBox ModeSelectionBox;
        private System.Windows.Forms.ComboBox DirectionSelectionBox;
        private ZedGraph.ZedGraphControl PositionGraph;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.Label ModeSelectionLabel;
        private System.Windows.Forms.Label DirectionSelectionLabel;
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
        private ZedGraph.ZedGraphControl VelocityGraph;
        private ZedGraph.ZedGraphControl AccelerationGraph;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

