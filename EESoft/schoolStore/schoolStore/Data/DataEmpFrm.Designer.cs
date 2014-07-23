namespace schoolStore
{
    partial class DataEmpFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEmpFrm));
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.LUEJob = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNewAddress = new DevExpress.XtraEditors.TextEdit();
            this.TxtNewTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNewNID = new DevExpress.XtraEditors.TextEdit();
            this.TxtNewMobil = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNewName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.LUEEditJob = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditAddress = new DevExpress.XtraEditors.TextEdit();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditTel = new DevExpress.XtraEditors.TextEdit();
            this.TxtEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditNID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditMobil = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEJob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewNID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewMobil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEditJob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditNID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditMobil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(397, 111);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 233);
            this.BtnRefresh.TabIndex = 26;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.LUEJob);
            this.groupControl3.Controls.Add(this.BtnAdd);
            this.groupControl3.Controls.Add(this.TxtNewAddress);
            this.groupControl3.Controls.Add(this.TxtNewTel);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.TxtNewNID);
            this.groupControl3.Controls.Add(this.TxtNewMobil);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.TxtNewName);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(12, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(379, 209);
            this.groupControl3.TabIndex = 25;
            this.groupControl3.Text = "اضافة موظف جديــده";
            // 
            // LUEJob
            // 
            this.LUEJob.Location = new System.Drawing.Point(55, 78);
            this.LUEJob.Name = "LUEJob";
            this.LUEJob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEJob.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JOBNAME", "اسم الوظيفه")});
            this.LUEJob.Properties.NullText = "";
            this.LUEJob.Properties.NullValuePrompt = "اختـــار وظيفه";
            this.LUEJob.Size = new System.Drawing.Size(173, 19);
            this.LUEJob.TabIndex = 10;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(118, 178);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "حفـــــظ";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtNewAddress
            // 
            this.TxtNewAddress.Location = new System.Drawing.Point(55, 153);
            this.TxtNewAddress.Name = "TxtNewAddress";
            this.TxtNewAddress.Properties.MaxLength = 100;
            this.TxtNewAddress.Size = new System.Drawing.Size(173, 19);
            this.TxtNewAddress.TabIndex = 5;
            // 
            // TxtNewTel
            // 
            this.TxtNewTel.Location = new System.Drawing.Point(55, 103);
            this.TxtNewTel.Name = "TxtNewTel";
            this.TxtNewTel.Properties.MaxLength = 100;
            this.TxtNewTel.Size = new System.Drawing.Size(173, 19);
            this.TxtNewTel.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(287, 156);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(26, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "عنوان";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(284, 106);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "تليفون";
            // 
            // TxtNewNID
            // 
            this.TxtNewNID.Location = new System.Drawing.Point(55, 53);
            this.TxtNewNID.Name = "TxtNewNID";
            this.TxtNewNID.Properties.MaxLength = 14;
            this.TxtNewNID.Size = new System.Drawing.Size(173, 19);
            this.TxtNewNID.TabIndex = 1;
            // 
            // TxtNewMobil
            // 
            this.TxtNewMobil.Location = new System.Drawing.Point(55, 128);
            this.TxtNewMobil.Name = "TxtNewMobil";
            this.TxtNewMobil.Properties.MaxLength = 14;
            this.TxtNewMobil.Size = new System.Drawing.Size(173, 19);
            this.TxtNewMobil.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(281, 131);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "محمول";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(252, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "الرقم القومي";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(279, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "الوظيفه";
            // 
            // TxtNewName
            // 
            this.TxtNewName.Location = new System.Drawing.Point(55, 28);
            this.TxtNewName.Name = "TxtNewName";
            this.TxtNewName.Properties.MaxLength = 50;
            this.TxtNewName.Size = new System.Drawing.Size(173, 19);
            this.TxtNewName.TabIndex = 0;
            this.TxtNewName.EditValueChanged += new System.EventHandler(this.TxtNewName_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(253, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "اسم الموظف";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.LUEEditJob);
            this.groupControl2.Controls.Add(this.BtnDelete);
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.TxtEditAddress);
            this.groupControl2.Controls.Add(this.LUEItems);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.TxtEditTel);
            this.groupControl2.Controls.Add(this.TxtEditName);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.TxtEditNID);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.TxtEditMobil);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Location = new System.Drawing.Point(12, 227);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 230);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "تعديل اسم موظف";
            // 
            // LUEEditJob
            // 
            this.LUEEditJob.Location = new System.Drawing.Point(55, 101);
            this.LUEEditJob.Name = "LUEEditJob";
            this.LUEEditJob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEditJob.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JOBNAME", "اسم الوظيفه")});
            this.LUEEditJob.Properties.NullText = "";
            this.LUEEditJob.Properties.NullValuePrompt = "اختـــار وظيفه";
            this.LUEEditJob.Size = new System.Drawing.Size(173, 19);
            this.LUEEditJob.TabIndex = 20;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnDelete.Location = new System.Drawing.Point(5, 24);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(44, 22);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(118, 201);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "حفـــــظ";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtEditAddress
            // 
            this.TxtEditAddress.Location = new System.Drawing.Point(55, 176);
            this.TxtEditAddress.Name = "TxtEditAddress";
            this.TxtEditAddress.Properties.MaxLength = 100;
            this.TxtEditAddress.Size = new System.Drawing.Size(173, 19);
            this.TxtEditAddress.TabIndex = 16;
            // 
            // LUEItems
            // 
            this.LUEItems.Location = new System.Drawing.Point(55, 26);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNAME", "اسم الموظف"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JOBNAME", "اسم الوظيفه")});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Properties.NullValuePrompt = "اختـــار محافظــه";
            this.LUEItems.Size = new System.Drawing.Size(173, 19);
            this.LUEItems.TabIndex = 9;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(246, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع الموظفين";
            // 
            // TxtEditTel
            // 
            this.TxtEditTel.Location = new System.Drawing.Point(55, 126);
            this.TxtEditTel.Name = "TxtEditTel";
            this.TxtEditTel.Properties.MaxLength = 100;
            this.TxtEditTel.Size = new System.Drawing.Size(173, 19);
            this.TxtEditTel.TabIndex = 14;
            // 
            // TxtEditName
            // 
            this.TxtEditName.Location = new System.Drawing.Point(55, 51);
            this.TxtEditName.Name = "TxtEditName";
            this.TxtEditName.Properties.MaxLength = 50;
            this.TxtEditName.Size = new System.Drawing.Size(173, 19);
            this.TxtEditName.TabIndex = 11;
            this.TxtEditName.EditValueChanged += new System.EventHandler(this.TxtEditName_EditValueChanged);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(290, 179);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(26, 13);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "عنوان";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(256, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "اسم الموظف";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(287, 129);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(29, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "تليفون";
            // 
            // TxtEditNID
            // 
            this.TxtEditNID.Location = new System.Drawing.Point(55, 76);
            this.TxtEditNID.Name = "TxtEditNID";
            this.TxtEditNID.Properties.MaxLength = 50;
            this.TxtEditNID.Size = new System.Drawing.Size(173, 19);
            this.TxtEditNID.TabIndex = 12;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(282, 104);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(34, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "الوظيفه";
            // 
            // TxtEditMobil
            // 
            this.TxtEditMobil.Location = new System.Drawing.Point(55, 151);
            this.TxtEditMobil.Name = "TxtEditMobil";
            this.TxtEditMobil.Properties.MaxLength = 14;
            this.TxtEditMobil.Size = new System.Drawing.Size(173, 19);
            this.TxtEditMobil.TabIndex = 15;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(255, 79);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "الرقم القومي";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(284, 154);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(32, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "محمول";
            // 
            // DataEmpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 463);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DataEmpFrm";
            this.Text = "الموظفين";
            this.Load += new System.EventHandler(this.DataEmpFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEJob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewNID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewMobil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEditJob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditNID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditMobil.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.TextEdit TxtNewAddress;
        private DevExpress.XtraEditors.TextEdit TxtNewTel;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtNewNID;
        private DevExpress.XtraEditors.TextEdit TxtNewMobil;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtNewName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit TxtEditAddress;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtEditTel;
        private DevExpress.XtraEditors.TextEdit TxtEditName;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit TxtEditNID;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtEditMobil;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit LUEJob;
        private DevExpress.XtraEditors.LookUpEdit LUEEditJob;
    }
}