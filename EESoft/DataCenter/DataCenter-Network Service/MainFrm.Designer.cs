using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenterNetworkService
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class MainFrm : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
			this.components = new System.ComponentModel.Container();
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(MainFrm_FormClosed);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MainFrm_FormClosing);
			base.Load += new System.EventHandler(MainFrm_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.BtnStart = new System.Windows.Forms.Button();
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			this.BtnStop = new System.Windows.Forms.Button();
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			this.BtnOptions = new System.Windows.Forms.Button();
			this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
			this.Label3 = new System.Windows.Forms.Label();
			this.LblBackground = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.ServiceNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.NetS_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.NetS_CMS.Opening += new System.ComponentModel.CancelEventHandler(this.NetS_CMS_Opening);
			this.ShowMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowMainWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowMainWindowToolStripMenuItem_Click);
			this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
			this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
			this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			this.TimerZ = new System.Windows.Forms.Timer(this.components);
			this.TimerZ.Tick += new System.EventHandler(this.TimerZ_Tick);
			this.NetS_CMS.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.RoyalBlue;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(56, 20);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(112, 15);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Start network service";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.RoyalBlue;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(56, 64);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(110, 15);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Stop network service";
			//
			//BtnStart
			//
			this.BtnStart.BackgroundImage = global::My.Resources.Resources.bt_Start;
			this.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnStart.Location = new System.Drawing.Point(12, 7);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(38, 38);
			this.BtnStart.TabIndex = 0;
			this.BtnStart.UseVisualStyleBackColor = true;
			//
			//BtnStop
			//
			this.BtnStop.BackgroundImage = global::My.Resources.Resources.bt_Stop;
			this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnStop.Enabled = false;
			this.BtnStop.Location = new System.Drawing.Point(12, 51);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(38, 38);
			this.BtnStop.TabIndex = 1;
			this.BtnStop.UseVisualStyleBackColor = true;
			//
			//BtnOptions
			//
			this.BtnOptions.BackgroundImage = global::My.Resources.Resources.bt_Settings;
			this.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnOptions.Location = new System.Drawing.Point(12, 95);
			this.BtnOptions.Name = "BtnOptions";
			this.BtnOptions.Size = new System.Drawing.Size(38, 38);
			this.BtnOptions.TabIndex = 2;
			this.BtnOptions.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.RoyalBlue;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(56, 108);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(124, 15);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Network service options";
			//
			//LblBackground
			//
			this.LblBackground.Image = global::My.Resources.Resources.Background;
			this.LblBackground.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.LblBackground.Location = new System.Drawing.Point(87, 3);
			this.LblBackground.Name = "LblBackground";
			this.LblBackground.Size = new System.Drawing.Size(209, 148);
			this.LblBackground.TabIndex = 3;
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.Color.RoyalBlue;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Location = new System.Drawing.Point(6, 3);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(62, 135);
			this.Label4.TabIndex = 4;
			//
			//ServiceNotifyIcon
			//
			this.ServiceNotifyIcon.ContextMenuStrip = this.NetS_CMS;
			this.ServiceNotifyIcon.Icon = (System.Drawing.Icon) (resources.GetObject("ServiceNotifyIcon.Icon"));
			this.ServiceNotifyIcon.Text = "Data Center-Network Service";
			//
			//NetS_CMS
			//
			this.NetS_CMS.BackColor = System.Drawing.Color.White;
			this.NetS_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ShowMainWindowToolStripMenuItem, this.StartToolStripMenuItem, this.StopToolStripMenuItem, this.OptionsToolStripMenuItem, this.ExitToolStripMenuItem});
			this.NetS_CMS.Name = "NetS_CMS";
			this.NetS_CMS.Size = new System.Drawing.Size(167, 114);
			//
			//ShowMainWindowToolStripMenuItem
			//
			this.ShowMainWindowToolStripMenuItem.Image = global::My.Resources.Resources.Background;
			this.ShowMainWindowToolStripMenuItem.Name = "ShowMainWindowToolStripMenuItem";
			this.ShowMainWindowToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.ShowMainWindowToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.ShowMainWindowToolStripMenuItem.Text = "Show Main Window";
			//
			//StartToolStripMenuItem
			//
			this.StartToolStripMenuItem.Image = global::My.Resources.Resources.bt_Start;
			this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
			this.StartToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.StartToolStripMenuItem.Text = "&Start";
			//
			//StopToolStripMenuItem
			//
			this.StopToolStripMenuItem.Image = global::My.Resources.Resources.bt_Stop;
			this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
			this.StopToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.StopToolStripMenuItem.Text = "S&top";
			//
			//OptionsToolStripMenuItem
			//
			this.OptionsToolStripMenuItem.Image = global::My.Resources.Resources.bt_Settings;
			this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
			this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.OptionsToolStripMenuItem.Text = "&Options";
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.ExitToolStripMenuItem.Text = "E&xit";
			//
			//TimerZ
			//
			this.TimerZ.Interval = 1;
			//
			//MainFrm
			//
			this.AcceptButton = this.BtnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(269, 141);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.BtnOptions);
			this.Controls.Add(this.BtnStop);
			this.Controls.Add(this.BtnStart);
			this.Controls.Add(this.LblBackground);
			this.Controls.Add(this.Label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.Name = "MainFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataCenter Service Manager";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.NetS_CMS.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button BtnStart;
		internal System.Windows.Forms.Button BtnStop;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button BtnOptions;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label LblBackground;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.NotifyIcon ServiceNotifyIcon;
		internal System.Windows.Forms.ContextMenuStrip NetS_CMS;
		internal System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ShowMainWindowToolStripMenuItem;
		internal System.Windows.Forms.Timer TimerZ;
		
	}
	
}
