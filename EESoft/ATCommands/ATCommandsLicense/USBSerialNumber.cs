using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;

namespace ATCommandsLicense
{
    public class USBSerialNumber
    {
        
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)] 
        static extern bool GetVolumeInformation(string Volume, StringBuilder VolumeName, 
	    uint VolumeNameSize, out uint SerialNumber, out uint SerialNumberLength, 
	    out uint flags, StringBuilder fs, uint fs_size);

        public static string GetCDSerialNumber(string DriveLetter)
        {
            uint serialNum, serialNumLength, flags;
            StringBuilder volumename = new StringBuilder(256);
            StringBuilder fstype = new StringBuilder(256);
            bool Found = GetVolumeInformation(DriveLetter, volumename, (uint)volumename.Capacity - 1, out serialNum, out serialNumLength,
            out flags, fstype, (uint)fstype.Capacity - 1);
            if (Found)
                return EncodeString(serialNum.ToString());
            else
                return string.Empty;
        }
        public static string GetSerialNumber(string DriveLetter)
        {
            DriveLetter = DriveLetter.ToUpper();
            string  temp = string.Empty;
            string ans = string.Empty;
            string[] parts;
            //get the Logical Disk for that drive letter
            ManagementObject wmi_ld = new ManagementObject("win32_logicaldisk.deviceid=\"" + DriveLetter + "\"");
            //get the associated DiskPartition
            foreach (ManagementObject DiskPartition in wmi_ld.GetRelated("Win32_DiskPartition"))
            {
                //get the associated DiskDrive
                foreach (ManagementObject DiskDrive in DiskPartition.GetRelated("Win32_DiskDrive"))
                {
                    /*There is a bug in WinVista that corrupts some of the fields
                    of the Win32_DiskDrive class if you instantiate the class via
                    its primary key (as in the example above) and the device is
                    a USB disk. Oh well... so we have go thru this extra step*/
                    ManagementClass wmi = new ManagementClass("Win32_DiskDrive");
                    /*loop thru all of the instances. This is silly, we shouldn't
                     *have to loop thru them all, when we know which one we want.*/
                    foreach (ManagementObject obj in wmi.GetInstances())
                    {
                        // do the DeviceID fields match?
                        if (obj["DeviceID"].ToString() == DiskDrive["DeviceID"].ToString())
                        {
                            //the serial number is embedded in the PnPDeviceID
                            temp = obj["PnPDeviceID"].ToString();
                            if (!temp.StartsWith("USBSTOR"))
                            {
                                System.Windows.Forms.MessageBox.Show(DriveLetter + " doesn't appear to be USB Device");
                                return string.Empty;
                            }
                            parts = temp.Split("\\&".ToCharArray());
                            //The serial number should be the next to the last element
                            ans = parts[parts.Length - 2];
                        }
                        
                    }
                }
            }
            return ans;
        }
        public static string matchDriveLetterWithSerial(string DriveLatter)
        {
            string RtnMe = string.Empty;
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
                    /* This is where we get the drive serial */
                    if (driveLetter == DriveLatter.ToUpper())
                    {
                        if (disk["InterfaceType"].ToString() == "USB")
                            return DecodeString(disk["PNPDeviceID"].ToString().Split(Convert.ToChar("\\"))[2].ToString());
                    }
                }
            }
            return string.Empty;
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

