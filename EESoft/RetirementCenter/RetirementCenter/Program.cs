using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace RetirementCenter
{
    static class Program
    {
        public static FXFW.SqlDB MCL = new FXFW.SqlDB();
        public static FXFW.Logger Logger;
        public static string FilesPath = Application.StartupPath + "\\Files\\";
        public static string imgPath = string.Empty;
        public static string imgExt = ".jpg";
        public static string attachPath = string.Empty;
        public static string imgPathWeb = Application.StartupPath + "\\imgPathWeb\\";
        public static string WebDB = Application.StartupPath + "\\datam.mdb";
        public static string MandoopImgPath = Application.StartupPath + "\\imgMandoopPath\\";
        public static string AppMenuName = "mbRetCenter";
        public static Image CompanyLogo;
        public static double Eshtrak = 0;
        public static double FastCardCost = 0;
        public static Misc.Types.UserInfo UserInfo = new Misc.Types.UserInfo();
        private static DevExpress.XtraBars.Alerter.AlertControl Alert = new DevExpress.XtraBars.Alerter.AlertControl() { AutoFormDelay = 4000 };
        public static string updatePath = Application.StartupPath + @"\RetirementCenter_update.exe";
        public static string AppPath = Application.StartupPath + @"\RetirementCenter.exe";

        public enum cardtype
        {
            دائمة = 1,
            مؤقتة = 2
        }
        public enum CDMashHala
        {
            Asda2 = 1,
            Warasa = 2
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            PerfomeChangeExe();
   
            Alert.AlertClick += (o, e) => { Program.Logger.ShowHideLogWindow = true; };

            if (System.IO.File.Exists(Application.StartupPath + @"\RibbonSettings.xml"))
                System.IO.File.Delete(Application.StartupPath + @"\RibbonSettings.xml");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            if (FXFW.SqlDB.LoadSqlDBPath("RetirementCenter") && Authentication())
            {
                LoadAppSetting();
                FXFW.SqlDB.LoadSQLReports();
                Logger = new FXFW.Logger(FXFW.Logger.LanguageInfo.Arabic, Application.ProductName, Properties.Resources.EESoft, false);
                
                try
                {
                    LoadStartupArgs(args);
                    LoadAppOptions(); //CreateDirectories();
                    //Members.DataSources.TeachersUnion.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.None);
                    if (!CheckExpiration())
                    {
                        MessageBox.Show("Problem found in database, data maybe lose if you continue" + Environment.NewLine + "Are you sure want to continue" + Environment.NewLine + "?",
                            "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }

                    System.Threading.ThreadPool.QueueUserWorkItem((o) =>
                    {
                        using (SplashFrm SC = new SplashFrm())// Show Splash Screen..
                            SC.ShowDialog();
                    });
                    using (LoginFrm FrmLogin = new LoginFrm())
                    {
                        //Create Administrator user if not exists b4 show login form
                        if (!SQLProvider.PrepareBaseRole())
                            return;
                        DatabaseScripts.FireScript();//add my views
                        FrmLogin.ShowDialog();
                    }

                    SQLProvider.PerformUpdate();

                    Application.Run(new MainFrm());
                }
                catch (Exception ex)
                {
                    msgDlg.Show(ex.Message);
                    Program.Logger.LogThis(null, Application.ProductName, FXFW.Logger.OpType.fail, ex, null, null);
                }
            }
        }

        public static void ShowMsg(string Msg, bool IsError, Form ThisForm, bool Popup = false)
        {
            try
            {
                MainFrm ParentFrm = (MainFrm)ThisForm.Parent.Parent;
                ParentFrm.mbRetCenterInfo.Caption = Msg;
                if (IsError)
                    ParentFrm.mbRetCenterInfo.Appearance.ForeColor = System.Drawing.Color.Red;
                else
                    ParentFrm.mbRetCenterInfo.Appearance.ForeColor = System.Drawing.Color.Green;
                //ActionLog += String.Format("[{0}] [{1}] : ({2}){3}", DateTime.Now.ToShortTimeString(), ThisForm.Text, Msg, Environment.NewLine);
            }
            catch
            { }
            if (Popup)
            {
                FXFW.Logger.LogDetails logDetails = new FXFW.Logger.LogDetails() { message = Msg, Owner = ThisForm };
                
                DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo(Application.ProductName, Msg);
                if (IsError)
                    info.Image = Properties.Resources.error;
                else
                    info.Image = Properties.Resources.done;
                Alert.Show(ThisForm, info);
            }
        }
        private static void LoadStartupArgs(string[] args)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name);
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name);
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
        private static void LoadAppOptions()
        {
            System.Data.DataRow row = SQLProvider.SelectAppOptions().Rows[0];

            imgPath = row["imgPath"].ToString();
            attachPath = row["attachPath"].ToString();
            MandoopImgPath = row["MandoopImgPath"].ToString();
            imgPathWeb = row["imgPathWeb"].ToString();
            Eshtrak = Convert.ToDouble(row["Eshtrak"]);
            FastCardCost = Convert.ToDouble(row["Rasm"]);
            
            //Load Company Logo
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (!FXFW.SqlDB.IsNullOrEmpty(row["CompanyLogo"]))
                ms = new System.IO.MemoryStream((byte[])row["CompanyLogo"]);
            else
                Properties.Resources.EESoft.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            CompanyLogo = Image.FromStream(ms);

            if (imgPath.Remove(0, imgPath.Length - 1) != @"\")
                imgPath += @"\";
            if (attachPath.Remove(0, attachPath.Length - 1) != @"\")
                attachPath += @"\";
            if (MandoopImgPath.Remove(0, MandoopImgPath.Length - 1) != @"\")
                MandoopImgPath += @"\";
            if (imgPathWeb.Remove(0, imgPathWeb.Length - 1) != @"\")
                imgPathWeb += @"\";
        }
        private static void LoadAppSetting()
        {
            SQLProvider.ConnectionString = FXFW.SqlDB.SqlConStr;
        }
        private static void CreateDirectories()
        {
            if (!System.IO.Directory.Exists(FilesPath))// Directory Path
                System.IO.Directory.CreateDirectory(FilesPath);
            if (!System.IO.Directory.Exists(imgPath))
                System.IO.Directory.CreateDirectory(imgPath);
            if (!System.IO.Directory.Exists(imgPathWeb))
                System.IO.Directory.CreateDirectory(imgPathWeb);
            if (!System.IO.Directory.Exists(MandoopImgPath))
                System.IO.Directory.CreateDirectory(MandoopImgPath);
        }
        private static void PerfomeChangeExe()
        {
            if (Program.updatePath == Application.ExecutablePath)
            {
                byte[] data = System.IO.File.ReadAllBytes(Application.ExecutablePath);
                System.IO.FileStream fs = System.IO.File.Create(Program.AppPath);
                fs.Write(data, 0, data.Length);
                fs.Close();
                System.Diagnostics.Process.Start(Program.AppPath);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                return;
            }
        }
        private static bool CheckExpiration()
        {
            DateTime periodDate = new DateTime(2014, 8, 17);
            bool ReturnMe = false;
            DataSources.dsQueries ds = new DataSources.dsQueries();
            DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();

            if (periodDate > SQLProvider.ServerDateTime())
            {
                adpQry.UpdateQueryStartAuth();
                return true;
            }

            try
            {
                ReturnMe = (bool)adpQry.ScalarQueryAuth();
                if (ReturnMe)
                {
                    if (DateTime.Compare(periodDate, (DateTime)adpQry.ServerDateTime()) != 1)
                    {
                        ReturnMe = false;
                        adpQry.UpdateQueryEndAuth();
                    }
                }
            }
            catch { }
            return ReturnMe;

        }
    }
}