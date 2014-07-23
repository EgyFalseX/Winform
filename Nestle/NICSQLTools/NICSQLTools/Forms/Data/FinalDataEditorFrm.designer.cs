namespace NICSQLTools.Forms.Data
{
    partial class FinalDataEditorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalDataEditorFrm));
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
            this.LSMS = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBilling_Document = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_Eh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume_14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume_13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue_14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue_13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCases_14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCases_13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNew_Cases = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCases = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice_Point = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPallet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumer_price__Piece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumer_price__Carton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute_Number__system = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDN_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDN__Custtype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Type_STI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeek_NCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrade_Price_Piece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrade_Price_Carton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice_Point_rang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice_Increas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNew_Qu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolum_Pice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBase_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBase_Base_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_3_Ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_1_Ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear_C = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Type_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubchannel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colL6_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHier_Level_6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colL5_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHier_Level_5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colL4_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHier_Level_4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colL3_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHier_Level_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_3_En = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_1_En = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand_Route = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupervisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRSM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_District = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_District_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay_Month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_LD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnnex_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnnex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNew_Quanteite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyeard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute___Sold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition_base_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActual_Invoiced_Quan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colG_L_Account_Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBase_Unit_of_Measure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBilling_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReference_Document_N = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_Organization = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBilling_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial_Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBilling_date_for_bil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSold_to_party = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistribution_Channel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBase_New = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevel_CCSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRZ_brand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand_Rang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SDN_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_District_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutoKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCustHierLevel6Id = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustHierLevel6Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel6Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel5Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel5Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel4Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel4Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel3Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel3Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributionChannelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributionChannel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCustomerTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCustomerType2Id = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerType2Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCustomerGroupId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerGroup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSubchannelId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubchannelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubchannelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCityId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityEnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityArName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditCreationDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustHierLevel6Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerType2Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerGroupId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubchannelId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCityId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditCreationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditCreationDate.CalendarTimeProperties)).BeginInit();
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
            this.gridControlMain.DataSource = this.LSMS;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditCustHierLevel6Id,
            this.repositoryItemGridLookUpEditCustomerTypeId,
            this.repositoryItemGridLookUpEditCustomerType2Id,
            this.repositoryItemGridLookUpEditCustomerGroupId,
            this.repositoryItemGridLookUpEditSubchannelId,
            this.repositoryItemGridLookUpEditCityId,
            this.repositoryItemDateEditCreationDate});
            this.gridControlMain.Size = new System.Drawing.Size(636, 255);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // LSMS
            // 
            this.LSMS.ElementType = typeof(NICSQLTools.Data._0_0_Final_Data_All);
            this.LSMS.KeyExpression = "AutoKey";
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBilling_Document,
            this.colSales_Eh,
            this.colVolume_14,
            this.colVolume_13,
            this.colValue_14,
            this.colValue_13,
            this.colCases_14,
            this.colCases_13,
            this.colVolume,
            this.colNew_Cases,
            this.colType,
            this.colCases,
            this.colValue,
            this.colPrice_Point,
            this.colMaterial_Type,
            this.colPallet,
            this.colConsumer_price__Piece,
            this.colConsumer_price__Carton,
            this.colRoute_Number__system,
            this.colGroup_3,
            this.colGroup_2,
            this.colGroup_1,
            this.colSDN_Code,
            this.colSDN__Custtype,
            this.colAddress,
            this.colCustomer_Type_STI,
            this.colWeek_NCE,
            this.colTrade_Price_Piece,
            this.colTrade_Price_Carton,
            this.colPrice_Point_rang,
            this.colPrice_Increas,
            this.colNew_Qu,
            this.colVolum_Pice,
            this.colVol,
            this.colVolum,
            this.colQuin,
            this.colMaterial_Name,
            this.colBase_Product,
            this.colBase_Base_Product,
            this.colBrand,
            this.colName_3_Ar,
            this.colName_1_Ar,
            this.colYear_C,
            this.colCustomer_Type_2,
            this.colCustomer_Type,
            this.colCustomer_Group,
            this.colSubchannel,
            this.colL6_Code,
            this.colCustHier_Level_6,
            this.colL5_Code,
            this.colCustHier_Level_5,
            this.colL4_Code,
            this.colCustHier_Level_4,
            this.colL3_Code,
            this.colCustHier_Level_3,
            this.colName_3_En,
            this.colName_1_En,
            this.colBrand_Route,
            this.colSupervisor,
            this.colASM,
            this.colRSM,
            this.colSales_District,
            this.colSales_District_Name,
            this.colRegion,
            this.colRoute_Name,
            this.colPeriod,
            this.colDay_Month,
            this.colYear,
            this.colDay,
            this.colWeek,
            this.colSales_LD,
            this.colMonth,
            this.colUpdated,
            this.colAnnex_rate,
            this.colAnnex,
            this.colNew_Quanteite,
            this.colyeard,
            this.colRoute___Sold,
            this.colCondition_value,
            this.colCondition_base_value,
            this.colActual_Invoiced_Quan,
            this.colG_L_Account_Number,
            this.colCondition_type,
            this.colPlant,
            this.colBase_Unit_of_Measure,
            this.colSales_unit,
            this.colBilling_item,
            this.colReference_Document_N,
            this.colPayer,
            this.colCompany_Code,
            this.colSales_Organization,
            this.colBilling_Type,
            this.colMaterial_Number,
            this.colBilling_date_for_bil,
            this.colRoute,
            this.colSold_to_party,
            this.colDistribution_Channel,
            this.colTPP,
            this.colSales,
            this.colBase_New,
            this.colLevel_CCSD,
            this.colFRZ_brand,
            this.colBrand_Rang,
            this.col_SDN_Type,
            this.colSales_District_2,
            this.colAutoKey});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colBilling_Document
            // 
            this.colBilling_Document.Caption = "Billing Document";
            this.colBilling_Document.FieldName = "Billing_Document";
            this.colBilling_Document.Name = "colBilling_Document";
            this.colBilling_Document.Visible = true;
            this.colBilling_Document.VisibleIndex = 1;
            this.colBilling_Document.Width = 99;
            // 
            // colSales_Eh
            // 
            this.colSales_Eh.Caption = "Sales Eh";
            this.colSales_Eh.FieldName = "Sales_Eh";
            this.colSales_Eh.Name = "colSales_Eh";
            // 
            // colVolume_14
            // 
            this.colVolume_14.Caption = "Volume 14";
            this.colVolume_14.FieldName = "Volume_14";
            this.colVolume_14.Name = "colVolume_14";
            this.colVolume_14.Visible = true;
            this.colVolume_14.VisibleIndex = 2;
            // 
            // colVolume_13
            // 
            this.colVolume_13.Caption = "Volume 13";
            this.colVolume_13.FieldName = "Volume_13";
            this.colVolume_13.Name = "colVolume_13";
            this.colVolume_13.Visible = true;
            this.colVolume_13.VisibleIndex = 3;
            // 
            // colValue_14
            // 
            this.colValue_14.Caption = "Value 14";
            this.colValue_14.FieldName = "Value_14";
            this.colValue_14.Name = "colValue_14";
            this.colValue_14.Visible = true;
            this.colValue_14.VisibleIndex = 4;
            // 
            // colValue_13
            // 
            this.colValue_13.Caption = "Value 13";
            this.colValue_13.FieldName = "Value_13";
            this.colValue_13.Name = "colValue_13";
            this.colValue_13.Visible = true;
            this.colValue_13.VisibleIndex = 5;
            // 
            // colCases_14
            // 
            this.colCases_14.Caption = "Cases 14";
            this.colCases_14.FieldName = "Cases_14";
            this.colCases_14.Name = "colCases_14";
            this.colCases_14.Visible = true;
            this.colCases_14.VisibleIndex = 6;
            // 
            // colCases_13
            // 
            this.colCases_13.Caption = "Cases 13";
            this.colCases_13.FieldName = "Cases_13";
            this.colCases_13.Name = "colCases_13";
            this.colCases_13.Visible = true;
            this.colCases_13.VisibleIndex = 7;
            // 
            // colVolume
            // 
            this.colVolume.Caption = "Volume";
            this.colVolume.FieldName = "Volume";
            this.colVolume.Name = "colVolume";
            // 
            // colNew_Cases
            // 
            this.colNew_Cases.Caption = "New Cases";
            this.colNew_Cases.FieldName = "New_Cases";
            this.colNew_Cases.Name = "colNew_Cases";
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 8;
            // 
            // colCases
            // 
            this.colCases.Caption = "Cases";
            this.colCases.FieldName = "Cases";
            this.colCases.Name = "colCases";
            // 
            // colValue
            // 
            this.colValue.Caption = "Value";
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            // 
            // colPrice_Point
            // 
            this.colPrice_Point.Caption = "Price Point";
            this.colPrice_Point.FieldName = "Price_Point";
            this.colPrice_Point.Name = "colPrice_Point";
            // 
            // colMaterial_Type
            // 
            this.colMaterial_Type.Caption = "Material Type";
            this.colMaterial_Type.FieldName = "Material_Type";
            this.colMaterial_Type.Name = "colMaterial_Type";
            this.colMaterial_Type.Width = 87;
            // 
            // colPallet
            // 
            this.colPallet.Caption = "Pallet";
            this.colPallet.FieldName = "Pallet";
            this.colPallet.Name = "colPallet";
            // 
            // colConsumer_price__Piece
            // 
            this.colConsumer_price__Piece.Caption = "Consumer price Piece";
            this.colConsumer_price__Piece.FieldName = "Consumer_price__Piece";
            this.colConsumer_price__Piece.Name = "colConsumer_price__Piece";
            this.colConsumer_price__Piece.Width = 133;
            // 
            // colConsumer_price__Carton
            // 
            this.colConsumer_price__Carton.Caption = "Consumer price Carton";
            this.colConsumer_price__Carton.FieldName = "Consumer_price__Carton";
            this.colConsumer_price__Carton.Name = "colConsumer_price__Carton";
            this.colConsumer_price__Carton.Width = 141;
            // 
            // colRoute_Number__system
            // 
            this.colRoute_Number__system.Caption = "Route Number system";
            this.colRoute_Number__system.FieldName = "Route_Number__system";
            this.colRoute_Number__system.Name = "colRoute_Number__system";
            this.colRoute_Number__system.Width = 137;
            // 
            // colGroup_3
            // 
            this.colGroup_3.Caption = "Group 3";
            this.colGroup_3.FieldName = "Group_3";
            this.colGroup_3.Name = "colGroup_3";
            // 
            // colGroup_2
            // 
            this.colGroup_2.Caption = "Group 2";
            this.colGroup_2.FieldName = "Group_2";
            this.colGroup_2.Name = "colGroup_2";
            // 
            // colGroup_1
            // 
            this.colGroup_1.Caption = "Group 1";
            this.colGroup_1.FieldName = "Group_1";
            this.colGroup_1.Name = "colGroup_1";
            // 
            // colSDN_Code
            // 
            this.colSDN_Code.Caption = "SDN Code";
            this.colSDN_Code.FieldName = "SDN_Code";
            this.colSDN_Code.Name = "colSDN_Code";
            // 
            // colSDN__Custtype
            // 
            this.colSDN__Custtype.Caption = "SDN Custtype";
            this.colSDN__Custtype.FieldName = "SDN__Custtype";
            this.colSDN__Custtype.Name = "colSDN__Custtype";
            this.colSDN__Custtype.Width = 95;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "SDN__Custtype";
            this.colAddress.Name = "colAddress";
            // 
            // colCustomer_Type_STI
            // 
            this.colCustomer_Type_STI.Caption = "Customer Type STI";
            this.colCustomer_Type_STI.FieldName = "Customer_Type_STI";
            this.colCustomer_Type_STI.Name = "colCustomer_Type_STI";
            this.colCustomer_Type_STI.Width = 117;
            // 
            // colWeek_NCE
            // 
            this.colWeek_NCE.Caption = "Week NCE";
            this.colWeek_NCE.FieldName = "Week_NCE";
            this.colWeek_NCE.Name = "colWeek_NCE";
            // 
            // colTrade_Price_Piece
            // 
            this.colTrade_Price_Piece.Caption = "Trade Price Piece";
            this.colTrade_Price_Piece.FieldName = "Trade_Price_Piece";
            this.colTrade_Price_Piece.Name = "colTrade_Price_Piece";
            this.colTrade_Price_Piece.Width = 107;
            // 
            // colTrade_Price_Carton
            // 
            this.colTrade_Price_Carton.Caption = "Trade Price Carton";
            this.colTrade_Price_Carton.FieldName = "Trade_Price_Carton";
            this.colTrade_Price_Carton.Name = "colTrade_Price_Carton";
            this.colTrade_Price_Carton.Width = 115;
            // 
            // colPrice_Point_rang
            // 
            this.colPrice_Point_rang.Caption = "Price Point rang";
            this.colPrice_Point_rang.FieldName = "Price_Point_rang";
            this.colPrice_Point_rang.Name = "colPrice_Point_rang";
            this.colPrice_Point_rang.Width = 100;
            // 
            // colPrice_Increas
            // 
            this.colPrice_Increas.Caption = "Price Increas";
            this.colPrice_Increas.FieldName = "Price_Increas";
            this.colPrice_Increas.Name = "colPrice_Increas";
            this.colPrice_Increas.Width = 84;
            // 
            // colNew_Qu
            // 
            this.colNew_Qu.Caption = "New Qu";
            this.colNew_Qu.FieldName = "New_Qu";
            this.colNew_Qu.Name = "colNew_Qu";
            // 
            // colVolum_Pice
            // 
            this.colVolum_Pice.Caption = "Volum Pice";
            this.colVolum_Pice.FieldName = "Volum_Pice";
            this.colVolum_Pice.Name = "colVolum_Pice";
            // 
            // colVol
            // 
            this.colVol.Caption = "Vol";
            this.colVol.FieldName = "Vol";
            this.colVol.Name = "colVol";
            // 
            // colVolum
            // 
            this.colVolum.Caption = "Volum";
            this.colVolum.FieldName = "Volum";
            this.colVolum.Name = "colVolum";
            // 
            // colQuin
            // 
            this.colQuin.Caption = "Quin";
            this.colQuin.FieldName = "Quin";
            this.colQuin.Name = "colQuin";
            // 
            // colMaterial_Name
            // 
            this.colMaterial_Name.Caption = "Material Name";
            this.colMaterial_Name.FieldName = "Material_Name";
            this.colMaterial_Name.Name = "colMaterial_Name";
            this.colMaterial_Name.Visible = true;
            this.colMaterial_Name.VisibleIndex = 10;
            this.colMaterial_Name.Width = 90;
            // 
            // colBase_Product
            // 
            this.colBase_Product.Caption = "Base Product";
            this.colBase_Product.FieldName = "Base_Product";
            this.colBase_Product.Name = "colBase_Product";
            this.colBase_Product.Width = 85;
            // 
            // colBase_Base_Product
            // 
            this.colBase_Base_Product.Caption = "Base Base Product";
            this.colBase_Base_Product.FieldName = "Base_Base_Product";
            this.colBase_Base_Product.Name = "colBase_Base_Product";
            this.colBase_Base_Product.Visible = true;
            this.colBase_Base_Product.VisibleIndex = 11;
            this.colBase_Base_Product.Width = 114;
            // 
            // colBrand
            // 
            this.colBrand.Caption = "Brand";
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 12;
            // 
            // colName_3_Ar
            // 
            this.colName_3_Ar.Caption = "Name 3 Ar";
            this.colName_3_Ar.FieldName = "Name_3_Ar";
            this.colName_3_Ar.Name = "colName_3_Ar";
            this.colName_3_Ar.Visible = true;
            this.colName_3_Ar.VisibleIndex = 17;
            // 
            // colName_1_Ar
            // 
            this.colName_1_Ar.Caption = "Name 1 Ar";
            this.colName_1_Ar.FieldName = "Name_1_Ar";
            this.colName_1_Ar.Name = "colName_1_Ar";
            this.colName_1_Ar.Visible = true;
            this.colName_1_Ar.VisibleIndex = 16;
            // 
            // colYear_C
            // 
            this.colYear_C.Caption = "Year C";
            this.colYear_C.FieldName = "Year_C";
            this.colYear_C.Name = "colYear_C";
            // 
            // colCustomer_Type_2
            // 
            this.colCustomer_Type_2.Caption = "Customer Type 2";
            this.colCustomer_Type_2.FieldName = "Customer_Type_2";
            this.colCustomer_Type_2.Name = "colCustomer_Type_2";
            this.colCustomer_Type_2.Visible = true;
            this.colCustomer_Type_2.VisibleIndex = 21;
            this.colCustomer_Type_2.Width = 107;
            // 
            // colCustomer_Type
            // 
            this.colCustomer_Type.Caption = "Customer Type";
            this.colCustomer_Type.FieldName = "Customer_Type";
            this.colCustomer_Type.Name = "colCustomer_Type";
            this.colCustomer_Type.Visible = true;
            this.colCustomer_Type.VisibleIndex = 22;
            this.colCustomer_Type.Width = 95;
            // 
            // colCustomer_Group
            // 
            this.colCustomer_Group.Caption = "Customer Group";
            this.colCustomer_Group.FieldName = "Customer_Group";
            this.colCustomer_Group.Name = "colCustomer_Group";
            this.colCustomer_Group.Visible = true;
            this.colCustomer_Group.VisibleIndex = 23;
            this.colCustomer_Group.Width = 100;
            // 
            // colSubchannel
            // 
            this.colSubchannel.Caption = "Subchannel";
            this.colSubchannel.FieldName = "Subchannel";
            this.colSubchannel.Name = "colSubchannel";
            this.colSubchannel.Visible = true;
            this.colSubchannel.VisibleIndex = 24;
            // 
            // colL6_Code
            // 
            this.colL6_Code.Caption = "L6 Code";
            this.colL6_Code.FieldName = "L6_Code";
            this.colL6_Code.Name = "colL6_Code";
            // 
            // colCustHier_Level_6
            // 
            this.colCustHier_Level_6.Caption = "CustHier Level 6";
            this.colCustHier_Level_6.FieldName = "CustHier_Level_6";
            this.colCustHier_Level_6.Name = "colCustHier_Level_6";
            this.colCustHier_Level_6.Width = 106;
            // 
            // colL5_Code
            // 
            this.colL5_Code.Caption = "L5 Code";
            this.colL5_Code.FieldName = "L5_Code";
            this.colL5_Code.Name = "colL5_Code";
            // 
            // colCustHier_Level_5
            // 
            this.colCustHier_Level_5.Caption = "CustHier Level 5";
            this.colCustHier_Level_5.FieldName = "CustHier_Level_5";
            this.colCustHier_Level_5.Name = "colCustHier_Level_5";
            this.colCustHier_Level_5.Width = 106;
            // 
            // colL4_Code
            // 
            this.colL4_Code.Caption = "L4 Code";
            this.colL4_Code.FieldName = "L4_Code";
            this.colL4_Code.Name = "colL4_Code";
            // 
            // colCustHier_Level_4
            // 
            this.colCustHier_Level_4.Caption = "CustHier Level 4";
            this.colCustHier_Level_4.FieldName = "CustHier_Level_4";
            this.colCustHier_Level_4.Name = "colCustHier_Level_4";
            this.colCustHier_Level_4.Width = 106;
            // 
            // colL3_Code
            // 
            this.colL3_Code.Caption = "L3 Code";
            this.colL3_Code.FieldName = "L3_Code";
            this.colL3_Code.Name = "colL3_Code";
            // 
            // colCustHier_Level_3
            // 
            this.colCustHier_Level_3.Caption = "CustHier Level 3";
            this.colCustHier_Level_3.FieldName = "CustHier_Level_3";
            this.colCustHier_Level_3.Name = "colCustHier_Level_3";
            this.colCustHier_Level_3.Width = 106;
            // 
            // colName_3_En
            // 
            this.colName_3_En.Caption = "Name 3 En";
            this.colName_3_En.FieldName = "Name_3_En";
            this.colName_3_En.Name = "colName_3_En";
            this.colName_3_En.Visible = true;
            this.colName_3_En.VisibleIndex = 15;
            this.colName_3_En.Width = 76;
            // 
            // colName_1_En
            // 
            this.colName_1_En.Caption = "Name 1 En";
            this.colName_1_En.FieldName = "Name_1_En";
            this.colName_1_En.Name = "colName_1_En";
            this.colName_1_En.Visible = true;
            this.colName_1_En.VisibleIndex = 14;
            this.colName_1_En.Width = 76;
            // 
            // colBrand_Route
            // 
            this.colBrand_Route.Caption = "Brand Route";
            this.colBrand_Route.FieldName = "Brand_Route";
            this.colBrand_Route.Name = "colBrand_Route";
            this.colBrand_Route.Visible = true;
            this.colBrand_Route.VisibleIndex = 28;
            this.colBrand_Route.Width = 82;
            // 
            // colSupervisor
            // 
            this.colSupervisor.Caption = "Supervisor";
            this.colSupervisor.FieldName = "Supervisor";
            this.colSupervisor.Name = "colSupervisor";
            this.colSupervisor.Visible = true;
            this.colSupervisor.VisibleIndex = 29;
            // 
            // colASM
            // 
            this.colASM.Caption = "ASM";
            this.colASM.FieldName = "ASM";
            this.colASM.Name = "colASM";
            this.colASM.Visible = true;
            this.colASM.VisibleIndex = 30;
            // 
            // colRSM
            // 
            this.colRSM.Caption = "RSM";
            this.colRSM.FieldName = "RSM";
            this.colRSM.Name = "colRSM";
            this.colRSM.Visible = true;
            this.colRSM.VisibleIndex = 31;
            // 
            // colSales_District
            // 
            this.colSales_District.Caption = "Sales District";
            this.colSales_District.FieldName = "Sales_District";
            this.colSales_District.Name = "colSales_District";
            this.colSales_District.Visible = true;
            this.colSales_District.VisibleIndex = 32;
            this.colSales_District.Width = 83;
            // 
            // colSales_District_Name
            // 
            this.colSales_District_Name.Caption = "Sales District Name";
            this.colSales_District_Name.FieldName = "Sales_District_Name";
            this.colSales_District_Name.Name = "colSales_District_Name";
            this.colSales_District_Name.Visible = true;
            this.colSales_District_Name.VisibleIndex = 33;
            this.colSales_District_Name.Width = 116;
            // 
            // colRegion
            // 
            this.colRegion.Caption = "Region";
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            // 
            // colRoute_Name
            // 
            this.colRoute_Name.Caption = "Route Name";
            this.colRoute_Name.FieldName = "Route_Name";
            this.colRoute_Name.Name = "colRoute_Name";
            this.colRoute_Name.Visible = true;
            this.colRoute_Name.VisibleIndex = 27;
            this.colRoute_Name.Width = 81;
            // 
            // colPeriod
            // 
            this.colPeriod.Caption = "Period";
            this.colPeriod.FieldName = "Period";
            this.colPeriod.Name = "colPeriod";
            // 
            // colDay_Month
            // 
            this.colDay_Month.Caption = "Day Month";
            this.colDay_Month.FieldName = "Day_Month";
            this.colDay_Month.Name = "colDay_Month";
            this.colDay_Month.Visible = true;
            this.colDay_Month.VisibleIndex = 37;
            // 
            // colYear
            // 
            this.colYear.Caption = "Year";
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            // 
            // colDay
            // 
            this.colDay.Caption = "Day";
            this.colDay.FieldName = "Day";
            this.colDay.Name = "colDay";
            this.colDay.Visible = true;
            this.colDay.VisibleIndex = 38;
            // 
            // colWeek
            // 
            this.colWeek.Caption = "Week";
            this.colWeek.FieldName = "Week";
            this.colWeek.Name = "colWeek";
            this.colWeek.Visible = true;
            this.colWeek.VisibleIndex = 39;
            // 
            // colSales_LD
            // 
            this.colSales_LD.Caption = "Sales LD";
            this.colSales_LD.FieldName = "Sales_LD";
            this.colSales_LD.Name = "colSales_LD";
            // 
            // colMonth
            // 
            this.colMonth.Caption = "Month";
            this.colMonth.FieldName = "Month";
            this.colMonth.Name = "colMonth";
            this.colMonth.Visible = true;
            this.colMonth.VisibleIndex = 40;
            // 
            // colUpdated
            // 
            this.colUpdated.Caption = "Updated";
            this.colUpdated.FieldName = "Updated";
            this.colUpdated.Name = "colUpdated";
            // 
            // colAnnex_rate
            // 
            this.colAnnex_rate.Caption = "Annex rate";
            this.colAnnex_rate.FieldName = "Annex_rate";
            this.colAnnex_rate.Name = "colAnnex_rate";
            this.colAnnex_rate.Width = 76;
            // 
            // colAnnex
            // 
            this.colAnnex.Caption = "Annex";
            this.colAnnex.FieldName = "Annex";
            this.colAnnex.Name = "colAnnex";
            // 
            // colNew_Quanteite
            // 
            this.colNew_Quanteite.Caption = "New Quanteite";
            this.colNew_Quanteite.FieldName = "New_Quanteite";
            this.colNew_Quanteite.Name = "colNew_Quanteite";
            this.colNew_Quanteite.Width = 94;
            // 
            // colyeard
            // 
            this.colyeard.Caption = "yeard";
            this.colyeard.FieldName = "yeard";
            this.colyeard.Name = "colyeard";
            this.colyeard.Visible = true;
            this.colyeard.VisibleIndex = 41;
            // 
            // colRoute___Sold
            // 
            this.colRoute___Sold.Caption = "Route & Sold";
            this.colRoute___Sold.FieldName = "Route___Sold";
            this.colRoute___Sold.Name = "colRoute___Sold";
            this.colRoute___Sold.Visible = true;
            this.colRoute___Sold.VisibleIndex = 26;
            this.colRoute___Sold.Width = 86;
            // 
            // colCondition_value
            // 
            this.colCondition_value.Caption = "Condition value";
            this.colCondition_value.FieldName = "Condition_value";
            this.colCondition_value.Name = "colCondition_value";
            this.colCondition_value.Width = 96;
            // 
            // colCondition_base_value
            // 
            this.colCondition_base_value.Caption = "Condition base value";
            this.colCondition_base_value.FieldName = "Condition_base_value";
            this.colCondition_base_value.Name = "colCondition_base_value";
            this.colCondition_base_value.Width = 125;
            // 
            // colActual_Invoiced_Quan
            // 
            this.colActual_Invoiced_Quan.Caption = "Actual Invoiced Quan";
            this.colActual_Invoiced_Quan.FieldName = "Actual_Invoiced_Quan";
            this.colActual_Invoiced_Quan.Name = "colActual_Invoiced_Quan";
            this.colActual_Invoiced_Quan.Width = 128;
            // 
            // colG_L_Account_Number
            // 
            this.colG_L_Account_Number.Caption = "G/L Account_Number";
            this.colG_L_Account_Number.FieldName = "G_L_Account_Number";
            this.colG_L_Account_Number.Name = "colG_L_Account_Number";
            this.colG_L_Account_Number.Width = 125;
            // 
            // colCondition_type
            // 
            this.colCondition_type.Caption = "Condition type";
            this.colCondition_type.FieldName = "Condition_type";
            this.colCondition_type.Name = "colCondition_type";
            this.colCondition_type.Width = 92;
            // 
            // colPlant
            // 
            this.colPlant.Caption = "Plant";
            this.colPlant.FieldName = "Plant";
            this.colPlant.Name = "colPlant";
            this.colPlant.Visible = true;
            this.colPlant.VisibleIndex = 36;
            // 
            // colBase_Unit_of_Measure
            // 
            this.colBase_Unit_of_Measure.Caption = "Base Unit of Measure";
            this.colBase_Unit_of_Measure.FieldName = "Base_Unit_of_Measure";
            this.colBase_Unit_of_Measure.Name = "colBase_Unit_of_Measure";
            this.colBase_Unit_of_Measure.Width = 130;
            // 
            // colSales_unit
            // 
            this.colSales_unit.Caption = "Sales unit";
            this.colSales_unit.FieldName = "Sales_unit";
            this.colSales_unit.Name = "colSales_unit";
            // 
            // colBilling_item
            // 
            this.colBilling_item.Caption = "Billing item";
            this.colBilling_item.FieldName = "Billing_item";
            this.colBilling_item.Name = "colBilling_item";
            // 
            // colReference_Document_N
            // 
            this.colReference_Document_N.Caption = "Reference Document N";
            this.colReference_Document_N.FieldName = "Reference_Document_N";
            this.colReference_Document_N.Name = "colReference_Document_N";
            this.colReference_Document_N.Width = 136;
            // 
            // colPayer
            // 
            this.colPayer.Caption = "Payer";
            this.colPayer.FieldName = "Payer";
            this.colPayer.Name = "colPayer";
            // 
            // colCompany_Code
            // 
            this.colCompany_Code.Caption = "Company Code";
            this.colCompany_Code.FieldName = "Company_Code";
            this.colCompany_Code.Name = "colCompany_Code";
            this.colCompany_Code.Width = 95;
            // 
            // colSales_Organization
            // 
            this.colSales_Organization.Caption = "Sales Organization";
            this.colSales_Organization.FieldName = "Sales_Organization";
            this.colSales_Organization.Name = "colSales_Organization";
            this.colSales_Organization.Width = 111;
            // 
            // colBilling_Type
            // 
            this.colBilling_Type.Caption = "Billing Type";
            this.colBilling_Type.FieldName = "Billing_Type";
            this.colBilling_Type.Name = "colBilling_Type";
            // 
            // colMaterial_Number
            // 
            this.colMaterial_Number.Caption = "Material Number";
            this.colMaterial_Number.FieldName = "Material_Number";
            this.colMaterial_Number.Name = "colMaterial_Number";
            this.colMaterial_Number.Visible = true;
            this.colMaterial_Number.VisibleIndex = 9;
            this.colMaterial_Number.Width = 100;
            // 
            // colBilling_date_for_bil
            // 
            this.colBilling_date_for_bil.Caption = "Billing date for bil";
            this.colBilling_date_for_bil.FieldName = "Billing_date_for_bil";
            this.colBilling_date_for_bil.Name = "colBilling_date_for_bil";
            this.colBilling_date_for_bil.Visible = true;
            this.colBilling_date_for_bil.VisibleIndex = 0;
            this.colBilling_date_for_bil.Width = 109;
            // 
            // colRoute
            // 
            this.colRoute.Caption = "Route";
            this.colRoute.FieldName = "Route";
            this.colRoute.Name = "colRoute";
            // 
            // colSold_to_party
            // 
            this.colSold_to_party.Caption = "Sold to party";
            this.colSold_to_party.FieldName = "Sold_to_party";
            this.colSold_to_party.Name = "colSold_to_party";
            this.colSold_to_party.Visible = true;
            this.colSold_to_party.VisibleIndex = 13;
            this.colSold_to_party.Width = 87;
            // 
            // colDistribution_Channel
            // 
            this.colDistribution_Channel.Caption = "Distribution Channel";
            this.colDistribution_Channel.FieldName = "Distribution_Channel";
            this.colDistribution_Channel.Name = "colDistribution_Channel";
            this.colDistribution_Channel.Visible = true;
            this.colDistribution_Channel.VisibleIndex = 25;
            this.colDistribution_Channel.Width = 118;
            // 
            // colTPP
            // 
            this.colTPP.Caption = "TPP";
            this.colTPP.FieldName = "TPP";
            this.colTPP.Name = "colTPP";
            // 
            // colSales
            // 
            this.colSales.Caption = "Sales";
            this.colSales.FieldName = "Sales";
            this.colSales.Name = "colSales";
            // 
            // colBase_New
            // 
            this.colBase_New.Caption = "Base New";
            this.colBase_New.FieldName = "Base_New";
            this.colBase_New.Name = "colBase_New";
            this.colBase_New.Visible = true;
            this.colBase_New.VisibleIndex = 18;
            // 
            // colLevel_CCSD
            // 
            this.colLevel_CCSD.Caption = "Level CCSD";
            this.colLevel_CCSD.FieldName = "Level_CCSD";
            this.colLevel_CCSD.Name = "colLevel_CCSD";
            this.colLevel_CCSD.Visible = true;
            this.colLevel_CCSD.VisibleIndex = 19;
            this.colLevel_CCSD.Width = 77;
            // 
            // colFRZ_brand
            // 
            this.colFRZ_brand.Caption = "FRZ brand";
            this.colFRZ_brand.FieldName = "FRZ_brand";
            this.colFRZ_brand.Name = "colFRZ_brand";
            this.colFRZ_brand.Visible = true;
            this.colFRZ_brand.VisibleIndex = 20;
            // 
            // colBrand_Rang
            // 
            this.colBrand_Rang.Caption = "Brand Rang";
            this.colBrand_Rang.FieldName = "Brand_Rang";
            this.colBrand_Rang.Name = "colBrand_Rang";
            this.colBrand_Rang.Width = 78;
            // 
            // col_SDN_Type
            // 
            this.col_SDN_Type.Caption = "SDN Type";
            this.col_SDN_Type.FieldName = "_SDN_Type";
            this.col_SDN_Type.Name = "col_SDN_Type";
            this.col_SDN_Type.Visible = true;
            this.col_SDN_Type.VisibleIndex = 35;
            // 
            // colSales_District_2
            // 
            this.colSales_District_2.Caption = "Sales District 2";
            this.colSales_District_2.FieldName = "Sales_District_2";
            this.colSales_District_2.Name = "colSales_District_2";
            this.colSales_District_2.Visible = true;
            this.colSales_District_2.VisibleIndex = 34;
            this.colSales_District_2.Width = 95;
            // 
            // colAutoKey
            // 
            this.colAutoKey.Caption = "AutoKey";
            this.colAutoKey.FieldName = "AutoKey";
            this.colAutoKey.Name = "colAutoKey";
            // 
            // repositoryItemGridLookUpEditCustHierLevel6Id
            // 
            this.repositoryItemGridLookUpEditCustHierLevel6Id.AutoHeight = false;
            this.repositoryItemGridLookUpEditCustHierLevel6Id.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemGridLookUpEditCustHierLevel6Id.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCustHierLevel6Id.DisplayMember = "CustHierLevel6Name";
            this.repositoryItemGridLookUpEditCustHierLevel6Id.Name = "repositoryItemGridLookUpEditCustHierLevel6Id";
            this.repositoryItemGridLookUpEditCustHierLevel6Id.NullText = "";
            this.repositoryItemGridLookUpEditCustHierLevel6Id.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCustHierLevel6Id.ValueMember = "CustHierLevel6Id";
            this.repositoryItemGridLookUpEditCustHierLevel6Id.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustHierLevel6Id,
            this.colCustHierLevel6Name,
            this.colCustHierLevel5Id,
            this.colCustHierLevel5Name,
            this.colCustHierLevel4Id,
            this.colCustHierLevel4Name,
            this.colCustHierLevel3Id,
            this.colCustHierLevel3Name,
            this.colDistributionChannelId,
            this.colDistributionChannel});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCustHierLevel6Id
            // 
            this.colCustHierLevel6Id.FieldName = "CustHierLevel6Id";
            this.colCustHierLevel6Id.Name = "colCustHierLevel6Id";
            this.colCustHierLevel6Id.Visible = true;
            this.colCustHierLevel6Id.VisibleIndex = 0;
            // 
            // colCustHierLevel6Name
            // 
            this.colCustHierLevel6Name.FieldName = "CustHierLevel6Name";
            this.colCustHierLevel6Name.Name = "colCustHierLevel6Name";
            this.colCustHierLevel6Name.Visible = true;
            this.colCustHierLevel6Name.VisibleIndex = 1;
            // 
            // colCustHierLevel5Id
            // 
            this.colCustHierLevel5Id.FieldName = "CustHierLevel5Id";
            this.colCustHierLevel5Id.Name = "colCustHierLevel5Id";
            this.colCustHierLevel5Id.Visible = true;
            this.colCustHierLevel5Id.VisibleIndex = 2;
            // 
            // colCustHierLevel5Name
            // 
            this.colCustHierLevel5Name.FieldName = "CustHierLevel5Name";
            this.colCustHierLevel5Name.Name = "colCustHierLevel5Name";
            this.colCustHierLevel5Name.Visible = true;
            this.colCustHierLevel5Name.VisibleIndex = 3;
            // 
            // colCustHierLevel4Id
            // 
            this.colCustHierLevel4Id.FieldName = "CustHierLevel4Id";
            this.colCustHierLevel4Id.Name = "colCustHierLevel4Id";
            this.colCustHierLevel4Id.Visible = true;
            this.colCustHierLevel4Id.VisibleIndex = 4;
            // 
            // colCustHierLevel4Name
            // 
            this.colCustHierLevel4Name.FieldName = "CustHierLevel4Name";
            this.colCustHierLevel4Name.Name = "colCustHierLevel4Name";
            this.colCustHierLevel4Name.Visible = true;
            this.colCustHierLevel4Name.VisibleIndex = 5;
            // 
            // colCustHierLevel3Id
            // 
            this.colCustHierLevel3Id.FieldName = "CustHierLevel3Id";
            this.colCustHierLevel3Id.Name = "colCustHierLevel3Id";
            this.colCustHierLevel3Id.Visible = true;
            this.colCustHierLevel3Id.VisibleIndex = 6;
            // 
            // colCustHierLevel3Name
            // 
            this.colCustHierLevel3Name.FieldName = "CustHierLevel3Name";
            this.colCustHierLevel3Name.Name = "colCustHierLevel3Name";
            this.colCustHierLevel3Name.Visible = true;
            this.colCustHierLevel3Name.VisibleIndex = 7;
            // 
            // colDistributionChannelId
            // 
            this.colDistributionChannelId.FieldName = "DistributionChannelId";
            this.colDistributionChannelId.Name = "colDistributionChannelId";
            this.colDistributionChannelId.Visible = true;
            this.colDistributionChannelId.VisibleIndex = 8;
            // 
            // colDistributionChannel
            // 
            this.colDistributionChannel.FieldName = "DistributionChannel";
            this.colDistributionChannel.Name = "colDistributionChannel";
            this.colDistributionChannel.Visible = true;
            this.colDistributionChannel.VisibleIndex = 9;
            // 
            // repositoryItemGridLookUpEditCustomerTypeId
            // 
            this.repositoryItemGridLookUpEditCustomerTypeId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCustomerTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCustomerTypeId.DisplayMember = "CustomerType1";
            this.repositoryItemGridLookUpEditCustomerTypeId.Name = "repositoryItemGridLookUpEditCustomerTypeId";
            this.repositoryItemGridLookUpEditCustomerTypeId.NullText = "";
            this.repositoryItemGridLookUpEditCustomerTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCustomerTypeId.ValueMember = "CustomerTypeId";
            this.repositoryItemGridLookUpEditCustomerTypeId.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerTypeId,
            this.colCustomerType1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerTypeId
            // 
            this.colCustomerTypeId.FieldName = "CustomerTypeId";
            this.colCustomerTypeId.Name = "colCustomerTypeId";
            this.colCustomerTypeId.Visible = true;
            this.colCustomerTypeId.VisibleIndex = 0;
            // 
            // colCustomerType1
            // 
            this.colCustomerType1.FieldName = "CustomerType1";
            this.colCustomerType1.Name = "colCustomerType1";
            this.colCustomerType1.Visible = true;
            this.colCustomerType1.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEditCustomerType2Id
            // 
            this.repositoryItemGridLookUpEditCustomerType2Id.AutoHeight = false;
            this.repositoryItemGridLookUpEditCustomerType2Id.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCustomerType2Id.DisplayMember = "CustomerType21";
            this.repositoryItemGridLookUpEditCustomerType2Id.Name = "repositoryItemGridLookUpEditCustomerType2Id";
            this.repositoryItemGridLookUpEditCustomerType2Id.NullText = "";
            this.repositoryItemGridLookUpEditCustomerType2Id.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCustomerType2Id.ValueMember = "CustomerType2Id";
            this.repositoryItemGridLookUpEditCustomerType2Id.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerType2Id,
            this.colCustomerType21});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerType2Id
            // 
            this.colCustomerType2Id.FieldName = "CustomerType2Id";
            this.colCustomerType2Id.Name = "colCustomerType2Id";
            this.colCustomerType2Id.Visible = true;
            this.colCustomerType2Id.VisibleIndex = 0;
            // 
            // colCustomerType21
            // 
            this.colCustomerType21.FieldName = "CustomerType21";
            this.colCustomerType21.Name = "colCustomerType21";
            this.colCustomerType21.Visible = true;
            this.colCustomerType21.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEditCustomerGroupId
            // 
            this.repositoryItemGridLookUpEditCustomerGroupId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCustomerGroupId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCustomerGroupId.DisplayMember = "CustomerGroup1";
            this.repositoryItemGridLookUpEditCustomerGroupId.Name = "repositoryItemGridLookUpEditCustomerGroupId";
            this.repositoryItemGridLookUpEditCustomerGroupId.NullText = "";
            this.repositoryItemGridLookUpEditCustomerGroupId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCustomerGroupId.ValueMember = "CustomerGroupId";
            this.repositoryItemGridLookUpEditCustomerGroupId.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerGroupId,
            this.colCustomerGroup1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerGroupId
            // 
            this.colCustomerGroupId.FieldName = "CustomerGroupId";
            this.colCustomerGroupId.Name = "colCustomerGroupId";
            this.colCustomerGroupId.Visible = true;
            this.colCustomerGroupId.VisibleIndex = 0;
            // 
            // colCustomerGroup1
            // 
            this.colCustomerGroup1.FieldName = "CustomerGroup1";
            this.colCustomerGroup1.Name = "colCustomerGroup1";
            this.colCustomerGroup1.Visible = true;
            this.colCustomerGroup1.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEditSubchannelId
            // 
            this.repositoryItemGridLookUpEditSubchannelId.AutoHeight = false;
            this.repositoryItemGridLookUpEditSubchannelId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSubchannelId.DisplayMember = "SubchannelName";
            this.repositoryItemGridLookUpEditSubchannelId.Name = "repositoryItemGridLookUpEditSubchannelId";
            this.repositoryItemGridLookUpEditSubchannelId.NullText = "";
            this.repositoryItemGridLookUpEditSubchannelId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSubchannelId.ValueMember = "SubchannelId";
            this.repositoryItemGridLookUpEditSubchannelId.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubchannelId,
            this.colSubchannelName});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colSubchannelId
            // 
            this.colSubchannelId.FieldName = "SubchannelId";
            this.colSubchannelId.Name = "colSubchannelId";
            this.colSubchannelId.Visible = true;
            this.colSubchannelId.VisibleIndex = 0;
            // 
            // colSubchannelName
            // 
            this.colSubchannelName.FieldName = "SubchannelName";
            this.colSubchannelName.Name = "colSubchannelName";
            this.colSubchannelName.Visible = true;
            this.colSubchannelName.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEditCityId
            // 
            this.repositoryItemGridLookUpEditCityId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCityId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCityId.DisplayMember = "CityEnName";
            this.repositoryItemGridLookUpEditCityId.Name = "repositoryItemGridLookUpEditCityId";
            this.repositoryItemGridLookUpEditCityId.NullText = "";
            this.repositoryItemGridLookUpEditCityId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCityId.ValueMember = "CityId";
            this.repositoryItemGridLookUpEditCityId.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCityId,
            this.colCityEnName,
            this.colCityArName});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colCityId
            // 
            this.colCityId.FieldName = "CityId";
            this.colCityId.Name = "colCityId";
            this.colCityId.Visible = true;
            this.colCityId.VisibleIndex = 0;
            // 
            // colCityEnName
            // 
            this.colCityEnName.FieldName = "CityEnName";
            this.colCityEnName.Name = "colCityEnName";
            this.colCityEnName.Visible = true;
            this.colCityEnName.VisibleIndex = 1;
            // 
            // colCityArName
            // 
            this.colCityArName.FieldName = "CityArName";
            this.colCityArName.Name = "colCityArName";
            this.colCityArName.Visible = true;
            this.colCityArName.VisibleIndex = 2;
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
            // FinalDataEditorFrm
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
            this.Name = "FinalDataEditorFrm";
            this.Text = "Final Data";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Shown += new System.EventHandler(this.CustomerEditorFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustHierLevel6Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerType2Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerGroupId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubchannelId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCityId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditCreationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditCreationDate)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCustHierLevel6Id;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCustomerTypeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCustomerType2Id;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCustomerGroupId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSubchannelId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCityId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel6Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel6Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel5Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel5Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel4Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel4Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel3Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel3Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributionChannelId;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributionChannel;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType2Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType21;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubchannelId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubchannelName;
        private DevExpress.XtraGrid.Columns.GridColumn colCityId;
        private DevExpress.XtraGrid.Columns.GridColumn colCityEnName;
        private DevExpress.XtraGrid.Columns.GridColumn colCityArName;
        private DevExpress.Data.Linq.LinqServerModeSource LSMS;
        private DevExpress.XtraGrid.Columns.GridColumn colBilling_Document;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_Eh;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume_14;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume_13;
        private DevExpress.XtraGrid.Columns.GridColumn colValue_14;
        private DevExpress.XtraGrid.Columns.GridColumn colValue_13;
        private DevExpress.XtraGrid.Columns.GridColumn colCases_14;
        private DevExpress.XtraGrid.Columns.GridColumn colCases_13;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colNew_Cases;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colCases;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice_Point;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colPallet;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumer_price__Piece;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumer_price__Carton;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute_Number__system;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup_3;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup_2;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup_1;
        private DevExpress.XtraGrid.Columns.GridColumn colSDN_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colSDN__Custtype;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Type_STI;
        private DevExpress.XtraGrid.Columns.GridColumn colWeek_NCE;
        private DevExpress.XtraGrid.Columns.GridColumn colTrade_Price_Piece;
        private DevExpress.XtraGrid.Columns.GridColumn colTrade_Price_Carton;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice_Point_rang;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice_Increas;
        private DevExpress.XtraGrid.Columns.GridColumn colNew_Qu;
        private DevExpress.XtraGrid.Columns.GridColumn colVolum_Pice;
        private DevExpress.XtraGrid.Columns.GridColumn colVol;
        private DevExpress.XtraGrid.Columns.GridColumn colVolum;
        private DevExpress.XtraGrid.Columns.GridColumn colQuin;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colBase_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colBase_Base_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colName_3_Ar;
        private DevExpress.XtraGrid.Columns.GridColumn colName_1_Ar;
        private DevExpress.XtraGrid.Columns.GridColumn colYear_C;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Type_2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group;
        private DevExpress.XtraGrid.Columns.GridColumn colSubchannel;
        private DevExpress.XtraGrid.Columns.GridColumn colL6_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHier_Level_6;
        private DevExpress.XtraGrid.Columns.GridColumn colL5_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHier_Level_5;
        private DevExpress.XtraGrid.Columns.GridColumn colL4_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHier_Level_4;
        private DevExpress.XtraGrid.Columns.GridColumn colL3_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHier_Level_3;
        private DevExpress.XtraGrid.Columns.GridColumn colName_3_En;
        private DevExpress.XtraGrid.Columns.GridColumn colName_1_En;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand_Route;
        private DevExpress.XtraGrid.Columns.GridColumn colSupervisor;
        private DevExpress.XtraGrid.Columns.GridColumn colASM;
        private DevExpress.XtraGrid.Columns.GridColumn colRSM;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_District;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_District_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colDay_Month;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colDay;
        private DevExpress.XtraGrid.Columns.GridColumn colWeek;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_LD;
        private DevExpress.XtraGrid.Columns.GridColumn colMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnex_rate;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnex;
        private DevExpress.XtraGrid.Columns.GridColumn colNew_Quanteite;
        private DevExpress.XtraGrid.Columns.GridColumn colyeard;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute___Sold;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_value;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_base_value;
        private DevExpress.XtraGrid.Columns.GridColumn colActual_Invoiced_Quan;
        private DevExpress.XtraGrid.Columns.GridColumn colG_L_Account_Number;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_type;
        private DevExpress.XtraGrid.Columns.GridColumn colPlant;
        private DevExpress.XtraGrid.Columns.GridColumn colBase_Unit_of_Measure;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_unit;
        private DevExpress.XtraGrid.Columns.GridColumn colBilling_item;
        private DevExpress.XtraGrid.Columns.GridColumn colReference_Document_N;
        private DevExpress.XtraGrid.Columns.GridColumn colPayer;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_Organization;
        private DevExpress.XtraGrid.Columns.GridColumn colBilling_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial_Number;
        private DevExpress.XtraGrid.Columns.GridColumn colBilling_date_for_bil;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute;
        private DevExpress.XtraGrid.Columns.GridColumn colSold_to_party;
        private DevExpress.XtraGrid.Columns.GridColumn colDistribution_Channel;
        private DevExpress.XtraGrid.Columns.GridColumn colTPP;
        private DevExpress.XtraGrid.Columns.GridColumn colSales;
        private DevExpress.XtraGrid.Columns.GridColumn colBase_New;
        private DevExpress.XtraGrid.Columns.GridColumn colLevel_CCSD;
        private DevExpress.XtraGrid.Columns.GridColumn colFRZ_brand;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand_Rang;
        private DevExpress.XtraGrid.Columns.GridColumn col_SDN_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_District_2;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoKey;
    }
}