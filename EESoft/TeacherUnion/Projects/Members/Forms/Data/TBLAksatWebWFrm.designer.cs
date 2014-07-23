namespace Members
{
    partial class TBLAksatWebWFrm
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbmostahk = new DevExpress.XtraEditors.TextEdit();
            this.deesaldate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dekestenddate = new DevExpress.XtraEditors.DateEdit();
            this.tbesalno = new DevExpress.XtraEditors.TextEdit();
            this.tbmadfoaa = new DevExpress.XtraEditors.TextEdit();
            this.colMonthName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbmostahk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deesaldate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deesaldate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dekestenddate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekestenddate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbesalno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmadfoaa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(364, 227);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "التاريخ";
            // 
            // tbmostahk
            // 
            this.tbmostahk.Location = new System.Drawing.Point(29, 104);
            this.tbmostahk.Name = "tbmostahk";
            this.tbmostahk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbmostahk.Properties.Appearance.Options.UseFont = true;
            this.tbmostahk.Properties.DisplayFormat.FormatString = "f2";
            this.tbmostahk.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbmostahk.Properties.EditFormat.FormatString = "f2";
            this.tbmostahk.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbmostahk.Properties.Mask.EditMask = "f2";
            this.tbmostahk.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbmostahk.Size = new System.Drawing.Size(200, 26);
            this.tbmostahk.TabIndex = 2;
            // 
            // deesaldate
            // 
            this.deesaldate.EditValue = null;
            this.deesaldate.Location = new System.Drawing.Point(29, 224);
            this.deesaldate.Name = "deesaldate";
            this.deesaldate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deesaldate.Properties.Appearance.Options.UseFont = true;
            this.deesaldate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deesaldate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deesaldate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deesaldate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deesaldate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deesaldate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deesaldate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deesaldate.Size = new System.Drawing.Size(200, 26);
            this.deesaldate.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(338, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "المستحق";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Location = new System.Drawing.Point(5, 375);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(436, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Members.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(281, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفـــــــــــــــــــــــــظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::Members.Properties.Resources.Delete;
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(7, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtpGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(441, 357);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpGeneral});
            // 
            // xtpGeneral
            // 
            this.xtpGeneral.Controls.Add(this.labelControl2);
            this.xtpGeneral.Controls.Add(this.labelControl3);
            this.xtpGeneral.Controls.Add(this.labelControl5);
            this.xtpGeneral.Controls.Add(this.labelControl1);
            this.xtpGeneral.Controls.Add(this.labelControl4);
            this.xtpGeneral.Controls.Add(this.dekestenddate);
            this.xtpGeneral.Controls.Add(this.deesaldate);
            this.xtpGeneral.Controls.Add(this.tbesalno);
            this.xtpGeneral.Controls.Add(this.tbmadfoaa);
            this.xtpGeneral.Controls.Add(this.tbmostahk);
            this.xtpGeneral.Image = global::Members.Properties.Resources.Edit;
            this.xtpGeneral.Name = "xtpGeneral";
            this.xtpGeneral.Size = new System.Drawing.Size(435, 310);
            this.xtpGeneral.Text = "بيانات أساسيه";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(324, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "نهاية القسط";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Location = new System.Drawing.Point(331, 187);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "رقم الايصال";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(353, 147);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "المدفوع";
            // 
            // dekestenddate
            // 
            this.dekestenddate.EditValue = null;
            this.dekestenddate.Location = new System.Drawing.Point(29, 60);
            this.dekestenddate.Name = "dekestenddate";
            this.dekestenddate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dekestenddate.Properties.Appearance.Options.UseFont = true;
            this.dekestenddate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dekestenddate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dekestenddate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dekestenddate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dekestenddate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dekestenddate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dekestenddate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dekestenddate.Size = new System.Drawing.Size(200, 26);
            this.dekestenddate.TabIndex = 4;
            // 
            // tbesalno
            // 
            this.tbesalno.Location = new System.Drawing.Point(29, 184);
            this.tbesalno.Name = "tbesalno";
            this.tbesalno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbesalno.Properties.Appearance.Options.UseFont = true;
            this.tbesalno.Size = new System.Drawing.Size(200, 26);
            this.tbesalno.TabIndex = 5;
            // 
            // tbmadfoaa
            // 
            this.tbmadfoaa.Location = new System.Drawing.Point(29, 144);
            this.tbmadfoaa.Name = "tbmadfoaa";
            this.tbmadfoaa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbmadfoaa.Properties.Appearance.Options.UseFont = true;
            this.tbmadfoaa.Properties.DisplayFormat.FormatString = "f2";
            this.tbmadfoaa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbmadfoaa.Properties.EditFormat.FormatString = "f2";
            this.tbmadfoaa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbmadfoaa.Properties.Mask.EditMask = "f2";
            this.tbmadfoaa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbmadfoaa.Size = new System.Drawing.Size(200, 26);
            this.tbmadfoaa.TabIndex = 3;
            // 
            // colMonthName
            // 
            this.colMonthName.AppearanceCell.Options.UseTextOptions = true;
            this.colMonthName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonthName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName.Caption = "اسم الشهر";
            this.colMonthName.FieldName = "MonthName";
            this.colMonthName.Name = "colMonthName";
            this.colMonthName.Visible = true;
            this.colMonthName.VisibleIndex = 0;
            // 
            // colYearName
            // 
            this.colYearName.AppearanceCell.Options.UseTextOptions = true;
            this.colYearName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.Caption = "اسم السنه";
            this.colYearName.FieldName = "YearName";
            this.colYearName.Name = "colYearName";
            this.colYearName.Visible = true;
            this.colYearName.VisibleIndex = 0;
            // 
            // colMonthName1
            // 
            this.colMonthName1.AppearanceCell.Options.UseTextOptions = true;
            this.colMonthName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonthName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName1.Caption = "اسم الشهر";
            this.colMonthName1.FieldName = "MonthName";
            this.colMonthName1.Name = "colMonthName1";
            this.colMonthName1.Visible = true;
            this.colMonthName1.VisibleIndex = 0;
            // 
            // TBLAksatWebWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(450, 431);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TBLAksatWebWFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحرير";
            this.Load += new System.EventHandler(this.FormWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbmostahk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deesaldate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deesaldate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpGeneral.ResumeLayout(false);
            this.xtpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dekestenddate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekestenddate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbesalno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmadfoaa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbmostahk;
        private DevExpress.XtraEditors.DateEdit deesaldate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpGeneral;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName;
        private DevExpress.XtraGrid.Columns.GridColumn colYearName;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbmadfoaa;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbesalno;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dekestenddate;
    }
}