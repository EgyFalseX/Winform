namespace NICSQLTools
{
    partial class ImportDaysFrm
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
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.ImportBillingDetailsFrmConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.ProgressBarMain = new DevExpress.XtraEditors.ProgressBarControl();
            this.tbLog = new DevExpress.XtraEditors.MemoEdit();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.lblEstTime = new DevExpress.XtraEditors.LabelControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetFileName = new DevExpress.XtraEditors.SimpleButton();
            this.lbcFilePath = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemFiles = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLog = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemProgress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupCommand = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemRemove = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemImport = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItemSpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this._0_3__Route_DetailsTableAdapter = new NICSQLTools.Data.dsDataTableAdapters._0_3__Route_DetailsTableAdapter();
            this._0_6_Customer_HNTableAdapter = new NICSQLTools.Data.dsDataTableAdapters._0_6_Customer_HNTableAdapter();
            this.dsData = new NICSQLTools.Data.dsData();
            this._0_4__Product_DetailsTableAdapter = new NICSQLTools.Data.dsDataTableAdapters._0_4__Product_DetailsTableAdapter();
            this._0_1__Master_AllTableAdapter = new NICSQLTools.Data.dsDataTableAdapters._0_1__Master_AllTableAdapter();
            this.qryBillDocTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.QryBillDocTableAdapter();
            this.SSM = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::NICSQLTools.WaitWindowFrm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ImportBillingDetailsFrmConvertedLayout)).BeginInit();
            this.ImportBillingDetailsFrmConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(551, 346);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 13);
            this.lblCount.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0/0";
            // 
            // ImportBillingDetailsFrmConvertedLayout
            // 
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.ProgressBarMain);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.tbLog);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lblCount);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnImport);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lblEstTime);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnRemove);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnGetFileName);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lbcFilePath);
            this.ImportBillingDetailsFrmConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportBillingDetailsFrmConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ImportBillingDetailsFrmConvertedLayout.Name = "ImportBillingDetailsFrmConvertedLayout";
            this.ImportBillingDetailsFrmConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(987, 330, 315, 464);
            this.ImportBillingDetailsFrmConvertedLayout.OptionsView.UseDefaultDragAndDropRendering = false;
            this.ImportBillingDetailsFrmConvertedLayout.Root = this.layoutControlGroup1;
            this.ImportBillingDetailsFrmConvertedLayout.Size = new System.Drawing.Size(579, 393);
            this.ImportBillingDetailsFrmConvertedLayout.TabIndex = 6;
            // 
            // ProgressBarMain
            // 
            this.ProgressBarMain.Location = new System.Drawing.Point(57, 363);
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new System.Drawing.Size(510, 18);
            this.ProgressBarMain.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.ProgressBarMain.TabIndex = 8;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(241, 154);
            this.tbLog.Name = "tbLog";
            this.tbLog.Properties.ReadOnly = true;
            this.tbLog.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(326, 188);
            this.tbLog.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.tbLog.TabIndex = 6;
            this.tbLog.UseOptimizedRendering = true;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Image = global::NICSQLTools.Properties.Resources.importtodatabase_32x32;
            this.btnImport.Location = new System.Drawing.Point(24, 292);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(201, 38);
            this.btnImport.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import R3";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblEstTime
            // 
            this.lblEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstTime.Location = new System.Drawing.Point(57, 346);
            this.lblEstTime.Name = "lblEstTime";
            this.lblEstTime.Size = new System.Drawing.Size(490, 13);
            this.lblEstTime.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lblEstTime.TabIndex = 4;
            this.lblEstTime.Text = "00:00";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(140, 250);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 38);
            this.btnRemove.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGetFileName
            // 
            this.btnGetFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileName.Location = new System.Drawing.Point(24, 250);
            this.btnGetFileName.Name = "btnGetFileName";
            this.btnGetFileName.Size = new System.Drawing.Size(112, 38);
            this.btnGetFileName.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnGetFileName.TabIndex = 0;
            this.btnGetFileName.Text = "Add Excel File";
            this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
            // 
            // lbcFilePath
            // 
            this.lbcFilePath.HorizontalScrollbar = true;
            this.lbcFilePath.Location = new System.Drawing.Point(12, 12);
            this.lbcFilePath.Name = "lbcFilePath";
            this.lbcFilePath.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcFilePath.Size = new System.Drawing.Size(555, 138);
            this.lbcFilePath.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lbcFilePath.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemFiles,
            this.layoutControlItemLog,
            this.layoutControlItemTime,
            this.layoutControlItemCount,
            this.layoutControlItemProgress,
            this.layoutControlGroupCommand,
            this.emptySpaceItemSpace});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(579, 393);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemFiles
            // 
            this.layoutControlItemFiles.Control = this.lbcFilePath;
            this.layoutControlItemFiles.CustomizationFormText = "Files";
            this.layoutControlItemFiles.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemFiles.MaxSize = new System.Drawing.Size(0, 142);
            this.layoutControlItemFiles.MinSize = new System.Drawing.Size(54, 142);
            this.layoutControlItemFiles.Name = "layoutControlItemFiles";
            this.layoutControlItemFiles.Size = new System.Drawing.Size(559, 142);
            this.layoutControlItemFiles.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemFiles.Text = "Files";
            this.layoutControlItemFiles.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemFiles.TextToControlDistance = 0;
            this.layoutControlItemFiles.TextVisible = false;
            // 
            // layoutControlItemLog
            // 
            this.layoutControlItemLog.Control = this.tbLog;
            this.layoutControlItemLog.CustomizationFormText = "Log";
            this.layoutControlItemLog.Location = new System.Drawing.Point(229, 142);
            this.layoutControlItemLog.Name = "layoutControlItemLog";
            this.layoutControlItemLog.Size = new System.Drawing.Size(330, 192);
            this.layoutControlItemLog.Text = "Log";
            this.layoutControlItemLog.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLog.TextToControlDistance = 0;
            this.layoutControlItemLog.TextVisible = false;
            // 
            // layoutControlItemTime
            // 
            this.layoutControlItemTime.Control = this.lblEstTime;
            this.layoutControlItemTime.CustomizationFormText = "Time";
            this.layoutControlItemTime.Location = new System.Drawing.Point(0, 334);
            this.layoutControlItemTime.MaxSize = new System.Drawing.Size(0, 17);
            this.layoutControlItemTime.MinSize = new System.Drawing.Size(77, 17);
            this.layoutControlItemTime.Name = "layoutControlItemTime";
            this.layoutControlItemTime.Size = new System.Drawing.Size(539, 17);
            this.layoutControlItemTime.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemTime.Text = "Time";
            this.layoutControlItemTime.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemCount
            // 
            this.layoutControlItemCount.Control = this.lblCount;
            this.layoutControlItemCount.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.layoutControlItemCount.CustomizationFormText = "Count";
            this.layoutControlItemCount.Location = new System.Drawing.Point(539, 334);
            this.layoutControlItemCount.Name = "layoutControlItemCount";
            this.layoutControlItemCount.Size = new System.Drawing.Size(20, 17);
            this.layoutControlItemCount.Text = "Count";
            this.layoutControlItemCount.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItemCount.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCount.TextToControlDistance = 0;
            this.layoutControlItemCount.TextVisible = false;
            // 
            // layoutControlItemProgress
            // 
            this.layoutControlItemProgress.Control = this.ProgressBarMain;
            this.layoutControlItemProgress.CustomizationFormText = "Progress";
            this.layoutControlItemProgress.Location = new System.Drawing.Point(0, 351);
            this.layoutControlItemProgress.MaxSize = new System.Drawing.Size(0, 22);
            this.layoutControlItemProgress.MinSize = new System.Drawing.Size(99, 22);
            this.layoutControlItemProgress.Name = "layoutControlItemProgress";
            this.layoutControlItemProgress.Size = new System.Drawing.Size(559, 22);
            this.layoutControlItemProgress.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemProgress.Text = "Progress";
            this.layoutControlItemProgress.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlGroupCommand
            // 
            this.layoutControlGroupCommand.CustomizationFormText = "Command";
            this.layoutControlGroupCommand.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemRemove,
            this.layoutControlItemAdd,
            this.layoutControlItemImport});
            this.layoutControlGroupCommand.Location = new System.Drawing.Point(0, 226);
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
            // emptySpaceItemSpace
            // 
            this.emptySpaceItemSpace.AllowHotTrack = false;
            this.emptySpaceItemSpace.CustomizationFormText = "Space";
            this.emptySpaceItemSpace.Location = new System.Drawing.Point(0, 142);
            this.emptySpaceItemSpace.Name = "emptySpaceItemSpace";
            this.emptySpaceItemSpace.Size = new System.Drawing.Size(229, 84);
            this.emptySpaceItemSpace.Text = "Space";
            this.emptySpaceItemSpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel Files(xlsx)|*.xlsx";
            this.ofd.Multiselect = true;
            // 
            // _0_3__Route_DetailsTableAdapter
            // 
            this._0_3__Route_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // _0_6_Customer_HNTableAdapter
            // 
            this._0_6_Customer_HNTableAdapter.ClearBeforeFill = true;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _0_4__Product_DetailsTableAdapter
            // 
            this._0_4__Product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // _0_1__Master_AllTableAdapter
            // 
            this._0_1__Master_AllTableAdapter.ClearBeforeFill = true;
            // 
            // qryBillDocTableAdapter
            // 
            this.qryBillDocTableAdapter.ClearBeforeFill = true;
            // 
            // ImportDaysFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 393);
            this.Controls.Add(this.ImportBillingDetailsFrmConvertedLayout);
            this.Icon = global::NICSQLTools.Properties.Resources.importtodatabase_16x16;
            this.Name = "ImportDaysFrm";
            this.Text = "Import R3";
            ((System.ComponentModel.ISupportInitialize)(this.ImportBillingDetailsFrmConvertedLayout)).EndInit();
            this.ImportBillingDetailsFrmConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraEditors.LabelControl lblEstTime;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnGetFileName;
        private DevExpress.XtraEditors.ListBoxControl lbcFilePath;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevExpress.XtraLayout.LayoutControl ImportBillingDetailsFrmConvertedLayout;
        private DevExpress.XtraEditors.ProgressBarControl ProgressBarMain;
        private DevExpress.XtraEditors.MemoEdit tbLog;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFiles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRemove;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemProgress;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupCommand;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemSpace;
        private Data.dsDataTableAdapters._0_3__Route_DetailsTableAdapter _0_3__Route_DetailsTableAdapter;
        private Data.dsDataTableAdapters._0_6_Customer_HNTableAdapter _0_6_Customer_HNTableAdapter;
        private Data.dsData dsData;
        private Data.dsDataTableAdapters._0_4__Product_DetailsTableAdapter _0_4__Product_DetailsTableAdapter;
        private Data.dsDataTableAdapters._0_1__Master_AllTableAdapter _0_1__Master_AllTableAdapter;
        private Data.dsDataTableAdapters.QryBillDocTableAdapter qryBillDocTableAdapter;
        private DevExpress.XtraSplashScreen.SplashScreenManager SSM;
    }
}