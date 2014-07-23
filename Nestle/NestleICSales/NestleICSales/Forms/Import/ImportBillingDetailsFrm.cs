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
using log4net;
using NestleICSales.Managers;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;
using NestleICSales.Utilities;
using System.IO;

namespace NestleICSales.Forms.Import
{

    public partial class ImportBillingDetailsFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportBillingDetailsFrm));
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
                ", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportBillingDetailsFrm()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

            adpDistributionChannelTable.FillByIceCream(dsNM.DistributionChannel);
            adpPlantTable.FillByIceCream(dsNM.Plant);
        }
        private bool ImportSalesSummaryFromExcel()
        {
            bool output = false;
            dsNM.BillingDetails.Clear();

            int NewCustomerFounded = 0;
            int NewRouteFounded = 0;
            int NewProductFounded = 0;
            AddLog("Start importing ...");
            DataTable dtExcel = new DataTable();
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        SplashScreenManager.Default.SetWaitFormDescription("Loading Excel File [" + (i + 1) + "] Contains [1/4]");
                        DataTable dtPart = DataManager.LoadExcelFile(lbcFilePath.Items[i].ToString(), 0, "*");
                        if (dtPart.Rows.Count == 0)
                            continue;
                        dtExcel.Merge(dtPart);
                    }
                }
                SplashScreenManager.Default.SetWaitFormDescription("Loading Customers Informations [2/4]");
                adpCustomer.Fill(dsNM.Customer);
                SplashScreenManager.Default.SetWaitFormDescription("Loading Routes Informations [3/4]");
                adpRoute.Fill(dsNM.Routes);
                SplashScreenManager.Default.SetWaitFormDescription("Loading Products Informations [4/4]");
                adpProductTable.Fill(dsNM.Product);
            }));
            SplashScreenManager.CloseForm();
            if (dtExcel.Rows.Count == 0)
                return false;

            DateTime dtStart = DateTime.Now;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            DateTime datein = Managers.DataManager.defaultInstance.GetServerDatetime;
            int userin = UserManager.defaultInstance.UserInfo.UserID;

            int ProcessedCounter = 0;
            int ProcessedMax = dtExcel.Rows.Count;
            this.Invoke(new MethodInvoker(() =>
            {
                ProgressBarMain.Properties.Maximum = ProcessedMax;
                ProgressBarMain.EditValue = ProcessedCounter;
            }));

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

                DataRow[] FindDist = dsNM.DistributionChannel.Select("DistributionChannel = " + row["Distribution Channel"]);
                if (FindDist == null || FindDist.Length == 0)
                    continue;
                DataRow[] FindPlant = dsNM.Plant.Select("SapName = " + row["Plant"]);
                if (FindPlant == null || FindPlant.Length == 0)
                    continue;

                DataSources.dsData.BillingDetailsRow SqlRow = dsNM.BillingDetails.NewBillingDetailsRow();
                SqlRow.BillingDocument = Convert.ToInt64(row["Billing Document"]);
                SqlRow.BillingDate = Convert.ToDateTime(row["Billing date for bil"]);
                SqlRow.ReferenceDocumentN = row["Reference Document N"].ToString();
                SqlRow.SoldToParty = Convert.ToInt32(row["Sold-to party"]);
                SqlRow.ConditionValue = Convert.ToDouble(row["Condition value"]);

                //Customer Update
                DataSources.dsData.CustomerRow CustomerRow = GetCustomerRow(SqlRow.SoldToParty, dsNM.Customer);
                if (CustomerRow.RowState == DataRowState.Detached)
                {
                    CustomerRow.CreationDate = datein;
                    CustomerRow.CustomerId = SqlRow.SoldToParty;
                    dsNM.Customer.AddCustomerRow(CustomerRow);
                    CustomerRow.EndEdit();
                    adpCustomer.Update(CustomerRow);
                    AddLog("[New Customer Added] : " + row["Sold-to party"]);
                    NewCustomerFounded++;
                }

                //Route Update
                if (row["Route"].ToString() == Route.DistributorsRouteId)//000001
                {
                    SqlRow.RouteNumber = SqlRow.SoldToParty.ToString();
                    SqlRow.ActualRouteNumber = row["Route"].ToString();
                }
                else if (row["Route"].ToString() == Route.ErrorRouteId || row["Route"].ToString().Trim() == string.Empty)//999999 or NULL
                {
                    SqlRow.RouteNumber = Managers.RouteCustomer.GetRouteNumberFromCustomerId(SqlRow.SoldToParty, row["Reference Document N"].ToString());
                    SqlRow.ActualRouteNumber = SqlRow.RouteNumber;
                }
                else
                {
                    DataSources.dsData.RoutesRow RouteRow = Route.GetRouteNumber(row["Route"].ToString().Trim(), dsNM.Routes);
                    if (RouteRow.RowState == DataRowState.Detached)
                    {
                        RouteRow.RouteNumber = row["Route"].ToString().Trim();
                        //RouteRow.RouteNumber = row["Route"].ToString();
                        dsNM.Routes.AddRoutesRow(RouteRow);
                        RouteRow.EndEdit();
                        adpRoute.Update(RouteRow);
                        AddLog("[New Route Added] : " + row["Route"]);
                        NewRouteFounded++;
                    }
                    SqlRow.RouteNumber = RouteRow.RouteNumber; 
                    SqlRow.ActualRouteNumber = SqlRow.RouteNumber;
                }

                Managers.BillingDetails.GetConditionTypeId(row["Condition type"].ToString(), ref SqlRow);

                SqlRow.MaterialNumber = Convert.ToInt32(row["Material Number"].ToString());
                //Product Update
                DataSources.dsData.ProductRow ProductRow = Product.GetProductRow(SqlRow.MaterialNumber, dsNM.Product);
                if (ProductRow.RowState == DataRowState.Detached)
                {
                    ProductRow.MaterialNumber = SqlRow.MaterialNumber;
                    dsNM.Product.AddProductRow(ProductRow);
                    ProductRow.EndEdit();
                    adpProductTable.Update(ProductRow);
                    AddLog("[New Product Added] : " + ProductRow.MaterialNumber);
                    NewProductFounded++;
                }

                Managers.BillingDetails.GetBillTypeId(row["Billing Type"].ToString(), ref SqlRow);

                if (row["Sales unit"].ToString() == Types.SalesUnit.EA.ToString())
                    SqlRow.ActualInvoicedQuan = Convert.ToDouble(row["Actual Invoiced Quan"]);
                else
                    SqlRow.ActualInvoicedQuan = Convert.ToDouble(row["Actual Invoiced Quan"]) * ProductRow.Quantity;
                
                SqlRow.Unreal = false;

                SqlRow.userin = userin; SqlRow.datein = datein;

                dsNM.BillingDetails.AddBillingDetailsRow(SqlRow);

                SqlRow.EndEdit();
            }
            Logger.Debug("Bulk Generated ...");
            con.Open();

            //Saving Updated Data As Bulks
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); Application.DoEvents();
            SplashScreenManager.Default.SetWaitFormDescription("Updating Billing Details ..."); Application.DoEvents();
            if (!BillingDetails.UpdateBulkBillingDetails(cmd, dsNM.BillingDetails))
                MsgDlg.Show("Update Billing Details Failed", Types.MessageType.Error);
            else
            {
                AddLog("New Billing Details Saved " + dsNM.BillingDetails.Count);
                output = true;
            }

            AddLog("New Customers Saved " + NewCustomerFounded);
            AddLog("New Routes Saved " + NewRouteFounded);
            AddLog("New Product Saved " + NewProductFounded);
            AddLog("New R3 Data Saved " + dsNM.BillingDetails.Count);

            Logger.Debug("Bulk Saved ...");

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsNM.BillingDetails.Clear();
            dsNM.Customer.Clear();
            cmd.Dispose(); cmd = null; con.Close(); con.Dispose(); con = null;
            GC.Collect(); GC.WaitForPendingFinalizers();
            SplashScreenManager.CloseForm();

            return output;
        }
        private void AddLog(string strLog)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tbLog.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
                Logger.Info(strLog);
            }));
        }
        private DataSources.dsData.CustomerRow GetCustomerRow(int CustomerId, DataSources.dsData.CustomerDataTable tbl)
        {
            DataSources.dsData.CustomerRow row = tbl.FindByCustomerId(CustomerId);
            if (row == null)
            {
                DataSources.dsData.CustomerRow CusRow = tbl.NewCustomerRow();
                Customer.CreateDefaultCustomer(ref CusRow);
                return CusRow;
            }
            else
                return row;
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
                MsgDlg.Show("Please add a file to import", Types.MessageType.Warn);
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
                MsgDlg.Show("Faild to import R3 from excel. - " + ex.Message, Types.MessageType.Error, ex);
            }
        }
        void ImportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (ImportSalesSummaryFromExcel())
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
                MsgDlg.Show("R3 imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", Types.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion

    }
}
