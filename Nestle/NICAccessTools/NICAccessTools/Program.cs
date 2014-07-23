using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace NICAccessTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
    }
}
