using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace ATCommands
{
    public class MyCL
    {
        #region -   Variables   -

        public static string SqlConStr = string.Empty;
        public static UserInfoStruct UserInfo = new UserInfoStruct();
        public static readonly string DBPath = Application.StartupPath + "\\DBPath";
        public static readonly string licensePath = Application.StartupPath + "\\license";
        public static string StyleSettingsPath = "StyleSettings";
        public static string SchoolDBPath = string.Empty;
        public static string DatanetDBPath = string.Empty;
        public static string acc_smsDBPath = string.Empty;
        public static string malafatSmsDBPath = string.Empty;
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
        #endregion
        #region -   Functions   -
        public static void ShowMsg(string Msg, bool IsError, Form ThisForm, bool popup)
        {
            MainFrm ParentFrm = (MainFrm)ThisForm;
            ParentFrm.LblMsg.Text = Msg;
            if (IsError)
                ParentFrm.LblMsg.Appearance.ForeColor = System.Drawing.Color.Red;
            else
                ParentFrm.LblMsg.Appearance.ForeColor = System.Drawing.Color.Green;
            DataRow row = ParentFrm.ActionLogTbl.NewRow();
            row["details"] = String.Format("[{0}] [{1}] : ({2}){3}", DateTime.Now.ToShortTimeString(), ThisForm.Text, Msg, Environment.NewLine);
            Console.WriteLine(row["details"]);
            ParentFrm.ActionLogTbl.Rows.Add(row);
            msgbox.Show(Msg, IsError, ThisForm, popup);
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
        public static Single ConvertStringToInt(string str, string Comma)
        {
            string ReturnMe = string.Empty;
            int count = 0;
            foreach (char c in str.ToCharArray())
            {
                if (c == Convert.ToChar(Comma) && count < 1)
                {
                    ReturnMe += ".";
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
        public static DataTable LoadDataTable(string CommandString, string AccessDBPath)
        {
            AccessDBPath = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + AccessDBPath + "\"";
            DataTable ReturnMe = new DataTable("False2011-07");
            using (OleDbDataAdapter DA = new OleDbDataAdapter(CommandString, AccessDBPath))
            {
                try { DA.Fill(ReturnMe); }
                catch (OleDbException ex)
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
            DataTable TblUser = LoadDataTable(String.Format(@"SELECT UserID, UserName, PassWord FROM Users
                                                              WHERE (UserName = N'{0}') AND (PassWord = N'{1}')", username, password));
            foreach (DataRow row in TblUser.Rows)
            {
                UserInfo = new UserInfoStruct { UserID = row["UserID"].ToString(), UserName = row["UserName"].ToString() };
                return true;
            }
            return false;
        }
        public static bool SaveSQLDBPath()
        {
            try
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                if (CheckDBWorking(SqlConStr) == false)// Check if Connection is Working ...
                    return false;
                using (BinaryWriter writer = new BinaryWriter(File.Open(DBPath, FileMode.Create)))
                {
                    writer.Write(Strin2Bytes(SqlConStr));
                    writer.Close();
                    return true;
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
                    using (SQLConnectionFrm SqlFrm = new SQLConnectionFrm { DatabaseName = "SMS" })
                    {
                        SqlFrm.ShowDialog();
                    }
                }
                SqlConStr = Bytes2String(File.ReadAllBytes(DBPath));

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
        public static byte[] Strin2Bytes(string Text)
        {
            string hex = string.Empty;
            foreach (char c in Text)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)Convert.ToUInt32(tmp.ToString()));
            }

            return Encoding.Default.GetBytes(hex);
            //return Encoding.Default.GetBytes(Text);
        }
        public static string Bytes2String(byte[] Bytez)
        {
            string ConvThis = System.Text.Encoding.ASCII.GetString(Bytez);
            byte[] raw = new byte[ConvThis.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(ConvThis.Substring(i * 2, 2), 16);
            }
            return System.Text.Encoding.ASCII.GetString(raw);
        }
        public static string ReadFromLicenseFile()
        {
            return File.ReadAllText(MyCL.licensePath);
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
            //using (ServiceController service = new ServiceController(serviceName))
            //{
            //    try
            //    {
            //        TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
            //        service.Start();
            //        service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            //    }
            //    catch (Exception ex)
            //    {
            //        //msg(ex.Message, true, "None", new Form());
            //        MessageBox.Show(ex.Message, "Error ..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
        public static void StopService(string serviceName, int timeoutMilliseconds)
        {
            //using (ServiceController service = new ServiceController(serviceName))
            //{
            //    try
            //    {
            //        TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
            //        service.Stop();
            //        service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            //    }
            //    catch (Exception ex)
            //    {
            //        //msg(ex.Message, true, "None", new Form());
            //        MessageBox.Show(ex.Message, "Error ..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
        #endregion
        #endregion
    }
}
