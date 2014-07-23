using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;


namespace E_Club_Mem_Manager
{
    public partial class QryMemberFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ResultTbl = new DataTable("Result");
        DataTable GenderTB = new DataTable("Genders");
        DataTable NationalityTB = new DataTable("Nationalities");
        DataTable ReligionTB = new DataTable("Religions");
        DataTable SocialTB = new DataTable("Socials");
        DataTable SubscriptionTB = new DataTable("Subscriptions");
        DataTable jobTB = new DataTable("jobs");
        DataTable StatesTB = new DataTable("States");
        DataTable StationTB = new DataTable("Stations");
        DataTable QualificationTB = new DataTable("Qualifications");
        #endregion
        #region -   Functions   -
        public QryMemberFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            GenderTB = Program.MC.LoadDataTableMem("SELECT gender_ID, gender_name FROM CD_gender");
            SocialTB = Program.MC.LoadDataTableMem("SELECT Social_id, Social FROM CD_Social");
            ReligionTB = Program.MC.LoadDataTableMem("SELECT Religion_id, Religion FROM CD_Religion");
            NationalityTB = Program.MC.LoadDataTableMem("SELECT Nationality_id, Nationality FROM CD_Nationality");
            SubscriptionTB = Program.MC.LoadDataTableMem("SELECT Subscription_type_id, Subscription_type FROM CD_Subscription_type");
            QualificationTB = Program.MC.LoadDataTableMem("SELECT Qualification_id, Qualification FROM CD_Qualification");
            jobTB = Program.MC.LoadDataTableMem("SELECT job_id, job FROM CD_job");
            StatesTB = Program.MC.LoadDataTableMem("SELECT GOV_ID, GOV FROM CD_GOV");
            StationTB = Program.MC.LoadDataTableMem("SELECT markz_ID, MARKZ FROM CD_MARKZ");
        }
        private string QueryString(string Condition)
        {
            string ReturnMe = @"Set Dateformat dmy SELECT        mem_ID, mem_firstname, mem_fathername, mem_grandname, mem_famname, mem_NNumber,
                             (SELECT        gender_name
                                FROM            CD_gender
                                WHERE        (gender_ID = TBL_members_1.mem_gender)) AS gender_name,
                             (SELECT        Religion
                                FROM            CD_Religion
                                WHERE        (Religion_id = TBL_members_1.mem_Religion)) AS Religion,
                             (SELECT        Nationality
                                FROM            CD_Nationality
                                WHERE        (Nationality_id = TBL_members_1.mem_Nationality)) AS Nationality,
                             (SELECT        Social
                                FROM            CD_Social
                                WHERE        (Social_id = TBL_members_1.mem_Social)) AS Social, mem_bdate,
                             (SELECT        job
                                FROM            CD_job
                                WHERE        (job_id = TBL_members_1.mem_job)) AS job, mem_jobDetail,
                             (SELECT        MARKZ
                                FROM            CD_MARKZ
                                WHERE        (markz_ID = TBL_members_1.mem_markz)) AS MARKZ, mem_address, mem_mNUMBER,
                             (SELECT        GOV
                                FROM            CD_GOV
                                WHERE        (GOV_ID = TBL_members_1.MEM_GOV)) AS GOV, mem_gov_eork,
                             (SELECT        mem_name
                                FROM            TBL_members
                                WHERE        (mem_ID = mem_parent)) AS mem_name, mem_Case,
                             (SELECT        Qualification
                                FROM            CD_Qualification
                                WHERE        (Qualification_id = TBL_members_1.Qualification_id)) AS Qualification1, tel_house, tel_mobile, morafk,
                             (SELECT        Kinship
                                FROM            CD_kinship
                                WHERE        (Kinship_id = TBL_members_1.Kinship_id)) AS Kinship,
                             (SELECT        Subscription_type
                                FROM            CD_Subscription_type
                                WHERE        (Subscription_type_id = TBL_members_1.Subscription_type_id)) AS Subscription_type
                                FROM        TBL_members AS TBL_members_1 ";
            return ReturnMe + " " + Condition;
        }
        private void FillResult(string Condition)
        {
            ResultTbl = new DataTable("Result");
            ResultTbl = Program.MC.LoadDataTableMem(QueryString(Condition));
            gridControlResult.DataSource = ResultTbl;
        }
        #endregion
        #region -   Event Handlers   -
        private void QryMemberFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            CBCode_SelectedIndexChanged(CBCode, new EventArgs());
        }
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            gridView1});
            gridControlResult.MainView = gridView1;
        }
        private void cardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Card.CardView MyCardView;
            MyCardView = new DevExpress.XtraGrid.Views.Card.CardView();
            MyCardView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            GCmem_ID, GCmem_firstname, GCmem_fathername, GCmem_grandname, GCmem_famname, GCmem_NNumber, GCgender_name, GCReligion,
            GCNationality, GCSocial, GCmem_bdate, GCjob, GCmem_jobDetail, GCMARKZ, GCmem_address, GCmem_mNUMBER, GOV, GCmem_Case, GCQualification,
            GCtel_house, GCtel_mobile, GCKinship, GCSubscription_type});
            MyCardView.FocusedCardTopFieldIndex = 0;
            MyCardView.GridControl = gridControlResult;
            MyCardView.Name = "cardView1";
            MyCardView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            gridControlResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            MyCardView});
            gridControlResult.MainView = MyCardView;
        }
        private void TxtSearch_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text.Trim().Length != 0)
                Btntxt.Enabled = true;
            else
                Btntxt.Enabled = false;
        }
        private void LUECode_EditValueChanged(object sender, EventArgs e)
        {
            if (LUECode.EditValue != null)
                BtnCode.Enabled = true;
            else
                BtnCode.Enabled = false;
        }
        private void TxtAge_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtAge.Text.Trim().Length != 0)
                BtnAge1.Enabled = true;
            else
                BtnAge1.Enabled = false;
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
        private void DEAge_EditValueChanged(object sender, EventArgs e)
        {
            if (DEAge.EditValue != null)
                BtnAge3.Enabled = true;
            else
                BtnAge3.Enabled = false;
        }
        private void CBCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LUECode.Properties.Columns.Clear();
            switch (CBCode.SelectedIndex)
            {
                case 0://النــــوع
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gender_name", "النــــوع"));
                    LUECode.Properties.DataSource = GenderTB;
                    LUECode.Properties.DisplayMember = "gender_name";
                    LUECode.Properties.ValueMember = "gender_ID";
                    break;
                case 1://الحاله الاجتماعيه
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Social", "الحاله الاجتماعيه"));
                    LUECode.Properties.DataSource = SocialTB;
                    LUECode.Properties.DisplayMember = "Social";
                    LUECode.Properties.ValueMember = "Social_id";
                    break;
                case 2://الديانه
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Religion", "الديانه"));
                    LUECode.Properties.DataSource = ReligionTB;
                    LUECode.Properties.DisplayMember = "Religion";
                    LUECode.Properties.ValueMember = "Religion_id";
                    break;
                case 3://الجنسيه
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nationality", "الجنسيه"));
                    LUECode.Properties.DataSource = NationalityTB;
                    LUECode.Properties.DisplayMember = "Nationality";
                    LUECode.Properties.ValueMember = "Nationality_id";
                    break;
                case 4://نوع الاشتراك
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Subscription_type", "نوع الاشتراك"));
                    LUECode.Properties.DataSource = SubscriptionTB;
                    LUECode.Properties.DisplayMember = "Subscription_type";
                    LUECode.Properties.ValueMember = "Subscription_type_id";
                    break;
                case 5://المؤهــــل
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Qualification", "المؤهــــل"));
                    LUECode.Properties.DataSource = QualificationTB;
                    LUECode.Properties.DisplayMember = "Qualification";
                    LUECode.Properties.ValueMember = "Qualification_id";
                    break;
                case 6://الوظيـــفه
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("job", "الوظيـــفه"));
                    LUECode.Properties.DataSource = jobTB;
                    LUECode.Properties.DisplayMember = "job";
                    LUECode.Properties.ValueMember = "job_id";
                    break;
                case 7://المحافظـــه
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GOV", "المحافظـــه"));
                    LUECode.Properties.DataSource = StatesTB;
                    LUECode.Properties.DisplayMember = "GOV";
                    LUECode.Properties.ValueMember = "GOV_ID";
                    break;
                case 8://المــركز
                    LUECode.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARKZ", "المــركز"));
                    LUECode.Properties.DataSource = StationTB;
                    LUECode.Properties.DisplayMember = "MARKZ";
                    LUECode.Properties.ValueMember = "markz_ID";
                    break;
            }
        }
        private void Btntxt_Click(object sender, EventArgs e)
        {
            switch (CBTxt.SelectedIndex)
            {
                case 0://كود العضــــــو
                    FillResult("Where mem_ID like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 1://رقم العضويه
                    FillResult("Where mem_mNUMBER like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 2://الرقم القومي
                    FillResult("Where mem_NNumber like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 3://الاسم الاول
                    FillResult("Where mem_firstname like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 4://اسم الاب
                    FillResult("Where mem_fathername like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 5://اسم الجد
                    FillResult("Where  mem_grandname like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 6://اللقب(العائله)
                    FillResult("Where mem_famname like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 7://الوصف الوظيفــي
                    FillResult("Where mem_jobDetail like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 8://العنـــوان
                    FillResult("Where mem_address like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 9://التليفــون
                    FillResult("Where tel_house like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
                case 10://المحمـــول
                    FillResult("Where tel_mobile like '%" + TxtSearch.Text.Trim() + "%'");
                    break;
            }
        }
        private void BtnCode_Click(object sender, EventArgs e)
        {
            switch (CBCode.SelectedIndex)
            {
                case 0://النــــوع
                    FillResult(" Where mem_gender = " + LUECode.EditValue.ToString());
                    break;
                case 1://الحاله الاجتماعيه
                    FillResult(" Where mem_Social = " + LUECode.EditValue.ToString());
                    break;
                case 2://الديانه
                    FillResult(" Where mem_Religion = " + LUECode.EditValue.ToString());
                    break;
                case 3://الجنسيه
                    FillResult(" Where mem_Nationality = " + LUECode.EditValue.ToString());
                    break;
                case 4://نوع الاشتراك
                    FillResult(" Where Subscription_type_id = " + LUECode.EditValue.ToString());
                    break;
                case 5://المؤهــــل
                    FillResult(" Where Qualification_id = " + LUECode.EditValue.ToString());
                    break;
                case 6://الوظيـــفه
                    FillResult(" Where mem_job = " + LUECode.EditValue.ToString());
                    break;
                case 7://المحافظـــه
                    FillResult(" Where MEM_GOV = " + LUECode.EditValue.ToString());
                    break;
                case 8://المــركز
                    FillResult(" Where mem_markz = " + LUECode.EditValue.ToString());
                    break;
            }
        }
        private void BtnAge1_Click(object sender, EventArgs e)
        {
            string startdate, enddate;
            startdate = "1/1/" + (DateTime.Now.Year - MCls.ConvertStringToInt(TxtAge.Text.Trim())).ToString();
            enddate = "31/12/" + (DateTime.Now.Year - MCls.ConvertStringToInt(TxtAge.Text.Trim())).ToString();
            FillResult(" WHERE mem_bdate BETWEEN '" + startdate + "' AND '" + enddate + "'");
        }
        private void BtnAge2_Click(object sender, EventArgs e)
        {
            FillResult(" WHERE mem_bdate BETWEEN '" + DEAgeFrom.Text.Trim() + "' AND '" + DEAgeTo.Text.Trim() + "'");
        }
        private void BtnAge3_Click(object sender, EventArgs e)
        {
            switch (CBAge.SelectedIndex)
            {
                case 0://>
                    FillResult(" WHERE mem_bdate < '" + DEAge.Text.Trim() + "'");
                    break;
                case 1://<
                    FillResult(" WHERE mem_bdate > '" + DEAge.Text.Trim() + "'");
                    break;
                case 2://=
                    FillResult(" WHERE mem_bdate = '" + DEAge.Text.Trim() + "'");
                    break;
            }
        }
        #endregion
    }
}