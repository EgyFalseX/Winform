namespace FXFW
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
            this.CBUseExpress = new System.Windows.Forms.CheckBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.GBDB = new System.Windows.Forms.GroupBox();
            this.PnlAttachDB = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.BtnDB = new System.Windows.Forms.Button();
            this.RBNotAttached = new System.Windows.Forms.RadioButton();
            this.PnlSelectDB = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.CBDBName = new System.Windows.Forms.ComboBox();
            this.RBAttached = new System.Windows.Forms.RadioButton();
            this.GBSecurity = new System.Windows.Forms.GroupBox();
            this.CBSqlAuth = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtReportSrvName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtReportSrvPort = new System.Windows.Forms.TextBox();
            this.TxtReportPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GBReport = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSSRSUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSSRSPassword = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.TxtSSRSDomain = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GBDB.SuspendLayout();
            this.PnlAttachDB.SuspendLayout();
            this.PnlSelectDB.SuspendLayout();
            this.GBSecurity.SuspendLayout();
            this.GBReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBUseExpress
            // 
            this.CBUseExpress.AutoSize = true;
            this.CBUseExpress.Location = new System.Drawing.Point(164, 42);
            this.CBUseExpress.Name = "CBUseExpress";
            this.CBUseExpress.Size = new System.Drawing.Size(110, 17);
            this.CBUseExpress.TabIndex = 1;
            this.CBUseExpress.Text = "Using Sql Express";
            this.CBUseExpress.UseVisualStyleBackColor = true;
            this.CBUseExpress.Click += new System.EventHandler(this.CBUseExpress_CheckedChanged);
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(135, 16);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(139, 20);
            this.txtserver.TabIndex = 73;
            this.txtserver.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(32, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 13);
            this.Label1.TabIndex = 75;
            this.Label1.Text = "Server Name or IP :";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Enabled = false;
            this.BtnConnect.ForeColor = System.Drawing.Color.Black;
            this.BtnConnect.Location = new System.Drawing.Point(135, 143);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(139, 23);
            this.BtnConnect.TabIndex = 5;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // GBDB
            // 
            this.GBDB.BackColor = System.Drawing.Color.Transparent;
            this.GBDB.Controls.Add(this.PnlAttachDB);
            this.GBDB.Controls.Add(this.RBNotAttached);
            this.GBDB.Controls.Add(this.PnlSelectDB);
            this.GBDB.Controls.Add(this.RBAttached);
            this.GBDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GBDB.ForeColor = System.Drawing.Color.Lime;
            this.GBDB.Location = new System.Drawing.Point(15, 192);
            this.GBDB.Name = "GBDB";
            this.GBDB.Size = new System.Drawing.Size(307, 117);
            this.GBDB.TabIndex = 71;
            this.GBDB.TabStop = false;
            this.GBDB.Text = " - DataBase Attachment - ";
            this.GBDB.Visible = false;
            // 
            // PnlAttachDB
            // 
            this.PnlAttachDB.Controls.Add(this.Label2);
            this.PnlAttachDB.Controls.Add(this.txtdatabase);
            this.PnlAttachDB.Controls.Add(this.BtnDB);
            this.PnlAttachDB.Location = new System.Drawing.Point(5, 75);
            this.PnlAttachDB.Name = "PnlAttachDB";
            this.PnlAttachDB.Size = new System.Drawing.Size(297, 32);
            this.PnlAttachDB.TabIndex = 62;
            this.PnlAttachDB.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(7, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 13);
            this.Label2.TabIndex = 50;
            this.Label2.Text = "Database Name :";
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(110, 7);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.ReadOnly = true;
            this.txtdatabase.Size = new System.Drawing.Size(139, 20);
            this.txtdatabase.TabIndex = 50;
            this.txtdatabase.TabStop = false;
            // 
            // BtnDB
            // 
            this.BtnDB.ForeColor = System.Drawing.Color.Black;
            this.BtnDB.Location = new System.Drawing.Point(250, 5);
            this.BtnDB.Name = "BtnDB";
            this.BtnDB.Size = new System.Drawing.Size(41, 23);
            this.BtnDB.TabIndex = 10;
            this.BtnDB.Text = "...";
            this.BtnDB.UseVisualStyleBackColor = true;
            this.BtnDB.Click += new System.EventHandler(this.BtnDB_Click);
            // 
            // RBNotAttached
            // 
            this.RBNotAttached.AutoSize = true;
            this.RBNotAttached.Location = new System.Drawing.Point(145, 15);
            this.RBNotAttached.Name = "RBNotAttached";
            this.RBNotAttached.Size = new System.Drawing.Size(87, 17);
            this.RBNotAttached.TabIndex = 8;
            this.RBNotAttached.TabStop = true;
            this.RBNotAttached.Text = "not attached";
            this.RBNotAttached.UseVisualStyleBackColor = true;
            this.RBNotAttached.CheckedChanged += new System.EventHandler(this.RBNotAttached_CheckedChanged);
            // 
            // PnlSelectDB
            // 
            this.PnlSelectDB.Controls.Add(this.Label5);
            this.PnlSelectDB.Controls.Add(this.CBDBName);
            this.PnlSelectDB.Location = new System.Drawing.Point(5, 38);
            this.PnlSelectDB.Name = "PnlSelectDB";
            this.PnlSelectDB.Size = new System.Drawing.Size(297, 32);
            this.PnlSelectDB.TabIndex = 62;
            this.PnlSelectDB.Visible = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(13, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(90, 13);
            this.Label5.TabIndex = 52;
            this.Label5.Text = "Database Name :";
            // 
            // CBDBName
            // 
            this.CBDBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDBName.FormattingEnabled = true;
            this.CBDBName.Location = new System.Drawing.Point(116, 6);
            this.CBDBName.Name = "CBDBName";
            this.CBDBName.Size = new System.Drawing.Size(139, 21);
            this.CBDBName.TabIndex = 9;
            // 
            // RBAttached
            // 
            this.RBAttached.AutoSize = true;
            this.RBAttached.Location = new System.Drawing.Point(49, 15);
            this.RBAttached.Name = "RBAttached";
            this.RBAttached.Size = new System.Drawing.Size(68, 17);
            this.RBAttached.TabIndex = 7;
            this.RBAttached.TabStop = true;
            this.RBAttached.Text = "attached";
            this.RBAttached.UseVisualStyleBackColor = true;
            this.RBAttached.CheckedChanged += new System.EventHandler(this.RBAttached_CheckedChanged);
            // 
            // GBSecurity
            // 
            this.GBSecurity.BackColor = System.Drawing.Color.Transparent;
            this.GBSecurity.Controls.Add(this.CBUseExpress);
            this.GBSecurity.Controls.Add(this.txtserver);
            this.GBSecurity.Controls.Add(this.Label1);
            this.GBSecurity.Controls.Add(this.BtnConnect);
            this.GBSecurity.Controls.Add(this.CBSqlAuth);
            this.GBSecurity.Controls.Add(this.Label3);
            this.GBSecurity.Controls.Add(this.TxtPW);
            this.GBSecurity.Controls.Add(this.Label4);
            this.GBSecurity.Controls.Add(this.TxtID);
            this.GBSecurity.ForeColor = System.Drawing.Color.Lime;
            this.GBSecurity.Location = new System.Drawing.Point(15, 13);
            this.GBSecurity.Name = "GBSecurity";
            this.GBSecurity.Size = new System.Drawing.Size(311, 173);
            this.GBSecurity.TabIndex = 67;
            this.GBSecurity.TabStop = false;
            this.GBSecurity.Text = "Security";
            // 
            // CBSqlAuth
            // 
            this.CBSqlAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSqlAuth.FormattingEnabled = true;
            this.CBSqlAuth.Items.AddRange(new object[] {
            "SQL Server Authentication",
            "Windows Authentication"});
            this.CBSqlAuth.Location = new System.Drawing.Point(94, 65);
            this.CBSqlAuth.Name = "CBSqlAuth";
            this.CBSqlAuth.Size = new System.Drawing.Size(180, 21);
            this.CBSqlAuth.TabIndex = 2;
            this.CBSqlAuth.SelectedIndexChanged += new System.EventHandler(this.CBSqlAuth_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(61, 95);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 13);
            this.Label3.TabIndex = 70;
            this.Label3.Text = "User Name :";
            // 
            // TxtPW
            // 
            this.TxtPW.Enabled = false;
            this.TxtPW.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPW.Location = new System.Drawing.Point(135, 116);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.PasswordChar = 'x';
            this.TxtPW.Size = new System.Drawing.Size(139, 21);
            this.TxtPW.TabIndex = 4;
            this.TxtPW.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(61, 116);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(60, 13);
            this.Label4.TabIndex = 72;
            this.Label4.Text = "Password :";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(135, 92);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(139, 20);
            this.TxtID.TabIndex = 3;
            this.TxtID.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // TxtReportSrvName
            // 
            this.TxtReportSrvName.Location = new System.Drawing.Point(14, 32);
            this.TxtReportSrvName.Name = "TxtReportSrvName";
            this.TxtReportSrvName.Size = new System.Drawing.Size(139, 20);
            this.TxtReportSrvName.TabIndex = 11;
            this.TxtReportSrvName.Text = "ReportServer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Report Server Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(153, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Reports Path :";
            // 
            // TxtReportSrvPort
            // 
            this.TxtReportSrvPort.Location = new System.Drawing.Point(14, 71);
            this.TxtReportSrvPort.Name = "TxtReportSrvPort";
            this.TxtReportSrvPort.Size = new System.Drawing.Size(139, 20);
            this.TxtReportSrvPort.TabIndex = 13;
            this.TxtReportSrvPort.Text = "8080";
            // 
            // TxtReportPath
            // 
            this.TxtReportPath.Location = new System.Drawing.Point(156, 32);
            this.TxtReportPath.Name = "TxtReportPath";
            this.TxtReportPath.Size = new System.Drawing.Size(139, 20);
            this.TxtReportPath.TabIndex = 12;
            this.TxtReportPath.Text = "FalseX Reports";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(11, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Report Server Port :";
            // 
            // GBReport
            // 
            this.GBReport.BackColor = System.Drawing.Color.Transparent;
            this.GBReport.Controls.Add(this.label11);
            this.GBReport.Controls.Add(this.TxtSSRSDomain);
            this.GBReport.Controls.Add(this.label10);
            this.GBReport.Controls.Add(this.TxtSSRSUserName);
            this.GBReport.Controls.Add(this.label6);
            this.GBReport.Controls.Add(this.label9);
            this.GBReport.Controls.Add(this.TxtReportSrvName);
            this.GBReport.Controls.Add(this.label8);
            this.GBReport.Controls.Add(this.TxtSSRSPassword);
            this.GBReport.Controls.Add(this.TxtReportSrvPort);
            this.GBReport.Controls.Add(this.TxtReportPath);
            this.GBReport.Controls.Add(this.label7);
            this.GBReport.ForeColor = System.Drawing.Color.Lime;
            this.GBReport.Location = new System.Drawing.Point(15, 315);
            this.GBReport.Name = "GBReport";
            this.GBReport.Size = new System.Drawing.Size(307, 178);
            this.GBReport.TabIndex = 68;
            this.GBReport.TabStop = false;
            this.GBReport.Text = "Reporting";
            this.GBReport.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(11, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Report Server UserName :";
            // 
            // TxtSSRSUserName
            // 
            this.TxtSSRSUserName.Location = new System.Drawing.Point(14, 110);
            this.TxtSSRSUserName.Name = "TxtSSRSUserName";
            this.TxtSSRSUserName.Size = new System.Drawing.Size(139, 20);
            this.TxtSSRSUserName.TabIndex = 14;
            this.TxtSSRSUserName.Text = "UserName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(153, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Report Server Password :";
            // 
            // TxtSSRSPassword
            // 
            this.TxtSSRSPassword.Location = new System.Drawing.Point(156, 110);
            this.TxtSSRSPassword.Name = "TxtSSRSPassword";
            this.TxtSSRSPassword.PasswordChar = '*';
            this.TxtSSRSPassword.Size = new System.Drawing.Size(139, 20);
            this.TxtSSRSPassword.TabIndex = 15;
            this.TxtSSRSPassword.Text = "Password";
            // 
            // btnstart
            // 
            this.btnstart.ForeColor = System.Drawing.Color.Black;
            this.btnstart.Location = new System.Drawing.Point(51, 510);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(176, 23);
            this.btnstart.TabIndex = 17;
            this.btnstart.Text = "Save";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Visible = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.ForeColor = System.Drawing.Color.Black;
            this.BtnEnd.Location = new System.Drawing.Point(231, 510);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(59, 23);
            this.BtnEnd.TabIndex = 18;
            this.BtnEnd.Text = "End";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Visible = false;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // TxtSSRSDomain
            // 
            this.TxtSSRSDomain.Location = new System.Drawing.Point(14, 149);
            this.TxtSSRSDomain.Name = "TxtSSRSDomain";
            this.TxtSSRSDomain.Size = new System.Drawing.Size(139, 20);
            this.TxtSSRSDomain.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(11, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Report Server Domain :";
            // 
            // SQLConnectionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FXFW.Properties.Resources.SQLConnection;
            this.ClientSize = new System.Drawing.Size(341, 545);
            this.Controls.Add(this.GBDB);
            this.Controls.Add(this.GBSecurity);
            this.Controls.Add(this.GBReport);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.BtnEnd);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SQLConnectionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " - SQL Connection - ";
            this.Load += new System.EventHandler(this.SQLConnectionFrm_Load);
            this.GBDB.ResumeLayout(false);
            this.GBDB.PerformLayout();
            this.PnlAttachDB.ResumeLayout(false);
            this.PnlAttachDB.PerformLayout();
            this.PnlSelectDB.ResumeLayout(false);
            this.PnlSelectDB.PerformLayout();
            this.GBSecurity.ResumeLayout(false);
            this.GBSecurity.PerformLayout();
            this.GBReport.ResumeLayout(false);
            this.GBReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox CBUseExpress;
        internal System.Windows.Forms.TextBox txtserver;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnConnect;
        internal System.Windows.Forms.GroupBox GBDB;
        private System.Windows.Forms.Panel PnlAttachDB;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtdatabase;
        internal System.Windows.Forms.Button BtnDB;
        internal System.Windows.Forms.RadioButton RBNotAttached;
        private System.Windows.Forms.Panel PnlSelectDB;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox CBDBName;
        internal System.Windows.Forms.RadioButton RBAttached;
        private System.Windows.Forms.GroupBox GBSecurity;
        private System.Windows.Forms.ComboBox CBSqlAuth;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtPW;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TxtID;
        internal System.Windows.Forms.TextBox TxtReportSrvName;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox TxtReportSrvPort;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GBReport;
        internal System.Windows.Forms.Button btnstart;
        internal System.Windows.Forms.Button BtnEnd;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox TxtSSRSUserName;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox TxtSSRSPassword;
        public System.Windows.Forms.TextBox TxtReportPath;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox TxtSSRSDomain;







    }
}