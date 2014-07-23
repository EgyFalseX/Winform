namespace NestleICSales.Forms.Import
{
    partial class ImportEquipmentFrm
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
            this.ImportEquipmentFrmConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.btnGetFileName = new DevExpress.XtraEditors.SimpleButton();
            this.lblEstTime = new DevExpress.XtraEditors.LabelControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.tbLog = new DevExpress.XtraEditors.MemoEdit();
            this.lbcFilePath = new DevExpress.XtraEditors.ListBoxControl();
            this.LayoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemFiles = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLog = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupCommand = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemImport = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemRemove = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItemSpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemProgress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.adpCustomer = new NestleICSales.DataSources.dsDataTableAdapters.CustomerTableAdapter();
            this.dsNM = new NestleICSales.DataSources.dsData();
            this.AdpEquipment = new NestleICSales.DataSources.dsDataTableAdapters.EquipmentTableAdapter();
            this.AdpProductBrand = new NestleICSales.DataSources.dsDataTableAdapters.ProductBrandTableAdapter();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportEquipmentFrmConvertedLayout)).BeginInit();
            this.ImportEquipmentFrmConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNM)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarMain
            // 
            this.ProgressBarMain.Location = new System.Drawing.Point(57, 369);
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new System.Drawing.Size(510, 20);
            this.ProgressBarMain.StyleController = this.ImportEquipmentFrmConvertedLayout;
            this.ProgressBarMain.TabIndex = 0;
            // 
            // ImportEquipmentFrmConvertedLayout
            // 
            this.ImportEquipmentFrmConvertedLayout.Controls.Add(this.ProgressBarMain);
            this.ImportEquipmentFrmConvertedLayout.Controls.Add(this.btnRemove);
            this.ImportEquipmentFrmConvertedLayout.Controls.Add(this.lblCount);
            this.ImportEquipmentFrmConvertedLayout.Controls.Add(this.btnGetFileName);
            this.ImportEquipmentFrmConvertedLayout.Controls.Add(this.lblEstTime);
            this.ImportEquipmentFrmConvertedLayout.Controls.Add(this.btnImport);
            this.ImportEquipmentFrmConvertedLayout.Controls.Add(this.tbLog);
            this.ImportEquipmentFrmConvertedLayout.Controls.Add(this.lbcFilePath);
            this.ImportEquipmentFrmConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportEquipmentFrmConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ImportEquipmentFrmConvertedLayout.Name = "ImportEquipmentFrmConvertedLayout";
            this.ImportEquipmentFrmConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(666, 53, 314, 550);
            this.ImportEquipmentFrmConvertedLayout.OptionsView.UseDefaultDragAndDropRendering = false;
            this.ImportEquipmentFrmConvertedLayout.Root = this.LayoutControlGroup1;
            this.ImportEquipmentFrmConvertedLayout.Size = new System.Drawing.Size(579, 401);
            this.ImportEquipmentFrmConvertedLayout.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Image = global::NestleICSales.Properties.Resources.removedatafile_32x32;
            this.btnRemove.Location = new System.Drawing.Point(140, 256);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 38);
            this.btnRemove.StyleController = this.ImportEquipmentFrmConvertedLayout;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Location = new System.Drawing.Point(551, 352);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 13);
            this.lblCount.StyleController = this.ImportEquipmentFrmConvertedLayout;
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0/0";
            // 
            // btnGetFileName
            // 
            this.btnGetFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileName.Image = global::NestleICSales.Properties.Resources.adddatafile_32x32;
            this.btnGetFileName.Location = new System.Drawing.Point(24, 256);
            this.btnGetFileName.Name = "btnGetFileName";
            this.btnGetFileName.Size = new System.Drawing.Size(112, 38);
            this.btnGetFileName.StyleController = this.ImportEquipmentFrmConvertedLayout;
            this.btnGetFileName.TabIndex = 0;
            this.btnGetFileName.Text = "Add Excel File";
            this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
            // 
            // lblEstTime
            // 
            this.lblEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstTime.Location = new System.Drawing.Point(39, 352);
            this.lblEstTime.Name = "lblEstTime";
            this.lblEstTime.Size = new System.Drawing.Size(46, 13);
            this.lblEstTime.StyleController = this.ImportEquipmentFrmConvertedLayout;
            this.lblEstTime.TabIndex = 4;
            this.lblEstTime.Text = "00:00";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Image = global::NestleICSales.Properties.Resources.importtodatabase_32x32;
            this.btnImport.Location = new System.Drawing.Point(24, 298);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(201, 38);
            this.btnImport.StyleController = this.ImportEquipmentFrmConvertedLayout;
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Equipment";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(241, 154);
            this.tbLog.Name = "tbLog";
            this.tbLog.Properties.ReadOnly = true;
            this.tbLog.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(326, 194);
            this.tbLog.StyleController = this.ImportEquipmentFrmConvertedLayout;
            this.tbLog.TabIndex = 4;
            this.tbLog.UseOptimizedRendering = true;
            // 
            // lbcFilePath
            // 
            this.lbcFilePath.HorizontalScrollbar = true;
            this.lbcFilePath.Location = new System.Drawing.Point(12, 12);
            this.lbcFilePath.Name = "lbcFilePath";
            this.lbcFilePath.Size = new System.Drawing.Size(555, 138);
            this.lbcFilePath.StyleController = this.ImportEquipmentFrmConvertedLayout;
            this.lbcFilePath.TabIndex = 2;
            // 
            // LayoutControlGroup1
            // 
            this.LayoutControlGroup1.CustomizationFormText = "Root";
            this.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LayoutControlGroup1.GroupBordersVisible = false;
            this.LayoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemFiles,
            this.layoutControlItemLog,
            this.layoutControlGroupCommand,
            this.emptySpaceItemSpace,
            this.layoutControlItemProgress,
            this.layoutControlItemCount,
            this.layoutControlItemTime});
            this.LayoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlGroup1.Name = "LayoutControlGroup1";
            this.LayoutControlGroup1.Size = new System.Drawing.Size(579, 401);
            this.LayoutControlGroup1.Text = "Root";
            this.LayoutControlGroup1.TextVisible = false;
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
            this.layoutControlItemLog.Size = new System.Drawing.Size(330, 198);
            this.layoutControlItemLog.Text = "Log";
            this.layoutControlItemLog.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLog.TextToControlDistance = 0;
            this.layoutControlItemLog.TextVisible = false;
            // 
            // layoutControlGroupCommand
            // 
            this.layoutControlGroupCommand.CustomizationFormText = "Command";
            this.layoutControlGroupCommand.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemImport,
            this.layoutControlItemAdd,
            this.layoutControlItemRemove});
            this.layoutControlGroupCommand.Location = new System.Drawing.Point(0, 232);
            this.layoutControlGroupCommand.Name = "layoutControlGroupCommand";
            this.layoutControlGroupCommand.Size = new System.Drawing.Size(229, 108);
            this.layoutControlGroupCommand.Text = "Command";
            this.layoutControlGroupCommand.TextVisible = false;
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
            // emptySpaceItemSpace
            // 
            this.emptySpaceItemSpace.AllowHotTrack = false;
            this.emptySpaceItemSpace.CustomizationFormText = "Space";
            this.emptySpaceItemSpace.Location = new System.Drawing.Point(0, 142);
            this.emptySpaceItemSpace.Name = "emptySpaceItemSpace";
            this.emptySpaceItemSpace.Size = new System.Drawing.Size(229, 90);
            this.emptySpaceItemSpace.Text = "Space";
            this.emptySpaceItemSpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemProgress
            // 
            this.layoutControlItemProgress.Control = this.ProgressBarMain;
            this.layoutControlItemProgress.CustomizationFormText = "Progress";
            this.layoutControlItemProgress.Location = new System.Drawing.Point(0, 357);
            this.layoutControlItemProgress.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItemProgress.MinSize = new System.Drawing.Size(99, 24);
            this.layoutControlItemProgress.Name = "layoutControlItemProgress";
            this.layoutControlItemProgress.Size = new System.Drawing.Size(559, 24);
            this.layoutControlItemProgress.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemProgress.Text = "Progress";
            this.layoutControlItemProgress.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemCount
            // 
            this.layoutControlItemCount.Control = this.lblCount;
            this.layoutControlItemCount.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.layoutControlItemCount.CustomizationFormText = "Count";
            this.layoutControlItemCount.Location = new System.Drawing.Point(77, 340);
            this.layoutControlItemCount.Name = "layoutControlItemCount";
            this.layoutControlItemCount.Size = new System.Drawing.Size(482, 17);
            this.layoutControlItemCount.Text = "Count";
            this.layoutControlItemCount.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItemCount.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItemCount.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCount.TextToControlDistance = 0;
            this.layoutControlItemCount.TextVisible = false;
            // 
            // layoutControlItemTime
            // 
            this.layoutControlItemTime.Control = this.lblEstTime;
            this.layoutControlItemTime.CustomizationFormText = "Time";
            this.layoutControlItemTime.Location = new System.Drawing.Point(0, 340);
            this.layoutControlItemTime.MaxSize = new System.Drawing.Size(77, 17);
            this.layoutControlItemTime.MinSize = new System.Drawing.Size(77, 17);
            this.layoutControlItemTime.Name = "layoutControlItemTime";
            this.layoutControlItemTime.Size = new System.Drawing.Size(77, 17);
            this.layoutControlItemTime.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemTime.Text = "Time";
            this.layoutControlItemTime.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItemTime.TextSize = new System.Drawing.Size(22, 13);
            this.layoutControlItemTime.TextToControlDistance = 5;
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel Files(xlsx)|*.xlsx";
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
            // AdpEquipment
            // 
            this.AdpEquipment.ClearBeforeFill = true;
            // 
            // AdpProductBrand
            // 
            this.AdpProductBrand.ClearBeforeFill = true;
            // 
            // ImportEquipmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 401);
            this.Controls.Add(this.ImportEquipmentFrmConvertedLayout);
            this.Icon = global::NestleICSales.Properties.Resources.importtodatabase_16x16;
            this.Name = "ImportEquipmentFrm";
            this.Text = "Import Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportEquipmentFrmConvertedLayout)).EndInit();
            this.ImportEquipmentFrmConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).EndInit();
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
        private DataSources.dsDataTableAdapters.CustomerTableAdapter adpCustomer;
        private DataSources.dsData dsNM;
        private DevExpress.XtraEditors.MemoEdit tbLog;
        private DataSources.dsDataTableAdapters.EquipmentTableAdapter AdpEquipment;
        private DataSources.dsDataTableAdapters.ProductBrandTableAdapter AdpProductBrand;
        private DevExpress.XtraLayout.LayoutControl ImportEquipmentFrmConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFiles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLog;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupCommand;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRemove;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemSpace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemProgress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTime;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}