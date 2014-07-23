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
    public partial class TBLTraineeCertificatesFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TBLTraineeCertificatesFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            //TBLTrainee
            repositoryItemGridLookUpEditTraineeID.DataSource = MyCL.LoadDataTable("Select TraineeID, TraineeName From TBLTrainee");
            repositoryItemGridLookUpEditTraineeID.ValueMember = "TraineeID";
            repositoryItemGridLookUpEditTraineeID.DisplayMember = "TraineeName";
            //TBLCourses
            repositoryItemGridLookUpEditCourseId.DataSource = MyCL.LoadDataTable("Select CourseId, CourseName From TBLCourses");
            repositoryItemGridLookUpEditCourseId.ValueMember = "CourseId";
            repositoryItemGridLookUpEditCourseId.DisplayMember = "CourseName";
            //CDReservationWay
            repositoryItemGridLookUpEditCertificateID.DataSource = MyCL.LoadDataTable("Select CertificateID, Certificate From CDCertificates");
            repositoryItemGridLookUpEditCertificateID.ValueMember = "CertificateID";
            repositoryItemGridLookUpEditCertificateID.DisplayMember = "Certificate";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select TraineeID, CourseId, CertificateID, ReceiptDate, 
            CertificateValue, UniqueNo, ID, TraineeID AS TraineeID_Org, CourseId AS CourseId_Org, CertificateID AS CertificateID_Org From TBLTraineeCertificates");
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
            if (Row["TraineeID"].ToString() == string.Empty || Row["CourseId"].ToString() == string.Empty || Row["CertificateID"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("البيانات غير مكتمله", true, this);
                return;
            }
            string TraineeID;
            if (Row["TraineeID"].ToString() == string.Empty)
                TraineeID = "NULL";
            else
                TraineeID = Row["TraineeID"].ToString();

            string CourseId;
            if (Row["CourseId"].ToString() == string.Empty)
                CourseId = "NULL";
            else
                CourseId = Row["CourseId"].ToString();

            string CertificateID;
            if (Row["CertificateID"].ToString() == string.Empty)
                CertificateID = "NULL";
            else
                CertificateID = Row["CertificateID"].ToString();

            string ReceiptDate;
            if (Row["ReceiptDate"].ToString() == string.Empty)
                ReceiptDate = "NULL";
            else
                ReceiptDate = string.Format(@"Convert(Datetime, '{0}', 103)", MyCL.ConvertToDateDMY(Row["ReceiptDate"].ToString()));

            string CertificateValue;
            if (Row["CertificateValue"].ToString() == string.Empty)
                CertificateValue = "0";
            else
                CertificateValue = Row["CertificateValue"].ToString();
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    string NewNo = string.Empty;
                    DataTable dt = MyCL.LoadDataTable(String.Format("SELECT TOP (1) UniqueNo FROM TBLTraineeCertificates ORDER BY ID DESC", TraineeID));
                    if (dt.Rows.Count == 0)
                        NewNo = "1";
                    else
                    {
                        string[] SubStr = dt.Rows[0]["UniqueNo"].ToString().Split(Convert.ToChar("-"));
                        NewNo = (Convert.ToInt16(SubStr[SubStr.Length - 1]) + 1).ToString();
                    }
                    string UniqueNo = String.Format("{0}-{1}", MyCL.LoadDataTable(String.Format("Select Isnull(MembershipNo, '') From TBLTrainers Where TrainerID = (Select TrainerID From TBLCourseTrainers Where CourseId = {0})", CourseId)).Rows[0][0], NewNo);
                    if (Row["TraineeID_Org"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"INSERT INTO TBLTraineeCertificates (TraineeID, CourseId, CertificateID, ReceiptDate, CertificateValue, UniqueNo)
                        VALUES ({0}, {1}, {2}, {3}, {4}, N'{5}')", TraineeID, CourseId, CertificateID, ReceiptDate, CertificateValue, UniqueNo);
                    else
                        cmd.CommandText = string.Format(@"UPDATE TBLTraineeCertificates SET TraineeID = {0}, CourseId = {1}, CertificateID = {2}, ReceiptDate = {3}, CertificateValue = {4} 
                        Where TraineeID = {5} And CourseId = {6} And CertificateID = {7}", TraineeID, CourseId, CertificateID, ReceiptDate, CertificateValue, Row["TraineeID_Org"], Row["CourseId_Org"], Row["CertificateID_Org"]);
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
            if (Row["TraineeID_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"Delete From TBLTraineeCertificates Where TraineeID = {0} And CourseId = {1} And CertificateID = {2}",
                Row["TraineeID"], Row["CourseId"], Row["CertificateID"]);
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