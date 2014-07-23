using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Emp_Manager
{
    public partial class EditorSpecificationFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ParentsItemsTbl = new DataTable("ParentsItems");
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ParentsItemsTbl = new DataTable("ParentsItems");
            ParentsItemsTbl = Program.MC.LoadDataTable("SELECT Moaahel_ID, Moaahel_Name FROM CD_Moaahel", Program.MC.SQLConStrMalafat);
            LUEItemsParents.Properties.DataSource = ParentsItemsTbl;
            LUEItemsParents.Properties.DisplayMember = "Moaahel_Name";
            LUEItemsParents.Properties.ValueMember = "Moaahel_ID";
            if (ParentsItemsTbl.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجــد مؤهـــلات", "البيانات غير متاحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public EditorSpecificationFrm()
        {
            InitializeComponent();
        }
        private void LoadChild()
        {
            ItemsTbl = new DataTable("Items");
            if (LUEItemsParents.ItemIndex > -1)
            {
                ItemsTbl = Program.MC.LoadDataTable("SELECT SPECIFICATION_ID, SPECIFICATION_NAME FROM CDR_SPECIFICATION Where Moaahel_ID = " + ParentsItemsTbl.Rows[LUEItemsParents.ItemIndex]["Moaahel_ID"].ToString(), Program.MC.SQLConStrMalafat);
            }
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "SPECIFICATION_NAME";
            LUEItems.Properties.ValueMember = "SPECIFICATION_ID";
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex == -1)
            {
                MessageBox.Show("من فضلك اختار التخــصص اولا", "البيانات غير متاحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDR_SPECIFICATION WHERE (SPECIFICATION_ID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadChild();
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
            if (LUEItemsParents.ItemIndex == -1)
            {
                MessageBox.Show("من فضلك اختار التخصص اولا", "البيانات غير متاحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDR_SPECIFICATION  (SPECIFICATION_NAME, Moaahel_ID) VALUES (N'{0}', {1})", TxtNewItem.Text.Trim(), ParentsItemsTbl.Rows[LUEItemsParents.ItemIndex]["Moaahel_ID"].ToString()), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadChild();
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
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDR_SPECIFICATION SET SPECIFICATION_NAME = N'{0}' WHERE (SPECIFICATION_ID = {1})", TxtEditItem.Text.Trim(), LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadChild();
                    MessageBox.Show("تم التعــــديل ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TxtNewItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewItem.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditItem.Text.Trim().Length > 0 && LUEItems.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditItem.Text = LUEItems.Text;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditItem.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void LUEItemsParents_EditValueChanged(object sender, EventArgs e)
        {
            LoadChild();   
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorSpecificationFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}