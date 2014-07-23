using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using System.Data.SqlClient;
using DevExpress.XtraSplashScreen;
using System.Linq;
using  GM.Managers;
using GM.Forms.Code;
using GM.Forms.Qry;
using GM.Reports;
using GM.Forms.Main;


namespace GM.Forms
{
    public partial class MainFrm : RibbonForm
    {

        #region -   Variables   -

        #endregion
        #region -   Functions   -
        public MainFrm()
        {
            InitializeComponent();
            InitSkinGallery();
            #if DEBUG
            ribbonPageDebug.Visible = true;
            #endif

            rgbiSkins.GalleryItemClick +=rgbiSkins_GalleryItemClick;
            if (System.IO.File.Exists(UserSkinSettings.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(UserSkinSettings.LoadSettings(UserSkinSettings.StyleSettingsPath).SkinName);
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true, true);
        }
        void OpenFileBrowserTab()
        {
            //ItemBrowserFrm frm = new ItemBrowserFrm();
            //frm.FormClosing += new FormClosingEventHandler((o, e) => 
            //{
            //    if (e.CloseReason == CloseReason.UserClosing)
            //        e.Cancel = true;
            //});
            //frm.MdiParent = this;
            //frm.Show();
        }
        private void LoadUserPriv()
        {
            //Hide All Tools
            for (int i = 0; i < ribbonControl.Items.Count; i++)
            {
                if (ribbonControl.Items[i].GetType().Name == "BarButtonItem")
                {
                    if (ribbonControl.Items[i].Name == "bbiHelp" || ribbonControl.Items[i].Name == "bbiExit" || ribbonControl.Items[i].Name == "bbiAbout" ||
                        ribbonControl.Items[i].Name == "bbiSkins" || ribbonControl.Items[i].Name == "bbiInfo" || ribbonControl.Items[i].Name == "bbiStatus" ||
                        ribbonControl.Items[i].Name == "bbiPasswordChanger")
                        continue;
                    ribbonControl.Items[i].Visibility = BarItemVisibility.Never;
                }

            }
            //Customizing menu visibility depand on user roles
            foreach (DataSources.dsQry.UserRoleDetailNamesRow row in UserManager.defaultInstance.UserRoleDetailNames)
            {
                for (int i = 0; i < ribbonControl.Items.Count; i++)
                {
                    if (row.RoleDetailName == ribbonControl.Items[i].Name)
                        ribbonControl.Items[i].Visibility = BarItemVisibility.Always;
                }
            }
        }
        
        #endregion
        #region - Event Handlers -
        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadUserPriv();
            OpenFileBrowserTab();
        }
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in this.OwnedForms)
            {
                try
                {
                    frm.Close();
                    frm.Dispose();
                }
                catch
                { }
            }
            System.Diagnostics.Process.GetCurrentProcess().Kill();

        }
        private void bbiDebugLogs_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Glob.DebugLog.IsDisposed)
                Glob.DebugLog = new DebugLogsFrm();
            Glob.DebugLog.Show();
        }
        private void TabManagerMain_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            e.Page.MdiChild.Icon.Save(ms);
            e.Page.Image = Image.FromStream(ms);
            ms.Close(); ms.Dispose();
            //if (e.Page.MdiChild.GetType())
            //{

            //}
        }
        void rgbiSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            UserSkinSettings us = new UserSkinSettings();
            us.SkinName = UserLookAndFeel.Default.ActiveSkinName;
            UserSkinSettings.SaveSettings(us);
        }
        private void bbiPasswordChanger_ItemClick(object sender, ItemClickEventArgs e)
        {
            PasswordChangerFrm frm = new PasswordChangerFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserEditorFrm frm = new UserEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            RoleEditorFrm frm = new RoleEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiUserRoleEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserRoleEditorFrm frm = new UserRoleEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiRoleDetailEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            RoleDetailEditorFrm frm = new RoleDetailEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void bbiGovEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.GovEditorFrm frm = new Forms.Code.GovEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiAreaEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.AreaEditorFrm frm = new Forms.Code.AreaEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void biiTraderEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.TraderEditorFrm frm = new Forms.Code.TraderEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiPlumberEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.PlumberEditorFrm frm = new Forms.Code.PlumberEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiItemEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.ItemEditorFrm frm = new Forms.Code.ItemEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiMenuThemeEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Forms.Code.MenuThemeEditorFrm frm = new Forms.Code.MenuThemeEditorFrm() { MdiParent = this };
            //frm.Show();
        }
        private void bbiEmployeeEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.EmployeeEditorFrm frm = new Forms.Code.EmployeeEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiCustomersEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Forms.Code.CustomersEditorFrm frm = new Forms.Code.CustomersEditorFrm() { MdiParent = this };
            //frm.Show();
        }
        private void bbiBranchEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Forms.Code.BranchEditorFrm frm = new Forms.Code.BranchEditorFrm() { MdiParent = this };
            //frm.Show();
        }
        private void bbiBillEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            BillEditorFrm frm = new BillEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQry001_ItemClick(object sender, ItemClickEventArgs e)
        {
            Qry001Frm frm = new Qry001Frm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQry002_ItemClick(object sender, ItemClickEventArgs e)
        {
            Qry002Frm frm = new Qry002Frm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQry003_ItemClick(object sender, ItemClickEventArgs e)
        {
            Qry003Frm frm = new Qry003Frm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQry004_ItemClick(object sender, ItemClickEventArgs e)
        {
            Qry004Frm frm = new Qry004Frm() { MdiParent = this };
            frm.Show();
        }
        private void bbXRep01_ItemClick(object sender, ItemClickEventArgs e)
        {
            XRep01 FrmRep = new XRep01();
            Glob.ShowPrintPreview(FrmRep);
        }
        private void bbXRep02_ItemClick(object sender, ItemClickEventArgs e)
        {
            XRep02 FrmRep = new XRep02();
            Glob.ShowPrintPreview(FrmRep);
        }
        private void bbXRep03_ItemClick(object sender, ItemClickEventArgs e)
        {
            XRep03 FrmRep = new XRep03();
            Glob.ShowPrintPreview(FrmRep);
        }
        private void bbXRep04_ItemClick(object sender, ItemClickEventArgs e)
        {
            XRep04 FrmRep = new XRep04();
            Glob.ShowPrintPreview(FrmRep);
        }
        private void bbXRep05_ItemClick(object sender, ItemClickEventArgs e)
        {
            XRep05 FrmRep = new XRep05();
            Glob.ShowPrintPreview(FrmRep);
        }
        #endregion

        

        

    }
}
