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
    public partial class EditorBankFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable BankTbl = new DataTable("BankTable");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            BankTbl = new DataTable("BankTable");
            BankTbl = FXFW.SqlDB.LoadDataTable("SELECT BankAcountID, BankName, BankAcountNO, BankAcountName, BankAddess, BankTel1, BankTel2, BankFax, Bremark FROM CDBANK");
            LUEItems.Properties.DataSource = BankTbl;
            LUEItems.Properties.DisplayMember = "BankName";
            LUEItems.Properties.ValueMember = "BankAcountID";
        }
       public EditorBankFrm()
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
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDBANK WHERE (BankAcountID = {0})", LUEItems.EditValue), Con);
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
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                string BankAcountNO = "NULL", BankAcountName = "NULL", BankAddess = "NULL", BankTel1 = "NULL", BankTel2 = "NULL", BankFax = "NULL", Bremark = "NULL";
                if (TxtNewAcountNo.Text.Trim().Length > 0)
                    BankAcountNO = "N'" + TxtNewAcountNo.Text.Trim() + "'";
                if (TxtNewAccountName.Text.Trim().Length > 0)
                    BankAcountName = "N'" + TxtNewAccountName.Text.Trim() + "'";
                if (TxtNewAddress.Text.Trim().Length > 0)
                    BankAddess = "N'" + TxtNewAddress.Text.Trim() + "'";
                if (TxtNewPhone1.Text.Trim().Length > 0)
                    BankTel1 = "N'" + TxtNewPhone1.Text.Trim() + "'";
                if (TxtNewPhone2.Text.Trim().Length > 0)
                    BankTel2 = "N'" + TxtNewPhone2.Text.Trim() + "'";
                if (TxtNewFax.Text.Trim().Length > 0)
                    BankFax = "N'" + TxtNewFax.Text.Trim() + "'";
                if (TxtNewBremark.Text.Trim().Length > 0)
                    Bremark = "N'" + TxtNewBremark.Text.Trim() + "'";
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDBANK  (BankAcountID, BankName, BankAcountNO, BankAcountName, BankAddess, BankTel1, BankTel2, BankFax, Bremark) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}, {8})", Program.GetNewID("CDBANK", "BankAcountID"), TxtNewName.Text.Trim(), BankAcountNO, BankAcountName, BankAddess, BankTel1, BankTel2, BankFax, Bremark), Con);
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
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                string BankAcountNO = "NULL", BankAcountName = "NULL", BankAddess = "NULL", BankTel1 = "NULL", BankTel2 = "NULL", BankFax = "NULL", Bremark = "NULL";
                if (TxtEditAcountNo.Text.Trim().Length > 0)
                    BankAcountNO = "N'" + TxtEditAcountNo.Text.Trim() + "'";
                if (TxtEditAccountName.Text.Trim().Length > 0)
                    BankAcountName = "N'" + TxtEditAccountName.Text.Trim() + "'";
                if (TxtEditAddress.Text.Trim().Length > 0)
                    BankAddess = "N'" + TxtEditAddress.Text.Trim() + "'";
                if (TxtEditPhone1.Text.Trim().Length > 0)
                    BankTel1 = "N'" + TxtEditPhone1.Text.Trim() + "'";
                if (TxtEditPhone2.Text.Trim().Length > 0)
                    BankTel2 = "N'" + TxtEditPhone2.Text.Trim() + "'";
                if (TxtEditFax.Text.Trim().Length > 0)
                    BankFax = "N'" + TxtEditFax.Text.Trim() + "'";
                if (TxtEditBremark.Text.Trim().Length > 0)
                    Bremark = "N'" + TxtEditBremark.Text.Trim() + "'";
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDBANK SET BankName = N'{0}',BankAcountNO = {1}, BankAcountName = {2}, BankAddess = {3}, BankTel1 = {4}, BankTel2 = {5}, BankFax = {6}, Bremark = {7} WHERE (BankAcountID = {8})", TxtEditName.Text.Trim(), BankAcountNO, BankAcountName, BankAddess, BankTel1, BankTel2, BankFax, Bremark, LUEItems.EditValue), Con);
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
        }
        private void EditorBankFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditName.Text = BankTbl.Rows[LUEItems.ItemIndex]["BankName"].ToString();
                TxtEditAcountNo.Text = BankTbl.Rows[LUEItems.ItemIndex]["BankAcountNO"].ToString();
                TxtEditAccountName.Text = BankTbl.Rows[LUEItems.ItemIndex]["BankAcountName"].ToString();
                TxtEditAddress.Text = BankTbl.Rows[LUEItems.ItemIndex]["BankAddess"].ToString();
                TxtEditPhone1.Text = BankTbl.Rows[LUEItems.ItemIndex]["BankTel1"].ToString();
                TxtEditPhone2.Text = BankTbl.Rows[LUEItems.ItemIndex]["BankTel2"].ToString();
                TxtEditFax.Text = BankTbl.Rows[LUEItems.ItemIndex]["BankFax"].ToString();
                TxtEditBremark.Text = BankTbl.Rows[LUEItems.ItemIndex]["Bremark"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditName.Text = string.Empty;
                TxtEditAcountNo.Text = string.Empty;
                TxtEditAccountName.Text = string.Empty;
                TxtEditAddress.Text = string.Empty;
                TxtEditPhone1.Text = string.Empty;
                TxtEditPhone2.Text = string.Empty;
                TxtEditFax.Text = string.Empty;
                TxtEditBremark.Text = string.Empty;
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