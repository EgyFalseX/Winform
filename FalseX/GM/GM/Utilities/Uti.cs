using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GM.Utilities
{
    public static class Uti
    {
        public static void LogMessage(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }
        public static void AddBytesToArray(ref byte[] srcBytes, byte[]add, bool AtEnd)
        {
            Array.Resize(ref srcBytes, srcBytes.Length + add.Length);
            if (AtEnd)
            {
                System.Buffer.BlockCopy(add, 0, srcBytes, srcBytes.Length - add.Length, add.Length);
            }
            else
            {
                Array.Copy(srcBytes, 0, srcBytes, add.Length, srcBytes.Length - add.Length);
                System.Buffer.BlockCopy(add, 0, srcBytes, 0, add.Length);
            }
        }
        public static bool IsNullOrEmpty(object obj)
        {
            if (obj == null)
                return true;

            if (obj.ToString() == string.Empty)
                return true;
            else
                return false;
        }
    }
}
