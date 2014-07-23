﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Student
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
            //FXFW.SqlDB.UserInfo = new FXFW.SqlDB.UserInfoStruct { UserID = "1", UserName = "Admin" };
            //Close();
            //return;
            ///////////////////////////////////////////////////////////////////////////////
            if (Program.MCL.LoadUserInfo(TxtUserName.Text.Trim(), TxtPassword.Text.Trim()))
            {
                SaveLoginTime();
                Logged = true;
                //Program.ShowMsg("تم الدخول..  مرحبا " + TxtUserName.Text.Trim(), false, this);
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
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                //GETDATE()
                con.Open();
                cmd.CommandText = @"UPDATE Users SET LastActivityDate = GETDATE() WHERE UserID = " + FXFW.SqlDB.UserInfo.UserID;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطـــــــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}