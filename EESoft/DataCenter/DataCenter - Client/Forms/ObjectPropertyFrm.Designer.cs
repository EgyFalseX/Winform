using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace DataCenter_Client
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
                this.FilesTabPage = new System.Windows.Forms.TabPage();
                this.CBEditFileType = new System.Windows.Forms.ComboBox();
                this.Label25 = new System.Windows.Forms.Label();
                this.BtnEditFileName = new System.Windows.Forms.Button();
                this.LblUser = new System.Windows.Forms.Label();
                this.BtnSaveFile = new System.Windows.Forms.Button();
                this.LblDate = new System.Windows.Forms.Label();
                this.LblFilePath = new System.Windows.Forms.Label();
                this.Label15 = new System.Windows.Forms.Label();
                this.Label17 = new System.Windows.Forms.Label();
                this.Label18 = new System.Windows.Forms.Label();
                this.Label19 = new System.Windows.Forms.Label();
                this.Label20 = new System.Windows.Forms.Label();
                this.TxtDisc = new System.Windows.Forms.TextBox();
                this.TxtFileName = new System.Windows.Forms.TextBox();
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
                this.FoldersFilesTabControl = new System.Windows.Forms.TabControl();
                this.NewFolderTabPage.SuspendLayout();
                this.NewFileTabPage.SuspendLayout();
                this.FilesTabPage.SuspendLayout();
                this.FoldersTabPage.SuspendLayout();
                this.FoldersFilesTabControl.SuspendLayout();
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
                // NewFolderTabPage
                // 
                this.NewFolderTabPage.BackColor = System.Drawing.Color.Transparent;
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
                this.BtnNewFolderSave.Text = "حفظ";
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
                this.Label29.Location = new System.Drawing.Point(271, 121);
                this.Label29.Name = "Label29";
                this.Label29.Size = new System.Drawing.Size(32, 13);
                this.Label29.TabIndex = 9;
                this.Label29.Text = "تعليق";
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
                this.Label34.Location = new System.Drawing.Point(254, 12);
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
                this.TxtNewFolderDesc.Location = new System.Drawing.Point(8, 121);
                this.TxtNewFolderDesc.MaxLength = 50;
                this.TxtNewFolderDesc.Multiline = true;
                this.TxtNewFolderDesc.Name = "TxtNewFolderDesc";
                this.TxtNewFolderDesc.Size = new System.Drawing.Size(227, 96);
                this.TxtNewFolderDesc.TabIndex = 2;
                // 
                // TxtNewFolderName
                // 
                this.TxtNewFolderName.Location = new System.Drawing.Point(8, 9);
                this.TxtNewFolderName.MaxLength = 25;
                this.TxtNewFolderName.Name = "TxtNewFolderName";
                this.TxtNewFolderName.Size = new System.Drawing.Size(227, 20);
                this.TxtNewFolderName.TabIndex = 1;
                this.TxtNewFolderName.TextChanged += new System.EventHandler(this.TxtFolderName_TextChanged);
                // 
                // NewFileTabPage
                // 
                this.NewFileTabPage.BackColor = System.Drawing.Color.Transparent;
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
                this.TxtNewFileName.Location = new System.Drawing.Point(74, 11);
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
                this.FileTypeCB.Location = new System.Drawing.Point(70, 119);
                this.FileTypeCB.Name = "FileTypeCB";
                this.FileTypeCB.Size = new System.Drawing.Size(169, 21);
                this.FileTypeCB.TabIndex = 3;
                // 
                // BtnBrowseNewFile
                // 
                this.BtnBrowseNewFile.Location = new System.Drawing.Point(12, 9);
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
                this.Label9.BackColor = System.Drawing.Color.Transparent;
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
                this.BtnSaveNewFile.Text = "حفظ";
                this.BtnSaveNewFile.UseVisualStyleBackColor = true;
                this.BtnSaveNewFile.Click += new System.EventHandler(this.BtnSaveNewFile_Click);
                // 
                // LblNewFileDate
                // 
                this.LblNewFileDate.AutoSize = true;
                this.LblNewFileDate.BackColor = System.Drawing.Color.Transparent;
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
                this.LblNewFilePath.Size = new System.Drawing.Size(0, 13);
                this.LblNewFilePath.TabIndex = 23;
                this.LblNewFilePath.TextChanged += new System.EventHandler(this.TxtNewFileName_TextChanged);
                // 
                // Label26
                // 
                this.Label26.AutoSize = true;
                this.Label26.BackColor = System.Drawing.Color.Transparent;
                this.Label26.Location = new System.Drawing.Point(257, 122);
                this.Label26.Name = "Label26";
                this.Label26.Size = new System.Drawing.Size(50, 13);
                this.Label26.TabIndex = 25;
                this.Label26.Text = "نوع الملف";
                // 
                // Label13
                // 
                this.Label13.AutoSize = true;
                this.Label13.BackColor = System.Drawing.Color.Transparent;
                this.Label13.Location = new System.Drawing.Point(275, 150);
                this.Label13.Name = "Label13";
                this.Label13.Size = new System.Drawing.Size(32, 13);
                this.Label13.TabIndex = 25;
                this.Label13.Text = "تعليق";
                // 
                // Label12
                // 
                this.Label12.AutoSize = true;
                this.Label12.ForeColor = System.Drawing.Color.Red;
                this.Label12.Location = new System.Drawing.Point(3, 241);
                this.Label12.Name = "Label12";
                this.Label12.Size = new System.Drawing.Size(122, 13);
                this.Label12.TabIndex = 26;
                this.Label12.Text = "Maximum file size is 50M";
                // 
                // Label21
                // 
                this.Label21.AutoSize = true;
                this.Label21.BackColor = System.Drawing.Color.Transparent;
                this.Label21.Location = new System.Drawing.Point(239, 92);
                this.Label21.Name = "Label21";
                this.Label21.Size = new System.Drawing.Size(68, 13);
                this.Label21.TabIndex = 26;
                this.Label21.Text = "اسم المستخدم";
                // 
                // Label22
                // 
                this.Label22.AutoSize = true;
                this.Label22.BackColor = System.Drawing.Color.Transparent;
                this.Label22.Location = new System.Drawing.Point(269, 66);
                this.Label22.Name = "Label22";
                this.Label22.Size = new System.Drawing.Size(38, 13);
                this.Label22.TabIndex = 19;
                this.Label22.Text = "التاريخ";
                // 
                // Label23
                // 
                this.Label23.AutoSize = true;
                this.Label23.BackColor = System.Drawing.Color.Transparent;
                this.Label23.Location = new System.Drawing.Point(271, 40);
                this.Label23.Name = "Label23";
                this.Label23.Size = new System.Drawing.Size(36, 13);
                this.Label23.TabIndex = 18;
                this.Label23.Text = "المسار";
                // 
                // Label24
                // 
                this.Label24.AutoSize = true;
                this.Label24.BackColor = System.Drawing.Color.Transparent;
                this.Label24.Location = new System.Drawing.Point(257, 14);
                this.Label24.Name = "Label24";
                this.Label24.Size = new System.Drawing.Size(50, 13);
                this.Label24.TabIndex = 20;
                this.Label24.Text = "اسم الملف";
                // 
                // TxtNewFileDesc
                // 
                this.TxtNewFileDesc.Location = new System.Drawing.Point(12, 147);
                this.TxtNewFileDesc.MaxLength = 20;
                this.TxtNewFileDesc.Multiline = true;
                this.TxtNewFileDesc.Name = "TxtNewFileDesc";
                this.TxtNewFileDesc.Size = new System.Drawing.Size(227, 70);
                this.TxtNewFileDesc.TabIndex = 4;
                // 
                // FilesTabPage
                // 
                this.FilesTabPage.BackColor = System.Drawing.Color.Transparent;
                this.FilesTabPage.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
                this.FilesTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.FilesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.FilesTabPage.Controls.Add(this.CBEditFileType);
                this.FilesTabPage.Controls.Add(this.Label25);
                this.FilesTabPage.Controls.Add(this.BtnEditFileName);
                this.FilesTabPage.Controls.Add(this.LblUser);
                this.FilesTabPage.Controls.Add(this.BtnSaveFile);
                this.FilesTabPage.Controls.Add(this.LblDate);
                this.FilesTabPage.Controls.Add(this.LblFilePath);
                this.FilesTabPage.Controls.Add(this.Label15);
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
                // CBEditFileType
                // 
                this.CBEditFileType.DisplayMember = "TypeName";
                this.CBEditFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.CBEditFileType.FormattingEnabled = true;
                this.CBEditFileType.Location = new System.Drawing.Point(67, 116);
                this.CBEditFileType.Name = "CBEditFileType";
                this.CBEditFileType.Size = new System.Drawing.Size(169, 21);
                this.CBEditFileType.TabIndex = 28;
                this.CBEditFileType.ValueMember = "TypeID";
                // 
                // Label25
                // 
                this.Label25.AutoSize = true;
                this.Label25.BackColor = System.Drawing.Color.Transparent;
                this.Label25.Location = new System.Drawing.Point(257, 119);
                this.Label25.Name = "Label25";
                this.Label25.Size = new System.Drawing.Size(50, 13);
                this.Label25.TabIndex = 27;
                this.Label25.Text = "نوع الملف";
                // 
                // BtnEditFileName
                // 
                this.BtnEditFileName.Location = new System.Drawing.Point(9, 9);
                this.BtnEditFileName.Name = "BtnEditFileName";
                this.BtnEditFileName.Size = new System.Drawing.Size(56, 23);
                this.BtnEditFileName.TabIndex = 2;
                this.BtnEditFileName.Text = "تعديل";
                this.BtnEditFileName.UseVisualStyleBackColor = true;
                this.BtnEditFileName.Click += new System.EventHandler(this.BtnEditFileName_Click);
                // 
                // LblUser
                // 
                this.LblUser.AutoSize = true;
                this.LblUser.BackColor = System.Drawing.Color.Transparent;
                this.LblUser.Location = new System.Drawing.Point(30, 92);
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
                this.BtnSaveFile.Text = "حفظ";
                this.BtnSaveFile.UseVisualStyleBackColor = true;
                this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
                // 
                // LblDate
                // 
                this.LblDate.AutoSize = true;
                this.LblDate.BackColor = System.Drawing.Color.Transparent;
                this.LblDate.Location = new System.Drawing.Point(30, 66);
                this.LblDate.Name = "LblDate";
                this.LblDate.Size = new System.Drawing.Size(53, 13);
                this.LblDate.TabIndex = 10;
                this.LblDate.Text = "1/1/2000";
                // 
                // LblFilePath
                // 
                this.LblFilePath.AutoSize = true;
                this.LblFilePath.BackColor = System.Drawing.Color.Transparent;
                this.LblFilePath.Location = new System.Drawing.Point(30, 40);
                this.LblFilePath.Name = "LblFilePath";
                this.LblFilePath.Size = new System.Drawing.Size(21, 13);
                this.LblFilePath.TabIndex = 9;
                this.LblFilePath.Text = "c:\\";
                // 
                // Label15
                // 
                this.Label15.AutoSize = true;
                this.Label15.BackColor = System.Drawing.Color.Transparent;
                this.Label15.Location = new System.Drawing.Point(269, 148);
                this.Label15.Name = "Label15";
                this.Label15.Size = new System.Drawing.Size(38, 13);
                this.Label15.TabIndex = 11;
                this.Label15.Text = "التعليق";
                // 
                // Label17
                // 
                this.Label17.AutoSize = true;
                this.Label17.BackColor = System.Drawing.Color.Transparent;
                this.Label17.Location = new System.Drawing.Point(239, 92);
                this.Label17.Name = "Label17";
                this.Label17.Size = new System.Drawing.Size(68, 13);
                this.Label17.TabIndex = 12;
                this.Label17.Text = "اسم المستخدم";
                // 
                // Label18
                // 
                this.Label18.AutoSize = true;
                this.Label18.BackColor = System.Drawing.Color.Transparent;
                this.Label18.Location = new System.Drawing.Point(269, 66);
                this.Label18.Name = "Label18";
                this.Label18.Size = new System.Drawing.Size(38, 13);
                this.Label18.TabIndex = 5;
                this.Label18.Text = "التاريخ";
                // 
                // Label19
                // 
                this.Label19.AutoSize = true;
                this.Label19.BackColor = System.Drawing.Color.Transparent;
                this.Label19.Location = new System.Drawing.Point(251, 40);
                this.Label19.Name = "Label19";
                this.Label19.Size = new System.Drawing.Size(56, 13);
                this.Label19.TabIndex = 4;
                this.Label19.Text = "مسار الملف";
                // 
                // Label20
                // 
                this.Label20.AutoSize = true;
                this.Label20.BackColor = System.Drawing.Color.Transparent;
                this.Label20.Location = new System.Drawing.Point(257, 14);
                this.Label20.Name = "Label20";
                this.Label20.Size = new System.Drawing.Size(50, 13);
                this.Label20.TabIndex = 6;
                this.Label20.Text = "اسم الملف";
                // 
                // TxtDisc
                // 
                this.TxtDisc.Location = new System.Drawing.Point(9, 145);
                this.TxtDisc.MaxLength = 20;
                this.TxtDisc.Multiline = true;
                this.TxtDisc.Name = "TxtDisc";
                this.TxtDisc.Size = new System.Drawing.Size(227, 68);
                this.TxtDisc.TabIndex = 3;
                // 
                // TxtFileName
                // 
                this.TxtFileName.Enabled = false;
                this.TxtFileName.Location = new System.Drawing.Point(71, 12);
                this.TxtFileName.MaxLength = 20;
                this.TxtFileName.Name = "TxtFileName";
                this.TxtFileName.Size = new System.Drawing.Size(165, 20);
                this.TxtFileName.TabIndex = 1;
                // 
                // FoldersTabPage
                // 
                this.FoldersTabPage.BackColor = System.Drawing.Color.White;
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
                this.FoldersTabPage.Location = new System.Drawing.Point(4, 22);
                this.FoldersTabPage.Name = "FoldersTabPage";
                this.FoldersTabPage.Padding = new System.Windows.Forms.Padding(3);
                this.FoldersTabPage.Size = new System.Drawing.Size(319, 285);
                this.FoldersTabPage.TabIndex = 0;
                this.FoldersTabPage.Text = "المجلدات";
                this.FoldersTabPage.UseVisualStyleBackColor = true;
                // 
                // BtnEditFolderName
                // 
                this.BtnEditFolderName.Location = new System.Drawing.Point(21, 9);
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
                this.BtnSaveFolder.Text = "حفظ";
                this.BtnSaveFolder.UseVisualStyleBackColor = true;
                this.BtnSaveFolder.Click += new System.EventHandler(this.BtnSaveFolder_Click);
                // 
                // LblFolderUser
                // 
                this.LblFolderUser.AutoSize = true;
                this.LblFolderUser.BackColor = System.Drawing.Color.Transparent;
                this.LblFolderUser.Location = new System.Drawing.Point(24, 92);
                this.LblFolderUser.Name = "LblFolderUser";
                this.LblFolderUser.Size = new System.Drawing.Size(47, 13);
                this.LblFolderUser.TabIndex = 1;
                this.LblFolderUser.Text = "Unkown";
                // 
                // LblFolderDate
                // 
                this.LblFolderDate.AutoSize = true;
                this.LblFolderDate.BackColor = System.Drawing.Color.Transparent;
                this.LblFolderDate.Location = new System.Drawing.Point(24, 66);
                this.LblFolderDate.Name = "LblFolderDate";
                this.LblFolderDate.Size = new System.Drawing.Size(53, 13);
                this.LblFolderDate.TabIndex = 1;
                this.LblFolderDate.Text = "1/1/2000";
                // 
                // LblFolderPath
                // 
                this.LblFolderPath.AutoSize = true;
                this.LblFolderPath.BackColor = System.Drawing.Color.Transparent;
                this.LblFolderPath.Location = new System.Drawing.Point(21, 40);
                this.LblFolderPath.Name = "LblFolderPath";
                this.LblFolderPath.Size = new System.Drawing.Size(21, 13);
                this.LblFolderPath.TabIndex = 1;
                this.LblFolderPath.Text = "c:\\";
                // 
                // Label10
                // 
                this.Label10.AutoSize = true;
                this.Label10.BackColor = System.Drawing.Color.Transparent;
                this.Label10.Location = new System.Drawing.Point(271, 119);
                this.Label10.Name = "Label10";
                this.Label10.Size = new System.Drawing.Size(32, 13);
                this.Label10.TabIndex = 1;
                this.Label10.Text = "تعليق";
                // 
                // Label6
                // 
                this.Label6.AutoSize = true;
                this.Label6.BackColor = System.Drawing.Color.Transparent;
                this.Label6.Location = new System.Drawing.Point(241, 92);
                this.Label6.Name = "Label6";
                this.Label6.Size = new System.Drawing.Size(68, 13);
                this.Label6.TabIndex = 1;
                this.Label6.Text = "اسم المستخدم";
                // 
                // Label4
                // 
                this.Label4.AutoSize = true;
                this.Label4.BackColor = System.Drawing.Color.Transparent;
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
                this.Label2.Location = new System.Drawing.Point(250, 40);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(59, 13);
                this.Label2.TabIndex = 1;
                this.Label2.Text = "مسار المجلد";
                // 
                // Label1
                // 
                this.Label1.AutoSize = true;
                this.Label1.BackColor = System.Drawing.Color.Transparent;
                this.Label1.Location = new System.Drawing.Point(256, 14);
                this.Label1.Name = "Label1";
                this.Label1.Size = new System.Drawing.Size(53, 13);
                this.Label1.TabIndex = 1;
                this.Label1.Text = "اسم المجلد";
                // 
                // TxtFolderDisc
                // 
                this.TxtFolderDisc.Location = new System.Drawing.Point(24, 119);
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
                // FoldersFilesTabControl
                // 
                this.FoldersFilesTabControl.Controls.Add(this.FoldersTabPage);
                this.FoldersFilesTabControl.Controls.Add(this.FilesTabPage);
                this.FoldersFilesTabControl.Controls.Add(this.NewFileTabPage);
                this.FoldersFilesTabControl.Controls.Add(this.NewFolderTabPage);
                this.FoldersFilesTabControl.Location = new System.Drawing.Point(5, 6);
                this.FoldersFilesTabControl.Name = "FoldersFilesTabControl";
                this.FoldersFilesTabControl.SelectedIndex = 0;
                this.FoldersFilesTabControl.Size = new System.Drawing.Size(327, 311);
                this.FoldersFilesTabControl.TabIndex = 0;
                // 
                // ObjectPropertyFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.ClientSize = new System.Drawing.Size(336, 351);
                this.Controls.Add(this.BtnCancel);
                this.Controls.Add(this.FoldersFilesTabControl);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "ObjectPropertyFrm";
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "خصائص المجلدات و الملفات";
                this.NewFolderTabPage.ResumeLayout(false);
                this.NewFolderTabPage.PerformLayout();
                this.NewFileTabPage.ResumeLayout(false);
                this.NewFileTabPage.PerformLayout();
                this.FilesTabPage.ResumeLayout(false);
                this.FilesTabPage.PerformLayout();
                this.FoldersTabPage.ResumeLayout(false);
                this.FoldersTabPage.PerformLayout();
                this.FoldersFilesTabControl.ResumeLayout(false);
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Button BtnCancel;
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
		internal System.Windows.Forms.TabPage NewFileTabPage;
		internal System.Windows.Forms.ProgressBar NewFileProgressBar;
		internal System.Windows.Forms.TextBox TxtNewFileName;
		internal System.Windows.Forms.ComboBox FileTypeCB;
        internal System.Windows.Forms.Button BtnBrowseNewFile;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Button BtnSaveNewFile;
		internal System.Windows.Forms.Label LblNewFileDate;
		internal System.Windows.Forms.Label LblNewFilePath;
		internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.TextBox TxtNewFileDesc;
		internal System.Windows.Forms.TabPage FilesTabPage;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Button BtnEditFileName;
		internal System.Windows.Forms.Label LblUser;
		internal System.Windows.Forms.Button BtnSaveFile;
		internal System.Windows.Forms.Label LblDate;
		internal System.Windows.Forms.Label LblFilePath;
        internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox TxtDisc;
		internal System.Windows.Forms.TextBox TxtFileName;
		internal System.Windows.Forms.TabPage FoldersTabPage;
        internal System.Windows.Forms.Button BtnEditFolderName;
		internal System.Windows.Forms.Button BtnSaveFolder;
		internal System.Windows.Forms.Label LblFolderUser;
		internal System.Windows.Forms.Label LblFolderDate;
		internal System.Windows.Forms.Label LblFolderPath;
        internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TxtFolderDisc;
		internal System.Windows.Forms.TextBox TxtFolderName;
		internal System.Windows.Forms.TabControl FoldersFilesTabControl;
        internal ComboBox CBEditFileType;
	}
	
}
