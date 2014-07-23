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
    public partial class TBLTrainersCoursesOutFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        DataTable CoursesTable = new DataTable("FalseX2011-07");

        DataTable TBLTrainersTraineeOUT = new DataTable("FalseX2011-08");
        DataTable TBLOrderCertificates = new DataTable("FalseX2011-08");
        DataTable TBLWebTraineeOut = new DataTable("FalseX2011-08");

        #endregion
        #region -   Functions   -
        public TBLTrainersCoursesOutFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            //CourseType
            repositoryItemGridLookUpEditMainTrainerID.DataSource = MyCL.LoadDataTable("Select TrainerID, TrainerName From TBLTrainers");
            repositoryItemGridLookUpEditMainTrainerID.ValueMember = "TrainerID";
            repositoryItemGridLookUpEditMainTrainerID.DisplayMember = "TrainerName";
            //Courses
            repositoryItemGridLookUpEditCourseIdInDatabase.DataSource = MyCL.LoadDataTable("Select CourseId, CourseName From TBLCourses");
            repositoryItemGridLookUpEditCourseIdInDatabase.ValueMember = "CourseId";
            repositoryItemGridLookUpEditCourseIdInDatabase.DisplayMember = "CourseName";
            //Trainee
            repositoryItemGridLookUpEditTrainersTraineeOUTTraineeID.DataSource = MyCL.LoadDataTable(@"Select TraineeID, TraineeName, NameInEnglish, GenderID, 
            NationalityId, Mobile, Email From TBLTrainee Where TraineeTypeId = 2");
            repositoryItemGridLookUpEditTrainersTraineeOUTTraineeID.ValueMember = "TraineeID";
            repositoryItemGridLookUpEditTrainersTraineeOUTTraineeID.DisplayMember = "TraineeName";
            gridControlTBLTrainee.DataSource = MyCL.LoadDataTable(@"Select TraineeID, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, 
            Email From TBLTrainee Where TraineeTypeId = 2");
            //CoursePlace
            repositoryItemGridLookUpEditCoursePlace.DataSource = MyCL.LoadDataTable("Select PlaceID, PlaceName From CdPlace");
            repositoryItemGridLookUpEditCoursePlace.ValueMember = "PlaceID";
            repositoryItemGridLookUpEditCoursePlace.DisplayMember = "PlaceName";
            
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select OrderID, TrainerID, CourseName, OrderRemark, 
            DateOrder, CourseIdInDatabase, OrderOk, OrderClosed From TBLTrainersCoursesOut");
            gridControlMain.DataSource = GridTable;
            gridControlMain.RefreshDataSource();
        }
        private void LoadAllDetails()
        {
            CoursesTable = new DataTable("FalseX2011-07");
            CoursesTable = MyCL.LoadDataTable(@"Select OrderID, TrainerID, CourseName, OrderRemark, 
            Convert(nvarchar, DateOrder, 103) AS DateOrder, CourseIdInDatabase, OrderOk, OrderClosed From TBLTrainersCoursesOut");
            LUEOrder.Properties.DataSource = CoursesTable;
            LUEOrder.Properties.ValueMember = "OrderID";
            LUEOrder.Properties.DisplayMember = "CourseName";
            //Certificates
            repositoryItemGridLookUpEditCertificateID.DataSource = MyCL.LoadDataTable("Select CertificateID, Certificate From CDCertificates");
            repositoryItemGridLookUpEditCertificateID.ValueMember = "CertificateID";
            repositoryItemGridLookUpEditCertificateID.DisplayMember = "Certificate";
            //Gender
            repositoryItemGridLookUpEditGenderID.DataSource = MyCL.LoadDataTable("Select GenderID, Gender From CdGender");
            repositoryItemGridLookUpEditGenderID.ValueMember = "GenderID";
            repositoryItemGridLookUpEditGenderID.DisplayMember = "Gender";
            //Nationality
            repositoryItemGridLookUpEditNationalityId.DataSource = MyCL.LoadDataTable("Select NationalityId, Nationality From CdNationality");
            repositoryItemGridLookUpEditNationalityId.ValueMember = "NationalityId";
            repositoryItemGridLookUpEditNationalityId.DisplayMember = "Nationality";
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
            string DateOrder;
            if (Row["DateOrder"].ToString() == string.Empty)
                DateOrder = "NULL";
            else
                DateOrder = String.Format("CONVERT(DATETIME, '{0}', 103)", MyCL.ConvertToDateDMY(Row["DateOrder"].ToString()));
            string TrainerID;
            if (Row["TrainerID"].ToString() == string.Empty)
                TrainerID = "NULL";
            else
                TrainerID = String.Format("{0}", Row["TrainerID"]);
            string CourseName;
            if (Row["CourseName"].ToString() == string.Empty)
                CourseName = "NULL";
            else
                CourseName = String.Format("N'{0}'", Row["CourseName"]);
            string OrderRemark;
            if (Row["OrderRemark"].ToString() == string.Empty)
                OrderRemark = "NULL";
            else
                OrderRemark = String.Format("N'{0}'", Row["OrderRemark"]);
            string CourseIdInDatabase;
            if (Row["CourseIdInDatabase"].ToString() == string.Empty)
                CourseIdInDatabase = "NULL";
            else
                CourseIdInDatabase = String.Format("{0}", Row["CourseIdInDatabase"]);


            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                if (Row["OrderID"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    cmd.CommandText = string.Format(@"INSERT INTO TBLTrainersCoursesOut (DateOrder, TrainerID, CourseName, OrderRemark, CourseIdInDatabase, OrderOk, OrderClosed)
                    VALUES ({0}, {1}, {2}, {3}, {4}, '{5}', '{6}')", DateOrder, TrainerID, CourseName, OrderRemark, CourseIdInDatabase, Row["OrderOk"], Row["OrderClosed"]);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE TBLTrainersCoursesOut SET DateOrder = {0}, TrainerID = {1}, CourseName = {2}, OrderRemark = {3}, CourseIdInDatabase = {4},
                    OrderOk = '{5}', OrderClosed = '{6}' WHERE OrderID = {7}", DateOrder, TrainerID, CourseName, OrderRemark, CourseIdInDatabase, Row["OrderOk"], Row["OrderClosed"], Row["OrderID"]);
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
            if (Row["OrderID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From TBLTrainersCoursesOut Where OrderID = " + Row["OrderID"];
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
                LoadAllDetails();
        }
        private void LUEOrder_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEOrder.EditValue == null)
            {
                TBLTrainersTraineeOUT = new DataTable();
                TBLOrderCertificates = new DataTable();
                TBLWebTraineeOut = new DataTable();
            }
            //TrainersTraineeOUT
            TBLTrainersTraineeOUT = MyCL.LoadDataTable(@"Select OrderID, TraineeID, TraineeID AS TraineeID_Org From TBLTrainersTraineeOUT Where 
            OrderID = " + LUEOrder.EditValue);
            gridControlTrainersTraineeOUT.DataSource = TBLTrainersTraineeOUT;
            //OrderCertificates
            TBLOrderCertificates = MyCL.LoadDataTable(@"SELECT OrderID, CertificateID, CountCertificate, TotalValue, DateRecive, OrderOk, OrderClosed, Remark, CertificateID AS CertificateID_Org
            FROM TBLOrderCertificates Where OrderID = " + LUEOrder.EditValue);
            gridControlCertificates.DataSource = TBLOrderCertificates;
            //WebTraineeOut
            //TBLWebTraineeOut = MyCL.LoadDataTable(@"SELECT TraineeID, TraineeID AS TraineeID_Org, OrderID, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, mail FROM TBLWebTraineeOut
            //Where OrderID = " + LUEOrder.EditValue);
            //gridControlTBLTrainee.DataSource = TBLWebTraineeOut;
        }
        private void repositoryItemButtonEditCertificatesOK_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewCertificates.GetFocusedDataRow();
            if (Row["CertificateID"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("الحقول فارغه", true, this);
                LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
            }
            string CountCertificate;
            if (Row["CountCertificate"].ToString() == string.Empty)
                CountCertificate = "0";
            else
                CountCertificate = Row["CountCertificate"].ToString();
            string TotalValue;
            if (Row["TotalValue"].ToString() == string.Empty)
                TotalValue = "0";
            else
                TotalValue = Row["TotalValue"].ToString();

            string DateRecive;
            if (Row["DateRecive"].ToString() == string.Empty)
                DateRecive = "NULL";
            else
                DateRecive = String.Format("Convert(Datetime, '{0}', 103)", MyCL.ConvertToDateDMY(Row["DateRecive"].ToString()));
            string Remark;
            if (Row["Remark"].ToString() == string.Empty)
                Remark = "NULL";
            else
                Remark = String.Format("N'{0}'", Row["Remark"]);
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["CertificateID_Org"].ToString() == string.Empty)// Is Unsaved Row?
                        cmd.CommandText = string.Format(@"INSERT INTO TBLOrderCertificates (OrderID, CertificateID, CountCertificate, TotalValue, DateRecive, OrderOk, OrderClosed, Remark)
                        VALUES ({0}, {1}, {2}, {3}, {4}, '{5}', '{6}', {7})", LUEOrder.EditValue, Row["CertificateID"], CountCertificate, TotalValue, DateRecive, Row["OrderOk"], Row["OrderClosed"], Remark);
                    else
                        cmd.CommandText = string.Format(@"UPDATE TBLOrderCertificates
                        SET CertificateID = {0}, CountCertificate = {1}, TotalValue = {2}, DateRecive = {3}, OrderOk = '{4}', OrderClosed = '{5}', 
                        Remark = {6} WHERE (OrderID = {7}) AND (CertificateID = {8})", Row["CertificateID"], CountCertificate, TotalValue, DateRecive, Row["OrderOk"],
                        Row["OrderClosed"], Remark, LUEOrder.EditValue, Row["CertificateID_Org"]);
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
            LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
        }
        private void repositoryItemButtonEditCertificatesDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewCertificates.GetFocusedDataRow();
            if (Row["CertificateID_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"Delete From TBLOrderCertificates Where OrderID = {0} And CertificateID = {1}", Row["OrderID"], Row["CertificateID_Org"]);
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
            LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
        }
        private void repositoryItemButtonEditOkTrainersTraineeOUT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewTrainersTraineeOUT.GetFocusedDataRow();
            if (Row["TraineeID"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("الحقول فارغه", true, this);
                LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["OrderID"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"Insert Into TBLTrainersTraineeOUT (OrderID, TraineeID) VALUES ({0}, {1})", LUEOrder.EditValue, Row["TraineeID"]);
                    else
                        cmd.CommandText = string.Format(@"Update TBLTrainersTraineeOUT Set  TraineeID = {0} Where OrderID = {1} And TraineeID = {2}", Row["TraineeID"], LUEOrder.EditValue, Row["TraineeID_Org"]);
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
            LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
        }
        private void repositoryItemButtonEditDeleteTrainersTraineeOUT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewTrainersTraineeOUT.GetFocusedDataRow();
            if (Row["TraineeID_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"Delete From TBLTrainersTraineeOUT Where OrderID = {0} And TraineeID = {1}", Row["OrderID"], Row["TraineeID_Org"]);
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
            LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
        }
        #endregion
        //        private void repositoryItemButtonEditOkWebTraineeOut_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //        {
        //            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        //                return;
        //            DataRow Row = (DataRow)gridViewWebTraineeOut.GetFocusedDataRow();
        //            if (Row["TraineeID"].ToString() == string.Empty)
        //            {
        //                MyCL.ShowMsg("الحقول فارغه", true, this);
        //                LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
        //            }
        //            string TraineeName;
        //            if (Row["TraineeName"].ToString() == string.Empty)
        //                TraineeName = "NULL";
        //            else
        //                TraineeName = String.Format("N'{0}'", Row["TraineeName"]);
        //            string NameInEnglish;
        //            if (Row["NameInEnglish"].ToString() == string.Empty)
        //                NameInEnglish = "NULL";
        //            else
        //                NameInEnglish = String.Format("N'{0}'", Row["NameInEnglish"]);
        //            string GenderID;
        //            if (Row["GenderID"].ToString() == string.Empty)
        //                GenderID = "NULL";
        //            else
        //                GenderID = Row["GenderID"].ToString();
        //            string NationalityId;
        //            if (Row["NationalityId"].ToString() == string.Empty)
        //                NationalityId = "NULL";
        //            else
        //                NationalityId = Row["NationalityId"].ToString();
        //            string Mobile;
        //            if (Row["Mobile"].ToString() == string.Empty)
        //                Mobile = "NULL";
        //            else
        //                Mobile = String.Format("N'{0}'", Row["Mobile"]);
        //            string mail;
        //            if (Row["mail"].ToString() == string.Empty)
        //                mail = "NULL";
        //            else
        //                mail = String.Format("N'{0}'", Row["mail"]);

        //            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
        //            {
        //                SqlCommand cmd = new SqlCommand("", con);
        //                try
        //                {
        //                    if (Row["TraineeID_Org"].ToString() == string.Empty)// Is Unsaved Row?
        //                        cmd.CommandText = string.Format(@"INSERT INTO TBLWebTraineeOut (OrderID, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, mail)
        //                        VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})", LUEOrder.EditValue, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, mail);
        //                    else
        //                    {
        //                        cmd.CommandText = string.Format(@"UPDATE TBLWebTraineeOut SET TraineeName = {0}, NameInEnglish = {1}, GenderID = {2}, NationalityId = {3}, 
        //                        Mobile = {4}, mail = {5} WHERE (OrderID = {6}) AND (TraineeID = {7})", TraineeName, NameInEnglish, GenderID, NationalityId,
        //                        Mobile, mail, LUEOrder.EditValue, Row["TraineeID_Org"]);
        //                    }
        //                    con.Open();
        //                    cmd.ExecuteNonQuery();
        //                    MyCL.ShowMsg("تم الحفظ", false, this);
        //                }
        //                catch (SqlException ex)
        //                {
        //                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
        //                }
        //                con.Close();
        //            }
        //            LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
        //        }
        //        private void repositoryItemButtonEditDeleteWebTraineeOut_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //        {
        //            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        //                return;
        //            DataRow Row = (DataRow)gridViewWebTraineeOut.GetFocusedDataRow();
        //            if (Row["TraineeID_Org"].ToString() == string.Empty)// Is Unsaved Row?
        //            {
        //                LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
        //                return;
        //            }
        //            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
        //            {
        //                SqlCommand cmd = new SqlCommand("", con);
        //                try
        //                {
        //                    cmd.CommandText = string.Format(@"Delete From TBLWebTraineeOut Where TraineeID = {0} And OrderID = {1}",
        //                    Row["TraineeID_Org"], LUEOrder.EditValue);
        //                    con.Open();
        //                    cmd.ExecuteNonQuery();
        //                    MyCL.ShowMsg("تم الحذف", false, this);
        //                }
        //                catch (SqlException ex)
        //                {
        //                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
        //                }
        //                con.Close();
        //            }
        //            LUEOrder_EditValueChanged(LUEOrder, new EventArgs());
        //        }
    }
}