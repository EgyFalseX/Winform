using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace E_Club_Mem_Manager
{
    public partial class LoginFrm : XtraForm
    {
        bool success = false;
        public LoginFrm()
        {
            InitializeComponent();
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (Program.MC.LoadUserInfo(TxtuserName.Text, TxtuserPassword.Text))// Load User Information -- Temp --
            {
                success = true;
                Close();
            }
            else
                MCls.msg("خطاء في اسم المستخدم و كلمة المرور", true, "", this);
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (success == false)
                Application.Exit();
        }
    }
}