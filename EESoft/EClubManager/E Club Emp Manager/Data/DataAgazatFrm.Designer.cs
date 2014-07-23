namespace E_Club_Emp_Manager
{
    partial class DataAgazatFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataAgazatFrm));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageAdding = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.MemoTxt = new DevExpress.XtraEditors.MemoEdit();
            this.DEEnd = new DevExpress.XtraEditors.DateEdit();
            this.DEStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LUEAgazaType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LUEEmp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageEditing = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlAgaza = new DevExpress.XtraGrid.GridControl();
            this.gridViewAgaza = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCEmp_Full_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCagaza_type_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCagaza_st_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCagaza_end_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCagaza_MEMEO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEAgazaType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).BeginInit();
            this.xtraTabPageEditing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAgaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAgaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageAdding;
            this.xtraTabControl1.Size = new System.Drawing.Size(672, 297);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageAdding,
            this.xtraTabPageEditing});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPageAdding
            // 
            this.xtraTabPageAdding.Controls.Add(this.groupControl1);
            this.xtraTabPageAdding.Name = "xtraTabPageAdding";
            this.xtraTabPageAdding.Size = new System.Drawing.Size(666, 271);
            this.xtraTabPageAdding.Text = "اضافه";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.MemoTxt);
            this.groupControl1.Controls.Add(this.DEEnd);
            this.groupControl1.Controls.Add(this.DEStart);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.LUEAgazaType);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.LUEEmp);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(168, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(328, 256);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "اضافه اجازه للموظف";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(123, 226);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "اضافه";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MemoTxt
            // 
            this.MemoTxt.Location = new System.Drawing.Point(3, 124);
            this.MemoTxt.Name = "MemoTxt";
            this.MemoTxt.Properties.MaxLength = 200;
            this.MemoTxt.Properties.NullValuePrompt = "اضق ملاحظه";
            this.MemoTxt.Size = new System.Drawing.Size(232, 96);
            this.MemoTxt.TabIndex = 4;
            // 
            // DEEnd
            // 
            this.DEEnd.EditValue = null;
            this.DEEnd.Location = new System.Drawing.Point(62, 99);
            this.DEEnd.Name = "DEEnd";
            this.DEEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEEnd.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.DEEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEEnd.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.DEEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEEnd.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.DEEnd.Properties.NullValuePrompt = "اختار تاريخ";
            this.DEEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DEEnd.Size = new System.Drawing.Size(173, 19);
            this.DEEnd.TabIndex = 3;
            // 
            // DEStart
            // 
            this.DEStart.EditValue = null;
            this.DEStart.Location = new System.Drawing.Point(62, 74);
            this.DEStart.Name = "DEStart";
            this.DEStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.DEStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEStart.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.DEStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.DEStart.Properties.NullValuePrompt = "اختار تاريخ";
            this.DEStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DEStart.Size = new System.Drawing.Size(173, 19);
            this.DEStart.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(267, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Tag = "";
            this.labelControl5.Text = "ملاحظـــات";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(265, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "تاريخ النهايه";
            // 
            // LUEAgazaType
            // 
            this.LUEAgazaType.Location = new System.Drawing.Point(62, 49);
            this.LUEAgazaType.Name = "LUEAgazaType";
            this.LUEAgazaType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEAgazaType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("agaza_type_name", "اسم نوع الاجازه")});
            this.LUEAgazaType.Properties.NullText = "";
            this.LUEAgazaType.Properties.NullValuePrompt = "اختار";
            this.LUEAgazaType.Size = new System.Drawing.Size(173, 19);
            this.LUEAgazaType.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(265, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تاريخ البدايه";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(270, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "نوع الاجازه";
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
            this.labelControl1.Location = new System.Drawing.Point(257, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم الموظف";
            // 
            // xtraTabPageEditing
            // 
            this.xtraTabPageEditing.Controls.Add(this.gridControlAgaza);
            this.xtraTabPageEditing.Name = "xtraTabPageEditing";
            this.xtraTabPageEditing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabPageEditing.Size = new System.Drawing.Size(666, 271);
            this.xtraTabPageEditing.Text = "تعديل";
            // 
            // gridControlAgaza
            // 
            this.gridControlAgaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlAgaza.Location = new System.Drawing.Point(3, 3);
            this.gridControlAgaza.MainView = this.gridViewAgaza;
            this.gridControlAgaza.Name = "gridControlAgaza";
            this.gridControlAgaza.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDelete});
            this.gridControlAgaza.Size = new System.Drawing.Size(659, 262);
            this.gridControlAgaza.TabIndex = 6;
            this.gridControlAgaza.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAgaza});
            // 
            // gridViewAgaza
            // 
            this.gridViewAgaza.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCEmpID,
            this.GCEmp_Full_Name,
            this.GCagaza_type_name,
            this.GCagaza_st_date,
            this.GCagaza_end_date,
            this.GCagaza_MEMEO,
            this.GCDelete});
            this.gridViewAgaza.GridControl = this.gridControlAgaza;
            this.gridViewAgaza.Name = "gridViewAgaza";
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
            this.GCEmp_Full_Name.VisibleIndex = 5;
            // 
            // GCagaza_type_name
            // 
            this.GCagaza_type_name.Caption = "نوع الاجازه";
            this.GCagaza_type_name.FieldName = "agaza_type_name";
            this.GCagaza_type_name.Name = "GCagaza_type_name";
            this.GCagaza_type_name.OptionsColumn.AllowEdit = false;
            this.GCagaza_type_name.Visible = true;
            this.GCagaza_type_name.VisibleIndex = 4;
            // 
            // GCagaza_st_date
            // 
            this.GCagaza_st_date.Caption = "تاريخ البدايه";
            this.GCagaza_st_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.GCagaza_st_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCagaza_st_date.FieldName = "agaza_st_date";
            this.GCagaza_st_date.GroupFormat.FormatString = "dd/MM/yyyy";
            this.GCagaza_st_date.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCagaza_st_date.Name = "GCagaza_st_date";
            this.GCagaza_st_date.OptionsColumn.AllowEdit = false;
            this.GCagaza_st_date.Visible = true;
            this.GCagaza_st_date.VisibleIndex = 3;
            // 
            // GCagaza_end_date
            // 
            this.GCagaza_end_date.Caption = "تاريخ النهايه";
            this.GCagaza_end_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.GCagaza_end_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCagaza_end_date.FieldName = "agaza_end_date";
            this.GCagaza_end_date.GroupFormat.FormatString = "dd/MM/yyyy";
            this.GCagaza_end_date.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GCagaza_end_date.Name = "GCagaza_end_date";
            this.GCagaza_end_date.OptionsColumn.AllowEdit = false;
            this.GCagaza_end_date.Visible = true;
            this.GCagaza_end_date.VisibleIndex = 2;
            // 
            // GCagaza_MEMEO
            // 
            this.GCagaza_MEMEO.Caption = "معلومات";
            this.GCagaza_MEMEO.FieldName = "agaza_MEMEO";
            this.GCagaza_MEMEO.Name = "GCagaza_MEMEO";
            this.GCagaza_MEMEO.OptionsColumn.AllowEdit = false;
            this.GCagaza_MEMEO.Visible = true;
            this.GCagaza_MEMEO.VisibleIndex = 1;
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
            // DataAgazatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 321);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataAgazatFrm";
            this.Text = "اجازات الموظفين";
            this.Load += new System.EventHandler(this.DataAgazatFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageAdding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEAgazaType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).EndInit();
            this.xtraTabPageEditing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAgaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAgaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAdding;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageEditing;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit MemoTxt;
        private DevExpress.XtraEditors.DateEdit DEEnd;
        private DevExpress.XtraEditors.DateEdit DEStart;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit LUEEmp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraGrid.GridControl gridControlAgaza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAgaza;
        private DevExpress.XtraGrid.Columns.GridColumn GCEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn GCEmp_Full_Name;
        private DevExpress.XtraGrid.Columns.GridColumn GCagaza_type_name;
        private DevExpress.XtraGrid.Columns.GridColumn GCagaza_st_date;
        private DevExpress.XtraGrid.Columns.GridColumn GCagaza_end_date;
        private DevExpress.XtraGrid.Columns.GridColumn GCagaza_MEMEO;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraEditors.LookUpEdit LUEAgazaType;
    }
}