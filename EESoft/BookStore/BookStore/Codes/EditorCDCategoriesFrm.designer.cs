namespace BookStore
{
    partial class EditorCDCategoriesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorCDCategoriesFrm));
            this.TLCat = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumnalsofof_code = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemGridLookUpEditalsofof_code = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeListColumnCategory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemButtonEditCategoryId = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.treeListColumnCategoryId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnparentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MyimageList = new System.Windows.Forms.ImageList(this.components);
            this.MycontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TLCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditalsofof_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditCategoryId)).BeginInit();
            this.MycontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLCat
            // 
            this.TLCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLCat.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumnalsofof_code,
            this.treeListColumnCategory,
            this.treeListColumnCategoryId,
            this.treeListColumnparentID});
            this.TLCat.ColumnsImageList = this.MyimageList;
            this.TLCat.ContextMenuStrip = this.MycontextMenuStrip;
            this.TLCat.CustomizationFormBounds = new System.Drawing.Rectangle(1150, 437, 216, 178);
            this.TLCat.Location = new System.Drawing.Point(12, 12);
            this.TLCat.Name = "TLCat";
            this.TLCat.OptionsBehavior.AllowIncrementalSearch = true;
            this.TLCat.OptionsBehavior.AutoFocusNewNode = true;
            this.TLCat.OptionsBehavior.EnableFiltering = true;
            this.TLCat.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.TLCat.OptionsBehavior.PopulateServiceColumns = true;
            this.TLCat.OptionsView.AutoWidth = false;
            this.TLCat.OptionsView.EnableAppearanceEvenRow = true;
            this.TLCat.OptionsView.EnableAppearanceOddRow = true;
            this.TLCat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditCategoryId,
            this.repositoryItemGridLookUpEditalsofof_code});
            this.TLCat.SelectImageList = this.MyimageList;
            this.TLCat.Size = new System.Drawing.Size(559, 266);
            this.TLCat.StateImageList = this.MyimageList;
            this.TLCat.TabIndex = 0;
            this.TLCat.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Solid;
            // 
            // treeListColumnalsofof_code
            // 
            this.treeListColumnalsofof_code.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumnalsofof_code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumnalsofof_code.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumnalsofof_code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumnalsofof_code.Caption = "الصف";
            this.treeListColumnalsofof_code.ColumnEdit = this.repositoryItemGridLookUpEditalsofof_code;
            this.treeListColumnalsofof_code.FieldName = "alsofof_code";
            this.treeListColumnalsofof_code.MinWidth = 49;
            this.treeListColumnalsofof_code.Name = "treeListColumnalsofof_code";
            this.treeListColumnalsofof_code.Visible = true;
            this.treeListColumnalsofof_code.VisibleIndex = 0;
            this.treeListColumnalsofof_code.Width = 157;
            // 
            // repositoryItemGridLookUpEditalsofof_code
            // 
            this.repositoryItemGridLookUpEditalsofof_code.AutoHeight = false;
            this.repositoryItemGridLookUpEditalsofof_code.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditalsofof_code.DisplayMember = "alsofof_NAME";
            this.repositoryItemGridLookUpEditalsofof_code.Name = "repositoryItemGridLookUpEditalsofof_code";
            this.repositoryItemGridLookUpEditalsofof_code.NullText = "";
            this.repositoryItemGridLookUpEditalsofof_code.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditalsofof_code.ValueMember = "alsofof_code";
            this.repositoryItemGridLookUpEditalsofof_code.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "الاسم";
            this.gridColumn2.FieldName = "alsofof_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // treeListColumnCategory
            // 
            this.treeListColumnCategory.Caption = "اسم التصنيف";
            this.treeListColumnCategory.ColumnEdit = this.repositoryItemButtonEditCategoryId;
            this.treeListColumnCategory.FieldName = "Category";
            this.treeListColumnCategory.ImageIndex = 0;
            this.treeListColumnCategory.MinWidth = 49;
            this.treeListColumnCategory.Name = "treeListColumnCategory";
            this.treeListColumnCategory.Visible = true;
            this.treeListColumnCategory.VisibleIndex = 1;
            this.treeListColumnCategory.Width = 209;
            // 
            // repositoryItemButtonEditCategoryId
            // 
            this.repositoryItemButtonEditCategoryId.AutoHeight = false;
            this.repositoryItemButtonEditCategoryId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditCategoryId.Name = "repositoryItemButtonEditCategoryId";
            this.repositoryItemButtonEditCategoryId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditCategory_ButtonClick);
            // 
            // treeListColumnCategoryId
            // 
            this.treeListColumnCategoryId.Caption = "رقم التصنيف";
            this.treeListColumnCategoryId.FieldName = "CategoryId";
            this.treeListColumnCategoryId.Name = "treeListColumnCategoryId";
            this.treeListColumnCategoryId.OptionsColumn.AllowEdit = false;
            this.treeListColumnCategoryId.OptionsColumn.ReadOnly = true;
            // 
            // treeListColumnparentID
            // 
            this.treeListColumnparentID.Caption = "رقم الاب";
            this.treeListColumnparentID.FieldName = "parentID";
            this.treeListColumnparentID.Name = "treeListColumnparentID";
            this.treeListColumnparentID.OptionsColumn.AllowEdit = false;
            this.treeListColumnparentID.OptionsColumn.ReadOnly = true;
            // 
            // MyimageList
            // 
            this.MyimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyimageList.ImageStream")));
            this.MyimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MyimageList.Images.SetKeyName(0, "Folders.png");
            // 
            // MycontextMenuStrip
            // 
            this.MycontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.newRootToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.MycontextMenuStrip.Name = "MycontextMenuStrip";
            this.MycontextMenuStrip.Size = new System.Drawing.Size(184, 70);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Image = global::BookStore.Properties.Resources.UpgradeReport_Plus;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addNewToolStripMenuItem.Text = "اضف تصنيف";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // newRootToolStripMenuItem
            // 
            this.newRootToolStripMenuItem.Image = global::BookStore.Properties.Resources.plus;
            this.newRootToolStripMenuItem.Name = "newRootToolStripMenuItem";
            this.newRootToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newRootToolStripMenuItem.Text = "اضافة تصنيف عمومي";
            this.newRootToolStripMenuItem.Click += new System.EventHandler(this.newRootToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Image = global::BookStore.Properties.Resources.DeleteTGrid;
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteItemToolStripMenuItem.Text = "حذف التصنيف";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "alsofof_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // EditorCDCategoriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 290);
            this.Controls.Add(this.TLCat);
            this.Name = "EditorCDCategoriesFrm";
            this.Text = "بيانات التصنيف";
            this.Load += new System.EventHandler(this.EditorCDCategoriesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TLCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditalsofof_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditCategoryId)).EndInit();
            this.MycontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList TLCat;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnCategoryId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnCategory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnparentID;
        private System.Windows.Forms.ImageList MyimageList;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditCategoryId;
        private System.Windows.Forms.ContextMenuStrip MycontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRootToolStripMenuItem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnalsofof_code;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditalsofof_code;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}