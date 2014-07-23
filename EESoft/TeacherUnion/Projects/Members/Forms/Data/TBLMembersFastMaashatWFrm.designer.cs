namespace Members
{
    partial class TBLMembersFastMaashatWFrm
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
            this.tbKideNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.lueJobtitleID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cDJobtitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJobtitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueSubCommitteId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cDSubCommitteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueSyndicateId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMemberName = new DevExpress.XtraEditors.TextEdit();
            this.tbMemberNId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.colMonthName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDSyndicateTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter();
            this.cDSubCommitteTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSubCommitteTableAdapter();
            this.colGehaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGehaName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDJobtitleTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDJobtitleTableAdapter();
            this.ceShadetKed = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKideNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueJobtitleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDJobtitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSubCommitteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSubCommitteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberNId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShadetKed.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKideNumber
            // 
            this.tbKideNumber.EditValue = "";
            this.tbKideNumber.Location = new System.Drawing.Point(110, 53);
            this.tbKideNumber.Name = "tbKideNumber";
            this.tbKideNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbKideNumber.Properties.Appearance.Options.UseFont = true;
            this.tbKideNumber.Size = new System.Drawing.Size(277, 26);
            this.tbKideNumber.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(429, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "رقم القيد";
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
            this.panelControl1.Location = new System.Drawing.Point(5, 311);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(601, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Members.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(446, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 7;
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
            this.xtraTabControl1.Size = new System.Drawing.Size(606, 300);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpGeneral});
            // 
            // xtpGeneral
            // 
            this.xtpGeneral.Controls.Add(this.ceShadetKed);
            this.xtpGeneral.Controls.Add(this.lueJobtitleID);
            this.xtpGeneral.Controls.Add(this.lueSubCommitteId);
            this.xtpGeneral.Controls.Add(this.lueSyndicateId);
            this.xtpGeneral.Controls.Add(this.tbMemberName);
            this.xtpGeneral.Controls.Add(this.tbMemberNId);
            this.xtpGeneral.Controls.Add(this.tbKideNumber);
            this.xtpGeneral.Controls.Add(this.labelControl1);
            this.xtpGeneral.Controls.Add(this.labelControl5);
            this.xtpGeneral.Controls.Add(this.labelControl4);
            this.xtpGeneral.Controls.Add(this.labelControl3);
            this.xtpGeneral.Controls.Add(this.labelControl6);
            this.xtpGeneral.Controls.Add(this.labelControl2);
            this.xtpGeneral.Image = global::Members.Properties.Resources.Edit;
            this.xtpGeneral.Name = "xtpGeneral";
            this.xtpGeneral.Size = new System.Drawing.Size(600, 253);
            this.xtpGeneral.Text = "بيانات أساسيه";
            // 
            // lueJobtitleID
            // 
            this.lueJobtitleID.EditValue = "";
            this.lueJobtitleID.Location = new System.Drawing.Point(110, 149);
            this.lueJobtitleID.Name = "lueJobtitleID";
            this.lueJobtitleID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueJobtitleID.Properties.Appearance.Options.UseFont = true;
            this.lueJobtitleID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueJobtitleID.Properties.DataSource = this.cDJobtitleBindingSource;
            this.lueJobtitleID.Properties.DisplayMember = "Jobtitle";
            this.lueJobtitleID.Properties.NullText = "";
            this.lueJobtitleID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueJobtitleID.Properties.ValueMember = "JobtitleID";
            this.lueJobtitleID.Properties.View = this.gridView3;
            this.lueJobtitleID.Size = new System.Drawing.Size(277, 26);
            this.lueJobtitleID.TabIndex = 5;
            // 
            // cDJobtitleBindingSource
            // 
            this.cDJobtitleBindingSource.DataMember = "CDJobtitle";
            this.cDJobtitleBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJobtitle});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colJobtitle
            // 
            this.colJobtitle.AppearanceCell.Options.UseTextOptions = true;
            this.colJobtitle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobtitle.AppearanceHeader.Options.UseTextOptions = true;
            this.colJobtitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobtitle.Caption = "الوظيفة";
            this.colJobtitle.FieldName = "Jobtitle";
            this.colJobtitle.Name = "colJobtitle";
            this.colJobtitle.Visible = true;
            this.colJobtitle.VisibleIndex = 0;
            // 
            // lueSubCommitteId
            // 
            this.lueSubCommitteId.EditValue = "";
            this.lueSubCommitteId.Location = new System.Drawing.Point(110, 117);
            this.lueSubCommitteId.Name = "lueSubCommitteId";
            this.lueSubCommitteId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueSubCommitteId.Properties.Appearance.Options.UseFont = true;
            this.lueSubCommitteId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSubCommitteId.Properties.DataSource = this.cDSubCommitteBindingSource;
            this.lueSubCommitteId.Properties.DisplayMember = "SubCommitte";
            this.lueSubCommitteId.Properties.NullText = "";
            this.lueSubCommitteId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSubCommitteId.Properties.ValueMember = "SubCommitteId";
            this.lueSubCommitteId.Properties.View = this.gridView1;
            this.lueSubCommitteId.Size = new System.Drawing.Size(277, 26);
            this.lueSubCommitteId.TabIndex = 4;
            // 
            // cDSubCommitteBindingSource
            // 
            this.cDSubCommitteBindingSource.DataMember = "CDSubCommitte";
            this.cDSubCommitteBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubCommitte});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "الاسم";
            this.colSubCommitte.FieldName = "SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 0;
            // 
            // lueSyndicateId
            // 
            this.lueSyndicateId.EditValue = "";
            this.lueSyndicateId.Location = new System.Drawing.Point(110, 85);
            this.lueSyndicateId.Name = "lueSyndicateId";
            this.lueSyndicateId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueSyndicateId.Properties.Appearance.Options.UseFont = true;
            this.lueSyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyndicateId.Properties.DataSource = this.cDSyndicateBindingSource;
            this.lueSyndicateId.Properties.DisplayMember = "Syndicate";
            this.lueSyndicateId.Properties.NullText = "";
            this.lueSyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyndicateId.Properties.ValueMember = "SyndicateId";
            this.lueSyndicateId.Properties.View = this.gridLookUpEdit1View;
            this.lueSyndicateId.Size = new System.Drawing.Size(277, 26);
            this.lueSyndicateId.TabIndex = 3;
            this.lueSyndicateId.EditValueChanged += new System.EventHandler(this.lueSyndicateId_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate});
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
            this.colSyndicate.Caption = "النقابة";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 0;
            // 
            // tbMemberName
            // 
            this.tbMemberName.EditValue = "";
            this.tbMemberName.Location = new System.Drawing.Point(110, 21);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMemberName.Properties.Appearance.Options.UseFont = true;
            this.tbMemberName.Size = new System.Drawing.Size(277, 26);
            this.tbMemberName.TabIndex = 0;
            // 
            // tbMemberNId
            // 
            this.tbMemberNId.EditValue = "";
            this.tbMemberNId.Location = new System.Drawing.Point(110, 181);
            this.tbMemberNId.Name = "tbMemberNId";
            this.tbMemberNId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMemberNId.Properties.Appearance.Options.UseFont = true;
            this.tbMemberNId.Properties.DisplayFormat.FormatString = "n0";
            this.tbMemberNId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbMemberNId.Properties.EditFormat.FormatString = "n0";
            this.tbMemberNId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbMemberNId.Properties.Mask.EditMask = "n0";
            this.tbMemberNId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbMemberNId.Properties.MaxLength = 14;
            this.tbMemberNId.Size = new System.Drawing.Size(277, 26);
            this.tbMemberNId.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(440, 152);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الوظيفة";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Location = new System.Drawing.Point(418, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "اسم العضو";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(449, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "اللجنة";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(413, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "رقم القومي";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Location = new System.Drawing.Point(396, 88);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "النقابة الفرعية";
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
            // cDSubCommitteTableAdapter
            // 
            this.cDSubCommitteTableAdapter.ClearBeforeFill = true;
            // 
            // colGehaName
            // 
            this.colGehaName.AppearanceCell.Options.UseTextOptions = true;
            this.colGehaName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaName.AppearanceHeader.Options.UseTextOptions = true;
            this.colGehaName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaName.Caption = "النوع";
            this.colGehaName.FieldName = "GehaName";
            this.colGehaName.Name = "colGehaName";
            this.colGehaName.Visible = true;
            this.colGehaName.VisibleIndex = 0;
            // 
            // colGehaName1
            // 
            this.colGehaName1.AppearanceCell.Options.UseTextOptions = true;
            this.colGehaName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGehaName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaName1.Caption = "الاسم";
            this.colGehaName1.FieldName = "GehaName";
            this.colGehaName1.Name = "colGehaName1";
            this.colGehaName1.Visible = true;
            this.colGehaName1.VisibleIndex = 0;
            // 
            // cDJobtitleTableAdapter
            // 
            this.cDJobtitleTableAdapter.ClearBeforeFill = true;
            // 
            // ceShadetKed
            // 
            this.ceShadetKed.Location = new System.Drawing.Point(273, 213);
            this.ceShadetKed.Name = "ceShadetKed";
            this.ceShadetKed.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ceShadetKed.Properties.Appearance.Options.UseFont = true;
            this.ceShadetKed.Properties.Caption = "شهادة القيد";
            this.ceShadetKed.Size = new System.Drawing.Size(114, 24);
            this.ceShadetKed.TabIndex = 7;
            // 
            // TBLMembersFastMaashatWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TBLMembersFastMaashatWFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحرير";
            this.Load += new System.EventHandler(this.FormWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbKideNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpGeneral.ResumeLayout(false);
            this.xtpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueJobtitleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDJobtitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSubCommitteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSubCommitteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberNId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShadetKed.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbKideNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
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
        private DevExpress.XtraEditors.GridLookUpEdit lueSyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDetails;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraEditors.TextEdit tbMemberName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit lueSubCommitteId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.BindingSource cDSubCommitteBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSubCommitteTableAdapter cDSubCommitteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGehaName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colGehaName1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSadad;
        private DevExpress.XtraEditors.GridLookUpEdit lueJobtitleID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource cDJobtitleBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDJobtitleTableAdapter cDJobtitleTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colJobtitle;
        private DevExpress.XtraEditors.TextEdit tbMemberNId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit ceShadetKed;
    }
}