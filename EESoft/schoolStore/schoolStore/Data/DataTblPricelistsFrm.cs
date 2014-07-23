using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;


namespace schoolStore
{
    public partial class DataTblPricelistsFrm : DevExpress.XtraEditors.XtraForm
    {
       
        #region -   Variables   -

        #endregion
        #region -   Functions   -
        private void LoadTreeView(TreeView TV, bool LoadAsnaf)
        {
            TV.Nodes.Clear();
            DataTable TblCDCategories = new DataTable("TblCDCategories");
            TblCDCategories = FXFW.SqlDB.LoadDataTable("Select CategoryId, parentID, Category From CDCategories Where parentID = 0");
            foreach (DataRow row in TblCDCategories.Rows)
            {
                TreeNode NewNode = TV.Nodes.Add(row["CategoryId"].ToString(), row["Category"].ToString(), 0);
                LoadSubRoot(NewNode, LoadAsnaf);
                if (LoadAsnaf)
                    LoadContains(NewNode);
            }
        }
        private void LoadSubRoot(TreeNode Nodi, bool LoadAsnaf)
        {
            DataTable TblCDCategories = new DataTable("TblCDCategories");
            TblCDCategories = FXFW.SqlDB.LoadDataTable("Select CategoryId, parentID, Category From CDCategories Where parentID = " + Nodi.Name);
            foreach (DataRow row in TblCDCategories.Rows)
            {
                TreeNode NewNode = Nodi.Nodes.Add(row["CategoryId"].ToString(), row["Category"].ToString(), 0);
                LoadSubRoot(NewNode, LoadAsnaf);
                if (LoadAsnaf)
                    LoadContains(NewNode);
            }
        }
        private void LoadContains(TreeNode Nodi)
        {
            DataTable TblCDASNAF = new DataTable("TblCDCategories");
            TblCDASNAF = FXFW.SqlDB.LoadDataTable("Select SanfID, SanfName From CDASNAF Where CategoryID = " + Nodi.Name);
            foreach (DataRow row in TblCDASNAF.Rows)
            {
                TreeNode NewNode = Nodi.Nodes.Add(row["SanfID"].ToString(), row["SanfName"].ToString(), 1);
            }
        }
        private void LoadGrid()
        {
            GridTable = FXFW.SqlDB.LoadDataTable(@"Select SanfID, priceout, Oldpriceout, 
            (Select CategoryID From CDASNAF Where SanfID = TblPricelistdetailes.SanfID) AS CategoryID,
            (Select SanfName From CDASNAF Where SanfID = TblPricelistdetailes.SanfID) AS SanfName
            From TblPricelistdetailes");
            gridControlMain.DataSource = GridTable;
        }
        #endregion
        #region -   Event Handlers   -
        DataTable GridTable = new DataTable();
        public DataTblPricelistsFrm()
        {
            InitializeComponent();
        }
        private void DataTblPricelistsFrm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadTreeView(TVAddCat, false);
        }
        private void TVAddCat_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GridTable = FXFW.SqlDB.LoadDataTable(@"Select SanfID, priceout, Oldpriceout, 
            (Select CategoryID From CDASNAF Where SanfID = TblPricelistdetailes.SanfID) AS CategoryID,
            (Select SanfName From CDASNAF Where SanfID = TblPricelistdetailes.SanfID) AS SanfName
            From TblPricelistdetailes Where SanfID in (Select SanfID From CDASNAF Where CategoryID = " + e.Node.Name + ")");
            gridControlMain.DataSource = GridTable;
            
        }
        private void repositoryItemButtonEditAddSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BtnSaveAll.Focus();
            gridControlMain.Focus();
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow row = GridTable.Rows[gridViewAdd.GetFocusedDataSourceRowIndex()];
            try
            {
                cmd.CommandText = string.Format(@"Update TblPricelistdetailes Set priceout = {0}, Oldpriceout = {1} Where SanfID = {2}",
                row["priceout"], row["Oldpriceout"], row["SanfID"]);
                con.Open();
                cmd.ExecuteNonQuery();
                LoadGrid();
                //Program.msg("تم التعديل", false, "", this);
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            if (trackBarPrice.Value == 1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow row in GridTable.Rows)
                {
                    string priceout, Oldpriceout;
                    if (row["priceout"].ToString() != string.Empty)
                    {
                        Oldpriceout = row["priceout"].ToString();
                        priceout = (Convert.ToDouble(row["priceout"].ToString()) + (Convert.ToDouble(row["priceout"].ToString()) / (100 / trackBarPrice.Value))).ToString();
                    }
                    else
                    {
                        Oldpriceout = "0";
                        priceout = "0";
                    }
                    cmd.CommandText = string.Format(@"Update TblPricelistdetailes Set priceout = {0}, Oldpriceout = {1} Where SanfID = {2}",
                    priceout, Oldpriceout, row["SanfID"]);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
            }
            catch (SqlException ex)
            {
                trn.Rollback();
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
            LoadGrid();
        }
        private void BtnSaveCat_Click(object sender, EventArgs e)
        {
            if (TVAddCat.SelectedNode == null)
                return;
            if (trackBarPrice.Value == 1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow row in GridTable.Rows)
                {
                    if (row["CategoryID"].ToString() != TVAddCat.SelectedNode.Name)
                        continue;
                    string priceout, Oldpriceout;
                    if (row["priceout"].ToString() != string.Empty)
                    {
                        Oldpriceout = row["priceout"].ToString();
                        priceout = (Convert.ToDouble(row["priceout"].ToString()) + (Convert.ToDouble(row["priceout"].ToString()) / (100 / trackBarPrice.Value))).ToString();
                    }
                    else
                    {
                        Oldpriceout = "0";
                        priceout = "0";
                    }
                    cmd.CommandText = string.Format(@"Update TblPricelistdetailes Set priceout = {0}, Oldpriceout = {1} Where SanfID = {2}",
                    priceout, Oldpriceout, row["SanfID"]);
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
            }
            catch (SqlException ex)
            {
                trn.Rollback();
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
            LoadGrid();
        }

#endregion

    }
}