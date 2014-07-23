namespace schoolStore
{
    partial class AccTreeOptionsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccTreeOptionsFrm));
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPagesupplier = new DevExpress.XtraTab.XtraTabPage();
            this.Txtsupplier = new DevExpress.XtraEditors.TextEdit();
            this.TVsupplier = new System.Windows.Forms.TreeView();
            this.MyimageList = new System.Windows.Forms.ImageList(this.components);
            this.Btnsupplier = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPagecustomer = new DevExpress.XtraTab.XtraTabPage();
            this.Txtcustomer = new DevExpress.XtraEditors.TextEdit();
            this.TVcustomer = new System.Windows.Forms.TreeView();
            this.Btncustomer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPagesupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtsupplier.Properties)).BeginInit();
            this.xtraTabPagecustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtcustomer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControlMain.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPagesupplier;
            this.xtraTabControlMain.Size = new System.Drawing.Size(301, 331);
            this.xtraTabControlMain.TabIndex = 0;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPagesupplier,
            this.xtraTabPagecustomer});
            this.xtraTabControlMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControlMain_SelectedPageChanged);
            // 
            // xtraTabPagesupplier
            // 
            this.xtraTabPagesupplier.Controls.Add(this.Txtsupplier);
            this.xtraTabPagesupplier.Controls.Add(this.TVsupplier);
            this.xtraTabPagesupplier.Controls.Add(this.Btnsupplier);
            this.xtraTabPagesupplier.Name = "xtraTabPagesupplier";
            this.xtraTabPagesupplier.Size = new System.Drawing.Size(295, 305);
            this.xtraTabPagesupplier.Text = "الموردين";
            // 
            // Txtsupplier
            // 
            this.Txtsupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txtsupplier.Location = new System.Drawing.Point(58, 13);
            this.Txtsupplier.Name = "Txtsupplier";
            this.Txtsupplier.Size = new System.Drawing.Size(178, 19);
            this.Txtsupplier.TabIndex = 2;
            // 
            // TVsupplier
            // 
            this.TVsupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TVsupplier.FullRowSelect = true;
            this.TVsupplier.HideSelection = false;
            this.TVsupplier.ImageIndex = 0;
            this.TVsupplier.ImageList = this.MyimageList;
            this.TVsupplier.Location = new System.Drawing.Point(22, 38);
            this.TVsupplier.Name = "TVsupplier";
            this.TVsupplier.SelectedImageIndex = 0;
            this.TVsupplier.Size = new System.Drawing.Size(251, 229);
            this.TVsupplier.TabIndex = 1;
            // 
            // MyimageList
            // 
            this.MyimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyimageList.ImageStream")));
            this.MyimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MyimageList.Images.SetKeyName(0, "Folders.png");
            this.MyimageList.Images.SetKeyName(1, "Material.png");
            this.MyimageList.Images.SetKeyName(2, "AddTGrid.png");
            // 
            // Btnsupplier
            // 
            this.Btnsupplier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnsupplier.Location = new System.Drawing.Point(58, 273);
            this.Btnsupplier.Name = "Btnsupplier";
            this.Btnsupplier.Size = new System.Drawing.Size(178, 23);
            this.Btnsupplier.TabIndex = 0;
            this.Btnsupplier.Text = "حفظ";
            this.Btnsupplier.Click += new System.EventHandler(this.Btnsupplier_Click);
            // 
            // xtraTabPagecustomer
            // 
            this.xtraTabPagecustomer.Controls.Add(this.Txtcustomer);
            this.xtraTabPagecustomer.Controls.Add(this.TVcustomer);
            this.xtraTabPagecustomer.Controls.Add(this.Btncustomer);
            this.xtraTabPagecustomer.Name = "xtraTabPagecustomer";
            this.xtraTabPagecustomer.Size = new System.Drawing.Size(295, 305);
            this.xtraTabPagecustomer.Text = "العملاء";
            // 
            // Txtcustomer
            // 
            this.Txtcustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txtcustomer.Location = new System.Drawing.Point(58, 13);
            this.Txtcustomer.Name = "Txtcustomer";
            this.Txtcustomer.Size = new System.Drawing.Size(178, 19);
            this.Txtcustomer.TabIndex = 5;
            // 
            // TVcustomer
            // 
            this.TVcustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TVcustomer.FullRowSelect = true;
            this.TVcustomer.HideSelection = false;
            this.TVcustomer.ImageIndex = 0;
            this.TVcustomer.ImageList = this.MyimageList;
            this.TVcustomer.Location = new System.Drawing.Point(22, 38);
            this.TVcustomer.Name = "TVcustomer";
            this.TVcustomer.SelectedImageIndex = 0;
            this.TVcustomer.Size = new System.Drawing.Size(251, 229);
            this.TVcustomer.TabIndex = 4;
            // 
            // Btncustomer
            // 
            this.Btncustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btncustomer.Location = new System.Drawing.Point(58, 273);
            this.Btncustomer.Name = "Btncustomer";
            this.Btncustomer.Size = new System.Drawing.Size(178, 23);
            this.Btncustomer.TabIndex = 3;
            this.Btncustomer.Text = "حفظ";
            this.Btncustomer.Click += new System.EventHandler(this.Btncustomer_Click);
            // 
            // AccTreeOptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 355);
            this.Controls.Add(this.xtraTabControlMain);
            this.Name = "AccTreeOptionsFrm";
            this.Text = "خيارات شجرة الحسابات";
            this.Load += new System.EventHandler(this.AccTreeOptionsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPagesupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Txtsupplier.Properties)).EndInit();
            this.xtraTabPagecustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Txtcustomer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagesupplier;
        private DevExpress.XtraEditors.TextEdit Txtsupplier;
        private System.Windows.Forms.TreeView TVsupplier;
        private DevExpress.XtraEditors.SimpleButton Btnsupplier;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagecustomer;
        private DevExpress.XtraEditors.TextEdit Txtcustomer;
        private System.Windows.Forms.TreeView TVcustomer;
        private DevExpress.XtraEditors.SimpleButton Btncustomer;
        private System.Windows.Forms.ImageList MyimageList;
    }
}