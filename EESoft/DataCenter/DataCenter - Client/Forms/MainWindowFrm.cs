using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using FunctionLib;
using System.IO;
using My.Resources;
using System.Data.SqlClient;
using System.Net.Sockets;
using Microsoft.VisualBasic;
using System.Text;


namespace DataCenter_Client
{
	public partial class MainWindowFrm
    {
        #region -   Variables   -
        private Timer TMR = new Timer();
        private short Int1 = (short)0;
        private string ErrorProviderZ;
        DataTable FileGeneral = new DataTable();
        DataTable StudentTbl = new DataTable();
        DataTable FolderGeneralTbl = new DataTable();
        DataTable EmpTbl = new DataTable();
        #endregion
        #region -   Functions   -
        public MainWindowFrm()
        {
            InitializeComponent();
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
        public void LoadFoldersRoot()
        {
            FolderGeneralTbl = MCls.LoadDataTable(string.Format(@"DECLARE @UsrID nvarchar(4)
            Set @UsrID ='{0}'
            DECLARE  @FolderID nvarchar(50), @FolderName nvarchar(50), @RullID nvarchar(50), @CanWrite tinyint, @CanDelete tinyint, @CanAdd tinyint, @CanView tinyint
            DECLARE  MyC1 CURSOR  For select RullID from Users_Rulls where UsrID = @UsrID
            Select FolderID, CanWrite, CanDelete, CanAdd, CanView, 
            (Select FolderName From FolderInfo Where FolderID = Folder_User.FolderID) AS FolderName,
            (Select ParentID From FolderInfo Where FolderID = Folder_User.FolderID) AS ParentID, 
            (Select FolderPath From FolderInfo Where FolderID = Folder_User.FolderID) AS FolderPath,
            (Select CreatedIn From FolderInfo Where FolderID = Folder_User.FolderID) AS CreatedIn,
            (Select Disc From FolderInfo Where FolderID = Folder_User.FolderID) AS Disc,
            (Select UserName From Users Where UsrID = (Select UserID From FolderInfo Where FolderID = Folder_User.FolderID)) AS UserName
             From Folder_User Where UsrID = @UsrID ORDER BY FolderID
            Open MyC1
            FETCH NEXT FROM MyC1 INTO @RullID
            While @@FETCH_STATUS = 0
            BEGIN 
            Select FolderID, CanWrite, CanDelete, CanAdd, CanView, 
            (Select FolderName From FolderInfo Where FolderID = Folder_Rull.FolderID) AS FolderName, 
            (Select ParentID From FolderInfo Where FolderID = Folder_Rull.FolderID) AS ParentID,
            (Select FolderPath From FolderInfo Where FolderID = Folder_Rull.FolderID) AS FolderPath,
            (Select CreatedIn From FolderInfo Where FolderID = Folder_Rull.FolderID) AS CreatedIn,
            (Select Disc From FolderInfo Where FolderID = Folder_Rull.FolderID) AS Disc,
            (Select UserName From Users Where UsrID = (Select UserID From FolderInfo Where FolderID = Folder_Rull.FolderID)) AS UserName
             From Folder_Rull Where RullID = @RullID And Not Exists (Select FolderID From Folder_User Where UsrID = @UsrID And FolderID = Folder_Rull.FolderID) ORDER BY FolderID /*check if this FolderID Already selected in 1st result*/
             FETCH NEXT FROM MyC1 INTO @RullID
            END
            Close MyC1
            DEALLOCATE MyC1", MainModule.FunLib.CUser.UID), true);
            /////////////////////////////////////////////////////////////////
            FolderGeneralTbl.DefaultView.ApplyDefaultSort = true;         //
            FolderGeneralTbl.DefaultView.Sort = "ParentID ASC";          // Trying to soft rows by 'ParentID'
            FolderGeneralTbl.DefaultView.ApplyDefaultSort = true;       //
            /////////////////////////////////////////////////////////////
            TreeNode SelectedNode;
            if (TVGFoldersGeneral.SelectedNode != null)
                SelectedNode = TVGFoldersGeneral.SelectedNode;
            else
                SelectedNode = null;
            TVGFoldersGeneral.Nodes.Clear();
            TreeNode Nodi;
            for (int i = 0; i < FolderGeneralTbl.Rows.Count; i++)
            {
                Nodi = new TreeNode() { Name = FolderGeneralTbl.Rows[i]["FolderID"].ToString(), Text = FolderGeneralTbl.Rows[i]["FolderName"].ToString(), Tag = i };
                if (TVGFoldersGeneral.Nodes.Find(FolderGeneralTbl.Rows[i]["ParentID"].ToString(), true).Length != 0)
                    TVGFoldersGeneral.Nodes.Find(FolderGeneralTbl.Rows[i]["ParentID"].ToString(), true)[0].Nodes.Add(Nodi);
                else
                    TVGFoldersGeneral.Nodes.Add(Nodi);
                if (TVGFoldersGeneral.Nodes.Count != 0)
                {
                    if (SelectedNode != null)
                        TVGFoldersGeneral.SelectedNode = SelectedNode;
                }
            }
        }
        public void RelaodFilesInListView()
        {
            if (TVGFoldersGeneral.SelectedNode != null)
            {
                LVFilesGeneral.Items.Clear();
                ListViewItem LVI = new ListViewItem();
                FileGeneral = MCls.LoadDataTable(@"SELECT FileID, FileName, FilePath, CreatedIn, UsrID, Dis, FolderID, TypeID, Active, InUseUserID, InUse,
                        (Select TypeName From FileType Where TypeID = FileInfo.TypeID) AS TypeName,
                        (Select UserName From Users Where UsrID = FileInfo.UsrID) AS UserName
                        FROM FileInfo WHERE FolderID = " + TVGFoldersGeneral.SelectedNode.Name, "");
                int tag = 0;
                foreach (DataRow row in FileGeneral.Rows)
                {
                    LVI = new ListViewItem();
                    LVI.Tag = tag;
                    tag++;
                    LVI.Name = row["FileID"].ToString();
                    LVI.Text = row["FileName"].ToString();// 0
                    LVI.SubItems.Add(Convert.ToString((Convert.ToDateTime(row["CreatedIn"].ToString())).Date));// 1
                    LVI.SubItems.Add(row["UserName"].ToString());// 2
                    LVI.SubItems.Add(row["TypeName"].ToString());// 3
                    LVI.ImageKey = row["TypeID"].ToString().Trim();// 4
                    if (row["InUse"].ToString() == "1")
                    {
                        LVI.ForeColor = Color.Blue;
                        LVI.ForeColor = Color.Red;
                    }
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
        public void ReciveFile(string IP_Address, int RPort, string ServerFilePath, string ClientFilePath)
        {
            Enabled = false;
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            short Readed;
            FileStream FileSTM;
            try
            {
                string FullString = (int)NetworkFunction.Commands.ReciveFile + ServerFilePath;
                byte[] DataB = new byte[4097];
                DataB = Encoding.Default.GetBytes(FullString);
                Sok.Connect(IP_Address, RPort);
                if (Sok.Connected == true)
                {
                    Sok.Send(DataB, DataB.Length, SocketFlags.None); //Sending Header
                    DataB = new byte[4097];
                    FileSTM = File.Create(ClientFilePath.Trim());
                    do
                    {
                        Readed = (short)(Sok.Receive(DataB, 0, 4096, SocketFlags.None));
                        if (Readed > 0)
                        {
                            FileSTM.Write(DataB, 0, Readed);
                        }
                        else
                            break;
                        Application.DoEvents();
                    } while (true);
                    FileSTM.Close();
                    MCls.msg("تم التحميل", false, "", this);
                }
                else
                {
                    MCls.msg("لا يوجد اتصال", true, "", this);
                }
                Sok.Close();
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
            }
            Enabled = true;
            Sok.Dispose();
            Sok = null;
        }
        #endregion
        #region - Event Handlers-
        public void MainWindowFrm_Load(Object sender, EventArgs e)
        {
            Enabled = false;
            TMR.Interval = 1;
            TMR.Tick += TMR_Tick;
            TMR.Enabled = true;
            TControlRight.TabPages.Clear();
            TControlRight.TabPages.Add(TabPageGeneralRight);
        }
        private void TMR_Tick(object sender, EventArgs e)
        {
            Enabled = true;
            TMR.Enabled = false;
            LoadFoldersRoot();
            LoadGeneralIcons();
            LoadStuIcons();
        }
        public void TVFolders_AfterSelect(Object sender, TreeViewEventArgs e)
        {
            RelaodFilesInListView();
        }
        public void TVFolders_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                TVGFoldersGeneral.SelectedNode = e.Node;
        }
        public void MainWindowFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
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
        }
        private void BtnStudentsearch_Click(object sender, EventArgs e)
        {
            if (TxtStudentsearch.Text.Trim().Length == 0)
                return;
            LoadStudent(TxtStudentsearch.Text.Trim());
        }
        #region   -  Menu Commands  -
        public void ExitToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        public void LockedFilesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmLockedFiles = new LockedFilesFrm();
            MainModule.FrmLockedFiles.ShowDialog();
        }
        public void OptionsToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmOptions = new OptionsFrm();
            MainModule.FrmOptions.TxtPassword.Text = MainModule.FunLib.CUser.UPass;
            MainModule.FrmOptions.TxtPasswordCon.Text = MainModule.FunLib.CUser.UPass;
            MainModule.FrmOptions.ShowDialog();
        }
        public void ToolBarToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (ToolBarToolStripMenuItem.Checked == false)
                ToolStrip.Visible = false;
            else
                ToolStrip.Visible = true;
        }
        public void StatusBarToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (StatusBarToolStripMenuItem.Checked == false)
                StatusStrip.Visible = false;
            else
                StatusStrip.Visible = true;
        }
        #endregion
        #region   -  Context Menus  -
        public void FoldersCMGeneral_Opening(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TVGFoldersGeneral.SelectedNode == null)
            {
                e.Cancel = true;
                return;
            }
            DataRow row = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag];
            if (row["CanAdd"].ToString() == "1" || row["CanWrite"].ToString() == "1")
                CreateFolderToolStripMenuItem.Enabled = true;
            else
                CreateFolderToolStripMenuItem.Enabled = false;
            if (row["CanDelete"].ToString() == "1")
                FoldersRemoveToolStripMenuItem.Enabled = true;
            else
                FoldersRemoveToolStripMenuItem.Enabled = false;
            if (row["CanView"].ToString() == "1" || row["CanWrite"].ToString() == "1")
                FoldersPropertiesToolStripMenuItem.Enabled = true;
            else
                FoldersPropertiesToolStripMenuItem.Enabled = false;
        }
        public void FilesCMGeneral_Opening(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TVGFoldersGeneral.SelectedNode == null) //if there is no active folder
            {
                e.Cancel = true;
                return;
            }
            DataRow row = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag];
            if (row["CanWrite"].ToString() == "1")
                lockToolStripMenuItem.Enabled = true;
            else
                lockToolStripMenuItem.Enabled = false;
            if (row["CanView"].ToString() == "1" || row["CanWrite"].ToString() == "1")
                TransferToolStripMenuItem.Enabled = true;
            else
                TransferToolStripMenuItem.Enabled = false;
            if (row["CanAdd"].ToString() == "1")
                AddFilesToolStripMenuItem.Enabled = true;
            else
                AddFilesToolStripMenuItem.Enabled = false;
            if (row["CanDelete"].ToString() == "1")
                FilesRemoveToolStripMenuItem.Enabled = true;
            else
                FilesRemoveToolStripMenuItem.Enabled = false;
            if (row["CanView"].ToString() == "1" || row["CanWrite"].ToString() == "1")
                FilesPropertiesToolStripMenuItem.Enabled = true;
            else
                FilesPropertiesToolStripMenuItem.Enabled = false;
        }
        public void CreateFolderToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MainModule.FrmObjectProperty = new ObjectPropertyFrm();
            if (TVGFoldersGeneral.SelectedNode != null)
            {
                MainModule.PropertyObjectInfo.FolderIndex = TVGFoldersGeneral.SelectedNode.Name;
                MainModule.PropertyObjectInfo.ObjecyType = MainModule.ObjectType.NewFolder;
                MainModule.PropertyObjectInfo.FolderPath = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag]["FolderPath"].ToString();
                MainModule.FrmObjectProperty.LblNewFolderPath.Text = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag]["FolderPath"].ToString();
                MainModule.FrmObjectProperty.LblNewFolderDate.Text = DateTime.Now.Date.ToShortDateString();
                MainModule.FrmObjectProperty.LblNewFolderOwner.Text = MainModule.FunLib.CUser.UName;
                //privilage will remove cs the creation related 2 the user privilage only
                MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Clear();
                MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.NewFolderTabPage);
                MainModule.FrmObjectProperty.Text = "مجلد جديد";
                MainModule.FrmObjectProperty.ShowDialog();
            }
            else
                MCls.msg("من فضلك اختار مخلد", true, "", this);
            
        }
        public void AddFilesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (TVGFoldersGeneral.SelectedNode != null)
            {
                MainModule.PropertyObjectInfo.FolderIndex = TVGFoldersGeneral.SelectedNode.Name;
                MainModule.PropertyObjectInfo.FolderPath = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag]["FolderPath"].ToString();
                MainModule.FrmObjectProperty = new ObjectPropertyFrm();
                MainModule.FrmObjectProperty.LblNewFileDate.Text = DateTime.Now.Date.ToShortDateString();
                DataTable dt = MCls.LoadDataTable("Select TypeID, TypeName, TypeExt From FileType", "");
                MainModule.FrmObjectProperty.FileTypeCB.DataSource = dt;
                MainModule.FrmObjectProperty.FileTypeCB.DisplayMember = "TypeName";
                MainModule.FrmObjectProperty.FileTypeCB.ValueMember = "TypeID";
                MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Clear();
                MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.NewFileTabPage);
                MainModule.FrmObjectProperty.Text = "ملف جديد";
                MainModule.FrmObjectProperty.ShowDialog();
            }
        }
        public void FilesRemoveToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (TVGFoldersGeneral.SelectedNode == null || LVFilesGeneral.SelectedIndices.Count == 0)
            {
                MCls.msg("من فضلك اختار ملف داخل مجلد",true,"",this);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            //Get Selected File Information.
            DataTable dt = MCls.LoadDataTable(string.Format("Select FileID, FileName, FilePath From FileInfo Where FileID = '{0}'", LVFilesGeneral.SelectedItems[0].Name), "");
            if (dt.Rows.Count == 0)
            {
                MCls.msg("الملف غير موجود", true, "", this);
                return;
            }
            Enabled = false;// Disable Form Controls
            string FileID = dt.Rows[0]["FileID"].ToString();
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = String.Format("Delete From FileInfo Where FileID ='{0}'", FileID);// Delete the file from database.
                con.Open();
                cmd.ExecuteNonQuery();
                // Move the file from its location to DeletedFilesPath location.
                MainModule.NWLib.RemoveFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.ProjectsPath + dt.Rows[0]["FilePath"], MainModule.DeletedFilesPath);
                RelaodFilesInListView();
                MCls.msg("تم الحذف", false, "", this);
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
            Enabled = true;// Enabled Form Controls
          
        }
        public void FilesPropertiesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            //Must Edit to fit the client case
            if (LVFilesGeneral.SelectedIndices.Count == 0)
                return;
            DataRow sRow = FileGeneral.Rows[(int)LVFilesGeneral.SelectedItems[0].Tag];
            MainModule.FrmObjectProperty = new ObjectPropertyFrm();
            MainModule.PropertyObjectInfo.FolderIndex = sRow["FolderID"].ToString();
            MainModule.PropertyObjectInfo.FolderPath = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag]["FolderPath"].ToString();
            MainModule.PropertyObjectInfo.FileIndex = sRow["FileID"].ToString();
            MainModule.FrmObjectProperty.TxtFileName.Text = sRow["FileName"].ToString();
            MainModule.PropertyObjectInfo.FileName = sRow["FileName"].ToString();
            MainModule.FrmObjectProperty.LblFilePath.Text = sRow["FilePath"].ToString();
            MainModule.FrmObjectProperty.LblDate.Text = Convert.ToDateTime(sRow["CreatedIn"].ToString()).ToShortDateString();
            MainModule.FrmObjectProperty.LblUser.Text = sRow["UserName"].ToString();

            MainModule.FrmObjectProperty.TxtDisc.Text = sRow["Dis"].ToString();
            //'''''''''''''' i Can Add Type Icon To This Window
            MainModule.FrmObjectProperty.CBEditFileType.DataSource = MCls.LoadDataTable("Select TypeID, TypeName From FileType", "");
            MainModule.FrmObjectProperty.CBEditFileType.SelectedValue = sRow["TypeID"].ToString();
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Clear();
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.FilesTabPage);
            MainModule.FrmObjectProperty.Text = "خصائص الملف";
            //Privilages Effect

            //string CanWrite = (string)FolderGeneralTbl.Compute("CanWrite", String.Format("FolderID = '{0}'", sRow["FolderID"].ToString()));
            string CanWrite = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag]["CanWrite"].ToString();
            if (CanWrite == "0") //Chech for Write privilage
            {
                MainModule.FrmObjectProperty.BtnEditFileName.Enabled = false;
                MainModule.FrmObjectProperty.BtnSaveFile.Enabled = false;
            }
            else
            {
                MainModule.FrmObjectProperty.BtnEditFileName.Enabled = true;
                MainModule.FrmObjectProperty.BtnSaveFile.Enabled = true;
            }
            MainModule.FrmObjectProperty.ShowDialog();
        }
        public void FoldersPropertiesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            //Mist Edit to fit the client case
            if (TVGFoldersGeneral.SelectedNode == null)
            {
                MCls.msg("من فضلك اختار مجلد", true, "", this);
                return;
            }
            DataRow sRow = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag];
            MainModule.FrmObjectProperty = new ObjectPropertyFrm();
            MainModule.PropertyObjectInfo.FolderIndex = TVGFoldersGeneral.SelectedNode.Name;
            MainModule.PropertyObjectInfo.ObjecyType = MainModule.ObjectType.ExistedFolder;
            MainModule.PropertyObjectInfo.FolderPath = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag]["FolderPath"].ToString();
            MainModule.FrmObjectProperty.TxtFolderName.Text = sRow["FolderName"].ToString();
            MainModule.FrmObjectProperty.LblFolderPath.Text = sRow["FolderPath"].ToString();
            MainModule.FrmObjectProperty.LblFolderDate.Text = Convert.ToDateTime(sRow["CreatedIn"].ToString()).ToShortDateString();
            MainModule.FrmObjectProperty.LblFolderUser.Text = sRow["UserName"].ToString();
            MainModule.FrmObjectProperty.TxtFolderDisc.Text = sRow["Disc"].ToString();
            MainModule.FunLib.GetAllprivilege();
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Clear();
            MainModule.FrmObjectProperty.FoldersFilesTabControl.Controls.Add(MainModule.FrmObjectProperty.FoldersTabPage);
            MainModule.FrmObjectProperty.Text = "خصائص المجلد";
            //Privilage Effect

            if (sRow["CanWrite"].ToString() == "0") //Chech for Write privilage
            {
                MainModule.FrmObjectProperty.BtnEditFolderName.Enabled = false;
                MainModule.FrmObjectProperty.BtnSaveFolder.Enabled = false;
            }
            else
            {
                MainModule.FrmObjectProperty.BtnEditFolderName.Enabled = true;
                MainModule.FrmObjectProperty.BtnSaveFolder.Enabled = true;
            }
            MainModule.FrmObjectProperty.ShowDialog();
        }
        public void FoldersRemoveToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (TVGFoldersGeneral.SelectedNode == null)
                return;
            //Check if the folder have files or folders
            if (TVGFoldersGeneral.SelectedNode.Nodes.Count != 0 || LVFilesGeneral.Items.Count != 0)
            {
                MCls.msg("المجلد ليس فارغ", true, "", this);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            Enabled = false;
            DataRow sRow = FolderGeneralTbl.Rows[(int)TVGFoldersGeneral.SelectedNode.Tag];
            string RemoveFolderErrorResult = MainModule.FunLib.RemoveFolder(sRow["FolderID"].ToString());
            if (RemoveFolderErrorResult == null)
            {
                //remove the Phy folder
                MainModule.NWLib.RemoveFolder(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.ProjectsPath + sRow["FolderPath"], MainModule.DeletedFilesPath);
                MCls.msg("تم الحذف", false, "", this);
                //Reload TreeView
                LoadFoldersRoot();
            }
            Enabled = true;
        }
        public void lockToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (LVFilesGeneral.SelectedIndices.Count == 0)
                return;
            DataRow sRow = FileGeneral.Rows[(int)LVFilesGeneral.SelectedItems[0].Tag];
            if (FileGeneral.Rows[(int)LVFilesGeneral.SelectedItems[0].Tag]["InUse"].ToString() == "0")
            {
                ErrorProviderZ = MainModule.FunLib.LockFile(sRow["FileID"].ToString(), MainModule.FunLib.CUser.UID);
                if (ErrorProviderZ == null)
                    MCls.msg("تم الغلق", false, "", this);
                else
                    MCls.msg(ErrorProviderZ, true, "", this);
            }
            else
            {
                ErrorProviderZ = MainModule.FunLib.UnLockFile(sRow["FileID"].ToString());
                if (ErrorProviderZ == null)
                    MCls.msg("تم الفتح", false, "", this);
                else
                    MCls.msg(ErrorProviderZ, true, "", this);
            }
            RelaodFilesInListView();
        }
        public void TransferToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (LVFilesGeneral.SelectedIndices.Count == 0)
                return;
            MainModule.FrmTransfer = new TransferFrm();
            MainModule.FrmTransfer.FileID = FileGeneral.Rows[LVFilesGeneral.SelectedIndices[0]]["FileID"].ToString();
            MainModule.FrmTransfer.FilePath = FileGeneral.Rows[LVFilesGeneral.SelectedIndices[0]]["FilePath"].ToString();
            MainModule.FrmTransfer.ShowDialog();
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
        private void tSMIStuTransfer_Click(object sender, EventArgs e)
        {
            if (LVFilesStudent.SelectedIndices.Count == 0)
                return;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.Cancel)
                return;
            string FileName = StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]]["FilePath"].ToString();
            //if (File.Exists(MainModule.StudentFilesPath + FileName))
            //{
            //}
            //else
            //    MCls.msg("الملف مفقود", true, "", this);
            try
            {
                ReciveFile(MainModule.ServerIP, Convert.ToInt16(MainModule.REQPort), MainModule.StudentFilesPath + FileName, fbd.SelectedPath + "\\" + FileName);
                //MCls.msg("تم النسخ", false, "", this);
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
            }
        }
        private void TSMIStuDelFiles_Click(object sender, EventArgs e)
        {
            if (LVFilesStudent.SelectedItems.Count == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                cmd.CommandText = "Delete From StuFileInfo Where StuFileID = " + StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]]["StuFileID"];
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                cmd.ExecuteNonQuery();
                string DFilePath = MainModule.StudentFilesPath + StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]]["FilePath"];
                string DelDir = String.Format("{0}{1}-{2}-{3}\\", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                MainModule.NWLib.CreateFolder(MainModule.ServerIP, int.Parse(MainModule.REQPort), DelDir);
                //MainModule.NWLib.RemoveFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), DFilePath, String.Format("{0}{1}", DelDir, StudentTbl.Rows[LVFilesStudent.SelectedIndices[0]]["FilePath"]));
                MainModule.NWLib.RemoveFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), DFilePath, MainModule.DeletedFilesPath);
                trn.Commit();
                LoadStudent(true);
                MCls.msg("تم الحذف", false, "", this);
            }
            catch (SqlException ex)
            {
                trn.Rollback();
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
            if (LVFilesEmp.SelectedItems.Count == 0 && CBEmp.SelectedIndex == -1)
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
            //if (File.Exists(MainModule.EmpFilesPath + FileName))
            //{
            //}
            //else
            //    MCls.msg("الملف مفقود", true, "", this);
            try
            {
                ReciveFile(MainModule.ServerIP, Convert.ToInt16(MainModule.REQPort), MainModule.EmpFilesPath + FileName, fbd.SelectedPath + "\\" + FileName);
                //MCls.msg("تم النسخ", false, "", this);
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
            }
        }
        private void TSMIEmpDelFiles_Click(object sender, EventArgs e)
        {
            if (LVFilesEmp.SelectedItems.Count == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                cmd.CommandText = "Delete From EmpFileInfo Where EmpFileID = " + EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]]["EmpFileID"];
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                cmd.ExecuteNonQuery();
                string DFilePath = MainModule.EmpFilesPath + EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]]["FilePath"];
                string DelDir = String.Format("{0}{1}-{2}-{3}\\", MainModule.DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                MainModule.NWLib.CreateFolder(MainModule.ServerIP, int.Parse(MainModule.REQPort), DelDir);
                //MainModule.NWLib.RemoveFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), DFilePath, String.Format("{0}{1}", DelDir, EmpTbl.Rows[LVFilesEmp.SelectedIndices[0]]["FilePath"]));
                MainModule.NWLib.RemoveFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), DFilePath, MainModule.DeletedFilesPath);
                trn.Commit();
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
        #region   -  Tool bar menus  -
        public void LargeIconToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            LVFilesGeneral.View = View.LargeIcon;
            LVFilesStudent.View = View.LargeIcon;
        }
        public void SmallIconToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            LVFilesGeneral.View = View.SmallIcon;
            LVFilesStudent.View = View.SmallIcon;
        }
        public void DetailsToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            LVFilesGeneral.View = View.Details;
            LVFilesStudent.View = View.Details;
        }
        public void ListToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            LVFilesGeneral.View = View.List;
            LVFilesStudent.View = View.List;
        }
        public void LockedfilesStripButton_Click(Object sender, EventArgs e)
        {
            LockedFilesToolStripMenuItem_Click(sender, e);
        }
        public void OptionsToolStripButton_Click(Object sender, EventArgs e)
        {
            OptionsToolStripMenuItem_Click(sender, e);
        }
        #endregion
        #endregion
    }
}
