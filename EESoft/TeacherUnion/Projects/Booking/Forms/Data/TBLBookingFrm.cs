using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Booking
{
    public partial class TBLBookingFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLBookingFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames SelectedTable)
        {
            switch (SelectedTable)
            {
                case CodeFrm.TableNames.CDHall:
                    //CDHall
                    LUEhallId.Properties.DataSource = SQLProvider.SelectCDHall();
                    LUEhallId.Properties.DisplayMember = "hallName";
                    LUEhallId.Properties.ValueMember = "hallId";
                    break;
                case CodeFrm.TableNames.CDFatra:
                    //CDFatra
                    LUEFatraId.Properties.DataSource = SQLProvider.SelectCDFatra();
                    LUEFatraId.Properties.DisplayMember = "Fatra";
                    LUEFatraId.Properties.ValueMember = "FatraId";
                    break;
                case CodeFrm.TableNames.TBLWorker:
                    //TBLWorker
                    LUEWorkerId.Properties.DataSource = SQLProvider.SelectTBLWorker();
                    LUEWorkerId.Properties.DisplayMember = "Worker";
                    LUEWorkerId.Properties.ValueMember = "WorkerId";
                    break;
                case CodeFrm.TableNames.CDEradType:
                    //CDEradType
                    repositoryItemGridLookUpEditEradTypeId.DataSource = SQLProvider.SelectCDEradType();
                    repositoryItemGridLookUpEditEradTypeId.DisplayMember = "EradType";
                    repositoryItemGridLookUpEditEradTypeId.ValueMember = "EradTypeId";
                    break;
                case CodeFrm.TableNames.CDMonsrefType:
                    //CDMonsrefType
                    repositoryItemGridLookUpEditMonsrefTypeId.DataSource = SQLProvider.SelectCDMonsrefType();
                    repositoryItemGridLookUpEditMonsrefTypeId.DisplayMember = "MonsrefType";
                    repositoryItemGridLookUpEditMonsrefTypeId.ValueMember = "MonsrefTypeId";
                    break;
                case CodeFrm.TableNames.All:
                    //CDHall
                    LUEhallId.Properties.DataSource = SQLProvider.SelectCDHall();
                    LUEhallId.Properties.DisplayMember = "hallName";
                    LUEhallId.Properties.ValueMember = "hallId";
                    //CDFatra
                    LUEFatraId.Properties.DataSource = SQLProvider.SelectCDFatra();
                    LUEFatraId.Properties.DisplayMember = "Fatra";
                    LUEFatraId.Properties.ValueMember = "FatraId";
                    //TBLWorker
                    LUEWorkerId.Properties.DataSource = SQLProvider.SelectTBLWorker();
                    LUEWorkerId.Properties.DisplayMember = "Worker";
                    LUEWorkerId.Properties.ValueMember = "WorkerId";
                    //CDEradType
                    repositoryItemGridLookUpEditEradTypeId.DataSource = SQLProvider.SelectCDEradType();
                    repositoryItemGridLookUpEditEradTypeId.DisplayMember = "EradType";
                    repositoryItemGridLookUpEditEradTypeId.ValueMember = "EradTypeId";
                    //CDMonsrefType
                    repositoryItemGridLookUpEditMonsrefTypeId.DataSource = SQLProvider.SelectCDMonsrefType();
                    repositoryItemGridLookUpEditMonsrefTypeId.DisplayMember = "MonsrefType";
                    repositoryItemGridLookUpEditMonsrefTypeId.ValueMember = "MonsrefTypeId";
                    break;
                default:
                    break;
            }
        }
        private void LoadData()
        {
            LUEBooking.Properties.DataSource = SQLProvider.SelectTBLBooking();
        }
        private void LoadGridEx()
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEBooking.EditValue))
                gridControlData1.DataSource = SQLProvider.SelectTBLBEradat(null);
            else
                gridControlData1.DataSource = SQLProvider.SelectTBLBEradat(LUEBooking.EditValue);

            if (FXFW.SqlDB.IsNullOrEmpty(LUEBooking.EditValue))
                gridControlData2.DataSource = SQLProvider.SelectTBLMasrofat(null);
            else
                gridControlData2.DataSource = SQLProvider.SelectTBLMasrofat(LUEBooking.EditValue);
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
        private void ActiveKeyDownEventGrid1(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData1.DataSource).Rows.Add(((DataTable)gridControlData1.DataSource).NewRow());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActiveKeyDownEventGrid2(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData2.DataSource).Rows.Add(((DataTable)gridControlData2.DataSource).NewRow());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave2_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel2_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave2_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            return;
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Retirement" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
        private void TBLBookingFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadData();
        }
        private void LUEhallId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CDHallFrm FrmCDHall = new CDHallFrm();
            FrmCDHall.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDHall);
        }
        private void LUEFatraId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDFatra);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDFatra);
        }
        private void LUEWorkerId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            TBLWorkerFrm FrmTBLWorker = new TBLWorkerFrm();
            FrmTBLWorker.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.TBLWorker);
        }
        private void repositoryItemGridLookUpEditEradTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEradType);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDEradType);
        }
        private void repositoryItemGridLookUpEditMonsrefTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDMonsrefType);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDMonsrefType);
        }
        private void LUEBooking_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEBooking.EditValue == null)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            if (LUEBooking.ItemIndex == -1)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            DataRow row = ((DataTable)LUEBooking.Properties.DataSource).Rows[LUEBooking.ItemIndex];

            tbBookingName.Text = row["BookingName"].ToString();
            LUEhallId.EditValue = row["hallId"];
            DEBookingDate.EditValue = row["BookingDate"];
            LUEFatraId.EditValue = row["FatraId"];
            LUEWorkerId.EditValue = row["WorkerId"];
            tbBookingMobile.Text = row["BookingMobile"].ToString();

            LoadGridEx();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            xtraTabPageBEradat.PageVisible = true;
            xtraTabPageMasrofat.PageVisible = true;
            //refresh data inside controls
            for (int i = 0; i < xtraTabControlMain.TabPages.Count; i++)
                xtraTabControlMain.SelectedTabPageIndex = i;
            xtraTabControlMain.SelectedTabPageIndex = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tbBookingName.Text = string.Empty;
            LUEhallId.EditValue = null;
            DEBookingDate.EditValue = null;
            LUEFatraId.EditValue = null;
            LUEWorkerId.EditValue = null;
            tbBookingMobile.Text = string.Empty;
           
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            xtraTabPageBEradat.PageVisible = false;
            xtraTabPageMasrofat.PageVisible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                SQLProvider.InsertTBLBooking(DEBookingDate.EditValue, LUEhallId.EditValue, LUEFatraId.EditValue, tbBookingName.Text, 
                    tbBookingMobile.Text, LUEWorkerId.EditValue);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                LoadGridEx();
                LUEBooking.ItemIndex = LUEBooking.Properties.DropDownRows;
                xtraTabPageBEradat.PageVisible = true;
                xtraTabPageMasrofat.PageVisible = true;
                xtraTabControlMain.SelectedTabPage = xtraTabPageBEradat;
                //btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEBooking.EditValue))
                return;
            try
            {
                SQLProvider.UpdateTBLBooking(LUEBooking.EditValue, DEBookingDate.EditValue, LUEhallId.EditValue, LUEFatraId.EditValue, tbBookingName.Text,
                    tbBookingMobile.Text, LUEWorkerId.EditValue);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
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
            if (LUEBooking.EditValue == null)
                return;
            if (LUEBooking.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                SQLProvider.DeleteTBLBooking(LUEBooking.EditValue);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow row = gridViewData1.GetFocusedDataRow();
                if (row["org_BookingId"].ToString() == string.Empty)
                {
                    SQLProvider.InsertTBLBEradat(LUEBooking.EditValue, row["EradTypeId"], row["EradDate"], row["EradMony"], row["Ebean"]);
                }
                else
                {
                    SQLProvider.UpdateTBLBEradat(row["BookingId"], row["EradTypeId"], row["EradDate"], row["EradMony"], row["Ebean"],
                        row["org_BookingId"], row["org_EradTypeId"]);
                }
                LoadGridEx();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                DataRow row = gridViewData1.GetFocusedDataRow();
                if (row["org_BookingId"].ToString() != string.Empty)
                    SQLProvider.DeleteTBLBEradat(row["org_BookingId"], row["org_EradTypeId"]);
                LoadGridEx();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSave2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow row = gridViewData2.GetFocusedDataRow();
                if (row["org_BookingId"].ToString() == string.Empty)
                {
                    SQLProvider.InsertTBLMasrofat(LUEBooking.EditValue, row["MonsrefTypeId"], row["MonsrefDate"], row["MonsrefMony"], row["Mbean"]);
                }
                else
                {
                    SQLProvider.UpdateTBLMasrofat(row["BookingId"], row["MonsrefTypeId"], row["MonsrefDate"], row["MonsrefMony"], row["Mbean"],
                        row["org_BookingId"], row["org_MonsrefTypeId"]);
                }
                LoadGridEx();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                DataRow row = gridViewData2.GetFocusedDataRow();
                if (row["org_BookingId"].ToString() != string.Empty)
                    SQLProvider.DeleteTBLMasrofat(row["org_BookingId"], row["org_MonsrefTypeId"]);
                LoadGridEx();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
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

