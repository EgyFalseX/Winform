﻿namespace StAccount
{
    partial class AccTypesFrm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccTypesFrm));
            this.TreeListAcc = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollectionNodes = new DevExpress.Utils.ImageCollection(this.components);
            this.GCCodes = new DevExpress.XtraEditors.GroupControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.LlHyCode = new DevExpress.XtraEditors.LabelControl();
            this.LblAccCode = new DevExpress.XtraEditors.LabelControl();
            this.LblParentName = new DevExpress.XtraEditors.LabelControl();
            this.LblTreeID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GCDetails = new DevExpress.XtraEditors.GroupControl();
            this.TxtAccName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCCodes)).BeginInit();
            this.GCCodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCDetails)).BeginInit();
            this.GCDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeListAcc
            // 
            this.TreeListAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeListAcc.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn6,
            this.treeListColumn2,
            this.treeListColumn7});
            this.TreeListAcc.Location = new System.Drawing.Point(10, 12);
            this.TreeListAcc.Name = "TreeListAcc";
            this.TreeListAcc.BeginUnboundLoad();
            this.TreeListAcc.AppendNode(new object[] {
            "شجرة الحسابات",
            null,
            null,
            null}, -1, 0, 1, -1);
            this.TreeListAcc.EndUnboundLoad();
            this.TreeListAcc.OptionsBehavior.PopulateServiceColumns = true;
            this.TreeListAcc.OptionsLayout.AddNewColumns = false;
            this.TreeListAcc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.TreeListAcc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.TreeListAcc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TreeListAcc.SelectImageList = this.imageCollectionNodes;
            this.TreeListAcc.Size = new System.Drawing.Size(840, 300);
            this.TreeListAcc.TabIndex = 0;
            this.TreeListAcc.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.TreeListAcc_AfterExpand);
            this.TreeListAcc.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.TreeListAcc_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn1.Caption = "-   الحســــابات   -";
            this.treeListColumn1.FieldName = "اسم الحساب";
            this.treeListColumn1.MinWidth = 91;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 91;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn6.Caption = "كود الدليل";
            this.treeListColumn6.FieldName = "AccountTreeId";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.OptionsColumn.AllowEdit = false;
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 1;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn2.Caption = "اسم الحساب";
            this.treeListColumn2.ColumnEdit = this.repositoryItemButtonEdit1;
            this.treeListColumn2.FieldName = "AccountDes";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 2;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "حفظ", 30, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.MaxLength = 150;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn7.Caption = "Account ID";
            this.treeListColumn7.FieldName = "AccountId";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.OptionsColumn.AllowEdit = false;
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 3;
            // 
            // imageCollectionNodes
            // 
            this.imageCollectionNodes.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionNodes.ImageStream")));
            this.imageCollectionNodes.Images.SetKeyName(0, "NodeItems.jpg");
            this.imageCollectionNodes.Images.SetKeyName(1, "NodeSelected.png");
            this.imageCollectionNodes.Images.SetKeyName(2, "NodeNotSelected.png");
            // 
            // GCCodes
            // 
            this.GCCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GCCodes.Controls.Add(this.labelControl15);
            this.GCCodes.Controls.Add(this.LlHyCode);
            this.GCCodes.Controls.Add(this.LblAccCode);
            this.GCCodes.Controls.Add(this.LblParentName);
            this.GCCodes.Controls.Add(this.LblTreeID);
            this.GCCodes.Controls.Add(this.labelControl1);
            this.GCCodes.Location = new System.Drawing.Point(12, 318);
            this.GCCodes.Name = "GCCodes";
            this.GCCodes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GCCodes.Size = new System.Drawing.Size(293, 136);
            this.GCCodes.TabIndex = 1;
            this.GCCodes.Text = "اكواد";
            this.GCCodes.Visible = false;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(175, 34);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(84, 13);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "اسم الحساب الاب";
            // 
            // LlHyCode
            // 
            this.LlHyCode.Location = new System.Drawing.Point(85, 85);
            this.LlHyCode.Name = "LlHyCode";
            this.LlHyCode.Size = new System.Drawing.Size(104, 13);
            this.LlHyCode.TabIndex = 0;
            this.LlHyCode.Text = "كود الحساب في الدليل";
            // 
            // LblAccCode
            // 
            this.LblAccCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblAccCode.Location = new System.Drawing.Point(31, 53);
            this.LblAccCode.Name = "LblAccCode";
            this.LblAccCode.Size = new System.Drawing.Size(25, 13);
            this.LblAccCode.TabIndex = 0;
            this.LblAccCode.Text = "None";
            // 
            // LblParentName
            // 
            this.LblParentName.Location = new System.Drawing.Point(31, 34);
            this.LblParentName.Name = "LblParentName";
            this.LblParentName.Size = new System.Drawing.Size(25, 13);
            this.LblParentName.TabIndex = 0;
            this.LblParentName.Text = "None";
            // 
            // LblTreeID
            // 
            this.LblTreeID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblTreeID.Location = new System.Drawing.Point(137, 104);
            this.LblTreeID.Name = "LblTreeID";
            this.LblTreeID.Size = new System.Drawing.Size(25, 13);
            this.LblTreeID.TabIndex = 0;
            this.LblTreeID.Text = "None";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(205, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "كود الحساب";
            // 
            // GCDetails
            // 
            this.GCDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GCDetails.Controls.Add(this.TxtAccName);
            this.GCDetails.Controls.Add(this.labelControl7);
            this.GCDetails.Location = new System.Drawing.Point(311, 318);
            this.GCDetails.Name = "GCDetails";
            this.GCDetails.Size = new System.Drawing.Size(319, 136);
            this.GCDetails.TabIndex = 1;
            this.GCDetails.Text = "تفاصيل الحساب";
            this.GCDetails.Visible = false;
            // 
            // TxtAccName
            // 
            this.TxtAccName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAccName.Location = new System.Drawing.Point(12, 30);
            this.TxtAccName.Name = "TxtAccName";
            this.TxtAccName.Properties.MaxLength = 150;
            this.TxtAccName.Size = new System.Drawing.Size(187, 20);
            this.TxtAccName.TabIndex = 1;
            this.TxtAccName.EditValueChanged += new System.EventHandler(this.TxtAccName_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(239, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "اسم الحساب";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.BtnCancel);
            this.groupControl3.Controls.Add(this.BtnDelete);
            this.groupControl3.Controls.Add(this.BtnSave);
            this.groupControl3.Controls.Add(this.BtnNew);
            this.groupControl3.Location = new System.Drawing.Point(636, 318);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(214, 136);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "الاوامر";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(134, 33);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(72, 81);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "الغاء الامر";
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(8, 91);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(8, 62);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(8, 33);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(120, 23);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "جديد";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // AccTypesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 462);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.GCDetails);
            this.Controls.Add(this.GCCodes);
            this.Controls.Add(this.TreeListAcc);
            this.MinimumSize = new System.Drawing.Size(870, 496);
            this.Name = "AccTypesFrm";
            this.Text = "اكواد الحسابات";
            this.Load += new System.EventHandler(this.AccTypesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TreeListAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCCodes)).EndInit();
            this.GCCodes.ResumeLayout(false);
            this.GCCodes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCDetails)).EndInit();
            this.GCDetails.ResumeLayout(false);
            this.GCDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList TreeListAcc;
        private DevExpress.XtraEditors.GroupControl GCCodes;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl LlHyCode;
        private DevExpress.XtraEditors.LabelControl LblAccCode;
        private DevExpress.XtraEditors.LabelControl LblParentName;
        private DevExpress.XtraEditors.LabelControl LblTreeID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl GCDetails;
        private DevExpress.XtraEditors.TextEdit TxtAccName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.Utils.ImageCollection imageCollectionNodes;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;

    }
}