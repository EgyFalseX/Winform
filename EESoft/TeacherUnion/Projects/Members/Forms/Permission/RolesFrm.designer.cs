namespace Members.Forms.Data
{
    partial class RolesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesFrm));
            this.groupControlInsert = new DevExpress.XtraEditors.GroupControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNewItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNewDes = new DevExpress.XtraEditors.MemoEdit();
            this.groupControlUpdate = new DevExpress.XtraEditors.GroupControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditDes = new DevExpress.XtraEditors.MemoEdit();
            this.groupControlSelect = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInsert)).BeginInit();
            this.groupControlInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdate)).BeginInit();
            this.groupControlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSelect)).BeginInit();
            this.groupControlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlInsert
            // 
            this.groupControlInsert.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlInsert.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlInsert.Controls.Add(this.BtnAdd);
            this.groupControlInsert.Controls.Add(this.labelControl5);
            this.groupControlInsert.Controls.Add(this.TxtNewItem);
            this.groupControlInsert.Controls.Add(this.labelControl3);
            this.groupControlInsert.Controls.Add(this.TxtNewDes);
            this.groupControlInsert.Location = new System.Drawing.Point(9, 221);
            this.groupControlInsert.Name = "groupControlInsert";
            this.groupControlInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControlInsert.Size = new System.Drawing.Size(379, 140);
            this.groupControlInsert.TabIndex = 5;
            this.groupControlInsert.Text = "اضافة سماحيه جديده";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(126, 108);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(238, 51);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "تعليق";
            // 
            // TxtNewItem
            // 
            this.TxtNewItem.Location = new System.Drawing.Point(59, 24);
            this.TxtNewItem.Name = "TxtNewItem";
            this.TxtNewItem.Properties.MaxLength = 100;
            this.TxtNewItem.Size = new System.Drawing.Size(173, 20);
            this.TxtNewItem.TabIndex = 5;
            this.TxtNewItem.EditValueChanged += new System.EventHandler(this.TxtNewItem_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(238, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "اسم السماحيه";
            // 
            // TxtNewDes
            // 
            this.TxtNewDes.Location = new System.Drawing.Point(59, 49);
            this.TxtNewDes.Name = "TxtNewDes";
            this.TxtNewDes.Properties.MaxLength = 250;
            this.TxtNewDes.Size = new System.Drawing.Size(173, 53);
            this.TxtNewDes.TabIndex = 6;
            this.TxtNewDes.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // groupControlUpdate
            // 
            this.groupControlUpdate.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlUpdate.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlUpdate.Controls.Add(this.BtnUpdate);
            this.groupControlUpdate.Controls.Add(this.labelControl4);
            this.groupControlUpdate.Controls.Add(this.TxtEditItem);
            this.groupControlUpdate.Controls.Add(this.labelControl2);
            this.groupControlUpdate.Controls.Add(this.TxtEditDes);
            this.groupControlUpdate.Location = new System.Drawing.Point(9, 75);
            this.groupControlUpdate.Name = "groupControlUpdate";
            this.groupControlUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControlUpdate.Size = new System.Drawing.Size(379, 140);
            this.groupControlUpdate.TabIndex = 2;
            this.groupControlUpdate.Text = "تعديل السماحيه";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(126, 108);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "تعديل";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(242, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "تعليق";
            // 
            // TxtEditItem
            // 
            this.TxtEditItem.Location = new System.Drawing.Point(63, 24);
            this.TxtEditItem.Name = "TxtEditItem";
            this.TxtEditItem.Properties.MaxLength = 100;
            this.TxtEditItem.Size = new System.Drawing.Size(173, 20);
            this.TxtEditItem.TabIndex = 2;
            this.TxtEditItem.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(242, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تعديل الاسم";
            // 
            // TxtEditDes
            // 
            this.TxtEditDes.Location = new System.Drawing.Point(63, 49);
            this.TxtEditDes.Name = "TxtEditDes";
            this.TxtEditDes.Properties.MaxLength = 250;
            this.TxtEditDes.Size = new System.Drawing.Size(173, 53);
            this.TxtEditDes.TabIndex = 3;
            this.TxtEditDes.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // groupControlSelect
            // 
            this.groupControlSelect.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlSelect.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlSelect.Controls.Add(this.BtnDelete);
            this.groupControlSelect.Controls.Add(this.LUEItems);
            this.groupControlSelect.Controls.Add(this.labelControl1);
            this.groupControlSelect.Location = new System.Drawing.Point(9, 10);
            this.groupControlSelect.Name = "groupControlSelect";
            this.groupControlSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControlSelect.Size = new System.Drawing.Size(379, 59);
            this.groupControlSelect.TabIndex = 0;
            this.groupControlSelect.Text = "جميع السماحيات";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnDelete.Location = new System.Drawing.Point(38, 25);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(44, 22);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LUEItems
            // 
            this.LUEItems.Location = new System.Drawing.Point(88, 28);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "اسم الصلاحيه", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleDesc", "تعليق", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEItems.Size = new System.Drawing.Size(173, 20);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(267, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختار سماحيه";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(395, 63);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 241);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // RolesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 366);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControlInsert);
            this.Controls.Add(this.groupControlUpdate);
            this.Controls.Add(this.groupControlSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RolesFrm";
            this.Text = "السماحيات";
            this.Load += new System.EventHandler(this.EditorJobFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInsert)).EndInit();
            this.groupControlInsert.ResumeLayout(false);
            this.groupControlInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdate)).EndInit();
            this.groupControlUpdate.ResumeLayout(false);
            this.groupControlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditDes.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit TxtNewItem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControlUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit TxtEditItem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControlSelect;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit TxtNewDes;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit TxtEditDes;
    }
}