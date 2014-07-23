namespace NestleMenu.Forms.Code
{
    partial class MenuThemeEditorWFrm
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
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.MenuThemeNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MenuThemeLogoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.MenuThemeDescriptionMemoExEdit = new DevExpress.XtraEditors.MemoEdit();
            this.menuSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNU = new NestleMenu.DataSources.dsNU();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForMenuThemeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMenuThemeDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMenuThemeLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.menuSizeTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.MenuSizeTableAdapter();
            this.DisabledCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForDisabled = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuThemeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuThemeLogoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuThemeDescriptionMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuThemeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuThemeDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuThemeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabledCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisabled)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.MenuThemeNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.MenuThemeLogoPictureEdit);
            this.dataLayoutControlMain.Controls.Add(this.MenuThemeDescriptionMemoExEdit);
            this.dataLayoutControlMain.Controls.Add(this.DisabledCheckEdit);
            this.dataLayoutControlMain.DataSource = this.menuSizeBindingSource;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(728, 105, 395, 494);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 253);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::NestleMenu.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 22);
            this.btnSave.StyleController = this.dataLayoutControlMain;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::NestleMenu.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(260, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // MenuThemeNameTextEdit
            // 
            this.MenuThemeNameTextEdit.Location = new System.Drawing.Point(132, 12);
            this.MenuThemeNameTextEdit.Name = "MenuThemeNameTextEdit";
            this.MenuThemeNameTextEdit.Size = new System.Drawing.Size(266, 20);
            this.MenuThemeNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.MenuThemeNameTextEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Please Enter Menu Size Name";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderEditor.SetValidationRule(this.MenuThemeNameTextEdit, conditionValidationRule1);
            // 
            // MenuThemeLogoPictureEdit
            // 
            this.MenuThemeLogoPictureEdit.Location = new System.Drawing.Point(132, 36);
            this.MenuThemeLogoPictureEdit.Name = "MenuThemeLogoPictureEdit";
            this.MenuThemeLogoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.MenuThemeLogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.MenuThemeLogoPictureEdit.Size = new System.Drawing.Size(266, 72);
            this.MenuThemeLogoPictureEdit.StyleController = this.dataLayoutControlMain;
            this.MenuThemeLogoPictureEdit.TabIndex = 1;
            // 
            // MenuThemeDescriptionMemoExEdit
            // 
            this.MenuThemeDescriptionMemoExEdit.Location = new System.Drawing.Point(132, 112);
            this.MenuThemeDescriptionMemoExEdit.Name = "MenuThemeDescriptionMemoExEdit";
            this.MenuThemeDescriptionMemoExEdit.Size = new System.Drawing.Size(266, 70);
            this.MenuThemeDescriptionMemoExEdit.StyleController = this.dataLayoutControlMain;
            this.MenuThemeDescriptionMemoExEdit.TabIndex = 2;
            this.MenuThemeDescriptionMemoExEdit.UseOptimizedRendering = true;
            // 
            // menuSizeBindingSource
            // 
            this.menuSizeBindingSource.DataMember = "MenuSize";
            this.menuSizeBindingSource.DataSource = this.dsNU;
            // 
            // dsNU
            // 
            this.dsNU.DataSetName = "dsNU";
            this.dsNU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 253);
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
            this.ItemForMenuThemeName,
            this.ItemForMenuThemeDescription,
            this.ItemForMenuThemeLogo,
            this.ItemForDisabled});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 233);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 207);
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
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 207);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 174);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 10);
            this.emptySpaceItem1.Text = "empty Space Item Last";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForMenuThemeName
            // 
            this.ItemForMenuThemeName.Control = this.MenuThemeNameTextEdit;
            this.ItemForMenuThemeName.CustomizationFormText = "Menu Theme Name";
            this.ItemForMenuThemeName.Location = new System.Drawing.Point(0, 0);
            this.ItemForMenuThemeName.Name = "ItemForMenuThemeName";
            this.ItemForMenuThemeName.Size = new System.Drawing.Size(390, 24);
            this.ItemForMenuThemeName.Text = "Menu Theme Name";
            this.ItemForMenuThemeName.TextSize = new System.Drawing.Size(117, 13);
            // 
            // ItemForMenuThemeDescription
            // 
            this.ItemForMenuThemeDescription.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForMenuThemeDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForMenuThemeDescription.Control = this.MenuThemeDescriptionMemoExEdit;
            this.ItemForMenuThemeDescription.CustomizationFormText = "Menu Theme Description";
            this.ItemForMenuThemeDescription.Location = new System.Drawing.Point(0, 100);
            this.ItemForMenuThemeDescription.Name = "ItemForMenuThemeDescription";
            this.ItemForMenuThemeDescription.Size = new System.Drawing.Size(390, 74);
            this.ItemForMenuThemeDescription.Text = "Menu Theme Description";
            this.ItemForMenuThemeDescription.TextSize = new System.Drawing.Size(117, 13);
            // 
            // ItemForMenuThemeLogo
            // 
            this.ItemForMenuThemeLogo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForMenuThemeLogo.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForMenuThemeLogo.Control = this.MenuThemeLogoPictureEdit;
            this.ItemForMenuThemeLogo.CustomizationFormText = "Menu Theme Logo";
            this.ItemForMenuThemeLogo.Location = new System.Drawing.Point(0, 24);
            this.ItemForMenuThemeLogo.Name = "ItemForMenuThemeLogo";
            this.ItemForMenuThemeLogo.Size = new System.Drawing.Size(390, 76);
            this.ItemForMenuThemeLogo.Text = "Menu Theme Logo";
            this.ItemForMenuThemeLogo.TextSize = new System.Drawing.Size(117, 13);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.dsNU;
            // 
            // menuSizeTableAdapter
            // 
            this.menuSizeTableAdapter.ClearBeforeFill = true;
            // 
            // DisabledCheckEdit
            // 
            this.DisabledCheckEdit.Location = new System.Drawing.Point(12, 196);
            this.DisabledCheckEdit.Name = "DisabledCheckEdit";
            this.DisabledCheckEdit.Properties.Caption = "Disabled";
            this.DisabledCheckEdit.Size = new System.Drawing.Size(386, 19);
            this.DisabledCheckEdit.StyleController = this.dataLayoutControlMain;
            this.DisabledCheckEdit.TabIndex = 3;
            // 
            // ItemForDisabled
            // 
            this.ItemForDisabled.Control = this.DisabledCheckEdit;
            this.ItemForDisabled.CustomizationFormText = "Disabled";
            this.ItemForDisabled.Location = new System.Drawing.Point(0, 184);
            this.ItemForDisabled.Name = "ItemForDisabled";
            this.ItemForDisabled.Size = new System.Drawing.Size(390, 23);
            this.ItemForDisabled.Text = "Disabled";
            this.ItemForDisabled.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDisabled.TextToControlDistance = 0;
            this.ItemForDisabled.TextVisible = false;
            // 
            // MenuThemeEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 253);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::NestleMenu.Properties.Resources.MenuTheme;
            this.Name = "MenuThemeEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.JobEditorWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuThemeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuThemeLogoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuThemeDescriptionMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuThemeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuThemeDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuThemeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabledCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisabled)).EndInit();
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
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.BindingSource menuSizeBindingSource;
        private DataSources.dsNUTableAdapters.MenuSizeTableAdapter menuSizeTableAdapter;
        private DevExpress.XtraEditors.TextEdit MenuThemeNameTextEdit;
        private DevExpress.XtraEditors.PictureEdit MenuThemeLogoPictureEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMenuThemeName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMenuThemeDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMenuThemeLogo;
        private DevExpress.XtraEditors.MemoEdit MenuThemeDescriptionMemoExEdit;
        private DevExpress.XtraEditors.CheckEdit DisabledCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDisabled;
    }
}