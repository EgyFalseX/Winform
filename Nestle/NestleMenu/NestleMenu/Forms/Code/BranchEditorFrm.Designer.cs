namespace NestleMenu.Forms.Code
{
    partial class BranchEditorFrm
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
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNU = new NestleMenu.DataSources.dsNU();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBranshName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCustomerId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerLogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupervisorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSupervisorId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEditMenuSizeLogo = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.branchTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.BranchTableAdapter();
            this.customersTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.CustomersTableAdapter();
            this.employeeTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.EmployeeTableAdapter();
            this.jobTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.JobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSupervisorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditMenuSizeLogo)).BeginInit();
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
            this.bbiNew.Glyph = global::NestleMenu.Properties.Resources.New;
            this.bbiNew.Id = 0;
            this.bbiNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NestleMenu.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(712, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 286);
            this.barDockControlBottom.Size = new System.Drawing.Size(712, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(712, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 255);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.branchBindingSource;
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
            this.repositoryItemPictureEditMenuSizeLogo,
            this.repositoryItemGridLookUpEditCustomerId,
            this.repositoryItemGridLookUpEditSupervisorId});
            this.gridControlMain.Size = new System.Drawing.Size(712, 255);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.dsNU;
            // 
            // dsNU
            // 
            this.dsNU.DataSetName = "dsNU";
            this.dsNU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnEdit,
            this.gridColumnDelete,
            this.colBranshName,
            this.colCustomerId,
            this.colSupervisorId,
            this.colBranchPhone,
            this.colBranchMobile,
            this.colBranchAddress});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEdit.Caption = "Edit";
            this.gridColumnEdit.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 6;
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
            this.gridColumnDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.Caption = "Delete";
            this.gridColumnDelete.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 7;
            this.gridColumnDelete.Width = 86;
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
            // colBranshName
            // 
            this.colBranshName.FieldName = "BranchName";
            this.colBranshName.Name = "colBranshName";
            this.colBranshName.Visible = true;
            this.colBranshName.VisibleIndex = 0;
            this.colBranshName.Width = 82;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Caption = "Customer";
            this.colCustomerId.ColumnEdit = this.repositoryItemGridLookUpEditCustomerId;
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 1;
            this.colCustomerId.Width = 78;
            // 
            // repositoryItemGridLookUpEditCustomerId
            // 
            this.repositoryItemGridLookUpEditCustomerId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCustomerId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCustomerId.DataSource = this.customersBindingSource;
            this.repositoryItemGridLookUpEditCustomerId.DisplayMember = "CustomerName";
            this.repositoryItemGridLookUpEditCustomerId.Name = "repositoryItemGridLookUpEditCustomerId";
            this.repositoryItemGridLookUpEditCustomerId.NullText = "";
            this.repositoryItemGridLookUpEditCustomerId.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.repositoryItemGridLookUpEditCustomerId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCustomerId.ValueMember = "CustomerId";
            this.repositoryItemGridLookUpEditCustomerId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dsNU;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerLogo});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            // colSupervisorId
            // 
            this.colSupervisorId.Caption = "Supervisor";
            this.colSupervisorId.ColumnEdit = this.repositoryItemGridLookUpEditSupervisorId;
            this.colSupervisorId.FieldName = "SupervisorId";
            this.colSupervisorId.Name = "colSupervisorId";
            this.colSupervisorId.Visible = true;
            this.colSupervisorId.VisibleIndex = 2;
            this.colSupervisorId.Width = 83;
            // 
            // repositoryItemGridLookUpEditSupervisorId
            // 
            this.repositoryItemGridLookUpEditSupervisorId.AutoHeight = false;
            this.repositoryItemGridLookUpEditSupervisorId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSupervisorId.DataSource = this.employeeBindingSource;
            this.repositoryItemGridLookUpEditSupervisorId.DisplayMember = "EmployeeName";
            this.repositoryItemGridLookUpEditSupervisorId.Name = "repositoryItemGridLookUpEditSupervisorId";
            this.repositoryItemGridLookUpEditSupervisorId.NullText = "";
            this.repositoryItemGridLookUpEditSupervisorId.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.repositoryItemGridLookUpEditSupervisorId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSupervisorId.ValueMember = "EmployeeId";
            this.repositoryItemGridLookUpEditSupervisorId.View = this.gridView1;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dsNU;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobName", "Job Name", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.jobBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "JobName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "JobId";
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
            this.colJobId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colJobId.FieldName = "JobId";
            this.colJobId.Name = "colJobId";
            this.colJobId.Visible = true;
            this.colJobId.VisibleIndex = 1;
            // 
            // colBranchPhone
            // 
            this.colBranchPhone.FieldName = "BranchPhone";
            this.colBranchPhone.Name = "colBranchPhone";
            this.colBranchPhone.Visible = true;
            this.colBranchPhone.VisibleIndex = 3;
            this.colBranchPhone.Width = 85;
            // 
            // colBranchMobile
            // 
            this.colBranchMobile.FieldName = "BranchMobile";
            this.colBranchMobile.Name = "colBranchMobile";
            this.colBranchMobile.Visible = true;
            this.colBranchMobile.VisibleIndex = 4;
            this.colBranchMobile.Width = 85;
            // 
            // colBranchAddress
            // 
            this.colBranchAddress.FieldName = "BranchAddress";
            this.colBranchAddress.Name = "colBranchAddress";
            this.colBranchAddress.Visible = true;
            this.colBranchAddress.VisibleIndex = 5;
            this.colBranchAddress.Width = 94;
            // 
            // repositoryItemPictureEditMenuSizeLogo
            // 
            this.repositoryItemPictureEditMenuSizeLogo.Name = "repositoryItemPictureEditMenuSizeLogo";
            this.repositoryItemPictureEditMenuSizeLogo.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEditMenuSizeLogo.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
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
            // BranchEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 286);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = global::NestleMenu.Properties.Resources.BranchEditor;
            this.Name = "BranchEditorFrm";
            this.Text = "Branch Editor";
            this.Load += new System.EventHandler(this.JobEditorFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCustomerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSupervisorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditMenuSizeLogo)).EndInit();
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
        private DataSources.dsNU dsNU;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditMenuSizeLogo;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private DataSources.dsNUTableAdapters.BranchTableAdapter branchTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBranshName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCustomerId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSupervisorId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSupervisorId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchAddress;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSources.dsNUTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.dsNUTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerLogo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colJobId;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private DataSources.dsNUTableAdapters.JobTableAdapter jobTableAdapter;
    }
}