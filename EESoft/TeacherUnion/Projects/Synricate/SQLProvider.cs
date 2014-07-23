using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Synricate
{
    public class SQLProvider
    {
        #region -   Variables   -

        public static string AccConStr = string.Empty;
        //public static UserInfoStruct UserInfo = new UserInfoStruct();
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
        public enum CDMetingState
        {
            حاضر = 1,
            غائب = 2
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
        //General
        public static bool LoadUserInfo(string username, string password)
        {
            DataTable TblUser = FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT UserID, UserName, UserPass FROM Users
                                                              WHERE (UserName = N'{0}') AND (UserPass = N'{1}')", username, password));
            foreach (DataRow row in TblUser.Rows)
            {
                FXFW.SqlDB.UserInfo = new FXFW.SqlDB.UserInfoStruct{ UserID = row["UserID"].ToString(), UserName = row["UserName"].ToString() };
                return true;
            }
            return false;
        }
        //Codes
        public static DataTable SelectCDSyndicate()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT SyndicateId, Syndicate, saddress, sphone1, sphone2, smobil, sfax, smail, slogo
            FROM CDSyndicate");
        }
        public static DataTable SelectCDSubCommitte()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT SubCommitteId, SubCommitte, SyndicateId, saddress, sphone1, sphone2, smobil, sfax, smail, slogo
            FROM CDSubCommitte");
        }
        public static DataTable SelectCDSCommitte()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT LagnaNoaeaId, LagnaNoaeaName, LagnaDES
            FROM CDSCommitte");
        }
        public static DataTable SelectCDCommitteJop()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT CommittejopId, CommittejopName
            FROM CDCommitteJop");
        }
        public static DataTable SelectCDJop()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT jopId, jopName FROM CDJop");
        }
        public static DataTable SelectCDMetingState()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MetingStateId, MetingState FROM CDMetingState");
        }
        public static DataTable SelectCDYear()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT YearId, Year FROM CDYear");
        }
        public static DataTable SelectCDMonth()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MonthId, Month FROM CDMonth");
        }
        //Data
        public static DataTable SelectTBLMeeting()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MId, MDate, CONVERT(DATETIME, MTime, 114) AS MTime, SubCommitteId, LagnaNoaeaId, filepath, datein, userin,
            CONVERT(NVARCHAR, MDate, 103) + ' - ' + (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLMeeting.SubCommitteId) + ' - ' + (SELECT LagnaNoaeaName FROM CDSCommitte WHERE LagnaNoaeaId = TBLMeeting.LagnaNoaeaId) AS Details
            FROM TBLMeeting");
        }
        public static DataTable SelectTBLMeetingMember()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MId, MemberId, MetingStateId, CONVERT(DATETIME, HodorTime, 114) AS HodorTime, Mrem,
            MId AS org_MId, MemberId AS org_MemberId 
            FROM TBLMeetingMember");
        }
        public static DataTable SelectTBLMeetingMember(object MId)
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MId, MemberId, MetingStateId, CONVERT(DATETIME, HodorTime, 114) AS HodorTime, Mrem,
            MId AS org_MId, MemberId AS org_MemberId 
            FROM TBLMeetingMember WHERE MId = " + MId);
        }
        public static DataTable SelectTBLmdescion()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MId, MdescNu, Mdesc, MFollow,
            MId AS org_MId, MdescNu AS org_MdescNu 
            FROM TBLmdescion");
        }
        public static DataTable SelectTBLmdescion(object MId)
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MId, MdescNu, Mdesc, MFollow,
            MId AS org_MId, MdescNu AS org_MdescNu 
            FROM TBLmdescion WHERE MId = " + MId);
        }
        public static DataTable SelectTBLMember()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, MemberName, jopId, Memberworkon, Membertel, Membermobil, Memberemail, Memberaddress,
            picpath, MemberBDate, userin, datein FROM TBLMember");
        }
        public static DataTable SelectTBLSCommitteMember()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, LagnaNoaeaId, SubCommitteId, CommittejopId, workstartdate, workenddate, datein, userin, 
            (SELECT MemberName FROM TBLMember WHERE MemberId = TBLSCommitteMember.MemberId) AS MemberName, 
            MemberId AS org_MemberId, LagnaNoaeaId AS org_LagnaNoaeaId, SubCommitteId AS org_SubCommitteId
            FROM TBLSCommitteMember");
        }
        public static DataTable SelectTBLSCommitteMember(object LagnaNoaeaId, object SubCommitteId)
        {
            return FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT MemberId, LagnaNoaeaId, SubCommitteId, CommittejopId, workstartdate, workenddate, datein, userin,
                                            (SELECT MemberName FROM TBLMember WHERE MemberId = TBLSCommitteMember.MemberId) AS MemberName, 
                                            MemberId AS org_MemberId, LagnaNoaeaId AS org_LagnaNoaeaId, SubCommitteId AS org_SubCommitteId
                                            FROM TBLSCommitteMember
                                            WHERE LagnaNoaeaId = {0} AND SubCommitteId = {1}", LagnaNoaeaId, SubCommitteId));
        }
        public static DataTable SelectTBLPlan()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT planId, yearId, monthId, SubCommitteId, LagnaNoaeaId, userin, datein,
            (SELECT Year FROM CDYear WHERE YearId = TBLPlan.yearId) + ' - ' + (SELECT Month FROM CDMonth WHERE MonthId = TBLPlan.monthId) + ' - ' + 
            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLPlan.SubCommitteId) + ' - ' + (SELECT LagnaNoaeaName FROM CDSCommitte WHERE LagnaNoaeaId = TBLPlan.LagnaNoaeaId) AS Details
            FROM TBLPlan");
        }
        public static DataTable SelectTBLPlandetials()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT plandetialId, planId, plandetialdate, plandetial, MemberId, rem, tam, PPERCENT, DEF,
            plandetialId AS org_plandetialId, planId AS org_planId
            FROM TBLPlandetials");
        }
        public static DataTable SelectTBLPlandetials(object planId)
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT plandetialId, planId, plandetialdate, plandetial, MemberId, rem, tam, PPERCENT, DEF,
            plandetialId AS org_plandetialId, planId AS org_planId
            FROM TBLPlandetials WHERE planId = " + planId);
        }
        #endregion
        #region -   Inserting   -
        //Code

        public static bool InsertCDSyndicate(object Syndicate, object saddress, object sphone1, object sphone2, object smobil, object sfax, object smail, object slogo)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Syndicate", SqlDbType.NVarChar) { Value = Syndicate });
            cmd.Parameters.Add(new SqlParameter("@saddress", SqlDbType.NVarChar) { Value = saddress });
            cmd.Parameters.Add(new SqlParameter("@sphone1", SqlDbType.NVarChar) { Value = sphone1 });
            cmd.Parameters.Add(new SqlParameter("@sphone2", SqlDbType.NVarChar) { Value = sphone2 });
            cmd.Parameters.Add(new SqlParameter("@smobil", SqlDbType.NVarChar) { Value = smobil });
            cmd.Parameters.Add(new SqlParameter("@sfax", SqlDbType.NVarChar) { Value = sfax });
            cmd.Parameters.Add(new SqlParameter("@smail", SqlDbType.NVarChar) { Value = smail });
            cmd.Parameters.Add(new SqlParameter("@slogo", SqlDbType.Image) { Value = slogo });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDSyndicate (SyndicateId, Syndicate, saddress, sphone1, sphone2, smobil, sfax, smail, slogo)
                VALUES ((SELECT ISNULL(MAX(SyndicateId) + 1, 1) FROM CDSyndicate),@Syndicate, @saddress, @sphone1, @sphone2, @smobil, @sfax, @smail, @slogo)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDSubCommitte(object SubCommitte, object SyndicateId, object saddress, object sphone1, object sphone2, object smobil, object sfax, object smail, object slogo)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SubCommitte", SqlDbType.NVarChar) { Value = SubCommitte });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@saddress", SqlDbType.NVarChar) { Value = saddress });
            cmd.Parameters.Add(new SqlParameter("@sphone1", SqlDbType.NVarChar) { Value = sphone1 });
            cmd.Parameters.Add(new SqlParameter("@sphone2", SqlDbType.NVarChar) { Value = sphone2 });
            cmd.Parameters.Add(new SqlParameter("@smobil", SqlDbType.NVarChar) { Value = smobil });
            cmd.Parameters.Add(new SqlParameter("@sfax", SqlDbType.NVarChar) { Value = sfax });
            cmd.Parameters.Add(new SqlParameter("@smail", SqlDbType.NVarChar) { Value = smail });
            cmd.Parameters.Add(new SqlParameter("@slogo", SqlDbType.Image) { Value = slogo });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDSubCommitte (SubCommitteId, SubCommitte, SyndicateId, saddress, sphone1, sphone2, smobil, sfax, smail, slogo)
                VALUES ((SELECT ISNULL(MAX(SubCommitteId) + 1, 1) FROM CDSubCommitte), @SubCommitte, @SyndicateId, @saddress, @sphone1, @sphone2, @smobil, @sfax, @smail, @slogo)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDSCommitte(object LagnaNoaeaName, object LagnaDES)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaName", SqlDbType.NVarChar) { Value = LagnaNoaeaName });
            cmd.Parameters.Add(new SqlParameter("@LagnaDES", SqlDbType.NVarChar) { Value = LagnaDES });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDSCommitte (LagnaNoaeaId, LagnaNoaeaName, LagnaDES)
                VALUES ((SELECT ISNULL(MAX(LagnaNoaeaId) + 1, 1) FROM CDSCommitte),@LagnaNoaeaName, @LagnaDES)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDCommitteJop(object CommittejopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@CommittejopName", SqlDbType.NVarChar) { Value = CommittejopName });


            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDCommitteJop (CommittejopId, CommittejopName)
                VALUES ((SELECT ISNULL(MAX(CommittejopId) + 1, 1) FROM CDCommitteJop),@CommittejopName)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDJop(object jopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@jopName", SqlDbType.NVarChar) { Value = jopName });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDJop (jopId, jopName) 
                VALUES ((SELECT ISNULL(MAX(jopId) + 1, 1) FROM CDJop), @jopName)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDYear(object Year)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.NVarChar) { Value = Year });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDYear (YearId, Year) 
                VALUES ((SELECT ISNULL(MAX(YearId) + 1, 1) FROM CDYear), @Year)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertCDMonth(object Month)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Month", SqlDbType.NVarChar) { Value = Month });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDMonth (MonthId, Month) 
                VALUES ((SELECT ISNULL(MAX(MonthId) + 1, 1) FROM CDMonth), @Month)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        //Data
        public static bool InsertTBLMeeting(object MDate, object MTime, object SubCommitteId, object LagnaNoaeaId, object filepath)
        {
            DataTable dtMembers = FXFW.SqlDB.LoadDataTable(String.Format(@"Select MemberId FROM TBLSCommitteMember WHERE SubCommitteId = {0} AND LagnaNoaeaId = {1}", SubCommitteId, LagnaNoaeaId));
            string MId = FXFW.SqlDB.GetNewID("TBLMeeting", "MId");

            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MId", SqlDbType.Int) { Value = MId });
            cmd.Parameters.Add(new SqlParameter("@MDate", SqlDbType.Date) { Value = MDate });
            cmd.Parameters.Add(new SqlParameter("@MTime", SqlDbType.DateTime) { Value = MTime });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaId", SqlDbType.Int) { Value = LagnaNoaeaId });
            cmd.Parameters.Add(new SqlParameter("@filepath", SqlDbType.NVarChar) { Value = filepath });

            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMeeting (MId, MDate, MTime, SubCommitteId, LagnaNoaeaId, filepath, datein, userin)
                VALUES (@MId, @MDate, @MTime, @SubCommitteId, @LagnaNoaeaId, @filepath, GETDATE(), @userin)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                //Insert Meeting Members With Default Value
                foreach (DataRow row in dtMembers.Rows)
                {
                    InsertTBLMeetingMember(MId, row["MemberId"], SQLProvider.CDMetingState.حاضر, MTime, "");
                }
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLMeetingMember(object MId, object MemberId, object MetingStateId, object HodorTime, object Mrem)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MId", SqlDbType.Int) { Value = MId });
            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@MetingStateId", SqlDbType.TinyInt) { Value = MetingStateId });
            cmd.Parameters.Add(new SqlParameter("@HodorTime", SqlDbType.DateTime) { Value = HodorTime });
            cmd.Parameters.Add(new SqlParameter("@Mrem", SqlDbType.NVarChar) { Value = Mrem });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMeetingMember (MId, MemberId, MetingStateId, HodorTime) 
                                    VALUES (@MId, @MemberId, @MetingStateId, @HodorTime)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLmdescion(object MId, object MdescNu, object Mdesc, object MFollow)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MId", SqlDbType.Int) { Value = MId });
            cmd.Parameters.Add(new SqlParameter("@MdescNu", SqlDbType.Int) { Value = MdescNu });
            cmd.Parameters.Add(new SqlParameter("@Mdesc", SqlDbType.NVarChar) { Value = Mdesc });
            cmd.Parameters.Add(new SqlParameter("@MFollow", SqlDbType.NText) { Value = MFollow });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLmdescion (MId, MdescNu, Mdesc, MFollow) 
                                    VALUES (@MId, @MdescNu, @Mdesc, @MFollow)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLMember(object MemberName, object jopId, object Memberworkon, object Membertel, object Membermobil, object Memberemail, object Memberaddress,
            object picpath, object MemberBDate)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberName", SqlDbType.NVarChar) { Value = MemberName });
            cmd.Parameters.Add(new SqlParameter("@jopId", SqlDbType.Int) { Value = jopId });
            cmd.Parameters.Add(new SqlParameter("@Memberworkon", SqlDbType.NVarChar) { Value = Memberworkon });
            cmd.Parameters.Add(new SqlParameter("@Membertel", SqlDbType.NVarChar) { Value = Membertel });
            cmd.Parameters.Add(new SqlParameter("@Membermobil", SqlDbType.NVarChar) { Value = Membermobil });
            cmd.Parameters.Add(new SqlParameter("@Memberemail", SqlDbType.NVarChar) { Value = Memberemail });
            cmd.Parameters.Add(new SqlParameter("@Memberaddress", SqlDbType.NVarChar) { Value = Memberaddress });
            cmd.Parameters.Add(new SqlParameter("@picpath", SqlDbType.Image) { Value = picpath });
            cmd.Parameters.Add(new SqlParameter("@MemberBDate", SqlDbType.Date) { Value = MemberBDate });

            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMember (MemberId, MemberName, jopId, Memberworkon, Membertel, Membermobil, Memberemail, Memberaddress,
                picpath, MemberBDate, userin, datein)
                VALUES ((SELECT ISNULL(MAX(MemberId) + 1, 1) FROM TBLMember),@MemberName, @jopId, @Memberworkon, @Membertel, @Membermobil, @Memberemail, @Memberaddress,
                @picpath, @MemberBDate, @userin, GETDATE())";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLSCommitteMember(object MemberId, object LagnaNoaeaId, object SubCommitteId, object CommittejopId, object workstartdate, object workenddate)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaId", SqlDbType.Int) { Value = LagnaNoaeaId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@CommittejopId", SqlDbType.TinyInt) { Value = CommittejopId });
            cmd.Parameters.Add(new SqlParameter("@workstartdate", SqlDbType.Date) { Value = workstartdate });
            cmd.Parameters.Add(new SqlParameter("@workenddate", SqlDbType.Date) { Value = workenddate });

            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLSCommitteMember (MemberId, LagnaNoaeaId, SubCommitteId, CommittejopId, workstartdate, workenddate, datein, userin)
                VALUES (@MemberId, @LagnaNoaeaId, @SubCommitteId, @CommittejopId, @workstartdate, @workenddate, GETDATE(), @userin)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLPlan(object yearId, object monthId, object SubCommitteId, object LagnaNoaeaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@yearId", SqlDbType.TinyInt) { Value = yearId });
            cmd.Parameters.Add(new SqlParameter("@monthId", SqlDbType.TinyInt) { Value = monthId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaId", SqlDbType.Int) { Value = LagnaNoaeaId });

            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLPlan (planId, yearId, monthId, SubCommitteId, LagnaNoaeaId, datein, userin)
                VALUES ((SELECT ISNULL(MAX(planId) + 1, 1) FROM TBLPlan), @yearId, @monthId, @SubCommitteId, @LagnaNoaeaId, GETDATE(), @userin)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLPlandetials(object planId, object plandetialdate, object plandetial, object MemberId, object rem, object tam, object PPERCENT, object DEF)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@planId", SqlDbType.Int) { Value = planId });
            cmd.Parameters.Add(new SqlParameter("@plandetialdate", SqlDbType.Date) { Value = plandetialdate });
            cmd.Parameters.Add(new SqlParameter("@plandetial", SqlDbType.NVarChar) { Value = plandetial });
            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@rem", SqlDbType.NVarChar) { Value = rem });
            cmd.Parameters.Add(new SqlParameter("@tam", SqlDbType.Bit) { Value = tam });
            cmd.Parameters.Add(new SqlParameter("@PPERCENT", SqlDbType.Float) { Value = PPERCENT });
            cmd.Parameters.Add(new SqlParameter("@DEF", SqlDbType.NText) { Value = DEF });
            

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLPlandetials (plandetialId, planId, plandetialdate, plandetial, MemberId, rem, tam, PPERCENT, DEF)
                VALUES ((SELECT ISNULL(MAX(plandetialId) + 1, 1) FROM TBLPlandetials), @planId, @plandetialdate, @plandetial, @MemberId, @rem, @tam, @PPERCENT, @DEF)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
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
        public static bool UpdateCDSyndicate(object SyndicateId, object Syndicate, object saddress, object sphone1, object sphone2, object smobil, object sfax, object smail, object slogo)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@Syndicate", SqlDbType.NVarChar) { Value = Syndicate });
            cmd.Parameters.Add(new SqlParameter("@saddress", SqlDbType.NVarChar) { Value = saddress });
            cmd.Parameters.Add(new SqlParameter("@sphone1", SqlDbType.NVarChar) { Value = sphone1 });
            cmd.Parameters.Add(new SqlParameter("@sphone2", SqlDbType.NVarChar) { Value = sphone2 });
            cmd.Parameters.Add(new SqlParameter("@smobil", SqlDbType.NVarChar) { Value = smobil });
            cmd.Parameters.Add(new SqlParameter("@sfax", SqlDbType.NVarChar) { Value = sfax });
            cmd.Parameters.Add(new SqlParameter("@smail", SqlDbType.NVarChar) { Value = smail });
            cmd.Parameters.Add(new SqlParameter("@slogo", SqlDbType.Image) { Value = slogo });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDSyndicate SET Syndicate = @Syndicate, saddress = @saddress, sphone1 = @sphone1, sphone2 = @sphone2, smobil = @smobil, 
                sfax = @sfax, smail = @smail, slogo = @slogo
                WHERE SyndicateId = @SyndicateId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDSubCommitte(object SubCommitteId, object SubCommitte, object SyndicateId, object saddress, object sphone1, object sphone2, object smobil, object sfax, object smail, object slogo)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitte", SqlDbType.NVarChar) { Value = SubCommitte });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@saddress", SqlDbType.NVarChar) { Value = saddress });
            cmd.Parameters.Add(new SqlParameter("@sphone1", SqlDbType.NVarChar) { Value = sphone1 });
            cmd.Parameters.Add(new SqlParameter("@sphone2", SqlDbType.NVarChar) { Value = sphone2 });
            cmd.Parameters.Add(new SqlParameter("@smobil", SqlDbType.NVarChar) { Value = smobil });
            cmd.Parameters.Add(new SqlParameter("@sfax", SqlDbType.NVarChar) { Value = sfax });
            cmd.Parameters.Add(new SqlParameter("@smail", SqlDbType.NVarChar) { Value = smail });
            cmd.Parameters.Add(new SqlParameter("@slogo", SqlDbType.Image) { Value = slogo });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDSubCommitte SET SubCommitte = @SubCommitte, SyndicateId = @SyndicateId, saddress = @saddress, sphone1 = @sphone1, 
                sphone2 = @sphone2, smobil = @smobil, sfax = @sfax, smail = @smail, slogo = @slogo
                WHERE SubCommitteId = @SubCommitteId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDSCommitte(object LagnaNoaeaId, object LagnaNoaeaName, object LagnaDES)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaId", SqlDbType.Int) { Value = LagnaNoaeaId });
            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaName", SqlDbType.NVarChar) { Value = LagnaNoaeaName });
            cmd.Parameters.Add(new SqlParameter("@LagnaDES", SqlDbType.NVarChar) { Value = LagnaDES });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDSCommitte SET LagnaNoaeaName = @LagnaNoaeaName, LagnaDES = @LagnaDES
                WHERE LagnaNoaeaId = @LagnaNoaeaId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDCommitteJop(object CommittejopId, object CommittejopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@CommittejopId", SqlDbType.TinyInt) { Value = CommittejopId });
            cmd.Parameters.Add(new SqlParameter("@CommittejopName", SqlDbType.NVarChar) { Value = CommittejopName });
            
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDCommitteJop SET CommittejopName = @CommittejopName
                WHERE CommittejopId = @CommittejopId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDJop(object jopId, object jopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@jopId", SqlDbType.TinyInt) { Value = jopId });
            cmd.Parameters.Add(new SqlParameter("@jopName", SqlDbType.NVarChar) { Value = jopName });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDJop SET jopName = @jopName WHERE jopId = @jopId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDYear(object YearId, object Year)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@YearId", SqlDbType.TinyInt) { Value = YearId });
            cmd.Parameters.Add(new SqlParameter("@Year", SqlDbType.NVarChar) { Value = Year });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDYear SET Year = @Year WHERE YearId = @YearId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateCDMonth(object MonthId, object Month)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MonthId", SqlDbType.TinyInt) { Value = MonthId });
            cmd.Parameters.Add(new SqlParameter("@Month", SqlDbType.NVarChar) { Value = Month });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDMonth SET Month = @Month WHERE MonthId = @MonthId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        //Data
        public static bool UpdateTBLMeeting(object MId, object MDate, object MTime, object SubCommitteId, object LagnaNoaeaId, object filepath)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MId", SqlDbType.Int) { Value = MId });
            cmd.Parameters.Add(new SqlParameter("@MDate", SqlDbType.Date) { Value = MDate });
            cmd.Parameters.Add(new SqlParameter("@MTime", SqlDbType.DateTime) { Value = MTime });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaId", SqlDbType.Int) { Value = LagnaNoaeaId });
            cmd.Parameters.Add(new SqlParameter("@filepath", SqlDbType.NVarChar) { Value = filepath });

            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMeeting SET MDate = @MDate, MTime = @MTime, SubCommitteId = @SubCommitteId, LagnaNoaeaId = @LagnaNoaeaId, 
                filepath = @filepath, datein = GETDATE(), userin = @userin
                WHERE MId = @MId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateTBLMeetingMember(object MId, object MemberId, object MetingStateId, object HodorTime, object Mrem, object org_MId, object org_MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MId", SqlDbType.Int) { Value = MId });
            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@MetingStateId", SqlDbType.TinyInt) { Value = MetingStateId });
            cmd.Parameters.Add(new SqlParameter("@HodorTime", SqlDbType.DateTime) { Value = HodorTime });
            cmd.Parameters.Add(new SqlParameter("@Mrem", SqlDbType.NVarChar) { Value = Mrem });

            cmd.Parameters.Add(new SqlParameter("@org_MId", SqlDbType.Int) { Value = org_MId });
            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMeetingMember SET MId = @MId, MemberId = @MemberId, MetingStateId = @MetingStateId, 
                HodorTime = @HodorTime, Mrem = @Mrem
                WHERE MId = @org_MId AND MemberId = @org_MemberId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateTBLmdescion(object MId, object MdescNu, object Mdesc, object MFollow, object org_MId, object org_MdescNu)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MId", SqlDbType.Int) { Value = MId });
            cmd.Parameters.Add(new SqlParameter("@MdescNu", SqlDbType.Int) { Value = MdescNu });
            cmd.Parameters.Add(new SqlParameter("@Mdesc", SqlDbType.NVarChar) { Value = Mdesc });
            cmd.Parameters.Add(new SqlParameter("@MFollow", SqlDbType.NText) { Value = MFollow });

            cmd.Parameters.Add(new SqlParameter("@org_MId", SqlDbType.Int) { Value = org_MId });
            cmd.Parameters.Add(new SqlParameter("@org_MdescNu", SqlDbType.Int) { Value = org_MdescNu });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLmdescion SET MId = @MId, MdescNu = @MdescNu, Mdesc = @Mdesc, 
                MFollow = @MFollow
                WHERE MId = @org_MId AND MdescNu = @org_MdescNu";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateTBLMember(object MemberId, object MemberName, object jopId, object Memberworkon, object Membertel, object Membermobil, object Memberemail, object Memberaddress,
            object picpath, object MemberBDate)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@MemberName", SqlDbType.NVarChar) { Value = MemberName });
            cmd.Parameters.Add(new SqlParameter("@jopId", SqlDbType.Int) { Value = jopId });
            cmd.Parameters.Add(new SqlParameter("@Memberworkon", SqlDbType.NVarChar) { Value = Memberworkon });
            cmd.Parameters.Add(new SqlParameter("@Membertel", SqlDbType.NVarChar) { Value = Membertel });
            cmd.Parameters.Add(new SqlParameter("@Membermobil", SqlDbType.NVarChar) { Value = Membermobil });
            cmd.Parameters.Add(new SqlParameter("@Memberemail", SqlDbType.NVarChar) { Value = Memberemail });
            cmd.Parameters.Add(new SqlParameter("@Memberaddress", SqlDbType.NVarChar) { Value = Memberaddress });
            cmd.Parameters.Add(new SqlParameter("@picpath", SqlDbType.Image) { Value = picpath });
            cmd.Parameters.Add(new SqlParameter("@MemberBDate", SqlDbType.Date) { Value = MemberBDate });

            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMember SET MemberName = @MemberName, jopId = @jopId, Memberworkon = @Memberworkon, Membertel = @Membertel, 
                Membermobil = @Membermobil, Memberemail = @Memberemail, Memberaddress = @Memberaddress, picpath = @picpath, MemberBDate = @MemberBDate, 
                userin = @userin, datein = GETDATE()
                WHERE MemberId = @MemberId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateTBLSCommitteMember(object MemberId, object LagnaNoaeaId, object SubCommitteId, object CommittejopId, object workstartdate, object workenddate, object org_MemberId, object org_LagnaNoaeaId, object org_SubCommitteId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaId", SqlDbType.Int) { Value = LagnaNoaeaId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@CommittejopId", SqlDbType.TinyInt) { Value = CommittejopId });
            cmd.Parameters.Add(new SqlParameter("@workstartdate", SqlDbType.Date) { Value = workstartdate });
            cmd.Parameters.Add(new SqlParameter("@workenddate", SqlDbType.Date) { Value = workenddate });

            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });
            cmd.Parameters.Add(new SqlParameter("@org_LagnaNoaeaId", SqlDbType.Int) { Value = org_LagnaNoaeaId });
            cmd.Parameters.Add(new SqlParameter("@org_SubCommitteId", SqlDbType.Int) { Value = org_SubCommitteId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLSCommitteMember SET MemberId = @MemberId, LagnaNoaeaId = @LagnaNoaeaId, SubCommitteId = @SubCommitteId, 
                CommittejopId = @CommittejopId, workstartdate = @workstartdate, workenddate = @workenddate, datein = GETDATE(), userin = @userin
                WHERE MemberId = @org_MemberId AND LagnaNoaeaId = @org_LagnaNoaeaId AND SubCommitteId = @org_SubCommitteId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateTBLPlan(object planId, object yearId, object monthId, object SubCommitteId, object LagnaNoaeaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@planId", SqlDbType.Int) { Value = planId });
            cmd.Parameters.Add(new SqlParameter("@yearId", SqlDbType.TinyInt) { Value = yearId });
            cmd.Parameters.Add(new SqlParameter("@monthId", SqlDbType.TinyInt) { Value = monthId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaId", SqlDbType.Int) { Value = LagnaNoaeaId });

            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLPlan SET yearId = @yearId, monthId = @monthId, SubCommitteId = @SubCommitteId, 
                LagnaNoaeaId = @LagnaNoaeaId, datein = GETDATE(), userin = @userin
                WHERE planId = @planId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool UpdateTBLPlandetials(object plandetialId, object planId, object plandetialdate, object plandetial, object MemberId, object rem, object tam, object PPERCENT, object DEF, object org_plandetialId, object org_planId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@plandetialId", SqlDbType.Int) { Value = plandetialId });
            cmd.Parameters.Add(new SqlParameter("@planId", SqlDbType.Int) { Value = planId });
            cmd.Parameters.Add(new SqlParameter("@plandetialdate", SqlDbType.Date) { Value = plandetialdate });
            cmd.Parameters.Add(new SqlParameter("@plandetial", SqlDbType.NVarChar) { Value = plandetial });
            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@rem", SqlDbType.NVarChar) { Value = rem });
            cmd.Parameters.Add(new SqlParameter("@tam", SqlDbType.Bit) { Value = tam });
            cmd.Parameters.Add(new SqlParameter("@PPERCENT", SqlDbType.Float) { Value = PPERCENT });
            cmd.Parameters.Add(new SqlParameter("@DEF", SqlDbType.NText) { Value = DEF });

            cmd.Parameters.Add(new SqlParameter("@org_plandetialId", SqlDbType.Int) { Value = org_plandetialId });
            cmd.Parameters.Add(new SqlParameter("@org_planId", SqlDbType.Int) { Value = org_planId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLPlandetials SET plandetialId = @plandetialId, planId = @planId, plandetialdate = @plandetialdate, plandetial = @plandetial, 
                MemberId = @MemberId, rem = @rem, tam = @tam, PPERCENT = @PPERCENT, DEF = @DEF
                WHERE plandetialId = @org_plandetialId AND planId = @org_planId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
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
        
        public static bool DeleteCDSyndicate(object SyndicateId)
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
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDSubCommitte(object SubCommitteId)
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
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDSCommitte(object LagnaNoaeaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@LagnaNoaeaId", SqlDbType.Int) { Value = LagnaNoaeaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDSCommitte WHERE (LagnaNoaeaId = @LagnaNoaeaId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDCommitteJop(object CommittejopId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@CommittejopId", SqlDbType.Int) { Value = CommittejopId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDCommitteJop WHERE (CommittejopId = @CommittejopId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDJop(object jopId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@jopId", SqlDbType.Int) { Value = jopId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDJop WHERE (jopId = @jopId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDYear(object YearId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@YearId", SqlDbType.TinyInt) { Value = YearId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDYear WHERE (YearId = @YearId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDMonth(object MonthId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MonthId", SqlDbType.TinyInt) { Value = MonthId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDMonth WHERE (MonthId = @MonthId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        //Data
        public static bool DeleteTBLMeeting(object MId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MId", SqlDbType.Int) { Value = MId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMeeting WHERE (MId = @MId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteTBLMeetingMember(object org_MId, object org_MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@org_MId", SqlDbType.Int) { Value = org_MId });
            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMeetingMember WHERE 
                MId = @org_MId AND MemberId = @org_MemberId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteTBLmdescion(object org_MId, object org_MdescNu)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@org_MId", SqlDbType.Int) { Value = org_MId });
            cmd.Parameters.Add(new SqlParameter("@org_MdescNu", SqlDbType.Int) { Value = org_MdescNu });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLmdescion WHERE 
                MId = @org_MId AND MdescNu = @org_MdescNu";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteTBLMember(object MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMember WHERE (MemberId = @MemberId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteTBLSCommitteMember(object org_MemberId, object org_LagnaNoaeaId, object org_SubCommitteId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });
            cmd.Parameters.Add(new SqlParameter("@org_LagnaNoaeaId", SqlDbType.Int) { Value = org_LagnaNoaeaId });
            cmd.Parameters.Add(new SqlParameter("@org_SubCommitteId", SqlDbType.Int) { Value = org_SubCommitteId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLSCommitteMember WHERE 
                MemberId = @org_MemberId AND LagnaNoaeaId = @org_LagnaNoaeaId AND SubCommitteId = @org_SubCommitteId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteTBLPlan(object planId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@planId", SqlDbType.Int) { Value = planId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLPlan WHERE (planId = @planId)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteTBLPlandetials(object org_plandetialId, object org_planId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@org_plandetialId", SqlDbType.Int) { Value = org_plandetialId });
            cmd.Parameters.Add(new SqlParameter("@org_planId", SqlDbType.Int) { Value = org_planId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLPlandetials WHERE 
                plandetialId = @org_plandetialId AND planId = @org_planId";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                con.Close();
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
