using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;
using System.Collections;

namespace SchoolWeeklyPeriods
{
    public partial class TBLTimeTableFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLTimeTableFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CDAlsofof:
                    repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select alsofof_code, alsofof_name, alsofof_name_e FROM CDAlsofof");
                    break;
                case CodeFrm.TableNames.CDEFasl:
                    repositoryItemGridLookUpEditfasl_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e FROM CDEFasl");
                    break;
                case CodeFrm.TableNames.CDDayname:
                    repositoryItemGridLookUpEditdaycode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    break;
                case CodeFrm.TableNames.CDAlhasas:
                    repositoryItemGridLookUpEdithasa_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e FROM CDAlhasas");
                    break;
                case CodeFrm.TableNames.CDPlace:
                    repositoryItemGridLookUpEditplacecd.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT placecd, place FROM gdw.CDPlace");
                    LuePlace.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT placecd, place FROM gdw.CDPlace");
                    LuePlaceShare.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT placecd, place FROM gdw.CDPlace");
                    break;
                case CodeFrm.TableNames.All:
                    repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select alsofof_code, alsofof_name, alsofof_name_e FROM CDAlsofof");
                    repositoryItemGridLookUpEditfasl_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e FROM CDEFasl");
                    repositoryItemGridLookUpEditdaycode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    repositoryItemGridLookUpEdithasa_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e FROM CDAlhasas");
                    repositoryItemGridLookUpEditplacecd.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT placecd, place FROM gdw.CDPlace");

                    DataTable dt = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
                    ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') AS emp_name
                    FROM TBL_Emp");
                    LUEEmp.Properties.DataSource = dt;
                    repositoryItemGridLookUpEditEmpID.DataSource = dt;
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "emp_name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";

                    repositoryItemGridLookUpEditSubjectId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e FROM CD_Subject");

                    LuePlace.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT placecd, place FROM gdw.CDPlace");
                    LuePlaceShare.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT placecd, place FROM gdw.CDPlace");

                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, EmpID, alsofof_code, fasl_code, SubjectId, placecd, daycode, hasa_code,
            asase_code AS org_asase_code, EmpID AS org_EmpID, alsofof_code AS org_alsofof_code, fasl_code AS org_fasl_code, SubjectId AS org_SubjectId, daycode AS org_daycode, hasa_code AS org_hasa_code
            From gdw.TBLTimeTable Where asase_code = " + FXFW.SqlDB.asase_code);
        }
        private void SharePeriodSaf()
        {
            DataTable dtAllSharePeriod = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, SubjectId, alsofof_code, fasl_code, asase_code, 
            (select twoh from CDSubjectWekly where alsofof_code = TBL_Share.alsofof_code  AND SubjectId = TBL_Share.SubjectId) as twoh
            from TBL_Share WHERE asase_code = " + FXFW.SqlDB.asase_code);
            DataTable dtEmpDays = FXFW.SqlDB.LoadDataTable(@"SELECT daycode FROM gdw.CD_HesaTime GROUP BY daycode");// Days available for Emp
            
            foreach (DataRow row in dtAllSharePeriod.Rows)
            {
                int Endless = 0;
                bool FristEmptyPeriod = false;
                while (AvailableSubject(row["SubjectId"].ToString(), row["EmpID"].ToString(), row["alsofof_code"].ToString(), row["fasl_code"].ToString()) > 0 && Endless < 4)
                {
                    if (Endless > 0)
                    {
                        FristEmptyPeriod = true;
                    }
                    List<string[]> SavedSubjectItems = new List<string[]>();//this to save what subject has been added

                    foreach (DataRow rowDays in dtEmpDays.Rows)// Days For Emp
                    {
                        bool itemsaved = false;
                        foreach (string[] item in SavedSubjectItems)
                        {
                            if (row["SubjectId"].ToString() == item[0] && row["alsofof_code"].ToString() == item[1])
                            {
                                itemsaved = true;
                                break;
                            }
                        }
                        if (itemsaved)
                            break;
                        if (AvailableSubject(row["SubjectId"].ToString(), row["EmpID"].ToString(), row["alsofof_code"].ToString(), row["fasl_code"].ToString()) <= 0)
                            break;
                        string[] EmpIDs = null;
                        foreach (DataRow EmpRow in dtAllSharePeriod.Rows)// get all empid for this subject+alsofof
                        {
                            if (EmpRow["SubjectId"].ToString() == row["SubjectId"].ToString() && EmpRow["alsofof_code"].ToString() == row["alsofof_code"].ToString())
                            {
                                if (EmpIDs == null)
                                    EmpIDs = new string[1];
                                else
                                    Array.Resize<string>(ref EmpIDs, EmpIDs.Length + 1);
                                EmpIDs[EmpIDs.Length - 1] = EmpRow["EmpID"].ToString();
                            }
                        }

                        //bool twoh;
                        if (!FXFW.SqlDB.IsNullOrEmpty(row["twoh"]))
                        {
                            //twoh = Convert.ToBoolean(row["twoh"]);
                            string[] hasa_code = Available2Period(rowDays["daycode"].ToString(), EmpIDs, row["SubjectId"].ToString(), FristEmptyPeriod, row["alsofof_code"].ToString(), row["fasl_code"].ToString());
                            if (hasa_code[0] == string.Empty)
                                continue;
                            else if (hasa_code[1] == string.Empty)
                            {
                                foreach (DataRow item in dtAllSharePeriod.Rows)
                                {
                                    if (item["SubjectId"].ToString() != row["SubjectId"].ToString() || item["alsofof_code"].ToString() != row["alsofof_code"].ToString())
                                        continue;
                                    SavePeriod(item["EmpID"].ToString(), rowDays["daycode"].ToString(), hasa_code[0], item["alsofof_code"].ToString(), item["fasl_code"].ToString(), item["SubjectId"].ToString(), LuePlaceShare.EditValue.ToString());
                                    string[] add = new string[2]; add[0] = row["SubjectId"].ToString(); add[1] = row["alsofof_code"].ToString();
                                    SavedSubjectItems.Add(add);
                                }
                            }
                            else
                            {
                                foreach (DataRow item in dtAllSharePeriod.Rows)
                                {
                                    if (item["SubjectId"].ToString() != row["SubjectId"].ToString() || item["alsofof_code"].ToString() != row["alsofof_code"].ToString())
                                        continue;
                                    SavePeriod(item["EmpID"].ToString(), rowDays["daycode"].ToString(), hasa_code[0], item["alsofof_code"].ToString(), item["fasl_code"].ToString(), item["SubjectId"].ToString(), LuePlaceShare.EditValue.ToString());
                                    SavePeriod(item["EmpID"].ToString(), rowDays["daycode"].ToString(), hasa_code[1], item["alsofof_code"].ToString(), item["fasl_code"].ToString(), item["SubjectId"].ToString(), LuePlaceShare.EditValue.ToString());
                                    string[] add = new string[2]; add[0] = row["SubjectId"].ToString(); add[1] = row["alsofof_code"].ToString();
                                    SavedSubjectItems.Add(add);
                                }
                            }
                        }
                        else
                        {
                            //twoh = false;
                            string hasa_code = AvailablePeriod(rowDays["daycode"].ToString(), EmpIDs, row["SubjectId"].ToString(), FristEmptyPeriod, row["alsofof_code"].ToString(), row["fasl_code"].ToString());
                            if (hasa_code == string.Empty)
                                continue;
                            foreach (DataRow item in dtAllSharePeriod.Rows)
                            {
                                if (item["SubjectId"].ToString() != row["SubjectId"].ToString() || item["alsofof_code"].ToString() != row["alsofof_code"].ToString())
                                    continue;
                                SavePeriod(item["EmpID"].ToString(), rowDays["daycode"].ToString(), hasa_code, item["alsofof_code"].ToString(), item["fasl_code"].ToString(), item["SubjectId"].ToString(), LuePlaceShare.EditValue.ToString());
                                string[] add = new string[2]; add[0] = row["SubjectId"].ToString(); add[1] = row["alsofof_code"].ToString();
                                SavedSubjectItems.Add(add);
                            }
                        }
                        Application.DoEvents();
                    }
                    Endless++;
                }
            }
            LoadGrid();
        }
        private void SharePeriodFasl()
        {
            DataTable dtAllSharePeriod = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, SubjectId, alsofof_code, fasl_code, asase_code, 
            (select twoh from CDSubjectWekly where alsofof_code = TBL_Share.alsofof_code  AND SubjectId = TBL_Share.SubjectId) as twoh
            from TBL_Share WHERE asase_code = " + FXFW.SqlDB.asase_code);
            DataTable dtEmpDays = FXFW.SqlDB.LoadDataTable(@"SELECT daycode FROM gdw.CD_HesaTime GROUP BY daycode");// Days available for Emp

            foreach (DataRow row in dtAllSharePeriod.Rows)
            {
                int Endless = 0;
                bool FristEmptyPeriod = false;
                while (AvailableSubject(row["SubjectId"].ToString(), row["EmpID"].ToString(), row["alsofof_code"].ToString(), row["fasl_code"].ToString()) > 0 && Endless < 4)
                {
                    if (Endless > 0)
                    {
                        FristEmptyPeriod = true;
                    }
                    List<string[]> SavedSubjectItems = new List<string[]>();//this to save what subject has been added
                    
                    foreach (DataRow rowDays in dtEmpDays.Rows)// Days For Emp
                    {
                        bool itemsaved = false;
                        foreach (string[] item in SavedSubjectItems)
                        {
                            if (row["SubjectId"].ToString() == item[0])
                            {
                                itemsaved = true;
                                break;
                            }
                        }
                        if (itemsaved)
                            break;
                        if (AvailableSubject(row["SubjectId"].ToString(), row["EmpID"].ToString(), row["alsofof_code"].ToString(), row["fasl_code"].ToString()) <= 0)
                            break;
                        //bool twoh;
                        if (!FXFW.SqlDB.IsNullOrEmpty(row["twoh"]))
                        {
                            //twoh = Convert.ToBoolean(row["twoh"]);
                            string[] hasa_code = Available2Period(rowDays["daycode"].ToString(), row["EmpID"].ToString(), row["SubjectId"].ToString(), FristEmptyPeriod, row["alsofof_code"].ToString(), row["fasl_code"].ToString());
                            if (hasa_code[0] == string.Empty)
                                continue;
                            else if (hasa_code[1] == string.Empty)
                            {
                                foreach (DataRow item in dtAllSharePeriod.Rows)
                                {
                                    if (item["SubjectId"].ToString() != row["SubjectId"].ToString() || item["alsofof_code"].ToString() != row["alsofof_code"].ToString() || item["fasl_code"].ToString() != row["fasl_code"].ToString())
                                        continue;
                                    SavePeriod(item["EmpID"].ToString(), rowDays["daycode"].ToString(), hasa_code[0], item["alsofof_code"].ToString(), item["fasl_code"].ToString(), item["SubjectId"].ToString(), LuePlaceShare.EditValue.ToString());
                                    string[] add = new string[2]; add[0] = row["SubjectId"].ToString(); add[1] = row["alsofof_code"].ToString();
                                    SavedSubjectItems.Add(add);
                                }
                            }
                            else
                            {
                                foreach (DataRow item in dtAllSharePeriod.Rows)
                                {
                                    if (item["SubjectId"].ToString() != row["SubjectId"].ToString() || item["alsofof_code"].ToString() != row["alsofof_code"].ToString() || item["fasl_code"].ToString() != row["fasl_code"].ToString())
                                        continue;
                                    SavePeriod(item["EmpID"].ToString(), rowDays["daycode"].ToString(), hasa_code[0], item["alsofof_code"].ToString(), item["fasl_code"].ToString(), item["SubjectId"].ToString(), LuePlaceShare.EditValue.ToString());
                                    SavePeriod(item["EmpID"].ToString(), rowDays["daycode"].ToString(), hasa_code[1], item["alsofof_code"].ToString(), item["fasl_code"].ToString(), item["SubjectId"].ToString(), LuePlaceShare.EditValue.ToString());
                                    string[] add = new string[2]; add[0] = row["SubjectId"].ToString(); add[1] = row["alsofof_code"].ToString();
                                    SavedSubjectItems.Add(add);
                                }
                            }
                        }
                        else
                        {
                            //twoh = false;
                            string hasa_code = AvailablePeriod(rowDays["daycode"].ToString(), row["EmpID"].ToString(), row["SubjectId"].ToString(), FristEmptyPeriod, row["alsofof_code"].ToString(), row["fasl_code"].ToString());
                            if (hasa_code == string.Empty)
                                continue;
                            foreach (DataRow item in dtAllSharePeriod.Rows)
                            {
                                if (item["SubjectId"].ToString() != row["SubjectId"].ToString() || item["alsofof_code"].ToString() != row["alsofof_code"].ToString() || item["fasl_code"].ToString() != row["fasl_code"].ToString())
                                    continue;
                                SavePeriod(item["EmpID"].ToString(), rowDays["daycode"].ToString(), hasa_code, item["alsofof_code"].ToString(), item["fasl_code"].ToString(), item["SubjectId"].ToString(), LuePlaceShare.EditValue.ToString());
                                string[] add = new string[2]; add[0] = row["SubjectId"].ToString(); add[1] = row["alsofof_code"].ToString();
                                SavedSubjectItems.Add(add);
                            }
                        }
                        Application.DoEvents();
                    }
                    Endless++;
                }
            }
            LoadGrid();
        }
        private bool PeriodBusy(string EmpID, string hasa_code)
        { 
            DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT EmpID FROM gdw.TBLTimeTable
            WHERE asase_code = {0} AND EmpID = {1} AND hasa_code = {2}", FXFW.SqlDB.asase_code, EmpID, hasa_code));
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private bool PeriodBusy(string[] EmpID, string hasa_code)
        {
            string EmpExp = string.Empty;
            for (int i = 0; i < EmpID.Length; i++)
            {
                EmpExp += "EmpID = " + EmpID[i];
                if (i + 1 < EmpID.Length)
                    EmpExp += " OR ";
            }

            DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT EmpID FROM gdw.TBLTimeTable
            WHERE asase_code = {0} AND ({1}) AND hasa_code = {2}", FXFW.SqlDB.asase_code, EmpExp, hasa_code));
            if (dt.Rows.Count >= EmpID.Length)
                return true;
            else
                return false;
        }
        private bool SavePeriod(string EmpID, string daycode, string hasa_code, string alsofof_code, string fasl_code, string SubjectId, object placecd)
        {
            bool ReturnMe = false;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = FXFW.SqlDB.asase_code });
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = EmpID });
            cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt) { Value = alsofof_code });
            cmd.Parameters.Add(new SqlParameter("@fasl_code", SqlDbType.TinyInt) { Value = fasl_code });
            cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = SubjectId });
            cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = daycode });
            cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = hasa_code });
            cmd.Parameters.Add(new SqlParameter("@placecd", SqlDbType.TinyInt) { Value = placecd });
            try
            {
                cmd.CommandText = @"INSERT INTO gdw.TBLTimeTable (asase_code, EmpID, alsofof_code, fasl_code, SubjectId, daycode, hasa_code, placecd)
                VALUES (@asase_code, @EmpID, @alsofof_code, @fasl_code, @SubjectId, @daycode, @hasa_code, @placecd)";
                con.Open();
                cmd.ExecuteNonQuery();
                ReturnMe = true;
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            return ReturnMe;
        }
        private string AvailablePeriod(string daycode, string EmpID, string SubjectId, bool FristEmptyPeriod, string alsofof_code, string fasl_code)
        {
            string ReturnMe = string.Empty;

            DataTable dtAllPeriod = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT hasa_code from TBL_Priority Where SubjectId = {0} AND
            NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {1} AND daycode = {2} AND alsofof_code = {3} AND fasl_code = {4} AND hasa_code = TBL_Priority.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From TBLTeacherNoDays Where daycode = {2} AND EmpID = {5} AND hasa_code = TBL_Priority.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {1} AND daycode = {2} AND hasa_code = TBL_Priority.hasa_code AND EmpID = {5})"
            , SubjectId, FXFW.SqlDB.asase_code, daycode, alsofof_code, fasl_code, EmpID));
            using (DataTable dtAllPeriodEXT = FXFW.SqlDB.LoadDataTable(string.Format(@"Select hasa_code From gdw.CD_HesaTime Where daycode = {0} AND 
            marhala_code = (SELECT marhala_code FROM dbo.CDAlsofof WHERE alsofof_code = {1}) AND 
            NOT EXISTS(SELECT hasa_code FROM TBL_Priority Where SubjectId = {2} AND hasa_code = gdw.CD_HesaTime.hasa_code)                 
            AND
            NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {3} AND daycode = {0} AND alsofof_code = {1} AND fasl_code = {4} AND hasa_code = gdw.CD_HesaTime.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From TBLTeacherNoDays Where daycode = {0} AND EmpID = {5} AND hasa_code = gdw.CD_HesaTime.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {3} AND daycode = {0} AND hasa_code = gdw.CD_HesaTime.hasa_code AND EmpID = {5})"
            , daycode, alsofof_code, SubjectId, FXFW.SqlDB.asase_code, fasl_code, EmpID)))
            {
                foreach (DataRow item in dtAllPeriodEXT.Rows)
                    dtAllPeriod.ImportRow(item);
            }

            for (int i = 0; i < dtAllPeriod.Rows.Count; i++)
            {
                int  hasa_code = (int)dtAllPeriod.Rows[i]["hasa_code"];
                if (FristEmptyPeriod == false && dtAllPeriod.Rows.Count > 2 && hasa_code != 1)
                {
                    if (PeriodBusy(EmpID, (hasa_code - 1).ToString()))
                    {
                        continue;
                    }
                    ReturnMe = dtAllPeriod.Rows[i]["hasa_code"].ToString();
                    break;
                }
                else
                {
                    ReturnMe = dtAllPeriod.Rows[i]["hasa_code"].ToString();
                    break;
                }
            }
            return ReturnMe;
        }
        private string AvailablePeriod(string daycode, string[] EmpID, string SubjectId, bool FristEmptyPeriod, string alsofof_code, string fasl_code)
        {
            string ReturnMe = string.Empty;
            string EmpExp = string.Empty;
            for (int i = 0; i < EmpID.Length; i++)
			{
                EmpExp += "EmpID = " + EmpID[i];
                if (i + 1 < EmpID.Length)
                    EmpExp += " OR ";
			}
            

            DataTable dtAllPeriod = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT hasa_code from TBL_Priority Where SubjectId = {0} AND
            NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {1} AND daycode = {2} AND alsofof_code = {3} AND fasl_code = {4} AND hasa_code = TBL_Priority.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From TBLTeacherNoDays Where daycode = {2} AND ({5}) AND hasa_code = TBL_Priority.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {1} AND daycode = {2} AND hasa_code = TBL_Priority.hasa_code AND ({5}))"
            , SubjectId, FXFW.SqlDB.asase_code, daycode, alsofof_code, fasl_code, EmpID));
            using (DataTable dtAllPeriodEXT = FXFW.SqlDB.LoadDataTable(string.Format(@"Select hasa_code From gdw.CD_HesaTime Where daycode = {0} AND 
            marhala_code = (SELECT marhala_code FROM dbo.CDAlsofof WHERE alsofof_code = {1}) AND 
            NOT EXISTS(SELECT hasa_code FROM TBL_Priority Where SubjectId = {2} AND hasa_code = gdw.CD_HesaTime.hasa_code)                 
            AND
            NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {3} AND daycode = {0} AND alsofof_code = {1} AND fasl_code = {4} AND hasa_code = gdw.CD_HesaTime.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From TBLTeacherNoDays Where daycode = {0} AND ({5}) AND hasa_code = gdw.CD_HesaTime.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {3} AND daycode = {0} AND hasa_code = gdw.CD_HesaTime.hasa_code AND ({5}))"
            , daycode, alsofof_code, SubjectId, FXFW.SqlDB.asase_code, fasl_code, EmpExp)))
            {
                foreach (DataRow item in dtAllPeriodEXT.Rows)
                    dtAllPeriod.ImportRow(item);
            }

            for (int i = 0; i < dtAllPeriod.Rows.Count; i++)
            {
                int hasa_code = (int)dtAllPeriod.Rows[i]["hasa_code"];
                if (FristEmptyPeriod == false && dtAllPeriod.Rows.Count > 2 && hasa_code != 1)
                {
                    if (PeriodBusy(EmpID, (hasa_code - 1).ToString()))
                    {
                        continue;
                    }
                    ReturnMe = dtAllPeriod.Rows[i]["hasa_code"].ToString();
                    break;
                }
                else
                {
                    ReturnMe = dtAllPeriod.Rows[i]["hasa_code"].ToString();
                    break;
                }
            }
            return ReturnMe;
        }
        private string[] Available2Period(string daycode, string EmpID, string SubjectId, bool FristEmptyPeriod, string alsofof_code, string fasl_code)
        {
            string[] ReturnMe = new string[2]; ReturnMe[0] = string.Empty; ReturnMe[1] = string.Empty;

            DataTable dtAllPeriod = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT hasa_code from TBL_Priority Where SubjectId = {0} AND
            NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {1} AND daycode = {2} AND alsofof_code = {3} AND fasl_code = {4} AND hasa_code = TBL_Priority.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From TBLTeacherNoDays Where daycode = {2} AND EmpID = {5} AND hasa_code = TBL_Priority.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {1} AND daycode = {2} AND hasa_code = TBL_Priority.hasa_code AND EmpID = {5})"
            , SubjectId, FXFW.SqlDB.asase_code, daycode, alsofof_code, fasl_code, EmpID));
            using (DataTable dtAllPeriodEXT = FXFW.SqlDB.LoadDataTable(string.Format(@"Select hasa_code From gdw.CD_HesaTime Where daycode = {0} AND 
            marhala_code = (SELECT marhala_code FROM dbo.CDAlsofof WHERE alsofof_code = {1}) AND 
            NOT EXISTS(SELECT hasa_code FROM TBL_Priority Where SubjectId = {2} AND hasa_code = gdw.CD_HesaTime.hasa_code)                 
            AND
            NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {3} AND daycode = {0} AND alsofof_code = {1} AND fasl_code = {4} AND hasa_code = gdw.CD_HesaTime.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From TBLTeacherNoDays Where daycode = {0} AND EmpID = {5} AND hasa_code = gdw.CD_HesaTime.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {3} AND daycode = {0} AND hasa_code = gdw.CD_HesaTime.hasa_code AND EmpID = {5})"
            , daycode, alsofof_code, SubjectId, FXFW.SqlDB.asase_code, fasl_code, EmpID)))
            {
                foreach (DataRow item in dtAllPeriodEXT.Rows)
                    dtAllPeriod.ImportRow(item);
            }
            for (int i = 0; i < dtAllPeriod.Rows.Count - 1; i++)
            {
                if (i + 1 > dtAllPeriod.Rows.Count)
                {
                    ReturnMe[0] = dtAllPeriod.Rows[i]["hasa_code"].ToString();
                    break;
                }
                else
                {
                    if (Convert.ToInt16(dtAllPeriod.Rows[i + 1]["hasa_code"].ToString()) == Convert.ToInt16(dtAllPeriod.Rows[i]["hasa_code"].ToString()) + 1)
                    {
                        // chech if the hasa - 1 is busy for this emp
                        int hasa_code = (int)dtAllPeriod.Rows[i]["hasa_code"];
                        if (FristEmptyPeriod == false && hasa_code != 1)
                        {
                            if (PeriodBusy(EmpID, (hasa_code - 1).ToString()))
                                continue;
                        }

                        ReturnMe[0] = dtAllPeriod.Rows[i]["hasa_code"].ToString();
                        ReturnMe[1] = dtAllPeriod.Rows[i + 1]["hasa_code"].ToString();
                        break;
                    }
                }
            }
            if (ReturnMe[0] == string.Empty)
            {
                foreach (DataRow rowAll in dtAllPeriod.Rows)
                {
                    ReturnMe[0] = rowAll["hasa_code"].ToString();
                    break;
                }
            }
            return ReturnMe;
        }
        private string[] Available2Period(string daycode, string[] EmpID, string SubjectId, bool FristEmptyPeriod, string alsofof_code, string fasl_code)
        {
            string[] ReturnMe = new string[2]; ReturnMe[0] = string.Empty; ReturnMe[1] = string.Empty;

             string EmpExp = string.Empty;
            for (int i = 0; i < EmpID.Length; i++)
			{
                EmpExp += "EmpID = " + EmpID[i];
                if (i + 1 < EmpID.Length)
                    EmpExp += " OR ";
			}

            DataTable dtAllPeriod = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT hasa_code from TBL_Priority Where SubjectId = {0} AND
            NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {1} AND daycode = {2} AND alsofof_code = {3} AND fasl_code = {4} AND hasa_code = TBL_Priority.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From TBLTeacherNoDays Where daycode = {2} AND ({5}) AND hasa_code = TBL_Priority.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {1} AND daycode = {2} AND hasa_code = TBL_Priority.hasa_code AND ({5}))"
            , SubjectId, FXFW.SqlDB.asase_code, daycode, alsofof_code, fasl_code, EmpExp));
            using (DataTable dtAllPeriodEXT = FXFW.SqlDB.LoadDataTable(string.Format(@"Select hasa_code From gdw.CD_HesaTime Where daycode = {0} AND 
            marhala_code = (SELECT marhala_code FROM dbo.CDAlsofof WHERE alsofof_code = {1}) AND 
            NOT EXISTS(SELECT hasa_code FROM TBL_Priority Where SubjectId = {2} AND hasa_code = gdw.CD_HesaTime.hasa_code)                 
            AND
            NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {3} AND daycode = {0} AND alsofof_code = {1} AND fasl_code = {4} AND hasa_code = gdw.CD_HesaTime.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From TBLTeacherNoDays Where daycode = {0} AND ({5}) AND hasa_code = gdw.CD_HesaTime.hasa_code)
            AND NOT EXISTS(
            Select hasa_code From gdw.TBLTimeTable Where asase_code = {3} AND daycode = {0} AND hasa_code = gdw.CD_HesaTime.hasa_code AND ({5}))"
            , daycode, alsofof_code, SubjectId, FXFW.SqlDB.asase_code, fasl_code, EmpExp)))
            {
                foreach (DataRow item in dtAllPeriodEXT.Rows)
                    dtAllPeriod.ImportRow(item);
            }
            for (int i = 0; i < dtAllPeriod.Rows.Count - 1; i++)
            {
                if (i + 1 > dtAllPeriod.Rows.Count)
                {
                    ReturnMe[0] = dtAllPeriod.Rows[i]["hasa_code"].ToString();
                    break;
                }
                else
                {
                    if (Convert.ToInt16(dtAllPeriod.Rows[i + 1]["hasa_code"].ToString()) == Convert.ToInt16(dtAllPeriod.Rows[i]["hasa_code"].ToString()) + 1)
                    {
                        // chech if the hasa - 1 is busy for this emp
                        int hasa_code = (int)dtAllPeriod.Rows[i]["hasa_code"];
                        if (FristEmptyPeriod == false && hasa_code != 1)
                        {
                            if (PeriodBusy(EmpID, (hasa_code - 1).ToString()))
                                continue;
                        }

                        ReturnMe[0] = dtAllPeriod.Rows[i]["hasa_code"].ToString();
                        ReturnMe[1] = dtAllPeriod.Rows[i + 1]["hasa_code"].ToString();
                        break;
                    }
                }
            }
            if (ReturnMe[0] == string.Empty)
            {
                foreach (DataRow rowAll in dtAllPeriod.Rows)
                {
                    ReturnMe[0] = rowAll["hasa_code"].ToString();
                    break;
                }
            }
            return ReturnMe;
        }
        private int AvailableSubject(string SubjectId, string EmpID, string alsofof_code, string fasl_code)
        {
            //Available Period for Subject
            DataTable dtAllPeriod = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT ISNULL((SELECT ISNULL(hesasno, 0) FROM CDSubjectWekly WHERE alsofof_code = {0} AND SubjectId = {1})
            - (SELECT ISNULL(COUNT(*), 0) FROM gdw.TBLTimeTable WHERE asase_code = {2} AND alsofof_code = {0} AND SubjectId = {1} AND fasl_code = {3}), 0) 
            AS Remaning", alsofof_code, SubjectId, FXFW.SqlDB.asase_code, fasl_code));
            if (Convert.ToInt16(dtAllPeriod.Rows[0][0].ToString()) <= 0)
                return 0;
            else
                return Convert.ToInt16(dtAllPeriod.Rows[0][0].ToString());
        }
        private int MaxPeriodPerDay(string EmpID, int daysCount)
        {
            //return how much period as a mix period for this Emp
            int SumEmpPeriodShouldHave = (int)FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT ISNULL(sum(x.PeriodCount),0) AS PeriodCount
            From
            (
            SELECT 
            (SELECT hesasno FROM CDSubjectWekly where alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId) AS PeriodCount
            From gdw.TBLTeachersPlan
            WHERE asase_code = {0} AND EmpID = {1}
            ) x", FXFW.SqlDB.asase_code, EmpID)).Rows[0][0];
            int WeekDaysCount = daysCount;
            return SumEmpPeriodShouldHave / WeekDaysCount;
        }
        private int EmpAddedPeriods(string EmpID)
        {
            return (int)FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT
            (
            SELECT ISNULL(sum(x.PeriodCount),0) AS PeriodCount
            From
            (
            SELECT 
            (SELECT hesasno FROM CDSubjectWekly where alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId) AS PeriodCount
            From gdw.TBLTeachersPlan
            WHERE asase_code = {0} AND EmpID = {1}
            ) x 
            )
            -
            (
            SELECT COUNT(EmpID) FROM gdw.TBLTimeTable
            WHERE asase_code = {0} AND EmpID = {1}
            )", FXFW.SqlDB.asase_code, EmpID)).Rows[0][0];
        }
        private bool AddEmp(string EmpID)
        {
            bool ReturnMe = true;
            DataTable dtEmpDays = FXFW.SqlDB.LoadDataTable(@"SELECT daycode FROM gdw.CD_HesaTime GROUP BY daycode");// Days available for Emp
            
            int MaxDayPeriod = MaxPeriodPerDay(EmpID, dtEmpDays.Rows.Count);

            int PeriodRemain = EmpAddedPeriods(EmpID);
            int Endless = 0;
            bool FristEmptyPeriod = false;//For check if this is the 2nd loop for this subject, so try 2 add period at the 1st free place
            while (PeriodRemain > 0)
            {
                if (Endless > 2)
                    FristEmptyPeriod = true;
                if (Endless > 4)
                {
                    ReturnMe = false;
                    break;
                }
                DataTable dtSubject = FXFW.SqlDB.LoadDataTable(string.Format(@"Select SubjectId, alsofof_code, fasl_code,
                (select twoh from CDSubjectWekly where alsofof_code = gdw.TBLTeachersPlan.alsofof_code  AND SubjectId = gdw.TBLTeachersPlan.SubjectId) as twoh,
                ISNULL((SELECT ISNULL(hesasno, 0) FROM CDSubjectWekly WHERE alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId)
                -
                (SELECT ISNULL(COUNT(*), 0) FROM gdw.TBLTimeTable WHERE asase_code = gdw.TBLTeachersPlan.asase_code AND EmpID = gdw.TBLTeachersPlan.EmpID AND alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId AND fasl_code = gdw.TBLTeachersPlan.fasl_code), 0) 
                AS Remaning
                From gdw.TBLTeachersPlan 
                Where EmpID = {0} AND asase_code = {1} order by twoh desc", EmpID, FXFW.SqlDB.asase_code));// Emp Subjects

                foreach (DataRow rowSubject in dtSubject.Rows)
                {
                    int SubjectPeriodRemain = (int)rowSubject["Remaning"];
                        foreach (DataRow rowDays in dtEmpDays.Rows)// Days For Emp
                        {
                            if (FristEmptyPeriod == false)
                            {
                                //check if this emp have maxium period for this day or not
                                int EmpDaySavedPeriod = (int)FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT COUNT(*) FROM gdw.TBLTimeTable WHERE asase_code = {0} AND EmpID = {1} AND daycode = {2}",
                                    FXFW.SqlDB.asase_code, EmpID, rowDays["daycode"])).Rows[0][0];
                                if (MaxDayPeriod + 1 < EmpDaySavedPeriod)
                                    continue;// this mean that this emp have the max period for this day
                            }
                            if (SubjectPeriodRemain <= 0)
                                break;
                            bool twoh;
                            if (!FXFW.SqlDB.IsNullOrEmpty(rowSubject["twoh"]))
                                twoh = Convert.ToBoolean(rowSubject["twoh"]);
                            else
                                twoh = false;

                            if (twoh && SubjectPeriodRemain >= 2)
                            {
                                string[] hasa_code = Available2Period(rowDays["daycode"].ToString(), EmpID, rowSubject["SubjectId"].ToString(), FristEmptyPeriod, rowSubject["alsofof_code"].ToString(), rowSubject["fasl_code"].ToString());
                                if (hasa_code[0] != string.Empty)
                                {
                                    SavePeriod(EmpID, rowDays["daycode"].ToString(), hasa_code[0], rowSubject["alsofof_code"].ToString(), rowSubject["fasl_code"].ToString(), rowSubject["SubjectId"].ToString(), LuePlace.EditValue.ToString());
                                    SubjectPeriodRemain--;
                                }
                                if (hasa_code[1] != string.Empty)
                                {
                                    SavePeriod(EmpID, rowDays["daycode"].ToString(), hasa_code[1], rowSubject["alsofof_code"].ToString(), rowSubject["fasl_code"].ToString(), rowSubject["SubjectId"].ToString(), LuePlace.EditValue.ToString());
                                    SubjectPeriodRemain--;
                                }
                            }
                            else
                            {
                                string hasa_code = AvailablePeriod(rowDays["daycode"].ToString(), EmpID, rowSubject["SubjectId"].ToString(), FristEmptyPeriod, rowSubject["alsofof_code"].ToString(), rowSubject["fasl_code"].ToString());
                                if (hasa_code == string.Empty)
                                    continue;
                                SavePeriod(EmpID, rowDays["daycode"].ToString(), hasa_code, rowSubject["alsofof_code"].ToString(), rowSubject["fasl_code"].ToString(), rowSubject["SubjectId"].ToString(), LuePlace.EditValue.ToString());
                                SubjectPeriodRemain--;
                            }
                            Application.DoEvents();
                        
                        }
                }
                Endless++;
            }
            return ReturnMe;
        }
        private static bool DeleteEmp(string EmpID)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"DELETE FROM gdw.TBLTimeTable 
                WHERE (asase_code = @org_asase_code) AND (EmpID = @org_EmpID)";
                cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = FXFW.SqlDB.asase_code });
                cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = EmpID });
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private static bool DeletePeriod(string asase_code, string EmpID, string daycode, string hasa_code, string alsofof_code, string fasl_code, string SubjectId, string placecd)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"DELETE FROM gdw.TBLTimeTable 
                WHERE (asase_code = @asase_code) AND (EmpID = @EmpID) AND (daycode = @daycode) AND (hasa_code = @hasa_code) AND 
                (alsofof_code = @alsofof_code) AND (fasl_code = @fasl_code) AND (SubjectId = @SubjectId) AND (placecd = @placecd)";
                cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = asase_code });
                cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = EmpID });

                cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = daycode });
                cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = hasa_code });
                cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt) { Value = alsofof_code });
                cmd.Parameters.Add(new SqlParameter("@fasl_code", SqlDbType.TinyInt) { Value = fasl_code });
                cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = SubjectId });
                cmd.Parameters.Add(new SqlParameter("@placecd", SqlDbType.TinyInt) { Value = placecd });
                con.Open();
                int rowcount = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private bool ReplacePeriod(string asase_code1, string EmpID1, string daycode1, string hasa_code1, string alsofof_code1, string fasl_code1, string SubjectId1, string placecd1,
            string asase_code2, string EmpID2, string daycode2, string hasa_code2, string alsofof_code2, string fasl_code2, string SubjectId2, string placecd2)
        {
            if (!DeletePeriod(asase_code1, EmpID1, daycode1, hasa_code1, alsofof_code1, fasl_code1, SubjectId1, placecd1) || !DeletePeriod(asase_code2, EmpID2, daycode2, hasa_code2, alsofof_code2, fasl_code2, SubjectId2, placecd2))
            {
                SavePeriod(EmpID1, daycode1, hasa_code1, alsofof_code1, fasl_code1, SubjectId1, placecd1);
                return false;
            }
            if (SavePeriod(EmpID2, daycode1, hasa_code1, alsofof_code1, fasl_code1, SubjectId2, placecd2) && SavePeriod(EmpID1, daycode2, hasa_code2, alsofof_code2, fasl_code2, SubjectId1, placecd1))
                return true;    
            else
                return false;
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData.DataSource).Rows.Add(((DataTable)gridControlData.DataSource).NewRow());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Time" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }

#endregion
        #region - Event Handlers -
        private void stu_nashatFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void LUEEmp_EditValueChanged(object sender, EventArgs e)
        {
            //Is any of
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
            {
                gridViewData.ActiveFilterString = string.Empty;
                return;
            }
            //ColumnFilterInfo columnfilter = new ColumnFilterInfo(String.Format("[EmpID] Equals '{0}'", 1));
            //gridViewData.Columns["EmpID"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            //gridViewData.Columns["EmpID"].FilterInfo = columnfilter;
            string[] arr = LUEEmp.EditValue.ToString().Split(Convert.ToChar(","));
            string FilterString = string.Empty;
            foreach (string item in arr)
            {
                FilterString += String.Format("OR [EmpID] = {0} ", item);
            }
            gridViewData.ActiveFilterString = FilterString.Remove(0, 2);
            
        }
        private void repositoryItemGridLookUpEditfasl_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEFasl);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDEFasl);
        }
        private void repositoryItemGridLookUpEditalsofof_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAlsofof);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDAlsofof);
        }
        private void repositoryItemGridLookUpEditdaycode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDDayname);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDDayname);
        }
        private void repositoryItemGridLookUpEdithasa_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAlhasas);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDAlhasas);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue) || FXFW.SqlDB.IsNullOrEmpty(LuePlace.EditValue))
            {
                Program.ShowMsg("البيانات غير مكتمله", true, this);
                Program.Logger.LogThis("البيانات غير مكتمله", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }
            string[] EmpArr = LUEEmp.EditValue.ToString().Split(Convert.ToChar(","));
            gcControls.Enabled = false;
            gridControlData.Visible = false;
            pb.Visible = true;
            pb.Properties.Maximum = EmpArr.Length;
            pb.EditValue = 0;
            List<string> EmpArrRemain = new List<string>();

            foreach (string EmpID in EmpArr)
            {
                if (!AddEmp(EmpID))
                    EmpArrRemain.Add(EmpID);
                pb.EditValue = FXFW.SqlDB.ConvertStringToInt(pb.EditValue.ToString()) + 1;
            }
            foreach (string item in EmpArrRemain)
            {
                if (TryToAdd(item, LuePlace.EditValue.ToString()))
                    pb.EditValue = FXFW.SqlDB.ConvertStringToInt(pb.EditValue.ToString()) + 1;
                Application.DoEvents();
            }
            LoadGrid();
            gcControls.Enabled = true;
            gridControlData.Visible = true;
            pb.Visible = false;
            pb.EditValue = 0;
        }
        private bool TryToAdd(string EmpID, string placecd)
        {
            bool ReturnMe = true;
            DataTable TblRemain = FXFW.SqlDB.LoadDataTable(String.Format(@"SELECT asase_code, EmpID, alsofof_code, fasl_code, SubjectId,
            (SELECT hesasno FROM CDSubjectWekly where alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId) AS hesasno,
            (SELECT ISNULL(COUNT(*), 0) FROM gdw.TBLTimeTable WHERE asase_code = gdw.TBLTeachersPlan.asase_code AND EmpID = gdw.TBLTeachersPlan.EmpID AND alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND fasl_code = gdw.TBLTeachersPlan.fasl_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId) AS HavePeriod,
            (SELECT hesasno FROM CDSubjectWekly where alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId)
            -
            (SELECT ISNULL(COUNT(*), 0) FROM gdw.TBLTimeTable WHERE asase_code = gdw.TBLTeachersPlan.asase_code AND EmpID = gdw.TBLTeachersPlan.EmpID AND alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND fasl_code = gdw.TBLTeachersPlan.fasl_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId) AS remain
            From gdw.TBLTeachersPlan
            WHERE EmpID = {0} AND asase_code = {1} AND
            (SELECT hesasno FROM CDSubjectWekly where alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId) > 
            (SELECT ISNULL(COUNT(*), 0) FROM gdw.TBLTimeTable WHERE asase_code = gdw.TBLTeachersPlan.asase_code AND EmpID = gdw.TBLTeachersPlan.EmpID AND alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND fasl_code = gdw.TBLTeachersPlan.fasl_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId)"
                , EmpID, FXFW.SqlDB.asase_code));
            foreach (DataRow TblRemainRow in TblRemain.Rows)
            {
                int PeriodToFill = (int)TblRemainRow["remain"];// Need to fill x of periods
                for (int i = 0; i < PeriodToFill; i++)
                {
                    DataTable FreeFaslPeriod = FXFW.SqlDB.LoadDataTable(string.Format(@"select daycode, hasa_code from gdw.CD_HesaTime
                where marhala_code = (SELECT marhala_code from CDAlsofof where alsofof_code = {0})
                AND NOT EXISTS
                (SELECT hasa_code from gdw.TBLTimeTable WHERE asase_code = {1} AND daycode = gdw.CD_HesaTime.daycode AND hasa_code = gdw.CD_HesaTime.hasa_code 
                AND alsofof_code = {0} AND fasl_code = {2})", TblRemainRow["alsofof_code"], TblRemainRow["asase_code"], TblRemainRow["fasl_code"]));
                    bool PeriodAddingFinished = false;
                    foreach (DataRow FreeFaslPeriodRow in FreeFaslPeriod.Rows)
                    {
                        if (PeriodAddingFinished)
                            break;
                        DataTable FreeEmp = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT asase_code, EmpID, daycode, hasa_code, alsofof_code, fasl_code, SubjectId, placecd,
                    (SELECT twoh FROM CDSubjectWekly WHERE SubjectId = gdw.TBLTimeTable.SubjectId AND alsofof_code = gdw.TBLTimeTable.alsofof_code) as twoh
                    FROM gdw.TBLTimeTable WHERE asase_code = {0} AND alsofof_code = {1} AND fasl_code = {2}
                    AND NOT EXISTS (
                    SELECT hasa_code FROM gdw.TBLTimeTable AS TBL1 WHERE asase_code = gdw.TBLTimeTable.asase_code AND EmpID = gdw.TBLTimeTable.EmpID AND daycode = {3} AND hasa_code = {4}
                    ) AND NOT EXISTS (
                    SELECT EmpID FROM gdw.TBLTimeTable AS TBL2 WHERE EmpID = {5} AND asase_code = gdw.TBLTimeTable.asase_code AND daycode = gdw.TBLTimeTable.daycode AND hasa_code = gdw.TBLTimeTable.hasa_code
                    ) order by twoh, hasa_code desc", TblRemainRow["asase_code"], TblRemainRow["alsofof_code"], TblRemainRow["fasl_code"], FreeFaslPeriodRow["daycode"], FreeFaslPeriodRow["hasa_code"], EmpID));
                                            
                        foreach (DataRow FreeEmpRow in FreeEmp.Rows)
                        {
                            if (ReplacePeriod(FreeEmpRow["asase_code"].ToString(), FreeEmpRow["EmpID"].ToString(), FreeEmpRow["daycode"].ToString(), FreeEmpRow["hasa_code"].ToString(), FreeEmpRow["alsofof_code"].ToString(), FreeEmpRow["fasl_code"].ToString(), FreeEmpRow["SubjectId"].ToString(), FreeEmpRow["placecd"].ToString(),
                                TblRemainRow["asase_code"].ToString(), EmpID, FreeFaslPeriodRow["daycode"].ToString(), FreeFaslPeriodRow["hasa_code"].ToString(), TblRemainRow["alsofof_code"].ToString(), TblRemainRow["fasl_code"].ToString(), TblRemainRow["SubjectId"].ToString(), placecd))
                            {
                                PeriodAddingFinished = true;
                                break;
                            }
                        }
                    }
                    ReturnMe = false;
                }
            }
        
            return ReturnMe;
        }
        private void btnAddShare_Click(object sender, EventArgs e)
        {
            SharePeriodSaf();
            //SharePeriodFasl();
        }
        private void LUEEmp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                return;
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;
            if (MessageBox.Show("هل انت متأكد تريد حذف كل حصص هذا المدرس؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            string[] EmpArr = LUEEmp.EditValue.ToString().Split(Convert.ToChar(","));
            try
            {
                foreach (string item in EmpArr)
                    DeleteEmp(item);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow rowgridViewData = gridViewData.GetFocusedDataRow();
            cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = FXFW.SqlDB.asase_code });
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = rowgridViewData["EmpID"] });
            cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt) { Value = rowgridViewData["alsofof_code"] });
            cmd.Parameters.Add(new SqlParameter("@fasl_code", SqlDbType.TinyInt) { Value = rowgridViewData["fasl_code"] });
            cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = rowgridViewData["SubjectId"] });
            cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = rowgridViewData["daycode"] });
            cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = rowgridViewData["hasa_code"] });
            cmd.Parameters.Add(new SqlParameter("@placecd", SqlDbType.TinyInt) { Value = rowgridViewData["placecd"] });

            try
            {
                if (rowgridViewData["org_EmpID"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO gdw.TBLTimeTable (asase_code, EmpID, alsofof_code, fasl_code, SubjectId, daycode, hasa_code, placecd)
                    VALUES (@asase_code, @EmpID, @alsofof_code, @fasl_code, @SubjectId, @daycode, @hasa_code, @placecd)";
                }
                else
                {
                    cmd.CommandText = @"UPDATE gdw.TBLTimeTable SET asase_code = @asase_code, EmpID = @EmpID, alsofof_code = @alsofof_code, fasl_code = @fasl_code, 
                    SubjectId = @SubjectId, daycode = @daycode, hasa_code = @hasa_code, placecd = @placecd
                    WHERE (asase_code = @org_asase_code) AND (EmpID = @org_EmpID) AND (alsofof_code = @org_alsofof_code) AND (fasl_code = @org_fasl_code) AND 
                    (SubjectId = @org_SubjectId) AND (daycode = @org_daycode) AND (hasa_code = @org_hasa_code)";
                    cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = rowgridViewData["org_asase_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewData["org_EmpID"] });
                    cmd.Parameters.Add(new SqlParameter("@org_alsofof_code", SqlDbType.TinyInt) { Value = rowgridViewData["org_alsofof_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_fasl_code", SqlDbType.TinyInt) { Value = rowgridViewData["org_fasl_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_SubjectId", SqlDbType.SmallInt) { Value = rowgridViewData["org_SubjectId"] });
                    cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowgridViewData["org_daycode"] });
                    cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowgridViewData["org_hasa_code"] });
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow rowgridViewTBLTeacherNoDays = gridViewData.GetFocusedDataRow();
            if (rowgridViewTBLTeacherNoDays["org_EmpID"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"DELETE FROM gdw.TBLTimeTable 
                WHERE (asase_code = @org_asase_code) AND (EmpID = @org_EmpID) AND (alsofof_code = @org_alsofof_code) AND (fasl_code = @org_fasl_code) AND 
                (SubjectId = @org_SubjectId) AND (daycode = @org_daycode) AND (hasa_code = @org_hasa_code)";
                cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_asase_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_EmpID"] });
                cmd.Parameters.Add(new SqlParameter("@org_alsofof_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_alsofof_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_fasl_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_fasl_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_SubjectId", SqlDbType.SmallInt) { Value = rowgridViewTBLTeacherNoDays["org_SubjectId"] });
                cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_daycode"] });
                cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_hasa_code"] });
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion
    }
}