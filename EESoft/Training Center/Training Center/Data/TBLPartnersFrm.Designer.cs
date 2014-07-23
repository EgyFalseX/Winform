namespace Training_Center
{
    partial class TBLPartnersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLPartnersFrm));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCPartnersAddres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCPartnerphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCPartnermobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCPartnerfax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCPartneremail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCPartnerPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(12, 12);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDelete});
            this.gridControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMain.Size = new System.Drawing.Size(760, 438);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCPartner,
            this.GCPartnersAddres,
            this.GCPartnerphone,
            this.GCPartnermobile,
            this.GCPartnerfax,
            this.GCPartneremail,
            this.GCPartnerPerson,
            this.GCSave,
            this.GCDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // GCPartner
            // 
            this.GCPartner.AppearanceCell.Options.UseTextOptions = true;
            this.GCPartner.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartner.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPartner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartner.Caption = "الاسم";
            this.GCPartner.FieldName = "Partner";
            this.GCPartner.Name = "GCPartner";
            this.GCPartner.Visible = true;
            this.GCPartner.VisibleIndex = 0;
            this.GCPartner.Width = 217;
            // 
            // GCPartnersAddres
            // 
            this.GCPartnersAddres.AppearanceCell.Options.UseTextOptions = true;
            this.GCPartnersAddres.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnersAddres.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPartnersAddres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnersAddres.Caption = "العنوان";
            this.GCPartnersAddres.FieldName = "PartnersAddres";
            this.GCPartnersAddres.Name = "GCPartnersAddres";
            this.GCPartnersAddres.Visible = true;
            this.GCPartnersAddres.VisibleIndex = 1;
            this.GCPartnersAddres.Width = 159;
            // 
            // GCSave
            // 
            this.GCSave.AppearanceCell.Options.UseTextOptions = true;
            this.GCSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSave.AppearanceHeader.Options.UseTextOptions = true;
            this.GCSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSave.Caption = "حفظ";
            this.GCSave.ColumnEdit = this.repositoryItemButtonEditSave;
            this.GCSave.Name = "GCSave";
            this.GCSave.Visible = true;
            this.GCSave.VisibleIndex = 7;
            this.GCSave.Width = 79;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSave_ButtonClick);
            // 
            // GCDelete
            // 
            this.GCDelete.AppearanceCell.Options.UseTextOptions = true;
            this.GCDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.GCDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCDelete.Caption = "حذف";
            this.GCDelete.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.GCDelete.Name = "GCDelete";
            this.GCDelete.Visible = true;
            this.GCDelete.VisibleIndex = 8;
            this.GCDelete.Width = 81;
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDelete_ButtonClick);
            // 
            // GCPartnerphone
            // 
            this.GCPartnerphone.AppearanceCell.Options.UseTextOptions = true;
            this.GCPartnerphone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnerphone.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPartnerphone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnerphone.Caption = "التليفون";
            this.GCPartnerphone.FieldName = "Partnerphone";
            this.GCPartnerphone.Name = "GCPartnerphone";
            this.GCPartnerphone.Visible = true;
            this.GCPartnerphone.VisibleIndex = 2;
            // 
            // GCPartnermobile
            // 
            this.GCPartnermobile.AppearanceCell.Options.UseTextOptions = true;
            this.GCPartnermobile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnermobile.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPartnermobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnermobile.Caption = "الموبيل";
            this.GCPartnermobile.FieldName = "Partnermobile";
            this.GCPartnermobile.Name = "GCPartnermobile";
            this.GCPartnermobile.Visible = true;
            this.GCPartnermobile.VisibleIndex = 3;
            // 
            // GCPartnerfax
            // 
            this.GCPartnerfax.AppearanceCell.Options.UseTextOptions = true;
            this.GCPartnerfax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnerfax.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPartnerfax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnerfax.Caption = "فاكس";
            this.GCPartnerfax.FieldName = "Partnerfax";
            this.GCPartnerfax.Name = "GCPartnerfax";
            this.GCPartnerfax.Visible = true;
            this.GCPartnerfax.VisibleIndex = 4;
            // 
            // GCPartneremail
            // 
            this.GCPartneremail.AppearanceCell.Options.UseTextOptions = true;
            this.GCPartneremail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartneremail.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPartneremail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartneremail.Caption = "البريد";
            this.GCPartneremail.FieldName = "Partneremail";
            this.GCPartneremail.Name = "GCPartneremail";
            this.GCPartneremail.Visible = true;
            this.GCPartneremail.VisibleIndex = 5;
            // 
            // GCPartnerPerson
            // 
            this.GCPartnerPerson.AppearanceCell.Options.UseTextOptions = true;
            this.GCPartnerPerson.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnerPerson.AppearanceHeader.Options.UseTextOptions = true;
            this.GCPartnerPerson.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCPartnerPerson.Caption = "المدير المسئول";
            this.GCPartnerPerson.FieldName = "PartnerPerson";
            this.GCPartnerPerson.Name = "GCPartnerPerson";
            this.GCPartnerPerson.Visible = true;
            this.GCPartnerPerson.VisibleIndex = 6;
            this.GCPartnerPerson.Width = 114;
            // 
            // TBLPartnersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLPartnersFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموردون";
            this.Load += new System.EventHandler(this.FrmCdBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn GCPartner;
        private DevExpress.XtraGrid.Columns.GridColumn GCPartnersAddres;
        private DevExpress.XtraGrid.Columns.GridColumn GCSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCPartnerphone;
        private DevExpress.XtraGrid.Columns.GridColumn GCPartnermobile;
        private DevExpress.XtraGrid.Columns.GridColumn GCPartnerfax;
        private DevExpress.XtraGrid.Columns.GridColumn GCPartneremail;
        private DevExpress.XtraGrid.Columns.GridColumn GCPartnerPerson;
    }
}