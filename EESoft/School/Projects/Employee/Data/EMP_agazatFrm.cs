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

namespace Employee
{
    public partial class EMP_agazatFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public EMP_agazatFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CD_AgazaType:
                    repositoryItemGridLookUpEditagaza_type_code.DataSource = SqlDB.LoadDataTable(@"SELECT AgazaTypeId, AgazaTypeName, AgazaTypeName_e FROM CD_AgazaType");
                    repositoryItemGridLookUpEditagaza_type_code.DisplayMember = "AgazaTypeName";
                    repositoryItemGridLookUpEditagaza_type_code.ValueMember = "AgazaTypeId";
                    break;
                case CodeFrm.TableNames.All:
                    //CD_Specialization
                    repositoryItemGridLookUpEditagaza_type_code.DataSource = SqlDB.LoadDataTable(@"SELECT AgazaTypeId, AgazaTypeName, AgazaTypeName_e FROM CD_AgazaType");
                    repositoryItemGridLookUpEditagaza_type_code.DisplayMember = "AgazaTypeName";
                    repositoryItemGridLookUpEditagaza_type_code.ValueMember = "AgazaTypeId";
                    //TBL_Emp
                    repositoryItemGridLookUpEditEmpID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
                    break;
                default:
                    break;
            }
            
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, agaza_st_date, agaza_type_code, agaza_MEMEO, datein, userin, 
            EmpID AS EmpID_SRC, agaza_st_date AS agaza_st_date_SRC FROM EMP_agazat");
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
            SqlDB.GetFormPriv("Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditagaza_type_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_AgazaType);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_AgazaType);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            string EmpID;
            if (row["EmpID"].ToString() == string.Empty)
                EmpID = "NULL";
            else
                EmpID = row["EmpID"].ToString();

            string agaza_type_code;
            if (row["agaza_type_code"].ToString() == string.Empty)
                agaza_type_code = "NULL";
            else
                agaza_type_code = row["agaza_type_code"].ToString();

            string agaza_st_date;
            if (row["agaza_st_date"].ToString() == string.Empty)
                agaza_st_date = "NULL";
            else
                agaza_st_date = string.Format("Convert(datetime, '{0}', 103)", SqlDB.ConvertToDateDMY(row["agaza_st_date"].ToString()));

            string agaza_MEMEO;
            if (row["agaza_MEMEO"].ToString() == string.Empty)
                agaza_MEMEO = "NULL";
            else
                agaza_MEMEO = String.Format("N'{0}'", row["agaza_MEMEO"]);

            try
            {
                if (row["EmpID_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO EMP_agazat (EmpID, agaza_st_date, agaza_type_code, agaza_MEMEO, datein, userin)
                    VALUES ({0}, {1}, {2}, {3}, GETDATE(), {4})", EmpID, agaza_st_date, agaza_type_code, agaza_MEMEO, SqlDB.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE EMP_agazat SET EmpID = {0}, agaza_st_date = {1}, agaza_type_code = {2}, agaza_MEMEO = {3}, datein = GETDATE(), userin = {4}
                    WHERE (EmpID = {5}) AND (agaza_st_date = Convert(datetime, '{6}', 103))", EmpID, agaza_st_date, agaza_type_code, agaza_MEMEO, SqlDB.UserInfo.UserID, row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["agaza_st_date_SRC"].ToString()));
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
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["EmpID_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From EMP_agazat Where EmpID = {0} And agaza_st_date = Convert(datetime, '{1}', 103)",
                row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["agaza_st_date_SRC"].ToString()));
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