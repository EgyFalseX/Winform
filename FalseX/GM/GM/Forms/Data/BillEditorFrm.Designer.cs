namespace GM.Forms.Code
{
    partial class BillEditorFrm
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
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.xpDSData = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionData = new DevExpress.Xpo.Session(this.components);
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillEndId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditEmployeeId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGM = new GM.DataSources.dsGM();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlumberId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditPlumberId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.plumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTraderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTraderId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.traderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTraderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colguaranteeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemGridLookUpEditGovId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGovName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new GM.DataSources.dsGMTableAdapters.BillTableAdapter();
            this.employeeTableAdapter = new GM.DataSources.dsGMTableAdapters.EmployeeTableAdapter();
            this.plumberTableAdapter = new GM.DataSources.dsGMTableAdapters.PlumberTableAdapter();
            this.traderTableAdapter = new GM.DataSources.dsGMTableAdapters.TraderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditEmployeeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditPlumberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTraderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditGovId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
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
            this.bbiNew,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Glyph = global::GM.Properties.Resources.New;
            this.bbiNew.Id = 0;
            this.bbiNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::GM.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1145, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 286);
            this.barDockControlBottom.Size = new System.Drawing.Size(1145, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1145, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 255);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.xpDSData;
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
            this.repositoryItemButtonEditEdit,
            this.repositoryItemButtonEditDelete,
            this.repositoryItemGridLookUpEditGovId,
            this.repositoryItemDateEdit1,
            this.repositoryItemGridLookUpEditEmployeeId,
            this.repositoryItemGridLookUpEditPlumberId,
            this.repositoryItemGridLookUpEditTraderId});
            this.gridControlMain.Size = new System.Drawing.Size(1145, 255);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // xpDSData
            // 
            this.xpDSData.ObjectType = typeof(GM.DataSources.dsGM.BillDataTable);
            this.xpDSData.Session = this.sessionData;
            // 
            // sessionData
            // 
            this.sessionData.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionData.TrackPropertiesModifications = true;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillId,
            this.colBillEndId,
            this.colBillDate,
            this.colEmployeeId,
            this.colPlumberId,
            this.colTraderId,
            this.colOwnerAddress,
            this.colOwnerName,
            this.colOwnerPhone,
            this.colCardValue,
            this.colguaranteeId,
            this.colNotes,
            this.gridColumnEdit,
            this.gridColumnDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colBillId
            // 
            this.colBillId.AppearanceCell.Options.UseTextOptions = true;
            this.colBillId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillId.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillId.Caption = "Bill ID";
            this.colBillId.FieldName = "BillId";
            this.colBillId.Name = "colBillId";
            this.colBillId.Visible = true;
            this.colBillId.VisibleIndex = 0;
            // 
            // colBillEndId
            // 
            this.colBillEndId.AppearanceCell.Options.UseTextOptions = true;
            this.colBillEndId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillEndId.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillEndId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillEndId.Caption = "Bill End";
            this.colBillEndId.FieldName = "BillEndId";
            this.colBillEndId.Name = "colBillEndId";
            this.colBillEndId.Visible = true;
            this.colBillEndId.VisibleIndex = 1;
            // 
            // colBillDate
            // 
            this.colBillDate.AppearanceCell.Options.UseTextOptions = true;
            this.colBillDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillDate.Caption = "Date";
            this.colBillDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colBillDate.FieldName = "BillDate";
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.Visible = true;
            this.colBillDate.VisibleIndex = 2;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "d/M/yyyy";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeId.Caption = "Employee";
            this.colEmployeeId.ColumnEdit = this.repositoryItemGridLookUpEditEmployeeId;
            this.colEmployeeId.FieldName = "EmployeeId!Key";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.Visible = true;
            this.colEmployeeId.VisibleIndex = 3;
            this.colEmployeeId.Width = 78;
            // 
            // repositoryItemGridLookUpEditEmployeeId
            // 
            this.repositoryItemGridLookUpEditEmployeeId.AutoHeight = false;
            this.repositoryItemGridLookUpEditEmployeeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditEmployeeId.DataSource = this.employeeBindingSource;
            this.repositoryItemGridLookUpEditEmployeeId.DisplayMember = "EmployeeName";
            this.repositoryItemGridLookUpEditEmployeeId.Name = "repositoryItemGridLookUpEditEmployeeId";
            this.repositoryItemGridLookUpEditEmployeeId.NullText = "";
            this.repositoryItemGridLookUpEditEmployeeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditEmployeeId.ValueMember = "EmployeeId";
            this.repositoryItemGridLookUpEditEmployeeId.View = this.gridView1;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dsGM;
            // 
            // dsGM
            // 
            this.dsGM.DataSetName = "dsGM";
            this.dsGM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeName.Caption = "الاسم";
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            // 
            // colPlumberId
            // 
            this.colPlumberId.AppearanceCell.Options.UseTextOptions = true;
            this.colPlumberId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberId.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlumberId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberId.Caption = "Plumber";
            this.colPlumberId.ColumnEdit = this.repositoryItemGridLookUpEditPlumberId;
            this.colPlumberId.FieldName = "PlumberId!Key";
            this.colPlumberId.Name = "colPlumberId";
            this.colPlumberId.Visible = true;
            this.colPlumberId.VisibleIndex = 4;
            // 
            // repositoryItemGridLookUpEditPlumberId
            // 
            this.repositoryItemGridLookUpEditPlumberId.AutoHeight = false;
            this.repositoryItemGridLookUpEditPlumberId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditPlumberId.DataSource = this.plumberBindingSource;
            this.repositoryItemGridLookUpEditPlumberId.DisplayMember = "PlumberName";
            this.repositoryItemGridLookUpEditPlumberId.Name = "repositoryItemGridLookUpEditPlumberId";
            this.repositoryItemGridLookUpEditPlumberId.NullText = "";
            this.repositoryItemGridLookUpEditPlumberId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditPlumberId.ValueMember = "PlumberId";
            this.repositoryItemGridLookUpEditPlumberId.View = this.gridView2;
            // 
            // plumberBindingSource
            // 
            this.plumberBindingSource.DataMember = "Plumber";
            this.plumberBindingSource.DataSource = this.dsGM;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "PlumberName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colTraderId
            // 
            this.colTraderId.AppearanceCell.Options.UseTextOptions = true;
            this.colTraderId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderId.AppearanceHeader.Options.UseTextOptions = true;
            this.colTraderId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderId.Caption = "Trader";
            this.colTraderId.ColumnEdit = this.repositoryItemGridLookUpEditTraderId;
            this.colTraderId.FieldName = "TraderId!Key";
            this.colTraderId.Name = "colTraderId";
            this.colTraderId.Visible = true;
            this.colTraderId.VisibleIndex = 5;
            // 
            // repositoryItemGridLookUpEditTraderId
            // 
            this.repositoryItemGridLookUpEditTraderId.AutoHeight = false;
            this.repositoryItemGridLookUpEditTraderId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditTraderId.DataSource = this.traderBindingSource;
            this.repositoryItemGridLookUpEditTraderId.DisplayMember = "TraderName";
            this.repositoryItemGridLookUpEditTraderId.Name = "repositoryItemGridLookUpEditTraderId";
            this.repositoryItemGridLookUpEditTraderId.NullText = "";
            this.repositoryItemGridLookUpEditTraderId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditTraderId.ValueMember = "TraderId";
            this.repositoryItemGridLookUpEditTraderId.View = this.gridView3;
            // 
            // traderBindingSource
            // 
            this.traderBindingSource.DataMember = "Trader";
            this.traderBindingSource.DataSource = this.dsGM;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTraderName});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colTraderName
            // 
            this.colTraderName.FieldName = "TraderName";
            this.colTraderName.Name = "colTraderName";
            this.colTraderName.Visible = true;
            this.colTraderName.VisibleIndex = 0;
            // 
            // colOwnerAddress
            // 
            this.colOwnerAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colOwnerAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colOwnerAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerAddress.Caption = "Owner Address";
            this.colOwnerAddress.FieldName = "OwnerAddress";
            this.colOwnerAddress.Name = "colOwnerAddress";
            this.colOwnerAddress.Visible = true;
            this.colOwnerAddress.VisibleIndex = 6;
            this.colOwnerAddress.Width = 93;
            // 
            // colOwnerName
            // 
            this.colOwnerName.AppearanceCell.Options.UseTextOptions = true;
            this.colOwnerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colOwnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerName.Caption = "Owner Name";
            this.colOwnerName.FieldName = "OwnerName";
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.Visible = true;
            this.colOwnerName.VisibleIndex = 7;
            this.colOwnerName.Width = 81;
            // 
            // colOwnerPhone
            // 
            this.colOwnerPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colOwnerPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colOwnerPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerPhone.Caption = "Owner Phone";
            this.colOwnerPhone.FieldName = "OwnerPhone";
            this.colOwnerPhone.Name = "colOwnerPhone";
            this.colOwnerPhone.Visible = true;
            this.colOwnerPhone.VisibleIndex = 8;
            this.colOwnerPhone.Width = 84;
            // 
            // colCardValue
            // 
            this.colCardValue.AppearanceCell.Options.UseTextOptions = true;
            this.colCardValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCardValue.AppearanceHeader.Options.UseTextOptions = true;
            this.colCardValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCardValue.Caption = "Card Value";
            this.colCardValue.FieldName = "CardValue";
            this.colCardValue.Name = "colCardValue";
            this.colCardValue.Visible = true;
            this.colCardValue.VisibleIndex = 9;
            // 
            // colguaranteeId
            // 
            this.colguaranteeId.AppearanceCell.Options.UseTextOptions = true;
            this.colguaranteeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colguaranteeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colguaranteeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colguaranteeId.Caption = "Guarantee Id";
            this.colguaranteeId.FieldName = "guaranteeId";
            this.colguaranteeId.Name = "colguaranteeId";
            this.colguaranteeId.Visible = true;
            this.colguaranteeId.VisibleIndex = 10;
            // 
            // colNotes
            // 
            this.colNotes.AppearanceCell.Options.UseTextOptions = true;
            this.colNotes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNotes.AppearanceHeader.Options.UseTextOptions = true;
            this.colNotes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNotes.Caption = "Notes";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 11;
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEdit.Caption = "Edit";
            this.gridColumnEdit.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 12;
            this.gridColumnEdit.Width = 89;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.Caption = "Delete";
            this.gridColumnDelete.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 13;
            this.gridColumnDelete.Width = 90;
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDelete_ButtonClick);
            // 
            // repositoryItemGridLookUpEditGovId
            // 
            this.repositoryItemGridLookUpEditGovId.AutoHeight = false;
            this.repositoryItemGridLookUpEditGovId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditGovId.DisplayMember = "GovName";
            this.repositoryItemGridLookUpEditGovId.Name = "repositoryItemGridLookUpEditGovId";
            this.repositoryItemGridLookUpEditGovId.NullText = "";
            this.repositoryItemGridLookUpEditGovId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditGovId.ValueMember = "GovId";
            this.repositoryItemGridLookUpEditGovId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGovName});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colGovName
            // 
            this.colGovName.AppearanceCell.Options.UseTextOptions = true;
            this.colGovName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGovName.AppearanceHeader.Options.UseTextOptions = true;
            this.colGovName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGovName.Caption = "GovName";
            this.colGovName.FieldName = "GovName";
            this.colGovName.Name = "colGovName";
            this.colGovName.Visible = true;
            this.colGovName.VisibleIndex = 0;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.dsGM;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // plumberTableAdapter
            // 
            this.plumberTableAdapter.ClearBeforeFill = true;
            // 
            // traderTableAdapter
            // 
            this.traderTableAdapter.ClearBeforeFill = true;
            // 
            // BillEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 286);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = global::GM.Properties.Resources.MenuOrder16;
            this.Name = "BillEditorFrm";
            this.Text = "Bill Editor";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditEmployeeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditPlumberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTraderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditGovId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DataSources.dsGM dsGM;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditGovId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colGovName;
        private System.Windows.Forms.BindingSource billBindingSource;
        private DataSources.dsGMTableAdapters.BillTableAdapter billTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colPlumberId;
        private DevExpress.XtraGrid.Columns.GridColumn colTraderId;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerName;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCardValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditEmployeeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.dsGMTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditPlumberId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource plumberBindingSource;
        private DataSources.dsGMTableAdapters.PlumberTableAdapter plumberTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colBillId;
        private DevExpress.XtraGrid.Columns.GridColumn colBillEndId;
        private DevExpress.XtraGrid.Columns.GridColumn colguaranteeId;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTraderId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource traderBindingSource;
        private DataSources.dsGMTableAdapters.TraderTableAdapter traderTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTraderName;
        private DevExpress.Xpo.XPServerCollectionSource xpDSData;
        private DevExpress.Xpo.Session sessionData;
    }
}