namespace DataCenter.Forms
{
    partial class CategoryPermissionEditorDLG
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
            this.gcCommands = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageUser = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlUser = new DevExpress.XtraGrid.GridControl();
            this.categoryUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDataCenter = new DataCenter.DataSources.dsDataCenter();
            this.gridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditGrantId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lSMSGrant = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditUserUserID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lSMSUser = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanRead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanWrite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanInsert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInheritance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInheritanceCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditInheritanceCategoryId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lSMSCategory = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colUserLevelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditUserLevelId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.userLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserLevelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditUserSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colUserDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditUserDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.xtraTabPageRole = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlRole = new DevExpress.XtraGrid.GridControl();
            this.categoryRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditRoleGrantId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditRoleID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lSMSRole = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditRoleInheritanceCategoryId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditRoleUserLevelId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserLevelName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditRoleSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditRoleDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.categoryUserTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.CategoryUserTableAdapter();
            this.userLevelTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.UserLevelTableAdapter();
            this.categoryRoleTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.CategoryRoleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).BeginInit();
            this.gcCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditGrantId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSGrant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditInheritanceCategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserLevelId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditUserSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditUserDelete)).BeginInit();
            this.xtraTabPageRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleGrantId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditRoleInheritanceCategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleUserLevelId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRoleSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRoleDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCommands
            // 
            this.gcCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCommands.AppearanceCaption.Options.UseTextOptions = true;
            this.gcCommands.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcCommands.Controls.Add(this.btnClose);
            this.gcCommands.Controls.Add(this.btnSave);
            this.gcCommands.Location = new System.Drawing.Point(12, 295);
            this.gcCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCommands.Name = "gcCommands";
            this.gcCommands.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcCommands.Size = new System.Drawing.Size(815, 61);
            this.gcCommands.TabIndex = 1;
            this.gcCommands.Text = "اوامر";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::DataCenter.Properties.Resources.Delete;
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(6, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::DataCenter.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(687, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Far;
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageUser;
            this.xtraTabControl1.Size = new System.Drawing.Size(815, 270);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageUser,
            this.xtraTabPageRole});
            // 
            // xtraTabPageUser
            // 
            this.xtraTabPageUser.Controls.Add(this.gridControlUser);
            this.xtraTabPageUser.Image = global::DataCenter.Properties.Resources.UserPriv;
            this.xtraTabPageUser.Name = "xtraTabPageUser";
            this.xtraTabPageUser.Size = new System.Drawing.Size(809, 223);
            this.xtraTabPageUser.Text = "المستخدمين";
            // 
            // gridControlUser
            // 
            this.gridControlUser.DataSource = this.categoryUserBindingSource;
            this.gridControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUser.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlUser.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlUser.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlUser.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlUser.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlUser.Location = new System.Drawing.Point(0, 0);
            this.gridControlUser.MainView = this.gridViewUser;
            this.gridControlUser.Name = "gridControlUser";
            this.gridControlUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditUserSave,
            this.repositoryItemButtonEditUserDelete,
            this.repositoryItemGridLookUpEditUserLevelId,
            this.repositoryItemLookUpEditInheritanceCategoryId,
            this.repositoryItemGridLookUpEditUserUserID,
            this.repositoryItemGridLookUpEditGrantId});
            this.gridControlUser.Size = new System.Drawing.Size(809, 223);
            this.gridControlUser.TabIndex = 0;
            this.gridControlUser.UseEmbeddedNavigator = true;
            this.gridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUser});
            // 
            // categoryUserBindingSource
            // 
            this.categoryUserBindingSource.DataMember = "CategoryUser";
            this.categoryUserBindingSource.DataSource = this.dsDataCenter;
            // 
            // dsDataCenter
            // 
            this.dsDataCenter.DataSetName = "dsDataCenter";
            this.dsDataCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewUser
            // 
            this.gridViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantId,
            this.colUserID,
            this.colCanRead,
            this.colCanWrite,
            this.colCanInsert,
            this.colCanDelete,
            this.colInheritance,
            this.colInheritanceCategoryId,
            this.colUserLevelId,
            this.colUserEdit,
            this.colUserDelete});
            this.gridViewUser.GridControl = this.gridControlUser;
            this.gridViewUser.Name = "gridViewUser";
            this.gridViewUser.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewUser.OptionsView.ColumnAutoWidth = false;
            this.gridViewUser.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewUser.OptionsView.ShowAutoFilterRow = true;
            this.gridViewUser.OptionsView.ShowDetailButtons = false;
            this.gridViewUser.OptionsView.ShowGroupPanel = false;
            this.gridViewUser.OptionsView.ShowIndicator = false;
            this.gridViewUser.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewUser_ShowingEditor);
            this.gridViewUser.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewUser_InitNewRow);
            this.gridViewUser.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewUser_InvalidRowException);
            // 
            // colGrantId
            // 
            this.colGrantId.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId.Caption = "نوع السماحية";
            this.colGrantId.ColumnEdit = this.repositoryItemGridLookUpEditGrantId;
            this.colGrantId.FieldName = "GrantId";
            this.colGrantId.Name = "colGrantId";
            this.colGrantId.Visible = true;
            this.colGrantId.VisibleIndex = 0;
            this.colGrantId.Width = 82;
            // 
            // repositoryItemGridLookUpEditGrantId
            // 
            this.repositoryItemGridLookUpEditGrantId.AutoHeight = false;
            this.repositoryItemGridLookUpEditGrantId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditGrantId.DataSource = this.lSMSGrant;
            this.repositoryItemGridLookUpEditGrantId.DisplayMember = "GrantName";
            this.repositoryItemGridLookUpEditGrantId.Name = "repositoryItemGridLookUpEditGrantId";
            this.repositoryItemGridLookUpEditGrantId.NullText = "";
            this.repositoryItemGridLookUpEditGrantId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditGrantId.ValueMember = "GrantId";
            this.repositoryItemGridLookUpEditGrantId.View = this.gridView2;
            // 
            // lSMSGrant
            // 
            this.lSMSGrant.ElementType = typeof(DataCenter.DataSources.Linq.vGrant);
            this.lSMSGrant.KeyExpression = "GrantId";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colGrantName
            // 
            this.colGrantName.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName.Caption = "نوع السماحية";
            this.colGrantName.FieldName = "GrantName";
            this.colGrantName.Name = "colGrantName";
            this.colGrantName.Visible = true;
            this.colGrantName.VisibleIndex = 0;
            // 
            // colUserID
            // 
            this.colUserID.AppearanceCell.Options.UseTextOptions = true;
            this.colUserID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserID.Caption = "المستخدم";
            this.colUserID.ColumnEdit = this.repositoryItemGridLookUpEditUserUserID;
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 1;
            this.colUserID.Width = 119;
            // 
            // repositoryItemGridLookUpEditUserUserID
            // 
            this.repositoryItemGridLookUpEditUserUserID.AutoHeight = false;
            this.repositoryItemGridLookUpEditUserUserID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditUserUserID.DataSource = this.lSMSUser;
            this.repositoryItemGridLookUpEditUserUserID.DisplayMember = "RealName";
            this.repositoryItemGridLookUpEditUserUserID.Name = "repositoryItemGridLookUpEditUserUserID";
            this.repositoryItemGridLookUpEditUserUserID.NullText = "";
            this.repositoryItemGridLookUpEditUserUserID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditUserUserID.ValueMember = "UserID";
            this.repositoryItemGridLookUpEditUserUserID.View = this.gridView1;
            // 
            // lSMSUser
            // 
            this.lSMSUser.ElementType = typeof(DataCenter.DataSources.Linq.vUser);
            this.lSMSUser.KeyExpression = "UserID";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRealName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "اسم المستخدم";
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 0;
            // 
            // colCanRead
            // 
            this.colCanRead.AppearanceCell.Options.UseTextOptions = true;
            this.colCanRead.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanRead.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanRead.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanRead.Caption = "قرائة";
            this.colCanRead.FieldName = "CanRead";
            this.colCanRead.Name = "colCanRead";
            this.colCanRead.Visible = true;
            this.colCanRead.VisibleIndex = 2;
            this.colCanRead.Width = 41;
            // 
            // colCanWrite
            // 
            this.colCanWrite.AppearanceCell.Options.UseTextOptions = true;
            this.colCanWrite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanWrite.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanWrite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanWrite.Caption = "تعديل";
            this.colCanWrite.FieldName = "CanWrite";
            this.colCanWrite.Name = "colCanWrite";
            this.colCanWrite.Visible = true;
            this.colCanWrite.VisibleIndex = 3;
            this.colCanWrite.Width = 45;
            // 
            // colCanInsert
            // 
            this.colCanInsert.AppearanceCell.Options.UseTextOptions = true;
            this.colCanInsert.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanInsert.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanInsert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanInsert.Caption = "اضافة";
            this.colCanInsert.FieldName = "CanInsert";
            this.colCanInsert.Name = "colCanInsert";
            this.colCanInsert.Visible = true;
            this.colCanInsert.VisibleIndex = 4;
            this.colCanInsert.Width = 45;
            // 
            // colCanDelete
            // 
            this.colCanDelete.AppearanceCell.Options.UseTextOptions = true;
            this.colCanDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanDelete.Caption = "حذف";
            this.colCanDelete.FieldName = "CanDelete";
            this.colCanDelete.Name = "colCanDelete";
            this.colCanDelete.Visible = true;
            this.colCanDelete.VisibleIndex = 5;
            this.colCanDelete.Width = 42;
            // 
            // colInheritance
            // 
            this.colInheritance.AppearanceCell.Options.UseTextOptions = true;
            this.colInheritance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInheritance.AppearanceHeader.Options.UseTextOptions = true;
            this.colInheritance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInheritance.Caption = "سماحية مشتركة";
            this.colInheritance.FieldName = "Inheritance";
            this.colInheritance.Name = "colInheritance";
            this.colInheritance.Visible = true;
            this.colInheritance.VisibleIndex = 6;
            this.colInheritance.Width = 98;
            // 
            // colInheritanceCategoryId
            // 
            this.colInheritanceCategoryId.AppearanceCell.Options.UseTextOptions = true;
            this.colInheritanceCategoryId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInheritanceCategoryId.AppearanceHeader.Options.UseTextOptions = true;
            this.colInheritanceCategoryId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInheritanceCategoryId.Caption = "مجلد السماحية المشتركة";
            this.colInheritanceCategoryId.ColumnEdit = this.repositoryItemLookUpEditInheritanceCategoryId;
            this.colInheritanceCategoryId.FieldName = "InheritanceCategoryId";
            this.colInheritanceCategoryId.Name = "colInheritanceCategoryId";
            this.colInheritanceCategoryId.OptionsColumn.AllowEdit = false;
            this.colInheritanceCategoryId.OptionsColumn.ReadOnly = true;
            this.colInheritanceCategoryId.Visible = true;
            this.colInheritanceCategoryId.VisibleIndex = 10;
            this.colInheritanceCategoryId.Width = 138;
            // 
            // repositoryItemLookUpEditInheritanceCategoryId
            // 
            this.repositoryItemLookUpEditInheritanceCategoryId.AutoHeight = false;
            this.repositoryItemLookUpEditInheritanceCategoryId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditInheritanceCategoryId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "اسم المجلد", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditInheritanceCategoryId.DataSource = this.lSMSCategory;
            this.repositoryItemLookUpEditInheritanceCategoryId.DisplayMember = "CategoryName";
            this.repositoryItemLookUpEditInheritanceCategoryId.Name = "repositoryItemLookUpEditInheritanceCategoryId";
            this.repositoryItemLookUpEditInheritanceCategoryId.NullText = "";
            this.repositoryItemLookUpEditInheritanceCategoryId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditInheritanceCategoryId.ValueMember = "CategoryId";
            // 
            // lSMSCategory
            // 
            this.lSMSCategory.ElementType = typeof(DataCenter.DataSources.Linq.vCategory);
            this.lSMSCategory.KeyExpression = "CategoryId";
            // 
            // colUserLevelId
            // 
            this.colUserLevelId.AppearanceCell.Options.UseTextOptions = true;
            this.colUserLevelId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserLevelId.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserLevelId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserLevelId.Caption = "مستوي السماحية";
            this.colUserLevelId.ColumnEdit = this.repositoryItemGridLookUpEditUserLevelId;
            this.colUserLevelId.FieldName = "UserLevelId";
            this.colUserLevelId.Name = "colUserLevelId";
            this.colUserLevelId.Visible = true;
            this.colUserLevelId.VisibleIndex = 7;
            this.colUserLevelId.Width = 104;
            // 
            // repositoryItemGridLookUpEditUserLevelId
            // 
            this.repositoryItemGridLookUpEditUserLevelId.AutoHeight = false;
            this.repositoryItemGridLookUpEditUserLevelId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditUserLevelId.DataSource = this.userLevelBindingSource;
            this.repositoryItemGridLookUpEditUserLevelId.DisplayMember = "UserLevelName";
            this.repositoryItemGridLookUpEditUserLevelId.Name = "repositoryItemGridLookUpEditUserLevelId";
            this.repositoryItemGridLookUpEditUserLevelId.NullText = "";
            this.repositoryItemGridLookUpEditUserLevelId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditUserLevelId.ValueMember = "UserLevelId";
            this.repositoryItemGridLookUpEditUserLevelId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // userLevelBindingSource
            // 
            this.userLevelBindingSource.DataMember = "UserLevel";
            this.userLevelBindingSource.DataSource = this.dsDataCenter;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserLevelName});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colUserLevelName
            // 
            this.colUserLevelName.Caption = "اسم المستوي";
            this.colUserLevelName.FieldName = "UserLevelName";
            this.colUserLevelName.Name = "colUserLevelName";
            this.colUserLevelName.Visible = true;
            this.colUserLevelName.VisibleIndex = 0;
            // 
            // colUserEdit
            // 
            this.colUserEdit.AppearanceCell.Options.UseTextOptions = true;
            this.colUserEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserEdit.Caption = "حفظ";
            this.colUserEdit.ColumnEdit = this.repositoryItemButtonEditUserSave;
            this.colUserEdit.Name = "colUserEdit";
            this.colUserEdit.Visible = true;
            this.colUserEdit.VisibleIndex = 8;
            this.colUserEdit.Width = 46;
            // 
            // repositoryItemButtonEditUserSave
            // 
            this.repositoryItemButtonEditUserSave.AutoHeight = false;
            this.repositoryItemButtonEditUserSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditUserSave.Name = "repositoryItemButtonEditUserSave";
            this.repositoryItemButtonEditUserSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditUserSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditUserSave_ButtonClick);
            // 
            // colUserDelete
            // 
            this.colUserDelete.AppearanceCell.Options.UseTextOptions = true;
            this.colUserDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserDelete.Caption = "حذف";
            this.colUserDelete.ColumnEdit = this.repositoryItemButtonEditUserDelete;
            this.colUserDelete.Name = "colUserDelete";
            this.colUserDelete.Visible = true;
            this.colUserDelete.VisibleIndex = 9;
            this.colUserDelete.Width = 42;
            // 
            // repositoryItemButtonEditUserDelete
            // 
            this.repositoryItemButtonEditUserDelete.AutoHeight = false;
            this.repositoryItemButtonEditUserDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditUserDelete.Name = "repositoryItemButtonEditUserDelete";
            this.repositoryItemButtonEditUserDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditUserDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditUserDelete_ButtonClick);
            // 
            // xtraTabPageRole
            // 
            this.xtraTabPageRole.Controls.Add(this.gridControlRole);
            this.xtraTabPageRole.Image = global::DataCenter.Properties.Resources.RolePriv;
            this.xtraTabPageRole.Name = "xtraTabPageRole";
            this.xtraTabPageRole.Size = new System.Drawing.Size(809, 223);
            this.xtraTabPageRole.Text = "المجموعات";
            // 
            // gridControlRole
            // 
            this.gridControlRole.DataSource = this.categoryRoleBindingSource;
            this.gridControlRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRole.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlRole.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlRole.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlRole.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlRole.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlRole.Location = new System.Drawing.Point(0, 0);
            this.gridControlRole.MainView = this.gridViewRole;
            this.gridControlRole.Name = "gridControlRole";
            this.gridControlRole.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditRoleSave,
            this.repositoryItemButtonEditRoleDelete,
            this.repositoryItemGridLookUpEditRoleUserLevelId,
            this.repositoryItemLookUpEditRoleInheritanceCategoryId,
            this.repositoryItemGridLookUpEditRoleID,
            this.repositoryItemGridLookUpEditRoleGrantId});
            this.gridControlRole.Size = new System.Drawing.Size(809, 223);
            this.gridControlRole.TabIndex = 1;
            this.gridControlRole.UseEmbeddedNavigator = true;
            this.gridControlRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRole});
            // 
            // categoryRoleBindingSource
            // 
            this.categoryRoleBindingSource.DataMember = "CategoryRole";
            this.categoryRoleBindingSource.DataSource = this.dsDataCenter;
            // 
            // gridViewRole
            // 
            this.gridViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantId1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridViewRole.GridControl = this.gridControlRole;
            this.gridViewRole.Name = "gridViewRole";
            this.gridViewRole.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewRole.OptionsView.ColumnAutoWidth = false;
            this.gridViewRole.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewRole.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRole.OptionsView.ShowDetailButtons = false;
            this.gridViewRole.OptionsView.ShowGroupPanel = false;
            this.gridViewRole.OptionsView.ShowIndicator = false;
            this.gridViewRole.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewRole_ShowingEditor);
            this.gridViewRole.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewRole_InitNewRow);
            this.gridViewRole.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewRole_InvalidRowException);
            // 
            // colGrantId1
            // 
            this.colGrantId1.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantId1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId1.Caption = "نوع السماحية";
            this.colGrantId1.ColumnEdit = this.repositoryItemGridLookUpEditRoleGrantId;
            this.colGrantId1.FieldName = "GrantId";
            this.colGrantId1.Name = "colGrantId1";
            this.colGrantId1.Visible = true;
            this.colGrantId1.VisibleIndex = 0;
            this.colGrantId1.Width = 82;
            // 
            // repositoryItemGridLookUpEditRoleGrantId
            // 
            this.repositoryItemGridLookUpEditRoleGrantId.AutoHeight = false;
            this.repositoryItemGridLookUpEditRoleGrantId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditRoleGrantId.DataSource = this.lSMSGrant;
            this.repositoryItemGridLookUpEditRoleGrantId.DisplayMember = "GrantName";
            this.repositoryItemGridLookUpEditRoleGrantId.Name = "repositoryItemGridLookUpEditRoleGrantId";
            this.repositoryItemGridLookUpEditRoleGrantId.NullText = "";
            this.repositoryItemGridLookUpEditRoleGrantId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditRoleGrantId.ValueMember = "GrantId";
            this.repositoryItemGridLookUpEditRoleGrantId.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantName1});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colGrantName1
            // 
            this.colGrantName1.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName1.Caption = "نوع السماحية";
            this.colGrantName1.FieldName = "GrantName";
            this.colGrantName1.Name = "colGrantName1";
            this.colGrantName1.Visible = true;
            this.colGrantName1.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "مجموعة";
            this.gridColumn1.ColumnEdit = this.repositoryItemGridLookUpEditRoleID;
            this.gridColumn1.FieldName = "RoleID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 119;
            // 
            // repositoryItemGridLookUpEditRoleID
            // 
            this.repositoryItemGridLookUpEditRoleID.AutoHeight = false;
            this.repositoryItemGridLookUpEditRoleID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditRoleID.DataSource = this.lSMSRole;
            this.repositoryItemGridLookUpEditRoleID.DisplayMember = "RoleName";
            this.repositoryItemGridLookUpEditRoleID.Name = "repositoryItemGridLookUpEditRoleID";
            this.repositoryItemGridLookUpEditRoleID.NullText = "";
            this.repositoryItemGridLookUpEditRoleID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditRoleID.ValueMember = "RoleID";
            this.repositoryItemGridLookUpEditRoleID.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // lSMSRole
            // 
            this.lSMSRole.ElementType = typeof(DataCenter.DataSources.Linq.vRole);
            this.lSMSRole.KeyExpression = "RoleID";
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleName,
            this.colRoleDesc});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colRoleName
            // 
            this.colRoleName.AppearanceCell.Options.UseTextOptions = true;
            this.colRoleName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleName.Caption = "اسم المجموعة";
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 0;
            // 
            // colRoleDesc
            // 
            this.colRoleDesc.AppearanceCell.Options.UseTextOptions = true;
            this.colRoleDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleDesc.Caption = "معلومات";
            this.colRoleDesc.FieldName = "RoleDesc";
            this.colRoleDesc.Name = "colRoleDesc";
            this.colRoleDesc.Visible = true;
            this.colRoleDesc.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "قرائة";
            this.gridColumn2.FieldName = "CanRead";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 41;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "تعديل";
            this.gridColumn3.FieldName = "CanWrite";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 45;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "اضافة";
            this.gridColumn4.FieldName = "CanInsert";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 45;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "حذف";
            this.gridColumn5.FieldName = "CanDelete";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 42;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "سماحية مشتركة";
            this.gridColumn6.FieldName = "Inheritance";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 98;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "مجلد السماحية المشتركة";
            this.gridColumn7.ColumnEdit = this.repositoryItemLookUpEditRoleInheritanceCategoryId;
            this.gridColumn7.FieldName = "InheritanceCategoryId";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 10;
            this.gridColumn7.Width = 138;
            // 
            // repositoryItemLookUpEditRoleInheritanceCategoryId
            // 
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.AutoHeight = false;
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "اسم المجلد", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.DataSource = this.lSMSCategory;
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.DisplayMember = "CategoryName";
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.Name = "repositoryItemLookUpEditRoleInheritanceCategoryId";
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.NullText = "";
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditRoleInheritanceCategoryId.ValueMember = "CategoryId";
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "مستوي السماحية";
            this.gridColumn8.ColumnEdit = this.repositoryItemGridLookUpEditRoleUserLevelId;
            this.gridColumn8.FieldName = "UserLevelId";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 104;
            // 
            // repositoryItemGridLookUpEditRoleUserLevelId
            // 
            this.repositoryItemGridLookUpEditRoleUserLevelId.AutoHeight = false;
            this.repositoryItemGridLookUpEditRoleUserLevelId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditRoleUserLevelId.DataSource = this.userLevelBindingSource;
            this.repositoryItemGridLookUpEditRoleUserLevelId.DisplayMember = "UserLevelName";
            this.repositoryItemGridLookUpEditRoleUserLevelId.Name = "repositoryItemGridLookUpEditRoleUserLevelId";
            this.repositoryItemGridLookUpEditRoleUserLevelId.NullText = "";
            this.repositoryItemGridLookUpEditRoleUserLevelId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditRoleUserLevelId.ValueMember = "UserLevelId";
            this.repositoryItemGridLookUpEditRoleUserLevelId.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserLevelName1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colUserLevelName1
            // 
            this.colUserLevelName1.AppearanceCell.Options.UseTextOptions = true;
            this.colUserLevelName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserLevelName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserLevelName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserLevelName1.Caption = "اسم المستوي";
            this.colUserLevelName1.FieldName = "UserLevelName";
            this.colUserLevelName1.Name = "colUserLevelName1";
            this.colUserLevelName1.Visible = true;
            this.colUserLevelName1.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "حفظ";
            this.gridColumn9.ColumnEdit = this.repositoryItemButtonEditRoleSave;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 46;
            // 
            // repositoryItemButtonEditRoleSave
            // 
            this.repositoryItemButtonEditRoleSave.AutoHeight = false;
            this.repositoryItemButtonEditRoleSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditRoleSave.Name = "repositoryItemButtonEditRoleSave";
            this.repositoryItemButtonEditRoleSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditRoleSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditRoleSave_ButtonClick);
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "حذف";
            this.gridColumn10.ColumnEdit = this.repositoryItemButtonEditRoleDelete;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 42;
            // 
            // repositoryItemButtonEditRoleDelete
            // 
            this.repositoryItemButtonEditRoleDelete.AutoHeight = false;
            this.repositoryItemButtonEditRoleDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditRoleDelete.Name = "repositoryItemButtonEditRoleDelete";
            this.repositoryItemButtonEditRoleDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditRoleDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditRoleDelete_ButtonClick);
            // 
            // categoryUserTableAdapter
            // 
            this.categoryUserTableAdapter.ClearBeforeFill = true;
            // 
            // userLevelTableAdapter
            // 
            this.userLevelTableAdapter.ClearBeforeFill = true;
            // 
            // categoryRoleTableAdapter
            // 
            this.categoryRoleTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryPermissionEditorDLG
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(831, 361);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gcCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CategoryPermissionEditorDLG";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "محرر الصلاحيات";
            this.Load += new System.EventHandler(this.CategoryEditorDLG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).EndInit();
            this.gcCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditGrantId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSGrant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditInheritanceCategoryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserLevelId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditUserSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditUserDelete)).EndInit();
            this.xtraTabPageRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleGrantId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditRoleInheritanceCategoryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleUserLevelId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRoleSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRoleDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcCommands;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageUser;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageRole;
        private DevExpress.XtraGrid.GridControl gridControlUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUser;
        private DataSources.dsDataCenter dsDataCenter;
        private System.Windows.Forms.BindingSource categoryUserBindingSource;
        private DataSources.dsDataCenterTableAdapters.CategoryUserTableAdapter categoryUserTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colCanRead;
        private DevExpress.XtraGrid.Columns.GridColumn colCanWrite;
        private DevExpress.XtraGrid.Columns.GridColumn colCanInsert;
        private DevExpress.XtraGrid.Columns.GridColumn colCanDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colInheritance;
        private DevExpress.XtraGrid.Columns.GridColumn colUserEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditUserSave;
        private DevExpress.XtraGrid.Columns.GridColumn colUserDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditUserDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colInheritanceCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserLevelId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditUserLevelId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource userLevelBindingSource;
        private DataSources.dsDataCenterTableAdapters.UserLevelTableAdapter userLevelTableAdapter;
        private DevExpress.Data.Linq.LinqServerModeSource lSMSCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditInheritanceCategoryId;
        private DevExpress.XtraGrid.GridControl gridControlRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditRoleInheritanceCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRoleUserLevelId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditRoleSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditRoleDelete;
        private System.Windows.Forms.BindingSource categoryRoleBindingSource;
        private DataSources.dsDataCenterTableAdapters.CategoryRoleTableAdapter categoryRoleTableAdapter;
        private DevExpress.Data.Linq.LinqServerModeSource lSMSUser;
        private DevExpress.Data.Linq.LinqServerModeSource lSMSRole;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRoleID;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colUserLevelName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserLevelName1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditUserUserID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantId;
        private DevExpress.Data.Linq.LinqServerModeSource lSMSGrant;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditGrantId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantId1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRoleGrantId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantName1;
    }
}