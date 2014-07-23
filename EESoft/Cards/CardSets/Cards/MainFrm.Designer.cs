namespace CardSets
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
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.mailGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.StudentItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.navbarImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.memberdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCards = new CardSets.DataSources.dsCards();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colchk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFASL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCQueryOptions = new DevExpress.XtraEditors.GroupControl();
            this.btnPrintEditor = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mFile = new DevExpress.XtraBars.BarSubItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.mHelp = new DevExpress.XtraBars.BarSubItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.colFASL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memberdataTableAdapter = new CardSets.DataSources.dsCardsTableAdapters.memberdataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCQueryOptions)).BeginInit();
            this.GCQueryOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 22);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl.Panel2.Controls.Add(this.GCQueryOptions);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(950, 528);
            this.splitContainerControl.SplitterPosition = 155;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.mailGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.mailGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.StudentItem});
            this.navBarControl.LargeImages = this.navbarImageListLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 155;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(155, 516);
            this.navBarControl.SmallImages = this.navbarImageList;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl1";
            // 
            // mailGroup
            // 
            this.mailGroup.Caption = "الاعضاء";
            this.mailGroup.Expanded = true;
            this.mailGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.StudentItem)});
            this.mailGroup.LargeImageIndex = 0;
            this.mailGroup.Name = "mailGroup";
            // 
            // StudentItem
            // 
            this.StudentItem.Caption = "عرض بيانات الاعضاء";
            this.StudentItem.Name = "StudentItem";
            this.StudentItem.SmallImageIndex = 0;
            this.StudentItem.ItemChanged += new System.EventHandler(this.StudentItem_ItemChanged);
            // 
            // navbarImageListLarge
            // 
            this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
            this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageListLarge.Images.SetKeyName(0, "student.png");
            this.navbarImageListLarge.Images.SetKeyName(1, "Organizer_32x32.png");
            // 
            // navbarImageList
            // 
            this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
            this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageList.Images.SetKeyName(0, "Drafts_16x16.png");
            this.navbarImageList.Images.SetKeyName(1, "Inbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(2, "Outbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageList.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageList.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.gridControlMain);
            this.groupControl2.Location = new System.Drawing.Point(4, 66);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(771, 444);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "البيانات";
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.memberdataBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(2, 21);
            this.gridControlMain.MainView = this.gridViewData;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlMain.Size = new System.Drawing.Size(767, 421);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // memberdataBindingSource
            // 
            this.memberdataBindingSource.DataMember = "memberdata";
            this.memberdataBindingSource.DataSource = this.dsCards;
            // 
            // dsCards
            // 
            this.dsCards.DataSetName = "dsCards";
            this.dsCards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colchk,
            this.colID,
            this.colSNAME,
            this.colSAF,
            this.colFASL,
            this.colPHONE,
            this.colUSERNAME,
            this.colIMG});
            this.gridViewData.GridControl = this.gridControlMain;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            // 
            // colchk
            // 
            this.colchk.AppearanceCell.Options.UseTextOptions = true;
            this.colchk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colchk.AppearanceHeader.Options.UseTextOptions = true;
            this.colchk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colchk.Caption = "اختر";
            this.colchk.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colchk.FieldName = "chk";
            this.colchk.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colchk.Name = "colchk";
            this.colchk.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colchk.Visible = true;
            this.colchk.VisibleIndex = 0;
            this.colchk.Width = 47;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "ID";
            this.colID.FieldName = "memberid";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 46;
            // 
            // colSNAME
            // 
            this.colSNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSNAME.Caption = "الاسم";
            this.colSNAME.FieldName = "membername";
            this.colSNAME.Name = "colSNAME";
            this.colSNAME.OptionsColumn.AllowEdit = false;
            this.colSNAME.Visible = true;
            this.colSNAME.VisibleIndex = 2;
            this.colSNAME.Width = 206;
            // 
            // colSAF
            // 
            this.colSAF.AppearanceCell.Options.UseTextOptions = true;
            this.colSAF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF.AppearanceHeader.Options.UseTextOptions = true;
            this.colSAF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF.Caption = "الفئة";
            this.colSAF.FieldName = "titleName";
            this.colSAF.Name = "colSAF";
            this.colSAF.OptionsColumn.AllowEdit = false;
            this.colSAF.Visible = true;
            this.colSAF.VisibleIndex = 3;
            this.colSAF.Width = 70;
            // 
            // colFASL
            // 
            this.colFASL.AppearanceCell.Options.UseTextOptions = true;
            this.colFASL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL.AppearanceHeader.Options.UseTextOptions = true;
            this.colFASL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL.Caption = "الصفة النقابية";
            this.colFASL.FieldName = "sefaName";
            this.colFASL.Name = "colFASL";
            this.colFASL.OptionsColumn.AllowEdit = false;
            this.colFASL.Visible = true;
            this.colFASL.VisibleIndex = 4;
            this.colFASL.Width = 91;
            // 
            // colPHONE
            // 
            this.colPHONE.AppearanceCell.Options.UseTextOptions = true;
            this.colPHONE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.Caption = "الفرعية";
            this.colPHONE.FieldName = "LagnaName";
            this.colPHONE.Name = "colPHONE";
            this.colPHONE.OptionsColumn.AllowEdit = false;
            this.colPHONE.Visible = true;
            this.colPHONE.VisibleIndex = 5;
            this.colPHONE.Width = 85;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.Caption = "اللجنة";
            this.colUSERNAME.FieldName = "subcommite";
            this.colUSERNAME.Name = "colUSERNAME";
            this.colUSERNAME.OptionsColumn.AllowEdit = false;
            this.colUSERNAME.Visible = true;
            this.colUSERNAME.VisibleIndex = 6;
            this.colUSERNAME.Width = 104;
            // 
            // colIMG
            // 
            this.colIMG.AppearanceCell.Options.UseTextOptions = true;
            this.colIMG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIMG.AppearanceHeader.Options.UseTextOptions = true;
            this.colIMG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIMG.Caption = "الصورة";
            this.colIMG.FieldName = "imgpath";
            this.colIMG.Name = "colIMG";
            this.colIMG.OptionsColumn.AllowEdit = false;
            this.colIMG.Visible = true;
            this.colIMG.VisibleIndex = 7;
            this.colIMG.Width = 87;
            // 
            // GCQueryOptions
            // 
            this.GCQueryOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCQueryOptions.AppearanceCaption.Options.UseTextOptions = true;
            this.GCQueryOptions.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCQueryOptions.Controls.Add(this.btnPrintEditor);
            this.GCQueryOptions.Controls.Add(this.btnPrint2);
            this.GCQueryOptions.Controls.Add(this.btnPrint);
            this.GCQueryOptions.Location = new System.Drawing.Point(1, 3);
            this.GCQueryOptions.Name = "GCQueryOptions";
            this.GCQueryOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GCQueryOptions.Size = new System.Drawing.Size(771, 57);
            this.GCQueryOptions.TabIndex = 1;
            this.GCQueryOptions.Text = "خيارات";
            // 
            // btnPrintEditor
            // 
            this.btnPrintEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintEditor.Location = new System.Drawing.Point(304, 27);
            this.btnPrintEditor.Name = "btnPrintEditor";
            this.btnPrintEditor.Size = new System.Drawing.Size(163, 23);
            this.btnPrintEditor.TabIndex = 2;
            this.btnPrintEditor.Text = "تعديل ورقة الطباعه";
            this.btnPrintEditor.Visible = false;
            this.btnPrintEditor.Click += new System.EventHandler(this.btnPrintEditor_Click);
            // 
            // btnPrint2
            // 
            this.btnPrint2.Location = new System.Drawing.Point(5, 27);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(163, 23);
            this.btnPrint2.TabIndex = 2;
            this.btnPrint2.Text = "مجلس ادارة النقابة العامة";
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(603, 27);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "هيئة مكتب النقابة العامة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mFile,
            this.barButtonItem2,
            this.iExit,
            this.mHelp,
            this.iAbout});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 12;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mHelp)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // mFile
            // 
            this.mFile.Caption = "&File";
            this.mFile.Id = 0;
            this.mFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit)});
            this.mFile.Name = "mFile";
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.Id = 9;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // mHelp
            // 
            this.mHelp.Caption = "&Help";
            this.mHelp.Id = 10;
            this.mHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout)});
            this.mHelp.Name = "mHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.Id = 11;
            this.iAbout.Name = "iAbout";
            this.iAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAbout_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(950, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Size = new System.Drawing.Size(950, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 528);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(950, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 528);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Open";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // colFASL1
            // 
            this.colFASL1.AppearanceCell.Options.UseTextOptions = true;
            this.colFASL1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL1.AppearanceHeader.Options.UseTextOptions = true;
            this.colFASL1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL1.Caption = "اسم الفصل";
            this.colFASL1.FieldName = "FASL";
            this.colFASL1.Name = "colFASL1";
            this.colFASL1.Visible = true;
            this.colFASL1.VisibleIndex = 0;
            // 
            // memberdataTableAdapter
            // 
            this.memberdataTableAdapter.ClearBeforeFill = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "الكارنيهات";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCQueryOptions)).EndInit();
            this.GCQueryOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarSubItem mHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup mailGroup;
        private DevExpress.XtraNavBar.NavBarItem StudentItem;
        private System.Windows.Forms.ImageList navbarImageList;
        private System.Windows.Forms.ImageList navbarImageListLarge;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSAF;
        private DevExpress.XtraGrid.Columns.GridColumn colFASL;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colIMG;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl GCQueryOptions;
        private DevExpress.XtraGrid.Columns.GridColumn colFASL1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnPrintEditor;
        private DataSources.dsCards dsCards;
        private System.Windows.Forms.BindingSource memberdataBindingSource;
        private DataSources.dsCardsTableAdapters.memberdataTableAdapter memberdataTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colchk;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnPrint2;

    }
}
