namespace Members.Forms.Qry
{
    partial class Qry21Frm
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
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.LUEHafza = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tBLHafzawebListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnionList = new Members.DataSources.dsTeachersUnion();
            this.repositoryItemLookUpEditSyndicateId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colhafzaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhafzadate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllCount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosedCount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.qry21BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnionQuery = new Members.DataSources.dsTeachersUnionQuery();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditclosed = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimagepath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tBLHafzawebListTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLHafzawebListTableAdapter();
            this.qry21TableAdapter = new Members.DataSources.dsTeachersUnionQueryTableAdapters.Qry21TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEHafza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHafzawebListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSyndicateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry21BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditclosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.pbc);
            this.groupControl1.Controls.Add(this.LUEHafza);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(668, 64);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "الحافظة";
            // 
            // pbc
            // 
            this.pbc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbc.Location = new System.Drawing.Point(6, 34);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(317, 18);
            this.pbc.TabIndex = 6;
            // 
            // LUEHafza
            // 
            this.LUEHafza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LUEHafza.EditValue = "";
            this.LUEHafza.Location = new System.Drawing.Point(329, 33);
            this.LUEHafza.Name = "LUEHafza";
            this.LUEHafza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEHafza.Properties.DataSource = this.tBLHafzawebListBindingSource;
            this.LUEHafza.Properties.DisplayMember = "hafzaid";
            this.LUEHafza.Properties.NullText = "";
            this.LUEHafza.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditSyndicateId});
            this.LUEHafza.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEHafza.Properties.ValueMember = "hafzaid";
            this.LUEHafza.Properties.View = this.gridLookUpEdit2View;
            this.LUEHafza.Size = new System.Drawing.Size(249, 20);
            this.LUEHafza.TabIndex = 5;
            this.LUEHafza.EditValueChanged += new System.EventHandler(this.LUEHafza_EditValueChanged);
            // 
            // tBLHafzawebListBindingSource
            // 
            this.tBLHafzawebListBindingSource.DataMember = "TBLHafzawebList";
            this.tBLHafzawebListBindingSource.DataSource = this.dsTeachersUnionList;
            // 
            // dsTeachersUnionList
            // 
            this.dsTeachersUnionList.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnionList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemLookUpEditSyndicateId
            // 
            this.repositoryItemLookUpEditSyndicateId.AutoHeight = false;
            this.repositoryItemLookUpEditSyndicateId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSyndicateId.DisplayMember = "Syndicate";
            this.repositoryItemLookUpEditSyndicateId.Name = "repositoryItemLookUpEditSyndicateId";
            this.repositoryItemLookUpEditSyndicateId.NullText = "";
            this.repositoryItemLookUpEditSyndicateId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditSyndicateId.ValueMember = "SyndicateId";
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colhafzaid,
            this.colSyndicateId,
            this.colhafzadate,
            this.colAllCount1,
            this.colClosedCount1});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit2View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colhafzaid
            // 
            this.colhafzaid.AppearanceCell.Options.UseTextOptions = true;
            this.colhafzaid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzaid.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafzaid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzaid.Caption = "رقم الحافظة";
            this.colhafzaid.FieldName = "hafzaid";
            this.colhafzaid.Name = "colhafzaid";
            this.colhafzaid.Visible = true;
            this.colhafzaid.VisibleIndex = 0;
            // 
            // colSyndicateId
            // 
            this.colSyndicateId.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.Caption = "النقابة الفرعية";
            this.colSyndicateId.ColumnEdit = this.repositoryItemLookUpEditSyndicateId;
            this.colSyndicateId.FieldName = "SyndicateId";
            this.colSyndicateId.Name = "colSyndicateId";
            this.colSyndicateId.Visible = true;
            this.colSyndicateId.VisibleIndex = 1;
            // 
            // colhafzadate
            // 
            this.colhafzadate.AppearanceCell.Options.UseTextOptions = true;
            this.colhafzadate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzadate.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafzadate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzadate.Caption = "تاريخ الحافظة";
            this.colhafzadate.FieldName = "hafzadate";
            this.colhafzadate.Name = "colhafzadate";
            this.colhafzadate.Visible = true;
            this.colhafzadate.VisibleIndex = 2;
            // 
            // colAllCount1
            // 
            this.colAllCount1.AppearanceCell.Options.UseTextOptions = true;
            this.colAllCount1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllCount1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllCount1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllCount1.Caption = "الاجمالي";
            this.colAllCount1.FieldName = "AllCount";
            this.colAllCount1.Name = "colAllCount1";
            this.colAllCount1.OptionsColumn.ReadOnly = true;
            this.colAllCount1.Visible = true;
            this.colAllCount1.VisibleIndex = 3;
            // 
            // colClosedCount1
            // 
            this.colClosedCount1.AppearanceCell.Options.UseTextOptions = true;
            this.colClosedCount1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClosedCount1.AppearanceHeader.Options.UseTextOptions = true;
            this.colClosedCount1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClosedCount1.Caption = "المرحل";
            this.colClosedCount1.FieldName = "ClosedCount";
            this.colClosedCount1.Name = "colClosedCount1";
            this.colClosedCount1.OptionsColumn.ReadOnly = true;
            this.colClosedCount1.Visible = true;
            this.colClosedCount1.VisibleIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(612, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "اختر حافظة";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.gridControlData);
            this.groupControl3.Location = new System.Drawing.Point(12, 82);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(668, 279);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "تفاصيل للحافظة";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.qry21BindingSource;
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
            this.repositoryItemCheckEditclosed});
            this.gridControlData.Size = new System.Drawing.Size(664, 256);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // qry21BindingSource
            // 
            this.qry21BindingSource.DataMember = "Qry21";
            this.qry21BindingSource.DataSource = this.dsTeachersUnionQuery;
            // 
            // dsTeachersUnionQuery
            // 
            this.dsTeachersUnionQuery.DataSetName = "dsTeachersUnionQuery";
            this.dsTeachersUnionQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberName,
            this.colKideNumber,
            this.gridColumn2,
            this.colSyndicate,
            this.colimagepath,
            this.gridColumn1});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
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
            this.colMemberName.OptionsColumn.ReadOnly = true;
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 0;
            this.colMemberName.Width = 234;
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
            this.colKideNumber.VisibleIndex = 1;
            this.colKideNumber.Width = 62;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "مغلق";
            this.gridColumn2.ColumnEdit = this.repositoryItemCheckEditclosed;
            this.gridColumn2.FieldName = "closed";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 48;
            // 
            // repositoryItemCheckEditclosed
            // 
            this.repositoryItemCheckEditclosed.AutoHeight = false;
            this.repositoryItemCheckEditclosed.Name = "repositoryItemCheckEditclosed";
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
            // colimagepath
            // 
            this.colimagepath.AppearanceCell.Options.UseTextOptions = true;
            this.colimagepath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimagepath.AppearanceHeader.Options.UseTextOptions = true;
            this.colimagepath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimagepath.Caption = "المسار";
            this.colimagepath.FieldName = "imagepath";
            this.colimagepath.Name = "colimagepath";
            this.colimagepath.Visible = true;
            this.colimagepath.VisibleIndex = 4;
            this.colimagepath.Width = 173;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "تعديل";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 51;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // tBLHafzawebListTableAdapter
            // 
            this.tBLHafzawebListTableAdapter.ClearBeforeFill = true;
            // 
            // qry21TableAdapter
            // 
            this.qry21TableAdapter.ClearBeforeFill = true;
            // 
            // Qry21Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "Qry21Frm";
            this.Text = "مسارات الويب المفقودة";
            this.Load += new System.EventHandler(this.TBLHafzawebFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEHafza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHafzawebListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSyndicateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry21BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditclosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DataSources.dsTeachersUnion dsTeachersUnionList;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private System.Windows.Forms.BindingSource tBLHafzawebListBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLHafzawebListTableAdapter tBLHafzawebListTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditclosed;
        private DevExpress.XtraEditors.GridLookUpEdit LUEHafza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colhafzaid;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateId;
        private DevExpress.XtraGrid.Columns.GridColumn colhafzadate;
        private DevExpress.XtraGrid.Columns.GridColumn colAllCount1;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedCount1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSyndicateId;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private System.Windows.Forms.BindingSource qry21BindingSource;
        private DataSources.dsTeachersUnionQuery dsTeachersUnionQuery;
        private DataSources.dsTeachersUnionQueryTableAdapters.Qry21TableAdapter qry21TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colimagepath;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
    }
}