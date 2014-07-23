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

namespace StAccount
{
    public partial class TBLSelectSTEdafyFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable dt_CD_PayTypeDetiel = new DataTable();
        DataTable dt_TBLstudent = new DataTable();
        #endregion
        #region -   Functions   -
        public TBLSelectSTEdafyFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CD_PayTypeDetiel:
                    dt_CD_PayTypeDetiel = SqlDB.LoadDataTable(@"SELECT PayTypeDetielId, PayTypeDetiel
                    FROM CD_PayTypeDetiel WHERE EXISTS (SELECT PayTypeId FROM CD_PayType WHERE (PayTypeId = CD_PayTypeDetiel.PayTypeId) AND (Additional = 1))");
                    repositoryItemSearchLookUpEditPayTypeDetielId.DataSource = dt_CD_PayTypeDetiel;
                    repositoryItemSearchLookUpEditPayTypeDetielId.DisplayMember = "PayTypeDetiel";
                    repositoryItemSearchLookUpEditPayTypeDetielId.ValueMember = "PayTypeDetielId";
                    break;
                case CodeFrm.TableNames.All:
                    //CD_PayTypeDetiel
                    dt_CD_PayTypeDetiel = SqlDB.LoadDataTable(@"SELECT PayTypeDetielId, PayTypeDetiel
                    FROM CD_PayTypeDetiel WHERE EXISTS (SELECT PayTypeId FROM CD_PayType WHERE (PayTypeId = CD_PayTypeDetiel.PayTypeId) AND (Additional = 1))");
                    repositoryItemSearchLookUpEditPayTypeDetielId.DataSource = dt_CD_PayTypeDetiel;
                    repositoryItemSearchLookUpEditPayTypeDetielId.DisplayMember = "PayTypeDetiel";
                    repositoryItemSearchLookUpEditPayTypeDetielId.ValueMember = "PayTypeDetielId";
                    //stu.TBLstudent
                    dt_TBLstudent = SqlDB.LoadDataTable(string.Format(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS stu_name,
                    (Select alsofof_code From stu.student_t Where stu_code = stu.TBLstudent.stu_code And asase_code = {0}) AS alsofof_code,
                    (Select alsofof_name From CDAlsofof Where alsofof_code = (Select alsofof_code From stu.student_t Where stu_code = stu.TBLstudent.stu_code And asase_code = {0})) AS alsofof_name,
                    (Select fasl_code From stu.student_t Where stu_code = stu.TBLstudent.stu_code And asase_code = {0}) AS fasl_code,
                    (Select fasl_name From CDEFasl Where fasl_code = (Select fasl_code From stu.student_t Where stu_code = stu.TBLstudent.stu_code And asase_code = {0})) AS fasl_name
                    FROM stu.TBLstudent", FXFW.SqlDB.asase_code));
                    repositoryItemSearchLookUpEditstu_code.DataSource = dt_TBLstudent;
                    repositoryItemSearchLookUpEditstu_code.DisplayMember = "stu_name";
                    repositoryItemSearchLookUpEditstu_code.ValueMember = "stu_code";
                    break;
                default:
                    break;
            }
            
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(String.Format(@"SELECT asase_code, stu_code, PayTypeDetielId, edafymony, datein, userin,
                                                                         asase_code AS org_asase_code, stu_code AS org_stu_code, PayTypeDetielId AS org_PayTypeDetielId,
                                                                         (Select alsofof_name From CDAlsofof Where alsofof_code = (Select alsofof_code From stu.student_t Where stu_code = TBLSelectSTEdafy.stu_code And asase_code = TBLSelectSTEdafy.asase_code)) AS alsofof_name,
                                                                         (Select fasl_name From CDEFasl Where fasl_code = (Select fasl_code From stu.student_t Where stu_code = TBLSelectSTEdafy.stu_code And asase_code = TBLSelectSTEdafy.asase_code)) AS fasl_name
                                                                         FROM TBLSelectSTEdafy Where asase_code = {0} AND EXISTS (SELECT PayTypeId FROM CD_PayType WHERE Additional = 1 AND PayTypeId = (SELECT PayTypeId FROM CD_PayTypeDetiel WHERE PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId))", FXFW.SqlDB.asase_code));
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
            SqlDB.GetFormPriv(Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
        private void repositoryItemSearchLookUpEditPayTypeDetielId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_PayTypeDetiel);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_PayTypeDetiel);
        }
        private void repositoryItemSearchLookUpEditstu_code_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRow rowStudent = dt_TBLstudent.Rows[gridViewData.GetFocusedDataSourceRowIndex()];
            if (e.NewValue != null)
            {
                for (int i = 0; i < dt_TBLstudent.Rows.Count; i++)
                {
                    if (dt_TBLstudent.Rows[i]["stu_code"].ToString() == e.NewValue.ToString())
                    {
                        gridViewData.SetRowCellValue(gridViewData.FocusedRowHandle, "alsofof_name", dt_TBLstudent.Rows[i]["alsofof_name"].ToString());
                        gridViewData.SetRowCellValue(gridViewData.FocusedRowHandle, "fasl_name", dt_TBLstudent.Rows[i]["fasl_name"].ToString());
                        break;
                    }
                }
            }
            else
            {
                gridViewData.SetRowCellValue(gridViewData.FocusedRowHandle, "alsofof_name", string.Empty);
                gridViewData.SetRowCellValue(gridViewData.FocusedRowHandle, "fasl_name", string.Empty);
            }
        }
        private void repositoryItemSearchLookUpEditPayTypeDetielId_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (string.IsNullOrEmpty(gridViewData.GetRowCellValue(gridViewData.FocusedRowHandle, "stu_code").ToString()))
            {
                gridViewData.SetRowCellValue(gridViewData.FocusedRowHandle, "edafymony", "0");
                return;
            }
            string alsofof_code = "0";
            for (int i = 0; i < dt_TBLstudent.Rows.Count; i++)
            {
                if (dt_TBLstudent.Rows[i]["stu_code"].ToString() == gridViewData.GetRowCellValue(gridViewData.FocusedRowHandle, "stu_code").ToString())
                {
                    alsofof_code = dt_TBLstudent.Rows[i]["alsofof_code"].ToString();
                    break;
                }
            }
            if (e.NewValue != null)
            {
                DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT PayMony AS PayMony FROM CD_PayMony
                WHERE (asase_code = {0}) AND (PayTypeDetielId = {1}) AND (alsofof_code = {2})", FXFW.SqlDB.asase_code, e.NewValue, alsofof_code));
                if (dt.Rows.Count > 0)
                    gridViewData.SetRowCellValue(gridViewData.FocusedRowHandle, "edafymony", dt.Rows[0][0]);    
                else
                    gridViewData.SetRowCellValue(gridViewData.FocusedRowHandle, "edafymony", "0");
            }
            else
            {
                gridViewData.SetRowCellValue(gridViewData.FocusedRowHandle, "edafymony", "0");
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["stu_code"].ToString() == string.Empty || row["PayTypeDetielId"].ToString() == string.Empty)
            {
                Program.ShowMsg("من فضلك ادخل اسم الطالب و بند التحصيل", true, this);
                Program.Logger.LogThis("من فضلك ادخل اسم الطالب و بند التحصيل", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }
            cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.Int) { Value = FXFW.SqlDB.asase_code });
            cmd.Parameters.Add(new SqlParameter("@stu_code", SqlDbType.Int) { Value = row["stu_code"].ToString() });
            cmd.Parameters.Add(new SqlParameter("@PayTypeDetielId", SqlDbType.Int) { Value = row["PayTypeDetielId"].ToString() });
            cmd.Parameters.Add(new SqlParameter("@edafymony", SqlDbType.Float) { Value = row["edafymony"].ToString() });
            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            try
            {
                if (row["org_asase_code"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO dbo.TBLSelectSTEdafy
                                                ( asase_code ,
                                                  stu_code ,
                                                  PayTypeDetielId ,
                                                  edafymony ,
                                                  datein ,
                                                  userin
                                                )
                                        VALUES  ( @asase_code , -- asase_code - tinyint
                                                  @stu_code , -- stu_code - int
                                                  @PayTypeDetielId , -- PayTypeDetielId - int
                                                  @edafymony , -- edafymony - float
                                                  GETDATE() , -- datein - datetime
                                                  @userin  -- userin - int
                                                )";
                }
                else
                {
                    cmd.CommandText = @"UPDATE TBLSelectSTEdafy SET asase_code = @asase_code, stu_code = @stu_code, PayTypeDetielId = @PayTypeDetielId, edafymony = @edafymony, datein = GETDATE(), userin = @userin
                                                      WHERE (asase_code = @org_asase_code) AND (stu_code = @org_stu_code) AND (PayTypeDetielId = @org_PayTypeDetielId)";
                    cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.Int) { Value = row["org_asase_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_stu_code", SqlDbType.Int) { Value = row["org_stu_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_PayTypeDetielId", SqlDbType.Int) { Value = row["org_PayTypeDetielId"].ToString() });
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
            if (row["org_asase_code"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"Delete From TBLSelectSTEdafy Where asase_code = @org_asase_code And stu_code = @org_stu_code And PayTypeDetielId = @org_PayTypeDetielId";
                cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.Int) { Value = row["org_asase_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@org_stu_code", SqlDbType.Int) { Value = row["org_stu_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@org_PayTypeDetielId", SqlDbType.Int) { Value = row["org_PayTypeDetielId"].ToString() });
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