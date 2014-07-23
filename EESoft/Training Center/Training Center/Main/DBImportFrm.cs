using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Training_Center
{
    public partial class DBImportFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        string AccessDBConStr = string.Empty;

        DataTable SRCTBLTrainee = new DataTable();
        DataTable SRCTBLWebReservation = new DataTable();
        DataTable SRCTBLTrainersCoursesOut = new DataTable();
        DataTable SRCTBLTrainersTraineeOUT = new DataTable();
        DataTable SRCTBLOrderCertificates = new DataTable();
        DataTable TrgCdBankAccount = new DataTable();
        DataTable TrgCDCertificates = new DataTable();
        DataTable TrgCDCourseType = new DataTable();
        DataTable TrgCDjob = new DataTable();
        DataTable TrgCDknow = new DataTable();
        DataTable TrgCdPlace = new DataTable();
        DataTable TrgCdLab = new DataTable();
        DataTable TrgCDMembershipType = new DataTable();
        DataTable TrgCdNationality = new DataTable();
        DataTable TrgCDReservationWay = new DataTable();
        DataTable TrgCDTrainingBag = new DataTable();
        DataTable TrgTBLPartners = new DataTable();
        DataTable TrgTBLCourses = new DataTable();
        DataTable TrgTBLCourseCertificates = new DataTable();
        DataTable TrgTBLCourseAgenda = new DataTable();
        DataTable TrgTBLCourseTrainers = new DataTable();
        DataTable TrgTBLTrainers = new DataTable();
        DataTable TrgTBLTrainersBag = new DataTable();
        DataTable TrgTBLAttend = new DataTable();
        DataTable TrgTBLReservation = new DataTable();
        DataTable TrgTBLTraineeCertificates = new DataTable();
        DataTable TrgTBLMemberShip = new DataTable();
        
        #endregion
        #region -   Functions   -
        public DBImportFrm()
        {
            InitializeComponent();
        }
        private DataTable LoadTableAccess(string CommandString, string DBFileName)
        {
            DataTable ReturnMe = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("", String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"{0}\"", DBFileName));
            da.SelectCommand.CommandText = CommandString;
            da.Fill(ReturnMe);
            return ReturnMe;
        }

        private bool ImportTBLTrainee()
        {
            bool ReturnMe = false;
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLTrainee in SRCTBLTrainee.Rows)// Sync Table
                {
                    string GenderID;
                    if (RowSRCTBLTrainee["GenderID"].ToString() == string.Empty)
                        GenderID = "NULL";
                    else
                        GenderID = RowSRCTBLTrainee["GenderID"].ToString();
                    string NationalityId;
                    if (RowSRCTBLTrainee["NationalityId"].ToString() == string.Empty)
                        NationalityId = "NULL";
                    else
                        NationalityId = RowSRCTBLTrainee["NationalityId"].ToString();
                    string jobID;
                    if (RowSRCTBLTrainee["jobID"].ToString() == string.Empty)
                        jobID = "NULL";
                    else
                        jobID = RowSRCTBLTrainee["jobID"].ToString();
                    string MembershipTypeID;
                    if (RowSRCTBLTrainee["MembershipTypeID"].ToString() == string.Empty)
                        MembershipTypeID = "NULL";
                    else
                        MembershipTypeID = RowSRCTBLTrainee["MembershipTypeID"].ToString();

                    string TraineeTypeId;
                    if (RowSRCTBLTrainee["TraineeTypeId"].ToString() == string.Empty)
                        TraineeTypeId = "NULL";
                    else
                        TraineeTypeId = RowSRCTBLTrainee["TraineeTypeId"].ToString();

                    string TimeIn;
                    if (RowSRCTBLTrainee["TimeIn"].ToString() == string.Empty)
                        TimeIn = "GETDATE()";
                    else
                        TimeIn = string.Format("Convert(Datetime, '{0}', 120)", RowSRCTBLTrainee["TimeIn"]);
                    
                    PBCImport.EditValue = (int)PBCImport.EditValue + 1;
                    Application.DoEvents(); cmd.Parameters.Clear();

//                    cmd.CommandText = string.Format(@"if exists(Select * From TBLTrainee Where TraineeID = {0})
//                    UPDATE TBLTrainee SET TraineeName = N'{1}', NameInEnglish = N'{2}', GenderID = {3}, NationalityId = {4}, Mobile = N'{5}', Email = N'{6}', City = N'{7}', Address = N'{8}', jobID = {9}, OtherJob = N'{10}', 
//                    CertificateAddress = N'{11}', MembershipTypeID = {12}, MembershipNo = N'{13}', REM = N'{14}', UserName = N'{15}', password = N'{16}', image = N'{17}', 
//                    TraineeTypeId = {18}, TimeIn = {19} WHERE (TraineeID = {0})
//                    Else
//                    INSERT INTO TBLTrainee (TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob, CertificateAddress, MembershipTypeID, MembershipNo, REM, 
//                    UserName, password, image, TraineeID, TraineeTypeId, TimeIn) VALUES (N'{1}', N'{2}', {3}, {4}, N'{5}', N'{6}', N'{7}', N'{8}', {9}, N'{10}', N'{11}', {12}, N'{13}', N'{14}', N'{15}', N'{16}', N'{17}', {0}, {18}, {19})",
//                    RowSRCTBLTrainee["TraineeID"], RowSRCTBLTrainee["TraineeName"], RowSRCTBLTrainee["NameInEnglish"], GenderID, NationalityId,
//                    RowSRCTBLTrainee["Mobile"], RowSRCTBLTrainee["Email"], RowSRCTBLTrainee["City"], RowSRCTBLTrainee["Address"], jobID, RowSRCTBLTrainee["OtherJob"], RowSRCTBLTrainee["CertificateAddress"], MembershipTypeID,
//                    RowSRCTBLTrainee["MembershipNo"], RowSRCTBLTrainee["REM"], RowSRCTBLTrainee["UserName"], RowSRCTBLTrainee["password"], RowSRCTBLTrainee["image"], TraineeTypeId, TimeIn);
                    cmd.CommandText = string.Format(@"if exists(Select * From TBLTrainee Where TraineeID = {0})
                    UPDATE TBLTrainee SET TraineeName = @TraineeName, NameInEnglish = @NameInEnglish, GenderID = {1}, NationalityId = {2}, Mobile = N'{3}', Email = N'{4}', City = N'{5}', Address = N'{6}', jobID = {7}, OtherJob = N'{8}', 
                    CertificateAddress = N'{9}', MembershipTypeID = {10}, MembershipNo = N'{11}', REM = N'{12}', UserName = N'{13}', password = N'{14}', image = N'{15}', 
                    TraineeTypeId = {16}, TimeIn = {17} WHERE (TraineeID = {0})
                    Else
                    INSERT INTO TBLTrainee (TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob, CertificateAddress, MembershipTypeID, MembershipNo, REM, 
                    UserName, password, image, TraineeID, TraineeTypeId, TimeIn) VALUES (@TraineeName, @NameInEnglish, {1}, {2}, N'{3}', N'{4}', N'{5}', N'{6}', {7}, N'{8}', N'{9}', {10}, N'{11}', N'{12}', N'{13}', N'{14}', N'{15}', {0}, {16}, {17})",
                    RowSRCTBLTrainee["TraineeID"], GenderID, NationalityId,
                    RowSRCTBLTrainee["Mobile"], RowSRCTBLTrainee["Email"], RowSRCTBLTrainee["City"], RowSRCTBLTrainee["Address"], jobID, RowSRCTBLTrainee["OtherJob"], RowSRCTBLTrainee["CertificateAddress"], MembershipTypeID,
                    RowSRCTBLTrainee["MembershipNo"], RowSRCTBLTrainee["REM"], RowSRCTBLTrainee["UserName"], RowSRCTBLTrainee["password"], RowSRCTBLTrainee["image"], TraineeTypeId, TimeIn);
                    cmd.Parameters.AddWithValue("TraineeName", RowSRCTBLTrainee["TraineeName"]);
                    cmd.Parameters.AddWithValue("NameInEnglish", RowSRCTBLTrainee["NameInEnglish"]);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ImportTBLWebReservation()
        {
            bool ReturnMe = false;
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLWebReservation in SRCTBLWebReservation.Rows)// Sync Table
                {
                    string TraineeID;
                    if (RowSRCTBLWebReservation["TraineeID"].ToString() == string.Empty)
                        TraineeID = "NULL";
                    else
                        TraineeID = RowSRCTBLWebReservation["TraineeID"].ToString();
                    string CourseId;
                    if (RowSRCTBLWebReservation["CourseId"].ToString() == string.Empty)
                        CourseId = "NULL";
                    else
                        CourseId = RowSRCTBLWebReservation["CourseId"].ToString();
                    string ReservationDate;
                    if (RowSRCTBLWebReservation["ReservationDate"].ToString() == string.Empty)
                        ReservationDate = "NULL";
                    else
                        ReservationDate = string.Format("Convert(Datetime, '{0}', 103)", RowSRCTBLWebReservation["ReservationDate"]);
                    
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents(); cmd.Parameters.Clear();

                    cmd.CommandText = string.Format(@"if exists(Select * From TBLWebReservation Where TraineeID = {0} And CourseId = {1}) 
                    UPDATE TBLWebReservation SET ReservationDate = {2} WHERE (TraineeID = {0}) AND (CourseId = {1}) 
                    Else 
                    INSERT INTO TBLWebReservation (TraineeID, CourseId, ReservationDate) VALUES ({0}, {1}, {2})", TraineeID, CourseId, ReservationDate);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ImportTBLTrainersCoursesOut()
        {
            bool ReturnMe = false;
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLTrainersCoursesOut in SRCTBLTrainersCoursesOut.Rows)// Sync Table
                {
                    string OrderID;
                    if (RowSRCTBLTrainersCoursesOut["OrderID"].ToString() == string.Empty)
                        OrderID = "NULL";
                    else
                        OrderID = RowSRCTBLTrainersCoursesOut["OrderID"].ToString();
                    string TrainerID;
                    if (RowSRCTBLTrainersCoursesOut["TrainerID"].ToString() == string.Empty)
                        TrainerID = "NULL";
                    else
                        TrainerID = RowSRCTBLTrainersCoursesOut["TrainerID"].ToString();
                    string CourseIdInDatabase;
                    if (RowSRCTBLTrainersCoursesOut["CourseIdInDatabase"].ToString() == string.Empty)
                        CourseIdInDatabase = "NULL";
                    else
                        CourseIdInDatabase = RowSRCTBLTrainersCoursesOut["CourseIdInDatabase"].ToString();
                    string DateOrder;
                    if (RowSRCTBLTrainersCoursesOut["DateOrder"].ToString() == string.Empty)
                        DateOrder = "NULL";
                    else
                        DateOrder = string.Format("Convert(Datetime, '{0}', 103)", RowSRCTBLTrainersCoursesOut["DateOrder"]);
                    //string TimeIn;
                    //if (RowSRCTBLTrainersCoursesOut["TimeIn"].ToString() == string.Empty)
                    //    TimeIn = "GERDATE()";
                    //else
                    //    TimeIn = string.Format("Convert(Datetime, '{0}', 120)", RowSRCTBLTrainersCoursesOut["TimeIn"]);
                    string OrderOk;
                    if (RowSRCTBLTrainersCoursesOut["OrderOk"].ToString() == string.Empty)
                        OrderOk = "False";
                    else
                        OrderOk = RowSRCTBLTrainersCoursesOut["OrderOk"].ToString();
                    string OrderClosed;
                    if (RowSRCTBLTrainersCoursesOut["OrderClosed"].ToString() == string.Empty)
                        OrderClosed = "False";
                    else
                        OrderClosed = RowSRCTBLTrainersCoursesOut["OrderClosed"].ToString();

                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();

                    cmd.CommandText = string.Format(@"if exists(Select * From TBLTrainersCoursesOut Where OrderID = {0}) 
                    UPDATE TBLTrainersCoursesOut
                    SET DateOrder = {1}, TrainerID = {2}, CourseName = N'{3}', OrderRemark = N'{4}', CourseIdInDatabase = {5}, OrderOk = '{6}', OrderClosed = '{7}', TimeIn = GETDATE()
                    WHERE (OrderID = {0})
                    Else 
                    INSERT INTO TBLTrainersCoursesOut (OrderID, DateOrder, TrainerID, CourseName, OrderRemark, CourseIdInDatabase, OrderOk, OrderClosed, TimeIn)
                    VALUES ({0}, {1}, {2}, N'{3}', N'{4}', {5}, '{6}', '{7}', GETDATE())", OrderID, DateOrder, TrainerID, RowSRCTBLTrainersCoursesOut["CourseName"], RowSRCTBLTrainersCoursesOut["OrderRemark"],
                    CourseIdInDatabase, OrderOk, OrderClosed);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ImportTBLTrainersTraineeOUT()
        {
            bool ReturnMe = false;
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLTrainersTraineeOUT in SRCTBLTrainersTraineeOUT.Rows)// Sync Table
                {
                    string OrderID;
                    if (RowSRCTBLTrainersTraineeOUT["OrderID"].ToString() == string.Empty)
                        OrderID = "NULL";
                    else
                        OrderID = RowSRCTBLTrainersTraineeOUT["OrderID"].ToString();
                    string TraineeID;
                    if (RowSRCTBLTrainersTraineeOUT["TraineeID"].ToString() == string.Empty)
                        TraineeID = "NULL";
                    else
                        TraineeID = RowSRCTBLTrainersTraineeOUT["TraineeID"].ToString();

                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();

                    cmd.CommandText = string.Format(@"if not exists(Select * From TBLTrainersTraineeOUT Where OrderID = {0} And TraineeID = {1}) 
                    INSERT INTO TBLTrainersTraineeOUT (OrderID, TraineeID, UserIn, TimeIn) VALUES ({0}, {1}, {2}, GETDATE())", OrderID, TraineeID, MyCL.UserInfo.UserID);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ImportTBLOrderCertificates()
        {
            bool ReturnMe = false;
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLOrderCertificates in SRCTBLOrderCertificates.Rows)// Sync Table
                {
                    string OrderID;
                    if (RowSRCTBLOrderCertificates["OrderID"].ToString() == string.Empty)
                        OrderID = "NULL";
                    else
                        OrderID = RowSRCTBLOrderCertificates["OrderID"].ToString();
                    string CertificateID;
                    if (RowSRCTBLOrderCertificates["CertificateID"].ToString() == string.Empty)
                        CertificateID = "NULL";
                    else
                        CertificateID = RowSRCTBLOrderCertificates["CertificateID"].ToString();
                    string CountCertificate;
                    if (RowSRCTBLOrderCertificates["CountCertificate"].ToString() == string.Empty)
                        CountCertificate = "0";
                    else
                        CountCertificate = RowSRCTBLOrderCertificates["CountCertificate"].ToString();
                    string TotalValue;
                    if (RowSRCTBLOrderCertificates["TotalValue"].ToString() == string.Empty)
                        TotalValue = "0";
                    else
                        TotalValue = RowSRCTBLOrderCertificates["TotalValue"].ToString();
                    string DateRecive;
                    if (RowSRCTBLOrderCertificates["DateRecive"].ToString() == string.Empty)
                        DateRecive = "NULL";
                    else
                        DateRecive = string.Format("Convert(Datetime, '{0}', 103)", RowSRCTBLOrderCertificates["DateRecive"]);
                    string OrderOk;
                    if (RowSRCTBLOrderCertificates["OrderOk"].ToString() == string.Empty)
                        OrderOk = "False";
                    else
                        OrderOk = RowSRCTBLOrderCertificates["OrderOk"].ToString();
                    string OrderClosed;
                    if (RowSRCTBLOrderCertificates["OrderClosed"].ToString() == string.Empty)
                        OrderClosed = "False";
                    else
                        OrderClosed = RowSRCTBLOrderCertificates["OrderClosed"].ToString();
                    string Remark;
                    if (RowSRCTBLOrderCertificates["Remark"].ToString() == string.Empty)
                        Remark = "NULL";
                    else
                        Remark = string.Format("N'{0}'", RowSRCTBLOrderCertificates["Remark"]);

                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();

                    cmd.CommandText = string.Format(@"if exists(Select * From TBLOrderCertificates Where OrderID = {0} And CertificateID = {1}) 
                    UPDATE TBLOrderCertificates
                    SET CountCertificate = {2}, TotalValue = {3}, DateRecive = {4}, OrderOk = '{5}', OrderClosed = '{6}', Remark = {7}, UserIn = {8}, TimeIn = GETDATE()
                    WHERE OrderID = {0} AND CertificateID = {1}
                    Else 
                    INSERT INTO TBLOrderCertificates
                    (OrderID, CertificateID, CountCertificate, TotalValue, DateRecive, OrderOk, OrderClosed, Remark, UserIn, TimeIn)
                    VALUES ({0}, {1}, {2}, {3}, {4}, '{5}', '{6}', {7}, {8}, GETDATE())", OrderID, CertificateID, CountCertificate, TotalValue, DateRecive, 
                    OrderOk, OrderClosed, Remark, MyCL.UserInfo.UserID);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }

        private bool ExportCdBankAccount()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                
                foreach (DataRow RowSRCCdBankAccount in TrgCdBankAccount.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string AccountID;
                    if (RowSRCCdBankAccount["AccountID"].ToString() == string.Empty)
                        AccountID = "NULL";
                    else
                        AccountID = RowSRCCdBankAccount["AccountID"].ToString();
                    string AccountName;
                    if (RowSRCCdBankAccount["AccountName"].ToString() == string.Empty)
                        AccountName = "NULL";
                    else
                        AccountName = String.Format("'{0}'", RowSRCCdBankAccount["AccountName"]);

                    string AccountNumber;
                    if (RowSRCCdBankAccount["AccountNumber"].ToString() == string.Empty)
                        AccountNumber = "NULL";
                    else
                        AccountNumber = RowSRCCdBankAccount["AccountNumber"].ToString();
                    cmd.CommandText = @"Select Count(*) From CdBankAccount Where AccountID = " + AccountID;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CdBankAccount SET AccountName = {0}, AccountNumber = {1} WHERE (AccountID = {2})", AccountName, AccountNumber, AccountID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CdBankAccount (AccountID, AccountName, AccountNumber) VALUES ({0}, {1}, {2})", AccountID, AccountName, AccountNumber);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCDCertificates()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCDCertificates in TrgCDCertificates.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string CertificateID;
                    if (RowSRCCDCertificates["CertificateID"].ToString() == string.Empty)
                        CertificateID = "NULL";
                    else
                        CertificateID = RowSRCCDCertificates["CertificateID"].ToString();
                    string Certificate;
                    if (RowSRCCDCertificates["Certificate"].ToString() == string.Empty)
                        Certificate = "NULL";
                    else
                        Certificate = String.Format("'{0}'", RowSRCCDCertificates["Certificate"]);
                    string CertificateFrom;
                    if (RowSRCCDCertificates["Certificate"].ToString() == string.Empty)
                        CertificateFrom = "NULL";
                    else
                        CertificateFrom = RowSRCCDCertificates["CertificateFrom"].ToString();
                    string CertificateValue;
                    if (RowSRCCDCertificates["CertificateValue"].ToString() == string.Empty)
                        CertificateValue = "0";
                    else
                        CertificateValue = RowSRCCDCertificates["CertificateValue"].ToString();

                    cmd.CommandText = @"Select Count(*) From CDCertificates Where CertificateID = " + RowSRCCDCertificates["CertificateID"];
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CDCertificates SET Certificate = {0}, CertificateFrom = {1}, CertificateValue = {2} WHERE (CertificateID = {3})", Certificate, CertificateFrom, CertificateValue, CertificateID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CDCertificates (CertificateID, Certificate, CertificateFrom, CertificateValue) VALUES ({0}, {1}, {2}, {3})", CertificateID, Certificate, CertificateFrom, CertificateValue);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCDCourseType()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCDCourseType in TrgCDCourseType.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string CourseTypeID;
                    if (RowSRCCDCourseType["CourseTypeID"].ToString() == string.Empty)
                        CourseTypeID = "NULL";
                    else
                        CourseTypeID = RowSRCCDCourseType["CourseTypeID"].ToString();

                    string CourseTypeName;
                    if (RowSRCCDCourseType["CourseTypeName"].ToString() == string.Empty)
                        CourseTypeName = "NULL";
                    else
                        CourseTypeName = String.Format("'{0}'", RowSRCCDCourseType["CourseTypeName"]);

                    cmd.CommandText = @"Select Count(*) From CDCourseType Where CourseTypeID = " + CourseTypeID;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CDCourseType SET CourseTypeName = {0} WHERE (CourseTypeID = {1})", CourseTypeName, CourseTypeID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CDCourseType (CourseTypeID, CourseTypeName) VALUES ({0}, {1})", CourseTypeID, CourseTypeName);
                    cmd.ExecuteNonQuery(); 
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCDjob()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCDjob in TrgCDjob.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string jobID;
                    if (RowSRCCDjob["jobID"].ToString() == string.Empty)
                        jobID = "NULL";
                    else
                        jobID = RowSRCCDjob["jobID"].ToString();

                    string job;
                    if (RowSRCCDjob["job"].ToString() == string.Empty)
                        job = "NULL";
                    else
                        job = String.Format("'{0}'", RowSRCCDjob["job"]);

                    cmd.CommandText = @"Select Count(*) From Cdjob Where jobID = " + jobID;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE Cdjob SET job = {0} WHERE (jobID = {1})", job, jobID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO Cdjob (jobID, job) VALUES ({0}, {1})", jobID, job);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCDknow()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCDknow in TrgCDknow.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string knowID;
                    if (RowSRCCDknow["knowID"].ToString() == string.Empty)
                        knowID = "NULL";
                    else
                        knowID = RowSRCCDknow["knowID"].ToString();
                    string know;
                    if (RowSRCCDknow["know"].ToString() == string.Empty)
                        know = "NULL";
                    else
                        know = String.Format("'{0}'", RowSRCCDknow["know"]);

                    cmd.CommandText = @"Select Count(*) From CDknow Where knowID = " + knowID;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CDknow SET know = {0} WHERE (knowID = {1})", know, knowID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CDknow (knowID, know) VALUES ({0}, {1})", knowID, know);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCdPlace()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCdPlace in TrgCdPlace.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string PlaceID;
                    if (RowSRCCdPlace["PlaceID"].ToString() == string.Empty)
                        PlaceID = "NULL";
                    else
                        PlaceID = RowSRCCdPlace["PlaceID"].ToString();
                    string PlaceName;
                    if (RowSRCCdPlace["PlaceName"].ToString() == string.Empty)
                        PlaceName = "NULL";
                    else
                        PlaceName = String.Format("'{0}'", RowSRCCdPlace["PlaceName"]);
                    cmd.CommandText = @"Select Count(*) From CdPlace Where PlaceID = " + PlaceID;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CdPlace SET PlaceName = {0} WHERE (PlaceID = {1})", PlaceName, PlaceID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CdPlace (PlaceID, PlaceName) VALUES ({0}, {1})", PlaceID, PlaceName);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCdLab()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCdLab in TrgCdLab.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string LabId;
                    if (RowSRCCdLab["LabId"].ToString() == string.Empty)
                        LabId = "NULL";
                    else
                        LabId = RowSRCCdLab["LabId"].ToString();
                    string LabName;
                    if (RowSRCCdLab["LabName"].ToString() == string.Empty)
                        LabName = "NULL";
                    else
                        LabName = String.Format("'{0}'", RowSRCCdLab["LabName"]);
                    cmd.CommandText = @"Select Count(*) From CdLab Where LabId = " + LabId;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CdLab SET LabName = {0} WHERE (LabId = {1})", LabName, LabId);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CdLab (LabId, LabName) VALUES ({0}, {1})", LabId, LabName);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCDMembershipType()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCDMembershipType in TrgCDMembershipType.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string MembershipTypeID;
                    if (RowSRCCDMembershipType["MembershipTypeID"].ToString() == string.Empty)
                        MembershipTypeID = "NULL";
                    else
                        MembershipTypeID = RowSRCCDMembershipType["MembershipTypeID"].ToString();
                    string MembershipType;
                    if (RowSRCCDMembershipType["MembershipType"].ToString() == string.Empty)
                        MembershipType = "NULL";
                    else
                        MembershipType = String.Format("'{0}'", RowSRCCDMembershipType["MembershipType"]);
                    cmd.CommandText = @"Select Count(*) From CDMembershipType Where MembershipTypeID = " + MembershipTypeID;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CDMembershipType SET MembershipType = {0} WHERE (MembershipTypeID = {1})", MembershipType, MembershipTypeID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CDMembershipType (MembershipTypeID, MembershipType) VALUES ({0}, {1})", MembershipTypeID, MembershipType);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCdNationality()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCdNationality in TrgCdNationality.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();                    
                    string NationalityId;
                    if (RowSRCCdNationality["NationalityId"].ToString() == string.Empty)
                        NationalityId = "NULL";
                    else
                        NationalityId = RowSRCCdNationality["NationalityId"].ToString();
                    string Nationality;
                    if (RowSRCCdNationality["Nationality"].ToString() == string.Empty)
                        Nationality = "NULL";
                    else
                        Nationality = String.Format("'{0}'", RowSRCCdNationality["Nationality"]);

                    cmd.CommandText = @"Select Count(*) From CdNationality Where NationalityId = " + NationalityId;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CdNationality SET Nationality = {0} WHERE (NationalityId = {1})", Nationality, NationalityId);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CdNationality (NationalityId, Nationality) VALUES ({0}, {1})", NationalityId, Nationality);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCDReservationWay()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCCDReservationWay in TrgCDReservationWay.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string ReservationWayID;
                    if (RowSRCCDReservationWay["ReservationWayID"].ToString() == string.Empty)
                        ReservationWayID = "NULL";
                    else
                        ReservationWayID = RowSRCCDReservationWay["ReservationWayID"].ToString();
                    string ReservationWay;
                    if (RowSRCCDReservationWay["ReservationWay"].ToString() == string.Empty)
                        ReservationWay = "NULL";
                    else
                        ReservationWay = String.Format("'{0}'", RowSRCCDReservationWay["ReservationWay"]);

                    cmd.CommandText = @"Select Count(*) From CDReservationWay Where ReservationWayID = " + ReservationWayID;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CDReservationWay SET ReservationWay = {0} WHERE (ReservationWayID = {1})", ReservationWay, ReservationWayID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CDReservationWay (ReservationWayID, ReservationWay) VALUES ({0}, {1})", ReservationWayID, ReservationWay);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportCDTrainingBag()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCDTrainingBag in TrgCDTrainingBag.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string TrainingBagId;
                    if (RowSRCDTrainingBag["TrainingBagId"].ToString() == string.Empty)
                        TrainingBagId = "NULL";
                    else
                        TrainingBagId = RowSRCDTrainingBag["TrainingBagId"].ToString();
                    string CourseTypeID;
                    if (RowSRCDTrainingBag["CourseTypeID"].ToString() == string.Empty)
                        CourseTypeID = "NULL";
                    else
                        CourseTypeID = RowSRCDTrainingBag["CourseTypeID"].ToString();
                    string TrainingBag;
                    if (RowSRCDTrainingBag["TrainingBag"].ToString() == string.Empty)
                        TrainingBag = "NULL";
                    else
                        TrainingBag = String.Format("'{0}'", RowSRCDTrainingBag["TrainingBag"]);
                    string rem;
                    if (RowSRCDTrainingBag["rem"].ToString() == string.Empty)
                        rem = "NULL";
                    else
                        rem = String.Format("'{0}'", RowSRCDTrainingBag["rem"]);

                    cmd.CommandText = @"Select Count(*) From CDTrainingBag Where TrainingBagId = " + TrainingBagId;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE CDTrainingBag SET CourseTypeID = {0},  TrainingBag = {1}, rem = {2} WHERE (TrainingBagId = {3})", CourseTypeID, TrainingBag, rem, TrainingBagId);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO CDTrainingBag (TrainingBagId, CourseTypeID, TrainingBag, rem) VALUES ({0}, {1}, {2}, {3})", TrainingBagId, CourseTypeID, TrainingBag, rem);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLPartners()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLPartners in TrgTBLPartners.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string PartnerID;
                    if (RowSRCTBLPartners["PartnerID"].ToString() == string.Empty)
                        PartnerID = "NULL";
                    else
                        PartnerID = RowSRCTBLPartners["PartnerID"].ToString();
                    string Partner;
                    if (RowSRCTBLPartners["Partner"].ToString() == string.Empty)
                        Partner = "NULL";
                    else
                        Partner = String.Format("'{0}'", RowSRCTBLPartners["Partner"]);
                    string PartnersAddres;
                    if (RowSRCTBLPartners["PartnersAddres"].ToString() == string.Empty)
                        PartnersAddres = "NULL";
                    else
                        PartnersAddres = String.Format("'{0}'", RowSRCTBLPartners["PartnersAddres"]);
                    string Partnerphone;
                    if (RowSRCTBLPartners["Partnerphone"].ToString() == string.Empty)
                        Partnerphone = "NULL";
                    else
                        Partnerphone = String.Format("'{0}'", RowSRCTBLPartners["Partnerphone"]);
                    string Partnermobile;
                    if (RowSRCTBLPartners["Partnermobile"].ToString() == string.Empty)
                        Partnermobile = "NULL";
                    else
                        Partnermobile = String.Format("'{0}'", RowSRCTBLPartners["Partnermobile"]);
                    string Partnerfax;
                    if (RowSRCTBLPartners["Partnerfax"].ToString() == string.Empty)
                        Partnerfax = "NULL";
                    else
                        Partnerfax = String.Format("'{0}'", RowSRCTBLPartners["Partnerfax"]);
                    string Partneremail;
                    if (RowSRCTBLPartners["Partneremail"].ToString() == string.Empty)
                        Partneremail = "NULL";
                    else
                        Partneremail = String.Format("'{0}'", RowSRCTBLPartners["Partneremail"]);
                    string PartnerPerson;
                    if (RowSRCTBLPartners["PartnerPerson"].ToString() == string.Empty)
                        PartnerPerson = "NULL";
                    else
                        PartnerPerson = String.Format("'{0}'", RowSRCTBLPartners["PartnerPerson"]);

                    cmd.CommandText = @"Select Count(*) From TBLPartners Where PartnerID = " + PartnerID;
                    if ((int)cmd.ExecuteScalar() > 0)
                        cmd.CommandText = String.Format(@"UPDATE TBLPartners SET Partner = {0},  PartnersAddres = {1}, Partnerphone = {2}, Partnermobile = {3},  Partnerfax = {4}, Partneremail = {5}, PartnerPerson = {6} 
                        WHERE (PartnerID = {7})", Partner, PartnersAddres, Partnerphone, Partnermobile, Partnerfax, Partneremail, PartnerPerson, PartnerID);
                    else
                        cmd.CommandText = String.Format(@"INSERT INTO TBLPartners (PartnerID, Partner, PartnersAddres, Partnerphone, Partnermobile, Partnerfax, Partneremail, PartnerPerson) VALUES 
                        ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", PartnerID, Partner, PartnersAddres, Partnerphone, Partnermobile, Partnerfax, Partneremail, PartnerPerson);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLCourses()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLCourses in TrgTBLCourses.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string CourseId;
                    if (RowSRCTBLCourses["CourseId"].ToString() == string.Empty)
                        CourseId = "NULL";
                    else
                        CourseId = RowSRCTBLCourses["CourseId"].ToString();
                    string CourseTypeID;
                    if (RowSRCTBLCourses["CourseId"].ToString() == string.Empty)
                        CourseTypeID = "NULL";
                    else
                        CourseTypeID = RowSRCTBLCourses["CourseTypeID"].ToString();
                    string CourseName;
                    if (RowSRCTBLCourses["CourseName"].ToString() == string.Empty)
                        CourseName = "NULL";
                    else
                        CourseName = string.Format("'{0}'", RowSRCTBLCourses["CourseName"]);
                    string CoursePlace;
                    if (RowSRCTBLCourses["CoursePlace"].ToString() == string.Empty)
                        CoursePlace = "NULL";
                    else
                        CoursePlace = string.Format("'{0}'", RowSRCTBLCourses["CoursePlace"]);
                    string StartDate;
                    if (RowSRCTBLCourses["StartDate"].ToString() == string.Empty)
                        StartDate = "NULL";
                    else
                        StartDate = string.Format("Format('{0}', 'DD/MM/YYYY')", RowSRCTBLCourses["StartDate"]);
                    string EndDate;
                    if (RowSRCTBLCourses["EndDate"].ToString() == string.Empty)
                        EndDate = "NULL";
                    else
                        EndDate = string.Format("Format('{0}', 'DD/MM/YYYY')", RowSRCTBLCourses["EndDate"]);
                    string Price;
                    if (RowSRCTBLCourses["Price"].ToString() == string.Empty)
                        Price = "0";
                    else
                        Price = RowSRCTBLCourses["Price"].ToString();
                    string WithExam;
                    if (RowSRCTBLCourses["WithExam"].ToString() == string.Empty)
                        WithExam = "False";
                    else
                        WithExam = RowSRCTBLCourses["WithExam"].ToString();
                    string ExamMax;
                    if (RowSRCTBLCourses["ExamMax"].ToString() == string.Empty)
                        ExamMax = "0";
                    else
                        ExamMax = RowSRCTBLCourses["ExamMax"].ToString();
                    string ExamMin;
                    if (RowSRCTBLCourses["ExamMin"].ToString() == string.Empty)
                        ExamMin = "0";
                    else
                        ExamMin = RowSRCTBLCourses["ExamMin"].ToString();
                    string ApologyAllow;
                    if (RowSRCTBLCourses["ApologyAllow"].ToString() == string.Empty)
                        ApologyAllow = "False";
                    else
                        ApologyAllow = RowSRCTBLCourses["ApologyAllow"].ToString();
                    string rem;
                    if (RowSRCTBLCourses["rem"].ToString() == string.Empty)
                        rem = "NULL";
                    else
                        rem = String.Format("'{0}'", RowSRCTBLCourses["rem"]);
                    string LabId;
                    if (RowSRCTBLCourses["LabId"].ToString() == string.Empty)
                        LabId = "NULL";
                    else
                        LabId = RowSRCTBLCourses["LabId"].ToString();
                    string EvalAllow;
                    if (RowSRCTBLCourses["EvalAllow"].ToString() == string.Empty)
                        EvalAllow = "False";
                    else
                        EvalAllow = RowSRCTBLCourses["EvalAllow"].ToString();

                    string ShowOnline;
                    if (RowSRCTBLCourses["ShowOnline"].ToString() == string.Empty)
                        ShowOnline = "False";
                    else
                        ShowOnline = RowSRCTBLCourses["ShowOnline"].ToString();
                    cmd.CommandText = @"Select Count(*) From TBLCourses Where CourseId = " + CourseId;
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        cmd.CommandText = String.Format(@"UPDATE TBLCourses SET CourseTypeID = {0} , CourseName = {1} , CoursePlace = {2} , StartDate = {3}, 
                        EndDate = {4}, Price = {5} , WithExam = {6} , ExamMax = {7} , ExamMin = {8} , ApologyAllow = {9} , rem = {10} , LabId = {11} , 
                        EvalAllow = {12} , ShowOnline = {13} Where CourseId = {14}", CourseTypeID, CourseName, CoursePlace, StartDate, EndDate, Price, WithExam, ExamMax, ExamMin, ApologyAllow, rem, LabId, EvalAllow, ShowOnline, CourseId);
                    }
                    else
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLCourses (CourseId, CourseTypeID, CourseName, CoursePlace, StartDate, EndDate, Price, WithExam, ExamMax, ExamMin, ApologyAllow, rem, LabId, EvalAllow, ShowOnline)
                        VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", CourseId, CourseTypeID, CourseName, CoursePlace, StartDate, EndDate, Price, WithExam, ExamMax, ExamMin, ApologyAllow, rem, LabId, EvalAllow, ShowOnline);
                    }
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLCourseCertificates()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLCourseCertificates in TrgTBLCourseCertificates.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string CourseId;
                    if (RowSRCTBLCourseCertificates["CourseId"].ToString() == string.Empty)
                        CourseId = "NULL";
                    else
                        CourseId = RowSRCTBLCourseCertificates["CourseId"].ToString();
                    string CertificateID;
                    if (RowSRCTBLCourseCertificates["CertificateID"].ToString() == string.Empty)
                        CertificateID = "NULL";
                    else
                        CertificateID = RowSRCTBLCourseCertificates["CertificateID"].ToString();
                    cmd.CommandText = String.Format(@"Select Count(*) From TBLCourseCertificates Where CourseId = {0} And CertificateID = {1}", CourseId, CertificateID);
                    if ((int)cmd.ExecuteScalar() <= 0)
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLCourseCertificates (CourseId, CertificateID) VALUES ({0}, {1})", CourseId, CertificateID);
                        cmd.ExecuteNonQuery();
                    }
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLCourseAgenda()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLCourseAgenda in TrgTBLCourseAgenda.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string CourseId;
                    if (RowSRCTBLCourseAgenda["CourseId"].ToString() == string.Empty)
                        CourseId = "NULL";
                    else
                        CourseId = RowSRCTBLCourseAgenda["CourseId"].ToString();
                    string ADate;
                    if (RowSRCTBLCourseAgenda["ADate"].ToString() == string.Empty)
                        ADate = "NULL";
                    else
                        ADate = string.Format("Format('{0}', 'DD/MM/YYYY')", RowSRCTBLCourseAgenda["ADate"]);
                    string TimeFrom;
                    if (RowSRCTBLCourseAgenda["TimeFrom"].ToString() == string.Empty)
                        TimeFrom = "NULL";
                    else
                        TimeFrom = string.Format("Format('{0}', 'hh:mm:ss')", RowSRCTBLCourseAgenda["TimeFrom"]);
                    string TimeTo;
                    if (RowSRCTBLCourseAgenda["TimeTo"].ToString() == string.Empty)
                        TimeTo = "NULL";
                    else
                        TimeTo = string.Format("Format('{0}', 'hh:mm:ss')", RowSRCTBLCourseAgenda["TimeTo"]);
                    string subject;
                    if (RowSRCTBLCourseAgenda["subject"].ToString() == string.Empty)
                        subject = "NULL";
                    else
                        subject = String.Format("'{0}'", RowSRCTBLCourseAgenda["subject"]);

                    cmd.CommandText = String.Format("Select Count(*) From TBLCourseAgenda Where CourseId = {0} And ADate = {1}", CourseId, ADate);
                    
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        cmd.CommandText = String.Format(@"UPDATE TBLCourseAgenda SET TimeFrom = {0}, TimeTo = {1}, subject = {2}
                        WHERE (CourseId = {3}) AND (ADate = {4})", TimeFrom, TimeTo, subject, CourseId, ADate);
                    }
                    else
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLCourseAgenda (TimeFrom, TimeTo, subject, CourseId, ADate) VALUES ({0}, 
                        {1}, {2}, {3}, {4})", TimeFrom, TimeTo, subject, CourseId, ADate);
                    }
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLCourseTrainers()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLCourseTrainers in TrgTBLCourseTrainers.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string CourseId;
                    if (RowSRCTBLCourseTrainers["CourseId"].ToString() == string.Empty)
                        CourseId = "NULL";
                    else
                        CourseId = RowSRCTBLCourseTrainers["CourseId"].ToString();
                    string TrainerID;
                    if (RowSRCTBLCourseTrainers["TrainerID"].ToString() == string.Empty)
                        TrainerID = "NULL";
                    else
                        TrainerID = RowSRCTBLCourseTrainers["TrainerID"].ToString();

                    cmd.CommandText = String.Format(@"Select Count(*) From TBLCourseTrainers Where CourseId = {0} And TrainerID = {1}", CourseId, TrainerID);
                    if ((int)cmd.ExecuteScalar() <= 0)
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLCourseTrainers (CourseId, TrainerID) VALUES ({0}, {1})", CourseId, TrainerID);
                        cmd.ExecuteNonQuery();
                    }
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLTrainers()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLTrainers in TrgTBLTrainers.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string TrainerID;
                    if (RowSRCTBLTrainers["TrainerID"].ToString() == string.Empty)
                        TrainerID = "NULL";
                    else
                        TrainerID = RowSRCTBLTrainers["TrainerID"].ToString();
                    string TrainerName;
                    if (RowSRCTBLTrainers["TrainerName"].ToString() == string.Empty)
                        TrainerName = "NULL";
                    else
                        TrainerName = string.Format("'{0}'", RowSRCTBLTrainers["TrainerName"]);
                    string NameInEnglish;
                    if (RowSRCTBLTrainers["NameInEnglish"].ToString() == string.Empty)
                        NameInEnglish = "NULL";
                    else
                        NameInEnglish = string.Format("'{0}'", RowSRCTBLTrainers["NameInEnglish"]);
                    string GenderID;
                    if (RowSRCTBLTrainers["GenderID"].ToString() == string.Empty)
                        GenderID = "NULL";
                    else
                        GenderID = RowSRCTBLTrainers["GenderID"].ToString();
                    string NationalityId;
                    if (RowSRCTBLTrainers["NationalityId"].ToString() == string.Empty)
                        NationalityId = "NULL";
                    else
                        NationalityId = RowSRCTBLTrainers["NationalityId"].ToString();
                    string Mobile;
                    if (RowSRCTBLTrainers["Mobile"].ToString() == string.Empty)
                        Mobile = "NULL";
                    else
                        Mobile = string.Format("'{0}'", RowSRCTBLTrainers["Mobile"]);
                    string Email;
                    if (RowSRCTBLTrainers["Email"].ToString() == string.Empty)
                        Email = "NULL";
                    else
                        Email = string.Format("'{0}'", RowSRCTBLTrainers["Email"]);
                    string City;
                    if (RowSRCTBLTrainers["City"].ToString() == string.Empty)
                        City = "NULL";
                    else
                        City = string.Format("'{0}'", RowSRCTBLTrainers["City"]);
                    string Address;
                    if (RowSRCTBLTrainers["Address"].ToString() == string.Empty)
                        Address = "NULL";
                    else
                        Address = string.Format("'{0}'", RowSRCTBLTrainers["Address"]);
                    string jobID;
                    if (RowSRCTBLTrainers["jobID"].ToString() == string.Empty)
                        jobID = "NULL";
                    else
                        jobID = RowSRCTBLTrainers["jobID"].ToString();
                    string OtherJob;
                    if (RowSRCTBLTrainers["OtherJob"].ToString() == string.Empty)
                        OtherJob = "NULL";
                    else
                        OtherJob = string.Format("'{0}'", RowSRCTBLTrainers["OtherJob"]);
                    string CertificateAddress;
                    if (RowSRCTBLTrainers["CertificateAddress"].ToString() == string.Empty)
                        CertificateAddress = "NULL";
                    else
                        CertificateAddress = string.Format("'{0}'", RowSRCTBLTrainers["CertificateAddress"]);
                    string REM;
                    if (RowSRCTBLTrainers["REM"].ToString() == string.Empty)
                        REM = "NULL";
                    else
                        REM = string.Format("'{0}'", RowSRCTBLTrainers["REM"]);
                    string MembershipTypeID;
                    if (RowSRCTBLTrainers["MembershipTypeID"].ToString() == string.Empty)
                        MembershipTypeID = "NULL";
                    else
                        MembershipTypeID = RowSRCTBLTrainers["MembershipTypeID"].ToString();
                    string MembershipNo;
                    if (RowSRCTBLTrainers["MembershipNo"].ToString() == string.Empty)
                        MembershipNo = "NULL";
                    else
                        MembershipNo = string.Format("'{0}'", RowSRCTBLTrainers["MembershipNo"]);
                    string UserName;
                    if (RowSRCTBLTrainers["UserName"].ToString() == string.Empty)
                        UserName = "NULL";
                    else
                        UserName = string.Format("'{0}'", RowSRCTBLTrainers["UserName"]);
                    string password;
                    if (RowSRCTBLTrainers["password"].ToString() == string.Empty)
                        password = "NULL";
                    else
                        password = string.Format("'{0}'", RowSRCTBLTrainers["password"]);
                    string image;
                    if (RowSRCTBLTrainers["image"].ToString() == string.Empty)
                        image = "NULL";
                    else
                        image = string.Format("'{0}'", RowSRCTBLTrainers["image"]);

                    cmd.CommandText = @"Select Count(*) From TBLTrainers Where TrainerID = " + TrainerID;
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        cmd.CommandText = String.Format(@"UPDATE TBLTrainers
                        SET TrainerName = {0}, NameInEnglish = {1}, GenderID = {2}, NationalityId = {3}, Mobile = {4}, 
                        Email = {5}, City = {6}, Address = {7}, jobID = {8}, OtherJob = {9}, CertificateAddress = {10}, REM = {11}, 
                        MembershipTypeID = {12}, MembershipNo = {13}, UserName = {14}, [password] = {15}, [image] = {13} Where TrainerID = {17}", TrainerID, TrainerName, NameInEnglish, 
                        GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob, CertificateAddress, REM, MembershipTypeID, MembershipNo, UserName, password, image);
                    }
                    else
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLTrainers (TrainerID, TrainerName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob,
                        CertificateAddress, REM, MembershipTypeID, MembershipNo, UserName, [password], [image])
                        VALUES ({0},{1},{2},{3},{4},{5}, {6} ,{7},{8},{9},{10},{11}, {12},
                        {13},{14},{15},{16}, {17})", TrainerID, TrainerName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, OtherJob, 
                        CertificateAddress, REM, MembershipTypeID, MembershipNo, UserName, password, image);
                    }
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLTrainersBag()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRTBLTrainersBag in TrgTBLTrainersBag.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string TrainerID;
                    if (RowSRTBLTrainersBag["TrainerID"].ToString() == string.Empty)
                        TrainerID = "NULL";
                    else
                        TrainerID = RowSRTBLTrainersBag["TrainerID"].ToString();
                    string TrainingBagId;
                    if (RowSRTBLTrainersBag["TrainingBagId"].ToString() == string.Empty)
                        TrainingBagId = "NULL";
                    else
                        TrainingBagId = RowSRTBLTrainersBag["TrainingBagId"].ToString();
                    string DateAdoption;
                    if (RowSRTBLTrainersBag["DateAdoption"].ToString() == string.Empty)
                        DateAdoption = "NULL";
                    else
                        DateAdoption = string.Format("Format('{0}', 'DD/MM/YYYY')", RowSRTBLTrainersBag["DateAdoption"]);
                    string AdoptionValue;
                    if (RowSRTBLTrainersBag["AdoptionValue"].ToString() == string.Empty)
                        AdoptionValue = "NULL";
                    else
                        AdoptionValue = RowSRTBLTrainersBag["AdoptionValue"].ToString();
                    string Adoption;
                    if (RowSRTBLTrainersBag["Adoption"].ToString() == string.Empty)
                        Adoption = "False";
                    else
                        Adoption = RowSRTBLTrainersBag["Adoption"].ToString();
                    string AdoptionRemark;
                    if (RowSRTBLTrainersBag["AdoptionRemark"].ToString() == string.Empty)
                        AdoptionRemark = "NULL";
                    else
                        AdoptionRemark = string.Format("'{0}'", RowSRTBLTrainersBag["AdoptionRemark"]);
                    string AdoptionNo;
                    if (RowSRTBLTrainersBag["AdoptionNo"].ToString() == string.Empty)
                        AdoptionNo = "NULL";
                    else
                        AdoptionNo = string.Format("'{0}'", RowSRTBLTrainersBag["AdoptionNo"]);


                    cmd.CommandText = String.Format("Select Count(*) From TBLTrainersBag Where TrainerID = {0} And TrainingBagId = {1}", TrainerID, TrainingBagId);
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        cmd.CommandText = String.Format(@"UPDATE TBLTrainersBag SET DateAdoption = {0}, AdoptionValue = {1}, Adoption = {2}, AdoptionRemark = {3}, AdoptionNo = {4}
                        WHERE TrainerID = {5} AND TrainingBagId = {6}", DateAdoption, AdoptionValue, Adoption, AdoptionRemark, AdoptionNo, TrainerID, TrainingBagId);
                    }
                    else
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLTrainersBag (TrainerID, TrainingBagId, DateAdoption, AdoptionValue, Adoption, AdoptionRemark, AdoptionNo)
                        VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})", TrainerID, TrainingBagId, DateAdoption, AdoptionValue, Adoption, AdoptionRemark, AdoptionNo);
                    }
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLAttend()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLAttend in TrgTBLAttend.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string TraineeID;
                    if (RowSRCTBLAttend["TraineeID"].ToString() == string.Empty)
                        TraineeID = "NULL";
                    else
                        TraineeID = RowSRCTBLAttend["TraineeID"].ToString();
                    string CourseId;
                    if (RowSRCTBLAttend["CourseId"].ToString() == string.Empty)
                        CourseId = "NULL";
                    else
                        CourseId = RowSRCTBLAttend["CourseId"].ToString();
                    string ADate;
                    if (RowSRCTBLAttend["ADate"].ToString() == string.Empty)
                        ADate = "NULL";
                    else
                        ADate = string.Format("Format('{0}', 'DD/MM/YYYY')", RowSRCTBLAttend["ADate"]);

                    cmd.CommandText = String.Format("Select Count(*) From TBLAttend Where TraineeID = {0} And CourseId = {1} And ADate = {2}", TraineeID, CourseId, ADate);
                    if ((int)cmd.ExecuteScalar() <= 0)
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLAttend (TraineeID, CourseId, ADate)
                        VALUES ({0}, {1}, {2})", TraineeID, CourseId, ADate);
                        cmd.ExecuteNonQuery();
                    }
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLReservation()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLReservation in TrgTBLReservation.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string ReservationID;
                    if (RowSRCTBLReservation["ReservationID"].ToString() == string.Empty)
                        ReservationID = "NULL";
                    else
                        ReservationID = RowSRCTBLReservation["ReservationID"].ToString();
                    string TraineeID;
                    if (RowSRCTBLReservation["TraineeID"].ToString() == string.Empty)
                        TraineeID = "NULL";
                    else
                        TraineeID = RowSRCTBLReservation["TraineeID"].ToString();
                    string CourseId;
                    if (RowSRCTBLReservation["CourseId"].ToString() == string.Empty)
                        CourseId = "NULL";
                    else
                        CourseId = RowSRCTBLReservation["CourseId"].ToString();
                    string ReservationWayID;
                    if (RowSRCTBLReservation["ReservationWayID"].ToString() == string.Empty)
                        ReservationWayID = "NULL";
                    else
                        ReservationWayID = RowSRCTBLReservation["ReservationWayID"].ToString();

                    string TransferDate;
                    if (RowSRCTBLReservation["TransferDate"].ToString() == string.Empty)
                        TransferDate = "NULL";
                    else
                        TransferDate = String.Format("Format('{0}', 'DD/MM/YYYY')", RowSRCTBLReservation["TransferDate"]);
                    string TransferValue;
                    if (RowSRCTBLReservation["TransferValue"].ToString() == string.Empty)
                        TransferValue = "NULL";
                    else
                        TransferValue = RowSRCTBLReservation["TransferValue"].ToString();
                    string AccountID;
                    if (RowSRCTBLReservation["AccountID"].ToString() == string.Empty)
                        AccountID = "NULL";
                    else
                        AccountID = RowSRCTBLReservation["AccountID"].ToString();
                    string esalno;
                    if (RowSRCTBLReservation["esalno"].ToString() == string.Empty)
                        esalno = "NULL";
                    else
                        esalno = String.Format("'{0}'", RowSRCTBLReservation["esalno"]);

                    cmd.CommandText = "Select Count(*) From TBLReservation Where Rid = " + ReservationID;
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        cmd.CommandText = String.Format(@"UPDATE TBLReservation SET TraineeID = {0}, CourseId = {1}, ReservationWayID = {2}, TransferDate = {3}, 
                        TransferValue = {4}, AccountID = {5}, esalno = {6} WHERE Rid = {7}", TraineeID, CourseId, ReservationWayID, TransferDate, TransferValue, AccountID, esalno, ReservationID);
                    }
                    else
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLReservation (Rid, TraineeID, CourseId, ReservationWayID, TransferDate, TransferValue, AccountID, esalno)
                        VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", ReservationID, TraineeID, CourseId, ReservationWayID, TransferDate, TransferValue, AccountID, esalno);
                    }
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLTraineeCertificates()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLTraineeCertificates in TrgTBLTraineeCertificates.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    string TraineeID;
                    if (RowSRCTBLTraineeCertificates["TraineeID"].ToString() == string.Empty)
                        TraineeID = "NULL";
                    else
                        TraineeID = RowSRCTBLTraineeCertificates["TraineeID"].ToString();
                    string CourseId;
                    if (RowSRCTBLTraineeCertificates["CourseId"].ToString() == string.Empty)
                        CourseId = "NULL";
                    else
                        CourseId = RowSRCTBLTraineeCertificates["CourseId"].ToString();
                    string CertificateID;
                    if (RowSRCTBLTraineeCertificates["CertificateID"].ToString() == string.Empty)
                        CertificateID = "NULL";
                    else
                        CertificateID = RowSRCTBLTraineeCertificates["CertificateID"].ToString();

                    string CertificateValue;
                    if (RowSRCTBLTraineeCertificates["CertificateValue"].ToString() == string.Empty)
                        CertificateValue = "NULL";
                    else
                        CertificateValue = RowSRCTBLTraineeCertificates["CertificateValue"].ToString();
                    string ReceiptDate;
                    if (RowSRCTBLTraineeCertificates["ReceiptDate"].ToString() == string.Empty)
                        ReceiptDate = "NULL";
                    else
                        ReceiptDate = String.Format("Format('{0}', 'DD/MM/YYYY')", RowSRCTBLTraineeCertificates["ReceiptDate"]);
                    string UniqueNo;
                    if (RowSRCTBLTraineeCertificates["UniqueNo"].ToString() == string.Empty)
                        UniqueNo = "NULL";
                    else
                        UniqueNo = String.Format("'{0}'", RowSRCTBLTraineeCertificates["UniqueNo"]);

                    cmd.CommandText = String.Format("Select Count(*) From TBLTraineeCertificates Where TraineeID = {0} And CourseId = {1} And CertificateID = {2}", TraineeID, CourseId, CertificateID);
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        cmd.CommandText = String.Format(@"UPDATE TBLTraineeCertificates SET ReceiptDate = {0}, CertificateValue = {1}, UniqueNo = {2}
                        WHERE TraineeID = {3} And CourseId = {4} And CertificateID = {5}", ReceiptDate, CertificateValue, UniqueNo, TraineeID, CourseId, CertificateID);
                    }
                    else
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLTraineeCertificates (TraineeID, CourseId, CertificateID, CertificateValue, ReceiptDate, UniqueNo)
                        VALUES ({0}, {1}, {2}, {3}, {4}, {5})", TraineeID, CourseId, CertificateID, CertificateValue, ReceiptDate, UniqueNo);
                    }
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        private bool ExportTBLMemberShip()
        {
            bool ReturnMe = false;
            OleDbConnection con = new OleDbConnection(AccessDBConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            OleDbTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow RowSRCTBLMemberShip in TrgTBLMemberShip.Rows)// Sync Table
                {
                    PBCExport.EditValue = (int)PBCExport.EditValue + 1;
                    Application.DoEvents();
                    
                    string TrainerID;
                    if (RowSRCTBLMemberShip["TrainerID"].ToString() == string.Empty)
                        TrainerID = "NULL";
                    else
                        TrainerID = RowSRCTBLMemberShip["TrainerID"].ToString();
                    string MembershipFrom;
                    if (RowSRCTBLMemberShip["MembershipFrom"].ToString() == string.Empty)
                        MembershipFrom = "NULL";
                    else
                        MembershipFrom = string.Format("Format('{0}', 'DD/MM/YYYY')", RowSRCTBLMemberShip["MembershipFrom"]);
                    string MembershipTo;
                    if (RowSRCTBLMemberShip["MembershipTo"].ToString() == string.Empty)
                        MembershipTo = "NULL";
                    else
                        MembershipTo = string.Format("Format('{0}', 'DD/MM/YYYY')", RowSRCTBLMemberShip["MembershipTo"]);
                    string MembershipValue;
                    if (RowSRCTBLMemberShip["MembershipValue"].ToString() == string.Empty)
                        MembershipValue = "0";
                    else
                        MembershipValue = RowSRCTBLMemberShip["MembershipValue"].ToString();

                    cmd.CommandText = String.Format("Select Count(*) From TBLMemberShip Where TrainerID = {0} And MembershipFrom = {1}", TrainerID, MembershipFrom);
                    if ((int)cmd.ExecuteScalar() <= 0)
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO TBLMemberShip (TrainerID, MembershipFrom, MembershipTo, MembershipValue)
                        VALUES ({0}, {1}, {2}, {3})", TrainerID, MembershipFrom, MembershipTo, MembershipValue);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd.CommandText = String.Format(@"UPDATE TBLMemberShip SET MembershipTo = {0}, MembershipValue = {1}
                        WHERE (TrainerID = {2}) AND (MembershipFrom = {3})", MembershipTo, MembershipValue, TrainerID, MembershipFrom);
                        cmd.ExecuteNonQuery();
                    }
                }
                trn.Commit();
                ReturnMe = true;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
                trn.Rollback();
            }
            con.Close();
            return ReturnMe;
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnUpdateImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Access database (*.mdb)|*.mdb|All Files (*.*)|*.*", CheckFileExists = true, CheckPathExists = true };
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            xTabC.Enabled = false;
            PBCImport.Properties.Maximum = 0;
            
            PBCImport.EditValue = 0;
            List<object> Tablez = CCBEImport.Properties.Items.GetCheckedValues();
            foreach (object item in Tablez)
            {
                switch ((string)item)// Get Progress bar max value
                {
                    case "mbImportTBLTrainee":
                        SRCTBLTrainee = LoadTableAccess(@"SELECT TraineeID, TraineeName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID,
                        OtherJob, CertificateAddress, MembershipTypeID, MembershipNo, REM, UserName, [password], [image], TraineeTypeId, Format(TimeIn, 'yyyy-mm-dd hh:mm:ss') AS TimeIn FROM TBLTrainee", ofd.FileName);
                        PBCImport.Properties.Maximum += SRCTBLTrainee.Rows.Count;
                        break;

                    case "mbImportTBLWebReservation":
                        SRCTBLWebReservation = LoadTableAccess("SELECT RID, TraineeID, CourseId, Format(ReservationDate,'DD/MM/YYYY') AS ReservationDate FROM TBLWebReservation", ofd.FileName);
                        PBCImport.Properties.Maximum += SRCTBLWebReservation.Rows.Count;
                        break;
                    case "mbTBLTrainersCoursesOut":
                        SRCTBLTrainersCoursesOut = LoadTableAccess(@"SELECT OrderID, Format(DateOrder,'DD/MM/YYYY') AS DateOrder, TrainerID, 
                        CourseName, OrderRemark, CourseIdInDatabase, OrderOk, OrderClosed 
                        FROM TBLTrainersCoursesOut", ofd.FileName);
                        PBCImport.Properties.Maximum += SRCTBLTrainersCoursesOut.Rows.Count;
                        break;
                    case "mbTBLTrainersTraineeOUT":
                        SRCTBLTrainersTraineeOUT = LoadTableAccess(@"SELECT OrderID, TraineeID FROM TBLTrainersTraineeOUT", ofd.FileName);
                        PBCImport.Properties.Maximum += SRCTBLTrainersTraineeOUT.Rows.Count;
                        break;
                    case "mbTBLOrderCertificates":
                        SRCTBLOrderCertificates = LoadTableAccess(@"SELECT OrderID, CertificateID, CountCertificate, TotalValue, Format(DateRecive,'DD/MM/YYYY') AS DateRecive, OrderOk, OrderClosed, Remark
                        FROM TBLOrderCertificates", ofd.FileName);
                        PBCImport.Properties.Maximum += SRCTBLOrderCertificates.Rows.Count;
                        break;
                    default:
                        break;
                }
            }
            foreach (object item in Tablez)// Start Updating
            {
                switch ((string)item)
                {
                    case "mbImportTBLTrainee":
                        if (ImportTBLTrainee())
                            MyCL.ShowMsg("تم استقبال بيانات المتدربين", false, this);
                        else
                            MyCL.ShowMsg("لم يتم استقبال بيانات المتدربين", true, this);
                        break;

                    case "mbImportTBLWebReservation":
                        if (ImportTBLWebReservation())
                            MyCL.ShowMsg("تم استقبال بيانات حجز الدورات", false, this);
                        else
                            MyCL.ShowMsg("لم يتم استقبال بيانات حجز الدورات", true, this);
                        break;
                    case "mbTBLTrainersCoursesOut":
                        if (ImportTBLTrainersCoursesOut())
                            MyCL.ShowMsg("تم استقبال بيانات طلب تسجيل دورة خارجية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم استقبال بيانات طلب تسجيل دورة خارجية", true, this);
                        break;
                    case "mbTBLTrainersTraineeOUT":
                        if (ImportTBLTrainersTraineeOUT())
                            MyCL.ShowMsg("تم استقبال بيانات حجز دورات خارجية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم استقبال بيانات حجز دورات خارجية", true, this);
                        break;
                    case "mbTBLOrderCertificates":
                        if (ImportTBLOrderCertificates())
                            MyCL.ShowMsg("تم استقبال بيانات طلب شهادات لدورات خارجية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم استقبال بيانات طلب شهادات لدورات خارجية", true, this);
                        break;
                    default:
                        break;
                }
            }
            xTabC.Enabled = true;
            PBCImport.Properties.Maximum = 1;
            PBCImport.EditValue = 0;
        }
        private void BtnUpdateExport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Access database (*.mdb)|*.mdb|All Files (*.*)|*.*", CheckFileExists = true, CheckPathExists = true };
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            AccessDBConStr = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"{0}\"", ofd.FileName);
            xTabC.Enabled = false;
            PBCImport.Properties.Maximum = 0;
            PBCExport.EditValue = 0;
            List<object> Tablez = CCBEExport.Properties.Items.GetCheckedValues();
            foreach (object item in Tablez)
            {
                switch ((string)item)// Get Progress bar max value
                {
                    case "CdBankAccount":
                        TrgCdBankAccount = MyCL.LoadDataTable(@"Select AccountID, AccountName, AccountNumber From CdBankAccount");
                        PBCExport.Properties.Maximum += TrgCdBankAccount.Rows.Count;
                        break;
                    case "CDCertificates":
                        TrgCDCertificates = MyCL.LoadDataTable(@"Select CertificateID, Certificate, CertificateFrom, CertificateValue From CDCertificates");
                        PBCExport.Properties.Maximum += TrgCDCertificates.Rows.Count;
                        break;
                    case "CDCourseType":
                        TrgCDCourseType = MyCL.LoadDataTable(@"Select CourseTypeID, CourseTypeName From CDCourseType");
                        PBCExport.Properties.Maximum += TrgCDCourseType.Rows.Count;
                        break;
                    case "CDjob":
                        TrgCDjob = MyCL.LoadDataTable(@"Select jobID, job From CDjob");
                        PBCExport.Properties.Maximum += TrgCDjob.Rows.Count;
                        break;
                    case "CDknow":
                        TrgCDknow = MyCL.LoadDataTable(@"Select knowID, know From CDknow");
                        PBCExport.Properties.Maximum += TrgCDknow.Rows.Count;
                        break;
                    case "CdPlace":
                        TrgCdPlace = MyCL.LoadDataTable(@"Select PlaceID, PlaceName From CdPlace");
                        PBCExport.Properties.Maximum += TrgCdPlace.Rows.Count;
                        break;
                    case "CdLab":
                        TrgCdLab = MyCL.LoadDataTable(@"Select LabId, LabName, LabDes From CdLab");
                        PBCExport.Properties.Maximum += TrgCdLab.Rows.Count;
                        break;
                    case "CDMembershipType":
                        TrgCDMembershipType = MyCL.LoadDataTable(@"Select MembershipTypeID, MembershipType From CDMembershipType");
                        PBCExport.Properties.Maximum += TrgCDMembershipType.Rows.Count;
                        break;
                    case "CdNationality":
                        TrgCdNationality = MyCL.LoadDataTable(@"Select NationalityId, Nationality From CdNationality");
                        PBCExport.Properties.Maximum += TrgCdNationality.Rows.Count;
                        break;
                    case "CDReservationWay":
                        TrgCDReservationWay = MyCL.LoadDataTable(@"Select ReservationWayID, ReservationWay From CDReservationWay");
                        PBCExport.Properties.Maximum += TrgCDReservationWay.Rows.Count;
                        break;
                    case "CDTrainingBag":
                        TrgCDTrainingBag = MyCL.LoadDataTable(@"Select TrainingBagId, CourseTypeID, TrainingBag, rem From CDTrainingBag");
                        PBCExport.Properties.Maximum += TrgCDTrainingBag.Rows.Count;
                        break;
                    case "TBLPartners":
                        TrgTBLPartners = MyCL.LoadDataTable(@"Select PartnerID, Partner, PartnersAddres, Partnerphone, Partnermobile, Partnerfax, Partneremail, PartnerPerson From TBLPartners");
                        PBCExport.Properties.Maximum += TrgTBLPartners.Rows.Count;
                        break;
                    case "TBLCourses":
                        TrgTBLCourses = MyCL.LoadDataTable(@"SELECT CourseId, CourseTypeID, CourseName, CoursePlace, Convert(nvarchar, StartDate, 103) AS StartDate,Convert(nvarchar, EndDate, 103) AS EndDate, 
                        Price, WithExam, ExamMax, ExamMin, ApologyAllow, rem, LabId, EvalAllow, ShowOnline FROM TBLCourses");
                        PBCExport.Properties.Maximum += TrgTBLCourses.Rows.Count;
                        break;
                    case "TBLCourseCertificates":
                        TrgTBLCourseCertificates = MyCL.LoadDataTable(@"Select CourseId, CertificateID From TBLCourseCertificates");
                        PBCExport.Properties.Maximum += TrgTBLCourseCertificates.Rows.Count;
                        break;
                    case "TBLCourseAgenda":
                        TrgTBLCourseAgenda = MyCL.LoadDataTable(@"Select CourseId, Convert(nvarchar, ADate, 103) AS ADate, Convert(nvarchar, TimeFrom, 108) AS TimeFrom, 
                        Convert(nvarchar, TimeTo, 108) AS TimeTo, subject From TBLCourseAgenda");
                        PBCExport.Properties.Maximum += TrgTBLCourseAgenda.Rows.Count;
                        break;
                    case "TBLCourseTrainers":
                        TrgTBLCourseTrainers = MyCL.LoadDataTable(@"Select CourseId, TrainerID From TBLCourseTrainers");
                        PBCExport.Properties.Maximum += TrgTBLCourseTrainers.Rows.Count;
                        break;
                    case "TBLTrainers":
                        TrgTBLTrainers = MyCL.LoadDataTable(@"SELECT TrainerID, TrainerName, NameInEnglish, GenderID, NationalityId, Mobile, Email, City, Address, jobID, 
                        OtherJob, CertificateAddress, REM, MembershipTypeID, MembershipNo, UserName, password, image FROM TBLTrainers");
                        PBCExport.Properties.Maximum += TrgTBLTrainers.Rows.Count;
                        break;
                    case "TBLTrainersBag":
                        TrgTBLTrainersBag = MyCL.LoadDataTable(@"SELECT TrainerID, TrainingBagId, Convert(nvarchar, DateAdoption, 103) AS DateAdoption, AdoptionValue, 
                        Adoption, AdoptionRemark, AdoptionNo, ID FROM TBLTrainersBag");
                        PBCExport.Properties.Maximum += TrgTBLTrainersBag.Rows.Count;
                        break;
                    case "TBLAttend":
                        TrgTBLAttend = MyCL.LoadDataTable(@"Select TraineeID, CourseId, Convert(nvarchar, ADate, 103) AS ADate From TBLAttend");
                        PBCExport.Properties.Maximum += TrgTBLAttend.Rows.Count;
                        break;
                    case "TBLReservation":
                        TrgTBLReservation = MyCL.LoadDataTable(@"SELECT ReservationID, TraineeID, CourseId, ReservationWayID, Convert(nvarchar, TransferDate, 103) AS TransferDate, 
                        TransferValue, AccountID, esalno FROM TBLReservation");
                        PBCExport.Properties.Maximum += TrgTBLReservation.Rows.Count;
                        break;
                    case "TBLTraineeCertificates":
                        TrgTBLTraineeCertificates = MyCL.LoadDataTable(@"SELECT TraineeID, CourseId, CertificateID, CertificateValue, CONVERT(nvarchar, ReceiptDate, 103) AS ReceiptDate, 
                        UniqueNo, ID FROM TBLTraineeCertificates");
                        PBCExport.Properties.Maximum += TrgTBLTraineeCertificates.Rows.Count;
                        break;
                    case "TBLMemberShip":
                        TrgTBLMemberShip = MyCL.LoadDataTable(@"SELECT ID, TrainerID, Convert(nvarchar, MembershipFrom, 103) AS MembershipFrom, 
                        Convert(nvarchar, MembershipTo, 103) AS MembershipTo, MembershipValue FROM TBLMemberShip");
                        PBCExport.Properties.Maximum += TrgTBLMemberShip.Rows.Count;
                        break;
                    default:
                        break;
                }
            }

            foreach (object item in Tablez)
            {
                switch ((string)item)// Start Updating
                {
                    case "CdBankAccount":
                        if (ExportCdBankAccount())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد حسابات البنك", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد حسابات البنك", true, this);
                        break;
                    case "CDCertificates":
                        if (ExportCDCertificates())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد انواع الشهادات", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد انواع الشهادات", true, this);
                        break;
                    case "CDCourseType":
                        if (ExportCDCourseType())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد فئات الدورات", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد فئات الدورات", true, this);
                        break;
                    case "CDjob":
                        if (ExportCDjob())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد الوظائف", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد الوظائف", true, this);
                        break;
                    case "CDknow":
                        if (ExportCDknow())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد طرق التعرف على الاكاديمية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد طرق التعرف على الاكاديمية", true, this);
                        break;
                    case "CdPlace":
                        if (ExportCdPlace())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد اماكن التدريب", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد اماكن التدريب", true, this);
                        break;
                    case "CdLab":
                        if (ExportCdLab())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد القاعات التدريبية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد القاعات التدريبية", true, this);
                        break;
                    case "CDMembershipType":
                        if (ExportCDMembershipType())
                            MyCL.ShowMsg("تم ارسال بيانات نوع العضوية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات نوع العضوية", true, this);
                        break;
                    case "CdNationality":
                        if (ExportCdNationality())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد الجنسيات", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد الجنسيات", true, this);
                        break;
                    case "CDReservationWay":
                        if (ExportCDReservationWay())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد طرق الحجز", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد طرق الحجز", true, this);
                        break;
                    case "CDTrainingBag":
                        if (ExportCDTrainingBag())
                            MyCL.ShowMsg("تم ارسال بيانات اكواد الحقائب التدريبية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات اكواد الحقائب التدريبية", true, this);
                        break;
                    case "TBLPartners":
                        if (ExportTBLPartners())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات الموردين", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات الموردين", true, this);
                        break;
                    case "TBLCourses":
                        if (ExportTBLCourses())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات الدورات التدريبية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات الدورات التدريبية", true, this);
                        break;
                    case "TBLCourseCertificates":
                        if (ExportTBLCourseCertificates())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات شهادات الدورات", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات شهادات الدورات", true, this);
                        break;
                    case "TBLCourseAgenda":
                        if (ExportTBLCourseAgenda())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات شهادات الدورات", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات شهادات الدورات", true, this);
                        break;
                    case "TBLCourseTrainers":
                        if (ExportTBLCourseTrainers())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات مدربي الدورات", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات مدربي الدورات", true, this);
                        break;
                    case "TBLTrainers":
                        if (ExportTBLTrainers())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات المدربين", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات المدربين", true, this);
                        break;
                    case "TBLTrainersBag":
                        if (ExportTBLTrainersBag())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات حقائب المدربين", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات حقائب المدربين", true, this);
                        break;
                    case "TBLAttend":
                        if (ExportTBLAttend())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات الحضور", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات الحضور", true, this);
                        break;
                    case "TBLReservation":
                        if (ExportTBLReservation())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات حجز الدورات", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات حجز الدورات", true, this);
                        break;
                    case "TBLTraineeCertificates":
                        if (ExportTBLTraineeCertificates())
                            MyCL.ShowMsg("تم ارسال بيانات بيانات شهادات المتدربين", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات بيانات شهادات المتدربين", true, this);
                        break;
                    case "TBLMemberShip":
                        if (ExportTBLMemberShip())
                            MyCL.ShowMsg("تم ارسال بيانات العضوية", false, this);
                        else
                            MyCL.ShowMsg("لم يتم ارسال بيانات العضوية", true, this);
                        break;
                    default:
                        break;
                }
            }
            
            xTabC.Enabled = true;
            PBCExport.Properties.Maximum = 1;
            PBCExport.EditValue = 0;
        }
        #endregion
    }
}