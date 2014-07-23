using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using FunctionLib;

namespace DataCenter_Server
{
	public partial class PrivilegesFrm
	{
		public PrivilegesFrm()
		{
			InitializeComponent();
		}
		//private string ResultErrors = "";
		//private int Int1;
		private Timer ActionTMR = new Timer();
        private void LoadPriv()
        {
            DataTable dt = MCls.LoadDataTable("SELECT RullID, RullName FROM Rulls", "");
            LBPrivileges.DataSource = dt;
            LBPrivileges.DisplayMember = "RullName";
            LBPrivileges.ValueMember = "RullID";
        }
		
		private void ActionTMR_Tick(object sender, EventArgs e)
		{
			LblAction.Text = "No Action";
			LblAction.ForeColor = Color.Black;
		}
        public void PrivilegesFrm_Load(Object sender, EventArgs e)
        {
            LoadPriv();
        }
        public void TxtNewPriv_TextChanged(Object sender, EventArgs e)
        {
            if (TxtNewPriv.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        public void LBPrivileges_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (LBPrivileges.SelectedIndex != -1)
            {
                BtnRemove.Enabled = true;
                TxtUpdate.ReadOnly = false;
                TxtUpdate.Text = ((DataTable)LBPrivileges.DataSource).Rows[LBPrivileges.SelectedIndex]["RullName"].ToString();
            }
            else
            {
                TxtUpdate.Clear();
                TxtUpdate.ReadOnly = true;
                BtnRemove.Enabled = false;
            }
        }
        public void BtnRemove_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
                return;
            using (SqlConnection con = new SqlConnection(MCls.SQLConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = "Delete From Rulls Where RullID = " + LBPrivileges.SelectedValue;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MCls.msg("تم الحذف", false, "", this);
                    LoadPriv();
                }
                catch (SqlException ex)
                {
                    MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                }
                con.Close();
            }
        }
        public void TxtUpdate_TextChanged(Object sender, EventArgs e)
        {
            if (TxtUpdate.Text.Trim().Length > 0)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        public void BtnClose_Click(Object sender, EventArgs e)
        {
            Close();
        }
        public void BtnAdd_Click(Object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(MCls.SQLConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format("Insert into Rulls (RullID, RullName) VALUES ((SELECT ISNULL(MAX(RullID) + 1, 1) FROM Rulls AS NewID), N'{0}')", TxtNewPriv.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MCls.msg("تم الاضافه", false, "", this);
                    LoadPriv();
                }
                catch (SqlException ex)
                {
                    MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                }
                con.Close();
            }
        }
        public void BtnUpdate_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.No)
                return;
            using (SqlConnection con = new SqlConnection(MCls.SQLConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format("Update Rulls Set RullName = N'{0}' Where RullID = {1}", TxtUpdate.Text.Trim(), LBPrivileges.SelectedValue);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MCls.msg("تم التعديل", false, "", this);
                    LoadPriv();
                }
                catch (SqlException ex)
                {
                    MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                }
                con.Close();
            }
        }
	}
}
