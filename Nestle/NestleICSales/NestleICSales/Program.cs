using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Diagnostics;
using log4net;

namespace NestleICSales
{
    static class Program
    {
        public static Glob DC;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(Application.StartupPath + "\\Log4Net\\L4N.config"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            //BackgroundWorker worker = new BackgroundWorker(); worker.DoWork += worker_DoWork; worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            //worker.RunWorkerAsync();
            //Forms.SplashFrm splash = new Forms.SplashFrm(); splash.Show();
            //Properties.Settings.Default["AccessdbConnectionString"] = Properties.Settings.Default["AccessdbConnectionString"].ToString().Replace("mdb", "accdb");

            if (Glob.StartApp())
            {
                //Application.Run(new XtraForm1());
                DC.FrmMain = new Forms.MainFrm();
                Application.Run(DC.FrmMain);
            }
            Process.GetCurrentProcess().Kill();
        }
        static void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = Glob.StartApp();
        }
        static void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                // Here you can safely manipulate the GUI controls
                //Forms.MainFrm mainform = new Forms.MainFrm();
                //mainform.ShowDialog();

                //Application.Run(new Forms.MainFrm());
            }
            Application.Exit();
        }

    }
}
