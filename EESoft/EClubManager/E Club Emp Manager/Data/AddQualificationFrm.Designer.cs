namespace E_Club_Emp_Manager
{
    partial class AddQualificationFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQualificationFrm));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnAddQua = new DevExpress.XtraEditors.SimpleButton();
            this.DEDate = new DevExpress.XtraEditors.DateEdit();
            this.LUEDgree = new DevExpress.XtraEditors.LookUpEdit();
            this.LUESpec = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LUEQua = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.DGVAddQua = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LUEEmployees = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEDgree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEQua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAddQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmployees.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl3.Controls.Add(this.BtnAddQua);
            this.groupControl3.Controls.Add(this.DEDate);
            this.groupControl3.Controls.Add(this.LUEDgree);
            this.groupControl3.Controls.Add(this.LUESpec);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.LUEQua);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Location = new System.Drawing.Point(12, 72);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(628, 104);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "بيانات المؤهل";
            // 
            // BtnAddQua
            // 
            this.BtnAddQua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddQua.Location = new System.Drawing.Point(236, 74);
            this.BtnAddQua.Name = "BtnAddQua";
            this.BtnAddQua.Size = new System.Drawing.Size(156, 23);
            this.BtnAddQua.TabIndex = 3;
            this.BtnAddQua.Text = "اضـــــــافه";
            this.BtnAddQua.Click += new System.EventHandler(this.BtnAddQua_Click);
            // 
            // DEDate
            // 
            this.DEDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DEDate.EditValue = null;
            this.DEDate.Location = new System.Drawing.Point(45, 49);
            this.DEDate.Name = "DEDate";
            this.DEDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.DEDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.DEDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEDate.Properties.NullValuePrompt = "اختار التاريخ";
            this.DEDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DEDate.Size = new System.Drawing.Size(197, 19);
            this.DEDate.TabIndex = 2;
            // 
            // LUEDgree
            // 
            this.LUEDgree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUEDgree.Location = new System.Drawing.Point(333, 49);
            this.LUEDgree.Name = "LUEDgree";
            this.LUEDgree.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEDgree.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("takdeer_code", "takdeer_code", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("takdeer_name", "takdeer_name")});
            this.LUEDgree.Properties.NullText = "";
            this.LUEDgree.Properties.NullValuePrompt = "لا يوجـــــد";
            this.LUEDgree.Size = new System.Drawing.Size(197, 19);
            this.LUEDgree.TabIndex = 1;
            // 
            // LUESpec
            // 
            this.LUESpec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUESpec.Location = new System.Drawing.Point(45, 24);
            this.LUESpec.Name = "LUESpec";
            this.LUESpec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUESpec.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPECIFICATION_ID", "SPECIFICATION_ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPECIFICATION_NAME", "تخصص المؤهل")});
            this.LUESpec.Properties.NullText = "";
            this.LUESpec.Properties.NullValuePrompt = "لا يوجـــــد";
            this.LUESpec.Size = new System.Drawing.Size(197, 19);
            this.LUESpec.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Location = new System.Drawing.Point(536, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "التقدير";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Location = new System.Drawing.Point(248, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تاريخ المؤهل";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Location = new System.Drawing.Point(248, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تخصص المؤهل";
            // 
            // LUEQua
            // 
            this.LUEQua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUEQua.Location = new System.Drawing.Point(333, 24);
            this.LUEQua.Name = "LUEQua";
            this.LUEQua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEQua.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moaahel_ID", "Moaahel_ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moaahel_Name", "المؤهلات")});
            this.LUEQua.Properties.NullText = "";
            this.LUEQua.Properties.NullValuePrompt = "لا يوجـــــد";
            this.LUEQua.Size = new System.Drawing.Size(197, 19);
            this.LUEQua.TabIndex = 1;
            this.LUEQua.EditValueChanged += new System.EventHandler(this.LUEQua_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(536, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "المؤهل";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl2.Controls.Add(this.DGVAddQua);
            this.groupControl2.Location = new System.Drawing.Point(12, 182);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(630, 249);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "مؤهلات الموظـــف";
            // 
            // DGVAddQua
            // 
            this.DGVAddQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAddQua.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAddQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVAddQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAddQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAddQua.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVAddQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAddQua.Location = new System.Drawing.Point(2, 21);
            this.DGVAddQua.MultiSelect = false;
            this.DGVAddQua.Name = "DGVAddQua";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAddQua.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVAddQua.RowTemplate.ReadOnly = true;
            this.DGVAddQua.Size = new System.Drawing.Size(626, 226);
            this.DGVAddQua.TabIndex = 0;
            this.DGVAddQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAddQua_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Emp_ID";
            this.Column5.HeaderText = "Emp_ID";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Emp_Name";
            this.Column1.HeaderText = "الاسم";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Moaahel_ID";
            this.Column6.HeaderText = "Moaahel_ID";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Moaahel_Name";
            this.Column2.HeaderText = "المؤهل";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Spec_Name";
            this.Column3.HeaderText = "تخصص المؤهل";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Moaahel_Dat";
            this.Column4.HeaderText = "تاريخ المؤهل";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "حذف";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Text = "حذف المؤهل";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Controls.Add(this.LUEEmployees);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(630, 54);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "جميع الموظفــــين";
            // 
            // LUEEmployees
            // 
            this.LUEEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUEEmployees.Location = new System.Drawing.Point(192, 26);
            this.LUEEmployees.Name = "LUEEmployees";
            this.LUEEmployees.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEmployees.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpID", "EmpID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Emp_Full_Name", "اسماء الموظفيــن")});
            this.LUEEmployees.Properties.NullText = "";
            this.LUEEmployees.Properties.NullValuePrompt = "لا يوجـــــد";
            this.LUEEmployees.Size = new System.Drawing.Size(247, 19);
            this.LUEEmployees.TabIndex = 1;
            this.LUEEmployees.EditValueChanged += new System.EventHandler(this.LUEEmployees_EditValueChanged);
            // 
            // AddQualificationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 439);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQualificationFrm";
            this.Text = "مؤهلات الموظفين";
            this.Load += new System.EventHandler(this.AddQualificationFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEDgree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEQua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAddQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmployees.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit LUEEmployees;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView DGVAddQua;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit DEDate;
        private DevExpress.XtraEditors.LookUpEdit LUESpec;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit LUEQua;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit LUEDgree;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton BtnAddQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}