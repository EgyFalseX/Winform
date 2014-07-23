using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;

namespace E_Club_Att_Manager
{
    class MCls
    {
        #region -   Variables   -
        //DB COnnections
        public string SQLConStrMalafat = "Data Source=.;Initial Catalog=MALAFAT;Integrated Security=True";
        public string SQLConStrMembers = "Data Source=.;Initial Catalog=members;Integrated Security=True";
        //Forms - Code
        public EditorHarakaTypeFrm FrmEditorHarakaType;
        public EditorShiftFrm FrmEditorShift;
        //Forms - Data
        public DataEmpAttTimeFrm FrmDataEmpAttTime;
        //Forms - General
        public DemoManagerFrm FrmDemoManager;

        //Enums / struct
        public enum RegKeyValues
        {
            SQLString, PW
        }
        public enum HarakaTypeStr
        {
            Refuse = 0, Hedoor = 1, Inseraf = 2, Azzn = 3, AzznBack = 4, Nothing = -1
        }
        #endregion
        #region -   Functions   -
        //Normal
        public static string ConvertToDateDMY(string PDate)
        {
            string ReturnMe = string.Empty;
            DateTime MyDate = Convert.ToDateTime(PDate);
            ReturnMe = MyDate.Year + "-" + MyDate.Month + "-" + MyDate.Day;
            return ReturnMe;
        }
        public static string ConvertToDateYMDhms(string PDate)
        {
            //  dd/mm/yy hh:mi:ss:mmmAM  for Convert(131).
            string ReturnMe = string.Empty;
            DateTime MyDate = Convert.ToDateTime(PDate);
            ReturnMe = MyDate.Year + "-" + MyDate.Month + "-" + MyDate.Day + " " + MyDate.Hour + ":" + MyDate.Minute + ":" + MyDate.Second;
            return ReturnMe;
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
        public static string CheckExp(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                    return "Already Exist ...";
                case 233:
                    return "Sql Server Is Not Running ...";
                case 2:
                    return "Sql Server Is Not Running ...";
                case 515:
                    string ReturnMe = "You Must Fill" + Environment.NewLine;
                    int tempint = 0;
                    foreach (char Chr in ex.Message.ToCharArray())
                    {
                        //Get column name from error msg and its between ''
                        char Dot = '\'';

                        if (Chr == Dot)
                            tempint++;
                        if (tempint == 1)
                            ReturnMe += Chr;
                        else if (tempint == 2)
                            break;
                    }
                    return ReturnMe + "'";
                default:
                    return ex.Message;
            }
        }
        //Database
        public DataTable LoadDataTableMalafat(string CommandString)
        {
            
            DataTable ReturnMe = new DataTable();
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, Program.MC.SQLConStrMalafat))
            {
                try { DA.Fill(ReturnMe); }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            return ReturnMe;
        }
        public DataTable LoadDataTable(string CommandString, string ErrorProviderStr)
        {
            ErrorProviderStr = string.Empty;
            DataTable ReturnMe = new DataTable("SocialStateTypes");
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, Program.MC.SQLConStrMalafat))
            {
                try { DA.Fill(ReturnMe); }
                catch (Exception ex)
                { ErrorProviderStr = ex.Message; }
            }
            return ReturnMe;
        }
        public static string GetAttachDefaultPath()
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                string DataToReturn = string.Empty;
                SqlCommand Cmd = new SqlCommand("SELECT TOP (1) path_attach_emp FROM ATT_company_data", Con);
                try
                {
                    Con.Open();
                    DataToReturn = Cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (DataToReturn.Length > 0)
                {
                    if (DataToReturn[DataToReturn.Length - 1].ToString() != "\\")
                    {
                        DataToReturn += "\\";
                    }
                }
                return DataToReturn;
            }
        }
        public static string GetNewIDMalafat(string TableName, string ColumnName)
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat);
            SqlCommand Cmd = new SqlCommand("SELECT ISNULL(MAX(" + ColumnName + ") + 1, 1) AS NewID FROM " + TableName + " AS NewID", Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                    dr.Read();
                ReturnMe = dr.GetValue(0).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            Con.Close();
            return ReturnMe;
        }
        //Registry Functions
        public static void PrepareReg()
        {
            RegistryKey RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            string[] arr;
            arr = Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "ECM")
                {
                    return;
                }
            }
            RegKey.CreateSubKey("ECM");
        }
        public static void SetRegValue(string KeyValue, RegKeyValues ValueName)
        {
            PrepareReg();
            RegistryKey X = Registry.LocalMachine.OpenSubKey("SOFTWARE\\ECM", true);
            X.SetValue(ValueName.ToString(), KeyValue);
        }
        public static string GetRegValue(RegKeyValues ValueName)
        {
            PrepareReg();
            string ReturnMe = string.Empty;
            string[] arr = Registry.LocalMachine.OpenSubKey("SOFTWARE\\ECM", false).GetValueNames();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ValueName.ToString())
                {
                    ReturnMe = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\ECM", false).GetValue(ValueName.ToString());
                    break;
                }
            }
            return ReturnMe;
        }
        public static void ResetConnection()
        {
            Registry.LocalMachine.DeleteSubKey("SOFTWARE\\ECM");
        }
        #endregion
    }
}