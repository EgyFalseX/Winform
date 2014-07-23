namespace TinyShop.Forms.Query
{
    partial class QryBillsFrm
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
            this.qryBillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTinyData = new TinyShop.DataSources.dsTinyData();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditBillTypeID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.billTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBillNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditInfo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colTotalCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUserID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEditDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemLookUpEditPersonIDCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemLookUpEditPersonIDSupplier = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.qryBillsTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.QryBillsTableAdapter();
            this.suppliersTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.SuppliersTableAdapter();
            this.customersTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.CustomersTableAdapter();
            this.billTypesTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.BillTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryBillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBillTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditD.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPersonIDCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPersonIDSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.qryBillsBindingSource;
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
            this.repositoryItemCalcEdit1,
            this.repositoryItemDateEditDMY,
            this.repositoryItemDateEditD});
            this.gridControlData.Size = new System.Drawing.Size(692, 373);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // qryBillsBindingSource
            // 
            this.qryBillsBindingSource.DataMember = "QryBills";
            this.qryBillsBindingSource.DataSource = this.dsTinyData;
            // 
            // dsTinyData
            // 
            this.dsTinyData.DataSetName = "dsTinyData";
            this.dsTinyData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewData.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewData.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewData.Appearance.Row.Options.UseFont = true;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillTypeID,
            this.colBillNo,
            this.colBillName,
            this.colBillDate,
            this.colPersonName,
            this.colInfo,
            this.colTotalCash,
            this.colUserID,
            this.colEditDate});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridViewData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCash", this.colTotalCash, "")});
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.SummariesIgnoreNullValues = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.RowAutoHeight = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colBillTypeID
            // 
            this.colBillTypeID.AppearanceCell.Options.UseTextOptions = true;
            this.colBillTypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillTypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillTypeID.Caption = "النوع";
            this.colBillTypeID.ColumnEdit = this.repositoryItemLookUpEditBillTypeID;
            this.colBillTypeID.FieldName = "BillTypeID";
            this.colBillTypeID.Name = "colBillTypeID";
            this.colBillTypeID.OptionsColumn.AllowEdit = false;
            this.colBillTypeID.Visible = true;
            this.colBillTypeID.VisibleIndex = 0;
            this.colBillTypeID.Width = 85;
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
            // colBillNo
            // 
            this.colBillNo.AppearanceCell.Options.UseTextOptions = true;
            this.colBillNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBillNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBillNo.Caption = "الرقم";
            this.colBillNo.FieldName = "BillNo";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.OptionsColumn.AllowEdit = false;
            this.colBillNo.Visible = true;
            this.colBillNo.VisibleIndex = 1;
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
            this.colBillName.OptionsColumn.AllowEdit = false;
            this.colBillName.Visible = true;
            this.colBillName.VisibleIndex = 2;
            this.colBillName.Width = 143;
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
            this.colBillDate.OptionsColumn.AllowEdit = false;
            this.colBillDate.Visible = true;
            this.colBillDate.VisibleIndex = 3;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            this.colPersonName.OptionsColumn.AllowEdit = false;
            this.colPersonName.Visible = true;
            this.colPersonName.VisibleIndex = 4;
            this.colPersonName.Width = 164;
            // 
            // colInfo
            // 
            this.colInfo.AppearanceCell.Options.UseTextOptions = true;
            this.colInfo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInfo.Caption = "معلومات";
            this.colInfo.ColumnEdit = this.repositoryItemMemoExEditInfo;
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.OptionsColumn.ReadOnly = true;
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 5;
            // 
            // repositoryItemMemoExEditInfo
            // 
            this.repositoryItemMemoExEditInfo.AutoHeight = false;
            this.repositoryItemMemoExEditInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditInfo.Name = "repositoryItemMemoExEditInfo";
            // 
            // colTotalCash
            // 
            this.colTotalCash.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalCash.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalCash.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalCash.Caption = "القيمة";
            this.colTotalCash.FieldName = "TotalCash";
            this.colTotalCash.Name = "colTotalCash";
            this.colTotalCash.OptionsColumn.AllowEdit = false;
            this.colTotalCash.Visible = true;
            this.colTotalCash.VisibleIndex = 6;
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
            this.colUserID.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemLookUpEditUserID
            // 
            this.repositoryItemLookUpEditUserID.AutoHeight = false;
            this.repositoryItemLookUpEditUserID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserID.Name = "repositoryItemLookUpEditUserID";
            this.repositoryItemLookUpEditUserID.NullText = "";
            this.repositoryItemLookUpEditUserID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // colEditDate
            // 
            this.colEditDate.AppearanceCell.Options.UseTextOptions = true;
            this.colEditDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEditDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colEditDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEditDate.Caption = "تارخ الادخال";
            this.colEditDate.ColumnEdit = this.repositoryItemDateEditD;
            this.colEditDate.FieldName = "EditDate";
            this.colEditDate.Name = "colEditDate";
            this.colEditDate.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemDateEditD
            // 
            this.repositoryItemDateEditD.AutoHeight = false;
            this.repositoryItemDateEditD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditD.Name = "repositoryItemDateEditD";
            this.repositoryItemDateEditD.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // qryBillsTableAdapter
            // 
            this.qryBillsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // billTypesTableAdapter
            // 
            this.billTypesTableAdapter.ClearBeforeFill = true;
            // 
            // QryBillsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.gridControlData);
            this.Name = "QryBillsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الفواتير";
            this.Load += new System.EventHandler(this.QryBillsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryBillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBillTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditD.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPersonIDCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPersonIDSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DataSources.dsTinyData dsTinyData;
        private System.Windows.Forms.BindingSource qryBillsBindingSource;
        private DataSources.dsTinyDataTableAdapters.QryBillsTableAdapter qryBillsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBillTypeID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditBillTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colBillNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBillName;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPersonIDCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colEditDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCash;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private DataSources.dsTinyDataTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSources.dsTinyDataTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPersonIDSupplier;
        private System.Windows.Forms.BindingSource billTypesBindingSource;
        private DataSources.dsTinyDataTableAdapters.BillTypesTableAdapter billTypesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditD;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonName;
    }
}