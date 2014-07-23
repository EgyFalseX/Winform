namespace Members.Forms.Data
{
    partial class TBLUserMistakeFrm
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.tBLUserMistakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLUserMistakeTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLUserMistakeTableAdapter();
            this.coluserid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmistakenots = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditUsers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditWorkTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemMemoEditMem = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemDateEditDateTime = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.UsersTableAdapter();
            this.cDWorkTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDWorkTypeTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDWorkTypeTableAdapter();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUserMistakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditWorkTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateTime.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDWorkTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.gridControlData);
            this.groupControl3.Location = new System.Drawing.Point(0, -2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(692, 307);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "التفاصيل";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLUserMistakeBindingSource;
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
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDelete,
            this.repositoryItemGridLookUpEditUsers,
            this.repositoryItemGridLookUpEditWorkTypeId,
            this.repositoryItemMemoEditMem,
            this.repositoryItemDateEditDateTime});
            this.gridControlData.Size = new System.Drawing.Size(688, 284);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluserid,
            this.colWorkTypeId,
            this.colmistakenots,
            this.gridColumn1,
            this.gridColumn3,
            this.coluserin,
            this.coldatein});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضعظ لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "تعديل";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 48;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSave_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "الحذف";
            this.gridColumn3.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 44;
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
            // groupControl2
            // 
            this.groupControl2.AllowTouchScroll = true;
            this.groupControl2.Controls.Add(this.btnNew);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 311);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(692, 62);
            this.groupControl2.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.Image = global::Members.Properties.Resources.Add;
            this.btnNew.Location = new System.Drawing.Point(487, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLUserMistakeBindingSource
            // 
            this.tBLUserMistakeBindingSource.DataMember = "TBLUserMistake";
            this.tBLUserMistakeBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // tBLUserMistakeTableAdapter
            // 
            this.tBLUserMistakeTableAdapter.ClearBeforeFill = true;
            // 
            // coluserid
            // 
            this.coluserid.AppearanceCell.Options.UseTextOptions = true;
            this.coluserid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserid.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserid.Caption = "اسم الموظف";
            this.coluserid.ColumnEdit = this.repositoryItemGridLookUpEditUsers;
            this.coluserid.FieldName = "userid";
            this.coluserid.Name = "coluserid";
            this.coluserid.Visible = true;
            this.coluserid.VisibleIndex = 0;
            this.coluserid.Width = 104;
            // 
            // colWorkTypeId
            // 
            this.colWorkTypeId.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkTypeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkTypeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colWorkTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkTypeId.Caption = "نوع العمل";
            this.colWorkTypeId.ColumnEdit = this.repositoryItemGridLookUpEditWorkTypeId;
            this.colWorkTypeId.FieldName = "WorkTypeId";
            this.colWorkTypeId.Name = "colWorkTypeId";
            this.colWorkTypeId.Visible = true;
            this.colWorkTypeId.VisibleIndex = 1;
            this.colWorkTypeId.Width = 92;
            // 
            // colmistakenots
            // 
            this.colmistakenots.AppearanceCell.Options.UseTextOptions = true;
            this.colmistakenots.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmistakenots.AppearanceHeader.Options.UseTextOptions = true;
            this.colmistakenots.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmistakenots.Caption = "ملاحظات";
            this.colmistakenots.ColumnEdit = this.repositoryItemMemoEditMem;
            this.colmistakenots.FieldName = "mistakenots";
            this.colmistakenots.Name = "colmistakenots";
            this.colmistakenots.Visible = true;
            this.colmistakenots.VisibleIndex = 2;
            this.colmistakenots.Width = 377;
            // 
            // coluserin
            // 
            this.coluserin.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.Caption = "مسئول الادخال";
            this.coluserin.FieldName = "userin";
            this.coluserin.Name = "coluserin";
            this.coluserin.OptionsColumn.AllowEdit = false;
            this.coluserin.OptionsColumn.ReadOnly = true;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.OptionsColumn.AllowEdit = false;
            this.coldatein.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemGridLookUpEditUsers
            // 
            this.repositoryItemGridLookUpEditUsers.AutoHeight = false;
            this.repositoryItemGridLookUpEditUsers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditUsers.DataSource = this.usersBindingSource;
            this.repositoryItemGridLookUpEditUsers.DisplayMember = "RealName";
            this.repositoryItemGridLookUpEditUsers.Name = "repositoryItemGridLookUpEditUsers";
            this.repositoryItemGridLookUpEditUsers.NullText = "";
            this.repositoryItemGridLookUpEditUsers.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditUsers.ValueMember = "UserID";
            this.repositoryItemGridLookUpEditUsers.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEditWorkTypeId
            // 
            this.repositoryItemGridLookUpEditWorkTypeId.AutoHeight = false;
            this.repositoryItemGridLookUpEditWorkTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditWorkTypeId.DataSource = this.cDWorkTypeBindingSource;
            this.repositoryItemGridLookUpEditWorkTypeId.DisplayMember = "WorkType";
            this.repositoryItemGridLookUpEditWorkTypeId.Name = "repositoryItemGridLookUpEditWorkTypeId";
            this.repositoryItemGridLookUpEditWorkTypeId.NullText = "";
            this.repositoryItemGridLookUpEditWorkTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditWorkTypeId.ValueMember = "WorkTypeId";
            this.repositoryItemGridLookUpEditWorkTypeId.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemMemoEditMem
            // 
            this.repositoryItemMemoEditMem.Name = "repositoryItemMemoEditMem";
            // 
            // repositoryItemDateEditDateTime
            // 
            this.repositoryItemDateEditDateTime.AutoHeight = false;
            this.repositoryItemDateEditDateTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDateTime.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEditDateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDateTime.EditFormat.FormatString = "g";
            this.repositoryItemDateEditDateTime.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDateTime.Mask.EditMask = "g";
            this.repositoryItemDateEditDateTime.Name = "repositoryItemDateEditDateTime";
            this.repositoryItemDateEditDateTime.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // cDWorkTypeBindingSource
            // 
            this.cDWorkTypeBindingSource.DataMember = "CDWorkType";
            this.cDWorkTypeBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // cDWorkTypeTableAdapter
            // 
            this.cDWorkTypeTableAdapter.ClearBeforeFill = true;
            // 
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "الاسم";
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 0;
            // 
            // colWorkType
            // 
            this.colWorkType.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkType.AppearanceHeader.Options.UseTextOptions = true;
            this.colWorkType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkType.Caption = "النوع";
            this.colWorkType.FieldName = "WorkType";
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.Visible = true;
            this.colWorkType.VisibleIndex = 0;
            // 
            // TBLUserMistakeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Name = "TBLUserMistakeFrm";
            this.Text = "اخطاء العاملين";
            this.Load += new System.EventHandler(this.TBLHafzawebFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUserMistakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditWorkTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateTime.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDWorkTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLUserMistakeBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLUserMistakeTableAdapter tBLUserMistakeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coluserid;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditWorkTypeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmistakenots;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEditMem;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDateTime;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource cDWorkTypeBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDWorkTypeTableAdapter cDWorkTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkType;
    }
}