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

namespace SchoolWeeklyPeriods
{
    public partial class TBLTeacherNoDaysFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLTeacherNoDaysFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CDDayname:
                    repositoryItemGridLookUpEditdaycode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    LUEDays.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    LUEDays.Properties.DisplayMember = "dayname";
                    LUEDays.Properties.ValueMember = "daycode";
                    break;
                case CodeFrm.TableNames.CDAlhasas:
                    repositoryItemGridLookUpEdithasa_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e FROM CDAlhasas");
                    break;
                case CodeFrm.TableNames.All:
                    repositoryItemGridLookUpEditdaycode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    repositoryItemGridLookUpEdithasa_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e FROM CDAlhasas");
                    LUEDays.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e FROM CDDayname");
                    LUEDays.Properties.DisplayMember = "dayname";
                    LUEDays.Properties.ValueMember = "daycode";

                    repositoryItemGridLookUpEditEmpID.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
                    ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') AS emp_name
                    FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "emp_name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
                    LUEEmp.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
                    ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') AS emp_name
                    FROM TBL_Emp");
                    LUEEmp.Properties.DisplayMember = "emp_name";
                    LUEEmp.Properties.ValueMember = "EmpID";
                    
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, daycode, hasa_code,
            EmpID AS org_EmpID, daycode AS org_daycode, hasa_code AS org_hasa_code FROM TBLTeacherNoDays");
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
            SqlDB.GetFormPriv("Time" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
        private void repositoryItemGridLookUpEditdaycode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDDayname);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDDayname);
        }
        private void repositoryItemGridLookUpEdithasa_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAlhasas);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDAlhasas);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SqlDB.IsNullOrEmpty(LUEEmp.EditValue) || SqlDB.IsNullOrEmpty(LUEDays.EditValue))
            {
                Program.ShowMsg("من فضلك اختر مدرس و يوم", true, this);
                Program.Logger.LogThis("من فضلك اختر مدرس و يوم", Text, FXFW.Logger.OpType.warning, null, null, this);
                return;
            }
            DataTable dt = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code FROM CDAlhasas");
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = LUEEmp.EditValue });
            cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = LUEDays.EditValue });
            cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int));
            cmd.CommandText = @"INSERT INTO TBLTeacherNoDays (EmpID, daycode, hasa_code) VALUES (@EmpID, @daycode, @hasa_code)";
            try
            {
                con.Open();
                foreach (DataRow item in dt.Rows)
                {
                    cmd.Parameters["@hasa_code"].Value = item["hasa_code"].ToString();
                    try { cmd.ExecuteNonQuery(); } catch  { }
                }
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow rowgridViewTBLTeacherNoDays = gridViewData.GetFocusedDataRow();
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["EmpID"] });
            cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["daycode"] });
            cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["hasa_code"] });

            try
            {
                if (rowgridViewTBLTeacherNoDays["org_EmpID"].ToString() == string.Empty)
                    cmd.CommandText = @"INSERT INTO TBLTeacherNoDays (EmpID, daycode, hasa_code) VALUES (@EmpID, @daycode, @hasa_code)";
                else
                {
                    cmd.CommandText = @"UPDATE TBLTeacherNoDays SET EmpID = @EmpID, daycode = @daycode, hasa_code = @hasa_code 
                    WHERE (EmpID = @org_EmpID) AND (daycode = @org_daycode) AND (hasa_code = @org_hasa_code)";
                    cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_EmpID"] });
                    cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_daycode"] });
                    cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_hasa_code"] });
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
            con.Close();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow rowgridViewTBLTeacherNoDays = gridViewData.GetFocusedDataRow();
            if (rowgridViewTBLTeacherNoDays["org_EmpID"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"DELETE FROM TBLTeacherNoDays WHERE (EmpID = @org_EmpID) AND (daycode = @org_daycode) AND (hasa_code = @org_hasa_code)";
                cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_EmpID"] });
                cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_daycode"] });
                cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_hasa_code"] });
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