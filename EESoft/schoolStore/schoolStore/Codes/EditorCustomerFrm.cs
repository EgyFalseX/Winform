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
    public partial class EditorCustomerFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable CustomerTbl = new DataTable("CustomersSuppliers");
        string NewAccountId = string.Empty;
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            CustomerTbl = new DataTable("CustomersSuppliers");
            CustomerTbl = FXFW.SqlDB.LoadDataTable("SELECT PERSONID, PERSON, Addess, Tel, Mobil, Fax, remark, AccountId, (Select AccountTreeId From TBL_Accountes Where AccountId = CustomersSuppliers.AccountId) As AccountTreeId FROM CustomersSuppliers Where PERSONTYPE = 1");
            LUEItems.Properties.DataSource = CustomerTbl;
            LUEItems.Properties.DisplayMember = "PERSON";
            LUEItems.Properties.ValueMember = "PERSONID";
        }
        private void GetNewAccountID()
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("SELECT ISNULL(MAX(AccountTreeId) + 1, " + Program.AccountTreeIdCustomer + ") AS NewID FROM TBL_Accountes AS NewID WHERE (PairantAccount = " + Program.AccountIdCustomer + ")", Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    ReturnMe = dr.GetValue(0).ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Con.Close();
            NewAccountId = Program.GetNewID("TBL_Accountes", "AccountId");
            TxtNewAccountId.Text = ReturnMe;
        }
        public EditorCustomerFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            SqlTransaction Trn = null;
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CustomersSuppliers WHERE (PERSONID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Trn = Con.BeginTransaction();
                    Cmd.Transaction = Trn;
                    Cmd.ExecuteNonQuery();
                    if (CustomerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString() != string.Empty)
                    {
                        Cmd.CommandText = "DELETE FROM TBL_Accountes Where AccountId = " + CustomerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString();
                        Cmd.ExecuteNonQuery();
                    }
                    Trn.Commit();
                    LoadData();
                    GetNewAccountID();
                    LUEItems.ItemIndex = -1;
                    MessageBox.Show("تم الحـــذف ", "حـــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Trn.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                string Addess = "NULL", Tel = "NULL", Mobil = "NULL", Fax = "NULL", remark = "NULL";
                if (TxtNewAddess.Text.Trim().Length > 0)
                    Addess = String.Format("N'{0}'", TxtNewAddess.Text.Trim());
                if (TxtNewTel.Text.Trim().Length > 0)
                    Tel = String.Format("N'{0}'", TxtNewTel.Text.Trim());
                if (TxtNewMobil.Text.Trim().Length > 0)
                    Mobil = String.Format("N'{0}'", TxtNewMobil.Text.Trim());
                if (TxtNewFax.Text.Trim().Length > 0)
                    Fax = String.Format("N'{0}'", TxtNewFax.Text.Trim());
                if (TxtNewremark.Text.Trim().Length > 0)
                    remark = String.Format("N'{0}'", TxtNewremark.Text.Trim());
                SqlTransaction Trn = null;
                SqlCommand Cmd = new SqlCommand("", Con);
                try
                {
                    Con.Open();
                    Trn = Con.BeginTransaction();
                    Cmd.Transaction = Trn;
                    Cmd.CommandText = String.Format(@"INSERT INTO TBL_Accountes (AccountId, AccountTreeId, PairantAccount, AccountDes) VALUES ({0}, {1}, {2}, N'{3}')",
                    NewAccountId, TxtNewAccountId.Text, Program.AccountIdCustomer, TxtNewName.Text.Trim());
                    Cmd.ExecuteNonQuery();
                    Cmd.CommandText = String.Format(@"INSERT INTO CustomersSuppliers (PERSONID, PERSON, Addess, Tel, Mobil, Fax, remark, AccountId, PERSONTYPE)
                    VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}, 1)", Program.GetNewID("CustomersSuppliers", "PERSONID"), TxtNewName.Text.Trim(), Addess, Tel, Mobil, Fax, remark, NewAccountId); ;
                    Cmd.ExecuteNonQuery();
                    Trn.Commit();
                    TxtNewName.Text = string.Empty;
                    TxtNewAddess.Text = string.Empty;
                    TxtNewTel.Text = string.Empty;
                    TxtNewMobil.Text = string.Empty;
                    TxtNewFax.Text = string.Empty;
                    TxtNewremark.Text = string.Empty;
                    TxtNewName.Focus();
                    LoadData();
                    GetNewAccountID();
                    MessageBox.Show("تم الاضــــافه", "اضافــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Trn.Rollback();
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex == -1)
                return;
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                string Addess = "NULL", Tel = "NULL", Mobil = "NULL", Fax = "NULL", remark = "NULL", AccountId = "NULL";
                if (TxtEditAddess.Text.Trim().Length > 0)
                    Addess = String.Format("N'{0}'", TxtEditAddess.Text.Trim());
                if (TxtEditTel.Text.Trim().Length > 0)
                    Tel = String.Format("N'{0}'", TxtEditTel.Text.Trim());
                if (TxtEditMobil.Text.Trim().Length > 0)
                    Mobil = String.Format("N'{0}'", TxtEditMobil.Text.Trim());
                if (TxtEditFax.Text.Trim().Length > 0)
                    Fax = String.Format("N'{0}'", TxtEditFax.Text.Trim());
                if (TxtEditremark.Text.Trim().Length > 0)
                    remark = String.Format("N'{0}'", TxtEditremark.Text.Trim());
                if (CustomerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString() != string.Empty)
                {
                    AccountId = CustomerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString();
                }
                SqlCommand Cmd = new SqlCommand(String.Format(@"UPDATE CustomersSuppliers SET PERSON = N'{0}', Addess = {1}, Tel = {2}, Mobil = {3}, Fax = {4}, remark = {5} WHERE (PERSONID = {6})", 
                TxtEditName.Text.Trim(), Addess, Tel, Mobil, Fax, remark, LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم التعــــديل ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            GetNewAccountID();
        }
        private void EditorCustomerFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            GetNewAccountID();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditName.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["PERSON"].ToString();
                TxtEditAddess.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["Addess"].ToString();
                TxtEditTel.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["Tel"].ToString();
                TxtEditMobil.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["Mobil"].ToString();
                TxtEditFax.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["Fax"].ToString();
                TxtEditremark.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["remark"].ToString();
                TxtEditAccountId.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["AccountTreeId"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditName.Text = string.Empty;
                TxtEditAddess.Text = string.Empty;
                TxtEditTel.Text = string.Empty;
                TxtEditMobil.Text = string.Empty;
                TxtEditFax.Text = string.Empty;
                TxtEditremark.Text = string.Empty;
                TxtEditAccountId.Text = string.Empty;
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
            if (TxtNewAccountId.Text.Trim().Length == 0 || NewAccountId == string.Empty || TxtNewName.Text.Trim().Length == 0)
                BtnAdd.Enabled = false;
            else
                BtnAdd.Enabled = true;
        }
        private void TxtNewAccountId_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewAccountId.Text.Trim().Length == 0 || NewAccountId == string.Empty || TxtNewName.Text.Trim().Length == 0)
                BtnAdd.Enabled = false;
            else
                BtnAdd.Enabled = true;
        }
        #endregion
    }
}