namespace E_Club_Mem_Manager
{
    partial class AddMemAttachmentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemAttachmentFrm));
            this.GridController = new DevExpress.XtraGrid.GridControl();
            this.GridViewMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridController
            // 
            this.GridController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridController.Location = new System.Drawing.Point(2, 21);
            this.GridController.MainView = this.GridViewMembers;
            this.GridController.Name = "GridController";
            this.GridController.Size = new System.Drawing.Size(774, 430);
            this.GridController.TabIndex = 0;
            this.GridController.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMembers});
            // 
            // GridViewMembers
            // 
            this.GridViewMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumnID,
            this.GridColumnName,
            this.GridColumnCount});
            this.GridViewMembers.GridControl = this.GridController;
            this.GridViewMembers.Name = "GridViewMembers";
            this.GridViewMembers.OptionsBehavior.Editable = false;
            this.GridViewMembers.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GridViewMembers_RowCellClick);
            // 
            // GridColumnID
            // 
            this.GridColumnID.Caption = "mem_ID";
            this.GridColumnID.FieldName = "mem_ID";
            this.GridColumnID.Name = "GridColumnID";
            // 
            // GridColumnName
            // 
            this.GridColumnName.Caption = "اسم الاعضـــــــــــاء";
            this.GridColumnName.FieldName = "mem_name";
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.GridController);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(778, 453);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "جدول مرفقــــــــــات الاعضاء";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 413);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(778, 40);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "ملحـــــــــوظه";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(373, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(398, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الزر الايسر للفأره : لتعديد محتوي الخليه - و الزر الايمن للفأره : لحذفها";
            // 
            // AddMemAttachmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 453);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMemAttachmentFrm";
            this.Text = "المرفقــــــــــات";
            this.Load += new System.EventHandler(this.AddAttachmentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridController;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewMembers;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumnCount;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;




    }
}