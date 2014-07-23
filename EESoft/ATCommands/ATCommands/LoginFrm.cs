using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ATCommands
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        public bool Logged = false;
        public LoginFrm()
        {
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
            //MyCL.UserInfo = new MyCL.UserInfoStruct { UserID = "1", UserName = "Admin" };
            //Close();
            //return;
            ///////////////////////////////////////////////////////////////////////////////
            if (Program.MCL.LoadUserInfo(TxtUserName.Text.Trim(), TxtPassword.Text.Trim()))
            {
                //SaveLoginTime();
                Logged = true;
                //MyCL.ShowMsg("تم الدخول..  مرحبا " + TxtUserName.Text.Trim(), false, this);
                Close();
            }
            else
                MessageBox.Show("خطاء في اسم المستخدم او كلمة المرور", "خطـــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void SaveLoginTime()
        {
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                //GETDATE()
                con.Open();
                cmd.CommandText = @"UPDATE Users SET LastActivityDate = Now() WHERE UserID = " + MyCL.UserInfo.UserID;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(MyCL.CheckExp(ex), "خطـــــــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

    }
}