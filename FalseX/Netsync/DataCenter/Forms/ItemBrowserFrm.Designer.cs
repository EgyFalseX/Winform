namespace DataCenter.Forms
{
    partial class ItemBrowserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBrowserFrm));
            this.contextMenuStripFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFiletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FileProperitestoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileAdminLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qryItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new DataCenter.DataSources.dsQueries();
            this.qryItemsTableAdapter = new DataCenter.DataSources.dsQueriesTableAdapters.QryItemsTableAdapter();
            this.dsDataCenter = new DataCenter.DataSources.dsDataCenter();
            this.itemTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.ItemTableAdapter();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.tlCategory = new DevExpress.XtraTreeList.TreeList();
            this.colCategoryName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.contextMenuStripCaterogy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSubCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMainCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryAdminLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryPermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qryCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sharedImageCollectionCategory = new DevExpress.Utils.SharedImageCollection(this.components);
            this.gridControlFiles = new DevExpress.XtraGrid.GridControl();
            this.gridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeIconData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colCreateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealNameLastEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanInsert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCanWrite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qryCategoryTableAdapter = new DataCenter.DataSources.dsQueriesTableAdapters.QryCategoryTableAdapter();
            this.contextMenuStripFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlCategory)).BeginInit();
            this.contextMenuStripCaterogy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollectionCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollectionCategory.ImageSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripFile
            // 
            this.contextMenuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFileToolStripMenuItem,
            this.toolStripSeparator3,
            this.addFileToolStripMenuItem,
            this.DeleteFiletoolStripMenuItem,
            this.toolStripSeparator4,
            this.FileProperitestoolStripMenuItem,
            this.fileAdminLevelToolStripMenuItem});
            this.contextMenuStripFile.Name = "contextMenuStripFolder";
            this.contextMenuStripFile.Size = new System.Drawing.Size(142, 126);
            this.contextMenuStripFile.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripFile_Opening);
            // 
            // viewFileToolStripMenuItem
            // 
            this.viewFileToolStripMenuItem.Image = global::DataCenter.Properties.Resources.view;
            this.viewFileToolStripMenuItem.Name = "viewFileToolStripMenuItem";
            this.viewFileToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.viewFileToolStripMenuItem.Text = "عرض";
            this.viewFileToolStripMenuItem.Click += new System.EventHandler(this.viewFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Image = global::DataCenter.Properties.Resources.Add;
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addFileToolStripMenuItem.Text = "اضافة ملف";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // DeleteFiletoolStripMenuItem
            // 
            this.DeleteFiletoolStripMenuItem.Image = global::DataCenter.Properties.Resources.Delete;
            this.DeleteFiletoolStripMenuItem.Name = "DeleteFiletoolStripMenuItem";
            this.DeleteFiletoolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.DeleteFiletoolStripMenuItem.Text = "حذف ملف";
            this.DeleteFiletoolStripMenuItem.Click += new System.EventHandler(this.DeleteFiletoolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            // 
            // FileProperitestoolStripMenuItem
            // 
            this.FileProperitestoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FileProperitestoolStripMenuItem.Image")));
            this.FileProperitestoolStripMenuItem.Name = "FileProperitestoolStripMenuItem";
            this.FileProperitestoolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.FileProperitestoolStripMenuItem.Text = "خصائص";
            this.FileProperitestoolStripMenuItem.Click += new System.EventHandler(this.FileProperitestoolStripMenuItem_Click);
            // 
            // fileAdminLevelToolStripMenuItem
            // 
            this.fileAdminLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filePermissionToolStripMenuItem,
            this.fileHistoryToolStripMenuItem});
            this.fileAdminLevelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileAdminLevelToolStripMenuItem.Image")));
            this.fileAdminLevelToolStripMenuItem.Name = "fileAdminLevelToolStripMenuItem";
            this.fileAdminLevelToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fileAdminLevelToolStripMenuItem.Text = "خصائص المدير";
            // 
            // filePermissionToolStripMenuItem
            // 
            this.filePermissionToolStripMenuItem.Image = global::DataCenter.Properties.Resources.Permission;
            this.filePermissionToolStripMenuItem.Name = "filePermissionToolStripMenuItem";
            this.filePermissionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.filePermissionToolStripMenuItem.Text = "الصلاحيات";
            this.filePermissionToolStripMenuItem.Click += new System.EventHandler(this.filePermissionToolStripMenuItem_Click);
            // 
            // fileHistoryToolStripMenuItem
            // 
            this.fileHistoryToolStripMenuItem.Image = global::DataCenter.Properties.Resources.History;
            this.fileHistoryToolStripMenuItem.Name = "fileHistoryToolStripMenuItem";
            this.fileHistoryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.fileHistoryToolStripMenuItem.Text = "توثيق العمليات";
            this.fileHistoryToolStripMenuItem.Click += new System.EventHandler(this.fileHistoryToolStripMenuItem_Click);
            // 
            // qryItemsBindingSource
            // 
            this.qryItemsBindingSource.DataMember = "QryItems";
            this.qryItemsBindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qryItemsTableAdapter
            // 
            this.qryItemsTableAdapter.ClearBeforeFill = true;
            // 
            // dsDataCenter
            // 
            this.dsDataCenter.DataSetName = "dsDataCenter";
            this.dsDataCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.AutoScroll = true;
            this.splitContainerControl.Panel1.Controls.Add(this.tlCategory);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.AutoScroll = true;
            this.splitContainerControl.Panel2.Controls.Add(this.gridControlFiles);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(979, 445);
            this.splitContainerControl.SplitterPosition = 165;
            this.splitContainerControl.TabIndex = 1;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // tlCategory
            // 
            this.tlCategory.AllowDrop = true;
            this.tlCategory.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCategoryName1});
            this.tlCategory.ContextMenuStrip = this.contextMenuStripCaterogy;
            this.tlCategory.DataSource = this.qryCategoryBindingSource;
            this.tlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCategory.ImageIndexFieldName = "IconId";
            this.tlCategory.KeyFieldName = "CategoryId";
            this.tlCategory.Location = new System.Drawing.Point(0, 0);
            this.tlCategory.Name = "tlCategory";
            this.tlCategory.OptionsBehavior.Editable = false;
            this.tlCategory.OptionsView.ShowColumns = false;
            this.tlCategory.OptionsView.ShowIndicator = false;
            this.tlCategory.PreviewFieldName = "Info";
            this.tlCategory.Size = new System.Drawing.Size(165, 433);
            this.tlCategory.StateImageList = this.sharedImageCollectionCategory;
            this.tlCategory.TabIndex = 0;
            this.tlCategory.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.tlCategory_GetStateImage);
            this.tlCategory.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlCategory_FocusedNodeChanged);
            this.tlCategory.DragDrop += new System.Windows.Forms.DragEventHandler(this.tlCategory_DragDrop);
            this.tlCategory.DragEnter += new System.Windows.Forms.DragEventHandler(this.tlCategory_DragEnter);
            this.tlCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlCategory_MouseDown);
            this.tlCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlCategory_MouseMove);
            // 
            // colCategoryName1
            // 
            this.colCategoryName1.Caption = ".";
            this.colCategoryName1.FieldName = "CategoryName";
            this.colCategoryName1.MinWidth = 33;
            this.colCategoryName1.Name = "colCategoryName1";
            this.colCategoryName1.Visible = true;
            this.colCategoryName1.VisibleIndex = 0;
            // 
            // contextMenuStripCaterogy
            // 
            this.contextMenuStripCaterogy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSubCategoryToolStripMenuItem,
            this.addMainCategoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteCategoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.categoryPropertiesToolStripMenuItem,
            this.categoryAdminLevelToolStripMenuItem});
            this.contextMenuStripCaterogy.Name = "contextMenuStripFolder";
            this.contextMenuStripCaterogy.Size = new System.Drawing.Size(161, 126);
            this.contextMenuStripCaterogy.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCaterogy_Opening);
            // 
            // addSubCategoryToolStripMenuItem
            // 
            this.addSubCategoryToolStripMenuItem.Image = global::DataCenter.Properties.Resources.Add;
            this.addSubCategoryToolStripMenuItem.Name = "addSubCategoryToolStripMenuItem";
            this.addSubCategoryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addSubCategoryToolStripMenuItem.Text = "اضافة مجلد فرعي";
            this.addSubCategoryToolStripMenuItem.Click += new System.EventHandler(this.addSubCategoryToolStripMenuItem_Click);
            // 
            // addMainCategoryToolStripMenuItem
            // 
            this.addMainCategoryToolStripMenuItem.Image = global::DataCenter.Properties.Resources.AddSub;
            this.addMainCategoryToolStripMenuItem.Name = "addMainCategoryToolStripMenuItem";
            this.addMainCategoryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addMainCategoryToolStripMenuItem.Text = "اضافة مجلد رئيسي";
            this.addMainCategoryToolStripMenuItem.Click += new System.EventHandler(this.addMainCategoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.Image = global::DataCenter.Properties.Resources.Delete;
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            this.deleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteCategoryToolStripMenuItem.Text = "حذف مجلد";
            this.deleteCategoryToolStripMenuItem.Click += new System.EventHandler(this.deleteCategoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // categoryPropertiesToolStripMenuItem
            // 
            this.categoryPropertiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoryPropertiesToolStripMenuItem.Image")));
            this.categoryPropertiesToolStripMenuItem.Name = "categoryPropertiesToolStripMenuItem";
            this.categoryPropertiesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.categoryPropertiesToolStripMenuItem.Text = "خصائص";
            this.categoryPropertiesToolStripMenuItem.Click += new System.EventHandler(this.categoryPropertiesToolStripMenuItem_Click);
            // 
            // categoryAdminLevelToolStripMenuItem
            // 
            this.categoryAdminLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryPermissionToolStripMenuItem,
            this.categoryHistoryToolStripMenuItem});
            this.categoryAdminLevelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoryAdminLevelToolStripMenuItem.Image")));
            this.categoryAdminLevelToolStripMenuItem.Name = "categoryAdminLevelToolStripMenuItem";
            this.categoryAdminLevelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.categoryAdminLevelToolStripMenuItem.Text = "خصائص المدير";
            // 
            // categoryPermissionToolStripMenuItem
            // 
            this.categoryPermissionToolStripMenuItem.Image = global::DataCenter.Properties.Resources.Permission;
            this.categoryPermissionToolStripMenuItem.Name = "categoryPermissionToolStripMenuItem";
            this.categoryPermissionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.categoryPermissionToolStripMenuItem.Text = "الصلاحيات";
            this.categoryPermissionToolStripMenuItem.Click += new System.EventHandler(this.categoryPermissionToolStripMenuItem_Click);
            // 
            // categoryHistoryToolStripMenuItem
            // 
            this.categoryHistoryToolStripMenuItem.Image = global::DataCenter.Properties.Resources.History;
            this.categoryHistoryToolStripMenuItem.Name = "categoryHistoryToolStripMenuItem";
            this.categoryHistoryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.categoryHistoryToolStripMenuItem.Text = "توثيق العمليات";
            this.categoryHistoryToolStripMenuItem.Click += new System.EventHandler(this.categoryHistoryToolStripMenuItem_Click);
            // 
            // qryCategoryBindingSource
            // 
            this.qryCategoryBindingSource.DataMember = "QryCategory";
            this.qryCategoryBindingSource.DataSource = this.dsQueries;
            // 
            // sharedImageCollectionCategory
            // 
            // 
            // 
            // 
            this.sharedImageCollectionCategory.ImageSource.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("sharedImageCollectionCategory.ImageSource.ImageStream")));
            this.sharedImageCollectionCategory.ImageSource.InsertImage(global::DataCenter.Properties.Resources.Category, "Category", typeof(global::DataCenter.Properties.Resources), 0);
            this.sharedImageCollectionCategory.ImageSource.Images.SetKeyName(0, "Category");
            this.sharedImageCollectionCategory.ParentControl = this;
            // 
            // gridControlFiles
            // 
            this.gridControlFiles.AllowDrop = true;
            this.gridControlFiles.ContextMenuStrip = this.contextMenuStripFile;
            this.gridControlFiles.DataSource = this.qryItemsBindingSource;
            this.gridControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlFiles.Location = new System.Drawing.Point(0, 0);
            this.gridControlFiles.MainView = this.gridViewFiles;
            this.gridControlFiles.Name = "gridControlFiles";
            this.gridControlFiles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1,
            this.repositoryItemDateEditDMY,
            this.repositoryItemPictureEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControlFiles.Size = new System.Drawing.Size(797, 433);
            this.gridControlFiles.TabIndex = 0;
            this.gridControlFiles.UseEmbeddedNavigator = true;
            this.gridControlFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFiles});
            this.gridControlFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlFiles_DragDrop);
            this.gridControlFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridControlFiles_DragEnter);
            this.gridControlFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControlFiles_MouseDown);
            this.gridControlFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridControlFiles_MouseMove);
            // 
            // gridViewFiles
            // 
            this.gridViewFiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeIconData,
            this.colItemName,
            this.colInfo,
            this.colCreateIn,
            this.colRealName,
            this.colModifyIn,
            this.colRealNameLastEdit,
            this.colLocker,
            this.colCategoryName,
            this.colTypeName,
            this.colCanInsert,
            this.colCanWrite,
            this.colCanDelete});
            this.gridViewFiles.GridControl = this.gridControlFiles;
            this.gridViewFiles.Name = "gridViewFiles";
            this.gridViewFiles.OptionsBehavior.Editable = false;
            this.gridViewFiles.OptionsCustomization.AllowRowSizing = true;
            this.gridViewFiles.OptionsView.ColumnAutoWidth = false;
            this.gridViewFiles.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFiles.OptionsView.ShowDetailButtons = false;
            this.gridViewFiles.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewFiles.OptionsView.ShowIndicator = false;
            this.gridViewFiles.OptionsView.ShowPreview = true;
            this.gridViewFiles.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewFiles.RowHeight = 30;
            this.gridViewFiles.CalcPreviewText += new DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(this.gridViewFiles_CalcPreviewText);
            // 
            // colTypeIconData
            // 
            this.colTypeIconData.AppearanceCell.Options.UseTextOptions = true;
            this.colTypeIconData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeIconData.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeIconData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeIconData.Caption = ".";
            this.colTypeIconData.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colTypeIconData.FieldName = "TypeIconData";
            this.colTypeIconData.Name = "colTypeIconData";
            this.colTypeIconData.Visible = true;
            this.colTypeIconData.VisibleIndex = 0;
            this.colTypeIconData.Width = 24;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.NullText = " ";
            // 
            // colItemName
            // 
            this.colItemName.AppearanceCell.Options.UseTextOptions = true;
            this.colItemName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemName.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemName.Caption = "اسم الملف";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 166;
            // 
            // colInfo
            // 
            this.colInfo.AppearanceCell.Options.UseTextOptions = true;
            this.colInfo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInfo.Caption = "معلومات";
            this.colInfo.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 4;
            this.colInfo.Width = 64;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colCreateIn
            // 
            this.colCreateIn.AppearanceCell.Options.UseTextOptions = true;
            this.colCreateIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreateIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colCreateIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreateIn.Caption = "تاريخ الانشاء";
            this.colCreateIn.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colCreateIn.FieldName = "CreateIn";
            this.colCreateIn.Name = "colCreateIn";
            this.colCreateIn.Visible = true;
            this.colCreateIn.VisibleIndex = 5;
            this.colCreateIn.Width = 77;
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
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "مسئول الانشاء";
            this.colRealName.FieldName = "RealNameOwner";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 6;
            this.colRealName.Width = 105;
            // 
            // colModifyIn
            // 
            this.colModifyIn.AppearanceCell.Options.UseTextOptions = true;
            this.colModifyIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifyIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifyIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifyIn.Caption = "تاريخ اخر تعديل";
            this.colModifyIn.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colModifyIn.FieldName = "ModifyIn";
            this.colModifyIn.Name = "colModifyIn";
            this.colModifyIn.Visible = true;
            this.colModifyIn.VisibleIndex = 7;
            this.colModifyIn.Width = 87;
            // 
            // colRealNameLastEdit
            // 
            this.colRealNameLastEdit.AppearanceCell.Options.UseTextOptions = true;
            this.colRealNameLastEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealNameLastEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealNameLastEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealNameLastEdit.Caption = "مسئول اخر تعديل";
            this.colRealNameLastEdit.FieldName = "RealNameLastEdit";
            this.colRealNameLastEdit.Name = "colRealNameLastEdit";
            this.colRealNameLastEdit.Visible = true;
            this.colRealNameLastEdit.VisibleIndex = 8;
            this.colRealNameLastEdit.Width = 100;
            // 
            // colLocker
            // 
            this.colLocker.AppearanceCell.Options.UseTextOptions = true;
            this.colLocker.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLocker.AppearanceHeader.Options.UseTextOptions = true;
            this.colLocker.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLocker.Caption = "مغلق";
            this.colLocker.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colLocker.FieldName = "Locker";
            this.colLocker.Name = "colLocker";
            this.colLocker.Visible = true;
            this.colLocker.VisibleIndex = 9;
            this.colLocker.Width = 45;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // colCategoryName
            // 
            this.colCategoryName.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoryName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoryName.Caption = "المجلد";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 3;
            this.colCategoryName.Width = 96;
            // 
            // colTypeName
            // 
            this.colTypeName.AppearanceCell.Options.UseTextOptions = true;
            this.colTypeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeName.Caption = "نوع الملف";
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 2;
            this.colTypeName.Width = 108;
            // 
            // colCanInsert
            // 
            this.colCanInsert.Caption = "سماحية الاضافة";
            this.colCanInsert.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colCanInsert.FieldName = "CanInsert";
            this.colCanInsert.Name = "colCanInsert";
            this.colCanInsert.Visible = true;
            this.colCanInsert.VisibleIndex = 10;
            this.colCanInsert.Width = 93;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // colCanWrite
            // 
            this.colCanWrite.AppearanceCell.Options.UseTextOptions = true;
            this.colCanWrite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanWrite.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanWrite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanWrite.Caption = "سماحية التعديل";
            this.colCanWrite.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colCanWrite.FieldName = "CanWrite";
            this.colCanWrite.Name = "colCanWrite";
            this.colCanWrite.Visible = true;
            this.colCanWrite.VisibleIndex = 11;
            this.colCanWrite.Width = 93;
            // 
            // colCanDelete
            // 
            this.colCanDelete.AppearanceCell.Options.UseTextOptions = true;
            this.colCanDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanDelete.Caption = "سماحية الحذف";
            this.colCanDelete.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colCanDelete.FieldName = "CanDelete";
            this.colCanDelete.Name = "colCanDelete";
            this.colCanDelete.Visible = true;
            this.colCanDelete.VisibleIndex = 12;
            this.colCanDelete.Width = 89;
            // 
            // qryCategoryTableAdapter
            // 
            this.qryCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // ItemBrowserFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 445);
            this.Controls.Add(this.splitContainerControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemBrowserFrm";
            this.Text = "الملفات";
            this.Load += new System.EventHandler(this.ItemBrowserFrm_Load);
            this.contextMenuStripFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlCategory)).EndInit();
            this.contextMenuStripCaterogy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollectionCategory.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollectionCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem DeleteFiletoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem FileProperitestoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileAdminLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filePermissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileHistoryToolStripMenuItem;
        private System.Windows.Forms.BindingSource qryItemsBindingSource;
        private DataSources.dsQueries dsQueries;
        private DataSources.dsQueriesTableAdapters.QryItemsTableAdapter qryItemsTableAdapter;
        private DataSources.dsDataCenter dsDataCenter;
        private DataSources.dsDataCenterTableAdapters.ItemTableAdapter itemTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraTreeList.TreeList tlCategory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategoryName1;
        private DevExpress.XtraGrid.GridControl gridControlFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFiles;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeIconData;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyIn;
        private DevExpress.XtraGrid.Columns.GridColumn colRealNameLastEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colLocker;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCanInsert;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCanWrite;
        private DevExpress.XtraGrid.Columns.GridColumn colCanDelete;
        private System.Windows.Forms.BindingSource qryCategoryBindingSource;
        private DataSources.dsQueriesTableAdapters.QryCategoryTableAdapter qryCategoryTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCaterogy;
        private System.Windows.Forms.ToolStripMenuItem addSubCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMainCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem categoryPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryAdminLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryPermissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryHistoryToolStripMenuItem;
        private DevExpress.Utils.SharedImageCollection sharedImageCollectionCategory;
        private System.Windows.Forms.ToolStripMenuItem viewFileToolStripMenuItem;
    }
}