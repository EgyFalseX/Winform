﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FalseStudio
{
    static class FalseStudioProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainCLS.Initialize();
            Application.Run();
        }
        
    }
}
