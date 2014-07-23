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
using  NestleMenu.Managers;
using NestleMenu.Forms.Code;


namespace NestleMenu.Forms
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

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
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
            return;
            //Hide All Tools
            //for (int i = 0; i < ribbonControl.Items.Count; i++)
            //{
            //    if (ribbonControl.Items[i].GetType().Name == "BarButtonItem")
            //    {
            //        if (ribbonControl.Items[i].Name == "bbiHelp" || ribbonControl.Items[i].Name == "bbiExit" || ribbonControl.Items[i].Name == "bbiAbout" ||
            //            ribbonControl.Items[i].Name == "bbiSkins" || ribbonControl.Items[i].Name == "bbiInfo" || ribbonControl.Items[i].Name == "bbiStatus" ||
            //            ribbonControl.Items[i].Name == "bbiPasswordChanger")
            //            continue;
            //        ribbonControl.Items[i].Visibility = BarItemVisibility.Never;
            //    }

            //}
            ////Customizing menu visibility depand on user roles
            //foreach (DataSources.dsNM.AppRoleRow row in UserManager.defaultInstance.UserAppRoles)
            //{
            //    for (int i = 0; i < ribbonControl.Items.Count; i++)
            //    {
            //        if (row.MenuItemName == ribbonControl.Items[i].Name)
            //            ribbonControl.Items[i].Visibility = BarItemVisibility.Always;
            //    }
            //}
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
            if (NU.DebugLog.IsDisposed)
                NU.DebugLog = new DebugLogsFrm();
            NU.DebugLog.Show();
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
        private void bbiUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            //UsersFrm frm = new UsersFrm() { MdiParent = this };
            //frm.Show();
        }
        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void bbiAreaEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.AreaEditorFrm frm = new Forms.Code.AreaEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiJobEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.JobEditorFrm frm = new Forms.Code.JobEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void biiProductBaseEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.ProductBaseEditorFrm frm = new Forms.Code.ProductBaseEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiProductEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.ProductEditorFrm frm = new Forms.Code.ProductEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiMenuSizeEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.MenuSizeEditorFrm frm = new Forms.Code.MenuSizeEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiMenuThemeEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.MenuThemeEditorFrm frm = new Forms.Code.MenuThemeEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiEmployeeEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.EmployeeEditorFrm frm = new Forms.Code.EmployeeEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiCustomersEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.CustomersEditorFrm frm = new Forms.Code.CustomersEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiBranchEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Code.BranchEditorFrm frm = new Forms.Code.BranchEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiMenuOrderEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Data.MenuOrderEditorFrm frm = new Forms.Data.MenuOrderEditorFrm() { MdiParent = this };
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
        #endregion

    }
}
