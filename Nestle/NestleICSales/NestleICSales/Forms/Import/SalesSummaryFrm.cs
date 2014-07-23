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
    public partial class SalesSummaryFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(SalesSummaryFrm));
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Name1
Id
Name3
Region
Lv6Name
Lv6Code
Lv5Name
Lv5Code
Lv4Name
Lv4Code
Lv3Name
Lv3Code
DisName
DisCode
                ", Environment.NewLine);
            }
        }
        #endregion
        #region -   Functions   -
        public SalesSummaryFrm()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;
        }
        private bool ImportSalesSummaryFromExcel()
        {
            //0//Name1
            //1//Id
            //2//Name3
            //3//Region
            //4//Lv6Name
            //5//Lv6Code
            //6//Lv5Name
            //7//Lv5Code
            //8//Lv4Name
            //9//Lv4Code
            //10//Lv3Name
            //11//Lv3Code
            //12//DisName
            //13//DisCode
            bool output = false;
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
                        dtExcel.Merge(DataManager.LoadExcelFile(lbcFilePath.Items[i].ToString(), 0, "*"));
                    }
                }
                SplashScreenManager.Default.SetWaitFormDescription("Loading Customers Informations [2/3]");
                adpCustomer.Fill(dsNM.Customer);
                SplashScreenManager.Default.SetWaitFormDescription("Loading Customer Levels [3/3]");
                adpCustHierLevel3Table.Fill(dsNM.CustHierLevel3); adpCustHierLevel4Table.Fill(dsNM.CustHierLevel4);
                adpCustHierLevel5Table.Fill(dsNM.CustHierLevel5); adpCustHierLevel6Table.Fill(dsNM.CustHierLevel6);
                adpDistributionChannelTable.Fill(dsNM.DistributionChannel);
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

                if (row[0].ToString() == string.Empty || row[0].ToString() == "Customer")
                    continue;

                int CustomerId = Convert.ToInt32(row[1].ToString());//.Substring(11)
                DataSources.dsData.CustomerRow SqlRow = Customer.GetCustomerRow(CustomerId.ToString(), dsNM.Customer);

                SqlRow.CustomerId = CustomerId;
                SqlRow.CustomerNameEn1 = row[0].ToString();
                SqlRow.CustomerNameEn2 = row[2].ToString();
                SqlRow.SubchannelId = Customer.GetSubchannelIdByCustomerName3(row[2].ToString());
                SqlRow.CityId = DataManager.GetCityId(row[3].ToString());

                SqlRow.CustHierLevel6Id = Managers.Customer.GetLv6Code(row[13].ToString(), row[11].ToString(), row[10].ToString(), row[9].ToString(),row[8].ToString(), 
                    row[7].ToString(), row[6].ToString(), row[5].ToString(), row[4].ToString(), dsNM.DistributionChannel, dsNM.CustHierLevel3, dsNM.CustHierLevel4, dsNM.CustHierLevel5, dsNM.CustHierLevel6);
                
                SqlRow.CustomerTypeId = Customer.GetCustomerTypeIdByL4Code(row[9].ToString());
                SqlRow.CustomerType2Id = Customer.GetCustomerType2IdByCustomerTypeId(SqlRow.CustomerTypeId);

                SqlRow.userin = userin; SqlRow.datein = datein;
                if (SqlRow.RowState == DataRowState.Detached)
                {
                    dsNM.Customer.AddCustomerRow(SqlRow);
                    AddLog("[New Customer Added] : " + CustomerId);
                    NewCustomerFounded++;
                }
                SqlRow.EndEdit();
            }
            Logger.Debug("Bulk Generated ...");
            con.Open();

            //Saving Updated Data As Bulks
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            SplashScreenManager.Default.SetWaitFormDescription("Updating Customers ..."); Application.DoEvents();
            if (!Customer.UpdateBulkCustomerBySalesSummary(cmd, dsNM.Customer))
                MsgDlg.Show("Update Customers Failed", Types.MessageType.Error);
            else
            {
                AddLog("Customers Updated " + dtExcel.Rows.Count);
                Logger.Debug("Bulk Saved ...");
                output = true;
            }
            AddLog("New Customers Saved " + NewCustomerFounded);

            dtExcel.Rows.Clear();
            dsNM.Customer.Clear();
            this.Invoke(new MethodInvoker(() =>
            {
                ProgressBarMain.EditValue = 0;
            }));
            con.Close(); con.Dispose();
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
                MsgDlg.Show("Faild to import Sales Summary from excel. - " + ex.Message, Types.MessageType.Error, ex);
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
                MsgDlg.Show("Sales Summary imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", Types.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion

    }
}
