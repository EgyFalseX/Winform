using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using DataCenter.Managers;

namespace DataCenter.Forms
{
    public partial class ServerOptionWizardFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ServerOptionWizardFrm));
        #endregion
        #region -   Functions   -
        public ServerOptionWizardFrm()
        {
            InitializeComponent();
        }
        private bool Saving()
        {
            AppManager.defaultInstance.SetServerOption(nsLib.Utilities.Types.ServerOptions.FilesPath, beFilesPath.EditValue);
            AppManager.defaultInstance.SetServerOption(nsLib.Utilities.Types.ServerOptions.DeletedFilesPath, beDeletedFilesPath.EditValue);
            AppManager.defaultInstance.SetServerOption(nsLib.Utilities.Types.ServerOptions.DefaultUserPassword, tbDefaultUserPassword.EditValue);
            AppManager.defaultInstance.SetServerOption(nsLib.Utilities.Types.ServerOptions.ServerIP, tbServerIP.EditValue);
            AppManager.defaultInstance.SetServerOption(nsLib.Utilities.Types.ServerOptions.ServerPort, tbServerPort.EditValue);
            return AppManager.defaultInstance.SaveServerOptions();

        }
        #endregion
        #region -   Event Handlers   -
        private void ServerOptionWizardFrm_Load(object sender, EventArgs e)
        {
            beFilesPath.EditValue = AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.FilesPath);
            beDeletedFilesPath.EditValue = AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.DeletedFilesPath);
            tbDefaultUserPassword.EditValue = AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.DefaultUserPassword);
            tbServerIP.EditValue = AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.ServerIP);
            tbServerPort.EditValue = AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.ServerPort);
        }
        private void wizardControlOptions_CancelClick(object sender, CancelEventArgs e)
        {
            this.Close();
        }
        private void wizardControlOptions_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == wizardPagePaths)
            {
                if (!beFilesPath.DoValidate() || !beDeletedFilesPath.DoValidate())
                {
                    e.Cancel = true;
                    DataCenterX.LogMessage("يجب مليء جميع البيانات", typeof(ServerOptionWizardFrm), nsLib.Utilities.Types.MessageType.Warn, null, true);
                }
            }
            else if (e.PrevPage == wizardPageGeneralOptions)
            {
                if (!tbDefaultUserPassword.DoValidate())
                {
                    e.Cancel = true;
                    DataCenterX.LogMessage("يجب مليء جميع البيانات", typeof(ServerOptionWizardFrm), nsLib.Utilities.Types.MessageType.Warn, null, true);
                }
            }
            else if (e.PrevPage == wizardPageServerOptions)
            {
                if (!tbServerIP.DoValidate() || !tbServerPort.DoValidate())
                {
                    e.Cancel = true;
                    DataCenterX.LogMessage("يجب مليء جميع البيانات", typeof(ServerOptionWizardFrm), nsLib.Utilities.Types.MessageType.Warn, null, true);
                    return;
                }
            }
        }
        private void wizardControlOptions_FinishClick(object sender, CancelEventArgs e)
        {
            //Saving
            if (!Saving())
            {
                e.Cancel = true;
                DataCenterX.LogMessage("خطــــــاء,  لم يتم الحفظ", typeof(ServerOptionWizardFrm), nsLib.Utilities.Types.MessageType.Error, null, true);
            }
            else
                DataCenterX.LogMessage("تم حفظ الخيارات", typeof(ServerOptionWizardFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
        }
        private void beFilesPath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                beFilesPath.EditValue = fbd.SelectedPath;
            }
        }
        private void beDeletedFilesPath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                beDeletedFilesPath.EditValue = fbd.SelectedPath;
            }
        }

        private void tbDefaultUserPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbDefaultUserPassword.EditValue == null || tbDefaultUserPassword.EditValue.ToString() == string.Empty)
                e.Cancel = true;
        }
        private void beFilesPath_Validating(object sender, CancelEventArgs e)
        {
            if (beFilesPath.EditValue == null || beFilesPath.EditValue.ToString() == string.Empty)
                e.Cancel = true;
        }
        private void beDeletedFilesPath_Validating(object sender, CancelEventArgs e)
        {
            if (beDeletedFilesPath.EditValue == null || beDeletedFilesPath.EditValue.ToString() == string.Empty)
                e.Cancel = true;
        }
        private void tbServerIP_Validating(object sender, CancelEventArgs e)
        {
            if (tbServerIP.EditValue == null || tbServerIP.EditValue.ToString() == string.Empty)
                e.Cancel = true;
        }
        private void tbServerPort_Validating(object sender, CancelEventArgs e)
        {
            if (tbServerPort.EditValue == null || tbServerPort.EditValue.ToString() == string.Empty)
                e.Cancel = true;
        }

        #endregion



    }
}