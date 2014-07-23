namespace Synricate
{
    partial class ImgViewerFrm
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
            this.Img = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // Img
            // 
            this.Img.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Img.Location = new System.Drawing.Point(12, 12);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(220, 154);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img.TabIndex = 0;
            this.Img.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(85, 78);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(1, 1);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ImgViewerFrm
            // 
            this.AcceptButton = this.BtnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(244, 178);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImgViewerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عارض الصور";
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        public System.Windows.Forms.PictureBox Img;
    }
}