using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace TinyShop
{
    static class Program
    {
        public static dbTools.misc.UserInfo UserData = new dbTools.misc.UserInfo();
        public static string dbSourcePath = Application.StartupPath + "\\defaultDB";
        public static string dbCurrentPath = Application.StartupPath + "\\TinyData.mdb";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            UserData.UserID = 1; UserData.UserName = "Admin";
            Misc.misc.LoadStartupArgs(args);

            Application.Run(new TinyShop.Forms.SplashScreenTS());
            Application.Run(new TinyShop.Forms.MainFrm());
        }
        public static void ShowMsg(string message, bool IsError, Form Owner)
        {
            if (IsError)
            {
                MessageBox.Show(Owner, message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Owner, message, "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}