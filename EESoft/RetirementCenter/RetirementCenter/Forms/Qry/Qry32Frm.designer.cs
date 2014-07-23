namespace RetirementCenter
{
    partial class Qry32Frm
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
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition2 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            this.calcWarasaType = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControlMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.vQry32BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.fieldCountPersonId = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldresponsiblesarf = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldyasref1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSyndicate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSubCommitte1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWarasaType = new DevExpress.XtraPivotGrid.PivotGridField();
            this.vQry32TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry32TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry32BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // calcWarasaType
            // 
            this.calcWarasaType.Appearance.Cell.Options.UseTextOptions = true;
            this.calcWarasaType.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcWarasaType.Appearance.Header.Options.UseTextOptions = true;
            this.calcWarasaType.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcWarasaType.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.calcWarasaType.AreaIndex = 1;
            this.calcWarasaType.Caption = "نسبة";
            this.calcWarasaType.CellFormat.FormatString = "p2";
            this.calcWarasaType.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcWarasaType.FieldName = "CountPersonId";
            this.calcWarasaType.GrandTotalCellFormat.FormatString = "p2";
            this.calcWarasaType.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcWarasaType.Name = "calcWarasaType";
            this.calcWarasaType.Options.ShowGrandTotal = false;
            this.calcWarasaType.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfRowGrandTotal;
            this.calcWarasaType.TotalCellFormat.FormatString = "p2";
            this.calcWarasaType.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcWarasaType.TotalValueFormat.FormatString = "p2";
            this.calcWarasaType.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcWarasaType.ValueFormat.FormatString = "p2";
            this.calcWarasaType.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(734, 47);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(588, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // pivotGridControlMain
            // 
            this.pivotGridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControlMain.DataSource = this.vQry32BindingSource;
            this.pivotGridControlMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountPersonId,
            this.fieldresponsiblesarf,
            this.fieldyasref1,
            this.fieldSyndicate1,
            this.fieldSubCommitte1,
            this.fieldWarasaType,
            this.calcWarasaType});
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Green;
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            pivotGridStyleFormatCondition1.Field = this.calcWarasaType;
            pivotGridStyleFormatCondition1.FieldName = "calcWarasaType";
            pivotGridStyleFormatCondition1.Value1 = ".5";
            pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            pivotGridStyleFormatCondition2.Field = this.calcWarasaType;
            pivotGridStyleFormatCondition2.FieldName = "calcWarasaType";
            pivotGridStyleFormatCondition2.Value1 = ".5";
            this.pivotGridControlMain.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1,
            pivotGridStyleFormatCondition2});
            this.pivotGridControlMain.Location = new System.Drawing.Point(0, 53);
            this.pivotGridControlMain.Name = "pivotGridControlMain";
            this.pivotGridControlMain.Size = new System.Drawing.Size(734, 408);
            this.pivotGridControlMain.TabIndex = 4;
            // 
            // vQry32BindingSource
            // 
            this.vQry32BindingSource.DataMember = "vQry32";
            this.vQry32BindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCountPersonId
            // 
            this.fieldCountPersonId.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldCountPersonId.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCountPersonId.Appearance.Header.Options.UseTextOptions = true;
            this.fieldCountPersonId.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCountPersonId.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCountPersonId.AreaIndex = 0;
            this.fieldCountPersonId.Caption = "العدد";
            this.fieldCountPersonId.FieldName = "CountPersonId";
            this.fieldCountPersonId.Name = "fieldCountPersonId";
            // 
            // fieldresponsiblesarf
            // 
            this.fieldresponsiblesarf.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldresponsiblesarf.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldresponsiblesarf.Appearance.Header.Options.UseTextOptions = true;
            this.fieldresponsiblesarf.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldresponsiblesarf.AreaIndex = 2;
            this.fieldresponsiblesarf.Caption = "مسئول صرف";
            this.fieldresponsiblesarf.FieldName = "responsiblesarf";
            this.fieldresponsiblesarf.Name = "fieldresponsiblesarf";
            // 
            // fieldyasref1
            // 
            this.fieldyasref1.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldyasref1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldyasref1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldyasref1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldyasref1.AreaIndex = 0;
            this.fieldyasref1.Caption = "يصرف";
            this.fieldyasref1.FieldName = "yasref";
            this.fieldyasref1.Name = "fieldyasref1";
            // 
            // fieldSyndicate1
            // 
            this.fieldSyndicate1.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldSyndicate1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSyndicate1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldSyndicate1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSyndicate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSyndicate1.AreaIndex = 0;
            this.fieldSyndicate1.Caption = "فرعية";
            this.fieldSyndicate1.FieldName = "Syndicate";
            this.fieldSyndicate1.Name = "fieldSyndicate1";
            this.fieldSyndicate1.Width = 124;
            // 
            // fieldSubCommitte1
            // 
            this.fieldSubCommitte1.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldSubCommitte1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSubCommitte1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldSubCommitte1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSubCommitte1.AreaIndex = 1;
            this.fieldSubCommitte1.Caption = "لجنة";
            this.fieldSubCommitte1.FieldName = "SubCommitte";
            this.fieldSubCommitte1.Name = "fieldSubCommitte1";
            // 
            // fieldWarasaType
            // 
            this.fieldWarasaType.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldWarasaType.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldWarasaType.Appearance.Header.Options.UseTextOptions = true;
            this.fieldWarasaType.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldWarasaType.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldWarasaType.AreaIndex = 0;
            this.fieldWarasaType.Caption = "نوع الوريث";
            this.fieldWarasaType.FieldName = "WarasaType";
            this.fieldWarasaType.Name = "fieldWarasaType";
            // 
            // vQry32TableAdapter
            // 
            this.vQry32TableAdapter.ClearBeforeFill = true;
            // 
            // Qry32Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.pivotGridControlMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "Qry32Frm";
            this.Text = "احصائيات الورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Shown += new System.EventHandler(this.Frm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry32BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlMain;
        private DevExpress.XtraPivotGrid.PivotGridField fieldyasref1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSyndicate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSubCommitte1;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource vQry32BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry32TableAdapter vQry32TableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountPersonId;
        private DevExpress.XtraPivotGrid.PivotGridField fieldresponsiblesarf;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWarasaType;
        private DevExpress.XtraPivotGrid.PivotGridField calcWarasaType;

    }
}