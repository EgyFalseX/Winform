namespace Training_Center
{
    partial class TblAlkaznaFrm
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
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCActionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditActionId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCHarakaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.GCAmony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditClac = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.GCNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditNotes = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.GCAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditAccountID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCClosek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditClosek = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GCSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditActionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditClac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditAccountID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditClosek)).BeginInit();
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
            this.repositoryItemGridLookUpEditActionId,
            this.repositoryItemCalcEditClac,
            this.repositoryItemGridLookUpEditAccountID,
            this.repositoryItemDateEditDate,
            this.repositoryItemMemoExEditNotes,
            this.repositoryItemCheckEditClosek});
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
            this.GCActionId,
            this.GCHarakaNo,
            this.GCActionDate,
            this.GCAmony,
            this.GCAccountId,
            this.GCNotes,
            this.GCClosek,
            this.GCSave,
            this.GCDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // GCActionId
            // 
            this.GCActionId.AppearanceCell.Options.UseTextOptions = true;
            this.GCActionId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCActionId.AppearanceHeader.Options.UseTextOptions = true;
            this.GCActionId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCActionId.Caption = "نوع الحركه";
            this.GCActionId.ColumnEdit = this.repositoryItemGridLookUpEditActionId;
            this.GCActionId.FieldName = "ActionId";
            this.GCActionId.Name = "GCActionId";
            this.GCActionId.Visible = true;
            this.GCActionId.VisibleIndex = 0;
            this.GCActionId.Width = 180;
            // 
            // repositoryItemGridLookUpEditActionId
            // 
            this.repositoryItemGridLookUpEditActionId.AutoHeight = false;
            this.repositoryItemGridLookUpEditActionId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditActionId.Name = "repositoryItemGridLookUpEditActionId";
            this.repositoryItemGridLookUpEditActionId.NullText = "";
            this.repositoryItemGridLookUpEditActionId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditActionId.View = this.gridView1;
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
            this.gridColumn1.FieldName = "action_name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // GCHarakaNo
            // 
            this.GCHarakaNo.AppearanceCell.Options.UseTextOptions = true;
            this.GCHarakaNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHarakaNo.AppearanceHeader.Options.UseTextOptions = true;
            this.GCHarakaNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHarakaNo.Caption = "رقم الحركه";
            this.GCHarakaNo.FieldName = "HarakaNo";
            this.GCHarakaNo.Name = "GCHarakaNo";
            this.GCHarakaNo.OptionsColumn.ReadOnly = true;
            this.GCHarakaNo.Visible = true;
            this.GCHarakaNo.VisibleIndex = 1;
            this.GCHarakaNo.Width = 139;
            // 
            // GCActionDate
            // 
            this.GCActionDate.AppearanceCell.Options.UseTextOptions = true;
            this.GCActionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCActionDate.AppearanceHeader.Options.UseTextOptions = true;
            this.GCActionDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCActionDate.Caption = "التاريخ";
            this.GCActionDate.ColumnEdit = this.repositoryItemDateEditDate;
            this.GCActionDate.FieldName = "ActionDate";
            this.GCActionDate.Name = "GCActionDate";
            this.GCActionDate.Visible = true;
            this.GCActionDate.VisibleIndex = 2;
            this.GCActionDate.Width = 85;
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
            // GCAmony
            // 
            this.GCAmony.AppearanceCell.Options.UseTextOptions = true;
            this.GCAmony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAmony.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAmony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAmony.Caption = "المبلغ";
            this.GCAmony.ColumnEdit = this.repositoryItemCalcEditClac;
            this.GCAmony.FieldName = "Amony";
            this.GCAmony.Name = "GCAmony";
            this.GCAmony.Visible = true;
            this.GCAmony.VisibleIndex = 3;
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
            // GCNotes
            // 
            this.GCNotes.AppearanceCell.Options.UseTextOptions = true;
            this.GCNotes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCNotes.AppearanceHeader.Options.UseTextOptions = true;
            this.GCNotes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCNotes.Caption = "البيان";
            this.GCNotes.ColumnEdit = this.repositoryItemMemoExEditNotes;
            this.GCNotes.FieldName = "Notes";
            this.GCNotes.Name = "GCNotes";
            this.GCNotes.Visible = true;
            this.GCNotes.VisibleIndex = 5;
            // 
            // repositoryItemMemoExEditNotes
            // 
            this.repositoryItemMemoExEditNotes.AutoHeight = false;
            this.repositoryItemMemoExEditNotes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditNotes.Name = "repositoryItemMemoExEditNotes";
            // 
            // GCAccountId
            // 
            this.GCAccountId.AppearanceCell.Options.UseTextOptions = true;
            this.GCAccountId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAccountId.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAccountId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAccountId.Caption = "الحساب";
            this.GCAccountId.ColumnEdit = this.repositoryItemGridLookUpEditAccountID;
            this.GCAccountId.FieldName = "AccountId";
            this.GCAccountId.Name = "GCAccountId";
            this.GCAccountId.Visible = true;
            this.GCAccountId.VisibleIndex = 4;
            this.GCAccountId.Width = 107;
            // 
            // repositoryItemGridLookUpEditAccountID
            // 
            this.repositoryItemGridLookUpEditAccountID.AutoHeight = false;
            this.repositoryItemGridLookUpEditAccountID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemGridLookUpEditAccountID.Name = "repositoryItemGridLookUpEditAccountID";
            this.repositoryItemGridLookUpEditAccountID.NullText = "";
            this.repositoryItemGridLookUpEditAccountID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditAccountID.View = this.gridView4;
            this.repositoryItemGridLookUpEditAccountID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemGridLookUpEditAccountID_ButtonClick);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn2});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "الرقم الشجري";
            this.gridColumn4.FieldName = "AccountTreeId";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "تعليق";
            this.gridColumn2.FieldName = "AccountDes";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // GCClosek
            // 
            this.GCClosek.AppearanceCell.Options.UseTextOptions = true;
            this.GCClosek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCClosek.AppearanceHeader.Options.UseTextOptions = true;
            this.GCClosek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCClosek.Caption = "اغلاق القيد";
            this.GCClosek.ColumnEdit = this.repositoryItemCheckEditClosek;
            this.GCClosek.FieldName = "Closek";
            this.GCClosek.Name = "GCClosek";
            this.GCClosek.Visible = true;
            this.GCClosek.VisibleIndex = 6;
            this.GCClosek.Width = 87;
            // 
            // repositoryItemCheckEditClosek
            // 
            this.repositoryItemCheckEditClosek.AutoHeight = false;
            this.repositoryItemCheckEditClosek.Name = "repositoryItemCheckEditClosek";
            this.repositoryItemCheckEditClosek.ValueGrayed = false;
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
            // TblAlkaznaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.gridControlMain);
            this.Name = "TblAlkaznaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حركة الخزينة";
            this.Load += new System.EventHandler(this.FrmCdBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditActionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditClac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditAccountID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditClosek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn GCActionId;
        private DevExpress.XtraGrid.Columns.GridColumn GCAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn GCSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCHarakaNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditActionId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn GCActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCAmony;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditClac;
        private DevExpress.XtraGrid.Columns.GridColumn GCClosek;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditAccountID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn GCNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditClosek;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}