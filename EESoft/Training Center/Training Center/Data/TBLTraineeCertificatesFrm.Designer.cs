namespace Training_Center
{
    partial class TBLTraineeCertificatesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLTraineeCertificatesFrm));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCTraineeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTraineeID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCCourseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCourseId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCCertificateID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCertificateID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCReceiptDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.GCCertificateValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditClac = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.GCSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCUniqueNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTraineeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCourseId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCertificateID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.repositoryItemGridLookUpEditTraineeID,
            this.repositoryItemGridLookUpEditCourseId,
            this.repositoryItemGridLookUpEditCertificateID,
            this.repositoryItemCalcEditClac,
            this.repositoryItemDateEditDate});
            this.gridControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMain.Size = new System.Drawing.Size(760, 438);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCTraineeID,
            this.GCCourseId,
            this.GCCertificateID,
            this.GCReceiptDate,
            this.GCCertificateValue,
            this.GCUniqueNo,
            this.GCSave,
            this.GCDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // GCTraineeID
            // 
            this.GCTraineeID.AppearanceCell.Options.UseTextOptions = true;
            this.GCTraineeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTraineeID.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTraineeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTraineeID.Caption = "اسم المتدرب";
            this.GCTraineeID.ColumnEdit = this.repositoryItemGridLookUpEditTraineeID;
            this.GCTraineeID.FieldName = "TraineeID";
            this.GCTraineeID.Name = "GCTraineeID";
            this.GCTraineeID.Visible = true;
            this.GCTraineeID.VisibleIndex = 0;
            this.GCTraineeID.Width = 175;
            // 
            // repositoryItemGridLookUpEditTraineeID
            // 
            this.repositoryItemGridLookUpEditTraineeID.AutoHeight = false;
            this.repositoryItemGridLookUpEditTraineeID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditTraineeID.Name = "repositoryItemGridLookUpEditTraineeID";
            this.repositoryItemGridLookUpEditTraineeID.NullText = "";
            this.repositoryItemGridLookUpEditTraineeID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditTraineeID.View = this.gridView1;
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
            this.gridColumn1.FieldName = "TraineeName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // GCCourseId
            // 
            this.GCCourseId.AppearanceCell.Options.UseTextOptions = true;
            this.GCCourseId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCourseId.AppearanceHeader.Options.UseTextOptions = true;
            this.GCCourseId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCourseId.Caption = "الدورة التدريبية";
            this.GCCourseId.ColumnEdit = this.repositoryItemGridLookUpEditCourseId;
            this.GCCourseId.FieldName = "CourseId";
            this.GCCourseId.Name = "GCCourseId";
            this.GCCourseId.Visible = true;
            this.GCCourseId.VisibleIndex = 1;
            this.GCCourseId.Width = 137;
            // 
            // repositoryItemGridLookUpEditCourseId
            // 
            this.repositoryItemGridLookUpEditCourseId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCourseId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCourseId.Name = "repositoryItemGridLookUpEditCourseId";
            this.repositoryItemGridLookUpEditCourseId.NullText = "";
            this.repositoryItemGridLookUpEditCourseId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCourseId.View = this.gridView2;
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
            this.gridColumn2.FieldName = "CourseName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // GCCertificateID
            // 
            this.GCCertificateID.AppearanceCell.Options.UseTextOptions = true;
            this.GCCertificateID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCertificateID.AppearanceHeader.Options.UseTextOptions = true;
            this.GCCertificateID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCertificateID.Caption = "الشهاده";
            this.GCCertificateID.ColumnEdit = this.repositoryItemGridLookUpEditCertificateID;
            this.GCCertificateID.FieldName = "CertificateID";
            this.GCCertificateID.Name = "GCCertificateID";
            this.GCCertificateID.Visible = true;
            this.GCCertificateID.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEditCertificateID
            // 
            this.repositoryItemGridLookUpEditCertificateID.AutoHeight = false;
            this.repositoryItemGridLookUpEditCertificateID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCertificateID.Name = "repositoryItemGridLookUpEditCertificateID";
            this.repositoryItemGridLookUpEditCertificateID.NullText = "";
            this.repositoryItemGridLookUpEditCertificateID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCertificateID.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "الاسم";
            this.gridColumn3.FieldName = "Certificate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // GCReceiptDate
            // 
            this.GCReceiptDate.AppearanceCell.Options.UseTextOptions = true;
            this.GCReceiptDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCReceiptDate.AppearanceHeader.Options.UseTextOptions = true;
            this.GCReceiptDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCReceiptDate.Caption = "التاريخ";
            this.GCReceiptDate.ColumnEdit = this.repositoryItemDateEditDate;
            this.GCReceiptDate.FieldName = "ReceiptDate";
            this.GCReceiptDate.Name = "GCReceiptDate";
            this.GCReceiptDate.Visible = true;
            this.GCReceiptDate.VisibleIndex = 3;
            this.GCReceiptDate.Width = 77;
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
            // GCCertificateValue
            // 
            this.GCCertificateValue.AppearanceCell.Options.UseTextOptions = true;
            this.GCCertificateValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCertificateValue.AppearanceHeader.Options.UseTextOptions = true;
            this.GCCertificateValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCertificateValue.Caption = "قيمة الشهادة";
            this.GCCertificateValue.ColumnEdit = this.repositoryItemCalcEditClac;
            this.GCCertificateValue.FieldName = "CertificateValue";
            this.GCCertificateValue.Name = "GCCertificateValue";
            this.GCCertificateValue.Visible = true;
            this.GCCertificateValue.VisibleIndex = 4;
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
            this.GCSave.VisibleIndex = 6;
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
            this.GCDelete.VisibleIndex = 7;
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
            // GCUniqueNo
            // 
            this.GCUniqueNo.AppearanceCell.Options.UseTextOptions = true;
            this.GCUniqueNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCUniqueNo.AppearanceHeader.Options.UseTextOptions = true;
            this.GCUniqueNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCUniqueNo.Caption = "رقم الشهادة";
            this.GCUniqueNo.FieldName = "UniqueNo";
            this.GCUniqueNo.Name = "GCUniqueNo";
            this.GCUniqueNo.OptionsColumn.AllowEdit = false;
            this.GCUniqueNo.OptionsColumn.ReadOnly = true;
            this.GCUniqueNo.Visible = true;
            this.GCUniqueNo.VisibleIndex = 5;
            // 
            // TBLTraineeCertificatesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLTraineeCertificatesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شهادات المتدربين";
            this.Load += new System.EventHandler(this.FrmCdBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTraineeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCourseId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCertificateID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn GCTraineeID;
        private DevExpress.XtraGrid.Columns.GridColumn GCSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCCourseId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTraineeID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCourseId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCertificateID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn GCReceiptDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditClac;
        private DevExpress.XtraGrid.Columns.GridColumn GCCertificateValue;
        private DevExpress.XtraGrid.Columns.GridColumn GCCertificateID;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCUniqueNo;
    }
}