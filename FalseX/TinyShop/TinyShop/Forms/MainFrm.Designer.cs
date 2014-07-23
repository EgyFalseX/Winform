namespace TinyShop.Forms
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
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupPrint = new DevExpress.XtraNavBar.NavBarGroup();
            this.ItemPrintBarcode = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupMain = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemProductsEditor = new DevExpress.XtraNavBar.NavBarItem();
            this.ItemSuppliersEditor = new DevExpress.XtraNavBar.NavBarItem();
            this.ItemCustomersEditor = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupBills = new DevExpress.XtraNavBar.NavBarGroup();
            this.ItemBillsBaye3Editor = new DevExpress.XtraNavBar.NavBarItem();
            this.ItemBillsTawreedEditor = new DevExpress.XtraNavBar.NavBarItem();
            this.ItemBillsMortaga3Editor = new DevExpress.XtraNavBar.NavBarItem();
            this.ItemBillsHawaleekEditor = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupQuery = new DevExpress.XtraNavBar.NavBarGroup();
            this.ItemQryBills = new DevExpress.XtraNavBar.NavBarItem();
            this.ItemQryBillsDetails = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupOptions = new DevExpress.XtraNavBar.NavBarGroup();
            this.ItemOptions = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageList = new System.Windows.Forms.ImageList(this.components);
            this.navbarImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mFile = new DevExpress.XtraBars.BarSubItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.mHelp = new DevExpress.XtraBars.BarSubItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroupPrint;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupMain,
            this.navBarGroupBills,
            this.navBarGroupQuery,
            this.navBarGroupPrint,
            this.navBarGroupOptions});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.itemProductsEditor,
            this.ItemCustomersEditor,
            this.ItemSuppliersEditor,
            this.ItemBillsBaye3Editor,
            this.ItemBillsTawreedEditor,
            this.ItemBillsMortaga3Editor,
            this.ItemBillsHawaleekEditor,
            this.ItemQryBills,
            this.ItemQryBillsDetails,
            this.ItemOptions,
            this.ItemPrintBarcode});
            this.navBarControl.LargeImages = this.navbarImageList;
            this.navBarControl.Location = new System.Drawing.Point(0, 24);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl.Size = new System.Drawing.Size(165, 499);
            this.navBarControl.SmallImages = this.navbarImageListLarge;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 1;
            // 
            // navBarGroupPrint
            // 
            this.navBarGroupPrint.Caption = "طباعة";
            this.navBarGroupPrint.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemPrintBarcode)});
            this.navBarGroupPrint.LargeImageIndex = 4;
            this.navBarGroupPrint.Name = "navBarGroupPrint";
            // 
            // ItemPrintBarcode
            // 
            this.ItemPrintBarcode.Caption = "طباعة الباركود";
            this.ItemPrintBarcode.Name = "ItemPrintBarcode";
            this.ItemPrintBarcode.SmallImage = global::TinyShop.Properties.Resources.barcode;
            this.ItemPrintBarcode.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemPrintBarcode_LinkClicked);
            // 
            // navBarGroupMain
            // 
            this.navBarGroupMain.Caption = "بيانات رئيسية";
            this.navBarGroupMain.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroupMain.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemProductsEditor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemSuppliersEditor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemCustomersEditor)});
            this.navBarGroupMain.LargeImageIndex = 0;
            this.navBarGroupMain.Name = "navBarGroupMain";
            // 
            // itemProductsEditor
            // 
            this.itemProductsEditor.Caption = "الاصناف";
            this.itemProductsEditor.Name = "itemProductsEditor";
            this.itemProductsEditor.SmallImage = global::TinyShop.Properties.Resources.ProductsEditor;
            this.itemProductsEditor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itemProductsEditor_LinkClicked);
            // 
            // ItemSuppliersEditor
            // 
            this.ItemSuppliersEditor.Caption = "الموردين";
            this.ItemSuppliersEditor.Name = "ItemSuppliersEditor";
            this.ItemSuppliersEditor.SmallImage = global::TinyShop.Properties.Resources.SuppliersEditor;
            this.ItemSuppliersEditor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemSuppliersEditor_LinkClicked);
            // 
            // ItemCustomersEditor
            // 
            this.ItemCustomersEditor.Caption = "العملاء";
            this.ItemCustomersEditor.Name = "ItemCustomersEditor";
            this.ItemCustomersEditor.SmallImage = global::TinyShop.Properties.Resources.CustomersEditor;
            this.ItemCustomersEditor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemCustomersEditor_LinkClicked);
            // 
            // navBarGroupBills
            // 
            this.navBarGroupBills.Caption = "الفواتير";
            this.navBarGroupBills.Expanded = true;
            this.navBarGroupBills.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroupBills.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemBillsBaye3Editor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemBillsTawreedEditor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemBillsMortaga3Editor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemBillsHawaleekEditor)});
            this.navBarGroupBills.LargeImageIndex = 1;
            this.navBarGroupBills.Name = "navBarGroupBills";
            // 
            // ItemBillsBaye3Editor
            // 
            this.ItemBillsBaye3Editor.Caption = "فواتير المبيعات";
            this.ItemBillsBaye3Editor.Name = "ItemBillsBaye3Editor";
            this.ItemBillsBaye3Editor.SmallImage = global::TinyShop.Properties.Resources.Baye3Editor;
            this.ItemBillsBaye3Editor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemBillsBaye3Editor_LinkClicked);
            // 
            // ItemBillsTawreedEditor
            // 
            this.ItemBillsTawreedEditor.Caption = "فواتير المشتريات";
            this.ItemBillsTawreedEditor.Name = "ItemBillsTawreedEditor";
            this.ItemBillsTawreedEditor.SmallImage = global::TinyShop.Properties.Resources.TawreedEditor;
            this.ItemBillsTawreedEditor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemBillsTawreedEditor_LinkClicked);
            // 
            // ItemBillsMortaga3Editor
            // 
            this.ItemBillsMortaga3Editor.Caption = "فواتير المرتجع";
            this.ItemBillsMortaga3Editor.Name = "ItemBillsMortaga3Editor";
            this.ItemBillsMortaga3Editor.SmallImage = global::TinyShop.Properties.Resources.Mortaga3Editor;
            this.ItemBillsMortaga3Editor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemBillsMortaga3Editor_LinkClicked);
            // 
            // ItemBillsHawaleekEditor
            // 
            this.ItemBillsHawaleekEditor.Caption = "فواتير الهوالك";
            this.ItemBillsHawaleekEditor.Name = "ItemBillsHawaleekEditor";
            this.ItemBillsHawaleekEditor.SmallImage = global::TinyShop.Properties.Resources.HawaleekEditor;
            this.ItemBillsHawaleekEditor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemBillsHawaleekEditor_LinkClicked);
            // 
            // navBarGroupQuery
            // 
            this.navBarGroupQuery.Caption = "استعلامات";
            this.navBarGroupQuery.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroupQuery.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemQryBills),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemQryBillsDetails)});
            this.navBarGroupQuery.LargeImageIndex = 2;
            this.navBarGroupQuery.Name = "navBarGroupQuery";
            // 
            // ItemQryBills
            // 
            this.ItemQryBills.Caption = "الفواتير";
            this.ItemQryBills.Name = "ItemQryBills";
            this.ItemQryBills.SmallImage = global::TinyShop.Properties.Resources.Qry;
            this.ItemQryBills.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemQryBills_LinkClicked);
            // 
            // ItemQryBillsDetails
            // 
            this.ItemQryBillsDetails.Caption = "تفاصيل الفواتير";
            this.ItemQryBillsDetails.Name = "ItemQryBillsDetails";
            this.ItemQryBillsDetails.SmallImage = global::TinyShop.Properties.Resources.Qry;
            this.ItemQryBillsDetails.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemQryBillsDetails_LinkClicked);
            // 
            // navBarGroupOptions
            // 
            this.navBarGroupOptions.Caption = "خيارات";
            this.navBarGroupOptions.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemOptions)});
            this.navBarGroupOptions.LargeImageIndex = 3;
            this.navBarGroupOptions.Name = "navBarGroupOptions";
            // 
            // ItemOptions
            // 
            this.ItemOptions.Caption = "خيارات البرنامج";
            this.ItemOptions.Name = "ItemOptions";
            this.ItemOptions.SmallImage = global::TinyShop.Properties.Resources.Options;
            this.ItemOptions.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemOptions_LinkClicked);
            // 
            // navbarImageList
            // 
            this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
            this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageList.Images.SetKeyName(0, "Code.png");
            this.navbarImageList.Images.SetKeyName(1, "Data.png");
            this.navbarImageList.Images.SetKeyName(2, "Query.png");
            this.navbarImageList.Images.SetKeyName(3, "Options.png");
            this.navbarImageList.Images.SetKeyName(4, "Print.png");
            // 
            // navbarImageListLarge
            // 
            this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
            this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageListLarge.Images.SetKeyName(0, "ProductsEditor.png");
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mFile,
            this.barButtonItem2,
            this.iExit,
            this.mHelp,
            this.iAbout});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 12;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mHelp)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // mFile
            // 
            this.mFile.Caption = "&File";
            this.mFile.Glyph = global::TinyShop.Properties.Resources.File;
            this.mFile.Id = 0;
            this.mFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit)});
            this.mFile.Name = "mFile";
            this.mFile.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.Glyph = global::TinyShop.Properties.Resources.Delete;
            this.iExit.Id = 9;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // mHelp
            // 
            this.mHelp.Caption = "&Help";
            this.mHelp.Glyph = global::TinyShop.Properties.Resources.Help;
            this.mHelp.Id = 10;
            this.mHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout)});
            this.mHelp.Name = "mHelp";
            this.mHelp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.Glyph = global::TinyShop.Properties.Resources.About;
            this.iAbout.Id = 11;
            this.iAbout.Name = "iAbout";
            this.iAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAbout_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(942, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 523);
            this.barDockControlBottom.Size = new System.Drawing.Size(942, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(942, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 499);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Open";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 523);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiny Shop";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarSubItem mHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupBills;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupQuery;
        private DevExpress.XtraNavBar.NavBarItem itemProductsEditor;
        private DevExpress.XtraNavBar.NavBarItem ItemCustomersEditor;
        private DevExpress.XtraNavBar.NavBarItem ItemSuppliersEditor;
        private DevExpress.XtraNavBar.NavBarItem ItemBillsBaye3Editor;
        private System.Windows.Forms.ImageList navbarImageList;
        private System.Windows.Forms.ImageList navbarImageListLarge;
        private DevExpress.XtraNavBar.NavBarItem ItemBillsTawreedEditor;
        private DevExpress.XtraNavBar.NavBarItem ItemBillsMortaga3Editor;
        private DevExpress.XtraNavBar.NavBarItem ItemBillsHawaleekEditor;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupMain;
        private DevExpress.XtraNavBar.NavBarItem ItemQryBills;
        private DevExpress.XtraNavBar.NavBarItem ItemQryBillsDetails;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupOptions;
        private DevExpress.XtraNavBar.NavBarItem ItemOptions;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupPrint;
        private DevExpress.XtraNavBar.NavBarItem ItemPrintBarcode;

    }
}
