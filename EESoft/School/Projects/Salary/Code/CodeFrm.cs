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

namespace Salary
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        DataRow rowgridViewCD_HesaTime = null;
        public bool ExitAfterSave = false;
        public enum TableNames : byte
        {
            All,
            CD_AsaseSalary,
            CD_SarfGeha,
            CDMonth,
            CD_Esthkak,
            CD_Estktaa,
            CD_HesaTime,
            CDSubjectWekly,
            CDPlace,
            TBLNesab,
            TBLTeacherNoDays,
            TBLTeachersPlan,
            CDPlaceTraining,
            CD_AgazaType,
            CDTakdeer,
            CD_EznType,
            CD_GzaaType,
            CD_GehaGazaa
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
                case TableNames.CD_AsaseSalary:
                    gridControlCode.MainView = gridViewCD_AsaseSalary;
                    LoadData(TableNames.CD_AsaseSalary);
                    Text += " تحديد العام المالي";
                    break;
                case TableNames.CD_SarfGeha:
                    gridControlCode.MainView = gridViewCD_SarfGeha;
                     LoadData(TableNames.CD_SarfGeha);
                     Text += "  جهات الصرف";
                    break;
                case TableNames.CDMonth:
                    gridControlCode.MainView = gridViewCDMonth;
                    LoadData(TableNames.CDMonth);
                    Text += "  الشهور";
                    break;
                case TableNames.CD_Esthkak:
                    gridControlCode.MainView = gridViewCD_Esthkak;
                    LoadData(TableNames.CD_Esthkak);
                    Text += "  الاستحقاقات";
                    break;
                case TableNames.CD_Estktaa:
                    gridControlCode.MainView = gridViewCD_Estktaa;
                    LoadData(TableNames.CD_Estktaa);
                    Text += "  الاستقطاعات";
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
                case TableNames.TBLNesab:
                    gridControlCode.MainView = gridViewTBLNesab;
                    LoadData(TableNames.TBLNesab);
                    Text += " نصاب المدرسين";
                    break;
                case TableNames.TBLTeacherNoDays:
                    gridControlCode.MainView = gridViewTBLTeacherNoDays;
                    LoadData(TableNames.TBLTeacherNoDays);
                    Text += " ايام اجازات المدرسين";
                    break;
                case TableNames.TBLTeachersPlan:
                    gridControlCode.MainView = gridViewTBLTeachersPlan;
                    LoadData(TableNames.TBLTeachersPlan);
                    Text += " خطط المدرسين";
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
                default:
                    break;
            }
            
        }
        private void LoadData(TableNames CodeName)
        {
            DataTable dt = new DataTable();
            switch (CodeName)
            {
                case TableNames.CD_AsaseSalary:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT AsaseSalaryId, AsaseSalary, school_allcode, AsaseDate, FromDate1, ToDate2, Alawa1, DateAlawa1, DateAlawa2, Alawa2, 
                    DateAlawa3, Alawa3, DateAlawa4, Alawa4, Alawa5, DateAlawa5, MokafaDayes, MinAsaseMokafa, MinMokafa FROM CD_AsaseSalary");
                    repositoryItemGridLookUpEditSPOS.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT school_allcode, school_allname, school_allname_e FROM TBLSCHOOLALL");
                    break;
                case TableNames.CD_SarfGeha:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT SarfGehaId, SarfGeha FROM CD_SarfGeha");
                    break;
                case TableNames.CDMonth:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT month_code, month_name, month_name_e FROM CDMonth");
                    break;
                case TableNames.CD_Esthkak:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EsthkakId, Esthkak, EsthkakTypeId, EsthkakNesba, EsthkakMony FROM CD_Esthkak");
                    repositoryItemGridLookUpEditEsthkakTypeId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EsthkakTypeId, EsthkakType FROM CD_EsthkakType");
                    break;
                case TableNames.CD_Estktaa:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EstktaaId, Estktaa, EstktaaTypeId, EstktaaNesba, EstktaaMony FROM CD_Estktaa");
                    repositoryItemGridLookUpEditEsthkakTypeId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EsthkakTypeId, EsthkakType FROM CD_EsthkakType");
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
                case TableNames.TBLNesab:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, EmpID, nesabfealy, nesabedafy, rem,
                    asase_code AS org_asase_code, EmpID AS org_EmpID FROM gdw.TBLNesab WHERE asase_code = " + FXFW.SqlDB.asase_code);
                    repositoryItemGridLookUpEditEmpID.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
                    ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '')  AS emp_name
                    FROM TBL_Emp"); 
                    break;
                case TableNames.TBLTeacherNoDays:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, daycode, hasa_code,
                    EmpID AS org_EmpID, daycode AS org_daycode, hasa_code AS org_hasa_code FROM TBLTeacherNoDays");
                    repositoryItemGridLookUpEditEmpID.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
                    ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '')  AS emp_name
                    FROM TBL_Emp"); 
                    repositoryItemGridLookUpEditdaycode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    repositoryItemGridLookUpEdithasa_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e FROM CDAlhasas");
                    break;
                case TableNames.TBLTeachersPlan:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, EmpID, alsofof_code, fasl_code, SubjectId FROM gdw.TBLTeachersPlan Where asase_code = " + FXFW.SqlDB.asase_code);
                    repositoryItemGridLookUpEditEmpID.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
                    ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '')  AS emp_name
                    FROM TBL_Emp");
                    repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable("Select alsofof_code, alsofof_name, alsofof_name_e FROM CDAlsofof");
                    repositoryItemGridLookUpEditfasl_code.DataSource = FXFW.SqlDB.LoadDataTable("Select fasl_code, fasl_name, fasl_name_e FROM CDAlsofof"); 
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
            FXFW.SqlDB.GetFormPriv("Salary" + ViewName.ToString(), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
                    case "gridViewCD_AsaseSalary":
                        DataRow rowgridViewCD_AsaseSalary = gridViewCD_AsaseSalary.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@AsaseSalary", SqlDbType.NVarChar) { Value = rowgridViewCD_AsaseSalary["AsaseSalary"] });
                        cmd.Parameters.Add(new SqlParameter("@school_allcode", SqlDbType.Float) { Value = rowgridViewCD_AsaseSalary["school_allcode"] });
                        cmd.Parameters.Add(new SqlParameter("@AsaseDate", SqlDbType.Date) { Value = rowgridViewCD_AsaseSalary["AsaseDate"] });
                        cmd.Parameters.Add(new SqlParameter("@FromDate1", SqlDbType.Date) { Value = rowgridViewCD_AsaseSalary["FromDate1"] });
                        cmd.Parameters.Add(new SqlParameter("@ToDate2", SqlDbType.Date) { Value = rowgridViewCD_AsaseSalary["ToDate2"] });
                        cmd.Parameters.Add(new SqlParameter("@Alawa1", SqlDbType.NVarChar) { Value = rowgridViewCD_AsaseSalary["Alawa1"] });
                        cmd.Parameters.Add(new SqlParameter("@DateAlawa1", SqlDbType.Date) { Value = rowgridViewCD_AsaseSalary["DateAlawa1"] });
                        cmd.Parameters.Add(new SqlParameter("@Alawa2", SqlDbType.NVarChar) { Value = rowgridViewCD_AsaseSalary["Alawa2"] });
                        cmd.Parameters.Add(new SqlParameter("@DateAlawa2", SqlDbType.Date) { Value = rowgridViewCD_AsaseSalary["DateAlawa2"] });
                        cmd.Parameters.Add(new SqlParameter("@Alawa3", SqlDbType.NVarChar) { Value = rowgridViewCD_AsaseSalary["Alawa3"] });
                        cmd.Parameters.Add(new SqlParameter("@DateAlawa3", SqlDbType.Date) { Value = rowgridViewCD_AsaseSalary["DateAlawa3"] });
                        cmd.Parameters.Add(new SqlParameter("@Alawa4", SqlDbType.NVarChar) { Value = rowgridViewCD_AsaseSalary["Alawa4"] });
                        cmd.Parameters.Add(new SqlParameter("@DateAlawa4", SqlDbType.Date) { Value = rowgridViewCD_AsaseSalary["DateAlawa4"] });
                        cmd.Parameters.Add(new SqlParameter("@Alawa5", SqlDbType.NVarChar) { Value = rowgridViewCD_AsaseSalary["Alawa5"] });
                        cmd.Parameters.Add(new SqlParameter("@DateAlawa5", SqlDbType.Date) { Value = rowgridViewCD_AsaseSalary["DateAlawa5"] });
                        cmd.Parameters.Add(new SqlParameter("@MokafaDayes", SqlDbType.Int) { Value = rowgridViewCD_AsaseSalary["MokafaDayes"] });
                        cmd.Parameters.Add(new SqlParameter("@MinAsaseMokafa", SqlDbType.Float) { Value = rowgridViewCD_AsaseSalary["MinAsaseMokafa"] });
                        cmd.Parameters.Add(new SqlParameter("@MinMokafa", SqlDbType.Float) { Value = rowgridViewCD_AsaseSalary["MinMokafa"] });
                        
                        if (rowgridViewCD_AsaseSalary["AsaseSalaryId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO CD_AsaseSalary
                            (AsaseSalaryId, AsaseSalary, school_allcode, AsaseDate, FromDate1, ToDate2, Alawa1, DateAlawa1, Alawa2, DateAlawa2, Alawa3, DateAlawa3, Alawa4, DateAlawa4, Alawa5, DateAlawa5, MokafaDayes, MinAsaseMokafa, MinMokafa)
                            VALUES ((SELECT ISNULL(MAX(AsaseSalaryId) + 1, 1) FROM CD_AsaseSalary), @AsaseSalary, @school_allcode, @AsaseDate, @FromDate1, @ToDate2, @Alawa1, @DateAlawa1, @Alawa2, @DateAlawa2, @Alawa3, @DateAlawa3, 
                            @Alawa4, @DateAlawa4, @Alawa5, @DateAlawa5, @MokafaDayes, @MinAsaseMokafa, @MinMokafa)";
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_AsaseSalary SET AsaseSalary = @AsaseSalary, school_allcode = @school_allcode, AsaseDate = @AsaseDate, FromDate1 = @FromDate1, ToDate2 = @ToDate2, Alawa1 = @Alawa1,
                            DateAlawa1 = @DateAlawa1, Alawa2 = @Alawa2, DateAlawa2 = @DateAlawa2, Alawa3 = @Alawa3, DateAlawa3 = @DateAlawa3, Alawa4 = @Alawa4, DateAlawa4 = @DateAlawa4, Alawa5 = @Alawa5, DateAlawa5 = @DateAlawa5, 
                            MokafaDayes = @MokafaDayes, MinAsaseMokafa = @MinAsaseMokafa, MinMokafa = @MinMokafa WHERE (AsaseSalaryId = @AsaseSalaryId)");
                            cmd.Parameters.Add(new SqlParameter("@AsaseSalaryId", SqlDbType.Int) { Value = rowgridViewCD_AsaseSalary["AsaseSalaryId"] });
                        }
                        cmd.ExecuteNonQuery();
                        if (ExitAfterSave) // this should fire only when i call cd_year for 1st time application run
                            Application.Restart();
                        ((MainFrm)this.ParentForm).LoadCD_AsaseSalary();
                        break;
                    case "gridViewCD_SarfGeha":
                        DataRow rowgridViewCD_SarfGeha = gridViewCD_SarfGeha.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@SarfGeha", SqlDbType.NVarChar) { Value = rowgridViewCD_SarfGeha["SarfGeha"] });

                        if (rowgridViewCD_SarfGeha["SarfGehaId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO CD_SarfGeha (SarfGehaId, SarfGeha) VALUES ((SELECT ISNULL(MAX(SarfGehaId) + 1, 1) FROM CD_SarfGeha), @SarfGeha)";
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE CD_SarfGeha SET SarfGeha = @SarfGeha WHERE (SarfGehaId = @SarfGehaId)";
                            cmd.Parameters.Add(new SqlParameter("@SarfGehaId", SqlDbType.TinyInt) { Value = rowgridViewCD_SarfGeha["SarfGehaId"] });
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDMonth":
                        DataRow rowgridViewCDMonth = gridViewCDMonth.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@month_name", SqlDbType.NVarChar) { Value = rowgridViewCDMonth["month_name"] });
                        cmd.Parameters.Add(new SqlParameter("@month_name_e", SqlDbType.NVarChar) { Value = rowgridViewCDMonth["month_name_e"] });
                        if (rowgridViewCDMonth["month_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO CDMonth (month_code, month_name, month_name_e) VALUES ((SELECT ISNULL(MAX(month_code) + 1, 1) FROM CDMonth), @month_name, @month_name_e)";
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE CDMonth SET month_name = @month_name, month_name_e = @month_name_e WHERE (month_code = @month_code)";
                            cmd.Parameters.Add(new SqlParameter("@month_code", SqlDbType.TinyInt) { Value = rowgridViewCDMonth["month_code"] });
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_Esthkak":
                        DataRow rowggridViewCD_Esthkak = gridViewCD_Esthkak.GetFocusedDataRow();

                        cmd.Parameters.Add(new SqlParameter("@Esthkak", SqlDbType.NVarChar) { Value = rowggridViewCD_Esthkak["Esthkak"] });
                        cmd.Parameters.Add(new SqlParameter("@EsthkakTypeId", SqlDbType.TinyInt) { Value = rowggridViewCD_Esthkak["EsthkakTypeId"] });
                        cmd.Parameters.Add(new SqlParameter("@EsthkakNesba", SqlDbType.Float) { Value = rowggridViewCD_Esthkak["EsthkakNesba"] });
                        cmd.Parameters.Add(new SqlParameter("@EsthkakMony", SqlDbType.Float) { Value = rowggridViewCD_Esthkak["EsthkakMony"] });

                        if (rowggridViewCD_Esthkak["EsthkakId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO CD_Esthkak (EsthkakId, Esthkak, EsthkakTypeId, EsthkakNesba, EsthkakMony) VALUES 
                            ((SELECT ISNULL(MAX(EsthkakId) + 1, 1) FROM CD_Esthkak), @Esthkak, @EsthkakTypeId, @EsthkakNesba, @EsthkakMony)";
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@EsthkakId", SqlDbType.TinyInt) { Value = rowggridViewCD_Esthkak["EsthkakId"] });
                            cmd.CommandText = @"UPDATE CD_Esthkak SET Esthkak = @Esthkak, EsthkakTypeId = @EsthkakTypeId, EsthkakNesba = @EsthkakNesba, EsthkakMony = @EsthkakMony
                            WHERE (EsthkakId = @EsthkakId)";
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_Estktaa":
                        DataRow rowgridViewCD_Estktaa = gridViewCD_Estktaa.GetFocusedDataRow();

                        cmd.Parameters.Add(new SqlParameter("@Estktaa", SqlDbType.NVarChar) { Value = rowgridViewCD_Estktaa["Estktaa"] });
                        cmd.Parameters.Add(new SqlParameter("@EstktaaTypeId", SqlDbType.TinyInt) { Value = rowgridViewCD_Estktaa["EstktaaTypeId"] });
                        cmd.Parameters.Add(new SqlParameter("@EstktaaNesba", SqlDbType.Float) { Value = rowgridViewCD_Estktaa["EstktaaNesba"] });
                        cmd.Parameters.Add(new SqlParameter("@EstktaaMony", SqlDbType.Float) { Value = rowgridViewCD_Estktaa["EstktaaMony"] });

                        if (rowgridViewCD_Estktaa["EstktaaId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO CD_Estktaa (EstktaaId, Estktaa, EstktaaTypeId, EstktaaNesba, EstktaaMony) VALUES 
                            ((SELECT ISNULL(MAX(EstktaaId) + 1, 1) FROM CD_Estktaa), @Estktaa, @EstktaaTypeId, @EstktaaNesba, @EstktaaMony)";
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@EstktaaId", SqlDbType.TinyInt) { Value = rowgridViewCD_Estktaa["EstktaaId"] });
                            cmd.CommandText = @"UPDATE CD_Estktaa SET Estktaa = @Estktaa, EstktaaTypeId = @EstktaaTypeId, EstktaaNesba = @EstktaaNesba, EstktaaMony = @EstktaaMony
                            WHERE (EstktaaId = @EstktaaId)";
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
                    case "gridViewTBLNesab":
                        DataRow rowgridViewTBLNesab = gridViewTBLNesab.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = FXFW.SqlDB.asase_code});
                        cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = rowgridViewTBLNesab["EmpID"] });
                        cmd.Parameters.Add(new SqlParameter("@nesabfealy", SqlDbType.TinyInt) { Value = rowgridViewTBLNesab["nesabfealy"] });
                        cmd.Parameters.Add(new SqlParameter("@nesabedafy", SqlDbType.TinyInt) { Value = rowgridViewTBLNesab["nesabedafy"] });
                        cmd.Parameters.Add(new SqlParameter("@rem", SqlDbType.NVarChar) { Value = rowgridViewTBLNesab["rem"] });
                        if (rowgridViewTBLNesab["org_EmpID"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO gdw.TBLNesab (asase_code, EmpID, nesabfealy, nesabedafy, rem)
                            VALUES (@asase_code, @EmpID, @nesabfealy, @nesabedafy, @rem)";
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE gdw.TBLNesab SET asase_code = @asase_code, EmpID = @EmpID, nesabfealy = @nesabfealy, nesabedafy = @nesabedafy, rem = @rem
                            WHERE asase_code = @org_asase_code AND EmpID = @org_EmpID";
                            cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = rowgridViewTBLNesab["org_asase_code"] });
                            cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLNesab["org_EmpID"] });
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewTBLTeacherNoDays":
                        DataRow rowgridViewTBLTeacherNoDays = gridViewTBLTeacherNoDays.GetFocusedDataRow();
                        cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["EmpID"] });
                        cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["daycode"] });
                        cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["hasa_code"] });
                        if (rowgridViewTBLTeacherNoDays["org_EmpID"].ToString() == string.Empty)
                            cmd.CommandText = @"INSERT INTO TBLTeacherNoDays (EmpID, daycode, hasa_code) VALUES (@EmpID, @daycode, @hasa_code)";
                        else
                        {
                            cmd.CommandText = @"UPDATE TBLTeacherNoDays SET EmpID = @EmpID, daycode = @daycode, hasa_code = @hasa_code
                            WHERE (EmpID = @org_EmpID) AND (daycode = @org_daycode) AND (hasa_code = @org_hasa_code)";
                            cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_EmpID"] });
                            cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_daycode"] });
                            cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_hasa_code"] });
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewTBLTeachersPlan":
                        DataRow rowgridViewTBLTeachersPlan= gridViewTBLTeachersPlan.GetFocusedDataRow();

                        if (rowgridViewTBLTeachersPlan["CourseId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_Courses (CourseId, CourseName, CourseName_e)
                            VALUES ((SELECT ISNULL(MAX(CourseId) + 1, 1) FROM CD_Courses), N'{0}', N'{1}')",
                            rowgridViewTBLTeachersPlan["CourseName"], rowgridViewTBLTeachersPlan["CourseName_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_Courses SET CourseName = N'{0}', CourseName_e = N'{1}' WHERE (CourseId = {2})",
                            rowgridViewTBLTeachersPlan["CourseName"], rowgridViewTBLTeachersPlan["CourseName_e"], rowgridViewTBLTeachersPlan["CourseId"]);
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
                    case "gridViewCD_AsaseSalary":
                        DataRow rowgridViewCD_AsaseSalary = gridViewCD_AsaseSalary.GetFocusedDataRow();
                        if (rowgridViewCD_AsaseSalary["AsaseSalaryId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_AsaseSalary WHERE (AsaseSalaryId = {0})", rowgridViewCD_AsaseSalary["AsaseSalaryId"]);
                            cmd.ExecuteNonQuery();
                            ((MainFrm)this.ParentForm).LoadCD_AsaseSalary();
                        }
                        break;
                    case "gridViewCD_SarfGeha":
                        DataRow rowgridViewCD_SarfGeha = gridViewCD_SarfGeha.GetFocusedDataRow();
                        if (rowgridViewCD_SarfGeha["SarfGehaId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = @"DELETE FROM CD_SarfGeha WHERE (SarfGehaId = @SarfGehaId)";
                            cmd.Parameters.Add(new SqlParameter("@SarfGehaId", SqlDbType.TinyInt) { Value = rowgridViewCD_SarfGeha["SarfGehaId"] });
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDMonth":
                        DataRow rowgridViewCDMonth = gridViewCDMonth.GetFocusedDataRow();
                        if (rowgridViewCDMonth["month_code"].ToString() != string.Empty)
                        {
                            cmd.Parameters.Add(new SqlParameter("@month_code", SqlDbType.TinyInt) { Value = rowgridViewCDMonth["month_code"] });
                            cmd.CommandText = @"DELETE FROM CDMonth WHERE (month_code = @month_code)";
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_Esthkak":
                        DataRow rowgridViewCD_Esthkak = gridViewCD_Esthkak.GetFocusedDataRow();
                        if (rowgridViewCD_Esthkak["EsthkakId"].ToString() != string.Empty)
                        {
                            cmd.Parameters.Add(new SqlParameter("@EsthkakId", SqlDbType.TinyInt) { Value = rowgridViewCD_Esthkak["EsthkakId"] });
                            cmd.CommandText = @"DELETE FROM CD_Esthkak WHERE (EsthkakId = @EsthkakId)";
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_Estktaa":
                        DataRow rowgridViewCD_Estktaa = gridViewCD_Estktaa.GetFocusedDataRow();
                        if (rowgridViewCD_Estktaa["EstktaaId"].ToString() != string.Empty)
                        {
                            cmd.Parameters.Add(new SqlParameter("@EstktaaId", SqlDbType.TinyInt) { Value = rowgridViewCD_Estktaa["EstktaaId"] });
                            cmd.CommandText = @"DELETE FROM CD_Estktaa WHERE (EstktaaId = @EstktaaId)";
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
                    case "gridViewTBLNesab":
                        DataRow rowgridViewTBLNesab = gridViewTBLNesab.GetFocusedDataRow();
                        if (rowgridViewTBLNesab["org_EmpID"].ToString() != string.Empty)
                        {
                            cmd.CommandText = @"DELETE FROM gdw.TBLNesab WHERE asase_code = @org_asase_code AND EmpID = @org_EmpID";
                            cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.Int) { Value = rowgridViewTBLNesab["org_asase_code"] });
                            cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLNesab["org_EmpID"] });
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewTBLTeacherNoDays":
                        DataRow rowgridViewTBLTeacherNoDays = gridViewTBLTeacherNoDays.GetFocusedDataRow();
                        if (rowgridViewTBLTeacherNoDays["org_EmpID"].ToString() != string.Empty)
                        {
                            cmd.CommandText = @"DELETE FROM TBLTeacherNoDays WHERE (EmpID = @org_EmpID) AND (daycode = @org_daycode) AND (hasa_code = @org_hasa_code)";
                            cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_EmpID"] });
                            cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_daycode"] });
                            cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_hasa_code"] });
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_Courses":
                        DataRow rowgridViewCD_Courses = gridViewTBLTeachersPlan.GetFocusedDataRow();
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