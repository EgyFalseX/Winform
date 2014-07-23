using System;
using System.Windows.Forms;

namespace DataCenter_Client
{
	public partial class OptionsFrm
	{
		public OptionsFrm()
		{
			InitializeComponent();
		}
		private string ErrorProvider;


        public void TxtPassword_TextChanged(Object sender, EventArgs e)
        {
            if (TxtPassword.TextLength > 0 || TxtPasswordCon.TextLength > 0 || TxtPassword.Text.Trim() != TxtPasswordCon.Text.Trim())
                BtnSaveClientOptions.Enabled = true;
            else
                BtnSaveClientOptions.Enabled = false;
        }

        public void BtnSaveClientOptions_Click(Object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟","تحزير",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            ErrorProvider = null;
            ErrorProvider = MainModule.FunLib.ChangePasswrod(MainModule.FunLib.CUser.UID, TxtPassword.Text.Trim());
            if (ErrorProvider == null)
            {
                MainModule.FunLib.CUser.UPass = TxtPassword.Text.Trim();
                FunctionLib.MCls.msg("تم حفظ كلمة المرور", false, "", this);  
            }
            else
                FunctionLib.MCls.msg("تم الرفض", true, "", this);  
        }
	}
}
