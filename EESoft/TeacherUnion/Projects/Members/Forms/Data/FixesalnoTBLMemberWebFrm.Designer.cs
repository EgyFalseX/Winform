namespace Members.Forms.Data
{
    partial class FixesalnoTBLMemberWebFrm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.fixesalnoTBLMemberWebBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnionQuery = new Members.DataSources.dsTeachersUnionQuery();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tbtbesalnoSearch = new DevExpress.XtraEditors.ButtonEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueSyndicateId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDSyndicateTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbtbesalnoUpdate = new DevExpress.XtraEditors.TextEdit();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fixesalnoTBLMemberWebTableAdapter = new Members.DataSources.dsTeachersUnionQueryTableAdapters.FixesalnoTBLMemberWebTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixesalnoTBLMemberWebBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtbesalnoSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtbesalnoUpdate.Properties)).BeginInit();
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
            this.groupControl3.Location = new System.Drawing.Point(0, 57);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(684, 347);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "تفاصيل";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.fixesalnoTBLMemberWebBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(680, 324);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // fixesalnoTBLMemberWebBindingSource
            // 
            this.fixesalnoTBLMemberWebBindingSource.DataMember = "FixesalnoTBLMemberWeb";
            this.fixesalnoTBLMemberWebBindingSource.DataSource = this.dsTeachersUnionQuery;
            // 
            // dsTeachersUnionQuery
            // 
            this.dsTeachersUnionQuery.DataSetName = "dsTeachersUnionQuery";
            this.dsTeachersUnionQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberName1,
            this.colSyndicate1,
            this.colKideNumber,
            this.colesalno});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضعظ لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
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
            this.colMemberName1.Width = 279;
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
            this.colSyndicate1.Width = 155;
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
            this.colKideNumber.Width = 120;
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
            this.colesalno.Width = 104;
            // 
            // groupControl2
            // 
            this.groupControl2.AllowTouchScroll = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.tbtbesalnoSearch);
            this.groupControl2.Controls.Add(this.btnSearch);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.lueSyndicateId);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(684, 51);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "خيارات";
            // 
            // tbtbesalnoSearch
            // 
            this.tbtbesalnoSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbtbesalnoSearch.Location = new System.Drawing.Point(198, 24);
            this.tbtbesalnoSearch.Name = "tbtbesalnoSearch";
            this.tbtbesalnoSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbtbesalnoSearch.Properties.Appearance.Options.UseFont = true;
            this.tbtbesalnoSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", 40, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.tbtbesalnoSearch.Properties.DisplayFormat.FormatString = "n0";
            this.tbtbesalnoSearch.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbtbesalnoSearch.Properties.EditFormat.FormatString = "n0";
            this.tbtbesalnoSearch.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbtbesalnoSearch.Properties.Mask.EditMask = "n0";
            this.tbtbesalnoSearch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbtbesalnoSearch.Size = new System.Drawing.Size(150, 22);
            this.tbtbesalnoSearch.TabIndex = 1;
            this.tbtbesalnoSearch.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.tbtbesalnoSearch_ButtonClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Location = new System.Drawing.Point(92, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحـــــــث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(354, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "رقم الايصال";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(631, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "الفرعية";
            // 
            // lueSyndicateId
            // 
            this.lueSyndicateId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lueSyndicateId.Location = new System.Drawing.Point(425, 24);
            this.lueSyndicateId.Name = "lueSyndicateId";
            this.lueSyndicateId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueSyndicateId.Properties.Appearance.Options.UseFont = true;
            this.lueSyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", 40, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.lueSyndicateId.Properties.DataSource = this.cDSyndicateBindingSource;
            this.lueSyndicateId.Properties.DisplayMember = "Syndicate";
            this.lueSyndicateId.Properties.NullText = "";
            this.lueSyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyndicateId.Properties.ValueMember = "SyndicateId";
            this.lueSyndicateId.Properties.View = this.gridLookUpEdit1View;
            this.lueSyndicateId.Size = new System.Drawing.Size(200, 22);
            this.lueSyndicateId.TabIndex = 0;
            this.lueSyndicateId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueSyndicateId_ButtonClick);
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSyndicate2
            // 
            this.colSyndicate2.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate2.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate2.Caption = "الفرعية";
            this.colSyndicate2.FieldName = "Syndicate";
            this.colSyndicate2.Name = "colSyndicate2";
            this.colSyndicate2.Visible = true;
            this.colSyndicate2.VisibleIndex = 0;
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.AllowTouchScroll = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.tbtbesalnoUpdate);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 410);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(684, 51);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "تعديل";
            // 
            // tbtbesalnoUpdate
            // 
            this.tbtbesalnoUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbtbesalnoUpdate.Location = new System.Drawing.Point(451, 26);
            this.tbtbesalnoUpdate.Name = "tbtbesalnoUpdate";
            this.tbtbesalnoUpdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbtbesalnoUpdate.Properties.Appearance.Options.UseFont = true;
            this.tbtbesalnoUpdate.Size = new System.Drawing.Size(150, 22);
            this.tbtbesalnoUpdate.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Location = new System.Drawing.Point(345, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(607, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "رقم الايصال";
            // 
            // fixesalnoTBLMemberWebTableAdapter
            // 
            this.fixesalnoTBLMemberWebTableAdapter.ClearBeforeFill = true;
            // 
            // FixesalnoTBLMemberWebFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Name = "FixesalnoTBLMemberWebFrm";
            this.Text = "تعديل ايصال اعضاء الويب";
            this.Load += new System.EventHandler(this.FixesalnoTBLMembersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixesalnoTBLMemberWebBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtbesalnoSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtbesalnoUpdate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GridLookUpEdit lueSyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit tbtbesalnoSearch;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate2;
        private DataSources.dsTeachersUnionQuery dsTeachersUnionQuery;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbtbesalnoUpdate;
        private System.Windows.Forms.BindingSource fixesalnoTBLMemberWebBindingSource;
        private DataSources.dsTeachersUnionQueryTableAdapters.FixesalnoTBLMemberWebTableAdapter fixesalnoTBLMemberWebTableAdapter;
    }
}