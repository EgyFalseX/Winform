namespace DataCenter.Forms
{
    partial class MSGDLG
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.pb = new System.Windows.Forms.PictureBox();
            this.tbMSG = new DevExpress.XtraEditors.MemoEdit();
            this.tbDetails = new DevExpress.XtraEditors.MemoExEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMSG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(282, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "اغلاق";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(7, 8);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(64, 64);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 3;
            this.pb.TabStop = false;
            // 
            // tbMSG
            // 
            this.tbMSG.Location = new System.Drawing.Point(80, 8);
            this.tbMSG.Name = "tbMSG";
            this.tbMSG.Properties.AllowFocused = false;
            this.tbMSG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbMSG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbMSG.Properties.Appearance.Options.UseBackColor = true;
            this.tbMSG.Properties.Appearance.Options.UseFont = true;
            this.tbMSG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tbMSG.Properties.ReadOnly = true;
            this.tbMSG.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMSG.Properties.UseParentBackground = true;
            this.tbMSG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbMSG.Size = new System.Drawing.Size(302, 88);
            this.tbMSG.TabIndex = 2;
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(12, 113);
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbDetails.Size = new System.Drawing.Size(100, 20);
            this.tbDetails.TabIndex = 1;
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
            this.panelControl1.TabIndex = 4;
            // 
            // MSGDLG
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(394, 137);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tbDetails);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MSGDLG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MSGDLG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMSG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.PictureBox pb;
        private DevExpress.XtraEditors.MemoEdit tbMSG;
        private DevExpress.XtraEditors.MemoExEdit tbDetails;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}