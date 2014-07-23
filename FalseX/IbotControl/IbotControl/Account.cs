using System;
using System.Collections.Generic;

using System.Text;

namespace IbotControl
{
    [Serializable]
    public class Account
    {
        public string silkroadServer { get; set; }
        public string silkroadUser { get; set; }
        public string silkroadPass { get; set; }
        public string autoSelectChar { get; set; }
        public string autoSelectOpt { get; set; }
        public bool autoConnect { get; set; }
        public bool hideiBot { get; set; }
        public bool clientlessLogin { get; set; }
        public string changeLoginIP { get; set; }
        public string secondPasscode { get; set; }
        public bool Start { get; set; }
        public bool DCRestart { get; set; }
        public bool RestartUnknowSpot { get; set; }
        public string IbotFilePath { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public IBot bot { get; set; }
        
        public Account()
        { 

        }
        public Account(string SilkroadServer, string SilkroadUser, string SilkroadPass, string AutoSelectChar, string AutoSelectOpt
            , bool AutoConnect, bool HideiBot, bool ClientlessLogin, string ChangeLoginIP, string SecondPasscode,
            bool start, bool dcRestart, bool scrollUnknowSpot, string ibotFilePath)
        {
            silkroadServer = SilkroadServer;
            silkroadUser = SilkroadUser;
            silkroadPass = SilkroadPass;
            autoSelectChar = AutoSelectChar;
            autoSelectOpt = AutoSelectOpt;
            autoConnect = AutoConnect;
            hideiBot = HideiBot;
            clientlessLogin = ClientlessLogin;
            changeLoginIP = ChangeLoginIP;
            secondPasscode = SecondPasscode;
            Start = start;
            DCRestart = dcRestart;
            RestartUnknowSpot = scrollUnknowSpot;
            IbotFilePath = ibotFilePath;
        }

        public string CommandLineArg
        {
            get
            {
                string command = string.Empty;

                if (silkroadServer != string.Empty)
                    command += " SN:" + silkroadServer;
                if (silkroadUser != string.Empty)
                    command += " SU:" + silkroadUser;
                if (silkroadPass != string.Empty)
                    command += " SP:" + silkroadPass;
                if (autoSelectChar != string.Empty)
                    command += " AS:" + autoSelectChar;
                if (secondPasscode != string.Empty)
                    command += " PC:" + secondPasscode;
                if (autoSelectOpt != string.Empty)
                    command += " AB:" + autoSelectOpt;
                if (changeLoginIP != string.Empty)
                    command += " LS:" + changeLoginIP;
                if (clientlessLogin != false)
                    command += " CL";
                if (autoConnect != false)
                    command += " AC:4000";
                if (hideiBot != false)
                    command += " HI ";
                
                return command;
            }
        }

    }
}
