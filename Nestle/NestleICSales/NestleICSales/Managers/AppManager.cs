using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace NestleICSales.Managers
{
    public class AppManager
    {

        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(AppManager));
        public static AppManager defaultInstance;

        private DataSources.dsData dsData;
        private DataSources.dsDataTableAdapters.ServerOptionTableAdapter adpserverOptions;
        public DataSources.dsQryTableAdapters.QueriesTableAdapter adpQry { get; set; }
        //public DataSources.dsDataCenterTableAdapters.LogsTableAdapter adpLog { get; set; }
        public string AppMenuName { get { return "bbi"; } }
        #endregion
        #region -   Properties   -
        public string DatabaseName
        {
            get
            {
                return "Nestle";
            }
        }
        public string ReportURL { get; set; }
        public string ReportPath { get; set; }
        public string SqlConStr { get; set; }
        public string SSRSUserName { get; set; }
        public string SSRSPassword { get; set; }
        public string SSRSDomain { get; set; }
        public string DBPath
        {//System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName)
            get
            { return System.Windows.Forms.Application.StartupPath + "\\dbcfg"; }
        }


        #endregion
        #region -   Functions   -
        public AppManager()
        {
            dsData = new DataSources.dsData();
            adpserverOptions = new DataSources.dsDataTableAdapters.ServerOptionTableAdapter();
            adpQry = new DataSources.dsQryTableAdapters.QueriesTableAdapter();
            //adpLog = new DataSources.dsDataCenterTableAdapters.LogsTableAdapter();
        }
        public static bool Init()
        {
            defaultInstance = new AppManager();
            Logger.Debug("Init ... Done");
            return true;
        }
        public object GetServerOption(Utilities.Types.ServerOptions OptionType)
        {
            DataSources.dsData.ServerOptionRow[] row =
                (DataSources.dsData.ServerOptionRow[])dsData.ServerOption.Select("OptionId = " + (int)OptionType);
            if (row.Length == 0)
            {
                //Option doesn't exists so create it
                DataSources.dsData.ServerOptionRow newOptions = dsData.ServerOption.NewServerOptionRow();
                newOptions.OptionId = (int)OptionType; newOptions.OptionName = OptionType.ToString();
                adpserverOptions.Update(newOptions);
                return null;
            }
            else
                return row[0].OptionValue;
        }
        public void SetServerOption(Utilities.Types.ServerOptions OptionType, object value)
        {
            DataSources.dsData.ServerOptionRow row =
                (DataSources.dsData.ServerOptionRow)dsData.ServerOption.Select("OptionId = " + (int)OptionType)[0];

            row.OptionValue = Convert.ToString(value);
        }
        public bool LoadServerOptions()
        {
            try
            {
                adpserverOptions.Fill(dsData.ServerOption);
                string FilesPath = (string)AppManager.defaultInstance.GetServerOption(Utilities.Types.ServerOptions.FilesPath);
                if (!System.IO.Directory.Exists(FilesPath))
                    System.IO.Directory.CreateDirectory(FilesPath);
                string DeletedFilesPath = (string)AppManager.defaultInstance.GetServerOption(Utilities.Types.ServerOptions.DeletedFilesPath);
                if (!System.IO.Directory.Exists(DeletedFilesPath))
                    System.IO.Directory.CreateDirectory(DeletedFilesPath);
                Logger.Debug("Load Server Options ... Done");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Load Server Options ... Error - " + ex.Message, ex);
                return false;
            }
        }
        public bool SaveServerOptions()
        {
            try
            {
                adpserverOptions.Update(dsData.ServerOption);
                Logger.Debug("Save Server Options ... Done");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Save Server Options ... Error - " + ex.Message, ex);
                return false;
            }
        }
        public bool CheckReqOptions()
        {
            if (GetServerOption(Utilities.Types.ServerOptions.FilesPath).ToString() == string.Empty ||
                GetServerOption(Utilities.Types.ServerOptions.DefaultUserPassword).ToString() == string.Empty ||
                GetServerOption(Utilities.Types.ServerOptions.DeletedFilesPath).ToString() == string.Empty ||
                GetServerOption(Utilities.Types.ServerOptions.ServerIP).ToString() == string.Empty ||
                GetServerOption(Utilities.Types.ServerOptions.ServerPort).ToString() == string.Empty)
            {
                Logger.Debug("Check Req Options = False");
                return false;
            }
            else
            {
                Logger.Debug("Check Req Options = True");
                return true;
            }
            

        }

        public DateTime ServerDateTime()
        {
            try
            {
                return (DateTime)adpQry.ScalarQuerySERVERDATETIME();
            }
            catch (Exception ex)
            {
                Utilities.Uti.LogMessage(ex.Message);
                return DateTime.Now;
            }
        }

        public bool SaveSQLDBPath()
        {
            try
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                // Create an instance of StreamReader to read from a file.
                using (BinaryWriter writer = new BinaryWriter(File.Open(DBPath, FileMode.Create)))
                {
                    string StrToSave = String.Format("{0}|{1}|{2}|{3}|{4}|{5}", SqlConStr, ReportURL, ReportPath, SSRSUserName, SSRSPassword, SSRSDomain);
                    writer.Write(Strin2Bytes(StrToSave));
                    writer.Flush();
                    writer.Close();
                }
                Logger.Debug("Save SQL DBPath ... Done");
                return true;
            }
            catch(Exception ex)
            {
                Logger.Error("Save SQL DBPath ... Error - " + ex.Message, ex);
                return false;
            }
        }
        public bool LoadSqlDBPath(string DatabaseName)
        {
            try
            {
                if (!File.Exists(DBPath))// Check If DBPass is Exists
                {
                    Forms.SQLConnectionFrm SqlFrm = new Forms.SQLConnectionFrm { DatabaseName = DatabaseName };
                    if (SqlFrm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        return false;
                }
                // Create an instance of StreamReader to read from a file.
                string[] ConfigArr = Bytes2String(File.ReadAllBytes(DBPath)).Split(Convert.ToChar("|"));
                SqlConStr = ConfigArr[0];
                ReportURL = ConfigArr[1];
                ReportPath = ConfigArr[2];
                SSRSUserName = ConfigArr[3];
                SSRSPassword = ConfigArr[4];
                SSRSDomain = ConfigArr[5];
                if (Forms.SQLConnectionFrm.CheckDBWorking(SqlConStr))
                {
                    Logger.Debug("Load Sql DBPath ... Done");
                    return true;
                }
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
                        if (System.Windows.Forms.MessageBox.Show(msg, "خطاء في الاتصال بقاعدة البيانات", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                        {
                            Logger.Error("Load Sql DBPath ... Error");
                            return false;
                        }
                        File.Delete(DBPath);
                    }
                    //Application.Restart();
                    Logger.Error("Load Sql DBPath ... Error");
                    return false;
                }
            }
            catch(Exception ex)
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                Logger.Error("Load Sql DBPath ... Error - " + ex.Message, ex);

                return false;
            }
        }
        private byte[] Strin2Bytes(string Text)
        {
            string hex = string.Empty;
            foreach (char c in Text)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)Convert.ToUInt32(tmp.ToString()));
            }

            return Encoding.Default.GetBytes(hex);
        }
        private string Bytes2String(byte[] Bytez)
        {
            string ConvThis = System.Text.Encoding.ASCII.GetString(Bytez);
            byte[] raw = new byte[ConvThis.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(ConvThis.Substring(i * 2, 2), 16);
            }
            return System.Text.Encoding.ASCII.GetString(raw);
        }

        public void LogOperation(Utilities.Types.LogType logType, int index, Utilities.Types.LogOpType logOpTyp, int? ExtraIndex = null)
        {
            //adpLog.Insert((int)logType, index, (int)logOpTyp, ServerDateTime(), UserManager.defaultInstance.UserInfo.UserID, ExtraIndex);
            Logger.Debug("Log Operation ... Done");
        }
        
        #endregion

    }
}

