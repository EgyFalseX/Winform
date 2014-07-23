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
    public partial class EditorJobDescriptionFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ParentsItemsTbl = new DataTable("ParentsItems");
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ParentsItemsTbl = new DataTable("ParentsItems"); ;
            ParentsItemsTbl = Program.MC.LoadDataTable("SELECT job_id, job FROM CD_job", Program.MC.SQLConStrMalafat);
            LUEItemsParents.Properties.DataSource = ParentsItemsTbl;
            LUEItemsParents.Properties.DisplayMember = "job";
            LUEItemsParents.Properties.ValueMember = "job_id";
            if (ParentsItemsTbl.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجــد وظائـــف", "البيانات غير متاحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
        }
        public EditorJobDescriptionFrm()
        {
            InitializeComponent();
        }
        private void LoadChildData()
        {
            ItemsTbl = new DataTable("Items");
            if (LUEItemsParents.ItemIndex > -1)
            {
                ItemsTbl = Program.MC.LoadDataTable("SELECT Job_Dis_ID, Job_DisName FROM CD_Job_Dis Where job_id = " + ParentsItemsTbl.Rows[LUEItemsParents.ItemIndex]["job_id"].ToString(), Program.MC.SQLConStrMalafat);
            }
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "Job_DisName";
            LUEItems.Properties.ValueMember = "Job_Dis_ID";
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex == -1)
            {
                 MessageBox.Show("من فضلك اختار الوصــف اولا", "البيانات غير متاحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CD_Job_Dis WHERE (Job_Dis_ID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadChildData();
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
                MessageBox.Show("من فضلك اختار الوظيفه اولا", "البيانات غير متاحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CD_Job_Dis  (Job_DisName, job_id) VALUES (N'{0}', {1})", TxtNewItem.Text.Trim(), ParentsItemsTbl.Rows[LUEItemsParents.ItemIndex]["job_id"].ToString()), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadChildData();
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
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CD_Job_Dis SET Job_DisName = N'{0}' WHERE (Job_Dis_ID = {1})", TxtEditItem.Text.Trim(), LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadChildData();
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
            LoadChildData();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorJobDescriptionFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}