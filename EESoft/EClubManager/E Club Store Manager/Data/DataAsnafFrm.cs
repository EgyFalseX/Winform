using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Store_Manager
{
    public partial class DataAsnafFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable CategoryTbl = new DataTable("FalseX");
        DataTable CompanyTbl = new DataTable("FalseX");
        DataTable TagzeaUnitTbl = new DataTable("FalseX");
        DataTable GomlaUnitTbl = new DataTable("FalseX");
        DataTable AsnafGridTbl = new DataTable("FalseX");
        public DataAsnafFrm()
        {
            InitializeComponent();
        }
        private void DataAsnafFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }
        private void LoadDefaultData()
        {
            CategoryTbl = new DataTable("FalseX");
            CompanyTbl = new DataTable("FalseX");
            TagzeaUnitTbl = new DataTable("FalseX");
            GomlaUnitTbl = new DataTable("FalseX");
            CategoryTbl = Program.MC.LoadDataTable("SELECT CategoryID, CategoryName FROM CDCategories");
            LUECategory.Properties.DataSource = CategoryTbl;
            LUECategory.Properties.DisplayMember = "CategoryName";
            LUECategory.Properties.ValueMember = "CategoryID";
            CompanyTbl= Program.MC.LoadDataTable("SELECT CompanyID, Company FROM CDCompany");
            LUECompany.Properties.DataSource = CompanyTbl;
            LUECompany.Properties.DisplayMember = "Company";
            LUECompany.Properties.ValueMember = "CompanyID";
            TagzeaUnitTbl = Program.MC.LoadDataTable("SELECT SalesUnitID, SalesUnitName FROM CDSalesUnit");
            LUETagzeaUnit.Properties.DataSource = TagzeaUnitTbl;
            LUETagzeaUnit.Properties.DisplayMember = "SalesUnitName";
            LUETagzeaUnit.Properties.ValueMember = "SalesUnitID";
            GomlaUnitTbl = Program.MC.LoadDataTable("SELECT SalesUnitID, SalesUnitName FROM CDSalesUnit");
            LUEGomlaUnit.Properties.DataSource = GomlaUnitTbl;
            LUEGomlaUnit.Properties.DisplayMember = "SalesUnitName";
            LUEGomlaUnit.Properties.ValueMember = "SalesUnitID";
            //GridControl Columns
            repositoryItemLookUpEditCompany.DataSource = CompanyTbl;
            repositoryItemLookUpEditCompany.DisplayMember = "Company";
            repositoryItemLookUpEditCompany.ValueMember = "CompanyID";
            repositoryItemLookUpEditCategory.DataSource = CategoryTbl;
            repositoryItemLookUpEditCategory.DisplayMember = "CategoryName";
            repositoryItemLookUpEditCategory.ValueMember = "CategoryID";
            repositoryItemLookUpEditTagzeaUnit.DataSource = TagzeaUnitTbl;
            repositoryItemLookUpEditTagzeaUnit.DisplayMember = "SalesUnitName";
            repositoryItemLookUpEditTagzeaUnit.ValueMember = "SalesUnitID";
            repositoryItemLookUpEditGomlaUnit.DataSource = GomlaUnitTbl;
            repositoryItemLookUpEditGomlaUnit.DisplayMember = "SalesUnitName";
            repositoryItemLookUpEditGomlaUnit.ValueMember = "SalesUnitID";
        }
        private void LoadGridData()
        {
            AsnafGridTbl = new DataTable("FalseX");
            AsnafGridTbl = Program.MC.LoadDataTable("SELECT SanfID, CategoryID, SanfName, CompanyID, CostPrice, MinimumPrice, TagzeaUnit, TagzeaEqual, TagzeaSellprice, GomlaUnit, GomlaEqual, GomlaSellprice, ReOrder, rem FROM CDASNAF");
            GridControlAsnaf.DataSource = AsnafGridTbl;
        }
        private void TxtSanfName_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtSanfName.Text.Trim().Length == 0)
                BtnAdd.Enabled = false;
            else
                BtnAdd.Enabled = true;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string CategoryID = "NULL", SanfName = "N'" + TxtSanfName.Text.Trim() + "'", CompanyID = "NULL", CostPrice = "NULL", MinimumPrice = "NULL", TagzeaUnit = "NULL", TagzeaEqual = "NULL", TagzeaSellprice = "NULL", GomlaUnit = "NULL", GomlaEqual = "NULL", GomlaSellprice = "NULL", ReOrder = "NULL", rem = "NULL";
            if (LUECategory.EditValue != null)
                CategoryID = LUECategory.EditValue.ToString();
            if (LUECompany.EditValue != null)
                CompanyID = LUECompany.EditValue.ToString();
            if (TxtPrice.Text.Trim().Length != 0)
                CostPrice = TxtPrice.Text.Trim();
            if (TxtMinPrice.Text.Trim().Length != 0)
                MinimumPrice = TxtMinPrice.Text.Trim();
            if (TxtReOrder.Text.Trim().Length != 0)
                ReOrder = TxtReOrder.Text.Trim();
            if (MemRem.Text.Trim().Length != 0)
                rem = "N'" + MemRem.Text.Trim() + "'";
            if (LUETagzeaUnit.EditValue != null)
                TagzeaUnit = LUETagzeaUnit.EditValue.ToString();
            if (TxtTagzeaEqual.Text.Trim().Length != 0)
                TagzeaEqual = TxtTagzeaEqual.Text.Trim();
            if (TxtTagzeaSellprice.Text.Trim().Length != 0)
                TagzeaSellprice = TxtTagzeaSellprice.Text.Trim();
            if (LUEGomlaUnit.EditValue != null)
                GomlaUnit = LUEGomlaUnit.EditValue.ToString();
            if (TxtGomlaEqual.Text.Trim().Length != 0)
                GomlaEqual = TxtGomlaEqual.Text.Trim();
            if (TxtGomlaSellprice.Text.Trim().Length != 0)
                GomlaSellprice = TxtGomlaSellprice.Text.Trim();
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand("INSERT INTO CDASNAF (SanfID, CategoryID, SanfName, CompanyID, CostPrice, MinimumPrice, TagzeaUnit, TagzeaEqual, TagzeaSellprice, GomlaUnit, GomlaEqual, GomlaSellprice, ReOrder, rem) VALUES (" + MCls.GetNewID("CDASNAF", "SanfID") + ", " + CategoryID + ", " + SanfName + ", " + CompanyID + ", " + CostPrice + ", " + MinimumPrice + ", " + TagzeaUnit + ", " + TagzeaEqual + ", " + TagzeaSellprice + ", " + GomlaUnit + ", " + GomlaEqual + ", " + GomlaSellprice + ", " + ReOrder + ", " + rem + ")", Con);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                MessageBox.Show("تم اضافة الصنــــف", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            Con.Close();

        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            if (MCls.DeleteRow("CDASNAF", "SanfID", AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["SanfID"].ToString()))
            {
                //gridView1.DeleteSelectedRows();
                LoadGridData();
                MessageBox.Show("تم حذف الصنــــف", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void repositoryItemButtonEditUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            string CategoryID = "NULL", SanfName = "NULL", CompanyID = "NULL", CostPrice = "NULL", MinimumPrice = "NULL", TagzeaUnit = "NULL", TagzeaEqual = "NULL", TagzeaSellprice = "NULL", GomlaUnit = "NULL", GomlaEqual = "NULL", GomlaSellprice = "NULL", ReOrder = "NULL", rem = "NULL";
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["CategoryID"].ToString() != string.Empty)
                CategoryID = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["CategoryID"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["SanfName"].ToString() != string.Empty)
                SanfName = "N'" + AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["SanfName"].ToString() + "'";
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["CompanyID"].ToString() != string.Empty)
                CompanyID = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["CompanyID"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["CostPrice"].ToString() != string.Empty)
                CostPrice = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["CostPrice"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MinimumPrice"].ToString() != string.Empty)
                MinimumPrice = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MinimumPrice"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["ReOrder"].ToString() != string.Empty)
                ReOrder = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["ReOrder"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["rem"].ToString() != string.Empty)
                rem = "N'" + AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["rem"].ToString() + "'";
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TagzeaUnit"].ToString() != string.Empty)
                TagzeaUnit = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TagzeaUnit"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TagzeaEqual"].ToString() != string.Empty)
                TagzeaEqual = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TagzeaEqual"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TagzeaSellprice"].ToString() != string.Empty)
                TagzeaSellprice = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TagzeaSellprice"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["GomlaUnit"].ToString() != string.Empty)
                GomlaUnit = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["GomlaUnit"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["GomlaEqual"].ToString() != string.Empty)
                GomlaEqual = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["GomlaEqual"].ToString();
            if (AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["GomlaSellprice"].ToString() != string.Empty)
                GomlaSellprice = AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["GomlaSellprice"].ToString();
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Cmd.CommandText = "UPDATE CDASNAF SET CategoryID = " + CategoryID + ", SanfName = " + SanfName + ", CompanyID = " + CompanyID + ", CostPrice = " + CostPrice + ", MinimumPrice = " + MinimumPrice + ", TagzeaUnit = " + TagzeaUnit + ", TagzeaEqual = " + TagzeaEqual + ", TagzeaSellprice = " + TagzeaSellprice + ", GomlaUnit = " + GomlaUnit + ", GomlaEqual = " + GomlaEqual + ", GomlaSellprice = " + GomlaSellprice + ", ReOrder = " + ReOrder + ", rem = " + rem + " WHERE (SanfID = " + AsnafGridTbl.Rows[gridView1.GetFocusedDataSourceRowIndex()]["SanfID"].ToString() + ")";
                Con.Open();
                Cmd.ExecuteNonQuery();
                LoadGridData();
                MessageBox.Show("تم حفظ التعديل", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (e.Page == xtraTabPage2)
                LoadGridData();
        }
    }
}