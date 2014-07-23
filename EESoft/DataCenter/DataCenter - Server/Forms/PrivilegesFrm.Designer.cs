using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class PrivilegesFrm : System.Windows.Forms.Form
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivilegesFrm));
                this.Label2 = new System.Windows.Forms.Label();
                this.TxtNewPriv = new System.Windows.Forms.TextBox();
                this.LBPrivileges = new System.Windows.Forms.ListBox();
                this.BtnAdd = new System.Windows.Forms.Button();
                this.BtnRemove = new System.Windows.Forms.Button();
                this.LblAction = new System.Windows.Forms.Label();
                this.TxtUpdate = new System.Windows.Forms.TextBox();
                this.BtnUpdate = new System.Windows.Forms.Button();
                this.BtnClose = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.BackColor = System.Drawing.Color.Transparent;
                this.Label2.ForeColor = System.Drawing.Color.Black;
                this.Label2.Location = new System.Drawing.Point(194, 15);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(71, 13);
                this.Label2.TabIndex = 0;
                this.Label2.Text = "سماحيه جديده";
                // 
                // TxtNewPriv
                // 
                this.TxtNewPriv.Location = new System.Drawing.Point(12, 12);
                this.TxtNewPriv.MaxLength = 20;
                this.TxtNewPriv.Name = "TxtNewPriv";
                this.TxtNewPriv.Size = new System.Drawing.Size(176, 20);
                this.TxtNewPriv.TabIndex = 1;
                this.TxtNewPriv.TextChanged += new System.EventHandler(this.TxtNewPriv_TextChanged);
                // 
                // LBPrivileges
                // 
                this.LBPrivileges.FormattingEnabled = true;
                this.LBPrivileges.Location = new System.Drawing.Point(12, 67);
                this.LBPrivileges.Name = "LBPrivileges";
                this.LBPrivileges.Size = new System.Drawing.Size(176, 82);
                this.LBPrivileges.TabIndex = 3;
                this.LBPrivileges.ValueMember = "RullID";
                this.LBPrivileges.SelectedIndexChanged += new System.EventHandler(this.LBPrivileges_SelectedIndexChanged);
                // 
                // BtnAdd
                // 
                this.BtnAdd.Enabled = false;
                this.BtnAdd.Location = new System.Drawing.Point(12, 38);
                this.BtnAdd.Name = "BtnAdd";
                this.BtnAdd.Size = new System.Drawing.Size(176, 23);
                this.BtnAdd.TabIndex = 2;
                this.BtnAdd.Text = "اضافه";
                this.BtnAdd.UseVisualStyleBackColor = true;
                this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
                // 
                // BtnRemove
                // 
                this.BtnRemove.Enabled = false;
                this.BtnRemove.Location = new System.Drawing.Point(194, 67);
                this.BtnRemove.Name = "BtnRemove";
                this.BtnRemove.Size = new System.Drawing.Size(78, 23);
                this.BtnRemove.TabIndex = 4;
                this.BtnRemove.Text = "حذف";
                this.BtnRemove.UseVisualStyleBackColor = true;
                this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
                // 
                // LblAction
                // 
                this.LblAction.BackColor = System.Drawing.Color.Gainsboro;
                this.LblAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LblAction.Location = new System.Drawing.Point(194, 93);
                this.LblAction.Name = "LblAction";
                this.LblAction.Size = new System.Drawing.Size(78, 66);
                this.LblAction.TabIndex = 8;
                this.LblAction.Text = "...";
                this.LblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // TxtUpdate
                // 
                this.TxtUpdate.Location = new System.Drawing.Point(12, 155);
                this.TxtUpdate.MaxLength = 20;
                this.TxtUpdate.Name = "TxtUpdate";
                this.TxtUpdate.Size = new System.Drawing.Size(176, 20);
                this.TxtUpdate.TabIndex = 5;
                this.TxtUpdate.TextChanged += new System.EventHandler(this.TxtUpdate_TextChanged);
                // 
                // BtnUpdate
                // 
                this.BtnUpdate.Enabled = false;
                this.BtnUpdate.Location = new System.Drawing.Point(12, 181);
                this.BtnUpdate.Name = "BtnUpdate";
                this.BtnUpdate.Size = new System.Drawing.Size(176, 23);
                this.BtnUpdate.TabIndex = 6;
                this.BtnUpdate.Text = "تعديل";
                this.BtnUpdate.UseVisualStyleBackColor = true;
                this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
                // 
                // BtnClose
                // 
                this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose.Location = new System.Drawing.Point(194, 181);
                this.BtnClose.Name = "BtnClose";
                this.BtnClose.Size = new System.Drawing.Size(78, 23);
                this.BtnClose.TabIndex = 7;
                this.BtnClose.Text = "اغلاق";
                this.BtnClose.UseVisualStyleBackColor = true;
                this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
                // 
                // PrivilegesFrm
                // 
                this.AcceptButton = this.BtnAdd;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.PrivilegesFrm;
                this.CancelButton = this.BtnClose;
                this.ClientSize = new System.Drawing.Size(284, 210);
                this.Controls.Add(this.LblAction);
                this.Controls.Add(this.BtnClose);
                this.Controls.Add(this.BtnRemove);
                this.Controls.Add(this.BtnUpdate);
                this.Controls.Add(this.BtnAdd);
                this.Controls.Add(this.LBPrivileges);
                this.Controls.Add(this.TxtUpdate);
                this.Controls.Add(this.TxtNewPriv);
                this.Controls.Add(this.Label2);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "PrivilegesFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "السماحيات";
                this.Load += new System.EventHandler(this.PrivilegesFrm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TxtNewPriv;
        internal System.Windows.Forms.ListBox LBPrivileges;
		internal System.Windows.Forms.Button BtnAdd;
		internal System.Windows.Forms.Button BtnRemove;
		internal System.Windows.Forms.Label LblAction;
		internal System.Windows.Forms.TextBox TxtUpdate;
		internal System.Windows.Forms.Button BtnUpdate;
        internal System.Windows.Forms.Button BtnClose;
        private System.ComponentModel.IContainer components;
	}
	
}
