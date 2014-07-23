namespace NestleICSales.Forms.Data
{
    partial class RouteEditorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteEditorFrm));
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
            this.colRouteNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditPlantSalesDistrictId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSPlantSalesDistrictId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPlantSalesDistrictId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlantSalesDistrict1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlantSapName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlantType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlantTypeBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupervisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRSM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditRouteBrandId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSRouteBrandId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRouteBrandId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteBrand1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditRouteStatusId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSRouteStatusId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRouteStatusId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescriptions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditDesc = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditPlantSalesDistrictId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSPlantSalesDistrictId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRouteBrandId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRouteBrandId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRouteStatusId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRouteStatusId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
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
            this.bbiExport.Glyph = global::NestleICSales.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(855, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 286);
            this.barDockControlBottom.Size = new System.Drawing.Size(855, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(855, 31);
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
            this.repositoryItemMemoExEditDesc,
            this.repositoryItemGridLookUpEditPlantSalesDistrictId,
            this.repositoryItemGridLookUpEditRouteBrandId,
            this.repositoryItemGridLookUpEditRouteStatusId});
            this.gridControlMain.Size = new System.Drawing.Size(855, 255);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRouteNumber,
            this.colRouteName,
            this.gridColumn2,
            this.colSupervisor,
            this.colASM,
            this.colRSM,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn8,
            this.colDescriptions});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CustomerId", null, "")});
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
            // colRouteNumber
            // 
            this.colRouteNumber.Caption = "Route Number";
            this.colRouteNumber.FieldName = "RouteNumber";
            this.colRouteNumber.Name = "colRouteNumber";
            this.colRouteNumber.Visible = true;
            this.colRouteNumber.VisibleIndex = 0;
            this.colRouteNumber.Width = 80;
            // 
            // colRouteName
            // 
            this.colRouteName.Caption = "Route Name";
            this.colRouteName.FieldName = "RouteName";
            this.colRouteName.Name = "colRouteName";
            this.colRouteName.Visible = true;
            this.colRouteName.VisibleIndex = 1;
            this.colRouteName.Width = 78;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Plant Sales District";
            this.gridColumn2.ColumnEdit = this.repositoryItemGridLookUpEditPlantSalesDistrictId;
            this.gridColumn2.FieldName = "PlantSalesDistrictId!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 104;
            // 
            // repositoryItemGridLookUpEditPlantSalesDistrictId
            // 
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.AutoHeight = false;
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.DataSource = this.LSMSPlantSalesDistrictId;
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.DisplayMember = "PlantSalesDistrict1";
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.Name = "repositoryItemGridLookUpEditPlantSalesDistrictId";
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.NullText = "";
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.ValueMember = "PlantSalesDistrictId";
            this.repositoryItemGridLookUpEditPlantSalesDistrictId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // LSMSPlantSalesDistrictId
            // 
            this.LSMSPlantSalesDistrictId.ElementType = typeof(NestleICSales.DataSources.Linq.PlantSalesDistrict);
            this.LSMSPlantSalesDistrictId.KeyExpression = "PlantSalesDistrictId";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPlantSalesDistrictId,
            this.colPlantSalesDistrict1,
            this.colPlantName,
            this.colPlantSapName,
            this.colPlantType,
            this.colPlantTypeBase});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPlantSalesDistrictId
            // 
            this.colPlantSalesDistrictId.Caption = "Plant Sales District Id";
            this.colPlantSalesDistrictId.FieldName = "PlantSalesDistrictId";
            this.colPlantSalesDistrictId.Name = "colPlantSalesDistrictId";
            this.colPlantSalesDistrictId.Visible = true;
            this.colPlantSalesDistrictId.VisibleIndex = 0;
            // 
            // colPlantSalesDistrict1
            // 
            this.colPlantSalesDistrict1.Caption = "Plant Sales District";
            this.colPlantSalesDistrict1.FieldName = "PlantSalesDistrict1";
            this.colPlantSalesDistrict1.Name = "colPlantSalesDistrict1";
            this.colPlantSalesDistrict1.Visible = true;
            this.colPlantSalesDistrict1.VisibleIndex = 1;
            // 
            // colPlantName
            // 
            this.colPlantName.Caption = "PlantName";
            this.colPlantName.FieldName = "Plant.PlantName";
            this.colPlantName.Name = "colPlantName";
            this.colPlantName.Visible = true;
            this.colPlantName.VisibleIndex = 2;
            // 
            // colPlantSapName
            // 
            this.colPlantSapName.Caption = "PlantSapNo";
            this.colPlantSapName.FieldName = "Plant.SapName";
            this.colPlantSapName.Name = "colPlantSapName";
            this.colPlantSapName.Visible = true;
            this.colPlantSapName.VisibleIndex = 4;
            // 
            // colPlantType
            // 
            this.colPlantType.Caption = "Plant Type";
            this.colPlantType.FieldName = "PlantType.PlantType1";
            this.colPlantType.Name = "colPlantType";
            this.colPlantType.Visible = true;
            this.colPlantType.VisibleIndex = 3;
            // 
            // colPlantTypeBase
            // 
            this.colPlantTypeBase.Caption = "Plant Type Base";
            this.colPlantTypeBase.FieldName = "PlantType.PlantTypeBase.PlantTypeBase1";
            this.colPlantTypeBase.Name = "colPlantTypeBase";
            this.colPlantTypeBase.Visible = true;
            this.colPlantTypeBase.VisibleIndex = 5;
            // 
            // colSupervisor
            // 
            this.colSupervisor.Caption = "Supervisor";
            this.colSupervisor.FieldName = "Supervisor";
            this.colSupervisor.Name = "colSupervisor";
            this.colSupervisor.Visible = true;
            this.colSupervisor.VisibleIndex = 3;
            // 
            // colASM
            // 
            this.colASM.Caption = "ASM";
            this.colASM.FieldName = "ASM";
            this.colASM.Name = "colASM";
            this.colASM.Visible = true;
            this.colASM.VisibleIndex = 4;
            this.colASM.Width = 43;
            // 
            // colRSM
            // 
            this.colRSM.Caption = "RSM";
            this.colRSM.FieldName = "RSM";
            this.colRSM.Name = "colRSM";
            this.colRSM.Visible = true;
            this.colRSM.VisibleIndex = 5;
            this.colRSM.Width = 34;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Route Brand";
            this.gridColumn4.ColumnEdit = this.repositoryItemGridLookUpEditRouteBrandId;
            this.gridColumn4.FieldName = "RouteBrandId!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 77;
            // 
            // repositoryItemGridLookUpEditRouteBrandId
            // 
            this.repositoryItemGridLookUpEditRouteBrandId.AutoHeight = false;
            this.repositoryItemGridLookUpEditRouteBrandId.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemGridLookUpEditRouteBrandId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditRouteBrandId.DataSource = this.LSMSRouteBrandId;
            this.repositoryItemGridLookUpEditRouteBrandId.DisplayMember = "RouteBrand1";
            this.repositoryItemGridLookUpEditRouteBrandId.Name = "repositoryItemGridLookUpEditRouteBrandId";
            this.repositoryItemGridLookUpEditRouteBrandId.NullText = "";
            this.repositoryItemGridLookUpEditRouteBrandId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditRouteBrandId.ValueMember = "RouteBrandId";
            this.repositoryItemGridLookUpEditRouteBrandId.View = this.gridView1;
            // 
            // LSMSRouteBrandId
            // 
            this.LSMSRouteBrandId.ElementType = typeof(NestleICSales.DataSources.Linq.RouteBrand);
            this.LSMSRouteBrandId.KeyExpression = "RouteBrandId";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRouteBrandId,
            this.colRouteBrand1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colRouteBrandId
            // 
            this.colRouteBrandId.Caption = "Route Brand Id";
            this.colRouteBrandId.FieldName = "RouteBrandId";
            this.colRouteBrandId.Name = "colRouteBrandId";
            this.colRouteBrandId.Visible = true;
            this.colRouteBrandId.VisibleIndex = 0;
            // 
            // colRouteBrand1
            // 
            this.colRouteBrand1.Caption = "Route Brand";
            this.colRouteBrand1.FieldName = "RouteBrand1";
            this.colRouteBrand1.Name = "colRouteBrand1";
            this.colRouteBrand1.Visible = true;
            this.colRouteBrand1.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Route Brand Old";
            this.gridColumn6.ColumnEdit = this.repositoryItemGridLookUpEditRouteBrandId;
            this.gridColumn6.FieldName = "RouteBrandIdOld!Key";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 89;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Route Status";
            this.gridColumn8.ColumnEdit = this.repositoryItemGridLookUpEditRouteStatusId;
            this.gridColumn8.FieldName = "RouteStatusId!Key";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 78;
            // 
            // repositoryItemGridLookUpEditRouteStatusId
            // 
            this.repositoryItemGridLookUpEditRouteStatusId.AutoHeight = false;
            this.repositoryItemGridLookUpEditRouteStatusId.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemGridLookUpEditRouteStatusId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditRouteStatusId.DataSource = this.LSMSRouteStatusId;
            this.repositoryItemGridLookUpEditRouteStatusId.DisplayMember = "RouteStatus1";
            this.repositoryItemGridLookUpEditRouteStatusId.Name = "repositoryItemGridLookUpEditRouteStatusId";
            this.repositoryItemGridLookUpEditRouteStatusId.NullText = "";
            this.repositoryItemGridLookUpEditRouteStatusId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditRouteStatusId.ValueMember = "RouteStatusId";
            this.repositoryItemGridLookUpEditRouteStatusId.View = this.gridView2;
            // 
            // LSMSRouteStatusId
            // 
            this.LSMSRouteStatusId.ElementType = typeof(NestleICSales.DataSources.Linq.RouteStatus);
            this.LSMSRouteStatusId.KeyExpression = "RouteStatusId";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRouteStatusId,
            this.colRouteStatus1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colRouteStatusId
            // 
            this.colRouteStatusId.Caption = "Route Status Id";
            this.colRouteStatusId.FieldName = "RouteStatusId";
            this.colRouteStatusId.Name = "colRouteStatusId";
            this.colRouteStatusId.Visible = true;
            this.colRouteStatusId.VisibleIndex = 0;
            // 
            // colRouteStatus1
            // 
            this.colRouteStatus1.Caption = "Route Status";
            this.colRouteStatus1.FieldName = "RouteStatus1";
            this.colRouteStatus1.Name = "colRouteStatus1";
            this.colRouteStatus1.Visible = true;
            this.colRouteStatus1.VisibleIndex = 1;
            // 
            // colDescriptions
            // 
            this.colDescriptions.Caption = "Description";
            this.colDescriptions.ColumnEdit = this.repositoryItemMemoExEditDesc;
            this.colDescriptions.FieldName = "Descriptions";
            this.colDescriptions.Name = "colDescriptions";
            this.colDescriptions.Visible = true;
            this.colDescriptions.VisibleIndex = 9;
            this.colDescriptions.Width = 77;
            // 
            // repositoryItemMemoExEditDesc
            // 
            this.repositoryItemMemoExEditDesc.AutoHeight = false;
            this.repositoryItemMemoExEditDesc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditDesc.Name = "repositoryItemMemoExEditDesc";
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NestleICSales.DataSources.dsData.RoutesDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            // 
            // RouteEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 286);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RouteEditorFrm";
            this.Text = "Route";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Shown += new System.EventHandler(this.CustomerEditorFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditPlantSalesDistrictId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSPlantSalesDistrictId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRouteBrandId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRouteBrandId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRouteStatusId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRouteStatusId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
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
        private DevExpress.Data.Linq.LinqServerModeSource LSMSPlantSalesDistrictId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSRouteBrandId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSRouteStatusId;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditPlantSalesDistrictId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSupervisor;
        private DevExpress.XtraGrid.Columns.GridColumn colASM;
        private DevExpress.XtraGrid.Columns.GridColumn colRSM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRouteBrandId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRouteStatusId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriptions;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colPlantSalesDistrictId;
        private DevExpress.XtraGrid.Columns.GridColumn colPlantSalesDistrict1;
        private DevExpress.XtraGrid.Columns.GridColumn colPlantName;
        private DevExpress.XtraGrid.Columns.GridColumn colPlantType;
        private DevExpress.XtraGrid.Columns.GridColumn colPlantSapName;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteBrandId;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteBrand1;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteStatusId;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteStatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colPlantTypeBase;
    }
}