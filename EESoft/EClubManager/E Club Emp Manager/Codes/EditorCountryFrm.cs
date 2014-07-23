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
    public partial class EditorCountryFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable CitiesTbl = new DataTable("Cities");
        #endregion
        #region -   Functions   -

        private void LoadData()
        {
            CitiesTbl = new DataTable("Cities");
            CitiesTbl = Program.MC.LoadDataTable("SELECT GOV_ID, GOV_NAME FROM CDR_GOV", Program.MC.SQLConStrMalafat);
            LUECities.Properties.DataSource = CitiesTbl;
            LUECities.Properties.DisplayMember = "GOV_NAME";
            LUECities.Properties.ValueMember = "GOV_ID";
        }
        public EditorCountryFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟","تأكــــيد",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;   
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDR_GOV WHERE (GOV_ID = {0})", LUECities.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUECities.ItemIndex = -1;
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
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDR_GOV  (GOV_NAME) VALUES (N'{0}')", TxtNewCity.Text.Trim()), Con);
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
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDR_GOV SET GOV_NAME = N'{0}' WHERE (GOV_ID = {1})", TxtEditCity.Text.Trim(), LUECities.EditValue), Con);
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
        private void TxtNewCity_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewCity.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditCity_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditCity.Text.Trim().Length > 0 && LUECities.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUECities_EditValueChanged(object sender, EventArgs e)
        {
            if (LUECities.ItemIndex > -1)
            {
                TxtEditCity.Text = LUECities.Text;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditCity.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void AddCountryFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

    }
}