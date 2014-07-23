namespace FunctionLib
{
    partial class SQLConnectionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLConnectionFrm));
            this.SqlConnectionUC = new FunctionLib.SQLConnectionUC();
            this.SuspendLayout();
            // 
            // SqlConnectionUC
            // 
            this.SqlConnectionUC.BackColor = System.Drawing.Color.Transparent;
            this.SqlConnectionUC.Location = new System.Drawing.Point(11, 12);
            this.SqlConnectionUC.Name = "SqlConnectionUC";
            this.SqlConnectionUC.Size = new System.Drawing.Size(319, 445);
            this.SqlConnectionUC.TabIndex = 0;
            this.SqlConnectionUC.Load += new System.EventHandler(this.SqlConnectionUC_Load);
            // 
            // SQLConnectionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FunctionLib.Properties.Resources.Background_02;
            this.ClientSize = new System.Drawing.Size(341, 461);
            this.Controls.Add(this.SqlConnectionUC);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SQLConnectionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " - SQL Connection - ";
            this.Load += new System.EventHandler(this.SQLConnectionFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SQLConnectionUC SqlConnectionUC;






    }
}