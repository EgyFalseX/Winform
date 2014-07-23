namespace NICSQLTools.Forms.Data
{
    partial class CustomerEditorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditorFrm));
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer_T = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1En = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName3En = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomertypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colL3Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colL4Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colL5Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colL6Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubchannel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevelCCSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType_STI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributionchannel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1Ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName3Ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType2OLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerbrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRZbrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCustomerGroup = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditCustomerType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditCustomerType2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditSubchannel = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditLevelCCSD = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditDistributionChannel2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemDateEditCreationDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.customerGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerGroupTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.CustomerGroupTableAdapter();
            this.colCustomerGroup2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTypeTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.CustomerTypeTableAdapter();
            this.colCustomerType1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerType2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerType2TableAdapter = new NICSQLTools.Data.dsQryTableAdapters.CustomerType2TableAdapter();
            this.colCustomerType21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subchannelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subchannelTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.SubchannelTableAdapter();
            this.colSubchannel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.levelCCSDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelCCSDTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.LevelCCSDTableAdapter();
            this.colLevelCCSD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.distributionChannel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distributionChannel2TableAdapter = new NICSQLTools.Data.dsQryTableAdapters.DistributionChannel2TableAdapter();
            this.colDistributionchannel21 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubchannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditLevelCCSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDistributionChannel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditCreationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditCreationDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerType2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subchannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelCCSDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionChannel2BindingSource)).BeginInit();
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
            this.bbiSave,
            this.bbiExport});
            this.barManagerMain.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.Glyph")));
            this.bbiSave.Id = 0;
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.LargeGlyph")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NICSQLTools.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(636, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 286);
            this.barDockControlBottom.Size = new System.Drawing.Size(636, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 255);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(636, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 255);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditCustomerGroup,
            this.repositoryItemGridLookUpEditCustomerType,
            this.repositoryItemGridLookUpEditCustomerType2,
            this.repositoryItemGridLookUpEditSubchannel,
            this.repositoryItemGridLookUpEditLevelCCSD,
            this.repositoryItemGridLookUpEditDistributionChannel2,
            this.repositoryItemDateEditCreationDate});
            this.gridControlMain.Size = new System.Drawing.Size(636, 255);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer_T,
            this.colCustomerGroup,
            this.colName1En,
            this.colName3En,
            this.colCustomerType,
            this.colCustomerType2,
            this.colCustHierLevel3,
            this.colCustomertypeCode,
            this.colL3Code,
            this.colL4Code,
            this.colCustHierLevel4,
            this.colL5Code,
            this.colCustHierLevel5,
            this.colL6Code,
            this.colCustHierLevel6,
            this.colSubchannel,
            this.colLevelCCSD,
            this.colCustomerType_STI,
            this.colDistributionchannel2,
            this.colYearC,
            this.colAddress,
            this.colName1Ar,
            this.colName3Ar,
            this.colCityEN,
            this.colCityAR,
            this.gridColumn1,
            this.colCustomerType2OLD,
            this.colCreationDate,
            this.colCustomerbrand,
            this.colSerialNO,
            this.colFRZbrand});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click here to add a new customer";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colCustomer_T
            // 
            this.colCustomer_T.FieldName = "Customer_T";
            this.colCustomer_T.Name = "colCustomer_T";
            this.colCustomer_T.Visible = true;
            this.colCustomer_T.VisibleIndex = 0;
            this.colCustomer_T.Width = 77;
            // 
            // colCustomerGroup
            // 
            this.colCustomerGroup.ColumnEdit = this.repositoryItemGridLookUpEditCustomerGroup;
            this.colCustomerGroup.FieldName = "Customer Group";
            this.colCustomerGroup.Name = "colCustomerGroup";
            this.colCustomerGroup.Visible = true;
            this.colCustomerGroup.VisibleIndex = 1;
            this.colCustomerGroup.Width = 97;
            // 
            // colName1En
            // 
            this.colName1En.FieldName = "Name 1 En";
            this.colName1En.Name = "colName1En";
            this.colName1En.Visible = true;
            this.colName1En.VisibleIndex = 2;
            // 
            // colName3En
            // 
            this.colName3En.FieldName = "Name 3 En";
            this.colName3En.Name = "colName3En";
            this.colName3En.Visible = true;
            this.colName3En.VisibleIndex = 3;
            // 
            // colCustomerType
            // 
            this.colCustomerType.ColumnEdit = this.repositoryItemGridLookUpEditCustomerType;
            this.colCustomerType.FieldName = "Customer Type";
            this.colCustomerType.Name = "colCustomerType";
            this.colCustomerType.Visible = true;
            this.colCustomerType.VisibleIndex = 4;
            this.colCustomerType.Width = 92;
            // 
            // colCustomerType2
            // 
            this.colCustomerType2.ColumnEdit = this.repositoryItemGridLookUpEditCustomerType2;
            this.colCustomerType2.FieldName = "Customer Type 2";
            this.colCustomerType2.Name = "colCustomerType2";
            this.colCustomerType2.Visible = true;
            this.colCustomerType2.VisibleIndex = 5;
            this.colCustomerType2.Width = 101;
            // 
            // colCustHierLevel3
            // 
            this.colCustHierLevel3.FieldName = "CustHier Level 3";
            this.colCustHierLevel3.Name = "colCustHierLevel3";
            this.colCustHierLevel3.Visible = true;
            this.colCustHierLevel3.VisibleIndex = 6;
            this.colCustHierLevel3.Width = 100;
            // 
            // colCustomertypeCode
            // 
            this.colCustomertypeCode.FieldName = "Customer type Code";
            this.colCustomertypeCode.Name = "colCustomertypeCode";
            this.colCustomertypeCode.Visible = true;
            this.colCustomertypeCode.VisibleIndex = 7;
            this.colCustomertypeCode.Width = 118;
            // 
            // colL3Code
            // 
            this.colL3Code.FieldName = "L3 Code";
            this.colL3Code.Name = "colL3Code";
            this.colL3Code.Visible = true;
            this.colL3Code.VisibleIndex = 8;
            // 
            // colL4Code
            // 
            this.colL4Code.FieldName = "L4 Code";
            this.colL4Code.Name = "colL4Code";
            this.colL4Code.Visible = true;
            this.colL4Code.VisibleIndex = 9;
            // 
            // colCustHierLevel4
            // 
            this.colCustHierLevel4.FieldName = "CustHier Level 4";
            this.colCustHierLevel4.Name = "colCustHierLevel4";
            this.colCustHierLevel4.Visible = true;
            this.colCustHierLevel4.VisibleIndex = 10;
            this.colCustHierLevel4.Width = 100;
            // 
            // colL5Code
            // 
            this.colL5Code.FieldName = "L5 Code";
            this.colL5Code.Name = "colL5Code";
            this.colL5Code.Visible = true;
            this.colL5Code.VisibleIndex = 11;
            // 
            // colCustHierLevel5
            // 
            this.colCustHierLevel5.FieldName = "CustHier Level 5";
            this.colCustHierLevel5.Name = "colCustHierLevel5";
            this.colCustHierLevel5.Visible = true;
            this.colCustHierLevel5.VisibleIndex = 12;
            this.colCustHierLevel5.Width = 100;
            // 
            // colL6Code
            // 
            this.colL6Code.FieldName = "L6 Code";
            this.colL6Code.Name = "colL6Code";
            this.colL6Code.Visible = true;
            this.colL6Code.VisibleIndex = 13;
            // 
            // colCustHierLevel6
            // 
            this.colCustHierLevel6.FieldName = "CustHier Level 6";
            this.colCustHierLevel6.Name = "colCustHierLevel6";
            this.colCustHierLevel6.Visible = true;
            this.colCustHierLevel6.VisibleIndex = 14;
            this.colCustHierLevel6.Width = 100;
            // 
            // colSubchannel
            // 
            this.colSubchannel.ColumnEdit = this.repositoryItemGridLookUpEditSubchannel;
            this.colSubchannel.FieldName = "Subchannel";
            this.colSubchannel.Name = "colSubchannel";
            this.colSubchannel.Visible = true;
            this.colSubchannel.VisibleIndex = 15;
            // 
            // colLevelCCSD
            // 
            this.colLevelCCSD.ColumnEdit = this.repositoryItemGridLookUpEditLevelCCSD;
            this.colLevelCCSD.FieldName = "Level CCSD";
            this.colLevelCCSD.Name = "colLevelCCSD";
            this.colLevelCCSD.Visible = true;
            this.colLevelCCSD.VisibleIndex = 16;
            // 
            // colCustomerType_STI
            // 
            this.colCustomerType_STI.FieldName = "Customer Type_STI";
            this.colCustomerType_STI.Name = "colCustomerType_STI";
            this.colCustomerType_STI.Visible = true;
            this.colCustomerType_STI.VisibleIndex = 17;
            this.colCustomerType_STI.Width = 114;
            // 
            // colDistributionchannel2
            // 
            this.colDistributionchannel2.ColumnEdit = this.repositoryItemGridLookUpEditDistributionChannel2;
            this.colDistributionchannel2.FieldName = "Distribution channel 2";
            this.colDistributionchannel2.Name = "colDistributionchannel2";
            this.colDistributionchannel2.Visible = true;
            this.colDistributionchannel2.VisibleIndex = 18;
            this.colDistributionchannel2.Width = 122;
            // 
            // colYearC
            // 
            this.colYearC.FieldName = "Year C";
            this.colYearC.Name = "colYearC";
            this.colYearC.Visible = true;
            this.colYearC.VisibleIndex = 19;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 20;
            // 
            // colName1Ar
            // 
            this.colName1Ar.FieldName = "Name 1 Ar";
            this.colName1Ar.Name = "colName1Ar";
            this.colName1Ar.Visible = true;
            this.colName1Ar.VisibleIndex = 21;
            // 
            // colName3Ar
            // 
            this.colName3Ar.FieldName = "Name 3 Ar";
            this.colName3Ar.Name = "colName3Ar";
            this.colName3Ar.Visible = true;
            this.colName3Ar.VisibleIndex = 22;
            // 
            // colCityEN
            // 
            this.colCityEN.FieldName = "City EN";
            this.colCityEN.Name = "colCityEN";
            this.colCityEN.Visible = true;
            this.colCityEN.VisibleIndex = 23;
            // 
            // colCityAR
            // 
            this.colCityAR.FieldName = "City AR";
            this.colCityAR.Name = "colCityAR";
            this.colCityAR.Visible = true;
            this.colCityAR.VisibleIndex = 24;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Base-New";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 25;
            // 
            // colCustomerType2OLD
            // 
            this.colCustomerType2OLD.FieldName = "Customer Type 2 OLD";
            this.colCustomerType2OLD.Name = "colCustomerType2OLD";
            this.colCustomerType2OLD.Visible = true;
            this.colCustomerType2OLD.VisibleIndex = 26;
            this.colCustomerType2OLD.Width = 124;
            // 
            // colCreationDate
            // 
            this.colCreationDate.FieldName = "Creation Date";
            this.colCreationDate.Name = "colCreationDate";
            this.colCreationDate.Visible = true;
            this.colCreationDate.VisibleIndex = 27;
            this.colCreationDate.Width = 86;
            // 
            // colCustomerbrand
            // 
            this.colCustomerbrand.FieldName = "Customer brand";
            this.colCustomerbrand.Name = "colCustomerbrand";
            this.colCustomerbrand.Visible = true;
            this.colCustomerbrand.VisibleIndex = 28;
            this.colCustomerbrand.Width = 96;
            // 
            // colSerialNO
            // 
            this.colSerialNO.FieldName = "Serial NO";
            this.colSerialNO.Name = "colSerialNO";
            this.colSerialNO.Visible = true;
            this.colSerialNO.VisibleIndex = 29;
            // 
            // colFRZbrand
            // 
            this.colFRZbrand.FieldName = "FRZ brand";
            this.colFRZbrand.Name = "colFRZbrand";
            this.colFRZbrand.Visible = true;
            this.colFRZbrand.VisibleIndex = 30;
            // 
            // repositoryItemGridLookUpEditCustomerGroup
            // 
            this.repositoryItemGridLookUpEditCustomerGroup.AutoHeight = false;
            this.repositoryItemGridLookUpEditCustomerGroup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemGridLookUpEditCustomerGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCustomerGroup.DataSource = this.customerGroupBindingSource;
            this.repositoryItemGridLookUpEditCustomerGroup.DisplayMember = "Customer Group";
            this.repositoryItemGridLookUpEditCustomerGroup.Name = "repositoryItemGridLookUpEditCustomerGroup";
            this.repositoryItemGridLookUpEditCustomerGroup.NullText = "";
            this.repositoryItemGridLookUpEditCustomerGroup.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCustomerGroup.ValueMember = "Customer Group";
            this.repositoryItemGridLookUpEditCustomerGroup.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerGroup2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEditCustomerType
            // 
            this.repositoryItemGridLookUpEditCustomerType.AutoHeight = false;
            this.repositoryItemGridLookUpEditCustomerType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCustomerType.DataSource = this.customerTypeBindingSource;
            this.repositoryItemGridLookUpEditCustomerType.DisplayMember = "Customer Type";
            this.repositoryItemGridLookUpEditCustomerType.Name = "repositoryItemGridLookUpEditCustomerType";
            this.repositoryItemGridLookUpEditCustomerType.NullText = "";
            this.repositoryItemGridLookUpEditCustomerType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCustomerType.ValueMember = "Customer Type";
            this.repositoryItemGridLookUpEditCustomerType.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerType1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEditCustomerType2
            // 
            this.repositoryItemGridLookUpEditCustomerType2.AutoHeight = false;
            this.repositoryItemGridLookUpEditCustomerType2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCustomerType2.DataSource = this.customerType2BindingSource;
            this.repositoryItemGridLookUpEditCustomerType2.DisplayMember = "Customer Type 2";
            this.repositoryItemGridLookUpEditCustomerType2.Name = "repositoryItemGridLookUpEditCustomerType2";
            this.repositoryItemGridLookUpEditCustomerType2.NullText = "";
            this.repositoryItemGridLookUpEditCustomerType2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCustomerType2.ValueMember = "Customer Type 2";
            this.repositoryItemGridLookUpEditCustomerType2.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerType21});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEditSubchannel
            // 
            this.repositoryItemGridLookUpEditSubchannel.AutoHeight = false;
            this.repositoryItemGridLookUpEditSubchannel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSubchannel.DataSource = this.subchannelBindingSource;
            this.repositoryItemGridLookUpEditSubchannel.DisplayMember = "Subchannel";
            this.repositoryItemGridLookUpEditSubchannel.Name = "repositoryItemGridLookUpEditSubchannel";
            this.repositoryItemGridLookUpEditSubchannel.NullText = "";
            this.repositoryItemGridLookUpEditSubchannel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSubchannel.ValueMember = "Subchannel";
            this.repositoryItemGridLookUpEditSubchannel.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubchannel1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEditLevelCCSD
            // 
            this.repositoryItemGridLookUpEditLevelCCSD.AutoHeight = false;
            this.repositoryItemGridLookUpEditLevelCCSD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditLevelCCSD.DataSource = this.levelCCSDBindingSource;
            this.repositoryItemGridLookUpEditLevelCCSD.DisplayMember = "Level CCSD";
            this.repositoryItemGridLookUpEditLevelCCSD.Name = "repositoryItemGridLookUpEditLevelCCSD";
            this.repositoryItemGridLookUpEditLevelCCSD.NullText = "";
            this.repositoryItemGridLookUpEditLevelCCSD.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditLevelCCSD.ValueMember = "Level CCSD";
            this.repositoryItemGridLookUpEditLevelCCSD.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLevelCCSD1});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEditDistributionChannel2
            // 
            this.repositoryItemGridLookUpEditDistributionChannel2.AutoHeight = false;
            this.repositoryItemGridLookUpEditDistributionChannel2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditDistributionChannel2.DataSource = this.distributionChannel2BindingSource;
            this.repositoryItemGridLookUpEditDistributionChannel2.DisplayMember = "Distribution channel 2";
            this.repositoryItemGridLookUpEditDistributionChannel2.Name = "repositoryItemGridLookUpEditDistributionChannel2";
            this.repositoryItemGridLookUpEditDistributionChannel2.NullText = "";
            this.repositoryItemGridLookUpEditDistributionChannel2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditDistributionChannel2.ValueMember = "Distribution channel 2";
            this.repositoryItemGridLookUpEditDistributionChannel2.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDistributionchannel21});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemDateEditCreationDate
            // 
            this.repositoryItemDateEditCreationDate.AutoHeight = false;
            this.repositoryItemDateEditCreationDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditCreationDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditCreationDate.DisplayFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditCreationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditCreationDate.EditFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditCreationDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditCreationDate.Mask.EditMask = "d/M/yyyy";
            this.repositoryItemDateEditCreationDate.Name = "repositoryItemDateEditCreationDate";
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData._0_6_Customer_HNDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerGroupBindingSource
            // 
            this.customerGroupBindingSource.DataMember = "CustomerGroup";
            this.customerGroupBindingSource.DataSource = this.dsQry;
            // 
            // customerGroupTableAdapter
            // 
            this.customerGroupTableAdapter.ClearBeforeFill = true;
            // 
            // colCustomerGroup2
            // 
            this.colCustomerGroup2.FieldName = "Customer Group";
            this.colCustomerGroup2.Name = "colCustomerGroup2";
            this.colCustomerGroup2.Visible = true;
            this.colCustomerGroup2.VisibleIndex = 0;
            // 
            // customerTypeBindingSource
            // 
            this.customerTypeBindingSource.DataMember = "CustomerType";
            this.customerTypeBindingSource.DataSource = this.dsQry;
            // 
            // customerTypeTableAdapter
            // 
            this.customerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // colCustomerType1
            // 
            this.colCustomerType1.FieldName = "Customer Type";
            this.colCustomerType1.Name = "colCustomerType1";
            this.colCustomerType1.Visible = true;
            this.colCustomerType1.VisibleIndex = 0;
            // 
            // customerType2BindingSource
            // 
            this.customerType2BindingSource.DataMember = "CustomerType2";
            this.customerType2BindingSource.DataSource = this.dsQry;
            // 
            // customerType2TableAdapter
            // 
            this.customerType2TableAdapter.ClearBeforeFill = true;
            // 
            // colCustomerType21
            // 
            this.colCustomerType21.FieldName = "Customer Type 2";
            this.colCustomerType21.Name = "colCustomerType21";
            this.colCustomerType21.Visible = true;
            this.colCustomerType21.VisibleIndex = 0;
            // 
            // subchannelBindingSource
            // 
            this.subchannelBindingSource.DataMember = "Subchannel";
            this.subchannelBindingSource.DataSource = this.dsQry;
            // 
            // subchannelTableAdapter
            // 
            this.subchannelTableAdapter.ClearBeforeFill = true;
            // 
            // colSubchannel1
            // 
            this.colSubchannel1.FieldName = "Subchannel";
            this.colSubchannel1.Name = "colSubchannel1";
            this.colSubchannel1.Visible = true;
            this.colSubchannel1.VisibleIndex = 0;
            // 
            // levelCCSDBindingSource
            // 
            this.levelCCSDBindingSource.DataMember = "LevelCCSD";
            this.levelCCSDBindingSource.DataSource = this.dsQry;
            // 
            // levelCCSDTableAdapter
            // 
            this.levelCCSDTableAdapter.ClearBeforeFill = true;
            // 
            // colLevelCCSD1
            // 
            this.colLevelCCSD1.FieldName = "Level CCSD";
            this.colLevelCCSD1.Name = "colLevelCCSD1";
            this.colLevelCCSD1.Visible = true;
            this.colLevelCCSD1.VisibleIndex = 0;
            // 
            // distributionChannel2BindingSource
            // 
            this.distributionChannel2BindingSource.DataMember = "DistributionChannel2";
            this.distributionChannel2BindingSource.DataSource = this.dsQry;
            // 
            // distributionChannel2TableAdapter
            // 
            this.distributionChannel2TableAdapter.ClearBeforeFill = true;
            // 
            // colDistributionchannel21
            // 
            this.colDistributionchannel21.FieldName = "Distribution channel 2";
            this.colDistributionchannel21.Name = "colDistributionchannel21";
            this.colDistributionchannel21.Visible = true;
            this.colDistributionchannel21.VisibleIndex = 0;
            // 
            // CustomerEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 286);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerEditorFrm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Shown += new System.EventHandler(this.CustomerEditorFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubchannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditLevelCCSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDistributionChannel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditCreationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditCreationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerType2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subchannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelCCSDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionChannel2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCustomerGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCustomerType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCustomerType2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSubchannel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditLevelCCSD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditDistributionChannel2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditCreationDate;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_T;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colName1En;
        private DevExpress.XtraGrid.Columns.GridColumn colName3En;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel3;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomertypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colL3Code;
        private DevExpress.XtraGrid.Columns.GridColumn colL4Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel4;
        private DevExpress.XtraGrid.Columns.GridColumn colL5Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel5;
        private DevExpress.XtraGrid.Columns.GridColumn colL6Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel6;
        private DevExpress.XtraGrid.Columns.GridColumn colSubchannel;
        private DevExpress.XtraGrid.Columns.GridColumn colLevelCCSD;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType_STI;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributionchannel2;
        private DevExpress.XtraGrid.Columns.GridColumn colYearC;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colName1Ar;
        private DevExpress.XtraGrid.Columns.GridColumn colName3Ar;
        private DevExpress.XtraGrid.Columns.GridColumn colCityEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCityAR;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType2OLD;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerbrand;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNO;
        private DevExpress.XtraGrid.Columns.GridColumn colFRZbrand;
        private NICSQLTools.Data.dsQry dsQry;
        private System.Windows.Forms.BindingSource customerGroupBindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.CustomerGroupTableAdapter customerGroupTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerGroup2;
        private System.Windows.Forms.BindingSource customerTypeBindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.CustomerTypeTableAdapter customerTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType1;
        private System.Windows.Forms.BindingSource customerType2BindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.CustomerType2TableAdapter customerType2TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType21;
        private System.Windows.Forms.BindingSource subchannelBindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.SubchannelTableAdapter subchannelTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSubchannel1;
        private System.Windows.Forms.BindingSource levelCCSDBindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.LevelCCSDTableAdapter levelCCSDTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colLevelCCSD1;
        private System.Windows.Forms.BindingSource distributionChannel2BindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.DistributionChannel2TableAdapter distributionChannel2TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributionchannel21;
    }
}