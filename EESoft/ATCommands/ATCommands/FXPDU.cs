using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Collections;



namespace ATCommands
{
    public class FXPDU1
	{
		
		#region Enums
		public enum ENUM_TP_VPF
		{
			Relative_Format = 16 //b4=1 b3=0
		}
		
		public enum ENUM_TP_SRI
		{
			Request_SMS_Report = 32,
			No_SMS_Report = 0
		}
		
		public enum ENUM_TP_DCS
		{
			DefaultAlphabet = 0,
			UCS2 = 8
		}
		
		public enum ENUM_TP_VALID_PERIOD
		{
			OneHour = 11, //0 to 143:(TP-VP+1)*5Min
			ThreeHours = 29,
			SixHours = 71,
			TwelveHours = 143,
			OneDay = 167,
			OneWeek = 196,
			Maximum = 255
		}
		#endregion
		
		#region Protected Data
		protected string SC_Number; //Note the plus!
		protected byte TP_MTI = 1;
		protected byte TP_RD = 0;
		protected byte TP_VPF = 16;
		protected byte TP_UDHI;
		protected byte TP_SRR;
		protected int TP_MR;
		protected string TP_DA;
		protected byte TP_PID;
		protected byte TP_DCS;
		protected byte TP_VP;
		protected int TP_UDL;
		protected string TP_UD;
		#endregion
		
		#region Properties
		
		public string ServiceCenterNumber
		{
			get
			{
				return SC_Number;
			}
			set
			{
				//Convert an ServiceCenterNumber to PDU Code
				if (System.Convert.ToBoolean(value.IndexOf("+") + 1))
				{
					SC_Number = "91";
				}
				else
				{
					SC_Number = "81";
				}
				
				value = value.Substring(1);
				int i;
				if ((value.Length % 2) == 1)
				{
					value += "F";
				}
				for (i = 1; i <= value.Length; i += 2)
				{
					SC_Number += Swap(value.Substring(i - 1, 2));
				}
				SC_Number = (string) (ByteToHex((byte) ((SC_Number.Length - 2) / 2 + 1)) + SC_Number);
			}
			
		}
		
		public ENUM_TP_SRI TP_Status_Report_Request
		{
			get
			{
				return  (ENUM_TP_SRI) (TP_SRR);
			}
			set
			{
				TP_SRR =  (byte) (value);
			}
		}
		
		public int TP_Message_Reference
		{
			get
			{
				return TP_MR;
			}
			set
			{
				TP_MR = value;
			}
		}
		
		public string TP_Destination_Address
		{
			get
			{
				return TP_DA;
			}
			set
			{
				TP_DA = "";
				
				if (System.Convert.ToBoolean(value.IndexOf("+") + 1))
				{
					TP_DA += "91";
				}
				else
				{
					TP_DA += "81";
				}
				value = value.Replace("+", "");
				TP_DA = (string) (Strings.Format(value.Length, "X2") + TP_DA);
				int i;
				if ((value.Length % 2) == 1)
				{
					value += "F";
				}
				for (i = 1; i <= value.Length; i += 2)
				{
					TP_DA += Swap(value.Substring(i - 1, 2));
				}
			}
		}
		
		
		public ENUM_TP_DCS TP_Data_Coding_Scheme
		{
			get
			{
				return  (ENUM_TP_DCS) (TP_DCS);
			}
			set
			{
				TP_DCS =  (byte) (value);
			}
		}
		
		public ENUM_TP_VALID_PERIOD TP_Validity_Period
		{
			get
			{
				return  (ENUM_TP_VALID_PERIOD) (TP_VP);
			}
			set
			{
				TP_VP =  (byte) (value);
			}
		}
		
		public virtual string TP_User_Data
		{
			get
			{
				return TP_UD;
			}
			set
			{
				if (TP_DCS == System.Convert.ToByte(ENUM_TP_DCS.DefaultAlphabet))
				{
					TP_UDL = value.Length;
					TP_UD = Encode7Bit(value);
				}
				else if (TP_DCS == System.Convert.ToByte(ENUM_TP_DCS.UCS2))
				{
					TP_UDL = value.Length * 2;
					TP_UD = EncodeUCS2(value);
				}
				else
				{
					TP_UD = value;
				}
			}
		}
		#endregion
		
		#region Functions
        public static FXPDU1.ENUM_TP_DCS CheckForEncoding(string Content)
		{
			int i;
			for (i = 1; i <= Content.Length; i++)
			{
				if (Strings.Asc(Content.Substring(i - 1, 1)) < 0)
				{
                    return FXPDU1.ENUM_TP_DCS.UCS2;
				}
			}
            return FXPDU1.ENUM_TP_DCS.DefaultAlphabet;
		}
		
		public virtual string GetSMSPDUCode()
		{
			string PDUCode;
			//Check User Data Length
			if (TP_DCS == System.Convert.ToByte(ENUM_TP_DCS.DefaultAlphabet))
			{
				if (TP_UD.Length > 280)
				{
					throw (new Exception("User Data is TOO LONG for SMS"));
				}
			}
			if (TP_DCS == System.Convert.ToByte(ENUM_TP_DCS.UCS2))
			{
				if (TP_UD.Length > 280)
				{
					throw (new Exception("User Data is TOO LONG for SMS"));
				}
			}
			//Make PDUCode
			PDUCode = SC_Number;
			PDUCode += FirstOctet();
			PDUCode += Strings.Format(TP_MR, "X2");
			PDUCode += TP_DA;
			PDUCode += Strings.Format(TP_PID, "X2");
			PDUCode += Strings.Format(TP_DCS, "X2");
			PDUCode += Strings.Format(TP_VP, "X2");
			PDUCode += Strings.Format(TP_UDL, "X2");
			PDUCode += TP_UD;
			return PDUCode;
		}
		
		public virtual string FirstOctet()
		{
			return ByteToHex((byte) (TP_MTI + TP_VPF + TP_SRR + TP_UDHI));
		}
		
		static public string ByteToHex(byte aByte)
		{
			string result;
			result = Strings.Format(aByte, "X2");
			return result;
		}
		
		#region Encode7Bit
		static public string Encode7Bit(string Content)
		{
			//Prepare
			char[] CharArray = Content.ToCharArray();
			
			string t = "";
			foreach (char c in CharArray)
			{
				t = (string) (CharTo7Bits(c) + t);
			}
			//Add "0"
			int i;
			if ((t.Length % 8) != 0)
			{
				for (i = 1; i <= 8 - (t.Length % 8); i++)
				{
					t = (string) ("0" + t);
				}
			}
			//Split into 8bits
			string result = "";
			for (i = t.Length - 8; i >= 0; i -= 8)
			{
				result = result + BitsToHex(t.Substring(i + 1 - 1, 8));
			}
			return result;
		}
		
		static public string BitsToHex(string Bits)
		{
			//Convert 8Bits to Hex String
			int i;
			int v = System.Convert.ToInt32(0);
			// 			int v;
			for (i = 0; i <= Bits.Length - 1; i++)
			{
				v =  (int) (v + Conversion.Val(Bits.Substring(i + 1 - 1, 1)) * Math.Pow(2, (7 - i)));
			}
			string result;
			result = Strings.Format(v, "X2");
			return result;
		}
		
		static public string CharTo7Bits(char c)
		{
			if (c == '@')
			{
				return "0000000";
			}
			string Result = string.Empty;
			int i;
			for (i = 0; i <= 6; i++)
			{
                //[Source] if ((Strings.Asc(c) + Math.Pow(2, i) ) > 0)
				if ((Strings.Asc(c) + Math.Pow(2, i) ) > 0)
				{
					Result = (string) ("1" + Result);
				}
				else
				{
					Result = (string) ("0" + Result);
				}
			}
			return Result;
		}
		#endregion
		
		static public string EncodeUCS2(string Content)
		{
			int i;
			int v;
			string Result = "";
			string t;
			// 			string t;
			for (i = 1; i <= Content.Length; i++)
			{
				v = Strings.AscW(Content.Substring(i - 1, 4));
				t = Strings.Format(v, "X4");
				Result += t;
			}
			return Result;
		}
		
		static public string Swap(string TwoBitStr)
		{
			//Swap two bit like "EF" TO "FE"
			char[] c = TwoBitStr.ToCharArray();
			char t;
			t = c[0];
			c[0] = c[1];
			c[1] = t;
			return (c[0] + c[1]).ToString();
		}
		#endregion
	}
}
