namespace Retirement
{
    partial class UsersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersFrm));
            this.groupControlInsert = new DevExpress.XtraEditors.GroupControl();
            this.CEAddActive = new DevExpress.XtraEditors.CheckEdit();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAddItem = new DevExpress.XtraEditors.TextEdit();
            this.TxtAddPass2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddPass1 = new DevExpress.XtraEditors.TextEdit();
            this.groupControlUpdate = new DevExpress.XtraEditors.GroupControl();
            this.CEEditActive = new DevExpress.XtraEditors.CheckEdit();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditPass2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditPass1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlSelect = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInsert)).BeginInit();
            this.groupControlInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEAddActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdate)).BeginInit();
            this.groupControlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEEditActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSelect)).BeginInit();
            this.groupControlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlInsert
            // 
            this.groupControlInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControlInsert.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlInsert.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlInsert.Controls.Add(this.CEAddActive);
            this.groupControlInsert.Controls.Add(this.BtnAdd);
            this.groupControlInsert.Controls.Add(this.TxtAddItem);
            this.groupControlInsert.Controls.Add(this.TxtAddPass2);
            this.groupControlInsert.Controls.Add(this.labelControl3);
            this.groupControlInsert.Controls.Add(this.labelControl7);
            this.groupControlInsert.Controls.Add(this.labelControl6);
            this.groupControlInsert.Controls.Add(this.TxtAddPass1);
            this.groupControlInsert.Location = new System.Drawing.Point(9, 239);
            this.groupControlInsert.Name = "groupControlInsert";
            this.groupControlInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControlInsert.Size = new System.Drawing.Size(341, 153);
            this.groupControlInsert.TabIndex = 7;
            this.groupControlInsert.Text = "اضافة مستخدم جديد";
            // 
            // CEAddActive
            // 
            this.CEAddActive.EditValue = true;
            this.CEAddActive.Location = new System.Drawing.Point(143, 99);
            this.CEAddActive.Name = "CEAddActive";
            this.CEAddActive.Properties.Caption = "متاح";
            this.CEAddActive.Size = new System.Drawing.Size(62, 19);
            this.CEAddActive.TabIndex = 10;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(95, 124);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtAddItem
            // 
            this.TxtAddItem.Location = new System.Drawing.Point(32, 24);
            this.TxtAddItem.Name = "TxtAddItem";
            this.TxtAddItem.Properties.MaxLength = 25;
            this.TxtAddItem.Properties.NullValuePrompt = "ادخل اسم";
            this.TxtAddItem.Size = new System.Drawing.Size(173, 19);
            this.TxtAddItem.TabIndex = 7;
            this.TxtAddItem.EditValueChanged += new System.EventHandler(this.TxtNewItem_EditValueChanged);
            // 
            // TxtAddPass2
            // 
            this.TxtAddPass2.Location = new System.Drawing.Point(32, 74);
            this.TxtAddPass2.Name = "TxtAddPass2";
            this.TxtAddPass2.Properties.MaxLength = 25;
            this.TxtAddPass2.Properties.NullValuePrompt = "اعد كتابة كلمة المرور";
            this.TxtAddPass2.Properties.PasswordChar = '*';
            this.TxtAddPass2.Size = new System.Drawing.Size(173, 19);
            this.TxtAddPass2.TabIndex = 9;
            this.TxtAddPass2.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(225, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "اسم المستخدم";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(211, 77);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "تأكيد كلمة المرور";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(249, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "كلمة المرور";
            // 
            // TxtAddPass1
            // 
            this.TxtAddPass1.Location = new System.Drawing.Point(32, 49);
            this.TxtAddPass1.Name = "TxtAddPass1";
            this.TxtAddPass1.Properties.MaxLength = 25;
            this.TxtAddPass1.Properties.NullValuePrompt = "ادخل كلمة المرور";
            this.TxtAddPass1.Properties.PasswordChar = '*';
            this.TxtAddPass1.Size = new System.Drawing.Size(173, 19);
            this.TxtAddPass1.TabIndex = 8;
            this.TxtAddPass1.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // groupControlUpdate
            // 
            this.groupControlUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControlUpdate.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlUpdate.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlUpdate.Controls.Add(this.CEEditActive);
            this.groupControlUpdate.Controls.Add(this.BtnUpdate);
            this.groupControlUpdate.Controls.Add(this.TxtEditPass2);
            this.groupControlUpdate.Controls.Add(this.labelControl5);
            this.groupControlUpdate.Controls.Add(this.TxtEditPass1);
            this.groupControlUpdate.Controls.Add(this.labelControl4);
            this.groupControlUpdate.Controls.Add(this.TxtEditItem);
            this.groupControlUpdate.Controls.Add(this.labelControl2);
            this.groupControlUpdate.Location = new System.Drawing.Point(9, 75);
            this.groupControlUpdate.Name = "groupControlUpdate";
            this.groupControlUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControlUpdate.Size = new System.Drawing.Size(341, 158);
            this.groupControlUpdate.TabIndex = 2;
            this.groupControlUpdate.Text = "تعديل مستخدم";
            // 
            // CEEditActive
            // 
            this.CEEditActive.EditValue = true;
            this.CEEditActive.Location = new System.Drawing.Point(141, 104);
            this.CEEditActive.Name = "CEEditActive";
            this.CEEditActive.Properties.Caption = "متاح";
            this.CEEditActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CEEditActive.Size = new System.Drawing.Size(64, 19);
            this.CEEditActive.TabIndex = 5;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(95, 129);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "تعديل";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtEditPass2
            // 
            this.TxtEditPass2.Location = new System.Drawing.Point(32, 79);
            this.TxtEditPass2.Name = "TxtEditPass2";
            this.TxtEditPass2.Properties.MaxLength = 25;
            this.TxtEditPass2.Properties.NullValuePrompt = "اعد كتابة كلمة المرور";
            this.TxtEditPass2.Properties.PasswordChar = '*';
            this.TxtEditPass2.Size = new System.Drawing.Size(173, 19);
            this.TxtEditPass2.TabIndex = 4;
            this.TxtEditPass2.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(211, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "تأكيد كلمة المرور";
            // 
            // TxtEditPass1
            // 
            this.TxtEditPass1.Location = new System.Drawing.Point(32, 54);
            this.TxtEditPass1.Name = "TxtEditPass1";
            this.TxtEditPass1.Properties.MaxLength = 25;
            this.TxtEditPass1.Properties.NullValuePrompt = "ادخل كلمة المرور";
            this.TxtEditPass1.Properties.PasswordChar = '*';
            this.TxtEditPass1.Size = new System.Drawing.Size(173, 19);
            this.TxtEditPass1.TabIndex = 3;
            this.TxtEditPass1.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(247, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "كلمة المرور";
            // 
            // TxtEditItem
            // 
            this.TxtEditItem.Location = new System.Drawing.Point(32, 29);
            this.TxtEditItem.Name = "TxtEditItem";
            this.TxtEditItem.Properties.MaxLength = 25;
            this.TxtEditItem.Properties.NullValuePrompt = "ادخل اسم";
            this.TxtEditItem.Size = new System.Drawing.Size(173, 19);
            this.TxtEditItem.TabIndex = 2;
            this.TxtEditItem.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(233, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تعديل الاسم";
            // 
            // groupControlSelect
            // 
            this.groupControlSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControlSelect.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlSelect.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlSelect.Controls.Add(this.BtnDelete);
            this.groupControlSelect.Controls.Add(this.LUEItems);
            this.groupControlSelect.Controls.Add(this.labelControl1);
            this.groupControlSelect.Location = new System.Drawing.Point(9, 10);
            this.groupControlSelect.Name = "groupControlSelect";
            this.groupControlSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControlSelect.Size = new System.Drawing.Size(341, 59);
            this.groupControlSelect.TabIndex = 0;
            this.groupControlSelect.Text = "جميع المستخدمين";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnDelete.Location = new System.Drawing.Point(21, 26);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(44, 22);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LUEItems
            // 
            this.LUEItems.Location = new System.Drawing.Point(68, 29);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "اسم المستخدم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Size = new System.Drawing.Size(173, 19);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(247, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختار مستخدم";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(356, 79);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 241);
            this.BtnRefresh.TabIndex = 12;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // UsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 398);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControlInsert);
            this.Controls.Add(this.groupControlUpdate);
            this.Controls.Add(this.groupControlSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UsersFrm";
            this.Text = "المستخدمين";
            this.Load += new System.EventHandler(this.EditorJobFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInsert)).EndInit();
            this.groupControlInsert.ResumeLayout(false);
            this.groupControlInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEAddActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdate)).EndInit();
            this.groupControlUpdate.ResumeLayout(false);
            this.groupControlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEEditActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSelect)).EndInit();
            this.groupControlSelect.ResumeLayout(false);
            this.groupControlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControlInsert;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.GroupControl groupControlUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit TxtEditItem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControlSelect;
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