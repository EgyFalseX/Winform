namespace Retirement
{
    partial class SplashFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashFrm));
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblProduct = new System.Windows.Forms.Label();
            this.LblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.ForeColor = System.Drawing.Color.Black;
            this.LblVersion.Location = new System.Drawing.Point(14, 211);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(42, 13);
            this.LblVersion.TabIndex = 0;
            this.LblVersion.Text = "Version";
            // 
            // LblProduct
            // 
            this.LblProduct.AutoSize = true;
            this.LblProduct.ForeColor = System.Drawing.Color.Black;
            this.LblProduct.Location = new System.Drawing.Point(12, 17);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(44, 13);
            this.LblProduct.TabIndex = 1;
            this.LblProduct.Text = "Product";
            // 
            // LblCopyright
            // 
            this.LblCopyright.AutoSize = true;
            this.LblCopyright.Font = new System.Drawing.Font("Tahoma", 8F);
            this.LblCopyright.ForeColor = System.Drawing.Color.Black;
            this.LblCopyright.Location = new System.Drawing.Point(12, 228);
            this.LblCopyright.Name = "LblCopyright";
            this.LblCopyright.Size = new System.Drawing.Size(54, 13);
            this.LblCopyright.TabIndex = 3;
            this.LblCopyright.Text = "Copyright";
            // 
            // SplashFrm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Retirement.Properties.Resources.SplashScreen;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.ControlBox = false;
            this.Controls.Add(this.LblCopyright);
            this.Controls.Add(this.LblProduct);
            this.Controls.Add(this.LblVersion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashFrm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Egy]FalseX2011";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.SplashFrm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SplashFrm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SplashFrm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.Label LblCopyright;


    }
}