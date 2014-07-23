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
    public partial class DataEmpFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable EmpTbl = new DataTable("EmpTable");
        DataTable JobTbl = new DataTable("JobTable");
        string NewAccountId = string.Empty;
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            EmpTbl = new DataTable("EmpTable");
            EmpTbl = FXFW.SqlDB.LoadDataTable("SELECT EMPID, EMPNAME, EMPNID, JOBID, (Select JOBNAME From CDJOB Where JOBID = TBLEMP.JOBID) AS JOBNAME , EMPPHONE, EMPMOBIL, EMPADDRESS FROM TBLEMP");
            LUEItems.Properties.DataSource = EmpTbl;
            LUEItems.Properties.DisplayMember = "EMPNAME";
            LUEItems.Properties.ValueMember = "EMPID";

            JobTbl = new DataTable("JobTable");
            JobTbl = FXFW.SqlDB.LoadDataTable("Select JOBID, JOBNAME From CDJOB");
            LUEEditJob.Properties.DataSource = JobTbl;
            LUEEditJob.Properties.DisplayMember = "JOBNAME";
            LUEEditJob.Properties.ValueMember = "JOBID";
            LUEJob.Properties.DataSource = JobTbl;
            LUEJob.Properties.DisplayMember = "JOBNAME";
            LUEJob.Properties.ValueMember = "JOBID";
        }
        public DataEmpFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM TBLEMP WHERE (EMPID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEItems.ItemIndex = -1;
                    MessageBox.Show("تم الحـــذف ", "حـــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string EMPNID = "NULL", JOBID = "NULL", EMPPHONE = "NULL", EMPMOBIL = "NULL", EMPADDRESS = "NULL";
            if (TxtNewNID.Text.Trim().Length != 0)
                EMPNID = "N'" + TxtNewNID.Text.Trim() + "'";
            if (LUEJob.EditValue != null)
                JOBID = LUEJob.EditValue.ToString();
            if (TxtNewTel.Text.Trim().Length != 0)
                EMPPHONE = "N'" + TxtNewTel.Text.Trim() + "'";
            if (TxtNewMobil.Text.Trim().Length != 0)
                EMPMOBIL = "N'" + TxtNewMobil.Text.Trim() + "'";
            if (TxtNewAddress.Text.Trim().Length != 0)
                EMPADDRESS = "N'" + TxtNewAddress.Text.Trim() + "'";
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO TBLEMP (EMPID, EMPNAME, EMPNID, JOBID, EMPPHONE, EMPMOBIL, EMPADDRESS) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6})", Program.GetNewID("TBLEMP", "EMPID"), TxtNewName.Text.Trim(), EMPNID, JOBID, EMPPHONE, EMPMOBIL, EMPADDRESS), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم الاضــــافه", "اضافــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string EMPNID = "NULL", JOBID = "NULL", EMPPHONE = "NULL", EMPMOBIL = "NULL", EMPADDRESS = "NULL";
            if (TxtEditNID.Text.Trim().Length != 0)
                EMPNID = "N'" + TxtEditNID.Text.Trim() + "'";
            if (LUEEditJob.EditValue != null)
                JOBID = LUEEditJob.EditValue.ToString();
            if (TxtEditTel.Text.Trim().Length != 0)
                EMPPHONE = "N'" + TxtEditTel.Text.Trim() + "'";
            if (TxtEditMobil.Text.Trim().Length != 0)
                EMPMOBIL = "N'" + TxtEditMobil.Text.Trim() + "'";
            if (TxtEditAddress.Text.Trim().Length != 0)
                EMPADDRESS = "N'" + TxtEditAddress.Text.Trim() + "'";
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE TBLEMP SET EMPNAME = '{0}', EMPNID = {1}, JOBID = {2}, EMPPHONE = {3}, EMPMOBIL = {4}, EMPADDRESS = {5} WHERE (EMPID = {6})", TxtEditName.Text.Trim(), EMPNID, JOBID, EMPPHONE, EMPMOBIL, EMPADDRESS,LUEEditJob.EditValue.ToString()), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم الاضــــافه", "اضافــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void DataEmpFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditName.Text = EmpTbl.Rows[LUEItems.ItemIndex]["EMPNAME"].ToString();
                TxtEditNID.Text = EmpTbl.Rows[LUEItems.ItemIndex]["EMPNID"].ToString();
                LUEEditJob.EditValue = EmpTbl.Rows[LUEItems.ItemIndex]["JOBID"];
                TxtEditTel.Text = EmpTbl.Rows[LUEItems.ItemIndex]["EMPPHONE"].ToString();
                TxtEditMobil.Text = EmpTbl.Rows[LUEItems.ItemIndex]["EMPMOBIL"].ToString();
                TxtEditAddress.Text = EmpTbl.Rows[LUEItems.ItemIndex]["EMPADDRESS"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditName.Text = string.Empty;
                TxtEditNID.Text = string.Empty;
                LUEEditJob.EditValue = null;
                TxtEditTel.Text = string.Empty;
                TxtEditMobil.Text = string.Empty;
                TxtEditAddress.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void TxtEditName_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditName.Text.Trim().Length > 0 && LUEItems.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void TxtNewName_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewName.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        #endregion
    }
}