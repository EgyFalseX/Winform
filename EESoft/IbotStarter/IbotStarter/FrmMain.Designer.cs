namespace IbotStarter
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnExit = new System.Windows.Forms.Button();
            this.notifyIconIbot = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(56, 10);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // notifyIconIbot
            // 
            this.notifyIconIbot.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconIbot.Icon")));
            this.notifyIconIbot.Text = "Ibot Starter";
            this.notifyIconIbot.Visible = true;
            this.notifyIconIbot.DoubleClick += new System.EventHandler(this.notifyIconIbot_DoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 42);
            this.Controls.Add(this.BtnExit);
            this.Name = "FrmMain";
            this.Text = "Ibot Starter";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.NotifyIcon notifyIconIbot;
    }
}

