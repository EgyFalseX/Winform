using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace schoolStore
{
    public partial class DataReturnSellStuBillFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        #endregion
        #region -   Functions   -
        public DataReturnSellStuBillFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            SLUEBills.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT StoreTrID, STTRANSTYPEID, StoreTrDate, StoreTrIDDAY, StoreTrIDTYPE, PERSONID, BillPayTypeID, DiscountTypeId, 
            (Select stu_name from student where stu_code = PERSONID) as stu_name,
            (Select stu_name from student where stu_code = PERSONID) + ' - ' + CONVERT(nvarchar, StoreTrDate, 103)  AS Details,
            Totalkasm, ExtraFees, REM, UserIN, TimeIN,  StoreID, EMPID, TRHEL FROM TBLStoreTransaction Where STTRANSTYPEID = 2");
        }
        private DataTable LoadData(string StoreTrID)
        {
            DataTable dt = new DataTable();
            dt = FXFW.SqlDB.LoadDataTable(@"SELECT StoreTrID, SanfID, harakatype, Quantity, Price, DiscountTypeId, Discount,
            (SELECT SanfName FROM CDASNAF WHERE SanfID = StoreTransactionDetailes.SanfID) AS SanfName,
            (SELECT DiscountType FROM CdDiscountType WHERE DiscountTypeId = StoreTransactionDetailes.DiscountTypeId) AS DiscountType,
            'false' AS chkMe
            FROM StoreTransactionDetailes WHERE harakatype = 2 AND NOT EXISTS 
            (SELECT StoreTrID FROM StoreTransactionDetailes AS StoreTransactionDetailes_1 WHERE StoreTrID = StoreTransactionDetailes.StoreTrID AND SanfID = StoreTransactionDetailes.SanfID AND harakatype = 1)
            AND StoreTrID = " + StoreTrID);
            return dt;
        }
        #endregion
        #region -   Event Handlers   -
        private void DataReturnSellStuBillFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            

        }
        private void SLUEBills_EditValueChanged(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(SLUEBills.EditValue))
                gridControlData.DataSource = new DataTable();
            else
                gridControlData.DataSource = LoadData(SLUEBills.EditValue.ToString());
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            DataRow row = gridViewData.GetFocusedDataRow();
            try
            {
                cmd.CommandText = @"INSERT INTO dbo.StoreTransactionDetailes
                                            ( StoreTrID ,
                                              SanfID ,
                                              harakatype ,
                                              Quantity ,
                                              Price ,
                                              DiscountTypeId ,
                                              Discount
                                            )
                                    VALUES  ( @StoreTrID , -- StoreTrID - int
                                              @SanfID , -- SanfID - int
                                              @harakatype , -- harakatype - smallint
                                              @Quantity , -- Quantity - int
                                              @Price , -- Price - float
                                              @DiscountTypeId , -- DiscountTypeId - smallint
                                              @Discount  -- Discount - float
                                            )";
                cmd.Parameters.Add(new SqlParameter("@StoreTrID", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@SanfID", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@harakatype", SqlDbType.SmallInt));
                cmd.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float));
                cmd.Parameters.Add(new SqlParameter("@DiscountTypeId", SqlDbType.SmallInt));
                cmd.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Float));
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow item in ((DataTable)gridControlData.DataSource).Rows)
                {
                    if ((bool)row["RemoveMe"] == true)
                    {
                        cmd.Parameters[@"StoreTrID"].Value = row["StoreTrID"];
                        cmd.Parameters[@"SanfID"].Value = row["SanfID"];
                        cmd.Parameters[@"harakatype"].Value = "1";
                        cmd.Parameters[@"Quantity"].Value = row["Quantity"];
                        cmd.Parameters[@"Price"].Value = row["Price"];
                        cmd.Parameters[@"DiscountTypeId"].Value = row["DiscountTypeId"];
                        cmd.Parameters[@"Discount"].Value = row["Discount"];
                        cmd.ExecuteNonQuery();
                    }
                }
                trn.Commit();
                Program.msg("تم الحفـــــــظ", false, "", this);
                SLUEBills_EditValueChanged(SLUEBills, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void repositoryItemButtonEditReturn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            //SqlTransaction trn = null;
            DataRow row = gridViewData.GetFocusedDataRow();
            try
            {
                cmd.CommandText = @"INSERT INTO dbo.StoreTransactionDetailes
                                            ( StoreTrID ,
                                              SanfID ,
                                              harakatype ,
                                              Quantity ,
                                              Price ,
                                              DiscountTypeId ,
                                              Discount
                                            )
                                    VALUES  ( @StoreTrID , -- StoreTrID - int
                                              @SanfID , -- SanfID - int
                                              @harakatype , -- harakatype - smallint
                                              @Quantity , -- Quantity - int
                                              @Price , -- Price - float
                                              @DiscountTypeId , -- DiscountTypeId - smallint
                                              @Discount  -- Discount - float
                                            )";
                cmd.Parameters.Add(new SqlParameter("@StoreTrID", SqlDbType.Int) { Value = row["StoreTrID"] });
                cmd.Parameters.Add(new SqlParameter("@SanfID", SqlDbType.Int) { Value = row["SanfID"] });
                cmd.Parameters.Add(new SqlParameter("@harakatype", SqlDbType.SmallInt) { Value = "1" });
                cmd.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int) { Value = row["Quantity"] });
                cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float) { Value = row["Price"] });
                cmd.Parameters.Add(new SqlParameter("@DiscountTypeId", SqlDbType.SmallInt) { Value = row["DiscountTypeId"] });
                cmd.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Float) { Value = row["Discount"] });
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحفـــــــظ", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SLUEBills_EditValueChanged(SLUEBills, new EventArgs());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطـــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        #endregion

    }
}