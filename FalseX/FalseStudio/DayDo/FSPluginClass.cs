using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSPluginnamespace
{
    public class FSPluginClass
    {
        private OptionsFRM DayDoOptions = new OptionsFRM();
        public FSPluginClass()
        {

        }

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
            if (DayDoOptions.Visible != true)
            {
                DayDoOptions.Visible=true;
            }
            else
            {
                DayDoOptions.Focus();
            }
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
