namespace NestleMenu.Forms.Code
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.JobIdGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.dsNU = new NestleMenu.DataSources.dsNU();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.EmployeeNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AreaIdGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForEmployeeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJobId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAreaId = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderEditor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.JobTableAdapter();
            this.colJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.AreaTableAdapter();
            this.colAreaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new NestleMenu.DataSources.dsNUTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAreaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.JobIdGridLookUpEdit);
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.EmployeeNameTextEdit);
            this.dataLayoutControlMain.Controls.Add(this.AreaIdGridLookUpEdit);
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(822, 143, 379, 434);
            this.dataLayoutControlMain.Root = this.layoutControlGroup1;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(410, 187);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // JobIdGridLookUpEdit
            // 
            this.JobIdGridLookUpEdit.Location = new System.Drawing.Point(91, 36);
            this.JobIdGridLookUpEdit.Name = "JobIdGridLookUpEdit";
            this.JobIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.JobIdGridLookUpEdit.Properties.DataSource = this.jobBindingSource;
            this.JobIdGridLookUpEdit.Properties.DisplayMember = "JobName";
            this.JobIdGridLookUpEdit.Properties.NullText = "";
            this.JobIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.JobIdGridLookUpEdit.Properties.ValueMember = "JobId";
            this.JobIdGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.JobIdGridLookUpEdit.Size = new System.Drawing.Size(307, 20);
            this.JobIdGridLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.JobIdGridLookUpEdit.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Please Enter Product Base Name";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderEditor.SetValidationRule(this.JobIdGridLookUpEdit, conditionValidationRule3);
            // 
            // dsNU
            // 
            this.dsNU.DataSetName = "dsNU";
            this.dsNU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJobName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::NestleMenu.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 22);
            this.btnSave.StyleController = this.dataLayoutControlMain;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::NestleMenu.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(260, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 22);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            // 
            // EmployeeNameTextEdit
            // 
            this.EmployeeNameTextEdit.Location = new System.Drawing.Point(91, 12);
            this.EmployeeNameTextEdit.Name = "EmployeeNameTextEdit";
            this.EmployeeNameTextEdit.Size = new System.Drawing.Size(307, 20);
            this.EmployeeNameTextEdit.StyleController = this.dataLayoutControlMain;
            this.EmployeeNameTextEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Please Enter Product Name";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderEditor.SetValidationRule(this.EmployeeNameTextEdit, conditionValidationRule1);
            // 
            // AreaIdGridLookUpEdit
            // 
            this.AreaIdGridLookUpEdit.Location = new System.Drawing.Point(91, 60);
            this.AreaIdGridLookUpEdit.Name = "AreaIdGridLookUpEdit";
            this.AreaIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AreaIdGridLookUpEdit.Properties.DataSource = this.areaBindingSource;
            this.AreaIdGridLookUpEdit.Properties.DisplayMember = "AreaName";
            this.AreaIdGridLookUpEdit.Properties.NullText = "";
            this.AreaIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.AreaIdGridLookUpEdit.Properties.ValueMember = "AreaId";
            this.AreaIdGridLookUpEdit.Properties.View = this.gridView1;
            this.AreaIdGridLookUpEdit.Size = new System.Drawing.Size(307, 20);
            this.AreaIdGridLookUpEdit.StyleController = this.dataLayoutControlMain;
            this.AreaIdGridLookUpEdit.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAreaName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(410, 187);
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
            this.ItemForEmployeeName,
            this.ItemForJobId,
            this.ItemForAreaId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(390, 167);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.CustomizationFormText = "layoutControlItemCancel";
            this.layoutControlItemCancel.Location = new System.Drawing.Point(248, 141);
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
            this.layoutControlItemSave.Location = new System.Drawing.Point(0, 141);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(390, 69);
            this.emptySpaceItem1.Text = "empty Space Item Last";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForEmployeeName
            // 
            this.ItemForEmployeeName.Control = this.EmployeeNameTextEdit;
            this.ItemForEmployeeName.CustomizationFormText = "Employee Name";
            this.ItemForEmployeeName.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmployeeName.Name = "ItemForEmployeeName";
            this.ItemForEmployeeName.Size = new System.Drawing.Size(390, 24);
            this.ItemForEmployeeName.Text = "Employee Name";
            this.ItemForEmployeeName.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForJobId
            // 
            this.ItemForJobId.Control = this.JobIdGridLookUpEdit;
            this.ItemForJobId.CustomizationFormText = "Job";
            this.ItemForJobId.Location = new System.Drawing.Point(0, 24);
            this.ItemForJobId.Name = "ItemForJobId";
            this.ItemForJobId.Size = new System.Drawing.Size(390, 24);
            this.ItemForJobId.Text = "Job";
            this.ItemForJobId.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForAreaId
            // 
            this.ItemForAreaId.Control = this.AreaIdGridLookUpEdit;
            this.ItemForAreaId.CustomizationFormText = "Area";
            this.ItemForAreaId.Location = new System.Drawing.Point(0, 48);
            this.ItemForAreaId.Name = "ItemForAreaId";
            this.ItemForAreaId.Size = new System.Drawing.Size(390, 24);
            this.ItemForAreaId.Text = "Area";
            this.ItemForAreaId.TextSize = new System.Drawing.Size(76, 13);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.dsNU;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // colJobName
            // 
            this.colJobName.FieldName = "JobName";
            this.colJobName.Name = "colJobName";
            this.colJobName.Visible = true;
            this.colJobName.VisibleIndex = 0;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.dsNU;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // colAreaName
            // 
            this.colAreaName.FieldName = "AreaName";
            this.colAreaName.Name = "colAreaName";
            this.colAreaName.Visible = true;
            this.colAreaName.VisibleIndex = 0;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dsNU;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeEditorWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 187);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = global::NestleMenu.Properties.Resources.Employee;
            this.Name = "EmployeeEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.AreaEditorWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JobIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAreaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.GridLookUpEdit JobIdGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit EmployeeNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployeeName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJobId;
        private DevExpress.XtraEditors.GridLookUpEdit AreaIdGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAreaId;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private DataSources.dsNUTableAdapters.JobTableAdapter jobTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colJobName;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private DataSources.dsNUTableAdapters.AreaTableAdapter areaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaName;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.dsNUTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}