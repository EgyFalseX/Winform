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
    public partial class EMP_eznFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public EMP_eznFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CD_EznType:
                    repositoryItemGridLookUpEditEznTypeId.DataSource = SqlDB.LoadDataTable(@"SELECT EznTypeId, EznType, EznType_e FROM CD_EznType");
                    repositoryItemGridLookUpEditEznTypeId.DisplayMember = "EznType";
                    repositoryItemGridLookUpEditEznTypeId.ValueMember = "EznTypeId";
                    break;
                case CodeFrm.TableNames.All:
                    //TBL_Emp
                    repositoryItemGridLookUpEditEmpID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
                    //CD_EznType
                    repositoryItemGridLookUpEditEznTypeId.DataSource = SqlDB.LoadDataTable(@"SELECT EznTypeId, EznType, EznType_e FROM CD_EznType");
                    repositoryItemGridLookUpEditEznTypeId.DisplayMember = "EznType";
                    repositoryItemGridLookUpEditEznTypeId.ValueMember = "EznTypeId";
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, ezn_date, Convert(Datetime, ezn_time_start, 114) AS ezn_time_start, Convert(Datetime, ezn_time_end, 114) AS ezn_time_end, EznTypeId, ezn_place, datein, userin, 
            EmpID AS EmpID_SRC, ezn_date AS ezn_date_SRC FROM EMP_ezn");
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
            SqlDB.GetFormPriv("Emp" + "Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
        
        private void repositoryItemGridLookUpEditEznTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EznType);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_EznType);
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

            string ezn_date;
            if (row["ezn_date"].ToString() == string.Empty)
                ezn_date = "NULL";
            else
                ezn_date = string.Format("Convert(datetime, '{0}', 103)", SqlDB.ConvertToDateDMY(row["ezn_date"].ToString()));

            string ezn_time_start;
            if (row["ezn_time_start"].ToString() == string.Empty)
                ezn_time_start = "NULL";
            else
                ezn_time_start = string.Format(@"Convert(Datetime, '{0}', 114)", SqlDB.ConvertToDateHMS(row["ezn_time_start"].ToString()));

            string ezn_time_end;
            if (row["ezn_time_end"].ToString() == string.Empty)
                ezn_time_end = "NULL";
            else
                ezn_time_end = string.Format(@"Convert(Datetime, '{0}', 114)", SqlDB.ConvertToDateHMS(row["ezn_time_end"].ToString()));

            string EznTypeId;
            if (row["EznTypeId"].ToString() == string.Empty)
                EznTypeId = "NULL";
            else
                EznTypeId = row["EznTypeId"].ToString();

            string ezn_place;
            if (row["ezn_place"].ToString() == string.Empty)
                ezn_place = "NULL";
            else
                ezn_place = String.Format("N'{0}'", row["ezn_place"]);

            try
            {
                if (row["EmpID_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO EMP_ezn (EmpID, ezn_date, ezn_time_start, ezn_time_end, EznTypeId, ezn_place, datein, userin)
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, GETDATE(), {6})", EmpID, ezn_date, ezn_time_start, ezn_time_end, EznTypeId, ezn_place, SqlDB.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE EMP_ezn SET EmpID = {0}, ezn_date = {1}, ezn_time_start = {2}, ezn_time_end = {3}, EznTypeId = {4}, ezn_place = {5}, datein = GETDATE(), userin = {6}
                    WHERE (EmpID = {7}) AND (ezn_date = Convert(datetime, '{8}', 103))", EmpID, ezn_date, ezn_time_start, ezn_time_end, EznTypeId, ezn_place, SqlDB.UserInfo.UserID, row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["ezn_date_SRC"].ToString()));
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
                cmd.CommandText = string.Format(@"Delete From EMP_ezn Where EmpID = {0} And ezn_date = Convert(datetime, '{1}', 103)",
                row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["ezn_date_SRC"].ToString()));
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