namespace Members
{
    partial class TBLEmpWorkWFrm
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
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lueSyndicateId = new DevExpress.XtraEditors.LookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.LUEWorkTypeId = new DevExpress.XtraEditors.LookUpEdit();
            this.cDWorkTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ceclosed = new DevExpress.XtraEditors.CheckEdit();
            this.tbwrem = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbwno = new DevExpress.XtraEditors.TextEdit();
            this.colMonthName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDSyndicateTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter();
            this.cDWorkTypeTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDWorkTypeTableAdapter();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.deworkdate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEWorkTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDWorkTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceclosed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbwrem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbwno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deworkdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deworkdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Location = new System.Drawing.Point(359, 8);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 19);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "النقابة";
            // 
            // lueSyndicateId
            // 
            this.lueSyndicateId.Location = new System.Drawing.Point(26, 5);
            this.lueSyndicateId.Name = "lueSyndicateId";
            this.lueSyndicateId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueSyndicateId.Properties.Appearance.Options.UseFont = true;
            this.lueSyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyndicateId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.lueSyndicateId.Properties.DataSource = this.cDSyndicateBindingSource;
            this.lueSyndicateId.Properties.DisplayMember = "Syndicate";
            this.lueSyndicateId.Properties.NullText = "";
            this.lueSyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyndicateId.Properties.ValueMember = "SyndicateId";
            this.lueSyndicateId.Size = new System.Drawing.Size(200, 26);
            this.lueSyndicateId.TabIndex = 0;
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Location = new System.Drawing.Point(5, 331);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(441, 313);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpGeneral});
            // 
            // xtpGeneral
            // 
            this.xtpGeneral.Controls.Add(this.labelControl3);
            this.xtpGeneral.Controls.Add(this.deworkdate);
            this.xtpGeneral.Controls.Add(this.LUEWorkTypeId);
            this.xtpGeneral.Controls.Add(this.ceclosed);
            this.xtpGeneral.Controls.Add(this.tbwrem);
            this.xtpGeneral.Controls.Add(this.lueSyndicateId);
            this.xtpGeneral.Controls.Add(this.labelControl1);
            this.xtpGeneral.Controls.Add(this.labelControl2);
            this.xtpGeneral.Controls.Add(this.labelControl5);
            this.xtpGeneral.Controls.Add(this.labelControl10);
            this.xtpGeneral.Controls.Add(this.tbwno);
            this.xtpGeneral.Image = global::Members.Properties.Resources.Edit;
            this.xtpGeneral.Name = "xtpGeneral";
            this.xtpGeneral.Size = new System.Drawing.Size(435, 266);
            this.xtpGeneral.Text = "بيانات أساسيه";
            // 
            // LUEWorkTypeId
            // 
            this.LUEWorkTypeId.Location = new System.Drawing.Point(26, 37);
            this.LUEWorkTypeId.Name = "LUEWorkTypeId";
            this.LUEWorkTypeId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LUEWorkTypeId.Properties.Appearance.Options.UseFont = true;
            this.LUEWorkTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEWorkTypeId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WorkType", "النوع", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.LUEWorkTypeId.Properties.DataSource = this.cDWorkTypeBindingSource;
            this.LUEWorkTypeId.Properties.DisplayMember = "WorkType";
            this.LUEWorkTypeId.Properties.NullText = "";
            this.LUEWorkTypeId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEWorkTypeId.Properties.ValueMember = "WorkTypeId";
            this.LUEWorkTypeId.Size = new System.Drawing.Size(200, 26);
            this.LUEWorkTypeId.TabIndex = 1;
            // 
            // cDWorkTypeBindingSource
            // 
            this.cDWorkTypeBindingSource.DataMember = "CDWorkType";
            this.cDWorkTypeBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // ceclosed
            // 
            this.ceclosed.Location = new System.Drawing.Point(315, 215);
            this.ceclosed.Name = "ceclosed";
            this.ceclosed.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ceclosed.Properties.Appearance.Options.UseFont = true;
            this.ceclosed.Properties.Caption = "اغلاق";
            this.ceclosed.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style16;
            this.ceclosed.Size = new System.Drawing.Size(85, 32);
            this.ceclosed.TabIndex = 5;
            this.ceclosed.CheckedChanged += new System.EventHandler(this.ceclosed_CheckedChanged);
            // 
            // tbwrem
            // 
            this.tbwrem.EditValue = "";
            this.tbwrem.Location = new System.Drawing.Point(26, 133);
            this.tbwrem.Name = "tbwrem";
            this.tbwrem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbwrem.Properties.Appearance.Options.UseFont = true;
            this.tbwrem.Size = new System.Drawing.Size(200, 96);
            this.tbwrem.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(361, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "العمل";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(342, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "التفاصيل";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Location = new System.Drawing.Point(367, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "العدد";
            // 
            // tbwno
            // 
            this.tbwno.Location = new System.Drawing.Point(26, 69);
            this.tbwno.Name = "tbwno";
            this.tbwno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbwno.Properties.Appearance.Options.UseFont = true;
            this.tbwno.Properties.DisplayFormat.FormatString = "n0";
            this.tbwno.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbwno.Properties.EditFormat.FormatString = "n0";
            this.tbwno.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbwno.Properties.Mask.EditMask = "n0";
            this.tbwno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbwno.Size = new System.Drawing.Size(200, 26);
            this.tbwno.TabIndex = 2;
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
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // cDWorkTypeTableAdapter
            // 
            this.cDWorkTypeTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(361, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "التاريخ";
            // 
            // deworkdate
            // 
            this.deworkdate.EditValue = null;
            this.deworkdate.Location = new System.Drawing.Point(26, 101);
            this.deworkdate.Name = "deworkdate";
            this.deworkdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deworkdate.Properties.Appearance.Options.UseFont = true;
            this.deworkdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deworkdate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deworkdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deworkdate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deworkdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deworkdate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deworkdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deworkdate.Size = new System.Drawing.Size(200, 26);
            this.deworkdate.TabIndex = 3;
            // 
            // TBLEmpWorkWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(450, 385);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TBLEmpWorkWFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحرير";
            this.Load += new System.EventHandler(this.FormWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpGeneral.ResumeLayout(false);
            this.xtpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEWorkTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDWorkTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceclosed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbwrem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbwno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deworkdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deworkdate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lueSyndicateId;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpGeneral;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName;
        private DevExpress.XtraGrid.Columns.GridColumn colYearName;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName1;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbwno;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ceclosed;
        private DevExpress.XtraEditors.MemoEdit tbwrem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource cDWorkTypeBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDWorkTypeTableAdapter cDWorkTypeTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit LUEWorkTypeId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit deworkdate;
    }
}