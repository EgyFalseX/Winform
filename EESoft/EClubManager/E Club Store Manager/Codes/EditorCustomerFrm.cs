using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Store_Manager
{
    public partial class EditorCustomerFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable CustomerTbl = new DataTable("CustomerTable");
        string NewAccountId = string.Empty;
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            CustomerTbl = new DataTable("CustomerTable");
            CustomerTbl = Program.MC.LoadDataTable("SELECT CustomerID, Customer, CustomerOfficial, CustomerAddess, CustomerTel, CustomerMobil, CustomerFax, remark, AccountId, (Select AccountTreeId From TBL_Accountes Where AccountId = CDCustomers.AccountId) As AccountTreeId FROM CDCustomers");
            LUEItems.Properties.DataSource = CustomerTbl;
            LUEItems.Properties.DisplayMember = "Customer";
            LUEItems.Properties.ValueMember = "CustomerID";
        }
        private void GetNewAccountID()
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand("SELECT ISNULL(MAX(AccountTreeId) + 1, " + Program.MC.AccountTreeIdCustomer + ") AS NewID FROM TBL_Accountes AS NewID WHERE (PairantAccount = " + Program.MC.AccountIdCustomer + ")", Con);
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
            NewAccountId = MCls.GetNewID("TBL_Accountes", "AccountId");
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
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDCustomers WHERE (CustomerID = {0})", LUEItems.EditValue), Con);
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
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts))
            {
                string CustomerOfficial = "NULL", CustomerAddess = "NULL", CustomerTel = "NULL", CustomerMobil = "NULL", CustomerFax = "NULL", remark = "NULL";
                if (TxtNewCustomerOfficial.Text.Trim().Length > 0)
                    CustomerOfficial = "N'" + TxtNewCustomerOfficial.Text.Trim() + "'";
                if (TxtNewCustomerAddess.Text.Trim().Length > 0)
                    CustomerAddess = "N'" + TxtNewCustomerAddess.Text.Trim() + "'";
                if (TxtNewCustomerTel.Text.Trim().Length > 0)
                    CustomerTel = "N'" + TxtNewCustomerTel.Text.Trim() + "'";
                if (TxtNewCustomerMobil.Text.Trim().Length > 0)
                    CustomerMobil = "N'" + TxtNewCustomerMobil.Text.Trim() + "'";
                if (TxtNewCustomerFax.Text.Trim().Length > 0)
                    CustomerFax = "N'" + TxtNewCustomerFax.Text.Trim() + "'";
                if (TxtNewremark.Text.Trim().Length > 0)
                    remark = "N'" + TxtNewremark.Text.Trim() + "'";
                SqlTransaction Trn = null;
                SqlCommand Cmd = new SqlCommand("", Con);
                
                try
                {
                    Con.Open();
                    Trn = Con.BeginTransaction();
                    Cmd.Transaction = Trn;
                    Cmd.CommandText = "INSERT INTO TBL_Accountes (AccountId, AccountTreeId, PairantAccount, AccountDes) VALUES (" + NewAccountId + ", " + TxtNewAccountId.Text + ", " + Program.MC.AccountIdCustomer + ", N'" + TxtNewName.Text.Trim() + "')";
                    Cmd.ExecuteNonQuery();
                    Cmd.CommandText = String.Format("INSERT INTO CDCustomers (CustomerID, Customer, CustomerOfficial, CustomerAddess, CustomerTel, CustomerMobil, CustomerFax, remark, AccountId) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}, {8})", MCls.GetNewID("CDCustomers", "CustomerID"), TxtNewName.Text.Trim(), CustomerOfficial, CustomerAddess, CustomerTel, CustomerMobil, CustomerFax, remark, NewAccountId); ;
                    Cmd.ExecuteNonQuery();
                    Trn.Commit();
                    TxtNewName.Text = string.Empty;
                    TxtNewCustomerOfficial.Text = string.Empty;
                    TxtNewCustomerAddess.Text = string.Empty;
                    TxtNewCustomerTel.Text = string.Empty;
                    TxtNewCustomerMobil.Text = string.Empty;
                    TxtNewCustomerFax.Text = string.Empty;
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
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts))
            {
                string CustomerOfficial = "NULL", CustomerAddess = "NULL", CustomerTel = "NULL", CustomerMobil = "NULL", CustomerFax = "NULL", remark = "NULL", AccountId = "NULL";
                if (TxtEditCustomerOfficial.Text.Trim().Length > 0)
                    CustomerOfficial = "N'" + TxtEditCustomerOfficial.Text.Trim() + "'";
                if (TxtEditCustomerAddess.Text.Trim().Length > 0)
                    CustomerAddess = "N'" + TxtEditCustomerAddess.Text.Trim() + "'";
                if (TxtEditCustomerTel.Text.Trim().Length > 0)
                    CustomerTel = "N'" + TxtEditCustomerTel.Text.Trim() + "'";
                if (TxtEditCustomerMobil.Text.Trim().Length > 0)
                    CustomerMobil = "N'" + TxtEditCustomerMobil.Text.Trim() + "'";
                if (TxtEditCustomerFax.Text.Trim().Length > 0)
                    CustomerFax = "N'" + TxtEditCustomerFax.Text.Trim() + "'";
                if (TxtEditremark.Text.Trim().Length > 0)
                    remark = "N'" + TxtEditremark.Text.Trim() + "'";
                if (CustomerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString() != string.Empty)
                {
                    AccountId = CustomerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString();
                }
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDCustomers SET Customer = N'{0}',CustomerOfficial = {1}, CustomerAddess = {2}, CustomerTel = {3}, CustomerMobil = {4}, CustomerFax = {5}, remark = {6} WHERE (CustomerID = {7})", TxtEditName.Text.Trim(), CustomerOfficial, CustomerAddess, CustomerTel, CustomerMobil, CustomerFax, remark, LUEItems.EditValue), Con);
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
                TxtEditName.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["Customer"].ToString();
                TxtEditCustomerOfficial.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["CustomerOfficial"].ToString();
                TxtEditCustomerAddess.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["CustomerAddess"].ToString();
                TxtEditCustomerTel.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["CustomerTel"].ToString();
                TxtEditCustomerMobil.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["CustomerMobil"].ToString();
                TxtEditCustomerFax.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["CustomerFax"].ToString();
                TxtEditremark.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["remark"].ToString();
                TxtEditAccountId.Text = CustomerTbl.Rows[LUEItems.ItemIndex]["AccountTreeId"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditName.Text = string.Empty;
                TxtEditCustomerOfficial.Text = string.Empty;
                TxtEditCustomerAddess.Text = string.Empty;
                TxtEditCustomerTel.Text = string.Empty;
                TxtEditCustomerMobil.Text = string.Empty;
                TxtEditCustomerFax.Text = string.Empty;
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