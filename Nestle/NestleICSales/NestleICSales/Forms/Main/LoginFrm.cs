using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NestleICSales.Managers;

namespace NestleICSales.Forms
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(LoginFrm));
        public LoginFrm()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure?", Utilities.Types.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                return;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserManager.defaultInstance.SignIn(tbname.Text, tbpass.Text))
                DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                MsgDlg.Show("Invalid username/password", Utilities.Types.MessageType.Error);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}