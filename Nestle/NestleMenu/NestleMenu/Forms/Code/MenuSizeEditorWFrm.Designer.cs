namespace NestleMenu.Forms.Code
{
    partial class MenuSizeEditorWFrm
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
            this.MenuSizeNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MenuSizeLogoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.MenuSizeDescriptionMemoExEdit = new DevExpress.XtraEditors.MemoEdit();
            this.menuSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNU = new NestleMenu.DataSources.dsNU();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForMenuSizeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMenuSizeDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMenuSizeLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.menuSizeTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.MenuSizeTableAdapter();
            this.DisabledCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForDisabled = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSizeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSizeLogoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSizeDescriptionMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuSizeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuSizeDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuSizeLogo)).BeginInit();
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
            this.dataLayoutControlMain.Controls.Add(this.MenuSizeNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.MenuSizeLogoPictureEdit);
            this.dataLayoutControlMain.Controls.Add(this.MenuSizeDescriptionMemoExEdit);
            this.dataLayoutControlMain.Controls.Add(this.DisabledCheckEdit);
            this.dataLayoutControlMain.DataSource = this.menuSizeBindingSource;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(736, 125, 412, 525);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 259);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::NestleMenu.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 225);
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
            this.btnCancel.Location = new System.Drawing.Point(260, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // MenuSizeNameTextEdit
            // 
            this.MenuSizeNameTextEdit.Location = new System.Drawing.Point(119, 12);
            this.MenuSizeNameTextEdit.Name = "MenuSizeNameTextEdit";
            this.MenuSizeNameTextEdit.Size = new System.Drawing.Size(279, 20);
            this.MenuSizeNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.MenuSizeNameTextEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Please Enter Menu Size Name";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderEditor.SetValidationRule(this.MenuSizeNameTextEdit, conditionValidationRule1);
            // 
            // MenuSizeLogoPictureEdit
            // 
            this.MenuSizeLogoPictureEdit.Location = new System.Drawing.Point(119, 36);
            this.MenuSizeLogoPictureEdit.Name = "MenuSizeLogoPictureEdit";
            this.MenuSizeLogoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.MenuSizeLogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.MenuSizeLogoPictureEdit.Size = new System.Drawing.Size(279, 58);
            this.MenuSizeLogoPictureEdit.StyleController = this.dataLayoutControlMain;
            this.MenuSizeLogoPictureEdit.TabIndex = 1;
            // 
            // MenuSizeDescriptionMemoExEdit
            // 
            this.MenuSizeDescriptionMemoExEdit.Location = new System.Drawing.Point(119, 98);
            this.MenuSizeDescriptionMemoExEdit.Name = "MenuSizeDescriptionMemoExEdit";
            this.MenuSizeDescriptionMemoExEdit.Size = new System.Drawing.Size(279, 88);
            this.MenuSizeDescriptionMemoExEdit.StyleController = this.dataLayoutControlMain;
            this.MenuSizeDescriptionMemoExEdit.TabIndex = 2;
            this.MenuSizeDescriptionMemoExEdit.UseOptimizedRendering = true;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 259);
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
            this.ItemForMenuSizeName,
            this.ItemForMenuSizeDescription,
            this.ItemForMenuSizeLogo,
            this.ItemForDisabled});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 239);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 213);
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
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 213);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 178);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 12);
            this.emptySpaceItem1.Text = "empty Space Item Last";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForMenuSizeName
            // 
            this.ItemForMenuSizeName.Control = this.MenuSizeNameTextEdit;
            this.ItemForMenuSizeName.CustomizationFormText = "Menu Size Name";
            this.ItemForMenuSizeName.Location = new System.Drawing.Point(0, 0);
            this.ItemForMenuSizeName.Name = "ItemForMenuSizeName";
            this.ItemForMenuSizeName.Size = new System.Drawing.Size(390, 24);
            this.ItemForMenuSizeName.Text = "Menu Size Name";
            this.ItemForMenuSizeName.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForMenuSizeDescription
            // 
            this.ItemForMenuSizeDescription.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForMenuSizeDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForMenuSizeDescription.Control = this.MenuSizeDescriptionMemoExEdit;
            this.ItemForMenuSizeDescription.CustomizationFormText = "Menu Size Description";
            this.ItemForMenuSizeDescription.Location = new System.Drawing.Point(0, 86);
            this.ItemForMenuSizeDescription.Name = "ItemForMenuSizeDescription";
            this.ItemForMenuSizeDescription.Size = new System.Drawing.Size(390, 92);
            this.ItemForMenuSizeDescription.Text = "Menu Size Description";
            this.ItemForMenuSizeDescription.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForMenuSizeLogo
            // 
            this.ItemForMenuSizeLogo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForMenuSizeLogo.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForMenuSizeLogo.Control = this.MenuSizeLogoPictureEdit;
            this.ItemForMenuSizeLogo.CustomizationFormText = "Menu Size Logo";
            this.ItemForMenuSizeLogo.Location = new System.Drawing.Point(0, 24);
            this.ItemForMenuSizeLogo.Name = "ItemForMenuSizeLogo";
            this.ItemForMenuSizeLogo.Size = new System.Drawing.Size(390, 62);
            this.ItemForMenuSizeLogo.Text = "Menu Size Logo";
            this.ItemForMenuSizeLogo.TextSize = new System.Drawing.Size(104, 13);
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
            this.DisabledCheckEdit.Location = new System.Drawing.Point(12, 202);
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
            this.ItemForDisabled.Location = new System.Drawing.Point(0, 190);
            this.ItemForDisabled.Name = "ItemForDisabled";
            this.ItemForDisabled.Size = new System.Drawing.Size(390, 23);
            this.ItemForDisabled.Text = "Disabled";
            this.ItemForDisabled.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDisabled.TextToControlDistance = 0;
            this.ItemForDisabled.TextVisible = false;
            // 
            // MenuSizeEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 259);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::NestleMenu.Properties.Resources.MenuSize;
            this.Name = "MenuSizeEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.JobEditorWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSizeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSizeLogoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSizeDescriptionMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuSizeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuSizeDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuSizeLogo)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit MenuSizeNameTextEdit;
        private DevExpress.XtraEditors.PictureEdit MenuSizeLogoPictureEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMenuSizeName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMenuSizeDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMenuSizeLogo;
        private DevExpress.XtraEditors.MemoEdit MenuSizeDescriptionMemoExEdit;
        private DevExpress.XtraEditors.CheckEdit DisabledCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDisabled;
    }
}