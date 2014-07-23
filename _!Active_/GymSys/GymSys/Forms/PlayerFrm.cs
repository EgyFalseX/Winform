using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymSys
{
    public partial class PlayerFrm : Form
    {
        public PlayerFrm()
        {
            InitializeComponent();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim().Length > 0)
            {
                BtnAdd.Enabled = true;
            }
                else
            {
                BtnAdd.Enabled = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.EXECMD("Insert INTO Players (PlayerName,PlayerPhone,PlayerMobile,PlayerAddress,PlayerSIN) Values ('" + TxtName.Text.Trim() + "','" + TxtPhone.Text.Trim() + "','" + TxtMob.Text.Trim() + "','" + TxtAddress.Text.Trim() + "','" + TxtSIN.Text.Trim() + "')"));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
