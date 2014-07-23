using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace FSPluginnamespace
{
    public partial class TravianMonitorFrm : Form
    {
        public TravianMonitorFrm()
        {
            InitializeComponent();
        }
        
        bool Char1, Char2, Char3, Char4, Char5, Char6, Char7, Char8, Char9;
        string DTPTime,RightNow;
        string WarningSoundPath;
        SoundPlayer WarningSound;
        
        private void TravianMonitorFrm_Load(object sender, EventArgs e)
        {
            Tmr.Start();
            if (System.IO.File.Exists(Application.StartupPath + @"\Plugins\WarningSound.wav"))
            {
                WarningSoundPath = Application.StartupPath + @"\Plugins\WarningSound.wav";
            }
            else
            {
                WarningSoundPath = @"c:\Windows\Media\chimes.wav";
            }
            WarningSound = new SoundPlayer(WarningSoundPath);
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            RightNow = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            if (Char1)
            { 
                DTPTime = DTP1.Value.Hour.ToString() + ":" + DTP1.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl1.BackColor = Color.Red;
                    Btn1_Click(sender, e);
                }
                else
                {
                    Lbl1.Text = DTP1.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
            }
            if (Char2)
            {
                DTPTime = DTP2.Value.Hour.ToString() + ":" + DTP2.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl2.BackColor = Color.Red;
                    Btn2_Click(sender, e);
                }
                else
                {
                    Lbl2.Text = DTP2.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
            }
            if (Char3)
            {
                DTPTime = DTP3.Value.Hour.ToString() + ":" + DTP3.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl3.BackColor = Color.Red;
                    Btn3_Click(sender, e);
                }
                else
                {
                    Lbl3.Text = DTP3.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
            }
            if (Char4)
            {
                DTPTime = DTP4.Value.Hour.ToString() + ":" + DTP4.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl4.BackColor = Color.Red;
                    Btn4_Click(sender, e);
                }
                else
                {
                    Lbl4.Text = DTP4.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
            }
            if (Char5)
            {
                DTPTime = DTP5.Value.Hour.ToString() + ":" + DTP5.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl5.BackColor = Color.Red;
                    Btn5_Click(sender, e);
                }
                else
                {
                    Lbl5.Text = DTP5.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
            }
            if (Char6)
            {
                DTPTime = DTP6.Value.Hour.ToString() + ":" + DTP6.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl6.BackColor = Color.Red;
                    Btn6_Click(sender, e);
                }
                else
                {
                    Lbl6.Text = DTP6.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
            }
            if (Char7)
            {
                DTPTime = DTP7.Value.Hour.ToString() + ":" + DTP7.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl7.BackColor = Color.Red;
                    Btn7_Click(sender, e);
                }
                else
                {
                    Lbl7.Text = DTP7.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
            }
            if (Char8)
            {
                DTPTime = DTP8.Value.Hour.ToString() + ":" + DTP8.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl8.BackColor = Color.Red;
                    Btn8_Click(sender, e);
                }
                else
                {
                    Lbl8.Text = DTP8.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
            }
            if (Char9)
            {
                DTPTime = DTP9.Value.Hour.ToString() + ":" + DTP9.Value.Minute.ToString();
                if (DTPTime == RightNow)
                {
                    WarningSound.Play();
                    Pnl9.BackColor = Color.Red;
                    Btn9_Click(sender, e);
                }
                else
                {
                    Lbl9.Text = DTP9.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).ToString().Substring(0, 8);
                }
                
            }
        }
        
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "Start")
            {
                Btn1.Text = "End";
                Char1 = true;
                Pnl1.BackColor = SystemColors.Control;
            }
            else
            {
                Btn1.Text = "Start";
                Char1 = false;
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Btn2.Text == "Start")
            {
                Btn2.Text = "End";
                Char2 = true;
                Pnl2.BackColor = SystemColors.Control;
            }
            else
            {
                Btn2.Text = "Start";
                Char2 = false;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Btn3.Text == "Start")
            {
                Btn3.Text = "End";
                Char3 = true;
                Pnl3.BackColor = SystemColors.Control;
            }
            else
            {
                Btn3.Text = "Start";
                Char3 = false;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (Btn4.Text == "Start")
            {
                Btn4.Text = "End";
                Char4 = true;
                Pnl4.BackColor = SystemColors.Control;
            }
            else
            {
                Btn4.Text = "Start";
                Char4 = false;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (Btn5.Text == "Start")
            {
                Btn5.Text = "End";
                Char5 = true;
                Pnl5.BackColor = SystemColors.Control;
            }
            else
            {
                Btn5.Text = "Start";
                Char5 = false;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (Btn6.Text == "Start")
            {
                Btn6.Text = "End";
                Char6 = true;
                Pnl6.BackColor = SystemColors.Control;
            }
            else
            {
                Btn6.Text = "Start";
                Char6 = false;
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (Btn7.Text == "Start")
            {
                Btn7.Text = "End";
                Char7 = true;
                Pnl7.BackColor = SystemColors.Control;
            }
            else
            {
                Btn7.Text = "Start";
                Char7 = false;
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (Btn8.Text == "Start")
            {
                Btn8.Text = "End";
                Char8 = true;
                Pnl8.BackColor = SystemColors.Control;
            }
            else
            {
                Btn8.Text = "Start";
                Char8 = false;
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (Btn9.Text == "Start")
            {
                Btn9.Text = "End";
                Char9 = true;
                Pnl9.BackColor = SystemColors.Control;
            }
            else
            {
                Btn9.Text = "Start";
                Char9 = false;
            }
        }


        private void BtnI1_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 0;
            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP1.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[0].TaskMins);
            }
        }

        private void BtnI2_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 1;
            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP2.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[1].TaskMins);
            }
        }

        private void BtnI3_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 2;
            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP3.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[2].TaskMins);
            }
        }

        private void BtnI4_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 3;

            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP4.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[3].TaskMins);
            }
        }

        private void BtnI5_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 4;
            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP5.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[4].TaskMins);
            }
        }

        private void BtnI6_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 5;
            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP6.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[5].TaskMins);
            }
        }

        private void BtnI7_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 6;
            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP7.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[6].TaskMins);
            }
        }

        private void BtnI8_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 7;
            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP8.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[7].TaskMins);
            }
        }

        private void BtnI9_Click(object sender, EventArgs e)
        {
            ContainFrm FrmContain = new ContainFrm();
            FrmContain.AccIndex = 8;
            if (FrmContain.ShowDialog() == DialogResult.OK)
            {
                DTP9.Value = DateTime.Now.AddMinutes(FSPluginClass.Elements[8].TaskMins);
            }
        }

    }
}
