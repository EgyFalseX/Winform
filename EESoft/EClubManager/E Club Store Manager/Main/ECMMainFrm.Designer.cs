namespace E_Club_Store_Manager
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.restConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editorYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorAccountNatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorsalesUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorCompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billPayTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAsnafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBuyBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip();
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
            this.helpMenu});
            this.GeneralmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GeneralmenuStrip.MdiWindowListItem = this.windowsMenu;
            this.GeneralmenuStrip.Name = "GeneralmenuStrip";
            this.GeneralmenuStrip.Size = new System.Drawing.Size(934, 24);
            this.GeneralmenuStrip.TabIndex = 0;
            this.GeneralmenuStrip.Text = "GeneralmenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.restConnectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(45, 20);
            this.fileMenu.Text = "ملـــف";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
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
            this.CodeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorYearToolStripMenuItem,
            this.editorAccountNatureToolStripMenuItem,
            this.EditorsalesUnitToolStripMenuItem,
            this.editorStoreToolStripMenuItem,
            this.banksToolStripMenuItem,
            this.editorCustomerToolStripMenuItem,
            this.editorCategoriesToolStripMenuItem,
            this.editorSuppliersToolStripMenuItem,
            this.EditorCompaniesToolStripMenuItem,
            this.billPayTypeToolStripMenuItem,
            this.editJobToolStripMenuItem,
            this.editEmpToolStripMenuItem});
            this.CodeMenu.Name = "CodeMenu";
            this.CodeMenu.Size = new System.Drawing.Size(41, 20);
            this.CodeMenu.Text = "اكواد";
            // 
            // editorYearToolStripMenuItem
            // 
            this.editorYearToolStripMenuItem.Name = "editorYearToolStripMenuItem";
            this.editorYearToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorYearToolStripMenuItem.Text = "السنوات الماليه";
            this.editorYearToolStripMenuItem.Click += new System.EventHandler(this.editorYearToolStripMenuItem_Click);
            // 
            // editorAccountNatureToolStripMenuItem
            // 
            this.editorAccountNatureToolStripMenuItem.Name = "editorAccountNatureToolStripMenuItem";
            this.editorAccountNatureToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorAccountNatureToolStripMenuItem.Text = "طبيعة الحسابات";
            this.editorAccountNatureToolStripMenuItem.Click += new System.EventHandler(this.editorAccountNatureToolStripMenuItem_Click);
            // 
            // EditorsalesUnitToolStripMenuItem
            // 
            this.EditorsalesUnitToolStripMenuItem.Name = "EditorsalesUnitToolStripMenuItem";
            this.EditorsalesUnitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditorsalesUnitToolStripMenuItem.Text = "الوحـــــــدات";
            this.EditorsalesUnitToolStripMenuItem.Click += new System.EventHandler(this.EditorsalesUnitToolStripMenuItem_Click);
            // 
            // editorStoreToolStripMenuItem
            // 
            this.editorStoreToolStripMenuItem.Name = "editorStoreToolStripMenuItem";
            this.editorStoreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorStoreToolStripMenuItem.Text = "المخـازن";
            this.editorStoreToolStripMenuItem.Click += new System.EventHandler(this.editorStoreToolStripMenuItem_Click);
            // 
            // banksToolStripMenuItem
            // 
            this.banksToolStripMenuItem.Name = "banksToolStripMenuItem";
            this.banksToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.banksToolStripMenuItem.Text = "البنـــوك";
            this.banksToolStripMenuItem.Click += new System.EventHandler(this.banksToolStripMenuItem_Click);
            // 
            // editorCustomerToolStripMenuItem
            // 
            this.editorCustomerToolStripMenuItem.Name = "editorCustomerToolStripMenuItem";
            this.editorCustomerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorCustomerToolStripMenuItem.Text = "العملاء";
            this.editorCustomerToolStripMenuItem.Click += new System.EventHandler(this.editorCustomerToolStripMenuItem_Click);
            // 
            // editorCategoriesToolStripMenuItem
            // 
            this.editorCategoriesToolStripMenuItem.Name = "editorCategoriesToolStripMenuItem";
            this.editorCategoriesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorCategoriesToolStripMenuItem.Text = "فئــات الاصناف";
            this.editorCategoriesToolStripMenuItem.Click += new System.EventHandler(this.editorCategoriesToolStripMenuItem_Click);
            // 
            // editorSuppliersToolStripMenuItem
            // 
            this.editorSuppliersToolStripMenuItem.Name = "editorSuppliersToolStripMenuItem";
            this.editorSuppliersToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorSuppliersToolStripMenuItem.Text = "الموردين";
            this.editorSuppliersToolStripMenuItem.Click += new System.EventHandler(this.editorSuppliersToolStripMenuItem_Click);
            // 
            // EditorCompaniesToolStripMenuItem
            // 
            this.EditorCompaniesToolStripMenuItem.Name = "EditorCompaniesToolStripMenuItem";
            this.EditorCompaniesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditorCompaniesToolStripMenuItem.Text = "الشركات المنتجــه";
            this.EditorCompaniesToolStripMenuItem.Click += new System.EventHandler(this.EditorCompaniesToolStripMenuItem_Click);
            // 
            // billPayTypeToolStripMenuItem
            // 
            this.billPayTypeToolStripMenuItem.Name = "billPayTypeToolStripMenuItem";
            this.billPayTypeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.billPayTypeToolStripMenuItem.Text = "طرق الدفع";
            this.billPayTypeToolStripMenuItem.Click += new System.EventHandler(this.billPayTypeToolStripMenuItem_Click);
            // 
            // editJobToolStripMenuItem
            // 
            this.editJobToolStripMenuItem.Name = "editJobToolStripMenuItem";
            this.editJobToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editJobToolStripMenuItem.Text = "الوظائف";
            this.editJobToolStripMenuItem.Click += new System.EventHandler(this.editJobToolStripMenuItem_Click);
            // 
            // editEmpToolStripMenuItem
            // 
            this.editEmpToolStripMenuItem.Name = "editEmpToolStripMenuItem";
            this.editEmpToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editEmpToolStripMenuItem.Text = "موظفين";
            this.editEmpToolStripMenuItem.Click += new System.EventHandler(this.editEmpToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataAsnafToolStripMenuItem,
            this.dataBuyBillToolStripMenuItem,
            this.sellBillToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dataToolStripMenuItem.Text = "ادخال بيانات";
            // 
            // dataAsnafToolStripMenuItem
            // 
            this.dataAsnafToolStripMenuItem.Name = "dataAsnafToolStripMenuItem";
            this.dataAsnafToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dataAsnafToolStripMenuItem.Text = "بيانات الاصناف";
            this.dataAsnafToolStripMenuItem.Click += new System.EventHandler(this.dataAsnafToolStripMenuItem_Click);
            // 
            // dataBuyBillToolStripMenuItem
            // 
            this.dataBuyBillToolStripMenuItem.Name = "dataBuyBillToolStripMenuItem";
            this.dataBuyBillToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dataBuyBillToolStripMenuItem.Text = "فاتورة مشتريات";
            this.dataBuyBillToolStripMenuItem.Click += new System.EventHandler(this.dataBuyBillToolStripMenuItem_Click);
            // 
            // sellBillToolStripMenuItem
            // 
            this.sellBillToolStripMenuItem.Name = "sellBillToolStripMenuItem";
            this.sellBillToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sellBillToolStripMenuItem.Text = "فاتورة مبيعات";
            this.sellBillToolStripMenuItem.Click += new System.EventHandler(this.sellBillToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.queryToolStripMenuItem.Text = "استعلامــات";
            // 
            // printingToolStripMenuItem
            // 
            this.printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            this.printingToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.printingToolStripMenuItem.Text = "طبــاعة تقاريــر";
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.permissionToolStripMenuItem.Text = "صلاحيــــات";
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
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
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
            // ECMMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::E_Club_Store_Manager.Properties.Resources.ECRM_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 612);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.GeneralmenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GeneralmenuStrip;
            this.Name = "ECMMainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المخازن";
            this.Activated += new System.EventHandler(this.ECMMainFrm_Activated);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
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
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorAccountNatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditorsalesUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditorCompaniesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billPayTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAsnafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBuyBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellBillToolStripMenuItem;
    }
}



