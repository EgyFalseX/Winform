using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbSyc_Server.Logging
{
    public class Log
    {
        public static void LogMessage(string msg, bool IsError = false)
        {
            System.Diagnostics.Debug.WriteLine(msg);
            Program.MainFrm.LogMsg(msg, IsError);
        }

    }
}
