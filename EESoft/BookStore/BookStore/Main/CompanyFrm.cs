using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace BookStore
{
    public partial class CompanyFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        #region -   Functions   -
        public CompanyFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dt = FXFW.SqlDB.LoadDataTable(@"SELECT [CompanyID]
                                                          ,[Company]
                                                          ,[CompanyOfficial]
                                                          ,[CompanyAddess]
                                                          ,[CompanyTel]
                                                          ,[CompanyMobil]
                                                          ,[CompanyFax]
                                                          ,[remark]
                                                          ,[Logo]
                                                    FROM [CDCompany]");
            if (dt.Rows.Count == 0)
            {
                tbCompany.Text = string.Empty;
                tbCompanyOfficial.Text = string.Empty;
                tbCompanyAddess.Text = string.Empty;
                tbCompanyTel.Text = string.Empty;
                tbCompanyMobil.Text = string.Empty;
                tbCompanyFax.Text = string.Empty;
                tbremark.Text = string.Empty;
                peLogo.Image = null;
            }
            else
            {
                DataRow row = dt.Rows[0];

                tbCompany.Text = row["Company"].ToString();
                tbCompanyOfficial.Text = row["CompanyOfficial"].ToString();
                tbCompanyAddess.Text = row["CompanyAddess"].ToString();
                tbCompanyTel.Text = row["CompanyTel"].ToString();
                tbCompanyMobil.Text = row["CompanyMobil"].ToString();
                tbCompanyFax.Text = row["CompanyFax"].ToString();
                tbremark.Text = row["remark"].ToString();
                peLogo.EditValue = row["Logo"];
            }
        }
        #endregion
        #region - Event Handlers -
        private void CompanyFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.Parameters.Add(new SqlParameter("Company", SqlDbType.NVarChar) { Value = tbCompany.Text });
                cmd.Parameters.Add(new SqlParameter("CompanyOfficial", SqlDbType.NVarChar) { Value = tbCompanyOfficial.Text });
                cmd.Parameters.Add(new SqlParameter("CompanyAddess", SqlDbType.NVarChar) { Value = tbCompanyAddess.Text });
                cmd.Parameters.Add(new SqlParameter("CompanyTel", SqlDbType.NVarChar) { Value = tbCompanyTel.Text });
                cmd.Parameters.Add(new SqlParameter("CompanyMobil", SqlDbType.NVarChar) { Value = tbCompanyMobil.Text });
                cmd.Parameters.Add(new SqlParameter("CompanyFax", SqlDbType.NVarChar) { Value = tbCompanyFax.Text });
                cmd.Parameters.Add(new SqlParameter("remark", SqlDbType.NVarChar) { Value = tbremark.Text });
                
                if (!FXFW.SqlDB.IsNullOrEmpty(peLogo.Image))
                {
                    byte[] SchoolLogo = null;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    peLogo.Image.Save(ms, peLogo.Image.RawFormat);
                    SchoolLogo = ms.GetBuffer();
                    cmd.Parameters.Add(new SqlParameter("Logo", SqlDbType.Image) { Value = SchoolLogo });
                }
                else
                    cmd.Parameters.Add(new SqlParameter("Logo", SqlDbType.Image) { Value = DBNull.Value });

                cmd.CommandText = @"UPDATE CDCompany SET Company = @Company, CompanyOfficial = @CompanyOfficial, CompanyAddess = @CompanyAddess,
                CompanyTel = @CompanyTel, CompanyMobil = @CompanyMobil, CompanyFax = @CompanyFax, remark = @remark, Logo = @Logo";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ", "تمت العمليــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطـــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        #endregion

        

        
    }
}