using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class LockedFilesFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockedFilesFrm));
                this.LVFiles = new System.Windows.Forms.ListView();
                this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.BtnApply = new System.Windows.Forms.Button();
                this.Panel1 = new System.Windows.Forms.Panel();
                this.CBSelectNone = new System.Windows.Forms.CheckBox();
                this.CBSelectAll = new System.Windows.Forms.CheckBox();
                this.Panel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // LVFiles
                // 
                this.LVFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.LVFiles.BackColor = System.Drawing.Color.White;
                this.LVFiles.CheckBoxes = true;
                this.LVFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader3,
            this.ColumnHeader1,
            this.ColumnHeader4});
                this.LVFiles.FullRowSelect = true;
                this.LVFiles.Location = new System.Drawing.Point(12, 12);
                this.LVFiles.Name = "LVFiles";
                this.LVFiles.Size = new System.Drawing.Size(581, 395);
                this.LVFiles.TabIndex = 0;
                this.LVFiles.UseCompatibleStateImageBehavior = false;
                this.LVFiles.View = System.Windows.Forms.View.Details;
                this.LVFiles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LVFiles_ItemChecked);
                // 
                // ColumnHeader3
                // 
                this.ColumnHeader3.Text = "اسم الملف";
                this.ColumnHeader3.Width = 100;
                // 
                // ColumnHeader1
                // 
                this.ColumnHeader1.Text = "المسار";
                this.ColumnHeader1.Width = 270;
                // 
                // ColumnHeader4
                // 
                this.ColumnHeader4.Text = "اسم المستخدم";
                this.ColumnHeader4.Width = 96;
                // 
                // BtnApply
                // 
                this.BtnApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                this.BtnApply.Location = new System.Drawing.Point(188, 4);
                this.BtnApply.Name = "BtnApply";
                this.BtnApply.Size = new System.Drawing.Size(107, 23);
                this.BtnApply.TabIndex = 3;
                this.BtnApply.Text = "تفعيل";
                this.BtnApply.UseVisualStyleBackColor = true;
                this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
                // 
                // Panel1
                // 
                this.Panel1.BackColor = System.Drawing.Color.Transparent;
                this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Panel1.Controls.Add(this.CBSelectNone);
                this.Panel1.Controls.Add(this.BtnApply);
                this.Panel1.Controls.Add(this.CBSelectAll);
                this.Panel1.Location = new System.Drawing.Point(60, 411);
                this.Panel1.Name = "Panel1";
                this.Panel1.Size = new System.Drawing.Size(484, 32);
                this.Panel1.TabIndex = 4;
                // 
                // CBSelectNone
                // 
                this.CBSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                this.CBSelectNone.AutoSize = true;
                this.CBSelectNone.Location = new System.Drawing.Point(387, 7);
                this.CBSelectNone.Name = "CBSelectNone";
                this.CBSelectNone.Size = new System.Drawing.Size(90, 17);
                this.CBSelectNone.TabIndex = 1;
                this.CBSelectNone.Text = "اخيتار لا شيء";
                this.CBSelectNone.UseVisualStyleBackColor = true;
                this.CBSelectNone.CheckedChanged += new System.EventHandler(this.CBSelectNone_CheckedChanged);
                // 
                // CBSelectAll
                // 
                this.CBSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                this.CBSelectAll.AutoSize = true;
                this.CBSelectAll.Location = new System.Drawing.Point(303, 7);
                this.CBSelectAll.Name = "CBSelectAll";
                this.CBSelectAll.Size = new System.Drawing.Size(76, 17);
                this.CBSelectAll.TabIndex = 0;
                this.CBSelectAll.Text = "اختيار الكل";
                this.CBSelectAll.UseVisualStyleBackColor = true;
                this.CBSelectAll.CheckedChanged += new System.EventHandler(this.CBSelectAll_CheckedChanged);
                // 
                // LockedFilesFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.LockedFilesFrm;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.ClientSize = new System.Drawing.Size(605, 448);
                this.Controls.Add(this.Panel1);
                this.Controls.Add(this.LVFiles);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "LockedFilesFrm";
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "الملفات المغلقه";
                this.TransparencyKey = System.Drawing.Color.Lime;
                this.Load += new System.EventHandler(this.LockedFilesFrm_Load);
                this.Panel1.ResumeLayout(false);
                this.Panel1.PerformLayout();
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.ListView LVFiles;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.Button BtnApply;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.CheckBox CBSelectNone;
        internal System.Windows.Forms.CheckBox CBSelectAll;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
	}
}
