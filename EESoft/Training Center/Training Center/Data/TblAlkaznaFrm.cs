using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Training_Center
{
    public partial class TblAlkaznaFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TblAlkaznaFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            //TBLTrainee
            repositoryItemGridLookUpEditActionId.DataSource = MyCL.LoadDataTable("Select ActionId, action_name From CdActionkazna");
            repositoryItemGridLookUpEditActionId.ValueMember = "ActionId";
            repositoryItemGridLookUpEditActionId.DisplayMember = "action_name";
            //CdBankAccount
            repositoryItemGridLookUpEditAccountID.DataSource = MyCL.LoadDataTable("Select AccountId, AccountTreeId, AccountDes From TBL_Accountes");
            repositoryItemGridLookUpEditAccountID.ValueMember = "AccountId";
            repositoryItemGridLookUpEditAccountID.DisplayMember = "AccountDes";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"SELECT ActionId, HarakaNo, ActionDate, Amony, Notes, AccountId, Closek, 
            HarakaNo AS HarakaNo_Org, Convert(nvarchar, ActionDate, 103) AS ActionDate_Org, Closek AS Closek_Org FROM TblAlkazna");
            gridControlMain.DataSource = GridTable;
            gridControlMain.RefreshDataSource();
        }
#endregion
        #region -   Event Handlers   -
        private void FrmCdBankAccount_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void repositoryItemGridLookUpEditAccountID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
                return;
            using (AccTypesDlgFrm dlg = new AccTypesDlgFrm())
            {
                dlg.ShowDialog();
                if (dlg.AccountID != string.Empty)
                {
                    DataRow row = gridViewMain.GetFocusedDataRow();
                    row["AccountId"] = dlg.AccountID;
                }
            }
            gridViewMain.FocusedColumn = GCNotes;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            
            if (Row["ActionDate"].ToString() == string.Empty || Row["ActionId"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("بيانات غير مكتمله", true, this);
                return;
            }
            string Amony;
            if (Row["Amony"].ToString() == string.Empty)
                Amony = "0";
            else
                Amony = Row["Amony"].ToString();
            string Notes;
            if (Row["Notes"].ToString() == string.Empty)
                Notes = "NULL";
            else
                Notes = string.Format(@"N'{0}'", Row["Notes"]);
            string AccountId;
            if (Row["AccountId"].ToString() == string.Empty)
                AccountId = "NULL";
            else
                AccountId = Row["AccountId"].ToString();

            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["HarakaNo_Org"].ToString() == string.Empty)// Is Unsaved Row?
                    {
                        string HarakaNo = MyCL.GetNewID("TblAlkazna", "HarakaNo");
                        cmd.CommandText = string.Format(@"INSERT INTO TblAlkazna (ActionId, HarakaNo, ActionDate, Amony, Notes, AccountId, Closek)
                                VALUES ({0}, {1}, CONVERT(DATETIME, '{2}', 103), {3}, {4}, {5}, '{6}')", Row["ActionId"], HarakaNo, MyCL.ConvertToDateDMY(Row["ActionDate"].ToString()), Amony, Notes, AccountId, Row["Closek"]);
                    }
                    else
                    {
                        if (Row["Closek_Org"].ToString() == "True")
                        {
                            MyCL.ShowMsg("لا يمكن تعديل ما تم ترحيله", true, this);
                            return;
                        }
                        cmd.CommandText = string.Format(@"UPDATE TblAlkazna SET ActionId = {0}, HarakaNo = {1}, ActionDate = CONVERT(DATETIME, '{2}', 103), Amony = {3}, 
                        Notes = {4}, AccountId = {5}, Closek = '{6}' Where HarakaNo = {7} And ActionDate = CONVERT(DATETIME, '{8}', 103)", Row["ActionId"],
                        Row["HarakaNo"], MyCL.ConvertToDateDMY(Row["ActionDate"].ToString()), Amony, Notes, AccountId, Row["Closek"], Row["HarakaNo_Org"], Row["ActionDate_Org"]);
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MyCL.ShowMsg("تم الحفظ", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
                con.Close();
            }
            LoadData();
            
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["HarakaNo_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"Delete From TblAlkazna Where HarakaNo = {0} And ActionDate = CONVERT(DATETIME, '{1}', 103)}", 
                Row["HarakaNo_Org"], Row["ActionDate_Org"]);
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
            }
            con.Close();
            LoadData();
        }
        #endregion
    }
}