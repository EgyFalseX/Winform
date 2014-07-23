namespace schoolStore
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtUserName = new DevExpress.XtraEditors.TextEdit();
            this.BtnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.BtnEnd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(206, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم المستخدم";
            // 
            // TxtUserName
            // 
            this.TxtUserName.EditValue = "";
            this.TxtUserName.Location = new System.Drawing.Point(18, 17);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.TxtUserName.Size = new System.Drawing.Size(182, 22);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.EditValueChanged += new System.EventHandler(this.text_EditValueChanged);
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(18, 107);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(182, 23);
            this.BtnEnter.TabIndex = 2;
            this.BtnEnter.Text = "دخــــــــــــــــــــــــــول";
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(227, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "كلمة الســر";
            // 
            // TxtPassword
            // 
            this.TxtPassword.EditValue = "";
            this.TxtPassword.Location = new System.Drawing.Point(18, 48);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.TxtPassword.Properties.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(182, 22);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.EditValueChanged += new System.EventHandler(this.text_EditValueChanged);
            // 
            // BtnEnd
            // 
            this.BtnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEnd.Location = new System.Drawing.Point(215, 107);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(75, 23);
            this.BtnEnd.TabIndex = 3;
            this.BtnEnd.Text = "خروج";
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // LoginFrm
            // 
            this.AcceptButton = this.BtnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::schoolStore.Properties.Resources.Login_Back;
            this.CancelButton = this.BtnEnd;
            this.ClientSize = new System.Drawing.Size(288, 138);
            this.ControlBox = false;
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدميـــــــــــــن";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtUserName;
        private DevExpress.XtraEditors.SimpleButton BtnEnter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.SimpleButton BtnEnd;
    }
}