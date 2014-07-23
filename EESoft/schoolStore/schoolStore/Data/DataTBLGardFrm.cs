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
    public partial class DataTBLGardFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable CDASNAF = new DataTable();
        #endregion
        #region -   Functions   -
        public DataTBLGardFrm()
        {
            InitializeComponent();
        }
        private void LoadDefault()
        {
            lueEMPID.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"Select EMPID, EMPNAME, (Select JOBNAME From CDJOB Where JOBID = TBLEMP.JOBID) AS JOBNAME From TBLEMP");
            lueEMPID.Properties.DisplayMember = "EMPNAME";
            lueEMPID.Properties.ValueMember = "EMPID";
            CDASNAF = FXFW.SqlDB.LoadDataTable(@"Select SanfID, SanfName, Sanfbarcode FROM CDASNAF");
        }
        private void LoadGard()
        {
            lueGardId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"Select GardId, GardDate, 
            CONVERT(nvarchar, GardDate, 103) + ' - ' + (Select EMPNAME From TBLEMP Where EMPID = TBLGard.EMPID) AS Details,
            (Select EMPNAME From TBLEMP Where EMPID = TBLGard.EMPID) AS EMPNAME 
            From TBLGard");
            lueGardId.Properties.DisplayMember = "Details";
            lueGardId.Properties.ValueMember = "GardId";
 
        }
        private void LoadGrid(object GardId)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(GardId))
                gridControlData.DataSource = new DataTable();
            else
            {
                gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"Select GardId, SanfID, scount, 
            (Select SanfName From CDASNAF Where SanfID = TabGardDetials.SanfID) AS SanfName From TabGardDetials Where GardId = " + GardId);
            }
        }
        private int SearchBarcode(string barcode)
        {
            int returnMe = -1;
            for (int i = 0; i < CDASNAF.Rows.Count; i++)
            {
                if (barcode == CDASNAF.Rows[i]["Sanfbarcode"].ToString())
                {
                    returnMe = i;
                    break;
                }
            }
            return returnMe;
        }
        private bool Saving(string GardId, string SanfID, string scount)
        {
            bool returnMe = false;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"INSERT INTO TabGardDetials (GardId, SanfID, scount) VALUES(@GardId, @SanfID, @scount)";
                cmd.Parameters.Add(new SqlParameter("@GardId", SqlDbType.Int) { Value = GardId });
                cmd.Parameters.Add(new SqlParameter("@SanfID", SqlDbType.Int) { Value = SanfID });
                cmd.Parameters.Add(new SqlParameter("@scount", SqlDbType.Int) { Value = scount });
                con.Open();
                cmd.ExecuteNonQuery();
                returnMe = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطـــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            return returnMe;
        }
        #endregion
        #region -   Event Handlers   -
        private void DataTBLGardFrm_Load(object sender, EventArgs e)
        {
            LoadDefault();
            LoadGard();
        }
        private void lueGardId_EditValueChanged(object sender, EventArgs e)
        {
            LoadGrid(lueGardId.EditValue.ToString());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(deGardDate.EditValue) || FXFW.SqlDB.IsNullOrEmpty(lueEMPID.EditValue))
            {
                MessageBox.Show("من فضلك اختار مسؤل الجرد و التاريخ", "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"INSERT INTO TBLGard (GardId, GardDate, EMPID) VALUES((Select ISNULL(MAX(GardId) + 1, 1) From TBLGard), @GardDate, @EMPID)";

                cmd.Parameters.Add(new SqlParameter("@GardDate", SqlDbType.Date) { Value = deGardDate.EditValue });
                cmd.Parameters.Add(new SqlParameter("@EMPID", SqlDbType.Int) { Value = lueEMPID.EditValue });
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الاضافه", "تمت العمليــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطـــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            LoadGard();
        }
        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {
            if (tbBarcode.Text.Trim().Length != 6)
                return;
            if (FXFW.SqlDB.IsNullOrEmpty(lueGardId.EditValue) || FXFW.SqlDB.ConvertStringToInt(tbscount.Text) == 0)
            {
                MessageBox.Show("من فضلك اختار جرد و كميه", "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = SearchBarcode(tbBarcode.Text.Trim());// search for sanf barcode
            if (index == -1)
            {
                MessageBox.Show("لا يوجد صنف بهذا الباركود", "غير صحيح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBarcode.Text = string.Empty;
                return;
            }
            if (Saving(lueGardId.EditValue.ToString(), CDASNAF.Rows[index]["SanfID"].ToString(), tbscount.Text.Trim()))
                tbBarcode.Text = string.Empty;
            LoadGrid(lueGardId.EditValue.ToString());
            
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            try
            {
                cmd.CommandText = @"DELETE FROM TabGardDetials WHERE GardId = @GardId AND SanfID = @SanfID";

                cmd.Parameters.Add(new SqlParameter("@GardId", SqlDbType.Int) { Value = row["GardId"] });
                cmd.Parameters.Add(new SqlParameter("@SanfID", SqlDbType.Int) { Value = row["SanfID"] });
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحــــذف", "تمت العمليــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطـــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            LoadGrid(lueGardId.EditValue.ToString());
        }
        #endregion
        
    }
}