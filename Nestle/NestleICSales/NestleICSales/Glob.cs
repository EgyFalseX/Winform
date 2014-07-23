using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using NestleICSales.Managers;
using NestleICSales.Forms.Main;

namespace NestleICSales
{
    public class Glob
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Glob));
        //public static nsLib.nsLib NSManager { get; set; }
        public static NestleICSales.Forms.DebugLogsFrm DebugLog { get; set; }
        public Forms.MainFrm FrmMain = null;
        public Glob()
        {
        }
        public static bool StartApp()
        {
            DebugLog = new Forms.DebugLogsFrm();
            #if DEBUG
            DebugLog.Show();
            Application.DoEvents();
            #endif
            SplashScreenManager.ShowForm(typeof(Forms.Main.SplashScreenFrm));

            Program.DC = new Glob();
            //Init User AppManager
            if (SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.Default.SendCommand(SplashScreenFrm.SplashScreenCommand.SetState, "Loading Application Manager ...");
            if (AppManager.Init())
            {
                if (!AppManager.defaultInstance.LoadSqlDBPath(AppManager.defaultInstance.DatabaseName))
                    return false;
                else
                {
                    Properties.Settings.Default["MainConnectionString"] = AppManager.defaultInstance.SqlConStr;
                    //Properties.Settings.Default.Save();
                    DevExpress.Xpo.XpoDefault.Session.ConnectionString = AppManager.defaultInstance.SqlConStr;
                    DevExpress.Xpo.XpoDefault.ConnectionString = AppManager.defaultInstance.SqlConStr;
                    DevExpress.Xpo.XpoDefault.Session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
                }
            }
            else
                return false;
            //Init DataManager
            if (SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.Default.SendCommand(SplashScreenFrm.SplashScreenCommand.SetState, "Loading Data Manager ...");
            if (!DataManager.Init())
                return false;
            AppManager.defaultInstance.LoadServerOptions();
            //Init UserManager
            if (SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.Default.SendCommand(SplashScreenFrm.SplashScreenCommand.SetState, "Loading User Manager ...");
            if (!UserManager.Init())
                return false;
            //Init Login
            if (SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.Default.SendCommand(SplashScreenFrm.SplashScreenCommand.SetState, "Waiting user login ...");
            if (!Program.DC.Login())
                return false;
            //Init Options
            if (SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.Default.SendCommand(SplashScreenFrm.SplashScreenCommand.SetState, "Loading Application Options ...");
            if (!AppManager.defaultInstance.CheckReqOptions())
            {
                Forms.ServerOptionWizardFrm frm = new Forms.ServerOptionWizardFrm();
                frm.ShowDialog();
                if (!AppManager.defaultInstance.CheckReqOptions())
                    return false;
            }

            SplashScreenManager.CloseForm();

            //NSManager = new nsLib.nsLib(Convert.ToInt32(AppManager.defaultInstance.GetServerOption(Utilities.Types.ServerOptions.ServerPort)), 
            //    AppManager.defaultInstance.GetServerOption(Utilities.Types.ServerOptions.ServerIP).ToString());
            //if (!NSManager.ConnectMe())
            //    return false;

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
        public static void _LogMessage(string msg, Type typ, Utilities.Types.MessageType msgTyp, Exception ex = null, bool ShowMsg = false)
        {
            log4net.ILog Logger = log4net.LogManager.GetLogger(typ);
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
            MsgDlg.Show(msg, msgTyp, ex);
        }

    }
}
