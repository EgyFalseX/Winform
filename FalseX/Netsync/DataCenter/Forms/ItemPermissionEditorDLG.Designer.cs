namespace DataCenter.Forms
{
    partial class ItemPermissionEditorDLG
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
            this.itemUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDataCenter = new DataCenter.DataSources.dsDataCenter();
            this.gridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditUserGrantId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lSMSGrant = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantName3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditUserUserID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lSMSUser = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanRead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanWrite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanInsert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditUserSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colUserDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditUserDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.xtraTabPageRole = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlRole = new DevExpress.XtraGrid.GridControl();
            this.itemRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantId3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditRoleGrantId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantName2 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditRoleSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditRoleDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.xtraTabPageCategoryInfo = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageCatUser = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlCategoryUser = new DevExpress.XtraGrid.GridControl();
            this.categoryUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCategoryUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCatUserGrantId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit5View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lSMSCategory = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.userLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageCatRole = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlCategoryRole = new DevExpress.XtraGrid.GridControl();
            this.categoryRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCategoryRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCatRoleGrantId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrantName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryUserTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.CategoryUserTableAdapter();
            this.userLevelTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.UserLevelTableAdapter();
            this.categoryRoleTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.CategoryRoleTableAdapter();
            this.xtraTabPageCategoryRole = new DevExpress.XtraTab.XtraTabPage();
            this.itemUserTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.ItemUserTableAdapter();
            this.itemRoleTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.ItemRoleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).BeginInit();
            this.gcCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserGrantId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSGrant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditUserSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditUserDelete)).BeginInit();
            this.xtraTabPageRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleGrantId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRoleSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRoleDelete)).BeginInit();
            this.xtraTabPageCategoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPageCatUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategoryUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoryUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCatUserGrantId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.xtraTabPageCatRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategoryRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoryRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCatRoleGrantId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
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
            this.xtraTabPageRole,
            this.xtraTabPageCategoryInfo});
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
            this.gridControlUser.DataSource = this.itemUserBindingSource;
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
            this.repositoryItemGridLookUpEditUserUserID,
            this.repositoryItemGridLookUpEditUserGrantId});
            this.gridControlUser.Size = new System.Drawing.Size(809, 223);
            this.gridControlUser.TabIndex = 0;
            this.gridControlUser.UseEmbeddedNavigator = true;
            this.gridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUser});
            // 
            // itemUserBindingSource
            // 
            this.itemUserBindingSource.DataMember = "ItemUser";
            this.itemUserBindingSource.DataSource = this.dsDataCenter;
            // 
            // dsDataCenter
            // 
            this.dsDataCenter.DataSetName = "dsDataCenter";
            this.dsDataCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewUser
            // 
            this.gridViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantId2,
            this.colUserID,
            this.colCanRead,
            this.colCanWrite,
            this.colCanInsert,
            this.colCanDelete,
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
            this.gridViewUser.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewUser_InitNewRow);
            this.gridViewUser.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewUser_InvalidRowException);
            // 
            // colGrantId2
            // 
            this.colGrantId2.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantId2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId2.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantId2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId2.Caption = "نوع السماحية";
            this.colGrantId2.ColumnEdit = this.repositoryItemGridLookUpEditUserGrantId;
            this.colGrantId2.FieldName = "GrantId";
            this.colGrantId2.Name = "colGrantId2";
            this.colGrantId2.Visible = true;
            this.colGrantId2.VisibleIndex = 0;
            this.colGrantId2.Width = 82;
            // 
            // repositoryItemGridLookUpEditUserGrantId
            // 
            this.repositoryItemGridLookUpEditUserGrantId.AutoHeight = false;
            this.repositoryItemGridLookUpEditUserGrantId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditUserGrantId.DataSource = this.lSMSGrant;
            this.repositoryItemGridLookUpEditUserGrantId.DisplayMember = "GrantName";
            this.repositoryItemGridLookUpEditUserGrantId.Name = "repositoryItemGridLookUpEditUserGrantId";
            this.repositoryItemGridLookUpEditUserGrantId.NullText = "";
            this.repositoryItemGridLookUpEditUserGrantId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditUserGrantId.ValueMember = "GrantId";
            this.repositoryItemGridLookUpEditUserGrantId.View = this.gridView9;
            // 
            // lSMSGrant
            // 
            this.lSMSGrant.ElementType = typeof(DataCenter.DataSources.Linq.vGrant);
            this.lSMSGrant.KeyExpression = "GrantId";
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantName3});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // colGrantName3
            // 
            this.colGrantName3.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantName3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName3.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantName3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName3.Caption = "نوع السماحية";
            this.colGrantName3.FieldName = "GrantName";
            this.colGrantName3.Name = "colGrantName3";
            this.colGrantName3.Visible = true;
            this.colGrantName3.VisibleIndex = 0;
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
            this.colUserEdit.VisibleIndex = 6;
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
            this.colUserDelete.VisibleIndex = 7;
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
            this.gridControlRole.DataSource = this.itemRoleBindingSource;
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
            this.repositoryItemGridLookUpEditRoleID,
            this.repositoryItemGridLookUpEditRoleGrantId});
            this.gridControlRole.Size = new System.Drawing.Size(809, 223);
            this.gridControlRole.TabIndex = 1;
            this.gridControlRole.UseEmbeddedNavigator = true;
            this.gridControlRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRole});
            // 
            // itemRoleBindingSource
            // 
            this.itemRoleBindingSource.DataMember = "ItemRole";
            this.itemRoleBindingSource.DataSource = this.dsDataCenter;
            // 
            // gridViewRole
            // 
            this.gridViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantId3,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
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
            this.gridViewRole.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewRole_InitNewRow);
            this.gridViewRole.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewRole_InvalidRowException);
            // 
            // colGrantId3
            // 
            this.colGrantId3.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantId3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId3.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantId3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId3.Caption = "نوع السماحية";
            this.colGrantId3.ColumnEdit = this.repositoryItemGridLookUpEditRoleGrantId;
            this.colGrantId3.FieldName = "GrantId";
            this.colGrantId3.Name = "colGrantId3";
            this.colGrantId3.Visible = true;
            this.colGrantId3.VisibleIndex = 0;
            this.colGrantId3.Width = 82;
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
            this.colGrantName2});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colGrantName2
            // 
            this.colGrantName2.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantName2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName2.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantName2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName2.Caption = "نوع السماحية";
            this.colGrantName2.FieldName = "GrantName";
            this.colGrantName2.Name = "colGrantName2";
            this.colGrantName2.Visible = true;
            this.colGrantName2.VisibleIndex = 0;
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
            this.gridColumn9.VisibleIndex = 6;
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
            this.gridColumn10.VisibleIndex = 7;
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
            // xtraTabPageCategoryInfo
            // 
            this.xtraTabPageCategoryInfo.Controls.Add(this.xtraTabControl3);
            this.xtraTabPageCategoryInfo.Image = global::DataCenter.Properties.Resources.Properties;
            this.xtraTabPageCategoryInfo.Name = "xtraTabPageCategoryInfo";
            this.xtraTabPageCategoryInfo.Size = new System.Drawing.Size(809, 223);
            this.xtraTabPageCategoryInfo.Text = "صلاحيات المجلد";
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPageCatUser;
            this.xtraTabControl3.Size = new System.Drawing.Size(809, 223);
            this.xtraTabControl3.TabIndex = 3;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageCatUser,
            this.xtraTabPageCatRole});
            // 
            // xtraTabPageCatUser
            // 
            this.xtraTabPageCatUser.Controls.Add(this.gridControlCategoryUser);
            this.xtraTabPageCatUser.Image = global::DataCenter.Properties.Resources.UserPriv;
            this.xtraTabPageCatUser.Name = "xtraTabPageCatUser";
            this.xtraTabPageCatUser.Size = new System.Drawing.Size(803, 176);
            this.xtraTabPageCatUser.Text = "المستخدمين";
            // 
            // gridControlCategoryUser
            // 
            this.gridControlCategoryUser.DataSource = this.categoryUserBindingSource;
            this.gridControlCategoryUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCategoryUser.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlCategoryUser.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlCategoryUser.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlCategoryUser.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlCategoryUser.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlCategoryUser.Location = new System.Drawing.Point(0, 0);
            this.gridControlCategoryUser.MainView = this.gridViewCategoryUser;
            this.gridControlCategoryUser.Name = "gridControlCategoryUser";
            this.gridControlCategoryUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEditCatUserGrantId});
            this.gridControlCategoryUser.Size = new System.Drawing.Size(803, 176);
            this.gridControlCategoryUser.TabIndex = 1;
            this.gridControlCategoryUser.UseEmbeddedNavigator = true;
            this.gridControlCategoryUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategoryUser});
            // 
            // categoryUserBindingSource
            // 
            this.categoryUserBindingSource.DataMember = "CategoryUser";
            this.categoryUserBindingSource.DataSource = this.dsDataCenter;
            // 
            // gridViewCategoryUser
            // 
            this.gridViewCategoryUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantId,
            this.gridColumn11,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19});
            this.gridViewCategoryUser.GridControl = this.gridControlCategoryUser;
            this.gridViewCategoryUser.Name = "gridViewCategoryUser";
            this.gridViewCategoryUser.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewCategoryUser.OptionsBehavior.Editable = false;
            this.gridViewCategoryUser.OptionsBehavior.ReadOnly = true;
            this.gridViewCategoryUser.OptionsView.ColumnAutoWidth = false;
            this.gridViewCategoryUser.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCategoryUser.OptionsView.ShowDetailButtons = false;
            this.gridViewCategoryUser.OptionsView.ShowGroupPanel = false;
            this.gridViewCategoryUser.OptionsView.ShowIndicator = false;
            // 
            // colGrantId
            // 
            this.colGrantId.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId.Caption = "نوع السماحية";
            this.colGrantId.ColumnEdit = this.repositoryItemGridLookUpEditCatUserGrantId;
            this.colGrantId.FieldName = "GrantId";
            this.colGrantId.Name = "colGrantId";
            this.colGrantId.Visible = true;
            this.colGrantId.VisibleIndex = 0;
            this.colGrantId.Width = 82;
            // 
            // repositoryItemGridLookUpEditCatUserGrantId
            // 
            this.repositoryItemGridLookUpEditCatUserGrantId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCatUserGrantId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCatUserGrantId.DataSource = this.lSMSGrant;
            this.repositoryItemGridLookUpEditCatUserGrantId.DisplayMember = "GrantName";
            this.repositoryItemGridLookUpEditCatUserGrantId.Name = "repositoryItemGridLookUpEditCatUserGrantId";
            this.repositoryItemGridLookUpEditCatUserGrantId.NullText = "";
            this.repositoryItemGridLookUpEditCatUserGrantId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCatUserGrantId.ValueMember = "GrantId";
            this.repositoryItemGridLookUpEditCatUserGrantId.View = this.repositoryItemGridLookUpEdit5View;
            // 
            // repositoryItemGridLookUpEdit5View
            // 
            this.repositoryItemGridLookUpEdit5View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantName});
            this.repositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit5View.Name = "repositoryItemGridLookUpEdit5View";
            this.repositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = false;
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
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "المستخدم";
            this.gridColumn11.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.gridColumn11.FieldName = "UserID";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 119;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.lSMSUser;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "RealName";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit1.ValueMember = "UserID";
            this.repositoryItemGridLookUpEdit1.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "اسم المستخدم";
            this.gridColumn12.FieldName = "RealName";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "قرائة";
            this.gridColumn13.FieldName = "CanRead";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 41;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.Caption = "تعديل";
            this.gridColumn14.FieldName = "CanWrite";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            this.gridColumn14.Width = 45;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.Caption = "اضافة";
            this.gridColumn15.FieldName = "CanInsert";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 45;
            // 
            // gridColumn16
            // 
            this.gridColumn16.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.Caption = "حذف";
            this.gridColumn16.FieldName = "CanDelete";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 5;
            this.gridColumn16.Width = 42;
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.Caption = "سماحية مشتركة";
            this.gridColumn17.FieldName = "Inheritance";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 6;
            this.gridColumn17.Width = 98;
            // 
            // gridColumn18
            // 
            this.gridColumn18.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn18.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn18.Caption = "مجلد السماحية المشتركة";
            this.gridColumn18.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn18.FieldName = "InheritanceCategoryId";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.OptionsColumn.ReadOnly = true;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 8;
            this.gridColumn18.Width = 138;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "اسم المجلد", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEdit1.DataSource = this.lSMSCategory;
            this.repositoryItemLookUpEdit1.DisplayMember = "CategoryName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "CategoryId";
            // 
            // lSMSCategory
            // 
            this.lSMSCategory.ElementType = typeof(DataCenter.DataSources.Linq.vCategory);
            this.lSMSCategory.KeyExpression = "CategoryId";
            // 
            // gridColumn19
            // 
            this.gridColumn19.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn19.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn19.Caption = "مستوي السماحية";
            this.gridColumn19.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.gridColumn19.FieldName = "UserLevelId";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 7;
            this.gridColumn19.Width = 104;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.userLevelBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "UserLevelName";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.NullText = "";
            this.repositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit2.ValueMember = "UserLevelId";
            this.repositoryItemGridLookUpEdit2.View = this.gridView6;
            // 
            // userLevelBindingSource
            // 
            this.userLevelBindingSource.DataMember = "UserLevel";
            this.userLevelBindingSource.DataSource = this.dsDataCenter;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn20});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "اسم المستوي";
            this.gridColumn20.FieldName = "UserLevelName";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 0;
            // 
            // xtraTabPageCatRole
            // 
            this.xtraTabPageCatRole.Controls.Add(this.gridControlCategoryRole);
            this.xtraTabPageCatRole.Image = global::DataCenter.Properties.Resources.RolePriv;
            this.xtraTabPageCatRole.Name = "xtraTabPageCatRole";
            this.xtraTabPageCatRole.Size = new System.Drawing.Size(803, 176);
            this.xtraTabPageCatRole.Text = "المجموعات";
            // 
            // gridControlCategoryRole
            // 
            this.gridControlCategoryRole.DataSource = this.categoryRoleBindingSource;
            this.gridControlCategoryRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCategoryRole.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlCategoryRole.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlCategoryRole.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlCategoryRole.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlCategoryRole.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlCategoryRole.Location = new System.Drawing.Point(0, 0);
            this.gridControlCategoryRole.MainView = this.gridViewCategoryRole;
            this.gridControlCategoryRole.Name = "gridControlCategoryRole";
            this.gridControlCategoryRole.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit4,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemGridLookUpEdit3,
            this.repositoryItemGridLookUpEditCatRoleGrantId});
            this.gridControlCategoryRole.Size = new System.Drawing.Size(803, 176);
            this.gridControlCategoryRole.TabIndex = 2;
            this.gridControlCategoryRole.UseEmbeddedNavigator = true;
            this.gridControlCategoryRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategoryRole});
            // 
            // categoryRoleBindingSource
            // 
            this.categoryRoleBindingSource.DataMember = "CategoryRole";
            this.categoryRoleBindingSource.DataSource = this.dsDataCenter;
            // 
            // gridViewCategoryRole
            // 
            this.gridViewCategoryRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantId1,
            this.gridColumn23,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn32});
            this.gridViewCategoryRole.GridControl = this.gridControlCategoryRole;
            this.gridViewCategoryRole.Name = "gridViewCategoryRole";
            this.gridViewCategoryRole.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewCategoryRole.OptionsBehavior.Editable = false;
            this.gridViewCategoryRole.OptionsBehavior.ReadOnly = true;
            this.gridViewCategoryRole.OptionsView.ColumnAutoWidth = false;
            this.gridViewCategoryRole.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCategoryRole.OptionsView.ShowDetailButtons = false;
            this.gridViewCategoryRole.OptionsView.ShowGroupPanel = false;
            this.gridViewCategoryRole.OptionsView.ShowIndicator = false;
            // 
            // colGrantId1
            // 
            this.colGrantId1.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantId1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantId1.Caption = "نوع السماحية";
            this.colGrantId1.ColumnEdit = this.repositoryItemGridLookUpEditCatRoleGrantId;
            this.colGrantId1.FieldName = "GrantId";
            this.colGrantId1.Name = "colGrantId1";
            this.colGrantId1.Visible = true;
            this.colGrantId1.VisibleIndex = 0;
            this.colGrantId1.Width = 82;
            // 
            // repositoryItemGridLookUpEditCatRoleGrantId
            // 
            this.repositoryItemGridLookUpEditCatRoleGrantId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCatRoleGrantId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCatRoleGrantId.DataSource = this.lSMSGrant;
            this.repositoryItemGridLookUpEditCatRoleGrantId.DisplayMember = "GrantName";
            this.repositoryItemGridLookUpEditCatRoleGrantId.Name = "repositoryItemGridLookUpEditCatRoleGrantId";
            this.repositoryItemGridLookUpEditCatRoleGrantId.NullText = "";
            this.repositoryItemGridLookUpEditCatRoleGrantId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCatRoleGrantId.ValueMember = "GrantId";
            this.repositoryItemGridLookUpEditCatRoleGrantId.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrantName1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colGrantName1
            // 
            this.colGrantName1.AppearanceCell.Options.UseTextOptions = true;
            this.colGrantName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrantName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrantName1.Caption = "اسم السماحية";
            this.colGrantName1.FieldName = "GrantName";
            this.colGrantName1.Name = "colGrantName1";
            this.colGrantName1.Visible = true;
            this.colGrantName1.VisibleIndex = 0;
            // 
            // gridColumn23
            // 
            this.gridColumn23.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn23.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn23.Caption = "مجموعة";
            this.gridColumn23.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.gridColumn23.FieldName = "RoleID";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 1;
            this.gridColumn23.Width = 119;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.lSMSRole;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "RoleName";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.NullText = "";
            this.repositoryItemGridLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit3.ValueMember = "RoleID";
            this.repositoryItemGridLookUpEdit3.View = this.gridView7;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn24,
            this.gridColumn25});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn24
            // 
            this.gridColumn24.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn24.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn24.Caption = "اسم المجموعة";
            this.gridColumn24.FieldName = "RoleName";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 0;
            // 
            // gridColumn25
            // 
            this.gridColumn25.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn25.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn25.Caption = "معلومات";
            this.gridColumn25.FieldName = "RoleDesc";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 1;
            // 
            // gridColumn26
            // 
            this.gridColumn26.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn26.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn26.Caption = "قرائة";
            this.gridColumn26.FieldName = "CanRead";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 2;
            this.gridColumn26.Width = 41;
            // 
            // gridColumn27
            // 
            this.gridColumn27.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn27.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn27.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn27.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn27.Caption = "تعديل";
            this.gridColumn27.FieldName = "CanWrite";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 3;
            this.gridColumn27.Width = 45;
            // 
            // gridColumn28
            // 
            this.gridColumn28.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn28.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn28.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn28.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn28.Caption = "اضافة";
            this.gridColumn28.FieldName = "CanInsert";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 4;
            this.gridColumn28.Width = 45;
            // 
            // gridColumn29
            // 
            this.gridColumn29.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn29.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn29.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn29.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn29.Caption = "حذف";
            this.gridColumn29.FieldName = "CanDelete";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 5;
            this.gridColumn29.Width = 42;
            // 
            // gridColumn30
            // 
            this.gridColumn30.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn30.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn30.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn30.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn30.Caption = "سماحية مشتركة";
            this.gridColumn30.FieldName = "Inheritance";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 6;
            this.gridColumn30.Width = 98;
            // 
            // gridColumn31
            // 
            this.gridColumn31.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn31.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn31.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn31.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn31.Caption = "مجلد السماحية المشتركة";
            this.gridColumn31.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.gridColumn31.FieldName = "InheritanceCategoryId";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.OptionsColumn.AllowEdit = false;
            this.gridColumn31.OptionsColumn.ReadOnly = true;
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 8;
            this.gridColumn31.Width = 138;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "اسم المجلد", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEdit2.DataSource = this.lSMSCategory;
            this.repositoryItemLookUpEdit2.DisplayMember = "CategoryName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit2.ValueMember = "CategoryId";
            // 
            // gridColumn32
            // 
            this.gridColumn32.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn32.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn32.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn32.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn32.Caption = "مستوي السماحية";
            this.gridColumn32.ColumnEdit = this.repositoryItemGridLookUpEdit4;
            this.gridColumn32.FieldName = "UserLevelId";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 7;
            this.gridColumn32.Width = 104;
            // 
            // repositoryItemGridLookUpEdit4
            // 
            this.repositoryItemGridLookUpEdit4.AutoHeight = false;
            this.repositoryItemGridLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit4.DataSource = this.userLevelBindingSource;
            this.repositoryItemGridLookUpEdit4.DisplayMember = "UserLevelName";
            this.repositoryItemGridLookUpEdit4.Name = "repositoryItemGridLookUpEdit4";
            this.repositoryItemGridLookUpEdit4.NullText = "";
            this.repositoryItemGridLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit4.ValueMember = "UserLevelId";
            this.repositoryItemGridLookUpEdit4.View = this.gridView8;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn33});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn33
            // 
            this.gridColumn33.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn33.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn33.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn33.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn33.Caption = "اسم المستوي";
            this.gridColumn33.FieldName = "UserLevelName";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 0;
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
            // xtraTabPageCategoryRole
            // 
            this.xtraTabPageCategoryRole.Image = global::DataCenter.Properties.Resources.RolePriv;
            this.xtraTabPageCategoryRole.Name = "xtraTabPageCategoryRole";
            this.xtraTabPageCategoryRole.Size = new System.Drawing.Size(294, 132);
            // 
            // itemUserTableAdapter
            // 
            this.itemUserTableAdapter.ClearBeforeFill = true;
            // 
            // itemRoleTableAdapter
            // 
            this.itemRoleTableAdapter.ClearBeforeFill = true;
            // 
            // FilePermissionEditorDLG
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
            this.Name = "FilePermissionEditorDLG";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "محرر الصلاحيات";
            this.Load += new System.EventHandler(this.FilePermissionEditorDLG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).EndInit();
            this.gcCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserGrantId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSGrant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditUserSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditUserDelete)).EndInit();
            this.xtraTabPageRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleGrantId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRoleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRoleSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRoleDelete)).EndInit();
            this.xtraTabPageCategoryInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPageCatUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategoryUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoryUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCatUserGrantId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSMSCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.xtraTabPageCatRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategoryRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoryRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCatRoleGrantId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colUserEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditUserSave;
        private DevExpress.XtraGrid.Columns.GridColumn colUserDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditUserDelete;
        private System.Windows.Forms.BindingSource userLevelBindingSource;
        private DataSources.dsDataCenterTableAdapters.UserLevelTableAdapter userLevelTableAdapter;
        private DevExpress.Data.Linq.LinqServerModeSource lSMSCategory;
        private DevExpress.XtraGrid.GridControl gridControlRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditUserUserID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCategoryInfo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCategoryRole;
        private DevExpress.XtraGrid.GridControl gridControlCategoryUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategoryUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.GridControl gridControlCategoryRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategoryRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCatUser;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCatRole;
        private DevExpress.Data.Linq.LinqServerModeSource lSMSGrant;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCatUserGrantId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit5View;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantId1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCatRoleGrantId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantName1;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantId2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditUserGrantId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantName3;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantId3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRoleGrantId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colGrantName2;
        private System.Windows.Forms.BindingSource itemUserBindingSource;
        private DataSources.dsDataCenterTableAdapters.ItemUserTableAdapter itemUserTableAdapter;
        private System.Windows.Forms.BindingSource itemRoleBindingSource;
        private DataSources.dsDataCenterTableAdapters.ItemRoleTableAdapter itemRoleTableAdapter;
    }
}