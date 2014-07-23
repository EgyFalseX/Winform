namespace Members
{
    partial class TBLMemberOldFrm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LUEEmp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tBLMemberOldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbesalno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbMemberName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LUESubCommitteId = new DevExpress.XtraEditors.LookUpEdit();
            this.cDSubCommitteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LUESyndicateId = new DevExpress.XtraEditors.LookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbKideNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageMain = new DevExpress.XtraTab.XtraTabPage();
            this.tBLMemberOldTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMemberOldTableAdapter();
            this.cDSyndicateTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter();
            this.cDSubCommitteTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDSubCommitteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMemberOldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbesalno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUESubCommitteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSubCommitteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKideNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.LUEEmp);
            this.groupControl1.Location = new System.Drawing.Point(1, 6);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(732, 97);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "الاعضاء";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::Members.Properties.Resources.DeleteObject;
            this.btnDelete.Location = new System.Drawing.Point(146, 35);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Tag = "delete";
            this.btnDelete.Text = "حذف";
            this.btnDelete.ToolTip = "اضعط هنا لحذف المختار";
            this.btnDelete.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnDelete.ToolTipTitle = "حذف F8";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(231, 52);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(231, 32);
            this.btnNew.TabIndex = 1;
            this.btnNew.Tag = "new";
            this.btnNew.Text = "اضافة جديد";
            this.btnNew.ToolTip = "اضعط هنا لبدء اضافة جديد";
            this.btnNew.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnNew.ToolTipTitle = "اضافة F5";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(470, 31);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "الاعضاء";
            // 
            // LUEEmp
            // 
            this.LUEEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUEEmp.Location = new System.Drawing.Point(230, 30);
            this.LUEEmp.Margin = new System.Windows.Forms.Padding(0);
            this.LUEEmp.Name = "LUEEmp";
            this.LUEEmp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEEmp.Properties.DataSource = this.tBLMemberOldBindingSource;
            this.LUEEmp.Properties.DisplayMember = "MemberName";
            this.LUEEmp.Properties.NullText = "";
            this.LUEEmp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEEmp.Properties.ValueMember = "MemberoldId";
            this.LUEEmp.Properties.View = this.gridLookUpEdit1View;
            this.LUEEmp.Size = new System.Drawing.Size(231, 20);
            this.LUEEmp.TabIndex = 0;
            this.LUEEmp.EditValueChanged += new System.EventHandler(this.LUEEmp_EditValueChanged);
            // 
            // tBLMemberOldBindingSource
            // 
            this.tBLMemberOldBindingSource.DataMember = "TBLMemberOld";
            this.tBLMemberOldBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.Caption = "الاسماء";
            this.gridColumn17.FieldName = "MemberName";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(558, 127);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 17);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "رقم الايصال";
            // 
            // tbesalno
            // 
            this.tbesalno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbesalno.EnterMoveNextControl = true;
            this.tbesalno.Location = new System.Drawing.Point(363, 126);
            this.tbesalno.Margin = new System.Windows.Forms.Padding(0);
            this.tbesalno.Name = "tbesalno";
            this.tbesalno.Properties.DisplayFormat.FormatString = "n0";
            this.tbesalno.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbesalno.Properties.EditFormat.FormatString = "n0";
            this.tbesalno.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbesalno.Properties.Mask.EditMask = "n0";
            this.tbesalno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbesalno.Properties.MaxLength = 12;
            this.tbesalno.Size = new System.Drawing.Size(161, 20);
            this.tbesalno.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl2.Location = new System.Drawing.Point(587, 59);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "الاسم";
            // 
            // tbMemberName
            // 
            this.tbMemberName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberName.EnterMoveNextControl = true;
            this.tbMemberName.Location = new System.Drawing.Point(96, 60);
            this.tbMemberName.Margin = new System.Windows.Forms.Padding(0);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(428, 20);
            this.tbMemberName.TabIndex = 0;
            this.tbMemberName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // groupControl6
            // 
            this.groupControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl6.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupControl6.AppearanceCaption.Options.UseFont = true;
            this.groupControl6.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl6.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl6.Controls.Add(this.btnUpdate);
            this.groupControl6.Controls.Add(this.btnSave);
            this.groupControl6.Location = new System.Drawing.Point(1, 343);
            this.groupControl6.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(725, 60);
            this.groupControl6.TabIndex = 8;
            this.groupControl6.Text = "الاوامر";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(346, 23);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(231, 32);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Tag = "update";
            this.btnUpdate.Text = "حفظ كتعديل";
            this.btnUpdate.ToolTip = "اضعط هنا لحفظ التعديلات";
            this.btnUpdate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnUpdate.ToolTipTitle = "تعديل F10";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(108, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(231, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Tag = "save";
            this.btnSave.Text = "حفظ جديد";
            this.btnSave.ToolTip = "اضعط هنا لحفظ جديد";
            this.btnSave.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnSave.ToolTipTitle = "حفظ جديد F6";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl21
            // 
            this.labelControl21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl21.Location = new System.Drawing.Point(270, 92);
            this.labelControl21.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(79, 17);
            this.labelControl21.TabIndex = 27;
            this.labelControl21.Text = "اللجنة النقابية";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl11.Location = new System.Drawing.Point(541, 94);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(80, 17);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "النقابة الفرعية";
            // 
            // LUESubCommitteId
            // 
            this.LUESubCommitteId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUESubCommitteId.EnterMoveNextControl = true;
            this.LUESubCommitteId.Location = new System.Drawing.Point(96, 91);
            this.LUESubCommitteId.Margin = new System.Windows.Forms.Padding(0);
            this.LUESubCommitteId.Name = "LUESubCommitteId";
            this.LUESubCommitteId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.LUESubCommitteId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubCommitte", "الاسم", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.LUESubCommitteId.Properties.DataSource = this.cDSubCommitteBindingSource;
            this.LUESubCommitteId.Properties.DisplayMember = "SubCommitte";
            this.LUESubCommitteId.Properties.NullText = "";
            this.LUESubCommitteId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUESubCommitteId.Properties.ValueMember = "SubCommitteId";
            this.LUESubCommitteId.Size = new System.Drawing.Size(162, 20);
            this.LUESubCommitteId.TabIndex = 2;
            // 
            // cDSubCommitteBindingSource
            // 
            this.cDSubCommitteBindingSource.DataMember = "CDSubCommitte";
            this.cDSubCommitteBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // LUESyndicateId
            // 
            this.LUESyndicateId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUESyndicateId.EnterMoveNextControl = true;
            this.LUESyndicateId.Location = new System.Drawing.Point(363, 93);
            this.LUESyndicateId.Margin = new System.Windows.Forms.Padding(0);
            this.LUESyndicateId.Name = "LUESyndicateId";
            this.LUESyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.LUESyndicateId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الاسم", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.LUESyndicateId.Properties.DataSource = this.cDSyndicateBindingSource;
            this.LUESyndicateId.Properties.DisplayMember = "Syndicate";
            this.LUESyndicateId.Properties.NullText = "";
            this.LUESyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUESyndicateId.Properties.ValueMember = "SyndicateId";
            this.LUESyndicateId.Size = new System.Drawing.Size(161, 20);
            this.LUESyndicateId.TabIndex = 1;
            this.LUESyndicateId.EditValueChanged += new System.EventHandler(this.LUESyndicateId_EditValueChanged);
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // tbKideNumber
            // 
            this.tbKideNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbKideNumber.EnterMoveNextControl = true;
            this.tbKideNumber.Location = new System.Drawing.Point(96, 128);
            this.tbKideNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tbKideNumber.Name = "tbKideNumber";
            this.tbKideNumber.Properties.DisplayFormat.FormatString = "n0";
            this.tbKideNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbKideNumber.Properties.EditFormat.FormatString = "n0";
            this.tbKideNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbKideNumber.Properties.Mask.EditMask = "n0";
            this.tbKideNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbKideNumber.Size = new System.Drawing.Size(162, 20);
            this.tbKideNumber.TabIndex = 4;
            // 
            // labelControl20
            // 
            this.labelControl20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl20.Location = new System.Drawing.Point(296, 129);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(52, 17);
            this.labelControl20.TabIndex = 35;
            this.labelControl20.Text = "رقم القيد";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(1, 106);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageMain;
            this.xtraTabControl1.Size = new System.Drawing.Size(725, 234);
            this.xtraTabControl1.TabIndex = 36;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageMain});
            // 
            // xtraTabPageMain
            // 
            this.xtraTabPageMain.Controls.Add(this.labelControl3);
            this.xtraTabPageMain.Controls.Add(this.tbMemberName);
            this.xtraTabPageMain.Controls.Add(this.tbesalno);
            this.xtraTabPageMain.Controls.Add(this.LUESubCommitteId);
            this.xtraTabPageMain.Controls.Add(this.labelControl20);
            this.xtraTabPageMain.Controls.Add(this.labelControl11);
            this.xtraTabPageMain.Controls.Add(this.LUESyndicateId);
            this.xtraTabPageMain.Controls.Add(this.labelControl21);
            this.xtraTabPageMain.Controls.Add(this.labelControl2);
            this.xtraTabPageMain.Controls.Add(this.tbKideNumber);
            this.xtraTabPageMain.Name = "xtraTabPageMain";
            this.xtraTabPageMain.Size = new System.Drawing.Size(719, 206);
            this.xtraTabPageMain.Text = "بيانات اساسية";
            // 
            // tBLMemberOldTableAdapter
            // 
            this.tBLMemberOldTableAdapter.ClearBeforeFill = true;
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // cDSubCommitteTableAdapter
            // 
            this.cDSubCommitteTableAdapter.ClearBeforeFill = true;
            // 
            // TBLMemberOldFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 407);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl1);
            this.Name = "TBLMemberOldFrm";
            this.Text = "ادخال قديم";
            this.Load += new System.EventHandler(this.TBL_EmpFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMemberOldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbesalno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LUESubCommitteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSubCommitteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKideNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageMain.ResumeLayout(false);
            this.xtraTabPageMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbMemberName;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GridLookUpEdit LUEEmp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LookUpEdit LUESubCommitteId;
        private DevExpress.XtraEditors.LookUpEdit LUESyndicateId;
        private DevExpress.XtraEditors.TextEdit tbKideNumber;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbesalno;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMain;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource tBLMemberOldBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.TBLMemberOldTableAdapter tBLMemberOldTableAdapter;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private System.Windows.Forms.BindingSource cDSubCommitteBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDSubCommitteTableAdapter cDSubCommitteTableAdapter;
    }
}