using System;
using System.Collections.Generic;

using System.Text;

namespace CenterBotControl
{
    [Serializable]
    public class Account
    {
        public string silkroadServer { get; set; }
        public string silkroadUser { get; set; }
        public string silkroadPass { get; set; }
        public bool autoConnect { get; set; }
        public string LoginIP { get; set; }
        public string secondPasscode { get; set; }
        public bool Start { get; set; }
        public bool DCRestart { get; set; }
        public string CharName { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public CenterBot bot { get; set; }
        
        public Account()
        { 

        }
        public Account(string SilkroadServer, string SilkroadUser, string SilkroadPass, bool AutoConnect, string loginIP, string SecondPasscode, string charName)
        {
            silkroadServer = SilkroadServer;
            silkroadUser = SilkroadUser;
            silkroadPass = SilkroadPass;
            autoConnect = AutoConnect;
            LoginIP = loginIP;
            secondPasscode = SecondPasscode;
            CharName = charName;
        }
        public string CommandLineArg
        {
            get
            {
                string command = string.Empty;

                if (silkroadServer != string.Empty)
                    command += " -server " + silkroadServer;
                if (silkroadUser != string.Empty)
                    command += " -username " + silkroadUser;
                if (silkroadPass != string.Empty)
                    command += " -password " + silkroadPass;
                if (secondPasscode != string.Empty)
                    command += " -passcode " + secondPasscode;
                if (CharName != string.Empty)
                    command += " -charname " + CharName;
                if (LoginIP != string.Empty)
                    command += " -loginserver " + LoginIP;

                command += " -Relog 1 -StartBot 1 -login 1";
                return command;
            }
        }

    }
}
