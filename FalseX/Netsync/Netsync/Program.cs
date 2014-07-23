using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Netsync.Managers;
using log4net;

namespace Netsync
{
    static class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));
        public static NS ns;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inti();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
        private static void Inti()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(Application.StartupPath + "\\Log4Net\\DataCenterLog4Net.config"));
            ClientManager clnManager = new ClientManager();
            MethodManager mthManager = new MethodManager();
            ns = new NS();
        }

    }
}
