using System.Diagnostics;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Net.Sockets;
using System.Text;


namespace DataCenter_Client
{
	public sealed partial class SplashScreen
	{
		public SplashScreen()
		{
			InitializeComponent();
		}
		private Timer TIMR = new Timer(); //this timer start the operations
		private Timer FadTmr = new Timer(); //this is the fading timer
		private string ErrorProvider; //this is an intermediate variable between the function and the sender
		private int Int1; //Free int for any loop
		delegate void SetTextCallback(string Args); //its intermediate variable help me to send string between threads
        public void SplashScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Strings.Chr(Convert.ToInt32(Keys.Enter)))
                Tmr_Tick(sender, e);
        }
        public void SplashScreen_Load(object sender, EventArgs e)
        {
            TIMR.Interval = 2000;
            TIMR.Tick += Tmr_Tick;
            TIMR.Enabled = true;
            FadTmr.Interval = 10;
            FadTmr.Tick += FadTmr_tick;
            FadTmr.Enabled = true;
            ProgressBarLoading.Maximum = 2;
            ProgressBarLoading.Value = 1;
            //Application title
            if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title != "")
                ApplicationTitle.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title;
            else
                ApplicationTitle.Text = Path.GetFileNameWithoutExtension((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.AssemblyName);
            Version.Text = String.Format(Version.Text, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Major, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Minor);
            Copyright.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Copyright;
        }
        private void Tmr_Tick(object sender, EventArgs e)
        {
            TIMR.Enabled = false;
            FadTmr.Enabled = false;
            ErrorProvider = null;
            MainModule.FrmMainWindow = new MainWindowFrm();
            MainModule.FrmMainWindow.Show();
            Close();
        }
		private void FadTmr_tick(object sender, EventArgs e)
		{
			if (Opacity < 1)
				Opacity += 0.009;
			else
			{
				Opacity = 1;
				FadTmr.Enabled = false;
			}
		}
		private void SetValue(string Args)
		{
			if (Lbl.InvokeRequired)
			{
                SetTextCallback d = SetValue;
				Invoke(d, new object[] {Args});
			}
			else
			{
				Lbl.Text = Args;
			}
		}
	}
}
