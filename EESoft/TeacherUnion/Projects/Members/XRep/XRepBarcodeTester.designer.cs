namespace Members
{
    partial class XRepBarcodeTester
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrBarCodeTest = new DevExpress.XtraReports.UI.XRBarCode();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.pramValue = new DevExpress.XtraReports.Parameters.Parameter();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pramWidth = new DevExpress.XtraReports.Parameters.Parameter();
            this.pramHight = new DevExpress.XtraReports.Parameters.Parameter();
            this.pramType = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCodeTest});
            this.Detail.HeightF = 68.75F;
            this.Detail.MultiColumn.ColumnWidth = 326F;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UsePadding = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrBarCodeTest
            // 
            this.xrBarCodeTest.AutoModule = true;
            this.xrBarCodeTest.LocationFloat = new DevExpress.Utils.PointFloat(340.625F, 24.58334F);
            this.xrBarCodeTest.Name = "xrBarCodeTest";
            this.xrBarCodeTest.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCodeTest.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrBarCodeTest.StylePriority.UseTextAlignment = false;
            this.xrBarCodeTest.Symbology = code128Generator1;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 0F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // pramValue
            // 
            this.pramValue.Description = "رقم الباركود";
            this.pramValue.Name = "pramValue";
            this.pramValue.Value = "123456";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // pramWidth
            // 
            this.pramWidth.Description = "العرض";
            this.pramWidth.Name = "pramWidth";
            this.pramWidth.Type = typeof(int);
            this.pramWidth.Value = 100;
            // 
            // pramHight
            // 
            this.pramHight.Description = "الارتفاع";
            this.pramHight.Name = "pramHight";
            this.pramHight.Type = typeof(int);
            this.pramHight.Value = 30;
            // 
            // pramType
            // 
            this.pramType.Description = "النوع";
            this.pramType.Name = "pramType";
            this.pramType.Visible = false;
            // 
            // XRepBarcodeTester
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.DrawGrid = false;
            this.Margins = new System.Drawing.Printing.Margins(12, 0, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pramValue,
            this.pramWidth,
            this.pramHight,
            this.pramType});
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 10;
            this.Version = "11.2";
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.XRepBarcodeTester_ParametersRequestBeforeShow);
            this.ParametersRequestSubmit += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.XRepBarcodeTester_ParametersRequestSubmit);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.Parameters.Parameter pramValue;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCodeTest;
        private DevExpress.XtraReports.Parameters.Parameter pramWidth;
        private DevExpress.XtraReports.Parameters.Parameter pramHight;
        private DevExpress.XtraReports.Parameters.Parameter pramType;
    }
}
