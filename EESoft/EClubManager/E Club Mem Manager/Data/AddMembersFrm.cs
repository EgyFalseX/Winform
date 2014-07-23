using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace E_Club_Mem_Manager
{
    public partial class AddMembersFrm : Form
    {

        // What is "MEM_GOV" in TBL_members


        DataTable GenderTB = new DataTable("Genders");
        DataTable NationalityTB = new DataTable("Nationalities");
        DataTable ReligionTB = new DataTable("Religions");
        DataTable SocialTB = new DataTable("Socials");
        DataTable SubscriptionTB = new DataTable("Subscriptions");
        DataTable StatesTB = new DataTable("States");
        DataTable jobTB = new DataTable("jobs");
        DataTable StationTB = new DataTable("Stations");
        DataTable QualificationTB = new DataTable("Qualifications");
        DataTable Members = new DataTable("Members");
        DataTable CD_CurrentStateTbl = new DataTable("CD_CurrentState");
        DataTable Cd_asaseTbl = new DataTable("Cd_asase");
        DataTable TBL_FallMembershipTbl = new DataTable("TBL_FallMembership");
        DataTable CD_FALLReasonTbl = new DataTable("CD_FALLReason");

        string MembersPhotosPath = string.Empty;
        string MembersPhotosPathEdit = string.Empty;

        public AddMembersFrm()
        {
            InitializeComponent();
            
        }
        private void LoadData()
        {
            
            GenderTB = new DataTable("Genders");
            NationalityTB = new DataTable("Nationalities");
            ReligionTB = new DataTable("Religions");
            SocialTB = new DataTable("Socials");
            SubscriptionTB = new DataTable("Subscriptions");
            StatesTB = new DataTable("States");
            jobTB = new DataTable("jobs");
            QualificationTB = new DataTable("Qualifications");
            CD_FALLReasonTbl = new DataTable("CD_FALLReason");
            SqlDataAdapter DA = new SqlDataAdapter("", Program.MC.SQLConStrMembers);
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand CMD = new SqlCommand("", Con);
            try
            {
                // Load Some Information need it.
                DA.SelectCommand.CommandText = "Select CurrentStateID, CurrentState From CD_CurrentState";
                DA.Fill(CD_CurrentStateTbl);
                CBCurrentStateID.DataSource = CD_CurrentStateTbl;
                CBCurrentStateID.ValueMember = "CurrentStateID";
                CBCurrentStateID.DisplayMember = "CurrentState";
                CBEditCurrentStateID.DataSource = CD_CurrentStateTbl;
                CBEditCurrentStateID.ValueMember = "CurrentStateID";
                CBEditCurrentStateID.DisplayMember = "CurrentState";

                DA.SelectCommand.CommandText = "Select asasecode, asasename From Cd_asase";
                DA.Fill(Cd_asaseTbl);
                CBasaseStart.DataSource = Cd_asaseTbl;
                CBasaseStart.ValueMember = "asasecode";
                CBasaseStart.DisplayMember = "asasename";
                CBEditasaseStart.DataSource = Cd_asaseTbl;
                CBEditasaseStart.ValueMember = "asasecode";
                CBEditasaseStart.DisplayMember = "asasename";

                DA.SelectCommand.CommandText = "SELECT gender_ID, gender_name FROM CD_gender";
                DA.Fill(GenderTB);
                CBGender.DataSource = GenderTB;
                CBGender.ValueMember = "gender_ID";
                CBGender.DisplayMember = "gender_name";
                CBGenderEdit.DataSource = GenderTB;
                CBGenderEdit.ValueMember = "gender_ID";
                CBGenderEdit.DisplayMember = "gender_name";


                DA.SelectCommand.CommandText = "SELECT Nationality_id, Nationality FROM CD_Nationality";
                DA.Fill(NationalityTB);
                CBNationality.DataSource = NationalityTB;
                CBNationality.ValueMember = "Nationality_id";
                CBNationality.DisplayMember = "Nationality";
                CBNationalityEdit.DataSource = NationalityTB;
                CBNationalityEdit.ValueMember = "Nationality_id";
                CBNationalityEdit.DisplayMember = "Nationality";

                DA.SelectCommand.CommandText = "SELECT Religion_id, Religion FROM CD_Religion";
                DA.Fill(ReligionTB);
                CBReligion.DataSource = ReligionTB;
                CBReligion.ValueMember = "Religion_id";
                CBReligion.DisplayMember = "Religion";
                CBReligionEdit.DataSource = ReligionTB;
                CBReligionEdit.ValueMember = "Religion_id";
                CBReligionEdit.DisplayMember = "Religion";

                DA.SelectCommand.CommandText = "SELECT Social_id, Social FROM CD_Social";
                DA.Fill(SocialTB);
                CBSocial.DataSource = SocialTB;
                CBSocial.ValueMember = "Social_id";
                CBSocial.DisplayMember = "Social";
                CBSocialEdit.DataSource = SocialTB;
                CBSocialEdit.ValueMember = "Social_id";
                CBSocialEdit.DisplayMember = "Social";

                DA.SelectCommand.CommandText = "SELECT Subscription_type_id, Subscription_type FROM CD_Subscription_type";
                DA.Fill(SubscriptionTB);
                CBSubscriptionType.DataSource = SubscriptionTB;
                CBSubscriptionType.ValueMember = "Subscription_type_id";
                CBSubscriptionType.DisplayMember = "Subscription_type";
                CBSubscriptionTypeEdit.DataSource = SubscriptionTB;
                CBSubscriptionTypeEdit.ValueMember = "Subscription_type_id";
                CBSubscriptionTypeEdit.DisplayMember = "Subscription_type";

                DA.SelectCommand.CommandText = "SELECT GOV_ID, GOV FROM CD_GOV";
                DA.Fill(StatesTB);
                CBStates.DataSource = StatesTB;
                CBStates.ValueMember = "GOV_ID";
                CBStates.DisplayMember = "GOV";
                CBStatesEdit.DataSource = StatesTB;
                CBStatesEdit.ValueMember = "GOV_ID";
                CBStatesEdit.DisplayMember = "GOV";

                DA.SelectCommand.CommandText = "SELECT job_id, job FROM CD_job";
                DA.Fill(jobTB);
                CBJobs.DataSource = jobTB;
                CBJobs.ValueMember = "job_id";
                CBJobs.DisplayMember = "job";
                CBJobsEdit.DataSource = jobTB;
                CBJobsEdit.ValueMember = "job_id";
                CBJobsEdit.DisplayMember = "job";

                DA.SelectCommand.CommandText = "SELECT Qualification_id, Qualification FROM CD_Qualification";
                DA.Fill(QualificationTB);
                CBQua.DataSource = QualificationTB;
                CBQua.ValueMember = "Qualification_id";
                CBQua.DisplayMember = "Qualification";
                CBQuaEdit.DataSource = QualificationTB;
                CBQuaEdit.ValueMember = "Qualification_id";
                CBQuaEdit.DisplayMember = "Qualification";


                //CBStations
                DA.SelectCommand.CommandText = "SELECT markz_ID, MARKZ FROM CD_MARKZ";
                DataTable DTMarkz = new DataTable("FX2011-02");
                DA.Fill(DTMarkz);
                CBStationsEdit.DataSource = DTMarkz;
                CBStationsEdit.ValueMember = "markz_ID";
                CBStationsEdit.DisplayMember = "MARKZ";

                //CD_FALLReason
                DA.SelectCommand.CommandText = "Select FALLReasonID, FALLReasonNAME From CD_FALLReason";
                DA.Fill(CD_FALLReasonTbl);
                LUEFALLReasonID.Properties.DataSource = CD_FALLReasonTbl;
                LUEFALLReasonID.Properties.ValueMember = "FALLReasonID";
                LUEFALLReasonID.Properties.DisplayMember = "FALLReasonNAME";

                // Get Members Photos Path
                CMD.CommandText = "SELECT TOP (1) path_attach_emp FROM ATT_company_data";
                Con.Open();
                MembersPhotosPath = CMD.ExecuteScalar().ToString();
                
                if (MembersPhotosPath == string.Empty)
                {
                    Con.Close();
                    MessageBox.Show("مسار صور الاعضاء غير صحيح", "بيان اساسي مفقود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                if (Directory.Exists(MembersPhotosPath) == false)
                    Directory.CreateDirectory(MembersPhotosPath);
                if (MembersPhotosPath.Substring(MembersPhotosPath.Length - 1) != @"\")
                    MembersPhotosPath += "\\";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }
        private void LoadAllMembers()
        {
            //CONVERT(DATETIME, mem_bdate, 20) AS mem_bdate
            Members = Program.MC.LoadDataTable(@"SELECT mem_ID, mem_firstname, mem_fathername, mem_grandname, mem_famname, mem_name, mem_NNumber, mem_gender, mem_Religion, mem_Nationality, 
            mem_Social, CONVERT(varchar, mem_bdate, 103) AS mem_bdate, mem_job, mem_jobDetail, mem_markz, mem_address, mem_mNUMBER, MEM_GOV, mem_gov_eork, mem_parent, mem_Case, 
            Qualification_id, tel_house, tel_mobile, morafk, Kinship_id, Subscription_type_id, MemPic, Approvalno, CONVERT(varchar, Approvaldate, 103) AS Approvaldate, CurrentStateID, asaseStart
            FROM TBL_members", Program.MC.SQLConStrMembers);
            CBMembers.DataSource = Members;
            CBMembers.DisplayMember = "mem_name";
            CBMembers.ValueMember = "mem_ID";
        }
        private void GetNewMemberCode()
        {
            string MemberCode = string.Empty;
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand CMD = new SqlCommand("SELECT MAX(mem_ID) AS mem_ID FROM TBL_members", Con);
            try
            {
                Con.Open();
                MemberCode = CMD.ExecuteScalar().ToString();
                if (MemberCode == string.Empty)
                    MemberCode = DateTime.Now.Year.ToString() + 1;
                else
                    MemberCode = (Convert.ToInt16(MemberCode) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطــــــا في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con.Close();
            TxtMemCode.Text = MemberCode;
        }
        private void ClearForm()
        {
            TxtMemCode.Text = string.Empty;
            TxtSNN.Text = string.Empty;
            Txt1stName.Text = string.Empty;
            Txt3rdName.Text = string.Empty;
            TxtMemXCode.Text = string.Empty;
            Txt2ndName.Text = string.Empty;
            Txt4thName.Text = string.Empty;
            TxtFullName.Text = string.Empty;
            LblPhotoPath.Text = string.Empty;
            TxtJobDes.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtMobile.Text = string.Empty;
            PBMemPhoto.Image = null;
        }
        private void UpdateMemCounter()
        {
            LblMemCount.Text = Program.MC.LoadDataTableMem(@"SELECT ISNULL(COUNT(mem_ID), 0) AS MemCount FROM TBL_members").Rows[0][0].ToString();
            DataTable dt = Program.MC.LoadDataTableMem(@"SELECT TOP (1) mem_name FROM TBL_members ORDER BY mem_ID DESC");
            if (dt.Rows.Count == 0)
                LblLastMem.Text = string.Empty;
            else
                LblLastMem.Text = dt.Rows[0][0].ToString();
        }
        private void LoadMemFall(string mem_ID)
        {
            TBL_FallMembershipTbl = Program.MC.LoadDataTableMem(string.Format(@"Select mem_ID, Convert(nvarchar, FALLDATE, 103) AS FALLDATE, FALLReasonID, FALLREMARK, 
            (Select FALLReasonNAME From CD_FALLReason Where FALLReasonID = TBL_FallMembership.FALLReasonID) AS FALLReasonNAME From TBL_FallMembership
            Where mem_ID = {0}", mem_ID));
            gridControlFall.DataSource = TBL_FallMembershipTbl;
        }
        private void AddMembersFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            GetNewMemberCode();
            UpdateMemCounter();
        }
        private void BtnClearImage_Click(object sender, EventArgs e)
        {
            PBMemPhoto.Image = null;
        }
        private void BtnCleaImageEdit_Click(object sender, EventArgs e)
        {
            PBMemPhotoEdit.Image = null;
        }
        private void CBStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GOV_ID;
            if (CBStates.SelectedIndex != 0)
                GOV_ID = CBStates.SelectedValue.ToString();
            else
                GOV_ID = "NULL";
            StationTB = new DataTable("Stations");
            SqlDataAdapter DA = new SqlDataAdapter("SELECT markz_ID, MARKZ FROM CD_MARKZ WHERE GOV_ID = " + GOV_ID , Program.MC.SQLConStrMembers);
            try
            {
                DA.Fill(StationTB);
                CBStations.DataSource = StationTB;
                CBStations.ValueMember = "markz_ID";
                CBStations.DisplayMember = "MARKZ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnEmpInfo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GetNewMemberCode();
        }
        private void BtnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            OFD.FilterIndex = 1;
            OFD.CheckFileExists = true;
            OFD.CheckPathExists = true;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                LblPhotoPath.Text = OFD.FileName;
                PBMemPhoto.Image = Image.FromFile(OFD.FileName);
                if (File.Exists(MembersPhotosPath + TxtMemCode))
                    File.Delete(MembersPhotosPath + TxtMemCode);
            }

        }
        private void BtnChoosePhotoEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            OFD.FilterIndex = 1;
            OFD.CheckFileExists = true;
            OFD.CheckPathExists = true;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                LblPhotoPathEdit.Text = OFD.FileName;
                PBMemPhotoEdit.Image = Image.FromFile(OFD.FileName);
                if (File.Exists(MembersPhotosPathEdit + TxtMemCodeEdit))
                    File.Delete(MembersPhotosPathEdit + TxtMemCodeEdit);
            }
        }
        private void TxtNames_TextChanged(object sender, EventArgs e)
        {
            TxtFullName.Text = String.Format("{0} {1} {2} {3}", Txt1stName.Text, Txt2ndName.Text, Txt3rdName.Text, Txt4thName.Text);
        }
        private void TxtNamesEdit_TextChanged(object sender, EventArgs e)
        {
            TxtFullNameEdit.Text = String.Format("{0} {1} {2} {3}", Txt1stNameEdit.Text, Txt2ndNameEdit.Text, Txt3rdNameEdit.Text, Txt4thNameEdit.Text);
        }
        private void CBMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMembers.SelectedIndex == -1)
                return;
            DataRow row = Members.Rows[CBMembers.SelectedIndex];
            TxtMemCodeEdit.Text = row["mem_ID"].ToString();
            TxtMemXCodeEdit.Text = row["mem_mNUMBER"].ToString();
            TxtSNNEdit.Text = row["mem_NNumber"].ToString();
            if (row["mem_gender"].ToString() != string.Empty)
                CBGenderEdit.SelectedValue = row["mem_gender"].ToString();
            else
                CBGenderEdit.SelectedIndex = -1;
            Txt1stNameEdit.Text = row["mem_firstname"].ToString();
            Txt2ndNameEdit.Text = row["mem_fathername"].ToString();
            Txt3rdNameEdit.Text = row["mem_grandname"].ToString();
            Txt4thNameEdit.Text = row["mem_famname"].ToString();
            TxtFullNameEdit.Text = row["mem_name"].ToString();
            if (row["mem_bdate"].ToString() != string.Empty)
                DEDateEdit.EditValue = row["mem_bdate"].ToString();
            else
                DEDateEdit.EditValue = null;
            if (row["mem_Religion"].ToString() != string.Empty)
                CBReligionEdit.SelectedValue = row["mem_Religion"].ToString();
            else
                CBReligionEdit.SelectedIndex = -1;
            if (row["mem_Social"].ToString() != string.Empty)
                CBSocialEdit.SelectedValue = row["mem_Social"].ToString();
            else
                CBSocialEdit.SelectedIndex = -1;
            if (row["mem_Nationality"].ToString() != string.Empty)
                CBNationalityEdit.SelectedValue = row["mem_Nationality"].ToString();
            else
                CBNationalityEdit.SelectedIndex = -1;
            if (row["Subscription_type_id"].ToString() != string.Empty)
                CBSubscriptionTypeEdit.SelectedValue = row["Subscription_type_id"].ToString();
            else
                CBSubscriptionTypeEdit.SelectedIndex = -1;
            // Load Pic
            if (DBNull.Value != row["MemPic"])
            {
                MemoryStream stream = new MemoryStream();
                byte[] MemPic = (byte[])row["MemPic"];
                MemoryStream ms = new MemoryStream(MemPic);
                PBMemPhotoEdit.Image = Image.FromStream(ms);
            }
            else
                PBMemPhotoEdit.Image = null;
            
            if (row["Qualification_id"].ToString() != string.Empty)
                CBQuaEdit.SelectedValue = row["Qualification_id"].ToString();
            else
                CBQuaEdit.SelectedIndex = -1;
            if (row["mem_job"].ToString() != string.Empty)
                CBJobsEdit.SelectedValue = row["mem_job"].ToString();
            else
                CBJobsEdit.SelectedIndex = -1;
            TxtJobDesEdit.Text = row["mem_jobDetail"].ToString();
            if (row["MEM_GOV"].ToString() != string.Empty)
                CBStatesEdit.SelectedValue = row["MEM_GOV"].ToString();
            else
                CBStatesEdit.SelectedIndex = -1;
            if (row["mem_markz"].ToString() != string.Empty)
                CBStationsEdit.SelectedValue = row["mem_markz"].ToString();
            else
                CBStationsEdit.SelectedIndex = -1;
            TxtAddressEdit.Text = row["mem_address"].ToString();
            TxtPhoneEdit.Text = row["tel_house"].ToString();
            TxtMobileEdit.Text = row["tel_mobile"].ToString();

            TxtEditApprovalno.Text = row["Approvalno"].ToString();
            if (row["Approvaldate"].ToString() != string.Empty)
                DEEditApprovaldate.EditValue = row["Approvaldate"].ToString();
            else
                DEEditApprovaldate.EditValue = null;

            if (row["CurrentStateID"].ToString() != string.Empty)
                CBEditCurrentStateID.SelectedValue = row["CurrentStateID"].ToString();
            else
                CBEditCurrentStateID.SelectedIndex = -1;
            if (row["asaseStart"].ToString() != string.Empty)
                CBEditasaseStart.SelectedValue = row["asaseStart"].ToString();
            else
                CBEditasaseStart.SelectedIndex = -1;
            if (row["CurrentStateID"].ToString() == "2")
            {
                LoadMemFall(row["mem_ID"].ToString());// Load Fall
                tabControl2.TabPages.Add(tabPageFall);
            }
            else
                tabControl2.TabPages.Remove(tabPageFall);
            
        }
        private void BtnSaveMem_Click(object sender, EventArgs e)
        {
            if (TxtMemCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("من فضلك ادخل رقم العضو", "تحزيــــــــر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Genders;
            string mem_bdate;
            string Religion;
            string Social;
            string Nationality;
            string SubscriptionType;
            string Qua;
            string Jobs;
            string States;
            string Stations;
            string MemXCode;
            string Approvalno;
            string Approvaldate;
            string CurrentStateID;
            string asaseStart;
            byte[] MemPic = null;
            if (CBGender.SelectedValue != null)
                Genders = CBGender.SelectedValue.ToString();
            else
                Genders = "NULL";
            if (DEDate.EditValue != null)
                mem_bdate = String.Format("CONVERT(DATETIME, '{0}', 103)", DEDate.Text);
            else
                mem_bdate = "NULL";
            if (CBReligion.SelectedValue != null)
                Religion = CBReligion.SelectedValue.ToString();
            else
                Religion = "NULL";
            if (CBSocial.SelectedValue != null)
                Social = CBSocial.SelectedValue.ToString();
            else
                Social = "NULL";
            if (CBNationality.SelectedValue != null)
                Nationality = CBNationality.SelectedValue.ToString();
            else
                Nationality = "NULL";
            if (CBSubscriptionType.SelectedValue != null)
                SubscriptionType = CBSubscriptionType.SelectedValue.ToString();
            else
                SubscriptionType = "NULL";
            if (CBQua.SelectedValue != null)
                Qua = CBQua.SelectedValue.ToString();
            else
                Qua = "NULL";
            if (CBJobs.SelectedValue != null)
                Jobs = CBJobs.SelectedValue.ToString();
            else
                Jobs = "NULL";
            if (CBStates.SelectedValue != null)
                States = CBStates.SelectedValue.ToString();
            else
                States = "NULL";
            if (CBStations.SelectedValue != null)
                Stations = CBStations.SelectedValue.ToString();
            else
                Stations = "NULL";
            if (TxtMemXCode.Text.Trim() != string.Empty)
                MemXCode = TxtMemXCode.Text.Trim();
            else
                MemXCode = "NULL";
            if (TxtApprovalno.Text.Trim() != string.Empty)
                Approvalno = TxtApprovalno.Text.Trim();
            else
                Approvalno = "NULL";
            if (DEApprovaldate.EditValue != null)
                Approvaldate = String.Format("CONVERT(DATETIME, '{0}', 103)", DEApprovaldate.Text);
            else
                Approvaldate = "NULL";
            if (CBCurrentStateID.SelectedValue != null)
                CurrentStateID = CBCurrentStateID.SelectedValue.ToString();
            else
                CurrentStateID = "NULL";
            if (CBasaseStart.SelectedValue != null)
                asaseStart = CBasaseStart.SelectedValue.ToString();
            else
                asaseStart = "NULL";
            //MemoryStream stream = new MemoryStream();
            //byte[] compLogo = (byte[])CompanyDataTbl.Rows[0]["compLogo"];
            //MemoryStream ms = new MemoryStream(compLogo);
            //PicLogo.Image = Image.FromStream(ms);
            GetNewMemberCode();
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand CMD = new SqlCommand(String.Format(@"Set DateFormat DMY INSERT INTO TBL_members (mem_ID, mem_firstname, mem_fathername, mem_grandname, mem_famname, mem_name, mem_NNumber, mem_gender, mem_Religion, mem_Nationality, mem_Social, mem_bdate, mem_job, mem_jobDetail, mem_markz, mem_address, mem_mNUMBER, Qualification_id, tel_house, tel_mobile, Subscription_type_id, MemPic, Approvalno, Approvaldate, CurrentStateID, asaseStart)
            VALUES ({0}, N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', {7}, {8}, {9}, {10}, {11}, {12}, N'{13}', {14}, N'{15}', {16}, {17}, N'{18}', N'{19}', {20}, @MemPic, {21}, {22}, {23}, {24})",
            TxtMemCode.Text, Txt1stName.Text, Txt2ndName.Text, Txt3rdName.Text, Txt4thName.Text, TxtFullName.Text.Trim(), TxtSNN.Text, Genders, Religion, Nationality, Social, mem_bdate, Jobs, TxtJobDes.Text,
            Stations, TxtAddress.Text, MemXCode, Qua, TxtPhone.Text, TxtMobile.Text, SubscriptionType, Approvalno, Approvaldate, CurrentStateID, asaseStart), Con);

            if (LblPhotoPath.Text != string.Empty)
            {
                MemPic = File.ReadAllBytes(LblPhotoPath.Text);
                CMD.Parameters.AddWithValue("@MemPic", MemPic);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                global::E_Club_Mem_Manager.Properties.Resources.NoImage.Save(ms, global::E_Club_Mem_Manager.Properties.Resources.NoImage.RawFormat);
                MemPic = ms.GetBuffer();
                CMD.Parameters.AddWithValue("@MemPic", MemPic);
            }
            try
            {
                Con.Open();
                CMD.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("تم اضافــة العضـــو", "تم الاضافـــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                GetNewMemberCode();
                UpdateMemCounter();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                Con.Close();
            }
            
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (CBMembers.SelectedIndex == -1)
                return;
            if (TxtMemCode.Text.Trim() == string.Empty || Txt1stNameEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("من فضلك ادخل رقم العضو و اسم العضو", "تحزيــــــــر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Genders;
            string mem_bdate;
            string Religion;
            string Social;
            string Nationality;
            string SubscriptionType;
            string Qua;
            string Jobs;
            string States;
            string Stations;
            string MemXCode;
            string Approvalno;
            string Approvaldate;
            string CurrentStateID;
            string asaseStart;
            byte[] MemPic = null;
            if (CBGenderEdit.SelectedValue != null)
                Genders = CBGenderEdit.SelectedValue.ToString();
            else
                Genders = "NULL";
            if (DEDateEdit.EditValue != null)
                mem_bdate = String.Format("CONVERT(DATETIME, '{0}', 103)", DEDateEdit.Text);
            else
                mem_bdate = "NULL";
            if (CBReligionEdit.SelectedValue != null)
                Religion = CBReligionEdit.SelectedValue.ToString();
            else
                Religion = "NULL";
            if (CBSocialEdit.SelectedValue != null)
                Social = CBSocialEdit.SelectedValue.ToString();
            else
                Social = "NULL";
            if (CBNationalityEdit.SelectedValue != null)
                Nationality = CBNationalityEdit.SelectedValue.ToString();
            else
                Nationality = "NULL";
            if (CBSubscriptionTypeEdit.SelectedValue != null)
                SubscriptionType = CBSubscriptionTypeEdit.SelectedValue.ToString();
            else
                SubscriptionType = "NULL";
            if (CBQuaEdit.SelectedValue != null)
                Qua = CBQuaEdit.SelectedValue.ToString();
            else
                Qua = "NULL";
            if (CBJobsEdit.SelectedValue != null)
                Jobs = CBJobsEdit.SelectedValue.ToString();
            else
                Jobs = "NULL";
            if (CBStatesEdit.SelectedValue != null)
                States = CBStatesEdit.SelectedValue.ToString();
            else
                States = "NULL";
            if (CBStationsEdit.SelectedValue != null)
                Stations = CBStationsEdit.SelectedValue.ToString();
            else
                Stations = "NULL";
            if (TxtMemXCodeEdit.Text.Trim() != string.Empty)
                MemXCode = TxtMemXCodeEdit.Text.Trim();
            else
                MemXCode = "NULL";
            if (TxtEditApprovalno.Text.Trim() != string.Empty)
                Approvalno = TxtEditApprovalno.Text.Trim();
            else
                Approvalno = "NULL";
            if (DEEditApprovaldate.EditValue != null)
                Approvaldate = String.Format("CONVERT(DATETIME, '{0}', 103)", DEEditApprovaldate.Text);
            else
                Approvaldate = "NULL";
            if (CBEditCurrentStateID.SelectedValue != null)
                CurrentStateID = CBEditCurrentStateID.SelectedValue.ToString();
            else
                CurrentStateID = "NULL";
            if (CBEditasaseStart.SelectedValue != null)
                asaseStart = CBEditasaseStart.SelectedValue.ToString();
            else
                asaseStart = "NULL";

            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand CMD = new SqlCommand(String.Format(@"Update TBL_members Set mem_firstname = N'{1}', mem_fathername = N'{2}', mem_grandname = N'{3}', mem_famname = N'{4}', mem_name = N'{5}', mem_NNumber = N'{6}', 
            mem_gender = {7}, mem_Religion = {8}, mem_Nationality = {9}, mem_Social = {10}, mem_bdate = {11}, mem_job = {12}, mem_jobDetail = N'{13}', mem_markz = {14}, 
            mem_address = N'{15}', mem_mNUMBER = {16}, Qualification_id = {17}, tel_house = N'{18}', tel_mobile = N'{19}', Subscription_type_id = {20}, MEM_GOV = {21}, MemPic = @MemPic, 
            Approvalno = {22}, Approvaldate = {23}, CurrentStateID = {24}, asaseStart = {25} Where mem_ID = {26}",
            TxtMemCodeEdit.Text, Txt1stNameEdit.Text, Txt2ndNameEdit.Text, Txt3rdNameEdit.Text, Txt4thNameEdit.Text, TxtFullNameEdit.Text.Trim(), TxtSNNEdit.Text, Genders, 
            Religion, Nationality, Social, mem_bdate, Jobs, TxtJobDesEdit.Text, Stations, TxtAddressEdit.Text, MemXCode, Qua, TxtPhoneEdit.Text, TxtMobileEdit.Text, SubscriptionType,
            States, Approvalno, Approvaldate, CurrentStateID, asaseStart, CBMembers.SelectedValue), Con);
            MemoryStream ms = new MemoryStream();
            Image NOimg = global::E_Club_Mem_Manager.Properties.Resources.NoImage;
            if (PBMemPhotoEdit.Image != null)
                PBMemPhotoEdit.Image.Save(ms, PBMemPhotoEdit.Image.RawFormat);
            else
                NOimg.Save(ms, NOimg.RawFormat);
            MemPic = ms.GetBuffer();
            CMD.Parameters.AddWithValue("@MemPic", MemPic);
            try
            {
                Con.Open();
                CMD.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("تم تعديل العضـــو", "تم الاضافـــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllMembers();
                UpdateMemCounter();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                Con.Close();
            }
            
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CBMembers.SelectedIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟","تحزيـــــر!!",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = "Delete From TBL_members Where mem_ID = " + CBMembers.SelectedValue;
                con.Open();
                cmd.ExecuteNonQuery();
                LoadAllMembers();
                UpdateMemCounter();
                MessageBox.Show("تم حذف العضو", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageEditing)
                LoadAllMembers();
        }
        private void repositoryItemButtonEditFallDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيـــــر!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataRow Row =  (DataRow)TBL_FallMembershipTbl.Rows[gridViewFall.GetFocusedDataSourceRowIndex()];
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"Delete From TBL_FallMembership Where mem_ID = {0} And FALLDATE = Convert(Datetime , '{1}', 103)",
                Row["mem_ID"], Row["FALLDATE"]);
                con.Open();
                cmd.ExecuteNonQuery();
                LoadMemFall(Row["mem_ID"].ToString());
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnAddFall_Click(object sender, EventArgs e)
        {
            if (CBMembers.SelectedIndex == -1 || DEFALLDATE.EditValue == null || LUEFALLReasonID.EditValue == null)
            {
                MCls.msg("من فضلك اكمل البيانات", true, "", this);
                return;
            }
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand cmd = new SqlCommand("", con);
            string mem_ID = Members.Rows[CBMembers.SelectedIndex]["mem_ID"].ToString();
            string FALLREMARK;
            if (TxtFALLREMARK.Text.Trim().Length > 0)
                FALLREMARK = String.Format("N'{0}'", TxtFALLREMARK.Text);
            else
                FALLREMARK = "NULL";
            try
            {
                cmd.CommandText = string.Format(@"Insert Into TBL_FallMembership (mem_ID, FALLDATE, FALLReasonID, FALLREMARK) VALUES ({0}, Convert(Datetime, '{1}', 103), {2}, {3})",
                    mem_ID, DEFALLDATE.Text, LUEFALLReasonID.EditValue, FALLREMARK);
                con.Open();
                cmd.ExecuteNonQuery();
                LoadMemFall(mem_ID);
                MCls.msg("تم الاضافه", false, "", this);
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }

        
    }
}
