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

namespace E_Club_Store_Manager
{
    public partial class DataBillFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable ItemDetials = new DataTable("FalseX2010");
        DataTable AsnafTbl = new DataTable("Asnaf");
        DataTable BillPayTypeTbl = new DataTable("BillPayType");
        DataTable SuppliersTbl = new DataTable("Suppliers");
        DataTable EMPTbl = new DataTable("EMP");
        DataTable STORETbl = new DataTable("STORE");
        DataTable SalesUnitTbl = new DataTable("SalesUnitTable");
        DataTable WaredTbl = new DataTable("WaredTable");
        DataTable WaredDetialsTbl = new DataTable("WaredDetialsTable");
        public DataBillFrm()
        {
            InitializeComponent();
        }
        private void DataBillFrm_Load(object sender, EventArgs e)
        {
            ItemDetials.Columns.Add("WaredID");
            ItemDetials.Columns.Add("SanfID");
            ItemDetials.Columns.Add("UnitID");
            ItemDetials.Columns.Add("SalesUnitName");
            ItemDetials.Columns.Add("WaredQuantity",typeof (Single));
            ItemDetials.Columns.Add("WaredPrice", typeof(Single));
            ItemDetials.Columns.Add("DiscountPercent", typeof(Single));
            ItemDetials.Columns.Add("SortNo");
            ItemDetials.Columns.Add("Total", typeof(Single));
            GridControlAddDetials.DataSource = ItemDetials;
            LoadDefaultData();
            LoadEditorGridDataside();
            ClearForm();
            if (TxtBillID.Text.Trim().Length != 0)
                BtnSave.Enabled = true;
            else
                BtnSave.Enabled = false;
        }
        private void LoadDefaultData()
        {
            //Load Default for adding grid
            AsnafTbl = Program.MC.LoadDataTable("SELECT SanfID, SanfName, TagzeaUnit,(Select SalesUnitName From CDSalesUnit Where SalesUnitID = CDASNAF.TagzeaUnit) As SalesUnitName FROM CDASNAF");
            repositoryItemLookUpEditSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditSanfID.ValueMember = "SanfID";
            BillPayTypeTbl = Program.MC.LoadDataTable("SELECT BillPayTypeID, BillPayTypeName FROM BillPayType");
            LUEBillPayType.Properties.DataSource = BillPayTypeTbl;
            LUEBillPayType.Properties.DisplayMember = "BillPayTypeName";
            LUEBillPayType.Properties.ValueMember = "BillPayTypeID";
            SuppliersTbl = Program.MC.LoadDataTable("SELECT SupplierID, Supplier, SupplierOfficial, SupplierAddess, SupplierTel, SupplierMobil FROM CDSuppliers");
            LUESuppler.Properties.DataSource = SuppliersTbl;
            LUESuppler.Properties.DisplayMember = "Supplier";
            LUESuppler.Properties.ValueMember = "SupplierID";
            EMPTbl = Program.MC.LoadDataTable("SELECT EMPID, EMPNAME, EMPPHONE, EMPMOBIL FROM TBLEMP");
            LUEEmp.Properties.DataSource = EMPTbl;
            LUEEmp.Properties.DisplayMember = "EMPNAME";
            LUEEmp.Properties.ValueMember = "EMPID";
            STORETbl = Program.MC.LoadDataTable("SELECT StoreID, StoreName, StorePlace, StoreTel, StoreMobil FROM CDSTORE");
            LUEStorage.Properties.DataSource = STORETbl;
            LUEStorage.Properties.DisplayMember = "StoreName";
            LUEStorage.Properties.ValueMember = "StoreID";
            //Load Default for Editting grid
            repositoryItemLookUpEditEditSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditEditSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditEditSanfID.ValueMember = "SanfID";
            repositoryItemLookUpEditEditSupplier.DataSource = SuppliersTbl;
            repositoryItemLookUpEditEditSupplier.DisplayMember = "Supplier";
            repositoryItemLookUpEditEditSupplier.ValueMember = "SupplierID";
            repositoryItemLookUpEditEditMostlemID.DataSource = EMPTbl;
            repositoryItemLookUpEditEditMostlemID.DisplayMember = "EMPNAME";
            repositoryItemLookUpEditEditMostlemID.ValueMember = "EMPID";
            repositoryItemLookUpEditEditStoreID.DataSource = STORETbl;
            repositoryItemLookUpEditEditStoreID.DisplayMember = "StoreName";
            repositoryItemLookUpEditEditStoreID.ValueMember = "StoreID";
            repositoryItemLookUpEditEditBillPayTypeID.DataSource = BillPayTypeTbl;
            repositoryItemLookUpEditEditBillPayTypeID.DisplayMember = "BillPayTypeName";
            repositoryItemLookUpEditEditBillPayTypeID.ValueMember = "BillPayTypeID";
            SalesUnitTbl = Program.MC.LoadDataTable("SELECT SalesUnitID, SalesUnitName FROM CDSalesUnit");
            repositoryItemLookUpEditEditSalesUnitID.DataSource = SalesUnitTbl;
            repositoryItemLookUpEditEditSalesUnitID.DisplayMember = "SalesUnitName";
            repositoryItemLookUpEditEditSalesUnitID.ValueMember = "SalesUnitID";
            repositoryItemLookUpEditDetialSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditDetialSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditDetialSanfID.ValueMember = "SanfID";
        }
        private void LoadEditorGridDataside()
        {
            WaredTbl = new DataTable("WaredTable");
            SqlDataAdapter da = new SqlDataAdapter("", Program.MC.SQLConStrG_Accounts);
            da.SelectCommand.CommandText = "SELECT WaredID, WaredDate, SupplierID, (Select Supplier From CDSuppliers Where SupplierID = TBLWARED.SupplierID) As Supplier, MostlemID, (Select EMPNAME From TBLEMP Where EMPID = TBLWARED.MostlemID) As EMPNAME , TotalkasmPercent, ExtraFees, REM, StoreID, (Select StoreName From CDSTORE Where StoreID = TBLWARED.StoreID) As StoreName, BillPayTypeID, (Select BillPayTypeName From BillPayType Where BillPayTypeID = TBLWARED.BillPayTypeID) As BillPayTypeName FROM TBLWARED"; da.Fill(WaredTbl);
            gridControlEditor.DataSource = WaredTbl;
        }
        private void ClacTotal()
        {
            Single price, count, dis;
            if (ItemDetials.Rows.Count > 0)
            {
                count = MCls.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["WaredQuantity"].ToString());
                price = MCls.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["WaredPrice"].ToString());
                dis = MCls.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["DiscountPercent"].ToString());
                ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Total"] = ((count * price) - dis).ToString();
                Single totaldis, extra;
                extra = MCls.ConvertStringToInt(TxtExtraPayValue.Text);
                totaldis = MCls.ConvertStringToInt(TxtDiscount.Text);
                LblTotal.Text = ((Convert.ToInt16(ItemDetials.Compute("Sum(Total)", "")) + extra) - totaldis).ToString();
            }
            if (Convert.ToInt16(LblTotal.Text) < 0)
            {
                MessageBox.Show("اجمالي الفاتوره ليس صحيح","بيانات غير صحيحيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BtnSave.Enabled = false;
            }
            else
                BtnSave.Enabled = true;
        }
        private void ClearForm()
        {
            TxtBillID.Text = string.Empty;
            DEBillDate.EditValue = null;
            LUESuppler.EditValue = null;
            LUEEmp.EditValue = null;
            LUEStorage.EditValue = null;
            LUEBillPayType.EditValue = null;
            TxtDiscount.Text = string.Empty;
            TxtExtraPayValue.Text = string.Empty;
            MemInfo.Text = string.Empty;
            LblTotal.Text = "0";
            TxtBillID.Text = MCls.GetNewID("TBLWARED", "WaredID");
            ItemDetials.Rows.Clear();
        }
        private void GetBillDetial()
        {
            
            if (mastergridView.FocusedRowHandle >= 0 && mastergridView.SelectedRowsCount > 0)
            {
                gridControlEditorDetial.DataSource = null;
                WaredDetialsTbl = new DataTable("WaredDetialsTable");
                DataRow row = mastergridView.GetFocusedDataRow();
                if (row == null)
                    return;
                SqlDataAdapter da = new SqlDataAdapter("", Program.MC.SQLConStrG_Accounts);
                da.SelectCommand.CommandText = "SELECT WaredID, SanfID, UnitID As SalesUnitID,(Select SalesUnitName From CDSalesUnit Where SalesUnitID = TBLWaredDetailes.UnitID) AS SalesUnitName, WaredQuantity, WaredPrice, DiscountPercent, orderin, (WaredQuantity * WaredPrice) - DiscountPercent AS Total FROM TBLWaredDetailes Where WaredID = " + row["WaredID"].ToString();
                da.Fill(WaredDetialsTbl);
                gridControlEditorDetial.DataSource = WaredDetialsTbl;
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //check for  - data
            if (TxtBillID.Text.Trim().Length == 0 || DEBillDate.EditValue == null || LUESuppler.EditValue == null || LUEEmp.EditValue == null || LUEStorage.EditValue == null || LUEBillPayType.EditValue == null)
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
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand("", Con);
            SqlTransaction Trn = null;
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                string TotalkasmPercent = "0", ExtraFees = "0", REM = "NULL", WaredID = "NULL";
                string TheTime = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                if (TxtDiscount.Text.Trim().Length != 0)
                    TotalkasmPercent = TxtDiscount.Text.Trim();
                if (TxtExtraPayValue.Text.Trim().Length != 0)
                    ExtraFees = TxtExtraPayValue.Text.Trim();
                if (MemInfo.Text.Trim().Length != 0)
                    REM = "N'" + MemInfo.Text.Trim() + "'";
                WaredID = MCls.GetNewID("TBLWARED", "WaredID");
                Cmd.CommandText = String.Format("INSERT INTO TBLWARED (WaredID, WaredDate, SupplierID, MostlemID, TotalkasmPercent, ExtraFees, REM, UserIN, TimeIN, StoreID, BillPayTypeID) VALUES ({0}, Convert(Datetime, '{1}', 103), {2}, {3}, {4}, {5}, {6}, {7}, CONVERT(DATETIME, '{8}', 102), {9}, {10})", WaredID, DEBillDate.EditValue, LUESuppler.EditValue, LUEEmp.EditValue, TotalkasmPercent, ExtraFees, REM, Program.MC.UserInfo.UserID, TheTime, LUEStorage.EditValue, LUEBillPayType.EditValue);
                Cmd.ExecuteNonQuery();
                int orderin = 0;
                foreach (DataRow row in ItemDetials.Rows)
                {
                    string SanfID = "NULL", UnitID = "NULL", WaredQuantity = "0", WaredPrice = "0", DiscountPercent = "0";
                    SanfID = row["SanfID"].ToString();
                    UnitID = row["UnitID"].ToString();
                    if (row["WaredQuantity"].ToString() != string.Empty)
                        WaredQuantity = row["WaredQuantity"].ToString();
                    if (row["WaredPrice"].ToString() != string.Empty)
                        WaredPrice = row["WaredPrice"].ToString();
                    if (row["DiscountPercent"].ToString() != string.Empty)
                        DiscountPercent = row["DiscountPercent"].ToString();
                    orderin++;
                    Cmd.CommandText = string.Format("INSERT INTO TBLWaredDetailes (WaredID, SanfID, UnitID, WaredQuantity, WaredPrice, DiscountPercent, orderin) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})", WaredID, SanfID, UnitID, WaredQuantity, WaredPrice, DiscountPercent, orderin);
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
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void repositoryItemLookUpEditSanfID_EditValueChanged(object sender, EventArgs e)
        {
            BtnSave.Focus();
            gridViewAdd.Focus();
            LookUpEdit LUE = (LookUpEdit)sender;
            ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["UnitID"] = AsnafTbl.Rows[LUE.ItemIndex]["TagzeaUnit"].ToString();
            ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["SalesUnitName"] = AsnafTbl.Rows[LUE.ItemIndex]["SalesUnitName"].ToString();
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
            string WaredID1, SanfID1, UnitID1, SalesUnitName1, WaredQuantity1, WaredPrice1, DiscountPercent1;
            string WaredID2, SanfID2, UnitID2, SalesUnitName2, WaredQuantity2, WaredPrice2, DiscountPercent2;
            //save data in row 1
            WaredID1 = row1["WaredID"].ToString();
            SanfID1 = row1["SanfID"].ToString();
            UnitID1 = row1["UnitID"].ToString();
            SalesUnitName1 = row1["SalesUnitName"].ToString();
            WaredQuantity1 = row1["WaredQuantity"].ToString();
            WaredPrice1 = row1["WaredPrice"].ToString();
            DiscountPercent1 = row1["DiscountPercent"].ToString();
            //save data in row 2
            WaredID2 = row2["WaredID"].ToString();
            SanfID2 = row2["SanfID"].ToString();
            UnitID2 = row2["UnitID"].ToString();
            SalesUnitName2 = row2["SalesUnitName"].ToString();
            WaredQuantity2 = row2["WaredQuantity"].ToString();
            WaredPrice2 = row2["WaredPrice"].ToString();
            DiscountPercent2 = row2["DiscountPercent"].ToString();
            //save data to row1
            row1["WaredID"] = WaredID2;
            row1["SanfID"] = SanfID2;
            row1["UnitID"] = UnitID2;
            row1["SalesUnitName"] = SalesUnitName2;
            row1["WaredQuantity"] = WaredQuantity2;
            row1["WaredPrice"] = WaredPrice2;
            row1["DiscountPercent"] = MCls.ConvertStringToInt(DiscountPercent2);
            //save data to row2
            row2["WaredID"] = WaredID1;
            row2["SanfID"] = SanfID1;
            row2["UnitID"] = UnitID1;
            row2["SalesUnitName"] = SalesUnitName1;
            row2["WaredQuantity"] = WaredQuantity1;
            row2["WaredPrice"] = WaredPrice1;
            row2["DiscountPercent"] = MCls.ConvertStringToInt(DiscountPercent1);
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridViewAdd.UpdateCurrentRow();
            if (e.Column.Name == "gridColumnWaredQuantity" || e.Column.Name == "gridColumnWaredPrice" || e.Column.Name == "gridColumnDiscountPercent")
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
        private void repositoryItemButtonEditBillEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Update Bill
            if (MessageBox.Show("هل ترغب في التعديل؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            DataRow row = mastergridView.GetFocusedDataRow();
            string WaredDate = "NULL", SupplierID = "NULL", MostlemID = "NULL", TotalkasmPercent = "0", ExtraFees = "0", REM = "NULL", UserIN = Program.MC.UserInfo.UserID, TimeIN = "NULL", StoreID = "NULL", BillPayTypeID = "NULL";
            TimeIN = "'" + DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "'";
            if (row["WaredDate"].ToString() != string.Empty)
                WaredDate = string.Format("Convert(Datetime, '{0}', 103)", row["WaredDate"].ToString());
            if (row["SupplierID"].ToString() != string.Empty)
                SupplierID = row["SupplierID"].ToString();
            if (row["MostlemID"].ToString() != string.Empty)
                MostlemID = row["MostlemID"].ToString();
            if (row["TotalkasmPercent"].ToString() != string.Empty)
                TotalkasmPercent = row["TotalkasmPercent"].ToString();
            if (row["ExtraFees"].ToString() != string.Empty)
                ExtraFees = row["ExtraFees"].ToString();
            if (row["REM"].ToString() != string.Empty)
                REM = "N'" + row["REM"].ToString() + "'";
            if (row["StoreID"].ToString() != string.Empty)
                StoreID = row["StoreID"].ToString();
            if (row["BillPayTypeID"].ToString() != string.Empty)
                BillPayTypeID = row["BillPayTypeID"].ToString();

            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = string.Format("Set Dateformat dmy UPDATE TBLWARED SET WaredDate = {0}, SupplierID = {1}, MostlemID = {2}, TotalkasmPercent = {3}, ExtraFees = {4}, REM = {5}, UserIN = {6}, TimeIN = {7}, StoreID = {8},  BillPayTypeID = {9} WHERE (WaredID = {10})", WaredDate, SupplierID, MostlemID, TotalkasmPercent, ExtraFees, REM, UserIN, TimeIN, StoreID, BillPayTypeID, row["WaredID"].ToString());
                Cmd.ExecuteNonQuery();
                MessageBox.Show("تم تعديل الفاتوره", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void repositoryItemButtonEditEditBillDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete Bill
            if (MessageBox.Show("هل ترغب في الحذف؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            DataRow row = mastergridView.GetFocusedDataRow();
            SqlCommand Cmd = new SqlCommand("", Con);
            SqlTransaction Trn = null;
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                Cmd.CommandText = "DELETE FROM TBLWaredDetailes WHERE (WaredID = " + row["WaredID"].ToString() + ")";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "DELETE FROM TBLWARED WHERE (WaredID = " + row["WaredID"].ToString() + ")";
                Cmd.ExecuteNonQuery();
                Trn.Commit();
                LoadEditorGridDataside();
                MessageBox.Show("تم حذف الفاتوره", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void mastergridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            GetBillDetial();
        }
        private void repositoryItemLookUpEditDetialSanfID_EditValueChanged(object sender, EventArgs e)
        {
            BtnSave.Focus();
            gridViewAdd.Focus();
            LookUpEdit LUE = (LookUpEdit)sender;
            WaredDetialsTbl.Rows[gridViewEditDetial.GetFocusedDataSourceRowIndex()]["SalesUnitID"] = AsnafTbl.Rows[LUE.ItemIndex]["TagzeaUnit"].ToString();
            WaredDetialsTbl.Rows[gridViewEditDetial.GetFocusedDataSourceRowIndex()]["SalesUnitName"] = AsnafTbl.Rows[LUE.ItemIndex]["SalesUnitName"].ToString();
        }
        private void repositoryItemButtonEditEditDetialDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete Detial
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int index = gridViewEditDetial.GetDataSourceRowIndex(gridViewEditDetial.FocusedRowHandle);
            DataRow row = WaredDetialsTbl.Rows[index];
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand("DELETE FROM TBLWaredDetailes WHERE (WaredID = " + row["WaredID"].ToString() + ") AND (SanfID = " + row["SanfID"].ToString() + ")", Con);
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
        private void repositoryItemButtonEditDetialUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Update Detial
            gridViewEditDetial.UpdateCurrentRow();
            if (MessageBox.Show("هل ترغب في التعديل؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int index = gridViewEditDetial.GetDataSourceRowIndex(gridViewEditDetial.FocusedRowHandle);

            DataRow row = WaredDetialsTbl.Rows[index];
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand(string.Format("UPDATE TBLWaredDetailes SET SanfID = {0}, UnitID = {1}, WaredQuantity = {2}, WaredPrice = {3}, DiscountPercent = {4} WHERE (WaredID = {5}) AND (SanfID = {6})", row["SanfID"].ToString(), row["SalesUnitID"].ToString(), row["WaredQuantity"].ToString(), row["WaredPrice"].ToString(), row["DiscountPercent"].ToString(), mastergridView.GetFocusedDataRow()["WaredID"].ToString(), row["SanfID"].ToString()), Con);
            try
            {
                Con.Open();
                if (Cmd.ExecuteNonQuery() == 0)
                {
                    int orderin;
                    string SanfID = "NULL", UnitID = "NULL", WaredQuantity = "0", WaredPrice = "0", DiscountPercent = "0", WaredID = mastergridView.GetFocusedDataRow()["WaredID"].ToString();
                    SanfID = row["SanfID"].ToString();
                    UnitID = row["UnitID"].ToString();
                    if (row["WaredQuantity"].ToString() != string.Empty)
                        WaredQuantity = row["WaredQuantity"].ToString();
                    if (row["WaredPrice"].ToString() != string.Empty)
                        WaredPrice = row["WaredPrice"].ToString();
                    if (row["DiscountPercent"].ToString() != string.Empty)
                        DiscountPercent = row["DiscountPercent"].ToString();
                    orderin = (int)MCls.ConvertStringToInt(MCls.GetNewID("TBLWaredDetailes", "orderin")) + 1;
                    Cmd.CommandText = string.Format("INSERT INTO TBLWaredDetailes (WaredID, SanfID, UnitID, WaredQuantity, WaredPrice, DiscountPercent, orderin) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})", WaredID, SanfID, UnitID, WaredQuantity, WaredPrice, DiscountPercent, orderin);
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
        private void gridViewEditDetial_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column != gridColumnEditDetialSanfID)
            {
                return;
            }
            if (MessageBox.Show("هل ترغب في التعديل؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int index = gridViewEditDetial.GetDataSourceRowIndex(gridViewEditDetial.FocusedRowHandle);
            DataRow row = WaredDetialsTbl.Rows[index];
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
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand("UPDATE TBLWaredDetailes SET SanfID = " + SanfID + ",UnitID = " + UnitID + " WHERE (WaredID = " + row["WaredID"].ToString() + ") AND (SanfID = " + row["SanfID"].ToString() + ")", Con);
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
        private void xtraTabControlEditor_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (e.Page == xtraTabPageEdit)
                LoadEditorGridDataside();
        }

    }
}