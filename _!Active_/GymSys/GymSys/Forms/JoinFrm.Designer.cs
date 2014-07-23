namespace GymSys
{
    partial class JoinFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinFrm));
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBPlayer = new System.Windows.Forms.ComboBox();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(19, 80);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCost.Size = new System.Drawing.Size(159, 20);
            this.TxtCost.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(184, 104);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdd.Location = new System.Drawing.Point(103, 104);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "تاريخ الاشتراك";
            // 
            // CBPlayer
            // 
            this.CBPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPlayer.FormattingEnabled = true;
            this.CBPlayer.Location = new System.Drawing.Point(19, 0);
            this.CBPlayer.Name = "CBPlayer";
            this.CBPlayer.Size = new System.Drawing.Size(159, 21);
            this.CBPlayer.TabIndex = 0;
            // 
            // CBType
            // 
            this.CBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBType.FormattingEnabled = true;
            this.CBType.Location = new System.Drawing.Point(19, 27);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(159, 21);
            this.CBType.TabIndex = 1;
            this.CBType.SelectedIndexChanged += new System.EventHandler(this.CBType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "اسم العميــل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "نوع الاشتــراك";
            // 
            // DTP
            // 
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(19, 54);
            this.DTP.Name = "DTP";
            this.DTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DTP.Size = new System.Drawing.Size(159, 20);
            this.DTP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "المبلغ";
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Location = new System.Drawing.Point(16, 109);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(13, 13);
            this.LblDays.TabIndex = 12;
            this.LblDays.Text = "0";
            // 
            // JoinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 133);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.CBPlayer);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JoinFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاشتــراك";
            this.Load += new System.EventHandler(this.JoinFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBPlayer;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDays;
    }
}