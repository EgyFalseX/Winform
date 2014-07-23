 using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace StoreAccount
{
    class MCls
    {
        #region -   Variables   -
        public static string SQLConStrStoreAccount = "Data Source=.;Initial Catalog=G_Accounts;Integrated Security=True";
        public string AccountIdCustomer = "11";//كود العملاء في شجرةالحسابات
        public string AccountTreeIdCustomer = "1020010001";//اول كود شجره لاول عميل
        public string AccountIdSuppler = "10";//كود الموردين في شجرةالحسابات
        public string AccountTreeIdSuppler = "201001";//اول كود شجره لاول مورد
        public static UserInfoStruct UserInfo = new UserInfoStruct();
        public static readonly string DBPath = Application.StartupPath + "\\DBPath";
        public static readonly string SqlRptPath = Application.StartupPath + "\\SqlRpt";
        public static readonly string licensePath = Application.StartupPath + "\\license";
        public static string StyleSettingsPath = "StyleSettings";
        public static string ReportURL = string.Empty;
        public static string ReportPath = string.Empty;
        public static SQLReportsStr[] SQLRep;

        //Forms - Main
        //public SQLConnectionFrm FrmSQLConnection;

        //Enums
        public enum RegKeyValues
        {
            ReportUrl, ReportPath, SQLStringStoreAccount
        }
        public enum AppOptions
        {
            customer, supplier, purchasing
            // inventory, sales, UnderExchange, UnderCollection, SaleReturner, BuyReturner, CommercialCustomer
        }
        public enum HarakaType
        {
            مرتجع = 1, مبيعات = 2
        }
        public enum DiscountType
        {
            مبلغ = 1, نسبة = 2, بدون_خصم = 3
        }
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
        public static void msg(string StringMessage, bool ShowErrorNo, string StringErrorNo, Form OwnerForm)
        {
            MSGBOXFrm msgbox = new MSGBOXFrm(StringMessage, ShowErrorNo, StringErrorNo);
            msgbox.ShowDialog(OwnerForm);
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
        //Database
        public static DataTable LoadDataTable(string CommandString)
        {
            
            DataTable ReturnMe = new DataTable();
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, new SqlConnection(MCls.SQLConStrStoreAccount)))
            {
                try { DA.Fill(ReturnMe); }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            return ReturnMe;
        }
        public static DataTable LoadDataTable(string CommandString, string ErrorProviderStr)
        {
            ErrorProviderStr = string.Empty;
            DataTable ReturnMe = new DataTable("SocialStateTypes");
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, MCls.SQLConStrStoreAccount))
            {
                try { DA.Fill(ReturnMe); }
                catch (Exception ex)
                { ErrorProviderStr = ex.Message; }
            }
            return ReturnMe;
        }
        public static string GetAttachDefaultPath()
        {
            using (SqlConnection Con = new SqlConnection(MCls.SQLConStrStoreAccount))
            {
                string DataToReturn = string.Empty;
                SqlCommand Cmd = new SqlCommand("SELECT TOP (1) path_attach_emp FROM ATT_company_data", Con);
                try
                {
                    Con.Open();
                    DataToReturn = Cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (DataToReturn.Length > 0)
                {
                    if (DataToReturn[DataToReturn.Length - 1].ToString() != "\\")
                    {
                        DataToReturn += "\\";
                    }
                }
                return DataToReturn;
            }
        }
        public static string ServerTest(string ServerName, string username, string pass)
        {
            SqlConnection Con = new SqlConnection("Data Source=" + ServerName + @";Persist Security Info=True;User ID=" + username + ";Password=" + pass);
            try
            {
                Con.Open();
                Con.Close();
                return Con.ConnectionString.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        public static string ServerTest(string ServerName)
        {
            SqlConnection Con = new SqlConnection("Data Source=" + ServerName + @";Integrated Security=true");
            try
            {
                Con.Open();
                Con.Close();
                return Con.ConnectionString.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
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
            catch (Exception)
            {
            }
            return ReturnMe;
        }
        public static bool AttachDB(string DatabaseName, string DataPath, string LogPath, string ConStr)
        {
            bool ReturnMe = false;
            SqlConnection TempCon = new SqlConnection(ConStr);
            string PConStr = "Data Source=" + TempCon.DataSource + ";Integrated Security=true";
            SqlConnection Con = new SqlConnection(PConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                //                Cmd.CommandText = @"CREATE DATABASE " + DatabaseName + @"
                //                                    ON(NAME='" + DatabaseName + @"', FILENAME='" + DataPath + @"')
                //                                    LOG ON(NAME='" + DatabaseName + @"_log', FILENAME='" + LogPath + @"')
                //                                    FOR ATTACH WITH ENABLE_BROKER;";
                Cmd.CommandText = "EXEC sp_attach_db @dbname = N'" + DatabaseName + "', @filename1 = N'" + DataPath + "',@filename2 = N'" + LogPath + "'";
                if (Cmd.ExecuteNonQuery() != 0)
                    ReturnMe = true;
                else
                    ReturnMe = false;
            }
            catch (Exception ex)
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
            string PConStr = "Data Source=" + TempCon.DataSource + ";Integrated Security=true";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ReturnMe = false;
            }
            Con.Close();
            return ReturnMe;
        }
        public static string GetNewID(string TableName, string ColumnName)
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(MCls.SQLConStrStoreAccount);
            SqlCommand Cmd = new SqlCommand("SELECT ISNULL(MAX(" + ColumnName + ") + 1, 1) AS NewID FROM " + TableName + " AS NewID", Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                    dr.Read();
                    ReturnMe = dr.GetValue(0).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            Con.Close();
            return ReturnMe;
        }
        public static string GetNewID(string TableName, string ColumnName, string Condition)
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(MCls.SQLConStrStoreAccount);
            SqlCommand Cmd = new SqlCommand(String.Format("SELECT ISNULL(MAX({0}) + 1, 1) AS NewID FROM {1} Where {2}", ColumnName, TableName, Condition), Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                    dr.Read();
                ReturnMe = dr.GetValue(0).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            Con.Close();
            return ReturnMe;
        }
        public static bool DeleteRow(string TableName, string RowIDName, string RowIDValue)
        {
            bool ReturnMe = false;
            SqlConnection Con = new SqlConnection(MCls.SQLConStrStoreAccount);
            SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM {0} WHERE ({1} = {2})", TableName, RowIDName, RowIDValue), Con);
            try
            {
                Con.Open();
                if (Cmd.ExecuteNonQuery().ToString() != "0")
                {
                    ReturnMe = true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            Con.Close();
            return ReturnMe;
        }
        public static string GetOptionValue(AppOptions AppOp)
        {
            string ReturnMe = "0";
            SqlConnection con = new SqlConnection(MCls.SQLConStrStoreAccount);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format("Select opvalue From CDOptions Where opname = N'{0}'", AppOp);
                con.Open();
                ReturnMe = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException)
            { }
            con.Close();
            return ReturnMe;
        }
        public static bool SetOptionValue(AppOptions AppOp, string Value)
        {
            bool ReturnMe = false;
            SqlConnection con = new SqlConnection(MCls.SQLConStrStoreAccount);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format("Update CDOptions Set opvalue = N'{0}' Where opname = N'{1}'", Value, AppOp);
                con.Open();
                cmd.ExecuteNonQuery();
                ReturnMe = true;
            }
            catch (SqlException)
            { }
            con.Close();
            return ReturnMe;
        }
        public static void GetFormPriv(string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;
            DataTable Priv = LoadDataTable(string.Format(@"SELECT RoleDetial.Selecting, RoleDetial.Inserting, RoleDetial.Updateing, RoleDetial.Deleting FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID
            WHERE (UserRoles.UserId = {0}) AND (RoleDetial.MenuItemName = N'{1}')", MCls.UserInfo.UserID, FormName));
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
            Process.Start(new ProcessStartInfo() { FileName = "RSBuild.exe", Arguments = "DpyRpt", UseShellExecute = true, WorkingDirectory = Application.StartupPath + @"\SqlRpt\" });
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
                    string StrToSave = String.Format("{0}|{1}|{2}", SQLConStrStoreAccount, ReportURL, ReportPath);
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
        public static bool LoadSqlDBPath()
        {
            try
            {
                if (!File.Exists(DBPath))// Check If DBPass is Exists
                {
                    using (SQLConnectionFrm SqlFrm = new SQLConnectionFrm { DatabaseName = "StoreAccount" })
                    {
                        SqlFrm.ShowDialog();
                    }
                }
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                string[] ConfigArr = Bytes2String(File.ReadAllBytes(DBPath)).Split(Convert.ToChar("|"));
                SQLConStrStoreAccount = ConfigArr[0];
                ReportURL = ConfigArr[1];
                ReportPath = ConfigArr[2];
                if (CheckDBWorking(SQLConStrStoreAccount))
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
        public static System.Drawing.Icon MakeIcon(System.Drawing.Image img, int size, bool keepAspectRatio)
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
            return File.ReadAllText(MCls.licensePath);
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
            Server srvSql = new Server(new ServerConnection(new SqlConnection(MCls.SQLConStrStoreAccount)));
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

            Server srvSql = new Server(new ServerConnection(new SqlConnection(MCls.SQLConStrStoreAccount)));
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
