using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class DisactivatedUsersFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisactivatedUsersFrm));
                this.BtnActivate = new System.Windows.Forms.Button();
                this.Label1 = new System.Windows.Forms.Label();
                this.LBUsers = new System.Windows.Forms.ListBox();
                this.BtnDelete = new System.Windows.Forms.Button();
                this.BtnClose = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // BtnActivate
                // 
                this.BtnActivate.Location = new System.Drawing.Point(11, 44);
                this.BtnActivate.Name = "BtnActivate";
                this.BtnActivate.Size = new System.Drawing.Size(110, 23);
                this.BtnActivate.TabIndex = 1;
                this.BtnActivate.Text = "تفعيــــل";
                this.BtnActivate.UseVisualStyleBackColor = true;
                this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
                // 
                // Label1
                // 
                this.Label1.AutoSize = true;
                this.Label1.BackColor = System.Drawing.Color.Transparent;
                this.Label1.ForeColor = System.Drawing.Color.Black;
                this.Label1.Location = new System.Drawing.Point(8, 8);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(117, 13);
                this.Label1.TabIndex = 1;
                this.Label1.Text = "المستخدمين غير المفعلين";
                // 
                // LBUsers
                // 
                this.LBUsers.FormattingEnabled = true;
                this.LBUsers.Location = new System.Drawing.Point(137, 8);
                this.LBUsers.Name = "LBUsers";
                this.LBUsers.Size = new System.Drawing.Size(139, 251);
                this.LBUsers.TabIndex = 0;
                this.LBUsers.SelectedIndexChanged += new System.EventHandler(this.LBUsers_SelectedIndexChanged);
                // 
                // BtnDelete
                // 
                this.BtnDelete.Location = new System.Drawing.Point(11, 73);
                this.BtnDelete.Name = "BtnDelete";
                this.BtnDelete.Size = new System.Drawing.Size(110, 23);
                this.BtnDelete.TabIndex = 2;
                this.BtnDelete.Text = "حزف";
                this.BtnDelete.UseVisualStyleBackColor = true;
                this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
                // 
                // BtnClose
                // 
                this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose.Location = new System.Drawing.Point(11, 236);
                this.BtnClose.Name = "BtnClose";
                this.BtnClose.Size = new System.Drawing.Size(110, 23);
                this.BtnClose.TabIndex = 3;
                this.BtnClose.Text = "اغلاق";
                this.BtnClose.UseVisualStyleBackColor = true;
                this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
                // 
                // DisactivatedUsersFrm
                // 
                this.AcceptButton = this.BtnActivate;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.DisactivatedUsersFrm;
                this.CancelButton = this.BtnClose;
                this.ClientSize = new System.Drawing.Size(284, 266);
                this.Controls.Add(this.LBUsers);
                this.Controls.Add(this.Label1);
                this.Controls.Add(this.BtnClose);
                this.Controls.Add(this.BtnDelete);
                this.Controls.Add(this.BtnActivate);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "DisactivatedUsersFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "تفعيل المستخدمين";
                this.Load += new System.EventHandler(this.DisactivatedUsersFrm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.Button BtnActivate;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ListBox LBUsers;
		internal System.Windows.Forms.Button BtnDelete;
		internal System.Windows.Forms.Button BtnClose;
	}
	
}
