namespace DataCenter_Server
{
    partial class StuFileTypeFrm
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.CBTypes = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIcon = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(68, 65);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(60, 23);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "تعديل";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // CBTypes
            // 
            this.CBTypes.FormattingEnabled = true;
            this.CBTypes.Location = new System.Drawing.Point(68, 12);
            this.CBTypes.Name = "CBTypes";
            this.CBTypes.Size = new System.Drawing.Size(121, 21);
            this.CBTypes.TabIndex = 2;
            this.CBTypes.SelectedIndexChanged += new System.EventHandler(this.CBTypes_SelectedIndexChanged);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(68, 39);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(121, 20);
            this.TxtName.TabIndex = 3;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Location = new System.Drawing.Point(12, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(50, 50);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(214, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الانواع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(195, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "تعديل الاسم";
            // 
            // BtnIcon
            // 
            this.BtnIcon.Location = new System.Drawing.Point(12, 65);
            this.BtnIcon.Name = "BtnIcon";
            this.BtnIcon.Size = new System.Drawing.Size(50, 23);
            this.BtnIcon.TabIndex = 0;
            this.BtnIcon.Text = "...";
            this.BtnIcon.UseVisualStyleBackColor = true;
            this.BtnIcon.Click += new System.EventHandler(this.BtnIcon_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(129, 65);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(60, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // StuFileTypeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My.Resources.Resources.EditFileTypesFrm;
            this.ClientSize = new System.Drawing.Size(262, 98);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.CBTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnIcon);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StuFileTypeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انواع ملفات الطلاب و العاملين";
            this.Load += new System.EventHandler(this.StuFileTypeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox CBTypes;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnIcon;
        private System.Windows.Forms.Button BtnAdd;
    }
}