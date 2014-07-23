using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;

namespace E_Club_Mem_Manager
{
    public partial class EditorUserInRoleFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable UsersTbl = new DataTable("Users");
        DataTable RolesTbl = new DataTable("Roles");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            UsersTbl = new DataTable("Users");
            UsersTbl = Program.MC.LoadDataTable("SELECT UserID, UserName FROM aspnet_Users", Program.MC.SQLConStrMembers);
            LUEItems.Properties.DataSource = UsersTbl;
            LUEItems.Properties.DisplayMember = "UserName";
            LUEItems.Properties.ValueMember = "UserID";
        }
        private void LoadRoles(string Userid)
        {
            RolesTbl = new DataTable("Roles");
            RolesTbl = Program.MC.LoadDataTable("SELECT RoleID, RoleName, RoleDesc, (SELECT '1' AS Active FROM aspnet_UsersInRoles WHERE (UserId = " + Userid + ") AND (RoleId = aspnet_Roles.RoleID)) AS Active FROM aspnet_Roles", Program.MC.SQLConStrMembers);
            CLSCRole.Items.Clear();
            foreach (DataRow row in RolesTbl.Rows)
            {
                if (row["Active"] == System.DBNull.Value)
                    CLSCRole.Items.Add(row["RoleID"].ToString(), row["RoleName"].ToString(), CheckState.Unchecked, true);
                else
                    CLSCRole.Items.Add(row["RoleID"].ToString(), row["RoleName"].ToString(), CheckState.Checked, true);
            }
        }
        public EditorUserInRoleFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                SqlCommand Cmd = new SqlCommand("", Con);
                SqlTransaction trn = null;
                try
                {
                    Con.Open();
                    trn = Con.BeginTransaction();
                    Cmd.Transaction = trn;
                    Cmd.CommandText = string.Format("Delete From aspnet_UsersInRoles Where UserId = {0}", LUEItems.EditValue);
                    Cmd.ExecuteNonQuery();
                    foreach (DataRow row in RolesTbl.Rows)
                    {
                        if (row["Active"].ToString() == "1")
                        {
                            Cmd.CommandText = String.Format("INSERT INTO aspnet_UsersInRoles (UserId, RoleId) VALUES ({0}, {1})", LUEItems.EditValue, row["RoleID"].ToString());
                            Cmd.ExecuteNonQuery();
                        }
                    }
                    trn.Commit();
                    LoadRoles(LUEItems.EditValue.ToString());
                    MessageBox.Show("تم التعــــديل ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    trn.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            TxtNote.Text = string.Empty;
            if (LUEItems.ItemIndex > -1)
            {
                LoadRoles(LUEItems.EditValue.ToString());
                BtnUpdate.Enabled = true;
            }
            else
                BtnUpdate.Enabled = false;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void CLSCRole_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State == CheckState.Checked)
                RolesTbl.Rows[e.Index]["Active"] = "1";
            else
                RolesTbl.Rows[e.Index]["Active"] = "0";
        }
        private void CLSCRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CLSCRole.SelectedIndex != -1)
                TxtNote.Text = RolesTbl.Rows[CLSCRole.SelectedIndex]["RoleDesc"].ToString();
            else
                TxtNote.Text = string.Empty;
        }
        #endregion
    }
}