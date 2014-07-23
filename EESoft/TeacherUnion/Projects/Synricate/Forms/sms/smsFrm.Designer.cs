namespace Synricate
{
    partial class smsFrm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smsFrm));
            this.gridViewMessages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCMessagesnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCMessagesmessageBody = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCMessagesstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCMessagesSendTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.GCMessagesUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSettingUse = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCMessageSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCMessagesDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSettingDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.CMSdataschool = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCTemplateTemplateBody = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTemplateSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTemplateUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTemplateDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewTBLSCommitteMember = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditstu_code = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridViewExcel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewSetting = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCServiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCSettingSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCSettingUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCSettingDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navbarImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.USBserialPort = new System.IO.Ports.SerialPort(this.components);
            this.navbarImageList = new System.Windows.Forms.ImageList(this.components);
            this.TmrSignal = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMember = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTemplate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMSG = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSetting = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDisconnect = new DevExpress.XtraEditors.SimpleButton();
            this.PnlConnection = new DevExpress.XtraEditors.PanelControl();
            this.LblDeviceName = new DevExpress.XtraEditors.LabelControl();
            this.TxtServiceNum = new DevExpress.XtraEditors.TextEdit();
            this.BtnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CBEPort = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PBSignal = new DevExpress.XtraEditors.ProgressBarControl();
            this.PnlSend = new DevExpress.XtraEditors.PanelControl();
            this.BtnDelSendTo = new DevExpress.XtraEditors.DropDownButton();
            this.PBSend = new DevExpress.XtraEditors.ProgressBarControl();
            this.LblMsgCounter = new System.Windows.Forms.Label();
            this.LblCharCounter = new System.Windows.Forms.Label();
            this.BtnSaveMsg = new DevExpress.XtraEditors.SimpleButton();
            this.CBAddVar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.LBCSendTo = new DevExpress.XtraEditors.ListBoxControl();
            this.TxtMsg = new DevExpress.XtraEditors.MemoEdit();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSettingUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSettingDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            this.CMSdataschool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLSCommitteMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditstu_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlConnection)).BeginInit();
            this.PnlConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServiceNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBEPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSignal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlSend)).BeginInit();
            this.PnlSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAddVar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBCSendTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMsg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewMessages
            // 
            this.gridViewMessages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewMessages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCMessagesnumber,
            this.GCMessagesmessageBody,
            this.GCMessagesstatus,
            this.GCMessagesSendTime,
            this.GCMessagesUse,
            this.GCMessageSave,
            this.GCMessagesDel});
            this.gridViewMessages.GridControl = this.gridControlMain;
            this.gridViewMessages.Name = "gridViewMessages";
            this.gridViewMessages.OptionsView.ColumnAutoWidth = false;
            // 
            // GCMessagesnumber
            // 
            this.GCMessagesnumber.AppearanceCell.Options.UseTextOptions = true;
            this.GCMessagesnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMessagesnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesnumber.Caption = "المرسل اليه";
            this.GCMessagesnumber.FieldName = "number";
            this.GCMessagesnumber.Name = "GCMessagesnumber";
            this.GCMessagesnumber.Visible = true;
            this.GCMessagesnumber.VisibleIndex = 0;
            this.GCMessagesnumber.Width = 107;
            // 
            // GCMessagesmessageBody
            // 
            this.GCMessagesmessageBody.AppearanceCell.Options.UseTextOptions = true;
            this.GCMessagesmessageBody.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesmessageBody.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GCMessagesmessageBody.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMessagesmessageBody.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesmessageBody.Caption = "تفاصي الرساله";
            this.GCMessagesmessageBody.FieldName = "messageBody";
            this.GCMessagesmessageBody.Name = "GCMessagesmessageBody";
            this.GCMessagesmessageBody.Visible = true;
            this.GCMessagesmessageBody.VisibleIndex = 1;
            this.GCMessagesmessageBody.Width = 299;
            // 
            // GCMessagesstatus
            // 
            this.GCMessagesstatus.AppearanceCell.Options.UseTextOptions = true;
            this.GCMessagesstatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesstatus.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMessagesstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesstatus.Caption = "الحاله";
            this.GCMessagesstatus.FieldName = "status";
            this.GCMessagesstatus.Name = "GCMessagesstatus";
            this.GCMessagesstatus.Visible = true;
            this.GCMessagesstatus.VisibleIndex = 2;
            this.GCMessagesstatus.Width = 99;
            // 
            // GCMessagesSendTime
            // 
            this.GCMessagesSendTime.AppearanceCell.Options.UseTextOptions = true;
            this.GCMessagesSendTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesSendTime.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMessagesSendTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesSendTime.Caption = "التاريخ";
            this.GCMessagesSendTime.ColumnEdit = this.repositoryItemDateEditDate;
            this.GCMessagesSendTime.FieldName = "SendTime";
            this.GCMessagesSendTime.Name = "GCMessagesSendTime";
            this.GCMessagesSendTime.Visible = true;
            this.GCMessagesSendTime.VisibleIndex = 3;
            this.GCMessagesSendTime.Width = 90;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // GCMessagesUse
            // 
            this.GCMessagesUse.AppearanceCell.Options.UseTextOptions = true;
            this.GCMessagesUse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesUse.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMessagesUse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesUse.Caption = "استخدام";
            this.GCMessagesUse.ColumnEdit = this.repositoryItemButtonEditSettingUse;
            this.GCMessagesUse.Name = "GCMessagesUse";
            this.GCMessagesUse.Visible = true;
            this.GCMessagesUse.VisibleIndex = 4;
            this.GCMessagesUse.Width = 106;
            // 
            // repositoryItemButtonEditSettingUse
            // 
            this.repositoryItemButtonEditSettingUse.AutoHeight = false;
            this.repositoryItemButtonEditSettingUse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemButtonEditSettingUse.Name = "repositoryItemButtonEditSettingUse";
            this.repositoryItemButtonEditSettingUse.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSettingUse.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSettingUse_ButtonClick);
            // 
            // GCMessageSave
            // 
            this.GCMessageSave.AppearanceCell.Options.UseTextOptions = true;
            this.GCMessageSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessageSave.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMessageSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessageSave.Caption = "حفظ";
            this.GCMessageSave.ColumnEdit = this.repositoryItemButtonEditSave;
            this.GCMessageSave.Name = "GCMessageSave";
            this.GCMessageSave.Visible = true;
            this.GCMessageSave.VisibleIndex = 5;
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
            // GCMessagesDel
            // 
            this.GCMessagesDel.AppearanceCell.Options.UseTextOptions = true;
            this.GCMessagesDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesDel.AppearanceHeader.Options.UseTextOptions = true;
            this.GCMessagesDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCMessagesDel.Caption = "حذف";
            this.GCMessagesDel.ColumnEdit = this.repositoryItemButtonEditSettingDel;
            this.GCMessagesDel.Name = "GCMessagesDel";
            this.GCMessagesDel.Visible = true;
            this.GCMessagesDel.VisibleIndex = 6;
            // 
            // repositoryItemButtonEditSettingDel
            // 
            this.repositoryItemButtonEditSettingDel.AutoHeight = false;
            this.repositoryItemButtonEditSettingDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditSettingDel.Name = "repositoryItemButtonEditSettingDel";
            this.repositoryItemButtonEditSettingDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSettingDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSettingDel_ButtonClick);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.ContextMenuStrip = this.CMSdataschool;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode1.LevelTemplate = this.gridViewMessages;
            gridLevelNode1.RelationName = "Level2";
            gridLevelNode2.LevelTemplate = this.gridViewTemplates;
            gridLevelNode2.RelationName = "Level3";
            gridLevelNode3.LevelTemplate = this.gridViewTBLSCommitteMember;
            gridLevelNode3.RelationName = "Level11";
            gridLevelNode4.LevelTemplate = this.gridViewExcel;
            gridLevelNode4.RelationName = "Level1";
            this.gridControlMain.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3,
            gridLevelNode4});
            this.gridControlMain.Location = new System.Drawing.Point(0, 267);
            this.gridControlMain.MainView = this.gridViewSetting;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSettingUse,
            this.repositoryItemButtonEditSettingDel,
            this.repositoryItemDateEditDate,
            this.repositoryItemButtonEditSave,
            this.repositoryItemCheckEditstu_code});
            this.gridControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlMain.Size = new System.Drawing.Size(784, 283);
            this.gridControlMain.TabIndex = 7;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTemplates,
            this.gridViewTBLSCommitteMember,
            this.gridViewExcel,
            this.gridViewSetting,
            this.gridViewMessages});
            // 
            // CMSdataschool
            // 
            this.CMSdataschool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSelectAll,
            this.toolStripSeparator1,
            this.toolStripMenuItemAdd});
            this.CMSdataschool.Name = "CMSdataschool";
            this.CMSdataschool.ShowImageMargin = false;
            this.CMSdataschool.Size = new System.Drawing.Size(100, 54);
            this.CMSdataschool.Opening += new System.ComponentModel.CancelEventHandler(this.CMSdataschool_Opening);
            // 
            // toolStripMenuItemSelectAll
            // 
            this.toolStripMenuItemSelectAll.Name = "toolStripMenuItemSelectAll";
            this.toolStripMenuItemSelectAll.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItemSelectAll.Text = "اختيار الكل";
            this.toolStripMenuItemSelectAll.Click += new System.EventHandler(this.toolStripMenuItemSelectAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItemAdd.Text = "اضافة";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // gridViewTemplates
            // 
            this.gridViewTemplates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCTemplateTemplateBody,
            this.GCTemplateSave,
            this.GCTemplateUse,
            this.GCTemplateDel});
            this.gridViewTemplates.GridControl = this.gridControlMain;
            this.gridViewTemplates.Name = "gridViewTemplates";
            this.gridViewTemplates.OptionsView.ColumnAutoWidth = false;
            // 
            // GCTemplateTemplateBody
            // 
            this.GCTemplateTemplateBody.AppearanceCell.Options.UseTextOptions = true;
            this.GCTemplateTemplateBody.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTemplateTemplateBody.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTemplateTemplateBody.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTemplateTemplateBody.Caption = "نص الرساله";
            this.GCTemplateTemplateBody.FieldName = "TemplateBody";
            this.GCTemplateTemplateBody.Name = "GCTemplateTemplateBody";
            this.GCTemplateTemplateBody.Visible = true;
            this.GCTemplateTemplateBody.VisibleIndex = 0;
            this.GCTemplateTemplateBody.Width = 389;
            // 
            // GCTemplateSave
            // 
            this.GCTemplateSave.AppearanceCell.Options.UseTextOptions = true;
            this.GCTemplateSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTemplateSave.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTemplateSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTemplateSave.Caption = "حفظ";
            this.GCTemplateSave.ColumnEdit = this.repositoryItemButtonEditSave;
            this.GCTemplateSave.Name = "GCTemplateSave";
            this.GCTemplateSave.Visible = true;
            this.GCTemplateSave.VisibleIndex = 2;
            this.GCTemplateSave.Width = 110;
            // 
            // GCTemplateUse
            // 
            this.GCTemplateUse.AppearanceCell.Options.UseTextOptions = true;
            this.GCTemplateUse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTemplateUse.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTemplateUse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTemplateUse.Caption = "استخدام";
            this.GCTemplateUse.ColumnEdit = this.repositoryItemButtonEditSettingUse;
            this.GCTemplateUse.Name = "GCTemplateUse";
            this.GCTemplateUse.Visible = true;
            this.GCTemplateUse.VisibleIndex = 1;
            this.GCTemplateUse.Width = 88;
            // 
            // GCTemplateDel
            // 
            this.GCTemplateDel.AppearanceCell.Options.UseTextOptions = true;
            this.GCTemplateDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTemplateDel.AppearanceHeader.Options.UseTextOptions = true;
            this.GCTemplateDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCTemplateDel.Caption = "حذف";
            this.GCTemplateDel.ColumnEdit = this.repositoryItemButtonEditSettingDel;
            this.GCTemplateDel.Name = "GCTemplateDel";
            this.GCTemplateDel.Visible = true;
            this.GCTemplateDel.VisibleIndex = 3;
            this.GCTemplateDel.Width = 82;
            // 
            // gridViewTBLSCommitteMember
            // 
            this.gridViewTBLSCommitteMember.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn23,
            this.gridColumn24});
            this.gridViewTBLSCommitteMember.GridControl = this.gridControlMain;
            this.gridViewTBLSCommitteMember.Name = "gridViewTBLSCommitteMember";
            this.gridViewTBLSCommitteMember.OptionsView.ColumnAutoWidth = false;
            this.gridViewTBLSCommitteMember.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridViewTBLSCommitteMember.OptionsView.ShowFooter = true;
            // 
            // gridColumn19
            // 
            this.gridColumn19.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn19.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn19.Caption = "الاسم";
            this.gridColumn19.FieldName = "MemberName";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            this.gridColumn19.Width = 87;
            // 
            // gridColumn20
            // 
            this.gridColumn20.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn20.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn20.Caption = "اللجنه النقابيه";
            this.gridColumn20.FieldName = "SubCommitte";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn21.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn21.Caption = "اللجنه النوعيه";
            this.gridColumn21.FieldName = "LagnaNoaeaName";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            this.gridColumn21.Width = 161;
            // 
            // gridColumn22
            // 
            this.gridColumn22.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn22.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn22.Caption = "الوظيفه";
            this.gridColumn22.FieldName = "CommittejopName";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 3;
            this.gridColumn22.Width = 95;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "بداية العمل";
            this.gridColumn2.FieldName = "workstartdate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "نهاية العمل";
            this.gridColumn3.FieldName = "workenddate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            // 
            // gridColumn23
            // 
            this.gridColumn23.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn23.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn23.Caption = "الموبيل";
            this.gridColumn23.FieldName = "Membermobil";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 6;
            this.gridColumn23.Width = 100;
            // 
            // gridColumn24
            // 
            this.gridColumn24.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn24.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn24.Caption = "استخدام";
            this.gridColumn24.ColumnEdit = this.repositoryItemCheckEditstu_code;
            this.gridColumn24.FieldName = "checked";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 7;
            // 
            // repositoryItemCheckEditstu_code
            // 
            this.repositoryItemCheckEditstu_code.AutoHeight = false;
            this.repositoryItemCheckEditstu_code.DisplayValueChecked = "True";
            this.repositoryItemCheckEditstu_code.DisplayValueUnchecked = "False";
            this.repositoryItemCheckEditstu_code.Name = "repositoryItemCheckEditstu_code";
            this.repositoryItemCheckEditstu_code.ValueChecked = "True";
            this.repositoryItemCheckEditstu_code.ValueUnchecked = "False";
            // 
            // gridViewExcel
            // 
            this.gridViewExcel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4});
            this.gridViewExcel.GridControl = this.gridControlMain;
            this.gridViewExcel.Name = "gridViewExcel";
            this.gridViewExcel.OptionsView.ColumnAutoWidth = false;
            this.gridViewExcel.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridViewExcel.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "الموبيل";
            this.gridColumn1.FieldName = "mobile";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 230;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "استخدام";
            this.gridColumn4.ColumnEdit = this.repositoryItemCheckEditstu_code;
            this.gridColumn4.FieldName = "checked";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridViewSetting
            // 
            this.gridViewSetting.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCServiceNum,
            this.GCSettingSave,
            this.GCSettingUse,
            this.GCSettingDel});
            this.gridViewSetting.GridControl = this.gridControlMain;
            this.gridViewSetting.Name = "gridViewSetting";
            this.gridViewSetting.OptionsView.ColumnAutoWidth = false;
            // 
            // GCServiceNum
            // 
            this.GCServiceNum.AppearanceCell.Options.UseTextOptions = true;
            this.GCServiceNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCServiceNum.AppearanceHeader.Options.UseTextOptions = true;
            this.GCServiceNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCServiceNum.Caption = "رقم الخدمه للكارت";
            this.GCServiceNum.FieldName = "ServiceNum";
            this.GCServiceNum.Name = "GCServiceNum";
            this.GCServiceNum.Visible = true;
            this.GCServiceNum.VisibleIndex = 0;
            this.GCServiceNum.Width = 326;
            // 
            // GCSettingSave
            // 
            this.GCSettingSave.AppearanceCell.Options.UseTextOptions = true;
            this.GCSettingSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSettingSave.AppearanceHeader.Options.UseTextOptions = true;
            this.GCSettingSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSettingSave.Caption = "حفظ";
            this.GCSettingSave.ColumnEdit = this.repositoryItemButtonEditSave;
            this.GCSettingSave.Name = "GCSettingSave";
            this.GCSettingSave.Visible = true;
            this.GCSettingSave.VisibleIndex = 2;
            // 
            // GCSettingUse
            // 
            this.GCSettingUse.AppearanceCell.Options.UseTextOptions = true;
            this.GCSettingUse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSettingUse.AppearanceHeader.Options.UseTextOptions = true;
            this.GCSettingUse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSettingUse.Caption = "استخدام";
            this.GCSettingUse.ColumnEdit = this.repositoryItemButtonEditSettingUse;
            this.GCSettingUse.Name = "GCSettingUse";
            this.GCSettingUse.Visible = true;
            this.GCSettingUse.VisibleIndex = 1;
            this.GCSettingUse.Width = 148;
            // 
            // GCSettingDel
            // 
            this.GCSettingDel.AppearanceCell.Options.UseTextOptions = true;
            this.GCSettingDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSettingDel.AppearanceHeader.Options.UseTextOptions = true;
            this.GCSettingDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCSettingDel.Caption = "حذف";
            this.GCSettingDel.ColumnEdit = this.repositoryItemButtonEditSettingDel;
            this.GCSettingDel.Name = "GCSettingDel";
            this.GCSettingDel.Visible = true;
            this.GCSettingDel.VisibleIndex = 3;
            // 
            // navbarImageListLarge
            // 
            this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
            this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageListLarge.Images.SetKeyName(0, "Mail_32x32.png");
            this.navbarImageListLarge.Images.SetKeyName(1, "Organizer_32x32.png");
            this.navbarImageListLarge.Images.SetKeyName(2, "connect.png");
            this.navbarImageListLarge.Images.SetKeyName(3, "disconnect.png");
            this.navbarImageListLarge.Images.SetKeyName(4, "ports.png");
            this.navbarImageListLarge.Images.SetKeyName(5, "ServiceNo.png");
            this.navbarImageListLarge.Images.SetKeyName(6, "Send.png");
            this.navbarImageListLarge.Images.SetKeyName(7, "SaveMsg.png");
            this.navbarImageListLarge.Images.SetKeyName(8, "dataschool.gif");
            // 
            // USBserialPort
            // 
            this.USBserialPort.ReadTimeout = 1000;
            this.USBserialPort.WriteTimeout = 1000;
            this.USBserialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.USBserialPort_DataReceived);
            // 
            // navbarImageList
            // 
            this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
            this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageList.Images.SetKeyName(0, "delete.png");
            this.navbarImageList.Images.SetKeyName(1, "setting.ico");
            this.navbarImageList.Images.SetKeyName(2, "Templates.ico");
            this.navbarImageList.Images.SetKeyName(3, "User.ico");
            this.navbarImageList.Images.SetKeyName(4, "Send.png");
            this.navbarImageList.Images.SetKeyName(5, "Contacts.ico");
            this.navbarImageList.Images.SetKeyName(6, "Groups.ico");
            this.navbarImageList.Images.SetKeyName(7, "styles.ico");
            this.navbarImageList.Images.SetKeyName(8, "e_schoolDB.png");
            this.navbarImageList.Images.SetKeyName(9, "dataschool.gif");
            this.navbarImageList.Images.SetKeyName(10, "Absent.png");
            this.navbarImageList.Images.SetKeyName(11, "AbsentCount.png");
            this.navbarImageList.Images.SetKeyName(12, "birthday.png");
            this.navbarImageList.Images.SetKeyName(13, "Datanet.png");
            this.navbarImageList.Images.SetKeyName(14, "acc_sms.png");
            this.navbarImageList.Images.SetKeyName(15, "malafatSms.png");
            // 
            // TmrSignal
            // 
            this.TmrSignal.Interval = 2000;
            this.TmrSignal.Tick += new System.EventHandler(this.TmrSignal_Tick);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.btnExcel);
            this.groupControl1.Controls.Add(this.BtnMember);
            this.groupControl1.Controls.Add(this.BtnTemplate);
            this.groupControl1.Controls.Add(this.BtnMSG);
            this.groupControl1.Controls.Add(this.BtnSetting);
            this.groupControl1.Controls.Add(this.BtnDisconnect);
            this.groupControl1.Controls.Add(this.PnlConnection);
            this.groupControl1.Controls.Add(this.PnlSend);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(784, 261);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "الرسائل";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(405, 226);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(70, 30);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "اكسل";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // BtnMember
            // 
            this.BtnMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMember.Location = new System.Drawing.Point(481, 226);
            this.BtnMember.Name = "BtnMember";
            this.BtnMember.Size = new System.Drawing.Size(70, 30);
            this.BtnMember.TabIndex = 5;
            this.BtnMember.Text = "الاعضاء";
            this.BtnMember.Click += new System.EventHandler(this.BtnMember_Click);
            // 
            // BtnTemplate
            // 
            this.BtnTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTemplate.Location = new System.Drawing.Point(557, 226);
            this.BtnTemplate.Name = "BtnTemplate";
            this.BtnTemplate.Size = new System.Drawing.Size(70, 30);
            this.BtnTemplate.TabIndex = 5;
            this.BtnTemplate.Text = "القوالب";
            this.BtnTemplate.Click += new System.EventHandler(this.BtnTemplate_Click);
            // 
            // BtnMSG
            // 
            this.BtnMSG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMSG.Location = new System.Drawing.Point(633, 226);
            this.BtnMSG.Name = "BtnMSG";
            this.BtnMSG.Size = new System.Drawing.Size(70, 30);
            this.BtnMSG.TabIndex = 5;
            this.BtnMSG.Text = "الرسائل";
            this.BtnMSG.Click += new System.EventHandler(this.BtnMSG_Click);
            // 
            // BtnSetting
            // 
            this.BtnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetting.Location = new System.Drawing.Point(709, 226);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(70, 30);
            this.BtnSetting.TabIndex = 5;
            this.BtnSetting.Text = "الخيارات";
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDisconnect.ImageIndex = 3;
            this.BtnDisconnect.ImageList = this.navbarImageListLarge;
            this.BtnDisconnect.Location = new System.Drawing.Point(486, 167);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(157, 33);
            this.BtnDisconnect.TabIndex = 1;
            this.BtnDisconnect.Text = "قطع الاتصال";
            this.BtnDisconnect.Visible = false;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // PnlConnection
            // 
            this.PnlConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlConnection.Controls.Add(this.LblDeviceName);
            this.PnlConnection.Controls.Add(this.TxtServiceNum);
            this.PnlConnection.Controls.Add(this.BtnConnect);
            this.PnlConnection.Controls.Add(this.labelControl2);
            this.PnlConnection.Controls.Add(this.labelControl1);
            this.PnlConnection.Controls.Add(this.CBEPort);
            this.PnlConnection.Controls.Add(this.PBSignal);
            this.PnlConnection.Location = new System.Drawing.Point(427, 24);
            this.PnlConnection.Name = "PnlConnection";
            this.PnlConnection.Size = new System.Drawing.Size(352, 144);
            this.PnlConnection.TabIndex = 0;
            // 
            // LblDeviceName
            // 
            this.LblDeviceName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblDeviceName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblDeviceName.Location = new System.Drawing.Point(59, 48);
            this.LblDeviceName.Name = "LblDeviceName";
            this.LblDeviceName.Size = new System.Drawing.Size(0, 13);
            this.LblDeviceName.TabIndex = 4;
            // 
            // TxtServiceNum
            // 
            this.TxtServiceNum.Location = new System.Drawing.Point(59, 64);
            this.TxtServiceNum.Name = "TxtServiceNum";
            this.TxtServiceNum.Size = new System.Drawing.Size(157, 20);
            this.TxtServiceNum.TabIndex = 1;
            // 
            // BtnConnect
            // 
            this.BtnConnect.ImageIndex = 2;
            this.BtnConnect.ImageList = this.navbarImageListLarge;
            this.BtnConnect.Location = new System.Drawing.Point(59, 89);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(157, 33);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "اتصال";
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ImageIndex = 5;
            this.labelControl2.Appearance.ImageList = this.navbarImageListLarge;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(222, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 36);
            this.labelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ImageIndex = 4;
            this.labelControl1.Appearance.ImageList = this.navbarImageListLarge;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(222, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 36);
            this.labelControl1.TabIndex = 2;
            // 
            // CBEPort
            // 
            this.CBEPort.Location = new System.Drawing.Point(59, 22);
            this.CBEPort.Name = "CBEPort";
            this.CBEPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBEPort.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBEPort.Size = new System.Drawing.Size(157, 20);
            this.CBEPort.TabIndex = 0;
            this.CBEPort.SelectedIndexChanged += new System.EventHandler(this.CBEPort_SelectedIndexChanged);
            // 
            // PBSignal
            // 
            this.PBSignal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBSignal.Location = new System.Drawing.Point(2, 2);
            this.PBSignal.Name = "PBSignal";
            this.PBSignal.Properties.Maximum = 31;
            this.PBSignal.Properties.NullText = "الشبكه";
            this.PBSignal.Properties.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Vertical;
            this.PBSignal.Properties.ShowTitle = true;
            this.PBSignal.Properties.Step = 1;
            this.PBSignal.Size = new System.Drawing.Size(28, 140);
            this.PBSignal.TabIndex = 5;
            // 
            // PnlSend
            // 
            this.PnlSend.Controls.Add(this.BtnDelSendTo);
            this.PnlSend.Controls.Add(this.PBSend);
            this.PnlSend.Controls.Add(this.LblMsgCounter);
            this.PnlSend.Controls.Add(this.LblCharCounter);
            this.PnlSend.Controls.Add(this.BtnSaveMsg);
            this.PnlSend.Controls.Add(this.CBAddVar);
            this.PnlSend.Controls.Add(this.btnSend);
            this.PnlSend.Controls.Add(this.LBCSendTo);
            this.PnlSend.Controls.Add(this.TxtMsg);
            this.PnlSend.Enabled = false;
            this.PnlSend.Location = new System.Drawing.Point(12, 24);
            this.PnlSend.Name = "PnlSend";
            this.PnlSend.Size = new System.Drawing.Size(409, 196);
            this.PnlSend.TabIndex = 2;
            // 
            // BtnDelSendTo
            // 
            this.BtnDelSendTo.ImageIndex = 0;
            this.BtnDelSendTo.ImageList = this.navbarImageList;
            this.BtnDelSendTo.Location = new System.Drawing.Point(255, 121);
            this.BtnDelSendTo.Name = "BtnDelSendTo";
            this.BtnDelSendTo.Size = new System.Drawing.Size(149, 23);
            this.BtnDelSendTo.TabIndex = 5;
            this.BtnDelSendTo.Text = "حذف";
            this.BtnDelSendTo.Click += new System.EventHandler(this.BtnDelSendTo_Click);
            // 
            // PBSend
            // 
            this.PBSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBSend.Location = new System.Drawing.Point(2, 179);
            this.PBSend.Name = "PBSend";
            this.PBSend.Properties.ShowTitle = true;
            this.PBSend.Properties.Step = 1;
            this.PBSend.Size = new System.Drawing.Size(405, 15);
            this.PBSend.TabIndex = 6;
            // 
            // LblMsgCounter
            // 
            this.LblMsgCounter.AutoSize = true;
            this.LblMsgCounter.Location = new System.Drawing.Point(5, 163);
            this.LblMsgCounter.Name = "LblMsgCounter";
            this.LblMsgCounter.Size = new System.Drawing.Size(13, 13);
            this.LblMsgCounter.TabIndex = 5;
            this.LblMsgCounter.Text = "0";
            // 
            // LblCharCounter
            // 
            this.LblCharCounter.AutoSize = true;
            this.LblCharCounter.Location = new System.Drawing.Point(120, 163);
            this.LblCharCounter.Name = "LblCharCounter";
            this.LblCharCounter.Size = new System.Drawing.Size(13, 13);
            this.LblCharCounter.TabIndex = 5;
            this.LblCharCounter.Text = "0";
            // 
            // BtnSaveMsg
            // 
            this.BtnSaveMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSaveMsg.ImageIndex = 7;
            this.BtnSaveMsg.ImageList = this.navbarImageListLarge;
            this.BtnSaveMsg.Location = new System.Drawing.Point(183, 121);
            this.BtnSaveMsg.Name = "BtnSaveMsg";
            this.BtnSaveMsg.Size = new System.Drawing.Size(66, 38);
            this.BtnSaveMsg.TabIndex = 4;
            this.BtnSaveMsg.Text = "حفظ";
            this.BtnSaveMsg.Click += new System.EventHandler(this.BtnSaveMsg_Click);
            // 
            // CBAddVar
            // 
            this.CBAddVar.Location = new System.Drawing.Point(5, 5);
            this.CBAddVar.Name = "CBAddVar";
            this.CBAddVar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.CBAddVar.Properties.Items.AddRange(new object[] {
            "[الاسم]",
            "[الوظيفه]"});
            this.CBAddVar.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.CBAddVar_Properties_ButtonClick);
            this.CBAddVar.Size = new System.Drawing.Size(245, 20);
            this.CBAddVar.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSend.ImageIndex = 6;
            this.btnSend.ImageList = this.navbarImageListLarge;
            this.btnSend.Location = new System.Drawing.Point(5, 121);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(175, 38);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "ارسال";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // LBCSendTo
            // 
            this.LBCSendTo.Appearance.Options.UseTextOptions = true;
            this.LBCSendTo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LBCSendTo.Location = new System.Drawing.Point(255, 28);
            this.LBCSendTo.Name = "LBCSendTo";
            this.LBCSendTo.Size = new System.Drawing.Size(150, 87);
            this.LBCSendTo.TabIndex = 2;
            // 
            // TxtMsg
            // 
            this.TxtMsg.Location = new System.Drawing.Point(5, 28);
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtMsg.Size = new System.Drawing.Size(245, 87);
            this.TxtMsg.TabIndex = 1;
            this.TxtMsg.EditValueChanged += new System.EventHandler(this.TxtMsg_EditValueChanged);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // smsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlMain);
            this.Name = "smsFrm";
            this.Text = "الرسائل";
            this.Load += new System.EventHandler(this.smsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSettingUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSettingDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            this.CMSdataschool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTBLSCommitteMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditstu_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlConnection)).EndInit();
            this.PnlConnection.ResumeLayout(false);
            this.PnlConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServiceNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBEPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSignal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlSend)).EndInit();
            this.PnlSend.ResumeLayout(false);
            this.PnlSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAddVar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBCSendTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMsg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList navbarImageListLarge;
        private System.Windows.Forms.ContextMenuStrip CMSdataschool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.IO.Ports.SerialPort USBserialPort;
        private System.Windows.Forms.ImageList navbarImageList;
        private System.Windows.Forms.Timer TmrSignal;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnDisconnect;
        private DevExpress.XtraEditors.PanelControl PnlConnection;
        private DevExpress.XtraEditors.TextEdit TxtServiceNum;
        private DevExpress.XtraEditors.SimpleButton BtnConnect;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit CBEPort;
        private DevExpress.XtraEditors.ProgressBarControl PBSignal;
        private DevExpress.XtraEditors.PanelControl PnlSend;
        private DevExpress.XtraEditors.DropDownButton BtnDelSendTo;
        private DevExpress.XtraEditors.ProgressBarControl PBSend;
        private System.Windows.Forms.Label LblMsgCounter;
        private System.Windows.Forms.Label LblCharCounter;
        private DevExpress.XtraEditors.SimpleButton BtnSaveMsg;
        private DevExpress.XtraEditors.ComboBoxEdit CBAddVar;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.ListBoxControl LBCSendTo;
        private DevExpress.XtraEditors.MemoEdit TxtMsg;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSettingUse;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSettingDel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMessages;
        private DevExpress.XtraGrid.Columns.GridColumn GCMessagesnumber;
        private DevExpress.XtraGrid.Columns.GridColumn GCMessagesmessageBody;
        private DevExpress.XtraGrid.Columns.GridColumn GCMessagesstatus;
        private DevExpress.XtraGrid.Columns.GridColumn GCMessagesSendTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCMessagesUse;
        private DevExpress.XtraGrid.Columns.GridColumn GCMessageSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCMessagesDel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTemplates;
        private DevExpress.XtraGrid.Columns.GridColumn GCTemplateTemplateBody;
        private DevExpress.XtraGrid.Columns.GridColumn GCTemplateSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCTemplateUse;
        private DevExpress.XtraGrid.Columns.GridColumn GCTemplateDel;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditstu_code;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTBLSCommitteMember;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSetting;
        private DevExpress.XtraGrid.Columns.GridColumn GCServiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn GCSettingSave;
        private DevExpress.XtraGrid.Columns.GridColumn GCSettingUse;
        private DevExpress.XtraGrid.Columns.GridColumn GCSettingDel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton BtnMember;
        private DevExpress.XtraEditors.SimpleButton BtnTemplate;
        private DevExpress.XtraEditors.SimpleButton BtnMSG;
        private DevExpress.XtraEditors.SimpleButton BtnSetting;
        private DevExpress.XtraEditors.LabelControl LblDeviceName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExcel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
    }
}