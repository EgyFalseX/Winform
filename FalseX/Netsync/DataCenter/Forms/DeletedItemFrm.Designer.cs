namespace DataCenter.Forms
{
    partial class DeletedItemFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletedItemFrm));
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeIconData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEditTypeIconData = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemGridLookUpEditUserLevelId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserLevelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditUserPass = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemCheckEditIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditTypeIconData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserLevelId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditUserPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.LSMSData;
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
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDelete,
            this.repositoryItemGridLookUpEditUserLevelId,
            this.repositoryItemMemoExEditUserPass,
            this.repositoryItemCheckEditIsActive,
            this.repositoryItemPictureEditTypeIconData});
            this.gridControlData.Size = new System.Drawing.Size(814, 361);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(DataCenter.DataSources.Linq.vDeletedItem);
            this.LSMSData.KeyExpression = "ItemId";
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeIconData,
            this.colItemName,
            this.colTypeName,
            this.colCategoryName,
            this.colOwnerRealName,
            this.colLastRealName,
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضعط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.RowAutoHeight = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.OptionsView.ShowIndicator = false;
            this.gridViewData.OptionsView.ShowPreview = true;
            this.gridViewData.RowHeight = 36;
            this.gridViewData.CalcPreviewText += new DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(this.gridViewData_CalcPreviewText);
            // 
            // colTypeIconData
            // 
            this.colTypeIconData.AppearanceCell.Options.UseTextOptions = true;
            this.colTypeIconData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeIconData.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeIconData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeIconData.Caption = ".";
            this.colTypeIconData.ColumnEdit = this.repositoryItemPictureEditTypeIconData;
            this.colTypeIconData.FieldName = "TypeIconData";
            this.colTypeIconData.Name = "colTypeIconData";
            this.colTypeIconData.OptionsColumn.AllowEdit = false;
            this.colTypeIconData.Visible = true;
            this.colTypeIconData.VisibleIndex = 0;
            this.colTypeIconData.Width = 35;
            // 
            // repositoryItemPictureEditTypeIconData
            // 
            this.repositoryItemPictureEditTypeIconData.Name = "repositoryItemPictureEditTypeIconData";
            this.repositoryItemPictureEditTypeIconData.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            // 
            // colItemName
            // 
            this.colItemName.AppearanceCell.Options.UseTextOptions = true;
            this.colItemName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemName.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemName.Caption = "اسم الملف";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 149;
            // 
            // colTypeName
            // 
            this.colTypeName.AppearanceCell.Options.UseTextOptions = true;
            this.colTypeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeName.Caption = "نوع الملف";
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.OptionsColumn.AllowEdit = false;
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 2;
            this.colTypeName.Width = 123;
            // 
            // colCategoryName
            // 
            this.colCategoryName.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoryName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoryName.Caption = "المجلد";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.OptionsColumn.AllowEdit = false;
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 3;
            this.colCategoryName.Width = 111;
            // 
            // colOwnerRealName
            // 
            this.colOwnerRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colOwnerRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colOwnerRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerRealName.Caption = "مستخدم الانشاء";
            this.colOwnerRealName.FieldName = "OwnerRealName";
            this.colOwnerRealName.Name = "colOwnerRealName";
            this.colOwnerRealName.OptionsColumn.AllowEdit = false;
            this.colOwnerRealName.Visible = true;
            this.colOwnerRealName.VisibleIndex = 4;
            this.colOwnerRealName.Width = 124;
            // 
            // colLastRealName
            // 
            this.colLastRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colLastRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLastRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colLastRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLastRealName.Caption = "مستخدم اخر تعديل";
            this.colLastRealName.FieldName = "LastRealName";
            this.colLastRealName.Name = "colLastRealName";
            this.colLastRealName.OptionsColumn.AllowEdit = false;
            this.colLastRealName.Visible = true;
            this.colLastRealName.VisibleIndex = 5;
            this.colLastRealName.Width = 119;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "ارجاع";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
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
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "حذف";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
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
            // repositoryItemGridLookUpEditUserLevelId
            // 
            this.repositoryItemGridLookUpEditUserLevelId.AutoHeight = false;
            this.repositoryItemGridLookUpEditUserLevelId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditUserLevelId.DisplayMember = "UserLevelName";
            this.repositoryItemGridLookUpEditUserLevelId.Name = "repositoryItemGridLookUpEditUserLevelId";
            this.repositoryItemGridLookUpEditUserLevelId.NullText = "";
            this.repositoryItemGridLookUpEditUserLevelId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditUserLevelId.ValueMember = "UserLevelId";
            this.repositoryItemGridLookUpEditUserLevelId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserLevelName});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colUserLevelName
            // 
            this.colUserLevelName.AppearanceCell.Options.UseTextOptions = true;
            this.colUserLevelName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserLevelName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserLevelName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserLevelName.Caption = "المستوي";
            this.colUserLevelName.FieldName = "UserLevelName";
            this.colUserLevelName.Name = "colUserLevelName";
            this.colUserLevelName.Visible = true;
            this.colUserLevelName.VisibleIndex = 0;
            // 
            // repositoryItemMemoExEditUserPass
            // 
            this.repositoryItemMemoExEditUserPass.AutoHeight = false;
            this.repositoryItemMemoExEditUserPass.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditUserPass.Name = "repositoryItemMemoExEditUserPass";
            // 
            // repositoryItemCheckEditIsActive
            // 
            this.repositoryItemCheckEditIsActive.AutoHeight = false;
            this.repositoryItemCheckEditIsActive.Name = "repositoryItemCheckEditIsActive";
            // 
            // DeletedItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 361);
            this.Controls.Add(this.gridControlData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletedItemFrm";
            this.Text = "الملفات المحزوفة";
            this.Load += new System.EventHandler(this.FileTypeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditTypeIconData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditUserLevelId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditUserPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditIsActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditUserLevelId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditUserPass;
        private DevExpress.XtraGrid.Columns.GridColumn colUserLevelName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditIsActive;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeIconData;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditTypeIconData;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastRealName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}