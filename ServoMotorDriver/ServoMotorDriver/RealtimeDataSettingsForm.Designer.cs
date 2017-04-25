namespace ServoMotorDriver {
    partial class RealtimeDataSettingsForm {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AccelerationResetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AccelerationUpdateTimeTextBox = new System.Windows.Forms.TextBox();
            this.AccelerationPeriodUpDown = new System.Windows.Forms.NumericUpDown();
            this.AccelerationSamplesUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VelocityResetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VelocityUpdateTimeTextBox = new System.Windows.Forms.TextBox();
            this.VelocityPeriodUpDown = new System.Windows.Forms.NumericUpDown();
            this.VelocitySamplesUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationPeriodUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationSamplesUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityPeriodUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocitySamplesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Real-time Data Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AccelerationResetButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.AccelerationUpdateTimeTextBox);
            this.groupBox3.Controls.Add(this.AccelerationPeriodUpDown);
            this.groupBox3.Controls.Add(this.AccelerationSamplesUpDown);
            this.groupBox3.Location = new System.Drawing.Point(264, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 128);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acceleration";
            // 
            // AccelerationResetButton
            // 
            this.AccelerationResetButton.Location = new System.Drawing.Point(6, 97);
            this.AccelerationResetButton.Name = "AccelerationResetButton";
            this.AccelerationResetButton.Size = new System.Drawing.Size(240, 23);
            this.AccelerationResetButton.TabIndex = 3;
            this.AccelerationResetButton.Text = "Reset to Default";
            this.AccelerationResetButton.UseVisualStyleBackColor = true;
            this.AccelerationResetButton.Click += new System.EventHandler(this.OnAcclerationResetButtonClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Equivalent Update Time (ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sample Period (ms)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Number of Samples";
            // 
            // AccelerationUpdateTimeTextBox
            // 
            this.AccelerationUpdateTimeTextBox.Location = new System.Drawing.Point(155, 71);
            this.AccelerationUpdateTimeTextBox.Name = "AccelerationUpdateTimeTextBox";
            this.AccelerationUpdateTimeTextBox.ReadOnly = true;
            this.AccelerationUpdateTimeTextBox.Size = new System.Drawing.Size(91, 20);
            this.AccelerationUpdateTimeTextBox.TabIndex = 1;
            // 
            // AccelerationPeriodUpDown
            // 
            this.AccelerationPeriodUpDown.Location = new System.Drawing.Point(111, 45);
            this.AccelerationPeriodUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AccelerationPeriodUpDown.Name = "AccelerationPeriodUpDown";
            this.AccelerationPeriodUpDown.Size = new System.Drawing.Size(135, 20);
            this.AccelerationPeriodUpDown.TabIndex = 1;
            this.AccelerationPeriodUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AccelerationPeriodUpDown.ValueChanged += new System.EventHandler(this.OnAccelerationPeriodChanged);
            // 
            // AccelerationSamplesUpDown
            // 
            this.AccelerationSamplesUpDown.Location = new System.Drawing.Point(111, 19);
            this.AccelerationSamplesUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AccelerationSamplesUpDown.Name = "AccelerationSamplesUpDown";
            this.AccelerationSamplesUpDown.Size = new System.Drawing.Size(135, 20);
            this.AccelerationSamplesUpDown.TabIndex = 0;
            this.AccelerationSamplesUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.AccelerationSamplesUpDown.ValueChanged += new System.EventHandler(this.OnAccelerationSamplesChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VelocityResetButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.VelocityUpdateTimeTextBox);
            this.groupBox2.Controls.Add(this.VelocityPeriodUpDown);
            this.groupBox2.Controls.Add(this.VelocitySamplesUpDown);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velocity";
            // 
            // VelocityResetButton
            // 
            this.VelocityResetButton.Location = new System.Drawing.Point(6, 97);
            this.VelocityResetButton.Name = "VelocityResetButton";
            this.VelocityResetButton.Size = new System.Drawing.Size(240, 23);
            this.VelocityResetButton.TabIndex = 2;
            this.VelocityResetButton.Text = "Reset to Default";
            this.VelocityResetButton.UseVisualStyleBackColor = true;
            this.VelocityResetButton.Click += new System.EventHandler(this.OnVelocityResetButtonClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Equivalent Update Time (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sample Period (ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Samples";
            // 
            // VelocityUpdateTimeTextBox
            // 
            this.VelocityUpdateTimeTextBox.Location = new System.Drawing.Point(155, 71);
            this.VelocityUpdateTimeTextBox.Name = "VelocityUpdateTimeTextBox";
            this.VelocityUpdateTimeTextBox.ReadOnly = true;
            this.VelocityUpdateTimeTextBox.Size = new System.Drawing.Size(91, 20);
            this.VelocityUpdateTimeTextBox.TabIndex = 1;
            // 
            // VelocityPeriodUpDown
            // 
            this.VelocityPeriodUpDown.Location = new System.Drawing.Point(111, 45);
            this.VelocityPeriodUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.VelocityPeriodUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VelocityPeriodUpDown.Name = "VelocityPeriodUpDown";
            this.VelocityPeriodUpDown.Size = new System.Drawing.Size(135, 20);
            this.VelocityPeriodUpDown.TabIndex = 1;
            this.VelocityPeriodUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VelocityPeriodUpDown.ValueChanged += new System.EventHandler(this.OnVelocityPeriodChanged);
            // 
            // VelocitySamplesUpDown
            // 
            this.VelocitySamplesUpDown.Location = new System.Drawing.Point(111, 19);
            this.VelocitySamplesUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.VelocitySamplesUpDown.Name = "VelocitySamplesUpDown";
            this.VelocitySamplesUpDown.Size = new System.Drawing.Size(135, 20);
            this.VelocitySamplesUpDown.TabIndex = 0;
            this.VelocitySamplesUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.VelocitySamplesUpDown.ValueChanged += new System.EventHandler(this.OnVelocitySamplesChanged);
            // 
            // RealtimeDataSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 173);
            this.Controls.Add(this.groupBox1);
            this.Name = "RealtimeDataSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealtimeDataSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationPeriodUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationSamplesUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityPeriodUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocitySamplesUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AccelerationResetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AccelerationUpdateTimeTextBox;
        private System.Windows.Forms.NumericUpDown AccelerationPeriodUpDown;
        private System.Windows.Forms.NumericUpDown AccelerationSamplesUpDown;
        private System.Windows.Forms.Button VelocityResetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VelocityUpdateTimeTextBox;
        private System.Windows.Forms.NumericUpDown VelocityPeriodUpDown;
        private System.Windows.Forms.NumericUpDown VelocitySamplesUpDown;
    }
}