namespace RetirementCenter
{
    partial class Qry17Frm
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
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateWarasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditSyndicateId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSCDSyndicate = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colSubCommitteWarasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditSubCommitteId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSCDSubCommitte = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumnOpenEditor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEditor = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSyndicateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSubCommitteId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditSyndicateId,
            this.repositoryItemLookUpEditSubCommitteId,
            this.repositoryItemButtonEditEditor});
            this.gridControlData.Size = new System.Drawing.Size(734, 404);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
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
            this.colpersonName,
            this.colMMashatName,
            this.colSyndicateWarasa,
            this.colSubCommitteWarasa,
            this.colsarfnumber,
            this.colPersonId,
            this.gridColumnNames,
            this.gridColumnOpenEditor});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colpersonName
            // 
            this.colpersonName.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.Caption = "اسم الوريث";
            this.colpersonName.FieldName = "personName";
            this.colpersonName.Name = "colpersonName";
            this.colpersonName.OptionsColumn.AllowEdit = false;
            this.colpersonName.Visible = true;
            this.colpersonName.VisibleIndex = 0;
            this.colpersonName.Width = 104;
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
            this.colMMashatName.OptionsColumn.AllowEdit = false;
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 3;
            this.colMMashatName.Width = 115;
            // 
            // colSyndicateWarasa
            // 
            this.colSyndicateWarasa.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateWarasa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateWarasa.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateWarasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateWarasa.Caption = "فرعية الوريث";
            this.colSyndicateWarasa.ColumnEdit = this.repositoryItemLookUpEditSyndicateId;
            this.colSyndicateWarasa.FieldName = "SyndicateId";
            this.colSyndicateWarasa.Name = "colSyndicateWarasa";
            this.colSyndicateWarasa.OptionsColumn.AllowEdit = false;
            this.colSyndicateWarasa.Visible = true;
            this.colSyndicateWarasa.VisibleIndex = 1;
            this.colSyndicateWarasa.Width = 104;
            // 
            // repositoryItemLookUpEditSyndicateId
            // 
            this.repositoryItemLookUpEditSyndicateId.AutoHeight = false;
            this.repositoryItemLookUpEditSyndicateId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSyndicateId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الاسم")});
            this.repositoryItemLookUpEditSyndicateId.DataSource = this.LSMSCDSyndicate;
            this.repositoryItemLookUpEditSyndicateId.DisplayMember = "Syndicate";
            this.repositoryItemLookUpEditSyndicateId.Name = "repositoryItemLookUpEditSyndicateId";
            this.repositoryItemLookUpEditSyndicateId.NullText = "";
            this.repositoryItemLookUpEditSyndicateId.ValueMember = "SyndicateId";
            // 
            // LSMSCDSyndicate
            // 
            this.LSMSCDSyndicate.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSCDSyndicate.KeyExpression = "[SyndicateId]";
            // 
            // colSubCommitteWarasa
            // 
            this.colSubCommitteWarasa.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteWarasa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteWarasa.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteWarasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteWarasa.Caption = "لجنة الوريث";
            this.colSubCommitteWarasa.ColumnEdit = this.repositoryItemLookUpEditSubCommitteId;
            this.colSubCommitteWarasa.FieldName = "SubCommitteId";
            this.colSubCommitteWarasa.Name = "colSubCommitteWarasa";
            this.colSubCommitteWarasa.OptionsColumn.AllowEdit = false;
            this.colSubCommitteWarasa.Visible = true;
            this.colSubCommitteWarasa.VisibleIndex = 2;
            this.colSubCommitteWarasa.Width = 98;
            // 
            // repositoryItemLookUpEditSubCommitteId
            // 
            this.repositoryItemLookUpEditSubCommitteId.AutoHeight = false;
            this.repositoryItemLookUpEditSubCommitteId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSubCommitteId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubCommitte", "الاسم")});
            this.repositoryItemLookUpEditSubCommitteId.DataSource = this.LSMSCDSubCommitte;
            this.repositoryItemLookUpEditSubCommitteId.DisplayMember = "SubCommitte";
            this.repositoryItemLookUpEditSubCommitteId.Name = "repositoryItemLookUpEditSubCommitteId";
            this.repositoryItemLookUpEditSubCommitteId.NullText = "";
            this.repositoryItemLookUpEditSubCommitteId.ValueMember = "SubCommitteId";
            // 
            // LSMSCDSubCommitte
            // 
            this.LSMSCDSubCommitte.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSubCommitte);
            this.LSMSCDSubCommitte.KeyExpression = "[SubCommitteId]";
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
            this.colsarfnumber.OptionsColumn.AllowEdit = false;
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 4;
            this.colsarfnumber.Width = 85;
            // 
            // colPersonId
            // 
            this.colPersonId.AppearanceCell.Options.UseTextOptions = true;
            this.colPersonId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonId.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonId.Caption = "كود الوريث";
            this.colPersonId.FieldName = "PersonId";
            this.colPersonId.Name = "colPersonId";
            this.colPersonId.OptionsColumn.AllowEdit = false;
            this.colPersonId.Visible = true;
            this.colPersonId.VisibleIndex = 5;
            this.colPersonId.Width = 106;
            // 
            // gridColumnNames
            // 
            this.gridColumnNames.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnNames.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNames.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNames.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNames.Caption = "عدد اسماء الوريث";
            this.gridColumnNames.FieldName = "Names";
            this.gridColumnNames.Name = "gridColumnNames";
            this.gridColumnNames.OptionsColumn.AllowEdit = false;
            this.gridColumnNames.Visible = true;
            this.gridColumnNames.VisibleIndex = 6;
            this.gridColumnNames.Width = 97;
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
            // gridColumnOpenEditor
            // 
            this.gridColumnOpenEditor.Caption = "التعديل";
            this.gridColumnOpenEditor.ColumnEdit = this.repositoryItemButtonEditEditor;
            this.gridColumnOpenEditor.Name = "gridColumnOpenEditor";
            this.gridColumnOpenEditor.Visible = true;
            this.gridColumnOpenEditor.VisibleIndex = 7;
            // 
            // repositoryItemButtonEditEditor
            // 
            this.repositoryItemButtonEditEditor.AutoHeight = false;
            this.repositoryItemButtonEditEditor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditEditor.Name = "repositoryItemButtonEditEditor";
            this.repositoryItemButtonEditEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEditor.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEditor_ButtonClick);
            // 
            // Qry17Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry17Frm";
            this.Text = "عدد الاسماء للورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            this.Shown += new System.EventHandler(this.Qry17Frm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSyndicateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSubCommitteId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateWarasa;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteWarasa;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNames;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSubCommitte;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSyndicateId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSubCommitteId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOpenEditor;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEditor;

    }
}