namespace E_Club_Mem_Manager
{
    partial class EditorUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorUserFrm));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditPass1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditPass2 = new DevExpress.XtraEditors.TextEdit();
            this.CEEditActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddPass1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddPass2 = new DevExpress.XtraEditors.TextEdit();
            this.CEAddActive = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEEditActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEAddActive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.CEAddActive);
            this.groupControl3.Controls.Add(this.BtnAdd);
            this.groupControl3.Controls.Add(this.TxtAddItem);
            this.groupControl3.Controls.Add(this.TxtAddPass2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.TxtAddPass1);
            this.groupControl3.Location = new System.Drawing.Point(9, 239);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(379, 153);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "اضافة مستخدم جديــده";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(118, 124);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "حفـــــظ";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.CEEditActive);
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.TxtEditPass2);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.TxtEditPass1);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.TxtEditItem);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(9, 75);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 158);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "تعديل اسم مستخدم";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(118, 128);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "حفـــــظ";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtEditItem
            // 
            this.TxtEditItem.Location = new System.Drawing.Point(55, 28);
            this.TxtEditItem.Name = "TxtEditItem";
            this.TxtEditItem.Properties.MaxLength = 25;
            this.TxtEditItem.Properties.NullValuePrompt = "ادخل اسم";
            this.TxtEditItem.Size = new System.Drawing.Size(173, 19);
            this.TxtEditItem.TabIndex = 2;
            this.TxtEditItem.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(265, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تعديل الاسم";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.LUEItems);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(9, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 59);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "جميع اسماء المستخدمين";
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
            // LUEItems
            // 
            this.LUEItems.Location = new System.Drawing.Point(55, 28);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "اسماء المستخدمين")});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Properties.NullValuePrompt = "اختـــار";
            this.LUEItems.Size = new System.Drawing.Size(173, 19);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(234, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع المستخدمين";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(395, 79);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 241);
            this.BtnRefresh.TabIndex = 12;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(279, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "كلمة المرور";
            // 
            // TxtEditPass1
            // 
            this.TxtEditPass1.Location = new System.Drawing.Point(55, 53);
            this.TxtEditPass1.Name = "TxtEditPass1";
            this.TxtEditPass1.Properties.MaxLength = 25;
            this.TxtEditPass1.Properties.NullValuePrompt = "ادخل كلمة المرور";
            this.TxtEditPass1.Properties.PasswordChar = '*';
            this.TxtEditPass1.Size = new System.Drawing.Size(173, 19);
            this.TxtEditPass1.TabIndex = 3;
            this.TxtEditPass1.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(256, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "اعدة كلمة المرور";
            // 
            // TxtEditPass2
            // 
            this.TxtEditPass2.Location = new System.Drawing.Point(55, 78);
            this.TxtEditPass2.Name = "TxtEditPass2";
            this.TxtEditPass2.Properties.MaxLength = 25;
            this.TxtEditPass2.Properties.NullValuePrompt = "اعد كتابة كلمة المرور";
            this.TxtEditPass2.Properties.PasswordChar = '*';
            this.TxtEditPass2.Size = new System.Drawing.Size(173, 19);
            this.TxtEditPass2.TabIndex = 4;
            this.TxtEditPass2.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // CEEditActive
            // 
            this.CEEditActive.EditValue = true;
            this.CEEditActive.Location = new System.Drawing.Point(95, 103);
            this.CEEditActive.Name = "CEEditActive";
            this.CEEditActive.Properties.Caption = "تفعيل الاستخدام";
            this.CEEditActive.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.CEEditActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CEEditActive.Size = new System.Drawing.Size(133, 22);
            this.CEEditActive.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(303, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = " الاسم";
            // 
            // TxtAddItem
            // 
            this.TxtAddItem.Location = new System.Drawing.Point(55, 24);
            this.TxtAddItem.Name = "TxtAddItem";
            this.TxtAddItem.Properties.MaxLength = 25;
            this.TxtAddItem.Properties.NullValuePrompt = "ادخل اسم";
            this.TxtAddItem.Size = new System.Drawing.Size(173, 19);
            this.TxtAddItem.TabIndex = 7;
            this.TxtAddItem.EditValueChanged += new System.EventHandler(this.TxtNewItem_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(279, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "كلمة المرور";
            // 
            // TxtAddPass1
            // 
            this.TxtAddPass1.Location = new System.Drawing.Point(55, 49);
            this.TxtAddPass1.Name = "TxtAddPass1";
            this.TxtAddPass1.Properties.MaxLength = 25;
            this.TxtAddPass1.Properties.NullValuePrompt = "ادخل كلمة المرور";
            this.TxtAddPass1.Properties.PasswordChar = '*';
            this.TxtAddPass1.Size = new System.Drawing.Size(173, 19);
            this.TxtAddPass1.TabIndex = 8;
            this.TxtAddPass1.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(256, 77);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(83, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "اعدة كلمة المرور";
            // 
            // TxtAddPass2
            // 
            this.TxtAddPass2.Location = new System.Drawing.Point(55, 74);
            this.TxtAddPass2.Name = "TxtAddPass2";
            this.TxtAddPass2.Properties.MaxLength = 25;
            this.TxtAddPass2.Properties.NullValuePrompt = "اعد كتابة كلمة المرور";
            this.TxtAddPass2.Properties.PasswordChar = '*';
            this.TxtAddPass2.Size = new System.Drawing.Size(173, 19);
            this.TxtAddPass2.TabIndex = 9;
            this.TxtAddPass2.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // CEAddActive
            // 
            this.CEAddActive.EditValue = true;
            this.CEAddActive.Location = new System.Drawing.Point(95, 99);
            this.CEAddActive.Name = "CEAddActive";
            this.CEAddActive.Properties.Caption = "تفعيل الاستخدام";
            this.CEAddActive.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.CEAddActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CEAddActive.Size = new System.Drawing.Size(133, 22);
            this.CEAddActive.TabIndex = 10;
            // 
            // EditorUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 398);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorUserFrm";
            this.Text = "المحافظات";
            this.Load += new System.EventHandler(this.EditorJobFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEEditActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEAddActive.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit TxtEditItem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CEAddActive;
        private DevExpress.XtraEditors.TextEdit TxtAddItem;
        private DevExpress.XtraEditors.TextEdit TxtAddPass2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtAddPass1;
        private DevExpress.XtraEditors.CheckEdit CEEditActive;
        private DevExpress.XtraEditors.TextEdit TxtEditPass2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtEditPass1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}