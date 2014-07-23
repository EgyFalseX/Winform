namespace SqlInstaller
{
    partial class FrmConfigFileCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtINSTANCEID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtACTION = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFEATURES = new System.Windows.Forms.TextBox();
            this.CBHELP = new System.Windows.Forms.CheckBox();
            this.CBINDICATEPROGRESS = new System.Windows.Forms.CheckBox();
            this.CBQUIET = new System.Windows.Forms.CheckBox();
            this.CBQUIETSIMPLE = new System.Windows.Forms.CheckBox();
            this.CBX86 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMEDIASOURCE = new System.Windows.Forms.TextBox();
            this.BtnMEDIASOURCE = new System.Windows.Forms.Button();
            this.CBERRORREPORTING = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtINSTANCEDIR = new System.Windows.Forms.TextBox();
            this.BtnINSTALLSHAREDDIR = new System.Windows.Forms.Button();
            this.CBSQMREPORTING = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtINSTANCENAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAGTSVCACCOUNT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBAGTSVCSTARTUPTYPE = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBISSVCSTARTUPTYPE = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtISSVCACCOUNT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CBASSVCSTARTUPTYPE = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtASCOLLATION = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtASDATADIR = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtASLOGDIR = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtASBACKUPDIR = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtASTEMPDIR = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtASCONFIGDIR = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtASPROVIDERMSOLAP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CBSQLSVCSTARTUPTYPE = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtFILESTREAMLEVEL = new System.Windows.Forms.TextBox();
            this.CBENABLERANU = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtSQLCOLLATION = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtSQLSVCACCOUNT = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TxtSQLSYSADMINACCOUNTS = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtSECURITYMODE = new System.Windows.Forms.TextBox();
            this.CBADDCURRENTUSERASSQLADMIN = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TxtTCPENABLED = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.TxtNPENABLED = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.CBBROWSERSVCSTARTUPTYPE = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.TxtRSSVCACCOUNT = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.CBRSSVCSTARTUPTYPE = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.TxtRSINSTALLMODE = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.RTBLog = new System.Windows.Forms.RichTextBox();
            this.BtnInstall = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify the Instance ID";
            // 
            // TxtINSTANCEID
            // 
            this.TxtINSTANCEID.Location = new System.Drawing.Point(168, 20);
            this.TxtINSTANCEID.Name = "TxtINSTANCEID";
            this.TxtINSTANCEID.ReadOnly = true;
            this.TxtINSTANCEID.Size = new System.Drawing.Size(316, 20);
            this.TxtINSTANCEID.TabIndex = 1;
            this.TxtINSTANCEID.Text = "SQLEXPRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Specifies a Setup work flow";
            // 
            // TxtACTION
            // 
            this.TxtACTION.Location = new System.Drawing.Point(168, 46);
            this.TxtACTION.Name = "TxtACTION";
            this.TxtACTION.ReadOnly = true;
            this.TxtACTION.Size = new System.Drawing.Size(316, 20);
            this.TxtACTION.TabIndex = 1;
            this.TxtACTION.Text = "Install";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Specifies features to install";
            // 
            // TxtFEATURES
            // 
            this.TxtFEATURES.Location = new System.Drawing.Point(168, 72);
            this.TxtFEATURES.Name = "TxtFEATURES";
            this.TxtFEATURES.ReadOnly = true;
            this.TxtFEATURES.Size = new System.Drawing.Size(316, 20);
            this.TxtFEATURES.TabIndex = 1;
            this.TxtFEATURES.Text = "SQLENGINE,REPLICATION,FULLTEXT,RS,BIDS,SSMS";
            // 
            // CBHELP
            // 
            this.CBHELP.AutoSize = true;
            this.CBHELP.Checked = true;
            this.CBHELP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBHELP.Location = new System.Drawing.Point(23, 101);
            this.CBHELP.Name = "CBHELP";
            this.CBHELP.Size = new System.Drawing.Size(241, 17);
            this.CBHELP.TabIndex = 2;
            this.CBHELP.Text = "Displays the command line parameters usage";
            this.CBHELP.UseVisualStyleBackColor = true;
            // 
            // CBINDICATEPROGRESS
            // 
            this.CBINDICATEPROGRESS.AutoSize = true;
            this.CBINDICATEPROGRESS.Location = new System.Drawing.Point(23, 124);
            this.CBINDICATEPROGRESS.Name = "CBINDICATEPROGRESS";
            this.CBINDICATEPROGRESS.Size = new System.Drawing.Size(348, 17);
            this.CBINDICATEPROGRESS.TabIndex = 2;
            this.CBINDICATEPROGRESS.Text = "Specifies that the detailed Setup log should be piped to the console";
            this.CBINDICATEPROGRESS.UseVisualStyleBackColor = true;
            // 
            // CBQUIET
            // 
            this.CBQUIET.AutoSize = true;
            this.CBQUIET.Checked = true;
            this.CBQUIET.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBQUIET.Location = new System.Drawing.Point(23, 147);
            this.CBQUIET.Name = "CBQUIET";
            this.CBQUIET.Size = new System.Drawing.Size(224, 17);
            this.CBQUIET.TabIndex = 2;
            this.CBQUIET.Text = "Setup will not display any user interface. ";
            this.CBQUIET.UseVisualStyleBackColor = true;
            // 
            // CBQUIETSIMPLE
            // 
            this.CBQUIETSIMPLE.AutoSize = true;
            this.CBQUIETSIMPLE.Checked = true;
            this.CBQUIETSIMPLE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBQUIETSIMPLE.Location = new System.Drawing.Point(23, 170);
            this.CBQUIETSIMPLE.Name = "CBQUIETSIMPLE";
            this.CBQUIETSIMPLE.Size = new System.Drawing.Size(313, 17);
            this.CBQUIETSIMPLE.TabIndex = 2;
            this.CBQUIETSIMPLE.Text = "Setup will display progress only without any user interaction";
            this.CBQUIETSIMPLE.UseVisualStyleBackColor = true;
            // 
            // CBX86
            // 
            this.CBX86.AutoSize = true;
            this.CBX86.Location = new System.Drawing.Point(23, 193);
            this.CBX86.Name = "CBX86";
            this.CBX86.Size = new System.Drawing.Size(250, 17);
            this.CBX86.TabIndex = 2;
            this.CBX86.Text = "Specifies that Setup should install into WOW64";
            this.CBX86.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Specifies the path to the installation";
            // 
            // TxtMEDIASOURCE
            // 
            this.TxtMEDIASOURCE.Location = new System.Drawing.Point(205, 216);
            this.TxtMEDIASOURCE.Name = "TxtMEDIASOURCE";
            this.TxtMEDIASOURCE.ReadOnly = true;
            this.TxtMEDIASOURCE.Size = new System.Drawing.Size(242, 20);
            this.TxtMEDIASOURCE.TabIndex = 1;
            this.TxtMEDIASOURCE.Text = "C:\\";
            // 
            // BtnMEDIASOURCE
            // 
            this.BtnMEDIASOURCE.Location = new System.Drawing.Point(453, 214);
            this.BtnMEDIASOURCE.Name = "BtnMEDIASOURCE";
            this.BtnMEDIASOURCE.Size = new System.Drawing.Size(42, 23);
            this.BtnMEDIASOURCE.TabIndex = 3;
            this.BtnMEDIASOURCE.Text = "...";
            this.BtnMEDIASOURCE.UseVisualStyleBackColor = true;
            this.BtnMEDIASOURCE.Click += new System.EventHandler(this.BtnMEDIASOURCE_Click);
            // 
            // CBERRORREPORTING
            // 
            this.CBERRORREPORTING.AutoSize = true;
            this.CBERRORREPORTING.Location = new System.Drawing.Point(23, 242);
            this.CBERRORREPORTING.Name = "CBERRORREPORTING";
            this.CBERRORREPORTING.Size = new System.Drawing.Size(242, 17);
            this.CBERRORREPORTING.TabIndex = 2;
            this.CBERRORREPORTING.Text = "Specify if errors can be reported to Microsoft";
            this.CBERRORREPORTING.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Specify the root installation directory";
            // 
            // TxtINSTANCEDIR
            // 
            this.TxtINSTANCEDIR.Location = new System.Drawing.Point(205, 265);
            this.TxtINSTANCEDIR.Name = "TxtINSTANCEDIR";
            this.TxtINSTANCEDIR.ReadOnly = true;
            this.TxtINSTANCEDIR.Size = new System.Drawing.Size(242, 20);
            this.TxtINSTANCEDIR.TabIndex = 1;
            this.TxtINSTANCEDIR.Text = "C:\\Program Files\\";
            // 
            // BtnINSTALLSHAREDDIR
            // 
            this.BtnINSTALLSHAREDDIR.Location = new System.Drawing.Point(453, 263);
            this.BtnINSTALLSHAREDDIR.Name = "BtnINSTALLSHAREDDIR";
            this.BtnINSTALLSHAREDDIR.Size = new System.Drawing.Size(42, 23);
            this.BtnINSTALLSHAREDDIR.TabIndex = 3;
            this.BtnINSTALLSHAREDDIR.Text = "...";
            this.BtnINSTALLSHAREDDIR.UseVisualStyleBackColor = true;
            this.BtnINSTALLSHAREDDIR.Click += new System.EventHandler(this.BtnINSTANCEDIR_Click);
            // 
            // CBSQMREPORTING
            // 
            this.CBSQMREPORTING.AutoSize = true;
            this.CBSQMREPORTING.Location = new System.Drawing.Point(22, 291);
            this.CBSQMREPORTING.Name = "CBSQMREPORTING";
            this.CBSQMREPORTING.Size = new System.Drawing.Size(422, 17);
            this.CBSQMREPORTING.TabIndex = 2;
            this.CBSQMREPORTING.Text = "Specify that SQL Server feature usage data can be collected and sent to Microsoft" +
                "";
            this.CBSQMREPORTING.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Specify a default or named instance";
            // 
            // TxtINSTANCENAME
            // 
            this.TxtINSTANCENAME.Location = new System.Drawing.Point(205, 314);
            this.TxtINSTANCENAME.Name = "TxtINSTANCENAME";
            this.TxtINSTANCENAME.ReadOnly = true;
            this.TxtINSTANCENAME.Size = new System.Drawing.Size(279, 20);
            this.TxtINSTANCENAME.TabIndex = 1;
            this.TxtINSTANCENAME.Text = "SQLEXPRESS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Agent account name ";
            // 
            // TxtAGTSVCACCOUNT
            // 
            this.TxtAGTSVCACCOUNT.Location = new System.Drawing.Point(135, 340);
            this.TxtAGTSVCACCOUNT.Name = "TxtAGTSVCACCOUNT";
            this.TxtAGTSVCACCOUNT.ReadOnly = true;
            this.TxtAGTSVCACCOUNT.Size = new System.Drawing.Size(349, 20);
            this.TxtAGTSVCACCOUNT.TabIndex = 1;
            this.TxtAGTSVCACCOUNT.Text = "NT AUTHORITY\\NETWORK SERVICE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Auto-start service after installation";
            // 
            // CBAGTSVCSTARTUPTYPE
            // 
            this.CBAGTSVCSTARTUPTYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBAGTSVCSTARTUPTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBAGTSVCSTARTUPTYPE.FormattingEnabled = true;
            this.CBAGTSVCSTARTUPTYPE.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Disabled"});
            this.CBAGTSVCSTARTUPTYPE.Location = new System.Drawing.Point(205, 366);
            this.CBAGTSVCSTARTUPTYPE.Name = "CBAGTSVCSTARTUPTYPE";
            this.CBAGTSVCSTARTUPTYPE.Size = new System.Drawing.Size(131, 21);
            this.CBAGTSVCSTARTUPTYPE.TabIndex = 4;
            this.CBAGTSVCSTARTUPTYPE.Text = "Disabled";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Startup type for Integration Services. ";
            // 
            // CBISSVCSTARTUPTYPE
            // 
            this.CBISSVCSTARTUPTYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBISSVCSTARTUPTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBISSVCSTARTUPTYPE.FormattingEnabled = true;
            this.CBISSVCSTARTUPTYPE.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Disabled"});
            this.CBISSVCSTARTUPTYPE.Location = new System.Drawing.Point(217, 393);
            this.CBISSVCSTARTUPTYPE.Name = "CBISSVCSTARTUPTYPE";
            this.CBISSVCSTARTUPTYPE.Size = new System.Drawing.Size(131, 21);
            this.CBISSVCSTARTUPTYPE.TabIndex = 4;
            this.CBISSVCSTARTUPTYPE.Text = "Automatic";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Account for Integration Services";
            // 
            // TxtISSVCACCOUNT
            // 
            this.TxtISSVCACCOUNT.Location = new System.Drawing.Point(189, 420);
            this.TxtISSVCACCOUNT.Name = "TxtISSVCACCOUNT";
            this.TxtISSVCACCOUNT.ReadOnly = true;
            this.TxtISSVCACCOUNT.Size = new System.Drawing.Size(295, 20);
            this.TxtISSVCACCOUNT.TabIndex = 1;
            this.TxtISSVCACCOUNT.Text = "NT AUTHORITY\\NetworkService";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(372, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Controls the service startup type setting after the service has been created";
            // 
            // CBASSVCSTARTUPTYPE
            // 
            this.CBASSVCSTARTUPTYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBASSVCSTARTUPTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBASSVCSTARTUPTYPE.FormattingEnabled = true;
            this.CBASSVCSTARTUPTYPE.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Disabled"});
            this.CBASSVCSTARTUPTYPE.Location = new System.Drawing.Point(397, 446);
            this.CBASSVCSTARTUPTYPE.Name = "CBASSVCSTARTUPTYPE";
            this.CBASSVCSTARTUPTYPE.Size = new System.Drawing.Size(87, 21);
            this.CBASSVCSTARTUPTYPE.TabIndex = 4;
            this.CBASSVCSTARTUPTYPE.Text = "Automatic";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "The collation to be used by Analysis Services";
            // 
            // TxtASCOLLATION
            // 
            this.TxtASCOLLATION.Location = new System.Drawing.Point(247, 473);
            this.TxtASCOLLATION.Name = "TxtASCOLLATION";
            this.TxtASCOLLATION.ReadOnly = true;
            this.TxtASCOLLATION.Size = new System.Drawing.Size(237, 20);
            this.TxtASCOLLATION.TabIndex = 1;
            this.TxtASCOLLATION.Text = "Latin1_General_CI_AS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "The location for the Analysis Services data files";
            // 
            // TxtASDATADIR
            // 
            this.TxtASDATADIR.Location = new System.Drawing.Point(257, 18);
            this.TxtASDATADIR.Name = "TxtASDATADIR";
            this.TxtASDATADIR.ReadOnly = true;
            this.TxtASDATADIR.Size = new System.Drawing.Size(225, 20);
            this.TxtASDATADIR.TabIndex = 1;
            this.TxtASDATADIR.Text = "Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "The location for the Analysis Services log files";
            // 
            // TxtASLOGDIR
            // 
            this.TxtASLOGDIR.Location = new System.Drawing.Point(257, 44);
            this.TxtASLOGDIR.Name = "TxtASLOGDIR";
            this.TxtASLOGDIR.ReadOnly = true;
            this.TxtASLOGDIR.Size = new System.Drawing.Size(225, 20);
            this.TxtASLOGDIR.TabIndex = 1;
            this.TxtASLOGDIR.Text = "Log";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(245, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "The location for the Analysis Services backup files";
            // 
            // TxtASBACKUPDIR
            // 
            this.TxtASBACKUPDIR.Location = new System.Drawing.Point(269, 70);
            this.TxtASBACKUPDIR.Name = "TxtASBACKUPDIR";
            this.TxtASBACKUPDIR.ReadOnly = true;
            this.TxtASBACKUPDIR.Size = new System.Drawing.Size(213, 20);
            this.TxtASBACKUPDIR.TabIndex = 1;
            this.TxtASBACKUPDIR.Text = "Backup";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(261, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "The location for the Analysis Services temporary files";
            // 
            // TxtASTEMPDIR
            // 
            this.TxtASTEMPDIR.Location = new System.Drawing.Point(285, 96);
            this.TxtASTEMPDIR.Name = "TxtASTEMPDIR";
            this.TxtASTEMPDIR.ReadOnly = true;
            this.TxtASTEMPDIR.Size = new System.Drawing.Size(197, 20);
            this.TxtASTEMPDIR.TabIndex = 1;
            this.TxtASTEMPDIR.Text = "Temp";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(274, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "The location for the Analysis Services configuration files";
            // 
            // TxtASCONFIGDIR
            // 
            this.TxtASCONFIGDIR.Location = new System.Drawing.Point(298, 122);
            this.TxtASCONFIGDIR.Name = "TxtASCONFIGDIR";
            this.TxtASCONFIGDIR.ReadOnly = true;
            this.TxtASCONFIGDIR.Size = new System.Drawing.Size(184, 20);
            this.TxtASCONFIGDIR.TabIndex = 1;
            this.TxtASCONFIGDIR.Text = "Config";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(361, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Specifies whether or not the MSOLAP provider is allowed to run in process";
            // 
            // TxtASPROVIDERMSOLAP
            // 
            this.TxtASPROVIDERMSOLAP.Location = new System.Drawing.Point(385, 148);
            this.TxtASPROVIDERMSOLAP.Name = "TxtASPROVIDERMSOLAP";
            this.TxtASPROVIDERMSOLAP.ReadOnly = true;
            this.TxtASPROVIDERMSOLAP.Size = new System.Drawing.Size(97, 20);
            this.TxtASPROVIDERMSOLAP.TabIndex = 1;
            this.TxtASPROVIDERMSOLAP.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(198, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Startup type for the SQL Server service";
            // 
            // CBSQLSVCSTARTUPTYPE
            // 
            this.CBSQLSVCSTARTUPTYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBSQLSVCSTARTUPTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBSQLSVCSTARTUPTYPE.FormattingEnabled = true;
            this.CBSQLSVCSTARTUPTYPE.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Disabled"});
            this.CBSQLSVCSTARTUPTYPE.Location = new System.Drawing.Point(222, 174);
            this.CBSQLSVCSTARTUPTYPE.Name = "CBSQLSVCSTARTUPTYPE";
            this.CBSQLSVCSTARTUPTYPE.Size = new System.Drawing.Size(131, 21);
            this.CBSQLSVCSTARTUPTYPE.TabIndex = 4;
            this.CBSQLSVCSTARTUPTYPE.Text = "Automatic";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(265, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Level to enable FILESTREAM feature at (0, 1, 2 or 3).";
            // 
            // TxtFILESTREAMLEVEL
            // 
            this.TxtFILESTREAMLEVEL.Location = new System.Drawing.Point(289, 201);
            this.TxtFILESTREAMLEVEL.Name = "TxtFILESTREAMLEVEL";
            this.TxtFILESTREAMLEVEL.ReadOnly = true;
            this.TxtFILESTREAMLEVEL.Size = new System.Drawing.Size(193, 20);
            this.TxtFILESTREAMLEVEL.TabIndex = 1;
            this.TxtFILESTREAMLEVEL.Text = "0";
            // 
            // CBENABLERANU
            // 
            this.CBENABLERANU.AutoSize = true;
            this.CBENABLERANU.Location = new System.Drawing.Point(20, 227);
            this.CBENABLERANU.Name = "CBENABLERANU";
            this.CBENABLERANU.Size = new System.Drawing.Size(270, 17);
            this.CBENABLERANU.TabIndex = 2;
            this.CBENABLERANU.Text = "Set to \"1\" to enable RANU for SQL Server Express.";
            this.CBENABLERANU.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 253);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(391, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Specifies a Windows collation or an SQL collation to use for the Database Engine";
            // 
            // TxtSQLCOLLATION
            // 
            this.TxtSQLCOLLATION.Location = new System.Drawing.Point(407, 250);
            this.TxtSQLCOLLATION.Name = "TxtSQLCOLLATION";
            this.TxtSQLCOLLATION.ReadOnly = true;
            this.TxtSQLCOLLATION.Size = new System.Drawing.Size(75, 20);
            this.TxtSQLCOLLATION.TabIndex = 1;
            this.TxtSQLCOLLATION.Text = "Arabic_CI_AS";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 279);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(157, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Account for SQL Server service";
            // 
            // TxtSQLSVCACCOUNT
            // 
            this.TxtSQLSVCACCOUNT.Location = new System.Drawing.Point(187, 276);
            this.TxtSQLSVCACCOUNT.Name = "TxtSQLSVCACCOUNT";
            this.TxtSQLSVCACCOUNT.ReadOnly = true;
            this.TxtSQLSVCACCOUNT.Size = new System.Drawing.Size(295, 20);
            this.TxtSQLSVCACCOUNT.TabIndex = 1;
            this.TxtSQLSVCACCOUNT.Text = "NT AUTHORITY\\SYSTEM";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 305);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(342, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Windows account(s) to provision as SQL Server system administrators";
            // 
            // TxtSQLSYSADMINACCOUNTS
            // 
            this.TxtSQLSYSADMINACCOUNTS.Location = new System.Drawing.Point(366, 302);
            this.TxtSQLSYSADMINACCOUNTS.Name = "TxtSQLSYSADMINACCOUNTS";
            this.TxtSQLSYSADMINACCOUNTS.ReadOnly = true;
            this.TxtSQLSYSADMINACCOUNTS.Size = new System.Drawing.Size(116, 20);
            this.TxtSQLSYSADMINACCOUNTS.TabIndex = 1;
            this.TxtSQLSYSADMINACCOUNTS.Text = "Builtin\\Administrators";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 331);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(396, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "The default is Windows Authentication. Use \"SQL\" for Mixed Mode Authentication";
            // 
            // TxtSECURITYMODE
            // 
            this.TxtSECURITYMODE.Location = new System.Drawing.Point(420, 328);
            this.TxtSECURITYMODE.Name = "TxtSECURITYMODE";
            this.TxtSECURITYMODE.ReadOnly = true;
            this.TxtSECURITYMODE.Size = new System.Drawing.Size(62, 20);
            this.TxtSECURITYMODE.TabIndex = 1;
            this.TxtSECURITYMODE.Text = "SQL";
            // 
            // CBADDCURRENTUSERASSQLADMIN
            // 
            this.CBADDCURRENTUSERASSQLADMIN.AutoSize = true;
            this.CBADDCURRENTUSERASSQLADMIN.Checked = true;
            this.CBADDCURRENTUSERASSQLADMIN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBADDCURRENTUSERASSQLADMIN.Location = new System.Drawing.Point(21, 354);
            this.CBADDCURRENTUSERASSQLADMIN.Name = "CBADDCURRENTUSERASSQLADMIN";
            this.CBADDCURRENTUSERASSQLADMIN.Size = new System.Drawing.Size(442, 17);
            this.CBADDCURRENTUSERASSQLADMIN.TabIndex = 2;
            this.CBADDCURRENTUSERASSQLADMIN.Text = "Provision current user as a Database Engine system administrator for SQL Server 2" +
                "008";
            this.CBADDCURRENTUSERASSQLADMIN.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 380);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(267, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Specify 0 to disable or 1 to enable the TCP/IP protocol";
            // 
            // TxtTCPENABLED
            // 
            this.TxtTCPENABLED.Location = new System.Drawing.Point(289, 377);
            this.TxtTCPENABLED.Name = "TxtTCPENABLED";
            this.TxtTCPENABLED.ReadOnly = true;
            this.TxtTCPENABLED.Size = new System.Drawing.Size(193, 20);
            this.TxtTCPENABLED.TabIndex = 1;
            this.TxtTCPENABLED.Text = "1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 406);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(295, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Specify 0 to disable or 1 to enable the Named Pipes protocol";
            // 
            // TxtNPENABLED
            // 
            this.TxtNPENABLED.Location = new System.Drawing.Point(319, 403);
            this.TxtNPENABLED.Name = "TxtNPENABLED";
            this.TxtNPENABLED.ReadOnly = true;
            this.TxtNPENABLED.Size = new System.Drawing.Size(163, 20);
            this.TxtNPENABLED.TabIndex = 1;
            this.TxtNPENABLED.Text = "1";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 432);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(165, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Startup type for Browser Service";
            // 
            // CBBROWSERSVCSTARTUPTYPE
            // 
            this.CBBROWSERSVCSTARTUPTYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBBROWSERSVCSTARTUPTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBBROWSERSVCSTARTUPTYPE.FormattingEnabled = true;
            this.CBBROWSERSVCSTARTUPTYPE.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Disabled"});
            this.CBBROWSERSVCSTARTUPTYPE.Location = new System.Drawing.Point(189, 429);
            this.CBBROWSERSVCSTARTUPTYPE.Name = "CBBROWSERSVCSTARTUPTYPE";
            this.CBBROWSERSVCSTARTUPTYPE.Size = new System.Drawing.Size(131, 21);
            this.CBBROWSERSVCSTARTUPTYPE.TabIndex = 4;
            this.CBBROWSERSVCSTARTUPTYPE.Text = "Automatic";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 459);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(313, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Specifies which account the report server NT service should use";
            // 
            // TxtRSSVCACCOUNT
            // 
            this.TxtRSSVCACCOUNT.Location = new System.Drawing.Point(337, 456);
            this.TxtRSSVCACCOUNT.Name = "TxtRSSVCACCOUNT";
            this.TxtRSSVCACCOUNT.ReadOnly = true;
            this.TxtRSSVCACCOUNT.Size = new System.Drawing.Size(145, 20);
            this.TxtRSSVCACCOUNT.TabIndex = 1;
            this.TxtRSSVCACCOUNT.Text = "NT AUTHORITY\\SYSTEM";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 485);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(310, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Specifies how the startup mode of the report server NT service";
            // 
            // CBRSSVCSTARTUPTYPE
            // 
            this.CBRSSVCSTARTUPTYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBRSSVCSTARTUPTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRSSVCSTARTUPTYPE.FormattingEnabled = true;
            this.CBRSSVCSTARTUPTYPE.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Disabled"});
            this.CBRSSVCSTARTUPTYPE.Location = new System.Drawing.Point(337, 482);
            this.CBRSSVCSTARTUPTYPE.Name = "CBRSSVCSTARTUPTYPE";
            this.CBRSSVCSTARTUPTYPE.Size = new System.Drawing.Size(145, 21);
            this.CBRSSVCSTARTUPTYPE.TabIndex = 4;
            this.CBRSSVCSTARTUPTYPE.Text = "Automatic";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 512);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(238, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Specifies which mode report server is installed in";
            // 
            // TxtRSINSTALLMODE
            // 
            this.TxtRSINSTALLMODE.Location = new System.Drawing.Point(262, 509);
            this.TxtRSINSTALLMODE.Name = "TxtRSINSTALLMODE";
            this.TxtRSINSTALLMODE.ReadOnly = true;
            this.TxtRSINSTALLMODE.Size = new System.Drawing.Size(220, 20);
            this.TxtRSINSTALLMODE.TabIndex = 1;
            this.TxtRSINSTALLMODE.Text = "DefaultNativeMode";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 564);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtINSTANCEID);
            this.tabPage1.Controls.Add(this.CBASSVCSTARTUPTYPE);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TxtINSTANCENAME);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.CBISSVCSTARTUPTYPE);
            this.tabPage1.Controls.Add(this.TxtAGTSVCACCOUNT);
            this.tabPage1.Controls.Add(this.CBAGTSVCSTARTUPTYPE);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.BtnINSTALLSHAREDDIR);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BtnMEDIASOURCE);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TxtACTION);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.CBSQMREPORTING);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CBERRORREPORTING);
            this.tabPage1.Controls.Add(this.TxtMEDIASOURCE);
            this.tabPage1.Controls.Add(this.CBX86);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.CBQUIETSIMPLE);
            this.tabPage1.Controls.Add(this.TxtISSVCACCOUNT);
            this.tabPage1.Controls.Add(this.CBQUIET);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.CBINDICATEPROGRESS);
            this.tabPage1.Controls.Add(this.TxtASCOLLATION);
            this.tabPage1.Controls.Add(this.CBHELP);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TxtFEATURES);
            this.tabPage1.Controls.Add(this.TxtINSTANCEDIR);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtASDATADIR);
            this.tabPage2.Controls.Add(this.CBRSSVCSTARTUPTYPE);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.CBBROWSERSVCSTARTUPTYPE);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.CBSQLSVCSTARTUPTYPE);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.CBENABLERANU);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.CBADDCURRENTUSERASSQLADMIN);
            this.tabPage2.Controls.Add(this.TxtSQLSVCACCOUNT);
            this.tabPage2.Controls.Add(this.TxtSQLCOLLATION);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.TxtRSINSTALLMODE);
            this.tabPage2.Controls.Add(this.TxtASPROVIDERMSOLAP);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.TxtRSSVCACCOUNT);
            this.tabPage2.Controls.Add(this.TxtFILESTREAMLEVEL);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.TxtTCPENABLED);
            this.tabPage2.Controls.Add(this.TxtASCONFIGDIR);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.TxtNPENABLED);
            this.tabPage2.Controls.Add(this.TxtASTEMPDIR);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.TxtSQLSYSADMINACCOUNTS);
            this.tabPage2.Controls.Add(this.TxtASBACKUPDIR);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.TxtSECURITYMODE);
            this.tabPage2.Controls.Add(this.TxtASLOGDIR);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.RTBLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(508, 538);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "Logging";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // RTBLog
            // 
            this.RTBLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBLog.Location = new System.Drawing.Point(3, 3);
            this.RTBLog.Name = "RTBLog";
            this.RTBLog.Size = new System.Drawing.Size(502, 532);
            this.RTBLog.TabIndex = 0;
            this.RTBLog.Text = "";
            // 
            // BtnInstall
            // 
            this.BtnInstall.Location = new System.Drawing.Point(449, 582);
            this.BtnInstall.Name = "BtnInstall";
            this.BtnInstall.Size = new System.Drawing.Size(75, 31);
            this.BtnInstall.TabIndex = 6;
            this.BtnInstall.Text = "Install";
            this.BtnInstall.UseVisualStyleBackColor = true;
            this.BtnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(16, 590);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(427, 16);
            this.PB.TabIndex = 7;
            // 
            // FrmConfigFileCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 618);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.BtnInstall);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigFileCreator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Server Express 2008 Installer";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtINSTANCEID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtACTION;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFEATURES;
        private System.Windows.Forms.CheckBox CBHELP;
        private System.Windows.Forms.CheckBox CBINDICATEPROGRESS;
        private System.Windows.Forms.CheckBox CBQUIET;
        private System.Windows.Forms.CheckBox CBQUIETSIMPLE;
        private System.Windows.Forms.CheckBox CBX86;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMEDIASOURCE;
        private System.Windows.Forms.Button BtnMEDIASOURCE;
        private System.Windows.Forms.CheckBox CBERRORREPORTING;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtINSTANCEDIR;
        private System.Windows.Forms.Button BtnINSTALLSHAREDDIR;
        private System.Windows.Forms.CheckBox CBSQMREPORTING;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtINSTANCENAME;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAGTSVCACCOUNT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBAGTSVCSTARTUPTYPE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBISSVCSTARTUPTYPE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtISSVCACCOUNT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CBASSVCSTARTUPTYPE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtASCOLLATION;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtASDATADIR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtASLOGDIR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtASBACKUPDIR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtASTEMPDIR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtASCONFIGDIR;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtASPROVIDERMSOLAP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox CBSQLSVCSTARTUPTYPE;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtFILESTREAMLEVEL;
        private System.Windows.Forms.CheckBox CBENABLERANU;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TxtSQLCOLLATION;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtSQLSVCACCOUNT;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TxtSQLSYSADMINACCOUNTS;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TxtSECURITYMODE;
        private System.Windows.Forms.CheckBox CBADDCURRENTUSERASSQLADMIN;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TxtTCPENABLED;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TxtNPENABLED;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox CBBROWSERSVCSTARTUPTYPE;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox TxtRSSVCACCOUNT;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox CBRSSVCSTARTUPTYPE;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox TxtRSINSTALLMODE;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnInstall;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.RichTextBox RTBLog;

    }
}

