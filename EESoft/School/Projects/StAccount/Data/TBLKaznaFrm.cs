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
    public partial class TBLKaznaFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public TBLKaznaFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            //CDHarkaType
            repositoryItemGridLookUpEditHarkaTypeId.DataSource = SqlDB.LoadDataTable(@"SELECT HarkaTypeId, HarkaType FROM CDHarkaType");
            repositoryItemGridLookUpEditHarkaTypeId.DisplayMember = "HarkaType";
            repositoryItemGridLookUpEditHarkaTypeId.ValueMember = "HarkaTypeId";

            repositoryItemGridLookUpEditAccountId.DataSource = SqlDB.LoadDataTable(@"SELECT AccountId, AccountDes FROM CD_Acounts");
            repositoryItemGridLookUpEditAccountId.DisplayMember = "AccountDes";
            repositoryItemGridLookUpEditAccountId.ValueMember = "AccountId";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT kid, HarkaTypeId, HarkaDate, EznNo, AccountId, kmony, kbean, kname, userin, datein FROM TBLKazna");
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
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditAccountId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
                return;
            AccTypesDlgFrm dlg = new AccTypesDlgFrm();
            dlg.ShowDialog();
            DataRow row = gridViewData.GetFocusedDataRow();
            if (dlg.AccountID != string.Empty)
            {
                row["AccountId"] = dlg.AccountID;
                this.Focus();
                gridControlData.Focus();
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();

            try
            {
                if (row["kid"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO dbo.TBLKazna
                                                ( HarkaTypeId ,
                                                  HarkaDate ,
                                                  EznNo ,
                                                  AccountId ,
                                                  kmony ,
                                                  kbean ,
                                                  kname ,
                                                  userin ,
                                                  datein
                                                )
                                        VALUES  ( @HarkaTypeId , -- HarkaTypeId - tinyint
                                                  @HarkaDate , -- HarkaDate - date
                                                  (Select Isnull(Max(EznNo) + 1, 1) From TBLKazna Where HarkaTypeId = @HarkaTypeId) , -- EznNo - int
                                                  @AccountId , -- AccountId - int
                                                  @kmony , -- kmony - float
                                                  @kbean , -- kbean - nvarchar(150)
                                                  @kname , -- kname - nvarchar(50)
                                                  @userin , -- userin - int
                                                  GETDATE()  -- datein - datetime
                                                )";
                }
                else
                {
                    cmd.CommandText = @"UPDATE TBLKazna SET 
                                        HarkaTypeId = @HarkaTypeId,
                                        HarkaDate = @HarkaDate ,
                                        AccountId = @AccountId ,
                                        kmony = @kmony ,
                                        kbean = @kbean ,
                                        kname = @kname ,
                                        userin = @userin ,
                                        datein = GETDATE()
                                        WHERE kid = @kid";
                    cmd.Parameters.Add(new SqlParameter("@kid", SqlDbType.Int) { Value = row["kid"] });
                }
                cmd.Parameters.Add(new SqlParameter("@HarkaTypeId", SqlDbType.TinyInt) { Value = row["HarkaTypeId"] });
                cmd.Parameters.Add(new SqlParameter("@HarkaDate", SqlDbType.Date) { Value = row["HarkaDate"] });
                //cmd.Parameters.Add(new SqlParameter("@EznNo", SqlDbType.Int) { Value = row["EznNo"] });
                cmd.Parameters.Add(new SqlParameter("@AccountId", SqlDbType.Int) { Value = row["AccountId"] });
                cmd.Parameters.Add(new SqlParameter("@kmony", SqlDbType.Float) { Value = row["kmony"] });
                cmd.Parameters.Add(new SqlParameter("@kbean", SqlDbType.NVarChar) { Value = row["kbean"] });
                cmd.Parameters.Add(new SqlParameter("@kname", SqlDbType.NVarChar) { Value = row["kname"] });
                cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = SqlDB.UserInfo.UserID });
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
            if (row["kid"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"Delete From TBLKazna Where kid = " + row["kid"];
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