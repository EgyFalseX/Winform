namespace RetirementCenter
{
    partial class Qry16Frm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LSMSCDSyndicate = new DevExpress.Data.Linq.LinqServerModeSource();
            this.LSMSCDSubCommitte = new DevExpress.Data.Linq.LinqServerModeSource();
            this.tBLWarasaSarfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gcCommands = new DevExpress.XtraEditors.GroupControl();
            this.LUECDSubCommitte = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubCommitte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LUESyndicateId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LUETBLDofatSarf = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSTBLDofatSarf = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDofatSarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnCompare = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.pcProgress = new DevExpress.XtraEditors.PanelControl();
            this.lblMax = new DevExpress.XtraEditors.LabelControl();
            this.lblValue = new DevExpress.XtraEditors.LabelControl();
            this.tBLWarasaSarfTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarfTableAdapter();
            this.dsReports = new RetirementCenter.DataSources.dsReports();
            this.rep03TableAdapter = new RetirementCenter.DataSources.dsReportsTableAdapters.Rep03TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWarasaSarfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).BeginInit();
            this.gcCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUECDSubCommitte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUETBLDofatSarf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLDofatSarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProgress)).BeginInit();
            this.pcProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(856, 298);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewData.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewData.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn13,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "eshtrakmonth", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "estktaa", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monymonth", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "rsmmonth", null, "")});
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gridViewData_CustomSummaryCalculate);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "كود الوريث";
            this.gridColumn2.FieldName = "PersonId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "كود العضو";
            this.gridColumn13.FieldName = "MMashatId";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "رقم الصرف";
            this.gridColumn3.FieldName = "sarfnumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "نوع الاختلاف";
            this.gridColumn4.FieldName = "DeffType";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "مبلغ التقرير";
            this.gridColumn5.FieldName = "monymonthR";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "رسم التقرير";
            this.gridColumn6.FieldName = "rsmmonthR";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "اشتراك التقرير";
            this.gridColumn7.FieldName = "eshtrakmonthR";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 91;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "استقطاع التقرير";
            this.gridColumn8.FieldName = "estktaaR";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 90;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "مبلغ الدفعة";
            this.gridColumn9.FieldName = "monymonthS";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "رسم الدفعة";
            this.gridColumn10.FieldName = "rsmmonthS";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "اشتراك الدفعة";
            this.gridColumn11.FieldName = "eshtrakmonthS";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            this.gridColumn11.Width = 90;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "استقطاع الدفعة";
            this.gridColumn12.FieldName = "estktaaS";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 10;
            this.gridColumn12.Width = 96;
            // 
            // LSMSCDSyndicate
            // 
            this.LSMSCDSyndicate.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSCDSyndicate.KeyExpression = "[SyndicateId]";
            // 
            // LSMSCDSubCommitte
            // 
            this.LSMSCDSubCommitte.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSubCommitte);
            this.LSMSCDSubCommitte.KeyExpression = "[SubCommitteId]";
            // 
            // tBLWarasaSarfBindingSource
            // 
            this.tBLWarasaSarfBindingSource.DataMember = "TBLWarasaSarf";
            this.tBLWarasaSarfBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcCommands
            // 
            this.gcCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCommands.AppearanceCaption.Options.UseTextOptions = true;
            this.gcCommands.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcCommands.Controls.Add(this.LUECDSubCommitte);
            this.gcCommands.Controls.Add(this.labelControl2);
            this.gcCommands.Controls.Add(this.LUESyndicateId);
            this.gcCommands.Controls.Add(this.labelControl1);
            this.gcCommands.Controls.Add(this.LUETBLDofatSarf);
            this.gcCommands.Controls.Add(this.labelControl7);
            this.gcCommands.Controls.Add(this.btnCompare);
            this.gcCommands.Location = new System.Drawing.Point(12, 12);
            this.gcCommands.Name = "gcCommands";
            this.gcCommands.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcCommands.Size = new System.Drawing.Size(860, 110);
            this.gcCommands.TabIndex = 0;
            this.gcCommands.Text = "خيارات";
            // 
            // LUECDSubCommitte
            // 
            this.LUECDSubCommitte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LUECDSubCommitte.Location = new System.Drawing.Point(580, 83);
            this.LUECDSubCommitte.Name = "LUECDSubCommitte";
            this.LUECDSubCommitte.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LUECDSubCommitte.Properties.Appearance.Options.UseFont = true;
            this.LUECDSubCommitte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUECDSubCommitte.Properties.DataSource = this.LSMSCDSubCommitte;
            this.LUECDSubCommitte.Properties.DisplayMember = "SubCommitte";
            this.LUECDSubCommitte.Properties.NullText = "";
            this.LUECDSubCommitte.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUECDSubCommitte.Properties.ValueMember = "SubCommitteId";
            this.LUECDSubCommitte.Properties.View = this.gridView4;
            this.LUECDSubCommitte.Size = new System.Drawing.Size(236, 22);
            this.LUECDSubCommitte.TabIndex = 2;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubCommitte1});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colSubCommitte1
            // 
            this.colSubCommitte1.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte1.Caption = "اللجنة";
            this.colSubCommitte1.FieldName = "SubCommitte";
            this.colSubCommitte1.Name = "colSubCommitte1";
            this.colSubCommitte1.Visible = true;
            this.colSubCommitte1.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(829, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "لجنة";
            // 
            // LUESyndicateId
            // 
            this.LUESyndicateId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LUESyndicateId.Location = new System.Drawing.Point(580, 58);
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
            this.LUESyndicateId.EditValueChanged += new System.EventHandler(this.LUESyndicateId_EditValueChanged);
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
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(822, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "فرعية";
            // 
            // LUETBLDofatSarf
            // 
            this.LUETBLDofatSarf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LUETBLDofatSarf.Location = new System.Drawing.Point(580, 30);
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
            // LSMSTBLDofatSarf
            // 
            this.LSMSTBLDofatSarf.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLDofatSarf);
            this.LSMSTBLDofatSarf.KeyExpression = "[DofatSarfId]";
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
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(822, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "الدفعة";
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(426, 30);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(150, 22);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "مقارنة";
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl2.Controls.Add(this.gridControlData);
            this.groupControl2.Location = new System.Drawing.Point(12, 128);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(860, 321);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "التفاصيل";
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbc
            // 
            this.pbc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbc.Location = new System.Drawing.Point(5, 16);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(406, 26);
            this.pbc.TabIndex = 2;
            // 
            // pcProgress
            // 
            this.pcProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcProgress.Controls.Add(this.lblMax);
            this.pcProgress.Controls.Add(this.pbc);
            this.pcProgress.Controls.Add(this.lblValue);
            this.pcProgress.Location = new System.Drawing.Point(14, 45);
            this.pcProgress.Name = "pcProgress";
            this.pcProgress.Size = new System.Drawing.Size(418, 45);
            this.pcProgress.TabIndex = 3;
            this.pcProgress.Visible = false;
            // 
            // lblMax
            // 
            this.lblMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMax.Location = new System.Drawing.Point(351, 1);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(6, 13);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "0";
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(7, 1);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(6, 13);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "0";
            // 
            // tBLWarasaSarfTableAdapter
            // 
            this.tBLWarasaSarfTableAdapter.ClearBeforeFill = true;
            // 
            // dsReports
            // 
            this.dsReports.DataSetName = "dsReports";
            this.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rep03TableAdapter
            // 
            this.rep03TableAdapter.ClearBeforeFill = true;
            // 
            // Qry16Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pcProgress);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gcCommands);
            this.Name = "Qry16Frm";
            this.Text = "مقارنة صرفية الورثة بالتقرير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TBLWarasaSarfFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWarasaSarfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).EndInit();
            this.gcCommands.ResumeLayout(false);
            this.gcCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUECDSubCommitte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUESyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUETBLDofatSarf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLDofatSarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProgress)).EndInit();
            this.pcProgress.ResumeLayout(false);
            this.pcProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.GroupControl gcCommands;
        private DevExpress.XtraEditors.SimpleButton btnCompare;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GridLookUpEdit LUETBLDofatSarf;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLDofatSarf;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarf;
        private DataSources.dsQueries dsQueries;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraEditors.PanelControl pcProgress;
        private DevExpress.XtraEditors.LabelControl lblMax;
        private DevExpress.XtraEditors.LabelControl lblValue;
        private DevExpress.XtraEditors.GridLookUpEdit LUESyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSyndicate;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSubCommitte;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource tBLWarasaSarfBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarfTableAdapter tBLWarasaSarfTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit LUECDSubCommitte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte1;
        private DataSources.dsReports dsReports;
        private DataSources.dsReportsTableAdapters.Rep03TableAdapter rep03TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
    }
}