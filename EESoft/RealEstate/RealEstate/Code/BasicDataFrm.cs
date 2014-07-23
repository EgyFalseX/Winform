using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;


namespace RealEstate
{
    public partial class BasicDataFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable CompanyDataTbl = new DataTable();
        #endregion
        #region -   Functions   -
        public BasicDataFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            CompanyDataTbl = new DataTable();
            CompanyDataTbl = MyCL.LoadDataTable(@"SELECT CompanyAr, CompanyEn, ActivityAr, ActivityEn, CommercialAr, 
            CommercialEn, tel, mobil, AddressAr, AddressEn, Logopath FROM BasicData");
            if (CompanyDataTbl.Rows.Count != 0)
            {
                DataRow row = CompanyDataTbl.Rows[0];
                TxtCompanyAr.Text = row["CompanyAr"].ToString();
                TxtCompanyEn.Text = row["CompanyEn"].ToString();
                TxtActivityAr.Text = row["ActivityAr"].ToString();
                TxtActivityEn.Text = row["ActivityEn"].ToString();
                TxtCommercialAr.Text = row["CommercialAr"].ToString();
                TxtCommercialEn.Text = row["CommercialEn"].ToString();
                Txttel.Text = row["tel"].ToString();
                Txtmobil.Text = row["mobil"].ToString();
                TxtAddressAr.Text = row["AddressAr"].ToString();
                TxtAddressEn.Text = row["AddressEn"].ToString();
                PBImage.ImageLocation = row["Logopath"].ToString();
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
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            string CompanyAr;
            if (TxtCompanyAr.Text.Trim().Length != 0)
                CompanyAr = String.Format("'{0}'", MyCL.CleanSQLValue(TxtCompanyAr.Text.Trim()));
            else
                CompanyAr = "NULL";
            string CompanyEn;
            if (TxtCompanyEn.Text.Trim().Length != 0)
                CompanyEn = String.Format("'{0}'", MyCL.CleanSQLValue(TxtCompanyEn.Text.Trim()));
            else
                CompanyEn = "NULL";
            string ActivityAr;
            if (TxtActivityAr.Text.Trim().Length != 0)
                ActivityAr = String.Format("'{0}'", MyCL.CleanSQLValue(TxtActivityAr.Text.Trim()));
            else
                ActivityAr = "NULL";
            string ActivityEn;
            if (TxtActivityEn.Text.Trim().Length != 0)
                ActivityEn = String.Format("'{0}'", MyCL.CleanSQLValue(TxtActivityEn.Text.Trim()));
            else
                ActivityEn = "NULL";
            string CommercialAr;
            if (TxtCommercialAr.Text.Trim().Length != 0)
                CommercialAr = String.Format("'{0}'", MyCL.CleanSQLValue(TxtCommercialAr.Text.Trim()));
            else
                CommercialAr = "NULL";
            string CommercialEn;
            if (TxtCommercialEn.Text.Trim().Length != 0)
                CommercialEn = String.Format("'{0}'", MyCL.CleanSQLValue(TxtCommercialEn.Text.Trim()));
            else
                CommercialEn = "NULL";
            string tel;
            if (Txttel.Text.Trim().Length != 0)
                tel = String.Format("'{0}'", MyCL.CleanSQLValue(Txttel.Text.Trim()));
            else
                tel = "NULL";
            string mobil;
            if (Txtmobil.Text.Trim().Length != 0)
                mobil = String.Format("'{0}'", MyCL.CleanSQLValue(Txtmobil.Text.Trim()));
            else
                mobil = "NULL";
            string AddressAr;
            if (TxtAddressAr.Text.Trim().Length != 0)
                AddressAr = String.Format("'{0}'", MyCL.CleanSQLValue(TxtAddressAr.Text.Trim()));
            else
                AddressAr = "NULL";
            string AddressEn;
            if (TxtAddressEn.Text.Trim().Length != 0)
                AddressEn = String.Format("'{0}'", MyCL.CleanSQLValue(TxtAddressEn.Text.Trim()));
            else
                AddressEn = "NULL";
            string Logopath;
            if (PBImage.ImageLocation != string.Empty)
                Logopath = String.Format("'{0}'", MyCL.CleanSQLValue(PBImage.ImageLocation));
            else
                Logopath = "NULL";

            try
            {
                con.Open();
                cmd.CommandText = "Delete From BASICDATA";
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format(@"INSERT INTO BasicData
                (CompanyAr, CompanyEn, ActivityAr, ActivityEn, CommercialAr, CommercialEn, tel, mobil, AddressAr, AddressEn, Logopath)
                VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", CompanyAr, CompanyEn, ActivityAr, ActivityEn, CommercialAr,
                CommercialEn, tel, mobil, AddressAr, AddressEn, Logopath);
                
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message , true, this);
            }
            con.Close();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(MyCL.PicPath))
                    Directory.CreateDirectory(MyCL.PicPath);
                string newPath = MyCL.PicPath + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + OFD.SafeFileName;
                File.Copy(OFD.FileName, newPath);
                PBImage.ImageLocation = OFD.FileName;
            }
        }
        #endregion
    }
}