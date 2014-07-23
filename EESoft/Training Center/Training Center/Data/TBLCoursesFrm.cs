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
    public partial class TBLCoursesFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        DataTable CoursesTable = new DataTable("FalseX2011-07");

        DataTable TBLCourseCertificates = new DataTable("FalseX2011-08");
        DataTable TBLCourseAgenda = new DataTable("FalseX2011-08");
        DataTable TBLCourseTrainers = new DataTable("FalseX2011-08");
        DataTable TBLReservation = new DataTable("FalseX2011-08");
        DataTable TBLAttend = new DataTable("FalseX2011-08");
        #endregion
        #region -   Functions   -
        public TBLCoursesFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            //CourseType
            repositoryItemGridLookUpEditCourseTypeID.DataSource = MyCL.LoadDataTable("Select CourseTypeID, CourseTypeName From CDCourseType");
            repositoryItemGridLookUpEditCourseTypeID.ValueMember = "CourseTypeID";
            repositoryItemGridLookUpEditCourseTypeID.DisplayMember = "CourseTypeName";
            //Lab
            repositoryItemGridLookUpEditLabId.DataSource = MyCL.LoadDataTable("Select LabId, LabName, LabDes From CdLab");
            repositoryItemGridLookUpEditLabId.ValueMember = "LabId";
            repositoryItemGridLookUpEditLabId.DisplayMember = "LabName";
            //CoursePlace
            repositoryItemGridLookUpEditCoursePlace.DataSource = MyCL.LoadDataTable("Select PlaceID, PlaceName From CdPlace");
            repositoryItemGridLookUpEditCoursePlace.ValueMember = "PlaceID";
            repositoryItemGridLookUpEditCoursePlace.DisplayMember = "PlaceName";
            //Certificate
            repositoryItemGridLookUpEditCertificateID.DataSource = MyCL.LoadDataTable("Select CertificateID, Certificate, (Select Partner From TBLPartners Where PartnerID = CertificateFrom) AS CertificateFrom, CertificateValue From CDCertificates");
            repositoryItemGridLookUpEditCertificateID.ValueMember = "CertificateID";
            repositoryItemGridLookUpEditCertificateID.DisplayMember = "Certificate";
            //Trainer
            repositoryItemGridLookUpEditTrainerID.DataSource = MyCL.LoadDataTable("Select TrainerID, TrainerName From TBLTrainers");
            repositoryItemGridLookUpEditTrainerID.ValueMember = "TrainerID";
            repositoryItemGridLookUpEditTrainerID.DisplayMember = "TrainerName";
            //TBLTrainee
            repositoryItemGridLookUpEditTraineeID.DataSource = MyCL.LoadDataTable("Select TraineeID, TraineeName From TBLTrainee");
            repositoryItemGridLookUpEditTraineeID.ValueMember = "TraineeID";
            repositoryItemGridLookUpEditTraineeID.DisplayMember = "TraineeName";
            //CDReservationWay
            repositoryItemGridLookUpEditReservationWayID.DataSource = MyCL.LoadDataTable("Select ReservationWayID, ReservationWay From CDReservationWay");
            repositoryItemGridLookUpEditReservationWayID.ValueMember = "ReservationWayID";
            repositoryItemGridLookUpEditReservationWayID.DisplayMember = "ReservationWay";
            //CdBankAccount
            repositoryItemGridLookUpEditAccountID.DataSource = MyCL.LoadDataTable("Select AccountID, AccountName From CdBankAccount");
            repositoryItemGridLookUpEditAccountID.ValueMember = "AccountID";
            repositoryItemGridLookUpEditAccountID.DisplayMember = "AccountName";
            //TBLTrainee
            repositoryItemGridLookUpEditAttendTraineeID.DataSource = MyCL.LoadDataTable("Select TraineeID, TraineeName From TBLTrainee");
            repositoryItemGridLookUpEditAttendTraineeID.ValueMember = "TraineeID";
            repositoryItemGridLookUpEditAttendTraineeID.DisplayMember = "TraineeName";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select CourseId, CourseTypeID, CourseName, CoursePlace, 
            StartDate, EndDate, Price, WithExam, ExamMax, ExamMin, ApologyAllow, LabId, ShowOnline From TBLCourses");
            gridControlMain.DataSource = GridTable;
            gridControlMain.RefreshDataSource();
        }
        private void LoadAllCourses()
        {
            CoursesTable = new DataTable("FalseX2011-07");
            CoursesTable = MyCL.LoadDataTable(@"Select CourseId, CourseTypeID, CourseName, CoursePlace, 
            Convert(nvarchar, StartDate, 103) AS StartDate, Convert(nvarchar, EndDate, 103) AS EndDate, 
            Price, WithExam, ExamMax, ExamMin, ApologyAllow, LabId, ShowOnline From TBLCourses");
            LUECourses.Properties.DataSource = CoursesTable;
            LUECourses.Properties.ValueMember = "CourseId";
            LUECourses.Properties.DisplayMember = "CourseName";
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
            string CourseTypeID;
            if (Row["CourseTypeID"].ToString() == string.Empty)
                CourseTypeID = "NULL";
            else
                CourseTypeID = String.Format("{0}", Row["CourseTypeID"]);

            string CoursePlace;
            if (Row["CoursePlace"].ToString() == string.Empty)
                CoursePlace = "NULL";
            else
                CoursePlace = String.Format("{0}", Row["CoursePlace"]);

            string LabId;
            if (Row["LabId"].ToString() == string.Empty)
                LabId = "NULL";
            else
                LabId = String.Format("{0}", Row["LabId"]);

            string CourseName;
            if (Row["CourseName"].ToString() == string.Empty)
                CourseName = "NULL";
            else
                CourseName = String.Format("N'{0}'", Row["CourseName"]);
            string StartDate;
            if (Row["StartDate"].ToString() == string.Empty)
                StartDate = "NULL";
            else
                StartDate = String.Format("CONVERT(DATETIME, '{0}', 103)", MyCL.ConvertToDateDMY(Row["StartDate"].ToString()));
            string EndDate;
            if (Row["EndDate"].ToString() == string.Empty)
                EndDate = "NULL";
            else
                EndDate = String.Format("CONVERT(DATETIME, '{0}', 103)", MyCL.ConvertToDateDMY(Row["EndDate"].ToString()));
            string Price;
            if (Row["Price"].ToString() == string.Empty)
                Price = "0";
            else
                Price = String.Format("{0}", Row["Price"]);
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                if (Row["CourseId"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    string NewID = MyCL.GetNewID("TBLCourses", "CourseId");
                    cmd.CommandText = string.Format(@"INSERT INTO TBLCourses (CourseId, CourseTypeID, CourseName, CoursePlace, StartDate, EndDate, Price, WithExam, ApologyAllow, LabId, ShowOnline)
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, '{7}', '{8}', {9}, '{10}')",
                    NewID, CourseTypeID, CourseName, CoursePlace, StartDate, EndDate, Price, Row["WithExam"], Row["ApologyAllow"], LabId, Row["ShowOnline"]);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE TBLCourses SET CourseTypeID = {0}, CourseName = {1}, CoursePlace = {2}, 
                    StartDate = {3},  EndDate = {4}, Price = {5}, WithExam = '{6}', 
                    ApologyAllow = '{7}', LabId = {8}, ShowOnline = '{9}' Where CourseId = {10}", CourseTypeID, CourseName, CoursePlace, StartDate, EndDate,
                      Price, Row["WithExam"], Row["ApologyAllow"], LabId, Row["ShowOnline"], Row["CourseId"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ", false, this);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
            }
            con.Close();
            LoadData();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["CourseId"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From TBLCourses Where CourseId = " + Row["CourseId"];
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
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageDetails)
                LoadAllCourses();
        }
        private void LUECourses_EditValueChanged(object sender, EventArgs e)
        {
            if (LUECourses.EditValue == null)
            {
                TBLCourseCertificates = new DataTable();
                TBLCourseAgenda = new DataTable();
                TBLCourseTrainers = new DataTable();
                TBLReservation = new DataTable();
                TBLAttend = new DataTable();
            }
            //Certificates
            TBLCourseCertificates = MyCL.LoadDataTable(@"Select CourseId, CertificateID, CertificateID as CertificateID_Org, 
            (Select Certificate From CDCertificates Where CertificateID = TBLCourseCertificates.CertificateID) AS Certificate From TBLCourseCertificates Where 
            CourseId = " + LUECourses.EditValue);
            gridControlCertificates.DataSource = TBLCourseCertificates;
            //Agenda
            TBLCourseAgenda = MyCL.LoadDataTable(@"Select CourseId, ADate, Convert(nvarchar, TimeFrom, 108) AS TimeFrom,
            Convert(nvarchar, TimeTo, 108) AS TimeTo, subject, Convert(nvarchar, ADate, 103) AS ADate_Org From TBLCourseAgenda Where CourseId = " + LUECourses.EditValue);
            gridControlAgenda.DataSource = TBLCourseAgenda;
            //Trainers
            TBLCourseTrainers = MyCL.LoadDataTable(@"Select CourseId, TrainerID, TrainerID AS TrainerID_Org From TBLCourseTrainers Where CourseId = " + LUECourses.EditValue);
            gridControlTrainers.DataSource = TBLCourseTrainers;
            //Reservation
            TBLReservation = MyCL.LoadDataTable(@"Select ReservationID, TraineeID, CourseId, ReservationWayID, TransferDate, 
            TransferValue, AccountID, esalno From TBLReservation Where CourseId = " + LUECourses.EditValue);
            gridControlReservation.DataSource = TBLReservation;
            //Attend
            TBLAttend = MyCL.LoadDataTable(@"Select CourseId, TraineeID, TraineeID AS TraineeID_Org, ADate, Convert(nvarchar, ADate, 103) AS ADate_Org From TBLAttend Where CourseId = " + LUECourses.EditValue);
            gridControlAttend.DataSource = TBLAttend;
        }
        private void repositoryItemButtonEditCertificatesOK_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewCertificates.GetFocusedDataRow();
            if (Row["CertificateID"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("الحقول فارغه", true, this);
                LUECourses_EditValueChanged(LUECourses, new EventArgs());
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["CertificateID_Org"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"Insert Into TBLCourseCertificates (CourseId, CertificateID) VALUES ({0}, {1})", LUECourses.EditValue, Row["CertificateID"]);
                    else
                        cmd.CommandText = string.Format(@"Update TBLCourseCertificates Set  CertificateID = {0} Where CourseId = {1} And CertificateID = {2}", Row["CertificateID"], LUECourses.EditValue, Row["CertificateID_Org"]);
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
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditCertificatesDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewCertificates.GetFocusedDataRow();
            if (Row["CertificateID_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LUECourses_EditValueChanged(LUECourses, new EventArgs());
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"Delete From TBLCourseCertificates Where CourseId = {0} And CertificateID = {1}", Row["CourseId"], Row["CertificateID_Org"]);
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
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditOKAgenda_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow Row = (DataRow)gridViewAgenda.GetFocusedDataRow();
            if (Row["ADate"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("من فضلك اكمل البيانات", true, this);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            string TimeFrom;
            if (Row["TimeFrom"].ToString() == string.Empty)
                TimeFrom = "NULL";
            else
                TimeFrom = string.Format("CONVERT(DATETIME, '{0}', 108)", MyCL.ConvertToDateHMS(Row["TimeFrom"].ToString()));
            string TimeTo;
            if (Row["TimeTo"].ToString() == string.Empty)
                TimeTo = "NULL";
            else
                TimeTo = string.Format("CONVERT(DATETIME, '{0}', 108)", MyCL.ConvertToDateHMS(Row["TimeTo"].ToString()));
            string subject;
            if (Row["subject"].ToString() == string.Empty)
                subject = "NULL";
            else
                subject = string.Format("N'{0}'", Row["subject"]);
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                if (Row["ADate_Org"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    cmd.CommandText = string.Format(@"INSERT INTO TBLCourseAgenda (CourseId, ADate, TimeFrom, TimeTo, subject)
                    VALUES ({0}, CONVERT(DATETIME, '{1}', 103), {2}, {3}, {4})", LUECourses.EditValue, MyCL.ConvertToDateDMY(Row["ADate"].ToString()), TimeFrom, TimeTo, subject);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE TBLCourseAgenda SET ADate = CONVERT(DATETIME, '{0}', 103), 
                 TimeFrom = {1},  TimeTo ={2}, subject = {3} Where CourseId = {4} And ADate = CONVERT(DATETIME, '{5}', 103)", MyCL.ConvertToDateDMY(Row["ADate"].ToString()), TimeFrom, TimeTo,
                    subject, LUECourses.EditValue, Row["ADate_Org"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ", false, this);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
            }
            con.Close();
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditDeleteAgenda_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewAgenda.GetFocusedDataRow();
            if (Row["ADate_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LUECourses_EditValueChanged(LUECourses, new EventArgs());
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"Delete From TBLCourseAgenda Where CourseId = {0} And ADate = CONVERT(DATETIME, '{1}', 103)", LUECourses.EditValue, Row["ADate_org"]);
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
            }
            con.Close();
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditOkTrainers_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewTrainers.GetFocusedDataRow();
            if (Row["TrainerID"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("الحقول فارغه", true, this);
                LUECourses_EditValueChanged(LUECourses, new EventArgs());
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["TrainerID_Org"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"Insert Into TBLCourseTrainers (CourseId, TrainerID) VALUES ({0}, {1})", LUECourses.EditValue, Row["TrainerID"]);
                    else
                        cmd.CommandText = string.Format(@"Update TBLCourseTrainers Set  TrainerID = {0} Where CourseId = {1} And TrainerID = {2}", Row["TrainerID"], LUECourses.EditValue, Row["TrainerID_Org"]);
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
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditDeleteTrainers_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewTrainers.GetFocusedDataRow();
            if (Row["TrainerID_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LUECourses_EditValueChanged(LUECourses, new EventArgs());
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"Delete From TBLCourseTrainers Where CourseId = {0} And TrainerID = {1}", Row["CourseId"], Row["TrainerID_Org"]);
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
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditOKReservation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewReservation.GetFocusedDataRow();
            string TraineeID;
            if (Row["TraineeID"].ToString() == string.Empty)
                TraineeID = "NULL";
            else
                TraineeID = Row["TraineeID"].ToString();

            string ReservationWayID;
            if (Row["ReservationWayID"].ToString() == string.Empty)
                ReservationWayID = "NULL";
            else
                ReservationWayID = Row["ReservationWayID"].ToString();

            string TransferDate;
            if (Row["TransferDate"].ToString() == string.Empty)
                TransferDate = "NULL";
            else
                TransferDate = string.Format(@"Convert(Datetime, '{0}', 103)", MyCL.ConvertToDateDMY(Row["TransferDate"].ToString()));

            string AccountID;
            if (Row["AccountID"].ToString() == string.Empty)
                AccountID = "NULL";
            else
                AccountID = Row["AccountID"].ToString();

            string esalno;
            if (Row["esalno"].ToString() == string.Empty)
                esalno = "NULL";
            else
                esalno = string.Format(@"N'{0}'", Row["esalno"]);

            string TransferValue;
            if (Row["TransferValue"].ToString() == string.Empty)
                TransferValue = "0";
            else
                TransferValue = Row["TransferValue"].ToString();
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["ReservationID"].ToString() == string.Empty)// Is Unsaved Row?
                        //string NewID = MyCL.GetNewID("TBLReservation", "ReservationID");
                        cmd.CommandText = string.Format(@"INSERT INTO TBLReservation (TraineeID, CourseId, ReservationWayID, TransferDate, TransferValue, AccountID, esalno)
                        VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})", TraineeID, LUECourses.EditValue, ReservationWayID, TransferDate, TransferValue, AccountID, esalno);
                    else
                        cmd.CommandText = string.Format(@"UPDATE TBLReservation SET TraineeID = {0}, ReservationWayID = {1}, TransferDate = {2}, TransferValue = {3}, AccountID = {4}, 
                                esalno = {5} Where ReservationID = {6}", TraineeID, ReservationWayID, TransferDate, TransferValue, AccountID, esalno, Row["ReservationID"]);
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
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditDeleteReservation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewReservation.GetFocusedDataRow();
            if (Row["ReservationID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LUECourses_EditValueChanged(LUECourses, new EventArgs());
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = @"Delete From TBLReservation Where ReservationID = " + Row["ReservationID"];
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
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void BtnAttendAll_Click(object sender, EventArgs e)
        {
            if (LUECourses.EditValue == null || DEAttendDate.EditValue == null)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                SqlTransaction trn;
                try
                {
                    DataTable dt = MyCL.LoadDataTable(@"Select TraineeID From TBLReservation Where CourseId = " + LUECourses.EditValue);
                    con.Open();
                    trn = con.BeginTransaction();
                    cmd.Transaction = trn;
                    foreach (DataRow row in dt.Rows)
                    {
                        cmd.CommandText = string.Format(@"Insert Into TBLAttend (TraineeID, CourseId, ADate) VALUES ({0}, {1}, Convert(datetime, '{2}', 103))", row["TraineeID"], LUECourses.EditValue, DEAttendDate.Text);
                        cmd.ExecuteNonQuery();
                    }
                    trn.Commit();
                    MyCL.ShowMsg("تم الاضافه", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
                con.Close();
            }
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditOkAttend_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewAttend.GetFocusedDataRow();
            if (Row["TraineeID"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("الحقول فارغه", true, this);
                LUECourses_EditValueChanged(LUECourses, new EventArgs());
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["TraineeID_Org"].ToString() == string.Empty)// Is Unsaved Row?
                        cmd.CommandText = string.Format(@"Insert Into TBLAttend (CourseId, TraineeID, ADate) VALUES ({0}, {1}, Convert(Datetime, '{2}', 103))", 
                        LUECourses.EditValue, Row["TraineeID"], MyCL.ConvertToDateDMY(Row["ADate"].ToString()));
                    else
                        cmd.CommandText = string.Format(@"Update TBLAttend Set  TraineeID = {0}, ADate = Convert(Datetime, '{1}', 103) Where CourseId = {2} And TraineeID = {3} And ADate = Convert(Datetime, '{4}', 103)", Row["TraineeID"],
                        MyCL.ConvertToDateDMY(Row["ADate"].ToString()), LUECourses.EditValue, Row["TraineeID_Org"], Row["ADate_Org"]);
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
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        private void repositoryItemButtonEditDeleteAttend_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewAttend.GetFocusedDataRow();
            if (Row["TraineeID_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LUECourses_EditValueChanged(LUECourses, new EventArgs());
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"Delete From TBLAttend Where CourseId = {0} And TraineeID = {1} And ADate = Convert(Datetime, '{2}', 103)", 
                    Row["CourseId"], Row["TraineeID_Org"], Row["ADate_Org"]);
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
            LUECourses_EditValueChanged(LUECourses, new EventArgs());
        }
        #endregion
    }
}