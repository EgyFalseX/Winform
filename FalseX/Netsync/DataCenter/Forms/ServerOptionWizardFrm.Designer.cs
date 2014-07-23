namespace DataCenter.Forms
{
    partial class ServerOptionWizardFrm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerOptionWizardFrm));
            this.wizardControlOptions = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.wizardPagePaths = new DevExpress.XtraWizard.WizardPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.beDeletedFilesPath = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.beFilesPath = new DevExpress.XtraEditors.ButtonEdit();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.wizardPageGeneralOptions = new DevExpress.XtraWizard.WizardPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbDefaultUserPassword = new DevExpress.XtraEditors.TextEdit();
            this.wizardPageServerOptions = new DevExpress.XtraWizard.WizardPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbServerPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbServerIP = new DevExpress.XtraEditors.TextEdit();
            this.dxValidationProviderOptions = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlOptions)).BeginInit();
            this.wizardControlOptions.SuspendLayout();
            this.welcomeWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            this.wizardPagePaths.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDeletedFilesPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFilesPath.Properties)).BeginInit();
            this.completionWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.wizardPageGeneralOptions.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefaultUserPassword.Properties)).BeginInit();
            this.wizardPageServerOptions.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServerPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServerIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControlOptions
            // 
            this.wizardControlOptions.CancelText = "الغاء";
            this.wizardControlOptions.Controls.Add(this.welcomeWizardPage);
            this.wizardControlOptions.Controls.Add(this.wizardPagePaths);
            this.wizardControlOptions.Controls.Add(this.completionWizardPage);
            this.wizardControlOptions.Controls.Add(this.wizardPageGeneralOptions);
            this.wizardControlOptions.Controls.Add(this.wizardPageServerOptions);
            this.wizardControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControlOptions.FinishText = "انهاء";
            this.wizardControlOptions.HeaderImage = global::DataCenter.Properties.Resources.Settings;
            this.wizardControlOptions.HelpText = "مساعدة";
            this.wizardControlOptions.Location = new System.Drawing.Point(0, 0);
            this.wizardControlOptions.Name = "wizardControlOptions";
            this.wizardControlOptions.NextText = "التالي";
            this.wizardControlOptions.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.wizardPagePaths,
            this.wizardPageGeneralOptions,
            this.wizardPageServerOptions,
            this.completionWizardPage});
            this.wizardControlOptions.PreviousText = "< السابق";
            this.wizardControlOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wizardControlOptions.Size = new System.Drawing.Size(692, 397);
            this.wizardControlOptions.Text = "خيارات البرنامج";
            this.wizardControlOptions.TitleImage = global::DataCenter.Properties.Resources.Settings;
            this.wizardControlOptions.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControlOptions.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControlOptions_SelectedPageChanging);
            this.wizardControlOptions.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControlOptions_CancelClick);
            this.wizardControlOptions.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControlOptions_FinishClick);
            // 
            // welcomeWizardPage
            // 
            this.welcomeWizardPage.Controls.Add(this.memoEdit2);
            this.welcomeWizardPage.Name = "welcomeWizardPage";
            this.welcomeWizardPage.Size = new System.Drawing.Size(632, 235);
            // 
            // memoEdit2
            // 
            this.memoEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit2.EditValue = "مرحبا بك في خيارات الرنامج\r\nهنا يمكنك تغير خيارات البرنامج و الخادم\r\n\r\nلبداء تغير" +
    " الخيارات اضغط التالـــي";
            this.memoEdit2.Location = new System.Drawing.Point(0, 0);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(632, 235);
            this.memoEdit2.TabIndex = 0;
            // 
            // wizardPagePaths
            // 
            this.wizardPagePaths.Controls.Add(this.tableLayoutPanel1);
            this.wizardPagePaths.Name = "wizardPagePaths";
            this.wizardPagePaths.Size = new System.Drawing.Size(632, 235);
            this.wizardPagePaths.Text = "مسارات الملفات";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.16294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.83706F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.beDeletedFilesPath, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.beFilesPath, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 232);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(548, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "مسار المحزوفات";
            // 
            // beDeletedFilesPath
            // 
            this.beDeletedFilesPath.EditValue = "";
            this.beDeletedFilesPath.Location = new System.Drawing.Point(179, 141);
            this.beDeletedFilesPath.Name = "beDeletedFilesPath";
            this.beDeletedFilesPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 40, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.beDeletedFilesPath.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beDeletedFilesPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.beDeletedFilesPath.Size = new System.Drawing.Size(300, 20);
            this.beDeletedFilesPath.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "يجب ادخال مسار المحزوفات";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderOptions.SetValidationRule(this.beDeletedFilesPath, conditionValidationRule1);
            this.beDeletedFilesPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beDeletedFilesPath_ButtonClick);
            this.beDeletedFilesPath.Validating += new System.ComponentModel.CancelEventHandler(this.beDeletedFilesPath_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(560, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "مسار الملفات";
            // 
            // beFilesPath
            // 
            this.beFilesPath.EditValue = "";
            this.beFilesPath.Location = new System.Drawing.Point(179, 95);
            this.beFilesPath.Name = "beFilesPath";
            this.beFilesPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 40, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.beFilesPath.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beFilesPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.beFilesPath.Size = new System.Drawing.Size(300, 20);
            this.beFilesPath.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "يجب ادخال مسار الملفات";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderOptions.SetValidationRule(this.beFilesPath, conditionValidationRule2);
            this.beFilesPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beFilesPath_ButtonClick);
            this.beFilesPath.Validating += new System.ComponentModel.CancelEventHandler(this.beFilesPath_Validating);
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.Controls.Add(this.memoEdit1);
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.Size = new System.Drawing.Size(632, 235);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = "لضغط انهاء لحفظ الخيارات";
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(632, 235);
            this.memoEdit1.TabIndex = 0;
            // 
            // wizardPageGeneralOptions
            // 
            this.wizardPageGeneralOptions.Controls.Add(this.tableLayoutPanel2);
            this.wizardPageGeneralOptions.Name = "wizardPageGeneralOptions";
            this.wizardPageGeneralOptions.Size = new System.Drawing.Size(632, 235);
            this.wizardPageGeneralOptions.Text = "خيارات رئيسية";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.46836F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.53165F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbDefaultUserPassword, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 235);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(501, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "كلمة مرور المستخدم الجديد";
            // 
            // tbDefaultUserPassword
            // 
            this.tbDefaultUserPassword.Location = new System.Drawing.Point(187, 81);
            this.tbDefaultUserPassword.Name = "tbDefaultUserPassword";
            this.tbDefaultUserPassword.Size = new System.Drawing.Size(300, 20);
            this.tbDefaultUserPassword.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "يجب ادخال كلمة مرور المستخدم الجديد";
            this.dxValidationProviderOptions.SetValidationRule(this.tbDefaultUserPassword, conditionValidationRule3);
            this.tbDefaultUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbDefaultUserPassword_Validating);
            // 
            // wizardPageServerOptions
            // 
            this.wizardPageServerOptions.Controls.Add(this.tableLayoutPanel3);
            this.wizardPageServerOptions.Name = "wizardPageServerOptions";
            this.wizardPageServerOptions.Size = new System.Drawing.Size(632, 235);
            this.wizardPageServerOptions.Text = "خيارات الخادم";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.98101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.01899F));
            this.tableLayoutPanel3.Controls.Add(this.labelControl5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbServerPort, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelControl4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbServerIP, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(632, 232);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(601, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "البورت";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(229, 119);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Properties.Mask.EditMask = "n0";
            this.tbServerPort.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbServerPort.Properties.MaxLength = 5;
            this.tbServerPort.Size = new System.Drawing.Size(300, 20);
            this.tbServerPort.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "يجب ادخال البورت";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderOptions.SetValidationRule(this.tbServerPort, conditionValidationRule4);
            this.tbServerPort.Validating += new System.ComponentModel.CancelEventHandler(this.tbServerPort_Validating);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(568, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "أي بي الخادم";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(229, 61);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Properties.Mask.EditMask = "\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}";
            this.tbServerIP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tbServerIP.Size = new System.Drawing.Size(300, 20);
            this.tbServerIP.TabIndex = 1;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "يجب ادخال أي بي الخادم";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderOptions.SetValidationRule(this.tbServerIP, conditionValidationRule5);
            this.tbServerIP.Validating += new System.ComponentModel.CancelEventHandler(this.tbServerIP_Validating);
            // 
            // ServerOptionWizardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 397);
            this.Controls.Add(this.wizardControlOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerOptionWizardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خيارات البرنامج";
            this.Load += new System.EventHandler(this.ServerOptionWizardFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlOptions)).EndInit();
            this.wizardControlOptions.ResumeLayout(false);
            this.welcomeWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            this.wizardPagePaths.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDeletedFilesPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFilesPath.Properties)).EndInit();
            this.completionWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.wizardPageGeneralOptions.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefaultUserPassword.Properties)).EndInit();
            this.wizardPageServerOptions.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServerPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServerIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControlOptions;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
        private DevExpress.XtraWizard.WizardPage wizardPagePaths;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
        private DevExpress.XtraWizard.WizardPage wizardPageGeneralOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit beFilesPath;
        private DevExpress.XtraEditors.ButtonEdit beDeletedFilesPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbDefaultUserPassword;
        private DevExpress.XtraWizard.WizardPage wizardPageServerOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbServerPort;
        private DevExpress.XtraEditors.TextEdit tbServerIP;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderOptions;
    }
}