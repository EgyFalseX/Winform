using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace ServiceQuery
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
        public static DataTable SelectCDEdara()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EdaraId, Edara FROM CDEdara");
        }
        public static DataTable SelectCDserviceType()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT serviceTypeId, servicesType FROM CDserviceType");
        }
        public static DataTable SelectCDReply()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT Replyid, Reply FROM CDReply");
        }
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
        public static DataTable SelectCDAttatech()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT AttatechID, Attatech, serviceTypeId FROM CDAttatech");
        }
        //Data
        public static DataTable SelectTBLWared()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT WaredId, EdaraId, serviceTypeId, SyndicateId, SubCommitteId, WaredDate, MandopName, USERIN, DATEIN,
            (SELECT Edara FROM CDEdara WHERE EdaraId = TBLWared.EdaraId) + ' - ' + (SELECT servicesType FROM CDserviceType WHERE serviceTypeId = TBLWared.serviceTypeId) + ' - ' + 
            (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLWared.SyndicateId) AS details
            FROM TBLWared");
        }
        public static DataTable SelectTBLWaredDetails(object WaredId)
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT WaredDetailsID, WaredId, Mname, Mkid, Mmemberno, MmemberSARFno, DREMARK, USERIN, DATEIN
            FROM TBLWaredDetails WHERE WaredId = " + WaredId);
        }
        public static DataTable SelectTBLWaredAttach(object WaredId)
        {
            return FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT WaredDetailsID, AttatechID, ATTREMARK,
            WaredDetailsID AS org_WaredDetailsID, AttatechID AS org_AttatechID
            FROM TBLWaredAttach WHERE EXISTS (SELECT WaredDetailsID FROM TBLWaredDetails WHERE WaredId = {0})", WaredId));
        }
        public static DataTable SelectTBLTransfer(object WaredId)
        {
            return FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT WaredDetailsID, EdaraId, transferdate, recive, 
            WaredDetailsID AS org_WaredDetailsID, EdaraId AS org_EdaraId, transferdate AS org_transferdate
            FROM TBLTransfer WHERE EXISTS (SELECT WaredDetailsID FROM TBLWaredDetails WHERE WaredId = {0})", WaredId));
        }
        public static DataTable SelectTBLReply(object WaredId)
        {
            return FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT WaredDetailsID, EdaraId, Replyid, Replydate, replyremark, 
            WaredDetailsID AS org_WaredDetailsID, EdaraId AS org_EdaraId, Replyid AS org_Replyid
            FROM TBLReply WHERE EXISTS (SELECT WaredDetailsID FROM TBLWaredDetails WHERE WaredId = {0})", WaredId));
        }

        #endregion
        #region -   Inserting   -
        //Code
        public static bool InsertCDEdara(object Edara)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Edara", SqlDbType.NVarChar) { Value = Edara });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDEdara (EdaraId, Edara) VALUES ((SELECT ISNULL(MAX(EdaraId) + 1, 1) FROM CDEdara), @Edara)";
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
        public static bool InsertCDserviceType(object servicesType)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@servicesType", SqlDbType.NVarChar) { Value = servicesType });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDserviceType (serviceTypeId, servicesType) VALUES ((SELECT ISNULL(MAX(serviceTypeId) + 1, 1) FROM CDserviceType), @servicesType)";
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
        public static bool InsertCDReply(object Reply)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Reply", SqlDbType.NVarChar) { Value = Reply });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDReply (Replyid, Reply) VALUES ((SELECT ISNULL(MAX(Replyid) + 1, 1) FROM CDReply), @Reply)";
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
        public static bool InsertCDAttatech(object Attatech, object serviceTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Attatech", SqlDbType.NVarChar) { Value = Attatech });
            cmd.Parameters.Add(new SqlParameter("@serviceTypeId", SqlDbType.Int) { Value = serviceTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDAttatech (AttatechID, Attatech, serviceTypeId) VALUES ((SELECT ISNULL(MAX(AttatechID) + 1, 1) FROM CDAttatech), @Attatech, @serviceTypeId)";
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
        public static bool InsertTBLWared(object EdaraId, object serviceTypeId, object SyndicateId, object SubCommitteId, object WaredDate, object MandopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@serviceTypeId", SqlDbType.Int) { Value = serviceTypeId });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@WaredDate", SqlDbType.Date) { Value = WaredDate });
            cmd.Parameters.Add(new SqlParameter("@MandopName", SqlDbType.NVarChar) { Value = MandopName });

            cmd.Parameters.Add(new SqlParameter("@USERIN", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLWared (WaredId, EdaraId, serviceTypeId, SyndicateId, SubCommitteId, WaredDate, MandopName, USERIN, DATEIN)
                VALUES ((SELECT ISNULL(MAX(WaredId) + 1, 1) FROM TBLWared), @EdaraId, @serviceTypeId, @SyndicateId, @SubCommitteId, @WaredDate, @MandopName, @USERIN, GETDATE())";
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
        public static bool InsertTBLWaredDetails(object WaredId, object Mname, object Mkid, object Mmemberno, object MmemberSARFno, object DREMARK)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredId", SqlDbType.Int) { Value = WaredId });
            cmd.Parameters.Add(new SqlParameter("@Mname", SqlDbType.NVarChar) { Value = Mname });
            cmd.Parameters.Add(new SqlParameter("@Mkid", SqlDbType.Int) { Value = Mkid });
            cmd.Parameters.Add(new SqlParameter("@Mmemberno", SqlDbType.Int) { Value = Mmemberno });
            cmd.Parameters.Add(new SqlParameter("@MmemberSARFno", SqlDbType.Int) { Value = MmemberSARFno });
            cmd.Parameters.Add(new SqlParameter("@DREMARK", SqlDbType.NText) { Value = DREMARK });

            cmd.Parameters.Add(new SqlParameter("@USERIN", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });


            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLWaredDetails (WaredDetailsID, WaredId, Mname, Mkid, Mmemberno, MmemberSARFno, DREMARK, USERIN, DATEIN)
                VALUES ((SELECT ISNULL(MAX(WaredDetailsID) + 1, 1) FROM TBLWaredDetails), @WaredId, @Mname, @Mkid, @Mmemberno, @MmemberSARFno, @DREMARK, @USERIN, GETDATE())";
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
        public static bool InsertTBLWaredAttach(object WaredDetailsID, object AttatechID, object ATTREMARK)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@AttatechID", SqlDbType.Int) { Value = AttatechID });
            cmd.Parameters.Add(new SqlParameter("@ATTREMARK", SqlDbType.NVarChar) { Value = ATTREMARK });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLWaredAttach (WaredDetailsID, AttatechID, ATTREMARK)
                VALUES (@WaredDetailsID, @AttatechID, @ATTREMARK)";
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
        public static bool InsertTBLTransfer(object WaredDetailsID, object EdaraId, object transferdate, object recive)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@transferdate", SqlDbType.Date) { Value = transferdate });
            cmd.Parameters.Add(new SqlParameter("@recive", SqlDbType.Bit) { Value = recive });

            cmd.Parameters.Add(new SqlParameter("@USERIN", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLTransfer (WaredDetailsID, EdaraId, transferdate, recive, USERIN, DATEIN)
                VALUES (@WaredDetailsID, @EdaraId, @transferdate, @recive, @USERIN, GETDATE())";
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
        public static bool InsertTBLReply(object WaredDetailsID, object EdaraId, object Replyid, object Replydate, object replyremark)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@Replyid", SqlDbType.Int) { Value = Replyid });
            cmd.Parameters.Add(new SqlParameter("@Replydate", SqlDbType.Date) { Value = Replydate });
            cmd.Parameters.Add(new SqlParameter("@replyremark", SqlDbType.NText) { Value = replyremark });

            cmd.Parameters.Add(new SqlParameter("@USERIN", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLReply (WaredDetailsID, EdaraId, Replyid, Replydate, replyremark, USERIN, DATEIN)
                VALUES (@WaredDetailsID, @EdaraId, @Replyid, @Replydate, @replyremark, @USERIN, GETDATE())";
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
        public static bool UpdateCDEdara(object EdaraId, object Edara)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@Edara", SqlDbType.NVarChar) { Value = Edara });
            
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDEdara SET Edara = @Edara WHERE (EdaraId = @EdaraId)";
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
        public static bool UpdateCDserviceType(object serviceTypeId, object servicesType)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@serviceTypeId", SqlDbType.Int) { Value = serviceTypeId });
            cmd.Parameters.Add(new SqlParameter("@servicesType", SqlDbType.NVarChar) { Value = servicesType });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDserviceType SET servicesType = @servicesType WHERE (serviceTypeId = @serviceTypeId)";
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
        public static bool UpdateCDReply(object Replyid, object Reply)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Replyid", SqlDbType.Int) { Value = Replyid });
            cmd.Parameters.Add(new SqlParameter("@Reply", SqlDbType.NVarChar) { Value = Reply });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDReply SET Reply = @Reply WHERE (Replyid = @Replyid)";
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
        public static bool UpdateCDAttatech(object AttatechID, object Attatech, object serviceTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@AttatechID", SqlDbType.Int) { Value = AttatechID });
            cmd.Parameters.Add(new SqlParameter("@Attatech", SqlDbType.NVarChar) { Value = Attatech });
            cmd.Parameters.Add(new SqlParameter("@serviceTypeId", SqlDbType.Int) { Value = serviceTypeId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDAttatech SET Attatech = @Attatech, serviceTypeId = @serviceTypeId WHERE (AttatechID = @AttatechID)";
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
        public static bool UpdateTBLWared(object WaredId, object EdaraId, object serviceTypeId, object SyndicateId, object SubCommitteId, object WaredDate, object MandopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredId", SqlDbType.Int) { Value = WaredId });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@serviceTypeId", SqlDbType.Int) { Value = serviceTypeId });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
            cmd.Parameters.Add(new SqlParameter("@WaredDate", SqlDbType.Date) { Value = WaredDate });
            cmd.Parameters.Add(new SqlParameter("@MandopName", SqlDbType.NVarChar) { Value = MandopName });

            cmd.Parameters.Add(new SqlParameter("@USERIN", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLWared SET EdaraId = @EdaraId, serviceTypeId = @serviceTypeId, SyndicateId = @SyndicateId, SubCommitteId = @SubCommitteId, 
                WaredDate = @WaredDate, MandopName = @MandopName, USERIN = @USERIN, DATEIN = GETDATE() WHERE WaredId = @WaredId";
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
        public static bool UpdateTBLWaredDetails(object WaredDetailsID, object WaredId, object Mname, object Mkid, object Mmemberno, object MmemberSARFno, object DREMARK)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@WaredId", SqlDbType.Int) { Value = WaredId });
            cmd.Parameters.Add(new SqlParameter("@Mname", SqlDbType.NVarChar) { Value = Mname });
            cmd.Parameters.Add(new SqlParameter("@Mkid", SqlDbType.Int) { Value = Mkid });
            cmd.Parameters.Add(new SqlParameter("@Mmemberno", SqlDbType.Int) { Value = Mmemberno });
            cmd.Parameters.Add(new SqlParameter("@MmemberSARFno", SqlDbType.Int) { Value = MmemberSARFno });
            cmd.Parameters.Add(new SqlParameter("@DREMARK", SqlDbType.NText) { Value = DREMARK });

            cmd.Parameters.Add(new SqlParameter("@USERIN", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLWaredDetails SET WaredId = @WaredId, Mname = @Mname, Mkid = @Mkid, Mmemberno = @Mmemberno, 
                MmemberSARFno = @MmemberSARFno, DREMARK = @DREMARK, USERIN = @USERIN, DATEIN = GETDATE() WHERE WaredDetailsID = @WaredDetailsID";
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
        public static bool UpdateTBLWaredAttach(object WaredDetailsID, object AttatechID, object ATTREMARK, object org_WaredDetailsID, object org_AttatechID)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@AttatechID", SqlDbType.Int) { Value = AttatechID });
            cmd.Parameters.Add(new SqlParameter("@ATTREMARK", SqlDbType.NVarChar) { Value = ATTREMARK });

            cmd.Parameters.Add(new SqlParameter("@org_WaredDetailsID", SqlDbType.Int) { Value = org_WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@org_AttatechID", SqlDbType.Int) { Value = org_AttatechID });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLWaredAttach SET WaredDetailsID = @WaredDetailsID, AttatechID = @AttatechID, ATTREMARK = @ATTREMARK 
                WHERE WaredDetailsID = @org_WaredDetailsID AND AttatechID = @org_AttatechID";
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
        public static bool UpdateTBLTransfer(object WaredDetailsID, object EdaraId, object transferdate, object recive, object org_WaredDetailsID, object org_EdaraId, object org_transferdate)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            
            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@transferdate", SqlDbType.Date) { Value = transferdate });
            cmd.Parameters.Add(new SqlParameter("@recive", SqlDbType.Bit) { Value = recive });

            cmd.Parameters.Add(new SqlParameter("@USERIN", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            cmd.Parameters.Add(new SqlParameter("@org_WaredDetailsID", SqlDbType.Int) { Value = org_WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@org_EdaraId", SqlDbType.Int) { Value = org_EdaraId });
            cmd.Parameters.Add(new SqlParameter("@org_transferdate", SqlDbType.Date) { Value = org_transferdate });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLTransfer SET WaredDetailsID = @WaredDetailsID, EdaraId = @EdaraId, transferdate = @transferdate 
                WHERE WaredDetailsID = @org_WaredDetailsID AND EdaraId = @org_EdaraId AND transferdate = @org_transferdate";
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
        public static bool UpdateTBLReply(object WaredDetailsID, object EdaraId, object Replyid, object Replydate, object replyremark, object org_WaredDetailsID, object org_EdaraId, object org_Replyid)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);


            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@Replyid", SqlDbType.Int) { Value = Replyid });
            cmd.Parameters.Add(new SqlParameter("@Replydate", SqlDbType.Date) { Value = Replydate });
            cmd.Parameters.Add(new SqlParameter("@replyremark", SqlDbType.NText) { Value = replyremark });

            cmd.Parameters.Add(new SqlParameter("@USERIN", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            cmd.Parameters.Add(new SqlParameter("@org_WaredDetailsID", SqlDbType.Int) { Value = org_WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@org_EdaraId", SqlDbType.Int) { Value = org_EdaraId });
            cmd.Parameters.Add(new SqlParameter("@org_Replyid", SqlDbType.Int) { Value = org_Replyid });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLReply SET WaredDetailsID = @WaredDetailsID, EdaraId = @EdaraId, Replyid = @Replyid, Replydate = @Replydate, 
                replyremark = @replyremark, USERIN = @USERIN, DATEIN = GETDATE() 
                WHERE WaredDetailsID = @org_WaredDetailsID AND EdaraId = @org_EdaraId AND Replyid = @org_Replyid";
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
        public static bool DeleteCDEdara(object EdaraId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDEdara WHERE (EdaraId = @EdaraId)";
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
        public static bool DeleteCDserviceType(object serviceTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@serviceTypeId", SqlDbType.Int) { Value = serviceTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDserviceType WHERE (serviceTypeId = @serviceTypeId)";
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
        public static bool DeleteCDReply(object Replyid)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Replyid", SqlDbType.Int) { Value = Replyid });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDReply WHERE (Replyid = @Replyid)";
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
        public static bool DeleteCDAttatech(object AttatechID)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@AttatechID", SqlDbType.Int) { Value = AttatechID });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDAttatech WHERE (AttatechID = @AttatechID)";
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
        public static bool DeleteTBLWared(object WaredId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredId", SqlDbType.Int) { Value = WaredId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLWared WHERE (WaredId = @WaredId)";
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
        public static bool DeleteTBLWaredDetails(object WaredDetailsID)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLWaredDetails WHERE (WaredDetailsID = @WaredDetailsID)";
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
        public static bool DeleteTBLWaredAttach(object WaredDetailsID, object AttatechID)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@AttatechID", SqlDbType.Int) { Value = AttatechID });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLWaredAttach WHERE (WaredDetailsID = @WaredDetailsID) AND (AttatechID = @AttatechID)";
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
        public static bool DeleteTBLTransfer(object WaredDetailsID, object EdaraId, object transferdate)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@transferdate", SqlDbType.Int) { Value = transferdate });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLTransfer WHERE (WaredDetailsID = @WaredDetailsID) AND (EdaraId = @EdaraId) AND (transferdate = @transferdate)";
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
        public static bool DeleteTBLReply(object WaredDetailsID, object EdaraId, object Replyid)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@WaredDetailsID", SqlDbType.Int) { Value = WaredDetailsID });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@Replyid", SqlDbType.Int) { Value = Replyid });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLReply WHERE (WaredDetailsID = @WaredDetailsID) AND (EdaraId = @EdaraId) AND (Replyid = @Replyid)";
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
