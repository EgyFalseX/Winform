namespace E_Club_Att_Manager
{
    partial class EditorShiftFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorShiftFrm));
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.TEEndAdd = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TEStartAdd = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNewShift = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TEEndEdit = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TEStartEdit = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditShift = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUEShift = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEEndAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEStartAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEEndEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEStartEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEShift.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(397, 77);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 241);
            this.BtnRefresh.TabIndex = 9;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.TEEndAdd);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.TEStartAdd);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.BtnAdd);
            this.groupControl3.Controls.Add(this.TxtNewShift);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(12, 217);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(379, 134);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "اضافة فتــــره جديــده";
            // 
            // TEEndAdd
            // 
            this.TEEndAdd.EditValue = new System.DateTime(((long)(0)));
            this.TEEndAdd.Location = new System.Drawing.Point(128, 79);
            this.TEEndAdd.Name = "TEEndAdd";
            this.TEEndAdd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TEEndAdd.Properties.DisplayFormat.FormatString = "t";
            this.TEEndAdd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEEndAdd.Properties.EditFormat.FormatString = "t";
            this.TEEndAdd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEEndAdd.Properties.Mask.EditMask = "t";
            this.TEEndAdd.Size = new System.Drawing.Size(100, 20);
            this.TEEndAdd.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(252, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "نهاية الفتره";
            // 
            // TEStartAdd
            // 
            this.TEStartAdd.EditValue = new System.DateTime(((long)(0)));
            this.TEStartAdd.Location = new System.Drawing.Point(128, 53);
            this.TEStartAdd.Name = "TEStartAdd";
            this.TEStartAdd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TEStartAdd.Properties.DisplayFormat.FormatString = "t";
            this.TEStartAdd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEStartAdd.Properties.EditFormat.FormatString = "t";
            this.TEStartAdd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEStartAdd.Properties.Mask.EditMask = "t";
            this.TEStartAdd.Size = new System.Drawing.Size(100, 20);
            this.TEStartAdd.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(250, 60);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "بداية الفتره";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(118, 105);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "حفـــــظ";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtNewShift
            // 
            this.TxtNewShift.Location = new System.Drawing.Point(55, 28);
            this.TxtNewShift.Name = "TxtNewShift";
            this.TxtNewShift.Properties.MaxLength = 15;
            this.TxtNewShift.Properties.NullValuePrompt = "ادخل الاسم";
            this.TxtNewShift.Size = new System.Drawing.Size(173, 19);
            this.TxtNewShift.TabIndex = 5;
            this.TxtNewShift.EditValueChanged += new System.EventHandler(this.TxtNewShift_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(259, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "اسم الفتره";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TEEndEdit);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.TEStartEdit);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.TxtEditShift);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(12, 77);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 134);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "تعديل اسم فتـــره";
            // 
            // TEEndEdit
            // 
            this.TEEndEdit.EditValue = new System.DateTime(((long)(0)));
            this.TEEndEdit.Location = new System.Drawing.Point(128, 79);
            this.TEEndEdit.Name = "TEEndEdit";
            this.TEEndEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TEEndEdit.Properties.DisplayFormat.FormatString = "t";
            this.TEEndEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEEndEdit.Properties.EditFormat.FormatString = "t";
            this.TEEndEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEEndEdit.Properties.Mask.EditMask = "t";
            this.TEEndEdit.Size = new System.Drawing.Size(100, 20);
            this.TEEndEdit.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(250, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "نهاية الفتره";
            // 
            // TEStartEdit
            // 
            this.TEStartEdit.EditValue = new System.DateTime(((long)(0)));
            this.TEStartEdit.Location = new System.Drawing.Point(128, 53);
            this.TEStartEdit.Name = "TEStartEdit";
            this.TEStartEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TEStartEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TEStartEdit.Properties.DisplayFormat.FormatString = "t";
            this.TEStartEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEStartEdit.Properties.EditFormat.FormatString = "t";
            this.TEStartEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TEStartEdit.Properties.Mask.EditMask = "t";
            this.TEStartEdit.Size = new System.Drawing.Size(100, 20);
            this.TEStartEdit.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(250, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "بداية الفتره";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(118, 105);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "حفـــــظ";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtEditShift
            // 
            this.TxtEditShift.Location = new System.Drawing.Point(55, 28);
            this.TxtEditShift.Name = "TxtEditShift";
            this.TxtEditShift.Properties.MaxLength = 15;
            this.TxtEditShift.Properties.NullValuePrompt = "ادخل الاسم";
            this.TxtEditShift.Size = new System.Drawing.Size(173, 19);
            this.TxtEditShift.TabIndex = 1;
            this.TxtEditShift.EditValueChanged += new System.EventHandler(this.TxtEditShift_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(249, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تعديل الاسم";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.LUEShift);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 59);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "جميع الفتــــــرات المضافه";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnDelete.Location = new System.Drawing.Point(6, 26);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(44, 22);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LUEShift
            // 
            this.LUEShift.Location = new System.Drawing.Point(55, 28);
            this.LUEShift.Name = "LUEShift";
            this.LUEShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEShift.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("shift", "اسماء الفتــــــــــرات")});
            this.LUEShift.Properties.NullText = "";
            this.LUEShift.Properties.NullValuePrompt = "اختـــار";
            this.LUEShift.Size = new System.Drawing.Size(173, 19);
            this.LUEShift.TabIndex = 0;
            this.LUEShift.EditValueChanged += new System.EventHandler(this.LUEShift_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(234, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع الفتـــــرات";
            // 
            // EditorShiftFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 358);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorShiftFrm";
            this.Text = "الفتــــرات";
            this.Load += new System.EventHandler(this.EditorShiftFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEEndAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEStartAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEEndEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEStartEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEShift.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.TextEdit TxtNewShift;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit TxtEditShift;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.LookUpEdit LUEShift;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit TEEndEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TimeEdit TEStartEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TimeEdit TEEndAdd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TimeEdit TEStartAdd;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}