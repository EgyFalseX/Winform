namespace E_Club_Emp_Manager
{
    partial class EditorInsuranceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorInsuranceFrm));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GridControlInsurance = new DevExpress.XtraGrid.GridControl();
            this.GridViewInsurance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.GridControlInsurance);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(658, 355);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "الارقام التـــأمينيــــه";
            // 
            // GridControlInsurance
            // 
            this.GridControlInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlInsurance.Location = new System.Drawing.Point(5, 24);
            this.GridControlInsurance.MainView = this.GridViewInsurance;
            this.GridControlInsurance.Name = "GridControlInsurance";
            this.GridControlInsurance.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1});
            this.GridControlInsurance.Size = new System.Drawing.Size(648, 326);
            this.GridControlInsurance.TabIndex = 0;
            this.GridControlInsurance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewInsurance});
            // 
            // GridViewInsurance
            // 
            this.GridViewInsurance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn2});
            this.GridViewInsurance.GridControl = this.GridControlInsurance;
            this.GridViewInsurance.Name = "GridViewInsurance";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "EmpID";
            this.gridColumn1.FieldName = "EmpID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowShowHide = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "رقم بطاقة التأمين";
            this.gridColumn5.FieldName = "betaka_tameen";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "تــاريخ التــأميــن";
            this.gridColumn4.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "tameen_date1";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.HideSelection = false;
            this.repositoryItemDateEdit1.Mask.BeepOnError = true;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.NullValuePrompt = "لا يوجد تاريخ";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.VistaTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.VistaTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.VistaTimeProperties.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.VistaTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemDateEdit1_EditValueChanging);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "الرقــم التــأميني";
            this.gridColumn3.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn3.FieldName = "tameen_no";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaxLength = 20;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemTextEdit1_EditValueChanging);
            this.repositoryItemTextEdit1.Leave += new System.EventHandler(this.repositoryItemTextEdit1_Leave);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "الاســـــــــــــم";
            this.gridColumn2.FieldName = "Emp_Full_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // EditorInsuranceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 378);
            this.Controls.Add(this.groupControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorInsuranceFrm";
            this.Text = "تأمينات الموظفين";
            this.Load += new System.EventHandler(this.EditorInsuranceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GridControlInsurance;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewInsurance;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}