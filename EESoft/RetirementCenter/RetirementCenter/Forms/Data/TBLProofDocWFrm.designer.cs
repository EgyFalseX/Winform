namespace RetirementCenter
{
    partial class TBLProofDocWFrm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.ceYasref = new DevExpress.XtraEditors.CheckEdit();
            this.lueMMashatId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSMMashatId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyasref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMashHala = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbmemo = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.deDocDate = new DevExpress.XtraEditors.DateEdit();
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.colMonthName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblProofDocTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLProofDocTableAdapter();
            this.tblMashatTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceYasref.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMMashatId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSMMashatId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDocDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDocDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(419, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "التاريخ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(412, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "ملاحظة";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Location = new System.Drawing.Point(5, 370);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(520, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::RetirementCenter.Properties.Resources.Delete;
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(7, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::RetirementCenter.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(312, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفـــــــــــــــــــــــــظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtpGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(525, 352);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpGeneral});
            // 
            // xtpGeneral
            // 
            this.xtpGeneral.Controls.Add(this.ceYasref);
            this.xtpGeneral.Controls.Add(this.btnSave);
            this.xtpGeneral.Controls.Add(this.lueMMashatId);
            this.xtpGeneral.Controls.Add(this.tbmemo);
            this.xtpGeneral.Controls.Add(this.labelControl6);
            this.xtpGeneral.Controls.Add(this.labelControl2);
            this.xtpGeneral.Controls.Add(this.labelControl4);
            this.xtpGeneral.Controls.Add(this.deDocDate);
            this.xtpGeneral.Image = global::RetirementCenter.Properties.Resources.Edit;
            this.xtpGeneral.Name = "xtpGeneral";
            this.xtpGeneral.Size = new System.Drawing.Size(519, 305);
            this.xtpGeneral.Text = "بيانات أساسيه";
            // 
            // ceYasref
            // 
            this.ceYasref.Location = new System.Drawing.Point(211, 72);
            this.ceYasref.Name = "ceYasref";
            this.ceYasref.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ceYasref.Properties.Appearance.Options.UseFont = true;
            this.ceYasref.Properties.Caption = "يصرف";
            this.ceYasref.Size = new System.Drawing.Size(75, 24);
            this.ceYasref.TabIndex = 1;
            // 
            // lueMMashatId
            // 
            this.lueMMashatId.EditValue = "";
            this.lueMMashatId.Location = new System.Drawing.Point(53, 10);
            this.lueMMashatId.Name = "lueMMashatId";
            this.lueMMashatId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueMMashatId.Properties.Appearance.Options.UseFont = true;
            this.lueMMashatId.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueMMashatId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMMashatId.Properties.DataSource = this.LSMSMMashatId;
            this.lueMMashatId.Properties.DisplayMember = "MMashatName";
            this.lueMMashatId.Properties.NullText = "";
            this.lueMMashatId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMMashatId.Properties.ValueMember = "MMashatId";
            this.lueMMashatId.Properties.View = this.gridLookUpEdit1View;
            this.lueMMashatId.Size = new System.Drawing.Size(233, 26);
            this.lueMMashatId.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "يجب اختيار العضو";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderMain.SetValidationRule(this.lueMMashatId, conditionValidationRule1);
            this.lueMMashatId.EditValueChanged += new System.EventHandler(this.lueMMashatId_EditValueChanged);
            // 
            // LSMSMMashatId
            // 
            this.LSMSMMashatId.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLMashat);
            this.LSMSMMashatId.KeyExpression = "MMashatId";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatName,
            this.colsarfnumber1,
            this.colSubCommitte1,
            this.colSyndicate,
            this.colyasref,
            this.colMashHala});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.AutoPopulateColumns = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowDetailButtons = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMMashatName
            // 
            this.colMMashatName.Caption = "الاسم";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 1;
            // 
            // colsarfnumber1
            // 
            this.colsarfnumber1.Caption = "رقم الصرف";
            this.colsarfnumber1.FieldName = "sarfnumber";
            this.colsarfnumber1.Name = "colsarfnumber1";
            this.colsarfnumber1.Visible = true;
            this.colsarfnumber1.VisibleIndex = 0;
            // 
            // colSubCommitte1
            // 
            this.colSubCommitte1.Caption = "اللجنة";
            this.colSubCommitte1.FieldName = "SubCommitte";
            this.colSubCommitte1.Name = "colSubCommitte1";
            this.colSubCommitte1.Visible = true;
            this.colSubCommitte1.VisibleIndex = 4;
            // 
            // colSyndicate
            // 
            this.colSyndicate.Caption = "الفرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 3;
            // 
            // colyasref
            // 
            this.colyasref.Caption = "يصرف";
            this.colyasref.FieldName = "yasref";
            this.colyasref.Name = "colyasref";
            this.colyasref.Visible = true;
            this.colyasref.VisibleIndex = 5;
            // 
            // colMashHala
            // 
            this.colMashHala.Caption = "النوع";
            this.colMashHala.FieldName = "MashHala";
            this.colMashHala.Name = "colMashHala";
            this.colMashHala.Visible = true;
            this.colMashHala.VisibleIndex = 2;
            // 
            // tbmemo
            // 
            this.tbmemo.Location = new System.Drawing.Point(53, 143);
            this.tbmemo.Name = "tbmemo";
            this.tbmemo.Size = new System.Drawing.Size(233, 80);
            this.tbmemo.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "يجب ادخال الملاحظات";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderMain.SetValidationRule(this.tbmemo, conditionValidationRule2);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Location = new System.Drawing.Point(375, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "الاعضاء/الورثة";
            // 
            // deDocDate
            // 
            this.deDocDate.EditValue = "";
            this.deDocDate.Location = new System.Drawing.Point(53, 105);
            this.deDocDate.Name = "deDocDate";
            this.deDocDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deDocDate.Properties.Appearance.Options.UseFont = true;
            this.deDocDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDocDate.Properties.Mask.EditMask = "d/M/yyyy";
            this.deDocDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDocDate.Size = new System.Drawing.Size(233, 26);
            this.deDocDate.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "يجب ادخال التاريخ";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProviderMain.SetValidationRule(this.deDocDate, conditionValidationRule3);
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tblProofDocTableAdapter
            // 
            this.tblProofDocTableAdapter.ClearBeforeFill = true;
            // 
            // tblMashatTableAdapter
            // 
            this.tblMashatTableAdapter.ClearBeforeFill = true;
            // 
            // TBLProofDocWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(542, 426);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TBLProofDocWFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحرير";
            this.Load += new System.EventHandler(this.FormWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpGeneral.ResumeLayout(false);
            this.xtpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceYasref.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMMashatId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSMMashatId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDocDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDocDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpGeneral;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName;
        private DevExpress.XtraGrid.Columns.GridColumn colYearName;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName1;
        private DevExpress.XtraEditors.MemoEdit tbmemo;
        private DevExpress.XtraEditors.GridLookUpEdit lueMMashatId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDetails;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte1;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colyasref;
        private DevExpress.XtraGrid.Columns.GridColumn colMashHala;
        private DevExpress.XtraEditors.DateEdit deDocDate;
        private DevExpress.XtraEditors.CheckEdit ceYasref;
        private DataSources.dsRetirementCenterTableAdapters.TBLProofDocTableAdapter tblProofDocTableAdapter;
        private DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter tblMashatTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
    }
}