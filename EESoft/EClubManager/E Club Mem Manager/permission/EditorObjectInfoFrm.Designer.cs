namespace E_Club_Mem_Manager
{
    partial class EditorObjectInfoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorObjectInfoFrm));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.TxtAddDes = new DevExpress.XtraEditors.MemoEdit();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.LUEAddCodeName = new DevExpress.XtraEditors.LookUpEdit();
            this.LUEAddMenu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TxtEditDes = new DevExpress.XtraEditors.MemoEdit();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.LUEEditCodeName = new DevExpress.XtraEditors.LookUpEdit();
            this.LUEEditMenu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEAddCodeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEAddMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEditCodeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEditMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.TxtAddDes);
            this.groupControl3.Controls.Add(this.BtnAdd);
            this.groupControl3.Controls.Add(this.LUEAddCodeName);
            this.groupControl3.Controls.Add(this.LUEAddMenu);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.TxtAddItem);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Location = new System.Drawing.Point(12, 325);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(379, 246);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "اضافة عنصر جديــده";
            // 
            // TxtAddDes
            // 
            this.TxtAddDes.Location = new System.Drawing.Point(17, 100);
            this.TxtAddDes.Name = "TxtAddDes";
            this.TxtAddDes.Size = new System.Drawing.Size(208, 110);
            this.TxtAddDes.TabIndex = 10;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(115, 216);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "حفـــــظ";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LUEAddCodeName
            // 
            this.LUEAddCodeName.Location = new System.Drawing.Point(17, 49);
            this.LUEAddCodeName.Name = "LUEAddCodeName";
            this.LUEAddCodeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEAddCodeName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("menutext", "اسم النافذه")});
            this.LUEAddCodeName.Properties.NullText = "";
            this.LUEAddCodeName.Properties.NullValuePrompt = "اختـــار";
            this.LUEAddCodeName.Size = new System.Drawing.Size(208, 19);
            this.LUEAddCodeName.TabIndex = 8;
            this.LUEAddCodeName.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // LUEAddMenu
            // 
            this.LUEAddMenu.Location = new System.Drawing.Point(17, 24);
            this.LUEAddMenu.Name = "LUEAddMenu";
            this.LUEAddMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEAddMenu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ObjectTypeName", "اسم القائمه")});
            this.LUEAddMenu.Properties.NullText = "";
            this.LUEAddMenu.Properties.NullValuePrompt = "اختـــار";
            this.LUEAddMenu.Size = new System.Drawing.Size(208, 19);
            this.LUEAddMenu.TabIndex = 7;
            this.LUEAddMenu.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(264, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تعديل الاسم";
            // 
            // TxtAddItem
            // 
            this.TxtAddItem.Location = new System.Drawing.Point(17, 74);
            this.TxtAddItem.Name = "TxtAddItem";
            this.TxtAddItem.Properties.MaxLength = 15;
            this.TxtAddItem.Size = new System.Drawing.Size(208, 19);
            this.TxtAddItem.TabIndex = 9;
            this.TxtAddItem.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(272, 52);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "اسم النافذه";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(242, 102);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "تعديل المعلومات";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(267, 27);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "اسم القائمه";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtEditDes);
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.LUEEditCodeName);
            this.groupControl2.Controls.Add(this.LUEEditMenu);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.TxtEditItem);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(9, 75);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 244);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "تعديل عنصر";
            // 
            // TxtEditDes
            // 
            this.TxtEditDes.Location = new System.Drawing.Point(20, 100);
            this.TxtEditDes.Name = "TxtEditDes";
            this.TxtEditDes.Size = new System.Drawing.Size(208, 110);
            this.TxtEditDes.TabIndex = 5;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(118, 216);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "حفـــــظ";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LUEEditCodeName
            // 
            this.LUEEditCodeName.Location = new System.Drawing.Point(20, 49);
            this.LUEEditCodeName.Name = "LUEEditCodeName";
            this.LUEEditCodeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEditCodeName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("menutext", "اسم النافذه")});
            this.LUEEditCodeName.Properties.NullText = "";
            this.LUEEditCodeName.Properties.NullValuePrompt = "اختـــار";
            this.LUEEditCodeName.Size = new System.Drawing.Size(208, 19);
            this.LUEEditCodeName.TabIndex = 3;
            this.LUEEditCodeName.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // LUEEditMenu
            // 
            this.LUEEditMenu.Location = new System.Drawing.Point(20, 24);
            this.LUEEditMenu.Name = "LUEEditMenu";
            this.LUEEditMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEditMenu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ObjectTypeName", "اسم القائمه")});
            this.LUEEditMenu.Properties.NullText = "";
            this.LUEEditMenu.Properties.NullValuePrompt = "اختـــار";
            this.LUEEditMenu.Size = new System.Drawing.Size(208, 19);
            this.LUEEditMenu.TabIndex = 2;
            this.LUEEditMenu.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(275, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "اسم النافذه";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(270, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "اسم القائمه";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(245, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "تعديل المعلومات";
            // 
            // TxtEditItem
            // 
            this.TxtEditItem.Location = new System.Drawing.Point(20, 74);
            this.TxtEditItem.Name = "TxtEditItem";
            this.TxtEditItem.Properties.MaxLength = 15;
            this.TxtEditItem.Size = new System.Drawing.Size(208, 19);
            this.TxtEditItem.TabIndex = 4;
            this.TxtEditItem.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(267, 77);
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
            this.groupControl1.Text = "جميع اسماء العناصر";
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ObjectName", "اسم العنصر")});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Properties.NullValuePrompt = "اختـــار";
            this.LUEItems.Size = new System.Drawing.Size(173, 19);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(267, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع العناصر";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(395, 169);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 241);
            this.BtnRefresh.TabIndex = 12;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // EditorObjectInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 578);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorObjectInfoFrm";
            this.Text = "انواع العناصـــر";
            this.Load += new System.EventHandler(this.EditorObjectInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEAddCodeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEAddMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEditCodeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEditMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LookUpEdit LUEEditMenu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit TxtEditDes;
        private DevExpress.XtraEditors.MemoEdit TxtAddDes;
        private DevExpress.XtraEditors.LookUpEdit LUEAddMenu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAddItem;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit LUEAddCodeName;
        private DevExpress.XtraEditors.LookUpEdit LUEEditCodeName;
    }
}