namespace RealEstate    
{
    partial class CdperiodFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CdperiodFrm));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCPeriodId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCmonths = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditmonths = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditmonths)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(12, 12);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDelete,
            this.repositoryItemCalcEditmonths});
            this.gridControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMain.Size = new System.Drawing.Size(560, 438);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCPeriodId,
            this.GCPeriod,
            this.GCmonths,
            this.GCSave,
            this.GCDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // GCPeriodId
            // 
            this.GCPeriodId.AppearanceCell.Options.UseTextOptions = true;
            this.GCPeriodId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPeriodId.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPeriodId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPeriodId.Caption = "كود المدة";
            this.GCPeriodId.FieldName = "PeriodId";
            this.GCPeriodId.Name = "GCPeriodId";
            this.GCPeriodId.OptionsColumn.AllowEdit = false;
            this.GCPeriodId.OptionsColumn.ReadOnly = true;
            this.GCPeriodId.Visible = true;
            this.GCPeriodId.VisibleIndex = 2;
            // 
            // GCPeriod
            // 
            this.GCPeriod.AppearanceCell.Options.UseTextOptions = true;
            this.GCPeriod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPeriod.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPeriod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPeriod.Caption = "مدة الإيجار";
            this.GCPeriod.FieldName = "Period";
            this.GCPeriod.Name = "GCPeriod";
            this.GCPeriod.Visible = true;
            this.GCPeriod.VisibleIndex = 0;
            this.GCPeriod.Width = 285;
            // 
            // GCSave
            // 
            this.GCSave.AppearanceCell.Options.UseTextOptions = true;
            this.GCSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSave.AppearanceHeader.Options.UseTextOptions = true;
            this.GCSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSave.Caption = "حفظ";
            this.GCSave.ColumnEdit = this.repositoryItemButtonEditSave;
            this.GCSave.Name = "GCSave";
            this.GCSave.Visible = true;
            this.GCSave.VisibleIndex = 3;
            this.GCSave.Width = 79;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSave_ButtonClick);
            // 
            // GCDelete
            // 
            this.GCDelete.AppearanceCell.Options.UseTextOptions = true;
            this.GCDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.GCDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCDelete.Caption = "حذف";
            this.GCDelete.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.GCDelete.Name = "GCDelete";
            this.GCDelete.Visible = true;
            this.GCDelete.VisibleIndex = 4;
            this.GCDelete.Width = 81;
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
            // GCmonths
            // 
            this.GCmonths.AppearanceCell.Options.UseTextOptions = true;
            this.GCmonths.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCmonths.AppearanceHeader.Options.UseTextOptions = true;
            this.GCmonths.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCmonths.Caption = "عدد الشهور";
            this.GCmonths.ColumnEdit = this.repositoryItemCalcEditmonths;
            this.GCmonths.FieldName = "months";
            this.GCmonths.Name = "GCmonths";
            this.GCmonths.Visible = true;
            this.GCmonths.VisibleIndex = 1;
            // 
            // repositoryItemCalcEditmonths
            // 
            this.repositoryItemCalcEditmonths.AutoHeight = false;
            this.repositoryItemCalcEditmonths.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditmonths.DisplayFormat.FormatString = "n0";
            this.repositoryItemCalcEditmonths.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditmonths.EditFormat.FormatString = "n0";
            this.repositoryItemCalcEditmonths.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditmonths.Mask.EditMask = "n0";
            this.repositoryItemCalcEditmonths.Name = "repositoryItemCalcEditmonths";
            // 
            // CdperiodFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CdperiodFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدد الايجار";
            this.Load += new System.EventHandler(this.FrmCdBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditmonths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn GCPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn GCSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCPeriodId;
        private DevExpress.XtraGrid.Columns.GridColumn GCmonths;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditmonths;
    }
}