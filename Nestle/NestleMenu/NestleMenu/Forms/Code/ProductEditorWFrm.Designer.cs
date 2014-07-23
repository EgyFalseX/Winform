namespace NestleMenu.Forms.Code
{
    partial class ProductEditorWFrm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ProductBaseIdGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.productBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNU = new NestleMenu.DataSources.dsNU();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductBaseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.DisabledCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ProductImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProductBaseId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDisabled = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProductImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.productTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.ProductTableAdapter();
            this.productBaseTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.ProductBaseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBaseIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabledCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductBaseId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.ProductBaseIdGridLookUpEdit);
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.ProductNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.DescriptionMemoEdit);
            this.dataLayoutControlMain.Controls.Add(this.DisabledCheckEdit);
            this.dataLayoutControlMain.Controls.Add(this.ProductImagePictureEdit);
            this.dataLayoutControlMain.DataSource = this.productBindingSource;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(768, 28, 379, 506);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 323);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // ProductBaseIdGridLookUpEdit
            // 
            this.ProductBaseIdGridLookUpEdit.Location = new System.Drawing.Point(108, 36);
            this.ProductBaseIdGridLookUpEdit.Name = "ProductBaseIdGridLookUpEdit";
            this.ProductBaseIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProductBaseIdGridLookUpEdit.Properties.DataSource = this.productBaseBindingSource;
            this.ProductBaseIdGridLookUpEdit.Properties.DisplayMember = "ProductBaseName";
            this.ProductBaseIdGridLookUpEdit.Properties.NullText = "";
            this.ProductBaseIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ProductBaseIdGridLookUpEdit.Properties.ValueMember = "ProductBaseId";
            this.ProductBaseIdGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.ProductBaseIdGridLookUpEdit.Size = new System.Drawing.Size(290, 20);
            this.ProductBaseIdGridLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.ProductBaseIdGridLookUpEdit.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Please Enter Product Base Name";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderEditor.SetValidationRule(this.ProductBaseIdGridLookUpEdit, conditionValidationRule1);
            // 
            // productBaseBindingSource
            // 
            this.productBaseBindingSource.DataMember = "ProductBase";
            this.productBaseBindingSource.DataSource = this.dsNU;
            // 
            // dsNU
            // 
            this.dsNU.DataSetName = "dsNU";
            this.dsNU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductBaseName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colProductBaseName
            // 
            this.colProductBaseName.FieldName = "ProductBaseName";
            this.colProductBaseName.Name = "colProductBaseName";
            this.colProductBaseName.Visible = true;
            this.colProductBaseName.VisibleIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::NestleMenu.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 22);
            this.btnSave.StyleController = this.dataLayoutControlMain;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::NestleMenu.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(260, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // ProductNameTextEdit
            // 
            this.ProductNameTextEdit.Location = new System.Drawing.Point(108, 12);
            this.ProductNameTextEdit.Name = "ProductNameTextEdit";
            this.ProductNameTextEdit.Size = new System.Drawing.Size(290, 20);
            this.ProductNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.ProductNameTextEdit.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Please Enter Product Name";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderEditor.SetValidationRule(this.ProductNameTextEdit, conditionValidationRule2);
            // 
            // DescriptionMemoEdit
            // 
            this.DescriptionMemoEdit.Location = new System.Drawing.Point(108, 143);
            this.DescriptionMemoEdit.Name = "DescriptionMemoEdit";
            this.DescriptionMemoEdit.Size = new System.Drawing.Size(290, 80);
            this.DescriptionMemoEdit.StyleController = this.dataLayoutControlMain;
            this.DescriptionMemoEdit.TabIndex = 3;
            this.DescriptionMemoEdit.UseOptimizedRendering = true;
            // 
            // DisabledCheckEdit
            // 
            this.DisabledCheckEdit.Location = new System.Drawing.Point(12, 266);
            this.DisabledCheckEdit.Name = "DisabledCheckEdit";
            this.DisabledCheckEdit.Properties.Caption = "Disabled";
            this.DisabledCheckEdit.Size = new System.Drawing.Size(386, 19);
            this.DisabledCheckEdit.StyleController = this.dataLayoutControlMain;
            this.DisabledCheckEdit.TabIndex = 4;
            // 
            // ProductImagePictureEdit
            // 
            this.ProductImagePictureEdit.Location = new System.Drawing.Point(108, 60);
            this.ProductImagePictureEdit.Name = "ProductImagePictureEdit";
            this.ProductImagePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.ProductImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ProductImagePictureEdit.Size = new System.Drawing.Size(290, 79);
            this.ProductImagePictureEdit.StyleController = this.dataLayoutControlMain;
            this.ProductImagePictureEdit.TabIndex = 2;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dsNU;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 323);
            this.layoutControlGroup1.Text = "Root";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemCancel,
            this.layoutControlItemSave,
            this.emptySpaceItem1,
            this.ItemForProductName,
            this.ItemForDescription,
            this.ItemForProductBaseId,
            this.ItemForDisabled,
            this.ItemForProductImage});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 303);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 277);
            this.layoutControlItemCancel.Name = "layoutControlItemCancel";
            this.layoutControlItemCancel.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItemCancel.Text = "layoutControlItemCancel";
            this.layoutControlItemCancel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCancel.TextToControlDistance = 0;
            this.layoutControlItemCancel.TextVisible = false;
            // 
            // layoutControlItemSave
            // 
            this.layoutControlItemSave.Control = this.btnSave;
            this.layoutControlItemSave.CustomizationFormText = "layoutControlItemSave";
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 277);
            this.layoutControlItemSave.Name = "layoutControlItemSave";
            this.layoutControlItemSave.Size = new System.Drawing.Size(248, 26);
            this.layoutControlItemSave.Text = "layoutControlItemSave";
            this.layoutControlItemSave.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSave.TextToControlDistance = 0;
            this.layoutControlItemSave.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItemLast";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 215);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 39);
            this.emptySpaceItem1.Text = "empty Space Item Last";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForProductName
            // 
            this.ItemForProductName.Control = this.ProductNameTextEdit;
            this.ItemForProductName.CustomizationFormText = "Product Name";
            this.ItemForProductName.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductName.Name = "ItemForProductName";
            this.ItemForProductName.Size = new System.Drawing.Size(390, 24);
            this.ItemForProductName.Text = "Product Name";
            this.ItemForProductName.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForDescription.Control = this.DescriptionMemoEdit;
            this.ItemForDescription.CustomizationFormText = "Description";
            this.ItemForDescription.Location = new System.Drawing.Point(0, 131);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(390, 84);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForProductBaseId
            // 
            this.ItemForProductBaseId.Control = this.ProductBaseIdGridLookUpEdit;
            this.ItemForProductBaseId.CustomizationFormText = "Product Base Id";
            this.ItemForProductBaseId.Location = new System.Drawing.Point(0, 24);
            this.ItemForProductBaseId.Name = "ItemForProductBaseId";
            this.ItemForProductBaseId.Size = new System.Drawing.Size(390, 24);
            this.ItemForProductBaseId.Text = "Product Base Name";
            this.ItemForProductBaseId.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForDisabled
            // 
            this.ItemForDisabled.Control = this.DisabledCheckEdit;
            this.ItemForDisabled.CustomizationFormText = "Disabled";
            this.ItemForDisabled.Location = new System.Drawing.Point(0, 254);
            this.ItemForDisabled.Name = "ItemForDisabled";
            this.ItemForDisabled.Size = new System.Drawing.Size(390, 23);
            this.ItemForDisabled.Text = "Disabled";
            this.ItemForDisabled.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDisabled.TextToControlDistance = 0;
            this.ItemForDisabled.TextVisible = false;
            // 
            // ItemForProductImage
            // 
            this.ItemForProductImage.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForProductImage.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForProductImage.Control = this.ProductImagePictureEdit;
            this.ItemForProductImage.CustomizationFormText = "Product Image";
            this.ItemForProductImage.Location = new System.Drawing.Point(0, 48);
            this.ItemForProductImage.Name = "ItemForProductImage";
            this.ItemForProductImage.Size = new System.Drawing.Size(390, 83);
            this.ItemForProductImage.Text = "Product Image";
            this.ItemForProductImage.TextSize = new System.Drawing.Size(93, 13);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBaseTableAdapter
            // 
            this.productBaseTableAdapter.ClearBeforeFill = true;
            // 
            // ProductEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 323);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::NestleMenu.Properties.Resources.ProductEditor;
            this.Name = "ProductEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.AreaEditorWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBaseIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabledCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductBaseId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSources.dsNU dsNU;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSave;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderEditor;
        private DevExpress.XtraEditors.GridLookUpEdit ProductBaseIdGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.MemoEdit DescriptionMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductBaseId;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DataSources.dsNUTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBaseBindingSource;
        private DataSources.dsNUTableAdapters.ProductBaseTableAdapter productBaseTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colProductBaseName;
        private DevExpress.XtraEditors.CheckEdit DisabledCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDisabled;
        private DevExpress.XtraEditors.PictureEdit ProductImagePictureEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductImage;
    }
}