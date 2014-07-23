namespace DatabaseImageEditor
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPK = new System.Windows.Forms.TextBox();
            this.tbColumn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxProgress = new System.Windows.Forms.GroupBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lblRows = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnPath);
            this.groupBox1.Controls.Add(this.tbPK);
            this.groupBox1.Controls.Add(this.tbFileName);
            this.groupBox1.Controls.Add(this.tbColumn);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbW);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Options";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(340, 20);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(50, 20);
            this.tbH.TabIndex = 4;
            this.tbH.Text = "100";
            this.tbH.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Jpeg";
            this.label7.Visible = false;
            // 
            // tbPK
            // 
            this.tbPK.Location = new System.Drawing.Point(95, 46);
            this.tbPK.Name = "tbPK";
            this.tbPK.Size = new System.Drawing.Size(120, 20);
            this.tbPK.TabIndex = 2;
            this.tbPK.Text = "MemberId";
            // 
            // tbColumn
            // 
            this.tbColumn.Location = new System.Drawing.Point(95, 72);
            this.tbColumn.Name = "tbColumn";
            this.tbColumn.Size = new System.Drawing.Size(120, 20);
            this.tbColumn.TabIndex = 2;
            this.tbColumn.Text = "img";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ImageFormat";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Primary Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "H";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Image Column";
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(261, 20);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(50, 20);
            this.tbW.TabIndex = 3;
            this.tbW.Text = "100";
            this.tbW.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "W";
            this.label3.Visible = false;
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(95, 20);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(120, 20);
            this.tbTable.TabIndex = 1;
            this.tbTable.Text = "TBLMembers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Start";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(333, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBoxProgress
            // 
            this.groupBoxProgress.Controls.Add(this.pb);
            this.groupBoxProgress.Controls.Add(this.lblRows);
            this.groupBoxProgress.Controls.Add(this.label4);
            this.groupBoxProgress.Location = new System.Drawing.Point(12, 170);
            this.groupBoxProgress.Name = "groupBoxProgress";
            this.groupBoxProgress.Size = new System.Drawing.Size(396, 81);
            this.groupBoxProgress.TabIndex = 1;
            this.groupBoxProgress.TabStop = false;
            this.groupBoxProgress.Text = "Progress";
            this.groupBoxProgress.Visible = false;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(6, 52);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(384, 23);
            this.pb.TabIndex = 1;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(48, 22);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(13, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rows";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(10, 122);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(19, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "...";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(351, 120);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(39, 23);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Filename Column";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(95, 98);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(120, 20);
            this.tbFileName.TabIndex = 2;
            this.tbFileName.Text = "KideNumber";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 288);
            this.Controls.Add(this.groupBoxProgress);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Image Exporter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxProgress.ResumeLayout(false);
            this.groupBoxProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxProgress;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label9;
    }
}

