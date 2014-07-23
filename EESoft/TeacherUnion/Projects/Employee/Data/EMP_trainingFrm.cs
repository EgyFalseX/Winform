using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using FXFW;

namespace Employee
{
    public partial class EMP_trainingFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public EMP_trainingFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CD_Courses:
                    repositoryItemGridLookUpEditCourseId.DataSource = SqlDB.LoadDataTable(@"SELECT CourseId, CourseName, CourseName_e FROM CD_Courses");
                    repositoryItemGridLookUpEditCourseId.DisplayMember = "CourseName";
                    repositoryItemGridLookUpEditCourseId.ValueMember = "CourseId";
                    break;
                case CodeFrm.TableNames.CDPlaceTraining:
                    repositoryItemGridLookUpEditPlaceTrainingId.DataSource = SqlDB.LoadDataTable(@"SELECT PlaceTrainingId, PlaceTrainingName, PlaceTrainingName_e FROM CDPlaceTraining");
                    repositoryItemGridLookUpEditPlaceTrainingId.DisplayMember = "PlaceTrainingName";
                    repositoryItemGridLookUpEditPlaceTrainingId.ValueMember = "PlaceTrainingId";
                    break;
                case CodeFrm.TableNames.CDTakdeer:
                    repositoryItemGridLookUpEditTakdeerId.DataSource = SqlDB.LoadDataTable(@"SELECT TakdeerId, TakdeerName, TakdeerName_e FROM CDTakdeer");
                    repositoryItemGridLookUpEditTakdeerId.DisplayMember = "TakdeerName";
                    repositoryItemGridLookUpEditTakdeerId.ValueMember = "TakdeerId";
                    break;
                case CodeFrm.TableNames.All:
                    //CD_Courses
                    repositoryItemGridLookUpEditCourseId.DataSource = SqlDB.LoadDataTable(@"SELECT CourseId, CourseName, CourseName_e FROM CD_Courses");
                    repositoryItemGridLookUpEditCourseId.DisplayMember = "CourseName";
                    repositoryItemGridLookUpEditCourseId.ValueMember = "CourseId";
                    //CDPlaceTraining
                    repositoryItemGridLookUpEditPlaceTrainingId.DataSource = SqlDB.LoadDataTable(@"SELECT PlaceTrainingId, PlaceTrainingName, PlaceTrainingName_e FROM CDPlaceTraining");
                    repositoryItemGridLookUpEditPlaceTrainingId.DisplayMember = "PlaceTrainingName";
                    repositoryItemGridLookUpEditPlaceTrainingId.ValueMember = "PlaceTrainingId";
                    //CDTakdeer
                    repositoryItemGridLookUpEditTakdeerId.DataSource = SqlDB.LoadDataTable(@"SELECT TakdeerId, TakdeerName, TakdeerName_e FROM CDTakdeer");
                    repositoryItemGridLookUpEditTakdeerId.DisplayMember = "TakdeerName";
                    repositoryItemGridLookUpEditTakdeerId.ValueMember = "TakdeerId";
                    //TBL_Emp
                    repositoryItemGridLookUpEditEmpID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, prog_start_date, CourseId, TakdeerId, PlaceTrainingId, prog_end_date, userin, datein, 
            EmpID AS EmpID_SRC, prog_start_date AS prog_start_date_SRC, CourseId AS CourseId_SRC FROM EMP_training");
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData.DataSource).Rows.Add(((DataTable)gridControlData.DataSource).NewRow());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SqlDB.GetFormPriv("Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
#endregion
        #region - Event Handlers -
        private void stu_nashatFrm_Load(object sender, EventArgs e)
        {
            //ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditCourseId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Courses);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_Courses);
        }
        private void repositoryItemGridLookUpEditPlaceTrainingId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDPlaceTraining);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDPlaceTraining);
        }
        private void repositoryItemGridLookUpEditTakdeerId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDTakdeer);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDTakdeer);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            string EmpID;
            if (row["EmpID"].ToString() == string.Empty)
                EmpID = "NULL";
            else
                EmpID = row["EmpID"].ToString();

            string CourseId;
            if (row["CourseId"].ToString() == string.Empty)
                CourseId = "NULL";
            else
                CourseId = row["CourseId"].ToString();

            string prog_start_date;
            if (row["prog_start_date"].ToString() == string.Empty)
                prog_start_date = "NULL";
            else
                prog_start_date = string.Format("Convert(datetime, '{0}', 103)", SqlDB.ConvertToDateDMY(row["prog_start_date"].ToString()));

            string prog_end_date;
            if (row["prog_end_date"].ToString() == string.Empty)
                prog_end_date = "NULL";
            else
                prog_end_date = string.Format("Convert(datetime, '{0}', 103)", SqlDB.ConvertToDateDMY(row["prog_end_date"].ToString()));
            
            string PlaceTrainingId;
            if (row["PlaceTrainingId"].ToString() == string.Empty)
                PlaceTrainingId = "0";
            else
                PlaceTrainingId = row["PlaceTrainingId"].ToString();

            string TakdeerId;
            if (row["TakdeerId"].ToString() == string.Empty)
                TakdeerId = "NULL";
            else
                TakdeerId = row["TakdeerId"].ToString();

            try
            {
                if (row["EmpID_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO EMP_training (EmpID, prog_start_date, CourseId, TakdeerId, PlaceTrainingId, prog_end_date, userin, datein)
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, GETDATE())", EmpID, prog_start_date, CourseId, TakdeerId, PlaceTrainingId, prog_end_date, SqlDB.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE EMP_training SET EmpID = {0}, prog_start_date = {1}, CourseId = {2}, TakdeerId = {3}, PlaceTrainingId = {4}, prog_end_date = {5},
                    userin = {6}, datein = GETDATE() WHERE (EmpID = {7}) AND (prog_start_date = Convert(datetime, '{8}', 103)) AND (CourseId = {9})", EmpID, prog_start_date, CourseId, TakdeerId, PlaceTrainingId, prog_end_date, 
                    SqlDB.UserInfo.UserID, row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["prog_start_date_SRC"].ToString()), row["CourseId_SRC"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["EmpID_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From EMP_training Where EmpID = {0} And CourseId = {1} And prog_start_date = Convert(datetime, '{2}', 103)",
                row["EmpID_SRC"], row["CourseId_SRC"], SqlDB.ConvertToDateDMY(row["prog_start_date_SRC"].ToString()));
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion

    }
}