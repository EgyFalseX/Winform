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
    public partial class TabTrainerOrderBagFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TabTrainerOrderBagFrm()
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
            GridTable = MyCL.LoadDataTable(@"Select OrderBagId, TrainerID, BagName, BagRemark, OrderDate From TabTrainerOrderBag");
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
            if (Row["TrainerID"].ToString() == string.Empty)
            {
                MyCL.ShowMsg("بيانات غير مكتمله", true, this);
                return;
            }
            string BagName;
            if (Row["BagName"].ToString() == string.Empty)
                BagName = "NULL";
            else
                BagName = string.Format("N'{0}'", Row["BagName"]);

            string BagRemark;
            if (Row["BagRemark"].ToString() == string.Empty)
                BagRemark = "NULL";
            else
                BagRemark = string.Format("N'{0}'", Row["BagRemark"]);
            string OrderDate;
            if (Row["OrderDate"].ToString() == string.Empty)
                OrderDate = "NULL";
            else
                OrderDate = string.Format(@"Convert(Datetime, '{0}', 103)", MyCL.ConvertToDateDMY(Row["OrderDate"].ToString()));
            

            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (Row["OrderBagId"].ToString() == string.Empty)// Is Unsaved Row?
                        cmd.CommandText = string.Format(@"INSERT INTO TabTrainerOrderBag (TrainerID, BagName, BagRemark, OrderDate)
                                VALUES ({0}, {1}, {2}, {3})", Row["TrainerID"], BagName, BagRemark, OrderDate);
                    else
                        cmd.CommandText = string.Format(@"UPDATE TabTrainerOrderBag SET TrainerID = {0}, BagName = {1}, BagRemark = {2}, OrderDate = {3} 
                                 Where OrderBagId = {4}", Row["TrainerID"], BagName, BagRemark, OrderDate, Row["OrderBagId"]);
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
            if (Row["OrderBagId"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"Delete From TabTrainerOrderBag Where OrderBagId = {0}", Row["OrderBagId"]);
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