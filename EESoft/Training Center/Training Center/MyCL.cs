using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.ServiceProcess;
using CrystalDecisions.CrystalReports.Engine;

namespace Training_Center
{
    public class MyCL
    {
        #region -   Variables   -

        public static string SqlConStr = string.Empty;
        public static UserInfoStruct UserInfo = new UserInfoStruct();
        public static readonly string DBPath = Application.StartupPath + "\\DBPath";
        public static readonly string CReportsPath = Application.StartupPath + "\\CReports";
        //public static readonly string ReportsPath = Application.StartupPath + "\\Reports";
        public static string ReportURL = string.Empty;
        public static string ReportPath = string.Empty;
        public static ReportType RepTy = ReportType.None;
        public static ReportTypeStr[] RepTyps;
        public static string ActionLog = string.Empty;
        public static CRReportsStr[] crRep;
        //Enums
        public enum ReportType
        {
            None
        }
        public struct UserInfoStruct
        {
            public string UserID;
            public string UserName;
        }
        public struct CRReportsStr
        {
            //public ReportClass CRReport;
            public ReportDocument CRReport;
            public string RepCaption;
        }
        public struct ReportTypeStr
        {
            public string RepName;
            public string RepCaption;
        }
        //Forms - Main
        public ActionLogFrm FrmActionLog;
        //Forms - Codes
        public CdBankAccountFrm FrmCdBankAccount;
        public CDCertificatesFrm FrmCDCertificates;
        public CDCourseTypeFrm FrmCDCourseType;
        public CdjobFrm FrmCdjob;
        public CDknowFrm FrmCDknow;
        public CdLabFrm FrmCdLab;
        public CDMembershipTypeFrm FrmCDMembershipType;
        public CdNationalityFrm FrmCdNationality;
        public CdPlaceFrm FrmCdPlace;
        public CDReservationWayFrm FrmCDReservationWay;
        public CDTrainingBagFrm FrmCDTrainingBag;
        //Forms - Permission
        public EditorRoleFrm FrmEditorRole;
        public EditorRoleMenuFrm FrmEditorRoleMenu;
        public EditorUserFrm FrmEditorUser;
        public EditorUserInRoleFrm FrmEditorUserInRole;
        //Forms - Data
        public TBLCoursesFrm FrmTBLCourses;
        public TBLCourseAgendaFrm FrmTBLCourseAgenda;
        public TBLReservationFrm FrmTBLReservation;
        public TBLTraineeFrm FrmTBLTrainee;
        public TBLTrainersFrm FrmTBLTrainers;
        public TBLCourseCertificatesFrm FrmTBLCourseCertificates;
        public TBLTraineeCertificatesFrm FrmTBLTraineeCertificates;
        public TBLPartnersFrm FrmTBLPartners;
        public TBLTrainersBagFrm FrmTBLTrainersBag;
        public TBLTrainersCoursesOutFrm FrmTBLTrainersCoursesOut;
        public TBLMemberShipFrm FrmTBLMemberShip;
        public TBLWebTraineeFrm FrmTBLWebTrainee;
        public TBLAccountsFrm FrmTBLAccounts;
        public TblAlkaznaFrm FrmTblAlkazna;
        public TBLWebReservationFrm FrmTBLWebReservation;
        //Forms - Options
        public DBImportFrm FrmDBImport;

        #endregion
        #region -   Functions   -
        public static void LoadCRReports()
        {
            if (!File.Exists(CReportsPath +  "\\CReports.txt"))// Check If DBPass is Exists
                return;
            using (StreamReader sr = new StreamReader(CReportsPath + "\\CReports.txt",Encoding.Default))// Read Connection String
            {
                crRep = new CRReportsStr[0];
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Array.Resize<CRReportsStr>(ref crRep, crRep.Length + 1);
                    string[] Parts = line.Split(Convert.ToChar(";"));
                    crRep[crRep.Length - 1].CRReport = new ReportDocument();
                    crRep[crRep.Length - 1].CRReport.Load(String.Format("{0}\\{1}", CReportsPath, Parts[0]));
                    crRep[crRep.Length - 1].RepCaption = Parts[1];
                }
            }
        }
        public static void ShowMsg(string Msg, bool IsError, Form ThisForm)
        {
            FrmMain ParentFrm = (FrmMain)ThisForm.Parent.Parent;
            ParentFrm.sSecMsg.Caption = Msg;
            if (IsError)
                ParentFrm.sSecMsg.Appearance.ForeColor = System.Drawing.Color.Red;
            else
                ParentFrm.sSecMsg.Appearance.ForeColor = System.Drawing.Color.Green;
            ActionLog += String.Format("[{0}] [{1}] : ({2}){3}", DateTime.Now.ToShortTimeString(), ThisForm.Text, Msg, Environment.NewLine);
        }
        public static string ConvertToDateDMY(string PDate)
        {

            string ReturnMe = string.Empty;
            DateTime MyDate = Convert.ToDateTime(PDate);
            ReturnMe = String.Format("{0}/{1}/{2}", MyDate.Day, MyDate.Month, MyDate.Year);
            return ReturnMe;
        }
        public static string ConvertToDateHMS(string PDate)
        {

            string ReturnMe = string.Empty;
            DateTime MyDate = Convert.ToDateTime(PDate);
            ReturnMe = String.Format("{0}:{1}:{2}", MyDate.Hour, MyDate.Minute, MyDate.Second);
            return ReturnMe;
        }
        public static Single ConvertStringToInt(string str)
        {
            string ReturnMe = string.Empty;
            int count = 0;
            foreach (char c in str.ToCharArray())
            {
                if (c == Convert.ToChar(".") && count < 1)
                {
                    ReturnMe += c.ToString();
                    count++;
                }
                if (char.IsNumber(c))
                {
                    ReturnMe += c.ToString();
                }
            }
            if (ReturnMe == string.Empty)
            {
                ReturnMe = "0";
            }
            return Convert.ToSingle(ReturnMe);
        }
        public static string CheckExp(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                    return "موجود مسبقا";
                case 515:
                    string ReturnMe = "يجب مليء " + Environment.NewLine;
                    int tempint = 0;
                    foreach (char Chr in ex.Message.ToCharArray())
                    {
                        //Get column name from error msg and its between ''
                        char Dot = '\'';

                        if (Chr == Dot)
                            tempint++;
                        if (tempint == 1)
                            ReturnMe += Chr;
                        else if (tempint == 2)
                            break;
                    }
                    return ReturnMe + "'";
                case 241:
                    return String.Format("خطاء في نوع البيان {0}من فضلك فحص الارقام و التواريخ", Environment.NewLine);
                case 242:
                    return String.Format("خطاء في ادخال التاريخ {0}من فضلك تأكد ان صياغة التاريخ هي {0}سنه/شهر/يوم", Environment.NewLine);
                default:
                    return ex.Message;
            }
        }
        public static bool CheckDBWorking(string AccessConnectionString)
        {
            using (SqlConnection con = new SqlConnection(AccessConnectionString))
            {
                try
                {
                    con.Open();
                    con.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static string ServerTest(string ServerName, string username, string pass)
        {
            using (SqlConnection Con = new SqlConnection(String.Format(@"Data Source={0};Persist Security Info=True;User ID={1};Password={2}", ServerName, username, pass)))
            {
                try
                {
                    Con.Open();
                    Con.Close();
                    return Con.ConnectionString;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
        }
        public static string ServerTest(string ServerName)
        {
            using (SqlConnection Con = new SqlConnection(String.Format(@"Data Source={0};Integrated Security=true", ServerName)))
            {
                try
                {
                    Con.Open();
                    Con.Close();
                    return Con.ConnectionString;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
        }
        public static DataTable GetAllDatabase(string Constr)
        {
            DataTable ReturnMe = new DataTable("FalseX2010");
            SqlConnection Con = new SqlConnection(Constr);
            SqlDataAdapter dr = new SqlDataAdapter("SELECT * FROM master.dbo.sysdatabases", Con);
            try
            {
                dr.Fill(ReturnMe);
            }
            catch (SqlException)
            {
            }
            return ReturnMe;
        }
        public static bool AttachDB(string DatabaseName, string DataPath, string LogPath, string ConStr)
        {
            bool ReturnMe = false;
            SqlConnection TempCon = new SqlConnection(ConStr);
            string PConStr = String.Format("Data Source={0};Integrated Security=true", TempCon.DataSource);
            SqlConnection Con = new SqlConnection(PConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = String.Format(@"EXEC sp_attach_db @dbname = N'{0}', @filename1 = N'{1}',@filename2 = N'{2}'", 
                DatabaseName, DataPath, LogPath);
                if (Cmd.ExecuteNonQuery() != 0)
                    ReturnMe = true;
                else
                    ReturnMe = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                ReturnMe = false;
            }
            Con.Close();
            return ReturnMe;
        }
        public static bool AttachDB(string DatabaseName, string DataPath, string ConStr)
        {
            //FOR ATTACH_REBUILD_LOG
            bool ReturnMe = false;
            SqlConnection TempCon = new SqlConnection(ConStr);
            string PConStr = String.Format("Data Source={0};Integrated Security=true", TempCon.DataSource);
            SqlConnection Con = new SqlConnection(PConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = @"CREATE DATABASE " + DatabaseName + @"
                                    ON(NAME='" + DatabaseName + @"', FILENAME='" + DataPath + @"')
                                    FOR ATTACH_REBUILD_LOG;";
                if (Cmd.ExecuteNonQuery() != 0)
                    ReturnMe = true;
                else
                    ReturnMe = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                ReturnMe = false;
            }
            Con.Close();
            return ReturnMe;
        }
        public static DataTable LoadDataTable(string CommandString)
        {
            DataTable ReturnMe = new DataTable("False2011-07");
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, MyCL.SqlConStr))
            {
                try { DA.Fill(ReturnMe); }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return ReturnMe;
        }
        public static string GetNewID(string TableName, string ColunmName)
        {
            string ReturnMe = string.Empty;
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    con.Open();
                    //cmd.CommandText = string.Format(@"SELECT IIF(IsNull(MAX({0})), 1, MAX({0}) + 1) AS NewID FROM {1}", ColunmName, TableName);
                    cmd.CommandText = string.Format(@"SELECT ISNULL(MAX({0}) + 1, 1) AS NewID FROM {1} AS NewID", ColunmName, TableName);
                    ReturnMe = cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            return ReturnMe;
        }
        public bool LoadUserInfo(string username, string password)
        {
            DataTable TblUser = LoadDataTable(String.Format(@"SELECT UserID, UserName, UserPass, IsActive FROM Users
                                                                          WHERE (UserName = N'{0}') AND (UserPass = N'{1}') AND (IsActive = 1)", username, password));
            foreach (DataRow row in TblUser.Rows)
            {
                UserInfo = new UserInfoStruct { UserID = row["UserID"].ToString(), UserName = row["UserName"].ToString() };
                return true;
            }
            return false;
        }
        private static bool SaveDBPath()
        {
            MessageBox.Show("Must Change");
            try
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                SqlConStr = string.Empty;

                OpenFileDialog OFD = new OpenFileDialog { CheckFileExists = true, CheckPathExists = true, Filter = "Access Database|*.mdb|All Files|*.*", Title = "اختار قاعدة بيانات" };
                if (OFD.ShowDialog() == DialogResult.Cancel)// Choose FileName
                        Application.Exit();
                SqlConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + OFD.FileName;// Assign FileName to Connection String
                if (CheckDBWorking(SqlConStr) == false)// Check if Connection is Working ...
                    return false;
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamWriter sr = File.CreateText(DBPath))// Save FileName To DBPass
                {
                    sr.WriteLine(OFD.FileName);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool SaveSQLDBPath()
        {
            try
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamWriter sr = File.CreateText(DBPath))// Save FileName To DBPass
                {
                    sr.WriteLine(String.Format("{0}|{1}|{2}", SqlConStr, ReportURL, ReportPath));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool LoadDBPath()
        {
            try
            {
                if (!File.Exists(DBPath))// Check If DBPass is Exists
                {
                    if (SaveDBPath() == false)
                    {
                        MessageBox.Show(String.Format("لم يتم اختيار قاعده البيانات بطريقه صحيحه{0}تم اغلاق البرنامج", Environment.NewLine));
                        Application.Exit();
                    }
                }
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(DBPath))
                {
                    SqlConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sr.ReadLine();
                    ReportURL = sr.ReadLine();
                    ReportPath = sr.ReadLine();
                }
                if (CheckDBWorking(SqlConStr))
                    return true;
                else
                {
                    if (File.Exists(DBPath))
                        File.Delete(DBPath);
                    Application.Restart();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool LoadSqlDBPath()
        {
            try
            {
                if (!File.Exists(DBPath))// Check If DBPass is Exists
                {
                    using (SQLConnectionFrm SqlFrm = new SQLConnectionFrm { DatabaseName = "AATSdata" })
                    {
                        SqlFrm.ShowDialog();
                    }
                }
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(DBPath))// Read Connection String
                {
                    string[] ConfigArr = sr.ReadLine().Split(Convert.ToChar("|"));
                    SqlConStr = ConfigArr[0];
                    ReportURL = ConfigArr[1];
                    ReportPath = ConfigArr[2];
                }
                //if (File.Exists(ReportsPath))// Check If ReportsPath is Exists
                //{
                //    using (StreamReader sr = new StreamReader(ReportsPath))// Read Reports
                //    {
                //        string line;
                //        while ((line = sr.ReadLine()) != null)
                //        {
                //            string[] ConfigArr = line.Split(Convert.ToChar(";"));
                //            if (RepTyps == null)
                //                RepTyps = new ReportTypeStr[1];
                //            else
                //                Array.Resize(ref RepTyps, RepTyps.Length + 1);
                //            RepTyps[RepTyps.Length - 1].RepName = ConfigArr[0];
                //            RepTyps[RepTyps.Length - 1].RepCaption = ConfigArr[1];

                //        }
                //    }
                //}
                if (CheckDBWorking(SqlConStr))
                    return true;
                else
                {
                    if (File.Exists(DBPath))
                        File.Delete(DBPath);
                    Application.Restart();
                    return false;
                }
            }
            catch
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                return false;
            }
        }
        #region -   Database Backup   -
        public static void DatabaseBackup(string DesPath, ref ProgressBar PB)
        {
            DataTable Pathz = MyCL.LoadDataTable("SELECT filename FROM sys.sysfiles");
            string DBFile = string.Empty, DBLog = string.Empty;
            DBFile = Pathz.Rows[0][0].ToString();
            DBLog = Pathz.Rows[1][0].ToString();
            string NewDBFile = string.Empty, NewDBLog = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog { FileName = DBFile };
            NewDBFile = String.Format(@"{0}\{1}", DesPath, ofd.SafeFileName);
            ofd.FileName = DBLog;
            NewDBLog = String.Format(@"{0}\{1}", DesPath, ofd.SafeFileName);
            if (!File.Exists(DBFile) || !File.Exists(DBLog))
            {
                //msg("Can't Backup, Database file not found ...!", true, "None", new Form());
                MessageBox.Show("Can't Backup, Database file not found ...!", "Error ..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PB.Value += 1;
            StopService("MSSQLSERVER", 120000);
            PB.Value += 1;
            Application.DoEvents();
            File.Copy(DBFile, NewDBFile, true);
            File.Copy(DBLog, NewDBLog, true);
            PB.Value += 1;
            Application.DoEvents();
            StartService("MSSQLSERVER", 120000);
            Application.DoEvents();
        }
        public static void DatabaseRestore(string DBFile, string DBLog, ref ProgressBar PB)
        {
            DataTable Pathz = MyCL.LoadDataTable("SELECT filename FROM sys.sysfiles");
            string NewDBFile = string.Empty, NewDBLog = string.Empty;
            NewDBFile = Pathz.Rows[0][0].ToString();
            NewDBLog = Pathz.Rows[1][0].ToString();
            if (!File.Exists(DBFile) || !File.Exists(DBLog))
            {
                //msg("Can't Restore, Database file not found ...!", true, "None", new Form());
                MessageBox.Show("Can't Restore, Database file not found ...!", "Error ..",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            PB.Value += 1;
            StopService("MSSQLSERVER", 120000);
            PB.Value += 1;
            Application.DoEvents();
            File.Copy(DBFile, NewDBFile, true);
            File.Copy(DBLog, NewDBLog, true);
            PB.Value += 1;
            Application.DoEvents();
            StartService("MSSQLSERVER", 120000);
            Application.DoEvents();
        }
        public static void StartService(string serviceName, int timeoutMilliseconds)
        {
            using (ServiceController service = new ServiceController(serviceName))
            {
                try
                {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                catch (Exception ex)
                {
                    //msg(ex.Message, true, "None", new Form());
                    MessageBox.Show(ex.Message, "Error ..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void StopService(string serviceName, int timeoutMilliseconds)
        {
            using (ServiceController service = new ServiceController(serviceName))
            {
                try
                {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }
                catch (Exception ex)
                {
                    //msg(ex.Message, true, "None", new Form());
                    MessageBox.Show(ex.Message, "Error ..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #endregion
    }
}
