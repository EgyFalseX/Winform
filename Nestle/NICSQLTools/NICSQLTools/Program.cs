using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace NICSQLTools
{
    static class Program
    {
        public static string updatePath = Application.StartupPath + @"\UpdateObject";
        public static string AppPath = Application.StartupPath + @"\NICSQLTools.exe";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataManager.PerformChangeExe();
            
            //UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (FXFW.SqlDB.LoadSqlDBPath("IC_DB"))
            {
                Properties.Settings.Default["IC_DBConnectionString"] = FXFW.SqlDB.SqlConStr;

                Init();
                //Set User Info
                DataManager.User.RealName = "Public Test"; DataManager.User.IsAdmin = true;
                DataManager.PerformUpdate();
                Application.Run(new MainFrm());
            }
            
        }
        public static void Init()
        {
            DataManager.Init();
        }

    }
}
