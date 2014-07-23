namespace NestleMenu.Forms.Code
{
    partial class EmployeeEditorFrm
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
            this.dsNU = new NestleMenu.DataSources.dsNU();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.EmployeeTableAdapter();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAreaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditAreaId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditJobId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.AreaTableAdapter();
            this.colAreaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.JobTableAdapter();
            this.colJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditAreaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditJobId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
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
            this.gridControlMain.DataSource = this.employeeBindingSource;
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
            this.repositoryItemGridLookUpEditAreaId,
            this.repositoryItemGridLookUpEditJobId});
            this.gridControlMain.Size = new System.Drawing.Size(636, 255);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
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
            this.colEmployeeName,
            this.colAreaId,
            this.colJobId});
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
            this.gridColumnEdit.VisibleIndex = 3;
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
            this.gridColumnDelete.VisibleIndex = 4;
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
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dsNU;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            this.colEmployeeName.Width = 114;
            // 
            // colAreaId
            // 
            this.colAreaId.Caption = "Area";
            this.colAreaId.ColumnEdit = this.repositoryItemGridLookUpEditAreaId;
            this.colAreaId.FieldName = "AreaId";
            this.colAreaId.Name = "colAreaId";
            this.colAreaId.Visible = true;
            this.colAreaId.VisibleIndex = 1;
            // 
            // colJobId
            // 
            this.colJobId.Caption = "Job";
            this.colJobId.ColumnEdit = this.repositoryItemGridLookUpEditJobId;
            this.colJobId.FieldName = "JobId";
            this.colJobId.Name = "colJobId";
            this.colJobId.Visible = true;
            this.colJobId.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEditAreaId
            // 
            this.repositoryItemGridLookUpEditAreaId.AutoHeight = false;
            this.repositoryItemGridLookUpEditAreaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditAreaId.DataSource = this.areaBindingSource;
            this.repositoryItemGridLookUpEditAreaId.DisplayMember = "AreaName";
            this.repositoryItemGridLookUpEditAreaId.Name = "repositoryItemGridLookUpEditAreaId";
            this.repositoryItemGridLookUpEditAreaId.NullText = "";
            this.repositoryItemGridLookUpEditAreaId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditAreaId.ValueMember = "AreaId";
            this.repositoryItemGridLookUpEditAreaId.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAreaName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEditJobId
            // 
            this.repositoryItemGridLookUpEditJobId.AutoHeight = false;
            this.repositoryItemGridLookUpEditJobId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditJobId.DataSource = this.jobBindingSource;
            this.repositoryItemGridLookUpEditJobId.DisplayMember = "JobName";
            this.repositoryItemGridLookUpEditJobId.Name = "repositoryItemGridLookUpEditJobId";
            this.repositoryItemGridLookUpEditJobId.NullText = "";
            this.repositoryItemGridLookUpEditJobId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditJobId.ValueMember = "JobId";
            this.repositoryItemGridLookUpEditJobId.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJobName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.dsNU;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // colAreaName
            // 
            this.colAreaName.FieldName = "AreaName";
            this.colAreaName.Name = "colAreaName";
            this.colAreaName.Visible = true;
            this.colAreaName.VisibleIndex = 0;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.dsNU;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // colJobName
            // 
            this.colJobName.FieldName = "JobName";
            this.colJobName.Name = "colJobName";
            this.colJobName.Visible = true;
            this.colJobName.VisibleIndex = 0;
            // 
            // EmployeeEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 286);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = global::NestleMenu.Properties.Resources.Employee;
            this.Name = "EmployeeEditorFrm";
            this.Text = "Employee Editor";
            this.Load += new System.EventHandler(this.AreaEditorFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditAreaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditJobId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.dsNUTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditAreaId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colJobId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditJobId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private DataSources.dsNUTableAdapters.AreaTableAdapter areaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaName;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private DataSources.dsNUTableAdapters.JobTableAdapter jobTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colJobName;
    }
}