namespace schoolStore
{
    partial class EditorYearFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorYearFrm));
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.LUEYear = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.DEEnd = new DevExpress.XtraEditors.DateEdit();
            this.DEStart = new DevExpress.XtraEditors.DateEdit();
            this.TxtNewYear = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(396, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 197);
            this.BtnRefresh.TabIndex = 6;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.LUEYear);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(8, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(382, 59);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "جميع السنوات المضافه";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnDelete.Location = new System.Drawing.Point(6, 26);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(44, 22);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LUEYear
            // 
            this.LUEYear.Location = new System.Drawing.Point(55, 28);
            this.LUEYear.Name = "LUEYear";
            this.LUEYear.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.LUEYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEYear.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YearID", "YearID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YearName", "اسم السنه"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YStartDate", "تاريخ البدايه", 20, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YEndDate", "تاريخ النهايه", 20, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Default)});
            this.LUEYear.Properties.NullText = "";
            this.LUEYear.Properties.NullValuePrompt = "اختـــار";
            this.LUEYear.Size = new System.Drawing.Size(173, 19);
            this.LUEYear.TabIndex = 0;
            this.LUEYear.EditValueChanged += new System.EventHandler(this.LUEYear_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(243, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جميع السنوات";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnAdd);
            this.groupControl2.Controls.Add(this.DEEnd);
            this.groupControl2.Controls.Add(this.DEStart);
            this.groupControl2.Controls.Add(this.TxtNewYear);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(8, 77);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(382, 132);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "اضافة سنه جديده";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(55, 99);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(173, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "اضـــــــــــافــه";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DEEnd
            // 
            this.DEEnd.EditValue = null;
            this.DEEnd.Location = new System.Drawing.Point(55, 74);
            this.DEEnd.Name = "DEEnd";
            this.DEEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEEnd.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.DEEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEEnd.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.DEEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEEnd.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.DEEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DEEnd.Size = new System.Drawing.Size(173, 19);
            this.DEEnd.TabIndex = 4;
            // 
            // DEStart
            // 
            this.DEStart.EditValue = null;
            this.DEStart.Location = new System.Drawing.Point(55, 49);
            this.DEStart.Name = "DEStart";
            this.DEStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.DEStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEStart.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.DEStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DEStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.DEStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DEStart.Size = new System.Drawing.Size(173, 19);
            this.DEStart.TabIndex = 3;
            // 
            // TxtNewYear
            // 
            this.TxtNewYear.Location = new System.Drawing.Point(55, 24);
            this.TxtNewYear.Name = "TxtNewYear";
            this.TxtNewYear.Properties.MaxLength = 30;
            this.TxtNewYear.Size = new System.Drawing.Size(173, 19);
            this.TxtNewYear.TabIndex = 2;
            this.TxtNewYear.EditValueChanged += new System.EventHandler(this.TxtNewYear_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(248, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "تاريخ النهاية";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(246, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تاريخ البداية";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(244, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "السنة المالية";
            // 
            // EditorYearFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 215);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorYearFrm";
            this.Text = "اكواد السنوات";
            this.Load += new System.EventHandler(this.EditorYearFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.LookUpEdit LUEYear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.DateEdit DEEnd;
        private DevExpress.XtraEditors.DateEdit DEStart;
        private DevExpress.XtraEditors.TextEdit TxtNewYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}