using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	public sealed partial class SplashScreen
	{
		public SplashScreen()
		{
			InitializeComponent();
		}
		private Timer TMR = new Timer();
		private Timer FadTmr = new Timer();
		public void SplashScreen_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == Strings.Chr(System.Convert.ToInt32(Keys.Enter)))
			{
				Tmr_Tick(sender, e);
			}
		}
		public void SplashScreen_Load(object sender, System.EventArgs e)
		{
			//Set up the dialog text at runtime according to the application's assembly information.
			TMR.Interval = 4000;
			TMR.Tick += new System.EventHandler(Tmr_Tick);
			TMR.Enabled = true;
			FadTmr.Interval = 10;
			FadTmr.Tick += new System.EventHandler(FadTmr_tick);
			FadTmr.Enabled = true;
			//  properties dialog (under the "Project" menu).
			
			//Application title
			if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title != "")
			{
				ApplicationTitle.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title;
			}
			else
			{
				//If the application title is missing, use the application name, without the extension
				ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.AssemblyName);
			}
			
			//Format the version information using the text set into the Version control at design time as the
			//  formatting string.  This allows for effective localization if desired.
			//  Build and revision information could be included by using the following code and changing the
			//  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
			//  String.Format() in Help for more information.
			//
			//    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
			
			Version.Text = System.String.Format(Version.Text, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Major, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Minor);
			
			//Copyright info
			Copyright.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Copyright;
			//Copyright.Text &= vbNewLine & "Mostafa Nouh Abdo" & vbNewLine & "Mohamed Aly Omer"
		}
		public void Tmr_Tick(object sender, EventArgs e)
		{
			//FrmLogin.Show()
			//FrmMainForm.Show()
			TMR.Enabled = false;
			FadTmr.Enabled = false;
			this.Close();
		}
		private void FadTmr_tick(object sender, EventArgs e)
		{
			if (this.Opacity < 1)
			{
				this.Opacity += 0.009;
			}
			else
			{
				this.Opacity = 1;
				FadTmr.Enabled = false;
			}
		}
		
	}
	
}
