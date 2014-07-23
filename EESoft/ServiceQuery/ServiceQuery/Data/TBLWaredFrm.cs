using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace ServiceQuery
{
    public partial class TBLWaredFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        enum TableName : byte
        {
            All,
            CDEdara,
            CDserviceType,
            CDReply,
            CDSyndicate,
            CDSubCommitte,
            CDAttatech

        }
        #endregion
        #region -   Functions   -
        public TBLWaredFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(TableName SelectedTable)
        {
            switch (SelectedTable)
            {
                case TableName.CDEdara:
                    lueEdaraId.Properties.DataSource = SQLProvider.SelectCDEdara();
                    lueEdaraId.Properties.DisplayMember = "Edara";
                    lueEdaraId.Properties.ValueMember = "EdaraId";
                    repositoryItemGridLookUpEditEdaraId.DataSource = SQLProvider.SelectCDEdara();
                    repositoryItemGridLookUpEditEdaraId.DisplayMember = "Edara";
                    repositoryItemGridLookUpEditEdaraId.ValueMember = "EdaraId";
                    break;
                case TableName.CDserviceType:
                    lueserviceTypeId.Properties.DataSource = SQLProvider.SelectCDserviceType();
                    lueserviceTypeId.Properties.DisplayMember = "servicesType";
                    lueserviceTypeId.Properties.ValueMember = "serviceTypeId";
                    break;
                case TableName.CDSyndicate:
                    lueSyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    lueSyndicateId.Properties.DisplayMember = "Syndicate";
                    lueSyndicateId.Properties.ValueMember = "SyndicateId";
                    break;
                case TableName.CDSubCommitte:
                    lueSubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    lueSubCommitteId.Properties.DisplayMember = "SubCommitte";
                    lueSubCommitteId.Properties.ValueMember = "SubCommitteId";
                    break;
                case TableName.CDAttatech:
                    repositoryItemGridLookUpEditAttatechID.DataSource = SQLProvider.SelectCDAttatech();
                    repositoryItemGridLookUpEditAttatechID.DisplayMember = "Attatech";
                    repositoryItemGridLookUpEditAttatechID.ValueMember = "AttatechID";
                    break;
                case TableName.CDReply:
                    repositoryItemGridLookUpEditReplyid.DataSource = SQLProvider.SelectCDReply();
                    repositoryItemGridLookUpEditReplyid.DisplayMember = "Reply";
                    repositoryItemGridLookUpEditReplyid.ValueMember = "Replyid";
                    break;
                case TableName.All:
                    lueEdaraId.Properties.DataSource = SQLProvider.SelectCDEdara();
                    lueEdaraId.Properties.DisplayMember = "Edara";
                    lueEdaraId.Properties.ValueMember = "EdaraId";
                    repositoryItemGridLookUpEditEdaraId.DataSource = SQLProvider.SelectCDEdara();
                    repositoryItemGridLookUpEditEdaraId.DisplayMember = "Edara";
                    repositoryItemGridLookUpEditEdaraId.ValueMember = "EdaraId";

                    lueserviceTypeId.Properties.DataSource = SQLProvider.SelectCDserviceType();
                    lueserviceTypeId.Properties.DisplayMember = "servicesType";
                    lueserviceTypeId.Properties.ValueMember = "serviceTypeId";

                    lueSyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    lueSyndicateId.Properties.DisplayMember = "Syndicate";
                    lueSyndicateId.Properties.ValueMember = "SyndicateId";

                    lueSubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    lueSubCommitteId.Properties.DisplayMember = "SubCommitte";
                    lueSubCommitteId.Properties.ValueMember = "SubCommitteId";

                    repositoryItemGridLookUpEditAttatechID.DataSource = SQLProvider.SelectCDAttatech();
                    repositoryItemGridLookUpEditAttatechID.DisplayMember = "Attatech";
                    repositoryItemGridLookUpEditAttatechID.ValueMember = "AttatechID";

                    repositoryItemGridLookUpEditReplyid.DataSource = SQLProvider.SelectCDReply();
                    repositoryItemGridLookUpEditReplyid.DisplayMember = "Reply";
                    repositoryItemGridLookUpEditReplyid.ValueMember = "Replyid";
                    break;
                default:
                    break;
            }
        }
        private void LoadData()
        {
            DataTable TBLWared = SQLProvider.SelectTBLWared();
            LUETBLWared.Properties.DataSource = TBLWared;
            LUETBLWared.Properties.DisplayMember = "details";
            LUETBLWared.Properties.ValueMember = "WaredId";
           
        }
        private void LoadTBLWaredDetails_Attach(object WaredId)
        {
            DataTable dtDetails = SQLProvider.SelectTBLWaredDetails(WaredId); dtDetails.TableName = "details";
            DataTable dtAttach = SQLProvider.SelectTBLWaredAttach(WaredId); dtAttach.TableName = "attach";
            DataTable dtTransfer = SQLProvider.SelectTBLTransfer(WaredId); dtTransfer.TableName = "Transfer";
            DataTable dtReply = SQLProvider.SelectTBLReply(WaredId); dtReply.TableName = "Reply";

            DataSet ds = new DataSet("dataSetDetails");
            ds.Tables.AddRange(new DataTable[] { dtDetails, dtAttach, dtTransfer, dtReply });

            ds.Relations.Add("المرفقات", dtDetails.Columns["WaredDetailsID"], dtAttach.Columns["WaredDetailsID"]);
            ds.Relations.Add("التحويلات", dtDetails.Columns["WaredDetailsID"], dtTransfer.Columns["WaredDetailsID"]);
            ds.Relations.Add("الرد", dtDetails.Columns["WaredDetailsID"], dtReply.Columns["WaredDetailsID"]);

            gridControl1.DataSource = ds;
            gridControl1.DataMember = dtDetails.TableName;
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    FindCtr(this, "new");
                    break;
                case Keys.F6:
                    FindCtr(this, "save");
                    break;
                case Keys.F8:
                    FindCtr(this, "delete");
                    break;
                case Keys.F10:
                    FindCtr(this, "update");
                    break;
                default:
                    break;
            }

        }
        private static void FindCtr(Control MyControls, string tag)
        {
            foreach (Control ctr in MyControls.Controls)
            {
                if (ctr.HasChildren == true)
                {
                    FindCtr(ctr, tag);
                    continue;
                }
                if (ctr is SimpleButton)
                {
                    if (((SimpleButton)ctr).Tag.ToString() == tag)
                        ((SimpleButton)ctr).PerformClick();
                }
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("ServiceQuery" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            xtraTabControlMain.Visible = Selecting;
            btnNew.Visible = Inserting;
            btnUpdate.Visible = Updateing;
            btnDelete.Visible = Deleting;
            if (Inserting || Updateing)
            {
                //repositoryItemButtonEditCDRelativeCodeSave.Buttons[0].Enabled = true;
                //repositoryItemButtonEditrem_sudSave.Buttons[0].Enabled = true;
            }
            else
            {
                //repositoryItemButtonEditCDRelativeCodeSave.Buttons[0].Enabled = false;
                //repositoryItemButtonEditrem_sudSave.Buttons[0].Enabled = false;
            }
            if (Deleting)
            {
                //repositoryItemButtonEditCDRelativeCodeDel.Buttons[0].Enabled = true;
                //repositoryItemButtonEditrem_sudDel.Buttons[0].Enabled = true;
            }
            else
            {
                //repositoryItemButtonEditCDRelativeCodeDel.Buttons[0].Enabled = false;
                //repositoryItemButtonEditrem_sudDel.Buttons[0].Enabled = false;
            }
        }

        #endregion
        #region - Event Handlers -
        private void TBL_EmpFrm_Load(object sender, EventArgs e)
        {
            //ActivePriv();
            LoadDefaultData(TableName.All);
            LoadData();
        }
        private void LUETBLWared_EditValueChanged(object sender, EventArgs e)
        {
            if (LUETBLWared.EditValue == null)
            {
                btnNew_Click(btnNew, new EventArgs());

                xtraTabPageDetails.PageVisible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            if (LUETBLWared.ItemIndex == -1)
            {
                btnNew_Click(btnNew, new EventArgs());
                xtraTabPageDetails.PageVisible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            DataRow row = ((DataTable)LUETBLWared.Properties.DataSource).Rows[LUETBLWared.ItemIndex];

            lueEdaraId.EditValue = row["EdaraId"];
            lueserviceTypeId.EditValue = row["serviceTypeId"];
            lueSyndicateId.EditValue = row["SyndicateId"];
            lueSubCommitteId.EditValue = row["SubCommitteId"];
            deWaredDate.EditValue = row["WaredDate"];
            tbMandopName.Text = row["MandopName"].ToString();

            //Load Details
            LoadTBLWaredDetails_Attach(LUETBLWared.EditValue);


            xtraTabPageDetails.PageVisible = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;

            //refresh data inside controls
            for (int i = 0; i < xtraTabControlMain.TabPages.Count; i++)
                xtraTabControlMain.SelectedTabPageIndex = i;
            xtraTabControlMain.SelectedTabPageIndex = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            lueEdaraId.EditValue = null;
            lueserviceTypeId.EditValue = null;
            lueSyndicateId.EditValue = null;
            lueSubCommitteId.EditValue = null;
            deWaredDate.EditValue = null;
            tbMandopName.Text = string.Empty;

            xtraTabPageDetails.PageVisible = false;
            
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SQLProvider.InsertTBLWared(lueEdaraId.EditValue, lueserviceTypeId.EditValue, lueSyndicateId.EditValue, lueSubCommitteId.EditValue, deWaredDate.EditValue, tbMandopName.Text))
                {
                    LoadData();
                    btnNew_Click(btnNew, new EventArgs());
                    Program.ShowMsg("تم الاضافه", false, this);
                    Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                else
                {
                    Program.ShowMsg("لم يتم الاصافه", true, this);
                    Program.Logger.LogThis("لم يتم الاصافه", Text, FXFW.Logger.OpType.fail, null, null, this);
                }
                
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (SQLProvider.UpdateTBLWared(LUETBLWared.EditValue, lueEdaraId.EditValue, lueserviceTypeId.EditValue, lueSyndicateId.EditValue, lueSubCommitteId.EditValue, deWaredDate.EditValue, tbMandopName.Text))
                {
                    LoadData();
                    Program.ShowMsg("تم التعديل", false, this);
                    Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                else
                {
                    Program.ShowMsg("لم يتم التعديل", true, this);
                    Program.Logger.LogThis("لم يتم التعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                }

                LoadData();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                if (SQLProvider.DeleteTBLWared(LUETBLWared.EditValue))
                {
                    LoadData();
                    btnNew_Click(btnNew, new EventArgs());
                    Program.ShowMsg("تم الحذف", false, this);
                    Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                else
                {
                    Program.ShowMsg("لم يتم الحذف", true, this);
                    Program.Logger.LogThis("لم يتم الحذف", Text, FXFW.Logger.OpType.fail, null, null, this);
                }
                
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSave1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;
            DataRow rowgridView1 = gridViewdetails.GetFocusedDataRow();
            try
            {
                if (rowgridView1["WaredDetailsID"].ToString() == string.Empty)
                {
                    if (SQLProvider.InsertTBLWaredDetails(LUETBLWared.EditValue, rowgridView1["Mname"], rowgridView1["Mkid"], rowgridView1["Mmemberno"], rowgridView1["MmemberSARFno"], rowgridView1["DREMARK"]))
                    {
                        LoadTBLWaredDetails_Attach(LUETBLWared.EditValue);
                        Program.ShowMsg("تم الاضافه", false, this);
                        Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم الاصافه", true, this);
                        Program.Logger.LogThis("لم يتم الاصافه", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
                else
                {
                    if (SQLProvider.UpdateTBLWaredDetails(rowgridView1["WaredDetailsID"], rowgridView1["WaredId"], rowgridView1["Mname"], rowgridView1["Mkid"], rowgridView1["Mmemberno"], rowgridView1["MmemberSARFno"], rowgridView1["DREMARK"]))
                    {
                        LoadTBLWaredDetails_Attach(LUETBLWared.EditValue);
                        Program.ShowMsg("تم التعديل", false, this);
                        Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم التعديل", true, this);
                        Program.Logger.LogThis("لم يتم التعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
                

            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDelete1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataRow rowgridView1 = gridViewdetails.GetFocusedDataRow();
            try
            {
                if (rowgridView1["WaredDetailsID"].ToString() != string.Empty)
                {
                    if (SQLProvider.DeleteTBLWaredDetails(rowgridView1["WaredDetailsID"]))
                    {
                        LoadTBLWaredDetails_Attach(LUETBLWared.EditValue);
                        Program.ShowMsg("تم الحذف", false, this);
                        Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم الحذف", true, this);
                        Program.Logger.LogThis("لم يتم الحذف", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSaveAttach_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;


            DataRow rowdetail = ((ColumnView)((ColumnView)gridControl1.FocusedView).ParentView).GetFocusedDataRow();
            DataRow rowattach = ((ColumnView)gridControl1.FocusedView).GetFocusedDataRow();
            
            try
            {
                if (rowattach["org_AttatechID"].ToString() == string.Empty)
                {
                    if (SQLProvider.InsertTBLWaredAttach(rowdetail["WaredDetailsID"], rowattach["AttatechID"], rowattach["ATTREMARK"]))
                    {
                        //update data grid
                        rowattach["org_AttatechID"] = rowattach["AttatechID"];
                        rowattach["org_WaredDetailsID"] = rowattach["WaredDetailsID"];

                        Program.ShowMsg("تم الاضافه", false, this);
                        Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم الاصافه", true, this);
                        Program.Logger.LogThis("لم يتم الاصافه", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
                else
                {
                    if (SQLProvider.UpdateTBLWaredAttach(rowdetail["WaredDetailsID"], rowattach["AttatechID"], rowattach["ATTREMARK"], rowattach["org_WaredDetailsID"], rowattach["org_AttatechID"]))
                    {
                        Program.ShowMsg("تم التعديل", false, this);
                        Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم التعديل", true, this);
                        Program.Logger.LogThis("لم يتم التعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }


            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDeleteAttach_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            
            DataRow rowattach = ((ColumnView)gridControl1.FocusedView).GetFocusedDataRow();

            try
            {
                if (rowattach["org_AttatechID"].ToString() != string.Empty)
                {
                    if (SQLProvider.DeleteTBLWaredAttach(rowattach["org_WaredDetailsID"], rowattach["org_AttatechID"]))
                    {
                        //update data grid
                        int index = ((ColumnView)gridControl1.FocusedView).GetFocusedDataSourceRowIndex();
                        DataSet ds = (DataSet)gridControl1.DataSource; ds.Tables["attach"].Rows.RemoveAt(index);

                        Program.ShowMsg("تم الحذف", false, this);
                        Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم الحذف", true, this);
                        Program.Logger.LogThis("لم يتم الحذف", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSaveTransfer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;

            DataRow rowdetail = ((ColumnView)((ColumnView)gridControl1.FocusedView).ParentView).GetFocusedDataRow();
            DataRow rowTransfer = ((ColumnView)gridControl1.FocusedView).GetFocusedDataRow();

            try
            {
                if (rowTransfer["org_EdaraId"].ToString() == string.Empty)
                {
                    if (SQLProvider.InsertTBLTransfer(rowdetail["WaredDetailsID"], rowTransfer["EdaraId"], rowTransfer["transferdate"], rowTransfer["recive"]))
                    {
                        //update data grid
                        rowTransfer["org_WaredDetailsID"] = rowTransfer["WaredDetailsID"];
                        rowTransfer["org_EdaraId"] = rowTransfer["EdaraId"];
                        rowTransfer["org_transferdate"] = rowTransfer["transferdate"];

                        Program.ShowMsg("تم الاضافه", false, this);
                        Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم الاصافه", true, this);
                        Program.Logger.LogThis("لم يتم الاصافه", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
                else
                {
                    if (SQLProvider.UpdateTBLTransfer(rowdetail["WaredDetailsID"], rowTransfer["EdaraId"], rowTransfer["transferdate"], rowTransfer["recive"], rowTransfer["org_WaredDetailsID"], rowTransfer["org_EdaraId"], rowTransfer["org_transferdate"]))
                    {
                        Program.ShowMsg("تم التعديل", false, this);
                        Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم التعديل", true, this);
                        Program.Logger.LogThis("لم يتم التعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }

            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDeleteTransfer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            DataRow rowTransfer = ((ColumnView)gridControl1.FocusedView).GetFocusedDataRow();

            try
            {
                if (rowTransfer["org_EdaraId"].ToString() != string.Empty)
                {
                    if (SQLProvider.DeleteTBLTransfer(rowTransfer["org_WaredDetailsID"], rowTransfer["org_EdaraId"], rowTransfer["org_transferdate"]))
                    {
                        //update data grid
                        int index = ((ColumnView)gridControl1.FocusedView).GetFocusedDataSourceRowIndex();
                        DataSet ds = (DataSet)gridControl1.DataSource; ds.Tables["Transfer"].Rows.RemoveAt(index);

                        Program.ShowMsg("تم الحذف", false, this);
                        Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم الحذف", true, this);
                        Program.Logger.LogThis("لم يتم الحذف", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSaveReply_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;

            DataRow rowdetail = ((ColumnView)((ColumnView)gridControl1.FocusedView).ParentView).GetFocusedDataRow();
            DataRow rowTransfer = ((ColumnView)gridControl1.FocusedView).GetFocusedDataRow();

            try
            {
                if (rowTransfer["org_EdaraId"].ToString() == string.Empty)
                {
                    if (SQLProvider.InsertTBLReply(rowdetail["WaredDetailsID"], rowTransfer["EdaraId"], rowTransfer["Replyid"], rowTransfer["Replydate"], rowTransfer["replyremark"]))
                    {
                        //update data grid
                        rowTransfer["org_WaredDetailsID"] = rowTransfer["WaredDetailsID"];
                        rowTransfer["org_EdaraId"] = rowTransfer["EdaraId"];
                        rowTransfer["org_Replyid"] = rowTransfer["Replyid"];

                        Program.ShowMsg("تم الاضافه", false, this);
                        Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم الاصافه", true, this);
                        Program.Logger.LogThis("لم يتم الاصافه", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
                else
                {
                    if (SQLProvider.UpdateTBLReply(rowdetail["WaredDetailsID"], rowTransfer["EdaraId"], rowTransfer["Replyid"], rowTransfer["Replydate"], rowTransfer["replyremark"], rowTransfer["org_WaredDetailsID"], rowTransfer["org_EdaraId"], rowTransfer["org_Replyid"]))
                    {
                        Program.ShowMsg("تم التعديل", false, this);
                        Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم التعديل", true, this);
                        Program.Logger.LogThis("لم يتم التعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }

            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDeleteReply_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUETBLWared.EditValue == null)
                return;
            if (LUETBLWared.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            DataRow rowTransfer = ((ColumnView)gridControl1.FocusedView).GetFocusedDataRow();

            try
            {
                if (rowTransfer["org_EdaraId"].ToString() != string.Empty)
                {
                    if (SQLProvider.DeleteTBLReply(rowTransfer["org_WaredDetailsID"], rowTransfer["org_EdaraId"], rowTransfer["org_Replyid"]))
                    {
                        //update data grid
                        int index = ((ColumnView)gridControl1.FocusedView).GetFocusedDataSourceRowIndex();
                        DataSet ds = (DataSet)gridControl1.DataSource; ds.Tables["Reply"].Rows.RemoveAt(index);

                        Program.ShowMsg("تم الحذف", false, this);
                        Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    else
                    {
                        Program.ShowMsg("لم يتم الحذف", true, this);
                        Program.Logger.LogThis("لم يتم الحذف", Text, FXFW.Logger.OpType.fail, null, null, this);
                    }
                }
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }

#endregion         #region -   Variables   -

    }
}

