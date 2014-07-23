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
    public partial class PayFrm : Form
    {
        DataTable Playez = new DataTable();
        //DataTable JoinID = new DataTable();
        public PayFrm()
        {
            InitializeComponent();
        }

        private void PayFrm_Load(object sender, EventArgs e)
        {
            Playez = Program.CreatTable("Select PlayerID,PlayerName From Players");
            CBPlayer.DisplayMember = "PlayerName"; CBPlayer.ValueMember = "PlayerID";
            CBPlayer.DataSource = Playez;
            if (CBPlayer.Items.Count == 0)
            { MessageBox.Show("لا يوجد عمــــلاء"); }
            else
            { CBPlayer.SelectedIndex = 0; }
        }

        private void TxtCost_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(TxtCost.Text) > int.Parse(LblRemaining.Text))
            {
                TxtCost.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CBPlayer.SelectedIndex == -1)
            {
                MessageBox.Show("خطـــــأ");
                return;
            }
            ///////////////////////

        }

        private void CBPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBPlayer.SelectedIndex != -1)
            {

                MessageBox.Show(CBPlayer.SelectedValue.ToString());
                DataTable JoinID = new DataTable();
                JoinID = Program.CreatTable("Select JoiningID,TypeID From Joining Where PlayerID = " + CBPlayer.SelectedValue.ToString() + " ORDER BY StartDate DESC");
                if (JoinID.Rows.Count == 0)
                {
                    MessageBox.Show("العميــل غير مشترك");
                    LblRemaining.Text = "0";
                    this.Close();
                }
                int Payed;
                Payed = int.Parse(Program.ExecuteScalar("SELECT SUM(Amount) AS Pay FROM Payments WHERE (JoiningID = " + CBPlayer.SelectedValue.ToString() + ")"));
                //SELECT TypeCost FROM Types Where TypeID = 
                LblRemaining.Text = (int.Parse(Program.ExecuteScalar("SELECT TypeCost FROM Types Where TypeID = " + CBPlayer.SelectedValue.ToString())) - int.Parse(JoinID.Rows[0][0].ToString())).ToString();
            }
        }
    }
}
