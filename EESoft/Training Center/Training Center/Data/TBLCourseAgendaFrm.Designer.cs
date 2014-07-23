namespace Training_Center
{
    partial class TBLCourseAgendaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLCourseAgendaFrm));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCCourseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCourseId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCADate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.GCTimeFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.GCTimeTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCsubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditsubject = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.GCSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemTimeEditTime = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCourseId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditsubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEditTime)).BeginInit();
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
            this.repositoryItemGridLookUpEditCourseId,
            this.repositoryItemTimeEditTime,
            this.repositoryItemMemoExEditsubject,
            this.repositoryItemDateEditDate,
            this.repositoryItemTimeEdit1});
            this.gridControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMain.Size = new System.Drawing.Size(610, 438);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCCourseId,
            this.GCADate,
            this.GCTimeFrom,
            this.GCTimeTo,
            this.GCsubject,
            this.GCSave,
            this.GCDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
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
            this.GCCourseId.VisibleIndex = 0;
            this.GCCourseId.Width = 139;
            // 
            // repositoryItemGridLookUpEditCourseId
            // 
            this.repositoryItemGridLookUpEditCourseId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCourseId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCourseId.Name = "repositoryItemGridLookUpEditCourseId";
            this.repositoryItemGridLookUpEditCourseId.NullText = "";
            this.repositoryItemGridLookUpEditCourseId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCourseId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "الاسم";
            this.gridColumn4.FieldName = "CourseName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // GCADate
            // 
            this.GCADate.AppearanceCell.Options.UseTextOptions = true;
            this.GCADate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCADate.AppearanceHeader.Options.UseTextOptions = true;
            this.GCADate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCADate.Caption = "التاريخ";
            this.GCADate.ColumnEdit = this.repositoryItemDateEditDate;
            this.GCADate.FieldName = "ADate";
            this.GCADate.Name = "GCADate";
            this.GCADate.Visible = true;
            this.GCADate.VisibleIndex = 1;
            this.GCADate.Width = 180;
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
            // GCTimeFrom
            // 
            this.GCTimeFrom.AppearanceCell.Options.UseTextOptions = true;
            this.GCTimeFrom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTimeFrom.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTimeFrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTimeFrom.Caption = "من";
            this.GCTimeFrom.ColumnEdit = this.repositoryItemTimeEdit1;
            this.GCTimeFrom.FieldName = "TimeFrom";
            this.GCTimeFrom.Name = "GCTimeFrom";
            this.GCTimeFrom.Visible = true;
            this.GCTimeFrom.VisibleIndex = 2;
            this.GCTimeFrom.Width = 118;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.HideSelection = false;
            this.repositoryItemTimeEdit1.Mask.EditMask = "hh:mm:ss tt";
            this.repositoryItemTimeEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // GCTimeTo
            // 
            this.GCTimeTo.AppearanceCell.Options.UseTextOptions = true;
            this.GCTimeTo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTimeTo.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTimeTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTimeTo.Caption = "الي";
            this.GCTimeTo.ColumnEdit = this.repositoryItemTimeEdit1;
            this.GCTimeTo.FieldName = "TimeTo";
            this.GCTimeTo.Name = "GCTimeTo";
            this.GCTimeTo.Visible = true;
            this.GCTimeTo.VisibleIndex = 3;
            this.GCTimeTo.Width = 109;
            // 
            // GCsubject
            // 
            this.GCsubject.AppearanceCell.Options.UseTextOptions = true;
            this.GCsubject.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCsubject.AppearanceHeader.Options.UseTextOptions = true;
            this.GCsubject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCsubject.Caption = "الموضوع";
            this.GCsubject.ColumnEdit = this.repositoryItemMemoExEditsubject;
            this.GCsubject.FieldName = "subject";
            this.GCsubject.Name = "GCsubject";
            this.GCsubject.Visible = true;
            this.GCsubject.VisibleIndex = 4;
            // 
            // repositoryItemMemoExEditsubject
            // 
            this.repositoryItemMemoExEditsubject.AutoHeight = false;
            this.repositoryItemMemoExEditsubject.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditsubject.Name = "repositoryItemMemoExEditsubject";
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
            // repositoryItemTimeEditTime
            // 
            this.repositoryItemTimeEditTime.AutoHeight = false;
            this.repositoryItemTimeEditTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEditTime.Name = "repositoryItemTimeEditTime";
            // 
            // TBLCourseAgendaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLCourseAgendaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اجندة الدورة التدريبية";
            this.Load += new System.EventHandler(this.FrmCdBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCourseId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditsubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEditTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn GCADate;
        private DevExpress.XtraGrid.Columns.GridColumn GCTimeFrom;
        private DevExpress.XtraGrid.Columns.GridColumn GCSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCCourseId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCourseId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn GCTimeTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEditTime;
        private DevExpress.XtraGrid.Columns.GridColumn GCsubject;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditsubject;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
    }
}