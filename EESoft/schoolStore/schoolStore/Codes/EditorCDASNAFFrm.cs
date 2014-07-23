using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using System.Data.SqlClient;
using Alias = System.Windows.Forms;

namespace schoolStore
{
    public partial class EditorCDASNAFFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public EditorCDASNAFFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            DataTable TblCDCompany = new DataTable();
            TblCDCompany = FXFW.SqlDB.LoadDataTable("Select CompanyID, Company From CDCompany");
            LUEAddCDCompany.Properties.DataSource = TblCDCompany;
            LUEAddCDCompany.Properties.DisplayMember = "Company";
            LUEAddCDCompany.Properties.ValueMember = "CompanyID";
            LUEEditCDCompany.Properties.DataSource = TblCDCompany;
            LUEEditCDCompany.Properties.DisplayMember = "Company";
            LUEEditCDCompany.Properties.ValueMember = "CompanyID";

            DataTable TblTagzeaUnit = new DataTable();
            TblTagzeaUnit = FXFW.SqlDB.LoadDataTable("Select SalesUnitID, SalesUnitName From CDSalesUnit");
            LUEAddTagzeaUnit.Properties.DataSource = TblTagzeaUnit;
            LUEAddTagzeaUnit.Properties.DisplayMember = "SalesUnitName";
            LUEAddTagzeaUnit.Properties.ValueMember = "SalesUnitID";
            LUEEditTagzeaUnit.Properties.DataSource = TblTagzeaUnit;
            LUEEditTagzeaUnit.Properties.DisplayMember = "SalesUnitName";
            LUEEditTagzeaUnit.Properties.ValueMember = "SalesUnitID";
        }
        private string GetNewBarCode(string CategoryID)
        {
            string LastBarCode = FXFW.SqlDB.LoadDataTable("SELECT ISNULL(MAX(Sanfbarcode) + 1, 0) AS Sanfbarcode FROM CDASNAF WHERE CategoryID = " + CategoryID).Rows[0][0].ToString();
            if (LastBarCode == "0")
            {
                switch (CategoryID.Length)
                {
                    case 1:
                        return String.Format("00{0}001", CategoryID);
                    case 2:
                        return String.Format("0{0}001", CategoryID);
                    case 3:
                        return String.Format("{0}001", CategoryID);
                }
            }
            else
            {
                switch (LastBarCode.Length)
                {
                    case 4:
                        return String.Format("00{0}", LastBarCode);
                    case 5:
                        return String.Format("0{0}", LastBarCode);
                    case 6:
                        return String.Format("{0}", LastBarCode);
                }
            }
            return "XXXXXX";
        }
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
        private void ClearForm()
        {
            TxtAddSanfName.Text = string.Empty;
            LUEAddCDCompany.ItemIndex = 0;
            LUEAddTagzeaUnit.ItemIndex = 0;
            TxtAddReOrder.Text = "1";
            TxtAddModelNo.Text = string.Empty;
            TxtAddrem.Text = string.Empty;
            TVAddCat_AfterSelect(TVAddCat, new TreeViewEventArgs(new TreeNode()));
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorCDASNAFFrm_Load(object sender, EventArgs e)
        {
            LoadTreeView(TVAddCat, false);
            LoadDefaultData();
            ClearForm();
        }
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEdit)
                LoadTreeView(TVEditCat, true);
        }
        private void BtnAddSave_Click(object sender, EventArgs e)
        {
            if (TxtAddSanfName.Text.Trim() == string.Empty || LUEAddTagzeaUnit.EditValue == null || TVAddCat.SelectedNode == null)
            {
                Program.msg("من فضلك اكمل البيانات", true, "", this);
                return;
            }
            // Check if this Sanf Name is Exists b4
            DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"Select SanfID From CDASNAF Where SanfName Like N'{0}'", TxtAddSanfName.Text));
            if (dt.Rows.Count > 0)
            {
                Program.msg("هذا الاسم للصنف موجود مسبقا", true, "", this);
                return;
            }
            string CDCompany;
            if (LUEAddCDCompany.EditValue != null)
                CDCompany = LUEAddCDCompany.EditValue.ToString();
            else
                CDCompany = "NULL";
            string ReOrder;
            if (TxtAddReOrder.Text != string.Empty)
                ReOrder = TxtAddReOrder.Text;
            else
                ReOrder = "NULL";

            string rem;
            if (TxtAddrem.Text != string.Empty)
                rem = string.Format("N'{0}'", TxtAddrem.Text);
            else
                rem = "NULL";
            string ModelNo;
            if (TxtAddModelNo.Text != string.Empty)
                ModelNo = string.Format("N'{0}'", TxtAddModelNo.Text);
            else
                ModelNo = "NULL";
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"INSERT INTO CDASNAF (SanfID, CategoryID, SanfName, CompanyID, TagzeaUnit, ReOrder, rem, Sanfbarcode, ModelNo)
                VALUES ((Select Isnull(Max(SanfID) + 1, 1) From CDASNAF), {0}, N'{1}', {2}, {3}, {4}, {5}, N'{6}', {7})", TVAddCat.SelectedNode.Name, TxtAddSanfName.Text,
                CDCompany, LUEAddTagzeaUnit.EditValue, ReOrder, rem, GetNewBarCode(TVAddCat.SelectedNode.Name), ModelNo);
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format(@"Insert Into TblPricelistdetailes (SanfID, priceout, Oldpriceout) VALUES
                ((Select Max(SanfID) From CDASNAF), 0, 0)");
                cmd.ExecuteNonQuery();
                ClearForm();
                //Program.msg("تم الاضافه", false, "", this);
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void TVEditCat_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TVEditCat.SelectedNode.ImageIndex == 0)
            {
                TxtEditSanfName.Text = string.Empty;
                LUEEditCDCompany.EditValue = null;
                LUEEditTagzeaUnit.EditValue = null;
                TxtEditReOrder.Text = string.Empty;
                TxtEditrem.Text = string.Empty;
                TxtSanfbarcode.Text = string.Empty;
                TxtEditModelNo.Text = string.Empty;
                return;
            }
            DataRow SanfDetailsRow = FXFW.SqlDB.LoadDataTable("Select SanfID, CategoryID, SanfName, CompanyID, TagzeaUnit, ReOrder, rem, Sanfbarcode, ModelNo From CDASNAF Where SanfID = " + TVEditCat.SelectedNode.Name).Rows[0];
            TxtEditSanfName.Text = SanfDetailsRow["SanfName"].ToString();
            LUEEditCDCompany.EditValue = SanfDetailsRow["CompanyID"];
            LUEEditTagzeaUnit.EditValue = SanfDetailsRow["TagzeaUnit"];
            TxtEditReOrder.Text = SanfDetailsRow["ReOrder"].ToString();
            TxtEditrem.Text = SanfDetailsRow["rem"].ToString();
            TxtSanfbarcode.Text = SanfDetailsRow["Sanfbarcode"].ToString();
            TxtEditModelNo.Text = SanfDetailsRow["ModelNo"].ToString();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TVEditCat.SelectedNode.ImageIndex == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == Alias.DialogResult.No)
                return;
            string CDCompany;
            if (LUEEditCDCompany.EditValue != null)
                CDCompany = LUEEditCDCompany.EditValue.ToString();
            else
                CDCompany = "NULL";
            string ReOrder;
            if (TxtEditReOrder.Text != string.Empty)
                ReOrder = TxtEditReOrder.Text;
            else
                ReOrder = "NULL";

            string rem;
            if (TxtEditrem.Text != string.Empty)
                rem = string.Format("N'{0}'", TxtEditrem.Text);
            else
                rem = "NULL";
            string ModelNo;
            if (TxtEditModelNo.Text != string.Empty)
                ModelNo = string.Format("N'{0}'", TxtEditModelNo.Text);
            else
                ModelNo = "NULL";
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"Update CDASNAF Set CategoryID = {0}, SanfName = N'{1}', CompanyID = {2}, TagzeaUnit = {3}, ReOrder = {4}, 
                rem = {5}, ModelNo = {6} Where SanfID = {7} ", TVEditCat.SelectedNode.Parent.Name, TxtEditSanfName.Text,
                CDCompany, LUEEditTagzeaUnit.EditValue, ReOrder, rem, ModelNo, TVEditCat.SelectedNode.Name);
                cmd.ExecuteNonQuery();
                TVEditCat.SelectedNode.Text = TxtEditSanfName.Text;
                Program.msg("تم التعديل", false, "", this);
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TVEditCat.SelectedNode.ImageIndex == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == Alias.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = "Delete From CDASNAF Where SanfID = " + TVEditCat.SelectedNode.Name;
                cmd.ExecuteNonQuery();
                TVEditCat.SelectedNode.Remove();
                Program.msg("تم الحذف", false, "", this);
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();

        }
        private void TVAddCat_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TVAddCat.SelectedNode == null)
            {
                TxtLastSanf.Text = string.Empty;
                TxtCount.Text = string.Empty;
                return;
            }
            DataTable DT = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT COUNT(SanfID) AS Total, (Select top 1 SanfName From CDASNAF Where CategoryID = {0} order by SanfID desc) AS SanfName FROM CDASNAF WHERE CategoryID = {0}", TVAddCat.SelectedNode.Name));
            if (DT.Rows.Count == 0)
            {
                TxtLastSanf.Text = string.Empty;
                TxtCount.Text = string.Empty;
            }
            else
            {
                TxtLastSanf.Text = DT.Rows[0]["SanfName"].ToString();
                TxtCount.Text = DT.Rows[0]["Total"].ToString();
            }
        }
        #endregion

    }
}