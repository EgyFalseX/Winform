namespace Retirement
{
    partial class TBLDofatdeatilesFrm
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
            this.tBLDofatdeatilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Retirement.DataSources.dsTeachersUnion();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditMMashatId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tBLMashatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditn0 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colmonthlyretrment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditf2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.coltotalmonthlyretrment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleshtrakat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrasm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestbad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaksat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAddAll = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tBLDofatdeatilesTableAdapter = new Retirement.DataSources.dsTeachersUnionTableAdapters.TBLDofatdeatilesTableAdapter();
            this.tBLMashatTableAdapter = new Retirement.DataSources.dsTeachersUnionTableAdapters.TBLMashatTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbmonthlyretrment = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbtotalmonthlyretrment = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbeshtrakat = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tbrasm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbestbad = new DevExpress.XtraEditors.TextEdit();
            this.tbaksat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDofatdeatilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMMashatId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMashatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditn0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmonthlyretrment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtotalmonthlyretrment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbeshtrakat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrasm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbestbad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaksat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLDofatdeatilesBindingSource;
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
            this.repositoryItemGridLookUpEditMMashatId,
            this.repositoryItemCalcEditf2,
            this.repositoryItemCalcEditn0});
            this.gridControlData.Size = new System.Drawing.Size(756, 306);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // tBLDofatdeatilesBindingSource
            // 
            this.tBLDofatdeatilesBindingSource.DataMember = "TBLDofatdeatiles";
            this.tBLDofatdeatilesBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatId,
            this.colsarfnumber,
            this.colmonthlyretrment,
            this.coltotalmonthlyretrment,
            this.coleshtrakat,
            this.colrasm,
            this.colestbad,
            this.colaksat,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridViewData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewData_InitNewRow);
            // 
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "صاحب المعاش";
            this.colMMashatId.ColumnEdit = this.repositoryItemGridLookUpEditMMashatId;
            this.colMMashatId.FieldName = "MMashatId";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEditMMashatId
            // 
            this.repositoryItemGridLookUpEditMMashatId.AutoHeight = false;
            this.repositoryItemGridLookUpEditMMashatId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditMMashatId.DataSource = this.tBLMashatBindingSource;
            this.repositoryItemGridLookUpEditMMashatId.DisplayMember = "MMashatName";
            this.repositoryItemGridLookUpEditMMashatId.Name = "repositoryItemGridLookUpEditMMashatId";
            this.repositoryItemGridLookUpEditMMashatId.NullText = "";
            this.repositoryItemGridLookUpEditMMashatId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditMMashatId.ValueMember = "MMashatId";
            this.repositoryItemGridLookUpEditMMashatId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tBLMashatBindingSource
            // 
            this.tBLMashatBindingSource.DataMember = "TBLMashat";
            this.tBLMashatBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم الصرف";
            this.colsarfnumber.ColumnEdit = this.repositoryItemCalcEditn0;
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 1;
            // 
            // repositoryItemCalcEditn0
            // 
            this.repositoryItemCalcEditn0.AutoHeight = false;
            this.repositoryItemCalcEditn0.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditn0.DisplayFormat.FormatString = "n0";
            this.repositoryItemCalcEditn0.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditn0.EditFormat.FormatString = "n0";
            this.repositoryItemCalcEditn0.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditn0.Mask.EditMask = "n0";
            this.repositoryItemCalcEditn0.Name = "repositoryItemCalcEditn0";
            // 
            // colmonthlyretrment
            // 
            this.colmonthlyretrment.AppearanceCell.Options.UseTextOptions = true;
            this.colmonthlyretrment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmonthlyretrment.AppearanceHeader.Options.UseTextOptions = true;
            this.colmonthlyretrment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmonthlyretrment.Caption = "المعاش الشهرى";
            this.colmonthlyretrment.ColumnEdit = this.repositoryItemCalcEditf2;
            this.colmonthlyretrment.FieldName = "monthlyretrment";
            this.colmonthlyretrment.Name = "colmonthlyretrment";
            this.colmonthlyretrment.Visible = true;
            this.colmonthlyretrment.VisibleIndex = 2;
            this.colmonthlyretrment.Width = 92;
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
            // coltotalmonthlyretrment
            // 
            this.coltotalmonthlyretrment.AppearanceCell.Options.UseTextOptions = true;
            this.coltotalmonthlyretrment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalmonthlyretrment.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotalmonthlyretrment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalmonthlyretrment.Caption = "جملة المبلغ";
            this.coltotalmonthlyretrment.ColumnEdit = this.repositoryItemCalcEditf2;
            this.coltotalmonthlyretrment.FieldName = "totalmonthlyretrment";
            this.coltotalmonthlyretrment.Name = "coltotalmonthlyretrment";
            this.coltotalmonthlyretrment.Visible = true;
            this.coltotalmonthlyretrment.VisibleIndex = 3;
            // 
            // coleshtrakat
            // 
            this.coleshtrakat.AppearanceCell.Options.UseTextOptions = true;
            this.coleshtrakat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coleshtrakat.AppearanceHeader.Options.UseTextOptions = true;
            this.coleshtrakat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coleshtrakat.Caption = "اشتراكات";
            this.coleshtrakat.ColumnEdit = this.repositoryItemCalcEditf2;
            this.coleshtrakat.FieldName = "eshtrakat";
            this.coleshtrakat.Name = "coleshtrakat";
            this.coleshtrakat.Visible = true;
            this.coleshtrakat.VisibleIndex = 4;
            // 
            // colrasm
            // 
            this.colrasm.AppearanceCell.Options.UseTextOptions = true;
            this.colrasm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrasm.AppearanceHeader.Options.UseTextOptions = true;
            this.colrasm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrasm.Caption = "رسم";
            this.colrasm.ColumnEdit = this.repositoryItemCalcEditf2;
            this.colrasm.FieldName = "rasm";
            this.colrasm.Name = "colrasm";
            this.colrasm.Visible = true;
            this.colrasm.VisibleIndex = 5;
            // 
            // colestbad
            // 
            this.colestbad.AppearanceCell.Options.UseTextOptions = true;
            this.colestbad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestbad.AppearanceHeader.Options.UseTextOptions = true;
            this.colestbad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestbad.Caption = "استبعاد";
            this.colestbad.ColumnEdit = this.repositoryItemCalcEditf2;
            this.colestbad.FieldName = "estbad";
            this.colestbad.Name = "colestbad";
            this.colestbad.Visible = true;
            this.colestbad.VisibleIndex = 6;
            // 
            // colaksat
            // 
            this.colaksat.AppearanceCell.Options.UseTextOptions = true;
            this.colaksat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaksat.AppearanceHeader.Options.UseTextOptions = true;
            this.colaksat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaksat.Caption = "اقساط";
            this.colaksat.ColumnEdit = this.repositoryItemCalcEditf2;
            this.colaksat.FieldName = "aksat";
            this.colaksat.Name = "colaksat";
            this.colaksat.Visible = true;
            this.colaksat.VisibleIndex = 7;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "حفظ";
            this.gridColumn3.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 71;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSave_ButtonClick);
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "حذف";
            this.gridColumn4.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 9;
            this.gridColumn4.Width = 70;
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
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.tbtotalmonthlyretrment);
            this.groupControl1.Controls.Add(this.tbmonthlyretrment);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnAddAll);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(760, 102);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "خيارات";
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(110, 38);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(150, 50);
            this.btnAddAll.TabIndex = 3;
            this.btnAddAll.Text = "اعداد الدفعة";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl2.Controls.Add(this.gridControlData);
            this.groupControl2.Location = new System.Drawing.Point(12, 120);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(760, 329);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "التفاصيل";
            // 
            // tBLDofatdeatilesTableAdapter
            // 
            this.tBLDofatdeatilesTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMashatTableAdapter
            // 
            this.tBLMashatTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(574, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "المعاش الشهري";
            // 
            // tbmonthlyretrment
            // 
            this.tbmonthlyretrment.EditValue = "0";
            this.tbmonthlyretrment.Location = new System.Drawing.Point(518, 40);
            this.tbmonthlyretrment.Name = "tbmonthlyretrment";
            this.tbmonthlyretrment.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbmonthlyretrment.Properties.DisplayFormat.FormatString = "f2";
            this.tbmonthlyretrment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbmonthlyretrment.Properties.EditFormat.FormatString = "f2";
            this.tbmonthlyretrment.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbmonthlyretrment.Properties.Mask.EditMask = "f2";
            this.tbmonthlyretrment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbmonthlyretrment.Size = new System.Drawing.Size(50, 20);
            this.tbmonthlyretrment.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(597, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "جملة المبلغ";
            // 
            // tbtotalmonthlyretrment
            // 
            this.tbtotalmonthlyretrment.EditValue = "0";
            this.tbtotalmonthlyretrment.Location = new System.Drawing.Point(518, 68);
            this.tbtotalmonthlyretrment.Name = "tbtotalmonthlyretrment";
            this.tbtotalmonthlyretrment.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbtotalmonthlyretrment.Properties.DisplayFormat.FormatString = "f2";
            this.tbtotalmonthlyretrment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbtotalmonthlyretrment.Properties.EditFormat.FormatString = "f2";
            this.tbtotalmonthlyretrment.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbtotalmonthlyretrment.Properties.Mask.EditMask = "f2";
            this.tbtotalmonthlyretrment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbtotalmonthlyretrment.Size = new System.Drawing.Size(50, 20);
            this.tbtotalmonthlyretrment.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(179, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "اشتراكات";
            // 
            // tbeshtrakat
            // 
            this.tbeshtrakat.EditValue = "0";
            this.tbeshtrakat.Location = new System.Drawing.Point(113, 27);
            this.tbeshtrakat.Name = "tbeshtrakat";
            this.tbeshtrakat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbeshtrakat.Properties.DisplayFormat.FormatString = "f2";
            this.tbeshtrakat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbeshtrakat.Properties.EditFormat.FormatString = "f2";
            this.tbeshtrakat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbeshtrakat.Properties.Mask.EditMask = "f2";
            this.tbeshtrakat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbeshtrakat.Size = new System.Drawing.Size(50, 20);
            this.tbeshtrakat.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.tbaksat);
            this.groupControl3.Controls.Add(this.tbrasm);
            this.groupControl3.Controls.Add(this.tbestbad);
            this.groupControl3.Controls.Add(this.tbeshtrakat);
            this.groupControl3.Location = new System.Drawing.Point(266, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(230, 74);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "الاستقطاعات";
            // 
            // tbrasm
            // 
            this.tbrasm.EditValue = "0";
            this.tbrasm.Location = new System.Drawing.Point(18, 27);
            this.tbrasm.Name = "tbrasm";
            this.tbrasm.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbrasm.Properties.DisplayFormat.FormatString = "f2";
            this.tbrasm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbrasm.Properties.EditFormat.FormatString = "f2";
            this.tbrasm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbrasm.Properties.Mask.EditMask = "f2";
            this.tbrasm.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbrasm.Size = new System.Drawing.Size(50, 20);
            this.tbrasm.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(79, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "رسم";
            // 
            // tbestbad
            // 
            this.tbestbad.EditValue = "0";
            this.tbestbad.Location = new System.Drawing.Point(113, 49);
            this.tbestbad.Name = "tbestbad";
            this.tbestbad.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbestbad.Properties.DisplayFormat.FormatString = "f2";
            this.tbestbad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbestbad.Properties.EditFormat.FormatString = "f2";
            this.tbestbad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbestbad.Properties.Mask.EditMask = "f2";
            this.tbestbad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbestbad.Size = new System.Drawing.Size(50, 20);
            this.tbestbad.TabIndex = 2;
            // 
            // tbaksat
            // 
            this.tbaksat.EditValue = "0";
            this.tbaksat.Location = new System.Drawing.Point(18, 49);
            this.tbaksat.Name = "tbaksat";
            this.tbaksat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbaksat.Properties.DisplayFormat.FormatString = "f2";
            this.tbaksat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbaksat.Properties.EditFormat.FormatString = "f2";
            this.tbaksat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbaksat.Properties.Mask.EditMask = "f2";
            this.tbaksat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbaksat.Size = new System.Drawing.Size(50, 20);
            this.tbaksat.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(166, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "م بالاستبعاد";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(72, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "إقساط";
            // 
            // TBLDofatdeatilesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "TBLDofatdeatilesFrm";
            this.Text = "التفاصيل";
            this.Load += new System.EventHandler(this.TBLDofatdeatilesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDofatdeatilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMMashatId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMashatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditn0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbmonthlyretrment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtotalmonthlyretrment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbeshtrakat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrasm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbestbad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaksat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddAll;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLDofatdeatilesBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLDofatdeatilesTableAdapter tBLDofatdeatilesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colaksat;
        private DevExpress.XtraGrid.Columns.GridColumn coleshtrakat;
        private DevExpress.XtraGrid.Columns.GridColumn colestbad;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colmonthlyretrment;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colrasm;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalmonthlyretrment;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditMMashatId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tBLMashatBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLMashatTableAdapter tBLMashatTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditn0;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditf2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbaksat;
        private DevExpress.XtraEditors.TextEdit tbrasm;
        private DevExpress.XtraEditors.TextEdit tbestbad;
        private DevExpress.XtraEditors.TextEdit tbeshtrakat;
        private DevExpress.XtraEditors.TextEdit tbtotalmonthlyretrment;
        private DevExpress.XtraEditors.TextEdit tbmonthlyretrment;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}