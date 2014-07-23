namespace GM.Forms.Code
{
    partial class PlumberEditorWFrm
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
            this.ceAutoOpen = new DevExpress.XtraEditors.CheckEdit();
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
            this.PlumberNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PlumberPhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PlumberMobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PlumberAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NationalIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForGovId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAreaId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPlumberName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPlumberPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPlumberMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPlumberAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNationalId = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.govTableAdapter = new GM.DataSources.dsGMTableAdapters.GovTableAdapter();
            this.areaTableAdapter = new GM.DataSources.dsGMTableAdapters.AreaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoOpen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GovIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.govBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberPhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberMobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationalIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGovId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAreaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNationalId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.ceAutoOpen);
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.AreaIdGridLookUpEdit);
            this.dataLayoutControlMain.Controls.Add(this.GovIdGridLookUpEdit);
            this.dataLayoutControlMain.Controls.Add(this.PlumberNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.PlumberPhoneTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.PlumberMobileTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.PlumberAddressTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.NationalIdTextEdit);
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(745, 205, 250, 350);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 261);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // ceAutoOpen
            // 
            this.ceAutoOpen.Location = new System.Drawing.Point(12, 230);
            this.ceAutoOpen.Name = "ceAutoOpen";
            this.ceAutoOpen.Properties.Caption = "AutoOpen";
            this.ceAutoOpen.Size = new System.Drawing.Size(120, 19);
            this.ceAutoOpen.StyleController = this.dataLayoutControlMain;
            this.ceAutoOpen.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::GM.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 22);
            this.btnSave.StyleController = this.dataLayoutControlMain;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::GM.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(260, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 8;
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
            this.AreaIdGridLookUpEdit.Location = new System.Drawing.Point(95, 156);
            this.AreaIdGridLookUpEdit.Name = "AreaIdGridLookUpEdit";
            this.AreaIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AreaIdGridLookUpEdit.Properties.DataSource = this.areaBindingSource;
            this.AreaIdGridLookUpEdit.Properties.DisplayMember = "AreaName";
            this.AreaIdGridLookUpEdit.Properties.NullText = "";
            this.AreaIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.AreaIdGridLookUpEdit.Properties.ValueMember = "AreaId";
            this.AreaIdGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.AreaIdGridLookUpEdit.Size = new System.Drawing.Size(303, 20);
            this.AreaIdGridLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.AreaIdGridLookUpEdit.TabIndex = 6;
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
            this.GovIdGridLookUpEdit.Location = new System.Drawing.Point(95, 132);
            this.GovIdGridLookUpEdit.Name = "GovIdGridLookUpEdit";
            this.GovIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GovIdGridLookUpEdit.Properties.DataSource = this.govBindingSource;
            this.GovIdGridLookUpEdit.Properties.DisplayMember = "GovName";
            this.GovIdGridLookUpEdit.Properties.NullText = "";
            this.GovIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.GovIdGridLookUpEdit.Properties.ValueMember = "GovId";
            this.GovIdGridLookUpEdit.Properties.View = this.gridView1;
            this.GovIdGridLookUpEdit.Size = new System.Drawing.Size(303, 20);
            this.GovIdGridLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.GovIdGridLookUpEdit.TabIndex = 5;
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
            // PlumberNameTextEdit
            // 
            this.PlumberNameTextEdit.EnterMoveNextControl = true;
            this.PlumberNameTextEdit.Location = new System.Drawing.Point(95, 12);
            this.PlumberNameTextEdit.Name = "PlumberNameTextEdit";
            this.PlumberNameTextEdit.Size = new System.Drawing.Size(303, 20);
            this.PlumberNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.PlumberNameTextEdit.TabIndex = 0;
            // 
            // PlumberPhoneTextEdit
            // 
            this.PlumberPhoneTextEdit.EnterMoveNextControl = true;
            this.PlumberPhoneTextEdit.Location = new System.Drawing.Point(95, 60);
            this.PlumberPhoneTextEdit.Name = "PlumberPhoneTextEdit";
            this.PlumberPhoneTextEdit.Size = new System.Drawing.Size(303, 20);
            this.PlumberPhoneTextEdit.StyleController = this.dataLayoutControlMain;
            this.PlumberPhoneTextEdit.TabIndex = 2;
            // 
            // PlumberMobileTextEdit
            // 
            this.PlumberMobileTextEdit.EnterMoveNextControl = true;
            this.PlumberMobileTextEdit.Location = new System.Drawing.Point(95, 84);
            this.PlumberMobileTextEdit.Name = "PlumberMobileTextEdit";
            this.PlumberMobileTextEdit.Size = new System.Drawing.Size(303, 20);
            this.PlumberMobileTextEdit.StyleController = this.dataLayoutControlMain;
            this.PlumberMobileTextEdit.TabIndex = 3;
            // 
            // PlumberAddressTextEdit
            // 
            this.PlumberAddressTextEdit.EnterMoveNextControl = true;
            this.PlumberAddressTextEdit.Location = new System.Drawing.Point(95, 108);
            this.PlumberAddressTextEdit.Name = "PlumberAddressTextEdit";
            this.PlumberAddressTextEdit.Size = new System.Drawing.Size(303, 20);
            this.PlumberAddressTextEdit.StyleController = this.dataLayoutControlMain;
            this.PlumberAddressTextEdit.TabIndex = 4;
            // 
            // NationalIdTextEdit
            // 
            this.NationalIdTextEdit.EnterMoveNextControl = true;
            this.NationalIdTextEdit.Location = new System.Drawing.Point(95, 36);
            this.NationalIdTextEdit.Name = "NationalIdTextEdit";
            this.NationalIdTextEdit.Size = new System.Drawing.Size(303, 20);
            this.NationalIdTextEdit.StyleController = this.dataLayoutControlMain;
            this.NationalIdTextEdit.TabIndex = 1;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 261);
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
            this.ItemForPlumberName,
            this.ItemForPlumberPhone,
            this.ItemForPlumberMobile,
            this.ItemForPlumberAddress,
            this.ItemForNationalId,
            this.emptySpaceItem2,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 241);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 192);
            this.layoutControlItemCancel.Name = "layoutControlItemCancel";
            this.layoutControlItemCancel.Size = new System.Drawing.Size(142, 49);
            this.layoutControlItemCancel.Text = "layoutControlItemCancel";
            this.layoutControlItemCancel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCancel.TextToControlDistance = 0;
            this.layoutControlItemCancel.TextVisible = false;
            // 
            // layoutControlItemSave
            // 
            this.layoutControlItemSave.Control = this.btnSave;
            this.layoutControlItemSave.CustomizationFormText = "layoutControlItemSave";
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 192);
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
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 24);
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
            this.ItemForGovId.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForAreaId
            // 
            this.ItemForAreaId.Control = this.AreaIdGridLookUpEdit;
            this.ItemForAreaId.CustomizationFormText = "Area Name";
            this.ItemForAreaId.Location = new System.Drawing.Point(0, 144);
            this.ItemForAreaId.Name = "ItemForAreaId";
            this.ItemForAreaId.Size = new System.Drawing.Size(390, 24);
            this.ItemForAreaId.Text = "Area Name";
            this.ItemForAreaId.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPlumberName
            // 
            this.ItemForPlumberName.Control = this.PlumberNameTextEdit;
            this.ItemForPlumberName.CustomizationFormText = "Plumber Name";
            this.ItemForPlumberName.Location = new System.Drawing.Point(0, 0);
            this.ItemForPlumberName.Name = "ItemForPlumberName";
            this.ItemForPlumberName.Size = new System.Drawing.Size(390, 24);
            this.ItemForPlumberName.Text = "Plumber Name";
            this.ItemForPlumberName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPlumberPhone
            // 
            this.ItemForPlumberPhone.Control = this.PlumberPhoneTextEdit;
            this.ItemForPlumberPhone.CustomizationFormText = "Plumber Phone";
            this.ItemForPlumberPhone.Location = new System.Drawing.Point(0, 48);
            this.ItemForPlumberPhone.Name = "ItemForPlumberPhone";
            this.ItemForPlumberPhone.Size = new System.Drawing.Size(390, 24);
            this.ItemForPlumberPhone.Text = "Plumber Phone";
            this.ItemForPlumberPhone.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPlumberMobile
            // 
            this.ItemForPlumberMobile.Control = this.PlumberMobileTextEdit;
            this.ItemForPlumberMobile.CustomizationFormText = "Plumber Mobile";
            this.ItemForPlumberMobile.Location = new System.Drawing.Point(0, 72);
            this.ItemForPlumberMobile.Name = "ItemForPlumberMobile";
            this.ItemForPlumberMobile.Size = new System.Drawing.Size(390, 24);
            this.ItemForPlumberMobile.Text = "Plumber Mobile";
            this.ItemForPlumberMobile.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPlumberAddress
            // 
            this.ItemForPlumberAddress.Control = this.PlumberAddressTextEdit;
            this.ItemForPlumberAddress.CustomizationFormText = "Plumber Address";
            this.ItemForPlumberAddress.Location = new System.Drawing.Point(0, 96);
            this.ItemForPlumberAddress.Name = "ItemForPlumberAddress";
            this.ItemForPlumberAddress.Size = new System.Drawing.Size(390, 24);
            this.ItemForPlumberAddress.Text = "Plumber Address";
            this.ItemForPlumberAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForNationalId
            // 
            this.ItemForNationalId.Control = this.NationalIdTextEdit;
            this.ItemForNationalId.CustomizationFormText = "National Id";
            this.ItemForNationalId.Location = new System.Drawing.Point(0, 24);
            this.ItemForNationalId.Name = "ItemForNationalId";
            this.ItemForNationalId.Size = new System.Drawing.Size(390, 24);
            this.ItemForNationalId.Text = "National Id";
            this.ItemForNationalId.TextSize = new System.Drawing.Size(80, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(124, 218);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(124, 23);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceAutoOpen;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 218);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(124, 23);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // govTableAdapter
            // 
            this.govTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // PlumberEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::GM.Properties.Resources.JobEditor;
            this.Name = "PlumberEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoOpen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GovIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.govBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberPhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberMobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlumberAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationalIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGovId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAreaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlumberAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNationalId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit PlumberNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PlumberPhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit PlumberMobileTextEdit;
        private DevExpress.XtraEditors.TextEdit PlumberAddressTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPlumberName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPlumberPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPlumberMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPlumberAddress;
        private DevExpress.XtraEditors.TextEdit NationalIdTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNationalId;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        public DevExpress.XtraEditors.CheckEdit ceAutoOpen;
    }
}