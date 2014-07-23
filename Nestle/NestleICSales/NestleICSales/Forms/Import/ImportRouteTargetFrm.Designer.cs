namespace NestleICSales.Forms.Import
{
    partial class ImportRouteTargetFrm
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
            this.MainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lblEstTime = new DevExpress.XtraEditors.LabelControl();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetFileName = new DevExpress.XtraEditors.SimpleButton();
            this.seMonth = new DevExpress.XtraEditors.SpinEdit();
            this.seYear = new DevExpress.XtraEditors.SpinEdit();
            this.tbLog = new DevExpress.XtraEditors.MemoEdit();
            this.lbcFilePath = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemLog = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemProgress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupCommands = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemImport = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemYear = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemMonth = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemRemove = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemFiles = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitterItemMid = new DevExpress.XtraLayout.SplitterItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.adpRoute = new NestleICSales.DataSources.dsDataTableAdapters.RoutesTableAdapter();
            this.dsNM = new NestleICSales.DataSources.dsData();
            this.layoutConverterMain = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.adpRouteTargetFormulaTable = new NestleICSales.DataSources.dsDataTableAdapters.RouteTargetFormulaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutControl)).BeginInit();
            this.MainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItemMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNM)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarMain
            // 
            this.ProgressBarMain.Location = new System.Drawing.Point(57, 332);
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new System.Drawing.Size(689, 18);
            this.ProgressBarMain.StyleController = this.MainLayoutControl;
            this.ProgressBarMain.TabIndex = 0;
            // 
            // MainLayoutControl
            // 
            this.MainLayoutControl.Controls.Add(this.lblEstTime);
            this.MainLayoutControl.Controls.Add(this.lblCount);
            this.MainLayoutControl.Controls.Add(this.ProgressBarMain);
            this.MainLayoutControl.Controls.Add(this.btnImport);
            this.MainLayoutControl.Controls.Add(this.btnRemove);
            this.MainLayoutControl.Controls.Add(this.btnGetFileName);
            this.MainLayoutControl.Controls.Add(this.seMonth);
            this.MainLayoutControl.Controls.Add(this.seYear);
            this.MainLayoutControl.Controls.Add(this.tbLog);
            this.MainLayoutControl.Controls.Add(this.lbcFilePath);
            this.MainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutControl.Name = "MainLayoutControl";
            this.MainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1024, 327, 330, 453);
            this.MainLayoutControl.Root = this.layoutControlGroup1;
            this.MainLayoutControl.Size = new System.Drawing.Size(758, 362);
            this.MainLayoutControl.TabIndex = 6;
            // 
            // lblEstTime
            // 
            this.lblEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstTime.Location = new System.Drawing.Point(57, 315);
            this.lblEstTime.Name = "lblEstTime";
            this.lblEstTime.Size = new System.Drawing.Size(28, 13);
            this.lblEstTime.StyleController = this.MainLayoutControl;
            this.lblEstTime.TabIndex = 4;
            this.lblEstTime.Text = "00:00";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Location = new System.Drawing.Point(730, 315);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 13);
            this.lblCount.StyleController = this.MainLayoutControl;
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0/0";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Image = global::NestleICSales.Properties.Resources.importtodatabase_32x32;
            this.btnImport.Location = new System.Drawing.Point(24, 261);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(201, 38);
            this.btnImport.StyleController = this.MainLayoutControl;
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import Route Target";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Image = global::NestleICSales.Properties.Resources.removedatafile_32x32;
            this.btnRemove.Location = new System.Drawing.Point(140, 219);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 38);
            this.btnRemove.StyleController = this.MainLayoutControl;
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGetFileName
            // 
            this.btnGetFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileName.Image = global::NestleICSales.Properties.Resources.adddatafile_32x32;
            this.btnGetFileName.Location = new System.Drawing.Point(24, 219);
            this.btnGetFileName.Name = "btnGetFileName";
            this.btnGetFileName.Size = new System.Drawing.Size(112, 38);
            this.btnGetFileName.StyleController = this.MainLayoutControl;
            this.btnGetFileName.TabIndex = 2;
            this.btnGetFileName.Text = "Add Excel File";
            this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
            // 
            // seMonth
            // 
            this.seMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seMonth.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seMonth.Location = new System.Drawing.Point(69, 195);
            this.seMonth.Name = "seMonth";
            this.seMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seMonth.Properties.DisplayFormat.FormatString = "d";
            this.seMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seMonth.Properties.EditFormat.FormatString = "d";
            this.seMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seMonth.Properties.Mask.EditMask = "d";
            this.seMonth.Properties.MaxLength = 2;
            this.seMonth.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.seMonth.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seMonth.Size = new System.Drawing.Size(156, 20);
            this.seMonth.StyleController = this.MainLayoutControl;
            this.seMonth.TabIndex = 1;
            // 
            // seYear
            // 
            this.seYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seYear.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.seYear.Location = new System.Drawing.Point(69, 171);
            this.seYear.Name = "seYear";
            this.seYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seYear.Properties.DisplayFormat.FormatString = "d";
            this.seYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seYear.Properties.EditFormat.FormatString = "d";
            this.seYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seYear.Properties.Mask.EditMask = "d";
            this.seYear.Properties.MaxLength = 4;
            this.seYear.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.seYear.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.seYear.Size = new System.Drawing.Size(156, 20);
            this.seYear.StyleController = this.MainLayoutControl;
            this.seYear.TabIndex = 0;
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(241, 90);
            this.tbLog.Name = "tbLog";
            this.tbLog.Properties.ReadOnly = true;
            this.tbLog.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(505, 221);
            this.tbLog.StyleController = this.MainLayoutControl;
            this.tbLog.TabIndex = 2;
            this.tbLog.UseOptimizedRendering = true;
            // 
            // lbcFilePath
            // 
            this.lbcFilePath.HorizontalScrollbar = true;
            this.lbcFilePath.Location = new System.Drawing.Point(12, 12);
            this.lbcFilePath.Name = "lbcFilePath";
            this.lbcFilePath.Size = new System.Drawing.Size(734, 69);
            this.lbcFilePath.StyleController = this.MainLayoutControl;
            this.lbcFilePath.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemLog,
            this.layoutControlItemProgress,
            this.layoutControlItemCount,
            this.layoutControlItemTime,
            this.layoutControlGroupCommands,
            this.layoutControlItemFiles,
            this.emptySpaceItem1,
            this.splitterItemMid});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(758, 362);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemLog
            // 
            this.layoutControlItemLog.Control = this.tbLog;
            this.layoutControlItemLog.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItemLog.CustomizationFormText = "tbLogitem";
            this.layoutControlItemLog.Location = new System.Drawing.Point(229, 78);
            this.layoutControlItemLog.Name = "layoutControlItemLog";
            this.layoutControlItemLog.Size = new System.Drawing.Size(509, 225);
            this.layoutControlItemLog.Text = "layoutControlItemLog";
            this.layoutControlItemLog.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLog.TextToControlDistance = 0;
            this.layoutControlItemLog.TextVisible = false;
            // 
            // layoutControlItemProgress
            // 
            this.layoutControlItemProgress.Control = this.ProgressBarMain;
            this.layoutControlItemProgress.CustomizationFormText = "Progress";
            this.layoutControlItemProgress.Location = new System.Drawing.Point(0, 320);
            this.layoutControlItemProgress.Name = "layoutControlItemProgress";
            this.layoutControlItemProgress.Size = new System.Drawing.Size(738, 22);
            this.layoutControlItemProgress.Text = "Progress";
            this.layoutControlItemProgress.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemCount
            // 
            this.layoutControlItemCount.Control = this.lblCount;
            this.layoutControlItemCount.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItemCount.CustomizationFormText = "Count";
            this.layoutControlItemCount.Location = new System.Drawing.Point(77, 303);
            this.layoutControlItemCount.Name = "layoutControlItemCount";
            this.layoutControlItemCount.Size = new System.Drawing.Size(661, 17);
            this.layoutControlItemCount.Text = "Count";
            this.layoutControlItemCount.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCount.TextToControlDistance = 0;
            this.layoutControlItemCount.TextVisible = false;
            // 
            // layoutControlItemTime
            // 
            this.layoutControlItemTime.Control = this.lblEstTime;
            this.layoutControlItemTime.CustomizationFormText = "Time";
            this.layoutControlItemTime.Location = new System.Drawing.Point(0, 303);
            this.layoutControlItemTime.Name = "layoutControlItemTime";
            this.layoutControlItemTime.Size = new System.Drawing.Size(77, 17);
            this.layoutControlItemTime.Text = "Time";
            this.layoutControlItemTime.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlGroupCommands
            // 
            this.layoutControlGroupCommands.CustomizationFormText = "Commands";
            this.layoutControlGroupCommands.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemImport,
            this.layoutControlItemYear,
            this.layoutControlItemMonth,
            this.layoutControlItemAdd,
            this.layoutControlItemRemove});
            this.layoutControlGroupCommands.Location = new System.Drawing.Point(0, 147);
            this.layoutControlGroupCommands.Name = "layoutControlGroupCommands";
            this.layoutControlGroupCommands.Size = new System.Drawing.Size(229, 156);
            this.layoutControlGroupCommands.Text = "Commands";
            this.layoutControlGroupCommands.TextVisible = false;
            // 
            // layoutControlItemImport
            // 
            this.layoutControlItemImport.Control = this.btnImport;
            this.layoutControlItemImport.CustomizationFormText = "Import";
            this.layoutControlItemImport.Location = new System.Drawing.Point(0, 90);
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
            // layoutControlItemYear
            // 
            this.layoutControlItemYear.Control = this.seYear;
            this.layoutControlItemYear.CustomizationFormText = "Year";
            this.layoutControlItemYear.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemYear.MaxSize = new System.Drawing.Size(205, 24);
            this.layoutControlItemYear.MinSize = new System.Drawing.Size(205, 24);
            this.layoutControlItemYear.Name = "layoutControlItemYear";
            this.layoutControlItemYear.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItemYear.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemYear.Text = "Year";
            this.layoutControlItemYear.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemMonth
            // 
            this.layoutControlItemMonth.Control = this.seMonth;
            this.layoutControlItemMonth.CustomizationFormText = "Month";
            this.layoutControlItemMonth.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemMonth.MaxSize = new System.Drawing.Size(205, 24);
            this.layoutControlItemMonth.MinSize = new System.Drawing.Size(205, 24);
            this.layoutControlItemMonth.Name = "layoutControlItemMonth";
            this.layoutControlItemMonth.Size = new System.Drawing.Size(205, 24);
            this.layoutControlItemMonth.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemMonth.Text = "Month";
            this.layoutControlItemMonth.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemAdd
            // 
            this.layoutControlItemAdd.Control = this.btnGetFileName;
            this.layoutControlItemAdd.CustomizationFormText = "Add";
            this.layoutControlItemAdd.Location = new System.Drawing.Point(0, 48);
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
            this.layoutControlItemRemove.Location = new System.Drawing.Point(116, 48);
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
            // layoutControlItemFiles
            // 
            this.layoutControlItemFiles.Control = this.lbcFilePath;
            this.layoutControlItemFiles.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.layoutControlItemFiles.CustomizationFormText = "lbcFilePathitem";
            this.layoutControlItemFiles.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemFiles.Name = "layoutControlItemFiles";
            this.layoutControlItemFiles.Size = new System.Drawing.Size(738, 73);
            this.layoutControlItemFiles.Text = "layoutControlItemFiles";
            this.layoutControlItemFiles.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemFiles.TextToControlDistance = 0;
            this.layoutControlItemFiles.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 78);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(229, 69);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitterItemMid
            // 
            this.splitterItemMid.AllowHotTrack = true;
            this.splitterItemMid.CustomizationFormText = "splitterItemMid";
            this.splitterItemMid.Location = new System.Drawing.Point(0, 73);
            this.splitterItemMid.Name = "splitterItemMid";
            this.splitterItemMid.Size = new System.Drawing.Size(738, 5);
            this.splitterItemMid.TrimClientAreaToControl = false;
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel Files(xlsx)|*.xlsx";
            // 
            // adpRoute
            // 
            this.adpRoute.ClearBeforeFill = true;
            // 
            // dsNM
            // 
            this.dsNM.DataSetName = "dsNM";
            this.dsNM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adpRouteTargetFormulaTable
            // 
            this.adpRouteTargetFormulaTable.ClearBeforeFill = true;
            // 
            // ImportRouteTargetFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 362);
            this.Controls.Add(this.MainLayoutControl);
            this.Icon = global::NestleICSales.Properties.Resources.importtodatabase_16x16;
            this.Name = "ImportRouteTargetFrm";
            this.Text = "Import Route Target";
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutControl)).EndInit();
            this.MainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItemMid)).EndInit();
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
        private DataSources.dsData dsNM;
        private DevExpress.XtraEditors.MemoEdit tbLog;
        private DevExpress.XtraLayout.LayoutControl MainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFiles;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverterMain;
        private DevExpress.XtraEditors.SpinEdit seMonth;
        private DevExpress.XtraEditors.SpinEdit seYear;
        private DataSources.dsDataTableAdapters.RouteTargetFormulaTableAdapter adpRouteTargetFormulaTable;
        private DevExpress.XtraLayout.SplitterItem splitterItemMid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemMonth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRemove;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemProgress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTime;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupCommands;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}