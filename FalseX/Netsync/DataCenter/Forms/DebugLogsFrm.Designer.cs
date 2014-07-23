namespace DataCenter.Forms
{
    partial class DebugLogsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugLogsFrm));
            this.mLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // mLog
            // 
            this.mLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mLog.Location = new System.Drawing.Point(0, 0);
            this.mLog.Name = "mLog";
            this.mLog.Size = new System.Drawing.Size(595, 361);
            this.mLog.TabIndex = 0;
            this.mLog.Text = "";
            // 
            // LogsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 361);
            this.Controls.Add(this.mLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogsFrm";
            this.Text = "النتائج";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogsFrm_FormClosing);
            this.Load += new System.EventHandler(this.LogsFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mLog;

    }
}