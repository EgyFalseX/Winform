namespace Netsync
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            this.notifyIconNetsync = new System.Windows.Forms.NotifyIcon();
            this.contextMenuStripNetsync = new System.Windows.Forms.ContextMenuStrip();
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.contextMenuStripNetsync.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(45, 51);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(53, 20);
            this.tbPort.TabIndex = 2;
            this.tbPort.Text = "0";
            this.tbPort.TextChanged += new System.EventHandler(this.tbPort_TextChanged);
            // 
            // cbAutoStart
            // 
            this.cbAutoStart.AutoSize = true;
            this.cbAutoStart.Location = new System.Drawing.Point(104, 54);
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.Size = new System.Drawing.Size(76, 17);
            this.cbAutoStart.TabIndex = 3;
            this.cbAutoStart.Text = "Auto Start";
            this.cbAutoStart.UseVisualStyleBackColor = true;
            this.cbAutoStart.CheckedChanged += new System.EventHandler(this.cbAutoStart_CheckedChanged);
            // 
            // notifyIconNetsync
            // 
            this.notifyIconNetsync.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconNetsync.BalloonTipText = "Network transfer data service manage";
            this.notifyIconNetsync.BalloonTipTitle = "Netsync";
            this.notifyIconNetsync.ContextMenuStrip = this.contextMenuStripNetsync;
            this.notifyIconNetsync.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconNetsync.Icon")));
            this.notifyIconNetsync.Text = "Netsync";
            this.notifyIconNetsync.Visible = true;
            this.notifyIconNetsync.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconNetsync_MouseDoubleClick);
            // 
            // contextMenuStripNetsync
            // 
            this.contextMenuStripNetsync.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitsToolStripMenuItem});
            this.contextMenuStripNetsync.Name = "contextMenuStrip1";
            this.contextMenuStripNetsync.Size = new System.Drawing.Size(134, 92);
            this.contextMenuStripNetsync.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStripNetsync_MouseDoubleClick);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Image = global::Netsync.Properties.Resources.Netsync;
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::Netsync.Properties.Resources.bt_Start;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::Netsync.Properties.Resources.bt_Stop;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.stopToolStripMenuItem.Text = "S&top";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // exitsToolStripMenuItem
            // 
            this.exitsToolStripMenuItem.Image = global::Netsync.Properties.Resources.Exit;
            this.exitsToolStripMenuItem.Name = "exitsToolStripMenuItem";
            this.exitsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitsToolStripMenuItem.Text = "E&xits";
            this.exitsToolStripMenuItem.Click += new System.EventHandler(this.exitsToolStripMenuItem_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Image = global::Netsync.Properties.Resources.bt_Stop;
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.Location = new System.Drawing.Point(104, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(86, 33);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::Netsync.Properties.Resources.bt_Start;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 80);
            this.Controls.Add(this.cbAutoStart);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netsync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.contextMenuStripNetsync.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.CheckBox cbAutoStart;
        private System.Windows.Forms.NotifyIcon notifyIconNetsync;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNetsync;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
    }
}

