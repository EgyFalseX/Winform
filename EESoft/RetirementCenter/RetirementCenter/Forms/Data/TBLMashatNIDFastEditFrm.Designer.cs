namespace RetirementCenter.Forms.Data
{
    partial class TBLMashatNIDFastEditFrm
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
            this.tBLMashatFastEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSyndicateId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSCDSyndicate = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSubCommitteId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSCDSubCommitte = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubCommitte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMashHalaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditMashHalaId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSCDMashHala = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colyasref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdityasref = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMMashatNId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditMMashatNId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditTransferSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tBLMashatFastEditTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLMashatFastEditTableAdapter();
            this.tblNoSarfDetelsTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLNoSarfDetelsTableAdapter();
            this.tblMashatTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter();
            this.colMashHala = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMashatFastEditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSyndicateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubCommitteId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMashHalaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDMashHala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdityasref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditMMashatNId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLMashatFastEditBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditTransferSave,
            this.repositoryItemGridLookUpEditSyndicateId,
            this.repositoryItemGridLookUpEditSubCommitteId,
            this.repositoryItemCheckEdityasref,
            this.repositoryItemTextEditMMashatNId,
            this.repositoryItemGridLookUpEditMashHalaId});
            this.gridControlData.Size = new System.Drawing.Size(734, 361);
            this.gridControlData.TabIndex = 2;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tBLMashatFastEditBindingSource
            // 
            this.tBLMashatFastEditBindingSource.DataMember = "TBLMashatFastEdit";
            this.tBLMashatFastEditBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatName,
            this.colSyndicateId,
            this.colSubCommitteId,
            this.colsarfnumber,
            this.colMashHalaId,
            this.colyasref,
            this.colMMashatNId,
            this.gridColumn4});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "الاسم";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.OptionsColumn.ReadOnly = true;
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 0;
            this.colMMashatName.Width = 158;
            // 
            // colSyndicateId
            // 
            this.colSyndicateId.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.Caption = "الفرعية";
            this.colSyndicateId.ColumnEdit = this.repositoryItemGridLookUpEditSyndicateId;
            this.colSyndicateId.FieldName = "SyndicateId";
            this.colSyndicateId.Name = "colSyndicateId";
            this.colSyndicateId.OptionsColumn.ReadOnly = true;
            this.colSyndicateId.Visible = true;
            this.colSyndicateId.VisibleIndex = 2;
            this.colSyndicateId.Width = 103;
            // 
            // repositoryItemGridLookUpEditSyndicateId
            // 
            this.repositoryItemGridLookUpEditSyndicateId.AutoHeight = false;
            this.repositoryItemGridLookUpEditSyndicateId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSyndicateId.DataSource = this.LSMSCDSyndicate;
            this.repositoryItemGridLookUpEditSyndicateId.DisplayMember = "Syndicate";
            this.repositoryItemGridLookUpEditSyndicateId.Name = "repositoryItemGridLookUpEditSyndicateId";
            this.repositoryItemGridLookUpEditSyndicateId.NullText = "";
            this.repositoryItemGridLookUpEditSyndicateId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSyndicateId.ValueMember = "SyndicateId";
            this.repositoryItemGridLookUpEditSyndicateId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // LSMSCDSyndicate
            // 
            this.LSMSCDSyndicate.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSCDSyndicate.KeyExpression = "[SyndicateId]";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSyndicate1
            // 
            this.colSyndicate1.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.Caption = "الفرعية";
            this.colSyndicate1.FieldName = "Syndicate";
            this.colSyndicate1.Name = "colSyndicate1";
            this.colSyndicate1.Visible = true;
            this.colSyndicate1.VisibleIndex = 0;
            // 
            // colSubCommitteId
            // 
            this.colSubCommitteId.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.Caption = "اللجنة";
            this.colSubCommitteId.ColumnEdit = this.repositoryItemGridLookUpEditSubCommitteId;
            this.colSubCommitteId.FieldName = "SubCommitteId";
            this.colSubCommitteId.Name = "colSubCommitteId";
            this.colSubCommitteId.Visible = true;
            this.colSubCommitteId.VisibleIndex = 3;
            this.colSubCommitteId.Width = 100;
            // 
            // repositoryItemGridLookUpEditSubCommitteId
            // 
            this.repositoryItemGridLookUpEditSubCommitteId.AutoHeight = false;
            this.repositoryItemGridLookUpEditSubCommitteId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSubCommitteId.DataSource = this.LSMSCDSubCommitte;
            this.repositoryItemGridLookUpEditSubCommitteId.DisplayMember = "SubCommitte";
            this.repositoryItemGridLookUpEditSubCommitteId.Name = "repositoryItemGridLookUpEditSubCommitteId";
            this.repositoryItemGridLookUpEditSubCommitteId.NullText = "";
            this.repositoryItemGridLookUpEditSubCommitteId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSubCommitteId.ValueMember = "SubCommitteId";
            this.repositoryItemGridLookUpEditSubCommitteId.View = this.gridView1;
            this.repositoryItemGridLookUpEditSubCommitteId.Enter += new System.EventHandler(this.repositoryItemGridLookUpEditSubCommitteId_Enter);
            // 
            // LSMSCDSubCommitte
            // 
            this.LSMSCDSubCommitte.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSubCommitte);
            this.LSMSCDSubCommitte.KeyExpression = "[SubCommitteId]";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubCommitte1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSubCommitte1
            // 
            this.colSubCommitte1.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte1.Caption = "الجنة";
            this.colSubCommitte1.FieldName = "SubCommitte";
            this.colSubCommitte1.Name = "colSubCommitte1";
            this.colSubCommitte1.Visible = true;
            this.colSubCommitte1.VisibleIndex = 0;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم الصرف";
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.OptionsColumn.ReadOnly = true;
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 1;
            // 
            // colMashHalaId
            // 
            this.colMashHalaId.AppearanceCell.Options.UseTextOptions = true;
            this.colMashHalaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHalaId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMashHalaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHalaId.Caption = "النوع";
            this.colMashHalaId.ColumnEdit = this.repositoryItemGridLookUpEditMashHalaId;
            this.colMashHalaId.FieldName = "MashHalaId";
            this.colMashHalaId.Name = "colMashHalaId";
            this.colMashHalaId.OptionsColumn.AllowEdit = false;
            this.colMashHalaId.OptionsColumn.ReadOnly = true;
            this.colMashHalaId.Visible = true;
            this.colMashHalaId.VisibleIndex = 4;
            // 
            // repositoryItemGridLookUpEditMashHalaId
            // 
            this.repositoryItemGridLookUpEditMashHalaId.AutoHeight = false;
            this.repositoryItemGridLookUpEditMashHalaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditMashHalaId.DataSource = this.LSMSCDMashHala;
            this.repositoryItemGridLookUpEditMashHalaId.DisplayMember = "MashHala";
            this.repositoryItemGridLookUpEditMashHalaId.Name = "repositoryItemGridLookUpEditMashHalaId";
            this.repositoryItemGridLookUpEditMashHalaId.NullText = "";
            this.repositoryItemGridLookUpEditMashHalaId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditMashHalaId.ValueMember = "MashHalaId";
            this.repositoryItemGridLookUpEditMashHalaId.View = this.gridView2;
            // 
            // LSMSCDMashHala
            // 
            this.LSMSCDMashHala.ElementType = typeof(RetirementCenter.DataSources.Linq.CDMashHala);
            this.LSMSCDMashHala.KeyExpression = "[MashHalaId]";
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colyasref
            // 
            this.colyasref.AppearanceCell.Options.UseTextOptions = true;
            this.colyasref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.AppearanceHeader.Options.UseTextOptions = true;
            this.colyasref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.Caption = "يصرف";
            this.colyasref.ColumnEdit = this.repositoryItemCheckEdityasref;
            this.colyasref.FieldName = "yasref";
            this.colyasref.Name = "colyasref";
            this.colyasref.OptionsColumn.ReadOnly = true;
            this.colyasref.Visible = true;
            this.colyasref.VisibleIndex = 5;
            // 
            // repositoryItemCheckEdityasref
            // 
            this.repositoryItemCheckEdityasref.AutoHeight = false;
            this.repositoryItemCheckEdityasref.Name = "repositoryItemCheckEdityasref";
            this.repositoryItemCheckEdityasref.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdityasref_CheckedChanged);
            // 
            // colMMashatNId
            // 
            this.colMMashatNId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.Caption = "الرقم القومي";
            this.colMMashatNId.ColumnEdit = this.repositoryItemTextEditMMashatNId;
            this.colMMashatNId.FieldName = "MMashatNId";
            this.colMMashatNId.Name = "colMMashatNId";
            this.colMMashatNId.Visible = true;
            this.colMMashatNId.VisibleIndex = 6;
            this.colMMashatNId.Width = 82;
            // 
            // repositoryItemTextEditMMashatNId
            // 
            this.repositoryItemTextEditMMashatNId.AutoHeight = false;
            this.repositoryItemTextEditMMashatNId.MaxLength = 14;
            this.repositoryItemTextEditMMashatNId.Name = "repositoryItemTextEditMMashatNId";
            this.repositoryItemTextEditMMashatNId.Validating += new System.ComponentModel.CancelEventHandler(this.repositoryItemTextEditMMashatNId_Validating);
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "حفظ";
            this.gridColumn4.ColumnEdit = this.repositoryItemButtonEditTransferSave;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 59;
            // 
            // repositoryItemButtonEditTransferSave
            // 
            this.repositoryItemButtonEditTransferSave.AutoHeight = false;
            this.repositoryItemButtonEditTransferSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditTransferSave.Name = "repositoryItemButtonEditTransferSave";
            this.repositoryItemButtonEditTransferSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditTransferSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditTransferSave_ButtonClick);
            // 
            // tBLMashatFastEditTableAdapter
            // 
            this.tBLMashatFastEditTableAdapter.ClearBeforeFill = true;
            // 
            // tblNoSarfDetelsTableAdapter
            // 
            this.tblNoSarfDetelsTableAdapter.ClearBeforeFill = true;
            // 
            // tblMashatTableAdapter
            // 
            this.tblMashatTableAdapter.ClearBeforeFill = true;
            // 
            // colMashHala
            // 
            this.colMashHala.AppearanceCell.Options.UseTextOptions = true;
            this.colMashHala.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHala.AppearanceHeader.Options.UseTextOptions = true;
            this.colMashHala.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHala.Caption = "النوع";
            this.colMashHala.FieldName = "MashHala";
            this.colMashHala.Name = "colMashHala";
            this.colMashHala.Visible = true;
            this.colMashHala.VisibleIndex = 0;
            // 
            // TBLMashatNIDFastEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.gridControlData);
            this.Name = "TBLMashatNIDFastEditFrm";
            this.Text = "تعديل الرقم القومي و الصرف للاعضاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TBLMashatNIDFastEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMashatFastEditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSyndicateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubCommitteId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMashHalaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDMashHala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdityasref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditMMashatNId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSubCommitteId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditTransferSave;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteId;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colyasref;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdityasref;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatNId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSyndicate;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSubCommitte;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource tBLMashatFastEditBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.TBLMashatFastEditTableAdapter tBLMashatFastEditTableAdapter;
        private DataSources.dsRetirementCenterTableAdapters.TBLNoSarfDetelsTableAdapter tblNoSarfDetelsTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditMMashatNId;
        private DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter tblMashatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMashHalaId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditMashHalaId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDMashHala;
        private DevExpress.XtraGrid.Columns.GridColumn colMashHala;
    }
}