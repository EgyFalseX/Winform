namespace Training_Center
{
    partial class TBLMemberShipFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLMemberShipFrm));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCTrainerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTrainerID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCMembershipFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.GCMembershipTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCMembershipValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditClac = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.GCSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTrainerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditClac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
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
            this.repositoryItemGridLookUpEditTrainerID,
            this.repositoryItemCalcEditClac,
            this.repositoryItemDateEditDate});
            this.gridControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMain.Size = new System.Drawing.Size(660, 438);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCTrainerID,
            this.gridColumn3,
            this.GCMembershipFrom,
            this.GCMembershipTo,
            this.GCMembershipValue,
            this.GCSave,
            this.GCDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // GCTrainerID
            // 
            this.GCTrainerID.AppearanceCell.Options.UseTextOptions = true;
            this.GCTrainerID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTrainerID.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTrainerID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTrainerID.Caption = "اسم المدرب";
            this.GCTrainerID.ColumnEdit = this.repositoryItemGridLookUpEditTrainerID;
            this.GCTrainerID.FieldName = "TrainerID";
            this.GCTrainerID.Name = "GCTrainerID";
            this.GCTrainerID.Visible = true;
            this.GCTrainerID.VisibleIndex = 0;
            this.GCTrainerID.Width = 173;
            // 
            // repositoryItemGridLookUpEditTrainerID
            // 
            this.repositoryItemGridLookUpEditTrainerID.AutoHeight = false;
            this.repositoryItemGridLookUpEditTrainerID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditTrainerID.Name = "repositoryItemGridLookUpEditTrainerID";
            this.repositoryItemGridLookUpEditTrainerID.NullText = "";
            this.repositoryItemGridLookUpEditTrainerID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditTrainerID.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "كود";
            this.gridColumn2.FieldName = "TrainerID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "TrainerName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // GCMembershipFrom
            // 
            this.GCMembershipFrom.AppearanceCell.Options.UseTextOptions = true;
            this.GCMembershipFrom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMembershipFrom.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMembershipFrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMembershipFrom.Caption = "بداية العضوية";
            this.GCMembershipFrom.ColumnEdit = this.repositoryItemDateEditDate;
            this.GCMembershipFrom.FieldName = "MembershipFrom";
            this.GCMembershipFrom.Name = "GCMembershipFrom";
            this.GCMembershipFrom.Visible = true;
            this.GCMembershipFrom.VisibleIndex = 2;
            this.GCMembershipFrom.Width = 125;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // GCMembershipTo
            // 
            this.GCMembershipTo.AppearanceCell.Options.UseTextOptions = true;
            this.GCMembershipTo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMembershipTo.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMembershipTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMembershipTo.Caption = "نهاية العضوية";
            this.GCMembershipTo.ColumnEdit = this.repositoryItemDateEditDate;
            this.GCMembershipTo.FieldName = "MembershipTo";
            this.GCMembershipTo.Name = "GCMembershipTo";
            this.GCMembershipTo.Visible = true;
            this.GCMembershipTo.VisibleIndex = 3;
            this.GCMembershipTo.Width = 101;
            // 
            // GCMembershipValue
            // 
            this.GCMembershipValue.AppearanceCell.Options.UseTextOptions = true;
            this.GCMembershipValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMembershipValue.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMembershipValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMembershipValue.Caption = "قيمة العضوية";
            this.GCMembershipValue.ColumnEdit = this.repositoryItemCalcEditClac;
            this.GCMembershipValue.FieldName = "MembershipValue";
            this.GCMembershipValue.Name = "GCMembershipValue";
            this.GCMembershipValue.Visible = true;
            this.GCMembershipValue.VisibleIndex = 4;
            this.GCMembershipValue.Width = 79;
            // 
            // repositoryItemCalcEditClac
            // 
            this.repositoryItemCalcEditClac.AutoHeight = false;
            this.repositoryItemCalcEditClac.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditClac.DisplayFormat.FormatString = "f2";
            this.repositoryItemCalcEditClac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditClac.EditFormat.FormatString = "f2";
            this.repositoryItemCalcEditClac.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditClac.Mask.EditMask = "f2";
            this.repositoryItemCalcEditClac.Name = "repositoryItemCalcEditClac";
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
            this.GCSave.VisibleIndex = 5;
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
            this.GCDelete.VisibleIndex = 6;
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
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "نوع العضويه";
            this.gridColumn3.FieldName = "MembershipType";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 117;
            // 
            // TBLMemberShipFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLMemberShipFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عضوية الاكاديمية";
            this.Load += new System.EventHandler(this.FrmCdBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTrainerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditClac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn GCTrainerID;
        private DevExpress.XtraGrid.Columns.GridColumn GCSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCMembershipFrom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn GCMembershipTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditClac;
        private DevExpress.XtraGrid.Columns.GridColumn GCMembershipValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTrainerID;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}