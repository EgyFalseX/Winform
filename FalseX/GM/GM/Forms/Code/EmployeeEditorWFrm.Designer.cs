namespace GM.Forms.Code
{
    partial class EmployeeEditorWFrm
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
            this.EmployeeNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmployeePhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmployeeAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AreaIdGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGM = new GM.DataSources.dsGM();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAreaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GovIdGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.govBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGovName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmployeeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForEmployeePhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmployeeAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGovId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAreaId = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.govTableAdapter = new GM.DataSources.dsGMTableAdapters.GovTableAdapter();
            this.areaTableAdapter = new GM.DataSources.dsGMTableAdapters.AreaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GovIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.govBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGovId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAreaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.EmployeeNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.EmployeePhoneTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.EmployeeAddressTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.AreaIdGridLookUpEdit);
            this.dataLayoutControlMain.Controls.Add(this.GovIdGridLookUpEdit);
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(745, 205, 250, 350);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 179);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::GM.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 145);
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
            this.btnCancel.Location = new System.Drawing.Point(260, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // EmployeeNameTextEdit
            // 
            this.EmployeeNameTextEdit.EnterMoveNextControl = true;
            this.EmployeeNameTextEdit.Location = new System.Drawing.Point(103, 12);
            this.EmployeeNameTextEdit.Name = "EmployeeNameTextEdit";
            this.EmployeeNameTextEdit.Size = new System.Drawing.Size(295, 20);
            this.EmployeeNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.EmployeeNameTextEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Must Enter Area Name";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderEditor.SetValidationRule(this.EmployeeNameTextEdit, conditionValidationRule1);
            // 
            // EmployeePhoneTextEdit
            // 
            this.EmployeePhoneTextEdit.EnterMoveNextControl = true;
            this.EmployeePhoneTextEdit.Location = new System.Drawing.Point(103, 36);
            this.EmployeePhoneTextEdit.Name = "EmployeePhoneTextEdit";
            this.EmployeePhoneTextEdit.Size = new System.Drawing.Size(295, 20);
            this.EmployeePhoneTextEdit.StyleController = this.dataLayoutControlMain;
            this.EmployeePhoneTextEdit.TabIndex = 1;
            // 
            // EmployeeAddressTextEdit
            // 
            this.EmployeeAddressTextEdit.EnterMoveNextControl = true;
            this.EmployeeAddressTextEdit.Location = new System.Drawing.Point(103, 60);
            this.EmployeeAddressTextEdit.Name = "EmployeeAddressTextEdit";
            this.EmployeeAddressTextEdit.Size = new System.Drawing.Size(295, 20);
            this.EmployeeAddressTextEdit.StyleController = this.dataLayoutControlMain;
            this.EmployeeAddressTextEdit.TabIndex = 2;
            // 
            // AreaIdGridLookUpEdit
            // 
            this.AreaIdGridLookUpEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AreaIdGridLookUpEdit.EnterMoveNextControl = true;
            this.AreaIdGridLookUpEdit.Location = new System.Drawing.Point(103, 108);
            this.AreaIdGridLookUpEdit.Name = "AreaIdGridLookUpEdit";
            this.AreaIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AreaIdGridLookUpEdit.Properties.DataSource = this.areaBindingSource;
            this.AreaIdGridLookUpEdit.Properties.DisplayMember = "AreaName";
            this.AreaIdGridLookUpEdit.Properties.NullText = "";
            this.AreaIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.AreaIdGridLookUpEdit.Properties.ValueMember = "AreaId";
            this.AreaIdGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.AreaIdGridLookUpEdit.Size = new System.Drawing.Size(295, 20);
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
            this.GovIdGridLookUpEdit.Location = new System.Drawing.Point(103, 84);
            this.GovIdGridLookUpEdit.Name = "GovIdGridLookUpEdit";
            this.GovIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GovIdGridLookUpEdit.Properties.DataSource = this.govBindingSource;
            this.GovIdGridLookUpEdit.Properties.DisplayMember = "GovName";
            this.GovIdGridLookUpEdit.Properties.NullText = "";
            this.GovIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.GovIdGridLookUpEdit.Properties.ValueMember = "GovId";
            this.GovIdGridLookUpEdit.Properties.View = this.gridView1;
            this.GovIdGridLookUpEdit.Size = new System.Drawing.Size(295, 20);
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 179);
            this.layoutControlGroup1.Text = "Root";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmployeeName,
            this.layoutControlItemCancel,
            this.layoutControlItemSave,
            this.emptySpaceItem1,
            this.ItemForEmployeePhone,
            this.ItemForEmployeeAddress,
            this.ItemForGovId,
            this.ItemForAreaId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 159);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForEmployeeName
            // 
            this.ItemForEmployeeName.Control = this.EmployeeNameTextEdit;
            this.ItemForEmployeeName.CustomizationFormText = "Employee Name";
            this.ItemForEmployeeName.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmployeeName.Name = "ItemForEmployeeName";
            this.ItemForEmployeeName.Size = new System.Drawing.Size(390, 24);
            this.ItemForEmployeeName.Text = "EmployeeName";
            this.ItemForEmployeeName.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 133);
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
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 133);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 13);
            this.emptySpaceItem1.Text = "empty Space Item Last";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForEmployeePhone
            // 
            this.ItemForEmployeePhone.Control = this.EmployeePhoneTextEdit;
            this.ItemForEmployeePhone.CustomizationFormText = "Employee Phone";
            this.ItemForEmployeePhone.Location = new System.Drawing.Point(0, 24);
            this.ItemForEmployeePhone.Name = "ItemForEmployeePhone";
            this.ItemForEmployeePhone.Size = new System.Drawing.Size(390, 24);
            this.ItemForEmployeePhone.Text = "Employee Phone";
            this.ItemForEmployeePhone.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForEmployeeAddress
            // 
            this.ItemForEmployeeAddress.Control = this.EmployeeAddressTextEdit;
            this.ItemForEmployeeAddress.CustomizationFormText = "Employee Address";
            this.ItemForEmployeeAddress.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmployeeAddress.Name = "ItemForEmployeeAddress";
            this.ItemForEmployeeAddress.Size = new System.Drawing.Size(390, 24);
            this.ItemForEmployeeAddress.Text = "Employee Address";
            this.ItemForEmployeeAddress.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForGovId
            // 
            this.ItemForGovId.Control = this.GovIdGridLookUpEdit;
            this.ItemForGovId.CustomizationFormText = "Gov Name";
            this.ItemForGovId.Location = new System.Drawing.Point(0, 72);
            this.ItemForGovId.Name = "ItemForGovId";
            this.ItemForGovId.Size = new System.Drawing.Size(390, 24);
            this.ItemForGovId.Text = "Gov Name";
            this.ItemForGovId.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForAreaId
            // 
            this.ItemForAreaId.Control = this.AreaIdGridLookUpEdit;
            this.ItemForAreaId.CustomizationFormText = "Area Name";
            this.ItemForAreaId.Location = new System.Drawing.Point(0, 96);
            this.ItemForAreaId.Name = "ItemForAreaId";
            this.ItemForAreaId.Size = new System.Drawing.Size(390, 24);
            this.ItemForAreaId.Text = "Area Name";
            this.ItemForAreaId.TextSize = new System.Drawing.Size(88, 13);
            // 
            // govTableAdapter
            // 
            this.govTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 179);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::GM.Properties.Resources.Employee;
            this.Name = "EmployeeEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GovIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.govBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGovId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAreaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit EmployeeNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployeeName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSave;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderEditor;
        private System.Windows.Forms.BindingSource DataBindingSource;
        private DataSources.dsGM dsGM;
        private DevExpress.XtraEditors.TextEdit EmployeePhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit EmployeeAddressTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAreaId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGovId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployeePhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployeeAddress;
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
    }
}