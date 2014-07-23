using System;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace ATCommandsLicense
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the FalseX-2011 application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                FolderBrowserDialog FBDUSB = new FolderBrowserDialog() { Description = "Choose USB Driver - Fx2011" };
                if (FBDUSB.ShowDialog() == DialogResult.OK)
                {
                    string Data = USBSerialNumber.GetCDSerialNumber(FBDUSB.SelectedPath.Substring(0, 2));
                    if (Data == string.Empty)// Can't Get Serial No.
                    {
                        MessageBox.Show("Wrong Drive Letter ...!", "Error ...[Egy]FalseX", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                    FolderBrowserDialog FBDLis = new FolderBrowserDialog() { Description = "Choose License Folder - Fx2011" };
                    if (FBDLis.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(FBDLis.SelectedPath + @"\license", Data, Encoding.Unicode);
                        MessageBox.Show("Data Saved To \n" + FBDLis.SelectedPath + @"\license", "Done ....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ....!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
