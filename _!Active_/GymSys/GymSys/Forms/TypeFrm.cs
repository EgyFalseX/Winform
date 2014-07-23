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
    public partial class TypeFrm : Form
    {
        public TypeFrm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim().Length == 0 || TxtDays.Text.Trim().Length == 0 || TxtCost.Text.Trim().Length == 0)
            {
                MessageBox.Show("خطـــــأ");
                return;
            }
            MessageBox.Show(Program.EXECMD("Insert INTO [Types] (TypeName,TypeCost,TypeDays) Values ('" + TxtName.Text.Trim() + "','" + TxtCost.Text.Trim() + "','" + TxtDays.Text.Trim() + "')"));
            TxtCost.Clear();
            TxtName.Clear();
            TxtDays.Clear();
            TxtName.Focus();
        }
    }
}
