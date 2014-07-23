using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using GM.Managers;

namespace GM
{
    public class Glob
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Glob));
        //public static nsLib.nsLib NSManager { get; set; }
        public static GM.Forms.DebugLogsFrm DebugLog { get; set; }

        public Glob()
        {
        }

        public static bool StartApp()
        {
            DebugLog = new Forms.DebugLogsFrm();
            #if DEBUG
            DebugLog.Show();
            #endif

            Program.DC = new Glob();
            if (AppManager.Init())
            {
                
            }
            else
                return false;

            if (!DataManager.Init())
                return false;
            //AppManager.defaultInstance.LoadServerOptions();

            if (!UserManager.Init())
                return false;

            if (!Program.DC.Login())
                return false;

            //if (!AppManager.defaultInstance.CheckReqOptions())
            //{
            //    if (!AppManager.defaultInstance.CheckReqOptions())
            //        return false;
            //}
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
                case GM.Utilities.Types.MessagePopupType.Message:
                    msgDlg.Show(msg, msgDlg.msgButtons.Close);
                    break;
                case GM.Utilities.Types.MessagePopupType.Alert:
                    if (CallObject.GetType() == typeof(Form))
                        msgDlg.ShowAlert(msg, msgTyp, (Form)CallObject);
                    else
                        msgDlg.ShowAlert(msg, msgTyp, new Form());
                    break;
            }
        }

        public static void ShowPrintPreview(DevExpress.XtraReports.IReport report, bool dlg = false)
        {
            // Create a Print Tool and show the Print Preview form. 
            DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(report);

            // Set watermark options.
            //printTool.PrintingSystem.Watermark.Image = Program.CompanyLogo;
            //printTool.PrintingSystem.Watermark.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            //printTool.PrintingSystem.Watermark.ImageTiling = false;
            //printTool.PrintingSystem.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;
            //printTool.PrintingSystem.Watermark.ImageTransparency = 150;
            //printTool.PrintingSystem.Watermark.ShowBehind = false;
            //printTool.PrintingSystem.Watermark.PageRange = "1";
            if (dlg)
                printTool.ShowRibbonPreviewDialog();
            else
                printTool.ShowRibbonPreview();
        }

    }
}
