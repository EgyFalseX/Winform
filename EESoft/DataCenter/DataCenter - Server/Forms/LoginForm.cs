using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;

namespace DataCenter_Server
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
            if (MainModule.FunLib.SALogin(UsernameTextBox.Text.Trim(), PasswordTextBox.Text.Trim()) == true)
            {
                //MsgBox("Login sccuessfull")
                string DataChecked = "";
                if (MainModule.FunLib.GetRegValue(ref DataChecked, FunctionLib.DataCenterServerLib.RegKeyValues.DataChacked) == true)
                {
                    MainModule.FrmMainForm.Show();
                    CExit = true;
                    Close();
                }
                else
                {
                    CExit = true;
                    MainModule.MsgBox_("لم يتم فحص البيانات", 84, 23, false, this);
                    MainModule.FrmFilesChecker = new FilesCheckerFrm();
                    MainModule.FrmFilesChecker.Show();
                    Close();
                }
            }
            else
                MainModule.MsgBox_("خطاء في الاسم او كلمة السر", 84, 23, false, this);
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
