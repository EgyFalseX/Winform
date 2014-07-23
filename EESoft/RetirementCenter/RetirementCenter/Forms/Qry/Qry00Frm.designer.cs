namespace RetirementCenter
{
    partial class Qry00Frm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewTBLWarasa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMSTBLMashats = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewTBLMashats = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyasref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkeEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemPictureEditImg = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLWarasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLMashats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLMashats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewTBLWarasa
            // 
            this.gridViewTBLWarasa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewTBLWarasa.GridControl = this.gridControlData;
            this.gridViewTBLWarasa.Name = "gridViewTBLWarasa";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "اسم الوريث";
            this.gridColumn1.FieldName = "personName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "النوع";
            this.gridColumn2.FieldName = "WarasaTypeId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.LSMSTBLMashats;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            gridLevelNode1.LevelTemplate = this.gridViewTBLWarasa;
            gridLevelNode1.RelationName = "TBLWarasa";
            this.gridControlData.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewTBLMashats;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDate,
            this.repositoryItemPictureEditImg,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEditDMY});
            this.gridControlData.Size = new System.Drawing.Size(734, 404);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTBLMashats,
            this.gridViewTBLWarasa});
            // 
            // LSMSTBLMashats
            // 
            this.LSMSTBLMashats.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLMashat);
            this.LSMSTBLMashats.KeyExpression = "[MMashatId]";
            // 
            // gridViewTBLMashats
            // 
            this.gridViewTBLMashats.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewTBLMashats.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewTBLMashats.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewTBLMashats.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewTBLMashats.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewTBLMashats.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewTBLMashats.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewTBLMashats.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridViewTBLMashats.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewTBLMashats.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewTBLMashats.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridViewTBLMashats.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewTBLMashats.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridViewTBLMashats.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridViewTBLMashats.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridViewTBLMashats.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewTBLMashats.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridViewTBLMashats.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewTBLMashats.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewTBLMashats.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridViewTBLMashats.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewTBLMashats.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewTBLMashats.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewTBLMashats.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewTBLMashats.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewTBLMashats.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewTBLMashats.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTBLMashats.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewTBLMashats.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewTBLMashats.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewTBLMashats.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridViewTBLMashats.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridViewTBLMashats.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewTBLMashats.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridViewTBLMashats.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridViewTBLMashats.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewTBLMashats.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewTBLMashats.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewTBLMashats.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewTBLMashats.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewTBLMashats.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewTBLMashats.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewTBLMashats.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridViewTBLMashats.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewTBLMashats.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridViewTBLMashats.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridViewTBLMashats.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewTBLMashats.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewTBLMashats.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewTBLMashats.Appearance.Row.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridViewTBLMashats.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridViewTBLMashats.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewTBLMashats.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewTBLMashats.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewTBLMashats.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatName,
            this.colsarfnumber,
            this.colyasref,
            this.colSyndicateId,
            this.colSubCommitte,
            this.colWorkeEndDate,
            this.coldatein,
            this.colMMashatId});
            this.gridViewTBLMashats.GridControl = this.gridControlData;
            this.gridViewTBLMashats.Name = "gridViewTBLMashats";
            this.gridViewTBLMashats.OptionsCustomization.AllowRowSizing = true;
            this.gridViewTBLMashats.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewTBLMashats.OptionsFind.AlwaysVisible = true;
            this.gridViewTBLMashats.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewTBLMashats.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewTBLMashats.OptionsView.AllowCellMerge = true;
            this.gridViewTBLMashats.OptionsView.ColumnAutoWidth = false;
            this.gridViewTBLMashats.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewTBLMashats.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewTBLMashats.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTBLMashats.OptionsView.ShowFooter = true;
            this.gridViewTBLMashats.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridViewTBLMashats_MasterRowGetChildList);
            this.gridViewTBLMashats.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTBLMashats_FocusedRowChanged);
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "اسم العضو";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 0;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم الصرف";
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 1;
            // 
            // colyasref
            // 
            this.colyasref.AppearanceCell.Options.UseTextOptions = true;
            this.colyasref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.AppearanceHeader.Options.UseTextOptions = true;
            this.colyasref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.Caption = "يصرف";
            this.colyasref.FieldName = "yasref";
            this.colyasref.Name = "colyasref";
            this.colyasref.Visible = true;
            this.colyasref.VisibleIndex = 2;
            this.colyasref.Width = 46;
            // 
            // colSyndicateId
            // 
            this.colSyndicateId.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.Caption = "فرعية العضو";
            this.colSyndicateId.FieldName = "CDSyndicate.Syndicate";
            this.colSyndicateId.Name = "colSyndicateId";
            this.colSyndicateId.Visible = true;
            this.colSyndicateId.VisibleIndex = 3;
            this.colSyndicateId.Width = 114;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "لجنة العضو";
            this.colSubCommitte.FieldName = "CDSubCommitte.SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 4;
            // 
            // colWorkeEndDate
            // 
            this.colWorkeEndDate.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkeEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkeEndDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colWorkeEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkeEndDate.Caption = "تاريخ نهاية العمل";
            this.colWorkeEndDate.FieldName = "WorkeEndDate";
            this.colWorkeEndDate.Name = "colWorkeEndDate";
            this.colWorkeEndDate.Visible = true;
            this.colWorkeEndDate.VisibleIndex = 5;
            this.colWorkeEndDate.Width = 94;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 6;
            // 
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "كود العضو";
            this.colMMashatId.FieldName = "MMashatId";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 7;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "u";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "u";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemPictureEditImg
            // 
            this.repositoryItemPictureEditImg.Name = "repositoryItemPictureEditImg";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            this.panelControl1.TabIndex = 3;
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
            // Qry00Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry00Frm";
            this.Text = "الورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QryTblAhteatyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLWarasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLMashats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLMashats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTBLMashats;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditImg;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLMashats;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn colyasref;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkeEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateId;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTBLWarasa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;

    }
}