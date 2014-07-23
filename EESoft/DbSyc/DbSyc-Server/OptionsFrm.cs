using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DbSyc_Server
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
            int port = 0;
            try
            {
                port = Convert.ToInt32(tbPort.Text);
                Properties.Settings.Default.Port = port;
                Properties.Settings.Default.Save();
                Logging.Log.LogMessage("Options Saved ...");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logging.Log.LogMessage(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
