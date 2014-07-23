using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DbSyc_Server
{
    static class Program
    {
        public static svc Service;
        public static DbSycMainFrm MainFrm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Service = new svc(Properties.Settings.Default.Port);
            MainFrm = new DbSycMainFrm();

            Application.Run(MainFrm);
        }
    }
}
