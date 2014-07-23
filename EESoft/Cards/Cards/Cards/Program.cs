using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace Cards
{
    static class Program
    {
        public static string ImagePath 
        {
            get
            {
                return Application.StartupPath + @"\images\";
            }
        }
        public static string LogoPath
        {
            get
            {
                return Application.StartupPath + @"\logo.jpg";
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            
            Application.Run(new MainFrm());
        }
    }
}