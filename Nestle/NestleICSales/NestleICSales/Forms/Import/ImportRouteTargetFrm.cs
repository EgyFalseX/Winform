using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
    public partial class ImportRouteTargetFrm : XtraForm
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
APOS Target
INV Target
DS Target
Sales Target
                ", Environment.NewLine);
            }
        }
        #endregion
        #region -   Functions   -
        public ImportRouteTargetFrm()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;
        }
        short GetShort(object obj)
        {
            short output = 0;
            short.TryParse(obj.ToString().Trim(), out output);
            return output;
        }
        double GetDouble(object obj)
        {
            double output = 0;
            double.TryParse(obj.ToString().Trim(), out output);
            return output;
        }
        private bool ImportRouteCutomerFromExcel()
        {
            //0//[Route Number]
            //1//[Route Name]
            //2//[APOS Target]
            //3//[INV Target]
            //4//[DS Target]
            //5//[Sales Target]

            bool output = false;
            dsNM.RouteTarget.Clear();
            short Year = Convert.ToInt16(seYear.EditValue);
            short Month = Convert.ToInt16(seMonth.EditValue);
            int BusinessDaysPerMonth = Utilities.Uti.BusinessDays(DataManager.defaultInstance.WeekEndDays, Year, Month).Count;
            int BusinessDaysPerWeek = 7 - DataManager.defaultInstance.WeekEndDays.Length;

            int NewRouteFounded = 0;
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
                SplashScreenManager.Default.SetWaitFormDescription("Loading Routes Informations [2/2]");
                adpRoute.Fill(dsNM.Routes);
                adpRouteTargetFormulaTable.Fill(dsNM.RouteTargetFormula);
            }));
            SplashScreenManager.CloseForm();
            if (dtExcel.Rows.Count == 0)
                return false;

            DateTime dtStart = DateTime.Now;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            DateTime datein = DataManager.defaultInstance.GetServerDatetime;
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
                if (row["Route Number"].ToString().Trim() == string.Empty)
                    continue;

                DataSources.dsData.RouteTargetRow SqlRow = dsNM.RouteTarget.NewRouteTargetRow();
                SqlRow.RouteNumber = row["Route Number"].ToString().Trim();

                //Route Update
                DataSources.dsData.RoutesRow RouteRow = Route.GetRouteNumber(row["Route Number"].ToString().Trim(), dsNM.Routes);
                if (RouteRow.RouteName == Route.DefaultRouteName)
                {
                    RouteRow.RouteNumber = SqlRow.RouteNumber;
                    if (RouteRow.RowState == DataRowState.Detached)
                    {
                        dsNM.Routes.AddRoutesRow(RouteRow);
                        RouteRow.EndEdit();
                        adpRoute.Update(RouteRow);
                        AddLog("[New Route Added] : " + SqlRow.RouteNumber);
                        NewRouteFounded++;
                    }
                    else
                        RouteRow.EndEdit();
                }

                SqlRow.TargetYear = Year;
                SqlRow.TargetMonth = Month;

                DataSources.dsData.RouteTargetFormulaRow Formula = dsNM.RouteTargetFormula.FindByRouteTargetFormulaMonth(SqlRow.TargetMonth);

                SqlRow.TargetAPOSMonth = GetDouble(row["APOS Target"]);
                SqlRow.TargetINVMonth = GetDouble(row["INV Target"]);
                SqlRow.TargetSalesMonth = GetDouble(row["Sales Target"]);
                SqlRow.TargetDSMonth = GetDouble(row["DS Target"]);

                SqlRow.TargetAPOSDay = SqlRow.TargetAPOSMonth / Formula.RouteTargetFormulaActiveDays;
                SqlRow.TargetINVDay = SqlRow.TargetINVMonth / BusinessDaysPerMonth;
                SqlRow.TargetSalesDay = SqlRow.TargetSalesMonth / BusinessDaysPerMonth;
                SqlRow.TargetDSDay = SqlRow.TargetSalesDay / SqlRow.TargetINVDay;

                SqlRow.TargetAPOSWeek = SqlRow.TargetAPOSDay * BusinessDaysPerWeek;
                SqlRow.TargetINVWeek = SqlRow.TargetINVDay * BusinessDaysPerWeek;
                SqlRow.TargetSalesWeek = SqlRow.TargetSalesDay * BusinessDaysPerWeek;
                SqlRow.TargetDSWeek = SqlRow.TargetSalesWeek / SqlRow.TargetINVWeek;

                SqlRow.userin = userin; SqlRow.datein = datein;

                dsNM.RouteTarget.AddRouteTargetRow(SqlRow);
                SqlRow.EndEdit();
            }
            Logger.Debug("Bulk Generated ...");
            con.Open();

            //Saving Updated Data As Bulks
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                SplashScreenManager.Default.SetWaitFormDescription("Updating Route Target ...");
                if (!RouteTarget.UpdateBulkRouteTarget(cmd, dsNM.RouteTarget))
                    MsgDlg.Show("Update Route Target Failed", Types.MessageType.Error);
                {
                    AddLog("New Routes Saved " + dsNM.Routes.Count);
                    Logger.Debug("Bulk Saved ...");
                    output = true;
                }

                dtExcel.Rows.Clear();
                dsNM.Routes.Clear(); dsNM.RouteTarget.Clear();
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
            layoutControlGroupCommands.Enabled = false;
            try
            {
                BackgroundWorker ImportWorker = new BackgroundWorker();
                ImportWorker.DoWork += ImportWorker_DoWork;
                ImportWorker.RunWorkerCompleted += ImportWorker_RunWorkerCompleted;
                ImportWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Faild to import Route Target from excel. - " + ex.Message, Types.MessageType.Error, ex);
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
                MsgDlg.Show("Route Target imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", Types.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommands.Enabled = true;
        }

        #endregion

    }
}
