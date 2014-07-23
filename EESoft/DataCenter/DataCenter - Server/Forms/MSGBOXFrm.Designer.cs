using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class MSGBOXFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSGBOXFrm));
                this.Panel = new System.Windows.Forms.Panel();
                this.LBLMSG = new System.Windows.Forms.Label();
                this.BtnOk = new System.Windows.Forms.Button();
                this.Panel1 = new System.Windows.Forms.Panel();
                this.PictureBox1 = new System.Windows.Forms.PictureBox();
                this.Panel.SuspendLayout();
                this.Panel1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                this.SuspendLayout();
                // 
                // Panel
                // 
                this.Panel.BackColor = System.Drawing.Color.Transparent;
                this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.Panel.Controls.Add(this.LBLMSG);
                this.Panel.ForeColor = System.Drawing.Color.Lime;
                this.Panel.Location = new System.Drawing.Point(12, 92);
                this.Panel.Name = "Panel";
                this.Panel.Size = new System.Drawing.Size(376, 70);
                this.Panel.TabIndex = 1;
                this.Panel.TabStop = true;
                this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseDown);
                this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseMove);
                this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseUp);
                // 
                // LBLMSG
                // 
                this.LBLMSG.AutoSize = true;
                this.LBLMSG.BackColor = System.Drawing.Color.Black;
                this.LBLMSG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LBLMSG.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LBLMSG.ForeColor = System.Drawing.Color.Lime;
                this.LBLMSG.Location = new System.Drawing.Point(154, 23);
                this.LBLMSG.Name = "LBLMSG";
                this.LBLMSG.Size = new System.Drawing.Size(64, 20);
                this.LBLMSG.TabIndex = 2;
                this.LBLMSG.Text = "No Data";
                this.LBLMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // BtnOk
                // 
                this.BtnOk.BackColor = System.Drawing.Color.Blue;
                this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.BtnOk.ForeColor = System.Drawing.Color.Black;
                this.BtnOk.Location = new System.Drawing.Point(240, 205);
                this.BtnOk.Name = "BtnOk";
                this.BtnOk.Size = new System.Drawing.Size(148, 24);
                this.BtnOk.TabIndex = 0;
                this.BtnOk.Text = "موافق";
                this.BtnOk.UseVisualStyleBackColor = false;
                // 
                // Panel1
                // 
                this.Panel1.BackColor = System.Drawing.Color.Transparent;
                this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Panel1.Controls.Add(this.PictureBox1);
                this.Panel1.Location = new System.Drawing.Point(12, 171);
                this.Panel1.Name = "Panel1";
                this.Panel1.Size = new System.Drawing.Size(148, 72);
                this.Panel1.TabIndex = 4;
                // 
                // PictureBox1
                // 
                this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.PictureBox1.Image = global::My.Resources.Resources.EESoft_logo;
                this.PictureBox1.InitialImage = null;
                this.PictureBox1.Location = new System.Drawing.Point(23, 10);
                this.PictureBox1.Name = "PictureBox1";
                this.PictureBox1.Size = new System.Drawing.Size(100, 50);
                this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.PictureBox1.TabIndex = 2;
                this.PictureBox1.TabStop = false;
                // 
                // MSGBOXFrm
                // 
                this.AcceptButton = this.BtnOk;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.MSGBOXFrm;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.CancelButton = this.BtnOk;
                this.ClientSize = new System.Drawing.Size(400, 255);
                this.Controls.Add(this.Panel1);
                this.Controls.Add(this.BtnOk);
                this.Controls.Add(this.Panel);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "MSGBOXFrm";
                this.Opacity = 0D;
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "Login Error Message";
                this.Load += new System.EventHandler(this.MSGBOXFrm_Load);
                this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseDown);
                this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseMove);
                this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseUp);
                this.Panel.ResumeLayout(false);
                this.Panel.PerformLayout();
                this.Panel1.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel Panel;
		internal System.Windows.Forms.Button BtnOk;
		internal System.Windows.Forms.Label LBLMSG;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.PictureBox PictureBox1;
	}
	
}
