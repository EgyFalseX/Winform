namespace BookStore
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
            this.importStudentFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.storeCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorsalesUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorCDCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAsnafFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTblPricelistsFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBillFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSellStuBillBarCodeFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTBLGardFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataReturnSellStuBillFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataReturnbuyBillFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMortag3BillBarCodeFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constraintsDailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrysellsFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qryQryBuysFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qryItemAvailabilityFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xRep01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prmEditorRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prmEditorRoleMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PremEditorUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premEditorUserInRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xRep02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.LUEItems.Size = new System.Drawing.Size(147, 20);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(165, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
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
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 59);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(110, 215);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "GeneralmenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restConnectionToolStripMenuItem,
            this.importStudentFrmToolStripMenuItem,
            this.clearDbToolStripMenuItem});
            this.fileMenu.Image = global::BookStore.Properties.Resources.File;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(97, 20);
            this.fileMenu.Text = "ملـــف";
            // 
            // restConnectionToolStripMenuItem
            // 
            this.restConnectionToolStripMenuItem.CheckOnClick = true;
            this.restConnectionToolStripMenuItem.Image = global::BookStore.Properties.Resources.Connection;
            this.restConnectionToolStripMenuItem.Name = "restConnectionToolStripMenuItem";
            this.restConnectionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.restConnectionToolStripMenuItem.Text = "ألغاء اتصال قاعدة البيانات";
            this.restConnectionToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // importStudentFrmToolStripMenuItem
            // 
            this.importStudentFrmToolStripMenuItem.CheckOnClick = true;
            this.importStudentFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.database_import;
            this.importStudentFrmToolStripMenuItem.Name = "importStudentFrmToolStripMenuItem";
            this.importStudentFrmToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.importStudentFrmToolStripMenuItem.Text = "استيراد طلاب";
            this.importStudentFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // clearDbToolStripMenuItem
            // 
            this.clearDbToolStripMenuItem.CheckOnClick = true;
            this.clearDbToolStripMenuItem.Image = global::BookStore.Properties.Resources.Close;
            this.clearDbToolStripMenuItem.Name = "clearDbToolStripMenuItem";
            this.clearDbToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.clearDbToolStripMenuItem.Text = "تفريغ قاعدة البيانات";
            this.clearDbToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // CodeMenu
            // 
            this.CodeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeCodesToolStripMenuItem,
            this.generalCodesToolStripMenuItem});
            this.CodeMenu.Image = global::BookStore.Properties.Resources.Code;
            this.CodeMenu.Name = "CodeMenu";
            this.CodeMenu.Size = new System.Drawing.Size(97, 20);
            this.CodeMenu.Text = "اكواد";
            // 
            // storeCodesToolStripMenuItem
            // 
            this.storeCodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorsalesUnitToolStripMenuItem,
            this.editorStoreToolStripMenuItem,
            this.editorCDCategoriesToolStripMenuItem});
            this.storeCodesToolStripMenuItem.Image = global::BookStore.Properties.Resources.editorStore;
            this.storeCodesToolStripMenuItem.Name = "storeCodesToolStripMenuItem";
            this.storeCodesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.storeCodesToolStripMenuItem.Text = "اكواد المخازن";
            // 
            // EditorsalesUnitToolStripMenuItem
            // 
            this.EditorsalesUnitToolStripMenuItem.CheckOnClick = true;
            this.EditorsalesUnitToolStripMenuItem.Image = global::BookStore.Properties.Resources.EditorsalesUnit;
            this.EditorsalesUnitToolStripMenuItem.Name = "EditorsalesUnitToolStripMenuItem";
            this.EditorsalesUnitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.EditorsalesUnitToolStripMenuItem.Text = "الوحـــــــدات";
            this.EditorsalesUnitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editorStoreToolStripMenuItem
            // 
            this.editorStoreToolStripMenuItem.CheckOnClick = true;
            this.editorStoreToolStripMenuItem.Image = global::BookStore.Properties.Resources.editorStore;
            this.editorStoreToolStripMenuItem.Name = "editorStoreToolStripMenuItem";
            this.editorStoreToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editorStoreToolStripMenuItem.Text = "المخـازن";
            this.editorStoreToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // editorCDCategoriesToolStripMenuItem
            // 
            this.editorCDCategoriesToolStripMenuItem.CheckOnClick = true;
            this.editorCDCategoriesToolStripMenuItem.Image = global::BookStore.Properties.Resources.editorCDCategories;
            this.editorCDCategoriesToolStripMenuItem.Name = "editorCDCategoriesToolStripMenuItem";
            this.editorCDCategoriesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editorCDCategoriesToolStripMenuItem.Text = "فئــات الاصناف";
            this.editorCDCategoriesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // generalCodesToolStripMenuItem
            // 
            this.generalCodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editJobToolStripMenuItem});
            this.generalCodesToolStripMenuItem.Image = global::BookStore.Properties.Resources.Code;
            this.generalCodesToolStripMenuItem.Name = "generalCodesToolStripMenuItem";
            this.generalCodesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.generalCodesToolStripMenuItem.Text = "اكواد عامه";
            // 
            // editJobToolStripMenuItem
            // 
            this.editJobToolStripMenuItem.CheckOnClick = true;
            this.editJobToolStripMenuItem.Image = global::BookStore.Properties.Resources.editJobTool;
            this.editJobToolStripMenuItem.Name = "editJobToolStripMenuItem";
            this.editJobToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editJobToolStripMenuItem.Text = "الوظائف";
            this.editJobToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataStoreToolStripMenuItem,
            this.dataAccountToolStripMenuItem,
            this.dataGeneralToolStripMenuItem});
            this.dataToolStripMenuItem.Image = global::BookStore.Properties.Resources.Data;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.dataToolStripMenuItem.Text = "ادخال بيانات";
            // 
            // dataStoreToolStripMenuItem
            // 
            this.dataStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorSuppliersToolStripMenuItem,
            this.dataAsnafFrmToolStripMenuItem,
            this.dataTblPricelistsFrmToolStripMenuItem,
            this.dataBillFrmToolStripMenuItem,
            this.studentFrmToolStripMenuItem,
            this.dataSellStuBillBarCodeFrmToolStripMenuItem,
            this.dataTBLGardFrmToolStripMenuItem,
            this.dataReturnSellStuBillFrmToolStripMenuItem,
            this.dataReturnbuyBillFrmToolStripMenuItem,
            this.dataMortag3BillBarCodeFrmToolStripMenuItem});
            this.dataStoreToolStripMenuItem.Image = global::BookStore.Properties.Resources.editorStore;
            this.dataStoreToolStripMenuItem.Name = "dataStoreToolStripMenuItem";
            this.dataStoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataStoreToolStripMenuItem.Text = "بيانات المخازن";
            // 
            // editorSuppliersToolStripMenuItem
            // 
            this.editorSuppliersToolStripMenuItem.CheckOnClick = true;
            this.editorSuppliersToolStripMenuItem.Image = global::BookStore.Properties.Resources.editorSuppliers;
            this.editorSuppliersToolStripMenuItem.Name = "editorSuppliersToolStripMenuItem";
            this.editorSuppliersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editorSuppliersToolStripMenuItem.Text = "جهات التوريد";
            this.editorSuppliersToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataAsnafFrmToolStripMenuItem
            // 
            this.dataAsnafFrmToolStripMenuItem.CheckOnClick = true;
            this.dataAsnafFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.dataAsnafFrm;
            this.dataAsnafFrmToolStripMenuItem.Name = "dataAsnafFrmToolStripMenuItem";
            this.dataAsnafFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dataAsnafFrmToolStripMenuItem.Text = "بيانات الكتب";
            this.dataAsnafFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataTblPricelistsFrmToolStripMenuItem
            // 
            this.dataTblPricelistsFrmToolStripMenuItem.CheckOnClick = true;
            this.dataTblPricelistsFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.dataTblPricelistsFrm;
            this.dataTblPricelistsFrmToolStripMenuItem.Name = "dataTblPricelistsFrmToolStripMenuItem";
            this.dataTblPricelistsFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dataTblPricelistsFrmToolStripMenuItem.Text = "قائمه الاسعار";
            this.dataTblPricelistsFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataBillFrmToolStripMenuItem
            // 
            this.dataBillFrmToolStripMenuItem.CheckOnClick = true;
            this.dataBillFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.dataBillFrm;
            this.dataBillFrmToolStripMenuItem.Name = "dataBillFrmToolStripMenuItem";
            this.dataBillFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dataBillFrmToolStripMenuItem.Text = "الواردات";
            this.dataBillFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // studentFrmToolStripMenuItem
            // 
            this.studentFrmToolStripMenuItem.CheckOnClick = true;
            this.studentFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.TBLstudent;
            this.studentFrmToolStripMenuItem.Name = "studentFrmToolStripMenuItem";
            this.studentFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.studentFrmToolStripMenuItem.Text = "الطلاب";
            this.studentFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataSellStuBillBarCodeFrmToolStripMenuItem
            // 
            this.dataSellStuBillBarCodeFrmToolStripMenuItem.CheckOnClick = true;
            this.dataSellStuBillBarCodeFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.DataSellStuBillBarCodeFrm;
            this.dataSellStuBillBarCodeFrmToolStripMenuItem.Name = "dataSellStuBillBarCodeFrmToolStripMenuItem";
            this.dataSellStuBillBarCodeFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dataSellStuBillBarCodeFrmToolStripMenuItem.Text = "اذن صرف للطالب";
            this.dataSellStuBillBarCodeFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataTBLGardFrmToolStripMenuItem
            // 
            this.dataTBLGardFrmToolStripMenuItem.CheckOnClick = true;
            this.dataTBLGardFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.TabGardDetials;
            this.dataTBLGardFrmToolStripMenuItem.Name = "dataTBLGardFrmToolStripMenuItem";
            this.dataTBLGardFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dataTBLGardFrmToolStripMenuItem.Text = "الجرد";
            this.dataTBLGardFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataReturnSellStuBillFrmToolStripMenuItem
            // 
            this.dataReturnSellStuBillFrmToolStripMenuItem.CheckOnClick = true;
            this.dataReturnSellStuBillFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.dataReturnSellStuBill;
            this.dataReturnSellStuBillFrmToolStripMenuItem.Name = "dataReturnSellStuBillFrmToolStripMenuItem";
            this.dataReturnSellStuBillFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dataReturnSellStuBillFrmToolStripMenuItem.Text = "مردود المبيعات";
            this.dataReturnSellStuBillFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataReturnbuyBillFrmToolStripMenuItem
            // 
            this.dataReturnbuyBillFrmToolStripMenuItem.CheckOnClick = true;
            this.dataReturnbuyBillFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.dataReturnSellStuBill;
            this.dataReturnbuyBillFrmToolStripMenuItem.Name = "dataReturnbuyBillFrmToolStripMenuItem";
            this.dataReturnbuyBillFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dataReturnbuyBillFrmToolStripMenuItem.Text = "مردود المشتريات";
            this.dataReturnbuyBillFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataMortag3BillBarCodeFrmToolStripMenuItem
            // 
            this.dataMortag3BillBarCodeFrmToolStripMenuItem.CheckOnClick = true;
            this.dataMortag3BillBarCodeFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.dataReturnSellStuBill;
            this.dataMortag3BillBarCodeFrmToolStripMenuItem.Name = "dataMortag3BillBarCodeFrmToolStripMenuItem";
            this.dataMortag3BillBarCodeFrmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dataMortag3BillBarCodeFrmToolStripMenuItem.Text = "مرتجع الموردين";
            this.dataMortag3BillBarCodeFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataAccountToolStripMenuItem
            // 
            this.dataAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsTypesToolStripMenuItem,
            this.constraintsDailyToolStripMenuItem});
            this.dataAccountToolStripMenuItem.Image = global::BookStore.Properties.Resources.banks;
            this.dataAccountToolStripMenuItem.Name = "dataAccountToolStripMenuItem";
            this.dataAccountToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataAccountToolStripMenuItem.Text = "بيانات الحسابات";
            // 
            // accountsTypesToolStripMenuItem
            // 
            this.accountsTypesToolStripMenuItem.CheckOnClick = true;
            this.accountsTypesToolStripMenuItem.Image = global::BookStore.Properties.Resources.accountsTypes;
            this.accountsTypesToolStripMenuItem.Name = "accountsTypesToolStripMenuItem";
            this.accountsTypesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.accountsTypesToolStripMenuItem.Text = "دليل الحسابات";
            this.accountsTypesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // constraintsDailyToolStripMenuItem
            // 
            this.constraintsDailyToolStripMenuItem.CheckOnClick = true;
            this.constraintsDailyToolStripMenuItem.Image = global::BookStore.Properties.Resources.constraintsDaily;
            this.constraintsDailyToolStripMenuItem.Name = "constraintsDailyToolStripMenuItem";
            this.constraintsDailyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.constraintsDailyToolStripMenuItem.Text = "القيود اليوميــه";
            this.constraintsDailyToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // dataGeneralToolStripMenuItem
            // 
            this.dataGeneralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEmpToolStripMenuItem});
            this.dataGeneralToolStripMenuItem.Image = global::BookStore.Properties.Resources.Code;
            this.dataGeneralToolStripMenuItem.Name = "dataGeneralToolStripMenuItem";
            this.dataGeneralToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataGeneralToolStripMenuItem.Text = "بيانات عامه";
            // 
            // editEmpToolStripMenuItem
            // 
            this.editEmpToolStripMenuItem.CheckOnClick = true;
            this.editEmpToolStripMenuItem.Image = global::BookStore.Properties.Resources.editEmp;
            this.editEmpToolStripMenuItem.Name = "editEmpToolStripMenuItem";
            this.editEmpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editEmpToolStripMenuItem.Text = "العاملون";
            this.editEmpToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qrysellsFrmToolStripMenuItem,
            this.qryQryBuysFrmToolStripMenuItem,
            this.qryItemAvailabilityFrmToolStripMenuItem});
            this.queryToolStripMenuItem.Image = global::BookStore.Properties.Resources.Queries;
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.queryToolStripMenuItem.Text = "استعلامــات";
            // 
            // qrysellsFrmToolStripMenuItem
            // 
            this.qrysellsFrmToolStripMenuItem.CheckOnClick = true;
            this.qrysellsFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.Qry;
            this.qrysellsFrmToolStripMenuItem.Name = "qrysellsFrmToolStripMenuItem";
            this.qrysellsFrmToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.qrysellsFrmToolStripMenuItem.Text = "استعلام المبيعات";
            this.qrysellsFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // qryQryBuysFrmToolStripMenuItem
            // 
            this.qryQryBuysFrmToolStripMenuItem.CheckOnClick = true;
            this.qryQryBuysFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.Qry;
            this.qryQryBuysFrmToolStripMenuItem.Name = "qryQryBuysFrmToolStripMenuItem";
            this.qryQryBuysFrmToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.qryQryBuysFrmToolStripMenuItem.Text = "استعلام المشتريات";
            this.qryQryBuysFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // qryItemAvailabilityFrmToolStripMenuItem
            // 
            this.qryItemAvailabilityFrmToolStripMenuItem.CheckOnClick = true;
            this.qryItemAvailabilityFrmToolStripMenuItem.Image = global::BookStore.Properties.Resources.Qry;
            this.qryItemAvailabilityFrmToolStripMenuItem.Name = "qryItemAvailabilityFrmToolStripMenuItem";
            this.qryItemAvailabilityFrmToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.qryItemAvailabilityFrmToolStripMenuItem.Text = "الاصناف في المخزن";
            this.qryItemAvailabilityFrmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // printingToolStripMenuItem
            // 
            this.printingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xRep01ToolStripMenuItem,
            this.xRep02ToolStripMenuItem});
            this.printingToolStripMenuItem.Image = global::BookStore.Properties.Resources.Print1;
            this.printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            this.printingToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.printingToolStripMenuItem.Text = "طبــاعة تقاريــر";
            // 
            // xRep01ToolStripMenuItem
            // 
            this.xRep01ToolStripMenuItem.CheckOnClick = true;
            this.xRep01ToolStripMenuItem.Image = global::BookStore.Properties.Resources.Report;
            this.xRep01ToolStripMenuItem.Name = "xRep01ToolStripMenuItem";
            this.xRep01ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.xRep01ToolStripMenuItem.Text = "الواردات في فترة";
            this.xRep01ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prmEditorRoleToolStripMenuItem,
            this.prmEditorRoleMenuToolStripMenuItem,
            this.PremEditorUserToolStripMenuItem,
            this.premEditorUserInRoleToolStripMenuItem});
            this.permissionToolStripMenuItem.Image = global::BookStore.Properties.Resources.Permission;
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.permissionToolStripMenuItem.Text = "صلاحيــــات";
            // 
            // prmEditorRoleToolStripMenuItem
            // 
            this.prmEditorRoleToolStripMenuItem.CheckOnClick = true;
            this.prmEditorRoleToolStripMenuItem.Image = global::BookStore.Properties.Resources.Roles;
            this.prmEditorRoleToolStripMenuItem.Name = "prmEditorRoleToolStripMenuItem";
            this.prmEditorRoleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.prmEditorRoleToolStripMenuItem.Text = "السماحيات";
            this.prmEditorRoleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // prmEditorRoleMenuToolStripMenuItem
            // 
            this.prmEditorRoleMenuToolStripMenuItem.CheckOnClick = true;
            this.prmEditorRoleMenuToolStripMenuItem.Image = global::BookStore.Properties.Resources.RoleDetial;
            this.prmEditorRoleMenuToolStripMenuItem.Name = "prmEditorRoleMenuToolStripMenuItem";
            this.prmEditorRoleMenuToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.prmEditorRoleMenuToolStripMenuItem.Text = "محتويات الصلاحيات";
            this.prmEditorRoleMenuToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // PremEditorUserToolStripMenuItem
            // 
            this.PremEditorUserToolStripMenuItem.CheckOnClick = true;
            this.PremEditorUserToolStripMenuItem.Image = global::BookStore.Properties.Resources.Users;
            this.PremEditorUserToolStripMenuItem.Name = "PremEditorUserToolStripMenuItem";
            this.PremEditorUserToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.PremEditorUserToolStripMenuItem.Text = "المستخدمين";
            this.PremEditorUserToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // premEditorUserInRoleToolStripMenuItem
            // 
            this.premEditorUserInRoleToolStripMenuItem.CheckOnClick = true;
            this.premEditorUserInRoleToolStripMenuItem.Image = global::BookStore.Properties.Resources.UserRoles;
            this.premEditorUserInRoleToolStripMenuItem.Name = "premEditorUserInRoleToolStripMenuItem";
            this.premEditorUserInRoleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.premEditorUserInRoleToolStripMenuItem.Text = "سماحيات المستخدمين";
            this.premEditorUserInRoleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.skinsToolStripMenuItem});
            this.toolsMenu.Image = global::BookStore.Properties.Resources.Tools;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(97, 20);
            this.toolsMenu.Text = "ادوات";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.Image = global::BookStore.Properties.Resources.Options;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.optionsToolStripMenuItem.Text = "اختيارات";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // skinsToolStripMenuItem
            // 
            this.skinsToolStripMenuItem.CheckOnClick = true;
            this.skinsToolStripMenuItem.Image = global::BookStore.Properties.Resources.Skins;
            this.skinsToolStripMenuItem.Name = "skinsToolStripMenuItem";
            this.skinsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.skinsToolStripMenuItem.Text = "الاشكال";
            this.skinsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpMenu.Image = global::BookStore.Properties.Resources.Help;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(97, 20);
            this.helpMenu.Text = "مساعده";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.CheckOnClick = true;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.contentsToolStripMenuItem.Text = "المحتويات";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.CheckOnClick = true;
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.indexToolStripMenuItem.Text = "فهرس";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.CheckOnClick = true;
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.searchToolStripMenuItem.Text = "بحث";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.CheckOnClick = true;
            this.aboutToolStripMenuItem.Image = global::BookStore.Properties.Resources.EESoft;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "عن البرنامج";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // xRep02ToolStripMenuItem
            // 
            this.xRep02ToolStripMenuItem.CheckOnClick = true;
            this.xRep02ToolStripMenuItem.Image = global::BookStore.Properties.Resources.Report;
            this.xRep02ToolStripMenuItem.Name = "xRep02ToolStripMenuItem";
            this.xRep02ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.xRep02ToolStripMenuItem.Text = "اقرار استلام الكتب";
            this.xRep02ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem storeCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditorsalesUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorCDCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAsnafFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTblPricelistsFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBillFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constraintsDailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qrysellsFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qryItemAvailabilityFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prmEditorRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prmEditorRoleMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PremEditorUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premEditorUserInRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qryQryBuysFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSellStuBillBarCodeFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTBLGardFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStudentFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataReturnSellStuBillFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataReturnbuyBillFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMortag3BillBarCodeFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xRep01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xRep02ToolStripMenuItem;
    }
}