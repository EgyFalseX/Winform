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
    public partial class CD_AsaseFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable dataTbl = new DataTable();
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            dataTbl = new DataTable();
            dataTbl = FXFW.SqlDB.LoadDataTable("SELECT asase_code, asase_year FROM CD_Asase");
            LUEItems.Properties.DataSource = dataTbl;
            LUEItems.Properties.DisplayMember = "asase_year";
            LUEItems.Properties.ValueMember = "asase_code";
        }
        public CD_AsaseFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟","تأكــــيد",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;   
            using (SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM CD_Asase WHERE asase_code = " + LUEItems.EditValue, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
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
            if (tbcodeadd.Text == string.Empty || tbnameadd.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال الكود و الاسم", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = @"INSERT INTO dbo.CD_Asase
                                                ( asase_code, asase_year )
                                        VALUES  ( @asase_code, -- asase_code - int
                                                  @asase_year  -- asase_year - nvarchar(50)
                                                  )";
                    cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.Int) { Value = Convert.ToInt32(tbcodeadd.Text) });
                    cmd.Parameters.Add(new SqlParameter("@asase_year", SqlDbType.NVarChar) { Value = tbnameadd.Text });
                    con.Open();
                    cmd.ExecuteNonQuery();
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
            using (SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = @"UPDATE CD_Asase SET
		                                        asase_code = @asase_code, -- asase_code - int
		                                        asase_year = @asase_year  -- asase_year - nvarchar(50)
                                        WHERE asase_code = @org_asase_code";
                    cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.Int) { Value = Convert.ToInt32(tbcodeedit.Text) });
                    cmd.Parameters.Add(new SqlParameter("@asase_year", SqlDbType.NVarChar) { Value = tbnameedit.Text });
                    cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.Int) { Value = Convert.ToInt32(LUEItems.EditValue) });
                    con.Open();
                    cmd.ExecuteNonQuery();
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
        private void EditorEducationFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                DataRow row = ((System.Data.DataRowView)LUEItems.GetSelectedDataRow()).Row;

                tbcodeedit.Text = row["asase_code"].ToString();
                tbnameedit.Text = row["asase_year"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                tbcodeadd.Text = string.Empty;
                tbnameadd.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        #endregion
    }
}