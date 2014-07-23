namespace SqlRptBuilder
{
    partial class FrmBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuilder));
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtrdlName = new System.Windows.Forms.TextBox();
            this.BtnSelectRpt = new System.Windows.Forms.Button();
            this.CBRpt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LVrpt = new System.Windows.Forms.ListView();
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblrdlPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPath
            // 
            this.TxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPath.Location = new System.Drawing.Point(3, 5);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(386, 20);
            this.TxtPath.TabIndex = 2;
            this.TxtPath.TabStop = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnDelete.Location = new System.Drawing.Point(88, 257);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(222, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtrdlName
            // 
            this.TxtrdlName.Location = new System.Drawing.Point(80, 80);
            this.TxtrdlName.Name = "TxtrdlName";
            this.TxtrdlName.Size = new System.Drawing.Size(106, 20);
            this.TxtrdlName.TabIndex = 2;
            // 
            // BtnSelectRpt
            // 
            this.BtnSelectRpt.Location = new System.Drawing.Point(80, 26);
            this.BtnSelectRpt.Name = "BtnSelectRpt";
            this.BtnSelectRpt.Size = new System.Drawing.Size(100, 23);
            this.BtnSelectRpt.TabIndex = 1;
            this.BtnSelectRpt.Text = "...";
            this.BtnSelectRpt.UseVisualStyleBackColor = true;
            this.BtnSelectRpt.Click += new System.EventHandler(this.BtnSelectRpt_Click);
            // 
            // CBRpt
            // 
            this.CBRpt.FormattingEnabled = true;
            this.CBRpt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CBRpt.Location = new System.Drawing.Point(80, 106);
            this.CBRpt.Name = "CBRpt";
            this.CBRpt.Size = new System.Drawing.Size(42, 21);
            this.CBRpt.TabIndex = 3;
            this.CBRpt.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Report Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Position:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(80, 132);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LVrpt
            // 
            this.LVrpt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LVrpt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPosition,
            this.columnHeaderFileName,
            this.columnHeaderName});
            this.LVrpt.FullRowSelect = true;
            this.LVrpt.HideSelection = false;
            this.LVrpt.Location = new System.Drawing.Point(6, 158);
            this.LVrpt.Name = "LVrpt";
            this.LVrpt.Size = new System.Drawing.Size(386, 97);
            this.LVrpt.TabIndex = 5;
            this.LVrpt.UseCompatibleStateImageBehavior = false;
            this.LVrpt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPosition
            // 
            this.columnHeaderPosition.Text = "Position";
            this.columnHeaderPosition.Width = 49;
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "FileName";
            this.columnHeaderFileName.Width = 132;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 89;
            // 
            // LblrdlPath
            // 
            this.LblrdlPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LblrdlPath.Location = new System.Drawing.Point(6, 55);
            this.LblrdlPath.Name = "LblrdlPath";
            this.LblrdlPath.ReadOnly = true;
            this.LblrdlPath.Size = new System.Drawing.Size(386, 20);
            this.LblrdlPath.TabIndex = 2;
            this.LblrdlPath.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Path:";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(417, 24);
            this.menuStripMain.TabIndex = 8;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLoadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openLoadToolStripMenuItem
            // 
            this.openLoadToolStripMenuItem.Name = "openLoadToolStripMenuItem";
            this.openLoadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openLoadToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openLoadToolStripMenuItem.Text = "&Open/Load";
            this.openLoadToolStripMenuItem.Click += new System.EventHandler(this.openLoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutUsToolStripMenuItem.Text = "&About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMain.Controls.Add(this.TxtPath);
            this.PnlMain.Controls.Add(this.LVrpt);
            this.PnlMain.Controls.Add(this.BtnSelectRpt);
            this.PnlMain.Controls.Add(this.label3);
            this.PnlMain.Controls.Add(this.BtnAdd);
            this.PnlMain.Controls.Add(this.label2);
            this.PnlMain.Controls.Add(this.BtnDelete);
            this.PnlMain.Controls.Add(this.label1);
            this.PnlMain.Controls.Add(this.LblrdlPath);
            this.PnlMain.Controls.Add(this.CBRpt);
            this.PnlMain.Controls.Add(this.TxtrdlName);
            this.PnlMain.Location = new System.Drawing.Point(11, 28);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(395, 284);
            this.PnlMain.TabIndex = 9;
            this.PnlMain.Visible = false;
            // 
            // FrmBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 318);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Config Builder";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtrdlName;
        private System.Windows.Forms.Button BtnSelectRpt;
        private System.Windows.Forms.ComboBox CBRpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListView LVrpt;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderPosition;
        private System.Windows.Forms.TextBox LblrdlPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel PnlMain;
    }
}

