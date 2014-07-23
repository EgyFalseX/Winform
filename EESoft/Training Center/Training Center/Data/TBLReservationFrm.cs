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
    public partial class TBLReservationFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TBLReservationFrm()
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
            repositoryItemGridLookUpEditReservationWayID.DataSource = MyCL.LoadDataTable("Select ReservationWayID, ReservationWay From CDReservationWay");
            repositoryItemGridLookUpEditReservationWayID.ValueMember = "ReservationWayID";
            repositoryItemGridLookUpEditReservationWayID.DisplayMember = "ReservationWay";
            //CdBankAccount
            repositoryItemGridLookUpEditAccountID.DataSource = MyCL.LoadDataTable("Select AccountID, AccountName From CdBankAccount");
            repositoryItemGridLookUpEditAccountID.ValueMember = "AccountID";
            repositoryItemGridLookUpEditAccountID.DisplayMember = "AccountName";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select ReservationID, TraineeID, CourseId, ReservationWayID, TransferDate, 
            TransferValue, AccountID, esalno From TBLReservation");
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
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                if (Row["ReservationID"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    //string NewID = MyCL.GetNewID("TBLReservation", "ReservationID");
                    cmd.CommandText = string.Format(@"INSERT INTO TBLReservation (TraineeID, CourseId, ReservationWayID, TransferDate, TransferValue, AccountID, esalno)
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})", TraineeID, CourseId, ReservationWayID, TransferDate, TransferValue, AccountID, esalno);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE TBLReservation SET TraineeID = {0}, CourseId = {1}, ReservationWayID = {2}, TransferDate = {3}, TransferValue = {4}, AccountID = {5}, 
                    esalno = {6} Where ReservationID = {7}", TraineeID, CourseId, ReservationWayID, TransferDate, TransferValue, AccountID, esalno, Row["ReservationID"]);
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
            if (Row["ReservationID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
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
            LoadData();
        }
        #endregion
    }
}