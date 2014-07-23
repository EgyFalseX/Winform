using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Netsync
{
    public static class config
    {
        public static int PORT { get; set; }
        private static string _configFilePath = Application.StartupPath + "\\Config";

        public static void SaveConfig()
        {

        }
        public static void LoadConfig()
        {

        }
        public static bool StartUp
        {
            get
            {
                RegistryKey add = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                foreach (string item in add.GetValueNames())
                {
                    if (item == Application.ProductName)
                        return true;
                }
                return false;
            }
            set
            {
                RegistryKey add = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (value)
                    add.SetValue(Application.ProductName, "\"" + Application.ExecutablePath.ToString() + "\"");
                else
                    add.DeleteValue(Application.ProductName, false);
            }
        }

    }
}
