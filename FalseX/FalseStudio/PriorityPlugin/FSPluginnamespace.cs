using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSPluginnamespace
{
    public class FSPluginClass
    {
        OptionsFRM Frm = new OptionsFRM();

        public void StartPlugin()
        {
            Frm.Show();
        }
        public void StopPlugin()
        {
            try
            {
                Frm.Hide();
            }
            catch 
            { }
        }
        public void ShowOptions()
        {
            Frm.Show();
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
