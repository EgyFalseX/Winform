namespace System.Windows.Forms
{
    partial class msgDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgDlg));
            this.pbQ = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb = new System.Windows.Forms.RichTextBox();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQ
            // 
            this.pbQ.Image = ((System.Drawing.Image)(resources.GetObject("pbQ.Image")));
            this.pbQ.Location = new System.Drawing.Point(322, 14);
            this.pbQ.Name = "pbQ";
            this.pbQ.Size = new System.Drawing.Size(64, 64);
            this.pbQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQ.TabIndex = 3;
            this.pbQ.TabStop = false;
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnYes.Location = new System.Drawing.Point(294, 102);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 40);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "نـعـم";
            this.btnYes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCancel.Location = new System.Drawing.Point(147, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "اغلاق";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNo.Location = new System.Drawing.Point(0, 102);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 40);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "لا";
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb);
            this.panel1.Controls.Add(this.pbQ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 100);
            this.panel1.TabIndex = 4;
            // 
            // tb
            // 
            this.tb.BackColor = System.Drawing.Color.White;
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tb.ForeColor = System.Drawing.Color.Green;
            this.tb.Location = new System.Drawing.Point(12, 12);
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(302, 84);
            this.tb.TabIndex = 10;
            this.tb.TabStop = false;
            this.tb.Tag = "";
            this.tb.Text = "";
            // 
            // pbInfo
            // 
            this.pbInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbInfo.Image")));
            this.pbInfo.Location = new System.Drawing.Point(273, 125);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(15, 17);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInfo.TabIndex = 5;
            this.pbInfo.TabStop = false;
            this.pbInfo.Visible = false;
            // 
            // msgDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(394, 144);
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "msgDlg";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رسالة";
            this.Load += new System.EventHandler(this.MSGDLG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQ)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQ;
        private Button btnYes;
        private Button btnCancel;
        private Button btnNo;
        private Panel panel1;
        private RichTextBox tb;
        private PictureBox pbInfo;

    }
}