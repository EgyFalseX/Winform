namespace Members.Forms.Qry
{
    partial class Qry24Frm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.chartControlMain = new DevExpress.XtraCharts.ChartControl();
            this.qry24BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnionQuery = new Members.DataSources.dsTeachersUnionQuery();
            this.qry24TableAdapter = new Members.DataSources.dsTeachersUnionQueryTableAdapters.Qry24TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry24BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(734, 47);
            this.panelControl1.TabIndex = 2;
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
            // chartControlMain
            // 
            this.chartControlMain.DataSource = this.qry24BindingSource;
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisX.Label.MaxWidth = 120;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Title.Antialiasing = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisY.Label.MaxWidth = 120;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlMain.Diagram = xyDiagram1;
            this.chartControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlMain.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControlMain.Location = new System.Drawing.Point(0, 47);
            this.chartControlMain.Name = "chartControlMain";
            series1.ArgumentDataMember = "YM";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "SeriesMonthYear";
            series1.ValueDataMembersSerializable = "C";
            this.chartControlMain.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.chartControlMain.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chartControlMain.Size = new System.Drawing.Size(734, 415);
            this.chartControlMain.TabIndex = 3;
            chartTitle1.Antialiasing = false;
            chartTitle1.Text = "عدد الاعضاء المدخلة شهريا";
            this.chartControlMain.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // qry24BindingSource
            // 
            this.qry24BindingSource.DataMember = "Qry24";
            this.qry24BindingSource.DataSource = this.dsTeachersUnionQuery;
            // 
            // dsTeachersUnionQuery
            // 
            this.dsTeachersUnionQuery.DataSetName = "dsTeachersUnionQuery";
            this.dsTeachersUnionQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qry24TableAdapter
            // 
            this.qry24TableAdapter.ClearBeforeFill = true;
            // 
            // Qry24Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.chartControlMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "Qry24Frm";
            this.Text = "عدد الادخال بالشهر و السنة";
            this.Load += new System.EventHandler(this.QryTblAhteatyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry24BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraCharts.ChartControl chartControlMain;
        private DataSources.dsTeachersUnionQuery dsTeachersUnionQuery;
        private System.Windows.Forms.BindingSource qry24BindingSource;
        private DataSources.dsTeachersUnionQueryTableAdapters.Qry24TableAdapter qry24TableAdapter;

    }
}