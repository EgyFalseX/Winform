namespace GetFolderFilePaths
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.cbCut = new System.Windows.Forms.CheckBox();
            this.cbSubDir = new System.Windows.Forms.CheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNameAndEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenDir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dsFilePaths = new GetFolderFilePaths.dsFilePaths();
            this.filePathsTableAdapter = new GetFolderFilePaths.dsFilePathsTableAdapters.FilePathsTableAdapter();
            this.filesNamesTableAdapter = new GetFolderFilePaths.dsFilePathsTableAdapters.FilesNamesTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dsFilePathsViewer = new GetFolderFilePaths.dsFilePaths();
            this.gbMain.SuspendLayout();
            this.gbCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilePaths)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilePathsViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.lblPath);
            this.gbMain.Controls.Add(this.btnPath);
            this.gbMain.Location = new System.Drawing.Point(6, 6);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(661, 43);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Folder Information";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(87, 20);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(22, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "C:\\";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(6, 15);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(580, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(154, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbCommand
            // 
            this.gbCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCommand.Controls.Add(this.cbCut);
            this.gbCommand.Controls.Add(this.cbSubDir);
            this.gbCommand.Controls.Add(this.btnSearch);
            this.gbCommand.Controls.Add(this.btnSave);
            this.gbCommand.Enabled = false;
            this.gbCommand.Location = new System.Drawing.Point(6, 446);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(661, 50);
            this.gbCommand.TabIndex = 2;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Commands";
            // 
            // cbCut
            // 
            this.cbCut.AutoSize = true;
            this.cbCut.Location = new System.Drawing.Point(6, 32);
            this.cbCut.Name = "cbCut";
            this.cbCut.Size = new System.Drawing.Size(127, 17);
            this.cbCut.TabIndex = 0;
            this.cbCut.Text = "Cut Known Files Only";
            this.cbCut.UseVisualStyleBackColor = true;
            // 
            // cbSubDir
            // 
            this.cbSubDir.AutoSize = true;
            this.cbSubDir.Checked = true;
            this.cbSubDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSubDir.Location = new System.Drawing.Point(6, 15);
            this.cbSubDir.Name = "cbSubDir";
            this.cbSubDir.Size = new System.Drawing.Size(142, 17);
            this.cbSubDir.TabIndex = 0;
            this.cbSubDir.Text = "Get Sub Directories Files";
            this.cbSubDir.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FileName,
            this.FileNameAndEx,
            this.FolderName,
            this.OpenDir});
            this.dgvData.DataSource = this.dsFilePaths;
            this.dgvData.Location = new System.Drawing.Point(6, 55);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(661, 385);
            this.dgvData.TabIndex = 1;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // FileNameAndEx
            // 
            this.FileNameAndEx.DataPropertyName = "FileNameAndEx";
            this.FileNameAndEx.HeaderText = "FileNameAndEx";
            this.FileNameAndEx.Name = "FileNameAndEx";
            this.FileNameAndEx.ReadOnly = true;
            // 
            // FolderName
            // 
            this.FolderName.DataPropertyName = "FolderName";
            this.FolderName.HeaderText = "FolderName";
            this.FolderName.Name = "FolderName";
            this.FolderName.ReadOnly = true;
            // 
            // OpenDir
            // 
            this.OpenDir.HeaderText = "Open Folder";
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.ReadOnly = true;
            this.OpenDir.Text = "...";
            // 
            // dsFilePaths
            // 
            this.dsFilePaths.DataSetName = "dsFilePaths";
            this.dsFilePaths.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filePathsTableAdapter
            // 
            this.filePathsTableAdapter.ClearBeforeFill = true;
            // 
            // filesNamesTableAdapter
            // 
            this.filesNamesTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 525);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbMain);
            this.tabPage1.Controls.Add(this.gbCommand);
            this.tabPage1.Controls.Add(this.dgvData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dgvViewer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Viewer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvViewer
            // 
            this.dgvViewer.AllowUserToAddRows = false;
            this.dgvViewer.AllowUserToDeleteRows = false;
            this.dgvViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewer.AutoGenerateColumns = false;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewButtonColumn1});
            this.dgvViewer.DataSource = this.dsFilePaths;
            this.dgvViewer.Location = new System.Drawing.Point(7, 55);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.ReadOnly = true;
            this.dgvViewer.Size = new System.Drawing.Size(661, 436);
            this.dgvViewer.TabIndex = 2;
            this.dgvViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewer_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FileNameAndEx";
            this.dataGridViewTextBoxColumn3.HeaderText = "FileNameAndEx";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FolderName";
            this.dataGridViewTextBoxColumn4.HeaderText = "FolderName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Open Folder";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLoadData);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Contains";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(6, 15);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dsFilePathsViewer
            // 
            this.dsFilePathsViewer.DataSetName = "dsFilePaths";
            this.dsFilePathsViewer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 525);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "File Paths";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.gbCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilePaths)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFilePathsViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPath;
        private dsFilePaths dsFilePaths;
        private dsFilePathsTableAdapters.FilePathsTableAdapter filePathsTableAdapter;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.CheckBox cbSubDir;
        private System.Windows.Forms.CheckBox cbCut;
        private dsFilePathsTableAdapters.FilesNamesTableAdapter filesNamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameAndEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderName;
        private System.Windows.Forms.DataGridViewButtonColumn OpenDir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private dsFilePaths dsFilePathsViewer;
    }
}

