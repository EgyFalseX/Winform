namespace RetirementCenter
{
    partial class TBLProofDocFrm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditMMashatId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.XPCSTBLMashat = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionTBLMashat = new DevExpress.Xpo.Session(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMashHala = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyasref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditmemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditdatein = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdituserin = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEDARET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDARET1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdaraMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnkapaMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.usersTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter();
            this.tblProofDocTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLProofDocTableAdapter();
            this.tblProofDocbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMMashatId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPCSTBLMashat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTBLMashat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditmemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdatein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdatein.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdituserin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProofDocbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.LSMSData;
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
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDel,
            this.repositoryItemDateEditDMY,
            this.repositoryItemDateEditdatein,
            this.repositoryItemGridLookUpEdituserin,
            this.repositoryItemMemoExEditmemo,
            this.repositoryItemGridLookUpEditMMashatId});
            this.gridControlData.Size = new System.Drawing.Size(756, 273);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLProofDoc);
            this.LSMSData.KeyExpression = "ProofDocId";
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatId,
            this.colmemo,
            this.colDocDate,
            this.coldatein,
            this.coluserin,
            this.gridColumnSave,
            this.gridColumnDelete});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewData_InvalidRowException);
            // 
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "اسم العضو";
            this.colMMashatId.ColumnEdit = this.repositoryItemGridLookUpEditMMashatId;
            this.colMMashatId.FieldName = "MMashatId";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.OptionsColumn.ReadOnly = true;
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 0;
            this.colMMashatId.Width = 150;
            // 
            // repositoryItemGridLookUpEditMMashatId
            // 
            this.repositoryItemGridLookUpEditMMashatId.AutoHeight = false;
            this.repositoryItemGridLookUpEditMMashatId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditMMashatId.DataSource = this.XPCSTBLMashat;
            this.repositoryItemGridLookUpEditMMashatId.DisplayMember = "MMashatName";
            this.repositoryItemGridLookUpEditMMashatId.Name = "repositoryItemGridLookUpEditMMashatId";
            this.repositoryItemGridLookUpEditMMashatId.ValueMember = "MMashatId";
            this.repositoryItemGridLookUpEditMMashatId.View = this.gridView1;
            // 
            // XPCSTBLMashat
            // 
            this.XPCSTBLMashat.ObjectType = typeof(RetirementCenter.DataSources.dsQueries.TBLMashatDataTable);
            this.XPCSTBLMashat.Session = this.sessionTBLMashat;
            // 
            // sessionTBLMashat
            // 
            this.sessionTBLMashat.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatName,
            this.colsarfnumber,
            this.colMashHala,
            this.colSyndicate,
            this.colSubCommitte,
            this.colyasref});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "الاسم";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 1;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم الصرف";
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 0;
            // 
            // colMashHala
            // 
            this.colMashHala.AppearanceCell.Options.UseTextOptions = true;
            this.colMashHala.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHala.AppearanceHeader.Options.UseTextOptions = true;
            this.colMashHala.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHala.Caption = "النوع";
            this.colMashHala.FieldName = "MashHala";
            this.colMashHala.Name = "colMashHala";
            this.colMashHala.Visible = true;
            this.colMashHala.VisibleIndex = 2;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "الفرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 3;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "اللجنة";
            this.colSubCommitte.FieldName = "SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 4;
            // 
            // colyasref
            // 
            this.colyasref.AppearanceCell.Options.UseTextOptions = true;
            this.colyasref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.AppearanceHeader.Options.UseTextOptions = true;
            this.colyasref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.Caption = "يصرف";
            this.colyasref.FieldName = "yasref";
            this.colyasref.Name = "colyasref";
            this.colyasref.Visible = true;
            this.colyasref.VisibleIndex = 5;
            // 
            // colmemo
            // 
            this.colmemo.AppearanceCell.Options.UseTextOptions = true;
            this.colmemo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmemo.AppearanceHeader.Options.UseTextOptions = true;
            this.colmemo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmemo.Caption = "ملاحظات";
            this.colmemo.ColumnEdit = this.repositoryItemMemoExEditmemo;
            this.colmemo.FieldName = "memo";
            this.colmemo.Name = "colmemo";
            this.colmemo.OptionsColumn.ReadOnly = true;
            this.colmemo.Visible = true;
            this.colmemo.VisibleIndex = 1;
            // 
            // repositoryItemMemoExEditmemo
            // 
            this.repositoryItemMemoExEditmemo.AutoHeight = false;
            this.repositoryItemMemoExEditmemo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditmemo.Name = "repositoryItemMemoExEditmemo";
            // 
            // colDocDate
            // 
            this.colDocDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDocDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocDate.Caption = "التاريخ";
            this.colDocDate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.OptionsColumn.ReadOnly = true;
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 2;
            this.colDocDate.Width = 81;
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
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.ColumnEdit = this.repositoryItemDateEditdatein;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.OptionsColumn.AllowEdit = false;
            this.coldatein.OptionsColumn.ReadOnly = true;
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 3;
            this.coldatein.Width = 94;
            // 
            // repositoryItemDateEditdatein
            // 
            this.repositoryItemDateEditdatein.AutoHeight = false;
            this.repositoryItemDateEditdatein.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditdatein.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEditdatein.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditdatein.EditFormat.FormatString = "g";
            this.repositoryItemDateEditdatein.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditdatein.Mask.EditMask = "g";
            this.repositoryItemDateEditdatein.Name = "repositoryItemDateEditdatein";
            this.repositoryItemDateEditdatein.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // coluserin
            // 
            this.coluserin.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.Caption = "مسئول الادخال";
            this.coluserin.ColumnEdit = this.repositoryItemGridLookUpEdituserin;
            this.coluserin.FieldName = "userin";
            this.coluserin.Name = "coluserin";
            this.coluserin.OptionsColumn.AllowEdit = false;
            this.coluserin.OptionsColumn.ReadOnly = true;
            this.coluserin.Visible = true;
            this.coluserin.VisibleIndex = 4;
            this.coluserin.Width = 97;
            // 
            // repositoryItemGridLookUpEdituserin
            // 
            this.repositoryItemGridLookUpEdituserin.AutoHeight = false;
            this.repositoryItemGridLookUpEdituserin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdituserin.DataSource = this.usersBindingSource;
            this.repositoryItemGridLookUpEdituserin.DisplayMember = "RealName";
            this.repositoryItemGridLookUpEdituserin.Name = "repositoryItemGridLookUpEdituserin";
            this.repositoryItemGridLookUpEdituserin.NullText = "";
            this.repositoryItemGridLookUpEdituserin.ValueMember = "UserID";
            this.repositoryItemGridLookUpEdituserin.View = this.gridView2;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnSave
            // 
            this.gridColumnSave.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSave.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSave.Caption = "تعديل";
            this.gridColumnSave.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumnSave.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumnSave.Name = "gridColumnSave";
            this.gridColumnSave.Visible = true;
            this.gridColumnSave.VisibleIndex = 5;
            this.gridColumnSave.Width = 55;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSave_ButtonClick);
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.Caption = "حذف";
            this.gridColumnDelete.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumnDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 6;
            this.gridColumnDelete.Width = 51;
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
            // colEDARET
            // 
            this.colEDARET.AppearanceCell.Options.UseTextOptions = true;
            this.colEDARET.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDARET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET.Caption = "اسم الاداره";
            this.colEDARET.FieldName = "EDARET";
            this.colEDARET.Name = "colEDARET";
            this.colEDARET.Visible = true;
            this.colEDARET.VisibleIndex = 0;
            // 
            // colEDARET1
            // 
            this.colEDARET1.AppearanceCell.Options.UseTextOptions = true;
            this.colEDARET1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET1.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDARET1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET1.Caption = "الادارة";
            this.colEDARET1.FieldName = "EDARET";
            this.colEDARET1.Name = "colEDARET1";
            this.colEDARET1.Visible = true;
            this.colEDARET1.VisibleIndex = 0;
            // 
            // colEdaraMandopName
            // 
            this.colEdaraMandopName.AppearanceCell.Options.UseTextOptions = true;
            this.colEdaraMandopName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdaraMandopName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdaraMandopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdaraMandopName.Caption = "الاسم";
            this.colEdaraMandopName.FieldName = "EdaraMandopName";
            this.colEdaraMandopName.Name = "colEdaraMandopName";
            this.colEdaraMandopName.Visible = true;
            this.colEdaraMandopName.VisibleIndex = 0;
            // 
            // colnkapaMandopName
            // 
            this.colnkapaMandopName.AppearanceCell.Options.UseTextOptions = true;
            this.colnkapaMandopName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopName.AppearanceHeader.Options.UseTextOptions = true;
            this.colnkapaMandopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopName.Caption = "الاسم";
            this.colnkapaMandopName.FieldName = "nkapaMandopName";
            this.colnkapaMandopName.Name = "colnkapaMandopName";
            this.colnkapaMandopName.Visible = true;
            this.colnkapaMandopName.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "اسم الشهر";
            this.gridColumn2.FieldName = "MonthName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControlData);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(760, 296);
            this.groupControl1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.AllowTouchScroll = true;
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnNew);
            this.groupControl2.Location = new System.Drawing.Point(12, 314);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(760, 62);
            this.groupControl2.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.Image = global::RetirementCenter.Properties.Resources.Add;
            this.btnNew.Location = new System.Drawing.Point(555, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tblProofDocTableAdapter
            // 
            this.tblProofDocTableAdapter.ClearBeforeFill = true;
            // 
            // tblProofDocbindingSource
            // 
            this.tblProofDocbindingSource.DataMember = "TBLProofDoc";
            this.tblProofDocbindingSource.DataSource = this.dsRetirementCenter;
            // 
            // TBLProofDocFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 388);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "TBLProofDocFrm";
            this.Text = "بيان المعاش";
            this.Load += new System.EventHandler(this.FormFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMMashatId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPCSTBLMashat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTBLMashat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditmemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdatein.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdatein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdituserin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblProofDocbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET1;
        private DevExpress.XtraGrid.Columns.GridColumn colEdaraMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditdatein;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdituserin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditmemo;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colmemo;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditMMashatId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.Xpo.XPServerCollectionSource XPCSTBLMashat;
        private DevExpress.Xpo.Session sessionTBLMashat;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMashHala;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colyasref;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.TBLProofDocTableAdapter tblProofDocTableAdapter;
        private System.Windows.Forms.BindingSource tblProofDocbindingSource;
    }
}