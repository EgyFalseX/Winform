namespace FXFW
{
    partial class LoggerTreeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggerFrm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TVMain = new System.Windows.Forms.TreeView();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.GBDetails = new System.Windows.Forms.GroupBox();
            this.TxtDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.GBDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TVMain);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GBDetails);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(784, 362);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 1;
            // 
            // TVMain
            // 
            this.TVMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TVMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVMain.FullRowSelect = true;
            this.TVMain.ImageIndex = 0;
            this.TVMain.ImageList = this.imageListMain;
            this.TVMain.Location = new System.Drawing.Point(0, 0);
            this.TVMain.Name = "TVMain";
            this.TVMain.SelectedImageIndex = 0;
            this.TVMain.ShowPlusMinus = false;
            this.TVMain.ShowRootLines = false;
            this.TVMain.Size = new System.Drawing.Size(784, 205);
            this.TVMain.TabIndex = 1;
            this.TVMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVMain_AfterSelect);
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "success.png");
            this.imageListMain.Images.SetKeyName(1, "fail.png");
            this.imageListMain.Images.SetKeyName(2, "warning.png");
            this.imageListMain.Images.SetKeyName(3, "infomation.png");
            // 
            // GBDetails
            // 
            this.GBDetails.BackColor = System.Drawing.SystemColors.Control;
            this.GBDetails.Controls.Add(this.TxtDetails);
            this.GBDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBDetails.Location = new System.Drawing.Point(0, 0);
            this.GBDetails.Name = "GBDetails";
            this.GBDetails.Size = new System.Drawing.Size(784, 153);
            this.GBDetails.TabIndex = 0;
            this.GBDetails.TabStop = false;
            this.GBDetails.Text = "  - Details -  ";
            // 
            // TxtDetails
            // 
            this.TxtDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDetails.Location = new System.Drawing.Point(3, 16);
            this.TxtDetails.Multiline = true;
            this.TxtDetails.Name = "TxtDetails";
            this.TxtDetails.ReadOnly = true;
            this.TxtDetails.Size = new System.Drawing.Size(778, 134);
            this.TxtDetails.TabIndex = 0;
            // 
            // LoggerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoggerFrm";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggerFrm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.GBDetails.ResumeLayout(false);
            this.GBDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TxtDetails;
        public System.Windows.Forms.GroupBox GBDetails;
        private System.Windows.Forms.ImageList imageListMain;
        public System.Windows.Forms.TreeView TVMain;
    }
}