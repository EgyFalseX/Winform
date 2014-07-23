namespace Members
{
    partial class XRep03
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xtctotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcesalno = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcSyndicate = new DevExpress.XtraReports.UI.XRTableCell();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xpbLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xlHafzaDate = new DevExpress.XtraReports.UI.XRLabel();
            this.paramprintdate = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrlSum = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlCount = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.teachersUnionDataSet1 = new Members.DataSources.dsTeachersUnion();
            this.xRep03_QTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.XRep03_QTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersUnionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 25F;
            this.Detail.MultiColumn.ColumnWidth = 326F;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UsePadding = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(92.00001F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(484.4998F, 25F);
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xtctotal,
            this.xtcesalno,
            this.xtcSyndicate});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xtctotal
            // 
            this.xtctotal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRep03_Q.total")});
            this.xtctotal.Name = "xtctotal";
            this.xtctotal.Text = "xtctotal";
            this.xtctotal.Weight = 1.9270834350585937D;
            // 
            // xtcesalno
            // 
            this.xtcesalno.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRep03_Q.esalno")});
            this.xtcesalno.Name = "xtcesalno";
            this.xtcesalno.Text = "xtcesalno";
            this.xtcesalno.Weight = 1.251248779296875D;
            // 
            // xtcSyndicate
            // 
            this.xtcSyndicate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRep03_Q.Syndicate")});
            this.xtcSyndicate.Name = "xtcSyndicate";
            this.xtcSyndicate.StylePriority.UseTextAlignment = false;
            this.xtcSyndicate.Text = "xtcSyndicate";
            this.xtcSyndicate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xtcSyndicate.Weight = 1.6666662597656248D;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 0F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xpbLogo
            // 
            this.xpbLogo.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.xpbLogo.Name = "xpbLogo";
            this.xpbLogo.SizeF = new System.Drawing.SizeF(100F, 80F);
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(91.99995F, 98.95834F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(484.4998F, 25F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseForeColor = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell7});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "المجموع";
            this.xrTableCell4.Weight = 1.9270834350585937D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "رقم الايصال";
            this.xrTableCell5.Weight = 1.251248779296875D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "اسم الفرعية";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 1.6666662597656248D;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(383.1251F, 29F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(113.5416F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "التاريخ";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xlHafzaDate
            // 
            this.xlHafzaDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.paramprintdate, "Text", "{0:dd/MM/yyyy}")});
            this.xlHafzaDate.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.xlHafzaDate.LocationFloat = new DevExpress.Utils.PointFloat(261.2501F, 29F);
            this.xlHafzaDate.Name = "xlHafzaDate";
            this.xlHafzaDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlHafzaDate.SizeF = new System.Drawing.SizeF(121.8749F, 23F);
            this.xlHafzaDate.StylePriority.UseFont = false;
            this.xlHafzaDate.StylePriority.UseTextAlignment = false;
            this.xlHafzaDate.Text = "xlHafzaDate";
            this.xlHafzaDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // paramprintdate
            // 
            this.paramprintdate.Description = "تاريخ الطباعة";
            this.paramprintdate.Name = "paramprintdate";
            this.paramprintdate.Type = typeof(System.DateTime);
            this.paramprintdate.ValueInfo = "08/05/2013 15:50:28";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(588.3329F, 29F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(216.6667F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "ادارة المعلومات ودعم اتخاذ القرار";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(647.7081F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(157.2917F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "نقابة المهن التعليمية";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlSum,
            this.xrLabel8,
            this.xrlCount,
            this.xrLabel5});
            this.bottomMarginBand1.HeightF = 64.33334F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // xrlSum
            // 
            this.xrlSum.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRep03_Q.total")});
            this.xrlSum.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.xrlSum.LocationFloat = new DevExpress.Utils.PointFloat(134.1667F, 32.99999F);
            this.xrlSum.Name = "xrlSum";
            this.xrlSum.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlSum.SizeF = new System.Drawing.SizeF(113.5416F, 23F);
            this.xrlSum.StylePriority.UseFont = false;
            this.xrlSum.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#,#}";
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrlSum.Summary = xrSummary1;
            this.xrlSum.Text = "xrlSum";
            this.xrlSum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(134.1667F, 10.00001F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(113.5416F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "المجموع";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlCount
            // 
            this.xrlCount.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRep03_Q.esalno")});
            this.xrlCount.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.xrlCount.LocationFloat = new DevExpress.Utils.PointFloat(436.2498F, 32.99999F);
            this.xrlCount.Name = "xrlCount";
            this.xrlCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlCount.SizeF = new System.Drawing.SizeF(113.5416F, 23F);
            this.xrlCount.StylePriority.UseFont = false;
            this.xrlCount.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:#,#}";
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary2.IgnoreNullValues = true;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrlCount.Summary = xrSummary2;
            this.xrlCount.Text = "xrlCount";
            this.xrlCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(436.25F, 10.00001F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(113.5416F, 23F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "العدد";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel9,
            this.xlHafzaDate,
            this.xpbLogo});
            this.ReportHeader.HeightF = 123.9583F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // teachersUnionDataSet1
            // 
            this.teachersUnionDataSet1.DataSetName = "TeachersUnionDataSet";
            this.teachersUnionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xRep03_QTableAdapter
            // 
            this.xRep03_QTableAdapter.ClearBeforeFill = true;
            // 
            // XRep03
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.ReportHeader});
            this.DataAdapter = this.xRep03_QTableAdapter;
            this.DataMember = "XRep03_Q";
            this.DataSource = this.teachersUnionDataSet1;
            this.DrawGrid = false;
            this.Margins = new System.Drawing.Printing.Margins(12, 0, 0, 64);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramprintdate});
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 10;
            this.Version = "12.2";
            this.ParametersRequestSubmit += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.XRep03_ParametersRequestSubmit);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersUnionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xlHafzaDate;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xtctotal;
        private DevExpress.XtraReports.UI.XRTableCell xtcesalno;
        private DevExpress.XtraReports.UI.XRTableCell xtcSyndicate;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrlCount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRPictureBox xpbLogo;
        private DevExpress.XtraReports.UI.XRLabel xrlSum;
        private DevExpress.XtraReports.Parameters.Parameter paramprintdate;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DataSources.dsTeachersUnion teachersUnionDataSet1;
        private DataSources.dsTeachersUnionTableAdapters.XRep03_QTableAdapter xRep03_QTableAdapter;
    }
}
