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
    public partial class EditorRoleFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ItemsTbl = new DataTable("Items");
            ItemsTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleID, RoleName, RoleDesc FROM Roles");
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "RoleName";
            LUEItems.Properties.ValueMember = "RoleID";
        }
        public EditorRoleFrm()
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
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM Roles WHERE (RoleID = {0})", LUEItems.EditValue), Con);
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
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO Roles (RoleID, RoleName, RoleDesc) VALUES ({0}, N'{1}', N'{2}')", Program.GetNewID("Roles", "RoleID"), TxtNewItem.Text.Trim(), TxtNewDes.Text.Trim()), Con);
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
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE Roles SET RoleName = N'{0}', RoleDesc = N'{1}' WHERE (RoleID = {2})", TxtEditItem.Text.Trim(), TxtEditDes.Text.Trim(), LUEItems.EditValue), Con);
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
            if (TxtNewItem.Text.Trim().Length > 0)
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
                TxtEditDes.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["RoleDesc"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditItem.Text = string.Empty;
                TxtEditDes.Text = string.Empty;
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