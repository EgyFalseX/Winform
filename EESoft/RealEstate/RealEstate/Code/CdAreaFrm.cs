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
    public partial class CdAreaFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public CdAreaFrm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable("Select CdAreaId, CdArea From CdArea");
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
            try
            {
                if (Row["CdAreaId"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    string NewID = MyCL.GetNewID("CdArea", "CdAreaId");
                    cmd.CommandText = String.Format("Insert Into CdArea (CdAreaId, [CdArea]) VALUES ({0}, '{1}')", NewID, MyCL.CleanSQLValue(Row["CdArea"].ToString()));
                }
                else
                {
                    cmd.CommandText = String.Format("Update CdArea Set [CdArea] = '{0}' Where CdAreaId = {1}", MyCL.CleanSQLValue(Row["CdArea"].ToString()), Row["CdAreaId"]);
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
            if (Row["CdAreaId"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From CdArea Where CdAreaId = " + Row["CdAreaId"];
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
