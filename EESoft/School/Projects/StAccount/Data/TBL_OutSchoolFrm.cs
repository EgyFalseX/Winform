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

namespace StAccount
{
    public partial class TBL_OutSchoolFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBL_OutSchoolFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemSearchLookUpEditstu_code.DataSource = SqlDB.LoadDataTable(@"SELECT stu_code,
            (SELECT FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME FROM stu.TBLstudent WHERE stu_code = stu.student_t.stu_code) AS stu_name,
            (SELECT alsofof_name FROM CDAlsofof WHERE alsofof_code = stu.student_t.alsofof_code) AS alsofof_name,
            (SELECT fasl_name FROM CDEFasl WHERE fasl_code = stu.student_t.fasl_code) AS fasl_name
             FROM stu.student_t Where asase_code = " + FXFW.SqlDB.asase_code);
            repositoryItemSearchLookUpEditstu_code.DisplayMember = "stu_name";
            repositoryItemSearchLookUpEditstu_code.ValueMember = "stu_code";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT stu_code, asase_code, Sremark,
            (SELECT alsofof_name FROM CDAlsofof WHERE alsofof_code = (SELECT alsofof_code FROM stu.student_t WHERE stu_code = TBL_OutSchool.stu_code AND asase_code = TBL_OutSchool.asase_code)) AS alsofof_name,
            (SELECT fasl_name FROM CDEFasl WHERE fasl_code = (SELECT fasl_code FROM stu.student_t WHERE stu_code = TBL_OutSchool.stu_code AND asase_code = TBL_OutSchool.asase_code)) AS fasl_name,
            (Select asase_year From CD_AsaseACC Where asase_code = TBL_OutSchool.asase_code) AS asase_year,
            stu_code AS stu_code_SRC, asase_code AS asase_code_SRC
            FROM TBL_OutSchool
            WHERE asase_code = " + FXFW.SqlDB.asase_code);
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
            SqlDB.GetFormPriv(Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            DataRow row = advBandedGridViewData.GetFocusedDataRow();
            if (row["stu_code"].ToString() == string.Empty)
            {
                Program.ShowMsg("يجب ادخال الطالب", true, this);
                Program.Logger.LogThis("يجب ادخال الطالب", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = "INSERT INTO TBL_OutSchool (asase_code, stu_code, Sremark) VALUES (@asase_code, @stu_code, @Sremark)";
                    cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.Int) { Value = FXFW.SqlDB.asase_code });
                    cmd.Parameters.Add(new SqlParameter("@stu_code", SqlDbType.Int) { Value = row["stu_code"] });
                    cmd.Parameters.Add(new SqlParameter("@Sremark", SqlDbType.NVarChar) { Value = row["Sremark"] });
                }
                else
                {
                    cmd.CommandText = @"UPDATE TBL_OutSchool SET asase_code = @asase_code, stu_code = @stu_code, Sremark = @Sremark
                    WHERE asase_code = @asase_code_SRC AND stu_code = @stu_code_SRC";
                    cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.Int) { Value = FXFW.SqlDB.asase_code });
                    cmd.Parameters.Add(new SqlParameter("@stu_code", SqlDbType.Int) { Value = row["stu_code"] });
                    cmd.Parameters.Add(new SqlParameter("@Sremark", SqlDbType.NVarChar) { Value = row["Sremark"] });
                    
                    cmd.Parameters.Add(new SqlParameter("@asase_code_SRC", SqlDbType.Int) { Value = row["asase_code_SRC"] });
                    cmd.Parameters.Add(new SqlParameter("@stu_code_SRC", SqlDbType.Int) { Value = row["stu_code_SRC"] });
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
            DataRow row = advBandedGridViewData.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"Delete From TBL_OutSchool Where asase_code = @asase_code_SRC AND stu_code = @stu_code_SRC";
                cmd.Parameters.Add(new SqlParameter("@asase_code_SRC", SqlDbType.Int) { Value = row["asase_code_SRC"] });
                cmd.Parameters.Add(new SqlParameter("@stu_code_SRC", SqlDbType.Int) { Value = row["stu_code_SRC"] });
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