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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeSelectionBox = new System.Windows.Forms.ComboBox();
            this.DirectionSelectionBox = new System.Windows.Forms.ComboBox();
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendReceiveTimer
            // 
            this.SendReceiveTimer.Enabled = true;
            this.SendReceiveTimer.Interval = 10;
            this.SendReceiveTimer.Tick += new System.EventHandler(this.SendReceiveUpdate);
            // 
            // ComPortSelectionBox
            // 
            this.ComPortSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortSelectionBox.FormattingEnabled = true;
            this.ComPortSelectionBox.Location = new System.Drawing.Point(12, 27);
            this.ComPortSelectionBox.Name = "ComPortSelectionBox";
            this.ComPortSelectionBox.Size = new System.Drawing.Size(252, 21);
            this.ComPortSelectionBox.TabIndex = 0;
            this.ComPortSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnComPortSelectionChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLogStatusStrip});
            this.StatusStrip.Location = new System.Drawing.Point(0, 304);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(610, 22);
            this.StatusStrip.TabIndex = 1;
            // 
            // MessageLogStatusStrip
            // 
            this.MessageLogStatusStrip.Name = "MessageLogStatusStrip";
            this.MessageLogStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(610, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ModeSelectionBox
            // 
            this.ModeSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelectionBox.FormattingEnabled = true;
            this.ModeSelectionBox.Location = new System.Drawing.Point(12, 66);
            this.ModeSelectionBox.Name = "ModeSelectionBox";
            this.ModeSelectionBox.Size = new System.Drawing.Size(252, 21);
            this.ModeSelectionBox.TabIndex = 3;
            this.ModeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnModeSelectionChanged);
            // 
            // DirectionSelectionBox
            // 
            this.DirectionSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DirectionSelectionBox.FormattingEnabled = true;
            this.DirectionSelectionBox.Location = new System.Drawing.Point(12, 108);
            this.DirectionSelectionBox.Name = "DirectionSelectionBox";
            this.DirectionSelectionBox.Size = new System.Drawing.Size(252, 21);
            this.DirectionSelectionBox.TabIndex = 4;
            this.DirectionSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnDirectionSelectionChanged);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(610, 326);
            this.Controls.Add(this.DirectionSelectionBox);
            this.Controls.Add(this.ModeSelectionBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ComPortSelectionBox);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servo Motor Driver";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialComPort;
        private System.Windows.Forms.Timer SendReceiveTimer;
        private System.Windows.Forms.ComboBox ComPortSelectionBox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel MessageLogStatusStrip;
        private System.Windows.Forms.ComboBox ModeSelectionBox;
        private System.Windows.Forms.ComboBox DirectionSelectionBox;
    }
}

