namespace Retirement.Forms.Main
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneralOptions = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            this.appOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Retirement.DataSources.dsTeachersUnion();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.beimgpathweb = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.beMandoopImgpath = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.beattachpath = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.beimgpath = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.appOptionsTableAdapter = new Retirement.DataSources.dsTeachersUnionTableAdapters.AppOptionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageGeneralOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beimgpathweb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beMandoopImgpath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beattachpath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beimgpath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.xtraTabControlMain.Size = new System.Drawing.Size(625, 292);
            this.xtraTabControlMain.TabIndex = 0;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneralOptions});
            // 
            // xtraTabPageGeneralOptions
            // 
            this.xtraTabPageGeneralOptions.Controls.Add(this.labelControl1);
            this.xtraTabPageGeneralOptions.Controls.Add(this.peLogo);
            this.xtraTabPageGeneralOptions.Controls.Add(this.groupControl5);
            this.xtraTabPageGeneralOptions.Controls.Add(this.groupControl4);
            this.xtraTabPageGeneralOptions.Controls.Add(this.groupControl3);
            this.xtraTabPageGeneralOptions.Controls.Add(this.groupControl2);
            this.xtraTabPageGeneralOptions.Name = "xtraTabPageGeneralOptions";
            this.xtraTabPageGeneralOptions.Size = new System.Drawing.Size(619, 264);
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
            this.appOptionsBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl5
            // 
            this.groupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl5.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl5.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl5.Controls.Add(this.beimgpathweb);
            this.groupControl5.Location = new System.Drawing.Point(201, 188);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupControl5.Size = new System.Drawing.Size(411, 53);
            this.groupControl5.TabIndex = 3;
            this.groupControl5.Text = "مسار صور الويب";
            // 
            // beimgpathweb
            // 
            this.beimgpathweb.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appOptionsBindingSource, "imgpathweb", true));
            this.beimgpathweb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beimgpathweb.Location = new System.Drawing.Point(2, 21);
            this.beimgpathweb.Name = "beimgpathweb";
            this.beimgpathweb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 50, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.beimgpathweb.Size = new System.Drawing.Size(407, 20);
            this.beimgpathweb.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl4.Controls.Add(this.beMandoopImgpath);
            this.groupControl4.Location = new System.Drawing.Point(201, 129);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupControl4.Size = new System.Drawing.Size(411, 53);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "مسار صور المندوبين";
            // 
            // beMandoopImgpath
            // 
            this.beMandoopImgpath.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appOptionsBindingSource, "MandoopImgpath", true));
            this.beMandoopImgpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beMandoopImgpath.Location = new System.Drawing.Point(2, 21);
            this.beMandoopImgpath.Name = "beMandoopImgpath";
            this.beMandoopImgpath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 50, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.beMandoopImgpath.Size = new System.Drawing.Size(407, 20);
            this.beMandoopImgpath.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl3.Controls.Add(this.beattachpath);
            this.groupControl3.Location = new System.Drawing.Point(201, 70);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupControl3.Size = new System.Drawing.Size(411, 53);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "مسار المرفقات";
            // 
            // beattachpath
            // 
            this.beattachpath.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appOptionsBindingSource, "attachpath", true));
            this.beattachpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beattachpath.Location = new System.Drawing.Point(2, 21);
            this.beattachpath.Name = "beattachpath";
            this.beattachpath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 50, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.beattachpath.Size = new System.Drawing.Size(407, 20);
            this.beattachpath.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl2.Controls.Add(this.beimgpath);
            this.groupControl2.Location = new System.Drawing.Point(201, 11);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupControl2.Size = new System.Drawing.Size(411, 53);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "مسار صور الاعضاء";
            // 
            // beimgpath
            // 
            this.beimgpath.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appOptionsBindingSource, "imgpath", true));
            this.beimgpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beimgpath.Location = new System.Drawing.Point(2, 21);
            this.beimgpath.Name = "beimgpath";
            this.beimgpath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 50, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.beimgpath.Size = new System.Drawing.Size(407, 20);
            this.beimgpath.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 298);
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
            // AppOptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 362);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beimgpathweb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beMandoopImgpath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beattachpath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beimgpath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
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
        private DevExpress.XtraEditors.ButtonEdit beimgpath;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.ButtonEdit beimgpathweb;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ButtonEdit beMandoopImgpath;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ButtonEdit beattachpath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DataSources.dsTeachersUnionTableAdapters.AppOptionsTableAdapter appOptionsTableAdapter;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource appOptionsBindingSource;
    }
}