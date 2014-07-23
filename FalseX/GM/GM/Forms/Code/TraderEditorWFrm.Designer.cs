namespace GM.Forms.Code
{
    partial class TraderEditorWFrm
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
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.AreaIdGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGM = new GM.DataSources.dsGM();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAreaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GovIdGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.govBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGovName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TraderNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TraderSiteNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TraderPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TraderMobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TraderAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForGovId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAreaId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTraderName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTraderSiteName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTraderPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTraderMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTraderAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.govTableAdapter = new GM.DataSources.dsGMTableAdapters.GovTableAdapter();
            this.areaTableAdapter = new GM.DataSources.dsGMTableAdapters.AreaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GovIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.govBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderSiteNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderMobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGovId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAreaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderSiteName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.AreaIdGridLookUpEdit);
            this.dataLayoutControlMain.Controls.Add(this.GovIdGridLookUpEdit);
            this.dataLayoutControlMain.Controls.Add(this.TraderNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.TraderSiteNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.TraderPhoneTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.TraderMobileTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.TraderAddressTextEdit);
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(745, 205, 250, 350);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 235);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::GM.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 201);
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
            this.btnCancel.Image = global::GM.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(260, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // AreaIdGridLookUpEdit
            // 
            this.AreaIdGridLookUpEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AreaIdGridLookUpEdit.EnterMoveNextControl = true;
            this.AreaIdGridLookUpEdit.Location = new System.Drawing.Point(98, 156);
            this.AreaIdGridLookUpEdit.Name = "AreaIdGridLookUpEdit";
            this.AreaIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AreaIdGridLookUpEdit.Properties.DataSource = this.areaBindingSource;
            this.AreaIdGridLookUpEdit.Properties.DisplayMember = "AreaName";
            this.AreaIdGridLookUpEdit.Properties.NullText = "";
            this.AreaIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.AreaIdGridLookUpEdit.Properties.ValueMember = "AreaId";
            this.AreaIdGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.AreaIdGridLookUpEdit.Size = new System.Drawing.Size(300, 20);
            this.AreaIdGridLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.AreaIdGridLookUpEdit.TabIndex = 4;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.dsGM;
            // 
            // dsGM
            // 
            this.dsGM.DataSetName = "dsGM";
            this.dsGM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAreaName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colAreaName
            // 
            this.colAreaName.AppearanceCell.Options.UseTextOptions = true;
            this.colAreaName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAreaName.AppearanceHeader.Options.UseTextOptions = true;
            this.colAreaName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAreaName.Caption = "Area Name";
            this.colAreaName.FieldName = "AreaName";
            this.colAreaName.Name = "colAreaName";
            this.colAreaName.Visible = true;
            this.colAreaName.VisibleIndex = 0;
            // 
            // GovIdGridLookUpEdit
            // 
            this.GovIdGridLookUpEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.GovIdGridLookUpEdit.EnterMoveNextControl = true;
            this.GovIdGridLookUpEdit.Location = new System.Drawing.Point(98, 132);
            this.GovIdGridLookUpEdit.Name = "GovIdGridLookUpEdit";
            this.GovIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GovIdGridLookUpEdit.Properties.DataSource = this.govBindingSource;
            this.GovIdGridLookUpEdit.Properties.DisplayMember = "GovName";
            this.GovIdGridLookUpEdit.Properties.NullText = "";
            this.GovIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.GovIdGridLookUpEdit.Properties.ValueMember = "GovId";
            this.GovIdGridLookUpEdit.Properties.View = this.gridView1;
            this.GovIdGridLookUpEdit.Size = new System.Drawing.Size(300, 20);
            this.GovIdGridLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.GovIdGridLookUpEdit.TabIndex = 3;
            this.GovIdGridLookUpEdit.EditValueChanged += new System.EventHandler(this.GovIdGridLookUpEdit_EditValueChanged);
            // 
            // govBindingSource
            // 
            this.govBindingSource.DataMember = "Gov";
            this.govBindingSource.DataSource = this.dsGM;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGovName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colGovName
            // 
            this.colGovName.AppearanceCell.Options.UseTextOptions = true;
            this.colGovName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGovName.AppearanceHeader.Options.UseTextOptions = true;
            this.colGovName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGovName.Caption = "Gov Name";
            this.colGovName.FieldName = "GovName";
            this.colGovName.Name = "colGovName";
            this.colGovName.Visible = true;
            this.colGovName.VisibleIndex = 0;
            // 
            // TraderNameTextEdit
            // 
            this.TraderNameTextEdit.EnterMoveNextControl = true;
            this.TraderNameTextEdit.Location = new System.Drawing.Point(98, 12);
            this.TraderNameTextEdit.Name = "TraderNameTextEdit";
            this.TraderNameTextEdit.Size = new System.Drawing.Size(300, 20);
            this.TraderNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.TraderNameTextEdit.TabIndex = 8;
            // 
            // TraderSiteNameTextEdit
            // 
            this.TraderSiteNameTextEdit.EnterMoveNextControl = true;
            this.TraderSiteNameTextEdit.Location = new System.Drawing.Point(98, 36);
            this.TraderSiteNameTextEdit.Name = "TraderSiteNameTextEdit";
            this.TraderSiteNameTextEdit.Size = new System.Drawing.Size(300, 20);
            this.TraderSiteNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.TraderSiteNameTextEdit.TabIndex = 9;
            // 
            // TraderPhoneTextEdit
            // 
            this.TraderPhoneTextEdit.EnterMoveNextControl = true;
            this.TraderPhoneTextEdit.Location = new System.Drawing.Point(98, 60);
            this.TraderPhoneTextEdit.Name = "TraderPhoneTextEdit";
            this.TraderPhoneTextEdit.Size = new System.Drawing.Size(300, 20);
            this.TraderPhoneTextEdit.StyleController = this.dataLayoutControlMain;
            this.TraderPhoneTextEdit.TabIndex = 10;
            // 
            // TraderMobileTextEdit
            // 
            this.TraderMobileTextEdit.EnterMoveNextControl = true;
            this.TraderMobileTextEdit.Location = new System.Drawing.Point(98, 84);
            this.TraderMobileTextEdit.Name = "TraderMobileTextEdit";
            this.TraderMobileTextEdit.Size = new System.Drawing.Size(300, 20);
            this.TraderMobileTextEdit.StyleController = this.dataLayoutControlMain;
            this.TraderMobileTextEdit.TabIndex = 11;
            // 
            // TraderAddressTextEdit
            // 
            this.TraderAddressTextEdit.EnterMoveNextControl = true;
            this.TraderAddressTextEdit.Location = new System.Drawing.Point(98, 108);
            this.TraderAddressTextEdit.Name = "TraderAddressTextEdit";
            this.TraderAddressTextEdit.Size = new System.Drawing.Size(300, 20);
            this.TraderAddressTextEdit.StyleController = this.dataLayoutControlMain;
            this.TraderAddressTextEdit.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 235);
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
            this.ItemForGovId,
            this.ItemForAreaId,
            this.ItemForTraderName,
            this.ItemForTraderSiteName,
            this.ItemForTraderPhone,
            this.ItemForTraderMobile,
            this.ItemForTraderAddress});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 215);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 189);
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
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 189);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 168);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 21);
            this.emptySpaceItem1.Text = "empty Space Item Last";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForGovId
            // 
            this.ItemForGovId.Control = this.GovIdGridLookUpEdit;
            this.ItemForGovId.CustomizationFormText = "Gov Name";
            this.ItemForGovId.Location = new System.Drawing.Point(0, 120);
            this.ItemForGovId.Name = "ItemForGovId";
            this.ItemForGovId.Size = new System.Drawing.Size(390, 24);
            this.ItemForGovId.Text = "Gov Name";
            this.ItemForGovId.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForAreaId
            // 
            this.ItemForAreaId.Control = this.AreaIdGridLookUpEdit;
            this.ItemForAreaId.CustomizationFormText = "Area Name";
            this.ItemForAreaId.Location = new System.Drawing.Point(0, 144);
            this.ItemForAreaId.Name = "ItemForAreaId";
            this.ItemForAreaId.Size = new System.Drawing.Size(390, 24);
            this.ItemForAreaId.Text = "Area Name";
            this.ItemForAreaId.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForTraderName
            // 
            this.ItemForTraderName.Control = this.TraderNameTextEdit;
            this.ItemForTraderName.CustomizationFormText = "Trader Name";
            this.ItemForTraderName.Location = new System.Drawing.Point(0, 0);
            this.ItemForTraderName.Name = "ItemForTraderName";
            this.ItemForTraderName.Size = new System.Drawing.Size(390, 24);
            this.ItemForTraderName.Text = "Trader Name";
            this.ItemForTraderName.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForTraderSiteName
            // 
            this.ItemForTraderSiteName.Control = this.TraderSiteNameTextEdit;
            this.ItemForTraderSiteName.CustomizationFormText = "Trader Site Name";
            this.ItemForTraderSiteName.Location = new System.Drawing.Point(0, 24);
            this.ItemForTraderSiteName.Name = "ItemForTraderSiteName";
            this.ItemForTraderSiteName.Size = new System.Drawing.Size(390, 24);
            this.ItemForTraderSiteName.Text = "Trader Site Name";
            this.ItemForTraderSiteName.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForTraderPhone
            // 
            this.ItemForTraderPhone.Control = this.TraderPhoneTextEdit;
            this.ItemForTraderPhone.CustomizationFormText = "Trader Phone";
            this.ItemForTraderPhone.Location = new System.Drawing.Point(0, 48);
            this.ItemForTraderPhone.Name = "ItemForTraderPhone";
            this.ItemForTraderPhone.Size = new System.Drawing.Size(390, 24);
            this.ItemForTraderPhone.Text = "Trader Phone";
            this.ItemForTraderPhone.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForTraderMobile
            // 
            this.ItemForTraderMobile.Control = this.TraderMobileTextEdit;
            this.ItemForTraderMobile.CustomizationFormText = "Trader Mobile";
            this.ItemForTraderMobile.Location = new System.Drawing.Point(0, 72);
            this.ItemForTraderMobile.Name = "ItemForTraderMobile";
            this.ItemForTraderMobile.Size = new System.Drawing.Size(390, 24);
            this.ItemForTraderMobile.Text = "Trader Mobile";
            this.ItemForTraderMobile.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForTraderAddress
            // 
            this.ItemForTraderAddress.Control = this.TraderAddressTextEdit;
            this.ItemForTraderAddress.CustomizationFormText = "Trader Address";
            this.ItemForTraderAddress.Location = new System.Drawing.Point(0, 96);
            this.ItemForTraderAddress.Name = "ItemForTraderAddress";
            this.ItemForTraderAddress.Size = new System.Drawing.Size(390, 24);
            this.ItemForTraderAddress.Text = "Trader Address";
            this.ItemForTraderAddress.TextSize = new System.Drawing.Size(83, 13);
            // 
            // govTableAdapter
            // 
            this.govTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // TraderEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 235);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::GM.Properties.Resources.Trader;
            this.Name = "TraderEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AreaIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GovIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.govBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderSiteNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderMobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGovId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAreaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderSiteName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTraderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSave;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderEditor;
        private System.Windows.Forms.BindingSource DataBindingSource;
        private DataSources.dsGM dsGM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAreaId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGovId;
        private DevExpress.XtraEditors.GridLookUpEdit AreaIdGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit GovIdGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource govBindingSource;
        private DataSources.dsGMTableAdapters.GovTableAdapter govTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGovName;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private DataSources.dsGMTableAdapters.AreaTableAdapter areaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaName;
        private DevExpress.XtraEditors.TextEdit TraderNameTextEdit;
        private DevExpress.XtraEditors.TextEdit TraderSiteNameTextEdit;
        private DevExpress.XtraEditors.TextEdit TraderPhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit TraderMobileTextEdit;
        private DevExpress.XtraEditors.TextEdit TraderAddressTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTraderName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTraderSiteName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTraderPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTraderMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTraderAddress;
    }
}