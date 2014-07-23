namespace DbSyc_Client
{
    partial class DbSycMainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbSycMainFrm));
            this.LV = new System.Windows.Forms.ListView();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.pnlCommand = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.pnlCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.AllowDrop = true;
            this.LV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV.BackColor = System.Drawing.Color.Black;
            this.LV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LV.ForeColor = System.Drawing.Color.White;
            this.LV.LargeImageList = this.imageListIcon;
            this.LV.Location = new System.Drawing.Point(12, 12);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(436, 260);
            this.LV.TabIndex = 0;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LV_ItemSelectionChanged);
            this.LV.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_DragDrop);
            this.LV.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_DragEnter);
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "dbFile.png");
            // 
            // pnlCommand
            // 
            this.pnlCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCommand.Controls.Add(this.btnExit);
            this.pnlCommand.Controls.Add(this.btnOption);
            this.pnlCommand.Controls.Add(this.btnDelete);
            this.pnlCommand.Controls.Add(this.btnDownload);
            this.pnlCommand.Controls.Add(this.btnAdd);
            this.pnlCommand.Controls.Add(this.btnUpload);
            this.pnlCommand.Location = new System.Drawing.Point(3, 278);
            this.pnlCommand.Name = "pnlCommand";
            this.pnlCommand.Size = new System.Drawing.Size(453, 68);
            this.pnlCommand.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::DbSyc_Client.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(8, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOption
            // 
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption.BackColor = System.Drawing.Color.Transparent;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption.ForeColor = System.Drawing.Color.White;
            this.btnOption.Image = global::DbSyc_Client.Properties.Resources.Options;
            this.btnOption.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOption.Location = new System.Drawing.Point(74, 7);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(60, 58);
            this.btnOption.TabIndex = 3;
            this.btnOption.Text = "خيارات";
            this.btnOption.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::DbSyc_Client.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(140, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 58);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.Enabled = false;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDownload.Location = new System.Drawing.Point(361, 7);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(83, 58);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DbSyc_Client.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(206, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 58);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpload.Location = new System.Drawing.Point(272, 7);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(83, 58);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 352);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(460, 11);
            this.pb.TabIndex = 6;
            this.pb.Visible = false;
            // 
            // DbSycMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(460, 363);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pnlCommand);
            this.Controls.Add(this.LV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(424, 402);
            this.Name = "DbSycMainFrm";
            this.Text = "File Transfer";
            this.Load += new System.EventHandler(this.DbSycMainFrm_Load);
            this.pnlCommand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlCommand;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button btnOption;
    }
}

