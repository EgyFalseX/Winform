using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class OptionsFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsFrm));
                this.TC = new System.Windows.Forms.TabControl();
                this.ServerOptionTabPage = new System.Windows.Forms.TabPage();
                this.BtnClose1 = new System.Windows.Forms.Button();
                this.BtnSaveServerOptions = new System.Windows.Forms.Button();
                this.BtnBrowseEmpFiles = new System.Windows.Forms.Button();
                this.BtnBrowseStudentFiles = new System.Windows.Forms.Button();
                this.BtnBrowseDeletedFiles = new System.Windows.Forms.Button();
                this.BtnBrowseProjectPath = new System.Windows.Forms.Button();
                this.TxtEmpFilesPath = new System.Windows.Forms.TextBox();
                this.TxtStudentFilesPath = new System.Windows.Forms.TextBox();
                this.label11 = new System.Windows.Forms.Label();
                this.TxtDeletedFiles = new System.Windows.Forms.TextBox();
                this.label7 = new System.Windows.Forms.Label();
                this.TxtProjectPath = new System.Windows.Forms.TextBox();
                this.Label6 = new System.Windows.Forms.Label();
                this.TxtPassword = new System.Windows.Forms.TextBox();
                this.Label2 = new System.Windows.Forms.Label();
                this.Label1 = new System.Windows.Forms.Label();
                this.ClientOptionTabPage = new System.Windows.Forms.TabPage();
                this.BtnClose2 = new System.Windows.Forms.Button();
                this.BtnSaveClientOptions = new System.Windows.Forms.Button();
                this.TxtServerPort = new System.Windows.Forms.TextBox();
                this.TxtServerIP = new System.Windows.Forms.TextBox();
                this.Label5 = new System.Windows.Forms.Label();
                this.Label4 = new System.Windows.Forms.Label();
                this.StudentTabPage = new System.Windows.Forms.TabPage();
                this.BtnSyncData = new System.Windows.Forms.Button();
                this.PB = new System.Windows.Forms.ProgressBar();
                this.txtStuFileCount = new System.Windows.Forms.TextBox();
                this.label9 = new System.Windows.Forms.Label();
                this.TxtStuCount = new System.Windows.Forms.TextBox();
                this.label8 = new System.Windows.Forms.Label();
                this.EmpTabPage = new System.Windows.Forms.TabPage();
                this.PBEmp = new System.Windows.Forms.ProgressBar();
                this.BtnEmpSyncData = new System.Windows.Forms.Button();
                this.txtEmpFileCount = new System.Windows.Forms.TextBox();
                this.label3 = new System.Windows.Forms.Label();
                this.TxtEmpCount = new System.Windows.Forms.TextBox();
                this.label10 = new System.Windows.Forms.Label();
                this.TC.SuspendLayout();
                this.ServerOptionTabPage.SuspendLayout();
                this.ClientOptionTabPage.SuspendLayout();
                this.StudentTabPage.SuspendLayout();
                this.EmpTabPage.SuspendLayout();
                this.SuspendLayout();
                // 
                // TC
                // 
                this.TC.Controls.Add(this.ServerOptionTabPage);
                this.TC.Controls.Add(this.ClientOptionTabPage);
                this.TC.Controls.Add(this.StudentTabPage);
                this.TC.Controls.Add(this.EmpTabPage);
                this.TC.Location = new System.Drawing.Point(12, 12);
                this.TC.Name = "TC";
                this.TC.SelectedIndex = 0;
                this.TC.Size = new System.Drawing.Size(444, 231);
                this.TC.TabIndex = 0;
                this.TC.Selected += new System.Windows.Forms.TabControlEventHandler(this.TC_Selected);
                // 
                // ServerOptionTabPage
                // 
                this.ServerOptionTabPage.Controls.Add(this.BtnClose1);
                this.ServerOptionTabPage.Controls.Add(this.BtnSaveServerOptions);
                this.ServerOptionTabPage.Controls.Add(this.BtnBrowseEmpFiles);
                this.ServerOptionTabPage.Controls.Add(this.BtnBrowseStudentFiles);
                this.ServerOptionTabPage.Controls.Add(this.BtnBrowseDeletedFiles);
                this.ServerOptionTabPage.Controls.Add(this.BtnBrowseProjectPath);
                this.ServerOptionTabPage.Controls.Add(this.TxtEmpFilesPath);
                this.ServerOptionTabPage.Controls.Add(this.TxtStudentFilesPath);
                this.ServerOptionTabPage.Controls.Add(this.label11);
                this.ServerOptionTabPage.Controls.Add(this.TxtDeletedFiles);
                this.ServerOptionTabPage.Controls.Add(this.label7);
                this.ServerOptionTabPage.Controls.Add(this.TxtProjectPath);
                this.ServerOptionTabPage.Controls.Add(this.Label6);
                this.ServerOptionTabPage.Controls.Add(this.TxtPassword);
                this.ServerOptionTabPage.Controls.Add(this.Label2);
                this.ServerOptionTabPage.Controls.Add(this.Label1);
                this.ServerOptionTabPage.Location = new System.Drawing.Point(4, 22);
                this.ServerOptionTabPage.Name = "ServerOptionTabPage";
                this.ServerOptionTabPage.Padding = new System.Windows.Forms.Padding(3);
                this.ServerOptionTabPage.Size = new System.Drawing.Size(436, 205);
                this.ServerOptionTabPage.TabIndex = 0;
                this.ServerOptionTabPage.Text = "خيارات الخادم";
                this.ServerOptionTabPage.UseVisualStyleBackColor = true;
                // 
                // BtnClose1
                // 
                this.BtnClose1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose1.Location = new System.Drawing.Point(276, 150);
                this.BtnClose1.Name = "BtnClose1";
                this.BtnClose1.Size = new System.Drawing.Size(53, 23);
                this.BtnClose1.TabIndex = 6;
                this.BtnClose1.Text = "اغلاق";
                this.BtnClose1.UseVisualStyleBackColor = true;
                this.BtnClose1.Click += new System.EventHandler(this.BtnClose_Click);
                // 
                // BtnSaveServerOptions
                // 
                this.BtnSaveServerOptions.Enabled = false;
                this.BtnSaveServerOptions.Location = new System.Drawing.Point(136, 150);
                this.BtnSaveServerOptions.Name = "BtnSaveServerOptions";
                this.BtnSaveServerOptions.Size = new System.Drawing.Size(134, 23);
                this.BtnSaveServerOptions.TabIndex = 5;
                this.BtnSaveServerOptions.Text = "حفظ";
                this.BtnSaveServerOptions.UseVisualStyleBackColor = true;
                this.BtnSaveServerOptions.Click += new System.EventHandler(this.BtnSave_Click);
                // 
                // BtnBrowseEmpFiles
                // 
                this.BtnBrowseEmpFiles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnBrowseEmpFiles.Location = new System.Drawing.Point(68, 122);
                this.BtnBrowseEmpFiles.Name = "BtnBrowseEmpFiles";
                this.BtnBrowseEmpFiles.Size = new System.Drawing.Size(62, 23);
                this.BtnBrowseEmpFiles.TabIndex = 4;
                this.BtnBrowseEmpFiles.Text = "...";
                this.BtnBrowseEmpFiles.UseVisualStyleBackColor = true;
                this.BtnBrowseEmpFiles.Click += new System.EventHandler(this.BtnBrowseEmpFiles_Click);
                // 
                // BtnBrowseStudentFiles
                // 
                this.BtnBrowseStudentFiles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnBrowseStudentFiles.Location = new System.Drawing.Point(68, 96);
                this.BtnBrowseStudentFiles.Name = "BtnBrowseStudentFiles";
                this.BtnBrowseStudentFiles.Size = new System.Drawing.Size(62, 23);
                this.BtnBrowseStudentFiles.TabIndex = 4;
                this.BtnBrowseStudentFiles.Text = "...";
                this.BtnBrowseStudentFiles.UseVisualStyleBackColor = true;
                this.BtnBrowseStudentFiles.Click += new System.EventHandler(this.BtnBrowseStudentFiles_Click);
                // 
                // BtnBrowseDeletedFiles
                // 
                this.BtnBrowseDeletedFiles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnBrowseDeletedFiles.Location = new System.Drawing.Point(68, 70);
                this.BtnBrowseDeletedFiles.Name = "BtnBrowseDeletedFiles";
                this.BtnBrowseDeletedFiles.Size = new System.Drawing.Size(62, 23);
                this.BtnBrowseDeletedFiles.TabIndex = 4;
                this.BtnBrowseDeletedFiles.Text = "...";
                this.BtnBrowseDeletedFiles.UseVisualStyleBackColor = true;
                this.BtnBrowseDeletedFiles.Click += new System.EventHandler(this.BtnBrowseDeletedFiles_Click);
                // 
                // BtnBrowseProjectPath
                // 
                this.BtnBrowseProjectPath.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnBrowseProjectPath.Location = new System.Drawing.Point(68, 44);
                this.BtnBrowseProjectPath.Name = "BtnBrowseProjectPath";
                this.BtnBrowseProjectPath.Size = new System.Drawing.Size(62, 23);
                this.BtnBrowseProjectPath.TabIndex = 2;
                this.BtnBrowseProjectPath.Text = "...";
                this.BtnBrowseProjectPath.UseVisualStyleBackColor = true;
                this.BtnBrowseProjectPath.Click += new System.EventHandler(this.BtnBrowseProjectPath_Click);
                // 
                // TxtEmpFilesPath
                // 
                this.TxtEmpFilesPath.Location = new System.Drawing.Point(136, 124);
                this.TxtEmpFilesPath.Name = "TxtEmpFilesPath";
                this.TxtEmpFilesPath.ReadOnly = true;
                this.TxtEmpFilesPath.Size = new System.Drawing.Size(134, 20);
                this.TxtEmpFilesPath.TabIndex = 19;
                this.TxtEmpFilesPath.TabStop = false;
                this.TxtEmpFilesPath.TextChanged += new System.EventHandler(this.TxtServerOptions_TextChanged);
                // 
                // TxtStudentFilesPath
                // 
                this.TxtStudentFilesPath.Location = new System.Drawing.Point(136, 98);
                this.TxtStudentFilesPath.Name = "TxtStudentFilesPath";
                this.TxtStudentFilesPath.ReadOnly = true;
                this.TxtStudentFilesPath.Size = new System.Drawing.Size(134, 20);
                this.TxtStudentFilesPath.TabIndex = 19;
                this.TxtStudentFilesPath.TabStop = false;
                this.TxtStudentFilesPath.TextChanged += new System.EventHandler(this.TxtServerOptions_TextChanged);
                // 
                // label11
                // 
                this.label11.AutoSize = true;
                this.label11.Location = new System.Drawing.Point(287, 127);
                this.label11.Name = "label11";
                this.label11.Size = new System.Drawing.Size(96, 13);
                this.label11.TabIndex = 11;
                this.label11.Text = "مسار ملفات العاملين";
                this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                // 
                // TxtDeletedFiles
                // 
                this.TxtDeletedFiles.Location = new System.Drawing.Point(136, 72);
                this.TxtDeletedFiles.Name = "TxtDeletedFiles";
                this.TxtDeletedFiles.ReadOnly = true;
                this.TxtDeletedFiles.Size = new System.Drawing.Size(134, 20);
                this.TxtDeletedFiles.TabIndex = 19;
                this.TxtDeletedFiles.TabStop = false;
                this.TxtDeletedFiles.TextChanged += new System.EventHandler(this.TxtServerOptions_TextChanged);
                // 
                // label7
                // 
                this.label7.AutoSize = true;
                this.label7.Location = new System.Drawing.Point(294, 101);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(89, 13);
                this.label7.TabIndex = 11;
                this.label7.Text = "مسار ملفات الطلاب";
                this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                // 
                // TxtProjectPath
                // 
                this.TxtProjectPath.Location = new System.Drawing.Point(136, 46);
                this.TxtProjectPath.Name = "TxtProjectPath";
                this.TxtProjectPath.ReadOnly = true;
                this.TxtProjectPath.Size = new System.Drawing.Size(134, 20);
                this.TxtProjectPath.TabIndex = 20;
                this.TxtProjectPath.TabStop = false;
                this.TxtProjectPath.TextChanged += new System.EventHandler(this.TxtServerOptions_TextChanged);
                // 
                // Label6
                // 
                this.Label6.AutoSize = true;
                this.Label6.Location = new System.Drawing.Point(276, 75);
                this.Label6.Name = "Label6";
                this.Label6.Size = new System.Drawing.Size(107, 13);
                this.Label6.TabIndex = 11;
                this.Label6.Text = "مسار الملفات المحزوفه";
                this.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                // 
                // TxtPassword
                // 
                this.TxtPassword.Location = new System.Drawing.Point(136, 16);
                this.TxtPassword.Name = "TxtPassword";
                this.TxtPassword.Size = new System.Drawing.Size(134, 20);
                this.TxtPassword.TabIndex = 1;
                this.TxtPassword.TextChanged += new System.EventHandler(this.TxtServerOptions_TextChanged);
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.Location = new System.Drawing.Point(319, 49);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(64, 13);
                this.Label2.TabIndex = 14;
                this.Label2.Text = "مسار الملفات";
                // 
                // Label1
                // 
                this.Label1.AutoSize = true;
                this.Label1.Location = new System.Drawing.Point(285, 19);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(98, 13);
                this.Label1.TabIndex = 13;
                this.Label1.Text = "كلمة السر الافتراضيه";
                // 
                // ClientOptionTabPage
                // 
                this.ClientOptionTabPage.Controls.Add(this.BtnClose2);
                this.ClientOptionTabPage.Controls.Add(this.BtnSaveClientOptions);
                this.ClientOptionTabPage.Controls.Add(this.TxtServerPort);
                this.ClientOptionTabPage.Controls.Add(this.TxtServerIP);
                this.ClientOptionTabPage.Controls.Add(this.Label5);
                this.ClientOptionTabPage.Controls.Add(this.Label4);
                this.ClientOptionTabPage.Location = new System.Drawing.Point(4, 22);
                this.ClientOptionTabPage.Name = "ClientOptionTabPage";
                this.ClientOptionTabPage.Padding = new System.Windows.Forms.Padding(3);
                this.ClientOptionTabPage.Size = new System.Drawing.Size(436, 205);
                this.ClientOptionTabPage.TabIndex = 1;
                this.ClientOptionTabPage.Text = "خيارات الاجهزه المخدومه";
                this.ClientOptionTabPage.UseVisualStyleBackColor = true;
                // 
                // BtnClose2
                // 
                this.BtnClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose2.Location = new System.Drawing.Point(281, 89);
                this.BtnClose2.Name = "BtnClose2";
                this.BtnClose2.Size = new System.Drawing.Size(53, 23);
                this.BtnClose2.TabIndex = 4;
                this.BtnClose2.Text = "اغلاق";
                this.BtnClose2.UseVisualStyleBackColor = true;
                this.BtnClose2.Click += new System.EventHandler(this.BtnClose_Click);
                // 
                // BtnSaveClientOptions
                // 
                this.BtnSaveClientOptions.Enabled = false;
                this.BtnSaveClientOptions.Location = new System.Drawing.Point(109, 89);
                this.BtnSaveClientOptions.Name = "BtnSaveClientOptions";
                this.BtnSaveClientOptions.Size = new System.Drawing.Size(134, 23);
                this.BtnSaveClientOptions.TabIndex = 3;
                this.BtnSaveClientOptions.Text = "حفظ";
                this.BtnSaveClientOptions.UseVisualStyleBackColor = true;
                this.BtnSaveClientOptions.Click += new System.EventHandler(this.BtnSaveClientOptions_Click);
                // 
                // TxtServerPort
                // 
                this.TxtServerPort.Location = new System.Drawing.Point(109, 63);
                this.TxtServerPort.MaxLength = 8;
                this.TxtServerPort.Name = "TxtServerPort";
                this.TxtServerPort.Size = new System.Drawing.Size(134, 20);
                this.TxtServerPort.TabIndex = 2;
                this.TxtServerPort.TextChanged += new System.EventHandler(this.TxtClientOptions_TextChanged);
                // 
                // TxtServerIP
                // 
                this.TxtServerIP.Location = new System.Drawing.Point(109, 37);
                this.TxtServerIP.MaxLength = 15;
                this.TxtServerIP.Name = "TxtServerIP";
                this.TxtServerIP.Size = new System.Drawing.Size(134, 20);
                this.TxtServerIP.TabIndex = 1;
                this.TxtServerIP.TextChanged += new System.EventHandler(this.TxtClientOptions_TextChanged);
                // 
                // Label5
                // 
                this.Label5.AutoSize = true;
                this.Label5.Location = new System.Drawing.Point(249, 66);
                this.Label5.Name = "Label5";
                this.Label5.Size = new System.Drawing.Size(85, 13);
                this.Label5.TabIndex = 15;
                this.Label5.Text = "رقم مسار الاتصال";
                // 
                // Label4
                // 
                this.Label4.AutoSize = true;
                this.Label4.Location = new System.Drawing.Point(287, 37);
                this.Label4.Name = "Label4";
                this.Label4.Size = new System.Drawing.Size(47, 13);
                this.Label4.TabIndex = 15;
                this.Label4.Text = "IP الخادم";
                // 
                // StudentTabPage
                // 
                this.StudentTabPage.Controls.Add(this.BtnSyncData);
                this.StudentTabPage.Controls.Add(this.PB);
                this.StudentTabPage.Controls.Add(this.txtStuFileCount);
                this.StudentTabPage.Controls.Add(this.label9);
                this.StudentTabPage.Controls.Add(this.TxtStuCount);
                this.StudentTabPage.Controls.Add(this.label8);
                this.StudentTabPage.Location = new System.Drawing.Point(4, 22);
                this.StudentTabPage.Name = "StudentTabPage";
                this.StudentTabPage.Padding = new System.Windows.Forms.Padding(3);
                this.StudentTabPage.Size = new System.Drawing.Size(436, 205);
                this.StudentTabPage.TabIndex = 2;
                this.StudentTabPage.Text = "قاعدة بيانات الطلاب";
                this.StudentTabPage.UseVisualStyleBackColor = true;
                // 
                // BtnSyncData
                // 
                this.BtnSyncData.Location = new System.Drawing.Point(159, 117);
                this.BtnSyncData.Name = "BtnSyncData";
                this.BtnSyncData.Size = new System.Drawing.Size(111, 23);
                this.BtnSyncData.TabIndex = 3;
                this.BtnSyncData.Text = "تحديث البيانات";
                this.BtnSyncData.UseVisualStyleBackColor = true;
                this.BtnSyncData.Click += new System.EventHandler(this.BtnSyncData_Click);
                // 
                // PB
                // 
                this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.PB.Location = new System.Drawing.Point(3, 186);
                this.PB.Name = "PB";
                this.PB.Size = new System.Drawing.Size(430, 16);
                this.PB.Step = 1;
                this.PB.TabIndex = 2;
                // 
                // txtStuFileCount
                // 
                this.txtStuFileCount.Location = new System.Drawing.Point(159, 91);
                this.txtStuFileCount.Name = "txtStuFileCount";
                this.txtStuFileCount.ReadOnly = true;
                this.txtStuFileCount.Size = new System.Drawing.Size(50, 20);
                this.txtStuFileCount.TabIndex = 1;
                this.txtStuFileCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // label9
                // 
                this.label9.AutoSize = true;
                this.label9.Location = new System.Drawing.Point(215, 94);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(58, 13);
                this.label9.TabIndex = 0;
                this.label9.Text = "عدد الملفات";
                // 
                // TxtStuCount
                // 
                this.TxtStuCount.Location = new System.Drawing.Point(159, 65);
                this.TxtStuCount.Name = "TxtStuCount";
                this.TxtStuCount.ReadOnly = true;
                this.TxtStuCount.Size = new System.Drawing.Size(50, 20);
                this.TxtStuCount.TabIndex = 1;
                this.TxtStuCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // label8
                // 
                this.label8.AutoSize = true;
                this.label8.Location = new System.Drawing.Point(215, 68);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(55, 13);
                this.label8.TabIndex = 0;
                this.label8.Text = "عدد الطلاب";
                // 
                // EmpTabPage
                // 
                this.EmpTabPage.Controls.Add(this.PBEmp);
                this.EmpTabPage.Controls.Add(this.BtnEmpSyncData);
                this.EmpTabPage.Controls.Add(this.txtEmpFileCount);
                this.EmpTabPage.Controls.Add(this.label3);
                this.EmpTabPage.Controls.Add(this.TxtEmpCount);
                this.EmpTabPage.Controls.Add(this.label10);
                this.EmpTabPage.Location = new System.Drawing.Point(4, 22);
                this.EmpTabPage.Name = "EmpTabPage";
                this.EmpTabPage.Padding = new System.Windows.Forms.Padding(3);
                this.EmpTabPage.Size = new System.Drawing.Size(436, 205);
                this.EmpTabPage.TabIndex = 3;
                this.EmpTabPage.Text = "قاعدة بيانات العاملين";
                this.EmpTabPage.UseVisualStyleBackColor = true;
                // 
                // PBEmp
                // 
                this.PBEmp.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.PBEmp.Location = new System.Drawing.Point(3, 186);
                this.PBEmp.Name = "PBEmp";
                this.PBEmp.Size = new System.Drawing.Size(430, 16);
                this.PBEmp.Step = 1;
                this.PBEmp.TabIndex = 9;
                // 
                // BtnEmpSyncData
                // 
                this.BtnEmpSyncData.Location = new System.Drawing.Point(161, 117);
                this.BtnEmpSyncData.Name = "BtnEmpSyncData";
                this.BtnEmpSyncData.Size = new System.Drawing.Size(111, 23);
                this.BtnEmpSyncData.TabIndex = 8;
                this.BtnEmpSyncData.Text = "تحديث البيانات";
                this.BtnEmpSyncData.UseVisualStyleBackColor = true;
                this.BtnEmpSyncData.Click += new System.EventHandler(this.BtnEmpSyncData_Click);
                // 
                // txtEmpFileCount
                // 
                this.txtEmpFileCount.Location = new System.Drawing.Point(161, 91);
                this.txtEmpFileCount.Name = "txtEmpFileCount";
                this.txtEmpFileCount.ReadOnly = true;
                this.txtEmpFileCount.Size = new System.Drawing.Size(50, 20);
                this.txtEmpFileCount.TabIndex = 7;
                this.txtEmpFileCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(217, 94);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(58, 13);
                this.label3.TabIndex = 5;
                this.label3.Text = "عدد الملفات";
                // 
                // TxtEmpCount
                // 
                this.TxtEmpCount.Location = new System.Drawing.Point(161, 65);
                this.TxtEmpCount.Name = "TxtEmpCount";
                this.TxtEmpCount.ReadOnly = true;
                this.TxtEmpCount.Size = new System.Drawing.Size(50, 20);
                this.TxtEmpCount.TabIndex = 6;
                this.TxtEmpCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // label10
                // 
                this.label10.AutoSize = true;
                this.label10.Location = new System.Drawing.Point(217, 68);
                this.label10.Name = "label10";
                this.label10.Size = new System.Drawing.Size(62, 13);
                this.label10.TabIndex = 4;
                this.label10.Text = "عدد العاملين";
                // 
                // OptionsFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.OptionsFrm;
                this.ClientSize = new System.Drawing.Size(468, 255);
                this.Controls.Add(this.TC);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "OptionsFrm";
                this.ShowIcon = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "خيارات";
                this.Load += new System.EventHandler(this.OptionsFrm_Load);
                this.TC.ResumeLayout(false);
                this.ServerOptionTabPage.ResumeLayout(false);
                this.ServerOptionTabPage.PerformLayout();
                this.ClientOptionTabPage.ResumeLayout(false);
                this.ClientOptionTabPage.PerformLayout();
                this.StudentTabPage.ResumeLayout(false);
                this.StudentTabPage.PerformLayout();
                this.EmpTabPage.ResumeLayout(false);
                this.EmpTabPage.PerformLayout();
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TC;
		internal System.Windows.Forms.TabPage ServerOptionTabPage;
		internal System.Windows.Forms.Button BtnClose1;
        internal System.Windows.Forms.Button BtnSaveServerOptions;
        internal System.Windows.Forms.Button BtnBrowseProjectPath;
		internal System.Windows.Forms.TextBox TxtProjectPath;
        internal System.Windows.Forms.TextBox TxtPassword;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TabPage ClientOptionTabPage;
		internal System.Windows.Forms.TextBox TxtServerPort;
		internal System.Windows.Forms.TextBox TxtServerIP;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button BtnClose2;
		internal System.Windows.Forms.Button BtnSaveClientOptions;
		internal System.Windows.Forms.Button BtnBrowseDeletedFiles;
		internal System.Windows.Forms.TextBox TxtDeletedFiles;
        internal System.Windows.Forms.Label Label6;
        internal Button BtnBrowseStudentFiles;
        internal TextBox TxtStudentFilesPath;
        internal Label label7;
        private TabPage StudentTabPage;
        private TextBox txtStuFileCount;
        private Label label9;
        private TextBox TxtStuCount;
        private Label label8;
        private Button BtnSyncData;
        private ProgressBar PB;
        private TabPage EmpTabPage;
        private Button BtnEmpSyncData;
        private TextBox txtEmpFileCount;
        private Label label3;
        private TextBox TxtEmpCount;
        private Label label10;
        private ProgressBar PBEmp;
        internal Button BtnBrowseEmpFiles;
        internal TextBox TxtEmpFilesPath;
        internal Label label11;
	}
	
}
