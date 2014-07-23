namespace E_Club_Att_Manager
{
    partial class DemoManagerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoManagerFrm));
            this.BtnShitEditor = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHarakaTypeEditor = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnQryEmpAtt = new DevExpress.XtraEditors.SimpleButton();
            this.BtnQryEmpInfo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnShitEditor
            // 
            this.BtnShitEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShitEditor.Location = new System.Drawing.Point(178, 321);
            this.BtnShitEditor.Name = "BtnShitEditor";
            this.BtnShitEditor.Size = new System.Drawing.Size(120, 23);
            this.BtnShitEditor.TabIndex = 0;
            this.BtnShitEditor.Text = "الفترات";
            this.BtnShitEditor.Click += new System.EventHandler(this.BtnShitEditor_Click);
            // 
            // BtnHarakaTypeEditor
            // 
            this.BtnHarakaTypeEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHarakaTypeEditor.Location = new System.Drawing.Point(178, 345);
            this.BtnHarakaTypeEditor.Name = "BtnHarakaTypeEditor";
            this.BtnHarakaTypeEditor.Size = new System.Drawing.Size(120, 23);
            this.BtnHarakaTypeEditor.TabIndex = 1;
            this.BtnHarakaTypeEditor.Text = "انواع الحركه";
            this.BtnHarakaTypeEditor.Click += new System.EventHandler(this.BtnHarakaTypeEditor_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(422, 321);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "الحضور";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEnd.Location = new System.Drawing.Point(422, 345);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(120, 23);
            this.BtnEnd.TabIndex = 5;
            this.BtnEnd.Text = "Exit";
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnQryEmpAtt
            // 
            this.BtnQryEmpAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQryEmpAtt.Location = new System.Drawing.Point(300, 321);
            this.BtnQryEmpAtt.Name = "BtnQryEmpAtt";
            this.BtnQryEmpAtt.Size = new System.Drawing.Size(120, 23);
            this.BtnQryEmpAtt.TabIndex = 3;
            this.BtnQryEmpAtt.Text = "استعلام الحضور";
            this.BtnQryEmpAtt.Click += new System.EventHandler(this.BtnQryEmpAtt_Click);
            // 
            // BtnQryEmpInfo
            // 
            this.BtnQryEmpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQryEmpInfo.Location = new System.Drawing.Point(300, 345);
            this.BtnQryEmpInfo.Name = "BtnQryEmpInfo";
            this.BtnQryEmpInfo.Size = new System.Drawing.Size(120, 23);
            this.BtnQryEmpInfo.TabIndex = 4;
            this.BtnQryEmpInfo.Text = "استعلام الموظفين";
            this.BtnQryEmpInfo.Click += new System.EventHandler(this.BtnQryEmpInfo_Click);
            // 
            // DemoManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::E_Club_Att_Manager.Properties.Resources.ECAM_BG;
            this.ClientSize = new System.Drawing.Size(552, 403);
            this.ControlBox = false;
            this.Controls.Add(this.BtnQryEmpInfo);
            this.Controls.Add(this.BtnQryEmpAtt);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnHarakaTypeEditor);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnShitEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DemoManagerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدير الحضور و الانصراف";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnShitEditor;
        private DevExpress.XtraEditors.SimpleButton BtnHarakaTypeEditor;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton BtnEnd;
        private DevExpress.XtraEditors.SimpleButton BtnQryEmpAtt;
        private DevExpress.XtraEditors.SimpleButton BtnQryEmpInfo;
    }
}