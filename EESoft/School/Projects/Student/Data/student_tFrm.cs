using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Student
{
    public partial class student_tFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public student_tFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditstu_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS Stu_Name FROM stu.TBLstudent");
            repositoryItemGridLookUpEditstu_code.DisplayMember = "Stu_Name";
            repositoryItemGridLookUpEditstu_code.ValueMember = "stu_code";

            repositoryItemGridLookUpEditasase_year.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, SPOS FROM CD_Asase");
            repositoryItemGridLookUpEditasase_year.DisplayMember = "asase_year";
            repositoryItemGridLookUpEditasase_year.ValueMember = "asase_code";

            repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT alsofof_code, alsofof_name, marhala_code, alsofof_name_e FROM CDAlsofof");
            repositoryItemGridLookUpEditalsofof_code.DisplayMember = "alsofof_name";
            repositoryItemGridLookUpEditalsofof_code.ValueMember = "alsofof_code";

            repositoryItemGridLookUpEditfasl_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e FROM CDEFasl");
            repositoryItemGridLookUpEditfasl_code.DisplayMember = "fasl_name";
            repositoryItemGridLookUpEditfasl_code.ValueMember = "fasl_code";

        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, asase_code, alsofof_code, fasl_code, stu_code AS stu_code_SRC, 
            asase_code AS asase_code_SRC FROM stu.student_t Where asase_code = " + FXFW.SqlDB.asase_code);
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
            FXFW.SqlDB.GetFormPriv("Stu" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
#endregion
        #region - Event Handlers -
        
        private void student_tFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewstudent_t.GetFocusedDataRow();
            string stu_code;
            if (row["stu_code"].ToString() == string.Empty)
                stu_code = "NULL";
            else
                stu_code = row["stu_code"].ToString();
            string asase_code;
            if (FXFW.SqlDB.asase_code == string.Empty)
                asase_code = "NULL";
            else
                asase_code = FXFW.SqlDB.asase_code;
            string alsofof_code;
            if (row["alsofof_code"].ToString() == string.Empty)
                alsofof_code = "NULL";
            else
                alsofof_code = row["alsofof_code"].ToString();
            string fasl_code;
            if (row["fasl_code"].ToString() == string.Empty)
                fasl_code = "NULL";
            else
                fasl_code = row["fasl_code"].ToString();
            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"Insert Into stu.student_t (stu_code, asase_code, alsofof_code, fasl_code) VALUES ({0}, {1}, {2}, {3})", 
                    stu_code, asase_code, alsofof_code, fasl_code);
                }
                else
                {
                    cmd.CommandText = string.Format(@"Update stu.student_t Set stu_code = {0}, asase_code = {1}, alsofof_code = {2}, fasl_code = {3} 
                    Where stu_code = {4} AND asase_code = {5}", stu_code, asase_code, alsofof_code, fasl_code,
                    row["stu_code_SRC"], row["asase_code_SRC"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewstudent_t.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From stu.student_t Where stu_code = {0} AND asase_code = {1}", 
                row["stu_code_SRC"], row["asase_code_SRC"]);
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion

    }
}