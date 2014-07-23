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
    public partial class TBLNesabFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLNesabFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditEmpID.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
            ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '')  AS emp_name
            FROM TBL_Emp");
            repositoryItemGridLookUpEditEmpID.DisplayMember = "emp_name";
            repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, EmpID, nesabfealy, nesabedafy, rem, 
            asase_code AS org_asase_code, EmpID AS org_EmpID FROM gdw.TBLNesab WHERE asase_code = " + FXFW.SqlDB.asase_code);
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
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow rowgridViewTBLNesab = gridViewData.GetFocusedDataRow();
            cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = FXFW.SqlDB.asase_code });
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = rowgridViewTBLNesab["EmpID"] });
            cmd.Parameters.Add(new SqlParameter("@nesabfealy", SqlDbType.TinyInt) { Value = rowgridViewTBLNesab["nesabfealy"] });
            cmd.Parameters.Add(new SqlParameter("@nesabedafy", SqlDbType.TinyInt) { Value = rowgridViewTBLNesab["nesabedafy"] });
            cmd.Parameters.Add(new SqlParameter("@rem", SqlDbType.NVarChar) { Value = rowgridViewTBLNesab["rem"] });

            try
            {
                if (rowgridViewTBLNesab["org_EmpID"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO gdw.TBLNesab (asase_code, EmpID, nesabfealy, nesabedafy, rem)
                    VALUES (@asase_code, @EmpID, @nesabfealy, @nesabedafy, @rem)";
                }
                else
                {
                    cmd.CommandText = @"UPDATE gdw.TBLNesab SET asase_code = @asase_code, EmpID = @EmpID, nesabfealy = @nesabfealy, nesabedafy = @nesabedafy, rem = @rem
                    WHERE asase_code = @org_asase_code AND EmpID = @org_EmpID";
                    cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = rowgridViewTBLNesab["org_asase_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLNesab["org_EmpID"] });
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
            DataRow rowgridViewTBLNesab = gridViewData.GetFocusedDataRow();
            if (rowgridViewTBLNesab["org_EmpID"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"DELETE FROM gdw.TBLNesab WHERE asase_code = @org_asase_code AND EmpID = @org_EmpID";
                cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.Int) { Value = rowgridViewTBLNesab["org_asase_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = rowgridViewTBLNesab["org_EmpID"] });
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