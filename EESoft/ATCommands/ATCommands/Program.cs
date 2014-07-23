using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.IO;


namespace ATCommands
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
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            MyCL.LoadSqlDBPath();
            Properties.Settings.Default["SMSConnectionString"] = MyCL.SqlConStr;
            //Application.Run(new MainFrm());
            //return;
            if (!Directory.Exists(Application.StartupPath + @"\Log"))
                Directory.CreateDirectory(Application.StartupPath + @"\Log");
            if (File.Exists(MyCL.licensePath))
            {
                Application.Run(new MainFrm());
                return;

                //USB Serial Check
                if (USBSerialNumber.IsMatchSN(MyCL.ReadFromLicenseFile()))
                    Application.Run(new MainFrm());
                else
                    MessageBox.Show("„·› «· —ŒÌ’ €Ì— ’ÕÌÕ", " „ Êﬁ› «·»—‰«„Ã...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("·« ÌÊÃœ „·› «· —ŒÌ’", " „ Êﬁ› «·»—‰«„Ã...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}