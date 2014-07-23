namespace Members
{
    partial class TBLManualArsheefFrm
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
            this.tBLManualArsheefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKartonaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEditAREMARK = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEditDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDatein = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdituserin = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tBLManualArsheefTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLManualArsheefTableAdapter();
            this.usersTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLManualArsheefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditAREMARK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEditDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLManualArsheefBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDel,
            this.repositoryItemDateEditDatein,
            this.repositoryItemButtonEditEditDetails,
            this.repositoryItemMemoEditAREMARK,
            this.repositoryItemLookUpEdituserin});
            this.gridControlData.Size = new System.Drawing.Size(784, 362);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // tBLManualArsheefBindingSource
            // 
            this.tBLManualArsheefBindingSource.DataMember = "TBLManualArsheef";
            this.tBLManualArsheefBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKartonaNo,
            this.colAREMARK,
            this.gridColumn11,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "أضغط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.RowHeight = 30;
            this.gridViewData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewData_InitNewRow);
            // 
            // colKartonaNo
            // 
            this.colKartonaNo.AppearanceCell.Options.UseTextOptions = true;
            this.colKartonaNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartonaNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colKartonaNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartonaNo.Caption = "رقم الكارتونة ";
            this.colKartonaNo.FieldName = "KartonaNo";
            this.colKartonaNo.Name = "colKartonaNo";
            this.colKartonaNo.Visible = true;
            this.colKartonaNo.VisibleIndex = 0;
            // 
            // colAREMARK
            // 
            this.colAREMARK.AppearanceCell.Options.UseTextOptions = true;
            this.colAREMARK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAREMARK.AppearanceHeader.Options.UseTextOptions = true;
            this.colAREMARK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAREMARK.Caption = "ملاحظات";
            this.colAREMARK.ColumnEdit = this.repositoryItemMemoEditAREMARK;
            this.colAREMARK.FieldName = "AREMARK";
            this.colAREMARK.Name = "colAREMARK";
            this.colAREMARK.Visible = true;
            this.colAREMARK.VisibleIndex = 1;
            this.colAREMARK.Width = 518;
            // 
            // repositoryItemMemoEditAREMARK
            // 
            this.repositoryItemMemoEditAREMARK.Name = "repositoryItemMemoEditAREMARK";
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "الي التفاصيل";
            this.gridColumn11.ColumnEdit = this.repositoryItemButtonEditEditDetails;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 80;
            // 
            // repositoryItemButtonEditEditDetails
            // 
            this.repositoryItemButtonEditEditDetails.AutoHeight = false;
            this.repositoryItemButtonEditEditDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditEditDetails.Name = "repositoryItemButtonEditEditDetails";
            this.repositoryItemButtonEditEditDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEditDetails.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEditDetails_ButtonClick);
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "تاريخ الادخال";
            this.gridColumn8.ColumnEdit = this.repositoryItemDateEditDatein;
            this.gridColumn8.FieldName = "datein";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
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
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "مدخل البيانات";
            this.gridColumn9.ColumnEdit = this.repositoryItemLookUpEdituserin;
            this.gridColumn9.FieldName = "userin";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemLookUpEdituserin
            // 
            this.repositoryItemLookUpEdituserin.AutoHeight = false;
            this.repositoryItemLookUpEdituserin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdituserin.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEdituserin.DataSource = this.usersBindingSource;
            this.repositoryItemLookUpEdituserin.DisplayMember = "UserName";
            this.repositoryItemLookUpEdituserin.Name = "repositoryItemLookUpEdituserin";
            this.repositoryItemLookUpEdituserin.NullText = "";
            this.repositoryItemLookUpEdituserin.ReadOnly = true;
            this.repositoryItemLookUpEdituserin.ValueMember = "UserID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsTeachersUnion;
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
            this.gridColumn3.VisibleIndex = 3;
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
            this.gridColumn4.VisibleIndex = 4;
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
            // ofd
            // 
            this.ofd.Filter = "Images(*.jpg)|*.jpg|All Files(*.*)|*.*";
            this.ofd.FilterIndex = 0;
            this.ofd.Title = "اختر صورة";
            // 
            // tBLManualArsheefTableAdapter
            // 
            this.tBLManualArsheefTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // TBLManualArsheefFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.gridControlData);
            this.Name = "TBLManualArsheefFrm";
            this.Text = "الارشيف اليدوي";
            this.Load += new System.EventHandler(this.TBLMandoopFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLManualArsheefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditAREMARK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEditDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDatein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDatein;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEditDetails;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLManualArsheefBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLManualArsheefTableAdapter tBLManualArsheefTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAREMARK;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEditAREMARK;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdituserin;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colKartonaNo;
    }
}