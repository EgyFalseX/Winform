namespace Fellowship.Qry
{
    partial class Qry002
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControlData = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.vQry002BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFellowshipQuery = new Fellowship.DataSources.DSFellowshipQuery();
            this.fieldMEM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGOV1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldEdara1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMoahel1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSchool1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldJob1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.vQry002TableAdapter = new Fellowship.DataSources.DSFellowshipQueryTableAdapters.vQry002TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry002BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowshipQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(971, 47);
            this.panelControl1.TabIndex = 4;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(825, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // pivotGridControlData
            // 
            this.pivotGridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControlData.DataSource = this.vQry002BindingSource;
            this.pivotGridControlData.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldMEM1,
            this.fieldGOV1,
            this.fieldEdara1,
            this.fieldMoahel1,
            this.fieldSchool1,
            this.fieldJob1});
            this.pivotGridControlData.Location = new System.Drawing.Point(0, 53);
            this.pivotGridControlData.Name = "pivotGridControlData";
            this.pivotGridControlData.Size = new System.Drawing.Size(971, 335);
            this.pivotGridControlData.TabIndex = 5;
            // 
            // vQry002BindingSource
            // 
            this.vQry002BindingSource.DataMember = "vQry002";
            this.vQry002BindingSource.DataSource = this.dSFellowshipQuery;
            // 
            // dSFellowshipQuery
            // 
            this.dSFellowshipQuery.DataSetName = "DSFellowshipQuery";
            this.dSFellowshipQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldMEM1
            // 
            this.fieldMEM1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMEM1.AreaIndex = 0;
            this.fieldMEM1.Caption = "عدد الاعضاء";
            this.fieldMEM1.FieldName = "MEM";
            this.fieldMEM1.Name = "fieldMEM1";
            // 
            // fieldGOV1
            // 
            this.fieldGOV1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldGOV1.AreaIndex = 0;
            this.fieldGOV1.Caption = "المحافظة / المديرية";
            this.fieldGOV1.FieldName = "GOV";
            this.fieldGOV1.Name = "fieldGOV1";
            this.fieldGOV1.Options.ShowTotals = false;
            this.fieldGOV1.Width = 160;
            // 
            // fieldEdara1
            // 
            this.fieldEdara1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldEdara1.AreaIndex = 1;
            this.fieldEdara1.Caption = "الادارة";
            this.fieldEdara1.FieldName = "Edara";
            this.fieldEdara1.Name = "fieldEdara1";
            this.fieldEdara1.Options.ShowTotals = false;
            // 
            // fieldMoahel1
            // 
            this.fieldMoahel1.AreaIndex = 0;
            this.fieldMoahel1.Caption = "المؤهل";
            this.fieldMoahel1.FieldName = "Moahel";
            this.fieldMoahel1.Name = "fieldMoahel1";
            // 
            // fieldSchool1
            // 
            this.fieldSchool1.AreaIndex = 1;
            this.fieldSchool1.Caption = "المدرسة";
            this.fieldSchool1.FieldName = "School";
            this.fieldSchool1.Name = "fieldSchool1";
            // 
            // fieldJob1
            // 
            this.fieldJob1.AreaIndex = 2;
            this.fieldJob1.Caption = "الوظيفة";
            this.fieldJob1.FieldName = "Job";
            this.fieldJob1.Name = "fieldJob1";
            // 
            // vQry002TableAdapter
            // 
            this.vQry002TableAdapter.ClearBeforeFill = true;
            // 
            // Qry002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 390);
            this.Controls.Add(this.pivotGridControlData);
            this.Controls.Add(this.panelControl1);
            this.Name = "Qry002";
            this.Text = "بيانات الاعضاء احصائي";
            this.Load += new System.EventHandler(this.Qry001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry002BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowshipQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlData;
        private DataSources.DSFellowshipQuery dSFellowshipQuery;
        private System.Windows.Forms.BindingSource vQry002BindingSource;
        private DataSources.DSFellowshipQueryTableAdapters.vQry002TableAdapter vQry002TableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMEM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGOV1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldEdara1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMoahel1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSchool1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJob1;
    }
}