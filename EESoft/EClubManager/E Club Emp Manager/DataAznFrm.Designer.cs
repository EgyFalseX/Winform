namespace E_Club_Emp_Manager
{
    partial class DataAznFrm
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageAdding = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TECEnd = new DevExpress.XtraEditors.TimeEdit();
            this.TECStart = new DevExpress.XtraEditors.TimeEdit();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.MemoTxt = new DevExpress.XtraEditors.MemoEdit();
            this.DEDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LUEEznType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LUEEmp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageEditing = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlAzn = new DevExpress.XtraGrid.GridControl();
            this.gridViewAzn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCEmp_Full_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCezn_type_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCezn_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCezn_time_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCezn_time_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCezn_place = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TECEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEznType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).BeginInit();
            this.xtraTabPageEditing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAzn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAzn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 8);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageAdding;
            this.xtraTabControl1.Size = new System.Drawing.Size(665, 291);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageAdding,
            this.xtraTabPageEditing});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPageAdding
            // 
            this.xtraTabPageAdding.Controls.Add(this.groupControl1);
            this.xtraTabPageAdding.Name = "xtraTabPageAdding";
            this.xtraTabPageAdding.Size = new System.Drawing.Size(658, 262);
            this.xtraTabPageAdding.Text = "اضافه";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Controls.Add(this.TECEnd);
            this.groupControl1.Controls.Add(this.TECStart);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.MemoTxt);
            this.groupControl1.Controls.Add(this.DEDate);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.LUEEznType);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.LUEEmp);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(165, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(328, 256);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "اضافه اذن للموظف";
            // 
            // TECEnd
            // 
            this.TECEnd.EditValue = new System.DateTime(((long)(0)));
            this.TECEnd.Location = new System.Drawing.Point(123, 125);
            this.TECEnd.Name = "TECEnd";
            this.TECEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TECEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TECEnd.Properties.DisplayFormat.FormatString = "t";
            this.TECEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TECEnd.Properties.EditFormat.FormatString = "t";
            this.TECEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TECEnd.Properties.Mask.EditMask = "t";
            this.TECEnd.Size = new System.Drawing.Size(111, 20);
            this.TECEnd.TabIndex = 4;
            // 
            // TECStart
            // 
            this.TECStart.EditValue = new System.DateTime(((long)(0)));
            this.TECStart.Location = new System.Drawing.Point(123, 99);
            this.TECStart.Name = "TECStart";
            this.TECStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TECStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TECStart.Properties.DisplayFormat.FormatString = "t";
            this.TECStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TECStart.Properties.EditFormat.FormatString = "t";
            this.TECStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TECStart.Properties.Mask.EditMask = "t";
            this.TECStart.Size = new System.Drawing.Size(111, 20);
            this.TECStart.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(123, 226);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "اضافه";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MemoTxt
            // 
            this.MemoTxt.Location = new System.Drawing.Point(3, 151);
            this.MemoTxt.Name = "MemoTxt";
            this.MemoTxt.Properties.MaxLength = 200;
            this.MemoTxt.Properties.NullValuePrompt = "اضق ملاحظه";
            this.MemoTxt.Size = new System.Drawing.Size(232, 69);
            this.MemoTxt.TabIndex = 5;
            // 
            // DEDate
            // 
            this.DEDate.EditValue = null;
            this.DEDate.Location = new System.Drawing.Point(62, 74);
            this.DEDate.Name = "DEDate";
            this.DEDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.DEDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.DEDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.DEDate.Properties.NullValuePrompt = "اختار تاريخ";
            this.DEDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DEDate.Size = new System.Drawing.Size(173, 19);
            this.DEDate.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(260, 128);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "وقت العوده";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(267, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Tag = "";
            this.labelControl5.Text = "ملاحظـــات";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(243, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "وقت الاستأذان";
            // 
            // LUEEznType
            // 
            this.LUEEznType.Location = new System.Drawing.Point(62, 49);
            this.LUEEznType.Name = "LUEEznType";
            this.LUEEznType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEznType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ezn_type_name", "اسم نوع الاذن")});
            this.LUEEznType.Properties.NullText = "";
            this.LUEEznType.Properties.NullValuePrompt = "اختار";
            this.LUEEznType.Size = new System.Drawing.Size(173, 19);
            this.LUEEznType.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(241, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تاريخ البدايه";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(272, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "نوع الاذن";
            // 
            // LUEEmp
            // 
            this.LUEEmp.Location = new System.Drawing.Point(62, 24);
            this.LUEEmp.Name = "LUEEmp";
            this.LUEEmp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEmp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpID", "رقم الموظف"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Emp_Full_Name", "اسم الموظف"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PHONE_NO", "تليفون"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MOBILE_NO", "موبيل"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("job", "الوظيفه")});
            this.LUEEmp.Properties.NullText = "";
            this.LUEEmp.Properties.NullValuePrompt = "اختار";
            this.LUEEmp.Size = new System.Drawing.Size(173, 19);
            this.LUEEmp.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(254, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم الموظف";
            // 
            // xtraTabPageEditing
            // 
            this.xtraTabPageEditing.Controls.Add(this.gridControlAzn);
            this.xtraTabPageEditing.Name = "xtraTabPageEditing";
            this.xtraTabPageEditing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabPageEditing.Size = new System.Drawing.Size(658, 262);
            this.xtraTabPageEditing.Text = "تعديل";
            // 
            // gridControlAzn
            // 
            this.gridControlAzn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlAzn.Location = new System.Drawing.Point(3, 3);
            this.gridControlAzn.MainView = this.gridViewAzn;
            this.gridControlAzn.Name = "gridControlAzn";
            this.gridControlAzn.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDelete});
            this.gridControlAzn.Size = new System.Drawing.Size(652, 256);
            this.gridControlAzn.TabIndex = 7;
            this.gridControlAzn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAzn});
            // 
            // gridViewAzn
            // 
            this.gridViewAzn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCEmpID,
            this.GCEmp_Full_Name,
            this.GCezn_type_name,
            this.GCezn_date,
            this.GCezn_time_start,
            this.GCezn_time_end,
            this.GCezn_place,
            this.GCDelete});
            this.gridViewAzn.GridControl = this.gridControlAzn;
            this.gridViewAzn.Name = "gridViewAzn";
            // 
            // GCEmpID
            // 
            this.GCEmpID.Caption = "رقم الموظف";
            this.GCEmpID.FieldName = "EmpID";
            this.GCEmpID.Name = "GCEmpID";
            this.GCEmpID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // GCEmp_Full_Name
            // 
            this.GCEmp_Full_Name.Caption = "اسم الموظف";
            this.GCEmp_Full_Name.FieldName = "Emp_Full_Name";
            this.GCEmp_Full_Name.Name = "GCEmp_Full_Name";
            this.GCEmp_Full_Name.OptionsColumn.AllowEdit = false;
            this.GCEmp_Full_Name.Visible = true;
            this.GCEmp_Full_Name.VisibleIndex = 6;
            // 
            // GCezn_type_name
            // 
            this.GCezn_type_name.Caption = "نوع الاذن";
            this.GCezn_type_name.FieldName = "ezn_type_name";
            this.GCezn_type_name.Name = "GCezn_type_name";
            this.GCezn_type_name.OptionsColumn.AllowEdit = false;
            this.GCezn_type_name.Visible = true;
            this.GCezn_type_name.VisibleIndex = 5;
            // 
            // GCezn_date
            // 
            this.GCezn_date.Caption = "تاريخ الاذن";
            this.GCezn_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.GCezn_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCezn_date.FieldName = "ezn_date";
            this.GCezn_date.GroupFormat.FormatString = "dd/MM/yyyy";
            this.GCezn_date.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCezn_date.Name = "GCezn_date";
            this.GCezn_date.OptionsColumn.AllowEdit = false;
            this.GCezn_date.Visible = true;
            this.GCezn_date.VisibleIndex = 4;
            // 
            // GCezn_time_start
            // 
            this.GCezn_time_start.Caption = "وقت الاستأذان";
            this.GCezn_time_start.DisplayFormat.FormatString = "t";
            this.GCezn_time_start.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCezn_time_start.FieldName = "ezn_time_start";
            this.GCezn_time_start.GroupFormat.FormatString = "t";
            this.GCezn_time_start.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCezn_time_start.Name = "GCezn_time_start";
            this.GCezn_time_start.OptionsColumn.AllowEdit = false;
            this.GCezn_time_start.Visible = true;
            this.GCezn_time_start.VisibleIndex = 3;
            // 
            // GCezn_time_end
            // 
            this.GCezn_time_end.Caption = "وقت العوده";
            this.GCezn_time_end.DisplayFormat.FormatString = "t";
            this.GCezn_time_end.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCezn_time_end.FieldName = "ezn_time_end";
            this.GCezn_time_end.GroupFormat.FormatString = "t";
            this.GCezn_time_end.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCezn_time_end.Name = "GCezn_time_end";
            this.GCezn_time_end.OptionsColumn.AllowEdit = false;
            this.GCezn_time_end.Visible = true;
            this.GCezn_time_end.VisibleIndex = 2;
            // 
            // GCezn_place
            // 
            this.GCezn_place.Caption = "معلومات";
            this.GCezn_place.FieldName = "ezn_place";
            this.GCezn_place.Name = "GCezn_place";
            this.GCezn_place.OptionsColumn.AllowEdit = false;
            this.GCezn_place.Visible = true;
            this.GCezn_place.VisibleIndex = 1;
            // 
            // GCDelete
            // 
            this.GCDelete.Caption = "حذف";
            this.GCDelete.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.GCDelete.Name = "GCDelete";
            this.GCDelete.Visible = true;
            this.GCDelete.VisibleIndex = 0;
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
            // DataAznFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 305);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "DataAznFrm";
            this.Text = "اذون الموظفين";
            this.Load += new System.EventHandler(this.DataAznFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageAdding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TECEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEznType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).EndInit();
            this.xtraTabPageEditing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAzn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAzn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAdding;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.MemoEdit MemoTxt;
        private DevExpress.XtraEditors.DateEdit DEDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit LUEEznType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit LUEEmp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageEditing;
        private DevExpress.XtraGrid.GridControl gridControlAzn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAzn;
        private DevExpress.XtraGrid.Columns.GridColumn GCEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn GCEmp_Full_Name;
        private DevExpress.XtraGrid.Columns.GridColumn GCezn_type_name;
        private DevExpress.XtraGrid.Columns.GridColumn GCezn_date;
        private DevExpress.XtraGrid.Columns.GridColumn GCezn_time_start;
        private DevExpress.XtraGrid.Columns.GridColumn GCezn_place;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraEditors.TimeEdit TECEnd;
        private DevExpress.XtraEditors.TimeEdit TECStart;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn GCezn_time_end;
    }
}