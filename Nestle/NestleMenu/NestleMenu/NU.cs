using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using NestleMenu.Managers;

namespace NestleMenu
{
    public class NU
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(NU));
        //public static nsLib.nsLib NSManager { get; set; }
        public static NestleMenu.Forms.DebugLogsFrm DebugLog { get; set; }

        public NU()
        {
        }

        public static bool StartApp()
        {
            DebugLog = new Forms.DebugLogsFrm();
            #if DEBUG
            DebugLog.Show();
            #endif

            Program.DC = new NU();
            if (AppManager.Init())
            {}
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
                if (!AppManager.defaultInstance.CheckReqOptions())
                    return false;
            }
            return true;
        }

        public bool Login()
        {
            Forms.LoginFrm login = new Forms.LoginFrm();
            if (login.ShowDialog() != DialogResult.OK)
                return false;

            return UserManager.defaultInstance.loggedIn;
        }

        public static void StopApp()
        {
            Application.Exit();
        }

        public static void LogMessage(string msg, object CallObject, Utilities.Types.MessageType msgTyp, Utilities.Types.MessagePopupType msgPopup, Exception ex = null)
        {
            log4net.ILog Logger = log4net.LogManager.GetLogger(CallObject.GetType());
            switch (msgTyp)
            {
                case Utilities.Types.MessageType.Success:
                    Logger.Info(msg, ex);
                    break;
                case Utilities.Types.MessageType.Error:
                    Logger.Error(msg, ex);
                    break;
                case Utilities.Types.MessageType.Info:
                    Logger.Info(msg, ex);
                    break;
                case Utilities.Types.MessageType.Debug:
                    Logger.Debug(msg, ex);
                    break;
                case Utilities.Types.MessageType.Fatal:
                    Logger.Fatal(msg, ex);
                    break;
                case Utilities.Types.MessageType.Warn:
                    Logger.Warn(msg, ex);
                    break;
                default:
                    break;
            }
            switch (msgPopup)
            {
                case NestleMenu.Utilities.Types.MessagePopupType.Message:
                    msgDlg.Show(msg, msgDlg.msgButtons.Close);
                    break;
                case NestleMenu.Utilities.Types.MessagePopupType.Alert:
                    if (CallObject.GetType() == typeof(Form))
                        msgDlg.ShowAlert(msg, msgTyp, (Form)CallObject);
                    else
                        msgDlg.ShowAlert(msg, msgTyp, new Form());
                    break;
            }
        }

    }
}
