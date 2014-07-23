using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataCenter.Managers;

namespace DataCenter.Forms
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {

        public LoginFrm()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد", "خطاء", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                return;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserManager.defaultInstance.SignIn(tbname.Text, tbpass.Text))
                DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                DataCenterX.LogMessage("اسم المستخدم او كلمة المرور خاطئة", typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, null, true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}