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
            this.YAxisSelectionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XAxisUnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.YAxisUnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GraphsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphsGroupBox
            // 
            this.GraphsGroupBox.Controls.Add(this.Chart);
            this.GraphsGroupBox.Location = new System.Drawing.Point(12, 89);
            this.GraphsGroupBox.Name = "GraphsGroupBox";
            this.GraphsGroupBox.Size = new System.Drawing.Size(762, 284);
            this.GraphsGroupBox.TabIndex = 16;
            this.GraphsGroupBox.TabStop = false;
            this.GraphsGroupBox.Text = "Graphing";
            // 
            // Chart
            // 
            this.Chart.Location = new System.Drawing.Point(6, 19);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(750, 259);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X-Axis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y-Axis:";
            // 
            // XAxisSelectionBox
            // 
            this.XAxisSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XAxisSelectionBox.FormattingEnabled = true;
            this.XAxisSelectionBox.Location = new System.Drawing.Point(58, 13);
            this.XAxisSelectionBox.Name = "XAxisSelectionBox";
            this.XAxisSelectionBox.Size = new System.Drawing.Size(145, 21);
            this.XAxisSelectionBox.TabIndex = 3;
            this.XAxisSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnXAxisSelectionChanged);
            // 
            // YAxisSelectionBox
            // 
            this.YAxisSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YAxisSelectionBox.FormattingEnabled = true;
            this.YAxisSelectionBox.Location = new System.Drawing.Point(58, 40);
            this.YAxisSelectionBox.Name = "YAxisSelectionBox";
            this.YAxisSelectionBox.Size = new System.Drawing.Size(145, 21);
            this.YAxisSelectionBox.TabIndex = 4;
            this.YAxisSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnYAxisSelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Unit:";
            // 
            // XAxisUnitSelectionBox
            // 
            this.XAxisUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XAxisUnitSelectionBox.FormattingEnabled = true;
            this.XAxisUnitSelectionBox.Location = new System.Drawing.Point(244, 13);
            this.XAxisUnitSelectionBox.Name = "XAxisUnitSelectionBox";
            this.XAxisUnitSelectionBox.Size = new System.Drawing.Size(90, 21);
            this.XAxisUnitSelectionBox.TabIndex = 18;
            this.XAxisUnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnXAxisUnitSelectionChanged);
            // 
            // YAxisUnitSelectionBox
            // 
            this.YAxisUnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YAxisUnitSelectionBox.FormattingEnabled = true;
            this.YAxisUnitSelectionBox.Location = new System.Drawing.Point(244, 40);
            this.YAxisUnitSelectionBox.Name = "YAxisUnitSelectionBox";
            this.YAxisUnitSelectionBox.Size = new System.Drawing.Size(90, 21);
            this.YAxisUnitSelectionBox.TabIndex = 19;
            this.YAxisUnitSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnYAxisUnitSelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YAxisUnitSelectionBox);
            this.groupBox1.Controls.Add(this.XAxisUnitSelectionBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.XAxisSelectionBox);
            this.groupBox1.Controls.Add(this.YAxisSelectionBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axes Setup";
            // 
            // GraphingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GraphsGroupBox);
            this.MaximumSize = new System.Drawing.Size(802, 419);
            this.MinimumSize = new System.Drawing.Size(802, 419);
            this.Name = "GraphingForm";
            this.Text = "GraphingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.GraphsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GraphsGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox YAxisSelectionBox;
        private System.Windows.Forms.ComboBox XAxisSelectionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox XAxisUnitSelectionBox;
        private System.Windows.Forms.ComboBox YAxisUnitSelectionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private LiveCharts.WinForms.CartesianChart Chart;
    }
}