namespace RetirementCenter.Forms.Data
{
    partial class TBLMemberSarf_arshefDeleteFrm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueDofatSarfId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tBLDofatSarfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDofatSarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lueSyndicateId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tBLDofatSarfTableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter();
            this.cDSyndicateTableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter();
            this.tblMemberSarf_arshefTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lueDofatSarfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDofatSarfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(243, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الدفعة";
            // 
            // lueDofatSarfId
            // 
            this.lueDofatSarfId.Location = new System.Drawing.Point(12, 22);
            this.lueDofatSarfId.Name = "lueDofatSarfId";
            this.lueDofatSarfId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDofatSarfId.Properties.DataSource = this.tBLDofatSarfBindingSource;
            this.lueDofatSarfId.Properties.DisplayMember = "DofatSarf";
            this.lueDofatSarfId.Properties.NullText = "";
            this.lueDofatSarfId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDofatSarfId.Properties.ValueMember = "DofatSarfId";
            this.lueDofatSarfId.Properties.View = this.gridLookUpEdit1View;
            this.lueDofatSarfId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lueDofatSarfId.Size = new System.Drawing.Size(220, 20);
            this.lueDofatSarfId.TabIndex = 0;
            // 
            // tBLDofatSarfBindingSource
            // 
            this.tBLDofatSarfBindingSource.DataMember = "TBLDofatSarf";
            this.tBLDofatSarfBindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDofatSarf});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDofatSarf
            // 
            this.colDofatSarf.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.Caption = "اسم الدفعه";
            this.colDofatSarf.FieldName = "DofatSarf";
            this.colDofatSarf.Name = "colDofatSarf";
            this.colDofatSarf.Visible = true;
            this.colDofatSarf.VisibleIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف من الارشيف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(238, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "الفرعية";
            // 
            // lueSyndicateId
            // 
            this.lueSyndicateId.Location = new System.Drawing.Point(12, 48);
            this.lueSyndicateId.Name = "lueSyndicateId";
            this.lueSyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyndicateId.Properties.DataSource = this.cDSyndicateBindingSource;
            this.lueSyndicateId.Properties.DisplayMember = "Syndicate";
            this.lueSyndicateId.Properties.NullText = "";
            this.lueSyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyndicateId.Properties.ValueMember = "SyndicateId";
            this.lueSyndicateId.Properties.View = this.gridView1;
            this.lueSyndicateId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lueSyndicateId.Size = new System.Drawing.Size(220, 20);
            this.lueSyndicateId.TabIndex = 1;
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dsQueries;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "اسم الفرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 0;
            // 
            // tBLDofatSarfTableAdapter
            // 
            this.tBLDofatSarfTableAdapter.ClearBeforeFill = true;
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // tblMemberSarf_arshefTableAdapter
            // 
            this.tblMemberSarf_arshefTableAdapter.ClearBeforeFill = true;
            // 
            // TBLMemberSarf_arshefDeleteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 132);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lueSyndicateId);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lueDofatSarfId);
            this.Controls.Add(this.labelControl1);
            this.Name = "TBLMemberSarf_arshefDeleteFrm";
            this.Text = "ارشيف الاعضاء";
            this.Load += new System.EventHandler(this.TBLMemberSarf_arshefDeleteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueDofatSarfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDofatSarfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit lueDofatSarfId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit lueSyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource tBLDofatSarfBindingSource;
        private DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter tBLDofatSarfTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarf;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter tblMemberSarf_arshefTableAdapter;
    }
}