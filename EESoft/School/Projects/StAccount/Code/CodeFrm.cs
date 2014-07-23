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

namespace StAccount
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        public enum TableNames : byte
        {
            All,
            CD_AsaseACC,
            CD_PayType,
            CD_PayTypeDetiel,
            CD_PayMony,
            CD_Discounts,
            CD_KastNo,
            CD_KastSaf,
            CD_KastBnood,
            CD_Specialization,
            CD_MaritalStatus,
            CD_Courses,
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
                case TableNames.CD_AsaseACC:
                    gridControlCode.MainView = gridViewCD_AsaseACC;
                    LoadData(TableNames.CD_AsaseACC);
                    Text += " تحديد العام الدراسي";
                    break;
                case TableNames.CD_PayType:
                    gridControlCode.MainView = gridViewCD_PayType;
                     LoadData(TableNames.CD_PayType);
                     Text += " انواع التحصيل";
                    break;
                case TableNames.CD_PayTypeDetiel:
                    gridControlCode.MainView = gridViewCD_PayTypeDetiel;
                    LoadData(TableNames.CD_PayTypeDetiel);
                    Text += " بنود التحصيل";
                    break;
                case TableNames.CD_PayMony:
                    gridControlCode.MainView = gridViewCD_PayMony;
                    LoadData(TableNames.CD_PayMony);
                    Text += " مبالغ الانشطه";
                    break;
                case TableNames.CD_Discounts:
                    gridControlCode.MainView = gridViewCD_Discounts;
                    LoadData(TableNames.CD_Discounts);
                    Text += " اكواد الخصومات";
                    break;
                case TableNames.CD_KastNo:
                    gridControlCode.MainView = gridViewCD_KastNo;
                    LoadData(TableNames.CD_KastNo);
                    Text += " اكواد الاقساط";
                    break;
                case TableNames.CD_KastSaf:
                    gridControlCode.MainView = gridViewCD_KastSaf;
                    LoadData(TableNames.CD_KastSaf);
                    Text += " مبالغ القسط للصفوف";
                    break;
                case TableNames.CD_KastBnood:
                    gridControlCode.MainView = gridViewCD_KastBnood;
                    LoadData(TableNames.CD_KastBnood);
                    Text += " بنود القسط";
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
                default:
                    break;
            }
            
        }
        private void LoadData(TableNames CodeName)
        {
            DataTable dt = new DataTable();
            switch (CodeName)
            {
                case TableNames.CD_AsaseACC:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, school_allcode, SPOS, 
                    (Select school_allname From TBLSCHOOLALL Where school_allcode = CD_AsaseACC.school_allcode) AS school_allname FROM CD_AsaseACC");
                    repositoryItemGridLookUpEditSPOS.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SPOS, SCHOOL, SCHOOl_e, school_allcode FROM TBLSCHOOL");
                    break;
                case TableNames.CD_PayType:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT PayTypeId, PayType, Additional FROM CD_PayType");
                    break;
                case TableNames.CD_PayTypeDetiel:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT PayTypeDetielId, PayTypeDetiel, PayTypeId FROM CD_PayTypeDetiel");
                    repositoryItemGridLookUpEditPayTypeId.DataSource = FXFW.SqlDB.LoadDataTable("SELECT PayTypeId, PayType, Additional FROM CD_PayType"); 
                    break;
                case TableNames.CD_PayMony:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, PayTypeDetielId, alsofof_code, PayMony, (Select asase_year From CD_AsaseACC Where asase_code = CD_PayMony.asase_code) AS asase_year, 
                    asase_code AS asase_code_SRC, PayTypeDetielId AS PayTypeDetielId_SRC, alsofof_code AS alsofof_code_SRC FROM CD_PayMony WHERE asase_code = " + FXFW.SqlDB.asase_code);
                    repositoryItemGridLookUpEditPayTypeDetielId.DataSource = FXFW.SqlDB.LoadDataTable("Select PayTypeDetielId, PayTypeDetiel FROM CD_PayTypeDetiel");
                    repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable("Select alsofof_code, alsofof_name FROM CDAlsofof"); 
                    break;
                case TableNames.CD_Discounts:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT DiscountsId, Discounts, PayTypeDetielId, Percentage FROM CD_Discounts");
                    repositoryItemGridLookUpEditPayTypeDetielId.DataSource = FXFW.SqlDB.LoadDataTable("Select PayTypeDetielId, PayTypeDetiel FROM CD_PayTypeDetiel");
                    break;
                case TableNames.CD_KastNo:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT KastNoId, KastName FROM CD_KastNo");
                    break;
                case TableNames.CD_KastSaf:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT KastNoId, alsofof_code, KastSafMony, KastNoId AS KastNoId_SRC, alsofof_code AS alsofof_code_SRC FROM CD_KastSaf");
                    repositoryItemGridLookUpEditKastNoId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT KastNoId, KastName FROM CD_KastNo");
                    repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable("Select alsofof_code, alsofof_name FROM CDAlsofof"); 
                    break;
                case TableNames.CD_KastBnood:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT KastNoId, PayTypeDetielId, Awlawea, KastNoId AS KastNoId_SRC, PayTypeDetielId AS PayTypeDetielId_SRC FROM CD_KastBnood");
                    repositoryItemGridLookUpEditKastNoId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT KastNoId, KastName FROM CD_KastNo");
                    repositoryItemGridLookUpEditPayTypeDetielId.DataSource = FXFW.SqlDB.LoadDataTable("Select PayTypeDetielId, PayTypeDetiel FROM CD_PayTypeDetiel");
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
            FXFW.SqlDB.GetFormPriv("StAcc" + ViewName.ToString(), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
                    case "gridViewCD_AsaseACC":
                        DataRow rowgridViewCD_AsaseACC = gridViewCD_AsaseACC.GetFocusedDataRow();

                        if (rowgridViewCD_AsaseACC["asase_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_AsaseACC (asase_code, asase_year, school_allcode, SPOS)
                            VALUES ((SELECT ISNULL(MAX(asase_code) + 1, 1) FROM CD_AsaseACC), N'{0}', (Select school_allcode From TBLSCHOOL Where SPOS = {1}), {1})",
                            rowgridViewCD_AsaseACC["asase_year"], rowgridViewCD_AsaseACC["SPOS"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_AsaseACC SET asase_year = N'{0}', school_allcode = (Select school_allcode From TBLSCHOOL Where SPOS = {1}), 
                            SPOS = {1} WHERE (asase_code = {2})",
                            rowgridViewCD_AsaseACC["asase_year"], rowgridViewCD_AsaseACC["SPOS"], rowgridViewCD_AsaseACC["asase_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        ((MainFrm)this.ParentForm).LoadCD_AsaseACC();
                        break;
                    case "gridViewCD_PayType":
                        DataRow rowgridViewCD_PayType = gridViewCD_PayType.GetFocusedDataRow();
                        if (rowgridViewCD_PayType["PayTypeId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_PayType (PayTypeId, PayType, Additional)
                            VALUES ((SELECT ISNULL(MAX(PayTypeId) + 1, 1) FROM CD_PayType), N'{0}','{1}')",
                            rowgridViewCD_PayType["PayType"], rowgridViewCD_PayType["Additional"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_PayType SET PayType = N'{0}', Additional = '{1}' WHERE (PayTypeId = {2})",
                            rowgridViewCD_PayType["PayType"], rowgridViewCD_PayType["Additional"], rowgridViewCD_PayType["PayTypeId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_PayTypeDetiel":
                        DataRow rowgridViewCD_PayTypeDetiel = gridViewCD_PayTypeDetiel.GetFocusedDataRow();
                        string PayTypeId;
                        if (rowgridViewCD_PayTypeDetiel["PayTypeId"].ToString() != string.Empty)
                            PayTypeId = rowgridViewCD_PayTypeDetiel["PayTypeId"].ToString();
                        else
                            PayTypeId = "NULL";
                        if (rowgridViewCD_PayTypeDetiel["PayTypeDetielId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_PayTypeDetiel (PayTypeDetielId, PayTypeDetiel, PayTypeId)
                            VALUES ((SELECT ISNULL(MAX(PayTypeDetielId) + 1, 1) FROM CD_PayTypeDetiel), N'{0}', {1})", rowgridViewCD_PayTypeDetiel["PayTypeDetiel"], PayTypeId);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_PayTypeDetiel SET PayTypeDetiel = N'{0}', PayTypeId = {1} WHERE (PayTypeDetielId = {2})",
                            rowgridViewCD_PayTypeDetiel["PayTypeDetiel"], PayTypeId, rowgridViewCD_PayTypeDetiel["PayTypeDetielId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_PayMony":
                        DataRow rowggridViewCD_PayMony = gridViewCD_PayMony.GetFocusedDataRow();

                        string PayTypeDetielId;
                        if (rowggridViewCD_PayMony["PayTypeDetielId"].ToString() != string.Empty)
                            PayTypeDetielId = rowggridViewCD_PayMony["PayTypeDetielId"].ToString();
                        else
                            PayTypeDetielId = "NULL";

                        string alsofof_code;
                        if (rowggridViewCD_PayMony["alsofof_code"].ToString() != string.Empty)
                            alsofof_code = rowggridViewCD_PayMony["alsofof_code"].ToString();
                        else
                            alsofof_code = "NULL";

                        string PayMony;
                        if (rowggridViewCD_PayMony["PayMony"].ToString() != string.Empty)
                            PayMony = rowggridViewCD_PayMony["PayMony"].ToString();
                        else
                            PayMony = "0";

                        if (rowggridViewCD_PayMony["asase_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_PayMony (asase_code, PayTypeDetielId, alsofof_code, PayMony)
                            VALUES ({0}, {1}, {2}, {3})", FXFW.SqlDB.asase_code, PayTypeDetielId, alsofof_code, PayMony);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_PayMony SET asase_code = {0}, PayTypeDetielId = {1}, alsofof_code = {2}, PayMony = {3}  
                            WHERE (asase_code = {4}) AND (PayTypeDetielId = {5}) AND (alsofof_code = {6})", FXFW.SqlDB.asase_code, PayTypeDetielId, alsofof_code, PayMony,
                            rowggridViewCD_PayMony["asase_code_SRC"], rowggridViewCD_PayMony["PayTypeDetielId_SRC"], rowggridViewCD_PayMony["alsofof_code_SRC"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_Discounts":
                        DataRow rowgridViewCD_Discounts = gridViewCD_Discounts.GetFocusedDataRow();
                        string PayTypeDetielId_;
                        if (rowgridViewCD_Discounts["PayTypeDetielId"].ToString() != string.Empty)
                            PayTypeDetielId_ = rowgridViewCD_Discounts["PayTypeDetielId"].ToString();
                        else
                            PayTypeDetielId_ = "NULL";
                        string Percentage;
                        if (rowgridViewCD_Discounts["Percentage"].ToString() != string.Empty)
                            Percentage = rowgridViewCD_Discounts["Percentage"].ToString();
                        else
                            Percentage = "0";

                        if (rowgridViewCD_Discounts["DiscountsId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_Discounts (DiscountsId, Discounts, PayTypeDetielId, Percentage)
                            VALUES ((SELECT ISNULL(MAX(DiscountsId) + 1, 1) FROM CD_Discounts), N'{0}', {1}, {2})", rowgridViewCD_Discounts["Discounts"], PayTypeDetielId_, Percentage);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_Discounts SET Discounts = N'{0}', PayTypeDetielId = {1}, Percentage = {2} WHERE (DiscountsId = {3})",
                            rowgridViewCD_Discounts["Discounts"], PayTypeDetielId_, Percentage, rowgridViewCD_Discounts["DiscountsId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_KastNo":
                        DataRow rowgridViewCD_KastNo = gridViewCD_KastNo.GetFocusedDataRow();
                        if (rowgridViewCD_KastNo["KastNoId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CD_KastNo (KastNoId, KastName)
                            VALUES ((SELECT ISNULL(MAX(KastNoId) + 1, 1) FROM CD_KastNo), N'{0}')", rowgridViewCD_KastNo["KastName"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CD_KastNo SET KastName = N'{0}' WHERE (KastNoId = {1})",
                            rowgridViewCD_KastNo["KastName"], rowgridViewCD_KastNo["KastNoId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_KastSaf":
                        DataRow rowgridViewCD_KastSaf = gridViewCD_KastSaf.GetFocusedDataRow();
                        if (rowgridViewCD_KastSaf["KastNoId_SRC"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO CD_KastSaf (KastNoId, alsofof_code, KastSafMony) VALUES (@KastNoId, @alsofof_code, @KastSafMony)";
                            cmd.Parameters.Add(new SqlParameter("@KastNoId", SqlDbType.Int) { Value = rowgridViewCD_KastSaf["KastNoId"] });
                            cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.Int) { Value = rowgridViewCD_KastSaf["alsofof_code"] });
                            cmd.Parameters.Add(new SqlParameter("@KastSafMony", SqlDbType.Decimal) { Value = rowgridViewCD_KastSaf["KastSafMony"] });
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE CD_KastSaf SET KastNoId = @KastNoId, alsofof_code = @alsofof_code, KastSafMony = @KastSafMony 
                            WHERE (KastNoId = @KastNoId_SRC) And (alsofof_code = @alsofof_code_SRC)";
                            cmd.Parameters.Add(new SqlParameter("@KastNoId", SqlDbType.Int) { Value = rowgridViewCD_KastSaf["KastNoId"] });
                            cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.Int) { Value = rowgridViewCD_KastSaf["alsofof_code"] });
                            cmd.Parameters.Add(new SqlParameter("@KastSafMony", SqlDbType.Decimal) { Value = rowgridViewCD_KastSaf["KastSafMony"] });
                            cmd.Parameters.Add(new SqlParameter("@KastNoId_SRC", SqlDbType.Int) { Value = rowgridViewCD_KastSaf["KastNoId_SRC"] });
                            cmd.Parameters.Add(new SqlParameter("@alsofof_code_SRC", SqlDbType.Int) { Value = rowgridViewCD_KastSaf["alsofof_code_SRC"] });
                            
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCD_KastBnood":
                        DataRow rowgridViewCD_KastBnood = gridViewCD_KastBnood.GetFocusedDataRow();
                        if (rowgridViewCD_KastBnood["KastNoId_SRC"].ToString() == string.Empty)
                        {
                            cmd.CommandText = @"INSERT INTO CD_KastBnood (KastNoId, PayTypeDetielId, Awlawea) VALUES (@KastNoId, @PayTypeDetielId, @Awlawea)";
                            cmd.Parameters.Add(new SqlParameter("@KastNoId", SqlDbType.Int) { Value = rowgridViewCD_KastBnood["KastNoId"] });
                            cmd.Parameters.Add(new SqlParameter("@PayTypeDetielId", SqlDbType.Int) { Value = rowgridViewCD_KastBnood["PayTypeDetielId"] });
                            cmd.Parameters.Add(new SqlParameter("@Awlawea", SqlDbType.NVarChar) { Value = rowgridViewCD_KastBnood["Awlawea"] });
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE CD_KastBnood SET KastNoId = @KastNoId, PayTypeDetielId = @PayTypeDetielId, Awlawea = @Awlawea
                            WHERE (KastNoId = @KastNoId_SRC) And (@PayTypeDetielId = @PayTypeDetielId_SRC)";
                            cmd.Parameters.Add(new SqlParameter("@KastNoId", SqlDbType.Int) { Value = rowgridViewCD_KastBnood["KastNoId"] });
                            cmd.Parameters.Add(new SqlParameter("@PayTypeDetielId", SqlDbType.Int) { Value = rowgridViewCD_KastBnood["PayTypeDetielId"] });
                            cmd.Parameters.Add(new SqlParameter("@Awlawea", SqlDbType.NVarChar) { Value = rowgridViewCD_KastBnood["Awlawea"] });
                            cmd.Parameters.Add(new SqlParameter("@KastNoId_SRC", SqlDbType.Int) { Value = rowgridViewCD_KastBnood["KastNoId_SRC"] });
                            cmd.Parameters.Add(new SqlParameter("@PayTypeDetielId_SRC", SqlDbType.Int) { Value = rowgridViewCD_KastBnood["PayTypeDetielId_SRC"] });
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
                    case "gridViewCD_AsaseACC":
                        DataRow rowgridViewCD_AsaseACC = gridViewCD_AsaseACC.GetFocusedDataRow();
                        if (rowgridViewCD_AsaseACC["asase_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_AsaseACC WHERE (asase_code = {0})", rowgridViewCD_AsaseACC["asase_code"]);
                            cmd.ExecuteNonQuery();
                            ((MainFrm)this.ParentForm).LoadCD_AsaseACC();
                        }
                        break;
                    case "gridViewCD_PayType":
                        DataRow rowgridViewCD_PayType = gridViewCD_PayType.GetFocusedDataRow();
                        if (rowgridViewCD_PayType["PayTypeId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_PayType WHERE (PayTypeId = {0})", rowgridViewCD_PayType["PayTypeId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_PayTypeDetiel":
                        DataRow rowgridViewCD_PayTypeDetiel = gridViewCD_PayTypeDetiel.GetFocusedDataRow();
                        if (rowgridViewCD_PayTypeDetiel["PayTypeDetielId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_PayTypeDetiel WHERE (PayTypeDetielId = {0})", rowgridViewCD_PayTypeDetiel["PayTypeDetielId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_PayMony":
                        DataRow rowgridViewCD_PayMony = gridViewCD_PayMony.GetFocusedDataRow();
                        if (rowgridViewCD_PayMony["asase_code_SRC"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_PayMony WHERE (asase_code = {0}) AND (PayTypeDetielId = {1}) AND (alsofof_code = {2})",
                            rowgridViewCD_PayMony["asase_code_SRC"], rowgridViewCD_PayMony["PayTypeDetielId_SRC"], rowgridViewCD_PayMony["alsofof_code_SRC"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_Discounts":
                        DataRow rowgridViewCD_Discounts = gridViewCD_Discounts.GetFocusedDataRow();
                        if (rowgridViewCD_Discounts["DiscountsId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_Discounts WHERE (DiscountsId = {0})", rowgridViewCD_Discounts["DiscountsId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_KastNo":
                        DataRow rowgridViewCD_KastNo = gridViewCD_KastNo.GetFocusedDataRow();
                        if (rowgridViewCD_KastNo["KastNoId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CD_KastNo WHERE (KastNoId = {0})", rowgridViewCD_KastNo["KastNoId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_KastSaf":
                        DataRow rowgridViewCD_KastSaf = gridViewCD_KastSaf.GetFocusedDataRow();
                        if (rowgridViewCD_KastSaf["KastNoId_SRC"].ToString() != string.Empty)
                        {
                            cmd.CommandText = @"DELETE FROM CD_KastSaf WHERE (KastNoId = @KastNoId_SRC) And (alsofof_code = @alsofof_code_SRC)";
                            cmd.Parameters.Add(new SqlParameter("@KastNoId_SRC", SqlDbType.Int) { Value = rowgridViewCD_KastSaf["KastNoId_SRC"] });
                            cmd.Parameters.Add(new SqlParameter("@alsofof_code_SRC", SqlDbType.Int) { Value = rowgridViewCD_KastSaf["alsofof_code_SRC"] });
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCD_KastBnood":
                        DataRow rowgridViewCD_KastBnood = gridViewCD_KastBnood.GetFocusedDataRow();
                        if (rowgridViewCD_KastBnood["KastNoId_SRC"].ToString() != string.Empty)
                        {
                            cmd.CommandText = @"DELETE FROM CD_KastBnood WHERE (KastNoId = @KastNoId_SRC) And (PayTypeDetielId = @PayTypeDetielId_SRC)";
                            cmd.Parameters.Add(new SqlParameter("@KastNoId_SRC", SqlDbType.Int) { Value = rowgridViewCD_KastBnood["KastNoId_SRC"] });
                            cmd.Parameters.Add(new SqlParameter("@PayTypeDetielId_SRC", SqlDbType.Int) { Value = rowgridViewCD_KastBnood["PayTypeDetielId_SRC"] });
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