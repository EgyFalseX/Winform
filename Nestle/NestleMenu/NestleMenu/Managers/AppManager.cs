using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace NestleMenu.Managers
{
    public class AppManager
    {

        #region -   Variables   -

        public static AppManager defaultInstance;

        private DataSources.dsNU dsData;
        private DataSources.dsNUTableAdapters.ServerOptionTableAdapter adpserverOptions;
        public DataSources.dsNUTableAdapters.QueriesTableAdapter adpQry { get; set; }
        //public DataSources.dsDataCenterTableAdapters.LogsTableAdapter adpLog { get; set; }
        public string AppMenuName { get { return "bbi"; } }
        #endregion
        #region -   Properties   -
        public string DatabaseName
        {
            get
            {
                return "NestleMenu";
            }
        }
        public string SqlConStr { get; set; }
        public string DBPath
        {//System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName)
            get
            { return System.Windows.Forms.Application.StartupPath + "\\dbcfg"; }
        }


        #endregion
        #region -   Functions   -
        public AppManager()
        {
            dsData = new DataSources.dsNU();
            adpserverOptions = new DataSources.dsNUTableAdapters.ServerOptionTableAdapter();
            adpQry = new DataSources.dsNUTableAdapters.QueriesTableAdapter();
            //adpLog = new DataSources.dsDataCenterTableAdapters.LogsTableAdapter();
        }
        public static bool Init()
        {
            defaultInstance = new AppManager();

            NU.LogMessage("Init ... Done", AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
            return true;
        }
        public object GetServerOption(Utilities.Types.ServerOptions OptionType)
        {
            DataSources.dsNU.ServerOptionRow[] row =
                (DataSources.dsNU.ServerOptionRow[])dsData.ServerOption.Select("OptionId = " + (int)OptionType);
            if (row.Length == 0)
            {
                //Option doesn't exists so create it
                DataSources.dsNU.ServerOptionRow newOptions = dsData.ServerOption.NewServerOptionRow();
                newOptions.ServerOptionId = (int)OptionType; newOptions.ServerOption = OptionType.ToString();
                adpserverOptions.Update(newOptions);
                return null;
            }
            else
                return row[0].ServerValue;
        }
        public void SetServerOption(Utilities.Types.ServerOptions OptionType, object value)
        {
            DataSources.dsNU.ServerOptionRow row =
                (DataSources.dsNU.ServerOptionRow)dsData.ServerOption.Select("OptionId = " + (int)OptionType)[0];

            row.ServerValue = Convert.ToString(value);
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

                NU.LogMessage("Load Server Options ... Done", AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            catch (Exception ex)
            {
                NU.LogMessage("Load Server Options ... Error", AppManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.None, ex);
                return false;
            }
        }
        public bool SaveServerOptions()
        {
            try
            {
                adpserverOptions.Update(dsData.ServerOption);
                NU.LogMessage("Save Server Options ... Done", AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            catch (Exception ex)
            {
                NU.LogMessage("Save Server Options ... Error", AppManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
                return false;
            }
        }
        public bool CheckReqOptions()
        {
            return true;
            //if (GetServerOption(Utilities.Types.ServerOptions.FilesPath).ToString() == string.Empty ||
            //    GetServerOption(Utilities.Types.ServerOptions.DefaultUserPassword).ToString() == string.Empty ||
            //    GetServerOption(Utilities.Types.ServerOptions.DeletedFilesPath).ToString() == string.Empty ||
            //    GetServerOption(Utilities.Types.ServerOptions.ServerIP).ToString() == string.Empty ||
            //    GetServerOption(Utilities.Types.ServerOptions.ServerPort).ToString() == string.Empty)
            //{
            //    NU.LogMessage("Check Req Options = False", typeof(AppManager), Utilities.Types.MessageType.Debug);
            //    return false;
            //}
            //else
            //{
            //    NU.LogMessage("Check Req Options = True", typeof(AppManager), Utilities.Types.MessageType.Debug);
            //    return true;
            //}
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
                    string StrToSave = String.Format("{0}", SqlConStr);
                    writer.Write(Strin2Bytes(StrToSave));
                    writer.Flush();
                    writer.Close();
                }
                NU.LogMessage("Save Config ... Done", AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            catch(Exception ex)
            {
                NU.LogMessage("Save Config ... Error", AppManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
                return false;
            }
        }
        public bool LoadSqlDBPath(string DatabaseName)
        {
            return true;
            //try
            //{
            //    if (!File.Exists(DBPath))// Check If DBPass is Exists
            //    {
            //        Forms.SQLConnectionFrm SqlFrm = new Forms.SQLConnectionFrm { DatabaseName = DatabaseName };
            //        if (SqlFrm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            //            return false;
            //    }
            //    // Create an instance of StreamReader to read from a file.
            //    string[] ConfigArr = Bytes2String(File.ReadAllBytes(DBPath)).Split(Convert.ToChar("|"));
            //    SqlConStr = ConfigArr[0];
            //    if (Forms.SQLConnectionFrm.CheckDBWorking(SqlConStr))
            //    {
            //        NU.LogMessage("Load Sql DBPath ... Done", typeof(AppManager), Utilities.Types.MessageType.Debug);
            //        return true;
            //    }
            //    else
            //    {
            //        if (File.Exists(DBPath))
            //        {
            //            string msg = "لم نتمكن من الاتصال يرجع ذلك لاكثر من سبب" + "\n" +
            //                         "من الممكن ان يكون الخادم او الخدمه مغلقه" + "\n" + "او" + "\n" +
            //                         "اختيارات الاتصال خاطئه " + "\n" +
            //                         "هل ترغب في اعادة كتابتها؟" + "\n" +
            //                         "'Yes' = سيتم الغاء الاتصال و اعادة كتابتها" + "\n" +
            //                         "'No' = سيتم اغلاق البرنامج بدون حذف خيارات الاتصال";
            //            if (System.Windows.Forms.MessageBox.Show(msg, "خطاء في الاتصال بقاعدة البيانات", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
            //            {
            //                NU.LogMessage("Load Sql DBPath ... Error", typeof(AppManager), Utilities.Types.MessageType.Error);
            //                return false;
            //            }
            //            File.Delete(DBPath);
            //        }
            //        //Application.Restart();
            //        NU.LogMessage("Load Sql DBPath ... Error", typeof(AppManager), Utilities.Types.MessageType.Error);
            //        return false;
            //    }
            //}
            //catch(Exception ex)
            //{
            //    if (File.Exists(DBPath))
            //        File.Delete(DBPath);
            //    NU.LogMessage("Load Sql DBPath ... Error", typeof(AppManager), Utilities.Types.MessageType.Error, ex);
            //    return false;
            //}
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
            NU.LogMessage("Log Operation ... Done", AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
        }
        
        #endregion

    }
}

