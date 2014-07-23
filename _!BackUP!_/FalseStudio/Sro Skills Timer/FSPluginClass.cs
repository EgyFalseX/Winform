using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSPluginnamespace
{
    class FSPluginClass
    {
        SroTimerFRM FRMSroTimer = new SroTimerFRM();

        public void StartPlugin()
        {
            if (!FRMSroTimer.Created)
            {
                FRMSroTimer = new SroTimerFRM();
                FRMSroTimer.Show();
            }
            else
            {
                FRMSroTimer.Focus();
            }
        }
        public void StopPlugin()
        {
            if (FRMSroTimer.Created)
            {
                FRMSroTimer.Close();
            }
        }
        public void ShowOptions()
        {
            MessageBox.Show("No options for this plugin","Sro Skills Timer",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public string GetOwner()
        {
            return "False";
        }
        public string GetVersion()
        {
            return Application.ProductVersion.ToString();
        }
    }
}
