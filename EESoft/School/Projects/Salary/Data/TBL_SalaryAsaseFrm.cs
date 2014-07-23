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

namespace Salary
{
    public partial class TBL_SalaryAsaseFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBL_SalaryAsaseFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            //TBL_Emp
            repositoryItemGridLookUpEditEmpID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, 
            Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name FROM TBL_Emp");
            repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
            repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, AsaseSalaryId, AsaseSalary,
            EmpID AS org_EmpID, AsaseSalaryId AS org_AsaseSalaryId
            FROM TBL_SalaryAsase Where AsaseSalaryId = " + FXFW.SqlDB.asase_code);
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
            SqlDB.GetFormPriv("Salary" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            ActivePriv();
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = row["EmpID"] });
            cmd.Parameters.Add(new SqlParameter("@AsaseSalaryId", SqlDbType.Int) { Value = FXFW.SqlDB.asase_code });
            cmd.Parameters.Add(new SqlParameter("@AsaseSalary", SqlDbType.Float) { Value = row["AsaseSalary"] });
            
            foreach (SqlParameter item in cmd.Parameters)
            {
                if (FXFW.SqlDB.IsNullOrEmpty(item.Value))
                {
                    item.Value = DBNull.Value;
                }

            }
            try
            {
                if (row["org_EmpID"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO TBL_SalaryAsase (EmpID, AsaseSalaryId, AsaseSalary) VALUES (@EmpID, @AsaseSalaryId, @AsaseSalary)";
                }
                else
                {
                    cmd.CommandText = @"UPDATE TBL_SalaryAsase SET EmpID = @EmpID, AsaseSalaryId = @AsaseSalaryId, AsaseSalary = @AsaseSalary 
                    WHERE (EmpID = @org_EmpID) AND (AsaseSalaryId = @org_AsaseSalaryId)";
                    cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = row["org_EmpID"] });
                    cmd.Parameters.Add(new SqlParameter("@org_AsaseSalaryId", SqlDbType.Int) { Value = row["org_AsaseSalaryId"] });
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
            if (row["org_EmpID"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"Delete From TBL_SalaryAsase WHERE (EmpID = @org_EmpID) AND (AsaseSalaryId = @org_AsaseSalaryId)";
                cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = row["org_EmpID"] });
                cmd.Parameters.Add(new SqlParameter("@org_AsaseSalaryId", SqlDbType.Int) { Value = row["org_AsaseSalaryId"] });
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