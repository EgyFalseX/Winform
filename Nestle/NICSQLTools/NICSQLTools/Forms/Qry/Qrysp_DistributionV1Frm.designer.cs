namespace NICSQLTools.Forms.Qry
{
    partial class Qrysp_DistributionV1Frm
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
            this.repositoryItemTextEditf2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiStartDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiEndDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bbiGetData = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.pivotGridControlMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.spDistributionV1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.fieldBaseBaseProduct1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesDistrict1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRouteSold1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAPOS141 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAPOS131 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTAPOS141 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTAPOS131 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldASM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSupervisor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRouteName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBrandRoute1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPre13 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPre14 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemTextEditPer = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sp_DistributionV1TableAdapter = new NICSQLTools.Data.dsQryTableAdapters.sp_DistributionV1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDistributionV1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPer)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTextEditf2
            // 
            this.repositoryItemTextEditf2.AutoHeight = false;
            this.repositoryItemTextEditf2.DisplayFormat.FormatString = "f2";
            this.repositoryItemTextEditf2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditf2.Mask.EditMask = "f2";
            this.repositoryItemTextEditf2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditf2.Name = "repositoryItemTextEditf2";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiExport,
            this.bbiStartDate,
            this.barHeaderItem1,
            this.bbiGetData,
            this.barHeaderItem2,
            this.bbiEndDate});
            this.barManagerMain.MaxItemId = 13;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemDateEdit3});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStartDate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEndDate),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiGetData, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Select Date";
            this.barHeaderItem1.Id = 3;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // bbiStartDate
            // 
            this.bbiStartDate.Caption = "Date Start";
            this.bbiStartDate.Edit = this.repositoryItemDateEdit1;
            this.bbiStartDate.Id = 2;
            this.bbiStartDate.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1));
            this.bbiStartDate.Name = "bbiStartDate";
            this.bbiStartDate.Width = 120;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "End Date";
            this.barHeaderItem2.Id = 11;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // bbiEndDate
            // 
            this.bbiEndDate.Caption = "Date End";
            this.bbiEndDate.Edit = this.repositoryItemDateEdit3;
            this.bbiEndDate.Id = 12;
            this.bbiEndDate.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2));
            this.bbiEndDate.Name = "bbiEndDate";
            this.bbiEndDate.Width = 120;
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // bbiGetData
            // 
            this.bbiGetData.Caption = "Get Data";
            this.bbiGetData.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbiGetData.Glyph = global::NICSQLTools.Properties.Resources.apply_16x16;
            this.bbiGetData.Id = 9;
            this.bbiGetData.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.bbiGetData.Name = "bbiGetData";
            this.bbiGetData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGetData_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NICSQLTools.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(919, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 311);
            this.barDockControlBottom.Size = new System.Drawing.Size(919, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 280);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(919, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 280);
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // pivotGridControlMain
            // 
            this.pivotGridControlMain.DataSource = this.spDistributionV1BindingSource;
            this.pivotGridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControlMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldBaseBaseProduct1,
            this.fieldSalesDistrict1,
            this.fieldRouteSold1,
            this.fieldAPOS141,
            this.fieldAPOS131,
            this.fieldTAPOS141,
            this.fieldTAPOS131,
            this.fieldASM1,
            this.fieldSupervisor1,
            this.fieldRouteName1,
            this.fieldBrandRoute1,
            this.fieldPre13,
            this.fieldPre14});
            this.pivotGridControlMain.Location = new System.Drawing.Point(0, 31);
            this.pivotGridControlMain.Name = "pivotGridControlMain";
            this.pivotGridControlMain.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues;
            this.pivotGridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditPer});
            this.pivotGridControlMain.Size = new System.Drawing.Size(919, 280);
            this.pivotGridControlMain.TabIndex = 14;
            this.pivotGridControlMain.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControlMain_CellDoubleClick);
            // 
            // spDistributionV1BindingSource
            // 
            this.spDistributionV1BindingSource.DataMember = "sp_DistributionV1";
            this.spDistributionV1BindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldBaseBaseProduct1
            // 
            this.fieldBaseBaseProduct1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldBaseBaseProduct1.AreaIndex = 4;
            this.fieldBaseBaseProduct1.Caption = "Base Base Product";
            this.fieldBaseBaseProduct1.FieldName = "Base Base Product";
            this.fieldBaseBaseProduct1.Name = "fieldBaseBaseProduct1";
            // 
            // fieldSalesDistrict1
            // 
            this.fieldSalesDistrict1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesDistrict1.AreaIndex = 0;
            this.fieldSalesDistrict1.Caption = "Sales District";
            this.fieldSalesDistrict1.FieldName = "Sales District";
            this.fieldSalesDistrict1.Name = "fieldSalesDistrict1";
            // 
            // fieldRouteSold1
            // 
            this.fieldRouteSold1.AreaIndex = 0;
            this.fieldRouteSold1.Caption = "Route & Sold";
            this.fieldRouteSold1.FieldName = "Route & Sold";
            this.fieldRouteSold1.Name = "fieldRouteSold1";
            // 
            // fieldAPOS141
            // 
            this.fieldAPOS141.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAPOS141.AreaIndex = 4;
            this.fieldAPOS141.Caption = "APOS CY";
            this.fieldAPOS141.FieldName = "APOS14";
            this.fieldAPOS141.Name = "fieldAPOS141";
            // 
            // fieldAPOS131
            // 
            this.fieldAPOS131.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAPOS131.AreaIndex = 1;
            this.fieldAPOS131.Caption = "APOS LY";
            this.fieldAPOS131.FieldName = "APOS13";
            this.fieldAPOS131.Name = "fieldAPOS131";
            // 
            // fieldTAPOS141
            // 
            this.fieldTAPOS141.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTAPOS141.AreaIndex = 3;
            this.fieldTAPOS141.Caption = "TAPOS CY";
            this.fieldTAPOS141.FieldName = "TAPOS14";
            this.fieldTAPOS141.Name = "fieldTAPOS141";
            // 
            // fieldTAPOS131
            // 
            this.fieldTAPOS131.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTAPOS131.AreaIndex = 0;
            this.fieldTAPOS131.Caption = "TAPOS LY";
            this.fieldTAPOS131.FieldName = "TAPOS13";
            this.fieldTAPOS131.Name = "fieldTAPOS131";
            // 
            // fieldASM1
            // 
            this.fieldASM1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldASM1.AreaIndex = 1;
            this.fieldASM1.Caption = "ASM";
            this.fieldASM1.FieldName = "ASM";
            this.fieldASM1.Name = "fieldASM1";
            // 
            // fieldSupervisor1
            // 
            this.fieldSupervisor1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSupervisor1.AreaIndex = 2;
            this.fieldSupervisor1.Caption = "Supervisor";
            this.fieldSupervisor1.FieldName = "Supervisor";
            this.fieldSupervisor1.Name = "fieldSupervisor1";
            // 
            // fieldRouteName1
            // 
            this.fieldRouteName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldRouteName1.AreaIndex = 3;
            this.fieldRouteName1.Caption = "Route Name";
            this.fieldRouteName1.FieldName = "Route Name";
            this.fieldRouteName1.Name = "fieldRouteName1";
            // 
            // fieldBrandRoute1
            // 
            this.fieldBrandRoute1.AreaIndex = 1;
            this.fieldBrandRoute1.Caption = "Brand Route";
            this.fieldBrandRoute1.FieldName = "Brand Route";
            this.fieldBrandRoute1.Name = "fieldBrandRoute1";
            // 
            // fieldPre13
            // 
            this.fieldPre13.Appearance.Value.ForeColor = System.Drawing.Color.Red;
            this.fieldPre13.Appearance.Value.Options.UseForeColor = true;
            this.fieldPre13.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPre13.AreaIndex = 2;
            this.fieldPre13.Caption = "% LY";
            this.fieldPre13.CellFormat.FormatString = "f2";
            this.fieldPre13.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPre13.EmptyCellText = "0";
            this.fieldPre13.EmptyValueText = "0";
            this.fieldPre13.Name = "fieldPre13";
            this.fieldPre13.TotalCellFormat.FormatString = "f2";
            this.fieldPre13.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPre13.TotalValueFormat.FormatString = "f2";
            this.fieldPre13.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPre13.UnboundExpression = "[fieldTAPOS131]/[fieldTAPOS131]";
            this.fieldPre13.UnboundFieldName = "fieldPre13";
            this.fieldPre13.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.fieldPre13.ValueFormat.FormatString = "f2";
            this.fieldPre13.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldPre14
            // 
            this.fieldPre14.Appearance.Value.ForeColor = System.Drawing.Color.Red;
            this.fieldPre14.Appearance.Value.Options.UseForeColor = true;
            this.fieldPre14.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPre14.AreaIndex = 5;
            this.fieldPre14.Caption = "% CY";
            this.fieldPre14.CellFormat.FormatString = "f2";
            this.fieldPre14.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPre14.EmptyCellText = "0";
            this.fieldPre14.EmptyValueText = "0";
            this.fieldPre14.Name = "fieldPre14";
            this.fieldPre14.TotalCellFormat.FormatString = "f2";
            this.fieldPre14.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPre14.TotalValueFormat.FormatString = "f2";
            this.fieldPre14.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPre14.UnboundExpression = "[fieldAPOS141]/[fieldTAPOS141]";
            this.fieldPre14.UnboundFieldName = "fieldPre14";
            this.fieldPre14.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.fieldPre14.ValueFormat.FormatString = "f2";
            this.fieldPre14.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // repositoryItemTextEditPer
            // 
            this.repositoryItemTextEditPer.AutoHeight = false;
            this.repositoryItemTextEditPer.DisplayFormat.FormatString = "c";
            this.repositoryItemTextEditPer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditPer.Mask.EditMask = "p";
            this.repositoryItemTextEditPer.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditPer.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEditPer.Name = "repositoryItemTextEditPer";
            // 
            // sp_DistributionV1TableAdapter
            // 
            this.sp_DistributionV1TableAdapter.ClearBeforeFill = true;
            // 
            // Qrysp_DistributionV1Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 311);
            this.Controls.Add(this.pivotGridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = global::NICSQLTools.Properties.Resources.Qry16;
            this.Name = "Qrysp_DistributionV1Frm";
            this.Text = "Distribution Per Route";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDistributionV1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarEditItem bbiStartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarLargeButtonItem bbiGetData;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditf2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarEditItem bbiEndDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditPer;
        private System.Windows.Forms.BindingSource spDistributionV1BindingSource;
        private NICSQLTools.Data.dsQry dsQry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBaseBaseProduct1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesDistrict1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRouteSold1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAPOS141;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAPOS131;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTAPOS141;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTAPOS131;
        private DevExpress.XtraPivotGrid.PivotGridField fieldASM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSupervisor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRouteName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBrandRoute1;
        private NICSQLTools.Data.dsQryTableAdapters.sp_DistributionV1TableAdapter sp_DistributionV1TableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPre13;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPre14;
    }
}