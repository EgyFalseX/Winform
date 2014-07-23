namespace E_Club_Att_Manager
{
    partial class DataEmpAttTimeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEmpAttTimeFrm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LUEShift = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LUEEmp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TECEnd = new DevExpress.XtraEditors.TimeEdit();
            this.TECStart = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.TEWEnd = new DevExpress.XtraEditors.TimeEdit();
            this.TEWStart = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlEdit = new DevExpress.XtraGrid.GridControl();
            this.gridViewEdit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCshift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GChedor_time_Start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GChedor_time_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCenseraf_time_Start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCenseraf_time_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TECEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEWEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEWStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.LUEShift);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.LUEEmp);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(549, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(229, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات رئيسيه";
            // 
            // LUEShift
            // 
            this.LUEShift.Location = new System.Drawing.Point(5, 49);
            this.LUEShift.Name = "LUEShift";
            this.LUEShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEShift.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("shift", "اسم الفتره"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("shift_Start", "بداية الفتره"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("shift_End", "نهاية الفتره")});
            this.LUEShift.Properties.NullText = "";
            this.LUEShift.Properties.NullValuePrompt = "اختــــــــــار";
            this.LUEShift.Size = new System.Drawing.Size(150, 19);
            this.LUEShift.TabIndex = 1;
            this.LUEShift.EditValueChanged += new System.EventHandler(this.LUEShift_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(179, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "الفتره";
            // 
            // LUEEmp
            // 
            this.LUEEmp.Location = new System.Drawing.Point(5, 24);
            this.LUEEmp.Name = "LUEEmp";
            this.LUEEmp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEmp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Emp_Full_Name", "اسم الموظف"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PHONE_NO", "تليفون"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MOBILE_NO", "موبيل")});
            this.LUEEmp.Properties.NullText = "";
            this.LUEEmp.Properties.NullValuePrompt = "اختــــــــــار";
            this.LUEEmp.Size = new System.Drawing.Size(150, 19);
            this.LUEEmp.TabIndex = 0;
            this.LUEEmp.EditValueChanged += new System.EventHandler(this.LUEEmp_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(161, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الموظفين";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.TECEnd);
            this.groupControl2.Controls.Add(this.TECStart);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(358, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(185, 79);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "حضــــور";
            // 
            // TECEnd
            // 
            this.TECEnd.EditValue = new System.DateTime(((long)(0)));
            this.TECEnd.Location = new System.Drawing.Point(5, 50);
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
            this.TECEnd.TabIndex = 3;
            // 
            // TECStart
            // 
            this.TECStart.EditValue = new System.DateTime(((long)(0)));
            this.TECStart.Location = new System.Drawing.Point(5, 24);
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
            this.TECStart.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(148, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "نهايه";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(148, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "بداية";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.TEWEnd);
            this.groupControl3.Controls.Add(this.TEWStart);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Location = new System.Drawing.Point(167, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(185, 79);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "انصــــــــراف";
            // 
            // TEWEnd
            // 
            this.TEWEnd.EditValue = new System.DateTime(((long)(0)));
            this.TEWEnd.Location = new System.Drawing.Point(5, 50);
            this.TEWEnd.Name = "TEWEnd";
            this.TEWEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TEWEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TEWEnd.Properties.DisplayFormat.FormatString = "t";
            this.TEWEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEWEnd.Properties.EditFormat.FormatString = "t";
            this.TEWEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEWEnd.Properties.Mask.EditMask = "t";
            this.TEWEnd.Size = new System.Drawing.Size(111, 20);
            this.TEWEnd.TabIndex = 5;
            // 
            // TEWStart
            // 
            this.TEWStart.EditValue = new System.DateTime(((long)(0)));
            this.TEWStart.Location = new System.Drawing.Point(5, 24);
            this.TEWStart.Name = "TEWStart";
            this.TEWStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TEWStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TEWStart.Properties.DisplayFormat.FormatString = "t";
            this.TEWStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEWStart.Properties.EditFormat.FormatString = "t";
            this.TEWStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEWStart.Properties.Mask.EditMask = "t";
            this.TEWStart.Size = new System.Drawing.Size(111, 20);
            this.TEWStart.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(148, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "نهايه";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(146, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "بداية";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(86, 39);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 52);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "حفـــظ";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // gridControlEdit
            // 
            this.gridControlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlEdit.Location = new System.Drawing.Point(5, 97);
            this.gridControlEdit.MainView = this.gridViewEdit;
            this.gridControlEdit.Name = "gridControlEdit";
            this.gridControlEdit.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDelete});
            this.gridControlEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlEdit.Size = new System.Drawing.Size(773, 353);
            this.gridControlEdit.TabIndex = 7;
            this.gridControlEdit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEdit});
            // 
            // gridViewEdit
            // 
            this.gridViewEdit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCEmpID,
            this.GCshift,
            this.GChedor_time_Start,
            this.GChedor_time_End,
            this.GCenseraf_time_Start,
            this.GCenseraf_time_End,
            this.gridColumn7});
            this.gridViewEdit.GridControl = this.gridControlEdit;
            this.gridViewEdit.Name = "gridViewEdit";
            // 
            // GCEmpID
            // 
            this.GCEmpID.Caption = "كود الموظف";
            this.GCEmpID.FieldName = "EmpID";
            this.GCEmpID.Name = "GCEmpID";
            this.GCEmpID.OptionsColumn.AllowEdit = false;
            this.GCEmpID.OptionsColumn.ReadOnly = true;
            this.GCEmpID.Visible = true;
            this.GCEmpID.VisibleIndex = 6;
            // 
            // GCshift
            // 
            this.GCshift.Caption = "نوع الفتره";
            this.GCshift.FieldName = "shift";
            this.GCshift.Name = "GCshift";
            this.GCshift.OptionsColumn.AllowEdit = false;
            this.GCshift.OptionsColumn.ReadOnly = true;
            this.GCshift.Visible = true;
            this.GCshift.VisibleIndex = 5;
            this.GCshift.Width = 118;
            // 
            // GChedor_time_Start
            // 
            this.GChedor_time_Start.Caption = "بداية فترة الحضور";
            this.GChedor_time_Start.DisplayFormat.FormatString = "t";
            this.GChedor_time_Start.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GChedor_time_Start.FieldName = "hedor_time_Start";
            this.GChedor_time_Start.GroupFormat.FormatString = "t";
            this.GChedor_time_Start.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GChedor_time_Start.Name = "GChedor_time_Start";
            this.GChedor_time_Start.OptionsColumn.AllowEdit = false;
            this.GChedor_time_Start.OptionsColumn.ReadOnly = true;
            this.GChedor_time_Start.Visible = true;
            this.GChedor_time_Start.VisibleIndex = 4;
            this.GChedor_time_Start.Width = 141;
            // 
            // GChedor_time_End
            // 
            this.GChedor_time_End.Caption = "نهاية فترة الحضور";
            this.GChedor_time_End.DisplayFormat.FormatString = "t";
            this.GChedor_time_End.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GChedor_time_End.FieldName = "hedor_time_End";
            this.GChedor_time_End.GroupFormat.FormatString = "t";
            this.GChedor_time_End.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GChedor_time_End.Name = "GChedor_time_End";
            this.GChedor_time_End.OptionsColumn.AllowEdit = false;
            this.GChedor_time_End.OptionsColumn.ReadOnly = true;
            this.GChedor_time_End.Visible = true;
            this.GChedor_time_End.VisibleIndex = 3;
            this.GChedor_time_End.Width = 132;
            // 
            // GCenseraf_time_Start
            // 
            this.GCenseraf_time_Start.Caption = "بداية فترة الانصراف";
            this.GCenseraf_time_Start.DisplayFormat.FormatString = "t";
            this.GCenseraf_time_Start.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCenseraf_time_Start.FieldName = "enseraf_time_Start";
            this.GCenseraf_time_Start.GroupFormat.FormatString = "t";
            this.GCenseraf_time_Start.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCenseraf_time_Start.Name = "GCenseraf_time_Start";
            this.GCenseraf_time_Start.OptionsColumn.AllowEdit = false;
            this.GCenseraf_time_Start.OptionsColumn.ReadOnly = true;
            this.GCenseraf_time_Start.Visible = true;
            this.GCenseraf_time_Start.VisibleIndex = 2;
            this.GCenseraf_time_Start.Width = 140;
            // 
            // GCenseraf_time_End
            // 
            this.GCenseraf_time_End.Caption = "نهاية فترة الانصراف";
            this.GCenseraf_time_End.DisplayFormat.FormatString = "t";
            this.GCenseraf_time_End.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCenseraf_time_End.FieldName = "enseraf_time_End";
            this.GCenseraf_time_End.GroupFormat.FormatString = "t";
            this.GCenseraf_time_End.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCenseraf_time_End.Name = "GCenseraf_time_End";
            this.GCenseraf_time_End.OptionsColumn.AllowEdit = false;
            this.GCenseraf_time_End.OptionsColumn.ReadOnly = true;
            this.GCenseraf_time_End.Visible = true;
            this.GCenseraf_time_End.VisibleIndex = 1;
            this.GCenseraf_time_End.Width = 138;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "حــــــــــــذف";
            this.gridColumn7.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 86;
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
            // DataEmpAttTimeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.gridControlEdit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataEmpAttTimeFrm";
            this.Text = "اوقات حضور و انصراف العاملين";
            this.Load += new System.EventHandler(this.DataEmpAttTimeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TECEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEWEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEWStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit LUEEmp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit LUEShift;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TimeEdit TECEnd;
        private DevExpress.XtraEditors.TimeEdit TECStart;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TimeEdit TEWEnd;
        private DevExpress.XtraEditors.TimeEdit TEWStart;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraGrid.GridControl gridControlEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn GCEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn GCshift;
        private DevExpress.XtraGrid.Columns.GridColumn GChedor_time_Start;
        private DevExpress.XtraGrid.Columns.GridColumn GChedor_time_End;
        private DevExpress.XtraGrid.Columns.GridColumn GCenseraf_time_Start;
        private DevExpress.XtraGrid.Columns.GridColumn GCenseraf_time_End;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
    }
}