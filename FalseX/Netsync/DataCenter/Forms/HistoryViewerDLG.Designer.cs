namespace DataCenter.Forms
{
    partial class HistoryViewerDLG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryViewerDLG));
            this.gridControlHistory = new DevExpress.XtraGrid.GridControl();
            this.gridViewHistoryCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditLogTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colOperationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditLogOpId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLogDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUserId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLogNameExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditRole = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dsQueries = new DataCenter.DataSources.dsQueries();
            this.qryLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryLogsTableAdapter = new DataCenter.DataSources.dsQueriesTableAdapters.QryLogsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistoryCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLogTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLogOpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryLogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlHistory
            // 
            this.gridControlHistory.DataSource = this.qryLogsBindingSource;
            this.gridControlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHistory.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlHistory.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlHistory.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlHistory.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlHistory.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlHistory.Location = new System.Drawing.Point(0, 0);
            this.gridControlHistory.MainView = this.gridViewHistoryCategory;
            this.gridControlHistory.Name = "gridControlHistory";
            this.gridControlHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditLogOpId,
            this.repositoryItemDateEditDate,
            this.repositoryItemLookUpEditUserId,
            this.repositoryItemLookUpEditRole,
            this.repositoryItemLookUpEditLogTypeId});
            this.gridControlHistory.Size = new System.Drawing.Size(784, 361);
            this.gridControlHistory.TabIndex = 0;
            this.gridControlHistory.UseEmbeddedNavigator = true;
            this.gridControlHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHistoryCategory});
            // 
            // gridViewHistoryCategory
            // 
            this.gridViewHistoryCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogTypeName,
            this.colOperationName,
            this.colLogDate,
            this.colRealName,
            this.colLogNameExtra});
            this.gridViewHistoryCategory.GridControl = this.gridControlHistory;
            this.gridViewHistoryCategory.Name = "gridViewHistoryCategory";
            this.gridViewHistoryCategory.OptionsBehavior.Editable = false;
            this.gridViewHistoryCategory.OptionsView.ColumnAutoWidth = false;
            this.gridViewHistoryCategory.OptionsView.ShowAutoFilterRow = true;
            this.gridViewHistoryCategory.OptionsView.ShowDetailButtons = false;
            this.gridViewHistoryCategory.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridViewHistoryCategory_CustomRowCellEdit);
            // 
            // colLogTypeName
            // 
            this.colLogTypeName.AppearanceCell.Options.UseTextOptions = true;
            this.colLogTypeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogTypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colLogTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogTypeName.Caption = "نوع العنصر";
            this.colLogTypeName.FieldName = "LogTypeName";
            this.colLogTypeName.Name = "colLogTypeName";
            this.colLogTypeName.Visible = true;
            this.colLogTypeName.VisibleIndex = 0;
            this.colLogTypeName.Width = 167;
            // 
            // repositoryItemLookUpEditLogTypeId
            // 
            this.repositoryItemLookUpEditLogTypeId.AutoHeight = false;
            this.repositoryItemLookUpEditLogTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditLogTypeId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LogTypeName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditLogTypeId.DisplayMember = "LogTypeName";
            this.repositoryItemLookUpEditLogTypeId.Name = "repositoryItemLookUpEditLogTypeId";
            this.repositoryItemLookUpEditLogTypeId.NullText = "";
            this.repositoryItemLookUpEditLogTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditLogTypeId.ValueMember = "LogTypeId";
            // 
            // colOperationName
            // 
            this.colOperationName.AppearanceCell.Options.UseTextOptions = true;
            this.colOperationName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOperationName.AppearanceHeader.Options.UseTextOptions = true;
            this.colOperationName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOperationName.Caption = "نوع العملية";
            this.colOperationName.FieldName = "OperationName";
            this.colOperationName.Name = "colOperationName";
            this.colOperationName.Visible = true;
            this.colOperationName.VisibleIndex = 1;
            this.colOperationName.Width = 159;
            // 
            // repositoryItemLookUpEditLogOpId
            // 
            this.repositoryItemLookUpEditLogOpId.AutoHeight = false;
            this.repositoryItemLookUpEditLogOpId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditLogOpId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OperationName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditLogOpId.DisplayMember = "OperationName";
            this.repositoryItemLookUpEditLogOpId.Name = "repositoryItemLookUpEditLogOpId";
            this.repositoryItemLookUpEditLogOpId.NullText = "";
            this.repositoryItemLookUpEditLogOpId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditLogOpId.ValueMember = "LogOpId";
            // 
            // colLogDate
            // 
            this.colLogDate.AppearanceCell.Options.UseTextOptions = true;
            this.colLogDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colLogDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogDate.Caption = "تاريخ العملية";
            this.colLogDate.ColumnEdit = this.repositoryItemDateEditDate;
            this.colLogDate.FieldName = "LogDate";
            this.colLogDate.Name = "colLogDate";
            this.colLogDate.Visible = true;
            this.colLogDate.VisibleIndex = 2;
            this.colLogDate.Width = 128;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "d/M/yyyy - HH:MM:ss";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.EditFormat.FormatString = "d/M/yyyy - HH:MM:ss";
            this.repositoryItemDateEditDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "d/M/yyyy - HH:MM:ss";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "المستخدم";
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 3;
            this.colRealName.Width = 153;
            // 
            // repositoryItemLookUpEditUserId
            // 
            this.repositoryItemLookUpEditUserId.AutoHeight = false;
            this.repositoryItemLookUpEditUserId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditUserId.DisplayMember = "RealName";
            this.repositoryItemLookUpEditUserId.Name = "repositoryItemLookUpEditUserId";
            this.repositoryItemLookUpEditUserId.NullText = "";
            this.repositoryItemLookUpEditUserId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditUserId.ValueMember = "UserID";
            // 
            // colLogNameExtra
            // 
            this.colLogNameExtra.AppearanceCell.Options.UseTextOptions = true;
            this.colLogNameExtra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogNameExtra.AppearanceHeader.Options.UseTextOptions = true;
            this.colLogNameExtra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogNameExtra.Caption = "عنصر";
            this.colLogNameExtra.FieldName = "LogNameExtra";
            this.colLogNameExtra.Name = "colLogNameExtra";
            this.colLogNameExtra.Visible = true;
            this.colLogNameExtra.VisibleIndex = 4;
            this.colLogNameExtra.Width = 112;
            // 
            // repositoryItemLookUpEditRole
            // 
            this.repositoryItemLookUpEditRole.AutoHeight = false;
            this.repositoryItemLookUpEditRole.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditRole.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "الاسم", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditRole.DisplayMember = "RoleName";
            this.repositoryItemLookUpEditRole.Name = "repositoryItemLookUpEditRole";
            this.repositoryItemLookUpEditRole.NullText = "";
            this.repositoryItemLookUpEditRole.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditRole.ValueMember = "RoleID";
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qryLogsBindingSource
            // 
            this.qryLogsBindingSource.DataMember = "QryLogs";
            this.qryLogsBindingSource.DataSource = this.dsQueries;
            // 
            // qryLogsTableAdapter
            // 
            this.qryLogsTableAdapter.ClearBeforeFill = true;
            // 
            // HistoryViewerDLG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.gridControlHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryViewerDLG";
            this.Text = "العمليات";
            this.Load += new System.EventHandler(this.HistoryViewerDLG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistoryCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLogTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLogOpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryLogsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHistoryCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colLogTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colOperationName;
        private DevExpress.XtraGrid.Columns.GridColumn colLogDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditLogOpId;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colLogNameExtra;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditRole;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditLogTypeId;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource qryLogsBindingSource;
        private DataSources.dsQueriesTableAdapters.QryLogsTableAdapter qryLogsTableAdapter;
    }
}