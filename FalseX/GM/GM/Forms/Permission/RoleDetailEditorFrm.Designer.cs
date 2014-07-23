namespace GM.Forms.Code
{
    partial class RoleDetailEditorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleDetailEditorFrm));
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiLueRole = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemGridLookUpEditRole = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGM = new GM.DataSources.dsGM();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.userRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new GM.DataSources.dsGMTableAdapters.RoleTableAdapter();
            this.userRoleTableAdapter = new GM.DataSources.dsGMTableAdapters.UserRoleTableAdapter();
            this.roleDetailTableAdapter = new GM.DataSources.dsGMTableAdapters.RoleDetailTableAdapter();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.siInfo = new DevExpress.XtraBars.BarStaticItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbiUser = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDebugLogs = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGovEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAreaEditor = new DevExpress.XtraBars.BarButtonItem();
            this.biiTraderEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPlumberEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiItemEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEmployeeEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBillEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiQry001 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiQry002 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiQry003 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiQry004 = new DevExpress.XtraBars.BarButtonItem();
            this.bbXRep01 = new DevExpress.XtraBars.BarButtonItem();
            this.bbXRep02 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRole = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUserRoleEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRoleDetailEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPasswordChanger = new DevExpress.XtraBars.BarButtonItem();
            this.bbXRep03 = new DevExpress.XtraBars.BarButtonItem();
            this.bbXRep04 = new DevExpress.XtraBars.BarButtonItem();
            this.bbXRep05 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.BasicDataRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AdvDataribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQry = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupQry = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupReport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageRoles = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PrivRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageDebug = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDebugLog = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiLueRole});
            this.barManagerMain.MaxItemId = 3;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditRole});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLueRole)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiLueRole
            // 
            this.bbiLueRole.Caption = "User";
            this.bbiLueRole.Edit = this.repositoryItemGridLookUpEditRole;
            this.bbiLueRole.Id = 2;
            this.bbiLueRole.Name = "bbiLueRole";
            this.bbiLueRole.Width = 150;
            this.bbiLueRole.EditValueChanged += new System.EventHandler(this.bbiLueRole_EditValueChanged);
            // 
            // repositoryItemGridLookUpEditRole
            // 
            this.repositoryItemGridLookUpEditRole.AutoHeight = false;
            this.repositoryItemGridLookUpEditRole.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditRole.DataSource = this.roleBindingSource;
            this.repositoryItemGridLookUpEditRole.DisplayMember = "RoleName";
            this.repositoryItemGridLookUpEditRole.Name = "repositoryItemGridLookUpEditRole";
            this.repositoryItemGridLookUpEditRole.NullText = "";
            this.repositoryItemGridLookUpEditRole.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditRole.ValueMember = "RoleId";
            this.repositoryItemGridLookUpEditRole.View = this.gridView1;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.dsGM;
            // 
            // dsGM
            // 
            this.dsGM.DataSetName = "dsGM";
            this.dsGM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleId,
            this.colRoleName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colRoleId
            // 
            this.colRoleId.AppearanceCell.Options.UseTextOptions = true;
            this.colRoleId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleId.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleId.FieldName = "RoleId";
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.Visible = true;
            this.colRoleId.VisibleIndex = 0;
            // 
            // colRoleName
            // 
            this.colRoleName.AppearanceCell.Options.UseTextOptions = true;
            this.colRoleName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(784, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 181);
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 152);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(784, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 152);
            // 
            // userRoleBindingSource
            // 
            this.userRoleBindingSource.DataMember = "UserRole";
            this.userRoleBindingSource.DataSource = this.dsGM;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // userRoleTableAdapter
            // 
            this.userRoleTableAdapter.ClearBeforeFill = true;
            // 
            // roleDetailTableAdapter
            // 
            this.roleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonText = null;
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
            this.bbiUser,
            this.bbiDebugLogs,
            this.bbiGovEditor,
            this.bbiAreaEditor,
            this.biiTraderEditor,
            this.bbiPlumberEditor,
            this.bbiItemEditor,
            this.bbiEmployeeEditor,
            this.bbiBillEditor,
            this.bbiQry001,
            this.bbiQry002,
            this.bbiQry003,
            this.bbiQry004,
            this.bbXRep01,
            this.bbXRep02,
            this.bbiRole,
            this.bbiUserRoleEditor,
            this.bbiRoleDetailEditor,
            this.bbiPasswordChanger,
            this.bbXRep03,
            this.bbXRep04,
            this.bbXRep05});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 29);
            this.ribbonControl.MaxItemId = 4;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.PageHeaderItemLinks.Add(this.bbiPasswordChanger);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage,
            this.ribbonPageQry,
            this.ribbonPageReports,
            this.ribbonPageRoles,
            this.helpRibbonPage,
            this.ribbonPageDebug});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(784, 142);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iHelp);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.bbiPasswordChanger);
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
            this.ribbonImageCollection.Images.SetKeyName(11, "Reports16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "BranchEditor.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Customers.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "Employee.png");
            this.ribbonImageCollection.Images.SetKeyName(15, "Gov.png");
            this.ribbonImageCollection.Images.SetKeyName(16, "ImportData.png");
            this.ribbonImageCollection.Images.SetKeyName(17, "Item.png");
            this.ribbonImageCollection.Images.SetKeyName(18, "JobEditor.png");
            this.ribbonImageCollection.Images.SetKeyName(19, "MenuOrder16.png");
            this.ribbonImageCollection.Images.SetKeyName(20, "MenuSize.png");
            this.ribbonImageCollection.Images.SetKeyName(21, "MenuTheme.png");
            this.ribbonImageCollection.Images.SetKeyName(22, "nestle.png");
            this.ribbonImageCollection.Images.SetKeyName(23, "ProductBaseEditor.png");
            this.ribbonImageCollection.Images.SetKeyName(24, "ProductEditor.png");
            this.ribbonImageCollection.Images.SetKeyName(25, "Qry16.png");
            this.ribbonImageCollection.Images.SetKeyName(26, "Role.png");
            this.ribbonImageCollection.Images.SetKeyName(27, "RoleDetail.png");
            this.ribbonImageCollection.Images.SetKeyName(28, "Trader.png");
            this.ribbonImageCollection.Images.SetKeyName(29, "User.png");
            this.ribbonImageCollection.Images.SetKeyName(30, "UserRole.png");
            this.ribbonImageCollection.Images.SetKeyName(31, "AreaEditor.png");
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
            // bbiUser
            // 
            this.bbiUser.Caption = "User";
            this.bbiUser.Id = 67;
            this.bbiUser.ImageIndex = 29;
            this.bbiUser.LargeImageIndex = 29;
            this.bbiUser.Name = "bbiUser";
            this.bbiUser.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiDebugLogs
            // 
            this.bbiDebugLogs.Caption = "Debug Log";
            this.bbiDebugLogs.Id = 70;
            this.bbiDebugLogs.ImageIndex = 7;
            this.bbiDebugLogs.LargeImageIndex = 7;
            this.bbiDebugLogs.Name = "bbiDebugLogs";
            this.bbiDebugLogs.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiGovEditor
            // 
            this.bbiGovEditor.Caption = "Gov Editor";
            this.bbiGovEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiGovEditor.Id = 1;
            this.bbiGovEditor.ImageIndex = 15;
            this.bbiGovEditor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiGovEditor.LargeGlyph")));
            this.bbiGovEditor.LargeImageIndex = 15;
            this.bbiGovEditor.Name = "bbiGovEditor";
            this.bbiGovEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiAreaEditor
            // 
            this.bbiAreaEditor.Caption = "Area Editor";
            this.bbiAreaEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiAreaEditor.Id = 2;
            this.bbiAreaEditor.ImageIndex = 31;
            this.bbiAreaEditor.LargeImageIndex = 31;
            this.bbiAreaEditor.Name = "bbiAreaEditor";
            this.bbiAreaEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // biiTraderEditor
            // 
            this.biiTraderEditor.Caption = "Trader Editor";
            this.biiTraderEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biiTraderEditor.Id = 3;
            this.biiTraderEditor.ImageIndex = 28;
            this.biiTraderEditor.LargeImageIndex = 28;
            this.biiTraderEditor.Name = "biiTraderEditor";
            this.biiTraderEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiPlumberEditor
            // 
            this.bbiPlumberEditor.Caption = "Plumber Editor";
            this.bbiPlumberEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPlumberEditor.Id = 4;
            this.bbiPlumberEditor.ImageIndex = 18;
            this.bbiPlumberEditor.LargeImageIndex = 18;
            this.bbiPlumberEditor.Name = "bbiPlumberEditor";
            this.bbiPlumberEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiItemEditor
            // 
            this.bbiItemEditor.Caption = "Item Editor";
            this.bbiItemEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiItemEditor.Id = 5;
            this.bbiItemEditor.ImageIndex = 17;
            this.bbiItemEditor.LargeImageIndex = 17;
            this.bbiItemEditor.Name = "bbiItemEditor";
            this.bbiItemEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiEmployeeEditor
            // 
            this.bbiEmployeeEditor.Caption = "Employee Editor";
            this.bbiEmployeeEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiEmployeeEditor.Id = 7;
            this.bbiEmployeeEditor.ImageIndex = 14;
            this.bbiEmployeeEditor.LargeImageIndex = 14;
            this.bbiEmployeeEditor.Name = "bbiEmployeeEditor";
            this.bbiEmployeeEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiBillEditor
            // 
            this.bbiBillEditor.Caption = "Bills";
            this.bbiBillEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiBillEditor.Id = 10;
            this.bbiBillEditor.ImageIndex = 19;
            this.bbiBillEditor.LargeImageIndex = 19;
            this.bbiBillEditor.Name = "bbiBillEditor";
            this.bbiBillEditor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbiQry001
            // 
            this.bbiQry001.Caption = "General Query Pivot";
            this.bbiQry001.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiQry001.Id = 11;
            this.bbiQry001.ImageIndex = 25;
            this.bbiQry001.LargeImageIndex = 25;
            this.bbiQry001.Name = "bbiQry001";
            this.bbiQry001.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiQry002
            // 
            this.bbiQry002.Caption = "General Query";
            this.bbiQry002.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiQry002.Id = 12;
            this.bbiQry002.ImageIndex = 25;
            this.bbiQry002.LargeImageIndex = 25;
            this.bbiQry002.Name = "bbiQry002";
            this.bbiQry002.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiQry003
            // 
            this.bbiQry003.Caption = "General Bill Query Pivot";
            this.bbiQry003.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiQry003.Id = 13;
            this.bbiQry003.ImageIndex = 25;
            this.bbiQry003.LargeImageIndex = 25;
            this.bbiQry003.Name = "bbiQry003";
            this.bbiQry003.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiQry004
            // 
            this.bbiQry004.Caption = "General Bill Query";
            this.bbiQry004.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiQry004.Id = 14;
            this.bbiQry004.ImageIndex = 25;
            this.bbiQry004.LargeImageIndex = 25;
            this.bbiQry004.Name = "bbiQry004";
            this.bbiQry004.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbXRep01
            // 
            this.bbXRep01.Caption = "تقرير سباكين محافظة";
            this.bbXRep01.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbXRep01.Id = 15;
            this.bbXRep01.ImageIndex = 11;
            this.bbXRep01.LargeImageIndex = 11;
            this.bbXRep01.Name = "bbXRep01";
            this.bbXRep01.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbXRep02
            // 
            this.bbXRep02.Caption = "تقرير سباكين منطقة";
            this.bbXRep02.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbXRep02.Id = 16;
            this.bbXRep02.ImageIndex = 11;
            this.bbXRep02.LargeImageIndex = 11;
            this.bbXRep02.Name = "bbXRep02";
            this.bbXRep02.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiRole
            // 
            this.bbiRole.Caption = "Role";
            this.bbiRole.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiRole.Id = 17;
            this.bbiRole.ImageIndex = 26;
            this.bbiRole.LargeImageIndex = 26;
            this.bbiRole.Name = "bbiRole";
            this.bbiRole.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiUserRoleEditor
            // 
            this.bbiUserRoleEditor.Caption = "User Role";
            this.bbiUserRoleEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiUserRoleEditor.Id = 18;
            this.bbiUserRoleEditor.ImageIndex = 30;
            this.bbiUserRoleEditor.LargeImageIndex = 30;
            this.bbiUserRoleEditor.Name = "bbiUserRoleEditor";
            this.bbiUserRoleEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiRoleDetailEditor
            // 
            this.bbiRoleDetailEditor.Caption = "Role Detail";
            this.bbiRoleDetailEditor.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiRoleDetailEditor.Id = 19;
            this.bbiRoleDetailEditor.ImageIndex = 27;
            this.bbiRoleDetailEditor.LargeImageIndex = 27;
            this.bbiRoleDetailEditor.Name = "bbiRoleDetailEditor";
            this.bbiRoleDetailEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbiPasswordChanger
            // 
            this.bbiPasswordChanger.Caption = "Change Username/Password";
            this.bbiPasswordChanger.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPasswordChanger.Id = 20;
            this.bbiPasswordChanger.ImageIndex = 5;
            this.bbiPasswordChanger.LargeImageIndex = 5;
            this.bbiPasswordChanger.Name = "bbiPasswordChanger";
            // 
            // bbXRep03
            // 
            this.bbXRep03.Caption = "تقرير سباكين تاجر";
            this.bbXRep03.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbXRep03.Id = 1;
            this.bbXRep03.ImageIndex = 11;
            this.bbXRep03.LargeImageIndex = 11;
            this.bbXRep03.Name = "bbXRep03";
            this.bbXRep03.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbXRep04
            // 
            this.bbXRep04.Caption = "تقرير سباكين مندوب";
            this.bbXRep04.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbXRep04.Id = 2;
            this.bbXRep04.ImageIndex = 11;
            this.bbXRep04.LargeImageIndex = 11;
            this.bbXRep04.Name = "bbXRep04";
            this.bbXRep04.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbXRep05
            // 
            this.bbXRep05.Caption = "تقرير معاينات سباك";
            this.bbXRep05.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbXRep05.Id = 3;
            this.bbXRep05.ImageIndex = 11;
            this.bbXRep05.LargeImageIndex = 11;
            this.bbXRep05.Name = "bbXRep05";
            this.bbXRep05.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
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
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "Reports32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(12, "BranchEditor.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(13, "Customers.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(14, "Employee.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(15, "Gov.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(16, "ImportData.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(17, "Item.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(18, "JobEditor.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(19, "MenuOrder32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(20, "MenuSize.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(21, "MenuTheme.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(22, "nestle.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(23, "ProductBaseEditor.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(24, "ProductEditor.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(25, "Qry32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(26, "Role.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(27, "RoleDetail.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(28, "Trader.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(29, "User.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(30, "UserRole.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(31, "AreaEditor.png");
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.BasicDataRibbonPageGroup,
            this.AdvDataribbonPageGroup,
            this.skinsRibbonPageGroup,
            this.exitRibbonPageGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Home";
            // 
            // BasicDataRibbonPageGroup
            // 
            this.BasicDataRibbonPageGroup.ItemLinks.Add(this.bbiGovEditor);
            this.BasicDataRibbonPageGroup.ItemLinks.Add(this.bbiAreaEditor);
            this.BasicDataRibbonPageGroup.ItemLinks.Add(this.bbiEmployeeEditor);
            this.BasicDataRibbonPageGroup.ItemLinks.Add(this.biiTraderEditor);
            this.BasicDataRibbonPageGroup.ItemLinks.Add(this.bbiPlumberEditor);
            this.BasicDataRibbonPageGroup.ItemLinks.Add(this.bbiItemEditor);
            this.BasicDataRibbonPageGroup.Name = "BasicDataRibbonPageGroup";
            this.BasicDataRibbonPageGroup.Text = "Basic Data";
            // 
            // AdvDataribbonPageGroup
            // 
            this.AdvDataribbonPageGroup.ItemLinks.Add(this.bbiBillEditor);
            this.AdvDataribbonPageGroup.Name = "AdvDataribbonPageGroup";
            this.AdvDataribbonPageGroup.Text = "Advanced Data";
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
            // ribbonPageQry
            // 
            this.ribbonPageQry.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupQry});
            this.ribbonPageQry.Name = "ribbonPageQry";
            this.ribbonPageQry.Text = "Queries";
            // 
            // ribbonPageGroupQry
            // 
            this.ribbonPageGroupQry.ItemLinks.Add(this.bbiQry001);
            this.ribbonPageGroupQry.ItemLinks.Add(this.bbiQry002);
            this.ribbonPageGroupQry.ItemLinks.Add(this.bbiQry003);
            this.ribbonPageGroupQry.ItemLinks.Add(this.bbiQry004);
            this.ribbonPageGroupQry.Name = "ribbonPageGroupQry";
            this.ribbonPageGroupQry.Text = "Queries";
            // 
            // ribbonPageReports
            // 
            this.ribbonPageReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupReport});
            this.ribbonPageReports.Name = "ribbonPageReports";
            this.ribbonPageReports.Text = "Reports";
            // 
            // ribbonPageGroupReport
            // 
            this.ribbonPageGroupReport.ItemLinks.Add(this.bbXRep01);
            this.ribbonPageGroupReport.ItemLinks.Add(this.bbXRep02);
            this.ribbonPageGroupReport.ItemLinks.Add(this.bbXRep03);
            this.ribbonPageGroupReport.ItemLinks.Add(this.bbXRep04);
            this.ribbonPageGroupReport.ItemLinks.Add(this.bbXRep05);
            this.ribbonPageGroupReport.Name = "ribbonPageGroupReport";
            this.ribbonPageGroupReport.Text = "Report";
            // 
            // ribbonPageRoles
            // 
            this.ribbonPageRoles.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PrivRibbonPageGroup});
            this.ribbonPageRoles.Name = "ribbonPageRoles";
            this.ribbonPageRoles.Text = "Roles";
            // 
            // PrivRibbonPageGroup
            // 
            this.PrivRibbonPageGroup.ItemLinks.Add(this.bbiUser);
            this.PrivRibbonPageGroup.ItemLinks.Add(this.bbiRole);
            this.PrivRibbonPageGroup.ItemLinks.Add(this.bbiUserRoleEditor);
            this.PrivRibbonPageGroup.ItemLinks.Add(this.bbiRoleDetailEditor);
            this.PrivRibbonPageGroup.Name = "PrivRibbonPageGroup";
            this.PrivRibbonPageGroup.Text = "Roles";
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
            // RoleDetailEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 181);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = global::GM.Properties.Resources.RoleDetail;
            this.Name = "RoleDetailEditorFrm";
            this.Text = "Role Detail Editor";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DataSources.dsGM dsGM;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DataSources.dsGMTableAdapters.RoleTableAdapter roleTableAdapter;
        private DevExpress.XtraBars.BarEditItem bbiLueRole;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource userRoleBindingSource;
        private DataSources.dsGMTableAdapters.UserRoleTableAdapter userRoleTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleId;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DataSources.dsGMTableAdapters.RoleDetailTableAdapter roleDetailTableAdapter;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.BarButtonItem bbiUser;
        private DevExpress.XtraBars.BarButtonItem bbiDebugLogs;
        private DevExpress.XtraBars.BarButtonItem bbiGovEditor;
        private DevExpress.XtraBars.BarButtonItem bbiAreaEditor;
        private DevExpress.XtraBars.BarButtonItem biiTraderEditor;
        private DevExpress.XtraBars.BarButtonItem bbiPlumberEditor;
        private DevExpress.XtraBars.BarButtonItem bbiItemEditor;
        private DevExpress.XtraBars.BarButtonItem bbiEmployeeEditor;
        private DevExpress.XtraBars.BarButtonItem bbiBillEditor;
        private DevExpress.XtraBars.BarButtonItem bbiQry001;
        private DevExpress.XtraBars.BarButtonItem bbiQry002;
        private DevExpress.XtraBars.BarButtonItem bbiQry003;
        private DevExpress.XtraBars.BarButtonItem bbiQry004;
        private DevExpress.XtraBars.BarButtonItem bbXRep01;
        private DevExpress.XtraBars.BarButtonItem bbXRep02;
        private DevExpress.XtraBars.BarButtonItem bbiRole;
        private DevExpress.XtraBars.BarButtonItem bbiUserRoleEditor;
        private DevExpress.XtraBars.BarButtonItem bbiRoleDetailEditor;
        private DevExpress.XtraBars.BarButtonItem bbiPasswordChanger;
        private DevExpress.XtraBars.BarButtonItem bbXRep03;
        private DevExpress.XtraBars.BarButtonItem bbXRep04;
        private DevExpress.XtraBars.BarButtonItem bbXRep05;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BasicDataRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup AdvDataribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQry;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQry;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageRoles;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PrivRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDebug;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDebugLog;
    }
}