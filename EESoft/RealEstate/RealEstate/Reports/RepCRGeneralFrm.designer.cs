namespace RealEstate
{
    partial class RepCRGeneralFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCRGeneralFrm));
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewer.Location = new System.Drawing.Point(0, 0);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.Size = new System.Drawing.Size(900, 712);
            this.CRViewer.TabIndex = 0;
            // 
            // RepCRGeneralFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 712);
            this.Controls.Add(this.CRViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepCRGeneralFrm";
            this.Text = "تقرير";
            this.Load += new System.EventHandler(this.RepCRGeneralFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;

    }
}