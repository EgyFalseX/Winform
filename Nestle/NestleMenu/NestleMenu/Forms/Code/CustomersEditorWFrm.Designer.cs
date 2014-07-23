namespace NestleMenu.Forms.Code
{
    partial class CustomersEditorWFrm
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
            this.CustomerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerLogoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.CustomerPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerMobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerEmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNU = new NestleMenu.DataSources.dsNU();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForCustomerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMenuSizeLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomerPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomerMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomerEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLogoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuSizeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.CustomerNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.CustomerLogoPictureEdit);
            this.dataLayoutControlMain.Controls.Add(this.CustomerPhoneTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.CustomerMobileTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.CustomerEmailTextEdit);
            this.dataLayoutControlMain.DataSource = this.customersBindingSource;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(745, 205, 250, 350);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 269);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::NestleMenu.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 235);
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
            this.btnCancel.Location = new System.Drawing.Point(260, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // CustomerNameTextEdit
            // 
            this.CustomerNameTextEdit.Location = new System.Drawing.Point(94, 12);
            this.CustomerNameTextEdit.Name = "CustomerNameTextEdit";
            this.CustomerNameTextEdit.Size = new System.Drawing.Size(304, 20);
            this.CustomerNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.CustomerNameTextEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Please Enter Menu Size Name";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderEditor.SetValidationRule(this.CustomerNameTextEdit, conditionValidationRule1);
            // 
            // CustomerLogoPictureEdit
            // 
            this.CustomerLogoPictureEdit.Location = new System.Drawing.Point(94, 108);
            this.CustomerLogoPictureEdit.Name = "CustomerLogoPictureEdit";
            this.CustomerLogoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.CustomerLogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.CustomerLogoPictureEdit.Size = new System.Drawing.Size(304, 88);
            this.CustomerLogoPictureEdit.StyleController = this.dataLayoutControlMain;
            this.CustomerLogoPictureEdit.TabIndex = 4;
            // 
            // CustomerPhoneTextEdit
            // 
            this.CustomerPhoneTextEdit.Location = new System.Drawing.Point(94, 36);
            this.CustomerPhoneTextEdit.Name = "CustomerPhoneTextEdit";
            this.CustomerPhoneTextEdit.Size = new System.Drawing.Size(304, 20);
            this.CustomerPhoneTextEdit.StyleController = this.dataLayoutControlMain;
            this.CustomerPhoneTextEdit.TabIndex = 1;
            // 
            // CustomerMobileTextEdit
            // 
            this.CustomerMobileTextEdit.Location = new System.Drawing.Point(94, 60);
            this.CustomerMobileTextEdit.Name = "CustomerMobileTextEdit";
            this.CustomerMobileTextEdit.Size = new System.Drawing.Size(304, 20);
            this.CustomerMobileTextEdit.StyleController = this.dataLayoutControlMain;
            this.CustomerMobileTextEdit.TabIndex = 2;
            // 
            // CustomerEmailTextEdit
            // 
            this.CustomerEmailTextEdit.Location = new System.Drawing.Point(94, 84);
            this.CustomerEmailTextEdit.Name = "CustomerEmailTextEdit";
            this.CustomerEmailTextEdit.Size = new System.Drawing.Size(304, 20);
            this.CustomerEmailTextEdit.StyleController = this.dataLayoutControlMain;
            this.CustomerEmailTextEdit.TabIndex = 3;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dsNU;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 269);
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
            this.ItemForCustomerName,
            this.ItemForMenuSizeLogo,
            this.ItemForCustomerPhone,
            this.ItemForCustomerMobile,
            this.ItemForCustomerEmail});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 249);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 223);
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
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 223);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 188);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 35);
            this.emptySpaceItem1.Text = "empty Space Item Last";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForCustomerName
            // 
            this.ItemForCustomerName.Control = this.CustomerNameTextEdit;
            this.ItemForCustomerName.CustomizationFormText = "Customer Name";
            this.ItemForCustomerName.Location = new System.Drawing.Point(0, 0);
            this.ItemForCustomerName.Name = "ItemForCustomerName";
            this.ItemForCustomerName.Size = new System.Drawing.Size(390, 24);
            this.ItemForCustomerName.Text = "Customer Name";
            this.ItemForCustomerName.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForMenuSizeLogo
            // 
            this.ItemForMenuSizeLogo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForMenuSizeLogo.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForMenuSizeLogo.Control = this.CustomerLogoPictureEdit;
            this.ItemForMenuSizeLogo.CustomizationFormText = "Menu Size Logo";
            this.ItemForMenuSizeLogo.Location = new System.Drawing.Point(0, 96);
            this.ItemForMenuSizeLogo.Name = "ItemForMenuSizeLogo";
            this.ItemForMenuSizeLogo.Size = new System.Drawing.Size(390, 92);
            this.ItemForMenuSizeLogo.Text = "Menu Size Logo";
            this.ItemForMenuSizeLogo.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForCustomerPhone
            // 
            this.ItemForCustomerPhone.Control = this.CustomerPhoneTextEdit;
            this.ItemForCustomerPhone.CustomizationFormText = "Customer Phone";
            this.ItemForCustomerPhone.Location = new System.Drawing.Point(0, 24);
            this.ItemForCustomerPhone.Name = "ItemForCustomerPhone";
            this.ItemForCustomerPhone.Size = new System.Drawing.Size(390, 24);
            this.ItemForCustomerPhone.Text = "Customer Phone";
            this.ItemForCustomerPhone.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForCustomerMobile
            // 
            this.ItemForCustomerMobile.Control = this.CustomerMobileTextEdit;
            this.ItemForCustomerMobile.CustomizationFormText = "Customer Mobile";
            this.ItemForCustomerMobile.Location = new System.Drawing.Point(0, 48);
            this.ItemForCustomerMobile.Name = "ItemForCustomerMobile";
            this.ItemForCustomerMobile.Size = new System.Drawing.Size(390, 24);
            this.ItemForCustomerMobile.Text = "Customer Mobile";
            this.ItemForCustomerMobile.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForCustomerEmail
            // 
            this.ItemForCustomerEmail.Control = this.CustomerEmailTextEdit;
            this.ItemForCustomerEmail.CustomizationFormText = "Customer Email";
            this.ItemForCustomerEmail.Location = new System.Drawing.Point(0, 72);
            this.ItemForCustomerEmail.Name = "ItemForCustomerEmail";
            this.ItemForCustomerEmail.Size = new System.Drawing.Size(390, 24);
            this.ItemForCustomerEmail.Text = "Customer Email";
            this.ItemForCustomerEmail.TextSize = new System.Drawing.Size(79, 13);
            // 
            // CustomersEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 269);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::NestleMenu.Properties.Resources.Customers;
            this.Name = "CustomersEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.JobEditorWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLogoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMenuSizeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerEmail)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit CustomerNameTextEdit;
        private DevExpress.XtraEditors.PictureEdit CustomerLogoPictureEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMenuSizeLogo;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DevExpress.XtraEditors.TextEdit CustomerPhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit CustomerMobileTextEdit;
        private DevExpress.XtraEditors.TextEdit CustomerEmailTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerEmail;
    }
}