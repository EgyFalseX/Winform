namespace NestleICSales.Forms.Import
{
    partial class ImportFrm
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
            this.pnlProgress = new DevExpress.XtraEditors.PanelControl();
            this.ProgressBarMain = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.lblEstTime = new DevExpress.XtraEditors.LabelControl();
            this.btnViewXml = new DevExpress.XtraEditors.SimpleButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.GridControlData = new DevExpress.XtraGrid.GridControl();
            this.GridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GLUEReportType = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewExcelFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnFromExcel = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPageImporting = new DevExpress.XtraTab.XtraTabPage();
            this.btnImportRoute = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportEmpExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportEmp = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportMaster = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPageRouteCustomerAssignment = new DevExpress.XtraTab.XtraTabPage();
            this.customerTableAdapter = new NestleICSales.DataSources.dsDataTableAdapters.CustomerTableAdapter();
            this.dsNM = new NestleICSales.DataSources.dsData();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgress)).BeginInit();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLUEReportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPageImporting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNM)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.ProgressBarMain);
            this.pnlProgress.Controls.Add(this.lblCount);
            this.pnlProgress.Controls.Add(this.lblEstTime);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgress.Location = new System.Drawing.Point(0, 360);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(925, 50);
            this.pnlProgress.TabIndex = 0;
            // 
            // ProgressBarMain
            // 
            this.ProgressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBarMain.Location = new System.Drawing.Point(2, 25);
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new System.Drawing.Size(921, 23);
            this.ProgressBarMain.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Location = new System.Drawing.Point(821, 6);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0/0";
            // 
            // lblEstTime
            // 
            this.lblEstTime.Location = new System.Drawing.Point(5, 6);
            this.lblEstTime.Name = "lblEstTime";
            this.lblEstTime.Size = new System.Drawing.Size(28, 13);
            this.lblEstTime.TabIndex = 4;
            this.lblEstTime.Text = "00:00";
            // 
            // btnViewXml
            // 
            this.btnViewXml.Location = new System.Drawing.Point(69, 38);
            this.btnViewXml.Name = "btnViewXml";
            this.btnViewXml.Size = new System.Drawing.Size(178, 23);
            this.btnViewXml.TabIndex = 1;
            this.btnViewXml.Text = "View";
            this.btnViewXml.Click += new System.EventHandler(this.btnViewXml_Click);
            // 
            // GridControlData
            // 
            this.GridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlData.Location = new System.Drawing.Point(3, 67);
            this.GridControlData.MainView = this.GridViewData;
            this.GridControlData.Name = "GridControlData";
            this.GridControlData.Size = new System.Drawing.Size(889, 244);
            this.GridControlData.TabIndex = 2;
            this.GridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewData});
            // 
            // GridViewData
            // 
            this.GridViewData.GridControl = this.GridControlData;
            this.GridViewData.Name = "GridViewData";
            this.GridViewData.OptionsView.ColumnAutoWidth = false;
            this.GridViewData.OptionsView.ShowAutoFilterRow = true;
            this.GridViewData.OptionsView.ShowFooter = true;
            // 
            // GLUEReportType
            // 
            this.GLUEReportType.EditValue = "";
            this.GLUEReportType.Location = new System.Drawing.Point(69, 12);
            this.GLUEReportType.Name = "GLUEReportType";
            this.GLUEReportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GLUEReportType.Properties.DisplayMember = "FormationName";
            this.GLUEReportType.Properties.NullText = "";
            this.GLUEReportType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.GLUEReportType.Properties.ValueMember = "FileType";
            this.GLUEReportType.Properties.View = this.gridLookUpEdit1View;
            this.GLUEReportType.Size = new System.Drawing.Size(178, 20);
            this.GLUEReportType.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Report Name";
            this.gridColumn1.FieldName = "FormationName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Report Type";
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControlMain.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControlMain.Size = new System.Drawing.Size(901, 342);
            this.xtraTabControlMain.TabIndex = 5;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPageImporting,
            this.xtraTabPageRouteCustomerAssignment});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnNext);
            this.xtraTabPage1.Controls.Add(this.btnViewExcelFile);
            this.xtraTabPage1.Controls.Add(this.btnFromExcel);
            this.xtraTabPage1.Controls.Add(this.btnViewXml);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.GridControlData);
            this.xtraTabPage1.Controls.Add(this.GLUEReportType);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(895, 314);
            this.xtraTabPage1.Text = "Xml File Viewer";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(714, 38);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(178, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnViewExcelFile
            // 
            this.btnViewExcelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewExcelFile.Location = new System.Drawing.Point(714, 10);
            this.btnViewExcelFile.Name = "btnViewExcelFile";
            this.btnViewExcelFile.Size = new System.Drawing.Size(178, 23);
            this.btnViewExcelFile.TabIndex = 5;
            this.btnViewExcelFile.Text = "View";
            this.btnViewExcelFile.Click += new System.EventHandler(this.btnViewExcelFile_Click);
            // 
            // btnFromExcel
            // 
            this.btnFromExcel.Location = new System.Drawing.Point(324, 38);
            this.btnFromExcel.Name = "btnFromExcel";
            this.btnFromExcel.Size = new System.Drawing.Size(178, 23);
            this.btnFromExcel.TabIndex = 1;
            this.btnFromExcel.Text = "Excel";
            this.btnFromExcel.Click += new System.EventHandler(this.btnFromExcel_Click);
            // 
            // xtraTabPageImporting
            // 
            this.xtraTabPageImporting.Controls.Add(this.btnImportRoute);
            this.xtraTabPageImporting.Controls.Add(this.btnImportEmpExcel);
            this.xtraTabPageImporting.Controls.Add(this.btnImportEmp);
            this.xtraTabPageImporting.Controls.Add(this.btnImportProduct);
            this.xtraTabPageImporting.Controls.Add(this.btnImportMaster);
            this.xtraTabPageImporting.Controls.Add(this.btnImportCustomer);
            this.xtraTabPageImporting.Name = "xtraTabPageImporting";
            this.xtraTabPageImporting.Size = new System.Drawing.Size(895, 314);
            this.xtraTabPageImporting.Text = "Importing";
            // 
            // btnImportRoute
            // 
            this.btnImportRoute.Location = new System.Drawing.Point(43, 163);
            this.btnImportRoute.Name = "btnImportRoute";
            this.btnImportRoute.Size = new System.Drawing.Size(178, 23);
            this.btnImportRoute.TabIndex = 7;
            this.btnImportRoute.Text = "Import Route";
            this.btnImportRoute.Click += new System.EventHandler(this.btnImportRoute_Click);
            // 
            // btnImportEmpExcel
            // 
            this.btnImportEmpExcel.Location = new System.Drawing.Point(227, 121);
            this.btnImportEmpExcel.Name = "btnImportEmpExcel";
            this.btnImportEmpExcel.Size = new System.Drawing.Size(178, 23);
            this.btnImportEmpExcel.TabIndex = 7;
            this.btnImportEmpExcel.Text = "Import Emp (Excel)";
            this.btnImportEmpExcel.Click += new System.EventHandler(this.btnImportEmpExcel_Click);
            // 
            // btnImportEmp
            // 
            this.btnImportEmp.Location = new System.Drawing.Point(43, 121);
            this.btnImportEmp.Name = "btnImportEmp";
            this.btnImportEmp.Size = new System.Drawing.Size(178, 23);
            this.btnImportEmp.TabIndex = 7;
            this.btnImportEmp.Text = "Import Emp";
            this.btnImportEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnImportProduct
            // 
            this.btnImportProduct.Location = new System.Drawing.Point(43, 79);
            this.btnImportProduct.Name = "btnImportProduct";
            this.btnImportProduct.Size = new System.Drawing.Size(178, 23);
            this.btnImportProduct.TabIndex = 4;
            this.btnImportProduct.Text = "Import Product";
            this.btnImportProduct.Click += new System.EventHandler(this.btnImportProduct_Click);
            // 
            // btnImportMaster
            // 
            this.btnImportMaster.Location = new System.Drawing.Point(43, 202);
            this.btnImportMaster.Name = "btnImportMaster";
            this.btnImportMaster.Size = new System.Drawing.Size(178, 23);
            this.btnImportMaster.TabIndex = 3;
            this.btnImportMaster.Text = "Import Master";
            this.btnImportMaster.Click += new System.EventHandler(this.btnImportMaster_Click);
            // 
            // btnImportCustomer
            // 
            this.btnImportCustomer.Location = new System.Drawing.Point(43, 37);
            this.btnImportCustomer.Name = "btnImportCustomer";
            this.btnImportCustomer.Size = new System.Drawing.Size(178, 23);
            this.btnImportCustomer.TabIndex = 3;
            this.btnImportCustomer.Text = "Import Customers";
            this.btnImportCustomer.Click += new System.EventHandler(this.btnImportCustomer_Click);
            // 
            // xtraTabPageRouteCustomerAssignment
            // 
            this.xtraTabPageRouteCustomerAssignment.Name = "xtraTabPageRouteCustomerAssignment";
            this.xtraTabPageRouteCustomerAssignment.Size = new System.Drawing.Size(895, 314);
            this.xtraTabPageRouteCustomerAssignment.Text = "Route Customer Assignment";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // dsNM
            // 
            this.dsNM.DataSetName = "dsNM";
            this.dsNM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ImportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 410);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.pnlProgress);
            this.Icon = global::NestleICSales.Properties.Resources.ImportData;
            this.Name = "ImportFrm";
            this.Text = "Import Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgress)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLUEReportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPageImporting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsNM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlProgress;
        private DevExpress.XtraEditors.ProgressBarControl ProgressBarMain;
        private DevExpress.XtraEditors.SimpleButton btnViewXml;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevExpress.XtraGrid.GridControl GridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewData;
        private DevExpress.XtraEditors.GridLookUpEdit GLUEReportType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DataSources.dsDataTableAdapters.CustomerTableAdapter customerTableAdapter;
        private DevExpress.XtraEditors.LabelControl lblEstTime;
        private DevExpress.XtraEditors.SimpleButton btnViewExcelFile;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageImporting;
        private DevExpress.XtraEditors.SimpleButton btnImportEmp;
        private DevExpress.XtraEditors.SimpleButton btnImportProduct;
        private DevExpress.XtraEditors.SimpleButton btnImportCustomer;
        private DevExpress.XtraEditors.SimpleButton btnImportRoute;
        private DevExpress.XtraEditors.SimpleButton btnFromExcel;
        private DevExpress.XtraEditors.SimpleButton btnImportEmpExcel;
        private DevExpress.XtraEditors.SimpleButton btnImportMaster;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageRouteCustomerAssignment;
        private DataSources.dsData dsNM;
    }
}