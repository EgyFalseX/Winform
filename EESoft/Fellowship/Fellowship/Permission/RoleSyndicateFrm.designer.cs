namespace RetirementCenter.Forms.Data
{
    partial class RoleSyndicateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleSyndicateFrm));
            this.groupControlUpdate = new DevExpress.XtraEditors.GroupControl();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.CLSCRole = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlSelect = new DevExpress.XtraEditors.GroupControl();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdate)).BeginInit();
            this.groupControlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLSCRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSelect)).BeginInit();
            this.groupControlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlUpdate
            // 
            this.groupControlUpdate.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlUpdate.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlUpdate.Controls.Add(this.TxtNote);
            this.groupControlUpdate.Controls.Add(this.CLSCRole);
            this.groupControlUpdate.Controls.Add(this.BtnUpdate);
            this.groupControlUpdate.Controls.Add(this.labelControl2);
            this.groupControlUpdate.Location = new System.Drawing.Point(9, 75);
            this.groupControlUpdate.Name = "groupControlUpdate";
            this.groupControlUpdate.Size = new System.Drawing.Size(379, 272);
            this.groupControlUpdate.TabIndex = 8;
            this.groupControlUpdate.Text = "تعديل الفرعيات السماحية";
            // 
            // TxtNote
            // 
            this.TxtNote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNote.ForeColor = System.Drawing.Color.Green;
            this.TxtNote.Location = new System.Drawing.Point(5, 24);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ReadOnly = true;
            this.TxtNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtNote.Size = new System.Drawing.Size(140, 207);
            this.TxtNote.TabIndex = 7;
            this.TxtNote.Text = "يمكنك تعديل او حذف فرعيات السماحية المختارة";
            // 
            // CLSCRole
            // 
            this.CLSCRole.Location = new System.Drawing.Point(151, 24);
            this.CLSCRole.Name = "CLSCRole";
            this.CLSCRole.Size = new System.Drawing.Size(155, 207);
            this.CLSCRole.TabIndex = 4;
            this.CLSCRole.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.CLSCRole_ItemCheck);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(196, 237);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "تعديل";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(312, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "الفرعيات";
            // 
            // groupControlSelect
            // 
            this.groupControlSelect.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlSelect.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlSelect.Controls.Add(this.LUEItems);
            this.groupControlSelect.Controls.Add(this.labelControl1);
            this.groupControlSelect.Location = new System.Drawing.Point(9, 10);
            this.groupControlSelect.Name = "groupControlSelect";
            this.groupControlSelect.Size = new System.Drawing.Size(379, 59);
            this.groupControlSelect.TabIndex = 7;
            this.groupControlSelect.Text = "جميع المستخدمين";
            // 
            // LUEItems
            // 
            this.LUEItems.Location = new System.Drawing.Point(61, 28);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEItems.Size = new System.Drawing.Size(173, 20);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(240, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختر سماحية";
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
            // RoleSyndicateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 355);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControlUpdate);
            this.Controls.Add(this.groupControlSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RoleSyndicateFrm";
            this.Text = "فرعيات السماحيات";
            this.Load += new System.EventHandler(this.EditorJobFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdate)).EndInit();
            this.groupControlUpdate.ResumeLayout(false);
            this.groupControlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLSCRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSelect)).EndInit();
            this.groupControlSelect.ResumeLayout(false);
            this.groupControlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControlUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControlSelect;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl CLSCRole;
        private System.Windows.Forms.TextBox TxtNote;
    }
}