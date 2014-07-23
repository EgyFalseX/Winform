namespace TinyShop.Forms.Query
{
    partial class QryBillsDetailsFrm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.qryBillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTinyData = new TinyShop.DataSources.dsTinyData();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditBillTypeID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.billTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditProductID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBillName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUserID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colEditDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPersonIDCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemMemoExEditInfo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemLookUpEditPersonIDSupplier = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryBillDetailsTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.QryBillDetailsTableAdapter();
            this.billTypesTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.BillTypesTableAdapter();
            this.customersTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.CustomersTableAdapter();
            this.suppliersTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.SuppliersTableAdapter();
            this.usersTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.UsersTableAdapter();
            this.productsTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryBillDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBillTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPersonIDCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPersonIDSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.qryBillDetailsBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditBillTypeID,
            this.repositoryItemLookUpEditPersonIDCustomer,
            this.repositoryItemMemoExEditInfo,
            this.repositoryItemLookUpEditUserID,
            this.repositoryItemLookUpEditPersonIDSupplier,
            this.repositoryItemDateEditDMY,
            this.repositoryItemLookUpEditProductID});
            this.gridControlData.Size = new System.Drawing.Size(742, 423);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // qryBillDetailsBindingSource
            // 
            this.qryBillDetailsBindingSource.DataMember = "QryBillDetails";
            this.qryBillDetailsBindingSource.DataSource = this.dsTinyData;
            // 
            // dsTinyData
            // 
            this.dsTinyData.DataSetName = "dsTinyData";
            this.dsTinyData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewData.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewData.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewData.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewData.Appearance.Row.Options.UseFont = true;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillTypeID,
            this.colProductID,
            this.colQuantity,
            this.colUnitPrice,
            this.gridColumnTotal,
            this.colBillNo,
            this.colBillDate,
            this.colBillName,
            this.colPersonName,
            this.colUserID,
            this.colEditDate});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridViewData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumnTotal", this.gridColumnTotal, "")});
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.SummariesIgnoreNullValues = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.RowAutoHeight = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBillDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colBillTypeID
            // 
            this.colBillTypeID.AppearanceCell.Options.UseTextOptions = true;
            this.colBillTypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillTypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeID.Caption = "نوع الفاتورة";
            this.colBillTypeID.ColumnEdit = this.repositoryItemLookUpEditBillTypeID;
            this.colBillTypeID.FieldName = "BillTypeID";
            this.colBillTypeID.Name = "colBillTypeID";
            this.colBillTypeID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BillTypeID", "{0}")});
            this.colBillTypeID.Visible = true;
            this.colBillTypeID.VisibleIndex = 0;
            this.colBillTypeID.Width = 88;
            // 
            // repositoryItemLookUpEditBillTypeID
            // 
            this.repositoryItemLookUpEditBillTypeID.AutoHeight = false;
            this.repositoryItemLookUpEditBillTypeID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditBillTypeID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BillTypeName", "النوع", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditBillTypeID.DataSource = this.billTypesBindingSource;
            this.repositoryItemLookUpEditBillTypeID.DisplayMember = "BillTypeName";
            this.repositoryItemLookUpEditBillTypeID.Name = "repositoryItemLookUpEditBillTypeID";
            this.repositoryItemLookUpEditBillTypeID.NullText = "";
            this.repositoryItemLookUpEditBillTypeID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditBillTypeID.ValueMember = "BillTypeID";
            // 
            // billTypesBindingSource
            // 
            this.billTypesBindingSource.DataMember = "BillTypes";
            this.billTypesBindingSource.DataSource = this.dsTinyData;
            // 
            // colProductID
            // 
            this.colProductID.AppearanceCell.Options.UseTextOptions = true;
            this.colProductID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductID.Caption = "المنتج";
            this.colProductID.ColumnEdit = this.repositoryItemLookUpEditProductID;
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 3;
            this.colProductID.Width = 153;
            // 
            // repositoryItemLookUpEditProductID
            // 
            this.repositoryItemLookUpEditProductID.AutoHeight = false;
            this.repositoryItemLookUpEditProductID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditProductID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "الصنف", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditProductID.DataSource = this.productsBindingSource;
            this.repositoryItemLookUpEditProductID.DisplayMember = "ProductName";
            this.repositoryItemLookUpEditProductID.Name = "repositoryItemLookUpEditProductID";
            this.repositoryItemLookUpEditProductID.NullText = "";
            this.repositoryItemLookUpEditProductID.ValueMember = "ProductID";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dsTinyData;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "الكمية";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.Caption = "السعر";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnTotal.Caption = "المجموع";
            this.gridColumnTotal.FieldName = "gridColumnTotal";
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumnTotal.UnboundExpression = "[UnitPrice] * [Quantity]";
            this.gridColumnTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 7;
            // 
            // colBillNo
            // 
            this.colBillNo.AppearanceCell.Options.UseTextOptions = true;
            this.colBillNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillNo.Caption = "رقم الفاتورة";
            this.colBillNo.FieldName = "BillNo";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.Visible = true;
            this.colBillNo.VisibleIndex = 1;
            // 
            // colBillDate
            // 
            this.colBillDate.AppearanceCell.Options.UseTextOptions = true;
            this.colBillDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillDate.Caption = "تاريخ الفاتورة";
            this.colBillDate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colBillDate.FieldName = "BillDate";
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.Visible = true;
            this.colBillDate.VisibleIndex = 2;
            this.colBillDate.Width = 101;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEditDMY.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colBillName
            // 
            this.colBillName.AppearanceCell.Options.UseTextOptions = true;
            this.colBillName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillName.Caption = "اسم الافاتورة";
            this.colBillName.FieldName = "BillName";
            this.colBillName.Name = "colBillName";
            this.colBillName.Width = 94;
            // 
            // colPersonName
            // 
            this.colPersonName.AppearanceCell.Options.UseTextOptions = true;
            this.colPersonName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonName.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonName.Caption = "الشخص";
            this.colPersonName.FieldName = "PersonName";
            this.colPersonName.Name = "colPersonName";
            this.colPersonName.Visible = true;
            this.colPersonName.VisibleIndex = 4;
            this.colPersonName.Width = 123;
            // 
            // colUserID
            // 
            this.colUserID.AppearanceCell.Options.UseTextOptions = true;
            this.colUserID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserID.Caption = "المستخدم";
            this.colUserID.ColumnEdit = this.repositoryItemLookUpEditUserID;
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            // 
            // repositoryItemLookUpEditUserID
            // 
            this.repositoryItemLookUpEditUserID.AutoHeight = false;
            this.repositoryItemLookUpEditUserID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "الاسم")});
            this.repositoryItemLookUpEditUserID.DataSource = this.usersBindingSource;
            this.repositoryItemLookUpEditUserID.DisplayMember = "UserName";
            this.repositoryItemLookUpEditUserID.Name = "repositoryItemLookUpEditUserID";
            this.repositoryItemLookUpEditUserID.NullText = "";
            this.repositoryItemLookUpEditUserID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditUserID.ValueMember = "UserID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsTinyData;
            // 
            // colEditDate
            // 
            this.colEditDate.AppearanceCell.Options.UseTextOptions = true;
            this.colEditDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEditDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colEditDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEditDate.Caption = "تاريخ الادخال";
            this.colEditDate.FieldName = "EditDate";
            this.colEditDate.Name = "colEditDate";
            this.colEditDate.Width = 94;
            // 
            // repositoryItemLookUpEditPersonIDCustomer
            // 
            this.repositoryItemLookUpEditPersonIDCustomer.AutoHeight = false;
            this.repositoryItemLookUpEditPersonIDCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPersonIDCustomer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditPersonIDCustomer.DataSource = this.customersBindingSource;
            this.repositoryItemLookUpEditPersonIDCustomer.DisplayMember = "CustomerName";
            this.repositoryItemLookUpEditPersonIDCustomer.Name = "repositoryItemLookUpEditPersonIDCustomer";
            this.repositoryItemLookUpEditPersonIDCustomer.NullText = "";
            this.repositoryItemLookUpEditPersonIDCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditPersonIDCustomer.ValueMember = "CustomerID";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dsTinyData;
            // 
            // repositoryItemMemoExEditInfo
            // 
            this.repositoryItemMemoExEditInfo.AutoHeight = false;
            this.repositoryItemMemoExEditInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditInfo.Name = "repositoryItemMemoExEditInfo";
            // 
            // repositoryItemLookUpEditPersonIDSupplier
            // 
            this.repositoryItemLookUpEditPersonIDSupplier.AutoHeight = false;
            this.repositoryItemLookUpEditPersonIDSupplier.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPersonIDSupplier.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplierName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditPersonIDSupplier.DataSource = this.suppliersBindingSource;
            this.repositoryItemLookUpEditPersonIDSupplier.DisplayMember = "supplierName";
            this.repositoryItemLookUpEditPersonIDSupplier.Name = "repositoryItemLookUpEditPersonIDSupplier";
            this.repositoryItemLookUpEditPersonIDSupplier.NullText = "";
            this.repositoryItemLookUpEditPersonIDSupplier.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditPersonIDSupplier.ValueMember = "SupplierID";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.dsTinyData;
            // 
            // qryBillDetailsTableAdapter
            // 
            this.qryBillDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // billTypesTableAdapter
            // 
            this.billTypesTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // QryBillsDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.gridControlData);
            this.Name = "QryBillsDetailsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تفاضيل الفواتير";
            this.Load += new System.EventHandler(this.QryBillsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryBillDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBillTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPersonIDCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPersonIDSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditBillTypeID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPersonIDCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPersonIDSupplier;
        private DataSources.dsTinyData dsTinyData;
        private System.Windows.Forms.BindingSource qryBillDetailsBindingSource;
        private DataSources.dsTinyDataTableAdapters.QryBillDetailsTableAdapter qryBillDetailsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBillTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colBillNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBillName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colEditDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotal;
        private System.Windows.Forms.BindingSource billTypesBindingSource;
        private DataSources.dsTinyDataTableAdapters.BillTypesTableAdapter billTypesTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSources.dsTinyDataTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private DataSources.dsTinyDataTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSources.dsTinyDataTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditProductID;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DataSources.dsTinyDataTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonName;
    }
}