using System.Drawing;
using System.Windows.Forms;
using System;

namespace DataCenter_Server
{
	public partial class MSGBOXFrm
	{
		#region Form Auto Move Subroutain
		public short x;
		public short y;
		public bool fla;
        public void MSGBOXFrm_MouseDown(object sender, MouseEventArgs e)
        {
            x = (short)e.X;
            y = (short)e.Y;
            fla = true;
        }
        public void MSGBOXFrm_MouseUp(object sender, MouseEventArgs e)
        {
            fla = false;
        }
        public void MSGBOXFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (fla == true)
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
            else
                Visible = true;

        }
		#endregion
		private Timer FadTMR = new Timer();
		private string MSG;
		private Timer LBLTMR = new Timer();
		public MSGBOXFrm(string ShowedMessage)
		{
			MSG = ShowedMessage;
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			// Add any initialization after the InitializeComponent() call.
		}
        public void MSGBOXFrm_Load(Object sender, EventArgs e)
        {
            LBLMSG.Text = MSG;
            FadTMR.Interval = 30;
            FadTMR.Tick += FadTmr_tick;
            LBLTMR.Tick += LBLTMR_Tick;
            FadTMR.Enabled = true;
            LBLTMR.Interval = 1500;
            //LBLTMR.Enabled = True
        }
		private void FadTmr_tick(object sender, EventArgs e)
		{
			if (Opacity < 1)
				Opacity += 0.029;
			else
			{
				Opacity = 1;
				FadTMR.Enabled = false;
			}
		}
		private void LBLTMR_Tick(object sender, EventArgs e)
		{
			if (LBLMSG.Visible == true)
				LBLMSG.Visible = false;
			else
				LBLMSG.Visible = true;
		}
        private void BtnOk_Click(Object sender, EventArgs e)
        {
            LBLTMR.Enabled = false;
            Close();
        }
	}
}
