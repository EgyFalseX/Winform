namespace Fellowship.Qry
{
    partial class Qry005
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
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSchool = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGOV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDARET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoahel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dSFellowshipQuery = new Fellowship.DataSources.DSFellowshipQuery();
            this.vQry005BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vQry005TableAdapter = new Fellowship.DataSources.DSFellowshipQueryTableAdapters.vQry005TableAdapter();
            this.colGOV2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAll_Edarat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsed_Edarat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowshipQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry005BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.vQry005BindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 3);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(971, 387);
            this.gridControlData.TabIndex = 2;
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
            this.colGOV2,
            this.colAll_Edarat,
            this.colUsed_Edarat});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colSchool
            // 
            this.colSchool.FieldName = "School";
            this.colSchool.Name = "colSchool";
            this.colSchool.Visible = true;
            this.colSchool.VisibleIndex = 0;
            // 
            // colGOV
            // 
            this.colGOV.FieldName = "GOV";
            this.colGOV.Name = "colGOV";
            this.colGOV.Visible = true;
            this.colGOV.VisibleIndex = 0;
            // 
            // colEDARET
            // 
            this.colEDARET.FieldName = "EDARET";
            this.colEDARET.Name = "colEDARET";
            this.colEDARET.Visible = true;
            this.colEDARET.VisibleIndex = 0;
            // 
            // colMoahel
            // 
            this.colMoahel.FieldName = "Moahel";
            this.colMoahel.Name = "colMoahel";
            this.colMoahel.Visible = true;
            this.colMoahel.VisibleIndex = 0;
            // 
            // colJob
            // 
            this.colJob.FieldName = "Job";
            this.colJob.Name = "colJob";
            this.colJob.Visible = true;
            this.colJob.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // dSFellowshipQuery
            // 
            this.dSFellowshipQuery.DataSetName = "DSFellowshipQuery";
            this.dSFellowshipQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vQry005BindingSource
            // 
            this.vQry005BindingSource.DataMember = "vQry005";
            this.vQry005BindingSource.DataSource = this.dSFellowshipQuery;
            // 
            // vQry005TableAdapter
            // 
            this.vQry005TableAdapter.ClearBeforeFill = true;
            // 
            // colGOV2
            // 
            this.colGOV2.AppearanceCell.Options.UseTextOptions = true;
            this.colGOV2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGOV2.AppearanceHeader.Options.UseTextOptions = true;
            this.colGOV2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGOV2.Caption = "المحافظة / المديرية";
            this.colGOV2.FieldName = "GOV";
            this.colGOV2.Name = "colGOV2";
            this.colGOV2.Visible = true;
            this.colGOV2.VisibleIndex = 0;
            this.colGOV2.Width = 162;
            // 
            // colAll_Edarat
            // 
            this.colAll_Edarat.AppearanceCell.Options.UseTextOptions = true;
            this.colAll_Edarat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAll_Edarat.AppearanceHeader.Options.UseTextOptions = true;
            this.colAll_Edarat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAll_Edarat.Caption = "كل الادارات";
            this.colAll_Edarat.FieldName = "All_Edarat";
            this.colAll_Edarat.Name = "colAll_Edarat";
            this.colAll_Edarat.OptionsColumn.ReadOnly = true;
            this.colAll_Edarat.Visible = true;
            this.colAll_Edarat.VisibleIndex = 1;
            this.colAll_Edarat.Width = 142;
            // 
            // colUsed_Edarat
            // 
            this.colUsed_Edarat.AppearanceCell.Options.UseTextOptions = true;
            this.colUsed_Edarat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsed_Edarat.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsed_Edarat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsed_Edarat.Caption = "الادارات المستخدمة";
            this.colUsed_Edarat.FieldName = "Used_Edarat";
            this.colUsed_Edarat.Name = "colUsed_Edarat";
            this.colUsed_Edarat.OptionsColumn.ReadOnly = true;
            this.colUsed_Edarat.Visible = true;
            this.colUsed_Edarat.VisibleIndex = 2;
            this.colUsed_Edarat.Width = 171;
            // 
            // Qry005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 390);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry005";
            this.Text = "المديريات و الادارات";
            this.Load += new System.EventHandler(this.Qry001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowshipQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry005BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colSchool;
        private DevExpress.XtraGrid.Columns.GridColumn colGOV;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET;
        private DevExpress.XtraGrid.Columns.GridColumn colMoahel;
        private DevExpress.XtraGrid.Columns.GridColumn colJob;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DataSources.DSFellowshipQuery dSFellowshipQuery;
        private System.Windows.Forms.BindingSource vQry005BindingSource;
        private DataSources.DSFellowshipQueryTableAdapters.vQry005TableAdapter vQry005TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGOV2;
        private DevExpress.XtraGrid.Columns.GridColumn colAll_Edarat;
        private DevExpress.XtraGrid.Columns.GridColumn colUsed_Edarat;
    }
}