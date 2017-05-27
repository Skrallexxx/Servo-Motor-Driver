namespace ServoMotorDriver {
    partial class GraphingForm {
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
            this.GraphsGroupBox = new System.Windows.Forms.GroupBox();
            this.Chart = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XAxisSelectionBox = new System.Windows.Forms.ComboBox();
            this.YAxis1SelectionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XAxisUnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.YAxis1UnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GraphPeriodTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DataPointsUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Series2EnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.Series1EnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.YAxis2UnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.YAxis2SelectionBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GraphsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPointsUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphsGroupBox
            // 
            this.GraphsGroupBox.Controls.Add(this.Chart);
            this.GraphsGroupBox.Location = new System.Drawing.Point(12, 111);
            this.GraphsGroupBox.Name = "GraphsGroupBox";
            this.GraphsGroupBox.Size = new System.Drawing.Size(762, 447);
            this.GraphsGroupBox.TabIndex = 16;
            this.GraphsGroupBox.TabStop = false;
            this.GraphsGroupBox.Text = "Graphing";
            // 
            // Chart
            // 
            this.Chart.Location = new System.Drawing.Point(9, 19);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(750, 421);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X-Axis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y-Axis 1:";
            // 
            // XAxisSelectionBox
            // 
            this.XAxisSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XAxisSelectionBox.FormattingEnabled = true;
            this.XAxisSelectionBox.Location = new System.Drawing.Point(119, 26);
            this.XAxisSelectionBox.Name = "XAxisSelectionBox";
            this.XAxisSelectionBox.Size = new System.Drawing.Size(123, 21);
            this.XAxisSelectionBox.TabIndex = 3;
            this.XAxisSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnXAxisSelectionChanged);
            // 
            // YAxis1SelectionBox
            // 
            this.YAxis1SelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YAxis1SelectionBox.FormattingEnabled = true;
            this.YAxis1SelectionBox.Location = new System.Drawing.Point(69, 13);
            this.YAxis1SelectionBox.Name = "YAxis1SelectionBox";
            this.YAxis1SelectionBox.Size = new System.Drawing.Size(89, 21);
            this.YAxis1SelectionBox.TabIndex = 4;
            this.YAxis1SelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnYAxis1SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Unit:";
            // 
            // XAxisUnitSelectionBox
            // 
            this.XAxisUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XAxisUnitSelectionBox.FormattingEnabled = true;
            this.XAxisUnitSelectionBox.Location = new System.Drawing.Point(294, 26);
            this.XAxisUnitSelectionBox.Name = "XAxisUnitSelectionBox";
            this.XAxisUnitSelectionBox.Size = new System.Drawing.Size(82, 21);
            this.XAxisUnitSelectionBox.TabIndex = 18;
            this.XAxisUnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnXAxisUnitSelectionChanged);
            // 
            // YAxis1UnitSelectionBox
            // 
            this.YAxis1UnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YAxis1UnitSelectionBox.FormattingEnabled = true;
            this.YAxis1UnitSelectionBox.Location = new System.Drawing.Point(199, 13);
            this.YAxis1UnitSelectionBox.Name = "YAxis1UnitSelectionBox";
            this.YAxis1UnitSelectionBox.Size = new System.Drawing.Size(64, 21);
            this.YAxis1UnitSelectionBox.TabIndex = 19;
            this.YAxis1UnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnYAxis1UnitSelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.GraphPeriodTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DataPointsUpDown);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.XAxisUnitSelectionBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.XAxisSelectionBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 93);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axes Setup";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Period:";
            // 
            // GraphPeriodTextBox
            // 
            this.GraphPeriodTextBox.Location = new System.Drawing.Point(294, 53);
            this.GraphPeriodTextBox.Name = "GraphPeriodTextBox";
            this.GraphPeriodTextBox.ReadOnly = true;
            this.GraphPeriodTextBox.Size = new System.Drawing.Size(82, 20);
            this.GraphPeriodTextBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Data Points to Show:";
            // 
            // DataPointsUpDown
            // 
            this.DataPointsUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DataPointsUpDown.Location = new System.Drawing.Point(119, 53);
            this.DataPointsUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DataPointsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DataPointsUpDown.Name = "DataPointsUpDown";
            this.DataPointsUpDown.Size = new System.Drawing.Size(123, 20);
            this.DataPointsUpDown.TabIndex = 21;
            this.DataPointsUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.DataPointsUpDown.ValueChanged += new System.EventHandler(this.OnDataPointsUpDownChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Series2EnabledCheckbox);
            this.groupBox2.Controls.Add(this.Series1EnabledCheckbox);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.YAxis2UnitSelectionBox);
            this.groupBox2.Controls.Add(this.YAxis2SelectionBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.YAxis1UnitSelectionBox);
            this.groupBox2.Controls.Add(this.YAxis1SelectionBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(382, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 70);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y-Axis Setup";
            // 
            // Series2EnabledCheckbox
            // 
            this.Series2EnabledCheckbox.AutoSize = true;
            this.Series2EnabledCheckbox.Checked = true;
            this.Series2EnabledCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Series2EnabledCheckbox.Location = new System.Drawing.Point(269, 41);
            this.Series2EnabledCheckbox.Name = "Series2EnabledCheckbox";
            this.Series2EnabledCheckbox.Size = new System.Drawing.Size(65, 17);
            this.Series2EnabledCheckbox.TabIndex = 27;
            this.Series2EnabledCheckbox.Text = "Enabled";
            this.Series2EnabledCheckbox.UseVisualStyleBackColor = true;
            this.Series2EnabledCheckbox.CheckedChanged += new System.EventHandler(this.OnSeries2CheckedChanged);
            // 
            // Series1EnabledCheckbox
            // 
            this.Series1EnabledCheckbox.AutoSize = true;
            this.Series1EnabledCheckbox.Checked = true;
            this.Series1EnabledCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Series1EnabledCheckbox.Location = new System.Drawing.Point(269, 15);
            this.Series1EnabledCheckbox.Name = "Series1EnabledCheckbox";
            this.Series1EnabledCheckbox.Size = new System.Drawing.Size(65, 17);
            this.Series1EnabledCheckbox.TabIndex = 26;
            this.Series1EnabledCheckbox.Text = "Enabled";
            this.Series1EnabledCheckbox.UseVisualStyleBackColor = true;
            this.Series1EnabledCheckbox.CheckedChanged += new System.EventHandler(this.OnSeries1CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(340, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 21);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Y-Axis 2:";
            // 
            // YAxis2UnitSelectionBox
            // 
            this.YAxis2UnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YAxis2UnitSelectionBox.FormattingEnabled = true;
            this.YAxis2UnitSelectionBox.Location = new System.Drawing.Point(199, 40);
            this.YAxis2UnitSelectionBox.Name = "YAxis2UnitSelectionBox";
            this.YAxis2UnitSelectionBox.Size = new System.Drawing.Size(64, 21);
            this.YAxis2UnitSelectionBox.TabIndex = 23;
            this.YAxis2UnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnYAxis2UnitSelectionChanged);
            // 
            // YAxis2SelectionBox
            // 
            this.YAxis2SelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YAxis2SelectionBox.FormattingEnabled = true;
            this.YAxis2SelectionBox.Location = new System.Drawing.Point(69, 40);
            this.YAxis2SelectionBox.Name = "YAxis2SelectionBox";
            this.YAxis2SelectionBox.Size = new System.Drawing.Size(89, 21);
            this.YAxis2SelectionBox.TabIndex = 21;
            this.YAxis2SelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnYAxis2SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Unit:";
            // 
            // GraphingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GraphsGroupBox);
            this.MinimumSize = new System.Drawing.Size(802, 419);
            this.Name = "GraphingForm";
            this.Text = "GraphingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.GraphsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPointsUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GraphsGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox YAxis1SelectionBox;
        private System.Windows.Forms.ComboBox XAxisSelectionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox XAxisUnitSelectionBox;
        private System.Windows.Forms.ComboBox YAxis1UnitSelectionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private LiveCharts.WinForms.CartesianChart Chart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox YAxis2UnitSelectionBox;
        private System.Windows.Forms.ComboBox YAxis2SelectionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DataPointsUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GraphPeriodTextBox;
        private System.Windows.Forms.CheckBox Series2EnabledCheckbox;
        private System.Windows.Forms.CheckBox Series1EnabledCheckbox;
    }
}