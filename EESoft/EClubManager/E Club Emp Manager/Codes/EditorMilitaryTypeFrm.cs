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
    public partial class EditorMilitaryTypeFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable MilitaryTypesTbl = new DataTable("MilitaryTypes");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            MilitaryTypesTbl = new DataTable("MilitaryTypes");
            MilitaryTypesTbl = Program.MC.LoadDataTable("SELECT tagned_id, tagned FROM CD_tagneed", Program.MC.SQLConStrMalafat);
            LUEMilitaryTypes.Properties.DataSource = MilitaryTypesTbl;
            LUEMilitaryTypes.Properties.DisplayMember = "tagned";
            LUEMilitaryTypes.Properties.ValueMember = "tagned_id";
        }
        public EditorMilitaryTypeFrm()
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
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CD_tagneed WHERE (tagned_id = {0})", LUEMilitaryTypes.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEMilitaryTypes.ItemIndex = -1;
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
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CD_tagneed  (tagned) VALUES (N'{0}')", TxtNewMilitaryTypes.Text.Trim()), Con);
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
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CD_tagneed SET tagned = N'{0}' WHERE (tagned_id = {1})", TxtEditMilitaryType.Text.Trim(), LUEMilitaryTypes.EditValue), Con);
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
        private void TxtNewMilitaryTypes_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewMilitaryTypes.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditMilitaryType_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditMilitaryType.Text.Trim().Length > 0 && LUEMilitaryTypes.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUEMilitaryTypes_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEMilitaryTypes.ItemIndex > -1)
            {
                TxtEditMilitaryType.Text = LUEMilitaryTypes.Text;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditMilitaryType.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void MilitaryTypeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}