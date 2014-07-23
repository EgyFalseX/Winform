namespace RetirementCenter.Forms.Data
{
    partial class TBLNoSarfWarsaInfo
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
            this.gridControlTBLNoSarfWarsa = new DevExpress.XtraGrid.GridControl();
            this.tBLNoSarfWarsaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridViewTBLNoSarfWarsa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldatehala = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colyasref1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.coldatein1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.coluserin1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tBLNoSarfWarsaTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLNoSarfWarsaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTBLNoSarfWarsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLNoSarfWarsaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLNoSarfWarsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlTBLNoSarfWarsa
            // 
            this.gridControlTBLNoSarfWarsa.DataSource = this.tBLNoSarfWarsaBindingSource;
            this.gridControlTBLNoSarfWarsa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTBLNoSarfWarsa.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlTBLNoSarfWarsa.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlTBLNoSarfWarsa.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlTBLNoSarfWarsa.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlTBLNoSarfWarsa.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlTBLNoSarfWarsa.Location = new System.Drawing.Point(0, 0);
            this.gridControlTBLNoSarfWarsa.MainView = this.gridViewTBLNoSarfWarsa;
            this.gridControlTBLNoSarfWarsa.Name = "gridControlTBLNoSarfWarsa";
            this.gridControlTBLNoSarfWarsa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit2,
            this.repositoryItemButtonEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit3,
            this.repositoryItemLookUpEdit1});
            this.gridControlTBLNoSarfWarsa.Size = new System.Drawing.Size(773, 321);
            this.gridControlTBLNoSarfWarsa.TabIndex = 2;
            this.gridControlTBLNoSarfWarsa.UseEmbeddedNavigator = true;
            this.gridControlTBLNoSarfWarsa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTBLNoSarfWarsa});
            // 
            // tBLNoSarfWarsaBindingSource
            // 
            this.tBLNoSarfWarsaBindingSource.DataMember = "TBLNoSarfWarsa";
            this.tBLNoSarfWarsaBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewTBLNoSarfWarsa
            // 
            this.gridViewTBLNoSarfWarsa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldatehala,
            this.gridColumn2,
            this.colyasref1,
            this.coldatein1,
            this.coluserin1});
            this.gridViewTBLNoSarfWarsa.GridControl = this.gridControlTBLNoSarfWarsa;
            this.gridViewTBLNoSarfWarsa.Name = "gridViewTBLNoSarfWarsa";
            this.gridViewTBLNoSarfWarsa.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewTBLNoSarfWarsa.OptionsBehavior.Editable = false;
            this.gridViewTBLNoSarfWarsa.OptionsView.ColumnAutoWidth = false;
            this.gridViewTBLNoSarfWarsa.RowHeight = 32;
            // 
            // coldatehala
            // 
            this.coldatehala.AppearanceCell.Options.UseTextOptions = true;
            this.coldatehala.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatehala.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatehala.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatehala.Caption = "التاريخ";
            this.coldatehala.ColumnEdit = this.repositoryItemDateEdit1;
            this.coldatehala.FieldName = "datehala";
            this.coldatehala.Name = "coldatehala";
            this.coldatehala.Visible = true;
            this.coldatehala.VisibleIndex = 1;
            this.coldatehala.Width = 87;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "ملاحظات";
            this.gridColumn2.ColumnEdit = this.repositoryItemMemoEdit2;
            this.gridColumn2.FieldName = "halarem";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 382;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // colyasref1
            // 
            this.colyasref1.AppearanceCell.Options.UseTextOptions = true;
            this.colyasref1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref1.AppearanceHeader.Options.UseTextOptions = true;
            this.colyasref1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref1.Caption = "الصرف";
            this.colyasref1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colyasref1.FieldName = "yasref";
            this.colyasref1.Name = "colyasref1";
            this.colyasref1.Visible = true;
            this.colyasref1.VisibleIndex = 0;
            this.colyasref1.Width = 44;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // coldatein1
            // 
            this.coldatein1.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein1.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein1.Caption = "تاريخ الادخال";
            this.coldatein1.ColumnEdit = this.repositoryItemDateEdit3;
            this.coldatein1.FieldName = "datein";
            this.coldatein1.Name = "coldatein1";
            this.coldatein1.OptionsColumn.AllowEdit = false;
            this.coldatein1.OptionsColumn.ReadOnly = true;
            this.coldatein1.Visible = true;
            this.coldatein1.VisibleIndex = 3;
            this.coldatein1.Width = 100;
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.repositoryItemDateEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.EditFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.repositoryItemDateEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.Mask.EditMask = "dd/MM/yyyy - hh:mm:ss";
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            this.repositoryItemDateEdit3.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // coluserin1
            // 
            this.coluserin1.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin1.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin1.Caption = "مسئول الادخال";
            this.coluserin1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.coluserin1.FieldName = "userin";
            this.coluserin1.Name = "coluserin1";
            this.coluserin1.OptionsColumn.AllowEdit = false;
            this.coluserin1.OptionsColumn.ReadOnly = true;
            this.coluserin1.Visible = true;
            this.coluserin1.VisibleIndex = 4;
            this.coluserin1.Width = 139;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEdit1.DisplayMember = "RealName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "UserID";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // tBLNoSarfWarsaTableAdapter
            // 
            this.tBLNoSarfWarsaTableAdapter.ClearBeforeFill = true;
            // 
            // TBLNoSarfWarsaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 321);
            this.Controls.Add(this.gridControlTBLNoSarfWarsa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TBLNoSarfWarsaInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ملاحظات الصرف";
            this.Load += new System.EventHandler(this.TBLNoSarfWarsaInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTBLNoSarfWarsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLNoSarfWarsaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLNoSarfWarsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTBLNoSarfWarsa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTBLNoSarfWarsa;
        private DevExpress.XtraGrid.Columns.GridColumn coldatehala;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colyasref1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource tBLNoSarfWarsaBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.TBLNoSarfWarsaTableAdapter tBLNoSarfWarsaTableAdapter;
    }
}