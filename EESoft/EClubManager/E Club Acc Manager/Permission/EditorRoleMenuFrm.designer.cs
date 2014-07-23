namespace E_Club_Acc_Manager
{
    partial class EditorRoleMenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorRoleMenuFrm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prmEditorRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prmEditorRoleMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PremEditorUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premEditorUserInRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constraintsDailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LUEItems);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(248, 59);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "جميع السماحيات";
            // 
            // LUEItems
            // 
            this.LUEItems.Location = new System.Drawing.Point(12, 28);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "Role Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleDesc", "Description")});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Size = new System.Drawing.Size(147, 19);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(165, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختر سماحيه";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.CodeMenu,
            this.dataToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.printingToolStripMenuItem,
            this.permissionToolStripMenuItem,
            this.toolsMenu,
            this.helpMenu,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 59);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(98, 215);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "GeneralmenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restConnectionToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(85, 19);
            this.fileMenu.Text = "ملـــف";
            // 
            // restConnectionToolStripMenuItem
            // 
            this.restConnectionToolStripMenuItem.CheckOnClick = true;
            this.restConnectionToolStripMenuItem.Name = "restConnectionToolStripMenuItem";
            this.restConnectionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.restConnectionToolStripMenuItem.Text = "ألغاء اتصال قاعدة البيانات";
            this.restConnectionToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
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
            this.CodeMenu.Size = new System.Drawing.Size(85, 19);
            this.CodeMenu.Text = "اكواد";
            // 
            // editorYearToolStripMenuItem
            // 
            this.editorYearToolStripMenuItem.CheckOnClick = true;
            this.editorYearToolStripMenuItem.Name = "editorYearToolStripMenuItem";
            this.editorYearToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorYearToolStripMenuItem.Text = "السنوات الماليه";
            this.editorYearToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editorAccountNatureToolStripMenuItem
            // 
            this.editorAccountNatureToolStripMenuItem.CheckOnClick = true;
            this.editorAccountNatureToolStripMenuItem.Name = "editorAccountNatureToolStripMenuItem";
            this.editorAccountNatureToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorAccountNatureToolStripMenuItem.Text = "طبيعة الحسابات";
            this.editorAccountNatureToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // EditorsalesUnitToolStripMenuItem
            // 
            this.EditorsalesUnitToolStripMenuItem.CheckOnClick = true;
            this.EditorsalesUnitToolStripMenuItem.Name = "EditorsalesUnitToolStripMenuItem";
            this.EditorsalesUnitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditorsalesUnitToolStripMenuItem.Text = "الوحـــــــدات";
            this.EditorsalesUnitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editorStoreToolStripMenuItem
            // 
            this.editorStoreToolStripMenuItem.CheckOnClick = true;
            this.editorStoreToolStripMenuItem.Name = "editorStoreToolStripMenuItem";
            this.editorStoreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorStoreToolStripMenuItem.Text = "المخـازن";
            this.editorStoreToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // banksToolStripMenuItem
            // 
            this.banksToolStripMenuItem.CheckOnClick = true;
            this.banksToolStripMenuItem.Name = "banksToolStripMenuItem";
            this.banksToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.banksToolStripMenuItem.Text = "البنـــوك";
            this.banksToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editorCustomerToolStripMenuItem
            // 
            this.editorCustomerToolStripMenuItem.CheckOnClick = true;
            this.editorCustomerToolStripMenuItem.Name = "editorCustomerToolStripMenuItem";
            this.editorCustomerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorCustomerToolStripMenuItem.Text = "العملاء";
            this.editorCustomerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editorCategoriesToolStripMenuItem
            // 
            this.editorCategoriesToolStripMenuItem.CheckOnClick = true;
            this.editorCategoriesToolStripMenuItem.Name = "editorCategoriesToolStripMenuItem";
            this.editorCategoriesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorCategoriesToolStripMenuItem.Text = "فئــات الاصناف";
            this.editorCategoriesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editorSuppliersToolStripMenuItem
            // 
            this.editorSuppliersToolStripMenuItem.CheckOnClick = true;
            this.editorSuppliersToolStripMenuItem.Name = "editorSuppliersToolStripMenuItem";
            this.editorSuppliersToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editorSuppliersToolStripMenuItem.Text = "الموردين";
            this.editorSuppliersToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // EditorCompaniesToolStripMenuItem
            // 
            this.EditorCompaniesToolStripMenuItem.CheckOnClick = true;
            this.EditorCompaniesToolStripMenuItem.Name = "EditorCompaniesToolStripMenuItem";
            this.EditorCompaniesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditorCompaniesToolStripMenuItem.Text = "الشركات المنتجــه";
            this.EditorCompaniesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // billPayTypeToolStripMenuItem
            // 
            this.billPayTypeToolStripMenuItem.CheckOnClick = true;
            this.billPayTypeToolStripMenuItem.Name = "billPayTypeToolStripMenuItem";
            this.billPayTypeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.billPayTypeToolStripMenuItem.Text = "طرق الدفع";
            this.billPayTypeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editJobToolStripMenuItem
            // 
            this.editJobToolStripMenuItem.CheckOnClick = true;
            this.editJobToolStripMenuItem.Name = "editJobToolStripMenuItem";
            this.editJobToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editJobToolStripMenuItem.Text = "الوظائف";
            this.editJobToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editEmpToolStripMenuItem
            // 
            this.editEmpToolStripMenuItem.CheckOnClick = true;
            this.editEmpToolStripMenuItem.Name = "editEmpToolStripMenuItem";
            this.editEmpToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editEmpToolStripMenuItem.Text = "موظفين";
            this.editEmpToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsTypesToolStripMenuItem,
            this.constraintsDailyToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.dataToolStripMenuItem.Text = "ادخال بيانات";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.queryToolStripMenuItem.Text = "استعلامــات";
            // 
            // printingToolStripMenuItem
            // 
            this.printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            this.printingToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.printingToolStripMenuItem.Text = "طبــاعة تقاريــر";
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prmEditorRoleToolStripMenuItem,
            this.prmEditorRoleMenuToolStripMenuItem,
            this.PremEditorUserToolStripMenuItem,
            this.premEditorUserInRoleToolStripMenuItem});
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.permissionToolStripMenuItem.Text = "صلاحيــــات";
            // 
            // prmEditorRoleToolStripMenuItem
            // 
            this.prmEditorRoleToolStripMenuItem.CheckOnClick = true;
            this.prmEditorRoleToolStripMenuItem.Name = "prmEditorRoleToolStripMenuItem";
            this.prmEditorRoleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.prmEditorRoleToolStripMenuItem.Text = "السماحيات";
            this.prmEditorRoleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // prmEditorRoleMenuToolStripMenuItem
            // 
            this.prmEditorRoleMenuToolStripMenuItem.CheckOnClick = true;
            this.prmEditorRoleMenuToolStripMenuItem.Name = "prmEditorRoleMenuToolStripMenuItem";
            this.prmEditorRoleMenuToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.prmEditorRoleMenuToolStripMenuItem.Text = "محتويات المستخدمين";
            this.prmEditorRoleMenuToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // PremEditorUserToolStripMenuItem
            // 
            this.PremEditorUserToolStripMenuItem.CheckOnClick = true;
            this.PremEditorUserToolStripMenuItem.Name = "PremEditorUserToolStripMenuItem";
            this.PremEditorUserToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.PremEditorUserToolStripMenuItem.Text = "المستخدمين";
            this.PremEditorUserToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // premEditorUserInRoleToolStripMenuItem
            // 
            this.premEditorUserInRoleToolStripMenuItem.CheckOnClick = true;
            this.premEditorUserInRoleToolStripMenuItem.Name = "premEditorUserInRoleToolStripMenuItem";
            this.premEditorUserInRoleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.premEditorUserInRoleToolStripMenuItem.Text = "سماحيات المستخدمين";
            this.premEditorUserInRoleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(85, 19);
            this.toolsMenu.Text = "ادوات";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "اختيارات";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(85, 19);
            this.helpMenu.Text = "مساعده";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.CheckOnClick = true;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.contentsToolStripMenuItem.Text = "المحتويات";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.CheckOnClick = true;
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.indexToolStripMenuItem.Text = "فهرس";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.CheckOnClick = true;
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.searchToolStripMenuItem.Text = "بحث";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.CheckOnClick = true;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "عن البرنامج";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 4);
            // 
            // accountsTypesToolStripMenuItem
            // 
            this.accountsTypesToolStripMenuItem.CheckOnClick = true;
            this.accountsTypesToolStripMenuItem.Name = "accountsTypesToolStripMenuItem";
            this.accountsTypesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountsTypesToolStripMenuItem.Text = "دليل الحسابات";
            this.accountsTypesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // constraintsDailyToolStripMenuItem
            // 
            this.constraintsDailyToolStripMenuItem.CheckOnClick = true;
            this.constraintsDailyToolStripMenuItem.Name = "constraintsDailyToolStripMenuItem";
            this.constraintsDailyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.constraintsDailyToolStripMenuItem.Text = "القيود اليوميــه";
            this.constraintsDailyToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // EditorRoleMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 274);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorRoleMenuFrm";
            this.Text = "محتويات السماحيات";
            this.Load += new System.EventHandler(this.EditorRoleMenuFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem restConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CodeMenu;
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
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prmEditorRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prmEditorRoleMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PremEditorUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premEditorUserInRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constraintsDailyToolStripMenuItem;
    }
}