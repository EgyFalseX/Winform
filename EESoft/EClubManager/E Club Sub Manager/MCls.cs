using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;

namespace E_Club_Sub_Manager
{
    class MCls
    {
        #region -   Variables   -
        public string AttachDefaultPath;
        public UserInfoStruct UserInfo = new UserInfoStruct();
        public string ReportURL = string.Empty;
        public string ReportPath = string.Empty;
        public int SubScriptSingle = 1;
        public int SubScriptFamily = 2;
        public int SubScriptDepend = 3;
        public ReportType RepTy = ReportType.None;
        //DB COnnections
        public string SQLConStrMalafat = "Data Source=.;Initial Catalog=MALAFAT;Integrated Security=True";
        public string SQLConStrMembers = "Data Source=.;Initial Catalog=members;Integrated Security=True";
        //Forms
        public SQLConnectionFrm FrmSQLConnection;
        public AddMembershipFrm FrmAddMembership;
        public CardsFrm FrmCards;
        //Queries
        public QryMembershipFrm FrmQryMembership;
        //Permission

        //public EditorRoleFrm FrmEditorRole;
        //public EditorUserFrm FrmEditorUser;
        //public EditorUserInRoleFrm FrmEditorUserInRole;
        //public EditorRoleContiansFrm FrmEditorRoleContians;

        //Enums
        public enum ReportType
        {
            None,
            Paymentday,
            Paymentpriod,
            Paymentmember,
            Paymentpriodsum,
            Paymentlate

        }
        public enum RegKeyValues
        {
            SQLStringMember, SQLStringMalafat, ReportUrl, ReportPath
        }
        public struct UserInfoStruct
        {
            public string UserID;
            public string UserName;
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
        public static void msg(string StringMessage, bool ShowErrorNo, string StringErrorNo, Form OwnerForm)
        {
            MSGBOXFrm msgbox = new MSGBOXFrm(StringMessage, ShowErrorNo, StringErrorNo);
            msgbox.ShowDialog(OwnerForm);
        }
        public bool LoadUserInfo()
        {
            UserInfo = new UserInfoStruct();
            UserInfo.UserID = "1";
            UserInfo.UserName = "Mohamed Aly Omer";

            return true;
        }   
        //Database
        public DataTable LoadDataTable(string CommandString, string ConnString)
        {

            DataTable ReturnMe = new DataTable("FalseX2010-08");
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, ConnString))
            {
                try { DA.Fill(ReturnMe); }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            return ReturnMe;
        }
        public DataTable LoadDataTableMem(string CommandString)
        {

            DataTable ReturnMe = new DataTable("FalseX2010-08");
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, Program.MC.SQLConStrMembers))
            {
                try { DA.Fill(ReturnMe); }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
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
        public string ServerTest(string ServerName, string username, string pass)
        {
            SqlConnection Con = new SqlConnection("Data Source=" + ServerName + @";Persist Security Info=True;User ID=" + username + ";Password=" + pass);
            try
            {
                Con.Open();
                Con.Close();
                return Con.ConnectionString.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        public string ServerTest(string ServerName)
        {
            SqlConnection Con = new SqlConnection("Data Source=" + ServerName + @";Integrated Security=true");
            try
            {
                Con.Open();
                Con.Close();
                return Con.ConnectionString.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        public static DataTable GetAllDatabase(string Constr)
        {
            DataTable ReturnMe = new DataTable("FalseX2010");
            SqlConnection Con = new SqlConnection(Constr);
            SqlDataAdapter dr = new SqlDataAdapter("SELECT * FROM master.dbo.sysdatabases", Con);
            try
            {
                dr.Fill(ReturnMe);
            }
            catch (Exception)
            {
            }
            return ReturnMe;
        }
        public static DataTable GetAllDatabase(string Constr, string DatabaseName)
        {
            DataTable ReturnMe = new DataTable("FalseX2010");
            SqlConnection Con = new SqlConnection(Constr);
            SqlDataAdapter dr = new SqlDataAdapter("SELECT * FROM master.dbo.sysdatabases", Con);
            try
            {
                dr.Fill(ReturnMe);
            }
            catch (Exception)
            {
            }
            return ReturnMe;
        }
        public static bool AttachDB(string DatabaseName, string DataPath, string LogPath, string ConStr)
        {
            bool ReturnMe = false;
            SqlConnection TempCon = new SqlConnection(ConStr);
            string PConStr = "Data Source=" + TempCon.DataSource + ";Integrated Security=true";
            SqlConnection Con = new SqlConnection(PConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                //                Cmd.CommandText = @"CREATE DATABASE " + DatabaseName + @"
                //                                    ON(NAME='" + DatabaseName + @"', FILENAME='" + DataPath + @"')
                //                                    LOG ON(NAME='" + DatabaseName + @"_log', FILENAME='" + LogPath + @"')
                //                                    FOR ATTACH WITH ENABLE_BROKER;";
                Cmd.CommandText = "EXEC sp_attach_db @dbname = N'" + DatabaseName + "', @filename1 = N'" + DataPath + "',@filename2 = N'" + LogPath + "'";
                if (Cmd.ExecuteNonQuery() != 0)
                    ReturnMe = true;
                else
                    ReturnMe = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ReturnMe = false;
            }
            Con.Close();
            return ReturnMe;
        }
        public static bool AttachDB(string DatabaseName, string DataPath, string ConStr)
        {
            //FOR ATTACH_REBUILD_LOG
            bool ReturnMe = false;
            SqlConnection TempCon = new SqlConnection(ConStr);
            string PConStr = "Data Source=" + TempCon.DataSource + ";Integrated Security=true";
            SqlConnection Con = new SqlConnection(PConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = @"CREATE DATABASE " + DatabaseName + @"
                                    ON(NAME='" + DatabaseName + @"', FILENAME='" + DataPath + @"')
                                    FOR ATTACH_REBUILD_LOG;";
                if (Cmd.ExecuteNonQuery() != 0)
                    ReturnMe = true;
                else
                    ReturnMe = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ReturnMe = false;
            }
            Con.Close();
            return ReturnMe;
        }
        public static void DeAttachDB(string ConStr, string DBName)
        {
            SqlConnection Con = new SqlConnection(ConStr);
            SqlCommand Cmd = new SqlCommand("Use Master EXEC SP_Detach_db " + DBName, Con);
            try
            {
                Con.Open();
                Con.ChangeDatabase("Master");
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }
        public static string GetNewIDMember(string TableName, string ColumnName)
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers);
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
        public static void SetRegValue(string KeyValue, string ValueName)
        {
            PrepareReg();
            RegistryKey X = Registry.LocalMachine.OpenSubKey("SOFTWARE\\ECM", true);
            X.SetValue(ValueName, KeyValue);

        }
        public static string GetRegValue(string ValueName)
        {
            PrepareReg();
            string ReturnMe = string.Empty;
            string[] arr = Registry.LocalMachine.OpenSubKey("SOFTWARE\\ECM", false).GetValueNames();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ValueName)
                {
                    ReturnMe = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\ECM", false).GetValue(ValueName);
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