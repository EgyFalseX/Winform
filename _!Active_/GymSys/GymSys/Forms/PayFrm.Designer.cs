namespace GymSys
{
    partial class PayFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayFrm));
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.CBPlayer = new System.Windows.Forms.ComboBox();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblRemaining = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DTP
            // 
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(12, 39);
            this.DTP.Name = "DTP";
            this.DTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DTP.Size = new System.Drawing.Size(159, 20);
            this.DTP.TabIndex = 14;
            // 
            // CBPlayer
            // 
            this.CBPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPlayer.FormattingEnabled = true;
            this.CBPlayer.Location = new System.Drawing.Point(12, 12);
            this.CBPlayer.Name = "CBPlayer";
            this.CBPlayer.Size = new System.Drawing.Size(159, 21);
            this.CBPlayer.TabIndex = 13;
            this.CBPlayer.SelectedIndexChanged += new System.EventHandler(this.CBPlayer_SelectedIndexChanged);
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(96, 65);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCost.Size = new System.Drawing.Size(75, 20);
            this.TxtCost.TabIndex = 15;
            this.TxtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(177, 88);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdd.Location = new System.Drawing.Point(96, 88);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "اسم العميــل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "المبلغ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "تاريخ الدفـعه";
            // 
            // LblRemaining
            // 
            this.LblRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRemaining.Location = new System.Drawing.Point(12, 65);
            this.LblRemaining.Name = "LblRemaining";
            this.LblRemaining.ReadOnly = true;
            this.LblRemaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblRemaining.Size = new System.Drawing.Size(75, 20);
            this.LblRemaining.TabIndex = 15;
            this.LblRemaining.Text = "0";
            this.LblRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 116);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.CBPlayer);
            this.Controls.Add(this.LblRemaining);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدفـعـــات";
            this.Load += new System.EventHandler(this.PayFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.ComboBox CBPlayer;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LblRemaining;
    }
}