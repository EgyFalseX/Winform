namespace schoolStore
{
    partial class CD_AsaseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CD_AsaseFrm));
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tbnameadd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbcodeadd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.tbcodeedit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbnameedit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnameadd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcodeadd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcodeedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnameedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(395, 10);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 313);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.BtnAdd);
            this.groupControl3.Controls.Add(this.tbnameadd);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.tbcodeadd);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(9, 211);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(379, 112);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "اضافه";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(118, 80);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "حفـــــظ";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbnameadd
            // 
            this.tbnameadd.Location = new System.Drawing.Point(55, 54);
            this.tbnameadd.Name = "tbnameadd";
            this.tbnameadd.Properties.MaxLength = 50;
            this.tbnameadd.Size = new System.Drawing.Size(173, 20);
            this.tbnameadd.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(251, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "اسم جديد";
            // 
            // tbcodeadd
            // 
            this.tbcodeadd.Location = new System.Drawing.Point(55, 28);
            this.tbcodeadd.Name = "tbcodeadd";
            this.tbcodeadd.Properties.DisplayFormat.FormatString = "n0";
            this.tbcodeadd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbcodeadd.Properties.EditFormat.FormatString = "n0";
            this.tbcodeadd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbcodeadd.Properties.Mask.EditMask = "n0";
            this.tbcodeadd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbcodeadd.Properties.MaxLength = 50;
            this.tbcodeadd.Size = new System.Drawing.Size(173, 20);
            this.tbcodeadd.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(251, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "كود جديد";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.tbcodeedit);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.tbnameedit);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(9, 75);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 114);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "تعديل";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(118, 86);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "حفـــــظ";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tbcodeedit
            // 
            this.tbcodeedit.Location = new System.Drawing.Point(55, 34);
            this.tbcodeedit.Name = "tbcodeedit";
            this.tbcodeedit.Properties.DisplayFormat.FormatString = "n0";
            this.tbcodeedit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbcodeedit.Properties.EditFormat.FormatString = "n0";
            this.tbcodeedit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbcodeedit.Properties.Mask.EditMask = "n0";
            this.tbcodeedit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbcodeedit.Properties.MaxLength = 50;
            this.tbcodeedit.Size = new System.Drawing.Size(173, 20);
            this.tbcodeedit.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(249, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "تعديل الكود";
            // 
            // tbnameedit
            // 
            this.tbnameedit.Location = new System.Drawing.Point(55, 60);
            this.tbnameedit.Name = "tbnameedit";
            this.tbnameedit.Properties.MaxLength = 50;
            this.tbnameedit.Size = new System.Drawing.Size(173, 20);
            this.tbnameedit.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(249, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تعديل الاسم";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.LUEItems);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(9, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 59);
            this.groupControl1.TabIndex = 0;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("asase_code", 40, "الكود"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("asase_year", 40, "الاسم")});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Properties.NullValuePrompt = "اختـــار";
            this.LUEItems.Size = new System.Drawing.Size(173, 20);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(245, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختار عام";
            // 
            // CD_AsaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 330);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CD_AsaseFrm";
            this.Text = "العام الدراسي";
            this.Load += new System.EventHandler(this.EditorEducationFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnameadd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcodeadd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcodeedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnameedit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit tbcodeadd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit tbnameedit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbnameadd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbcodeedit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}