namespace NestleICSales.Forms.Import
{
    partial class ImportEmployeeFrm
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
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetFileName = new DevExpress.XtraEditors.SimpleButton();
            this.lbcFilePath = new DevExpress.XtraEditors.ListBoxControl();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pnlCommands = new DevExpress.XtraEditors.PanelControl();
            this.tbLog = new DevExpress.XtraEditors.MemoEdit();
            this.dsNM = new NestleICSales.DataSources.dsData();
            this.adpEmployeeTable = new NestleICSales.DataSources.dsDataTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgress)).BeginInit();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCommands)).BeginInit();
            this.pnlCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNM)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.ProgressBarMain);
            this.pnlProgress.Controls.Add(this.lblCount);
            this.pnlProgress.Controls.Add(this.lblEstTime);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgress.Location = new System.Drawing.Point(0, 274);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(579, 51);
            this.pnlProgress.TabIndex = 5;
            // 
            // ProgressBarMain
            // 
            this.ProgressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBarMain.Location = new System.Drawing.Point(2, 26);
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new System.Drawing.Size(575, 23);
            this.ProgressBarMain.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Location = new System.Drawing.Point(475, 7);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0/0";
            // 
            // lblEstTime
            // 
            this.lblEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstTime.Location = new System.Drawing.Point(12, 7);
            this.lblEstTime.Name = "lblEstTime";
            this.lblEstTime.Size = new System.Drawing.Size(28, 13);
            this.lblEstTime.TabIndex = 4;
            this.lblEstTime.Text = "00:00";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Image = global::NestleICSales.Properties.Resources.removedatafile_32x32;
            this.btnRemove.Location = new System.Drawing.Point(158, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Image = global::NestleICSales.Properties.Resources.importtodatabase_32x32;
            this.btnImport.Location = new System.Drawing.Point(2, 139);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(255, 32);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Employee";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnGetFileName
            // 
            this.btnGetFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileName.Image = global::NestleICSales.Properties.Resources.adddatafile_32x32;
            this.btnGetFileName.Location = new System.Drawing.Point(2, 5);
            this.btnGetFileName.Name = "btnGetFileName";
            this.btnGetFileName.Size = new System.Drawing.Size(150, 32);
            this.btnGetFileName.TabIndex = 0;
            this.btnGetFileName.Text = "Add Excel File";
            this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
            // 
            // lbcFilePath
            // 
            this.lbcFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbcFilePath.HorizontalScrollbar = true;
            this.lbcFilePath.Location = new System.Drawing.Point(0, 0);
            this.lbcFilePath.Name = "lbcFilePath";
            this.lbcFilePath.Size = new System.Drawing.Size(579, 97);
            this.lbcFilePath.TabIndex = 2;
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel Files(xlsx)|*.xlsx";
            // 
            // pnlCommands
            // 
            this.pnlCommands.Controls.Add(this.btnGetFileName);
            this.pnlCommands.Controls.Add(this.btnRemove);
            this.pnlCommands.Controls.Add(this.btnImport);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCommands.Location = new System.Drawing.Point(317, 97);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(262, 177);
            this.pnlCommands.TabIndex = 5;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(0, 97);
            this.tbLog.Name = "tbLog";
            this.tbLog.Properties.ReadOnly = true;
            this.tbLog.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(317, 177);
            this.tbLog.TabIndex = 4;
            this.tbLog.UseOptimizedRendering = true;
            // 
            // dsNM
            // 
            this.dsNM.DataSetName = "dsNM";
            this.dsNM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adpEmployeeTable
            // 
            this.adpEmployeeTable.ClearBeforeFill = true;
            // 
            // ImportEmployeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 325);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.pnlCommands);
            this.Controls.Add(this.lbcFilePath);
            this.Controls.Add(this.pnlProgress);
            this.Icon = global::NestleICSales.Properties.Resources.importtodatabase_16x16;
            this.Name = "ImportEmployeeFrm";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgress)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCommands)).EndInit();
            this.pnlCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlProgress;
        private DevExpress.XtraEditors.ProgressBarControl ProgressBarMain;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraEditors.LabelControl lblEstTime;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnGetFileName;
        private DevExpress.XtraEditors.ListBoxControl lbcFilePath;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DataSources.dsData dsNM;
        private DevExpress.XtraEditors.PanelControl pnlCommands;
        private DevExpress.XtraEditors.MemoEdit tbLog;
        private DataSources.dsDataTableAdapters.EmployeeTableAdapter adpEmployeeTable;
    }
}