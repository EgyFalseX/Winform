using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Main
{
    public partial class PasswordChangerFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter adpUser = new DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter();
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
            if (adpUser.ScalarQueryCheckPassword(tbOldPass.Text, Program.UserInfo.UserId) < 1)
            {
                Program.ShowMsg("كلمة المرور الحالية خاطئة", true, this, true);
                Program.Logger.LogThis("كلمة المرور الحالية خاطئة", Text, FXFW.Logger.OpType.warning, null, null, this);
                return;
            }
            adpUser.UpdateQueryPassword(tbNewPass.EditValue.ToString(), Program.UserInfo.UserId);
            Program.ShowMsg("تم الحفـــظ", false, this, true);
            Program.Logger.LogThis("تم الحفـــظ", Text, FXFW.Logger.OpType.success, null, null, this);
        }
        #endregion
        
    }
}