using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace E_Club_Loader
{
    public partial class MainFrm : Form
    {
        #region -   Variables   -
        public int x;
        public int y;
        public bool fla;
        private Timer Tmr = new Timer();
        private int ScnHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private int _To = 0;
        public bool Reset_Falg;
        string ECCM = string.Empty;
        string ECAM = string.Empty;
        string ECEM = string.Empty;
        string ECMM = string.Empty;
        string ECRM = string.Empty;
        string ECSM = string.Empty;
        #endregion
        #region -   Functions   -
        public MainFrm()
        {
            InitializeComponent();
        }
        private void GetPathZ()
        {
            ECCM = MCls.GetRegValue(MCls.ECCM);
            ECAM = MCls.GetRegValue(MCls.ECAM);
            ECEM = MCls.GetRegValue(MCls.ECEM);
            ECMM = MCls.GetRegValue(MCls.ECMM);
            ECRM = MCls.GetRegValue(MCls.ECRM);
            ECSM = MCls.GetRegValue(MCls.ECSM);
            if (ECCM != string.Empty)
            {
                BtnAcc.Enabled = true;
                BtnAcc.BackColor = Color.DarkOrange;
            }
            if (ECAM != string.Empty)
            {
                BtnAtt.Enabled = true;
                BtnAtt.BackColor = Color.DarkOrange;
            }
            if (ECEM != string.Empty)
            {
                BtrnEmp.Enabled = true;
                BtrnEmp.BackColor = Color.DarkOrange;
            }
            if (ECMM != string.Empty)
            {
                BtnMem.Enabled = true;
                BtnMem.BackColor = Color.DarkOrange;
            }
            if (ECRM != string.Empty)
            {
                BtnStore.Enabled = true;
                BtnStore.BackColor = Color.DarkOrange;
            }
            if (ECSM != string.Empty)
            {
                BtnMemAcc.Enabled = true;
                BtnMemAcc.BackColor = Color.DarkOrange;
            }
        }
        #endregion
        #region -   Event Handlers  -
        private void MainFrm_Load(object sender, EventArgs e)
        {
            LbRight.Text = DateTime.Today.Day + "/   " + DateTime.Today.Month + "/   " + DateTime.Today.Year;
            this.TopMost = false;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width), Screen.PrimaryScreen.WorkingArea.Height);
            Tmr.Interval = 10;
            Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            Tmr.Start();
            GetPathZ();
        }
        private void Tmr_Tick(object sender, EventArgs e)
        {
            _To += Tmr.Interval;
            if (_To < this.Size.Height)
                this.Location = new Point(this.Location.X, ScnHeight - _To);
            else
            {
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width), (Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height));
                this.TopMost = true;
                Tmr.Stop();
            }
        }
        private void MainFrm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            fla = true;
        }
        private void MainFrm_MouseUp(object sender, MouseEventArgs e)
        {
            fla = false;
        }
        private void MainFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (fla == true)
                this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
        }
        private void BtnAcc_Click(object sender, EventArgs e)
        {
            if (File.Exists(ECCM))
                Process.Start(ECCM);
        }
        private void BtnAtt_Click(object sender, EventArgs e)
        {
            if (File.Exists(ECAM))
                Process.Start(ECAM);
        }
        private void BtrnEmp_Click(object sender, EventArgs e)
        {
            if (File.Exists(ECEM))
                Process.Start(ECEM);
        }
        private void BtnMem_Click(object sender, EventArgs e)
        {
            if (File.Exists(ECMM))
                Process.Start(ECMM);
        }
        private void BtnStore_Click(object sender, EventArgs e)
        {
            if (File.Exists(ECRM))
                Process.Start(ECRM);
        }
        private void BtnMemAcc_Click(object sender, EventArgs e)
        {
            if (File.Exists(ECSM))
                Process.Start(ECSM);
        }
        private void Btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
