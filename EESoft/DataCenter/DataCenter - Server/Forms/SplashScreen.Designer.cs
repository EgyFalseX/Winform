using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
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
                this.PictureBox1 = new System.Windows.Forms.PictureBox();
                this.MainLayoutPanel.SuspendLayout();
                this.DetailsLayoutPanel.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                this.SuspendLayout();
                // 
                // MainLayoutPanel
                // 
                this.MainLayoutPanel.BackgroundImage = global::My.Resources.Resources.SplashScreen;
                this.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.MainLayoutPanel.ColumnCount = 2;
                this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
                this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
                this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 1);
                this.MainLayoutPanel.Controls.Add(this.ApplicationTitle, 1, 0);
                this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
                this.MainLayoutPanel.Name = "MainLayoutPanel";
                this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
                this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
                this.MainLayoutPanel.Size = new System.Drawing.Size(496, 314);
                this.MainLayoutPanel.TabIndex = 0;
                this.MainLayoutPanel.Click += new System.EventHandler(this.Tmr_Tick);
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
                this.DetailsLayoutPanel.Location = new System.Drawing.Point(246, 226);
                this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
                this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                this.DetailsLayoutPanel.Size = new System.Drawing.Size(247, 79);
                this.DetailsLayoutPanel.TabIndex = 1;
                // 
                // Version
                // 
                this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.Version.BackColor = System.Drawing.Color.Transparent;
                this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Version.Location = new System.Drawing.Point(3, 9);
                this.Version.Name = "Version";
                this.Version.Size = new System.Drawing.Size(241, 20);
                this.Version.TabIndex = 1;
                this.Version.Text = "Version {1}.{0:00}";
                this.Version.Click += new System.EventHandler(this.Tmr_Tick);
                // 
                // Copyright
                // 
                this.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.Copyright.BackColor = System.Drawing.Color.Transparent;
                this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Copyright.Location = new System.Drawing.Point(3, 39);
                this.Copyright.Name = "Copyright";
                this.Copyright.Size = new System.Drawing.Size(241, 40);
                this.Copyright.TabIndex = 2;
                this.Copyright.Text = "Copyright ";
                this.Copyright.Click += new System.EventHandler(this.Tmr_Tick);
                // 
                // ApplicationTitle
                // 
                this.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
                this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ApplicationTitle.Location = new System.Drawing.Point(246, 3);
                this.ApplicationTitle.Name = "ApplicationTitle";
                this.ApplicationTitle.Size = new System.Drawing.Size(247, 212);
                this.ApplicationTitle.TabIndex = 0;
                this.ApplicationTitle.Text = "DataCenter - Server";
                this.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                this.ApplicationTitle.Click += new System.EventHandler(this.Tmr_Tick);
                // 
                // PictureBox1
                // 
                this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.PictureBox1.Image = global::My.Resources.Resources.EESoft_logo;
                this.PictureBox1.Location = new System.Drawing.Point(34, 57);
                this.PictureBox1.Name = "PictureBox1";
                this.PictureBox1.Size = new System.Drawing.Size(168, 94);
                this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.PictureBox1.TabIndex = 1;
                this.PictureBox1.TabStop = false;
                // 
                // SplashScreen
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.SplashScreen;
                this.ClientSize = new System.Drawing.Size(496, 314);
                this.ControlBox = false;
                this.Controls.Add(this.PictureBox1);
                this.Controls.Add(this.MainLayoutPanel);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "SplashScreen";
                this.Opacity = 0D;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Load += new System.EventHandler(this.SplashScreen_Load);
                this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SplashScreen_KeyPress);
                this.MainLayoutPanel.ResumeLayout(false);
                this.DetailsLayoutPanel.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.PictureBox PictureBox1;
		
	}
	
}
