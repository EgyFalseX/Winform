using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace RealEstate
{
    public partial class TblOwnerFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TblOwnerFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            repositoryItemGridLookUpEditCdAreaId.DataSource = MyCL.LoadDataTable("Select CdAreaId, CdArea From CdArea");
            repositoryItemGridLookUpEditCdAreaId.ValueMember = "CdAreaId";
            repositoryItemGridLookUpEditCdAreaId.DisplayMember = "CdArea";
            repositoryItemGridLookUpEditownertypeid.DataSource = MyCL.LoadDataTable("Select ownertypeid, ownertype From cdownertype");
            repositoryItemGridLookUpEditownertypeid.ValueMember = "ownertypeid";
            repositoryItemGridLookUpEditownertypeid.DisplayMember = "ownertype";
            repositoryItemGridLookUpEditnationaltyid.DataSource = MyCL.LoadDataTable("Select nationaltyid, nationalty From cdnationalty");
            repositoryItemGridLookUpEditnationaltyid.ValueMember = "nationaltyid";
            repositoryItemGridLookUpEditnationaltyid.DisplayMember = "nationalty";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"Select OwnerId, ownertypeid, nationaltyid, Owner, CdAreaId, OwnerTel, OwnerMobil, OwnerAddress, OwnerHafeza, HafezaIn, segel, 
            datein, userin From TblOwner");
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
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            string CdAreaId;
            if (Row["CdAreaId"].ToString() != string.Empty)
                CdAreaId = Row["CdAreaId"].ToString();
            else
                CdAreaId = "NULL";
            string ownertypeid;
            if (Row["ownertypeid"].ToString() != string.Empty)
                ownertypeid = Row["ownertypeid"].ToString();
            else
                ownertypeid = "NULL";
            string nationaltyid;
            if (Row["nationaltyid"].ToString() != string.Empty)
                nationaltyid = Row["nationaltyid"].ToString();
            else
                nationaltyid = "NULL";
            try
            {
                if (Row["OwnerId"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    string NewID = MyCL.GetNewID("TblOwner", "OwnerId");
                    cmd.CommandText = string.Format(@"Insert Into TblOwner (OwnerId, Owner, CdAreaId, OwnerTel, OwnerMobil, OwnerAddress, OwnerHafeza, HafezaIn, segel,  datein, userin, ownertypeid, nationaltyid) VALUES 
                    ({0}, '{1}', {2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', NOW(), {9}, {10}, {11})", NewID, MyCL.CleanSQLValue(Row["Owner"].ToString()), CdAreaId, MyCL.CleanSQLValue(Row["OwnerTel"].ToString()), MyCL.CleanSQLValue(Row["OwnerMobil"].ToString()), MyCL.CleanSQLValue(Row["OwnerAddress"].ToString()),
                    MyCL.CleanSQLValue(Row["OwnerHafeza"].ToString()), MyCL.CleanSQLValue(Row["HafezaIn"].ToString()), MyCL.CleanSQLValue(Row["segel"].ToString()), MyCL.UserInfo.UserID, ownertypeid, nationaltyid);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE TblOwner SET Owner = '{0}', CdAreaId = {1}, OwnerTel = '{2}', OwnerMobil = '{3}', OwnerAddress = '{4}', 
                    OwnerHafeza = '{5}', HafezaIn = '{6}', segel = '{7}', datein = NOW(), userin = {8}, ownertypeid = {9}, nationaltyid = {10} WHERE (TblOwner.OwnerId = {11})", MyCL.CleanSQLValue(Row["Owner"].ToString()),
                    CdAreaId, MyCL.CleanSQLValue(Row["OwnerTel"].ToString()), MyCL.CleanSQLValue(Row["OwnerMobil"].ToString()), MyCL.CleanSQLValue(Row["OwnerAddress"].ToString()), MyCL.CleanSQLValue(Row["OwnerHafeza"].ToString()),
                    MyCL.CleanSQLValue(Row["HafezaIn"].ToString()), MyCL.CleanSQLValue(Row["segel"].ToString()), MyCL.UserInfo.UserID, ownertypeid, nationaltyid, Row["OwnerId"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message , true, this);
            }
            con.Close();
            LoadData();
            
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["OwnerId"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From TblOwner Where OwnerId = " + Row["OwnerId"];
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message , true, this);
            }
            con.Close();
            LoadData();
        }
        #endregion
    }
}