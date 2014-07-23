namespace schoolStore
{
    partial class CodeGeneralDataFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeGeneralDataFrm));
            this.GCControls = new DevExpress.XtraEditors.GroupControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.TxtArName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEnName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPhone1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPhone2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPhone3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFax = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtArAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEnAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.DEStartingDate = new DevExpress.XtraEditors.DateEdit();
            this.folderBrowserDialogAttPath = new System.Windows.Forms.FolderBrowserDialog();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.BtnLoadImage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GCControls)).BeginInit();
            this.GCControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtArName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEnName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtArAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEnAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStartingDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStartingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GCControls
            // 
            this.GCControls.Controls.Add(this.BtnSave);
            this.GCControls.Controls.Add(this.BtnClose);
            this.GCControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GCControls.Location = new System.Drawing.Point(0, 394);
            this.GCControls.Name = "GCControls";
            this.GCControls.Size = new System.Drawing.Size(597, 57);
            this.GCControls.TabIndex = 14;
            this.GCControls.Text = " - Commands  -";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(429, 26);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.ToolTip = "This button save the window data";
            this.BtnSave.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnSave.ToolTipTitle = "Command Information";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(510, 26);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 16;
            this.BtnClose.Text = "Close";
            this.BtnClose.ToolTip = "This button close the window";
            this.BtnClose.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnClose.ToolTipTitle = "Command Information";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtArName
            // 
            this.TxtArName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtArName.Location = new System.Drawing.Point(78, 12);
            this.TxtArName.Name = "TxtArName";
            this.TxtArName.Properties.MaxLength = 50;
            this.TxtArName.Size = new System.Drawing.Size(200, 19);
            this.TxtArName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(8, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Arabic Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(8, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "English Name";
            // 
            // TxtEnName
            // 
            this.TxtEnName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEnName.Location = new System.Drawing.Point(78, 37);
            this.TxtEnName.Name = "TxtEnName";
            this.TxtEnName.Properties.MaxLength = 50;
            this.TxtEnName.Size = new System.Drawing.Size(200, 19);
            this.TxtEnName.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(8, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Phone #1";
            // 
            // TxtPhone1
            // 
            this.TxtPhone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPhone1.Location = new System.Drawing.Point(78, 62);
            this.TxtPhone1.Name = "TxtPhone1";
            this.TxtPhone1.Properties.Mask.BeepOnError = true;
            this.TxtPhone1.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtPhone1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtPhone1.Properties.Mask.ShowPlaceHolders = false;
            this.TxtPhone1.Properties.MaxLength = 20;
            this.TxtPhone1.Size = new System.Drawing.Size(200, 19);
            this.TxtPhone1.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Location = new System.Drawing.Point(8, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Phone #2";
            // 
            // TxtPhone2
            // 
            this.TxtPhone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPhone2.Location = new System.Drawing.Point(78, 87);
            this.TxtPhone2.Name = "TxtPhone2";
            this.TxtPhone2.Properties.Mask.BeepOnError = true;
            this.TxtPhone2.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtPhone2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtPhone2.Properties.Mask.ShowPlaceHolders = false;
            this.TxtPhone2.Properties.MaxLength = 20;
            this.TxtPhone2.Size = new System.Drawing.Size(200, 19);
            this.TxtPhone2.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Location = new System.Drawing.Point(8, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Phone #3";
            // 
            // TxtPhone3
            // 
            this.TxtPhone3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPhone3.Location = new System.Drawing.Point(78, 112);
            this.TxtPhone3.Name = "TxtPhone3";
            this.TxtPhone3.Properties.Mask.BeepOnError = true;
            this.TxtPhone3.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtPhone3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtPhone3.Properties.Mask.ShowPlaceHolders = false;
            this.TxtPhone3.Properties.MaxLength = 20;
            this.TxtPhone3.Size = new System.Drawing.Size(200, 19);
            this.TxtPhone3.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Location = new System.Drawing.Point(8, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Mobile";
            // 
            // TxtMobile
            // 
            this.TxtMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMobile.Location = new System.Drawing.Point(78, 137);
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Properties.Mask.BeepOnError = true;
            this.TxtMobile.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtMobile.Properties.Mask.ShowPlaceHolders = false;
            this.TxtMobile.Properties.MaxLength = 20;
            this.TxtMobile.Size = new System.Drawing.Size(200, 19);
            this.TxtMobile.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Location = new System.Drawing.Point(8, 165);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Fax";
            // 
            // TxtFax
            // 
            this.TxtFax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtFax.Location = new System.Drawing.Point(78, 162);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Properties.Mask.BeepOnError = true;
            this.TxtFax.Properties.Mask.EditMask = "\\d{0,14}";
            this.TxtFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtFax.Properties.Mask.ShowPlaceHolders = false;
            this.TxtFax.Properties.MaxLength = 20;
            this.TxtFax.Size = new System.Drawing.Size(200, 19);
            this.TxtFax.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl8.Location = new System.Drawing.Point(8, 190);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "EMail";
            // 
            // TxtEMail
            // 
            this.TxtEMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEMail.Location = new System.Drawing.Point(78, 187);
            this.TxtEMail.Name = "TxtEMail";
            this.TxtEMail.Properties.Mask.BeepOnError = true;
            this.TxtEMail.Properties.Mask.EditMask = "[A-Z0-9._%-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}";
            this.TxtEMail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtEMail.Properties.Mask.ShowPlaceHolders = false;
            this.TxtEMail.Properties.MaxLength = 50;
            this.TxtEMail.Size = new System.Drawing.Size(200, 19);
            this.TxtEMail.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl9.Location = new System.Drawing.Point(8, 215);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 13);
            this.labelControl9.TabIndex = 6;
            this.labelControl9.Text = "Starting Date";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl10.Location = new System.Drawing.Point(348, 15);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(23, 13);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "Logo";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl11.Location = new System.Drawing.Point(8, 240);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(53, 13);
            this.labelControl11.TabIndex = 6;
            this.labelControl11.Text = "Ar Address";
            // 
            // TxtArAddress
            // 
            this.TxtArAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtArAddress.Location = new System.Drawing.Point(78, 237);
            this.TxtArAddress.Name = "TxtArAddress";
            this.TxtArAddress.Properties.MaxLength = 30;
            this.TxtArAddress.Size = new System.Drawing.Size(200, 19);
            this.TxtArAddress.TabIndex = 9;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl12.Location = new System.Drawing.Point(8, 265);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(51, 13);
            this.labelControl12.TabIndex = 6;
            this.labelControl12.Text = "EnAddress";
            // 
            // TxtEnAddress
            // 
            this.TxtEnAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEnAddress.Location = new System.Drawing.Point(78, 262);
            this.TxtEnAddress.Name = "TxtEnAddress";
            this.TxtEnAddress.Properties.MaxLength = 30;
            this.TxtEnAddress.Size = new System.Drawing.Size(200, 19);
            this.TxtEnAddress.TabIndex = 10;
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl13.Location = new System.Drawing.Point(299, 215);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(46, 13);
            this.labelControl13.TabIndex = 6;
            this.labelControl13.Text = "Password";
            this.labelControl13.Visible = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPassword.Location = new System.Drawing.Point(381, 212);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.MaxLength = 50;
            this.TxtPassword.Properties.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(196, 19);
            this.TxtPassword.TabIndex = 12;
            this.TxtPassword.Visible = false;
            // 
            // DEStartingDate
            // 
            this.DEStartingDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DEStartingDate.EditValue = null;
            this.DEStartingDate.Location = new System.Drawing.Point(78, 212);
            this.DEStartingDate.Name = "DEStartingDate";
            this.DEStartingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEStartingDate.Properties.DisplayFormat.FormatString = "dd MMM yyyy";
            this.DEStartingDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEStartingDate.Properties.EditFormat.FormatString = "dd MMM yyyy";
            this.DEStartingDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEStartingDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.DEStartingDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DEStartingDate.Size = new System.Drawing.Size(200, 19);
            this.DEStartingDate.TabIndex = 8;
            // 
            // folderBrowserDialogAttPath
            // 
            this.folderBrowserDialogAttPath.Description = "Select Folder For Attachment Files";
            this.folderBrowserDialogAttPath.SelectedPath = "C:\\";
            // 
            // PBImage
            // 
            this.PBImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBImage.Location = new System.Drawing.Point(381, 14);
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
            this.BtnLoadImage.Location = new System.Drawing.Point(381, 183);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(160, 23);
            this.BtnLoadImage.TabIndex = 11;
            this.BtnLoadImage.Text = "Load Image";
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // CodeGeneralDataFrm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(597, 451);
            this.Controls.Add(this.PBImage);
            this.Controls.Add(this.DEStartingDate);
            this.Controls.Add(this.BtnLoadImage);
            this.Controls.Add(this.TxtEMail);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.TxtFax);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TxtMobile);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtPhone3);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TxtEnAddress);
            this.Controls.Add(this.TxtPhone2);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TxtArAddress);
            this.Controls.Add(this.TxtPhone1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtEnName);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.TxtArName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GCControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeGeneralDataFrm";
            this.Text = "Organization Information";
            this.Load += new System.EventHandler(this.CodeGeneralDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCControls)).EndInit();
            this.GCControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtArName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEnName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtArAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEnAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStartingDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStartingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GCControls;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.TextEdit TxtArName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtEnName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtPhone1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtPhone2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtPhone3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtMobile;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtFax;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtEMail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtArAddress;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit TxtEnAddress;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.DateEdit DEStartingDate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAttPath;
        private System.Windows.Forms.PictureBox PBImage;
        private DevExpress.XtraEditors.SimpleButton BtnLoadImage;
    }
}