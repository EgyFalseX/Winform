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
    public partial class TBLCourseCertificatesFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");


        #endregion
        #region -   Functions   -
        public TBLCourseCertificatesFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            repositoryItemGridLookUpEditCourseId.DataSource = MyCL.LoadDataTable("Select CourseId, CourseName, Convert(nvarchar, StartDate, 103) AS StartDate, Convert(nvarchar, EndDate, 103) AS EndDate From TBLCourses");
            repositoryItemGridLookUpEditCourseId.ValueMember = "CourseId";
            repositoryItemGridLookUpEditCourseId.DisplayMember = "CourseName";

            repositoryItemGridLookUpEditCertificateID.DataSource = MyCL.LoadDataTable("Select CertificateID, Certificate, (Select Partner From TBLPartners Where PartnerID = CertificateFrom) AS CertificateFrom, CertificateValue From CDCertificates");
            repositoryItemGridLookUpEditCertificateID.ValueMember = "CertificateID";
            repositoryItemGridLookUpEditCertificateID.DisplayMember = "Certificate";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable("Select CourseId, CertificateID, CourseId AS CourseId_Org, CertificateID AS CertificateID_Org From TBLCourseCertificates");
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
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["CourseId"].ToString() == string.Empty || Row["CertificateID"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("الحقول فارغه", true, this);
                LoadData();
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["CourseId_Org"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"Insert Into TBLCourseCertificates (CourseId, CertificateID) VALUES ({0}, {1})", Row["CourseId"], Row["CertificateID"]);
                    else
                        cmd.CommandText = string.Format(@"Update TBLCourseCertificates Set CourseId = {0}, CertificateID = {1} Where CourseId = {2} And CertificateID = {3}", Row["CourseId"], Row["CertificateID"], Row["CourseId_Org"], Row["CertificateID_Org"]);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MyCL.ShowMsg("تم الحفظ", false, this);
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
            if (Row["CourseId_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"Delete From TBLCourseCertificates Where CourseId = {0} And CertificateID = {1}", Row["CourseId_Org"], Row["CertificateID_Org"]);
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
            }
            con.Close();
            LoadData();
        }
        #endregion
    }
}