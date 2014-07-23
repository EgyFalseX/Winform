using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace RealEstate
{
    public partial class CdperiodFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public CdperiodFrm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable("Select PeriodId, Period, months From Cdperiod");
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
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            string months;
            if (Row["months"].ToString() != string.Empty)
                months = Row["months"].ToString();
            else
                months = "0";
            try
            {
                if (Row["PeriodId"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    string NewID = MyCL.GetNewID("Cdperiod", "PeriodId");
                    cmd.CommandText = string.Format(@"Insert Into Cdperiod (PeriodId, Period, months) VALUES ({0}, '{1}', {2})", NewID, MyCL.CleanSQLValue(Row["Period"].ToString()), months);
                }
                else
                {
                    cmd.CommandText = string.Format(@"Update Cdperiod Set Period = '{0}', months = {1} Where PeriodId = {2}", MyCL.CleanSQLValue(Row["Period"].ToString()), months, Row["PeriodId"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message , true, this);
            }
            con.Close();
            LoadData();
            
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["PeriodId"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From Cdperiod Where PeriodId = " + Row["PeriodId"];
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message , true, this);
            }
            con.Close();
            LoadData();
        }
        #endregion
    }
}