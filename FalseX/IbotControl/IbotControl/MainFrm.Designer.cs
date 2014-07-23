namespace IbotControl
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvAccount = new System.Windows.Forms.ListView();
            this.chCharName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label23 = new System.Windows.Forms.Label();
            this.cbAccIP = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIbotAccountPath = new System.Windows.Forms.Label();
            this.btnSelectAccountIbot = new System.Windows.Forms.Button();
            this.cbRestartUnknowSpot = new System.Windows.Forms.CheckBox();
            this.cbDCRestart = new System.Windows.Forms.CheckBox();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.tbCharName = new System.Windows.Forms.TextBox();
            this.tbPasscode = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBots = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LVBots = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripBots = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BottoolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCloseAllBots = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemShowHide = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHideAll = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.tabControlBotInfo = new System.Windows.Forms.TabControl();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLoop = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblDied = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSkillPerHour = new System.Windows.Forms.Label();
            this.lblGoldPerHour = new System.Windows.Forms.Label();
            this.lblExpPerHour = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDCCount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTryConnectCount = new System.Windows.Forms.Label();
            this.pbCharHP = new IbotControl.Misc.ProgressBarEx2();
            this.pbCharMP = new IbotControl.Misc.ProgressBarEx2();
            this.pbCharExp = new IbotControl.Misc.ProgressBarEx2();
            this.pbCharBerzerg = new IbotControl.Misc.ProgressBarEx2();
            this.pbPetHP = new IbotControl.Misc.ProgressBarEx2();
            this.pbPetHGP = new IbotControl.Misc.ProgressBarEx2();
            this.pbTransHP = new IbotControl.Misc.ProgressBarEx2();
            this.tabPageBotLog = new System.Windows.Forms.TabPage();
            this.lbBotLog = new System.Windows.Forms.ListBox();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.lblPetInvFreeSlot = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblCharInvFreeSlot = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.lbCharInventory = new System.Windows.Forms.ListBox();
            this.lbPetInventory = new System.Windows.Forms.ListBox();
            this.tabPageHachshield = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.rtbHachshield = new System.Windows.Forms.RichTextBox();
            this.gbHackshield = new System.Windows.Forms.GroupBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbShowHideClient = new System.Windows.Forms.CheckBox();
            this.tby = new System.Windows.Forms.TextBox();
            this.tbx = new System.Windows.Forms.TextBox();
            this.btnResizeClient = new System.Windows.Forms.Button();
            this.tbHackshieldPort = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbHackshieldIP = new System.Windows.Forms.ComboBox();
            this.btnStopHackshield = new System.Windows.Forms.Button();
            this.btnStartHackshield = new System.Windows.Forms.Button();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSroPath = new System.Windows.Forms.Label();
            this.btnSroPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIbotPath = new System.Windows.Forms.Label();
            this.btnIbotPath = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutputWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrUIBotInfo = new System.Windows.Forms.Timer(this.components);
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.notifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageBots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStripBots.SuspendLayout();
            this.tabControlBotInfo.SuspendLayout();
            this.tabPageStatistics.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageBotLog.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabPageHachshield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gbHackshield.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer3);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(697, 434);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(697, 458);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStripMain);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tbLog);
            this.splitContainer3.Size = new System.Drawing.Size(697, 434);
            this.splitContainer3.SplitterDistance = 301;
            this.splitContainer3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageAccount);
            this.tabControl1.Controls.Add(this.tabPageBots);
            this.tabControl1.Controls.Add(this.tabPageHachshield);
            this.tabControl1.Controls.Add(this.tabPageOptions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageListIcon;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 301);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.Black;
            this.tabPageMain.BackgroundImage = global::IbotControl.Properties.Resources.Main;
            this.tabPageMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageMain.Controls.Add(this.btnStop);
            this.tabPageMain.Controls.Add(this.btnStart);
            this.tabPageMain.ImageKey = "Main.png";
            this.tabPageMain.Location = new System.Drawing.Point(4, 23);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(689, 274);
            this.tabPageMain.TabIndex = 2;
            this.tabPageMain.Text = "Main";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Image = global::IbotControl.Properties.Resources.Stop;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStop.Location = new System.Drawing.Point(549, 226);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(132, 42);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Image = global::IbotControl.Properties.Resources.Start;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStart.Location = new System.Drawing.Point(411, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.BackColor = System.Drawing.Color.Black;
            this.tabPageAccount.BackgroundImage = global::IbotControl.Properties.Resources.Account;
            this.tabPageAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageAccount.Controls.Add(this.splitContainer1);
            this.tabPageAccount.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tabPageAccount.ImageKey = "Account.png";
            this.tabPageAccount.Location = new System.Drawing.Point(4, 23);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(689, 274);
            this.tabPageAccount.TabIndex = 0;
            this.tabPageAccount.Text = "Account";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvAccount);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label23);
            this.splitContainer1.Panel2.Controls.Add(this.cbAccIP);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.cbRestartUnknowSpot);
            this.splitContainer1.Panel2.Controls.Add(this.cbDCRestart);
            this.splitContainer1.Panel2.Controls.Add(this.cbStart);
            this.splitContainer1.Panel2.Controls.Add(this.cbServer);
            this.splitContainer1.Panel2.Controls.Add(this.tbCharName);
            this.splitContainer1.Panel2.Controls.Add(this.tbPasscode);
            this.splitContainer1.Panel2.Controls.Add(this.tbPassword);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.tbUsername);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemove);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(683, 268);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvAccount
            // 
            this.lvAccount.BackColor = System.Drawing.Color.Black;
            this.lvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCharName,
            this.chServer});
            this.lvAccount.ContextMenuStrip = this.contextMenuStripAccount;
            this.lvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAccount.ForeColor = System.Drawing.Color.White;
            this.lvAccount.FullRowSelect = true;
            this.lvAccount.HideSelection = false;
            this.lvAccount.Location = new System.Drawing.Point(0, 0);
            this.lvAccount.MultiSelect = false;
            this.lvAccount.Name = "lvAccount";
            this.lvAccount.Size = new System.Drawing.Size(200, 268);
            this.lvAccount.TabIndex = 0;
            this.lvAccount.UseCompatibleStateImageBehavior = false;
            this.lvAccount.View = System.Windows.Forms.View.Details;
            this.lvAccount.SelectedIndexChanged += new System.EventHandler(this.lvAccount_SelectedIndexChanged);
            this.lvAccount.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAccount_MouseDoubleClick);
            // 
            // chCharName
            // 
            this.chCharName.Text = "Char Name";
            this.chCharName.Width = 98;
            // 
            // chServer
            // 
            this.chServer.Text = "Server";
            this.chServer.Width = 83;
            // 
            // contextMenuStripAccount
            // 
            this.contextMenuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripAccount.Name = "contextMenuStripGrid";
            this.contextMenuStripAccount.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::IbotControl.Properties.Resources.Edit2;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 165);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 13;
            this.label23.Text = "Server IP";
            // 
            // cbAccIP
            // 
            this.cbAccIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAccIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccIP.FormattingEnabled = true;
            this.cbAccIP.Items.AddRange(new object[] {
            "121.128.133.26",
            "121.128.133.27",
            "121.128.133.28",
            "121.128.133.29",
            "121.128.133.30"});
            this.cbAccIP.Location = new System.Drawing.Point(94, 162);
            this.cbAccIP.Name = "cbAccIP";
            this.cbAccIP.Size = new System.Drawing.Size(156, 21);
            this.cbAccIP.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblIbotAccountPath);
            this.groupBox3.Controls.Add(this.btnSelectAccountIbot);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 49);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ibot Path";
            // 
            // lblIbotAccountPath
            // 
            this.lblIbotAccountPath.AutoSize = true;
            this.lblIbotAccountPath.Location = new System.Drawing.Point(44, 21);
            this.lblIbotAccountPath.Name = "lblIbotAccountPath";
            this.lblIbotAccountPath.Size = new System.Drawing.Size(0, 13);
            this.lblIbotAccountPath.TabIndex = 1;
            // 
            // btnSelectAccountIbot
            // 
            this.btnSelectAccountIbot.ForeColor = System.Drawing.Color.Black;
            this.btnSelectAccountIbot.Location = new System.Drawing.Point(3, 16);
            this.btnSelectAccountIbot.Name = "btnSelectAccountIbot";
            this.btnSelectAccountIbot.Size = new System.Drawing.Size(35, 23);
            this.btnSelectAccountIbot.TabIndex = 0;
            this.btnSelectAccountIbot.Text = "...";
            this.btnSelectAccountIbot.UseVisualStyleBackColor = true;
            this.btnSelectAccountIbot.Click += new System.EventHandler(this.btnSelectAccountIbot_Click);
            // 
            // cbRestartUnknowSpot
            // 
            this.cbRestartUnknowSpot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbRestartUnknowSpot.AutoSize = true;
            this.cbRestartUnknowSpot.Location = new System.Drawing.Point(267, 77);
            this.cbRestartUnknowSpot.Name = "cbRestartUnknowSpot";
            this.cbRestartUnknowSpot.Size = new System.Drawing.Size(140, 17);
            this.cbRestartUnknowSpot.TabIndex = 7;
            this.cbRestartUnknowSpot.Text = "Restart When bot stuck";
            this.cbRestartUnknowSpot.UseVisualStyleBackColor = true;
            // 
            // cbDCRestart
            // 
            this.cbDCRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDCRestart.AutoSize = true;
            this.cbDCRestart.Location = new System.Drawing.Point(266, 54);
            this.cbDCRestart.Name = "cbDCRestart";
            this.cbDCRestart.Size = new System.Drawing.Size(127, 17);
            this.cbDCRestart.TabIndex = 9;
            this.cbDCRestart.Text = "Restart bot when DC";
            this.cbDCRestart.UseVisualStyleBackColor = true;
            // 
            // cbStart
            // 
            this.cbStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStart.AutoSize = true;
            this.cbStart.Location = new System.Drawing.Point(266, 31);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(76, 17);
            this.cbStart.TabIndex = 7;
            this.cbStart.Text = "Auto Start";
            this.cbStart.UseVisualStyleBackColor = true;
            // 
            // cbServer
            // 
            this.cbServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(94, 31);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(156, 21);
            this.cbServer.TabIndex = 1;
            // 
            // tbCharName
            // 
            this.tbCharName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCharName.Location = new System.Drawing.Point(94, 135);
            this.tbCharName.Name = "tbCharName";
            this.tbCharName.Size = new System.Drawing.Size(156, 20);
            this.tbCharName.TabIndex = 5;
            // 
            // tbPasscode
            // 
            this.tbPasscode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPasscode.Location = new System.Drawing.Point(94, 109);
            this.tbPasscode.Name = "tbPasscode";
            this.tbPasscode.Size = new System.Drawing.Size(156, 20);
            this.tbPasscode.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPassword.Location = new System.Drawing.Point(94, 83);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(156, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Charname";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUsername.Location = new System.Drawing.Point(94, 57);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(156, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Passcode";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Image = global::IbotControl.Properties.Resources.Delete;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(303, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::IbotControl.Properties.Resources.Edit;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(348, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::IbotControl.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(267, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SilkroadServer";
            // 
            // tabPageBots
            // 
            this.tabPageBots.BackColor = System.Drawing.Color.Black;
            this.tabPageBots.BackgroundImage = global::IbotControl.Properties.Resources.Ibot;
            this.tabPageBots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageBots.Controls.Add(this.splitContainer2);
            this.tabPageBots.ImageKey = "Ibot.png";
            this.tabPageBots.Location = new System.Drawing.Point(4, 23);
            this.tabPageBots.Name = "tabPageBots";
            this.tabPageBots.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBots.Size = new System.Drawing.Size(689, 274);
            this.tabPageBots.TabIndex = 1;
            this.tabPageBots.Text = "Online bots";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.LVBots);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlBotInfo);
            this.splitContainer2.Size = new System.Drawing.Size(683, 268);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.TabIndex = 0;
            // 
            // LVBots
            // 
            this.LVBots.BackColor = System.Drawing.Color.Black;
            this.LVBots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LVBots.ContextMenuStrip = this.contextMenuStripBots;
            this.LVBots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVBots.ForeColor = System.Drawing.Color.White;
            this.LVBots.FullRowSelect = true;
            this.LVBots.HideSelection = false;
            this.LVBots.LargeImageList = this.imageListIcon;
            this.LVBots.Location = new System.Drawing.Point(0, 0);
            this.LVBots.MultiSelect = false;
            this.LVBots.Name = "LVBots";
            this.LVBots.Size = new System.Drawing.Size(211, 268);
            this.LVBots.SmallImageList = this.imageListIcon;
            this.LVBots.StateImageList = this.imageListIcon;
            this.LVBots.TabIndex = 1;
            this.LVBots.UseCompatibleStateImageBehavior = false;
            this.LVBots.View = System.Windows.Forms.View.Details;
            this.LVBots.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LVBots_ItemChecked);
            this.LVBots.SelectedIndexChanged += new System.EventHandler(this.LVBots_SelectedIndexChanged);
            this.LVBots.DoubleClick += new System.EventHandler(this.LVBots_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Char Name";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Server";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Visable";
            this.columnHeader3.Width = 45;
            // 
            // contextMenuStripBots
            // 
            this.contextMenuStripBots.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BottoolStripMenuItemClose,
            this.toolStripMenuItemCloseAllBots,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemShowHide,
            this.ToolStripMenuItemHideAll});
            this.contextMenuStripBots.Name = "contextMenuStripGrid";
            this.contextMenuStripBots.Size = new System.Drawing.Size(134, 98);
            this.contextMenuStripBots.PaddingChanged += new System.EventHandler(this.contextMenuStripBots_PaddingChanged);
            // 
            // BottoolStripMenuItemClose
            // 
            this.BottoolStripMenuItemClose.Image = global::IbotControl.Properties.Resources.Close;
            this.BottoolStripMenuItemClose.Name = "BottoolStripMenuItemClose";
            this.BottoolStripMenuItemClose.Size = new System.Drawing.Size(133, 22);
            this.BottoolStripMenuItemClose.Text = "Close";
            this.BottoolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItemCloseBot_Click);
            // 
            // toolStripMenuItemCloseAllBots
            // 
            this.toolStripMenuItemCloseAllBots.Image = global::IbotControl.Properties.Resources.CloseAll;
            this.toolStripMenuItemCloseAllBots.Name = "toolStripMenuItemCloseAllBots";
            this.toolStripMenuItemCloseAllBots.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemCloseAllBots.Text = "Close All";
            this.toolStripMenuItemCloseAllBots.Click += new System.EventHandler(this.toolStripMenuItemCloseAllBots_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // ToolStripMenuItemShowHide
            // 
            this.ToolStripMenuItemShowHide.Image = global::IbotControl.Properties.Resources.ShowHide;
            this.ToolStripMenuItemShowHide.Name = "ToolStripMenuItemShowHide";
            this.ToolStripMenuItemShowHide.Size = new System.Drawing.Size(133, 22);
            this.ToolStripMenuItemShowHide.Text = "Show/Hide";
            this.ToolStripMenuItemShowHide.Click += new System.EventHandler(this.showhideToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemHideAll
            // 
            this.ToolStripMenuItemHideAll.Image = global::IbotControl.Properties.Resources.HideAll;
            this.ToolStripMenuItemHideAll.Name = "ToolStripMenuItemHideAll";
            this.ToolStripMenuItemHideAll.Size = new System.Drawing.Size(133, 22);
            this.ToolStripMenuItemHideAll.Text = "Hide All";
            this.ToolStripMenuItemHideAll.Click += new System.EventHandler(this.hideAllToolStripMenuItem_Click);
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "RedBall.png");
            this.imageListIcon.Images.SetKeyName(1, "YellowBall.png");
            this.imageListIcon.Images.SetKeyName(2, "GreenBall.png");
            this.imageListIcon.Images.SetKeyName(3, "Account.png");
            this.imageListIcon.Images.SetKeyName(4, "HS.png");
            this.imageListIcon.Images.SetKeyName(5, "Ibot.png");
            this.imageListIcon.Images.SetKeyName(6, "Option.png");
            this.imageListIcon.Images.SetKeyName(7, "Main.png");
            // 
            // tabControlBotInfo
            // 
            this.tabControlBotInfo.Controls.Add(this.tabPageStatistics);
            this.tabControlBotInfo.Controls.Add(this.tabPageBotLog);
            this.tabControlBotInfo.Controls.Add(this.tabPageInventory);
            this.tabControlBotInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBotInfo.Location = new System.Drawing.Point(0, 0);
            this.tabControlBotInfo.Name = "tabControlBotInfo";
            this.tabControlBotInfo.SelectedIndex = 0;
            this.tabControlBotInfo.Size = new System.Drawing.Size(468, 268);
            this.tabControlBotInfo.TabIndex = 38;
            this.tabControlBotInfo.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlBotInfo_Selected);
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.BackColor = System.Drawing.Color.Black;
            this.tabPageStatistics.Controls.Add(this.tableLayoutPanel1);
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistics.Size = new System.Drawing.Size(460, 242);
            this.tabPageStatistics.TabIndex = 0;
            this.tabPageStatistics.Text = "Statistics";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLoop, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblLvl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDied, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCharName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblItems, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblExp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGold, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSkill, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSkillPerHour, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGoldPerHour, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblExpPerHour, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblDCCount, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblTryConnectCount, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.pbCharHP, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbCharMP, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbCharExp, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbCharBerzerg, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbPetHP, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.pbPetHGP, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.pbTransHP, 3, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 220);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Char Name";
            // 
            // lblLoop
            // 
            this.lblLoop.AutoSize = true;
            this.lblLoop.Location = new System.Drawing.Point(72, 140);
            this.lblLoop.Name = "lblLoop";
            this.lblLoop.Size = new System.Drawing.Size(11, 13);
            this.lblLoop.TabIndex = 24;
            this.lblLoop.Text = "-";
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(72, 80);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(11, 13);
            this.lblLvl.TabIndex = 21;
            this.lblLvl.Text = "-";
            // 
            // lblDied
            // 
            this.lblDied.AutoSize = true;
            this.lblDied.Location = new System.Drawing.Point(72, 120);
            this.lblDied.Name = "lblDied";
            this.lblDied.Size = new System.Drawing.Size(11, 13);
            this.lblDied.TabIndex = 27;
            this.lblDied.Text = "-";
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(72, 0);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(11, 13);
            this.lblCharName.TabIndex = 32;
            this.lblCharName.Text = "-";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(72, 100);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(11, 13);
            this.lblItems.TabIndex = 31;
            this.lblItems.Text = "-";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(72, 60);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(13, 13);
            this.lblExp.TabIndex = 22;
            this.lblExp.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Skill Point";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Level";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(72, 40);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(13, 13);
            this.lblGold.TabIndex = 25;
            this.lblGold.Text = "0";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(72, 20);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(13, 13);
            this.lblSkill.TabIndex = 28;
            this.lblSkill.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Gold";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Loop count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Experience";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Items pick";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Died count";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(179, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Per Hour";
            // 
            // lblSkillPerHour
            // 
            this.lblSkillPerHour.AutoSize = true;
            this.lblSkillPerHour.Location = new System.Drawing.Point(179, 20);
            this.lblSkillPerHour.Name = "lblSkillPerHour";
            this.lblSkillPerHour.Size = new System.Drawing.Size(13, 13);
            this.lblSkillPerHour.TabIndex = 40;
            this.lblSkillPerHour.Text = "0";
            // 
            // lblGoldPerHour
            // 
            this.lblGoldPerHour.AutoSize = true;
            this.lblGoldPerHour.Location = new System.Drawing.Point(179, 40);
            this.lblGoldPerHour.Name = "lblGoldPerHour";
            this.lblGoldPerHour.Size = new System.Drawing.Size(13, 13);
            this.lblGoldPerHour.TabIndex = 40;
            this.lblGoldPerHour.Text = "0";
            // 
            // lblExpPerHour
            // 
            this.lblExpPerHour.AutoSize = true;
            this.lblExpPerHour.Location = new System.Drawing.Point(179, 60);
            this.lblExpPerHour.Name = "lblExpPerHour";
            this.lblExpPerHour.Size = new System.Drawing.Size(13, 13);
            this.lblExpPerHour.TabIndex = 40;
            this.lblExpPerHour.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(72, 200);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(11, 13);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "DCs";
            // 
            // lblDCCount
            // 
            this.lblDCCount.AutoSize = true;
            this.lblDCCount.Location = new System.Drawing.Point(72, 160);
            this.lblDCCount.Name = "lblDCCount";
            this.lblDCCount.Size = new System.Drawing.Size(13, 13);
            this.lblDCCount.TabIndex = 38;
            this.lblDCCount.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Con Retries";
            // 
            // lblTryConnectCount
            // 
            this.lblTryConnectCount.AutoSize = true;
            this.lblTryConnectCount.Location = new System.Drawing.Point(72, 180);
            this.lblTryConnectCount.Name = "lblTryConnectCount";
            this.lblTryConnectCount.Size = new System.Drawing.Size(13, 13);
            this.lblTryConnectCount.TabIndex = 38;
            this.lblTryConnectCount.Text = "0";
            // 
            // pbCharHP
            // 
            this.pbCharHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbCharHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCharHP.ForeColor = System.Drawing.Color.Maroon;
            this.pbCharHP.Location = new System.Drawing.Point(252, 3);
            this.pbCharHP.Name = "pbCharHP";
            this.pbCharHP.Percentage = 0;
            this.pbCharHP.ShowText = false;
            this.pbCharHP.Size = new System.Drawing.Size(195, 14);
            this.pbCharHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbCharHP.TabIndex = 41;
            // 
            // pbCharMP
            // 
            this.pbCharMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbCharMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCharMP.ForeColor = System.Drawing.Color.Navy;
            this.pbCharMP.Location = new System.Drawing.Point(252, 23);
            this.pbCharMP.Name = "pbCharMP";
            this.pbCharMP.Percentage = 0;
            this.pbCharMP.ShowText = false;
            this.pbCharMP.Size = new System.Drawing.Size(195, 14);
            this.pbCharMP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbCharMP.TabIndex = 41;
            // 
            // pbCharExp
            // 
            this.pbCharExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbCharExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCharExp.ForeColor = System.Drawing.Color.Green;
            this.pbCharExp.Location = new System.Drawing.Point(252, 43);
            this.pbCharExp.Name = "pbCharExp";
            this.pbCharExp.Percentage = 0;
            this.pbCharExp.ShowText = false;
            this.pbCharExp.Size = new System.Drawing.Size(195, 14);
            this.pbCharExp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbCharExp.TabIndex = 41;
            // 
            // pbCharBerzerg
            // 
            this.pbCharBerzerg.BackColor = System.Drawing.Color.Purple;
            this.pbCharBerzerg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCharBerzerg.ForeColor = System.Drawing.Color.Pink;
            this.pbCharBerzerg.Location = new System.Drawing.Point(252, 63);
            this.pbCharBerzerg.Maximum = 5;
            this.pbCharBerzerg.Name = "pbCharBerzerg";
            this.pbCharBerzerg.Percentage = 0;
            this.pbCharBerzerg.ShowText = false;
            this.pbCharBerzerg.Size = new System.Drawing.Size(195, 14);
            this.pbCharBerzerg.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbCharBerzerg.TabIndex = 41;
            // 
            // pbPetHP
            // 
            this.pbPetHP.BackColor = System.Drawing.Color.White;
            this.pbPetHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPetHP.ForeColor = System.Drawing.Color.Gray;
            this.pbPetHP.Location = new System.Drawing.Point(252, 103);
            this.pbPetHP.Name = "pbPetHP";
            this.pbPetHP.Percentage = 0;
            this.pbPetHP.ShowText = false;
            this.pbPetHP.Size = new System.Drawing.Size(195, 14);
            this.pbPetHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPetHP.TabIndex = 41;
            // 
            // pbPetHGP
            // 
            this.pbPetHGP.BackColor = System.Drawing.Color.Olive;
            this.pbPetHGP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPetHGP.ForeColor = System.Drawing.Color.Yellow;
            this.pbPetHGP.Location = new System.Drawing.Point(252, 123);
            this.pbPetHGP.Name = "pbPetHGP";
            this.pbPetHGP.Percentage = 0;
            this.pbPetHGP.ShowText = false;
            this.pbPetHGP.Size = new System.Drawing.Size(195, 14);
            this.pbPetHGP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPetHGP.TabIndex = 41;
            // 
            // pbTransHP
            // 
            this.pbTransHP.BackColor = System.Drawing.Color.SaddleBrown;
            this.pbTransHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTransHP.ForeColor = System.Drawing.Color.Orange;
            this.pbTransHP.Location = new System.Drawing.Point(252, 143);
            this.pbTransHP.Name = "pbTransHP";
            this.pbTransHP.Percentage = 0;
            this.pbTransHP.ShowText = false;
            this.pbTransHP.Size = new System.Drawing.Size(195, 14);
            this.pbTransHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTransHP.TabIndex = 41;
            // 
            // tabPageBotLog
            // 
            this.tabPageBotLog.BackColor = System.Drawing.Color.Black;
            this.tabPageBotLog.Controls.Add(this.lbBotLog);
            this.tabPageBotLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageBotLog.Name = "tabPageBotLog";
            this.tabPageBotLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBotLog.Size = new System.Drawing.Size(460, 259);
            this.tabPageBotLog.TabIndex = 1;
            this.tabPageBotLog.Text = "Bot Log";
            // 
            // lbBotLog
            // 
            this.lbBotLog.BackColor = System.Drawing.Color.Black;
            this.lbBotLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBotLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBotLog.ForeColor = System.Drawing.Color.White;
            this.lbBotLog.FormattingEnabled = true;
            this.lbBotLog.Location = new System.Drawing.Point(3, 3);
            this.lbBotLog.Name = "lbBotLog";
            this.lbBotLog.Size = new System.Drawing.Size(454, 253);
            this.lbBotLog.TabIndex = 0;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.BackColor = System.Drawing.Color.Black;
            this.tabPageInventory.Controls.Add(this.lblPetInvFreeSlot);
            this.tabPageInventory.Controls.Add(this.label22);
            this.tabPageInventory.Controls.Add(this.lblCharInvFreeSlot);
            this.tabPageInventory.Controls.Add(this.label21);
            this.tabPageInventory.Controls.Add(this.splitContainer5);
            this.tabPageInventory.ForeColor = System.Drawing.Color.White;
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(460, 259);
            this.tabPageInventory.TabIndex = 2;
            this.tabPageInventory.Text = "Inventory";
            // 
            // lblPetInvFreeSlot
            // 
            this.lblPetInvFreeSlot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPetInvFreeSlot.AutoSize = true;
            this.lblPetInvFreeSlot.Location = new System.Drawing.Point(308, 10);
            this.lblPetInvFreeSlot.Name = "lblPetInvFreeSlot";
            this.lblPetInvFreeSlot.Size = new System.Drawing.Size(13, 13);
            this.lblPetInvFreeSlot.TabIndex = 1;
            this.lblPetInvFreeSlot.Text = "0";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(233, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Pet Free Slot";
            // 
            // lblCharInvFreeSlot
            // 
            this.lblCharInvFreeSlot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCharInvFreeSlot.AutoSize = true;
            this.lblCharInvFreeSlot.Location = new System.Drawing.Point(88, 10);
            this.lblCharInvFreeSlot.Name = "lblCharInvFreeSlot";
            this.lblCharInvFreeSlot.Size = new System.Drawing.Size(13, 13);
            this.lblCharInvFreeSlot.TabIndex = 1;
            this.lblCharInvFreeSlot.Text = "0";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Char Free Slot";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer5.Location = new System.Drawing.Point(6, 26);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.lbCharInventory);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.lbPetInventory);
            this.splitContainer5.Size = new System.Drawing.Size(448, 227);
            this.splitContainer5.SplitterDistance = 226;
            this.splitContainer5.TabIndex = 0;
            // 
            // lbCharInventory
            // 
            this.lbCharInventory.BackColor = System.Drawing.Color.Black;
            this.lbCharInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCharInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCharInventory.ForeColor = System.Drawing.Color.White;
            this.lbCharInventory.FormattingEnabled = true;
            this.lbCharInventory.Location = new System.Drawing.Point(0, 0);
            this.lbCharInventory.Name = "lbCharInventory";
            this.lbCharInventory.Size = new System.Drawing.Size(226, 227);
            this.lbCharInventory.TabIndex = 1;
            // 
            // lbPetInventory
            // 
            this.lbPetInventory.BackColor = System.Drawing.Color.Black;
            this.lbPetInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPetInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPetInventory.ForeColor = System.Drawing.Color.White;
            this.lbPetInventory.FormattingEnabled = true;
            this.lbPetInventory.Location = new System.Drawing.Point(0, 0);
            this.lbPetInventory.Name = "lbPetInventory";
            this.lbPetInventory.Size = new System.Drawing.Size(218, 227);
            this.lbPetInventory.TabIndex = 1;
            // 
            // tabPageHachshield
            // 
            this.tabPageHachshield.BackColor = System.Drawing.Color.Black;
            this.tabPageHachshield.BackgroundImage = global::IbotControl.Properties.Resources.HS;
            this.tabPageHachshield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageHachshield.Controls.Add(this.splitContainer4);
            this.tabPageHachshield.ImageKey = "HS.png";
            this.tabPageHachshield.Location = new System.Drawing.Point(4, 23);
            this.tabPageHachshield.Name = "tabPageHachshield";
            this.tabPageHachshield.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHachshield.Size = new System.Drawing.Size(689, 274);
            this.tabPageHachshield.TabIndex = 3;
            this.tabPageHachshield.Text = "Hackshield";
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.rtbHachshield);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.gbHackshield);
            this.splitContainer4.Size = new System.Drawing.Size(683, 268);
            this.splitContainer4.SplitterDistance = 491;
            this.splitContainer4.TabIndex = 1;
            // 
            // rtbHachshield
            // 
            this.rtbHachshield.BackColor = System.Drawing.Color.Black;
            this.rtbHachshield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbHachshield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHachshield.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbHachshield.Location = new System.Drawing.Point(0, 0);
            this.rtbHachshield.Name = "rtbHachshield";
            this.rtbHachshield.Size = new System.Drawing.Size(489, 266);
            this.rtbHachshield.TabIndex = 0;
            this.rtbHachshield.Text = "";
            // 
            // gbHackshield
            // 
            this.gbHackshield.Controls.Add(this.gbClient);
            this.gbHackshield.Controls.Add(this.tbHackshieldPort);
            this.gbHackshield.Controls.Add(this.label19);
            this.gbHackshield.Controls.Add(this.label18);
            this.gbHackshield.Controls.Add(this.cbHackshieldIP);
            this.gbHackshield.Controls.Add(this.btnStopHackshield);
            this.gbHackshield.Controls.Add(this.btnStartHackshield);
            this.gbHackshield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHackshield.ForeColor = System.Drawing.Color.White;
            this.gbHackshield.Location = new System.Drawing.Point(0, 0);
            this.gbHackshield.Name = "gbHackshield";
            this.gbHackshield.Size = new System.Drawing.Size(186, 266);
            this.gbHackshield.TabIndex = 3;
            this.gbHackshield.TabStop = false;
            this.gbHackshield.Text = "Start Hackshield";
            // 
            // gbClient
            // 
            this.gbClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbClient.Controls.Add(this.label20);
            this.gbClient.Controls.Add(this.cbShowHideClient);
            this.gbClient.Controls.Add(this.tby);
            this.gbClient.Controls.Add(this.tbx);
            this.gbClient.Controls.Add(this.btnResizeClient);
            this.gbClient.Enabled = false;
            this.gbClient.ForeColor = System.Drawing.Color.White;
            this.gbClient.Location = new System.Drawing.Point(9, 98);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(163, 74);
            this.gbClient.TabIndex = 4;
            this.gbClient.TabStop = false;
            this.gbClient.Text = " Client ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "*";
            // 
            // cbShowHideClient
            // 
            this.cbShowHideClient.Image = global::IbotControl.Properties.Resources.Silkroad;
            this.cbShowHideClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbShowHideClient.Location = new System.Drawing.Point(6, 19);
            this.cbShowHideClient.Name = "cbShowHideClient";
            this.cbShowHideClient.Size = new System.Drawing.Size(129, 25);
            this.cbShowHideClient.TabIndex = 3;
            this.cbShowHideClient.Text = "Show/Hide Client";
            this.cbShowHideClient.UseVisualStyleBackColor = true;
            this.cbShowHideClient.CheckedChanged += new System.EventHandler(this.cbShowHideClient_CheckedChanged);
            // 
            // tby
            // 
            this.tby.Location = new System.Drawing.Point(62, 44);
            this.tby.Name = "tby";
            this.tby.Size = new System.Drawing.Size(31, 20);
            this.tby.TabIndex = 1;
            this.tby.Text = "600";
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(6, 44);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(31, 20);
            this.tbx.TabIndex = 1;
            this.tbx.Text = "800";
            // 
            // btnResizeClient
            // 
            this.btnResizeClient.ForeColor = System.Drawing.Color.Black;
            this.btnResizeClient.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnResizeClient.Location = new System.Drawing.Point(99, 42);
            this.btnResizeClient.Name = "btnResizeClient";
            this.btnResizeClient.Size = new System.Drawing.Size(58, 22);
            this.btnResizeClient.TabIndex = 2;
            this.btnResizeClient.Text = "Resize";
            this.btnResizeClient.UseVisualStyleBackColor = true;
            this.btnResizeClient.Click += new System.EventHandler(this.btnResizeClient_Click);
            // 
            // tbHackshieldPort
            // 
            this.tbHackshieldPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHackshieldPort.Location = new System.Drawing.Point(9, 72);
            this.tbHackshieldPort.Name = "tbHackshieldPort";
            this.tbHackshieldPort.Size = new System.Drawing.Size(129, 20);
            this.tbHackshieldPort.TabIndex = 1;
            this.tbHackshieldPort.Text = "15777";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Port";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Server IP";
            // 
            // cbHackshieldIP
            // 
            this.cbHackshieldIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHackshieldIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHackshieldIP.FormattingEnabled = true;
            this.cbHackshieldIP.Items.AddRange(new object[] {
            "121.128.133.26",
            "121.128.133.27",
            "121.128.133.28",
            "121.128.133.29",
            "121.128.133.30"});
            this.cbHackshieldIP.Location = new System.Drawing.Point(6, 32);
            this.cbHackshieldIP.Name = "cbHackshieldIP";
            this.cbHackshieldIP.Size = new System.Drawing.Size(132, 21);
            this.cbHackshieldIP.TabIndex = 0;
            // 
            // btnStopHackshield
            // 
            this.btnStopHackshield.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStopHackshield.Enabled = false;
            this.btnStopHackshield.ForeColor = System.Drawing.Color.Black;
            this.btnStopHackshield.Image = global::IbotControl.Properties.Resources.Stop;
            this.btnStopHackshield.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStopHackshield.Location = new System.Drawing.Point(94, 178);
            this.btnStopHackshield.Name = "btnStopHackshield";
            this.btnStopHackshield.Size = new System.Drawing.Size(89, 37);
            this.btnStopHackshield.TabIndex = 2;
            this.btnStopHackshield.Text = "STOP";
            this.btnStopHackshield.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStopHackshield.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopHackshield.UseVisualStyleBackColor = true;
            this.btnStopHackshield.Click += new System.EventHandler(this.btnStopHackshield_Click);
            // 
            // btnStartHackshield
            // 
            this.btnStartHackshield.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartHackshield.ForeColor = System.Drawing.Color.Black;
            this.btnStartHackshield.Image = global::IbotControl.Properties.Resources.Start;
            this.btnStartHackshield.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStartHackshield.Location = new System.Drawing.Point(4, 178);
            this.btnStartHackshield.Name = "btnStartHackshield";
            this.btnStartHackshield.Size = new System.Drawing.Size(89, 37);
            this.btnStartHackshield.TabIndex = 2;
            this.btnStartHackshield.Text = "START";
            this.btnStartHackshield.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartHackshield.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartHackshield.UseVisualStyleBackColor = true;
            this.btnStartHackshield.Click += new System.EventHandler(this.btnStartHackshield_Click);
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.BackColor = System.Drawing.Color.Black;
            this.tabPageOptions.BackgroundImage = global::IbotControl.Properties.Resources.Option;
            this.tabPageOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageOptions.Controls.Add(this.cbStartWithWindows);
            this.tabPageOptions.Controls.Add(this.groupBox2);
            this.tabPageOptions.Controls.Add(this.groupBox1);
            this.tabPageOptions.ImageKey = "Option.png";
            this.tabPageOptions.Location = new System.Drawing.Point(4, 23);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(689, 274);
            this.tabPageOptions.TabIndex = 4;
            this.tabPageOptions.Text = "Options";
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Checked = global::IbotControl.Properties.Settings.Default.RunAtStartup;
            this.cbStartWithWindows.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::IbotControl.Properties.Settings.Default, "RunAtStartup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbStartWithWindows.Location = new System.Drawing.Point(11, 116);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(183, 17);
            this.cbStartWithWindows.TabIndex = 1;
            this.cbStartWithWindows.Text = "Start with windows [Automation]";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSroPath);
            this.groupBox2.Controls.Add(this.btnSroPath);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Silkroad Path";
            // 
            // lblSroPath
            // 
            this.lblSroPath.AutoSize = true;
            this.lblSroPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::IbotControl.Properties.Settings.Default, "SroPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSroPath.Location = new System.Drawing.Point(44, 21);
            this.lblSroPath.Name = "lblSroPath";
            this.lblSroPath.Size = new System.Drawing.Size(22, 13);
            this.lblSroPath.TabIndex = 1;
            this.lblSroPath.Text = global::IbotControl.Properties.Settings.Default.SroPath;
            // 
            // btnSroPath
            // 
            this.btnSroPath.ForeColor = System.Drawing.Color.Black;
            this.btnSroPath.Location = new System.Drawing.Point(3, 16);
            this.btnSroPath.Name = "btnSroPath";
            this.btnSroPath.Size = new System.Drawing.Size(35, 23);
            this.btnSroPath.TabIndex = 0;
            this.btnSroPath.Text = "...";
            this.btnSroPath.UseVisualStyleBackColor = true;
            this.btnSroPath.Click += new System.EventHandler(this.btnSroPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblIbotPath);
            this.groupBox1.Controls.Add(this.btnIbotPath);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ibot Path";
            // 
            // lblIbotPath
            // 
            this.lblIbotPath.AutoSize = true;
            this.lblIbotPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::IbotControl.Properties.Settings.Default, "IbotPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblIbotPath.Location = new System.Drawing.Point(44, 21);
            this.lblIbotPath.Name = "lblIbotPath";
            this.lblIbotPath.Size = new System.Drawing.Size(22, 13);
            this.lblIbotPath.TabIndex = 1;
            this.lblIbotPath.Text = global::IbotControl.Properties.Settings.Default.IbotPath;
            // 
            // btnIbotPath
            // 
            this.btnIbotPath.ForeColor = System.Drawing.Color.Black;
            this.btnIbotPath.Location = new System.Drawing.Point(3, 16);
            this.btnIbotPath.Name = "btnIbotPath";
            this.btnIbotPath.Size = new System.Drawing.Size(35, 23);
            this.btnIbotPath.TabIndex = 0;
            this.btnIbotPath.Text = "...";
            this.btnIbotPath.UseVisualStyleBackColor = true;
            this.btnIbotPath.Click += new System.EventHandler(this.btnIbotPath_Click);
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.Color.Black;
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.ForeColor = System.Drawing.Color.DarkGray;
            this.tbLog.Location = new System.Drawing.Point(0, 0);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(697, 129);
            this.tbLog.TabIndex = 0;
            this.tbLog.Text = "Salam Alekom - Welcome\n";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(697, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::IbotControl.Properties.Resources.File;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::IbotControl.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::IbotControl.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OutputWindowToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Image = global::IbotControl.Properties.Resources.Info;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // OutputWindowToolStripMenuItem
            // 
            this.OutputWindowToolStripMenuItem.Image = global::IbotControl.Properties.Resources.output;
            this.OutputWindowToolStripMenuItem.Name = "OutputWindowToolStripMenuItem";
            this.OutputWindowToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.OutputWindowToolStripMenuItem.Text = "Output Window";
            this.OutputWindowToolStripMenuItem.Click += new System.EventHandler(this.outputWindowToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::IbotControl.Properties.Resources.Info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TmrUIBotInfo
            // 
            this.TmrUIBotInfo.Enabled = true;
            this.TmrUIBotInfo.Interval = 1000;
            this.TmrUIBotInfo.Tick += new System.EventHandler(this.TmrUIBotInfo_Tick);
            // 
            // fbd
            // 
            this.fbd.Description = "Select Directory";
            // 
            // ofd
            // 
            this.ofd.FileName = "iBot.exe";
            this.ofd.Filter = "Ibot File|ibot.exe";
            // 
            // notifyIconApp
            // 
            this.notifyIconApp.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIconApp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApp.Icon")));
            this.notifyIconApp.Text = "bot control";
            this.notifyIconApp.Visible = true;
            this.notifyIconApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconApp_MouseDoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(697, 458);
            this.Controls.Add(this.toolStripContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainFrm";
            this.Text = "Ibot Control";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.SizeChanged += new System.EventHandler(this.MainFrm_SizeChanged);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageAccount.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripAccount.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageBots.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStripBots.ResumeLayout(false);
            this.tabControlBotInfo.ResumeLayout(false);
            this.tabPageStatistics.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageBotLog.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageInventory.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabPageHachshield.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.gbHackshield.ResumeLayout(false);
            this.gbHackshield.PerformLayout();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.TabPage tabPageBots;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPasscode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbCharName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.ListView lvAccount;
        private System.Windows.Forms.ColumnHeader chCharName;
        private System.Windows.Forms.ColumnHeader chServer;
        private System.Windows.Forms.CheckBox cbDCRestart;
        private System.Windows.Forms.CheckBox cbRestartUnknowSpot;
        private System.Windows.Forms.ListView LVBots;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLoop;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblDied;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer TmrUIBotInfo;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox tbLog;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSkillPerHour;
        private System.Windows.Forms.Label lblGoldPerHour;
        private System.Windows.Forms.Label lblExpPerHour;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDCCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTryConnectCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBots;
        private System.Windows.Forms.ToolStripMenuItem BottoolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCloseAllBots;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowHide;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHideAll;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.TabPage tabPageHachshield;
        private System.Windows.Forms.RichTextBox rtbHachshield;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIbotPath;
        private System.Windows.Forms.Button btnIbotPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSroPath;
        private System.Windows.Forms.Button btnSroPath;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblIbotAccountPath;
        private System.Windows.Forms.Button btnSelectAccountIbot;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OutputWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconApp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox gbHackshield;
        private System.Windows.Forms.CheckBox cbShowHideClient;
        private System.Windows.Forms.TextBox tbHackshieldPort;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbHackshieldIP;
        private System.Windows.Forms.Button btnStopHackshield;
        private System.Windows.Forms.Button btnStartHackshield;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tby;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Button btnResizeClient;
        private System.Windows.Forms.TabControl tabControlBotInfo;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.TabPage tabPageBotLog;
        private System.Windows.Forms.ListBox lbBotLog;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListBox lbCharInventory;
        private System.Windows.Forms.ListBox lbPetInventory;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPetInvFreeSlot;
        private System.Windows.Forms.Label lblCharInvFreeSlot;
        private Misc.ProgressBarEx2 pbCharHP;
        private Misc.ProgressBarEx2 pbCharMP;
        private Misc.ProgressBarEx2 pbCharExp;
        private Misc.ProgressBarEx2 pbCharBerzerg;
        private Misc.ProgressBarEx2 pbPetHP;
        private Misc.ProgressBarEx2 pbPetHGP;
        private Misc.ProgressBarEx2 pbTransHP;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbAccIP;

    }
}