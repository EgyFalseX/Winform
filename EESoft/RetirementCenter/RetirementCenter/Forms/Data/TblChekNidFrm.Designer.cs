namespace RetirementCenter.Forms.Data
{
    partial class TblChekNidFrm
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
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barLargeButtonItemSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionData = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWorkData = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colm_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colallremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLargeButtonItemSave});
            this.barManagerMain.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItemSave)});
            this.bar1.Text = "Tools";
            // 
            // barLargeButtonItemSave
            // 
            this.barLargeButtonItemSave.Caption = "حفظ";
            this.barLargeButtonItemSave.Glyph = global::RetirementCenter.Properties.Resources.Edit;
            this.barLargeButtonItemSave.Id = 0;
            this.barLargeButtonItemSave.Name = "barLargeButtonItemSave";
            this.barLargeButtonItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItemSave_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(533, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 277);
            this.barDockControlBottom.Size = new System.Drawing.Size(533, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 230);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(533, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 230);
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.xpCollectionData;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.Location = new System.Drawing.Point(0, 47);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.MenuManager = this.barManagerMain;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.gridControlData.Size = new System.Drawing.Size(533, 230);
            this.gridControlData.TabIndex = 4;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // xpCollectionData
            // 
            this.xpCollectionData.ObjectType = typeof(RetirementCenter.DataSources.dsRetirementCenter.TblChekNidDataTable);
            this.xpCollectionData.Session = this.unitOfWorkData;
            // 
            // unitOfWorkData
            // 
            this.unitOfWorkData.TrackPropertiesModifications = false;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNid,
            this.colm_name,
            this.colallremark});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewData_InitNewRow);
            this.gridViewData.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewData_CellValueChanged);
            // 
            // colNid
            // 
            this.colNid.AppearanceCell.Options.UseTextOptions = true;
            this.colNid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNid.AppearanceHeader.Options.UseTextOptions = true;
            this.colNid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNid.Caption = "الرقم القومي";
            this.colNid.FieldName = "Nid";
            this.colNid.Name = "colNid";
            this.colNid.Visible = true;
            this.colNid.VisibleIndex = 0;
            this.colNid.Width = 117;
            // 
            // colm_name
            // 
            this.colm_name.AppearanceCell.Options.UseTextOptions = true;
            this.colm_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colm_name.AppearanceHeader.Options.UseTextOptions = true;
            this.colm_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colm_name.Caption = "الاسم";
            this.colm_name.FieldName = "m_name";
            this.colm_name.Name = "colm_name";
            this.colm_name.Visible = true;
            this.colm_name.VisibleIndex = 1;
            this.colm_name.Width = 133;
            // 
            // colallremark
            // 
            this.colallremark.AppearanceCell.Options.UseTextOptions = true;
            this.colallremark.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colallremark.AppearanceHeader.Options.UseTextOptions = true;
            this.colallremark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colallremark.Caption = "ملاحظات";
            this.colallremark.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colallremark.FieldName = "allremark";
            this.colallremark.Name = "colallremark";
            this.colallremark.Visible = true;
            this.colallremark.VisibleIndex = 2;
            this.colallremark.Width = 123;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // TblChekNidFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 277);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TblChekNidFrm";
            this.Text = "ارقام قوميه قابله للتكرار";
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItemSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.Xpo.XPCollection xpCollectionData;
        private DevExpress.Xpo.UnitOfWork unitOfWorkData;
        private DevExpress.XtraGrid.Columns.GridColumn colNid;
        private DevExpress.XtraGrid.Columns.GridColumn colm_name;
        private DevExpress.XtraGrid.Columns.GridColumn colallremark;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;

    }
}