namespace NICSQLTools
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControlMain = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.DockingMain = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.backstageViewClientControlOpenAccess = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.lblAccessdbPath = new DevExpress.XtraEditors.LabelControl();
            this.btnOpendb = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.backstageViewTabItemOpenAccess = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.siInfo = new DevExpress.XtraBars.BarStaticItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbiDebugLogs = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImportBillingDetails = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImportProcedures = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImportQry = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImportExecute = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCustomerEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRouteEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProductEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFinalDataEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiQrysp_DistributionV1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiQryDistribution = new DevExpress.XtraBars.BarSubItem();
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCode = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ExeribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageImport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupImportImportData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQry = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupQry = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageDebug = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDebugLog = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TabManagerMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ofdAccess = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.backstageViewControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DockingMain)).BeginInit();
            this.backstageViewClientControlOpenAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
            this.popupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabManagerMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.backstageViewControlMain;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.Controller = this.DockingMain;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.iExit,
            this.iHelp,
            this.iAbout,
            this.siStatus,
            this.siInfo,
            this.rgbiSkins,
            this.bbiDebugLogs,
            this.bbiImportBillingDetails,
            this.bbiImportProcedures,
            this.bbiImportQry,
            this.bbiImportExecute,
            this.bbiCustomerEditor,
            this.bbiRouteEditor,
            this.bbiProductEditor,
            this.bbiFinalDataEditor,
            this.bbiQrysp_DistributionV1,
            this.bbiQryDistribution});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage,
            this.ribbonPageImport,
            this.ribbonPageQry,
            this.helpRibbonPage,
            this.ribbonPageDebug});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(1100, 144);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iHelp);
            // 
            // backstageViewControlMain
            // 
            this.backstageViewControlMain.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControlMain.Controller = this.DockingMain;
            this.backstageViewControlMain.Controls.Add(this.backstageViewClientControlOpenAccess);
            this.backstageViewControlMain.Images = this.ribbonImageCollectionLarge;
            this.backstageViewControlMain.Items.Add(this.backstageViewTabItemOpenAccess);
            this.backstageViewControlMain.Location = new System.Drawing.Point(12, 150);
            this.backstageViewControlMain.Name = "backstageViewControlMain";
            this.backstageViewControlMain.Ribbon = this.ribbonControl;
            this.backstageViewControlMain.SelectedTab = this.backstageViewTabItemOpenAccess;
            this.backstageViewControlMain.SelectedTabIndex = 0;
            this.backstageViewControlMain.Size = new System.Drawing.Size(480, 513);
            this.backstageViewControlMain.TabIndex = 6;
            // 
            // DockingMain
            // 
            this.DockingMain.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.DockingMain.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // backstageViewClientControlOpenAccess
            // 
            this.backstageViewClientControlOpenAccess.Controls.Add(this.lblAccessdbPath);
            this.backstageViewClientControlOpenAccess.Controls.Add(this.btnOpendb);
            this.backstageViewClientControlOpenAccess.Location = new System.Drawing.Point(177, 63);
            this.backstageViewClientControlOpenAccess.Name = "backstageViewClientControlOpenAccess";
            this.backstageViewClientControlOpenAccess.Size = new System.Drawing.Size(302, 449);
            this.backstageViewClientControlOpenAccess.TabIndex = 0;
            // 
            // lblAccessdbPath
            // 
            this.lblAccessdbPath.Location = new System.Drawing.Point(16, 176);
            this.lblAccessdbPath.Name = "lblAccessdbPath";
            this.lblAccessdbPath.Size = new System.Drawing.Size(209, 13);
            this.lblAccessdbPath.TabIndex = 1;
            this.lblAccessdbPath.Text = "Click \"Browse\" to select an access database";
            // 
            // btnOpendb
            // 
            this.btnOpendb.ImageIndex = 15;
            this.btnOpendb.ImageList = this.ribbonImageCollectionLarge;
            this.btnOpendb.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnOpendb.Location = new System.Drawing.Point(16, 103);
            this.btnOpendb.Name = "btnOpendb";
            this.btnOpendb.Size = new System.Drawing.Size(97, 67);
            this.btnOpendb.TabIndex = 0;
            this.btnOpendb.Text = "Browse";
            this.btnOpendb.Click += new System.EventHandler(this.btnOpendb_Click);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Info_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "RolePriv.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "UserRole.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Users.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Settings.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Debuglog.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "AppRole.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "ImportData.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "Qry.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "Customer32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(12, "Route32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(13, "ProductBase32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(14, "City32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(15, "Open32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(16, "Access32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(17, "Customer32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(18, "Route32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(19, "ProductBase32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(20, "Master32.png");
            // 
            // backstageViewTabItemOpenAccess
            // 
            this.backstageViewTabItemOpenAccess.Caption = "Select Database";
            this.backstageViewTabItemOpenAccess.ContentControl = this.backstageViewClientControlOpenAccess;
            this.backstageViewTabItemOpenAccess.ImageIndex = 16;
            this.backstageViewTabItemOpenAccess.Name = "backstageViewTabItemOpenAccess";
            this.backstageViewTabItemOpenAccess.Selected = true;
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "RolePriv.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "UserRole.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Users.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Settings.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Debuglog.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "AppRole.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "ImportData.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Qry.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Customer16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Route16.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "ProductBase16.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "City16.png");
            this.ribbonImageCollection.Images.SetKeyName(15, "Open16.png");
            this.ribbonImageCollection.Images.SetKeyName(16, "Access16.png");
            this.ribbonImageCollection.Images.SetKeyName(17, "Customer16.png");
            this.ribbonImageCollection.Images.SetKeyName(18, "Route16.png");
            this.ribbonImageCollection.Images.SetKeyName(19, "ProductBase16.png");
            this.ribbonImageCollection.Images.SetKeyName(20, "Master16.png");
            // 
            // iExit
            // 
            this.iExit.Caption = "Exit";
            this.iExit.Description = "Closes this program after prompting you to save unsaved data.";
            this.iExit.Hint = "Closes this program after prompting you to save unsaved data";
            this.iExit.Id = 20;
            this.iExit.ImageIndex = 0;
            this.iExit.LargeImageIndex = 0;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Help";
            this.iHelp.Description = "Start the program help system.";
            this.iHelp.Hint = "Start the program help system";
            this.iHelp.Id = 22;
            this.iHelp.ImageIndex = 1;
            this.iHelp.LargeImageIndex = 1;
            this.iHelp.Name = "iHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "About";
            this.iAbout.Description = "Displays general program information.";
            this.iAbout.Hint = "Displays general program information";
            this.iAbout.Id = 24;
            this.iAbout.ImageIndex = 2;
            this.iAbout.LargeImageIndex = 2;
            this.iAbout.Name = "iAbout";
            // 
            // siStatus
            // 
            this.siStatus.Caption = "Ready";
            this.siStatus.Id = 31;
            this.siStatus.Name = "siStatus";
            this.siStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // siInfo
            // 
            this.siInfo.Caption = "Nothing";
            this.siInfo.Id = 32;
            this.siInfo.Name = "siInfo";
            this.siInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // bbiDebugLogs
            // 
            this.bbiDebugLogs.Caption = "Debug Log";
            this.bbiDebugLogs.Id = 70;
            this.bbiDebugLogs.ImageIndex = 7;
            this.bbiDebugLogs.LargeImageIndex = 7;
            this.bbiDebugLogs.Name = "bbiDebugLogs";
            this.bbiDebugLogs.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiDebugLogs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDebugLogs_ItemClick);
            // 
            // bbiImportBillingDetails
            // 
            this.bbiImportBillingDetails.Caption = "Import R3";
            this.bbiImportBillingDetails.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiImportBillingDetails.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiImportBillingDetails.Glyph")));
            this.bbiImportBillingDetails.Id = 4;
            this.bbiImportBillingDetails.Name = "bbiImportBillingDetails";
            this.bbiImportBillingDetails.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiImportBillingDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportBillingDetailsFrm_ItemClick);
            // 
            // bbiImportProcedures
            // 
            this.bbiImportProcedures.Caption = "Procedures";
            this.bbiImportProcedures.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiImportProcedures.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiImportProcedures.Glyph")));
            this.bbiImportProcedures.Id = 11;
            this.bbiImportProcedures.Name = "bbiImportProcedures";
            this.bbiImportProcedures.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiImportProcedures.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportProcedures_ItemClick);
            // 
            // bbiImportQry
            // 
            this.bbiImportQry.Caption = "Queries";
            this.bbiImportQry.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiImportQry.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiImportQry.Glyph")));
            this.bbiImportQry.Id = 12;
            this.bbiImportQry.Name = "bbiImportQry";
            this.bbiImportQry.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiImportQry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportQry_ItemClick);
            // 
            // bbiImportExecute
            // 
            this.bbiImportExecute.Caption = "Execute";
            this.bbiImportExecute.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiImportExecute.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiImportExecute.Glyph")));
            this.bbiImportExecute.Id = 13;
            this.bbiImportExecute.Name = "bbiImportExecute";
            this.bbiImportExecute.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiImportExecute.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportExecute_ItemClick);
            // 
            // bbiCustomerEditor
            // 
            this.bbiCustomerEditor.Caption = "Customers Editor";
            this.bbiCustomerEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiCustomerEditor.Id = 14;
            this.bbiCustomerEditor.ImageIndex = 17;
            this.bbiCustomerEditor.LargeImageIndex = 17;
            this.bbiCustomerEditor.Name = "bbiCustomerEditor";
            this.bbiCustomerEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCustomerEditorFrm_ItemClick);
            // 
            // bbiRouteEditor
            // 
            this.bbiRouteEditor.Caption = "Routes Editor";
            this.bbiRouteEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiRouteEditor.Id = 15;
            this.bbiRouteEditor.ImageIndex = 18;
            this.bbiRouteEditor.LargeImageIndex = 18;
            this.bbiRouteEditor.Name = "bbiRouteEditor";
            this.bbiRouteEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRouteEditor_ItemClick);
            // 
            // bbiProductEditor
            // 
            this.bbiProductEditor.Caption = "Product Editor";
            this.bbiProductEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiProductEditor.Id = 16;
            this.bbiProductEditor.ImageIndex = 19;
            this.bbiProductEditor.LargeImageIndex = 19;
            this.bbiProductEditor.Name = "bbiProductEditor";
            this.bbiProductEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProductEditor_ItemClick);
            // 
            // bbiFinalDataEditor
            // 
            this.bbiFinalDataEditor.Caption = "Final Data";
            this.bbiFinalDataEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiFinalDataEditor.Id = 17;
            this.bbiFinalDataEditor.ImageIndex = 20;
            this.bbiFinalDataEditor.LargeImageIndex = 20;
            this.bbiFinalDataEditor.Name = "bbiFinalDataEditor";
            this.bbiFinalDataEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFinalDataEditor_ItemClick);
            // 
            // bbiQrysp_DistributionV1
            // 
            this.bbiQrysp_DistributionV1.Caption = "Distribution Per Route";
            this.bbiQrysp_DistributionV1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiQrysp_DistributionV1.Id = 18;
            this.bbiQrysp_DistributionV1.ImageIndex = 10;
            this.bbiQrysp_DistributionV1.LargeImageIndex = 10;
            this.bbiQrysp_DistributionV1.Name = "bbiQrysp_DistributionV1";
            this.bbiQrysp_DistributionV1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiQrysp_DistributionV1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiQrysp_DistributionV1_ItemClick);
            // 
            // bbiQryDistribution
            // 
            this.bbiQryDistribution.Caption = "Distribution";
            this.bbiQryDistribution.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiQryDistribution.Id = 19;
            this.bbiQryDistribution.ImageIndex = 10;
            this.bbiQryDistribution.LargeImageIndex = 10;
            this.bbiQryDistribution.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiQrysp_DistributionV1)});
            this.bbiQryDistribution.Name = "bbiQryDistribution";
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCode,
            this.dataRibbonPageGroup,
            this.ExeribbonPageGroup,
            this.skinsRibbonPageGroup,
            this.exitRibbonPageGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Home";
            // 
            // ribbonPageGroupCode
            // 
            this.ribbonPageGroupCode.ItemLinks.Add(this.bbiImportProcedures);
            this.ribbonPageGroupCode.ItemLinks.Add(this.bbiImportQry);
            this.ribbonPageGroupCode.Name = "ribbonPageGroupCode";
            this.ribbonPageGroupCode.Text = "Code";
            // 
            // dataRibbonPageGroup
            // 
            this.dataRibbonPageGroup.ItemLinks.Add(this.bbiFinalDataEditor);
            this.dataRibbonPageGroup.ItemLinks.Add(this.bbiCustomerEditor);
            this.dataRibbonPageGroup.ItemLinks.Add(this.bbiRouteEditor);
            this.dataRibbonPageGroup.ItemLinks.Add(this.bbiProductEditor);
            this.dataRibbonPageGroup.Name = "dataRibbonPageGroup";
            this.dataRibbonPageGroup.Text = "Data";
            // 
            // ExeribbonPageGroup
            // 
            this.ExeribbonPageGroup.ItemLinks.Add(this.bbiImportExecute);
            this.ExeribbonPageGroup.Name = "ExeribbonPageGroup";
            this.ExeribbonPageGroup.Text = "Execution";
            // 
            // skinsRibbonPageGroup
            // 
            this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
            this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
            this.skinsRibbonPageGroup.ShowCaptionButton = false;
            this.skinsRibbonPageGroup.Text = "Skins";
            // 
            // exitRibbonPageGroup
            // 
            this.exitRibbonPageGroup.ItemLinks.Add(this.iExit);
            this.exitRibbonPageGroup.Name = "exitRibbonPageGroup";
            this.exitRibbonPageGroup.Text = "Exit";
            // 
            // ribbonPageImport
            // 
            this.ribbonPageImport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupImportImportData});
            this.ribbonPageImport.Name = "ribbonPageImport";
            this.ribbonPageImport.Text = "Import Data";
            // 
            // ribbonPageGroupImportImportData
            // 
            this.ribbonPageGroupImportImportData.ItemLinks.Add(this.bbiImportBillingDetails);
            this.ribbonPageGroupImportImportData.Name = "ribbonPageGroupImportImportData";
            this.ribbonPageGroupImportImportData.Text = "Import data from external datasource";
            // 
            // ribbonPageQry
            // 
            this.ribbonPageQry.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupQry});
            this.ribbonPageQry.Name = "ribbonPageQry";
            this.ribbonPageQry.Text = "Queries";
            // 
            // ribbonPageGroupQry
            // 
            this.ribbonPageGroupQry.ItemLinks.Add(this.bbiQryDistribution);
            this.ribbonPageGroupQry.Name = "ribbonPageGroupQry";
            this.ribbonPageGroupQry.Text = "Queries";
            // 
            // helpRibbonPage
            // 
            this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.helpRibbonPageGroup});
            this.helpRibbonPage.Name = "helpRibbonPage";
            this.helpRibbonPage.Text = "Help";
            // 
            // helpRibbonPageGroup
            // 
            this.helpRibbonPageGroup.ItemLinks.Add(this.iHelp);
            this.helpRibbonPageGroup.ItemLinks.Add(this.iAbout);
            this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
            this.helpRibbonPageGroup.Text = "Help";
            // 
            // ribbonPageDebug
            // 
            this.ribbonPageDebug.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupDebugLog});
            this.ribbonPageDebug.Name = "ribbonPageDebug";
            this.ribbonPageDebug.Text = "Debug";
            this.ribbonPageDebug.Visible = false;
            // 
            // ribbonPageGroupDebugLog
            // 
            this.ribbonPageGroupDebugLog.ItemLinks.Add(this.bbiDebugLogs);
            this.ribbonPageGroupDebugLog.Name = "ribbonPageGroupDebugLog";
            this.ribbonPageGroupDebugLog.Text = "Log";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.siStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.siInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 669);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1100, 31);
            // 
            // appMenu
            // 
            this.appMenu.BottomPaneControlContainer = this.popupControlContainer2;
            this.appMenu.ItemLinks.Add(this.iExit);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            this.appMenu.RightPaneControlContainer = this.popupControlContainer1;
            this.appMenu.ShowRightPane = true;
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer2.Appearance.Options.UseBackColor = true;
            this.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer2.Controls.Add(this.buttonEdit);
            this.popupControlContainer2.Location = new System.Drawing.Point(887, 618);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Ribbon = this.ribbonControl;
            this.popupControlContainer2.Size = new System.Drawing.Size(118, 28);
            this.popupControlContainer2.TabIndex = 3;
            this.popupControlContainer2.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.EditValue = "Some Text";
            this.buttonEdit.Location = new System.Drawing.Point(3, 5);
            this.buttonEdit.MenuManager = this.ribbonControl;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit.Size = new System.Drawing.Size(100, 20);
            this.buttonEdit.TabIndex = 0;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.someLabelControl2);
            this.popupControlContainer1.Controls.Add(this.someLabelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(805, 576);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl;
            this.popupControlContainer1.Size = new System.Drawing.Size(76, 70);
            this.popupControlContainer1.TabIndex = 2;
            this.popupControlContainer1.Visible = false;
            // 
            // someLabelControl2
            // 
            this.someLabelControl2.Location = new System.Drawing.Point(3, 57);
            this.someLabelControl2.Name = "someLabelControl2";
            this.someLabelControl2.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl2.TabIndex = 0;
            this.someLabelControl2.Text = "Some Info";
            // 
            // someLabelControl1
            // 
            this.someLabelControl1.Location = new System.Drawing.Point(3, 3);
            this.someLabelControl1.Name = "someLabelControl1";
            this.someLabelControl1.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl1.TabIndex = 0;
            this.someLabelControl1.Text = "Some Info";
            // 
            // TabManagerMain
            // 
            this.TabManagerMain.Controller = this.DockingMain;
            this.TabManagerMain.MdiParent = this;
            this.TabManagerMain.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.TabManagerMain_PageAdded);
            // 
            // ofdAccess
            // 
            this.ofdAccess.Filter = "Access File (*.mdb,*.accdb)|*.accdb;*.mdb|All Files (*.*)|*.*";
            this.ofdAccess.Title = "Select Access Database file";
            // 
            // MainFrm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.popupControlContainer2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.backstageViewControlMain);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainFrm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "NIC SQL Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.backstageViewControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DockingMain)).EndInit();
            this.backstageViewClientControlOpenAccess.ResumeLayout(false);
            this.backstageViewClientControlOpenAccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabManagerMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager TabManagerMain;
        private DevExpress.XtraBars.BarAndDockingController DockingMain;
        private DevExpress.XtraBars.BarButtonItem bbiDebugLogs;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDebug;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDebugLog;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControlMain;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControlOpenAccess;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItemOpenAccess;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageImport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupImportImportData;
        private DevExpress.XtraBars.BarButtonItem bbiImportBillingDetails;
        private DevExpress.XtraEditors.LabelControl lblAccessdbPath;
        private DevExpress.XtraEditors.SimpleButton btnOpendb;
        private System.Windows.Forms.OpenFileDialog ofdAccess;
        private DevExpress.XtraBars.BarButtonItem bbiImportProcedures;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCode;
        private DevExpress.XtraBars.BarButtonItem bbiImportQry;
        private DevExpress.XtraBars.BarButtonItem bbiImportExecute;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ExeribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiCustomerEditor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup dataRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiRouteEditor;
        private DevExpress.XtraBars.BarButtonItem bbiProductEditor;
        private DevExpress.XtraBars.BarButtonItem bbiFinalDataEditor;
        private DevExpress.XtraBars.BarButtonItem bbiQrysp_DistributionV1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQry;
        private DevExpress.XtraBars.BarSubItem bbiQryDistribution;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQry;

    }
}
