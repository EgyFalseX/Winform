namespace schoolStore
{
    partial class EditorAccountNatureFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorAccountNatureFrm));
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNewNatureTypes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditNatureType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUENatureTypes = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewNatureTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditNatureType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUENatureTypes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(396, 10);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 241);
            this.BtnRefresh.TabIndex = 14;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnAdd);
            this.groupControl3.Controls.Add(this.TxtNewNatureTypes);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(10, 166);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(379, 85);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "اضافة طبيعة حساب";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(118, 53);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "حفـــــظ";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtNewNatureTypes
            // 
            this.TxtNewNatureTypes.Location = new System.Drawing.Point(55, 28);
            this.TxtNewNatureTypes.Name = "TxtNewNatureTypes";
            this.TxtNewNatureTypes.Properties.MaxLength = 20;
            this.TxtNewNatureTypes.Size = new System.Drawing.Size(173, 19);
            this.TxtNewNatureTypes.TabIndex = 4;
            this.TxtNewNatureTypes.EditValueChanged += new System.EventHandler(this.TxtNewNatureTypes_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(255, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "اسم الحساب";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.TxtEditNatureType);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(10, 75);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 85);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "تعديل طبيعة حساب";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(118, 53);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "حفـــــظ";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtEditNatureType
            // 
            this.TxtEditNatureType.Location = new System.Drawing.Point(55, 28);
            this.TxtEditNatureType.Name = "TxtEditNatureType";
            this.TxtEditNatureType.Properties.MaxLength = 20;
            this.TxtEditNatureType.Size = new System.Drawing.Size(173, 19);
            this.TxtEditNatureType.TabIndex = 2;
            this.TxtEditNatureType.EditValueChanged += new System.EventHandler(this.TxtEditNatureType_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(259, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تعديل الاسم";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.LUENatureTypes);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 59);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "جميع الطبيعات";
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
            // LUENatureTypes
            // 
            this.LUENatureTypes.Location = new System.Drawing.Point(55, 28);
            this.LUENatureTypes.Name = "LUENatureTypes";
            this.LUENatureTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUENatureTypes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccNatueID", "AccNatueID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccNatueName", "طبيعة الحسابات")});
            this.LUENatureTypes.Properties.NullText = "";
            this.LUENatureTypes.Properties.NullValuePrompt = "اختـــار";
            this.LUENatureTypes.Size = new System.Drawing.Size(173, 19);
            this.LUENatureTypes.TabIndex = 0;
            this.LUENatureTypes.EditValueChanged += new System.EventHandler(this.LUENatureTypes_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(250, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع الطبيعات";
            // 
            // EditorAccountNatureFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 260);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorAccountNatureFrm";
            this.Text = "طبيعة الحسابات";
            this.Load += new System.EventHandler(this.EditorAccountNatureFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewNatureTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditNatureType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUENatureTypes.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.TextEdit TxtNewNatureTypes;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit TxtEditNatureType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.LookUpEdit LUENatureTypes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}