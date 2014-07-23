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
using  NestleICSales.Managers;
using NestleICSales.Forms.Code;
using NestleICSales.Forms.Import;
using NestleICSales.Forms.Qry;


namespace NestleICSales.Forms
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
            foreach (DataSources.dsData.AppRoleRow row in UserManager.defaultInstance.UserAppRoles)
            {
                for (int i = 0; i < ribbonControl.Items.Count; i++)
                {
                    if (row.MenuItemName == ribbonControl.Items[i].Name)
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

            //new XtraForm1().Show();
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
        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void bbiRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            //RoleFrm frm = new RoleFrm() { MdiParent = this };
            //frm.Show();
        }
        private void bbiUserRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            //UserRoleFrm frm = new UserRoleFrm() { MdiParent = this };
            //frm.Show();
        }
        private void bbiUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            //UsersFrm frm = new UsersFrm() { MdiParent = this };
            //frm.Show();
        }
        private void bbiAppRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            //AppRoleFrm frm = new AppRoleFrm() { MdiParent = this };
            //frm.Show();
        }
        private void bbiServerOptionWizard_ItemClick(object sender, ItemClickEventArgs e)
        {
            ServerOptionWizardFrm frm = new ServerOptionWizardFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiCityEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            CityEditorFrm frm = new CityEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportFrm frm = new ImportFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImportRouteCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportRouteCustomerFrm frm = new ImportRouteCustomerFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiSalesSummary_ItemClick(object sender, ItemClickEventArgs e)
        {
            SalesSummaryFrm frm = new SalesSummaryFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImportBillingDetailsFrm_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportBillingDetailsFrm frm = new ImportBillingDetailsFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImportEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportEmployeeFrm frm = new ImportEmployeeFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImportEquipment_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportEquipmentFrm frm = new ImportEquipmentFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImportRoute_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportRouteFrm frm = new ImportRouteFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImportRouteTarget_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportRouteTargetFrm frm = new ImportRouteTargetFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiCustomerEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Data.CustomerEditorFrm frm = new Data.CustomerEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiRouteEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Data.RouteEditorFrm frm = new Data.RouteEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiProductEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Data.ProductEditorFrm frm = new Data.ProductEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQry001_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryPro_0001AFrm frm = new QryPro_0001AFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQry002_ItemClick(object sender, ItemClickEventArgs e)
        {
            Qry002Frm frm = new Qry002Frm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQryPro_0001A_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryPro_0001AFrm frm = new QryPro_0001AFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQryPro_0001B_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryPro_0001BFrm frm = new QryPro_0001BFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQryPro_0001C_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryPro_0001CFrm frm = new QryPro_0001CFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQryPro_0002_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryPro_0002Frm frm = new QryPro_0002Frm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQryPro_0001D_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryPro_0001DFrm frm = new QryPro_0001DFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQryPro_0004_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryPro_0003Frm frm = new QryPro_0003Frm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQryPro_0005_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryPro_0004Frm frm = new QryPro_0004Frm() { MdiParent = this };
            frm.Show();
        }
         
        #endregion

    }
}
