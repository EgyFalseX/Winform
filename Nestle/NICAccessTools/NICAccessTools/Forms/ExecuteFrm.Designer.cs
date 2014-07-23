namespace NICAccessTools.Forms
{
    partial class ExecuteFrm
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (con != null)
                {
                    con.Dispose();
                    con = null;
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                    cmd = null;
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecuteFrm));
            this.groupControlOption = new DevExpress.XtraEditors.GroupControl();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnExecute = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.luePro = new DevExpress.XtraEditors.GridLookUpEdit();
            this.xpCollectionProcedures = new DevExpress.Xpo.XPCollection(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProcedureName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcedureInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlExe = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbQry = new DevExpress.XtraEditors.ListBoxControl();
            this.qryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCfg = new NICAccessTools.Data.dsCfg();
            this.unitOfWorkProcedures = new DevExpress.Xpo.UnitOfWork(this.components);
            this.qryTableAdapter = new NICAccessTools.Data.dsCfgTableAdapters.QryTableAdapter();
            this.pb = new DevExpress.XtraEditors.ProgressBarControl();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.lblState = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOption)).BeginInit();
            this.groupControlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luePro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionProcedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlExe)).BeginInit();
            this.groupControlExe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkProcedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlOption
            // 
            this.groupControlOption.Controls.Add(this.btnStop);
            this.groupControlOption.Controls.Add(this.btnExecute);
            this.groupControlOption.Controls.Add(this.labelControl1);
            this.groupControlOption.Controls.Add(this.luePro);
            this.groupControlOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlOption.Location = new System.Drawing.Point(0, 0);
            this.groupControlOption.Name = "groupControlOption";
            this.groupControlOption.Size = new System.Drawing.Size(652, 84);
            this.groupControlOption.TabIndex = 0;
            this.groupControlOption.Text = "Control Panal";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::NICAccessTools.Properties.Resources.Stop;
            this.btnStop.Location = new System.Drawing.Point(540, 35);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 35);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Enabled = false;
            this.btnExecute.Image = global::NICAccessTools.Properties.Resources.Start;
            this.btnExecute.Location = new System.Drawing.Point(434, 35);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(100, 35);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(12, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Procedures";
            // 
            // luePro
            // 
            this.luePro.EditValue = "";
            this.luePro.Location = new System.Drawing.Point(82, 41);
            this.luePro.Name = "luePro";
            this.luePro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.luePro.Properties.Appearance.Options.UseFont = true;
            this.luePro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePro.Properties.DataSource = this.xpCollectionProcedures;
            this.luePro.Properties.DisplayMember = "ProcedureName";
            this.luePro.Properties.NullText = "";
            this.luePro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luePro.Properties.ValueMember = "ProcedureId";
            this.luePro.Properties.View = this.gridLookUpEdit1View;
            this.luePro.Size = new System.Drawing.Size(202, 22);
            this.luePro.TabIndex = 0;
            this.luePro.EditValueChanged += new System.EventHandler(this.luePro_EditValueChanged);
            // 
            // xpCollectionProcedures
            // 
            this.xpCollectionProcedures.ObjectType = typeof(NICAccessTools.Data.dsCfg.ProceduresDataTable);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProcedureName,
            this.colProcedureInfo});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colProcedureName
            // 
            this.colProcedureName.FieldName = "ProcedureName";
            this.colProcedureName.Name = "colProcedureName";
            this.colProcedureName.Visible = true;
            this.colProcedureName.VisibleIndex = 0;
            // 
            // colProcedureInfo
            // 
            this.colProcedureInfo.FieldName = "ProcedureInfo";
            this.colProcedureInfo.Name = "colProcedureInfo";
            this.colProcedureInfo.Visible = true;
            this.colProcedureInfo.VisibleIndex = 1;
            // 
            // groupControlExe
            // 
            this.groupControlExe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlExe.Controls.Add(this.gridControlData);
            this.groupControlExe.Controls.Add(this.lbQry);
            this.groupControlExe.Location = new System.Drawing.Point(0, 90);
            this.groupControlExe.Name = "groupControlExe";
            this.groupControlExe.Size = new System.Drawing.Size(652, 247);
            this.groupControlExe.TabIndex = 1;
            this.groupControlExe.Text = "Executing Information";
            // 
            // gridControlData
            // 
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.Location = new System.Drawing.Point(261, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(389, 224);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            // 
            // lbQry
            // 
            this.lbQry.DataSource = this.qryBindingSource;
            this.lbQry.DisplayMember = "QryName";
            this.lbQry.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbQry.Location = new System.Drawing.Point(2, 21);
            this.lbQry.Name = "lbQry";
            this.lbQry.Size = new System.Drawing.Size(259, 224);
            this.lbQry.TabIndex = 0;
            this.lbQry.ValueMember = "QryId";
            // 
            // qryBindingSource
            // 
            this.qryBindingSource.DataMember = "Qry";
            this.qryBindingSource.DataSource = this.dsCfg;
            this.qryBindingSource.Filter = "ProcedureId = 0";
            this.qryBindingSource.Sort = "QryNumber";
            // 
            // dsCfg
            // 
            this.dsCfg.DataSetName = "dsCfg";
            this.dsCfg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitOfWorkProcedures
            // 
            this.unitOfWorkProcedures.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWorkProcedures.TrackPropertiesModifications = false;
            // 
            // qryTableAdapter
            // 
            this.qryTableAdapter.ClearBeforeFill = true;
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(261, 343);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(386, 18);
            this.pb.TabIndex = 2;
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblState.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblState.Location = new System.Drawing.Point(2, 343);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(253, 13);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "Ready";
            // 
            // ExecuteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 362);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.groupControlExe);
            this.Controls.Add(this.groupControlOption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExecuteFrm";
            this.Text = "Execute Query";
            this.Load += new System.EventHandler(this.ExecuteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOption)).EndInit();
            this.groupControlOption.ResumeLayout(false);
            this.groupControlOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luePro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionProcedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlExe)).EndInit();
            this.groupControlExe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCfg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkProcedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlOption;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnExecute;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit luePro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl groupControlExe;
        private DevExpress.XtraEditors.ListBoxControl lbQry;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.Xpo.XPCollection xpCollectionProcedures;
        private DevExpress.Xpo.UnitOfWork unitOfWorkProcedures;
        private DevExpress.XtraGrid.Columns.GridColumn colProcedureName;
        private DevExpress.XtraGrid.Columns.GridColumn colProcedureInfo;
        private Data.dsCfg dsCfg;
        private System.Windows.Forms.BindingSource qryBindingSource;
        private Data.dsCfgTableAdapters.QryTableAdapter qryTableAdapter;
        private DevExpress.XtraEditors.ProgressBarControl pb;
        private System.ComponentModel.BackgroundWorker worker;
        private DevExpress.XtraEditors.LabelControl lblState;
    }
}