namespace schoolStore
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
            this.treeListColumnCategory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemButtonEditCategoryId = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.treeListColumnCategoryId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnparentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MyimageList = new System.Windows.Forms.ImageList(this.components);
            this.MycontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TLCat)).BeginInit();
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
            this.treeListColumnCategory,
            this.treeListColumnCategoryId,
            this.treeListColumnparentID});
            this.TLCat.ColumnsImageList = this.MyimageList;
            this.TLCat.ContextMenuStrip = this.MycontextMenuStrip;
            this.TLCat.CustomizationFormBounds = new System.Drawing.Rectangle(1575, 1149, 216, 178);
            this.TLCat.Location = new System.Drawing.Point(12, 12);
            this.TLCat.Name = "TLCat";
            this.TLCat.OptionsBehavior.AllowIncrementalSearch = true;
            this.TLCat.OptionsBehavior.AutoFocusNewNode = true;
            this.TLCat.OptionsBehavior.EnableFiltering = true;
            this.TLCat.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.TLCat.OptionsBehavior.PopulateServiceColumns = true;
            this.TLCat.OptionsView.EnableAppearanceEvenRow = true;
            this.TLCat.OptionsView.EnableAppearanceOddRow = true;
            this.TLCat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditCategoryId});
            this.TLCat.SelectImageList = this.MyimageList;
            this.TLCat.Size = new System.Drawing.Size(559, 266);
            this.TLCat.StateImageList = this.MyimageList;
            this.TLCat.TabIndex = 0;
            this.TLCat.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Solid;
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
            this.treeListColumnCategory.VisibleIndex = 0;
            this.treeListColumnCategory.Width = 186;
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
            this.MycontextMenuStrip.Size = new System.Drawing.Size(171, 92);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Image = global::schoolStore.Properties.Resources.UpgradeReport_Plus;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addNewToolStripMenuItem.Text = "اضف تصنيف";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // newRootToolStripMenuItem
            // 
            this.newRootToolStripMenuItem.Image = global::schoolStore.Properties.Resources.plus;
            this.newRootToolStripMenuItem.Name = "newRootToolStripMenuItem";
            this.newRootToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.newRootToolStripMenuItem.Text = "اضافة تصنيف عمومي";
            this.newRootToolStripMenuItem.Click += new System.EventHandler(this.newRootToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Image = global::schoolStore.Properties.Resources.DeleteTGrid;
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deleteItemToolStripMenuItem.Text = "حذف التصنيف";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
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
    }
}