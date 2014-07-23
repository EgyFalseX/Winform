namespace AccessReportVeiwer
{
    partial class XtraForm1
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
            this.btnprev = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(294, 164);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(75, 23);
            this.btnprev.TabIndex = 0;
            this.btnprev.Text = "preview";
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(294, 193);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 0;
            this.btnprint.Text = "print";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 532);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnprev);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnprev;
        private DevExpress.XtraEditors.SimpleButton btnprint;

    }
}