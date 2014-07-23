using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using log4net;
using System.Windows.Forms;

namespace GM.Managers
{
    public class AppManager
    {
        #region -   Variables   -

        public static AppManager defaultInstance;
        //private DataSources.dsGM dsData;
        //private DataSources.dsNUTableAdapters.ServerOptionTableAdapter adpserverOptions;
        //public DataSources.dsQryTableAdapters.QueriesTableAdapter adpQry { get; set; }
        //public DataSources.dsDataCenterTableAdapters.LogsTableAdapter adpLog { get; set; }
        const string Provider = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=kadry1982;Data Source=";
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
            //adpQry = new DataSources.dsQryTableAdapters.QueriesTableAdapter();
            //dsData = new DataSources.dsNU();
            //adpserverOptions = new DataSources.dsNUTableAdapters.ServerOptionTableAdapter();
            //adpLog = new DataSources.dsDataCenterTableAdapters.LogsTableAdapter();
        }
        public static bool Init()
        {
            bool ReturnMe = false;
            defaultInstance = new AppManager();
            ReturnMe = defaultInstance.LoadDBPath();
            if (ReturnMe)
                Glob.LogMessage("Init ... OK", AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
            return ReturnMe;
        }
        public bool LoadDBPath()
        {
            if (DBConnectionCheck(Properties.Settings.Default.dbPath))
            {
                Properties.Settings.Default["GmKadryConnectionString"] = Properties.Settings.Default.dbPath;
                return true; 
            }
                
            OpenFileDialog ofd = new OpenFileDialog() { Title = "Select Access Database File", Filter = "access database(*.mdb)|*.mdb|All Files(*.*)|*.*" };
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return false;
            if (DBConnectionCheck(Provider + ofd.FileName))
            {
                Properties.Settings.Default.dbPath = Provider + ofd.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default["GmKadryConnectionString"] = Properties.Settings.Default.dbPath;
                Glob.LogMessage("Save Config ... OK", AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            else
                return false;
        }
        public bool DBConnectionCheck(string dbPath)
        {
            bool ReturnMe = false;
            //string connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;
            try
            {
                OleDbConnection con = new OleDbConnection(dbPath);
                con.Open();
                con.Close();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                Glob.LogMessage(ex.Message, AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
            }
            return ReturnMe;
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
            Glob.LogMessage("Log Operation ... OK", AppManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
        }
        
        #endregion

    }
}

