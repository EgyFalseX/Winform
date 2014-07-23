namespace RealEstate
{
    partial class ActionLogFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionLogFrm));
            this.TxtLog = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLog.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLog
            // 
            this.TxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtLog.EditValue = "";
            this.TxtLog.Location = new System.Drawing.Point(0, 0);
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtLog.Size = new System.Drawing.Size(384, 362);
            this.TxtLog.TabIndex = 0;
            // 
            // ActionLogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.TxtLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActionLogFrm";
            this.Text = "ارشيف الرسائل";
            this.Load += new System.EventHandler(this.ActionLogFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtLog.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit TxtLog;
    }
}