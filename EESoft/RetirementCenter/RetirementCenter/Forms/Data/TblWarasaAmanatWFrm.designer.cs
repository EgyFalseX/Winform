namespace RetirementCenter
{
    partial class TblWarasaAmanatWFrm
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.luePersonId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSTBLWarasa = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueDofatSarfAId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cdDofaatAmanatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDofatSarfDatefrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDofatSarfDateto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbamanatrem = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbamanatmony = new DevExpress.XtraEditors.TextEdit();
            this.colMonthName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cdDofaatAmanatTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.CdDofaatAmanatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luePersonId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLWarasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDofatSarfAId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDofaatAmanatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbamanatrem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbamanatmony.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(388, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "اسم العضو";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(412, 123);
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
            this.xtpGeneral.Controls.Add(this.btnSave);
            this.xtpGeneral.Controls.Add(this.luePersonId);
            this.xtpGeneral.Controls.Add(this.lueDofatSarfAId);
            this.xtpGeneral.Controls.Add(this.tbamanatrem);
            this.xtpGeneral.Controls.Add(this.labelControl6);
            this.xtpGeneral.Controls.Add(this.labelControl2);
            this.xtpGeneral.Controls.Add(this.labelControl1);
            this.xtpGeneral.Controls.Add(this.labelControl4);
            this.xtpGeneral.Controls.Add(this.tbamanatmony);
            this.xtpGeneral.Image = global::RetirementCenter.Properties.Resources.Edit;
            this.xtpGeneral.Name = "xtpGeneral";
            this.xtpGeneral.Size = new System.Drawing.Size(519, 305);
            this.xtpGeneral.Text = "بيانات أساسيه";
            // 
            // luePersonId
            // 
            this.luePersonId.EditValue = "";
            this.luePersonId.Location = new System.Drawing.Point(53, 46);
            this.luePersonId.Name = "luePersonId";
            this.luePersonId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.luePersonId.Properties.Appearance.Options.UseFont = true;
            this.luePersonId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePersonId.Properties.DataSource = this.LSMSTBLWarasa;
            this.luePersonId.Properties.DisplayMember = "personName";
            this.luePersonId.Properties.NullText = "";
            this.luePersonId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luePersonId.Properties.ValueMember = "PersonId";
            this.luePersonId.Properties.View = this.gridView1;
            this.luePersonId.Size = new System.Drawing.Size(233, 26);
            this.luePersonId.TabIndex = 1;
            // 
            // LSMSTBLWarasa
            // 
            this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLWarasa_TBLMashat);
            this.LSMSTBLWarasa.KeyExpression = "PersonId";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colsarfnumber,
            this.colSyndicate1,
            this.colSubCommitte});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "personName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم صرف";
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 1;
            // 
            // colSyndicate1
            // 
            this.colSyndicate1.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.Caption = "فرعية";
            this.colSyndicate1.FieldName = "Syndicate";
            this.colSyndicate1.Name = "colSyndicate1";
            this.colSyndicate1.Visible = true;
            this.colSyndicate1.VisibleIndex = 3;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "لجنة";
            this.colSubCommitte.FieldName = "SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 2;
            // 
            // lueDofatSarfAId
            // 
            this.lueDofatSarfAId.EditValue = "";
            this.lueDofatSarfAId.Location = new System.Drawing.Point(53, 10);
            this.lueDofatSarfAId.Name = "lueDofatSarfAId";
            this.lueDofatSarfAId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueDofatSarfAId.Properties.Appearance.Options.UseFont = true;
            this.lueDofatSarfAId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDofatSarfAId.Properties.DataSource = this.cdDofaatAmanatBindingSource;
            this.lueDofatSarfAId.Properties.DisplayMember = "DofatSarfA";
            this.lueDofatSarfAId.Properties.NullText = "";
            this.lueDofatSarfAId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDofatSarfAId.Properties.ValueMember = "DofatSarfAId";
            this.lueDofatSarfAId.Properties.View = this.gridLookUpEdit1View;
            this.lueDofatSarfAId.Size = new System.Drawing.Size(233, 26);
            this.lueDofatSarfAId.TabIndex = 0;
            this.lueDofatSarfAId.EditValueChanged += new System.EventHandler(this.lueDofatSarfAId_EditValueChanged);
            // 
            // cdDofaatAmanatBindingSource
            // 
            this.cdDofaatAmanatBindingSource.DataMember = "CdDofaatAmanat";
            this.cdDofaatAmanatBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate,
            this.colDofatSarfDatefrom,
            this.colDofatSarfDateto});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "الاسم";
            this.colSyndicate.FieldName = "DofatSarfA";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 0;
            // 
            // colDofatSarfDatefrom
            // 
            this.colDofatSarfDatefrom.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarfDatefrom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfDatefrom.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarfDatefrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfDatefrom.Caption = "من";
            this.colDofatSarfDatefrom.FieldName = "DofatSarfDatefrom";
            this.colDofatSarfDatefrom.Name = "colDofatSarfDatefrom";
            this.colDofatSarfDatefrom.Visible = true;
            this.colDofatSarfDatefrom.VisibleIndex = 1;
            // 
            // colDofatSarfDateto
            // 
            this.colDofatSarfDateto.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarfDateto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfDateto.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarfDateto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfDateto.Caption = "الي";
            this.colDofatSarfDateto.FieldName = "DofatSarfDateto";
            this.colDofatSarfDateto.Name = "colDofatSarfDateto";
            this.colDofatSarfDateto.Visible = true;
            this.colDofatSarfDateto.VisibleIndex = 2;
            // 
            // tbamanatrem
            // 
            this.tbamanatrem.Location = new System.Drawing.Point(53, 125);
            this.tbamanatrem.Name = "tbamanatrem";
            this.tbamanatrem.Size = new System.Drawing.Size(233, 80);
            this.tbamanatrem.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Location = new System.Drawing.Point(418, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "الدفعة";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(420, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "المبلغ";
            // 
            // tbamanatmony
            // 
            this.tbamanatmony.Location = new System.Drawing.Point(53, 84);
            this.tbamanatmony.Name = "tbamanatmony";
            this.tbamanatmony.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbamanatmony.Properties.Appearance.Options.UseFont = true;
            this.tbamanatmony.Properties.DisplayFormat.FormatString = "f2";
            this.tbamanatmony.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbamanatmony.Properties.EditFormat.FormatString = "f2";
            this.tbamanatmony.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbamanatmony.Properties.Mask.EditMask = "f2";
            this.tbamanatmony.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbamanatmony.Size = new System.Drawing.Size(233, 26);
            this.tbamanatmony.TabIndex = 2;
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
            // cdDofaatAmanatTableAdapter
            // 
            this.cdDofaatAmanatTableAdapter.ClearBeforeFill = true;
            // 
            // TblWarasaAmanatWFrm
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
            this.Name = "TblWarasaAmanatWFrm";
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
            ((System.ComponentModel.ISupportInitialize)(this.luePersonId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLWarasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDofatSarfAId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDofaatAmanatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbamanatrem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbamanatmony.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbamanatmony;
        private DevExpress.XtraEditors.MemoEdit tbamanatrem;
        private DevExpress.XtraEditors.GridLookUpEdit lueDofatSarfAId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDetails;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraEditors.GridLookUpEdit luePersonId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource cdDofaatAmanatBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.CdDofaatAmanatTableAdapter cdDofaatAmanatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarfDatefrom;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarfDateto;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLWarasa;
    }
}