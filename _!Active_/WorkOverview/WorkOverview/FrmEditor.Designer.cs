namespace WorkOverview
{
    partial class FrmEditor
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
            this.PicCubeImage = new System.Windows.Forms.PictureBox();
            this.BtnSelectImage = new System.Windows.Forms.Button();
            this.LblPath = new System.Windows.Forms.Label();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CBAllCubes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeleteCube = new System.Windows.Forms.Button();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicCubeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCubeImage
            // 
            this.PicCubeImage.Location = new System.Drawing.Point(0, 0);
            this.PicCubeImage.Name = "PicCubeImage";
            this.PicCubeImage.Size = new System.Drawing.Size(320, 240);
            this.PicCubeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCubeImage.TabIndex = 0;
            this.PicCubeImage.TabStop = false;
            // 
            // BtnSelectImage
            // 
            this.BtnSelectImage.Location = new System.Drawing.Point(12, 246);
            this.BtnSelectImage.Name = "BtnSelectImage";
            this.BtnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectImage.TabIndex = 1;
            this.BtnSelectImage.Text = "Load Image";
            this.BtnSelectImage.UseVisualStyleBackColor = true;
            this.BtnSelectImage.Click += new System.EventHandler(this.BtnSelectImage_Click);
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(93, 251);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(0, 13);
            this.LblPath.TabIndex = 2;
            // 
            // TxtInfo
            // 
            this.TxtInfo.Location = new System.Drawing.Point(12, 275);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtInfo.Size = new System.Drawing.Size(565, 155);
            this.TxtInfo.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(257, 444);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Add";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cube Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(394, 220);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(183, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // CBAllCubes
            // 
            this.CBAllCubes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAllCubes.FormattingEnabled = true;
            this.CBAllCubes.Location = new System.Drawing.Point(394, 12);
            this.CBAllCubes.Name = "CBAllCubes";
            this.CBAllCubes.Size = new System.Drawing.Size(183, 21);
            this.CBAllCubes.TabIndex = 6;
            this.CBAllCubes.SelectedIndexChanged += new System.EventHandler(this.CBAllCubes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Cubes";
            // 
            // BtnDeleteCube
            // 
            this.BtnDeleteCube.Enabled = false;
            this.BtnDeleteCube.Location = new System.Drawing.Point(489, 39);
            this.BtnDeleteCube.Name = "BtnDeleteCube";
            this.BtnDeleteCube.Size = new System.Drawing.Size(88, 23);
            this.BtnDeleteCube.TabIndex = 8;
            this.BtnDeleteCube.Text = "Delete Cube";
            this.BtnDeleteCube.UseVisualStyleBackColor = true;
            this.BtnDeleteCube.Click += new System.EventHandler(this.BtnDeleteCube_Click);
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Enabled = false;
            this.BtnSaveChanges.Location = new System.Drawing.Point(395, 39);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(88, 23);
            this.BtnSaveChanges.TabIndex = 8;
            this.BtnSaveChanges.Text = "Update";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // FrmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 479);
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.BtnDeleteCube);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBAllCubes);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.BtnSelectImage);
            this.Controls.Add(this.PicCubeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmEditor";
            this.Text = "FrmEditor";
            this.Load += new System.EventHandler(this.FrmEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicCubeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicCubeImage;
        private System.Windows.Forms.Button BtnSelectImage;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CBAllCubes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDeleteCube;
        private System.Windows.Forms.Button BtnSaveChanges;
    }
}