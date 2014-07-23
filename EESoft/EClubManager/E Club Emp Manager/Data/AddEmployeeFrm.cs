using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;

namespace E_Club_Emp_Manager
{
    public partial class AddEmployeeFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
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
        DataTable EmpTbl = new DataTable("Emp");
        #endregion
        #region -   Functions   -
        private void LoadSpecialtyTypes(string Moaahel_ID)
        {
            //تخصص المؤهل
            SpecialtyTypesTBL = new DataTable("SpecialtyTypes");
            SpecialtyTypesTBL = Program.MC.LoadDataTable(String.Format("SELECT SPECIFICATION_ID, SPECIFICATION_NAME FROM CDR_SPECIFICATION WHERE (Moaahel_ID = {0})", Moaahel_ID), Program.MC.SQLConStrMalafat);
            LUESpecialtyTypes.Properties.DataSource = SpecialtyTypesTBL;
            LUESpecialtyTypes.Properties.DisplayMember = "SPECIFICATION_NAME";
            LUESpecialtyTypes.Properties.ValueMember = "SPECIFICATION_ID";
        }
        private void LoadJobDescriptions(string job_id)
        {
            //توصيف الوظيفه
            JobDescriptionsTypesTBL = new DataTable("JobDescriptionsTypes");
            JobDescriptionsTypesTBL = Program.MC.LoadDataTable(String.Format("SELECT Job_Dis_ID, Job_DisName FROM CD_Job_Dis WHERE (job_id = {0})", job_id), Program.MC.SQLConStrMalafat);
            LUEJobDescriptionsTypes.Properties.DataSource = JobDescriptionsTypesTBL;
            LUEJobDescriptionsTypes.Properties.DisplayMember = "Job_DisName";
            LUEJobDescriptionsTypes.Properties.ValueMember = "Job_Dis_ID";
        }
        private void LoadData()
        {
            SocialStateTypesTBL = new DataTable("SocialStateTypes");
            LUEGenderTBL = new DataTable("Gender");
            ReligionTypesTBL = new DataTable("ReligionTypes");
            StatesTBL = new DataTable("States");
            MilitaryStateTypesTBL = new DataTable("MilitaryStateTypes");
            CitysTBL = new DataTable("Citys");
            NationalityTypeTBL = new DataTable("NationalityType");
            JobTypesTBL = new DataTable("JobTypes");
            QualifierTypesTBL = new DataTable("QualifierTypes");
            SpecialtySideTypesTBL = new DataTable("SpecialtySideTypes");

            using (SqlDataAdapter DA = new SqlDataAdapter("", Program.MC.SQLConStrMalafat))
            {
                //الحاله الاجتماعيه
                SocialStateTypesTBL = Program.MC.LoadDataTable("SELECT Social_id, Social FROM CD_Social", Program.MC.SQLConStrMalafat);
                LUESocialStateTypes.Properties.DataSource = SocialStateTypesTBL;
                LUESocialStateTypes.Properties.DisplayMember = "Social";
                LUESocialStateTypes.Properties.ValueMember = "Social_id";
                LUESocialStateTypesEdit.Properties.DataSource = SocialStateTypesTBL;
                LUESocialStateTypesEdit.Properties.DisplayMember = "Social";
                LUESocialStateTypesEdit.Properties.ValueMember = "Social_id";                
                //النوع
                LUEGenderTBL = Program.MC.LoadDataTable("SELECT gender_ID, gender_name FROM CD_gender", Program.MC.SQLConStrMalafat);
                LUEGender.Properties.DataSource = LUEGenderTBL;
                LUEGender.Properties.DisplayMember = "gender_name";
                LUEGender.Properties.ValueMember = "gender_ID";
                LUEGenderEdit.Properties.DataSource = LUEGenderTBL;
                LUEGenderEdit.Properties.DisplayMember = "gender_name";
                LUEGenderEdit.Properties.ValueMember = "gender_ID";
                //الديانه
                ReligionTypesTBL = Program.MC.LoadDataTable("SELECT Religion_id, Religion FROM CD_Religion", Program.MC.SQLConStrMalafat);
                LUEReligionTypes.Properties.DataSource = ReligionTypesTBL;
                LUEReligionTypes.Properties.DisplayMember = "Religion";
                LUEReligionTypes.Properties.ValueMember = "Religion_id";
                LUEReligionTypesEdit.Properties.DataSource = ReligionTypesTBL;
                LUEReligionTypesEdit.Properties.DisplayMember = "Religion";
                LUEReligionTypesEdit.Properties.ValueMember = "Religion_id";
                //حالة الموظف
                StatesTBL = Program.MC.LoadDataTable("SELECT JOB_STATUS_ID, JOB_STATUS_NAME FROM CDR_JOB_STATUS", Program.MC.SQLConStrMalafat);
                LUEStates.Properties.DataSource = StatesTBL;
                LUEStates.Properties.DisplayMember = "JOB_STATUS_NAME";
                LUEStates.Properties.ValueMember = "JOB_STATUS_ID";
                LUEStatesEdit.Properties.DataSource = StatesTBL;
                LUEStatesEdit.Properties.DisplayMember = "JOB_STATUS_NAME";
                LUEStatesEdit.Properties.ValueMember = "JOB_STATUS_ID";
                //االتجنيد
                MilitaryStateTypesTBL = Program.MC.LoadDataTable("SELECT tagned_id, tagned FROM CD_tagneed", Program.MC.SQLConStrMalafat);
                LUEMilitaryStateTypes.Properties.DataSource = MilitaryStateTypesTBL;
                LUEMilitaryStateTypes.Properties.DisplayMember = "tagned";
                LUEMilitaryStateTypes.Properties.ValueMember = "tagned_id";
                LUEMilitaryStateTypesEdit.Properties.DataSource = MilitaryStateTypesTBL;
                LUEMilitaryStateTypesEdit.Properties.DisplayMember = "tagned";
                LUEMilitaryStateTypesEdit.Properties.ValueMember = "tagned_id";
                //محافظة الميلاد
                CitysTBL = Program.MC.LoadDataTable("SELECT GOV_ID, GOV_NAME FROM CDR_GOV", Program.MC.SQLConStrMalafat);
                LUECitys.Properties.DataSource = CitysTBL;
                LUECitys.Properties.DisplayMember = "GOV_NAME";
                LUECitys.Properties.ValueMember = "GOV_ID";
                LUECitysEdit.Properties.DataSource = CitysTBL;
                LUECitysEdit.Properties.DisplayMember = "GOV_NAME";
                LUECitysEdit.Properties.ValueMember = "GOV_ID";
                //الجنسيه
                NationalityTypeTBL = Program.MC.LoadDataTable("SELECT Nationality_id, Nationality FROM CD_Nationality", Program.MC.SQLConStrMalafat);
                LUENationalityType.Properties.DataSource = NationalityTypeTBL;
                LUENationalityType.Properties.DisplayMember = "Nationality";
                LUENationalityType.Properties.ValueMember = "Nationality_id";
                LUENationalityTypeEdit.Properties.DataSource = NationalityTypeTBL;
                LUENationalityTypeEdit.Properties.DisplayMember = "Nationality";
                LUENationalityTypeEdit.Properties.ValueMember = "Nationality_id";
                //الوظيفه
                JobTypesTBL = Program.MC.LoadDataTable("SELECT job_id, job FROM CD_job", Program.MC.SQLConStrMalafat);
                LUEJobTypes.Properties.DataSource = JobTypesTBL;
                LUEJobTypes.Properties.DisplayMember = "job";
                LUEJobTypes.Properties.ValueMember = "job_id";
                LUEJobTypesEdit.Properties.DataSource = JobTypesTBL;
                LUEJobTypesEdit.Properties.DisplayMember = "job";
                LUEJobTypesEdit.Properties.ValueMember = "job_id";
                //المؤهل
                QualifierTypesTBL = Program.MC.LoadDataTable("SELECT Moaahel_ID, Moaahel_Name FROM CD_Moaahel", Program.MC.SQLConStrMalafat);
                LUEQualifierTypes.Properties.DataSource = QualifierTypesTBL;
                LUEQualifierTypes.Properties.DisplayMember = "Moaahel_Name";
                LUEQualifierTypes.Properties.ValueMember = "Moaahel_ID";
                LUEQualifierTypesEdit.Properties.DataSource = QualifierTypesTBL;
                LUEQualifierTypesEdit.Properties.DisplayMember = "Moaahel_Name";
                LUEQualifierTypesEdit.Properties.ValueMember = "Moaahel_ID";
                //جهة المؤهل
                SpecialtySideTypesTBL = Program.MC.LoadDataTable("SELECT University_ID, University_Name FROM CD_University", Program.MC.SQLConStrMalafat);
                LUESpecialtySideTypes.Properties.DataSource = SpecialtySideTypesTBL;
                LUESpecialtySideTypes.Properties.DisplayMember = "University_Name";
                LUESpecialtySideTypes.Properties.ValueMember = "University_ID";
                LUESpecialtySideTypesEdit.Properties.DataSource = SpecialtySideTypesTBL;
                LUESpecialtySideTypesEdit.Properties.DisplayMember = "University_Name";
                LUESpecialtySideTypesEdit.Properties.ValueMember = "University_ID";
                //تخصص المؤهل
                DataTable SpecialtyTypesTBL2 = new DataTable("SpecialtyTypes");
                SpecialtyTypesTBL2 = Program.MC.LoadDataTable("SELECT SPECIFICATION_ID, SPECIFICATION_NAME FROM CDR_SPECIFICATION", Program.MC.SQLConStrMalafat);
                LUESpecialtyTypesEdit.Properties.DataSource = SpecialtyTypesTBL2;
                LUESpecialtyTypesEdit.Properties.DisplayMember = "SPECIFICATION_NAME";
                LUESpecialtyTypesEdit.Properties.ValueMember = "SPECIFICATION_ID";
                //توصيف الوظيفه
                DataTable JobDescriptionsTypesTBL2 = new DataTable("JobDescriptionsTypes");
                JobDescriptionsTypesTBL2 = Program.MC.LoadDataTable("SELECT Job_Dis_ID, Job_DisName FROM CD_Job_Dis", Program.MC.SQLConStrMalafat);
                LUEJobDescriptionsTypesEdit.Properties.DataSource = JobDescriptionsTypesTBL2;
                LUEJobDescriptionsTypesEdit.Properties.DisplayMember = "Job_DisName";
                LUEJobDescriptionsTypesEdit.Properties.ValueMember = "Job_Dis_ID";
            }
        }
        private void GetFreeEmpID()
        {
            string EmpID = string.Empty;
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand("SELECT TOP (1) EmpID FROM Emp_Master ORDER BY EmpID DESC", Con);
                SqlDataReader dr;
                try
                {
                    Con.Open();
                    dr = Cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        EmpID = dr.GetValue(0).ToString();
                    }
                    else
                    {
                        EmpID = null;
                    }
                    dr.Close();
                    if (EmpID == null)
                    {
                        Cmd.CommandText = "SELECT TOP (1) Emp_Start_Code FROM ATT_company_data";
                        EmpID = Cmd.ExecuteScalar().ToString();
                        TxtCode.Text = EmpID;
                    }
                    else
                        TxtCode.Text = (Convert.ToInt32(EmpID) + 1).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
        }
        private void LoadAllEmp()
        {
            EmpTbl = new DataTable("Emp");
            EmpTbl = Program.MC.LoadDataTable(@"SELECT EmpID, EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, job_id, CONVERT(varchar, BIRTH_DATE, 103) AS BIRTH_DATE, GENDER_ID, BIRTH_GOV, 
            JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, MOBILE_NO, Job_Dis_ID, University_ID, AddingDate, noview, orderreport, Religion_id, Social_id, 
            tagned_id, tameen_no, CONVERT(varchar, tameen_date1, 103) AS tameen_date1, CONVERT(varchar, tameen_date2, 103) AS tameen_date2, betaka_tameen, CONVERT(varchar, Work_Start_Date, 103) AS Work_Start_Date, CONVERT(varchar, Ac_Start_Date, 103) AS Ac_Start_Date, Moaahel_ID, CONVERT(varchar, Moaahel_Date, 103) AS Moaahel_Date, SPECIFICATION_ID, Nationality_id, 
            Emp_Full_Name, EmpPic
            FROM Emp_Master", Program.MC.SQLConStrMalafat);
            LUEEmp.Properties.DataSource = EmpTbl;
            LUEEmp.Properties.DisplayMember = "Emp_Full_Name";
            LUEEmp.Properties.ValueMember = "EmpID";
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string EmpID;
            if (TxtCode.Text.Trim().Length != 0)
                EmpID = TxtCode.Text;
            else
                EmpID = "NULL";
            string EmpNationalID;
            if (TxtSSN.Text.Trim().Length != 0)
                EmpNationalID = String.Format("N'{0}'", TxtSSN.Text);
            else
                EmpNationalID = "NULL";

            string EMP_FIRST_NAME;
            if (TxtName1.Text.Trim().Length != 0)
                EMP_FIRST_NAME = String.Format("N'{0}'", TxtName1.Text);
            else
                EMP_FIRST_NAME = "NULL";

            string EMP_FATHER_NAME;
            if (TxtName2.Text.Trim().Length != 0)
                EMP_FATHER_NAME = String.Format("N'{0}'", TxtName2.Text);
            else
                EMP_FATHER_NAME = "NULL";

            string EMP_FAM_NAME;
            if (TxtName3.Text.Trim().Length != 0)
                EMP_FAM_NAME = String.Format("N'{0}'", TxtName3.Text);
            else
                EMP_FAM_NAME = "NULL";

            string EMP_FOURTH_NAME;
            if (TxtName4.Text.Trim().Length != 0)
                EMP_FOURTH_NAME = String.Format("N'{0}'", TxtName4.Text);
            else
                EMP_FOURTH_NAME = "NULL";

            string Emp_Full_Name;
            if (TxtNameAll.Text.Trim().Length != 0)
                Emp_Full_Name = String.Format("N'{0}'", TxtNameAll.Text);
            else
                Emp_Full_Name = "NULL";

            string BIRTH_DATE;
            if (DEBirth.Text.Trim().Length != 0)
                BIRTH_DATE = String.Format("Convert(Datetime, '{0}', 103)", DEBirth.Text);
            else
                BIRTH_DATE = "NULL";

            string Social_id;
            if (LUESocialStateTypes.ItemIndex != -1)
                Social_id = LUESocialStateTypes.EditValue.ToString();
            else
                Social_id = "NULL";
            
            string GENDER_ID;
            if (LUEGender.ItemIndex != -1)
                GENDER_ID = LUEGender.EditValue.ToString();
            else
                GENDER_ID = "NULL";

            string Religion_id;
            if (LUEReligionTypes.ItemIndex != -1)
                Religion_id = LUEReligionTypes.EditValue.ToString();
            else
                Religion_id = "NULL";

            string JOB_STATUS_ID;
            if (LUEStates.ItemIndex != -1)
                JOB_STATUS_ID = LUEStates.EditValue.ToString();
            else
                JOB_STATUS_ID = "NULL";

            string tagned_id;
            if (LUEMilitaryStateTypes.ItemIndex != -1)
                tagned_id = LUEMilitaryStateTypes.EditValue.ToString();
            else
                tagned_id = "NULL";

            string BIRTH_GOV;
            if (LUECitys.ItemIndex != -1)
                BIRTH_GOV = LUECitys.EditValue.ToString();
            else
                BIRTH_GOV = "NULL";

            string Nationality_id;
            if (LUENationalityType.ItemIndex != -1)
                Nationality_id = LUENationalityType.EditValue.ToString();
            else
                Nationality_id = "NULL";

            string Emp_Address;
            if (TxtAddress.Text.Trim().Length != 0)
                Emp_Address = String.Format("N'{0}'", TxtAddress.Text);
            else
                Emp_Address = "NULL";

            string PHONE_NO;
            if (TxtPhone.Text.Trim().Length != 0)
                PHONE_NO = String.Format("N'{0}'", TxtPhone.Text);
            else
                PHONE_NO = "NULL";

            string MOBILE_NO;
            if (TxtMobile.Text.Trim().Length != 0)
                MOBILE_NO = String.Format("N'{0}'", TxtMobile.Text);
            else
                MOBILE_NO = "NULL";

            string job_id;
            if (LUEJobTypes.ItemIndex != -1)
                job_id = LUEJobTypes.EditValue.ToString();
            else
                job_id = "NULL";

            string Job_Dis_ID;
            if (LUEJobDescriptionsTypes.ItemIndex != -1)
                Job_Dis_ID = LUEJobDescriptionsTypes.EditValue.ToString();
            else
                Job_Dis_ID = "NULL";

            string Work_Start_Date;
            if (DEWorkDate1.Text.Trim().Length != 0)
                Work_Start_Date = String.Format("Convert(Datetime, '{0}', 103)", DEWorkDate1.Text);
            else
                Work_Start_Date = "NULL";

            string Ac_Start_Date;
            if (DEWorkDate2.Text.Trim().Length != 0)
                Ac_Start_Date = String.Format("Convert(Datetime, '{0}', 103)", DEWorkDate2.Text);
            else
                Ac_Start_Date = "NULL";

            string tameen_no;
            if (TxtSecurityNo.Text.Trim().Length != 0)
                tameen_no = String.Format("N'{0}'", TxtSecurityNo.Text);
            else
                tameen_no = "NULL";

            string tameen_date1;
            if (DESecurityDate1.Text.Trim().Length != 0)
                tameen_date1 = String.Format("Convert(Datetime, '{0}', 103)", DESecurityDate1.Text);
            else
                tameen_date1 = "NULL";

            string tameen_date2;
            if (DESecurityDate2.Text.Trim().Length != 0)
                tameen_date2 = String.Format("Convert(Datetime, '{0}', 103)", DESecurityDate2.Text);
            else
                tameen_date2 = "NULL";

            string betaka_tameen;
            if (TxtSecurityCardNo.Text.Trim().Length != 0)
                betaka_tameen = String.Format("N'{0}'", TxtSecurityCardNo.Text);
            else
                betaka_tameen = "NULL";

            string Moaahel_ID;
            if (LUEQualifierTypes.ItemIndex != -1)
                Moaahel_ID = LUEQualifierTypes.EditValue.ToString();
            else
                Moaahel_ID = "NULL";

            string Moaahel_Date;
            if (DEQualifierDate.Text.Trim().Length != 0)
                Moaahel_Date = String.Format("Convert(Datetime, '{0}', 103)", DEQualifierDate.Text);
            else
                Moaahel_Date = "NULL";

            string SPECIFICATION_ID;
            if (LUESpecialtyTypes.ItemIndex != -1)
                SPECIFICATION_ID = LUESpecialtyTypes.EditValue.ToString();
            else
                SPECIFICATION_ID = "NULL";

            string University_ID;
            if (LUESpecialtySideTypes.ItemIndex != -1)
                University_ID = LUESpecialtySideTypes.EditValue.ToString();
            else
                University_ID = "NULL";
            
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format(@"INSERT INTO Emp_Master (EmpID, EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, Emp_Full_Name, BIRTH_DATE, Social_id, GENDER_ID, Religion_id, JOB_STATUS_ID, tagned_id, BIRTH_GOV, Nationality_id, Emp_Address, PHONE_NO, MOBILE_NO, job_id, Job_Dis_ID, Work_Start_Date, Ac_Start_Date, tameen_no, tameen_date1, tameen_date2, betaka_tameen, Moaahel_ID, Moaahel_Date, SPECIFICATION_ID, University_ID, EmpPic) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, @MemPic)", EmpID, EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, Emp_Full_Name, BIRTH_DATE, Social_id, GENDER_ID, Religion_id, JOB_STATUS_ID, tagned_id, BIRTH_GOV, Nationality_id, Emp_Address, PHONE_NO, MOBILE_NO, job_id, Job_Dis_ID, Work_Start_Date, Ac_Start_Date, tameen_no, tameen_date1, tameen_date2, betaka_tameen, Moaahel_ID, Moaahel_Date, SPECIFICATION_ID, University_ID), Con);
                try
                {
                    byte[] MemPic = null;
                    MemoryStream ms = new MemoryStream();
                    Image NOimg = global::E_Club_Emp_Manager.Properties.Resources.NoImage;
                    if (PicEmp.Image != null)
                        PicEmp.Image.Save(ms, PicEmp.Image.RawFormat);
                    else
                        NOimg.Save(ms, NOimg.RawFormat);
                    MemPic = ms.GetBuffer();
                    Cmd.Parameters.AddWithValue("@MemPic", MemPic);

                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    BtnClear_Click(BtnClear, new EventArgs());
                    TxtName1.Focus();
                    MCls.msg("تم اضافــة الموظف", false, "", this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCode.Text = string.Empty;
            TxtSSN.Text = string.Empty;
            TxtName1.Text = string.Empty;
            TxtName2.Text = string.Empty;
            TxtName3.Text = string.Empty;
            TxtName4.Text = string.Empty;
            TxtNameAll.Text = string.Empty;
            DEBirth.DeselectAll();
            TxtAge.Text = string.Empty;
            LUESocialStateTypes.EditValue = null;
            LUEGender.EditValue = null;
            LUEReligionTypes.EditValue = null;
            LUEStates.EditValue = null;
            LUEMilitaryStateTypes.EditValue = null;
            LUECitys.EditValue = null;
            LUENationalityType.EditValue = null;
            TxtAddress.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtMobile.Text = string.Empty;
            LUEJobTypes.EditValue = null;
            LUEJobDescriptionsTypes.EditValue = null;
            DEWorkDate1.DeselectAll();
            DEWorkDate2.DeselectAll();
            TxtSecurityNo.Text = string.Empty;
            DESecurityDate1.DeselectAll();
            DESecurityDate2.DeselectAll();
            TxtSecurityCardNo.Text = string.Empty;
            LUEQualifierTypes.EditValue = null;
            DEQualifierDate.DeselectAll();
            LUESpecialtyTypes.EditValue = null;
            LUESpecialtySideTypes.EditValue = null;
            PicEmp.Image = null;
            GetFreeEmpID();
        }
        private void LUEJobTypes_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEJobTypes.ItemIndex > -1)
                LoadJobDescriptions(JobTypesTBL.Rows[LUEJobTypes.ItemIndex]["job_id"].ToString());
            else
                LUEJobDescriptionsTypes.ItemIndex = -1;
        }
        private void LUEQualifierTypes_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEQualifierTypes.ItemIndex > -1)
                LoadSpecialtyTypes(QualifierTypesTBL.Rows[LUEQualifierTypes.ItemIndex]["Moaahel_ID"].ToString());
            else
                LUESpecialtyTypes.ItemIndex = -1;
        }
        private void DEBirth_EditValueChanged(object sender, EventArgs e)
        {
            if (DEBirth.EditValue != null)
                TxtAge.Text = (Convert.ToInt16(DateTime.Now.Year) - Convert.ToInt16(DEBirth.DateTime.Year)).ToString();
            else
                TxtAge.Text = string.Empty;
        }
        private void DEBirthEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (DEBirthEdit.EditValue != null)
                TxtAgeEdit.Text = (Convert.ToInt16(DateTime.Now.Year) - Convert.ToInt16(DEBirthEdit.DateTime.Year)).ToString();
            else
                TxtAgeEdit.Text = string.Empty;
        }
        private void TxtNames_TextChanged(object sender, EventArgs e)
        {
            TxtNameAll.Text = String.Format("{0} {1} {2} {3}", TxtName1.Text, TxtName2.Text, TxtName3.Text, TxtName4.Text);
        }
        private void TxtNamesEdit_TextChanged(object sender, EventArgs e)
        {
            TxtNameAllEdit.Text = String.Format("{0} {1} {2} {3}", TxtName1Edit.Text, TxtName2Edit.Text, TxtName3Edit.Text, TxtName4Edit.Text);
        }
        private void AddEmployeeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            GetFreeEmpID();
        }
        private void xtraTabControl2_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEditing)
                LoadAllEmp();
        }
        public AddEmployeeFrm()
        {
            InitializeComponent();
        }
        private void LUEEmp_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
                return;
            DataRow row = EmpTbl.Rows[LUEEmp.ItemIndex];

            TxtCodeEdit.Text = row["EmpID"].ToString();
            TxtSSNEdit.Text = row["EmpNationalID"].ToString();
            TxtName1Edit.Text = row["EMP_FIRST_NAME"].ToString();
            TxtName2Edit.Text = row["EMP_FATHER_NAME"].ToString();
            TxtName3Edit.Text = row["EMP_FAM_NAME"].ToString();
            TxtName4Edit.Text = row["EMP_FOURTH_NAME"].ToString();
            TxtNameAllEdit.Text = row["Emp_Full_Name"].ToString();
            if (row["BIRTH_DATE"].ToString() != string.Empty)
                DEBirthEdit.EditValue = row["BIRTH_DATE"].ToString();
            else
                DEBirthEdit.EditValue = null;
            DEBirthEdit_EditValueChanged(DEBirthEdit, new EventArgs());
            if (row["Social_id"].ToString() != string.Empty)
                LUESocialStateTypesEdit.EditValue = row["Social_id"];
            else
                LUESocialStateTypesEdit.EditValue = null;
            if (row["GENDER_ID"].ToString() != string.Empty)
                LUEGenderEdit.EditValue = row["GENDER_ID"];
            else
                LUEGenderEdit.EditValue = null;
            if (row["Religion_id"].ToString() != string.Empty)
                LUEReligionTypesEdit.EditValue = row["Religion_id"];
            else
                LUEReligionTypesEdit.EditValue = null;
            if (row["JOB_STATUS_ID"].ToString() != string.Empty)
                LUEStatesEdit.EditValue = row["JOB_STATUS_ID"];
            else
                LUEStatesEdit.EditValue = null;

            if (row["Religion_id"].ToString() != string.Empty)
                LUEReligionTypesEdit.EditValue = row["Religion_id"];
            else
                LUEReligionTypesEdit.EditValue = null;
            if (row["tagned_id"].ToString() != string.Empty)
                LUEMilitaryStateTypesEdit.EditValue = row["tagned_id"];
            else
                LUEMilitaryStateTypesEdit.EditValue = null;
            if (row["BIRTH_GOV"].ToString() != string.Empty)
                LUECitysEdit.EditValue = row["BIRTH_GOV"];
            else
                LUECitysEdit.EditValue = null;
            if (row["Nationality_id"].ToString() != string.Empty)
                LUENationalityTypeEdit.EditValue = row["Nationality_id"];
            else
                LUENationalityTypeEdit.EditValue = null;
            TxtAddressEdit.Text = row["Emp_Address"].ToString();
            TxtPhoneEdit.Text = row["PHONE_NO"].ToString();
            TxtMobileEdit.Text = row["MOBILE_NO"].ToString();
            if (row["job_id"].ToString() != string.Empty)
                LUEJobTypesEdit.EditValue = row["job_id"];
            else
                LUEJobTypesEdit.EditValue = null;
            if (row["Job_Dis_ID"].ToString() != string.Empty)
                LUEJobDescriptionsTypesEdit.EditValue = row["Job_Dis_ID"];
            else
                LUEJobDescriptionsTypesEdit.EditValue = null;

            DEWorkDate1Edit.EditValue = row["Work_Start_Date"].ToString();
            DEWorkDate2Edit.EditValue = row["Ac_Start_Date"].ToString();

            TxtSecurityNoEdit.Text = row["tameen_no"].ToString();
            DESecurityDate1Edit.EditValue = row["tameen_date1"].ToString();
            DESecurityDate2Edit.EditValue = row["tameen_date2"].ToString();
            TxtSecurityCardNoEdit.Text = row["betaka_tameen"].ToString();
            if (row["Moaahel_ID"].ToString() != string.Empty)
                LUEQualifierTypesEdit.EditValue = row["Moaahel_ID"];
            else
                LUEQualifierTypesEdit.EditValue = null;
            DEQualifierDateEdit.EditValue = row["Moaahel_Date"].ToString();
            if (row["SPECIFICATION_ID"].ToString() != string.Empty)
                LUESpecialtyTypesEdit.EditValue = row["SPECIFICATION_ID"];
            else
                LUESpecialtyTypesEdit.EditValue = null;
            if (row["University_ID"].ToString() != string.Empty)
                LUESpecialtySideTypesEdit.EditValue = row["University_ID"];
            else
                LUESpecialtySideTypesEdit.EditValue = null;

            if (DBNull.Value != row["EmpPic"])
            {
                byte[] PicByte = (byte[])row["EmpPic"];
                MemoryStream ms = new MemoryStream(PicByte);
                PicEmpEdit.Image = Image.FromStream(ms);
            }
            else
                PicEmpEdit.Image = null;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
                return;
            byte[] MemPic = null;

            string EmpID;
            if (TxtCodeEdit.Text.Trim().Length != 0)
                EmpID = TxtCodeEdit.Text;
            else
                EmpID = "NULL";
            string EmpNationalID;
            if (TxtSSNEdit.Text.Trim().Length != 0)
                EmpNationalID = String.Format("N'{0}'", TxtSSNEdit.Text);
            else
                EmpNationalID = "NULL";

            string EMP_FIRST_NAME;
            if (TxtName1Edit.Text.Trim().Length != 0)
                EMP_FIRST_NAME = String.Format("N'{0}'", TxtName1Edit.Text);
            else
                EMP_FIRST_NAME = "NULL";

            string EMP_FATHER_NAME;
            if (TxtName2Edit.Text.Trim().Length != 0)
                EMP_FATHER_NAME = String.Format("N'{0}'", TxtName2Edit.Text);
            else
                EMP_FATHER_NAME = "NULL";

            string EMP_FAM_NAME;
            if (TxtName3Edit.Text.Trim().Length != 0)
                EMP_FAM_NAME = String.Format("N'{0}'", TxtName3Edit.Text);
            else
                EMP_FAM_NAME = "NULL";

            string EMP_FOURTH_NAME;
            if (TxtName4Edit.Text.Trim().Length != 0)
                EMP_FOURTH_NAME = String.Format("N'{0}'", TxtName4Edit.Text);
            else
                EMP_FOURTH_NAME = "NULL";

            string Emp_Full_Name;
            if (TxtNameAllEdit.Text.Trim().Length != 0)
                Emp_Full_Name = String.Format("N'{0}'", TxtNameAllEdit.Text);
            else
                Emp_Full_Name = "NULL";

            string BIRTH_DATE;
            if (DEBirthEdit.Text.Trim().Length != 0)
                BIRTH_DATE = String.Format("Convert(Datetime, '{0}', 103)", DEBirthEdit.Text);
            else
                BIRTH_DATE = "NULL";

            string Social_id;
            if (LUESocialStateTypesEdit.ItemIndex != -1)
                Social_id = LUESocialStateTypesEdit.EditValue.ToString();
            else
                Social_id = "NULL";

            string GENDER_ID;
            if (LUEGenderEdit.ItemIndex != -1)
                GENDER_ID = LUEGenderEdit.EditValue.ToString();
            else
                GENDER_ID = "NULL";

            string Religion_id;
            if (LUEReligionTypesEdit.ItemIndex != -1)
                Religion_id = LUEReligionTypesEdit.EditValue.ToString();
            else
                Religion_id = "NULL";

            string JOB_STATUS_ID;
            if (LUEStatesEdit.ItemIndex != -1)
                JOB_STATUS_ID = LUEStatesEdit.EditValue.ToString();
            else
                JOB_STATUS_ID = "NULL";

            string tagned_id;
            if (LUEMilitaryStateTypesEdit.ItemIndex != -1)
                tagned_id = LUEMilitaryStateTypesEdit.EditValue.ToString();
            else
                tagned_id = "NULL";

            string BIRTH_GOV;
            if (LUECitysEdit.ItemIndex != -1)
                BIRTH_GOV = LUECitysEdit.EditValue.ToString();
            else
                BIRTH_GOV = "NULL";

            string Nationality_id;
            if (LUENationalityTypeEdit.ItemIndex != -1)
                Nationality_id = LUENationalityTypeEdit.EditValue.ToString();
            else
                Nationality_id = "NULL";

            string Emp_Address;
            if (TxtAddressEdit.Text.Trim().Length != 0)
                Emp_Address = String.Format("N'{0}'", TxtAddressEdit.Text);
            else
                Emp_Address = "NULL";

            string PHONE_NO;
            if (TxtPhoneEdit.Text.Trim().Length != 0)
                PHONE_NO = String.Format("N'{0}'", TxtPhoneEdit.Text);
            else
                PHONE_NO = "NULL";

            string MOBILE_NO;
            if (TxtMobileEdit.Text.Trim().Length != 0)
                MOBILE_NO = String.Format("N'{0}'", TxtMobileEdit.Text);
            else
                MOBILE_NO = "NULL";

            string job_id;
            if (LUEJobTypesEdit.ItemIndex != -1)
                job_id = LUEJobTypesEdit.EditValue.ToString();
            else
                job_id = "NULL";

            string Job_Dis_ID;
            if (LUEJobDescriptionsTypesEdit.ItemIndex != -1)
                Job_Dis_ID = LUEJobDescriptionsTypesEdit.EditValue.ToString();
            else
                Job_Dis_ID = "NULL";

            string Work_Start_Date;
            if (DEWorkDate1Edit.Text.Trim().Length != 0)
                Work_Start_Date = String.Format("Convert(Datetime, '{0}', 103)", DEWorkDate1Edit.Text);
            else
                Work_Start_Date = "NULL";

            string Ac_Start_Date;
            if (DEWorkDate2Edit.Text.Trim().Length != 0)
                Ac_Start_Date = String.Format("Convert(Datetime, '{0}', 103)", DEWorkDate2Edit.Text);
            else
                Ac_Start_Date = "NULL";

            string tameen_no;
            if (TxtSecurityNoEdit.Text.Trim().Length != 0)
                tameen_no = String.Format("N'{0}'", TxtSecurityNoEdit.Text);
            else
                tameen_no = "NULL";

            string tameen_date1;
            if (DESecurityDate1Edit.Text.Trim().Length != 0)
                tameen_date1 = String.Format("Convert(Datetime, '{0}', 103)", DESecurityDate1Edit.Text);
            else
                tameen_date1 = "NULL";

            string tameen_date2;
            if (DESecurityDate2Edit.Text.Trim().Length != 0)
                tameen_date2 = String.Format("Convert(Datetime, '{0}', 103)", DESecurityDate2Edit.Text);
            else
                tameen_date2 = "NULL";

            string betaka_tameen;
            if (TxtSecurityCardNoEdit.Text.Trim().Length != 0)
                betaka_tameen = String.Format("N'{0}'", TxtSecurityCardNoEdit.Text);
            else
                betaka_tameen = "NULL";

            string Moaahel_ID;
            if (LUEQualifierTypesEdit.ItemIndex != -1)
                Moaahel_ID = LUEQualifierTypesEdit.EditValue.ToString();
            else
                Moaahel_ID = "NULL";

            string Moaahel_Date;
            if (DEQualifierDateEdit.Text.Trim().Length != 0)
                Moaahel_Date = String.Format("Convert(Datetime, '{0}', 103)", DEQualifierDateEdit.Text);
            else
                Moaahel_Date = "NULL";

            string SPECIFICATION_ID;
            if (LUESpecialtyTypesEdit.ItemIndex != -1)
                SPECIFICATION_ID = LUESpecialtyTypesEdit.EditValue.ToString();
            else
                SPECIFICATION_ID = "NULL";

            string University_ID;
            if (LUESpecialtySideTypesEdit.ItemIndex != -1)
                University_ID = LUESpecialtySideTypesEdit.EditValue.ToString();
            else
                University_ID = "NULL";

            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format(@"UPDATE Emp_Master Set EmpNationalID = {0}, EMP_FIRST_NAME = {1}, EMP_FATHER_NAME = {2}, EMP_FAM_NAME = {3}, EMP_FOURTH_NAME = {4}, 
                Emp_Full_Name = {5}, BIRTH_DATE = {6}, Social_id = {7}, GENDER_ID = {8}, Religion_id = {9}, JOB_STATUS_ID = {10}, tagned_id = {11}, BIRTH_GOV = {12}, Nationality_id = {13}, Emp_Address = {14}, PHONE_NO = {15}, MOBILE_NO = {16}, job_id = {17}, 
                Job_Dis_ID = {18}, Work_Start_Date = {19}, Ac_Start_Date = {20}, tameen_no = {21}, tameen_date1 = {22}, tameen_date2 = {23}, betaka_tameen = {24}, Moaahel_ID = {25}, Moaahel_Date = {26}, SPECIFICATION_ID = {27}, University_ID = {28}, EmpPic = @MemPic Where EmpID = {29}",
                EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, Emp_Full_Name, BIRTH_DATE, Social_id, GENDER_ID, Religion_id, JOB_STATUS_ID, tagned_id, BIRTH_GOV, Nationality_id, Emp_Address, PHONE_NO, MOBILE_NO, job_id, Job_Dis_ID, Work_Start_Date,
                Ac_Start_Date, tameen_no, tameen_date1, tameen_date2, betaka_tameen, Moaahel_ID, Moaahel_Date, SPECIFICATION_ID, University_ID, LUEEmp.EditValue), Con);
                try
                {
                    MemoryStream ms = new MemoryStream();
                    Image NOimg = global::E_Club_Emp_Manager.Properties.Resources.NoImage;
                    if (PicEmpEdit.Image != null)
                        PicEmpEdit.Image.Save(ms, PicEmpEdit.Image.RawFormat);
                    else
                        NOimg.Save(ms, NOimg.RawFormat);
                    
                    MemPic = ms.GetBuffer();
                    Cmd.Parameters.AddWithValue("@MemPic", MemPic);
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadAllEmp();
                    BtnClear_Click(BtnClear, new EventArgs());
                    TxtName1.Focus();
                    MCls.msg("تم تعديل الموظف", false, "", this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
                return;
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMalafat);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = "Delete From Emp_Master Where EmpID = " + LUEEmp.EditValue;
                con.Open();
                cmd.ExecuteNonQuery();
                LoadAllEmp();
                MCls.msg("تم حذف الموظف", false, "", this);
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        #endregion

    }
}