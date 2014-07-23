using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Fellowship.DataSources;

namespace Fellowship
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        public bool Logged = false;
        DSFellowship.UsersDataTable Tbl = new DSFellowship.UsersDataTable();
        DataSources.DSFellowshipTableAdapters.UsersTableAdapter DA = new DataSources.DSFellowshipTableAdapters.UsersTableAdapter();
        
        public LoginFrm()
        {
            //DA.Connection.ConnectionString = FXFW.SqlDB.SqlConStr;
            InitializeComponent();
        }
        private void text_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Trim().Length > 0 && TxtPassword.Text.Trim().Length > 0)
                BtnEnter.Enabled = true;
            else
                BtnEnter.Enabled = false;
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Tbl = DA.GetDataBy(TxtUserName.Text, TxtPassword.Text);
            if (Tbl.Rows.Count == 0)
            {
                MessageBox.Show("خطاء في اسم المستخدم او كلمة المرور", "خطـــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FXFW.SqlDB.UserInfo = new FXFW.SqlDB.UserInfoStruct();
            FXFW.SqlDB.UserInfo.UserID = Tbl.Rows[0]["UserID"].ToString();
            FXFW.SqlDB.UserInfo.UserName = Tbl.Rows[0]["UserName"].ToString();
            Tbl.Rows[0]["LastActivityDate"] = DateTime.Now;
            Tbl.Rows[0].AcceptChanges();
            DA.Update(Tbl.Rows[0]);

            SetAdminInfo();
  
            Logged = true;
            Close();
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void SaveLoginTime()
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                //GETDATE()
                con.Open();
                cmd.CommandText = @"UPDATE Users SET LastActivityDate = GETDATE() WHERE UserID = " + FXFW.SqlDB.UserInfo.UserID;
                cmd.ExecuteNonQuery();
                Program.Logger.LogThis("تم حفظ بيانات الدخول", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطـــــــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        private void SetAdminInfo()
        {
            Program.UserInfo.UserId = Convert.ToInt32(FXFW.SqlDB.UserInfo.UserID);
            Program.UserInfo.UserName = FXFW.SqlDB.UserInfo.UserName;
            Program.UserInfo.UserRoles = new List<int>();
            DataSources.DSFellowshipTableAdapters.UserRolesTableAdapter adp = new DataSources.DSFellowshipTableAdapters.UserRolesTableAdapter();
            foreach (DataSources.DSFellowship.UserRolesRow item in adp.GetDataByUserId(Program.UserInfo.UserId).Rows)
            {
                Program.UserInfo.UserRoles.Add(item.RoleId);
                if (item.RoleId == 1)
                    Program.UserInfo.IsAdmin = true;
            }
        }
    }
}