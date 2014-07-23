using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Runtime.InteropServices;
using System.IO;

namespace ATCommands
{
    public class USBSerialNumber
    {
        

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern bool GetVolumeInformation(string Volume, StringBuilder VolumeName,
        uint VolumeNameSize, out uint SerialNumber, out uint SerialNumberLength,
        out uint flags, StringBuilder fs, uint fs_size);

        public static string GetCDSerialNumber(string DriveLetter)
        {
            try
            {
                uint serialNum, serialNumLength, flags;
                StringBuilder volumename = new StringBuilder(256);
                StringBuilder fstype = new StringBuilder(256);
                bool Found = GetVolumeInformation(DriveLetter, volumename, (uint)volumename.Capacity - 1, out serialNum, out serialNumLength,
                out flags, fstype, (uint)fstype.Capacity - 1);
                if (Found)
                    return serialNum.ToString();
            }
            catch  {}
            return string.Empty;
        }
        public static bool IsMatchSN(string SerilaNo)
        {
            bool returnMe = false;
            if (SerilaNo == string.Empty)
                return returnMe;
            SerilaNo = DecodeString(SerilaNo);//Decode Serial

            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                string DriveSN = GetCDSerialNumber(item.Name.Substring(0, 2));
                if (DriveSN == SerilaNo)
                    returnMe = true;
            }
            return returnMe;
        }
        public bool matchDriveLetterWithSerial(string SerilaNo)
        {
            string[] diskArray;
            string driveNumber;
            string driveLetter;
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDiskToPartition");
            foreach (ManagementObject dm in searcher1.Get())
            {
                diskArray = null;
                driveLetter = getValueInQuotes(dm["Dependent"].ToString());
                diskArray = getValueInQuotes(dm["Antecedent"].ToString()).Split(',');
                driveNumber = diskArray[0].Remove(0, 6).Trim();
                ManagementObjectSearcher disks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject disk in disks.Get())
                {
                    if (disk["InterfaceType"].ToString() == "USB")
                    {
                        /* This is where we get the drive serial */
                        if (parseSerialFromDeviceID(disk["PNPDeviceID"].ToString()) != string.Empty)
                        {
                            if (EncodeString(disk["PNPDeviceID"].ToString().Split(Convert.ToChar("\\"))[2].ToString()) == SerilaNo)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        private static string parseSerialFromDeviceID(string deviceId)
        {
            string[] splitDeviceId = deviceId.Split('\\');
            string[] serialArray;
            string serial;
            int arrayLen = splitDeviceId.Length - 1;

            serialArray = splitDeviceId[arrayLen].Split('&');
            serial = serialArray[0];

            return serial;
        }
        private static string getValueInQuotes(string inValue)
        {
            string parsedValue = "";

            int posFoundStart = 0;
            int posFoundEnd = 0;

            posFoundStart = inValue.IndexOf("\"");
            posFoundEnd = inValue.IndexOf("\"", posFoundStart + 1);

            parsedValue = inValue.Substring(posFoundStart + 1, (posFoundEnd - posFoundStart) - 1);

            return parsedValue;
        }
        private static string EncodeString(string Text2Encode)
        {
            string ReturnMe = string.Empty;
            foreach (char item in Text2Encode)
            {
                ReturnMe += ((char)(255 - (int)item)).ToString();
            }
            return ReturnMe;
        }
        private static string DecodeString(String Text2Decode)
        {
            string ReturnMe = string.Empty;
            foreach (char item in Text2Decode)
            {
                ReturnMe += ((char)(255 - (int)item)).ToString();
            }
            return ReturnMe;
        }

    }
}

