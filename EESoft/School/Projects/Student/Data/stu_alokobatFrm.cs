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
    public partial class stu_alokobatFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public stu_alokobatFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditstu_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS Stu_Name FROM stu.TBLstudent");
            repositoryItemGridLookUpEditstu_code.DisplayMember = "Stu_Name";
            repositoryItemGridLookUpEditstu_code.ValueMember = "stu_code";

            repositoryItemGridLookUpEditcode_alokobat.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT code_alokobat, name_alokobat, name_alokobat_e FROM CDAlokobat");
            repositoryItemGridLookUpEditcode_alokobat.DisplayMember = "name_alokobat";
            repositoryItemGridLookUpEditcode_alokobat.ValueMember = "code_alokobat";

            repositoryItemGridLookUpEditasase_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year FROM CD_asase");
            repositoryItemGridLookUpEditasase_code.DisplayMember = "asase_year";
            repositoryItemGridLookUpEditasase_code.ValueMember = "asase_code";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, code_alokobat, datea, asase_code, why, datein, 
            userin, stu_code AS stu_code_SRC, code_alokobat AS code_alokobat_SRC, datea AS datea_SRC FROM stu.stu_alokobat Where asase_code = " + FXFW.SqlDB.asase_code);
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
        private void stu_alokobatFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            string stu_code;
            if (row["stu_code"].ToString() == string.Empty)
                stu_code = "NULL";
            else
                stu_code = row["stu_code"].ToString();
            string code_alokobat;
            if (row["code_alokobat"].ToString() == string.Empty)
                code_alokobat = "NULL";
            else
                code_alokobat = row["code_alokobat"].ToString();
            string datea;
            if (row["datea"].ToString() == string.Empty)
                datea = "NULL";
            else
                datea = String.Format("Convert(Datetime, '{0}', 103)", FXFW.SqlDB.ConvertToDateDMY(row["datea"].ToString()));

            string asase_code;
            if (FXFW.SqlDB.asase_code == string.Empty)
                asase_code = "NULL";
            else
                asase_code = FXFW.SqlDB.asase_code;
            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"Insert Into stu.stu_alokobat (stu_code, code_alokobat, datea, asase_code, why, datein, userin) VALUES 
                    ({0}, {1}, {2}, {3}, N'{4}', GETDATE(), {5})", stu_code, code_alokobat, datea, asase_code, row["why"], FXFW.SqlDB.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE stu.stu_alokobat SET stu_code ={0}, code_alokobat ={1}, datea ={2}, asase_code ={3}, why =N'{4}', datein =GETDATE(), userin ={5}
                    WHERE (stu_code = {6}) AND (code_alokobat = {7}) AND (datea = Convert(Datetime, '{8}', 103))", stu_code, code_alokobat, datea, asase_code, row["why"],
                    FXFW.SqlDB.UserInfo.UserID, row["stu_code_SRC"], row["code_alokobat_SRC"], FXFW.SqlDB.ConvertToDateDMY(row["datea_SRC"].ToString()));
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
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From stu.stu_alokobat Where stu_code ={0} And code_alokobat ={1} And datea = Convert(Datetime, '{2}', 103)", 
                row["stu_code_SRC"], row["code_alokobat_SRC"], FXFW.SqlDB.ConvertToDateDMY(row["datea_SRC"].ToString()));
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