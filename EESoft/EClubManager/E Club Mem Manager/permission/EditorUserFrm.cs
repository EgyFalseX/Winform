using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Mem_Manager
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
            ItemsTbl = Program.MC.LoadDataTable("SELECT UserID, UserName, [Password], IsActive FROM aspnet_Users", Program.MC.SQLConStrMembers);
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
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM aspnet_Users WHERE (UserID = {0})", LUEItems.EditValue), Con);
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
            if (TxtAddPass1.Text.Trim().Length == 0 || TxtAddPass1.Text.Trim() != TxtAddPass2.Text.Trim())
            {
                MessageBox.Show("من فضلك ادخل كلمة المرور");
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO aspnet_Users (UserID, UserName, Password, IsActive) VALUES ({0}, N'{1}', N'{2}', N'{3}')", MCls.GetNewIDMember("aspnet_Users", "UserID"), TxtAddItem.Text.Trim(), TxtAddPass1.Text.Trim(), CEAddActive.Checked.ToString()), Con);
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
            if (TxtEditPass1.Text.Trim().Length == 0 || TxtEditPass1.Text.Trim() != TxtEditPass2.Text.Trim())
            {
                MessageBox.Show("من فضلك ادخل كلمة المرور");
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE aspnet_Users SET UserName = N'{0}', Password = N'{1}', IsActive = N'{2}' WHERE (UserID = {3})", TxtEditItem.Text.Trim(), TxtEditPass1.Text.Trim(), CEEditActive.Checked.ToString(), LUEItems.EditValue), Con);
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
                TxtEditPass1.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["Password"].ToString();
                TxtEditPass2.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["Password"].ToString();
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
        }
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}