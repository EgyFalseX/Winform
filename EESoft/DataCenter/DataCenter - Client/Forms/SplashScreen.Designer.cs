using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace DataCenter_Client
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class SplashScreen : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		internal System.Windows.Forms.Label ApplicationTitle;
		internal System.Windows.Forms.Label Version;
		internal System.Windows.Forms.Label Copyright;
		internal System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
		internal System.Windows.Forms.TableLayoutPanel DetailsLayoutPanel;
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
                this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
                this.DetailsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
                this.Version = new System.Windows.Forms.Label();
                this.Copyright = new System.Windows.Forms.Label();
                this.ApplicationTitle = new System.Windows.Forms.Label();
                this.Lbl = new System.Windows.Forms.Label();
                this.ProgressBarLoading = new System.Windows.Forms.ProgressBar();
                this.LblPercent = new System.Windows.Forms.Label();
                this.MainLayoutPanel.SuspendLayout();
                this.DetailsLayoutPanel.SuspendLayout();
                this.SuspendLayout();
                // 
                // MainLayoutPanel
                // 
                this.MainLayoutPanel.BackgroundImage = global::My.Resources.Resources.EESoft_logo;
                this.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.MainLayoutPanel.ColumnCount = 3;
                this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
                this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
                this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 1);
                this.MainLayoutPanel.Controls.Add(this.ApplicationTitle, 1, 0);
                this.MainLayoutPanel.Controls.Add(this.Lbl, 0, 2);
                this.MainLayoutPanel.Controls.Add(this.ProgressBarLoading, 1, 2);
                this.MainLayoutPanel.Controls.Add(this.LblPercent, 2, 2);
                this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
                this.MainLayoutPanel.Name = "MainLayoutPanel";
                this.MainLayoutPanel.RowCount = 3;
                this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
                this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
                this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
                this.MainLayoutPanel.Size = new System.Drawing.Size(496, 314);
                this.MainLayoutPanel.TabIndex = 0;
                // 
                // DetailsLayoutPanel
                // 
                this.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
                this.DetailsLayoutPanel.ColumnCount = 1;
                this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
                this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
                this.DetailsLayoutPanel.Controls.Add(this.Version, 0, 0);
                this.DetailsLayoutPanel.Controls.Add(this.Copyright, 0, 1);
                this.DetailsLayoutPanel.Location = new System.Drawing.Point(223, 225);
                this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
                this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                this.DetailsLayoutPanel.Size = new System.Drawing.Size(234, 67);
                this.DetailsLayoutPanel.TabIndex = 1;
                // 
                // Version
                // 
                this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.Version.BackColor = System.Drawing.Color.Transparent;
                this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Version.Location = new System.Drawing.Point(3, 6);
                this.Version.Name = "Version";
                this.Version.Size = new System.Drawing.Size(241, 20);
                this.Version.TabIndex = 1;
                this.Version.Text = "Version {1}.{0:00}";
                // 
                // Copyright
                // 
                this.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.Copyright.BackColor = System.Drawing.Color.Transparent;
                this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Copyright.Location = new System.Drawing.Point(3, 33);
                this.Copyright.Name = "Copyright";
                this.Copyright.Size = new System.Drawing.Size(241, 34);
                this.Copyright.TabIndex = 2;
                this.Copyright.Text = "Copyright ";
                // 
                // ApplicationTitle
                // 
                this.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
                this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ApplicationTitle.Location = new System.Drawing.Point(223, 59);
                this.ApplicationTitle.Name = "ApplicationTitle";
                this.ApplicationTitle.Size = new System.Drawing.Size(234, 104);
                this.ApplicationTitle.TabIndex = 0;
                this.ApplicationTitle.Text = "DataCenter - Client";
                this.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                // 
                // Lbl
                // 
                this.Lbl.BackColor = System.Drawing.Color.Transparent;
                this.Lbl.Location = new System.Drawing.Point(3, 295);
                this.Lbl.Name = "Lbl";
                this.Lbl.Size = new System.Drawing.Size(59, 13);
                this.Lbl.TabIndex = 1;
                this.Lbl.Text = "Loading ...";
                // 
                // ProgressBarLoading
                // 
                this.ProgressBarLoading.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ProgressBarLoading.Location = new System.Drawing.Point(223, 298);
                this.ProgressBarLoading.MarqueeAnimationSpeed = 40;
                this.ProgressBarLoading.Name = "ProgressBarLoading";
                this.ProgressBarLoading.Size = new System.Drawing.Size(234, 13);
                this.ProgressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                this.ProgressBarLoading.TabIndex = 2;
                // 
                // LblPercent
                // 
                this.LblPercent.AutoSize = true;
                this.LblPercent.BackColor = System.Drawing.Color.Transparent;
                this.LblPercent.Location = new System.Drawing.Point(463, 295);
                this.LblPercent.Name = "LblPercent";
                this.LblPercent.Size = new System.Drawing.Size(24, 13);
                this.LblPercent.TabIndex = 3;
                this.LblPercent.Text = "0%";
                this.LblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // SplashScreen
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(496, 314);
                this.ControlBox = false;
                this.Controls.Add(this.MainLayoutPanel);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "SplashScreen";
                this.Opacity = 0D;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.TransparencyKey = System.Drawing.Color.White;
                this.Load += new System.EventHandler(this.SplashScreen_Load);
                this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SplashScreen_KeyPress);
                this.MainLayoutPanel.ResumeLayout(false);
                this.MainLayoutPanel.PerformLayout();
                this.DetailsLayoutPanel.ResumeLayout(false);
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label Lbl;
		internal System.Windows.Forms.ProgressBar ProgressBarLoading;
		internal System.Windows.Forms.Label LblPercent;
		
	}
	
}
