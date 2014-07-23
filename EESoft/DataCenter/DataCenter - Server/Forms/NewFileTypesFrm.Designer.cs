using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class NewFileTypesFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFileTypesFrm));
                this.BtnSave = new System.Windows.Forms.Button();
                this.TxtExt = new System.Windows.Forms.TextBox();
                this.TxtName = new System.Windows.Forms.TextBox();
                this.TxtDes = new System.Windows.Forms.TextBox();
                this.Label3 = new System.Windows.Forms.Label();
                this.Label5 = new System.Windows.Forms.Label();
                this.Label1 = new System.Windows.Forms.Label();
                this.BtnClose = new System.Windows.Forms.Button();
                this.BtnIcon = new System.Windows.Forms.Button();
                this.LblIconPath = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // BtnSave
                // 
                this.BtnSave.Enabled = false;
                this.BtnSave.Location = new System.Drawing.Point(215, 37);
                this.BtnSave.Name = "BtnSave";
                this.BtnSave.Size = new System.Drawing.Size(103, 23);
                this.BtnSave.TabIndex = 4;
                this.BtnSave.Text = "حفظ";
                this.BtnSave.UseVisualStyleBackColor = true;
                this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
                // 
                // TxtExt
                // 
                this.TxtExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.TxtExt.Location = new System.Drawing.Point(326, 40);
                this.TxtExt.MaxLength = 3;
                this.TxtExt.Name = "TxtExt";
                this.TxtExt.Size = new System.Drawing.Size(152, 20);
                this.TxtExt.TabIndex = 1;
                this.TxtExt.TextChanged += new System.EventHandler(this.TxtExt_TextChanged);
                // 
                // TxtName
                // 
                this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.TxtName.Location = new System.Drawing.Point(326, 14);
                this.TxtName.MaxLength = 100;
                this.TxtName.Name = "TxtName";
                this.TxtName.Size = new System.Drawing.Size(152, 20);
                this.TxtName.TabIndex = 0;
                this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
                // 
                // TxtDes
                // 
                this.TxtDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.TxtDes.Location = new System.Drawing.Point(19, 12);
                this.TxtDes.MaxLength = 50;
                this.TxtDes.Multiline = true;
                this.TxtDes.Name = "TxtDes";
                this.TxtDes.Size = new System.Drawing.Size(172, 46);
                this.TxtDes.TabIndex = 2;
                // 
                // Label3
                // 
                this.Label3.AutoSize = true;
                this.Label3.BackColor = System.Drawing.Color.Transparent;
                this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Label3.ForeColor = System.Drawing.Color.Black;
                this.Label3.Location = new System.Drawing.Point(494, 42);
                this.Label3.Name = "Label3";
                this.Label3.Size = new System.Drawing.Size(40, 15);
                this.Label3.TabIndex = 11;
                this.Label3.Text = "الامتداد";
                // 
                // Label5
                // 
                this.Label5.AutoSize = true;
                this.Label5.BackColor = System.Drawing.Color.Transparent;
                this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Label5.ForeColor = System.Drawing.Color.Black;
                this.Label5.Location = new System.Drawing.Point(197, 14);
                this.Label5.Name = "Label5";
                this.Label5.Size = new System.Drawing.Size(34, 15);
                this.Label5.TabIndex = 10;
                this.Label5.Text = "تعليق";
                // 
                // Label1
                // 
                this.Label1.AutoSize = true;
                this.Label1.BackColor = System.Drawing.Color.Transparent;
                this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Label1.ForeColor = System.Drawing.Color.Black;
                this.Label1.Location = new System.Drawing.Point(502, 16);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(32, 15);
                this.Label1.TabIndex = 13;
                this.Label1.Text = "الاسم";
                // 
                // BtnClose
                // 
                this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose.Location = new System.Drawing.Point(477, 70);
                this.BtnClose.Name = "BtnClose";
                this.BtnClose.Size = new System.Drawing.Size(60, 23);
                this.BtnClose.TabIndex = 5;
                this.BtnClose.Text = "اغلاق";
                this.BtnClose.UseVisualStyleBackColor = true;
                this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
                // 
                // BtnIcon
                // 
                this.BtnIcon.Location = new System.Drawing.Point(19, 70);
                this.BtnIcon.Name = "BtnIcon";
                this.BtnIcon.Size = new System.Drawing.Size(90, 23);
                this.BtnIcon.TabIndex = 3;
                this.BtnIcon.Text = "اختار ايكون";
                this.BtnIcon.UseVisualStyleBackColor = true;
                this.BtnIcon.Click += new System.EventHandler(this.BtnIcon_Click);
                // 
                // LblIconPath
                // 
                this.LblIconPath.AutoSize = true;
                this.LblIconPath.BackColor = System.Drawing.Color.Transparent;
                this.LblIconPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LblIconPath.ForeColor = System.Drawing.Color.Black;
                this.LblIconPath.Location = new System.Drawing.Point(115, 75);
                this.LblIconPath.Name = "LblIconPath";
                this.LblIconPath.Size = new System.Drawing.Size(37, 15);
                this.LblIconPath.TabIndex = 21;
                this.LblIconPath.Text = "لايوجد";
                this.LblIconPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // NewFileTypesFrm
                // 
                this.AcceptButton = this.BtnSave;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.NewFileTypesFrm;
                this.CancelButton = this.BtnClose;
                this.ClientSize = new System.Drawing.Size(556, 104);
                this.Controls.Add(this.BtnClose);
                this.Controls.Add(this.BtnIcon);
                this.Controls.Add(this.BtnSave);
                this.Controls.Add(this.TxtExt);
                this.Controls.Add(this.TxtName);
                this.Controls.Add(this.TxtDes);
                this.Controls.Add(this.Label3);
                this.Controls.Add(this.Label5);
                this.Controls.Add(this.Label1);
                this.Controls.Add(this.LblIconPath);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "NewFileTypesFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "انواع الملفات";
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.Button BtnSave;
		internal System.Windows.Forms.TextBox TxtExt;
		internal System.Windows.Forms.TextBox TxtName;
		internal System.Windows.Forms.TextBox TxtDes;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button BtnClose;
		internal System.Windows.Forms.Button BtnIcon;
		internal System.Windows.Forms.Label LblIconPath;
	}
	
}
