namespace Members
{
    partial class TBLManualArsheefDetailsFrm
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
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LUEEmp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tBLPrintCardListGroupedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colesalno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprintdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tBLManualArsheefDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKartonaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalno1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprintdate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberShipNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemLookUpEditMemberId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tBLMembersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLManualArsheefDetailsTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLManualArsheefDetailsTableAdapter();
            this.tBLMembersListTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMembersListTableAdapter();
            this.tBLPrintCardListGroupedTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLPrintCardListGroupedTableAdapter();
            this.coltotalDone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCalcFree = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPrintCardListGroupedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLManualArsheefDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditMemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMembersListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.LUEEmp);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(784, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "خيارات الالحاق";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(252, 57);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Tag = "save";
            this.btnAdd.Text = "ألحاق";
            this.btnAdd.ToolTip = "اضعط هنا لحفظ جديد";
            this.btnAdd.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAdd.ToolTipTitle = "حفظ جديد F6";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(492, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "البيانات";
            // 
            // LUEEmp
            // 
            this.LUEEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUEEmp.Location = new System.Drawing.Point(252, 31);
            this.LUEEmp.Margin = new System.Windows.Forms.Padding(0);
            this.LUEEmp.Name = "LUEEmp";
            this.LUEEmp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEmp.Properties.DataSource = this.tBLPrintCardListGroupedBindingSource;
            this.LUEEmp.Properties.DisplayMember = "esalno";
            this.LUEEmp.Properties.NullText = "";
            this.LUEEmp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEEmp.Properties.View = this.gridLookUpEdit1View;
            this.LUEEmp.Size = new System.Drawing.Size(231, 20);
            this.LUEEmp.TabIndex = 2;
            // 
            // tBLPrintCardListGroupedBindingSource
            // 
            this.tBLPrintCardListGroupedBindingSource.DataMember = "TBLPrintCardListGrouped";
            this.tBLPrintCardListGroupedBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colesalno,
            this.colprintdate,
            this.coltotal,
            this.coltotalDone,
            this.gcCalcFree});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            // 
            // colprintdate
            // 
            this.colprintdate.AppearanceCell.Options.UseTextOptions = true;
            this.colprintdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprintdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colprintdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprintdate.Caption = "تاريخ الطباعة";
            this.colprintdate.FieldName = "printdate";
            this.colprintdate.Name = "colprintdate";
            this.colprintdate.Visible = true;
            this.colprintdate.VisibleIndex = 1;
            // 
            // coltotal
            // 
            this.coltotal.AppearanceCell.Options.UseTextOptions = true;
            this.coltotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotal.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotal.Caption = "العدد";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.gridControlData);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 100);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(784, 262);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "تفاصيل ما تم ألحاقة";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLManualArsheefDetailsBindingSource;
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
            this.repositoryItemLookUpEditMemberId});
            this.gridControlData.Size = new System.Drawing.Size(780, 239);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tBLManualArsheefDetailsBindingSource
            // 
            this.tBLManualArsheefDetailsBindingSource.DataMember = "TBLManualArsheefDetails";
            this.tBLManualArsheefDetailsBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKartonaNo,
            this.colesalno1,
            this.colprintdate1,
            this.colMemberName,
            this.colSyndicate,
            this.colSubCommitte,
            this.colKideNumber,
            this.colMemberShipNumber,
            this.gridColumn4});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            // 
            // colKartonaNo
            // 
            this.colKartonaNo.AppearanceCell.Options.UseTextOptions = true;
            this.colKartonaNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartonaNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colKartonaNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartonaNo.Caption = "رقم الكارتونة";
            this.colKartonaNo.FieldName = "KartonaNo";
            this.colKartonaNo.Name = "colKartonaNo";
            this.colKartonaNo.OptionsColumn.AllowEdit = false;
            this.colKartonaNo.OptionsColumn.ReadOnly = true;
            this.colKartonaNo.Visible = true;
            this.colKartonaNo.VisibleIndex = 0;
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
            this.colesalno1.OptionsColumn.AllowEdit = false;
            this.colesalno1.OptionsColumn.ReadOnly = true;
            this.colesalno1.Visible = true;
            this.colesalno1.VisibleIndex = 1;
            this.colesalno1.Width = 78;
            // 
            // colprintdate1
            // 
            this.colprintdate1.AppearanceCell.Options.UseTextOptions = true;
            this.colprintdate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprintdate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colprintdate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprintdate1.Caption = "تاريخ الطباعة";
            this.colprintdate1.FieldName = "printdate";
            this.colprintdate1.Name = "colprintdate1";
            this.colprintdate1.OptionsColumn.AllowEdit = false;
            this.colprintdate1.OptionsColumn.ReadOnly = true;
            this.colprintdate1.Visible = true;
            this.colprintdate1.VisibleIndex = 2;
            this.colprintdate1.Width = 78;
            // 
            // colMemberName
            // 
            this.colMemberName.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName.Caption = "اسم العضو";
            this.colMemberName.FieldName = "MemberName";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.OptionsColumn.ReadOnly = true;
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 3;
            this.colMemberName.Width = 179;
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
            this.colSyndicate.OptionsColumn.ReadOnly = true;
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 4;
            this.colSyndicate.Width = 122;
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
            this.colSubCommitte.OptionsColumn.ReadOnly = true;
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 5;
            this.colSubCommitte.Width = 115;
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
            this.colKideNumber.OptionsColumn.ReadOnly = true;
            this.colKideNumber.Visible = true;
            this.colKideNumber.VisibleIndex = 6;
            // 
            // colMemberShipNumber
            // 
            this.colMemberShipNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberShipNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberShipNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberShipNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberShipNumber.Caption = "رقم العضوية";
            this.colMemberShipNumber.FieldName = "MemberShipNumber";
            this.colMemberShipNumber.Name = "colMemberShipNumber";
            this.colMemberShipNumber.OptionsColumn.ReadOnly = true;
            this.colMemberShipNumber.Visible = true;
            this.colMemberShipNumber.VisibleIndex = 7;
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
            this.gridColumn4.VisibleIndex = 8;
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
            // repositoryItemLookUpEditMemberId
            // 
            this.repositoryItemLookUpEditMemberId.AutoHeight = false;
            this.repositoryItemLookUpEditMemberId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditMemberId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MemberName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditMemberId.DataSource = this.tBLMembersListBindingSource;
            this.repositoryItemLookUpEditMemberId.DisplayMember = "MemberName";
            this.repositoryItemLookUpEditMemberId.Name = "repositoryItemLookUpEditMemberId";
            this.repositoryItemLookUpEditMemberId.ReadOnly = true;
            this.repositoryItemLookUpEditMemberId.ValueMember = "MemberId";
            // 
            // tBLMembersListBindingSource
            // 
            this.tBLMembersListBindingSource.DataMember = "TBLMembersList";
            this.tBLMembersListBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // tBLManualArsheefDetailsTableAdapter
            // 
            this.tBLManualArsheefDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMembersListTableAdapter
            // 
            this.tBLMembersListTableAdapter.ClearBeforeFill = true;
            // 
            // tBLPrintCardListGroupedTableAdapter
            // 
            this.tBLPrintCardListGroupedTableAdapter.ClearBeforeFill = true;
            // 
            // coltotalDone
            // 
            this.coltotalDone.AppearanceCell.Options.UseTextOptions = true;
            this.coltotalDone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalDone.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotalDone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalDone.Caption = "تم ألحاقة من قبل";
            this.coltotalDone.FieldName = "totalDone";
            this.coltotalDone.Name = "coltotalDone";
            this.coltotalDone.Visible = true;
            this.coltotalDone.VisibleIndex = 3;
            // 
            // gcCalcFree
            // 
            this.gcCalcFree.AppearanceCell.Options.UseTextOptions = true;
            this.gcCalcFree.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcCalcFree.AppearanceHeader.Options.UseTextOptions = true;
            this.gcCalcFree.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcCalcFree.Caption = "لم يتم ألحاقة";
            this.gcCalcFree.FieldName = "gcCalcFree";
            this.gcCalcFree.Name = "gcCalcFree";
            this.gcCalcFree.UnboundExpression = "[total]  - [totalDone]";
            this.gcCalcFree.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gcCalcFree.Visible = true;
            this.gcCalcFree.VisibleIndex = 4;
            // 
            // TBLManualArsheefDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "TBLManualArsheefDetailsFrm";
            this.Text = "التفاصيل";
            this.Load += new System.EventHandler(this.TBLMandoopFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPrintCardListGroupedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLManualArsheefDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditMemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMembersListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit LUEEmp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno;
        private DevExpress.XtraGrid.Columns.GridColumn colprintdate;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLManualArsheefDetailsBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLManualArsheefDetailsTableAdapter tBLManualArsheefDetailsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno1;
        private DevExpress.XtraGrid.Columns.GridColumn colprintdate1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditMemberId;
        private System.Windows.Forms.BindingSource tBLMembersListBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLMembersListTableAdapter tBLMembersListTableAdapter;
        private System.Windows.Forms.BindingSource tBLPrintCardListGroupedBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLPrintCardListGroupedTableAdapter tBLPrintCardListGroupedTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberShipNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colKartonaNo;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalDone;
        private DevExpress.XtraGrid.Columns.GridColumn gcCalcFree;
    }
}