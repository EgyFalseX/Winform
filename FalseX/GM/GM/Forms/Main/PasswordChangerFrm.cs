using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GM.Managers;

namespace GM.Forms.Main
{
    public partial class PasswordChangerFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataSources.dsGMTableAdapters.UserTableAdapter adpUser = new DataSources.dsGMTableAdapters.UserTableAdapter();
        #endregion
        #region -   Functions   -
        public PasswordChangerFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region - Event Handlers -
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProviderPassword.Validate())
                return;
            if (!dxValidationProviderMain.Validate())
                return;

            if (adpUser.CheckPassword(UserManager.defaultInstance.UserInfo.UserId, tbOldPass.Text) < 1)
            {
                Glob.LogMessage("Current Password is wrong", this, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.Message);

                return;
            }
            adpUser.ChangePassword(tbNewPass.EditValue.ToString(), UserManager.defaultInstance.UserInfo.UserId);

            Glob.LogMessage("New Password Saved", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Message);
        }
        #endregion
        
    }
}