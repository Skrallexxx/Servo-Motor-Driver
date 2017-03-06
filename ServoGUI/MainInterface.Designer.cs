namespace ServoController
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.pnlPID = new System.Windows.Forms.Panel();
            this.btnPIDSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxKD = new System.Windows.Forms.TextBox();
            this.txtbxKI = new System.Windows.Forms.TextBox();
            this.txtbxKP = new System.Windows.Forms.TextBox();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.time_graph = new ZedGraph.ZedGraphControl();
            this.btn_select_yaxis_states = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlotGraphsTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pnlPID.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabGraph);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pnlPID);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(677, 646);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // pnlPID
            // 
            this.pnlPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPID.Controls.Add(this.btnPIDSet);
            this.pnlPID.Controls.Add(this.label4);
            this.pnlPID.Controls.Add(this.label3);
            this.pnlPID.Controls.Add(this.label2);
            this.pnlPID.Controls.Add(this.label1);
            this.pnlPID.Controls.Add(this.txtbxKD);
            this.pnlPID.Controls.Add(this.txtbxKI);
            this.pnlPID.Controls.Add(this.txtbxKP);
            this.pnlPID.Location = new System.Drawing.Point(445, 6);
            this.pnlPID.Name = "pnlPID";
            this.pnlPID.Size = new System.Drawing.Size(226, 232);
            this.pnlPID.TabIndex = 0;
            // 
            // btnPIDSet
            // 
            this.btnPIDSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPIDSet.Location = new System.Drawing.Point(89, 185);
            this.btnPIDSet.Name = "btnPIDSet";
            this.btnPIDSet.Size = new System.Drawing.Size(100, 34);
            this.btnPIDSet.TabIndex = 7;
            this.btnPIDSet.Text = "SET";
            this.btnPIDSet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Motor Controller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Derivative";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Integral";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proportional";
            // 
            // txtbxKD
            // 
            this.txtbxKD.Location = new System.Drawing.Point(89, 139);
            this.txtbxKD.Name = "txtbxKD";
            this.txtbxKD.Size = new System.Drawing.Size(100, 20);
            this.txtbxKD.TabIndex = 2;
            // 
            // txtbxKI
            // 
            this.txtbxKI.Location = new System.Drawing.Point(89, 89);
            this.txtbxKI.Name = "txtbxKI";
            this.txtbxKI.Size = new System.Drawing.Size(100, 20);
            this.txtbxKI.TabIndex = 1;
            // 
            // txtbxKP
            // 
            this.txtbxKP.Location = new System.Drawing.Point(89, 37);
            this.txtbxKP.Name = "txtbxKP";
            this.txtbxKP.Size = new System.Drawing.Size(100, 20);
            this.txtbxKP.TabIndex = 0;
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.time_graph);
            this.tabGraph.Controls.Add(this.btn_select_yaxis_states);
            this.tabGraph.Location = new System.Drawing.Point(4, 22);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(677, 646);
            this.tabGraph.TabIndex = 1;
            this.tabGraph.Text = "Graph";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // time_graph
            // 
            this.time_graph.BackColor = System.Drawing.Color.Red;
            this.time_graph.Cursor = System.Windows.Forms.Cursors.Default;
            this.time_graph.Location = new System.Drawing.Point(0, 0);
            this.time_graph.Margin = new System.Windows.Forms.Padding(2221, 1432, 2221, 1432);
            this.time_graph.Name = "time_graph";
            this.time_graph.ScrollGrace = 0D;
            this.time_graph.ScrollMaxX = 0D;
            this.time_graph.ScrollMaxY = 0D;
            this.time_graph.ScrollMaxY2 = 0D;
            this.time_graph.ScrollMinX = 0D;
            this.time_graph.ScrollMinY = 0D;
            this.time_graph.ScrollMinY2 = 0D;
            this.time_graph.Size = new System.Drawing.Size(677, 584);
            this.time_graph.TabIndex = 150;
            // 
            // btn_select_yaxis_states
            // 
            this.btn_select_yaxis_states.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_select_yaxis_states.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_select_yaxis_states.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_yaxis_states.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_select_yaxis_states.ImageKey = "(none)";
            this.btn_select_yaxis_states.Location = new System.Drawing.Point(7, 596);
            this.btn_select_yaxis_states.Name = "btn_select_yaxis_states";
            this.btn_select_yaxis_states.Size = new System.Drawing.Size(108, 31);
            this.btn_select_yaxis_states.TabIndex = 149;
            this.btn_select_yaxis_states.Text = "Select Yaxis";
            this.btn_select_yaxis_states.UseVisualStyleBackColor = false;
            this.btn_select_yaxis_states.Click += new System.EventHandler(this.btn_select_yaxis_states_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip2";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PlotGraphsTimer
            // 
            this.PlotGraphsTimer.Enabled = true;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 675);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainInterface";
            this.Text = "Motor Controller";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.pnlPID.ResumeLayout(false);
            this.pnlPID.PerformLayout();
            this.tabGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Panel pnlPID;
        private System.Windows.Forms.Button btnPIDSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxKD;
        private System.Windows.Forms.TextBox txtbxKI;
        private System.Windows.Forms.TextBox txtbxKP;
        private System.Windows.Forms.TabPage tabGraph;
        internal ZedGraph.ZedGraphControl time_graph;
        internal System.Windows.Forms.Button btn_select_yaxis_states;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.Timer PlotGraphsTimer;
    }
}

