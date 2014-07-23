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
    public partial class TBLMemberShipFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TBLMemberShipFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            //TBLTrainee
            repositoryItemGridLookUpEditTrainerID.DataSource = MyCL.LoadDataTable("Select TrainerID, TrainerName From TBLTrainers");
            repositoryItemGridLookUpEditTrainerID.ValueMember = "TrainerID";
            repositoryItemGridLookUpEditTrainerID.DisplayMember = "TrainerName";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select ID, TrainerID, MembershipFrom, 
            (Select MembershipType From CDMembershipType Where MembershipTypeID = (Select MembershipTypeID From TBLTrainers Where TrainerID = TBLMemberShip.TrainerID)) AS MembershipType,
            MembershipTo, MembershipValue From TBLMemberShip");
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
            if (Row["TrainerID"].ToString() == string.Empty || Row["MembershipFrom"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("بيانات غير مكتمله", true, this);
                return;
            }
            string MembershipFrom;
            if (Row["MembershipFrom"].ToString() == string.Empty)
                MembershipFrom = "NULL";
            else
                MembershipFrom = string.Format(@"Convert(Datetime, '{0}', 103)", MyCL.ConvertToDateDMY(Row["MembershipFrom"].ToString()));
            string MembershipTo;
            if (Row["MembershipTo"].ToString() == string.Empty)
                MembershipTo = "NULL";
            else
                MembershipTo = string.Format(@"Convert(Datetime, '{0}', 103)", MyCL.ConvertToDateDMY(Row["MembershipTo"].ToString()));
            string MembershipValue;
            if (Row["MembershipValue"].ToString() == string.Empty)
                MembershipValue = "0";
            else
                MembershipValue = Row["MembershipValue"].ToString();
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["ID"].ToString() == string.Empty)
                        // Is Unsaved Row?
                        cmd.CommandText = string.Format(@"INSERT INTO TBLMemberShip (TrainerID, MembershipFrom, MembershipTo, MembershipValue)
                        VALUES ({0}, {1}, {2}, {3})", Row["TrainerID"], MembershipFrom, MembershipTo, MembershipValue);
                    else
                        cmd.CommandText = string.Format(@"UPDATE TBLMemberShip SET TrainerID = {0}, MembershipFrom = {1}, MembershipTo = {2}, MembershipValue = {3}
                        WHERE ID = {4}", Row["TrainerID"], MembershipFrom, MembershipTo, MembershipValue, Row["ID"]);
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
            if (Row["ID"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"Delete From TBLMemberShip Where ID = {0}", Row["ID"]);
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