namespace Members.Forms.Data
{
    partial class ImportFromWebFrm
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
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblMemberCounter = new DevExpress.XtraEditors.LabelControl();
            this.lblagazatCounter = new DevExpress.XtraEditors.LabelControl();
            this.lblHafzaCounter = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlOp = new DevExpress.XtraEditors.GroupControl();
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.dsMemberCard = new Members.DataSources.dsMemberCard();
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.tblMemberWebTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter();
            this.hafzaTableAdapter = new Members.DataSources.dsMemberCardTableAdapters.hafzaTableAdapter();
            this.tblAllMemberTableAdapter = new Members.DataSources.dsMemberCardTableAdapters.TBLAllMemberTableAdapter();
            this.tblHafzawebTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLHafzawebTableAdapter();
            this.memberagazatTableAdapter = new Members.DataSources.dsMemberCardTableAdapters.memberagazatTableAdapter();
            this.tbLmemberagazatWebTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.TBLmemberagazatWebTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOp)).BeginInit();
            this.groupControlOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMemberCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlInfo.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlInfo.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControlInfo.Controls.Add(this.lblMemberCounter);
            this.groupControlInfo.Controls.Add(this.lblagazatCounter);
            this.groupControlInfo.Controls.Add(this.lblHafzaCounter);
            this.groupControlInfo.Controls.Add(this.labelControl3);
            this.groupControlInfo.Controls.Add(this.labelControl2);
            this.groupControlInfo.Controls.Add(this.labelControl1);
            this.groupControlInfo.Location = new System.Drawing.Point(12, 12);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(660, 100);
            this.groupControlInfo.TabIndex = 0;
            this.groupControlInfo.Text = "معلومات";
            // 
            // lblMemberCounter
            // 
            this.lblMemberCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberCounter.Location = new System.Drawing.Point(545, 66);
            this.lblMemberCounter.Name = "lblMemberCounter";
            this.lblMemberCounter.Size = new System.Drawing.Size(6, 13);
            this.lblMemberCounter.TabIndex = 0;
            this.lblMemberCounter.Text = "0";
            // 
            // lblagazatCounter
            // 
            this.lblagazatCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblagazatCounter.Location = new System.Drawing.Point(383, 38);
            this.lblagazatCounter.Name = "lblagazatCounter";
            this.lblagazatCounter.Size = new System.Drawing.Size(6, 13);
            this.lblagazatCounter.TabIndex = 0;
            this.lblagazatCounter.Text = "0";
            // 
            // lblHafzaCounter
            // 
            this.lblHafzaCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHafzaCounter.Location = new System.Drawing.Point(545, 38);
            this.lblHafzaCounter.Name = "lblHafzaCounter";
            this.lblHafzaCounter.Size = new System.Drawing.Size(6, 13);
            this.lblHafzaCounter.TabIndex = 0;
            this.lblHafzaCounter.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(623, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "اعضاء";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(452, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "الاجازات";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(614, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الحافظة";
            // 
            // groupControlOp
            // 
            this.groupControlOp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlOp.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlOp.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControlOp.Controls.Add(this.pbc);
            this.groupControlOp.Controls.Add(this.btnImport);
            this.groupControlOp.Location = new System.Drawing.Point(12, 118);
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
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(551, 40);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "استيراد";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dsMemberCard
            // 
            this.dsMemberCard.DataSetName = "dsMemberCard";
            this.dsMemberCard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMemberWebTableAdapter
            // 
            this.tblMemberWebTableAdapter.ClearBeforeFill = true;
            // 
            // hafzaTableAdapter
            // 
            this.hafzaTableAdapter.ClearBeforeFill = true;
            // 
            // tblAllMemberTableAdapter
            // 
            this.tblAllMemberTableAdapter.ClearBeforeFill = true;
            // 
            // tblHafzawebTableAdapter
            // 
            this.tblHafzawebTableAdapter.ClearBeforeFill = true;
            // 
            // memberagazatTableAdapter
            // 
            this.memberagazatTableAdapter.ClearBeforeFill = true;
            // 
            // tbLmemberagazatWebTableAdapter
            // 
            this.tbLmemberagazatWebTableAdapter.ClearBeforeFill = true;
            // 
            // ImportFromWebFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 232);
            this.Controls.Add(this.groupControlOp);
            this.Controls.Add(this.groupControlInfo);
            this.Name = "ImportFromWebFrm";
            this.Text = "استيراد من الويب";
            this.Load += new System.EventHandler(this.ImportFromWebFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOp)).EndInit();
            this.groupControlOp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMemberCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.GroupControl groupControlOp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblMemberCounter;
        private DevExpress.XtraEditors.LabelControl lblHafzaCounter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DataSources.dsMemberCard dsMemberCard;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter tblMemberWebTableAdapter;
        private DataSources.dsMemberCardTableAdapters.hafzaTableAdapter hafzaTableAdapter;
        private DataSources.dsMemberCardTableAdapters.TBLAllMemberTableAdapter tblAllMemberTableAdapter;
        private DataSources.dsTeachersUnionTableAdapters.TBLHafzawebTableAdapter tblHafzawebTableAdapter;
        private DevExpress.XtraEditors.LabelControl lblagazatCounter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DataSources.dsMemberCardTableAdapters.memberagazatTableAdapter memberagazatTableAdapter;
        private DataSources.dsTeachersUnionTableAdapters.TBLmemberagazatWebTableAdapter tbLmemberagazatWebTableAdapter;
    }
}