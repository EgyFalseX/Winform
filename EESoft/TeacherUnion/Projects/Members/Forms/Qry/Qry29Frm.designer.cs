namespace Members.Forms.Qry
{
    partial class Qry29Frm
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
            this.LSMSMembers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.colReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworkcount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworkrem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatework = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardsCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardtype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.LSMSMembers;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDMY});
            this.gridControlData.Size = new System.Drawing.Size(734, 409);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // LSMSMembers
            // 
            this.LSMSMembers.ElementType = typeof(Members.DataSources.Linq.vTBLMazroofPlusReceiptsQry29);
            this.LSMSMembers.KeyExpression = "ReceiptNo";
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
            this.colReceiptNo,
            this.colworkcount,
            this.coldatework,
            this.colReceiptDate,
            this.colCardsCount,
            this.colSyndicate,
            this.colCardtype,
            this.colReceiptAmount,
            this.colWorkType,
            this.colRealName,
            this.colworkrem});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            // colReceiptNo
            // 
            this.colReceiptNo.AppearanceCell.Options.UseTextOptions = true;
            this.colReceiptNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colReceiptNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptNo.Caption = "رقم الايصال";
            this.colReceiptNo.FieldName = "ReceiptNo";
            this.colReceiptNo.Name = "colReceiptNo";
            this.colReceiptNo.Visible = true;
            this.colReceiptNo.VisibleIndex = 0;
            // 
            // colworkcount
            // 
            this.colworkcount.AppearanceCell.Options.UseTextOptions = true;
            this.colworkcount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkcount.AppearanceHeader.Options.UseTextOptions = true;
            this.colworkcount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkcount.Caption = "العدد";
            this.colworkcount.FieldName = "workcount";
            this.colworkcount.Name = "colworkcount";
            this.colworkcount.Visible = true;
            this.colworkcount.VisibleIndex = 1;
            // 
            // colworkrem
            // 
            this.colworkrem.AppearanceCell.Options.UseTextOptions = true;
            this.colworkrem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkrem.AppearanceHeader.Options.UseTextOptions = true;
            this.colworkrem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkrem.Caption = "ملاحظات";
            this.colworkrem.FieldName = "workrem";
            this.colworkrem.Name = "colworkrem";
            this.colworkrem.Visible = true;
            this.colworkrem.VisibleIndex = 10;
            // 
            // coldatework
            // 
            this.coldatework.AppearanceCell.Options.UseTextOptions = true;
            this.coldatework.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatework.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatework.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatework.Caption = "تاريخ العمل";
            this.coldatework.ColumnEdit = this.repositoryItemDateEditDMY;
            this.coldatework.FieldName = "datework";
            this.coldatework.Name = "coldatework";
            this.coldatework.Visible = true;
            this.coldatework.VisibleIndex = 2;
            // 
            // colReceiptDate
            // 
            this.colReceiptDate.AppearanceCell.Options.UseTextOptions = true;
            this.colReceiptDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colReceiptDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptDate.Caption = "تاريخ الايصال";
            this.colReceiptDate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colReceiptDate.FieldName = "ReceiptDate";
            this.colReceiptDate.Name = "colReceiptDate";
            this.colReceiptDate.Visible = true;
            this.colReceiptDate.VisibleIndex = 3;
            // 
            // colCardsCount
            // 
            this.colCardsCount.AppearanceCell.Options.UseTextOptions = true;
            this.colCardsCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCardsCount.AppearanceHeader.Options.UseTextOptions = true;
            this.colCardsCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCardsCount.Caption = "عدد الكارنيهات";
            this.colCardsCount.FieldName = "CardsCount";
            this.colCardsCount.Name = "colCardsCount";
            this.colCardsCount.Visible = true;
            this.colCardsCount.VisibleIndex = 4;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "الفرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 5;
            // 
            // colCardtype
            // 
            this.colCardtype.AppearanceCell.Options.UseTextOptions = true;
            this.colCardtype.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCardtype.AppearanceHeader.Options.UseTextOptions = true;
            this.colCardtype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCardtype.Caption = "نوع الكارنية";
            this.colCardtype.FieldName = "Cardtype";
            this.colCardtype.Name = "colCardtype";
            this.colCardtype.Visible = true;
            this.colCardtype.VisibleIndex = 6;
            // 
            // colReceiptAmount
            // 
            this.colReceiptAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colReceiptAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colReceiptAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptAmount.Caption = "قيمة الايصال";
            this.colReceiptAmount.FieldName = "ReceiptAmount";
            this.colReceiptAmount.Name = "colReceiptAmount";
            this.colReceiptAmount.Visible = true;
            this.colReceiptAmount.VisibleIndex = 7;
            // 
            // colWorkType
            // 
            this.colWorkType.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkType.AppearanceHeader.Options.UseTextOptions = true;
            this.colWorkType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkType.Caption = "نوع العمل";
            this.colWorkType.FieldName = "WorkType";
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.Visible = true;
            this.colWorkType.VisibleIndex = 8;
            // 
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "مدخل البيان";
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 9;
            // 
            // Qry29Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry29Frm";
            this.Text = "الايصالات والمظاريف";
            this.Load += new System.EventHandler(this.QryTblAhteatyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSMembers;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn colworkcount;
        private DevExpress.XtraGrid.Columns.GridColumn coldatework;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCardsCount;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colCardtype;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkType;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colworkrem;

    }
}