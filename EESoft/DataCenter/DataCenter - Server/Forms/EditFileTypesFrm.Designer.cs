using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class EditFileTypesFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFileTypesFrm));
                this.BtnClose = new System.Windows.Forms.Button();
                this.BtnIcon = new System.Windows.Forms.Button();
                this.BtnSave = new System.Windows.Forms.Button();
                this.TxtExt = new System.Windows.Forms.TextBox();
                this.TxtName = new System.Windows.Forms.TextBox();
                this.TxtDes = new System.Windows.Forms.TextBox();
                this.Label3 = new System.Windows.Forms.Label();
                this.Label5 = new System.Windows.Forms.Label();
                this.Label1 = new System.Windows.Forms.Label();
                this.LblIconPath = new System.Windows.Forms.Label();
                this.Label2 = new System.Windows.Forms.Label();
                this.CBTypes = new System.Windows.Forms.ComboBox();
                this.BtnDelete = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // BtnClose
                // 
                this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose.Location = new System.Drawing.Point(470, 95);
                this.BtnClose.Name = "BtnClose";
                this.BtnClose.Size = new System.Drawing.Size(60, 23);
                this.BtnClose.TabIndex = 7;
                this.BtnClose.Text = "اغلاق";
                this.BtnClose.UseVisualStyleBackColor = true;
                this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
                // 
                // BtnIcon
                // 
                this.BtnIcon.Location = new System.Drawing.Point(12, 95);
                this.BtnIcon.Name = "BtnIcon";
                this.BtnIcon.Size = new System.Drawing.Size(90, 23);
                this.BtnIcon.TabIndex = 5;
                this.BtnIcon.Text = "تحميل ايكون";
                this.BtnIcon.UseVisualStyleBackColor = true;
                this.BtnIcon.Click += new System.EventHandler(this.BtnIcon_Click);
                // 
                // BtnSave
                // 
                this.BtnSave.Enabled = false;
                this.BtnSave.Location = new System.Drawing.Point(249, 63);
                this.BtnSave.Name = "BtnSave";
                this.BtnSave.Size = new System.Drawing.Size(103, 23);
                this.BtnSave.TabIndex = 6;
                this.BtnSave.Text = "حفظ";
                this.BtnSave.UseVisualStyleBackColor = true;
                this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
                // 
                // TxtExt
                // 
                this.TxtExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.TxtExt.Location = new System.Drawing.Point(88, 63);
                this.TxtExt.MaxLength = 3;
                this.TxtExt.Name = "TxtExt";
                this.TxtExt.Size = new System.Drawing.Size(152, 20);
                this.TxtExt.TabIndex = 3;
                // 
                // TxtName
                // 
                this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.TxtName.Location = new System.Drawing.Point(88, 37);
                this.TxtName.MaxLength = 100;
                this.TxtName.Name = "TxtName";
                this.TxtName.Size = new System.Drawing.Size(152, 20);
                this.TxtName.TabIndex = 2;
                // 
                // TxtDes
                // 
                this.TxtDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.TxtDes.Location = new System.Drawing.Point(358, 37);
                this.TxtDes.MaxLength = 50;
                this.TxtDes.Multiline = true;
                this.TxtDes.Name = "TxtDes";
                this.TxtDes.Size = new System.Drawing.Size(172, 48);
                this.TxtDes.TabIndex = 4;
                // 
                // Label3
                // 
                this.Label3.AutoSize = true;
                this.Label3.BackColor = System.Drawing.Color.Transparent;
                this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Label3.ForeColor = System.Drawing.Color.Black;
                this.Label3.Location = new System.Drawing.Point(12, 65);
                this.Label3.Name = "Label3";
                this.Label3.Size = new System.Drawing.Size(43, 15);
                this.Label3.TabIndex = 29;
                this.Label3.Text = "الامتداد";
                // 
                // Label5
                // 
                this.Label5.AutoSize = true;
                this.Label5.BackColor = System.Drawing.Color.Transparent;
                this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Label5.ForeColor = System.Drawing.Color.Black;
                this.Label5.Location = new System.Drawing.Point(285, 39);
                this.Label5.Name = "Label5";
                this.Label5.Size = new System.Drawing.Size(36, 15);
                this.Label5.TabIndex = 28;
                this.Label5.Text = "تعليق";
                // 
                // Label1
                // 
                this.Label1.AutoSize = true;
                this.Label1.BackColor = System.Drawing.Color.Transparent;
                this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Label1.Location = new System.Drawing.Point(12, 39);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(56, 15);
                this.Label1.TabIndex = 30;
                this.Label1.Text = "اسم النوع";
                // 
                // LblIconPath
                // 
                this.LblIconPath.AutoSize = true;
                this.LblIconPath.BackColor = System.Drawing.Color.Transparent;
                this.LblIconPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LblIconPath.ForeColor = System.Drawing.Color.Black;
                this.LblIconPath.Location = new System.Drawing.Point(108, 100);
                this.LblIconPath.Name = "LblIconPath";
                this.LblIconPath.Size = new System.Drawing.Size(40, 15);
                this.LblIconPath.TabIndex = 31;
                this.LblIconPath.Text = "لا يوجد";
                this.LblIconPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.BackColor = System.Drawing.Color.Transparent;
                this.Label2.ForeColor = System.Drawing.Color.Black;
                this.Label2.Location = new System.Drawing.Point(147, 8);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(35, 13);
                this.Label2.TabIndex = 32;
                this.Label2.Text = "الانواع";
                // 
                // CBTypes
                // 
                this.CBTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.CBTypes.FormattingEnabled = true;
                this.CBTypes.Location = new System.Drawing.Point(196, 8);
                this.CBTypes.Name = "CBTypes";
                this.CBTypes.Size = new System.Drawing.Size(200, 21);
                this.CBTypes.TabIndex = 0;
                this.CBTypes.SelectedIndexChanged += new System.EventHandler(this.CBTypes_SelectedIndexChanged);
                // 
                // BtnDelete
                // 
                this.BtnDelete.Enabled = false;
                this.BtnDelete.Location = new System.Drawing.Point(402, 8);
                this.BtnDelete.Name = "BtnDelete";
                this.BtnDelete.Size = new System.Drawing.Size(103, 23);
                this.BtnDelete.TabIndex = 1;
                this.BtnDelete.Text = "حذف";
                this.BtnDelete.UseVisualStyleBackColor = true;
                this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
                // 
                // EditFileTypesFrm
                // 
                this.AcceptButton = this.BtnSave;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.EditFileTypesFrm;
                this.CancelButton = this.BtnClose;
                this.ClientSize = new System.Drawing.Size(584, 128);
                this.Controls.Add(this.CBTypes);
                this.Controls.Add(this.Label2);
                this.Controls.Add(this.BtnClose);
                this.Controls.Add(this.BtnIcon);
                this.Controls.Add(this.BtnDelete);
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
                this.Name = "EditFileTypesFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "تعديل انواع الملفات";
                this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditFileTypesFrm_FormClosing);
                this.Load += new System.EventHandler(this.EditFileTypesFrm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.Button BtnClose;
		internal System.Windows.Forms.Button BtnIcon;
		internal System.Windows.Forms.Button BtnSave;
		internal System.Windows.Forms.TextBox TxtExt;
		internal System.Windows.Forms.TextBox TxtName;
		internal System.Windows.Forms.TextBox TxtDes;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label LblIconPath;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox CBTypes;
		internal System.Windows.Forms.Button BtnDelete;
	}
	
}
