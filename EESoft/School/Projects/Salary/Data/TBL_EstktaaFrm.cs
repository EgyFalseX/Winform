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

namespace Salary
{
    public partial class TBL_EstktaaFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBL_EstktaaFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CD_Estktaa:
                    repositoryItemGridLookUpEditEstktaaId.DataSource = SqlDB.LoadDataTable(@"SELECT EstktaaId, Estktaa FROM CD_Estktaa");
                    repositoryItemGridLookUpEditEstktaaId.DisplayMember = "Estktaa";
                    repositoryItemGridLookUpEditEstktaaId.ValueMember = "EstktaaId";
                    break;
                case CodeFrm.TableNames.All:
                    //CD_Estktaa
                    repositoryItemGridLookUpEditEstktaaId.DataSource = SqlDB.LoadDataTable(@"SELECT EstktaaId, Estktaa FROM CD_Estktaa");
                    repositoryItemGridLookUpEditEstktaaId.DisplayMember = "Estktaa";
                    repositoryItemGridLookUpEditEstktaaId.ValueMember = "EstktaaId";
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
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, EstktaaId, EsthkakMony, EsthkakDate, 
            EmpID AS org_EmpID, EstktaaId AS org_EstktaaId
            FROM CD_Estktaa");
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
            SqlDB.GetFormPriv("Salary" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditEstktaaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Estktaa);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_Estktaa);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = row["EmpID"] });
            cmd.Parameters.Add(new SqlParameter("@EstktaaId", SqlDbType.TinyInt) { Value = row["EstktaaId"] });
            cmd.Parameters.Add(new SqlParameter("@EsthkakMony", SqlDbType.Float) { Value = row["EsthkakMony"] });
            cmd.Parameters.Add(new SqlParameter("@EsthkakDate", SqlDbType.Date) { Value = row["EsthkakDate"] });
            foreach (SqlParameter item in cmd.Parameters)
            {
                if (FXFW.SqlDB.IsNullOrEmpty(item.Value))
                {
                    item.Value = DBNull.Value;
                }

            }
            try
            {
                if (row["org_EmpID"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO TBL_Estktaa (EmpID, EstktaaId, EsthkakMony, EsthkakDate) VALUES (@EmpID, @EstktaaId, @EsthkakMony, @EsthkakDate)";
                }
                else
                {
                    cmd.CommandText = @"UPDATE TBL_Estktaa SET EmpID = @EmpID, EstktaaId = @EstktaaId, EsthkakMony = @EsthkakMony, EsthkakDate = @EsthkakDate 
                    WHERE (EmpID = @org_EmpID) AND (EsthkakId = @org_EsthkakId)";
                    cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = row["org_EmpID"] });
                    cmd.Parameters.Add(new SqlParameter("@org_EstktaaId", SqlDbType.TinyInt) { Value = row["org_EstktaaId"] });
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
            if (row["org_EmpID"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"Delete From TBL_Estktaa WHERE (EmpID = @org_EmpID) AND (EstktaaId = @org_EstktaaId)";
                cmd.Parameters.Add(new SqlParameter("@org_EmpID", SqlDbType.Int) { Value = row["org_EmpID"] });
                cmd.Parameters.Add(new SqlParameter("@org_EstktaaId", SqlDbType.TinyInt) { Value = row["org_EstktaaId"] });
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