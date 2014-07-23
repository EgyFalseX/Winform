using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32;

namespace DataCenterNetworkService
{
	sealed class MModule
	{
		//Forms
		public static OptionsFrm FrmOptions = new OptionsFrm();
		public static MainFrm FrmMain = new MainFrm();
		//Options
		public static string DeletedFilesPath = "";
		public static short GeneralPort;
		//Public AutoStart As String
		public static string FileIfo = string.Empty;
        public static bool EnableCommand;
		public enum Commands //this is the commands between the server and the client
		{
			Ping, // command 0
			SendFile, //command 1
			ReciveFile, //command 2
			CreateFile, //command 3
			CreateFolder, //command 4
			RemoveFolder, //Command 5
			RemoveFile, //Command 6
			MoveFolder //Command 7
		}
		public enum RegKeyValues
		{
            GeneralPort,
            DeletedFilesPath
		}

        public static void PrepareReg()
        {
            RegistryKey RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            string[] arr;
            arr = Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "DataCenter")
                {
                    return;
                }
            }
            RegKey.CreateSubKey("DataCenter");
        }
        public static string GetRegValue(string ValueName)
        {
            PrepareReg();
            string ReturnMe = string.Empty;
            string[] arr = Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", false).GetValueNames();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ValueName)
                {
                    ReturnMe = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", false).GetValue(ValueName);
                    break;
                }
            }
            return ReturnMe;
        }
		public static bool GetRegValue(ref string KeyValue, RegKeyValues ValueName)
		{
            
            foreach (string str in Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames())
            {
                if (str == "DataCenter")
                {
                    string[] arr = Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", false).GetValueNames();
                    int ForInt = 0;
                    for (ForInt = 0; ForInt <= arr.Length - 1; ForInt++)
                    {
                        if (arr[ForInt] == ValueName.ToString())
                        {
                            KeyValue = (string)(Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", false).GetValue((string)(ValueName.ToString())));
                            return true;
                        }
                    }
                }
            }
            return false;
		}
	}
}
