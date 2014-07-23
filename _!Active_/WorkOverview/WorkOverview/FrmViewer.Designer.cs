namespace WorkOverview
{
    partial class FrmViewer
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
            this.LBCubes = new System.Windows.Forms.ListBox();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.BtnShowEditor = new System.Windows.Forms.Button();
            this.BtnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBCubes
            // 
            this.LBCubes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LBCubes.FormattingEnabled = true;
            this.LBCubes.Location = new System.Drawing.Point(413, 38);
            this.LBCubes.Name = "LBCubes";
            this.LBCubes.Size = new System.Drawing.Size(228, 433);
            this.LBCubes.TabIndex = 2;
            this.LBCubes.SelectedIndexChanged += new System.EventHandler(this.LBCubes_SelectedIndexChanged);
            // 
            // Pic1
            // 
            this.Pic1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic1.Location = new System.Drawing.Point(12, 25);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(395, 287);
            this.Pic1.TabIndex = 1;
            this.Pic1.TabStop = false;
            // 
            // TxtInfo
            // 
            this.TxtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInfo.Location = new System.Drawing.Point(12, 318);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtInfo.Size = new System.Drawing.Size(395, 179);
            this.TxtInfo.TabIndex = 4;
            // 
            // BtnShowEditor
            // 
            this.BtnShowEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShowEditor.Location = new System.Drawing.Point(413, 477);
            this.BtnShowEditor.Name = "BtnShowEditor";
            this.BtnShowEditor.Size = new System.Drawing.Size(228, 23);
            this.BtnShowEditor.TabIndex = 3;
            this.BtnShowEditor.Text = "Editor";
            this.BtnShowEditor.UseVisualStyleBackColor = true;
            this.BtnShowEditor.Click += new System.EventHandler(this.BtnShowEditor_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReload.Location = new System.Drawing.Point(413, 12);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(228, 23);
            this.BtnReload.TabIndex = 1;
            this.BtnReload.Text = "Reload";
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // FrmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 512);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.BtnShowEditor);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.LBCubes);
            this.Name = "FrmViewer";
            this.Text = "Work Overview";
            this.Load += new System.EventHandler(this.FrmViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBCubes;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Button BtnShowEditor;
        private System.Windows.Forms.Button BtnReload;
    }
}

