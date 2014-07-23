namespace Training_Center
{
    partial class DBImportFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBImportFrm));
            this.xTabC = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageImport = new DevExpress.XtraTab.XtraTabPage();
            this.CCBEImport = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.BtnUpdateImport = new DevExpress.XtraEditors.SimpleButton();
            this.PBCImport = new DevExpress.XtraEditors.ProgressBarControl();
            this.xtraTabPageExport = new DevExpress.XtraTab.XtraTabPage();
            this.CCBEExport = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.BtnUpdateExport = new DevExpress.XtraEditors.SimpleButton();
            this.PBCExport = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.xTabC)).BeginInit();
            this.xTabC.SuspendLayout();
            this.xtraTabPageImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCBEImport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCImport.Properties)).BeginInit();
            this.xtraTabPageExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCBEExport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCExport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xTabC
            // 
            this.xTabC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xTabC.Location = new System.Drawing.Point(0, 0);
            this.xTabC.Name = "xTabC";
            this.xTabC.SelectedTabPage = this.xtraTabPageImport;
            this.xTabC.Size = new System.Drawing.Size(539, 267);
            this.xTabC.TabIndex = 0;
            this.xTabC.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageImport,
            this.xtraTabPageExport});
            // 
            // xtraTabPageImport
            // 
            this.xtraTabPageImport.Controls.Add(this.CCBEImport);
            this.xtraTabPageImport.Controls.Add(this.BtnUpdateImport);
            this.xtraTabPageImport.Controls.Add(this.PBCImport);
            this.xtraTabPageImport.Name = "xtraTabPageImport";
            this.xtraTabPageImport.Size = new System.Drawing.Size(533, 241);
            this.xtraTabPageImport.Text = "استيراد";
            // 
            // CCBEImport
            // 
            this.CCBEImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCBEImport.EditValue = "";
            this.CCBEImport.Location = new System.Drawing.Point(166, 111);
            this.CCBEImport.Name = "CCBEImport";
            this.CCBEImport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CCBEImport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("mbImportTBLTrainee", "نقل بيانات المتدربين"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("mbImportTBLWebReservation", "نقل حجز الدورات"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("mbTBLTrainersCoursesOut", "نقل بيانات طلب تسجيل دورة خارجية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("mbTBLTrainersTraineeOUT", "نقل بيانات حجز دورات خارجية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("mbTBLOrderCertificates", "نقل بيانات طلب شهادات لدورات خارجية")});
            this.CCBEImport.Size = new System.Drawing.Size(200, 19);
            this.CCBEImport.TabIndex = 2;
            // 
            // BtnUpdateImport
            // 
            this.BtnUpdateImport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUpdateImport.Location = new System.Drawing.Point(0, 148);
            this.BtnUpdateImport.Name = "BtnUpdateImport";
            this.BtnUpdateImport.Size = new System.Drawing.Size(533, 40);
            this.BtnUpdateImport.TabIndex = 1;
            this.BtnUpdateImport.Text = "تحديث";
            this.BtnUpdateImport.Click += new System.EventHandler(this.BtnUpdateImport_Click);
            // 
            // PBCImport
            // 
            this.PBCImport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBCImport.Location = new System.Drawing.Point(0, 188);
            this.PBCImport.Name = "PBCImport";
            this.PBCImport.Size = new System.Drawing.Size(533, 53);
            this.PBCImport.TabIndex = 0;
            // 
            // xtraTabPageExport
            // 
            this.xtraTabPageExport.Controls.Add(this.CCBEExport);
            this.xtraTabPageExport.Controls.Add(this.BtnUpdateExport);
            this.xtraTabPageExport.Controls.Add(this.PBCExport);
            this.xtraTabPageExport.Name = "xtraTabPageExport";
            this.xtraTabPageExport.Size = new System.Drawing.Size(533, 241);
            this.xtraTabPageExport.Text = "تصدير";
            // 
            // CCBEExport
            // 
            this.CCBEExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCBEExport.EditValue = "";
            this.CCBEExport.Location = new System.Drawing.Point(166, 111);
            this.CCBEExport.Name = "CCBEExport";
            this.CCBEExport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CCBEExport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CdBankAccount", "اكواد حسابات البنك"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLPartners", "بيانات الموردين"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CDCertificates", "اكواد انواع الشهادات"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CDCourseType", "اكواد فئات الدورات"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CDjob", "اكواد الوظائف"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CDknow", "اكواد طرق التعرف على الاكاديمية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CdPlace", "اكواد اماكن التدريب"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CdLab", "اكواد القاعات التدريبية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CDMembershipType", "نوع العضوية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CdNationality", "اكواد الجنسيات"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CDReservationWay", "اكواد طرق الحجز"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CDTrainingBag", "اكواد الحقائب التدريبية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLCourses", "بيانات الدورات التدريبية"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLReservation", "بيانات حجز الدورات"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLCourseCertificates", "بيانات شهادات الدورات"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLTraineeCertificates", "بيانات شهادات المتدربين"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLCourseAgenda", "بيانات اجندة الدورات"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLAttend", "بيانات الحضور"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLTrainers", "بيانات المدربين"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLCourseTrainers", "بيانات مدربي الدورات"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLTrainersBag", "بيانات حقائب المدربين"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TBLMemberShip", "بيانات العضوية")});
            this.CCBEExport.Size = new System.Drawing.Size(200, 19);
            this.CCBEExport.TabIndex = 3;
            // 
            // BtnUpdateExport
            // 
            this.BtnUpdateExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUpdateExport.Location = new System.Drawing.Point(0, 148);
            this.BtnUpdateExport.Name = "BtnUpdateExport";
            this.BtnUpdateExport.Size = new System.Drawing.Size(533, 40);
            this.BtnUpdateExport.TabIndex = 2;
            this.BtnUpdateExport.Text = "تحديث";
            this.BtnUpdateExport.Click += new System.EventHandler(this.BtnUpdateExport_Click);
            // 
            // PBCExport
            // 
            this.PBCExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBCExport.Location = new System.Drawing.Point(0, 188);
            this.PBCExport.Name = "PBCExport";
            this.PBCExport.Size = new System.Drawing.Size(533, 53);
            this.PBCExport.TabIndex = 1;
            // 
            // DBImportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 267);
            this.Controls.Add(this.xTabC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBImportFrm";
            this.Text = "نقل البيانات من الويب";
            ((System.ComponentModel.ISupportInitialize)(this.xTabC)).EndInit();
            this.xTabC.ResumeLayout(false);
            this.xtraTabPageImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CCBEImport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCImport.Properties)).EndInit();
            this.xtraTabPageExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CCBEExport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCExport.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl PBCImport;
        private DevExpress.XtraEditors.ProgressBarControl PBCExport;
        private DevExpress.XtraEditors.SimpleButton BtnUpdateImport;
        private DevExpress.XtraEditors.SimpleButton BtnUpdateExport;
        public DevExpress.XtraTab.XtraTabControl xTabC;
        public DevExpress.XtraTab.XtraTabPage xtraTabPageImport;
        public DevExpress.XtraTab.XtraTabPage xtraTabPageExport;
        private DevExpress.XtraEditors.CheckedComboBoxEdit CCBEImport;
        private DevExpress.XtraEditors.CheckedComboBoxEdit CCBEExport;
    }
}