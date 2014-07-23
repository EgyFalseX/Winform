namespace Members.Forms.Data
{
    partial class TBLMemberEsalatFrm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.peimg = new DevExpress.XtraEditors.PictureEdit();
            this.lblSyndicate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblesalno = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblKideNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LUEMem = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tBLMembersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalno1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tBLMemberEsalatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colesalno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesaldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colesalmony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditf2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colesalremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEditMem = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tBLMembersListTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMembersListTableAdapter();
            this.tBLMemberEsalatTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMemberEsalatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peimg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEMem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMembersListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMemberEsalatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.peimg);
            this.groupControl1.Controls.Add(this.lblSyndicate);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.lblesalno);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblKideNumber);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.LUEMem);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(668, 126);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "الاعضاء";
            // 
            // peimg
            // 
            this.peimg.Location = new System.Drawing.Point(5, 25);
            this.peimg.Name = "peimg";
            this.peimg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peimg.Size = new System.Drawing.Size(100, 96);
            this.peimg.TabIndex = 12;
            // 
            // lblSyndicate
            // 
            this.lblSyndicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSyndicate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSyndicate.Location = new System.Drawing.Point(345, 100);
            this.lblSyndicate.Name = "lblSyndicate";
            this.lblSyndicate.Size = new System.Drawing.Size(250, 13);
            this.lblSyndicate.TabIndex = 6;
            this.lblSyndicate.Text = "-";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(622, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "الفرعية";
            // 
            // lblesalno
            // 
            this.lblesalno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblesalno.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblesalno.Location = new System.Drawing.Point(345, 81);
            this.lblesalno.Name = "lblesalno";
            this.lblesalno.Size = new System.Drawing.Size(250, 13);
            this.lblesalno.TabIndex = 8;
            this.lblesalno.Text = "-";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(604, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "رقم الايصال";
            // 
            // lblKideNumber
            // 
            this.lblKideNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKideNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblKideNumber.Location = new System.Drawing.Point(345, 62);
            this.lblKideNumber.Name = "lblKideNumber";
            this.lblKideNumber.Size = new System.Drawing.Size(250, 13);
            this.lblKideNumber.TabIndex = 10;
            this.lblKideNumber.Text = "-";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(614, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "رقم القيد";
            // 
            // LUEMem
            // 
            this.LUEMem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LUEMem.EditValue = "";
            this.LUEMem.Location = new System.Drawing.Point(366, 36);
            this.LUEMem.Name = "LUEMem";
            this.LUEMem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEMem.Properties.DataSource = this.tBLMembersListBindingSource;
            this.LUEMem.Properties.DisplayMember = "MemberName";
            this.LUEMem.Properties.NullText = "";
            this.LUEMem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEMem.Properties.ValueMember = "MemberId";
            this.LUEMem.Properties.View = this.gridLookUpEdit2View;
            this.LUEMem.Size = new System.Drawing.Size(249, 20);
            this.LUEMem.TabIndex = 5;
            this.LUEMem.EditValueChanged += new System.EventHandler(this.LUEMem_EditValueChanged);
            // 
            // tBLMembersListBindingSource
            // 
            this.tBLMembersListBindingSource.DataMember = "TBLMembersList";
            this.tBLMembersListBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberName1,
            this.colKideNumber1,
            this.colesalno1,
            this.colSyndicate1});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit2View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colMemberName1
            // 
            this.colMemberName1.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName1.Caption = "الاسم";
            this.colMemberName1.FieldName = "MemberName";
            this.colMemberName1.Name = "colMemberName1";
            this.colMemberName1.Visible = true;
            this.colMemberName1.VisibleIndex = 0;
            // 
            // colKideNumber1
            // 
            this.colKideNumber1.AppearanceCell.Options.UseTextOptions = true;
            this.colKideNumber1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKideNumber1.AppearanceHeader.Options.UseTextOptions = true;
            this.colKideNumber1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKideNumber1.Caption = "رقم القيد";
            this.colKideNumber1.FieldName = "KideNumber";
            this.colKideNumber1.Name = "colKideNumber1";
            this.colKideNumber1.Visible = true;
            this.colKideNumber1.VisibleIndex = 1;
            // 
            // colesalno1
            // 
            this.colesalno1.AppearanceCell.Options.UseTextOptions = true;
            this.colesalno1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalno1.AppearanceHeader.Options.UseTextOptions = true;
            this.colesalno1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalno1.Caption = "رقم الايصال";
            this.colesalno1.FieldName = "esalno";
            this.colesalno1.Name = "colesalno1";
            this.colesalno1.Visible = true;
            this.colesalno1.VisibleIndex = 2;
            // 
            // colSyndicate1
            // 
            this.colSyndicate1.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.Caption = "النقابة";
            this.colSyndicate1.FieldName = "Syndicate";
            this.colSyndicate1.Name = "colSyndicate1";
            this.colSyndicate1.OptionsColumn.ReadOnly = true;
            this.colSyndicate1.Visible = true;
            this.colSyndicate1.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(634, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "عضو";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.gridControlData);
            this.groupControl3.Location = new System.Drawing.Point(12, 157);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(668, 204);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "تفاصيل للحافظة";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLMemberEsalatBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditEdit,
            this.repositoryItemDateEditDMY,
            this.repositoryItemCalcEditf2,
            this.repositoryItemButtonEditDelete,
            this.repositoryItemMemoEditMem});
            this.gridControlData.Size = new System.Drawing.Size(664, 181);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tBLMemberEsalatBindingSource
            // 
            this.tBLMemberEsalatBindingSource.DataMember = "TBLMemberEsalat";
            this.tBLMemberEsalatBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colesalno,
            this.colesaldate,
            this.colesalmony,
            this.colesalremark,
            this.colEdit,
            this.colDelete});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضعظ لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewData_InitNewRow);
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
            this.colesalno.VisibleIndex = 0;
            this.colesalno.Width = 82;
            // 
            // colesaldate
            // 
            this.colesaldate.AppearanceCell.Options.UseTextOptions = true;
            this.colesaldate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesaldate.AppearanceHeader.Options.UseTextOptions = true;
            this.colesaldate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesaldate.Caption = "التاريخ";
            this.colesaldate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colesaldate.FieldName = "esaldate";
            this.colesaldate.Name = "colesaldate";
            this.colesaldate.Visible = true;
            this.colesaldate.VisibleIndex = 1;
            this.colesaldate.Width = 82;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colesalmony
            // 
            this.colesalmony.AppearanceCell.Options.UseTextOptions = true;
            this.colesalmony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalmony.AppearanceHeader.Options.UseTextOptions = true;
            this.colesalmony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalmony.Caption = "المبلغ";
            this.colesalmony.ColumnEdit = this.repositoryItemCalcEditf2;
            this.colesalmony.FieldName = "esalmony";
            this.colesalmony.Name = "colesalmony";
            this.colesalmony.Visible = true;
            this.colesalmony.VisibleIndex = 2;
            this.colesalmony.Width = 71;
            // 
            // repositoryItemCalcEditf2
            // 
            this.repositoryItemCalcEditf2.AutoHeight = false;
            this.repositoryItemCalcEditf2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditf2.DisplayFormat.FormatString = "f2";
            this.repositoryItemCalcEditf2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditf2.EditFormat.FormatString = "f2";
            this.repositoryItemCalcEditf2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditf2.Mask.EditMask = "f2";
            this.repositoryItemCalcEditf2.Name = "repositoryItemCalcEditf2";
            // 
            // colesalremark
            // 
            this.colesalremark.AppearanceCell.Options.UseTextOptions = true;
            this.colesalremark.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalremark.AppearanceHeader.Options.UseTextOptions = true;
            this.colesalremark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalremark.Caption = "ملاحظات";
            this.colesalremark.ColumnEdit = this.repositoryItemMemoEditMem;
            this.colesalremark.FieldName = "esalremark";
            this.colesalremark.Name = "colesalremark";
            this.colesalremark.Visible = true;
            this.colesalremark.VisibleIndex = 3;
            this.colesalremark.Width = 319;
            // 
            // repositoryItemMemoEditMem
            // 
            this.repositoryItemMemoEditMem.Name = "repositoryItemMemoEditMem";
            // 
            // colEdit
            // 
            this.colEdit.AppearanceCell.Options.UseTextOptions = true;
            this.colEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdit.Caption = "حفظ";
            this.colEdit.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 4;
            this.colEdit.Width = 52;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // colDelete
            // 
            this.colDelete.AppearanceCell.Options.UseTextOptions = true;
            this.colDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDelete.Caption = "حذف";
            this.colDelete.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 5;
            this.colDelete.Width = 36;
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDelete_ButtonClick);
            // 
            // tBLMembersListTableAdapter
            // 
            this.tBLMembersListTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMemberEsalatTableAdapter
            // 
            this.tBLMemberEsalatTableAdapter.ClearBeforeFill = true;
            // 
            // TBLMemberEsalatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "TBLMemberEsalatFrm";
            this.Text = "حافظة ويب للقيد تعديل";
            this.Load += new System.EventHandler(this.TBLHafzawebFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peimg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEMem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMembersListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMemberEsalatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraEditors.GridLookUpEdit LUEMem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLMembersListBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLMembersListTableAdapter tBLMembersListTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName1;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno1;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DataSources.dsTeachersUnionTableAdapters.TBLMemberEsalatTableAdapter tBLMemberEsalatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colesaldate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn colesalmony;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditf2;
        private DevExpress.XtraGrid.Columns.GridColumn colesalremark;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEditMem;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private System.Windows.Forms.BindingSource tBLMemberEsalatBindingSource;
        private DevExpress.XtraEditors.LabelControl lblSyndicate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblesalno;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblKideNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit peimg;
    }
}