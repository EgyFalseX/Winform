using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Retirement
{
    public class SQLProvider
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
            //public ReportDocument CRReport;
            public string RepCaption;
        }

        #endregion
        #region -   Functions   -
        public static void LoadCRReports()
        {
            //if (!File.Exists(CReportsPath + "\\CReports.txt"))// Check If DBPass is Exists
            //    return;
            //using (StreamReader sr = new StreamReader(CReportsPath + "\\CReports.txt", Encoding.Default))// Read Connection String
            //{
            //    crRep = new CRReportsStr[0];
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Array.Resize<CRReportsStr>(ref crRep, crRep.Length + 1);
            //        string[] Parts = line.Split(Convert.ToChar(";"));
            //        crRep[crRep.Length - 1].CRReport = new ReportDocument();
            //        crRep[crRep.Length - 1].CRReport.Load(String.Format("{0}\\{1}", CReportsPath, Parts[0]));
            //        crRep[crRep.Length - 1].RepCaption = Parts[1];
            //    }
            //}
        }
        private static void InsertEmptyValue(ref SqlCommand cmd)
        {
            foreach (SqlParameter item in cmd.Parameters)
            {
                if (FXFW.SqlDB.IsNullOrEmpty(item.Value))
                {
                    if (item.SqlDbType == SqlDbType.Bit)
                        item.Value = "False";
                    else
                        item.Value = DBNull.Value;
                }

            }
        }
        #region -   Selecting   -
        //Codes
        public static DataTable SelectCDGender()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT GenderId, Gender FROM CDGender");
        }
        public static DataTable SelectCDGov()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT GovId, GOV FROM CDGov");
        }
        public static DataTable SelectCDMarkez()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MarkezId, Markez, GovId FROM CDMarkez");
        }
        public static DataTable SelectCDSyndicate()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT SyndicateId, Syndicate FROM CDSyndicate");
        }
        public static DataTable SelectCDSubCommitte()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT SubCommitteId, SubCommitte, SyndicateId FROM CDSubCommitte");
        }
        public static DataTable SelectCDWarasaType()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT WarasaTypeId, WarasaType, feasarf FROM CDWarasaType");
        }
        public static DataTable SelectCDMashHala()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MashHalaId, MashHala, feasarfa FROM CDMashHala");
        }
        //Data
        public static DataTable SelectTBLMashat()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MMashatId, MMashatNId, MMashatName, BirthDate, MMashatGender, MMashataddresGov, MMashataddresMarkez, 
            MMashataddres, MMashatPhone, MMashatMobil, MMashatMail, WorkeEndDate, KideNumber, ZmalaEshtrakDate, SyndicateId, SubCommitteId, MemberShipNumber, 
            MashHalaId, sarfnumber FROM TBLMashat");
        }
        public static DataTable SelectTBLMashatList()
        {
            return FXFW.SqlDB.LoadDataTable(@"
            SELECT MMashatId, MMashatNId, MMashatName, BirthDate, MMashatGender, MMashataddresGov, MMashataddresMarkez, 
            MMashataddres, MMashatPhone, MMashatMobil, MMashatMail, WorkeEndDate, KideNumber, ZmalaEshtrakDate, SyndicateId, SubCommitteId, MemberShipNumber,
            (SELECT MashHala FROM CDMashHala WHERE MashHalaId = TBLMashat.MashHalaId) AS MashHala,
            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLMashat.SubCommitteId) AS SubCommitte,
            MashHalaId, sarfnumber FROM TBLMashat");
        }
        public static DataTable SelectTBLWarasa(object MMashatId)
        {
            if (MMashatId == null)
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT PersonId, MMashatId, WarasaTypeId, personName, personAddres, SyndicateId, SubCommitteId, 
                personphone, personmobile, personbirth, SarfHalaId, personrem FROM TBLWarasa");
            }
            else
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT PersonId, MMashatId, WarasaTypeId, personName, personAddres, SyndicateId, SubCommitteId, 
                personphone, personmobile, personbirth, SarfHalaId, personrem, PersonId AS org_PersonId, MMashatId AS org_MMashatId FROM TBLWarasa WHERE MMashatId = " + MMashatId);
            }
        }
        public static DataTable SelectTBLDofatSarf()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT DofatSarfId, DofatSarf, DofatSarfDate, remd FROM TBLDofatSarf");
        }
        #endregion
        #region -   Inserting   -
        //Code
        public static bool InsertCDGov(string GOV)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GOV", SqlDbType.NVarChar) { Value = GOV });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDGov (GovId, GOV) VALUES ((SELECT ISNULL(MAX(GovId) + 1, 1) FROM CDGov), @GOV)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDMarkez(string Markez, string GovId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Markez", SqlDbType.NVarChar) { Value = Markez });
            cmd.Parameters.Add(new SqlParameter("@GovId", SqlDbType.TinyInt) { Value = GovId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDMarkez (MarkezId, Markez, GovId) VALUES ((SELECT ISNULL(MAX(MarkezId) + 1, 1) FROM CDMarkez), @Markez, @GovId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDSyndicate(string Syndicate)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Syndicate", SqlDbType.NVarChar) { Value = Syndicate });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDSyndicate (SyndicateId, Syndicate) VALUES ((SELECT ISNULL(MAX(SyndicateId) + 1, 1) FROM CDSyndicate), @Syndicate)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDSubCommitte(string SubCommitte, string SyndicateId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SubCommitte", SqlDbType.NVarChar) { Value = SubCommitte });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.TinyInt) { Value = SyndicateId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDSubCommitte (SubCommitteId, SubCommitte, SyndicateId) 
                VALUES ((SELECT ISNULL(MAX(SubCommitteId) + 1, 1) FROM CDSubCommitte), @SubCommitte, @SyndicateId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDWarasaType(string WarasaType, string feasarf)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WarasaType", SqlDbType.NVarChar) { Value = WarasaType });
            cmd.Parameters.Add(new SqlParameter("@feasarf", SqlDbType.Float) { Value = feasarf });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDWarasaType (WarasaTypeId, WarasaType, feasarf) 
                VALUES ((SELECT ISNULL(MAX(WarasaTypeId) + 1, 1) FROM CDWarasaType), @WarasaType, @feasarf)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDMashHala(string MashHala, string feasarfa)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MashHala", SqlDbType.NVarChar) { Value = MashHala });
            cmd.Parameters.Add(new SqlParameter("@feasarfa", SqlDbType.Float) { Value = feasarfa });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDMashHala (MashHalaId, MashHala, feasarfa) 
                VALUES ((SELECT ISNULL(MAX(MashHalaId) + 1, 1) FROM CDMashHala), @MashHala, @feasarfa)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLMashat(object MMashatNId, object MMashatName, object BirthDate, object MMashatGender, object MMashataddresGov,
            object MMashataddresMarkez, object MMashataddres, object MMashatPhone, object MMashatMobil, object MMashatMail, object WorkeEndDate, object KideNumber, object ZmalaEshtrakDate,
            object SyndicateId, object SubCommitteId, object MemberShipNumber, object MashHalaId, object sarfnumber)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MMashatNId", SqlDbType.NVarChar) { Value = MMashatNId });
            cmd.Parameters.Add(new SqlParameter("@MMashatName", SqlDbType.NVarChar) { Value = MMashatName });
            cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Value = BirthDate });
            cmd.Parameters.Add(new SqlParameter("@MMashatGender", SqlDbType.TinyInt) { Value = MMashatGender });
            cmd.Parameters.Add(new SqlParameter("@MMashataddresGov", SqlDbType.TinyInt) { Value = MMashataddresGov });
            cmd.Parameters.Add(new SqlParameter("@MMashataddresMarkez", SqlDbType.Int) { Value = MMashataddresMarkez });
            cmd.Parameters.Add(new SqlParameter("@MMashataddres", SqlDbType.NVarChar) { Value = MMashataddres });
            cmd.Parameters.Add(new SqlParameter("@MMashatPhone", SqlDbType.NVarChar) { Value = MMashatPhone });
            cmd.Parameters.Add(new SqlParameter("@MMashatMobil", SqlDbType.NVarChar) { Value = MMashatMobil });
            cmd.Parameters.Add(new SqlParameter("@MMashatMail", SqlDbType.NVarChar) { Value = MMashatMail });
            cmd.Parameters.Add(new SqlParameter("@WorkeEndDate", SqlDbType.Date) { Value = WorkeEndDate });
            cmd.Parameters.Add(new SqlParameter("@KideNumber", SqlDbType.Int) { Value = KideNumber });
            cmd.Parameters.Add(new SqlParameter("@ZmalaEshtrakDate", SqlDbType.Date) { Value = ZmalaEshtrakDate });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@MemberShipNumber", SqlDbType.Int) { Value = MemberShipNumber });
            cmd.Parameters.Add(new SqlParameter("@MashHalaId", SqlDbType.TinyInt) { Value = MashHalaId });
            cmd.Parameters.Add(new SqlParameter("@sarfnumber", SqlDbType.Int) { Value = sarfnumber });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMashat (MMashatId, MMashatNId, MMashatName, BirthDate, MMashatGender, MMashataddresGov, MMashataddresMarkez, 
                MMashataddres, MMashatPhone, MMashatMobil, MMashatMail, WorkeEndDate, KideNumber, ZmalaEshtrakDate, SyndicateId, SubCommitteId, MemberShipNumber, 
                MashHalaId, sarfnumber)
                VALUES ((SELECT ISNULL(MAX(MMashatId) + 1, 1) FROM TBLMashat), @MMashatNId, @MMashatName, @BirthDate, @MMashatGender, @MMashataddresGov, @MMashataddresMarkez, 
                @MMashataddres, @MMashatPhone, @MMashatMobil, @MMashatMail, @WorkeEndDate, @KideNumber, @ZmalaEshtrakDate, @SyndicateId, @SubCommitteId, @MemberShipNumber, 
                @MashHalaId, @sarfnumber)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLWarasa(object MMashatId, object WarasaTypeId, object personName, object personAddres, object SyndicateId, object SubCommitteId,
            object personphone, object personmobile, object personbirth, object SarfHalaId, object personrem)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MMashatId", SqlDbType.Int) { Value = MMashatId });
            cmd.Parameters.Add(new SqlParameter("@WarasaTypeId", SqlDbType.TinyInt) { Value = WarasaTypeId });
            cmd.Parameters.Add(new SqlParameter("@personName", SqlDbType.NVarChar) { Value = personName });
            cmd.Parameters.Add(new SqlParameter("@personAddres", SqlDbType.NVarChar) { Value = personAddres });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@personphone", SqlDbType.NVarChar) { Value = personphone });
            cmd.Parameters.Add(new SqlParameter("@personmobile", SqlDbType.NVarChar) { Value = personmobile });
            cmd.Parameters.Add(new SqlParameter("@personbirth", SqlDbType.Date) { Value = personbirth });
            cmd.Parameters.Add(new SqlParameter("@SarfHalaId", SqlDbType.TinyInt) { Value = SarfHalaId });
            cmd.Parameters.Add(new SqlParameter("@personrem", SqlDbType.NVarChar) { Value = personrem });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLWarasa (PersonId, MMashatId, WarasaTypeId, personName, personAddres, SyndicateId, SubCommitteId, 
                personphone, personmobile, personbirth, SarfHalaId, personrem) VALUES ((SELECT ISNULL(MAX(PersonId) + 1, 1) FROM TBLWarasa), @MMashatId, 
                @WarasaTypeId, @personName, @personAddres, @SyndicateId, @SubCommitteId, @personphone, @personmobile, @personbirth, @SarfHalaId, @personrem)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLDofatSarf(object DofatSarf, object DofatSarfDate, object remd)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@DofatSarf", SqlDbType.NVarChar) { Value = DofatSarf });
            cmd.Parameters.Add(new SqlParameter("@DofatSarfDate", SqlDbType.Date) { Value = DofatSarfDate });
            cmd.Parameters.Add(new SqlParameter("@remd", SqlDbType.NVarChar) { Value = remd });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLDofatSarf (DofatSarfId, DofatSarf, DofatSarfDate, remd) 
                VALUES ((SELECT ISNULL(MAX(DofatSarfId) + 1, 1) FROM TBLDofatSarf), @DofatSarf, @DofatSarfDate, @remd)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        #endregion
        #region -   Updating   -
        //Code
        public static bool UpdateCDGov(string GovId, string GOV)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GOV", SqlDbType.NVarChar) { Value = GOV });
            cmd.Parameters.Add(new SqlParameter("@GovId", SqlDbType.TinyInt) { Value = GovId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDGov SET GOV = @GOV WHERE GovId = @GovId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDMarkez(string MarkezId, string Markez, string GovId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MarkezId", SqlDbType.Int) { Value = MarkezId });
            cmd.Parameters.Add(new SqlParameter("@Markez", SqlDbType.NVarChar) { Value = Markez });
            cmd.Parameters.Add(new SqlParameter("@GovId", SqlDbType.TinyInt) { Value = GovId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDMarkez SET Markez = @Markez, GovId = @GovId WHERE MarkezId = @MarkezId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDSyndicate(string SyndicateId, string Syndicate)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@Syndicate", SqlDbType.NVarChar) { Value = Syndicate });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDSyndicate SET Syndicate = @Syndicate WHERE SyndicateId = @SyndicateId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDSubCommitte(string SubCommitteId, string SubCommitte, string SyndicateId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitte", SqlDbType.NVarChar) { Value = SubCommitte });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDSubCommitte SET SubCommitte = @SubCommitte, SyndicateId = @SyndicateId WHERE SubCommitteId = @SubCommitteId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDWarasaType(string WarasaTypeId, string WarasaType, string feasarf)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WarasaTypeId", SqlDbType.Int) { Value = WarasaTypeId });
            cmd.Parameters.Add(new SqlParameter("@WarasaType", SqlDbType.NVarChar) { Value = WarasaType });
            cmd.Parameters.Add(new SqlParameter("@feasarf", SqlDbType.Int) { Value = feasarf });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDWarasaType SET WarasaType = @WarasaType, feasarf = @feasarf WHERE WarasaTypeId = @WarasaTypeId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDMashHala(string MashHalaId, string MashHala, string feasarfa)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MashHalaId", SqlDbType.Int) { Value = MashHalaId });
            cmd.Parameters.Add(new SqlParameter("@MashHala", SqlDbType.NVarChar) { Value = MashHala });
            cmd.Parameters.Add(new SqlParameter("@feasarfa", SqlDbType.Int) { Value = feasarfa });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDMashHala SET MashHala = @MashHala, feasarfa = @feasarfa WHERE MashHalaId = @MashHalaId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        //Data
        public static bool UpdateTBLMashat(object MMashatId, object MMashatNId, object MMashatName, object BirthDate, object MMashatGender, object MMashataddresGov,
    object MMashataddresMarkez, object MMashataddres, object MMashatPhone, object MMashatMobil, object MMashatMail, object WorkeEndDate, object KideNumber, object ZmalaEshtrakDate,
    object SyndicateId, object SubCommitteId, object MemberShipNumber, object MashHalaId, object sarfnumber)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MMashatId", SqlDbType.Int) { Value = MMashatId });
            cmd.Parameters.Add(new SqlParameter("@MMashatNId", SqlDbType.NVarChar) { Value = MMashatNId });
            cmd.Parameters.Add(new SqlParameter("@MMashatName", SqlDbType.NVarChar) { Value = MMashatName });
            cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Value = BirthDate });
            cmd.Parameters.Add(new SqlParameter("@MMashatGender", SqlDbType.TinyInt) { Value = MMashatGender });
            cmd.Parameters.Add(new SqlParameter("@MMashataddresGov", SqlDbType.TinyInt) { Value = MMashataddresGov });
            cmd.Parameters.Add(new SqlParameter("@MMashataddresMarkez", SqlDbType.Int) { Value = MMashataddresMarkez });
            cmd.Parameters.Add(new SqlParameter("@MMashataddres", SqlDbType.NVarChar) { Value = MMashataddres });
            cmd.Parameters.Add(new SqlParameter("@MMashatPhone", SqlDbType.NVarChar) { Value = MMashatPhone });
            cmd.Parameters.Add(new SqlParameter("@MMashatMobil", SqlDbType.NVarChar) { Value = MMashatMobil });
            cmd.Parameters.Add(new SqlParameter("@MMashatMail", SqlDbType.NVarChar) { Value = MMashatMail });
            cmd.Parameters.Add(new SqlParameter("@WorkeEndDate", SqlDbType.Date) { Value = WorkeEndDate });
            cmd.Parameters.Add(new SqlParameter("@KideNumber", SqlDbType.Int) { Value = KideNumber });
            cmd.Parameters.Add(new SqlParameter("@ZmalaEshtrakDate", SqlDbType.Date) { Value = ZmalaEshtrakDate });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@MemberShipNumber", SqlDbType.Int) { Value = MemberShipNumber });
            cmd.Parameters.Add(new SqlParameter("@MashHalaId", SqlDbType.TinyInt) { Value = MashHalaId });
            cmd.Parameters.Add(new SqlParameter("@sarfnumber", SqlDbType.Int) { Value = sarfnumber });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMashat SET MMashatNId = @MMashatNId, MMashatName = @MMashatName, BirthDate = @BirthDate, MMashatGender = @MMashatGender, 
                MMashataddresGov = @MMashataddresGov, MMashataddresMarkez = @MMashataddresMarkez, MMashataddres = @MMashataddres, MMashatPhone = @MMashatPhone, MMashatMobil = @MMashatMobil, 
                MMashatMail = @MMashatMail, WorkeEndDate = @WorkeEndDate, KideNumber = @KideNumber, ZmalaEshtrakDate = @ZmalaEshtrakDate, SyndicateId = @SyndicateId, SubCommitteId = @SubCommitteId, 
                MemberShipNumber = @MemberShipNumber, MashHalaId = @MashHalaId, sarfnumber = @sarfnumber WHERE MMashatId = @MMashatId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }

        public static bool UpdateTBLWarasa(object PersonId, object MMashatId, object WarasaTypeId, object personName, object personAddres, object SyndicateId, object SubCommitteId,
            object personphone, object personmobile, object personbirth, object SarfHalaId, object personrem, object org_PersonId, object org_MMashatId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int) { Value = PersonId });
            cmd.Parameters.Add(new SqlParameter("@MMashatId", SqlDbType.Int) { Value = MMashatId });
            cmd.Parameters.Add(new SqlParameter("@WarasaTypeId", SqlDbType.TinyInt) { Value = WarasaTypeId });
            cmd.Parameters.Add(new SqlParameter("@personName", SqlDbType.NVarChar) { Value = personName });
            cmd.Parameters.Add(new SqlParameter("@personAddres", SqlDbType.NVarChar) { Value = personAddres });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@personphone", SqlDbType.NVarChar) { Value = personphone });
            cmd.Parameters.Add(new SqlParameter("@personmobile", SqlDbType.NVarChar) { Value = personmobile });
            cmd.Parameters.Add(new SqlParameter("@personbirth", SqlDbType.Date) { Value = personbirth });
            cmd.Parameters.Add(new SqlParameter("@SarfHalaId", SqlDbType.TinyInt) { Value = SarfHalaId });
            cmd.Parameters.Add(new SqlParameter("@personrem", SqlDbType.NVarChar) { Value = personrem });
            cmd.Parameters.Add(new SqlParameter("@org_PersonId", SqlDbType.Int) { Value = org_PersonId });
            cmd.Parameters.Add(new SqlParameter("@org_MMashatId", SqlDbType.Int) { Value = org_MMashatId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLWarasa SET MMashatId = @MMashatId, WarasaTypeId = @WarasaTypeId, personName = @personName, personAddres = @personAddres, 
                SyndicateId = @SyndicateId, SubCommitteId = @SubCommitteId, personphone = @personphone, personmobile = @personmobile, personbirth = @personbirth, 
                SarfHalaId = @SarfHalaId, personrem = @personrem WHERE PersonId = @org_PersonId AND MMashatId = @org_MMashatId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }

        public static bool UpdateTBLDofatSarf(object DofatSarfId, object DofatSarf, object DofatSarfDate, object remd)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@DofatSarfId", SqlDbType.Int) { Value = DofatSarfId });
            cmd.Parameters.Add(new SqlParameter("@DofatSarf", SqlDbType.NVarChar) { Value = DofatSarf });
            cmd.Parameters.Add(new SqlParameter("@DofatSarfDate", SqlDbType.Date) { Value = DofatSarfDate });
            cmd.Parameters.Add(new SqlParameter("@remd", SqlDbType.NVarChar) { Value = remd });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLDofatSarf SET DofatSarf = @DofatSarf, DofatSarfDate = @DofatSarfDate, remd = @remd
                WHERE DofatSarfId = @DofatSarfId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }

        #endregion
        #region -   Deleting   -
        //Code
        public static bool DeleteCDGov(string GovId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GovId", SqlDbType.TinyInt) { Value = GovId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDGov WHERE (GovId = @GovId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDMarkez(string MarkezId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MarkezId", SqlDbType.Int) { Value = MarkezId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDMarkez WHERE (MarkezId = @MarkezId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDSyndicate(string SyndicateId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDSyndicate WHERE (SyndicateId = @SyndicateId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDSubCommitte(string SubCommitteId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDSubCommitte WHERE (SubCommitteId = @SubCommitteId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDWarasaType(string WarasaTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WarasaTypeId", SqlDbType.Int) { Value = WarasaTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDWarasaType WHERE (WarasaTypeId = @WarasaTypeId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDMashHala(string MashHalaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MashHalaId", SqlDbType.Int) { Value = MashHalaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDMashHala WHERE (MashHalaId = @MashHalaId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        //Data
        public static bool DeleteTBLMashat(string MMashatId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MMashatId", SqlDbType.Int) { Value = MMashatId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMashat WHERE (MMashatId = @MMashatId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteTBLWarasa(string PersonId, string MMashatId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int) { Value = PersonId });
            cmd.Parameters.Add(new SqlParameter("@MMashatId", SqlDbType.Int) { Value = MMashatId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLWarasa WHERE PersonId = @PersonId AND MMashatId = @MMashatId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteTBLDofatSarf(string DofatSarfId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@DofatSarfId", SqlDbType.Int) { Value = DofatSarfId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLDofatSarf WHERE (DofatSarfId = @DofatSarfId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
    #endregion

        #endregion
    }
}
