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
    public partial class TBL_MonthlyFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBL_MonthlyFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CDMonth:
                    repositoryItemGridLookUpEditmonth_code.DataSource = SqlDB.LoadDataTable(@"SELECT month_code, month_name, month_name_e FROM CDMonth");
                    repositoryItemGridLookUpEditmonth_code.DisplayMember = "month_name";
                    repositoryItemGridLookUpEditmonth_code.ValueMember = "month_code";
                    break;
                case CodeFrm.TableNames.All:
                    //CDMonth
                    repositoryItemGridLookUpEditmonth_code.DataSource = SqlDB.LoadDataTable(@"SELECT month_code, month_name, month_name_e FROM CDMonth");
                    repositoryItemGridLookUpEditmonth_code.DisplayMember = "month_name";
                    repositoryItemGridLookUpEditmonth_code.ValueMember = "month_code";
                    //TBL_Emp
                    repositoryItemGridLookUpEditEmpID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, 
                    Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT AsaseSalaryId, month_code, EmpID, 
            BandEsthkak1, BandEsthkak2, BandEsthkak3, BandEsthkak4, BandEsthkak5, BandEsthkak6, BandEsthkak7, BandEsthkak8,  BandEsthkak9, BandEsthkak10, 
            AsaseSalaryId AS org_AsaseSalaryId, month_code AS org_month_code, EmpID AS org_EmpID FROM TBL_Monthly Where AsaseSalaryId = " + FXFW.SqlDB.asase_code);
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
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditmonth_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDMonth);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDMonth);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = row["EmpID"] });
            cmd.Parameters.Add(new SqlParameter("@AsaseSalaryId", SqlDbType.Int) { Value = FXFW.SqlDB.asase_code });
            cmd.Parameters.Add(new SqlParameter("@month_code", SqlDbType.TinyInt) { Value = row["month_code"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak1", SqlDbType.Float) { Value = row["BandEsthkak1"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak2", SqlDbType.Float) { Value = row["BandEsthkak2"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak3", SqlDbType.Float) { Value = row["BandEsthkak3"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak4", SqlDbType.Float) { Value = row["BandEsthkak4"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak5", SqlDbType.Float) { Value = row["BandEsthkak5"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak6", SqlDbType.Float) { Value = row["BandEsthkak6"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak7", SqlDbType.Float) { Value = row["BandEsthkak7"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak8", SqlDbType.Float) { Value = row["BandEsthkak8"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak9", SqlDbType.Float) { Value = row["BandEsthkak9"] });
            cmd.Parameters.Add(new SqlParameter("@BandEsthkak10", SqlDbType.Float) { Value = row["BandEsthkak10"] });
            
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
                    cmd.CommandText = @"INSERT INTO TBL_Monthly (EmpID, AsaseSalaryId, month_code, BandEsthkak1, BandEsthkak2, BandEsthkak3, BandEsthkak4, BandEsthkak5, BandEsthkak6, BandEsthkak7, BandEsthkak8, BandEsthkak9, BandEsthkak10) 
                    VALUES (@EmpID, @AsaseSalaryId, @month_code, @BandEsthkak1, @BandEsthkak2, @BandEsthkak3, @BandEsthkak4, @BandEsthkak5, @BandEsthkak6, @BandEsthkak7, @BandEsthkak8, @BandEsthkak9, @BandEsthkak10)";
                }
                else
                {
                    cmd.CommandText = @"UPDATE TBL_Monthly SET EmpID = @EmpID, AsaseSalaryId = @AsaseSalaryId, month_code = @month_code, BandEsthkak1 = @BandEsthkak1, BandEsthkak2 = @BandEsthkak2, BandEsthkak3 = @BandEsthkak3, BandEsthkak4 = @BandEsthkak4, 
                    BandEsthkak5 = @BandEsthkak5, BandEsthkak6 = @BandEsthkak6, BandEsthkak7 = @BandEsthkak7, BandEsthkak8 = @BandEsthkak8, BandEsthkak9 = @BandEsthkak9, BandEsthkak10 = @BandEsthkak10
                    WHERE (EmpID = @org_EmpID) AND (AsaseSalaryId = @org_AsaseSalaryId) AND (month_code = @org_month_code)";
                    cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = row["org_EmpID"] });
                    cmd.Parameters.Add(new SqlParameter("@org_AsaseSalaryId", SqlDbType.Int) { Value = row["org_AsaseSalaryId"] });
                    cmd.Parameters.Add(new SqlParameter("@org_month_code", SqlDbType.TinyInt) { Value = row["org_month_code"] });
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
                cmd.CommandText = @"Delete From TBL_Monthly WHERE (EmpID = @org_EmpID) AND (AsaseSalaryId = @org_AsaseSalaryId) AND (month_code = @org_month_code)";
                cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = row["org_EmpID"] });
                cmd.Parameters.Add(new SqlParameter("@org_AsaseSalaryId", SqlDbType.Int) { Value = row["org_AsaseSalaryId"] });
                cmd.Parameters.Add(new SqlParameter("@org_month_code", SqlDbType.TinyInt) { Value = row["org_month_code"] });
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