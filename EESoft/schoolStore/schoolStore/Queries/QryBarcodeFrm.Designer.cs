namespace schoolStore
{
    partial class QryBarcodeFrm
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
            this.lueItems = new DevExpress.XtraEditors.LookUpEdit();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.gcMain = new DevExpress.XtraEditors.GroupControl();
            this.cbCode128Charset = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbW = new DevExpress.XtraEditors.CheckEdit();
            this.cbAutoModule = new DevExpress.XtraEditors.CheckEdit();
            this.cbShowText = new DevExpress.XtraEditors.CheckEdit();
            this.cbH = new DevExpress.XtraEditors.CheckEdit();
            this.tbW = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbCount = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            this.gcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCode128Charset.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoModule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lueItems
            // 
            this.lueItems.Location = new System.Drawing.Point(80, 33);
            this.lueItems.Name = "lueItems";
            this.lueItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SanfName", "اسم الصنف", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "اسم التصنيف", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.lueItems.Properties.NullText = "";
            this.lueItems.Properties.NullValuePrompt = "اختار صنف";
            this.lueItems.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueItems.Size = new System.Drawing.Size(200, 20);
            this.lueItems.TabIndex = 0;
            this.lueItems.EditValueChanged += new System.EventHandler(this.lueItems_EditValueChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(121, 235);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(103, 23);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "طبع باركود الصنف";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // gcMain
            // 
            this.gcMain.Controls.Add(this.cbCode128Charset);
            this.gcMain.Controls.Add(this.cbW);
            this.gcMain.Controls.Add(this.cbAutoModule);
            this.gcMain.Controls.Add(this.cbShowText);
            this.gcMain.Controls.Add(this.cbH);
            this.gcMain.Controls.Add(this.tbCount);
            this.gcMain.Controls.Add(this.labelControl4);
            this.gcMain.Controls.Add(this.tbW);
            this.gcMain.Controls.Add(this.labelControl2);
            this.gcMain.Controls.Add(this.tbH);
            this.gcMain.Controls.Add(this.labelControl3);
            this.gcMain.Controls.Add(this.labelControl1);
            this.gcMain.Controls.Add(this.lueItems);
            this.gcMain.Controls.Add(this.btnPreview);
            this.gcMain.Location = new System.Drawing.Point(12, 12);
            this.gcMain.Name = "gcMain";
            this.gcMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcMain.Size = new System.Drawing.Size(360, 263);
            this.gcMain.TabIndex = 0;
            // 
            // cbCode128Charset
            // 
            this.cbCode128Charset.Location = new System.Drawing.Point(80, 84);
            this.cbCode128Charset.Name = "cbCode128Charset";
            this.cbCode128Charset.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCode128Charset.Size = new System.Drawing.Size(144, 20);
            this.cbCode128Charset.TabIndex = 2;
            // 
            // cbW
            // 
            this.cbW.Location = new System.Drawing.Point(229, 179);
            this.cbW.Name = "cbW";
            this.cbW.Properties.Caption = "";
            this.cbW.Size = new System.Drawing.Size(43, 19);
            this.cbW.TabIndex = 6;
            this.cbW.CheckedChanged += new System.EventHandler(this.cbW_CheckedChanged);
            // 
            // cbAutoModule
            // 
            this.cbAutoModule.EditValue = true;
            this.cbAutoModule.Location = new System.Drawing.Point(131, 110);
            this.cbAutoModule.Name = "cbAutoModule";
            this.cbAutoModule.Properties.Caption = "تناسب الحجم";
            this.cbAutoModule.Size = new System.Drawing.Size(98, 19);
            this.cbAutoModule.TabIndex = 3;
            this.cbAutoModule.CheckedChanged += new System.EventHandler(this.cbH_CheckedChanged);
            // 
            // cbShowText
            // 
            this.cbShowText.EditValue = true;
            this.cbShowText.Location = new System.Drawing.Point(105, 59);
            this.cbShowText.Name = "cbShowText";
            this.cbShowText.Properties.Caption = "اظهار الرقم اسفل الباركود";
            this.cbShowText.Size = new System.Drawing.Size(151, 19);
            this.cbShowText.TabIndex = 1;
            this.cbShowText.CheckedChanged += new System.EventHandler(this.cbH_CheckedChanged);
            // 
            // cbH
            // 
            this.cbH.Location = new System.Drawing.Point(229, 155);
            this.cbH.Name = "cbH";
            this.cbH.Properties.Caption = "";
            this.cbH.Size = new System.Drawing.Size(43, 19);
            this.cbH.TabIndex = 4;
            this.cbH.CheckedChanged += new System.EventHandler(this.cbH_CheckedChanged);
            // 
            // tbW
            // 
            this.tbW.EditValue = "0";
            this.tbW.Enabled = false;
            this.tbW.Location = new System.Drawing.Point(121, 179);
            this.tbW.Name = "tbW";
            this.tbW.Properties.Mask.EditMask = "n0";
            this.tbW.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbW.Size = new System.Drawing.Size(62, 20);
            this.tbW.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(193, 182);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "العرض";
            // 
            // tbH
            // 
            this.tbH.EditValue = "0";
            this.tbH.Enabled = false;
            this.tbH.Location = new System.Drawing.Point(121, 154);
            this.tbH.Name = "tbH";
            this.tbH.Properties.Mask.EditMask = "n0";
            this.tbH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbH.Size = new System.Drawing.Size(62, 20);
            this.tbH.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(230, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "نوع الاحرف";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(197, 157);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "الطول";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(193, 208);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "عدد النسخ";
            // 
            // tbCount
            // 
            this.tbCount.EditValue = "1";
            this.tbCount.Location = new System.Drawing.Point(121, 205);
            this.tbCount.Name = "tbCount";
            this.tbCount.Properties.Mask.EditMask = "n0";
            this.tbCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbCount.Size = new System.Drawing.Size(62, 20);
            this.tbCount.TabIndex = 8;
            // 
            // QryBarcodeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 287);
            this.Controls.Add(this.gcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "QryBarcodeFrm";
            this.Text = "باركود";
            this.Load += new System.EventHandler(this.QryBarcodeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            this.gcMain.ResumeLayout(false);
            this.gcMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCode128Charset.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoModule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueItems;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.GroupControl gcMain;
        private DevExpress.XtraEditors.TextEdit tbW;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit cbW;
        private DevExpress.XtraEditors.CheckEdit cbH;
        private DevExpress.XtraEditors.CheckEdit cbShowText;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbCode128Charset;
        private DevExpress.XtraEditors.CheckEdit cbAutoModule;
        private DevExpress.XtraEditors.TextEdit tbCount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}