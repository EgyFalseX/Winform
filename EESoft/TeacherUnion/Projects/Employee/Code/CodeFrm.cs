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

namespace Employee
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        public enum TableNames : byte
        {
            All,
            CD_AsaseEmp,
            CD_EmpState,
            CD_JobDescription,
            CD_EmpJob,
            CD_Department,
            CD_Subject,// Removed
            CD_QualifiedPlace,
            CDQualification,
            CD_Specialization,
            CD_MaritalStatus,
            CD_Courses,
            CDPlaceTraining,
            CD_AgazaType,
            CDTakdeer,
            CD_EznType,
            CD_GzaaType,
            CD_GehaGazaa,
            CD_EmpTIME,
            CDGov,
            CD_AsaseSalary,
            CDKashf
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
                case TableNames.CD_AsaseEmp:
                    gridControlCode.MainView = gridViewCD_AsaseEmp;
                    LoadData(TableNames.CD_AsaseEmp);
                    Text += " تحديد العام";
                    break;
                case TableNames.CD_EmpState:
                    gridControlCode.MainView = gridViewCD_EmpState;
                     LoadData(TableNames.CD_EmpState);
                     Text += " الحالة الوظيفية";
                    break;
                case TableNames.CD_JobDescription:
                    gridControlCode.MainView = gridViewCD_JobDescription;
                    LoadData(TableNames.CD_JobDescription);
                    Text += " وظائف العاملين";
                    break;
                case TableNames.CD_EmpJob:
                    gridControlCode.MainView = gridViewCD_EmpJob;
                    LoadData(TableNames.CD_EmpJob);
                    Text += " الوصف الوظيفي";
                    break;
                case TableNames.CD_Department:
                    gridControlCode.MainView = gridViewCD_Department;
                    LoadData(TableNames.CD_Department);
                    Text += " الاقسام";
                    break;
                case TableNames.CD_Subject:// Removed
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
                case TableNames.CD_Courses:
                    gridControlCode.MainView = gridViewCD_Courses;
                    LoadData(TableNames.CD_Courses);
                    Text += " الدورات التدريبية";
                    break;
                case TableNames.CDPlaceTraining:
                    gridControlCode.MainView = gridViewCDPlaceTraining;
                    LoadData(TableNames.CDPlaceTraining);
                    Text += " الحالة الاجتماعية";
                    break;
                case TableNames.CD_AgazaType:
                    gridControlCode.MainView = gridViewCD_AgazaType;
                    LoadData(TableNames.CD_AgazaType);
                    Text += " انواع الغياب";
                    break;
                case TableNames.CDTakdeer:
                    gridControlCode.MainView = gridViewCDTakdeer;
                    LoadData(TableNames.CDTakdeer);
                    Text += " التقديرات";
                    break;
                case TableNames.CD_EznType:
                    gridControlCode.MainView = gridViewCD_EznType;
                    LoadData(TableNames.CD_EznType);
                    Text += " الاذن";
                    break;
                case TableNames.CD_GzaaType:
                    gridControlCode.MainView = gridViewCD_GzaaType;
                    LoadData(TableNames.CD_GzaaType);
                    Text += " الجزاءات";
                    break;
                case TableNames.CD_GehaGazaa:
                    gridControlCode.MainView = gridViewCD_GehaGazaa;
                    LoadData(TableNames.CD_GehaGazaa);
                    Text += " جهة الجزاء";
                    break;
                case TableNames.CD_EmpTIME:
                    gridControlCode.MainView = gridViewCD_EmpTIME;
                    LoadData(TableNames.CD_EmpTIME);
                    Text += " اوقات العاملين";
                    break;
                case TableNames.CDGov:
                    gridControlCode.MainView = gridViewCDGov;
                    LoadData(TableNames.CDGov);
                    Text += " المحافظات";
                    break;
                case TableNames.CD_AsaseSalary:
                    gridControlCode.MainView = gridViewCD_AsaseSalary;
                    LoadData(TableNames.CD_AsaseSalary);
                    Text += " السنة المالية";
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
                case TableNames.CD_AsaseEmp:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, school_allcode, SPOS, Convert(Datetime, HodorTime, 114) AS HodorTime, Convert(Datetime, EnsrafTime, 114) AS EnsrafTime, MonthEznNo,
                    (Select Syndicate From CDSyndicate Where SyndicateId = CD_AsaseEmp.SPOS) AS school_allname FROM CD_AsaseEmp");
                    repositoryItemGridLookUpEditSPOS.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubCommitteId, SubCommitte FROM CDSubCommitte");
                    repositoryItemGridLookUpEditschool_allname.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SyndicateId, Syndicate FROM CDSyndicate");
                    break;
                case TableNames.CD_EmpState:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EmpStateID, EmpStateName, EmpStateName_e, OnWork FROM CD_EmpState");
                    break;
                case TableNames.CD_JobDescription:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT JobId, JobNAME, JobNAME_e FROM CD_EmpJop");
                    break;
                case TableNames.CD_EmpJob:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT JobDescriptionId, JobId, JobDescription, JobDescription_e, 
                    JobDescriptionId AS org_JobDescriptionId, JobId AS org_JobId FROM CD_JobDescription");
                    repositoryItemGridLookUpEditJobDescriptionId.DataSource = FXFW.SqlDB.LoadDataTable("SELECT JobId, JobNAME, JobNAME_e FROM CD_EmpJop"); 
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
                case TableNames.CD_Courses:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT CourseId, CourseName, CourseName_e FROM CD_Courses");
                    break;
                case TableNames.CDPlaceTraining:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT PlaceTrainingId, PlaceTrainingName, PlaceTrainingName_e, PlaceTrainingTell, PlaceTrainingemail FROM CDPlaceTraining");
                    break;
                case TableNames.CD_AgazaType:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT AgazaTypeId, AgazaTypeName, AgazaTypeName_e, allow FROM CD_AgazaType");
                    break;
                case TableNames.CDTakdeer:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT TakdeerId, TakdeerName, TakdeerName_e FROM CDTakdeer");
                    break;
                case TableNames.CD_EznType:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EznTypeId, EznType, EznType_e FROM CD_EznType");
                    break;
                case TableNames.CD_GzaaType:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT GzaaTypeId, GzaaType, GzaaType_e FROM CD_GzaaType");
                    break;
                case TableNames.CD_GehaGazaa:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT GehaGazaaId, GehaGazaa, GehaGazaa_e FROM CD_GehaGazaa");
                    break;
                case TableNames.CD_EmpTIME:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, FatraId, Convert(Datetime, TimeAttendance, 114) AS TimeAttendance, Convert(Datetime, TimeLeave, 114) AS TimeLeave, 
                    EmpID AS org_EmpID, FatraId AS org_FatraId FROM CD_EmpTIME");
                    repositoryItemGridLookUpEditEmpID.DataSource = FXFW.SqlDB.LoadDataTable("SELECT EmpID, Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name From TBL_Emp");
                    repositoryItemGridLookUpEditFatraId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT FatraId, FatraName FROM CD_Ftra");
                    break;
                case TableNames.CDGov:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT GovId, GOV FROM CDGov");
                    break;
                case TableNames.CD_AsaseSalary:
                    dt = SQLProvider.SelectCD_AsaseSalary();
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
            FXFW.SqlDB.GetFormPriv("Emp" + ViewName, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
                    case "gridViewCD_AsaseEmp":
                        DataRow rowgridViewCD_AsaseEmp = gridViewCD_AsaseEmp.GetFocusedDataRow();
                        string HodorTime;
                        if (rowgridViewCD_AsaseEmp["HodorTime"].ToString() == string.Empty)
                            HodorTime = "NULL";
                        else
                            HodorTime = string.Format(@"Convert(Datetime, '{0}', 114)", FXFW.SqlDB.ConvertToDateHMS(rowgridViewCD_AsaseEmp["HodorTime"].ToString()));
                        string EnsrafTime;
                        if (rowgridViewCD_AsaseEmp["EnsrafTime"].ToString() == string.Empty)
                            EnsrafTime = "NULL";
                        else
                            EnsrafTime = string.Format(@"Convert(Datetime, '{0}', 114)", FXFW.SqlDB.ConvertToDateHMS(rowgridViewCD_AsaseEmp["EnsrafTime"].ToString()));
                        string MonthEznNo;
                        if (rowgridViewCD_AsaseEmp["MonthEznNo"].ToString() != string.Empty)
                            MonthEznNo = rowgridViewCD_AsaseEmp["MonthEznNo"].ToString();
                        else
                            MonthEznNo = "0";

                        string SPOS;
                        if (rowgridViewCD_AsaseEmp["SPOS"].ToString() != string.Empty)
                            SPOS = rowgridViewCD_AsaseEmp["SPOS"].ToString();
                        else
                            SPOS = "0";

                        if (rowgridViewCD_AsaseEmp["asase_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_AsaseEmp (asase_code, asase_year, school_allcode, SPOS, HodorTime, EnsrafTime, MonthEznNo)
                            VALUES ((SELECT ISNULL(MAX(asase_code) + 1, 1) FROM CD_AsaseEmp), N'{0}', (Select top 1 SyndicateId From CDSubCommitte Where SubCommitteId = {1}), N'{1}', {2}, {3}, {4})",
                            rowgridViewCD_AsaseEmp["asase_year"], SPOS, HodorTime, EnsrafTime, MonthEznNo);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_AsaseEmp SET asase_year = N'{0}', school_allcode = (Select SyndicateId From CDSubCommitte Where SubCommitteId = {1}), 
                            SPOS = {1}, HodorTime = {2}, EnsrafTime = {3}, MonthEznNo = {4} WHERE (asase_code = {5})",
                            rowgridViewCD_AsaseEmp["asase_year"], SPOS, HodorTime, EnsrafTime, MonthEznNo, rowgridViewCD_AsaseEmp["asase_code"]);
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
                        if (rowgridViewCD_JobDescription["JobId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_EmpJop (JobId, JobNAME, JobNAME_e)
                            VALUES ((SELECT ISNULL(MAX(JobId) + 1, 1) FROM CD_EmpJop), N'{0}', N'{1}')", rowgridViewCD_JobDescription["JobNAME"],
                            rowgridViewCD_JobDescription["JobNAME_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_EmpJop SET JobNAME = N'{0}', JobNAME_e = N'{1}' WHERE (JobId = {2})",
                            rowgridViewCD_JobDescription["JobNAME"], rowgridViewCD_JobDescription["JobNAME_e"], rowgridViewCD_JobDescription["JobId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_EmpJob":
                        DataRow rowggridViewCD_EmpJob = gridViewCD_EmpJob.GetFocusedDataRow();
                        string JobDescriptionId;
                        if (rowggridViewCD_EmpJob["JobId"].ToString() != string.Empty)
                            JobDescriptionId = rowggridViewCD_EmpJob["JobId"].ToString();
                        else
                            JobDescriptionId = "NULL";

                        if (rowggridViewCD_EmpJob["org_JobDescriptionId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_JobDescription (JobDescriptionId, JobDescription, JobDescription_e, JobId)
                            VALUES ((SELECT ISNULL(MAX(JobDescriptionId) + 1, 1) FROM CD_JobDescription), N'{0}', N'{1}', {2})", rowggridViewCD_EmpJob["JobDescription"],
                            rowggridViewCD_EmpJob["JobDescription_e"], JobDescriptionId);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_JobDescription SET JobDescription = N'{0}', JobDescription_e = N'{1}', JobId = {2}  WHERE (JobDescriptionId = {3}) AND (JobId = {4})",
                            rowggridViewCD_EmpJob["JobDescription"], rowggridViewCD_EmpJob["JobDescription_e"], rowggridViewCD_EmpJob["JobId"], rowggridViewCD_EmpJob["org_JobDescriptionId"], rowggridViewCD_EmpJob["org_JobId"]);
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
                    case "gridViewCD_Courses":
                        DataRow rowgridViewCD_Courses= gridViewCD_Courses.GetFocusedDataRow();

                        if (rowgridViewCD_Courses["CourseId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_Courses (CourseId, CourseName, CourseName_e)
                            VALUES ((SELECT ISNULL(MAX(CourseId) + 1, 1) FROM CD_Courses), N'{0}', N'{1}')",
                            rowgridViewCD_Courses["CourseName"], rowgridViewCD_Courses["CourseName_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_Courses SET CourseName = N'{0}', CourseName_e = N'{1}' WHERE (CourseId = {2})",
                            rowgridViewCD_Courses["CourseName"], rowgridViewCD_Courses["CourseName_e"], rowgridViewCD_Courses["CourseId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDPlaceTraining":
                        DataRow rowgridViewCDPlaceTraining = gridViewCDPlaceTraining.GetFocusedDataRow();
                        if (rowgridViewCDPlaceTraining["PlaceTrainingId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDPlaceTraining (PlaceTrainingId, PlaceTrainingName, PlaceTrainingName_e, PlaceTrainingTell, PlaceTrainingemail)
                            VALUES ((SELECT ISNULL(MAX(PlaceTrainingId) + 1, 1) FROM CDPlaceTraining), N'{0}', N'{1}', N'{2}', N'{3}')",
                            rowgridViewCDPlaceTraining["PlaceTrainingName"], rowgridViewCDPlaceTraining["PlaceTrainingName_e"], 
                            rowgridViewCDPlaceTraining["PlaceTrainingTell"], rowgridViewCDPlaceTraining["PlaceTrainingemail"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDPlaceTraining SET PlaceTrainingName = N'{0}', PlaceTrainingName_e = N'{1}', PlaceTrainingTell = N'{2}', PlaceTrainingemail = N'{3}' WHERE (PlaceTrainingId = {4})",
                            rowgridViewCDPlaceTraining["PlaceTrainingName"], rowgridViewCDPlaceTraining["PlaceTrainingName_e"], rowgridViewCDPlaceTraining["PlaceTrainingTell"],
                            rowgridViewCDPlaceTraining["PlaceTrainingemail"], rowgridViewCDPlaceTraining["PlaceTrainingId"]);
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
                    case "gridViewCDTakdeer":
                        DataRow rowgridViewCDTakdeer = gridViewCDTakdeer.GetFocusedDataRow();
                        if (rowgridViewCDTakdeer["TakdeerId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDTakdeer (TakdeerId, TakdeerName, TakdeerName_e)
                            VALUES ((SELECT ISNULL(MAX(TakdeerId) + 1, 1) FROM CDTakdeer), N'{0}', N'{1}')",
                            rowgridViewCDTakdeer["TakdeerName"], rowgridViewCDTakdeer["TakdeerName_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDTakdeer SET TakdeerName = N'{0}', TakdeerName_e = N'{1}' WHERE (TakdeerId = {2})",
                            rowgridViewCDTakdeer["TakdeerName"], rowgridViewCDTakdeer["TakdeerName_e"], rowgridViewCDTakdeer["TakdeerId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_EznType":
                        DataRow rowgridViewCD_EznType = gridViewCD_EznType.GetFocusedDataRow();
                        if (rowgridViewCD_EznType["EznTypeId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_EznType (EznTypeId, EznType, EznType_e)
                            VALUES ((SELECT ISNULL(MAX(EznTypeId) + 1, 1) FROM CD_EznType), N'{0}', N'{1}')",
                            rowgridViewCD_EznType["EznType"], rowgridViewCD_EznType["EznType_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_EznType SET EznType = N'{0}', EznType_e = N'{1}' WHERE (EznTypeId = {2})",
                            rowgridViewCD_EznType["EznType"], rowgridViewCD_EznType["EznType_e"], rowgridViewCD_EznType["EznTypeId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_GzaaType":
                        DataRow rowgridViewCD_GzaaType = gridViewCD_GzaaType.GetFocusedDataRow();
                        if (rowgridViewCD_GzaaType["GzaaTypeId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_GzaaType (GzaaTypeId, GzaaType, GzaaType_e)
                            VALUES ((SELECT ISNULL(MAX(GzaaTypeId) + 1, 1) FROM CD_GzaaType), N'{0}', N'{1}')",
                            rowgridViewCD_GzaaType["GzaaType"], rowgridViewCD_GzaaType["GzaaType_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_GzaaType SET GzaaType = N'{0}', GzaaType_e = N'{1}' WHERE (GzaaTypeId = {2})",
                            rowgridViewCD_GzaaType["GzaaType"], rowgridViewCD_GzaaType["GzaaType_e"], rowgridViewCD_GzaaType["GzaaTypeId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_GehaGazaa":
                        DataRow rowgridViewCD_GehaGazaa = gridViewCD_GehaGazaa.GetFocusedDataRow();
                        if (rowgridViewCD_GehaGazaa["GehaGazaaId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_GehaGazaa (GehaGazaaId, GehaGazaa, GehaGazaa_e)
                            VALUES ((SELECT ISNULL(MAX(GehaGazaaId) + 1, 1) FROM CD_GehaGazaa), N'{0}', N'{1}')",
                            rowgridViewCD_GehaGazaa["GehaGazaa"], rowgridViewCD_GehaGazaa["GehaGazaa_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_GehaGazaa SET GehaGazaa = N'{0}', GehaGazaa_e = N'{1}' WHERE (GehaGazaaId = {2})",
                            rowgridViewCD_GehaGazaa["GehaGazaa"], rowgridViewCD_GehaGazaa["GehaGazaa_e"], rowgridViewCD_GehaGazaa["GehaGazaaId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_EmpTIME":
                        DataRow rowgridViewCD_EmpTIME = gridViewCD_EmpTIME.GetFocusedDataRow();
                        string EmpID;
                        if (rowgridViewCD_EmpTIME["EmpID"].ToString() == string.Empty)
                            EmpID = "NULL";
                        else
                            EmpID = rowgridViewCD_EmpTIME["EmpID"].ToString();
                        string FatraId;
                        if (rowgridViewCD_EmpTIME["FatraId"].ToString() == string.Empty)
                            FatraId = "NULL";
                        else
                            FatraId = rowgridViewCD_EmpTIME["FatraId"].ToString();
                        string TimeAttendance;
                        if (rowgridViewCD_EmpTIME["TimeAttendance"].ToString() == string.Empty)
                            TimeAttendance = "NULL";
                        else
                            TimeAttendance = string.Format(@"Convert(Datetime, '{0}', 114)", FXFW.SqlDB.ConvertToDateHMS(rowgridViewCD_EmpTIME["TimeAttendance"].ToString()));
                        string TimeLeave;
                        if (rowgridViewCD_EmpTIME["TimeLeave"].ToString() == string.Empty)
                            TimeLeave = "NULL";
                        else
                            TimeLeave = string.Format(@"Convert(Datetime, '{0}', 114)", FXFW.SqlDB.ConvertToDateHMS(rowgridViewCD_EmpTIME["TimeLeave"].ToString()));

                        if (rowgridViewCD_EmpTIME["org_EmpID"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_EmpTIME (EmpID, TimeAttendance, TimeLeave, FatraId)
                            VALUES ({0}, {1}, {2}, {3})",
                            EmpID, TimeAttendance, TimeLeave, FatraId);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_EmpTIME SET EmpID = {0}, TimeAttendance = {1}, TimeLeave = {2}, FatraId = {3} WHERE (EmpID = {4}) AND (FatraId = {5})",
                            EmpID, TimeAttendance, TimeLeave, FatraId, rowgridViewCD_EmpTIME["org_EmpID"], rowgridViewCD_EmpTIME["org_FatraId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDGov":
                        DataRow rowgridViewCDGov = gridViewCDGov.GetFocusedDataRow();
                        if (rowgridViewCDGov["GovId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDGov (GovId, GOV)
                            VALUES ((SELECT ISNULL(MAX(GovId) + 1, 1) FROM CDGov), N'{0}')",
                            rowgridViewCDGov["GOV"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDGov SET GOV = N'{0}' WHERE (GovId = {1})",
                            rowgridViewCDGov["GOV"], rowgridViewCDGov["GovId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_AsaseSalary":
                        DataRow rowgridViewCD_AsaseSalary = gridViewCD_AsaseSalary.GetFocusedDataRow();
                        if (rowgridViewCD_AsaseSalary["AsaseSalaryId"].ToString() == string.Empty)
                        {
                            SQLProvider.InsertCD_AsaseSalary(rowgridViewCD_AsaseSalary["AsaseSalary"], DBNull.Value, DBNull.Value, rowgridViewCD_AsaseSalary["FromDate1"],
                                rowgridViewCD_AsaseSalary["ToDate2"], rowgridViewCD_AsaseSalary["Alawa1"], DBNull.Value, DBNull.Value,
                                rowgridViewCD_AsaseSalary["Alawa2"], DBNull.Value, rowgridViewCD_AsaseSalary["Alawa3"], DBNull.Value,
                                rowgridViewCD_AsaseSalary["Alawa4"], DBNull.Value, rowgridViewCD_AsaseSalary["Alawa4"], DBNull.Value, DBNull.Value, DBNull.Value);
                        }
                        else
                        {
                            SQLProvider.UpdateCD_AsaseSalary(rowgridViewCD_AsaseSalary["AsaseSalaryId"], rowgridViewCD_AsaseSalary["AsaseSalary"], DBNull.Value, DBNull.Value, rowgridViewCD_AsaseSalary["FromDate1"],
                                rowgridViewCD_AsaseSalary["ToDate2"], rowgridViewCD_AsaseSalary["Alawa1"], DBNull.Value, DBNull.Value,
                                rowgridViewCD_AsaseSalary["Alawa2"], DBNull.Value, rowgridViewCD_AsaseSalary["Alawa3"], DBNull.Value,
                                rowgridViewCD_AsaseSalary["Alawa4"], DBNull.Value, rowgridViewCD_AsaseSalary["Alawa4"], DBNull.Value, DBNull.Value, DBNull.Value);
                        }
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
                    case "gridViewCD_AsaseEmp":
                        DataRow rowgridViewCD_AsaseEmp = gridViewCD_AsaseEmp.GetFocusedDataRow();
                        if (rowgridViewCD_AsaseEmp["asase_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_AsaseEmp WHERE (asase_code = {0})", rowgridViewCD_AsaseEmp["asase_code"]);
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
                        if (rowgridViewCD_JobDescription["JobId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_EmpJop WHERE (JobId = {0})", rowgridViewCD_JobDescription["JobId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_EmpJob":
                        DataRow rowgridViewCD_EmpJob = gridViewCD_EmpJob.GetFocusedDataRow();
                        if (rowgridViewCD_EmpJob["org_JobDescriptionId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_JobDescription WHERE (JobDescriptionId = {0}) AND (JobId = {1})", rowgridViewCD_EmpJob["org_JobDescriptionId"], rowgridViewCD_EmpJob["org_JobId"]);
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
                    case "gridViewCD_Courses":
                        DataRow rowgridViewCD_Courses = gridViewCD_Courses.GetFocusedDataRow();
                        if (rowgridViewCD_Courses["CourseId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_Courses WHERE (CourseId = {0})", rowgridViewCD_Courses["CourseId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDPlaceTraining":
                        DataRow rowgridViewCDPlaceTraining = gridViewCDPlaceTraining.GetFocusedDataRow();
                        if (rowgridViewCDPlaceTraining["PlaceTrainingId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDPlaceTraining WHERE (PlaceTrainingId = {0})", rowgridViewCDPlaceTraining["PlaceTrainingId"]);
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
                    case "gridViewCDTakdeer":
                        DataRow rowgridViewCDTakdeer = gridViewCDTakdeer.GetFocusedDataRow();
                        if (rowgridViewCDTakdeer["TakdeerId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDTakdeer WHERE (TakdeerId = {0})", rowgridViewCDTakdeer["TakdeerId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_EznType":
                        DataRow rowgridViewCD_EznType = gridViewCD_EznType.GetFocusedDataRow();
                        if (rowgridViewCD_EznType["EznTypeId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_EznType WHERE (EznTypeId = {0})", rowgridViewCD_EznType["EznTypeId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_GzaaType":
                        DataRow rowgridViewCD_GzaaType = gridViewCD_GzaaType.GetFocusedDataRow();
                        if (rowgridViewCD_GzaaType["GzaaTypeId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_GzaaType WHERE (GzaaTypeId = {0})", rowgridViewCD_GzaaType["GzaaTypeId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_GehaGazaa":
                        DataRow rowgridViewCD_GehaGazaa = gridViewCD_GehaGazaa.GetFocusedDataRow();
                        if (rowgridViewCD_GehaGazaa["GehaGazaaId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_GehaGazaa WHERE (GehaGazaaId = {0})", rowgridViewCD_GehaGazaa["GehaGazaaId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_EmpTIME":
                        DataRow rowgridViewCD_EmpTIME = gridViewCD_EmpTIME.GetFocusedDataRow();
                        if (rowgridViewCD_EmpTIME["org_EmpID"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_EmpTIME WHERE (EmpID = {0}) AND (FatraId = {1})", rowgridViewCD_EmpTIME["org_EmpID"], rowgridViewCD_EmpTIME["org_FatraId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDGov":
                        DataRow rowgridViewCDGov = gridViewCDGov.GetFocusedDataRow();
                        if (rowgridViewCDGov["GovId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDGov WHERE (GovId = {0})", rowgridViewCDGov["GovId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_AsaseSalary":
                        DataRow rowgridViewCD_AsaseSalary = gridViewCD_AsaseSalary.GetFocusedDataRow();
                        if (rowgridViewCD_AsaseSalary["AsaseSalaryId"].ToString() != string.Empty)
                            SQLProvider.DeleteCD_AsaseSalary(rowgridViewCD_AsaseSalary["AsaseSalaryId"]);
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
        #endregion
    }
}