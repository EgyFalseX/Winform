using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using FunctionLib;
using System.IO;
using System.Data;
using My.Resources;
using System.Data.SqlClient;

namespace DataCenter_Server
{
	public partial class MainForm
    {
        #region -   Variables   -
        
        private Timer TMR = new Timer();
        public bool AppCantExit;
        DataTable StudentTbl = new DataTable();
        DataTable EmpTbl = new DataTable();
        #endregion
        #region -   Functions   -
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadFoldersRoot()
        {
            TVGFoldersGeneral.Nodes.Clear();
            DataTable Root = MainModule.FunLib.LoadTable(@"SELECT FolderID, FolderName, FolderPath, CreatedIn, UserID, Disc, ParentID
            FROM FolderInfo WHERE ParentID = N'0'");
            TreeNode Nodi;
            foreach (DataRow row in Root.Rows)
            {
                Nodi = new TreeNode() { Name = row["FolderID"].ToString(), Text = row["FolderName"].ToString() };
                TVGFoldersGeneral.Nodes.Add(Nodi);
                LoadFoldersTree(Nodi);
            }
        }
        public static void LoadFoldersTree(TreeNode Nodi)
        {
            DataTable Folders = MainModule.FunLib.LoadTable(String.Format(@"SELECT FolderID, FolderName, FolderPath, CreatedIn, UserID, Disc, ParentID FROM FolderInfo
                                WHERE ParentID = N'{0}'", Nodi.Name));
            TreeNode SubNodi;
            foreach (DataRow row in Folders.Rows)
            {
                SubNodi = new TreeNode() { Name = row["FolderID"].ToString(), Text = row["FolderName"].ToString() };
                Nodi.Nodes.Add(SubNodi);
                LoadFoldersTree(SubNodi);
            }
        }
        public void LoadGeneralIcons()
        {
            DataTable dt = MCls.LoadDataTable("Select TypeID, TypeIconData From FileType", "");
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.IsDBNull(row["TypeIconData"]))
                    continue;
                MemoryStream stream = new MemoryStream();
                byte[] TypeIconData = (byte[])row["TypeIconData"];
                MemoryStream ms = new MemoryStream(TypeIconData);
                Icon ico = null;
                Image img = null;
                try
                {
                    ms.Position = 0;
                    ico = new Icon(ms);
                    IconsList.Images.Add(row["TypeID"].ToString().Trim(), ico);
                }
                catch 
                {
                    img = Resources.Default_;
                    IconsList.Images.Add(row["TypeID"].ToString().Trim(), img);
                }
            }
        }
        public void LoadStuIcons()
        {
            IconsListStu.Images.Clear();
            DataTable dt = MCls.LoadDataTable("Select StuFileTypeID, StuFileData From StuFileType", "");
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.IsDBNull(row["StuFileData"]))
                    continue;
                MemoryStream stream = new MemoryStream();
                byte[] StuFileData = (byte[])row["StuFileData"];
                MemoryStream ms = new MemoryStream(StuFileData);
                Icon ico = null;
                Image img = null;
                try
                {
                    ms.Position = 0;
                    ico = new Icon(ms);
                    IconsListStu.Images.Add(row["StuFileTypeID"].ToString().Trim(), ico);
                }
                catch
                {
                    img = Resources.Default_;
                    IconsListStu.Images.Add(row["StuFileTypeID"].ToString().Trim(), img);
                }
            }
        }
        public void RelaodFilesInListView()
        {
            if (TVGFoldersGeneral.SelectedNode != null)
            {
                LVFilesGeneral.Items.Clear();
                ListViewItem LVI = new ListViewItem();
                DataTable Filez = MCls.LoadDataTable(@"SELECT FileID, FileName, FilePath, CreatedIn, UsrID, Dis, FolderID, TypeID, Active, InUseUserID, InUse,
                        (Select TypeName From FileType Where TypeID = FileInfo.TypeID) AS TypeName,
                        (Select UserName From Users Where UsrID = FileInfo.UsrID) AS UserName
                        FROM FileInfo WHERE FolderID = " + TVGFoldersGeneral.SelectedNode.Name, "");
                int tag = 0;
                foreach (DataRow row in Filez.Rows)
                {
                    LVI = new ListViewItem();
                    LVI.Tag = tag;
                    tag++;
                    LVI.Name = row["FileID"].ToString();
                    LVI.Text = row["FileName"].ToString();
                    LVI.SubItems.Add(Convert.ToString((Convert.ToDateTime(row["CreatedIn"].ToString())).Date));
                    LVI.SubItems.Add(row["UserName"].ToString());
                    LVI.SubItems.Add(row["TypeName"].ToString());
                    LVI.ImageKey = row["TypeID"].ToString().Trim();
                    LVFilesGeneral.Items.Add(LVI);
                }
            }
        }
        public void LoadStudent(string StudentName)
        {
            string CommandString = string.Format(@"SELECT StuFileInfo.StuFileID, StuFileInfo.FileName, StuFileInfo.FilePath, StuFileInfo.StuFileTypeID, StuFileInfo.CreatedIn, StuFileInfo.UsrID, StuFileInfo.Dis, 
            StuFileInfo.stu_code, StuFileInfo.asase_code, StuFileInfo.alsofof_code, StuFileInfo.fasl_code,
            (Select StuFileTypeName From StuFileType Where StuFileTypeID = StuFileInfo.StuFileTypeID) AS StuFileTypeName,
            (Select StuFileData From StuFileType Where StuFileTypeID = StuFileInfo.StuFileTypeID) AS StuFileData,
            (Select UserName From Users Where UsrID = StuFileInfo.UsrID) AS UserName,
            (Select stu_name From Student Where stu_code = StuFileInfo.stu_code) AS stu_name,
            (Select asase_year From asase Where asase_code = StuFileInfo.asase_code) AS asase_year,
            (Select alsofof_name From alsofof Where alsofof_code = StuFileInfo.alsofof_code) AS alsofof_name,
            (Select fasl_name From fasl Where fasl_code = StuFileInfo.fasl_code) AS fasl_name
            FROM StuFileInfo INNER JOIN Student ON StuFileInfo.stu_code = Student.stu_code WHERE (Student.stu_name LIKE  N'%{0}%')
            GROUP BY StuFileInfo.StuFileID, StuFileInfo.FileName, StuFileInfo.FilePath, StuFileInfo.StuFileTypeID, StuFileInfo.CreatedIn, StuFileInfo.UsrID, StuFileInfo.Dis, 
            StuFileInfo.stu_code, StuFileInfo.asase_code, StuFileInfo.alsofof_code, StuFileInfo.fasl_code", StudentName);
            StudentTbl = MCls.LoadDataTable(CommandString, "");
            StudentLVBind();
        }
        public void LoadStudent(bool LoadStudents)
        {
            //if (CBYear.DataSource == null || CBSaf.DataSource == null || CBFasl.DataSource == null)
            //{
            //    return;
            //}
            string stu_code;
            if (CBStudent.DataSource != null)
            {
                if (CBStudent.SelectedIndex == -1)
                    stu_code = string.Empty;
                else
                {
                    if (((DataTable)CBStudent.DataSource).Rows[CBStudent.SelectedIndex]["stu_code"].ToString() != string.Empty)
                        stu_code = ((DataTable)CBStudent.DataSource).Rows[CBStudent.SelectedIndex]["stu_code"].ToString();
                    else
                        stu_code = string.Empty;
                }
            }
            else
                stu_code = string.Empty;
            string asase_code;
            if (CBYear.DataSource != null)
            {
                if (CBYear.SelectedIndex == -1)
                    asase_code = string.Empty;
                else
                {
                    if (((DataTable)CBYear.DataSource).Rows[CBYear.SelectedIndex]["asase_code"].ToString() != string.Empty)
                        asase_code = ((DataTable)CBYear.DataSource).Rows[CBYear.SelectedIndex]["asase_code"].ToString();
                    else
                        asase_code = string.Empty;
                }
            }
            else
                asase_code = string.Empty;
            string alsofof_code;
            if (CBSaf.DataSource != null)
            {
                if (CBSaf.SelectedIndex == -1)
                    alsofof_code = string.Empty;
                else
                {
                    if (((DataTable)CBSaf.DataSource).Rows[CBSaf.SelectedIndex]["alsofof_code"].ToString() != string.Empty)
                        alsofof_code = ((DataTable)CBSaf.DataSource).Rows[CBSaf.SelectedIndex]["alsofof_code"].ToString();
                    else
                        alsofof_code = string.Empty;
                }
            }
            else
                alsofof_code = string.Empty;
            string fasl_code;
            if (CBFasl.DataSource != null)
            {
                if (CBFasl.SelectedIndex == -1)
                    fasl_code = string.Empty;
                else
                {
                    if (((DataTable)CBFasl.DataSource).Rows[CBFasl.SelectedIndex]["fasl_code"].ToString() != string.Empty)
                        fasl_code = ((DataTable)CBFasl.DataSource).Rows[CBFasl.SelectedIndex]["fasl_code"].ToString();
                    else
                        fasl_code = string.Empty;
                }
            }
            else
                fasl_code = string.Empty;
            string CommandStringFiles = @"Select StuFileID, FileName, FilePath, StuFileTypeID, CreatedIn, UsrID, Dis, stu_code, asase_code, alsofof_code, fasl_code,
            (Select StuFileTypeName From StuFileType Where StuFileTypeID = StuFileInfo.StuFileTypeID) AS StuFileTypeName,
            (Select StuFileData From StuFileType Where StuFileTypeID = StuFileInfo.StuFileTypeID) AS StuFileData,
            (Select UserName From Users Where UsrID = StuFileInfo.UsrID) AS UserName,
            (Select stu_name From Student Where stu_code = StuFileInfo.stu_code) AS stu_name,
            (Select asase_year From asase Where asase_code = StuFileInfo.asase_code) AS asase_year,
            (Select alsofof_name From alsofof Where alsofof_code = StuFileInfo.alsofof_code) AS alsofof_name,
            (Select fasl_name From fasl Where fasl_code = StuFileInfo.fasl_code) AS fasl_name
             From StuFileInfo Where";
            string CommandStringStudent = @"Select stu_code, (Select stu_name From Student Where stu_code = student_t.stu_code) AS stu_name From student_t Where ";
            if (stu_code == string.Empty)
                CommandStringFiles += " stu_code is not NULL ";
            else
                CommandStringFiles += " stu_code = " + stu_code;
            if (asase_code == string.Empty)
            {
                CommandStringFiles += " And asase_code is not NULL ";
                CommandStringStudent += " asase_code is not NULL ";
            }
            else
            {
                CommandStringFiles += " And asase_code = " + asase_code;
                CommandStringStudent += " asase_code = " + asase_code;
            }
            if (alsofof_code == string.Empty)
            {
                CommandStringFiles += " And alsofof_code is not NULL ";
                CommandStringStudent += " And alsofof_code is not NULL ";
            }
            else
            {
                CommandStringFiles += " And alsofof_code = " + alsofof_code;
                CommandStringStudent += " And alsofof_code = " + alsofof_code;
            }
            if (fasl_code == string.Empty)
            {
                CommandStringFiles += " And fasl_code is not NULL ";
                CommandStringStudent += " And fasl_code is not NULL ";
            }
            else
            {
                CommandStringFiles += " And fasl_code = " + fasl_code;
                CommandStringStudent += " And fasl_code = " + fasl_code;
            }
            StudentTbl = MCls.LoadDataTable(CommandStringFiles, "");
            if (LoadStudents)
            {
                CBStudent.DataSource = MCls.LoadDataTable(CommandStringStudent, "");
                CBStudent.DisplayMember = "stu_name";
                CBStudent.ValueMember = "stu_code";
            }
            StudentLVBind();
        }
        public void StudentLVBind()
        {
            LVFilesStudent.Items.Clear();
            ListViewItem LVI = new ListViewItem();
            int tag = 0;
            foreach (DataRow row in StudentTbl.Rows)
            {
                LVI = new ListViewItem();
                LVI.Tag = tag;
                tag++;
                LVI.Name = row["StuFileID"].ToString();
                LVI.Text = row["FileName"].ToString();
                LVI.SubItems.Add(row["stu_name"].ToString());
                LVI.SubItems.Add(row["StuFileTypeName"].ToString());
                LVI.SubItems.Add(row["asase_year"].ToString());
                LVI.SubItems.Add(row["alsofof_name"].ToString());
                LVI.SubItems.Add(row["fasl_name"].ToString());
                LVI.SubItems.Add(row["Dis"].ToString());
                LVI.SubItems.Add(Convert.ToString((Convert.ToDateTime(row["CreatedIn"].ToString())).ToShortDateString()));
                LVI.SubItems.Add(row["UserName"].ToString());
                LVI.ImageKey = row["StuFileTypeID"].ToString().Trim();
                LVFilesStudent.Items.Add(LVI);
            }
        }
        public void EmpLVBind()
        {
            LVFilesEmp.Items.Clear();
            ListViewItem LVI = new ListViewItem();
            int tag = 0;
            foreach (DataRow row in EmpTbl.Rows)
            {
                LVI = new ListViewItem();
                LVI.Tag = tag;
                tag++;
                LVI.Name = row["EmpFileID"].ToString();
                LVI.Text = row["FileName"].ToString();
                LVI.SubItems.Add(row["Name"].ToString());
                LVI.SubItems.Add(row["StuFileTypeName"].ToString());
                LVI.SubItems.Add(row["TAT"].ToString());
                LVI.SubItems.Add(Convert.ToString((Convert.ToDateTime(row["CreatedIn"].ToString())).ToShortDateString()));
                LVI.SubItems.Add(row["UserName"].ToString());
                LVI.SubItems.Add(row["Dis"].ToString());
                LVI.ImageKey = row["StuFileTypeID"].ToString().Trim();
                LVFilesEmp.Items.Add(LVI);
            }
        }
        #endregion
        #region - Event Handlers-
		private void TMR_Tick(object sender, EventArgs e)
		{
			Enabled = true;
			TMR.Enabled = false;
            while (MainModule.DefaultUserPassword == "" || MainModule.ProjectsPath == "" || MainModule.DeletedFilesPath == "" || MainModule.StudentFilesPath == "" || MainModule.EmpFilesPath == "")
			{
				MainModule.FrmOptions = new OptionsFrm();
				MainModule.FrmOptions.ShowDialog();
			}
            LoadFoldersRoot();
			LoadGeneralIcons();
		}
		public void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (AppCantExit == false)
				Application.Exit();
		}
        public void MainForm_Load(object sender, EventArgs e)
        {
            TMR.Interval = 1;
            TMR.Tick += TMR_Tick;
            LoadFoldersRoot();
            LoadGeneralIcons();
            LoadStuIcons();
            TControlRight.TabPages.Clear();
            TControlRight.TabPages.Add(TabPageGeneralRight);
        }
        public void TVFolders_AfterSelect(Object sender, TreeViewEventArgs e)
        {
            RelaodFilesInListView();
        }
        public void LVFiles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (LVFilesGeneral.Sorting == System.Windows.Forms.SortOrder.Ascending)
                LVFilesGeneral.Sorting = System.Windows.Forms.SortOrder.Descending;
            else
                LVFilesGeneral.Sorting = System.Windows.Forms.SortOrder.Ascending;
        }
		public void LVFiles_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData)
			{
				case Keys.Delete:
					FilesRemoveToolStripMenuItem_Click(sender, e);
					break;
				case Keys.Enter:
					FilesPropertiesToolStripMenuItem_Click(sender, e);
					break;
			}
			
		}
		public void LVFiles_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (LVFilesGeneral.SelectedIndices.Count > 0 && e.Button == MouseButtons.Left)
				FilesPropertiesToolStripMenuItem_Click(sender, e);
			else
				AddFilesToolStripMenuItem_Click(sender, e);
		}
        private void TControlLeft_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == TPageGeneralLeft)// General
            {
                TControlRight.TabPages.Clear();
                TControlRight.TabPages.Add(TabPageGeneralRight);
            }
            else if (e.TabPage == TPageStudentLeft)// Student
            {
                TControlRight.TabPages.Clear();
                TControlRight.TabPages.Add(TPageStudentRight);
                CBYear.DataSource = MCls.LoadDataTable("Select asase_code, asase_year From asase", "");// Load Years
                CBYear.DisplayMember = "asase_year";
                CBYear.ValueMember = "asase_code";
                CBSaf.DataSource = MCls.LoadDataTable("Select alsofof_code, alsofof_name From alsofof", "");// Load El Sofoof
                CBSaf.DisplayMember = "alsofof_name";
                CBSaf.ValueMember = "alsofof_code";
                CBFasl.DataSource = MCls.LoadDataTable("Select fasl_code, fasl_name From fasl", "");// Load El Fosool
                CBFasl.DisplayMember = "fasl_name";
                CBFasl.ValueMember = "fasl_code";
                LoadStuIcons();
                LoadStudent(true);
            }
            else if (e.TabPage == TPageEmpLeft)// Emp
            {
                TControlRight.TabPages.Clear();
                TControlRight.TabPages.Add(TPageEmpRight);
                CBEmp.DataSource = MCls.LoadDataTable("Select Code, Name, TAT From Emp", "");// Load Emp
                CBEmp.DisplayMember = "Name";
                CBEmp.ValueMember = "Code";
            }
        }
		//Menus
        public void RestartToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Application.Restart();
        }
        public void CreateNewUserToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmUsers = new EditUsersFrm();
            MainModule.FrmUsers.ShowDialog();
        }
        public void RemoveUserToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmDisactivatedUsers = new DisactivatedUsersFrm();
            MainModule.FrmDisactivatedUsers.ShowDialog();
        }
        public void EditUserPriviligeToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmUsersPrivileges = new UsersPrivilegesFrm();
            MainModule.FrmUsersPrivileges.ShowDialog();
        }
        public void FileCheckerToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmFilesChecker = new FilesCheckerFrm();
            MainModule.FrmFilesChecker.FormClosing += MainModule.FrmFilesChecker.FilesCheckerFrm_FormClosing;
            MainModule.FrmFilesChecker.AppCantExit = true;
            MainModule.FrmFilesChecker.MinimizeBox = false;
            MainModule.FrmFilesChecker.BtnStart.Visible = false;
            MainModule.FrmFilesChecker.ShowDialog();
        }
		public void NewProjectToolStripMenuItem_Clieck(object sender, EventArgs e)
		{
			MainModule.FrmWizrad = new WizradFrm();
            MainModule.FrmWizrad.FormClosing += MainModule.FrmWizrad.WizradFrm_FormClosing;
			MainModule.FrmWizrad.Show();
			AppCantExit = true;
			Close();
		}
        public void OptionsToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (MainModule.FrmOptions.Visible == false)
            {
                MainModule.FrmOptions = new OptionsFrm();
                MainModule.FrmOptions.Show();
            }
            else
                MainModule.FrmOptions.Activate();
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip.Visible = ToolBarToolStripMenuItem.Checked;
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusStrip.Visible = StatusBarToolStripMenuItem.Checked;
        }
        public void AddNewFileTypeToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmNewFileTypes = new NewFileTypesFrm();
            MainModule.FrmNewFileTypes.FormClosing += MainModule.FrmNewFileTypes.NewFileTypesFrm_FormClosing;
            MainModule.FrmNewFileTypes.ShowDialog();
        }
        public void FilesTypesEditorToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmEditFileTypes = new EditFileTypesFrm();
            MainModule.FrmEditFileTypes.FormClosing += MainModule.FrmEditFileTypes.EditFileTypesFrm_FormClosing;
            MainModule.FrmEditFileTypes.ShowDialog();
        }
        public void UnLockFilesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmLockedFiles = new LockedFilesFrm();
            MainModule.FrmLockedFiles.ShowDialog();
        }
        public void ExitToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        private void stuFileTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainModule.FrmStuFileType = new StuFileTypeFrm();
            MainModule.FrmStuFileType.ShowDialog();
        }
		//Context Menus
        public void FilesRemoveToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            short Int1 = 0;
            if (TVGFoldersGeneral.SelectedNode != null && LVFilesGeneral.SelectedIndices.Count > 0)
            {
                if (Interaction.MsgBox(String.Format("هل انت متأكد؟", Environment.NewLine), MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
                    return;
                DataTable SFile = MCls.LoadDataTable(String.Format(@"SELECT FileID, FileName, FilePath, CreatedIn, UsrID, Dis, FolderID, TypeID, Active, InUseUserID, InUse,
                                                                     (Select TypeName From FileType Where TypeID = FileInfo.TypeID) AS TypeName,
                                                                     (Select UserName From Users Where UsrID = FileInfo.UsrID) AS UserName
                                                                     FROM FileInfo WHERE FileID = '{0}'", LVFilesGeneral.SelectedItems[0].Name), "");
                if (SFile.Rows.Count == 0)
                {
                    MCls.msg("لم نعثر علي الملف", true, "", this);
                    return;
                }
                
                DataRow row = SFile.Rows[0];
                MainModule.PropertyObjectInfo.FolderIndex = TVGFoldersGeneral.SelectedNode.Name;
                MainModule.PropertyObjectInfo.FileIndex = (short)(LVFilesGeneral.SelectedItems[0].Index);
                string ErrorResult = MainModule.FunLib.RemoveFile(LVFilesGeneral.SelectedItems[0].Name);
                if (ErrorResult == null)
                {
                    if (File.Exists(MainModule.ProjectsPath + row["FilePath"].ToString()))
                    {
                        if (Directory.Exists(String.Format("{0}{1}-{2}-{3}\\", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)) == false)
                        {
                            Directory.CreateDirectory(String.Format("{0}{1}-{2}-{3}\\", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
                        }
                        string[] FilePaths = row["FilePath"].ToString().Split("\\".ToCharArray());
                        string NewPath;
                        for (Int1 = 0; Int1 <= 10000; Int1++)
                        {
                            NewPath = String.Format("{0}{1}-{2}-{3}\\{4} - {5}", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, FilePaths[FilePaths.Length - 1], Int1);
                            if (File.Exists(NewPath) == false)
                            {
                                File.Move(MainModule.ProjectsPath + row["FilePath"].ToString(), NewPath);
                                break;
                            }
                        }
                    }
                    RelaodFilesInListView();// Reload files in list after deletion
                    MainModule.MsgBox_("تم الحذف", 99, 23, true, this);
                }
                else
                    MainModule.MsgBox_(ErrorResult, 0, 23, false, this);
            }
        }
        public void FilesPropertiesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (LVFilesGeneral.SelectedIndices.Count > 0)
            {
                DataTable SFile = MCls.LoadDataTable(@"SELECT FileID, FileName, FilePath, CreatedIn, UsrID, Dis, FolderID, TypeID, Active, InUseUserID, InUse,
                (Select TypeName From FileType Where TypeID = FileInfo.TypeID) AS TypeName,
                (Select UserName From Users Where UsrID = FileInfo.UsrID) AS UserName
                FROM FileInfo WHERE FileID = " + LVFilesGeneral.SelectedItems[0].Name, "");
                if (SFile.Rows == null)
                {
                    MCls.msg("لم نعثر علي الملف", true, "", this);
                    return;
                }
                DataRow row = SFile.Rows[0];
                MainModule.FrmObjectProperty = new ObjectPropertyFrm();
                MainModule.PropertyObjectInfo.FolderIndex = TVGFoldersGeneral.SelectedNode.Name;
                MainModule.FrmObjectProperty.TxtFileName.Text = row["FileName"].ToString();
                MainModule.FrmObjectProperty.LblFilePath.Text = MainModule.ProjectsPath + row["FilePath"];
                MainModule.FrmObjectProperty.LblDate.Text = MCls.ConvertToDateDMY(row["CreatedIn"].ToString());
                MainModule.FrmObjectProperty.LblUser.Text = row["UserName"].ToString();
                MainModule.FrmObjectProperty.LblFileType.Text = row["TypeName"].ToString();
                MainModule.FrmObjectProperty.TxtDisc.Text = row["Dis"].ToString();
                MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Clear();
                MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.FilesTabPage);
                MainModule.FrmObjectProperty.BtnSavePriv.Enabled = true;
                MainModule.FrmObjectProperty.Text = "خصائص الملف";
                MainModule.FrmObjectProperty.ShowDialog();
            }
        }
        public void AddFilesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            
            if (TVGFoldersGeneral.SelectedNode != null)
            {
                
                MainModule.FrmObjectProperty = new ObjectPropertyFrm();
                
                MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Clear();
                MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.NewFileTabPage);
                
                MainModule.FrmObjectProperty.LblNewFileDate.Text = DateTime.Now.Date.ToString();
                MainModule.PropertyObjectInfo.FolderIndex = TVGFoldersGeneral.SelectedNode.Name;
                //object temp_object = MainModule.FrmObjectProperty.LblNewFileProjectName.Text;
                //string temp_string = (string)(temp_object);
                //MainModule.FunLib.GetProjectName((string)(MainModule.FunLib.Folders[(int)(TVFolders.SelectedNode.Tag)].ProID), ref temp_string);
                //if (MainModule.FunLib.AllFilesType != null)
                //{
                //    for (Int1 = 0; Int1 <= MainModule.FunLib.AllFilesType.Length - 1; Int1++)
                //        MainModule.FrmObjectProperty.FileTypeCB.Items.Add(MainModule.FunLib.AllFilesType[Int1].TypeName);
                //}

                MainModule.FrmObjectProperty.FileTypeCB.DataSource = MCls.LoadDataTable("Select TypeID, TypeName, TypeExt From FileType", "");
                MainModule.FrmObjectProperty.FileTypeCB.DisplayMember = "TypeName";
                MainModule.FrmObjectProperty.FileTypeCB.ValueMember = "TypeID";
                MainModule.FrmObjectProperty.Text = "ملف جديد";
                MainModule.FrmObjectProperty.ShowDialog();
            }
        }
        public void FoldersPropertiesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmObjectProperty = new ObjectPropertyFrm();
            if (TVGFoldersGeneral.SelectedNode == null)
            {
                MainModule.MsgBox_("من فضلك اختار مجلد", 112, 23, false, this);
                return;
            }
            
            DataTable FolderInfo = MainModule.FunLib.LoadTable(@"Select FolderName, FolderPath, CreatedIn, UserID, Disc, ParentID,
                (Select UserName From Users Where UsrID = FolderInfo.UserID) AS UserName
                From FolderInfo Where FolderID = " + TVGFoldersGeneral.SelectedNode.Name);
            if (FolderInfo.Rows == null)
            {
                MainModule.MsgBox_("لم نعثر علي المجلد", 112, 23, false, this);
                LoadFoldersRoot();
                return;
            }
            DataRow row = FolderInfo.Rows[0];
            MainModule.PropertyObjectInfo.ObjecyType = MainModule.ObjectType.ExistedFolder;
            MainModule.PropertyObjectInfo.FolderIndex = TVGFoldersGeneral.SelectedNode.Name;
            MainModule.FrmObjectProperty.TxtFolderName.Text = TVGFoldersGeneral.SelectedNode.Text;
            MainModule.FrmObjectProperty.LblFolderPath.Text = String.Format("{0}{1}", MainModule.ProjectsPath, row["FolderPath"]);
            MainModule.FrmObjectProperty.LblFolderDate.Text = MCls.ConvertToDateDMY(row["CreatedIn"].ToString()); ;
            MainModule.FrmObjectProperty.LblFolderUser.Text = row["UserName"].ToString();
            MainModule.FrmObjectProperty.TxtFolderDisc.Text = row["Disc"].ToString();
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Clear();
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.FoldersTabPage);
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.FoldersprivilegesTabPage);
            
            //Sort Privilege in list boxs
            MainModule.FunLib.GetAllprivilege();
            MainModule.FunLib.GetSelectedFolderprivilege(TVGFoldersGeneral.SelectedNode.Name);
            for (int IntForLoop = 0; IntForLoop <= MainModule.FunLib.Allprivilege.Length - 1; IntForLoop++)
            {
                if (MainModule.FunLib.Allprivilege[IntForLoop].privilegeSelected == true)
                {
                    MainModule.FrmObjectProperty.LBSelectedprivileges.Items.Add(MainModule.FunLib.Allprivilege[IntForLoop].privilegeName);
                    if (MainModule.FrmObjectProperty.SelectedPrv == null)
                        MainModule.FrmObjectProperty.SelectedPrv = new DataCenterServerLib.privilegeType[1];
                    else
                        Array.Resize(ref MainModule.FrmObjectProperty.SelectedPrv, MainModule.FrmObjectProperty.SelectedPrv.Length + 1);
                    MainModule.FrmObjectProperty.SelectedPrv[MainModule.FrmObjectProperty.SelectedPrv.Length - 1] = MainModule.FunLib.Allprivilege[IntForLoop];
                }
                else
                {
                    MainModule.FrmObjectProperty.LBAllprivileges.Items.Add(MainModule.FunLib.Allprivilege[IntForLoop].privilegeName);
                    if (MainModule.FrmObjectProperty.UnSelectedPrv == null)
                        MainModule.FrmObjectProperty.UnSelectedPrv = new DataCenterServerLib.privilegeType[1];
                    else
                        Array.Resize(ref MainModule.FrmObjectProperty.UnSelectedPrv, MainModule.FrmObjectProperty.UnSelectedPrv.Length + 1);
                    MainModule.FrmObjectProperty.UnSelectedPrv[MainModule.FrmObjectProperty.UnSelectedPrv.Length - 1] = MainModule.FunLib.Allprivilege[IntForLoop];
                }
            }
            //Sort Users in list boxs
            MainModule.FunLib.GetAllUsers();
            MainModule.FunLib.GetSelectedFolderUser(TVGFoldersGeneral.SelectedNode.Name);
            for (int IntForLoop = 0; IntForLoop <= MainModule.FunLib.AllUsersF.Length - 1; IntForLoop++)
            {
                if (MainModule.FunLib.AllUsersF[IntForLoop].privilegeSelected == true)
                {
                    MainModule.FrmObjectProperty.LBSelectedUsers.Items.Add(MainModule.FunLib.AllUsersF[IntForLoop].privilegeName);
                    if (MainModule.FrmObjectProperty.SelectedUser == null)
                        MainModule.FrmObjectProperty.SelectedUser = new DataCenterServerLib.privilegeType[1];
                    else
                        Array.Resize(ref MainModule.FrmObjectProperty.SelectedUser, MainModule.FrmObjectProperty.SelectedUser.Length + 1);
                    MainModule.FrmObjectProperty.SelectedUser[MainModule.FrmObjectProperty.SelectedUser.Length - 1] = MainModule.FunLib.AllUsersF[IntForLoop];
                }
                else
                {
                    MainModule.FrmObjectProperty.LBAllUsers.Items.Add(MainModule.FunLib.AllUsersF[IntForLoop].privilegeName);
                    if (MainModule.FrmObjectProperty.UnSelectedUser == null)
                        MainModule.FrmObjectProperty.UnSelectedUser = new DataCenterServerLib.privilegeType[1];
                    else
                        Array.Resize(ref MainModule.FrmObjectProperty.UnSelectedUser, MainModule.FrmObjectProperty.UnSelectedUser.Length + 1);
                    MainModule.FrmObjectProperty.UnSelectedUser[MainModule.FrmObjectProperty.UnSelectedUser.Length - 1] = MainModule.FunLib.AllUsersF[IntForLoop];
                }
            }
            MainModule.FrmObjectProperty.Text = "خصائص المجلد";
            MainModule.FrmObjectProperty.ShowDialog();
        }
        public void CreateFolderToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            short Int1 = 0;
            MainModule.FrmObjectProperty = new ObjectPropertyFrm();
            if (TVGFoldersGeneral.SelectedNode == null)
            {
                MainModule.MsgBox_("من فضلك اختار مجلد", 112, 23, false, this);
                return;
            }
            DataTable FolderInfo = MainModule.FunLib.LoadTable(@"Select FolderName, FolderPath, CreatedIn, UserID, Disc, ParentID,
                                    (Select UserName From Users Where UsrID = FolderInfo.UserID) AS UserName
                                    From FolderInfo Where FolderID = " + TVGFoldersGeneral.SelectedNode.Name);
            if (FolderInfo.Rows == null)
            {
                MainModule.MsgBox_("المجلد لم يعد موجود", 112, 23, false, this);
                LoadFoldersRoot();
                return;
            }
            DataRow row = FolderInfo.Rows[0];
            MainModule.PropertyObjectInfo.ObjecyType = MainModule.ObjectType.NewFolder;
            MainModule.PropertyObjectInfo.FolderIndex = TVGFoldersGeneral.SelectedNode.Name;
            MainModule.FrmObjectProperty.LblNewFolderPath.Text = MainModule.ProjectsPath + row["FolderPath"];
            MainModule.FrmObjectProperty.LblNewFolderDate.Text = DateTime.Now.Date.ToString();
            MainModule.FunLib.GetAllprivilege();

            for (Int1 = 0; Int1 <= MainModule.FunLib.Allprivilege.Length - 1; Int1++)
            {
                if (MainModule.FunLib.Allprivilege[Int1].privilegeName != "Public")
                {
                    MainModule.FrmObjectProperty.LBAllprivileges.Items.Add(MainModule.FunLib.Allprivilege[Int1].privilegeName);
                    if (MainModule.FrmObjectProperty.UnSelectedPrv == null)
                        MainModule.FrmObjectProperty.UnSelectedPrv = new DataCenterServerLib.privilegeType[1];
                    else
                        Array.Resize(ref MainModule.FrmObjectProperty.UnSelectedPrv, MainModule.FrmObjectProperty.UnSelectedPrv.Length + 1);
                    MainModule.FrmObjectProperty.UnSelectedPrv[MainModule.FrmObjectProperty.UnSelectedPrv.Length - 1] = MainModule.FunLib.Allprivilege[Int1];
                }
                else
                {
                    MainModule.FrmObjectProperty.LBSelectedprivileges.Items.Add(MainModule.FunLib.Allprivilege[Int1].privilegeName);
                    if (MainModule.FrmObjectProperty.SelectedPrv == null)
                        MainModule.FrmObjectProperty.SelectedPrv = new DataCenterServerLib.privilegeType[1];
                    else
                        Array.Resize(ref MainModule.FrmObjectProperty.SelectedPrv, MainModule.FrmObjectProperty.SelectedPrv.Length + 1);
                    MainModule.FrmObjectProperty.SelectedPrv[MainModule.FrmObjectProperty.SelectedPrv.Length - 1] = MainModule.FunLib.Allprivilege[Int1];
                }
            }
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Clear();
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.NewFolderTabPage);
            //MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.FoldersprivilegesTabPage);
            MainModule.FrmObjectProperty.BtnSavePriv.Visible = false;
            MainModule.FrmObjectProperty.Text = "مجلد جديد";
            MainModule.FrmObjectProperty.ShowDialog();

        }
        public void FoldersRemoveToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            short Int1 = 0;
            if (TVGFoldersGeneral.SelectedNode == null)
                return;
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.No)
                return;
            DataTable FolderInfo = MainModule.FunLib.LoadTable("Select FolderPath From FolderInfo Where FolderID = " + TVGFoldersGeneral.SelectedNode.Name);
            //Check if the folder have files or folder
            if (FolderInfo.Rows.Count == 0 || TVGFoldersGeneral.SelectedNode == null)
            {
                MainModule.MsgBox_("اختار مجلد", 104, 23, false, this);
                return;
            }
            if (TVGFoldersGeneral.SelectedNode.Nodes != null || LVFilesGeneral.Items.Count > 0)
            {
                MainModule.MsgBox_("المجلد ليس فارع", 104, 23, false, this);
                return;
            }
            string RemoveFolderErrorResult = MainModule.FunLib.RemoveFolder(TVGFoldersGeneral.SelectedNode.Name);
            if (RemoveFolderErrorResult == null)
            {
                //try to remove the Phy folder "Only if its empty"
                if (Directory.Exists(MainModule.ProjectsPath + FolderInfo.Rows[0]["FolderPath"]))
                {
                    string[] FileArr;
                    string[] FolderArr;
                    FileArr = Directory.GetFiles(MainModule.ProjectsPath + FolderInfo.Rows[0]["FolderPath"]);
                    FolderArr = Directory.GetDirectories(MainModule.ProjectsPath + FolderInfo.Rows[0]["FolderPath"]);
                    if (FileArr.Length == 0 || FolderArr.Length == 0)
                    {
                        try
                        {
                            if (!Directory.Exists(String.Format("{0}{1}-{2}-{3}", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)))
                                Directory.CreateDirectory(String.Format("{0}{1}-{2}-{3}", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
                            string NewPath;
                            for (Int1 = 0; Int1 <= 10000; Int1++)
                            {
                                NewPath = String.Format("{0}{1}-{2}-{3}\\{4}_{5}", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, TVGFoldersGeneral.SelectedNode.Text, Int1);
                                if (Directory.Exists(NewPath) == false)
                                {
                                    Directory.Move(MainModule.ProjectsPath + FolderInfo.Rows[0]["FolderPath"], NewPath);
                                    break;
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                    //Prepare Complate MSG
                    MainModule.MsgBox_("تم الحذف", 42, 23, true, this);
                    //Reload TreeView
                    Enabled = false;
                    TVGFoldersGeneral.SelectedNode.Remove();
                    Enabled = true;
                }
            }

            
        }
        public void PrivilegesEditorToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmPrivileges = new PrivilegesFrm();
            MainModule.FrmPrivileges.ShowDialog();
        }
		//Status Bar
        public void LargeIconListViewToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            LVFilesGeneral.View = View.LargeIcon;
            LargeIconListViewToolStripMenuItem.Checked = true;
            DetailsListViewToolStripMenuItem.Checked = false;
            SmallIconListViewToolStripMenuItem.Checked = false;
            ListListViewToolStripMenuItem.Checked = false;
        }
        public void DetailsListViewToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            LVFilesGeneral.View = View.Details;
            LargeIconListViewToolStripMenuItem.Checked = false;
            DetailsListViewToolStripMenuItem.Checked = true;
            SmallIconListViewToolStripMenuItem.Checked = false;
            ListListViewToolStripMenuItem.Checked = false;
        }
        public void SmallIconListViewToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            LVFilesGeneral.View = View.SmallIcon;
            LargeIconListViewToolStripMenuItem.Checked = false;
            DetailsListViewToolStripMenuItem.Checked = false;
            SmallIconListViewToolStripMenuItem.Checked = true;
            ListListViewToolStripMenuItem.Checked = false;
        }
        public void ListListViewToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            LVFilesGeneral.View = View.List;
            LargeIconListViewToolStripMenuItem.Checked = false;
            DetailsListViewToolStripMenuItem.Checked = false;
            SmallIconListViewToolStripMenuItem.Checked = false;
            ListListViewToolStripMenuItem.Checked = true;
        }
        #region - Stu Search-
        private void CBYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent(true);
            StudentLVBind();
        }
        private void CBSaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent(true);
            StudentLVBind();
        }
        private void CBFasl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent(true);
            StudentLVBind();
        }
        private void CBStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent(false);
            //StudentLVBind();
        }
        private void BtnStudentsearch_Click(object sender, EventArgs e)
        {
            if (TxtStudentsearch.Text.Trim().Length == 0)
                return;
            LoadStudent(TxtStudentsearch.Text.Trim());

        }
        private void TSMIStuAddFiles_Click(object sender, EventArgs e)
        {
            if (LVFilesStudent.SelectedItems.Count == 0 && (CBYear.SelectedIndex == -1 || CBSaf.SelectedIndex == -1 || CBFasl.SelectedIndex == -1 || CBStudent.SelectedIndex == -1))
            {
                MCls.msg("من فضلك اختار سنه و صف و فصل و طالب او اختار ملف", true, "", this);
                return;
            }
            MainModule.FrmStuObjectProperty = new StuObjectPropertyFrm();
            MainModule.FrmStuObjectProperty.TC.TabPages.Clear();
            MainModule.FrmStuObjectProperty.TC.TabPages.Add(MainModule.FrmStuObjectProperty.TPageStuAddFile);
            MainModule.FrmStuObjectProperty.BtnAddSave.Enabled = true;
            MainModule.FrmStuObjectProperty.BtnUpdate.Enabled = false;
            MainModule.FrmStuObjectProperty.LoadDtuFileType();
            if (LVFilesStudent.SelectedItems.Count != 0)
            {
                DataRow row = (DataRow)StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]];
                MainModule.FrmStuObjectProperty.LblAddYear.Text = row["asase_year"].ToString();
                MainModule.FrmStuObjectProperty.asase_code = row["asase_code"].ToString();
                MainModule.FrmStuObjectProperty.LblAddSaf.Text = row["alsofof_name"].ToString();
                MainModule.FrmStuObjectProperty.alsofof_code = row["alsofof_code"].ToString();
                MainModule.FrmStuObjectProperty.LblAddFasl.Text = row["fasl_name"].ToString();
                MainModule.FrmStuObjectProperty.fasl_code = row["fasl_code"].ToString();
                MainModule.FrmStuObjectProperty.LblAddStu.Text = row["stu_name"].ToString();
                MainModule.FrmStuObjectProperty.stu_code = row["stu_code"].ToString();
            }
            else
            {
                DataTable dt = (DataTable)CBYear.DataSource;
                MainModule.FrmStuObjectProperty.LblAddYear.Text = dt.Rows[CBYear.SelectedIndex]["asase_year"].ToString();
                MainModule.FrmStuObjectProperty.asase_code = dt.Rows[CBYear.SelectedIndex]["asase_code"].ToString();
                dt = (DataTable)CBSaf.DataSource;
                MainModule.FrmStuObjectProperty.LblAddSaf.Text = dt.Rows[CBSaf.SelectedIndex]["alsofof_name"].ToString();
                MainModule.FrmStuObjectProperty.alsofof_code = dt.Rows[CBSaf.SelectedIndex]["alsofof_code"].ToString();
                dt = (DataTable)CBFasl.DataSource;
                MainModule.FrmStuObjectProperty.LblAddFasl.Text = dt.Rows[CBFasl.SelectedIndex]["fasl_name"].ToString();
                MainModule.FrmStuObjectProperty.fasl_code = dt.Rows[CBFasl.SelectedIndex]["fasl_code"].ToString();
                dt = (DataTable)CBStudent.DataSource;
                MainModule.FrmStuObjectProperty.LblAddStu.Text = dt.Rows[CBStudent.SelectedIndex]["stu_name"].ToString();
                MainModule.FrmStuObjectProperty.stu_code = dt.Rows[CBStudent.SelectedIndex]["stu_code"].ToString();
            }
            MainModule.FrmStuObjectProperty.LblAddFileDate.Text = DateTime.Now.ToShortDateString();
            MainModule.FrmStuObjectProperty.FileName = "ملف جديد";
            MainModule.FrmStuObjectProperty.FilePath = MainModule.StudentFilesPath;
            MainModule.FrmStuObjectProperty.ShowDialog();
            LoadStudent(true);
        }
        private void tSMIStuTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVFilesStudent.SelectedIndices.Count == 0)
                return;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.Cancel)
                return;
            string FileName = StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]]["FilePath"].ToString();
            if (File.Exists(MainModule.StudentFilesPath + FileName))
            {
                try
                {
                    File.Copy(MainModule.StudentFilesPath + FileName, fbd.SelectedPath + "\\" + FileName);
                    MCls.msg("تم النسخ", false, "", this);
                }
                catch (Exception ex)
                {
                    MCls.msg(ex.Message, true, "", this);
                }
            }
            else
                MCls.msg("الملف مفقود", true, "", this);

        }
        private void TSMIStuDelFiles_Click(object sender, EventArgs e)
        {
            if (LVFilesStudent.SelectedItems.Count == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = "Delete From StuFileInfo Where StuFileID = " + StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]]["StuFileID"];
                con.Open();
                cmd.ExecuteNonQuery();
                string DFilePath = MainModule.StudentFilesPath + StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]]["FilePath"];
                if (File.Exists(DFilePath))
                {
                    string DelDir = String.Format("{0}{1}-{2}-{3}\\", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (!Directory.Exists(DelDir))
                        Directory.CreateDirectory(DelDir);
                    File.Move(DFilePath, String.Format("{0}{1}", DelDir, StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]]["FilePath"]));
                }
                LoadStudent(true);
                MCls.msg("تم الحذف", false, "", this);
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void TSMIStuProbFiles_Click(object sender, EventArgs e)
        {
            if (LVFilesStudent.SelectedItems.Count == 0)
                return;
            MainModule.FrmStuObjectProperty = new StuObjectPropertyFrm();
            MainModule.FrmStuObjectProperty.TC.TabPages.Clear();
            MainModule.FrmStuObjectProperty.TC.TabPages.Add(MainModule.FrmStuObjectProperty.TPageStuAddFile);
            MainModule.FrmStuObjectProperty.BtnAddSave.Enabled = false;
            MainModule.FrmStuObjectProperty.BtnUpdate.Enabled = true;
            MainModule.FrmStuObjectProperty.LoadDtuFileType();
            DataRow row = (DataRow)StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]];
            MainModule.FrmStuObjectProperty.LblAddYear.Text = row["asase_year"].ToString();
            MainModule.FrmStuObjectProperty.asase_code = row["asase_code"].ToString();
            MainModule.FrmStuObjectProperty.LblAddSaf.Text = row["alsofof_name"].ToString();
            MainModule.FrmStuObjectProperty.alsofof_code = row["alsofof_code"].ToString();
            MainModule.FrmStuObjectProperty.LblAddFasl.Text = row["fasl_name"].ToString();
            MainModule.FrmStuObjectProperty.fasl_code = row["fasl_code"].ToString();
            MainModule.FrmStuObjectProperty.LblAddStu.Text = row["stu_name"].ToString();
            MainModule.FrmStuObjectProperty.stu_code = row["stu_code"].ToString();

            MainModule.FrmStuObjectProperty.LblAddFileDate.Text = Convert.ToDateTime(row["CreatedIn"]).ToShortDateString();
            MainModule.FrmStuObjectProperty.TxtAddFileName.Text = Convert.ToString(row["FileName"]);
            MainModule.FrmStuObjectProperty.TxtAddDesc.Text = Convert.ToString(row["Dis"]);
            MainModule.FrmStuObjectProperty.StuFileID = row["StuFileID"].ToString();
            if (row["StuFileTypeID"].ToString() != string.Empty)
                MainModule.FrmStuObjectProperty.CBAddFileType.SelectedValue = row["StuFileTypeID"];
            else
                MainModule.FrmStuObjectProperty.CBAddFileType.SelectedIndex = -1;
            MainModule.FrmStuObjectProperty.FilePath = MainModule.StudentFilesPath;
            MainModule.FrmStuObjectProperty.ShowDialog();
            LoadStudent(true);
        }
        private void LVFilesStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TSMIStuProbFiles_Click(TSMIStuProbFiles, new EventArgs());
        }
        private void LVFilesStudent_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Delete:
                    TSMIStuDelFiles_Click(TSMIStuDelFiles, new EventArgs());
                    break;
                case Keys.Enter:
                    TSMIStuProbFiles_Click(TSMIStuProbFiles, new EventArgs());
                    break;
            }
        }
        #endregion
        #region - Emp Search-
        private void CBEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEmp.SelectedIndex != -1)
                EmpTbl = MCls.LoadDataTable(@"SELECT EmpFileID, FileName, FilePath, StuFileTypeID, CreatedIn, UsrID, Dis, Code,
                (Select StuFileTypeName From StuFileType Where StuFileTypeID = EmpFileInfo.StuFileTypeID) AS StuFileTypeName,
                (Select Name From Emp Where Code = EmpFileInfo.Code) AS Name,
                (Select TAT From Emp Where Code = EmpFileInfo.Code) AS TAT,
                (Select UserName From Users Where UsrID = EmpFileInfo.UsrID) AS UserName
                FROM EmpFileInfo
                Where Code = " + ((DataTable)CBEmp.DataSource).Rows[CBEmp.SelectedIndex]["Code"], "");
            else
                EmpTbl = new DataTable("");
            EmpLVBind();
        }
        private void BtnEmpSearch_Click(object sender, EventArgs e)
        {
            EmpTbl = new DataTable("");
            if (TxtEmpSearch.Text.Trim().Length == 0)
                EmpTbl = new DataTable("");
            else
                EmpTbl = MCls.LoadDataTable(@"SELECT EmpFileID, FileName, FilePath, StuFileTypeID, CreatedIn, UsrID, Dis, Code,
                (Select StuFileTypeName From StuFileType Where StuFileTypeID = EmpFileInfo.StuFileTypeID) AS StuFileTypeName,
                (Select Name From Emp Where Code = EmpFileInfo.Code) AS Name,
                (Select TAT From Emp Where Code = EmpFileInfo.Code) AS TAT,
                (Select UserName From Users Where UsrID = EmpFileInfo.UsrID) AS UserName
                FROM EmpFileInfo
                Where (Select Name From Emp Where Code = EmpFileInfo.Code) LIKE  N'%" + TxtEmpSearch.Text + "%'", "");
            EmpLVBind();
        }
        private void TSMIEmpAddFiles_Click(object sender, EventArgs e)
        {
            if (LVFilesEmp.SelectedItems.Count == 0 &&  CBEmp.SelectedIndex == -1)
            {
                MCls.msg("من فضلك اختار عامل او اختار ملف", true, "", this);
                return;
            }
            MainModule.FrmStuObjectProperty = new StuObjectPropertyFrm();
            MainModule.FrmStuObjectProperty.TC.TabPages.Clear();
            MainModule.FrmStuObjectProperty.TC.TabPages.Add(MainModule.FrmStuObjectProperty.TPageEmpAddFile);
            MainModule.FrmStuObjectProperty.BtnEmpAddSave.Enabled = true;
            MainModule.FrmStuObjectProperty.BtnEmpUpdate.Enabled = false;
            MainModule.FrmStuObjectProperty.LoadDtuFileType();
            if (LVFilesEmp.SelectedItems.Count != 0)
            {
                DataRow row = (DataRow)EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]];
                MainModule.FrmStuObjectProperty.LblEmpName.Text = row["Name"].ToString();
                MainModule.FrmStuObjectProperty.Code = row["Code"].ToString();
            }
            else
            {
                DataTable dt = (DataTable)CBEmp.DataSource;
                MainModule.FrmStuObjectProperty.LblEmpName.Text = dt.Rows[CBEmp.SelectedIndex]["Name"].ToString();
                MainModule.FrmStuObjectProperty.Code = dt.Rows[CBEmp.SelectedIndex]["Code"].ToString();
            }
            MainModule.FrmStuObjectProperty.LblEmpAddFileDate.Text = DateTime.Now.ToShortDateString();
            MainModule.FrmStuObjectProperty.FileName = "ملف جديد";
            MainModule.FrmStuObjectProperty.FilePath = MainModule.EmpFilesPath;
            MainModule.FrmStuObjectProperty.ShowDialog();
            CBEmp_SelectedIndexChanged(CBEmp, new EventArgs());
        }
        private void tSMIEmpTransfer_Click(object sender, EventArgs e)
        {
            if (LVFilesEmp.SelectedIndices.Count == 0)
                return;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.Cancel)
                return;
            string FileName = EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]]["FilePath"].ToString();
            if (File.Exists(MainModule.EmpFilesPath + FileName))
            {
                try
                {
                    File.Copy(MainModule.EmpFilesPath + FileName, fbd.SelectedPath + "\\" + FileName);
                    MCls.msg("تم النسخ", false, "", this);
                }
                catch (Exception ex)
                {
                    MCls.msg(ex.Message, true, "", this);
                }
            }
            else
                MCls.msg("الملف مفقود", true, "", this);
        }
        private void TSMIEmpDelFiles_Click(object sender, EventArgs e)
        {
            if (LVFilesEmp.SelectedItems.Count == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = "Delete From EmpFileInfo Where EmpFileID = " + EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]]["EmpFileID"];
                con.Open();
                cmd.ExecuteNonQuery();
                string DFilePath = MainModule.EmpFilesPath + EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]]["FilePath"];
                if (File.Exists(DFilePath))
                {
                    string DelDir = String.Format("{0}{1}-{2}-{3}\\", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (!Directory.Exists(DelDir))
                        Directory.CreateDirectory(DelDir);
                    File.Move(DFilePath, String.Format("{0}{1}", DelDir, EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]]["FilePath"]));
                }
                CBEmp_SelectedIndexChanged(CBEmp, new EventArgs());
                MCls.msg("تم الحذف", false, "", this);
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void TSMIEmpProbFiles_Click(object sender, EventArgs e)
        {
            if (LVFilesEmp.SelectedItems.Count == 0)
                return;
            MainModule.FrmStuObjectProperty = new StuObjectPropertyFrm();
            MainModule.FrmStuObjectProperty.TC.TabPages.Clear();
            MainModule.FrmStuObjectProperty.TC.TabPages.Add(MainModule.FrmStuObjectProperty.TPageEmpAddFile);
            MainModule.FrmStuObjectProperty.BtnEmpAddSave.Enabled = false;
            MainModule.FrmStuObjectProperty.BtnEmpUpdate.Enabled = true;
            MainModule.FrmStuObjectProperty.LoadDtuFileType();
            DataRow row = (DataRow)EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]];
            MainModule.FrmStuObjectProperty.LblEmpName.Text = row["Name"].ToString();
            MainModule.FrmStuObjectProperty.LblEmpAddUser.Text = row["UserName"].ToString();
            MainModule.FrmStuObjectProperty.LblEmpAddFileDate.Text = Convert.ToDateTime(row["CreatedIn"]).ToShortDateString();
            MainModule.FrmStuObjectProperty.TxtEmpAddFileName.Text = row["FileName"].ToString();
            MainModule.FrmStuObjectProperty.TxtEmpAddDesc.Text = Convert.ToString(row["Dis"]);
            MainModule.FrmStuObjectProperty.Code = row["Code"].ToString();
            MainModule.FrmStuObjectProperty.EmpFileID = row["EmpFileID"].ToString();
            if (row["StuFileTypeID"].ToString() != string.Empty)
                MainModule.FrmStuObjectProperty.CBEmpAddFileType.SelectedValue = row["StuFileTypeID"];
            else
                MainModule.FrmStuObjectProperty.CBEmpAddFileType.SelectedIndex = -1;
            MainModule.FrmStuObjectProperty.FilePath = MainModule.EmpFilesPath;
            MainModule.FrmStuObjectProperty.ShowDialog();
            CBEmp_SelectedIndexChanged(CBEmp, new EventArgs());
        }
        #endregion

        #endregion

    }
}