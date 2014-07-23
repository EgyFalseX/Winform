namespace RetirementCenter
{
    partial class Qry21Frm
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
            this.LSMSCDSyndicate = new DevExpress.Data.Linq.LinqServerModeSource();
            this.LSMSTBLDofatSarf = new DevExpress.Data.Linq.LinqServerModeSource();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.SyndicateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.CountMemberSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CountWarasaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.COUNTMSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.COUNTWSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.COUNTMWSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForSyndicate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountMember = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountWarasa = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCOUNTM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCOUNTW = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCOUNTMW = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblSum = new DevExpress.XtraLayout.SimpleLabelItem();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LUETBLDofatSarf = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDofatSarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LUESyndicateId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCommands = new DevExpress.XtraEditors.GroupControl();
            this.qry21TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.Qry21TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLDofatSarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyndicateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountMemberSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountWarasaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COUNTMSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COUNTWSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COUNTMWSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSyndicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountWarasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOUNTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOUNTW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOUNTMW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUETBLDofatSarf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).BeginInit();
            this.gcCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // LSMSCDSyndicate
            // 
            this.LSMSCDSyndicate.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSCDSyndicate.KeyExpression = "[SyndicateId]";
            // 
            // LSMSTBLDofatSarf
            // 
            this.LSMSTBLDofatSarf.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLDofatSarf);
            this.LSMSTBLDofatSarf.KeyExpression = "[DofatSarfId]";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl2.Controls.Add(this.dataLayoutControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 102);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(453, 347);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "التفاصيل";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.SyndicateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountMemberSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.CountWarasaSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.COUNTMSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.COUNTWSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.COUNTMWSpinEdit);
            this.dataLayoutControl1.DataMember = "Qry21";
            this.dataLayoutControl1.DataSource = this.dsQueries;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 21);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(694, 248, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(449, 324);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // SyndicateTextEdit
            // 
            this.SyndicateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsQueries, "Qry21.Syndicate", true));
            this.SyndicateTextEdit.EditValue = "";
            this.SyndicateTextEdit.Location = new System.Drawing.Point(12, 12);
            this.SyndicateTextEdit.Name = "SyndicateTextEdit";
            this.SyndicateTextEdit.Properties.ReadOnly = true;
            this.SyndicateTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SyndicateTextEdit.Size = new System.Drawing.Size(348, 20);
            this.SyndicateTextEdit.StyleController = this.dataLayoutControl1;
            this.SyndicateTextEdit.TabIndex = 4;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CountMemberSpinEdit
            // 
            this.CountMemberSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsQueries, "Qry21.CountMember", true));
            this.CountMemberSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CountMemberSpinEdit.Location = new System.Drawing.Point(12, 36);
            this.CountMemberSpinEdit.Name = "CountMemberSpinEdit";
            this.CountMemberSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CountMemberSpinEdit.Properties.ReadOnly = true;
            this.CountMemberSpinEdit.Size = new System.Drawing.Size(348, 20);
            this.CountMemberSpinEdit.StyleController = this.dataLayoutControl1;
            this.CountMemberSpinEdit.TabIndex = 5;
            // 
            // CountWarasaSpinEdit
            // 
            this.CountWarasaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsQueries, "Qry21.CountWarasa", true));
            this.CountWarasaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CountWarasaSpinEdit.Location = new System.Drawing.Point(12, 60);
            this.CountWarasaSpinEdit.Name = "CountWarasaSpinEdit";
            this.CountWarasaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CountWarasaSpinEdit.Properties.ReadOnly = true;
            this.CountWarasaSpinEdit.Size = new System.Drawing.Size(348, 20);
            this.CountWarasaSpinEdit.StyleController = this.dataLayoutControl1;
            this.CountWarasaSpinEdit.TabIndex = 6;
            // 
            // COUNTMSpinEdit
            // 
            this.COUNTMSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsQueries, "Qry21.COUNTM", true));
            this.COUNTMSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.COUNTMSpinEdit.Location = new System.Drawing.Point(12, 84);
            this.COUNTMSpinEdit.Name = "COUNTMSpinEdit";
            this.COUNTMSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.COUNTMSpinEdit.Properties.ReadOnly = true;
            this.COUNTMSpinEdit.Size = new System.Drawing.Size(348, 20);
            this.COUNTMSpinEdit.StyleController = this.dataLayoutControl1;
            this.COUNTMSpinEdit.TabIndex = 7;
            // 
            // COUNTWSpinEdit
            // 
            this.COUNTWSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsQueries, "Qry21.COUNTW", true));
            this.COUNTWSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.COUNTWSpinEdit.Location = new System.Drawing.Point(12, 108);
            this.COUNTWSpinEdit.Name = "COUNTWSpinEdit";
            this.COUNTWSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.COUNTWSpinEdit.Properties.ReadOnly = true;
            this.COUNTWSpinEdit.Size = new System.Drawing.Size(348, 20);
            this.COUNTWSpinEdit.StyleController = this.dataLayoutControl1;
            this.COUNTWSpinEdit.TabIndex = 8;
            // 
            // COUNTMWSpinEdit
            // 
            this.COUNTMWSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsQueries, "Qry21.COUNTMW", true));
            this.COUNTMWSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.COUNTMWSpinEdit.Location = new System.Drawing.Point(12, 132);
            this.COUNTMWSpinEdit.Name = "COUNTMWSpinEdit";
            this.COUNTMWSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.COUNTMWSpinEdit.Properties.ReadOnly = true;
            this.COUNTMWSpinEdit.Size = new System.Drawing.Size(348, 20);
            this.COUNTMWSpinEdit.StyleController = this.dataLayoutControl1;
            this.COUNTMWSpinEdit.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.emptySpaceItem1,
            this.simpleLabelItem1,
            this.lblSum});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(449, 324);
            this.layoutControlGroup1.Text = "التفاصيل";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSyndicate,
            this.ItemForCountMember,
            this.ItemForCountWarasa,
            this.ItemForCOUNTM,
            this.ItemForCOUNTW,
            this.ItemForCOUNTMW});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(429, 144);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForSyndicate
            // 
            this.ItemForSyndicate.Control = this.SyndicateTextEdit;
            this.ItemForSyndicate.CustomizationFormText = "الفرعية";
            this.ItemForSyndicate.Location = new System.Drawing.Point(0, 0);
            this.ItemForSyndicate.Name = "ItemForSyndicate";
            this.ItemForSyndicate.Size = new System.Drawing.Size(429, 24);
            this.ItemForSyndicate.Text = "الفرعية";
            this.ItemForSyndicate.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForSyndicate.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCountMember
            // 
            this.ItemForCountMember.Control = this.CountMemberSpinEdit;
            this.ItemForCountMember.CustomizationFormText = "عدد الاعضاء";
            this.ItemForCountMember.Location = new System.Drawing.Point(0, 24);
            this.ItemForCountMember.Name = "ItemForCountMember";
            this.ItemForCountMember.Size = new System.Drawing.Size(429, 24);
            this.ItemForCountMember.Text = "مبلغ الاعضاء";
            this.ItemForCountMember.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForCountMember.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCountWarasa
            // 
            this.ItemForCountWarasa.Control = this.CountWarasaSpinEdit;
            this.ItemForCountWarasa.CustomizationFormText = "عدد الورثة";
            this.ItemForCountWarasa.Location = new System.Drawing.Point(0, 48);
            this.ItemForCountWarasa.Name = "ItemForCountWarasa";
            this.ItemForCountWarasa.Size = new System.Drawing.Size(429, 24);
            this.ItemForCountWarasa.Text = "مبلغ الورثة";
            this.ItemForCountWarasa.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForCountWarasa.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCOUNTM
            // 
            this.ItemForCOUNTM.Control = this.COUNTMSpinEdit;
            this.ItemForCOUNTM.CustomizationFormText = "عدد اعضاء الورثة";
            this.ItemForCOUNTM.Location = new System.Drawing.Point(0, 72);
            this.ItemForCOUNTM.Name = "ItemForCOUNTM";
            this.ItemForCOUNTM.Size = new System.Drawing.Size(429, 24);
            this.ItemForCOUNTM.Text = "عدد اعضاء الورثة";
            this.ItemForCOUNTM.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForCOUNTM.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCOUNTW
            // 
            this.ItemForCOUNTW.Control = this.COUNTWSpinEdit;
            this.ItemForCOUNTW.CustomizationFormText = "مبلغ الورثة";
            this.ItemForCOUNTW.Location = new System.Drawing.Point(0, 96);
            this.ItemForCOUNTW.Name = "ItemForCOUNTW";
            this.ItemForCOUNTW.Size = new System.Drawing.Size(429, 24);
            this.ItemForCOUNTW.Text = "عدد الورثة";
            this.ItemForCOUNTW.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForCOUNTW.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCOUNTMW
            // 
            this.ItemForCOUNTMW.Control = this.COUNTMWSpinEdit;
            this.ItemForCOUNTMW.CustomizationFormText = "مبلغ الاعضاء";
            this.ItemForCOUNTMW.Location = new System.Drawing.Point(0, 120);
            this.ItemForCOUNTMW.Name = "ItemForCOUNTMW";
            this.ItemForCOUNTMW.Size = new System.Drawing.Size(429, 24);
            this.ItemForCOUNTMW.Text = "عدد الاعضاء";
            this.ItemForCOUNTMW.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForCOUNTMW.TextSize = new System.Drawing.Size(74, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(429, 143);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.CustomizationFormText = "المجموع";
            this.simpleLabelItem1.Location = new System.Drawing.Point(351, 287);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(78, 17);
            this.simpleLabelItem1.Text = "المجموع";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lblSum
            // 
            this.lblSum.AllowHotTrack = false;
            this.lblSum.CustomizationFormText = "LabelsimpleLabelItem2";
            this.lblSum.Location = new System.Drawing.Point(0, 287);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(351, 17);
            this.lblSum.Text = "0";
            this.lblSum.TextSize = new System.Drawing.Size(74, 13);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnView.Location = new System.Drawing.Point(5, 24);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(150, 22);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "عرض";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl7.Location = new System.Drawing.Point(401, 27);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "الدفعة";
            // 
            // LUETBLDofatSarf
            // 
            this.LUETBLDofatSarf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUETBLDofatSarf.Location = new System.Drawing.Point(159, 24);
            this.LUETBLDofatSarf.Name = "LUETBLDofatSarf";
            this.LUETBLDofatSarf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LUETBLDofatSarf.Properties.Appearance.Options.UseFont = true;
            this.LUETBLDofatSarf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUETBLDofatSarf.Properties.DataSource = this.LSMSTBLDofatSarf;
            this.LUETBLDofatSarf.Properties.DisplayMember = "DofatSarf";
            this.LUETBLDofatSarf.Properties.NullText = "";
            this.LUETBLDofatSarf.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUETBLDofatSarf.Properties.ValueMember = "DofatSarfId";
            this.LUETBLDofatSarf.Properties.View = this.gridLookUpEdit1View;
            this.LUETBLDofatSarf.Size = new System.Drawing.Size(236, 22);
            this.LUETBLDofatSarf.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDofatSarf});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDofatSarf
            // 
            this.colDofatSarf.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.Caption = "اسم الدفعة";
            this.colDofatSarf.FieldName = "DofatSarf";
            this.colDofatSarf.Name = "colDofatSarf";
            this.colDofatSarf.Visible = true;
            this.colDofatSarf.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(401, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "فرعية";
            // 
            // LUESyndicateId
            // 
            this.LUESyndicateId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUESyndicateId.Location = new System.Drawing.Point(159, 52);
            this.LUESyndicateId.Name = "LUESyndicateId";
            this.LUESyndicateId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LUESyndicateId.Properties.Appearance.Options.UseFont = true;
            this.LUESyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUESyndicateId.Properties.DataSource = this.LSMSCDSyndicate;
            this.LUESyndicateId.Properties.DisplayMember = "Syndicate";
            this.LUESyndicateId.Properties.NullText = "";
            this.LUESyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUESyndicateId.Properties.ValueMember = "SyndicateId";
            this.LUESyndicateId.Properties.View = this.gridView1;
            this.LUESyndicateId.Size = new System.Drawing.Size(236, 22);
            this.LUESyndicateId.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "الفرعية";
            this.gridColumn1.FieldName = "Syndicate";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gcCommands
            // 
            this.gcCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCommands.AppearanceCaption.Options.UseTextOptions = true;
            this.gcCommands.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcCommands.Controls.Add(this.LUESyndicateId);
            this.gcCommands.Controls.Add(this.labelControl1);
            this.gcCommands.Controls.Add(this.LUETBLDofatSarf);
            this.gcCommands.Controls.Add(this.labelControl7);
            this.gcCommands.Controls.Add(this.btnView);
            this.gcCommands.Location = new System.Drawing.Point(12, 12);
            this.gcCommands.Name = "gcCommands";
            this.gcCommands.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcCommands.Size = new System.Drawing.Size(453, 84);
            this.gcCommands.TabIndex = 0;
            this.gcCommands.Text = "خيارات";
            // 
            // qry21TableAdapter
            // 
            this.qry21TableAdapter.ClearBeforeFill = true;
            // 
            // Qry21Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 461);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gcCommands);
            this.Name = "Qry21Frm";
            this.Text = "احصائيات الدفعات للفرعيات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TBLWarasaSarfFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLDofatSarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SyndicateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountMemberSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountWarasaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COUNTMSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COUNTWSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COUNTMWSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSyndicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountWarasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOUNTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOUNTW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOUNTMW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUETBLDofatSarf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).EndInit();
            this.gcCommands.ResumeLayout(false);
            this.gcCommands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLDofatSarf;
        private DataSources.dsQueries dsQueries;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSyndicate;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GridLookUpEdit LUETBLDofatSarf;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarf;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit LUESyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GroupControl gcCommands;
        private DataSources.dsQueriesTableAdapters.Qry21TableAdapter qry21TableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit SyndicateTextEdit;
        private DevExpress.XtraEditors.SpinEdit CountMemberSpinEdit;
        private DevExpress.XtraEditors.SpinEdit CountWarasaSpinEdit;
        private DevExpress.XtraEditors.SpinEdit COUNTMSpinEdit;
        private DevExpress.XtraEditors.SpinEdit COUNTWSpinEdit;
        private DevExpress.XtraEditors.SpinEdit COUNTMWSpinEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSyndicate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountMember;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountWarasa;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCOUNTM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCOUNTW;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCOUNTMW;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem lblSum;
    }
}