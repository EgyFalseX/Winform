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
    public partial class DataSellStuBillBarCodeFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable AsnafTbl = new DataTable();
        DataTable student = new DataTable();
        DataTable BillPayTypeTbl = new DataTable("BillPayType");
        DataTable EMPTbl = new DataTable("EMP");
        DataTable STORETbl = new DataTable("STORE");
        DataTable CdDiscountTypeTbl = new DataTable("STTRANSTYPEID");
        DataTable harakatypeTbl = new DataTable("harakatype");
        DataTable DiscountTypeIdTbl = new DataTable("DiscountTypeId");
        DataTable ItemDetials = new DataTable();
        DataTable BillsTbl = new DataTable();
        DataTable BillsDetialTbl = new DataTable();
        #endregion
        #region -   Functions   -
        public DataSellStuBillBarCodeFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            // Get All Asnaf Types
            AsnafTbl = new DataTable();
            AsnafTbl = FXFW.SqlDB.LoadDataTable("Select SanfID, SanfName, Sanfbarcode From CDASNAF");
            repositoryItemLookUpEditAddSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditAddSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditAddSanfID.ValueMember = "SanfID";

            repositoryItemLookUpEditEditSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditEditSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditEditSanfID.ValueMember = "SanfID";

            CBESanf.Properties.Items.Clear();
            foreach (DataRow row in AsnafTbl.Rows)
                CBESanf.Properties.Items.Add(row["SanfName"].ToString());
            
            // Get All student Name
            student = FXFW.SqlDB.LoadDataTable("SELECT stu_code, stu_name FROM student Where asase_code = (Select Max(asase_code) From student)");
            LUEPERSONID.Properties.DataSource = student;
            LUEPERSONID.Properties.DisplayMember = "stu_name";
            LUEPERSONID.Properties.ValueMember = "stu_code";
            // Get All Bill Pay Types
            BillPayTypeTbl = FXFW.SqlDB.LoadDataTable("SELECT BillPayTypeID, BillPayTypeName FROM BillPayType");
            LUEBillPayType.Properties.DataSource = BillPayTypeTbl;
            LUEBillPayType.Properties.DisplayMember = "BillPayTypeName";
            LUEBillPayType.Properties.ValueMember = "BillPayTypeID";
            // Get All Emp Names
            EMPTbl = FXFW.SqlDB.LoadDataTable("SELECT EMPID, EMPNAME, EMPPHONE, EMPMOBIL FROM TBLEMP");
            LUEEMPID.Properties.DataSource = EMPTbl;
            LUEEMPID.Properties.DisplayMember = "EMPNAME";
            LUEEMPID.Properties.ValueMember = "EMPID";
            // Get All Storages Name
            STORETbl = FXFW.SqlDB.LoadDataTable("SELECT StoreID, StoreName, StorePlace, StoreTel, StoreMobil FROM CDSTORE");
            LUEStoreID.Properties.DataSource = STORETbl;
            LUEStoreID.Properties.DisplayMember = "StoreName";
            LUEStoreID.Properties.ValueMember = "StoreID";
            //Get All Haraka Types
            harakatypeTbl = FXFW.SqlDB.LoadDataTable("SELECT harakatype, haraka FROM CdHaraka");
            repositoryItemLookUpEditharakatype.DataSource = harakatypeTbl;
            repositoryItemLookUpEditharakatype.DisplayMember = "haraka";
            repositoryItemLookUpEditharakatype.ValueMember = "harakatype";

            repositoryItemLookUpEditEditharakatype.DataSource = harakatypeTbl;
            repositoryItemLookUpEditEditharakatype.DisplayMember = "haraka";
            repositoryItemLookUpEditEditharakatype.ValueMember = "harakatype";
            //Get All Discount Types
            CdDiscountTypeTbl = FXFW.SqlDB.LoadDataTable("SELECT DiscountTypeId, DiscountType FROM CdDiscountType");
            LUEDiscountTypeId.Properties.DataSource = CdDiscountTypeTbl;
            LUEDiscountTypeId.Properties.DisplayMember = "DiscountType";
            LUEDiscountTypeId.Properties.ValueMember = "DiscountTypeId";
            repositoryItemLookUpEditDiscountTypeId.DataSource = CdDiscountTypeTbl;
            repositoryItemLookUpEditDiscountTypeId.DisplayMember = "DiscountType";
            repositoryItemLookUpEditDiscountTypeId.ValueMember = "DiscountTypeId";

            repositoryItemLookUpEditEditDiscountTypeId.DataSource = CdDiscountTypeTbl;
            repositoryItemLookUpEditEditDiscountTypeId.DisplayMember = "DiscountType";
            repositoryItemLookUpEditEditDiscountTypeId.ValueMember = "DiscountTypeId";

            repositoryItemLookUpEditEditDiscountTypeIdDetail.DataSource = CdDiscountTypeTbl;
            repositoryItemLookUpEditEditDiscountTypeIdDetail.DisplayMember = "DiscountType";
            repositoryItemLookUpEditEditDiscountTypeIdDetail.ValueMember = "DiscountTypeId";
            //Edit Grid
            // Bill Pay Types
            repositoryItemLookUpEditEditBillPayType.DataSource = BillPayTypeTbl;
            repositoryItemLookUpEditEditBillPayType.DisplayMember = "BillPayTypeName";
            repositoryItemLookUpEditEditBillPayType.ValueMember = "BillPayTypeID";
            // Get Customers Name
            repositoryItemLookUpEditEditPERSONID.DataSource = student;
            repositoryItemLookUpEditEditPERSONID.DisplayMember = "PERSON";
            repositoryItemLookUpEditEditPERSONID.ValueMember = "PERSONID";
            // Get Emps Name
            repositoryItemLookUpEditEditEMPID.DataSource = EMPTbl;
            repositoryItemLookUpEditEditEMPID.DisplayMember = "EMPNAME";
            repositoryItemLookUpEditEditEMPID.ValueMember = "EMPID";
            // Get Storages Name
            repositoryItemLookUpEditEditStoreID.DataSource = STORETbl;
            repositoryItemLookUpEditEditStoreID.DisplayMember = "StoreName";
            repositoryItemLookUpEditEditStoreID.ValueMember = "StoreID";
            // Get Asnafs Name
        }
        private void ShowTotal()
        {
            if (ItemDetials.Rows.Count == 0)
            {
                LblTotal.Text = "0";
                return;
            }
            foreach (DataRow row in ItemDetials.Rows)
            {
                if (row["Quantity"].ToString() == string.Empty || row["Price"].ToString() == string.Empty || row["Discount"].ToString() == string.Empty || row["harakatype"].ToString() == string.Empty || row["DiscountTypeId"].ToString() == string.Empty)
                    continue;
                double Price = Convert.ToDouble(row["Price"]), Quantity = Convert.ToDouble(row["Quantity"]), Discount = Convert.ToDouble(row["Discount"]), Total = 0;
                if (row["DiscountTypeId"].ToString() == ((int)Program.DiscountType.مبلغ).ToString())
                    Total = Price * Quantity - Discount;
                else if (row["DiscountTypeId"].ToString() == ((int)Program.DiscountType.نسبة).ToString())
                    Total = (Price * Quantity) - (Price * Quantity * Discount / 100);
                else if (row["DiscountTypeId"].ToString() == ((int)Program.DiscountType.بدون_خصم).ToString())
                    Total = Price * Quantity;
                if (row["harakatype"].ToString() == ((int)Program.HarakaType.مبيعات).ToString())
                    row["Total"] = Total;
                else if (row["harakatype"].ToString() == ((int)Program.HarakaType.مرتجع).ToString())
                    row["Total"] = Total * -1;
            }
            if (LUEDiscountTypeId.EditValue.ToString() == ((int)Program.DiscountType.مبلغ).ToString())
            {
                LblTotal.Text = (Convert.ToDouble(ItemDetials.Compute("Sum(Total)", "")) - FXFW.SqlDB.ConvertStringToInt(TxtTotalkasm.Text)).ToString();
                
            }
            else if (LUEDiscountTypeId.EditValue.ToString() == ((int)Program.DiscountType.نسبة).ToString())
            {
                double Dis = Convert.ToDouble(ItemDetials.Compute("Sum(Total)", "")) * FXFW.SqlDB.ConvertStringToInt(TxtTotalkasm.Text) / 100;
                LblTotal.Text = (Convert.ToDouble(ItemDetials.Compute("Sum(Total)", "")) - Dis).ToString();
            }
            else
                LblTotal.Text = Convert.ToDouble(ItemDetials.Compute("Sum(Total)", "")).ToString();
            LblTotal.Text = Math.Round(Convert.ToDouble(LblTotal.Text), 2).ToString();
            
        }
        private void LoadEditGrid()
        {
            //GridControlEdit
            BillsTbl = new DataTable();
            BillsTbl = FXFW.SqlDB.LoadDataTable("SELECT StoreTrID, STTRANSTYPEID, StoreTrDate, StoreTrIDDAY, StoreTrIDTYPE, PERSONID, BillPayTypeID, DiscountTypeId, Totalkasm, ExtraFees, REM, UserIN, TimeIN,  StoreID, EMPID, TRHEL FROM TBLStoreTransaction Where STTRANSTYPEID = 2");
            GridControlEdit.DataSource = BillsTbl;
        }
        private void GetBillDetial()
        {
            if (gridViewEdit.FocusedRowHandle >= 0 && gridViewEdit.SelectedRowsCount > 0)
            {
                gridControlEditDetails.DataSource = null;
                BillsDetialTbl = new DataTable();
                DataRow row = gridViewEdit.GetFocusedDataRow();
                if (row == null)
                    return;
                BillsDetialTbl = FXFW.SqlDB.LoadDataTable("SELECT StoreTrID, SanfID, harakatype, Quantity, Price, DiscountTypeId, Discount FROM StoreTransactionDetailes Where StoreTrID = " + row["StoreTrID"].ToString());
                gridControlEditDetails.DataSource = BillsDetialTbl;
            }
        }
        private bool ItemAvailability(string SanfID, string Count)
        {
            DataRow row = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT ISNULL(SQ, 0) - {0} AS SQ, ReOrder FROM V_sumINOUT WHERE SanfID = {1}", Count, SanfID)).Rows[0];
            if (Convert.ToInt64(row["SQ"]) >= 0)
            {
                if (Convert.ToInt64(row["ReOrder"]) < Convert.ToInt64(row["SQ"]))
                    return true;
                else
                {
                    return true;
                }
            }
            else
                return false;
        }
        private static string ItemCount(string SanfID)
        {
            DataTable Tbl = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT ISNULL(SQ, 0) AS SQ, ReOrder FROM V_sumINOUT WHERE SanfID = {0}", SanfID));
            if (Tbl.Rows.Count == 0)
                return "0";
            else
                return Tbl.Rows[0][0].ToString();
        }
        #endregion
        #region -   Event Handlers   -
        private void DataSellBillBarCodeFrm_Load(object sender, EventArgs e)
        {
            ItemDetials.Columns.Add("StoreTrID");
            ItemDetials.Columns.Add("harakatype");
            ItemDetials.Columns.Add("SanfID");
            ItemDetials.Columns.Add("Quantity", typeof(Single));
            ItemDetials.Columns.Add("Price", typeof(Single));
            ItemDetials.Columns.Add("DiscountTypeId");
            ItemDetials.Columns.Add("Discount", typeof(Single));
            ItemDetials.Columns.Add("Total", typeof(Single));
            GridControlAddDetials.DataSource = ItemDetials;
            LoadDefaultData();
            LoadEditGrid();
            BtnNew_Click(BtnNew, new EventArgs());
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            LUEDiscountTypeId.ItemIndex = 2;
            TxtTotalkasm.Text = "0";
            MemInfo.Text = string.Empty;
            TxtBillID.Text = Program.GetNewID("TBLStoreTransaction", "StoreTrIDTYPE", "STTRANSTYPEID = 2");
            DEStoreTrDate.DateTime = DateTime.Today;
            DEStoreTrDate_EditValueChanged(DEStoreTrDate, new EventArgs());
            LUEPERSONID.ItemIndex = 1;
            LUEEMPID.ItemIndex = 0;
            LUEStoreID.ItemIndex = 0;
            LUEBillPayType.ItemIndex = 0;
            TxtItemCount.Text = "1";
            TxtBarCode.Text = string.Empty;
            LblTotal.Text = "0";
            ItemDetials.Rows.Clear();
        }
        private void CBESanf_SelectedIndexChanged(object sender, EventArgs e)
        {
           LblItemCount.Text = ItemCount(AsnafTbl.Rows[CBESanf.SelectedIndex]["SanfID"].ToString());
        }
        private void LUEDiscountTypeId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEDiscountTypeId.EditValue.ToString() == ((int)Program.DiscountType.مبلغ).ToString()) // مبلغ
            {
                TxtTotalkasm.Enabled = true;
                //TxtDiscount.Properties.DisplayFormat.FormatString = "c2";
                //TxtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //TxtDiscount.Properties.EditFormat.FormatString = "c2";
                //TxtDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //TxtDiscount.Properties.Mask.EditMask = "c2";
                //TxtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            }else if (LUEDiscountTypeId.EditValue.ToString() == ((int)Program.DiscountType.نسبة).ToString())//نسبه
            {
                TxtTotalkasm.Enabled = true;
                //TxtDiscount.Properties.DisplayFormat.FormatString = "c2";
                //TxtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //TxtDiscount.Properties.EditFormat.FormatString = "c2";
                //TxtDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //TxtDiscount.Properties.Mask.EditMask = "c2";
                //TxtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            }
            else// بدون خصم
            {
                TxtTotalkasm.Enabled = false;
                TxtTotalkasm.Text = "0";
            }
        }
        private void DEStoreTrDate_EditValueChanged(object sender, EventArgs e)
        {
            if (DEStoreTrDate.EditValue == null)
                TxtStoreTrIDDAY.Text = string.Empty;
            else
            {
                string Today = string.Format("Convert(Datetime, '{0}/{1}/{2}', 103)", DEStoreTrDate.DateTime.Day, DEStoreTrDate.DateTime.Month, DEStoreTrDate.DateTime.Year);
                TxtStoreTrIDDAY.Text = Program.GetNewID("TBLStoreTransaction", "StoreTrIDDAY", "StoreTrDate = " + Today);
            }
        }
        private void TxtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtBarCode.Text == string.Empty)
                return;
            if (e.KeyChar != (char)Keys.Enter)
                return;
            try
            {
                if (AsnafTbl.Compute("Sum(SanfID)", "Sanfbarcode = " + TxtBarCode.Text).ToString() == string.Empty)
                {
                    TxtBarCode.Text = string.Empty;
                    Program.msg("لا يوجد صنف بهذا السريال", true, "", this);
                    return;
                }
                DataRow row = ItemDetials.NewRow();
                row["SanfID"] = AsnafTbl.Compute("Sum(SanfID)", "Sanfbarcode = " + TxtBarCode.Text).ToString();
                row["harakatype"] = ((int)Program.HarakaType.مبيعات).ToString(); //مبيعات
                row["Quantity"] = TxtItemCount.Text;
                row["Price"] = FXFW.SqlDB.LoadDataTable(@"Select Isnull(Max(priceout), 0) AS priceout From TblPricelistdetailes Where SanfID = " + row["SanfID"]).Rows[0][0].ToString();
                row["DiscountTypeId"] = ((int)Program.DiscountType.بدون_خصم).ToString();
                row["Discount"] = "0";
                if (row["harakatype"].ToString() == ((int)Program.HarakaType.مبيعات).ToString())
                {
                    if (ItemAvailability(row["SanfID"].ToString(), row["Quantity"].ToString()) == false)
                    {
                        Program.msg("لا يوجد كميه كافيه في المخزن", true, "", this);
                        return;
                    }
                }
                ItemDetials.Rows.Add(row);
                GridControlAddDetials.DataSource = ItemDetials;
                ShowTotal();
            }
            catch (Exception ex)
            {
                Program.msg(ex.Message, true, "", this);
            }
            TxtBarCode.Text = string.Empty;
        }
        private void BtnAddSanf_Click(object sender, EventArgs e)
        {
            if (CBESanf.SelectedIndex == -1)
                return;
            try
            {
                DataRow row = ItemDetials.NewRow();
                row["SanfID"] = AsnafTbl.Rows[CBESanf.SelectedIndex]["SanfID"].ToString();
                row["harakatype"] = ((int)Program.HarakaType.مبيعات).ToString(); //مبيعات
                row["Quantity"] = "1";
                row["Price"] = FXFW.SqlDB.LoadDataTable(@"Select Isnull(Max(priceout), 0) AS priceout From TblPricelistdetailes Where SanfID = " + row["SanfID"]).Rows[0][0].ToString();
                row["DiscountTypeId"] = ((int)Program.DiscountType.بدون_خصم).ToString();
                row["Discount"] = "0";
                if (row["harakatype"].ToString() == ((int)Program.HarakaType.مبيعات).ToString())
                {
                    if (ItemAvailability(row["SanfID"].ToString(), row["Quantity"].ToString()) == false)
                    {
                        Program.msg("لا يوجد كميه كافيه في المخزن", true, "", this);
                        return;
                    }
                }
                ItemDetials.Rows.Add(row);
                GridControlAddDetials.DataSource = ItemDetials;
                ShowTotal();
                //CBESanf.SelectedIndex = -1;
                //CBESanf.ResetText();
            }
            catch (Exception ex)
            {
                Program.msg(ex.Message, true, "", this);
            }

        }
        private void repositoryItemLookUpEditAddSanfID_EditValueChanged(object sender, EventArgs e)
        {
            BtnSave.Focus();
            gridViewAdd.Focus();
            LookUpEdit LUE = (LookUpEdit)sender;
            if (ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["harakatype"].ToString() == ((int)Program.HarakaType.مبيعات).ToString())
            {
                ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Price"] = FXFW.SqlDB.LoadDataTable(@"Select priceout From TblPricelistdetailes Where SanfID = " + LUE.EditValue).Rows[0][0].ToString();
            }
            else if (ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["harakatype"].ToString() == ((int)Program.HarakaType.مرتجع).ToString())
            {
                ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Price"] = FXFW.SqlDB.LoadDataTable(@"Select priceout From TblPricelistdetailes Where SanfID = " + LUE.EditValue).Rows[0][0].ToString();
                ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["DiscountTypeId"] = ((int)Program.DiscountType.بدون_خصم).ToString();// if its back discount should b none
                ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Discount"] = "0";
            }
        }
        private void repositoryItemLookUpEditDiscountTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BtnSave.Focus();
            gridViewAdd.Focus();
            LookUpEdit LUE = (LookUpEdit)sender;
            if (LUE.EditValue.ToString() != ((int)Program.DiscountType.بدون_خصم).ToString() && ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["harakatype"].ToString() == ((int)Program.HarakaType.مرتجع).ToString())
            {
                LUE.EditValue = ((int)Program.DiscountType.بدون_خصم).ToString();
                ItemDetials.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()]["Discount"] = "0";
            }
        }
        private void gridViewAdd_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridViewAdd.UpdateCurrentRow();
            ShowTotal();
        }
        private void TxtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            ShowTotal();
        }
        private void TxtExtraPayValue_EditValueChanged(object sender, EventArgs e)
        {
            ShowTotal();
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
            if (TxtBillID.Text.Trim().Length == 0 || DEStoreTrDate.EditValue == null || LUEPERSONID.EditValue == null || LUEEMPID.EditValue == null || LUEStoreID.EditValue == null || LUEBillPayType.EditValue == null)
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
            if (MessageBox.Show("سيتم الحفظ و الترحيل للخزنه" + Environment.NewLine + "هل انت متأكد؟","حفظ الفاتوره...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            //SqlTransaction Trn = null;
            try
            {
                foreach (DataRow row in ItemDetials.Rows)
                {
                    if (row["SanfID"].ToString() == string.Empty /*|| row["harakatype"].ToString() == string.Empty*/ || row["Quantity"].ToString() == string.Empty || row["Price"].ToString() == string.Empty || row["DiscountTypeId"].ToString() == string.Empty || row["Discount"].ToString() == string.Empty)
                    {
                        MessageBox.Show("بيانات صنف غير مكتمله", "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //if (row["DiscountTypeId"].ToString() != ((int)Program.DiscountType.بدون_خصم).ToString() /*&& row["harakatype"].ToString() == ((int)Program.HarakaType.مرتجع).ToString()*/)
                    //{
                    //    MessageBox.Show("لا يمكن اضافة خصم لمرتجع", "بيانات خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    /*if (row["harakatype"].ToString() == ((int)Program.HarakaType.مبيعات).ToString())
                    {*/
                        if (ItemAvailability(row["SanfID"].ToString(), row["Quantity"].ToString()) == false)
                        {
                            Program.msg("لا يوجد كميه كافيه في المخزن", true, "", this);
                            return;
                        }
                    /*}*/
                }
                con.Open();
                //Trn = con.BeginTransaction();
                //cmd.Transaction = Trn;
                string Totalkasm = "0", REM = "NULL", StoreTrID = "NULL", DiscountTypeId = "NULL", EMPID = "NULL";
                string StoreTrDate = string.Format("Convert(Datetime, '{0}', 103)", DEStoreTrDate.Text);
                string Today = string.Format("Convert(Datetime, '{0}/{1}/{2}', 103)", DEStoreTrDate.DateTime.Day, DEStoreTrDate.DateTime.Month, DEStoreTrDate.DateTime.Year);
                if (TxtTotalkasm.Text.Trim().Length != 0 && LUEDiscountTypeId.EditValue.ToString() != ((int)Program.DiscountType.بدون_خصم).ToString())
                    Totalkasm = TxtTotalkasm.Text.Trim();
                if (MemInfo.Text.Trim().Length != 0)
                    REM = String.Format("N'{0}'", MemInfo.Text.Trim());
                if (LUEDiscountTypeId.EditValue != null)
                    DiscountTypeId = LUEDiscountTypeId.EditValue.ToString();
                if (LUEEMPID.EditValue != null)
                    EMPID = LUEEMPID.EditValue.ToString();
                StoreTrID = Program.GetNewID("TBLStoreTransaction", "StoreTrID");
                string StoreTrIDDAY = Program.GetNewID("TBLStoreTransaction", "StoreTrIDDAY", "StoreTrDate = " + Today);
                string StoreTrIDTYPE = Program.GetNewID("TBLStoreTransaction", "StoreTrIDTYPE", "STTRANSTYPEID = 2");
                cmd.CommandText = string.Format(@"INSERT INTO TBLStoreTransaction (StoreTrID, STTRANSTYPEID, StoreTrDate, StoreTrIDDAY, StoreTrIDTYPE, PERSONID, BillPayTypeID, Totalkasm, REM, StoreID, EMPID, TRHEL, UserIN, TimeIN) VALUES
                ({0}, 2, {1}, {2}, (Select Isnull(Max(StoreTrIDTYPE) + 1, 1) From TBLStoreTransaction Where STTRANSTYPEID = 2), {3}, {4}, {5}, {6}, {7}, {8}, '{9}', {10}, GETDATE())",
                StoreTrID, StoreTrDate, StoreTrIDDAY, LUEPERSONID.EditValue, LUEBillPayType.EditValue, Totalkasm, REM, LUEStoreID.EditValue, EMPID, "True", FXFW.SqlDB.UserInfo.UserID);
                cmd.ExecuteNonQuery();
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
                    cmd.CommandText = string.Format(@"INSERT INTO StoreTransactionDetailes (StoreTrID, SanfID, Quantity, Price, Discount, harakatype, DiscountTypeId) VALUES 
                    ({0}, {1}, {2}, {3}, {4}, {5}, {6})", StoreTrID, row["SanfID"], row["Quantity"], row["Price"], row["Discount"], 2 /*row["harakatype"]*/, row["DiscountTypeId"]);
                    cmd.ExecuteNonQuery();
                }
                string ActionId = "2";
                if (Convert.ToDouble(LblTotal.Text) <= 0)
                {
                    ActionId = "1";
                    LblTotal.Text = (Convert.ToDouble(LblTotal.Text) * -1).ToString();
                }
                cmd.CommandText = string.Format(@"INSERT INTO TblAlkazna (ActionId, HarakaNo, ActionDate, Amony, notes, namee, closek, UserIn, TimeIn)
                VALUES ({0}, (Select Isnull(Max(HarakaNo) + 1, 1) From TblAlkazna Where ActionId = {0}), {1}, {2}, N'{3}', N'{4}', 1, {5}, GETDATE())",
                ActionId, StoreTrDate, LblTotal.Text, MemInfo.Text, "فاتورة مبيعات", FXFW.SqlDB.UserInfo.UserID);
                cmd.ExecuteNonQuery();
                //Trn.Commit();
                // Print Bill Resit
                using (BillResitFrm PrintResit = new BillResitFrm(StoreTrID, StoreTrIDDAY, StoreTrIDTYPE, DEStoreTrDate.Text, LUEPERSONID.Text, LblTotal.Text, LblTotal.Text))
                    PrintResit.ShowDialog();

                MessageBox.Show("تم حفظ الفاتوره", "تمت الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew_Click(BtnNew, new EventArgs());
                DEStoreTrDate.Focus();
            }
            catch (SqlException ex)
            {
                //Trn.Rollback();
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void xtraTabControlBuyBill_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEdit)
                LoadEditGrid();
        }
        private void gridViewEdit_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetBillDetial();
        }
        private void repositoryItemButtonEditEditUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Update Bill
            if (MessageBox.Show("هل ترغب في التعديل؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            DataRow row = gridViewEdit.GetFocusedDataRow();
            if (row["TRHEL"].ToString() == "True")
            {
                Program.msg("لا يمكن تعديل هذه الفاتوره وذلك لان تم ترحيلها ", true, "", this);
                return;
            }
            string StoreTrDate, PERSONID, EMPID, Totalkasm, DiscountTypeId, REM, StoreID, BillPayTypeID, StoreTrIDDAY;
            if (row["StoreTrDate"].ToString() != string.Empty)
                StoreTrDate = string.Format("Convert(Datetime, '{0}', 103)", row["StoreTrDate"]);
            else
                StoreTrDate = "NULL";
            if (row["PERSONID"].ToString() != string.Empty)
                PERSONID = row["PERSONID"].ToString();
            else
                PERSONID = "NULL";
            if (row["EMPID"].ToString() != string.Empty)
                EMPID = row["EMPID"].ToString();
            else
                EMPID = "NULL";
            if (row["Totalkasm"].ToString() != string.Empty)
                Totalkasm = row["Totalkasm"].ToString();
            else
                Totalkasm = "0";
            if (row["DiscountTypeId"].ToString() != string.Empty)
                DiscountTypeId = row["DiscountTypeId"].ToString();
            else
                DiscountTypeId = "NULL";
            if (row["REM"].ToString() != string.Empty)
                REM = String.Format("N'{0}'", row["REM"]);
            else
                REM = "NULL";
            if (row["StoreID"].ToString() != string.Empty)
                StoreID = row["StoreID"].ToString();
            else
                StoreID = "NULL";
            if (row["BillPayTypeID"].ToString() != string.Empty)
                BillPayTypeID = row["BillPayTypeID"].ToString();
            else
                BillPayTypeID = "NULL";
            if (row["StoreTrIDDAY"].ToString() != string.Empty)
                StoreTrIDDAY = row["StoreTrIDDAY"].ToString();
            else
                StoreTrIDDAY = "NULL";
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = string.Format(@"Update TBLStoreTransaction Set StoreTrDate = {0}, StoreTrIDDAY = {1}, PERSONID = {2}, BillPayTypeID = {3}, DiscountTypeId = {4}, Totalkasm = {5}, 
                REM = {6}, StoreID = {7}, EMPID = {8}, UserIN = {9}, TimeIN = GETDATE() Where StoreTrID = {10}", StoreTrDate, StoreTrIDDAY, PERSONID, BillPayTypeID, DiscountTypeId, Totalkasm, REM, StoreID, EMPID, FXFW.SqlDB.UserInfo.UserID, row["StoreTrID"].ToString());
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
            DataRow row = gridViewEdit.GetFocusedDataRow();
            if (row["TRHEL"].ToString() == "True")
            {
                Program.msg("لا يمكن حذف هذه الفاتوره وذلك لان تم ترحيلها ", true, "", this);
                return;
            }
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            SqlTransaction Trn = null;
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                Cmd.CommandText = "DELETE FROM StoreTransactionDetailes WHERE StoreTrID = " + row["StoreTrID"].ToString();
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "DELETE FROM TBLStoreTransaction WHERE StoreTrID = " + row["StoreTrID"].ToString();
                Cmd.ExecuteNonQuery();
                Trn.Commit();
                LoadEditGrid();
                Program.msg("تم حذف الفاتوره", false, "", this);
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            Con.Close();
        }
        private void repositoryItemButtonEditEditTarhel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الترحيل حيث لا يمكن تعديل او حذف هذه الفاتوره؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataRow row = gridViewEdit.GetFocusedDataRow();
            if (row["TRHEL"].ToString() == "True")
            {
                Program.msg("لا يمكن ترحيل هذه الفاتوره وذلك لان تم ترحيلها مسبقا ", true, "", this);
                return;
            }
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = "Update TBLStoreTransaction Set TRHEL = 'True' WHERE StoreTrID = " + row["StoreTrID"].ToString();
                Cmd.ExecuteNonQuery();

                LoadEditGrid();
                Program.msg("تم حذف الفاتوره", false, "", this);
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            Con.Close();
        }
        private void TxtEditBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtEditBarcode.Text == string.Empty)
                return;
            if (e.KeyChar != (char)Keys.Enter)
                return;
            try
            {
                if (AsnafTbl.Compute("Sum(SanfID)", "SanfID = " + TxtEditBarcode.Text).ToString() == string.Empty)
                {
                    TxtEditBarcode.Text = string.Empty;
                    Program.msg("لا يوجد صنف بهذا السريال", true, "", this);
                    return;
                }
                if (gridViewEdit.FocusedRowHandle == -1 || TxtEditQuantity.Text.Length == 0)
                {
                    Program.msg("من فضلك اختر فاتوره و حركه و كميه", true, "", this);
                    return;
                }
                DataRow row = BillsDetialTbl.NewRow();
                row["SanfID"] = AsnafTbl.Compute("Sum(SanfID)", "SanfID = " + TxtEditBarcode.Text).ToString();
                row["harakatype"] = ((int)Program.HarakaType.مرتجع).ToString();
                row["Quantity"] = TxtEditQuantity.Text;
                row["Price"] = FXFW.SqlDB.LoadDataTable(@"Select priceout From TblPricelistdetailes Where SanfID = " + TxtEditBarcode.Text).Rows[0][0].ToString();
                row["DiscountTypeId"] = ((int)Program.DiscountType.بدون_خصم).ToString();
                row["Discount"] = "0";
                string StoreTrID = ((DataRow)gridViewEdit.GetFocusedDataRow())["StoreTrID"].ToString();
                BillsDetialTbl.Rows.Add(row);
                SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    con.Open();
                    cmd.CommandText = string.Format(@"INSERT INTO StoreTransactionDetailes (StoreTrID, SanfID, Quantity, Price, Discount, harakatype, DiscountTypeId) VALUES 
                    ({0}, {1}, {2}, {3}, {4}, {5}, {6})", StoreTrID, row["SanfID"], row["Quantity"], row["Price"], row["Discount"], row["harakatype"], row["DiscountTypeId"]);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
                }
                con.Close();
                gridControlEditDetails.DataSource = BillsDetialTbl;
            }
            catch (Exception ex)
            {
                Program.msg(ex.Message, true, "", this);
            }
            TxtBarCode.Text = string.Empty;
        }
        private void repositoryItemButtonEditEditDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        private void repositoryItemButtonEditDelDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete Detial
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int index = gridViewEditDetails.GetDataSourceRowIndex(gridViewEditDetails.FocusedRowHandle);
            DataRow row = BillsDetialTbl.Rows[index];
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
        
        #endregion

    }
}