namespace RealEstate
{
    partial class BasicDataFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicDataFrm));
            this.GCControls = new DevExpress.XtraEditors.GroupControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.TxtCompanyAr = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCompanyEn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtActivityAr = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtActivityEn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCommercialAr = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCommercialEn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Txttel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txtmobil = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddressAr = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddressEn = new DevExpress.XtraEditors.TextEdit();
            this.folderBrowserDialogAttPath = new System.Windows.Forms.FolderBrowserDialog();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.BtnLoadImage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GCControls)).BeginInit();
            this.GCControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyAr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyEn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtActivityAr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtActivityEn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCommercialAr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCommercialEn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txttel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmobil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddressAr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddressEn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GCControls
            // 
            this.GCControls.Controls.Add(this.BtnSave);
            this.GCControls.Controls.Add(this.BtnClose);
            this.GCControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GCControls.Location = new System.Drawing.Point(0, 336);
            this.GCControls.Name = "GCControls";
            this.GCControls.Size = new System.Drawing.Size(660, 57);
            this.GCControls.TabIndex = 14;
            this.GCControls.Text = " - الاوامر  -";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(492, 26);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.ToolTip = "لحفظ التعديلات";
            this.BtnSave.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnSave.ToolTipTitle = "Command Information";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(573, 26);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 16;
            this.BtnClose.Text = "اغلاق";
            this.BtnClose.ToolTip = "اغلاق الصفحه بدون الحفظ";
            this.BtnClose.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnClose.ToolTipTitle = "Command Information";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtCompanyAr
            // 
            this.TxtCompanyAr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCompanyAr.Location = new System.Drawing.Point(326, 8);
            this.TxtCompanyAr.Name = "TxtCompanyAr";
            this.TxtCompanyAr.Properties.MaxLength = 50;
            this.TxtCompanyAr.Size = new System.Drawing.Size(200, 19);
            this.TxtCompanyAr.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(582, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "اسم الشركة";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(532, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "اسم الشركة (انجليزي)ا";
            // 
            // TxtCompanyEn
            // 
            this.TxtCompanyEn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCompanyEn.Location = new System.Drawing.Point(326, 33);
            this.TxtCompanyEn.Name = "TxtCompanyEn";
            this.TxtCompanyEn.Properties.MaxLength = 50;
            this.TxtCompanyEn.Size = new System.Drawing.Size(200, 19);
            this.TxtCompanyEn.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(276, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "النشاط";
            // 
            // TxtActivityAr
            // 
            this.TxtActivityAr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtActivityAr.Location = new System.Drawing.Point(20, 8);
            this.TxtActivityAr.Name = "TxtActivityAr";
            this.TxtActivityAr.Properties.Mask.BeepOnError = true;
            this.TxtActivityAr.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtActivityAr.Properties.Mask.ShowPlaceHolders = false;
            this.TxtActivityAr.Properties.MaxLength = 20;
            this.TxtActivityAr.Size = new System.Drawing.Size(200, 19);
            this.TxtActivityAr.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Location = new System.Drawing.Point(226, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "النشاط (انجليزي)ا";
            // 
            // TxtActivityEn
            // 
            this.TxtActivityEn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtActivityEn.Location = new System.Drawing.Point(20, 33);
            this.TxtActivityEn.Name = "TxtActivityEn";
            this.TxtActivityEn.Properties.Mask.BeepOnError = true;
            this.TxtActivityEn.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtActivityEn.Properties.Mask.ShowPlaceHolders = false;
            this.TxtActivityEn.Properties.MaxLength = 20;
            this.TxtActivityEn.Size = new System.Drawing.Size(200, 19);
            this.TxtActivityEn.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Location = new System.Drawing.Point(585, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "سجل تجاري";
            // 
            // TxtCommercialAr
            // 
            this.TxtCommercialAr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCommercialAr.Location = new System.Drawing.Point(326, 58);
            this.TxtCommercialAr.Name = "TxtCommercialAr";
            this.TxtCommercialAr.Properties.Mask.BeepOnError = true;
            this.TxtCommercialAr.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtCommercialAr.Properties.Mask.ShowPlaceHolders = false;
            this.TxtCommercialAr.Properties.MaxLength = 20;
            this.TxtCommercialAr.Size = new System.Drawing.Size(200, 19);
            this.TxtCommercialAr.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Location = new System.Drawing.Point(535, 86);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(106, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "سجل تجاري (انجليزي)ا";
            // 
            // TxtCommercialEn
            // 
            this.TxtCommercialEn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCommercialEn.Location = new System.Drawing.Point(326, 83);
            this.TxtCommercialEn.Name = "TxtCommercialEn";
            this.TxtCommercialEn.Properties.Mask.BeepOnError = true;
            this.TxtCommercialEn.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtCommercialEn.Properties.Mask.ShowPlaceHolders = false;
            this.TxtCommercialEn.Properties.MaxLength = 20;
            this.TxtCommercialEn.Size = new System.Drawing.Size(200, 19);
            this.TxtCommercialEn.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Location = new System.Drawing.Point(279, 61);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "تليفون";
            // 
            // Txttel
            // 
            this.Txttel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txttel.Location = new System.Drawing.Point(20, 58);
            this.Txttel.Name = "Txttel";
            this.Txttel.Properties.Mask.BeepOnError = true;
            this.Txttel.Properties.Mask.EditMask = "\\d{0,14}";
            this.Txttel.Properties.Mask.ShowPlaceHolders = false;
            this.Txttel.Properties.MaxLength = 20;
            this.Txttel.Size = new System.Drawing.Size(200, 19);
            this.Txttel.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl8.Location = new System.Drawing.Point(286, 86);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "جوال";
            // 
            // Txtmobil
            // 
            this.Txtmobil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txtmobil.Location = new System.Drawing.Point(20, 83);
            this.Txtmobil.Name = "Txtmobil";
            this.Txtmobil.Properties.Mask.BeepOnError = true;
            this.Txtmobil.Properties.Mask.EditMask = "[A-Z0-9._%-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}";
            this.Txtmobil.Properties.Mask.ShowPlaceHolders = false;
            this.Txtmobil.Properties.MaxLength = 50;
            this.Txtmobil.Size = new System.Drawing.Size(200, 19);
            this.Txtmobil.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl11.Location = new System.Drawing.Point(610, 111);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(31, 13);
            this.labelControl11.TabIndex = 6;
            this.labelControl11.Text = "العنوان";
            // 
            // TxtAddressAr
            // 
            this.TxtAddressAr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAddressAr.Location = new System.Drawing.Point(326, 108);
            this.TxtAddressAr.Name = "TxtAddressAr";
            this.TxtAddressAr.Properties.MaxLength = 30;
            this.TxtAddressAr.Size = new System.Drawing.Size(200, 19);
            this.TxtAddressAr.TabIndex = 9;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl12.Location = new System.Drawing.Point(563, 133);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(78, 13);
            this.labelControl12.TabIndex = 6;
            this.labelControl12.Text = "العنوان(انجليزي)ا";
            // 
            // TxtAddressEn
            // 
            this.TxtAddressEn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAddressEn.Location = new System.Drawing.Point(326, 133);
            this.TxtAddressEn.Name = "TxtAddressEn";
            this.TxtAddressEn.Properties.MaxLength = 30;
            this.TxtAddressEn.Size = new System.Drawing.Size(200, 19);
            this.TxtAddressEn.TabIndex = 10;
            // 
            // folderBrowserDialogAttPath
            // 
            this.folderBrowserDialogAttPath.Description = "Select Folder For Attachment Files";
            this.folderBrowserDialogAttPath.SelectedPath = "C:\\";
            // 
            // PBImage
            // 
            this.PBImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBImage.Location = new System.Drawing.Point(20, 111);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(160, 163);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 21;
            this.PBImage.TabStop = false;
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLoadImage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnLoadImage.Location = new System.Drawing.Point(20, 280);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(160, 23);
            this.BtnLoadImage.TabIndex = 11;
            this.BtnLoadImage.Text = "Load Image";
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // BasicDataFrm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(660, 393);
            this.Controls.Add(this.PBImage);
            this.Controls.Add(this.BtnLoadImage);
            this.Controls.Add(this.Txtmobil);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.Txttel);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TxtCommercialEn);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TxtCommercialAr);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TxtAddressEn);
            this.Controls.Add(this.TxtActivityEn);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TxtAddressAr);
            this.Controls.Add(this.TxtActivityAr);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtCompanyEn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtCompanyAr);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GCControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasicDataFrm";
            this.Text = "البيانات الأساسية";
            this.Load += new System.EventHandler(this.CodeGeneralDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCControls)).EndInit();
            this.GCControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyAr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyEn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtActivityAr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtActivityEn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCommercialAr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCommercialEn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txttel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmobil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddressAr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddressEn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GCControls;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.TextEdit TxtCompanyAr;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtCompanyEn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtActivityAr;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtActivityEn;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtCommercialAr;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtCommercialEn;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit Txttel;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit Txtmobil;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtAddressAr;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit TxtAddressEn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAttPath;
        private System.Windows.Forms.PictureBox PBImage;
        private DevExpress.XtraEditors.SimpleButton BtnLoadImage;
    }
}