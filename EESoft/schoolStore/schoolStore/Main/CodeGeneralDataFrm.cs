using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;


namespace schoolStore
{
    public partial class CodeGeneralDataFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable CompanyDataTbl = new DataTable();
        #endregion
        #region -   Functions   -
        public CodeGeneralDataFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            CompanyDataTbl = new DataTable();
            CompanyDataTbl = FXFW.SqlDB.LoadDataTable(@"SELECT company_name_a, company_name_e, phone_1, phone_2, phone_3, mobile,
                                                        fax, email, StartingDate, compLogo, adress_a, adress_e, Password 
                                                        FROM ProductOwnerInfo");
            if (CompanyDataTbl.Rows.Count != 0)
            {
                TxtArName.Text = CompanyDataTbl.Rows[0]["company_name_a"].ToString();
                TxtEnName.Text = CompanyDataTbl.Rows[0]["company_name_e"].ToString();
                TxtPhone1.Text = CompanyDataTbl.Rows[0]["phone_1"].ToString();
                TxtPhone2.Text = CompanyDataTbl.Rows[0]["phone_2"].ToString();
                TxtPhone3.Text = CompanyDataTbl.Rows[0]["phone_3"].ToString();
                TxtMobile.Text = CompanyDataTbl.Rows[0]["mobile"].ToString();
                TxtFax.Text = CompanyDataTbl.Rows[0]["fax"].ToString();
                TxtEMail.Text = CompanyDataTbl.Rows[0]["email"].ToString();
                if (CompanyDataTbl.Rows[0]["StartingDate"] == DBNull.Value)
                    DEStartingDate.EditValue = null;
                else
                    DEStartingDate.EditValue = (DateTime)CompanyDataTbl.Rows[0]["StartingDate"];
                //PBImage.ImageLocation = CompanyDataTbl.Rows[0]["compLogo"].ToString();
                MemoryStream stream = new MemoryStream();
                byte[] compLogo = (byte[])CompanyDataTbl.Rows[0]["compLogo"];
                MemoryStream ms = new MemoryStream(compLogo);
                PBImage.Image = Image.FromStream(ms);
                TxtArAddress.Text = CompanyDataTbl.Rows[0]["adress_a"].ToString();
                TxtEnAddress.Text = CompanyDataTbl.Rows[0]["adress_e"].ToString();
                TxtPassword.Text = CompanyDataTbl.Rows[0]["Password"].ToString();
            }
        }
        #endregion
        #region -   Event Handlers   -
        private void CodeGeneralDataFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ..?!", "Update Confirmation..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlTransaction tr = null;
            SqlCommand cmd = new SqlCommand("", con);
            string company_name_a = "NULL", company_name_e = "NULL", phone_1 = "NULL", phone_2 = "NULL", phone_3 = "NULL", mobial = "NULL", fax = "NULL", email = "NULL", StartingDate = "NULL", adress_a = "NULL", adress_e = "NULL", Password = "NULL";
            if (TxtArName.Text.Trim().Length != 0)
                company_name_a = String.Format("N'{0}'", TxtArName.Text.Trim());
            if (TxtEnName.Text.Trim().Length != 0)
                company_name_e = String.Format("N'{0}'", TxtEnName.Text.Trim());
            if (TxtPhone1.Text.Trim().Length != 0)
                phone_1 = String.Format("N'{0}'", TxtPhone1.Text.Trim());
            if (TxtPhone2.Text.Trim().Length != 0)
                phone_2 = String.Format("N'{0}'", TxtPhone2.Text.Trim());
            if (TxtPhone3.Text.Trim().Length != 0)
                phone_3 = String.Format("N'{0}'", TxtPhone3.Text.Trim());
            if (TxtMobile.Text.Trim().Length != 0)
                mobial = String.Format("N'{0}'", TxtMobile.Text.Trim());
            if (TxtFax.Text.Trim().Length != 0)
                fax = String.Format("N'{0}'", TxtFax.Text.Trim());
            if (TxtEMail.Text.Trim().Length != 0)
                email = String.Format("N'{0}'", TxtEMail.Text.Trim());
            if (DEStartingDate.EditValue != null)
                StartingDate = String.Format("CONVERT(DATETIME, '{0}', 103)", DEStartingDate.EditValue);
            if (TxtArAddress.Text.Trim().Length != 0)
                adress_a = String.Format("N'{0}'", TxtArAddress.Text.Trim());
            if (TxtEnAddress.Text.Trim().Length != 0)
                adress_e = String.Format("N'{0}'", TxtEnAddress.Text.Trim());
            if (TxtPassword.Text.Trim().Length != 0)
                Password = String.Format("N'{0}'", TxtPassword.Text.Trim());
            string ImageLogo = null;
            if (PBImage.ImageLocation != string.Empty)
            {
                if (PBImage.ImageLocation.StartsWith(@"file:///"))
                    ImageLogo = PBImage.ImageLocation;
                else
                    ImageLogo = @"file:///" + PBImage.ImageLocation;
            }
            try
            {
                con.Open();
                tr = con.BeginTransaction();
                cmd.CommandText = "Delete From BASICDATA";
                cmd.Transaction = tr;
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format(@"INSERT INTO BASICDATA
                (company_code, company_name_a, company_name_e, phone_1, phone_2, phone_3, mobial, fax, email, StartingDate, adress_a, adress_e, [Password], compLogo)
                VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, @arrImage)", "1", company_name_a, company_name_e, phone_1, phone_2, phone_3, mobial, fax, email, StartingDate, adress_a, adress_e, Password);
                cmd.Parameters.AddWithValue("@arrImage", ImageLogo);
                cmd.ExecuteNonQuery();
                tr.Commit();
                Program.msg("Organization Information Saved ..", false, "", this);
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
                tr.Rollback();
            }
            con.Close();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                PBImage.ImageLocation = OFD.FileName;
        }
        #endregion
    }
}