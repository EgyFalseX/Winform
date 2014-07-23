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
    public partial class SupplierFrm : Form
    {
        public PlayerFrm FrmPlayer;
        public TypeFrm FrmType;
        public JoinFrm FrmJoin;
        public PayFrm FrmPay;


        public SupplierFrm()
        {
            InitializeComponent();
        }

        private void Btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void BtnPlayers_Click(object sender, EventArgs e)
        {

            if (FrmPlayer != null)
            {
                FrmPlayer.Close();
                FrmPlayer = new PlayerFrm();
                FrmPlayer.Show();
            }
            else
            {
                FrmPlayer = new PlayerFrm();
                FrmPlayer.Show();
            }

        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            if (FrmType != null)
            {
                FrmType.Close();
                FrmType = new TypeFrm();
                FrmType.Show();
            }
            else
            {
                FrmType = new TypeFrm();
                FrmType.Show();
            }
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            if (FrmJoin != null)
            {
                FrmJoin.Close();
                FrmJoin = new JoinFrm();
                FrmJoin.Show();
            }
            else
            {
                FrmJoin = new JoinFrm();
                FrmJoin.Show();
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (FrmPay != null)
            {
                FrmPay.Close();
                FrmPay = new PayFrm();
                FrmPay.Show();
            }
            else
            {
                FrmPay = new PayFrm();
                FrmPay.Show();
            }
        }

    }
}
