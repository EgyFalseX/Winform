namespace FSPluginnamespace
{
    partial class SroTimerFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SroTimerFRM));
            this.BtnStart = new System.Windows.Forms.Button();
            this.TxtTimerInterval = new System.Windows.Forms.TextBox();
            this.LblCount = new System.Windows.Forms.Label();
            this.TxtSp1 = new System.Windows.Forms.TextBox();
            this.TxtSp2 = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Lime;
            this.BtnStart.Location = new System.Drawing.Point(10, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TxtTimerInterval
            // 
            this.TxtTimerInterval.Location = new System.Drawing.Point(91, 15);
            this.TxtTimerInterval.Name = "TxtTimerInterval";
            this.TxtTimerInterval.Size = new System.Drawing.Size(100, 20);
            this.TxtTimerInterval.TabIndex = 0;
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(197, 18);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(31, 13);
            this.LblCount.TabIndex = 2;
            this.LblCount.Text = "0000";
            // 
            // TxtSp1
            // 
            this.TxtSp1.Location = new System.Drawing.Point(10, 41);
            this.TxtSp1.Name = "TxtSp1";
            this.TxtSp1.Size = new System.Drawing.Size(100, 20);
            this.TxtSp1.TabIndex = 3;
            this.TxtSp1.TextChanged += new System.EventHandler(this.TxtSp_TextChanged);
            // 
            // TxtSp2
            // 
            this.TxtSp2.Location = new System.Drawing.Point(128, 41);
            this.TxtSp2.Name = "TxtSp2";
            this.TxtSp2.Size = new System.Drawing.Size(100, 20);
            this.TxtSp2.TabIndex = 2;
            this.TxtSp2.TextChanged += new System.EventHandler(this.TxtSp_TextChanged);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(104, 69);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(31, 13);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // SroTimerFRM
            // 
            this.AcceptButton = this.BtnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.TxtSp2);
            this.Controls.Add(this.TxtSp1);
            this.Controls.Add(this.TxtTimerInterval);
            this.Controls.Add(this.BtnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(255, 126);
            this.MinimumSize = new System.Drawing.Size(255, 126);
            this.Name = "SroTimerFRM";
            this.Text = "Silkroad Skills Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox TxtTimerInterval;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.TextBox TxtSp1;
        private System.Windows.Forms.TextBox TxtSp2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label label1;
    }
}