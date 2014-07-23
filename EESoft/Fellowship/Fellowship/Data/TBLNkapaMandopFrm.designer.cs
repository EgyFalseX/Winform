namespace Fellowship
{
    partial class TBLNkapaMandopFrm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tBLNkapaMandopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFellowship = new Fellowship.DataSources.DSFellowship();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnkapaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditnkapaId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnkapaMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnkapaMandopMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnkapaMandopMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnkapaMandopAddres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEDARET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tBLNkapaMandopTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.TBLNkapaMandopTableAdapter();
            this.tableAdapterManager = new Fellowship.DataSources.DSFellowshipTableAdapters.TableAdapterManager();
            this.cDSyndicateTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.CDSyndicateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLNkapaMandopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditnkapaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLNkapaMandopBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDel,
            this.repositoryItemGridLookUpEditnkapaId});
            this.gridControlData.Size = new System.Drawing.Size(784, 362);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // tBLNkapaMandopBindingSource
            // 
            this.tBLNkapaMandopBindingSource.DataMember = "TBLNkapaMandop";
            this.tBLNkapaMandopBindingSource.DataSource = this.dSFellowship;
            // 
            // dSFellowship
            // 
            this.dSFellowship.DataSetName = "DSFellowship";
            this.dSFellowship.Locale = new System.Globalization.CultureInfo("en-US");
            this.dSFellowship.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnkapaId,
            this.colnkapaMandopName,
            this.colnkapaMandopMobile,
            this.colnkapaMandopMail,
            this.colnkapaMandopAddres,
            this.gridColumnSave,
            this.gridColumnDelete});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewData_InvalidRowException);
            // 
            // colnkapaId
            // 
            this.colnkapaId.AppearanceCell.Options.UseTextOptions = true;
            this.colnkapaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaId.AppearanceHeader.Options.UseTextOptions = true;
            this.colnkapaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaId.Caption = "اسم الفرعيه";
            this.colnkapaId.ColumnEdit = this.repositoryItemGridLookUpEditnkapaId;
            this.colnkapaId.FieldName = "nkapaId";
            this.colnkapaId.Name = "colnkapaId";
            this.colnkapaId.Visible = true;
            this.colnkapaId.VisibleIndex = 0;
            this.colnkapaId.Width = 113;
            // 
            // repositoryItemGridLookUpEditnkapaId
            // 
            this.repositoryItemGridLookUpEditnkapaId.AutoHeight = false;
            this.repositoryItemGridLookUpEditnkapaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemGridLookUpEditnkapaId.DataSource = this.cDSyndicateBindingSource;
            this.repositoryItemGridLookUpEditnkapaId.DisplayMember = "Syndicate";
            this.repositoryItemGridLookUpEditnkapaId.Name = "repositoryItemGridLookUpEditnkapaId";
            this.repositoryItemGridLookUpEditnkapaId.NullText = "";
            this.repositoryItemGridLookUpEditnkapaId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditnkapaId.ValueMember = "SyndicateId";
            this.repositoryItemGridLookUpEditnkapaId.View = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEditnkapaId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemGridLookUpEditnkapaId_ButtonClick);
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dSFellowship;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "الفرعيه";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 0;
            // 
            // colnkapaMandopName
            // 
            this.colnkapaMandopName.AppearanceCell.Options.UseTextOptions = true;
            this.colnkapaMandopName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopName.AppearanceHeader.Options.UseTextOptions = true;
            this.colnkapaMandopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopName.Caption = "اسم المندوب";
            this.colnkapaMandopName.FieldName = "nkapaMandopName";
            this.colnkapaMandopName.Name = "colnkapaMandopName";
            this.colnkapaMandopName.Visible = true;
            this.colnkapaMandopName.VisibleIndex = 1;
            this.colnkapaMandopName.Width = 136;
            // 
            // colnkapaMandopMobile
            // 
            this.colnkapaMandopMobile.AppearanceCell.Options.UseTextOptions = true;
            this.colnkapaMandopMobile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopMobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colnkapaMandopMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopMobile.Caption = "موبيل";
            this.colnkapaMandopMobile.FieldName = "nkapaMandopMobile";
            this.colnkapaMandopMobile.Name = "colnkapaMandopMobile";
            this.colnkapaMandopMobile.Visible = true;
            this.colnkapaMandopMobile.VisibleIndex = 2;
            // 
            // colnkapaMandopMail
            // 
            this.colnkapaMandopMail.AppearanceCell.Options.UseTextOptions = true;
            this.colnkapaMandopMail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopMail.AppearanceHeader.Options.UseTextOptions = true;
            this.colnkapaMandopMail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopMail.Caption = "ايميل";
            this.colnkapaMandopMail.FieldName = "nkapaMandopMail";
            this.colnkapaMandopMail.Name = "colnkapaMandopMail";
            this.colnkapaMandopMail.Visible = true;
            this.colnkapaMandopMail.VisibleIndex = 3;
            // 
            // colnkapaMandopAddres
            // 
            this.colnkapaMandopAddres.AppearanceCell.Options.UseTextOptions = true;
            this.colnkapaMandopAddres.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopAddres.AppearanceHeader.Options.UseTextOptions = true;
            this.colnkapaMandopAddres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopAddres.Caption = "العنوان";
            this.colnkapaMandopAddres.FieldName = "nkapaMandopAddres";
            this.colnkapaMandopAddres.Name = "colnkapaMandopAddres";
            this.colnkapaMandopAddres.Visible = true;
            this.colnkapaMandopAddres.VisibleIndex = 4;
            this.colnkapaMandopAddres.Width = 123;
            // 
            // gridColumnSave
            // 
            this.gridColumnSave.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSave.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSave.Caption = "حفظ";
            this.gridColumnSave.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumnSave.Name = "gridColumnSave";
            this.gridColumnSave.Visible = true;
            this.gridColumnSave.VisibleIndex = 5;
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
            // gridColumnDelete
            // 
            this.gridColumnDelete.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.Caption = "حذف";
            this.gridColumnDelete.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 6;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // colEDARET
            // 
            this.colEDARET.AppearanceCell.Options.UseTextOptions = true;
            this.colEDARET.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDARET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET.Caption = "اسم الاداره";
            this.colEDARET.FieldName = "EDARET";
            this.colEDARET.Name = "colEDARET";
            this.colEDARET.Visible = true;
            this.colEDARET.VisibleIndex = 0;
            // 
            // tBLNkapaMandopTableAdapter
            // 
            this.tBLNkapaMandopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CDEDARETTableAdapter = null;
            this.tableAdapterManager.CDModereaTableAdapter = null;
            this.tableAdapterManager.CDMonthTableAdapter = null;
            this.tableAdapterManager.CDSyndicateTableAdapter = this.cDSyndicateTableAdapter;
            this.tableAdapterManager.TBLEdaraMandopTableAdapter = null;
            this.tableAdapterManager.TBLNkapaMandopTableAdapter = this.tBLNkapaMandopTableAdapter;
            this.tableAdapterManager.TBLSheekWaredTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Fellowship.DataSources.DSFellowshipTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // TBLNkapaMandopFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.gridControlData);
            this.Name = "TBLNkapaMandopFrm";
            this.Text = "مندوبي النقابات";
            this.Load += new System.EventHandler(this.stu_nashatFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLNkapaMandopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditnkapaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET;
        private DataSources.DSFellowship dSFellowship;
        private System.Windows.Forms.BindingSource tBLNkapaMandopBindingSource;
        private DataSources.DSFellowshipTableAdapters.TBLNkapaMandopTableAdapter tBLNkapaMandopTableAdapter;
        private DataSources.DSFellowshipTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaId;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaMandopMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaMandopMail;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaMandopAddres;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.DSFellowshipTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditnkapaId;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
    }
}