using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Training_Center
{
    public partial class EditorUserFrm : XtraForm
    {
        #region -   Variables   -
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ItemsTbl = new DataTable("Items");
            ItemsTbl = MyCL.LoadDataTable("SELECT UserID, UserName, UserPass, IsActive FROM Users");
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "UserName";
            LUEItems.Properties.ValueMember = "UserID";
        }
        public EditorUserFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد ..?!", "تأكيد الحذف..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            using (SqlConnection Con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM Users WHERE UserID = {0}", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LUEItems.ItemIndex = -1;
                    MyCL.ShowMsg("تم الحذف ..", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
            }
            LoadData();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtAddPass1.Text.Trim().Length == 0 || TxtAddPass1.Text.Trim() != TxtAddPass2.Text.Trim())
            {
                MyCL.ShowMsg("من فضلك ادخل كلمة المرور ..", true, this);
                return;
            }
            string IsActive;
            if (CEAddActive.Checked)
                IsActive = "1";
            else
                IsActive = "0";
            using (SqlConnection Con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO Users (UserID, UserName, UserPass, IsActive) VALUES ({0}, '{1}', '{2}', {3})", MyCL.GetNewID("Users", "UserID"), TxtAddItem.Text.Trim(), TxtAddPass1.Text.Trim(), IsActive), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    MyCL.ShowMsg("تم الاضافه ..", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
            }
            LoadData();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtEditPass1.Text.Trim().Length == 0 || TxtEditPass1.Text.Trim() != TxtEditPass2.Text.Trim())
            {
                MyCL.ShowMsg("من فضلك ادخل كلمة المرور ..", true, this);
                return;
            }
            string IsActive;
            if (CEEditActive.Checked)
                IsActive = "1";
            else
                IsActive = "0";
            using (SqlConnection Con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE Users SET UserName = '{0}', UserPass = '{1}', IsActive = {2} WHERE UserID = {3}", TxtEditItem.Text.Trim(), TxtEditPass1.Text.Trim(), IsActive, LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    MyCL.ShowMsg("تم التعديل ..", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
            }
            LoadData();
        }
        private void TxtNewItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtAddItem.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditItem.Text.Trim().Length > 0 && LUEItems.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditItem.Text = LUEItems.Text;
                TxtEditPass1.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["UserPass"].ToString();
                TxtEditPass2.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["UserPass"].ToString();
                if (ItemsTbl.Rows[LUEItems.ItemIndex]["IsActive"].ToString() == "True")
                    CEEditActive.Checked = true;
                else
                    CEEditActive.Checked = false;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditItem.Text = string.Empty;
                TxtEditPass1.Text = string.Empty;
                TxtEditPass2.Text = string.Empty;
                CEEditActive.Checked = true;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            LUEItems.EditValue = null;
        }
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}