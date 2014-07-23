namespace E_Club_Store_Manager
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.BtnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.BtnEnd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(206, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم المستخدم";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(18, 17);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit1.Size = new System.Drawing.Size(182, 21);
            this.textEdit1.TabIndex = 0;
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
            this.labelControl2.Location = new System.Drawing.Point(227, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "كلمة الســر";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(18, 48);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit2.Properties.PasswordChar = '*';
            this.textEdit2.Size = new System.Drawing.Size(182, 21);
            this.textEdit2.TabIndex = 1;
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(215, 107);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(75, 23);
            this.BtnEnd.TabIndex = 3;
            this.BtnEnd.Text = "خروج";
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::E_Club_Store_Manager.Properties.Resources.Login_Back;
            this.ClientSize = new System.Drawing.Size(308, 158);
            this.ControlBox = false;
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "المستخدميـــــــــــــن";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnEnter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton BtnEnd;
    }
}