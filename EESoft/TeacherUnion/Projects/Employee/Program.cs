using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace Employee
{
    static class Program
    {
        public static FXFW.SqlDB MCL = new FXFW.SqlDB();
        public static FXFW.Logger Logger;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            if (FXFW.SqlDB.LoadSqlDBPath("TeachersUnion") && Authentication())
            {
                FXFW.SqlDB.LoadSQLReports();
                Logger = new FXFW.Logger(FXFW.Logger.LanguageInfo.English, Application.ProductName, Properties.Resources.EESoft, false);
                
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
            
            MainFrm ParentFrm;
            if (ThisForm.Parent == null)
            {
                if (ThisForm is MainFrm)
                    ParentFrm = (MainFrm)ThisForm;
                else
                    return;
            }
            else
                ParentFrm = (MainFrm)ThisForm.Parent.Parent;

            int start = ParentFrm.Logging.TextLength;
            ParentFrm.Logging.AppendText(String.Format("{0}[{1}] [{2}] : ", Environment.NewLine, DateTime.Now.ToShortTimeString(), ThisForm.Text));
            ParentFrm.Logging.Select(start, ParentFrm.Logging.TextLength - start);
            ParentFrm.Logging.SelectionColor = System.Drawing.Color.Gray;
            ParentFrm.Logging.SelectionFont = new System.Drawing.Font("Tahoma", 6, System.Drawing.FontStyle.Bold);
            start = ParentFrm.Logging.TextLength;
            ParentFrm.Logging.AppendText(Msg);
            ParentFrm.Logging.Select(start, ParentFrm.Logging.TextLength - start);
            //Andalus
            ParentFrm.Logging.SelectionFont = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular);
            if (IsError)
                ParentFrm.Logging.SelectionColor = System.Drawing.Color.Red;
            else
                ParentFrm.Logging.SelectionColor = System.Drawing.Color.Green;
            ParentFrm.Logging.ScrollToCaret();
        }
        private static void LoadStartupArgs(string[] args)
        {
            //DevExpress.XtraGrid.Localization.GridLocalizer.Active = new FXFW.EnglishGridLocalizer();
            //DevExpress.XtraEditors.Controls.Localizer.Active = new FXFW.EnglishEditorsLocalizer();
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
    }
}