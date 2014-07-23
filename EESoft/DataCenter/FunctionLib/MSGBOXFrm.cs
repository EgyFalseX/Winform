using System;
using System.Drawing;
using System.Windows.Forms;

namespace FunctionLib
{
    public partial class MSGBOXFrm : Form
    {
        #region -   Form Auto Move Subroutain   -
        public Int16 x = 0;
        public Int16 y = 0;
        public bool flg;
        private void MSGBOXFrm_MouseDown(object sender, MouseEventArgs e)
        {
            x = (Int16)e.X;
            y = (Int16)e.Y;
            flg = true;
        }
        private void MSGBOXFrm_MouseUp(object sender, MouseEventArgs e)
        {
            flg = false;
        }
        private void MSGBOXFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (flg)
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
            else
                Visible = true;
        }
        #endregion

        private Timer FadTMR = new Timer();
        private string MSG = string.Empty;
        private Timer LBLTMR = new Timer();

        public MSGBOXFrm(string ShowedMessage, bool ShowErrorNo, string ErrorNo)
        {
            InitializeComponent();

            MSG = ShowedMessage;
            PnlErrorNo.Visible = ShowErrorNo;
            LblErrorNo.Text = ErrorNo;
            if (ShowErrorNo)
            {
                TxtMSG.ForeColor = Color.Red;
                pictureBoxIcon.Image = global::FunctionLib.Properties.Resources.MSGBOX_Error;
            }
            else
            {
                TxtMSG.ForeColor = Color.Green;
                pictureBoxIcon.Image = global::FunctionLib.Properties.Resources.MSGBOX_Info;
            }
        }
        private void MSGBOXFrm_Load(object sender, EventArgs e)
        {
            TxtMSG.Text = MSG;
            FadTMR.Interval = 30;
            FadTMR.Tick += FadTmr_tick;
            LBLTMR.Tick += LBLTMR_Tick;
            FadTMR.Enabled = true;
            LBLTMR.Interval = 1500;
        }
        private void FadTmr_tick(object sender, EventArgs e)
        {
            try
            {
                if (Opacity < 1)
                Opacity += 0.029;
                else
                {
                    Opacity = 1;
                    FadTMR.Enabled = false;
                }
            }
            catch (Exception)
            {
                Opacity = 1;
                FadTMR.Enabled = false;
            }
            
        }
        private void LBLTMR_Tick(object sender, EventArgs e)
        {
            if (TxtMSG.Visible == true)
                TxtMSG.Visible = false;
            else
                TxtMSG.Visible = true;
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            LBLTMR.Enabled = false;
            Close();
        }
    }
}