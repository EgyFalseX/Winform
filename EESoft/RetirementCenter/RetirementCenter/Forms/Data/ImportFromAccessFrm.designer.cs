namespace RetirementCenter
{
    partial class ImportFromAccessFrm
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
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.ceWarasaExtra = new DevExpress.XtraEditors.CheckEdit();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.ceWarasa = new DevExpress.XtraEditors.CheckEdit();
            this.ceExtra = new DevExpress.XtraEditors.CheckEdit();
            this.lblCounter = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlOp = new DevExpress.XtraEditors.GroupControl();
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.dsdatam = new RetirementCenter.DataSources.dsdatam();
            this.replyTableAdapter = new RetirementCenter.DataSources.dsdatamTableAdapters.replyTableAdapter();
            this.reply_wTableAdapter = new RetirementCenter.DataSources.dsdatamTableAdapters.reply_wTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ceUpdateNIDWarasa = new DevExpress.XtraEditors.CheckEdit();
            this.ceUpdateNIDMember = new DevExpress.XtraEditors.CheckEdit();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lblWebWarasaCounter = new DevExpress.XtraEditors.LabelControl();
            this.lblWebMemberCounter = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tblmemberTableAdapter = new RetirementCenter.DataSources.dsWebDataTableAdapters.tblmemberTableAdapter();
            this.dsWebData = new RetirementCenter.DataSources.dsWebData();
            this.tblwarasasonTableAdapter = new RetirementCenter.DataSources.dsWebDataTableAdapters.tblwarasasonTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnImportAccess = new DevExpress.XtraEditors.SimpleButton();
            this.ceImportAccsess = new DevExpress.XtraEditors.CheckEdit();
            this.lblAccessCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.tblMashatTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter();
            this.tblmRemarksTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLMRemarksTableAdapter();
            this.tblMashatTablebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEdafatTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLEdafatTableAdapter();
            this.tblWarasaTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLWarasaTableAdapter();
            this.tblEdafatWarsaTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLEdafatWarsaTableAdapter();
            this.fromAccessTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.FromAccessTableAdapter();
            this.accsessTableAdapter = new RetirementCenter.DataSources.dsdatamTableAdapters.accsessTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceWarasaExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceWarasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOp)).BeginInit();
            this.groupControlOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdatam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceUpdateNIDWarasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceUpdateNIDMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWebData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceImportAccsess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMashatTablebindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlInfo.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlInfo.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControlInfo.Controls.Add(this.ceWarasaExtra);
            this.groupControlInfo.Controls.Add(this.btnImport);
            this.groupControlInfo.Controls.Add(this.ceWarasa);
            this.groupControlInfo.Controls.Add(this.ceExtra);
            this.groupControlInfo.Controls.Add(this.lblCounter);
            this.groupControlInfo.Controls.Add(this.labelControl1);
            this.groupControlInfo.Location = new System.Drawing.Point(345, 12);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(327, 100);
            this.groupControlInfo.TabIndex = 0;
            this.groupControlInfo.Text = "استيراد بيانات";
            // 
            // ceWarasaExtra
            // 
            this.ceWarasaExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceWarasaExtra.Enabled = false;
            this.ceWarasaExtra.Location = new System.Drawing.Point(23, 76);
            this.ceWarasaExtra.Name = "ceWarasaExtra";
            this.ceWarasaExtra.Properties.Caption = "الحاق اضافات الورثة";
            this.ceWarasaExtra.Size = new System.Drawing.Size(114, 19);
            this.ceWarasaExtra.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(5, 24);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "استيراد";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ceWarasa
            // 
            this.ceWarasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceWarasa.Location = new System.Drawing.Point(143, 76);
            this.ceWarasa.Name = "ceWarasa";
            this.ceWarasa.Properties.Caption = "الحاق الورثة";
            this.ceWarasa.Size = new System.Drawing.Size(77, 19);
            this.ceWarasa.TabIndex = 1;
            this.ceWarasa.CheckedChanged += new System.EventHandler(this.ceWarasa_CheckedChanged);
            // 
            // ceExtra
            // 
            this.ceExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceExtra.Location = new System.Drawing.Point(226, 76);
            this.ceExtra.Name = "ceExtra";
            this.ceExtra.Properties.Caption = "الحاق الاضافات";
            this.ceExtra.Size = new System.Drawing.Size(92, 19);
            this.ceExtra.TabIndex = 1;
            // 
            // lblCounter
            // 
            this.lblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCounter.Location = new System.Drawing.Point(212, 38);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(6, 13);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(281, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "العدد";
            // 
            // groupControlOp
            // 
            this.groupControlOp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlOp.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlOp.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControlOp.Controls.Add(this.pbc);
            this.groupControlOp.Location = new System.Drawing.Point(12, 221);
            this.groupControlOp.Name = "groupControlOp";
            this.groupControlOp.Size = new System.Drawing.Size(660, 100);
            this.groupControlOp.TabIndex = 1;
            this.groupControlOp.Text = "العمليات";
            // 
            // pbc
            // 
            this.pbc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbc.Location = new System.Drawing.Point(2, 80);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(656, 18);
            this.pbc.TabIndex = 1;
            // 
            // dsdatam
            // 
            this.dsdatam.DataSetName = "dsdatam";
            this.dsdatam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // replyTableAdapter
            // 
            this.replyTableAdapter.ClearBeforeFill = true;
            // 
            // reply_wTableAdapter
            // 
            this.reply_wTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.Controls.Add(this.ceUpdateNIDWarasa);
            this.groupControl1.Controls.Add(this.ceUpdateNIDMember);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.lblWebWarasaCounter);
            this.groupControl1.Controls.Add(this.lblWebMemberCounter);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(14, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "قاعدة بيانات الويب";
            // 
            // ceUpdateNIDWarasa
            // 
            this.ceUpdateNIDWarasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceUpdateNIDWarasa.Location = new System.Drawing.Point(8, 76);
            this.ceUpdateNIDWarasa.Name = "ceUpdateNIDWarasa";
            this.ceUpdateNIDWarasa.Properties.Caption = "تحديث الرقم القومي للورثة";
            this.ceUpdateNIDWarasa.Size = new System.Drawing.Size(152, 19);
            this.ceUpdateNIDWarasa.TabIndex = 1;
            // 
            // ceUpdateNIDMember
            // 
            this.ceUpdateNIDMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceUpdateNIDMember.Location = new System.Drawing.Point(166, 76);
            this.ceUpdateNIDMember.Name = "ceUpdateNIDMember";
            this.ceUpdateNIDMember.Properties.Caption = "تحديث الرقم القومي للاعضاء";
            this.ceUpdateNIDMember.Size = new System.Drawing.Size(152, 19);
            this.ceUpdateNIDMember.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(5, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "استيراد";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblWebWarasaCounter
            // 
            this.lblWebWarasaCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWebWarasaCounter.Location = new System.Drawing.Point(31, 57);
            this.lblWebWarasaCounter.Name = "lblWebWarasaCounter";
            this.lblWebWarasaCounter.Size = new System.Drawing.Size(6, 13);
            this.lblWebWarasaCounter.TabIndex = 0;
            this.lblWebWarasaCounter.Text = "0";
            // 
            // lblWebMemberCounter
            // 
            this.lblWebMemberCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWebMemberCounter.Location = new System.Drawing.Point(212, 57);
            this.lblWebMemberCounter.Name = "lblWebMemberCounter";
            this.lblWebMemberCounter.Size = new System.Drawing.Size(6, 13);
            this.lblWebMemberCounter.TabIndex = 0;
            this.lblWebMemberCounter.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(100, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "العدد";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(281, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "العدد";
            // 
            // tblmemberTableAdapter
            // 
            this.tblmemberTableAdapter.ClearBeforeFill = true;
            // 
            // dsWebData
            // 
            this.dsWebData.DataSetName = "dsWebData";
            this.dsWebData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblwarasasonTableAdapter
            // 
            this.tblwarasasonTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl2.Controls.Add(this.btnImportAccess);
            this.groupControl2.Controls.Add(this.ceImportAccsess);
            this.groupControl2.Controls.Add(this.lblAccessCount);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(14, 115);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(658, 100);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "استيراد مالي";
            // 
            // btnImportAccess
            // 
            this.btnImportAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportAccess.Location = new System.Drawing.Point(336, 24);
            this.btnImportAccess.Name = "btnImportAccess";
            this.btnImportAccess.Size = new System.Drawing.Size(100, 23);
            this.btnImportAccess.TabIndex = 0;
            this.btnImportAccess.Text = "استيراد";
            this.btnImportAccess.Click += new System.EventHandler(this.btnImportAccess_Click);
            // 
            // ceImportAccsess
            // 
            this.ceImportAccsess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceImportAccsess.Location = new System.Drawing.Point(584, 76);
            this.ceImportAccsess.Name = "ceImportAccsess";
            this.ceImportAccsess.Properties.Caption = "الحــــاق";
            this.ceImportAccsess.Size = new System.Drawing.Size(65, 19);
            this.ceImportAccsess.TabIndex = 1;
            // 
            // lblAccessCount
            // 
            this.lblAccessCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccessCount.Location = new System.Drawing.Point(543, 38);
            this.lblAccessCount.Name = "lblAccessCount";
            this.lblAccessCount.Size = new System.Drawing.Size(6, 13);
            this.lblAccessCount.TabIndex = 0;
            this.lblAccessCount.Text = "0";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(612, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "العدد";
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMashatTableAdapter
            // 
            this.tblMashatTableAdapter.ClearBeforeFill = true;
            // 
            // tblmRemarksTableAdapter
            // 
            this.tblmRemarksTableAdapter.ClearBeforeFill = true;
            // 
            // tblMashatTablebindingSource
            // 
            this.tblMashatTablebindingSource.DataMember = "TBLMashat";
            this.tblMashatTablebindingSource.DataSource = this.dsRetirementCenter;
            // 
            // tblEdafatTableAdapter
            // 
            this.tblEdafatTableAdapter.ClearBeforeFill = true;
            // 
            // tblWarasaTableAdapter
            // 
            this.tblWarasaTableAdapter.ClearBeforeFill = true;
            // 
            // tblEdafatWarsaTableAdapter
            // 
            this.tblEdafatWarsaTableAdapter.ClearBeforeFill = true;
            // 
            // fromAccessTableAdapter
            // 
            this.fromAccessTableAdapter.ClearBeforeFill = true;
            // 
            // accsessTableAdapter
            // 
            this.accsessTableAdapter.ClearBeforeFill = true;
            // 
            // ImportFromAccessFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 333);
            this.Controls.Add(this.groupControlOp);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControlInfo);
            this.Name = "ImportFromAccessFrm";
            this.Text = "استيراد";
            this.Load += new System.EventHandler(this.ImportFromWebFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceWarasaExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceWarasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOp)).EndInit();
            this.groupControlOp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdatam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceUpdateNIDWarasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceUpdateNIDMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWebData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceImportAccsess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMashatTablebindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.GroupControl groupControlOp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblCounter;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DataSources.dsdatam dsdatam;
        private DataSources.dsdatamTableAdapters.replyTableAdapter replyTableAdapter;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter tblMashatTableAdapter;
        private DataSources.dsRetirementCenterTableAdapters.TBLMRemarksTableAdapter tblmRemarksTableAdapter;
        private System.Windows.Forms.BindingSource tblMashatTablebindingSource;
        private DevExpress.XtraEditors.CheckEdit ceExtra;
        private DataSources.dsRetirementCenterTableAdapters.TBLEdafatTableAdapter tblEdafatTableAdapter;
        private DevExpress.XtraEditors.CheckEdit ceWarasa;
        private DataSources.dsRetirementCenterTableAdapters.TBLWarasaTableAdapter tblWarasaTableAdapter;
        private DataSources.dsdatamTableAdapters.reply_wTableAdapter reply_wTableAdapter;
        private DevExpress.XtraEditors.CheckEdit ceWarasaExtra;
        private DataSources.dsRetirementCenterTableAdapters.TBLEdafatWarsaTableAdapter tblEdafatWarsaTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit ceUpdateNIDMember;
        private DevExpress.XtraEditors.LabelControl lblWebMemberCounter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DataSources.dsWebDataTableAdapters.tblmemberTableAdapter tblmemberTableAdapter;
        private DataSources.dsWebData dsWebData;
        private DevExpress.XtraEditors.CheckEdit ceUpdateNIDWarasa;
        private DataSources.dsWebDataTableAdapters.tblwarasasonTableAdapter tblwarasasonTableAdapter;
        private DevExpress.XtraEditors.LabelControl lblWebWarasaCounter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnImportAccess;
        private DevExpress.XtraEditors.CheckEdit ceImportAccsess;
        private DevExpress.XtraEditors.LabelControl lblAccessCount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DataSources.dsRetirementCenterTableAdapters.FromAccessTableAdapter fromAccessTableAdapter;
        private DataSources.dsdatamTableAdapters.accsessTableAdapter accsessTableAdapter;
    }
}