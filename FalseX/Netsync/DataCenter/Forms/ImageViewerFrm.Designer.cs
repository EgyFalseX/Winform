namespace DataCenter.Forms
{
    partial class ImageViewerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewerFrm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnSqueeze = new DevExpress.XtraEditors.SimpleButton();
            this.btnZoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnStretch = new DevExpress.XtraEditors.SimpleButton();
            this.btnClip = new DevExpress.XtraEditors.SimpleButton();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.Controls.Add(this.pbc);
            this.groupControl1.Controls.Add(this.btnSqueeze);
            this.groupControl1.Controls.Add(this.btnZoom);
            this.groupControl1.Controls.Add(this.btnStretch);
            this.groupControl1.Controls.Add(this.btnClip);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 298);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 63);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "خيارات";
            // 
            // pbc
            // 
            this.pbc.Location = new System.Drawing.Point(240, 30);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(132, 18);
            this.pbc.TabIndex = 4;
            this.pbc.Visible = false;
            // 
            // btnSqueeze
            // 
            this.btnSqueeze.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSqueeze.Location = new System.Drawing.Point(183, 28);
            this.btnSqueeze.Name = "btnSqueeze";
            this.btnSqueeze.Size = new System.Drawing.Size(51, 23);
            this.btnSqueeze.TabIndex = 3;
            this.btnSqueeze.Text = "Squeeze";
            this.btnSqueeze.Click += new System.EventHandler(this.btnSqueeze_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnZoom.Location = new System.Drawing.Point(126, 28);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(51, 23);
            this.btnZoom.TabIndex = 2;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnStretch
            // 
            this.btnStretch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStretch.Location = new System.Drawing.Point(69, 28);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(51, 23);
            this.btnStretch.TabIndex = 1;
            this.btnStretch.Text = "Stretch";
            this.btnStretch.Click += new System.EventHandler(this.btnStretch_Click);
            // 
            // btnClip
            // 
            this.btnClip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClip.Location = new System.Drawing.Point(12, 28);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(51, 23);
            this.btnClip.TabIndex = 0;
            this.btnClip.Text = "Clip";
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            // 
            // peImage
            // 
            this.peImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peImage.Location = new System.Drawing.Point(12, 12);
            this.peImage.Name = "peImage";
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Size = new System.Drawing.Size(360, 280);
            this.peImage.TabIndex = 0;
            // 
            // ImageViewerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.peImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageViewerFrm";
            this.Text = "عارض";
            this.Load += new System.EventHandler(this.ImageViewerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSqueeze;
        private DevExpress.XtraEditors.SimpleButton btnZoom;
        private DevExpress.XtraEditors.SimpleButton btnStretch;
        private DevExpress.XtraEditors.SimpleButton btnClip;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraEditors.PictureEdit peImage;
    }
}