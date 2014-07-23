namespace RetirementCenter.Forms.Data
{
    partial class TBLWarasaNIDFastEditFrm
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
            this.tBLWarasaFastEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSyndicateId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSCDSyndicate = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSubCommitteIdW = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSCDSubCommitte = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubCommitte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarasaTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditWarasaTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSCDWarasaType = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWarasaType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatNId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditpersonNID = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditTransferSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdituserin = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSUsers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colSyndicateIdW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitteIdW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tBLWarasaFastEditTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLWarasaFastEditTableAdapter();
            this.tblWarasaTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLWarasaTableAdapter();
            this.repositoryItemGridLookUpEditSubCommitteId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWarasaFastEditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSyndicateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubCommitteIdW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditWarasaTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDWarasaType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditpersonNID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubCommitteId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLWarasaFastEditBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditTransferSave,
            this.repositoryItemGridLookUpEditSyndicateId,
            this.repositoryItemGridLookUpEditSubCommitteIdW,
            this.repositoryItemGridLookUpEditWarasaTypeId,
            this.repositoryItemTextEditpersonNID,
            this.repositoryItemLookUpEdituserin,
            this.repositoryItemGridLookUpEditSubCommitteId});
            this.gridControlData.Size = new System.Drawing.Size(734, 361);
            this.gridControlData.TabIndex = 2;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tBLWarasaFastEditBindingSource
            // 
            this.tBLWarasaFastEditBindingSource.DataMember = "TBLWarasaFastEdit";
            this.tBLWarasaFastEditBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatName,
            this.colSyndicateId,
            this.colSubCommitteId,
            this.colsarfnumber,
            this.colpersonName,
            this.colWarasaTypeId,
            this.colMMashatNId,
            this.gridColumn4,
            this.coluserin,
            this.colSyndicateIdW,
            this.colSubCommitteIdW});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "اسم العضو";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.OptionsColumn.ReadOnly = true;
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 0;
            this.colMMashatName.Width = 92;
            // 
            // colSyndicateId
            // 
            this.colSyndicateId.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.Caption = "فرعية العضو";
            this.colSyndicateId.ColumnEdit = this.repositoryItemGridLookUpEditSyndicateId;
            this.colSyndicateId.FieldName = "SyndicateId";
            this.colSyndicateId.Name = "colSyndicateId";
            this.colSyndicateId.OptionsColumn.ReadOnly = true;
            this.colSyndicateId.Visible = true;
            this.colSyndicateId.VisibleIndex = 1;
            this.colSyndicateId.Width = 103;
            // 
            // repositoryItemGridLookUpEditSyndicateId
            // 
            this.repositoryItemGridLookUpEditSyndicateId.AutoHeight = false;
            this.repositoryItemGridLookUpEditSyndicateId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSyndicateId.DataSource = this.LSMSCDSyndicate;
            this.repositoryItemGridLookUpEditSyndicateId.DisplayMember = "Syndicate";
            this.repositoryItemGridLookUpEditSyndicateId.Name = "repositoryItemGridLookUpEditSyndicateId";
            this.repositoryItemGridLookUpEditSyndicateId.NullText = "";
            this.repositoryItemGridLookUpEditSyndicateId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSyndicateId.ValueMember = "SyndicateId";
            this.repositoryItemGridLookUpEditSyndicateId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // LSMSCDSyndicate
            // 
            this.LSMSCDSyndicate.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSCDSyndicate.KeyExpression = "[SyndicateId]";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSyndicate1
            // 
            this.colSyndicate1.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.Caption = "الفرعية";
            this.colSyndicate1.FieldName = "Syndicate";
            this.colSyndicate1.Name = "colSyndicate1";
            this.colSyndicate1.Visible = true;
            this.colSyndicate1.VisibleIndex = 0;
            // 
            // colSubCommitteId
            // 
            this.colSubCommitteId.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.Caption = "لجنة العضو";
            this.colSubCommitteId.ColumnEdit = this.repositoryItemGridLookUpEditSubCommitteId;
            this.colSubCommitteId.FieldName = "SubCommitteId";
            this.colSubCommitteId.Name = "colSubCommitteId";
            this.colSubCommitteId.OptionsColumn.ReadOnly = true;
            this.colSubCommitteId.Visible = true;
            this.colSubCommitteId.VisibleIndex = 2;
            this.colSubCommitteId.Width = 104;
            // 
            // repositoryItemGridLookUpEditSubCommitteIdW
            // 
            this.repositoryItemGridLookUpEditSubCommitteIdW.AutoHeight = false;
            this.repositoryItemGridLookUpEditSubCommitteIdW.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSubCommitteIdW.DataSource = this.LSMSCDSubCommitte;
            this.repositoryItemGridLookUpEditSubCommitteIdW.DisplayMember = "SubCommitte";
            this.repositoryItemGridLookUpEditSubCommitteIdW.Name = "repositoryItemGridLookUpEditSubCommitteIdW";
            this.repositoryItemGridLookUpEditSubCommitteIdW.NullText = "";
            this.repositoryItemGridLookUpEditSubCommitteIdW.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSubCommitteIdW.ValueMember = "SubCommitteId";
            this.repositoryItemGridLookUpEditSubCommitteIdW.View = this.gridView1;
            this.repositoryItemGridLookUpEditSubCommitteIdW.Enter += new System.EventHandler(this.repositoryItemGridLookUpEditSubCommitteIdW_Enter);
            // 
            // LSMSCDSubCommitte
            // 
            this.LSMSCDSubCommitte.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSubCommitte);
            this.LSMSCDSubCommitte.KeyExpression = "[SubCommitteId]";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubCommitte1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSubCommitte1
            // 
            this.colSubCommitte1.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte1.Caption = "الجنة";
            this.colSubCommitte1.FieldName = "SubCommitte";
            this.colSubCommitte1.Name = "colSubCommitte1";
            this.colSubCommitte1.Visible = true;
            this.colSubCommitte1.VisibleIndex = 0;
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
            this.colsarfnumber.OptionsColumn.ReadOnly = true;
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 3;
            // 
            // colpersonName
            // 
            this.colpersonName.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.Caption = "اسم الوريث";
            this.colpersonName.FieldName = "personName";
            this.colpersonName.Name = "colpersonName";
            this.colpersonName.OptionsColumn.ReadOnly = true;
            this.colpersonName.Visible = true;
            this.colpersonName.VisibleIndex = 4;
            // 
            // colWarasaTypeId
            // 
            this.colWarasaTypeId.AppearanceCell.Options.UseTextOptions = true;
            this.colWarasaTypeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarasaTypeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarasaTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarasaTypeId.Caption = "نوع الوريث";
            this.colWarasaTypeId.ColumnEdit = this.repositoryItemGridLookUpEditWarasaTypeId;
            this.colWarasaTypeId.FieldName = "WarasaTypeId";
            this.colWarasaTypeId.Name = "colWarasaTypeId";
            this.colWarasaTypeId.Visible = true;
            this.colWarasaTypeId.VisibleIndex = 7;
            // 
            // repositoryItemGridLookUpEditWarasaTypeId
            // 
            this.repositoryItemGridLookUpEditWarasaTypeId.AutoHeight = false;
            this.repositoryItemGridLookUpEditWarasaTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditWarasaTypeId.DataSource = this.LSMSCDWarasaType;
            this.repositoryItemGridLookUpEditWarasaTypeId.DisplayMember = "WarasaType";
            this.repositoryItemGridLookUpEditWarasaTypeId.Name = "repositoryItemGridLookUpEditWarasaTypeId";
            this.repositoryItemGridLookUpEditWarasaTypeId.NullText = "";
            this.repositoryItemGridLookUpEditWarasaTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditWarasaTypeId.ValueMember = "WarasaTypeId";
            this.repositoryItemGridLookUpEditWarasaTypeId.View = this.gridView2;
            // 
            // LSMSCDWarasaType
            // 
            this.LSMSCDWarasaType.ElementType = typeof(RetirementCenter.DataSources.Linq.CDWarasaType);
            this.LSMSCDWarasaType.KeyExpression = "[WarasaTypeId]";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWarasaType});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colWarasaType
            // 
            this.colWarasaType.AppearanceCell.Options.UseTextOptions = true;
            this.colWarasaType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarasaType.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarasaType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarasaType.Caption = "النوع";
            this.colWarasaType.FieldName = "WarasaType";
            this.colWarasaType.Name = "colWarasaType";
            this.colWarasaType.Visible = true;
            this.colWarasaType.VisibleIndex = 0;
            // 
            // colMMashatNId
            // 
            this.colMMashatNId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.Caption = "الرقم القومي";
            this.colMMashatNId.ColumnEdit = this.repositoryItemTextEditpersonNID;
            this.colMMashatNId.FieldName = "personNID";
            this.colMMashatNId.Name = "colMMashatNId";
            this.colMMashatNId.Visible = true;
            this.colMMashatNId.VisibleIndex = 8;
            this.colMMashatNId.Width = 112;
            // 
            // repositoryItemTextEditpersonNID
            // 
            this.repositoryItemTextEditpersonNID.AutoHeight = false;
            this.repositoryItemTextEditpersonNID.MaxLength = 14;
            this.repositoryItemTextEditpersonNID.Name = "repositoryItemTextEditpersonNID";
            this.repositoryItemTextEditpersonNID.Validating += new System.ComponentModel.CancelEventHandler(this.repositoryItemTextEditpersonNID_Validating);
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "حفظ";
            this.gridColumn4.ColumnEdit = this.repositoryItemButtonEditTransferSave;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 9;
            this.gridColumn4.Width = 70;
            // 
            // repositoryItemButtonEditTransferSave
            // 
            this.repositoryItemButtonEditTransferSave.AutoHeight = false;
            this.repositoryItemButtonEditTransferSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditTransferSave.Name = "repositoryItemButtonEditTransferSave";
            this.repositoryItemButtonEditTransferSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditTransferSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditTransferSave_ButtonClick);
            // 
            // coluserin
            // 
            this.coluserin.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.Caption = "مسئول الادخال";
            this.coluserin.ColumnEdit = this.repositoryItemLookUpEdituserin;
            this.coluserin.FieldName = "userin";
            this.coluserin.Name = "coluserin";
            this.coluserin.OptionsColumn.AllowEdit = false;
            this.coluserin.Visible = true;
            this.coluserin.VisibleIndex = 10;
            this.coluserin.Width = 88;
            // 
            // repositoryItemLookUpEdituserin
            // 
            this.repositoryItemLookUpEdituserin.AutoHeight = false;
            this.repositoryItemLookUpEdituserin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdituserin.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEdituserin.DataSource = this.LSMSUsers;
            this.repositoryItemLookUpEdituserin.DisplayMember = "RealName";
            this.repositoryItemLookUpEdituserin.Name = "repositoryItemLookUpEdituserin";
            this.repositoryItemLookUpEdituserin.NullText = "";
            this.repositoryItemLookUpEdituserin.ValueMember = "UserID";
            // 
            // LSMSUsers
            // 
            this.LSMSUsers.ElementType = typeof(RetirementCenter.DataSources.Linq.User);
            this.LSMSUsers.KeyExpression = "[UserID]";
            // 
            // colSyndicateIdW
            // 
            this.colSyndicateIdW.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateIdW.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateIdW.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateIdW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateIdW.Caption = "فرعية الوريث";
            this.colSyndicateIdW.ColumnEdit = this.repositoryItemGridLookUpEditSyndicateId;
            this.colSyndicateIdW.FieldName = "SyndicateIdW";
            this.colSyndicateIdW.Name = "colSyndicateIdW";
            this.colSyndicateIdW.OptionsColumn.ReadOnly = true;
            this.colSyndicateIdW.Visible = true;
            this.colSyndicateIdW.VisibleIndex = 5;
            // 
            // colSubCommitteIdW
            // 
            this.colSubCommitteIdW.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteIdW.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteIdW.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteIdW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteIdW.Caption = "لجنة الوريث";
            this.colSubCommitteIdW.ColumnEdit = this.repositoryItemGridLookUpEditSubCommitteIdW;
            this.colSubCommitteIdW.FieldName = "SubCommitteIdW";
            this.colSubCommitteIdW.Name = "colSubCommitteIdW";
            this.colSubCommitteIdW.Visible = true;
            this.colSubCommitteIdW.VisibleIndex = 6;
            // 
            // tBLWarasaFastEditTableAdapter
            // 
            this.tBLWarasaFastEditTableAdapter.ClearBeforeFill = true;
            // 
            // tblWarasaTableAdapter
            // 
            this.tblWarasaTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemGridLookUpEditSubCommitteId
            // 
            this.repositoryItemGridLookUpEditSubCommitteId.AutoHeight = false;
            this.repositoryItemGridLookUpEditSubCommitteId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSubCommitteId.DataSource = this.LSMSCDSubCommitte;
            this.repositoryItemGridLookUpEditSubCommitteId.DisplayMember = "SubCommitte";
            this.repositoryItemGridLookUpEditSubCommitteId.Name = "repositoryItemGridLookUpEditSubCommitteId";
            this.repositoryItemGridLookUpEditSubCommitteId.NullText = "";
            this.repositoryItemGridLookUpEditSubCommitteId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSubCommitteId.ValueMember = "SubCommitteId";
            this.repositoryItemGridLookUpEditSubCommitteId.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubCommitte});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
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
            this.colSubCommitte.VisibleIndex = 0;
            // 
            // TBLWarasaNIDFastEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.gridControlData);
            this.Name = "TBLWarasaNIDFastEditFrm";
            this.Text = "تعديل الرقم القومي و الصرف للاعضاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TBLWarasaNIDFastEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWarasaFastEditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSyndicateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubCommitteIdW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditWarasaTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDWarasaType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditpersonNID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSubCommitteId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSubCommitteIdW;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditTransferSave;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteId;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatNId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSyndicate;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSubCommitte;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource tBLWarasaFastEditBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.TBLWarasaFastEditTableAdapter tBLWarasaFastEditTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colWarasaTypeId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDWarasaType;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditWarasaTypeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colWarasaType;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditpersonNID;
        private DataSources.dsRetirementCenterTableAdapters.TBLWarasaTableAdapter tblWarasaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdituserin;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateIdW;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteIdW;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSubCommitteId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
    }
}