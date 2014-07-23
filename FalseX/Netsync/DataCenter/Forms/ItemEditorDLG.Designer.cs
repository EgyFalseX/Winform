namespace DataCenter.Forms
{
    partial class ItemEditorDLG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEditorDLG));
            this.lblParentName = new DevExpress.XtraEditors.LabelControl();
            this.lblModifyIn = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblCreateIn = new DevExpress.XtraEditors.LabelControl();
            this.lblUserIn = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ceLocker = new DevExpress.XtraEditors.CheckEdit();
            this.tbInfo = new DevExpress.XtraEditors.MemoEdit();
            this.tbItemName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcCommands = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageEdit = new DevExpress.XtraTab.XtraTabPage();
            this.btnDownload = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.lueTypeId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.typesBindingSource = new System.Windows.Forms.BindingSource();
            this.dsDataCenter = new DataCenter.DataSources.dsDataCenter();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeIconData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageInfo = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.typesTableAdapter = new DataCenter.DataSources.dsDataCenterTableAdapters.TypesTableAdapter();
            this.pnlProgress = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblLockByLable = new DevExpress.XtraEditors.LabelControl();
            this.lblLockBy = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ceLocker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).BeginInit();
            this.gcCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.xtraTabPageInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgress)).BeginInit();
            this.pnlProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParentName
            // 
            this.lblParentName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblParentName.Location = new System.Drawing.Point(195, 2);
            this.lblParentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(15, 16);
            this.lblParentName.TabIndex = 1;
            this.lblParentName.Text = "---";
            // 
            // lblModifyIn
            // 
            this.lblModifyIn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblModifyIn.Location = new System.Drawing.Point(195, 65);
            this.lblModifyIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblModifyIn.Name = "lblModifyIn";
            this.lblModifyIn.Size = new System.Drawing.Size(15, 16);
            this.lblModifyIn.TabIndex = 0;
            this.lblModifyIn.Text = "---";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(222, 65);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(95, 17);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = ": تاريخ اخر تعديل";
            // 
            // lblCreateIn
            // 
            this.lblCreateIn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCreateIn.Location = new System.Drawing.Point(195, 44);
            this.lblCreateIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCreateIn.Name = "lblCreateIn";
            this.lblCreateIn.Size = new System.Drawing.Size(15, 16);
            this.lblCreateIn.TabIndex = 0;
            this.lblCreateIn.Text = "---";
            // 
            // lblUserIn
            // 
            this.lblUserIn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblUserIn.Location = new System.Drawing.Point(195, 23);
            this.lblUserIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblUserIn.Name = "lblUserIn";
            this.lblUserIn.Size = new System.Drawing.Size(15, 16);
            this.lblUserIn.TabIndex = 0;
            this.lblUserIn.Text = "---";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(237, 44);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 17);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = ": تاريخ الانشاء";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(246, 23);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = ": المستخدم";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(242, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = ": المجلد الاب";
            // 
            // ceLocker
            // 
            this.ceLocker.Location = new System.Drawing.Point(236, 193);
            this.ceLocker.Name = "ceLocker";
            this.ceLocker.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ceLocker.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.ceLocker.Properties.Appearance.Options.UseFont = true;
            this.ceLocker.Properties.Appearance.Options.UseForeColor = true;
            this.ceLocker.Properties.Caption = "متاح";
            this.ceLocker.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.ceLocker.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ceLocker.Properties.PictureChecked = global::DataCenter.Properties.Resources._lock;
            this.ceLocker.Properties.PictureUnchecked = global::DataCenter.Properties.Resources.Unlock;
            this.ceLocker.Size = new System.Drawing.Size(77, 36);
            this.ceLocker.TabIndex = 3;
            this.ceLocker.CheckedChanged += new System.EventHandler(this.ceLocker_CheckedChanged);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(15, 133);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbInfo.Properties.Appearance.Options.UseFont = true;
            this.tbInfo.Properties.MaxLength = 255;
            this.tbInfo.Size = new System.Drawing.Size(200, 96);
            this.tbInfo.TabIndex = 2;
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(15, 70);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbItemName.Properties.Appearance.Options.UseFont = true;
            this.tbItemName.Properties.MaxLength = 50;
            this.tbItemName.Size = new System.Drawing.Size(200, 26);
            this.tbItemName.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(247, 135);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = ": معلومات";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(226, 73);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = ": اسم الملف";
            // 
            // gcCommands
            // 
            this.gcCommands.AppearanceCaption.Options.UseTextOptions = true;
            this.gcCommands.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcCommands.Controls.Add(this.btnClose);
            this.gcCommands.Controls.Add(this.btnSave);
            this.gcCommands.Location = new System.Drawing.Point(12, 338);
            this.gcCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCommands.Name = "gcCommands";
            this.gcCommands.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcCommands.Size = new System.Drawing.Size(334, 61);
            this.gcCommands.TabIndex = 1;
            this.gcCommands.Text = "اوامر";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::DataCenter.Properties.Resources.Delete;
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(6, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DataCenter.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(209, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControlMain.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Far;
            this.xtraTabControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageEdit;
            this.xtraTabControlMain.Size = new System.Drawing.Size(334, 300);
            this.xtraTabControlMain.TabIndex = 0;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageEdit,
            this.xtraTabPageInfo});
            // 
            // xtraTabPageEdit
            // 
            this.xtraTabPageEdit.Controls.Add(this.btnDownload);
            this.xtraTabPageEdit.Controls.Add(this.btnUpload);
            this.xtraTabPageEdit.Controls.Add(this.lueTypeId);
            this.xtraTabPageEdit.Controls.Add(this.ceLocker);
            this.xtraTabPageEdit.Controls.Add(this.tbItemName);
            this.xtraTabPageEdit.Controls.Add(this.tbInfo);
            this.xtraTabPageEdit.Controls.Add(this.labelControl8);
            this.xtraTabPageEdit.Controls.Add(this.labelControl2);
            this.xtraTabPageEdit.Controls.Add(this.labelControl3);
            this.xtraTabPageEdit.Image = global::DataCenter.Properties.Resources.Edit;
            this.xtraTabPageEdit.Name = "xtraTabPageEdit";
            this.xtraTabPageEdit.Size = new System.Drawing.Size(328, 253);
            this.xtraTabPageEdit.Text = "تفاصيل  ";
            // 
            // btnDownload
            // 
            this.btnDownload.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDownload.Appearance.Options.UseFont = true;
            this.btnDownload.Image = global::DataCenter.Properties.Resources.download;
            this.btnDownload.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(15, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 40);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "استقبال";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnUpload.Appearance.Options.UseFont = true;
            this.btnUpload.Image = global::DataCenter.Properties.Resources.upload;
            this.btnUpload.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(213, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 40);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "ارسال";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lueTypeId
            // 
            this.lueTypeId.EditValue = "";
            this.lueTypeId.Location = new System.Drawing.Point(15, 101);
            this.lueTypeId.Name = "lueTypeId";
            this.lueTypeId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueTypeId.Properties.Appearance.Options.UseFont = true;
            this.lueTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTypeId.Properties.DataSource = this.typesBindingSource;
            this.lueTypeId.Properties.DisplayMember = "TypeName";
            this.lueTypeId.Properties.NullText = "";
            this.lueTypeId.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.lueTypeId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTypeId.Properties.ValueMember = "TypeId";
            this.lueTypeId.Properties.View = this.gridLookUpEdit1View;
            this.lueTypeId.Size = new System.Drawing.Size(200, 26);
            this.lueTypeId.TabIndex = 1;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "Types";
            this.typesBindingSource.DataSource = this.dsDataCenter;
            // 
            // dsDataCenter
            // 
            this.dsDataCenter.DataSetName = "dsDataCenter";
            this.dsDataCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeIconData,
            this.colTypeName,
            this.colInfo});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTypeIconData
            // 
            this.colTypeIconData.Caption = "...";
            this.colTypeIconData.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colTypeIconData.FieldName = "TypeIconData";
            this.colTypeIconData.Name = "colTypeIconData";
            this.colTypeIconData.Visible = true;
            this.colTypeIconData.VisibleIndex = 0;
            // 
            // colTypeName
            // 
            this.colTypeName.Caption = "اسم النوع";
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 1;
            // 
            // colInfo
            // 
            this.colInfo.Caption = "معلومات";
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl8.Location = new System.Drawing.Point(236, 104);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 19);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = ": نوع الملف";
            // 
            // xtraTabPageInfo
            // 
            this.xtraTabPageInfo.Controls.Add(this.tableLayoutPanel1);
            this.xtraTabPageInfo.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageInfo.Image")));
            this.xtraTabPageInfo.Name = "xtraTabPageInfo";
            this.xtraTabPageInfo.Size = new System.Drawing.Size(328, 253);
            this.xtraTabPageInfo.Text = "معلومات  ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.5625F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblParentName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModifyIn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserIn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCreateIn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLockByLable, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLockBy, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 236);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pbc
            // 
            this.pbc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbc.Location = new System.Drawing.Point(2, 2);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(262, 18);
            this.pbc.TabIndex = 4;
            // 
            // ofd
            // 
            this.ofd.Filter = "All Files (*.*)|*.*";
            // 
            // sfd
            // 
            this.sfd.AddExtension = false;
            this.sfd.Filter = "All Files (*.*)|*.*";
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.btnCancel);
            this.pnlProgress.Controls.Add(this.pbc);
            this.pnlProgress.Location = new System.Drawing.Point(12, 313);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(329, 22);
            this.pnlProgress.TabIndex = 6;
            this.pnlProgress.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(271, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 18);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "ألغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLockByLable
            // 
            this.lblLockByLable.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLockByLable.Location = new System.Drawing.Point(228, 86);
            this.lblLockByLable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLockByLable.Name = "lblLockByLable";
            this.lblLockByLable.Size = new System.Drawing.Size(89, 17);
            this.lblLockByLable.TabIndex = 2;
            this.lblLockByLable.Text = ": مغلق بواسطة";
            this.lblLockByLable.Visible = false;
            // 
            // lblLockBy
            // 
            this.lblLockBy.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLockBy.Location = new System.Drawing.Point(195, 86);
            this.lblLockBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLockBy.Name = "lblLockBy";
            this.lblLockBy.Size = new System.Drawing.Size(15, 16);
            this.lblLockBy.TabIndex = 3;
            this.lblLockBy.Text = "---";
            this.lblLockBy.Visible = false;
            // 
            // ItemEditorDLG
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(350, 401);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.gcCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ItemEditorDLG";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "محرر الملفات";
            this.Load += new System.EventHandler(this.CategoryEditorDLG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ceLocker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).EndInit();
            this.gcCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageEdit.ResumeLayout(false);
            this.xtraTabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.xtraTabPageInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgress)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblParentName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl gcCommands;
        private DevExpress.XtraEditors.TextEdit tbItemName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit tbInfo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit ceLocker;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblModifyIn;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblUserIn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblCreateIn;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageEdit;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GridLookUpEdit lueTypeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevExpress.XtraEditors.SimpleButton btnDownload;
        private System.Windows.Forms.SaveFileDialog sfd;
        private DataSources.dsDataCenter dsDataCenter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private DataSources.dsDataCenterTableAdapters.TypesTableAdapter typesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeIconData;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraEditors.PanelControl pnlProgress;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblLockByLable;
        private DevExpress.XtraEditors.LabelControl lblLockBy;
    }
}