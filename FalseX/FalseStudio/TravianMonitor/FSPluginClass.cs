using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSPluginnamespace
{
    public class FSPluginClass
    {
        public TravianMonitorFrm FrmTravianMonitor = new TravianMonitorFrm();
        

        public struct ElementContain
        {
           public int Count;
           public int Percent;
           public int WillB;
        }
        public struct Element
        {
            public ElementContain Wood;
            public ElementContain Mud;
            public ElementContain Iron;
            public ElementContain Wheat;
            public float TaskMins;
        }
        public static Element[] Elements = new Element[9];
        
        public void StartPlugin()
        {
            if (!FrmTravianMonitor.Created)
            {
                FrmTravianMonitor = new TravianMonitorFrm();
                FrmTravianMonitor.Show();
            }
            else
            {
                FrmTravianMonitor.Focus();
            }
        }
        public void StopPlugin()
        {
            if (FrmTravianMonitor.Created)
            {
                FrmTravianMonitor.Close();
            }
        }
        public void ShowOptions()
        {
            MessageBox.Show("No options for this plugin", "Travian Monitor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
