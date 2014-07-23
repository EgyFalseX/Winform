namespace BookStore
{
    partial class BillResitFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblCompany = new System.Windows.Forms.TextBox();
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblPayed = new System.Windows.Forms.Label();
            this.LblStoreTrIDTYPE = new System.Windows.Forms.Label();
            this.LblPERSONID = new System.Windows.Forms.Label();
            this.LblStoreTrDate = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblStoreTrIDDAY = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TmrPrint = new System.Windows.Forms.Timer(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.pnlPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCompany
            // 
            this.LblCompany.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LblCompany.Location = new System.Drawing.Point(22, 12);
            this.LblCompany.Name = "LblCompany";
            this.LblCompany.Size = new System.Drawing.Size(234, 24);
            this.LblCompany.TabIndex = 0;
            this.LblCompany.Text = "E-E-Soft";
            this.LblCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGVItems
            // 
            this.DGVItems.AllowUserToAddRows = false;
            this.DGVItems.AllowUserToDeleteRows = false;
            this.DGVItems.AllowUserToResizeColumns = false;
            this.DGVItems.AllowUserToResizeRows = false;
            this.DGVItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVItems.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGVItems.Location = new System.Drawing.Point(13, 3);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVItems.ShowCellErrors = false;
            this.DGVItems.ShowCellToolTips = false;
            this.DGVItems.ShowEditingIcon = false;
            this.DGVItems.ShowRowErrors = false;
            this.DGVItems.Size = new System.Drawing.Size(251, 311);
            this.DGVItems.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SanfName";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column2.HeaderText = "اسم الصنف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 148;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Price";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "السعر";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // LblPayed
            // 
            this.LblPayed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPayed.AutoSize = true;
            this.LblPayed.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblPayed.Location = new System.Drawing.Point(29, 318);
            this.LblPayed.Name = "LblPayed";
            this.LblPayed.Size = new System.Drawing.Size(16, 17);
            this.LblPayed.TabIndex = 2;
            this.LblPayed.Text = "0";
            // 
            // LblStoreTrIDTYPE
            // 
            this.LblStoreTrIDTYPE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStoreTrIDTYPE.AutoSize = true;
            this.LblStoreTrIDTYPE.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblStoreTrIDTYPE.Location = new System.Drawing.Point(24, 42);
            this.LblStoreTrIDTYPE.Name = "LblStoreTrIDTYPE";
            this.LblStoreTrIDTYPE.Size = new System.Drawing.Size(16, 17);
            this.LblStoreTrIDTYPE.TabIndex = 2;
            this.LblStoreTrIDTYPE.Text = "0";
            // 
            // LblPERSONID
            // 
            this.LblPERSONID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPERSONID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblPERSONID.Location = new System.Drawing.Point(22, 107);
            this.LblPERSONID.Name = "LblPERSONID";
            this.LblPERSONID.Size = new System.Drawing.Size(234, 40);
            this.LblPERSONID.TabIndex = 2;
            this.LblPERSONID.Text = "-";
            this.LblPERSONID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblStoreTrDate
            // 
            this.LblStoreTrDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStoreTrDate.AutoSize = true;
            this.LblStoreTrDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblStoreTrDate.Location = new System.Drawing.Point(79, 65);
            this.LblStoreTrDate.Name = "LblStoreTrDate";
            this.LblStoreTrDate.Size = new System.Drawing.Size(16, 17);
            this.LblStoreTrDate.TabIndex = 2;
            this.LblStoreTrDate.Text = "0";
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblTotal.Location = new System.Drawing.Point(145, 318);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(16, 17);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "0";
            // 
            // LblStoreTrIDDAY
            // 
            this.LblStoreTrIDDAY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStoreTrIDDAY.AutoSize = true;
            this.LblStoreTrIDDAY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblStoreTrIDDAY.Location = new System.Drawing.Point(146, 42);
            this.LblStoreTrIDDAY.Name = "LblStoreTrIDDAY";
            this.LblStoreTrIDDAY.Size = new System.Drawing.Size(16, 17);
            this.LblStoreTrIDDAY.TabIndex = 2;
            this.LblStoreTrIDDAY.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(80, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "المدفوع";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(65, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "رقم الفاتوره";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(210, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "العميل";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(209, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "الاجمالي";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(213, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(193, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الطلب";
            // 
            // TmrPrint
            // 
            this.TmrPrint.Interval = 500;
            this.TmrPrint.Tick += new System.EventHandler(this.TmrPrint_Tick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(98, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "طباعه";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlPrint
            // 
            this.pnlPrint.Controls.Add(this.btnExit);
            this.pnlPrint.Controls.Add(this.btnPrint);
            this.pnlPrint.Location = new System.Drawing.Point(12, 513);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(282, 31);
            this.pnlPrint.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(37, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LblCompany);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.LblStoreTrIDTYPE);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.LblPERSONID);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.LblStoreTrDate);
            this.splitContainer1.Panel1.Controls.Add(this.LblStoreTrIDDAY);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGVItems);
            this.splitContainer1.Panel2.Controls.Add(this.LblPayed);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.LblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(282, 495);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 3;
            // 
            // BillResitFrm
            // 
            this.AcceptButton = this.btnPrint;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(308, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillResitFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillResitFrm";
            this.Load += new System.EventHandler(this.BillResitFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.pnlPrint.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblStoreTrIDTYPE;
        private System.Windows.Forms.Label LblPERSONID;
        private System.Windows.Forms.Label LblStoreTrDate;
        private System.Windows.Forms.Label LblStoreTrIDDAY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPayed;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGVItems;
        private System.Windows.Forms.Timer TmrPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox LblCompany;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}