using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace Retirement
{
    static class Program
    {
        public static FXFW.SqlDB MCL = new FXFW.SqlDB();
        public static FXFW.Logger Logger;
        public static string FilesPath = Application.StartupPath + "\\Files\\";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (!System.IO.Directory.Exists(FilesPath))// Directory Path
                System.IO.Directory.CreateDirectory(FilesPath);
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            if (FXFW.SqlDB.LoadSqlDBPath("TeachersUnion") && Authentication())
            {
                LoadAppSetting();
                FXFW.SqlDB.LoadSQLReports();
                Logger = new FXFW.Logger(FXFW.Logger.LanguageInfo.Arabic, Application.ProductName, Properties.Resources.EESoft, false);

                try
                {
                    LoadStartupArgs(args);
                    Application.Run(new MainFrm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Program.Logger.LogThis(null, Application.ProductName, FXFW.Logger.OpType.fail, ex, null, null);
                }

            }
        }

        public static void ShowMsg(string Msg, bool IsError, Form ThisForm)
        {
            try
            {
                MainFrm ParentFrm = (MainFrm)ThisForm.Parent.Parent;
                ParentFrm.siInfo.Caption = Msg;
                if (IsError)
                    ParentFrm.siInfo.Appearance.ForeColor = System.Drawing.Color.Red;
                else
                    ParentFrm.siInfo.Appearance.ForeColor = System.Drawing.Color.Green;
                //ActionLog += String.Format("[{0}] [{1}] : ({2}){3}", DateTime.Now.ToShortTimeString(), ThisForm.Text, Msg, Environment.NewLine);
            }
            catch
            { }
        }
        private static void LoadStartupArgs(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name);
            foreach (string item in args)
            {
                if (item.ToLower().StartsWith("lang="))// Language
                {
                    // The following line provides localization for data formats. 
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(item.Substring(5));
                    // The following line provides localization for the application's user interface. 
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(item.Substring(5));
                }

            }
        }
        private static bool Authentication()
        {
            string filePath = Application.StartupPath + "\\lnc.key";

            if (!System.IO.File.Exists(filePath))
            {
                using (FXFW.LicenseKeyFrm dlg = new FXFW.LicenseKeyFrm(Application.ProductName))
                {
                    dlg.ShowDialog();
                }
            }

            if (!System.IO.File.Exists(filePath))
                return false;
            else
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(filePath);
                string Key = sr.ReadToEnd();
                sr.Close();
                if (FXFW.LicenseKeyFrm.Compare(Key, Application.ProductName))
                    return true;
                else
                {
                    System.IO.File.Delete(filePath);
                    Application.Restart();
                    Application.Exit();
                    return false;
                }
            }
        }
        private static void LoadAppSetting()
        {
            Properties.Settings.Default["TeachersUnionConnectionString"] = FXFW.SqlDB.SqlConStr;
            Properties.Settings.Default.Save();
        }
    }
}