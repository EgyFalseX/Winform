using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace RealEstate
{
    static class Program
    {
        public static MyCL MCL = new MyCL();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            //UserLookAndFeel.Default.SetSkinStyle("Dark Side");
            if (MyCL.LoadDBPath())
            {
                MyCL.LoadCRReports();
                Application.Run(new FrmMain());
            }
        }
    }
}