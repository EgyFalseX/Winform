namespace DbSyc_Client
{
    partial class OptionsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsFrm));
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DbSyc_Client.Properties.Settings.Default, "IP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbAddress.Location = new System.Drawing.Point(173, 9);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(88, 20);
            this.tbAddress.TabIndex = 5;
            this.tbAddress.Text = global::DbSyc_Client.Properties.Settings.Default.IP;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(47, 9);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(88, 20);
            this.tbPort.TabIndex = 5;
            this.tbPort.Text = "59000";
            // 
            // OptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 67);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionsFrm";
            this.Text = "Server Options";
            this.Load += new System.EventHandler(this.OptionsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPort;
    }
}