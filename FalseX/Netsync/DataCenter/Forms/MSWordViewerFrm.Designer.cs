namespace DataCenter.Forms
{
    partial class MSWordViewerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSWordViewerFrm));
            this.rec = new DevExpress.XtraRichEdit.RichEditControl();
            this.SuspendLayout();
            // 
            // rec
            // 
            this.rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rec.Location = new System.Drawing.Point(0, 0);
            this.rec.Name = "rec";
            this.rec.Options.MailMerge.KeepLastParagraph = false;
            this.rec.ReadOnly = true;
            this.rec.Size = new System.Drawing.Size(584, 361);
            this.rec.TabIndex = 0;
            // 
            // MSWordViewerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.rec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSWordViewerFrm";
            this.Text = "عرض";
            this.Load += new System.EventHandler(this.MSWordViewerFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl rec;
    }
}