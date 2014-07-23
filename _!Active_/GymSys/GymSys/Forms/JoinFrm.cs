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
    public partial class JoinFrm : Form
    {
        DataTable Playez = new DataTable();
        DataTable Typez = new DataTable();
        public JoinFrm()
        {
            InitializeComponent();
        }

        private void JoinFrm_Load(object sender, EventArgs e)
        {
            Playez = Program.CreatTable("Select PlayerID,PlayerName From Players");
            CBPlayer.DataSource = Playez;
            CBPlayer.DisplayMember = "PlayerName"; CBPlayer.ValueMember = "PlayerID";
            Typez = Program.CreatTable("Select TypeID,TypeName,TypeCost,TypeDays From Types");
            CBType.DataSource = Typez;
            CBType.DisplayMember = "TypeName"; CBType.ValueMember = "TypeID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int EffectedID = 0;
            Program.EXECMD("Insert INTO Joining (PlayerID,TypeID,StartDate) Values ('" + CBPlayer.SelectedValue.ToString() + "', '" + CBType.SelectedValue.ToString() + "', #" + DTP.Value.ToShortDateString() + "#)",ref EffectedID);
            if (EffectedID <= 0)
            {
                MessageBox.Show("خطـــــأ");
                return ;
            }
            MessageBox.Show(Program.EXECMD("Insert INTO Payments (JoiningID,PayDate,Amount) Values ('" + EffectedID + "', #" + DTP.Value.ToShortDateString() + "#, '" + int.Parse(TxtCost.Text) + "')"));
        }

        private void CBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBType.SelectedIndex > -1)
            {
                TxtCost.Text = Typez.Rows[CBType.SelectedIndex][2].ToString();
                LblDays.Text = Typez.Rows[CBType.SelectedIndex][3].ToString();
            }
            else
            {
                TxtCost.Text = "0";
                LblDays.Text = "0";
            }
        }
    }
}
