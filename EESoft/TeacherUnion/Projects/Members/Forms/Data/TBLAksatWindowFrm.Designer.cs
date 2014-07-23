namespace Members.Forms.Data
{
    partial class TBLAksatWindowFrm
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tBLAksatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditMemberId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tBLMembersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkestenddate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colmostahk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditf2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colmadfoaa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesaldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tBLAksatTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLAksatTableAdapter();
            this.tBLMembersListTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMembersListTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLAksatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMembersListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.gridControlData);
            this.groupControl3.Location = new System.Drawing.Point(0, -2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(692, 307);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "الاقساط";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLAksatBindingSource;
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
            this.repositoryItemButtonEditDetails,
            this.repositoryItemGridLookUpEditMemberId,
            this.repositoryItemDateEditDMY,
            this.repositoryItemCalcEditf2,
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDelete});
            this.gridControlData.Size = new System.Drawing.Size(688, 284);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tBLAksatBindingSource
            // 
            this.tBLAksatBindingSource.DataMember = "TBLAksat";
            this.tBLAksatBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberId,
            this.colSyndicate1,
            this.colKideNumber,
            this.colkestenddate,
            this.colmostahk,
            this.colmadfoaa,
            this.colesalno,
            this.colesaldate,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضعظ لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            // 
            // colMemberId
            // 
            this.colMemberId.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberId.Caption = "العضو";
            this.colMemberId.ColumnEdit = this.repositoryItemGridLookUpEditMemberId;
            this.colMemberId.FieldName = "MemberId";
            this.colMemberId.Name = "colMemberId";
            this.colMemberId.Visible = true;
            this.colMemberId.VisibleIndex = 0;
            this.colMemberId.Width = 83;
            // 
            // repositoryItemGridLookUpEditMemberId
            // 
            this.repositoryItemGridLookUpEditMemberId.AutoHeight = false;
            this.repositoryItemGridLookUpEditMemberId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditMemberId.DataSource = this.tBLMembersListBindingSource;
            this.repositoryItemGridLookUpEditMemberId.DisplayMember = "MemberName";
            this.repositoryItemGridLookUpEditMemberId.Name = "repositoryItemGridLookUpEditMemberId";
            this.repositoryItemGridLookUpEditMemberId.NullText = "";
            this.repositoryItemGridLookUpEditMemberId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditMemberId.ValueMember = "MemberId";
            this.repositoryItemGridLookUpEditMemberId.View = this.gridView2;
            this.repositoryItemGridLookUpEditMemberId.EditValueChanged += new System.EventHandler(this.repositoryItemGridLookUpEditMemberId_EditValueChanged);
            // 
            // tBLMembersListBindingSource
            // 
            this.tBLMembersListBindingSource.DataMember = "TBLMembersList";
            this.tBLMembersListBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberName,
            this.colKideNumber1,
            this.colSyndicate});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            this.colSyndicate.VisibleIndex = 2;
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
            this.colSyndicate1.OptionsColumn.AllowEdit = false;
            this.colSyndicate1.Visible = true;
            this.colSyndicate1.VisibleIndex = 1;
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
            this.colKideNumber.OptionsColumn.AllowEdit = false;
            this.colKideNumber.Visible = true;
            this.colKideNumber.VisibleIndex = 2;
            // 
            // colkestenddate
            // 
            this.colkestenddate.AppearanceCell.Options.UseTextOptions = true;
            this.colkestenddate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkestenddate.AppearanceHeader.Options.UseTextOptions = true;
            this.colkestenddate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkestenddate.Caption = "نهاية القسط";
            this.colkestenddate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colkestenddate.FieldName = "kestenddate";
            this.colkestenddate.Name = "colkestenddate";
            this.colkestenddate.Visible = true;
            this.colkestenddate.VisibleIndex = 3;
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
            // colmostahk
            // 
            this.colmostahk.AppearanceCell.Options.UseTextOptions = true;
            this.colmostahk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostahk.AppearanceHeader.Options.UseTextOptions = true;
            this.colmostahk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostahk.Caption = "المستحق";
            this.colmostahk.ColumnEdit = this.repositoryItemCalcEditf2;
            this.colmostahk.FieldName = "mostahk";
            this.colmostahk.Name = "colmostahk";
            this.colmostahk.Visible = true;
            this.colmostahk.VisibleIndex = 4;
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
            // colmadfoaa
            // 
            this.colmadfoaa.AppearanceCell.Options.UseTextOptions = true;
            this.colmadfoaa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmadfoaa.AppearanceHeader.Options.UseTextOptions = true;
            this.colmadfoaa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmadfoaa.Caption = "المدفوع";
            this.colmadfoaa.ColumnEdit = this.repositoryItemCalcEditf2;
            this.colmadfoaa.FieldName = "madfoaa";
            this.colmadfoaa.Name = "colmadfoaa";
            this.colmadfoaa.Visible = true;
            this.colmadfoaa.VisibleIndex = 5;
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
            this.colesalno.VisibleIndex = 6;
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
            this.colesaldate.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "تعديل";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 48;
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
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "التفاصيل";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEditDetails;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 60;
            // 
            // repositoryItemButtonEditDetails
            // 
            this.repositoryItemButtonEditDetails.AutoHeight = false;
            this.repositoryItemButtonEditDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditDetails.Name = "repositoryItemButtonEditDetails";
            this.repositoryItemButtonEditDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDetails.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDetails_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "الحذف";
            this.gridColumn3.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 10;
            this.gridColumn3.Width = 44;
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
            // tBLAksatTableAdapter
            // 
            this.tBLAksatTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMembersListTableAdapter
            // 
            this.tBLMembersListTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.AllowTouchScroll = true;
            this.groupControl2.Controls.Add(this.btnNew);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 311);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(692, 62);
            this.groupControl2.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.Image = global::Members.Properties.Resources.Add;
            this.btnNew.Location = new System.Drawing.Point(487, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // TBLAksatWindowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Name = "TBLAksatWindowFrm";
            this.Text = "الاقساط";
            this.Load += new System.EventHandler(this.TBLHafzawebFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLAksatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditMemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMembersListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDetails;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLAksatBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLAksatTableAdapter tBLAksatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditMemberId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DevExpress.XtraGrid.Columns.GridColumn colkestenddate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn colmostahk;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditf2;
        private DevExpress.XtraGrid.Columns.GridColumn colmadfoaa;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno;
        private DevExpress.XtraGrid.Columns.GridColumn colesaldate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private System.Windows.Forms.BindingSource tBLMembersListBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLMembersListTableAdapter tBLMembersListTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
    }
}