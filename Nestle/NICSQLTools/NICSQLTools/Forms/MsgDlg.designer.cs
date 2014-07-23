namespace System.Windows.Forms
{
    partial class MsgDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgDlg));
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.tbMSG = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pb = new System.Windows.Forms.PictureBox();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.tbStackTrace = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbMSG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnYes.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Image = global::NICSQLTools.Properties.Resources.done;
            this.btnYes.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnYes.Location = new System.Drawing.Point(4, 106);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 32);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            // 
            // tbMSG
            // 
            this.tbMSG.EditValue = "";
            this.tbMSG.Location = new System.Drawing.Point(82, 12);
            this.tbMSG.Name = "tbMSG";
            this.tbMSG.Properties.AllowFocused = false;
            this.tbMSG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbMSG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMSG.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.tbMSG.Properties.Appearance.Options.UseBackColor = true;
            this.tbMSG.Properties.Appearance.Options.UseFont = true;
            this.tbMSG.Properties.Appearance.Options.UseForeColor = true;
            this.tbMSG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tbMSG.Properties.ReadOnly = true;
            this.tbMSG.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMSG.Size = new System.Drawing.Size(302, 84);
            this.tbMSG.TabIndex = 0;
            this.tbMSG.TabStop = false;
            this.tbMSG.UseOptimizedRendering = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.tbMSG);
            this.panelControl1.Controls.Add(this.pb);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(394, 100);
            this.panelControl1.TabIndex = 2;
            // 
            // pb
            // 
            this.pb.Image = global::NICSQLTools.Properties.Resources.Question;
            this.pb.Location = new System.Drawing.Point(8, 14);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(64, 64);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 3;
            this.pb.TabStop = false;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Image = global::NICSQLTools.Properties.Resources.error;
            this.btnNo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNo.Location = new System.Drawing.Point(290, 106);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 32);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "No";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::NICSQLTools.Properties.Resources.Delete;
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(147, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            // 
            // tbStackTrace
            // 
            this.tbStackTrace.BackColor = System.Drawing.Color.Gainsboro;
            this.tbStackTrace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbStackTrace.ForeColor = System.Drawing.Color.DimGray;
            this.tbStackTrace.Location = new System.Drawing.Point(0, 157);
            this.tbStackTrace.Multiline = true;
            this.tbStackTrace.Name = "tbStackTrace";
            this.tbStackTrace.ReadOnly = true;
            this.tbStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStackTrace.Size = new System.Drawing.Size(394, 108);
            this.tbStackTrace.TabIndex = 3;
            // 
            // MsgDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(394, 265);
            this.Controls.Add(this.tbStackTrace);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MsgDlg";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.msgDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMSG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYes;
        private System.Windows.Forms.PictureBox pb;
        private DevExpress.XtraEditors.MemoEdit tbMSG;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private TextBox tbStackTrace;

    }
}