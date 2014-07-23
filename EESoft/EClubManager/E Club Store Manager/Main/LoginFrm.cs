using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace E_Club_Store_Manager
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Program.MC.LoadUserInfo();// Load User Information -- Temp --
            this.Close();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }
    }
}