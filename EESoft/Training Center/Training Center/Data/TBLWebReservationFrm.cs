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
    public partial class TBLWebReservationFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TBLWebReservationFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            repositoryItemGridLookUpEditCourseId.DataSource = MyCL.LoadDataTable("Select CourseId, CourseName, Convert(nvarchar, StartDate, 103) AS StartDate, Convert(nvarchar, EndDate, 103) AS EndDate From TBLCourses");
            repositoryItemGridLookUpEditCourseId.ValueMember = "CourseId";
            repositoryItemGridLookUpEditCourseId.DisplayMember = "CourseName";

            repositoryItemGridLookUpEditTraineeID.DataSource = MyCL.LoadDataTable("Select TraineeID, TraineeName From TBLTrainee");
            repositoryItemGridLookUpEditTraineeID.ValueMember = "TraineeID";
            repositoryItemGridLookUpEditTraineeID.DisplayMember = "TraineeName";
        }
        public void LoadData()
        {
            //Convert(nvarchar, ReservationDate, 103) AS ReservationDate
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select TraineeID, TraineeID AS TraineeID_Org, CourseId, CourseId AS CourseId_Org, 
            ReservationDate From TBLWebReservation");
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
            if (Row["TraineeID"].ToString() == string.Empty || Row["CourseId"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("الحقول فارغه", true, this);
                LoadData();
                return;
            }
            string ReservationDate;
            if (Row["ReservationDate"].ToString() == string.Empty)
                ReservationDate = "NULL";
            else
                ReservationDate = String.Format("Convert(Datetime, '{0}', 103)", MyCL.ConvertToDateDMY(Row["ReservationDate"].ToString()));
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["TraineeID_Org"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"Insert Into TBLWebReservation (TraineeID, CourseId, ReservationDate) VALUES ({0}, {1}, {2})", Row["TraineeID"], Row["CourseId"], ReservationDate);
                    else
                        cmd.CommandText = string.Format(@"Update TBLWebReservation Set TraineeID = {0}, CourseId = {1}, ReservationDate = {2} Where TraineeID = {3} And CourseId = {4}",
                        Row["TraineeID"], Row["CourseId"], ReservationDate, Row["TraineeID_Org"], Row["CourseId_Org"]);
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
                cmd.CommandText = string.Format(@"Delete From TBLWebReservation Where CourseId = {0} And TraineeID = {1}", Row["CourseId_Org"], Row["TraineeID_Org"]);
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