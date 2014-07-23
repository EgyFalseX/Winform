namespace schoolStore
{
    partial class AccTypesDlgFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccTypesDlgFrm));
            this.TLAccNames = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.BtnOk = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollectionNodes = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TLAccNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // TLAccNames
            // 
            this.TLAccNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TLAccNames.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.TLAccNames.Location = new System.Drawing.Point(8, 3);
            this.TLAccNames.Name = "TLAccNames";
            this.TLAccNames.BeginUnboundLoad();
            this.TLAccNames.AppendNode(new object[] {
            "شجرة الحسابات",
            "0"}, -1, 0, 1, -1);
            this.TLAccNames.EndUnboundLoad();
            this.TLAccNames.OptionsBehavior.Editable = false;
            this.TLAccNames.OptionsBehavior.PopulateServiceColumns = true;
            this.TLAccNames.OptionsLayout.AddNewColumns = false;
            this.TLAccNames.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.TLAccNames.SelectImageList = this.imageCollectionNodes;
            this.TLAccNames.Size = new System.Drawing.Size(272, 220);
            this.TLAccNames.TabIndex = 0;
            this.TLAccNames.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.TLAccNames_AfterExpand);
            this.TLAccNames.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.TLAccNames_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "اسم الحساب";
            this.treeListColumn1.FieldName = "AccountDes";
            this.treeListColumn1.MinWidth = 37;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "AccountId";
            this.treeListColumn2.FieldName = "AccountId";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Enabled = false;
            this.BtnOk.Location = new System.Drawing.Point(205, 229);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "موافق";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(124, 229);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "الغاء";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // imageCollectionNodes
            // 
            this.imageCollectionNodes.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionNodes.ImageStream")));
            this.imageCollectionNodes.Images.SetKeyName(0, "NodeItems.jpg");
            this.imageCollectionNodes.Images.SetKeyName(1, "NodeSelected.png");
            this.imageCollectionNodes.Images.SetKeyName(2, "NodeNotSelected.png");
            // 
            // AccTypesDlgFrm
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(288, 258);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TLAccNames);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccTypesDlgFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "الحســــــــــــــابات";
            this.Load += new System.EventHandler(this.AccTypesDlgFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TLAccNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList TLAccNames;
        private DevExpress.XtraEditors.SimpleButton BtnOk;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.Utils.ImageCollection imageCollectionNodes;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}