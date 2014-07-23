using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using FunctionLib;

namespace DataCenter_Server
{
	public partial class UsersPrivilegesFrm
	{
		public UsersPrivilegesFrm()
		{
			InitializeComponent();
		}
		
        DataTable UserDT = null;
        DataTable PrivDT = null;
        DataTable SelectedPrivDT = null;
        private void LoadUsers()
        {
            UserDT = MCls.LoadDataTable("Select UsrID, UserName From Users Where Status = 0", "");
            CBUsers.DataSource = UserDT;
            CBUsers.DisplayMember = "UserName";
            CBUsers.ValueMember = "UsrID";
        }
        private void LoadPriv()
        {
            PrivDT = MCls.LoadDataTable("Select RullID, RullName From Rulls", "");
            LBAllprivileges.DataSource = PrivDT;
            LBAllprivileges.DisplayMember = "RullName";
            LBAllprivileges.ValueMember = "RullID";
        }
        public void UsersPrivilegesFrm_Load(Object sender, EventArgs e)
        {
            LoadUsers();
            LoadPriv();
            if (CBUsers.Items.Count == 0 || LBAllprivileges.Items.Count == 0)
            {
                MCls.msg("لم نجد سماحيات او مستخدمين", true, "", this);
                return;
            }
        }
        private void ReloadSelectedUserPrivilege()
		{
            if (CBUsers.SelectedIndex != -1)
                SelectedPrivDT = MCls.LoadDataTable("Select URID, RullID, (Select RullName From Rulls Where RullID = Users_Rulls.RullID) AS RullName From Users_Rulls Where UsrID = " + UserDT.Rows[CBUsers.SelectedIndex]["UsrID"], "");
            LBSelectedprivileges.DataSource = SelectedPrivDT;
            LBSelectedprivileges.DisplayMember = "RullName";
            LBSelectedprivileges.ValueMember = "URID";
		}
        public void CBUsers_SelectedIndexChanged(Object sender, EventArgs e)
        {
            ReloadSelectedUserPrivilege();
        }
        public void BtnAddSelected_Click(Object sender, EventArgs e)
        {
            if (LBAllprivileges.SelectedIndex == -1 || CBUsers.SelectedIndex == -1)
                return;
            if (MCls.LoadDataTable(string.Format("Select URID from Users_Rulls Where RullID = N'{0}' And UsrID = N'{1}'", PrivDT.Rows[LBAllprivileges.SelectedIndex]["RullID"], UserDT.Rows[CBUsers.SelectedIndex]["UsrID"]), "").Rows.Count > 0)
            {
                MCls.msg("موجود مسبقا", true, "", this);
                return;
            }
            using (SqlConnection con = new SqlConnection(MCls.SQLConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    con.Open();
                    cmd.CommandText = string.Format("Insert into Users_Rulls (URID, RullID, UsrID) VALUES ((SELECT ISNULL(MAX(URID) + 1, 1) FROM Users_Rulls AS NewID), N'{0}', N'{1}')", LBAllprivileges.SelectedValue, UserDT.Rows[CBUsers.SelectedIndex]["UsrID"]);
                    cmd.ExecuteNonQuery();
                    MCls.msg("تم الاضافه", false, "", this);
                    LoadPriv();
                    ReloadSelectedUserPrivilege();
                }
                catch (SqlException ex)
                {
                    MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                }
                con.Close();
            }
        }
        public void BtnRemoveSelected_Click(Object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex == -1 || CBUsers.SelectedIndex == -1)
                return;
            if (Interaction.MsgBox("هل انت متأكد", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
                return;
            using (SqlConnection con = new SqlConnection(MCls.SQLConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    con.Open();
                    cmd.CommandText = String.Format("Delete From Users_Rulls Where URID = '{0}'", SelectedPrivDT.Rows[LBSelectedprivileges.SelectedIndex]["URID"]);
                    cmd.ExecuteNonQuery();
                    MCls.msg("تم الحذف", false, "", this);
                    ReloadSelectedUserPrivilege();
                }
                catch (SqlException ex)
                {
                    MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                }
                con.Close();
            }
           
        }
        public void LBAllprivileges_DoubleClick(object sender, EventArgs e)
        {
            if (LBAllprivileges.SelectedIndex != -1)
                BtnAddSelected_Click(sender, e);
        }
        public void LBSelectedprivileges_DoubleClick(object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
                BtnRemoveSelected_Click(sender, e);
        }
        public void LBAllprivileges_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (LBAllprivileges.SelectedIndex != -1)
                BtnAddSelected.Enabled = true;
            else
                BtnAddSelected.Enabled = false;
        }
        public void LBSelectedprivileges_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (LBSelectedprivileges.SelectedIndex != -1)
                BtnRemoveSelected.Enabled = true;
            else
                BtnRemoveSelected.Enabled = false;
        }
        public void BtnClose_Click(Object sender, EventArgs e)
        {
            Close();
        }
	}
}
