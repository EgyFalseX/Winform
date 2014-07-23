using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Diagnostics;
using log4net;

namespace DataCenter
{
    static class Program
    {
        public static DataCenterX DC;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(Application.StartupPath + "\\Log4Net\\DataCenterLog4Net.config"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            
            //BackgroundWorker worker = new BackgroundWorker(); worker.DoWork += worker_DoWork; worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            //worker.RunWorkerAsync();
            //Forms.SplashFrm splash = new Forms.SplashFrm(); splash.Show();
            if (DataCenterX.StartApp())
                Application.Run(new Forms.MainFrm());
        }

        static void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = DataCenterX.StartApp();
        }
        static void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                // Here you can safely manipulate the GUI controls
                //Forms.MainFrm mainform = new Forms.MainFrm();
                //mainform.ShowDialog();
                Application.Run(new Forms.MainFrm());
            }
            Application.Exit();
        }

    }
}