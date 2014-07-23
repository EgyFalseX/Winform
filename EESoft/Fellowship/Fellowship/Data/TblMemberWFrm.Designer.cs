namespace Fellowship
{
    partial class TblMemberWFrm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dSFellowship = new Fellowship.DataSources.DSFellowship();
            this.tbMemberName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbMemberAddress = new DevExpress.XtraEditors.TextEdit();
            this.deBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lueStateID = new DevExpress.XtraEditors.LookUpEdit();
            this.cDStateBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lueEdaraId = new DevExpress.XtraEditors.LookUpEdit();
            this.cDEDARETBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lueSyndicateId = new DevExpress.XtraEditors.LookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbKidnumber = new DevExpress.XtraEditors.TextEdit();
            this.tbMobile = new DevExpress.XtraEditors.TextEdit();
            this.deEhalaDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lueJobtitleID = new DevExpress.XtraEditors.LookUpEdit();
            this.cDJobBindingSource = new System.Windows.Forms.BindingSource();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cDEDARETTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.CDEDARETTableAdapter();
            this.cDSyndicateTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.CDSyndicateTableAdapter();
            this.cDStateTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.CDStateTableAdapter();
            this.cDJobTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.CDJobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStateID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEdaraId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDARETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKidnumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEhalaDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEhalaDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueJobtitleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(346, 341);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الموبيل";
            // 
            // dSFellowship
            // 
            this.dSFellowship.DataSetName = "DSFellowship";
            this.dSFellowship.Locale = new System.Globalization.CultureInfo("en-US");
            this.dSFellowship.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMemberName
            // 
            this.tbMemberName.EditValue = "";
            this.tbMemberName.Location = new System.Drawing.Point(18, 75);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMemberName.Properties.Appearance.Options.UseFont = true;
            this.tbMemberName.Size = new System.Drawing.Size(200, 26);
            this.tbMemberName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(353, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "الاسم";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(316, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تاريخ الميلاد";
            // 
            // tbMemberAddress
            // 
            this.tbMemberAddress.Location = new System.Drawing.Point(18, 304);
            this.tbMemberAddress.Name = "tbMemberAddress";
            this.tbMemberAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMemberAddress.Properties.Appearance.Options.UseFont = true;
            this.tbMemberAddress.Size = new System.Drawing.Size(200, 26);
            this.tbMemberAddress.TabIndex = 8;
            // 
            // deBirthDate
            // 
            this.deBirthDate.EditValue = null;
            this.deBirthDate.Location = new System.Drawing.Point(18, 109);
            this.deBirthDate.Name = "deBirthDate";
            this.deBirthDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deBirthDate.Properties.Appearance.Options.UseFont = true;
            this.deBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deBirthDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deBirthDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deBirthDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deBirthDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deBirthDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deBirthDate.Size = new System.Drawing.Size(200, 26);
            this.deBirthDate.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(349, 307);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "العنوان";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Location = new System.Drawing.Point(333, 176);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "رقم القيد";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Location = new System.Drawing.Point(355, 46);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 19);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "الحالة";
            // 
            // lueStateID
            // 
            this.lueStateID.Location = new System.Drawing.Point(18, 43);
            this.lueStateID.Name = "lueStateID";
            this.lueStateID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueStateID.Properties.Appearance.Options.UseFont = true;
            this.lueStateID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStateID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StateName", 100, "الاسم")});
            this.lueStateID.Properties.DataSource = this.cDStateBindingSource;
            this.lueStateID.Properties.DisplayMember = "StateName";
            this.lueStateID.Properties.NullText = "";
            this.lueStateID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueStateID.Properties.ValueMember = "StateID";
            this.lueStateID.Size = new System.Drawing.Size(200, 26);
            this.lueStateID.TabIndex = 0;
            // 
            // cDStateBindingSource
            // 
            this.cDStateBindingSource.DataMember = "CDState";
            this.cDStateBindingSource.DataSource = this.dSFellowship;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl9.Location = new System.Drawing.Point(355, 240);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 19);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "الادارة";
            // 
            // lueEdaraId
            // 
            this.lueEdaraId.Location = new System.Drawing.Point(18, 237);
            this.lueEdaraId.Name = "lueEdaraId";
            this.lueEdaraId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueEdaraId.Properties.Appearance.Options.UseFont = true;
            this.lueEdaraId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEdaraId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EDARET", "الاسم")});
            this.lueEdaraId.Properties.DataSource = this.cDEDARETBindingSource;
            this.lueEdaraId.Properties.DisplayMember = "EDARET";
            this.lueEdaraId.Properties.NullText = "";
            this.lueEdaraId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueEdaraId.Properties.ValueMember = "EdaraId";
            this.lueEdaraId.Size = new System.Drawing.Size(200, 26);
            this.lueEdaraId.TabIndex = 6;
            this.lueEdaraId.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lueEdaraId_QueryPopUp);
            // 
            // cDEDARETBindingSource
            // 
            this.cDEDARETBindingSource.DataMember = "CDEDARET";
            this.cDEDARETBindingSource.DataSource = this.dSFellowship;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Location = new System.Drawing.Point(353, 272);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 19);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "النقابة";
            // 
            // lueSyndicateId
            // 
            this.lueSyndicateId.Location = new System.Drawing.Point(18, 269);
            this.lueSyndicateId.Name = "lueSyndicateId";
            this.lueSyndicateId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueSyndicateId.Properties.Appearance.Options.UseFont = true;
            this.lueSyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyndicateId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الاسم")});
            this.lueSyndicateId.Properties.DataSource = this.cDSyndicateBindingSource;
            this.lueSyndicateId.Properties.DisplayMember = "Syndicate";
            this.lueSyndicateId.Properties.NullText = "";
            this.lueSyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyndicateId.Properties.ValueMember = "SyndicateId";
            this.lueSyndicateId.Size = new System.Drawing.Size(200, 26);
            this.lueSyndicateId.TabIndex = 7;
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dSFellowship;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.CaptionImage = global::Fellowship.Properties.Resources.Edit;
            this.groupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl1.Controls.Add(this.tbKidnumber);
            this.groupControl1.Controls.Add(this.tbMobile);
            this.groupControl1.Controls.Add(this.tbMemberName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.deEhalaDate);
            this.groupControl1.Controls.Add(this.deBirthDate);
            this.groupControl1.Controls.Add(this.lueStateID);
            this.groupControl1.Controls.Add(this.tbMemberAddress);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.lueJobtitleID);
            this.groupControl1.Controls.Add(this.lueEdaraId);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lueSyndicateId);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(417, 377);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "البيانات";
            // 
            // tbKidnumber
            // 
            this.tbKidnumber.Location = new System.Drawing.Point(18, 173);
            this.tbKidnumber.Name = "tbKidnumber";
            this.tbKidnumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbKidnumber.Properties.Appearance.Options.UseFont = true;
            this.tbKidnumber.Size = new System.Drawing.Size(200, 26);
            this.tbKidnumber.TabIndex = 4;
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(18, 338);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMobile.Properties.Appearance.Options.UseFont = true;
            this.tbMobile.Size = new System.Drawing.Size(200, 26);
            this.tbMobile.TabIndex = 9;
            // 
            // deEhalaDate
            // 
            this.deEhalaDate.EditValue = null;
            this.deEhalaDate.Location = new System.Drawing.Point(18, 141);
            this.deEhalaDate.Name = "deEhalaDate";
            this.deEhalaDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deEhalaDate.Properties.Appearance.Options.UseFont = true;
            this.deEhalaDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEhalaDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deEhalaDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deEhalaDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deEhalaDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deEhalaDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deEhalaDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deEhalaDate.Size = new System.Drawing.Size(200, 26);
            this.deEhalaDate.TabIndex = 3;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl11.Location = new System.Drawing.Point(344, 208);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(50, 19);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "الوظيفة";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl8.Location = new System.Drawing.Point(315, 144);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 19);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "تاريخ الاحالة";
            // 
            // lueJobtitleID
            // 
            this.lueJobtitleID.Location = new System.Drawing.Point(18, 205);
            this.lueJobtitleID.Name = "lueJobtitleID";
            this.lueJobtitleID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueJobtitleID.Properties.Appearance.Options.UseFont = true;
            this.lueJobtitleID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueJobtitleID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Jobtitle", "الاسم")});
            this.lueJobtitleID.Properties.DataSource = this.cDJobBindingSource;
            this.lueJobtitleID.Properties.DisplayMember = "Jobtitle";
            this.lueJobtitleID.Properties.NullText = "";
            this.lueJobtitleID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueJobtitleID.Properties.ValueMember = "JobtitleID";
            this.lueJobtitleID.Size = new System.Drawing.Size(200, 26);
            this.lueJobtitleID.TabIndex = 5;
            this.lueJobtitleID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lueEdaraId_QueryPopUp);
            // 
            // cDJobBindingSource
            // 
            this.cDJobBindingSource.DataMember = "CDJob";
            this.cDJobBindingSource.DataSource = this.dSFellowship;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Location = new System.Drawing.Point(12, 395);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(417, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Fellowship.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(262, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفـــــــــــــــــــــــــظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::Fellowship.Properties.Resources.Delete;
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(5, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cDEDARETTableAdapter
            // 
            this.cDEDARETTableAdapter.ClearBeforeFill = true;
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // cDStateTableAdapter
            // 
            this.cDStateTableAdapter.ClearBeforeFill = true;
            // 
            // cDJobTableAdapter
            // 
            this.cDJobTableAdapter.ClearBeforeFill = true;
            // 
            // TblMemberWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(443, 446);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TblMemberWFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحرير";
            this.Load += new System.EventHandler(this.TBLSheekWaredWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStateID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEdaraId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDEDARETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKidnumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEhalaDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEhalaDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueJobtitleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbMemberName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbMemberAddress;
        private DevExpress.XtraEditors.DateEdit deBirthDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lueStateID;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lueEdaraId;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lueSyndicateId;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DataSources.DSFellowship dSFellowship;
        private System.Windows.Forms.BindingSource cDEDARETBindingSource;
        private DataSources.DSFellowshipTableAdapters.CDEDARETTableAdapter cDEDARETTableAdapter;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.DSFellowshipTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbMobile;
        private DevExpress.XtraEditors.TextEdit tbKidnumber;
        private System.Windows.Forms.BindingSource cDStateBindingSource;
        private DataSources.DSFellowshipTableAdapters.CDStateTableAdapter cDStateTableAdapter;
        private DevExpress.XtraEditors.DateEdit deEhalaDate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LookUpEdit lueJobtitleID;
        private System.Windows.Forms.BindingSource cDJobBindingSource;
        private DataSources.DSFellowshipTableAdapters.CDJobTableAdapter cDJobTableAdapter;
    }
}