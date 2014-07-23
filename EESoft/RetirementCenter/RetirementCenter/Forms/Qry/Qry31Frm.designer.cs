namespace RetirementCenter
{
    partial class Qry31Frm
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
            this.calcMashHalaPer = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControlMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.vQry31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.fieldCountMMashatId = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldyasref1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSarfExpetion1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldmcompletesarf1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSyndicate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSubCommitte1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMashHala = new DevExpress.XtraPivotGrid.PivotGridField();
            this.vQry31TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry31TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // calcMashHalaPer
            // 
            this.calcMashHalaPer.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.calcMashHalaPer.AreaIndex = 1;
            this.calcMashHalaPer.Caption = "نسبة";
            this.calcMashHalaPer.CellFormat.FormatString = "p2";
            this.calcMashHalaPer.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcMashHalaPer.FieldName = "CountMMashatId";
            this.calcMashHalaPer.GrandTotalCellFormat.FormatString = "p2";
            this.calcMashHalaPer.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcMashHalaPer.Name = "calcMashHalaPer";
            this.calcMashHalaPer.Options.ShowGrandTotal = false;
            this.calcMashHalaPer.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfRowGrandTotal;
            this.calcMashHalaPer.TotalCellFormat.FormatString = "p2";
            this.calcMashHalaPer.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcMashHalaPer.TotalValueFormat.FormatString = "p2";
            this.calcMashHalaPer.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcMashHalaPer.ValueFormat.FormatString = "p2";
            this.calcMashHalaPer.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.pivotGridControlMain.DataSource = this.vQry31BindingSource;
            this.pivotGridControlMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountMMashatId,
            this.fieldyasref1,
            this.fieldSarfExpetion1,
            this.fieldmcompletesarf1,
            this.fieldSyndicate1,
            this.fieldSubCommitte1,
            this.fieldMashHala,
            this.calcMashHalaPer});
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Green;
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            pivotGridStyleFormatCondition1.Field = this.calcMashHalaPer;
            pivotGridStyleFormatCondition1.FieldName = "calcMashHalaPer";
            pivotGridStyleFormatCondition1.Value1 = ".5";
            pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            pivotGridStyleFormatCondition2.Field = this.calcMashHalaPer;
            pivotGridStyleFormatCondition2.FieldName = "calcMashHalaPer";
            pivotGridStyleFormatCondition2.Value1 = ".5";
            this.pivotGridControlMain.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1,
            pivotGridStyleFormatCondition2});
            this.pivotGridControlMain.Location = new System.Drawing.Point(0, 53);
            this.pivotGridControlMain.Name = "pivotGridControlMain";
            this.pivotGridControlMain.Size = new System.Drawing.Size(734, 408);
            this.pivotGridControlMain.TabIndex = 4;
            // 
            // vQry31BindingSource
            // 
            this.vQry31BindingSource.DataMember = "vQry31";
            this.vQry31BindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCountMMashatId
            // 
            this.fieldCountMMashatId.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldCountMMashatId.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCountMMashatId.Appearance.Header.Options.UseTextOptions = true;
            this.fieldCountMMashatId.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCountMMashatId.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCountMMashatId.AreaIndex = 0;
            this.fieldCountMMashatId.Caption = "العدد";
            this.fieldCountMMashatId.FieldName = "CountMMashatId";
            this.fieldCountMMashatId.Name = "fieldCountMMashatId";
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
            // fieldSarfExpetion1
            // 
            this.fieldSarfExpetion1.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldSarfExpetion1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSarfExpetion1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldSarfExpetion1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSarfExpetion1.AreaIndex = 1;
            this.fieldSarfExpetion1.Caption = "استثناء";
            this.fieldSarfExpetion1.FieldName = "SarfExpetion";
            this.fieldSarfExpetion1.Name = "fieldSarfExpetion1";
            // 
            // fieldmcompletesarf1
            // 
            this.fieldmcompletesarf1.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldmcompletesarf1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldmcompletesarf1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldmcompletesarf1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldmcompletesarf1.AreaIndex = 2;
            this.fieldmcompletesarf1.Caption = "صرف كامل";
            this.fieldmcompletesarf1.FieldName = "mcompletesarf";
            this.fieldmcompletesarf1.Name = "fieldmcompletesarf1";
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
            // 
            // fieldSubCommitte1
            // 
            this.fieldSubCommitte1.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldSubCommitte1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSubCommitte1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldSubCommitte1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSubCommitte1.AreaIndex = 3;
            this.fieldSubCommitte1.Caption = "لجنة";
            this.fieldSubCommitte1.FieldName = "SubCommitte";
            this.fieldSubCommitte1.Name = "fieldSubCommitte1";
            // 
            // fieldMashHala
            // 
            this.fieldMashHala.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldMashHala.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldMashHala.Appearance.Header.Options.UseTextOptions = true;
            this.fieldMashHala.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldMashHala.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMashHala.AreaIndex = 0;
            this.fieldMashHala.Caption = "الحالة";
            this.fieldMashHala.FieldName = "MashHala";
            this.fieldMashHala.Name = "fieldMashHala";
            // 
            // vQry31TableAdapter
            // 
            this.vQry31TableAdapter.ClearBeforeFill = true;
            // 
            // Qry31Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.pivotGridControlMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "Qry31Frm";
            this.Text = "احصائيات الاعضاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            this.Shown += new System.EventHandler(this.Qry31Frm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlMain;
        private DevExpress.XtraPivotGrid.PivotGridField fieldyasref1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSarfExpetion1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldmcompletesarf1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSyndicate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSubCommitte1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountMMashatId;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource vQry31BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry31TableAdapter vQry31TableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMashHala;
        private DevExpress.XtraPivotGrid.PivotGridField calcMashHalaPer;

    }
}