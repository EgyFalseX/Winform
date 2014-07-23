using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;

namespace E_Club_Mem_Manager
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
        public LoginFrm FrmLogin;
        public AddDependentFrm FrmAddDependent;
        public AddMemAttachmentFrm FrmAddMemAttachment;
        public AddMembersFrm FrmAddMembers;
        //Codes
        public EditorAsaseFrm FrmEditorAsase;
        public EditorAttachmentTypeFrm FrmEditorAttachmentType;
        public EditorGOVFrm FrmEditorGOV;
        public EditorJobFrm FrmEditorJob;
        public EditorMarkzFrm FrmEditorMarkz;
        public EditorMembershipTypeFrm FrmEditorMembershipType;
        public EditorQualificationFrm FrmEditorQualification;
        public EditorSocialFrm FrmEditorSocial;
        public EditorSubscriptionTypeFrm FrmEditorSubscriptionType;
        public CD_FALLReasonFrm FrmCD_FALLReason;
        public CD_kinshipFrm FrmCD_kinship;
        //Queries
        public QryMemberFrm FrmQryMember;
        public QryMemInfoFrm FrmQryMemInfo;
        //Permission
        public EditorObjectTypeFrm FrmEditorObjectType;
        public EditorRoleFrm FrmEditorRole;
        public EditorUserFrm FrmEditorUser;
        public EditorUserInRoleFrm FrmEditorUserInRole;
        public EditorRoleContiansFrm FrmEditorRoleContians;
        public EditorObjectInfoFrm FrmEditorObjectInfo;
        
        //Enums
        public enum ReportType
        {
            None,
            member1,
            General,
            age,
            memberyear,
            memberupdate
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
            ReturnMe = String.Format("{0}-{1}-{2}", MyDate.Year, MyDate.Month, MyDate.Day);
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
        public bool LoadUserInfo(string userName, string userPassword)
        {
            SqlConnection con = new SqlConnection(SQLConStrMembers);
            SqlCommand cmd = new SqlCommand("", con);
            if (LoadDataTableMem("Select UserID From Users").Rows.Count == 0)
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "INSERT INTO Users (UserID, UserName, UserPass, IsActive) VALUES (1, N'admin', N'admin', 1)";
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    msg(CheckExp(ex), true, ex.Number.ToString(), new Form());
                }
                con.Close();
            }
            UserInfo = new UserInfoStruct();
            DataTable dt = LoadDataTableMem(string.Format(@"SELECT UserID FROM Users WHERE (UserName = N'{0}') AND (UserPass = N'{1}') AND (IsActive = 'True')", userName, userPassword));
            if (dt.Rows.Count > 0)
            {
                cmd.CommandText = "Update Users Set LastActivityDate = GETDATE() Where UserID = " + dt.Rows[0]["UserID"].ToString();
                con.Open();
                cmd.ExecuteNonQuery();
                UserInfo.UserID = dt.Rows[0]["UserID"].ToString();
                UserInfo.UserName = userName;
                return true;
            }
            return false;
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