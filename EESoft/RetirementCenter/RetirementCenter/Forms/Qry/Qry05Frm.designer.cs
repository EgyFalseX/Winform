namespace RetirementCenter
{
    partial class Qry05Frm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMS = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonAddres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonbirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateWarasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitteWarasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonmobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonNID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarasaType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyasref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndworkReson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkeEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarasaTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateIdWarasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitteIdWarasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemPictureEditImg = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.colresponsiblesarf = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.LSMS;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDate,
            this.repositoryItemPictureEditImg,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEditDMY});
            this.gridControlData.Size = new System.Drawing.Size(734, 406);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // LSMS
            // 
            this.LSMS.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLWarasa_TBLMashat);
            this.LSMS.KeyExpression = "PersonId";
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewData.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewData.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewData.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewData.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewData.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewData.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewData.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridViewData.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewData.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridViewData.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewData.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.Row.Options.UseBackColor = true;
            this.gridViewData.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewData.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpersonName,
            this.colpersonAddres,
            this.colpersonbirth,
            this.colMMashatName,
            this.colSyndicateWarasa,
            this.colSubCommitteWarasa,
            this.colpersonmobile,
            this.colpersonNID,
            this.colWarasaType,
            this.colsarfnumber,
            this.colyasref,
            this.colSyndicate,
            this.colSubCommitte,
            this.colEndworkReson,
            this.colWorkeEndDate,
            this.coldatein,
            this.colRealName,
            this.colSyndicateId,
            this.colSubCommitteId,
            this.colPersonId,
            this.colMMashatId,
            this.colWarasaTypeId,
            this.colSyndicateIdWarasa,
            this.colSubCommitteIdWarasa,
            this.colresponsiblesarf});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colpersonName
            // 
            this.colpersonName.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.Caption = "اسم الوريث";
            this.colpersonName.FieldName = "personName";
            this.colpersonName.Name = "colpersonName";
            this.colpersonName.Visible = true;
            this.colpersonName.VisibleIndex = 0;
            // 
            // colpersonAddres
            // 
            this.colpersonAddres.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonAddres.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonAddres.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonAddres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonAddres.Caption = "العنوان";
            this.colpersonAddres.FieldName = "personAddres";
            this.colpersonAddres.Name = "colpersonAddres";
            this.colpersonAddres.Visible = true;
            this.colpersonAddres.VisibleIndex = 6;
            // 
            // colpersonbirth
            // 
            this.colpersonbirth.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonbirth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonbirth.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonbirth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonbirth.Caption = "تاريخ الميلاد";
            this.colpersonbirth.FieldName = "personbirth";
            this.colpersonbirth.Name = "colpersonbirth";
            this.colpersonbirth.Visible = true;
            this.colpersonbirth.VisibleIndex = 5;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "اسم العضو";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 7;
            // 
            // colSyndicateWarasa
            // 
            this.colSyndicateWarasa.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateWarasa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateWarasa.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateWarasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateWarasa.Caption = "فرعية الوريث";
            this.colSyndicateWarasa.FieldName = "SyndicateWarasa";
            this.colSyndicateWarasa.Name = "colSyndicateWarasa";
            this.colSyndicateWarasa.Visible = true;
            this.colSyndicateWarasa.VisibleIndex = 1;
            this.colSyndicateWarasa.Width = 77;
            // 
            // colSubCommitteWarasa
            // 
            this.colSubCommitteWarasa.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteWarasa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteWarasa.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteWarasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteWarasa.Caption = "لجنة الوريث";
            this.colSubCommitteWarasa.FieldName = "SubCommitteWarasa";
            this.colSubCommitteWarasa.Name = "colSubCommitteWarasa";
            this.colSubCommitteWarasa.Visible = true;
            this.colSubCommitteWarasa.VisibleIndex = 2;
            // 
            // colpersonmobile
            // 
            this.colpersonmobile.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonmobile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonmobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonmobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonmobile.Caption = "الموبيل";
            this.colpersonmobile.FieldName = "personmobile";
            this.colpersonmobile.Name = "colpersonmobile";
            this.colpersonmobile.Visible = true;
            this.colpersonmobile.VisibleIndex = 3;
            // 
            // colpersonNID
            // 
            this.colpersonNID.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonNID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonNID.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonNID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonNID.Caption = "الرقم القومي";
            this.colpersonNID.FieldName = "personNID";
            this.colpersonNID.Name = "colpersonNID";
            this.colpersonNID.Visible = true;
            this.colpersonNID.VisibleIndex = 14;
            this.colpersonNID.Width = 80;
            // 
            // colWarasaType
            // 
            this.colWarasaType.AppearanceCell.Options.UseTextOptions = true;
            this.colWarasaType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarasaType.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarasaType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarasaType.Caption = "النوع";
            this.colWarasaType.FieldName = "WarasaType";
            this.colWarasaType.Name = "colWarasaType";
            this.colWarasaType.Visible = true;
            this.colWarasaType.VisibleIndex = 4;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم الصرف";
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 8;
            // 
            // colyasref
            // 
            this.colyasref.AppearanceCell.Options.UseTextOptions = true;
            this.colyasref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.AppearanceHeader.Options.UseTextOptions = true;
            this.colyasref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.Caption = "يصرف";
            this.colyasref.FieldName = "yasref";
            this.colyasref.Name = "colyasref";
            this.colyasref.Visible = true;
            this.colyasref.VisibleIndex = 9;
            this.colyasref.Width = 46;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "فرعية العضو";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 11;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "لجنة العضو";
            this.colSubCommitte.FieldName = "SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 10;
            // 
            // colEndworkReson
            // 
            this.colEndworkReson.AppearanceCell.Options.UseTextOptions = true;
            this.colEndworkReson.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEndworkReson.AppearanceHeader.Options.UseTextOptions = true;
            this.colEndworkReson.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEndworkReson.Caption = "سبب نهاية العمل";
            this.colEndworkReson.FieldName = "EndworkReson";
            this.colEndworkReson.Name = "colEndworkReson";
            this.colEndworkReson.Visible = true;
            this.colEndworkReson.VisibleIndex = 12;
            this.colEndworkReson.Width = 98;
            // 
            // colWorkeEndDate
            // 
            this.colWorkeEndDate.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkeEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkeEndDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colWorkeEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkeEndDate.Caption = "تاريخ نهاية العمل";
            this.colWorkeEndDate.FieldName = "WorkeEndDate";
            this.colWorkeEndDate.Name = "colWorkeEndDate";
            this.colWorkeEndDate.Visible = true;
            this.colWorkeEndDate.VisibleIndex = 13;
            this.colWorkeEndDate.Width = 94;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 16;
            // 
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "مدخل البيان";
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 15;
            // 
            // colSyndicateId
            // 
            this.colSyndicateId.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.Caption = "كود فرعية العضو";
            this.colSyndicateId.FieldName = "SyndicateId";
            this.colSyndicateId.Name = "colSyndicateId";
            this.colSyndicateId.Visible = true;
            this.colSyndicateId.VisibleIndex = 17;
            this.colSyndicateId.Width = 93;
            // 
            // colSubCommitteId
            // 
            this.colSubCommitteId.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.Caption = "كود لجنة العضو";
            this.colSubCommitteId.FieldName = "SubCommitteId";
            this.colSubCommitteId.Name = "colSubCommitteId";
            this.colSubCommitteId.Visible = true;
            this.colSubCommitteId.VisibleIndex = 18;
            // 
            // colPersonId
            // 
            this.colPersonId.AppearanceCell.Options.UseTextOptions = true;
            this.colPersonId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonId.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonId.Caption = "كود الوريث";
            this.colPersonId.FieldName = "PersonId";
            this.colPersonId.Name = "colPersonId";
            this.colPersonId.Visible = true;
            this.colPersonId.VisibleIndex = 19;
            // 
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "كود العضو";
            this.colMMashatId.FieldName = "MMashatId";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 20;
            // 
            // colWarasaTypeId
            // 
            this.colWarasaTypeId.AppearanceCell.Options.UseTextOptions = true;
            this.colWarasaTypeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarasaTypeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarasaTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarasaTypeId.Caption = "كود الصله";
            this.colWarasaTypeId.FieldName = "WarasaTypeId";
            this.colWarasaTypeId.Name = "colWarasaTypeId";
            this.colWarasaTypeId.Visible = true;
            this.colWarasaTypeId.VisibleIndex = 21;
            // 
            // colSyndicateIdWarasa
            // 
            this.colSyndicateIdWarasa.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateIdWarasa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateIdWarasa.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateIdWarasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateIdWarasa.Caption = "كود فرعية الوريث";
            this.colSyndicateIdWarasa.FieldName = "SyndicateIdWarasa";
            this.colSyndicateIdWarasa.Name = "colSyndicateIdWarasa";
            this.colSyndicateIdWarasa.Visible = true;
            this.colSyndicateIdWarasa.VisibleIndex = 22;
            this.colSyndicateIdWarasa.Width = 95;
            // 
            // colSubCommitteIdWarasa
            // 
            this.colSubCommitteIdWarasa.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteIdWarasa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteIdWarasa.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteIdWarasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteIdWarasa.Caption = "كود لجنة الوريث";
            this.colSubCommitteIdWarasa.FieldName = "SubCommitteIdWarasa";
            this.colSubCommitteIdWarasa.Name = "colSubCommitteIdWarasa";
            this.colSubCommitteIdWarasa.Visible = true;
            this.colSubCommitteIdWarasa.VisibleIndex = 23;
            this.colSubCommitteIdWarasa.Width = 88;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "u";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "u";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemPictureEditImg
            // 
            this.repositoryItemPictureEditImg.Name = "repositoryItemPictureEditImg";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(734, 47);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(588, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // colresponsiblesarf
            // 
            this.colresponsiblesarf.AppearanceCell.Options.UseTextOptions = true;
            this.colresponsiblesarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colresponsiblesarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colresponsiblesarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colresponsiblesarf.Caption = "مسئول صرف";
            this.colresponsiblesarf.FieldName = "responsiblesarf";
            this.colresponsiblesarf.Name = "colresponsiblesarf";
            this.colresponsiblesarf.Visible = true;
            this.colresponsiblesarf.VisibleIndex = 24;
            // 
            // Qry05Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry05Frm";
            this.Text = "الورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QryTblAhteatyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditImg;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.Data.Linq.LinqServerModeSource LSMS;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn colyasref;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndworkReson;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkeEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonAddres;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonbirth;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonmobile;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonNID;
        private DevExpress.XtraGrid.Columns.GridColumn colWarasaType;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteId;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonId;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colWarasaTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateWarasa;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteWarasa;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateIdWarasa;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteIdWarasa;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsiblesarf;

    }
}