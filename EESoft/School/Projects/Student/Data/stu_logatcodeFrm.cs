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
    public partial class stu_logatcodeFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public stu_logatcodeFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            //CD_asase
            DataTable dtCD_asase = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year FROM CD_asase");
            LUEasase_code.Properties.DataSource = dtCD_asase;
            LUEasase_code.Properties.DisplayMember = "asase_year";
            LUEasase_code.Properties.ValueMember = "asase_code";
            repositoryItemGridLookUpEditasase_code.DataSource = dtCD_asase;
            repositoryItemGridLookUpEditasase_code.DisplayMember = "asase_year";
            repositoryItemGridLookUpEditasase_code.ValueMember = "asase_code";
            //CDAlsofof
            LUEalsofof_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT alsofof_code, alsofof_name, alsofof_name_e FROM CDAlsofof");
            LUEalsofof_code.Properties.DisplayMember = "alsofof_name";
            LUEalsofof_code.Properties.ValueMember = "alsofof_code";
            //CDLogatcode
            DataTable dtCDLogatcode = FXFW.SqlDB.LoadDataTable(@"SELECT loga_code, loga_name, loga_name_e FROM CDLogatcode");
            LUEloga_code1.Properties.DataSource = dtCDLogatcode;
            LUEloga_code1.Properties.DisplayMember = "loga_name";
            LUEloga_code1.Properties.ValueMember = "loga_code";
            LUEloga_code2.Properties.DataSource = dtCDLogatcode;
            LUEloga_code2.Properties.DisplayMember = "loga_name";
            LUEloga_code2.Properties.ValueMember = "loga_code";
            LUEloga_code3.Properties.DataSource = dtCDLogatcode;
            LUEloga_code3.Properties.DisplayMember = "loga_name";
            LUEloga_code3.Properties.ValueMember = "loga_code";
            repositoryItemGridLookUpEditloga_code.DataSource = dtCDLogatcode;
            repositoryItemGridLookUpEditloga_code.DisplayMember = "loga_name";
            repositoryItemGridLookUpEditloga_code.ValueMember = "loga_code";
            //TBLstudent
            repositoryItemGridLookUpEditstu_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS Stu_Name FROM stu.TBLstudent");
            repositoryItemGridLookUpEditstu_code.DisplayMember = "Stu_Name";
            repositoryItemGridLookUpEditstu_code.ValueMember = "stu_code";

        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, asase_code, loga_code1, loga_code2, loga_code3, 
            stu_code AS stu_code_SRC, asase_code AS asase_code_SRC,
            (Select alsofof_name From CDAlsofof Where alsofof_code = (Select alsofof_code From stu.student_t Where stu_code = stu.stu_logatcode.stu_code And asase_code = stu.stu_logatcode.asase_code)) AS alsofof_name 
            FROM stu.stu_logatcode Where asase_code = " + FXFW.SqlDB.asase_code);
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
        private void stu_logatcodeFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewstu_haletalked.GetFocusedDataRow();
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
            string loga_code1;
            if (row["loga_code1"].ToString() == string.Empty)
                loga_code1 = "NULL";
            else
                loga_code1 = row["loga_code1"].ToString();
            string loga_code2;
            if (row["loga_code2"].ToString() == string.Empty)
                loga_code2 = "NULL";
            else
                loga_code2 = row["loga_code2"].ToString();
            string loga_code3;
            if (row["loga_code3"].ToString() == string.Empty)
                loga_code3 = "NULL";
            else
                loga_code3 = row["loga_code3"].ToString();

            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO stu.stu_logatcode (stu_code, asase_code, loga_code1, loga_code2, loga_code3) VALUES ({0}, {1}, {2}, {3}, {4})",
                    stu_code, asase_code, loga_code1, loga_code2, loga_code3);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE stu.stu_logatcode SET stu_code = {0}, asase_code = {1}, loga_code1 = {2}, loga_code2 = {3}, 
                    loga_code3 = {4} WHERE (stu_code = {5}) AND (asase_code = {6})",
                    stu_code, asase_code, loga_code1, loga_code2, loga_code3, row["stu_code_SRC"], row["asase_code_SRC"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            LoadGrid();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewstu_haletalked.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From stu.stu_logatcode Where stu_code = {0} AND asase_code = {1}",
                row["stu_code_SRC"], row["asase_code_SRC"]);
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            LoadGrid();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LUEalsofof_code.EditValue == null || LUEasase_code.EditValue == null || LUEloga_code1.EditValue == null)
            {
                Program.ShowMsg("يجب اختيار صف و عام حتي يتم الحفظ", true, this);
                return;
            }
            DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT stu_code, asase_code, alsofof_code FROM stu.student_t WHERE (asase_code = {0}) AND (alsofof_code = {1})",
            LUEasase_code.EditValue, LUEalsofof_code.EditValue));
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            
            string loga_code1;
            if (LUEloga_code1.EditValue == null)
                loga_code1 = "NULL";
            else
                loga_code1 = LUEloga_code1.EditValue.ToString();
            string loga_code2;
            if (LUEloga_code2.EditValue == null)
                loga_code2 = "NULL";
            else
                loga_code2 = LUEloga_code2.EditValue.ToString();
            string loga_code3;
            if (LUEloga_code3.EditValue == null)
                loga_code3 = "NULL";
            else
                loga_code3 = LUEloga_code3.EditValue.ToString();
            try
            {
                con.Open();
                foreach (DataRow row in dt.Rows)
                {
                    cmd.CommandText = string.Format(@"if not exists(select * From stu.stu_logatcode Where stu_code = {0} And asase_code = {1}) 
                    INSERT INTO stu.stu_logatcode (stu_code, asase_code, loga_code1, loga_code2, loga_code3) VALUES ({0}, {1}, {2}, {3}, {4})",
                    row["stu_code"], LUEasase_code.EditValue, loga_code1, loga_code2, loga_code3);
                    cmd.ExecuteNonQuery();
                }
                Program.ShowMsg("تم الاضافه", false, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            LoadGrid();
        }
        #endregion
    
    }
}