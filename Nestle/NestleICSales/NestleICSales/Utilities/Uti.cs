using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestleICSales.Utilities
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
        public static List<int> BusinessDays(DayOfWeek[] WeekEndDays, int Year, int Month)
        {
            List<int> days = new List<int>();

            //Fetch the amount of days in your given month
            int daysInMonth = DateTime.DaysInMonth(Year, Month);

            //Here we create and enumerable from 1 to daysInMonth
            //and ask whether the Datetime object we create belongs to a weekend day,
            //if it doen't add it to our IEumerable<int> collection of days.
            IEnumerable<int> businessDaysInMonth = Enumerable.Range(1, daysInMonth).Where(d => !WeekEndDays.Contains(new DateTime(Year, Month, d).DayOfWeek));
            
            days.AddRange(businessDaysInMonth);
            return days;
        }
        public static Single ConvertStringToInt(string str)
        {
            string ReturnMe = string.Empty;
            int count = 0;
            foreach (char c in str.ToCharArray())
            {
                if (c == Convert.ToChar(".") && count < 1)
                {
                    ReturnMe += c.ToString();
                    count++;
                }
                if (char.IsNumber(c))
                {
                    ReturnMe += c.ToString();
                }
            }
            if (ReturnMe == string.Empty)
            {
                ReturnMe = "0";
            }
            return Convert.ToSingle(ReturnMe);
        }
    }
}
