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
    public partial class TBLTeachersPlanFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLTeachersPlanFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CDAlsofof:
                    repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select alsofof_code, alsofof_name, alsofof_name_e FROM CDAlsofof");
                    break;
                case CodeFrm.TableNames.CDEFasl:
                    repositoryItemGridLookUpEditfasl_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e FROM CDEFasl");
                    break;
                case CodeFrm.TableNames.All:
                    repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select alsofof_code, alsofof_name, alsofof_name_e FROM CDAlsofof");
                    repositoryItemGridLookUpEditfasl_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e FROM CDEFasl");
                    
                    repositoryItemGridLookUpEditEmpID.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
                    ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') AS emp_name
                    FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "emp_name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";

                    repositoryItemGridLookUpEditSubjectId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e FROM CD_Subject");
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, EmpID, alsofof_code, fasl_code, SubjectId,
            (SELECT hesasno FROM CDSubjectWekly where alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId) AS hesasno,
            (SELECT ISNULL(COUNT(*), 0) FROM gdw.TBLTimeTable WHERE asase_code = gdw.TBLTeachersPlan.asase_code AND EmpID = gdw.TBLTeachersPlan.EmpID AND alsofof_code = gdw.TBLTeachersPlan.alsofof_code AND fasl_code = gdw.TBLTeachersPlan.fasl_code AND SubjectId = gdw.TBLTeachersPlan.SubjectId) AS HavePeriod,
            asase_code AS org_asase_code, EmpID AS org_EmpID, alsofof_code AS org_alsofof_code, fasl_code AS org_fasl_code, SubjectId AS org_SubjectId
            From gdw.TBLTeachersPlan");
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
        private void gridViewData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName != "HavePeriod")
                return;
            DataRow row = (DataRow)gridViewData.GetDataRow(e.RowHandle);
            if (row["HavePeriod"].ToString() == string.Empty || row["hesasno"].ToString() == string.Empty)
                return;
            if (Convert.ToInt64(row["HavePeriod"]) < Convert.ToInt64(row["hesasno"]))
            {
                e.Appearance.BackColor = Color.OrangeRed;
                e.Appearance.BackColor2 = Color.MistyRose;
            }
        }
        private void repositoryItemGridLookUpEditalsofof_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAlsofof);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDAlsofof);
        }
        private void repositoryItemGridLookUpEditfasl_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEFasl);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDEFasl);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow rowgridViewTBLTeacherNoDays = gridViewData.GetFocusedDataRow();
            cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = FXFW.SqlDB.asase_code });
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["EmpID"] });
            cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["alsofof_code"] });
            cmd.Parameters.Add(new SqlParameter("@fasl_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["fasl_code"] });
            cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = rowgridViewTBLTeacherNoDays["SubjectId"] });

            try
            {
                if (rowgridViewTBLTeacherNoDays["org_EmpID"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO gdw.TBLTeachersPlan (asase_code, EmpID, alsofof_code, fasl_code, SubjectId)
                    VALUES (@asase_code, @EmpID, @alsofof_code, @fasl_code, @SubjectId)";
                }
                else
                {
                    cmd.CommandText = @"UPDATE gdw.TBLTeachersPlan SET asase_code = @asase_code, EmpID = @EmpID, alsofof_code = @alsofof_code, fasl_code = @fasl_code, SubjectId = @SubjectId 
                    WHERE (asase_code = @org_asase_code) AND (EmpID = @org_EmpID) AND (alsofof_code = @org_alsofof_code) AND (fasl_code = @org_fasl_code) AND (SubjectId = @org_SubjectId)";
                    cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_asase_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_EmpID"] });
                    cmd.Parameters.Add(new SqlParameter("@org_alsofof_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_alsofof_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_fasl_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_fasl_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_SubjectId", SqlDbType.SmallInt) { Value = rowgridViewTBLTeacherNoDays["org_SubjectId"] });
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
            DataRow rowgridViewTBLTeacherNoDays = gridViewData.GetFocusedDataRow();
            if (rowgridViewTBLTeacherNoDays["org_EmpID"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"DELETE FROM gdw.TBLTeachersPlan 
                WHERE (asase_code = @org_asase_code) AND (EmpID = @org_EmpID) AND (alsofof_code = @org_alsofof_code) AND (fasl_code = @org_fasl_code) AND (SubjectId = @org_SubjectId)";
                cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_asase_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLTeacherNoDays["org_EmpID"] });
                cmd.Parameters.Add(new SqlParameter("@org_alsofof_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_alsofof_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_fasl_code", SqlDbType.TinyInt) { Value = rowgridViewTBLTeacherNoDays["org_fasl_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_SubjectId", SqlDbType.SmallInt) { Value = rowgridViewTBLTeacherNoDays["org_SubjectId"] });
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