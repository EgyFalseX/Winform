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

namespace Booking
{
    public partial class UserRolesFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable UsersTbl = new DataTable("Users");
        DataTable RolesTbl = new DataTable("Roles");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            UsersTbl = new DataTable("Users");
            UsersTbl = FXFW.SqlDB.LoadDataTable("SELECT UserID, UserName FROM Users");
            LUEItems.Properties.DataSource = UsersTbl;
            LUEItems.Properties.DisplayMember = "UserName";
            LUEItems.Properties.ValueMember = "UserID";
        }
        private void LoadRoles(string Userid)
        {
            RolesTbl = new DataTable("Roles");
            RolesTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleID, RoleName, RoleDesc, (SELECT '1' AS Active FROM UserRoles WHERE (UserId = " + Userid + ") AND (RoleId = Roles.RoleID)) AS Active FROM Roles");
            CLSCRole.Items.Clear();
            foreach (DataRow row in RolesTbl.Rows)
            {
                if (row["Active"] == System.DBNull.Value)
                    CLSCRole.Items.Add(row["RoleID"].ToString(), row["RoleName"].ToString(), CheckState.Unchecked, true);
                else
                    CLSCRole.Items.Add(row["RoleID"].ToString(), row["RoleName"].ToString(), CheckState.Checked, true);
            }
        }
        public UserRolesFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Booking" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            groupControlSelect.Visible = Selecting;
            if (Inserting || Updateing || Deleting)
                groupControlUpdate.Visible = true;
            else
                groupControlUpdate.Visible = false;
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadData();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand("", Con);
                SqlTransaction trn = null;
                try
                {
                    Con.Open();
                    trn = Con.BeginTransaction();
                    Cmd.Transaction = trn;
                    Cmd.CommandText = string.Format("Delete From UserRoles Where UserId = {0}", LUEItems.EditValue);
                    Cmd.ExecuteNonQuery();
                    foreach (DataRow row in RolesTbl.Rows)
                    {
                        if (row["Active"].ToString() == "1")
                        {
                            Cmd.CommandText = String.Format("INSERT INTO UserRoles (UserId, RoleId) VALUES ({0}, {1})", LUEItems.EditValue, row["RoleID"].ToString());
                            Cmd.ExecuteNonQuery();
                        }
                    }
                    trn.Commit();
                    LoadRoles(LUEItems.EditValue.ToString());
                    Program.ShowMsg("تم التعديل ..", false, this);
                    Program.Logger.LogThis("تم التعديل ..", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    trn.Rollback();
                    MessageBox.Show(ex.Message);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
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