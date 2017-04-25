namespace ServoMotorDriver {
    partial class DeadBandSettingsForm {
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
            this.DeadBandSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BinaryTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.TestingStopButton = new System.Windows.Forms.Button();
            this.TestingStartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MassUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ManualResetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TestingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeadBandSettingsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeadBandSettingsGroupBox
            // 
            this.DeadBandSettingsGroupBox.Controls.Add(this.SaveButton);
            this.DeadBandSettingsGroupBox.Controls.Add(this.LoadButton);
            this.DeadBandSettingsGroupBox.Controls.Add(this.groupBox2);
            this.DeadBandSettingsGroupBox.Controls.Add(this.label6);
            this.DeadBandSettingsGroupBox.Controls.Add(this.label3);
            this.DeadBandSettingsGroupBox.Controls.Add(this.MassUpDown);
            this.DeadBandSettingsGroupBox.Controls.Add(this.groupBox1);
            this.DeadBandSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DeadBandSettingsGroupBox.Name = "DeadBandSettingsGroupBox";
            this.DeadBandSettingsGroupBox.Size = new System.Drawing.Size(516, 155);
            this.DeadBandSettingsGroupBox.TabIndex = 0;
            this.DeadBandSettingsGroupBox.TabStop = false;
            this.DeadBandSettingsGroupBox.Text = "Dead Band Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BinaryTextBox);
            this.groupBox2.Controls.Add(this.PositionTextBox);
            this.groupBox2.Controls.Add(this.TestingStopButton);
            this.groupBox2.Controls.Add(this.TestingStartButton);
            this.groupBox2.Location = new System.Drawing.Point(262, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 102);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automatic Deadband Testing";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(117, 45);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(61, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(193, 45);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(61, 23);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.OnLoadButtonClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "For current mass:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Current Motor Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Binary Output";
            // 
            // BinaryTextBox
            // 
            this.BinaryTextBox.Location = new System.Drawing.Point(138, 48);
            this.BinaryTextBox.Name = "BinaryTextBox";
            this.BinaryTextBox.ReadOnly = true;
            this.BinaryTextBox.Size = new System.Drawing.Size(104, 20);
            this.BinaryTextBox.TabIndex = 3;
            this.BinaryTextBox.Text = "Press start to begin";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(138, 74);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.ReadOnly = true;
            this.PositionTextBox.Size = new System.Drawing.Size(104, 20);
            this.PositionTextBox.TabIndex = 2;
            this.PositionTextBox.Text = "Press start to begin";
            // 
            // TestingStopButton
            // 
            this.TestingStopButton.Enabled = false;
            this.TestingStopButton.Location = new System.Drawing.Point(129, 19);
            this.TestingStopButton.Name = "TestingStopButton";
            this.TestingStopButton.Size = new System.Drawing.Size(113, 23);
            this.TestingStopButton.TabIndex = 1;
            this.TestingStopButton.Text = "Stop";
            this.TestingStopButton.UseVisualStyleBackColor = true;
            this.TestingStopButton.Click += new System.EventHandler(this.OnStopButtonClick);
            // 
            // TestingStartButton
            // 
            this.TestingStartButton.Location = new System.Drawing.Point(6, 19);
            this.TestingStartButton.Name = "TestingStartButton";
            this.TestingStartButton.Size = new System.Drawing.Size(112, 23);
            this.TestingStartButton.TabIndex = 0;
            this.TestingStartButton.Text = "Start";
            this.TestingStartButton.UseVisualStyleBackColor = true;
            this.TestingStartButton.Click += new System.EventHandler(this.OnStartButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motor Load Mass (g)";
            // 
            // MassUpDown
            // 
            this.MassUpDown.Location = new System.Drawing.Point(117, 19);
            this.MassUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MassUpDown.Name = "MassUpDown";
            this.MassUpDown.Size = new System.Drawing.Size(137, 20);
            this.MassUpDown.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ManualResetButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MinUpDown);
            this.groupBox1.Controls.Add(this.MaxUpDown);
            this.groupBox1.Location = new System.Drawing.Point(6, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual Deadband Settings";
            // 
            // ManualResetButton
            // 
            this.ManualResetButton.Location = new System.Drawing.Point(6, 45);
            this.ManualResetButton.Name = "ManualResetButton";
            this.ManualResetButton.Size = new System.Drawing.Size(236, 23);
            this.ManualResetButton.TabIndex = 4;
            this.ManualResetButton.Text = "Reset To Default";
            this.ManualResetButton.UseVisualStyleBackColor = true;
            this.ManualResetButton.Click += new System.EventHandler(this.OnResetButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dead Band (Binary)";
            // 
            // MinUpDown
            // 
            this.MinUpDown.Location = new System.Drawing.Point(111, 19);
            this.MinUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MinUpDown.Name = "MinUpDown";
            this.MinUpDown.Size = new System.Drawing.Size(50, 20);
            this.MinUpDown.TabIndex = 1;
            this.MinUpDown.Value = new decimal(new int[] {
            113,
            0,
            0,
            0});
            this.MinUpDown.ValueChanged += new System.EventHandler(this.OnMinValueChanged);
            // 
            // MaxUpDown
            // 
            this.MaxUpDown.Location = new System.Drawing.Point(191, 19);
            this.MaxUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MaxUpDown.Name = "MaxUpDown";
            this.MaxUpDown.Size = new System.Drawing.Size(50, 20);
            this.MaxUpDown.TabIndex = 0;
            this.MaxUpDown.Value = new decimal(new int[] {
            146,
            0,
            0,
            0});
            this.MaxUpDown.ValueChanged += new System.EventHandler(this.OnMaxValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestingProgressBar,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 172);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(536, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TestingProgressBar
            // 
            this.TestingProgressBar.Name = "TestingProgressBar";
            this.TestingProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "Loading...";
            // 
            // DeadBandSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 194);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DeadBandSettingsGroupBox);
            this.MaximumSize = new System.Drawing.Size(552, 233);
            this.MinimumSize = new System.Drawing.Size(552, 233);
            this.Name = "DeadBandSettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dead Band Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnDeadbandFormClosed);
            this.DeadBandSettingsGroupBox.ResumeLayout(false);
            this.DeadBandSettingsGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DeadBandSettingsGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MinUpDown;
        private System.Windows.Forms.NumericUpDown MaxUpDown;
        private System.Windows.Forms.Button ManualResetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MassUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TestingStartButton;
        private System.Windows.Forms.Button TestingStopButton;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox BinaryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar TestingProgressBar;
    }
}