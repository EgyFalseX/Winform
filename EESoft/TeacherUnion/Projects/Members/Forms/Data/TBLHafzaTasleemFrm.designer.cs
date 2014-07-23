namespace Members
{
    partial class TBLHafzaTasleemFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLHafzaTasleemFrm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tBLHafzaTasleemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridViewTBLHafzaTasleem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHafzaDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colSyndicateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSyndicateId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISMandoop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditTF = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colHafzaperson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditHafzaperson = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tBLMandoopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHafzapersonText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHafzaRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditRemark = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colhclose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDatein = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tBLHafzaTasleemTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLHafzaTasleemTableAdapter();
            this.cDSyndicateTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter();
            this.tBLMandoopTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMandoopTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHafzaTasleemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLHafzaTasleem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSyndicateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditTF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditHafzaperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMandoopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLHafzaTasleemBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewTBLHafzaTasleem;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDel,
            this.repositoryItemDateEditDatein,
            this.repositoryItemGridLookUpEditHafzaperson,
            this.repositoryItemDateEditDate,
            this.repositoryItemGridLookUpEditSyndicateId,
            this.repositoryItemCheckEditTF,
            this.repositoryItemMemoExEditRemark,
            this.repositoryItemButtonEditPrint});
            this.gridControlData.Size = new System.Drawing.Size(756, 258);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTBLHafzaTasleem});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // tBLHafzaTasleemBindingSource
            // 
            this.tBLHafzaTasleemBindingSource.DataMember = "TBLHafzaTasleem";
            this.tBLHafzaTasleemBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewTBLHafzaTasleem
            // 
            this.gridViewTBLHafzaTasleem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHafzaDate,
            this.colSyndicateId,
            this.colISMandoop,
            this.colHafzaperson,
            this.colHafzapersonText,
            this.colHafzaRemark,
            this.colhclose,
            this.coldatein,
            this.coluserin,
            this.gridColumnEdit,
            this.gridColumnDel,
            this.gridColumn1});
            this.gridViewTBLHafzaTasleem.GridControl = this.gridControlData;
            this.gridViewTBLHafzaTasleem.Name = "gridViewTBLHafzaTasleem";
            this.gridViewTBLHafzaTasleem.OptionsBehavior.ReadOnly = true;
            this.gridViewTBLHafzaTasleem.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewTBLHafzaTasleem.OptionsDetail.SmartDetailHeight = true;
            this.gridViewTBLHafzaTasleem.OptionsView.ColumnAutoWidth = false;
            this.gridViewTBLHafzaTasleem.OptionsView.ShowDetailButtons = false;
            this.gridViewTBLHafzaTasleem.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewTBLHafzaTasleem_InvalidRowException);
            // 
            // colHafzaDate
            // 
            this.colHafzaDate.AppearanceCell.Options.UseTextOptions = true;
            this.colHafzaDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHafzaDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colHafzaDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHafzaDate.Caption = "تاريخ";
            this.colHafzaDate.ColumnEdit = this.repositoryItemDateEditDate;
            this.colHafzaDate.FieldName = "HafzaDate";
            this.colHafzaDate.Name = "colHafzaDate";
            this.colHafzaDate.Visible = true;
            this.colHafzaDate.VisibleIndex = 0;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colSyndicateId
            // 
            this.colSyndicateId.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.Caption = "الفرعية";
            this.colSyndicateId.ColumnEdit = this.repositoryItemGridLookUpEditSyndicateId;
            this.colSyndicateId.FieldName = "SyndicateId";
            this.colSyndicateId.Name = "colSyndicateId";
            this.colSyndicateId.Visible = true;
            this.colSyndicateId.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEditSyndicateId
            // 
            this.repositoryItemGridLookUpEditSyndicateId.AutoHeight = false;
            this.repositoryItemGridLookUpEditSyndicateId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSyndicateId.DataSource = this.cDSyndicateBindingSource;
            this.repositoryItemGridLookUpEditSyndicateId.DisplayMember = "Syndicate";
            this.repositoryItemGridLookUpEditSyndicateId.Name = "repositoryItemGridLookUpEditSyndicateId";
            this.repositoryItemGridLookUpEditSyndicateId.NullText = "";
            this.repositoryItemGridLookUpEditSyndicateId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSyndicateId.ValueMember = "SyndicateId";
            this.repositoryItemGridLookUpEditSyndicateId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "الاسم";
            this.gridColumn6.FieldName = "Syndicate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // colISMandoop
            // 
            this.colISMandoop.AppearanceCell.Options.UseTextOptions = true;
            this.colISMandoop.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colISMandoop.AppearanceHeader.Options.UseTextOptions = true;
            this.colISMandoop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colISMandoop.Caption = "مندوب";
            this.colISMandoop.ColumnEdit = this.repositoryItemCheckEditTF;
            this.colISMandoop.FieldName = "ISMandoop";
            this.colISMandoop.Name = "colISMandoop";
            this.colISMandoop.Visible = true;
            this.colISMandoop.VisibleIndex = 2;
            // 
            // repositoryItemCheckEditTF
            // 
            this.repositoryItemCheckEditTF.AutoHeight = false;
            this.repositoryItemCheckEditTF.Name = "repositoryItemCheckEditTF";
            // 
            // colHafzaperson
            // 
            this.colHafzaperson.AppearanceCell.Options.UseTextOptions = true;
            this.colHafzaperson.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHafzaperson.AppearanceHeader.Options.UseTextOptions = true;
            this.colHafzaperson.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHafzaperson.Caption = "اسم المندوب";
            this.colHafzaperson.ColumnEdit = this.repositoryItemGridLookUpEditHafzaperson;
            this.colHafzaperson.FieldName = "Hafzaperson";
            this.colHafzaperson.Name = "colHafzaperson";
            this.colHafzaperson.Visible = true;
            this.colHafzaperson.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEditHafzaperson
            // 
            this.repositoryItemGridLookUpEditHafzaperson.AutoHeight = false;
            this.repositoryItemGridLookUpEditHafzaperson.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditHafzaperson.DataSource = this.tBLMandoopBindingSource;
            this.repositoryItemGridLookUpEditHafzaperson.DisplayMember = "MandoopName";
            this.repositoryItemGridLookUpEditHafzaperson.Name = "repositoryItemGridLookUpEditHafzaperson";
            this.repositoryItemGridLookUpEditHafzaperson.NullText = "";
            this.repositoryItemGridLookUpEditHafzaperson.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditHafzaperson.ValueMember = "MandoopId";
            this.repositoryItemGridLookUpEditHafzaperson.View = this.gridView2;
            // 
            // tBLMandoopBindingSource
            // 
            this.tBLMandoopBindingSource.DataMember = "TBLMandoop";
            this.tBLMandoopBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "الاسم";
            this.gridColumn13.FieldName = "MandoopName";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // colHafzapersonText
            // 
            this.colHafzapersonText.AppearanceCell.Options.UseTextOptions = true;
            this.colHafzapersonText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHafzapersonText.AppearanceHeader.Options.UseTextOptions = true;
            this.colHafzapersonText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHafzapersonText.Caption = "اسم الشخص";
            this.colHafzapersonText.FieldName = "HafzapersonText";
            this.colHafzapersonText.Name = "colHafzapersonText";
            this.colHafzapersonText.Visible = true;
            this.colHafzapersonText.VisibleIndex = 4;
            // 
            // colHafzaRemark
            // 
            this.colHafzaRemark.AppearanceCell.Options.UseTextOptions = true;
            this.colHafzaRemark.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHafzaRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colHafzaRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHafzaRemark.Caption = "ملاحظة";
            this.colHafzaRemark.ColumnEdit = this.repositoryItemMemoExEditRemark;
            this.colHafzaRemark.FieldName = "HafzaRemark";
            this.colHafzaRemark.Name = "colHafzaRemark";
            this.colHafzaRemark.Visible = true;
            this.colHafzaRemark.VisibleIndex = 5;
            // 
            // repositoryItemMemoExEditRemark
            // 
            this.repositoryItemMemoExEditRemark.AutoHeight = false;
            this.repositoryItemMemoExEditRemark.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditRemark.Name = "repositoryItemMemoExEditRemark";
            // 
            // colhclose
            // 
            this.colhclose.AppearanceCell.Options.UseTextOptions = true;
            this.colhclose.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhclose.AppearanceHeader.Options.UseTextOptions = true;
            this.colhclose.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhclose.Caption = "اغلاق";
            this.colhclose.ColumnEdit = this.repositoryItemCheckEditTF;
            this.colhclose.FieldName = "hclose";
            this.colhclose.Name = "colhclose";
            this.colhclose.Visible = true;
            this.colhclose.VisibleIndex = 6;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.ColumnEdit = this.repositoryItemDateEditDatein;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            // 
            // repositoryItemDateEditDatein
            // 
            this.repositoryItemDateEditDatein.AutoHeight = false;
            this.repositoryItemDateEditDatein.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDatein.DisplayFormat.FormatString = "u";
            this.repositoryItemDateEditDatein.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDatein.EditFormat.FormatString = "u";
            this.repositoryItemDateEditDatein.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDatein.Mask.EditMask = "u";
            this.repositoryItemDateEditDatein.Name = "repositoryItemDateEditDatein";
            this.repositoryItemDateEditDatein.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // coluserin
            // 
            this.coluserin.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.FieldName = "userin";
            this.coluserin.Name = "coluserin";
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEdit.Caption = "تعديل";
            this.gridColumnEdit.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 7;
            this.gridColumnEdit.Width = 84;
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
            // gridColumnDel
            // 
            this.gridColumnDel.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDel.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDel.Caption = "حذف";
            this.gridColumnDel.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumnDel.Name = "gridColumnDel";
            this.gridColumnDel.Visible = true;
            this.gridColumnDel.VisibleIndex = 9;
            this.gridColumnDel.Width = 56;
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
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "طباعة";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditPrint;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 53;
            // 
            // repositoryItemButtonEditPrint
            // 
            this.repositoryItemButtonEditPrint.AutoHeight = false;
            serializableAppearanceObject1.Image = global::Members.Properties.Resources.Print;
            serializableAppearanceObject1.Options.UseImage = true;
            this.repositoryItemButtonEditPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEditPrint.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditPrint.Name = "repositoryItemButtonEditPrint";
            this.repositoryItemButtonEditPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditPrint_ButtonClick_1);
            // 
            // tBLHafzaTasleemTableAdapter
            // 
            this.tBLHafzaTasleemTableAdapter.ClearBeforeFill = true;
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMandoopTableAdapter
            // 
            this.tBLMandoopTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.AllowTouchScroll = true;
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnNew);
            this.groupControl2.Location = new System.Drawing.Point(12, 299);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(760, 62);
            this.groupControl2.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.Image = global::Members.Properties.Resources.Add;
            this.btnNew.Location = new System.Drawing.Point(555, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AllowTouchScroll = true;
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControlData);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(760, 281);
            this.groupControl1.TabIndex = 0;
            // 
            // TBLHafzaTasleemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "TBLHafzaTasleemFrm";
            this.Text = "حافظة التسليم";
            this.Load += new System.EventHandler(this.stu_nashatFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHafzaTasleemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLHafzaTasleem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSyndicateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditTF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditHafzaperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMandoopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTBLHafzaTasleem;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDatein;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditHafzaperson;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLHafzaTasleemBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLHafzaTasleemTableAdapter tBLHafzaTasleemTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colHafzaDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHafzaperson;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateId;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraGrid.Columns.GridColumn colISMandoop;
        private DevExpress.XtraGrid.Columns.GridColumn colHafzapersonText;
        private DevExpress.XtraGrid.Columns.GridColumn colHafzaRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colhclose;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditTF;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditRemark;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private System.Windows.Forms.BindingSource tBLMandoopBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLMandoopTableAdapter tBLMandoopTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDel;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditPrint;
    }
}