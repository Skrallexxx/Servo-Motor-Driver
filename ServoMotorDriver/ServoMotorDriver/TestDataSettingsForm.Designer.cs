namespace ServoMotorDriver {
    partial class TestDataSettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TestDataConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.TestDataRandomGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxRandomIncrementUpDown = new System.Windows.Forms.NumericUpDown();
            this.RandomMinLabel = new System.Windows.Forms.Label();
            this.MinRandomIncrementUpDown = new System.Windows.Forms.NumericUpDown();
            this.IncrementUpDownLabel = new System.Windows.Forms.Label();
            this.IncrementUpDown = new System.Windows.Forms.NumericUpDown();
            this.IncrementLabel = new System.Windows.Forms.Label();
            this.IntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.RPMTextBox = new System.Windows.Forms.TextBox();
            this.RPMLabel = new System.Windows.Forms.Label();
            this.ResetDefaultButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TestDataConfigurationGroupBox.SuspendLayout();
            this.TestDataRandomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRandomIncrementUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRandomIncrementUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncrementUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TestDataConfigurationGroupBox
            // 
            this.TestDataConfigurationGroupBox.Controls.Add(this.RPMLabel);
            this.TestDataConfigurationGroupBox.Controls.Add(this.RPMTextBox);
            this.TestDataConfigurationGroupBox.Controls.Add(this.TestDataRandomGroupBox);
            this.TestDataConfigurationGroupBox.Controls.Add(this.IncrementUpDownLabel);
            this.TestDataConfigurationGroupBox.Controls.Add(this.IncrementUpDown);
            this.TestDataConfigurationGroupBox.Controls.Add(this.IncrementLabel);
            this.TestDataConfigurationGroupBox.Controls.Add(this.IntervalUpDown);
            this.TestDataConfigurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TestDataConfigurationGroupBox.Name = "TestDataConfigurationGroupBox";
            this.TestDataConfigurationGroupBox.Size = new System.Drawing.Size(260, 181);
            this.TestDataConfigurationGroupBox.TabIndex = 0;
            this.TestDataConfigurationGroupBox.TabStop = false;
            this.TestDataConfigurationGroupBox.Text = "Test Data Settings";
            // 
            // TestDataRandomGroupBox
            // 
            this.TestDataRandomGroupBox.Controls.Add(this.label1);
            this.TestDataRandomGroupBox.Controls.Add(this.MaxRandomIncrementUpDown);
            this.TestDataRandomGroupBox.Controls.Add(this.RandomMinLabel);
            this.TestDataRandomGroupBox.Controls.Add(this.MinRandomIncrementUpDown);
            this.TestDataRandomGroupBox.Location = new System.Drawing.Point(6, 104);
            this.TestDataRandomGroupBox.Name = "TestDataRandomGroupBox";
            this.TestDataRandomGroupBox.Size = new System.Drawing.Size(248, 71);
            this.TestDataRandomGroupBox.TabIndex = 1;
            this.TestDataRandomGroupBox.TabStop = false;
            this.TestDataRandomGroupBox.Text = "Randomness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Random Increment";
            this.toolTip1.SetToolTip(this.label1, "The maximum amount to increment by when using the random data mode");
            // 
            // MaxRandomIncrementUpDown
            // 
            this.MaxRandomIncrementUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxRandomIncrementUpDown.Location = new System.Drawing.Point(132, 45);
            this.MaxRandomIncrementUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.MaxRandomIncrementUpDown.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.MaxRandomIncrementUpDown.Name = "MaxRandomIncrementUpDown";
            this.MaxRandomIncrementUpDown.Size = new System.Drawing.Size(110, 20);
            this.MaxRandomIncrementUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.MaxRandomIncrementUpDown, "The maximum amount to increment by when using the random data mode");
            this.MaxRandomIncrementUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MaxRandomIncrementUpDown.ValueChanged += new System.EventHandler(this.OnMaxRandChanged);
            // 
            // RandomMinLabel
            // 
            this.RandomMinLabel.AutoSize = true;
            this.RandomMinLabel.Location = new System.Drawing.Point(6, 21);
            this.RandomMinLabel.Name = "RandomMinLabel";
            this.RandomMinLabel.Size = new System.Drawing.Size(117, 13);
            this.RandomMinLabel.TabIndex = 1;
            this.RandomMinLabel.Text = "Min Random Increment";
            this.toolTip1.SetToolTip(this.RandomMinLabel, "The minimum amount to increment by when using the random data mode");
            // 
            // MinRandomIncrementUpDown
            // 
            this.MinRandomIncrementUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinRandomIncrementUpDown.Location = new System.Drawing.Point(132, 19);
            this.MinRandomIncrementUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.MinRandomIncrementUpDown.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.MinRandomIncrementUpDown.Name = "MinRandomIncrementUpDown";
            this.MinRandomIncrementUpDown.Size = new System.Drawing.Size(110, 20);
            this.MinRandomIncrementUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.MinRandomIncrementUpDown, "The minimum amount to increment by when using the random data mode");
            this.MinRandomIncrementUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.MinRandomIncrementUpDown.ValueChanged += new System.EventHandler(this.OnMinRandChanged);
            // 
            // IncrementUpDownLabel
            // 
            this.IncrementUpDownLabel.AutoSize = true;
            this.IncrementUpDownLabel.Location = new System.Drawing.Point(6, 47);
            this.IncrementUpDownLabel.Name = "IncrementUpDownLabel";
            this.IncrementUpDownLabel.Size = new System.Drawing.Size(93, 13);
            this.IncrementUpDownLabel.TabIndex = 1;
            this.IncrementUpDownLabel.Text = "Increment Amount";
            this.toolTip1.SetToolTip(this.IncrementUpDownLabel, "The amount to increment the test data by");
            // 
            // IncrementUpDown
            // 
            this.IncrementUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IncrementUpDown.Location = new System.Drawing.Point(134, 45);
            this.IncrementUpDown.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.IncrementUpDown.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.IncrementUpDown.Name = "IncrementUpDown";
            this.IncrementUpDown.Size = new System.Drawing.Size(120, 20);
            this.IncrementUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.IncrementUpDown, "The amount to increment the test data by");
            this.IncrementUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.IncrementUpDown.ValueChanged += new System.EventHandler(this.OnIncrementChanged);
            // 
            // IncrementLabel
            // 
            this.IncrementLabel.AutoSize = true;
            this.IncrementLabel.Location = new System.Drawing.Point(6, 21);
            this.IncrementLabel.Name = "IncrementLabel";
            this.IncrementLabel.Size = new System.Drawing.Size(114, 13);
            this.IncrementLabel.TabIndex = 1;
            this.IncrementLabel.Text = "Increment Interval (ms)";
            this.toolTip1.SetToolTip(this.IncrementLabel, "The interval between incrementing the test data (in milliseconds)");
            // 
            // IntervalUpDown
            // 
            this.IntervalUpDown.Location = new System.Drawing.Point(134, 19);
            this.IntervalUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IntervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalUpDown.Name = "IntervalUpDown";
            this.IntervalUpDown.Size = new System.Drawing.Size(120, 20);
            this.IntervalUpDown.TabIndex = 0;
            this.toolTip1.SetToolTip(this.IntervalUpDown, "The interval between incrementing the test data (in milliseconds)");
            this.IntervalUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.IntervalUpDown.ValueChanged += new System.EventHandler(this.OnIncrementIntervalChanged);
            // 
            // RPMTextBox
            // 
            this.RPMTextBox.Location = new System.Drawing.Point(134, 71);
            this.RPMTextBox.Name = "RPMTextBox";
            this.RPMTextBox.ReadOnly = true;
            this.RPMTextBox.Size = new System.Drawing.Size(120, 20);
            this.RPMTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.RPMTextBox, "The equivalent motor RPM for the given interval and increment amount");
            // 
            // RPMLabel
            // 
            this.RPMLabel.AutoSize = true;
            this.RPMLabel.Location = new System.Drawing.Point(6, 74);
            this.RPMLabel.Name = "RPMLabel";
            this.RPMLabel.Size = new System.Drawing.Size(84, 13);
            this.RPMLabel.TabIndex = 3;
            this.RPMLabel.Text = "Equivalent RPM";
            this.toolTip1.SetToolTip(this.RPMLabel, "The equivalent motor RPM for the given interval and increment amount");
            // 
            // ResetDefaultButton
            // 
            this.ResetDefaultButton.Location = new System.Drawing.Point(12, 199);
            this.ResetDefaultButton.Name = "ResetDefaultButton";
            this.ResetDefaultButton.Size = new System.Drawing.Size(260, 23);
            this.ResetDefaultButton.TabIndex = 1;
            this.ResetDefaultButton.Text = "Reset to Default";
            this.toolTip1.SetToolTip(this.ResetDefaultButton, "Resets all the above values to their defaults");
            this.ResetDefaultButton.UseVisualStyleBackColor = true;
            this.ResetDefaultButton.Click += new System.EventHandler(this.OnResetDefaultButtonClicked);
            // 
            // TestDataSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.ResetDefaultButton);
            this.Controls.Add(this.TestDataConfigurationGroupBox);
            this.MinimumSize = new System.Drawing.Size(300, 203);
            this.Name = "TestDataSettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Data Settings";
            this.TestDataConfigurationGroupBox.ResumeLayout(false);
            this.TestDataConfigurationGroupBox.PerformLayout();
            this.TestDataRandomGroupBox.ResumeLayout(false);
            this.TestDataRandomGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRandomIncrementUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRandomIncrementUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncrementUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TestDataConfigurationGroupBox;
        private System.Windows.Forms.Label IncrementLabel;
        private System.Windows.Forms.NumericUpDown IntervalUpDown;
        private System.Windows.Forms.GroupBox TestDataRandomGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MaxRandomIncrementUpDown;
        private System.Windows.Forms.Label RandomMinLabel;
        private System.Windows.Forms.NumericUpDown MinRandomIncrementUpDown;
        private System.Windows.Forms.Label IncrementUpDownLabel;
        private System.Windows.Forms.NumericUpDown IncrementUpDown;
        private System.Windows.Forms.Label RPMLabel;
        private System.Windows.Forms.TextBox RPMTextBox;
        private System.Windows.Forms.Button ResetDefaultButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}