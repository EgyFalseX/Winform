namespace RetirementCenter.Forms.Data
{
    partial class TBLNoSarfDetelsDlg
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tbhalarem = new DevExpress.XtraEditors.MemoEdit();
            this.dedatehala = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbhalarem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatehala.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatehala.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Controls.Add(this.tbhalarem);
            this.panelControl1.Controls.Add(this.dedatehala);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(260, 154);
            this.panelControl1.TabIndex = 0;
            // 
            // tbhalarem
            // 
            this.tbhalarem.Location = new System.Drawing.Point(5, 44);
            this.tbhalarem.Name = "tbhalarem";
            this.tbhalarem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbhalarem.Properties.Appearance.Options.UseFont = true;
            this.tbhalarem.Size = new System.Drawing.Size(180, 96);
            this.tbhalarem.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "يجب ادخال ملاحظات";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderMain.SetValidationRule(this.tbhalarem, conditionValidationRule1);
            // 
            // dedatehala
            // 
            this.dedatehala.EditValue = null;
            this.dedatehala.Location = new System.Drawing.Point(5, 18);
            this.dedatehala.Name = "dedatehala";
            this.dedatehala.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dedatehala.Properties.Appearance.Options.UseFont = true;
            this.dedatehala.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedatehala.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedatehala.Size = new System.Drawing.Size(180, 22);
            this.dedatehala.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "يجب ادخال تاريخ";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderMain.SetValidationRule(this.dedatehala, conditionValidationRule2);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(204, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "ملاحظات";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(217, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "التاريخ";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Location = new System.Drawing.Point(12, 172);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(260, 62);
            this.groupControl1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::RetirementCenter.Properties.Resources.Delete;
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(5, 28);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::RetirementCenter.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(180, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TBLNoSarfDetelsDlg
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TBLNoSarfDetelsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الصرف";
            this.Load += new System.EventHandler(this.TBLNoSarfDetelsDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbhalarem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatehala.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatehala.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit tbhalarem;
        private DevExpress.XtraEditors.DateEdit dedatehala;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
    }
}