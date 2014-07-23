namespace Members.Forms.Main
{
    partial class PasswordChangerFrm
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
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.tbNewPass2 = new DevExpress.XtraEditors.TextEdit();
            this.tbNewPass = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbOldPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxValidationProviderPassword = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPass.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNewPass2
            // 
            this.tbNewPass2.Location = new System.Drawing.Point(79, 101);
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.Properties.PasswordChar = '*';
            this.tbNewPass2.Size = new System.Drawing.Size(300, 20);
            this.tbNewPass2.TabIndex = 2;
            compareAgainstControlValidationRule1.CaseSensitive = true;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.tbNewPass;
            compareAgainstControlValidationRule1.ErrorText = "كلمة المرور الجديدة واعادة كلمة المرو غير متوافقين";
            compareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderPassword.SetValidationRule(this.tbNewPass2, compareAgainstControlValidationRule1);
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "يجب ادخال اعادة كلمة المرور";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderMain.SetValidationRule(this.tbNewPass2, conditionValidationRule2);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(79, 62);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Properties.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(300, 20);
            this.tbNewPass.TabIndex = 1;
            compareAgainstControlValidationRule2.CaseSensitive = true;
            compareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule2.Control = this.tbNewPass2;
            compareAgainstControlValidationRule2.ErrorText = "كلمة المرور الجديدة واعادة كلمة المرو غير متوافقين";
            compareAgainstControlValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderPassword.SetValidationRule(this.tbNewPass, compareAgainstControlValidationRule2);
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "يجب ادخال كلمة المرور الجديدة";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderMain.SetValidationRule(this.tbNewPass, conditionValidationRule1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.56058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.43942F));
            this.tableLayoutPanel1.Controls.Add(this.tbOldPass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNewPass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNewPass2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(79, 3);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Properties.PasswordChar = '*';
            this.tbOldPass.Size = new System.Drawing.Size(300, 20);
            this.tbOldPass.TabIndex = 0;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "يجب ادخال كلمة المرور الحالية";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderMain.SetValidationRule(this.tbOldPass, conditionValidationRule3);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(400, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "كلمة المرور الحالية";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(396, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "كلمة المرور الجديدة";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(406, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "اعادة كلمة المرور";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(409, 159);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(229, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PasswordChangerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 212);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PasswordChangerFrm";
            this.Text = "تغير كلمة مرور المستخدم";
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPass.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit tbOldPass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbNewPass;
        private DevExpress.XtraEditors.TextEdit tbNewPass2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderPassword;
    }
}