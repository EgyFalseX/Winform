namespace schoolStore
{
    partial class MSGBOXFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSGBOXFrm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxCoLogo = new System.Windows.Forms.PictureBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblErrorNo = new System.Windows.Forms.Label();
            this.PnlErrorNo = new System.Windows.Forms.Panel();
            this.TxtMSG = new System.Windows.Forms.TextBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCoLogo)).BeginInit();
            this.PnlErrorNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PictureBoxCoLogo);
            this.Panel1.Location = new System.Drawing.Point(12, 176);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(120, 70);
            this.Panel1.TabIndex = 6;
            // 
            // PictureBoxCoLogo
            // 
            this.PictureBoxCoLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxCoLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxCoLogo.Image = global::schoolStore.Properties.Resources.MSGBOXCoLogo;
            this.PictureBoxCoLogo.InitialImage = null;
            this.PictureBoxCoLogo.Location = new System.Drawing.Point(9, 9);
            this.PictureBoxCoLogo.Name = "PictureBoxCoLogo";
            this.PictureBoxCoLogo.Size = new System.Drawing.Size(100, 50);
            this.PictureBoxCoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCoLogo.TabIndex = 2;
            this.PictureBoxCoLogo.TabStop = false;
            this.PictureBoxCoLogo.Visible = false;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.Black;
            this.BtnOk.Location = new System.Drawing.Point(256, 219);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(132, 24);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Error Number:";
            // 
            // LblErrorNo
            // 
            this.LblErrorNo.AutoSize = true;
            this.LblErrorNo.Location = new System.Drawing.Point(84, 6);
            this.LblErrorNo.Name = "LblErrorNo";
            this.LblErrorNo.Size = new System.Drawing.Size(13, 13);
            this.LblErrorNo.TabIndex = 7;
            this.LblErrorNo.Text = "0";
            // 
            // PnlErrorNo
            // 
            this.PnlErrorNo.BackColor = System.Drawing.Color.Transparent;
            this.PnlErrorNo.Controls.Add(this.label1);
            this.PnlErrorNo.Controls.Add(this.LblErrorNo);
            this.PnlErrorNo.Location = new System.Drawing.Point(12, 61);
            this.PnlErrorNo.Name = "PnlErrorNo";
            this.PnlErrorNo.Size = new System.Drawing.Size(376, 25);
            this.PnlErrorNo.TabIndex = 8;
            this.PnlErrorNo.Visible = false;
            // 
            // TxtMSG
            // 
            this.TxtMSG.BackColor = System.Drawing.Color.LightYellow;
            this.TxtMSG.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMSG.ForeColor = System.Drawing.Color.Black;
            this.TxtMSG.Location = new System.Drawing.Point(12, 92);
            this.TxtMSG.Multiline = true;
            this.TxtMSG.Name = "TxtMSG";
            this.TxtMSG.ReadOnly = true;
            this.TxtMSG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtMSG.Size = new System.Drawing.Size(376, 78);
            this.TxtMSG.TabIndex = 9;
            this.TxtMSG.Text = "No Data";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxIcon.Image = global::schoolStore.Properties.Resources.MSGBOX_Error;
            this.pictureBoxIcon.InitialImage = null;
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(400, 55);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // MSGBOXFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::schoolStore.Properties.Resources.MSGBOXFrm;
            this.ClientSize = new System.Drawing.Size(400, 255);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.TxtMSG);
            this.Controls.Add(this.PnlErrorNo);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSGBOXFrm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "schoolStore Message";
            this.Load += new System.EventHandler(this.MSGBOXFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MSGBOXFrm_MouseUp);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCoLogo)).EndInit();
            this.PnlErrorNo.ResumeLayout(false);
            this.PnlErrorNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBoxCoLogo;
        internal System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblErrorNo;
        private System.Windows.Forms.Panel PnlErrorNo;
        private System.Windows.Forms.TextBox TxtMSG;
        internal System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}