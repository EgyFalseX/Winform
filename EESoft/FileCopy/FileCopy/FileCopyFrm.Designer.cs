namespace FileCopy
{
    partial class FileCopyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileCopyFrm));
            this.btnUploadDaccount = new System.Windows.Forms.Button();
            this.btnDownloadDaccount = new System.Windows.Forms.Button();
            this.btnDownloadDaccountdataschool = new System.Windows.Forms.Button();
            this.btnUploadDaccountdataschool = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadDaccount
            // 
            this.btnUploadDaccount.Image = global::FileCopy.Properties.Resources.Upload;
            this.btnUploadDaccount.Location = new System.Drawing.Point(10, 23);
            this.btnUploadDaccount.Name = "btnUploadDaccount";
            this.btnUploadDaccount.Size = new System.Drawing.Size(136, 62);
            this.btnUploadDaccount.TabIndex = 0;
            this.btnUploadDaccount.Text = "تصدير داتا الحسابات";
            this.btnUploadDaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUploadDaccount.UseVisualStyleBackColor = true;
            this.btnUploadDaccount.Click += new System.EventHandler(this.btnUploadDaccount_Click);
            // 
            // btnDownloadDaccount
            // 
            this.btnDownloadDaccount.Image = global::FileCopy.Properties.Resources.Download;
            this.btnDownloadDaccount.Location = new System.Drawing.Point(152, 23);
            this.btnDownloadDaccount.Name = "btnDownloadDaccount";
            this.btnDownloadDaccount.Size = new System.Drawing.Size(136, 62);
            this.btnDownloadDaccount.TabIndex = 0;
            this.btnDownloadDaccount.Text = "استيراد داتا الحسابات";
            this.btnDownloadDaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDownloadDaccount.UseVisualStyleBackColor = true;
            this.btnDownloadDaccount.Click += new System.EventHandler(this.btnDownloadDaccount_Click);
            // 
            // btnDownloadDaccountdataschool
            // 
            this.btnDownloadDaccountdataschool.Image = global::FileCopy.Properties.Resources.Download;
            this.btnDownloadDaccountdataschool.Location = new System.Drawing.Point(152, 14);
            this.btnDownloadDaccountdataschool.Name = "btnDownloadDaccountdataschool";
            this.btnDownloadDaccountdataschool.Size = new System.Drawing.Size(136, 62);
            this.btnDownloadDaccountdataschool.TabIndex = 0;
            this.btnDownloadDaccountdataschool.Text = "استيراد بيانات ش ط";
            this.btnDownloadDaccountdataschool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDownloadDaccountdataschool.UseVisualStyleBackColor = true;
            this.btnDownloadDaccountdataschool.Click += new System.EventHandler(this.btnDownloadDaccountdataschool_Click);
            // 
            // btnUploadDaccountdataschool
            // 
            this.btnUploadDaccountdataschool.Image = global::FileCopy.Properties.Resources.Upload;
            this.btnUploadDaccountdataschool.Location = new System.Drawing.Point(10, 14);
            this.btnUploadDaccountdataschool.Name = "btnUploadDaccountdataschool";
            this.btnUploadDaccountdataschool.Size = new System.Drawing.Size(136, 62);
            this.btnUploadDaccountdataschool.TabIndex = 0;
            this.btnUploadDaccountdataschool.Text = "تصدير بيانات ش ط";
            this.btnUploadDaccountdataschool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUploadDaccountdataschool.UseVisualStyleBackColor = true;
            this.btnUploadDaccountdataschool.Click += new System.EventHandler(this.btnUploadDaccountdataschool_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUploadDaccount);
            this.groupBox1.Controls.Add(this.btnDownloadDaccount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(298, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " - داتا الحسابات - ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUploadDaccountdataschool);
            this.groupBox2.Controls.Add(this.btnDownloadDaccountdataschool);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(298, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " - بيانات ش ط - ";
            // 
            // FileCopyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 198);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileCopyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نقل البيانات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadDaccount;
        private System.Windows.Forms.Button btnUploadDaccount;
        private System.Windows.Forms.Button btnDownloadDaccountdataschool;
        private System.Windows.Forms.Button btnUploadDaccountdataschool;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

