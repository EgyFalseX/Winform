namespace GM.Forms.Code
{
    partial class BillEditorWFrm
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
            this.wizardControlMain = new DevExpress.XtraWizard.WizardControl();
            this.ceAutoOpen = new DevExpress.XtraEditors.CheckEdit();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.billDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGM = new GM.DataSources.dsGM();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditItemId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditQuin = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.BillDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.OwnerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OwnerAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OwnerPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NotesTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.BillIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BillEndIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmployeeIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.guaranteeIdSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.PlumberIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.plumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNationalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlumberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlumberMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlumberPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlumberAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TraderIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.traderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTraderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTraderSiteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTraderMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTraderPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTraderAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CardValueTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBillId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOwnerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOwnerAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNotes = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForguaranteeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBillEndId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPlumberId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOwnerPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBillDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmployeeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTraderId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCardValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new GM.DataSources.dsGMTableAdapters.BillTableAdapter();
            this.employeeTableAdapter = new GM.DataSources.dsGMTableAdapters.EmployeeTableAdapter();
            this.plumberTableAdapter = new GM.DataSources.dsGMTableAdapters.PlumberTableAdapter();
            this.traderTableAdapter = new GM.DataSources.dsGMTableAdapters.TraderTableAdapter();
            this.billDetailsTableAdapter = new GM.DataSources.dsGMTableAdapters.BillDetailsTableAdapter();
            this.itemTableAdapter = new GM.DataSources.dsGMTableAdapters.ItemTableAdapter();
            this.gcItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlMain)).BeginInit();
            this.wizardControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoOpen.Properties)).BeginInit();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditItemId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditQuin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillEndIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteeIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardValueTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBillId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOwnerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOwnerAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForguaranteeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBillEndId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOwnerPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCardValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControlMain
            // 
            this.wizardControlMain.Controls.Add(this.ceAutoOpen);
            this.wizardControlMain.Controls.Add(this.welcomeWizardPage1);
            this.wizardControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControlMain.FinishText = "&Save";
            this.wizardControlMain.Location = new System.Drawing.Point(0, 0);
            this.wizardControlMain.Name = "wizardControlMain";
            this.wizardControlMain.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1});
            this.wizardControlMain.Size = new System.Drawing.Size(729, 621);
            this.wizardControlMain.Text = "شاشة تسجيل المعاينات";
            this.wizardControlMain.UseCancelButton = false;
            this.wizardControlMain.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControlMain.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControlMain_CancelClick);
            this.wizardControlMain.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // ceAutoOpen
            // 
            this.ceAutoOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ceAutoOpen.Location = new System.Drawing.Point(38, 590);
            this.ceAutoOpen.Name = "ceAutoOpen";
            this.ceAutoOpen.Properties.Caption = "Auto Open";
            this.ceAutoOpen.Size = new System.Drawing.Size(75, 19);
            this.ceAutoOpen.TabIndex = 2;
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.gridControlMain);
            this.welcomeWizardPage1.Controls.Add(this.dataLayoutControl1);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(669, 459);
            this.welcomeWizardPage1.Text = "بيانات المعاينة";
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.billDetailsBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 217);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDelete,
            this.repositoryItemGridLookUpEditItemId,
            this.repositoryItemTextEditQuin});
            this.gridControlMain.Size = new System.Drawing.Size(669, 242);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // billDetailsBindingSource
            // 
            this.billDetailsBindingSource.DataMember = "BillDetails";
            this.billDetailsBindingSource.DataSource = this.dsGM;
            // 
            // dsGM
            // 
            this.dsGM.DataSetName = "dsGM";
            this.dsGM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemId,
            this.gcItemName,
            this.colQuin,
            this.colPoint,
            this.gridColumnDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "New";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewMain_InitNewRow);
            this.gridViewMain.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewMain_CustomUnboundColumnData);
            // 
            // colItemId
            // 
            this.colItemId.AppearanceCell.Options.UseTextOptions = true;
            this.colItemId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemId.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemId.Caption = "Item ID";
            this.colItemId.ColumnEdit = this.repositoryItemGridLookUpEditItemId;
            this.colItemId.FieldName = "ItemId";
            this.colItemId.Name = "colItemId";
            this.colItemId.Visible = true;
            this.colItemId.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEditItemId
            // 
            this.repositoryItemGridLookUpEditItemId.AutoHeight = false;
            this.repositoryItemGridLookUpEditItemId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditItemId.DataSource = this.itemBindingSource;
            this.repositoryItemGridLookUpEditItemId.DisplayMember = "ItemId";
            this.repositoryItemGridLookUpEditItemId.Name = "repositoryItemGridLookUpEditItemId";
            this.repositoryItemGridLookUpEditItemId.NullText = "";
            this.repositoryItemGridLookUpEditItemId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditItemId.ValueMember = "ItemId";
            this.repositoryItemGridLookUpEditItemId.View = this.gridView3;
            this.repositoryItemGridLookUpEditItemId.EditValueChanged += new System.EventHandler(this.repositoryItemGridLookUpEditItemId_EditValueChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dsGM;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemId1,
            this.colItemName,
            this.colItemPoint});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colItemId1
            // 
            this.colItemId1.FieldName = "ItemId";
            this.colItemId1.Name = "colItemId1";
            this.colItemId1.Visible = true;
            this.colItemId1.VisibleIndex = 0;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            // 
            // colItemPoint
            // 
            this.colItemPoint.FieldName = "ItemPoint";
            this.colItemPoint.Name = "colItemPoint";
            this.colItemPoint.Visible = true;
            this.colItemPoint.VisibleIndex = 2;
            // 
            // colQuin
            // 
            this.colQuin.AppearanceCell.Options.UseTextOptions = true;
            this.colQuin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuin.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuin.Caption = "Quin";
            this.colQuin.ColumnEdit = this.repositoryItemTextEditQuin;
            this.colQuin.FieldName = "Quin";
            this.colQuin.Name = "colQuin";
            this.colQuin.Visible = true;
            this.colQuin.VisibleIndex = 2;
            // 
            // repositoryItemTextEditQuin
            // 
            this.repositoryItemTextEditQuin.AutoHeight = false;
            this.repositoryItemTextEditQuin.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEditQuin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditQuin.EditFormat.FormatString = "n0";
            this.repositoryItemTextEditQuin.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditQuin.Mask.EditMask = "n0";
            this.repositoryItemTextEditQuin.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditQuin.Name = "repositoryItemTextEditQuin";
            this.repositoryItemTextEditQuin.EditValueChanged += new System.EventHandler(this.repositoryItemTextEditQuin_EditValueChanged);
            // 
            // colPoint
            // 
            this.colPoint.AppearanceCell.Options.UseTextOptions = true;
            this.colPoint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPoint.AppearanceHeader.Options.UseTextOptions = true;
            this.colPoint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPoint.Caption = "Points";
            this.colPoint.FieldName = "Point";
            this.colPoint.Name = "colPoint";
            this.colPoint.OptionsColumn.AllowEdit = false;
            this.colPoint.OptionsColumn.AllowFocus = false;
            this.colPoint.OptionsColumn.ReadOnly = true;
            this.colPoint.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Point", "{0}")});
            this.colPoint.Visible = true;
            this.colPoint.VisibleIndex = 3;
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.Caption = "Delete";
            this.gridColumnDelete.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.OptionsColumn.AllowFocus = false;
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 4;
            this.gridColumnDelete.Width = 86;
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.BillDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.OwnerNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.OwnerAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.OwnerPhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NotesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BillIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BillEndIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmployeeIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.guaranteeIdSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.PlumberIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TraderIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CardValueTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1035, 410, 452, 485);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(669, 217);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // BillDateDateEdit
            // 
            this.BillDateDateEdit.EditValue = null;
            this.BillDateDateEdit.EnterMoveNextControl = true;
            this.BillDateDateEdit.Location = new System.Drawing.Point(497, 12);
            this.BillDateDateEdit.Name = "BillDateDateEdit";
            this.BillDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BillDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BillDateDateEdit.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.BillDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.BillDateDateEdit.Properties.EditFormat.FormatString = "d/M/yyyy";
            this.BillDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.BillDateDateEdit.Properties.Mask.EditMask = "d/M/yyyy";
            this.BillDateDateEdit.Size = new System.Drawing.Size(160, 20);
            this.BillDateDateEdit.StyleController = this.dataLayoutControl1;
            this.BillDateDateEdit.TabIndex = 2;
            // 
            // OwnerNameTextEdit
            // 
            this.OwnerNameTextEdit.EnterMoveNextControl = true;
            this.OwnerNameTextEdit.Location = new System.Drawing.Point(89, 84);
            this.OwnerNameTextEdit.Name = "OwnerNameTextEdit";
            this.OwnerNameTextEdit.Size = new System.Drawing.Size(325, 20);
            this.OwnerNameTextEdit.StyleController = this.dataLayoutControl1;
            this.OwnerNameTextEdit.TabIndex = 7;
            // 
            // OwnerAddressTextEdit
            // 
            this.OwnerAddressTextEdit.EnterMoveNextControl = true;
            this.OwnerAddressTextEdit.Location = new System.Drawing.Point(89, 108);
            this.OwnerAddressTextEdit.Name = "OwnerAddressTextEdit";
            this.OwnerAddressTextEdit.Size = new System.Drawing.Size(568, 20);
            this.OwnerAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.OwnerAddressTextEdit.TabIndex = 9;
            // 
            // OwnerPhoneTextEdit
            // 
            this.OwnerPhoneTextEdit.EnterMoveNextControl = true;
            this.OwnerPhoneTextEdit.Location = new System.Drawing.Point(495, 84);
            this.OwnerPhoneTextEdit.Name = "OwnerPhoneTextEdit";
            this.OwnerPhoneTextEdit.Size = new System.Drawing.Size(162, 20);
            this.OwnerPhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.OwnerPhoneTextEdit.TabIndex = 8;
            // 
            // NotesTextEdit
            // 
            this.NotesTextEdit.EnterMoveNextControl = true;
            this.NotesTextEdit.Location = new System.Drawing.Point(342, 132);
            this.NotesTextEdit.Name = "NotesTextEdit";
            this.NotesTextEdit.Size = new System.Drawing.Size(315, 73);
            this.NotesTextEdit.StyleController = this.dataLayoutControl1;
            this.NotesTextEdit.TabIndex = 99;
            this.NotesTextEdit.TabStop = false;
            this.NotesTextEdit.UseOptimizedRendering = true;
            // 
            // BillIdTextEdit
            // 
            this.BillIdTextEdit.EditValue = "";
            this.BillIdTextEdit.EnterMoveNextControl = true;
            this.BillIdTextEdit.Location = new System.Drawing.Point(89, 12);
            this.BillIdTextEdit.Name = "BillIdTextEdit";
            this.BillIdTextEdit.Properties.DisplayFormat.FormatString = "n0";
            this.BillIdTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BillIdTextEdit.Properties.EditFormat.FormatString = "n0";
            this.BillIdTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BillIdTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.BillIdTextEdit.Size = new System.Drawing.Size(129, 20);
            this.BillIdTextEdit.StyleController = this.dataLayoutControl1;
            this.BillIdTextEdit.TabIndex = 0;
            // 
            // BillEndIdTextEdit
            // 
            this.BillEndIdTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.BillEndIdTextEdit.EnterMoveNextControl = true;
            this.BillEndIdTextEdit.Location = new System.Drawing.Point(299, 12);
            this.BillEndIdTextEdit.Name = "BillEndIdTextEdit";
            this.BillEndIdTextEdit.Properties.DisplayFormat.FormatString = "n0";
            this.BillEndIdTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BillEndIdTextEdit.Properties.EditFormat.FormatString = "n0";
            this.BillEndIdTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BillEndIdTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.BillEndIdTextEdit.Size = new System.Drawing.Size(117, 20);
            this.BillEndIdTextEdit.StyleController = this.dataLayoutControl1;
            this.BillEndIdTextEdit.TabIndex = 1;
            // 
            // EmployeeIdTextEdit
            // 
            this.EmployeeIdTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EmployeeIdTextEdit.EnterMoveNextControl = true;
            this.EmployeeIdTextEdit.Location = new System.Drawing.Point(89, 36);
            this.EmployeeIdTextEdit.Name = "EmployeeIdTextEdit";
            this.EmployeeIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmployeeIdTextEdit.Properties.DataSource = this.employeeBindingSource;
            this.EmployeeIdTextEdit.Properties.DisplayMember = "EmployeeName";
            this.EmployeeIdTextEdit.Properties.NullText = "";
            this.EmployeeIdTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.EmployeeIdTextEdit.Properties.ValueMember = "EmployeeId";
            this.EmployeeIdTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.EmployeeIdTextEdit.Size = new System.Drawing.Size(234, 20);
            this.EmployeeIdTextEdit.StyleController = this.dataLayoutControl1;
            this.EmployeeIdTextEdit.TabIndex = 3;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dsGM;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeName,
            this.colEmployeePhone,
            this.colEmployeeAddress});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            // 
            // colEmployeePhone
            // 
            this.colEmployeePhone.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeePhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeePhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeePhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeePhone.FieldName = "EmployeePhone";
            this.colEmployeePhone.Name = "colEmployeePhone";
            this.colEmployeePhone.Visible = true;
            this.colEmployeePhone.VisibleIndex = 1;
            // 
            // colEmployeeAddress
            // 
            this.colEmployeeAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeAddress.FieldName = "EmployeeAddress";
            this.colEmployeeAddress.Name = "colEmployeeAddress";
            this.colEmployeeAddress.Visible = true;
            this.colEmployeeAddress.VisibleIndex = 2;
            // 
            // guaranteeIdSpinEdit
            // 
            this.guaranteeIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.guaranteeIdSpinEdit.EnterMoveNextControl = true;
            this.guaranteeIdSpinEdit.Location = new System.Drawing.Point(404, 36);
            this.guaranteeIdSpinEdit.Name = "guaranteeIdSpinEdit";
            this.guaranteeIdSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.guaranteeIdSpinEdit.Size = new System.Drawing.Size(253, 20);
            this.guaranteeIdSpinEdit.StyleController = this.dataLayoutControl1;
            this.guaranteeIdSpinEdit.TabIndex = 4;
            // 
            // PlumberIdTextEdit
            // 
            this.PlumberIdTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PlumberIdTextEdit.EnterMoveNextControl = true;
            this.PlumberIdTextEdit.Location = new System.Drawing.Point(89, 60);
            this.PlumberIdTextEdit.Name = "PlumberIdTextEdit";
            this.PlumberIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PlumberIdTextEdit.Properties.DataSource = this.plumberBindingSource;
            this.PlumberIdTextEdit.Properties.DisplayMember = "PlumberName";
            this.PlumberIdTextEdit.Properties.NullText = "";
            this.PlumberIdTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.PlumberIdTextEdit.Properties.ValueMember = "PlumberId";
            this.PlumberIdTextEdit.Properties.View = this.gridView1;
            this.PlumberIdTextEdit.Size = new System.Drawing.Size(234, 20);
            this.PlumberIdTextEdit.StyleController = this.dataLayoutControl1;
            this.PlumberIdTextEdit.TabIndex = 5;
            // 
            // plumberBindingSource
            // 
            this.plumberBindingSource.DataMember = "Plumber";
            this.plumberBindingSource.DataSource = this.dsGM;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNationalId,
            this.colPlumberName,
            this.colPlumberMobile,
            this.colPlumberPhone,
            this.colPlumberAddress});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNationalId
            // 
            this.colNationalId.AppearanceCell.Options.UseTextOptions = true;
            this.colNationalId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNationalId.AppearanceHeader.Options.UseTextOptions = true;
            this.colNationalId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNationalId.FieldName = "NationalId";
            this.colNationalId.Name = "colNationalId";
            this.colNationalId.Visible = true;
            this.colNationalId.VisibleIndex = 0;
            // 
            // colPlumberName
            // 
            this.colPlumberName.AppearanceCell.Options.UseTextOptions = true;
            this.colPlumberName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberName.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlumberName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberName.FieldName = "PlumberName";
            this.colPlumberName.Name = "colPlumberName";
            this.colPlumberName.Visible = true;
            this.colPlumberName.VisibleIndex = 1;
            // 
            // colPlumberMobile
            // 
            this.colPlumberMobile.AppearanceCell.Options.UseTextOptions = true;
            this.colPlumberMobile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberMobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlumberMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberMobile.FieldName = "PlumberMobile";
            this.colPlumberMobile.Name = "colPlumberMobile";
            this.colPlumberMobile.Visible = true;
            this.colPlumberMobile.VisibleIndex = 2;
            // 
            // colPlumberPhone
            // 
            this.colPlumberPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colPlumberPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlumberPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberPhone.FieldName = "PlumberPhone";
            this.colPlumberPhone.Name = "colPlumberPhone";
            this.colPlumberPhone.Visible = true;
            this.colPlumberPhone.VisibleIndex = 3;
            // 
            // colPlumberAddress
            // 
            this.colPlumberAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colPlumberAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlumberAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlumberAddress.FieldName = "PlumberAddress";
            this.colPlumberAddress.Name = "colPlumberAddress";
            this.colPlumberAddress.Visible = true;
            this.colPlumberAddress.VisibleIndex = 4;
            // 
            // TraderIdTextEdit
            // 
            this.TraderIdTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TraderIdTextEdit.EnterMoveNextControl = true;
            this.TraderIdTextEdit.Location = new System.Drawing.Point(404, 60);
            this.TraderIdTextEdit.Name = "TraderIdTextEdit";
            this.TraderIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TraderIdTextEdit.Properties.DataSource = this.traderBindingSource;
            this.TraderIdTextEdit.Properties.DisplayMember = "TraderName";
            this.TraderIdTextEdit.Properties.NullText = "";
            this.TraderIdTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.TraderIdTextEdit.Properties.ValueMember = "TraderId";
            this.TraderIdTextEdit.Properties.View = this.gridView2;
            this.TraderIdTextEdit.Size = new System.Drawing.Size(253, 20);
            this.TraderIdTextEdit.StyleController = this.dataLayoutControl1;
            this.TraderIdTextEdit.TabIndex = 6;
            // 
            // traderBindingSource
            // 
            this.traderBindingSource.DataMember = "Trader";
            this.traderBindingSource.DataSource = this.dsGM;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTraderName,
            this.colTraderSiteName,
            this.colTraderMobile,
            this.colTraderPhone,
            this.colTraderAddress});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colTraderName
            // 
            this.colTraderName.AppearanceCell.Options.UseTextOptions = true;
            this.colTraderName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderName.AppearanceHeader.Options.UseTextOptions = true;
            this.colTraderName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderName.FieldName = "TraderName";
            this.colTraderName.Name = "colTraderName";
            this.colTraderName.Visible = true;
            this.colTraderName.VisibleIndex = 0;
            // 
            // colTraderSiteName
            // 
            this.colTraderSiteName.AppearanceCell.Options.UseTextOptions = true;
            this.colTraderSiteName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderSiteName.AppearanceHeader.Options.UseTextOptions = true;
            this.colTraderSiteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderSiteName.FieldName = "TraderSiteName";
            this.colTraderSiteName.Name = "colTraderSiteName";
            this.colTraderSiteName.Visible = true;
            this.colTraderSiteName.VisibleIndex = 1;
            // 
            // colTraderMobile
            // 
            this.colTraderMobile.AppearanceCell.Options.UseTextOptions = true;
            this.colTraderMobile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderMobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colTraderMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderMobile.FieldName = "TraderMobile";
            this.colTraderMobile.Name = "colTraderMobile";
            this.colTraderMobile.Visible = true;
            this.colTraderMobile.VisibleIndex = 2;
            // 
            // colTraderPhone
            // 
            this.colTraderPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colTraderPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colTraderPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderPhone.FieldName = "TraderPhone";
            this.colTraderPhone.Name = "colTraderPhone";
            this.colTraderPhone.Visible = true;
            this.colTraderPhone.VisibleIndex = 3;
            // 
            // colTraderAddress
            // 
            this.colTraderAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colTraderAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colTraderAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTraderAddress.FieldName = "TraderAddress";
            this.colTraderAddress.Name = "colTraderAddress";
            this.colTraderAddress.Visible = true;
            this.colTraderAddress.VisibleIndex = 4;
            // 
            // CardValueTextEdit
            // 
            this.CardValueTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CardValueTextEdit.EnterMoveNextControl = true;
            this.CardValueTextEdit.Location = new System.Drawing.Point(89, 132);
            this.CardValueTextEdit.Name = "CardValueTextEdit";
            this.CardValueTextEdit.Properties.DisplayFormat.FormatString = "n0";
            this.CardValueTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CardValueTextEdit.Properties.EditFormat.FormatString = "n0";
            this.CardValueTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CardValueTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.CardValueTextEdit.Properties.Mask.EditMask = "n0";
            this.CardValueTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CardValueTextEdit.Size = new System.Drawing.Size(172, 20);
            this.CardValueTextEdit.StyleController = this.dataLayoutControl1;
            this.CardValueTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(669, 217);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBillId,
            this.ItemForOwnerName,
            this.ItemForOwnerAddress,
            this.ItemForNotes,
            this.ItemForguaranteeId,
            this.ItemForBillEndId,
            this.ItemForPlumberId,
            this.ItemForOwnerPhone,
            this.ItemForBillDate,
            this.ItemForEmployeeId,
            this.ItemForTraderId,
            this.ItemForCardValue});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(649, 197);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForBillId
            // 
            this.ItemForBillId.Control = this.BillIdTextEdit;
            this.ItemForBillId.CustomizationFormText = "Bill Id";
            this.ItemForBillId.Location = new System.Drawing.Point(0, 0);
            this.ItemForBillId.Name = "ItemForBillId";
            this.ItemForBillId.Size = new System.Drawing.Size(210, 24);
            this.ItemForBillId.Text = "Bill Id";
            this.ItemForBillId.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForOwnerName
            // 
            this.ItemForOwnerName.Control = this.OwnerNameTextEdit;
            this.ItemForOwnerName.CustomizationFormText = "Owner Name";
            this.ItemForOwnerName.Location = new System.Drawing.Point(0, 72);
            this.ItemForOwnerName.Name = "ItemForOwnerName";
            this.ItemForOwnerName.Size = new System.Drawing.Size(406, 24);
            this.ItemForOwnerName.Text = "Owner Name";
            this.ItemForOwnerName.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForOwnerAddress
            // 
            this.ItemForOwnerAddress.Control = this.OwnerAddressTextEdit;
            this.ItemForOwnerAddress.CustomizationFormText = "Owner Address";
            this.ItemForOwnerAddress.Location = new System.Drawing.Point(0, 96);
            this.ItemForOwnerAddress.Name = "ItemForOwnerAddress";
            this.ItemForOwnerAddress.Size = new System.Drawing.Size(649, 24);
            this.ItemForOwnerAddress.Text = "Owner Address";
            this.ItemForOwnerAddress.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForNotes
            // 
            this.ItemForNotes.Control = this.NotesTextEdit;
            this.ItemForNotes.CustomizationFormText = "Notes";
            this.ItemForNotes.Location = new System.Drawing.Point(253, 120);
            this.ItemForNotes.Name = "ItemForNotes";
            this.ItemForNotes.Size = new System.Drawing.Size(396, 77);
            this.ItemForNotes.Text = "Notes";
            this.ItemForNotes.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForguaranteeId
            // 
            this.ItemForguaranteeId.Control = this.guaranteeIdSpinEdit;
            this.ItemForguaranteeId.CustomizationFormText = "Guarantee Id";
            this.ItemForguaranteeId.Location = new System.Drawing.Point(315, 24);
            this.ItemForguaranteeId.Name = "ItemForguaranteeId";
            this.ItemForguaranteeId.Size = new System.Drawing.Size(334, 24);
            this.ItemForguaranteeId.Text = "Guarantee Id";
            this.ItemForguaranteeId.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForBillEndId
            // 
            this.ItemForBillEndId.Control = this.BillEndIdTextEdit;
            this.ItemForBillEndId.CustomizationFormText = "Bill End Id";
            this.ItemForBillEndId.Location = new System.Drawing.Point(210, 0);
            this.ItemForBillEndId.Name = "ItemForBillEndId";
            this.ItemForBillEndId.Size = new System.Drawing.Size(198, 24);
            this.ItemForBillEndId.Text = "Bill End Id";
            this.ItemForBillEndId.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForPlumberId
            // 
            this.ItemForPlumberId.Control = this.PlumberIdTextEdit;
            this.ItemForPlumberId.CustomizationFormText = "Plumber";
            this.ItemForPlumberId.Location = new System.Drawing.Point(0, 48);
            this.ItemForPlumberId.Name = "ItemForPlumberId";
            this.ItemForPlumberId.Size = new System.Drawing.Size(315, 24);
            this.ItemForPlumberId.Text = "Plumber";
            this.ItemForPlumberId.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForOwnerPhone
            // 
            this.ItemForOwnerPhone.Control = this.OwnerPhoneTextEdit;
            this.ItemForOwnerPhone.CustomizationFormText = "Owner Phone";
            this.ItemForOwnerPhone.Location = new System.Drawing.Point(406, 72);
            this.ItemForOwnerPhone.Name = "ItemForOwnerPhone";
            this.ItemForOwnerPhone.Size = new System.Drawing.Size(243, 24);
            this.ItemForOwnerPhone.Text = "Owner Phone";
            this.ItemForOwnerPhone.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForBillDate
            // 
            this.ItemForBillDate.Control = this.BillDateDateEdit;
            this.ItemForBillDate.CustomizationFormText = "Bill Date";
            this.ItemForBillDate.Location = new System.Drawing.Point(408, 0);
            this.ItemForBillDate.Name = "ItemForBillDate";
            this.ItemForBillDate.Size = new System.Drawing.Size(241, 24);
            this.ItemForBillDate.Text = "Bill Date";
            this.ItemForBillDate.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForEmployeeId
            // 
            this.ItemForEmployeeId.Control = this.EmployeeIdTextEdit;
            this.ItemForEmployeeId.CustomizationFormText = "Employee";
            this.ItemForEmployeeId.Location = new System.Drawing.Point(0, 24);
            this.ItemForEmployeeId.Name = "ItemForEmployeeId";
            this.ItemForEmployeeId.Size = new System.Drawing.Size(315, 24);
            this.ItemForEmployeeId.Text = "Employee";
            this.ItemForEmployeeId.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForTraderId
            // 
            this.ItemForTraderId.Control = this.TraderIdTextEdit;
            this.ItemForTraderId.CustomizationFormText = "Trader";
            this.ItemForTraderId.Location = new System.Drawing.Point(315, 48);
            this.ItemForTraderId.Name = "ItemForTraderId";
            this.ItemForTraderId.Size = new System.Drawing.Size(334, 24);
            this.ItemForTraderId.Text = "Trader";
            this.ItemForTraderId.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCardValue
            // 
            this.ItemForCardValue.Control = this.CardValueTextEdit;
            this.ItemForCardValue.CustomizationFormText = "Card Value";
            this.ItemForCardValue.Location = new System.Drawing.Point(0, 120);
            this.ItemForCardValue.Name = "ItemForCardValue";
            this.ItemForCardValue.Size = new System.Drawing.Size(253, 77);
            this.ItemForCardValue.Text = "Card Value";
            this.ItemForCardValue.TextSize = new System.Drawing.Size(74, 13);
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.dsGM;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // plumberTableAdapter
            // 
            this.plumberTableAdapter.ClearBeforeFill = true;
            // 
            // traderTableAdapter
            // 
            this.traderTableAdapter.ClearBeforeFill = true;
            // 
            // billDetailsTableAdapter
            // 
            this.billDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // gcItemName
            // 
            this.gcItemName.AppearanceCell.Options.UseTextOptions = true;
            this.gcItemName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcItemName.AppearanceHeader.Options.UseTextOptions = true;
            this.gcItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcItemName.Caption = "Item Name";
            this.gcItemName.FieldName = "gcItemName";
            this.gcItemName.Name = "gcItemName";
            this.gcItemName.OptionsColumn.AllowEdit = false;
            this.gcItemName.OptionsColumn.AllowFocus = false;
            this.gcItemName.OptionsColumn.ReadOnly = true;
            this.gcItemName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gcItemName.Visible = true;
            this.gcItemName.VisibleIndex = 1;
            // 
            // BillEditorWFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 621);
            this.Controls.Add(this.wizardControlMain);
            this.Icon = global::GM.Properties.Resources.MenuOrder16;
            this.Name = "BillEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Shown += new System.EventHandler(this.BillEditorWFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlMain)).EndInit();
            this.wizardControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoOpen.Properties)).EndInit();
            this.welcomeWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditItemId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditQuin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillEndIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteeIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardValueTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBillId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOwnerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOwnerAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForguaranteeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBillEndId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOwnerPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCardValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControlMain;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DataSources.dsGM dsGM;
        private System.Windows.Forms.BindingSource billBindingSource;
        private DataSources.dsGMTableAdapters.BillTableAdapter billTableAdapter;
        private DevExpress.XtraEditors.DateEdit BillDateDateEdit;
        private DevExpress.XtraEditors.TextEdit OwnerNameTextEdit;
        private DevExpress.XtraEditors.TextEdit OwnerAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit OwnerPhoneTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBillId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBillDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployeeId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPlumberId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTraderId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOwnerName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOwnerAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOwnerPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCardValue;
        private DevExpress.XtraLayout.LayoutControlItem ItemForguaranteeId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNotes;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBillEndId;
        private DevExpress.XtraEditors.MemoEdit NotesTextEdit;
        private DevExpress.XtraEditors.TextEdit BillIdTextEdit;
        private DevExpress.XtraEditors.TextEdit BillEndIdTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit EmployeeIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit guaranteeIdSpinEdit;
        private DevExpress.XtraEditors.GridLookUpEdit PlumberIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit TraderIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit CardValueTextEdit;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.dsGMTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeAddress;
        private System.Windows.Forms.BindingSource plumberBindingSource;
        private DataSources.dsGMTableAdapters.PlumberTableAdapter plumberTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNationalId;
        private DevExpress.XtraGrid.Columns.GridColumn colPlumberName;
        private DevExpress.XtraGrid.Columns.GridColumn colPlumberMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colPlumberPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colPlumberAddress;
        private System.Windows.Forms.BindingSource traderBindingSource;
        private DataSources.dsGMTableAdapters.TraderTableAdapter traderTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTraderName;
        private DevExpress.XtraGrid.Columns.GridColumn colTraderSiteName;
        private DevExpress.XtraGrid.Columns.GridColumn colTraderMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colTraderPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colTraderAddress;
        private System.Windows.Forms.BindingSource billDetailsBindingSource;
        private DataSources.dsGMTableAdapters.BillDetailsTableAdapter billDetailsTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataSources.dsGMTableAdapters.ItemTableAdapter itemTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditItemId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPoint;
        private DevExpress.XtraGrid.Columns.GridColumn colQuin;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditQuin;
        private DevExpress.XtraGrid.Columns.GridColumn colPoint;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        public DevExpress.XtraEditors.CheckEdit ceAutoOpen;
        private DevExpress.XtraGrid.Columns.GridColumn gcItemName;
    }
}