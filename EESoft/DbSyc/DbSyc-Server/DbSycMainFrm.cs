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
    public partial class DbSycMainFrm : Form
    {
        public DbSycMainFrm()
        {
            InitializeComponent();
        }
        private void DbSycMainFrm_Load(object sender, EventArgs e)
        {

        }
        private void NIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplition();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Visible = true;
            btnStart.Visible = false;
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                Program.Service.OnStart();
            });
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            Program.Service.OnStop();
            btnStop.Visible = false;
            btnStart.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplition();
        }
        private void DbSycMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case  CloseReason.UserClosing:
                case CloseReason.FormOwnerClosing:
                case CloseReason.MdiFormClosing:
                    this.Hide();
                    e.Cancel = true;
                    break;
            }
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsFrm frm = new OptionsFrm();
            frm.ShowDialog();
        }
        private void ExitApplition()
        {
            Program.Service.OnStop();
            Application.Exit();
        }
        public void LogMsg(string msg, bool IsError = false)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                int selectionstart = tbLog.TextLength;
                tbLog.AppendText(msg + Environment.NewLine);
                if (IsError)
                {
                    tbLog.SelectionStart = selectionstart;
                    tbLog.SelectionLength = tbLog.TextLength;
                    tbLog.SelectionColor = System.Drawing.Color.Red;
                }
                tbLog.ScrollToCaret();
            }));
        }

        
    }
}
