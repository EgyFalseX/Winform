namespace Members
{
    partial class TBLPrintCardFawryFrm
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
            this.groupControlView = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.printCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcheckforprint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberShipNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardtype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditcardtype = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupControlCommand = new DevExpress.XtraEditors.GroupControl();
            this.btnChooseNo = new DevExpress.XtraEditors.ButtonEdit();
            this.CEAll = new DevExpress.XtraEditors.CheckEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lueSyndicateId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printCardsTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.PrintCardsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlView)).BeginInit();
            this.groupControlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditcardtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCommand)).BeginInit();
            this.groupControlCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChooseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlView
            // 
            this.groupControlView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlView.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlView.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlView.Controls.Add(this.gridControlData);
            this.groupControlView.Location = new System.Drawing.Point(12, 76);
            this.groupControlView.Name = "groupControlView";
            this.groupControlView.Size = new System.Drawing.Size(760, 252);
            this.groupControlView.TabIndex = 1;
            this.groupControlView.Text = "الاعضــــــــــــــــــاء";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.printCardsBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditcardtype});
            this.gridControlData.Size = new System.Drawing.Size(756, 229);
            this.gridControlData.TabIndex = 6;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // printCardsBindingSource
            // 
            this.printCardsBindingSource.DataMember = "PrintCards";
            this.printCardsBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcheckforprint,
            this.colesalno,
            this.colInstallment,
            this.colMemberName,
            this.colKideNumber,
            this.colMemberShipNumber,
            this.coldateend,
            this.colSyndicate,
            this.colSubCommitte,
            this.colcardtype});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            // 
            // colcheckforprint
            // 
            this.colcheckforprint.AppearanceCell.Options.UseTextOptions = true;
            this.colcheckforprint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcheckforprint.AppearanceHeader.Options.UseTextOptions = true;
            this.colcheckforprint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcheckforprint.Caption = "طباعة";
            this.colcheckforprint.FieldName = "checkforprint";
            this.colcheckforprint.Name = "colcheckforprint";
            this.colcheckforprint.Visible = true;
            this.colcheckforprint.VisibleIndex = 0;
            this.colcheckforprint.Width = 49;
            // 
            // colesalno
            // 
            this.colesalno.AppearanceCell.Options.UseTextOptions = true;
            this.colesalno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalno.AppearanceHeader.Options.UseTextOptions = true;
            this.colesalno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colesalno.Caption = "رقم الايصال";
            this.colesalno.FieldName = "esalno";
            this.colesalno.Name = "colesalno";
            this.colesalno.OptionsColumn.ReadOnly = true;
            this.colesalno.Visible = true;
            this.colesalno.VisibleIndex = 1;
            // 
            // colInstallment
            // 
            this.colInstallment.AppearanceCell.Options.UseTextOptions = true;
            this.colInstallment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInstallment.AppearanceHeader.Options.UseTextOptions = true;
            this.colInstallment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInstallment.Caption = "تقسيط";
            this.colInstallment.FieldName = "Installment";
            this.colInstallment.Name = "colInstallment";
            this.colInstallment.OptionsColumn.ReadOnly = true;
            this.colInstallment.Visible = true;
            this.colInstallment.VisibleIndex = 3;
            // 
            // colMemberName
            // 
            this.colMemberName.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberName.Caption = "الاسم";
            this.colMemberName.FieldName = "MemberName";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.OptionsColumn.ReadOnly = true;
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 4;
            this.colMemberName.Width = 118;
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
            this.colKideNumber.OptionsColumn.ReadOnly = true;
            this.colKideNumber.Visible = true;
            this.colKideNumber.VisibleIndex = 5;
            // 
            // colMemberShipNumber
            // 
            this.colMemberShipNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberShipNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberShipNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberShipNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberShipNumber.Caption = "رقم العضوية";
            this.colMemberShipNumber.FieldName = "MemberShipNumber";
            this.colMemberShipNumber.Name = "colMemberShipNumber";
            this.colMemberShipNumber.OptionsColumn.ReadOnly = true;
            this.colMemberShipNumber.Visible = true;
            this.colMemberShipNumber.VisibleIndex = 6;
            // 
            // coldateend
            // 
            this.coldateend.AppearanceCell.Options.UseTextOptions = true;
            this.coldateend.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateend.AppearanceHeader.Options.UseTextOptions = true;
            this.coldateend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateend.Caption = "تاريخ الانتهاء";
            this.coldateend.FieldName = "dateend";
            this.coldateend.Name = "coldateend";
            this.coldateend.OptionsColumn.ReadOnly = true;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "النقابة";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.OptionsColumn.ReadOnly = true;
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 7;
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
            this.colSubCommitte.OptionsColumn.ReadOnly = true;
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 8;
            // 
            // colcardtype
            // 
            this.colcardtype.AppearanceCell.Options.UseTextOptions = true;
            this.colcardtype.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcardtype.AppearanceHeader.Options.UseTextOptions = true;
            this.colcardtype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcardtype.Caption = "نوع العضوية";
            this.colcardtype.ColumnEdit = this.repositoryItemLookUpEditcardtype;
            this.colcardtype.FieldName = "cardtype";
            this.colcardtype.Name = "colcardtype";
            this.colcardtype.OptionsColumn.ReadOnly = true;
            this.colcardtype.Visible = true;
            this.colcardtype.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditcardtype
            // 
            this.repositoryItemLookUpEditcardtype.AutoHeight = false;
            this.repositoryItemLookUpEditcardtype.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditcardtype.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "النوع", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.repositoryItemLookUpEditcardtype.Name = "repositoryItemLookUpEditcardtype";
            this.repositoryItemLookUpEditcardtype.NullText = "";
            // 
            // groupControlCommand
            // 
            this.groupControlCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlCommand.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlCommand.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlCommand.Controls.Add(this.btnChooseNo);
            this.groupControlCommand.Controls.Add(this.CEAll);
            this.groupControlCommand.Controls.Add(this.btnPrint);
            this.groupControlCommand.Location = new System.Drawing.Point(14, 334);
            this.groupControlCommand.Name = "groupControlCommand";
            this.groupControlCommand.Size = new System.Drawing.Size(756, 66);
            this.groupControlCommand.TabIndex = 2;
            this.groupControlCommand.Text = "العمليــــــــــــــــــــــات";
            // 
            // btnChooseNo
            // 
            this.btnChooseNo.EditValue = "50";
            this.btnChooseNo.Location = new System.Drawing.Point(20, 41);
            this.btnChooseNo.Name = "btnChooseNo";
            this.btnChooseNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.btnChooseNo.Size = new System.Drawing.Size(100, 20);
            this.btnChooseNo.TabIndex = 4;
            this.btnChooseNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnChooseNo_ButtonClick);
            // 
            // CEAll
            // 
            this.CEAll.Location = new System.Drawing.Point(18, 23);
            this.CEAll.Name = "CEAll";
            this.CEAll.Properties.Caption = "اختيار الكـــل";
            this.CEAll.Size = new System.Drawing.Size(87, 19);
            this.CEAll.TabIndex = 3;
            this.CEAll.CheckedChanged += new System.EventHandler(this.CEAll_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(589, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = " طباعـــــــــه";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.lueSyndicateId);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(756, 58);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "خيارات";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(707, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "الفرعيه";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(22, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lueSyndicateId
            // 
            this.lueSyndicateId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lueSyndicateId.Location = new System.Drawing.Point(451, 31);
            this.lueSyndicateId.Name = "lueSyndicateId";
            this.lueSyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyndicateId.Properties.NullText = "";
            this.lueSyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyndicateId.Properties.View = this.gridLookUpEdit1View;
            this.lueSyndicateId.Size = new System.Drawing.Size(250, 20);
            this.lueSyndicateId.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "الاسم";
            this.gridColumn10.FieldName = "Syndicate";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // printCardsTableAdapter
            // 
            this.printCardsTableAdapter.ClearBeforeFill = true;
            // 
            // TBLPrintCardFawryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControlCommand);
            this.Controls.Add(this.groupControlView);
            this.Name = "TBLPrintCardFawryFrm";
            this.Text = "طباعة الكارنيهات الفوري";
            this.Load += new System.EventHandler(this.TBLPrintCardFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlView)).EndInit();
            this.groupControlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditcardtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCommand)).EndInit();
            this.groupControlCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChooseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlView;
        private DevExpress.XtraEditors.GroupControl groupControlCommand;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.CheckEdit CEAll;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.GridLookUpEdit lueSyndicateId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.ButtonEdit btnChooseNo;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource printCardsBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.PrintCardsTableAdapter printCardsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberShipNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno;
        private DevExpress.XtraGrid.Columns.GridColumn colcheckforprint;
        private DevExpress.XtraGrid.Columns.GridColumn coldateend;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallment;
        private DevExpress.XtraGrid.Columns.GridColumn colcardtype;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditcardtype;
    }
}