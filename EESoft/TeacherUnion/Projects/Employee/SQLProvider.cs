using System;
using System.Data;
using System.Data.SqlClient;

namespace Employee
{
    public class SQLProvider
    {
        public static object AsaseSalaryId = null;

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
        public static DataTable SelectCDKashf()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EmpKashfId, EmpKashf FROM CDKashf");
        }
        public static DataTable SelectCD_AsaseSalary()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT AsaseSalaryId, AsaseSalary, school_allcode, AsaseDate, FromDate1, ToDate2, Alawa1, DateAlawa1, 
            DateAlawa2, Alawa2, DateAlawa3, Alawa3, DateAlawa4, Alawa4, Alawa5, DateAlawa5, MokafaDayes, MinAsaseMokafa, MinMokafa
            FROM CD_AsaseSalary ORDER BY AsaseSalaryId DESC");
        }
        public static DataTable SelectCDMonth()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT MonthId, MonthName FROM CDMonth");
        }
        //Data
        public static DataTable SelectTBL_Emp()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name,
            EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, nationaltyId, dyana_code, 
            MaritalStatusId, DepartmentId, EmpJobId, BIRTH_DATE, GENDER_ID, BIRTH_GOV, JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, 
            MOBILE_NO, JobDescriptionId, Work_Start_Date, End_Work_Date, qualId, SpecializationId, QualifiedPlaceId, Moaahel_Date, tagned_id, tameen_no, tameen_date1, 
            betaka_tameen, noview, orderreport, EMPPIC
            FROM TBL_Emp");
        }
        public static DataTable SelectTBLEmpKashf()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, EmpKashfId, EmpID AS org_EmpID, EmpKashfId AS org_EmpKashfId FROM TBLEmpKashf");
        }
        public static DataTable SelectTBLSalary()
        {
            return FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, AsaseSalaryId, MonthId, orderreport, asaseold, alawaold, basicsalary, esthkak26, esthkak24,
            alawa1, alawa2, alawa3, alawa4, alawa5, agtmaia, edafia, menha, badalat, sumethkak, estktaa26, estktaa24, estktaa14, estktaa11, solaf, 
            geza, sumestktaa, safy,
            EmpID AS org_EmpID, AsaseSalaryId AS org_AsaseSalaryId, MonthId AS org_MonthId
            FROM TBLSalary");
        }
        #endregion
        #region -   Inserting   -
        //Code
        public static bool InsertCD_AsaseSalary(object AsaseSalary, object school_allcode, object AsaseDate, object FromDate1, object ToDate2,
            object Alawa1, object DateAlawa1, object DateAlawa2, object Alawa2, object DateAlawa3, object Alawa3, object DateAlawa4, object Alawa4,
            object DateAlawa5, object Alawa5, object MokafaDayes, object MinAsaseMokafa, object MinMokafa)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@AsaseSalary", SqlDbType.NVarChar) { Value = AsaseSalary });
            cmd.Parameters.Add(new SqlParameter("@school_allcode", SqlDbType.NVarChar) { Value = school_allcode });
            cmd.Parameters.Add(new SqlParameter("@AsaseDate", SqlDbType.Date) { Value = AsaseDate });
            cmd.Parameters.Add(new SqlParameter("@FromDate1", SqlDbType.Date) { Value = FromDate1 });
            cmd.Parameters.Add(new SqlParameter("@ToDate2", SqlDbType.Date) { Value = ToDate2 });
            cmd.Parameters.Add(new SqlParameter("@Alawa1", SqlDbType.NVarChar) { Value = Alawa1 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa1", SqlDbType.Date) { Value = DateAlawa1 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa2", SqlDbType.Date) { Value = DateAlawa2 });
            cmd.Parameters.Add(new SqlParameter("@Alawa2", SqlDbType.NVarChar) { Value = Alawa2 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa3", SqlDbType.Date) { Value = DateAlawa3 });
            cmd.Parameters.Add(new SqlParameter("@Alawa3", SqlDbType.NVarChar) { Value = Alawa3 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa4", SqlDbType.Date) { Value = DateAlawa4 });
            cmd.Parameters.Add(new SqlParameter("@Alawa4", SqlDbType.NVarChar) { Value = Alawa4 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa5", SqlDbType.Date) { Value = DateAlawa5 });
            cmd.Parameters.Add(new SqlParameter("@Alawa5", SqlDbType.NVarChar) { Value = Alawa5 });
            cmd.Parameters.Add(new SqlParameter("@MokafaDayes", SqlDbType.Int) { Value = MokafaDayes });
            cmd.Parameters.Add(new SqlParameter("@MinAsaseMokafa", SqlDbType.Float) { Value = MinAsaseMokafa });
            cmd.Parameters.Add(new SqlParameter("@MinMokafa", SqlDbType.Float) { Value = MinMokafa });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO CD_AsaseSalary (AsaseSalaryId, AsaseSalary, school_allcode, AsaseDate, FromDate1, ToDate2, Alawa1, 
                DateAlawa1, DateAlawa2, Alawa2, DateAlawa3, Alawa3, DateAlawa4, Alawa4,  Alawa5, DateAlawa5, MokafaDayes, MinAsaseMokafa, MinMokafa)
                VALUES ((SELECT ISNULL(MAX(AsaseSalaryId) + 1, 1) FROM CD_AsaseSalary), @AsaseSalary, @school_allcode, @AsaseDate, @FromDate1, @ToDate2,
                @Alawa1, @DateAlawa1, @DateAlawa2, @Alawa2, @DateAlawa3, @Alawa3, @DateAlawa4, @Alawa4,  @Alawa5, @DateAlawa5, @MokafaDayes, @MinAsaseMokafa, 
                @MinMokafa)";
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
        public static bool InsertTBLEmpKashf(object EmpID, object EmpKashfId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = EmpID });
            cmd.Parameters.Add(new SqlParameter("@EmpKashfId", SqlDbType.TinyInt) { Value = EmpKashfId });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLEmpKashf (EmpID, EmpKashfId) VALUES (@EmpID, @EmpKashfId)";
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
        public static bool InsertTBLSalary(object EmpID, object AsaseSalaryId, object MonthId, object orderreport, object asaseold,
            object alawaold, object basicsalary, object esthkak26, object esthkak24, object alawa1, object alawa2, object alawa3, object alawa4,
            object alawa5, object agtmaia, object edafia, object menha, object badalat, object sumethkak, object estktaa26, object estktaa24, 
            object estktaa14, object estktaa11, object solaf, object geza, object sumestktaa, object safy)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = EmpID });
            cmd.Parameters.Add(new SqlParameter("@AsaseSalaryId", SqlDbType.Int) { Value = AsaseSalaryId });
            cmd.Parameters.Add(new SqlParameter("@MonthId", SqlDbType.TinyInt) { Value = MonthId });
            cmd.Parameters.Add(new SqlParameter("@orderreport", SqlDbType.Int) { Value = orderreport });
            cmd.Parameters.Add(new SqlParameter("@asaseold", SqlDbType.Float) { Value = asaseold });
            cmd.Parameters.Add(new SqlParameter("@alawaold", SqlDbType.Float) { Value = alawaold });
            cmd.Parameters.Add(new SqlParameter("@basicsalary", SqlDbType.Float) { Value = basicsalary });
            cmd.Parameters.Add(new SqlParameter("@esthkak26", SqlDbType.Float) { Value = esthkak26 });
            cmd.Parameters.Add(new SqlParameter("@esthkak24", SqlDbType.Float) { Value = esthkak24 });
            cmd.Parameters.Add(new SqlParameter("@alawa1", SqlDbType.Float) { Value = alawa1 });
            cmd.Parameters.Add(new SqlParameter("@alawa2", SqlDbType.Float) { Value = alawa2 });
            cmd.Parameters.Add(new SqlParameter("@alawa3", SqlDbType.Float) { Value = alawa3 });
            cmd.Parameters.Add(new SqlParameter("@alawa4", SqlDbType.Float) { Value = alawa4 });
            cmd.Parameters.Add(new SqlParameter("@alawa5", SqlDbType.Float) { Value = alawa5 });
            cmd.Parameters.Add(new SqlParameter("@agtmaia", SqlDbType.Float) { Value = agtmaia });
            cmd.Parameters.Add(new SqlParameter("@edafia", SqlDbType.Float) { Value = edafia });
            cmd.Parameters.Add(new SqlParameter("@menha", SqlDbType.Float) { Value = menha });
            cmd.Parameters.Add(new SqlParameter("@badalat", SqlDbType.Float) { Value = badalat });
            cmd.Parameters.Add(new SqlParameter("@sumethkak", SqlDbType.Float) { Value = sumethkak });
            cmd.Parameters.Add(new SqlParameter("@estktaa26", SqlDbType.Float) { Value = estktaa26 });
            cmd.Parameters.Add(new SqlParameter("@estktaa24", SqlDbType.Float) { Value = estktaa24 });
            cmd.Parameters.Add(new SqlParameter("@estktaa14", SqlDbType.Float) { Value = estktaa14 });
            cmd.Parameters.Add(new SqlParameter("@estktaa11", SqlDbType.Float) { Value = estktaa11 });
            cmd.Parameters.Add(new SqlParameter("@solaf", SqlDbType.Float) { Value = solaf });
            cmd.Parameters.Add(new SqlParameter("@geza", SqlDbType.Float) { Value = geza });
            cmd.Parameters.Add(new SqlParameter("@sumestktaa", SqlDbType.Float) { Value = sumestktaa });
            cmd.Parameters.Add(new SqlParameter("@safy", SqlDbType.Float) { Value = safy });

            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBLSalary (EmpID, AsaseSalaryId, MonthId, orderreport, asaseold, alawaold, basicsalary, esthkak26, 
                esthkak24, alawa1, alawa2, alawa3, alawa4, alawa5, agtmaia, edafia, menha, badalat, sumethkak, estktaa26, estktaa24, estktaa14, 
                estktaa11, solaf, geza, sumestktaa, safy)
                VALUES (@EmpID, @AsaseSalaryId, @MonthId, @orderreport, @asaseold, @alawaold, @basicsalary, @esthkak26, @esthkak24, @alawa1, @alawa2, 
                @alawa3, @alawa4, @alawa5, @agtmaia, @edafia, @menha, @badalat, @sumethkak, @estktaa26, @estktaa24, @estktaa14, @estktaa11, @solaf, 
                @geza, @sumestktaa, @safy)";
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
        public static bool UpdateCD_AsaseSalary(object AsaseSalaryId, object AsaseSalary, object school_allcode, object AsaseDate, object FromDate1, object ToDate2,
            object Alawa1, object DateAlawa1, object DateAlawa2, object Alawa2, object DateAlawa3, object Alawa3, object DateAlawa4, object Alawa4,
            object DateAlawa5, object Alawa5, object MokafaDayes, object MinAsaseMokafa, object MinMokafa)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@AsaseSalaryId", SqlDbType.Int) { Value = AsaseSalaryId });
            cmd.Parameters.Add(new SqlParameter("@AsaseSalary", SqlDbType.NVarChar) { Value = AsaseSalary });
            cmd.Parameters.Add(new SqlParameter("@school_allcode", SqlDbType.NVarChar) { Value = school_allcode });
            cmd.Parameters.Add(new SqlParameter("@AsaseDate", SqlDbType.Date) { Value = AsaseDate });
            cmd.Parameters.Add(new SqlParameter("@FromDate1", SqlDbType.Date) { Value = FromDate1 });
            cmd.Parameters.Add(new SqlParameter("@ToDate2", SqlDbType.Date) { Value = ToDate2 });
            cmd.Parameters.Add(new SqlParameter("@Alawa1", SqlDbType.NVarChar) { Value = Alawa1 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa1", SqlDbType.Date) { Value = DateAlawa1 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa2", SqlDbType.Date) { Value = DateAlawa2 });
            cmd.Parameters.Add(new SqlParameter("@Alawa2", SqlDbType.NVarChar) { Value = Alawa2 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa3", SqlDbType.Date) { Value = DateAlawa3 });
            cmd.Parameters.Add(new SqlParameter("@Alawa3", SqlDbType.NVarChar) { Value = Alawa3 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa4", SqlDbType.Date) { Value = DateAlawa4 });
            cmd.Parameters.Add(new SqlParameter("@Alawa4", SqlDbType.NVarChar) { Value = Alawa4 });
            cmd.Parameters.Add(new SqlParameter("@DateAlawa5", SqlDbType.Date) { Value = DateAlawa5 });
            cmd.Parameters.Add(new SqlParameter("@Alawa5", SqlDbType.NVarChar) { Value = Alawa5 });
            cmd.Parameters.Add(new SqlParameter("@MokafaDayes", SqlDbType.Int) { Value = MokafaDayes });
            cmd.Parameters.Add(new SqlParameter("@MinAsaseMokafa", SqlDbType.Float) { Value = MinAsaseMokafa });
            cmd.Parameters.Add(new SqlParameter("@MinMokafa", SqlDbType.Float) { Value = MinMokafa });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE CD_AsaseSalary SET AsaseSalary = @AsaseSalary, school_allcode = @school_allcode, AsaseDate = @AsaseDate, 
                FromDate1 = @FromDate1, ToDate2 = @ToDate2, Alawa1 = @Alawa1, DateAlawa1 = @DateAlawa1, DateAlawa2 = @DateAlawa2, Alawa2 = @Alawa2, 
                DateAlawa3 = @DateAlawa3, Alawa3 = @Alawa3, DateAlawa4 = @DateAlawa4, Alawa4 = @Alawa4, Alawa5 = @Alawa5, DateAlawa5 = @DateAlawa5, 
                MokafaDayes = @MokafaDayes, MinAsaseMokafa = @MinAsaseMokafa, MinMokafa = @MinMokafa
                WHERE AsaseSalaryId = @AsaseSalaryId";
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
        public static bool UpdateTBLEmpKashf(object EmpID, object EmpKashfId, object org_EmpID, object org_EmpKashfId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = EmpID });
            cmd.Parameters.Add(new SqlParameter("@EmpKashfId", SqlDbType.TinyInt) { Value = EmpKashfId });
            cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = org_EmpID });
            cmd.Parameters.Add(new SqlParameter("@org_EmpKashfId", SqlDbType.TinyInt) { Value = org_EmpKashfId });
            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLEmpKashf SET EmpID = @EmpID, EmpKashfId = @EmpKashfId
                WHERE EmpID = @org_EmpID AND EmpKashfId = @org_EmpKashfId";
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
        public static bool UpdateTBLSalary(object EmpID, object AsaseSalaryId, object MonthId, object orderreport, object asaseold,
            object alawaold, object basicsalary, object esthkak26, object esthkak24, object alawa1, object alawa2, object alawa3, object alawa4,
            object alawa5, object agtmaia, object edafia, object menha, object badalat, object sumethkak, object estktaa26, object estktaa24,
            object estktaa14, object estktaa11, object solaf, object geza, object sumestktaa, object safy,
            object org_EmpID, object org_AsaseSalaryId, object org_MonthId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = EmpID });
            cmd.Parameters.Add(new SqlParameter("@AsaseSalaryId", SqlDbType.Int) { Value = AsaseSalaryId });
            cmd.Parameters.Add(new SqlParameter("@MonthId", SqlDbType.TinyInt) { Value = MonthId });
            cmd.Parameters.Add(new SqlParameter("@orderreport", SqlDbType.Int) { Value = orderreport });
            cmd.Parameters.Add(new SqlParameter("@asaseold", SqlDbType.Float) { Value = asaseold });
            cmd.Parameters.Add(new SqlParameter("@alawaold", SqlDbType.Float) { Value = alawaold });
            cmd.Parameters.Add(new SqlParameter("@basicsalary", SqlDbType.Float) { Value = basicsalary });
            cmd.Parameters.Add(new SqlParameter("@esthkak26", SqlDbType.Float) { Value = esthkak26 });
            cmd.Parameters.Add(new SqlParameter("@esthkak24", SqlDbType.Float) { Value = esthkak24 });
            cmd.Parameters.Add(new SqlParameter("@alawa1", SqlDbType.Float) { Value = alawa1 });
            cmd.Parameters.Add(new SqlParameter("@alawa2", SqlDbType.Float) { Value = alawa2 });
            cmd.Parameters.Add(new SqlParameter("@alawa3", SqlDbType.Float) { Value = alawa3 });
            cmd.Parameters.Add(new SqlParameter("@alawa4", SqlDbType.Float) { Value = alawa4 });
            cmd.Parameters.Add(new SqlParameter("@alawa5", SqlDbType.Float) { Value = alawa5 });
            cmd.Parameters.Add(new SqlParameter("@agtmaia", SqlDbType.Float) { Value = agtmaia });
            cmd.Parameters.Add(new SqlParameter("@edafia", SqlDbType.Float) { Value = edafia });
            cmd.Parameters.Add(new SqlParameter("@menha", SqlDbType.Float) { Value = menha });
            cmd.Parameters.Add(new SqlParameter("@badalat", SqlDbType.Float) { Value = badalat });
            cmd.Parameters.Add(new SqlParameter("@sumethkak", SqlDbType.Float) { Value = sumethkak });
            cmd.Parameters.Add(new SqlParameter("@estktaa26", SqlDbType.Float) { Value = estktaa26 });
            cmd.Parameters.Add(new SqlParameter("@estktaa24", SqlDbType.Float) { Value = estktaa24 });
            cmd.Parameters.Add(new SqlParameter("@estktaa14", SqlDbType.Float) { Value = estktaa14 });
            cmd.Parameters.Add(new SqlParameter("@estktaa11", SqlDbType.Float) { Value = estktaa11 });
            cmd.Parameters.Add(new SqlParameter("@solaf", SqlDbType.Float) { Value = solaf });
            cmd.Parameters.Add(new SqlParameter("@geza", SqlDbType.Float) { Value = geza });
            cmd.Parameters.Add(new SqlParameter("@sumestktaa", SqlDbType.Float) { Value = sumestktaa });
            cmd.Parameters.Add(new SqlParameter("@safy", SqlDbType.Float) { Value = safy });

            cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = org_EmpID });
            cmd.Parameters.Add(new SqlParameter("@org_AsaseSalaryId", SqlDbType.Int) { Value = org_AsaseSalaryId });
            cmd.Parameters.Add(new SqlParameter("@org_MonthId", SqlDbType.TinyInt) { Value = org_MonthId });

            try
            {
                con.Open();
                cmd.CommandText = @"UPDATE TBLSalary SET EmpID = @EmpID, AsaseSalaryId = @AsaseSalaryId, MonthId = @MonthId, orderreport = @orderreport,
                asaseold = @asaseold, alawaold = @alawaold, basicsalary = @basicsalary, esthkak26 = @esthkak26, esthkak24 = @esthkak24, alawa1 = @alawa1,
                alawa2 = @alawa2, alawa3 = @alawa3, alawa4 = @alawa4, alawa5 = @alawa5, agtmaia = @agtmaia, edafia = @edafia, menha = @menha, badalat = @badalat,
                sumethkak = @sumethkak, estktaa26 = @estktaa26, estktaa24 = @estktaa24, estktaa14 = @estktaa14, estktaa11 = @estktaa11, solaf = @solaf, 
                geza = @geza, sumestktaa = @sumestktaa, safy = @safy 
                WHERE EmpID = @org_EmpID AND AsaseSalaryId = @org_AsaseSalaryId AND MonthId = @org_MonthId";
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
        public static bool DeleteCD_AsaseSalary(object AsaseSalaryId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@AsaseSalaryId", SqlDbType.Int) { Value = AsaseSalaryId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM CD_AsaseSalary WHERE (AsaseSalaryId = @AsaseSalaryId)";
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
        public static bool DeleteTBLEmpKashf(object EmpID, object EmpKashfId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = EmpID });
            cmd.Parameters.Add(new SqlParameter("@EmpKashfId", SqlDbType.TinyInt) { Value = EmpKashfId });
            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLEmpKashf WHERE EmpID = @EmpID AND EmpKashfId = @EmpKashfId";
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
        public static bool DeleteTBLSalary(object EmpID, object AsaseSalaryId, object MonthId)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = EmpID });
            cmd.Parameters.Add(new SqlParameter("@AsaseSalaryId", SqlDbType.Int) { Value = AsaseSalaryId });
            cmd.Parameters.Add(new SqlParameter("@MonthId", SqlDbType.TinyInt) { Value = MonthId });

            try
            {
                con.Open();
                cmd.CommandText = @"DELETE FROM TBLSalary WHERE EmpID = @EmpID AND AsaseSalaryId = @AsaseSalaryId AND MonthId = @MonthId";
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
