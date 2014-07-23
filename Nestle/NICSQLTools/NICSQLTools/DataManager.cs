using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.IO;
using log4net;

namespace NICSQLTools
{
    public class DataManager
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(DataManager));
        public static DataManager defaultInstance;
        public static int ConnectionTimeout = 0;
        public static int SHRINKSIZE = 10;
        public static Data.dsDataTableAdapters.QueriesTableAdapter adpQry = new Data.dsDataTableAdapters.QueriesTableAdapter();

        #endregion
        #region -   Properties   -
        public static string dbPath
        {
            get;
            set;
        }
        public static int UnknownCityId
        {
            get { return 999999999; }
        }
        public static string Route000001
        {
            get { return "000001"; }
        }
        public static string Route999999
        {
            get { return "999999"; }
        }
        public DateTime ServerDateTime
        {
            get { return (DateTime)adpQry.GetServerDate(); }
        }


        public static Uti.Types.UserInfo User = new Uti.Types.UserInfo();

        #region -   Unknown Codes   -
        #endregion

        
        #endregion
        #region -   Functions   -
        public static void Init()
        {
            defaultInstance = new DataManager();
        }
        public static void SetAllCommandTimeouts(object adapter, int timeout)
        {
            var commands = adapter.GetType().InvokeMember("CommandCollection",
                    System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                    null, adapter, new object[0]);
            var sqlCommand = (System.Data.SqlClient.SqlCommand[])commands;
            foreach (var cmd in sqlCommand)
            {
                cmd.CommandTimeout = timeout;
            }
        }
        public static string GenerateDatabaseScript(string DatabasePath)
        {
            return string.Empty;//string.Format(Properties.Settings.Default.CreateDatabaseScript.Replace("FalseX2013", DatabasePath));
        }
        public static void PerformChangeExe()
        {
            if (Program.updatePath == System.Windows.Forms.Application.ExecutablePath)
            {
                byte[] data = System.IO.File.ReadAllBytes(System.Windows.Forms.Application.ExecutablePath);
                System.IO.FileStream fs = System.IO.File.Create(Program.AppPath);
                fs.Write(data, 0, data.Length);
                fs.Close();
                System.Diagnostics.Process.Start(Program.AppPath);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                return;
            }
        }
        public static void PerformUpdate()
        {
            int currentVersion = Convert.ToInt32(System.Windows.Forms.Application.ProductVersion.Replace(".", ""));
            int? serverVersion = adpQry.GetAppVersion();

            if (serverVersion == null)
            {
                if (!User.IsAdmin)
                    return;
                if (System.Windows.Forms.MsgDlg.Show("لا يوجد محتوي للبرنامج علي الخادم. هل ترغب في ارسال هذه النسخه للخادم؟", System.Windows.Forms.MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                    return;
                byte[] data = File.ReadAllBytes(System.Windows.Forms.Application.ExecutablePath);
                adpQry.SetAppData(data, currentVersion);
                
            }
            else
            {
                if (serverVersion == currentVersion)
                    return;
                else if (serverVersion < currentVersion)
                {
                    if (!User.IsAdmin)
                        return;
                    if (System.Windows.Forms.MsgDlg.Show("هذه الاصداره جديده عن الموجوده علي الخادم, هل ترغب في تحديث الخادم؟", System.Windows.Forms.MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                        return;
                    byte[] data = File.ReadAllBytes(System.Windows.Forms.Application.ExecutablePath);
                    adpQry.SetAppData(data, currentVersion);
                }
                else
                {
                    if (System.Windows.Forms.MsgDlg.Show("يوجد اصداره جديده من البرنامج علي الخادم, هل ترغب في التحديث؟", System.Windows.Forms.MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                        return;
                    //if (File.Exists(updatePath))
                    //    File.Delete(updatePath);
                    byte[] data = adpQry.GetAppData();
                    FileStream fs = File.Create(Program.updatePath);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                    System.Diagnostics.Process.Start(Program.updatePath);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
        }
        public static DataTable LoadExcelFile(string strFile, string sheetName, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection con = new OleDbConnection(strConnectionString);
                string query = string.Format("SELECT {0} FROM [{1}$]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
              //MsgDlg.Show("Load Excel File Failed - " + ex.Message, NestleICSales.Utilities.Types.MessageType.Error, ex);
                System.Windows.Forms.MessageBox.Show("Load Excel File Failed - " + ex.Message);
            }
            return dt;
        }
        public static DataTable LoadExcelFile(string strFile, int sheetIndex, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection con = new OleDbConnection(strConnectionString);
                con.Open();
                DataTable dtSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                con.Close();
                if (dtSchema == null)
                    return dt;
                string sheetName = dtSchema.Rows[sheetIndex]["TABLE_NAME"].ToString();
                string query = string.Format("SELECT {0} FROM [{1}]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                //MsgDlg.Show("Load Excel File Failed - " + ex.Message, NestleICSales.Utilities.Types.MessageType.Error, ex);
                System.Windows.Forms.MessageBox.Show("Load Excel File Failed - " + ex.Message);
            }
            return dt;
        }

        #endregion
    }
}