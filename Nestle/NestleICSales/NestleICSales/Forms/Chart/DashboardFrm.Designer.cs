namespace NestleICSales.Forms.Chart
{
    partial class DashboardFrm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
            this.dataSourcePro_0001 = new DevExpress.DashboardCommon.DataSource();
            this.dsNMQry1 = new NestleICSales.DataSources.dsQry();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourcePro_0001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNMQry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pivotDashboardItem1
            // 
            dimension1.DataMember = "Supervisor";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            dimension2.DataMember = "RouteName";
            measure1.DataMember = "SalesMonth";
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem2");
            this.pivotDashboardItem1.DataSource = this.dataSourcePro_0001;
            this.pivotDashboardItem1.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.Name = "Pivot 1";
            this.pivotDashboardItem1.NamesRepository.Clear();
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pivotDashboardItem1.ShowCaption = true;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // dataSourcePro_0001
            // 
            this.dataSourcePro_0001.ComponentName = "dataSourcePro_0001";
            this.dataSourcePro_0001.Data = this.dsNMQry1;
            this.dataSourcePro_0001.DataMember = "Pro_0001";
            this.dataSourcePro_0001.Name = "Data Source Pro_0001";
            // 
            // dsNMQry1
            // 
            this.dsNMQry1.DataSetName = "dsNMQry";
            this.dsNMQry1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DashboardFrm
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {
            this.dataSourcePro_0001});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pivotDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem1.Weight = 100D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourcePro_0001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNMQry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DataSource dataSourcePro_0001;
        private DataSources.dsQry dsNMQry1;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;

    }
}
