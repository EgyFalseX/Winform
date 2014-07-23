using System.Diagnostics;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DataCenter_Client
{
	public partial class LoginForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		private bool CExit;
        public void OK_Click(Object sender, EventArgs e)
        {
            if (MainModule.FunLib.ULogin(UsernameTextBox.Text.Trim(), PasswordTextBox.Text.Trim()) == true)
            {
                //Loading User privilagesIDs
                MainModule.FunLib.GetUserPrivilages();
                //MsgBox("Login sccuessfull")
                MainModule.SC.Show();
                CExit = true;
                Close();
            }
            else
            {
                MainModule.MsgBox_("خطاء في اسم المستخدم او كلمة السر", 84, 23, false, this);
            }
        }
        public void Cancel_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CExit == false)
                Application.Exit();
        }
        public void Btnresetconnection_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
                return;
            MainModule.FunLib.ResetConnection();
            Application.Restart();
            Process.GetCurrentProcess().Kill();
        }
	}
}
