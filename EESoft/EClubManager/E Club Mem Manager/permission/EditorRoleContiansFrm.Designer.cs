namespace E_Club_Mem_Manager
{
    partial class EditorRoleContiansFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorRoleContiansFrm));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.CLSCItem = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LUERoles = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLSCItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUERoles.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtNote);
            this.groupControl2.Controls.Add(this.CLSCItem);
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(9, 75);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 272);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "القدرات";
            // 
            // TxtNote
            // 
            this.TxtNote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNote.ForeColor = System.Drawing.Color.Green;
            this.TxtNote.Location = new System.Drawing.Point(234, 50);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ReadOnly = true;
            this.TxtNote.Size = new System.Drawing.Size(140, 188);
            this.TxtNote.TabIndex = 6;
            this.TxtNote.Text = ".";
            // 
            // CLSCItem
            // 
            this.CLSCItem.Location = new System.Drawing.Point(55, 31);
            this.CLSCItem.Name = "CLSCItem";
            this.CLSCItem.Size = new System.Drawing.Size(173, 207);
            this.CLSCItem.TabIndex = 4;
            this.CLSCItem.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.CLSCItem_ItemCheck);
            this.CLSCItem.SelectedIndexChanged += new System.EventHandler(this.CLSCItem_SelectedIndexChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(118, 244);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "حفـــــظ";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(277, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "انواع العناصر";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LUERoles);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(9, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 59);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "جميع اسماء الصلاحيات";
            // 
            // LUERoles
            // 
            this.LUERoles.Location = new System.Drawing.Point(55, 28);
            this.LUERoles.Name = "LUERoles";
            this.LUERoles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUERoles.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "اسماء الصلاحيه"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleDesc", "معلومه توضيحيه")});
            this.LUERoles.Properties.NullText = "";
            this.LUERoles.Properties.NullValuePrompt = "اختـــار";
            this.LUERoles.Size = new System.Drawing.Size(173, 19);
            this.LUERoles.TabIndex = 0;
            this.LUERoles.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(253, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع الصلاحيات";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(395, 57);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 241);
            this.BtnRefresh.TabIndex = 10;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // EditorRoleContiansFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 355);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorRoleContiansFrm";
            this.Text = "قدرات الصلاحيات";
            this.Load += new System.EventHandler(this.EditorRoleContiansFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLSCItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUERoles.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit LUERoles;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl CLSCItem;
        private System.Windows.Forms.TextBox TxtNote;
    }
}