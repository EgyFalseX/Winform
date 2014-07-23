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

namespace BookStore
{
    public partial class DataSellStuBillBarCodeFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        
        DataTable AsnafTbl = new DataTable();
        DataTable TasnefTbl = new DataTable();
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

            TasnefTbl = FXFW.SqlDB.LoadDataTable(@"Select distinct [CategoryID],(SELECT Category FROM CDCategories WHERE CategoryId = CDASNAF.CategoryId) AS Category,
            (SELECT alsofof_code FROM CDCategories WHERE CategoryId = CDASNAF.CategoryId) AS alsofof_code From CDASNAF");

            repositoryItemLookUpEditEditSanfID.DataSource = AsnafTbl;
            repositoryItemLookUpEditEditSanfID.DisplayMember = "SanfName";
            repositoryItemLookUpEditEditSanfID.ValueMember = "SanfID";

            CBESanf.Properties.Items.Clear();
            foreach (DataRow row in AsnafTbl.Rows)
                CBESanf.Properties.Items.Add(row["SanfName"].ToString());

            CBETasnef.Properties.Items.Clear();
            foreach (DataRow row in TasnefTbl.Rows)
                CBETasnef.Properties.Items.Add(row["Category"].ToString());
            
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
            harakatypeTbl = FXFW.SqlDB.LoadDataTable("SELECT harakatype, haraka FROM CdHaraka WHERE harakatype = 2 OR harakatype = 1");

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
            //gridViewAdd.EndUpdate();
            //GridControlAddDetials.EndUpdate();
            //GridControlAddDetials.RefreshDataSource();
            //gridViewAdd.RefreshData();
            //gridViewAdd.RefreshEditor(true);
            try
            {
                if (ItemDetials.Rows.Count == 0)
                {
                    LblTotal.Text = "0";
                    return;
                }
                foreach (DataRow row in ItemDetials.Rows)
                {
                    try
                    {
                        if (row["Quantity"].ToString() == string.Empty || row["Price"].ToString() == string.Empty || row["Discount"].ToString() == string.Empty || row["harakatype"].ToString() == string.Empty || row["DiscountTypeId"].ToString() == string.Empty)
                            continue;
                    }
                    catch
                    { continue; }

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
            catch 
            {}
        }
        private void LoadEditGrid()
        {
            //GridControlEdit
            BillsTbl = new DataTable();
            BillsTbl = FXFW.SqlDB.LoadDataTable(@"SELECT StoreTrID, STTRANSTYPEID, StoreTrDate, StoreTrIDDAY, StoreTrIDTYPE, PERSONID, BillPayTypeID, DiscountTypeId, Totalkasm, ExtraFees, REM, UserIN, TimeIN, 
StoreID, EMPID, TRHEL
FROM TBLStoreTransaction
WHERE (STTRANSTYPEID = 2) AND (TRHEL = 'False') AND (NOT EXISTS
 (SELECT StoreTrID FROM StoreTransactionDetailes WHERE (StoreTrID = TBLStoreTransaction.StoreTrID) AND (harakatype = 1)))");
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
                BillsDetialTbl = FXFW.SqlDB.LoadDataTable(@"SELECT StoreTrID, SanfID, harakatype, Quantity, Price, DiscountTypeId, Discount 
                FROM StoreTransactionDetailes Where StoreTrID = " + row["StoreTrID"].ToString());
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
        private static string ItemCountNotStored(string SanfID)
        {
            DataTable Tbl = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT ISNULL(Quantity, 0) AS Quantity FROM v_daily_st_nosarf WHERE SanfID = {0}", SanfID));
            if (Tbl.Rows.Count == 0)
                return "0";
            else
                return Tbl.Rows[0][0].ToString();
        }
        private bool IfBookValidForStudent(string BookId, string studentId)
        {
            bool output = false;
            DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT * FROM CDASNAF WHERE SanfID = {0} AND
            (SELECT alsofof_code FROM CDCategories WHERE CategoryId = CDASNAF.CategoryId)
            =
            (SELECT alsofof_code FROM student WHERE stu_code = {1} AND asase_code = {2})", BookId, studentId, Program.asase_code));
            if (dt.Rows.Count != 0)
                output = true;
            return output;
        }
        private void ActiveKeyDownEventGrid(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F8 && e.KeyData != Keys.Enter)
                return;
            switch (e.KeyData)
            {
                case Keys.F5:
                    //((DataTable)GridControlAddDetials.DataSource).Rows.Add(((DataTable)GridControlAddDetials.DataSource).NewRow());
                    TxtBarCode.Focus();
                    break;
                case Keys.F6:
                    BtnSave_Click(BtnSave, new EventArgs());
                    break;
                case Keys.F8:
                    gridViewAdd.DeleteSelectedRows();
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region -   Event Handlers   -
        private void DataSellBillBarCodeFrm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dsBookStoreQueries.CDalsofof' table. You can move, or remove it, as needed.
            this.cDalsofofTableAdapter.Fill(this.dsBookStoreQueries.CDalsofof);
            // TODO: This line of code loads data into the 'dsBookStoreQueries.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dsBookStoreQueries.student);
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
            LUEPERSONID.Focus();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            LUEDiscountTypeId.ItemIndex = 2;
            TxtTotalkasm.Text = "0";
            MemInfo.Text = string.Empty;
            TxtBillID.Text = Program.GetNewID("TBLStoreTransaction", "StoreTrIDTYPE", "STTRANSTYPEID = 2");
            DEStoreTrDate.DateTime = DateTime.Today;
            DEStoreTrDate_EditValueChanged(DEStoreTrDate, new EventArgs());
            LUEPERSONID.EditValue = null;
            LUEEMPID.ItemIndex = 0;
            LUEStoreID.ItemIndex = 0;
            LUEBillPayType.ItemIndex = 0;
            TxtItemCount.Text = "1";
            TxtBarCode.Text = string.Empty;
            LblTotal.Text = "0";
            ItemDetials.Rows.Clear();
            LUEPERSONID.Focus();
        }
        private void CBESanf_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblItemCount2.Text = ItemCount(AsnafTbl.Rows[CBESanf.SelectedIndex]["SanfID"].ToString());
            LblItemCountNoStore2.Text = ItemCountNotStored(AsnafTbl.Rows[CBESanf.SelectedIndex]["SanfID"].ToString());
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
                if (LUEPERSONID.EditValue == null ||LUEPERSONID.EditValue.ToString() == string.Empty)
                {
                    
                    Program.msg("يجب اختيار طالب اولا", true, "", this);
                    TxtBarCode.Text = string.Empty;
                    return;
                }
                if (AsnafTbl.Compute("Sum(SanfID)", "Sanfbarcode = " + TxtBarCode.Text).ToString() == string.Empty)
                {
                    TxtBarCode.Text = string.Empty;
                    Program.msg("لا يوجد صنف بهذا السريال", true, "", this);
                    return;
                }
                List<DataRow> rows = new List<DataRow>();
                double count = 0, storecount = 0;
                
                foreach (DataRow itemRow in AsnafTbl.Rows)
                {
                    if (itemRow["Sanfbarcode"].ToString() != TxtBarCode.Text)
                        continue;
                    if (!IfBookValidForStudent(itemRow["SanfID"].ToString(), LUEPERSONID.EditValue.ToString()))
                    {
                        TxtBarCode.Text = string.Empty;
                        Program.msg("هذا الصنف غير مناسب للطالب", true, "", this);
                        return;
                    }
                    DataRow row = ItemDetials.NewRow();
                    row["SanfID"] = itemRow["SanfID"];
                    row["harakatype"] = ((int)Program.HarakaType.مبيعات).ToString(); //مبيعات
                    row["Quantity"] = TxtItemCount.Text;
                    row["Price"] = FXFW.SqlDB.LoadDataTable(@"Select Isnull(Max(priceout), 0) AS priceout From TblPricelistdetailes Where SanfID = " + row["SanfID"]).Rows[0][0].ToString();
                    row["DiscountTypeId"] = ((int)Program.DiscountType.بدون_خصم).ToString();
                    row["Discount"] = "0";
                    if (row["harakatype"].ToString() == ((int)Program.HarakaType.مبيعات).ToString())
                    {
                        if (ItemAvailability(row["SanfID"].ToString(), row["Quantity"].ToString()) == false)
                        {
                            TxtBarCode.Text = string.Empty;
                            Program.msg("لا يوجد كميه كافيه في المخزن", true, "", this);
                            return;
                        }
                    }
                    if (ItemSarfDoneBefore(row["SanfID"].ToString(), row["harakatype"].ToString(), LUEPERSONID.EditValue.ToString()))
                    {
                        TxtBarCode.Text = string.Empty;
                        Program.msg("هذا الصنف تم بيعه من قبل لنفس الطالب في السنه الحاليه ", true, "", this);
                        continue;
                    }
                    //rows.Add(row);
                    ItemDetials.Rows.Add(row);
                    count += Convert.ToDouble(ItemCount(row["SanfID"].ToString()));
                    storecount += Convert.ToDouble(ItemCountNotStored(row["SanfID"].ToString()));
                }

                GridControlAddDetials.DataSource = ItemDetials;
                ShowTotal();
                LblItemCount1.Text = count.ToString();
                LblItemCountNoStore1.Text = storecount.ToString();
            }
            catch (Exception ex)
            {
                Program.msg(ex.Message, true, "", this);
            }
            TxtBarCode.Text = string.Empty;
            //GridControlAddDetials.Focus();
        }
        private void BtnAddSanf_Click(object sender, EventArgs e)
        {
            if (CBESanf.SelectedIndex == -1)
                return;
            try
            {
                DataRow row = ItemDetials.NewRow();
                row["SanfID"] = AsnafTbl.Rows[CBESanf.SelectedIndex]["SanfID"].ToString();
                if (!IfBookValidForStudent(row["SanfID"].ToString(), LUEPERSONID.EditValue.ToString()))
                {
                    TxtBarCode.Text = string.Empty;
                    Program.msg("هذا الصنف غير مناسب للطالب", true, "", this);
                    return;
                }
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
                if (ItemSarfDoneBefore(row["SanfID"].ToString(), row["harakatype"].ToString(), LUEPERSONID.EditValue.ToString()))
                {
                    Program.msg("هذا الصنف تم بيعه من قبل لنفس الطالب في السنه الحاليه ", true, "", this);
                    return;
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
        private void BtnAddTasnef_Click(object sender, EventArgs e)
        {
             if (CBETasnef.SelectedIndex == -1)
                return;

             DataTable Asnaf = FXFW.SqlDB.LoadDataTable(@"Select SanfID, SanfName, Sanfbarcode From CDASNAF Where CategoryID = " + TasnefTbl.Rows[CBETasnef.SelectedIndex]["CategoryID"]);
            try
            {
                foreach (DataRow item in Asnaf.Rows)
                {
                    DataRow row = ItemDetials.NewRow();
                    row["SanfID"] = item["SanfID"].ToString();
                    row["harakatype"] = ((int)Program.HarakaType.مبيعات).ToString(); //مبيعات
                    row["Quantity"] = "1";
                    row["Price"] = FXFW.SqlDB.LoadDataTable(@"Select Isnull(Max(priceout), 0) AS priceout From TblPricelistdetailes Where SanfID = " + row["SanfID"]).Rows[0][0].ToString();
                    row["DiscountTypeId"] = ((int)Program.DiscountType.بدون_خصم).ToString();
                    row["Discount"] = "0";
                    if (row["harakatype"].ToString() == ((int)Program.HarakaType.مبيعات).ToString())
                    {
                        if (ItemAvailability(row["SanfID"].ToString(), row["Quantity"].ToString()) == false)
                        {
                            Program.msg("لا يوجد كميه كافيه في المخزن للصنف " + item["SanfName"], true, "", this);
                            continue;
                        }
                    }
                    if (ItemSarfDoneBefore(row["SanfID"].ToString(), row["harakatype"].ToString(), LUEPERSONID.EditValue.ToString()))
                    {
                         Program.msg("هذا الصنف تم بيعه من قبل لنفس الطالب في السنه الحاليه ", true, "", this);
                        continue;
                    }
                    ItemDetials.Rows.Add(row);
                }
                GridControlAddDetials.DataSource = ItemDetials;
                ShowTotal();
            }
            catch (Exception ex)
            {
                Program.msg(ex.Message, true, "", this);
            }
        }
        private bool ItemSarfDoneBefore(string SanfID, string harakatype, string PERSONID)
        {
            //يبين اذا تم صرف هذا الصنف لنفس الطالب في العام الحالي ام لا
            bool output = false;
            string command = string.Format(@"SELECT * FROM StoreTransactionDetailes WHERE SanfID = {0} AND harakatype = {1} AND
                    EXISTS(SELECT * FROM TBLStoreTransaction WHERE StoreTrID = StoreTransactionDetailes.StoreTrID AND PERSONID = {2} AND asase_code = {3})",
                    SanfID, harakatype, PERSONID, Program.asase_code);
            DataTable dtCheckExists = FXFW.SqlDB.LoadDataTable(command);
            if (dtCheckExists.Rows.Count > 0)
            {
                output = true;
            }
            return output;
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
        private void gridViewAdd_RowCountChanged(object sender, EventArgs e)
        {
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
        private void LUEPERSONID_EditValueChanged(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEPERSONID.EditValue))
                return;
            TasnefTbl = FXFW.SqlDB.LoadDataTable(@"Select distinct [CategoryID],(SELECT Category FROM CDCategories WHERE CategoryId = CDASNAF.CategoryId) AS Category,
            (SELECT alsofof_code FROM CDCategories WHERE CategoryId = CDASNAF.CategoryId) AS alsofof_code From CDASNAF");
            string alsofof_code = FXFW.SqlDB.LoadDataTable(@"SELECT [alsofof_code] FROM [dbo].[student] WHERE [stu_code] = " + LUEPERSONID.EditValue).Rows[0][0].ToString();
            CBETasnef.Properties.Items.Clear();
            CBETasnef.Text = string.Empty;
            CBETasnef.EditValue = null;

            for (int i = TasnefTbl.Rows.Count - 1; i >= 0; i--)
            {
                if (TasnefTbl.Rows[i]["alsofof_code"].ToString() == alsofof_code)
                {
                }
                else
                {
                    TasnefTbl.Rows.RemoveAt(i);
                }
            }
            for (int i = 0; i < TasnefTbl.Rows.Count; i++)
            {
                if (TasnefTbl.Rows[i]["alsofof_code"].ToString() == alsofof_code)
                    CBETasnef.Properties.Items.Add(TasnefTbl.Rows[i]["Category"].ToString());
            }
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
            if (MessageBox.Show("هل انت متأكد؟","حفظ الفاتوره...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                foreach (DataRow row in ItemDetials.Rows)
                {
                    if (row["SanfID"].ToString() == string.Empty || row["Quantity"].ToString() == string.Empty || row["Price"].ToString() == string.Empty || row["DiscountTypeId"].ToString() == string.Empty || row["Discount"].ToString() == string.Empty)
                    {
                        MessageBox.Show("بيانات صنف غير مكتمله", "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (ItemAvailability(row["SanfID"].ToString(), row["Quantity"].ToString()) == false)
                    {
                        Program.msg("لا يوجد كميه كافيه في المخزن", true, "", this);
                        return;
                    }
                }
                con.Open();
                
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
                cmd.CommandText = string.Format(@"INSERT INTO TBLStoreTransaction (StoreTrID, STTRANSTYPEID, StoreTrDate, StoreTrIDDAY, StoreTrIDTYPE, PERSONID, BillPayTypeID, Totalkasm, REM, StoreID, EMPID, TRHEL, asase_code, UserIN, TimeIN) VALUES
                ({0}, 2, {1}, {2}, (Select Isnull(Max(StoreTrIDTYPE) + 1, 1) From TBLStoreTransaction Where STTRANSTYPEID = 2), {3}, {4}, {5}, {6}, {7}, {8}, '{9}', {10}, {11}, GETDATE())",
                StoreTrID, StoreTrDate, StoreTrIDDAY, LUEPERSONID.EditValue, LUEBillPayType.EditValue, Totalkasm, REM, LUEStoreID.EditValue, EMPID, "False", Program.asase_code, FXFW.SqlDB.UserInfo.UserID);
                cmd.ExecuteNonQuery();
                bool HaveNoMortaga3 = false;
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
                    string harakatype = "2";
                    if (row["harakatype"].ToString() != string.Empty)
                    {
                        harakatype = row["harakatype"].ToString();
                        if (row["harakatype"].ToString() == "1" | row["harakatype"].ToString() == "3")// should do not show print if its mortaga3
                            HaveNoMortaga3 = true;
                    }
                    
                    
                    cmd.CommandText = string.Format(@"INSERT INTO StoreTransactionDetailes (StoreTrID, SanfID, Quantity, Price, Discount, harakatype, DiscountTypeId, ohda, ohdatypeid) VALUES 
                    ({0}, {1}, {2}, {3}, {4}, {5}, {6}, 'false', 1)", StoreTrID, row["SanfID"], row["Quantity"], row["Price"], row["Discount"], harakatype, row["DiscountTypeId"]);
                    cmd.ExecuteNonQuery();
                }
//                string ActionId = "2";
//                if (Convert.ToDouble(LblTotal.Text) <= 0)
//                {
//                    ActionId = "1";
//                    LblTotal.Text = (Convert.ToDouble(LblTotal.Text) * -1).ToString();
//                }
//                cmd.CommandText = string.Format(@"INSERT INTO TblAlkazna (ActionId, HarakaNo, ActionDate, Amony, notes, namee, closek, UserIn, TimeIn)
//                VALUES ({0}, (Select Isnull(Max(HarakaNo) + 1, 1) From TblAlkazna Where ActionId = {0}), {1}, {2}, N'{3}', N'{4}', 1, {5}, GETDATE())",
//                ActionId, StoreTrDate, LblTotal.Text, MemInfo.Text, "فاتورة مبيعات", FXFW.SqlDB.UserInfo.UserID);
//                cmd.ExecuteNonQuery();
                
                // Print Bill Resit
                ShowTotal();

                XRepBillResit report = new XRepBillResit();
                report.LoadDataSource(StoreTrID);

                report.LblStoreTrIDTYPE.Text = StoreTrIDTYPE;
                report.LblStoreTrIDDAY.Text = StoreTrIDDAY;
                report.LblStoreTrDate.Text = DEStoreTrDate.Text;
                report.LblSaf.Text = FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT alsofof_NAME FROM CDalsofof
                WHERE alsofof_code = (SELECT alsofof_code FROM student WHERE asase_code = {0} AND stu_code = 
                (SELECT PERSONID FROM TBLStoreTransaction WHERE StoreTrID = {1}) )", Program.asase_code, StoreTrID)).Rows[0][0].ToString() + ")";
                
                report.LblPERSONID.Text = LUEPERSONID.Text;
                report.LblTotal.Text = LblTotal.Text;
                report.LblPayed.Text = LblTotal.Text;
                report.xrBarCodeItem.Text = StoreTrID;


                DataTable dt = FXFW.SqlDB.LoadDataTable("SELECT Company FROM CDCompany");
                if (dt.Rows.Count > 0)
                    report.LblCompany.Text = dt.Rows[0]["Company"].ToString();
                else
                    report.LblCompany.Text = string.Empty;
                if (HaveNoMortaga3 == false)
                    Program.ShowPrintPreview(report);

                //using (BillResitFrm PrintResit = new BillResitFrm(StoreTrID, StoreTrIDDAY, StoreTrIDTYPE, DEStoreTrDate.Text, LUEPERSONID.Text, LblTotal.Text, LblTotal.Text))
                //    PrintResit.ShowDialog();


                MessageBox.Show("تم حفظ الفاتوره", "تمت الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew_Click(BtnNew, new EventArgs());
                LUEPERSONID.Focus();
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
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            Con.Close();
        }
        private void TxtEditBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
//            if (TxtEditBarcode.Text == string.Empty)
//                return;
//            if (e.KeyChar != (char)Keys.Enter)
//                return;
//            try
//            {
//                if (AsnafTbl.Compute("Sum(SanfID)", "SanfID = " + TxtEditBarcode.Text).ToString() == string.Empty)
//                {
//                    TxtEditBarcode.Text = string.Empty;
//                    Program.msg("لا يوجد صنف بهذا السريال", true, "", this);
//                    return;
//                }
//                if (gridViewEdit.FocusedRowHandle == -1 || TxtEditQuantity.Text.Length == 0)
//                {
//                    Program.msg("من فضلك اختر فاتوره و حركه و كميه", true, "", this);
//                    return;
//                }
//                DataRow row = BillsDetialTbl.NewRow();
//                row["SanfID"] = AsnafTbl.Compute("Sum(SanfID)", "SanfID = " + TxtEditBarcode.Text).ToString();
//                row["harakatype"] = ((int)Program.HarakaType.مرتجع).ToString();
//                row["Quantity"] = TxtEditQuantity.Text;
//                row["Price"] = FXFW.SqlDB.LoadDataTable(@"Select priceout From TblPricelistdetailes Where SanfID = " + TxtEditBarcode.Text).Rows[0][0].ToString();
//                row["DiscountTypeId"] = ((int)Program.DiscountType.بدون_خصم).ToString();
//                row["Discount"] = "0";
//                string StoreTrID = ((DataRow)gridViewEdit.GetFocusedDataRow())["StoreTrID"].ToString();
//                BillsDetialTbl.Rows.Add(row);
//                SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
//                SqlCommand cmd = new SqlCommand("", con);
//                try
//                {
//                    con.Open();
//                    cmd.CommandText = string.Format(@"INSERT INTO StoreTransactionDetailes (StoreTrID, SanfID, Quantity, Price, Discount, harakatype, DiscountTypeId) VALUES 
//                    ({0}, {1}, {2}, {3}, {4}, {5}, {6})", StoreTrID, row["SanfID"], row["Quantity"], row["Price"], row["Discount"], row["harakatype"], row["DiscountTypeId"]);
//                    cmd.ExecuteNonQuery();
//                }
//                catch (SqlException ex)
//                {
//                    Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
//                }
//                con.Close();
//                gridControlEditDetails.DataSource = BillsDetialTbl;
//            }
//            catch (Exception ex)
//            {
//                Program.msg(ex.Message, true, "", this);
//            }
//            TxtBarCode.Text = string.Empty;
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
        private void LUEPERSONID_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            //{
            //    TxtBarCode.Focus();
            //}
        }
        private void TxtEditBarcode_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            if (TxtEditBarcode.Text == string.Empty)
                return;

            string FilterString = TxtEditBarcode.Text.Trim();
            TxtEditBarcode.Clear();
            TxtEditBarcode.Focus();

            gridViewEdit.ActiveFilterString = "StoreTrIDTYPE = " + FilterString;
            gridViewEdit.SelectAll();
            GetBillDetial();
            TxtItemCount.Focus();
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //GetBillDetial();
            //DataTable dt1 = (DataTable)gridControlEditDetails.DataSource;
            DataRow row = gridViewEdit.GetFocusedDataRow();

            XRepBillResit report = new XRepBillResit();
            report.LoadDataSource(row["StoreTrID"].ToString());

            report.LblStoreTrIDTYPE.Text = row["StoreTrIDTYPE"].ToString();
            report.LblStoreTrIDDAY.Text = row["StoreTrIDDAY"].ToString();
            report.LblStoreTrDate.Text = DEStoreTrDate.Text;
            DataTable alsofof_NAMETbl = FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT alsofof_NAME FROM CDalsofof
                WHERE alsofof_code = (SELECT alsofof_code FROM student WHERE asase_code = (Select Max(asase_code) From student) AND stu_code = 
                (SELECT PERSONID FROM TBLStoreTransaction WHERE StoreTrID = {0}) )", row["StoreTrID"]));
            if (alsofof_NAMETbl.Rows.Count > 0)
                report.LblSaf.Text = alsofof_NAMETbl.Rows[0][0].ToString();

            report.LblPERSONID.Text = LUEPERSONID.Text;
            report.LblTotal.Text = LblTotal.Text;
            report.LblPayed.Text = LblTotal.Text;
            report.xrBarCodeItem.Text = row["StoreTrID"].ToString();


            DataTable dt = FXFW.SqlDB.LoadDataTable("SELECT Company FROM CDCompany");
            if (dt.Rows.Count > 0)
                report.LblCompany.Text = dt.Rows[0]["Company"].ToString();
            else
                report.LblCompany.Text = string.Empty;

            Program.ShowPrintPreview(report);

        }
        private void TxtBarcodeClose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            DataTable dt = FXFW.SqlDB.LoadDataTable(@"SELECT StoreTrID FROM TBLStoreTransaction WHERE StoreTrID = " + TxtBarcodeClose.Text);
            if (dt.Rows.Count == 0)
            {
                LBBarCodeCloseLog.Items.Add("لا يوجد فاتوره بهذ الرقم");
                TxtBarcodeClose.Text = string.Empty;
                return;
            }
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"UPDATE TBLStoreTransaction SET TRHEL = 'True' WHERE StoreTrID = " + TxtBarcodeClose.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                LBBarCodeCloseLog.Items.Add("تم اغلاق الفاتوره رقم " + TxtBarcodeClose.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            TxtBarcodeClose.Text = string.Empty;
        }
        private void LUESaf_EditValueChanged(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUESaf.EditValue))
                return;
            DataSources.dsBookStoreQueries.CDalsofofRow row = (DataSources.dsBookStoreQueries.CDalsofofRow)((DataRowView)LUESaf.GetSelectedDataRow()).Row;
            // TODO: This line of code loads data into the 'dsBookStoreQueries.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.FillByalsofof_code(this.dsBookStoreQueries.student, Program.asase_code, row.alsofof_code);
        }

        #endregion
    }
}