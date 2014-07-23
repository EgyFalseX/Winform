namespace schoolStore
{
    partial class DataTBLGardFrm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lueEMPID = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.deGardDate = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tbscount = new DevExpress.XtraEditors.TextEdit();
            this.lueGardId = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueEMPID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGardDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGardDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGardId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.lueEMPID);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.deGardDate);
            this.groupControl1.Location = new System.Drawing.Point(18, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(249, 116);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "انشاء جرد";
            // 
            // lueEMPID
            // 
            this.lueEMPID.Location = new System.Drawing.Point(24, 50);
            this.lueEMPID.Name = "lueEMPID";
            this.lueEMPID.Properties.Appearance.Options.UseTextOptions = true;
            this.lueEMPID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lueEMPID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEMPID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNAME", "الاسم", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JOBNAME", "الوظيفه", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.lueEMPID.Properties.NullText = "";
            this.lueEMPID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueEMPID.Size = new System.Drawing.Size(200, 20);
            this.lueEMPID.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "اضافة جرد";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // deGardDate
            // 
            this.deGardDate.EditValue = null;
            this.deGardDate.Location = new System.Drawing.Point(24, 24);
            this.deGardDate.Name = "deGardDate";
            this.deGardDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deGardDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deGardDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deGardDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deGardDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deGardDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deGardDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deGardDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deGardDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deGardDate.Size = new System.Drawing.Size(200, 20);
            this.deGardDate.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.tbBarcode);
            this.groupControl2.Controls.Add(this.gridControlData);
            this.groupControl2.Controls.Add(this.tbscount);
            this.groupControl2.Controls.Add(this.lueGardId);
            this.groupControl2.Location = new System.Drawing.Point(18, 134);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(249, 416);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "تفاصيل جرد";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(80, 50);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(144, 20);
            this.tbBarcode.TabIndex = 2;
            this.tbBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBarcode.TextChanged += new System.EventHandler(this.tbBarcode_TextChanged);
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(5, 76);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDel});
            this.gridControlData.Size = new System.Drawing.Size(239, 335);
            this.gridControlData.TabIndex = 3;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn3});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "الصنف";
            this.gridColumn1.FieldName = "SanfName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 182;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "الكميه";
            this.gridColumn6.FieldName = "scount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 69;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "حذف";
            this.gridColumn3.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
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
            // tbscount
            // 
            this.tbscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbscount.EditValue = "1";
            this.tbscount.Location = new System.Drawing.Point(24, 50);
            this.tbscount.Name = "tbscount";
            this.tbscount.Properties.Appearance.Options.UseTextOptions = true;
            this.tbscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbscount.Properties.DisplayFormat.FormatString = "n0";
            this.tbscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbscount.Properties.EditFormat.FormatString = "n0";
            this.tbscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbscount.Properties.Mask.EditMask = "n0";
            this.tbscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbscount.Properties.NullValuePrompt = "الكميه";
            this.tbscount.Size = new System.Drawing.Size(50, 20);
            this.tbscount.TabIndex = 2;
            // 
            // lueGardId
            // 
            this.lueGardId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lueGardId.Location = new System.Drawing.Point(24, 24);
            this.lueGardId.Name = "lueGardId";
            this.lueGardId.Properties.Appearance.Options.UseTextOptions = true;
            this.lueGardId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lueGardId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGardId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNAME", "اسم الموظف", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GardDate", "تاريخ الخرد", 40, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Center)});
            this.lueGardId.Properties.NullText = "";
            this.lueGardId.Properties.NullValuePrompt = "اختار جرد";
            this.lueGardId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueGardId.Size = new System.Drawing.Size(200, 20);
            this.lueGardId.TabIndex = 0;
            this.lueGardId.EditValueChanged += new System.EventHandler(this.lueGardId_EditValueChanged);
            // 
            // DataTBLGardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 562);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DataTBLGardFrm";
            this.Text = "الجرد بالباركود";
            this.Load += new System.EventHandler(this.DataTBLGardFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueEMPID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGardDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGardDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGardId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.DateEdit deGardDate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit lueEMPID;
        private DevExpress.XtraEditors.TextEdit tbscount;
        private DevExpress.XtraEditors.LookUpEdit lueGardId;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.TextBox tbBarcode;
    }
}