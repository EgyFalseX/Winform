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
    public partial class EMP_gzaatFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public EMP_gzaatFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CD_GzaaType:
                    repositoryItemGridLookUpEditGzaaTypeId.DataSource = SqlDB.LoadDataTable(@"SELECT GzaaTypeId, GzaaType, GzaaType_e FROM CD_GzaaType");
                    repositoryItemGridLookUpEditGzaaTypeId.DisplayMember = "GzaaType";
                    repositoryItemGridLookUpEditGzaaTypeId.ValueMember = "GzaaTypeId";
                    break;
                case CodeFrm.TableNames.CD_GehaGazaa:
                    repositoryItemGridLookUpEditGehaGazaaId.DataSource = SqlDB.LoadDataTable(@"SELECT GehaGazaaId, GehaGazaa, GehaGazaa_e FROM CD_GehaGazaa");
                    repositoryItemGridLookUpEditGehaGazaaId.DisplayMember = "GehaGazaa";
                    repositoryItemGridLookUpEditGehaGazaaId.ValueMember = "GehaGazaaId";
                    break;
                case CodeFrm.TableNames.All:
                    //CD_GzaaType
                    repositoryItemGridLookUpEditGzaaTypeId.DataSource = SqlDB.LoadDataTable(@"SELECT GzaaTypeId, GzaaType, GzaaType_e FROM CD_GzaaType");
                    repositoryItemGridLookUpEditGzaaTypeId.DisplayMember = "GzaaType";
                    repositoryItemGridLookUpEditGzaaTypeId.ValueMember = "GzaaTypeId";
                    //CD_GehaGazaa
                    repositoryItemGridLookUpEditGehaGazaaId.DataSource = SqlDB.LoadDataTable(@"SELECT GehaGazaaId, GehaGazaa, GehaGazaa_e FROM CD_GehaGazaa");
                    repositoryItemGridLookUpEditGehaGazaaId.DisplayMember = "GehaGazaa";
                    repositoryItemGridLookUpEditGehaGazaaId.ValueMember = "GehaGazaaId";
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
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, GzaaTypeId, gzaa_date, gzaa_decision_no, GehaGazaaId, gzaa_reson, datein, userin, 
            EmpID AS EmpID_SRC, GzaaTypeId AS GzaaTypeId_SRC, gzaa_date AS gzaa_date_SRC FROM EMP_gzaat");
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
        private void repositoryItemGridLookUpEditGzaaTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_GzaaType);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_GzaaType);
        }
        private void repositoryItemGridLookUpEditGehaGazaaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_GehaGazaa);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_GehaGazaa);
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

            string GzaaTypeId;
            if (row["GzaaTypeId"].ToString() == string.Empty)
                GzaaTypeId = "NULL";
            else
                GzaaTypeId = row["GzaaTypeId"].ToString();

            string gzaa_date;
            if (row["gzaa_date"].ToString() == string.Empty)
                gzaa_date = "NULL";
            else
                gzaa_date = string.Format("Convert(datetime, '{0}', 103)", SqlDB.ConvertToDateDMY(row["gzaa_date"].ToString()));

            string gzaa_decision_no;
            if (row["gzaa_decision_no"].ToString() == string.Empty)
                gzaa_decision_no = "0";
            else
                gzaa_decision_no = row["gzaa_decision_no"].ToString();

            string GehaGazaaId;
            if (row["GehaGazaaId"].ToString() == string.Empty)
                GehaGazaaId = "NULL";
            else
                GehaGazaaId = row["GehaGazaaId"].ToString();

            string gzaa_reson;
            if (row["gzaa_reson"].ToString() == string.Empty)
                gzaa_reson = "NULL";
            else
                gzaa_reson = String.Format("N'{0}'", row["gzaa_reson"]);

            try
            {
                if (row["EmpID_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO EMP_gzaat (EmpID, GzaaTypeId, gzaa_date, gzaa_decision_no, GehaGazaaId, gzaa_reson, datein, userin)
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, GETDATE(), {6})", EmpID, GzaaTypeId, gzaa_date, gzaa_decision_no, GehaGazaaId, gzaa_reson, SqlDB.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE EMP_gzaat SET EmpID = {0}, GzaaTypeId = {1}, gzaa_date = {2}, gzaa_decision_no = {3}, GehaGazaaId = {4}, gzaa_reson = {5}, datein = GETDATE(), userin = {6}
                    WHERE (EmpID = {7}) AND (GzaaTypeId = {8}) AND (gzaa_date = Convert(datetime, '{9}', 103))", EmpID, GzaaTypeId, gzaa_date, gzaa_decision_no, GehaGazaaId, gzaa_reson, SqlDB.UserInfo.UserID,
                    row["EmpID_SRC"], row["GzaaTypeId_SRC"], SqlDB.ConvertToDateDMY(row["gzaa_date_SRC"].ToString()));
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
                cmd.CommandText = string.Format(@"Delete From EMP_gzaat Where EmpID = {0} And GzaaTypeId = {1} And gzaa_date = Convert(datetime, '{2}', 103)",
                row["EmpID_SRC"], row["GzaaTypeId_SRC"], SqlDB.ConvertToDateDMY(row["gzaa_date_SRC"].ToString()));
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