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
    public partial class TBLTrainersBagFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TBLTrainersBagFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            //TBLTrainee
            repositoryItemGridLookUpEditTrainerID.DataSource = MyCL.LoadDataTable("Select TrainerID, TrainerName From TBLTrainers");
            repositoryItemGridLookUpEditTrainerID.ValueMember = "TrainerID";
            repositoryItemGridLookUpEditTrainerID.DisplayMember = "TrainerName";
            //CDReservationWay
            repositoryItemGridLookUpEditTrainingBagId.DataSource = MyCL.LoadDataTable(@"Select TrainingBagId, TrainingBag From CDTrainingBag");
            repositoryItemGridLookUpEditTrainingBagId.ValueMember = "TrainingBagId";
            repositoryItemGridLookUpEditTrainingBagId.DisplayMember = "TrainingBag";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select TrainerID, TrainingBagId, DateAdoption, 
            AdoptionValue, AdoptionNo, TrainingBagId AS TrainingBagId_Org, TrainerID AS TrainerID_Org, Adoption, AdoptionRemark From TBLTrainersBag");
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
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["TrainerID"].ToString() == string.Empty || Row["TrainingBagId"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("بيانات غير مكتمله", true, this);
                return;
            }
            string TrainerID;
            if (Row["TrainerID"].ToString() == string.Empty)
                TrainerID = "NULL";
            else
                TrainerID = Row["TrainerID"].ToString();

            string TrainingBagId;
            if (Row["TrainingBagId"].ToString() == string.Empty)
                TrainingBagId = "NULL";
            else
                TrainingBagId = Row["TrainingBagId"].ToString();

            string AdoptionValue;
            if (Row["AdoptionValue"].ToString() == string.Empty)
                AdoptionValue = "0";
            else
                AdoptionValue = Row["AdoptionValue"].ToString();

            string DateAdoption;
            if (Row["DateAdoption"].ToString() == string.Empty)
                DateAdoption = "NULL";
            else
                DateAdoption = string.Format(@"Convert(Datetime, '{0}', 103)", MyCL.ConvertToDateDMY(Row["DateAdoption"].ToString()));
            string AdoptionRemark;
            if (Row["AdoptionRemark"].ToString() == string.Empty)
                AdoptionRemark = "NULL";
            else
                AdoptionRemark = string.Format("N'{0}'", Row["AdoptionRemark"]);

            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    string AdoptionNo = MyCL.LoadDataTable("Select Isnull(MembershipNo, '') From TBLTrainers Where TrainerID = " + TrainerID).Rows[0][0] + MyCL.GetNewID("TBLTrainersBag", "ID");
                    if (Row["TrainingBagId_Org"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"INSERT INTO TBLTrainersBag (TrainerID, TrainingBagId, DateAdoption, AdoptionValue, Adoption, AdoptionRemark, AdoptionNo)
                                VALUES ({0}, {1}, {2}, {3}, '{4}', {5}, N'{6}')", TrainerID, TrainingBagId, DateAdoption, AdoptionValue, Row["Adoption"], AdoptionRemark, AdoptionNo);
                    else
                        cmd.CommandText = string.Format(@"UPDATE TBLTrainersBag SET TrainerID = {0}, TrainingBagId = {1}, DateAdoption = {2}, AdoptionValue = {3}, Adoption = '{4}', AdoptionRemark = {5}
                                 Where TrainerID = {6} And TrainingBagId = {7}", TrainerID, TrainingBagId, DateAdoption, AdoptionValue, Row["Adoption"], AdoptionRemark, Row["TrainerID_Org"], Row["TrainingBagId_Org"]);
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
            if (Row["TrainingBagId_Org"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"Delete From TBLTrainersBag Where TrainerID = {0} And TrainingBagId = {1}",
                Row["TrainerID_Org"], Row["TrainingBagId_Org"]);
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