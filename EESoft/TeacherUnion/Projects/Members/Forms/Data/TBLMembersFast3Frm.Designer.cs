namespace Members.Forms.Data
{
    partial class TBLMembersFast3Frm
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tBLMembersMobileEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditSyndicateId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditSubCommitteId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cDSubCommitteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMemberPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tBLMembersMobileEditTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMembersMobileEditTableAdapter();
            this.GLUESyndicateId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cDSyndicateTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter();
            this.cDSubCommitteTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSubCommitteTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbKidNumber = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMembersMobileEditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSyndicateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSubCommitteId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSubCommitteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLUESyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKidNumber.Properties)).BeginInit();
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
            this.groupControl3.Location = new System.Drawing.Point(12, 36);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(711, 325);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "الاعضاء";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLMembersMobileEditBindingSource;
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
            this.repositoryItemLookUpEditSyndicateId,
            this.repositoryItemLookUpEditSubCommitteId});
            this.gridControlData.Size = new System.Drawing.Size(707, 302);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tBLMembersMobileEditBindingSource
            // 
            this.tBLMembersMobileEditBindingSource.DataMember = "TBLMembersMobileEdit";
            this.tBLMembersMobileEditBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberName,
            this.colKideNumber,
            this.colSyndicate1,
            this.colSubCommitte,
            this.colMemberPhone,
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
            this.colMemberName.OptionsColumn.AllowEdit = false;
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 0;
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
            this.colKideNumber.VisibleIndex = 1;
            // 
            // colSyndicate1
            // 
            this.colSyndicate1.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.Caption = "الفرعية";
            this.colSyndicate1.ColumnEdit = this.repositoryItemLookUpEditSyndicateId;
            this.colSyndicate1.FieldName = "SyndicateId";
            this.colSyndicate1.Name = "colSyndicate1";
            this.colSyndicate1.OptionsColumn.AllowEdit = false;
            this.colSyndicate1.Visible = true;
            this.colSyndicate1.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditSyndicateId
            // 
            this.repositoryItemLookUpEditSyndicateId.AutoHeight = false;
            this.repositoryItemLookUpEditSyndicateId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSyndicateId.DataSource = this.cDSyndicateBindingSource;
            this.repositoryItemLookUpEditSyndicateId.DisplayMember = "Syndicate";
            this.repositoryItemLookUpEditSyndicateId.Name = "repositoryItemLookUpEditSyndicateId";
            this.repositoryItemLookUpEditSyndicateId.NullText = "";
            this.repositoryItemLookUpEditSyndicateId.ValueMember = "SyndicateId";
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "اللجنة";
            this.colSubCommitte.ColumnEdit = this.repositoryItemLookUpEditSubCommitteId;
            this.colSubCommitte.FieldName = "SubCommitteId";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.OptionsColumn.AllowEdit = false;
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEditSubCommitteId
            // 
            this.repositoryItemLookUpEditSubCommitteId.AutoHeight = false;
            this.repositoryItemLookUpEditSubCommitteId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSubCommitteId.DataSource = this.cDSubCommitteBindingSource;
            this.repositoryItemLookUpEditSubCommitteId.DisplayMember = "SubCommitte";
            this.repositoryItemLookUpEditSubCommitteId.Name = "repositoryItemLookUpEditSubCommitteId";
            this.repositoryItemLookUpEditSubCommitteId.NullText = "";
            this.repositoryItemLookUpEditSubCommitteId.ValueMember = "SubCommitteId";
            // 
            // cDSubCommitteBindingSource
            // 
            this.cDSubCommitteBindingSource.DataMember = "CDSubCommitte";
            this.cDSubCommitteBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // colMemberPhone
            // 
            this.colMemberPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberPhone.Caption = "رقم الموبيل";
            this.colMemberPhone.FieldName = "MemberMobil";
            this.colMemberPhone.Name = "colMemberPhone";
            this.colMemberPhone.Visible = true;
            this.colMemberPhone.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "حفظ";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
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
            // tBLMembersMobileEditTableAdapter
            // 
            this.tBLMembersMobileEditTableAdapter.ClearBeforeFill = true;
            // 
            // GLUESyndicateId
            // 
            this.GLUESyndicateId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GLUESyndicateId.Location = new System.Drawing.Point(461, 10);
            this.GLUESyndicateId.Name = "GLUESyndicateId";
            this.GLUESyndicateId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.GLUESyndicateId.Properties.Appearance.Options.UseFont = true;
            this.GLUESyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GLUESyndicateId.Properties.DataSource = this.cDSyndicateBindingSource;
            this.GLUESyndicateId.Properties.DisplayMember = "Syndicate";
            this.GLUESyndicateId.Properties.NullText = "";
            this.GLUESyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.GLUESyndicateId.Properties.ValueMember = "SyndicateId";
            this.GLUESyndicateId.Properties.View = this.gridLookUpEdit1View;
            this.GLUESyndicateId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GLUESyndicateId.Size = new System.Drawing.Size(209, 24);
            this.GLUESyndicateId.TabIndex = 0;
            this.GLUESyndicateId.EditValueChanged += new System.EventHandler(this.GLUESyndicateId_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.colSyndicate.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(676, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "الفرعية";
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // cDSubCommitteTableAdapter
            // 
            this.cDSubCommitteTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(400, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "رقم القيد";
            // 
            // tbKidNumber
            // 
            this.tbKidNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKidNumber.Location = new System.Drawing.Point(166, 10);
            this.tbKidNumber.Name = "tbKidNumber";
            this.tbKidNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbKidNumber.Properties.Appearance.Options.UseFont = true;
            this.tbKidNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", 50, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.tbKidNumber.Size = new System.Drawing.Size(228, 24);
            this.tbKidNumber.TabIndex = 1;
            this.tbKidNumber.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.tbKidNumber_ButtonClick);
            // 
            // TBLMembersFast3Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 373);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GLUESyndicateId);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.tbKidNumber);
            this.Name = "TBLMembersFast3Frm";
            this.Text = "تعديل ارقام موبيل الاعضاء";
            this.Load += new System.EventHandler(this.TBLMembersFast3Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMembersMobileEditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSyndicateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSubCommitteId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSubCommitteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLUESyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKidNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLMembersMobileEditBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLMembersMobileEditTableAdapter tBLMembersMobileEditTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GridLookUpEdit GLUESyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSyndicateId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSubCommitteId;
        private System.Windows.Forms.BindingSource cDSubCommitteBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSubCommitteTableAdapter cDSubCommitteTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit tbKidNumber;
    }
}