namespace Fellowship.Data
{
    partial class DeleteTblAllDataFrm
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
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lue = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cDEDARETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFellowship = new Fellowship.DataSources.DSFellowship();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEDARET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDEDARETTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.CDEDARETTableAdapter();
            this.tblAllDataTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.TblAllDataTableAdapter();
            this.colModereaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditModereaId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cDGovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDGovTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.CDGovTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDARETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditModereaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDGovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(459, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختر ادارة";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(122, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lue
            // 
            this.lue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lue.Location = new System.Drawing.Point(203, 14);
            this.lue.Name = "lue";
            this.lue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue.Properties.DataSource = this.cDEDARETBindingSource;
            this.lue.Properties.DisplayMember = "EDARET";
            this.lue.Properties.NullText = "";
            this.lue.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditModereaId});
            this.lue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lue.Properties.ValueMember = "EdaraId";
            this.lue.Properties.View = this.gridLookUpEdit1View;
            this.lue.Size = new System.Drawing.Size(250, 20);
            this.lue.TabIndex = 0;
            // 
            // cDEDARETBindingSource
            // 
            this.cDEDARETBindingSource.DataMember = "CDEDARET";
            this.cDEDARETBindingSource.DataSource = this.dSFellowship;
            // 
            // dSFellowship
            // 
            this.dSFellowship.DataSetName = "DSFellowship";
            this.dSFellowship.Locale = new System.Globalization.CultureInfo("en-US");
            this.dSFellowship.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEDARET,
            this.colModereaId});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colEDARET
            // 
            this.colEDARET.FieldName = "EDARET";
            this.colEDARET.Name = "colEDARET";
            this.colEDARET.Visible = true;
            this.colEDARET.VisibleIndex = 0;
            // 
            // cDEDARETTableAdapter
            // 
            this.cDEDARETTableAdapter.ClearBeforeFill = true;
            // 
            // tblAllDataTableAdapter
            // 
            this.tblAllDataTableAdapter.ClearBeforeFill = true;
            // 
            // colModereaId
            // 
            this.colModereaId.AppearanceCell.Options.UseTextOptions = true;
            this.colModereaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModereaId.AppearanceHeader.Options.UseTextOptions = true;
            this.colModereaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModereaId.Caption = "مديرية";
            this.colModereaId.ColumnEdit = this.repositoryItemLookUpEditModereaId;
            this.colModereaId.FieldName = "ModereaId";
            this.colModereaId.Name = "colModereaId";
            this.colModereaId.Visible = true;
            this.colModereaId.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEditModereaId
            // 
            this.repositoryItemLookUpEditModereaId.AutoHeight = false;
            this.repositoryItemLookUpEditModereaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditModereaId.DataSource = this.cDGovBindingSource;
            this.repositoryItemLookUpEditModereaId.DisplayMember = "GOV";
            this.repositoryItemLookUpEditModereaId.Name = "repositoryItemLookUpEditModereaId";
            this.repositoryItemLookUpEditModereaId.NullText = "";
            this.repositoryItemLookUpEditModereaId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditModereaId.ValueMember = "GovId";
            // 
            // cDGovBindingSource
            // 
            this.cDGovBindingSource.DataMember = "CDGov";
            this.cDGovBindingSource.DataSource = this.dSFellowship;
            // 
            // cDGovTableAdapter
            // 
            this.cDGovTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteTblAllDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 52);
            this.Controls.Add(this.lue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelControl1);
            this.Name = "DeleteTblAllDataFrm";
            this.Text = "حذف بالادارة";
            this.Load += new System.EventHandler(this.DeleteTblAllDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDARETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditModereaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDGovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.GridLookUpEdit lue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DataSources.DSFellowship dSFellowship;
        private System.Windows.Forms.BindingSource cDEDARETBindingSource;
        private DataSources.DSFellowshipTableAdapters.CDEDARETTableAdapter cDEDARETTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET;
        private DataSources.DSFellowshipTableAdapters.TblAllDataTableAdapter tblAllDataTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditModereaId;
        private DevExpress.XtraGrid.Columns.GridColumn colModereaId;
        private System.Windows.Forms.BindingSource cDGovBindingSource;
        private DataSources.DSFellowshipTableAdapters.CDGovTableAdapter cDGovTableAdapter;
    }
}