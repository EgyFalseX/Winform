using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Training_Center
{
    public partial class TBLTrainersFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TBLTrainersFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            repositoryItemGridLookUpEditGenderID.DataSource = MyCL.LoadDataTable("Select GenderID, Gender From CdGender");
            repositoryItemGridLookUpEditGenderID.ValueMember = "GenderID";
            repositoryItemGridLookUpEditGenderID.DisplayMember = "Gender";
            LUEGenderID.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditGenderID.DataSource;
            LUEGenderID.Properties.ValueMember = "GenderID";
            LUEGenderID.Properties.DisplayMember = "Gender";

            repositoryItemGridLookUpEditNationalityId.DataSource = MyCL.LoadDataTable("Select NationalityId, Nationality From CdNationality");
            repositoryItemGridLookUpEditNationalityId.ValueMember = "NationalityId";
            repositoryItemGridLookUpEditNationalityId.DisplayMember = "Nationality";
            LUENationalityId.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditNationalityId.DataSource;
            LUENationalityId.Properties.ValueMember = "NationalityId";
            LUENationalityId.Properties.DisplayMember = "Nationality";

            repositoryItemGridLookUpEditjobID.DataSource = MyCL.LoadDataTable("Select jobID, job From CDjob");
            repositoryItemGridLookUpEditjobID.ValueMember = "jobID";
            repositoryItemGridLookUpEditjobID.DisplayMember = "job";
            LUEjobID.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditjobID.DataSource;
            LUEjobID.Properties.ValueMember = "jobID";
            LUEjobID.Properties.DisplayMember = "job";

            repositoryItemGridLookUpEditMembershipTypeID.DataSource = MyCL.LoadDataTable("Select MembershipTypeID, MembershipType From CDMembershipType");
            repositoryItemGridLookUpEditMembershipTypeID.ValueMember = "MembershipTypeID";
            repositoryItemGridLookUpEditMembershipTypeID.DisplayMember = "MembershipType";
            LUEMembershipTypeID.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditMembershipTypeID.DataSource;
            LUEMembershipTypeID.Properties.ValueMember = "MembershipTypeID";
            LUEMembershipTypeID.Properties.DisplayMember = "MembershipType";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"SELECT TrainerID, TrainerName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob,
            CertificateAddress, MembershipTypeID, MembershipNo, REM, UserName, password FROM TBLTrainers");
            gridControlMain.DataSource = GridTable;
            gridControlMain.RefreshDataSource();
        }
#endregion
        #region -   Event Handlers   -
        private void FrmCdBankAccount_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtTrainerName.Text = string.Empty;
            TxtNameInEnglish.Text = string.Empty;
            LUEGenderID.EditValue = null;
            LUENationalityId.EditValue = null;
            TxtMobile.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtCity.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            LUEjobID.EditValue = null;
            TxtOtherJob.Text = string.Empty;
            TxtCertificateAddress.Text = string.Empty;
            LUEMembershipTypeID.EditValue = null;
            TxtMembershipNo.Text = string.Empty;
            TxtREM.Text = string.Empty;
            TxtUserName.Text = string.Empty;
            Txtpassword.Text = string.Empty;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string TrainerName;
            if (TxtTrainerName.Text == string.Empty)
                TrainerName = "NULL";
            else
                TrainerName = string.Format("N'{0}'", TxtTrainerName.Text);
            string NameInEnglish;
            if (TxtNameInEnglish.Text == string.Empty)
                NameInEnglish = "NULL";
            else
                NameInEnglish = string.Format("N'{0}'", TxtNameInEnglish.Text);
            string Mobile;
            if (TxtMobile.Text == string.Empty)
                Mobile = "NULL";
            else
                Mobile = string.Format("N'{0}'", TxtMobile.Text);
            string Email;
            if (TxtEmail.Text == string.Empty)
                Email = "NULL";
            else
                Email = string.Format("N'{0}'", TxtEmail.Text);
            string Address;
            if (TxtAddress.Text == string.Empty)
                Address = "NULL";
            else
                Address = string.Format("N'{0}'", TxtAddress.Text);
            string OtherJob;
            if (TxtOtherJob.Text == string.Empty)
                OtherJob = "NULL";
            else
                OtherJob = string.Format("N'{0}'", TxtOtherJob.Text);
            string CertificateAddress;
            if (TxtCertificateAddress.Text == string.Empty)
                CertificateAddress = "NULL";
            else
                CertificateAddress = string.Format("N'{0}'", TxtCertificateAddress.Text);
            string MembershipNo;
            if (TxtMembershipNo.Text == string.Empty)
                MembershipNo = "NULL";
            else
                MembershipNo = string.Format("N'{0}'", TxtMembershipNo.Text);
            string REM;
            if (TxtREM.Text == string.Empty)
                REM = "NULL";
            else
                REM = string.Format("N'{0}'", TxtREM.Text);
            string GenderID;
            if (LUEGenderID.EditValue == null)
                GenderID = "NULL";
            else
                GenderID = string.Format("{0}", LUEGenderID.EditValue);
            string NationalityId;
            if (LUENationalityId.EditValue == null)
                NationalityId = "NULL";
            else
                NationalityId = string.Format("{0}", LUENationalityId.EditValue);
            string City;
            if (TxtCity.Text == null)
                City = "NULL";
            else
                City = string.Format("N'{0}'", TxtCity.Text);
            string jobID;
            if (LUEjobID.EditValue == null)
                jobID = "NULL";
            else
                jobID = string.Format("{0}", LUEjobID.EditValue);
            string MembershipTypeID;
            if (LUEMembershipTypeID.EditValue == null)
                MembershipTypeID = "NULL";
            else
                MembershipTypeID = string.Format("{0}", LUEMembershipTypeID.EditValue);
            string UserName;
            if (TxtUserName.Text == string.Empty)
                UserName = "NULL";
            else
                UserName = string.Format("N'{0}'", TxtUserName.Text);
            string password;
            if (Txtpassword.Text == string.Empty)
                password = "NULL";
            else
                password = string.Format("N'{0}'", Txtpassword.Text);
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    string NewID = MyCL.GetNewID("TBLTrainers", "TrainerID");
                    cmd.CommandText = string.Format(@"INSERT INTO TBLTrainers (TrainerID, TrainerName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, 
                    jobID, OtherJob, CertificateAddress, MembershipTypeID, MembershipNo, REM, UserName, password) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16})", 
                    NewID, TrainerName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob, CertificateAddress, MembershipTypeID, MembershipNo, REM, UserName, password);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    BtnClear_Click(BtnClear, new EventArgs());
                    MyCL.ShowMsg("تم الاضافه", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(ex.Message, true, this);
                }
                con.Close();
            }
        }
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEdit)
                LoadData();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            string TrainerName;
            if (Row["TrainerName"].ToString() == string.Empty)
                TrainerName = "NULL";
            else
                TrainerName = string.Format("N'{0}'", Row["TrainerName"]);
            string NameInEnglish;
            if (Row["NameInEnglish"].ToString() == string.Empty)
                NameInEnglish = "NULL";
            else
                NameInEnglish = string.Format("N'{0}'", Row["NameInEnglish"]);
            string Mobile;
            if (Row["Mobile"].ToString() == string.Empty)
                Mobile = "NULL";
            else
                Mobile = string.Format("N'{0}'", Row["Mobile"]);
            string Email;
            if (Row["Email"].ToString() == string.Empty)
                Email = "NULL";
            else
                Email = string.Format("N'{0}'", Row["Email"]);
            string Address;
            if (Row["Address"].ToString() == string.Empty)
                Address = "NULL";
            else
                Address = string.Format("N'{0}'", Row["Address"]);
            string OtherJob;
            if (Row["OtherJob"].ToString() == string.Empty)
                OtherJob = "NULL";
            else
                OtherJob = string.Format("N'{0}'", Row["OtherJob"]);
            string CertificateAddress;
            if (Row["CertificateAddress"].ToString() == string.Empty)
                CertificateAddress = "NULL";
            else
                CertificateAddress = string.Format("N'{0}'", Row["CertificateAddress"]);
            string MembershipNo;
            if (Row["MembershipNo"].ToString() == string.Empty)
                MembershipNo = "NULL";
            else
                MembershipNo = string.Format("N'{0}'", Row["MembershipNo"]);
            string REM;
            if (Row["REM"].ToString() == string.Empty)
                REM = "NULL";
            else
                REM = string.Format("N'{0}'", Row["REM"]);
            string GenderID;
            if (Row["GenderID"].ToString() == string.Empty)
                GenderID = "NULL";
            else
                GenderID = string.Format("N'{0}'", Row["GenderID"]);
            string NationalityId;
            if (Row["NationalityId"].ToString() == string.Empty)
                NationalityId = "NULL";
            else
                NationalityId = string.Format("N'{0}'", Row["NationalityId"]);
            string City;
            if (Row["City"].ToString() == string.Empty)
                City = "NULL";
            else
                City = string.Format("N'{0}'", Row["City"]);
            string jobID;
            if (Row["jobID"].ToString() == string.Empty)
                jobID = "NULL";
            else
                jobID = string.Format("N'{0}'", Row["jobID"]);
            string MembershipTypeID;
            if (Row["MembershipTypeID"].ToString() == string.Empty)
                MembershipTypeID = "NULL";
            else
                MembershipTypeID = string.Format("N'{0}'", Row["MembershipTypeID"]);
            string UserName;
            if (Row["UserName"].ToString() == string.Empty)
                UserName = "NULL";
            else
                UserName = string.Format("N'{0}'", Row["UserName"]);
            string password;
            if (Row["password"].ToString() == string.Empty)
                password = "NULL";
            else
                password = string.Format("N'{0}'", Row["password"]);
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"UPDATE TBLTrainers SET TrainerName = {0}, NameInEnglish = {1}, GenderID = {2}, NationalityId = {3}, Mobile = {4}, 
                    Email = {5}, City = {6}, Address = {7}, jobID = {8}, OtherJob = {9}, CertificateAddress = {10}, MembershipTypeID = {11}, MembershipNo = {12}, REM = {13}
                    ,UserName = {14}, password = {15} WHERE TrainerID = {16}", TrainerName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob, CertificateAddress, MembershipTypeID,
                    MembershipNo, REM, UserName, password, Row["TrainerID"]);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MyCL.ShowMsg("تم التعديل", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
                con.Close();
            }
            LoadData();
            
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["TrainerID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = @"Delete From TBLTrainers Where TrainerID = " + Row["TrainerID"];
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MyCL.ShowMsg("تم الحذف", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
                con.Close();
            }
            LoadData();
        }
        #endregion
    }
}