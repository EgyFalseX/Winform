namespace DataCenter_Client
{
    partial class StuObjectPropertyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuObjectPropertyFrm));
            this.TC = new System.Windows.Forms.TabControl();
            this.TPageStuAddFile = new System.Windows.Forms.TabPage();
            this.PBAddFile = new System.Windows.Forms.ProgressBar();
            this.LblAddStu = new System.Windows.Forms.TextBox();
            this.LblAddFasl = new System.Windows.Forms.TextBox();
            this.LblAddSaf = new System.Windows.Forms.TextBox();
            this.LblAddYear = new System.Windows.Forms.TextBox();
            this.TxtAddFileName = new System.Windows.Forms.TextBox();
            this.CBAddFileType = new System.Windows.Forms.ComboBox();
            this.BtnAddBrowse = new System.Windows.Forms.Button();
            this.LblAddUser = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAddSave = new System.Windows.Forms.Button();
            this.LblAddFileDate = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.TxtAddDesc = new System.Windows.Forms.TextBox();
            this.TPageEmpAddFile = new System.Windows.Forms.TabPage();
            this.PBEmpAddFile = new System.Windows.Forms.ProgressBar();
            this.TxtEmpAddFileName = new System.Windows.Forms.TextBox();
            this.CBEmpAddFileType = new System.Windows.Forms.ComboBox();
            this.BtnEmpAddBrowse = new System.Windows.Forms.Button();
            this.LblEmpAddUser = new System.Windows.Forms.Label();
            this.BtnEmpUpdate = new System.Windows.Forms.Button();
            this.BtnEmpAddSave = new System.Windows.Forms.Button();
            this.LblEmpAddFileDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtEmpAddDesc = new System.Windows.Forms.TextBox();
            this.LblEmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TC.SuspendLayout();
            this.TPageStuAddFile.SuspendLayout();
            this.TPageEmpAddFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC
            // 
            this.TC.Controls.Add(this.TPageStuAddFile);
            this.TC.Controls.Add(this.TPageEmpAddFile);
            this.TC.Location = new System.Drawing.Point(5, 6);
            this.TC.Name = "TC";
            this.TC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(327, 311);
            this.TC.TabIndex = 0;
            // 
            // TPageStuAddFile
            // 
            this.TPageStuAddFile.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
            this.TPageStuAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TPageStuAddFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TPageStuAddFile.Controls.Add(this.PBAddFile);
            this.TPageStuAddFile.Controls.Add(this.LblAddStu);
            this.TPageStuAddFile.Controls.Add(this.LblAddFasl);
            this.TPageStuAddFile.Controls.Add(this.LblAddSaf);
            this.TPageStuAddFile.Controls.Add(this.LblAddYear);
            this.TPageStuAddFile.Controls.Add(this.TxtAddFileName);
            this.TPageStuAddFile.Controls.Add(this.CBAddFileType);
            this.TPageStuAddFile.Controls.Add(this.BtnAddBrowse);
            this.TPageStuAddFile.Controls.Add(this.LblAddUser);
            this.TPageStuAddFile.Controls.Add(this.BtnUpdate);
            this.TPageStuAddFile.Controls.Add(this.BtnAddSave);
            this.TPageStuAddFile.Controls.Add(this.LblAddFileDate);
            this.TPageStuAddFile.Controls.Add(this.Label26);
            this.TPageStuAddFile.Controls.Add(this.Label13);
            this.TPageStuAddFile.Controls.Add(this.Label12);
            this.TPageStuAddFile.Controls.Add(this.Label21);
            this.TPageStuAddFile.Controls.Add(this.label4);
            this.TPageStuAddFile.Controls.Add(this.Label22);
            this.TPageStuAddFile.Controls.Add(this.label3);
            this.TPageStuAddFile.Controls.Add(this.label2);
            this.TPageStuAddFile.Controls.Add(this.label1);
            this.TPageStuAddFile.Controls.Add(this.Label24);
            this.TPageStuAddFile.Controls.Add(this.TxtAddDesc);
            this.TPageStuAddFile.Location = new System.Drawing.Point(4, 22);
            this.TPageStuAddFile.Name = "TPageStuAddFile";
            this.TPageStuAddFile.Padding = new System.Windows.Forms.Padding(3);
            this.TPageStuAddFile.Size = new System.Drawing.Size(319, 285);
            this.TPageStuAddFile.TabIndex = 0;
            this.TPageStuAddFile.Text = "ملف جديد";
            this.TPageStuAddFile.UseVisualStyleBackColor = true;
            // 
            // PBAddFile
            // 
            this.PBAddFile.Location = new System.Drawing.Point(4, 257);
            this.PBAddFile.Name = "PBAddFile";
            this.PBAddFile.Size = new System.Drawing.Size(128, 18);
            this.PBAddFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBAddFile.TabIndex = 48;
            this.PBAddFile.Visible = false;
            // 
            // LblAddStu
            // 
            this.LblAddStu.Location = new System.Drawing.Point(21, 28);
            this.LblAddStu.MaxLength = 20;
            this.LblAddStu.Name = "LblAddStu";
            this.LblAddStu.ReadOnly = true;
            this.LblAddStu.Size = new System.Drawing.Size(100, 20);
            this.LblAddStu.TabIndex = 33;
            // 
            // LblAddFasl
            // 
            this.LblAddFasl.Location = new System.Drawing.Point(21, 3);
            this.LblAddFasl.MaxLength = 20;
            this.LblAddFasl.Name = "LblAddFasl";
            this.LblAddFasl.ReadOnly = true;
            this.LblAddFasl.Size = new System.Drawing.Size(100, 20);
            this.LblAddFasl.TabIndex = 33;
            // 
            // LblAddSaf
            // 
            this.LblAddSaf.Location = new System.Drawing.Point(169, 28);
            this.LblAddSaf.MaxLength = 20;
            this.LblAddSaf.Name = "LblAddSaf";
            this.LblAddSaf.ReadOnly = true;
            this.LblAddSaf.Size = new System.Drawing.Size(100, 20);
            this.LblAddSaf.TabIndex = 33;
            // 
            // LblAddYear
            // 
            this.LblAddYear.Location = new System.Drawing.Point(169, 3);
            this.LblAddYear.MaxLength = 20;
            this.LblAddYear.Name = "LblAddYear";
            this.LblAddYear.ReadOnly = true;
            this.LblAddYear.Size = new System.Drawing.Size(100, 20);
            this.LblAddYear.TabIndex = 33;
            // 
            // TxtAddFileName
            // 
            this.TxtAddFileName.Location = new System.Drawing.Point(83, 65);
            this.TxtAddFileName.MaxLength = 20;
            this.TxtAddFileName.Name = "TxtAddFileName";
            this.TxtAddFileName.Size = new System.Drawing.Size(150, 20);
            this.TxtAddFileName.TabIndex = 33;
            // 
            // CBAddFileType
            // 
            this.CBAddFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAddFileType.FormattingEnabled = true;
            this.CBAddFileType.Location = new System.Drawing.Point(83, 140);
            this.CBAddFileType.Name = "CBAddFileType";
            this.CBAddFileType.Size = new System.Drawing.Size(150, 21);
            this.CBAddFileType.TabIndex = 35;
            // 
            // BtnAddBrowse
            // 
            this.BtnAddBrowse.Location = new System.Drawing.Point(21, 63);
            this.BtnAddBrowse.Name = "BtnAddBrowse";
            this.BtnAddBrowse.Size = new System.Drawing.Size(56, 23);
            this.BtnAddBrowse.TabIndex = 34;
            this.BtnAddBrowse.Text = "...";
            this.BtnAddBrowse.UseVisualStyleBackColor = true;
            this.BtnAddBrowse.Click += new System.EventHandler(this.BtnAddBrowse_Click);
            // 
            // LblAddUser
            // 
            this.LblAddUser.AutoSize = true;
            this.LblAddUser.Location = new System.Drawing.Point(165, 114);
            this.LblAddUser.Name = "LblAddUser";
            this.LblAddUser.Size = new System.Drawing.Size(71, 13);
            this.LblAddUser.TabIndex = 41;
            this.LblAddUser.Text = "Administrator";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(214, 257);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(99, 23);
            this.BtnUpdate.TabIndex = 37;
            this.BtnUpdate.Text = "تعديل";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAddSave
            // 
            this.BtnAddSave.Location = new System.Drawing.Point(214, 231);
            this.BtnAddSave.Name = "BtnAddSave";
            this.BtnAddSave.Size = new System.Drawing.Size(99, 23);
            this.BtnAddSave.TabIndex = 37;
            this.BtnAddSave.Text = "حفـــــظ";
            this.BtnAddSave.UseVisualStyleBackColor = true;
            this.BtnAddSave.Click += new System.EventHandler(this.BtnAddSave_Click);
            // 
            // LblAddFileDate
            // 
            this.LblAddFileDate.AutoSize = true;
            this.LblAddFileDate.Location = new System.Drawing.Point(179, 88);
            this.LblAddFileDate.Name = "LblAddFileDate";
            this.LblAddFileDate.Size = new System.Drawing.Size(51, 13);
            this.LblAddFileDate.TabIndex = 43;
            this.LblAddFileDate.Text = "1/1/2000";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(256, 140);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(52, 13);
            this.Label26.TabIndex = 44;
            this.Label26.Text = "نوع الملف";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(269, 167);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(37, 13);
            this.Label13.TabIndex = 45;
            this.Label13.Text = "الوصف";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.Color.Red;
            this.Label12.Location = new System.Drawing.Point(4, 241);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(140, 13);
            this.Label12.TabIndex = 46;
            this.Label12.Text = "حجم الملف اضعر من 50 ميجا";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(238, 114);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(81, 13);
            this.Label21.TabIndex = 47;
            this.Label21.Text = "اسم المستخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "الطالب";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(268, 88);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(35, 13);
            this.Label22.TabIndex = 39;
            this.Label22.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "الفصل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "الصف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "العام";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(256, 68);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(59, 13);
            this.Label24.TabIndex = 40;
            this.Label24.Text = "اسم الملف";
            // 
            // TxtAddDesc
            // 
            this.TxtAddDesc.Location = new System.Drawing.Point(30, 167);
            this.TxtAddDesc.MaxLength = 50;
            this.TxtAddDesc.Multiline = true;
            this.TxtAddDesc.Name = "TxtAddDesc";
            this.TxtAddDesc.Size = new System.Drawing.Size(227, 60);
            this.TxtAddDesc.TabIndex = 36;
            // 
            // TPageEmpAddFile
            // 
            this.TPageEmpAddFile.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
            this.TPageEmpAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TPageEmpAddFile.Controls.Add(this.PBEmpAddFile);
            this.TPageEmpAddFile.Controls.Add(this.TxtEmpAddFileName);
            this.TPageEmpAddFile.Controls.Add(this.CBEmpAddFileType);
            this.TPageEmpAddFile.Controls.Add(this.BtnEmpAddBrowse);
            this.TPageEmpAddFile.Controls.Add(this.LblEmpAddUser);
            this.TPageEmpAddFile.Controls.Add(this.BtnEmpUpdate);
            this.TPageEmpAddFile.Controls.Add(this.BtnEmpAddSave);
            this.TPageEmpAddFile.Controls.Add(this.LblEmpAddFileDate);
            this.TPageEmpAddFile.Controls.Add(this.label8);
            this.TPageEmpAddFile.Controls.Add(this.label9);
            this.TPageEmpAddFile.Controls.Add(this.label10);
            this.TPageEmpAddFile.Controls.Add(this.label11);
            this.TPageEmpAddFile.Controls.Add(this.label14);
            this.TPageEmpAddFile.Controls.Add(this.label15);
            this.TPageEmpAddFile.Controls.Add(this.TxtEmpAddDesc);
            this.TPageEmpAddFile.Controls.Add(this.LblEmpName);
            this.TPageEmpAddFile.Controls.Add(this.label5);
            this.TPageEmpAddFile.Location = new System.Drawing.Point(4, 22);
            this.TPageEmpAddFile.Name = "TPageEmpAddFile";
            this.TPageEmpAddFile.Padding = new System.Windows.Forms.Padding(3);
            this.TPageEmpAddFile.Size = new System.Drawing.Size(319, 285);
            this.TPageEmpAddFile.TabIndex = 1;
            this.TPageEmpAddFile.Text = "ملف جديد";
            this.TPageEmpAddFile.UseVisualStyleBackColor = true;
            // 
            // PBEmpAddFile
            // 
            this.PBEmpAddFile.Location = new System.Drawing.Point(5, 256);
            this.PBEmpAddFile.Name = "PBEmpAddFile";
            this.PBEmpAddFile.Size = new System.Drawing.Size(128, 18);
            this.PBEmpAddFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBEmpAddFile.TabIndex = 80;
            this.PBEmpAddFile.Visible = false;
            // 
            // TxtEmpAddFileName
            // 
            this.TxtEmpAddFileName.Location = new System.Drawing.Point(81, 55);
            this.TxtEmpAddFileName.MaxLength = 20;
            this.TxtEmpAddFileName.Name = "TxtEmpAddFileName";
            this.TxtEmpAddFileName.Size = new System.Drawing.Size(150, 20);
            this.TxtEmpAddFileName.TabIndex = 66;
            // 
            // CBEmpAddFileType
            // 
            this.CBEmpAddFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEmpAddFileType.FormattingEnabled = true;
            this.CBEmpAddFileType.Location = new System.Drawing.Point(81, 132);
            this.CBEmpAddFileType.Name = "CBEmpAddFileType";
            this.CBEmpAddFileType.Size = new System.Drawing.Size(150, 21);
            this.CBEmpAddFileType.TabIndex = 68;
            // 
            // BtnEmpAddBrowse
            // 
            this.BtnEmpAddBrowse.Location = new System.Drawing.Point(19, 55);
            this.BtnEmpAddBrowse.Name = "BtnEmpAddBrowse";
            this.BtnEmpAddBrowse.Size = new System.Drawing.Size(56, 23);
            this.BtnEmpAddBrowse.TabIndex = 67;
            this.BtnEmpAddBrowse.Text = "...";
            this.BtnEmpAddBrowse.UseVisualStyleBackColor = true;
            this.BtnEmpAddBrowse.Click += new System.EventHandler(this.BtnEmpAddBrowse_Click);
            // 
            // LblEmpAddUser
            // 
            this.LblEmpAddUser.AutoSize = true;
            this.LblEmpAddUser.Location = new System.Drawing.Point(163, 106);
            this.LblEmpAddUser.Name = "LblEmpAddUser";
            this.LblEmpAddUser.Size = new System.Drawing.Size(71, 13);
            this.LblEmpAddUser.TabIndex = 74;
            this.LblEmpAddUser.Text = "Administrator";
            // 
            // BtnEmpUpdate
            // 
            this.BtnEmpUpdate.Enabled = false;
            this.BtnEmpUpdate.Location = new System.Drawing.Point(214, 256);
            this.BtnEmpUpdate.Name = "BtnEmpUpdate";
            this.BtnEmpUpdate.Size = new System.Drawing.Size(99, 23);
            this.BtnEmpUpdate.TabIndex = 70;
            this.BtnEmpUpdate.Text = "تعديل";
            this.BtnEmpUpdate.UseVisualStyleBackColor = true;
            this.BtnEmpUpdate.Click += new System.EventHandler(this.BtnEmpUpdate_Click);
            // 
            // BtnEmpAddSave
            // 
            this.BtnEmpAddSave.Location = new System.Drawing.Point(214, 230);
            this.BtnEmpAddSave.Name = "BtnEmpAddSave";
            this.BtnEmpAddSave.Size = new System.Drawing.Size(99, 23);
            this.BtnEmpAddSave.TabIndex = 71;
            this.BtnEmpAddSave.Text = "حفـــــظ";
            this.BtnEmpAddSave.UseVisualStyleBackColor = true;
            this.BtnEmpAddSave.Click += new System.EventHandler(this.BtnEmpAddSave_Click);
            // 
            // LblEmpAddFileDate
            // 
            this.LblEmpAddFileDate.AutoSize = true;
            this.LblEmpAddFileDate.Location = new System.Drawing.Point(177, 80);
            this.LblEmpAddFileDate.Name = "LblEmpAddFileDate";
            this.LblEmpAddFileDate.Size = new System.Drawing.Size(51, 13);
            this.LblEmpAddFileDate.TabIndex = 75;
            this.LblEmpAddFileDate.Text = "1/1/2000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "نوع الملف";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "الوصف";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(4, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "حجم الملف اضعر من 50 ميجا";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "اسم المستخدم";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(271, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "التاريخ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 73;
            this.label15.Text = "اسم الملف";
            // 
            // TxtEmpAddDesc
            // 
            this.TxtEmpAddDesc.Location = new System.Drawing.Point(28, 159);
            this.TxtEmpAddDesc.MaxLength = 50;
            this.TxtEmpAddDesc.Multiline = true;
            this.TxtEmpAddDesc.Name = "TxtEmpAddDesc";
            this.TxtEmpAddDesc.Size = new System.Drawing.Size(227, 60);
            this.TxtEmpAddDesc.TabIndex = 69;
            // 
            // LblEmpName
            // 
            this.LblEmpName.Location = new System.Drawing.Point(58, 12);
            this.LblEmpName.MaxLength = 20;
            this.LblEmpName.Name = "LblEmpName";
            this.LblEmpName.ReadOnly = true;
            this.LblEmpName.Size = new System.Drawing.Size(159, 20);
            this.LblEmpName.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "العامل";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(225, 323);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(99, 23);
            this.BtnCancel.TabIndex = 1000;
            this.BtnCancel.Text = "اغلاق";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // StuObjectPropertyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My.Resources.Resources.ObjectPropertyFrm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 351);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StuObjectPropertyFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الخصائص";
            this.TC.ResumeLayout(false);
            this.TPageStuAddFile.ResumeLayout(false);
            this.TPageStuAddFile.PerformLayout();
            this.TPageEmpAddFile.ResumeLayout(false);
            this.TPageEmpAddFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.ProgressBar PBAddFile;
        internal System.Windows.Forms.Button BtnAddBrowse;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LblAddUser;
        public System.Windows.Forms.Label LblAddFileDate;
        public System.Windows.Forms.TextBox LblAddStu;
        public System.Windows.Forms.TextBox LblAddFasl;
        public System.Windows.Forms.TextBox LblAddSaf;
        public System.Windows.Forms.TextBox LblAddYear;
        public System.Windows.Forms.TabControl TC;
        public System.Windows.Forms.TabPage TPageStuAddFile;
        public System.Windows.Forms.Button BtnAddSave;
        public System.Windows.Forms.Button BtnUpdate;
        public System.Windows.Forms.TextBox TxtAddFileName;
        public System.Windows.Forms.TextBox TxtAddDesc;
        public System.Windows.Forms.ComboBox CBAddFileType;
        internal System.Windows.Forms.ProgressBar PBEmpAddFile;
        public System.Windows.Forms.TextBox TxtEmpAddFileName;
        public System.Windows.Forms.ComboBox CBEmpAddFileType;
        internal System.Windows.Forms.Button BtnEmpAddBrowse;
        public System.Windows.Forms.Label LblEmpAddUser;
        public System.Windows.Forms.Button BtnEmpUpdate;
        public System.Windows.Forms.Button BtnEmpAddSave;
        public System.Windows.Forms.Label LblEmpAddFileDate;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox TxtEmpAddDesc;
        public System.Windows.Forms.TextBox LblEmpName;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.TabPage TPageEmpAddFile;
    }
}