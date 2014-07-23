namespace TinyShop.Reports
{
    partial class XrepBarcode
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator2 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrBarCodeItem1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrBarCodeItem2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.lblPrice2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPrice1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPrice1,
            this.lblPrice2,
            this.xrBarCodeItem2,
            this.xrBarCodeItem1});
            this.Detail.HeightF = 120F;
            this.Detail.MultiColumn.ColumnWidth = 200F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrBarCodeItem1
            // 
            this.xrBarCodeItem1.AutoModule = true;
            this.xrBarCodeItem1.LocationFloat = new DevExpress.Utils.PointFloat(4.000016F, 3F);
            this.xrBarCodeItem1.Name = "xrBarCodeItem1";
            this.xrBarCodeItem1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCodeItem1.SizeF = new System.Drawing.SizeF(130F, 45F);
            this.xrBarCodeItem1.StylePriority.UseTextAlignment = false;
            this.xrBarCodeItem1.Symbology = code128Generator2;
            this.xrBarCodeItem1.Text = "123456789";
            this.xrBarCodeItem1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 0F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // xrBarCodeItem2
            // 
            this.xrBarCodeItem2.AutoModule = true;
            this.xrBarCodeItem2.LocationFloat = new DevExpress.Utils.PointFloat(4F, 58.1667F);
            this.xrBarCodeItem2.Name = "xrBarCodeItem2";
            this.xrBarCodeItem2.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCodeItem2.SizeF = new System.Drawing.SizeF(130F, 45F);
            this.xrBarCodeItem2.StylePriority.UseTextAlignment = false;
            this.xrBarCodeItem2.Symbology = code128Generator1;
            this.xrBarCodeItem2.Text = "123456789";
            this.xrBarCodeItem2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoWidth = true;
            this.lblPrice2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblPrice2.LocationFloat = new DevExpress.Utils.PointFloat(4F, 90.1667F);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblPrice2.SizeF = new System.Drawing.SizeF(56.79167F, 13F);
            this.lblPrice2.StylePriority.UseFont = false;
            this.lblPrice2.Text = "12345";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoWidth = true;
            this.lblPrice1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblPrice1.LocationFloat = new DevExpress.Utils.PointFloat(4.000016F, 35F);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPrice1.SizeF = new System.Drawing.SizeF(56.79167F, 13F);
            this.lblPrice1.StylePriority.UseFont = false;
            this.lblPrice1.Text = "12345";
            // 
            // XrepBarcode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 120;
            this.PageWidth = 140;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 10;
            this.Version = "12.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCodeItem1;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCodeItem2;
        private DevExpress.XtraReports.UI.XRLabel lblPrice2;
        private DevExpress.XtraReports.UI.XRLabel lblPrice1;
    }
}
