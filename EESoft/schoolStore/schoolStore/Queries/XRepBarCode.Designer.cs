namespace schoolStore
{
    partial class XRepBarCode
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
            this.xrBarCodeItem = new DevExpress.XtraReports.UI.XRBarCode();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pram1 = new DevExpress.XtraReports.Parameters.Parameter();
            this.lblModelNo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblpriceout = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblpriceout,
            this.lblModelNo,
            this.xrBarCodeItem});
            this.Detail.HeightF = 91.66663F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrBarCodeItem
            // 
            this.xrBarCodeItem.AutoModule = true;
            this.xrBarCodeItem.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 33.00002F);
            this.xrBarCodeItem.Name = "xrBarCodeItem";
            this.xrBarCodeItem.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCodeItem.SizeF = new System.Drawing.SizeF(630F, 50F);
            this.xrBarCodeItem.StylePriority.UseTextAlignment = false;
            this.xrBarCodeItem.Symbology = code128Generator1;
            this.xrBarCodeItem.Text = "12345";
            this.xrBarCodeItem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 21.875F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 26.0417F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pram1
            // 
            this.pram1.Description = "التصنيف";
            this.pram1.Name = "pram1";
            this.pram1.Type = typeof(int);
            this.pram1.Visible = false;
            // 
            // lblModelNo
            // 
            this.lblModelNo.CanGrow = false;
            this.lblModelNo.CanShrink = true;
            this.lblModelNo.LocationFloat = new DevExpress.Utils.PointFloat(22.49998F, 10.00004F);
            this.lblModelNo.Name = "lblModelNo";
            this.lblModelNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblModelNo.SizeF = new System.Drawing.SizeF(80F, 23F);
            this.lblModelNo.StylePriority.UseTextAlignment = false;
            this.lblModelNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // lblpriceout
            // 
            this.lblpriceout.CanGrow = false;
            this.lblpriceout.CanShrink = true;
            this.lblpriceout.LocationFloat = new DevExpress.Utils.PointFloat(104.7916F, 10.00004F);
            this.lblpriceout.Name = "lblpriceout";
            this.lblpriceout.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblpriceout.SizeF = new System.Drawing.SizeF(80F, 23F);
            this.lblpriceout.StylePriority.UseTextAlignment = false;
            this.lblpriceout.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // XRepBarCode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 22, 26);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pram1});
            this.Version = "11.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter pram1;
        public DevExpress.XtraReports.UI.XRBarCode xrBarCodeItem;
        private DevExpress.XtraReports.UI.XRLabel lblpriceout;
        private DevExpress.XtraReports.UI.XRLabel lblModelNo;
    }
}
