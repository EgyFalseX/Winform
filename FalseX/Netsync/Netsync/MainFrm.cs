using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Netsync
{
    public partial class MainFrm : Form
    {

        public MainFrm()
        {
            InitializeComponent();
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            cbAutoStart.Checked = config.StartUp;
            tbPort.Text = Properties.Settings.Default.Port.ToString();
        }
        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated && value)
            {
                base.CreateHandle();
                if (config.StartUp)
                {
                    value = false;
                    btnStart_Click(btnStart, EventArgs.Empty);
                }
            }
            base.SetVisibleCore(value);
        }
        private void tbPort_TextChanged(object sender, EventArgs e)
        {
            int port = 0;
            if (int.TryParse(tbPort.Text, out port))
            {
                Properties.Settings.Default.Port = port;
                Properties.Settings.Default.Save();
            }
        }
        private void cbAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            config.StartUp = cbAutoStart.Checked;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(Program.ns.OnStart).Start();
            btnStart.Enabled = false;
            btnEnd.Enabled = true;

            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;

        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Program.ns.OnStop();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;

            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStart_Click(btnStart, EventArgs.Empty);
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEnd_Click(btnEnd, EventArgs.Empty);
        }
        private void exitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }
        private void contextMenuStripNetsync_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
        }
        private void notifyIconNetsync_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
        }
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Application Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            if (btnEnd.Enabled)
                btnEnd_Click(btnEnd, EventArgs.Empty);
        }
       
    }
}
