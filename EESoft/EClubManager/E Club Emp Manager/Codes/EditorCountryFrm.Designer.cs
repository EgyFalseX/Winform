namespace E_Club_Emp_Manager
{
    partial class EditorCountryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorCountryFrm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUECities = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditCity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNewCity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUECities.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewCity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.LUECities);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 59);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "جميع المحافظــات المضافه";
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
            // LUECities
            // 
            this.LUECities.Location = new System.Drawing.Point(55, 28);
            this.LUECities.Name = "LUECities";
            this.LUECities.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUECities.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GOV_ID", "GOV_ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GOV_NAME", "اسماء المحافظات")});
            this.LUECities.Properties.NullText = "";
            this.LUECities.Size = new System.Drawing.Size(173, 19);
            this.LUECities.TabIndex = 0;
            this.LUECities.EditValueChanged += new System.EventHandler(this.LUECities_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(234, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع المحافظات";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnUpdate);
            this.groupControl2.Controls.Add(this.TxtEditCity);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(12, 77);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(379, 85);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "تعديل اسم محافظــــه";
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
            // TxtEditCity
            // 
            this.TxtEditCity.Location = new System.Drawing.Point(55, 28);
            this.TxtEditCity.Name = "TxtEditCity";
            this.TxtEditCity.Properties.MaxLength = 15;
            this.TxtEditCity.Size = new System.Drawing.Size(173, 19);
            this.TxtEditCity.TabIndex = 2;
            this.TxtEditCity.EditValueChanged += new System.EventHandler(this.TxtEditCity_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(249, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تعديل الاسم";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnAdd);
            this.groupControl3.Controls.Add(this.TxtNewCity);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(12, 168);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(379, 85);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "اضافة محافظــه جديــده";
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
            // TxtNewCity
            // 
            this.TxtNewCity.Location = new System.Drawing.Point(55, 28);
            this.TxtNewCity.Name = "TxtNewCity";
            this.TxtNewCity.Properties.MaxLength = 15;
            this.TxtNewCity.Size = new System.Drawing.Size(173, 19);
            this.TxtNewCity.TabIndex = 4;
            this.TxtNewCity.EditValueChanged += new System.EventHandler(this.TxtNewCity_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(242, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "اسم المحافظــه";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(398, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 241);
            this.BtnRefresh.TabIndex = 6;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // EditorCountryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorCountryFrm";
            this.Text = "المحافظـــــات";
            this.Load += new System.EventHandler(this.AddCountryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUECities.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewCity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit LUECities;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.TextEdit TxtEditCity;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.TextEdit TxtNewCity;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
    }
}