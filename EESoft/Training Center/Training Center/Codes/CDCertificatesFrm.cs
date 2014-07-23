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
    public partial class CDCertificatesFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");


        #endregion
        #region -   Functions   -
        public CDCertificatesFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            repositoryItemGridLookUpEditCertificateFrom.DataSource = MyCL.LoadDataTable("Select PartnerID, Partner, Partnermobile, Partneremail From TBLPartners");
            repositoryItemGridLookUpEditCertificateFrom.ValueMember = "PartnerID";
            repositoryItemGridLookUpEditCertificateFrom.DisplayMember = "Partner";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable("Select CertificateID, Certificate, CertificateFrom, CertificateValue From CDCertificates");
            gridControlMain.DataSource = GridTable;
            gridControlMain.RefreshDataSource();
        }
#endregion
        #region -   Event Handlers   -
        private void FrmCdBankAccount_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            //this.Focus();
            //gridControlMain.Focus();
            //gridControlMain.RefreshDataSource();
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            //DataRow Row = GridTable.Rows[gridViewMain.GetFocusedDataSourceRowIndex()];
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();

            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                if (Row["CertificateID"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    string NewID = MyCL.GetNewID("CDCertificates", "CertificateID");
                    cmd.CommandText = string.Format(@"Insert Into CDCertificates (CertificateID, Certificate, CertificateFrom, CertificateValue) VALUES ({0}, '{1}', {2}, {3})",
                    NewID, Row["Certificate"], Row["CertificateFrom"], Row["CertificateValue"]);
                }
                else
                {
                    cmd.CommandText = string.Format(@"Update CDCertificates Set Certificate = '{0}', CertificateFrom = {1}, CertificateValue = {2} Where CertificateID = {3}",
                    Row["Certificate"], Row["CertificateFrom"], Row["CertificateValue"], Row["CertificateID"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ", false, this);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
            }
            con.Close();
            LoadData();
            
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Focus();
            //gridControlMain.Focus();
            //gridControlMain.RefreshDataSource();
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            //DataRow Row = GridTable.Rows[gridViewMain.GetFocusedDataSourceRowIndex()];
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["CertificateID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From CDCertificates Where CertificateID = " + Row["CertificateID"];
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
            }
            con.Close();
            LoadData();
        }
        #endregion
    }
}