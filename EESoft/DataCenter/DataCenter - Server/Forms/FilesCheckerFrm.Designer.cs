using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class FilesCheckerFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesCheckerFrm));
                this.LVFolderFile = new System.Windows.Forms.ListView();
                this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.Label1 = new System.Windows.Forms.Label();
                this.CBFilter = new System.Windows.Forms.ComboBox();
                this.BtnStart = new System.Windows.Forms.Button();
                this.Panel1 = new System.Windows.Forms.Panel();
                this.LblTotal = new System.Windows.Forms.Label();
                this.Label4 = new System.Windows.Forms.Label();
                this.LblNotFound = new System.Windows.Forms.Label();
                this.Lblfound = new System.Windows.Forms.Label();
                this.Label3 = new System.Windows.Forms.Label();
                this.Label2 = new System.Windows.Forms.Label();
                this.Btnscan = new System.Windows.Forms.Button();
                this.PBData = new System.Windows.Forms.ProgressBar();
                this.Lblpercent = new System.Windows.Forms.Label();
                this.Label6 = new System.Windows.Forms.Label();
                this.Panel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // LVFolderFile
                // 
                this.LVFolderFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.LVFolderFile.BackColor = System.Drawing.SystemColors.Info;
                this.LVFolderFile.CheckBoxes = true;
                this.LVFolderFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader3,
            this.ColumnHeader1,
            this.ColumnHeader2});
                this.LVFolderFile.FullRowSelect = true;
                this.LVFolderFile.Location = new System.Drawing.Point(12, 26);
                this.LVFolderFile.Name = "LVFolderFile";
                this.LVFolderFile.Size = new System.Drawing.Size(484, 322);
                this.LVFolderFile.TabIndex = 1;
                this.LVFolderFile.UseCompatibleStateImageBehavior = false;
                this.LVFolderFile.View = System.Windows.Forms.View.Details;
                // 
                // ColumnHeader3
                // 
                this.ColumnHeader3.Text = "الحاله";
                this.ColumnHeader3.Width = 75;
                // 
                // ColumnHeader1
                // 
                this.ColumnHeader1.Text = "المسار";
                this.ColumnHeader1.Width = 305;
                // 
                // ColumnHeader2
                // 
                this.ColumnHeader2.Text = "الاسم";
                this.ColumnHeader2.Width = 100;
                // 
                // Label1
                // 
                this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                this.Label1.AutoSize = true;
                this.Label1.BackColor = System.Drawing.Color.Transparent;
                this.Label1.ForeColor = System.Drawing.Color.Black;
                this.Label1.Location = new System.Drawing.Point(423, 367);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(25, 13);
                this.Label1.TabIndex = 1;
                this.Label1.Text = "فلتر";
                // 
                // CBFilter
                // 
                this.CBFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                this.CBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.CBFilter.FormattingEnabled = true;
                this.CBFilter.Items.AddRange(new object[] {
            "اظهار المفقود فقط"});
                this.CBFilter.Location = new System.Drawing.Point(327, 383);
                this.CBFilter.Name = "CBFilter";
                this.CBFilter.Size = new System.Drawing.Size(121, 21);
                this.CBFilter.TabIndex = 2;
                this.CBFilter.SelectedIndexChanged += new System.EventHandler(this.CBFilter_SelectedIndexChanged);
                // 
                // BtnStart
                // 
                this.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                this.BtnStart.Enabled = false;
                this.BtnStart.Location = new System.Drawing.Point(61, 386);
                this.BtnStart.Name = "BtnStart";
                this.BtnStart.Size = new System.Drawing.Size(107, 23);
                this.BtnStart.TabIndex = 3;
                this.BtnStart.Text = "بداء البرنامج";
                this.BtnStart.UseVisualStyleBackColor = true;
                this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
                // 
                // Panel1
                // 
                this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                this.Panel1.BackColor = System.Drawing.Color.Transparent;
                this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Panel1.Controls.Add(this.LblTotal);
                this.Panel1.Controls.Add(this.Label4);
                this.Panel1.Controls.Add(this.LblNotFound);
                this.Panel1.Controls.Add(this.Lblfound);
                this.Panel1.Controls.Add(this.Label3);
                this.Panel1.Controls.Add(this.Label2);
                this.Panel1.ForeColor = System.Drawing.Color.Black;
                this.Panel1.Location = new System.Drawing.Point(178, 354);
                this.Panel1.Name = "Panel1";
                this.Panel1.Size = new System.Drawing.Size(135, 57);
                this.Panel1.TabIndex = 4;
                // 
                // LblTotal
                // 
                this.LblTotal.AutoSize = true;
                this.LblTotal.Location = new System.Drawing.Point(24, 36);
                this.LblTotal.Name = "LblTotal";
                this.LblTotal.Size = new System.Drawing.Size(13, 13);
                this.LblTotal.TabIndex = 0;
                this.LblTotal.Text = "0";
                // 
                // Label4
                // 
                this.Label4.AutoSize = true;
                this.Label4.Location = new System.Drawing.Point(81, 36);
                this.Label4.Name = "Label4";
                this.Label4.Size = new System.Drawing.Size(36, 13);
                this.Label4.TabIndex = 0;
                this.Label4.Text = "الكـــل";
                // 
                // LblNotFound
                // 
                this.LblNotFound.AutoSize = true;
                this.LblNotFound.Location = new System.Drawing.Point(24, 21);
                this.LblNotFound.Name = "LblNotFound";
                this.LblNotFound.Size = new System.Drawing.Size(13, 13);
                this.LblNotFound.TabIndex = 0;
                this.LblNotFound.Text = "0";
                // 
                // Lblfound
                // 
                this.Lblfound.AutoSize = true;
                this.Lblfound.Location = new System.Drawing.Point(24, 6);
                this.Lblfound.Name = "Lblfound";
                this.Lblfound.Size = new System.Drawing.Size(13, 13);
                this.Lblfound.TabIndex = 0;
                this.Lblfound.Text = "0";
                // 
                // Label3
                // 
                this.Label3.AutoSize = true;
                this.Label3.Location = new System.Drawing.Point(81, 21);
                this.Label3.Name = "Label3";
                this.Label3.Size = new System.Drawing.Size(33, 13);
                this.Label3.TabIndex = 0;
                this.Label3.Text = "مفقود";
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.Location = new System.Drawing.Point(81, 6);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(36, 13);
                this.Label2.TabIndex = 0;
                this.Label2.Text = "موجود";
                // 
                // Btnscan
                // 
                this.Btnscan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                this.Btnscan.Location = new System.Drawing.Point(61, 354);
                this.Btnscan.Name = "Btnscan";
                this.Btnscan.Size = new System.Drawing.Size(107, 23);
                this.Btnscan.TabIndex = 0;
                this.Btnscan.Text = "بداء الفحص";
                this.Btnscan.UseVisualStyleBackColor = true;
                this.Btnscan.Click += new System.EventHandler(this.Btnscan_Click);
                // 
                // PBData
                // 
                this.PBData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.PBData.Location = new System.Drawing.Point(12, 5);
                this.PBData.Name = "PBData";
                this.PBData.Size = new System.Drawing.Size(442, 20);
                this.PBData.TabIndex = 5;
                // 
                // Lblpercent
                // 
                this.Lblpercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                this.Lblpercent.AutoSize = true;
                this.Lblpercent.BackColor = System.Drawing.Color.Transparent;
                this.Lblpercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Lblpercent.Location = new System.Drawing.Point(457, 7);
                this.Lblpercent.Name = "Lblpercent";
                this.Lblpercent.Size = new System.Drawing.Size(19, 13);
                this.Lblpercent.TabIndex = 0;
                this.Lblpercent.Text = "00";
                // 
                // Label6
                // 
                this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                this.Label6.AutoSize = true;
                this.Label6.BackColor = System.Drawing.Color.Transparent;
                this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Label6.Location = new System.Drawing.Point(481, 7);
                this.Label6.Name = "Label6";
                this.Label6.Size = new System.Drawing.Size(15, 13);
                this.Label6.TabIndex = 0;
                this.Label6.Text = "%";
                // 
                // FilesCheckerFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.FilesCheckerFrm;
                this.ClientSize = new System.Drawing.Size(508, 417);
                this.Controls.Add(this.Label6);
                this.Controls.Add(this.Lblpercent);
                this.Controls.Add(this.PBData);
                this.Controls.Add(this.Panel1);
                this.Controls.Add(this.Btnscan);
                this.Controls.Add(this.BtnStart);
                this.Controls.Add(this.CBFilter);
                this.Controls.Add(this.Label1);
                this.Controls.Add(this.LVFolderFile);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.Name = "FilesCheckerFrm";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "فحص الملفات";
                this.TransparencyKey = System.Drawing.Color.Lime;
                this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilesCheckerFrm_FormClosing);
                this.Panel1.ResumeLayout(false);
                this.Panel1.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.ListView LVFolderFile;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox CBFilter;
		internal System.Windows.Forms.Button BtnStart;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label LblTotal;
		internal System.Windows.Forms.Label LblNotFound;
		internal System.Windows.Forms.Label Lblfound;
		internal System.Windows.Forms.Button Btnscan;
		internal System.Windows.Forms.ProgressBar PBData;
		internal System.Windows.Forms.Label Lblpercent;
		internal System.Windows.Forms.Label Label6;
	}
}
