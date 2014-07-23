using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Diagnostics;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.ServiceProcess;
//using CrystalDecisions.CrystalReports.Engine;

namespace FXFW
{
    public class SqlDB
    {
        #region -   Variables   -

        public static string SqlConStr = string.Empty;
        public static UserInfoStruct UserInfo = new UserInfoStruct();
        public static readonly string DBPath = Application.StartupPath + "\\DBPath";
        public static readonly string SqlRptPath = Application.StartupPath + "\\SqlRpt";
        public static readonly string licensePath = Application.StartupPath + "\\license";
        public static string StyleSettingsPath = "StyleSettings";
        public static string duckSettingsPath = "duckSettings";
        //public static readonly string ReportsPath = Application.StartupPath + "\\Reports";
        public static string ReportURL = string.Empty;
        public static string ReportPath = string.Empty;
        public static string SSRSUserName = string.Empty;
        public static string SSRSPassword = string.Empty;
        public static string SSRSDomain = string.Empty;
        //public static ReportType RepTy = ReportType.None;
        public static string ActionLog = string.Empty;
        public static SQLReportsStr[] SQLRep;
        public static string asase_code = string.Empty;
        //struct
        public struct UserInfoStruct
        {
            public string UserID;
            public string UserName;
        }
        public struct SQLReportsStr
        {
            public string RepFileName;
            public string RepCaption;
            public string RepPosition;
        }
        #endregion
        #region -   Functions   -
        public static void LoadSQLReports()
        {
            if (!File.Exists(SqlRptPath + "\\SQLReports.txt"))// Check If DBPass is Exists
                return;
            using (StreamReader sr = new StreamReader(SqlRptPath + "\\SQLReports.txt", Encoding.Default))// Read Connection String
            {
                SQLRep = new SQLReportsStr[0];
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] Parts = line.Split(Convert.ToChar(";"));
                    if (Parts.Length > 2)
                    {
                        Array.Resize<SQLReportsStr>(ref SQLRep, SQLRep.Length + 1);
                        SQLRep[SQLRep.Length - 1].RepPosition = Parts[0];
                        SQLRep[SQLRep.Length - 1].RepFileName = Parts[1];
                        SQLRep[SQLRep.Length - 1].RepCaption = Parts[2];
                    }
                }
            }
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
        public static string ConvertToDateDMYHMS(string PDate)
        {

            string ReturnMe = string.Empty;
            DateTime MyDate = Convert.ToDateTime(PDate);
            ReturnMe = String.Format("{0}-{1}-{2} {3}:{4}:{5}", MyDate.Year, MyDate.Month, MyDate.Day, MyDate.Hour, MyDate.Minute, MyDate.Second);
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
        public static bool IsNullOrEmpty(object obj)
        {
            if (obj == null)
                return true;

            if (obj.ToString() == string.Empty)
                return true;
            else
                return false;
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
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, SqlDB.SqlConStr))
            {
                try { DA.Fill(ReturnMe); }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return ReturnMe;
        }
        public static DataTable LoadDataTable(SqlCommand cmd)
        {
            DataTable ReturnMe = new DataTable("False2011-07");
            using (SqlDataAdapter DA = new SqlDataAdapter("", SqlDB.SqlConStr))
            {
                cmd.Connection = DA.SelectCommand.Connection;
                DA.SelectCommand = cmd;
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
            using (SqlConnection con = new SqlConnection(SqlDB.SqlConStr))
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
        public static void GetFormPriv(string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;
            DataTable Priv = SqlDB.LoadDataTable(string.Format(@"SELECT RoleDetial.Selecting, RoleDetial.Inserting, RoleDetial.Updateing, RoleDetial.Deleting FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID
            WHERE (UserRoles.UserId = {0}) AND (RoleDetial.MenuItemName = N'{1}')", UserInfo.UserID, FormName));
            foreach (DataRow row in Priv.Rows)
            {
                if (row["Selecting"].ToString() == "True")
                    Selecting = true;
                if (row["Inserting"].ToString() == "True")
                    Inserting = true;
                if (row["Updateing"].ToString() == "True")
                    Updateing = true;
                if (row["Deleting"].ToString() == "True")
                    Deleting = true;
            }
        }
        public static void DeploySSRSReports(Settings rptInfos)
        {
            if (! Directory.Exists(Application.StartupPath + @"\SqlRpt\"))
            {
                MessageBox.Show("System Folder Not Found", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SerializeThis.Serialize(rptInfos, Application.StartupPath + @"\SqlRpt\DpyRpt");
            Process.Start(new ProcessStartInfo() {  FileName = "RSBuild.exe", Arguments = "DpyRpt", UseShellExecute = true, WorkingDirectory = Application.StartupPath + @"\SqlRpt\" }).WaitForExit();
        }
        public static bool SaveSQLDBPath()
        {
            try
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (BinaryWriter writer = new BinaryWriter(File.Open(DBPath, FileMode.Create)))
                {
                    string StrToSave = String.Format("{0}|{1}|{2}|{3}|{4}|{5}", SqlConStr, ReportURL, ReportPath, SSRSUserName, SSRSPassword, SSRSDomain);
                    writer.Write(Strin2Bytes(StrToSave));
                    writer.Flush();
                    writer.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool LoadSqlDBPath(string DatabaseName)
        {
            try
            {
                if (!File.Exists(DBPath))// Check If DBPass is Exists
                {
                    using (SQLConnectionFrm SqlFrm = new SQLConnectionFrm { DatabaseName = DatabaseName })
                    {
                        SqlFrm.ShowDialog();
                    }
                }
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                string[] ConfigArr = Bytes2String(File.ReadAllBytes(DBPath)).Split(Convert.ToChar("|"));
                SqlConStr = ConfigArr[0];
                ReportURL = ConfigArr[1];
                ReportPath = ConfigArr[2];
                SSRSUserName = ConfigArr[3];
                SSRSPassword = ConfigArr[4];
                SSRSDomain = ConfigArr[5];
                if (CheckDBWorking(SqlConStr))
                    return true;
                else
                {
                    if (File.Exists(DBPath))
                    {
                        string msg = "لم نتمكن من الاتصال يرجع ذلك لاكثر من سبب" + "\n" +
                                     "من الممكن ان يكون الخادم او الخدمه مغلقه" + "\n" + "او" + "\n" +
                                     "اختيارات الاتصال خاطئه " + "\n" +
                                     "هل ترغب في اعادة كتابتها؟" + "\n" +
                                     "'Yes' = سيتم الغاء الاتصال و اعادة كتابتها" + "\n" +
                                     "'No' = سيتم اغلاق البرنامج بدون حذف خيارات الاتصال";
                        if (MessageBox.Show(msg,"خطاء في الاتصال بقاعدة البيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        {
                            Application.Exit();
                            return false;
                        }
                        File.Delete(DBPath);
                    }
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
        /// <summary>
        /// Converts an image into an icon.
        /// </summary>
        /// <param name="img">The image that shall become an icon</param>
        /// <param name="size">The width and height of the icon. Standard
        /// sizes are 16x16, 32x32, 48x48, 64x64.</param>
        /// <param name="keepAspectRatio">Whether the image should be squashed into a
        /// square or whether whitespace should be put around it.</param>
        /// <returns>An icon!!</returns>
        public  static System.Drawing.Icon MakeIcon(System.Drawing.Image img, int size, bool keepAspectRatio)
        {
            System.Drawing.Bitmap square = new System.Drawing.Bitmap(size, size); // create new bitmap
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(square); // allow drawing to it

            int x, y, w, h; // dimensions for new image

            if (!keepAspectRatio || img.Height == img.Width)
            {
                // just fill the square
                x = y = 0; // set x and y to 0
                w = h = size; // set width and height to size
            }
            else
            {
                // work out the aspect ratio
                float r = (float)img.Width / (float)img.Height;

                // set dimensions accordingly to fit inside size^2 square
                if (r > 1)
                { // w is bigger, so divide h by r
                    w = size;
                    h = (int)((float)size / r);
                    x = 0; y = (size - h) / 2; // center the image
                }
                else
                { // h is bigger, so multiply w by r
                    w = (int)((float)size * r);
                    h = size;
                    y = 0; x = (size - w) / 2; // center the image
                }
            }

            // make the image shrink nicely by using HighQualityBicubic mode
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, x, y, w, h); // draw image with specified dimensions
            g.Flush(); // make sure all drawing operations complete before we get the icon

            // following line would work directly on any image, but then
            // it wouldn't look as nice.
            return System.Drawing.Icon.FromHandle(square.GetHicon());
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
            return File.ReadAllText(SqlDB.licensePath);
        }
        public static bool ChangeBasicSSRSAuthType()
        {
            using (Microsoft.Win32.RegistryKey sqlServerKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server"))
            {
                foreach (string subKeyName in sqlServerKey.GetSubKeyNames())
                {
                    if (subKeyName.StartsWith("MSRS"))
                    {
                        using (Microsoft.Win32.RegistryKey instanceKey = sqlServerKey.OpenSubKey(subKeyName + @"\Setup"))
                        {
                            string rsreportserver = instanceKey.GetValue("SQLPath").ToString() + @"ReportServer\rsreportserver.config";
                            if (!System.IO.File.Exists(rsreportserver))
                                return false;
                            string Data = File.ReadAllText(rsreportserver);
                            if (Data.Contains("<RSWindowsNegotiate/>"))
                                return true;

                            string DataStart = Data.Substring(0, Data.IndexOf("<AuthenticationTypes>"));
                            string DataEnd = Data.Substring(Data.IndexOf("</AuthenticationTypes>"));
                            string DataMid = @" <AuthenticationTypes>
                            <RSWindowsNegotiate/>
                            <RSWindowsNTLM/> 
                            ";
                            //<RSWindowsNegotiate/>
                            //<RSWindowsNTLM/> 
                            File.WriteAllText(rsreportserver, DataStart + DataMid + DataEnd);
                            return true;
                        }
                    }
                }
            }

            return false;

        }
        public static bool ChangePublicSSRSAuthType()
        {
            using (Microsoft.Win32.RegistryKey sqlServerKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server"))
            {
                foreach (string subKeyName in sqlServerKey.GetSubKeyNames())
                {
                    if (subKeyName.StartsWith("MSRS"))
                    {
                        using (Microsoft.Win32.RegistryKey instanceKey = sqlServerKey.OpenSubKey(subKeyName + @"\Setup"))
                        {
                            string rsreportserver = instanceKey.GetValue("SQLPath").ToString() + @"ReportServer\rsreportserver.config";
                            if (!System.IO.File.Exists(rsreportserver))
                                return false;
                            string Data = File.ReadAllText(rsreportserver);
                            if (Data.Contains("<LogonMethod>3</LogonMethod>"))
                                return true;
                           
                            string DataStart = Data.Substring(0, Data.IndexOf("<AuthenticationTypes>"));
                            string DataEnd = Data.Substring(Data.IndexOf("</AuthenticationTypes>"));
                            string DataMid = @" <AuthenticationTypes>
                            <RSWindowsBasic>
                            <LogonMethod>3</LogonMethod>
                            <Realm></Realm>
                            <DefaultDomain></DefaultDomain>
                            </RSWindowsBasic> 
                            ";
                            //<RSWindowsNegotiate/>
			                //<RSWindowsNTLM/> 
                            File.WriteAllText(rsreportserver, DataStart + DataMid + DataEnd);
                            return true;
                        }
                    }
                }
            }


            return false;
 
        }
        #region -   Database Backup   -
        public static void BackupDatabase(String databaseName, String destinationFilePath)
        {
            LoadDataTable(String.Format(@"DECLARE @spid INT, @cnt INT, @sql VARCHAR(255) 
            SELECT @spid = MIN(spid), @cnt = COUNT(*) FROM master..sysprocesses WHERE dbid = DB_ID('{0}') AND spid != @@SPID
                WHILE @spid IS NOT NULL
                BEGIN
                    SET @sql = 'KILL '+RTRIM(@spid)
                    EXEC(@sql)  
                    SELECT @spid = MIN(spid), @cnt = COUNT(*) FROM master..sysprocesses WHERE dbid = DB_ID('{0}') AND spid != @@SPID  
                END ", databaseName));// Close DB Con
            Server srvSql = new Server(new ServerConnection(new SqlConnection(SqlConStr)));
            // Create a new backup operation
            Backup bkpDatabase = new Backup() { Action = BackupActionType.Database, Database = databaseName };
            // Set the backup device to a file
            BackupDeviceItem bkpDevice = new BackupDeviceItem(destinationFilePath, DeviceType.File);
            bkpDatabase.LogTruncation = BackupTruncateLogType.Truncate;
            // Add the backup device to the backup
            bkpDatabase.Devices.Add(bkpDevice);
            // Perform the backup
            bkpDatabase.SqlBackup(srvSql);

        }
        public static void RestoreDatabase(String databaseName, String filePath)
        {
            LoadDataTable(String.Format(@"DECLARE @spid INT, @cnt INT, @sql VARCHAR(255) 
            SELECT @spid = MIN(spid), @cnt = COUNT(*) FROM master..sysprocesses WHERE dbid = DB_ID('{0}') AND spid != @@SPID
                WHILE @spid IS NOT NULL
                BEGIN
                    SET @sql = 'KILL '+RTRIM(@spid)
                    EXEC(@sql)  
                    SELECT @spid = MIN(spid), @cnt = COUNT(*) FROM master..sysprocesses WHERE dbid = DB_ID('{0}') AND spid != @@SPID  
                END ", databaseName));// Close DB Con

            Server srvSql = new Server(new ServerConnection(new SqlConnection(SqlConStr)));
            // Create a new database restore operation
            Restore rstDatabase = new Restore() { Action = RestoreActionType.Database, Database = databaseName, ReplaceDatabase = true };
            // Set the backup device from which we want to restore, to a file
            BackupDeviceItem bkpDevice = new BackupDeviceItem(filePath, DeviceType.File);
            // Add the backup device to the restore type
            rstDatabase.Devices.Add(bkpDevice);
            // Perform the restore
            Database db = srvSql.Databases[databaseName];
            db.SetOffline();
            rstDatabase.SqlRestore(srvSql);
            db.SetOnline();
            srvSql.Refresh();
        }
        #endregion
        #endregion

    }
}
