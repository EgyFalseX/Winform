using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Acc_Manager
{
    public partial class EditorSuppliersFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable SupplerTbl = new DataTable("SupplerTable");
        string NewAccountId = string.Empty;
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            SupplerTbl = new DataTable("SupplerTable");
            SupplerTbl = Program.MC.LoadDataTable("SELECT SupplierID, Supplier, SupplierOfficial, SupplierAddess, SupplierTel, SupplierMobil, SupplierFax, remark, AccountId, (Select AccountTreeId From TBL_Accountes Where AccountId = CDSuppliers.AccountId) As AccountTreeId FROM CDSuppliers");
            LUEItems.Properties.DataSource = SupplerTbl;
            LUEItems.Properties.DisplayMember = "Supplier";
            LUEItems.Properties.ValueMember = "SupplierID";
        }
        private void GetNewAccountID()
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand("SELECT ISNULL(MAX(AccountTreeId) + 1, " + Program.MC.AccountTreeIdSuppler + ") AS NewID FROM TBL_Accountes AS NewID WHERE (PairantAccount = " + Program.MC.AccountIdSuppler + ")", Con);
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
        public EditorSuppliersFrm()
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
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDSuppliers WHERE (SupplierID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Trn = Con.BeginTransaction();
                    Cmd.Transaction = Trn;
                    Cmd.ExecuteNonQuery();
                    if (SupplerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString() != string.Empty)
                    {
                        Cmd.CommandText = "DELETE FROM TBL_Accountes Where AccountId = " + SupplerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString();
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
                string SupplerOfficial = "NULL", SupplerAddess = "NULL", SupplerTel = "NULL", SupplerMobil = "NULL", SupplerFax = "NULL", remark = "NULL";
                if (TxtNewSupplerOfficial.Text.Trim().Length > 0)
                    SupplerOfficial = "N'" + TxtNewSupplerOfficial.Text.Trim() + "'";
                if (TxtNewSupplerAddess.Text.Trim().Length > 0)
                    SupplerAddess = "N'" + TxtNewSupplerAddess.Text.Trim() + "'";
                if (TxtNewSupplerTel.Text.Trim().Length > 0)
                    SupplerTel = "N'" + TxtNewSupplerTel.Text.Trim() + "'";
                if (TxtNewSupplerMobil.Text.Trim().Length > 0)
                    SupplerMobil = "N'" + TxtNewSupplerMobil.Text.Trim() + "'";
                if (TxtNewSupplerFax.Text.Trim().Length > 0)
                    SupplerFax = "N'" + TxtNewSupplerFax.Text.Trim() + "'";
                if (TxtNewremark.Text.Trim().Length > 0)
                    remark = "N'" + TxtNewremark.Text.Trim() + "'";

                SqlCommand Cmd = new SqlCommand("", Con);
                SqlTransaction Trn = null;
                try
                {
                    Cmd.CommandText = "INSERT INTO TBL_Accountes (AccountId, AccountTreeId, PairantAccount, AccountDes) VALUES (" + NewAccountId + ", " + TxtNewAccountId.Text + ", " + Program.MC.AccountIdSuppler + ", N'" + TxtNewName.Text.Trim() + "')";
                    Con.Open();
                    Trn = Con.BeginTransaction();
                    Cmd.Transaction = Trn;
                    Cmd.ExecuteNonQuery();
                    Cmd.CommandText = String.Format("INSERT INTO CDSuppliers (SupplierID, Supplier, SupplierOfficial, SupplierAddess, SupplierTel, SupplierMobil, SupplierFax, remark, AccountId) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}, {8})", MCls.GetNewID("CDSuppliers", "SupplierID"), TxtNewName.Text.Trim(), SupplerOfficial, SupplerAddess, SupplerTel, SupplerMobil, SupplerFax, remark, NewAccountId); ;
                    Cmd.ExecuteNonQuery();
                    Trn.Commit();
                    TxtNewName.Text = string.Empty;
                    TxtNewSupplerOfficial.Text = string.Empty;
                    TxtNewSupplerAddess.Text = string.Empty;
                    TxtNewSupplerTel.Text = string.Empty;
                    TxtNewSupplerMobil.Text = string.Empty;
                    TxtNewSupplerFax.Text = string.Empty;
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
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts))
            {
                string SupplerOfficial = "NULL", SupplerAddess = "NULL", SupplerTel = "NULL", SupplerMobil = "NULL", SupplerFax = "NULL", remark = "NULL", AccountId = "NULL";
                if (TxtEditSupplerOfficial.Text.Trim().Length > 0)
                    SupplerOfficial = "N'" + TxtEditSupplerOfficial.Text.Trim() + "'";
                if (TxtEditSupplerAddess.Text.Trim().Length > 0)
                    SupplerAddess = "N'" + TxtEditSupplerAddess.Text.Trim() + "'";
                if (TxtEditSupplerTel.Text.Trim().Length > 0)
                    SupplerTel = "N'" + TxtEditSupplerTel.Text.Trim() + "'";
                if (TxtEditSupplerMobil.Text.Trim().Length > 0)
                    SupplerMobil = "N'" + TxtEditSupplerMobil.Text.Trim() + "'";
                if (TxtEditSupplerFax.Text.Trim().Length > 0)
                    SupplerFax = "N'" + TxtEditSupplerFax.Text.Trim() + "'";
                if (TxtEditremark.Text.Trim().Length > 0)
                    remark = "N'" + TxtEditremark.Text.Trim() + "'";
                if (SupplerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString() != string.Empty)
                {
                    AccountId = SupplerTbl.Rows[LUEItems.ItemIndex]["AccountId"].ToString();
                }
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDSuppliers SET Supplier = N'{0}',SupplierOfficial = {1}, SupplierAddess = {2}, SupplierTel = {3}, SupplierMobil = {4}, SupplierFax = {5}, remark = {6} WHERE (SupplierID = {7})", TxtEditName.Text.Trim(), SupplerOfficial, SupplerAddess, SupplerTel, SupplerMobil, SupplerFax, remark, LUEItems.EditValue), Con);
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
        private void EditorSuppliersFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            GetNewAccountID();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditName.Text = SupplerTbl.Rows[LUEItems.ItemIndex]["Supplier"].ToString();
                TxtEditSupplerOfficial.Text = SupplerTbl.Rows[LUEItems.ItemIndex]["SupplierOfficial"].ToString();
                TxtEditSupplerAddess.Text = SupplerTbl.Rows[LUEItems.ItemIndex]["SupplierAddess"].ToString();
                TxtEditSupplerTel.Text = SupplerTbl.Rows[LUEItems.ItemIndex]["SupplierTel"].ToString();
                TxtEditSupplerMobil.Text = SupplerTbl.Rows[LUEItems.ItemIndex]["SupplierMobil"].ToString();
                TxtEditSupplerFax.Text = SupplerTbl.Rows[LUEItems.ItemIndex]["SupplierFax"].ToString();
                TxtEditremark.Text = SupplerTbl.Rows[LUEItems.ItemIndex]["remark"].ToString();
                TxtEditAccountId.Text = SupplerTbl.Rows[LUEItems.ItemIndex]["AccountTreeId"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditName.Text = string.Empty;
                TxtEditSupplerOfficial.Text = string.Empty;
                TxtEditSupplerAddess.Text = string.Empty;
                TxtEditSupplerTel.Text = string.Empty;
                TxtEditSupplerMobil.Text = string.Empty;
                TxtEditSupplerFax.Text = string.Empty;
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