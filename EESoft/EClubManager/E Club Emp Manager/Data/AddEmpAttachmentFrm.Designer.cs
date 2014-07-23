namespace E_Club_Emp_Manager
{
    partial class AddEmpAttachmentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmpAttachmentFrm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GridController = new DevExpress.XtraGrid.GridControl();
            this.GridViewEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.GridController);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(743, 441);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "جدول مرفقــــــــــات الاعضاء";
            // 
            // GridController
            // 
            this.GridController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridController.Location = new System.Drawing.Point(2, 21);
            this.GridController.MainView = this.GridViewEmployees;
            this.GridController.Name = "GridController";
            this.GridController.Size = new System.Drawing.Size(739, 418);
            this.GridController.TabIndex = 0;
            this.GridController.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewEmployees});
            // 
            // GridViewEmployees
            // 
            this.GridViewEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumnID,
            this.GridColumnName,
            this.GridColumnCount});
            this.GridViewEmployees.GridControl = this.GridController;
            this.GridViewEmployees.Name = "GridViewEmployees";
            this.GridViewEmployees.OptionsBehavior.Editable = false;
            this.GridViewEmployees.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GridViewEmployees_RowCellClick);
            // 
            // GridColumnID
            // 
            this.GridColumnID.Caption = "EmpID";
            this.GridColumnID.FieldName = "EmpID";
            this.GridColumnID.Name = "GridColumnID";
            // 
            // GridColumnName
            // 
            this.GridColumnName.Caption = "اسم الموظــــــــــــف";
            this.GridColumnName.FieldName = "Emp_Full_Name";
            this.GridColumnName.Name = "GridColumnName";
            this.GridColumnName.Visible = true;
            this.GridColumnName.VisibleIndex = 0;
            // 
            // GridColumnCount
            // 
            this.GridColumnCount.Caption = "عدد المرفقــــات";
            this.GridColumnCount.FieldName = "AttachCount";
            this.GridColumnCount.Name = "GridColumnCount";
            this.GridColumnCount.Visible = true;
            this.GridColumnCount.VisibleIndex = 1;
            // 
            // AddEmpAttachmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 441);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmpAttachmentFrm";
            this.Text = "ملفات الموظفين";
            this.Load += new System.EventHandler(this.AddEmpAttachmentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GridController;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumnCount;
    }
}