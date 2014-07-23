using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class UsersPrivilegesFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersPrivilegesFrm));
                this.Label1 = new System.Windows.Forms.Label();
                this.CBUsers = new System.Windows.Forms.ComboBox();
                this.Label5 = new System.Windows.Forms.Label();
                this.Label3 = new System.Windows.Forms.Label();
                this.BtnRemoveSelected = new System.Windows.Forms.Button();
                this.BtnAddSelected = new System.Windows.Forms.Button();
                this.LBSelectedprivileges = new System.Windows.Forms.ListBox();
                this.LBAllprivileges = new System.Windows.Forms.ListBox();
                this.BtnClose = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // Label1
                // 
                this.Label1.AutoSize = true;
                this.Label1.BackColor = System.Drawing.Color.Transparent;
                this.Label1.ForeColor = System.Drawing.Color.Black;
                this.Label1.Location = new System.Drawing.Point(263, 3);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(59, 13);
                this.Label1.TabIndex = 0;
                this.Label1.Text = "المستخدمين";
                // 
                // CBUsers
                // 
                this.CBUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.CBUsers.FormattingEnabled = true;
                this.CBUsers.Location = new System.Drawing.Point(187, 19);
                this.CBUsers.Name = "CBUsers";
                this.CBUsers.Size = new System.Drawing.Size(135, 21);
                this.CBUsers.TabIndex = 1;
                this.CBUsers.SelectedIndexChanged += new System.EventHandler(this.CBUsers_SelectedIndexChanged);
                // 
                // Label5
                // 
                this.Label5.AutoSize = true;
                this.Label5.BackColor = System.Drawing.Color.Transparent;
                this.Label5.ForeColor = System.Drawing.Color.Black;
                this.Label5.Location = new System.Drawing.Point(184, 47);
                this.Label5.Name = "Label5";
                this.Label5.Size = new System.Drawing.Size(94, 13);
                this.Label5.TabIndex = 9;
                this.Label5.Text = "السماحيات المختاره";
                this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // Label3
                // 
                this.Label3.AutoSize = true;
                this.Label3.BackColor = System.Drawing.Color.Transparent;
                this.Label3.ForeColor = System.Drawing.Color.Black;
                this.Label3.Location = new System.Drawing.Point(10, 47);
                this.Label3.Name = "Label3";
                this.Label3.Size = new System.Drawing.Size(80, 13);
                this.Label3.TabIndex = 10;
                this.Label3.Text = "جميع السماحيات";
                this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // BtnRemoveSelected
                // 
                this.BtnRemoveSelected.Enabled = false;
                this.BtnRemoveSelected.Location = new System.Drawing.Point(150, 180);
                this.BtnRemoveSelected.Name = "BtnRemoveSelected";
                this.BtnRemoveSelected.Size = new System.Drawing.Size(37, 23);
                this.BtnRemoveSelected.TabIndex = 4;
                this.BtnRemoveSelected.Text = "<";
                this.BtnRemoveSelected.UseVisualStyleBackColor = true;
                this.BtnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
                // 
                // BtnAddSelected
                // 
                this.BtnAddSelected.Enabled = false;
                this.BtnAddSelected.Location = new System.Drawing.Point(148, 136);
                this.BtnAddSelected.Name = "BtnAddSelected";
                this.BtnAddSelected.Size = new System.Drawing.Size(37, 23);
                this.BtnAddSelected.TabIndex = 3;
                this.BtnAddSelected.Text = ">";
                this.BtnAddSelected.UseVisualStyleBackColor = true;
                this.BtnAddSelected.Click += new System.EventHandler(this.BtnAddSelected_Click);
                // 
                // LBSelectedprivileges
                // 
                this.LBSelectedprivileges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LBSelectedprivileges.FormattingEnabled = true;
                this.LBSelectedprivileges.Location = new System.Drawing.Point(187, 63);
                this.LBSelectedprivileges.Name = "LBSelectedprivileges";
                this.LBSelectedprivileges.Size = new System.Drawing.Size(135, 197);
                this.LBSelectedprivileges.TabIndex = 5;
                this.LBSelectedprivileges.SelectedIndexChanged += new System.EventHandler(this.LBSelectedprivileges_SelectedIndexChanged);
                this.LBSelectedprivileges.DoubleClick += new System.EventHandler(this.LBSelectedprivileges_DoubleClick);
                // 
                // LBAllprivileges
                // 
                this.LBAllprivileges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LBAllprivileges.FormattingEnabled = true;
                this.LBAllprivileges.Location = new System.Drawing.Point(11, 63);
                this.LBAllprivileges.Name = "LBAllprivileges";
                this.LBAllprivileges.Size = new System.Drawing.Size(135, 197);
                this.LBAllprivileges.TabIndex = 2;
                this.LBAllprivileges.SelectedIndexChanged += new System.EventHandler(this.LBAllprivileges_SelectedIndexChanged);
                this.LBAllprivileges.DoubleClick += new System.EventHandler(this.LBAllprivileges_DoubleClick);
                // 
                // BtnClose
                // 
                this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose.Location = new System.Drawing.Point(13, 266);
                this.BtnClose.Name = "BtnClose";
                this.BtnClose.Size = new System.Drawing.Size(311, 23);
                this.BtnClose.TabIndex = 6;
                this.BtnClose.Text = "اغلاق";
                this.BtnClose.UseVisualStyleBackColor = true;
                this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
                // 
                // UsersPrivilegesFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.UsersPrivilegesFrm;
                this.CancelButton = this.BtnClose;
                this.ClientSize = new System.Drawing.Size(334, 293);
                this.Controls.Add(this.BtnClose);
                this.Controls.Add(this.Label5);
                this.Controls.Add(this.Label3);
                this.Controls.Add(this.BtnRemoveSelected);
                this.Controls.Add(this.BtnAddSelected);
                this.Controls.Add(this.LBSelectedprivileges);
                this.Controls.Add(this.LBAllprivileges);
                this.Controls.Add(this.CBUsers);
                this.Controls.Add(this.Label1);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "UsersPrivilegesFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "سماحيات المستخدمين";
                this.Load += new System.EventHandler(this.UsersPrivilegesFrm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox CBUsers;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button BtnRemoveSelected;
		internal System.Windows.Forms.Button BtnAddSelected;
		internal System.Windows.Forms.ListBox LBSelectedprivileges;
		internal System.Windows.Forms.ListBox LBAllprivileges;
		internal System.Windows.Forms.Button BtnClose;
	}
	
}
