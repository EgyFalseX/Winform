using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace RealEstate
{
    public class MyCL
    {
        #region -   Variables   -

        public static string AccConStr = string.Empty;
        public static UserInfoStruct UserInfo = new UserInfoStruct();
        public static readonly string DBPath = Application.StartupPath + "\\DBPath";
        public static readonly string CReportsPath = Application.StartupPath + "\\CReports";
        public static string FileName = "StyleSettings";
        public static string ReportURL = string.Empty;
        public static string ReportPath = string.Empty;
        public static string ActionLog = string.Empty;
        public static string PicPath = @"D:\RealEstate\PIC\";
        public static CRReportsStr[] crRep;
        //struct
        public struct UserInfoStruct
        {
            public string UserID;
            public string UserName;
        }
        public struct CRReportsStr
        {
            public ReportDocument CRReport;
            public string RepCaption;
        }
        //Forms - Main
        public ActionLogFrm FrmActionLog;
        //Forms - Codes
        public CdAreaFrm FrmCdArea;
        public CdEstateCaseFrm FrmCdEstateCase;
        public CdperiodFrm FrmCdperiod;
        public CdTypeEstateFrm FrmCdTypeEstate;
        public BasicDataFrm FrmBasicData;
        public cdnationaltyFrm Frmcdnationalty;
        //Forms - Permission
        //Forms - Data
        public TblOwnerFrm FrmTblOwner;
        public TblEstateFrm FrmTblEstate;
        public BuyContractFrm FrmBuyContract;
        //Forms - Qry
        public QryTblEstateFrm FrmQryTblEstate;
        //Forms - Options

        #endregion
        #region -   Functions   -
        public static void LoadCRReports()
        {
            if (!File.Exists(CReportsPath + "\\CReports.txt"))// Check If DBPass is Exists
                return;
            using (StreamReader sr = new StreamReader(CReportsPath + "\\CReports.txt", Encoding.Default))// Read Connection String
            {
                crRep = new CRReportsStr[0];
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Array.Resize<CRReportsStr>(ref crRep, crRep.Length + 1);
                    string[] Parts = line.Split(Convert.ToChar(";"));
                    crRep[crRep.Length - 1].CRReport = new ReportDocument();
                    crRep[crRep.Length - 1].CRReport.Load(String.Format("{0}\\{1}", CReportsPath, Parts[0]));
                    crRep[crRep.Length - 1].RepCaption = Parts[1];
                }
            }
        }
        public static void ShowMsg(string Msg, bool IsError, Form ThisForm)
        {
            try
            {
                FrmMain ParentFrm = (FrmMain)ThisForm.Parent.Parent;
                ParentFrm.siInfo.Caption = Msg;
                if (IsError)
                    ParentFrm.siInfo.Appearance.ForeColor = System.Drawing.Color.Red;
                else
                    ParentFrm.siInfo.Appearance.ForeColor = System.Drawing.Color.Green;
                ActionLog += String.Format("[{0}] [{1}] : ({2}){3}", DateTime.Now.ToShortTimeString(), ThisForm.Text, Msg, Environment.NewLine);
            }
            catch 
            {            }
        }
        public static string ConvertToDateDMY(string PDate)
        {
            string ReturnMe = string.Empty;
            DateTime MyDate = Convert.ToDateTime(PDate);
            ReturnMe = String.Format("{0}/{1}/{2}", MyDate.Day, MyDate.Month, MyDate.Year);
            return ReturnMe;
        }
        public static string ConvertToDateHMS(string PDate)
        {

            string ReturnMe = string.Empty;
            DateTime MyDate = Convert.ToDateTime(PDate);
            ReturnMe = String.Format("{0}:{1}:{2}", MyDate.Hour, MyDate.Minute, MyDate.Second);
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
        public static bool CheckDBWorking(string AccessConnectionString)
        {
            using (OleDbConnection con = new OleDbConnection(AccessConnectionString))
            {
                try
                {
                    con.Open();
                    con.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static DataTable LoadDataTable(string CommandString)
        {
            DataTable ReturnMe = new DataTable("False2011-09");
            using (OleDbDataAdapter DA = new OleDbDataAdapter(CommandString, MyCL.AccConStr))
            {
                try { DA.Fill(ReturnMe); }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return ReturnMe;
        }
        public static string GetNewID(string TableName, string ColunmName)
        {
            string ReturnMe = string.Empty;
            using (OleDbConnection con = new OleDbConnection(MyCL.AccConStr))
            {
                OleDbCommand cmd = new OleDbCommand("", con);
                try
                {
                    con.Open();
                    cmd.CommandText = string.Format(@"SELECT IIF(IsNull(MAX({0})), 1, MAX({0}) + 1) AS NewID FROM {1}", ColunmName, TableName);
                    //cmd.CommandText = string.Format(@"SELECT ISNULL(MAX({0}) + 1, 1) AS NewID FROM {1} AS NewID", ColunmName, TableName);
                    ReturnMe = cmd.ExecuteScalar().ToString();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            return ReturnMe;
        }
        public bool LoadUserInfo(string username, string password)
        {
            DataTable TblUser = LoadDataTable(String.Format(@"SELECT * FROM Users
                                                                          WHERE (UserName = '{0}') AND (UserPass = '{1}') AND (IsActive = 1)", username, password));
            foreach (DataRow row in TblUser.Rows)
            {
                UserInfo = new UserInfoStruct { UserID = row["UserID"].ToString(), UserName = row["UserName"].ToString() };
                return true;
            }
            return false;
        }
        public static string CleanSQLValue(string Value)
        {
            if (Value == string.Empty)
                return string.Empty;
            return Value.Replace("'", "''");
        }
        private static bool SaveDBPath()
        {
            try
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                //AccConStr = string.Empty;

                //OpenFileDialog OFD = new OpenFileDialog { CheckFileExists = true, CheckPathExists = true, Filter = "Access Database|*.mdb|All Files|*.*", Title = "اختار قاعدة بيانات" };
                //if (OFD.ShowDialog() == DialogResult.Cancel)// Choose FileName
                //        Application.Exit();
                //AccConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + OFD.FileName;// Assign FileName to Connection String

                if (CheckDBWorking(AccConStr) == false)// Check if Connection is Working ...
                    return false;
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.

                using (BinaryWriter writer = new BinaryWriter(File.Open(DBPath, FileMode.Create)))
                {
                    //byte[] byz = Strin2Bytes(AccConStr);
                    writer.Write(Strin2Bytes(AccConStr));
                    writer.Close();
                    return true;
                }
                
            }
            catch
            {
                return false;
            }
        }
        public static bool LoadDBPath()
        {
            try
            {
                if (!File.Exists(DBPath))// Check If DBPass is Exists
                {
                    OpenFileDialog OFD = new OpenFileDialog { CheckFileExists = true, CheckPathExists = true, Filter = "Access Database|*.mdb|All Files|*.*", Title = "اختار قاعدة بيانات" };
                    if (OFD.ShowDialog() == DialogResult.Cancel)// Choose FileName
                        Application.Exit();
                    AccConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + OFD.FileName;// Assign FileName to Connection String
                    if (CheckDBWorking(AccConStr) == false)// Check if Connection is Working ...
                    {
                        MessageBox.Show(String.Format("لم يتم اختيار قاعده البيانات بطريقه صحيحه{0}تم اغلاق البرنامج", Environment.NewLine));
                        Application.Exit();
                    }
                    else
                        SaveDBPath();//Save Connection String To File
                }
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                AccConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Bytes2String(File.ReadAllBytes(DBPath));
                if (CheckDBWorking(AccConStr))
                    return true;
                else
                {
                    if (File.Exists(DBPath))
                        File.Delete(DBPath);
                    Application.Restart();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static byte[] Strin2Bytes(string Text)
        {
            string hex = string.Empty;
            foreach (char c in Text)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)Convert.ToUInt32(tmp.ToString()));
            }

            return Encoding.Default.GetBytes(hex);
            //return Encoding.Default.GetBytes(Text);
        }
        public static string Bytes2String(byte[] Bytez)
        {
            string ConvThis = System.Text.Encoding.ASCII.GetString(Bytez);
            byte[] raw = new byte[ConvThis.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(ConvThis.Substring(i * 2, 2), 16);
            }
            return System.Text.Encoding.ASCII.GetString(raw);
            //return System.Text.Encoding.ASCII.GetString(Bytez);
        }
        
        #endregion
    }
}
