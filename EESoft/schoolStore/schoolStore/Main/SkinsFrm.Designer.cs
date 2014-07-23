namespace schoolStore
{
    partial class SkinsFrm
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
            this.galleryControlSkins = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlSkins)).BeginInit();
            this.galleryControlSkins.SuspendLayout();
            this.SuspendLayout();
            // 
            // galleryControlSkins
            // 
            this.galleryControlSkins.Controls.Add(this.galleryControlClient1);
            this.galleryControlSkins.DesignGalleryGroupIndex = 0;
            this.galleryControlSkins.DesignGalleryItemIndex = 0;
            this.galleryControlSkins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryControlSkins.Location = new System.Drawing.Point(0, 0);
            this.galleryControlSkins.Name = "galleryControlSkins";
            this.galleryControlSkins.Size = new System.Drawing.Size(484, 362);
            this.galleryControlSkins.TabIndex = 1;
            this.galleryControlSkins.Text = "الاشكال";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControlSkins;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(463, 358);
            // 
            // SkinsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.galleryControlSkins);
            this.Name = "SkinsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الاشكال";
            this.Load += new System.EventHandler(this.SkinsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlSkins)).EndInit();
            this.galleryControlSkins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControlSkins;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}