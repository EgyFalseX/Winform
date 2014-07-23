namespace ATCommands
{
    partial class GroupSelectorFrm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(183, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختر مجموعه";
            // 
            // lueGroup
            // 
            this.lueGroup.Location = new System.Drawing.Point(27, 41);
            this.lueGroup.Name = "lueGroup";
            this.lueGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupName", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.lueGroup.Properties.NullText = "";
            this.lueGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueGroup.Size = new System.Drawing.Size(150, 20);
            this.lueGroup.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(86, 92);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "موافق";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // GroupSelectorFrm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 127);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lueGroup);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GroupSelectorFrm";
            this.Text = "GroupSelectorFrm";
            this.Load += new System.EventHandler(this.GroupSelectorFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueGroup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueGroup;
        private DevExpress.XtraEditors.SimpleButton btnOk;

    }
}