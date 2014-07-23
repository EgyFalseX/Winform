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
            if (TxtUserName.Text == string.Empty || TxtPassword.Text == string.Empty)
                return;
            if (Program.MC.LoadUserInfo(TxtUserName.Text, TxtPassword.Text))
            {
                SaveLoginTime();
                Logged = true;
                this.Close();
            }
            else
                Program.msg("خطـــاء في اسم المستخدم او كلمة السر", true, "None", this);
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
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
                cmd.CommandText = @"UPDATE Users SET LastActivityDate = CONVERT(DATETIME, GETDATE(), 20) WHERE UserID = " + FXFW.SqlDB.UserInfo.UserID;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
    }
}