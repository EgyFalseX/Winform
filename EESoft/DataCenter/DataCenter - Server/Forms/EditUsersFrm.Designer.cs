using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class EditUsersFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUsersFrm));
                this.BtnClose = new System.Windows.Forms.Button();
                this.BtnRemove = new System.Windows.Forms.Button();
                this.BtnUpdate = new System.Windows.Forms.Button();
                this.BtnAdd = new System.Windows.Forms.Button();
                this.Label3 = new System.Windows.Forms.Label();
                this.LBUsers = new System.Windows.Forms.ListBox();
                this.TxtUpdate = new System.Windows.Forms.TextBox();
                this.TxtNewUser = new System.Windows.Forms.TextBox();
                this.Label2 = new System.Windows.Forms.Label();
                this.BtnReset = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // BtnClose
                // 
                this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose.Location = new System.Drawing.Point(197, 175);
                this.BtnClose.Name = "BtnClose";
                this.BtnClose.Size = new System.Drawing.Size(78, 23);
                this.BtnClose.TabIndex = 7;
                this.BtnClose.Text = "اغلاق";
                this.BtnClose.UseVisualStyleBackColor = true;
                // 
                // BtnRemove
                // 
                this.BtnRemove.Enabled = false;
                this.BtnRemove.Location = new System.Drawing.Point(197, 77);
                this.BtnRemove.Name = "BtnRemove";
                this.BtnRemove.Size = new System.Drawing.Size(78, 23);
                this.BtnRemove.TabIndex = 3;
                this.BtnRemove.Text = "حذف";
                this.BtnRemove.UseVisualStyleBackColor = true;
                this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
                // 
                // BtnUpdate
                // 
                this.BtnUpdate.Enabled = false;
                this.BtnUpdate.Location = new System.Drawing.Point(12, 174);
                this.BtnUpdate.Name = "BtnUpdate";
                this.BtnUpdate.Size = new System.Drawing.Size(176, 23);
                this.BtnUpdate.TabIndex = 6;
                this.BtnUpdate.Text = "تعديل";
                this.BtnUpdate.UseVisualStyleBackColor = true;
                this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
                // 
                // BtnAdd
                // 
                this.BtnAdd.Enabled = false;
                this.BtnAdd.Location = new System.Drawing.Point(12, 31);
                this.BtnAdd.Name = "BtnAdd";
                this.BtnAdd.Size = new System.Drawing.Size(176, 23);
                this.BtnAdd.TabIndex = 1;
                this.BtnAdd.Text = "اضافه";
                this.BtnAdd.UseVisualStyleBackColor = true;
                this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
                // 
                // Label3
                // 
                this.Label3.AutoSize = true;
                this.Label3.BackColor = System.Drawing.Color.Transparent;
                this.Label3.ForeColor = System.Drawing.Color.Black;
                this.Label3.Location = new System.Drawing.Point(194, 61);
                this.Label3.Name = "Label3";
                this.Label3.Size = new System.Drawing.Size(85, 13);
                this.Label3.TabIndex = 13;
                this.Label3.Text = "جميع المستخدمين";
                // 
                // LBUsers
                // 
                this.LBUsers.FormattingEnabled = true;
                this.LBUsers.Location = new System.Drawing.Point(12, 60);
                this.LBUsers.Name = "LBUsers";
                this.LBUsers.Size = new System.Drawing.Size(176, 82);
                this.LBUsers.TabIndex = 2;
                this.LBUsers.SelectedIndexChanged += new System.EventHandler(this.LBUsers_SelectedIndexChanged);
                // 
                // TxtUpdate
                // 
                this.TxtUpdate.Location = new System.Drawing.Point(12, 148);
                this.TxtUpdate.MaxLength = 20;
                this.TxtUpdate.Name = "TxtUpdate";
                this.TxtUpdate.ReadOnly = true;
                this.TxtUpdate.Size = new System.Drawing.Size(176, 20);
                this.TxtUpdate.TabIndex = 5;
                this.TxtUpdate.TextChanged += new System.EventHandler(this.TxtUpdate_TextChanged);
                // 
                // TxtNewUser
                // 
                this.TxtNewUser.Location = new System.Drawing.Point(15, 5);
                this.TxtNewUser.MaxLength = 20;
                this.TxtNewUser.Name = "TxtNewUser";
                this.TxtNewUser.Size = new System.Drawing.Size(176, 20);
                this.TxtNewUser.TabIndex = 0;
                this.TxtNewUser.TextChanged += new System.EventHandler(this.TxtNewUser_TextChanged);
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.BackColor = System.Drawing.Color.Transparent;
                this.Label2.ForeColor = System.Drawing.Color.Black;
                this.Label2.Location = new System.Drawing.Point(197, 9);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(66, 13);
                this.Label2.TabIndex = 9;
                this.Label2.Text = "مستخدم جديد";
                // 
                // BtnReset
                // 
                this.BtnReset.Enabled = false;
                this.BtnReset.Location = new System.Drawing.Point(197, 106);
                this.BtnReset.Name = "BtnReset";
                this.BtnReset.Size = new System.Drawing.Size(78, 52);
                this.BtnReset.TabIndex = 4;
                this.BtnReset.Text = "تعديل كلمة المرور للحاله الافتراضيه";
                this.BtnReset.UseVisualStyleBackColor = true;
                this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
                // 
                // EditUsersFrm
                // 
                this.AcceptButton = this.BtnAdd;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.EditUsersFrm;
                this.CancelButton = this.BtnClose;
                this.ClientSize = new System.Drawing.Size(287, 203);
                this.Controls.Add(this.BtnClose);
                this.Controls.Add(this.BtnReset);
                this.Controls.Add(this.BtnRemove);
                this.Controls.Add(this.BtnUpdate);
                this.Controls.Add(this.BtnAdd);
                this.Controls.Add(this.Label3);
                this.Controls.Add(this.LBUsers);
                this.Controls.Add(this.TxtUpdate);
                this.Controls.Add(this.TxtNewUser);
                this.Controls.Add(this.Label2);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "EditUsersFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "المستخدمين";
                this.Load += new System.EventHandler(this.UsersFrm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.Button BtnClose;
		internal System.Windows.Forms.Button BtnRemove;
		internal System.Windows.Forms.Button BtnUpdate;
		internal System.Windows.Forms.Button BtnAdd;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ListBox LBUsers;
		internal System.Windows.Forms.TextBox TxtUpdate;
		internal System.Windows.Forms.TextBox TxtNewUser;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button BtnReset;
	}
	
}
