using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace Fellowship
{
    public partial class TblMemberAttachFrm : DevExpress.XtraEditors.XtraForm
    {

        int MemberId = 0;
        public TblMemberAttachFrm()
        {
            InitializeComponent();
        }
        public TblMemberAttachFrm(int memberId)
        {
            InitializeComponent();
            MemberId = memberId;
        }
        private void PrepareImagelist_Deleted()
        {
            repositoryItemImageComboBox1.SmallImages = imageCollection1;

            foreach (DataRow row in dSFellowship.CDAttach.Rows)
            {
                Byte[] image = row["AttachmentImg"] as Byte[];
                if (image == null)
                    return;
                MemoryStream imgStream = new MemoryStream(image);
                Image img = Image.FromStream(imgStream);
                imageCollection1.AddImage(img);
                repositoryItemImageComboBox1.Items.Add(new ImageComboBoxItem(Convert.ToString(row["AttachmentName"]), Convert.ToString(row["AttachmentTypeId"]), imageCollection1.Images.Count - 1));
            }
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            LUEMembers.Visible = Selecting;

            if (Inserting || Updateing)
                repositoryItemButtonEditEdit.Buttons[0].Visible = true;
            else
                repositoryItemButtonEditEdit.Buttons[0].Visible = false;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;
        }
        private void MemberAttachFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFellowship.CDAttach' table. You can move, or remove it, as needed.
            this.cDAttachTableAdapter.Fill(this.dSFellowship.CDAttach);
            
            // TODO: This line of code loads data into the 'dSFellowshipQuery.TblMember' table. You can move, or remove it, as needed.
            this.tblMemberTableAdapter.Fill(this.dSFellowshipQuery.TblMember);
            ActivePriv();
            //PrepareImagelist();
            if (MemberId != 0)
            {
                LUEMembers.EditValue = MemberId;
                gcOptions.Enabled = false;
            }
        }
        private void LUEMembers_EditValueChanged(object sender, EventArgs e)
        {

            DataSources.DSFellowshipQuery.TblMemberRow row = (DataSources.DSFellowshipQuery.TblMemberRow)((DataRowView)LUEMembers.GetSelectedDataRow()).Row;
            tblHafzaEstlamAttatchTableAdapter.FillByMemberID(dSFellowship.TblHafzaEstlamAttatch, row.MemberID);
            
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            //Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)DRV.Row;
            if (e.ErrorText.Contains("AttachId"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                e.ErrorText = "من فضلك بجب اختيار مرفق";
                return;
            }
            if (e.ErrorText.Contains("MemberID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["MemberID"] = "-1";
                return;
            }
        }
        private void gridViewData_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView GV = (DevExpress.XtraGrid.Views.Grid.GridView)gridControlData.MainView;
            DataSources.DSFellowship.TblHafzaEstlamAttatchRow row = (DataSources.DSFellowship.TblHafzaEstlamAttatchRow)GV.GetFocusedDataRow();

            if (LUEMembers.EditValue == null)
            {
                row.MemberID = -1;
            }
            else
            {
                row.MemberID = Convert.ToInt32(LUEMembers.EditValue);
            }
        }
        private void repositoryItemPictureEditAttachName_Click(object sender, EventArgs e)
        {
            PictureEdit pb = (PictureEdit)sender;
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row == null || row["AttachName"].ToString() == string.Empty)
                return;
            if (!File.Exists(row["AttachName"].ToString()))
                return;
            pb.Image = Image.FromFile(row["AttachName"].ToString());
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUEMembers.EditValue == null)
            {
                Program.ShowMsg("من فضلك اختر عضو", true, this);
                return;
            }
            DevExpress.XtraGrid.Views.Grid.GridView GV = (DevExpress.XtraGrid.Views.Grid.GridView)gridControlData.MainView;
            DataSources.DSFellowshipQuery.TblMemberRow member = (DataSources.DSFellowshipQuery.TblMemberRow)((DataRowView)LUEMembers.GetSelectedDataRow()).Row;
            DataSources.DSFellowship.TblHafzaEstlamAttatchRow row = (DataSources.DSFellowship.TblHafzaEstlamAttatchRow)GV.GetFocusedDataRow();
          
            //if (member == null)
            //    row = dSFellowship.TblHafzaEstlamAttatch.NewTblHafzaEstlamAttatchRow();

            Update(row);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView GV = (DevExpress.XtraGrid.Views.Grid.GridView)gridControlData.MainView;
            DataSources.DSFellowship.TblHafzaEstlamAttatchRow row = (DataSources.DSFellowship.TblHafzaEstlamAttatchRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tblHafzaEstlamAttatchTableAdapter.Delete(row.MemberID, row.AttachId);
                gridViewData.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void Update(DataSources.DSFellowship.TblHafzaEstlamAttatchRow row)
        {
            try
            {
                row.userin = Program.UserInfo.UserId;
                row.datein = DateTime.Now;
                if (row.RowState == DataRowState.Detached)
                {
                    row.MemberID = Convert.ToInt32(LUEMembers.EditValue);
                    dSFellowship.TblHafzaEstlamAttatch.AddTblHafzaEstlamAttatchRow(row);
                }
                tblHafzaEstlamAttatchBindingSource.EndEdit();
                tblHafzaEstlamAttatchTableAdapter.Update(row);
                dSFellowship.TblHafzaEstlamAttatch.AcceptChanges();

                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TblMemberAttachFrm));
            this.gcOptions = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LUEMembers = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tblMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFellowshipQuery = new Fellowship.DataSources.DSFellowshipQuery();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKideNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesalno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDetails = new DevExpress.XtraEditors.GroupControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tblHafzaEstlamAttatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFellowship = new Fellowship.DataSources.DSFellowship();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAttachmentTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditAttahcmentTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cDAttachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditAttachInfo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.colAttachmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.tblMemberTableAdapter = new Fellowship.DataSources.DSFellowshipQueryTableAdapters.TblMemberTableAdapter();
            this.tblHafzaEstlamAttatchTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.TblHafzaEstlamAttatchTableAdapter();
            this.cDAttachTableAdapter = new Fellowship.DataSources.DSFellowshipTableAdapters.CDAttachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcOptions)).BeginInit();
            this.gcOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEMembers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowshipQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).BeginInit();
            this.gcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHafzaEstlamAttatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditAttahcmentTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDAttachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditAttachInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOptions
            // 
            this.gcOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOptions.AppearanceCaption.Options.UseTextOptions = true;
            this.gcOptions.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcOptions.Controls.Add(this.labelControl1);
            this.gcOptions.Controls.Add(this.LUEMembers);
            this.gcOptions.Location = new System.Drawing.Point(12, 12);
            this.gcOptions.Name = "gcOptions";
            this.gcOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcOptions.Size = new System.Drawing.Size(568, 61);
            this.gcOptions.TabIndex = 0;
            this.gcOptions.Text = "الاعضاء";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(530, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الاعضاء";
            // 
            // LUEMembers
            // 
            this.LUEMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LUEMembers.Location = new System.Drawing.Point(252, 29);
            this.LUEMembers.Name = "LUEMembers";
            this.LUEMembers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEMembers.Properties.DataSource = this.tblMemberBindingSource;
            this.LUEMembers.Properties.DisplayMember = "MemberName";
            this.LUEMembers.Properties.NullText = "";
            this.LUEMembers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEMembers.Properties.ValueMember = "MemberID";
            this.LUEMembers.Properties.View = this.gridLookUpEdit1View;
            this.LUEMembers.Size = new System.Drawing.Size(250, 20);
            this.LUEMembers.TabIndex = 0;
            this.LUEMembers.EditValueChanged += new System.EventHandler(this.LUEMembers_EditValueChanged);
            // 
            // tblMemberBindingSource
            // 
            this.tblMemberBindingSource.DataMember = "TblMember";
            this.tblMemberBindingSource.DataSource = this.dSFellowshipQuery;
            // 
            // dSFellowshipQuery
            // 
            this.dSFellowshipQuery.DataSetName = "DSFellowshipQuery";
            this.dSFellowshipQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberName,
            this.colSyndicate,
            this.colKideNumber,
            this.colesalno});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 0;
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
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 1;
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
            this.colKideNumber.VisibleIndex = 2;
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
            this.colesalno.VisibleIndex = 3;
            // 
            // gcDetails
            // 
            this.gcDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDetails.AppearanceCaption.Options.UseTextOptions = true;
            this.gcDetails.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDetails.Controls.Add(this.gridControlData);
            this.gcDetails.Location = new System.Drawing.Point(12, 79);
            this.gcDetails.Name = "gcDetails";
            this.gcDetails.Size = new System.Drawing.Size(568, 332);
            this.gcDetails.TabIndex = 1;
            this.gcDetails.Text = "التفاضيل";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tblHafzaEstlamAttatchBindingSource;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDel,
            this.repositoryItemGridLookUpEditAttahcmentTypeId,
            this.repositoryItemMemoExEditAttachInfo,
            this.repositoryItemButtonEditEdit,
            this.repositoryItemImageComboBox1});
            this.gridControlData.Size = new System.Drawing.Size(564, 309);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tblHafzaEstlamAttatchBindingSource
            // 
            this.tblHafzaEstlamAttatchBindingSource.DataMember = "TblHafzaEstlamAttatch";
            this.tblHafzaEstlamAttatchBindingSource.DataSource = this.dSFellowship;
            // 
            // dSFellowship
            // 
            this.dSFellowship.DataSetName = "DSFellowship";
            this.dSFellowship.Locale = new System.Globalization.CultureInfo("en-US");
            this.dSFellowship.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAttachmentTypeId,
            this.colAttachInfo,
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة مرفق";
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewData_InitNewRow);
            this.gridViewData.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewData_InvalidRowException);
            // 
            // colAttachmentTypeId
            // 
            this.colAttachmentTypeId.AppearanceCell.Options.UseTextOptions = true;
            this.colAttachmentTypeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentTypeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachmentTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentTypeId.Caption = "النوع";
            this.colAttachmentTypeId.ColumnEdit = this.repositoryItemGridLookUpEditAttahcmentTypeId;
            this.colAttachmentTypeId.FieldName = "AttachId";
            this.colAttachmentTypeId.Name = "colAttachmentTypeId";
            this.colAttachmentTypeId.Visible = true;
            this.colAttachmentTypeId.VisibleIndex = 0;
            this.colAttachmentTypeId.Width = 125;
            // 
            // repositoryItemGridLookUpEditAttahcmentTypeId
            // 
            this.repositoryItemGridLookUpEditAttahcmentTypeId.AutoHeight = false;
            this.repositoryItemGridLookUpEditAttahcmentTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditAttahcmentTypeId.DataSource = this.cDAttachBindingSource;
            this.repositoryItemGridLookUpEditAttahcmentTypeId.DisplayMember = "AttachName";
            this.repositoryItemGridLookUpEditAttahcmentTypeId.Name = "repositoryItemGridLookUpEditAttahcmentTypeId";
            this.repositoryItemGridLookUpEditAttahcmentTypeId.NullText = "";
            this.repositoryItemGridLookUpEditAttahcmentTypeId.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.repositoryItemGridLookUpEditAttahcmentTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditAttahcmentTypeId.ValueMember = "AttachId";
            this.repositoryItemGridLookUpEditAttahcmentTypeId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // cDAttachBindingSource
            // 
            this.cDAttachBindingSource.DataMember = "CDAttach";
            this.cDAttachBindingSource.DataSource = this.dSFellowship;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.RowHeight = 32;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "اسم النوع";
            this.gridColumn3.FieldName = "AttachName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 192;
            // 
            // colAttachInfo
            // 
            this.colAttachInfo.AppearanceCell.Options.UseTextOptions = true;
            this.colAttachInfo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachInfo.Caption = "معلومات";
            this.colAttachInfo.ColumnEdit = this.repositoryItemMemoExEditAttachInfo;
            this.colAttachInfo.FieldName = "remm";
            this.colAttachInfo.Name = "colAttachInfo";
            this.colAttachInfo.Visible = true;
            this.colAttachInfo.VisibleIndex = 1;
            this.colAttachInfo.Width = 106;
            // 
            // repositoryItemMemoExEditAttachInfo
            // 
            this.repositoryItemMemoExEditAttachInfo.AutoHeight = false;
            this.repositoryItemMemoExEditAttachInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditAttachInfo.Name = "repositoryItemMemoExEditAttachInfo";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "اوامر";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 97;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "حذف";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 46;
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
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // ofd
            // 
            this.ofd.Filter = "All Files(*)|*.*|Images(*.Jpg)|*.jpg";
            // 
            // colAttachmentName
            // 
            this.colAttachmentName.AppearanceCell.Options.UseTextOptions = true;
            this.colAttachmentName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachmentName.Caption = "اسم النوع";
            this.colAttachmentName.FieldName = "AttachmentName";
            this.colAttachmentName.Name = "colAttachmentName";
            this.colAttachmentName.Visible = true;
            this.colAttachmentName.VisibleIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(105, 35);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // tblMemberTableAdapter
            // 
            this.tblMemberTableAdapter.ClearBeforeFill = true;
            // 
            // tblHafzaEstlamAttatchTableAdapter
            // 
            this.tblHafzaEstlamAttatchTableAdapter.ClearBeforeFill = true;
            // 
            // cDAttachTableAdapter
            // 
            this.cDAttachTableAdapter.ClearBeforeFill = true;
            // 
            // TblMemberAttachFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 423);
            this.Controls.Add(this.gcDetails);
            this.Controls.Add(this.gcOptions);
            this.Name = "TblMemberAttachFrm";
            this.Text = "المرفقات";
            this.Load += new System.EventHandler(this.MemberAttachFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcOptions)).EndInit();
            this.gcOptions.ResumeLayout(false);
            this.gcOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEMembers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowshipQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).EndInit();
            this.gcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHafzaEstlamAttatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFellowship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditAttahcmentTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDAttachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditAttachInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

    }
}