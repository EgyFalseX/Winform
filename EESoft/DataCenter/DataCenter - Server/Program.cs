using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FunctionLib;

namespace DataCenter_Server
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new StartUpFrm());
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), new Form());
            }
        }
        public static MCls MC = new MCls();
    }
}
