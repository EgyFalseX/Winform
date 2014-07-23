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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class TransferFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferFrm));
                this.Lbl = new System.Windows.Forms.Label();
                this.BtnDownload = new System.Windows.Forms.Button();
                this.Label1 = new System.Windows.Forms.Label();
                this.BtnUpload = new System.Windows.Forms.Button();
                this.BtnBrowse = new System.Windows.Forms.Button();
                this.LblPath = new System.Windows.Forms.Label();
                this.PBUpload = new System.Windows.Forms.ProgressBar();
                this.Label2 = new System.Windows.Forms.Label();
                this.LblBytes = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // Lbl
                // 
                this.Lbl.AutoSize = true;
                this.Lbl.Location = new System.Drawing.Point(12, 244);
                this.Lbl.Name = "Lbl";
                this.Lbl.Size = new System.Drawing.Size(57, 13);
                this.Lbl.TabIndex = 0;
                this.Lbl.Text = "Loading ...";
                // 
                // BtnDownload
                // 
                this.BtnDownload.Location = new System.Drawing.Point(331, 10);
                this.BtnDownload.Name = "BtnDownload";
                this.BtnDownload.Size = new System.Drawing.Size(97, 23);
                this.BtnDownload.TabIndex = 1;
                this.BtnDownload.Text = "استقبال ملف";
                this.BtnDownload.UseVisualStyleBackColor = true;
                this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
                // 
                // Label1
                // 
                this.Label1.BackColor = System.Drawing.Color.DarkGray;
                this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Label1.Location = new System.Drawing.Point(5, 37);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(440, 5);
                this.Label1.TabIndex = 2;
                // 
                // BtnUpload
                // 
                this.BtnUpload.Enabled = false;
                this.BtnUpload.Location = new System.Drawing.Point(333, 75);
                this.BtnUpload.Name = "BtnUpload";
                this.BtnUpload.Size = new System.Drawing.Size(97, 23);
                this.BtnUpload.TabIndex = 1;
                this.BtnUpload.Text = "ارسال ملف";
                this.BtnUpload.UseVisualStyleBackColor = true;
                this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
                // 
                // BtnBrowse
                // 
                this.BtnBrowse.Location = new System.Drawing.Point(333, 46);
                this.BtnBrowse.Name = "BtnBrowse";
                this.BtnBrowse.Size = new System.Drawing.Size(97, 23);
                this.BtnBrowse.TabIndex = 1;
                this.BtnBrowse.Text = "...";
                this.BtnBrowse.UseVisualStyleBackColor = true;
                this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
                // 
                // LblPath
                // 
                this.LblPath.AutoSize = true;
                this.LblPath.BackColor = System.Drawing.Color.Transparent;
                this.LblPath.Location = new System.Drawing.Point(21, 51);
                this.LblPath.Name = "LblPath";
                this.LblPath.Size = new System.Drawing.Size(161, 13);
                this.LblPath.TabIndex = 3;
                this.LblPath.Text = "من فضلك اختار مسار الملف لارساله";
                this.LblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // PBUpload
                // 
                this.PBUpload.Location = new System.Drawing.Point(24, 77);
                this.PBUpload.Name = "PBUpload";
                this.PBUpload.Size = new System.Drawing.Size(303, 20);
                this.PBUpload.TabIndex = 4;
                this.PBUpload.Visible = false;
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.BackColor = System.Drawing.Color.Transparent;
                this.Label2.Location = new System.Drawing.Point(21, 15);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(39, 13);
                this.Label2.TabIndex = 5;
                this.Label2.Text = "استقبل";
                // 
                // LblBytes
                // 
                this.LblBytes.AutoSize = true;
                this.LblBytes.BackColor = System.Drawing.Color.Transparent;
                this.LblBytes.Location = new System.Drawing.Point(124, 15);
                this.LblBytes.Name = "LblBytes";
                this.LblBytes.Size = new System.Drawing.Size(13, 13);
                this.LblBytes.TabIndex = 5;
                this.LblBytes.Text = "0";
                // 
                // TransferFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.TransferFrm;
                this.ClientSize = new System.Drawing.Size(450, 108);
                this.Controls.Add(this.LblBytes);
                this.Controls.Add(this.Label2);
                this.Controls.Add(this.PBUpload);
                this.Controls.Add(this.Label1);
                this.Controls.Add(this.BtnBrowse);
                this.Controls.Add(this.BtnUpload);
                this.Controls.Add(this.BtnDownload);
                this.Controls.Add(this.Lbl);
                this.Controls.Add(this.LblPath);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "TransferFrm";
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "صفحة تحميل الملفات";
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.Label Lbl;
		internal System.Windows.Forms.Button BtnDownload;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button BtnUpload;
		internal System.Windows.Forms.Button BtnBrowse;
		internal System.Windows.Forms.Label LblPath;
		internal System.Windows.Forms.ProgressBar PBUpload;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label LblBytes;
	}
	
}
