namespace Members
{
    partial class XRep07
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
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.hafzawebListTableAdapter1 = new Members.DataSources.dsTeachersUnionQueryTableAdapters.HafzawebListTableAdapter();
            this.dsTeachersUnionQuery1 = new Members.DataSources.dsTeachersUnionQuery();
            this.DetailGeneral = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTableDetails = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtVarCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtNameCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrlFilterType = new DevExpress.XtraReports.UI.XRLabel();
            this.xlSyndicateId = new DevExpress.XtraReports.UI.XRLabel();
            this.Pramhafzaid = new DevExpress.XtraReports.Parameters.Parameter();
            this.xpbLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTableHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtHeaderCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtHeaderCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.rep07TableAdapter = new Members.DataSources.dsTeachersUnionQueryTableAdapters.Rep07TableAdapter();
            this.PramFilterType = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // hafzawebListTableAdapter1
            // 
            this.hafzawebListTableAdapter1.ClearBeforeFill = true;
            // 
            // dsTeachersUnionQuery1
            // 
            this.dsTeachersUnionQuery1.DataSetName = "dsTeachersUnionQuery";
            this.dsTeachersUnionQuery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetailGeneral
            // 
            this.DetailGeneral.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableDetails});
            this.DetailGeneral.HeightF = 25F;
            this.DetailGeneral.MultiColumn.ColumnWidth = 400F;
            this.DetailGeneral.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.DetailGeneral.Name = "DetailGeneral";
            this.DetailGeneral.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SubCommitteId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("MemberName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.DetailGeneral.StylePriority.UsePadding = false;
            this.DetailGeneral.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableDetails
            // 
            this.xrTableDetails.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrTableDetails.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 0F);
            this.xrTableDetails.Name = "xrTableDetails";
            this.xrTableDetails.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTableDetails.SizeF = new System.Drawing.SizeF(399F, 25F);
            this.xrTableDetails.StylePriority.UseFont = false;
            this.xrTableDetails.StylePriority.UseTextAlignment = false;
            this.xrTableDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtVarCell,
            this.xrtNameCell,
            this.xrTableCell2});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrtVarCell
            // 
            this.xrtVarCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Rep07.SubCommitte")});
            this.xrtVarCell.Name = "xrtVarCell";
            this.xrtVarCell.StylePriority.UseTextAlignment = false;
            this.xrtVarCell.Text = "[SubCommitte]";
            this.xrtVarCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrtVarCell.Weight = 1.3591668564868846D;
            // 
            // xrtNameCell
            // 
            this.xrtNameCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Rep07.MemberName")});
            this.xrtNameCell.Name = "xrtNameCell";
            this.xrtNameCell.StylePriority.UseTextAlignment = false;
            this.xrtNameCell.Text = "xtcMemberShipNumber";
            this.xrtNameCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrtNameCell.Weight = 1.3591669020890533D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell2.Summary = xrSummary1;
            this.xrTableCell2.Weight = 1.3591667697965233D;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlFilterType,
            this.xlSyndicateId,
            this.xpbLogo,
            this.xrLabel7,
            this.xrLabel2,
            this.xrLabel1});
            this.topMarginBand1.HeightF = 112.5F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrlFilterType
            // 
            this.xrlFilterType.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.xrlFilterType.LocationFloat = new DevExpress.Utils.PointFloat(362.5F, 87.5F);
            this.xrlFilterType.Name = "xrlFilterType";
            this.xrlFilterType.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlFilterType.SizeF = new System.Drawing.SizeF(113.5416F, 25F);
            this.xrlFilterType.StylePriority.UseFont = false;
            this.xrlFilterType.StylePriority.UseTextAlignment = false;
            this.xrlFilterType.Text = "xxxxx";
            this.xrlFilterType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xlSyndicateId
            // 
            this.xlSyndicateId.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Pramhafzaid, "Text", "")});
            this.xlSyndicateId.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.xlSyndicateId.LocationFloat = new DevExpress.Utils.PointFloat(213.75F, 42.00001F);
            this.xlSyndicateId.Name = "xlSyndicateId";
            this.xlSyndicateId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlSyndicateId.SizeF = new System.Drawing.SizeF(194F, 25F);
            this.xlSyndicateId.StylePriority.UseFont = false;
            this.xlSyndicateId.StylePriority.UseTextAlignment = false;
            this.xlSyndicateId.Text = "xlSyndicateId";
            this.xlSyndicateId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Pramhafzaid
            // 
            this.Pramhafzaid.Description = "رقم الحافظة";
            dynamicListLookUpSettings1.DataAdapter = this.hafzawebListTableAdapter1;
            dynamicListLookUpSettings1.DataMember = "HafzawebList";
            dynamicListLookUpSettings1.DataSource = this.dsTeachersUnionQuery1;
            dynamicListLookUpSettings1.DisplayMember = "hafzaid";
            dynamicListLookUpSettings1.ValueMember = "hafzaid";
            this.Pramhafzaid.LookUpSettings = dynamicListLookUpSettings1;
            this.Pramhafzaid.Name = "Pramhafzaid";
            this.Pramhafzaid.Type = typeof(int);
            this.Pramhafzaid.ValueInfo = "0";
            // 
            // xpbLogo
            // 
            this.xpbLogo.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xpbLogo.Name = "xpbLogo";
            this.xpbLogo.SizeF = new System.Drawing.SizeF(100F, 80F);
            this.xpbLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(407.75F, 42.00001F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(113.5416F, 25F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "رقم الحافظه";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(588.3332F, 39.00001F);
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
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(647.7083F, 10.00001F);
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
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableHeader});
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTableHeader
            // 
            this.xrTableHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrTableHeader.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 0F);
            this.xrTableHeader.Name = "xrTableHeader";
            this.xrTableHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTableHeader.SizeF = new System.Drawing.SizeF(398F, 25F);
            this.xrTableHeader.StylePriority.UseBackColor = false;
            this.xrTableHeader.StylePriority.UseFont = false;
            this.xrTableHeader.StylePriority.UseForeColor = false;
            this.xrTableHeader.StylePriority.UseTextAlignment = false;
            this.xrTableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtHeaderCell1,
            this.xrtHeaderCell2,
            this.xrTableCell1});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrtHeaderCell1
            // 
            this.xrtHeaderCell1.Name = "xrtHeaderCell1";
            this.xrtHeaderCell1.StylePriority.UseTextAlignment = false;
            this.xrtHeaderCell1.Text = "اللجنة";
            this.xrtHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrtHeaderCell1.Weight = 0.81919998403945848D;
            // 
            // xrtHeaderCell2
            // 
            this.xrtHeaderCell2.Name = "xrtHeaderCell2";
            this.xrtHeaderCell2.StylePriority.UseTextAlignment = false;
            this.xrtHeaderCell2.Text = "الاسم";
            this.xrtHeaderCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrtHeaderCell2.Weight = 1.4742820068216544D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "رقم";
            this.xrTableCell1.Weight = 0.43328443607246614D;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(485.4168F, 41.04169F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(14.58331F, 25F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = ":";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(500.0001F, 41.04169F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(47.91663F, 25F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "المستلم";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(276.0419F, 10.00001F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(271.8749F, 25F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "استلمت الكارنيهات طبقاً للبيان الموضح اعلاه";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel3.Visible = false;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrlTotal,
            this.xrLabel3,
            this.xrLabel5,
            this.xrLabel6});
            this.PageFooter.HeightF = 83.33334F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(705.7086F, 10.00001F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(91.66663F, 25F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "العدد";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrlTotal
            // 
            this.xrlTotal.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrlTotal.LocationFloat = new DevExpress.Utils.PointFloat(622.7083F, 10.00001F);
            this.xrlTotal.Name = "xrlTotal";
            this.xrlTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlTotal.SizeF = new System.Drawing.SizeF(83.00031F, 25F);
            this.xrlTotal.StylePriority.UseFont = false;
            this.xrlTotal.StylePriority.UseTextAlignment = false;
            this.xrlTotal.Text = "0";
            this.xrlTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // rep07TableAdapter
            // 
            this.rep07TableAdapter.ClearBeforeFill = true;
            // 
            // PramFilterType
            // 
            this.PramFilterType.Description = "النوع";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "ما تم طباعتة"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "ما لم يتم طباعتة"));
            this.PramFilterType.LookUpSettings = staticListLookUpSettings1;
            this.PramFilterType.Name = "PramFilterType";
            this.PramFilterType.Type = typeof(int);
            this.PramFilterType.ValueInfo = "0";
            // 
            // XRep07
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.DetailGeneral,
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.PageHeader,
            this.PageFooter});
            this.DataAdapter = this.rep07TableAdapter;
            this.DataMember = "Rep07";
            this.DataSource = this.dsTeachersUnionQuery1;
            this.DrawGrid = false;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 112, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Pramhafzaid,
            this.PramFilterType});
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 10;
            this.Version = "12.2";
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.XRep07_ParametersRequestBeforeShow);
            this.ParametersRequestSubmit += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.XRep07_ParametersRequestSubmit);
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand DetailGeneral;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRPictureBox xpbLogo;
        private DevExpress.XtraReports.UI.XRLabel xlSyndicateId;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrlTotal;
        private DataSources.dsTeachersUnionQuery dsTeachersUnionQuery1;
        private DataSources.dsTeachersUnionQueryTableAdapters.Rep07TableAdapter rep07TableAdapter;
        private DevExpress.XtraReports.UI.XRTable xrTableHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrtHeaderCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrtHeaderCell2;
        private DataSources.dsTeachersUnionQueryTableAdapters.HafzawebListTableAdapter hafzawebListTableAdapter1;
        private DevExpress.XtraReports.Parameters.Parameter Pramhafzaid;
        private DevExpress.XtraReports.UI.XRTable xrTableDetails;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrtVarCell;
        private DevExpress.XtraReports.UI.XRTableCell xrtNameCell;
        private DevExpress.XtraReports.Parameters.Parameter PramFilterType;
        private DevExpress.XtraReports.UI.XRLabel xrlFilterType;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
    }
}
