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
    public partial class ImportRouteCustomerFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportRouteCustomerFrm));
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
<Empty Column>
Route
Name 1
Description
Customer
Name 1
Street
Date of Creation
City
Delivery Day
                ", Environment.NewLine);
            }
        }
        #endregion
        #region -   Functions   -
        public ImportRouteCustomerFrm()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;
        }
        private bool ImportRouteCutomerFromExcel()
        {
            bool output = false;
            dsNM.RouteCustomer.Clear();

            int NewRouteFounded = 0;
            int NewCustomerFounded = 0;
            AddLog("Start importing ...");
            DataTable dtExcel = new DataTable();
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        SplashScreenManager.Default.SetWaitFormDescription("Loading Excel File [" + (i + 1) + "] Contains [1/3]");
                        dtExcel.Merge(DataManager.LoadExcelFile(lbcFilePath.Items[i].ToString(), "Sheet1", "*"));
                    }
                }
                SplashScreenManager.Default.SetWaitFormDescription("Loading Routes Informations [2/3]");
                adpRoute.Fill(dsNM.Routes);
                SplashScreenManager.Default.SetWaitFormDescription("Loading Customers Informations [3/3]");
                adpCustomer.Fill(dsNM.Customer);
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
                    double DonePercent = ProcessedCounter / ProcessedMax;
                    this.Invoke(new MethodInvoker(() =>
                    {
                        lblEstTime.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMain.EditValue = ProcessedCounter;
                        lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);
                        Application.DoEvents();
                    }));
                }

                DataSources.dsData.RouteCustomerRow SqlRow = dsNM.RouteCustomer.NewRouteCustomerRow();
                //Route Update
                DataSources.dsData.RoutesRow RouteRow = Route.GetRouteNumber(row["Route"].ToString().Trim(), dsNM.Routes);
                SqlRow.RouteNumber = row["Route"].ToString().Trim();
                if (RouteRow.RouteName == Route.DefaultRouteName)
                {
                    RouteRow.RouteName = row["Name 1"].ToString();
                    RouteRow.RouteNumber = SqlRow.RouteNumber;
                    RouteRow.Descriptions = row["Description"].ToString();
                    if (RouteRow.RowState == DataRowState.Detached)
                    {
                        RouteRow.RouteNumber = SqlRow.RouteNumber;
                        dsNM.Routes.AddRoutesRow(RouteRow);
                        RouteRow.EndEdit();
                        adpRoute.Update(RouteRow);
                        AddLog("[New Route Added] : " + SqlRow.RouteNumber);
                        NewRouteFounded++;
                    }
                    else
                        RouteRow.EndEdit();
                }
                
                //Customer Update
                DataSources.dsData.CustomerRow CR = Customer.GetCustomerRow(row["Customer"].ToString(), dsNM.Customer);
                SqlRow.CustomerId = Convert.ToInt32(row["Customer"]);
                CR.CustomerNameEn1 = row["Name 11"].ToString();
                CR.CustomerAddress = row["Street"].ToString();
                CR.CreationDate = (DateTime)row["Date of Creation"];
                CR.CityId = DataManager.GetCityId(row["City"].ToString());
                //if (CR.CityId == 0)
                //{
                //    string x = string.Empty;
                //}
                if (CR.RowState == DataRowState.Detached)
                {
                    CR.CustomerId = SqlRow.CustomerId;
                    dsNM.Customer.AddCustomerRow(CR);
                    AddLog("[New Customer Added] : " + row["Customer"]);
                    NewCustomerFounded++;
                }
                CR.EndEdit();

                SqlRow.DeliveryDay = Convert.ToInt16(row["Delivery Day"]);
                SqlRow.userin = userin; SqlRow.datein = datein;
                switch (row[0].ToString())
                {
                    case "@08@":
                    case "@09@":
                        if (row["Delivery Day"].ToString() == "0" || row["Delivery Day"].ToString() == "5")
                            SqlRow.RouteCustomerStateId = (short)Types.RouteCustomerState.Pause;
                        else
                            SqlRow.RouteCustomerStateId = (short)Types.RouteCustomerState.Active;
                        break;
                    case "@0A@":
                        SqlRow.RouteCustomerStateId = (short)Types.RouteCustomerState.Terminated;
                        break;
                }
                SqlRow.EndEdit();
                dsNM.RouteCustomer.AddRouteCustomerRow(SqlRow);
            }
            Logger.Debug("Bulk Generated ...");
            con.Open();

            
            //Saving Updated Data As Bulks
            //SplashScreenManager.CloseForm();
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                SplashScreenManager.Default.SetWaitFormDescription("Updating Routes ... [1/3]");
                if (!Route.UpdateBulkRoute(cmd, dsNM.Routes))
                    MsgDlg.Show("Update Routes Failed", Types.MessageType.Error);
                else
                    AddLog("New Routes Saved " + NewRouteFounded);
                SplashScreenManager.Default.SetWaitFormDescription("Updating Customers ... [2/3]");
                if (!Customer.UpdateBulkCustomer(cmd, dsNM.Customer))
                    MsgDlg.Show("Update Customer Failed", Types.MessageType.Error);
                else
                    AddLog("New Customers Saved " + NewCustomerFounded);
                SplashScreenManager.Default.SetWaitFormDescription("Updating Route Customer ... [3/3]");
                if (!RouteCustomer.UpdateBulkRouteCustomer(cmd, dsNM.RouteCustomer))
                    MsgDlg.Show("Update RouteCustomer Failed", Types.MessageType.Error);
                else
                {
                    AddLog("RoutesCustomers Saved " + dsNM.RouteCustomer.Count);
                    Logger.Debug("Bulk Saved ...");
                    output = true;
                }
                
                dtExcel.Rows.Clear();
                dsNM.Routes.Clear();
                dsNM.RouteCustomer.Clear();
                dsNM.Customer.Clear();

                ProgressBarMain.EditValue = 0;
                con.Close(); con.Dispose();
            }));
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
        #endregion
        #region -   Event Handlers   -
        private void btnGetFileName_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            lbcFilePath.Items.Add(ofd.FileName);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbcFilePath.SelectedIndex == -1)
                return;
            lbcFilePath.Items.RemoveAt(lbcFilePath.SelectedIndex);
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
                MsgDlg.Show("Faild to import Route Customer Assignment from excel. - " + ex.Message, Types.MessageType.Error, ex);
            }
        }
        void ImportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (ImportRouteCutomerFromExcel())
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
                MsgDlg.Show("Route Customer Assignment imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", Types.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion

    }
}
