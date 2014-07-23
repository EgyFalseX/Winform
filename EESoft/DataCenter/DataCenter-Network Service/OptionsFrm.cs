using System.Windows.Forms;
using System;
using Microsoft.Win32;

namespace DataCenterNetworkService
{
	public partial class OptionsFrm
	{
		public OptionsFrm()
		{
			InitializeComponent();
		}
		private enum RegAutoStartKeyValues
		{
			GeneralPort,
			DeletedFilesPath,
			DataCenterAutoStart
		}
        public void OptionsFrm_Load(Object sender, EventArgs e)
        {
            try
            {
                string temp_string = "";
                if (GetRegAutoStartValue(ref temp_string, RegAutoStartKeyValues.DataCenterAutoStart) == true)
                    CBAutoStart.Checked = true;
                else
                    CBAutoStart.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CBAutoStart.Enabled = false;
                BtnApply.Enabled = false;
            }
        }
        public void BtnApply_Click(Object sender, EventArgs e)
        {
            try
            {
                if (CBAutoStart.Checked == true)
                    SetRegAutoStartValue(Application.ExecutablePath, RegAutoStartKeyValues.DataCenterAutoStart);
                else
                    DelRegAutoStartValue(RegAutoStartKeyValues.DataCenterAutoStart);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
		private bool GetRegAutoStartValue(ref string KeyValue, RegAutoStartKeyValues ValueName)
		{
			//MModule.PrepareReg();
			string[] arr = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false).GetValueNames();
			int ForInt = 0;
			for (ForInt = 0; ForInt <= arr.Length - 1; ForInt++)
			{
				if (arr[ForInt] == ValueName.ToString())
				{
					KeyValue = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false).GetValue(ValueName.ToString()).ToString();
					return true;
				}
			}
			return false;
		}
		private void SetRegAutoStartValue(string KeyValue, RegAutoStartKeyValues ValueName)
		{
			//MModule.PrepareReg();
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true).SetValue(ValueName.ToString(), KeyValue);
		}
		private void DelRegAutoStartValue(RegAutoStartKeyValues ValueName)
		{
			//MModule.PrepareReg();
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true).DeleteValue(ValueName.ToString());
		}
	}
}
