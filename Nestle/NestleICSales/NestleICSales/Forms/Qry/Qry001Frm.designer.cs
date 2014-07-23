namespace NestleICSales
{
    partial class Qry001Frm
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
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerNameEn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerNameEn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerNameAr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerNameAr2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel6Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel6Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel5Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel5Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel4Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel4Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel3Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustHierLevel3Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributionChannel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityEnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityArName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubchannelName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.LSMS.ElementType = typeof(NestleICSales.DataSources.Linq.vQry001);
            this.LSMS.KeyExpression = "CustomerId";
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
            this.colCustomerId,
            this.colCustomerNameEn1,
            this.colCustomerNameEn2,
            this.colCustomerNameAr1,
            this.colCustomerNameAr2,
            this.colCustHierLevel6Id,
            this.colCreationDate,
            this.colCustomerAddress,
            this.colCityId,
            this.colCustHierLevel6Name,
            this.colCustHierLevel5Id,
            this.colCustHierLevel5Name,
            this.colCustHierLevel4Id,
            this.colCustHierLevel4Name,
            this.colCustHierLevel3Id,
            this.colCustHierLevel3Name,
            this.colDistributionChannel,
            this.colCityEnName,
            this.colCityArName,
            this.colCustomerGroup,
            this.colCustomerType,
            this.colCustomerType2,
            this.colSubchannelName});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CustomerId", this.colCustomerId, "")});
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
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CustomerId", "{0}")});
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 0;
            this.colCustomerId.Width = 78;
            // 
            // colCustomerNameEn1
            // 
            this.colCustomerNameEn1.FieldName = "CustomerNameEn1";
            this.colCustomerNameEn1.Name = "colCustomerNameEn1";
            this.colCustomerNameEn1.Visible = true;
            this.colCustomerNameEn1.VisibleIndex = 1;
            this.colCustomerNameEn1.Width = 116;
            // 
            // colCustomerNameEn2
            // 
            this.colCustomerNameEn2.FieldName = "CustomerNameEn2";
            this.colCustomerNameEn2.Name = "colCustomerNameEn2";
            this.colCustomerNameEn2.Visible = true;
            this.colCustomerNameEn2.VisibleIndex = 2;
            this.colCustomerNameEn2.Width = 116;
            // 
            // colCustomerNameAr1
            // 
            this.colCustomerNameAr1.FieldName = "CustomerNameAr1";
            this.colCustomerNameAr1.Name = "colCustomerNameAr1";
            this.colCustomerNameAr1.Visible = true;
            this.colCustomerNameAr1.VisibleIndex = 3;
            this.colCustomerNameAr1.Width = 115;
            // 
            // colCustomerNameAr2
            // 
            this.colCustomerNameAr2.FieldName = "CustomerNameAr2";
            this.colCustomerNameAr2.Name = "colCustomerNameAr2";
            this.colCustomerNameAr2.Visible = true;
            this.colCustomerNameAr2.VisibleIndex = 4;
            this.colCustomerNameAr2.Width = 115;
            // 
            // colCustHierLevel6Id
            // 
            this.colCustHierLevel6Id.FieldName = "CustHierLevel6Id";
            this.colCustHierLevel6Id.Name = "colCustHierLevel6Id";
            // 
            // colCreationDate
            // 
            this.colCreationDate.FieldName = "CreationDate";
            this.colCreationDate.Name = "colCreationDate";
            this.colCreationDate.Visible = true;
            this.colCreationDate.VisibleIndex = 5;
            this.colCreationDate.Width = 86;
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.Visible = true;
            this.colCustomerAddress.VisibleIndex = 6;
            this.colCustomerAddress.Width = 107;
            // 
            // colCityId
            // 
            this.colCityId.FieldName = "CityId";
            this.colCityId.Name = "colCityId";
            // 
            // colCustHierLevel6Name
            // 
            this.colCustHierLevel6Name.FieldName = "CustHierLevel6Name";
            this.colCustHierLevel6Name.Name = "colCustHierLevel6Name";
            this.colCustHierLevel6Name.Visible = true;
            this.colCustHierLevel6Name.VisibleIndex = 11;
            this.colCustHierLevel6Name.Width = 124;
            // 
            // colCustHierLevel5Id
            // 
            this.colCustHierLevel5Id.FieldName = "CustHierLevel5Id";
            this.colCustHierLevel5Id.Name = "colCustHierLevel5Id";
            // 
            // colCustHierLevel5Name
            // 
            this.colCustHierLevel5Name.FieldName = "CustHierLevel5Name";
            this.colCustHierLevel5Name.Name = "colCustHierLevel5Name";
            this.colCustHierLevel5Name.Visible = true;
            this.colCustHierLevel5Name.VisibleIndex = 10;
            this.colCustHierLevel5Name.Width = 124;
            // 
            // colCustHierLevel4Id
            // 
            this.colCustHierLevel4Id.FieldName = "CustHierLevel4Id";
            this.colCustHierLevel4Id.Name = "colCustHierLevel4Id";
            // 
            // colCustHierLevel4Name
            // 
            this.colCustHierLevel4Name.FieldName = "CustHierLevel4Name";
            this.colCustHierLevel4Name.Name = "colCustHierLevel4Name";
            this.colCustHierLevel4Name.Visible = true;
            this.colCustHierLevel4Name.VisibleIndex = 9;
            this.colCustHierLevel4Name.Width = 124;
            // 
            // colCustHierLevel3Id
            // 
            this.colCustHierLevel3Id.FieldName = "CustHierLevel3Id";
            this.colCustHierLevel3Id.Name = "colCustHierLevel3Id";
            // 
            // colCustHierLevel3Name
            // 
            this.colCustHierLevel3Name.FieldName = "CustHierLevel3Name";
            this.colCustHierLevel3Name.Name = "colCustHierLevel3Name";
            this.colCustHierLevel3Name.Visible = true;
            this.colCustHierLevel3Name.VisibleIndex = 8;
            this.colCustHierLevel3Name.Width = 124;
            // 
            // colDistributionChannel
            // 
            this.colDistributionChannel.FieldName = "DistributionChannel";
            this.colDistributionChannel.Name = "colDistributionChannel";
            this.colDistributionChannel.Visible = true;
            this.colDistributionChannel.VisibleIndex = 7;
            this.colDistributionChannel.Width = 115;
            // 
            // colCityEnName
            // 
            this.colCityEnName.FieldName = "CityEnName";
            this.colCityEnName.Name = "colCityEnName";
            this.colCityEnName.Visible = true;
            this.colCityEnName.VisibleIndex = 16;
            this.colCityEnName.Width = 83;
            // 
            // colCityArName
            // 
            this.colCityArName.FieldName = "CityArName";
            this.colCityArName.Name = "colCityArName";
            // 
            // colCustomerGroup
            // 
            this.colCustomerGroup.FieldName = "CustomerGroup";
            this.colCustomerGroup.Name = "colCustomerGroup";
            this.colCustomerGroup.Visible = true;
            this.colCustomerGroup.VisibleIndex = 13;
            this.colCustomerGroup.Width = 97;
            // 
            // colCustomerType
            // 
            this.colCustomerType.FieldName = "CustomerType";
            this.colCustomerType.Name = "colCustomerType";
            this.colCustomerType.Visible = true;
            this.colCustomerType.VisibleIndex = 14;
            this.colCustomerType.Width = 92;
            // 
            // colCustomerType2
            // 
            this.colCustomerType2.FieldName = "CustomerType2";
            this.colCustomerType2.Name = "colCustomerType2";
            this.colCustomerType2.Visible = true;
            this.colCustomerType2.VisibleIndex = 15;
            this.colCustomerType2.Width = 98;
            // 
            // colSubchannelName
            // 
            this.colSubchannelName.FieldName = "SubchannelName";
            this.colSubchannelName.Name = "colSubchannelName";
            this.colSubchannelName.Visible = true;
            this.colSubchannelName.VisibleIndex = 12;
            this.colSubchannelName.Width = 104;
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
            // Qry001Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry001Frm";
            this.Text = "Customers";
            this.Icon = Properties.Resources.Qry16;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerNameEn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerNameEn2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerNameAr1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerNameAr2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel6Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCityId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel6Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel5Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel5Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel4Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel4Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel3Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCustHierLevel3Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributionChannel;
        private DevExpress.XtraGrid.Columns.GridColumn colCityEnName;
        private DevExpress.XtraGrid.Columns.GridColumn colCityArName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType2;
        private DevExpress.XtraGrid.Columns.GridColumn colSubchannelName;

    }
}