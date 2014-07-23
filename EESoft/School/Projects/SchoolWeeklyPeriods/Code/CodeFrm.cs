using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Repository;

namespace SchoolWeeklyPeriods
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        DataRow rowgridViewCD_HesaTime = null;
        public bool ExitAfterSave = false;
        public enum TableNames : byte
        {
            All,
            CD_Asasetime,
            CDAlhasas,
            CDAlsofof,
            CDEFasl,
            CDDayname,
            CD_HesaTime,
            CDSubjectWekly,
            CDPlace,
            CD_EmpState,
            CD_JobDescription,
            CD_EmpJob,
            CD_Department,
            CD_Subject,
            CD_QualifiedPlace,
            CDQualification,
            CD_Specialization,
            CD_MaritalStatus,
            TBL_Priority,
            CD_AgazaType
        }
        private readonly TableNames ViewName;
        #endregion
        #region -   Functions   -
        public CodeFrm(TableNames CodeName)
        {
            InitializeComponent();
            ViewName = CodeName;
            switch (CodeName)
            {
                case TableNames.CD_Asasetime:
                    gridControlCode.MainView = gridViewCD_Asasetime;
                    LoadData(TableNames.CD_Asasetime);
                    Text += " تحديد العام الدراسي";
                    break;
                case TableNames.CDAlhasas:
                    gridControlCode.MainView = gridViewCDAlhasas;
                     LoadData(TableNames.CDAlhasas);
                     Text += "  الحصص";
                    break;
                case TableNames.CDAlsofof:
                    gridControlCode.MainView = gridViewCDAlsofof;
                    LoadData(TableNames.CDAlsofof);
                    Text += "  الصفوف";
                    break;
                case TableNames.CDEFasl:
                    gridControlCode.MainView = gridViewCDEFasl;
                    LoadData(TableNames.CDEFasl);
                    Text += "  الفصول";
                    break;
                case TableNames.CDDayname:
                    gridControlCode.MainView = gridViewCDDayname;
                    LoadData(TableNames.CDDayname);
                    Text += "  الايام";
                    break;
                case TableNames.CD_HesaTime:
                    gridControlCode.MainView = gridViewCD_HesaTime;
                    LoadData(TableNames.CD_HesaTime);
                    Text += "  مواعيد الحصص";
                    break;
                case TableNames.CDSubjectWekly:
                    gridControlCode.MainView = gridViewCDSubjectWekly;
                    LoadData(TableNames.CDSubjectWekly);
                    Text += " خطة المواد الاسبوعية";
                    break;
                case TableNames.CDPlace:
                    gridControlCode.MainView = gridViewCDPlace;
                    LoadData(TableNames.CDPlace);
                    Text += " الاماكن";
                    break;
                case TableNames.CD_EmpState:
                    gridControlCode.MainView = gridViewCD_EmpState;
                    LoadData(TableNames.CD_EmpState);
                    Text += " الحالة الوظيفية";
                    break;
                case TableNames.CD_JobDescription:
                    gridControlCode.MainView = gridViewCD_JobDescription;
                    LoadData(TableNames.CD_JobDescription);
                    Text += " الوصف الوظيفي";
                    break;
                case TableNames.CD_EmpJob:
                    gridControlCode.MainView = gridViewCD_EmpJob;
                    LoadData(TableNames.CD_EmpJob);
                    Text += " وظائف العاملين";
                    break;
                case TableNames.CD_Department:
                    gridControlCode.MainView = gridViewCD_Department;
                    LoadData(TableNames.CD_Department);
                    Text += " الاقسام";
                    break;
                case TableNames.CD_Subject:
                    gridControlCode.MainView = gridViewCD_Subject;
                    LoadData(TableNames.CD_Subject);
                    Text += " المواد";
                    break;
                case TableNames.CD_QualifiedPlace:
                    gridControlCode.MainView = gridViewCD_QualifiedPlace;
                    LoadData(TableNames.CD_QualifiedPlace);
                    Text += " جهة الؤهل";
                    break;
                case TableNames.CDQualification:
                    gridControlCode.MainView = gridViewCDQualification;
                    LoadData(TableNames.CDQualification);
                    Text += " المؤهلات";
                    break;
                case TableNames.CD_Specialization:
                    gridControlCode.MainView = gridViewCD_Specialization;
                    LoadData(TableNames.CD_Specialization);
                    Text += " تخصص المؤهل";
                    break;
                case TableNames.CD_MaritalStatus:
                    gridControlCode.MainView = gridViewCD_MaritalStatus;
                    LoadData(TableNames.CD_MaritalStatus);
                    Text += " الحالة الاجتماعية";
                    break;
                case TableNames.TBL_Priority:
                    gridControlCode.MainView = gridViewTBL_Priority;
                    LoadData(TableNames.TBL_Priority);
                    Text += " أولويات المواد";
                    break;
                case TableNames.CD_AgazaType:
                    gridControlCode.MainView = gridViewCD_AgazaType;
                    LoadData(TableNames.CD_AgazaType);
                    Text += " الاجازات";
                    break;
                default:
                    break;
            }
            
        }
        private void LoadData(TableNames CodeName)
        {
            DataTable dt = new DataTable();
            switch (CodeName)
            {
                case TableNames.CD_Asasetime:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, school_allcode, SPOS, 
                    (Select school_allname From TBLSCHOOLALL Where school_allcode = CD_Asasetime.school_allcode) AS school_allname FROM CD_Asasetime");
                    repositoryItemGridLookUpEditSPOS.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SPOS, SCHOOL, SCHOOl_e, school_allcode FROM TBLSCHOOL");
                    break;
                case TableNames.CDAlhasas:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e FROM CDAlhasas");
                    break;
                case TableNames.CDAlsofof:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT alsofof_code, alsofof_name, marhala_code, alsofof_name_e, Shortly, Shortlye FROM CDAlsofof");
                    repositoryItemGridLookUpEditmarhala_code.DataSource = FXFW.SqlDB.LoadDataTable("Select marhala_code, marhala_name, marhala_name_e From CDMarahel");
                    break;
                case TableNames.CDEFasl:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e, Shortly, Shortlye FROM CDEFasl");
                    break;
                case TableNames.CDDayname:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    break;
                case TableNames.CD_HesaTime:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT marhala_code, daycode, hasa_code, Convert(Datetime, tiem_be, 114) AS tiem_be, Convert(Datetime, tiem_en, 114) AS tiem_en,
                    marhala_code as org_marhala_code, daycode as org_daycode, hasa_code as org_hasa_code
                    FROM gdw.CD_HesaTime");
                    repositoryItemGridLookUpEditmarhala_code.DataSource = FXFW.SqlDB.LoadDataTable("Select marhala_code, marhala_name, marhala_name_e From CDMarahel");
                    repositoryItemGridLookUpEditdaycode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    repositoryItemGridLookUpEdithasa_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e FROM CDAlhasas");
                    break;
                case TableNames.CDSubjectWekly:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT alsofof_code, SubjectId, hesasno, twoh, alsofof_code AS org_alsofof_code, SubjectId AS org_SubjectId FROM CDSubjectWekly");
                    repositoryItemGridLookUpEditSubjectId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e FROM CD_Subject");
                    repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable("Select alsofof_code, alsofof_name, alsofof_name_e FROM CDAlsofof");
                    break;
                case TableNames.CDPlace:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT placecd, place FROM gdw.CDPlace");
                    break;
                case TableNames.CD_EmpState:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EmpStateID, EmpStateName, EmpStateName_e, OnWork FROM CD_EmpState");
                    break;
                case TableNames.CD_JobDescription:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT JobDescriptionId, JobDescription, JobDescription_e FROM CD_JobDescription");
                    break;
                case TableNames.CD_EmpJob:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EmpJobId, JobDescriptionId, EmpJobName, EmpJobName_e FROM CD_EmpJob");
                    repositoryItemGridLookUpEditJobDescriptionId.DataSource = FXFW.SqlDB.LoadDataTable("Select JobDescriptionId, JobDescription, JobDescription_e FROM CD_JobDescription");
                    break;
                case TableNames.CD_Department:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT DepartmentId, Department, Department_e FROM CD_Department");
                    break;
                case TableNames.CD_Subject:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e, simple FROM CD_Subject");
                    break;
                case TableNames.CD_QualifiedPlace:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT QualifiedPlaceId, QualifiedPlaceName, QualifiedPlaceName_e FROM CD_QualifiedPlace");
                    break;
                case TableNames.CDQualification:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e, trbawy FROM CDQualification");
                    break;
                case TableNames.CD_Specialization:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT SpecializationId, qualId, SpecializationName, SpecializationName_e FROM CD_Specialization");
                    repositoryItemGridLookUpEditqualId.DataSource = FXFW.SqlDB.LoadDataTable("Select qualId, qualName, qualName_e From CDQualification");
                    break;
                case TableNames.CD_MaritalStatus:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT MaritalStatusId, MaritalStatus, MaritalStatus_e FROM CD_MaritalStatus");
                    break;
                case TableNames.TBL_Priority:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, hasa_code, autoid FROM TBL_Priority");
                    repositoryItemGridLookUpEditSubjectId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e FROM CD_Subject");
                    repositoryItemGridLookUpEdithasa_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e FROM CDAlhasas");
                    break;
                case TableNames.CD_AgazaType:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT AgazaTypeId, AgazaTypeName, AgazaTypeName_e, allow FROM CD_AgazaType");
                    break;
                default:
                    break;
            }
            gridControlCode.DataSource = dt;
            //gridViewCDMarahel.BestFitColumns()
            ((DevExpress.XtraGrid.Views.Grid.GridView)gridControlCode.MainView).BestFitColumns();
            
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
                    ((DataTable)gridControlCode.DataSource).Rows.Add(((DataTable)gridControlCode.DataSource).NewRow());
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
            FXFW.SqlDB.GetFormPriv("Time" + ViewName.ToString(), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlCode.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
#endregion
        #region - Event Handlers -
        private void CodeFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCD_Asasetime":
                        DataRow rowgridViewCD_Asasetime = gridViewCD_Asasetime.GetFocusedDataRow();

                        if (rowgridViewCD_Asasetime["asase_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_Asasetime (asase_code, asase_year, school_allcode, SPOS)
                            VALUES ((SELECT ISNULL(MAX(asase_code) + 1, 1) FROM CD_Asasetime), N'{0}', (Select school_allcode From TBLSCHOOL Where SPOS = {1}), {1})",
                            rowgridViewCD_Asasetime["asase_year"], rowgridViewCD_Asasetime["SPOS"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_Asasetime SET asase_year = N'{0}', school_allcode = (Select school_allcode From TBLSCHOOL Where SPOS = {1}), 
                            SPOS = {1} WHERE (asase_code = {2})",
                            rowgridViewCD_Asasetime["asase_year"], rowgridViewCD_Asasetime["SPOS"], rowgridViewCD_Asasetime["asase_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        if (ExitAfterSave) // this should fire only when i call cd_year for 1st time application run
                            Application.Restart();
                        ((MainFrm)this.ParentForm).LoadCD_Asasetime();
                        break;
                    case "gridViewCDAlhasas":
                        DataRow rowgridViewCDAlhasas = gridViewCDAlhasas.GetFocusedDataRow();
                        if (rowgridViewCDAlhasas["hasa_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDAlhasas (hasa_code, hasa_name, hasa_name_e)
                            VALUES ((SELECT ISNULL(MAX(hasa_code) + 1, 1) FROM CDAlhasas), N'{0}', N'{1}')",
                            rowgridViewCDAlhasas["hasa_name"], rowgridViewCDAlhasas["hasa_name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDAlhasas SET hasa_name = N'{0}', hasa_name_e = N'{1}' WHERE (hasa_code = {2})",
                            rowgridViewCDAlhasas["hasa_name"], rowgridViewCDAlhasas["hasa_name_e"], rowgridViewCDAlhasas["hasa_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDAlsofof":
                        DataRow rowgridViewCDAlsofof = gridViewCDAlsofof.GetFocusedDataRow();
                        if (rowgridViewCDAlsofof["alsofof_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDAlsofof (alsofof_code, alsofof_name, alsofof_name_e, marhala_code, Shortly, Shortlye)
                            VALUES ((SELECT ISNULL(MAX(alsofof_code) + 1, 1) FROM CDAlsofof), N'{0}', N'{1}', {2}, N'{3}', N'{4}')", rowgridViewCDAlsofof["alsofof_name"],
                            rowgridViewCDAlsofof["alsofof_name_e"], rowgridViewCDAlsofof["marhala_code"], rowgridViewCDAlsofof["Shortly"], rowgridViewCDAlsofof["Shortlye"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDAlsofof SET alsofof_name = N'{0}', alsofof_name_e = N'{1}', marhala_code = {2},
                            Shortly = N'{3}', Shortlye = N'{4}' WHERE (alsofof_code = {5})",
                            rowgridViewCDAlsofof["alsofof_name"], rowgridViewCDAlsofof["alsofof_name_e"], rowgridViewCDAlsofof["marhala_code"], rowgridViewCDAlsofof["Shortly"],
                            rowgridViewCDAlsofof["Shortlye"], rowgridViewCDAlsofof["alsofof_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDEFasl":
                        DataRow rowggridViewCDEFasl = gridViewCDEFasl.GetFocusedDataRow();
                        if (rowggridViewCDEFasl["fasl_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDEFasl (fasl_code, fasl_name, fasl_name_e, Shortly, Shortlye)
                            VALUES ((SELECT ISNULL(MAX(fasl_code) + 1, 1) FROM CDEFasl), N'{0}', N'{1}', N'{2}', N'{3}')", rowggridViewCDEFasl["fasl_name"],
                            rowggridViewCDEFasl["fasl_name_e"], rowggridViewCDEFasl["Shortly"], rowggridViewCDEFasl["Shortlye"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDEFasl SET fasl_name = N'{0}', fasl_name_e = N'{1}', Shortly = N'{2}', Shortlye = N'{3}' WHERE (fasl_code = {4})",
                            rowggridViewCDEFasl["fasl_name"], rowggridViewCDEFasl["fasl_name_e"], rowggridViewCDEFasl["Shortly"], rowggridViewCDEFasl["Shortlye"], rowggridViewCDEFasl["fasl_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDDayname":
                        DataRow rowgridViewCDDayname = gridViewCDDayname.GetFocusedDataRow();
                        if (rowgridViewCDDayname["daycode"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDDayname (daycode, dayname, dayname_e)
                            VALUES ((SELECT ISNULL(MAX(daycode) + 1, 1) FROM CDDayname), N'{0}', N'{1}')", rowgridViewCDDayname["dayname"], rowgridViewCDDayname["dayname_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDDayname SET dayname = N'{0}', dayname_e = N'{1}' WHERE (daycode = {2})",
                            rowgridViewCDDayname["dayname"], rowgridViewCDDayname["dayname_e"], rowgridViewCDDayname["daycode"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_HesaTime":
                        DataRow rowgridViewCD_HesaTime = gridViewCD_HesaTime.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@marhala_code", SqlDbType.TinyInt));
                        cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@tiem_be", SqlDbType.Time));
                        cmd.Parameters.Add(new SqlParameter("@tiem_en", SqlDbType.Time));

                        if (rowgridViewCD_HesaTime["marhala_code"].ToString() == string.Empty)
                            cmd.Parameters["@marhala_code"].Value = DBNull.Value;
                        else
                            cmd.Parameters["@marhala_code"].Value = rowgridViewCD_HesaTime["marhala_code"];
                        if (rowgridViewCD_HesaTime["daycode"].ToString() == string.Empty)
                            cmd.Parameters["@daycode"].Value = DBNull.Value;
                        else
                            cmd.Parameters["@daycode"].Value = rowgridViewCD_HesaTime["daycode"];
                        if (rowgridViewCD_HesaTime["hasa_code"].ToString() == string.Empty)
                            cmd.Parameters["@hasa_code"].Value = DBNull.Value;
                        else
                            cmd.Parameters["@hasa_code"].Value = rowgridViewCD_HesaTime["hasa_code"];
                        if (rowgridViewCD_HesaTime["tiem_be"].ToString() == string.Empty)
                            cmd.Parameters["@tiem_be"].Value = DBNull.Value;
                        else
                        {
                            cmd.Parameters["@tiem_be"].Value = FXFW.SqlDB.ConvertToDateHMS(rowgridViewCD_HesaTime["tiem_be"].ToString());
                        }
                        if (rowgridViewCD_HesaTime["tiem_en"].ToString() == string.Empty)
                            cmd.Parameters["@tiem_en"].Value = DBNull.Value;
                        else
                        {

                            cmd.Parameters["@tiem_en"].Value = FXFW.SqlDB.ConvertToDateHMS(rowgridViewCD_HesaTime["tiem_en"].ToString());
                        }

                        if (rowgridViewCD_HesaTime["org_marhala_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO gdw.CD_HesaTime (marhala_code, daycode, hasa_code, tiem_be, tiem_en)
                            VALUES (@marhala_code, @daycode, @hasa_code, @tiem_be, @tiem_en)";
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE gdw.CD_HesaTime SET marhala_code = @marhala_code, daycode = @daycode, hasa_code = @hasa_code, tiem_be = @tiem_be, tiem_en = @tiem_en
                            WHERE (marhala_code = @org_marhala_code) AND (daycode = @org_daycode) AND (hasa_code = @org_hasa_code)";
                            cmd.Parameters.Add(new SqlParameter("@org_marhala_code", SqlDbType.TinyInt) { Value = rowgridViewCD_HesaTime["org_marhala_code"] });
                            cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowgridViewCD_HesaTime["org_daycode"] });
                            cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowgridViewCD_HesaTime["org_hasa_code"] });
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDSubjectWekly":
                        DataRow rowgridViewCDSubjectWekly = gridViewCDSubjectWekly.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt) { Value = rowgridViewCDSubjectWekly["alsofof_code"] });
                        cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = rowgridViewCDSubjectWekly["SubjectId"] });
                        cmd.Parameters.Add(new SqlParameter("@hesasno", SqlDbType.TinyInt) { Value = rowgridViewCDSubjectWekly["hesasno"] });
                        cmd.Parameters.Add(new SqlParameter("@twoh", SqlDbType.Bit) { Value = rowgridViewCDSubjectWekly["twoh"] });
                        if (rowgridViewCDSubjectWekly["org_alsofof_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO CDSubjectWekly (alsofof_code, SubjectId, hesasno, twoh) VALUES (@alsofof_code, @SubjectId, @hesasno, @twoh)";
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE CDSubjectWekly SET alsofof_code = @alsofof_code, SubjectId = @SubjectId, hesasno = @hesasno, twoh = @twoh 
                            WHERE (alsofof_code = @org_alsofof_code) And (SubjectId = @org_SubjectId)";
                            cmd.Parameters.Add(new SqlParameter("@org_alsofof_code", SqlDbType.Int) { Value = rowgridViewCDSubjectWekly["org_alsofof_code"] });
                            cmd.Parameters.Add(new SqlParameter("@org_SubjectId", SqlDbType.Int) { Value = rowgridViewCDSubjectWekly["org_SubjectId"] });
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDPlace":
                        DataRow rowgridViewCDPlace = gridViewCDPlace.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@place", SqlDbType.NVarChar) { Value = rowgridViewCDPlace["place"] });
                        if (rowgridViewCDPlace["placecd"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO gdw.CDPlace (placecd, place) 
                            VALUES ((SELECT ISNULL(MAX(placecd) + 1, 1) FROM gdw.CDPlace), @place)";
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE gdw.CDPlace SET place = @place WHERE placecd = @placecd";
                            cmd.Parameters.Add(new SqlParameter("@placecd", SqlDbType.TinyInt) { Value = rowgridViewCDPlace["placecd"] });
                            
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_EmpState":
                        DataRow rowgridViewCD_EmpState = gridViewCD_EmpState.GetFocusedDataRow();
                        if (rowgridViewCD_EmpState["EmpStateID"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_EmpState (EmpStateID, EmpStateName, EmpStateName_e, OnWork)
                            VALUES ((SELECT ISNULL(MAX(EmpStateID) + 1, 1) FROM CD_EmpState), N'{0}', N'{1}', '{2}')",
                            rowgridViewCD_EmpState["EmpStateName"], rowgridViewCD_EmpState["EmpStateName_e"], rowgridViewCD_EmpState["OnWork"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_EmpState SET EmpStateName = N'{0}', EmpStateName_e = N'{1}', OnWork = '{2}' WHERE (EmpStateID = {3})",
                            rowgridViewCD_EmpState["EmpStateName"], rowgridViewCD_EmpState["EmpStateName_e"], rowgridViewCD_EmpState["OnWork"], rowgridViewCD_EmpState["EmpStateID"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_JobDescription":
                        DataRow rowgridViewCD_JobDescription = gridViewCD_JobDescription.GetFocusedDataRow();
                        if (rowgridViewCD_JobDescription["JobDescriptionId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_JobDescription (JobDescriptionId, JobDescription, JobDescription_e)
                            VALUES ((SELECT ISNULL(MAX(JobDescriptionId) + 1, 1) FROM CD_JobDescription), N'{0}', N'{1}')", rowgridViewCD_JobDescription["JobDescription"],
                            rowgridViewCD_JobDescription["JobDescription_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_JobDescription SET JobDescription = N'{0}', JobDescription_e = N'{1}' WHERE (JobDescriptionId = {2})",
                            rowgridViewCD_JobDescription["JobDescription"], rowgridViewCD_JobDescription["JobDescription_e"], rowgridViewCD_JobDescription["JobDescriptionId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_EmpJob":
                        DataRow rowggridViewCD_EmpJob = gridViewCD_EmpJob.GetFocusedDataRow();
                        string JobDescriptionId;
                        if (rowggridViewCD_EmpJob["JobDescriptionId"].ToString() != string.Empty)
                            JobDescriptionId = rowggridViewCD_EmpJob["JobDescriptionId"].ToString();
                        else
                            JobDescriptionId = "NULL";

                        if (rowggridViewCD_EmpJob["EmpJobId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_EmpJob (EmpJobId, EmpJobName, EmpJobName_e, JobDescriptionId)
                            VALUES ((SELECT ISNULL(MAX(EmpJobId) + 1, 1) FROM CD_EmpJob), N'{0}', N'{1}', {2})", rowggridViewCD_EmpJob["EmpJobName"],
                            rowggridViewCD_EmpJob["EmpJobName_e"], JobDescriptionId);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_EmpJob SET EmpJobName = N'{0}', EmpJobName_e = N'{1}', JobDescriptionId = {2}  WHERE (EmpJobId = {3})",
                            rowggridViewCD_EmpJob["EmpJobName"], rowggridViewCD_EmpJob["EmpJobName_e"], rowggridViewCD_EmpJob["JobDescriptionId"], rowggridViewCD_EmpJob["EmpJobId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_Department":
                        DataRow rowgridViewCD_Department = gridViewCD_Department.GetFocusedDataRow();
                        if (rowgridViewCD_Department["DepartmentId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_Department (DepartmentId, Department, Department_e)
                            VALUES ((SELECT ISNULL(MAX(DepartmentId) + 1, 1) FROM CD_Department), N'{0}', N'{1}')", rowgridViewCD_Department["Department"], rowgridViewCD_Department["Department_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_Department SET Department = N'{0}', Department_e = N'{1}' WHERE (DepartmentId = {2})",
                            rowgridViewCD_Department["Department"], rowgridViewCD_Department["Department_e"], rowgridViewCD_Department["DepartmentId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_Subject":
                        DataRow rowgridViewCD_Subject = gridViewCD_Subject.GetFocusedDataRow();
                        if (rowgridViewCD_Subject["SubjectId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_Subject (SubjectId, Subject, Subject_e, simple)
                            VALUES ((SELECT ISNULL(MAX(SubjectId) + 1, 1) FROM CD_Subject), N'{0}', N'{1}', N'{2}')", rowgridViewCD_Subject["Subject"],
                            rowgridViewCD_Subject["Subject_e"], rowgridViewCD_Subject["simple"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_Subject SET Subject = N'{0}', Subject_e = N'{1}', simple = N'{2}' WHERE (SubjectId = {3})",
                            rowgridViewCD_Subject["Subject"], rowgridViewCD_Subject["Subject_e"], rowgridViewCD_Subject["simple"], rowgridViewCD_Subject["SubjectId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_QualifiedPlace":
                        DataRow rowgridViewCD_QualifiedPlace = gridViewCD_QualifiedPlace.GetFocusedDataRow();
                        if (rowgridViewCD_QualifiedPlace["QualifiedPlaceId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_QualifiedPlace (QualifiedPlaceId, QualifiedPlaceName, QualifiedPlaceName_e)
                            VALUES ((SELECT ISNULL(MAX(QualifiedPlaceId) + 1, 1) FROM CD_QualifiedPlace), N'{0}', N'{1}')", rowgridViewCD_QualifiedPlace["QualifiedPlaceName"], rowgridViewCD_QualifiedPlace["QualifiedPlaceName_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_QualifiedPlace SET QualifiedPlaceName = N'{0}', QualifiedPlaceName_e = N'{1}' WHERE (QualifiedPlaceId = {2})",
                            rowgridViewCD_QualifiedPlace["QualifiedPlaceName"], rowgridViewCD_QualifiedPlace["QualifiedPlaceName_e"], rowgridViewCD_QualifiedPlace["QualifiedPlaceId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDQualification":
                        DataRow rowgridViewCDQualification = gridViewCDQualification.GetFocusedDataRow();
                        if (rowgridViewCDQualification["qualId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDQualification (qualId, qualName, qualName_e, trbawy)
                            VALUES ((SELECT ISNULL(MAX(qualId) + 1, 1) FROM CDQualification), N'{0}', N'{1}', '{2}')", rowgridViewCDQualification["qualName"],
                            rowgridViewCDQualification["qualName_e"], rowgridViewCDQualification["trbawy"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDQualification SET qualName = N'{0}', qualName_e = N'{1}', trbawy = '{2}' WHERE (qualId = {3})",
                            rowgridViewCDQualification["qualName"], rowgridViewCDQualification["qualName_e"], rowgridViewCDQualification["trbawy"], rowgridViewCDQualification["qualId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_Specialization":
                        DataRow rowgridViewCD_Specialization = gridViewCD_Specialization.GetFocusedDataRow();
                        if (rowgridViewCD_Specialization["SpecializationId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_Specialization (SpecializationId, qualId, SpecializationName, SpecializationName_e)
                            VALUES ((SELECT ISNULL(MAX(SpecializationId) + 1, 1) FROM CD_Specialization), {0}, N'{1}', N'{2}')",
                            rowgridViewCD_Specialization["qualId"], rowgridViewCD_Specialization["SpecializationName"], rowgridViewCD_Specialization["SpecializationName_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_Specialization SET qualId = {0}, SpecializationName = N'{1}', SpecializationName_e = N'{2}' WHERE (SpecializationId = {3})",
                            rowgridViewCD_Specialization["qualId"], rowgridViewCD_Specialization["SpecializationName"], rowgridViewCD_Specialization["SpecializationName_e"], rowgridViewCD_Specialization["SpecializationId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_MaritalStatus":
                        DataRow rowgridViewCD_MaritalStatus = gridViewCD_MaritalStatus.GetFocusedDataRow();
                        if (rowgridViewCD_MaritalStatus["MaritalStatusId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_MaritalStatus (MaritalStatusId, MaritalStatus, MaritalStatus_e)
                            VALUES ((SELECT ISNULL(MAX(MaritalStatusId) + 1, 1) FROM CD_MaritalStatus), N'{0}', N'{1}')",
                            rowgridViewCD_MaritalStatus["MaritalStatus"], rowgridViewCD_MaritalStatus["MaritalStatus_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_MaritalStatus SET MaritalStatus = N'{0}', MaritalStatus_e = N'{1}' WHERE (MaritalStatusId = {2})",
                            rowgridViewCD_MaritalStatus["MaritalStatus"], rowgridViewCD_MaritalStatus["MaritalStatus_e"], rowgridViewCD_MaritalStatus["MaritalStatusId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewTBL_Priority":
                        DataRow rowgridViewTBL_Priority = gridViewTBL_Priority.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = rowgridViewTBL_Priority["SubjectId"] });
                        cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = rowgridViewTBL_Priority["hasa_code"] });

                        if (rowgridViewTBL_Priority["autoid"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO TBL_Priority (SubjectId, hasa_code) VALUES (@SubjectId, @hasa_code)";
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@autoid", SqlDbType.BigInt) { Value = rowgridViewTBL_Priority["autoid"] });
                            cmd.CommandText = @"UPDATE TBL_Priority SET SubjectId = @SubjectId, hasa_code = @hasa_code WHERE (autoid = @autoid)";
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_AgazaType":
                        DataRow rowgridViewCD_AgazaType = gridViewCD_AgazaType.GetFocusedDataRow();
                        if (rowgridViewCD_AgazaType["AgazaTypeId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_AgazaType (AgazaTypeId, AgazaTypeName, AgazaTypeName_e, allow)
                            VALUES ((SELECT ISNULL(MAX(AgazaTypeId) + 1, 1) FROM CD_AgazaType), N'{0}', N'{1}', '{2}')",
                            rowgridViewCD_AgazaType["AgazaTypeName"], rowgridViewCD_AgazaType["AgazaTypeName_e"], rowgridViewCD_AgazaType["allow"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_AgazaType SET AgazaTypeName = N'{0}', AgazaTypeName_e = N'{1}', allow = '{2}' WHERE (AgazaTypeId = {3})",
                            rowgridViewCD_AgazaType["AgazaTypeName"], rowgridViewCD_AgazaType["AgazaTypeName_e"], rowgridViewCD_AgazaType["allow"], rowgridViewCD_AgazaType["AgazaTypeId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            LoadData(ViewName);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟","تحزير ...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCD_Asasetime":
                        DataRow rowgridViewCD_Asasetime = gridViewCD_Asasetime.GetFocusedDataRow();
                        if (rowgridViewCD_Asasetime["asase_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_Asasetime WHERE (asase_code = {0})", rowgridViewCD_Asasetime["asase_code"]);
                            cmd.ExecuteNonQuery();
                            ((MainFrm)this.ParentForm).LoadCD_Asasetime();
                        }
                        break;
                    case "gridViewCDAlhasas":
                        DataRow rowgridViewCDAlhasas = gridViewCDAlhasas.GetFocusedDataRow();
                        if (rowgridViewCDAlhasas["hasa_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDAlhasas WHERE (hasa_code = {0})", rowgridViewCDAlhasas["hasa_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDAlsofof":
                        DataRow rowgridViewCDAlsofof = gridViewCDAlsofof.GetFocusedDataRow();
                        if (rowgridViewCDAlsofof["alsofof_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDAlsofof WHERE (alsofof_code = {0})", rowgridViewCDAlsofof["alsofof_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDEFasl":
                        DataRow rowgridViewCDEFasl = gridViewCDEFasl.GetFocusedDataRow();
                        if (rowgridViewCDEFasl["fasl_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDEFasl WHERE (fasl_code = {0})", rowgridViewCDEFasl["fasl_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDDayname":
                        DataRow rowgridViewCDDayname = gridViewCDDayname.GetFocusedDataRow();
                        if (rowgridViewCDDayname["daycode"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDDayname WHERE (daycode = {0})", rowgridViewCDDayname["daycode"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_HesaTime":
                        DataRow rowgridViewCD_HesaTime = gridViewCD_HesaTime.GetFocusedDataRow();
                        if (rowgridViewCD_HesaTime["org_marhala_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = "DELETE FROM gdw.CD_HesaTime WHERE marhala_code = @org_marhala_code AND daycode = @org_daycode AND hasa_code = @org_hasa_code";

                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDSubjectWekly":
                        DataRow rowgridViewCDSubjectWekly = gridViewCDSubjectWekly.GetFocusedDataRow();
                        if (rowgridViewCDSubjectWekly["org_alsofof_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = @"DELETE FROM CDSubjectWekly WHERE (alsofof_code = @org_alsofof_code) And (SubjectId = @org_SubjectId)";
                            cmd.Parameters.Add(new SqlParameter("@org_alsofof_code", SqlDbType.Int) { Value = rowgridViewCDSubjectWekly["org_alsofof_code"] });
                            cmd.Parameters.Add(new SqlParameter("@org_SubjectId", SqlDbType.Int) { Value = rowgridViewCDSubjectWekly["org_SubjectId"] });
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDPlace":
                        DataRow rowgridViewCDPlace = gridViewCDPlace.GetFocusedDataRow();
                        if (rowgridViewCDPlace["placecd"].ToString() != string.Empty)
                        {
                            cmd.CommandText = @"DELETE FROM gdw.CDPlace WHERE placecd = @placecd";
                            cmd.Parameters.Add(new SqlParameter("@placecd", SqlDbType.Int) { Value = rowgridViewCDPlace["placecd"] });
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_EmpState":
                        DataRow rowgridViewCD_EmpState = gridViewCD_EmpState.GetFocusedDataRow();
                        if (rowgridViewCD_EmpState["EmpStateID"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_EmpState WHERE (EmpStateID = {0})", rowgridViewCD_EmpState["EmpStateID"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_JobDescription":
                        DataRow rowgridViewCD_JobDescription = gridViewCD_JobDescription.GetFocusedDataRow();
                        if (rowgridViewCD_JobDescription["JobDescriptionId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_JobDescription WHERE (JobDescriptionId = {0})", rowgridViewCD_JobDescription["JobDescriptionId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_EmpJob":
                        DataRow rowgridViewCD_EmpJob = gridViewCD_EmpJob.GetFocusedDataRow();
                        if (rowgridViewCD_EmpJob["EmpJobId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_EmpJob WHERE (EmpJobId = {0})", rowgridViewCD_EmpJob["EmpJobId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_Department":
                        DataRow rowgridViewCD_Department = gridViewCD_Department.GetFocusedDataRow();
                        if (rowgridViewCD_Department["DepartmentId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_Department WHERE (DepartmentId = {0})", rowgridViewCD_Department["DepartmentId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_Subject":
                        DataRow rowgridViewCD_Subject = gridViewCD_Subject.GetFocusedDataRow();
                        if (rowgridViewCD_Subject["SubjectId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_Subject WHERE (SubjectId = {0})", rowgridViewCD_Subject["SubjectId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_QualifiedPlace":
                        DataRow rowgridViewCD_QualifiedPlace = gridViewCD_QualifiedPlace.GetFocusedDataRow();
                        if (rowgridViewCD_QualifiedPlace["QualifiedPlaceId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_QualifiedPlace WHERE (QualifiedPlaceId = {0})", rowgridViewCD_QualifiedPlace["QualifiedPlaceId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDQualification":
                        DataRow rowgridViewCDQualification = gridViewCDQualification.GetFocusedDataRow();
                        if (rowgridViewCDQualification["qualId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDQualification WHERE (qualId = {0})", rowgridViewCDQualification["qualId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_Specialization":
                        DataRow rowgridViewCD_Specialization = gridViewCD_Specialization.GetFocusedDataRow();
                        if (rowgridViewCD_Specialization["SpecializationId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_Specialization WHERE (SpecializationId = {0})", rowgridViewCD_Specialization["SpecializationId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_MaritalStatus":
                        DataRow rowgridViewCD_MaritalStatus = gridViewCD_MaritalStatus.GetFocusedDataRow();
                        if (rowgridViewCD_MaritalStatus["MaritalStatusId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_MaritalStatus WHERE (MaritalStatusId = {0})", rowgridViewCD_MaritalStatus["MaritalStatusId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewTBL_Priority":
                        DataRow rowgridViewTBL_Priority = gridViewTBL_Priority.GetFocusedDataRow();
                        if (rowgridViewTBL_Priority["autoid"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM TBL_Priority WHERE (autoid = {0})", rowgridViewTBL_Priority["autoid"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_AgazaType":
                        DataRow rowgridViewCD_AgazaType = gridViewCD_AgazaType.GetFocusedDataRow();
                        if (rowgridViewCD_AgazaType["AgazaTypeId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_AgazaType WHERE (AgazaTypeId = {0})", rowgridViewCD_AgazaType["AgazaTypeId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            LoadData(ViewName);
        }
        private void gridControlCode_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                if (gridControlCode.MainView == gridViewCD_HesaTime)
                    rowgridViewCD_HesaTime = gridViewCD_HesaTime.GetFocusedDataRow();
            }
        }
        private void gridViewCD_HesaTime_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (rowgridViewCD_HesaTime != null)
            {
                gridViewCD_HesaTime.GetDataRow(e.RowHandle)["marhala_code"] = rowgridViewCD_HesaTime["marhala_code"];
                gridViewCD_HesaTime.GetDataRow(e.RowHandle)["daycode"] = rowgridViewCD_HesaTime["daycode"];
                gridViewCD_HesaTime.GetDataRow(e.RowHandle)["hasa_code"] = rowgridViewCD_HesaTime["hasa_code"];
                gridViewCD_HesaTime.GetDataRow(e.RowHandle)["tiem_be"] = rowgridViewCD_HesaTime["tiem_be"];
                gridViewCD_HesaTime.GetDataRow(e.RowHandle)["tiem_en"] = rowgridViewCD_HesaTime["tiem_en"];
                rowgridViewCD_HesaTime = null;
            }

        }
        #endregion
       
    }
}