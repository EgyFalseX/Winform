namespace Members
{
    partial class TblMemberAttachFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TblMemberAttachFrm));
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gcOptions = new DevExpress.XtraEditors.GroupControl();
            this.btnPath = new DevExpress.XtraEditors.SimpleButton();
            this.peimg = new DevExpress.XtraEditors.PictureEdit();
            this.lblSyndicate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblesalno = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblKideNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LUEMembers = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSMembers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDetails = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tblMemberAttachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAttachmentTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditAttahcmentTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cDAttachmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachmentImg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditAttachInfo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.tblMemberAttachTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TblMemberAttachTableAdapter();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cDAttachmentTypeTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDAttachmentTypeTableAdapter();
            this.colAttachmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOptions)).BeginInit();
            this.gcOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peimg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEMembers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).BeginInit();
            this.gcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMemberAttachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditAttahcmentTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDAttachmentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditAttachInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcOptions
            // 
            this.gcOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOptions.AppearanceCaption.Options.UseTextOptions = true;
            this.gcOptions.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcOptions.Controls.Add(this.btnPath);
            this.gcOptions.Controls.Add(this.peimg);
            this.gcOptions.Controls.Add(this.lblSyndicate);
            this.gcOptions.Controls.Add(this.labelControl4);
            this.gcOptions.Controls.Add(this.lblesalno);
            this.gcOptions.Controls.Add(this.labelControl3);
            this.gcOptions.Controls.Add(this.lblKideNumber);
            this.gcOptions.Controls.Add(this.labelControl2);
            this.gcOptions.Controls.Add(this.labelControl1);
            this.gcOptions.Controls.Add(this.LUEMembers);
            this.gcOptions.Location = new System.Drawing.Point(12, 12);
            this.gcOptions.Name = "gcOptions";
            this.gcOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcOptions.Size = new System.Drawing.Size(568, 139);
            this.gcOptions.TabIndex = 0;
            this.gcOptions.Text = "الاعضاء";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(111, 97);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "مسار المرفقات";
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // peimg
            // 
            this.peimg.Location = new System.Drawing.Point(5, 24);
            this.peimg.Name = "peimg";
            this.peimg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peimg.Size = new System.Drawing.Size(100, 96);
            this.peimg.TabIndex = 1;
            // 
            // lblSyndicate
            // 
            this.lblSyndicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSyndicate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSyndicate.Location = new System.Drawing.Point(252, 116);
            this.lblSyndicate.Name = "lblSyndicate";
            this.lblSyndicate.Size = new System.Drawing.Size(250, 13);
            this.lblSyndicate.TabIndex = 0;
            this.lblSyndicate.Text = "-";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(529, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "الفرعية";
            // 
            // lblesalno
            // 
            this.lblesalno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblesalno.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblesalno.Location = new System.Drawing.Point(252, 97);
            this.lblesalno.Name = "lblesalno";
            this.lblesalno.Size = new System.Drawing.Size(250, 13);
            this.lblesalno.TabIndex = 0;
            this.lblesalno.Text = "-";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(511, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "رقم الايصال";
            // 
            // lblKideNumber
            // 
            this.lblKideNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKideNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblKideNumber.Location = new System.Drawing.Point(252, 78);
            this.lblKideNumber.Name = "lblKideNumber";
            this.lblKideNumber.Size = new System.Drawing.Size(250, 13);
            this.lblKideNumber.TabIndex = 0;
            this.lblKideNumber.Text = "-";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(521, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "رقم القيد";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(530, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الاعضاء";
            // 
            // LUEMembers
            // 
            this.LUEMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LUEMembers.Location = new System.Drawing.Point(111, 29);
            this.LUEMembers.Name = "LUEMembers";
            this.LUEMembers.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LUEMembers.Properties.Appearance.Options.UseFont = true;
            this.LUEMembers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEMembers.Properties.DataSource = this.LSMSMembers;
            this.LUEMembers.Properties.DisplayMember = "MemberName";
            this.LUEMembers.Properties.NullText = "";
            this.LUEMembers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEMembers.Properties.ValueMember = "MemberId";
            this.LUEMembers.Properties.View = this.gridLookUpEdit1View;
            this.LUEMembers.Size = new System.Drawing.Size(391, 26);
            this.LUEMembers.TabIndex = 0;
            this.LUEMembers.EditValueChanged += new System.EventHandler(this.LUEMembers_EditValueChanged);
            // 
            // LSMSMembers
            // 
            this.LSMSMembers.ElementType = typeof(Members.DataSources.Linq.vTBLMembersPlusTblMemberAttach);
            this.LSMSMembers.KeyExpression = "[MemberId]";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberName,
            this.colSyndicate,
            this.colKideNumber,
            this.colesalno,
            this.colAttachCount});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMemberName
            // 
            this.colMemberName.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName.Caption = "الاسم";
            this.colMemberName.FieldName = "MemberName";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 0;
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
            this.colSyndicate.VisibleIndex = 1;
            // 
            // colKideNumber
            // 
            this.colKideNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colKideNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKideNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colKideNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKideNumber.Caption = "رقم القيد";
            this.colKideNumber.FieldName = "KideNumber";
            this.colKideNumber.Name = "colKideNumber";
            this.colKideNumber.Visible = true;
            this.colKideNumber.VisibleIndex = 2;
            // 
            // colesalno
            // 
            this.colesalno.AppearanceCell.Options.UseTextOptions = true;
            this.colesalno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalno.AppearanceHeader.Options.UseTextOptions = true;
            this.colesalno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalno.Caption = "رقم الايصال";
            this.colesalno.FieldName = "esalno";
            this.colesalno.Name = "colesalno";
            this.colesalno.Visible = true;
            this.colesalno.VisibleIndex = 3;
            // 
            // colAttachCount
            // 
            this.colAttachCount.AppearanceCell.Options.UseTextOptions = true;
            this.colAttachCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachCount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachCount.Caption = "عدد المرفقات";
            this.colAttachCount.FieldName = "AttachCount";
            this.colAttachCount.Name = "colAttachCount";
            this.colAttachCount.Visible = true;
            this.colAttachCount.VisibleIndex = 4;
            // 
            // gcDetails
            // 
            this.gcDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDetails.AppearanceCaption.Options.UseTextOptions = true;
            this.gcDetails.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDetails.Controls.Add(this.gridControlData);
            this.gcDetails.Enabled = false;
            this.gcDetails.Location = new System.Drawing.Point(12, 157);
            this.gcDetails.Name = "gcDetails";
            this.gcDetails.Size = new System.Drawing.Size(568, 254);
            this.gcDetails.TabIndex = 1;
            this.gcDetails.Text = "التفاضيل";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tblMemberAttachBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDel,
            this.repositoryItemGridLookUpEditAttahcmentTypeId,
            this.repositoryItemMemoExEditAttachInfo,
            this.repositoryItemButtonEditEdit,
            this.repositoryItemImageComboBox1});
            this.gridControlData.Size = new System.Drawing.Size(564, 231);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tblMemberAttachBindingSource
            // 
            this.tblMemberAttachBindingSource.DataMember = "TblMemberAttach";
            this.tblMemberAttachBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAttachmentTypeId,
            this.colAttachInfo,
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة مرفق";
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.RowHeight = 34;
            this.gridViewData.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewData_InvalidRowException);
            // 
            // colAttachmentTypeId
            // 
            this.colAttachmentTypeId.AppearanceCell.Options.UseTextOptions = true;
            this.colAttachmentTypeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentTypeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachmentTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentTypeId.Caption = "النوع";
            this.colAttachmentTypeId.ColumnEdit = this.repositoryItemGridLookUpEditAttahcmentTypeId;
            this.colAttachmentTypeId.FieldName = "AttachmentTypeId";
            this.colAttachmentTypeId.Name = "colAttachmentTypeId";
            this.colAttachmentTypeId.Visible = true;
            this.colAttachmentTypeId.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEditAttahcmentTypeId
            // 
            this.repositoryItemGridLookUpEditAttahcmentTypeId.AutoHeight = false;
            this.repositoryItemGridLookUpEditAttahcmentTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditAttahcmentTypeId.DataSource = this.cDAttachmentTypeBindingSource;
            this.repositoryItemGridLookUpEditAttahcmentTypeId.DisplayMember = "AttachmentName";
            this.repositoryItemGridLookUpEditAttahcmentTypeId.Name = "repositoryItemGridLookUpEditAttahcmentTypeId";
            this.repositoryItemGridLookUpEditAttahcmentTypeId.NullText = "";
            this.repositoryItemGridLookUpEditAttahcmentTypeId.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.repositoryItemGridLookUpEditAttahcmentTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditAttahcmentTypeId.ValueMember = "AttachmentTypeId";
            this.repositoryItemGridLookUpEditAttahcmentTypeId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // cDAttachmentTypeBindingSource
            // 
            this.cDAttachmentTypeBindingSource.DataMember = "CDAttachmentType";
            this.cDAttachmentTypeBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.colAttachmentImg});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.RowHeight = 32;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "اسم النوع";
            this.gridColumn3.FieldName = "AttachmentName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 192;
            // 
            // colAttachmentImg
            // 
            this.colAttachmentImg.AppearanceCell.Options.UseTextOptions = true;
            this.colAttachmentImg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentImg.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachmentImg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentImg.Caption = "صوره";
            this.colAttachmentImg.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colAttachmentImg.FieldName = "AttachmentImg";
            this.colAttachmentImg.Name = "colAttachmentImg";
            this.colAttachmentImg.Visible = true;
            this.colAttachmentImg.VisibleIndex = 1;
            this.colAttachmentImg.Width = 32;
            // 
            // colAttachInfo
            // 
            this.colAttachInfo.AppearanceCell.Options.UseTextOptions = true;
            this.colAttachInfo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachInfo.Caption = "معلومات";
            this.colAttachInfo.ColumnEdit = this.repositoryItemMemoExEditAttachInfo;
            this.colAttachInfo.FieldName = "AttachInfo";
            this.colAttachInfo.Name = "colAttachInfo";
            this.colAttachInfo.Visible = true;
            this.colAttachInfo.VisibleIndex = 1;
            // 
            // repositoryItemMemoExEditAttachInfo
            // 
            this.repositoryItemMemoExEditAttachInfo.AutoHeight = false;
            this.repositoryItemMemoExEditAttachInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditAttachInfo.Name = "repositoryItemMemoExEditAttachInfo";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "اوامر";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 144;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "حذف";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 46;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // tblMemberAttachTableAdapter
            // 
            this.tblMemberAttachTableAdapter.ClearBeforeFill = true;
            // 
            // ofd
            // 
            this.ofd.Filter = "All Files(*)|*.*|Images(*.Jpg)|*.jpg";
            // 
            // cDAttachmentTypeTableAdapter
            // 
            this.cDAttachmentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // colAttachmentName
            // 
            this.colAttachmentName.AppearanceCell.Options.UseTextOptions = true;
            this.colAttachmentName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentName.Caption = "اسم النوع";
            this.colAttachmentName.FieldName = "AttachmentName";
            this.colAttachmentName.Name = "colAttachmentName";
            this.colAttachmentName.Visible = true;
            this.colAttachmentName.VisibleIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(105, 35);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // TblMemberAttachFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 423);
            this.Controls.Add(this.gcDetails);
            this.Controls.Add(this.gcOptions);
            this.Name = "TblMemberAttachFrm";
            this.Text = "المرفقات";
            this.Load += new System.EventHandler(this.MemberAttachFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOptions)).EndInit();
            this.gcOptions.ResumeLayout(false);
            this.gcOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peimg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEMembers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).EndInit();
            this.gcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMemberAttachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditAttahcmentTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDAttachmentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditAttachInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcOptions;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl gcDetails;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private System.Windows.Forms.BindingSource tblMemberAttachBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TblMemberAttachTableAdapter tblMemberAttachTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditAttahcmentTypeId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource cDAttachmentTypeBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDAttachmentTypeTableAdapter cDAttachmentTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditAttachInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentImg;
        private DevExpress.XtraEditors.GridLookUpEdit LUEMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno;
        private DevExpress.XtraEditors.LabelControl lblKideNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblesalno;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblSyndicate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit peimg;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSMembers;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachCount;
        private DevExpress.XtraEditors.SimpleButton btnPath;
    }
}