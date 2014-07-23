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
using NICSQLTools.Forms;
using NICSQLTools.Forms.Data;
using NICSQLTools.Forms.Qry;


namespace NICSQLTools
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
            ////Hide All Tools
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
            //foreach (DataSources.dsData.AppRoleRow row in UserManager.defaultInstance.UserAppRoles)
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
            //if (Glob.DebugLog.IsDisposed)
            //    Glob.DebugLog = new DebugLogsFrm();
            //Glob.DebugLog.Show();
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
        private void bbiImportBillingDetailsFrm_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImportDaysFrm frm = new ImportDaysFrm() { MdiParent = this };
            frm.Show();
        }

        #endregion

        private void btnOpendb_Click(object sender, EventArgs e)
        {

            if (ofdAccess.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            //con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MyData.DatabaseFilePath);
            Properties.Settings.Default["dbConnectionString"] = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ofdAccess.FileName;
            DataManager.dbPath = ofdAccess.FileName;
            lblAccessdbPath.Text = ofdAccess.FileName;
            ribbonControl.HideApplicationButtonContentControl();
        }
        private void bbiImportProcedures_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProceduresFrm frm = new ProceduresFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImportQry_ItemClick(object sender, ItemClickEventArgs e)
        {
            QryFrm frm = new QryFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiImportExecute_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ExecuteFrm frm = new ExecuteFrm() { MdiParent = this };
            //frm.Show();
        }
        private void bbiCustomerEditorFrm_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerEditorFrm frm = new CustomerEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiRouteEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            RouteEditorFrm frm = new RouteEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiProductEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductEditorFrm frm = new ProductEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiFinalDataEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            FinalDataEditorFrm frm = new FinalDataEditorFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiQrysp_DistributionV1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Qrysp_DistributionV1Frm frm = new Qrysp_DistributionV1Frm() { MdiParent = this };
            frm.Show();
        }

    }
}
