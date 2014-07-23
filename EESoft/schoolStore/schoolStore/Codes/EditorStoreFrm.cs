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
    public partial class EditorStoreFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable StoreTbl = new DataTable("StoreTable");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            StoreTbl = new DataTable("SalesUnitTable");
            StoreTbl = FXFW.SqlDB.LoadDataTable("SELECT StoreID, StoreName, StorePlace, StoreOfficial, StoreTel, StoreMobil, StoreFax, remark FROM CDSTORE");
            LUEItems.Properties.DataSource = StoreTbl;
            LUEItems.Properties.DisplayMember = "StoreName";
            LUEItems.Properties.ValueMember = "StoreID";
        }
        public EditorStoreFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDSTORE WHERE (StoreID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEItems.ItemIndex = -1;
                    MessageBox.Show("تم الحـــذف ", "حـــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                string StorePlace = "NULL", StoreOfficial = "NULL", StoreTel = "NULL", StoreMobil = "NULL", StoreFax = "NULL", remark = "NULL";
                if (TxtNewPlace.Text.Trim().Length > 0)
                    StorePlace = "N'" + TxtNewPlace.Text.Trim() + "'";
                if (TxtNewOfficial.Text.Trim().Length > 0)
                    StoreOfficial = "N'" + TxtNewOfficial.Text.Trim() + "'";
                if (TxtNewPhone.Text.Trim().Length > 0)
                    StoreTel = "N'" + TxtNewPhone.Text.Trim() + "'";
                if (TxtNewMobile.Text.Trim().Length > 0)
                    StoreMobil = "N'" + TxtNewMobile.Text.Trim() + "'";
                if (TxtNewFax.Text.Trim().Length > 0)
                    StoreFax = "N'" + TxtNewFax.Text.Trim() + "'";
                if (TxtNewNote.Text.Trim().Length > 0)
                    remark = "N'" + TxtNewNote.Text.Trim() + "'";
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDSTORE  (StoreID, StoreName, StorePlace, StoreOfficial, StoreTel, StoreMobil, StoreFax, remark) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7})", Program.GetNewID("CDSTORE", "StoreID"), TxtNewName.Text.Trim(), StorePlace, StoreOfficial, StoreTel, StoreMobil, StoreFax, remark), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم الاضــــافه", "اضافــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                string StorePlace = "NULL", StoreOfficial = "NULL", StoreTel = "NULL", StoreMobil = "NULL", StoreFax = "NULL", remark = "NULL";
                if (TxtEditPlace.Text.Trim().Length > 0)
                    StorePlace = "N'" + TxtEditPlace.Text.Trim() + "'";
                if (TxtEditOfficial.Text.Trim().Length > 0)
                    StoreOfficial = "N'" + TxtEditOfficial.Text.Trim() + "'";
                if (TxtEditPhone.Text.Trim().Length > 0)
                    StoreTel = "N'" + TxtEditPhone.Text.Trim() + "'";
                if (TxtEditMobile.Text.Trim().Length > 0)
                    StoreMobil = "N'" + TxtEditMobile.Text.Trim() + "'";
                if (TxtEditFax.Text.Trim().Length > 0)
                    StoreFax = "N'" + TxtEditFax.Text.Trim() + "'";
                if (TxtEditNote.Text.Trim().Length > 0)
                    remark = "N'" + TxtEditNote.Text.Trim() + "'";
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDSTORE SET StoreName = N'{0}',StorePlace = {1}, StoreOfficial = {2}, StoreTel = {3}, StoreMobil = {4}, StoreFax = {5}, remark = {6} WHERE (StoreID = {7})", TxtEditName.Text.Trim(), StorePlace, StoreOfficial, StoreTel, StoreMobil, StoreFax, remark, LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم التعــــديل ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorStoreFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditName.Text = StoreTbl.Rows[LUEItems.ItemIndex]["StoreName"].ToString();
                TxtEditPlace.Text = StoreTbl.Rows[LUEItems.ItemIndex]["StorePlace"].ToString();
                TxtEditOfficial.Text = StoreTbl.Rows[LUEItems.ItemIndex]["StoreOfficial"].ToString();
                TxtEditPhone.Text = StoreTbl.Rows[LUEItems.ItemIndex]["StoreTel"].ToString();
                TxtEditMobile.Text = StoreTbl.Rows[LUEItems.ItemIndex]["StoreMobil"].ToString();
                TxtEditFax.Text = StoreTbl.Rows[LUEItems.ItemIndex]["StoreFax"].ToString();
                TxtEditNote.Text = StoreTbl.Rows[LUEItems.ItemIndex]["remark"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditName.Text = string.Empty;
                TxtEditPlace.Text = string.Empty;
                TxtEditOfficial.Text = string.Empty;
                TxtEditPhone.Text = string.Empty;
                TxtEditMobile.Text = string.Empty;
                TxtEditFax.Text = string.Empty;
                TxtEditNote.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void TxtEditName_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditName.Text.Trim().Length > 0 && LUEItems.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void TxtNewName_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewName.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        #endregion
    }
}