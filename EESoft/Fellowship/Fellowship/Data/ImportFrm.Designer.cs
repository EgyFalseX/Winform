namespace Fellowship.Data
{
    partial class ImportFrm
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
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.dsFellowship = new Fellowship.DataSources.DSFellowship();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFellowship)).BeginInit();
            this.SuspendLayout();
            // 
            // pbc
            // 
            this.pbc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbc.Location = new System.Drawing.Point(0, 52);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(598, 18);
            this.pbc.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(476, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(110, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "استيراد من الاكسس";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dsFellowship
            // 
            this.dsFellowship.DataSetName = "DSFellowship";
            this.dsFellowship.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsFellowship.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ImportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 70);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.pbc);
            this.Name = "ImportFrm";
            this.Text = "أستيراد بيانات";
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFellowship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DataSources.DSFellowship dsFellowship;
    }
}