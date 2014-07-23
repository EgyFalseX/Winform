using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Emp_Manager
{
    public partial class QryEmployeeFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private DevExpress.XtraGrid.Views.Card.CardView MycardView = new DevExpress.XtraGrid.Views.Card.CardView();
        private DevExpress.XtraGrid.Views.Grid.GridView MyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
        DataTable ResultTbl = new DataTable("Result");
        DataTable ReligionTypesTBL = new DataTable("ReligionTypes");
        DataTable LUEGenderTBL = new DataTable("Gender");
        DataTable SocialStateTypesTBL = new DataTable("SocialStateTypes");
        DataTable StatesTBL = new DataTable("States");
        DataTable MilitaryStateTypesTBL = new DataTable("MilitaryStateTypes");
        DataTable CitysTBL = new DataTable("Citys");
        DataTable NationalityTypeTBL = new DataTable("NationalityType");
        DataTable JobTypesTBL = new DataTable("JobTypes");
        DataTable JobDescriptionsTypesTBL = new DataTable("JobDescriptionsTypes");
        DataTable QualifierTypesTBL = new DataTable("QualifierTypes");
        DataTable SpecialtyTypesTBL = new DataTable("SpecialtyTypes");
        DataTable SpecialtySideTypesTBL = new DataTable("SpecialtySideTypes");
        #endregion
        #region -   Functions   -
        public QryEmployeeFrm()
        {
            InitializeComponent();
        }
        private string QueryString(string Condition)
        {
            string ReturnMe = @"Set Dateformat dmy SELECT EmpID, EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME,
                             (SELECT        job
                                FROM            CD_job
                                WHERE        (job_id = Emp_Master.job_id)) AS JobName, BIRTH_DATE,
                             (SELECT        gender_name
                                FROM            CD_gender
                                WHERE        (gender_ID = Emp_Master.GENDER_ID)) AS Gender,
                             (SELECT        GOV_NAME
                                FROM            CDR_GOV
                                WHERE        (GOV_ID = Emp_Master.BIRTH_GOV)) AS BIRTH_GOV,
                             (SELECT        JOB_STATUS_NAME
                                FROM            CDR_JOB_STATUS
                                WHERE        (JOB_STATUS_ID = Emp_Master.JOB_STATUS_ID)) AS JOB_STATUS_NAME, Emp_Address, PHONE_NO, MOBILE_NO,
                             (SELECT        Job_DisName
                                FROM            CD_Job_Dis
                                WHERE        (Job_Dis_ID = Emp_Master.Job_Dis_ID)) AS Job_DisName,
                             (SELECT        University_Name
                                FROM            CD_University
                                WHERE        (University_ID = Emp_Master.University_ID)) AS University_Name, AddingDate, noview, orderreport,
                             (SELECT        Religion
                                FROM            CD_Religion
                                WHERE        (Religion_id = Emp_Master.Religion_id)) AS Religion,
                             (SELECT        Social
                                FROM            CD_Social
                                WHERE        (Social_id = Emp_Master.Social_id)) AS Social,
                             (SELECT        tagned
                                FROM            CD_tagneed
                                WHERE        (tagned_id = Emp_Master.tagned_id)) AS tagned, tameen_no, tameen_date1, betaka_tameen, Work_Start_Date, Ac_Start_Date,
                             (SELECT        Moaahel_Name
                                FROM            CD_Moaahel
                                WHERE        (Moaahel_ID = Emp_Master.Moaahel_ID)) AS Moaahel_Name, Moaahel_Date,
                             (SELECT        SPECIFICATION_NAME
                                FROM            CDR_SPECIFICATION
                                WHERE        (SPECIFICATION_ID = Emp_Master.SPECIFICATION_ID)) AS SPECIFICATION_NAME,
                             (SELECT        Nationality
                                FROM            CD_Nationality
                                WHERE        (Nationality_id = Emp_Master.Nationality_id)) AS Nationality, Emp_Full_Name, tameen_date2
                                FROM            Emp_Master";
            return ReturnMe + " " + Condition;
        }
        private void FillResult(string Condition)
        {
            ResultTbl = new DataTable("Result");
            ResultTbl = Program.MC.LoadDataTable(QueryString(Condition), Program.MC.SQLConStrMalafat);
            gridControlResult.DataSource = ResultTbl;
        }
        private void LoadDefaultData()
        {
            
            
            
            SpecialtySideTypesTBL = new DataTable("SpecialtySideTypes");
            using (SqlDataAdapter DA = new SqlDataAdapter("", Program.MC.SQLConStrMalafat))
            {
                ////محافظة الميلاد
                
                ////الجنسيه
                
                
                ////المؤهل

                ////جهة المؤهل

            }
        }
        #endregion
        #region -   Event Handlers   -
        private void QryEmployeeFrm_Load(object sender, EventArgs e)
        {
            CBGeneral1_SelectedIndexChanged(CBGeneral1, new EventArgs());
            CBJob_SelectedIndexChanged(CBJob, new EventArgs());
            CBQua_SelectedIndexChanged(CBQua, new EventArgs());
            CBAddress_SelectedIndexChanged(CBAddress, new EventArgs());

        }
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            GCEmpID, GCEmpNationalID, GCEMP_FIRST_NAME, GCEMP_FATHER_NAME, GCEMP_FAM_NAME, GCEMP_FOURTH_NAME, GCJobName,GCBIRTH_DATE,
            GCGender, GCBIRTH_GOV, GCJOB_STATUS_NAME, GCEmp_Address, GCPHONE_NO, GCMOBILE_NO, GCJob_DisName, GCUniversity_Name, GCAddingDate,
            GCReligion, GCSocial, GCtagned, GCtameen_no, GCtameen_date1, GCbetaka_tameen, GCWork_Start_Date, GCAc_Start_Date, GCMoaahel_Name,
            GCMoaahel_Date, GCSPECIFICATION_NAME, GCNationality, GCtameen_date2});
            MyGridView.GridControl = this.gridControlResult;
            MyGridView.Name = "MyGridView";
            MyGridView.OptionsBehavior.Editable = false;
            MyGridView.OptionsView.ColumnAutoWidth = false;
            gridControlResult.MainView = MyGridView;
            this.gridControlResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            MyGridView});
        }
        private void cardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MycardView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            GCEmpID, GCEmpNationalID, GCEMP_FIRST_NAME, GCEMP_FATHER_NAME, GCEMP_FAM_NAME, GCEMP_FOURTH_NAME, GCJobName, GCBIRTH_DATE, GCGender,
            GCBIRTH_GOV, GCJOB_STATUS_NAME, GCEmp_Address, GCPHONE_NO, GCMOBILE_NO, GCJob_DisName, GCUniversity_Name, GCAddingDate, GCReligion,
            GCSocial, GCtagned, GCtameen_no, GCtameen_date1, GCbetaka_tameen, GCWork_Start_Date, GCAc_Start_Date, GCMoaahel_Name, GCMoaahel_Date,
            GCSPECIFICATION_NAME, GCNationality, GCtameen_date2});
            MycardView.FocusedCardTopFieldIndex = 0;
            MycardView.GridControl = this.gridControlResult;
            MycardView.Name = "MycardView";
            MycardView.OptionsBehavior.Editable = false;
            MycardView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            gridControlResult.MainView = MycardView;
            this.gridControlResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            MycardView});
        }
        #region -   General Tab   -
        private void CBGeneral1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LUEGeneral.Properties.Columns.Clear();
            switch (CBGeneral1.SelectedIndex)
            {
                case 0://الحاله الاجتماعيه
                    LUEGeneral.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Social", "الحاله الاجتماعيه"));
                    SocialStateTypesTBL = new DataTable("SocialStateTypes");
                    SocialStateTypesTBL = Program.MC.LoadDataTable("SELECT Social_id, Social FROM CD_Social", Program.MC.SQLConStrMalafat);
                    LUEGeneral.Properties.DataSource = SocialStateTypesTBL;
                    LUEGeneral.Properties.DisplayMember = "Social";
                    LUEGeneral.Properties.ValueMember = "Social_id";
                    break;
                case 1://الديانه
                    LUEGeneral.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Religion", "الديانه"));
                    ReligionTypesTBL = new DataTable("ReligionTypes");
                    ReligionTypesTBL = Program.MC.LoadDataTable("SELECT Religion_id, Religion FROM CD_Religion", Program.MC.SQLConStrMalafat);
                    LUEGeneral.Properties.DataSource = ReligionTypesTBL;
                    LUEGeneral.Properties.DisplayMember = "Religion";
                    LUEGeneral.Properties.ValueMember = "Religion_id";
                    break;
                case 2://موقف التجنيد
                    LUEGeneral.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tagned", "موقف التجنيد"));
                    MilitaryStateTypesTBL = new DataTable("MilitaryStateTypes");
                    MilitaryStateTypesTBL = Program.MC.LoadDataTable("SELECT tagned_id, tagned FROM CD_tagneed", Program.MC.SQLConStrMalafat);
                    LUEGeneral.Properties.DataSource = MilitaryStateTypesTBL;
                    LUEGeneral.Properties.DisplayMember = "tagned";
                    LUEGeneral.Properties.ValueMember = "tagned_id";
                    break;
                case 3://النوع
                    LUEGeneral.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gender_name", "النوع"));
                    LUEGenderTBL = new DataTable("Gender");
                    LUEGenderTBL = Program.MC.LoadDataTable("SELECT gender_ID, gender_name FROM CD_gender", Program.MC.SQLConStrMalafat);
                    LUEGeneral.Properties.DataSource = LUEGenderTBL;
                    LUEGeneral.Properties.DisplayMember = "gender_name";
                    LUEGeneral.Properties.ValueMember = "gender_ID";
                    break;
                case 4://الحاله
                    LUEGeneral.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JOB_STATUS_NAME", "الحاله"));
                    StatesTBL = new DataTable("States");
                    StatesTBL = Program.MC.LoadDataTable("SELECT JOB_STATUS_ID, JOB_STATUS_NAME FROM CDR_JOB_STATUS", Program.MC.SQLConStrMalafat);
                    LUEGeneral.Properties.DataSource = StatesTBL;
                    LUEGeneral.Properties.DisplayMember = "JOB_STATUS_NAME";
                    LUEGeneral.Properties.ValueMember = "JOB_STATUS_ID";
                    break;
            }
        }
        private void TxtGeneral1_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtGeneral1.Text.Trim().Length > 0)
                BtnGeneral2.Enabled = true;
            else
                BtnGeneral2.Enabled = false;
        }
        private void TxtGeneral2_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtGeneral2.Text.Trim().Length > 0)
                BtnGeneral3.Enabled = true;
            else
                BtnGeneral3.Enabled = false;
        }
        private void LUEGeneral_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEGeneral.ItemIndex != -1)
                BtnGeneral1.Enabled = true;
            else
                BtnGeneral1.Enabled = false;
        }
        private void BtnGeneral1_Click(object sender, EventArgs e)
        {
            switch (CBGeneral1.SelectedIndex)
            {
                case 0://الحاله الاجتماعيه
                    FillResult(" Where Social_id = " + LUEGeneral.EditValue.ToString());
                    break;
                case 1://الديانه
                    FillResult(" Where Religion_id = " + LUEGeneral.EditValue.ToString());
                    break;
                case 2://موقف التجنيد
                    FillResult(" Where tagned_id = " + LUEGeneral.EditValue.ToString());
                    break;
                case 3://النوع
                    FillResult(" Where GENDER_ID = " + LUEGeneral.EditValue.ToString());
                    break;
                case 4://الحاله
                    FillResult(" Where JOB_STATUS_ID = " + LUEGeneral.EditValue.ToString());
                    break;
            }
        }
        private void BtnGeneral2_Click(object sender, EventArgs e)
        {
            switch (CBGeneral2.SelectedIndex)
            {
                case 0://الاسم بالكامل
                    FillResult(" Where Emp_Full_Name like '%" + TxtGeneral1.Text.Trim() + "%'");
                    break;
                case 1://الاسم
                    FillResult(" Where EMP_FIRST_NAME like '%" + TxtGeneral1.Text.Trim() + "%'");
                    break;
                case 2://الاب
                    FillResult(" Where EMP_FATHER_NAME like '%" + TxtGeneral1.Text.Trim() + "%'");
                    break;
                case 3://الجد
                    FillResult(" Where EMP_FAM_NAME like '%" + TxtGeneral1.Text.Trim() + "%'");
                    break;
                case 4://اللقب
                    FillResult(" Where EMP_FOURTH_NAME like '%" + TxtGeneral1.Text.Trim() + "%'");
                    break;
            }
        }
        private void BtnGeneral3_Click(object sender, EventArgs e)
        {
            switch (CBGeneral3.SelectedIndex)
            {

                case 0://كود الموظف
                    FillResult(" Where EmpID = " + TxtGeneral2.Text.Trim() + "");
                    break;
                case 1://الرقم القومي
                    FillResult(" Where EmpNationalID like '%" + TxtGeneral2.Text.Trim() + "%'");
                    break;
                case 2://تليفون
                    FillResult(" Where PHONE_NO like '%" + TxtGeneral2.Text.Trim() + "%'");
                    break;
                case 3://محمول
                    FillResult(" Where MOBILE_NO like '%" + TxtGeneral2.Text.Trim() + "%'");
                    break;
            }
        }
        #endregion
        #region -   Age Tab   -
        private void DEAge_EditValueChanged(object sender, EventArgs e)
        {
            if (DEAge.EditValue != null)
                BtnAge3.Enabled = true;
            else
                BtnAge3.Enabled = false;
        }
        private void TxtAge_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtAge.Text.Trim().Length == 0)
                BtnAge1.Enabled = false;
            else
                BtnAge1.Enabled = true;
        }
        private void DEAgeTo_EditValueChanged(object sender, EventArgs e)
        {
            if (DEAgeFrom.EditValue != null && DEAgeTo.EditValue != null)
                BtnAge2.Enabled = true;
            else
                BtnAge2.Enabled = false;
        }
        private void DEAgeFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (DEAgeFrom.EditValue != null && DEAgeTo.EditValue != null)
                BtnAge2.Enabled = true;
            else
                BtnAge2.Enabled = false;
        }
        private void BtnAge1_Click(object sender, EventArgs e)
        {
            string startdate, enddate;
            startdate = "1/1/" + (DateTime.Now.Year - MCls.ConvertStringToInt(TxtAge.Text.Trim())).ToString();
            enddate = "31/12/" + (DateTime.Now.Year - MCls.ConvertStringToInt(TxtAge.Text.Trim())).ToString();
            FillResult(" WHERE BIRTH_DATE BETWEEN '" + startdate + "' AND '" + enddate + "'");
        }
        private void BtnAge2_Click(object sender, EventArgs e)
        {
            FillResult(" WHERE BIRTH_DATE BETWEEN '" + DEAgeFrom.Text.Trim() + "' AND '" + DEAgeTo.Text.Trim() + "'");
        }
        private void BtnAge3_Click(object sender, EventArgs e)
        {
            switch (CBAge.SelectedIndex)
            {
                case 0://>
                    FillResult(" WHERE BIRTH_DATE > '" + DEAge.Text.Trim() + "'");
                    break;
                case 1://<
                    FillResult(" WHERE BIRTH_DATE < '" + DEAge.Text.Trim() + "'");
                    break;
                case 2://=
                    FillResult(" WHERE BIRTH_DATE = '" + DEAge.Text.Trim() + "'");
                    break;
            }
        }
        #endregion
        #region -   Job Tab   -
        private void CBJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            LUEJob.Properties.Columns.Clear();
            switch (CBJob.SelectedIndex)
            {
                case 0://الوظيفه
                    LUEJob.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("job", "الوظيفه"));
                    JobTypesTBL = new DataTable("JobTypes");
                    JobTypesTBL = Program.MC.LoadDataTable("SELECT job_id, job FROM CD_job", Program.MC.SQLConStrMalafat);
                    LUEJob.Properties.DataSource = JobTypesTBL;
                    LUEJob.Properties.DisplayMember = "job";
                    LUEJob.Properties.ValueMember = "job_id";
                    break;
                case 1://توصيف الوظيفه
                    LUEJob.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Job_DisName", "توصيف الوظيفه"));
                    JobDescriptionsTypesTBL = new DataTable("JobDescriptionsTypes");
                    JobDescriptionsTypesTBL = Program.MC.LoadDataTable("SELECT Job_Dis_ID, Job_DisName FROM CD_Job_Dis", Program.MC.SQLConStrMalafat);
                    LUEJob.Properties.DataSource = JobDescriptionsTypesTBL;
                    LUEJob.Properties.DisplayMember = "Job_DisName";
                    LUEJob.Properties.ValueMember = "Job_Dis_ID";
                    break;
            }
        }
        private void DEJobFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (DEJobFrom.EditValue != null && DEJobTo.EditValue != null)
                BtnJob1.Enabled = true;
            else
                BtnJob1.Enabled = true;
        }
        private void DEJobTo_EditValueChanged(object sender, EventArgs e)
        {
            if (DEJobFrom.EditValue != null && DEJobTo.EditValue != null)
                BtnJob1.Enabled = true;
            else
                BtnJob1.Enabled = true;
        }
        private void LUEJob_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEJob.EditValue != null)
                BtnJob2.Enabled = true;
            else
                BtnJob2.Enabled = false;
        }
        private void BtnJob1_Click(object sender, EventArgs e)
        {
            switch (CBJobDate.SelectedIndex)
            {
                case 0://تاريخ التعيين
                    FillResult(" WHERE Work_Start_Date BETWEEN '" + DEJobFrom.EditValue.ToString() + "' AND '" + DEJobTo.EditValue.ToString() + "'");
                    break;
                case 1://استيلام العمل
                    FillResult(" WHERE Ac_Start_Date BETWEEN '" + DEJobFrom.EditValue.ToString() + "' AND '" + DEJobTo.EditValue.ToString() + "'");
                    break;
            }
        }
        private void BtnJob2_Click(object sender, EventArgs e)
        {
            switch (CBJob.SelectedIndex)
            {
                case 0://الوظيفه
                    FillResult(" WHERE job_id = " + LUEJob.EditValue.ToString());
                    break;
                case 1://توصيف الوظيفه
                    FillResult(" WHERE Job_Dis_ID = " + LUEJob.EditValue.ToString());
                    break;
            }
        }
        #endregion
        #region -   Qua Tab   -
        private void CBQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            LUEQua.Properties.Columns.Clear();
            QualifierTypesTBL = new DataTable("QualifierTypes");
            switch (CBQua.SelectedIndex)
            {
                case 0://المؤهل
                    LUEQua.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moaahel_Name", "المؤهل"));
                    QualifierTypesTBL = Program.MC.LoadDataTable("SELECT Moaahel_ID, Moaahel_Name FROM CD_Moaahel", Program.MC.SQLConStrMalafat);
                    LUEQua.Properties.DataSource = QualifierTypesTBL;
                    LUEQua.Properties.DisplayMember = "Moaahel_Name";
                    LUEQua.Properties.ValueMember = "Moaahel_ID";
                    break;
                case 1://تخصص المؤهل
                    LUEQua.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPECIFICATION_NAME", "تخصص المؤهل"));
                    QualifierTypesTBL = Program.MC.LoadDataTable("SELECT SPECIFICATION_ID, SPECIFICATION_NAME FROM CDR_SPECIFICATION", Program.MC.SQLConStrMalafat);
                    LUEQua.Properties.DataSource = SpecialtyTypesTBL;
                    LUEQua.Properties.DisplayMember = "SPECIFICATION_NAME";
                    LUEQua.Properties.ValueMember = "SPECIFICATION_ID";
                    break;
                case 2://جهة المؤهل
                    LUEJob.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("University_Name", "جهة المؤهل"));
                    QualifierTypesTBL = Program.MC.LoadDataTable("SELECT University_ID, University_Name FROM CD_University", Program.MC.SQLConStrMalafat);
                    LUEQua.Properties.DataSource = SpecialtySideTypesTBL;
                    LUEQua.Properties.DisplayMember = "University_Name";
                    LUEQua.Properties.ValueMember = "University_ID";
                    break;
            }
        }
        private void DEQuaFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (DEQuaFrom.EditValue != null && DEQuaTo.EditValue != null)
                BtnQua1.Enabled = true;
            else
                BtnQua1.Enabled = true;
        }
        private void DEQuaTo_EditValueChanged(object sender, EventArgs e)
        {
            if (DEQuaFrom.EditValue != null && DEQuaTo.EditValue != null)
                BtnQua1.Enabled = true;
            else
                BtnQua1.Enabled = true;
        }
        private void LUEQua_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEQua.EditValue != null)
                BtnQua2.Enabled = true;
            else
                BtnQua2.Enabled = false;
        }
        private void BtnQua1_Click(object sender, EventArgs e)
        {
            //تاريخ المؤهل
            FillResult(" WHERE Moaahel_Date BETWEEN '" + DEQuaFrom.EditValue.ToString() + "' AND '" + DEQuaTo.EditValue.ToString() + "'");
        }
        private void BtnQua2_Click(object sender, EventArgs e)
        {
            switch (CBQua.SelectedIndex)
            {
                case 0://المؤهل
                    FillResult(" WHERE Moaahel_ID = " + LUEQua.EditValue.ToString());
                    break;
                case 1://تخصص المؤهل
                    FillResult(" WHERE SPECIFICATION_ID = " + LUEQua.EditValue.ToString());
                    break;
                case 2://جهة المؤهل
                    FillResult(" WHERE University_ID = " + LUEQua.EditValue.ToString());
                    break;
            }
        }
        #endregion
        #region -   Address Tab   -
        private void CBAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            LUEAddress.Properties.Columns.Clear();
            
            switch (CBAddress.SelectedIndex)
            {
                case 0://محافظة الميلاد
                    LUEAddress.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GOV_NAME", "محافظة الميلاد"));
                    CitysTBL = new DataTable("Citys");
                    CitysTBL = Program.MC.LoadDataTable("SELECT GOV_ID, GOV_NAME FROM CDR_GOV", Program.MC.SQLConStrMalafat);
                    LUEAddress.Properties.DataSource = CitysTBL;
                    LUEAddress.Properties.DisplayMember = "GOV_NAME";
                    LUEAddress.Properties.ValueMember = "GOV_ID";
                    break;
                case 1://الجنسيه
                    LUEAddress.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nationality", "الجنسيه"));
                    NationalityTypeTBL = new DataTable("NationalityType");
                    NationalityTypeTBL = Program.MC.LoadDataTable("SELECT Nationality_id, Nationality FROM CD_Nationality", Program.MC.SQLConStrMalafat);
                    LUEAddress.Properties.DataSource = NationalityTypeTBL;
                    LUEAddress.Properties.DisplayMember = "Nationality";
                    LUEAddress.Properties.ValueMember = "Nationality_id";
                    break;
            }

        }
        private void LUEAddress_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEAddress.EditValue != null)
                BtnAddress1.Enabled = true;
            else
                BtnAddress1.Enabled = false;
        }
        private void TxtAddress_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtAddress.Text.Trim().Length != 0)
                BtnAddress2.Enabled = true;
            else
                BtnAddress2.Enabled = false;
        }
        private void BtnAddress1_Click(object sender, EventArgs e)
        {
            switch (CBAddress.SelectedIndex)
            {
                case 0://محافظة الميلاد
                    FillResult(" WHERE BIRTH_GOV = " + LUEAddress.EditValue.ToString());
                    break;
                case 1://الجنسيه
                    FillResult(" WHERE Nationality_id = " + LUEAddress.EditValue.ToString());
                    break;
            }
        }
        private void BtnAddress2_Click(object sender, EventArgs e)
        {
            FillResult(" WHERE Emp_Address like '%" + TxtAddress.Text.Trim() + "%'");
        }
        #endregion
        #region -   Security Insurance Tab   -
        private void DESecFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (DESecFrom.EditValue != null && DESecTo.EditValue != null)
                BtnSec1.Enabled = true;
            else
                BtnSec1.Enabled = true;
        }
        private void DESecTo_EditValueChanged(object sender, EventArgs e)
        {
            if (DESecFrom.EditValue != null && DESecTo.EditValue != null)
                BtnSec1.Enabled = true;
            else
                BtnSec1.Enabled = true;
        }
        private void TxtSec_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtSec.Text.Trim().Length != 0)
                BtnSec2.Enabled = true;
            else
                BtnSec2.Enabled = false;
        }
        private void BtnSec1_Click(object sender, EventArgs e)
        {
            switch (CBSecDate.SelectedIndex)
            {
                case 0://تاريخ التأمين 1
                    FillResult(" WHERE tameen_date1 BETWEEN '" + DESecFrom.EditValue.ToString() + "' AND '" + DESecTo.EditValue.ToString() + "'");
                    break;
                case 1://تاريخ التأمين 2
                    FillResult(" WHERE tameen_date2 BETWEEN '" + DESecFrom.Text.Trim() + "' AND '" + DESecTo.Text.Trim() + "'");
                    break;
            }
        }
        private void BtnSec2_Click(object sender, EventArgs e)
        {
            switch (CBSec.SelectedIndex)
            {
                case 0://الرقم التأميني
                    FillResult(" WHERE tameen_no like '%" + TxtAddress.Text.Trim() + "%'");
                    break;
                case 1://رقم بطاقة التأمين الصحي
                    FillResult(" WHERE betaka_tameen like '%" + TxtAddress.Text.Trim() + "%'");
                    break;
            }
        }
        #endregion
        #endregion
    }

}