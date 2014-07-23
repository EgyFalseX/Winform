namespace Cards
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
            this.dATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCards = new Cards.DataSources.dsCards();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFASL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCQueryOptions = new DevExpress.XtraEditors.GroupControl();
            this.btnPrintEditor = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetData = new DevExpress.XtraEditors.SimpleButton();
            this.LUEFasl = new DevExpress.XtraEditors.GridLookUpEdit();
            this.fASLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFASL2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LUESaf = new DevExpress.XtraEditors.GridLookUpEdit();
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
            this.safBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSAF1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dATATableAdapter = new Cards.DataSources.dsCardsTableAdapters.DATATableAdapter();
            this.safTableAdapter = new Cards.DataSources.dsCardsTableAdapters.SafTableAdapter();
            this.fASLTableAdapter = new Cards.DataSources.dsCardsTableAdapters.FASLTableAdapter();
            this.colFASL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCQueryOptions)).BeginInit();
            this.GCQueryOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEFasl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fASLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESaf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
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
            this.splitContainerControl.SplitterPosition = 165;
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
            this.navBarControl.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(165, 516);
            this.navBarControl.SmallImages = this.navbarImageList;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl1";
            // 
            // mailGroup
            // 
            this.mailGroup.Caption = "الطلاب";
            this.mailGroup.Expanded = true;
            this.mailGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.StudentItem)});
            this.mailGroup.LargeImageIndex = 0;
            this.mailGroup.Name = "mailGroup";
            // 
            // StudentItem
            // 
            this.StudentItem.Caption = "عرض بيانات الطلاب";
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
            this.groupControl2.Location = new System.Drawing.Point(4, 109);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(761, 401);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "البيانات";
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.dATABindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(2, 21);
            this.gridControlMain.MainView = this.gridViewData;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(757, 378);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // dATABindingSource
            // 
            this.dATABindingSource.DataMember = "DATA";
            this.dATABindingSource.DataSource = this.dsCards;
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
            this.colID,
            this.colSNAME,
            this.colSAF,
            this.colFASL,
            this.colPHONE,
            this.colUSERNAME,
            this.colPASSWORD,
            this.colIMG,
            this.colEdara,
            this.colGov});
            this.gridViewData.GridControl = this.gridControlMain;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 55;
            // 
            // colSNAME
            // 
            this.colSNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSNAME.Caption = "الاسم";
            this.colSNAME.FieldName = "SNAME";
            this.colSNAME.Name = "colSNAME";
            this.colSNAME.Visible = true;
            this.colSNAME.VisibleIndex = 1;
            this.colSNAME.Width = 206;
            // 
            // colSAF
            // 
            this.colSAF.AppearanceCell.Options.UseTextOptions = true;
            this.colSAF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF.AppearanceHeader.Options.UseTextOptions = true;
            this.colSAF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF.Caption = "الصف";
            this.colSAF.FieldName = "SAF";
            this.colSAF.Name = "colSAF";
            this.colSAF.Visible = true;
            this.colSAF.VisibleIndex = 2;
            this.colSAF.Width = 70;
            // 
            // colFASL
            // 
            this.colFASL.AppearanceCell.Options.UseTextOptions = true;
            this.colFASL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL.AppearanceHeader.Options.UseTextOptions = true;
            this.colFASL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL.Caption = "الفصل";
            this.colFASL.FieldName = "FASL";
            this.colFASL.Name = "colFASL";
            this.colFASL.Visible = true;
            this.colFASL.VisibleIndex = 3;
            this.colFASL.Width = 52;
            // 
            // colPHONE
            // 
            this.colPHONE.AppearanceCell.Options.UseTextOptions = true;
            this.colPHONE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.Caption = "التليفون";
            this.colPHONE.FieldName = "PHONE";
            this.colPHONE.Name = "colPHONE";
            this.colPHONE.Visible = true;
            this.colPHONE.VisibleIndex = 4;
            this.colPHONE.Width = 56;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.Caption = "اسم المستخدم";
            this.colUSERNAME.FieldName = "USERNAME";
            this.colUSERNAME.Name = "colUSERNAME";
            this.colUSERNAME.Visible = true;
            this.colUSERNAME.VisibleIndex = 5;
            this.colUSERNAME.Width = 104;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.AppearanceCell.Options.UseTextOptions = true;
            this.colPASSWORD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPASSWORD.AppearanceHeader.Options.UseTextOptions = true;
            this.colPASSWORD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPASSWORD.Caption = "الرقم السري";
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 6;
            this.colPASSWORD.Width = 77;
            // 
            // colIMG
            // 
            this.colIMG.AppearanceCell.Options.UseTextOptions = true;
            this.colIMG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIMG.AppearanceHeader.Options.UseTextOptions = true;
            this.colIMG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIMG.FieldName = "IMG";
            this.colIMG.Name = "colIMG";
            // 
            // colEdara
            // 
            this.colEdara.AppearanceCell.Options.UseTextOptions = true;
            this.colEdara.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdara.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdara.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdara.Caption = "الادارة";
            this.colEdara.FieldName = "Edara";
            this.colEdara.Name = "colEdara";
            this.colEdara.Visible = true;
            this.colEdara.VisibleIndex = 7;
            // 
            // colGov
            // 
            this.colGov.AppearanceCell.Options.UseTextOptions = true;
            this.colGov.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGov.AppearanceHeader.Options.UseTextOptions = true;
            this.colGov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGov.Caption = "المحافظه";
            this.colGov.FieldName = "Gov";
            this.colGov.Name = "colGov";
            this.colGov.Visible = true;
            this.colGov.VisibleIndex = 8;
            // 
            // GCQueryOptions
            // 
            this.GCQueryOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCQueryOptions.AppearanceCaption.Options.UseTextOptions = true;
            this.GCQueryOptions.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCQueryOptions.Controls.Add(this.btnPrintEditor);
            this.GCQueryOptions.Controls.Add(this.btnPrint);
            this.GCQueryOptions.Controls.Add(this.btnGetData);
            this.GCQueryOptions.Controls.Add(this.LUEFasl);
            this.GCQueryOptions.Controls.Add(this.LUESaf);
            this.GCQueryOptions.Controls.Add(this.labelControl2);
            this.GCQueryOptions.Controls.Add(this.labelControl1);
            this.GCQueryOptions.Location = new System.Drawing.Point(1, 3);
            this.GCQueryOptions.Name = "GCQueryOptions";
            this.GCQueryOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GCQueryOptions.Size = new System.Drawing.Size(761, 100);
            this.GCQueryOptions.TabIndex = 1;
            this.GCQueryOptions.Text = "خيارات";
            // 
            // btnPrintEditor
            // 
            this.btnPrintEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintEditor.Location = new System.Drawing.Point(593, 24);
            this.btnPrintEditor.Name = "btnPrintEditor";
            this.btnPrintEditor.Size = new System.Drawing.Size(163, 23);
            this.btnPrintEditor.TabIndex = 2;
            this.btnPrintEditor.Text = "تعديل ورقة الطباعه";
            this.btnPrintEditor.Visible = false;
            this.btnPrintEditor.Click += new System.EventHandler(this.btnPrintEditor_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(593, 72);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعه";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(5, 72);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(163, 23);
            this.btnGetData.TabIndex = 3;
            this.btnGetData.Text = "عرض";
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // LUEFasl
            // 
            this.LUEFasl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUEFasl.Location = new System.Drawing.Point(196, 47);
            this.LUEFasl.Name = "LUEFasl";
            this.LUEFasl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEFasl.Properties.DataSource = this.fASLBindingSource;
            this.LUEFasl.Properties.DisplayMember = "FASL";
            this.LUEFasl.Properties.NullText = "";
            this.LUEFasl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEFasl.Properties.ValueMember = "FASL";
            this.LUEFasl.Properties.View = this.gridView1;
            this.LUEFasl.Size = new System.Drawing.Size(150, 20);
            this.LUEFasl.TabIndex = 1;
            // 
            // fASLBindingSource
            // 
            this.fASLBindingSource.DataMember = "FASL";
            this.fASLBindingSource.DataSource = this.dsCards;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFASL2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFASL2
            // 
            this.colFASL2.AppearanceCell.Options.UseTextOptions = true;
            this.colFASL2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL2.AppearanceHeader.Options.UseTextOptions = true;
            this.colFASL2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL2.Caption = "اسم الفصل";
            this.colFASL2.FieldName = "FASL";
            this.colFASL2.Name = "colFASL2";
            this.colFASL2.Visible = true;
            this.colFASL2.VisibleIndex = 0;
            // 
            // LUESaf
            // 
            this.LUESaf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUESaf.Location = new System.Drawing.Point(383, 47);
            this.LUESaf.MenuManager = this.barManager;
            this.LUESaf.Name = "LUESaf";
            this.LUESaf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUESaf.Properties.DataSource = this.safBindingSource;
            this.LUESaf.Properties.DisplayMember = "SAF";
            this.LUESaf.Properties.NullText = "";
            this.LUESaf.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUESaf.Properties.ValueMember = "SAF";
            this.LUESaf.Properties.View = this.gridLookUpEdit1View;
            this.LUESaf.Size = new System.Drawing.Size(150, 20);
            this.LUESaf.TabIndex = 0;
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
            // safBindingSource
            // 
            this.safBindingSource.DataMember = "Saf";
            this.safBindingSource.DataSource = this.dsCards;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSAF1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSAF1
            // 
            this.colSAF1.AppearanceCell.Options.UseTextOptions = true;
            this.colSAF1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSAF1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF1.Caption = "اسم الصف";
            this.colSAF1.FieldName = "SAF";
            this.colSAF1.Name = "colSAF1";
            this.colSAF1.Visible = true;
            this.colSAF1.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Location = new System.Drawing.Point(352, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "الفصل";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(539, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الصف";
            // 
            // dATATableAdapter
            // 
            this.dATATableAdapter.ClearBeforeFill = true;
            // 
            // safTableAdapter
            // 
            this.safTableAdapter.ClearBeforeFill = true;
            // 
            // fASLTableAdapter
            // 
            this.fASLTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCQueryOptions)).EndInit();
            this.GCQueryOptions.ResumeLayout(false);
            this.GCQueryOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEFasl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fASLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESaf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
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
        private DataSources.dsCards dsCards;
        private System.Windows.Forms.BindingSource dATABindingSource;
        private DataSources.dsCardsTableAdapters.DATATableAdapter dATATableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSAF;
        private DevExpress.XtraGrid.Columns.GridColumn colFASL;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private DevExpress.XtraGrid.Columns.GridColumn colIMG;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl GCQueryOptions;
        private DevExpress.XtraEditors.SimpleButton btnGetData;
        private DevExpress.XtraEditors.GridLookUpEdit LUEFasl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit LUESaf;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource safBindingSource;
        private DataSources.dsCardsTableAdapters.SafTableAdapter safTableAdapter;
        private System.Windows.Forms.BindingSource fASLBindingSource;
        private DataSources.dsCardsTableAdapters.FASLTableAdapter fASLTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFASL1;
        private DevExpress.XtraGrid.Columns.GridColumn colSAF1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colEdara;
        private DevExpress.XtraGrid.Columns.GridColumn colGov;
        private DevExpress.XtraGrid.Columns.GridColumn colFASL2;
        private DevExpress.XtraEditors.SimpleButton btnPrintEditor;

    }
}
