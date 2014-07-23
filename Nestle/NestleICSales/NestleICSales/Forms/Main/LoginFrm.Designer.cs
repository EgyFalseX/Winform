namespace NestleICSales.Forms
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.tbname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.tbpass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.EditValue = "admin";
            this.tbname.Location = new System.Drawing.Point(174, 44);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(215, 20);
            this.tbname.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(172, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "username";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(300, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbpass
            // 
            this.tbpass.EditValue = "admin";
            this.tbpass.Location = new System.Drawing.Point(174, 101);
            this.tbpass.Name = "tbpass";
            this.tbpass.Properties.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(215, 20);
            this.tbpass.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(172, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(197, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Enter";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(12, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset connection config";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // LoginFrm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::NestleICSales.Properties.Resources.Login_Logo;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(401, 192);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tbname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.TextEdit tbpass;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnReset;
    }
}