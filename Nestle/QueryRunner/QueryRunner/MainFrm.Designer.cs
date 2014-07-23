namespace QueryRunner
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
            this.GBPath = new System.Windows.Forms.GroupBox();
            this.btndbPath = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.LBQueries = new System.Windows.Forms.ListBox();
            this.tbQueryName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.LVResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.ofdDB = new System.Windows.Forms.OpenFileDialog();
            this.sfdConfig = new System.Windows.Forms.SaveFileDialog();
            this.ofdConfig = new System.Windows.Forms.OpenFileDialog();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GBPath.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBPath
            // 
            this.GBPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBPath.Controls.Add(this.btndbPath);
            this.GBPath.Controls.Add(this.lblPath);
            this.GBPath.Location = new System.Drawing.Point(12, 27);
            this.GBPath.Name = "GBPath";
            this.GBPath.Size = new System.Drawing.Size(447, 60);
            this.GBPath.TabIndex = 0;
            this.GBPath.TabStop = false;
            this.GBPath.Text = "Access Database Path";
            // 
            // btndbPath
            // 
            this.btndbPath.Image = global::QueryRunner.Properties.Resources.Open;
            this.btndbPath.Location = new System.Drawing.Point(7, 20);
            this.btndbPath.Name = "btndbPath";
            this.btndbPath.Size = new System.Drawing.Size(75, 30);
            this.btndbPath.TabIndex = 1;
            this.btndbPath.UseVisualStyleBackColor = true;
            this.btndbPath.Click += new System.EventHandler(this.btndbPath_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(88, 31);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(22, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "C:\\";
            // 
            // LBQueries
            // 
            this.LBQueries.FormattingEnabled = true;
            this.LBQueries.Location = new System.Drawing.Point(12, 113);
            this.LBQueries.Name = "LBQueries";
            this.LBQueries.Size = new System.Drawing.Size(188, 160);
            this.LBQueries.TabIndex = 1;
            // 
            // tbQueryName
            // 
            this.tbQueryName.Location = new System.Drawing.Point(12, 306);
            this.tbQueryName.Name = "tbQueryName";
            this.tbQueryName.Size = new System.Drawing.Size(139, 20);
            this.tbQueryName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QueryRunner.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(157, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::QueryRunner.Properties.Resources.Remove;
            this.btnRemove.Location = new System.Drawing.Point(12, 279);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(187, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // LVResult
            // 
            this.LVResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LVResult.Location = new System.Drawing.Point(206, 113);
            this.LVResult.Name = "LVResult";
            this.LVResult.Size = new System.Drawing.Size(405, 189);
            this.LVResult.TabIndex = 5;
            this.LVResult.UseCompatibleStateImageBehavior = false;
            this.LVResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Query Name";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Effected Rows";
            this.columnHeader2.Width = 138;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(623, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.TabStop = true;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::QueryRunner.Properties.Resources.Load;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadToolStripMenuItem.Text = "L&oad";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::QueryRunner.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::QueryRunner.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(206, 306);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(405, 23);
            this.pb.TabIndex = 6;
            // 
            // ofdDB
            // 
            this.ofdDB.Filter = "New Access File (*.accdb)|*.accdb|Old Access File (*.mdb)|*.mdb|All Files (*.*)|*" +
    ".*";
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 337);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(623, 22);
            this.statusStripMain.TabIndex = 9;
            this.statusStripMain.Text = "Ready";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelStatus.Text = "Ready";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::QueryRunner.Properties.Resources.Stop;
            this.btnStop.Location = new System.Drawing.Point(567, 37);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 50);
            this.btnStop.TabIndex = 8;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Image = global::QueryRunner.Properties.Resources.Start;
            this.btnRun.Location = new System.Drawing.Point(465, 37);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 50);
            this.btnRun.TabIndex = 7;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Execution Time";
            this.columnHeader3.Width = 93;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 359);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.LVResult);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbQueryName);
            this.Controls.Add(this.LBQueries);
            this.Controls.Add(this.GBPath);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainFrm";
            this.Text = "Query Runner";
            this.GBPath.ResumeLayout(false);
            this.GBPath.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBPath;
        private System.Windows.Forms.Button btndbPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ListBox LBQueries;
        private System.Windows.Forms.TextBox tbQueryName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView LVResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.OpenFileDialog ofdDB;
        private System.Windows.Forms.SaveFileDialog sfdConfig;
        private System.Windows.Forms.OpenFileDialog ofdConfig;
        private System.Windows.Forms.Button btnRun;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

