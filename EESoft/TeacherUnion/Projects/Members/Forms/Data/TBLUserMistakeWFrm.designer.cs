namespace Members
{
    partial class TBLUserMistakeWFrm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.tbmistakenots = new DevExpress.XtraEditors.MemoEdit();
            this.LUEWorkTypeId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cDWorkTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeachersUnion = new Members.DataSources.dsTeachersUnion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LUEuserid = new DevExpress.XtraEditors.GridLookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.colMonthName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usersTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.UsersTableAdapter();
            this.cDWorkTypeTableAdapter = new Members.DataSources.dsTeachersUnionTableAdapters.CDWorkTypeTableAdapter();
            this.colWorkType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmistakenots.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEWorkTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDWorkTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEuserid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Location = new System.Drawing.Point(5, 375);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(436, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Members.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(281, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفـــــــــــــــــــــــــظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::Members.Properties.Resources.Delete;
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(7, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtpGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(441, 357);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpGeneral});
            // 
            // xtpGeneral
            // 
            this.xtpGeneral.Controls.Add(this.tbmistakenots);
            this.xtpGeneral.Controls.Add(this.LUEWorkTypeId);
            this.xtpGeneral.Controls.Add(this.LUEuserid);
            this.xtpGeneral.Controls.Add(this.labelControl2);
            this.xtpGeneral.Controls.Add(this.labelControl7);
            this.xtpGeneral.Controls.Add(this.labelControl6);
            this.xtpGeneral.Image = global::Members.Properties.Resources.Edit;
            this.xtpGeneral.Name = "xtpGeneral";
            this.xtpGeneral.Size = new System.Drawing.Size(435, 310);
            this.xtpGeneral.Text = "بيانات أساسيه";
            // 
            // tbmistakenots
            // 
            this.tbmistakenots.Location = new System.Drawing.Point(29, 152);
            this.tbmistakenots.Name = "tbmistakenots";
            this.tbmistakenots.Size = new System.Drawing.Size(200, 80);
            this.tbmistakenots.TabIndex = 2;
            // 
            // LUEWorkTypeId
            // 
            this.LUEWorkTypeId.Location = new System.Drawing.Point(29, 108);
            this.LUEWorkTypeId.Name = "LUEWorkTypeId";
            this.LUEWorkTypeId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LUEWorkTypeId.Properties.Appearance.Options.UseFont = true;
            this.LUEWorkTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEWorkTypeId.Properties.DataSource = this.cDWorkTypeBindingSource;
            this.LUEWorkTypeId.Properties.DisplayMember = "WorkType";
            this.LUEWorkTypeId.Properties.NullText = "";
            this.LUEWorkTypeId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEWorkTypeId.Properties.ValueMember = "WorkTypeId";
            this.LUEWorkTypeId.Properties.View = this.gridView1;
            this.LUEWorkTypeId.Size = new System.Drawing.Size(200, 26);
            this.LUEWorkTypeId.TabIndex = 1;
            // 
            // cDWorkTypeBindingSource
            // 
            this.cDWorkTypeBindingSource.DataMember = "CDWorkType";
            this.cDWorkTypeBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // dsTeachersUnion
            // 
            this.dsTeachersUnion.DataSetName = "dsTeachersUnion";
            this.dsTeachersUnion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWorkType});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // LUEuserid
            // 
            this.LUEuserid.Location = new System.Drawing.Point(29, 67);
            this.LUEuserid.Name = "LUEuserid";
            this.LUEuserid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LUEuserid.Properties.Appearance.Options.UseFont = true;
            this.LUEuserid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEuserid.Properties.DataSource = this.usersBindingSource;
            this.LUEuserid.Properties.DisplayMember = "RealName";
            this.LUEuserid.Properties.NullText = "";
            this.LUEuserid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEuserid.Properties.ValueMember = "UserID";
            this.LUEuserid.Properties.View = this.gridLookUpEdit1View;
            this.LUEuserid.Size = new System.Drawing.Size(200, 26);
            this.LUEuserid.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsTeachersUnion;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRealName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "الاسم";
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(346, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "ملاحظات";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Location = new System.Drawing.Point(340, 111);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 19);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "نوع العمل";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Location = new System.Drawing.Point(364, 70);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "الاسم";
            // 
            // colMonthName
            // 
            this.colMonthName.AppearanceCell.Options.UseTextOptions = true;
            this.colMonthName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonthName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName.Caption = "اسم الشهر";
            this.colMonthName.FieldName = "MonthName";
            this.colMonthName.Name = "colMonthName";
            this.colMonthName.Visible = true;
            this.colMonthName.VisibleIndex = 0;
            // 
            // colYearName
            // 
            this.colYearName.AppearanceCell.Options.UseTextOptions = true;
            this.colYearName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.Caption = "اسم السنه";
            this.colYearName.FieldName = "YearName";
            this.colYearName.Name = "colYearName";
            this.colYearName.Visible = true;
            this.colYearName.VisibleIndex = 0;
            // 
            // colMonthName1
            // 
            this.colMonthName1.AppearanceCell.Options.UseTextOptions = true;
            this.colMonthName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonthName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName1.Caption = "اسم الشهر";
            this.colMonthName1.FieldName = "MonthName";
            this.colMonthName1.Name = "colMonthName1";
            this.colMonthName1.Visible = true;
            this.colMonthName1.VisibleIndex = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // cDWorkTypeTableAdapter
            // 
            this.cDWorkTypeTableAdapter.ClearBeforeFill = true;
            // 
            // colWorkType
            // 
            this.colWorkType.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkType.AppearanceHeader.Options.UseTextOptions = true;
            this.colWorkType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkType.Caption = "النوع";
            this.colWorkType.FieldName = "WorkType";
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.Visible = true;
            this.colWorkType.VisibleIndex = 0;
            // 
            // TBLUserMistakeWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(450, 431);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TBLUserMistakeWFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحرير";
            this.Load += new System.EventHandler(this.FormWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpGeneral.ResumeLayout(false);
            this.xtpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmistakenots.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEWorkTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDWorkTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEuserid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpGeneral;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName;
        private DevExpress.XtraGrid.Columns.GridColumn colYearName;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GridLookUpEdit LUEuserid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit LUEWorkTypeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit tbmistakenots;
        private DataSources.dsTeachersUnion dsTeachersUnion;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private System.Windows.Forms.BindingSource cDWorkTypeBindingSource;
        private DataSources.dsTeachersUnionTableAdapters.CDWorkTypeTableAdapter cDWorkTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkType;
    }
}