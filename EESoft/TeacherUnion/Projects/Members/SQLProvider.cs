using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Members
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
        public static DataSources.dsTeachersUnion ds = new DataSources.dsTeachersUnion();
        private static DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter adpServerDateTime = new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter();
        public static DataSources.dsTeachersUnionQueryTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsTeachersUnionQueryTableAdapters.QueriesTableAdapter();

        public static string ConnectionString
        {
            set
            {
                Properties.Settings.Default["TeachersUnionConnectionString"] = value;
                //Properties.Settings.Default.Save();
                DevExpress.Xpo.XpoDefault.Session.ConnectionString = value;
                DevExpress.Xpo.XpoDefault.Session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
                
            }
        }
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
        public static DateTime GetServerDateTime()
        {
            return (DateTime)adpServerDateTime.ScalarQueryServerDateTime();
        }

        #region -   Selecting   -
        //Codes
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
        public static DataTable SelectCDSubCommitte(object SyndicateId = null)
        {
            if (SyndicateId == null)
                return FXFW.SqlDB.LoadDataTable(@"SELECT SubCommitteId, SubCommitte, SyndicateId FROM CDSubCommitte");
            else
                return FXFW.SqlDB.LoadDataTable(@"SELECT SubCommitteId, SubCommitte, SyndicateId FROM CDSubCommitte WHERE SyndicateId = " + SyndicateId);
        }
        public static DataTable SelectCDBirthPlace()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT PlaceId, BPlace FROM CDBirthPlace");
        }
        public static DataTable SelectCDJop()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT jopId, jopName FROM CDJop");
        }
        public static DataTable SelectCDJobDescription()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT JobDescriptionId, JobDescription, jopId FROM CDJobDescription");
        }
        public static DataTable SelectCDGehaType()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT GehaTypeId, GehaType FROM CDGehaType");
        }
        public static DataTable SelectCDModerea()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT ModereaId, Moderea, GovId FROM CDModerea");
        }
        public static DataTable SelectCDEDARET()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EdaraId, EDARET, ModereaId FROM CDEDARET");
        }
        public static DataTable SelectCDGeha()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT GehaId, GehaName, GehaTypeID, GovId, ModereaId, EdaraId FROM CDGeha");
        }
        public static DataTable SelectCDQualification()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, trbawy FROM CDQualification");
        }
        public static DataTable SelectCDSpecialization()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT qualId, SpecializationId, SpecializationName FROM CDSpecialization");
        }
        public static DataTable SelectCDGender()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT GenderId, Gender FROM CDGender");
        }
        public static DataTable SelectCDReligon()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT ReligonId, Religon FROM CDReligon");
        }
        public static DataTable SelectCDEstefaaKed()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EstefaaKedId, EstefaaKed FROM CDEstefaaKed");
        }
        public static DataTable SelectCDJobtitle()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT JobtitleID, Jobtitle FROM CDJobtitle");
        }
        public static DataTable SelectCDAttachmentType()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT AttachmentTypeId, AttachmentName, AttachmentExt, AttachmentImg FROM CDAttachmentType");
        }
        public static DataTable SelectAppOptions()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT imgPath, attachPath, MandoopImgPath, imgPathWeb, 
            CompanyLogo, NormalCardCost, FastCardCost FROM AppOptions");
        }
        //Data
        public static DataTable SelectTBLMembers(object MemberId = null)
        {
            if (MemberId == null)
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, MemberNKAPAId, MemberWId, MemberLId, MemberNId, MemberName, BirthDate, MemberBPlace, MemberGender, 
            MemberReligon, MemberqualId, MemberSpecialization, qualDate, MemberaddresGov, MemberaddresMarkez, Memberaddres, MemberPhone, MemberMobil, MemberWorkPhone, MemberMail, 
            WorkeDate, KideNumber, MemberFirestJop, ZmalaEshtrakDate, SyndicateId, SubCommitteId, MemberShipNumber, Img, RandomCard, 
            (SELECT jopName FROM CDJop
                                WHERE (jopId = (SELECT MAX(MemberCurrentJop) FROM TBLMemberWork
                                WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)))) AS jopName, 
            (SELECT GehaName FROM CDGeha
                                WHERE (GehaId = (SELECT MAX(GehaId) FROM TBLMemberWork
                                WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)))) AS GehaName, 
            (SELECT JobDate FROM TBLMemberWork Where (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork 
                                WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)) AS JobDate, 
            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLMembers.SubCommitteId) AS SubCommitte,
            (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLMembers.SyndicateId) AS Syndicate, JobtitleID,
            (SELECT Jobtitle FROM CDJobtitle WHERE JobtitleID = TBLMembers.JobtitleID) AS Jobtitle,
            esalno, cardtype, dateend, Installment
            FROM TBLMembers");
            }
            else
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, MemberNKAPAId, MemberWId, MemberLId, MemberNId, MemberName, BirthDate, MemberBPlace, MemberGender, 
            MemberReligon, MemberqualId, MemberSpecialization, qualDate, MemberaddresGov, MemberaddresMarkez, Memberaddres, MemberPhone, MemberMobil, MemberWorkPhone, MemberMail, 
            WorkeDate, KideNumber, MemberFirestJop, ZmalaEshtrakDate, SyndicateId, SubCommitteId, MemberShipNumber, Img, RandomCard, 
            (SELECT jopName FROM CDJop
                                WHERE (jopId = (SELECT MAX(MemberCurrentJop) FROM TBLMemberWork
                                WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)))) AS jopName, 
            (SELECT GehaName FROM CDGeha
                                WHERE (GehaId = (SELECT MAX(GehaId) FROM TBLMemberWork
                                WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)))) AS GehaName, 
            (SELECT JobDate FROM TBLMemberWork Where (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork 
                                WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)) AS JobDate, 
            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLMembers.SubCommitteId) AS SubCommitte,
            (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLMembers.SyndicateId) AS Syndicate, JobtitleID,
            (SELECT Jobtitle FROM CDJobtitle WHERE JobtitleID = TBLMembers.JobtitleID) AS Jobtitle,
            esalno, cardtype, dateend, Installment
            FROM TBLMembers WHERE MemberId = " + MemberId);
            }
            
        }
        public static object SelectTBLMembersImg(object MemberId)
        {
            DataTable dt = FXFW.SqlDB.LoadDataTable(@"SELECT Img FROM TBLMembers WHERE MemberId = " + MemberId);
            if (dt.Rows.Count == 0)
                return null;
            else
                return dt.Rows[0][0];
        }
        public static DataTable SelectTBLMembersFast()
        {
            //CAST(NULL AS BINARY) AS Img
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, MemberName, SyndicateId, SubCommitteId, MemberShipNumber, KideNumber, JobtitleID,
            img, CAST(NULL AS BINARY) AS ImgData, Installment
            FROM TBLMembers");
        }
        public static DataTable SelectTBLMembersList()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, MemberName
            FROM TBLMembers");
        }
        public static DataTable SelectTBLMemberWork()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, GehaId, GehaTypeId, MemberCurrentJop, EdaraId, ModereaId, JobDescriptionId, 
            MemberId AS org_MemberId, GehaId AS org_GehaId FROM TBLMemberWork");
        }
        public static DataTable SelectTBLMemberWork(object MemberId)
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, GehaId, GehaTypeId, MemberCurrentJop, EdaraId, ModereaId, JobDescriptionId, 
            MemberId AS org_MemberId, GehaId AS org_GehaId FROM TBLMemberWork WHERE MemberId = " + MemberId);
        }
        public static DataTable SelectTBL_Emp()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, nationaltyId, dyana_code, MaritalStatusId, 
                         DepartmentId, EmpJobId, BIRTH_DATE, GENDER_ID, BIRTH_GOV, JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, MOBILE_NO, JobDescriptionId, 
                         Work_Start_Date, End_Work_Date, qualId, SpecializationId, QualifiedPlaceId, Moaahel_Date, tagned_id, tameen_no, tameen_date1, tameen_date2, betaka_tameen, 
                         noview, orderreport, EMPPIC,
                         Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name 
                         FROM TBL_Emp");
        }
        public static DataTable SelectTBLHafza()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT HafzaId, HafzaDate, Hafzaperson, hclose,
            (SELECT Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') FROM TBL_Emp WHERE EmpID = TBLHafza.Hafzaperson) AS Emp_Name
            FROM TBLHafza");
        }
        public static DataTable SelectTBLMemberCard()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, ComeDate, HafzaId, ReciveDate, reciveperson, emprecive, recive,
            MemberId AS org_MemberId
            FROM TBLMemberCard");
        }
        public static DataTable SelectTBLMemberEstefaa()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, EstefaaKedId, EstefaaKedIdyn, pathattach,
            MemberId AS org_MemberId, EstefaaKedId AS org_EstefaaKedId
            FROM TBLMemberEstefaa");
        }
        public static DataTable SelectTBLMandoop(bool active = false)
        {
            string command = string.Empty;
            if (active == null)
            {
                command = @"SELECT MandoopId, MandoopName, MandoopNID, MandoopJOB, MandoopMOBIL, MandoopEMAIL, 
            SyndicateId, userin, datein, MandoopImg,
            (SELECT UserName FROM Users WHERE UserID = TBLMandoop.userin) AS UserName
            FROM TBLMandoop";
            }
            else if (active)
            {
                command = @"SELECT MandoopId, MandoopName, MandoopNID, MandoopJOB, MandoopMOBIL, MandoopEMAIL, 
            SyndicateId, userin, datein, MandoopImg,
            (SELECT UserName FROM Users WHERE UserID = TBLMandoop.userin) AS UserName
            FROM TBLMandoop Where active = 1";
            }
            else
            {
                command = @"SELECT MandoopId, MandoopName, MandoopNID, MandoopJOB, MandoopMOBIL, MandoopEMAIL, 
            SyndicateId, userin, datein, MandoopImg,
            (SELECT UserName FROM Users WHERE UserID = TBLMandoop.userin) AS UserName
            FROM TBLMandoop Where active = 0";
            }
            return FXFW.SqlDB.LoadDataTable(command);
        }
        public static DataTable SelectTBLHafzaTasleem(object HafzaId = null)
        {
            if (HafzaId == null)
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT HafzaId, HafzaDate, Hafzaperson, SyndicateId, datein, userin, 
                (SELECT UserName FROM Users WHERE UserID = TBLHafzaTasleem.userin) AS UserName
                FROM TBLHafzaTasleem");    
            }
            else
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT HafzaId, HafzaDate, Hafzaperson, SyndicateId, datein, userin, 
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLHafzaTasleem.SyndicateId) AS Syndicate,
                (SELECT MandoopName FROM TBLMandoop WHERE MandoopId = TBLHafzaTasleem.Hafzaperson) AS MandoopName,
                (SELECT UserName FROM Users WHERE UserID = TBLHafzaTasleem.userin) AS UserName
                FROM TBLHafzaTasleem WHERE HafzaId = " + HafzaId);    
            }
            
        }
        public static DataTable SelectTBLHafzaTasleemDeyails(object HafzaId = null)
        {
            if (HafzaId == null)
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT HafzaId, MemberId, 
                HafzaId AS org_HafzaId, MemberId AS org_MemberId 
                FROM TBLHafzaTasleemDeyails");    
            }
            else
            {
                return FXFW.SqlDB.LoadDataTable(@"SELECT HafzaId, MemberId, '' AS Num, 
                (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLHafzaTasleemDeyails.MemberId) AS MemberName,
                (SELECT MemberShipNumber FROM TBLMembers WHERE MemberId = TBLHafzaTasleemDeyails.MemberId) AS MemberShipNumber,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SyndicateId FROM TBLMembers WHERE MemberId = TBLHafzaTasleemDeyails.MemberId)) AS Syndicate
                FROM TBLHafzaTasleemDeyails");    
            }
            
        }

        public static DataSources.dsTeachersUnion.PrintCardsDataTable SelectTBLPrintCard(object cardtype = null, object SyndicateId = null, object esalno = null, object Installment = null)
        {
            DataSources.dsTeachersUnion.PrintCardsDataTable tbl = new DataSources.dsTeachersUnion.PrintCardsDataTable();
            DataSources.dsTeachersUnionTableAdapters.PrintCardsTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.PrintCardsTableAdapter();

            if (cardtype == null)
                adp.Fill(tbl);
            else
            {
                if (FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && FXFW.SqlDB.IsNullOrEmpty(esalno))
                {
                    //adp.FillBycardtype(tbl, Convert.ToByte(cardtype));
                }
                else if (!FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && FXFW.SqlDB.IsNullOrEmpty(esalno))
                {
                    //adp.FillBycardtype_SyndicateId(tbl, Convert.ToByte(cardtype), Convert.ToInt32(SyndicateId));
                }
                else if (FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && !FXFW.SqlDB.IsNullOrEmpty(esalno))
                {
                    //adp.FillBycardtype_esalno(tbl, Convert.ToByte(cardtype), Convert.ToInt32(esalno));
                }
                else if (!FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && !FXFW.SqlDB.IsNullOrEmpty(esalno))
                {
                    //adp.FillBycardtype_esalno_SyndicateId(tbl, Convert.ToByte(cardtype), Convert.ToInt32(esalno), Convert.ToInt32(SyndicateId));
                }
            }
            return tbl;
        }
        public static DataSources.dsTeachersUnion.RePrintCardsDataTable SelectTBLPrintCardRe(object cardtype, object SyndicateId = null, object esalno = null, object Installment = null)
        {
            DataSources.dsTeachersUnion.RePrintCardsDataTable tbl = new DataSources.dsTeachersUnion.RePrintCardsDataTable();
            DataSources.dsTeachersUnionTableAdapters.RePrintCardsTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.RePrintCardsTableAdapter();

            //if (FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && FXFW.SqlDB.IsNullOrEmpty(esalno))
            //    adp.FillBycardtype_Installment(tbl, Convert.ToInt32(cardtype), Convert.ToBoolean(Installment));
            //else if (!FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && FXFW.SqlDB.IsNullOrEmpty(esalno))
            //    adp.FillBycardtype_SyndicateId_Installment(tbl, Convert.ToInt32(SyndicateId), Convert.ToInt32(cardtype), Convert.ToBoolean(Installment));
            //else if (FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && !FXFW.SqlDB.IsNullOrEmpty(esalno))
            //    adp.FillBycardtype_esalno_Installment(tbl, Convert.ToInt32(esalno), Convert.ToInt32(cardtype), Convert.ToBoolean(Installment));
            //else if (!FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && !FXFW.SqlDB.IsNullOrEmpty(esalno))
            //    adp.FillBycardtype_esalno_Installment_SyndicateId(tbl, Convert.ToInt32(esalno), Convert.ToInt32(SyndicateId), Convert.ToInt32(cardtype), Convert.ToBoolean(Installment));
            return tbl;
        }
        //Qry
        public static DataTable SelectQry1()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, MemberName, BirthDate, 
            (SELECT SubCommitte FROM CDSubCommitte WHERE (SubCommitteId = TBLMembers.SubCommitteId)) AS SubCommitte,
            (SELECT Syndicate FROM CDSyndicate WHERE (SyndicateId = TBLMembers.SyndicateId)) AS Syndicate,
            (SELECT jopName FROM CDJop
                                        WHERE (jopId = (SELECT MAX(MemberCurrentJop) FROM TBLMemberWork
                                        WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                        WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)))) AS jopName,
            (SELECT GehaName FROM CDGeha
                                        WHERE (GehaId = (SELECT MAX(GehaId) FROM TBLMemberWork
                                        WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                        WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)))) AS GehaName,
            (SELECT JobDate FROM TBLMemberWork Where (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork 
                                        WHERE (MemberId = TBLMembers.MemberId))) AND (MemberId = TBLMembers.MemberId)) AS JobDate
            FROM TBLMembers");
        }
        public static DataTable SelectQry2()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, HafzaId, ComeDate,
            (SELECT HafzaDate FROM TBLHafza WHERE HafzaId = TBLMemberCard.HafzaId) AS HafzaDate,
            (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLMemberCard.MemberId) AS MemberName,
            (SELECT MemberMobil FROM TBLMembers WHERE MemberId = TBLMemberCard.MemberId) AS MemberMobil,
            (SELECT jopName FROM CDJop
                                          WHERE (jopId = (SELECT MAX(MemberCurrentJop) FROM TBLMemberWork
                                          WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                          WHERE (MemberId = TBLMemberCard.MemberId))) AND (MemberId = TBLMemberCard.MemberId)))) AS jopName,
            (SELECT GehaName FROM CDGeha
                                           WHERE (GehaId = (SELECT MAX(GehaId) FROM TBLMemberWork
                                           WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                           WHERE (MemberId = TBLMemberCard.MemberId))) AND (MemberId = TBLMemberCard.MemberId)))) AS GehaName,
            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = (SELECT SubCommitteId FROM TBLMembers WHERE MemberId = TBLMemberCard.MemberId)) AS SubCommitte,
            (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId =  (SELECT SubCommitteId FROM TBLMembers WHERE MemberId = TBLMemberCard.MemberId)) AS Syndicate
            FROM TBLMemberCard");
        }
        public static DataTable SelectQry3()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, HafzaId, ComeDate, ReciveDate, emprecive, 
            (SELECT Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') FROM TBL_Emp WHERE EmpID = TBLMemberCard.emprecive) AS Emp_Name,
            (SELECT HafzaDate FROM TBLHafza WHERE HafzaId = TBLMemberCard.HafzaId) AS HafzaDate,
            (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLMemberCard.MemberId) AS MemberName,
            (SELECT MemberMobil FROM TBLMembers WHERE MemberId = TBLMemberCard.MemberId) AS MemberMobil,
            (SELECT jopName FROM CDJop
                                          WHERE (jopId = (SELECT MAX(MemberCurrentJop) FROM TBLMemberWork
                                          WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                          WHERE (MemberId = TBLMemberCard.MemberId))) AND (MemberId = TBLMemberCard.MemberId)))) AS jopName,
            (SELECT GehaName FROM CDGeha
                                           WHERE (GehaId = (SELECT MAX(GehaId) FROM TBLMemberWork
                                           WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                           WHERE (MemberId = TBLMemberCard.MemberId))) AND (MemberId = TBLMemberCard.MemberId)))) AS GehaName,
            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = (SELECT SubCommitteId FROM TBLMembers WHERE MemberId = TBLMemberCard.MemberId)) AS SubCommitte,
            (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SubCommitteId FROM TBLMembers WHERE MemberId = TBLMemberCard.MemberId)) AS Syndicate
            FROM TBLMemberCard");
        }
        public static DataTable SelectQry4()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, EstefaaKedId, EstefaaKedIdyn, pathattach,
            (SELECT EstefaaKed FROM CDEstefaaKed WHERE EstefaaKedId =TBLMemberEstefaa.EstefaaKedId) AS EstefaaKed, 
            (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLMemberEstefaa.MemberId) AS MemberName,
            (SELECT MemberMobil FROM TBLMembers WHERE MemberId = TBLMemberEstefaa.MemberId) AS MemberMobil,
            (SELECT jopName FROM CDJop
                                        WHERE (jopId = (SELECT MAX(MemberCurrentJop) FROM TBLMemberWork
                                        WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                        WHERE (MemberId = TBLMemberEstefaa.MemberId))) AND (MemberId = TBLMemberEstefaa.MemberId)))) AS jopName,
            (SELECT GehaName FROM CDGeha
                                        WHERE (GehaId = (SELECT MAX(GehaId) FROM TBLMemberWork
                                        WHERE (JobDate = (SELECT MAX(JobDate) FROM TBLMemberWork
                                        WHERE (MemberId = TBLMemberEstefaa.MemberId))) AND (MemberId = TBLMemberEstefaa.MemberId)))) AS GehaName,
           (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = (SELECT SubCommitteId FROM TBLMembers WHERE MemberId = TBLMemberEstefaa.MemberId)) AS SubCommitte,
           (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SubCommitteId FROM TBLMembers WHERE MemberId = TBLMemberEstefaa.MemberId)) AS Syndicate
           FROM TBLMemberEstefaa");
        }
        public static DataTable SelectQry5()
        {
//            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, MemberName,  
//            KideNumber, SyndicateId, SubCommitteId, MemberShipNumber, RandomCard, 
//            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLMembers.SubCommitteId) AS SubCommitte,
//            (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLMembers.SyndicateId) AS Syndicate,
//            datein, (SELECT UserName FROM Users WHERE UserID = TBLMembers.userin) AS UserName, esalno,
//            CAST(NULL AS BINARY) AS Img
//            FROM TBLMembers");
            return FXFW.SqlDB.LoadDataTable(@"SELECT TBLMembers.MemberId, TBLMembers.MemberName, TBLMembers.KideNumber, TBLMembers.trheelprog,
            TBLMembers.SyndicateId, TBLMembers.SubCommitteId, TBLMembers.MemberShipNumber, TBLMembers.RandomCard,
            (SELECT SubCommitte FROM CDSubCommitte WHERE (SubCommitteId = TBLMembers.SubCommitteId)) AS SubCommitte,
            (SELECT Syndicate FROM CDSyndicate WHERE (SyndicateId = TBLMembers.SyndicateId)) AS Syndicate, TBLMembers.datein,
            (SELECT RealName FROM Users WHERE (UserID = TBLMembers.userin)) AS RealName, TBLMembers.esalno, CAST(NULL AS BINARY) AS Img, 
            (SELECT RealName FROM Users WHERE UserID = TBLPrintCard.userin) AS RealNamePrint, TBLMembers.fawry,
            TBLPrintCard.printed, TBLPrintCard.printdate FROM TBLMembers LEFT OUTER JOIN
            TBLPrintCard ON TBLMembers.MemberId = TBLPrintCard.MemberId");
        }
        public static DataTable SelectQry6()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, printdate, userin,
            (SELECT esalno FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS esalno,
            (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS MemberName,
            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = (SELECT SubCommitteId FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId)) AS SubCommitte,
            (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SyndicateId FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId)) AS Syndicate,
            (SELECT MemberShipNumber FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS MemberShipNumber,
            (SELECT KideNumber FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS KideNumber,
            CAST(NULL AS BINARY) AS Img,
            (SELECT RealName FROM Users WHERE UserID = TBLPrintCard.userin) AS RealName,
            (SELECT RealName FROM Users WHERE UserID = (SELECT userin FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId)) AS MemberRealName
            FROM TBLPrintCard
            ");
        }
        public static DataTable SelectQry7()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT 
            CONVERT(DATE, datein, 20) AS datein,
            (SELECT UserName FROM Users WHERE UserID = TBLMembers.userin) AS UserName,
            COUNT(MemberId) AS CNT
            FROM TBLMembers
            GROUP BY userin, CONVERT(DATE, datein, 20)
            ");
        }
        public static DataTable SelectQry8()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, MemberName, MemberShipNumber, KideNumber, esalno, 
            (SELECT SubCommitte FROM CDSubCommitte WHERE (SubCommitteId = TBLMEM.SubCommitteId)) AS SubCommitte,
            (SELECT Syndicate FROM CDSyndicate WHERE (SyndicateId = TBLMEM.SyndicateId)) AS Syndicate
            FROM TBLMembers AS TBLMEM
            WHERE EXISTS(SELECT MemberId FROM TBLMembers WHERE MemberId != TBLMEM.MemberId AND KideNumber = TBLMEM.KideNumber)
            ");
        }

        //Report
        public static DataTable SelectRep02(object SyndicateId = null, object[] esalno = null, object start = null, object end = null)
        {
            DataTable dt = new DataTable();

            if (FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && FXFW.SqlDB.IsNullOrEmpty(esalno))
            {
                if (start != null && end != null)
                {
                    SqlCommand cmd = new SqlCommand(FXFW.SqlDB.SqlConStr)
                    {
                        CommandText = @"SELECT 
                        (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS MemberName,
                        (SELECT KideNumber FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS KideNumber
                        FROM TBLPrintCard
                        WHERE [printdate] BETWEEN @start and @end
                        ORDER BY KideNumber"
                    };
                    cmd.Parameters.Add(new SqlParameter("@start", SqlDbType.DateTime) { Value = start });
                    cmd.Parameters.Add(new SqlParameter("@end", SqlDbType.DateTime) { Value = end });
                    dt = FXFW.SqlDB.LoadDataTable(cmd);
                }
                else
                {
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT 
                    (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS MemberName,
                    (SELECT KideNumber FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS KideNumber
                    FROM TBLPrintCard
                    ORDER BY KideNumber");
                }
                
            }
            else if (!FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && FXFW.SqlDB.IsNullOrEmpty(esalno))
            {
                if (start != null && end != null)
                {
                    SqlCommand cmd = new SqlCommand(FXFW.SqlDB.SqlConStr)
                    {
                        CommandText = @"SELECT 
                    (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS MemberName,
                    (SELECT KideNumber FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS KideNumber
                    FROM TBLPrintCard 
                    WHERE [printdate] BETWEEN @start and @end AND EXISTS(SELECT MemberId FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId AND SyndicateId = " + SyndicateId +
                    ") ORDER BY KideNumber"
                    };
                    cmd.Parameters.Add(new SqlParameter("@start", SqlDbType.DateTime) { Value = start });
                    cmd.Parameters.Add(new SqlParameter("@end", SqlDbType.DateTime) { Value = end });
                    dt = FXFW.SqlDB.LoadDataTable(cmd);
                }
                else
                {
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT 
                    (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS MemberName,
                    (SELECT KideNumber FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS KideNumber
                    FROM TBLPrintCard 
                    WHERE EXISTS(SELECT MemberId FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId AND SyndicateId = " + SyndicateId +
                    ") ORDER BY KideNumber");
                }
                
            }
            else if (!FXFW.SqlDB.IsNullOrEmpty(SyndicateId) && !FXFW.SqlDB.IsNullOrEmpty(esalno))
            {
                string esalcond = " AND (esalno = " + esalno[0];
                for (int i = 1; i < esalno.Length; i++)
                    esalcond += " OR esalno = " + esalno[i];
                esalcond += ")";
                if (start != null && end != null)
                {
                    SqlCommand cmd = new SqlCommand(FXFW.SqlDB.SqlConStr)
                    {
                        CommandText = String.Format(@"SELECT  
                        (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS MemberName,
                        (SELECT KideNumber FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS KideNumber
                        FROM TBLPrintCard 
                        WHERE [printdate] BETWEEN @start and @end AND EXISTS(SELECT MemberId FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId AND SyndicateId = {0} {1}) 
                        ORDER BY KideNumber", SyndicateId, esalcond)
                    };
                    cmd.Parameters.Add(new SqlParameter("@start", SqlDbType.DateTime) { Value = start });
                    cmd.Parameters.Add(new SqlParameter("@end", SqlDbType.DateTime) { Value = end });
                    dt = FXFW.SqlDB.LoadDataTable(cmd);
                }
                else
                {
                    dt = FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT  
                        (SELECT MemberName FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS MemberName,
                        (SELECT KideNumber FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS KideNumber
                        FROM TBLPrintCard 
                        WHERE EXISTS(SELECT MemberId FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId AND SyndicateId = {0} {1}) 
                        ORDER BY KideNumber", SyndicateId, esalcond));
                }
                
            }
            return dt;
        }
        public static DataTable Selectesalno(object SyndicateId)
        {
            DataTable dt = new DataTable();
            dt = FXFW.SqlDB.LoadDataTable(@"SELECT esalno FROM TBLMembers WHERE esalno IS NOT NULL AND SyndicateId = " + SyndicateId +
                "group by esalno");
            return dt;
            
        }
        public static DataTable SelectRep03(object printdate)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(@"SELECT esalno, COUNT(esalno) AS total, SyndicateId, Syndicate FROM
            (
            SELECT esalno,
            (SELECT SyndicateId FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId) AS SyndicateId,
            (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = (SELECT SyndicateId FROM TBLMembers WHERE MemberId = TBLPrintCard.MemberId)) AS Syndicate
             FROM TBLPrintCard 
             WHERE CAST(printdate AS DATE) = @printdate
             ) T
            GROUP BY esalno, SyndicateId, Syndicate
            order by esalno");
            cmd.Parameters.Add(new SqlParameter("@printdate", SqlDbType.Date) { Value = printdate });
            dt = FXFW.SqlDB.LoadDataTable(cmd);
            return dt;

        }

        #endregion
        #region -   Inserting   -
        //General
        public static bool PrepareBaseRole()
        {
            MainFrm frm = new MainFrm();
            DataSources.dsTeachersUnionTableAdapters.RoleDetialTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.RoleDetialTableAdapter();
           try
            {
                foreach (DevExpress.XtraBars.BarItem item in frm.ribbonControl.Items)
                {
                    if (item.Name != string.Empty)
                    {
                        adp.InsertBaseRole(item.Name);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
        public static bool FillUserPrv()
        {
            DataSources.dsTeachersUnionTableAdapters.RoleDetialTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.RoleDetialTableAdapter();
            try
            {
                adp.FillByUserId(ds.RoleDetial, Program.UserInfo.UserId);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
        public static void GetFormPriv(string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;

            if (FormName.Substring(FormName.Length - 3).ToLower() == "frm")
                FormName = FormName.Substring(0, FormName.Length - 3);
            FormName = Program.AppMenuName + FormName;

            foreach (DataSources.dsTeachersUnion.RoleDetialRow row in ds.RoleDetial.Rows)
            {
                if (row.MenuItemName != FormName)
                    continue;

                if (row.Selecting)
                    Selecting = row.Selecting;
                if (row.Inserting)
                    Inserting = row.Inserting;
                if (row.Updateing)
                    Updateing = row.Updateing;
                if (row.Deleting)
                    Deleting = row.Deleting;
            }
        }
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
        public static bool InsertCDBirthPlace(string BPlace)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@BPlace", SqlDbType.NVarChar) { Value = BPlace });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDBirthPlace (PlaceId, BPlace) VALUES ((SELECT ISNULL(MAX(PlaceId) + 1, 1) FROM CDBirthPlace), @BPlace)";
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
        public static bool InsertCDJop(string jopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@jopName", SqlDbType.NVarChar) { Value = jopName });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDJop (jopId, jopName) VALUES ((SELECT ISNULL(MAX(jopId) + 1, 1) FROM CDJop), @jopName)";
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
        public static bool InsertCDJobDescription(string JobDescription, string jopId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@JobDescription", SqlDbType.NVarChar) { Value = JobDescription });
            cmd.Parameters.Add(new SqlParameter("@jopId", SqlDbType.Int) { Value = jopId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDJobDescription (JobDescriptionId, JobDescription, jopId) 
                VALUES ((SELECT ISNULL(MAX(JobDescriptionId) + 1, 1) FROM CDJobDescription), @JobDescription, @jopId)";
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
        public static bool InsertCDGehaType(string jopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GehaType", SqlDbType.NVarChar) { Value = jopName });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDGehaType (GehaTypeId, GehaType) VALUES ((SELECT ISNULL(MAX(GehaTypeId) + 1, 1) FROM CDGehaType), @GehaType)";
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
        public static bool InsertCDModerea(string Moderea, string GovId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Moderea", SqlDbType.NVarChar) { Value = Moderea });
            cmd.Parameters.Add(new SqlParameter("@GovId", SqlDbType.TinyInt) { Value = GovId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDModerea (ModereaId, Moderea, GovId) VALUES ((SELECT ISNULL(MAX(ModereaId) + 1, 1) FROM CDModerea), @Moderea, @GovId)";
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
        public static bool InsertCDEDARET(string EDARET, string ModereaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EDARET", SqlDbType.NVarChar) { Value = EDARET });
            cmd.Parameters.Add(new SqlParameter("@ModereaId", SqlDbType.TinyInt) { Value = ModereaId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDEDARET (EdaraId, EDARET, ModereaId) VALUES ((SELECT ISNULL(MAX(EdaraId) + 1, 1) FROM CDEDARET), @EDARET, @ModereaId)";
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
        public static bool InsertCDGeha(string GehaName, string GehaTypeID, string GovId, string ModereaId, string EdaraId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GehaName", SqlDbType.NVarChar) { Value = GehaName });
            cmd.Parameters.Add(new SqlParameter("@GehaTypeID", SqlDbType.TinyInt) { Value = GehaTypeID });
            cmd.Parameters.Add(new SqlParameter("@GovId", SqlDbType.TinyInt) { Value = GovId });
            cmd.Parameters.Add(new SqlParameter("@ModereaId", SqlDbType.TinyInt) { Value = ModereaId });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDGeha (GehaId, GehaName, GehaTypeID, GovId, ModereaId, EdaraId) 
                VALUES ((SELECT ISNULL(MAX(GehaId) + 1, 1) FROM CDGeha), @GehaName, @GehaTypeID, @GovId, @ModereaId, @EdaraId)";
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
        public static bool InsertCDQualification(string qualName, string trbawy)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@qualName", SqlDbType.NVarChar) { Value = qualName });
            cmd.Parameters.Add(new SqlParameter("@trbawy", SqlDbType.Bit) { Value = trbawy });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDQualification (qualId, qualName, trbawy) 
                VALUES ((SELECT ISNULL(MAX(qualId) + 1, 1) FROM CDQualification), @qualName, @trbawy)";
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
        public static bool InsertCDSpecialization(string SpecializationName, string qualId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SpecializationName", SqlDbType.NVarChar) { Value = SpecializationName });
            cmd.Parameters.Add(new SqlParameter("@qualId", SqlDbType.Int) { Value = qualId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDSpecialization (SpecializationId, SpecializationName, qualId) 
                VALUES ((SELECT ISNULL(MAX(SpecializationId) + 1, 1) FROM CDSpecialization), @SpecializationName, @qualId)";
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
        public static bool InsertCDEstefaaKed(string EstefaaKed)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EstefaaKed", SqlDbType.NVarChar) { Value = EstefaaKed });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDEstefaaKed (EstefaaKedId, EstefaaKed) VALUES ((SELECT ISNULL(MAX(EstefaaKedId) + 1, 1) FROM CDEstefaaKed), @EstefaaKed)";
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
        public static bool InsertCDJobtitle(object Jobtitle)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Jobtitle", SqlDbType.NVarChar) { Value = Jobtitle });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDJobtitle (JobtitleID, Jobtitle) VALUES ((SELECT ISNULL(MAX(JobtitleID) + 1, 1) FROM CDJobtitle), @Jobtitle)";
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
        public static bool InsertCDAttachmentType(object AttachmentName, object AttachmentExt, object AttachmentImg)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@AttachmentName", SqlDbType.NVarChar) { Value = AttachmentName });
            cmd.Parameters.Add(new SqlParameter("@AttachmentExt", SqlDbType.NVarChar) { Value = AttachmentExt });
            cmd.Parameters.Add(new SqlParameter("@AttachmentImg", SqlDbType.Image) { Value = AttachmentImg });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDAttachmentType (AttachmentTypeId, AttachmentName, AttachmentExt, AttachmentImg) VALUES 
                ((SELECT ISNULL(MAX(AttachmentTypeId) + 1, 1) FROM CDAttachmentType), @AttachmentName, @AttachmentExt, @AttachmentImg)";
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
        public static bool InsertTBLMembers(object MemberNId, object MemberName, object BirthDate, object MemberBPlace, object MemberGender,
         object MemberReligon, object MemberqualId, object MemberSpecialization, object qualDate, object MemberaddresGov, object MemberaddresMarkez, 
            object Memberaddres, object MemberPhone, object MemberMobil, object MemberWorkPhone, object MemberMail, object WorkeDate, object KideNumber,
            object MemberFirestJop, object ZmalaEshtrakDate, object SyndicateId, object SubCommitteId, object Img, object JobtitleID,
            object esalno, object cardtype, object dateend, object Installment)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO dbo.TBLMembers
                                    ( MemberId ,
                                      MemberNId ,
                                      MemberName ,
                                      BirthDate ,
                                      MemberBPlace ,
                                      MemberGender ,
                                      MemberReligon ,
                                      MemberqualId ,
                                      MemberSpecialization ,
                                      qualDate ,
                                      MemberaddresGov ,
                                      MemberaddresMarkez ,
                                      Memberaddres ,
                                      MemberPhone ,
                                      MemberMobil ,
                                      MemberWorkPhone ,
                                      MemberMail ,
                                      WorkeDate ,
                                      KideNumber ,
                                      MemberFirestJop ,
                                      ZmalaEshtrakDate ,
                                      SyndicateId ,
                                      SubCommitteId ,
                                      MemberShipNumber,
                                      Img,
                                      RandomCard,
                                      userin,
                                      datein,
                                      JobtitleID,
                                      esalno,
                                      cardtype,
                                      dateend, 
                                      Installment
                                    )
                            VALUES  ( (SELECT ISNULL(MAX(MemberId) + 1, 1) FROM TBLMembers) , -- MemberId - int
                                      @MemberNId , -- MemberNId - nvarchar(14)
                                      @MemberName , -- MemberName - nvarchar(75)
                                      @BirthDate , -- BirthDate - date
                                      @MemberBPlace , -- MemberBPlace - int
                                      @MemberGender , -- MemberGender - tinyint
                                      @MemberReligon , -- MemberReligon - tinyint
                                      @MemberqualId , -- MemberqualId - int
                                      @MemberSpecialization , -- MemberSpecialization - int
                                      @qualDate , -- qualDate - date
                                      @MemberaddresGov , -- MemberaddresGov - tinyint
                                      @MemberaddresMarkez , -- MemberaddresMarkez - int
                                      @Memberaddres , -- Memberaddres - nvarchar(100)
                                      @MemberPhone , -- MemberPhone - nvarchar(11)
                                      @MemberMobil , -- MemberMobil - nvarchar(11)
                                      @MemberWorkPhone , -- MemberWorkPhone - nvarchar(11)
                                      @MemberMail , -- MemberMail - nvarchar(50)
                                      @WorkeDate , -- WorkeDate - date
                                      @KideNumber , -- KideNumber - int
                                      @MemberFirestJop , -- MemberFirestJop - int
                                      @ZmalaEshtrakDate , -- ZmalaEshtrakDate - date
                                      @SyndicateId , -- SyndicateId - int
                                      @SubCommitteId , -- SubCommitteId - int
                                      (SELECT ISNULL(MAX(MemberShipNumber) + 1, 1) FROM TBLMembers) ,  -- MemberShipNumber - int
                                      @Img ,  -- Img - nvarchar(50)
                                      @RandomCard,
                                      @userin,
                                      GETDATE(),
                                      @JobtitleID,
                                      @esalno,
                                      @cardtype,
                                      @dateend,
                                      @Installment
                                    )";
                cmd.Parameters.Add(new SqlParameter("@MemberNId", SqlDbType.NVarChar) { Value = MemberNId });
                cmd.Parameters.Add(new SqlParameter("@MemberName", SqlDbType.NVarChar) { Value = MemberName });
                cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Value = BirthDate });
                cmd.Parameters.Add(new SqlParameter("@MemberBPlace", SqlDbType.Int) { Value = MemberBPlace });
                cmd.Parameters.Add(new SqlParameter("@MemberGender", SqlDbType.TinyInt) { Value = MemberGender });
                cmd.Parameters.Add(new SqlParameter("@MemberReligon", SqlDbType.TinyInt) { Value = MemberReligon });
                cmd.Parameters.Add(new SqlParameter("@MemberqualId", SqlDbType.Int) { Value = MemberqualId });
                cmd.Parameters.Add(new SqlParameter("@MemberSpecialization", SqlDbType.Int) { Value = MemberSpecialization });
                cmd.Parameters.Add(new SqlParameter("@qualDate", SqlDbType.Date) { Value = qualDate });
                cmd.Parameters.Add(new SqlParameter("@MemberaddresGov", SqlDbType.TinyInt) { Value = MemberaddresGov });
                cmd.Parameters.Add(new SqlParameter("@MemberaddresMarkez", SqlDbType.Int) { Value = MemberaddresMarkez });
                cmd.Parameters.Add(new SqlParameter("@Memberaddres", SqlDbType.NVarChar) { Value = Memberaddres });
                cmd.Parameters.Add(new SqlParameter("@MemberPhone", SqlDbType.NVarChar) { Value = MemberPhone });
                cmd.Parameters.Add(new SqlParameter("@MemberMobil", SqlDbType.NVarChar) { Value = MemberMobil });
                cmd.Parameters.Add(new SqlParameter("@MemberWorkPhone", SqlDbType.NVarChar) { Value = MemberWorkPhone });
                cmd.Parameters.Add(new SqlParameter("@MemberMail", SqlDbType.NVarChar) { Value = MemberMail });
                cmd.Parameters.Add(new SqlParameter("@WorkeDate", SqlDbType.Date) { Value = WorkeDate });
                cmd.Parameters.Add(new SqlParameter("@KideNumber", SqlDbType.Int) { Value = KideNumber });
                cmd.Parameters.Add(new SqlParameter("@MemberFirestJop", SqlDbType.Int) { Value = MemberFirestJop });
                cmd.Parameters.Add(new SqlParameter("@ZmalaEshtrakDate", SqlDbType.Date) { Value = ZmalaEshtrakDate });
                cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
                cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
                //cmd.Parameters.Add(new SqlParameter("@MemberShipNumber", SqlDbType.Int) { Value = MemberShipNumber });
                cmd.Parameters.Add(new SqlParameter("@Img", SqlDbType.NVarChar) { Value = Img });
                Random rnd = new Random();
                cmd.Parameters.Add(new SqlParameter("@RandomCard", SqlDbType.Int) { Value = rnd.Next(100, 999) });
                cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
                cmd.Parameters.Add(new SqlParameter("@JobtitleID", SqlDbType.Int) { Value = JobtitleID });
                cmd.Parameters.Add(new SqlParameter("@esalno", SqlDbType.Int) { Value = esalno });

                cmd.Parameters.Add(new SqlParameter("@cardtype", SqlDbType.TinyInt) { Value = cardtype });
                cmd.Parameters.Add(new SqlParameter("@dateend", SqlDbType.Date) { Value = dateend });
                cmd.Parameters.Add(new SqlParameter("@Installment", SqlDbType.Bit) { Value = Installment });
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
        public static object InsertTBLMembers(object MemberName, object SyndicateId, object SubCommitteId, object KideNumber, object JobtitleID, object Img)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = @"SELECT ISNULL(MAX(MemberId) + 1, 1) FROM TBLMembers";
                object MemberId = cmd.ExecuteScalar();

                cmd.CommandText = @"INSERT INTO dbo.TBLMembers
                                    ( MemberId ,
                                      MemberName ,
                                      SyndicateId ,
                                      SubCommitteId ,
                                      MemberShipNumber ,
                                      KideNumber ,
                                      JobtitleID,
                                      userin,
                                      datein,
                                      Img
                                    )
                            VALUES  ( (SELECT ISNULL(MAX(MemberId) + 1, 1) FROM TBLMembers) , -- MemberId - int
                                      @MemberName , -- MemberName - nvarchar(75)
                                      @SyndicateId , -- SyndicateId - int
                                      @SubCommitteId , -- SubCommitteId - int
                                      (SELECT ISNULL(MAX(MemberShipNumber) + 1, 1) FROM TBLMembers) ,  -- MemberShipNumber - int
                                      @KideNumber , -- KideNumber - int
                                      @JobtitleID,
                                      @userin,
                                      GETDATE(),
                                      @Img
                                    )";
                cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.NVarChar) { Value = MemberId });
                cmd.Parameters.Add(new SqlParameter("@MemberName", SqlDbType.NVarChar) { Value = MemberName });
                cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
                cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
                cmd.Parameters.Add(new SqlParameter("@KideNumber", SqlDbType.Int) { Value = KideNumber });
                cmd.Parameters.Add(new SqlParameter("@JobtitleID", SqlDbType.Int) { Value = JobtitleID });
                Random rnd = new Random();
                cmd.Parameters.Add(new SqlParameter("@RandomCard", SqlDbType.Int) { Value = rnd.Next(100, 999) });
                cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
                cmd.Parameters.Add(new SqlParameter("@Img", SqlDbType.NVarChar) { Value = Img });

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
        public static bool InsertTBLMemberWork(string MemberId, string GehaId, string GehaTypeId, string MemberCurrentJop, string EdaraId, string ModereaId, string JobDescriptionId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@GehaId", SqlDbType.Int) { Value = GehaId });
            cmd.Parameters.Add(new SqlParameter("@GehaTypeId", SqlDbType.TinyInt) { Value = GehaTypeId });
            cmd.Parameters.Add(new SqlParameter("@MemberCurrentJop", SqlDbType.Int) { Value = MemberCurrentJop });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@ModereaId", SqlDbType.TinyInt) { Value = ModereaId });
            cmd.Parameters.Add(new SqlParameter("@JobDescriptionId", SqlDbType.Int) { Value = JobDescriptionId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMemberWork (MemberId, GehaId, GehaTypeId, MemberCurrentJop, EdaraId, ModereaId, JobDescriptionId)
                VALUES (@MemberId, @GehaId, @GehaTypeId, @MemberCurrentJop, @EdaraId, @ModereaId, @JobDescriptionId)";
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
        public static bool InsertTBLHafza(string HafzaDate, string Hafzaperson, string hclose)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaDate", SqlDbType.Date) { Value = HafzaDate });
            cmd.Parameters.Add(new SqlParameter("@Hafzaperson", SqlDbType.Int) { Value = Hafzaperson });
            cmd.Parameters.Add(new SqlParameter("@hclose", SqlDbType.Bit) { Value = hclose });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLHafza (HafzaId, HafzaDate, Hafzaperson, hclose) VALUES 
                ((SELECT ISNULL(MAX(HafzaId) + 1, 1) FROM TBLHafza), @HafzaDate, @Hafzaperson, @hclose)";
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
        public static bool InsertTBLMemberCard(string MemberId, string ComeDate, string HafzaId, string ReciveDate, string reciveperson, string emprecive, string recive)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@ComeDate", SqlDbType.Date) { Value = ComeDate });
            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            cmd.Parameters.Add(new SqlParameter("@ReciveDate", SqlDbType.Date) { Value = ReciveDate });
            cmd.Parameters.Add(new SqlParameter("@reciveperson", SqlDbType.NVarChar) { Value = reciveperson });
            cmd.Parameters.Add(new SqlParameter("@emprecive", SqlDbType.Int) { Value = emprecive });
            cmd.Parameters.Add(new SqlParameter("@recive", SqlDbType.Bit) { Value = recive });
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMemberCard (MemberId, ComeDate, HafzaId, ReciveDate, reciveperson, emprecive, recive) VALUES 
                (@MemberId, @ComeDate, @HafzaId, @ReciveDate, @reciveperson, @emprecive, @recive)";
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
        public static bool InsertTBLMemberEstefaa(string MemberId, string EstefaaKedId, string EstefaaKedIdyn, string pathattach)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@EstefaaKedId", SqlDbType.TinyInt) { Value = EstefaaKedId });
            cmd.Parameters.Add(new SqlParameter("@EstefaaKedIdyn", SqlDbType.Bit) { Value = EstefaaKedIdyn });
            cmd.Parameters.Add(new SqlParameter("@pathattach", SqlDbType.NVarChar) { Value = pathattach });
            

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMemberEstefaa (MemberId, EstefaaKedId, EstefaaKedIdyn, pathattach) 
                VALUES (@MemberId, @EstefaaKedId, @EstefaaKedIdyn, @pathattach)";
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
        public static bool InsertTBLPrintCard(DataTable Data)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            //object MemberId, object esalno, object printed, object printdate

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@esalno", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@printed", SqlDbType.Bit) { Value = true });
            //cmd.Parameters.Add(new SqlParameter("@printdate", SqlDbType.DateTime) {  Value = DateTime.Now });
            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                cmd.CommandText = @"INSERT INTO TBLPrintCard (MemberId, esalno, printed, printdate, userin)
                                    VALUES (@MemberId, @esalno, @printed, GETDATE(), @userin)";
                foreach (DataRow row in Data.Rows)
                {
                    cmd.Parameters["@MemberId"].Value = row["MemberId"];
                    cmd.Parameters["@esalno"].Value = row["esalno"];
                    InsertEmptyValue(ref cmd);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool InsertTBLMandoop(object MandoopName, object MandoopNID, object MandoopJOB, object MandoopMOBIL,
            object MandoopEMAIL, object SyndicateId, object MandoopImg)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MandoopName", SqlDbType.NVarChar) { Value = MandoopName });
            cmd.Parameters.Add(new SqlParameter("@MandoopNID", SqlDbType.NVarChar) { Value = MandoopNID });
            cmd.Parameters.Add(new SqlParameter("@MandoopJOB", SqlDbType.NVarChar) { Value = MandoopJOB });
            cmd.Parameters.Add(new SqlParameter("@MandoopMOBIL", SqlDbType.NVarChar) { Value = MandoopMOBIL });
            cmd.Parameters.Add(new SqlParameter("@MandoopEMAIL", SqlDbType.NVarChar) { Value = MandoopEMAIL });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            cmd.Parameters.Add(new SqlParameter("@MandoopImg", SqlDbType.NVarChar) { Value = MandoopImg });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLMandoop (MandoopId, MandoopName, MandoopNID, MandoopJOB, MandoopMOBIL, MandoopEMAIL, 
                SyndicateId, userin, datein, MandoopImg)  VALUES ((SELECT ISNULL(MAX(MandoopId) + 1, 1) FROM TBLMandoop), 
                @MandoopName, @MandoopNID, @MandoopJOB, @MandoopMOBIL, @MandoopEMAIL,
                @SyndicateId, @userin, GETDATE(), @MandoopImg)";
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
        public static bool InsertTBLHafzaTasleem(object HafzaDate, object Hafzaperson, object SyndicateId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaDate", SqlDbType.Date) { Value = HafzaDate });
            cmd.Parameters.Add(new SqlParameter("@Hafzaperson", SqlDbType.Int) { Value = Hafzaperson });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });


            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLHafzaTasleem (HafzaId, HafzaDate, Hafzaperson, SyndicateId, datein, userin) 
                VALUES ((SELECT ISNULL(MAX(HafzaId) + 1, 1) FROM TBLHafzaTasleem), @HafzaDate, @Hafzaperson, @SyndicateId, GETDATE(), @userin)";
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
        public static bool InsertTBLHafzaTasleemDeyails(object HafzaId, object MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            


            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLHafzaTasleemDeyails (HafzaId, MemberId) 
                VALUES (@HafzaId, @MemberId)";
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
        public static bool UpdateCDBirthPlace(string PlaceId, string BPlace)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@PlaceId", SqlDbType.Int) { Value = PlaceId });
            cmd.Parameters.Add(new SqlParameter("@BPlace", SqlDbType.NVarChar) { Value = BPlace});
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDBirthPlace SET BPlace = @BPlace WHERE PlaceId = @PlaceId";
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
        public static bool UpdateCDJop(string jopId, string jopName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@jopId", SqlDbType.Int) { Value = jopId });
            cmd.Parameters.Add(new SqlParameter("@jopName", SqlDbType.NVarChar) { Value = jopName });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDJop SET jopName = @jopName WHERE jopId = @jopId";
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
        public static bool UpdateCDJobDescription(string JobDescriptionId, string JobDescription, string jopId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@JobDescriptionId", SqlDbType.Int) { Value = JobDescriptionId });
            cmd.Parameters.Add(new SqlParameter("@JobDescription", SqlDbType.NVarChar) { Value = JobDescription });
            cmd.Parameters.Add(new SqlParameter("@jopId", SqlDbType.Int) { Value = jopId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDJobDescription SET JobDescription = @JobDescription, jopId = @jopId WHERE JobDescriptionId = @JobDescriptionId";
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
        public static bool UpdateCDGehaType(string GehaTypeId, string GehaType)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GehaTypeId", SqlDbType.Int) { Value = GehaTypeId });
            cmd.Parameters.Add(new SqlParameter("@GehaType", SqlDbType.NVarChar) { Value = GehaType });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDGehaType SET GehaType = @GehaType WHERE GehaTypeId = @GehaTypeId";
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
        public static bool UpdateCDModerea(string ModereaId, string Moderea, string GovId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@ModereaId", SqlDbType.Int) { Value = ModereaId });
            cmd.Parameters.Add(new SqlParameter("@Moderea", SqlDbType.NVarChar) { Value = Moderea });
            cmd.Parameters.Add(new SqlParameter("@GovId", SqlDbType.TinyInt) { Value = GovId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDModerea SET Moderea = @Moderea, GovId = @GovId WHERE ModereaId = @ModereaId";
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
        public static bool UpdateCDEDARET(string EdaraId, string EDARET, string ModereaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@EDARET", SqlDbType.NVarChar) { Value = EDARET });
            cmd.Parameters.Add(new SqlParameter("@ModereaId", SqlDbType.TinyInt) { Value = ModereaId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDEDARET SET EDARET = @EDARET, ModereaId = @ModereaId WHERE EdaraId = @EdaraId";
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
        public static bool UpdateCDGeha(string GehaId, string GehaName, string GehaTypeID, string GovId, string ModereaId, string EdaraId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GehaId", SqlDbType.Int) { Value = GehaId });
            cmd.Parameters.Add(new SqlParameter("@GehaName", SqlDbType.NVarChar) { Value = GehaName });
            cmd.Parameters.Add(new SqlParameter("@GehaTypeID", SqlDbType.TinyInt) { Value = GehaTypeID });
            cmd.Parameters.Add(new SqlParameter("@GovId", SqlDbType.TinyInt) { Value = GovId });
            cmd.Parameters.Add(new SqlParameter("@ModereaId", SqlDbType.TinyInt) { Value = ModereaId });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDGeha SET 
                GehaName = @GehaName, GehaTypeID = @GehaTypeID, GovId = @GovId, ModereaId = @ModereaId, EdaraId = @EdaraId 
                WHERE GehaId = @GehaId";
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
        public static bool UpdateCDQualification(string qualId, string qualName, string trbawy)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@qualId", SqlDbType.Int) { Value = qualId });
            cmd.Parameters.Add(new SqlParameter("@qualName", SqlDbType.NVarChar) { Value = qualName });
            cmd.Parameters.Add(new SqlParameter("@trbawy", SqlDbType.Bit) { Value = trbawy });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDQualification SET qualName = @qualName, trbawy = @trbawy WHERE qualId = @qualId";
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
        public static bool UpdateCDSpecialization(string SpecializationId, string SpecializationName, string qualId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SpecializationId", SqlDbType.Int) { Value = SpecializationId });
            cmd.Parameters.Add(new SqlParameter("@SpecializationName", SqlDbType.NVarChar) { Value = SpecializationName });
            cmd.Parameters.Add(new SqlParameter("@qualId", SqlDbType.Int) { Value = qualId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDSpecialization SET SpecializationName = @SpecializationName, qualId = @qualId WHERE SpecializationId = @SpecializationId";
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
        public static bool UpdateCDEstefaaKed(string EstefaaKedId, string EstefaaKed)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EstefaaKed", SqlDbType.NVarChar) { Value = EstefaaKed });
            cmd.Parameters.Add(new SqlParameter("@EstefaaKedId", SqlDbType.TinyInt) { Value = EstefaaKedId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDEstefaaKed SET EstefaaKed = @EstefaaKed WHERE EstefaaKedId = @EstefaaKedId";
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
        public static bool UpdateCDJobtitle(object JobtitleID, object Jobtitle)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@Jobtitle", SqlDbType.NVarChar) { Value = Jobtitle });
            cmd.Parameters.Add(new SqlParameter("@JobtitleID", SqlDbType.Int) { Value = JobtitleID });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDJobtitle SET Jobtitle = @Jobtitle WHERE JobtitleID = @JobtitleID";
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
        public static bool UpdateCDAttachmentType(object AttachmentTypeId, object AttachmentName, object AttachmentExt, object AttachmentImg)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@AttachmentTypeId", SqlDbType.Int) { Value = AttachmentTypeId });
            cmd.Parameters.Add(new SqlParameter("@AttachmentName", SqlDbType.NVarChar) { Value = AttachmentName });
            cmd.Parameters.Add(new SqlParameter("@AttachmentExt", SqlDbType.NVarChar) { Value = AttachmentExt });
            cmd.Parameters.Add(new SqlParameter("@AttachmentImg", SqlDbType.Image) { Value = AttachmentImg });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDAttachmentType SET AttachmentName = @AttachmentName, AttachmentExt = @AttachmentExt, 
                AttachmentImg = @AttachmentImg WHERE AttachmentTypeId = @AttachmentTypeId";
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
        public static bool UpdateTBLMembers(object MemberId, object MemberNId, object MemberName, object BirthDate, object MemberBPlace, object MemberGender,
                object MemberReligon, object MemberqualId, object MemberSpecialization, object qualDate, object MemberaddresGov, object MemberaddresMarkez,
            object Memberaddres, object MemberPhone, object MemberMobil, object MemberWorkPhone, object MemberMail, object WorkeDate, object KideNumber,
            object MemberFirestJop, object ZmalaEshtrakDate, object SyndicateId, object SubCommitteId, object MemberShipNumber, object Img,
            object JobtitleID, object esalno, object cardtype, object dateend, object Installment)
        
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE dbo.TBLMembers SET
                                          MemberNId = @MemberNId , -- MemberNId - nvarchar(14)
                                          MemberName = @MemberName , -- MemberName - nvarchar(75)
                                          BirthDate = @BirthDate , -- BirthDate - date
                                          MemberBPlace = @MemberBPlace , -- MemberBPlace - int
                                          MemberGender = @MemberGender , -- MemberGender - tinyint
                                          MemberReligon = @MemberReligon , -- MemberReligon - tinyint
                                          MemberqualId = @MemberqualId , -- MemberqualId - int
                                          MemberSpecialization = @MemberSpecialization , -- MemberSpecialization - int
                                          qualDate = @qualDate , -- qualDate - date
                                          MemberaddresGov = @MemberaddresGov , -- MemberaddresGov - tinyint
                                          MemberaddresMarkez = @MemberaddresMarkez , -- MemberaddresMarkez - int
                                          Memberaddres = @Memberaddres , -- Memberaddres - nvarchar(100)
                                          MemberPhone = @MemberPhone , -- MemberPhone - nvarchar(11)
                                          MemberMobil = @MemberMobil , -- MemberMobil - nvarchar(11)
                                          MemberWorkPhone = @MemberWorkPhone , -- MemberWorkPhone - nvarchar(11)
                                          MemberMail = @MemberMail , -- MemberMail - nvarchar(50)
                                          WorkeDate = @WorkeDate , -- WorkeDate - date
                                          KideNumber = @KideNumber , -- KideNumber - int
                                          MemberFirestJop = @MemberFirestJop , -- MemberFirestJop - int
                                          ZmalaEshtrakDate = @ZmalaEshtrakDate , -- ZmalaEshtrakDate - date
                                          SyndicateId = @SyndicateId , -- SyndicateId - int
                                          SubCommitteId = @SubCommitteId , -- SubCommitteId - int
                                          MemberShipNumber = @MemberShipNumber ,  -- MemberShipNumber - int
                                          Img = @Img,  -- Img - nvarchar(50)
                                          datein = GETDATE(),
                                          userin = @userin,
                                          JobtitleID = @JobtitleID,
                                          esalno = @esalno,
                                          cardtype = @cardtype,
                                          dateend = @dateend,
                                          Installment = @Installment
	                                WHERE MemberId = @MemberId";
                cmd.Parameters.Add(new SqlParameter("@MemberNId", SqlDbType.NVarChar) { Value = MemberNId });
                cmd.Parameters.Add(new SqlParameter("@MemberName", SqlDbType.NVarChar) { Value = MemberName });
                cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Value = BirthDate });
                cmd.Parameters.Add(new SqlParameter("@MemberBPlace", SqlDbType.Int) { Value = MemberBPlace });
                cmd.Parameters.Add(new SqlParameter("@MemberGender", SqlDbType.TinyInt) { Value = MemberGender });
                cmd.Parameters.Add(new SqlParameter("@MemberReligon", SqlDbType.TinyInt) { Value = MemberReligon });
                cmd.Parameters.Add(new SqlParameter("@MemberqualId", SqlDbType.Int) { Value = MemberqualId });
                cmd.Parameters.Add(new SqlParameter("@MemberSpecialization", SqlDbType.Int) { Value = MemberSpecialization });
                cmd.Parameters.Add(new SqlParameter("@qualDate", SqlDbType.Date) { Value = qualDate });
                cmd.Parameters.Add(new SqlParameter("@MemberaddresGov", SqlDbType.TinyInt) { Value = MemberaddresGov });
                cmd.Parameters.Add(new SqlParameter("@MemberaddresMarkez", SqlDbType.Int) { Value = MemberaddresMarkez });
                cmd.Parameters.Add(new SqlParameter("@Memberaddres", SqlDbType.NVarChar) { Value = Memberaddres });
                cmd.Parameters.Add(new SqlParameter("@MemberPhone", SqlDbType.NVarChar) { Value = MemberPhone });
                cmd.Parameters.Add(new SqlParameter("@MemberMobil", SqlDbType.NVarChar) { Value = MemberMobil });
                cmd.Parameters.Add(new SqlParameter("@MemberWorkPhone", SqlDbType.NVarChar) { Value = MemberWorkPhone });
                cmd.Parameters.Add(new SqlParameter("@MemberMail", SqlDbType.NVarChar) { Value = MemberMail });
                cmd.Parameters.Add(new SqlParameter("@WorkeDate", SqlDbType.Date) { Value = WorkeDate });
                cmd.Parameters.Add(new SqlParameter("@KideNumber", SqlDbType.Int) { Value = KideNumber });
                cmd.Parameters.Add(new SqlParameter("@MemberFirestJop", SqlDbType.Int) { Value = MemberFirestJop });
                cmd.Parameters.Add(new SqlParameter("@ZmalaEshtrakDate", SqlDbType.Date) { Value = ZmalaEshtrakDate });
                cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
                cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
                cmd.Parameters.Add(new SqlParameter("@MemberShipNumber", SqlDbType.Int) { Value = MemberShipNumber });
                cmd.Parameters.Add(new SqlParameter("@Img", SqlDbType.NVarChar) { Value = Img });
                cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
                cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
                cmd.Parameters.Add(new SqlParameter("@JobtitleID", SqlDbType.NVarChar) { Value = JobtitleID });
                cmd.Parameters.Add(new SqlParameter("@esalno", SqlDbType.Int) { Value = esalno });

                cmd.Parameters.Add(new SqlParameter("@cardtype", SqlDbType.TinyInt) { Value = cardtype });
                cmd.Parameters.Add(new SqlParameter("@dateend", SqlDbType.Date) { Value = dateend });
                cmd.Parameters.Add(new SqlParameter("@Installment", SqlDbType.Bit) { Value = Installment });
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
        public static bool UpdateTBLMembers(object MemberId, object MemberName, object SyndicateId, object SubCommitteId, object KideNumber, object JobtitleID, object Img = null)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                if (FXFW.SqlDB.IsNullOrEmpty(Img))
                {
                    cmd.CommandText = @"UPDATE dbo.TBLMembers SET
                                          MemberName = @MemberName , -- MemberName - nvarchar(75)
                                          KideNumber = @KideNumber , -- KideNumber - int
                                          SyndicateId = @SyndicateId , -- SyndicateId - int
                                          SubCommitteId = @SubCommitteId , -- SubCommitteId - int
                                          datein = GETDATE(),
                                          userin = @userin,
                                          JobtitleID = @JobtitleID
	                                WHERE MemberId = @MemberId";
                }
                else
                {
                    cmd.CommandText = @"UPDATE dbo.TBLMembers SET
                                          MemberName = @MemberName , -- MemberName - nvarchar(75)
                                          KideNumber = @KideNumber , -- KideNumber - int
                                          SyndicateId = @SyndicateId , -- SyndicateId - int
                                          SubCommitteId = @SubCommitteId , -- SubCommitteId - int
                                          datein = GETDATE(),
                                          userin = @userin,
                                          JobtitleID = @JobtitleID,
                                          Img = @Img
	                                WHERE MemberId = @MemberId";
                    cmd.Parameters.Add(new SqlParameter("@Img", SqlDbType.NVarChar) { Value = Img });
                }
                
                cmd.Parameters.Add(new SqlParameter("@MemberName", SqlDbType.NVarChar) { Value = MemberName });
                cmd.Parameters.Add(new SqlParameter("@KideNumber", SqlDbType.Int) { Value = KideNumber });
                cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
                cmd.Parameters.Add(new SqlParameter("@SubCommitteId", SqlDbType.Int) { Value = SubCommitteId });
                cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
                cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
                cmd.Parameters.Add(new SqlParameter("@JobtitleID", SqlDbType.NVarChar) { Value = JobtitleID });

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
        public static bool UpdateTBLMembersImg(object MemberId, object Img)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE dbo.TBLMembers SET
                                          Img = @Img , -- Img - nvarchar(50)
                                          datein = GETDATE(),
                                          userin = @userin
	                                WHERE MemberId = @MemberId";

                cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
                cmd.Parameters.Add(new SqlParameter("@Img", SqlDbType.NVarChar) { Value = Img });
                cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

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
        public static bool UpdateTBLMemberWork(string MemberId, string GehaId, string GehaTypeId, string MemberCurrentJop, string EdaraId, string ModereaId, string JobDescriptionId, string org_MemberId, string org_GehaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@GehaId", SqlDbType.Int) { Value = GehaId });
            cmd.Parameters.Add(new SqlParameter("@GehaTypeId", SqlDbType.TinyInt) { Value = GehaTypeId });
            cmd.Parameters.Add(new SqlParameter("@MemberCurrentJop", SqlDbType.Int) { Value = MemberCurrentJop });
            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = EdaraId });
            cmd.Parameters.Add(new SqlParameter("@ModereaId", SqlDbType.TinyInt) { Value = ModereaId });
            cmd.Parameters.Add(new SqlParameter("@JobDescriptionId", SqlDbType.Int) { Value = JobDescriptionId });
            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });
            cmd.Parameters.Add(new SqlParameter("@org_GehaId", SqlDbType.Int) { Value = org_GehaId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMemberWork SET MemberId = @MemberId, GehaId = @GehaId, GehaTypeId = @GehaTypeId, MemberCurrentJop = @MemberCurrentJop, 
                EdaraId = @EdaraId, ModereaId = @ModereaId, JobDescriptionId = @JobDescriptionId WHERE (MemberId = @org_MemberId) AND (GehaId = @org_GehaId)";
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
        public static bool UpdateTBLHafza(string HafzaId, string HafzaDate, string Hafzaperson, string hclose)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            cmd.Parameters.Add(new SqlParameter("@HafzaDate", SqlDbType.Date) { Value = HafzaDate });
            cmd.Parameters.Add(new SqlParameter("@Hafzaperson", SqlDbType.Int) { Value = Hafzaperson });
            cmd.Parameters.Add(new SqlParameter("@hclose", SqlDbType.Bit) { Value = hclose });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLHafza SET HafzaDate = @HafzaDate, Hafzaperson = @Hafzaperson, hclose = @hclose WHERE HafzaId = @HafzaId";
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
        public static bool UpdateTBLMemberCard(string MemberId, string ComeDate, string HafzaId, string ReciveDate, string reciveperson, string emprecive, string recive, string org_MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@ComeDate", SqlDbType.Date) { Value = ComeDate });
            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            cmd.Parameters.Add(new SqlParameter("@ReciveDate", SqlDbType.Date) { Value = ReciveDate });
            cmd.Parameters.Add(new SqlParameter("@reciveperson", SqlDbType.NVarChar) { Value = reciveperson });
            cmd.Parameters.Add(new SqlParameter("@emprecive", SqlDbType.Int) { Value = emprecive });
            cmd.Parameters.Add(new SqlParameter("@recive", SqlDbType.Bit) { Value = recive });
            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMemberCard SET MemberId = @MemberId, ComeDate = @ComeDate, HafzaId = @HafzaId, ReciveDate = @ReciveDate, reciveperson = @reciveperson, 
                emprecive = @emprecive, recive = @recive WHERE MemberId = @org_MemberId";
                
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
        public static bool UpdateTBLMemberEstefaa(string MemberId, string EstefaaKedId, string EstefaaKedIdyn, string pathattach, string org_MemberId, string org_EstefaaKedId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@EstefaaKedId", SqlDbType.TinyInt) { Value = EstefaaKedId });
            cmd.Parameters.Add(new SqlParameter("@EstefaaKedIdyn", SqlDbType.Bit) { Value = EstefaaKedIdyn });
            cmd.Parameters.Add(new SqlParameter("@pathattach", SqlDbType.NVarChar) { Value = pathattach });
            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });
            cmd.Parameters.Add(new SqlParameter("@org_EstefaaKedId", SqlDbType.TinyInt) { Value = org_EstefaaKedId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMemberEstefaa SET 
                MemberId = @MemberId, EstefaaKedId = @EstefaaKedId, EstefaaKedIdyn = @EstefaaKedIdyn, pathattach = @pathattach
                WHERE MemberId = @org_MemberId AND EstefaaKedId = @org_EstefaaKedId";
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
        public static bool UpdateTBLMandoop(object MandoopId, object MandoopName, object MandoopNID, object MandoopJOB, 
            object MandoopMOBIL, object MandoopEMAIL, object SyndicateId, object MandoopImg)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MandoopId", SqlDbType.Int) { Value = MandoopId });
            cmd.Parameters.Add(new SqlParameter("@MandoopName", SqlDbType.NVarChar) { Value = MandoopName });
            cmd.Parameters.Add(new SqlParameter("@MandoopNID", SqlDbType.NVarChar) { Value = MandoopNID });
            cmd.Parameters.Add(new SqlParameter("@MandoopJOB", SqlDbType.NVarChar) { Value = MandoopJOB });
            cmd.Parameters.Add(new SqlParameter("@MandoopMOBIL", SqlDbType.NVarChar) { Value = MandoopMOBIL });
            cmd.Parameters.Add(new SqlParameter("@MandoopEMAIL", SqlDbType.NVarChar) { Value = MandoopEMAIL });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            cmd.Parameters.Add(new SqlParameter("@MandoopImg", SqlDbType.NVarChar) { Value = MandoopImg });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLMandoop SET 
                MandoopName = @MandoopName, MandoopNID = @MandoopNID, MandoopJOB = @MandoopJOB, MandoopMOBIL = @MandoopMOBIL,
                MandoopEMAIL = @MandoopEMAIL, SyndicateId = @SyndicateId, userin = @userin, datein = GETDATE(), MandoopImg = @MandoopImg
                WHERE MandoopId = @MandoopId";
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
        public static bool UpdateTBLHafzaTasleem(object HafzaId, object HafzaDate, object Hafzaperson, object SyndicateId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            cmd.Parameters.Add(new SqlParameter("@HafzaDate", SqlDbType.Date) { Value = HafzaDate });
            cmd.Parameters.Add(new SqlParameter("@Hafzaperson", SqlDbType.Int) { Value = Hafzaperson });
            cmd.Parameters.Add(new SqlParameter("@SyndicateId", SqlDbType.Int) { Value = SyndicateId });
            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLHafzaTasleem SET 
                HafzaDate = @HafzaDate, Hafzaperson = @Hafzaperson, SyndicateId = @SyndicateId, datein = GETDATE(), userin = @userin
                WHERE HafzaId = @HafzaId";
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
        public static bool UpdateTBLHafzaTasleemDeyails(object HafzaId, object MemberId, object org_HafzaId, object org_MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@org_HafzaId", SqlDbType.Int) { Value = org_HafzaId });
            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });
            

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLHafzaTasleemDeyails SET 
                HafzaId = @HafzaId, MemberId = @MemberId
                WHERE HafzaId = @org_HafzaId AND MemberId = @org_MemberId";
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
        public static bool DeleteCDBirthPlace(string PlaceId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@PlaceId", SqlDbType.Int) { Value = PlaceId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDBirthPlace WHERE (PlaceId = @PlaceId)";
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
        public static bool DeleteCDJop(string jopId)
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
                return true;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
        }
        public static bool DeleteCDJobDescription(string JobDescriptionId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@JobDescriptionId", SqlDbType.Int) { Value = JobDescriptionId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDJobDescription WHERE (JobDescriptionId = @JobDescriptionId)";
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
        public static bool DeleteCDGehaType(string GehaTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GehaTypeId", SqlDbType.Int) { Value = GehaTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDGehaType WHERE (GehaTypeId = @GehaTypeId)";
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
        public static bool DeleteCDModerea(string ModereaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@ModereaId", SqlDbType.Int) { Value = ModereaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDModerea WHERE (ModereaId = @ModereaId)";
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
        public static bool DeleteCDEDARET(string ModereaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EdaraId", SqlDbType.Int) { Value = ModereaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDEDARET WHERE (EdaraId = @EdaraId)";
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
        public static bool DeleteCDGeha(string ModereaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@GehaId", SqlDbType.Int) { Value = ModereaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDGeha WHERE (GehaId = @GehaId)";
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
        public static bool DeleteCDQualification(string ModereaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@qualId", SqlDbType.Int) { Value = ModereaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDQualification WHERE (qualId = @qualId)";
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
        public static bool DeleteCDSpecialization(string ModereaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@SpecializationId", SqlDbType.Int) { Value = ModereaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDSpecialization WHERE (SpecializationId = @SpecializationId)";
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
        public static bool DeleteCDEstefaaKed(string EstefaaKedId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EstefaaKedId", SqlDbType.TinyInt) { Value = EstefaaKedId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDEstefaaKed WHERE (EstefaaKedId = @EstefaaKedId)";
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
        public static bool DeleteCDJobtitle(object JobtitleID)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@JobtitleID", SqlDbType.Int) { Value = JobtitleID });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDJobtitle WHERE (JobtitleID = @JobtitleID)";
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
        public static bool DeleteCDAttachmentType(object AttachmentTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@AttachmentTypeId", SqlDbType.Int) { Value = AttachmentTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDAttachmentType WHERE (AttachmentTypeId = @AttachmentTypeId)";
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
        public static bool DeleteTBLMembers(string MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMembers WHERE (MemberId = @MemberId)";
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
        public static bool DeleteTBLMemberWork(string MemberId, string GehaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = MemberId });
            cmd.Parameters.Add(new SqlParameter("@org_GehaId", SqlDbType.Int) { Value = GehaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMemberWork WHERE (MemberId = @org_MemberId) AND (GehaId = @org_GehaId)";
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
        public static bool DeleteTBLHafza(string HafzaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLHafza WHERE (HafzaId = @HafzaId)";
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
        public static bool DeleteTBLMemberCard(string MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMemberCard WHERE (MemberId = @MemberId)";
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
        public static bool DeleteTBLMemberEstefaa(string org_MemberId, string org_EstefaaKedId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@org_MemberId", SqlDbType.Int) { Value = org_MemberId });
            cmd.Parameters.Add(new SqlParameter("@org_EstefaaKedId", SqlDbType.Int) { Value = org_EstefaaKedId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMemberEstefaa WHERE (MemberId = @org_MemberId) AND (EstefaaKedId = @org_EstefaaKedId)";
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
        public static bool DeleteTBLMandoop(object MandoopId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MandoopId", SqlDbType.Int) { Value = MandoopId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLMandoop WHERE (MandoopId = @MandoopId)";
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
        public static bool DeleteTBLHafzaTasleem(object HafzaId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLHafzaTasleem WHERE (HafzaId = @HafzaId)";
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
        public static bool DeleteTBLHafzaTasleemDeyails(object HafzaId, object MemberId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@HafzaId", SqlDbType.Int) { Value = HafzaId });
            cmd.Parameters.Add(new SqlParameter("@MemberId", SqlDbType.Int) { Value = MemberId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLHafzaTasleemDeyails WHERE (HafzaId = @HafzaId) AND (MemberId = @MemberId)";
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
