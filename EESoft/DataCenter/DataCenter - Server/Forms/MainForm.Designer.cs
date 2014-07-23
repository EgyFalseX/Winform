using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class MainForm : System.Windows.Forms.Form
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
                this.components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                this.MenuStrip = new System.Windows.Forms.MenuStrip();
                this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
                this.NewProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
                this.RestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
                this.ToolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.StatusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
                this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.UsersManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.CreateNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.EditUserPriviligeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.RemoveUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.DataManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.FileCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.RestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.BackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.FilesTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.AddNewFileTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.FilesTypesEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.PrivilegesEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.UnLockFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.stuFileTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
                this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
                this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.ToolStrip = new System.Windows.Forms.ToolStrip();
                this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
                this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                this.ListViewToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
                this.LargeIconListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.DetailsListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.SmallIconListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.ListListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                this.StatusStrip = new System.Windows.Forms.StatusStrip();
                this.FoldersToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
                this.FoldersToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
                this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
                this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
                this.TVGFoldersGeneral = new System.Windows.Forms.TreeView();
                this.FoldersCMGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
                this.CreateFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.FoldersRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.FoldersPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.IconsList = new System.Windows.Forms.ImageList(this.components);
                this.MainImageList = new System.Windows.Forms.ImageList(this.components);
                this.SplitContainer = new System.Windows.Forms.SplitContainer();
                this.TControlLeft = new System.Windows.Forms.TabControl();
                this.TPageGeneralLeft = new System.Windows.Forms.TabPage();
                this.TPageStudentLeft = new System.Windows.Forms.TabPage();
                this.TVFoldersStudent = new System.Windows.Forms.TreeView();
                this.TPageEmpLeft = new System.Windows.Forms.TabPage();
                this.TVFoldersEmp = new System.Windows.Forms.TreeView();
                this.TControlRight = new System.Windows.Forms.TabControl();
                this.TabPageGeneralRight = new System.Windows.Forms.TabPage();
                this.LVFilesGeneral = new System.Windows.Forms.ListView();
                this.ColHDFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.ColHDCreatedIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.ColHDCreatedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.ColHDFileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.FilesCMGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
                this.AddFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.FilesRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.FilesPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.TPageStudentRight = new System.Windows.Forms.TabPage();
                this.groupBox1 = new System.Windows.Forms.GroupBox();
                this.groupBox3 = new System.Windows.Forms.GroupBox();
                this.TxtStudentsearch = new System.Windows.Forms.TextBox();
                this.BtnStudentsearch = new System.Windows.Forms.Button();
                this.CBFasl = new System.Windows.Forms.ComboBox();
                this.label3 = new System.Windows.Forms.Label();
                this.CBStudent = new System.Windows.Forms.ComboBox();
                this.label4 = new System.Windows.Forms.Label();
                this.CBSaf = new System.Windows.Forms.ComboBox();
                this.label2 = new System.Windows.Forms.Label();
                this.CBYear = new System.Windows.Forms.ComboBox();
                this.label1 = new System.Windows.Forms.Label();
                this.LVFilesStudent = new System.Windows.Forms.ListView();
                this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.chstu_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.chStuFileTypeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.chasase_year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.chalsofof_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.chfasl_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.chDis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.chCreatedIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.chUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.FilesCMStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
                this.TSMIStuAddFiles = new System.Windows.Forms.ToolStripMenuItem();
                this.tSMIStuTransfer = new System.Windows.Forms.ToolStripMenuItem();
                this.TSMIStuDelFiles = new System.Windows.Forms.ToolStripMenuItem();
                this.TSMIStuProbFiles = new System.Windows.Forms.ToolStripMenuItem();
                this.IconsListStu = new System.Windows.Forms.ImageList(this.components);
                this.TPageEmpRight = new System.Windows.Forms.TabPage();
                this.groupBox2 = new System.Windows.Forms.GroupBox();
                this.groupBox4 = new System.Windows.Forms.GroupBox();
                this.TxtEmpSearch = new System.Windows.Forms.TextBox();
                this.BtnEmpSearch = new System.Windows.Forms.Button();
                this.CBEmp = new System.Windows.Forms.ComboBox();
                this.label6 = new System.Windows.Forms.Label();
                this.LVFilesEmp = new System.Windows.Forms.ListView();
                this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                this.FilesCMEmp = new System.Windows.Forms.ContextMenuStrip(this.components);
                this.TSMIEmpAddFiles = new System.Windows.Forms.ToolStripMenuItem();
                this.tSMIEmpTransfer = new System.Windows.Forms.ToolStripMenuItem();
                this.TSMIEmpDelFiles = new System.Windows.Forms.ToolStripMenuItem();
                this.TSMIEmpProbFiles = new System.Windows.Forms.ToolStripMenuItem();
                this.MenuStrip.SuspendLayout();
                this.ToolStrip.SuspendLayout();
                this.StatusStrip.SuspendLayout();
                this.FoldersCMGeneral.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
                this.SplitContainer.Panel1.SuspendLayout();
                this.SplitContainer.Panel2.SuspendLayout();
                this.SplitContainer.SuspendLayout();
                this.TControlLeft.SuspendLayout();
                this.TPageGeneralLeft.SuspendLayout();
                this.TPageStudentLeft.SuspendLayout();
                this.TPageEmpLeft.SuspendLayout();
                this.TControlRight.SuspendLayout();
                this.TabPageGeneralRight.SuspendLayout();
                this.FilesCMGeneral.SuspendLayout();
                this.TPageStudentRight.SuspendLayout();
                this.groupBox1.SuspendLayout();
                this.groupBox3.SuspendLayout();
                this.FilesCMStudent.SuspendLayout();
                this.TPageEmpRight.SuspendLayout();
                this.groupBox2.SuspendLayout();
                this.groupBox4.SuspendLayout();
                this.FilesCMEmp.SuspendLayout();
                this.SuspendLayout();
                // 
                // MenuStrip
                // 
                this.MenuStrip.BackColor = System.Drawing.Color.Black;
                this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ViewMenu,
            this.ToolsMenu,
            this.HelpMenu});
                this.MenuStrip.Location = new System.Drawing.Point(0, 0);
                this.MenuStrip.Name = "MenuStrip";
                this.MenuStrip.Size = new System.Drawing.Size(904, 24);
                this.MenuStrip.TabIndex = 5;
                this.MenuStrip.Text = "MenuStrip";
                // 
                // FileMenu
                // 
                this.FileMenu.BackColor = System.Drawing.Color.Navy;
                this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProjectToolStripMenuItem,
            this.ToolStripSeparator5,
            this.RestartToolStripMenuItem,
            this.ExitToolStripMenuItem});
                this.FileMenu.ForeColor = System.Drawing.Color.White;
                this.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
                this.FileMenu.Name = "FileMenu";
                this.FileMenu.Size = new System.Drawing.Size(36, 20);
                this.FileMenu.Text = "ملف";
                // 
                // NewProjectToolStripMenuItem
                // 
                this.NewProjectToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.NewProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.NewProjectToolStripMenuItem.Image = global::My.Resources.Resources.Default_;
                this.NewProjectToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
                this.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem";
                this.NewProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
                this.NewProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
                this.NewProjectToolStripMenuItem.Text = "جديد";
                this.NewProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Clieck);
                // 
                // ToolStripSeparator5
                // 
                this.ToolStripSeparator5.BackColor = System.Drawing.Color.DarkGray;
                this.ToolStripSeparator5.Name = "ToolStripSeparator5";
                this.ToolStripSeparator5.Size = new System.Drawing.Size(135, 6);
                // 
                // RestartToolStripMenuItem
                // 
                this.RestartToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.RestartToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.RestartToolStripMenuItem.Image = global::My.Resources.Resources.Restart;
                this.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
                this.RestartToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
                this.RestartToolStripMenuItem.Text = "اعادة التشغيل";
                this.RestartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
                // 
                // ExitToolStripMenuItem
                // 
                this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.ExitToolStripMenuItem.Image = global::My.Resources.Resources.Exit_;
                this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
                this.ExitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
                this.ExitToolStripMenuItem.Text = "خروج";
                this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
                // 
                // ViewMenu
                // 
                this.ViewMenu.BackColor = System.Drawing.Color.Navy;
                this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarToolStripMenuItem,
            this.StatusBarToolStripMenuItem});
                this.ViewMenu.ForeColor = System.Drawing.Color.White;
                this.ViewMenu.Name = "ViewMenu";
                this.ViewMenu.Size = new System.Drawing.Size(45, 20);
                this.ViewMenu.Text = "عرض";
                // 
                // ToolBarToolStripMenuItem
                // 
                this.ToolBarToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.ToolBarToolStripMenuItem.Checked = true;
                this.ToolBarToolStripMenuItem.CheckOnClick = true;
                this.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
                this.ToolBarToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem";
                this.ToolBarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
                this.ToolBarToolStripMenuItem.Text = "شريط الادوات";
                this.ToolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
                // 
                // StatusBarToolStripMenuItem
                // 
                this.StatusBarToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.StatusBarToolStripMenuItem.Checked = true;
                this.StatusBarToolStripMenuItem.CheckOnClick = true;
                this.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
                this.StatusBarToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem";
                this.StatusBarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
                this.StatusBarToolStripMenuItem.Text = "شريط الحاله";
                this.StatusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
                // 
                // ToolsMenu
                // 
                this.ToolsMenu.BackColor = System.Drawing.Color.Navy;
                this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem,
            this.UsersManagerToolStripMenuItem,
            this.DataManagerToolStripMenuItem,
            this.FilesTypesToolStripMenuItem,
            this.PrivilegesEditorToolStripMenuItem,
            this.UnLockFilesToolStripMenuItem,
            this.stuFileTypeToolStripMenuItem});
                this.ToolsMenu.ForeColor = System.Drawing.Color.White;
                this.ToolsMenu.Name = "ToolsMenu";
                this.ToolsMenu.Size = new System.Drawing.Size(43, 20);
                this.ToolsMenu.Text = "ادوات";
                // 
                // OptionsToolStripMenuItem
                // 
                this.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.OptionsToolStripMenuItem.Image = global::My.Resources.Resources.Options;
                this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
                this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
                this.OptionsToolStripMenuItem.Text = "خيارات";
                this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
                // 
                // UsersManagerToolStripMenuItem
                // 
                this.UsersManagerToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.UsersManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewUserToolStripMenuItem,
            this.EditUserPriviligeToolStripMenuItem,
            this.RemoveUserToolStripMenuItem});
                this.UsersManagerToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.UsersManagerToolStripMenuItem.Image = global::My.Resources.Resources.Users;
                this.UsersManagerToolStripMenuItem.Name = "UsersManagerToolStripMenuItem";
                this.UsersManagerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
                this.UsersManagerToolStripMenuItem.Text = "المستخدمين";
                // 
                // CreateNewUserToolStripMenuItem
                // 
                this.CreateNewUserToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.CreateNewUserToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.CreateNewUserToolStripMenuItem.Image = global::My.Resources.Resources.Edit;
                this.CreateNewUserToolStripMenuItem.Name = "CreateNewUserToolStripMenuItem";
                this.CreateNewUserToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
                this.CreateNewUserToolStripMenuItem.Text = "اضافه";
                this.CreateNewUserToolStripMenuItem.Click += new System.EventHandler(this.CreateNewUserToolStripMenuItem_Click);
                // 
                // EditUserPriviligeToolStripMenuItem
                // 
                this.EditUserPriviligeToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.EditUserPriviligeToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.EditUserPriviligeToolStripMenuItem.Image = global::My.Resources.Resources.Edit;
                this.EditUserPriviligeToolStripMenuItem.Name = "EditUserPriviligeToolStripMenuItem";
                this.EditUserPriviligeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
                this.EditUserPriviligeToolStripMenuItem.Text = "سماحيات المستخدمين";
                this.EditUserPriviligeToolStripMenuItem.Click += new System.EventHandler(this.EditUserPriviligeToolStripMenuItem_Click);
                // 
                // RemoveUserToolStripMenuItem
                // 
                this.RemoveUserToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.RemoveUserToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.RemoveUserToolStripMenuItem.Image = global::My.Resources.Resources.Remove;
                this.RemoveUserToolStripMenuItem.Name = "RemoveUserToolStripMenuItem";
                this.RemoveUserToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
                this.RemoveUserToolStripMenuItem.Text = "حذف";
                this.RemoveUserToolStripMenuItem.Click += new System.EventHandler(this.RemoveUserToolStripMenuItem_Click);
                // 
                // DataManagerToolStripMenuItem
                // 
                this.DataManagerToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.DataManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileCheckerToolStripMenuItem,
            this.RestoreToolStripMenuItem,
            this.BackupToolStripMenuItem});
                this.DataManagerToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.DataManagerToolStripMenuItem.Image = global::My.Resources.Resources.Data;
                this.DataManagerToolStripMenuItem.Name = "DataManagerToolStripMenuItem";
                this.DataManagerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
                this.DataManagerToolStripMenuItem.Text = "البيانات";
                // 
                // FileCheckerToolStripMenuItem
                // 
                this.FileCheckerToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.FileCheckerToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.FileCheckerToolStripMenuItem.Name = "FileCheckerToolStripMenuItem";
                this.FileCheckerToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
                this.FileCheckerToolStripMenuItem.Text = "فحص الملفات";
                this.FileCheckerToolStripMenuItem.Click += new System.EventHandler(this.FileCheckerToolStripMenuItem_Click);
                // 
                // RestoreToolStripMenuItem
                // 
                this.RestoreToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.RestoreToolStripMenuItem.Enabled = false;
                this.RestoreToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem";
                this.RestoreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
                this.RestoreToolStripMenuItem.Text = "Restore";
                // 
                // BackupToolStripMenuItem
                // 
                this.BackupToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.BackupToolStripMenuItem.Enabled = false;
                this.BackupToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem";
                this.BackupToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
                this.BackupToolStripMenuItem.Text = "Backup";
                // 
                // FilesTypesToolStripMenuItem
                // 
                this.FilesTypesToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.FilesTypesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewFileTypeToolStripMenuItem,
            this.FilesTypesEditorToolStripMenuItem});
                this.FilesTypesToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.FilesTypesToolStripMenuItem.Image = global::My.Resources.Resources.files_Types;
                this.FilesTypesToolStripMenuItem.Name = "FilesTypesToolStripMenuItem";
                this.FilesTypesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
                this.FilesTypesToolStripMenuItem.Text = "انواع الملفات";
                // 
                // AddNewFileTypeToolStripMenuItem
                // 
                this.AddNewFileTypeToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.AddNewFileTypeToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.AddNewFileTypeToolStripMenuItem.Image = global::My.Resources.Resources.add;
                this.AddNewFileTypeToolStripMenuItem.Name = "AddNewFileTypeToolStripMenuItem";
                this.AddNewFileTypeToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
                this.AddNewFileTypeToolStripMenuItem.Text = "اضافه";
                this.AddNewFileTypeToolStripMenuItem.Click += new System.EventHandler(this.AddNewFileTypeToolStripMenuItem_Click);
                // 
                // FilesTypesEditorToolStripMenuItem
                // 
                this.FilesTypesEditorToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.FilesTypesEditorToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.FilesTypesEditorToolStripMenuItem.Image = global::My.Resources.Resources.Edit;
                this.FilesTypesEditorToolStripMenuItem.Name = "FilesTypesEditorToolStripMenuItem";
                this.FilesTypesEditorToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
                this.FilesTypesEditorToolStripMenuItem.Text = "تعديل";
                this.FilesTypesEditorToolStripMenuItem.Click += new System.EventHandler(this.FilesTypesEditorToolStripMenuItem_Click);
                // 
                // PrivilegesEditorToolStripMenuItem
                // 
                this.PrivilegesEditorToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.PrivilegesEditorToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.PrivilegesEditorToolStripMenuItem.Image = global::My.Resources.Resources.Edit;
                this.PrivilegesEditorToolStripMenuItem.Name = "PrivilegesEditorToolStripMenuItem";
                this.PrivilegesEditorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
                this.PrivilegesEditorToolStripMenuItem.Text = "السماحيات";
                this.PrivilegesEditorToolStripMenuItem.Click += new System.EventHandler(this.PrivilegesEditorToolStripMenuItem_Click);
                // 
                // UnLockFilesToolStripMenuItem
                // 
                this.UnLockFilesToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.UnLockFilesToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.UnLockFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UnLockFilesToolStripMenuItem.Image")));
                this.UnLockFilesToolStripMenuItem.Name = "UnLockFilesToolStripMenuItem";
                this.UnLockFilesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
                this.UnLockFilesToolStripMenuItem.Text = "الملفات المغلقه";
                this.UnLockFilesToolStripMenuItem.Click += new System.EventHandler(this.UnLockFilesToolStripMenuItem_Click);
                // 
                // stuFileTypeToolStripMenuItem
                // 
                this.stuFileTypeToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.stuFileTypeToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.stuFileTypeToolStripMenuItem.Image = global::My.Resources.Resources.files_Types;
                this.stuFileTypeToolStripMenuItem.Name = "stuFileTypeToolStripMenuItem";
                this.stuFileTypeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
                this.stuFileTypeToolStripMenuItem.Text = "انواع ملفات الطلاب و العاملين";
                this.stuFileTypeToolStripMenuItem.Click += new System.EventHandler(this.stuFileTypeToolStripMenuItem_Click);
                // 
                // HelpMenu
                // 
                this.HelpMenu.BackColor = System.Drawing.Color.Navy;
                this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem,
            this.ToolStripSeparator8,
            this.AboutToolStripMenuItem});
                this.HelpMenu.ForeColor = System.Drawing.Color.White;
                this.HelpMenu.Name = "HelpMenu";
                this.HelpMenu.Size = new System.Drawing.Size(54, 20);
                this.HelpMenu.Text = "مساعده";
                // 
                // HelpToolStripMenuItem
                // 
                this.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.HelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripMenuItem.Image")));
                this.HelpToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
                this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
                this.HelpToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
                this.HelpToolStripMenuItem.Text = "الشرح";
                // 
                // ToolStripSeparator8
                // 
                this.ToolStripSeparator8.BackColor = System.Drawing.Color.White;
                this.ToolStripSeparator8.Name = "ToolStripSeparator8";
                this.ToolStripSeparator8.Size = new System.Drawing.Size(125, 6);
                // 
                // AboutToolStripMenuItem
                // 
                this.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
                this.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
                this.AboutToolStripMenuItem.Image = global::My.Resources.Resources.About;
                this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
                this.AboutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
                this.AboutToolStripMenuItem.Text = "عن البرنامج";
                // 
                // ToolStrip
                // 
                this.ToolStrip.BackColor = System.Drawing.Color.DarkGray;
                this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.ToolStripSeparator1,
            this.ListViewToolStripDropDownButton,
            this.ToolStripSeparator2});
                this.ToolStrip.Location = new System.Drawing.Point(0, 24);
                this.ToolStrip.Name = "ToolStrip";
                this.ToolStrip.Size = new System.Drawing.Size(904, 25);
                this.ToolStrip.TabIndex = 3;
                this.ToolStrip.Text = "ToolStrip";
                // 
                // NewToolStripButton
                // 
                this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
                this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
                this.NewToolStripButton.Name = "NewToolStripButton";
                this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
                this.NewToolStripButton.Text = "جديد";
                this.NewToolStripButton.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Clieck);
                // 
                // ToolStripSeparator1
                // 
                this.ToolStripSeparator1.Name = "ToolStripSeparator1";
                this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
                // 
                // ListViewToolStripDropDownButton
                // 
                this.ListViewToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LargeIconListViewToolStripMenuItem,
            this.DetailsListViewToolStripMenuItem,
            this.SmallIconListViewToolStripMenuItem,
            this.ListListViewToolStripMenuItem});
                this.ListViewToolStripDropDownButton.Image = global::My.Resources.Resources.FIle_List_Style;
                this.ListViewToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Black;
                this.ListViewToolStripDropDownButton.Name = "ListViewToolStripDropDownButton";
                this.ListViewToolStripDropDownButton.Size = new System.Drawing.Size(89, 22);
                this.ListViewToolStripDropDownButton.Text = "طرق العرض";
                // 
                // LargeIconListViewToolStripMenuItem
                // 
                this.LargeIconListViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                this.LargeIconListViewToolStripMenuItem.Name = "LargeIconListViewToolStripMenuItem";
                this.LargeIconListViewToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
                this.LargeIconListViewToolStripMenuItem.Text = "كبير";
                this.LargeIconListViewToolStripMenuItem.Click += new System.EventHandler(this.LargeIconListViewToolStripMenuItem_Click);
                // 
                // DetailsListViewToolStripMenuItem
                // 
                this.DetailsListViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                this.DetailsListViewToolStripMenuItem.Name = "DetailsListViewToolStripMenuItem";
                this.DetailsListViewToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
                this.DetailsListViewToolStripMenuItem.Text = "تفصيلي";
                this.DetailsListViewToolStripMenuItem.Click += new System.EventHandler(this.DetailsListViewToolStripMenuItem_Click);
                // 
                // SmallIconListViewToolStripMenuItem
                // 
                this.SmallIconListViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                this.SmallIconListViewToolStripMenuItem.Name = "SmallIconListViewToolStripMenuItem";
                this.SmallIconListViewToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
                this.SmallIconListViewToolStripMenuItem.Text = "صغير";
                this.SmallIconListViewToolStripMenuItem.Click += new System.EventHandler(this.SmallIconListViewToolStripMenuItem_Click);
                // 
                // ListListViewToolStripMenuItem
                // 
                this.ListListViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                this.ListListViewToolStripMenuItem.Name = "ListListViewToolStripMenuItem";
                this.ListListViewToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
                this.ListListViewToolStripMenuItem.Text = "قائمه";
                this.ListListViewToolStripMenuItem.Click += new System.EventHandler(this.ListListViewToolStripMenuItem_Click);
                // 
                // ToolStripSeparator2
                // 
                this.ToolStripSeparator2.Name = "ToolStripSeparator2";
                this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
                // 
                // StatusStrip
                // 
                this.StatusStrip.BackColor = System.Drawing.Color.DarkGray;
                this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FoldersToolStripStatusLabel,
            this.FoldersToolStripProgressBar});
                this.StatusStrip.Location = new System.Drawing.Point(0, 599);
                this.StatusStrip.Name = "StatusStrip";
                this.StatusStrip.Size = new System.Drawing.Size(904, 22);
                this.StatusStrip.TabIndex = 7;
                this.StatusStrip.Text = "StatusStrip";
                // 
                // FoldersToolStripStatusLabel
                // 
                this.FoldersToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
                this.FoldersToolStripStatusLabel.Name = "FoldersToolStripStatusLabel";
                this.FoldersToolStripStatusLabel.Size = new System.Drawing.Size(70, 17);
                this.FoldersToolStripStatusLabel.Text = "تحميل الشجره";
                this.FoldersToolStripStatusLabel.Visible = false;
                // 
                // FoldersToolStripProgressBar
                // 
                this.FoldersToolStripProgressBar.Name = "FoldersToolStripProgressBar";
                this.FoldersToolStripProgressBar.Size = new System.Drawing.Size(150, 16);
                this.FoldersToolStripProgressBar.ToolTipText = "Loading Folders";
                this.FoldersToolStripProgressBar.Visible = false;
                // 
                // ToolStripStatusLabel
                // 
                this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
                this.ToolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
                this.ToolStripStatusLabel.Text = "Status";
                // 
                // TVGFoldersGeneral
                // 
                this.TVGFoldersGeneral.BackColor = System.Drawing.Color.DimGray;
                this.TVGFoldersGeneral.ContextMenuStrip = this.FoldersCMGeneral;
                this.TVGFoldersGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TVGFoldersGeneral.ForeColor = System.Drawing.Color.Lime;
                this.TVGFoldersGeneral.HideSelection = false;
                this.TVGFoldersGeneral.ImageIndex = 0;
                this.TVGFoldersGeneral.ImageList = this.IconsList;
                this.TVGFoldersGeneral.Location = new System.Drawing.Point(3, 3);
                this.TVGFoldersGeneral.Name = "TVGFoldersGeneral";
                this.TVGFoldersGeneral.SelectedImageIndex = 0;
                this.TVGFoldersGeneral.Size = new System.Drawing.Size(181, 500);
                this.TVGFoldersGeneral.TabIndex = 0;
                this.TVGFoldersGeneral.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVFolders_AfterSelect);
                // 
                // FoldersCMGeneral
                // 
                this.FoldersCMGeneral.BackColor = System.Drawing.Color.LightGray;
                this.FoldersCMGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFolderToolStripMenuItem,
            this.FoldersRemoveToolStripMenuItem,
            this.FoldersPropertiesToolStripMenuItem});
                this.FoldersCMGeneral.Name = "CMenuTree";
                this.FoldersCMGeneral.Size = new System.Drawing.Size(123, 70);
                // 
                // CreateFolderToolStripMenuItem
                // 
                this.CreateFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CreateFolderToolStripMenuItem.Image")));
                this.CreateFolderToolStripMenuItem.Name = "CreateFolderToolStripMenuItem";
                this.CreateFolderToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
                this.CreateFolderToolStripMenuItem.Text = "انشاء مجلد";
                this.CreateFolderToolStripMenuItem.Click += new System.EventHandler(this.CreateFolderToolStripMenuItem_Click);
                // 
                // FoldersRemoveToolStripMenuItem
                // 
                this.FoldersRemoveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FoldersRemoveToolStripMenuItem.Image")));
                this.FoldersRemoveToolStripMenuItem.Name = "FoldersRemoveToolStripMenuItem";
                this.FoldersRemoveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
                this.FoldersRemoveToolStripMenuItem.Text = "حذف";
                this.FoldersRemoveToolStripMenuItem.Click += new System.EventHandler(this.FoldersRemoveToolStripMenuItem_Click);
                // 
                // FoldersPropertiesToolStripMenuItem
                // 
                this.FoldersPropertiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FoldersPropertiesToolStripMenuItem.Image")));
                this.FoldersPropertiesToolStripMenuItem.Name = "FoldersPropertiesToolStripMenuItem";
                this.FoldersPropertiesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
                this.FoldersPropertiesToolStripMenuItem.Text = "خصائص";
                this.FoldersPropertiesToolStripMenuItem.Click += new System.EventHandler(this.FoldersPropertiesToolStripMenuItem_Click);
                // 
                // IconsList
                // 
                this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
                this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
                this.IconsList.Images.SetKeyName(0, "FoldersIcon.ico");
                this.IconsList.Images.SetKeyName(1, "Default.ico");
                // 
                // MainImageList
                // 
                this.MainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImageList.ImageStream")));
                this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
                this.MainImageList.Images.SetKeyName(0, "FoldersIcon.ico");
                this.MainImageList.Images.SetKeyName(1, "Default.ico");
                // 
                // SplitContainer
                // 
                this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
                this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
                this.SplitContainer.Location = new System.Drawing.Point(0, 49);
                this.SplitContainer.Name = "SplitContainer";
                // 
                // SplitContainer.Panel1
                // 
                this.SplitContainer.Panel1.AccessibleDescription = "Folders Tree";
                this.SplitContainer.Panel1.Controls.Add(this.TControlLeft);
                // 
                // SplitContainer.Panel2
                // 
                this.SplitContainer.Panel2.Controls.Add(this.TControlRight);
                this.SplitContainer.Size = new System.Drawing.Size(904, 550);
                this.SplitContainer.SplitterDistance = 195;
                this.SplitContainer.TabIndex = 1;
                // 
                // TControlLeft
                // 
                this.TControlLeft.Controls.Add(this.TPageGeneralLeft);
                this.TControlLeft.Controls.Add(this.TPageStudentLeft);
                this.TControlLeft.Controls.Add(this.TPageEmpLeft);
                this.TControlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TControlLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TControlLeft.Location = new System.Drawing.Point(0, 0);
                this.TControlLeft.Multiline = true;
                this.TControlLeft.Name = "TControlLeft";
                this.TControlLeft.SelectedIndex = 0;
                this.TControlLeft.Size = new System.Drawing.Size(195, 550);
                this.TControlLeft.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
                this.TControlLeft.TabIndex = 1;
                this.TControlLeft.Selected += new System.Windows.Forms.TabControlEventHandler(this.TControlLeft_Selected);
                // 
                // TPageGeneralLeft
                // 
                this.TPageGeneralLeft.Controls.Add(this.TVGFoldersGeneral);
                this.TPageGeneralLeft.Location = new System.Drawing.Point(4, 40);
                this.TPageGeneralLeft.Name = "TPageGeneralLeft";
                this.TPageGeneralLeft.Padding = new System.Windows.Forms.Padding(3);
                this.TPageGeneralLeft.Size = new System.Drawing.Size(187, 506);
                this.TPageGeneralLeft.TabIndex = 0;
                this.TPageGeneralLeft.Text = "ملفات عامه";
                this.TPageGeneralLeft.UseVisualStyleBackColor = true;
                // 
                // TPageStudentLeft
                // 
                this.TPageStudentLeft.Controls.Add(this.TVFoldersStudent);
                this.TPageStudentLeft.Location = new System.Drawing.Point(4, 40);
                this.TPageStudentLeft.Name = "TPageStudentLeft";
                this.TPageStudentLeft.Padding = new System.Windows.Forms.Padding(3);
                this.TPageStudentLeft.Size = new System.Drawing.Size(187, 506);
                this.TPageStudentLeft.TabIndex = 1;
                this.TPageStudentLeft.Text = "شئون طلاب";
                this.TPageStudentLeft.UseVisualStyleBackColor = true;
                // 
                // TVFoldersStudent
                // 
                this.TVFoldersStudent.BackColor = System.Drawing.Color.DimGray;
                this.TVFoldersStudent.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TVFoldersStudent.ForeColor = System.Drawing.Color.Lime;
                this.TVFoldersStudent.HideSelection = false;
                this.TVFoldersStudent.ImageIndex = 0;
                this.TVFoldersStudent.ImageList = this.IconsList;
                this.TVFoldersStudent.Location = new System.Drawing.Point(3, 3);
                this.TVFoldersStudent.Name = "TVFoldersStudent";
                this.TVFoldersStudent.SelectedImageIndex = 0;
                this.TVFoldersStudent.Size = new System.Drawing.Size(181, 500);
                this.TVFoldersStudent.TabIndex = 1;
                // 
                // TPageEmpLeft
                // 
                this.TPageEmpLeft.Controls.Add(this.TVFoldersEmp);
                this.TPageEmpLeft.Location = new System.Drawing.Point(4, 40);
                this.TPageEmpLeft.Name = "TPageEmpLeft";
                this.TPageEmpLeft.Padding = new System.Windows.Forms.Padding(3);
                this.TPageEmpLeft.Size = new System.Drawing.Size(187, 506);
                this.TPageEmpLeft.TabIndex = 2;
                this.TPageEmpLeft.Text = "شئون عاملين";
                this.TPageEmpLeft.UseVisualStyleBackColor = true;
                // 
                // TVFoldersEmp
                // 
                this.TVFoldersEmp.BackColor = System.Drawing.Color.DimGray;
                this.TVFoldersEmp.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TVFoldersEmp.ForeColor = System.Drawing.Color.Lime;
                this.TVFoldersEmp.HideSelection = false;
                this.TVFoldersEmp.ImageIndex = 0;
                this.TVFoldersEmp.ImageList = this.IconsList;
                this.TVFoldersEmp.Location = new System.Drawing.Point(3, 3);
                this.TVFoldersEmp.Name = "TVFoldersEmp";
                this.TVFoldersEmp.SelectedImageIndex = 0;
                this.TVFoldersEmp.Size = new System.Drawing.Size(181, 500);
                this.TVFoldersEmp.TabIndex = 1;
                // 
                // TControlRight
                // 
                this.TControlRight.Controls.Add(this.TabPageGeneralRight);
                this.TControlRight.Controls.Add(this.TPageStudentRight);
                this.TControlRight.Controls.Add(this.TPageEmpRight);
                this.TControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TControlRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TControlRight.Location = new System.Drawing.Point(0, 0);
                this.TControlRight.Multiline = true;
                this.TControlRight.Name = "TControlRight";
                this.TControlRight.SelectedIndex = 0;
                this.TControlRight.Size = new System.Drawing.Size(705, 550);
                this.TControlRight.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
                this.TControlRight.TabIndex = 3;
                // 
                // TabPageGeneralRight
                // 
                this.TabPageGeneralRight.Controls.Add(this.LVFilesGeneral);
                this.TabPageGeneralRight.Location = new System.Drawing.Point(4, 22);
                this.TabPageGeneralRight.Name = "TabPageGeneralRight";
                this.TabPageGeneralRight.Padding = new System.Windows.Forms.Padding(3);
                this.TabPageGeneralRight.Size = new System.Drawing.Size(697, 524);
                this.TabPageGeneralRight.TabIndex = 0;
                this.TabPageGeneralRight.Text = "ملفات عامه";
                this.TabPageGeneralRight.UseVisualStyleBackColor = true;
                // 
                // LVFilesGeneral
                // 
                this.LVFilesGeneral.BackColor = System.Drawing.Color.Gainsboro;
                this.LVFilesGeneral.BackgroundImage = global::My.Resources.Resources.LVFiles;
                this.LVFilesGeneral.BackgroundImageTiled = true;
                this.LVFilesGeneral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColHDFileName,
            this.ColHDCreatedIn,
            this.ColHDCreatedBy,
            this.ColHDFileType});
                this.LVFilesGeneral.ContextMenuStrip = this.FilesCMGeneral;
                this.LVFilesGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
                this.LVFilesGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LVFilesGeneral.FullRowSelect = true;
                this.LVFilesGeneral.GridLines = true;
                this.LVFilesGeneral.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                this.LVFilesGeneral.LargeImageList = this.IconsList;
                this.LVFilesGeneral.Location = new System.Drawing.Point(3, 3);
                this.LVFilesGeneral.MultiSelect = false;
                this.LVFilesGeneral.Name = "LVFilesGeneral";
                this.LVFilesGeneral.Size = new System.Drawing.Size(691, 518);
                this.LVFilesGeneral.SmallImageList = this.IconsList;
                this.LVFilesGeneral.TabIndex = 2;
                this.LVFilesGeneral.UseCompatibleStateImageBehavior = false;
                this.LVFilesGeneral.View = System.Windows.Forms.View.Details;
                this.LVFilesGeneral.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LVFiles_ColumnClick);
                this.LVFilesGeneral.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LVFiles_KeyDown);
                this.LVFilesGeneral.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LVFiles_MouseDoubleClick);
                // 
                // ColHDFileName
                // 
                this.ColHDFileName.Text = "اسم الملف";
                this.ColHDFileName.Width = 200;
                // 
                // ColHDCreatedIn
                // 
                this.ColHDCreatedIn.Text = "تاريخ الاضافه";
                this.ColHDCreatedIn.Width = 100;
                // 
                // ColHDCreatedBy
                // 
                this.ColHDCreatedBy.Text = "المستخدم";
                this.ColHDCreatedBy.Width = 100;
                // 
                // ColHDFileType
                // 
                this.ColHDFileType.Text = "نوع الملف";
                this.ColHDFileType.Width = 100;
                // 
                // FilesCMGeneral
                // 
                this.FilesCMGeneral.BackColor = System.Drawing.Color.LightGray;
                this.FilesCMGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFilesToolStripMenuItem,
            this.FilesRemoveToolStripMenuItem,
            this.FilesPropertiesToolStripMenuItem});
                this.FilesCMGeneral.Name = "CMenuTree";
                this.FilesCMGeneral.Size = new System.Drawing.Size(120, 70);
                // 
                // AddFilesToolStripMenuItem
                // 
                this.AddFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddFilesToolStripMenuItem.Image")));
                this.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem";
                this.AddFilesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
                this.AddFilesToolStripMenuItem.Text = "انشاء ملف";
                this.AddFilesToolStripMenuItem.Click += new System.EventHandler(this.AddFilesToolStripMenuItem_Click);
                // 
                // FilesRemoveToolStripMenuItem
                // 
                this.FilesRemoveToolStripMenuItem.Image = global::My.Resources.Resources.DeleteObject;
                this.FilesRemoveToolStripMenuItem.Name = "FilesRemoveToolStripMenuItem";
                this.FilesRemoveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
                this.FilesRemoveToolStripMenuItem.Text = "حذف";
                this.FilesRemoveToolStripMenuItem.Click += new System.EventHandler(this.FilesRemoveToolStripMenuItem_Click);
                // 
                // FilesPropertiesToolStripMenuItem
                // 
                this.FilesPropertiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FilesPropertiesToolStripMenuItem.Image")));
                this.FilesPropertiesToolStripMenuItem.Name = "FilesPropertiesToolStripMenuItem";
                this.FilesPropertiesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
                this.FilesPropertiesToolStripMenuItem.Text = "خصائص";
                this.FilesPropertiesToolStripMenuItem.Click += new System.EventHandler(this.FilesPropertiesToolStripMenuItem_Click);
                // 
                // TPageStudentRight
                // 
                this.TPageStudentRight.Controls.Add(this.groupBox1);
                this.TPageStudentRight.Controls.Add(this.LVFilesStudent);
                this.TPageStudentRight.Location = new System.Drawing.Point(4, 22);
                this.TPageStudentRight.Name = "TPageStudentRight";
                this.TPageStudentRight.Padding = new System.Windows.Forms.Padding(3);
                this.TPageStudentRight.Size = new System.Drawing.Size(697, 524);
                this.TPageStudentRight.TabIndex = 1;
                this.TPageStudentRight.Text = "ملفات الطلاب";
                this.TPageStudentRight.UseVisualStyleBackColor = true;
                // 
                // groupBox1
                // 
                this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
                this.groupBox1.Controls.Add(this.groupBox3);
                this.groupBox1.Controls.Add(this.CBFasl);
                this.groupBox1.Controls.Add(this.label3);
                this.groupBox1.Controls.Add(this.CBStudent);
                this.groupBox1.Controls.Add(this.label4);
                this.groupBox1.Controls.Add(this.CBSaf);
                this.groupBox1.Controls.Add(this.label2);
                this.groupBox1.Controls.Add(this.CBYear);
                this.groupBox1.Controls.Add(this.label1);
                this.groupBox1.Location = new System.Drawing.Point(6, 6);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.groupBox1.Size = new System.Drawing.Size(683, 97);
                this.groupBox1.TabIndex = 4;
                this.groupBox1.TabStop = false;
                this.groupBox1.Text = "خيارات البحث";
                // 
                // groupBox3
                // 
                this.groupBox3.Controls.Add(this.TxtStudentsearch);
                this.groupBox3.Controls.Add(this.BtnStudentsearch);
                this.groupBox3.Location = new System.Drawing.Point(7, 14);
                this.groupBox3.Name = "groupBox3";
                this.groupBox3.Size = new System.Drawing.Size(175, 77);
                this.groupBox3.TabIndex = 2;
                this.groupBox3.TabStop = false;
                this.groupBox3.Text = "بحث بالاسم";
                // 
                // TxtStudentsearch
                // 
                this.TxtStudentsearch.Location = new System.Drawing.Point(12, 16);
                this.TxtStudentsearch.Name = "TxtStudentsearch";
                this.TxtStudentsearch.Size = new System.Drawing.Size(150, 20);
                this.TxtStudentsearch.TabIndex = 3;
                // 
                // BtnStudentsearch
                // 
                this.BtnStudentsearch.Location = new System.Drawing.Point(12, 42);
                this.BtnStudentsearch.Name = "BtnStudentsearch";
                this.BtnStudentsearch.Size = new System.Drawing.Size(150, 23);
                this.BtnStudentsearch.TabIndex = 2;
                this.BtnStudentsearch.Text = "بحث";
                this.BtnStudentsearch.UseVisualStyleBackColor = true;
                this.BtnStudentsearch.Click += new System.EventHandler(this.BtnStudentsearch_Click);
                // 
                // CBFasl
                // 
                this.CBFasl.FormattingEnabled = true;
                this.CBFasl.Location = new System.Drawing.Point(188, 34);
                this.CBFasl.Name = "CBFasl";
                this.CBFasl.Size = new System.Drawing.Size(200, 21);
                this.CBFasl.TabIndex = 1;
                this.CBFasl.SelectedIndexChanged += new System.EventHandler(this.CBFasl_SelectedIndexChanged);
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(391, 37);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(39, 13);
                this.label3.TabIndex = 0;
                this.label3.Text = "الفصل";
                // 
                // CBStudent
                // 
                this.CBStudent.FormattingEnabled = true;
                this.CBStudent.Location = new System.Drawing.Point(188, 61);
                this.CBStudent.Name = "CBStudent";
                this.CBStudent.Size = new System.Drawing.Size(200, 21);
                this.CBStudent.TabIndex = 1;
                this.CBStudent.SelectedIndexChanged += new System.EventHandler(this.CBStudent_SelectedIndexChanged);
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(391, 64);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(41, 13);
                this.label4.TabIndex = 0;
                this.label4.Text = "الطالب";
                // 
                // CBSaf
                // 
                this.CBSaf.FormattingEnabled = true;
                this.CBSaf.Location = new System.Drawing.Point(438, 61);
                this.CBSaf.Name = "CBSaf";
                this.CBSaf.Size = new System.Drawing.Size(200, 21);
                this.CBSaf.TabIndex = 1;
                this.CBSaf.SelectedIndexChanged += new System.EventHandler(this.CBSaf_SelectedIndexChanged);
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(641, 64);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(35, 13);
                this.label2.TabIndex = 0;
                this.label2.Text = "الصف";
                // 
                // CBYear
                // 
                this.CBYear.FormattingEnabled = true;
                this.CBYear.Location = new System.Drawing.Point(438, 34);
                this.CBYear.Name = "CBYear";
                this.CBYear.Size = new System.Drawing.Size(200, 21);
                this.CBYear.TabIndex = 1;
                this.CBYear.SelectedIndexChanged += new System.EventHandler(this.CBYear_SelectedIndexChanged);
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(643, 37);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(33, 13);
                this.label1.TabIndex = 0;
                this.label1.Text = "العام";
                // 
                // LVFilesStudent
                // 
                this.LVFilesStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.LVFilesStudent.BackColor = System.Drawing.Color.Gainsboro;
                this.LVFilesStudent.BackgroundImage = global::My.Resources.Resources.LVFiles;
                this.LVFilesStudent.BackgroundImageTiled = true;
                this.LVFilesStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName,
            this.chstu_name,
            this.chStuFileTypeName,
            this.chasase_year,
            this.chalsofof_name,
            this.chfasl_name,
            this.chDis,
            this.chCreatedIn,
            this.chUserName});
                this.LVFilesStudent.ContextMenuStrip = this.FilesCMStudent;
                this.LVFilesStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LVFilesStudent.FullRowSelect = true;
                this.LVFilesStudent.GridLines = true;
                this.LVFilesStudent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                this.LVFilesStudent.LargeImageList = this.IconsListStu;
                this.LVFilesStudent.Location = new System.Drawing.Point(3, 109);
                this.LVFilesStudent.MultiSelect = false;
                this.LVFilesStudent.Name = "LVFilesStudent";
                this.LVFilesStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.LVFilesStudent.Size = new System.Drawing.Size(691, 412);
                this.LVFilesStudent.SmallImageList = this.IconsListStu;
                this.LVFilesStudent.TabIndex = 3;
                this.LVFilesStudent.UseCompatibleStateImageBehavior = false;
                this.LVFilesStudent.View = System.Windows.Forms.View.Details;
                this.LVFilesStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LVFilesStudent_KeyDown);
                this.LVFilesStudent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LVFilesStudent_MouseDoubleClick);
                // 
                // chFileName
                // 
                this.chFileName.Text = "اسم الملف";
                this.chFileName.Width = 100;
                // 
                // chstu_name
                // 
                this.chstu_name.Text = "اسم الطالب";
                this.chstu_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.chstu_name.Width = 100;
                // 
                // chStuFileTypeName
                // 
                this.chStuFileTypeName.Text = "نوع الملف";
                this.chStuFileTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                // 
                // chasase_year
                // 
                this.chasase_year.Text = "العام الدراسي";
                this.chasase_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.chasase_year.Width = 80;
                // 
                // chalsofof_name
                // 
                this.chalsofof_name.Text = "الصف";
                this.chalsofof_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                // 
                // chfasl_name
                // 
                this.chfasl_name.Text = "الفصل";
                this.chfasl_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                // 
                // chDis
                // 
                this.chDis.Text = "تعليق";
                this.chDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                // 
                // chCreatedIn
                // 
                this.chCreatedIn.Text = "وقت الانشاء";
                this.chCreatedIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.chCreatedIn.Width = 71;
                // 
                // chUserName
                // 
                this.chUserName.Text = "مستخدم اخر تعديل";
                this.chUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.chUserName.Width = 95;
                // 
                // FilesCMStudent
                // 
                this.FilesCMStudent.BackColor = System.Drawing.Color.LightGray;
                this.FilesCMStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIStuAddFiles,
            this.tSMIStuTransfer,
            this.TSMIStuDelFiles,
            this.TSMIStuProbFiles});
                this.FilesCMStudent.Name = "CMenuTree";
                this.FilesCMStudent.Size = new System.Drawing.Size(163, 92);
                // 
                // TSMIStuAddFiles
                // 
                this.TSMIStuAddFiles.Image = ((System.Drawing.Image)(resources.GetObject("TSMIStuAddFiles.Image")));
                this.TSMIStuAddFiles.Name = "TSMIStuAddFiles";
                this.TSMIStuAddFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
                this.TSMIStuAddFiles.Size = new System.Drawing.Size(162, 22);
                this.TSMIStuAddFiles.Text = "انشاء ملف";
                this.TSMIStuAddFiles.Click += new System.EventHandler(this.TSMIStuAddFiles_Click);
                // 
                // tSMIStuTransfer
                // 
                this.tSMIStuTransfer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                this.tSMIStuTransfer.Image = global::My.Resources.Resources.Transfer;
                this.tSMIStuTransfer.Name = "tSMIStuTransfer";
                this.tSMIStuTransfer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
                this.tSMIStuTransfer.Size = new System.Drawing.Size(162, 22);
                this.tSMIStuTransfer.Text = "تحميل";
                this.tSMIStuTransfer.Click += new System.EventHandler(this.tSMIStuTransferToolStripMenuItem_Click);
                // 
                // TSMIStuDelFiles
                // 
                this.TSMIStuDelFiles.Image = global::My.Resources.Resources.DeleteObject;
                this.TSMIStuDelFiles.Name = "TSMIStuDelFiles";
                this.TSMIStuDelFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
                this.TSMIStuDelFiles.Size = new System.Drawing.Size(162, 22);
                this.TSMIStuDelFiles.Text = "حذف";
                this.TSMIStuDelFiles.Click += new System.EventHandler(this.TSMIStuDelFiles_Click);
                // 
                // TSMIStuProbFiles
                // 
                this.TSMIStuProbFiles.Image = ((System.Drawing.Image)(resources.GetObject("TSMIStuProbFiles.Image")));
                this.TSMIStuProbFiles.Name = "TSMIStuProbFiles";
                this.TSMIStuProbFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
                this.TSMIStuProbFiles.Size = new System.Drawing.Size(162, 22);
                this.TSMIStuProbFiles.Text = "خصائص";
                this.TSMIStuProbFiles.Click += new System.EventHandler(this.TSMIStuProbFiles_Click);
                // 
                // IconsListStu
                // 
                this.IconsListStu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsListStu.ImageStream")));
                this.IconsListStu.TransparentColor = System.Drawing.Color.Transparent;
                this.IconsListStu.Images.SetKeyName(0, "FoldersIcon.ico");
                this.IconsListStu.Images.SetKeyName(1, "Default.ico");
                // 
                // TPageEmpRight
                // 
                this.TPageEmpRight.Controls.Add(this.groupBox2);
                this.TPageEmpRight.Controls.Add(this.LVFilesEmp);
                this.TPageEmpRight.Location = new System.Drawing.Point(4, 22);
                this.TPageEmpRight.Name = "TPageEmpRight";
                this.TPageEmpRight.Size = new System.Drawing.Size(697, 524);
                this.TPageEmpRight.TabIndex = 2;
                this.TPageEmpRight.Text = "ملفات شئون العاملين";
                this.TPageEmpRight.UseVisualStyleBackColor = true;
                // 
                // groupBox2
                // 
                this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
                this.groupBox2.Controls.Add(this.groupBox4);
                this.groupBox2.Controls.Add(this.CBEmp);
                this.groupBox2.Controls.Add(this.label6);
                this.groupBox2.Location = new System.Drawing.Point(6, 5);
                this.groupBox2.Name = "groupBox2";
                this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.groupBox2.Size = new System.Drawing.Size(683, 97);
                this.groupBox2.TabIndex = 6;
                this.groupBox2.TabStop = false;
                this.groupBox2.Text = "خيارات البحث";
                // 
                // groupBox4
                // 
                this.groupBox4.Controls.Add(this.TxtEmpSearch);
                this.groupBox4.Controls.Add(this.BtnEmpSearch);
                this.groupBox4.Location = new System.Drawing.Point(7, 14);
                this.groupBox4.Name = "groupBox4";
                this.groupBox4.Size = new System.Drawing.Size(175, 77);
                this.groupBox4.TabIndex = 2;
                this.groupBox4.TabStop = false;
                this.groupBox4.Text = "بحث بالاسم";
                // 
                // TxtEmpSearch
                // 
                this.TxtEmpSearch.Location = new System.Drawing.Point(12, 16);
                this.TxtEmpSearch.Name = "TxtEmpSearch";
                this.TxtEmpSearch.Size = new System.Drawing.Size(150, 20);
                this.TxtEmpSearch.TabIndex = 3;
                // 
                // BtnEmpSearch
                // 
                this.BtnEmpSearch.Location = new System.Drawing.Point(12, 42);
                this.BtnEmpSearch.Name = "BtnEmpSearch";
                this.BtnEmpSearch.Size = new System.Drawing.Size(150, 23);
                this.BtnEmpSearch.TabIndex = 2;
                this.BtnEmpSearch.Text = "بحث";
                this.BtnEmpSearch.UseVisualStyleBackColor = true;
                this.BtnEmpSearch.Click += new System.EventHandler(this.BtnEmpSearch_Click);
                // 
                // CBEmp
                // 
                this.CBEmp.FormattingEnabled = true;
                this.CBEmp.Location = new System.Drawing.Point(430, 42);
                this.CBEmp.Name = "CBEmp";
                this.CBEmp.Size = new System.Drawing.Size(200, 21);
                this.CBEmp.TabIndex = 1;
                this.CBEmp.SelectedIndexChanged += new System.EventHandler(this.CBEmp_SelectedIndexChanged);
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(633, 45);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(41, 13);
                this.label6.TabIndex = 0;
                this.label6.Text = "العامل";
                // 
                // LVFilesEmp
                // 
                this.LVFilesEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.LVFilesEmp.BackColor = System.Drawing.Color.Gainsboro;
                this.LVFilesEmp.BackgroundImage = global::My.Resources.Resources.LVFiles;
                this.LVFilesEmp.BackgroundImageTiled = true;
                this.LVFilesEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader4});
                this.LVFilesEmp.ContextMenuStrip = this.FilesCMEmp;
                this.LVFilesEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.LVFilesEmp.FullRowSelect = true;
                this.LVFilesEmp.GridLines = true;
                this.LVFilesEmp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                this.LVFilesEmp.LargeImageList = this.IconsListStu;
                this.LVFilesEmp.Location = new System.Drawing.Point(3, 108);
                this.LVFilesEmp.MultiSelect = false;
                this.LVFilesEmp.Name = "LVFilesEmp";
                this.LVFilesEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.LVFilesEmp.Size = new System.Drawing.Size(691, 412);
                this.LVFilesEmp.SmallImageList = this.IconsListStu;
                this.LVFilesEmp.TabIndex = 5;
                this.LVFilesEmp.UseCompatibleStateImageBehavior = false;
                this.LVFilesEmp.View = System.Windows.Forms.View.Details;
                // 
                // columnHeader1
                // 
                this.columnHeader1.Text = "اسم الملف";
                this.columnHeader1.Width = 112;
                // 
                // columnHeader2
                // 
                this.columnHeader2.Text = "اسم العامل";
                this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.columnHeader2.Width = 151;
                // 
                // columnHeader3
                // 
                this.columnHeader3.Text = "نوع الملف";
                this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.columnHeader3.Width = 88;
                // 
                // columnHeader7
                // 
                this.columnHeader7.Text = "الوظيفه";
                this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.columnHeader7.Width = 109;
                // 
                // columnHeader8
                // 
                this.columnHeader8.Text = "وقت الانشاء";
                this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.columnHeader8.Width = 71;
                // 
                // columnHeader9
                // 
                this.columnHeader9.Text = "مستخدم اخر تعديل";
                this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.columnHeader9.Width = 95;
                // 
                // columnHeader4
                // 
                this.columnHeader4.Text = "تعليق";
                this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                // 
                // FilesCMEmp
                // 
                this.FilesCMEmp.BackColor = System.Drawing.Color.LightGray;
                this.FilesCMEmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIEmpAddFiles,
            this.tSMIEmpTransfer,
            this.TSMIEmpDelFiles,
            this.TSMIEmpProbFiles});
                this.FilesCMEmp.Name = "CMenuTree";
                this.FilesCMEmp.Size = new System.Drawing.Size(163, 114);
                // 
                // TSMIEmpAddFiles
                // 
                this.TSMIEmpAddFiles.Image = ((System.Drawing.Image)(resources.GetObject("TSMIEmpAddFiles.Image")));
                this.TSMIEmpAddFiles.Name = "TSMIEmpAddFiles";
                this.TSMIEmpAddFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
                this.TSMIEmpAddFiles.Size = new System.Drawing.Size(162, 22);
                this.TSMIEmpAddFiles.Text = "انشاء ملف";
                this.TSMIEmpAddFiles.Click += new System.EventHandler(this.TSMIEmpAddFiles_Click);
                // 
                // tSMIEmpTransfer
                // 
                this.tSMIEmpTransfer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                this.tSMIEmpTransfer.Image = global::My.Resources.Resources.Transfer;
                this.tSMIEmpTransfer.Name = "tSMIEmpTransfer";
                this.tSMIEmpTransfer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
                this.tSMIEmpTransfer.Size = new System.Drawing.Size(162, 22);
                this.tSMIEmpTransfer.Text = "تحميل";
                this.tSMIEmpTransfer.Click += new System.EventHandler(this.tSMIEmpTransfer_Click);
                // 
                // TSMIEmpDelFiles
                // 
                this.TSMIEmpDelFiles.Image = global::My.Resources.Resources.DeleteObject;
                this.TSMIEmpDelFiles.Name = "TSMIEmpDelFiles";
                this.TSMIEmpDelFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
                this.TSMIEmpDelFiles.Size = new System.Drawing.Size(162, 22);
                this.TSMIEmpDelFiles.Text = "حذف";
                this.TSMIEmpDelFiles.Click += new System.EventHandler(this.TSMIEmpDelFiles_Click);
                // 
                // TSMIEmpProbFiles
                // 
                this.TSMIEmpProbFiles.Image = ((System.Drawing.Image)(resources.GetObject("TSMIEmpProbFiles.Image")));
                this.TSMIEmpProbFiles.Name = "TSMIEmpProbFiles";
                this.TSMIEmpProbFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
                this.TSMIEmpProbFiles.Size = new System.Drawing.Size(162, 22);
                this.TSMIEmpProbFiles.Text = "خصائص";
                this.TSMIEmpProbFiles.Click += new System.EventHandler(this.TSMIEmpProbFiles_Click);
                // 
                // MainForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.ClientSize = new System.Drawing.Size(904, 621);
                this.Controls.Add(this.SplitContainer);
                this.Controls.Add(this.ToolStrip);
                this.Controls.Add(this.MenuStrip);
                this.Controls.Add(this.StatusStrip);
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.IsMdiContainer = true;
                this.MainMenuStrip = this.MenuStrip;
                this.Name = "MainForm";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Data Center - Server Window";
                this.TransparencyKey = System.Drawing.Color.Pink;
                this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
                this.Load += new System.EventHandler(this.MainForm_Load);
                this.MenuStrip.ResumeLayout(false);
                this.MenuStrip.PerformLayout();
                this.ToolStrip.ResumeLayout(false);
                this.ToolStrip.PerformLayout();
                this.StatusStrip.ResumeLayout(false);
                this.StatusStrip.PerformLayout();
                this.FoldersCMGeneral.ResumeLayout(false);
                this.SplitContainer.Panel1.ResumeLayout(false);
                this.SplitContainer.Panel2.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
                this.SplitContainer.ResumeLayout(false);
                this.TControlLeft.ResumeLayout(false);
                this.TPageGeneralLeft.ResumeLayout(false);
                this.TPageStudentLeft.ResumeLayout(false);
                this.TPageEmpLeft.ResumeLayout(false);
                this.TControlRight.ResumeLayout(false);
                this.TabPageGeneralRight.ResumeLayout(false);
                this.FilesCMGeneral.ResumeLayout(false);
                this.TPageStudentRight.ResumeLayout(false);
                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                this.groupBox3.ResumeLayout(false);
                this.groupBox3.PerformLayout();
                this.FilesCMStudent.ResumeLayout(false);
                this.TPageEmpRight.ResumeLayout(false);
                this.groupBox2.ResumeLayout(false);
                this.groupBox2.PerformLayout();
                this.groupBox4.ResumeLayout(false);
                this.groupBox4.PerformLayout();
                this.FilesCMEmp.ResumeLayout(false);
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.ToolStripMenuItem HelpMenu;
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
		internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
		internal System.Windows.Forms.ToolTip ToolTip;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
		internal System.Windows.Forms.StatusStrip StatusStrip;
		internal System.Windows.Forms.ToolStripButton NewToolStripButton;
		internal System.Windows.Forms.ToolStrip ToolStrip;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem NewProjectToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FileMenu;
		internal System.Windows.Forms.MenuStrip MenuStrip;
		internal System.Windows.Forms.ToolStripMenuItem ViewMenu;
		internal System.Windows.Forms.ToolStripMenuItem ToolBarToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StatusBarToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ToolsMenu;
		internal System.Windows.Forms.TreeView TVGFoldersGeneral;
		internal System.Windows.Forms.SplitContainer SplitContainer;
		internal System.Windows.Forms.ListView LVFilesGeneral;
		internal System.Windows.Forms.ColumnHeader ColHDFileName;
		internal System.Windows.Forms.ToolStripMenuItem UsersManagerToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DataManagerToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CreateNewUserToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RemoveUserToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem EditUserPriviligeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FileCheckerToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RestoreToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem BackupToolStripMenuItem;
		internal System.Windows.Forms.ContextMenuStrip FoldersCMGeneral;
		internal System.Windows.Forms.ToolStripMenuItem CreateFolderToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FoldersRemoveToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FoldersPropertiesToolStripMenuItem;
		internal System.Windows.Forms.ImageList MainImageList;
        internal System.Windows.Forms.ColumnHeader ColHDCreatedIn;
		internal System.Windows.Forms.ColumnHeader ColHDCreatedBy;
		internal System.Windows.Forms.ColumnHeader ColHDFileType;
		internal System.Windows.Forms.ToolStripProgressBar FoldersToolStripProgressBar;
		internal System.Windows.Forms.ToolStripStatusLabel FoldersToolStripStatusLabel;
		internal System.Windows.Forms.ToolStripMenuItem RestartToolStripMenuItem;
		internal System.Windows.Forms.ContextMenuStrip FilesCMGeneral;
		internal System.Windows.Forms.ToolStripMenuItem AddFilesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FilesRemoveToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FilesPropertiesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PrivilegesEditorToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FilesTypesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddNewFileTypeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FilesTypesEditorToolStripMenuItem;
		internal System.Windows.Forms.ToolStripDropDownButton ListViewToolStripDropDownButton;
		internal System.Windows.Forms.ToolStripMenuItem LargeIconListViewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DetailsListViewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SmallIconListViewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ListListViewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		internal System.Windows.Forms.ToolStripMenuItem UnLockFilesToolStripMenuItem;
        private System.ComponentModel.IContainer components;
        private ImageList IconsList;
        private TabControl TControlLeft;
        private TabPage TPageStudentLeft;
        private TabPage TPageEmpLeft;
        private TabControl TControlRight;
        private TabPage TabPageGeneralRight;
        private TabPage TPageStudentRight;
        private TabPage TPageEmpRight;
        private TabPage TPageGeneralLeft;
        internal ListView LVFilesStudent;
        internal ColumnHeader chFileName;
        internal ColumnHeader chStuFileTypeName;
        internal ColumnHeader chstu_name;
        internal TreeView TVFoldersStudent;
        internal TreeView TVFoldersEmp;
        internal ContextMenuStrip FilesCMStudent;
        internal ToolStripMenuItem TSMIStuAddFiles;
        internal ToolStripMenuItem TSMIStuDelFiles;
        internal ToolStripMenuItem TSMIStuProbFiles;
        private GroupBox groupBox1;
        private ComboBox CBFasl;
        private Label label3;
        private ComboBox CBStudent;
        private Label label4;
        private ComboBox CBSaf;
        private Label label2;
        private ComboBox CBYear;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox TxtStudentsearch;
        private Button BtnStudentsearch;
        private ColumnHeader chasase_year;
        private ColumnHeader chalsofof_name;
        private ColumnHeader chfasl_name;
        private ColumnHeader chDis;
        private ColumnHeader chCreatedIn;
        private ColumnHeader chUserName;
        private ImageList IconsListStu;
        private ToolStripMenuItem tSMIStuTransfer;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox TxtEmpSearch;
        private Button BtnEmpSearch;
        private ComboBox CBEmp;
        private Label label6;
        internal ListView LVFilesEmp;
        internal ColumnHeader columnHeader1;
        internal ColumnHeader columnHeader2;
        internal ColumnHeader columnHeader3;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader4;
        internal ContextMenuStrip FilesCMEmp;
        internal ToolStripMenuItem TSMIEmpAddFiles;
        private ToolStripMenuItem tSMIEmpTransfer;
        internal ToolStripMenuItem TSMIEmpDelFiles;
        internal ToolStripMenuItem TSMIEmpProbFiles;
        private ToolStripMenuItem stuFileTypeToolStripMenuItem;
		
	}
}
