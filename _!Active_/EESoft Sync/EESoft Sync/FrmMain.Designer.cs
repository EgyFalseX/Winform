namespace EESoft_Sync
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Label3 = new System.Windows.Forms.Label();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label2 = new System.Windows.Forms.Label();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NetS_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.TimerZ = new System.Windows.Forms.Timer(this.components);
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblBackground = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.NetS_CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(56, 114);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(148, 15);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "EESoft Synchronizer Settings";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StartToolStripMenuItem.Text = "&Start Sync New Data";
            // 
            // ShowMainWindowToolStripMenuItem
            // 
            this.ShowMainWindowToolStripMenuItem.Name = "ShowMainWindowToolStripMenuItem";
            this.ShowMainWindowToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ShowMainWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowMainWindowToolStripMenuItem.Text = "Show Main Window";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(56, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 15);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Start Sync All Data";
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StopToolStripMenuItem.Text = "Start Sync &All Data";
            // 
            // NetS_CMS
            // 
            this.NetS_CMS.BackColor = System.Drawing.Color.White;
            this.NetS_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMainWindowToolStripMenuItem,
            this.StartToolStripMenuItem,
            this.StopToolStripMenuItem,
            this.OptionsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.NetS_CMS.Name = "NetS_CMS";
            this.NetS_CMS.Size = new System.Drawing.Size(181, 114);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OptionsToolStripMenuItem.Text = "&Options";
            // 
            // ServiceNotifyIcon
            // 
            this.ServiceNotifyIcon.ContextMenuStrip = this.NetS_CMS;
            this.ServiceNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ServiceNotifyIcon.Icon")));
            this.ServiceNotifyIcon.Text = "Data Center-Network Service";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(56, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 15);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Start Sync New Data";
            // 
            // TimerZ
            // 
            this.TimerZ.Interval = 5000;
            // 
            // BtnOptions
            // 
            this.BtnOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOptions.BackgroundImage")));
            this.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOptions.Location = new System.Drawing.Point(12, 101);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(38, 38);
            this.BtnOptions.TabIndex = 7;
            this.BtnOptions.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStop.BackgroundImage")));
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(12, 57);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(38, 38);
            this.BtnStop.TabIndex = 6;
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStart.BackgroundImage")));
            this.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStart.Location = new System.Drawing.Point(12, 13);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(38, 38);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblBackground
            // 
            this.LblBackground.Image = global::EESoft_Sync.Properties.Resources.Background;
            this.LblBackground.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblBackground.Location = new System.Drawing.Point(69, -1);
            this.LblBackground.Name = "LblBackground";
            this.LblBackground.Size = new System.Drawing.Size(246, 166);
            this.LblBackground.TabIndex = 11;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label4.Location = new System.Drawing.Point(6, 9);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(62, 135);
            this.Label4.TabIndex = 12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 161);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnOptions);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.LblBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "EESoft Synchronizer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.NetS_CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ShowMainWindowToolStripMenuItem;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip NetS_CMS;
        internal System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        internal System.Windows.Forms.NotifyIcon ServiceNotifyIcon;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Timer TimerZ;
        internal System.Windows.Forms.Button BtnOptions;
        internal System.Windows.Forms.Button BtnStop;
        internal System.Windows.Forms.Button BtnStart;
        internal System.Windows.Forms.Label LblBackground;
        internal System.Windows.Forms.Label Label4;
    }
}

