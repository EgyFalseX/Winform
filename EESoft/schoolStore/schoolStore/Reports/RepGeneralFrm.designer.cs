namespace schoolStore
{
    partial class RepGeneralFrm
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
            this.RVGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RVGeneral
            // 
            this.RVGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RVGeneral.Location = new System.Drawing.Point(0, 0);
            this.RVGeneral.Name = "RVGeneral";
            this.RVGeneral.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.RVGeneral.Size = new System.Drawing.Size(884, 562);
            this.RVGeneral.TabIndex = 0;
            // 
            // RepGeneralFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.RVGeneral);
            this.Name = "RepGeneralFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Text = "تقرير";
            this.Load += new System.EventHandler(this.RepGeneralFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVGeneral;

    }
}