namespace TinyShop.Forms.Data
{
    partial class BillsEditorFrm
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
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTinyData = new TinyShop.DataSources.dsTinyData();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditBillTypeID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.billTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillTypeName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBillName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditInfo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemTextEditf2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEditn0 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemGridLookUpEditPersonIDCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPersonIDCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditPersonIDSuppllier = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPersonIDSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsupplierPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsupplierAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.billsTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.BillsTableAdapter();
            this.billTypesTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.BillTypesTableAdapter();
            this.colBillTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customersTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.CustomersTableAdapter();
            this.suppliersTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.SuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBillTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditPersonIDCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPersonIDCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditPersonIDSuppllier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPersonIDSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.billsBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditEdit,
            this.repositoryItemButtonEditDel,
            this.repositoryItemTextEditf2,
            this.repositoryItemTextEditn0,
            this.repositoryItemGridLookUpEditBillTypeID,
            this.repositoryItemGridLookUpEditPersonIDCustomer,
            this.repositoryItemMemoExEditInfo,
            this.repositoryItemGridLookUpEditPersonIDSuppllier,
            this.repositoryItemDateEditDMY});
            this.gridControlData.Size = new System.Drawing.Size(714, 312);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "Bills";
            this.billsBindingSource.DataSource = this.dsTinyData;
            // 
            // dsTinyData
            // 
            this.dsTinyData.DataSetName = "dsTinyData";
            this.dsTinyData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewData.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewData.Appearance.Row.Options.UseFont = true;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillNo,
            this.colBillTypeID,
            this.colBillDate,
            this.colBillName,
            this.colPersonID,
            this.colInfo,
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridViewData_CustomRowCellEdit);
            this.gridViewData.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewData_InvalidRowException);
            // 
            // colBillNo
            // 
            this.colBillNo.AppearanceCell.Options.UseTextOptions = true;
            this.colBillNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillNo.Caption = "رقم الفاتوره";
            this.colBillNo.FieldName = "BillNo";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.Visible = true;
            this.colBillNo.VisibleIndex = 0;
            // 
            // colBillTypeID
            // 
            this.colBillTypeID.AppearanceCell.Options.UseTextOptions = true;
            this.colBillTypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillTypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeID.Caption = "النوع";
            this.colBillTypeID.ColumnEdit = this.repositoryItemGridLookUpEditBillTypeID;
            this.colBillTypeID.FieldName = "BillTypeID";
            this.colBillTypeID.Name = "colBillTypeID";
            this.colBillTypeID.Visible = true;
            this.colBillTypeID.VisibleIndex = 1;
            this.colBillTypeID.Width = 81;
            // 
            // repositoryItemGridLookUpEditBillTypeID
            // 
            this.repositoryItemGridLookUpEditBillTypeID.AutoHeight = false;
            this.repositoryItemGridLookUpEditBillTypeID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditBillTypeID.DataSource = this.billTypesBindingSource;
            this.repositoryItemGridLookUpEditBillTypeID.DisplayMember = "BillTypeName";
            this.repositoryItemGridLookUpEditBillTypeID.Name = "repositoryItemGridLookUpEditBillTypeID";
            this.repositoryItemGridLookUpEditBillTypeID.NullText = "";
            this.repositoryItemGridLookUpEditBillTypeID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditBillTypeID.ValueMember = "BillTypeID";
            this.repositoryItemGridLookUpEditBillTypeID.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // billTypesBindingSource
            // 
            this.billTypesBindingSource.DataMember = "BillTypes";
            this.billTypesBindingSource.DataSource = this.dsTinyData;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillTypeName1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colBillTypeName1
            // 
            this.colBillTypeName1.AppearanceCell.Options.UseTextOptions = true;
            this.colBillTypeName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillTypeName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeName1.Caption = "الانواع";
            this.colBillTypeName1.FieldName = "BillTypeName";
            this.colBillTypeName1.Name = "colBillTypeName1";
            this.colBillTypeName1.Visible = true;
            this.colBillTypeName1.VisibleIndex = 0;
            // 
            // colBillDate
            // 
            this.colBillDate.AppearanceCell.Options.UseTextOptions = true;
            this.colBillDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillDate.Caption = "التاريخ";
            this.colBillDate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colBillDate.FieldName = "BillDate";
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.Visible = true;
            this.colBillDate.VisibleIndex = 2;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.repositoryItemDateEditDMY.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEditDMY.VistaTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.VistaTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.VistaTimeProperties.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.VistaTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.VistaTimeProperties.Mask.EditMask = "dd/MM/yyyy";
            // 
            // colBillName
            // 
            this.colBillName.AppearanceCell.Options.UseTextOptions = true;
            this.colBillName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillName.Caption = "الاسم";
            this.colBillName.FieldName = "BillName";
            this.colBillName.Name = "colBillName";
            this.colBillName.Visible = true;
            this.colBillName.VisibleIndex = 3;
            this.colBillName.Width = 118;
            // 
            // colPersonID
            // 
            this.colPersonID.AppearanceCell.Options.UseTextOptions = true;
            this.colPersonID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonID.Caption = "الشخص";
            this.colPersonID.FieldName = "PersonID";
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.Visible = true;
            this.colPersonID.VisibleIndex = 4;
            this.colPersonID.Width = 97;
            // 
            // colInfo
            // 
            this.colInfo.AppearanceCell.Options.UseTextOptions = true;
            this.colInfo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInfo.Caption = "ملاحظات";
            this.colInfo.ColumnEdit = this.repositoryItemMemoExEditInfo;
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 5;
            this.colInfo.Width = 90;
            // 
            // repositoryItemMemoExEditInfo
            // 
            this.repositoryItemMemoExEditInfo.AutoHeight = false;
            this.repositoryItemMemoExEditInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditInfo.Name = "repositoryItemMemoExEditInfo";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "تعديل";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
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
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "حذف";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // repositoryItemTextEditf2
            // 
            this.repositoryItemTextEditf2.AutoHeight = false;
            this.repositoryItemTextEditf2.DisplayFormat.FormatString = "f2";
            this.repositoryItemTextEditf2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditf2.EditFormat.FormatString = "f2";
            this.repositoryItemTextEditf2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditf2.Mask.EditMask = "f2";
            this.repositoryItemTextEditf2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditf2.Name = "repositoryItemTextEditf2";
            // 
            // repositoryItemTextEditn0
            // 
            this.repositoryItemTextEditn0.AutoHeight = false;
            this.repositoryItemTextEditn0.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEditn0.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn0.EditFormat.FormatString = "n0";
            this.repositoryItemTextEditn0.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn0.Mask.EditMask = "n0";
            this.repositoryItemTextEditn0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditn0.Name = "repositoryItemTextEditn0";
            // 
            // repositoryItemGridLookUpEditPersonIDCustomer
            // 
            this.repositoryItemGridLookUpEditPersonIDCustomer.AutoHeight = false;
            this.repositoryItemGridLookUpEditPersonIDCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditPersonIDCustomer.DataSource = this.customersBindingSource;
            this.repositoryItemGridLookUpEditPersonIDCustomer.DisplayMember = "CustomerName";
            this.repositoryItemGridLookUpEditPersonIDCustomer.Name = "repositoryItemGridLookUpEditPersonIDCustomer";
            this.repositoryItemGridLookUpEditPersonIDCustomer.NullText = "";
            this.repositoryItemGridLookUpEditPersonIDCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditPersonIDCustomer.ValueMember = "CustomerID";
            this.repositoryItemGridLookUpEditPersonIDCustomer.View = this.gridViewPersonIDCustomer;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dsTinyData;
            // 
            // gridViewPersonIDCustomer
            // 
            this.gridViewPersonIDCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerPhone,
            this.colCustomerAddress});
            this.gridViewPersonIDCustomer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewPersonIDCustomer.Name = "gridViewPersonIDCustomer";
            this.gridViewPersonIDCustomer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPersonIDCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.Caption = "الاسم";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerPhone.Caption = "تليفون";
            this.colCustomerPhone.FieldName = "CustomerPhone";
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.Visible = true;
            this.colCustomerPhone.VisibleIndex = 1;
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerAddress.Caption = "عنوان";
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.Visible = true;
            this.colCustomerAddress.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEditPersonIDSuppllier
            // 
            this.repositoryItemGridLookUpEditPersonIDSuppllier.AutoHeight = false;
            this.repositoryItemGridLookUpEditPersonIDSuppllier.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditPersonIDSuppllier.DataSource = this.suppliersBindingSource;
            this.repositoryItemGridLookUpEditPersonIDSuppllier.DisplayMember = "supplierName";
            this.repositoryItemGridLookUpEditPersonIDSuppllier.Name = "repositoryItemGridLookUpEditPersonIDSuppllier";
            this.repositoryItemGridLookUpEditPersonIDSuppllier.NullText = "";
            this.repositoryItemGridLookUpEditPersonIDSuppllier.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditPersonIDSuppllier.ValueMember = "SupplierID";
            this.repositoryItemGridLookUpEditPersonIDSuppllier.View = this.gridViewPersonIDSupplier;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.dsTinyData;
            // 
            // gridViewPersonIDSupplier
            // 
            this.gridViewPersonIDSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsupplierName,
            this.colsupplierPhone,
            this.colsupplierAddress});
            this.gridViewPersonIDSupplier.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewPersonIDSupplier.Name = "gridViewPersonIDSupplier";
            this.gridViewPersonIDSupplier.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPersonIDSupplier.OptionsView.ShowGroupPanel = false;
            // 
            // colsupplierName
            // 
            this.colsupplierName.AppearanceCell.Options.UseTextOptions = true;
            this.colsupplierName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsupplierName.AppearanceHeader.Options.UseTextOptions = true;
            this.colsupplierName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsupplierName.Caption = "الاسم";
            this.colsupplierName.FieldName = "supplierName";
            this.colsupplierName.Name = "colsupplierName";
            this.colsupplierName.Visible = true;
            this.colsupplierName.VisibleIndex = 0;
            // 
            // colsupplierPhone
            // 
            this.colsupplierPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colsupplierPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsupplierPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colsupplierPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsupplierPhone.Caption = "تليفون";
            this.colsupplierPhone.FieldName = "supplierPhone";
            this.colsupplierPhone.Name = "colsupplierPhone";
            this.colsupplierPhone.Visible = true;
            this.colsupplierPhone.VisibleIndex = 1;
            // 
            // colsupplierAddress
            // 
            this.colsupplierAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colsupplierAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsupplierAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colsupplierAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsupplierAddress.Caption = "عنوان";
            this.colsupplierAddress.FieldName = "supplierAddress";
            this.colsupplierAddress.Name = "colsupplierAddress";
            this.colsupplierAddress.Visible = true;
            this.colsupplierAddress.VisibleIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.Controls.Add(this.gridControlData);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(718, 335);
            this.groupControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnNew);
            this.groupControl2.Location = new System.Drawing.Point(12, 353);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(718, 58);
            this.groupControl2.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Image = global::TinyShop.Properties.Resources.Add;
            this.btnNew.Location = new System.Drawing.Point(506, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(207, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // billTypesTableAdapter
            // 
            this.billTypesTableAdapter.ClearBeforeFill = true;
            // 
            // colBillTypeName
            // 
            this.colBillTypeName.AppearanceCell.Options.UseTextOptions = true;
            this.colBillTypeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeName.Caption = "اسم النوع";
            this.colBillTypeName.FieldName = "BillTypeName";
            this.colBillTypeName.Name = "colBillTypeName";
            this.colBillTypeName.Visible = true;
            this.colBillTypeName.VisibleIndex = 0;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // BillsEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "BillsEditorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الفواتير";
            this.Load += new System.EventHandler(this.BillsEditorFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBillTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditPersonIDCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPersonIDCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditPersonIDSuppllier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPersonIDSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditn0;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditf2;
        private DataSources.dsTinyData dsTinyData;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private DataSources.dsTinyDataTableAdapters.BillsTableAdapter billsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBillNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBillTypeID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditBillTypeID;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBillName;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditPersonIDCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPersonIDCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditInfo;
        private System.Windows.Forms.BindingSource billTypesBindingSource;
        private DataSources.dsTinyDataTableAdapters.BillTypesTableAdapter billTypesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBillTypeName;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSources.dsTinyDataTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditPersonIDSuppllier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPersonIDSupplier;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private DataSources.dsTinyDataTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplierPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplierAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colBillTypeName1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
    }
}