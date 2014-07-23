namespace schoolStore
{
    partial class ImportStudentFrm
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
            this.gcmain = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblcode = new DevExpress.XtraEditors.LabelControl();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbselectdb = new DevExpress.XtraEditors.ButtonEdit();
            this.openFileDialogDB = new System.Windows.Forms.OpenFileDialog();
            this.btnimport = new DevExpress.XtraEditors.SimpleButton();
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcmain)).BeginInit();
            this.gcmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbselectdb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcmain
            // 
            this.gcmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcmain.AppearanceCaption.Options.UseTextOptions = true;
            this.gcmain.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcmain.Controls.Add(this.groupControl2);
            this.gcmain.Controls.Add(this.tbselectdb);
            this.gcmain.Location = new System.Drawing.Point(12, 12);
            this.gcmain.Name = "gcmain";
            this.gcmain.Size = new System.Drawing.Size(349, 118);
            this.gcmain.TabIndex = 0;
            this.gcmain.Text = "قاعدة البيانات الطلاب";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.lblcode);
            this.groupControl2.Controls.Add(this.lblCount);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(5, 50);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(337, 59);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "معلومات قاعدة البيانات";
            // 
            // lblcode
            // 
            this.lblcode.Location = new System.Drawing.Point(34, 31);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(12, 13);
            this.lblcode.TabIndex = 1;
            this.lblcode.Text = "00";
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(205, 31);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(24, 13);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0000";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(79, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "كود العام";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(250, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "عدد الطلاب";
            // 
            // tbselectdb
            // 
            this.tbselectdb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbselectdb.Location = new System.Drawing.Point(5, 24);
            this.tbselectdb.Name = "tbselectdb";
            this.tbselectdb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbselectdb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tbselectdb.Size = new System.Drawing.Size(340, 20);
            this.tbselectdb.TabIndex = 1;
            this.tbselectdb.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.tbselectdb_ButtonClick);
            // 
            // openFileDialogDB
            // 
            this.openFileDialogDB.FileName = "dataschool.mdb";
            this.openFileDialogDB.Title = "اختار قاعدة بيانات الطلاب";
            // 
            // btnimport
            // 
            this.btnimport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnimport.Location = new System.Drawing.Point(107, 160);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(150, 23);
            this.btnimport.TabIndex = 2;
            this.btnimport.Text = "استيراد";
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // pbc
            // 
            this.pbc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbc.Location = new System.Drawing.Point(12, 136);
            this.pbc.Name = "pbc";
            this.pbc.Properties.ShowTitle = true;
            this.pbc.Properties.Step = 1;
            this.pbc.Size = new System.Drawing.Size(349, 18);
            this.pbc.TabIndex = 2;
            // 
            // ImportStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 188);
            this.Controls.Add(this.pbc);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.gcmain);
            this.Name = "ImportStudentFrm";
            this.Text = "استيراد طلاب";
            ((System.ComponentModel.ISupportInitialize)(this.gcmain)).EndInit();
            this.gcmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbselectdb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcmain;
        private DevExpress.XtraEditors.ButtonEdit tbselectdb;
        private System.Windows.Forms.OpenFileDialog openFileDialogDB;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblcode;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnimport;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
    }
}