using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace E_Club_Mem_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new ECMMainFrm());
        }
        public static MCls MC = new MCls();
    }
}
