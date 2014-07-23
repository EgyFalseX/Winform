namespace NestleMenu.Forms.Code
{
    partial class Qry002Frm
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
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiStartDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiEndDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bbiGetData = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dsNUQry = new NestleMenu.DataSources.dsNUQry();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.qry001TableAdapter = new NestleMenu.DataSources.dsNUQryTableAdapters.Qry001TableAdapter();
            this.qry001BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShowPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMenuOrderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuSizeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuThemeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShowLogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliverydate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderSupervisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductBaseName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNUQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry001BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
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
            this.bbiExport,
            this.bbiStartDate,
            this.barHeaderItem1,
            this.barHeaderItem2,
            this.bbiEndDate,
            this.bbiGetData});
            this.barManagerMain.MaxItemId = 10;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStartDate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEndDate),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiGetData, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Start Date";
            this.barHeaderItem1.Id = 3;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // bbiStartDate
            // 
            this.bbiStartDate.Caption = "bbiDateFrom";
            this.bbiStartDate.Edit = this.repositoryItemDateEdit1;
            this.bbiStartDate.Id = 2;
            this.bbiStartDate.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1));
            this.bbiStartDate.Name = "bbiStartDate";
            this.bbiStartDate.Width = 120;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "End Date";
            this.barHeaderItem2.Id = 5;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // bbiEndDate
            // 
            this.bbiEndDate.Caption = "barEditItem3";
            this.bbiEndDate.Edit = this.repositoryItemDateEdit2;
            this.bbiEndDate.Id = 7;
            this.bbiEndDate.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2));
            this.bbiEndDate.Name = "bbiEndDate";
            this.bbiEndDate.Width = 120;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // bbiGetData
            // 
            this.bbiGetData.Caption = "Get Data";
            this.bbiGetData.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbiGetData.Glyph = global::NestleMenu.Properties.Resources.apply_16x16;
            this.bbiGetData.Id = 9;
            this.bbiGetData.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.bbiGetData.Name = "bbiGetData";
            this.bbiGetData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGetData_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NestleMenu.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(884, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 286);
            this.barDockControlBottom.Size = new System.Drawing.Size(884, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(884, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 255);
            // 
            // dsNUQry
            // 
            this.dsNUQry.DataSetName = "dsNUQry";
            this.dsNUQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qry001TableAdapter
            // 
            this.qry001TableAdapter.ClearBeforeFill = true;
            // 
            // qry001BindingSource
            // 
            this.qry001BindingSource.DataMember = "Qry001";
            this.qry001BindingSource.DataSource = this.dsNUQry;
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataMember = "Qry001";
            this.gridControlMain.DataSource = this.dsNUQry;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit3});
            this.gridControlMain.Size = new System.Drawing.Size(884, 255);
            this.gridControlMain.TabIndex = 14;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrice,
            this.colShowPrice,
            this.colMenuOrderName,
            this.colMenuOrderDate,
            this.colBranchName,
            this.colCustomerName,
            this.colMenuSizeName,
            this.colMenuThemeName,
            this.colShowLogo,
            this.colOrderCount,
            this.colDeliverydate,
            this.colOrderSupervisor,
            this.colProductName,
            this.colProductBaseName});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.ReadOnly = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 6;
            // 
            // colShowPrice
            // 
            this.colShowPrice.Caption = "Show Price";
            this.colShowPrice.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colShowPrice.FieldName = "ShowPrice";
            this.colShowPrice.Name = "colShowPrice";
            this.colShowPrice.Visible = true;
            this.colShowPrice.VisibleIndex = 7;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colMenuOrderName
            // 
            this.colMenuOrderName.Caption = "Menu Name";
            this.colMenuOrderName.FieldName = "MenuOrderName";
            this.colMenuOrderName.Name = "colMenuOrderName";
            this.colMenuOrderName.OptionsColumn.ReadOnly = true;
            this.colMenuOrderName.Visible = true;
            this.colMenuOrderName.VisibleIndex = 1;
            this.colMenuOrderName.Width = 106;
            // 
            // colMenuOrderDate
            // 
            this.colMenuOrderDate.Caption = "Menu Date";
            this.colMenuOrderDate.ColumnEdit = this.repositoryItemDateEdit3;
            this.colMenuOrderDate.FieldName = "MenuOrderDate";
            this.colMenuOrderDate.Name = "colMenuOrderDate";
            this.colMenuOrderDate.OptionsColumn.ReadOnly = true;
            this.colMenuOrderDate.Visible = true;
            this.colMenuOrderDate.VisibleIndex = 0;
            this.colMenuOrderDate.Width = 102;
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "Branch";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.OptionsColumn.ReadOnly = true;
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 3;
            this.colBranchName.Width = 82;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Customer";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 95;
            // 
            // colMenuSizeName
            // 
            this.colMenuSizeName.Caption = "Menu Size";
            this.colMenuSizeName.FieldName = "MenuSizeName";
            this.colMenuSizeName.Name = "colMenuSizeName";
            this.colMenuSizeName.OptionsColumn.ReadOnly = true;
            this.colMenuSizeName.Visible = true;
            this.colMenuSizeName.VisibleIndex = 8;
            this.colMenuSizeName.Width = 97;
            // 
            // colMenuThemeName
            // 
            this.colMenuThemeName.Caption = "Menu Theme";
            this.colMenuThemeName.FieldName = "MenuThemeName";
            this.colMenuThemeName.Name = "colMenuThemeName";
            this.colMenuThemeName.OptionsColumn.ReadOnly = true;
            this.colMenuThemeName.Visible = true;
            this.colMenuThemeName.VisibleIndex = 9;
            this.colMenuThemeName.Width = 110;
            // 
            // colShowLogo
            // 
            this.colShowLogo.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colShowLogo.FieldName = "ShowLogo";
            this.colShowLogo.Name = "colShowLogo";
            this.colShowLogo.OptionsColumn.ReadOnly = true;
            this.colShowLogo.Visible = true;
            this.colShowLogo.VisibleIndex = 10;
            // 
            // colOrderCount
            // 
            this.colOrderCount.Caption = "Menu Count";
            this.colOrderCount.FieldName = "OrderCount";
            this.colOrderCount.Name = "colOrderCount";
            this.colOrderCount.OptionsColumn.ReadOnly = true;
            this.colOrderCount.Visible = true;
            this.colOrderCount.VisibleIndex = 11;
            this.colOrderCount.Width = 79;
            // 
            // colDeliverydate
            // 
            this.colDeliverydate.Caption = "Delivery Date";
            this.colDeliverydate.ColumnEdit = this.repositoryItemDateEdit3;
            this.colDeliverydate.FieldName = "Deliverydate";
            this.colDeliverydate.Name = "colDeliverydate";
            this.colDeliverydate.OptionsColumn.ReadOnly = true;
            this.colDeliverydate.Visible = true;
            this.colDeliverydate.VisibleIndex = 12;
            this.colDeliverydate.Width = 84;
            // 
            // colOrderSupervisor
            // 
            this.colOrderSupervisor.FieldName = "OrderSupervisor";
            this.colOrderSupervisor.Name = "colOrderSupervisor";
            this.colOrderSupervisor.OptionsColumn.ReadOnly = true;
            this.colOrderSupervisor.Visible = true;
            this.colOrderSupervisor.VisibleIndex = 13;
            this.colOrderSupervisor.Width = 101;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 5;
            this.colProductName.Width = 86;
            // 
            // colProductBaseName
            // 
            this.colProductBaseName.Caption = "Product Base";
            this.colProductBaseName.FieldName = "ProductBaseName";
            this.colProductBaseName.Name = "colProductBaseName";
            this.colProductBaseName.OptionsColumn.ReadOnly = true;
            this.colProductBaseName.Visible = true;
            this.colProductBaseName.VisibleIndex = 4;
            this.colProductBaseName.Width = 112;
            // 
            // Qry002Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 286);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = global::NestleMenu.Properties.Resources.Qry16;
            this.Name = "Qry002Frm";
            this.Text = "Menu Order Pivot";
            this.Load += new System.EventHandler(this.JobEditorFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNUQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry001BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarEditItem bbiStartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarEditItem bbiEndDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarLargeButtonItem bbiGetData;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DataSources.dsNUQry dsNUQry;
        private DataSources.dsNUQryTableAdapters.Qry001TableAdapter qry001TableAdapter;
        private System.Windows.Forms.BindingSource qry001BindingSource;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colShowPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuOrderName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuSizeName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuThemeName;
        private DevExpress.XtraGrid.Columns.GridColumn colShowLogo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCount;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliverydate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderSupervisor;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductBaseName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
    }
}