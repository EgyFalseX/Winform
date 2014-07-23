namespace ExcelToolVLookUp
{
    partial class FormMain
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.tbFieldFor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblFor = new System.Windows.Forms.Label();
            this.btnFor = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.tbFieldIn = new System.Windows.Forms.TextBox();
            this.LblIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.tbFieldFor);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.LblFor);
            this.gb1.Controls.Add(this.btnFor);
            this.gb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb1.Location = new System.Drawing.Point(0, 0);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(524, 58);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Search For";
            // 
            // tbFieldFor
            // 
            this.tbFieldFor.Location = new System.Drawing.Point(412, 27);
            this.tbFieldFor.Name = "tbFieldFor";
            this.tbFieldFor.Size = new System.Drawing.Size(100, 20);
            this.tbFieldFor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Field Name";
            // 
            // LblFor
            // 
            this.LblFor.AutoSize = true;
            this.LblFor.Location = new System.Drawing.Point(63, 27);
            this.LblFor.Name = "LblFor";
            this.LblFor.Size = new System.Drawing.Size(22, 13);
            this.LblFor.TabIndex = 2;
            this.LblFor.Text = "C:\\";
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(12, 22);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(45, 23);
            this.btnFor.TabIndex = 0;
            this.btnFor.Text = "...";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.tbFieldIn);
            this.gb2.Controls.Add(this.LblIn);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Controls.Add(this.btnIn);
            this.gb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb2.Location = new System.Drawing.Point(0, 58);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(524, 58);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "Search In";
            // 
            // tbFieldIn
            // 
            this.tbFieldIn.Location = new System.Drawing.Point(412, 34);
            this.tbFieldIn.Name = "tbFieldIn";
            this.tbFieldIn.Size = new System.Drawing.Size(100, 20);
            this.tbFieldIn.TabIndex = 1;
            // 
            // LblIn
            // 
            this.LblIn.AutoSize = true;
            this.LblIn.Location = new System.Drawing.Point(63, 24);
            this.LblIn.Name = "LblIn";
            this.LblIn.Size = new System.Drawing.Size(22, 13);
            this.LblIn.TabIndex = 2;
            this.LblIn.Text = "C:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field Name";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(12, 19);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(45, 23);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "...";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbResult.Location = new System.Drawing.Point(0, 116);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(200, 145);
            this.tbResult.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(349, 200);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 49);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Location = new System.Drawing.Point(206, 226);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(45, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(206, 122);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(306, 23);
            this.pb.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "FormMain";
            this.Text = "Excel Tool - V Look Up";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label LblFor;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Label LblIn;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.TextBox tbFieldFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFieldIn;
        private System.Windows.Forms.Label label2;
    }
}

