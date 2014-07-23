using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Training_Center
{
    public partial class TBLPartnersFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TBLPartnersFrm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"SELECT PartnerID, Partner, PartnersAddres, Partnerphone, Partnermobile, Partnerfax, Partneremail, PartnerPerson 
            FROM TBLPartners");
            gridControlMain.DataSource = GridTable;
            gridControlMain.RefreshDataSource();
            
        }
#endregion
        #region -   Event Handlers   -
        private void FrmCdBankAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            string Partner;
            if (Row["Partner"].ToString() == string.Empty)
                Partner = "NULL";                
            else
                Partner = string.Format("N'{0}'", Row["Partner"]);
            string PartnersAddres;
            if (Row["PartnersAddres"].ToString() == string.Empty)
                PartnersAddres = "NULL";
            else
                PartnersAddres = string.Format("N'{0}'", Row["PartnersAddres"]);
            string Partnerphone;
            if (Row["Partnerphone"].ToString() == string.Empty)
                Partnerphone = "NULL";
            else
                Partnerphone = string.Format("N'{0}'", Row["Partnerphone"]);
            string Partnermobile;
            if (Row["Partnermobile"].ToString() == string.Empty)
                Partnermobile = "NULL";
            else
                Partnermobile = string.Format("N'{0}'", Row["Partnermobile"]);
            string Partnerfax;
            if (Row["Partnerfax"].ToString() == string.Empty)
                Partnerfax = "NULL";
            else
                Partnerfax = string.Format("N'{0}'", Row["Partnerfax"]);
            string Partneremail;
            if (Row["Partneremail"].ToString() == string.Empty)
                Partneremail = "NULL";
            else
                Partneremail = string.Format("N'{0}'", Row["Partneremail"]);
            string PartnerPerson;
            if (Row["PartnerPerson"].ToString() == string.Empty)
                PartnerPerson = "NULL";
            else
                PartnerPerson = string.Format("N'{0}'", Row["PartnerPerson"]);
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    string PartnerID = MyCL.GetNewID("TBLPartners", "PartnerID");
                    if (Row["PartnerID"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"INSERT INTO TBLPartners (PartnerID, Partner, PartnersAddres, Partnerphone, Partnermobile, Partnerfax, Partneremail, PartnerPerson)
                                VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", PartnerID, Partner, PartnersAddres, Partnerphone, Partnermobile, Partnerfax, Partneremail, PartnerPerson);
                    else
                        cmd.CommandText = string.Format(@"UPDATE TBLPartners SET Partner = {0}, PartnersAddres = {1}, Partnerphone = {2}, Partnermobile = {3}, 
                                Partnerfax = {4}, Partneremail = {5}, PartnerPerson = {6} WHERE PartnerID = {7}", Partner, PartnersAddres, Partnerphone, Partnermobile, Partnerfax, Partneremail, PartnerPerson, Row["PartnerID"]);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MyCL.ShowMsg("تم الحفظ", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
                con.Close();
            }
            LoadData();
            
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["PartnerID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = @"Delete From TBLPartners Where PartnerID = " + Row["PartnerID"];
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MyCL.ShowMsg("تم الحذف", false, this);
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
                con.Close();
            }
            LoadData();
        }
        #endregion
    }
}