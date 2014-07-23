namespace CardSets
{
    partial class XRepCard_SRC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XRepCard));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xlsefa2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrtitleName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPBImg = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xlsubcommite = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xlsefaName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xlmembername = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xbCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.dsCards1 = new CardSets.DataSources.dsCards();
            this.memberdataTableAdapter = new CardSets.DataSources.dsCardsTableAdapters.memberdataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCards1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.HeightF = 196.6667F;
            this.Detail.MultiColumn.ColumnWidth = 326F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel1.CanGrow = false;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlsefa2,
            this.xrtitleName,
            this.xrPictureBox1,
            this.xrLabel14,
            this.xrLabel8,
            this.xrLabel4,
            this.xrLabel2,
            this.xrPBImg,
            this.xlsubcommite,
            this.xrLabel7,
            this.xlsefaName,
            this.xrLabel3,
            this.xlmembername,
            this.xrLabel1,
            this.xbCode});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(10F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(303F, 190F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xlsefa2
            // 
            this.xlsefa2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlsefa2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "memberdata.Sefa2")});
            this.xlsefa2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xlsefa2.LocationFloat = new DevExpress.Utils.PointFloat(150.2918F, 112.7226F);
            this.xlsefa2.Name = "xlsefa2";
            this.xlsefa2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlsefa2.SizeF = new System.Drawing.SizeF(142.3749F, 17.60339F);
            this.xlsefa2.StylePriority.UseBorders = false;
            this.xlsefa2.StylePriority.UseFont = false;
            this.xlsefa2.StylePriority.UseTextAlignment = false;
            this.xlsefa2.Text = "xlsefa2";
            this.xlsefa2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrtitleName
            // 
            this.xrtitleName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrtitleName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrtitleName.LocationFloat = new DevExpress.Utils.PointFloat(80.00005F, 40F);
            this.xrtitleName.Name = "xrtitleName";
            this.xrtitleName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrtitleName.SizeF = new System.Drawing.SizeF(223F, 17.87333F);
            this.xrtitleName.StylePriority.UseBorders = false;
            this.xrtitleName.StylePriority.UseFont = false;
            this.xrtitleName.StylePriority.UseTextAlignment = false;
            this.xrtitleName.Text = "هيئة مكتب النقابة العامة 2012";
            this.xrtitleName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(36.04F, 149.0633F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(60F, 20F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 169.0633F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(112.5134F, 17.60341F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "أ. أحمد محمد عبد المقصود";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(242.7917F, 137.5215F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(8.958344F, 17.6034F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = ":";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(224.0417F, 87.92387F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(8.958344F, 17.6034F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = ":";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(259.0417F, 63.12501F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(8.958344F, 17.6034F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = ":";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPBImg
            // 
            this.xrPBImg.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 43.65943F);
            this.xrPBImg.Name = "xrPBImg";
            this.xrPBImg.SizeF = new System.Drawing.SizeF(70F, 70F);
            this.xrPBImg.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xlsubcommite
            // 
            this.xlsubcommite.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlsubcommite.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "memberdata.KidNumber")});
            this.xlsubcommite.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xlsubcommite.LocationFloat = new DevExpress.Utils.PointFloat(104.0992F, 137.5215F);
            this.xlsubcommite.Name = "xlsubcommite";
            this.xlsubcommite.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlsubcommite.SizeF = new System.Drawing.SizeF(138.6925F, 17.60339F);
            this.xlsubcommite.StylePriority.UseBorders = false;
            this.xlsubcommite.StylePriority.UseFont = false;
            this.xlsubcommite.StylePriority.UseTextAlignment = false;
            this.xlsubcommite.Text = "xlsubcommite";
            this.xlsubcommite.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(251.75F, 137.5215F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(41.24997F, 17.60339F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "رقم القيد";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xlsefaName
            // 
            this.xlsefaName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlsefaName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "memberdata.sefaName")});
            this.xlsefaName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xlsefaName.LocationFloat = new DevExpress.Utils.PointFloat(80.00004F, 87.92387F);
            this.xlsefaName.Name = "xlsefaName";
            this.xlsefaName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlsefaName.SizeF = new System.Drawing.SizeF(144.0417F, 17.6034F);
            this.xlsefaName.StylePriority.UseBorders = false;
            this.xlsefaName.StylePriority.UseFont = false;
            this.xlsefaName.StylePriority.UseTextAlignment = false;
            this.xlsefaName.Text = "[sefaName]";
            this.xlsefaName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(233F, 87.92387F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(60F, 17.60341F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "الصفة النقابية";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xlmembername
            // 
            this.xlmembername.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlmembername.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "memberdata.membername")});
            this.xlmembername.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xlmembername.LocationFloat = new DevExpress.Utils.PointFloat(109.3751F, 63.12501F);
            this.xlmembername.Name = "xlmembername";
            this.xlmembername.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlmembername.SizeF = new System.Drawing.SizeF(149.6665F, 17.6034F);
            this.xlmembername.StylePriority.UseBorders = false;
            this.xlmembername.StylePriority.UseFont = false;
            this.xlmembername.StylePriority.UseTextAlignment = false;
            this.xlmembername.Text = "-";
            this.xlmembername.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(268F, 63.12504F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(25F, 17.6034F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "الاسم";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xbCode
            // 
            this.xbCode.AutoModule = true;
            this.xbCode.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "memberdata.KidNumber")});
            this.xbCode.LocationFloat = new DevExpress.Utils.PointFloat(6F, 118.6594F);
            this.xbCode.Name = "xbCode";
            this.xbCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xbCode.ShowText = false;
            this.xbCode.SizeF = new System.Drawing.SizeF(85F, 18F);
            this.xbCode.Symbology = code128Generator1;
            this.xbCode.Text = "xbCode";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.BorderColor = System.Drawing.SystemColors.ControlText;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.White;
            this.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.White;
            this.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.White;
            this.DataField.BorderColor = System.Drawing.SystemColors.ControlText;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
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
            // dsCards1
            // 
            this.dsCards1.DataSetName = "dsCards";
            this.dsCards1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberdataTableAdapter
            // 
            this.memberdataTableAdapter.ClearBeforeFill = true;
            // 
            // XRepCard
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.DataAdapter = this.memberdataTableAdapter;
            this.DataMember = "memberdata";
            this.DataSource = this.dsCards1;
            this.DrawGrid = false;
            this.FilterString = "[chk] = True";
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 205;
            this.PageWidth = 328;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "11.2";
            this.Watermark.Image = ((System.Drawing.Image)(resources.GetObject("XRepCard.Watermark.Image")));
            this.Watermark.ImageTransparency = 255;
            this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;
            ((System.ComponentModel.ISupportInitialize)(this.dsCards1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrtitleName;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPBImg;
        private DevExpress.XtraReports.UI.XRLabel xlsubcommite;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xlsefaName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xlmembername;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRBarCode xbCode;
        private DevExpress.XtraReports.UI.XRLabel xlsefa2;
        private DataSources.dsCards dsCards1;
        private DataSources.dsCardsTableAdapters.memberdataTableAdapter memberdataTableAdapter;
    }
}
