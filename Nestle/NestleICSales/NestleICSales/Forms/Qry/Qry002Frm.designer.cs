namespace NestleICSales
{
    partial class Qry002Frm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMS = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolumPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolumCarton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePriceCarton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePricePiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumerPriceCarton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumerPricePiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPallet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSplit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePointLastYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePointOldYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlavor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceChanges = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroup3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroup2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.LSMS;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 38);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(734, 419);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // LSMS
            // 
            this.LSMS.ElementType = typeof(NestleICSales.DataSources.Linq.vQry002);
            this.LSMS.KeyExpression = "MaterialNumber";
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewData.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewData.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewData.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewData.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewData.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewData.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewData.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewData.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridViewData.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewData.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridViewData.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewData.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.Row.Options.UseBackColor = true;
            this.gridViewData.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewData.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterialNumber,
            this.colMaterialName,
            this.colQuantity,
            this.colVolumPiece,
            this.colVolumCarton,
            this.colTradePriceCarton,
            this.colTradePricePiece,
            this.colConsumerPriceCarton,
            this.colConsumerPricePiece,
            this.colPallet,
            this.colSplit,
            this.colValidDateStart,
            this.colValidDateEnd,
            this.colPricePoint,
            this.colPricePointLastYear,
            this.colPricePointOldYear,
            this.coluserin,
            this.coldatein,
            this.colFlavor,
            this.colMaterialType,
            this.colPriceChanges,
            this.colNPDS,
            this.colBaseProduct,
            this.colBrand,
            this.colBusinessUnit,
            this.colProductGroup3,
            this.colProductGroup2,
            this.colProductGroup1});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CustomerId", null, "")});
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colMaterialNumber
            // 
            this.colMaterialNumber.FieldName = "MaterialNumber";
            this.colMaterialNumber.Name = "colMaterialNumber";
            this.colMaterialNumber.Visible = true;
            this.colMaterialNumber.VisibleIndex = 7;
            this.colMaterialNumber.Width = 97;
            // 
            // colMaterialName
            // 
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 8;
            this.colMaterialName.Width = 87;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 9;
            // 
            // colVolumPiece
            // 
            this.colVolumPiece.FieldName = "VolumPiece";
            this.colVolumPiece.Name = "colVolumPiece";
            this.colVolumPiece.Visible = true;
            this.colVolumPiece.VisibleIndex = 10;
            // 
            // colVolumCarton
            // 
            this.colVolumCarton.FieldName = "VolumCarton";
            this.colVolumCarton.Name = "colVolumCarton";
            this.colVolumCarton.Visible = true;
            this.colVolumCarton.VisibleIndex = 11;
            this.colVolumCarton.Width = 83;
            // 
            // colTradePriceCarton
            // 
            this.colTradePriceCarton.FieldName = "TradePriceCarton";
            this.colTradePriceCarton.Name = "colTradePriceCarton";
            this.colTradePriceCarton.Visible = true;
            this.colTradePriceCarton.VisibleIndex = 12;
            this.colTradePriceCarton.Width = 109;
            // 
            // colTradePricePiece
            // 
            this.colTradePricePiece.FieldName = "TradePricePiece";
            this.colTradePricePiece.Name = "colTradePricePiece";
            this.colTradePricePiece.Visible = true;
            this.colTradePricePiece.VisibleIndex = 13;
            this.colTradePricePiece.Width = 101;
            // 
            // colConsumerPriceCarton
            // 
            this.colConsumerPriceCarton.FieldName = "ConsumerPriceCarton";
            this.colConsumerPriceCarton.Name = "colConsumerPriceCarton";
            this.colConsumerPriceCarton.Visible = true;
            this.colConsumerPriceCarton.VisibleIndex = 14;
            this.colConsumerPriceCarton.Width = 129;
            // 
            // colConsumerPricePiece
            // 
            this.colConsumerPricePiece.FieldName = "ConsumerPricePiece";
            this.colConsumerPricePiece.Name = "colConsumerPricePiece";
            this.colConsumerPricePiece.Visible = true;
            this.colConsumerPricePiece.VisibleIndex = 15;
            this.colConsumerPricePiece.Width = 121;
            // 
            // colPallet
            // 
            this.colPallet.FieldName = "Pallet";
            this.colPallet.Name = "colPallet";
            this.colPallet.Visible = true;
            this.colPallet.VisibleIndex = 16;
            // 
            // colSplit
            // 
            this.colSplit.FieldName = "Split";
            this.colSplit.Name = "colSplit";
            this.colSplit.Visible = true;
            this.colSplit.VisibleIndex = 17;
            // 
            // colValidDateStart
            // 
            this.colValidDateStart.FieldName = "ValidDateStart";
            this.colValidDateStart.Name = "colValidDateStart";
            this.colValidDateStart.Visible = true;
            this.colValidDateStart.VisibleIndex = 18;
            this.colValidDateStart.Width = 94;
            // 
            // colValidDateEnd
            // 
            this.colValidDateEnd.FieldName = "ValidDateEnd";
            this.colValidDateEnd.Name = "colValidDateEnd";
            this.colValidDateEnd.Visible = true;
            this.colValidDateEnd.VisibleIndex = 19;
            this.colValidDateEnd.Width = 88;
            // 
            // colPricePoint
            // 
            this.colPricePoint.FieldName = "PricePoint";
            this.colPricePoint.Name = "colPricePoint";
            this.colPricePoint.Visible = true;
            this.colPricePoint.VisibleIndex = 20;
            // 
            // colPricePointLastYear
            // 
            this.colPricePointLastYear.FieldName = "PricePointLastYear";
            this.colPricePointLastYear.Name = "colPricePointLastYear";
            this.colPricePointLastYear.Visible = true;
            this.colPricePointLastYear.VisibleIndex = 21;
            this.colPricePointLastYear.Width = 117;
            // 
            // colPricePointOldYear
            // 
            this.colPricePointOldYear.FieldName = "PricePointOldYear";
            this.colPricePointOldYear.Name = "colPricePointOldYear";
            this.colPricePointOldYear.Visible = true;
            this.colPricePointOldYear.VisibleIndex = 22;
            this.colPricePointOldYear.Width = 113;
            // 
            // coluserin
            // 
            this.coluserin.FieldName = "userin";
            this.coluserin.Name = "coluserin";
            // 
            // coldatein
            // 
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            // 
            // colFlavor
            // 
            this.colFlavor.FieldName = "Flavor";
            this.colFlavor.Name = "colFlavor";
            this.colFlavor.Visible = true;
            this.colFlavor.VisibleIndex = 6;
            // 
            // colMaterialType
            // 
            this.colMaterialType.FieldName = "MaterialType";
            this.colMaterialType.Name = "colMaterialType";
            this.colMaterialType.Visible = true;
            this.colMaterialType.VisibleIndex = 23;
            this.colMaterialType.Width = 84;
            // 
            // colPriceChanges
            // 
            this.colPriceChanges.FieldName = "PriceChanges";
            this.colPriceChanges.Name = "colPriceChanges";
            this.colPriceChanges.Visible = true;
            this.colPriceChanges.VisibleIndex = 24;
            this.colPriceChanges.Width = 87;
            // 
            // colNPDS
            // 
            this.colNPDS.FieldName = "NPDS";
            this.colNPDS.Name = "colNPDS";
            this.colNPDS.Visible = true;
            this.colNPDS.VisibleIndex = 25;
            // 
            // colBaseProduct
            // 
            this.colBaseProduct.FieldName = "BaseProduct";
            this.colBaseProduct.Name = "colBaseProduct";
            this.colBaseProduct.Visible = true;
            this.colBaseProduct.VisibleIndex = 5;
            this.colBaseProduct.Width = 82;
            // 
            // colBrand
            // 
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 1;
            // 
            // colBusinessUnit
            // 
            this.colBusinessUnit.FieldName = "BusinessUnit";
            this.colBusinessUnit.Name = "colBusinessUnit";
            this.colBusinessUnit.Visible = true;
            this.colBusinessUnit.VisibleIndex = 0;
            this.colBusinessUnit.Width = 82;
            // 
            // colProductGroup3
            // 
            this.colProductGroup3.FieldName = "ProductGroup3";
            this.colProductGroup3.Name = "colProductGroup3";
            this.colProductGroup3.Visible = true;
            this.colProductGroup3.VisibleIndex = 4;
            this.colProductGroup3.Width = 94;
            // 
            // colProductGroup2
            // 
            this.colProductGroup2.FieldName = "ProductGroup2";
            this.colProductGroup2.Name = "colProductGroup2";
            this.colProductGroup2.Visible = true;
            this.colProductGroup2.VisibleIndex = 3;
            this.colProductGroup2.Width = 94;
            // 
            // colProductGroup1
            // 
            this.colProductGroup1.FieldName = "ProductGroup1";
            this.colProductGroup1.Name = "colProductGroup1";
            this.colProductGroup1.Visible = true;
            this.colProductGroup1.VisibleIndex = 2;
            this.colProductGroup1.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(734, 32);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(595, 5);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "Print / Export";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // Qry002Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry002Frm";
            this.Text = "Products";
            this.Icon = Properties.Resources.Qry16;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.Data.Linq.LinqServerModeSource LSMS;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colVolumPiece;
        private DevExpress.XtraGrid.Columns.GridColumn colVolumCarton;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePriceCarton;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePricePiece;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumerPriceCarton;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumerPricePiece;
        private DevExpress.XtraGrid.Columns.GridColumn colPallet;
        private DevExpress.XtraGrid.Columns.GridColumn colSplit;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colValidDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePoint;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePointLastYear;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePointOldYear;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn colFlavor;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialType;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceChanges;
        private DevExpress.XtraGrid.Columns.GridColumn colNPDS;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroup1;

    }
}