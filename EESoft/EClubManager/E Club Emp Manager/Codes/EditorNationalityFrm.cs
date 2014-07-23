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
    public partial class EditorNationalityFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable NationsTbl = new DataTable("Nations");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            NationsTbl = new DataTable("Nations");
            NationsTbl = Program.MC.LoadDataTable("SELECT Nationality_id, Nationality FROM CD_Nationality", Program.MC.SQLConStrMalafat);
            LUECountries.Properties.DataSource = NationsTbl;
            LUECountries.Properties.DisplayMember = "Nationality";
            LUECountries.Properties.ValueMember = "Nationality_id";
        }
        public EditorNationalityFrm()
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
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CD_Nationality WHERE (Nationality_id = {0})", LUECountries.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUECountries.ItemIndex = -1;
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
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CD_Nationality  (Nationality) VALUES (N'{0}')", TxtNewCountry.Text.Trim()), Con);
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
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CD_Nationality SET Nationality = N'{0}' WHERE (Nationality_id = {1})", TxtEditCountry.Text.Trim(), LUECountries.EditValue), Con);
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
        private void TxtNewCountry_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewCountry.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditCountry_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditCountry.Text.Trim().Length > 0 && LUECountries.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUECountries_EditValueChanged(object sender, EventArgs e)
        {
            if (LUECountries.ItemIndex > -1)
            {
                TxtEditCountry.Text = LUECountries.Text;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditCountry.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorNationalityFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}