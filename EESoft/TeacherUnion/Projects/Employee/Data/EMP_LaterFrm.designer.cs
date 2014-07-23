namespace Employee
{
    partial class EMP_LaterFrm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditEmpID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditlater_date = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEditTime = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDatein = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditEmpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditlater_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditlater_date.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEditTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDel,
            this.repositoryItemDateEditDatein,
            this.repositoryItemGridLookUpEditEmpID,
            this.repositoryItemDateEditlater_date,
            this.repositoryItemTimeEditTime});
            this.gridControlData.Size = new System.Drawing.Size(784, 362);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "اسم العامل";
            this.gridColumn1.ColumnEdit = this.repositoryItemGridLookUpEditEmpID;
            this.gridColumn1.FieldName = "EmpID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 171;
            // 
            // repositoryItemGridLookUpEditEmpID
            // 
            this.repositoryItemGridLookUpEditEmpID.AutoHeight = false;
            this.repositoryItemGridLookUpEditEmpID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditEmpID.Name = "repositoryItemGridLookUpEditEmpID";
            this.repositoryItemGridLookUpEditEmpID.NullText = "";
            this.repositoryItemGridLookUpEditEmpID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditEmpID.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "الاسم";
            this.gridColumn13.FieldName = "Emp_Name";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "التاريخ";
            this.gridColumn2.ColumnEdit = this.repositoryItemDateEditlater_date;
            this.gridColumn2.FieldName = "later_date";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 111;
            // 
            // repositoryItemDateEditlater_date
            // 
            this.repositoryItemDateEditlater_date.AutoHeight = false;
            this.repositoryItemDateEditlater_date.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditlater_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditlater_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditlater_date.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditlater_date.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditlater_date.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditlater_date.Name = "repositoryItemDateEditlater_date";
            this.repositoryItemDateEditlater_date.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "الوقت المقرر للحضور";
            this.gridColumn5.ColumnEdit = this.repositoryItemTimeEditTime;
            this.gridColumn5.FieldName = "timemokrr";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 145;
            // 
            // repositoryItemTimeEditTime
            // 
            this.repositoryItemTimeEditTime.AutoHeight = false;
            this.repositoryItemTimeEditTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEditTime.DisplayFormat.FormatString = "hh:mm:ss t";
            this.repositoryItemTimeEditTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTimeEditTime.EditFormat.FormatString = "hh:mm:ss t";
            this.repositoryItemTimeEditTime.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTimeEditTime.Mask.EditMask = "hh:mm:ss t";
            this.repositoryItemTimeEditTime.Name = "repositoryItemTimeEditTime";
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "الوقت الفعلي للحضور";
            this.gridColumn6.ColumnEdit = this.repositoryItemTimeEditTime;
            this.gridColumn6.FieldName = "timeattend";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 154;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "تاريخ الادخال";
            this.gridColumn8.ColumnEdit = this.repositoryItemDateEditDatein;
            this.gridColumn8.FieldName = "Datein";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemDateEditDatein
            // 
            this.repositoryItemDateEditDatein.AutoHeight = false;
            this.repositoryItemDateEditDatein.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDatein.DisplayFormat.FormatString = "u";
            this.repositoryItemDateEditDatein.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDatein.EditFormat.FormatString = "u";
            this.repositoryItemDateEditDatein.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDatein.Mask.EditMask = "u";
            this.repositoryItemDateEditDatein.Name = "repositoryItemDateEditDatein";
            this.repositoryItemDateEditDatein.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "مدخل البيانات";
            this.gridColumn9.FieldName = "Userin";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "حفظ";
            this.gridColumn3.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 71;
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
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "حذف";
            this.gridColumn4.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 70;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // EMP_LaterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.gridControlData);
            this.Name = "EMP_LaterFrm";
            this.Text = "التأخير";
            this.Load += new System.EventHandler(this.stu_nashatFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditEmpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditlater_date.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditlater_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEditTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDatein;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditEmpID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditlater_date;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEditTime;
    }
}