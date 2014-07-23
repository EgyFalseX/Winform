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
    public partial class DataBillFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable ItemDetials = new DataTable("FX2011-06");
        DataTable AsnafTbl = new DataTable("Asnaf");
        DataTable BillPayTypeTbl = new DataTable("BillPayType");
        DataTable CustomersSuppliersTbl = new DataTable("CustomersSuppliers");
        DataTable EMPTbl = new DataTable("EMP");
        DataTable STORETbl = new DataTable("STORE");
        DataTable SalesUnitTbl = new DataTable("SalesUnitTable");
        DataTable TBLStoreTransactionTbl = new DataTable("TBLStoreTransaction");
        DataTable StoreTransactionDetailesTbl = new DataTable("StoreTransactionDetailes");
        
        public DataBillFrm()
        {
            InitializeComponent();
        }
        private void DataBillFrm_Load(object sender, EventArgs e)
        {
            ItemDetials.Columns.Add("StoreTrID");
            ItemDetials.Columns.Add("SanfID");
            ItemDetials.Columns.Add("Quantity", typeof(Single));
            ItemDetials.Columns.Add("Price", typeof(Single));
            ItemDetials.Columns.Add("Discount", typeof(Single));
            ItemDetials.Columns.Add("SortNo");
            ItemDetials.Columns.Add("Total", typeof(Single));
            GridControlAddDetials.DataSource = ItemDetials;
            LoadDefaultData();
            LoadEditorGridDataside();
            ClearForm();
            if (TxtStoreTrIDTYPE.Text.Trim().Length != 0)
                BtnSave.Enabled = true;
            else
                BtnSave.Enabled = false;
        }
        private void LoadDefaultData()
        {
            //Load Default for adding grid
            AsnafTbl = FXFW.SqlDB.LoadDataTable("SELECT SanfID, SanfName, TagzeaUnit,(Select SalesUnitName From CDSalesUnit Where SalesUnitID = CDASNAF.TagzeaUnit) As SalesUnitName FROM CDASNAF");
            repositoryItemLookUpEditSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditSanfID.ValueMember = "SanfID";
            BillPayTypeTbl = FXFW.SqlDB.LoadDataTable("SELECT BillPayTypeID, BillPayTypeName FROM BillPayType");
            LUEBillPayType.Properties.DataSource = BillPayTypeTbl;
            LUEBillPayType.Properties.DisplayMember = "BillPayTypeName";
            LUEBillPayType.Properties.ValueMember = "BillPayTypeID";
            CustomersSuppliersTbl = FXFW.SqlDB.LoadDataTable("SELECT PERSONID, PERSON, Addess, Tel, Mobil, AccountId FROM CustomersSuppliers Where PERSONTYPE = 2");
            LUEPERSONID.Properties.DataSource = CustomersSuppliersTbl;
            LUEPERSONID.Properties.DisplayMember = "PERSON";
            LUEPERSONID.Properties.ValueMember = "PERSONID";
            EMPTbl = FXFW.SqlDB.LoadDataTable("SELECT EMPID, EMPNAME, EMPPHONE, EMPMOBIL FROM TBLEMP");
            LUEEMPID.Properties.DataSource = EMPTbl;
            LUEEMPID.Properties.DisplayMember = "EMPNAME";
            LUEEMPID.Properties.ValueMember = "EMPID";
            STORETbl = FXFW.SqlDB.LoadDataTable("SELECT StoreID, StoreName, StorePlace, StoreTel, StoreMobil FROM CDSTORE");
            LUEStoreID.Properties.DataSource = STORETbl;
            LUEStoreID.Properties.DisplayMember = "StoreName";
            LUEStoreID.Properties.ValueMember = "StoreID";
            //Load Default for Editting grid
            repositoryItemLookUpEditEditSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditEditSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditEditSanfID.ValueMember = "SanfID";
            repositoryItemLookUpEditEditPERSONID.DataSource = CustomersSuppliersTbl;
            repositoryItemLookUpEditEditPERSONID.DisplayMember = "PERSON";
            repositoryItemLookUpEditEditPERSONID.ValueMember = "PERSONID";
            repositoryItemLookUpEditEditEMPID.DataSource = EMPTbl;
            repositoryItemLookUpEditEditEMPID.DisplayMember = "EMPNAME";
            repositoryItemLookUpEditEditEMPID.ValueMember = "EMPID";
            repositoryItemLookUpEditEditStoreID.DataSource = STORETbl;
            repositoryItemLookUpEditEditStoreID.DisplayMember = "StoreName";
            repositoryItemLookUpEditEditStoreID.ValueMember = "StoreID";
            repositoryItemLookUpEditEditBillPayTypeID.DataSource = BillPayTypeTbl;
            repositoryItemLookUpEditEditBillPayTypeID.DisplayMember = "BillPayTypeName";
            repositoryItemLookUpEditEditBillPayTypeID.ValueMember = "BillPayTypeID";
            SalesUnitTbl = FXFW.SqlDB.LoadDataTable("SELECT SalesUnitID, SalesUnitName FROM CDSalesUnit");
            repositoryItemLookUpEditEditSalesUnitID.DataSource = SalesUnitTbl;
            repositoryItemLookUpEditEditSalesUnitID.DisplayMember = "SalesUnitName";
            repositoryItemLookUpEditEditSalesUnitID.ValueMember = "SalesUnitID";
            repositoryItemLookUpEditDetialSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditDetialSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditDetialSanfID.ValueMember = "SanfID";
        }
        private void LoadEditorGridDataside()
        {
            TBLStoreTransactionTbl = new DataTable("TBLStoreTransaction");
            SqlDataAdapter da = new SqlDataAdapter("", FXFW.SqlDB.SqlConStr);
            da.SelectCommand.CommandText = @"SELECT StoreTrID, StoreTrIDDAY, StoreTrDate, StoreTrIDTYPE, PERSONID, (Select PERSON From CustomersSuppliers Where PERSONID = TBLStoreTransaction.PERSONID) As PERSON, 
            EMPID, (Select EMPNAME From TBLEMP Where EMPID = TBLStoreTransaction.EMPID) As EMPNAME , Totalkasm, ExtraFees, REM, StoreID, (Select StoreName From CDSTORE Where StoreID = TBLStoreTransaction.StoreID) As StoreName, 
            BillPayTypeID, (Select BillPayTypeName From BillPayType Where BillPayTypeID = TBLStoreTransaction.BillPayTypeID) As BillPayTypeName FROM TBLStoreTransaction Where STTRANSTYPEID = 4"; da.Fill(TBLStoreTransactionTbl);
            gridControlEditor.DataSource = TBLStoreTransactionTbl;
        }
        private void ClacTotal()
        {
            Single price, count, dis;
            if (ItemDetials.Rows.Count > 0)
            {
                count = FXFW.SqlDB.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Quantity"].ToString());
                price = FXFW.SqlDB.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Price"].ToString());
                dis = FXFW.SqlDB.ConvertStringToInt(ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Discount"].ToString());
                ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Total"] = ((count * price) - dis).ToString();
                Single totaldis, extra;
                extra = FXFW.SqlDB.ConvertStringToInt(TxtExtraFees.Text);
                totaldis = FXFW.SqlDB.ConvertStringToInt(TxtTotalkasm.Text);
                LblTotal.Text = ((Convert.ToDouble(ItemDetials.Compute("Sum(Total)", "")) + extra) - totaldis).ToString();
            }
            if (Convert.ToDouble(LblTotal.Text) < 0)
            {
                MessageBox.Show("اجمالي الفاتوره ليس صحيح","بيانات غير صحيحيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BtnSave.Enabled = false;
            }
            else
                BtnSave.Enabled = true;
        }
        private void ClearForm()
        {
            TxtStoreTrIDTYPE.Text = string.Empty;
            DEStoreTrDate.EditValue = null;
            LUEPERSONID.EditValue = null;
            LUEEMPID.EditValue = null;
            LUEStoreID.EditValue = null;
            LUEBillPayType.EditValue = null;
            TxtTotalkasm.Text = string.Empty;
            TxtExtraFees.Text = string.Empty;
            TxtREM.Text = string.Empty;
            LblTotal.Text = "0";
            TxtStoreTrIDTYPE.Text = Program.GetNewID("TBLStoreTransaction", "StoreTrIDTYPE", "STTRANSTYPEID = 4");
            ItemDetials.Rows.Clear();
        }
        private void GetBillDetial()
        {
            
            if (mastergridView.FocusedRowHandle >= 0 && mastergridView.SelectedRowsCount > 0)
            {
                gridControlEditorDetial.DataSource = null;
                StoreTransactionDetailesTbl = new DataTable("StoreTransactionDetailes");
                DataRow row = mastergridView.GetFocusedDataRow();
                if (row == null)
                    return;
                SqlDataAdapter da = new SqlDataAdapter("", FXFW.SqlDB.SqlConStr);
                da.SelectCommand.CommandText = "SELECT StoreTrID, SanfID, Quantity, Price, Discount, (Quantity * Price) - Discount AS Total FROM StoreTransactionDetailes Where StoreTrID = " + row["StoreTrID"].ToString();
                da.Fill(StoreTransactionDetailesTbl);
                gridControlEditorDetial.DataSource = StoreTransactionDetailesTbl;
            }
        }
        private void TarhelCommand(string KIEDNO, string KIEDDATE, string StoreTrIDTYPE)
        {
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlTransaction Trn = null;
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                string TRANSID = Program.GetNewID("TBLTRANSACTION", "TRANSID");

                Cmd.CommandText = String.Format(@"INSERT INTO TBLTRANSACTION  (TRANSID, YearID, KIEDNO, KIEDDAFTRYNO, KIEDDATE, KIEDDESC, trhel) VALUES 
                ({0}, (Select Isnull(Max(YearID), NULL) From CDYeras), {1}, NULL, {2}, N'قيد مشتريات', 'False')", TRANSID, KIEDNO, KIEDDATE);
                Cmd.ExecuteNonQuery();

                string AccountId = CustomersSuppliersTbl.Rows[LUEPERSONID.ItemIndex]["AccountId"].ToString();
                string Madeen = "0", Daien = LblTotal.Text, MostandNo = KIEDNO;
                string kieddes = "فاتورة وارد رقم " + StoreTrIDTYPE + " بتاريخ " + DEStoreTrDate.Text;
                Cmd.CommandText = String.Format(@"INSERT INTO TBLTRAANSDETAILS (TRANSID, TNO, AccountId, Madeen, Daien, MostandNo, kieddes) VALUES 
                ({0}, 1, {1}, {2}, {3}, {4}, N'{5}')", TRANSID, AccountId, Madeen, Daien, MostandNo, kieddes);
                Cmd.ExecuteNonQuery();
                AccountId = Program.GetOptionValue(Program.AppOptions.purchasing);
                Madeen = LblTotal.Text;
                Daien = "0";
                Cmd.CommandText = String.Format(@"INSERT INTO TBLTRAANSDETAILS (TRANSID, TNO, AccountId, Madeen, Daien, MostandNo, kieddes) VALUES 
                ({0}, 2, {1}, {2}, {3}, {4}, N'{5}')", TRANSID, AccountId, Madeen, Daien, MostandNo, kieddes);
                Cmd.ExecuteNonQuery();
                Trn.Commit();
                //MessageBox.Show("تم حفـــظ القيــد", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                Program.msg(ex.Message, true, ex.Number.ToString(), this);
            }
            Con.Close();
        }
        private void DEStoreTrDate_EditValueChanged(object sender, EventArgs e)
        {
            if (DEStoreTrDate.EditValue == null)
                TxtStoreTrIDDAY.Text = string.Empty;
            else
                TxtStoreTrIDDAY.Text = Program.GetNewID("TBLStoreTransaction", "StoreTrIDDAY", "StoreTrDate = " + string.Format("Convert(Datetime, '{0}/{1}/{2}', 103)", DEStoreTrDate.DateTime.Day, DEStoreTrDate.DateTime.Month, DEStoreTrDate.DateTime.Year));

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //check for  - data
            if (TxtStoreTrIDTYPE.Text.Trim().Length == 0 || DEStoreTrDate.EditValue == null || LUEPERSONID.EditValue == null || LUEEMPID.EditValue == null || LUEStoreID.EditValue == null || LUEBillPayType.EditValue == null)
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
                string Totalkasm = "0", ExtraFees = "0", REM = "NULL", StoreTrID = "NULL";
                string StoreTrDate = string.Format("Convert(Datetime, '{0}', 103)", DEStoreTrDate.Text);
                string Today = string.Format("Convert(Datetime, '{0}/{1}/{2}', 103)", DEStoreTrDate.DateTime.Day, DEStoreTrDate.DateTime.Month, DEStoreTrDate.DateTime.Year);
                if (TxtTotalkasm.Text.Trim().Length != 0)
                    Totalkasm = TxtTotalkasm.Text.Trim();
                if (TxtExtraFees.Text.Trim().Length != 0)
                    ExtraFees = TxtExtraFees.Text.Trim();
                if (TxtREM.Text.Trim().Length != 0)
                    REM = String.Format("N'{0}'", TxtREM.Text.Trim());
                StoreTrID = Program.GetNewID("TBLStoreTransaction", "StoreTrID");
                string StoreTrIDDAY = Program.GetNewID("TBLStoreTransaction", "StoreTrIDDAY", "StoreTrDate = " + Today);
                string StoreTrIDTYPE = Program.GetNewID("TBLStoreTransaction", "StoreTrIDTYPE", "STTRANSTYPEID = 4");
                Cmd.CommandText = string.Format(@"INSERT INTO TBLStoreTransaction
                (StoreTrID, STTRANSTYPEID, StoreTrDate, StoreTrIDDAY, StoreTrIDTYPE, PERSONID, BillPayTypeID, Totalkasm, ExtraFees, REM, StoreID, EMPID, TRHEL, UserIN, TimeIN) VALUES
                ({0}, 4, {1}, {2}, 
                (Select Isnull(Max(StoreTrIDTYPE) + 1, 1) From TBLStoreTransaction Where STTRANSTYPEID = 4), {3}, {4}, {5}, {6}, {7}, {8}, {9}, 1, {10}, GETDATE())", StoreTrID, StoreTrDate, StoreTrIDDAY,
                LUEPERSONID.EditValue, LUEBillPayType.EditValue, Totalkasm, ExtraFees, REM, LUEStoreID.EditValue, LUEEMPID.EditValue, FXFW.SqlDB.UserInfo.UserID);
                Cmd.ExecuteNonQuery();
                int orderin = 0;
                foreach (DataRow row in ItemDetials.Rows)
                {
                    string SanfID = "NULL", Quantity = "0", Price = "0", Discount = "0";
                    SanfID = row["SanfID"].ToString();
                    if (row["Quantity"].ToString() != string.Empty)
                        Quantity = row["Quantity"].ToString();
                    if (row["Price"].ToString() != string.Empty)
                        Price = row["Price"].ToString();
                    if (row["Discount"].ToString() != string.Empty)
                        Discount = row["Discount"].ToString();
                    orderin++;
                    Cmd.CommandText = string.Format(@"INSERT INTO StoreTransactionDetailes (StoreTrID, SanfID, Quantity, Price, Discount, harakatype) VALUES 
                    ({0}, {1}, {2}, {3}, {4}, 4)", StoreTrID, SanfID, Quantity, Price, Discount);
                    Cmd.ExecuteNonQuery();
                }
                TarhelCommand(StoreTrID, StoreTrDate, StoreTrIDTYPE);
                Trn.Commit();
                MessageBox.Show("تم حفظ الفاتوره", "تمت الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                DEStoreTrDate.Focus();
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void repositoryItemButtonEditSort_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //int index = gridViewAdd.FocusedRowHandle;
            //DataRow row1 = null;
            //DataRow row2 = null;
            //if (e.Button.Index == 0)
            //{
            //    if (index <= 0) return;
            //    row1 = gridViewAdd.GetDataRow(index);
            //    row2 = gridViewAdd.GetDataRow(index - 1);
            //}
            //else
            //{
            //    if (gridViewAdd.IsLastRow) return;
            //    row1 = gridViewAdd.GetDataRow(index);
            //    row2 = gridViewAdd.GetDataRow(index + 1);
            //}
            //string WaredID1, SanfID1, UnitID1, SalesUnitName1, WaredQuantity1, WaredPrice1, DiscountPercent1;
            //string WaredID2, SanfID2, UnitID2, SalesUnitName2, WaredQuantity2, WaredPrice2, DiscountPercent2;
            ////save data in row 1
            //WaredID1 = row1["WaredID"].ToString();
            //SanfID1 = row1["SanfID"].ToString();
            //UnitID1 = row1["UnitID"].ToString();
            //SalesUnitName1 = row1["SalesUnitName"].ToString();
            //WaredQuantity1 = row1["WaredQuantity"].ToString();
            //WaredPrice1 = row1["WaredPrice"].ToString();
            //DiscountPercent1 = row1["DiscountPercent"].ToString();
            ////save data in row 2
            //WaredID2 = row2["WaredID"].ToString();
            //SanfID2 = row2["SanfID"].ToString();
            //UnitID2 = row2["UnitID"].ToString();
            //SalesUnitName2 = row2["SalesUnitName"].ToString();
            //WaredQuantity2 = row2["WaredQuantity"].ToString();
            //WaredPrice2 = row2["WaredPrice"].ToString();
            //DiscountPercent2 = row2["DiscountPercent"].ToString();
            ////save data to row1
            //row1["WaredID"] = WaredID2;
            //row1["SanfID"] = SanfID2;
            //row1["UnitID"] = UnitID2;
            //row1["SalesUnitName"] = SalesUnitName2;
            //row1["WaredQuantity"] = WaredQuantity2;
            //row1["WaredPrice"] = WaredPrice2;
            //row1["DiscountPercent"] = FXFW.SqlDB.ConvertStringToInt(DiscountPercent2);
            ////save data to row2
            //row2["WaredID"] = WaredID1;
            //row2["SanfID"] = SanfID1;
            //row2["UnitID"] = UnitID1;
            //row2["SalesUnitName"] = SalesUnitName1;
            //row2["WaredQuantity"] = WaredQuantity1;
            //row2["WaredPrice"] = WaredPrice1;
            //row2["DiscountPercent"] = FXFW.SqlDB.ConvertStringToInt(DiscountPercent1);
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridViewAdd.UpdateCurrentRow();
            if (e.Column.Name == "gridColumnQuantity" || e.Column.Name == "gridColumnPrice" || e.Column.Name == "gridColumnDiscount")
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
            DataRow row = mastergridView.GetFocusedDataRow();
            string StoreTrDate = "NULL", PERSONID = "NULL", EMPID = "NULL", Totalkasm = "0", ExtraFees = "0", REM = "NULL", UserIN = FXFW.SqlDB.UserInfo.UserID, StoreID = "NULL", BillPayTypeID = "NULL";
            if (row["StoreTrDate"].ToString() != string.Empty)
                StoreTrDate = string.Format("Convert(Datetime, '{0}', 103)", FXFW.SqlDB.ConvertToDateDMY(row["StoreTrDate"].ToString()));
            if (row["PERSONID"].ToString() != string.Empty)
                PERSONID = row["PERSONID"].ToString();
            if (row["EMPID"].ToString() != string.Empty)
                EMPID = row["EMPID"].ToString();
            if (row["Totalkasm"].ToString() != string.Empty)
                Totalkasm = row["Totalkasm"].ToString();
            if (row["ExtraFees"].ToString() != string.Empty)
                ExtraFees = row["ExtraFees"].ToString();
            if (row["REM"].ToString() != string.Empty)
                REM = String.Format("N'{0}'", row["REM"]);
            if (row["StoreID"].ToString() != string.Empty)
                StoreID = row["StoreID"].ToString();
            if (row["BillPayTypeID"].ToString() != string.Empty)
                BillPayTypeID = row["BillPayTypeID"].ToString();
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = string.Format(@"UPDATE TBLStoreTransaction SET StoreTrDate = {0}, PERSONID = {1}, EMPID = {2}, Totalkasm = {3}, ExtraFees = {4}, REM = {5}, UserIN = {6}, TimeIN = GETDATE(),
                StoreID = {7},  BillPayTypeID = {8} WHERE (StoreTrID = {9})", StoreTrDate, PERSONID, EMPID, Totalkasm, ExtraFees, REM, UserIN, StoreID, BillPayTypeID, row["StoreTrID"].ToString());
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
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            DataRow row = mastergridView.GetFocusedDataRow();
            SqlCommand Cmd = new SqlCommand("", Con);
            SqlTransaction Trn = null;
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                Cmd.CommandText = "DELETE FROM StoreTransactionDetailes WHERE StoreTrID = " + row["StoreTrID"];
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "DELETE FROM TBLStoreTransaction WHERE StoreTrID = " + row["StoreTrID"];
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
        private void repositoryItemButtonEditEditDetialDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete Detial
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int index = gridViewEditDetial.GetDataSourceRowIndex(gridViewEditDetial.FocusedRowHandle);
            DataRow row = StoreTransactionDetailesTbl.Rows[index];
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM StoreTransactionDetailes WHERE (StoreTrID = {0}) AND (SanfID = {1})", row["StoreTrID"], row["SanfID"]), Con);
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

            DataRow row = StoreTransactionDetailesTbl.Rows[index];
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand(string.Format(@"UPDATE StoreTransactionDetailes SET SanfID = {0}, Quantity = {1}, Price = {2}, Discount = {3} WHERE (StoreTrID = {4}) AND (SanfID = {5})",
            row["SanfID"].ToString(), row["Quantity"].ToString(), row["Price"].ToString(), row["Discount"].ToString(), mastergridView.GetFocusedDataRow()["StoreTrID"].ToString(), row["SanfID"].ToString()), Con);
            try
            {
                Con.Open();
                if (Cmd.ExecuteNonQuery() == 0)
                {
                    string SanfID = "NULL", Quantity = "0", Price = "0", Discount = "0", StoreTrID = mastergridView.GetFocusedDataRow()["StoreTrID"].ToString();
                    SanfID = row["SanfID"].ToString();
                    if (row["Quantity"].ToString() != string.Empty)
                        Quantity = row["Quantity"].ToString();
                    if (row["Price"].ToString() != string.Empty)
                        Price = row["Price"].ToString();
                    if (row["Discount"].ToString() != string.Empty)
                        Discount = row["Discount"].ToString();
                    Cmd.CommandText = string.Format("INSERT INTO StoreTransactionDetailes (StoreTrID, SanfID, Quantity, Price, Discount) VALUES ({0}, {1}, {2}, {3}, {4})", 
                    StoreTrID, SanfID, Quantity, Price, Discount);
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
            DataRow row = StoreTransactionDetailesTbl.Rows[index];
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
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand(String.Format("UPDATE StoreTransactionDetailes SET SanfID = {0} WHERE (StoreTrID = {1}) AND (SanfID = {2})", SanfID, row["StoreTrID"], row["SanfID"]), Con);
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