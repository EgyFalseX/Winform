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

namespace schoolStore
{
    public partial class DataSellBillFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable AsnafTbl = new DataTable();
        DataTable Customers = new DataTable();
        DataTable BillPayTypeTbl = new DataTable("BillPayType");
        DataTable EMPTbl = new DataTable("EMP");
        DataTable STORETbl = new DataTable("STORE");
        DataTable ItemDetials = new DataTable();
        DataTable BillsTbl = new DataTable();
        DataTable BillsDetialTbl = new DataTable();

        public DataSellBillFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            // Get All Asnaf Types
            AsnafTbl = new DataTable();
            AsnafTbl = FXFW.SqlDB.LoadDataTable("Select SanfID, SanfName, TagzeaSellprice, TagzeaUnit,(Select SalesUnitName From CDSalesUnit Where SalesUnitID = CDASNAF.TagzeaUnit) AS UnitName From CDASNAF");
            repositoryItemLookUpEditAddSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditAddSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditAddSanfID.ValueMember = "SanfID";
            // Get New ID
            TxtBillID.Text = string.Empty;
            TxtBillID.Text = Program.GetNewID("TBLOUT", "OUTID");
            // Get All Customers Name
            Customers = FXFW.SqlDB.LoadDataTable("SELECT CustomerID, Customer, CustomerOfficial, CustomerAddess, CustomerTel, CustomerMobil FROM CDCustomers");
            LUECustomer.Properties.DataSource = Customers;
            LUECustomer.Properties.DisplayMember = "Customer";
            LUECustomer.Properties.ValueMember = "CustomerID";
            // Get All Bill Pay Types
            BillPayTypeTbl = FXFW.SqlDB.LoadDataTable("SELECT BillPayTypeID, BillPayTypeName FROM BillPayType");
            LUEBillPayType.Properties.DataSource = BillPayTypeTbl;
            LUEBillPayType.Properties.DisplayMember = "BillPayTypeName";
            LUEBillPayType.Properties.ValueMember = "BillPayTypeID";
            // Get All Emp Names
            EMPTbl = FXFW.SqlDB.LoadDataTable("SELECT EMPID, EMPNAME, EMPPHONE, EMPMOBIL FROM TBLEMP");
            LUEEmp.Properties.DataSource = EMPTbl;
            LUEEmp.Properties.DisplayMember = "EMPNAME";
            LUEEmp.Properties.ValueMember = "EMPID";
            // Get All Storages Name
            STORETbl = FXFW.SqlDB.LoadDataTable("SELECT StoreID, StoreName, StorePlace, StoreTel, StoreMobil FROM CDSTORE");
            LUEStorage.Properties.DataSource = STORETbl;
            LUEStorage.Properties.DisplayMember = "StoreName";
            LUEStorage.Properties.ValueMember = "StoreID";
            //Edit Grid
            // Bill Pay Types
            repositoryItemLookUpEditEditBillOUTTypeID.DataSource = BillPayTypeTbl;
            repositoryItemLookUpEditEditBillOUTTypeID.DisplayMember = "BillPayTypeName";
            repositoryItemLookUpEditEditBillOUTTypeID.ValueMember = "BillPayTypeID";
            // Get Customers Name
            repositoryItemLookUpEditEditCustomerID.DataSource = Customers;
            repositoryItemLookUpEditEditCustomerID.DisplayMember = "Customer";
            repositoryItemLookUpEditEditCustomerID.ValueMember = "CustomerID";
            // Get Emps Name
            repositoryItemLookUpEditEditEMPID.DataSource = EMPTbl;
            repositoryItemLookUpEditEditEMPID.DisplayMember = "EMPNAME";
            repositoryItemLookUpEditEditEMPID.ValueMember = "EMPID";
            // Get Storages Name
            repositoryItemLookUpEditEditStoreID.DataSource = STORETbl;
            repositoryItemLookUpEditEditStoreID.DisplayMember = "StoreName";
            repositoryItemLookUpEditEditStoreID.ValueMember = "StoreID";
            // Get Asnafs Name
            repositoryItemLookUpEditEditDetialSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditEditDetialSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditEditDetialSanfID.ValueMember = "SanfID";
        }
        private void ClearForm()
        {
            TxtBillID.Text = string.Empty;
            DEBillDate.EditValue = null;
            LUECustomer.EditValue = null;
            LUEEmp.EditValue = null;
            LUEStorage.EditValue = null;
            LUEBillPayType.EditValue = null;
            TxtDiscount.Text = string.Empty;
            TxtExtraPayValue.Text = string.Empty;
            MemInfo.Text = string.Empty;
            LblTotal.Text = "0";
            ItemDetials.Rows.Clear();
        }
        private void ClacTotal()
        {
            Single price, count, dis;
            if (ItemDetials.Rows.Count > 0)
            {
                count = FXFW.SqlDB.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["outQuantity"].ToString());
                price = FXFW.SqlDB.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["outPrice"].ToString());
                dis = FXFW.SqlDB.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["DiscountPercent"].ToString());
                ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Total"] = ((count * price) - dis).ToString();
                Single totaldis, extra;
                extra = FXFW.SqlDB.ConvertStringToInt(TxtExtraPayValue.Text);
                totaldis = FXFW.SqlDB.ConvertStringToInt(TxtDiscount.Text);
                LblTotal.Text = ((Convert.ToInt32(ItemDetials.Compute("Sum(Total)", "")) + extra) - totaldis).ToString();
            }
            if (Convert.ToInt16(LblTotal.Text) < 0)
            {
                MessageBox.Show("اجمالي الفاتوره ليس صحيح", "بيانات غير صحيحيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnSave.Enabled = false;
            }
            else
                BtnSave.Enabled = true;
        }
        private void LoadEditGrid()
        { 
            //GridControlEdit
            BillsTbl = new DataTable();
            BillsTbl = FXFW.SqlDB.LoadDataTable("SELECT OUTID, BillOUTTypeID, OUTDate, CustomerID, EMPID, TotalkasmPercent, ExtraFees, REM, StoreID FROM TBLOUT");
            GridControlEdit.DataSource = BillsTbl;
        }
        private void GetBillDetial()
        {
            if (gridViewEdit.FocusedRowHandle >= 0 && gridViewEdit.SelectedRowsCount > 0)
            {
                GridControlEditDetial.DataSource = null;
                BillsDetialTbl = new DataTable();
                DataRow row = gridViewEdit.GetFocusedDataRow();
                if (row == null)
                    return;
                SqlDataAdapter da = new SqlDataAdapter("", FXFW.SqlDB.SqlConStr);
                da.SelectCommand.CommandText = "SELECT outID, SanfID, UnitID, (Select SalesUnitName From CDSalesUnit Where SalesUnitID = TBLOUTDetailes.UnitID) AS UnitName, outQuantity, outPrice, DiscountPercent, (outQuantity*outPrice) - DiscountPercent AS Total FROM TBLOUTDetailes Where outID = " + row["outID"].ToString() + " ORDER BY orderin";
                da.Fill(BillsDetialTbl);
                GridControlEditDetial.DataSource = BillsDetialTbl;
            }
        }
        private void DataBuyBillFrm_Load(object sender, EventArgs e)
        {
            ItemDetials.Columns.Add("outID");
            ItemDetials.Columns.Add("SanfID");
            ItemDetials.Columns.Add("UnitID");
            ItemDetials.Columns.Add("UnitName");
            ItemDetials.Columns.Add("outQuantity", typeof(Single));
            ItemDetials.Columns.Add("outPrice", typeof(Single));
            ItemDetials.Columns.Add("DiscountPercent", typeof(Single));
            ItemDetials.Columns.Add("Total", typeof(Single));
            GridControlAddDetials.DataSource = ItemDetials;
            //
            ClearForm();
            LoadDefaultData();
            LoadEditGrid();
            if (TxtBillID.Text.Trim().Length != 0)
                BtnSave.Enabled = true;
            else
                BtnSave.Enabled = false;
        }
        private void repositoryItemLookUpEditAddSanfID_EditValueChanged(object sender, EventArgs e)
        {
            BtnSave.Focus();
            gridViewAdd.Focus();
            LookUpEdit LUE = (LookUpEdit)sender;
            ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["UnitID"] = AsnafTbl.Rows[LUE.ItemIndex]["TagzeaUnit"].ToString();
            ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["UnitName"] = AsnafTbl.Rows[LUE.ItemIndex]["UnitName"].ToString();
        }
        private void gridViewAdd_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridViewAdd.UpdateCurrentRow();
            if (e.Column == GCoutQuantity || e.Column == GCoutPrice || e.Column == GCDiscountPercent)
            {
                ClacTotal();
            }
        }
        private void TxtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            ClacTotal();
        }
        private void TxtExtraPayValue_EditValueChanged(object sender, EventArgs e)
        {
            ClacTotal();
        }
        private void repositoryItemButtonEditSort_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = gridViewAdd.FocusedRowHandle;
            DataRow row1 = null;
            DataRow row2 = null;
            if (e.Button.Index == 0)
            {
                if (index <= 0) return;
                row1 = gridViewAdd.GetDataRow(index);
                row2 = gridViewAdd.GetDataRow(index - 1);
            }
            else
            {
                if (gridViewAdd.IsLastRow) return;
                row1 = gridViewAdd.GetDataRow(index);
                row2 = gridViewAdd.GetDataRow(index + 1);
            }
            string outID1, SanfID1, UnitID1, UnitName1, outQuantity1, outPrice1, DiscountPercent1, Total1;
            string outID2, SanfID2, UnitID2, UnitName2, outQuantity2, outPrice2, DiscountPercent2, Total2;
            //save data in row 1
            outID1 = row1["outID"].ToString();
            SanfID1 = row1["SanfID"].ToString();
            UnitID1 = row1["UnitID"].ToString();
            UnitName1 = row1["UnitName"].ToString();
            outQuantity1 = row1["outQuantity"].ToString();
            outPrice1 = row1["outPrice"].ToString();
            DiscountPercent1 = row1["DiscountPercent"].ToString();
            Total1 = row1["Total"].ToString();
            //save data in row 2
            outID2 = row2["outID"].ToString();
            SanfID2 = row2["SanfID"].ToString();
            UnitID2 = row2["UnitID"].ToString();
            UnitName2 = row2["UnitName"].ToString();
            outQuantity2 = row2["outQuantity"].ToString();
            outPrice2 = row2["outPrice"].ToString();
            DiscountPercent2 = row2["DiscountPercent"].ToString();
            Total2 = row2["Total"].ToString();
            //save data to row1
            row1["outID"] = outID2;
            row1["SanfID"] = SanfID2;
            row1["UnitID"] = UnitID2;
            row1["UnitName"] = UnitName2;
            row1["outQuantity"] = outQuantity2;
            row1["outPrice"] = outPrice2;
            row1["DiscountPercent"] = FXFW.SqlDB.ConvertStringToInt(DiscountPercent2);
            row1["Total"] = Total2;
            //save data to row2
            row2["outID"] = outID1;
            row2["SanfID"] = SanfID1;
            row2["UnitID"] = UnitID1;
            row2["UnitName"] = UnitName1;
            row2["outQuantity"] = outQuantity1;
            row2["outPrice"] = outPrice1;
            row2["DiscountPercent"] = FXFW.SqlDB.ConvertStringToInt(DiscountPercent1);
            row2["Total"] = Total1;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //check for  - data
            if (TxtBillID.Text.Trim().Length == 0 || DEBillDate.EditValue == null || LUECustomer.EditValue == null || LUEEmp.EditValue == null || LUEStorage.EditValue == null || LUEBillPayType.EditValue == null)
            {
                string ErrorText = "يجب ادخال كلا من" + "\n";
                ErrorText += "تاريخ الفاتوره" + "\n";
                ErrorText += "اسم المورد" + "\n";
                ErrorText += "المستلم" + "\n";
                ErrorText += "المخزن" + "\n";
                ErrorText += "نوع الدفع";
                MessageBox.Show(ErrorText, "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ItemDetials.Rows.Count == 0)
            {
                MessageBox.Show("يجب ادخال تفاصيل الفاتوره", "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataRow row in ItemDetials.Rows)
            {
                if (row["SanfID"].ToString() == string.Empty)
                {
                    MessageBox.Show("يجب ادخال الصنف", "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            SqlTransaction Trn = null;
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                string BillOUTTypeID = "NULL", OUTDate = "NULL", CustomerID = "NULL", EMPID = "NULL", StoreID = "NULL";
                string TotalkasmPercent = "0", ExtraFees = "0", REM = "NULL", OUTID = "NULL";
                string TheTime = "'" + DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "'";
                OUTID = Program.GetNewID("TBLOUT", "OUTID");
                if (LUEBillPayType.EditValue != null)
                    BillOUTTypeID = LUEBillPayType.EditValue.ToString();
                if (DEBillDate.EditValue != null)
                    OUTDate = "'" + FXFW.SqlDB.ConvertToDateDMY(DEBillDate.EditValue.ToString()) + "'";
                if (LUECustomer.EditValue != null)
                    CustomerID = LUECustomer.EditValue.ToString();
                if (LUEEmp.EditValue != null)
                    EMPID = LUEEmp.EditValue.ToString();
                if (LUEStorage.EditValue != null)
                    StoreID = LUEStorage.EditValue.ToString();
                if (TxtDiscount.Text.Trim().Length != 0)
                    TotalkasmPercent = TxtDiscount.Text.Trim();
                if (TxtExtraPayValue.Text.Trim().Length != 0)
                    ExtraFees = TxtExtraPayValue.Text.Trim();
                if (MemInfo.Text.Trim().Length != 0)
                    REM = "N'" + MemInfo.Text.Trim() + "'";
                Cmd.CommandText = string.Format("Set Dateformat dmy INSERT INTO TBLOUT (OUTID, BillOUTTypeID, OUTDate, CustomerID, EMPID, TotalkasmPercent, ExtraFees, REM, UserIN, TimeIN, StoreID) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", OUTID, BillOUTTypeID, OUTDate, CustomerID, EMPID, TotalkasmPercent, ExtraFees, REM, FXFW.SqlDB.UserInfo.UserID, TheTime, StoreID);
                Cmd.ExecuteNonQuery();
                int orderin = 0;
                foreach (DataRow row in ItemDetials.Rows)
                {
                    string SanfID = "NULL", UnitID = "NULL", outQuantity = "0", outPrice = "0", DiscountPercent = "0";
                    SanfID = row["SanfID"].ToString();
                    if (row["UnitID"].ToString() != string.Empty)
                        UnitID = row["UnitID"].ToString();
                    if (row["outQuantity"].ToString() != string.Empty)
                        outQuantity = row["outQuantity"].ToString();
                    if (row["outPrice"].ToString() != string.Empty)
                        outPrice = row["outPrice"].ToString();
                    if (row["DiscountPercent"].ToString() != string.Empty)
                        DiscountPercent = row["DiscountPercent"].ToString();
                    orderin++;
                    Cmd.CommandText = string.Format("INSERT INTO TBLOUTDetailes (outID, SanfID, UnitID, outQuantity, outPrice, DiscountPercent, orderin) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})", OUTID, SanfID, UnitID, outQuantity, outPrice, DiscountPercent, orderin);
                    Cmd.ExecuteNonQuery();
                }
                Trn.Commit();
                MessageBox.Show("تم حفظ الفاتوره", "تمت الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                DEBillDate.Focus();
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void repositoryItemButtonEditEditUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Update Bill
            if (MessageBox.Show("هل ترغب في التعديل؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            DataRow row = gridViewEdit.GetFocusedDataRow();
            string OUTDate = "NULL", CustomerID = "NULL", EMPID = "NULL", TotalkasmPercent = "0", ExtraFees = "0", REM = "NULL", UserIN = FXFW.SqlDB.UserInfo.UserID, TimeIN = "NULL", StoreID = "NULL", BillOUTTypeID = "NULL";
            TimeIN = "'" + DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "'";
            if (row["OUTDate"].ToString() != string.Empty)
                OUTDate = "'" + FXFW.SqlDB.ConvertToDateDMY(row["OUTDate"].ToString()) + "'";
            if (row["CustomerID"].ToString() != string.Empty)
                CustomerID = row["CustomerID"].ToString();
            if (row["EMPID"].ToString() != string.Empty)
                EMPID = row["EMPID"].ToString();
            if (row["TotalkasmPercent"].ToString() != string.Empty)
                TotalkasmPercent = row["TotalkasmPercent"].ToString();
            if (row["ExtraFees"].ToString() != string.Empty)
                ExtraFees = row["ExtraFees"].ToString();
            if (row["REM"].ToString() != string.Empty)
                REM = "N'" + row["REM"].ToString() + "'";
            if (row["StoreID"].ToString() != string.Empty)
                StoreID = row["StoreID"].ToString();
            if (row["BillOUTTypeID"].ToString() != string.Empty)
                BillOUTTypeID = row["BillOUTTypeID"].ToString();

            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = string.Format("Set Dateformat dmy UPDATE TBLOUT SET OUTDate = {0}, CustomerID = {1}, EMPID = {2}, TotalkasmPercent = {3}, ExtraFees = {4}, REM = {5}, UserIN = {6}, TimeIN = {7}, StoreID = {8},  BillOUTTypeID = {9} WHERE (OUTID = {10})", OUTDate, CustomerID, EMPID, TotalkasmPercent, ExtraFees, REM, UserIN, TimeIN, StoreID, BillOUTTypeID, row["OUTID"].ToString());
                Cmd.ExecuteNonQuery();
                MessageBox.Show("تم تعديل الفاتوره", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void repositoryItemButtonEditEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete Bill
            if (MessageBox.Show("هل ترغب في الحذف؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            DataRow row = gridViewEdit.GetFocusedDataRow();
            SqlCommand Cmd = new SqlCommand("", Con);
            SqlTransaction Trn = null;
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                Cmd.CommandText = "DELETE FROM TBLOUTDetailes WHERE (outID = " + row["outID"].ToString() + ")";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "DELETE FROM TBLOUT WHERE (OUTID = " + row["OUTID"].ToString() + ")";
                Cmd.ExecuteNonQuery();
                Trn.Commit();
                LoadEditGrid();
                MessageBox.Show("تم حذف الفاتوره", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void gridViewEditDetial_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column != GCEditDetialAsnaf)
                return;
            if (MessageBox.Show("هل ترغب في التعديل؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int index = gridViewEditDetial.GetDataSourceRowIndex(gridViewEditDetial.FocusedRowHandle);
            DataRow row = BillsDetialTbl.Rows[index];
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            string SanfID = "NULL", UnitID = "NULL";
            SanfID = e.Value.ToString();
            foreach (DataRow r in AsnafTbl.Rows)
            {
                if (r["SanfID"].ToString() == SanfID)
                {
                    UnitID = r["TagzeaUnit"].ToString();
                    break;
                }
            }
            SqlCommand Cmd = new SqlCommand("UPDATE TBLOUTDetailes SET SanfID = " + SanfID + ",UnitID = " + UnitID + " WHERE (outID = " + row["outID"].ToString() + ") AND (SanfID = " + row["SanfID"].ToString() + ")", Con);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                GetBillDetial();
                MessageBox.Show("تم تعديل الصنف", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void repositoryItemButtonEditEditDetialUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Update Detial
            gridViewEditDetial.UpdateCurrentRow();
            if (MessageBox.Show("هل ترغب في التعديل؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int index = gridViewEditDetial.GetDataSourceRowIndex(gridViewEditDetial.FocusedRowHandle);

            DataRow row = BillsDetialTbl.Rows[index];
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand(string.Format("UPDATE TBLOUTDetailes SET SanfID = {0}, UnitID = {1}, outQuantity = {2}, outPrice = {3}, DiscountPercent = {4} WHERE (outID = {5}) AND (SanfID = {6})", row["SanfID"].ToString(), row["UnitID"].ToString(), row["outQuantity"].ToString(), row["outPrice"].ToString(), row["DiscountPercent"].ToString(), gridViewEdit.GetFocusedDataRow()["outID"].ToString(), row["SanfID"].ToString()), Con);
            try
            {
                Con.Open();
                if (Cmd.ExecuteNonQuery() == 0)
                {
                    int orderin;
                    string SanfID = "NULL", UnitID = "NULL", outQuantity = "0", outPrice = "0", DiscountPercent = "0", outID = gridViewEdit.GetFocusedDataRow()["outID"].ToString();
                    SanfID = row["SanfID"].ToString();
                    UnitID = row["UnitID"].ToString();
                    if (row["outQuantity"].ToString() != string.Empty)
                        outQuantity = row["outQuantity"].ToString();
                    if (row["outPrice"].ToString() != string.Empty)
                        outPrice = row["outPrice"].ToString();
                    if (row["DiscountPercent"].ToString() != string.Empty)
                        DiscountPercent = row["DiscountPercent"].ToString();
                    orderin = (int)FXFW.SqlDB.ConvertStringToInt(Program.GetNewID("TBLOUTDetailes", "orderin")) + 1;
                    Cmd.CommandText = string.Format("INSERT INTO TBLOUTDetailes (outID, SanfID, UnitID, outQuantity, outPrice, DiscountPercent, orderin) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})", outID, SanfID, UnitID, outQuantity, outPrice, DiscountPercent, orderin);
                    Cmd.ExecuteNonQuery();
                }
                GetBillDetial();
                MessageBox.Show("تم تعديل الصنف", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void repositoryItemButtonEditditDetialDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete Detial
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int index = gridViewEditDetial.GetDataSourceRowIndex(gridViewEditDetial.FocusedRowHandle);
            DataRow row = BillsDetialTbl.Rows[index];
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("DELETE FROM TBLOUTDetailes WHERE (outID = " + row["outID"].ToString() + ") AND (SanfID = " + row["SanfID"].ToString() + ")", Con);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                GetBillDetial();
                MessageBox.Show("تم حذف الصنف", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void gridViewEdit_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetBillDetial();
        }
        private void repositoryItemLookUpEditEditDetialSanfID_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit LUE = (LookUpEdit)sender;
            BillsDetialTbl.Rows[gridViewEditDetial.GetFocusedDataSourceRowIndex()]["UnitID"] = AsnafTbl.Rows[LUE.ItemIndex]["TagzeaUnit"].ToString();
            BillsDetialTbl.Rows[gridViewEditDetial.GetFocusedDataSourceRowIndex()]["UnitName"] = AsnafTbl.Rows[LUE.ItemIndex]["UnitName"].ToString();
            gridViewEditDetial.UpdateCurrentRow();
        }

        
    }
}