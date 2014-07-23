namespace Synricate
{
    partial class ImportExcelDataFrm
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lbSheets = new System.Windows.Forms.ListBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.ListBox();
            this.lbColumns = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(343, 16);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(42, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lbSheets
            // 
            this.lbSheets.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSheets.FormattingEnabled = true;
            this.lbSheets.Location = new System.Drawing.Point(3, 16);
            this.lbSheets.Name = "lbSheets";
            this.lbSheets.Size = new System.Drawing.Size(101, 191);
            this.lbSheets.TabIndex = 1;
            this.lbSheets.SelectedIndexChanged += new System.EventHandler(this.lbSheets_SelectedIndexChanged);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(73, 19);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(264, 20);
            this.tbFileName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbFileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSelectFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel File Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.lbData);
            this.groupBox2.Controls.Add(this.lbColumns);
            this.groupBox2.Controls.Add(this.lbSheets);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 210);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel File Options";
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImport.Location = new System.Drawing.Point(326, 16);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 191);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "استيراد";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lbData
            // 
            this.lbData.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(215, 16);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(105, 191);
            this.lbData.TabIndex = 3;
            // 
            // lbColumns
            // 
            this.lbColumns.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbColumns.FormattingEnabled = true;
            this.lbColumns.Location = new System.Drawing.Point(104, 16);
            this.lbColumns.Name = "lbColumns";
            this.lbColumns.Size = new System.Drawing.Size(111, 191);
            this.lbColumns.TabIndex = 2;
            this.lbColumns.SelectedIndexChanged += new System.EventHandler(this.lbColumns_SelectedIndexChanged);
            // 
            // ImportExcelDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportExcelDataFrm";
            this.Text = "Import data from excel";
            this.Load += new System.EventHandler(this.ImportExcelDataFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.ListBox lbSheets;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbColumns;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Button btnImport;
    }
}

