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

namespace RealEstate
{
    public partial class BuyContractFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        DataTable GridSubTable = new DataTable("FalseX2011-09");
        #endregion
        #region -   Functions   -
        public BuyContractFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            DataTable Seller = MyCL.LoadDataTable("Select OwnerId, Owner From TblOwner Where ownertypeid = 1 Or ownertypeid = 3");
            LUEAddSeller.Properties.DataSource = Seller;
            LUEAddSeller.Properties.ValueMember = "OwnerId";
            LUEAddSeller.Properties.DisplayMember = "Owner";
            LUEEditSeller.Properties.DataSource = Seller;
            LUEEditSeller.Properties.ValueMember = "OwnerId";
            LUEEditSeller.Properties.DisplayMember = "Owner";
            DataTable Buyer = MyCL.LoadDataTable("Select OwnerId, Owner From TblOwner Where ownertypeid = 2");
            LUEAddBuyer.Properties.DataSource = Buyer;
            LUEAddBuyer.Properties.ValueMember = "OwnerId";
            LUEAddBuyer.Properties.DisplayMember = "Owner";
            LUEEditBuyer.Properties.DataSource = Buyer;
            LUEEditBuyer.Properties.ValueMember = "OwnerId";
            LUEEditBuyer.Properties.DisplayMember = "Owner";

            DataTable EstateId = MyCL.LoadDataTable(@"Select EstateId, (Select CdArea From CdArea Where CdAreaId = TblEstate.CdAreaId) AS CdArea, Aera, 
            (Select Owner From TblOwner Where OwnerId = TblEstate.OwnerId) & ' / ' & (Select TypeEstate From CdTypeEstate Where TypeEstateId = TblEstate.TypeEstateId) & ' / ' & Aera AS Details From TblEstate");
            LUEAddEstateId.Properties.DataSource = EstateId;
            LUEAddEstateId.Properties.ValueMember = "EstateId";
            LUEAddEstateId.Properties.DisplayMember = "Details";
            LUEEditEstateId.Properties.DataSource = EstateId;
            LUEEditEstateId.Properties.ValueMember = "EstateId";
            LUEEditEstateId.Properties.DisplayMember = "Details";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"SELECT contractid, contractDate, Seller, Buyer, EstateId, meterprice, allprice, madfoaa, datebaky, Percentage, rmark, shahed1, shahed2, datein, userin, 
            (Select Owner From TblOwner Where OwnerId = BuyContract.Seller) & ' / ' & (Select Owner From TblOwner Where OwnerId = BuyContract.Buyer) & ' / ' & Format(contractDate, 'dd/mm/yyyy') AS Details FROM BuyContract");
            LUEcontractid.Properties.DataSource = GridTable;
            LUEcontractid.Properties.ValueMember = "contractid";
            LUEcontractid.Properties.DisplayMember = "Details";
        }
        private void LoadSubData()
        {
            GridSubTable = MyCL.LoadDataTable(@"Select contractid, conditionno, condition From ContractConditions Where contractid = " + LUEcontractid.EditValue);
            gridControlMain.DataSource = GridSubTable;
        }
#endregion
        #region -   Event Handlers   -
        private void FrmCdBankAccount_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            DEAddcontractDate.EditValue = null;
            LUEAddSeller.EditValue = null;
            LUEAddBuyer.EditValue = null;
            LUEAddEstateId.EditValue = null;
            TxtAddshahed1.Text = string.Empty;
            TxtAddshahed2.Text = string.Empty;
            TxtAddmeterprice.Text = string.Empty;
            TxtAddallprice.Text = string.Empty;
            TxtAddmadfoaa.Text = string.Empty;
            LblAddRemaining.Text = "0.0";
            DEAdddatebaky.EditValue = null;
            TxtAddPercentage.Text = string.Empty;
            GCAddInfo.Visible = false;
            GCAddInfo.Text = string.Empty;
            DEAddcontractDate.Focus();
            TxtAddrmark.Text = string.Empty;
        }
        private void CalcAddRemaining_EditValueChanged(object sender, EventArgs e)
        {
            LblAddRemaining.Text = (MyCL.ConvertStringToInt(TxtAddallprice.Text) - MyCL.ConvertStringToInt(TxtAddmadfoaa.Text)).ToString();
        }
        private void CalcEditRemaining_EditValueChanged(object sender, EventArgs e)
        {
            LblEditRemaining.Text = (MyCL.ConvertStringToInt(TxtEditallprice.Text) - MyCL.ConvertStringToInt(TxtEditmadfoaa.Text)).ToString();
        }
        private void LUEAddEstateId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEAddEstateId.ItemIndex < 0)
            {
                GCAddInfo.Visible = false;
                return;
            }
            DataTable dt = (DataTable)LUEAddEstateId.Properties.DataSource;
            LblAddSize.Text = dt.Rows[LUEAddEstateId.ItemIndex]["Aera"].ToString();
            LblAddArea.Text = dt.Rows[LUEAddEstateId.ItemIndex]["CdArea"].ToString();
            GCAddInfo.Visible = true;
        }
        private void LUEEditEstateId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEditEstateId.ItemIndex < 0)
            {
                GCEditInfo.Visible = false;
                return;
            }
            DataTable dt = (DataTable)LUEEditEstateId.Properties.DataSource;
            LblEditSize.Text = dt.Rows[LUEEditEstateId.ItemIndex]["Aera"].ToString();
            LblEditArea.Text = dt.Rows[LUEEditEstateId.ItemIndex]["CdArea"].ToString();
            GCEditInfo.Visible = true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);

            string contractDate;
            if (DEAddcontractDate.EditValue != null)
                contractDate = String.Format("Format('{0}', 'dd/mm/yyyy')", DEAddcontractDate.Text);
            else
                contractDate = "NULL";
            string Seller;
            if (LUEAddSeller.EditValue != null)
                Seller = LUEAddSeller.EditValue.ToString();
            else
                Seller = "NULL";
            string Buyer;
            if (LUEAddBuyer.EditValue != null)
                Buyer = LUEAddBuyer.EditValue.ToString();
            else
                Buyer = "NULL";
            string EstateId;
            if (LUEAddEstateId.EditValue != null)
                EstateId = LUEAddEstateId.EditValue.ToString();
            else
                EstateId = "NULL";
            string meterprice;
            if (TxtAddmeterprice.Text != string.Empty)
                meterprice = TxtAddmeterprice.Text;
            else
                meterprice = "0";
            string AllPrice;
            if (TxtAddallprice.Text != string.Empty)
                AllPrice = TxtAddallprice.Text;
            else
                AllPrice = "0";
            string madfoaa;
            if (TxtAddmadfoaa.Text != string.Empty)
                madfoaa = TxtAddmadfoaa.Text;
            else
                madfoaa = "0";
            string datebaky;
            if (DEAdddatebaky.EditValue != null)
                datebaky = String.Format("Format('{0}', 'dd/mm/yyyy')", DEAdddatebaky.Text);
            else
                datebaky = "NULL";
            string Percentage;
            if (TxtAddPercentage.Text != string.Empty)
                Percentage = TxtAddPercentage.Text;
            else
                Percentage = "0";
            try
            {
                string NewID = MyCL.GetNewID("BuyContract", "contractid");
                cmd.CommandText = string.Format(@"INSERT INTO BuyContract (contractid, contractDate, Seller, Buyer, EstateId, meterprice, allprice, madfoaa, datebaky, Percentage, rmark, shahed1, shahed2, datein, userin)
                VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, '{10}', '{11}', '{12}', NOW(), {13})", NewID, contractDate, Seller, Buyer, EstateId, meterprice, AllPrice, madfoaa,
                datebaky, Percentage, MyCL.CleanSQLValue(TxtAddrmark.Text), MyCL.CleanSQLValue(TxtAddshahed1.Text), MyCL.CleanSQLValue(TxtAddshahed2.Text), MyCL.UserInfo.UserID);
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ رقم العقد = " + NewID, false, this);
                BtnClear_Click(BtnClear, new EventArgs());
                if (MessageBox.Show("هل تريد ان تضيف الشروط", "الشروط ...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                xtraTabControlMain.SelectedTabPage = xtraTabPageEdit;
                xtraTabControlMain_SelectedPageChanged(xtraTabControlMain, new DevExpress.XtraTab.TabPageChangedEventArgs(xtraTabPageAdd, xtraTabPageEdit));
                LUEcontractid.ItemIndex = ((DataTable)LUEcontractid.Properties.DataSource).Rows.Count - 1;
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
            }
            con.Close();
        }
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEdit)
                LoadData();
        }
        private void LUEEstateId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEcontractid.EditValue == null)
                return;
            DataRow row = GridTable.Rows[LUEcontractid.ItemIndex];
            DEEditcontractDate.EditValue = row["contractDate"];
            LUEEditSeller.EditValue = row["Seller"];
            LUEEditBuyer.EditValue = row["Buyer"];
            LUEEditEstateId.EditValue = row["EstateId"];
            ///////////////////////////////////////////
            TxtEditshahed1.Text = row["shahed1"].ToString();
            TxtEditshahed2.Text = row["shahed2"].ToString();
            TxtEditmeterprice.Text = row["meterprice"].ToString();
            TxtEditallprice.Text = row["allprice"].ToString();
            TxtEditmadfoaa.Text = row["madfoaa"].ToString();
            ////////////////////////////////////////////////
            CalcEditRemaining_EditValueChanged(LblEditSize, new EventArgs());
            ////////////////////////////////////////////////
            DEEditdatebaky.EditValue = row["datebaky"];
            TxtEditPercentage.Text = row["Percentage"].ToString();
            TxtEditrmark.Text = row["rmark"].ToString();
            TxtEditshahed1.Text = row["shahed1"].ToString();
            TxtEditshahed2.Text = row["shahed2"].ToString();
            LoadSubData();
        }
        private void LUEcontractid_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From BuyContract Where contractid = " + LUEcontractid.EditValue;
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
            }
            con.Close();
            LoadData();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (LUEcontractid.EditValue == null)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            string contractDate;
            if (DEEditcontractDate.EditValue.ToString() != string.Empty)
                contractDate = String.Format("Format('{0}', 'dd/mm/yyyy')", DEEditcontractDate.Text);
            else
                contractDate = "NULL";
            string Seller;
            if (LUEEditSeller.EditValue != null)
                Seller = LUEEditSeller.EditValue.ToString();
            else
                Seller = "NULL";
            string Buyer;
            if (LUEEditBuyer.EditValue != null)
                Buyer = LUEEditBuyer.EditValue.ToString();
            else
                Buyer = "NULL";
            string EstateId;
            if (LUEEditEstateId.EditValue != null)
                EstateId = LUEEditEstateId.EditValue.ToString();
            else
                EstateId = "NULL";
            string meterprice;
            if (TxtEditmeterprice.Text != string.Empty)
                meterprice = TxtEditmeterprice.Text;
            else
                meterprice = "0";
            string AllPrice;
            if (TxtEditallprice.Text != string.Empty)
                AllPrice = TxtEditallprice.Text;
            else
                AllPrice = "0";
            string madfoaa;
            if (TxtEditmadfoaa.Text != string.Empty)
                madfoaa = TxtEditmadfoaa.Text;
            else
                madfoaa = "0";
            string datebaky;
            if (DEEditdatebaky.EditValue != null)
                datebaky = String.Format("Format('{0}', 'dd/mm/yyyy')", DEEditdatebaky.Text);
            else
                datebaky = "NULL";
            string Percentage;
            if (TxtEditPercentage.Text != string.Empty)
                Percentage = TxtEditPercentage.Text;
            else
                Percentage = "0";
            try
            {
                cmd.CommandText = string.Format(@"UPDATE BuyContract SET contractDate = {0}, Seller = {1}, Buyer = {2}, EstateId = {3}, meterprice = {4}, allprice = {5}, madfoaa = {6}, datebaky = {7}, Percentage = {8}, 
                rmark = '{9}', shahed1 = '{10}', shahed2 = '{11}', datein = NOW(), userin = {12} Where contractid = {13}", contractDate, Seller, Buyer, EstateId, meterprice, AllPrice, madfoaa,
                datebaky, Percentage, MyCL.CleanSQLValue(TxtEditrmark.Text), MyCL.CleanSQLValue(TxtEditshahed1.Text), MyCL.CleanSQLValue(TxtEditshahed2.Text), MyCL.UserInfo.UserID, LUEcontractid.EditValue);
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم التعديل", false, this);
                LoadData();
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
            }
            con.Close();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUEcontractid.ItemIndex < 0)
                return;
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            string conditionno;
            if (Row["conditionno"].ToString() != string.Empty)
                conditionno = Row["conditionno"].ToString();
            else
                conditionno = "1";
            try
            {
                if (Row["contractid"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO ContractConditions (contractid, conditionno, condition)
                    VALUES ({0}, {1}, '{2}')", LUEcontractid.EditValue, conditionno, Row["condition"]);    
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE ContractConditions SET conditionno = {0}, condition = '{1}'
                    WHERE contractid = {2}", conditionno, Row["condition"], LUEcontractid.EditValue);
                }
                
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم التعديل", false, this);
                LoadData();
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
            }
            con.Close();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUEcontractid.ItemIndex < 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["contractid"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadSubData();
                return;
            }
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            try
            {
                cmd.CommandText = String.Format(@"Delete From ContractConditions Where contractid = {0} And conditionno = {1}", Row["contractid"], Row["conditionno"]);
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
            }
            con.Close();
            LoadSubData();
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (LUEcontractid.ItemIndex < 0)
                return;
            //RepCRGeneralFrm RepForm = new RepCRGeneralFrm();
            CReports.CRContract CRRep = new CReports.CRContract();
            CRRep.SetParameterValue(0, LUEcontractid.EditValue);
            

            CrystalDecisions.Shared.TableLogOnInfos crtableLogoninfos = new CrystalDecisions.Shared.TableLogOnInfos();
            CrystalDecisions.Shared.TableLogOnInfo crtableLogoninfo = new CrystalDecisions.Shared.TableLogOnInfo();
            CrystalDecisions.Shared.ConnectionInfo crConnectionInfo = new CrystalDecisions.Shared.ConnectionInfo();
            CrystalDecisions.CrystalReports.Engine.Tables CrTables = CRRep.Database.Tables;
            //System.Data.SqlClient.SqlConnectionStringBuilder ConString = new System.Data.SqlClient.SqlConnectionStringBuilder(MyCL.SqlConStr);
            System.Data.OleDb.OleDbConnectionStringBuilder AccConString = new OleDbConnectionStringBuilder(MyCL.AccConStr);
            crConnectionInfo.ServerName = AccConString.DataSource;
            crConnectionInfo.DatabaseName = "";
            crConnectionInfo.UserID = "";
            crConnectionInfo.Password = "";

            CRRep.DataSourceConnections[0].SetConnection("", AccConString.FileName, false);
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            //CRRep.PrintToPrinter(new System.Drawing.Printing.PrinterSettings(), new System.Drawing.Printing.PageSettings(), true);
            CRRep.PrintToPrinter(1, true, 1, 2);
            //RepForm.CRViewer.ReportSource = MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport;
            //RepForm.CRViewer.Refresh();
            //RepForm.ReportName = MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].RepCaption;
            //RepForm.MdiParent = this;
            //RepForm.Show();
        }
        #endregion
        
    }
}
