namespace Employee
{
    partial class AppOptionsFrm
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
            this.BtnChangePic = new System.Windows.Forms.Button();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.BtnDBMange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnChangePic
            // 
            this.BtnChangePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnChangePic.Location = new System.Drawing.Point(34, 135);
            this.BtnChangePic.Name = "BtnChangePic";
            this.BtnChangePic.Size = new System.Drawing.Size(75, 23);
            this.BtnChangePic.TabIndex = 1;
            this.BtnChangePic.Text = "...";
            this.BtnChangePic.UseVisualStyleBackColor = true;
            this.BtnChangePic.Click += new System.EventHandler(this.BtnChangePic_Click);
            // 
            // PBImage
            // 
            this.PBImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBImage.Location = new System.Drawing.Point(12, 12);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(118, 117);
            this.PBImage.TabIndex = 0;
            this.PBImage.TabStop = false;
            // 
            // BtnDBMange
            // 
            this.BtnDBMange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDBMange.Location = new System.Drawing.Point(147, 12);
            this.BtnDBMange.Name = "BtnDBMange";
            this.BtnDBMange.Size = new System.Drawing.Size(75, 117);
            this.BtnDBMange.TabIndex = 2;
            this.BtnDBMange.Text = "Backup\r\nRestore";
            this.BtnDBMange.UseVisualStyleBackColor = true;
            this.BtnDBMange.Click += new System.EventHandler(this.BtnDBMange_Click);
            // 
            // AppOptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 168);
            this.Controls.Add(this.BtnDBMange);
            this.Controls.Add(this.BtnChangePic);
            this.Controls.Add(this.PBImage);
            this.Name = "AppOptionsFrm";
            this.Text = "AppOptionsFrm";
            this.Load += new System.EventHandler(this.AppOptionsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImage;
        private System.Windows.Forms.Button BtnChangePic;
        private System.Windows.Forms.Button BtnDBMange;
    }
}