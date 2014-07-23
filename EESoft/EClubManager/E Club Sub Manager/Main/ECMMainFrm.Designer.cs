namespace E_Club_Sub_Manager
{
    partial class ECMMainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECMMainFrm));
            this.GeneralmenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qryMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorUserInRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorRoleContiansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip();
            this.repPaymentdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repPaymentpriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repPaymentmemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repPaymentpriodsumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repPaymentlateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralmenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralmenuStrip
            // 
            this.GeneralmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.CodeMenu,
            this.dataToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.printingToolStripMenuItem,
            this.permissionToolStripMenuItem,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu,
            this.toolStripMenuItem1});
            this.GeneralmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GeneralmenuStrip.MdiWindowListItem = this.windowsMenu;
            this.GeneralmenuStrip.Name = "GeneralmenuStrip";
            this.GeneralmenuStrip.Size = new System.Drawing.Size(934, 24);
            this.GeneralmenuStrip.TabIndex = 0;
            this.GeneralmenuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restConnectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(45, 20);
            this.fileMenu.Text = "ملـــف";
            // 
            // restConnectionToolStripMenuItem
            // 
            this.restConnectionToolStripMenuItem.Name = "restConnectionToolStripMenuItem";
            this.restConnectionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.restConnectionToolStripMenuItem.Text = "ألغاء اتصال قاعدة البيانات";
            this.restConnectionToolStripMenuItem.Click += new System.EventHandler(this.restConnectionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // CodeMenu
            // 
            this.CodeMenu.Name = "CodeMenu";
            this.CodeMenu.Size = new System.Drawing.Size(41, 20);
            this.CodeMenu.Text = "اكواد";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorMembershipToolStripMenuItem,
            this.cardsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dataToolStripMenuItem.Text = "ادخال بيانات";
            // 
            // editorMembershipToolStripMenuItem
            // 
            this.editorMembershipToolStripMenuItem.Name = "editorMembershipToolStripMenuItem";
            this.editorMembershipToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editorMembershipToolStripMenuItem.Text = "تسجيل الاشتراكات";
            this.editorMembershipToolStripMenuItem.Click += new System.EventHandler(this.editorMembershipToolStripMenuItem_Click);
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.Name = "cardsToolStripMenuItem";
            this.cardsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cardsToolStripMenuItem.Text = "الكرنيهات";
            this.cardsToolStripMenuItem.Click += new System.EventHandler(this.cardsToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qryMembershipToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.queryToolStripMenuItem.Text = "استعلامــات";
            // 
            // qryMembershipToolStripMenuItem
            // 
            this.qryMembershipToolStripMenuItem.Name = "qryMembershipToolStripMenuItem";
            this.qryMembershipToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.qryMembershipToolStripMenuItem.Text = "الاشتراكات";
            this.qryMembershipToolStripMenuItem.Click += new System.EventHandler(this.qryMembershipToolStripMenuItem_Click);
            // 
            // printingToolStripMenuItem
            // 
            this.printingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repPaymentdayToolStripMenuItem,
            this.repPaymentpriodToolStripMenuItem,
            this.repPaymentmemberToolStripMenuItem,
            this.repPaymentpriodsumToolStripMenuItem,
            this.repPaymentlateToolStripMenuItem});
            this.printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            this.printingToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.printingToolStripMenuItem.Text = "طبــاعة تقاريــر";
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorUserToolStripMenuItem,
            this.editorRoleToolStripMenuItem,
            this.editorUserInRoleToolStripMenuItem,
            this.editorRoleContiansToolStripMenuItem});
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.permissionToolStripMenuItem.Text = "صلاحيــــات";
            // 
            // editorUserToolStripMenuItem
            // 
            this.editorUserToolStripMenuItem.Name = "editorUserToolStripMenuItem";
            this.editorUserToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editorUserToolStripMenuItem.Text = "المستخدمين";
            this.editorUserToolStripMenuItem.Click += new System.EventHandler(this.editorUserToolStripMenuItem_Click);
            // 
            // editorRoleToolStripMenuItem
            // 
            this.editorRoleToolStripMenuItem.Name = "editorRoleToolStripMenuItem";
            this.editorRoleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editorRoleToolStripMenuItem.Text = "الصلاحيات";
            this.editorRoleToolStripMenuItem.Click += new System.EventHandler(this.editorRoleToolStripMenuItem_Click);
            // 
            // editorUserInRoleToolStripMenuItem
            // 
            this.editorUserInRoleToolStripMenuItem.Name = "editorUserInRoleToolStripMenuItem";
            this.editorUserInRoleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editorUserInRoleToolStripMenuItem.Text = "صلاحيات المستخدمين";
            this.editorUserInRoleToolStripMenuItem.Click += new System.EventHandler(this.editorUserInRoleToolStripMenuItem_Click);
            // 
            // editorRoleContiansToolStripMenuItem
            // 
            this.editorRoleContiansToolStripMenuItem.Name = "editorRoleContiansToolStripMenuItem";
            this.editorRoleContiansToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editorRoleContiansToolStripMenuItem.Text = "قدرات الصلاحيات";
            this.editorRoleContiansToolStripMenuItem.Click += new System.EventHandler(this.editorRoleContiansToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(45, 20);
            this.viewMenu.Text = "عرض";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.statusBarToolStripMenuItem.Text = "شريط الحاله";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(43, 20);
            this.toolsMenu.Text = "ادوات";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.optionsToolStripMenuItem.Text = "اختيارات";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(40, 20);
            this.windowsMenu.Text = "نوافذ";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cascadeToolStripMenuItem.Text = "ترتيب النوافذ";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tileVerticalToolStripMenuItem.Text = "العناوين رأسي";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tileHorizontalToolStripMenuItem.Text = "العناوين افقي";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.closeAllToolStripMenuItem.Text = "اغلاق الكل";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.arrangeIconsToolStripMenuItem.Text = "ترتيب الايكون";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(54, 20);
            this.helpMenu.Text = "مساعده";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.contentsToolStripMenuItem.Text = "المحتويات";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.indexToolStripMenuItem.Text = "فهرس";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.searchToolStripMenuItem.Text = "بحث";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(160, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "عن البرنامج";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 590);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(934, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // repPaymentdayToolStripMenuItem
            // 
            this.repPaymentdayToolStripMenuItem.Name = "repPaymentdayToolStripMenuItem";
            this.repPaymentdayToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.repPaymentdayToolStripMenuItem.Text = "بيان المتحصلات عن يوم";
            this.repPaymentdayToolStripMenuItem.Click += new System.EventHandler(this.repPaymentdayToolStripMenuItem_Click);
            // 
            // repPaymentpriodToolStripMenuItem
            // 
            this.repPaymentpriodToolStripMenuItem.Name = "repPaymentpriodToolStripMenuItem";
            this.repPaymentpriodToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.repPaymentpriodToolStripMenuItem.Text = "بيان المتحصلات عن فتره";
            this.repPaymentpriodToolStripMenuItem.Click += new System.EventHandler(this.repPaymentpriodToolStripMenuItem_Click);
            // 
            // repPaymentmemberToolStripMenuItem
            // 
            this.repPaymentmemberToolStripMenuItem.Name = "repPaymentmemberToolStripMenuItem";
            this.repPaymentmemberToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.repPaymentmemberToolStripMenuItem.Text = "بيان المتحصلات عضو";
            this.repPaymentmemberToolStripMenuItem.Click += new System.EventHandler(this.repPaymentmemberToolStripMenuItem_Click);
            // 
            // repPaymentpriodsumToolStripMenuItem
            // 
            this.repPaymentpriodsumToolStripMenuItem.Name = "repPaymentpriodsumToolStripMenuItem";
            this.repPaymentpriodsumToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.repPaymentpriodsumToolStripMenuItem.Text = "اجمالي المتحصلات عن فتره";
            this.repPaymentpriodsumToolStripMenuItem.Click += new System.EventHandler(this.repPaymentpriodsumToolStripMenuItem_Click);
            // 
            // repPaymentlateToolStripMenuItem
            // 
            this.repPaymentlateToolStripMenuItem.Name = "repPaymentlateToolStripMenuItem";
            this.repPaymentlateToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.repPaymentlateToolStripMenuItem.Text = "متأخرات السداد";
            this.repPaymentlateToolStripMenuItem.Click += new System.EventHandler(this.repPaymentlateToolStripMenuItem_Click);
            // 
            // ECMMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::E_Club_Sub_Manager.Properties.Resources.ECSM_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 612);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.GeneralmenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GeneralmenuStrip;
            this.Name = "ECMMainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاداره الماليه للاشتراكات";
            this.Load += new System.EventHandler(this.ECMMainFrm_Load);
            this.GeneralmenuStrip.ResumeLayout(false);
            this.GeneralmenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        public System.Windows.Forms.MenuStrip GeneralmenuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CodeMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorUserInRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorRoleContiansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qryMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repPaymentdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repPaymentpriodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repPaymentmemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repPaymentpriodsumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repPaymentlateToolStripMenuItem;
    }
}



