namespace RealEstate
{
    partial class QryTblEstateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QryTblEstateFrm));
            this.gridControlQry = new DevExpress.XtraGrid.GridControl();
            this.gridViewQry = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCEstateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCshow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCsakdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditMy = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.GCEstateCase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCCdArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCEstateAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditMy = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.GCEstateAdderss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCStreetNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCHadShmal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTallshmal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCHadGanob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTallGanob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCHadshark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTallshark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCHadghrab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTallghrab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCAera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCMetrprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCAllPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.GCimagepath1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditimagepath1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCimagepath2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditimagepath2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCdatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditMy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditMy.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditMy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditimagepath1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditimagepath2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlQry
            // 
            this.gridControlQry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlQry.BackgroundImage = global::RealEstate.Properties.Resources.SplashScreen;
            this.gridControlQry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridControlQry.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlQry.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlQry.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlQry.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlQry.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlQry.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlQry.Location = new System.Drawing.Point(12, 12);
            this.gridControlQry.MainView = this.gridViewQry;
            this.gridControlQry.Name = "gridControlQry";
            this.gridControlQry.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditMy,
            this.repositoryItemCalcEditMy,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemButtonEditimagepath1,
            this.repositoryItemButtonEditimagepath2});
            this.gridControlQry.Size = new System.Drawing.Size(960, 638);
            this.gridControlQry.TabIndex = 0;
            this.gridControlQry.UseEmbeddedNavigator = true;
            this.gridControlQry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQry});
            // 
            // gridViewQry
            // 
            this.gridViewQry.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCEstateId,
            this.GCshow,
            this.GCOwner,
            this.GCsakdate,
            this.GCEstateCase,
            this.GCCdArea,
            this.GCEstateAge,
            this.GCEstateAdderss,
            this.GCStreetNo,
            this.GCHadShmal,
            this.GCTallshmal,
            this.GCHadGanob,
            this.GCTallGanob,
            this.GCHadshark,
            this.GCTallshark,
            this.GCHadghrab,
            this.GCTallghrab,
            this.GCAera,
            this.GCMetrprice,
            this.GCAllPrice,
            this.GCremark,
            this.GCimagepath1,
            this.GCimagepath2,
            this.GCdatein,
            this.GCUserName});
            this.gridViewQry.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewQry.GridControl = this.gridControlQry;
            this.gridViewQry.Name = "gridViewQry";
            this.gridViewQry.OptionsBehavior.ReadOnly = true;
            this.gridViewQry.OptionsView.ColumnAutoWidth = false;
            // 
            // GCEstateId
            // 
            this.GCEstateId.AppearanceCell.Options.UseTextOptions = true;
            this.GCEstateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCEstateId.AppearanceHeader.Options.UseTextOptions = true;
            this.GCEstateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCEstateId.Caption = "رقم العقار";
            this.GCEstateId.FieldName = "EstateId";
            this.GCEstateId.Name = "GCEstateId";
            this.GCEstateId.OptionsColumn.AllowEdit = false;
            // 
            // GCshow
            // 
            this.GCshow.AppearanceCell.Options.UseTextOptions = true;
            this.GCshow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCshow.AppearanceHeader.Options.UseTextOptions = true;
            this.GCshow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCshow.Caption = "حالة العرض";
            this.GCshow.FieldName = "show";
            this.GCshow.Name = "GCshow";
            this.GCshow.OptionsColumn.AllowEdit = false;
            this.GCshow.Visible = true;
            this.GCshow.VisibleIndex = 0;
            // 
            // GCOwner
            // 
            this.GCOwner.AppearanceCell.Options.UseTextOptions = true;
            this.GCOwner.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwner.AppearanceHeader.Options.UseTextOptions = true;
            this.GCOwner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCOwner.Caption = "المالك";
            this.GCOwner.FieldName = "Owner";
            this.GCOwner.Name = "GCOwner";
            this.GCOwner.OptionsColumn.AllowEdit = false;
            this.GCOwner.Visible = true;
            this.GCOwner.VisibleIndex = 1;
            // 
            // GCsakdate
            // 
            this.GCsakdate.AppearanceCell.Options.UseTextOptions = true;
            this.GCsakdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCsakdate.AppearanceHeader.Options.UseTextOptions = true;
            this.GCsakdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCsakdate.Caption = "تاريخ الصك";
            this.GCsakdate.ColumnEdit = this.repositoryItemDateEditMy;
            this.GCsakdate.FieldName = "sakdate";
            this.GCsakdate.Name = "GCsakdate";
            this.GCsakdate.OptionsColumn.AllowEdit = false;
            this.GCsakdate.Visible = true;
            this.GCsakdate.VisibleIndex = 2;
            // 
            // repositoryItemDateEditMy
            // 
            this.repositoryItemDateEditMy.AutoHeight = false;
            this.repositoryItemDateEditMy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditMy.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditMy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditMy.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditMy.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditMy.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditMy.Name = "repositoryItemDateEditMy";
            this.repositoryItemDateEditMy.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // GCEstateCase
            // 
            this.GCEstateCase.AppearanceCell.Options.UseTextOptions = true;
            this.GCEstateCase.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCEstateCase.AppearanceHeader.Options.UseTextOptions = true;
            this.GCEstateCase.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCEstateCase.Caption = "حالة العقار";
            this.GCEstateCase.FieldName = "EstateCase";
            this.GCEstateCase.Name = "GCEstateCase";
            this.GCEstateCase.OptionsColumn.AllowEdit = false;
            this.GCEstateCase.Visible = true;
            this.GCEstateCase.VisibleIndex = 3;
            // 
            // GCCdArea
            // 
            this.GCCdArea.AppearanceCell.Options.UseTextOptions = true;
            this.GCCdArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCdArea.AppearanceHeader.Options.UseTextOptions = true;
            this.GCCdArea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCCdArea.Caption = "المنطقه";
            this.GCCdArea.FieldName = "CdArea";
            this.GCCdArea.Name = "GCCdArea";
            this.GCCdArea.OptionsColumn.AllowEdit = false;
            this.GCCdArea.Visible = true;
            this.GCCdArea.VisibleIndex = 4;
            // 
            // GCEstateAge
            // 
            this.GCEstateAge.AppearanceCell.Options.UseTextOptions = true;
            this.GCEstateAge.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCEstateAge.AppearanceHeader.Options.UseTextOptions = true;
            this.GCEstateAge.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCEstateAge.Caption = "العمر";
            this.GCEstateAge.ColumnEdit = this.repositoryItemCalcEditMy;
            this.GCEstateAge.FieldName = "EstateAge";
            this.GCEstateAge.Name = "GCEstateAge";
            this.GCEstateAge.OptionsColumn.AllowEdit = false;
            this.GCEstateAge.Visible = true;
            this.GCEstateAge.VisibleIndex = 5;
            // 
            // repositoryItemCalcEditMy
            // 
            this.repositoryItemCalcEditMy.AutoHeight = false;
            this.repositoryItemCalcEditMy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditMy.DisplayFormat.FormatString = "f2";
            this.repositoryItemCalcEditMy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditMy.EditFormat.FormatString = "f2";
            this.repositoryItemCalcEditMy.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditMy.Mask.EditMask = "f2";
            this.repositoryItemCalcEditMy.Name = "repositoryItemCalcEditMy";
            // 
            // GCEstateAdderss
            // 
            this.GCEstateAdderss.AppearanceCell.Options.UseTextOptions = true;
            this.GCEstateAdderss.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCEstateAdderss.AppearanceHeader.Options.UseTextOptions = true;
            this.GCEstateAdderss.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCEstateAdderss.Caption = "العنوان";
            this.GCEstateAdderss.FieldName = "EstateAdderss";
            this.GCEstateAdderss.Name = "GCEstateAdderss";
            this.GCEstateAdderss.OptionsColumn.AllowEdit = false;
            this.GCEstateAdderss.Visible = true;
            this.GCEstateAdderss.VisibleIndex = 6;
            // 
            // GCStreetNo
            // 
            this.GCStreetNo.AppearanceCell.Options.UseTextOptions = true;
            this.GCStreetNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCStreetNo.AppearanceHeader.Options.UseTextOptions = true;
            this.GCStreetNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCStreetNo.Caption = "عدد الشوارع";
            this.GCStreetNo.FieldName = "StreetNo";
            this.GCStreetNo.Name = "GCStreetNo";
            this.GCStreetNo.OptionsColumn.AllowEdit = false;
            this.GCStreetNo.Visible = true;
            this.GCStreetNo.VisibleIndex = 7;
            // 
            // GCHadShmal
            // 
            this.GCHadShmal.AppearanceCell.Options.UseTextOptions = true;
            this.GCHadShmal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHadShmal.AppearanceHeader.Options.UseTextOptions = true;
            this.GCHadShmal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHadShmal.Caption = "الحد الشمالي";
            this.GCHadShmal.FieldName = "HadShmal";
            this.GCHadShmal.Name = "GCHadShmal";
            this.GCHadShmal.OptionsColumn.AllowEdit = false;
            // 
            // GCTallshmal
            // 
            this.GCTallshmal.AppearanceCell.Options.UseTextOptions = true;
            this.GCTallshmal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTallshmal.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTallshmal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTallshmal.Caption = "الطول الشمالي";
            this.GCTallshmal.ColumnEdit = this.repositoryItemCalcEditMy;
            this.GCTallshmal.FieldName = "Tallshmal";
            this.GCTallshmal.Name = "GCTallshmal";
            this.GCTallshmal.OptionsColumn.AllowEdit = false;
            this.GCTallshmal.Width = 80;
            // 
            // GCHadGanob
            // 
            this.GCHadGanob.AppearanceCell.Options.UseTextOptions = true;
            this.GCHadGanob.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHadGanob.AppearanceHeader.Options.UseTextOptions = true;
            this.GCHadGanob.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHadGanob.Caption = "الحد الجنوبي";
            this.GCHadGanob.FieldName = "HadGanob";
            this.GCHadGanob.Name = "GCHadGanob";
            this.GCHadGanob.OptionsColumn.AllowEdit = false;
            // 
            // GCTallGanob
            // 
            this.GCTallGanob.AppearanceCell.Options.UseTextOptions = true;
            this.GCTallGanob.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTallGanob.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTallGanob.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTallGanob.Caption = "الطول الجنوبي";
            this.GCTallGanob.ColumnEdit = this.repositoryItemCalcEditMy;
            this.GCTallGanob.FieldName = "TallGanob";
            this.GCTallGanob.Name = "GCTallGanob";
            this.GCTallGanob.OptionsColumn.AllowEdit = false;
            // 
            // GCHadshark
            // 
            this.GCHadshark.AppearanceCell.Options.UseTextOptions = true;
            this.GCHadshark.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHadshark.AppearanceHeader.Options.UseTextOptions = true;
            this.GCHadshark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHadshark.Caption = "الحد الشرقي";
            this.GCHadshark.FieldName = "Hadshark";
            this.GCHadshark.Name = "GCHadshark";
            this.GCHadshark.OptionsColumn.AllowEdit = false;
            // 
            // GCTallshark
            // 
            this.GCTallshark.AppearanceCell.Options.UseTextOptions = true;
            this.GCTallshark.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTallshark.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTallshark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTallshark.Caption = "الطول الشرقي";
            this.GCTallshark.ColumnEdit = this.repositoryItemCalcEditMy;
            this.GCTallshark.FieldName = "Tallshark";
            this.GCTallshark.Name = "GCTallshark";
            this.GCTallshark.OptionsColumn.AllowEdit = false;
            this.GCTallshark.Width = 77;
            // 
            // GCHadghrab
            // 
            this.GCHadghrab.AppearanceCell.Options.UseTextOptions = true;
            this.GCHadghrab.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHadghrab.AppearanceHeader.Options.UseTextOptions = true;
            this.GCHadghrab.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCHadghrab.Caption = "الحد الغربي";
            this.GCHadghrab.FieldName = "Hadghrab";
            this.GCHadghrab.Name = "GCHadghrab";
            this.GCHadghrab.OptionsColumn.AllowEdit = false;
            // 
            // GCTallghrab
            // 
            this.GCTallghrab.AppearanceCell.Options.UseTextOptions = true;
            this.GCTallghrab.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTallghrab.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTallghrab.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTallghrab.Caption = "الطول الغربي";
            this.GCTallghrab.ColumnEdit = this.repositoryItemCalcEditMy;
            this.GCTallghrab.FieldName = "Tallghrab";
            this.GCTallghrab.Name = "GCTallghrab";
            this.GCTallghrab.OptionsColumn.AllowEdit = false;
            // 
            // GCAera
            // 
            this.GCAera.AppearanceCell.Options.UseTextOptions = true;
            this.GCAera.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAera.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAera.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAera.Caption = "المساحه";
            this.GCAera.ColumnEdit = this.repositoryItemCalcEditMy;
            this.GCAera.FieldName = "Aera";
            this.GCAera.Name = "GCAera";
            this.GCAera.OptionsColumn.AllowEdit = false;
            this.GCAera.Visible = true;
            this.GCAera.VisibleIndex = 8;
            // 
            // GCMetrprice
            // 
            this.GCMetrprice.AppearanceCell.Options.UseTextOptions = true;
            this.GCMetrprice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMetrprice.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMetrprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMetrprice.Caption = "سعر المتر";
            this.GCMetrprice.ColumnEdit = this.repositoryItemCalcEditMy;
            this.GCMetrprice.FieldName = "Metrprice";
            this.GCMetrprice.Name = "GCMetrprice";
            this.GCMetrprice.OptionsColumn.AllowEdit = false;
            this.GCMetrprice.Visible = true;
            this.GCMetrprice.VisibleIndex = 9;
            // 
            // GCAllPrice
            // 
            this.GCAllPrice.AppearanceCell.Options.UseTextOptions = true;
            this.GCAllPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAllPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.GCAllPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCAllPrice.Caption = "السعر الكلي";
            this.GCAllPrice.ColumnEdit = this.repositoryItemCalcEditMy;
            this.GCAllPrice.FieldName = "AllPrice";
            this.GCAllPrice.Name = "GCAllPrice";
            this.GCAllPrice.OptionsColumn.AllowEdit = false;
            this.GCAllPrice.Visible = true;
            this.GCAllPrice.VisibleIndex = 10;
            // 
            // GCremark
            // 
            this.GCremark.AppearanceCell.Options.UseTextOptions = true;
            this.GCremark.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCremark.AppearanceHeader.Options.UseTextOptions = true;
            this.GCremark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCremark.Caption = "ملاحظات";
            this.GCremark.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.GCremark.FieldName = "remark";
            this.GCremark.Name = "GCremark";
            this.GCremark.OptionsColumn.AllowEdit = false;
            this.GCremark.Visible = true;
            this.GCremark.VisibleIndex = 11;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // GCimagepath1
            // 
            this.GCimagepath1.AppearanceCell.Options.UseTextOptions = true;
            this.GCimagepath1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCimagepath1.AppearanceHeader.Options.UseTextOptions = true;
            this.GCimagepath1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCimagepath1.Caption = "صوره1";
            this.GCimagepath1.ColumnEdit = this.repositoryItemButtonEditimagepath1;
            this.GCimagepath1.FieldName = "imagepath1";
            this.GCimagepath1.Name = "GCimagepath1";
            this.GCimagepath1.OptionsColumn.ReadOnly = true;
            this.GCimagepath1.Visible = true;
            this.GCimagepath1.VisibleIndex = 12;
            // 
            // repositoryItemButtonEditimagepath1
            // 
            this.repositoryItemButtonEditimagepath1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemButtonEditimagepath1.Name = "repositoryItemButtonEditimagepath1";
            this.repositoryItemButtonEditimagepath1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditimagepath1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditimagepath1_ButtonClick);
            // 
            // GCimagepath2
            // 
            this.GCimagepath2.AppearanceCell.Options.UseTextOptions = true;
            this.GCimagepath2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCimagepath2.AppearanceHeader.Options.UseTextOptions = true;
            this.GCimagepath2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCimagepath2.Caption = "صوره2";
            this.GCimagepath2.ColumnEdit = this.repositoryItemButtonEditimagepath2;
            this.GCimagepath2.FieldName = "imagepath2";
            this.GCimagepath2.Name = "GCimagepath2";
            this.GCimagepath2.OptionsColumn.ReadOnly = true;
            this.GCimagepath2.Visible = true;
            this.GCimagepath2.VisibleIndex = 13;
            // 
            // repositoryItemButtonEditimagepath2
            // 
            this.repositoryItemButtonEditimagepath2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemButtonEditimagepath2.Name = "repositoryItemButtonEditimagepath2";
            this.repositoryItemButtonEditimagepath2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditimagepath2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditimagepath2_ButtonClick);
            // 
            // GCdatein
            // 
            this.GCdatein.AppearanceCell.Options.UseTextOptions = true;
            this.GCdatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCdatein.AppearanceHeader.Options.UseTextOptions = true;
            this.GCdatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCdatein.Caption = "تاريخ الادخال";
            this.GCdatein.ColumnEdit = this.repositoryItemDateEditMy;
            this.GCdatein.FieldName = "datein";
            this.GCdatein.Name = "GCdatein";
            this.GCdatein.OptionsColumn.AllowEdit = false;
            // 
            // GCUserName
            // 
            this.GCUserName.AppearanceCell.Options.UseTextOptions = true;
            this.GCUserName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCUserName.AppearanceHeader.Options.UseTextOptions = true;
            this.GCUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCUserName.Caption = "مدخل البيانات";
            this.GCUserName.FieldName = "UserName";
            this.GCUserName.Name = "GCUserName";
            this.GCUserName.OptionsColumn.AllowEdit = false;
            // 
            // QryTblEstateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.gridControlQry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QryTblEstateFrm";
            this.Text = "استعلام العقارات";
            this.Load += new System.EventHandler(this.QryTblEstateFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditMy.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditMy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditMy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditimagepath1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditimagepath2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlQry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewQry;
        private DevExpress.XtraGrid.Columns.GridColumn GCEstateId;
        private DevExpress.XtraGrid.Columns.GridColumn GCshow;
        private DevExpress.XtraGrid.Columns.GridColumn GCOwner;
        private DevExpress.XtraGrid.Columns.GridColumn GCsakdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditMy;
        private DevExpress.XtraGrid.Columns.GridColumn GCEstateCase;
        private DevExpress.XtraGrid.Columns.GridColumn GCCdArea;
        private DevExpress.XtraGrid.Columns.GridColumn GCEstateAge;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditMy;
        private DevExpress.XtraGrid.Columns.GridColumn GCEstateAdderss;
        private DevExpress.XtraGrid.Columns.GridColumn GCStreetNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCHadShmal;
        private DevExpress.XtraGrid.Columns.GridColumn GCTallshmal;
        private DevExpress.XtraGrid.Columns.GridColumn GCHadGanob;
        private DevExpress.XtraGrid.Columns.GridColumn GCTallGanob;
        private DevExpress.XtraGrid.Columns.GridColumn GCHadshark;
        private DevExpress.XtraGrid.Columns.GridColumn GCTallshark;
        private DevExpress.XtraGrid.Columns.GridColumn GCHadghrab;
        private DevExpress.XtraGrid.Columns.GridColumn GCTallghrab;
        private DevExpress.XtraGrid.Columns.GridColumn GCAera;
        private DevExpress.XtraGrid.Columns.GridColumn GCMetrprice;
        private DevExpress.XtraGrid.Columns.GridColumn GCAllPrice;
        private DevExpress.XtraGrid.Columns.GridColumn GCremark;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn GCimagepath1;
        private DevExpress.XtraGrid.Columns.GridColumn GCimagepath2;
        private DevExpress.XtraGrid.Columns.GridColumn GCdatein;
        private DevExpress.XtraGrid.Columns.GridColumn GCUserName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditimagepath1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditimagepath2;
    }
}