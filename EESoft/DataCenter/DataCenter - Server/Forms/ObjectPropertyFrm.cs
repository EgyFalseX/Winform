using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.IO;
using FunctionLib;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace DataCenter_Server
{
	public partial class ObjectPropertyFrm
	{
		public ObjectPropertyFrm()
		{
			InitializeComponent();
		}
		private short Int1;
		private short Int2;
		private string NewFolderErrorResult = "";
        private string ErrorProvider;
		public DataCenterServerLib.privilegeType[] SelectedPrv;
		public DataCenterServerLib.privilegeType[] UnSelectedPrv;
        public DataCenterServerLib.privilegeType[] SelectedUser;
        public DataCenterServerLib.privilegeType[] UnSelectedUser;
		//private DataCenterServerLib.privilegeType[] TempPrv;
	
        public void ObjectPropertyFrm_Load(Object sender, EventArgs e)
        {

        }
        public void BtnCancel_Click(Object sender, EventArgs e)
        {
            Close();
        }
        public void LBAllprivileges_DoubleClick(object sender, EventArgs e)
        {
            if (LBAllprivileges.SelectedIndex != -1)
                BtnAddSelected_Click(sender, e);
        }
        public void LBAllprivileges_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (LBAllprivileges.SelectedIndex != -1)
                BtnAddSelected.Enabled = true;
            else
                BtnAddSelected.Enabled = false;
            BtnSavePriv.Enabled = true;
        }
        public void BtnAddSelected_Click(Object sender, EventArgs e)
        {
            if (SelectedPrv == null)
                SelectedPrv = new DataCenterServerLib.privilegeType[1];
            else
                Array.Resize(ref SelectedPrv, SelectedPrv.Length + 1);
            SelectedPrv[SelectedPrv.Length - 1] = UnSelectedPrv[LBAllprivileges.SelectedIndex];
            if (UnSelectedPrv.Length > 1)
            {
                DataCenterServerLib.privilegeType[] TempPrv = new DataCenterServerLib.privilegeType[UnSelectedPrv.Length - 1 + 1];
                Array.Copy(UnSelectedPrv, TempPrv, UnSelectedPrv.Length);
                UnSelectedPrv = new DataCenterServerLib.privilegeType[1];
                for (Int1 = 0; Int1 <= TempPrv.Length - 1; Int1++)
                {
                    if (Int1 != LBAllprivileges.SelectedIndex)
                    {
                        UnSelectedPrv[UnSelectedPrv.Length - 1] = TempPrv[Int1];
                        Array.Resize(ref UnSelectedPrv, UnSelectedPrv.Length + 1);
                    }
                }
                Array.Resize(ref UnSelectedPrv, UnSelectedPrv.Length - 2 + 1);
            }
            else
            {
                UnSelectedPrv = new DataCenterServerLib.privilegeType[0];
            }
            LBSelectedprivileges.Items.Add(LBAllprivileges.SelectedItem.ToString());
            LBAllprivileges.Items.Remove(LBAllprivileges.SelectedItem);
        }
        public void LBSelectedprivileges_DoubleClick(object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
                BtnRemoveSelected_Click(sender, e);
        }
        public void LBSelectedprivileges_GotFocus(object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
            {
                CBDelete.Enabled = true;
                CBWrite.Enabled = true;
            }
            else
            {
                CBDelete.Enabled = false;
                CBWrite.Enabled = false;
            }
        }
        public void LBSelectedprivileges_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
            {
                BtnRemoveSelected.Enabled = true;
                CBDelete.Enabled = true;
                CBWrite.Enabled = true;
                CBAdd.Enabled = true;
                CBView.Enabled = true;
                if (SelectedPrv[LBSelectedprivileges.SelectedIndex].CanWrite == 0)
                    CBWrite.Checked = false;
                else
                    CBWrite.Checked = true;
                if (SelectedPrv[LBSelectedprivileges.SelectedIndex].CanDelete == 0)
                    CBDelete.Checked = false;
                else
                    CBDelete.Checked = true;
                if (SelectedPrv[LBSelectedprivileges.SelectedIndex].CanAdd == 0)
                    CBAdd.Checked = false;
                else
                    CBAdd.Checked = true;
                if (SelectedPrv[LBSelectedprivileges.SelectedIndex].CanView == 0)
                    CBView.Checked = false;
                else
                    CBView.Checked = true;
            }
            else
            {
                CBDelete.Enabled = false;
                CBWrite.Enabled = false;
                CBAdd.Enabled = false;
                CBView.Enabled = false;
                CBDelete.Checked = false;
                CBWrite.Checked = false;
                CBAdd.Checked = false;
                CBView.Checked = false;
                BtnRemoveSelected.Enabled = false;
            }
        }
        public void BtnRemoveSelected_Click(Object sender, EventArgs e)
        {
            if (UnSelectedPrv == null)
                UnSelectedPrv = new DataCenterServerLib.privilegeType[1];
            else
                Array.Resize(ref UnSelectedPrv, UnSelectedPrv.Length + 1);
            UnSelectedPrv[UnSelectedPrv.Length - 1] = SelectedPrv[LBSelectedprivileges.SelectedIndex];
            if (SelectedPrv.Length > 1)
            {
                DataCenterServerLib.privilegeType[] TempPrv = new DataCenterServerLib.privilegeType[SelectedPrv.Length - 1 + 1];
                Array.Copy(SelectedPrv, TempPrv, SelectedPrv.Length);
                SelectedPrv = new DataCenterServerLib.privilegeType[1];
                for (Int1 = 0; Int1 <= TempPrv.Length - 1; Int1++)
                {
                    if (Int1 != LBSelectedprivileges.SelectedIndex)
                    {
                        SelectedPrv[SelectedPrv.Length - 1] = TempPrv[Int1];
                        Array.Resize(ref SelectedPrv, SelectedPrv.Length + 1);
                    }
                }
                Array.Resize(ref SelectedPrv, SelectedPrv.Length - 2 + 1);
            }
            else
                SelectedPrv = new DataCenterServerLib.privilegeType[0];
            LBAllprivileges.Items.Add(LBSelectedprivileges.SelectedItem.ToString());
            LBSelectedprivileges.Items.Remove(LBSelectedprivileges.SelectedItem);
        }
        public void BtnAddAll_Click(Object sender, EventArgs e)
        {
            for (Int1 = 0; Int1 <= LBAllprivileges.Items.Count - 1; Int1++)
            {
                if (SelectedPrv == null)
                    SelectedPrv = new DataCenterServerLib.privilegeType[1];
                else
                    Array.Resize(ref SelectedPrv, SelectedPrv.Length + 1);
                SelectedPrv[SelectedPrv.Length - 1] = UnSelectedPrv[Int1];
                LBSelectedprivileges.Items.Add(LBAllprivileges.Items[Int1]);
            }
            UnSelectedPrv = new DataCenterServerLib.privilegeType[0];
            LBAllprivileges.Items.Clear();
        }
        public void BtnBtnRemoveAll_Click(Object sender, EventArgs e)
        {
            for (Int1 = 0; Int1 <= LBSelectedprivileges.Items.Count - 1; Int1++)
            {
                if (UnSelectedPrv == null)
                    UnSelectedPrv = new DataCenterServerLib.privilegeType[1];
                else
                    Array.Resize(ref UnSelectedPrv, UnSelectedPrv.Length + 1);
                UnSelectedPrv[UnSelectedPrv.Length - 1] = SelectedPrv[Int1];
                LBAllprivileges.Items.Add(LBSelectedprivileges.Items[Int1]);
            }
            SelectedPrv = new DataCenterServerLib.privilegeType[0];
            LBSelectedprivileges.Items.Clear();
        }
        public void BtnEditFolderName_Click(Object sender, EventArgs e)
        {
            if (BtnEditFolderName.Text == "تعديل")
            {
                BtnEditFolderName.Text = "الغاء";
                TxtFolderName.Enabled = true;
            }
            else
            {
                BtnEditFolderName.Text = "تعديل";
                TxtFolderName.Text = MCls.LoadDataTable(String.Format("Select FolderName From FolderInfo Where FolderID = N'{0}'", MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name), "").Rows[0]["FolderName"].ToString();
                TxtFolderName.Enabled = false;
            }
        }
        public void BtnSavePriv_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.No)
                return;
            if (MainModule.PropertyObjectInfo.ObjecyType == MainModule.ObjectType.ExistedFolder) //If the folder existed in the array
            {
                if (SelectedPrv != null)
                {
                    SqlConnection con = new SqlConnection(MCls.SQLConStr);
                    SqlCommand cmd = new SqlCommand("", con);
                    SqlTransaction trn = null;
                    try
                    {
                        con.Open();
                        trn = con.BeginTransaction();
                        cmd.Transaction = trn;
                        //Delete Prev for this folder
                        cmd.CommandText = string.Format("Delete From Folder_Rull Where FolderID = '{0}'", MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name);
                        cmd.ExecuteNonQuery();
                        foreach (DataCenterServerLib.privilegeType Prv in SelectedPrv)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO Folder_Rull
                            (FRID, FolderID, RullID, CanWrite, CanDelete, CanAdd, CanView)
                            VALUES ('{0}', N'{1}', N'{2}', {3}, {4}, {5}, {6})", MCls.GetNewID("Folder_Rull", "FRID"), MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name,
                            Prv.privilegeID, Prv.CanWrite, Prv.CanDelete, Prv.CanAdd, Prv.CanView);
                            cmd.ExecuteNonQuery();
                        }
                        trn.Commit();
                        MCls.msg("تم الحقـــظ", false, "", this);
                    }
                    catch (SqlException ex)
                    {
                        trn.Rollback();
                        MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                    }
                    con.Close();
                }
            }
        }
        public void BtnSaveFolder_Click(Object sender, EventArgs e)
        {
            ErrorProvider = null;
            if (TxtFolderName.Enabled == true && TxtFolderName.Text.Trim().Length > 0)
            {
                //string[] arr = MainModule.FunLib.Folders[MainModule.PropertyObjectInfo.FolderIndex].FolderPath.Split("\\".ToCharArray());
                string[] arr = MCls.LoadDataTable("Select FolderPath From FolderInfo Where FolderID = N'" + MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name + "'", "").Rows[0]["FolderPath"].ToString().Split("\\".ToCharArray());
                string NewPath = "";
                short i;
                for (i = 0; i <= arr.Length - 2; i++)
                    NewPath += (string)(arr[i] + "\\");
                NewPath += TxtFolderName.Text.Trim();
                bool DoneFalg = false;
                DoneFalg = MainModule.FunLib.ChagneFolderName(MainModule.PropertyObjectInfo.FolderIndex.ToString(), TxtFolderName.Text.Trim(), NewPath, MainModule.ProjectsPath);
                if (DoneFalg == true)
                {
                    MainModule.FrmMainForm.LVFilesGeneral.Items.Clear();
                    
                    BtnEditFolderName.Text = "تعديل";
                    TxtFolderName.Enabled = false;
                    MainModule.MsgBox_("تم التعديل", 10, 3, true, this);
                }
                else
                {
                    MainModule.MsgBox_("لم يتم التعديل", 3, 23, false, this);
                }
                
            }
            ErrorProvider = MainModule.FunLib.SaveFolderDesc(MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name, TxtFolderDisc.Text.Trim());
            MainModule.MsgBox_("تم التعديل", 96, 23, true, this);
            MainModule.FrmMainForm.LoadFoldersRoot();
        }
        public void BtnEditFileName_Click(Object sender, EventArgs e)
        {
            if (BtnEditFileName.Text == "تعديل")
            {
                BtnEditFileName.Text = "الغاء";
                TxtFileName.Enabled = true;
            }
            else
            {
                BtnEditFileName.Text = "تعديل";
                TxtFileName.Enabled = false;
            }
        }
        public void BtnBrowseNewFile_Click(Object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            FileInfo FileInf;
            OFD.Filter = "All Files (*.*)|*.*";
            OFD.CheckFileExists = true;
            OFD.CheckPathExists = true;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FileInf = new FileInfo(OFD.FileName);
                if ((int)(FileInf.Length / 1048576) > 50)
                    Interaction.MsgBox("الملف اكبر من 50 ميجا", MsgBoxStyle.Information, null);
                else
                    LblNewFilePath.Text = OFD.FileName;
            }
            else
                LblNewFilePath.Text = string.Empty;
        }
        public void TxtNewFileName_TextChanged(Object sender, EventArgs e)
        {
            if (TxtNewFileName.Text.Trim().Length > 0 && LblNewFilePath.Text.Trim().Length > 0)
                BtnSaveNewFile.Enabled = true;
            else
                BtnSaveNewFile.Enabled = false;
        }
        public void BtnSaveNewFile_Click(Object sender, EventArgs e)
        {
            string FileType = "MDC";
            if (FileTypeCB.SelectedIndex != -1)
                FileType = ((DataTable)FileTypeCB.DataSource).Rows[FileTypeCB.SelectedIndex]["TypeExt"].ToString();
            string[] FilePathFolders = LblNewFilePath.Text.Split("\\".ToCharArray());
            string NewFileName = FilePathFolders[FilePathFolders.Length - 1];
            DataTable FolderInfo_ = MCls.LoadDataTable(String.Format("Select FolderID, FolderName, FolderPath From FolderInfo Where FolderID = N'{0}'", MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name), "");
            for (Int1 = 0; Int1 <= 10000; Int1++)
            {
                NewFileName = String.Format("{0}_{1}.{2}", FilePathFolders[FilePathFolders.Length - 1], Int1, FileType);
                if (!File.Exists(String.Format("{0}\\{1}", MainModule.ProjectsPath + FolderInfo_.Rows[0]["FolderPath"], NewFileName)))
                {
                    //Copying File
                    try
                    {
                        FileStream FSR = new FileStream(LblNewFilePath.Text, FileMode.Open, FileAccess.Read, FileShare.Read, 4096);
                        FileStream FSW = new FileStream(MainModule.ProjectsPath + FolderInfo_.Rows[0]["FolderPath"] + "\\" + NewFileName, FileMode.Create, FileAccess.Write, FileShare.Write, 4096);
                        byte[] Byt = new byte[4097];
                        long FSRLen = FSR.Length;
                        NewFileProgressBar.Visible = true;
                        NewFileProgressBar.Value = 0;
                        NewFileProgressBar.Maximum = (int)(FSR.Length / 4096);
                        this.Enabled = false;
                        for (Int2 = 0; Int2 <= FSR.Length / 4096; Int2++)
                        {
                            Application.DoEvents();
                            NewFileProgressBar.Value = Int2;
                            if ((FSRLen - FSW.Length) > 4096)
                            {
                                FSR.Read(Byt, 0, 4096);
                                FSW.Write(Byt, 0, 4096);
                            }
                            else
                            {
                                FSR.Read(Byt, 0, (int)(FSRLen - FSW.Length));
                                FSW.Write(Byt, 0, (int)(FSR.Length - FSW.Length));
                            }
                        }
                        NewFileProgressBar.Value = 0;
                        NewFileProgressBar.Visible = false;
                        FSR.Close();
                        FSW.Close();
                    }
                    catch (Exception ex)
                    {
                        //Perpare Error MSG
                        MainModule.MsgBox_(ex.Message, 0, 20, false, this);
                        return;
                    }

                    string TypeID = "";
                    string TheResultID = "no";
                    if (FileTypeCB.SelectedIndex == -1)
                        TypeID = "0001";
                    else
                        TypeID = ((DataTable)FileTypeCB.DataSource).Rows[FileTypeCB.SelectedIndex]["TypeID"].ToString();
                    MainModule.FunLib.InsertNewFile(TxtNewFileName.Text.Trim(), FolderInfo_.Rows[0]["FolderPath"] + "\\" + NewFileName, DateTime.Now.Date.ToShortDateString(), "0001", TxtNewFileDesc.Text.Trim(), MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name, TypeID, ref TheResultID);
                    Enabled = true;
                    if (TheResultID != "no")
                    {
                        //Reload files in LV in main form
                        MainModule.FrmMainForm.RelaodFilesInListView();
                        //Perpare Complate MSG
                        MainModule.MsgBox_("تم الحفــــظ", 45, 23, true, this);
                        BtnCancel.Focus();
                    }
                    else
                        goto ErrorS;
                    return;
                }
            }
        ErrorS:
            if (File.Exists(MainModule.ProjectsPath + FolderInfo_.Rows[0]["FolderPath"] + "\\" + NewFileName))
                File.Delete(MainModule.ProjectsPath + FolderInfo_.Rows[0]["FolderPath"] + "\\" + NewFileName);
            //Perpare Error MSG
            MainModule.MsgBox_("لم يتم الحفــــظ", 43, 23, false, this);
            BtnCancel.Focus();
        }
        public void BtnSaveFile_Click(Object sender, EventArgs e)
        {
            string ErrorResult = "";
            ErrorResult = MainModule.FunLib.EditFileInfo(MainModule.FrmMainForm.LVFilesGeneral.SelectedItems[0].Name, TxtFileName.Text.Trim(), TxtDisc.Text.Trim());
            //Prepare MSG form
            if (ErrorResult == null)
            {
                MainModule.MsgBox_("تم الحفـــــــظ", 45, 23, true, this);
                MainModule.FrmMainForm.RelaodFilesInListView();
                Close();
            }
            else
                MainModule.MsgBox_(ErrorResult, (short)0, (short)23, false, this);
        }
        public void TxtNewFolderName_TextChanged(Object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            for (Int1 = 0; Int1 <= TB.Text.Trim().Length - 1; Int1++)
            {
                if (!char.IsLetterOrDigit(TB.Text.Trim(), Int1) && TB.Text[Int1].ToString() != "_" && TB.Text[Int1].ToString() != " ")
                {
                    TB.Text = string.Empty;
                    //Prepare the Error MSG
                    MainModule.MsgBox_("من فضلك ادخل ارقام و حروف فقط", 98, 23, false, this);
                    break;
                }
            }
            DataTable FolderInfo_ = MCls.LoadDataTable(String.Format("Select FolderName, FolderPath From FolderInfo Where FolderID = N'{0}'", MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name), "");
            if (TxtNewFolderName.Text.Trim().Length > 0)
            {
                LblNewFolderPath.Text = String.Format("{0}\\{1}", MainModule.ProjectsPath + FolderInfo_.Rows[0]["FolderPath"], TxtNewFolderName.Text.Trim());
                BtnNewFolderSave.Enabled = true;
            }
            else
            {
                BtnNewFolderSave.Enabled = false;
                LblNewFolderPath.Text = FolderInfo_.Rows[0]["FolderPath"].ToString();
            }

        }
        public void BtnNewFolderSave_Click(Object sender, EventArgs e)
        {
            //Try to Create the folder on the hard disk
            if (!Directory.Exists(LblNewFolderPath.Text))
            {
                try
                {
                    Directory.CreateDirectory(LblNewFolderPath.Text);
                }
                catch (Exception ex)
                {
                    //Folder FAILED to create, sub will exit
                    //Prepare the Error MSG
                    MainModule.MsgBox_(ex.Message, 0, 23, false, this);
                    return;
                }
            }
            //Adding Folder to the database
            NewFolderErrorResult = MainModule.FunLib.InsertNewFolder(TxtNewFolderName.Text.Trim(), LblNewFolderPath.Text.Substring(MainModule.ProjectsPath.Length), DateTime.Now.Date.ToShortDateString(), MainModule.AdminID, TxtNewFolderDesc.Text.Trim(), MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name);
            if (NewFolderErrorResult != null)
            {
                //Set Privilages
                // i already stop priv tab 2 apper in new folder//MainModule.FunLib.SaveFolderprivileges(NewFolderErrorResult, UnSelectedPrv, false);
                // i already stop priv tab 2 apper in new folder//MainModule.FunLib.SaveFolderprivileges(NewFolderErrorResult, SelectedPrv, true);
                MainModule.FunLib.GetSelectedFolderprivilege(NewFolderErrorResult);
                //adding the new folder to the treeview in main form
                TreeNode NewTreeNode = new TreeNode(TxtNewFolderName.Text.Trim()) { Name = NewFolderErrorResult};
                MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Nodes.Add(NewTreeNode);
                //Prepare the complate MSG
                MainModule.MsgBox_("تم الانشاء", 94, 23, true, this);
            }
            else
            {
                //Remove the created folder
                if (Directory.Exists(LblNewFolderPath.Text))
                {
                    string[] ArrFiles;
                    string[] ArrFolders;
                    ArrFiles = Directory.GetFiles(LblNewFolderPath.Text);
                    ArrFolders = Directory.GetDirectories(LblNewFolderPath.Text);
                    if (ArrFiles.Length == 0 && ArrFolders.Length == 0)
                    {
                        try
                        {
                            Directory.Delete(LblNewFolderPath.Text);
                        }
                        catch
                        {
                        }
                        MainModule.MsgBox_("لم يتم الانشاء", 89, 23, false, this);
                    }
                }
            }
        }
        public void TxtFolderName_TextChanged(Object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            for (Int1 = 0; Int1 <= TB.Text.Trim().Length - 1; Int1++)
            {
                if (!char.IsLetterOrDigit(TB.Text.Trim(), Int1) && TB.Text[Int1].ToString() != "_" && TB.Text[Int1].ToString() != " ")
                {
                    TB.Text = string.Empty;
                    //Prepare the Error MSG
                    MainModule.MsgBox_("من فضلك ادخل ارقام و حروف فقط", 98, 23, false, this);
                    break;
                }
            }
        }
        public void CBWrite_CheckedChanged(Object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
            {
                if (CBWrite.Checked == true)
                    SelectedPrv[LBSelectedprivileges.SelectedIndex].CanWrite = 1;
                else
                    SelectedPrv[LBSelectedprivileges.SelectedIndex].CanWrite = 0;
            }
        }
        public void CBDelete_CheckedChanged(Object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
            {
                if (CBDelete.Checked == true)
                    SelectedPrv[LBSelectedprivileges.SelectedIndex].CanDelete = 1;
                else
                    SelectedPrv[LBSelectedprivileges.SelectedIndex].CanDelete = 0;
            }
        }
        private void CBAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
            {
                if (CBAdd.Checked == true)
                    SelectedPrv[LBSelectedprivileges.SelectedIndex].CanAdd = 1;
                else
                    SelectedPrv[LBSelectedprivileges.SelectedIndex].CanAdd = 0;
            }
        }
        private void CBView_CheckedChanged(object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
            {
                if (CBView.Checked == true)
                    SelectedPrv[LBSelectedprivileges.SelectedIndex].CanView = 1;
                else
                    SelectedPrv[LBSelectedprivileges.SelectedIndex].CanView = 0;
            }
        }
        private void LBAllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBAllUsers.SelectedIndex != -1)
                BtnAddSelectedUser.Enabled = true;
            else
                BtnAddSelectedUser.Enabled = false;
            BtnSaveUser.Enabled = true;
        }
        private void LBAllUsers_DoubleClick(object sender, EventArgs e)
        {
            if (LBAllUsers.SelectedIndex != -1)
                BtnAddSelectedUser_Click(sender, e);
        }
        private void LBSelectedUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBSelectedUsers.SelectedIndex != -1)
            {
                BtnRemoveSelectedUser.Enabled = true;
                CBDeleteUser.Enabled = true;
                CBWriteUser.Enabled = true;
                CBAddUser.Enabled = true;
                CBViewUser.Enabled = true;
                if (SelectedUser[LBSelectedUsers.SelectedIndex].CanWrite == 0)
                    CBWriteUser.Checked = false;
                else
                    CBWriteUser.Checked = true;
                if (SelectedUser[LBSelectedUsers.SelectedIndex].CanDelete == 0)
                    CBDeleteUser.Checked = false;
                else
                    CBDeleteUser.Checked = true;
                if (SelectedUser[LBSelectedUsers.SelectedIndex].CanAdd == 0)
                    CBAddUser.Checked = false;
                else
                    CBAddUser.Checked = true;
                if (SelectedUser[LBSelectedUsers.SelectedIndex].CanView == 0)
                    CBViewUser.Checked = false;
                else
                    CBViewUser.Checked = true;
            }
            else
            {
                CBDeleteUser.Enabled = false;
                CBWriteUser.Enabled = false;
                CBAddUser.Enabled = false;
                CBViewUser.Enabled = false;
                CBDeleteUser.Checked = false;
                CBWriteUser.Checked = false;
                CBAddUser.Checked = false;
                CBViewUser.Checked = false;
                BtnRemoveSelectedUser.Enabled = false;
            }
        }
        private void LBSelectedUsers_DoubleClick(object sender, EventArgs e)
        {
            if (LBSelectedUsers.SelectedIndex != -1)
                BtnRemoveSelectedUser_Click(sender, e);
        }
        private void BtnAddAllUsers_Click(object sender, EventArgs e)
        {
            for (Int1 = 0; Int1 <= LBAllUsers.Items.Count - 1; Int1++)
            {
                if (SelectedUser == null)
                    SelectedUser = new DataCenterServerLib.privilegeType[1];
                else
                    Array.Resize(ref SelectedUser, SelectedUser.Length + 1);
                SelectedUser[SelectedUser.Length - 1] = UnSelectedUser[Int1];
                LBSelectedUsers.Items.Add(LBAllUsers.Items[Int1]);
            }
            UnSelectedUser = new DataCenterServerLib.privilegeType[0];
            LBAllUsers.Items.Clear();
        }
        private void BtnAddSelectedUser_Click(object sender, EventArgs e)
        {
            if (SelectedUser == null)
                SelectedUser = new DataCenterServerLib.privilegeType[1];
            else
                Array.Resize(ref SelectedUser, SelectedUser.Length + 1);
            SelectedUser[SelectedUser.Length - 1] = UnSelectedUser[LBAllUsers.SelectedIndex];
            if (UnSelectedUser.Length > 1)
            {
                DataCenterServerLib.privilegeType[] TempPrv = new DataCenterServerLib.privilegeType[UnSelectedUser.Length - 1 + 1];
                Array.Copy(UnSelectedUser, TempPrv, UnSelectedUser.Length);
                UnSelectedUser = new DataCenterServerLib.privilegeType[1];
                for (Int1 = 0; Int1 <= TempPrv.Length - 1; Int1++)
                {
                    if (Int1 != LBAllUsers.SelectedIndex)
                    {
                        UnSelectedUser[UnSelectedUser.Length - 1] = TempPrv[Int1];
                        Array.Resize(ref UnSelectedUser, UnSelectedUser.Length + 1);
                    }
                }
                Array.Resize(ref UnSelectedUser, UnSelectedUser.Length - 2 + 1);
            }
            else
            {
                UnSelectedUser = new DataCenterServerLib.privilegeType[0];
            }
            LBSelectedUsers.Items.Add(LBAllUsers.SelectedItem.ToString());
            LBAllUsers.Items.Remove(LBAllUsers.SelectedItem);
        }
        private void BtnRemoveSelectedUser_Click(object sender, EventArgs e)
        {
            if (UnSelectedUser == null)
                UnSelectedUser = new DataCenterServerLib.privilegeType[1];
            else
                Array.Resize(ref UnSelectedUser, UnSelectedUser.Length + 1);
            UnSelectedUser[UnSelectedUser.Length - 1] = SelectedUser[LBSelectedUsers.SelectedIndex];
            if (SelectedUser.Length > 1)
            {
                DataCenterServerLib.privilegeType[] TempPrv = new DataCenterServerLib.privilegeType[SelectedUser.Length - 1 + 1];
                Array.Copy(SelectedUser, TempPrv, SelectedUser.Length);
                SelectedUser = new DataCenterServerLib.privilegeType[1];
                for (Int1 = 0; Int1 <= TempPrv.Length - 1; Int1++)
                {
                    if (Int1 != LBSelectedUsers.SelectedIndex)
                    {
                        SelectedUser[SelectedUser.Length - 1] = TempPrv[Int1];
                        Array.Resize(ref SelectedUser, SelectedUser.Length + 1);
                    }
                }
                Array.Resize(ref SelectedUser, SelectedUser.Length - 2 + 1);
            }
            else
                SelectedUser = new DataCenterServerLib.privilegeType[0];
            LBAllUsers.Items.Add(LBSelectedUsers.SelectedItem.ToString());
            LBSelectedUsers.Items.Remove(LBSelectedUsers.SelectedItem);
        }
        private void BtnBtnRemoveAllUser_Click(object sender, EventArgs e)
        {
            for (Int1 = 0; Int1 <= LBSelectedUsers.Items.Count - 1; Int1++)
            {
                if (UnSelectedUser == null)
                    UnSelectedUser = new DataCenterServerLib.privilegeType[1];
                else
                    Array.Resize(ref UnSelectedUser, UnSelectedUser.Length + 1);
                UnSelectedUser[UnSelectedUser.Length - 1] = SelectedUser[Int1];
                LBAllUsers.Items.Add(LBSelectedUsers.Items[Int1]);
            }
            SelectedUser = new DataCenterServerLib.privilegeType[0];
            LBSelectedUsers.Items.Clear();
        }
        private void CBAddUser_CheckedChanged(object sender, EventArgs e)
        {
            if (LBSelectedUsers.SelectedIndex != -1)
            {
                if (CBAddUser.Checked == true)
                    SelectedUser[LBSelectedUsers.SelectedIndex].CanAdd = 1;
                else
                    SelectedUser[LBSelectedUsers.SelectedIndex].CanAdd = 0;
            }
        }
        private void CBViewUser_CheckedChanged(object sender, EventArgs e)
        {
            if (LBSelectedUsers.SelectedIndex != -1)
            {
                if (CBViewUser.Checked == true)
                    SelectedUser[LBSelectedUsers.SelectedIndex].CanView = 1;
                else
                    SelectedUser[LBSelectedUsers.SelectedIndex].CanView = 0;
            }
        }
        private void CBWriteUser_CheckedChanged(object sender, EventArgs e)
        {
            if (LBSelectedUsers.SelectedIndex != -1)
            {
                if (CBWriteUser.Checked == true)
                    SelectedUser[LBSelectedUsers.SelectedIndex].CanWrite = 1;
                else
                    SelectedUser[LBSelectedUsers.SelectedIndex].CanWrite = 0;
            }
        }
        private void CBDeleteUser_CheckedChanged(object sender, EventArgs e)
        {
            if (LBSelectedUsers.SelectedIndex != -1)
            {
                if (CBDeleteUser.Checked == true)
                    SelectedUser[LBSelectedUsers.SelectedIndex].CanDelete = 1;
                else
                    SelectedUser[LBSelectedUsers.SelectedIndex].CanDelete = 0;
            }
        }
        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.No)
                return;
            if (MainModule.PropertyObjectInfo.ObjecyType == MainModule.ObjectType.ExistedFolder) //If the folder existed in the array
            {
                if (SelectedUser != null)
                {
                    SqlConnection con = new SqlConnection(MCls.SQLConStr);
                    SqlCommand cmd = new SqlCommand("", con);
                    SqlTransaction trn = null;
                    try 
                    {
                        con.Open();
                        trn = con.BeginTransaction();
                        cmd.Transaction = trn;
                        //Delete All Users for this folder
                        cmd.CommandText = string.Format("Delete From Folder_User Where FolderID = '{0}'", MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name);
                        cmd.ExecuteNonQuery();
                        foreach (DataCenterServerLib.privilegeType User in SelectedUser)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO Folder_User
                            (FUID, FolderID, UsrID, CanWrite, CanDelete, CanAdd, CanView)
                            VALUES ('{0}', N'{1}', N'{2}', {3}, {4}, {5}, {6})", MCls.GetNewID("Folder_User", "FUID"), MainModule.FrmMainForm.TVGFoldersGeneral.SelectedNode.Name,
                            User.privilegeID, User.CanWrite, User.CanDelete, User.CanAdd, User.CanView);
                            cmd.ExecuteNonQuery();
                        }
                        trn.Commit();
                        MCls.msg("تم الحقـــظ", false, "", this);
	                }
	                catch (SqlException ex)
	                {
                        trn.Rollback();
                        MCls.msg(MCls.CheckExp(ex) , true,ex.Number.ToString(),this);
	                }
                    con.Close();
                }
            }
        }

	}
}
