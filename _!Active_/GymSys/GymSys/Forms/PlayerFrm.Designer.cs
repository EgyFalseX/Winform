namespace GymSys
{
    partial class PlayerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميـــل";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(90, 141);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(9, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtName.Size = new System.Drawing.Size(159, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(171, 141);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "تليـــفون";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(9, 38);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtPhone.Size = new System.Drawing.Size(159, 20);
            this.TxtPhone.TabIndex = 1;
            this.TxtPhone.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "موبيـــل";
            // 
            // TxtMob
            // 
            this.TxtMob.Location = new System.Drawing.Point(9, 64);
            this.TxtMob.Name = "TxtMob";
            this.TxtMob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtMob.Size = new System.Drawing.Size(159, 20);
            this.TxtMob.TabIndex = 2;
            this.TxtMob.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "عنـــوان";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(9, 90);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtAddress.Size = new System.Drawing.Size(159, 20);
            this.TxtAddress.TabIndex = 3;
            this.TxtAddress.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "رقم قومـــي";
            // 
            // TxtSIN
            // 
            this.TxtSIN.Location = new System.Drawing.Point(9, 116);
            this.TxtSIN.Name = "TxtSIN";
            this.TxtSIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtSIN.Size = new System.Drawing.Size(159, 20);
            this.TxtSIN.TabIndex = 4;
            this.TxtSIN.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // PlayerFrm
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(255, 169);
            this.Controls.Add(this.TxtSIN);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtMob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العمـــلاء";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSIN;
    }
}