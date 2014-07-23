namespace NestleMenu.Forms.Code
{
    partial class BranchEditorWFrm
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
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BranchNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BranchAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BranchPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BranchMobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SupervisorIdLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNU = new NestleMenu.DataSources.dsNU();
            this.repositoryItemLookUpEditJobId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerIdLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerLogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForBranchName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomerId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBranchAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBranchPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBranchMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSupervisorId = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.branchTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.BranchTableAdapter();
            this.customersTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.CustomersTableAdapter();
            this.employeeTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.EmployeeTableAdapter();
            this.jobTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.JobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchMobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupervisorIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditJobId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupervisorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.BranchNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.BranchAddressTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.BranchPhoneTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.BranchMobileTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.SupervisorIdLookUpEdit);
            this.dataLayoutControlMain.Controls.Add(this.CustomerIdLookUpEdit);
            this.dataLayoutControlMain.DataSource = this.branchBindingSource;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(745, 205, 250, 350);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 269);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::NestleMenu.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 22);
            this.btnSave.StyleController = this.dataLayoutControlMain;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::NestleMenu.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(260, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            // 
            // BranchNameTextEdit
            // 
            this.BranchNameTextEdit.EnterMoveNextControl = true;
            this.BranchNameTextEdit.Location = new System.Drawing.Point(90, 12);
            this.BranchNameTextEdit.Name = "BranchNameTextEdit";
            this.BranchNameTextEdit.Size = new System.Drawing.Size(308, 20);
            this.BranchNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.BranchNameTextEdit.TabIndex = 0;
            // 
            // BranchAddressTextEdit
            // 
            this.BranchAddressTextEdit.EnterMoveNextControl = true;
            this.BranchAddressTextEdit.Location = new System.Drawing.Point(90, 84);
            this.BranchAddressTextEdit.Name = "BranchAddressTextEdit";
            this.BranchAddressTextEdit.Size = new System.Drawing.Size(308, 20);
            this.BranchAddressTextEdit.StyleController = this.dataLayoutControlMain;
            this.BranchAddressTextEdit.TabIndex = 3;
            // 
            // BranchPhoneTextEdit
            // 
            this.BranchPhoneTextEdit.EnterMoveNextControl = true;
            this.BranchPhoneTextEdit.Location = new System.Drawing.Point(90, 108);
            this.BranchPhoneTextEdit.Name = "BranchPhoneTextEdit";
            this.BranchPhoneTextEdit.Size = new System.Drawing.Size(308, 20);
            this.BranchPhoneTextEdit.StyleController = this.dataLayoutControlMain;
            this.BranchPhoneTextEdit.TabIndex = 4;
            // 
            // BranchMobileTextEdit
            // 
            this.BranchMobileTextEdit.EnterMoveNextControl = true;
            this.BranchMobileTextEdit.Location = new System.Drawing.Point(90, 132);
            this.BranchMobileTextEdit.Name = "BranchMobileTextEdit";
            this.BranchMobileTextEdit.Size = new System.Drawing.Size(308, 20);
            this.BranchMobileTextEdit.StyleController = this.dataLayoutControlMain;
            this.BranchMobileTextEdit.TabIndex = 5;
            // 
            // SupervisorIdLookUpEdit
            // 
            this.SupervisorIdLookUpEdit.EnterMoveNextControl = true;
            this.SupervisorIdLookUpEdit.Location = new System.Drawing.Point(90, 60);
            this.SupervisorIdLookUpEdit.Name = "SupervisorIdLookUpEdit";
            this.SupervisorIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SupervisorIdLookUpEdit.Properties.DataSource = this.employeeBindingSource;
            this.SupervisorIdLookUpEdit.Properties.DisplayMember = "EmployeeName";
            this.SupervisorIdLookUpEdit.Properties.NullText = "";
            this.SupervisorIdLookUpEdit.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditJobId});
            this.SupervisorIdLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.SupervisorIdLookUpEdit.Properties.ValueMember = "EmployeeId";
            this.SupervisorIdLookUpEdit.Properties.View = this.gridView1;
            this.SupervisorIdLookUpEdit.Size = new System.Drawing.Size(308, 20);
            this.SupervisorIdLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.SupervisorIdLookUpEdit.TabIndex = 2;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dsNU;
            // 
            // dsNU
            // 
            this.dsNU.DataSetName = "dsNU";
            this.dsNU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemLookUpEditJobId
            // 
            this.repositoryItemLookUpEditJobId.AutoHeight = false;
            this.repositoryItemLookUpEditJobId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditJobId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobName", "Job Name", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditJobId.DataSource = this.jobBindingSource;
            this.repositoryItemLookUpEditJobId.DisplayMember = "JobName";
            this.repositoryItemLookUpEditJobId.Name = "repositoryItemLookUpEditJobId";
            this.repositoryItemLookUpEditJobId.ValueMember = "JobId";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.dsNU;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeName,
            this.colJobId});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            // 
            // colJobId
            // 
            this.colJobId.ColumnEdit = this.repositoryItemLookUpEditJobId;
            this.colJobId.FieldName = "JobId";
            this.colJobId.Name = "colJobId";
            this.colJobId.Visible = true;
            this.colJobId.VisibleIndex = 1;
            // 
            // CustomerIdLookUpEdit
            // 
            this.CustomerIdLookUpEdit.EnterMoveNextControl = true;
            this.CustomerIdLookUpEdit.Location = new System.Drawing.Point(90, 36);
            this.CustomerIdLookUpEdit.Name = "CustomerIdLookUpEdit";
            this.CustomerIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerIdLookUpEdit.Properties.DataSource = this.customersBindingSource;
            this.CustomerIdLookUpEdit.Properties.DisplayMember = "CustomerName";
            this.CustomerIdLookUpEdit.Properties.NullText = "";
            this.CustomerIdLookUpEdit.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.CustomerIdLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.CustomerIdLookUpEdit.Properties.ValueMember = "CustomerId";
            this.CustomerIdLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CustomerIdLookUpEdit.Size = new System.Drawing.Size(308, 20);
            this.CustomerIdLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.CustomerIdLookUpEdit.TabIndex = 1;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dsNU;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerLogo});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.RowHeight = 24;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            // 
            // colCustomerLogo
            // 
            this.colCustomerLogo.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colCustomerLogo.FieldName = "CustomerLogo";
            this.colCustomerLogo.Name = "colCustomerLogo";
            this.colCustomerLogo.Visible = true;
            this.colCustomerLogo.VisibleIndex = 1;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.dsNU;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 269);
            this.layoutControlGroup1.Text = "Root";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemCancel,
            this.layoutControlItemSave,
            this.emptySpaceItem1,
            this.ItemForBranchName,
            this.ItemForCustomerId,
            this.ItemForBranchAddress,
            this.ItemForBranchPhone,
            this.ItemForBranchMobile,
            this.ItemForSupervisorId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 249);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 223);
            this.layoutControlItemCancel.Name = "layoutControlItemCancel";
            this.layoutControlItemCancel.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItemCancel.Text = "layoutControlItemCancel";
            this.layoutControlItemCancel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCancel.TextToControlDistance = 0;
            this.layoutControlItemCancel.TextVisible = false;
            // 
            // layoutControlItemSave
            // 
            this.layoutControlItemSave.Control = this.btnSave;
            this.layoutControlItemSave.CustomizationFormText = "layoutControlItemSave";
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 223);
            this.layoutControlItemSave.Name = "layoutControlItemSave";
            this.layoutControlItemSave.Size = new System.Drawing.Size(248, 26);
            this.layoutControlItemSave.Text = "layoutControlItemSave";
            this.layoutControlItemSave.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSave.TextToControlDistance = 0;
            this.layoutControlItemSave.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItemLast";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 79);
            this.emptySpaceItem1.Text = "empty Space Item Last";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForBranchName
            // 
            this.ItemForBranchName.Control = this.BranchNameTextEdit;
            this.ItemForBranchName.CustomizationFormText = "Branch Name";
            this.ItemForBranchName.Location = new System.Drawing.Point(0, 0);
            this.ItemForBranchName.Name = "ItemForBranchName";
            this.ItemForBranchName.Size = new System.Drawing.Size(390, 24);
            this.ItemForBranchName.Text = "Branch Name";
            this.ItemForBranchName.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForCustomerId
            // 
            this.ItemForCustomerId.Control = this.CustomerIdLookUpEdit;
            this.ItemForCustomerId.CustomizationFormText = "Customer";
            this.ItemForCustomerId.Location = new System.Drawing.Point(0, 24);
            this.ItemForCustomerId.Name = "ItemForCustomerId";
            this.ItemForCustomerId.Size = new System.Drawing.Size(390, 24);
            this.ItemForCustomerId.Text = "Customer";
            this.ItemForCustomerId.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForBranchAddress
            // 
            this.ItemForBranchAddress.Control = this.BranchAddressTextEdit;
            this.ItemForBranchAddress.CustomizationFormText = "Branch Address";
            this.ItemForBranchAddress.Location = new System.Drawing.Point(0, 72);
            this.ItemForBranchAddress.Name = "ItemForBranchAddress";
            this.ItemForBranchAddress.Size = new System.Drawing.Size(390, 24);
            this.ItemForBranchAddress.Text = "Branch Address";
            this.ItemForBranchAddress.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForBranchPhone
            // 
            this.ItemForBranchPhone.Control = this.BranchPhoneTextEdit;
            this.ItemForBranchPhone.CustomizationFormText = "Branch Phone";
            this.ItemForBranchPhone.Location = new System.Drawing.Point(0, 96);
            this.ItemForBranchPhone.Name = "ItemForBranchPhone";
            this.ItemForBranchPhone.Size = new System.Drawing.Size(390, 24);
            this.ItemForBranchPhone.Text = "Branch Phone";
            this.ItemForBranchPhone.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForBranchMobile
            // 
            this.ItemForBranchMobile.Control = this.BranchMobileTextEdit;
            this.ItemForBranchMobile.CustomizationFormText = "Branch Mobile";
            this.ItemForBranchMobile.Location = new System.Drawing.Point(0, 120);
            this.ItemForBranchMobile.Name = "ItemForBranchMobile";
            this.ItemForBranchMobile.Size = new System.Drawing.Size(390, 24);
            this.ItemForBranchMobile.Text = "Branch Mobile";
            this.ItemForBranchMobile.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForSupervisorId
            // 
            this.ItemForSupervisorId.Control = this.SupervisorIdLookUpEdit;
            this.ItemForSupervisorId.CustomizationFormText = "Supervisor";
            this.ItemForSupervisorId.Location = new System.Drawing.Point(0, 48);
            this.ItemForSupervisorId.Name = "ItemForSupervisorId";
            this.ItemForSupervisorId.Size = new System.Drawing.Size(390, 24);
            this.ItemForSupervisorId.Text = "Supervisor";
            this.ItemForSupervisorId.TextSize = new System.Drawing.Size(75, 13);
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // BranchEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 269);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::NestleMenu.Properties.Resources.BranchEditor;
            this.Name = "BranchEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.JobEditorWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchMobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupervisorIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditJobId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupervisorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSources.dsNU dsNU;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSave;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderEditor;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private DataSources.dsNUTableAdapters.BranchTableAdapter branchTableAdapter;
        private DevExpress.XtraEditors.TextEdit BranchNameTextEdit;
        private DevExpress.XtraEditors.TextEdit BranchAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit BranchPhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit BranchMobileTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit SupervisorIdLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSupervisorId;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSources.dsNUTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.dsNUTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditJobId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colJobId;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private DataSources.dsNUTableAdapters.JobTableAdapter jobTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit CustomerIdLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerLogo;
    }
}