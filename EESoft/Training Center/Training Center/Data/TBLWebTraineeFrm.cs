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
    public partial class TBLWebTraineeFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TBLWebTraineeFrm()
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

            repositoryItemGridLookUpEditknowID.DataSource = MyCL.LoadDataTable("Select knowID, know From CDknow");
            repositoryItemGridLookUpEditknowID.ValueMember = "knowID";
            repositoryItemGridLookUpEditknowID.DisplayMember = "know";
            LUEknowID.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditknowID.DataSource;
            LUEknowID.Properties.ValueMember = "knowID";
            LUEknowID.Properties.DisplayMember = "know";

            repositoryItemGridLookUpEditjobID.DataSource = MyCL.LoadDataTable("Select jobID, job From CDjob");
            repositoryItemGridLookUpEditjobID.ValueMember = "jobID";
            repositoryItemGridLookUpEditjobID.DisplayMember = "job";
            LUEjobID.Properties.DataSource = (DataTable)repositoryItemGridLookUpEditjobID.DataSource;
            LUEjobID.Properties.ValueMember = "jobID";
            LUEjobID.Properties.DisplayMember = "job";

        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"SELECT TraineeID, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, mail, City, Address, jobID, OtherJob, Certificate,
            CertificateAddress, knowID, OtherKnowWay, REM FROM TBLWebTrainee");
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
            LUEknowID.EditValue = null;
            TxtAddress.Text = string.Empty;
            LUEjobID.EditValue = null;
            TxtOtherJob.Text = string.Empty;
            TxtCertificateAddress.Text = string.Empty;
            LUEknowID.EditValue = null;
            TxtOtherKnowWay.Text = string.Empty;
            CECertificate.Checked = false;
            TxtCity.Text = string.Empty;
            TxtREM.Text = string.Empty;
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
            string mail;
            if (TxtEmail.Text == string.Empty)
                mail = "NULL";
            else
                mail = string.Format("N'{0}'", TxtEmail.Text);
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
            string OtherKnowWay;
            if (TxtOtherKnowWay.Text == string.Empty)
                OtherKnowWay = "NULL";
            else
                OtherKnowWay = string.Format("N'{0}'", TxtOtherKnowWay.Text);
            string REM;
            if (TxtREM.Text == string.Empty)
                REM = "NULL";
            else
                REM = string.Format("N'{0}'", TxtREM.Text);
            string City;
            if (TxtCity.Text == string.Empty)
                City = "NULL";
            else
                City = string.Format("N'{0}'", TxtCity.Text);
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
            string knowID;
            if (LUEknowID.EditValue == null)
                knowID = "NULL";
            else
                knowID = string.Format("{0}", LUEknowID.EditValue);
            string jobID;
            if (LUEjobID.EditValue == null)
                jobID = "NULL";
            else
                jobID = string.Format("{0}", LUEjobID.EditValue);

            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    //string NewID = MyCL.GetNewID("TBLWebTrainee", "TraineeID");
                    cmd.CommandText = string.Format(@"INSERT INTO TBLWebTrainee (TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, mail, knowID, Address, 
                            jobID, OtherJob, CertificateAddress, OtherKnowWay, REM, City, Certificate) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, '{14}')",
                            TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, mail, knowID, Address, jobID, OtherJob, CertificateAddress, OtherKnowWay, REM, City, CECertificate.Checked);
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
            string mail;
            if (Row["mail"].ToString() == string.Empty)
                mail = "NULL";
            else
                mail = string.Format("N'{0}'", Row["mail"]);
            string City;
            if (Row["City"].ToString() == string.Empty)
                City = "NULL";
            else
                City = string.Format("N'{0}'", Row["City"]);
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
            string OtherKnowWay;
            if (Row["OtherKnowWay"].ToString() == string.Empty)
                OtherKnowWay = "NULL";
            else
                OtherKnowWay = string.Format("N'{0}'", Row["OtherKnowWay"]);
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
            string knowID;
            if (Row["knowID"].ToString() == string.Empty)
                knowID = "NULL";
            else
                knowID = string.Format("N'{0}'", Row["knowID"]);
            string jobID;
            if (Row["jobID"].ToString() == string.Empty)
                jobID = "NULL";
            else
                jobID = string.Format("N'{0}'", Row["jobID"]);
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"UPDATE TBLWebTrainee SET TraineeName = {0}, NameInEnglish = {1}, GenderID = {2}, NationalityId = {3}, Mobile = {4}, 
                    mail = {5}, knowID = {6}, Address = {7}, jobID = {8}, OtherJob = {9}, CertificateAddress = {10}, OtherKnowWay = {11}, Certificate = '{12}', REM = {13}, City = {14}
                    WHERE TraineeID = {15}", TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, mail, knowID, Address, jobID, OtherJob, CertificateAddress, OtherKnowWay,
                    Row["Certificate"], REM, City, Row["TraineeID"]);
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
                    cmd.CommandText = @"Delete From TBLWebTrainee Where TraineeID = " + Row["TraineeID"];
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