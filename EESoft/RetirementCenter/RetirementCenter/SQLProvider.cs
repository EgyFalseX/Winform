using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Configuration;

namespace RetirementCenter
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
        public static DataSources.dsRetirementCenter ds = new DataSources.dsRetirementCenter();
        public static DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();

        public static string ConnectionString
        {
            set
            {
                Properties.Settings.Default["RetirementCenterConnectionString"] = value;
                //Properties.Settings.Default.Save();
                DevExpress.Xpo.XpoDefault.Session.ConnectionString = value;
                DevExpress.Xpo.XpoDefault.Session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;

                //Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                ////the full name of the connection string can be found in the app.config file
                //// in the "name" attribute of the connection string
                //_config.ConnectionStrings.ConnectionStrings["RetirementCenter.Properties.Settings.RetirementCenterConnectionString"].ConnectionString = value;

                ////Save to file
                //_config.Save(ConfigurationSaveMode.Modified);

                ////force changes to take effect so that we can start using
                ////this new connection string immediately
                //ConfigurationManager.RefreshSection(_config.ConnectionStrings.SectionInformation.Name);

                //Properties.Settings.Default.Reload();
                
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
        public static DateTime ServerDateTime()
        {
            return (DateTime)adpQry.ServerDateTime();
        }
        public static void PerformUpdate()
        {
            int currentVersion = Convert.ToInt32(Application.ProductVersion.Replace(".", ""));
            int? serverVersion = adpQry.AppOptions_GetAppVersion();


          

            if (serverVersion == null)
	        {
                if (!Program.UserInfo.IsAdmin)
                    return;
                if (msgDlg.Show("لا يوجد محتوي للبرنامج علي الخادم. هل ترغب في ارسال هذه النسخه للخادم؟", msgDlg.msgButtons.YesNo) == DialogResult.No)
                    return;
                byte[] data = File.ReadAllBytes(Application.ExecutablePath);
                adpQry.AppOptions_UploadAppData(data, currentVersion);
	        }
            else
            {
                if (serverVersion == currentVersion)
                    return;
                else if (serverVersion < currentVersion)
                {
                    if (!Program.UserInfo.IsAdmin)
                        return;
                    if (msgDlg.Show("هذه الاصداره جديده عن الموجوده علي الخادم, هل ترغب في تحديث الخادم؟", msgDlg.msgButtons.YesNo) == DialogResult.No)
                        return;
                    byte[] data = File.ReadAllBytes(Application.ExecutablePath);
                    adpQry.AppOptions_UploadAppData(data, currentVersion);
                }
                else
                {
                    if (msgDlg.Show("يوجد اصداره جديده من البرنامج علي الخادم, هل ترغب في التحديث؟", msgDlg.msgButtons.YesNo) == DialogResult.No)
                        return;
                    //if (File.Exists(updatePath))
                    //    File.Delete(updatePath);
                    byte[] data = adpQry.AppOptions_GetAppData();
                    FileStream fs = File.Create(Program.updatePath);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                    System.Diagnostics.Process.Start(Program.updatePath);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
        }
        public static DataTable PersonNameCounter()
        {
            DataTable dt = FXFW.SqlDB.LoadDataTable(@"SELECT TBLWarasa.PersonId, TBLWarasa.personName, TBLWarasa.SyndicateId, TBLWarasa.SubCommitteId, TBLMashat.MMashatName, TBLMashat.sarfnumber, '' AS Names, TBLWarasa.MMashatId
            FROM TBLWarasa LEFT OUTER JOIN TBLMashat ON TBLWarasa.MMashatId = TBLMashat.MMashatId");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Names"] = dt.Rows[i]["personName"].ToString().Split(' ').Length;
            }
            return dt;
        }

        public static void XXX()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            SqlConnection con2 = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlCommand cmd2 = new SqlCommand("", con2);
            SqlDataReader dr = null;
            con.Open();
            con2.Open();
            cmd.CommandText = @"select * from FromAccess";
            dr = cmd.ExecuteReader();
            int counter = 1;
            while (dr.Read())
            {
                cmd2.CommandText = string.Format(@"update FromAccess set mid = {0} where MashHalaId = {1} AND SyndicateId = {2} AND SubCommitteId = {3} AND sarfnumber = {4} AND accsessmony = {5}",
                counter, dr["MashHalaId"], dr["SyndicateId"], dr["SubCommitteId"], dr["sarfnumber"], dr["accsessmony"]);
                cmd2.ExecuteNonQuery();
                counter++;
            }
            con.Close();
            con2.Close();
        }
        public static string CheckForDofaaCreationErrors(int DofatSarfId, int SyndicateId)
        {
            string msg = string.Empty;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlCommand cmd = new SqlCommand(string.Format(@"SELECT COUNT(*) FROM vQry06 WHERE(SyndicateId = {0})", SyndicateId), con);
            int result = 0;
            try
            {
                con.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result != 0)
                    msg += string.Format(@"{0}  في اخطاء فرعيات مسئول الصرف", result) + Environment.NewLine;

                cmd.CommandText = string.Format(@"SELECT COUNT(*) FROM vQry07 WHERE SyndicateId = {0}", SyndicateId);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في ورثة تصرف لاعضاء لا تصرف", result) + Environment.NewLine;

                cmd.CommandText = string.Format(@"SELECT COUNT(*) FROM vQry08 WHERE SyndicateId = {0}", SyndicateId);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في خطاء في مسئول الورثة", result) + Environment.NewLine;

                cmd.CommandText = string.Format(@"SELECT COUNT(*) FROM vQry11 WHERE SyndicateId = {0} AND DofatSarfId = {1}", SyndicateId, DofatSarfId);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في الاستثنائات", result) + Environment.NewLine;

                cmd.CommandText = string.Format(@"SELECT COUNT(*) FROM vQry12 WHERE SyndicateId = {0}", SyndicateId);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في ورثة بدون مسئول صرف", result) + Environment.NewLine;

                cmd.CommandText = string.Format(@"SELECT COUNT(*) FROM vQry13 WHERE SyndicateId = {0}", SyndicateId);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في اخطاء في تقرير الورثة", result) + Environment.NewLine;

                cmd.CommandText = string.Format(@"SELECT COUNT(*) FROM vQry14 WHERE SyndicateId = {0}", SyndicateId);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في ورثة بأسماء فارغة", result) + Environment.NewLine;

                cmd.CommandText = string.Format(@"SELECT COUNT(*) FROM vQry15 WHERE SyndicateId = {0}", SyndicateId);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في اخطاء لجان الفرعيات الورثة", result) + Environment.NewLine;

                DataSources.dsQueriesTableAdapters.Qry09TableAdapter adp = new DataSources.dsQueriesTableAdapters.Qry09TableAdapter();
                result = adp.GetDataBySyndicateId(SyndicateId, DofatSarfId).Count;
                if (result != 0)
                    msg += string.Format(@"{0}  في ورثه ليس لهم استثناء", result) + Environment.NewLine;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
            con.Close();
            return msg;

        }
        public static string CheckForDofaaCreationErrorsLite(int DofatSarfId, int SyndicateId)
        {
            string msg = string.Empty;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlCommand cmd = new SqlCommand(string.Format(@"SELECT COUNT(*) FROM vQry06 WHERE(SyndicateId = {0})", SyndicateId), con);
            int result = 0;
            try
            {
                con.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في اخطاء فرعيات مسئول الصرف", result) + Environment.NewLine;

                cmd.CommandText = string.Format(@"SELECT COUNT(*) FROM vQry35 WHERE SyndicateId = {0}", SyndicateId);
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                    msg += string.Format(@"{0}  في مسئول صرف لا يصرف لورثه تصرف", result) + Environment.NewLine;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex;
            }
            con.Close();
            return msg;
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
            CompanyLogo, Eshtrak, Rasm FROM AppOptions");
        }
        public static DataTable SelectCDMashHala()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MashHalaId, MashHala FROM CDMashHala");
        }
        public static DataTable SelectCDsarfType()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT sarfTypeId, MashHalaId, sarfType, feasarf FROM CDsarfType");
        }
        public static DataTable SelectTBLDofatSarf()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT DofatSarfId, DofatSarf, DofatSarfDatefrom, DofatSarfDateto, remd, dofclosed FROM TBLDofatSarf");
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

        //Qry

        //Report

        #endregion
        #region -   Inserting   -
        //General
        public static bool PrepareBaseRole()
        {
            MainFrm frm = new MainFrm();
            DataSources.dsRetirementCenterTableAdapters.RoleDetialTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.RoleDetialTableAdapter();
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
                msgDlg.Show(ex.Message);
                throw ex;
            }
        }
        public static bool FillUserPrv()
        {
            DataSources.dsRetirementCenterTableAdapters.RoleDetialTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.RoleDetialTableAdapter();
            try
            {
                adp.FillByUserId(ds.RoleDetial, Program.UserInfo.UserId);
                return true;
            }
            catch (Exception ex)
            {
                msgDlg.Show(ex.Message);
                throw ex;
            }
        }
        public static void GetFormPriv(string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;

            if (FormName.Substring(FormName.Length - 3).ToLower() == "frm")
                FormName = FormName.Substring(0, FormName.Length - 3);
            FormName = Program.AppMenuName + FormName;

            foreach (DataSources.dsRetirementCenter.RoleDetialRow row in ds.RoleDetial.Rows)
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
        public static bool InsertCDsarfType(object MashHalaId, object sarfType, object feasarf)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@MashHalaId", SqlDbType.TinyInt) { Value = MashHalaId });
            cmd.Parameters.Add(new SqlParameter("@sarfType", SqlDbType.NVarChar) { Value = sarfType });
            cmd.Parameters.Add(new SqlParameter("@feasarf", SqlDbType.Float) { Value = feasarf });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CDsarfType (sarfTypeId, MashHalaId, sarfType, feasarf) VALUES 
                ((SELECT ISNULL(MAX(sarfTypeId) + 1, 1) FROM CDsarfType), @MashHalaId, @sarfType, @feasarf)";
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
        public static bool InsertTBLDofatSarf(object DofatSarf, object DofatSarfDatefrom, object DofatSarfDateto, object remd, object dofclosed)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@DofatSarf", SqlDbType.NVarChar) { Value = DofatSarf });
            cmd.Parameters.Add(new SqlParameter("@DofatSarfDatefrom", SqlDbType.Date) { Value = DofatSarfDatefrom });
            cmd.Parameters.Add(new SqlParameter("@DofatSarfDateto", SqlDbType.Date) { Value = DofatSarfDateto });
            cmd.Parameters.Add(new SqlParameter("@remd", SqlDbType.NVarChar) { Value = remd });
            cmd.Parameters.Add(new SqlParameter("@dofclosed", SqlDbType.Bit) { Value = dofclosed });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLDofatSarf (DofatSarfId, DofatSarf, DofatSarfDatefrom, DofatSarfDateto, remd, dofclosed) VALUES 
                ((SELECT ISNULL(MAX(DofatSarfId) + 1, 1) FROM TBLDofatSarf), @DofatSarf, @DofatSarfDatefrom, @DofatSarfDateto, @remd, @dofclosed)";
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
        public static bool UpdateCDsarfType(object sarfTypeId, object MashHalaId, object sarfType, object feasarf)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@sarfTypeId", SqlDbType.TinyInt) { Value = sarfTypeId });
            cmd.Parameters.Add(new SqlParameter("@MashHalaId", SqlDbType.TinyInt) { Value = MashHalaId });
            cmd.Parameters.Add(new SqlParameter("@sarfType", SqlDbType.NVarChar) { Value = sarfType });
            cmd.Parameters.Add(new SqlParameter("@feasarf", SqlDbType.Float) { Value = feasarf });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CDsarfType SET MashHalaId = @MashHalaId, sarfType = @sarfType,
                feasarf =@feasarf WHERE sarfTypeId = @sarfTypeId";
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
        public static bool UpdateTBLDofatSarf(object DofatSarfId, object DofatSarf, object DofatSarfDatefrom, object DofatSarfDateto, object remd, object dofclosed)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@DofatSarfId", SqlDbType.Int) { Value = DofatSarfId });
            cmd.Parameters.Add(new SqlParameter("@DofatSarf", SqlDbType.NVarChar) { Value = DofatSarf });
            cmd.Parameters.Add(new SqlParameter("@DofatSarfDatefrom", SqlDbType.Date) { Value = DofatSarfDatefrom });
            cmd.Parameters.Add(new SqlParameter("@DofatSarfDateto", SqlDbType.Date) { Value = DofatSarfDateto });
            cmd.Parameters.Add(new SqlParameter("@remd", SqlDbType.NVarChar) { Value = remd });
            cmd.Parameters.Add(new SqlParameter("@dofclosed", SqlDbType.Bit) { Value = dofclosed });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLDofatSarf SET DofatSarf = @DofatSarf, DofatSarfDatefrom = @DofatSarfDatefrom,
                DofatSarfDateto =@DofatSarfDateto, remd =@remd, dofclosed = @dofclosed WHERE DofatSarfId = @DofatSarfId";
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
        public static bool DeleteCDsarfType(object sarfTypeId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@sarfTypeId", SqlDbType.Int) { Value = sarfTypeId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CDsarfType WHERE (sarfTypeId = @sarfTypeId)";
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
        public static bool DeleteTBLDofatSarf(object DofatSarfId)
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
