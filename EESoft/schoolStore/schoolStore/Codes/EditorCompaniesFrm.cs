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
    public partial class EditorCompaniesFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable CompanyTbl = new DataTable("CompanyTable");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            CompanyTbl = new DataTable("CompanyTable");
            CompanyTbl = FXFW.SqlDB.LoadDataTable("SELECT CompanyID, Company, CompanyOfficial, CompanyAddess, CompanyTel, CompanyMobil, CompanyFax, remark FROM CDCompany");
            LUEItems.Properties.DataSource = CompanyTbl;
            LUEItems.Properties.DisplayMember = "Company";
            LUEItems.Properties.ValueMember = "CompanyID";
        }
        public EditorCompaniesFrm()
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
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDCompany WHERE (CompanyID = {0})", LUEItems.EditValue), Con);
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
                string CompanyOfficial = "NULL", CompanyAddess = "NULL", CompanyTel = "NULL", CompanyMobil = "NULL", CompanyFax = "NULL", remark = "NULL";
                if (TxtNewOfficial.Text.Trim().Length > 0)
                    CompanyOfficial = "N'" + TxtNewOfficial.Text.Trim() + "'";
                if (TxtNewAddess.Text.Trim().Length > 0)
                    CompanyAddess = "N'" + TxtNewAddess.Text.Trim() + "'";
                if (TxtNewPhone.Text.Trim().Length > 0)
                    CompanyTel = "N'" + TxtNewPhone.Text.Trim() + "'";
                if (TxtNewMobile.Text.Trim().Length > 0)
                    CompanyMobil = "N'" + TxtNewMobile.Text.Trim() + "'";
                if (TxtNewFax.Text.Trim().Length > 0)
                    CompanyFax = "N'" + TxtNewFax.Text.Trim() + "'";
                if (TxtNewBremark.Text.Trim().Length > 0)
                    remark = "N'" + TxtNewBremark.Text.Trim() + "'";
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDCompany  (CompanyID, Company, CompanyOfficial, CompanyAddess, CompanyTel, CompanyMobil, CompanyFax, remark) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7})", Program.GetNewID("CDCompany", "CompanyID"), TxtNewName.Text.Trim(), CompanyOfficial, CompanyAddess, CompanyTel, CompanyMobil, CompanyFax, remark), Con);
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
                string CompanyOfficial = "NULL", CompanyAddess = "NULL", CompanyTel = "NULL", CompanyMobil = "NULL", CompanyFax = "NULL", remark = "NULL";
                if (TxtEditOfficial.Text.Trim().Length > 0)
                    CompanyOfficial = "N'" + TxtEditOfficial.Text.Trim() + "'";
                if (TxtEditAddess.Text.Trim().Length > 0)
                    CompanyAddess = "N'" + TxtEditAddess.Text.Trim() + "'";
                if (TxtEditPhone.Text.Trim().Length > 0)
                    CompanyTel = "N'" + TxtEditPhone.Text.Trim() + "'";
                if (TxtEditMobile.Text.Trim().Length > 0)
                    CompanyMobil = "N'" + TxtEditMobile.Text.Trim() + "'";
                if (TxtEditFax.Text.Trim().Length > 0)
                    CompanyFax = "N'" + TxtEditFax.Text.Trim() + "'";
                if (TxtEditBremark.Text.Trim().Length > 0)
                    remark = "N'" + TxtEditBremark.Text.Trim() + "'";
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDCompany SET Company = N'{0}',CompanyOfficial = {1}, CompanyAddess = {2}, CompanyTel = {3}, CompanyMobil = {4}, CompanyFax = {5}, remark = {6} WHERE (CompanyID = {7})", TxtEditName.Text.Trim(), CompanyOfficial, CompanyAddess, CompanyTel, CompanyMobil, CompanyFax, remark, LUEItems.EditValue), Con);
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
        private void EditorCompaniesFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditName.Text = CompanyTbl.Rows[LUEItems.ItemIndex]["Company"].ToString();
                TxtEditOfficial.Text = CompanyTbl.Rows[LUEItems.ItemIndex]["CompanyOfficial"].ToString();
                TxtEditAddess.Text = CompanyTbl.Rows[LUEItems.ItemIndex]["CompanyAddess"].ToString();
                TxtEditPhone.Text = CompanyTbl.Rows[LUEItems.ItemIndex]["CompanyTel"].ToString();
                TxtEditMobile.Text = CompanyTbl.Rows[LUEItems.ItemIndex]["CompanyMobil"].ToString();
                TxtEditFax.Text = CompanyTbl.Rows[LUEItems.ItemIndex]["CompanyFax"].ToString();
                TxtEditBremark.Text = CompanyTbl.Rows[LUEItems.ItemIndex]["remark"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditName.Text = string.Empty;
                TxtEditOfficial.Text = string.Empty;
                TxtEditAddess.Text = string.Empty;
                TxtEditPhone.Text = string.Empty;
                TxtEditMobile.Text = string.Empty;
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