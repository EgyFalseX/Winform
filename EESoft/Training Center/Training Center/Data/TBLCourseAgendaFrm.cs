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
    public partial class TBLCourseAgendaFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");


        #endregion
        #region -   Functions   -
        public TBLCourseAgendaFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            repositoryItemGridLookUpEditCourseId.DataSource = MyCL.LoadDataTable("Select CourseId, CourseName From TBLCourses");
            repositoryItemGridLookUpEditCourseId.ValueMember = "CourseId";
            repositoryItemGridLookUpEditCourseId.DisplayMember = "CourseName";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select CourseId, ADate, Convert(nvarchar, TimeFrom, 108) AS TimeFrom, Convert(nvarchar, TimeTo, 108) AS TimeTo, 
            CourseId AS CourseId_Org, Convert(nvarchar, ADate, 103) AS ADate_Org, subject From TBLCourseAgenda");
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
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["CourseId"].ToString() == string.Empty || Row["ADate"].ToString() == string.Empty)
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
                if (Row["CourseId_Org"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    cmd.CommandText = string.Format(@"INSERT INTO TBLCourseAgenda (CourseId, ADate, TimeFrom, TimeTo, subject)
                    VALUES ({0}, CONVERT(DATETIME, '{1}', 103), {2}, {3}, {4})", Row["CourseId"], MyCL.ConvertToDateDMY(Row["ADate"].ToString()), 
                    TimeFrom, TimeTo, subject);
                }
                else
                {
                 cmd.CommandText = string.Format(@"UPDATE TBLCourseAgenda SET CourseId = {0}, ADate = CONVERT(DATETIME, '{1}', 103), 
                 TimeFrom = {2},  TimeTo ={3}, subject = {4} Where CourseId = {5} And ADate = CONVERT(DATETIME, '{6}', 103)",
                 Row["CourseId"], MyCL.ConvertToDateDMY(Row["ADate"].ToString()), TimeFrom, TimeTo, subject, Row["CourseId_Org"], Row["ADate_Org"]);
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
                cmd.CommandText = string.Format(@"Delete From TBLCourseAgenda Where CourseId = {0} And ADate = CONVERT(DATETIME, '{1}', 103)", Row["CourseId_org"], Row["ADate_org"]);
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