namespace RetirementCenter.Forms.Main
{
    partial class AppOptionsFrm
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
            this.components = new System.ComponentModel.Container();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneralOptions = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            this.appOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.appOptionsTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.AppOptionsTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbEshtrak = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbRasm = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageGeneralOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEshtrak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRasm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControlMain.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControlMain.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageGeneralOptions;
            this.xtraTabControlMain.Size = new System.Drawing.Size(625, 166);
            this.xtraTabControlMain.TabIndex = 0;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneralOptions});
            // 
            // xtraTabPageGeneralOptions
            // 
            this.xtraTabPageGeneralOptions.Controls.Add(this.groupControl3);
            this.xtraTabPageGeneralOptions.Controls.Add(this.labelControl1);
            this.xtraTabPageGeneralOptions.Controls.Add(this.peLogo);
            this.xtraTabPageGeneralOptions.Controls.Add(this.groupControl2);
            this.xtraTabPageGeneralOptions.Name = "xtraTabPageGeneralOptions";
            this.xtraTabPageGeneralOptions.Size = new System.Drawing.Size(619, 138);
            this.xtraTabPageGeneralOptions.Text = "خيارات عامة";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(80, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "الشعار";
            // 
            // peLogo
            // 
            this.peLogo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appOptionsBindingSource, "CompanyLogo", true));
            this.peLogo.Location = new System.Drawing.Point(11, 35);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peLogo.Size = new System.Drawing.Size(100, 96);
            this.peLogo.TabIndex = 4;
            // 
            // appOptionsBindingSource
            // 
            this.appOptionsBindingSource.DataMember = "AppOptions";
            this.appOptionsBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsTeachersUnion";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.tbEshtrak);
            this.groupControl2.Location = new System.Drawing.Point(201, 11);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupControl2.Size = new System.Drawing.Size(411, 47);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "اشتراك";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 171);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(625, 64);
            this.groupControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // appOptionsTableAdapter
            // 
            this.appOptionsTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(372, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "اشتراك";
            // 
            // tbEshtrak
            // 
            this.tbEshtrak.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appOptionsBindingSource, "Eshtrak", true));
            this.tbEshtrak.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbEshtrak.Location = new System.Drawing.Point(2, 21);
            this.tbEshtrak.Name = "tbEshtrak";
            this.tbEshtrak.Size = new System.Drawing.Size(367, 20);
            this.tbEshtrak.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.tbRasm);
            this.groupControl3.Location = new System.Drawing.Point(201, 64);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupControl3.Size = new System.Drawing.Size(411, 47);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "رسم";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(383, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "رسم";
            // 
            // tbRasm
            // 
            this.tbRasm.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appOptionsBindingSource, "Rasm", true));
            this.tbRasm.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbRasm.Location = new System.Drawing.Point(2, 21);
            this.tbRasm.Name = "tbRasm";
            this.tbRasm.Size = new System.Drawing.Size(367, 20);
            this.tbRasm.TabIndex = 0;
            // 
            // AppOptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 235);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.xtraTabControlMain);
            this.Name = "AppOptionsFrm";
            this.Text = "خيارات";
            this.Load += new System.EventHandler(this.AppOptionsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageGeneralOptions.ResumeLayout(false);
            this.xtraTabPageGeneralOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appOptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbEshtrak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRasm.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGeneralOptions;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DataSources.dsRetirementCenterTableAdapters.AppOptionsTableAdapter appOptionsTableAdapter;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource appOptionsBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbRasm;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbEshtrak;
    }
}