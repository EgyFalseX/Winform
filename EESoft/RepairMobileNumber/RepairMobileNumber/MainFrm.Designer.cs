namespace RepairMobileNumber
{
    partial class MainFrm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageRepairMobile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRepair = new System.Windows.Forms.DataGridView();
            this.btnRepairMobile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb = new System.Windows.Forms.ToolStripProgressBar();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.govDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMobile = new RepairMobileNumber.dsMobile();
            this.mobileDataTableAdapter = new RepairMobileNumber.dsMobileTableAdapters.MobileDataTableAdapter();
            this.tabControlMain.SuspendLayout();
            this.tabPageRepairMobile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepair)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMobile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageRepairMobile);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(554, 261);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageRepairMobile
            // 
            this.tabPageRepairMobile.Controls.Add(this.dgvRepair);
            this.tabPageRepairMobile.Controls.Add(this.groupBox1);
            this.tabPageRepairMobile.Location = new System.Drawing.Point(4, 22);
            this.tabPageRepairMobile.Name = "tabPageRepairMobile";
            this.tabPageRepairMobile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRepairMobile.Size = new System.Drawing.Size(546, 235);
            this.tabPageRepairMobile.TabIndex = 0;
            this.tabPageRepairMobile.Text = "Repair Mobile";
            this.tabPageRepairMobile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRepairMobile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repair";
            // 
            // dgvRepair
            // 
            this.dgvRepair.AllowUserToAddRows = false;
            this.dgvRepair.AllowUserToDeleteRows = false;
            this.dgvRepair.AutoGenerateColumns = false;
            this.dgvRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.govDataGridViewTextBoxColumn});
            this.dgvRepair.DataSource = this.mobileDataBindingSource;
            this.dgvRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRepair.Location = new System.Drawing.Point(3, 56);
            this.dgvRepair.Name = "dgvRepair";
            this.dgvRepair.ReadOnly = true;
            this.dgvRepair.Size = new System.Drawing.Size(540, 176);
            this.dgvRepair.TabIndex = 1;
            // 
            // btnRepairMobile
            // 
            this.btnRepairMobile.Location = new System.Drawing.Point(6, 19);
            this.btnRepairMobile.Name = "btnRepairMobile";
            this.btnRepairMobile.Size = new System.Drawing.Size(75, 23);
            this.btnRepairMobile.TabIndex = 0;
            this.btnRepairMobile.Text = "Repair Mobile Number";
            this.btnRepairMobile.UseVisualStyleBackColor = true;
            this.btnRepairMobile.Click += new System.EventHandler(this.btnRepairMobile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblState,
            this.pb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(554, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblState
            // 
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(39, 17);
            this.lblState.Text = "Ready";
            // 
            // pb
            // 
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 16);
            this.pb.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataDataGridViewTextBoxColumn
            // 
            this.nameDataDataGridViewTextBoxColumn.DataPropertyName = "NameData";
            this.nameDataDataGridViewTextBoxColumn.HeaderText = "NameData";
            this.nameDataDataGridViewTextBoxColumn.Name = "nameDataDataGridViewTextBoxColumn";
            this.nameDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // govDataGridViewTextBoxColumn
            // 
            this.govDataGridViewTextBoxColumn.DataPropertyName = "Gov";
            this.govDataGridViewTextBoxColumn.HeaderText = "Gov";
            this.govDataGridViewTextBoxColumn.Name = "govDataGridViewTextBoxColumn";
            this.govDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataBindingSource
            // 
            this.mobileDataBindingSource.DataMember = "MobileData";
            this.mobileDataBindingSource.DataSource = this.dsMobile;
            // 
            // dsMobile
            // 
            this.dsMobile.DataSetName = "dsMobile";
            this.dsMobile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mobileDataTableAdapter
            // 
            this.mobileDataTableAdapter.ClearBeforeFill = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainFrm";
            this.Text = "Repair Mobile Numbers";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageRepairMobile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepair)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageRepairMobile;
        private System.Windows.Forms.DataGridView dgvRepair;
        private System.Windows.Forms.GroupBox groupBox1;
        private dsMobile dsMobile;
        private System.Windows.Forms.BindingSource mobileDataBindingSource;
        private dsMobileTableAdapters.MobileDataTableAdapter mobileDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn govDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRepairMobile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.ToolStripProgressBar pb;
    }
}

