namespace E_Club_Sub_Manager
{
    partial class QryMembershipFrm
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
            this.gridControlMembership = new DevExpress.XtraGrid.GridControl();
            this.gridViewMembership = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCmem_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCmem_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCmem_mNUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCmembership_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCmembership_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCmembership_end_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCPaymentValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditPaymentValue = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMembership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPaymentValue)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMembership
            // 
            this.gridControlMembership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMembership.Location = new System.Drawing.Point(0, 0);
            this.gridControlMembership.MainView = this.gridViewMembership;
            this.gridControlMembership.Name = "gridControlMembership";
            this.gridControlMembership.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditPaymentValue});
            this.gridControlMembership.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMembership.Size = new System.Drawing.Size(734, 412);
            this.gridControlMembership.TabIndex = 0;
            this.gridControlMembership.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMembership});
            // 
            // gridViewMembership
            // 
            this.gridViewMembership.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewMembership.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewMembership.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewMembership.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewMembership.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewMembership.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewMembership.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewMembership.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridViewMembership.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewMembership.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewMembership.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridViewMembership.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewMembership.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridViewMembership.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridViewMembership.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridViewMembership.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewMembership.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridViewMembership.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMembership.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewMembership.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridViewMembership.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMembership.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewMembership.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewMembership.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewMembership.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewMembership.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewMembership.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMembership.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewMembership.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridViewMembership.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMembership.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewMembership.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridViewMembership.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMembership.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewMembership.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewMembership.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMembership.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewMembership.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewMembership.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewMembership.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewMembership.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridViewMembership.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewMembership.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridViewMembership.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridViewMembership.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewMembership.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewMembership.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewMembership.Appearance.Row.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridViewMembership.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridViewMembership.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewMembership.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewMembership.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewMembership.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCmem_name,
            this.GCmem_ID,
            this.GCmem_mNUMBER,
            this.GCmembership_type,
            this.GCmembership_start_date,
            this.GCmembership_end_date,
            this.GCPaymentValue});
            this.gridViewMembership.GridControl = this.gridControlMembership;
            this.gridViewMembership.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "mem_ID", this.GCmem_name, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentValue", this.GCPaymentValue, "")});
            this.gridViewMembership.Name = "gridViewMembership";
            this.gridViewMembership.OptionsBehavior.Editable = false;
            this.gridViewMembership.OptionsView.ColumnAutoWidth = false;
            this.gridViewMembership.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMembership.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMembership.OptionsView.ShowFooter = true;
            // 
            // GCmem_name
            // 
            this.GCmem_name.Caption = "اسم العضو";
            this.GCmem_name.FieldName = "mem_name";
            this.GCmem_name.Name = "GCmem_name";
            this.GCmem_name.Visible = true;
            this.GCmem_name.VisibleIndex = 6;
            this.GCmem_name.Width = 73;
            // 
            // GCmem_ID
            // 
            this.GCmem_ID.Caption = "كود العضو";
            this.GCmem_ID.FieldName = "mem_ID";
            this.GCmem_ID.Name = "GCmem_ID";
            this.GCmem_ID.Visible = true;
            this.GCmem_ID.VisibleIndex = 5;
            this.GCmem_ID.Width = 68;
            // 
            // GCmem_mNUMBER
            // 
            this.GCmem_mNUMBER.Caption = "رقم العضويه";
            this.GCmem_mNUMBER.FieldName = "mem_mNUMBER";
            this.GCmem_mNUMBER.Name = "GCmem_mNUMBER";
            this.GCmem_mNUMBER.Visible = true;
            this.GCmem_mNUMBER.VisibleIndex = 4;
            this.GCmem_mNUMBER.Width = 86;
            // 
            // GCmembership_type
            // 
            this.GCmembership_type.Caption = "نوع العضويه";
            this.GCmembership_type.FieldName = "membership_type";
            this.GCmembership_type.Name = "GCmembership_type";
            this.GCmembership_type.Visible = true;
            this.GCmembership_type.VisibleIndex = 3;
            this.GCmembership_type.Width = 84;
            // 
            // GCmembership_start_date
            // 
            this.GCmembership_start_date.Caption = "بداية الاشتراك";
            this.GCmembership_start_date.FieldName = "membership_start_date";
            this.GCmembership_start_date.Name = "GCmembership_start_date";
            this.GCmembership_start_date.Visible = true;
            this.GCmembership_start_date.VisibleIndex = 2;
            this.GCmembership_start_date.Width = 97;
            // 
            // GCmembership_end_date
            // 
            this.GCmembership_end_date.Caption = "نهاية الاشتراك";
            this.GCmembership_end_date.FieldName = "membership_end_date";
            this.GCmembership_end_date.Name = "GCmembership_end_date";
            this.GCmembership_end_date.Visible = true;
            this.GCmembership_end_date.VisibleIndex = 1;
            this.GCmembership_end_date.Width = 95;
            // 
            // GCPaymentValue
            // 
            this.GCPaymentValue.Caption = "قيمة السداد";
            this.GCPaymentValue.ColumnEdit = this.repositoryItemTextEditPaymentValue;
            this.GCPaymentValue.FieldName = "PaymentValue";
            this.GCPaymentValue.Name = "GCPaymentValue";
            this.GCPaymentValue.Visible = true;
            this.GCPaymentValue.VisibleIndex = 0;
            this.GCPaymentValue.Width = 83;
            // 
            // repositoryItemTextEditPaymentValue
            // 
            this.repositoryItemTextEditPaymentValue.AutoHeight = false;
            this.repositoryItemTextEditPaymentValue.DisplayFormat.FormatString = "c";
            this.repositoryItemTextEditPaymentValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditPaymentValue.EditFormat.FormatString = "c";
            this.repositoryItemTextEditPaymentValue.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditPaymentValue.Mask.EditMask = "c";
            this.repositoryItemTextEditPaymentValue.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditPaymentValue.Name = "repositoryItemTextEditPaymentValue";
            // 
            // QryMembershipFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.gridControlMembership);
            this.Name = "QryMembershipFrm";
            this.Text = "استعلام عن الاشتراكات";
            this.Load += new System.EventHandler(this.QryMembershipFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMembership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPaymentValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMembership;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMembership;
        private DevExpress.XtraGrid.Columns.GridColumn GCmem_name;
        private DevExpress.XtraGrid.Columns.GridColumn GCmem_ID;
        private DevExpress.XtraGrid.Columns.GridColumn GCmem_mNUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn GCmembership_type;
        private DevExpress.XtraGrid.Columns.GridColumn GCmembership_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn GCmembership_end_date;
        private DevExpress.XtraGrid.Columns.GridColumn GCPaymentValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditPaymentValue;
    }
}