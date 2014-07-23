using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FunctionLib;
using System.IO;
using System.Data.SqlClient;

namespace DataCenter_Server
{
    public partial class StuObjectPropertyFrm : Form
    {
        #region -   Variables   -
        public string StuFileID, FileName, FilePath, StuFileTypeID, CreatedIn, UsrID, Dis, stu_code, asase_code, alsofof_code, fasl_code, EmpFileID, Code;
        string NewFilePath = string.Empty;
        bool FileChanged;
        #endregion
        #region -   Functions   -
        public StuObjectPropertyFrm()
        {
            InitializeComponent();
        }
       public void LoadDtuFileType()
        {
            DataTable dt = MCls.LoadDataTable("Select StuFileTypeID, StuFileTypeName From StuFileType", "");
            CBAddFileType.DataSource = dt;
            CBAddFileType.DisplayMember = "StuFileTypeName";
            CBAddFileType.ValueMember = "StuFileTypeID";

            CBEmpAddFileType.DataSource = dt;
            CBEmpAddFileType.DisplayMember = "StuFileTypeName";
            CBEmpAddFileType.ValueMember = "StuFileTypeID";
        }
        private bool CopyFile(string From, string To)
        {
            try
            {
                FileStream FSR = new FileStream(From, FileMode.Open, FileAccess.Read, FileShare.Read, 4096);
                FileStream FSW = new FileStream(To, FileMode.Create, FileAccess.Write, FileShare.Write, 4096);
                byte[] Byt = new byte[4097];
                long FSRLen = FSR.Length;
                PBAddFile.Visible = true;
                PBAddFile.Value = 0;
                PBAddFile.Maximum = (int)(FSR.Length / 4096);
                Enabled = false;
                for (int i = 0; i <= FSR.Length / 4096; i++)
                {
                    Application.DoEvents();
                    PBAddFile.Value = i;
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
                PBAddFile.Value = 0;
                PBAddFile.Visible = false;
                FSR.Close();
                FSW.Close();
                Enabled = true;
                return true;
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
                Enabled = true;
                return false;
            }
            
        }
        #endregion
        #region - Event Handlers-
        private void BtnAddBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog() { Filter = "All Files (*.*)|*.*", CheckFileExists = true, CheckPathExists = true };
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                if ((int)(new FileInfo(OFD.FileName).Length / 1048576) > 50)
                    MCls.msg("الملف اكبر من 50 ميجا", true, "", this);
                else
                {
                    NewFilePath = OFD.FileName;
                    FileChanged = true;
                }
            }
            else
                NewFilePath = string.Empty;
        }
        private void BtnAddSave_Click(object sender, EventArgs e)
        {
            //MainModule.StudentFilesPath
            if (!File.Exists(NewFilePath.Trim()))
            {
                MCls.msg("من فضلك اختار ملف", true, "", this);
                return;
            }
            StuFileID = MCls.GetNewID("StuFileInfo", "StuFileID");
            if (TxtAddFileName.Text.Trim().Length != 0)
                FileName = String.Format("N'{0}'", TxtAddFileName.Text.Trim());
            else
                FileName = "NULL";
            if (NewFilePath.LastIndexOf(".") != -1)
                FilePath = string.Format("{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second,NewFilePath.Substring(NewFilePath.LastIndexOf(".")));
            else
                FilePath = string.Format("{0}{1}{2}{3}{4}{5}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (CBAddFileType.SelectedIndex != -1)
                StuFileTypeID = CBAddFileType.SelectedValue.ToString();
            else
                StuFileTypeID = "NULL";
            if (TxtAddDesc.Text.Trim().Length != 0)
                Dis = String.Format("N'{0}'", TxtAddDesc.Text.Trim());
            else
                Dis = "NULL";
            if (CopyFile(NewFilePath, MainModule.StudentFilesPath + FilePath) == false)// Copy file...
            {
                if (File.Exists(MainModule.StudentFilesPath + FilePath))
                    File.Delete(MainModule.StudentFilesPath + FilePath);
                return;
            }
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"INSERT INTO StuFileInfo (StuFileID, FileName, FilePath, StuFileTypeID, CreatedIn, UsrID, Dis, stu_code, asase_code, alsofof_code, fasl_code)
                VALUES ({0}, {1}, N'{2}', {3}, '{4}', NULL, {5}, {6}, {7}, {8}, {9})", StuFileID, FileName, FilePath, StuFileTypeID, DateTime.Now.ToShortDateString(), Dis, stu_code, asase_code, alsofof_code, fasl_code);
                con.Open();
                cmd.ExecuteNonQuery();
                BtnUpdate.Enabled = true;
                BtnAddSave.Enabled = false;
                MCls.msg("تم الاضافه", false, "", this);
                Close();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if ((NewFilePath == string.Empty && FileChanged) || StuFileID == string.Empty)
            {
                MCls.msg("من فضلك اختار ملف", true, "", this);
                return;
            }
            if (TxtAddFileName.Text.Trim().Length != 0)
                FileName = String.Format("N'{0}'", TxtAddFileName.Text.Trim());
            else
                FileName = "NULL";
            if (TxtAddDesc.Text.Trim().Length != 0)
                Dis = String.Format("N'{0}'", TxtAddDesc.Text.Trim());
            else
                Dis = "NULL";
            if (CBAddFileType.SelectedIndex != -1)
                StuFileTypeID = CBAddFileType.SelectedValue.ToString();
            else
                StuFileTypeID = "NULL";
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            if (FileChanged)// File Changed
            {
                if (NewFilePath.LastIndexOf(".") != -1)
                    FilePath = MainModule.StudentFilesPath + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + NewFilePath.Substring(NewFilePath.LastIndexOf("."));
                else
                    FilePath = MainModule.StudentFilesPath + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
                if (CopyFile(NewFilePath, FilePath) == false)// Copy file...
                {
                    if (File.Exists(FilePath))
                        File.Delete(FilePath);
                    return;
                }
                cmd.CommandText = string.Format(@"UPDATE StuFileInfo SET FileName = {0}, FilePath = {1}, StuFileTypeID = {2}, CreatedIn = GETDATE(), UsrID = NULL, Dis = {3}, stu_code = {4}, 
                asase_code = {5}, alsofof_code = {6}, fasl_code = {7} WHERE (StuFileID = {8})", FileName, FilePath, StuFileTypeID, Dis, stu_code, asase_code, alsofof_code, fasl_code, StuFileID);
            }
            else
            {
                cmd.CommandText = string.Format(@"UPDATE StuFileInfo SET FileName = {0}, StuFileTypeID = {1}, CreatedIn = GETDATE(), UsrID = NULL, Dis = {2}, stu_code = {3}, 
                asase_code = {4}, alsofof_code = {5}, fasl_code = {6} WHERE (StuFileID = {7})", FileName, StuFileTypeID, Dis, stu_code, asase_code, alsofof_code, fasl_code, StuFileID);
            }
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                FileChanged = false;
                MCls.msg("تم التعديل", false, "", this);
                Close();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnEmpAddBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog() { Filter = "All Files (*.*)|*.*", CheckFileExists = true, CheckPathExists = true };
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                if ((int)(new FileInfo(OFD.FileName).Length / 1048576) > 50)
                    MCls.msg("الملف اكبر من 50 ميجا", true, "", this);
                else
                {
                    NewFilePath = OFD.FileName;
                    FileChanged = true;
                }
            }
            else
                NewFilePath = string.Empty;
        }
        private void BtnEmpAddSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(NewFilePath.Trim()))
            {
                MCls.msg("من فضلك اختار ملف", true, "", this);
                return;
            }
            EmpFileID = MCls.GetNewID("EmpFileInfo", "EmpFileID");
            if (TxtEmpAddFileName.Text.Trim().Length != 0)
                FileName = String.Format("N'{0}'", TxtEmpAddFileName.Text.Trim());
            else
                FileName = "NULL";
            if (NewFilePath.LastIndexOf(".") != -1)
                FilePath = string.Format("{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, NewFilePath.Substring(NewFilePath.LastIndexOf(".")));
            else
                FilePath = string.Format("{0}{1}{2}{3}{4}{5}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (CBEmpAddFileType.SelectedIndex != -1)
                StuFileTypeID = CBEmpAddFileType.SelectedValue.ToString();
            else
                StuFileTypeID = "NULL";
            if (TxtEmpAddDesc.Text.Trim().Length != 0)
                Dis = String.Format("N'{0}'", TxtEmpAddDesc.Text.Trim());
            else
                Dis = "NULL";
            if (CopyFile(NewFilePath, MainModule.EmpFilesPath + FilePath) == false)// Copy file...
            {
                if (File.Exists(MainModule.EmpFilesPath + FilePath))
                    File.Delete(MainModule.EmpFilesPath + FilePath);
                return;
            }
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"INSERT INTO EmpFileInfo (EmpFileID, FileName, FilePath, StuFileTypeID, CreatedIn, UsrID, Dis, Code)
                VALUES ({0}, {1}, N'{2}', {3}, '{4}', NULL, {5}, {6})", EmpFileID, FileName, FilePath, StuFileTypeID, DateTime.Now.ToShortDateString(), Dis, Code);
                con.Open();
                cmd.ExecuteNonQuery();
                BtnEmpUpdate.Enabled = true;
                BtnEmpAddSave.Enabled = false;
                MCls.msg("تم الاضافه", false, "", this);
                Close();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnEmpUpdate_Click(object sender, EventArgs e)
        {
            if ((NewFilePath == string.Empty && FileChanged) || EmpFileID == null)
            {
                MCls.msg("من فضلك اختار ملف", true, "", this);
                return;
            }
            if (TxtEmpAddFileName.Text.Trim().Length != 0)
                FileName = String.Format("N'{0}'", TxtEmpAddFileName.Text.Trim());
            else
                FileName = "NULL";
            if (TxtEmpAddDesc.Text.Trim().Length != 0)
                Dis = String.Format("N'{0}'", TxtEmpAddDesc.Text.Trim());
            else
                Dis = "NULL";
            if (CBEmpAddFileType.SelectedIndex != -1)
                StuFileTypeID = CBEmpAddFileType.SelectedValue.ToString();
            else
                StuFileTypeID = "NULL";
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            if (FileChanged)// File Changed
            {
                if (NewFilePath.LastIndexOf(".") != -1)
                    FilePath = MainModule.EmpFilesPath + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + NewFilePath.Substring(NewFilePath.LastIndexOf("."));
                else
                    FilePath = MainModule.EmpFilesPath + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
                if (CopyFile(NewFilePath, FilePath) == false)// Copy file...
                {
                    if (File.Exists(FilePath))
                        File.Delete(FilePath);
                    return;
                }
                cmd.CommandText = string.Format(@"UPDATE EmpFileInfo SET FileName = {0}, FilePath = {1}, StuFileTypeID = {2}, CreatedIn = GETDATE(), UsrID = NULL, Dis = {3}, Code = {4}
                WHERE (EmpFileID = {5})", FileName, FilePath, StuFileTypeID, Dis, Code, EmpFileID);
            }
            else
            {
                cmd.CommandText = string.Format(@"UPDATE EmpFileInfo SET FileName = {0}, StuFileTypeID = {1}, CreatedIn = GETDATE(), UsrID = NULL, Dis = {2}, Code = {3}
                WHERE (EmpFileID = {4})", FileName, StuFileTypeID, Dis, Code, EmpFileID);
            }
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                FileChanged = false;
                MCls.msg("تم التعديل", false, "", this);
                Close();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
#endregion
        
    }
}
