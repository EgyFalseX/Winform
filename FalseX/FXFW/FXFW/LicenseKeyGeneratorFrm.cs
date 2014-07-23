using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace FXFW
{
    public partial class LicenseKeyGeneratorFrm : Form
    {
        private static string PasswordKey = "ByTheNameOfAllah";
        #region -   Functions   -
        public LicenseKeyGeneratorFrm()
        {
            InitializeComponent();
            tbID.Text = CUPID();
        }
        public static string CUPID()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            using (ManagementObjectCollection moc = mc.GetInstances())
            {
                foreach (ManagementObject mo in moc)
                {
                    if (cpuInfo == "")
                    {
                        //Get only the first CPU's ID
                        cpuInfo = mo.Properties["processorID"].Value.ToString();
                        break;
                    }
                }
            }
            return cpuInfo;
        }
        #endregion
        #region -   Event Handlers   -

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim() == string.Empty)
            {
                tbKey.Text = string.Empty;
                return;
            }
            tbKey.Text = EncDec.Encrypt(tbID.Text + tbName.Text, PasswordKey);
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            using (StreamWriter sw = new StreamWriter(FBD.SelectedPath + @"\lnc.key"))
            {
                sw.Write(tbKey.Text);
                sw.Close();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    
    }
}
