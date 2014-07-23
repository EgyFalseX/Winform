using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DataCenter.Managers;

namespace DataCenter
{
    public class DataCenterX
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DataCenterX));
        public static nsLib.nsLib NSManager { get; set; }
        public static DataCenter.Forms.DebugLogsFrm DebugLog { get; set; }

        public DataCenterX()
        {
        }

        public static bool StartApp()
        {
            DebugLog = new Forms.DebugLogsFrm();
            #if DEBUG
            DebugLog.Show();
            #endif

            Program.DC = new DataCenterX();
            if (AppManager.Init())
            {
                if (!AppManager.defaultInstance.LoadSqlDBPath(AppManager.defaultInstance.DatabaseName))
                    return false;
                else
                {
                    Properties.Settings.Default["DataCenterConnectionString"] = AppManager.defaultInstance.SqlConStr;
                    Properties.Settings.Default.Save();
                    //DevExpress.Xpo.XpoDefault.Session.ConnectionString = AppManager.defaultInstance.SqlConStr;
                    //DevExpress.Xpo.XpoDefault.Session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
                
                }

            }
            else
                return false;

            if (!DataManager.Init())
                return false;
            AppManager.defaultInstance.LoadServerOptions();

            if (!UserManager.Init())
                return false;

            if (!Program.DC.Login())
                return false;

            if (!AppManager.defaultInstance.CheckReqOptions())
            {
                Forms.ServerOptionWizardFrm frm = new Forms.ServerOptionWizardFrm();
                frm.ShowDialog();
                if (!AppManager.defaultInstance.CheckReqOptions())
                    return false;
            }

            NSManager = new nsLib.nsLib(Convert.ToInt32(AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.ServerPort)), 
                AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.ServerIP).ToString());
            if (!NSManager.ConnectMe())
                return false;

            return true;
        }

        public bool Login()
        {
            Forms.LoginFrm login = new Forms.LoginFrm();
            if (login.ShowDialog() == DialogResult.OK)
                UserManager.defaultInstance.LoadUserRole();

            return UserManager.defaultInstance.loggedIn;
        }

        public static void StopApp()
        {
            Application.Exit();
        }

        public static void LogMessage(string msg, Type typ, nsLib.Utilities.Types.MessageType msgTyp, Exception ex = null, bool ShowMsg = false)
        {
            log4net.ILog Logger = log4net.LogManager.GetLogger(typ);
            switch (msgTyp)
            {
                case nsLib.Utilities.Types.MessageType.Success:
                    Logger.Info(msg, ex);
                    break;
                case nsLib.Utilities.Types.MessageType.Error:
                    Logger.Error(msg, ex);
                    break;
                case nsLib.Utilities.Types.MessageType.Info:
                    Logger.Info(msg, ex);
                    break;
                case nsLib.Utilities.Types.MessageType.Debug:
                    Logger.Debug(msg, ex);
                    break;
                case nsLib.Utilities.Types.MessageType.Fatal:
                    Logger.Fatal(msg, ex);
                    break;
                case nsLib.Utilities.Types.MessageType.Warn:
                    Logger.Warn(msg, ex);
                    break;
                default:
                    break;
            }
            if (ShowMsg)
                new Forms.MSGDLG(msg, msgTyp, ex).ShowDialog();

        }
    }
}
