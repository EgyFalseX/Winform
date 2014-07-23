namespace Employee
{
    partial class DatabaseManagerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseManagerFrm));
            this.BtnBackup = new System.Windows.Forms.Button();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.LBbackups = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnchoosePath = new System.Windows.Forms.Button();
            this.BtnSavePath = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBackup
            // 
            this.BtnBackup.BackColor = System.Drawing.Color.Lime;
            this.BtnBackup.ForeColor = System.Drawing.Color.Black;
            this.BtnBackup.Location = new System.Drawing.Point(7, 12);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(75, 23);
            this.BtnBackup.TabIndex = 1;
            this.BtnBackup.Text = "Backup";
            this.BtnBackup.UseVisualStyleBackColor = false;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.BackColor = System.Drawing.Color.Lime;
            this.BtnRestore.ForeColor = System.Drawing.Color.Black;
            this.BtnRestore.Location = new System.Drawing.Point(88, 12);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(75, 23);
            this.BtnRestore.TabIndex = 2;
            this.BtnRestore.Text = "Restore";
            this.BtnRestore.UseVisualStyleBackColor = false;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(11, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " - Databse Managment Commands - ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnBackup);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnRestore);
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 50);
            this.panel1.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Lime;
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(169, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(19, 294);
            this.PB.Maximum = 3;
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(254, 16);
            this.PB.Step = 1;
            this.PB.TabIndex = 1;
            this.PB.Visible = false;
            // 
            // LBbackups
            // 
            this.LBbackups.BackColor = System.Drawing.Color.Black;
            this.LBbackups.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LBbackups.ForeColor = System.Drawing.Color.Lime;
            this.LBbackups.FormattingEnabled = true;
            this.LBbackups.Location = new System.Drawing.Point(12, 93);
            this.LBbackups.Name = "LBbackups";
            this.LBbackups.ScrollAlwaysVisible = true;
            this.LBbackups.Size = new System.Drawing.Size(268, 108);
            this.LBbackups.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnSavePath);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " - Databse Save/Load Path - ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BtnchoosePath);
            this.panel2.Controls.Add(this.TxtPath);
            this.panel2.Location = new System.Drawing.Point(7, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 34);
            this.panel2.TabIndex = 0;
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(6, 5);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(214, 20);
            this.TxtPath.TabIndex = 0;
            // 
            // BtnchoosePath
            // 
            this.BtnchoosePath.BackColor = System.Drawing.Color.Lime;
            this.BtnchoosePath.ForeColor = System.Drawing.Color.Black;
            this.BtnchoosePath.Location = new System.Drawing.Point(217, 3);
            this.BtnchoosePath.Name = "BtnchoosePath";
            this.BtnchoosePath.Size = new System.Drawing.Size(33, 23);
            this.BtnchoosePath.TabIndex = 3;
            this.BtnchoosePath.Text = "...";
            this.BtnchoosePath.UseVisualStyleBackColor = false;
            this.BtnchoosePath.Click += new System.EventHandler(this.BtnchoosePath_Click);
            // 
            // BtnSavePath
            // 
            this.BtnSavePath.BackColor = System.Drawing.Color.Lime;
            this.BtnSavePath.ForeColor = System.Drawing.Color.Black;
            this.BtnSavePath.Location = new System.Drawing.Point(15, 53);
            this.BtnSavePath.Name = "BtnSavePath";
            this.BtnSavePath.Size = new System.Drawing.Size(214, 23);
            this.BtnSavePath.TabIndex = 3;
            this.BtnSavePath.Text = "Save";
            this.BtnSavePath.UseVisualStyleBackColor = false;
            this.BtnSavePath.Click += new System.EventHandler(this.BtnSavePath_Click);
            // 
            // DatabaseManagerFrm
            // 
            this.AcceptButton = this.BtnBackup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Employee.Properties.Resources.SQLConnection;
            this.ClientSize = new System.Drawing.Size(292, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LBbackups);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DatabaseManagerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Manager";
            this.Load += new System.EventHandler(this.DatabaseManagerFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.Button BtnRestore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.ListBox LBbackups;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnchoosePath;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnSavePath;

    }
}