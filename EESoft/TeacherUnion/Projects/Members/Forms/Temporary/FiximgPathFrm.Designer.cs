namespace Members.Forms.Temporary
{
    partial class FiximgPathFrm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbesalno = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDeletePath = new DevExpress.XtraEditors.SimpleButton();
            this.lbcPaths = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnAddPath = new DevExpress.XtraEditors.SimpleButton();
            this.dsTeachersUnionQuery = new Members.DataSources.dsTeachersUnionQuery();
            this.pathFixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pathFixTableAdapter = new Members.DataSources.dsTeachersUnionQueryTableAdapters.PathFixTableAdapter();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFix = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbesalno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathFixBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tbesalno);
            this.groupControl1.Controls.Add(this.btnFix);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(640, 87);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Options";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(581, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "رقم الايصال";
            // 
            // tbesalno
            // 
            this.tbesalno.Location = new System.Drawing.Point(477, 40);
            this.tbesalno.Name = "tbesalno";
            this.tbesalno.Size = new System.Drawing.Size(100, 20);
            this.tbesalno.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(371, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.pathFixBindingSource;
            this.gridControlData.Location = new System.Drawing.Point(155, 105);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(497, 223);
            this.gridControlData.TabIndex = 2;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKideNumber,
            this.colesalno,
            this.colimg});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeletePath.Location = new System.Drawing.Point(5, 190);
            this.btnDeletePath.Name = "btnDeletePath";
            this.btnDeletePath.Size = new System.Drawing.Size(52, 23);
            this.btnDeletePath.TabIndex = 2;
            this.btnDeletePath.Text = "حذف";
            this.btnDeletePath.Click += new System.EventHandler(this.btnDeletePath_Click);
            // 
            // lbcPaths
            // 
            this.lbcPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbcPaths.Location = new System.Drawing.Point(5, 24);
            this.lbcPaths.Name = "lbcPaths";
            this.lbcPaths.Size = new System.Drawing.Size(127, 160);
            this.lbcPaths.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.lbcPaths);
            this.groupControl2.Controls.Add(this.btnAddPath);
            this.groupControl2.Controls.Add(this.btnDeletePath);
            this.groupControl2.Location = new System.Drawing.Point(12, 105);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(137, 223);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Options";
            // 
            // btnAddPath
            // 
            this.btnAddPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddPath.Location = new System.Drawing.Point(80, 190);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(52, 23);
            this.btnAddPath.TabIndex = 1;
            this.btnAddPath.Text = "اضافة";
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // dsTeachersUnionQuery
            // 
            this.dsTeachersUnionQuery.DataSetName = "dsTeachersUnionQuery";
            this.dsTeachersUnionQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pathFixBindingSource
            // 
            this.pathFixBindingSource.DataMember = "PathFix";
            this.pathFixBindingSource.DataSource = this.dsTeachersUnionQuery;
            // 
            // pathFixTableAdapter
            // 
            this.pathFixTableAdapter.ClearBeforeFill = true;
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
            this.colKideNumber.VisibleIndex = 0;
            this.colKideNumber.Width = 96;
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
            this.colesalno.Visible = true;
            this.colesalno.VisibleIndex = 1;
            this.colesalno.Width = 95;
            // 
            // colimg
            // 
            this.colimg.AppearanceCell.Options.UseTextOptions = true;
            this.colimg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimg.AppearanceHeader.Options.UseTextOptions = true;
            this.colimg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimg.Caption = "مسار الصورة";
            this.colimg.FieldName = "img";
            this.colimg.Name = "colimg";
            this.colimg.Visible = true;
            this.colimg.VisibleIndex = 2;
            this.colimg.Width = 282;
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(5, 43);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(100, 39);
            this.btnFix.TabIndex = 2;
            this.btnFix.Text = "بداء المعالجة";
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // FiximgPathFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 340);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.groupControl1);
            this.Name = "FiximgPathFrm";
            this.Text = "معالجة مسار الصور";
            this.Load += new System.EventHandler(this.FiximgPathFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbesalno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTeachersUnionQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathFixBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbesalno;
        private DevExpress.XtraEditors.SimpleButton btnDeletePath;
        private DevExpress.XtraEditors.ListBoxControl lbcPaths;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddPath;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.BindingSource pathFixBindingSource;
        private DataSources.dsTeachersUnionQuery dsTeachersUnionQuery;
        private DevExpress.XtraGrid.Columns.GridColumn colKideNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colesalno;
        private DevExpress.XtraGrid.Columns.GridColumn colimg;
        private DataSources.dsTeachersUnionQueryTableAdapters.PathFixTableAdapter pathFixTableAdapter;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private DevExpress.XtraEditors.SimpleButton btnFix;
    }
}