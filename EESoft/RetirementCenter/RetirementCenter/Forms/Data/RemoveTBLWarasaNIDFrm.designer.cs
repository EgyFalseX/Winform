namespace RetirementCenter
{
    partial class RemoveTBLWarasaNIDFrm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatNId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemPictureEditImg = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.removeTBLWarasaNIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.removeTBLWarasaNIDTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.RemoveTBLWarasaNIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeTBLWarasaNIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.removeTBLWarasaNIDBindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDate,
            this.repositoryItemPictureEditImg,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEditDMY,
            this.repositoryItemButtonEditDelete});
            this.gridControlData.Size = new System.Drawing.Size(734, 404);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colSyndicate,
            this.colMMashatName,
            this.colMMashatNId,
            this.gridColumn1});
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
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "الفرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.OptionsColumn.AllowEdit = false;
            this.colSyndicate.OptionsColumn.ReadOnly = true;
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 0;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "الاسم";
            this.colMMashatName.FieldName = "personName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.OptionsColumn.AllowEdit = false;
            this.colMMashatName.OptionsColumn.ReadOnly = true;
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 1;
            // 
            // colMMashatNId
            // 
            this.colMMashatNId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.Caption = "الرقم القومي";
            this.colMMashatNId.FieldName = "personNID";
            this.colMMashatNId.Name = "colMMashatNId";
            this.colMMashatNId.OptionsColumn.AllowEdit = false;
            this.colMMashatNId.OptionsColumn.ReadOnly = true;
            this.colMMashatNId.Visible = true;
            this.colMMashatNId.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "حذف الرقم القومي";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 106;
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDelete_ButtonClick);
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
            // removeTBLWarasaNIDBindingSource
            // 
            this.removeTBLWarasaNIDBindingSource.DataMember = "RemoveTBLWarasaNID";
            this.removeTBLWarasaNIDBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // removeTBLWarasaNIDTableAdapter
            // 
            this.removeTBLWarasaNIDTableAdapter.ClearBeforeFill = true;
            // 
            // RemoveTBLWarasaNIDFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "RemoveTBLWarasaNIDFrm";
            this.Text = "حذف الرقم القومي للورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.removeTBLWarasaNIDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditImg;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatNId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private System.Windows.Forms.BindingSource removeTBLWarasaNIDBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.RemoveTBLWarasaNIDTableAdapter removeTBLWarasaNIDTableAdapter;

    }
}