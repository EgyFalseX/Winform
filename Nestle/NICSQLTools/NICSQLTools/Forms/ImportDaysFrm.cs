using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace NICSQLTools
{

    public partial class ImportDaysFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        //private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportDaysFrm));
        List<string> Dist = new List<string>();
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Distribution Channel
Plant
Billing Document
Billing date for bil
Reference Document N
Sold-to party
Condition value
Route
Condition type
Material Number
Billing Type
Actual Invoiced Quan
Sales unit
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportDaysFrm()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

        }
        private static bool FindBillDoc(Data.dsData.QryBillDocDataTable tbl, string BillDoc)
        {
            if (tbl.FindByBilling_Document(BillDoc) != null)
                return true;
            else
                return false;
        }
        private void LoadCustomerCodes(ref Data.dsData ds)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT Customer_T FROM [0-6 Customer HN]", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Data.dsData._0_6_Customer_HNRow row = ds._0_6_Customer_HN.New_0_6_Customer_HNRow();
                row.Customer_T = dr.GetValue(0).ToString();
                ds._0_6_Customer_HN.Add_0_6_Customer_HNRow(row);
            }
            dr.Close();
            cmd.Dispose();
            con.Close(); con.Dispose();
        }
        private bool ImportDaysFromExcel()
        {
            //return false;
            bool output = false;

            int NewCustomerFounded = 0;
            int NewRouteFounded = 0;
            int NewProductFounded = 0;
            AddLog("Start importing ...");
            DataTable dtExcel = new DataTable();
            
            //if (SSM.IsSplashFormVisible)
            //    SSM.CloseWaitForm();
            SSM.ShowWaitForm();
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        SSM.SetWaitFormDescription("Loading Excel File [" + (i + 1) + "] Contains [1/4]");
                        DataTable dtPart = DataManager.LoadExcelFile(lbcFilePath.Items[i].ToString(), 0, "*");
                        if (dtPart.Rows.Count == 0)
                            continue;
                        dtExcel.Merge(dtPart);
                    }
                }
                SSM.SetWaitFormDescription("Loading Customers Informations [2/4]");
                //_0_6_Customer_HNTableAdapter.FillOnlyCode(dsData._0_6_Customer_HN);
                LoadCustomerCodes(ref dsData);
                SSM.SetWaitFormDescription("Loading Routes Informations [3/4]");
                _0_3__Route_DetailsTableAdapter.FillOnlyCode(dsData._0_3__Route_Details);
                SSM.SetWaitFormDescription("Loading Products Informations [4/4]");
                _0_4__Product_DetailsTableAdapter.FillOnlyCode(dsData._0_4__Product_Details);
            }));
            
            if (dtExcel.Rows.Count == 0)
                return false;

            DateTime dtStart = DateTime.Now;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandTimeout = 0;
            
            con.Open();

            int ProcessedCounter = 0;
            int ProcessedMax = dtExcel.Rows.Count;
            this.Invoke(new MethodInvoker(() =>
            {
                ProgressBarMain.Properties.Maximum = ProcessedMax;
                ProgressBarMain.EditValue = ProcessedCounter;
            }));

            //Load All Bill Docs
            Data.dsData.QryBillDocDataTable TblMaster = new Data.dsData.QryBillDocDataTable();

            //deleting data before saving new 1
            var result = from row in dtExcel.AsEnumerable()
                         group row by row["Billing date for bil"] into grp
                         select new { BillingDate = grp.Key };

            DateTime BillStartDate = (DateTime)result.ElementAt(0).BillingDate;
            DateTime BillEndDate = (DateTime)result.ElementAt(result.Count() - 1).BillingDate;

            qryBillDocTableAdapter.Fill(TblMaster, BillStartDate, BillEndDate);

            SSM.CloseWaitForm();
            
            foreach (DataRow row in dtExcel.Rows)
            {
                //Update UI
                ProcessedCounter++;
                if (ProcessedCounter % 500 == 1)
                {
                    //double DonePercent = ProcessedCounter / ProcessedMax;
                    this.Invoke(new MethodInvoker(() =>
                    {
                        lblEstTime.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMain.EditValue = ProcessedCounter;
                        lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);

                        Application.DoEvents();
                    }));
                }

                if (FindBillDoc(TblMaster, row["Billing Document"].ToString()))// Check Bill Doc Exists
                    continue;

                Data.dsData._0_1__Master_AllRow SqlRow = dsData._0_1__Master_All.New_0_1__Master_AllRow();
                SqlRow.Billing_Document = row["Billing Document"].ToString();

                SqlRow.Billing_date_for_bil = Convert.ToDateTime(row["Billing date for bil"]);
                SqlRow.yeard = SqlRow.Billing_date_for_bil.Year.ToString();
                SqlRow.Month = SqlRow.Billing_date_for_bil.ToString("MMMM", System.Globalization.CultureInfo.InvariantCulture).ToString();

                SqlRow.Billing_Type = row["Billing Type"].ToString();
                SqlRow.Payer = row["Payer"].ToString();
                SqlRow._Sold_to_party = Convert.ToInt32(row["Sold-to party"]).ToString();
                SqlRow.Actual_Invoiced_Quan = Convert.ToDouble(row["Actual Invoiced Quan"]);
                SqlRow.Condition_base_value = Convert.ToDouble(row["Condition base value"]);
                SqlRow.Condition_type = row["Condition type"].ToString();
                SqlRow.Condition_value = Convert.ToDouble(row["Condition value"]);
                SqlRow.Distribution_Channel = row["Distribution Channel"].ToString();

                SqlRow._G_L_Account_Number = row["G/L Account Number"].ToString();
                SqlRow.Material_Number = Convert.ToInt32(row["Material Number"]);
                SqlRow.Plant = row["Plant"].ToString();
                SqlRow.Reference_Document_N = row["Reference Document N"].ToString();

                //Set Route and Fix 999999 and 000001
                SqlRow.Route = row["Route"].ToString();
                if (SqlRow.Route == DataManager.Route999999)
                {
                    if (SqlRow.Reference_Document_N.Trim().Substring(0, 2) == "CS")//try to get it from "Reference Document N"
                        SqlRow.Route = SqlRow.Reference_Document_N.Trim().Substring(2, 6);
                    else
                    {
                        //try to get it from last route for this "Sold to-party"
                        cmd.CommandText = string.Format("SELECT top 1 Route FROM [0-1  Master All] WHERE [Sold-to party] = \"{0}\" AND [0-1  Master All].Route <> \"999999\" order by [Billing date for bil] DESC", SqlRow._Sold_to_party);
                        object obj = cmd.ExecuteScalar();
                        if (obj != null)
                            SqlRow.Route = obj.ToString();
                    }
                }
                //Set _Route___Sold
                if (SqlRow.Route == DataManager.Route000001)
                    SqlRow._Route___Sold = SqlRow._Sold_to_party;
                else
                    SqlRow._Route___Sold = SqlRow.Route;

                SqlRow.Sales_district = row["Sales district"].ToString();
                SqlRow.Sales_unit = row["Sales unit"].ToString();
                SqlRow.Company_Code = row["Company Code"].ToString();
                SqlRow.Base_Unit_of_Measure = row["Base Unit of Measure"].ToString();
                SqlRow.Sales_Organization = row["Sales Organization"].ToString();

                //Customer Update
                Data.dsData._0_6_Customer_HNRow CustomerRow = Customer.GetCustomerRow(SqlRow._Sold_to_party, dsData._0_6_Customer_HN);

                if (CustomerRow.RowState == DataRowState.Detached)
                {
                    CustomerRow.Customer_T = SqlRow._Sold_to_party;
                    CustomerRow.Customer_Type = Customer.CustomerTypeIdDirect;
                    CustomerRow.Customer_Type_2 = Customer.CustomerType2IdDirect;
                    CustomerRow.Customer_Group = Customer.CustomerGroupIdDirect;
                    CustomerRow.Subchannel = Customer.SubchannelIdDirect;
                    CustomerRow.Customer_type_Code = Customer.CustomerTypeCodeDirect;
                    dsData._0_6_Customer_HN.Add_0_6_Customer_HNRow(CustomerRow);
                    CustomerRow.EndEdit();
                    _0_6_Customer_HNTableAdapter.Update(CustomerRow);//Update Customers
                    AddLog("[New Customer Found] : " + row["Sold-to party"]);
                    NewCustomerFounded++;
                }
                //Route Update

                if (row["Route"].ToString().Trim() != DataManager.Route000001 && row["Route"].ToString().Trim() != DataManager.Route999999)
                {
                    Data.dsData._0_3__Route_DetailsRow RouteRow = Route.GetRouteNumber(row["Route"].ToString().Trim(), dsData._0_3__Route_Details);
                    if (RouteRow.RowState == DataRowState.Detached)
                    {
                        RouteRow.Route_Number = SqlRow.Route;
                        dsData._0_3__Route_Details.Add_0_3__Route_DetailsRow(RouteRow);
                        RouteRow.EndEdit();
                        AddLog("[New Route Found] : " + RouteRow.Route_Number);
                        NewRouteFounded++;
                    }
                }

                //Product Update
                Data.dsData._0_4__Product_DetailsRow ProductRow = Product.GetProductRow(SqlRow.Material_Number, dsData._0_4__Product_Details);
                
                if (ProductRow.RowState == DataRowState.Detached)
                {
                    ProductRow.Material_Number = SqlRow.Material_Number;
                    dsData._0_4__Product_Details.Add_0_4__Product_DetailsRow(ProductRow);
                    ProductRow.EndEdit();
                    AddLog("[New Product Found] : " + ProductRow.Material_Number);
                    NewProductFounded++;
                }

                if (ProductRow.Quin == ProductRow.New_Qu)
                    SqlRow.New_Quanteite = Convert.ToInt32(SqlRow.Actual_Invoiced_Quan);
                else
                    SqlRow.New_Quanteite = Convert.ToInt32(SqlRow.Actual_Invoiced_Quan * ProductRow.Quin / ProductRow.New_Qu);

                dsData._0_1__Master_All.Add_0_1__Master_AllRow(SqlRow);
                SqlRow.EndEdit();
               
            }

            SSM.ShowWaitForm(); Application.DoEvents();
            SSM.SetWaitFormDescription("Updating Billing Details ..."); Application.DoEvents();
            if (!Master.UpdateBulkMaster(cmd, dsData._0_1__Master_All))
                MsgDlg.Show("Update Billing Details Failed", MsgDlg.MessageType.Error);
                
            else
            {
                AddLog("New Billing Details Saved " + dsData._0_1__Master_All.Count);
                output = true;
            }

            //SSM.SetWaitFormDescription("Updating Customers ..."); Application.DoEvents();
            //_0_6_Customer_HNTableAdapter.Update(dsData._0_6_Customer_HN);
            SSM.SetWaitFormDescription("Updating Routes ..."); Application.DoEvents();
            _0_3__Route_DetailsTableAdapter.Update(dsData._0_3__Route_Details);
            SSM.SetWaitFormDescription("Updating Products ..."); Application.DoEvents();
            _0_4__Product_DetailsTableAdapter.Update(dsData._0_4__Product_Details);
            dsData._0_1__Master_All.AcceptChanges();
            SSM.CloseWaitForm();

            AddLog("New Customers Saved " + NewCustomerFounded);
            AddLog("New Routes Saved " + NewRouteFounded);
            AddLog("New Product Saved " + NewProductFounded);
            AddLog("New R3 Data Saved " + dsData._0_1__Master_All.Count);


            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData._0_1__Master_All.Clear(); dsData._0_6_Customer_HN.Clear();
            dsData._0_1__Master_All.Dispose(); dsData._0_6_Customer_HN.Dispose();
            cmd.Dispose(); cmd = null; con.Close(); con.Dispose(); con = null;
            GC.Collect(); GC.WaitForPendingFinalizers();
            
            return output;
        }
        private void AddLog(string strLog)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tbLog.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
                //Logger.Info(strLog);
            }));
        }
        
        #endregion
        #region -   Event Handlers   -
        private void btnGetFileName_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            foreach (string item in ofd.FileNames)
            {
                int found = lbcFilePath.FindString(item);
                if (found != -1)
                    continue;
                lbcFilePath.Items.Add(item);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if (lbcFilePath.SelectedIndex == -1)
            //    return;
            
            for (int i = lbcFilePath.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbcFilePath.Items.Remove(lbcFilePath.SelectedItems[i]);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lbcFilePath.ItemCount == 0)
            {
                //MsgDlg.Show("Please add a file to import", Types.MessageType.Warn);
                MessageBox.Show("Please add a file to import");
                return;
            }
            layoutControlGroupCommand.Enabled = false;
            try
            {
                BackgroundWorker ImportWorker = new BackgroundWorker();
                ImportWorker.DoWork += ImportWorker_DoWork;
                ImportWorker.RunWorkerCompleted += ImportWorker_RunWorkerCompleted;
                ImportWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Faild to import R3 from excel. - " + ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        void ImportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (ImportDaysFromExcel())
            {
                e.Result = dt;
            }
            else
                e.Result = null;
        }
        void ImportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            

            if (e.Result != null)
            {
                DateTime dt = (DateTime)e.Result;
                MsgDlg.Show("R3 imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", MsgDlg.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion

    }
}
