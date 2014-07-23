using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DbSyc_Client
{
    public partial class OptionsFrm : Form
    {
        public OptionsFrm()
        {
            InitializeComponent();
        }
        private void OptionsFrm_Load(object sender, EventArgs e)
        {
            tbPort.Text = Properties.Settings.Default.Port.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Port = Convert.ToInt32(tbPort.Text);
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
