using System;
using System.Collections.Generic;

using System.Text;

namespace IbotControl.Hackshield
{
    public static class HSTypes
    {
        public const string LauncherTitle = "Silkroad Online Launcher";

        public const string IPHS = "####        IPHS:";
        public const string WaitingForSroClient = "Waiting for client... /127.0.0.1:";
        //Start Silkroad.exe here
        public const string ClientAccepted = "Client accepted...";
        public const string ConnectingToServer = "Connecting to server...";
        public const string InitializingPleaseWait = "Initializing please wait...";
        public const string SilkroadLauncherIsReady = "Silkroad launcher is now ready...";

        //Press Start In Silkroad Launcher here
        public const string Clientdisconnected = "Client disconnected...";
        public const string CriticalError = "Critical Error - ";

        public const string SROClientIsNowReady = "SRO Client is now ready...";
        public const string StartingHSServerListener = "Starting HS Server listener...";
        public const string WaitingForHSClient = "Waiting for HS Client... ";

        public const string ERROR = "****** ERROR ******";
        public const string ERRORHSData = "Error detected on HS Data... ";
        public const string ERRORRestartHS = "Please restart HS Server and Silkroad.exe";

        public delegate void ReceivedStatusEventhandler(object sender, HSLogTypes e);
        public delegate void SroClientStyleEventhandler(Win32.WindowShowStyle style);

        public enum HSLogTypes
        {
            IPHS,
            WaitingForSroClient,

            ClientAccepted,
            ConnectingToServer,
            InitializingPleaseWait,
            SilkroadLauncherIsReady,

            Clientdisconnected,
            CriticalError,

            SROClientIsNowReady,
            StartingHSServerListener,
            WaitingForHSClient,

            ERROR,
            ERRORHSData,
            ERRORRestartHS,

            Unknown
        }

        public static HSLogTypes GetLogType(string data)
        {
            if (data == null || data == string.Empty)
                return HSLogTypes.Unknown;

            if (data.StartsWith(IPHS))
                return HSLogTypes.IPHS;
            else if (data.StartsWith(WaitingForSroClient))
                return HSLogTypes.WaitingForSroClient;
            else if (data.StartsWith(ClientAccepted))
                return HSLogTypes.ClientAccepted;
            else if (data.StartsWith(ConnectingToServer))
                return HSLogTypes.ConnectingToServer;
            else if (data.StartsWith(InitializingPleaseWait))
                return HSLogTypes.InitializingPleaseWait;
            else if (data.StartsWith(SilkroadLauncherIsReady))
                return HSLogTypes.SilkroadLauncherIsReady;
            else if (data.StartsWith(Clientdisconnected))
                return HSLogTypes.Clientdisconnected;
            else if (data.StartsWith(CriticalError))
                return HSLogTypes.CriticalError;
            else if (data.StartsWith(SROClientIsNowReady))
                return HSLogTypes.SROClientIsNowReady;
            else if (data.StartsWith(StartingHSServerListener))
                return HSLogTypes.StartingHSServerListener;
            else if (data.StartsWith(WaitingForHSClient))
                return HSLogTypes.WaitingForHSClient;
            else if (data.StartsWith(ERROR))
                return HSLogTypes.ERROR;
            else if (data.StartsWith(ERRORHSData))
                return HSLogTypes.ERRORHSData;
            else if (data.StartsWith(ERRORRestartHS))
                return HSLogTypes.ERRORRestartHS;
            else
                return HSLogTypes.Unknown;

        }
      
    }
  
}

