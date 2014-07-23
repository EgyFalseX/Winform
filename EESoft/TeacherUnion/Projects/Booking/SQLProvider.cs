using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Booking
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
        public static DataTable SelectCDFatra()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT FatraId, Fatra, CONVERT(DateTime, ffrom, 114) AS ffrom, CONVERT(DateTime, fto, 114) AS fto FROM CDFatra");
        }
        public static DataTable SelectCDEradType()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EradTypeId, EradType FROM CDEradType");
        }
        public static DataTable SelectCDSyndicate()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT SyndicateId, Syndicate FROM CDSyndicate");
        }
        public static DataTable SelectCDSubCommitte()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT SubCommitteId, SubCommitte, SyndicateId FROM CDSubCommitte");
        }
        public static DataTable SelectCDMonsrefType()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MonsrefTypeId, MonsrefType FROM CDMonsrefType");
        }
        public static DataTable SelectCDJop()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT JopId, Jop FROM CDJop");
        }
        //Data
        public static DataTable SelectCDHall()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT hallId, hallName, SubCommitteId, hallAdress, halltel1, halltel2 FROM CDHall");
        }
        public static DataTable SelectTBLWorker()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT WorkerId, Worker, WorkerTel, WorkerMobil, WorkerAddress, JopId FROM TBLWorker");
        }
        public static DataTable SelectTBLBooking()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT BookingId, BookingDate, hallId, FatraId, BookingName, BookingMobile, WorkerId, DateIn, UserID,
            CONVERT(nvarchar, BookingDate, 103) + ' - ' + (SELECT hallName FROM CDHall WHERE hallId = TBLBooking.hallId) + ' - ' + BookingName AS Details
            FROM TBLBooking");
        }
        public static DataTable SelectTBLBEradat(object BookingId)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(BookingId))
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT BookingId, EradTypeId, EradDate, EradMony, Ebean, UserID, DateIn, 
                BookingId AS org_BookingId, EradTypeId AS org_EradTypeId
                FROM TBLBEradat");
            }
            else
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT BookingId, EradTypeId, EradDate, EradMony, Ebean, UserID, DateIn, 
                BookingId AS org_BookingId, EradTypeId AS org_EradTypeId
                FROM TBLBEradat WHERE BookingId = " + BookingId);
            }
            
        }
        public static DataTable SelectTBLMasrofat(object BookingId)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(BookingId))
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT BookingId, MonsrefTypeId, DateIn, MonsrefDate, MonsrefMony, Mbean, UserID, 
                BookingId AS org_BookingId, MonsrefTypeId AS org_MonsrefTypeId
                FROM TBLMasrofat");
            }
            else
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT BookingId, MonsrefTypeId, DateIn, MonsrefDate, MonsrefMony, Mbean, UserID, 
                BookingId AS org_BookingId, MonsrefTypeId AS org_MonsrefTypeId
                FROM TBLMasrofat WHERE BookingId = " + BookingId);
            }

        }
        #endregion
        #region -   Inserting   -
        //Code
        public static bool InsertCDFatra(object Fatra, object ffrom, object fto)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Fatra", SqlDbType.NVarChar) { Value = Fatra });
            cmd.Parameters.Add(new SqlParameter("@ffrom", SqlDbType.DateTime) { Value = ffrom });
            cmd.Parameters.Add(new SqlParameter("@fto", SqlDbType.DateTime) { Value = fto });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDFatra (FatraId, Fatra, ffrom, fto) VALUES ((SELECT ISNULL(MAX(FatraId) + 1, 1) FROM CDFatra), @Fatra, @ffrom, @fto)";
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
        public static bool InsertCDEradType(object EradType)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EradType", SqlDbType.NVarChar) { Value = EradType });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDEradType (EradTypeId, EradType) VALUES 
                ((SELECT ISNULL(MAX(EradTypeId) + 1, 1) FROM CDEradType), @EradType)";
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
        public static bool InsertCDSyndicate(object Syndicate)
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
        public static bool InsertCDSubCommitte(object SubCommitte, object SyndicateId)
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
        public static bool InsertCDMonsrefType(object MonsrefType)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MonsrefType", SqlDbType.NVarChar) { Value = MonsrefType });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDMonsrefType (MonsrefTypeId, MonsrefType) 
                VALUES ((SELECT ISNULL(MAX(MonsrefTypeId) + 1, 1) FROM CDMonsrefType), @MonsrefType)";
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
        public static bool InsertCDJop(object Jop)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Jop", SqlDbType.NVarChar) { Value = Jop });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDJop (JopId, Jop) 
                VALUES ((SELECT ISNULL(MAX(JopId) + 1, 1) FROM CDJop), @Jop)";
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

        public static bool InsertCDHall(object hallName, object SubCommitteId, object hallAdress, object halltel1, object halltel2)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@hallName", SqlDbType.NVarChar) { Value = hallName });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@hallAdress", SqlDbType.NVarChar) { Value = hallAdress });
            cmd.Parameters.Add(new SqlParameter("@halltel1", SqlDbType.NVarChar) { Value = halltel1 });
            cmd.Parameters.Add(new SqlParameter("@halltel2", SqlDbType.NVarChar) { Value = halltel2 });


            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDHall
                (hallId, hallName, SubCommitteId, hallAdress, halltel1, halltel2)
                VALUES ((SELECT ISNULL(MAX(hallId) + 1, 1) FROM CDHall), @hallName, @SubCommitteId, @hallAdress, @halltel1, @halltel2)";
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
        public static bool InsertTBLWorker(object Worker, object WorkerTel, object WorkerMobil, object WorkerAddress, object JopId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Worker", SqlDbType.NVarChar) { Value = Worker });
            cmd.Parameters.Add(new SqlParameter("@WorkerTel", SqlDbType.NVarChar) { Value = WorkerTel });
            cmd.Parameters.Add(new SqlParameter("@WorkerMobil", SqlDbType.NVarChar) { Value = WorkerMobil });
            cmd.Parameters.Add(new SqlParameter("@WorkerAddress", SqlDbType.NVarChar) { Value = WorkerAddress });
            cmd.Parameters.Add(new SqlParameter("@JopId", SqlDbType.TinyInt) { Value = JopId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLWorker (WorkerId, Worker, WorkerTel, WorkerMobil, WorkerAddress, JopId)
                VALUES ((SELECT ISNULL(MAX(WorkerId) + 1, 1) FROM TBLWorker), @Worker, @WorkerTel, @WorkerMobil, @WorkerAddress, @JopId)";
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
        public static bool InsertTBLBooking(object BookingDate, object hallId, object FatraId, object BookingName, object BookingMobile, object WorkerId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingDate", SqlDbType.Date) { Value = BookingDate });
            cmd.Parameters.Add(new SqlParameter("@hallId", SqlDbType.TinyInt) { Value = hallId });
            cmd.Parameters.Add(new SqlParameter("@FatraId", SqlDbType.TinyInt) { Value = FatraId });
            cmd.Parameters.Add(new SqlParameter("@BookingName", SqlDbType.NVarChar) { Value = BookingName });
            cmd.Parameters.Add(new SqlParameter("@BookingMobile", SqlDbType.NVarChar) { Value = BookingMobile });
            cmd.Parameters.Add(new SqlParameter("@WorkerId", SqlDbType.Int) { Value = WorkerId });

            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });


            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLBooking
                (BookingId, BookingDate, hallId, FatraId, BookingName, BookingMobile, WorkerId, DateIn, UserID)
                VALUES ((SELECT ISNULL(MAX(BookingId) + 1, 1) FROM TBLBooking), @BookingDate, @hallId, @FatraId, @BookingName, 
                @BookingMobile, @WorkerId, GETDATE(), @UserID)";
                InsertEmptyValue(ref cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public static bool InsertTBLBEradat(object BookingId, object EradTypeId, object EradDate, object EradMony, object Ebean)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingId", SqlDbType.Int) { Value = BookingId });
            cmd.Parameters.Add(new SqlParameter("@EradTypeId", SqlDbType.TinyInt) { Value = EradTypeId });
            cmd.Parameters.Add(new SqlParameter("@EradDate", SqlDbType.Date) { Value = EradDate });
            cmd.Parameters.Add(new SqlParameter("@EradMony", SqlDbType.Float) { Value = EradMony });
            cmd.Parameters.Add(new SqlParameter("@Ebean", SqlDbType.NVarChar) { Value = Ebean });

            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });


            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLBEradat
                (BookingId, EradTypeId, EradDate, EradMony, Ebean, UserID, DateIn)
                VALUES (@BookingId, @EradTypeId, @EradDate, @EradMony, @Ebean, @UserID, GETDATE())";
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
        public static bool InsertTBLMasrofat(object BookingId, object MonsrefTypeId, object MonsrefDate, object MonsrefMony, object Mbean)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingId", SqlDbType.Int) { Value = BookingId });
            cmd.Parameters.Add(new SqlParameter("@MonsrefTypeId", SqlDbType.TinyInt) { Value = MonsrefTypeId });
            cmd.Parameters.Add(new SqlParameter("@MonsrefDate", SqlDbType.Date) { Value = MonsrefDate });
            cmd.Parameters.Add(new SqlParameter("@MonsrefMony", SqlDbType.Float) { Value = MonsrefMony });
            cmd.Parameters.Add(new SqlParameter("@Mbean", SqlDbType.NVarChar) { Value = Mbean });

            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });


            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMasrofat
                (BookingId, MonsrefTypeId, MonsrefDate, MonsrefMony, Mbean, UserID, DateIn)
                VALUES (@BookingId, @MonsrefTypeId, @MonsrefDate, @MonsrefMony, @Mbean, @UserID, GETDATE())";
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
        public static bool UpdateCDFatra(object FatraId, object Fatra, object ffrom, object fto)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@FatraId", SqlDbType.TinyInt) { Value = FatraId });
            cmd.Parameters.Add(new SqlParameter("@Fatra", SqlDbType.NVarChar) { Value = Fatra });
            cmd.Parameters.Add(new SqlParameter("@ffrom", SqlDbType.DateTime) { Value = ffrom });
            cmd.Parameters.Add(new SqlParameter("@fto", SqlDbType.DateTime) { Value = fto });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDFatra SET Fatra = @Fatra, ffrom = @ffrom, fto = @fto WHERE FatraId = @FatraId";
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
        public static bool UpdateCDEradType(object EradTypeId, object EradType)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EradTypeId", SqlDbType.TinyInt) { Value = EradTypeId });
            cmd.Parameters.Add(new SqlParameter("@EradType", SqlDbType.NVarChar) { Value = EradType });
            
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDEradType SET EradType = @EradType WHERE EradTypeId = @EradTypeId";
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
        public static bool UpdateCDSyndicate(object SyndicateId, object Syndicate)
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
        public static bool UpdateCDSubCommitte(object SubCommitteId, object SubCommitte, object SyndicateId)
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
        public static bool UpdateCDMonsrefType(object MonsrefTypeId, object MonsrefType)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MonsrefTypeId", SqlDbType.TinyInt) { Value = MonsrefTypeId });
            cmd.Parameters.Add(new SqlParameter("@MonsrefType", SqlDbType.NVarChar) { Value = MonsrefType });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDMonsrefType SET MonsrefType = @MonsrefType WHERE MonsrefTypeId = @MonsrefTypeId";
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
        public static bool UpdateCDJop(object JopId, object Jop)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@JopId", SqlDbType.TinyInt) { Value = JopId });
            cmd.Parameters.Add(new SqlParameter("@Jop", SqlDbType.NVarChar) { Value = Jop });
            
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDJop SET Jop = @Jop WHERE JopId = @JopId";
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

        public static bool UpdateCDHall(object hallId, object hallName, object SubCommitteId, object hallAdress, object halltel1, object halltel2)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@hallId", SqlDbType.TinyInt) { Value = hallId });
            cmd.Parameters.Add(new SqlParameter("@hallName", SqlDbType.NVarChar) { Value = hallName });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@hallAdress", SqlDbType.NVarChar) { Value = hallAdress });
            cmd.Parameters.Add(new SqlParameter("@halltel1", SqlDbType.NVarChar) { Value = halltel1 });
            cmd.Parameters.Add(new SqlParameter("@halltel2", SqlDbType.NVarChar) { Value = halltel2 });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDHall
                SET hallName = @hallName, SubCommitteId = @SubCommitteId, hallAdress = @hallAdress, halltel1 = @halltel1, halltel2 = @halltel2
                WHERE hallId = @hallId";
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
        public static bool UpdateTBLWorker(object WorkerId, object Worker, object WorkerTel, object WorkerMobil, object WorkerAddress, object JopId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WorkerId", SqlDbType.Int) { Value = WorkerId });
            cmd.Parameters.Add(new SqlParameter("@Worker", SqlDbType.NVarChar) { Value = Worker });
            cmd.Parameters.Add(new SqlParameter("@WorkerTel", SqlDbType.NVarChar) { Value = WorkerTel });
            cmd.Parameters.Add(new SqlParameter("@WorkerMobil", SqlDbType.NVarChar) { Value = WorkerMobil });
            cmd.Parameters.Add(new SqlParameter("@WorkerAddress", SqlDbType.NVarChar) { Value = WorkerAddress });
            cmd.Parameters.Add(new SqlParameter("@JopId", SqlDbType.TinyInt) { Value = JopId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLWorker
                SET Worker = @Worker, WorkerTel = @WorkerTel, WorkerMobil = @WorkerMobil, WorkerAddress = @WorkerAddress, JopId = @JopId
                WHERE WorkerId  = @WorkerId";
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
        public static bool UpdateTBLBooking(object BookingId, object BookingDate, object hallId, object FatraId, object BookingName, object BookingMobile, object WorkerId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingId", SqlDbType.Int) { Value = BookingId });
            cmd.Parameters.Add(new SqlParameter("@BookingDate", SqlDbType.Date) { Value = BookingDate });
            cmd.Parameters.Add(new SqlParameter("@hallId", SqlDbType.TinyInt) { Value = hallId });
            cmd.Parameters.Add(new SqlParameter("@FatraId", SqlDbType.TinyInt) { Value = FatraId });
            cmd.Parameters.Add(new SqlParameter("@BookingName", SqlDbType.NVarChar) { Value = BookingName });
            cmd.Parameters.Add(new SqlParameter("@BookingMobile", SqlDbType.NVarChar) { Value = BookingMobile });
            cmd.Parameters.Add(new SqlParameter("@WorkerId", SqlDbType.Int) { Value = WorkerId });

            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLBooking SET BookingDate = @BookingDate, hallId = @hallId, FatraId = @FatraId, BookingName = @BookingName, 
                BookingMobile = @BookingMobile, WorkerId = @WorkerId, DateIn = GETDATE(), UserID = @UserID 
                WHERE (BookingId = @BookingId)";
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
        public static bool UpdateTBLBEradat(object BookingId, object EradTypeId, object EradDate, object EradMony, object Ebean, object org_BookingId, object org_EradTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingId", SqlDbType.Int) { Value = BookingId });
            cmd.Parameters.Add(new SqlParameter("@EradTypeId", SqlDbType.TinyInt) { Value = EradTypeId });
            cmd.Parameters.Add(new SqlParameter("@EradDate", SqlDbType.Date) { Value = EradDate });
            cmd.Parameters.Add(new SqlParameter("@EradMony", SqlDbType.Float) { Value = EradMony });
            cmd.Parameters.Add(new SqlParameter("@Ebean", SqlDbType.NVarChar) { Value = Ebean });

            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            cmd.Parameters.Add(new SqlParameter("@org_BookingId", SqlDbType.Int) { Value = org_BookingId });
            cmd.Parameters.Add(new SqlParameter("@org_EradTypeId", SqlDbType.TinyInt) { Value = org_EradTypeId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLBEradat SET BookingId = @BookingId, EradTypeId = @EradTypeId, EradDate = @EradDate, EradMony = @EradMony, Ebean = @Ebean, 
                UserID = @UserID, DateIn = GETDATE() 
                WHERE BookingId  = @org_BookingId AND EradTypeId  = @org_EradTypeId";
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
        public static bool UpdateTBLMasrofat(object BookingId, object MonsrefTypeId, object MonsrefDate, object MonsrefMony, object Mbean, object org_BookingId, object org_MonsrefTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingId", SqlDbType.Int) { Value = BookingId });
            cmd.Parameters.Add(new SqlParameter("@MonsrefTypeId", SqlDbType.TinyInt) { Value = MonsrefTypeId });
            cmd.Parameters.Add(new SqlParameter("@MonsrefDate", SqlDbType.Date) { Value = MonsrefDate });
            cmd.Parameters.Add(new SqlParameter("@MonsrefMony", SqlDbType.Float) { Value = MonsrefMony });
            cmd.Parameters.Add(new SqlParameter("@Mbean", SqlDbType.NVarChar) { Value = Mbean });

            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            cmd.Parameters.Add(new SqlParameter("@org_BookingId", SqlDbType.Int) { Value = org_BookingId });
            cmd.Parameters.Add(new SqlParameter("@org_MonsrefTypeId", SqlDbType.TinyInt) { Value = org_MonsrefTypeId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMasrofat SET BookingId = @BookingId, MonsrefTypeId = @MonsrefTypeId, MonsrefDate = @MonsrefDate, MonsrefMony = @MonsrefMony, 
                Mbean = @Mbean, UserID = @UserID, DateIn = GETDATE()
                WHERE BookingId = @org_BookingId AND MonsrefTypeId = @org_MonsrefTypeId";
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
        public static bool DeleteCDFatra(object FatraId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@FatraId", SqlDbType.TinyInt) { Value = FatraId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDFatra WHERE (FatraId = @FatraId)";
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
        public static bool DeleteCDEradType(object EradTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EradTypeId", SqlDbType.Int) { Value = EradTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDEradType WHERE (EradTypeId = @EradTypeId)";
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
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDMonsrefType(object MonsrefTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MonsrefTypeId", SqlDbType.Int) { Value = MonsrefTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDMonsrefType WHERE (MonsrefTypeId = @MonsrefTypeId)";
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
        public static bool DeleteCDJop(object JopId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@JopId", SqlDbType.TinyInt) { Value = JopId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDJop WHERE (JopId = @JopId)";
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
        public static bool DeleteCDHall(object hallId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@hallId", SqlDbType.TinyInt) { Value = hallId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDHall WHERE hallId = @hallId";
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
        public static bool DeleteTBLWorker(object WorkerId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WorkerId", SqlDbType.Int) { Value = WorkerId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLWorker WHERE WorkerId = @WorkerId";
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
        public static bool DeleteTBLBooking(object BookingId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingId", SqlDbType.Int) { Value = BookingId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLBooking WHERE BookingId = @BookingId";
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
        public static bool DeleteTBLBEradat(object BookingId, object EradTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingId", SqlDbType.Int) { Value = BookingId });
            cmd.Parameters.Add(new SqlParameter("@EradTypeId", SqlDbType.TinyInt) { Value = EradTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLBEradat WHERE BookingId = @BookingId AND EradTypeId = @EradTypeId";
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
        public static bool DeleteTBLMasrofat(object BookingId, object MonsrefTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BookingId", SqlDbType.Int) { Value = BookingId });
            cmd.Parameters.Add(new SqlParameter("@MonsrefTypeId", SqlDbType.TinyInt) { Value = MonsrefTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMasrofat WHERE BookingId = @BookingId AND MonsrefTypeId = @MonsrefTypeId";
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
