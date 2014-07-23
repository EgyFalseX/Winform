namespace FalseStudio
{
    partial class FSPluginsFRM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLDate = new System.Windows.Forms.Label();
            this.LBLOwner = new System.Windows.Forms.Label();
            this.LBLVersion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStopAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBPlugins = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LBLPlugins = new System.Windows.Forms.Label();
            this.LBLStarted = new System.Windows.Forms.Label();
            this.LBLStoped = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBLDate);
            this.groupBox1.Controls.Add(this.LBLOwner);
            this.groupBox1.Controls.Add(this.LBLVersion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnOptions);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Controls.Add(this.BtnStopAll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBPlugins);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " - Plugins - ";
            // 
            // LBLDate
            // 
            this.LBLDate.AutoSize = true;
            this.LBLDate.Location = new System.Drawing.Point(58, 105);
            this.LBLDate.Name = "LBLDate";
            this.LBLDate.Size = new System.Drawing.Size(51, 13);
            this.LBLDate.TabIndex = 4;
            this.LBLDate.Text = "00/00/00";
            // 
            // LBLOwner
            // 
            this.LBLOwner.AutoSize = true;
            this.LBLOwner.Location = new System.Drawing.Point(58, 81);
            this.LBLOwner.Name = "LBLOwner";
            this.LBLOwner.Size = new System.Drawing.Size(31, 13);
            this.LBLOwner.TabIndex = 4;
            this.LBLOwner.Text = "none";
            // 
            // LBLVersion
            // 
            this.LBLVersion.AutoSize = true;
            this.LBLVersion.Location = new System.Drawing.Point(58, 57);
            this.LBLVersion.Name = "LBLVersion";
            this.LBLVersion.Size = new System.Drawing.Size(29, 13);
            this.LBLVersion.TabIndex = 4;
            this.LBLVersion.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Owner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version:";
            // 
            // BtnOptions
            // 
            this.BtnOptions.Enabled = false;
            this.BtnOptions.Location = new System.Drawing.Point(255, 115);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(75, 23);
            this.BtnOptions.TabIndex = 3;
            this.BtnOptions.Text = "Options";
            this.BtnOptions.UseVisualStyleBackColor = true;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(255, 86);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Location = new System.Drawing.Point(255, 57);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStopAll
            // 
            this.BtnStopAll.Enabled = false;
            this.BtnStopAll.Location = new System.Drawing.Point(255, 19);
            this.BtnStopAll.Name = "BtnStopAll";
            this.BtnStopAll.Size = new System.Drawing.Size(75, 23);
            this.BtnStopAll.TabIndex = 2;
            this.BtnStopAll.Text = "Stop All";
            this.BtnStopAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plugins Name:";
            // 
            // CBPlugins
            // 
            this.CBPlugins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPlugins.FormattingEnabled = true;
            this.CBPlugins.Location = new System.Drawing.Point(86, 19);
            this.CBPlugins.Name = "CBPlugins";
            this.CBPlugins.Size = new System.Drawing.Size(163, 21);
            this.CBPlugins.TabIndex = 0;
            this.CBPlugins.SelectedIndexChanged += new System.EventHandler(this.CBPlugins_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Plugins:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Started:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Stoped:";
            // 
            // LBLPlugins
            // 
            this.LBLPlugins.AutoSize = true;
            this.LBLPlugins.Location = new System.Drawing.Point(70, 178);
            this.LBLPlugins.Name = "LBLPlugins";
            this.LBLPlugins.Size = new System.Drawing.Size(19, 13);
            this.LBLPlugins.TabIndex = 4;
            this.LBLPlugins.Text = "00";
            // 
            // LBLStarted
            // 
            this.LBLStarted.AutoSize = true;
            this.LBLStarted.Location = new System.Drawing.Point(70, 202);
            this.LBLStarted.Name = "LBLStarted";
            this.LBLStarted.Size = new System.Drawing.Size(19, 13);
            this.LBLStarted.TabIndex = 4;
            this.LBLStarted.Text = "00";
            // 
            // LBLStoped
            // 
            this.LBLStoped.AutoSize = true;
            this.LBLStoped.Location = new System.Drawing.Point(70, 226);
            this.LBLStoped.Name = "LBLStoped";
            this.LBLStoped.Size = new System.Drawing.Size(19, 13);
            this.LBLStoped.TabIndex = 4;
            this.LBLStoped.Text = "00";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(267, 216);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FSPluginsFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 251);
            this.Controls.Add(this.LBLStoped);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBLStarted);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBLPlugins);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.Name = "FSPluginsFRM";
            this.Text = "FalseStudio - Plugins";
            this.Load += new System.EventHandler(this.FSPluginsFRM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLDate;
        private System.Windows.Forms.Label LBLOwner;
        private System.Windows.Forms.Label LBLVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOptions;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStopAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBPlugins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LBLPlugins;
        private System.Windows.Forms.Label LBLStarted;
        private System.Windows.Forms.Label LBLStoped;
        private System.Windows.Forms.Button BtnClose;
    }
}