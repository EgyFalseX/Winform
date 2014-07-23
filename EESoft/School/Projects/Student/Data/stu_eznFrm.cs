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
    public partial class stu_eznFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public stu_eznFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditstu_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS Stu_Name FROM stu.TBLstudent");
            repositoryItemGridLookUpEditstu_code.DisplayMember = "Stu_Name";
            repositoryItemGridLookUpEditstu_code.ValueMember = "stu_code";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, ezn_date, asase_code, Convert(Datetime, ezn_time, 114) AS ezn_time, rezn, mostlem, mostlem_betaka, 
            (Select asase_year From CD_asase Where asase_code = stu.stu_ezn.asase_code) AS asase_year, stu_code AS stu_code_SRC, ezn_date AS ezn_date_SRC FROM stu.stu_ezn Where asase_code = " + FXFW.SqlDB.asase_code);
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
        private void stu_eznFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewstu_ezn.GetFocusedDataRow();
            string stu_code;
            if (row["stu_code"].ToString() == string.Empty)
                stu_code = "NULL";
            else
                stu_code = row["stu_code"].ToString();
            string ezn_date;
            if (row["ezn_date"].ToString() == string.Empty)
                ezn_date = "NULL";
            else
                ezn_date = String.Format("Convert(Datetime, '{0}', 103)", FXFW.SqlDB.ConvertToDateDMY(row["ezn_date"].ToString()));
            string ezn_time;
            if (row["ezn_time"].ToString() == string.Empty)
                ezn_time = "NULL";
            else
                ezn_time = string.Format(@"Convert(Datetime, '{0}', 114)", FXFW.SqlDB.ConvertToDateHMS(row["ezn_time"].ToString()));
            
            string asase_code;
            if (FXFW.SqlDB.asase_code == string.Empty)
                asase_code = "NULL";
            else
                asase_code = FXFW.SqlDB.asase_code;
            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO stu.stu_ezn (stu_code, ezn_date, asase_code, ezn_time, rezn, mostlem, mostlem_betaka) VALUES 
                    ({0}, {1}, {2}, {3}, N'{4}', N'{5}', N'{6}')", stu_code, ezn_date, asase_code, ezn_time, row["rezn"], row["mostlem"], row["mostlem_betaka"]);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE stu.stu_ezn SET stu_code = {0}, ezn_date = {1}, ezn_time = {2}, rezn = N'{3}', mostlem = N'{4}', mostlem_betaka = N'{5}'
                    Where stu_code = {6} And ezn_date = Convert(Datetime, '{7}', 103) And asase_code = {8}", stu_code, ezn_date, ezn_time, row["rezn"], row["mostlem"], row["mostlem_betaka"], 
                    row["stu_code_SRC"], FXFW.SqlDB.ConvertToDateDMY(row["ezn_date_SRC"].ToString()), row["asase_code"]);
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
            DataRow row = gridViewstu_ezn.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From stu.stu_ezn Where stu_code ={0} And ezn_date = Convert(Datetime, '{1}', 103) And asase_code ={2}",
                row["stu_code_SRC"], FXFW.SqlDB.ConvertToDateDMY(row["ezn_date_SRC"].ToString()), row["asase_code"]);
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