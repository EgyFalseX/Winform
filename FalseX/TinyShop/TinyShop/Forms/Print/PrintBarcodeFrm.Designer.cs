namespace TinyShop.Forms.Print
{
    partial class PrintBarcodeFrm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dsTinyData = new TinyShop.DataSources.dsTinyData();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TinyShop.DataSources.dsTinyDataTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(213, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الاصناف";
            // 
            // LUEItems
            // 
            this.LUEItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LUEItems.Location = new System.Drawing.Point(57, 27);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LUEItems.Properties.Appearance.Options.UseFont = true;
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "اسم", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductNumber", "رقم", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.LUEItems.Properties.DataSource = this.productsBindingSource;
            this.LUEItems.Properties.DisplayMember = "ProductName";
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEItems.Properties.ValueMember = "ProductID";
            this.LUEItems.Size = new System.Drawing.Size(150, 26);
            this.LUEItems.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.Image = global::TinyShop.Properties.Resources.Print48;
            this.btnPrint.Location = new System.Drawing.Point(57, 59);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 47);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dsTinyData
            // 
            this.dsTinyData.DataSetName = "dsTinyData";
            this.dsTinyData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dsTinyData;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // PrintBarcodeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 118);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.LUEItems);
            this.Controls.Add(this.labelControl1);
            this.Name = "PrintBarcodeFrm";
            this.Text = "طباعة الباركود";
            this.Load += new System.EventHandler(this.PrintBarcodeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DataSources.dsTinyData dsTinyData;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DataSources.dsTinyDataTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}