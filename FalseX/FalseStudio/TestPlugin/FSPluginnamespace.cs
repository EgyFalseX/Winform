using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSPluginnamespace
{
    public class FSPluginClass
    {
        public void StartPlugin()
        {
            MessageBox.Show("Test Plugin Started");
        }
        public void StopPlugin()
        {
            MessageBox.Show("Test Plugin Stoped");
        }
        public void ShowOptions()
        {
            MessageBox.Show("Test Plugin Show Options");
        }

        public string GetOwner()
        {
            return "FalseX";
        }

        public string GetVersion()
        {
            return Application.ProductVersion.ToString();
        }

    }
}
