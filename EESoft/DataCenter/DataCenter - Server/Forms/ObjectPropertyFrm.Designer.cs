using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class ObjectPropertyFrm : System.Windows.Forms.Form
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectPropertyFrm));
                this.BtnCancel = new System.Windows.Forms.Button();
                this.BtnSavePriv = new System.Windows.Forms.Button();
                this.FoldersFilesTabControl = new System.Windows.Forms.TabControl();
                this.FoldersTabPage = new System.Windows.Forms.TabPage();
                this.BtnEditFolderName = new System.Windows.Forms.Button();
                this.BtnSaveFolder = new System.Windows.Forms.Button();
                this.LblFolderUser = new System.Windows.Forms.Label();
                this.LblFolderDate = new System.Windows.Forms.Label();
                this.LblFolderPath = new System.Windows.Forms.Label();
                this.Label10 = new System.Windows.Forms.Label();
                this.Label6 = new System.Windows.Forms.Label();
                this.Label4 = new System.Windows.Forms.Label();
                this.Label2 = new System.Windows.Forms.Label();
                this.Label1 = new System.Windows.Forms.Label();
                this.TxtFolderDisc = new System.Windows.Forms.TextBox();
                this.TxtFolderName = new System.Windows.Forms.TextBox();
                this.FilesTabPage = new System.Windows.Forms.TabPage();
                this.Label25 = new System.Windows.Forms.Label();
                this.LblFileType = new System.Windows.Forms.Label();
                this.BtnEditFileName = new System.Windows.Forms.Button();
                this.LblProject = new System.Windows.Forms.Label();
                this.LblUser = new System.Windows.Forms.Label();
                this.BtnSaveFile = new System.Windows.Forms.Button();
                this.LblDate = new System.Windows.Forms.Label();
                this.LblFilePath = new System.Windows.Forms.Label();
                this.Label15 = new System.Windows.Forms.Label();
                this.Label16 = new System.Windows.Forms.Label();
                this.Label17 = new System.Windows.Forms.Label();
                this.Label18 = new System.Windows.Forms.Label();
                this.Label19 = new System.Windows.Forms.Label();
                this.Label20 = new System.Windows.Forms.Label();
                this.TxtDisc = new System.Windows.Forms.TextBox();
                this.TxtFileName = new System.Windows.Forms.TextBox();
                this.FoldersprivilegesTabPage = new System.Windows.Forms.TabPage();
                this.tabControl1 = new System.Windows.Forms.TabControl();
                this.tabPage1 = new System.Windows.Forms.TabPage();
                this.GroupBoxPrivilagesTab = new System.Windows.Forms.GroupBox();
                this.CBView = new System.Windows.Forms.CheckBox();
                this.CBDelete = new System.Windows.Forms.CheckBox();
                this.CBAdd = new System.Windows.Forms.CheckBox();
                this.CBWrite = new System.Windows.Forms.CheckBox();
                this.Label5 = new System.Windows.Forms.Label();
                this.Label3 = new System.Windows.Forms.Label();
                this.BtnBtnRemoveAll = new System.Windows.Forms.Button();
                this.BtnRemoveSelected = new System.Windows.Forms.Button();
                this.BtnAddSelected = new System.Windows.Forms.Button();
                this.BtnAddAll = new System.Windows.Forms.Button();
                this.LBSelectedprivileges = new System.Windows.Forms.ListBox();
                this.LBAllprivileges = new System.Windows.Forms.ListBox();
                this.tabPage2 = new System.Windows.Forms.TabPage();
                this.groupBox1 = new System.Windows.Forms.GroupBox();
                this.CBDeleteUser = new System.Windows.Forms.CheckBox();
                this.CBViewUser = new System.Windows.Forms.CheckBox();
                this.CBWriteUser = new System.Windows.Forms.CheckBox();
                this.CBAddUser = new System.Windows.Forms.CheckBox();
                this.label7 = new System.Windows.Forms.Label();
                this.label8 = new System.Windows.Forms.Label();
                this.BtnSaveUser = new System.Windows.Forms.Button();
                this.BtnBtnRemoveAllUser = new System.Windows.Forms.Button();
                this.BtnRemoveSelectedUser = new System.Windows.Forms.Button();
                this.BtnAddSelectedUser = new System.Windows.Forms.Button();
                this.BtnAddAllUsers = new System.Windows.Forms.Button();
                this.LBSelectedUsers = new System.Windows.Forms.ListBox();
                this.LBAllUsers = new System.Windows.Forms.ListBox();
                this.NewFileTabPage = new System.Windows.Forms.TabPage();
                this.NewFileProgressBar = new System.Windows.Forms.ProgressBar();
                this.TxtNewFileName = new System.Windows.Forms.TextBox();
                this.FileTypeCB = new System.Windows.Forms.ComboBox();
                this.BtnBrowseNewFile = new System.Windows.Forms.Button();
                this.Label9 = new System.Windows.Forms.Label();
                this.BtnSaveNewFile = new System.Windows.Forms.Button();
                this.LblNewFileDate = new System.Windows.Forms.Label();
                this.LblNewFilePath = new System.Windows.Forms.Label();
                this.Label26 = new System.Windows.Forms.Label();
                this.Label13 = new System.Windows.Forms.Label();
                this.Label12 = new System.Windows.Forms.Label();
                this.Label21 = new System.Windows.Forms.Label();
                this.Label22 = new System.Windows.Forms.Label();
                this.Label23 = new System.Windows.Forms.Label();
                this.Label24 = new System.Windows.Forms.Label();
                this.TxtNewFileDesc = new System.Windows.Forms.TextBox();
                this.NewFolderTabPage = new System.Windows.Forms.TabPage();
                this.BtnNewFolderSave = new System.Windows.Forms.Button();
                this.LblNewFolderOwner = new System.Windows.Forms.Label();
                this.LblNewFolderDate = new System.Windows.Forms.Label();
                this.LblNewFolderPath = new System.Windows.Forms.Label();
                this.Label29 = new System.Windows.Forms.Label();
                this.Label31 = new System.Windows.Forms.Label();
                this.Label32 = new System.Windows.Forms.Label();
                this.Label34 = new System.Windows.Forms.Label();
                this.Label33 = new System.Windows.Forms.Label();
                this.TxtNewFolderDesc = new System.Windows.Forms.TextBox();
                this.TxtNewFolderName = new System.Windows.Forms.TextBox();
                this.FoldersFilesTabControl.SuspendLayout();
                this.FoldersTabPage.SuspendLayout();
                this.FilesTabPage.SuspendLayout();
                this.FoldersprivilegesTabPage.SuspendLayout();
                this.tabControl1.SuspendLayout();
                this.tabPage1.SuspendLayout();
                this.GroupBoxPrivilagesTab.SuspendLayout();
                this.tabPage2.SuspendLayout();
                this.groupBox1.SuspendLayout();
                this.NewFileTabPage.SuspendLayout();
                this.NewFolderTabPage.SuspendLayout();
                this.SuspendLayout();
                // 
                // BtnCancel
                // 
                this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnCancel.Location = new System.Drawing.Point(219, 323);
                this.BtnCancel.Name = "BtnCancel";
                this.BtnCancel.Size = new System.Drawing.Size(99, 23);
                this.BtnCancel.TabIndex = 999;
                this.BtnCancel.Text = "اغلاق";
                this.BtnCancel.UseVisualStyleBackColor = true;
                this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
                // 
                // BtnSavePriv
                // 
                this.BtnSavePriv.Location = new System.Drawing.Point(196, 209);
                this.BtnSavePriv.Name = "BtnSavePriv";
                this.BtnSavePriv.Size = new System.Drawing.Size(99, 23);
                this.BtnSavePriv.TabIndex = 9;
                this.BtnSavePriv.Text = "حفـــــظ";
                this.BtnSavePriv.UseVisualStyleBackColor = true;
                this.BtnSavePriv.Click += new System.EventHandler(this.BtnSavePriv_Click);
                // 
                // FoldersFilesTabControl
                // 
                this.FoldersFilesTabControl.Controls.Add(this.FoldersTabPage);
                this.FoldersFilesTabControl.Controls.Add(this.FilesTabPage);
                this.FoldersFilesTabControl.Controls.Add(this.FoldersprivilegesTabPage);
                this.FoldersFilesTabControl.Controls.Add(this.NewFileTabPage);
                this.FoldersFilesTabControl.Controls.Add(this.NewFolderTabPage);
                this.FoldersFilesTabControl.Location = new System.Drawing.Point(5, 6);
                this.FoldersFilesTabControl.Name = "FoldersFilesTabControl";
                this.FoldersFilesTabControl.SelectedIndex = 0;
                this.FoldersFilesTabControl.Size = new System.Drawing.Size(327, 311);
                this.FoldersFilesTabControl.TabIndex = 0;
                // 
                // FoldersTabPage
                // 
                this.FoldersTabPage.BackColor = System.Drawing.Color.Transparent;
                this.FoldersTabPage.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
                this.FoldersTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.FoldersTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.FoldersTabPage.Controls.Add(this.BtnEditFolderName);
                this.FoldersTabPage.Controls.Add(this.BtnSaveFolder);
                this.FoldersTabPage.Controls.Add(this.LblFolderUser);
                this.FoldersTabPage.Controls.Add(this.LblFolderDate);
                this.FoldersTabPage.Controls.Add(this.LblFolderPath);
                this.FoldersTabPage.Controls.Add(this.Label10);
                this.FoldersTabPage.Controls.Add(this.Label6);
                this.FoldersTabPage.Controls.Add(this.Label4);
                this.FoldersTabPage.Controls.Add(this.Label2);
                this.FoldersTabPage.Controls.Add(this.Label1);
                this.FoldersTabPage.Controls.Add(this.TxtFolderDisc);
                this.FoldersTabPage.Controls.Add(this.TxtFolderName);
                this.FoldersTabPage.ForeColor = System.Drawing.Color.Black;
                this.FoldersTabPage.Location = new System.Drawing.Point(4, 22);
                this.FoldersTabPage.Name = "FoldersTabPage";
                this.FoldersTabPage.Padding = new System.Windows.Forms.Padding(3);
                this.FoldersTabPage.Size = new System.Drawing.Size(319, 285);
                this.FoldersTabPage.TabIndex = 0;
                this.FoldersTabPage.Text = "المجلادات";
                this.FoldersTabPage.UseVisualStyleBackColor = true;
                // 
                // BtnEditFolderName
                // 
                this.BtnEditFolderName.Location = new System.Drawing.Point(24, 9);
                this.BtnEditFolderName.Name = "BtnEditFolderName";
                this.BtnEditFolderName.Size = new System.Drawing.Size(56, 23);
                this.BtnEditFolderName.TabIndex = 2;
                this.BtnEditFolderName.Text = "تعديل";
                this.BtnEditFolderName.UseVisualStyleBackColor = true;
                this.BtnEditFolderName.Click += new System.EventHandler(this.BtnEditFolderName_Click);
                // 
                // BtnSaveFolder
                // 
                this.BtnSaveFolder.Location = new System.Drawing.Point(210, 251);
                this.BtnSaveFolder.Name = "BtnSaveFolder";
                this.BtnSaveFolder.Size = new System.Drawing.Size(99, 23);
                this.BtnSaveFolder.TabIndex = 4;
                this.BtnSaveFolder.Text = "حفـــــظ";
                this.BtnSaveFolder.UseVisualStyleBackColor = true;
                this.BtnSaveFolder.Click += new System.EventHandler(this.BtnSaveFolder_Click);
                // 
                // LblFolderUser
                // 
                this.LblFolderUser.AutoSize = true;
                this.LblFolderUser.BackColor = System.Drawing.Color.Transparent;
                this.LblFolderUser.ForeColor = System.Drawing.Color.Black;
                this.LblFolderUser.Location = new System.Drawing.Point(83, 92);
                this.LblFolderUser.Name = "LblFolderUser";
                this.LblFolderUser.Size = new System.Drawing.Size(47, 13);
                this.LblFolderUser.TabIndex = 1;
                this.LblFolderUser.Text = "Unkown";
                // 
                // LblFolderDate
                // 
                this.LblFolderDate.AutoSize = true;
                this.LblFolderDate.BackColor = System.Drawing.Color.Transparent;
                this.LblFolderDate.ForeColor = System.Drawing.Color.Black;
                this.LblFolderDate.Location = new System.Drawing.Point(83, 66);
                this.LblFolderDate.Name = "LblFolderDate";
                this.LblFolderDate.Size = new System.Drawing.Size(53, 13);
                this.LblFolderDate.TabIndex = 1;
                this.LblFolderDate.Text = "1/1/2000";
                // 
                // LblFolderPath
                // 
                this.LblFolderPath.AutoSize = true;
                this.LblFolderPath.BackColor = System.Drawing.Color.Transparent;
                this.LblFolderPath.ForeColor = System.Drawing.Color.Black;
                this.LblFolderPath.Location = new System.Drawing.Point(83, 40);
                this.LblFolderPath.Name = "LblFolderPath";
                this.LblFolderPath.Size = new System.Drawing.Size(21, 13);
                this.LblFolderPath.TabIndex = 1;
                this.LblFolderPath.Text = "c:\\";
                // 
                // Label10
                // 
                this.Label10.AutoSize = true;
                this.Label10.BackColor = System.Drawing.Color.Transparent;
                this.Label10.ForeColor = System.Drawing.Color.Black;
                this.Label10.Location = new System.Drawing.Point(270, 141);
                this.Label10.Name = "Label10";
                this.Label10.Size = new System.Drawing.Size(37, 13);
                this.Label10.TabIndex = 1;
                this.Label10.Text = "الوصف";
                // 
                // Label6
                // 
                this.Label6.AutoSize = true;
                this.Label6.BackColor = System.Drawing.Color.Transparent;
                this.Label6.ForeColor = System.Drawing.Color.Black;
                this.Label6.Location = new System.Drawing.Point(239, 92);
                this.Label6.Name = "Label6";
                this.Label6.Size = new System.Drawing.Size(68, 13);
                this.Label6.TabIndex = 1;
                this.Label6.Text = "اسم المستخدم";
                // 
                // Label4
                // 
                this.Label4.AutoSize = true;
                this.Label4.BackColor = System.Drawing.Color.Transparent;
                this.Label4.ForeColor = System.Drawing.Color.Black;
                this.Label4.Location = new System.Drawing.Point(271, 66);
                this.Label4.Name = "Label4";
                this.Label4.Size = new System.Drawing.Size(38, 13);
                this.Label4.TabIndex = 1;
                this.Label4.Text = "التاريخ";
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.BackColor = System.Drawing.Color.Transparent;
                this.Label2.ForeColor = System.Drawing.Color.Black;
                this.Label2.Location = new System.Drawing.Point(271, 40);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(36, 13);
                this.Label2.TabIndex = 1;
                this.Label2.Text = "المسار";
                // 
                // Label1
                // 
                this.Label1.AutoSize = true;
                this.Label1.BackColor = System.Drawing.Color.Transparent;
                this.Label1.ForeColor = System.Drawing.Color.Black;
                this.Label1.Location = new System.Drawing.Point(254, 14);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(53, 13);
                this.Label1.TabIndex = 1;
                this.Label1.Text = "اسم المجلد";
                // 
                // TxtFolderDisc
                // 
                this.TxtFolderDisc.Location = new System.Drawing.Point(24, 141);
                this.TxtFolderDisc.MaxLength = 50;
                this.TxtFolderDisc.Multiline = true;
                this.TxtFolderDisc.Name = "TxtFolderDisc";
                this.TxtFolderDisc.Size = new System.Drawing.Size(227, 96);
                this.TxtFolderDisc.TabIndex = 3;
                // 
                // TxtFolderName
                // 
                this.TxtFolderName.Enabled = false;
                this.TxtFolderName.Location = new System.Drawing.Point(83, 11);
                this.TxtFolderName.MaxLength = 25;
                this.TxtFolderName.Name = "TxtFolderName";
                this.TxtFolderName.Size = new System.Drawing.Size(165, 20);
                this.TxtFolderName.TabIndex = 1;
                this.TxtFolderName.TextChanged += new System.EventHandler(this.TxtFolderName_TextChanged);
                // 
                // FilesTabPage
                // 
                this.FilesTabPage.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
                this.FilesTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.FilesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.FilesTabPage.Controls.Add(this.Label25);
                this.FilesTabPage.Controls.Add(this.LblFileType);
                this.FilesTabPage.Controls.Add(this.BtnEditFileName);
                this.FilesTabPage.Controls.Add(this.LblProject);
                this.FilesTabPage.Controls.Add(this.LblUser);
                this.FilesTabPage.Controls.Add(this.BtnSaveFile);
                this.FilesTabPage.Controls.Add(this.LblDate);
                this.FilesTabPage.Controls.Add(this.LblFilePath);
                this.FilesTabPage.Controls.Add(this.Label15);
                this.FilesTabPage.Controls.Add(this.Label16);
                this.FilesTabPage.Controls.Add(this.Label17);
                this.FilesTabPage.Controls.Add(this.Label18);
                this.FilesTabPage.Controls.Add(this.Label19);
                this.FilesTabPage.Controls.Add(this.Label20);
                this.FilesTabPage.Controls.Add(this.TxtDisc);
                this.FilesTabPage.Controls.Add(this.TxtFileName);
                this.FilesTabPage.Location = new System.Drawing.Point(4, 22);
                this.FilesTabPage.Name = "FilesTabPage";
                this.FilesTabPage.Padding = new System.Windows.Forms.Padding(3);
                this.FilesTabPage.Size = new System.Drawing.Size(319, 285);
                this.FilesTabPage.TabIndex = 1;
                this.FilesTabPage.Text = "الملفات";
                this.FilesTabPage.UseVisualStyleBackColor = true;
                // 
                // Label25
                // 
                this.Label25.AutoSize = true;
                this.Label25.Location = new System.Drawing.Point(259, 144);
                this.Label25.Name = "Label25";
                this.Label25.Size = new System.Drawing.Size(50, 13);
                this.Label25.TabIndex = 27;
                this.Label25.Text = "نوع الملف";
                // 
                // LblFileType
                // 
                this.LblFileType.AutoSize = true;
                this.LblFileType.Location = new System.Drawing.Point(83, 144);
                this.LblFileType.Name = "LblFileType";
                this.LblFileType.Size = new System.Drawing.Size(16, 13);
                this.LblFileType.TabIndex = 26;
                this.LblFileType.Text = "...";
                // 
                // BtnEditFileName
                // 
                this.BtnEditFileName.Location = new System.Drawing.Point(24, 9);
                this.BtnEditFileName.Name = "BtnEditFileName";
                this.BtnEditFileName.Size = new System.Drawing.Size(56, 23);
                this.BtnEditFileName.TabIndex = 2;
                this.BtnEditFileName.Text = "تعديل";
                this.BtnEditFileName.UseVisualStyleBackColor = true;
                this.BtnEditFileName.Click += new System.EventHandler(this.BtnEditFileName_Click);
                // 
                // LblProject
                // 
                this.LblProject.AutoSize = true;
                this.LblProject.Location = new System.Drawing.Point(83, 118);
                this.LblProject.Name = "LblProject";
                this.LblProject.Size = new System.Drawing.Size(47, 13);
                this.LblProject.TabIndex = 7;
                this.LblProject.Text = "Unkown";
                // 
                // LblUser
                // 
                this.LblUser.AutoSize = true;
                this.LblUser.Location = new System.Drawing.Point(83, 92);
                this.LblUser.Name = "LblUser";
                this.LblUser.Size = new System.Drawing.Size(47, 13);
                this.LblUser.TabIndex = 8;
                this.LblUser.Text = "Unkown";
                // 
                // BtnSaveFile
                // 
                this.BtnSaveFile.Location = new System.Drawing.Point(210, 251);
                this.BtnSaveFile.Name = "BtnSaveFile";
                this.BtnSaveFile.Size = new System.Drawing.Size(99, 23);
                this.BtnSaveFile.TabIndex = 4;
                this.BtnSaveFile.Text = "حفـــــظ";
                this.BtnSaveFile.UseVisualStyleBackColor = true;
                this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
                // 
                // LblDate
                // 
                this.LblDate.AutoSize = true;
                this.LblDate.Location = new System.Drawing.Point(83, 66);
                this.LblDate.Name = "LblDate";
                this.LblDate.Size = new System.Drawing.Size(53, 13);
                this.LblDate.TabIndex = 10;
                this.LblDate.Text = "1/1/2000";
                // 
                // LblFilePath
                // 
                this.LblFilePath.AutoSize = true;
                this.LblFilePath.Location = new System.Drawing.Point(83, 40);
                this.LblFilePath.Name = "LblFilePath";
                this.LblFilePath.Size = new System.Drawing.Size(21, 13);
                this.LblFilePath.TabIndex = 9;
                this.LblFilePath.Text = "c:\\";
                // 
                // Label15
                // 
                this.Label15.AutoSize = true;
                this.Label15.Location = new System.Drawing.Point(276, 173);
                this.Label15.Name = "Label15";
                this.Label15.Size = new System.Drawing.Size(37, 13);
                this.Label15.TabIndex = 11;
                this.Label15.Text = "الوصف";
                // 
                // Label16
                // 
                this.Label16.AutoSize = true;
                this.Label16.Location = new System.Drawing.Point(238, 118);
                this.Label16.Name = "Label16";
                this.Label16.Size = new System.Drawing.Size(71, 13);
                this.Label16.TabIndex = 13;
                this.Label16.Text = "الاسم الرئيسي";
                // 
                // Label17
                // 
                this.Label17.AutoSize = true;
                this.Label17.Location = new System.Drawing.Point(239, 92);
                this.Label17.Name = "Label17";
                this.Label17.Size = new System.Drawing.Size(68, 13);
                this.Label17.TabIndex = 12;
                this.Label17.Text = "اسم المستخدم";
                // 
                // Label18
                // 
                this.Label18.AutoSize = true;
                this.Label18.Location = new System.Drawing.Point(269, 66);
                this.Label18.Name = "Label18";
                this.Label18.Size = new System.Drawing.Size(38, 13);
                this.Label18.TabIndex = 5;
                this.Label18.Text = "التاريخ";
                // 
                // Label19
                // 
                this.Label19.AutoSize = true;
                this.Label19.Location = new System.Drawing.Point(269, 40);
                this.Label19.Name = "Label19";
                this.Label19.Size = new System.Drawing.Size(36, 13);
                this.Label19.TabIndex = 4;
                this.Label19.Text = "المسار";
                // 
                // Label20
                // 
                this.Label20.AutoSize = true;
                this.Label20.Location = new System.Drawing.Point(259, 14);
                this.Label20.Name = "Label20";
                this.Label20.Size = new System.Drawing.Size(50, 13);
                this.Label20.TabIndex = 6;
                this.Label20.Text = "اسم الملف";
                // 
                // TxtDisc
                // 
                this.TxtDisc.Location = new System.Drawing.Point(24, 170);
                this.TxtDisc.MaxLength = 50;
                this.TxtDisc.Multiline = true;
                this.TxtDisc.Name = "TxtDisc";
                this.TxtDisc.Size = new System.Drawing.Size(227, 68);
                this.TxtDisc.TabIndex = 3;
                // 
                // TxtFileName
                // 
                this.TxtFileName.Enabled = false;
                this.TxtFileName.Location = new System.Drawing.Point(86, 11);
                this.TxtFileName.MaxLength = 20;
                this.TxtFileName.Name = "TxtFileName";
                this.TxtFileName.Size = new System.Drawing.Size(165, 20);
                this.TxtFileName.TabIndex = 1;
                // 
                // FoldersprivilegesTabPage
                // 
                this.FoldersprivilegesTabPage.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
                this.FoldersprivilegesTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.FoldersprivilegesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.FoldersprivilegesTabPage.Controls.Add(this.tabControl1);
                this.FoldersprivilegesTabPage.Location = new System.Drawing.Point(4, 22);
                this.FoldersprivilegesTabPage.Name = "FoldersprivilegesTabPage";
                this.FoldersprivilegesTabPage.Size = new System.Drawing.Size(319, 285);
                this.FoldersprivilegesTabPage.TabIndex = 2;
                this.FoldersprivilegesTabPage.Text = "السماحيات";
                this.FoldersprivilegesTabPage.UseVisualStyleBackColor = true;
                // 
                // tabControl1
                // 
                this.tabControl1.Controls.Add(this.tabPage1);
                this.tabControl1.Controls.Add(this.tabPage2);
                this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tabControl1.Location = new System.Drawing.Point(0, 0);
                this.tabControl1.Name = "tabControl1";
                this.tabControl1.SelectedIndex = 0;
                this.tabControl1.Size = new System.Drawing.Size(315, 281);
                this.tabControl1.TabIndex = 1;
                // 
                // tabPage1
                // 
                this.tabPage1.Controls.Add(this.GroupBoxPrivilagesTab);
                this.tabPage1.Location = new System.Drawing.Point(4, 22);
                this.tabPage1.Name = "tabPage1";
                this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
                this.tabPage1.Size = new System.Drawing.Size(307, 255);
                this.tabPage1.TabIndex = 0;
                this.tabPage1.Text = "السماحيات";
                this.tabPage1.UseVisualStyleBackColor = true;
                // 
                // GroupBoxPrivilagesTab
                // 
                this.GroupBoxPrivilagesTab.Controls.Add(this.CBView);
                this.GroupBoxPrivilagesTab.Controls.Add(this.CBDelete);
                this.GroupBoxPrivilagesTab.Controls.Add(this.CBAdd);
                this.GroupBoxPrivilagesTab.Controls.Add(this.CBWrite);
                this.GroupBoxPrivilagesTab.Controls.Add(this.Label5);
                this.GroupBoxPrivilagesTab.Controls.Add(this.Label3);
                this.GroupBoxPrivilagesTab.Controls.Add(this.BtnSavePriv);
                this.GroupBoxPrivilagesTab.Controls.Add(this.BtnBtnRemoveAll);
                this.GroupBoxPrivilagesTab.Controls.Add(this.BtnRemoveSelected);
                this.GroupBoxPrivilagesTab.Controls.Add(this.BtnAddSelected);
                this.GroupBoxPrivilagesTab.Controls.Add(this.BtnAddAll);
                this.GroupBoxPrivilagesTab.Controls.Add(this.LBSelectedprivileges);
                this.GroupBoxPrivilagesTab.Controls.Add(this.LBAllprivileges);
                this.GroupBoxPrivilagesTab.Location = new System.Drawing.Point(6, 11);
                this.GroupBoxPrivilagesTab.Name = "GroupBoxPrivilagesTab";
                this.GroupBoxPrivilagesTab.Size = new System.Drawing.Size(312, 238);
                this.GroupBoxPrivilagesTab.TabIndex = 0;
                this.GroupBoxPrivilagesTab.TabStop = false;
                this.GroupBoxPrivilagesTab.Text = "قائمة السماحيات";
                // 
                // CBView
                // 
                this.CBView.AutoSize = true;
                this.CBView.Enabled = false;
                this.CBView.Location = new System.Drawing.Point(98, 190);
                this.CBView.Name = "CBView";
                this.CBView.Size = new System.Drawing.Size(75, 17);
                this.CBView.TabIndex = 8;
                this.CBView.Text = "العرض فقط";
                this.CBView.UseVisualStyleBackColor = true;
                this.CBView.CheckedChanged += new System.EventHandler(this.CBView_CheckedChanged);
                // 
                // CBDelete
                // 
                this.CBDelete.AutoSize = true;
                this.CBDelete.Enabled = false;
                this.CBDelete.Location = new System.Drawing.Point(98, 213);
                this.CBDelete.Name = "CBDelete";
                this.CBDelete.Size = new System.Drawing.Size(53, 17);
                this.CBDelete.TabIndex = 8;
                this.CBDelete.Text = "الحذف";
                this.CBDelete.UseVisualStyleBackColor = true;
                this.CBDelete.CheckedChanged += new System.EventHandler(this.CBDelete_CheckedChanged);
                // 
                // CBAdd
                // 
                this.CBAdd.AutoSize = true;
                this.CBAdd.Enabled = false;
                this.CBAdd.Location = new System.Drawing.Point(6, 190);
                this.CBAdd.Name = "CBAdd";
                this.CBAdd.Size = new System.Drawing.Size(59, 17);
                this.CBAdd.TabIndex = 7;
                this.CBAdd.Text = "الاضافه";
                this.CBAdd.UseVisualStyleBackColor = true;
                this.CBAdd.CheckedChanged += new System.EventHandler(this.CBAdd_CheckedChanged);
                // 
                // CBWrite
                // 
                this.CBWrite.AutoSize = true;
                this.CBWrite.Enabled = false;
                this.CBWrite.Location = new System.Drawing.Point(6, 213);
                this.CBWrite.Name = "CBWrite";
                this.CBWrite.Size = new System.Drawing.Size(58, 17);
                this.CBWrite.TabIndex = 7;
                this.CBWrite.Text = "التعديل";
                this.CBWrite.UseVisualStyleBackColor = true;
                this.CBWrite.CheckedChanged += new System.EventHandler(this.CBWrite_CheckedChanged);
                // 
                // Label5
                // 
                this.Label5.AutoSize = true;
                this.Label5.Location = new System.Drawing.Point(172, 25);
                this.Label5.Name = "Label5";
                this.Label5.Size = new System.Drawing.Size(94, 13);
                this.Label5.TabIndex = 2;
                this.Label5.Text = "السماحيات المختاره";
                this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // Label3
                // 
                this.Label3.AutoSize = true;
                this.Label3.Location = new System.Drawing.Point(8, 25);
                this.Label3.Name = "Label3";
                this.Label3.Size = new System.Drawing.Size(71, 13);
                this.Label3.TabIndex = 2;
                this.Label3.Text = "كل السماحيات";
                this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // BtnBtnRemoveAll
                // 
                this.BtnBtnRemoveAll.Location = new System.Drawing.Point(132, 144);
                this.BtnBtnRemoveAll.Name = "BtnBtnRemoveAll";
                this.BtnBtnRemoveAll.Size = new System.Drawing.Size(37, 23);
                this.BtnBtnRemoveAll.TabIndex = 5;
                this.BtnBtnRemoveAll.Text = "<<";
                this.BtnBtnRemoveAll.UseVisualStyleBackColor = true;
                this.BtnBtnRemoveAll.Click += new System.EventHandler(this.BtnBtnRemoveAll_Click);
                // 
                // BtnRemoveSelected
                // 
                this.BtnRemoveSelected.Enabled = false;
                this.BtnRemoveSelected.Location = new System.Drawing.Point(132, 117);
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
                this.BtnAddSelected.Location = new System.Drawing.Point(132, 85);
                this.BtnAddSelected.Name = "BtnAddSelected";
                this.BtnAddSelected.Size = new System.Drawing.Size(37, 23);
                this.BtnAddSelected.TabIndex = 3;
                this.BtnAddSelected.Text = ">";
                this.BtnAddSelected.UseVisualStyleBackColor = true;
                this.BtnAddSelected.Click += new System.EventHandler(this.BtnAddSelected_Click);
                // 
                // BtnAddAll
                // 
                this.BtnAddAll.Location = new System.Drawing.Point(132, 58);
                this.BtnAddAll.Name = "BtnAddAll";
                this.BtnAddAll.Size = new System.Drawing.Size(37, 23);
                this.BtnAddAll.TabIndex = 2;
                this.BtnAddAll.Text = ">>";
                this.BtnAddAll.UseVisualStyleBackColor = true;
                this.BtnAddAll.Click += new System.EventHandler(this.BtnAddAll_Click);
                // 
                // LBSelectedprivileges
                // 
                this.LBSelectedprivileges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LBSelectedprivileges.FormattingEnabled = true;
                this.LBSelectedprivileges.Location = new System.Drawing.Point(171, 45);
                this.LBSelectedprivileges.Name = "LBSelectedprivileges";
                this.LBSelectedprivileges.Size = new System.Drawing.Size(125, 132);
                this.LBSelectedprivileges.TabIndex = 6;
                this.LBSelectedprivileges.SelectedIndexChanged += new System.EventHandler(this.LBSelectedprivileges_SelectedIndexChanged);
                this.LBSelectedprivileges.DoubleClick += new System.EventHandler(this.LBSelectedprivileges_DoubleClick);
                this.LBSelectedprivileges.GotFocus += new System.EventHandler(this.LBSelectedprivileges_GotFocus);
                // 
                // LBAllprivileges
                // 
                this.LBAllprivileges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LBAllprivileges.FormattingEnabled = true;
                this.LBAllprivileges.Location = new System.Drawing.Point(5, 45);
                this.LBAllprivileges.Name = "LBAllprivileges";
                this.LBAllprivileges.Size = new System.Drawing.Size(125, 132);
                this.LBAllprivileges.TabIndex = 1;
                this.LBAllprivileges.SelectedIndexChanged += new System.EventHandler(this.LBAllprivileges_SelectedIndexChanged);
                this.LBAllprivileges.DoubleClick += new System.EventHandler(this.LBAllprivileges_DoubleClick);
                // 
                // tabPage2
                // 
                this.tabPage2.Controls.Add(this.groupBox1);
                this.tabPage2.Location = new System.Drawing.Point(4, 22);
                this.tabPage2.Name = "tabPage2";
                this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
                this.tabPage2.Size = new System.Drawing.Size(307, 255);
                this.tabPage2.TabIndex = 1;
                this.tabPage2.Text = "افراد";
                this.tabPage2.UseVisualStyleBackColor = true;
                // 
                // groupBox1
                // 
                this.groupBox1.Controls.Add(this.CBDeleteUser);
                this.groupBox1.Controls.Add(this.CBViewUser);
                this.groupBox1.Controls.Add(this.CBWriteUser);
                this.groupBox1.Controls.Add(this.CBAddUser);
                this.groupBox1.Controls.Add(this.label7);
                this.groupBox1.Controls.Add(this.label8);
                this.groupBox1.Controls.Add(this.BtnSaveUser);
                this.groupBox1.Controls.Add(this.BtnBtnRemoveAllUser);
                this.groupBox1.Controls.Add(this.BtnRemoveSelectedUser);
                this.groupBox1.Controls.Add(this.BtnAddSelectedUser);
                this.groupBox1.Controls.Add(this.BtnAddAllUsers);
                this.groupBox1.Controls.Add(this.LBSelectedUsers);
                this.groupBox1.Controls.Add(this.LBAllUsers);
                this.groupBox1.Location = new System.Drawing.Point(-3, 8);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Size = new System.Drawing.Size(312, 238);
                this.groupBox1.TabIndex = 1;
                this.groupBox1.TabStop = false;
                this.groupBox1.Text = "قائمة المستخدمين";
                // 
                // CBDeleteUser
                // 
                this.CBDeleteUser.AutoSize = true;
                this.CBDeleteUser.Enabled = false;
                this.CBDeleteUser.Location = new System.Drawing.Point(99, 210);
                this.CBDeleteUser.Name = "CBDeleteUser";
                this.CBDeleteUser.Size = new System.Drawing.Size(53, 17);
                this.CBDeleteUser.TabIndex = 8;
                this.CBDeleteUser.Text = "الحذف";
                this.CBDeleteUser.UseVisualStyleBackColor = true;
                this.CBDeleteUser.CheckedChanged += new System.EventHandler(this.CBDeleteUser_CheckedChanged);
                // 
                // CBViewUser
                // 
                this.CBViewUser.AutoSize = true;
                this.CBViewUser.Enabled = false;
                this.CBViewUser.Location = new System.Drawing.Point(99, 187);
                this.CBViewUser.Name = "CBViewUser";
                this.CBViewUser.Size = new System.Drawing.Size(75, 17);
                this.CBViewUser.TabIndex = 8;
                this.CBViewUser.Text = "العرض فقط";
                this.CBViewUser.UseVisualStyleBackColor = true;
                this.CBViewUser.CheckedChanged += new System.EventHandler(this.CBViewUser_CheckedChanged);
                // 
                // CBWriteUser
                // 
                this.CBWriteUser.AutoSize = true;
                this.CBWriteUser.Enabled = false;
                this.CBWriteUser.Location = new System.Drawing.Point(7, 210);
                this.CBWriteUser.Name = "CBWriteUser";
                this.CBWriteUser.Size = new System.Drawing.Size(58, 17);
                this.CBWriteUser.TabIndex = 7;
                this.CBWriteUser.Text = "التعديل";
                this.CBWriteUser.UseVisualStyleBackColor = true;
                this.CBWriteUser.CheckedChanged += new System.EventHandler(this.CBWriteUser_CheckedChanged);
                // 
                // CBAddUser
                // 
                this.CBAddUser.AutoSize = true;
                this.CBAddUser.Enabled = false;
                this.CBAddUser.Location = new System.Drawing.Point(7, 187);
                this.CBAddUser.Name = "CBAddUser";
                this.CBAddUser.Size = new System.Drawing.Size(59, 17);
                this.CBAddUser.TabIndex = 7;
                this.CBAddUser.Text = "الاضافه";
                this.CBAddUser.UseVisualStyleBackColor = true;
                this.CBAddUser.CheckedChanged += new System.EventHandler(this.CBAddUser_CheckedChanged);
                // 
                // label7
                // 
                this.label7.AutoSize = true;
                this.label7.Location = new System.Drawing.Point(179, 25);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(38, 13);
                this.label7.TabIndex = 2;
                this.label7.Text = "المختار";
                this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // label8
                // 
                this.label8.AutoSize = true;
                this.label8.Location = new System.Drawing.Point(15, 25);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(36, 13);
                this.label8.TabIndex = 2;
                this.label8.Text = "الجميع";
                this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // BtnSaveUser
                // 
                this.BtnSaveUser.Location = new System.Drawing.Point(207, 206);
                this.BtnSaveUser.Name = "BtnSaveUser";
                this.BtnSaveUser.Size = new System.Drawing.Size(99, 23);
                this.BtnSaveUser.TabIndex = 9;
                this.BtnSaveUser.Text = "حفـــــظ";
                this.BtnSaveUser.UseVisualStyleBackColor = true;
                this.BtnSaveUser.Click += new System.EventHandler(this.BtnSaveUser_Click);
                // 
                // BtnBtnRemoveAllUser
                // 
                this.BtnBtnRemoveAllUser.Location = new System.Drawing.Point(139, 144);
                this.BtnBtnRemoveAllUser.Name = "BtnBtnRemoveAllUser";
                this.BtnBtnRemoveAllUser.Size = new System.Drawing.Size(37, 23);
                this.BtnBtnRemoveAllUser.TabIndex = 5;
                this.BtnBtnRemoveAllUser.Text = "<<";
                this.BtnBtnRemoveAllUser.UseVisualStyleBackColor = true;
                this.BtnBtnRemoveAllUser.Click += new System.EventHandler(this.BtnBtnRemoveAllUser_Click);
                // 
                // BtnRemoveSelectedUser
                // 
                this.BtnRemoveSelectedUser.Enabled = false;
                this.BtnRemoveSelectedUser.Location = new System.Drawing.Point(139, 117);
                this.BtnRemoveSelectedUser.Name = "BtnRemoveSelectedUser";
                this.BtnRemoveSelectedUser.Size = new System.Drawing.Size(37, 23);
                this.BtnRemoveSelectedUser.TabIndex = 4;
                this.BtnRemoveSelectedUser.Text = "<";
                this.BtnRemoveSelectedUser.UseVisualStyleBackColor = true;
                this.BtnRemoveSelectedUser.Click += new System.EventHandler(this.BtnRemoveSelectedUser_Click);
                // 
                // BtnAddSelectedUser
                // 
                this.BtnAddSelectedUser.Enabled = false;
                this.BtnAddSelectedUser.Location = new System.Drawing.Point(139, 85);
                this.BtnAddSelectedUser.Name = "BtnAddSelectedUser";
                this.BtnAddSelectedUser.Size = new System.Drawing.Size(37, 23);
                this.BtnAddSelectedUser.TabIndex = 3;
                this.BtnAddSelectedUser.Text = ">";
                this.BtnAddSelectedUser.UseVisualStyleBackColor = true;
                this.BtnAddSelectedUser.Click += new System.EventHandler(this.BtnAddSelectedUser_Click);
                // 
                // BtnAddAllUsers
                // 
                this.BtnAddAllUsers.Location = new System.Drawing.Point(139, 58);
                this.BtnAddAllUsers.Name = "BtnAddAllUsers";
                this.BtnAddAllUsers.Size = new System.Drawing.Size(37, 23);
                this.BtnAddAllUsers.TabIndex = 2;
                this.BtnAddAllUsers.Text = ">>";
                this.BtnAddAllUsers.UseVisualStyleBackColor = true;
                this.BtnAddAllUsers.Click += new System.EventHandler(this.BtnAddAllUsers_Click);
                // 
                // LBSelectedUsers
                // 
                this.LBSelectedUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LBSelectedUsers.FormattingEnabled = true;
                this.LBSelectedUsers.Location = new System.Drawing.Point(178, 45);
                this.LBSelectedUsers.Name = "LBSelectedUsers";
                this.LBSelectedUsers.Size = new System.Drawing.Size(125, 132);
                this.LBSelectedUsers.TabIndex = 6;
                this.LBSelectedUsers.SelectedIndexChanged += new System.EventHandler(this.LBSelectedUsers_SelectedIndexChanged);
                this.LBSelectedUsers.DoubleClick += new System.EventHandler(this.LBSelectedUsers_DoubleClick);
                // 
                // LBAllUsers
                // 
                this.LBAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.LBAllUsers.FormattingEnabled = true;
                this.LBAllUsers.Location = new System.Drawing.Point(12, 45);
                this.LBAllUsers.Name = "LBAllUsers";
                this.LBAllUsers.Size = new System.Drawing.Size(125, 132);
                this.LBAllUsers.TabIndex = 1;
                this.LBAllUsers.SelectedIndexChanged += new System.EventHandler(this.LBAllUsers_SelectedIndexChanged);
                this.LBAllUsers.DoubleClick += new System.EventHandler(this.LBAllUsers_DoubleClick);
                // 
                // NewFileTabPage
                // 
                this.NewFileTabPage.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
                this.NewFileTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.NewFileTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.NewFileTabPage.Controls.Add(this.NewFileProgressBar);
                this.NewFileTabPage.Controls.Add(this.TxtNewFileName);
                this.NewFileTabPage.Controls.Add(this.FileTypeCB);
                this.NewFileTabPage.Controls.Add(this.BtnBrowseNewFile);
                this.NewFileTabPage.Controls.Add(this.Label9);
                this.NewFileTabPage.Controls.Add(this.BtnSaveNewFile);
                this.NewFileTabPage.Controls.Add(this.LblNewFileDate);
                this.NewFileTabPage.Controls.Add(this.LblNewFilePath);
                this.NewFileTabPage.Controls.Add(this.Label26);
                this.NewFileTabPage.Controls.Add(this.Label13);
                this.NewFileTabPage.Controls.Add(this.Label12);
                this.NewFileTabPage.Controls.Add(this.Label21);
                this.NewFileTabPage.Controls.Add(this.Label22);
                this.NewFileTabPage.Controls.Add(this.Label23);
                this.NewFileTabPage.Controls.Add(this.Label24);
                this.NewFileTabPage.Controls.Add(this.TxtNewFileDesc);
                this.NewFileTabPage.Location = new System.Drawing.Point(4, 22);
                this.NewFileTabPage.Name = "NewFileTabPage";
                this.NewFileTabPage.Size = new System.Drawing.Size(319, 285);
                this.NewFileTabPage.TabIndex = 3;
                this.NewFileTabPage.Text = "ملف جديد";
                this.NewFileTabPage.UseVisualStyleBackColor = true;
                // 
                // NewFileProgressBar
                // 
                this.NewFileProgressBar.Location = new System.Drawing.Point(3, 258);
                this.NewFileProgressBar.Name = "NewFileProgressBar";
                this.NewFileProgressBar.Size = new System.Drawing.Size(199, 16);
                this.NewFileProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                this.NewFileProgressBar.TabIndex = 32;
                this.NewFileProgressBar.Visible = false;
                // 
                // TxtNewFileName
                // 
                this.TxtNewFileName.Location = new System.Drawing.Point(87, 11);
                this.TxtNewFileName.MaxLength = 20;
                this.TxtNewFileName.Name = "TxtNewFileName";
                this.TxtNewFileName.Size = new System.Drawing.Size(165, 20);
                this.TxtNewFileName.TabIndex = 1;
                this.TxtNewFileName.TextChanged += new System.EventHandler(this.TxtNewFileName_TextChanged);
                // 
                // FileTypeCB
                // 
                this.FileTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.FileTypeCB.FormattingEnabled = true;
                this.FileTypeCB.Location = new System.Drawing.Point(83, 118);
                this.FileTypeCB.Name = "FileTypeCB";
                this.FileTypeCB.Size = new System.Drawing.Size(169, 21);
                this.FileTypeCB.TabIndex = 3;
                // 
                // BtnBrowseNewFile
                // 
                this.BtnBrowseNewFile.Location = new System.Drawing.Point(25, 9);
                this.BtnBrowseNewFile.Name = "BtnBrowseNewFile";
                this.BtnBrowseNewFile.Size = new System.Drawing.Size(56, 23);
                this.BtnBrowseNewFile.TabIndex = 2;
                this.BtnBrowseNewFile.Text = "...";
                this.BtnBrowseNewFile.UseVisualStyleBackColor = true;
                this.BtnBrowseNewFile.Click += new System.EventHandler(this.BtnBrowseNewFile_Click);
                // 
                // Label9
                // 
                this.Label9.AutoSize = true;
                this.Label9.Location = new System.Drawing.Point(84, 92);
                this.Label9.Name = "Label9";
                this.Label9.Size = new System.Drawing.Size(67, 13);
                this.Label9.TabIndex = 22;
                this.Label9.Text = "Administrator";
                // 
                // BtnSaveNewFile
                // 
                this.BtnSaveNewFile.Enabled = false;
                this.BtnSaveNewFile.Location = new System.Drawing.Point(211, 251);
                this.BtnSaveNewFile.Name = "BtnSaveNewFile";
                this.BtnSaveNewFile.Size = new System.Drawing.Size(99, 23);
                this.BtnSaveNewFile.TabIndex = 5;
                this.BtnSaveNewFile.Text = "حفـــــظ";
                this.BtnSaveNewFile.UseVisualStyleBackColor = true;
                this.BtnSaveNewFile.Click += new System.EventHandler(this.BtnSaveNewFile_Click);
                // 
                // LblNewFileDate
                // 
                this.LblNewFileDate.AutoSize = true;
                this.LblNewFileDate.Location = new System.Drawing.Point(84, 66);
                this.LblNewFileDate.Name = "LblNewFileDate";
                this.LblNewFileDate.Size = new System.Drawing.Size(53, 13);
                this.LblNewFileDate.TabIndex = 24;
                this.LblNewFileDate.Text = "1/1/2000";
                // 
                // LblNewFilePath
                // 
                this.LblNewFilePath.AutoSize = true;
                this.LblNewFilePath.Location = new System.Drawing.Point(84, 40);
                this.LblNewFilePath.Name = "LblNewFilePath";
                this.LblNewFilePath.Size = new System.Drawing.Size(10, 13);
                this.LblNewFilePath.TabIndex = 23;
                this.LblNewFilePath.Text = ".";
                this.LblNewFilePath.TextChanged += new System.EventHandler(this.TxtNewFileName_TextChanged);
                // 
                // Label26
                // 
                this.Label26.AutoSize = true;
                this.Label26.Location = new System.Drawing.Point(255, 118);
                this.Label26.Name = "Label26";
                this.Label26.Size = new System.Drawing.Size(50, 13);
                this.Label26.TabIndex = 25;
                this.Label26.Text = "نوع الملف";
                // 
                // Label13
                // 
                this.Label13.AutoSize = true;
                this.Label13.Location = new System.Drawing.Point(273, 168);
                this.Label13.Name = "Label13";
                this.Label13.Size = new System.Drawing.Size(37, 13);
                this.Label13.TabIndex = 25;
                this.Label13.Text = "الوصف";
                // 
                // Label12
                // 
                this.Label12.AutoSize = true;
                this.Label12.ForeColor = System.Drawing.Color.Red;
                this.Label12.Location = new System.Drawing.Point(3, 241);
                this.Label12.Name = "Label12";
                this.Label12.Size = new System.Drawing.Size(131, 13);
                this.Label12.TabIndex = 26;
                this.Label12.Text = "حجم الملف اضعر من 50 ميجا";
                // 
                // Label21
                // 
                this.Label21.AutoSize = true;
                this.Label21.Location = new System.Drawing.Point(239, 92);
                this.Label21.Name = "Label21";
                this.Label21.Size = new System.Drawing.Size(68, 13);
                this.Label21.TabIndex = 26;
                this.Label21.Text = "اسم المستخدم";
                // 
                // Label22
                // 
                this.Label22.AutoSize = true;
                this.Label22.Location = new System.Drawing.Point(269, 66);
                this.Label22.Name = "Label22";
                this.Label22.Size = new System.Drawing.Size(38, 13);
                this.Label22.TabIndex = 19;
                this.Label22.Text = "التاريخ";
                // 
                // Label23
                // 
                this.Label23.AutoSize = true;
                this.Label23.Location = new System.Drawing.Point(269, 40);
                this.Label23.Name = "Label23";
                this.Label23.Size = new System.Drawing.Size(36, 13);
                this.Label23.TabIndex = 18;
                this.Label23.Text = "المسار";
                // 
                // Label24
                // 
                this.Label24.AutoSize = true;
                this.Label24.Location = new System.Drawing.Point(257, 14);
                this.Label24.Name = "Label24";
                this.Label24.Size = new System.Drawing.Size(50, 13);
                this.Label24.TabIndex = 20;
                this.Label24.Text = "اسم الملف";
                // 
                // TxtNewFileDesc
                // 
                this.TxtNewFileDesc.Location = new System.Drawing.Point(29, 168);
                this.TxtNewFileDesc.MaxLength = 50;
                this.TxtNewFileDesc.Multiline = true;
                this.TxtNewFileDesc.Name = "TxtNewFileDesc";
                this.TxtNewFileDesc.Size = new System.Drawing.Size(227, 70);
                this.TxtNewFileDesc.TabIndex = 4;
                // 
                // NewFolderTabPage
                // 
                this.NewFolderTabPage.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
                this.NewFolderTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.NewFolderTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.NewFolderTabPage.Controls.Add(this.BtnNewFolderSave);
                this.NewFolderTabPage.Controls.Add(this.LblNewFolderOwner);
                this.NewFolderTabPage.Controls.Add(this.LblNewFolderDate);
                this.NewFolderTabPage.Controls.Add(this.LblNewFolderPath);
                this.NewFolderTabPage.Controls.Add(this.Label29);
                this.NewFolderTabPage.Controls.Add(this.Label31);
                this.NewFolderTabPage.Controls.Add(this.Label32);
                this.NewFolderTabPage.Controls.Add(this.Label34);
                this.NewFolderTabPage.Controls.Add(this.Label33);
                this.NewFolderTabPage.Controls.Add(this.TxtNewFolderDesc);
                this.NewFolderTabPage.Controls.Add(this.TxtNewFolderName);
                this.NewFolderTabPage.Location = new System.Drawing.Point(4, 22);
                this.NewFolderTabPage.Name = "NewFolderTabPage";
                this.NewFolderTabPage.Size = new System.Drawing.Size(319, 285);
                this.NewFolderTabPage.TabIndex = 4;
                this.NewFolderTabPage.Text = "مجلد جديد";
                this.NewFolderTabPage.UseVisualStyleBackColor = true;
                // 
                // BtnNewFolderSave
                // 
                this.BtnNewFolderSave.Enabled = false;
                this.BtnNewFolderSave.Location = new System.Drawing.Point(209, 248);
                this.BtnNewFolderSave.Name = "BtnNewFolderSave";
                this.BtnNewFolderSave.Size = new System.Drawing.Size(99, 23);
                this.BtnNewFolderSave.TabIndex = 3;
                this.BtnNewFolderSave.Text = "حفـــــظ";
                this.BtnNewFolderSave.UseVisualStyleBackColor = true;
                this.BtnNewFolderSave.Click += new System.EventHandler(this.BtnNewFolderSave_Click);
                // 
                // LblNewFolderOwner
                // 
                this.LblNewFolderOwner.AutoSize = true;
                this.LblNewFolderOwner.Location = new System.Drawing.Point(82, 89);
                this.LblNewFolderOwner.Name = "LblNewFolderOwner";
                this.LblNewFolderOwner.Size = new System.Drawing.Size(67, 13);
                this.LblNewFolderOwner.TabIndex = 10;
                this.LblNewFolderOwner.Text = "Administrator";
                // 
                // LblNewFolderDate
                // 
                this.LblNewFolderDate.AutoSize = true;
                this.LblNewFolderDate.Location = new System.Drawing.Point(82, 63);
                this.LblNewFolderDate.Name = "LblNewFolderDate";
                this.LblNewFolderDate.Size = new System.Drawing.Size(53, 13);
                this.LblNewFolderDate.TabIndex = 13;
                this.LblNewFolderDate.Text = "1/1/2000";
                // 
                // LblNewFolderPath
                // 
                this.LblNewFolderPath.AutoSize = true;
                this.LblNewFolderPath.Location = new System.Drawing.Point(82, 37);
                this.LblNewFolderPath.Name = "LblNewFolderPath";
                this.LblNewFolderPath.Size = new System.Drawing.Size(21, 13);
                this.LblNewFolderPath.TabIndex = 12;
                this.LblNewFolderPath.Text = "c:\\";
                // 
                // Label29
                // 
                this.Label29.AutoSize = true;
                this.Label29.Location = new System.Drawing.Point(270, 141);
                this.Label29.Name = "Label29";
                this.Label29.Size = new System.Drawing.Size(37, 13);
                this.Label29.TabIndex = 9;
                this.Label29.Text = "الوصف";
                // 
                // Label31
                // 
                this.Label31.AutoSize = true;
                this.Label31.Location = new System.Drawing.Point(239, 89);
                this.Label31.Name = "Label31";
                this.Label31.Size = new System.Drawing.Size(68, 13);
                this.Label31.TabIndex = 4;
                this.Label31.Text = "اسم المستخدم";
                // 
                // Label32
                // 
                this.Label32.AutoSize = true;
                this.Label32.Location = new System.Drawing.Point(269, 63);
                this.Label32.Name = "Label32";
                this.Label32.Size = new System.Drawing.Size(38, 13);
                this.Label32.TabIndex = 6;
                this.Label32.Text = "التاريخ";
                // 
                // Label34
                // 
                this.Label34.AutoSize = true;
                this.Label34.Location = new System.Drawing.Point(255, 11);
                this.Label34.Name = "Label34";
                this.Label34.Size = new System.Drawing.Size(53, 13);
                this.Label34.TabIndex = 8;
                this.Label34.Text = "اسم المجلد";
                // 
                // Label33
                // 
                this.Label33.AutoSize = true;
                this.Label33.Location = new System.Drawing.Point(271, 37);
                this.Label33.Name = "Label33";
                this.Label33.Size = new System.Drawing.Size(36, 13);
                this.Label33.TabIndex = 8;
                this.Label33.Text = "المسار";
                // 
                // TxtNewFolderDesc
                // 
                this.TxtNewFolderDesc.Location = new System.Drawing.Point(22, 141);
                this.TxtNewFolderDesc.MaxLength = 50;
                this.TxtNewFolderDesc.Multiline = true;
                this.TxtNewFolderDesc.Name = "TxtNewFolderDesc";
                this.TxtNewFolderDesc.Size = new System.Drawing.Size(227, 96);
                this.TxtNewFolderDesc.TabIndex = 2;
                // 
                // TxtNewFolderName
                // 
                this.TxtNewFolderName.Location = new System.Drawing.Point(22, 8);
                this.TxtNewFolderName.MaxLength = 25;
                this.TxtNewFolderName.Name = "TxtNewFolderName";
                this.TxtNewFolderName.Size = new System.Drawing.Size(227, 20);
                this.TxtNewFolderName.TabIndex = 1;
                this.TxtNewFolderName.TextChanged += new System.EventHandler(this.TxtNewFolderName_TextChanged);
                // 
                // ObjectPropertyFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.CancelButton = this.BtnCancel;
                this.ClientSize = new System.Drawing.Size(336, 351);
                this.Controls.Add(this.BtnCancel);
                this.Controls.Add(this.FoldersFilesTabControl);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "ObjectPropertyFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "الخصائص";
                this.Load += new System.EventHandler(this.ObjectPropertyFrm_Load);
                this.FoldersFilesTabControl.ResumeLayout(false);
                this.FoldersTabPage.ResumeLayout(false);
                this.FoldersTabPage.PerformLayout();
                this.FilesTabPage.ResumeLayout(false);
                this.FilesTabPage.PerformLayout();
                this.FoldersprivilegesTabPage.ResumeLayout(false);
                this.tabControl1.ResumeLayout(false);
                this.tabPage1.ResumeLayout(false);
                this.GroupBoxPrivilagesTab.ResumeLayout(false);
                this.GroupBoxPrivilagesTab.PerformLayout();
                this.tabPage2.ResumeLayout(false);
                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                this.NewFileTabPage.ResumeLayout(false);
                this.NewFileTabPage.PerformLayout();
                this.NewFolderTabPage.ResumeLayout(false);
                this.NewFolderTabPage.PerformLayout();
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Button BtnCancel;
		internal System.Windows.Forms.Button BtnSavePriv;
		internal System.Windows.Forms.TabControl FoldersFilesTabControl;
		internal System.Windows.Forms.TabPage FoldersTabPage;
        internal System.Windows.Forms.TabPage FilesTabPage;
		internal System.Windows.Forms.Label LblFolderUser;
		internal System.Windows.Forms.Label LblFolderDate;
        internal System.Windows.Forms.Label LblFolderPath;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TxtFolderName;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox TxtFolderDisc;
		internal System.Windows.Forms.Label LblProject;
		internal System.Windows.Forms.Label LblUser;
		internal System.Windows.Forms.Label LblDate;
		internal System.Windows.Forms.Label LblFilePath;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox TxtDisc;
		internal System.Windows.Forms.TextBox TxtFileName;
		internal System.Windows.Forms.TabPage FoldersprivilegesTabPage;
		internal System.Windows.Forms.GroupBox GroupBoxPrivilagesTab;
		internal System.Windows.Forms.ListBox LBAllprivileges;
		internal System.Windows.Forms.Button BtnAddSelected;
		internal System.Windows.Forms.Button BtnAddAll;
		internal System.Windows.Forms.ListBox LBSelectedprivileges;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button BtnBtnRemoveAll;
		internal System.Windows.Forms.Button BtnRemoveSelected;
		internal System.Windows.Forms.Button BtnEditFolderName;
		internal System.Windows.Forms.Button BtnSaveFolder;
		internal System.Windows.Forms.Button BtnSaveFile;
		internal System.Windows.Forms.Button BtnEditFileName;
		internal System.Windows.Forms.TabPage NewFileTabPage;
        internal System.Windows.Forms.Button BtnBrowseNewFile;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Button BtnSaveNewFile;
		internal System.Windows.Forms.Label LblNewFileDate;
		internal System.Windows.Forms.Label LblNewFilePath;
        internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.TextBox TxtNewFileDesc;
		internal System.Windows.Forms.ComboBox FileTypeCB;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.TextBox TxtNewFileName;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.Label LblFileType;
		internal System.Windows.Forms.ProgressBar NewFileProgressBar;
        internal System.Windows.Forms.TabPage NewFolderTabPage;
		internal System.Windows.Forms.Button BtnNewFolderSave;
		internal System.Windows.Forms.Label LblNewFolderOwner;
		internal System.Windows.Forms.Label LblNewFolderDate;
		internal System.Windows.Forms.Label LblNewFolderPath;
        internal System.Windows.Forms.Label Label29;
		internal System.Windows.Forms.Label Label31;
		internal System.Windows.Forms.Label Label32;
		internal System.Windows.Forms.Label Label34;
		internal System.Windows.Forms.Label Label33;
		internal System.Windows.Forms.TextBox TxtNewFolderDesc;
		internal System.Windows.Forms.TextBox TxtNewFolderName;
		internal System.Windows.Forms.CheckBox CBDelete;
        internal System.Windows.Forms.CheckBox CBWrite;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        internal GroupBox groupBox1;
        internal CheckBox CBViewUser;
        internal CheckBox CBAddUser;
        internal Label label7;
        internal Label label8;
        internal Button BtnSaveUser;
        internal Button BtnBtnRemoveAllUser;
        internal Button BtnRemoveSelectedUser;
        internal Button BtnAddSelectedUser;
        internal Button BtnAddAllUsers;
        internal ListBox LBSelectedUsers;
        internal ListBox LBAllUsers;
        internal CheckBox CBView;
        internal CheckBox CBAdd;
        internal CheckBox CBDeleteUser;
        internal CheckBox CBWriteUser;
	}
	
}
