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
    public partial class stu_eyabFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public stu_eyabFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditstu_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS Stu_Name FROM stu.TBLstudent");
            repositoryItemGridLookUpEditstu_code.DisplayMember = "Stu_Name";
            repositoryItemGridLookUpEditstu_code.ValueMember = "stu_code";

            repositoryItemGridLookUpEditeyab_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT eyab_code, eyab_Name, eyab_Name_e FROM  cdEyab_code");
            repositoryItemGridLookUpEditeyab_code.DisplayMember = "eyab_Name";
            repositoryItemGridLookUpEditeyab_code.ValueMember = "eyab_code";

            repositoryItemGridLookUpEditasase_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year FROM CD_asase");
            repositoryItemGridLookUpEditasase_code.DisplayMember = "asase_year";
            repositoryItemGridLookUpEditasase_code.ValueMember = "asase_code";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, eyab_date, asase_code, eyab_code, remarks, datein, userin,
            stu_code AS stu_code_SRC, eyab_date AS eyab_date_SRC, eyab_code AS eyab_code_SRC FROM stu.stu_eyab Where asase_code = " + FXFW.SqlDB.asase_code);
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
        private void stu_eyabFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewstu_eyab.GetFocusedDataRow();
            string stu_code;
            if (row["stu_code"].ToString() == string.Empty)
                stu_code = "NULL";
            else
                stu_code = row["stu_code"].ToString();
            string eyab_code;
            if (row["eyab_code"].ToString() == string.Empty)
                eyab_code = "NULL";
            else
                eyab_code = row["eyab_code"].ToString();
            string eyab_date;
            if (row["eyab_date"].ToString() == string.Empty)
                eyab_date = "NULL";
            else
                eyab_date = String.Format("Convert(Datetime, '{0}', 103)", FXFW.SqlDB.ConvertToDateDMY(row["eyab_date"].ToString()));

            string asase_code;
            if (FXFW.SqlDB.asase_code == string.Empty)
                asase_code = "NULL";
            else
                asase_code = FXFW.SqlDB.asase_code;
            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"Insert Into stu.stu_eyab (stu_code, eyab_code, eyab_date, asase_code, remarks, datein, userin) VALUES 
                    ({0}, {1}, {2}, {3}, N'{4}', GETDATE(), {5})", stu_code, eyab_code, eyab_date, asase_code, row["remarks"], FXFW.SqlDB.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE stu.stu_eyab SET stu_code ={0}, eyab_code ={1}, eyab_date ={2}, asase_code ={3}, remarks =N'{4}', datein =GETDATE(), userin ={5}
                    WHERE (stu_code = {6}) AND (eyab_code = {7}) AND (eyab_date = Convert(Datetime, '{8}', 103))", stu_code, eyab_code, eyab_date, asase_code, row["remarks"],
                    FXFW.SqlDB.UserInfo.UserID, row["stu_code_SRC"], row["eyab_code_SRC"], FXFW.SqlDB.ConvertToDateDMY(row["eyab_date_SRC"].ToString()));
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
            DataRow row = gridViewstu_eyab.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From stu.stu_eyab Where stu_code ={0} And eyab_code ={1} And eyab_date =Convert(Datetime, '{2}', 103)",
                row["stu_code_SRC"], row["eyab_code_SRC"], FXFW.SqlDB.ConvertToDateDMY(row["eyab_date_SRC"].ToString()));
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
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageAdd)
            {
                LoadGrid();
                return;
            }
            else
            {
                gridControlSearch.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, asase_code, (Select  FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME From stu.TBLstudent Where stu_code = stu.student_t.stu_code) AS Stu_Name,
            (Select alsofof_name From CDAlsofof Where alsofof_code = stu.student_t.alsofof_code) AS saf,
            (Select fasl_name From CDEFasl Where fasl_code = stu.student_t.fasl_code) AS fasl, 'False' AS checkme
            FROM stu.student_t WHERE asase_code = " + FXFW.SqlDB.asase_code);
            }
        }
        private void toolStripMenuItemSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewSearch.RowCount; i++)
            {
                DataRowView row = (DataRowView)gridViewSearch.GetRow(gridViewSearch.GetVisibleRowHandle(i));
                row["checkme"] = true;
            }
            
        }

        private void btnAddSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                foreach (DataRow row in ((DataTable)gridControlSearch.DataSource).Rows)
                {
                    if (row["checkme"].ToString().ToLower() == "false")
                        continue;
                    cmd.CommandText = string.Format(@"Insert Into stu.stu_eyab (stu_code, eyab_code, eyab_date, asase_code, remarks, datein, userin) VALUES 
                    ({0}, 1, GETDATE(), {1}, NULL, GETDATE(), {2})", row["stu_code"], row["asase_code"], FXFW.SqlDB.UserInfo.UserID);
                    cmd.ExecuteNonQuery();
                }
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();

        }

#endregion

        
       
    }
}