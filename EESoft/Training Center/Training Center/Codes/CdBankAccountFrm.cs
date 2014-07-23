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
    public partial class CdBankAccountFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public CdBankAccountFrm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable("Select AccountID, AccountName, AccountNumber From CdBankAccount");
            gridControlMain.DataSource = GridTable;
            gridControlMain.RefreshDataSource();
            
        }
#endregion
        #region -   Event Handlers   -
        private void FrmCdBankAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            //this.Focus();
            //gridControlMain.Focus();
            //gridControlMain.RefreshDataSource();
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            //DataRow Row = GridTable.Rows[gridViewMain.GetFocusedDataSourceRowIndex()];
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();

            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                if (Row["AccountID"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    cmd.CommandText = string.Format(@"Insert Into CdBankAccount (AccountName, AccountNumber) VALUES ('{0}', '{1}')",
                    Row["AccountName"], Row["AccountNumber"]);
                }
                else
                {
                    cmd.CommandText = string.Format(@"Update CdBankAccount Set AccountName = '{0}', AccountNumber = '{1}' Where AccountID = {2}",
                    Row["AccountName"], Row["AccountNumber"], Row["AccountID"]);
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
            LoadData();
            
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Focus();
            //gridControlMain.Focus();
            //gridControlMain.RefreshDataSource();
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            //DataRow Row = GridTable.Rows[gridViewMain.GetFocusedDataSourceRowIndex()];
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["AccountID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From CdBankAccount Where AccountID = " + Row["AccountID"];
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