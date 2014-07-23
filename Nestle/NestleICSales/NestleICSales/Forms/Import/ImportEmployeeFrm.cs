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
    public partial class ImportEmployeeFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportEmployeeFrm));
        DataSources.dsDataTableAdapters.JobTitleTableAdapter adpJobTitle = new DataSources.dsDataTableAdapters.JobTitleTableAdapter();
        #endregion
        #region -   Functions   -
        public ImportEmployeeFrm()
        {
            InitializeComponent();
        }
        private void ImportSalesSummaryFromExcel()
        {
            int NewEmployeeFounded = 0;
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
                SplashScreenManager.Default.SetWaitFormDescription("Loading Employee Informations [2/2]");
                adpEmployeeTable.Fill(dsNM.Employee);
                adpJobTitle.Fill(dsNM.JobTitle);
            }));
            SplashScreenManager.CloseForm();
            if (dtExcel.Rows.Count == 0)
                return;

            DateTime dtStart = DateTime.Now;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            DateTime datein = Managers.DataManager.defaultInstance.GetServerDatetime;
            int userin = UserManager.defaultInstance.UserInfo.UserID;

            ProgressBarMain.Properties.Maximum = dtExcel.Rows.Count;
            ProgressBarMain.EditValue = 0;

            foreach (DataRow row in dtExcel.Rows)
            {
                //Update UI
                ProgressBarMain.EditValue = (int)ProgressBarMain.EditValue + 1;
                lblCount.Text = string.Format("{0}/{1}", ProgressBarMain.Properties.Maximum, ProgressBarMain.EditValue);
                double DonePercent = Convert.ToDouble(ProgressBarMain.EditValue) / ProgressBarMain.Properties.Maximum;
                if (DonePercent * 100 > 1)
                {
                    double sec = DateTime.Now.Subtract(dtStart).TotalSeconds / DonePercent;
                    DateTime endTime = DateTime.Now.AddSeconds(sec);
                    TimeSpan remainTime = DateTime.Now.AddSeconds(sec).Subtract(DateTime.Now);
                    lblEstTime.Text = string.Format("[{0}] mins", Convert.ToInt32(remainTime.TotalMinutes));
                }

                if (row["Employee No#"].ToString() == string.Empty)
                    continue;
                int EmployeeId = Convert.ToInt32(row["Employee No#"].ToString());
                DataSources.dsData.EmployeeRow SqlRow = Employee.GetEmployeeRow(EmployeeId, dsNM.Employee);

                SqlRow.EmployeeId = EmployeeId;
                SqlRow.EmployeeName = row["Name"].ToString();
                SqlRow.EmployeeNameFull = row["Name"].ToString();
                SqlRow.JobTitleId = Employee.GetJobTitleId(row["Position Description"].ToString(), dsNM.JobTitle);
                SqlRow.userin = userin; SqlRow.datein = datein;
                if (SqlRow.RowState == DataRowState.Detached)
                {
                    dsNM.Employee.AddEmployeeRow(SqlRow);
                    AddLog("[New Employee Added] : " + EmployeeId);
                    NewEmployeeFounded++;
                }
                SqlRow.EndEdit();
            }
            Logger.Debug("Bulk Generated ...");
            con.Open();

            //Saving Updated Data As Bulks
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            SplashScreenManager.Default.SetWaitFormDescription("Updating Employee ..."); Application.DoEvents();
            
            if (!Employee.UpdateBulkEmployeeBySalesSummary(cmd, dsNM.Employee))
                MsgDlg.Show("Update Employee Failed", Types.MessageType.Error);
            AddLog("New Employee Saved " + NewEmployeeFounded);
            AddLog("Employee Updated " + dtExcel.Rows.Count);
            Logger.Debug("Bulk Saved ...");
            dtExcel.Rows.Clear();
            dsNM.Customer.Clear();
            ProgressBarMain.EditValue = 0;
            con.Close(); con.Dispose();
            SplashScreenManager.CloseForm();
        }
        private void AddLog(string strLog)
        {
            tbLog.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
            Logger.Info(strLog);
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
            pnlCommands.Enabled = false;
            try
            {
                DateTime dt = DateTime.Now;
                ImportSalesSummaryFromExcel();
                MsgDlg.Show("Employee imported " + Environment.NewLine + "in " + DateTime.Now.Subtract(dt).TotalMinutes, Types.MessageType.Success);
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Faild to import Employee from excel. - " + ex.Message, Types.MessageType.Error, ex);
            }
            ProgressBarMain.EditValue = 0;
            pnlCommands.Enabled = true;
        }
        #endregion
    }
}
