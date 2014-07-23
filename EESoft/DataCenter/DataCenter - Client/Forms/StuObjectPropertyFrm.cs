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
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic;

namespace DataCenter_Client
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
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                cmd.CommandText = string.Format(@"INSERT INTO StuFileInfo (StuFileID, FileName, FilePath, StuFileTypeID, CreatedIn, UsrID, Dis, stu_code, asase_code, alsofof_code, fasl_code)
                VALUES ({0}, {1}, N'{2}', {3}, '{4}', {5}, {6}, {7}, {8}, {9}, {10})", StuFileID, FileName, FilePath, StuFileTypeID, DateTime.Now.ToShortDateString(), MainModule.FunLib.CUser.UID, Dis, stu_code, asase_code, alsofof_code, fasl_code);
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                cmd.ExecuteNonQuery();
                if (UploadFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.StudentFilesPath + FilePath, NewFilePath))// Copy file... 
                {
                    trn.Commit();
                    MCls.msg("تم الاضافه", false, "", this);
                    BtnUpdate.Enabled = true;
                    BtnAddSave.Enabled = false;
                    Close();
                }
                else
                    trn.Rollback();
            }
            catch (SqlException ex)
            {
                trn.Rollback();
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
            SqlTransaction trn = null;
            if (FileChanged)// File Changed
            {
                if (NewFilePath.LastIndexOf(".") != -1)
                    FilePath = string.Format("{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, NewFilePath.Substring(NewFilePath.LastIndexOf(".")));
                else
                    FilePath = string.Format("{0}{1}{2}{3}{4}{5}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                
                cmd.CommandText = string.Format(@"UPDATE StuFileInfo SET FileName = {0}, FilePath = {1}, StuFileTypeID = {2}, CreatedIn = GETDATE(), Dis = {3}, stu_code = {4}, 
                asase_code = {5}, alsofof_code = {6}, fasl_code = {7}, UsrID = {8} WHERE (StuFileID = {9})", FileName, FilePath, StuFileTypeID, Dis, stu_code, asase_code, alsofof_code, fasl_code, MainModule.FunLib.CUser.UID, StuFileID);
            }
            else
            {
                cmd.CommandText = string.Format(@"UPDATE StuFileInfo SET FileName = {0}, StuFileTypeID = {1}, CreatedIn = GETDATE(), Dis = {2}, stu_code = {3}, 
                asase_code = {4}, alsofof_code = {5}, fasl_code = {6}, UsrID = {7} WHERE (StuFileID = {8})", FileName, StuFileTypeID, Dis, stu_code, asase_code, alsofof_code, fasl_code, MainModule.FunLib.CUser.UID, StuFileID);
            }
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                cmd.ExecuteNonQuery();
                if (FileChanged)
                {
                    MainModule.NWLib.RemoveFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.StudentFilesPath + MCls.LoadDataTable("Select FilePath From StuFileInfo Where StuFileID = " + StuFileID, "").Rows[0][0].ToString(), MainModule.DeletedFilesPath);
                    if (UploadFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.StudentFilesPath + FilePath, NewFilePath))
                    {
                        trn.Commit();
                        FileChanged = false;
                        MCls.msg("تم التعديل", false, "", this);
                    }
                }
                else
                {
                    trn.Commit();
                    MCls.msg("تم التعديل", false, "", this);
                }
                Close();
            }
            catch (SqlException ex)
            {
                trn.Rollback();
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool UploadFile(string IP_Address, int RPort, string ServerFilePath, string ClientFilePath)
        {
            string FullString;
            byte[] Buffers = new byte[4097];
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int Created;
            try
            {
                FileStream FileSRM = new FileStream(ClientFilePath, FileMode.Open, FileAccess.Read);
                if (FileSRM.Length == 0)
                {
                    MCls.msg("حجم الملف 0", true, "", this);
                    return false;
                }
                FullString = (int)NetworkFunction.Commands.SendFile  + ServerFilePath + "/" + MainModule.DeletedFilesPath + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "\\" + "/" + FileSRM.Length;
                PBAddFile.Maximum = (int)(FileSystem.FileLen(ClientFilePath));
                PBAddFile.Value = 0;
                Buffers = Encoding.Default.GetBytes(FullString);
                Sok.Connect(IP_Address, RPort);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, FullString.Length, SocketFlags.None);
                    Sok.Receive(Buffers, 1, SocketFlags.None);
                    Created = Convert.ToInt32(Conversion.Val(Buffers[0]));
                    if (Created == 1)
                    {
                        Buffers = new byte[4097];
                        do
                        {
                            Created = FileSRM.Read(Buffers, 0, 4096);
                            if (Created > 0)
                            {
                                Sok.Send(Buffers, Created, SocketFlags.None);
                                PBAddFile.Value += Created;
                            }
                            else
                            {
                                break;
                            }
                            Application.DoEvents();
                        } while (true);
                        PBAddFile.Value = 0;
                        //MCls.msg("تم التحميل", false, "", this);
                        return true;
                    }
                    else
                    {
                        Sok.Close();
                        Sok = null;
                        MCls.msg("لم يتم تحميل الملف", true, "", this);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
                return false;
            }
            return false;
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
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                cmd.CommandText = string.Format(@"INSERT INTO EmpFileInfo (EmpFileID, FileName, FilePath, StuFileTypeID, CreatedIn, Dis, Code, UsrID)
                VALUES ({0}, {1}, N'{2}', {3}, '{4}', {5}, {6}, {7})", EmpFileID, FileName, FilePath, StuFileTypeID, DateTime.Now.ToShortDateString(), Dis, Code, MainModule.FunLib.CUser.UID);
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                cmd.ExecuteNonQuery();
                if (UploadFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.EmpFilesPath + FilePath, NewFilePath))// Copy file... 
                {
                    trn.Commit();
                    BtnEmpUpdate.Enabled = true;
                    BtnEmpAddSave.Enabled = false;
                    MCls.msg("تم الاضافه", false, "", this);
                    Close();
                }
                else
                    trn.Rollback();
            }
            catch (SqlException ex)
            {
                trn.Rollback();
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnEmpUpdate_Click(object sender, EventArgs e)
        {
            if ((NewFilePath == string.Empty && FileChanged) || EmpFileID == string.Empty)
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
            SqlTransaction trn = null;
            if (FileChanged)// File Changed
            {
                if (NewFilePath.LastIndexOf(".") != -1)
                    FilePath = string.Format("{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, NewFilePath.Substring(NewFilePath.LastIndexOf(".")));
                else
                    FilePath = string.Format("{0}{1}{2}{3}{4}{5}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

                cmd.CommandText = string.Format(@"UPDATE EmpFileInfo SET FileName = {0}, FilePath = N'{1}', StuFileTypeID = {2}, CreatedIn = GETDATE(), Dis = {3}, Code = {4}, UsrID = {5}
                WHERE (EmpFileID = {6})", FileName, FilePath, StuFileTypeID, Dis, Code, MainModule.FunLib.CUser.UID, EmpFileID);
            }
            else
            {
                cmd.CommandText = string.Format(@"UPDATE EmpFileInfo SET FileName = {0}, StuFileTypeID = {1}, CreatedIn = GETDATE(), Dis = {2}, Code = {3}, UsrID = {4}
                WHERE (EmpFileID = {5})", FileName, StuFileTypeID, Dis, Code, MainModule.FunLib.CUser.UID, EmpFileID);
            }
            string OldFileName = MCls.LoadDataTable("SELECT FilePath FROM EmpFileInfo WHERE (EmpFileID = " + EmpFileID + ")", "").Rows[0][0].ToString();
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                cmd.ExecuteNonQuery();
                if (FileChanged)
                {
                    MainModule.NWLib.RemoveFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.EmpFilesPath + OldFileName, MainModule.DeletedFilesPath);
                    if (UploadFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.EmpFilesPath + FilePath, NewFilePath))
                    {
                        trn.Commit();
                        FileChanged = false;
                        MCls.msg("تم التعديل", false, "", this);
                    }
                }
                else
                {
                    trn.Commit();
                    MCls.msg("تم التعديل", false, "", this);
                }
                Close();
            }
            catch (SqlException ex)
            {
                trn.Rollback();
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
#endregion

    }
}
