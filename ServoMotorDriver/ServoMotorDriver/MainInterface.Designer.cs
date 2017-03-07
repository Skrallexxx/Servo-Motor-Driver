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
            this.SerialComPort = new System.IO.Ports.SerialPort(this.components);
            this.SendReceiveTimer = new System.Windows.Forms.Timer(this.components);
            this.ComPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MessageLogStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.ModeSelectionBox = new System.Windows.Forms.ComboBox();
            this.DirectionSelectionBox = new System.Windows.Forms.ComboBox();
            this.Graph = new ZedGraph.ZedGraphControl();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.ModeSelectionLabel = new System.Windows.Forms.Label();
            this.DirectionSelectionLabel = new System.Windows.Forms.Label();
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputsGroupBox = new System.Windows.Forms.GroupBox();
            this.SpeedControlGroupBox = new System.Windows.Forms.GroupBox();
            this.SpeedControlProgressBar = new System.Windows.Forms.ProgressBar();
            this.VoltageControlRadioButton = new System.Windows.Forms.RadioButton();
            this.VoltageControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeedControlRadioButton = new System.Windows.Forms.RadioButton();
            this.DeadBandCompensationCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeedControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.RawControlGroupBox = new System.Windows.Forms.GroupBox();
            this.RawControlCurrentValueLabel = new System.Windows.Forms.Label();
            this.RawControlCurrentTextBox = new System.Windows.Forms.TextBox();
            this.RawControlDecimalLabel = new System.Windows.Forms.Label();
            this.RawControlProgressBar = new System.Windows.Forms.ProgressBar();
            this.RawControlUpDown = new System.Windows.Forms.NumericUpDown();
            this.PositionControlGroupBox = new System.Windows.Forms.GroupBox();
            this.PIDControlGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusStrip.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.OutputsGroupBox.SuspendLayout();
            this.SpeedControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedControlUpDown)).BeginInit();
            this.RawControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RawControlUpDown)).BeginInit();
            this.PositionControlGroupBox.SuspendLayout();
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
            this.StatusStrip.Location = new System.Drawing.Point(0, 601);
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
            // Graph
            // 
            this.Graph.IsShowCursorValues = true;
            this.Graph.Location = new System.Drawing.Point(302, 195);
            this.Graph.Name = "Graph";
            this.Graph.ScrollGrace = 0D;
            this.Graph.ScrollMaxX = 0D;
            this.Graph.ScrollMaxY = 0D;
            this.Graph.ScrollMaxY2 = 0D;
            this.Graph.ScrollMinX = 0D;
            this.Graph.ScrollMinY = 0D;
            this.Graph.ScrollMinY2 = 0D;
            this.Graph.Size = new System.Drawing.Size(540, 397);
            this.Graph.TabIndex = 5;
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
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(273, 100);
            this.ConfigurationGroupBox.TabIndex = 9;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Controller Configuration";
            // 
            // OutputsGroupBox
            // 
            this.OutputsGroupBox.Controls.Add(this.PositionControlGroupBox);
            this.OutputsGroupBox.Controls.Add(this.SpeedControlGroupBox);
            this.OutputsGroupBox.Controls.Add(this.RawControlGroupBox);
            this.OutputsGroupBox.Location = new System.Drawing.Point(12, 118);
            this.OutputsGroupBox.Name = "OutputsGroupBox";
            this.OutputsGroupBox.Size = new System.Drawing.Size(273, 480);
            this.OutputsGroupBox.TabIndex = 10;
            this.OutputsGroupBox.TabStop = false;
            this.OutputsGroupBox.Text = "Outputs";
            // 
            // SpeedControlGroupBox
            // 
            this.SpeedControlGroupBox.Controls.Add(this.SpeedControlProgressBar);
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlRadioButton);
            this.SpeedControlGroupBox.Controls.Add(this.VoltageControlUpDown);
            this.SpeedControlGroupBox.Controls.Add(this.SpeedControlRadioButton);
            this.SpeedControlGroupBox.Controls.Add(this.DeadBandCompensationCheckBox);
            this.SpeedControlGroupBox.Controls.Add(this.SpeedControlUpDown);
            this.SpeedControlGroupBox.Enabled = false;
            this.SpeedControlGroupBox.Location = new System.Drawing.Point(9, 100);
            this.SpeedControlGroupBox.Name = "SpeedControlGroupBox";
            this.SpeedControlGroupBox.Size = new System.Drawing.Size(258, 110);
            this.SpeedControlGroupBox.TabIndex = 11;
            this.SpeedControlGroupBox.TabStop = false;
            this.SpeedControlGroupBox.Text = "Speed/Voltage Control";
            // 
            // SpeedControlProgressBar
            // 
            this.SpeedControlProgressBar.Location = new System.Drawing.Point(6, 94);
            this.SpeedControlProgressBar.Name = "SpeedControlProgressBar";
            this.SpeedControlProgressBar.Size = new System.Drawing.Size(246, 10);
            this.SpeedControlProgressBar.TabIndex = 11;
            // 
            // VoltageControlRadioButton
            // 
            this.VoltageControlRadioButton.AutoSize = true;
            this.VoltageControlRadioButton.Location = new System.Drawing.Point(6, 68);
            this.VoltageControlRadioButton.Name = "VoltageControlRadioButton";
            this.VoltageControlRadioButton.Size = new System.Drawing.Size(77, 17);
            this.VoltageControlRadioButton.TabIndex = 12;
            this.VoltageControlRadioButton.Text = "Voltage (V)";
            this.VoltageControlRadioButton.UseVisualStyleBackColor = true;
            // 
            // VoltageControlUpDown
            // 
            this.VoltageControlUpDown.Enabled = false;
            this.VoltageControlUpDown.Location = new System.Drawing.Point(101, 68);
            this.VoltageControlUpDown.Name = "VoltageControlUpDown";
            this.VoltageControlUpDown.Size = new System.Drawing.Size(151, 20);
            this.VoltageControlUpDown.TabIndex = 12;
            // 
            // SpeedControlRadioButton
            // 
            this.SpeedControlRadioButton.AutoSize = true;
            this.SpeedControlRadioButton.Checked = true;
            this.SpeedControlRadioButton.Location = new System.Drawing.Point(6, 42);
            this.SpeedControlRadioButton.Name = "SpeedControlRadioButton";
            this.SpeedControlRadioButton.Size = new System.Drawing.Size(89, 17);
            this.SpeedControlRadioButton.TabIndex = 11;
            this.SpeedControlRadioButton.TabStop = true;
            this.SpeedControlRadioButton.Text = "Speed (RPM)";
            this.SpeedControlRadioButton.UseVisualStyleBackColor = true;
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
            // SpeedControlUpDown
            // 
            this.SpeedControlUpDown.Location = new System.Drawing.Point(101, 42);
            this.SpeedControlUpDown.Name = "SpeedControlUpDown";
            this.SpeedControlUpDown.Size = new System.Drawing.Size(151, 20);
            this.SpeedControlUpDown.TabIndex = 11;
            // 
            // RawControlGroupBox
            // 
            this.RawControlGroupBox.Controls.Add(this.RawControlCurrentValueLabel);
            this.RawControlGroupBox.Controls.Add(this.RawControlCurrentTextBox);
            this.RawControlGroupBox.Controls.Add(this.RawControlDecimalLabel);
            this.RawControlGroupBox.Controls.Add(this.RawControlProgressBar);
            this.RawControlGroupBox.Controls.Add(this.RawControlUpDown);
            this.RawControlGroupBox.Enabled = false;
            this.RawControlGroupBox.Location = new System.Drawing.Point(9, 19);
            this.RawControlGroupBox.Name = "RawControlGroupBox";
            this.RawControlGroupBox.Size = new System.Drawing.Size(258, 75);
            this.RawControlGroupBox.TabIndex = 11;
            this.RawControlGroupBox.TabStop = false;
            this.RawControlGroupBox.Text = "Raw DAC Control";
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
            this.RawControlDecimalLabel.Location = new System.Drawing.Point(30, 16);
            this.RawControlDecimalLabel.Name = "RawControlDecimalLabel";
            this.RawControlDecimalLabel.Size = new System.Drawing.Size(73, 13);
            this.RawControlDecimalLabel.TabIndex = 11;
            this.RawControlDecimalLabel.Text = "Desired Value";
            // 
            // RawControlProgressBar
            // 
            this.RawControlProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.RawControlProgressBar.Location = new System.Drawing.Point(6, 58);
            this.RawControlProgressBar.Maximum = 255;
            this.RawControlProgressBar.Name = "RawControlProgressBar";
            this.RawControlProgressBar.Size = new System.Drawing.Size(246, 10);
            this.RawControlProgressBar.Step = 255;
            this.RawControlProgressBar.TabIndex = 11;
            // 
            // RawControlUpDown
            // 
            this.RawControlUpDown.Location = new System.Drawing.Point(6, 32);
            this.RawControlUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RawControlUpDown.Name = "RawControlUpDown";
            this.RawControlUpDown.Size = new System.Drawing.Size(120, 20);
            this.RawControlUpDown.TabIndex = 11;
            this.RawControlUpDown.ValueChanged += new System.EventHandler(this.OnRawControlValueChanged);
            // 
            // PositionControlGroupBox
            // 
            this.PositionControlGroupBox.Controls.Add(this.PIDControlGroupBox);
            this.PositionControlGroupBox.Enabled = false;
            this.PositionControlGroupBox.Location = new System.Drawing.Point(9, 216);
            this.PositionControlGroupBox.Name = "PositionControlGroupBox";
            this.PositionControlGroupBox.Size = new System.Drawing.Size(258, 258);
            this.PositionControlGroupBox.TabIndex = 11;
            this.PositionControlGroupBox.TabStop = false;
            this.PositionControlGroupBox.Text = "Position Control";
            // 
            // PIDControlGroupBox
            // 
            this.PIDControlGroupBox.Location = new System.Drawing.Point(6, 152);
            this.PIDControlGroupBox.Name = "PIDControlGroupBox";
            this.PIDControlGroupBox.Size = new System.Drawing.Size(246, 100);
            this.PIDControlGroupBox.TabIndex = 11;
            this.PIDControlGroupBox.TabStop = false;
            this.PIDControlGroupBox.Text = "PID Controller Setup";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(854, 623);
            this.Controls.Add(this.OutputsGroupBox);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.StatusStrip);
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servo Motor Driver";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.OutputsGroupBox.ResumeLayout(false);
            this.SpeedControlGroupBox.ResumeLayout(false);
            this.SpeedControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageControlUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedControlUpDown)).EndInit();
            this.RawControlGroupBox.ResumeLayout(false);
            this.RawControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RawControlUpDown)).EndInit();
            this.PositionControlGroupBox.ResumeLayout(false);
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
        private ZedGraph.ZedGraphControl Graph;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.Label ModeSelectionLabel;
        private System.Windows.Forms.Label DirectionSelectionLabel;
        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.GroupBox OutputsGroupBox;
        private System.Windows.Forms.GroupBox RawControlGroupBox;
        private System.Windows.Forms.NumericUpDown RawControlUpDown;
        private System.Windows.Forms.ProgressBar RawControlProgressBar;
        private System.Windows.Forms.Label RawControlDecimalLabel;
        private System.Windows.Forms.TextBox RawControlCurrentTextBox;
        private System.Windows.Forms.Label RawControlCurrentValueLabel;
        private System.Windows.Forms.GroupBox SpeedControlGroupBox;
        private System.Windows.Forms.NumericUpDown VoltageControlUpDown;
        private System.Windows.Forms.CheckBox DeadBandCompensationCheckBox;
        private System.Windows.Forms.NumericUpDown SpeedControlUpDown;
        private System.Windows.Forms.ProgressBar SpeedControlProgressBar;
        private System.Windows.Forms.RadioButton VoltageControlRadioButton;
        private System.Windows.Forms.RadioButton SpeedControlRadioButton;
        private System.Windows.Forms.GroupBox PositionControlGroupBox;
        private System.Windows.Forms.GroupBox PIDControlGroupBox;
    }
}

