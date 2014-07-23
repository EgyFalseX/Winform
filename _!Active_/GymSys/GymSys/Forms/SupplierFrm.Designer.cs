namespace GymSys
{
    partial class SupplierFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierFrm));
            this.BtnOptions = new System.Windows.Forms.RadioButton();
            this.BtnPay = new System.Windows.Forms.RadioButton();
            this.BtnBills = new System.Windows.Forms.RadioButton();
            this.BtnPlayers = new System.Windows.Forms.RadioButton();
            this.LblBotton = new System.Windows.Forms.Label();
            this.LblLeft = new System.Windows.Forms.Label();
            this.Btnmin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LbRight = new System.Windows.Forms.Label();
            this.LblConnection = new System.Windows.Forms.Label();
            this.BtnPayments = new System.Windows.Forms.RadioButton();
            this.BtnStorage = new System.Windows.Forms.RadioButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOptions
            // 
            this.BtnOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnOptions.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnOptions.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnOptions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnOptions.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.BtnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.BtnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOptions.Location = new System.Drawing.Point(8, 253);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(140, 30);
            this.BtnOptions.TabIndex = 7;
            this.BtnOptions.Text = "خيارات";
            this.BtnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOptions.UseVisualStyleBackColor = false;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // BtnPay
            // 
            this.BtnPay.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnPay.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.BtnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.BtnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.Location = new System.Drawing.Point(8, 146);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(140, 30);
            this.BtnPay.TabIndex = 6;
            this.BtnPay.Text = "الدفعــــــات";
            this.BtnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnBills
            // 
            this.BtnBills.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnBills.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnBills.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBills.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.BtnBills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.BtnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBills.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBills.Location = new System.Drawing.Point(8, 182);
            this.BtnBills.Name = "BtnBills";
            this.BtnBills.Size = new System.Drawing.Size(140, 30);
            this.BtnBills.TabIndex = 6;
            this.BtnBills.Text = "الاستعلامات";
            this.BtnBills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnBills.UseVisualStyleBackColor = false;
            // 
            // BtnPlayers
            // 
            this.BtnPlayers.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnPlayers.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPlayers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPlayers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.BtnPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.BtnPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayers.Location = new System.Drawing.Point(8, 38);
            this.BtnPlayers.Name = "BtnPlayers";
            this.BtnPlayers.Size = new System.Drawing.Size(140, 30);
            this.BtnPlayers.TabIndex = 2;
            this.BtnPlayers.Text = "العمــــلاء";
            this.BtnPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPlayers.UseVisualStyleBackColor = false;
            this.BtnPlayers.Click += new System.EventHandler(this.BtnPlayers_Click);
            // 
            // LblBotton
            // 
            this.LblBotton.BackColor = System.Drawing.Color.DarkBlue;
            this.LblBotton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblBotton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBotton.ForeColor = System.Drawing.Color.Lime;
            this.LblBotton.Location = new System.Drawing.Point(6, 325);
            this.LblBotton.Name = "LblBotton";
            this.LblBotton.Size = new System.Drawing.Size(144, 5);
            this.LblBotton.TabIndex = 14;
            this.LblBotton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLeft
            // 
            this.LblLeft.BackColor = System.Drawing.Color.DarkBlue;
            this.LblLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblLeft.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLeft.ForeColor = System.Drawing.Color.Lime;
            this.LblLeft.Location = new System.Drawing.Point(0, 35);
            this.LblLeft.Name = "LblLeft";
            this.LblLeft.Size = new System.Drawing.Size(6, 295);
            this.LblLeft.TabIndex = 13;
            this.LblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btnmin
            // 
            this.Btnmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnmin.BackColor = System.Drawing.Color.DarkOrange;
            this.Btnmin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btnmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Btnmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmin.Location = new System.Drawing.Point(80, 289);
            this.Btnmin.Name = "Btnmin";
            this.Btnmin.Size = new System.Drawing.Size(68, 30);
            this.Btnmin.TabIndex = 8;
            this.Btnmin.Text = "تصغيــر";
            this.Btnmin.UseVisualStyleBackColor = false;
            this.Btnmin.Click += new System.EventHandler(this.Btnmin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(8, 289);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(68, 30);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LbRight
            // 
            this.LbRight.BackColor = System.Drawing.Color.DarkBlue;
            this.LbRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.LbRight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRight.ForeColor = System.Drawing.Color.Lime;
            this.LbRight.Location = new System.Drawing.Point(150, 35);
            this.LbRight.Name = "LbRight";
            this.LbRight.Size = new System.Drawing.Size(18, 295);
            this.LbRight.TabIndex = 12;
            this.LbRight.Text = "01/  01/  1999";
            this.LbRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblConnection
            // 
            this.LblConnection.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblConnection.BackColor = System.Drawing.Color.DarkBlue;
            this.LblConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblConnection.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnection.ForeColor = System.Drawing.Color.Lime;
            this.LblConnection.Location = new System.Drawing.Point(-1, 215);
            this.LblConnection.Name = "LblConnection";
            this.LblConnection.Size = new System.Drawing.Size(168, 35);
            this.LblConnection.TabIndex = 11;
            this.LblConnection.Text = "----------";
            this.LblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPayments
            // 
            this.BtnPayments.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnPayments.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPayments.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPayments.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.BtnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.BtnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPayments.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayments.Location = new System.Drawing.Point(8, 110);
            this.BtnPayments.Name = "BtnPayments";
            this.BtnPayments.Size = new System.Drawing.Size(140, 30);
            this.BtnPayments.TabIndex = 5;
            this.BtnPayments.Text = "الاشتراكات";
            this.BtnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPayments.UseVisualStyleBackColor = false;
            this.BtnPayments.Click += new System.EventHandler(this.BtnPayments_Click);
            // 
            // BtnStorage
            // 
            this.BtnStorage.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnStorage.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnStorage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnStorage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.BtnStorage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.BtnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStorage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStorage.Location = new System.Drawing.Point(8, 74);
            this.BtnStorage.Name = "BtnStorage";
            this.BtnStorage.Size = new System.Drawing.Size(140, 30);
            this.BtnStorage.TabIndex = 4;
            this.BtnStorage.Text = "الحضور";
            this.BtnStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnStorage.UseVisualStyleBackColor = false;
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.DarkBlue;
            this.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitle.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.Lime;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(168, 35);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Gym Manager";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Controls.Add(this.BtnOptions);
            this.PanelMain.Controls.Add(this.BtnPay);
            this.PanelMain.Controls.Add(this.BtnBills);
            this.PanelMain.Controls.Add(this.BtnPlayers);
            this.PanelMain.Controls.Add(this.LblBotton);
            this.PanelMain.Controls.Add(this.LblLeft);
            this.PanelMain.Controls.Add(this.Btnmin);
            this.PanelMain.Controls.Add(this.BtnExit);
            this.PanelMain.Controls.Add(this.LbRight);
            this.PanelMain.Controls.Add(this.LblConnection);
            this.PanelMain.Controls.Add(this.BtnPayments);
            this.PanelMain.Controls.Add(this.BtnStorage);
            this.PanelMain.Controls.Add(this.LblTitle);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(170, 332);
            this.PanelMain.TabIndex = 1;
            // 
            // SupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(170, 332);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System";
            this.PanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RadioButton BtnOptions;
        internal System.Windows.Forms.RadioButton BtnPay;
        internal System.Windows.Forms.RadioButton BtnBills;
        internal System.Windows.Forms.RadioButton BtnPlayers;
        internal System.Windows.Forms.Label LblBotton;
        internal System.Windows.Forms.Label LblLeft;
        internal System.Windows.Forms.Button Btnmin;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Label LbRight;
        internal System.Windows.Forms.Label LblConnection;
        internal System.Windows.Forms.RadioButton BtnPayments;
        internal System.Windows.Forms.RadioButton BtnStorage;
        internal System.Windows.Forms.Label LblTitle;
        internal System.Windows.Forms.Panel PanelMain;

    }
}

