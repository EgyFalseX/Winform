namespace schoolStore
{
    partial class DataTblPricelistsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTblPricelistsFrm));
            this.gridViewAdd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCSanfID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCpriceout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditpriceout = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.GCOldpriceout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCAddSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditAddSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.trackBarPrice = new DevExpress.XtraEditors.TrackBarControl();
            this.BtnSaveAll = new DevExpress.XtraEditors.SimpleButton();
            this.TVAddCat = new System.Windows.Forms.TreeView();
            this.MyimageList = new System.Windows.Forms.ImageList(this.components);
            this.BtnSaveCat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditpriceout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditAddSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAdd
            // 
            this.gridViewAdd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCSanfID,
            this.GCpriceout,
            this.GCOldpriceout,
            this.GCAddSave});
            this.gridViewAdd.GridControl = this.gridControlMain;
            this.gridViewAdd.Name = "gridViewAdd";
            // 
            // GCSanfID
            // 
            this.GCSanfID.AppearanceCell.Options.UseTextOptions = true;
            this.GCSanfID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSanfID.AppearanceHeader.Options.UseTextOptions = true;
            this.GCSanfID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSanfID.Caption = "اسم الصنف";
            this.GCSanfID.FieldName = "SanfName";
            this.GCSanfID.Name = "GCSanfID";
            this.GCSanfID.OptionsColumn.AllowEdit = false;
            this.GCSanfID.OptionsColumn.ReadOnly = true;
            this.GCSanfID.Visible = true;
            this.GCSanfID.VisibleIndex = 3;
            this.GCSanfID.Width = 151;
            // 
            // GCpriceout
            // 
            this.GCpriceout.AppearanceCell.Options.UseTextOptions = true;
            this.GCpriceout.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCpriceout.AppearanceHeader.Options.UseTextOptions = true;
            this.GCpriceout.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCpriceout.Caption = "سعر البيع";
            this.GCpriceout.ColumnEdit = this.repositoryItemCalcEditpriceout;
            this.GCpriceout.FieldName = "priceout";
            this.GCpriceout.Name = "GCpriceout";
            this.GCpriceout.Visible = true;
            this.GCpriceout.VisibleIndex = 2;
            this.GCpriceout.Width = 60;
            // 
            // repositoryItemCalcEditpriceout
            // 
            this.repositoryItemCalcEditpriceout.AutoHeight = false;
            this.repositoryItemCalcEditpriceout.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditpriceout.DisplayFormat.FormatString = "n2";
            this.repositoryItemCalcEditpriceout.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditpriceout.EditFormat.FormatString = "n2";
            this.repositoryItemCalcEditpriceout.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditpriceout.Mask.EditMask = "n2";
            this.repositoryItemCalcEditpriceout.Name = "repositoryItemCalcEditpriceout";
            // 
            // GCOldpriceout
            // 
            this.GCOldpriceout.AppearanceCell.Options.UseTextOptions = true;
            this.GCOldpriceout.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOldpriceout.AppearanceHeader.Options.UseTextOptions = true;
            this.GCOldpriceout.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOldpriceout.Caption = "السعر السابق";
            this.GCOldpriceout.ColumnEdit = this.repositoryItemCalcEditpriceout;
            this.GCOldpriceout.FieldName = "Oldpriceout";
            this.GCOldpriceout.Name = "GCOldpriceout";
            this.GCOldpriceout.Visible = true;
            this.GCOldpriceout.VisibleIndex = 1;
            this.GCOldpriceout.Width = 73;
            // 
            // GCAddSave
            // 
            this.GCAddSave.AppearanceCell.Options.UseTextOptions = true;
            this.GCAddSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAddSave.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAddSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAddSave.Caption = "حفظ";
            this.GCAddSave.ColumnEdit = this.repositoryItemButtonEditAddSave;
            this.GCAddSave.Name = "GCAddSave";
            this.GCAddSave.Visible = true;
            this.GCAddSave.VisibleIndex = 0;
            this.GCAddSave.Width = 50;
            // 
            // repositoryItemButtonEditAddSave
            // 
            this.repositoryItemButtonEditAddSave.AutoHeight = false;
            this.repositoryItemButtonEditAddSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditAddSave.Name = "repositoryItemButtonEditAddSave";
            this.repositoryItemButtonEditAddSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditAddSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditAddSave_ButtonClick);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.Location = new System.Drawing.Point(232, 80);
            this.gridControlMain.MainView = this.gridViewAdd;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditAddSave,
            this.repositoryItemCalcEditpriceout});
            this.gridControlMain.Size = new System.Drawing.Size(352, 382);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAdd});
            // 
            // trackBarPrice
            // 
            this.trackBarPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarPrice.EditValue = 1;
            this.trackBarPrice.Location = new System.Drawing.Point(0, 0);
            this.trackBarPrice.Name = "trackBarPrice";
            this.trackBarPrice.Properties.Maximum = 100;
            this.trackBarPrice.Properties.Minimum = -100;
            this.trackBarPrice.Properties.ShowValueToolTip = true;
            this.trackBarPrice.Properties.UseParentBackground = true;
            this.trackBarPrice.Size = new System.Drawing.Size(584, 45);
            this.trackBarPrice.TabIndex = 0;
            this.trackBarPrice.Value = 1;
            // 
            // BtnSaveAll
            // 
            this.BtnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSaveAll.Location = new System.Drawing.Point(123, 42);
            this.BtnSaveAll.Name = "BtnSaveAll";
            this.BtnSaveAll.Size = new System.Drawing.Size(339, 23);
            this.BtnSaveAll.TabIndex = 6;
            this.BtnSaveAll.Text = "حفظ الكل";
            this.BtnSaveAll.Click += new System.EventHandler(this.BtnSaveAll_Click);
            // 
            // TVAddCat
            // 
            this.TVAddCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TVAddCat.ImageIndex = 0;
            this.TVAddCat.ImageList = this.MyimageList;
            this.TVAddCat.Location = new System.Drawing.Point(0, 109);
            this.TVAddCat.Name = "TVAddCat";
            this.TVAddCat.SelectedImageIndex = 2;
            this.TVAddCat.Size = new System.Drawing.Size(226, 353);
            this.TVAddCat.TabIndex = 9;
            this.TVAddCat.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVAddCat_AfterSelect);
            // 
            // MyimageList
            // 
            this.MyimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyimageList.ImageStream")));
            this.MyimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MyimageList.Images.SetKeyName(0, "Folders.png");
            this.MyimageList.Images.SetKeyName(1, "Material.png");
            this.MyimageList.Images.SetKeyName(2, "AddTGrid.png");
            // 
            // BtnSaveCat
            // 
            this.BtnSaveCat.Location = new System.Drawing.Point(0, 80);
            this.BtnSaveCat.Name = "BtnSaveCat";
            this.BtnSaveCat.Size = new System.Drawing.Size(226, 28);
            this.BtnSaveCat.TabIndex = 6;
            this.BtnSaveCat.Text = "حفظ التصنيف";
            this.BtnSaveCat.Click += new System.EventHandler(this.BtnSaveCat_Click);
            // 
            // DataTblPricelistsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.TVAddCat);
            this.Controls.Add(this.BtnSaveCat);
            this.Controls.Add(this.BtnSaveAll);
            this.Controls.Add(this.trackBarPrice);
            this.Controls.Add(this.gridControlMain);
            this.Name = "DataTblPricelistsFrm";
            this.Text = "قوائم الاسعار";
            this.Load += new System.EventHandler(this.DataTblPricelistsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditpriceout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditAddSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAdd;
        private DevExpress.XtraGrid.Columns.GridColumn GCSanfID;
        private DevExpress.XtraGrid.Columns.GridColumn GCpriceout;
        private DevExpress.XtraGrid.Columns.GridColumn GCAddSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditAddSave;
        private DevExpress.XtraEditors.TrackBarControl trackBarPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditpriceout;
        private DevExpress.XtraEditors.SimpleButton BtnSaveAll;
        private DevExpress.XtraGrid.Columns.GridColumn GCOldpriceout;
        private System.Windows.Forms.TreeView TVAddCat;
        private DevExpress.XtraEditors.SimpleButton BtnSaveCat;
        private System.Windows.Forms.ImageList MyimageList;
    }
}