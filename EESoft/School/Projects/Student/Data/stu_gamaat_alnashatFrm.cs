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
    public partial class stu_gamaat_alnashatFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public stu_gamaat_alnashatFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditstu_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS Stu_Name FROM stu.TBLstudent");
            repositoryItemGridLookUpEditstu_code.DisplayMember = "Stu_Name";
            repositoryItemGridLookUpEditstu_code.ValueMember = "stu_code";

            repositoryItemGridLookUpEditcode_gamaat_alnashat.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT code_gamaat_alnashat, name_gamaat_alnashat, name_gamaat_alnashat_e FROM CDGamaat_alnashat");
            repositoryItemGridLookUpEditcode_gamaat_alnashat.DisplayMember = "name_gamaat_alnashat";
            repositoryItemGridLookUpEditcode_gamaat_alnashat.ValueMember = "code_gamaat_alnashat";

            repositoryItemGridLookUpEditasase_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year FROM CD_asase");
            repositoryItemGridLookUpEditasase_code.DisplayMember = "asase_year";
            repositoryItemGridLookUpEditasase_code.ValueMember = "asase_code";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, asase_code, code_gamaat_alnashat, dateRECORD, RREM,
            stu_code AS stu_code_SRC, asase_code AS asase_code_SRC, code_gamaat_alnashat AS code_gamaat_alnashat_SRC 
            FROM stu.stu_gamaat_alnashat Where asase_code = " + FXFW.SqlDB.asase_code);
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
        private void stu_gamaat_alnashatFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewstu_gamaat_alnashat.GetFocusedDataRow();
            string stu_code;
            if (row["stu_code"].ToString() == string.Empty)
                stu_code = "NULL";
            else
                stu_code = row["stu_code"].ToString();
            string code_gamaat_alnashat;
            if (row["code_gamaat_alnashat"].ToString() == string.Empty)
                code_gamaat_alnashat = "NULL";
            else
                code_gamaat_alnashat = row["code_gamaat_alnashat"].ToString();
            string asase_code;
            if (FXFW.SqlDB.asase_code == string.Empty)
                asase_code = "NULL";
            else
                asase_code = FXFW.SqlDB.asase_code;
            string dateRECORD;
            if (row["dateRECORD"].ToString() == string.Empty)
                dateRECORD = "NULL";
            else
                dateRECORD = string.Format(@"Convert(Datetime, '{0}', 103)", FXFW.SqlDB.ConvertToDateDMY(row["dateRECORD"].ToString()));
            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO stu.stu_gamaat_alnashat (stu_code, asase_code, code_gamaat_alnashat, dateRECORD, RREM)
                    VALUES ({0}, {1}, {2}, {3}, N'{4}')", stu_code, asase_code, code_gamaat_alnashat, dateRECORD, row["RREM"]);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE stu.stu_gamaat_alnashat SET stu_code = {0}, asase_code = {1}, code_gamaat_alnashat = {2}, dateRECORD = {3}, RREM = N'{4}'
                    Where stu_code = {5} And asase_code = {6} And code_gamaat_alnashat = {7}", stu_code, asase_code, code_gamaat_alnashat, dateRECORD, row["RREM"],
                    row["stu_code_SRC"], row["asase_code_SRC"], row["code_gamaat_alnashat_SRC"]);
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
            DataRow row = gridViewstu_gamaat_alnashat.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From stu.stu_gamaat_alnashat Where  stu_code = {0} And asase_code = {1} And code_gamaat_alnashat = {2}",
                row["stu_code_SRC"], row["asase_code_SRC"], row["code_gamaat_alnashat_SRC"]);
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