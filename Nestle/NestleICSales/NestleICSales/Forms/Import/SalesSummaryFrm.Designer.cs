namespace NestleICSales.Forms.Import
{
    partial class SalesSummaryFrm
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
            this.ProgressBarMain = new DevExpress.XtraEditors.ProgressBarControl();
            this.SalesSummaryFrmConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.btnGetFileName = new DevExpress.XtraEditors.SimpleButton();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.lblEstTime = new DevExpress.XtraEditors.LabelControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.tbLog = new DevExpress.XtraEditors.MemoEdit();
            this.lbcFilePath = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemFiles = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupCommand = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemRemove = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemImport = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItemSpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemProgress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLog = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.adpRoute = new NestleICSales.DataSources.dsDataTableAdapters.RoutesTableAdapter();
            this.adpCustomer = new NestleICSales.DataSources.dsDataTableAdapters.CustomerTableAdapter();
            this.dsNM = new NestleICSales.DataSources.dsData();
            this.adpCustHierLevel6Table = new NestleICSales.DataSources.dsDataTableAdapters.CustHierLevel6TableAdapter();
            this.adpCustHierLevel3Table = new NestleICSales.DataSources.dsDataTableAdapters.CustHierLevel3TableAdapter();
            this.adpCustHierLevel4Table = new NestleICSales.DataSources.dsDataTableAdapters.CustHierLevel4TableAdapter();
            this.adpCustHierLevel5Table = new NestleICSales.DataSources.dsDataTableAdapters.CustHierLevel5TableAdapter();
            this.adpDistributionChannelTable = new NestleICSales.DataSources.dsDataTableAdapters.DistributionChannelTableAdapter();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesSummaryFrmConvertedLayout)).BeginInit();
            this.SalesSummaryFrmConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNM)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarMain
            // 
            this.ProgressBarMain.Location = new System.Drawing.Point(57, 339);
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new System.Drawing.Size(535, 18);
            this.ProgressBarMain.StyleController = this.SalesSummaryFrmConvertedLayout;
            this.ProgressBarMain.TabIndex = 0;
            // 
            // SalesSummaryFrmConvertedLayout
            // 
            this.SalesSummaryFrmConvertedLayout.Controls.Add(this.ProgressBarMain);
            this.SalesSummaryFrmConvertedLayout.Controls.Add(this.btnGetFileName);
            this.SalesSummaryFrmConvertedLayout.Controls.Add(this.lblCount);
            this.SalesSummaryFrmConvertedLayout.Controls.Add(this.lblEstTime);
            this.SalesSummaryFrmConvertedLayout.Controls.Add(this.btnImport);
            this.SalesSummaryFrmConvertedLayout.Controls.Add(this.btnRemove);
            this.SalesSummaryFrmConvertedLayout.Controls.Add(this.tbLog);
            this.SalesSummaryFrmConvertedLayout.Controls.Add(this.lbcFilePath);
            this.SalesSummaryFrmConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesSummaryFrmConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.SalesSummaryFrmConvertedLayout.Name = "SalesSummaryFrmConvertedLayout";
            this.SalesSummaryFrmConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(756, 60, 316, 429);
            this.SalesSummaryFrmConvertedLayout.OptionsView.UseDefaultDragAndDropRendering = false;
            this.SalesSummaryFrmConvertedLayout.Root = this.layoutControlGroupRoot;
            this.SalesSummaryFrmConvertedLayout.Size = new System.Drawing.Size(604, 369);
            this.SalesSummaryFrmConvertedLayout.TabIndex = 6;
            // 
            // btnGetFileName
            // 
            this.btnGetFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileName.Image = global::NestleICSales.Properties.Resources.adddatafile_32x32;
            this.btnGetFileName.Location = new System.Drawing.Point(24, 226);
            this.btnGetFileName.Name = "btnGetFileName";
            this.btnGetFileName.Size = new System.Drawing.Size(112, 38);
            this.btnGetFileName.StyleController = this.SalesSummaryFrmConvertedLayout;
            this.btnGetFileName.TabIndex = 0;
            this.btnGetFileName.Text = "Add Excel File";
            this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Location = new System.Drawing.Point(576, 322);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 13);
            this.lblCount.StyleController = this.SalesSummaryFrmConvertedLayout;
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0/0";
            // 
            // lblEstTime
            // 
            this.lblEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstTime.Location = new System.Drawing.Point(39, 322);
            this.lblEstTime.Name = "lblEstTime";
            this.lblEstTime.Size = new System.Drawing.Size(28, 13);
            this.lblEstTime.StyleController = this.SalesSummaryFrmConvertedLayout;
            this.lblEstTime.TabIndex = 4;
            this.lblEstTime.Text = "00:00";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Image = global::NestleICSales.Properties.Resources.importtodatabase_32x32;
            this.btnImport.Location = new System.Drawing.Point(24, 268);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(201, 38);
            this.btnImport.StyleController = this.SalesSummaryFrmConvertedLayout;
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Sales Summary";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Image = global::NestleICSales.Properties.Resources.removedatafile_32x32;
            this.btnRemove.Location = new System.Drawing.Point(140, 226);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 38);
            this.btnRemove.StyleController = this.SalesSummaryFrmConvertedLayout;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(241, 154);
            this.tbLog.Name = "tbLog";
            this.tbLog.Properties.ReadOnly = true;
            this.tbLog.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(351, 164);
            this.tbLog.StyleController = this.SalesSummaryFrmConvertedLayout;
            this.tbLog.TabIndex = 4;
            this.tbLog.UseOptimizedRendering = true;
            // 
            // lbcFilePath
            // 
            this.lbcFilePath.HorizontalScrollbar = true;
            this.lbcFilePath.Location = new System.Drawing.Point(12, 12);
            this.lbcFilePath.Name = "lbcFilePath";
            this.lbcFilePath.Size = new System.Drawing.Size(580, 138);
            this.lbcFilePath.StyleController = this.SalesSummaryFrmConvertedLayout;
            this.lbcFilePath.TabIndex = 2;
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.CustomizationFormText = "Root";
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemFiles,
            this.layoutControlGroupCommand,
            this.emptySpaceItemSpace,
            this.layoutControlItemProgress,
            this.layoutControlItemLog,
            this.layoutControlItemCount,
            this.layoutControlItemTime});
            this.layoutControlGroupRoot.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(604, 369);
            this.layoutControlGroupRoot.Text = "Root";
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlItemFiles
            // 
            this.layoutControlItemFiles.Control = this.lbcFilePath;
            this.layoutControlItemFiles.CustomizationFormText = "Files";
            this.layoutControlItemFiles.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemFiles.MaxSize = new System.Drawing.Size(0, 142);
            this.layoutControlItemFiles.MinSize = new System.Drawing.Size(54, 142);
            this.layoutControlItemFiles.Name = "layoutControlItemFiles";
            this.layoutControlItemFiles.Size = new System.Drawing.Size(584, 142);
            this.layoutControlItemFiles.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemFiles.Text = "Files";
            this.layoutControlItemFiles.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemFiles.TextToControlDistance = 0;
            this.layoutControlItemFiles.TextVisible = false;
            // 
            // layoutControlGroupCommand
            // 
            this.layoutControlGroupCommand.CustomizationFormText = "Command";
            this.layoutControlGroupCommand.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemRemove,
            this.layoutControlItemImport,
            this.layoutControlItemAdd});
            this.layoutControlGroupCommand.Location = new System.Drawing.Point(0, 202);
            this.layoutControlGroupCommand.Name = "layoutControlGroupCommand";
            this.layoutControlGroupCommand.Size = new System.Drawing.Size(229, 108);
            this.layoutControlGroupCommand.Text = "Command";
            this.layoutControlGroupCommand.TextVisible = false;
            // 
            // layoutControlItemRemove
            // 
            this.layoutControlItemRemove.Control = this.btnRemove;
            this.layoutControlItemRemove.CustomizationFormText = "Remove";
            this.layoutControlItemRemove.Location = new System.Drawing.Point(116, 0);
            this.layoutControlItemRemove.MaxSize = new System.Drawing.Size(89, 42);
            this.layoutControlItemRemove.MinSize = new System.Drawing.Size(89, 42);
            this.layoutControlItemRemove.Name = "layoutControlItemRemove";
            this.layoutControlItemRemove.Size = new System.Drawing.Size(89, 42);
            this.layoutControlItemRemove.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemRemove.Text = "Remove";
            this.layoutControlItemRemove.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemRemove.TextToControlDistance = 0;
            this.layoutControlItemRemove.TextVisible = false;
            // 
            // layoutControlItemImport
            // 
            this.layoutControlItemImport.Control = this.btnImport;
            this.layoutControlItemImport.CustomizationFormText = "Import";
            this.layoutControlItemImport.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItemImport.MaxSize = new System.Drawing.Size(205, 42);
            this.layoutControlItemImport.MinSize = new System.Drawing.Size(205, 42);
            this.layoutControlItemImport.Name = "layoutControlItemImport";
            this.layoutControlItemImport.Size = new System.Drawing.Size(205, 42);
            this.layoutControlItemImport.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemImport.Text = "Import";
            this.layoutControlItemImport.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemImport.TextToControlDistance = 0;
            this.layoutControlItemImport.TextVisible = false;
            // 
            // layoutControlItemAdd
            // 
            this.layoutControlItemAdd.Control = this.btnGetFileName;
            this.layoutControlItemAdd.CustomizationFormText = "Add";
            this.layoutControlItemAdd.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemAdd.MaxSize = new System.Drawing.Size(116, 42);
            this.layoutControlItemAdd.MinSize = new System.Drawing.Size(116, 42);
            this.layoutControlItemAdd.Name = "layoutControlItemAdd";
            this.layoutControlItemAdd.Size = new System.Drawing.Size(116, 42);
            this.layoutControlItemAdd.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemAdd.Text = "Add";
            this.layoutControlItemAdd.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemAdd.TextToControlDistance = 0;
            this.layoutControlItemAdd.TextVisible = false;
            // 
            // emptySpaceItemSpace
            // 
            this.emptySpaceItemSpace.AllowHotTrack = false;
            this.emptySpaceItemSpace.CustomizationFormText = "Space";
            this.emptySpaceItemSpace.Location = new System.Drawing.Point(0, 142);
            this.emptySpaceItemSpace.Name = "emptySpaceItemSpace";
            this.emptySpaceItemSpace.Size = new System.Drawing.Size(229, 60);
            this.emptySpaceItemSpace.Text = "Space";
            this.emptySpaceItemSpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemProgress
            // 
            this.layoutControlItemProgress.Control = this.ProgressBarMain;
            this.layoutControlItemProgress.CustomizationFormText = "Progress";
            this.layoutControlItemProgress.Location = new System.Drawing.Point(0, 327);
            this.layoutControlItemProgress.Name = "layoutControlItemProgress";
            this.layoutControlItemProgress.Size = new System.Drawing.Size(584, 22);
            this.layoutControlItemProgress.Text = "Progress";
            this.layoutControlItemProgress.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemLog
            // 
            this.layoutControlItemLog.Control = this.tbLog;
            this.layoutControlItemLog.CustomizationFormText = "Log";
            this.layoutControlItemLog.Location = new System.Drawing.Point(229, 142);
            this.layoutControlItemLog.Name = "layoutControlItemLog";
            this.layoutControlItemLog.Size = new System.Drawing.Size(355, 168);
            this.layoutControlItemLog.Text = "Log";
            this.layoutControlItemLog.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLog.TextToControlDistance = 0;
            this.layoutControlItemLog.TextVisible = false;
            // 
            // layoutControlItemCount
            // 
            this.layoutControlItemCount.Control = this.lblCount;
            this.layoutControlItemCount.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.layoutControlItemCount.CustomizationFormText = "Count";
            this.layoutControlItemCount.Location = new System.Drawing.Point(59, 310);
            this.layoutControlItemCount.Name = "layoutControlItemCount";
            this.layoutControlItemCount.Size = new System.Drawing.Size(525, 17);
            this.layoutControlItemCount.Text = "Count";
            this.layoutControlItemCount.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItemCount.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCount.TextToControlDistance = 0;
            this.layoutControlItemCount.TextVisible = false;
            // 
            // layoutControlItemTime
            // 
            this.layoutControlItemTime.Control = this.lblEstTime;
            this.layoutControlItemTime.CustomizationFormText = "Time";
            this.layoutControlItemTime.Location = new System.Drawing.Point(0, 310);
            this.layoutControlItemTime.Name = "layoutControlItemTime";
            this.layoutControlItemTime.Size = new System.Drawing.Size(59, 17);
            this.layoutControlItemTime.Text = "Time";
            this.layoutControlItemTime.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItemTime.TextSize = new System.Drawing.Size(22, 13);
            this.layoutControlItemTime.TextToControlDistance = 5;
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel Files(xlsx)|*.xlsx";
            // 
            // adpRoute
            // 
            this.adpRoute.ClearBeforeFill = true;
            // 
            // adpCustomer
            // 
            this.adpCustomer.ClearBeforeFill = true;
            // 
            // dsNM
            // 
            this.dsNM.DataSetName = "dsNM";
            this.dsNM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adpCustHierLevel6Table
            // 
            this.adpCustHierLevel6Table.ClearBeforeFill = true;
            // 
            // adpCustHierLevel3Table
            // 
            this.adpCustHierLevel3Table.ClearBeforeFill = true;
            // 
            // adpCustHierLevel4Table
            // 
            this.adpCustHierLevel4Table.ClearBeforeFill = true;
            // 
            // adpCustHierLevel5Table
            // 
            this.adpCustHierLevel5Table.ClearBeforeFill = true;
            // 
            // adpDistributionChannelTable
            // 
            this.adpDistributionChannelTable.ClearBeforeFill = true;
            // 
            // SalesSummaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 369);
            this.Controls.Add(this.SalesSummaryFrmConvertedLayout);
            this.Icon = global::NestleICSales.Properties.Resources.importtodatabase_16x16;
            this.Name = "SalesSummaryFrm";
            this.Text = "Import Sales Summary";
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesSummaryFrmConvertedLayout)).EndInit();
            this.SalesSummaryFrmConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl ProgressBarMain;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraEditors.LabelControl lblEstTime;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnGetFileName;
        private DevExpress.XtraEditors.ListBoxControl lbcFilePath;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DataSources.dsDataTableAdapters.RoutesTableAdapter adpRoute;
        private DataSources.dsDataTableAdapters.CustomerTableAdapter adpCustomer;
        private DataSources.dsData dsNM;
        private DevExpress.XtraEditors.MemoEdit tbLog;
        private DataSources.dsDataTableAdapters.CustHierLevel6TableAdapter adpCustHierLevel6Table;
        private DataSources.dsDataTableAdapters.CustHierLevel3TableAdapter adpCustHierLevel3Table;
        private DataSources.dsDataTableAdapters.CustHierLevel4TableAdapter adpCustHierLevel4Table;
        private DataSources.dsDataTableAdapters.CustHierLevel5TableAdapter adpCustHierLevel5Table;
        private DataSources.dsDataTableAdapters.DistributionChannelTableAdapter adpDistributionChannelTable;
        private DevExpress.XtraLayout.LayoutControl SalesSummaryFrmConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFiles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLog;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupCommand;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRemove;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAdd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemSpace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemProgress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCount;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}