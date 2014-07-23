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
    public partial class ImportRouteFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportRouteFrm));
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Route Number
Route Name
Plant
Sales District
Supervisor
ASM
RSM
Brand Route
Notes
                ", Environment.NewLine);
            }
        }
        #endregion
        #region -   Functions   -
        public ImportRouteFrm()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;
        }
        private bool ImportRouteCutomerFromExcel()
        {
            /*
             * [Route Number]
             * [Route Name]
             * [Plant]
             * [Sales District]
             * [Supervisor]
             * [ASM]
             * [RSM]
             * [Brand Route]
             * [Notes]
             */
            bool output = false;
            dsNM.RouteCustomer.Clear();

            AddLog("Start importing ...");
            DataTable dtExcel = new DataTable();
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        SplashScreenManager.Default.SetWaitFormDescription("Loading Excel File [" + (i + 1) + "] Contains [1/2]");
                        dtExcel.Merge(DataManager.LoadExcelFile(lbcFilePath.Items[i].ToString(), 0, "*"));
                    }
                }
                SplashScreenManager.Default.SetWaitFormDescription("Loading Plant Sales District Informations [2/2]");
                AdpPlantSalesDistrictTable.Fill(dsNM.PlantSalesDistrict);
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

                DataSources.dsData.RoutesRow SqlRow = dsNM.Routes.NewRoutesRow();
                Route.CreateDefaultRoute(ref SqlRow);
                SqlRow.RouteNumber = row["Route Number"].ToString().Trim();
                SqlRow.RouteName = row["Route Name"].ToString().Trim();
                SqlRow.PlantSalesDistrictId = Route.GetPlantSalesDistrictId(row["Plant"].ToString().Trim(), row["Sales District"].ToString().Trim());
                SqlRow.Supervisor = row["Supervisor"].ToString().Trim();
                SqlRow.ASM = row["ASM"].ToString().Trim();
                SqlRow.RSM = row["RSM"].ToString().Trim();
                SqlRow.RouteBrandId = Route.GetRouteBrandId(row["Brand Route"].ToString().Trim());
                SqlRow.RouteBrandIdOld = Route.GetRouteBrandId(row["Brand Route"].ToString().Trim());
                if (dtExcel.Columns.Contains("Notes"))
                    SqlRow.Descriptions = row["Notes"].ToString();
                SqlRow.userin = userin; SqlRow.datein = datein;
                SqlRow.RouteStatusId = (short)Types.RouteStatus.Online;

                dsNM.Routes.AddRoutesRow(SqlRow);
                SqlRow.EndEdit();
            }
            Logger.Debug("Bulk Generated ...");
            con.Open();
            
            //Saving Updated Data As Bulks
            //SplashScreenManager.CloseForm();
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                SplashScreenManager.Default.SetWaitFormDescription("Updating Routes ...");
                if (!Route.UpdateBulkRoute(cmd, dsNM.Routes))
                    MsgDlg.Show("Update Routes Failed", Types.MessageType.Error);
                {
                    AddLog("New Routes Saved " + dsNM.Routes.Count);
                    Logger.Debug("Bulk Saved ...");
                    output = true;
                }

                dtExcel.Rows.Clear();
                dsNM.Routes.Clear();
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
                MsgDlg.Show("Faild to import Route from excel. - " + ex.Message, Types.MessageType.Error, ex);
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
                MsgDlg.Show("Route imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", Types.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion

    }
}
