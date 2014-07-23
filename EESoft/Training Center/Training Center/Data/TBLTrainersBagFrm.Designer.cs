namespace Training_Center
{
    partial class TBLTrainersBagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLTrainersBagFrm));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCTrainerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTrainerID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTrainingBagId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTrainingBagId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCDateAdoption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.GCAdoptionValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditClac = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.GCAdoption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditAdoption = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GCSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCAdoptionRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditAdoptionRemark = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.GCAdoptionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTrainerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTrainingBagId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditClac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditAdoption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditAdoptionRemark)).BeginInit();
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
            this.repositoryItemGridLookUpEditTrainingBagId,
            this.repositoryItemCalcEditClac,
            this.repositoryItemCheckEditAdoption,
            this.repositoryItemMemoExEditAdoptionRemark,
            this.repositoryItemDateEditDate});
            this.gridControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMain.Size = new System.Drawing.Size(860, 438);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCTrainerID,
            this.GCTrainingBagId,
            this.GCDateAdoption,
            this.GCAdoptionValue,
            this.GCAdoption,
            this.GCAdoptionRemark,
            this.GCAdoptionNo,
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
            this.GCTrainerID.Width = 175;
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
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "TrainerName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // GCTrainingBagId
            // 
            this.GCTrainingBagId.AppearanceCell.Options.UseTextOptions = true;
            this.GCTrainingBagId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTrainingBagId.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTrainingBagId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTrainingBagId.Caption = "الحقيبه";
            this.GCTrainingBagId.ColumnEdit = this.repositoryItemGridLookUpEditTrainingBagId;
            this.GCTrainingBagId.FieldName = "TrainingBagId";
            this.GCTrainingBagId.Name = "GCTrainingBagId";
            this.GCTrainingBagId.Visible = true;
            this.GCTrainingBagId.VisibleIndex = 1;
            this.GCTrainingBagId.Width = 137;
            // 
            // repositoryItemGridLookUpEditTrainingBagId
            // 
            this.repositoryItemGridLookUpEditTrainingBagId.AutoHeight = false;
            this.repositoryItemGridLookUpEditTrainingBagId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditTrainingBagId.Name = "repositoryItemGridLookUpEditTrainingBagId";
            this.repositoryItemGridLookUpEditTrainingBagId.NullText = "";
            this.repositoryItemGridLookUpEditTrainingBagId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditTrainingBagId.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "الاسم";
            this.gridColumn2.FieldName = "TrainingBag";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // GCDateAdoption
            // 
            this.GCDateAdoption.AppearanceCell.Options.UseTextOptions = true;
            this.GCDateAdoption.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCDateAdoption.AppearanceHeader.Options.UseTextOptions = true;
            this.GCDateAdoption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCDateAdoption.Caption = "التاريخ";
            this.GCDateAdoption.ColumnEdit = this.repositoryItemDateEditDate;
            this.GCDateAdoption.FieldName = "DateAdoption";
            this.GCDateAdoption.Name = "GCDateAdoption";
            this.GCDateAdoption.Visible = true;
            this.GCDateAdoption.VisibleIndex = 3;
            this.GCDateAdoption.Width = 77;
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
            // GCAdoptionValue
            // 
            this.GCAdoptionValue.AppearanceCell.Options.UseTextOptions = true;
            this.GCAdoptionValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAdoptionValue.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAdoptionValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAdoptionValue.Caption = "القيمه";
            this.GCAdoptionValue.ColumnEdit = this.repositoryItemCalcEditClac;
            this.GCAdoptionValue.FieldName = "AdoptionValue";
            this.GCAdoptionValue.Name = "GCAdoptionValue";
            this.GCAdoptionValue.Visible = true;
            this.GCAdoptionValue.VisibleIndex = 4;
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
            // GCAdoption
            // 
            this.GCAdoption.AppearanceCell.Options.UseTextOptions = true;
            this.GCAdoption.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAdoption.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAdoption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAdoption.Caption = "تم اعتمادها";
            this.GCAdoption.ColumnEdit = this.repositoryItemCheckEditAdoption;
            this.GCAdoption.FieldName = "Adoption";
            this.GCAdoption.Name = "GCAdoption";
            this.GCAdoption.Visible = true;
            this.GCAdoption.VisibleIndex = 2;
            // 
            // repositoryItemCheckEditAdoption
            // 
            this.repositoryItemCheckEditAdoption.AutoHeight = false;
            this.repositoryItemCheckEditAdoption.Name = "repositoryItemCheckEditAdoption";
            this.repositoryItemCheckEditAdoption.ValueGrayed = false;
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
            this.GCSave.VisibleIndex = 7;
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
            this.GCDelete.VisibleIndex = 8;
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
            // GCAdoptionRemark
            // 
            this.GCAdoptionRemark.AppearanceCell.Options.UseTextOptions = true;
            this.GCAdoptionRemark.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAdoptionRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAdoptionRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAdoptionRemark.Caption = "ملاحظات";
            this.GCAdoptionRemark.ColumnEdit = this.repositoryItemMemoExEditAdoptionRemark;
            this.GCAdoptionRemark.FieldName = "AdoptionRemark";
            this.GCAdoptionRemark.Name = "GCAdoptionRemark";
            this.GCAdoptionRemark.Visible = true;
            this.GCAdoptionRemark.VisibleIndex = 5;
            // 
            // repositoryItemMemoExEditAdoptionRemark
            // 
            this.repositoryItemMemoExEditAdoptionRemark.AutoHeight = false;
            this.repositoryItemMemoExEditAdoptionRemark.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditAdoptionRemark.Name = "repositoryItemMemoExEditAdoptionRemark";
            // 
            // GCAdoptionNo
            // 
            this.GCAdoptionNo.AppearanceCell.Options.UseTextOptions = true;
            this.GCAdoptionNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAdoptionNo.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAdoptionNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAdoptionNo.Caption = "رقم الاعتماد";
            this.GCAdoptionNo.FieldName = "AdoptionNo";
            this.GCAdoptionNo.Name = "GCAdoptionNo";
            this.GCAdoptionNo.OptionsColumn.AllowEdit = false;
            this.GCAdoptionNo.OptionsColumn.ReadOnly = true;
            this.GCAdoptionNo.Visible = true;
            this.GCAdoptionNo.VisibleIndex = 6;
            // 
            // TBLTrainersBagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLTrainersBagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حقائب المدربين";
            this.Load += new System.EventHandler(this.FrmCdBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTrainerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTrainingBagId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditClac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditAdoption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditAdoptionRemark)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn GCTrainingBagId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTrainingBagId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn GCDateAdoption;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditClac;
        private DevExpress.XtraGrid.Columns.GridColumn GCAdoptionValue;
        private DevExpress.XtraGrid.Columns.GridColumn GCAdoption;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTrainerID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditAdoption;
        private DevExpress.XtraGrid.Columns.GridColumn GCAdoptionRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditAdoptionRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCAdoptionNo;
    }
}