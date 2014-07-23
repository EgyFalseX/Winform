namespace FXFW
{
    partial class LoggerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggerFrm));
            this.RTBMain = new System.Windows.Forms.RichTextBox();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // RTBMain
            // 
            this.RTBMain.BackColor = System.Drawing.Color.AliceBlue;
            this.RTBMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBMain.Location = new System.Drawing.Point(0, 0);
            this.RTBMain.Name = "RTBMain";
            this.RTBMain.ReadOnly = true;
            this.RTBMain.Size = new System.Drawing.Size(806, 354);
            this.RTBMain.TabIndex = 0;
            this.RTBMain.Text = "";
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "success.png");
            this.imageListMain.Images.SetKeyName(1, "fail.png");
            this.imageListMain.Images.SetKeyName(2, "warning.png");
            this.imageListMain.Images.SetKeyName(3, "infomation.png");
            // 
            // LoggerFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 354);
            this.Controls.Add(this.RTBMain);
            this.Name = "LoggerFrm2";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggerFrm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.RichTextBox RTBMain;
    }
}