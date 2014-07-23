namespace NestleICSales
{
    partial class XtraForm1
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.colBillingDetailsId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCases = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillingDocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoldToParty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConditionTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributionChannelId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(721, 470);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillingDetailsId,
            this.colNPS,
            this.colQuin,
            this.colCases,
            this.colVolume,
            this.colBillingDocument,
            this.colSoldToParty,
            this.colRouteNumber,
            this.colBillingDate,
            this.colMaterialNumber,
            this.colConditionTypeId,
            this.colDistributionChannelId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(NestleICSales.DataSources.dsQry.vBillContainsDataTable);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // colBillingDetailsId
            // 
            this.colBillingDetailsId.FieldName = "BillingDetailsId";
            this.colBillingDetailsId.Name = "colBillingDetailsId";
            this.colBillingDetailsId.Visible = true;
            this.colBillingDetailsId.VisibleIndex = 0;
            // 
            // colNPS
            // 
            this.colNPS.FieldName = "NPS";
            this.colNPS.Name = "colNPS";
            this.colNPS.Visible = true;
            this.colNPS.VisibleIndex = 1;
            // 
            // colQuin
            // 
            this.colQuin.FieldName = "Quin";
            this.colQuin.Name = "colQuin";
            this.colQuin.Visible = true;
            this.colQuin.VisibleIndex = 2;
            // 
            // colCases
            // 
            this.colCases.FieldName = "Cases";
            this.colCases.Name = "colCases";
            this.colCases.Visible = true;
            this.colCases.VisibleIndex = 3;
            // 
            // colVolume
            // 
            this.colVolume.FieldName = "Volume";
            this.colVolume.Name = "colVolume";
            this.colVolume.Visible = true;
            this.colVolume.VisibleIndex = 4;
            // 
            // colBillingDocument
            // 
            this.colBillingDocument.FieldName = "BillingDocument";
            this.colBillingDocument.Name = "colBillingDocument";
            this.colBillingDocument.Visible = true;
            this.colBillingDocument.VisibleIndex = 5;
            // 
            // colSoldToParty
            // 
            this.colSoldToParty.FieldName = "SoldToParty";
            this.colSoldToParty.Name = "colSoldToParty";
            this.colSoldToParty.Visible = true;
            this.colSoldToParty.VisibleIndex = 6;
            // 
            // colRouteNumber
            // 
            this.colRouteNumber.FieldName = "RouteNumber";
            this.colRouteNumber.Name = "colRouteNumber";
            this.colRouteNumber.Visible = true;
            this.colRouteNumber.VisibleIndex = 7;
            // 
            // colBillingDate
            // 
            this.colBillingDate.FieldName = "BillingDate";
            this.colBillingDate.Name = "colBillingDate";
            this.colBillingDate.Visible = true;
            this.colBillingDate.VisibleIndex = 8;
            // 
            // colMaterialNumber
            // 
            this.colMaterialNumber.FieldName = "MaterialNumber";
            this.colMaterialNumber.Name = "colMaterialNumber";
            this.colMaterialNumber.Visible = true;
            this.colMaterialNumber.VisibleIndex = 9;
            // 
            // colConditionTypeId
            // 
            this.colConditionTypeId.FieldName = "ConditionTypeId";
            this.colConditionTypeId.Name = "colConditionTypeId";
            this.colConditionTypeId.Visible = true;
            this.colConditionTypeId.VisibleIndex = 10;
            // 
            // colDistributionChannelId
            // 
            this.colDistributionChannelId.FieldName = "DistributionChannelId";
            this.colDistributionChannelId.Name = "colDistributionChannelId";
            this.colDistributionChannelId.Visible = true;
            this.colDistributionChannelId.VisibleIndex = 11;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 470);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingDetailsId;
        private DevExpress.XtraGrid.Columns.GridColumn colNPS;
        private DevExpress.XtraGrid.Columns.GridColumn colQuin;
        private DevExpress.XtraGrid.Columns.GridColumn colCases;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingDocument;
        private DevExpress.XtraGrid.Columns.GridColumn colSoldToParty;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colConditionTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributionChannelId;
    }
}