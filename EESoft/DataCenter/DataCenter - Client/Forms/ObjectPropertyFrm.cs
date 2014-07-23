using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using FunctionLib;
using System.Data.SqlClient;

namespace DataCenter_Client
{
	public partial class ObjectPropertyFrm
	{
		public ObjectPropertyFrm()
		{
			InitializeComponent();
		}
		private short Int1;
		private string NewFolderErrorResult = "";
		private string ErrorProvider = null;
		private string[] Add = new string[1];
        public void BtnNewFolderSave_Click(Object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            //MainModule.PropertyObjectInfo

            //Try to Create the folder on the hard disk
            ErrorProvider = null;
            ErrorProvider = MainModule.NWLib.CreateFolder(MainModule.ServerIP, int.Parse(MainModule.REQPort), String.Format("{0}{1}\\{2}", MainModule.ProjectsPath , MainModule.PropertyObjectInfo.FolderPath, TxtNewFolderName.Text.Trim()));
            if (ErrorProvider != null)
            {
                MCls.msg(ErrorProvider, true, "", this);
                return;
            }
            //Adding Folder to the database
            NewFolderErrorResult = MainModule.FunLib.InsertNewFolder(TxtNewFolderName.Text.Trim(), String.Format("{0}\\{1}", MainModule.PropertyObjectInfo.FolderPath, TxtNewFolderName.Text.Trim()), DateTime.Now.Date.ToString(), MainModule.FunLib.CUser.UID, TxtNewFolderDesc.Text.Trim(), MainModule.PropertyObjectInfo.FolderIndex);
            if (NewFolderErrorResult != null)
            {
                string FolderID = MCls.LoadDataTable("SELECT TOP (1) FolderID FROM FolderInfo ORDER BY FolderID DESC", "").Rows[0][0].ToString();
                SqlConnection con = new SqlConnection(MCls.SQLConStr);
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"INSERT INTO Folder_User (FUID, FolderID, UsrID, CanWrite, CanDelete, CanAdd, CanView)
                    VALUES ((SELECT ISNULL(MAX(FUID) + 1, 1) AS NewID FROM Folder_User), N'{0}', N'{1}', 1, 1, 1, 1)", FolderID, MainModule.FunLib.CUser.UID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MainModule.FrmMainWindow.LoadFoldersRoot();
                    MCls.msg("تم الاضافه", false, "", this);
                }
                catch (SqlException ex)
                {
                    MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                }
                con.Close();
            }
            else
            {
                //Remove the created folder
                MCls.msg("لم نتكمن من اضافة المجلد", true, "", this);
            }
        }
        public void BtnCancel_Click(Object sender, EventArgs e)
        {
            Close();
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
                TxtFolderName.Enabled = false;
            }
        }
        public void BtnSaveNewFile_Click(Object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            Enabled = false;
            string FileType = "EDC";
            if (FileTypeCB.SelectedIndex != -1)
                FileType = ((DataTable)FileTypeCB.DataSource).Rows[FileTypeCB.SelectedIndex]["TypeExt"].ToString();
            //Creating Filename to save the Phy file
            string[] FilePathFolders = LblNewFilePath.Text.Split("\\".ToCharArray());
            string NewFileName = "";
            NewFileProgressBar.Visible = true;
            ErrorProvider = null;
            ErrorProvider = MainModule.CreateFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), LblNewFilePath.Text.Trim(), MainModule.ProjectsPath + MainModule.PropertyObjectInfo.FolderPath + "\\", FilePathFolders[FilePathFolders.Length - 1], FileType, ref NewFileName);
            if (ErrorProvider != null)
            {
                NewFileProgressBar.Value = 0;
                NewFileProgressBar.Maximum = 0;
                MainModule.FrmObjectProperty.Text = "خصائص الملف الجديد";
                MCls.msg(ErrorProvider, true, "", this);
                return;
            }


            string TypeID = "";
            string TheResultID = "no";
            if (FileTypeCB.SelectedIndex == -1)
                TypeID = "1";
            else
                TypeID = ((DataTable)FileTypeCB.DataSource).Rows[FileTypeCB.SelectedIndex]["TypeID"].ToString();
            MainModule.FunLib.InsertNewFile(TxtNewFileName.Text.Trim(), NewFileName.Replace(MainModule.ProjectsPath,string.Empty), DateTime.Now.Date.ToString(), MainModule.FunLib.CUser.UID, TxtNewFileDesc.Text.Trim(), MainModule.PropertyObjectInfo.FolderIndex, TypeID, ref TheResultID);
            Enabled = true;
            if (TheResultID != "no")
            {
                //Reload files in LV in main form
                MainModule.FrmMainWindow.RelaodFilesInListView();
                MCls.msg("تم الاضافه", false, "", this);
                BtnCancel.Focus();
            }
            else
                MCls.msg("لم نتمكن من الاضافه", true, "", this);
            Enabled = true;
            return;
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
                    MCls.msg("يجب ادخال ارقام و حروف فقط", true, "", this);
                    break;
                }
            }
            if (MainModule.PropertyObjectInfo.ObjecyType == MainModule.ObjectType.ExistedFolder)
            {
                if (TB.Text.Trim().Length > 0)
                {
                    LblFolderPath.Text = String.Format("{0}\\{1}", MainModule.PropertyObjectInfo.FolderPath, TB.Text.Trim());
                    BtnSaveFolder.Enabled = true;
                }
                else
                {
                    BtnSaveFolder.Enabled = false;
                    LblFolderPath.Text = MainModule.PropertyObjectInfo.FolderPath;
                }
            }
            else
            {
                if (TB.Text.Trim().Length > 0)
                {
                    LblNewFolderPath.Text = String.Format("{0}\\{1}", MainModule.PropertyObjectInfo.FolderPath, TB.Text.Trim());
                    BtnNewFolderSave.Enabled = true;
                }
                else
                {
                    BtnNewFolderSave.Enabled = false;
                    LblNewFolderPath.Text = MainModule.PropertyObjectInfo.FolderPath;
                }
            }
        }
        public void TxtNewFileName_TextChanged(Object sender, EventArgs e)
        {
            if (TxtNewFileName.Text.Trim().Length > 0 && LblNewFilePath.Text.Trim().Length > 0)
                BtnSaveNewFile.Enabled = true;
            else
                BtnSaveNewFile.Enabled = false;
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
                if ((int)(FileInf.Length / 1048576) > MainModule.DefaultFileSize)
                    MessageBox.Show(String.Format("الملف اكبر من {0} ميجا", MainModule.DefaultFileSize), "تحزير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    LblNewFilePath.Text = OFD.FileName;
            }
            else
                LblNewFilePath.Text = "";
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
        public void BtnSaveFile_Click(Object sender, EventArgs e)
        {
            string ErrorResult = "";
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            ErrorResult = MainModule.FunLib.EditFileInfo(MainModule.PropertyObjectInfo.FileIndex, TxtFileName.Text.Trim(), TxtDisc.Text.Trim(), ((DataTable)CBEditFileType.DataSource).Rows[CBEditFileType.SelectedIndex]["TypeID"].ToString());
            //Prepare MSG form
            if (ErrorResult == null)
            {
                //MsgBox_("Update complate", 126, 23, True, Me)
                MCls.msg("تم التعديل", false, "", this);
                MainModule.FrmMainWindow.RelaodFilesInListView();
            }
            else
                MCls.msg(ErrorResult, true, "", this);
        }
        public void BtnSaveFolder_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure?", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
                return;
            if (TxtFolderName.Enabled == false || TxtFolderName.Text.Trim().Length == 0)
               return;

            Enabled = false;
            string[] arr = MainModule.PropertyObjectInfo.FolderPath.Split("\\".ToCharArray());
            string NewPath = "";
            short i;
            for (i = 0; i <= arr.Length - 2; i++)
            {
                NewPath += (string)(arr[i] + "\\");
            }
            NewPath += TxtFolderName.Text.Trim();
            string Disc;
            if (TxtFolderDisc.Text.Trim().Length != 0)
                Disc = String.Format("N'{0}'", TxtFolderDisc.Text.Trim());
            else
                Disc = "NULL";
            
            try
            {
                if (MainModule.NWLib.MoveFolder(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.ProjectsPath + MainModule.PropertyObjectInfo.FolderPath, MainModule.ProjectsPath + NewPath) != null)
                {
                    MCls.msg("خطــــــــــــاء في نقل المجلد", true, "", this);
                    return;
                }
                if (MainModule.FunLib.ChagneFolderName(MainModule.PropertyObjectInfo.FolderIndex, TxtFolderName.Text.Trim(), NewPath, Disc, MainModule.ProjectsPath) == false)
                {
                    //return renamed folders
                    MainModule.NWLib.MoveFolder(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.ProjectsPath + NewPath, MainModule.ProjectsPath + MainModule.PropertyObjectInfo.FolderPath);
                    MCls.msg("خطــــــــــــاء في حفظ البيانات", true, "", this);
                    return;
                }
                BtnEditFolderName.Text = "تعديل";
                TxtFolderName.Enabled = false;
                MainModule.FrmMainWindow.LoadFoldersRoot();
                MCls.msg("تم التعديل", false, "", this);
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            Enabled = true;
        }
	}
}
