using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.ServiceProcess;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FunctionLib
{
    public class MCls
    {
        #region -   Variables   -
        //Normal
        public UserInfoStruct UserInfo = new UserInfoStruct();
        public string ReportURL = string.Empty;
        public string ReportPath = string.Empty;
        //Database connection
        public static string SQLConStr = string.Empty;//String.Format("Data Source={0};Persist Security Info=True;User ID=sa;Password=mysqlpass", System.Environment.MachineName);
        public string DataChacked = string.Empty;
        public string ServerIP = string.Empty;
        public string GeneralPort = string.Empty;
        public string DeletedFilesPath = string.Empty;

        //Forms
        //public SQLConnectionFrm FrmSQLConnection;

        public ReportType RepTy = ReportType.None;
        //Enums
        public enum ReportType
        {
            None
        }
        public enum RegKeyValues
        {
            SQLString,
            DataChacked,
            ServerIP,
            GeneralPort,
            DeletedFilesPath,
            ReportUrl,
            ReportPath
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
        public static object changeArrayLength(object Arr, bool Plus)
        {
            Array[] ReturnMe = (Array[])Arr;
            if (Arr == null)
                Array.Resize(ref ReturnMe, 1);
            else
            {
                if (Plus)
                    Array.Resize(ref ReturnMe, ReturnMe.Length + 1);
                else
                    Array.Resize(ref ReturnMe, ReturnMe.Length - 1);
            }
            return ReturnMe;
        }
        public static void msg(string StringMessage, bool ShowErrorNo, string StringErrorNo, Form OwnerForm)
        {
            using (MSGBOXFrm msgbox = new MSGBOXFrm(StringMessage, ShowErrorNo, StringErrorNo))
            {
                msgbox.ShowDialog(OwnerForm);
            }
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
        public bool LoadUserInfo(string username, string password)
        {
            DataTable TblUser = new DataTable("");
            TblUser = LoadDataTable(@"SELECT UserID, UserName, UserPass, IsActive FROM Users
                                      WHERE (UserName = N'" + username + "') AND (UserPass = N'" + password + "') AND (IsActive = 1)", "");
            foreach (DataRow row in TblUser.Rows)
            {
                UserInfo = new UserInfoStruct();
                UserInfo.UserID = row["UserID"].ToString();
                UserInfo.UserName = row["UserName"].ToString();
                return true;
            }
            return false;
        }
        //Database
        public static DataTable LoadDataTable(string CommandString, string ErrorProviderStr)
        {
            ErrorProviderStr = string.Empty;
            DataTable ReturnMe = new DataTable("False2010-10");
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, MCls.SQLConStr))
            {
                try { DA.Fill(ReturnMe); }
                catch (SqlException ex)
                { ErrorProviderStr = ex.Message; }
            }

            return ReturnMe;
        }
        public static DataTable LoadDataTable(string CommandString, bool MultiResult)
        {

            DataSet DS = new DataSet("False2011-03");
            using (SqlDataAdapter DA = new SqlDataAdapter(CommandString, MCls.SQLConStr))
            {
                try 
                {
                    DA.Fill(DS);
                    if (DS.Tables.Count > 1)
                        DS.Tables[0].Merge(DS.Tables[1]);
                }
                catch (SqlException ex)
                {
                    msg(ex.Message, true, "", new Form());
                }
            }

            return DS.Tables[0];
        }
        public static string ServerTest(string ServerName, string username, string pass)
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
        public static string ServerTest(string ServerName)
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
            catch (SqlException)
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
            catch (SqlException ex)
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                ReturnMe = false;
            }
            Con.Close();
            return ReturnMe;
        }
        public static string GetNewID(string TableName, string ColumnName)
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(MCls.SQLConStr);
            SqlCommand Cmd = new SqlCommand(String.Format("SELECT ISNULL(MAX({0}) + 1, 1) AS NewID FROM {1} AS NewID", ColumnName, TableName), Con);
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
                msg(ex.Message, true, ex.ErrorCode.ToString(), new Form());
            }
            Con.Close();
            return ReturnMe;
        }
        public static void GetFormPriv(string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;
            DataTable Priv = MCls.LoadDataTable(string.Format(@"SELECT RoleDetial.Selecting, RoleDetial.Inserting, RoleDetial.Updateing, RoleDetial.Deleting FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID
            WHERE (UserRoles.UserId = {0}) AND (RoleDetial.MenuItemName = N'{1}')", Program.MC.UserInfo.UserID, FormName), "");
            foreach (DataRow row in Priv.Rows)
            {
                if (row["Selecting"].ToString() == "True")
                    Selecting = true;
                if (row["Inserting"].ToString() == "True")
                    Inserting = true;
                if (row["Updateing"].ToString() == "True")
                    Updateing = true;
                if (row["Deleting"].ToString() == "True")
                    Deleting = true;
            }
        }
        #region -   Database Backup   -
        public static void DatabaseBackup(string DesPath, ref ProgressBar PB)
        {
            DataTable Pathz = MCls.LoadDataTable("SELECT filename FROM sys.sysfiles", "");
            string DBFile = string.Empty, DBLog = string.Empty;
            DBFile = Pathz.Rows[0][0].ToString();
            DBLog = Pathz.Rows[1][0].ToString();
            string NewDBFile = string.Empty, NewDBLog = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog { FileName = DBFile };
            NewDBFile = String.Format(@"{0}\{1}", DesPath, ofd.SafeFileName);
            ofd.FileName = DBLog;
            NewDBLog = String.Format(@"{0}\{1}", DesPath, ofd.SafeFileName);
            if (!File.Exists(DBFile) || !File.Exists(DBLog))
            {
                msg("Can't Backup, Database file not found ...!", true, "None", new Form());
                return;
            }
            PB.Value += 1;
            StopService("MSSQLSERVER", 120000);
            PB.Value += 1;
            Application.DoEvents();
            File.Copy(DBFile, NewDBFile, true);
            File.Copy(DBLog, NewDBLog, true);
            PB.Value += 1;
            Application.DoEvents();
            StartService("MSSQLSERVER", 120000);
            Application.DoEvents();
        }
        public static void DatabaseRestore(string DBFile, string DBLog, ref ProgressBar PB)
        {
            DataTable Pathz = MCls.LoadDataTable("SELECT filename FROM sys.sysfiles", "");
            string NewDBFile = string.Empty, NewDBLog = string.Empty;
            NewDBFile = Pathz.Rows[0][0].ToString();
            NewDBLog = Pathz.Rows[1][0].ToString();
            if (!File.Exists(DBFile) || !File.Exists(DBLog))
            {
                msg("Can't Restore, Database file not found ...!", true, "None", new Form());
                return;
            }
            PB.Value += 1;
            StopService("MSSQLSERVER", 120000);
            PB.Value += 1;
            Application.DoEvents();
            File.Copy(DBFile, NewDBFile, true);
            File.Copy(DBLog, NewDBLog, true);
            PB.Value += 1;
            Application.DoEvents();
            StartService("MSSQLSERVER", 120000);
            Application.DoEvents();
        }
        public static void StartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch (Exception ex)
            {
                msg(ex.Message, true, "None", new Form());
            }
        }
        public static void StopService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch (Exception ex)
            {
                msg(ex.Message, true, "None", new Form());
            }
        }
        #endregion
        //Registry Functions
        #region -   Registry   -
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
        public static void SetRegValue(string KeyValue, string ValueName)
        {
            PrepareReg();
            RegistryKey X = Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", true);
            X.SetValue(ValueName, KeyValue);

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
        public static void ResetConnection()
        {
            Registry.LocalMachine.DeleteSubKey("SOFTWARE\\DataCenter");
        }
        #endregion

        #endregion
    }
    public class DataCenterServerLib
    {
        #region -   Variables   -
        //Vars SQLClient
        public SqlConnection SQLCon = new SqlConnection("");
        private SqlDataReader SQLDR;
        private SqlTransaction SQLTrn;
        public SqlCommand SQLCmd;
        //Var Structure
        public struct FolderFileInfo
        {
            public string ID;
            public bool Found;
            public string FileName;
            public string FilePath;
            public FolderAndFile type;
        }
        public FolderFileInfo[] FolderFileList = new FolderFileInfo[1];
        public struct FolderInfo
        {
            public string FolderID;
            public string FolderName;
            public string FolderPath;
            public string UserID;
            public string CreatedIn;
            public string Disc;
            public string ProID;
            public string ParentID;
            public FileInfo[] Files;
        }
        //public FolderInfo[] Folders = new FolderInfo[1];
        public struct FileInfo
        {
            public string FileID;
            public string FileName;
            public string FilePath;
            public string CreatedIn;
            public string UsrID;
            public string Dis;
            public string ProID;
            public string FolderID;
            public string TypeID;
            public string UserName;
            public string TypeName;
            public string TypePath;
        }
        public enum FolderAndFile
        {
            Folder,
            File
        }
        public FolderAndFile FolderFileType;
        public enum RegKeyValues
        {
            SQLString,
            PW,
            DataChacked,
            ServerIP,
            GeneralPort,
            DeletedFilesPath
        }
        public struct privilegeType
        {
            public string privilegeName;
            public string privilegeID;
            public bool privilegeSelected;
            public int CanAdd;
            public int CanView;
            public int CanWrite;
            public int CanDelete;
        }
        public privilegeType[] Allprivilege = new privilegeType[1];
        public privilegeType[] AllUsersF = new privilegeType[1];
        public struct UsersInfo
        {
            //This type have all information about users
            public string UserID;
            public string UserName;
            public string UserPassword;
        }
        public struct FilesType
        {
            public string TypeID;
            public string TypeName;
            public string TypeIcon;
            public string TypeExt;
            public string TypeDesc;
        }
        public FilesType[] AllFilesType;
        public struct ProjectWithprivilegesType
        {
            public string ProjectID;
            public string ProjectName;
            public privilegeType[] InternalPrivileges;
        }
        public ProjectWithprivilegesType[] AllProjectWithPrivileges;
        public struct UserInfoType
        {
            public string UsrID;
            public string UserName;
        }
        public UserInfoType[] AllUsers;
        public struct ConsultantType
        {
            public string ConsID;
            public string ConsName;
            public string ConsAddress;
            public string ConsMob1;
            public string ConsMob2;
            public string ConsPho1;
            public string ConsPho2;
            public string ConsEmail1;
            public string ConsEmail2;
            public string ConsCVPath;
            public string Selected;
        }
        public ConsultantType[] AllConsultanats;
        public struct ContractorType
        {
            public string ContID;
            public string ContName;
            public string ContAddress;
            public string ContMob1;
            public string ContMob2;
            public string ContPho1;
            public string ContPho2;
            public string ContEmail1;
            public string ContEmail2;
            public string Selected;
        }
        public ContractorType[] AllContractors;
        public struct ClientType
        {
            public string ClientID;
            public string ClientName;
            public string ClientAddress;
            public string ClientMob1;
            public string ClientMob2;
            public string ClientPho1;
            public string ClientPho2;
            public string ClientMail1;
            public string ClientMail2;
        }
        public ClientType[] AllClients;
        public struct LockedFilesSTR
        {
            public string FileID;
            public string FileName;
            public string FilePath;
            public string ProjectName;
            public string UsrID;
            public string UsrName;
        }
        public struct ProjectInfo
        {
            public string ProjectID;
            public string PrjectName;
            public string ProjectLocation;
            public string ProjectStart;
            public string projectExp;
            public string ProjectEnd;
            public string ProjectBudget;
        }
        #endregion

        public DataCenterServerLib()
        {
            SQLCmd = new SqlCommand("", SQLCon, SQLTrn);

        }
        //Functions and subs
        public void ServerTest(string ServerName, string UserID, string UserPW, ref bool Done)
        {
            try
            {
                SQLCon.ConnectionString = String.Format("Data Source={0};User ID={1};Password={2}", ServerName, UserID, UserPW);
                SQLCon.Open();
                Done = true;
            }
            catch (Exception)
            {
                Done = false;
            }
            SQLCon.Close();
        }
        public void AttachDB(string DataPath, ref bool Done)
        {
            try
            {
                SQLCmd.CommandText = String.Format("EXEC sp_attach_single_file_db @dbname = 'DataCenter', @physname = '{0}'", DataPath);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
                Done = true;
            }
            catch (Exception)
            {
                Done = false;
            }
            SQLCon.Close();
        }
        public void AttachDB(string DataPath, string LogPath, ref bool Done)
        {
            try
            {
                SQLCmd.CommandText = String.Format("EXEC sp_attach_db @dbname = N'DataCenter', @filename1 = N'{0}',@filename2 = N'{1}'", DataPath, LogPath);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
                Done = true;
            }
            catch (Exception)
            {
                Done = false;
            }
            SQLCon.Close();
        }
        public string[] GetAllDatabase()
        {
            string[] DatBaseNames = new string[0];
            try
            {
                SQLCmd.CommandText = "SELECT * FROM master.dbo.sysdatabases";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (DatBaseNames.Length == 0)
                    {
                        DatBaseNames = new string[1];
                    }
                    else
                    {
                        Array.Resize(ref DatBaseNames, DatBaseNames.Length + 1);
                    }
                    DatBaseNames[DatBaseNames.Length - 1] = SQLDR.GetString(0).Trim();
                }
            }
            catch (Exception)
            {
                SQLDR.Close();
                SQLCon.Close();
                return null;
            }
            SQLDR.Close();
            SQLCon.Close();
            return DatBaseNames;
        }
        public bool SALogin(string SAName, string SAPassword)
        {
            try
            {
                SQLCmd.CommandText = String.Format("select SAName,SAPassword from SA where SAName='{0}' and SAPassword='{1}'", SAName, SAPassword);
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                if (SQLDR.HasRows == true)
                {
                    SQLDR.Close();
                    SQLCon.Close();
                    return true;
                }
                else
                {
                    SQLDR.Close();
                    SQLCon.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
            return false;
        }
        public string GetServerOption(ref string DefaultUserPassword, ref string ProjectsPath, ref string RelatedFiles, ref string DeletedFilesPath, ref string serverIP, ref string serverPort, ref string StudentFilesPath, ref string EmpFilesPath)
        {
            try
            {
                SQLCmd.CommandText = "SELECT ProjectsPath,RelatedFiles,DeletedFilesPath,ServerIP,ServerPort,DefaultUserPassword,StudentFilesPath, EmpFilesPath FROM dbo.ServerOption";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (SQLDR.IsDBNull(0) == false)
                        ProjectsPath = SQLDR.GetValue(0).ToString().Trim();
                    if (SQLDR.IsDBNull(1) == false)
                        RelatedFiles = SQLDR.GetValue(1).ToString().Trim();
                    if (SQLDR.IsDBNull(2) == false)
                        DeletedFilesPath = SQLDR.GetValue(2).ToString().Trim();
                    if (SQLDR.IsDBNull(3) == false)
                        serverIP = SQLDR.GetValue(3).ToString().Trim();
                    if (SQLDR.IsDBNull(4) == false)
                        serverPort = SQLDR.GetValue(4).ToString().Trim();
                    if (SQLDR.IsDBNull(5) == false)
                        DefaultUserPassword = SQLDR.GetValue(5).ToString().Trim();
                    if (SQLDR.IsDBNull(6) == false)
                        StudentFilesPath = SQLDR.GetValue(6).ToString().Trim();
                    if (SQLDR.IsDBNull(7) == false)
                        EmpFilesPath = SQLDR.GetValue(7).ToString().Trim();
                }
            }
            catch (SqlException ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string SaveServerOptions(string DefaultUserPassword, string ProjectsPath, string RelatedFiles, string DeletedFilesPath, string StudentFilesPath, string EmpFilesPath)
        {
            try
            {
                SQLCmd.CommandText = String.Format("UPDATE ServerOption SET DefaultUserPassword='{0}',ProjectsPath='{1}',RelatedFiles='{2}',DeletedFilesPath='{3}', StudentFilesPath = '{4}', EmpFilesPath = '{5}'", DefaultUserPassword, ProjectsPath, RelatedFiles, DeletedFilesPath, StudentFilesPath, EmpFilesPath);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string SaveClientOptions(string ServerIP, string ServerPort)
        {
            try
            {
                SQLCmd.CommandText = String.Format("UPDATE dbo.ServerOption SET ServerIP='{0}',ServerPort='{1}'", ServerIP, ServerPort);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public void GetAllFolderFile(string ProjectPath)
        {
            FolderFileList = new FolderFileInfo[1];
            try
            {
                SQLCmd.CommandText = "select FolderID,FolderName,FolderPath from FolderInfo";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    FolderFileList[FolderFileList.Length - 1].ID = SQLDR.GetValue(0).ToString().Trim();
                    FolderFileList[FolderFileList.Length - 1].FileName = SQLDR.GetValue(1).ToString().Trim();
                    FolderFileList[FolderFileList.Length - 1].FilePath = ProjectPath + SQLDR.GetValue(2).ToString().Trim();
                    FolderFileList[FolderFileList.Length - 1].type = FolderAndFile.Folder;
                    Array.Resize(ref FolderFileList, FolderFileList.Length + 1);
                }
                Array.Resize(ref FolderFileList, FolderFileList.Length - 2 + 1);
                SQLDR.Close();
                SQLCmd.CommandText = "select FileID,FileName,FilePath from FileInfo";
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    FolderFileList[FolderFileList.Length - 1].ID = SQLDR.GetValue(0).ToString().Trim();
                    FolderFileList[FolderFileList.Length - 1].FileName = SQLDR.GetValue(1).ToString().Trim();
                    FolderFileList[FolderFileList.Length - 1].FilePath = ProjectPath + SQLDR.GetValue(2).ToString().Trim();
                    FolderFileList[FolderFileList.Length - 1].type = FolderAndFile.File;
                    Array.Resize(ref FolderFileList, FolderFileList.Length + 1);
                }
                Array.Resize(ref FolderFileList, FolderFileList.Length - 2 + 1);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public void GetFoldersOrdered_ThenGetFiles1(string DataPath)
        {
            //Folders = new FolderInfo[1];
            //try
            //{
            //    SQLCmd.CommandText = "select FolderID,FolderName,FolderPath,UserID,CreatedIn,Disc,ProID,ParentID from dbo.FolderInfo order by FolderPath";
            //    SQLCon.Open();
            //    SQLDR = SQLCmd.ExecuteReader();
            //    while (SQLDR.Read())
            //    {
            //        Folders[Folders.Length - 1].FolderID = SQLDR.GetValue(0).ToString().Trim();
            //        Folders[Folders.Length - 1].FolderName = SQLDR.GetValue(1).ToString().Trim();
            //        Folders[Folders.Length - 1].FolderPath = DataPath + SQLDR.GetValue(2).ToString().Trim();
            //        Folders[Folders.Length - 1].UserID = SQLDR.GetValue(3).ToString().Trim();
            //        Folders[Folders.Length - 1].CreatedIn = SQLDR.GetValue(4).ToString().Trim();
            //        Folders[Folders.Length - 1].Disc = SQLDR.GetValue(5).ToString().Trim();
            //        Folders[Folders.Length - 1].ProID = SQLDR.GetValue(6).ToString().Trim();
            //        Folders[Folders.Length - 1].ParentID = SQLDR.GetValue(7).ToString().Trim();
            //        Array.Resize(ref Folders, Folders.Length + 1);
            //    }
            //    Array.Resize(ref Folders, Folders.Length - 2 + 1);
            //}
            //catch (Exception ex)
            //{
            //    Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            //}
            //SQLDR.Close();
            //SQLCon.Close();
            //GetAllFiles(DataPath);
        }
        private void GetAllFiles1(string DataPath)
        {
            //try
            //{
            //    SQLCmd.CommandText = "SP_GetAllFiles";
            //    SQLCon.Open();
            //    SQLDR = SQLCmd.ExecuteReader();
            //    short Int1 = (short)0;
            //    while (SQLDR.Read())
            //    {
            //        for (Int1 = 0; Int1 <= Folders.Length - 1; Int1++)
            //        {
            //            if (SQLDR.GetValue(7).ToString().Trim() == Folders[Int1].FolderID)
            //            {
            //                if (Folders[Int1].Files == null)
            //                {
            //                    Folders = new FolderInfo[Int1 + 1];
            //                }
            //                else
            //                {
            //                    Array.Resize(ref Folders, Int1 + 1);
            //                }
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].FileID = SQLDR.GetValue(0).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].FileName = SQLDR.GetValue(1).ToString().Trim();
            //                //The File Path = DataPath & the Database File Path :)
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].FilePath = DataPath + SQLDR.GetValue(2).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].CreatedIn = SQLDR.GetValue(3).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].UsrID = SQLDR.GetValue(4).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].Dis = SQLDR.GetValue(5).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].ProID = SQLDR.GetValue(6).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].FolderID = SQLDR.GetValue(7).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].TypeID = SQLDR.GetValue(8).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].UserName = SQLDR.GetValue(9).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].TypeName = SQLDR.GetValue(10).ToString().Trim();
            //                Folders[Int1].Files[Folders[Int1].Files.Length - 1].TypePath = SQLDR.GetValue(11).ToString().Trim();
            //                break;
            //            }
            //        }
            //        if (SQLDR.NextResult() == true)
            //        {
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            //}
            //SQLDR.Close();
            //SQLCon.Close();
        }
        public void GetWhoCreateit(string UserID, ref string UserName)
        {
            try
            {
                SQLCmd.CommandText = String.Format("select UserName from dbo.Users where UsrID='{0}'", UserID);
                SQLCon.Open();
                UserName = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                UserName = "Unknow";
            }
            SQLCon.Close();
        }
        public void GetProjectName(string ProID, ref string ProjectName)
        {
            try
            {
                SQLCmd.CommandText = String.Format("select ProName from dbo.Projects where ProID='{0}'", ProID);
                SQLCon.Open();
                ProjectName = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                ProjectName = "Unknow";
            }
            SQLCon.Close();
        }
        public void GetAllprivilege()
        {
            try
            {
                Allprivilege = new privilegeType[1];
                SQLCmd.CommandText = "select RullID,RullName from dbo.Rulls";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    Allprivilege[Allprivilege.Length - 1].privilegeID = SQLDR.GetValue(0).ToString().Trim();
                    Allprivilege[Allprivilege.Length - 1].privilegeName = SQLDR.GetValue(1).ToString().Trim();
                    Allprivilege[Allprivilege.Length - 1].privilegeSelected = false;
                    Allprivilege[Allprivilege.Length - 1].CanDelete = 0;
                    Allprivilege[Allprivilege.Length - 1].CanWrite = 0;
                    Allprivilege[Allprivilege.Length - 1].CanAdd = 0;
                    Allprivilege[Allprivilege.Length - 1].CanView = 0;
                    Array.Resize(ref Allprivilege, Allprivilege.Length + 1);
                }
                Array.Resize(ref Allprivilege, Allprivilege.Length - 2 + 1);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public void GetAllUsers()
        {
            try
            {
                AllUsersF = new privilegeType[1];
                SQLCmd.CommandText = "select UsrID,UserName from Users";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    AllUsersF[AllUsersF.Length - 1].privilegeID = SQLDR.GetValue(0).ToString().Trim();
                    AllUsersF[AllUsersF.Length - 1].privilegeName = SQLDR.GetValue(1).ToString().Trim();
                    AllUsersF[AllUsersF.Length - 1].privilegeSelected = false;
                    AllUsersF[AllUsersF.Length - 1].CanDelete = 0;
                    AllUsersF[AllUsersF.Length - 1].CanWrite = 0;
                    AllUsersF[AllUsersF.Length - 1].CanAdd = 0;
                    AllUsersF[AllUsersF.Length - 1].CanView = 0;
                    Array.Resize(ref AllUsersF, AllUsersF.Length + 1);
                }
                Array.Resize(ref AllUsersF, AllUsersF.Length - 2 + 1);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public void GetSelectedFolderprivilege(string FolderID)
        {
            try
            {
                GetAllprivilege();
                SQLCmd.CommandText = String.Format("select RullID, CanWrite, CanDelete, CanAdd, CanView from Folder_Rull where FolderID = '{0}'", FolderID);
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                string RullID = "";
                while (SQLDR.Read())
                {
                    RullID = SQLDR.GetValue(0).ToString().Trim();
                    int i = 0;
                    for (i = 0; i <= Allprivilege.Length - 1; i++)
                    {
                        if (RullID == Allprivilege[i].privilegeID)
                        {
                            Allprivilege[i].privilegeSelected = true;
                            Allprivilege[i].CanWrite = int.Parse(SQLDR.GetValue(1).ToString().Trim());
                            Allprivilege[i].CanDelete = int.Parse(SQLDR.GetValue(2).ToString().Trim());
                            Allprivilege[i].CanAdd = int.Parse(SQLDR.GetValue(3).ToString().Trim());
                            Allprivilege[i].CanView = int.Parse(SQLDR.GetValue(4).ToString().Trim());
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public void GetSelectedFolderUser(string FolderID)
        {
            try
            {
                GetAllUsers();
                SQLCmd.CommandText = String.Format("select UsrID, CanWrite, CanDelete, CanAdd, CanView from Folder_User where FolderID = '{0}'", FolderID);
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                string RullID = "";
                while (SQLDR.Read())
                {
                    RullID = SQLDR.GetValue(0).ToString().Trim();
                    int i = 0;
                    for (i = 0; i <= AllUsersF.Length - 1; i++)
                    {
                        if (RullID == AllUsersF[i].privilegeID)
                        {
                            AllUsersF[i].privilegeSelected = true;
                            AllUsersF[i].CanWrite = int.Parse(SQLDR.GetValue(1).ToString().Trim());
                            AllUsersF[i].CanDelete = int.Parse(SQLDR.GetValue(2).ToString().Trim());
                            AllUsersF[i].CanAdd = int.Parse(SQLDR.GetValue(3).ToString().Trim());
                            AllUsersF[i].CanView = int.Parse(SQLDR.GetValue(4).ToString().Trim());
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public void SaveFolderprivileges1(string FolderID, privilegeType[] privilegesID, bool AddOrRemove)
        {
            if (privilegesID == null)
                return;
            try
            {
                SQLCon.Open();
                SQLTrn = SQLCon.BeginTransaction("[Egy]FalseX");
                SQLCmd.Transaction = SQLTrn;
                short Int1;
                if (AddOrRemove == true)
                {
                    for (Int1 = 0; Int1 <= privilegesID.Length - 1; Int1++)
                    {
                        SQLCmd.CommandText = String.Format("SP_InsertNewFolderPrivilege @FolderID='{0}', @RullID='{1}', @CanWrite='{2}', @CanDelete='{3}'", FolderID, privilegesID[Int1].privilegeID, privilegesID[Int1].CanWrite, privilegesID[Int1].CanDelete);
                        SQLCmd.ExecuteNonQuery();
                        SQLCmd.CommandText = String.Format("SP_InsertNewFolderParentPrivilege @FolderID='{0}', @RullID='{1}'", FolderID, privilegesID[Int1].privilegeID);
                        SQLCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    for (Int1 = 0; Int1 <= privilegesID.Length - 1; Int1++)
                    {
                        SQLCmd.CommandText = String.Format("SP_DeleteFolderPrivilege @FolderID='{0}', @RullID='{1}'", FolderID, privilegesID[Int1].privilegeID);
                        SQLCmd.ExecuteNonQuery();
                    }
                }
                SQLTrn.Commit();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                SQLTrn.Rollback();
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public string SaveFolderDesc(string FolderID, string Desc)
        {
            try
            {
                SQLCmd.CommandText = String.Format("update dbo.FolderInfo set Disc='{0}' where FolderID='{1}'", Desc, FolderID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public bool ChagneFolderName(string FolderID, string FolderName, string NewPath, string ProjectPath)
        {
            short steps = 0;
            DataRow FolderInfo_ = MCls.LoadDataTable(String.Format("Select FolderName, FolderPath, FolderName From FolderInfo Where FolderID = N'{0}'", FolderID), "").Rows[0];
            try
            {
                //Get all folders that inside the selected folder to rename therer pathes
                string FullPath = FolderInfo_["FolderPath"].ToString();
                DataTable FoldersToChage = MCls.LoadDataTable(string.Format("Select FolderID, FolderPath from FolderInfo Where FolderPath LIKE '%{0}%'", FullPath), "");
                //Get all files that inside the selected folder to rename therer pathes
                DataTable FilesToChage = MCls.LoadDataTable(string.Format("Select FileID, FilePath, FileName from FileInfo Where FilePath LIKE '%{0}%'", FullPath), "");
                //Renaming folders
                SqlCommand SqlCmd2 = new SqlCommand("", SQLCon, SQLTrn);
                SQLCon.Open();
                SQLTrn = SQLCon.BeginTransaction("Eshta ya rgala");
                SqlCmd2.Transaction = SQLTrn;
                string NewPath2;
                foreach (DataRow row in FoldersToChage.Rows)
                {
                    NewPath2 = row["FolderPath"].ToString().Replace(FolderInfo_["FolderName"].ToString(), FolderName);
                    SqlCmd2.CommandText = String.Format("Update dbo.FolderInfo set FolderPath = N'{0}' where FolderID = N'{1}'", NewPath2, row["FolderID"]);
                    SqlCmd2.ExecuteNonQuery();

                }
                SqlCmd2.CommandText = String.Format("update dbo.FolderInfo set FolderName = N'{0}' where FolderID = N'{1}'", FolderName, FolderID);
                SqlCmd2.ExecuteNonQuery();
                //Renaming files
                foreach (DataRow row in FilesToChage.Rows)
                {
                    NewPath2 = row["FilePath"].ToString().Replace(FolderInfo_["FolderName"].ToString(), FolderName);
                    SqlCmd2.CommandText = String.Format("Update dbo.FileInfo set FilePath = N'{0}' where FileID = N'{1}'", NewPath2, row["FileID"]);
                    SqlCmd2.ExecuteNonQuery();
                }
               
                //Renaming the Phy folder inside the hard disk
                if (Directory.Exists(ProjectPath + FolderInfo_["FolderPath"]))
                {
                    if (ProjectPath + FolderInfo_["FolderPath"] != NewPath)
                    {
                        Directory.Move(ProjectPath + FolderInfo_["FolderPath"], ProjectPath + NewPath);
                        steps = 1;
                    }
                    SQLTrn.Commit();
                    SQLDR.Close();
                    SQLCon.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                if (steps == 1)
                {
                    try
                    {
                        Directory.Move(NewPath, ProjectPath + FolderInfo_["FolderPath"].ToString());
                        SQLDR.Close();
                        SQLCon.Close();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(String.Format("Critical problem{0}{1}Cant rename or move folder '{2}' to folder'{3}", Constants.vbNewLine, ex2.Message, NewPath, FolderInfo_["FolderPath"].ToString()));
                        SQLTrn.Rollback();
                        SQLDR.Close();
                        SQLCon.Close();
                        return false;
                    }
                }
                SQLTrn.Rollback();
                SQLDR.Close();
                SQLCon.Close();
                return false;
            }
            SQLCon.Close();
            return false;
        }
        public string AddNewConsultants(string TxtName, string TxtAddress, string Txtpho1, string TxtPho2, string TxtMob1, string TxtMob2, string TxtMail1, string Txtmail2, string CVPath)
        {
            try
            {
                string Result = "";
                SQLCmd.CommandText = String.Format("SP_InsertNewConsultants @ConsName='{0}',@ConsAddress='{1}',@ConsMob1='{2}',@ConsMob2='{3}',@ConsPho1='{4}',@ConsPho2='{5}',@ConsEmail1='{6}',@ConsEmail2='{7}',@ConsCVPath='{8}',@Anyway='0'", TxtName, TxtAddress, TxtMob1, TxtMob2, Txtpho1, TxtPho2, TxtMail1, Txtmail2, CVPath);
                SQLCon.Open();
                Result = (string)(SQLCmd.ExecuteScalar());
                if (Result.Trim() == "no")
                {
                    short i;
                    i = (short)(Interaction.MsgBox(String.Format("Consultants Name: {0} Already exist{1}Do you need to save it anyway?", TxtName, Constants.vbNewLine), MsgBoxStyle.YesNo, "Same Name..."));
                    if (i == 6)
                    {
                        SQLCmd.CommandText = String.Format("SP_InsertNewConsultants @ConsName='{0}',@ConsAddress='{1}',@ConsMob1='{2}',@ConsMob2='{3}',@ConsPho1='{4}',@ConsPho2='{5}',@ConsEmail1='{6}',@ConsEmail2='{7}',@ConsCVPath='{8}',@Anyway='1'", TxtName, TxtAddress, TxtMob1, TxtMob2, Txtpho1, TxtPho2, TxtMail1, Txtmail2, CVPath);
                        SQLCmd.ExecuteScalar();
                    }
                    else
                    {
                        SQLDR.Close();
                        SQLCon.Close();
                        return "no";
                    }
                }
            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return "yes";
        }
        public string GetAllFilesType1(string RelatedFiles)
        {
            AllFilesType = new FilesType[1];
            try
            {
                SQLCmd.CommandText = "select TypeID,TypeName,TypeIconData,TypeDic,TypeExt from dbo.FileType";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    AllFilesType[AllFilesType.Length - 1].TypeID = SQLDR.GetValue(0).ToString().Trim();
                    AllFilesType[AllFilesType.Length - 1].TypeName = SQLDR.GetValue(1).ToString().Trim();
                    if (SQLDR.GetValue(2).ToString().Trim() == "")
                    {
                        AllFilesType[AllFilesType.Length - 1].TypeIcon = "";
                    }
                    else
                    {
                        AllFilesType[AllFilesType.Length - 1].TypeIcon = RelatedFiles + SQLDR.GetValue(2).ToString().Trim();
                    }
                    AllFilesType[AllFilesType.Length - 1].TypeDesc = SQLDR.GetValue(3).ToString().Trim();
                    AllFilesType[AllFilesType.Length - 1].TypeExt = SQLDR.GetValue(4).ToString().Trim();
                    Array.Resize(ref AllFilesType, AllFilesType.Length + 1);
                }
                Array.Resize(ref AllFilesType, AllFilesType.Length - 2 + 1);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public void InsertNewFile(string FileName, string FilePath, string CreatedIn, string UsrID, string Dis, string FolderID, string TypeID, ref string Result)
        {
            try
            {
                SQLCmd.CommandText = String.Format("SP_InsertNewFile @FileName='{0}',@FilePath='{1}',@CreatedIn='{2}',@UsrID='{3}',@Dis='{4}',@FolderID='{5}',@TypeID='{6}'", FileName, FilePath, CreatedIn, UsrID, Dis, FolderID, TypeID);
                SQLCon.Open();
                Result = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public string Small_File_Transfer(string SourcePath, string TargetPath, string Extension)
        {
            try
            {
                short Int1 = 0;
                string[] FilePathFolders = SourcePath.Split("\\".ToCharArray());
                string NewFileName = FilePathFolders[FilePathFolders.Length - 1];
                for (Int1 = 0; Int1 <= 10000; Int1++)
                {
                    NewFileName = String.Format("{0}\\{1}_{2}.{3}", TargetPath, FilePathFolders[FilePathFolders.Length - 1], Int1, Extension);
                    if (!File.Exists(NewFileName))
                    {
                        //Copying File
                        File.Copy(SourcePath, NewFileName, true);
                        return NewFileName;
                    }
                }
            }
            catch (Exception)
            {
                return "Error";
            }
            return "";
        }
        public string EditFileInfo(string FileID, string NewFileName, string NewDescription)
        {
            try
            {
                SQLCmd.CommandText = String.Format("Update dbo.FileInfo set FileName='{0}' , Dis='{1}' where FileID='{2}'", NewFileName, NewDescription, FileID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string RemoveFile(string FileID)
        {
            try
            {
                SQLCmd.CommandText = String.Format("delete from FileInfo where FileID='{0}'", FileID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                SQLCon.Close();
                FunctionLib.MCls.msg(FunctionLib.MCls.CheckExp(ex), true, ex.Number.ToString(), new Form());
                return (ex.Message);
            }
            SQLCon.Close();
            return null;
        }
        public string InsertNewFolder(string FolderName, string FolderPath, string CreatedIn, string UserID, string Disc, string ParentID)
        {
            string ErrorResult = null;
            try
            {
                SQLCmd.CommandText = String.Format("SP_InsertNewFolder @FolderName='{0}',@FolderPath='{1}',@CreatedIn='{2}',@UserID='{3}',@Disc='{4}',@ParentID='{5}'", FolderName, FolderPath, CreatedIn, UserID, Disc, ParentID);
                SQLCon.Open();
                ErrorResult = (string)(SQLCmd.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                SQLCon.Close();
                return null;
            }
            SQLCon.Close();
            return ErrorResult;
        }
        public string RemoveFolder(string FolderID)
        {
            try
            {
                SQLCon.Open();
                SQLTrn = SQLCon.BeginTransaction("Eshta ya rgala");
                SQLCmd.Transaction = SQLTrn;
                SQLCmd.CommandText = String.Format("delete from Folder_Rull where FolderID='{0}'", FolderID);
                SQLCmd.ExecuteNonQuery();
                SQLCmd.CommandText = String.Format("delete from dbo.folderinfo where folderid='{0}'", FolderID);
                SQLCmd.ExecuteNonQuery();
                SQLTrn.Commit();
            }
            catch (Exception ex)
            {
                SQLTrn.Rollback();
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetAllProjectsPrivileges()
        {
            try
            {
                AllProjectWithPrivileges = null;
                SQLCmd.CommandText = "Select ProID,ProName from dbo.Projects Select RullID,RullName,ProID from dbo.Rulls";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (AllProjectWithPrivileges == null)
                    {
                        AllProjectWithPrivileges = new ProjectWithprivilegesType[1];
                    }
                    else if (!(AllProjectWithPrivileges[AllProjectWithPrivileges.Length - 1].ProjectID == null))
                    {
                        Array.Resize(ref AllProjectWithPrivileges, AllProjectWithPrivileges.Length + 1);
                    }
                    AllProjectWithPrivileges[AllProjectWithPrivileges.Length - 1].ProjectID = SQLDR.GetValue(0).ToString().Trim();
                    AllProjectWithPrivileges[AllProjectWithPrivileges.Length - 1].ProjectName = SQLDR.GetValue(1).ToString().Trim();
                }
                short Int1 = (short)0;
                if (SQLDR.NextResult())
                {
                    while (SQLDR.Read())
                    {
                        for (Int1 = 0; Int1 <= AllProjectWithPrivileges.Length - 1; Int1++)
                        {
                            if (SQLDR.GetValue(2).ToString().Trim() == AllProjectWithPrivileges[Int1].ProjectID)
                            {
                                if (AllProjectWithPrivileges[Int1].InternalPrivileges == null)
                                {
                                    AllProjectWithPrivileges = new ProjectWithprivilegesType[Int1 + 1];
                                }
                                else if (!(AllProjectWithPrivileges[Int1].InternalPrivileges[AllProjectWithPrivileges[Int1].InternalPrivileges.Length - 1].privilegeID == null))
                                {
                                    Array.Resize(ref AllProjectWithPrivileges, Int1 + 1);
                                }
                                AllProjectWithPrivileges[Int1].InternalPrivileges[AllProjectWithPrivileges[Int1].InternalPrivileges.Length - 1].privilegeID = SQLDR.GetValue(0).ToString().Trim();
                                AllProjectWithPrivileges[Int1].InternalPrivileges[AllProjectWithPrivileges[Int1].InternalPrivileges.Length - 1].privilegeName = SQLDR.GetValue(1).ToString().Trim();
                                break;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string DeletePrivilege(string PrivID)
        {
            try
            {
                SQLCmd.CommandText = String.Format("delete from dbo.Rulls where RullID='{0}'", PrivID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string InsertNewPrivilege(string PrivName, string ProID)
        {
            string NewPriID = null;
            try
            {
                SQLCmd.CommandText = String.Format("SP_InsertNewPrivilege @RullName='{0}',@ProID='{1}'", PrivName, ProID);
                SQLCon.Open();
                NewPriID = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception)
            {
                SQLCon.Close();
                return null;
            }
            SQLCon.Close();
            return NewPriID;
        }
        public string UpdatePrivilegeName(string PrivID, string PrivNewName)
        {
            try
            {
                SQLCmd.CommandText = String.Format("Update dbo.Rulls set RullName='{0}' where RullID='{1}'", PrivNewName, PrivID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string AddUserPrivilege(string UserID, string ProID, string RullID)
        {
            try
            {
                SQLCmd.CommandText = String.Format("SP_AddNewPrivilegeToUser @UserID='{0}' ,@ProID='{1}' ,@RullID='{2}'", UserID, ProID, RullID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string RemoveUserPrivilege(string UserID, string ProID, string RullID)
        {
            try
            {
                SQLCmd.CommandText = String.Format("delete from dbo.Users_Rulls where RullID='{0}' and UsrID='{1}' and ProID='{2}'", RullID, UserID, ProID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetAllUsers(string AdminID, bool Status)
        {
            AllUsers = null;
            try
            {
                if (Status == true)
                {
                    SQLCmd.CommandText = String.Format("Select UsrID,UserName,Password from dbo.Users where UsrID <> '{0}' and Status='0'", AdminID);
                }
                else
                {
                    SQLCmd.CommandText = String.Format("Select UsrID,UserName,Password from dbo.Users where UsrID <> '{0}' and Status='1'", AdminID);
                }

                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (AllUsers == null)
                    {
                        AllUsers = new UserInfoType[1];
                    }
                    else
                    {
                        Array.Resize(ref AllUsers, AllUsers.Length + 1);
                    }
                    AllUsers[AllUsers.Length - 1].UsrID = SQLDR.GetValue(0).ToString().Trim();
                    AllUsers[AllUsers.Length - 1].UserName = SQLDR.GetValue(1).ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string GetUserPrivilege(string UsrID, string ProID, ref string[] PriIDArr)
        {
            try
            {
                SQLCmd.CommandText = String.Format("select RullID from dbo.Users_Rulls where ProID='{0}' and UsrID='{1}'", ProID, UsrID);
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (PriIDArr == null)
                    {
                        PriIDArr = new string[1];
                    }
                    else
                    {
                        Array.Resize(ref PriIDArr, PriIDArr.Length + 1);
                    }
                    PriIDArr[PriIDArr.Length - 1] = SQLDR.GetValue(0).ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string AddUser(string Username)
        {
            string ErrorProvider;
            try
            {
                SQLCmd.CommandText = String.Format("SP_InsertNewUser @UserName='{0}'", Username);
                SQLCon.Open();
                ErrorProvider = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception)
            {
                SQLCon.Close();
                return "UserName In Used";
            }
            SQLCon.Close();
            return ErrorProvider;
        }
        public string UpdateUserameOrPassword(string UsrID, string NewText, bool Username_True_Password_False)
        {
            try
            {
                if (Username_True_Password_False == true)
                {
                    //Upate UserName
                    SQLCmd.CommandText = String.Format("Update dbo.Users set UserName='{0}' where UsrID='{1}'", NewText, UsrID);
                }
                else
                {
                    //Upate Password
                    SQLCmd.CommandText = String.Format("Update dbo.Users set Password='{0}' where UsrID='{1}'", NewText, UsrID);
                }
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public object UserActivation(string UsrID, bool Status)
        {
            try
            {
                if (Status == true)
                {
                    SQLCmd.CommandText = "Update dbo.Users set Status='0' where UsrID='" + UsrID + "'";
                }
                else
                {
                    SQLCmd.CommandText = "Update dbo.Users set Status='1' where UsrID='" + UsrID + "'";
                }
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetAllConsultants(string RelatedFiles, bool Status)
        {
            AllConsultanats = null;
            try
            {
                if (Status == true)
                {
                    SQLCmd.CommandText = "Select ConsID,ConsName,ConsAddress,ConsMob1,ConsMob2,ConsPho1,ConsPho2,ConsEmail1,ConsEmail2,ConsCVPath from dbo.Consultants where Deleted='0'";
                }
                else
                {
                    SQLCmd.CommandText = "Select ConsID,ConsName,ConsAddress,ConsMob1,ConsMob2,ConsPho1,ConsPho2,ConsEmail1,ConsEmail2,ConsCVPath from dbo.Consultants where Deleted='1'";
                }
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (AllConsultanats == null)
                    {
                        AllConsultanats = new ConsultantType[1];
                    }
                    else
                    {
                        Array.Resize(ref AllConsultanats, AllConsultanats.Length + 1);
                    }
                    AllConsultanats[AllConsultanats.Length - 1].ConsID = SQLDR.GetValue(0).ToString().Trim();
                    AllConsultanats[AllConsultanats.Length - 1].ConsName = SQLDR.GetValue(1).ToString().Trim();
                    AllConsultanats[AllConsultanats.Length - 1].ConsAddress = SQLDR.GetValue(2).ToString().Trim();
                    AllConsultanats[AllConsultanats.Length - 1].ConsMob1 = SQLDR.GetValue(3).ToString().Trim();
                    AllConsultanats[AllConsultanats.Length - 1].ConsMob2 = SQLDR.GetValue(4).ToString().Trim();
                    AllConsultanats[AllConsultanats.Length - 1].ConsPho1 = SQLDR.GetValue(5).ToString().Trim();
                    AllConsultanats[AllConsultanats.Length - 1].ConsPho2 = SQLDR.GetValue(6).ToString().Trim();
                    AllConsultanats[AllConsultanats.Length - 1].ConsEmail1 = SQLDR.GetValue(7).ToString().Trim();
                    AllConsultanats[AllConsultanats.Length - 1].ConsEmail2 = SQLDR.GetValue(8).ToString().Trim();
                    if (SQLDR.IsDBNull(9) || SQLDR.GetValue(9).ToString().Trim() == "")
                    {
                        AllConsultanats[AllConsultanats.Length - 1].ConsCVPath = "";
                    }
                    else
                    {
                        AllConsultanats[AllConsultanats.Length - 1].ConsCVPath = RelatedFiles + SQLDR.GetValue(9).ToString().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public void GetProjectConsultants(string ProjectID)
        {
            string[] CosID = new string[1];
            try
            {
                SQLCmd.CommandText = "Select PrCo,ConsID from dbo.Project_Consultants where ProID='" + ProjectID + "'";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                short int1;
                while (SQLDR.Read())
                {
                    CosID[CosID.Length - 1] = SQLDR.GetString(0).Trim();
                    Array.Resize(ref CosID, CosID.Length + 1);
                    for (int1 = 0; int1 <= AllConsultanats.Length - 1; int1++)
                    {
                        if (SQLDR.GetString(1).Trim() == AllConsultanats[int1].ConsID)
                        {
                            AllConsultanats[int1].Selected = "1";
                            break;
                        }
                    }
                }
                Array.Resize(ref CosID, CosID.Length - 2 + 1);
            }
            catch
            {

            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public void GetProjectContractors(string ProjectID)
        {
            string[] CosID = new string[1];
            try
            {
                SQLCmd.CommandText = "Select PrCo,ContID from dbo.Project_Contractors where ProID='" + ProjectID + "'";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                short int1;
                while (SQLDR.Read())
                {
                    CosID[CosID.Length - 1] = SQLDR.GetString(0).Trim();
                    Array.Resize(ref CosID, CosID.Length + 1);
                    for (int1 = 0; int1 <= AllContractors.Length - 1; int1++)
                    {
                        if (SQLDR.GetString(1).Trim() == AllContractors[int1].ContID)
                        {
                            AllContractors[int1].Selected = "1";
                            break;
                        }
                    }
                }
                Array.Resize(ref CosID, CosID.Length - 2 + 1);
            }
            catch
            {

            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public string AddConsultantToProject(string ProjectID, string ConsultantID)
        {
            try
            {
                SQLCmd.CommandText = "SP_AddNewConsultantsToProject @ProID='" + ProjectID + "',@ConsID='" + ConsultantID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string RemoveConsultantFromProject(string ProjectID, string ConsultantID)
        {
            try
            {
                SQLCmd.CommandText = "Delete from dbo.Project_Consultants where ProID='" + ProjectID + "' and ConsID='" + ConsultantID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string AddContractorToProject(string ProjectID, string ConsultantID)
        {
            try
            {
                SQLCmd.CommandText = "SP_AddNewContractorsToProject @ProID='" + ProjectID + "',@ContID='" + ConsultantID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string RemoveContractorFromProject(string ProjectID, string ContractorID)
        {
            try
            {
                SQLCmd.CommandText = "Delete from dbo.Project_Contractors where ProID='" + ProjectID + "' and ContID='" + ContractorID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetAllContractors(bool Status)
        {
            AllContractors = null;
            try
            {
                if (Status == true)
                {
                    SQLCmd.CommandText = "Select ContID,ContName,ContAddress,ContMob1,ContMob2,ContPho1,ContPho2,ContMail1,ContMail2 from dbo.Contractors Where Deleted='0'";
                }
                else
                {
                    SQLCmd.CommandText = "Select ContID,ContName,ContAddress,ContMob1,ContMob2,ContPho1,ContPho2,ContMail1,ContMail2 from dbo.Contractors Where Deleted='1'";
                }
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (AllContractors == null)
                    {
                        AllContractors = new ContractorType[1];
                    }
                    else
                    {
                        Array.Resize(ref AllContractors, AllContractors.Length + 1);
                    }
                    AllContractors[AllContractors.Length - 1].ContID = SQLDR.GetValue(0).ToString().Trim();
                    AllContractors[AllContractors.Length - 1].ContName = SQLDR.GetValue(1).ToString().Trim();
                    AllContractors[AllContractors.Length - 1].ContAddress = SQLDR.GetValue(2).ToString().Trim();
                    AllContractors[AllContractors.Length - 1].ContMob1 = SQLDR.GetValue(3).ToString().Trim();
                    AllContractors[AllContractors.Length - 1].ContMob2 = SQLDR.GetValue(4).ToString().Trim();
                    AllContractors[AllContractors.Length - 1].ContPho1 = SQLDR.GetValue(5).ToString().Trim();
                    AllContractors[AllContractors.Length - 1].ContPho2 = SQLDR.GetValue(6).ToString().Trim();
                    AllContractors[AllContractors.Length - 1].ContEmail1 = SQLDR.GetValue(7).ToString().Trim();
                    AllContractors[AllContractors.Length - 1].ContEmail2 = SQLDR.GetValue(8).ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetAllClients(bool Status)
        {
            AllClients = null;
            try
            {
                if (Status == true)
                {
                    SQLCmd.CommandText = "Select ClientID,ClientName,ClientAddress,ClientMob1,ClientMob2,ClientPho1,ClientPho2,ClientMail1,ClientMail2 from dbo.Client Where Deleted='0'";
                }
                else
                {
                    SQLCmd.CommandText = "Select ClientID,ClientName,ClientAddress,ClientMob1,ClientMob2,ClientPho1,ClientPho2,ClientMail1,ClientMail2 from dbo.Client Where Deleted='1'";
                }
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (AllClients == null)
                    {
                        AllClients = new ClientType[1];
                    }
                    else
                    {
                        Array.Resize(ref AllClients, AllClients.Length + 1);
                    }
                    AllClients[AllClients.Length - 1].ClientID = SQLDR.GetValue(0).ToString().Trim();
                    AllClients[AllClients.Length - 1].ClientName = SQLDR.GetValue(1).ToString().Trim();
                    AllClients[AllClients.Length - 1].ClientAddress = SQLDR.GetValue(2).ToString().Trim();
                    AllClients[AllClients.Length - 1].ClientMob1 = SQLDR.GetValue(3).ToString().Trim();
                    AllClients[AllClients.Length - 1].ClientMob2 = SQLDR.GetValue(4).ToString().Trim();
                    AllClients[AllClients.Length - 1].ClientPho1 = SQLDR.GetValue(5).ToString().Trim();
                    AllClients[AllClients.Length - 1].ClientPho2 = SQLDR.GetValue(6).ToString().Trim();
                    AllClients[AllClients.Length - 1].ClientMail1 = SQLDR.GetValue(7).ToString().Trim();
                    AllClients[AllClients.Length - 1].ClientMail2 = SQLDR.GetValue(8).ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string UpdateConsultants(string RelatedFiles, string ID, string Name, string Address, string Mob1, string Mob2, string Phon1, string Phon2, string Mail1, string Mail2, string CV)
        {
            try
            {
                if (RelatedFiles == null)
                {
                    SQLCmd.CommandText = "Update dbo.Consultants Set ConsName='" + Name + "',ConsAddress='" + Address + "',ConsMob1='" + Mob1 + "',ConsMob2='" + Mob2 + "',ConsPho1='" + Phon1 + "',ConsPho2='" + Phon2 + "',ConsEmail1='" + Mail1 + "',ConsEmail2='" + Mail2 + "',ConsCVPath='' where ConsID='" + ID + "'";
                }
                else
                {
                    SQLCmd.CommandText = "Update dbo.Consultants Set ConsName='" + Name + "',ConsAddress='" + Address + "',ConsMob1='" + Mob1 + "',ConsMob2='" + Mob2 + "',ConsPho1='" + Phon1 + "',ConsPho2='" + Phon2 + "',ConsEmail1='" + Mail1 + "',ConsEmail2='" + Mail2 + "',ConsCVPath='" + CV.Substring(RelatedFiles.Length) + "' where ConsID='" + ID + "'";
                }
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string UpdateContractors(string ID, string Name, string Address, string Mob1, string Mob2, string Phon1, string Phon2, string Mail1, string Mail2)
        {
            try
            {
                SQLCmd.CommandText = "Update dbo.Contractors Set ContName='" + Name + "',ContAddress='" + Address + "',ContMob1='" + Mob1 + "',ContMob2='" + Mob2 + "',ContPho1='" + Phon1 + "',ContPho2='" + Phon2 + "',ContMail1='" + Mail1 + "',ContMail2='" + Mail2 + "' where ContID='" + ID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string UpdateClients(string ID, string Name, string Address, string Mob1, string Mob2, string Phon1, string Phon2, string Mail1, string Mail2)
        {
            try
            {
                SQLCmd.CommandText = "Update dbo.Client Set ClientName='" + Name + "',ClientAddress='" + Address + "',ClientMob1='" + Mob1 + "',ClientMob2='" + Mob2 + "',ClientPho1='" + Phon1 + "',ClientPho2='" + Phon2 + "',ClientMail1='" + Mail1 + "',ClientMail2='" + Mail2 + "' where ClientID='" + ID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string DisactivateConsultants(string ID, bool Status)
        {
            try
            {
                if (Status == false)
                {
                    SQLCmd.CommandText = "Update dbo.Consultants Set Deleted='1' where ConsID='" + ID + "'";
                }
                else
                {
                    SQLCmd.CommandText = "Update dbo.Consultants Set Deleted='0' where ConsID='" + ID + "'";
                }
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string DisactivateContractors(string ID, bool Status)
        {
            try
            {
                if (Status == false)
                {
                    SQLCmd.CommandText = "Update dbo.Contractors Set Deleted='1' where ContID='" + ID + "'";
                }
                else
                {
                    SQLCmd.CommandText = "Update dbo.Contractors Set Deleted='0' where ContID='" + ID + "'";
                }
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string DisactivateClients(string ID, bool Status)
        {
            try
            {
                if (Status == false)
                {
                    SQLCmd.CommandText = "Update dbo.Client Set Deleted='1' where ClientID='" + ID + "'";
                }
                else
                {
                    SQLCmd.CommandText = "Update dbo.Client Set Deleted='0' where ClientID='" + ID + "'";
                }
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string DeleteUser(string UsrID)
        {
            string ErrorProvider = null;
            try
            {
                SQLCmd.CommandText = "SP_DeleteUser @USRID='" + UsrID + "'";
                SQLCon.Open();
                ErrorProvider = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return ErrorProvider;
        }
        public string DeleteContractors(string ContID)
        {
            string ErrorProvider = null;
            try
            {
                SQLCmd.CommandText = "SP_DeleteContractor @ContID='" + ContID + "'";
                SQLCon.Open();
                ErrorProvider = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return ErrorProvider;
        }
        public string DeleteConsultants(string ConsID)
        {
            string ErrorProvider = null;
            try
            {
                SQLCmd.CommandText = "SP_DeleteConsultant @ConsID='" + ConsID + "'";
                SQLCon.Open();
                ErrorProvider = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return ErrorProvider;
        }
        public string DeleteClients(string ClientID)
        {
            string ErrorProvider = null;
            try
            {
                SQLCmd.CommandText = "SP_DeleteClient @ClientID='" + ClientID + "'";
                SQLCon.Open();
                ErrorProvider = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return ErrorProvider;
        }
        public string AddNewClient(string ClientName, string ClientAddress, string ClientMob1, string ClientMob2, string ClientPho1, string ClientPho2, string ClientMail1, string ClientMail2)
        {
            string ErrorProvider = null;
            try
            {
                SQLCmd.CommandText = "SP_InsertNewClient @ClientName='" + ClientName + "',@ClientAddress='" + ClientAddress + "',@ClientMob1='" + ClientMob1 + "',@ClientMob2='" + ClientMob2 + "',@ClientPho1='" + ClientPho1 + "',@ClientPho2='" + ClientPho2 + "',@ClientMail1='" + ClientMail1 + "',@ClientMail2='" + ClientMail2 + "'";
                SQLCon.Open();
                ErrorProvider = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return ErrorProvider;
        }
        public string AddNewContractor(string ContName, string ContAddress, string ContMob1, string ContMob2, string ContPho1, string ContPho2, string ContMail1, string ContMail2)
        {
            string ErrorProvider = null;
            try
            {
                SQLCmd.CommandText = "SP_InsertNewContractor @ContName='" + ContName + "',@ContAddress='" + ContAddress + "',@ContMob1='" + ContMob1 + "',@ContMob2='" + ContMob2 + "',@ContPho1='" + ContPho1 + "',@ContPho2='" + ContPho2 + "',@ContMail1='" + ContMail1 + "',@ContMail2='" + ContMail2 + "'";
                SQLCon.Open();
                ErrorProvider = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return ErrorProvider;
        }
        public string AddNewProject(string ProName, string ProLocation, string Startat, string ExpEndat, string AdminID, string ProjectsPath, ref short PogressBarValue)
        {
            //543 Line for this sutpid funtion :(
            string NewFID = null;
            string LVL1 = null;
            string ProID = null;
            try
            {
                SQLCon.Open();
                PogressBarValue++;
                //Add Project
                SQLCmd.CommandText = String.Format("SP_AddNewProject @ProName='{0}',@ProLocation='{1}',@Startat='{2}',@ExpEndat='{3}'", ProName, ProLocation, Startat, ExpEndat);
                ProID = (string)(SQLCmd.ExecuteScalar());
                if (ProID == "NO")
                {
                    SQLCon.Close();
                    return "Can't Add New Project";
                }
                NewFID = FindNewFolderID();
                if (NewFID == "NO")
                {
                    SQLCon.Close();
                    return "Can't Add Site View";
                }
                SQLCmd.CommandText = String.Format("INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('{0}','{1}','{1}','{2}','{3}','{4}','0')", NewFID, ProName, DateTime.Now.Date, AdminID, ProID);
                SQLCmd.ExecuteNonQuery();
                if (!Directory.Exists(ProjectsPath + ProName))
                {
                    Directory.CreateDirectory(ProjectsPath + ProName);
                }
                LVL1 = NewFID;
                PogressBarValue++;

            }
            catch (Exception ex)
            {
                try
                {
                    if (ProID != null || ProID != "NO")
                    {
                        SQLCmd.CommandText = String.Format("DELETE FROM dbo.FolderInfo where ProID='{0}'", ProID);
                        SQLCmd.ExecuteNonQuery();
                        SQLCmd.CommandText = String.Format("DELETE FROM dbo.Projects WHERE ProID='{0}'", ProID);
                        SQLCmd.ExecuteNonQuery();
                    }
                    if (!Directory.Exists(ProjectsPath + ProName))
                    {
                        Directory.CreateDirectory(ProjectsPath + ProName);
                    }
                }
                catch
                { }
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        private string FindNewFolderID()
        {
            string NewID;
            try
            {
                SQLCmd.CommandText = "SP_FindNewFolderID";
                NewID = (string)(SQLCmd.ExecuteScalar());
                if (NewID == "NO")
                {
                    return "NO";
                }
            }
            catch (Exception)
            {
                return "NO";
            }
            return NewID;
        }
        public string RemoveProject(string ProID, string ProjectsPath, string DeletedFilesPath)
        {
            try
            {
                SqlCommand NewCMD = new SqlCommand("", SQLCon);
                string ProPath = null;
                SQLCon.Open();
                NewCMD.CommandText = String.Format("select FolderPath from dbo.FolderInfo where ProID='{0}' and ParentID='0'", ProID);
                ProPath = NewCMD.ExecuteScalar().ToString().Trim();
                if (ProPath != null)
                {
                    ProPath = ProjectsPath + ProPath;
                }
                SQLTrn = SQLCon.BeginTransaction();
                SQLCmd.Transaction = SQLTrn;
                SQLCmd.CommandText = String.Format("Delete from rulls where proid='{0}'", ProID);
                SQLCmd.ExecuteNonQuery();
                SQLCmd.CommandText = String.Format("Delete from dbo.FileInfo where ProID='{0}'", ProID);
                SQLCmd.ExecuteNonQuery();
                SQLCmd.CommandText = String.Format("Delete from dbo.FolderInfo where ProID='{0}'", ProID);
                SQLCmd.ExecuteNonQuery();
                SQLCmd.CommandText = String.Format("Delete from projects where proid='{0}'", ProID);
                SQLCmd.ExecuteNonQuery();
                SQLTrn.Commit();
                try
                {
                    if (ProPath != null)
                    {
                        if (Directory.Exists(ProPath))
                        {
                            if (!Directory.Exists(String.Format("{0}{1}-{2}-{3}", DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)))
                                Directory.CreateDirectory(String.Format("{0}{1}-{2}-{3}", DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
                            short Int1;
                            string[] ProjectPaths = ProPath.Split("\\".ToCharArray());
                            string NewPath;
                            for (Int1 = 0; Int1 <= 10000; Int1++)
                            {
                                NewPath = String.Format("{0}{1}-{2}-{3}\\{4}_{5}", DeletedFilesPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, ProjectPaths[ProjectPaths.Length - 1], Int1);
                                if (Directory.Exists(NewPath) == false)
                                {
                                    Directory.Move(ProPath, NewPath);
                                    break;
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
            }
            catch (Exception ex)
            {
                SQLTrn.Rollback();
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string AddNewFileType(string TypeName, byte[] TypeIconData, string TypeDic, string TypeExt)
        {
            string ErrorProvider = null;
            try
            {
                SQLCmd.CommandText = String.Format("SP_InsertNewFileType @TypeName='{0}',@TypeIconData='{1}',@TypeDic='{2}',@TypeExt='{3}'", TypeName, TypeIconData, TypeDic, TypeExt);
                SQLCon.Open();
                ErrorProvider = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return ErrorProvider;
            //TypeName In Used
        }
        public string UpdateFileType(string TypeID, string TypeName, byte[] TypeIconData, string TypeDic, string TypeExt)
        {
            try
            {
                SQLCmd.CommandText = String.Format("Update FileType set TypeName='{0}' , TypeIconPath='{1}' , TypeDic='{2}' , TypeExt='{3}' where TypeID={4}", TypeName, TypeIconData, TypeDic, TypeExt, TypeID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string DeleteFileType(string TypeID)
        {
            try
            {
                SQLCon.Open();
                SQLCmd.CommandText = (string)("Update dbo.FileInfo set TypeID=null where TypeID=" + TypeID);
                SQLCmd.ExecuteNonQuery();
                SQLCmd.CommandText = (string)("Delete From dbo.FileType where TypeID=" + TypeID);
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetAllLockedFile(ref LockedFilesSTR[] LockedFileZ)
        {
            LockedFileZ = new LockedFilesSTR[0];
            try
            {
                SQLCmd.CommandText = "SP_GetAllLockFiles";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (LockedFileZ.Length == 0)
                        LockedFileZ = new LockedFilesSTR[1];
                    else
                    {
                        Array.Resize(ref LockedFileZ, LockedFileZ.Length + 1);
                    }
                    LockedFileZ[LockedFileZ.Length - 1].FileID = SQLDR.GetString(0).Trim();
                    LockedFileZ[LockedFileZ.Length - 1].FileName = SQLDR.GetString(1).Trim();
                    LockedFileZ[LockedFileZ.Length - 1].FilePath = SQLDR.GetString(2).Trim();
                    LockedFileZ[LockedFileZ.Length - 1].UsrID = SQLDR.GetString(4).Trim();
                    LockedFileZ[LockedFileZ.Length - 1].UsrName = SQLDR.GetString(5).Trim();
                    if (SQLDR.NextResult())
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string UnLockFile(string FileID)
        {
            try
            {
                SQLCmd.CommandText = String.Format("Update dbo.FileInfo Set InUseUserID=NULL,InUse=0 Where FileID='{0}'", FileID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetProjectInfo(string ProjectID, ProjectInfo ProjectInfoSTR)
        {
            try
            {
                SQLCmd.CommandText = String.Format("Select ProName,ProLocation,Startat,ExpEndat,Endedat,Budget from dbo.Projects where ProID='{0}'", ProjectID);
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                SQLDR.Read();
                ProjectInfoSTR.ProjectID = ProjectID;
                ProjectInfoSTR.PrjectName = SQLDR.GetValue(0).ToString().Trim();
                ProjectInfoSTR.ProjectLocation = SQLDR.GetValue(1).ToString().Trim();
                if (SQLDR.IsDBNull(2) == false)
                {
                    //MsgBox(SQLDR.GetDateTime(2).ToShortDateString)
                    ProjectInfoSTR.ProjectStart = SQLDR.GetDateTime(2).ToShortDateString();
                }
                else
                {
                    ProjectInfoSTR.ProjectStart = "";
                }
                if (SQLDR.IsDBNull(3) == false)
                {
                    //MsgBox(SQLDR.GetDateTime(3).ToShortDateString)
                    ProjectInfoSTR.projectExp = SQLDR.GetDateTime(3).ToShortDateString();
                }
                else
                {
                    ProjectInfoSTR.projectExp = "";
                }
                if (SQLDR.IsDBNull(4) == false)
                {
                    //MsgBox(SQLDR.GetDateTime(4).ToShortDateString)
                    ProjectInfoSTR.ProjectEnd = SQLDR.GetDateTime(4).ToShortDateString();
                }
                else
                {
                    ProjectInfoSTR.ProjectEnd = "";
                }
                ProjectInfoSTR.ProjectBudget = SQLDR.GetValue(5).ToString().Trim();
            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string SaveProjectInfo(ProjectInfo ProjectInfoSTR)
        {
            try
            {
                SQLCmd.CommandText = String.Format("Update dbo.Projects Set ProName='{0}',ProLocation='{1}',Startat={2},ExpEndat={3},Endedat={4},Budget={5} Where ProID='{6}'", ProjectInfoSTR.PrjectName, ProjectInfoSTR.ProjectLocation, ProjectInfoSTR.ProjectStart, ProjectInfoSTR.projectExp, ProjectInfoSTR.ProjectEnd, ProjectInfoSTR.ProjectBudget, ProjectInfoSTR.ProjectID);
                SQLCon.Open();
                //MsgBox(SQLCmd.CommandText)
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }

        public DataTable GetFolderFiles(string FolderID)
        {
            DataTable dt = new DataTable("FX2011-02");
            using (SqlDataAdapter da = new SqlDataAdapter("", SQLCon))
            {
                try
                {
                    da.SelectCommand.CommandText = String.Format(@"SELECT FileID, FileName, FilePath, CreatedIn, UsrID, Dis, ProID, FolderID, TypeID, Active, InUseUserID, InUse FROM FileInfo
                                                                   WHERE FolderID = N'{0}'", FolderID);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                }
            }
            return dt;

        }
        public DataTable GetAllProjectz()
        {
            DataTable ReturnMe = new DataTable("FX2011-02");
            using (SqlDataAdapter da = new SqlDataAdapter("", SQLCon))
            {
                try
                {
                    da.SelectCommand.CommandText = "SELECT ProID, ProName, ProLocation, Startat, ExpEndat, Endedat, Budget FROM Projects";
                    da.Fill(ReturnMe);
                }
                catch (SqlException ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                }
            }
            return ReturnMe;
        }
        public DataTable LoadTable(string SQlCommandz)
        {
            DataTable ReturnMe = new DataTable("FX2011-02");
            using (SqlDataAdapter da = new SqlDataAdapter(SQlCommandz, SQLCon))
            {
                try
                {
                    da.Fill(ReturnMe);
                }
                catch (SqlException ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                }
            }
            return ReturnMe;
        }
        public DataTable GetFolderSubFolders(string ParentID)
        {
            DataTable ReturnMe = new DataTable("FX2011-02");
            using (SqlDataAdapter da = new SqlDataAdapter("", SQLCon))
            {
                try
                {
                    da.SelectCommand.CommandText = String.Format("SELECT FolderID, FolderName, FolderPath, CreatedIn, UserID, Disc, ProID, ParentID FROM FolderInfo WHERE ParentID = N'{0}'", ParentID);
                    da.Fill(ReturnMe);
                }
                catch (SqlException ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                }
            }
            return ReturnMe;
        }


        //Registry Functions
        public void PrepareReg()
        {
            RegistryKey RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            string[] arr;
            int ForInt = 0;
            arr = Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames();
            for (ForInt = 0; ForInt <= arr.Length - 1; ForInt++)
            {
                if (arr[ForInt] == "DataCenter")
                {
                }
            }
            RegKey.CreateSubKey("DataCenter");
        }
        public void SetRegValue(string KeyValue, RegKeyValues ValueName)
        {
            //"SQLString"
            PrepareReg();
            Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", true).SetValue((string)(ValueName.ToString()), KeyValue);
        }
        public bool GetRegValue(ref string ConStr, RegKeyValues ValueName)
        {
            PrepareReg();
            string[] arr = Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", false).GetValueNames();
            int ForInt = 0;
            for (ForInt = 0; ForInt <= arr.Length - 1; ForInt++)
            {
                if (arr[ForInt] == ValueName.ToString())
                {
                    ConStr = (string)(Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", false).GetValue((string)(ValueName.ToString())));
                    return true;
                }
            }
            return false;
        }
        public void ResetConnection()
        {
            Registry.LocalMachine.DeleteSubKey("SOFTWARE\\DataCenter");
            //Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", True).DeleteValue(RegKeyValues.PW)
        }
        //Binary Function
        public string CharToBinary(string Strings)
        {
            short @int;
            string fout = "";
            string @out = "";
            for (@int = 0; @int <= Strings.Length - 1; @int++)
            {
                long str2 = Microsoft.VisualBasic.Strings.Asc(Strings[@int]);
                str2 = (str2 * 9) / 8;
                long mydiv;
                while (str2 != 0)
                {
                    str2 = System.Math.DivRem(str2, 2, out mydiv);
                    if (mydiv > 0)
                    {
                        @out = (string)(1 + @out);
                    }
                    else
                    {
                        @out = (string)(0 + @out);
                    }
                }
                @out = new string('0', 8 - @out.Length) + @out;
                fout += @out;
                @out = "";
            }
            return fout;
        }
        public string Binarytochar(string Binarystring)
        {
            string fout = "";
            long back_to_normal;
            string[] arr = new string[(Binarystring.Length / 8) - 1 + 1];
            short i;
            for (i = 0; i <= (Binarystring.Length / 8) - 1; i++)
            {
                arr[i] = Binarystring.Substring(i * 8, 8);
            }
            for (i = 0; i <= arr.Length - 1; i++)
            {
                string str1 = (string)(arr[i].Substring(0, 4));
                string str2 = (string)(arr[i].Substring(4));
                short out1 = new short();
                short out2 = new short();
                if (str1[0] == '1')
                {
                    out1 += (short)8;
                }
                if (str1[1] == '1')
                {
                    out1 += (short)4;
                }
                if (str1[2] == '1')
                {
                    out1 += (short)2;
                }
                if (str1[3] == '1')
                {
                    out1++;
                }
                if (str2[0] == '1')
                {
                    out2 += (short)8;
                }
                if (str2[1] == '1')
                {
                    out2 += (short)4;
                }
                if (str2[2] == '1')
                {
                    out2 += (short)2;
                }
                if (str2[3] == '1')
                {
                    out2++;
                }
                out2 = (short)(out2 * 1);
                out1 = (short)(out1 * 16);
                back_to_normal = out1 + out2;
                back_to_normal = (back_to_normal * 8) / 9;
                fout += Strings.Chr((int)back_to_normal);
            }
            return fout;
        }

    }
    public class DataCenterClientLib
    {
        public DataCenterClientLib()
        {
            SQLCmd = new SqlCommand("", SQLCon, SQLTrn);

        }
        //Vars SQLClient
        public SqlConnection SQLCon = new SqlConnection("");
        private SqlDataReader SQLDR;
        private SqlTransaction SQLTrn;
        private SqlCommand SQLCmd;
        public string SqlStr;
        //Structure
        public struct PrvOperationsType
        {
            public string RullID;
            public string RullName;
            //Dim CanRead As Boolean
            public bool CanWrite;
            public bool CanDelete;
        }
        public struct PrivateFoldersPrvType
        {
            public FolderInfo[] FolderInfo;
            public PrvOperationsType[] PrvOperationsType;
        }
        public struct FileInfo
        {
            public string FileID;
            public string FileName;
            public string FilePath;
            public string CreatedIn;
            public string UsrID;
            public string Dis;
            public string ProID;
            public string FolderID;
            public string TypeID;
            public string UserName;
            public string TypeName;
            public string TypePath;
            public string InUseUserID;
            public string InUseUserName;
            public string InUse;
        }
        public struct FolderInfo
        {
            public string FolderID;
            public string FolderName;
            public string FolderPath;
            public string UserID;
            public string UserName;
            public string CreatedIn;
            public string Disc;
            public string ProID;
            public string ProName;
            public string ParentID;
            public FileInfo[] Files;
        }
        public struct FilesType
        {
            public string TypeID;
            public string TypeName;
            public string TypeIcon;
            public string TypeExt;
            public string TypeDesc;
        }
        public struct CUserIfo
        {
            public string UID;
            public string UName;
            public string UPass;
            public privilegeType[] UsrPrv;
        }
        public CUserIfo CUser;
        public struct privilegeType
        {
            public string privilegeName;
            public string privilegeID;
            public bool privilegeSelected;
            public int CanAdd;
            public int CanView;
            public int CanWrite;
            public int CanDelete;
        }
        public struct ProjectWithprivilegesType
        {
            public string ProjectID;
            public string ProjectName;
            public privilegeType[] InternalPrivileges;
        }
        private struct ListOfFilesPathType
        {
            public string FileID;
            public string FilePath;
        }
        private struct ListOfFoldersPathType
        {
            public string FolderID;
            public string FolderPath;
        }
        public struct LockedFilesSTR
        {
            public string FileID;
            public string FileName;
            public string FilePath;
            public string ProjectName;
            public string UsrID;
            public string UsrName;
        }
        //Vars
        //Public AllFoldersWithPrv As PrivateFoldersPrvType "Obsolated"
        //Public Folders(0) As FolderInfo "Obsolated"
        private string ErrorProvider = null;
        public FilesType[] AllFilesType;
        public privilegeType[] Allprivilege = new privilegeType[1];
        public ProjectWithprivilegesType[] AllProjectWithPrivileges;
        private ListOfFilesPathType[] ListOfFilesPathToChage = new ListOfFilesPathType[1];
        private ListOfFoldersPathType[] ListOfFoldersPathToChange = new ListOfFoldersPathType[1];
        private FunctionLib.NetworkFunction NWLib = new FunctionLib.NetworkFunction();
        //Enums
        public enum RegKeyValues
        {
            SQLString,
            PW,
            DataChacked

        }
        //Functions
        public void ServerTest(string ServerName, string UserID, string UserPW, ref bool Done)
        {
            try
            {
                SQLCon.ConnectionString = (string)("Data Source=" + ServerName + ";User ID=" + UserID + ";Password=" + UserPW);
                SQLCon.Open();
                Done = true;
            }
            catch (Exception)
            {
                Done = false;
            }
            SQLCon.Close();
        }
        public void AttachDB(string DataPath, ref bool Done)
        {
            try
            {
                SQLCmd.CommandText = "EXEC sp_attach_single_file_db @dbname = 'DataCenter', @physname = '" + DataPath + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
                Done = true;
            }
            catch (Exception)
            {
                Done = false;
            }
            SQLCon.Close();
        }
        public void AttachDB(string DataPath, string LogPath, ref bool Done)
        {
            try
            {
                SQLCmd.CommandText = "EXEC sp_attach_db @dbname = N'DataCenter', @filename1 = N'" + DataPath + "',@filename2 = N'" + LogPath + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
                Done = true;
            }
            catch (Exception)
            {
                Done = false;
            }
            SQLCon.Close();
        }
        public string[] GetAllDatabase()
        {
            string[] DatBaseNames = new string[0];
            try
            {
                SQLCmd.CommandText = "SELECT * FROM master.dbo.sysdatabases";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (DatBaseNames.Length == 0)
                    {
                        DatBaseNames = new string[1];
                    }
                    else
                    {
                        Array.Resize(ref DatBaseNames, DatBaseNames.Length + 1);
                    }
                    DatBaseNames[DatBaseNames.Length - 1] = SQLDR.GetString(0).Trim();
                }
            }
            catch (Exception)
            {
                SQLDR.Close();
                SQLCon.Close();
                return null;
            }
            SQLDR.Close();
            SQLCon.Close();
            return DatBaseNames;
        }
        public bool ULogin(string UName, string UPassword)
        {
            try
            {
                CUser = new CUserIfo();
                SQLCmd.CommandText = String.Format("Select UsrID from dbo.Users where UserName='{0}' and [Password]='{1}' and Status=0 and UserName<>'Administrator'", UName, UPassword);
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                SQLDR.Read();
                if (SQLDR.HasRows == true)
                {
                    CUser.UID = SQLDR.GetValue(0).ToString().Trim();
                    CUser.UName = UName;
                    CUser.UPass = UPassword;
                    SQLDR.Close();
                    SQLCon.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
            return false;
        }
        public string GetServerOption(ref string DefaultUserPassword, ref string ProjectsPath, ref string RelatedFiles, ref string DeletedFilesPath, ref string serverIP, ref string serverPort, ref string StudentFilesPath, ref string EmpFilesPath)
        {
            try
            {
                SQLCmd.CommandText = "SELECT ProjectsPath,RelatedFiles,DeletedFilesPath,ServerIP,ServerPort,DefaultUserPassword,StudentFilesPath, EmpFilesPath FROM dbo.ServerOption";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (SQLDR.IsDBNull(0) == false)
                        ProjectsPath = SQLDR.GetValue(0).ToString().Trim();
                    if (SQLDR.IsDBNull(1) == false)
                        RelatedFiles = SQLDR.GetValue(1).ToString().Trim();
                    if (SQLDR.IsDBNull(2) == false)
                        DeletedFilesPath = SQLDR.GetValue(2).ToString().Trim();
                    if (SQLDR.IsDBNull(3) == false)
                        serverIP = SQLDR.GetValue(3).ToString().Trim();
                    if (SQLDR.IsDBNull(4) == false)
                        serverPort = SQLDR.GetValue(4).ToString().Trim();
                    if (SQLDR.IsDBNull(5) == false)
                        DefaultUserPassword = SQLDR.GetValue(5).ToString().Trim();
                    if (SQLDR.IsDBNull(6) == false)
                        StudentFilesPath = SQLDR.GetValue(6).ToString().Trim();
                    if (SQLDR.IsDBNull(7) == false)
                        EmpFilesPath = SQLDR.GetValue(7).ToString().Trim();
                }
            }
            catch (SqlException ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string ChangePasswrod(string UserID, string UsrPassword)
        {
            try
            {
                SQLCmd.CommandText = "Update dbo.Users Set [Password]='" + UsrPassword + "' where UsrID='" + UserID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public void GetAllFoldersWithFilesOrdered(string DataPath, string UsrID, ref PrivateFoldersPrvType AllFoldersWithPrv2, ref int Max, ref int Values)
        {
        //    //ReDim AllFoldersWithPrv.FolderInfo(0)
        //    AllFoldersWithPrv2 = new PrivateFoldersPrvType();
        //    PrivateFoldersPrvType AllFoldersWithPrv = new PrivateFoldersPrvType();
        //    int Int1 = new int();
        //    //Connection No#2
        //    SqlConnection SqlCon2 = new SqlConnection(SqlStr);
        //    SqlCommand SqlCmd2 = new SqlCommand("", SqlCon2);
        //    SqlDataReader SqlDR2;
        //    //Connection No#3
        //    SqlConnection SqlCon3 = new SqlConnection(SqlStr);
        //    SqlCommand SqlCmd3 = new SqlCommand("", SqlCon3);
        //    SqlDataReader SqlDR3;
        //    //Connection No#3
        //    SqlConnection SqlCon4 = new SqlConnection(SqlStr);
        //    SqlCommand SqlCmd4 = new SqlCommand("", SqlCon4);
        //    short i;
        //    try
        //    {
        //        //1- Get User's Rulls
        //        SQLCmd.CommandText = "select RullID from dbo.Users_Rulls where UsrID='" + UsrID + "'";
        //        SQLCon.Open();
        //        SqlCon2.Open();
        //        SqlCon3.Open();
        //        SqlCon4.Open();
        //        SQLDR = SQLCmd.ExecuteReader();
        //        while (SQLDR.Read())
        //        {
        //            Max = SQLDR.VisibleFieldCount;
        //            Values = SQLDR.VisibleFieldCount;
        //            //2- Geting The FolderID,Write,Delete for this Rull
        //            SqlCmd2.CommandText = "Select FolderID,CanWrite,CanDelete from dbo.Folder_Rull where RullID='" + SQLDR.GetString(0).Trim() + "'";
        //            SqlDR2 = SqlCmd2.ExecuteReader();
        //            while (SqlDR2.Read())
        //            {
        //                if (AllFoldersWithPrv.FolderInfo != null) //check for if i already add this folder or not
        //                {
        //                    for (Int1 = 0; Int1 <= AllFoldersWithPrv.FolderInfo.Length - 1; Int1++)
        //                    {
        //                        if (AllFoldersWithPrv.FolderInfo[Int1].FolderID == SqlDR2.GetString(0).Trim())
        //                        {
        //                            if (SqlDR2.GetValue(1).ToString().Trim() == "1") //Fill CanWrite
        //                            {
        //                                AllFoldersWithPrv.PrvOperationsType[Int1].CanWrite = true;
        //                            }
        //                            if (SqlDR2.GetValue(2).ToString().Trim() == "1") //Fill CanDelete
        //                            {
        //                                AllFoldersWithPrv.PrvOperationsType[Int1].CanDelete = true;
        //                            }
        //                            goto NextLoop;
        //                        }
        //                    }
        //                }
        //                if (AllFoldersWithPrv.PrvOperationsType == null)
        //                {
        //                    AllFoldersWithPrv.PrvOperationsType = new PrvOperationsType[1];
        //                }
        //                else
        //                {
        //                    Array.Resize(ref AllFoldersWithPrv.PrvOperationsType, AllFoldersWithPrv.PrvOperationsType.Length + 1);
        //                }
        //                AllFoldersWithPrv.PrvOperationsType[AllFoldersWithPrv.PrvOperationsType.Length - 1].RullID = SQLDR.GetString(0).Trim(); //Fill RullID
        //                if (AllFoldersWithPrv.FolderInfo == null)
        //                {
        //                    AllFoldersWithPrv.FolderInfo = new FolderInfo[1];
        //                }
        //                else
        //                {
        //                    Array.Resize(ref AllFoldersWithPrv.FolderInfo, AllFoldersWithPrv.FolderInfo.Length + 1);
        //                }
        //                AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].FolderID = SqlDR2.GetString(0).Trim(); //Fill FolderID
        //                if (SqlDR2.GetValue(1).ToString().Trim() == "1") //Fill CanWrite
        //                {
        //                    AllFoldersWithPrv.PrvOperationsType[AllFoldersWithPrv.PrvOperationsType.Length - 1].CanWrite = true;
        //                }
        //                if (SqlDR2.GetValue(2).ToString().Trim() == "1") //Fill CanDelete
        //                {
        //                    AllFoldersWithPrv.PrvOperationsType[AllFoldersWithPrv.PrvOperationsType.Length - 1].CanDelete = true;
        //                }
        //                //SqlDR2.Close()
        //                //3- Get Folder Options
        //                SqlCmd3.CommandText = "SELECT FolderName,FolderPath,UserID,CreatedIn,Disc,ProID,ParentID from dbo.FolderInfo where FolderID='" + AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].FolderID + "' order by FolderPath";
        //                SqlDR3 = SqlCmd3.ExecuteReader();
        //                SqlDR3.Read();
        //                FolderInfo with_1 = AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1];
        //                with_1.FolderName = SqlDR3.GetValue(0).ToString().Trim();
        //                with_1.FolderPath = SqlDR3.GetValue(1).ToString().Trim();
        //                with_1.UserID = SqlDR3.GetValue(2).ToString().Trim();
        //                with_1.CreatedIn = SqlDR3.GetValue(3).ToString().Trim();
        //                with_1.Disc = SqlDR3.GetValue(4).ToString().Trim();
        //                with_1.ProID = SqlDR3.GetValue(5).ToString().Trim();
        //                with_1.ParentID = SqlDR3.GetValue(6).ToString().Trim();
        //                SqlDR3.Close();
        //                //4- Get the user name who create this folder
        //                SqlCmd3.CommandText = "Select UserName from dbo.Users where UsrID=" + AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].UserID;
        //                AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].UserName = (string)(SqlCmd3.ExecuteScalar());
        //                //5- Get Project name of this folder
        //                SqlCmd3.CommandText = "Select ProName from dbo.Projects where ProID=" + AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].ProID;
        //                AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].ProName = (string)(SqlCmd3.ExecuteScalar());
        //                //SqlDR2.Close()
        //                //6- Get Rull Name
        //                SqlCmd3.CommandText = "Select RullName from dbo.Rulls where RullID='" + AllFoldersWithPrv.PrvOperationsType[AllFoldersWithPrv.PrvOperationsType.Length - 1].RullID + "'";
        //                AllFoldersWithPrv.PrvOperationsType[AllFoldersWithPrv.PrvOperationsType.Length - 1].RullName = (string)(SqlCmd3.ExecuteScalar());
        //                //7- Get All Files Withen This Folder
        //                SqlCmd3.CommandText = "Select FileID,[FileName],FilePath,CreatedIn,UsrID,Dis,ProID,TypeID,InUseUserID,InUse from dbo.FileInfo where FolderID='" + AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].FolderID + "' and  Active=1";
        //                SqlDR3 = SqlCmd3.ExecuteReader();
        //                while (SqlDR3.Read())
        //                {
        //                    if (AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files == null)
        //                    {
        //                        AllFoldersWithPrv.FolderInfo = new FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1 + 1];
        //                    }
        //                    else
        //                    {
        //                        Array.Resize(ref AllFoldersWithPrv.FolderInfo, AllFoldersWithPrv.FolderInfo.Length - 1 + 1);
        //                    }
        //                    FileInfo with_2 = AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files[AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files.Length - 1];
        //                    with_2.FolderID = AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].FolderID;
        //                    with_2.FileID = SqlDR3.GetString(0).Trim();
        //                    with_2.FileName = SqlDR3.GetString(1).Trim();
        //                    with_2.FilePath = DataPath + SqlDR3.GetString(2).Trim();
        //                    with_2.CreatedIn = SqlDR3.GetValue(3).ToString().Trim();
        //                    with_2.UsrID = SqlDR3.GetString(4).Trim();
        //                    with_2.Dis = SqlDR3.GetValue(5).ToString().Trim();
        //                    with_2.ProID = SqlDR3.GetString(6).Trim();
        //                    with_2.TypeID = SqlDR3.GetValue(7).ToString().Trim();
        //                    with_2.InUseUserID = SqlDR3.GetValue(8).ToString().Trim();
        //                    with_2.InUse = SqlDR3.GetValue(9).ToString().Trim();
        //                    //8- Get User name that create this file
        //                    SqlCmd4.CommandText = "select UserName from dbo.Users where UsrID=" + AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files[AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files.Length - 1].UsrID;
        //                    AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files[AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files.Length - 1].UserName = (string)(SqlCmd4.ExecuteScalar());
        //                    //9- Get User who lock this file
        //                    if (SqlDR3.IsDBNull(8) == false)
        //                    {
        //                        SqlCmd4.CommandText = "select UserName from dbo.Users where UsrID=" + SqlDR3.GetString(8).Trim();
        //                        AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files[AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files.Length - 1].InUseUserName = SqlCmd4.ExecuteScalar().ToString().Trim();
        //                    }
        //                    //10- Get TypeName of this file
        //                    for (i = 0; i <= AllFilesType.Length - 1; i++)
        //                    {
        //                        if (AllFilesType[i].TypeID == AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files[AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files.Length - 1].TypeID)
        //                        {
        //                            AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files[AllFoldersWithPrv.FolderInfo[AllFoldersWithPrv.FolderInfo.Length - 1].Files.Length - 1].TypeName = AllFilesType[i].TypeName;
        //                            break;
        //                        }
        //                    }
        //                }
        //                SqlDR3.Close();
        //            NextLoop:
        //                1.GetHashCode(); //nop
        //            }
        //            SqlDR2.Close();
        //        }
        //        SQLDR.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Interaction.MsgBox(ex.StackTrace, MsgBoxStyle.Information, null);
        //    }
        ////ExitPoint:
        //    SQLDR.Close();
        //    SQLCon.Close();
        //    SqlCon2.Close();
        //    SqlCon3.Close();
        //    //Ordering
        //    int Int2;
        //    if (AllFoldersWithPrv.FolderInfo != null)
        //    {
        //        for (Int1 = 1; Int1 <= 5; Int1++)
        //        {
        //            for (Int2 = 0; Int2 <= AllFoldersWithPrv.FolderInfo.Length - 1; Int2++)
        //            {
        //                if (AllFoldersWithPrv.FolderInfo[Int2].FolderPath.Split("\\".ToCharArray()).Length == Int1)
        //                {
        //                    if (AllFoldersWithPrv2.FolderInfo == null)
        //                    {
        //                        AllFoldersWithPrv2.FolderInfo = new FolderInfo[1];
        //                        AllFoldersWithPrv2.PrvOperationsType = new PrvOperationsType[1];
        //                    }
        //                    else
        //                    {
        //                        Array.Resize(ref AllFoldersWithPrv2.FolderInfo, AllFoldersWithPrv2.FolderInfo.Length + 1);
        //                        Array.Resize(ref AllFoldersWithPrv2.PrvOperationsType, AllFoldersWithPrv2.PrvOperationsType.Length + 1);
        //                    }
        //                    AllFoldersWithPrv2.FolderInfo[AllFoldersWithPrv2.FolderInfo.Length - 1] = AllFoldersWithPrv.FolderInfo[Int2];
        //                    AllFoldersWithPrv2.FolderInfo[AllFoldersWithPrv2.FolderInfo.Length - 1] = AllFoldersWithPrv.FolderInfo[Int2];
        //                    AllFoldersWithPrv2.FolderInfo[AllFoldersWithPrv2.FolderInfo.Length - 1].FolderPath = DataPath + AllFoldersWithPrv2.FolderInfo[AllFoldersWithPrv2.FolderInfo.Length - 1].FolderPath;
        //                    AllFoldersWithPrv2.PrvOperationsType[AllFoldersWithPrv2.PrvOperationsType.Length - 1] = AllFoldersWithPrv.PrvOperationsType[Int2];
        //                }
        //            }
        //        }
        //    }
        }
        public void GetAllprivilege()
        {
            try
            {
                Allprivilege = new privilegeType[1];
                SQLCmd.CommandText = "select RullID,RullName from dbo.Rulls";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    Allprivilege[Allprivilege.Length - 1].privilegeID = SQLDR.GetValue(0).ToString().Trim();
                    Allprivilege[Allprivilege.Length - 1].privilegeName = SQLDR.GetValue(1).ToString().Trim();
                    Allprivilege[Allprivilege.Length - 1].privilegeSelected = false;
                    Allprivilege[Allprivilege.Length - 1].CanDelete = 0;
                    Allprivilege[Allprivilege.Length - 1].CanWrite = 0;
                    Allprivilege[Allprivilege.Length - 1].CanAdd = 0;
                    Allprivilege[Allprivilege.Length - 1].CanView = 0;
                    Array.Resize(ref Allprivilege, Allprivilege.Length + 1);
                }
                Array.Resize(ref Allprivilege, Allprivilege.Length - 2 + 1);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public string GetUserPrivilages()
        {
            try
            {
                SQLCmd.CommandText = String.Format("Select RullID from dbo.Users_Rulls where UsrID = '{0}'", CUser.UID);
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (CUser.UsrPrv == null)
                        CUser.UsrPrv = new privilegeType[1];
                    else
                        Array.Resize(ref CUser.UsrPrv, CUser.UsrPrv.Length + 1);
                    //CUser.UsrPrv = (privilegeType[])MCls.changeArrayLength(CUser.UsrPrv, true);// Changing Length With Function
                    CUser.UsrPrv[CUser.UsrPrv.Length - 1].privilegeID = SQLDR.GetString(0).Trim();
                }
            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        
        public void GetSelectedFolderprivilege(string FolderID)
        {
            try
            {
                GetAllprivilege();
                SQLCmd.CommandText = String.Format("select RullID, CanWrite, CanDelete, CanAdd, CanView from Folder_Rull where FolderID = '{0}'", FolderID);
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                string RullID = "";
                while (SQLDR.Read())
                {
                    RullID = SQLDR.GetValue(0).ToString().Trim();
                    int i = 0;
                    for (i = 0; i <= Allprivilege.Length - 1; i++)
                    {
                        if (RullID == Allprivilege[i].privilegeID)
                        {
                            Allprivilege[i].privilegeSelected = true;
                            Allprivilege[i].CanWrite = int.Parse(SQLDR.GetValue(1).ToString().Trim());
                            Allprivilege[i].CanDelete = int.Parse(SQLDR.GetValue(2).ToString().Trim());
                            Allprivilege[i].CanAdd = int.Parse(SQLDR.GetValue(3).ToString().Trim());
                            Allprivilege[i].CanView = int.Parse(SQLDR.GetValue(4).ToString().Trim());
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public string SaveFolderprivileges(string FolderID, string[] privilegesID, bool CanWrite, bool CanDelete, bool AddOrRemove)
        {
            try
            {
                SQLCon.Open();
                short Write;

                if (CanWrite == true)
                {
                    Write = (short)1;
                }
                else
                {
                    Write = (short)0;
                }
                short Delete;

                if (CanWrite == true)
                {
                    Delete = (short)1;
                }
                else
                {
                    Delete = (short)0;
                }
                SQLTrn = SQLCon.BeginTransaction("[Egy]FalseX");
                SQLCmd.Transaction = SQLTrn;
                short Int1;
                if (AddOrRemove == true)
                {
                    for (Int1 = 0; Int1 <= privilegesID.Length - 1; Int1++)
                    {
                        SQLCmd.CommandText = (string)("SP_InsertNewFolderPrivilege @FolderID='" + FolderID + "', @RullID='" + privilegesID[Int1] + "', @CanWrite=" + Write + ", @CanDelete=" + Delete);
                        SQLCmd.ExecuteNonQuery();
                        SQLCmd.CommandText = "SP_InsertNewFolderParentPrivilege @FolderID='" + FolderID + "', @RullID='" + privilegesID[Int1] + "'";
                        SQLCmd.ExecuteNonQuery();

                    }
                }
                else
                {
                    for (Int1 = 0; Int1 <= privilegesID.Length - 1; Int1++)
                    {
                        SQLCmd.CommandText = "Delete from dbo.Folder_Rull where FolderID='" + FolderID + "' and RullID='" + privilegesID[Int1] + "'";
                        SQLCmd.ExecuteNonQuery();
                    }
                }
                SQLTrn.Commit();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                SQLTrn.Rollback();
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string RemoveFile(string FileID)
        {
            try
            {
                SQLCmd.CommandText = "delete from FileInfo where FileID='" + FileID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return (ex.Message);
            }
            SQLCon.Close();
            return null;
        }
        public string InsertNewFolder(string FolderName, string FolderPath, string CreatedIn, string UserID, string Disc, string ParentID)
        {
            string ErrorResult = null;
            try
            {
                SQLCmd.CommandText = String.Format("SP_InsertNewFolder @FolderName='{0}',@FolderPath='{1}',@CreatedIn='{2}',@UserID='{3}',@Disc='{4}',@ParentID='{5}'", FolderName, FolderPath, CreatedIn, UserID, Disc, ParentID);
                SQLCon.Open();
                ErrorResult = (string)(SQLCmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                SQLCon.Close();
                return null;
            }
            SQLCon.Close();
            return ErrorResult;
        }
        public string RemoveFolder(string FolderID)
        {
            try
            {
                SQLCon.Open();
                SQLTrn = SQLCon.BeginTransaction("Eshta ya rgala");
                SQLCmd.Transaction = SQLTrn;
                SQLCmd.CommandText = "delete from Folder_Rull where FolderID='" + FolderID + "'";
                SQLCmd.ExecuteNonQuery();
                SQLCmd.CommandText = "delete from dbo.folderinfo where folderid='" + FolderID + "'";
                SQLCmd.ExecuteNonQuery();
                SQLTrn.Commit();
            }
            catch (Exception ex)
            {
                SQLTrn.Rollback();
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetAllProjectsPrivileges()
        {
            try
            {
                AllProjectWithPrivileges = null;
                SQLCmd.CommandText = "Select ProID,ProName from dbo.Projects Select RullID,RullName,ProID from dbo.Rulls";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (AllProjectWithPrivileges == null)
                    {
                        AllProjectWithPrivileges = new ProjectWithprivilegesType[1];
                    }
                    else if (!(AllProjectWithPrivileges[AllProjectWithPrivileges.Length - 1].ProjectID == null))
                    {
                        Array.Resize(ref AllProjectWithPrivileges, AllProjectWithPrivileges.Length + 1);
                    }
                    AllProjectWithPrivileges[AllProjectWithPrivileges.Length - 1].ProjectID = SQLDR.GetValue(0).ToString().Trim();
                    AllProjectWithPrivileges[AllProjectWithPrivileges.Length - 1].ProjectName = SQLDR.GetValue(1).ToString().Trim();
                }
                short Int1 = (short)0;
                if (SQLDR.NextResult())
                {
                    while (SQLDR.Read())
                    {
                        for (Int1 = 0; Int1 <= AllProjectWithPrivileges.Length - 1; Int1++)
                        {
                            if (SQLDR.GetValue(2).ToString().Trim() == AllProjectWithPrivileges[Int1].ProjectID)
                            {
                                if (AllProjectWithPrivileges[Int1].InternalPrivileges == null)
                                {
                                    AllProjectWithPrivileges = new ProjectWithprivilegesType[Int1 + 1];
                                }
                                else if (!(AllProjectWithPrivileges[Int1].InternalPrivileges[AllProjectWithPrivileges[Int1].InternalPrivileges.Length - 1].privilegeID == null))
                                {
                                    Array.Resize(ref AllProjectWithPrivileges, Int1 + 1);
                                }
                                AllProjectWithPrivileges[Int1].InternalPrivileges[AllProjectWithPrivileges[Int1].InternalPrivileges.Length - 1].privilegeID = SQLDR.GetValue(0).ToString().Trim();
                                AllProjectWithPrivileges[Int1].InternalPrivileges[AllProjectWithPrivileges[Int1].InternalPrivileges.Length - 1].privilegeName = SQLDR.GetValue(1).ToString().Trim();
                                break;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }
        public string SaveFolderDesc(string FolderID, string Desc)
        {
            try
            {
                SQLCmd.CommandText = "update dbo.FolderInfo set Disc='" + Desc + "' where FolderID='" + FolderID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public bool ChagneFolderName(string FolderID, string FolderName, string NewPath, string Disc, string ProjectPath)
        {
            short steps = 0;
            DataRow FolderInfo_ = MCls.LoadDataTable(String.Format("Select FolderName, FolderPath, FolderName From FolderInfo Where FolderID = N'{0}'", FolderID), "").Rows[0];
            try
            {
                //Get all folders that inside the selected folder to rename therer pathes
                string FullPath = FolderInfo_["FolderPath"].ToString();
                DataTable FoldersToChage = MCls.LoadDataTable(string.Format("Select FolderID, FolderPath from FolderInfo Where FolderPath LIKE '%{0}%'", FullPath), "");
                //Get all files that inside the selected folder to rename therer pathes
                DataTable FilesToChage = MCls.LoadDataTable(string.Format("Select FileID, FilePath, FileName from FileInfo Where FilePath LIKE '%{0}%'", FullPath), "");
                //Renaming folders
                SqlCommand SqlCmd2 = new SqlCommand("", SQLCon, SQLTrn);
                SQLCon.Open();
                SQLTrn = SQLCon.BeginTransaction("Eshta ya rgala");
                SqlCmd2.Transaction = SQLTrn;
                string NewPath2;
                foreach (DataRow row in FoldersToChage.Rows)
                {
                    NewPath2 = row["FolderPath"].ToString().Replace(FolderInfo_["FolderName"].ToString(), FolderName);
                    SqlCmd2.CommandText = String.Format("Update dbo.FolderInfo set FolderPath = N'{0}' where FolderID = N'{1}'", NewPath2, row["FolderID"]);
                    SqlCmd2.ExecuteNonQuery();

                }
                SqlCmd2.CommandText = String.Format("update dbo.FolderInfo set FolderName = N'{0}', Disc = {1} where FolderID = N'{2}'", FolderName, Disc, FolderID);
                SqlCmd2.ExecuteNonQuery();
                //Renaming files
                foreach (DataRow row in FilesToChage.Rows)
                {
                    NewPath2 = row["FilePath"].ToString().Replace(FolderInfo_["FolderName"].ToString(), FolderName);
                    SqlCmd2.CommandText = String.Format("Update dbo.FileInfo set FilePath = N'{0}' where FileID = N'{1}'", NewPath2, row["FileID"]);
                    SqlCmd2.ExecuteNonQuery();
                }
                SQLTrn.Commit();
                SQLCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, null);
                SQLTrn.Rollback();
            }
            SQLCon.Close();
            return false;
        }
        public void InsertNewFile(string FileName, string FilePath, string CreatedIn, string UsrID, string Dis, string FolderID, string TypeID, ref string Result)
        {
            try
            {
                SQLCmd.CommandText = String.Format("SP_InsertNewFile @FileName='{0}',@FilePath='{1}',@CreatedIn='{2}',@UsrID='{3}',@Dis='{4}',@FolderID='{5}',@TypeID='{6}'", FileName, FilePath, CreatedIn, UsrID, Dis, FolderID, TypeID);
                SQLCon.Open();
                Result = (string)(SQLCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDR.Close();
            SQLCon.Close();
        }
        public string EditFileInfo(string FileID, string NewFileName, string NewDescription, string TypeID)
        {
            try
            {
                SQLCmd.CommandText = String.Format("Update dbo.FileInfo set FileName = '{0}', Dis = '{1}', TypeID = '{2}' where FileID='{3}'", NewFileName, NewDescription, TypeID, FileID);
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string LockFile(string FileID, string UserID)
        {
            try
            {
                SQLCmd.CommandText = "Update dbo.FileInfo Set InUseUserID='" + UserID + "',InUse=1 Where FileID='" + FileID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string UnLockFile(string FileID)
        {
            try
            {
                SQLCmd.CommandText = "Update dbo.FileInfo Set InUseUserID=NULL,InUse=0 Where FileID='" + FileID + "'";
                SQLCon.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SQLCon.Close();
                return ex.Message;
            }
            SQLCon.Close();
            return null;
        }
        public string GetAllLockedFileByUser(string UsrID, ref LockedFilesSTR[] LockedFiles)
        {
            LockedFiles = new LockedFilesSTR[0];
            try
            {
                SQLCmd.CommandText = "SP_GetAllLockFilesByUser @UsrID='" + UsrID + "'";
                SQLCon.Open();
                SQLDR = SQLCmd.ExecuteReader();
                while (SQLDR.Read())
                {
                    if (LockedFiles.Length == 0)
                    {
                        LockedFiles = new LockedFilesSTR[1];
                    }
                    else
                    {
                        Array.Resize(ref LockedFiles, LockedFiles.Length + 1);
                    }
                    LockedFiles[LockedFiles.Length - 1].FileID = SQLDR.GetString(0).Trim();
                    LockedFiles[LockedFiles.Length - 1].FileName = SQLDR.GetString(1).Trim();
                    LockedFiles[LockedFiles.Length - 1].FilePath = SQLDR.GetString(2).Trim();
                    LockedFiles[LockedFiles.Length - 1].ProjectName = SQLDR.GetString(3).Trim();
                    if (SQLDR.NextResult())
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                SQLDR.Close();
                SQLCon.Close();
                return ex.Message;
            }
            SQLDR.Close();
            SQLCon.Close();
            return null;
        }

        //Registry Functions
        public void PrepareReg()
        {
            RegistryKey RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            string[] arr;
            int ForInt = 0;
            arr = Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames();
            for (ForInt = 0; ForInt <= arr.Length - 1; ForInt++)
            {
                if (arr[ForInt] == "DataCenter")
                    return;
            }
            RegKey.CreateSubKey("DataCenter");
        }
        public void SetRegValue(string KeyValue, RegKeyValues ValueName)
        {
            //"SQLString"
            PrepareReg();
            Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", true).SetValue((string)(ValueName.ToString()), KeyValue);
        }
        public bool GetRegValue(ref string ConStr, RegKeyValues ValueName)
        {
            PrepareReg();
            string[] arr = Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", false).GetValueNames();
            int ForInt = 0;
            for (ForInt = 0; ForInt <= arr.Length - 1; ForInt++)
            {
                if (arr[ForInt] == ValueName.ToString())
                {
                    ConStr = (string)(Registry.LocalMachine.OpenSubKey("SOFTWARE\\DataCenter", false).GetValue((string)(ValueName.ToString())));
                    return true;
                }
            }
            return false;
        }
        public void ResetConnection()
        {
            Registry.LocalMachine.DeleteSubKey("SOFTWARE\\DataCenter");
            //Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", True).DeleteValue(RegKeyValues.PW)
        }
        //Binary Function
        public string CharToBinary(string Strings)
        {
            short @int;
            string fout = "";
            string @out = "";
            for (@int = 0; @int <= Strings.Length - 1; @int++)
            {
                long str2 = Microsoft.VisualBasic.Strings.Asc(Strings[@int]);
                str2 = (str2 * 9) / 8;
                long mydiv;
                while (str2 != 0)
                {
                    str2 = System.Math.DivRem(str2, 2, out mydiv);
                    if (mydiv > 0)
                    {
                        @out = (string)(1 + @out);
                    }
                    else
                    {
                        @out = (string)(0 + @out);
                    }
                }
                @out = new string('0', 8 - @out.Length) + @out;
                fout += @out;
                @out = "";
            }
            return fout;
        }
        public string Binarytochar(string Binarystring)
        {
            string fout = "";
            long back_to_normal;
            string[] arr = new string[(Binarystring.Length / 8) - 1 + 1];
            short i;
            for (i = 0; i <= (Binarystring.Length / 8) - 1; i++)
            {
                arr[i] = Binarystring.Substring(i * 8, 8);
            }
            for (i = 0; i <= arr.Length - 1; i++)
            {
                string str1 = (string)(arr[i].Substring(0, 4));
                string str2 = (string)(arr[i].Substring(4));
                short out1 = new short();
                short out2 = new short();
                if (str1[0] == '1')
                {
                    out1 += (short)8;
                }
                if (str1[1] == '1')
                {
                    out1 += (short)4;
                }
                if (str1[2] == '1')
                {
                    out1 += (short)2;
                }
                if (str1[3] == '1')
                {
                    out1++;
                }
                if (str2[0] == '1')
                {
                    out2 += (short)8;
                }
                if (str2[1] == '1')
                {
                    out2 += (short)4;
                }
                if (str2[2] == '1')
                {
                    out2 += (short)2;
                }
                if (str2[3] == '1')
                {
                    out2++;
                }
                out2 = (short)(out2 * 1);
                out1 = (short)(out1 * 16);
                back_to_normal = out1 + out2;
                back_to_normal = (back_to_normal * 8) / 9;
                fout += Strings.Chr((int)back_to_normal);
            }
            return fout;
        }
    }
    public class NetworkFunction
    {
        public enum Commands //this is the commands between the server and the client
        {
            Ping = 0, // command 0
            ReciveFile = 1, //command 1
            SendFile = 2, //command 2
            CreateFile = 3, //command 3
            CreateFolder = 4, //command 4
            RemoveFolder = 5, //Command 5
            RemoveFile = 6, //Command 6
            MoveFolder = 7 //Command 7
        }
        public string CreateFolder(string IP_Address, int RPort, string FolderPath)
        {
            string FullString = System.Convert.ToString((int)Commands.CreateFolder + FolderPath);
            byte[] Buffers = new byte[4097];
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            short Created;
            try
            {
                Buffers = Encoding.Default.GetBytes(FullString);
                Sok.Connect(IP_Address, RPort);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, FullString.Length, SocketFlags.None);
                    Sok.Receive(Buffers, 1, SocketFlags.None);
                    Created = (short)(Conversion.Val(Buffers[0]));
                    if (Created == 0)
                    {
                        Sok.Close();
                        Sok = null;
                        return "Can't create folder or folder already existed";
                    }
                }
                else
                {
                    return "No Connection available";
                }
            }
            catch (Exception ex)
            {
                try
                {

                    Sok.Close();
                    Sok = null;
                }
                catch
                {
                }
                return ex.Message;
            }
            try
            {

                Sok.Close();
                Sok = null;
            }
            catch
            {
            }
            return null;
        }
        public string MoveFolder(string IP_Address, int RPort, string TFolder, string DFolder)
        {
            string FullString = System.Convert.ToString((int)Commands.MoveFolder + TFolder + "/" + DFolder);
            byte[] Buffers = new byte[4097];
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            short Created;
            try
            {
                Buffers = Encoding.Default.GetBytes(FullString);
                Sok.Connect(IP_Address, RPort);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, FullString.Length, SocketFlags.None);
                    Sok.Receive(Buffers, 1, SocketFlags.None);
                    Created = (short)(Conversion.Val(Buffers[0]));
                    if (Created == 0)
                    {
                        Sok.Close();
                        Sok = null;
                        return "Can't create folder or folder already existed";
                    }
                }
                else
                {
                    return "No Connection available";
                }
            }
            catch (Exception ex)
            {
                try
                {

                    Sok.Close();
                    Sok = null;
                }
                catch
                {
                }
                return ex.Message;
            }
            try
            {

                Sok.Close();
                Sok = null;
            }
            catch
            {
            }
            return null;
        }
        public string RemoveFile(string IP_Address, int RPort, string FilePath, string TrashFolder)
        {
            string FullString = System.Convert.ToString((int)Commands.RemoveFile + FilePath + "/" + TrashFolder + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "\\");
            byte[] Buffers = new byte[4097];
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            short Created;
            try
            {
                Buffers = Encoding.Default.GetBytes(FullString);
                Sok.Connect(IP_Address, RPort);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, FullString.Length, SocketFlags.None);
                    Sok.Receive(Buffers, 1, SocketFlags.None);
                    Created = (short)(Conversion.Val(Buffers[0]));
                    if (Created == 0)
                    {
                        Sok.Close();
                        Sok = null;
                        return "Can't remove file or file in use";
                    }
                }
                else
                {
                    return "No Connection available";
                }
            }
            catch (Exception ex)
            {
                try
                {

                    Sok.Close();
                    Sok = null;
                }
                catch
                {
                }
                return ex.Message;
            }
            try
            {

                Sok.Close();
                Sok = null;
            }
            catch
            {
            }
            return null;
        }
        public object RemoveFolder(string IP_Address, int RPort, string FolderPath, string TrashFolder)
        {
            string FullString = System.Convert.ToString((int)Commands.RemoveFolder + FolderPath + "/" + TrashFolder + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "\\");
            byte[] Buffers = new byte[4097];
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            short Created;
            try
            {
                Buffers = Encoding.Default.GetBytes(FullString);
                Sok.Connect(IP_Address, RPort);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, FullString.Length, SocketFlags.None);
                    Sok.Receive(Buffers, 1, SocketFlags.None);
                    Created = (short)(Conversion.Val(Buffers[0]));
                    if (Created == 0)
                    {
                        Sok.Close();
                        Sok = null;
                        return "Can't remove file or file in use";
                    }
                }
                else
                {
                    return "No Connection available";
                }
            }
            catch (Exception ex)
            {
                try
                {

                    Sok.Close();
                    Sok = null;
                }
                catch
                {
                }
                return ex.Message;
            }
            try
            {

                Sok.Close();
                Sok = null;
            }
            catch
            {
            }
            return null;
        }
    }
}