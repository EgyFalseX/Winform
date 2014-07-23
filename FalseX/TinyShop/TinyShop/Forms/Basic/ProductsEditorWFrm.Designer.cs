namespace TinyShop.Forms.Basic
{
    partial class ProductsEditorWFrm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbSellPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbBuyPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbProductNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSellPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBuyPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.CaptionImage = global::TinyShop.Properties.Resources.Edit;
            this.groupControl1.Controls.Add(this.tbSellPrice);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.tbBuyPrice);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tbProductNumber);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tbProductName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(397, 254);
            this.groupControl1.TabIndex = 0;
            // 
            // tbSellPrice
            // 
            this.tbSellPrice.Location = new System.Drawing.Point(5, 195);
            this.tbSellPrice.Name = "tbSellPrice";
            this.tbSellPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSellPrice.Properties.Appearance.Options.UseFont = true;
            this.tbSellPrice.Properties.DisplayFormat.FormatString = "f2";
            this.tbSellPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbSellPrice.Properties.EditFormat.FormatString = "f2";
            this.tbSellPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbSellPrice.Properties.Mask.EditMask = "f2";
            this.tbSellPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbSellPrice.Size = new System.Drawing.Size(304, 22);
            this.tbSellPrice.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(334, 198);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 17);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "سعر البيع";
            // 
            // tbBuyPrice
            // 
            this.tbBuyPrice.Location = new System.Drawing.Point(5, 155);
            this.tbBuyPrice.Name = "tbBuyPrice";
            this.tbBuyPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbBuyPrice.Properties.Appearance.Options.UseFont = true;
            this.tbBuyPrice.Properties.DisplayFormat.FormatString = "f2";
            this.tbBuyPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbBuyPrice.Properties.EditFormat.FormatString = "f2";
            this.tbBuyPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbBuyPrice.Properties.Mask.EditMask = "f2";
            this.tbBuyPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbBuyPrice.Size = new System.Drawing.Size(304, 22);
            this.tbBuyPrice.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(323, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "سعر الشراء";
            // 
            // tbProductNumber
            // 
            this.tbProductNumber.Location = new System.Drawing.Point(5, 115);
            this.tbProductNumber.Name = "tbProductNumber";
            this.tbProductNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbProductNumber.Properties.Appearance.Options.UseFont = true;
            this.tbProductNumber.Size = new System.Drawing.Size(304, 22);
            this.tbProductNumber.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(329, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "رقم الصنف";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(5, 75);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbProductName.Properties.Appearance.Options.UseFont = true;
            this.tbProductName.Size = new System.Drawing.Size(304, 22);
            this.tbProductName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(323, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم الصنف";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnClose);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Location = new System.Drawing.Point(12, 272);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(397, 54);
            this.groupControl2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::TinyShop.Properties.Resources.Delete;
            this.btnClose.Location = new System.Drawing.Point(5, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::TinyShop.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(242, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductsEditorWFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(421, 338);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ProductsEditorWFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحرير";
            this.Load += new System.EventHandler(this.ProductsEditorWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSellPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBuyPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbBuyPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbProductNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbProductName;
        private DevExpress.XtraEditors.TextEdit tbSellPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}