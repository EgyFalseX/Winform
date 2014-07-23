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
using  DataCenter.Managers;


namespace DataCenter.Forms
{
    public partial class MainFrm : RibbonForm
    {
        
        #region -   Variables   -
        private DataCenter.DataSources.dsDataCenterTableAdapters.CategoryTableAdapter adpCat = new DataSources.dsDataCenterTableAdapters.CategoryTableAdapter();
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
            ItemBrowserFrm frm = new ItemBrowserFrm();
            frm.FormClosing += new FormClosingEventHandler((o, e) => 
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
            });
            frm.MdiParent = this;
            frm.Show();
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
            foreach (DataSources.dsDataCenter.AppRoleRow row in UserManager.defaultInstance.UserAppRoles)
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
        }
        private void bbiDebugLogs_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DataCenterX.DebugLog.IsDisposed)
                DataCenterX.DebugLog = new DebugLogsFrm();
            DataCenterX.DebugLog.Show();
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
        private void bbiFileType_ItemClick(object sender, ItemClickEventArgs e)
        {
            FileTypeFrm frm = new FileTypeFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiIcons_ItemClick(object sender, ItemClickEventArgs e)
        {
            IconsFrm frm = new IconsFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            RoleFrm frm = new RoleFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiUserRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserRoleFrm frm = new UserRoleFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            UsersFrm frm = new UsersFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiAppRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            AppRoleFrm frm = new AppRoleFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiServerOptionWizard_ItemClick(object sender, ItemClickEventArgs e)
        {
            ServerOptionWizardFrm frm = new ServerOptionWizardFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiDeletedItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletedItemFrm frm = new DeletedItemFrm() { MdiParent = this };
            frm.Show();
        }
        private void bbiDeletedCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletedCategoryFrm frm = new DeletedCategoryFrm() { MdiParent = this };
            frm.Show();
        }
        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
