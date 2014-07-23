namespace RealEstate    
{
    partial class TblOwnerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TblOwnerFrm));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCOwnerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCownertypeid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditownertypeid = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCCdAreaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditCdAreaId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOwnerTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOwnerMobil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOwnerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOwnerHafeza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCHafezaIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCsegel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCnationaltyid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditnationaltyid = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditownertypeid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCdAreaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditnationaltyid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.repositoryItemButtonEditDelete,
            this.repositoryItemGridLookUpEditCdAreaId,
            this.repositoryItemGridLookUpEditownertypeid,
            this.repositoryItemGridLookUpEditnationaltyid});
            this.gridControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMain.Size = new System.Drawing.Size(860, 438);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOwnerId,
            this.GCownertypeid,
            this.GCOwner,
            this.GCnationaltyid,
            this.GCCdAreaId,
            this.GCOwnerTel,
            this.GCOwnerMobil,
            this.GCOwnerAddress,
            this.GCOwnerHafeza,
            this.GCHafezaIn,
            this.GCsegel,
            this.GCSave,
            this.GCDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // GCOwnerId
            // 
            this.GCOwnerId.AppearanceCell.Options.UseTextOptions = true;
            this.GCOwnerId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerId.AppearanceHeader.Options.UseTextOptions = true;
            this.GCOwnerId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerId.Caption = "كود المالك";
            this.GCOwnerId.FieldName = "OwnerId";
            this.GCOwnerId.Name = "GCOwnerId";
            this.GCOwnerId.OptionsColumn.AllowEdit = false;
            this.GCOwnerId.OptionsColumn.ReadOnly = true;
            this.GCOwnerId.Visible = true;
            this.GCOwnerId.VisibleIndex = 0;
            // 
            // GCownertypeid
            // 
            this.GCownertypeid.AppearanceCell.Options.UseTextOptions = true;
            this.GCownertypeid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCownertypeid.AppearanceHeader.Options.UseTextOptions = true;
            this.GCownertypeid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCownertypeid.Caption = "فئة العميل";
            this.GCownertypeid.ColumnEdit = this.repositoryItemGridLookUpEditownertypeid;
            this.GCownertypeid.FieldName = "ownertypeid";
            this.GCownertypeid.Name = "GCownertypeid";
            this.GCownertypeid.Visible = true;
            this.GCownertypeid.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEditownertypeid
            // 
            this.repositoryItemGridLookUpEditownertypeid.AutoHeight = false;
            this.repositoryItemGridLookUpEditownertypeid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditownertypeid.Name = "repositoryItemGridLookUpEditownertypeid";
            this.repositoryItemGridLookUpEditownertypeid.NullText = "";
            this.repositoryItemGridLookUpEditownertypeid.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditownertypeid.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "الاسم";
            this.gridColumn2.FieldName = "ownertype";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // GCOwner
            // 
            this.GCOwner.AppearanceCell.Options.UseTextOptions = true;
            this.GCOwner.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwner.AppearanceHeader.Options.UseTextOptions = true;
            this.GCOwner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwner.Caption = "اسم المالك";
            this.GCOwner.FieldName = "Owner";
            this.GCOwner.Name = "GCOwner";
            this.GCOwner.Visible = true;
            this.GCOwner.VisibleIndex = 2;
            this.GCOwner.Width = 135;
            // 
            // GCCdAreaId
            // 
            this.GCCdAreaId.AppearanceCell.Options.UseTextOptions = true;
            this.GCCdAreaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCdAreaId.AppearanceHeader.Options.UseTextOptions = true;
            this.GCCdAreaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCdAreaId.Caption = "المنطقة";
            this.GCCdAreaId.ColumnEdit = this.repositoryItemGridLookUpEditCdAreaId;
            this.GCCdAreaId.FieldName = "CdAreaId";
            this.GCCdAreaId.Name = "GCCdAreaId";
            this.GCCdAreaId.Visible = true;
            this.GCCdAreaId.VisibleIndex = 4;
            // 
            // repositoryItemGridLookUpEditCdAreaId
            // 
            this.repositoryItemGridLookUpEditCdAreaId.AutoHeight = false;
            this.repositoryItemGridLookUpEditCdAreaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditCdAreaId.Name = "repositoryItemGridLookUpEditCdAreaId";
            this.repositoryItemGridLookUpEditCdAreaId.NullText = "";
            this.repositoryItemGridLookUpEditCdAreaId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditCdAreaId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "CdArea";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // GCOwnerTel
            // 
            this.GCOwnerTel.AppearanceCell.Options.UseTextOptions = true;
            this.GCOwnerTel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerTel.AppearanceHeader.Options.UseTextOptions = true;
            this.GCOwnerTel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerTel.Caption = "تليفون";
            this.GCOwnerTel.FieldName = "OwnerTel";
            this.GCOwnerTel.Name = "GCOwnerTel";
            this.GCOwnerTel.Visible = true;
            this.GCOwnerTel.VisibleIndex = 5;
            // 
            // GCOwnerMobil
            // 
            this.GCOwnerMobil.AppearanceCell.Options.UseTextOptions = true;
            this.GCOwnerMobil.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerMobil.AppearanceHeader.Options.UseTextOptions = true;
            this.GCOwnerMobil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerMobil.Caption = "جوال";
            this.GCOwnerMobil.FieldName = "OwnerMobil";
            this.GCOwnerMobil.Name = "GCOwnerMobil";
            this.GCOwnerMobil.Visible = true;
            this.GCOwnerMobil.VisibleIndex = 6;
            // 
            // GCOwnerAddress
            // 
            this.GCOwnerAddress.AppearanceCell.Options.UseTextOptions = true;
            this.GCOwnerAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.GCOwnerAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerAddress.Caption = "العنوان";
            this.GCOwnerAddress.FieldName = "OwnerAddress";
            this.GCOwnerAddress.Name = "GCOwnerAddress";
            this.GCOwnerAddress.Visible = true;
            this.GCOwnerAddress.VisibleIndex = 7;
            // 
            // GCOwnerHafeza
            // 
            this.GCOwnerHafeza.AppearanceCell.Options.UseTextOptions = true;
            this.GCOwnerHafeza.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerHafeza.AppearanceHeader.Options.UseTextOptions = true;
            this.GCOwnerHafeza.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwnerHafeza.Caption = "الحفيظة";
            this.GCOwnerHafeza.FieldName = "OwnerHafeza";
            this.GCOwnerHafeza.Name = "GCOwnerHafeza";
            this.GCOwnerHafeza.Visible = true;
            this.GCOwnerHafeza.VisibleIndex = 8;
            // 
            // GCHafezaIn
            // 
            this.GCHafezaIn.AppearanceCell.Options.UseTextOptions = true;
            this.GCHafezaIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHafezaIn.AppearanceHeader.Options.UseTextOptions = true;
            this.GCHafezaIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHafezaIn.Caption = "في ";
            this.GCHafezaIn.FieldName = "HafezaIn";
            this.GCHafezaIn.Name = "GCHafezaIn";
            this.GCHafezaIn.Visible = true;
            this.GCHafezaIn.VisibleIndex = 9;
            // 
            // GCsegel
            // 
            this.GCsegel.AppearanceCell.Options.UseTextOptions = true;
            this.GCsegel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCsegel.AppearanceHeader.Options.UseTextOptions = true;
            this.GCsegel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCsegel.Caption = "سجل";
            this.GCsegel.FieldName = "segel";
            this.GCsegel.Name = "GCsegel";
            this.GCsegel.Visible = true;
            this.GCsegel.VisibleIndex = 10;
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
            this.GCSave.VisibleIndex = 11;
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
            this.GCDelete.VisibleIndex = 12;
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
            // GCnationaltyid
            // 
            this.GCnationaltyid.AppearanceCell.Options.UseTextOptions = true;
            this.GCnationaltyid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCnationaltyid.AppearanceHeader.Options.UseTextOptions = true;
            this.GCnationaltyid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCnationaltyid.Caption = "الجنسيه";
            this.GCnationaltyid.ColumnEdit = this.repositoryItemGridLookUpEditnationaltyid;
            this.GCnationaltyid.FieldName = "nationaltyid";
            this.GCnationaltyid.Name = "GCnationaltyid";
            this.GCnationaltyid.Visible = true;
            this.GCnationaltyid.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEditnationaltyid
            // 
            this.repositoryItemGridLookUpEditnationaltyid.AutoHeight = false;
            this.repositoryItemGridLookUpEditnationaltyid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditnationaltyid.Name = "repositoryItemGridLookUpEditnationaltyid";
            this.repositoryItemGridLookUpEditnationaltyid.NullText = "";
            this.repositoryItemGridLookUpEditnationaltyid.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditnationaltyid.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "الاسم";
            this.gridColumn3.FieldName = "nationalty";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // TblOwnerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TblOwnerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " العملاء";
            this.Load += new System.EventHandler(this.FrmCdBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditownertypeid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditCdAreaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditnationaltyid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn GCOwner;
        private DevExpress.XtraGrid.Columns.GridColumn GCSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCOwnerId;
        private DevExpress.XtraGrid.Columns.GridColumn GCCdAreaId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOwnerTel;
        private DevExpress.XtraGrid.Columns.GridColumn GCOwnerMobil;
        private DevExpress.XtraGrid.Columns.GridColumn GCOwnerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn GCOwnerHafeza;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditCdAreaId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn GCHafezaIn;
        private DevExpress.XtraGrid.Columns.GridColumn GCsegel;
        private DevExpress.XtraGrid.Columns.GridColumn GCownertypeid;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditownertypeid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn GCnationaltyid;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditnationaltyid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}