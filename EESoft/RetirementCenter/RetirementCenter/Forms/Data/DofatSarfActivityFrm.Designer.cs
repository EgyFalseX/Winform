namespace RetirementCenter.Forms.Data
{
    partial class DofatSarfActivityFrm
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
            this.dofatSarfActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSyndicateId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSCDSyndicate = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDofatSarfId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditDofatSarfId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSTBLDofatSarf = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDofatSarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMashHalaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditMashHalaId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSCDMashHala = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditTransferSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dofatSarfActivityTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.DofatSarfActivityTableAdapter();
            this.colMashHala = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dofatSarfActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSyndicateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDofatSarfId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLDofatSarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMashHalaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDMashHala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.dofatSarfActivityBindingSource;
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
            this.repositoryItemGridLookUpEditDofatSarfId,
            this.repositoryItemCheckEdit1,
            this.repositoryItemGridLookUpEditMashHalaId});
            this.gridControlData.Size = new System.Drawing.Size(734, 361);
            this.gridControlData.TabIndex = 2;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // dofatSarfActivityBindingSource
            // 
            this.dofatSarfActivityBindingSource.DataMember = "DofatSarfActivity";
            this.dofatSarfActivityBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicateId,
            this.colDofatSarfId,
            this.colMashHalaId,
            this.colClosed,
            this.gridColumn4});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            // 
            // colSyndicateId
            // 
            this.colSyndicateId.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.Caption = "فرعية العضو";
            this.colSyndicateId.ColumnEdit = this.repositoryItemGridLookUpEditSyndicateId;
            this.colSyndicateId.FieldName = "SyndicateId";
            this.colSyndicateId.Name = "colSyndicateId";
            this.colSyndicateId.Visible = true;
            this.colSyndicateId.VisibleIndex = 0;
            this.colSyndicateId.Width = 132;
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
            // colDofatSarfId
            // 
            this.colDofatSarfId.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarfId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfId.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarfId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfId.Caption = "الدفعة";
            this.colDofatSarfId.ColumnEdit = this.repositoryItemGridLookUpEditDofatSarfId;
            this.colDofatSarfId.FieldName = "DofatSarfId";
            this.colDofatSarfId.Name = "colDofatSarfId";
            this.colDofatSarfId.Visible = true;
            this.colDofatSarfId.VisibleIndex = 1;
            this.colDofatSarfId.Width = 167;
            // 
            // repositoryItemGridLookUpEditDofatSarfId
            // 
            this.repositoryItemGridLookUpEditDofatSarfId.AutoHeight = false;
            this.repositoryItemGridLookUpEditDofatSarfId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditDofatSarfId.DataSource = this.LSMSTBLDofatSarf;
            this.repositoryItemGridLookUpEditDofatSarfId.DisplayMember = "DofatSarf";
            this.repositoryItemGridLookUpEditDofatSarfId.Name = "repositoryItemGridLookUpEditDofatSarfId";
            this.repositoryItemGridLookUpEditDofatSarfId.NullText = "";
            this.repositoryItemGridLookUpEditDofatSarfId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditDofatSarfId.ValueMember = "DofatSarfId";
            this.repositoryItemGridLookUpEditDofatSarfId.View = this.gridView1;
            // 
            // LSMSTBLDofatSarf
            // 
            this.LSMSTBLDofatSarf.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLDofatSarf);
            this.LSMSTBLDofatSarf.KeyExpression = "[DofatSarfId]";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDofatSarf});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDofatSarf
            // 
            this.colDofatSarf.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.Caption = "اسم الدفعة";
            this.colDofatSarf.FieldName = "DofatSarf";
            this.colDofatSarf.Name = "colDofatSarf";
            this.colDofatSarf.Visible = true;
            this.colDofatSarf.VisibleIndex = 0;
            // 
            // colMashHalaId
            // 
            this.colMashHalaId.AppearanceCell.Options.UseTextOptions = true;
            this.colMashHalaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHalaId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMashHalaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHalaId.Caption = "الحالة";
            this.colMashHalaId.ColumnEdit = this.repositoryItemGridLookUpEditMashHalaId;
            this.colMashHalaId.FieldName = "MashHalaId";
            this.colMashHalaId.Name = "colMashHalaId";
            this.colMashHalaId.Visible = true;
            this.colMashHalaId.VisibleIndex = 2;
            this.colMashHalaId.Width = 117;
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
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMashHala});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colClosed
            // 
            this.colClosed.AppearanceCell.Options.UseTextOptions = true;
            this.colClosed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClosed.AppearanceHeader.Options.UseTextOptions = true;
            this.colClosed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClosed.Caption = "اغلاق";
            this.colClosed.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colClosed.FieldName = "Closed";
            this.colClosed.Name = "colClosed";
            this.colClosed.Visible = true;
            this.colClosed.VisibleIndex = 3;
            this.colClosed.Width = 123;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 70;
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
            // dofatSarfActivityTableAdapter
            // 
            this.dofatSarfActivityTableAdapter.ClearBeforeFill = true;
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
            // DofatSarfActivityFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.gridControlData);
            this.Name = "DofatSarfActivityFrm";
            this.Text = "تعديل الرقم القومي و الصرف للاعضاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DofatSarfActivityFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dofatSarfActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSyndicateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDofatSarfId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLDofatSarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMashHalaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDMashHala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditDofatSarfId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditTransferSave;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSyndicate;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource dofatSarfActivityBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.DofatSarfActivityTableAdapter dofatSarfActivityTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarfId;
        private DevExpress.XtraGrid.Columns.GridColumn colClosed;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLDofatSarf;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarf;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDMashHala;
        private DevExpress.XtraGrid.Columns.GridColumn colMashHalaId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditMashHalaId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMashHala;
    }
}