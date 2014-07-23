namespace DataCenter.Forms
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
            this.qryCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new DataCenter.DataSources.dsQueries();
            this.qryItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDataCenter = new DataCenter.DataSources.dsDataCenter();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DockingMain = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.siInfo = new DevExpress.XtraBars.BarStaticItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbiFileType = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIcons = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRole = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUserRole = new DevExpress.XtraBars.BarButtonItem();
            this.bbiServerOptionWizard = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUsers = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeletedItem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeletedCategory = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDebugLogs = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAppRole = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PrivRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageDebug = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDebugLog = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.qryItemsTableAdapter = new DataCenter.DataSources.dsQueriesTableAdapters.QryItemsTableAdapter();
            this.itemTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.ItemTableAdapter();
            this.qryCategoryTableAdapter = new DataCenter.DataSources.dsQueriesTableAdapters.QryCategoryTableAdapter();
            this.TabManagerMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qryCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
            this.popupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DockingMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabManagerMain)).BeginInit();
            this.SuspendLayout();
            // 
            // qryCategoryBindingSource
            // 
            this.qryCategoryBindingSource.DataMember = "QryCategory";
            this.qryCategoryBindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qryItemsBindingSource
            // 
            this.qryItemsBindingSource.DataMember = "QryItems";
            this.qryItemsBindingSource.DataSource = this.dsQueries;
            // 
            // dsDataCenter
            // 
            this.dsDataCenter.DataSetName = "dsDataCenter";
            this.dsDataCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
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
            this.bbiFileType,
            this.bbiIcons,
            this.bbiRole,
            this.bbiUserRole,
            this.bbiServerOptionWizard,
            this.bbiUsers,
            this.bbiDeletedItem,
            this.bbiDeletedCategory,
            this.bbiDebugLogs,
            this.bbiAppRole});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 72;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage,
            this.helpRibbonPage,
            this.ribbonPageDebug});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(1100, 144);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iHelp);
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
            this.popupControlContainer2.Location = new System.Drawing.Point(238, 289);
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
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.someLabelControl2);
            this.popupControlContainer1.Controls.Add(this.someLabelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(111, 197);
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
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "FileType.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Icons.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "RolePriv.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "UserRole.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Users.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Settings.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "DeletedItems.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "DeletedCategories.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Debuglog.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "AppRole.png");
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
            this.siStatus.Caption = "Some Status Info";
            this.siStatus.Id = 31;
            this.siStatus.Name = "siStatus";
            this.siStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // siInfo
            // 
            this.siInfo.Caption = "Some Info";
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
            // bbiFileType
            // 
            this.bbiFileType.Caption = "انواع الملفات";
            this.bbiFileType.Id = 62;
            this.bbiFileType.ImageIndex = 3;
            this.bbiFileType.LargeImageIndex = 3;
            this.bbiFileType.Name = "bbiFileType";
            this.bbiFileType.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiFileType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFileType_ItemClick);
            // 
            // bbiIcons
            // 
            this.bbiIcons.Caption = "ايكونات";
            this.bbiIcons.Id = 63;
            this.bbiIcons.ImageIndex = 4;
            this.bbiIcons.LargeImageIndex = 4;
            this.bbiIcons.Name = "bbiIcons";
            this.bbiIcons.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiIcons.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiIcons_ItemClick);
            // 
            // bbiRole
            // 
            this.bbiRole.Caption = "المجموعات";
            this.bbiRole.Id = 64;
            this.bbiRole.ImageIndex = 5;
            this.bbiRole.LargeImageIndex = 5;
            this.bbiRole.Name = "bbiRole";
            this.bbiRole.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRole_ItemClick);
            // 
            // bbiUserRole
            // 
            this.bbiUserRole.Caption = "مجموعات المستخدمين";
            this.bbiUserRole.Id = 65;
            this.bbiUserRole.ImageIndex = 6;
            this.bbiUserRole.LargeImageIndex = 6;
            this.bbiUserRole.Name = "bbiUserRole";
            this.bbiUserRole.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiUserRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUserRole_ItemClick);
            // 
            // bbiServerOptionWizard
            // 
            this.bbiServerOptionWizard.Caption = "خيارات البرنامج";
            this.bbiServerOptionWizard.Id = 66;
            this.bbiServerOptionWizard.ImageIndex = 8;
            this.bbiServerOptionWizard.LargeImageIndex = 8;
            this.bbiServerOptionWizard.Name = "bbiServerOptionWizard";
            this.bbiServerOptionWizard.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiServerOptionWizard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiServerOptionWizard_ItemClick);
            // 
            // bbiUsers
            // 
            this.bbiUsers.Caption = "المستخدميـــــن";
            this.bbiUsers.Id = 67;
            this.bbiUsers.ImageIndex = 7;
            this.bbiUsers.LargeImageIndex = 7;
            this.bbiUsers.Name = "bbiUsers";
            this.bbiUsers.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUsers_ItemClick);
            // 
            // bbiDeletedItem
            // 
            this.bbiDeletedItem.Caption = "الملفات المحزوفة";
            this.bbiDeletedItem.Id = 68;
            this.bbiDeletedItem.ImageIndex = 9;
            this.bbiDeletedItem.LargeImageIndex = 9;
            this.bbiDeletedItem.Name = "bbiDeletedItem";
            this.bbiDeletedItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiDeletedItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeletedItem_ItemClick);
            // 
            // bbiDeletedCategory
            // 
            this.bbiDeletedCategory.Caption = "المجلدات المحزوفة";
            this.bbiDeletedCategory.Id = 69;
            this.bbiDeletedCategory.ImageIndex = 10;
            this.bbiDeletedCategory.LargeImageIndex = 10;
            this.bbiDeletedCategory.Name = "bbiDeletedCategory";
            this.bbiDeletedCategory.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiDeletedCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeletedCategory_ItemClick);
            // 
            // bbiDebugLogs
            // 
            this.bbiDebugLogs.Caption = "Debug Log";
            this.bbiDebugLogs.Id = 70;
            this.bbiDebugLogs.ImageIndex = 11;
            this.bbiDebugLogs.LargeImageIndex = 11;
            this.bbiDebugLogs.Name = "bbiDebugLogs";
            this.bbiDebugLogs.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiDebugLogs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDebugLogs_ItemClick);
            // 
            // bbiAppRole
            // 
            this.bbiAppRole.Caption = "تفاصيل صلاحيات البرنامج";
            this.bbiAppRole.Id = 71;
            this.bbiAppRole.ImageIndex = 12;
            this.bbiAppRole.LargeImageIndex = 12;
            this.bbiAppRole.Name = "bbiAppRole";
            this.bbiAppRole.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiAppRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAppRole_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Info_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "FileType.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Icons.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "RolePriv.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "UserRole.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Users.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Settings.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "DeletedItems.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "DeletedCategories.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "Debuglog.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(12, "AppRole.png");
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileRibbonPageGroup,
            this.PrivRibbonPageGroup,
            this.skinsRibbonPageGroup,
            this.exitRibbonPageGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Home";
            // 
            // fileRibbonPageGroup
            // 
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiFileType);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiIcons);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiServerOptionWizard);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiDeletedItem);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiDeletedCategory);
            this.fileRibbonPageGroup.Name = "fileRibbonPageGroup";
            this.fileRibbonPageGroup.Text = "بيانات اساسية";
            // 
            // PrivRibbonPageGroup
            // 
            this.PrivRibbonPageGroup.ItemLinks.Add(this.bbiRole);
            this.PrivRibbonPageGroup.ItemLinks.Add(this.bbiUsers);
            this.PrivRibbonPageGroup.ItemLinks.Add(this.bbiUserRole);
            this.PrivRibbonPageGroup.ItemLinks.Add(this.bbiAppRole);
            this.PrivRibbonPageGroup.Name = "PrivRibbonPageGroup";
            this.PrivRibbonPageGroup.Text = "الصلاحيات";
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
            // qryItemsTableAdapter
            // 
            this.qryItemsTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // qryCategoryTableAdapter
            // 
            this.qryCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // TabManagerMain
            // 
            this.TabManagerMain.Controller = this.DockingMain;
            this.TabManagerMain.MdiParent = this;
            this.TabManagerMain.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.TabManagerMain_PageAdded);
            // 
            // MainFrm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.popupControlContainer2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainFrm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Data Center";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qryCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DockingMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabManagerMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileRibbonPageGroup;
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
        private DataSources.dsDataCenter dsDataCenter;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource qryItemsBindingSource;
        private DataSources.dsQueriesTableAdapters.QryItemsTableAdapter qryItemsTableAdapter;
        private DataSources.dsDataCenterTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource qryCategoryBindingSource;
        private DataSources.dsQueriesTableAdapters.QryCategoryTableAdapter qryCategoryTableAdapter;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager TabManagerMain;
        private DevExpress.XtraBars.BarAndDockingController DockingMain;
        private DevExpress.XtraBars.BarButtonItem bbiFileType;
        private DevExpress.XtraBars.BarButtonItem bbiIcons;
        private DevExpress.XtraBars.BarButtonItem bbiRole;
        private DevExpress.XtraBars.BarButtonItem bbiUserRole;
        private DevExpress.XtraBars.BarButtonItem bbiServerOptionWizard;
        private DevExpress.XtraBars.BarButtonItem bbiUsers;
        private DevExpress.XtraBars.BarButtonItem bbiDeletedItem;
        private DevExpress.XtraBars.BarButtonItem bbiDeletedCategory;
        private DevExpress.XtraBars.BarButtonItem bbiDebugLogs;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDebug;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDebugLog;
        private DevExpress.XtraBars.BarButtonItem bbiAppRole;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PrivRibbonPageGroup;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;

    }
}
