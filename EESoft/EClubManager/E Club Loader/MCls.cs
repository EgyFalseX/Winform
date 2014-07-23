using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;

namespace E_Club_Loader
{
    class MCls
    {
        #region -   Variables   -

        public static string ECCM = "E Club Acc Manager";
        public static string ECAM = "E Club Att Manager";
        public static string ECEM = "E Club Emp Manager";
        public static string ECMM = "E Club Mem Manager";
        public static string ECRM = "E Club Store Manager";
        public static string ECSM = "E Club Sub Manager";
       
        #endregion
        #region -   Functions   -
        //Registry Functions
        public static string GetRegValue(string ValueName)
        {
            string ReturnMe = string.Empty;
            try
            {
                string[] arr = Registry.LocalMachine.OpenSubKey("SOFTWARE\\ECM", false).GetValueNames();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == ValueName)
                    {
                        ReturnMe = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\ECM", false).GetValue(ValueName);
                        break;
                    }
                }

            }
            catch
            {
                return string.Empty;
            }
            return ReturnMe;
        }
        #endregion
    }
}