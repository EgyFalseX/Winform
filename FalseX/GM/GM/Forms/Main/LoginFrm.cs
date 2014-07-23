using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GM.Managers;

namespace GM.Forms
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserManager.defaultInstance.SignIn(tbname.Text, tbpass.Text))
                DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                Glob.LogMessage("Invalid username/password", this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, null);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}