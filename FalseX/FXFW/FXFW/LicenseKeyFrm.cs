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
    public partial class LicenseKeyFrm : Form
    {
        private static string PasswordKey = "ByTheNameOfAllah";
        private string AppName = string.Empty;
        #region -   Functions   -
        public LicenseKeyFrm(string ApplicationName)
        {
            InitializeComponent();
            AppName = ApplicationName;
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
        public static bool Compare(string Data, string ApplicationName)
        {
            try
            {
                if (EncDec.Decrypt(Data, PasswordKey) == CUPID() + ApplicationName)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        #endregion
        #region -   Event Handlers   -
        private void LicenseKeyFrm_Load(object sender, EventArgs e)
        {
            //EncDec.Encrypt(CUPID(), PasswordKey);
            tbID.Text = CUPID();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "LicenseKey(*.key)|*.key|All Files(*.*)|*.*" };
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            StreamReader sr = new StreamReader(ofd.FileName);
            string KeyString = sr.ReadToEnd();
            sr.Close();


            if (KeyString == EncDec.Encrypt(CUPID() + AppName, PasswordKey))
            {
                File.Copy(ofd.FileName, String.Format("{0}\\{1}", Application.StartupPath, ofd.SafeFileName));
                Close();
            }
            else
                MessageBox.Show("Key is wrong", "error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
