namespace Members
{
    partial class TBLMembersFastKidFrm
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
            this.LSMSMembers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.colEDARET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDARET1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdaraMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnkapaMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.cDSyndicateTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter();
            this.tblMembersTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.LSMSMembers;
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
            this.repositoryItemButtonEditDel});
            this.gridControlData.Size = new System.Drawing.Size(756, 273);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // LSMSMembers
            // 
            this.LSMSMembers.ElementType = typeof(Members.DataSources.Linq.vTBLMembersPlusTBLMemberHala);
            this.LSMSMembers.KeyExpression = "[MemberId]";
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumnSave,
            this.gridColumnDelete});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewData_InvalidRowException);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "MemberName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 250;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "رقم القيد";
            this.gridColumn3.FieldName = "KideNumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 108;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "رقم الايصال";
            this.gridColumn4.FieldName = "esalno";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 119;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "الفرعية";
            this.gridColumn5.FieldName = "Syndicate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 138;
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
            this.gridColumnSave.VisibleIndex = 4;
            this.gridColumnSave.Width = 78;
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
            this.gridColumnDelete.VisibleIndex = 5;
            this.gridColumnDelete.Width = 38;
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
            this.btnNew.Image = global::Members.Properties.Resources.Add;
            this.btnNew.Location = new System.Drawing.Point(555, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // tblMembersTableAdapter
            // 
            this.tblMembersTableAdapter.ClearBeforeFill = true;
            // 
            // TBLMembersFastKidFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 388);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "TBLMembersFastKidFrm";
            this.Text = "الاعضاء للقيد";
            this.Load += new System.EventHandler(this.FormFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
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
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET1;
        private DevExpress.XtraGrid.Columns.GridColumn colEdaraMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSMembers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter tblMembersTableAdapter;
    }
}