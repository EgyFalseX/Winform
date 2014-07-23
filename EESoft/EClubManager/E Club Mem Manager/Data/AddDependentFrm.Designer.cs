namespace E_Club_Mem_Manager
{
    partial class AddDependentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDependentFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBRelationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBMembers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBRelatedmembers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LUESelected = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAsdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUESelected.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnAsdd);
            this.groupBox1.Controls.Add(this.LUESelected);
            this.groupBox1.Controls.Add(this.CBRelationType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBRelatedmembers);
            this.groupBox1.Controls.Add(this.CBMembers);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(313, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " -  المرافقــــــون  - ";
            // 
            // CBRelationType
            // 
            this.CBRelationType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBRelationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRelationType.FormattingEnabled = true;
            this.CBRelationType.Location = new System.Drawing.Point(8, 65);
            this.CBRelationType.Name = "CBRelationType";
            this.CBRelationType.Size = new System.Drawing.Size(201, 21);
            this.CBRelationType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسماء الاعضــاء";
            // 
            // CBMembers
            // 
            this.CBMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBMembers.FormattingEnabled = true;
            this.CBMembers.Location = new System.Drawing.Point(8, 38);
            this.CBMembers.Name = "CBMembers";
            this.CBMembers.Size = new System.Drawing.Size(201, 21);
            this.CBMembers.TabIndex = 0;
            this.CBMembers.SelectedIndexChanged += new System.EventHandler(this.CBMembers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نوع القرابه";
            // 
            // CBRelatedmembers
            // 
            this.CBRelatedmembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBRelatedmembers.FormattingEnabled = true;
            this.CBRelatedmembers.Location = new System.Drawing.Point(8, 92);
            this.CBRelatedmembers.Name = "CBRelatedmembers";
            this.CBRelatedmembers.Size = new System.Drawing.Size(201, 21);
            this.CBRelatedmembers.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "اسماء المرافقين";
            // 
            // LUESelected
            // 
            this.LUESelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LUESelected.Location = new System.Drawing.Point(53, 215);
            this.LUESelected.Name = "LUESelected";
            this.LUESelected.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.LUESelected.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("child_name", "اسم المرافق")});
            this.LUESelected.Properties.NullText = "";
            this.LUESelected.Size = new System.Drawing.Size(201, 19);
            this.LUESelected.TabIndex = 6;
            this.LUESelected.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LUESelected_ButtonClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "مرافقون هذا العضو";
            // 
            // BtnAsdd
            // 
            this.BtnAsdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAsdd.Location = new System.Drawing.Point(8, 119);
            this.BtnAsdd.Name = "BtnAsdd";
            this.BtnAsdd.Size = new System.Drawing.Size(201, 23);
            this.BtnAsdd.TabIndex = 7;
            this.BtnAsdd.Text = "اضافه";
            this.BtnAsdd.Click += new System.EventHandler(this.BtnAsdd_Click);
            // 
            // AddDependentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 396);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDependentFrm";
            this.Text = "المرافقــــون";
            this.Load += new System.EventHandler(this.AddDependentFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUESelected.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBMembers;
        private System.Windows.Forms.ComboBox CBRelationType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBRelatedmembers;
        private DevExpress.XtraEditors.LookUpEdit LUESelected;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BtnAsdd;
    }
}