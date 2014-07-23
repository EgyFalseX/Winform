using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace FSPluginnamespace
{
    public partial class SroTimerFRM : Form
    {
        private Timer Tmr = new Timer();
        private bool StartSound = false;
        private int CountDown;

        public SroTimerFRM()
        {
            InitializeComponent();
            Tmr.Tick += new System.EventHandler(Tmr_Tick);
            Tmr.Interval = 1000;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartSound = !StartSound;
            CountDown = 0;
            if (StartSound == true)
            {
                LblCount.Text = Convert.ToInt16(TxtTimerInterval.Text).ToString();
                Tmr.Start();
                BtnStart.BackColor = Color.Red;
                BtnStart.ForeColor = Color.White;
                BtnStart.Text="Stop";
                
            } else {
                Tmr.Stop();
                LblCount.Text = "0";
                BtnStart.BackColor = Color.Lime;
                BtnStart.ForeColor = Color.Black;
                BtnStart.Text = "Start";
                this.Text = "Silkroad Skills Timer";
            }
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (CountDown != Convert.ToInt16(LblCount.Text))
            {
                CountDown += 1;
                this.Text = CountDown.ToString();
            }
            else
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
                }
            }

        private void TxtSp_TextChanged(object sender, EventArgs e)
        {
            if (TxtSp1.Text.Trim().Length > 0 && TxtSp2.Text.Trim().Length > 0)
            {
                try
                { LblResult.Text = (Convert.ToInt16(TxtSp2.Text) - Convert.ToInt16(TxtSp1.Text)).ToString(); }
                catch { LblResult.Text = "Error"; }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

     
        }
    }
