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
    public partial class TBLTraineeFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");


        #endregion
        #region -   Functions   -
        public TBLTraineeFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            //GenderID
            repositoryItemGridLookUpEditGenderID.DataSource = MyCL.LoadDataTable("Select GenderID, Gender From CdGender");
            repositoryItemGridLookUpEditGenderID.ValueMember = "GenderID";
            repositoryItemGridLookUpEditGenderID.DisplayMember = "Gender";
            LUEGenderID.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditGenderID.DataSource;
            LUEGenderID.Properties.ValueMember = "GenderID";
            LUEGenderID.Properties.DisplayMember = "Gender";
            //NationalityId
            repositoryItemGridLookUpEditNationalityId.DataSource = MyCL.LoadDataTable("Select NationalityId, Nationality From CdNationality");
            repositoryItemGridLookUpEditNationalityId.ValueMember = "NationalityId";
            repositoryItemGridLookUpEditNationalityId.DisplayMember = "Nationality";
            LUENationalityId.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditNationalityId.DataSource;
            LUENationalityId.Properties.ValueMember = "NationalityId";
            LUENationalityId.Properties.DisplayMember = "Nationality";
            //jobID
            repositoryItemGridLookUpEditjobID.DataSource = MyCL.LoadDataTable("Select jobID, job From CDjob");
            repositoryItemGridLookUpEditjobID.ValueMember = "jobID";
            repositoryItemGridLookUpEditjobID.DisplayMember = "job";
            LUEjobID.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditjobID.DataSource;
            LUEjobID.Properties.ValueMember = "jobID";
            LUEjobID.Properties.DisplayMember = "job";
            //MembershipTypeID
            repositoryItemGridLookUpEditMembershipTypeID.DataSource = MyCL.LoadDataTable("Select MembershipTypeID, MembershipType From CDMembershipType");
            repositoryItemGridLookUpEditMembershipTypeID.ValueMember = "MembershipTypeID";
            repositoryItemGridLookUpEditMembershipTypeID.DisplayMember = "MembershipType";
            LUEMembershipTypeID.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditMembershipTypeID.DataSource;
            LUEMembershipTypeID.Properties.ValueMember = "MembershipTypeID";
            LUEMembershipTypeID.Properties.DisplayMember = "MembershipType";
            //TraineeTypeId
            repositoryItemGridLookUpEditTraineeTypeId.DataSource = MyCL.LoadDataTable("Select TraineeTypeId, TraineeType From CDTraineeType");
            repositoryItemGridLookUpEditTraineeTypeId.ValueMember = "TraineeTypeId";
            repositoryItemGridLookUpEditTraineeTypeId.DisplayMember = "TraineeType";
            LUETraineeTypeId.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditTraineeTypeId.DataSource;
            LUETraineeTypeId.Properties.ValueMember = "TraineeTypeId";
            LUETraineeTypeId.Properties.DisplayMember = "TraineeType";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"SELECT TraineeID, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob,
            CertificateAddress, MembershipTypeID, MembershipNo, REM, UserName, password, TraineeTypeId, TimeIn, UserIn FROM TBLTrainee");
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
            TxtTraineeName.Text = string.Empty;
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
            LUETraineeTypeId.EditValue = null;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string TraineeName;
            if (TxtTraineeName.Text == string.Empty)
                TraineeName = "NULL";
            else
                TraineeName = string.Format("N'{0}'", TxtTraineeName.Text);
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
            if (TxtCity.Text == string.Empty)
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
            string TraineeTypeId;
            if (LUETraineeTypeId.EditValue == null)
                TraineeTypeId = "NULL";
            else
                TraineeTypeId = string.Format("{0}", LUETraineeTypeId.EditValue);

            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    string NewID = MyCL.GetNewID("TBLTrainee", "TraineeID");
                    cmd.CommandText = string.Format(@"INSERT INTO TBLTrainee (TraineeID, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, 
                    jobID, OtherJob, CertificateAddress, MembershipTypeID, MembershipNo, REM, TraineeTypeId, TimeIn, UserIn) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, GETDATE(), {16})",
                    NewID, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob, CertificateAddress, MembershipTypeID, MembershipNo, REM, TraineeTypeId, MyCL.UserInfo.UserID);
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
            string TraineeName;
            if (Row["TraineeName"].ToString() == string.Empty)
                TraineeName = "NULL";
            else
                TraineeName = string.Format("N'{0}'", Row["TraineeName"]);
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
            string TraineeTypeId;
            if (Row["TraineeTypeId"].ToString() == string.Empty)
                TraineeTypeId = "NULL";
            else
                TraineeTypeId = Row["TraineeTypeId"].ToString();

            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"UPDATE TBLTrainee SET TraineeName = {0}, NameInEnglish = {1}, GenderID = {2}, NationalityId = {3}, Mobile = {4}, 
                    Email = {5}, City = {6}, Address = {7}, jobID = {8}, OtherJob = {9}, CertificateAddress = {10}, MembershipTypeID = {11}, MembershipNo = {12}, REM = {13}, TraineeTypeId = {14}, 
                    TimeIn = GETDATE(), UserIn = {15}  WHERE TraineeID = {16}", TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob, CertificateAddress, MembershipTypeID,
                    MembershipNo, REM, TraineeTypeId, MyCL.UserInfo.UserID, Row["TraineeID"]);
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
            if (Row["TraineeID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = @"Delete From TBLTrainee Where TraineeID = " + Row["TraineeID"];
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