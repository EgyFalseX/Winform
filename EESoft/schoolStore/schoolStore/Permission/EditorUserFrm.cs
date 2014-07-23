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
    public partial class EditorUserFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ItemsTbl = new DataTable("Items");
            ItemsTbl = FXFW.SqlDB.LoadDataTable("SELECT UserID, UserName, UserPass, IsActive FROM Users");
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
            if (MessageBox.Show("هل انت متأكد ..?!", "تأكيد الحذف..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM Users WHERE (UserID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEItems.ItemIndex = -1;
                    Program.msg("تم الحذف ..", false, "", this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtAddPass1.Text.Trim().Length == 0 || TxtAddPass1.Text.Trim() != TxtAddPass2.Text.Trim())
            {
                Program.msg("من فضلك ادخل كلمة المرور ..", true, "None", this);
                return;
            }
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO Users (UserID, UserName, UserPass, IsActive) VALUES ({0}, N'{1}', N'{2}', N'{3}')", Program.GetNewID("Users", "UserID"), TxtAddItem.Text.Trim(), TxtAddPass1.Text.Trim(), CEAddActive.Checked.ToString()), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    Program.msg("تم الاضافه ..", false, "", this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtEditPass1.Text.Trim().Length == 0 || TxtEditPass1.Text.Trim() != TxtEditPass2.Text.Trim())
            {
                Program.msg("من فضلك ادخل كلمة المرور ..", true, "None", this);
                return;
            }
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE Users SET UserName = N'{0}', UserPass = N'{1}', IsActive = N'{2}' WHERE (UserID = {3})", TxtEditItem.Text.Trim(), TxtEditPass1.Text.Trim(), CEEditActive.Checked.ToString(), LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    Program.msg("تم التعديل ..", false, "", this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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