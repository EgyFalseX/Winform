namespace Members
{
    partial class Qry17Frm
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
            this.qry17BindingSource = new System.Windows.Forms.BindingSource();
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestefaa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditchk = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colestefareson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colhafzaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhafzadate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colJobtitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrekeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalhafza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalprint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprintdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrheldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkeduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserprint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserrev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinaluser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.qry17TableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.Qry17TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry17BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditchk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
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
            this.gridControlData.DataSource = this.qry17BindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDMY,
            this.repositoryItemCheckEditchk,
            this.repositoryItemMemoEdit1});
            this.gridControlData.Size = new System.Drawing.Size(734, 409);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // qry17BindingSource
            // 
            this.qry17BindingSource.DataMember = "Qry17";
            this.qry17BindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colMemberName,
            this.colKideNumber,
            this.colSyndicate,
            this.colSubCommitte,
            this.colestefaa,
            this.colestefareson,
            this.colhafzaid,
            this.colhafzadate,
            this.colJobtitle,
            this.colrekeed,
            this.colclosed,
            this.colesalhafza,
            this.colesalprint,
            this.colprintdate,
            this.coltrheldate,
            this.colkeduser,
            this.coluserprint,
            this.coluserrev,
            this.colfinaluser});
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
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colMemberName
            // 
            this.colMemberName.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName.Caption = "اسم العضو";
            this.colMemberName.FieldName = "MemberName";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 0;
            this.colMemberName.Width = 134;
            // 
            // colKideNumber
            // 
            this.colKideNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colKideNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKideNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colKideNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKideNumber.Caption = "رقم القيد";
            this.colKideNumber.FieldName = "KideNumber";
            this.colKideNumber.Name = "colKideNumber";
            this.colKideNumber.Visible = true;
            this.colKideNumber.VisibleIndex = 1;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "الفرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 2;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "اللجنة";
            this.colSubCommitte.FieldName = "SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 3;
            // 
            // colestefaa
            // 
            this.colestefaa.AppearanceCell.Options.UseTextOptions = true;
            this.colestefaa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestefaa.AppearanceHeader.Options.UseTextOptions = true;
            this.colestefaa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestefaa.Caption = "استيفاء";
            this.colestefaa.ColumnEdit = this.repositoryItemCheckEditchk;
            this.colestefaa.FieldName = "estefaa";
            this.colestefaa.Name = "colestefaa";
            this.colestefaa.Visible = true;
            this.colestefaa.VisibleIndex = 4;
            // 
            // repositoryItemCheckEditchk
            // 
            this.repositoryItemCheckEditchk.AutoHeight = false;
            this.repositoryItemCheckEditchk.Name = "repositoryItemCheckEditchk";
            // 
            // colestefareson
            // 
            this.colestefareson.AppearanceCell.Options.UseTextOptions = true;
            this.colestefareson.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestefareson.AppearanceHeader.Options.UseTextOptions = true;
            this.colestefareson.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestefareson.Caption = "سبب الاستيفاء";
            this.colestefareson.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colestefareson.FieldName = "estefareson";
            this.colestefareson.Name = "colestefareson";
            this.colestefareson.Visible = true;
            this.colestefareson.VisibleIndex = 5;
            this.colestefareson.Width = 89;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colhafzaid
            // 
            this.colhafzaid.AppearanceCell.Options.UseTextOptions = true;
            this.colhafzaid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzaid.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafzaid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzaid.Caption = "رقم الحافظة";
            this.colhafzaid.FieldName = "hafzaid";
            this.colhafzaid.Name = "colhafzaid";
            this.colhafzaid.Visible = true;
            this.colhafzaid.VisibleIndex = 6;
            // 
            // colhafzadate
            // 
            this.colhafzadate.AppearanceCell.Options.UseTextOptions = true;
            this.colhafzadate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzadate.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafzadate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzadate.Caption = "تاريخ الحافظة";
            this.colhafzadate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colhafzadate.FieldName = "hafzadate";
            this.colhafzadate.Name = "colhafzadate";
            this.colhafzadate.Visible = true;
            this.colhafzadate.VisibleIndex = 7;
            this.colhafzadate.Width = 78;
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
            // colJobtitle
            // 
            this.colJobtitle.AppearanceCell.Options.UseTextOptions = true;
            this.colJobtitle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobtitle.AppearanceHeader.Options.UseTextOptions = true;
            this.colJobtitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobtitle.Caption = "الوظيفة";
            this.colJobtitle.FieldName = "Jobtitle";
            this.colJobtitle.Name = "colJobtitle";
            this.colJobtitle.Visible = true;
            this.colJobtitle.VisibleIndex = 8;
            // 
            // colrekeed
            // 
            this.colrekeed.AppearanceCell.Options.UseTextOptions = true;
            this.colrekeed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrekeed.AppearanceHeader.Options.UseTextOptions = true;
            this.colrekeed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrekeed.Caption = "مراجعة القيد";
            this.colrekeed.ColumnEdit = this.repositoryItemCheckEditchk;
            this.colrekeed.FieldName = "rekeed";
            this.colrekeed.Name = "colrekeed";
            this.colrekeed.Visible = true;
            this.colrekeed.VisibleIndex = 9;
            this.colrekeed.Width = 77;
            // 
            // colclosed
            // 
            this.colclosed.AppearanceCell.Options.UseTextOptions = true;
            this.colclosed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colclosed.AppearanceHeader.Options.UseTextOptions = true;
            this.colclosed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colclosed.Caption = "مغلق";
            this.colclosed.ColumnEdit = this.repositoryItemCheckEditchk;
            this.colclosed.FieldName = "closed";
            this.colclosed.Name = "colclosed";
            this.colclosed.Visible = true;
            this.colclosed.VisibleIndex = 10;
            // 
            // colesalhafza
            // 
            this.colesalhafza.AppearanceCell.Options.UseTextOptions = true;
            this.colesalhafza.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalhafza.AppearanceHeader.Options.UseTextOptions = true;
            this.colesalhafza.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalhafza.Caption = "ايصال الحافظة";
            this.colesalhafza.FieldName = "esalhafza";
            this.colesalhafza.Name = "colesalhafza";
            this.colesalhafza.Visible = true;
            this.colesalhafza.VisibleIndex = 11;
            this.colesalhafza.Width = 82;
            // 
            // colesalprint
            // 
            this.colesalprint.AppearanceCell.Options.UseTextOptions = true;
            this.colesalprint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalprint.AppearanceHeader.Options.UseTextOptions = true;
            this.colesalprint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalprint.Caption = "ايصال الطباعة";
            this.colesalprint.FieldName = "esalprint";
            this.colesalprint.Name = "colesalprint";
            this.colesalprint.Visible = true;
            this.colesalprint.VisibleIndex = 12;
            this.colesalprint.Width = 81;
            // 
            // colprintdate
            // 
            this.colprintdate.AppearanceCell.Options.UseTextOptions = true;
            this.colprintdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprintdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colprintdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprintdate.Caption = "تاريخ الطباعة";
            this.colprintdate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colprintdate.FieldName = "printdate";
            this.colprintdate.Name = "colprintdate";
            this.colprintdate.Visible = true;
            this.colprintdate.VisibleIndex = 13;
            this.colprintdate.Width = 77;
            // 
            // coltrheldate
            // 
            this.coltrheldate.AppearanceCell.Options.UseTextOptions = true;
            this.coltrheldate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrheldate.AppearanceHeader.Options.UseTextOptions = true;
            this.coltrheldate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrheldate.Caption = "تاريخ الترحيل";
            this.coltrheldate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.coltrheldate.FieldName = "trheldate";
            this.coltrheldate.Name = "coltrheldate";
            this.coltrheldate.Visible = true;
            this.coltrheldate.VisibleIndex = 14;
            this.coltrheldate.Width = 77;
            // 
            // colkeduser
            // 
            this.colkeduser.AppearanceCell.Options.UseTextOptions = true;
            this.colkeduser.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkeduser.AppearanceHeader.Options.UseTextOptions = true;
            this.colkeduser.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkeduser.Caption = "مسئول تعديل رقم القيد";
            this.colkeduser.FieldName = "keduser";
            this.colkeduser.Name = "colkeduser";
            this.colkeduser.Visible = true;
            this.colkeduser.VisibleIndex = 15;
            this.colkeduser.Width = 127;
            // 
            // coluserprint
            // 
            this.coluserprint.AppearanceCell.Options.UseTextOptions = true;
            this.coluserprint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserprint.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserprint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserprint.Caption = "مسئول الطباعة";
            this.coluserprint.FieldName = "userprint";
            this.coluserprint.Name = "coluserprint";
            this.coluserprint.Visible = true;
            this.coluserprint.VisibleIndex = 16;
            this.coluserprint.Width = 90;
            // 
            // coluserrev
            // 
            this.coluserrev.AppearanceCell.Options.UseTextOptions = true;
            this.coluserrev.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserrev.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserrev.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserrev.Caption = "مراجع معلومات";
            this.coluserrev.FieldName = "userrev";
            this.coluserrev.Name = "coluserrev";
            this.coluserrev.Visible = true;
            this.coluserrev.VisibleIndex = 17;
            this.coluserrev.Width = 88;
            // 
            // colfinaluser
            // 
            this.colfinaluser.AppearanceCell.Options.UseTextOptions = true;
            this.colfinaluser.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfinaluser.AppearanceHeader.Options.UseTextOptions = true;
            this.colfinaluser.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfinaluser.Caption = "مراجع نهائي";
            this.colfinaluser.FieldName = "finaluser";
            this.colfinaluser.Name = "colfinaluser";
            this.colfinaluser.Visible = true;
            this.colfinaluser.VisibleIndex = 18;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(734, 47);
            this.panelControl1.TabIndex = 2;
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
            // qry17TableAdapter
            // 
            this.qry17TableAdapter.ClearBeforeFill = true;
            // 
            // Qry17Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry17Frm";
            this.Text = "اعضاء الويب";
            this.Load += new System.EventHandler(this.QryTblAhteatyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry17BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditchk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource qry17BindingSource;
        private DataSources.dsTeachersUnionTableAdapters.Qry17TableAdapter qry17TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colestefaa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditchk;
        private DevExpress.XtraGrid.Columns.GridColumn colestefareson;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colhafzaid;
        private DevExpress.XtraGrid.Columns.GridColumn colhafzadate;
        private DevExpress.XtraGrid.Columns.GridColumn colJobtitle;
        private DevExpress.XtraGrid.Columns.GridColumn colrekeed;
        private DevExpress.XtraGrid.Columns.GridColumn colclosed;
        private DevExpress.XtraGrid.Columns.GridColumn colesalhafza;
        private DevExpress.XtraGrid.Columns.GridColumn colesalprint;
        private DevExpress.XtraGrid.Columns.GridColumn colprintdate;
        private DevExpress.XtraGrid.Columns.GridColumn coltrheldate;
        private DevExpress.XtraGrid.Columns.GridColumn colkeduser;
        private DevExpress.XtraGrid.Columns.GridColumn coluserprint;
        private DevExpress.XtraGrid.Columns.GridColumn coluserrev;
        private DevExpress.XtraGrid.Columns.GridColumn colfinaluser;

    }
}