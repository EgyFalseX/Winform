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
    public partial class EMP_TAMEENFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public EMP_TAMEENFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            //TBL_Emp
            repositoryItemGridLookUpEditEmpID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name FROM TBL_Emp");
            repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
            repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
            
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, visit_date, doctor, report, userin, datein, 
            EmpID AS EmpID_SRC, visit_date AS visit_date_SRC FROM EMP_TAMEEN");
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
            LoadDefaultData();
            LoadGrid();
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

            string visit_date;
            if (row["visit_date"].ToString() == string.Empty)
                visit_date = "NULL";
            else
                visit_date = string.Format("Convert(datetime, '{0}', 103)", SqlDB.ConvertToDateDMY(row["visit_date"].ToString()));

            try
            {
                if (row["EmpID_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO EMP_TAMEEN (EmpID, visit_date, doctor, report, userin, datein)
                    VALUES ({0}, {1}, N'{2}', N'{3}', {4}, GETDATE())", EmpID, visit_date, row["doctor"], row["report"], SqlDB.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE EMP_TAMEEN SET EmpID = {0}, visit_date = {1}, doctor = N'{2}', report = N'{3}', userin = {4}, datein = GETDATE()
                    WHERE (EmpID = {5}) AND (visit_date = Convert(datetime, '{6}', 103))", EmpID, visit_date, row["doctor"], row["report"], SqlDB.UserInfo.UserID, row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["visit_date_SRC"].ToString()));
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
                cmd.CommandText = string.Format(@"Delete From EMP_TAMEEN Where EmpID = {0} And visit_date = Convert(datetime, '{1}', 103)",
                row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["visit_date_SRC"].ToString()));
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