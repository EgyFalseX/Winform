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
    public partial class TBLEstrdadFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public TBLEstrdadFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CD_PayType:
                    repositoryItemGridLookUpEditPayTypeId.DataSource = SqlDB.LoadDataTable(@"SELECT PayTypeId, PayType FROM CD_PayType");
                    repositoryItemGridLookUpEditPayTypeId.DisplayMember = "PayType";
                    repositoryItemGridLookUpEditPayTypeId.ValueMember = "PayTypeId";
                    break;
                case CodeFrm.TableNames.All:
                    //TBLstudent
                    DataTable TblMain = SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS stu_name
                    
                    FROM stu.TBLstudent");
                    repositoryItemGridLookUpEditstu_code.DataSource = TblMain;
                    repositoryItemGridLookUpEditstu_code.DisplayMember = "stu_name";
                    repositoryItemGridLookUpEditstu_code.ValueMember = "stu_code";
                    DataTable TblDetails = SqlDB.LoadDataTable(@"SELECT stu_code, estrdadmony, (Select PayType from CD_PayType where PayTypeId = TBLEstrdad.PayTypeId) as PayType FROM TBLEstrdad");

                    //CD_PayType
                    repositoryItemGridLookUpEditPayTypeId.DataSource = SqlDB.LoadDataTable(@"SELECT PayTypeId, PayType FROM CD_PayType");
                    repositoryItemGridLookUpEditPayTypeId.DisplayMember = "PayType";
                    repositoryItemGridLookUpEditPayTypeId.ValueMember = "PayTypeId";
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT asase_code, stu_code, PayTypeId, estrdadmony, estrdaddate, esremark, datein, userin,
            asase_code as org_asase_code, stu_code as org_stu_code, PayTypeId as org_PayTypeId FROM TBLEstrdad");
            //DevExpress.XtraGrid.Localization.GridLocalizer = 
            
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
        private void repositoryItemGridLookUpEditPayTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_PayType);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_PayType);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            
            
            try
            {
                if (row["org_asase_code"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO dbo.TBLEstrdad
                                                ( asase_code ,
                                                  stu_code ,
                                                  PayTypeId ,
                                                  estrdadmony ,
                                                  estrdaddate ,
                                                  esremark ,
                                                  datein ,
                                                  userin
                                                )
                                        VALUES  ( @asase_code , -- asase_code - tinyint
                                                  @stu_code , -- stu_code - int
                                                  @PayTypeId , -- PayTypeId - tinyint
                                                  @estrdadmony , -- estrdadmony - float
                                                  @estrdaddate , -- estrdaddate - date
                                                  @esremark , -- esremark - nvarchar(150)
                                                  GETDATE() , -- datein - datetime
                                                  @userin  -- userin - int
                                                )";
                }
                else
                {
                    cmd.CommandText = @"UPDATE TBLEstrdad SET
                                        asase_code = @asase_code , 
                                        stu_code = @stu_code ,
                                        PayTypeId = @PayTypeId ,
                                        estrdadmony = @estrdadmony ,
                                        estrdaddate = @estrdaddate ,
                                        esremark = @esremark ,
                                        datein = GETDATE() ,
                                        userin = @userin
                                        WHERE asase_code = @org_asase_code AND stu_code = @org_stu_code AND PayTypeId = @org_PayTypeId";
                    cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.Int) { Value = row["org_asase_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_stu_code", SqlDbType.Int) { Value = row["org_stu_code"] });
                    cmd.Parameters.Add(new SqlParameter("@org_PayTypeId", SqlDbType.Int) { Value = row["org_PayTypeId"] });
                }
                cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.Int) {  Value = FXFW.SqlDB.asase_code });
                cmd.Parameters.Add(new SqlParameter("@stu_code", SqlDbType.Int) { Value = row["stu_code"] });
                cmd.Parameters.Add(new SqlParameter("@PayTypeId", SqlDbType.Int) { Value = row["PayTypeId"] });
                cmd.Parameters.Add(new SqlParameter("@estrdadmony", SqlDbType.TinyInt) { Value = row["estrdadmony"] });
                cmd.Parameters.Add(new SqlParameter("@estrdaddate", SqlDbType.Date) { Value = row["estrdaddate"] });
                cmd.Parameters.Add(new SqlParameter("@esremark", SqlDbType.NVarChar) { Value = row["esremark"] });
                cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
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
                cmd.CommandText = @"Delete From TBLEstrdad Where asase_code = @org_asase_code And stu_code = @org_stu_code AND PayTypeId = @org_PayTypeId";
                cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.Int) { Value = row["org_asase_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_stu_code", SqlDbType.Int) { Value = row["org_stu_code"] });
                cmd.Parameters.Add(new SqlParameter("@org_PayTypeId", SqlDbType.Int) { Value = row["org_PayTypeId"] });
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