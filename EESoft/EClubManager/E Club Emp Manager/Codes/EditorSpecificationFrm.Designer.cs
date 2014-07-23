namespace E_Club_Emp_Manager
{
    partial class EditorSpecificationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorSpecificationFrm));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNewItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.LUEItemsParents = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItemsParents.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnAdd);
            this.groupControl3.Controls.Add(this.TxtNewItem);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(8, 231);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(379, 85);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "اضافة تخصص جديــده";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(118, 53);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "حفـــــظ";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtNewItem
            // 
            this.TxtNewItem.Location = new System.Drawing.Point(55, 28);
            this.TxtNewItem.Name = "TxtNewItem";
            this.TxtNewItem.Properties.MaxLength = 15;
            this.TxtNewItem.Size = new System.Drawing.Size(173, 19);
            this.TxtNewItem.TabIndex = 5;
            this.TxtNewItem.EditValueChanged += new System.EventHandler(this.TxtNewItem_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(265, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "اسم التخصص";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.TxtEditItem);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(8, 140);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 85);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "تعديل اسم تخصص";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(118, 53);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "حفـــــظ";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtEditItem
            // 
            this.TxtEditItem.Location = new System.Drawing.Point(55, 28);
            this.TxtEditItem.Name = "TxtEditItem";
            this.TxtEditItem.Properties.MaxLength = 15;
            this.TxtEditItem.Size = new System.Drawing.Size(173, 19);
            this.TxtEditItem.TabIndex = 3;
            this.TxtEditItem.EditValueChanged += new System.EventHandler(this.TxtEditItem_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(269, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تعديل الاسم";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.LUEItemsParents);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Location = new System.Drawing.Point(8, 10);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(379, 59);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "جميع اسماء المؤهــلات";
            // 
            // LUEItemsParents
            // 
            this.LUEItemsParents.Location = new System.Drawing.Point(55, 28);
            this.LUEItemsParents.Name = "LUEItemsParents";
            this.LUEItemsParents.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItemsParents.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moaahel_ID", "Moaahel_ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moaahel_Name", "اسماء المؤهــلات")});
            this.LUEItemsParents.Properties.NullText = "";
            this.LUEItemsParents.Size = new System.Drawing.Size(173, 19);
            this.LUEItemsParents.TabIndex = 0;
            this.LUEItemsParents.EditValueChanged += new System.EventHandler(this.LUEItemsParents_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(257, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "جميع المؤهــلات";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.LUEItems);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(8, 75);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 59);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "جميع اسماء تخصص المـؤهــلات";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnDelete.Location = new System.Drawing.Point(6, 26);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(44, 22);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LUEItems
            // 
            this.LUEItems.Location = new System.Drawing.Point(55, 28);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPECIFICATION_ID", "SPECIFICATION_ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPECIFICATION_NAME", "اسماء الوصـــف")});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Size = new System.Drawing.Size(173, 19);
            this.LUEItems.TabIndex = 1;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(245, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع التخصصات";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(393, 10);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 306);
            this.BtnRefresh.TabIndex = 12;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // EditorSpecificationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 327);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorSpecificationFrm";
            this.Text = "تخصص المؤهــلات";
            this.Load += new System.EventHandler(this.EditorSpecificationFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItemsParents.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit TxtNewItem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit TxtEditItem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LookUpEdit LUEItemsParents;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}