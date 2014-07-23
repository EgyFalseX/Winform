using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using FunctionLib;

namespace DataCenter_Server
{
	public partial class OptionsFrm
	{
		public OptionsFrm()
		{
			InitializeComponent();
		}
		private FolderBrowserDialog OFD = new FolderBrowserDialog();
        private string ErrorProvider;
        public void OptionsFrm_Load(Object sender, EventArgs e)
        {
            MainModule.FrmOptions.TxtPassword.Text = MainModule.DefaultUserPassword;
            MainModule.FrmOptions.TxtProjectPath.Text = MainModule.ProjectsPath;
            MainModule.FrmOptions.TxtServerPort.Text = MainModule.ServerPort;
            MainModule.FrmOptions.TxtServerIP.Text = MainModule.ServerIP;
            MainModule.FrmOptions.TxtDeletedFiles.Text = MainModule.DeletedFilesPath;
            MainModule.FrmOptions.TxtStudentFilesPath.Text = MainModule.StudentFilesPath;
            MainModule.FrmOptions.TxtEmpFilesPath.Text = MainModule.EmpFilesPath;
        }
        public void TxtServerOptions_TextChanged(Object sender, EventArgs e)
        {
            if (TxtPassword.Text.Trim().Length < 1 || TxtProjectPath.Text.Trim().Length < 1 ||TxtDeletedFiles.Text.Trim().Length < 1 || TxtStudentFilesPath.Text.Trim().Length < 1)
                BtnSaveServerOptions.Enabled = false;
            else
                BtnSaveServerOptions.Enabled = true;
        }
        public void BtnBrowseProjectPath_Click(Object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                TxtProjectPath.Text = OFD.SelectedPath;
                if (TxtProjectPath.Text[TxtProjectPath.Text.Length - 1] != char.Parse("\\"))
                    TxtProjectPath.Text += "\\";
            }
        }
        public void BtnBrowseDeletedFiles_Click(Object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                TxtDeletedFiles.Text = OFD.SelectedPath;
                if (TxtDeletedFiles.Text[TxtDeletedFiles.Text.Length - 1] != char.Parse("\\"))
                    TxtDeletedFiles.Text += "\\";
            }
        }
        private void BtnBrowseStudentFiles_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                TxtStudentFilesPath.Text = OFD.SelectedPath;
                if (TxtStudentFilesPath.Text[TxtStudentFilesPath.Text.Length - 1] != char.Parse("\\"))
                    TxtStudentFilesPath.Text += "\\";
            }
        }
        private void BtnBrowseEmpFiles_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                TxtEmpFilesPath.Text = OFD.SelectedPath;
                if (TxtEmpFilesPath.Text[TxtEmpFilesPath.Text.Length - 1] != char.Parse("\\"))
                    TxtEmpFilesPath.Text += "\\";
            }
        }
        public void BtnClose_Click(Object sender, EventArgs e)
        {
            Close();
        }
        public void BtnSave_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.No)
                return;
            ErrorProvider = null;
            ErrorProvider = MainModule.FunLib.SaveServerOptions(TxtPassword.Text.Trim(), TxtProjectPath.Text.Trim(), "", TxtDeletedFiles.Text.Trim(), TxtStudentFilesPath.Text.Trim(), TxtEmpFilesPath.Text.Trim());
            if (ErrorProvider == null)
            {
                MainModule.FunLib.SetRegValue(TxtDeletedFiles.Text.Trim(), FunctionLib.DataCenterServerLib.RegKeyValues.DeletedFilesPath);
                MainModule.DefaultUserPassword = TxtPassword.Text.Trim();
                MainModule.ProjectsPath = TxtProjectPath.Text.Trim();
                //MainModule.RelatedFiles = TxtRelatedFiles.Text.Trim();
                MainModule.DeletedFilesPath = TxtDeletedFiles.Text.Trim();
                MainModule.StudentFilesPath = TxtStudentFilesPath.Text.Trim();
                MainModule.EmpFilesPath = TxtEmpFilesPath.Text.Trim();
                FunctionLib.MCls.msg("تم الحفظ اعد تشغيل البرنامج", false,"",this);
            }
            else
                FunctionLib.MCls.msg("لم يتم الحفظ", true, "", this);
        }
        public void TxtClientOptions_TextChanged(Object sender, EventArgs e)
        {
            if (TxtServerIP.Text.Trim().Length < 1 || TxtServerPort.Text.Trim().Length < 1)
                BtnSaveClientOptions.Enabled = false;
            else
                BtnSaveClientOptions.Enabled = true;
        }
        public void BtnSaveClientOptions_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.No)
                return;
            ErrorProvider = null;
            ErrorProvider = MainModule.FunLib.SaveClientOptions(TxtServerIP.Text.Trim(), TxtServerPort.Text.Trim());
            if (ErrorProvider == null)
            {
                MainModule.FunLib.SetRegValue(TxtServerPort.Text.Trim(), FunctionLib.DataCenterServerLib.RegKeyValues.GeneralPort);
                MainModule.FunLib.SetRegValue(TxtServerIP.Text.Trim(), FunctionLib.DataCenterServerLib.RegKeyValues.ServerIP);
                MainModule.ServerIP = TxtServerIP.Text.Trim();
                MainModule.ServerPort = TxtServerPort.Text.Trim();
                MainModule.MsgBox_("تم الحفظ يجب اعادة تشغيل برنامج الخدمات", 25, 23, true, this);
            }
            else
                MainModule.MsgBox_("لم يتم الحفظ", 119, 23, false, this);
        }
        private void TC_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == StudentTabPage)
            {
                DataTable stu = MCls.LoadDataTable("Select Count(stu_code) From Student", "");
                DataTable filez = MCls.LoadDataTable("Select Count(StuFileID) From StuFileInfo", "");
                if (stu.Rows.Count != 0)
                    TxtStuCount.Text = stu.Rows[0][0].ToString();
                else
                    TxtStuCount.Text = "0";
                if (filez.Rows.Count != 0)
                    txtStuFileCount.Text = filez.Rows[0][0].ToString();
                else
                    txtStuFileCount.Text = "0";
            } if (e.TabPage == EmpTabPage)
            {
                DataTable Emp = MCls.LoadDataTable("Select Count(Code) From Emp", "");
                DataTable filez = MCls.LoadDataTable("Select Count(EmpFileID) From EmpFileInfo", "");
                if (Emp.Rows.Count != 0)
                    TxtEmpCount.Text = Emp.Rows[0][0].ToString();
                else
                    TxtEmpCount.Text = "0";
                if (filez.Rows.Count != 0)
                    txtEmpFileCount.Text = filez.Rows[0][0].ToString();
                else
                    txtEmpFileCount.Text = "0";
            }
        }
        private void BtnSyncData_Click(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files (*.*)|*.*", CheckFileExists = true, CheckPathExists = true };
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            TC.Enabled = false;
            SqlConnection sqlcon = new SqlConnection(MCls.SQLConStr);
            SqlCommand sqlcmd = new SqlCommand("", sqlcon);
            SqlTransaction trn = null;
            OleDbDataAdapter da = new OleDbDataAdapter("", String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"{0}\"", ofd.FileName));

            //DataTable Srcasase = new DataTable();// Sana El derasya
            //da.SelectCommand.CommandText = "Select asase_code, asase_year From asase";
            //da.Fill(Srcasase);
            //DataTable Srcalsofof = new DataTable();//El Sofoof
            //da.SelectCommand.CommandText = "Select alsofof_code, alsofof_name From alsofof";
            //da.Fill(Srcalsofof);
            //DataTable Srcfasl = new DataTable();// El fosol
            //da.SelectCommand.CommandText = "Select fasl_code, fasl_name From fasl";
            //da.Fill(Srcfasl);
            DataTable SrcStuNames = new DataTable();// El Tolab
            da.SelectCommand.CommandText = "Select stu_code, stu_name From student";
            da.Fill(SrcStuNames);
            DataTable SrcStuDetail = new DataTable();// Tfasel El Tolab
            da.SelectCommand.CommandText = "Select stu_code, asase_code, alsofof_code, fasl_code From student_t";
            da.Fill(SrcStuDetail);

            //PB.Maximum = Srcasase.Rows.Count + Srcalsofof.Rows.Count + Srcfasl.Rows.Count + SrcStuNames.Rows.Count + SrcStuDetail.Rows.Count;
            PB.Maximum = SrcStuNames.Rows.Count + SrcStuDetail.Rows.Count;
            PB.Value = 0;
            try
            {
                sqlcon.Open();
                trn = sqlcon.BeginTransaction();
                sqlcmd.Transaction = trn;
//                foreach (DataRow RowSrcasase in Srcasase.Rows)// Sync Year Table
//                {
//                    PB.Value++;
//                    Application.DoEvents();
//                    sqlcmd.CommandText = string.Format(@"if exists(Select * From asase Where asase_code = {0})
//                    Update asase Set asase_year = N'{1}' Where asase_code = {0}
//                    Else
//                    Insert Into asase (asase_code, asase_year) VALUES ({0}, N'{1}')", RowSrcasase["asase_code"], RowSrcasase["asase_year"]);
//                    sqlcmd.ExecuteNonQuery();
//                }
//                foreach (DataRow RowSrcalsofof in Srcalsofof.Rows)// Sync El Sofoof
//                {
//                    PB.Value++;
//                    Application.DoEvents();
//                    sqlcmd.CommandText = string.Format(@"if exists(Select * From alsofof Where alsofof_code = {0})
//                    Update alsofof Set alsofof_name = N'{1}' Where alsofof_code = {0}
//                    Else
//                    Insert Into alsofof (alsofof_code, alsofof_name) VALUES ({0}, N'{1}')", RowSrcalsofof["alsofof_code"], RowSrcalsofof["alsofof_name"]);
//                    sqlcmd.ExecuteNonQuery();
//                }
//                foreach (DataRow RowSrcSrcfasl in Srcfasl.Rows)// Sync El Fsool
//                {
//                    PB.Value++;
//                    Application.DoEvents();
//                    sqlcmd.CommandText = string.Format(@"if exists(Select * From fasl Where fasl_code = {0})
//                    Update fasl Set fasl_name = N'{1}' Where fasl_code = {0}
//                    Else
//                    Insert Into fasl (fasl_code, fasl_name) VALUES ({0}, N'{1}')", RowSrcSrcfasl["fasl_code"], RowSrcSrcfasl["fasl_name"]);
//                    sqlcmd.ExecuteNonQuery();
//                }
                foreach (DataRow RowSrcStuNames in SrcStuNames.Rows)// Sync Students Names Table
                {
                    PB.Value++;
                    Application.DoEvents();
                    sqlcmd.CommandText = string.Format(@"if exists(Select * From Student Where stu_code = {0})
                    Update Student Set stu_name = N'{1}' Where stu_code = {0}
                    Else
                    Insert Into Student (stu_code, stu_name) VALUES ({0}, N'{1}')", RowSrcStuNames["stu_code"], RowSrcStuNames["stu_name"]);
                    sqlcmd.ExecuteNonQuery();
                }
                foreach (DataRow RowSrcStuDetail in SrcStuDetail.Rows)// Sync Student Details Table
                {
                    PB.Value++;
                    Application.DoEvents();
                    sqlcmd.CommandText = string.Format(@"if not exists(Select * From student_t Where stu_code = {0} And asase_code = {1} And alsofof_code = {2} And fasl_code = {3}) 
                    Insert Into student_t (stu_code, asase_code, alsofof_code, fasl_code) VALUES ({0}, {1}, {2}, {3})",
                    RowSrcStuDetail["stu_code"], RowSrcStuDetail["asase_code"], RowSrcStuDetail["alsofof_code"], RowSrcStuDetail["fasl_code"]);
                    sqlcmd.ExecuteNonQuery();
                }

                trn.Commit();   
            }
            catch (OleDbException ex)
            {
                trn.Rollback();
                MCls.msg(ex.Message, true, "", this);
            }
            sqlcon.Close();
            PB.Value = 0;
            TC.Enabled = true;
        }
        private void BtnEmpSyncData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files (*.*)|*.*", CheckFileExists = true, CheckPathExists = true };
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            SqlConnection sqlcon = new SqlConnection(MCls.SQLConStr);
            SqlCommand sqlcmd = new SqlCommand("", sqlcon);
            SqlTransaction trn = null;
            OleDbDataAdapter da = new OleDbDataAdapter("", String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"{0}\"", ofd.FileName));
            TC.Enabled = false;
            DataTable Emp = new DataTable();// Sana El derasya
            da.SelectCommand.CommandText = "Select CODE, NAME, TAT From بيانات_الموظفين_بالمدرية";
            da.Fill(Emp);
            PBEmp.Maximum = Emp.Rows.Count;
            PBEmp.Value = 0;
            try
            {
                sqlcon.Open();
                trn = sqlcon.BeginTransaction();
                sqlcmd.Transaction = trn;
                foreach (DataRow RowEmp in Emp.Rows)// Sync Year Table
                {
                    PBEmp.Value++;
                    Application.DoEvents();
                    sqlcmd.CommandText = string.Format(@"if exists(Select * From Emp Where Code = {0})
                    Update Emp Set Name = N'{1}', TAT = N'{2}' Where Code = {0}
                    Else
                    Insert Into Emp (Code, Name, TAT) VALUES ({0}, N'{1}', N'{2}')", RowEmp["CODE"], RowEmp["NAME"], RowEmp["TAT"]);
                    sqlcmd.ExecuteNonQuery();
                }
                trn.Commit();
                TC_Selected(TC, new TabControlEventArgs(EmpTabPage, 3,new TabControlAction()));
            }
            catch (OleDbException ex)
            {
                trn.Rollback();
                MCls.msg(ex.Message, true, "", this);
            }
            sqlcon.Close();
            PBEmp.Value = 0;
            TC.Enabled = true;
        }
	}
}