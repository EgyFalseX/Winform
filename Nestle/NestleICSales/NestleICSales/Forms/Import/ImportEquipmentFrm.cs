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
    public partial class ImportEquipmentFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportRouteCustomerFrm));
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Equipment
Serial Number
Material
Description
Description
Valid From
Inventory no#
ConstructYear
Functional Loc#
                ", Environment.NewLine);
            }
        }
        #endregion
        #region -   Functions   -
        public ImportEquipmentFrm()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;
        }
        private bool ImportEquipmentFromExcel()
        {
            bool output = false;
            dsNM.Equipment.Clear();

            int NewCustomerFounded = 0;
            AddLog("Start importing ...");
            DataTable dtExcel = new DataTable();
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            for (int i = 0; i < lbcFilePath.ItemCount; i++)
            {
                if (File.Exists(lbcFilePath.Items[i].ToString()))
                {
                    SplashScreenManager.Default.SetWaitFormDescription("Loading Excel File [" + (i + 1) + "] Contains [1/3]");
                    dtExcel.Merge(DataManager.LoadExcelFile(lbcFilePath.Items[i].ToString(), "Sheet1", "*"));
                }
            }
            SplashScreenManager.Default.SetWaitFormDescription("Loading Product Brand Informations [2/3]");
            AdpProductBrand.Fill(dsNM.ProductBrand);
            SplashScreenManager.Default.SetWaitFormDescription("Loading Customers Informations [3/3]");
            adpCustomer.Fill(dsNM.Customer);
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
                DataSources.dsData.EquipmentRow SqlRow = dsNM.Equipment.NewEquipmentRow();
                SqlRow.EquipmentId = Convert.ToInt32(row["Equipment"]);
                SqlRow.SerialNumber = row["Serial Number"].ToString();
                SqlRow.Material = Convert.ToInt32(row["Material"]);
                SqlRow.Description = row["Description"].ToString();
                SqlRow.FunctionalLocation = row["Description1"].ToString();
                SqlRow.ValidFrom = Convert.ToDateTime(row["Valid From"]);
                SqlRow.InventoryNo = row["Inventory no#"].ToString();
                SqlRow.ConstructYear = row["ConstructYear"].ToString();

                //Customer Update
                DataSources.dsData.CustomerRow CR = Customer.GetCustomerRow(row["Functional Loc#"].ToString(), dsNM.Customer);
                SqlRow.FunctionalId = Convert.ToInt32(row["Functional Loc#"]);
                if (CR.RowState == DataRowState.Detached)
                {
                    CR.CustomerId = SqlRow.FunctionalId;
                    dsNM.Customer.AddCustomerRow(CR);
                    AddLog("[New Customer Added] : " + SqlRow.FunctionalId);
                    NewCustomerFounded++;
                }
                CR.EndEdit();

                SqlRow.BrandId = GetBrandId(SqlRow.SerialNumber, dsNM.ProductBrand);
                SqlRow.userin = userin; SqlRow.datein = datein;
                SqlRow.EndEdit();
                dsNM.Equipment.AddEquipmentRow(SqlRow);
            }
            Logger.Debug("Bulk Generated ...");
            con.Open();
            //Saving Updated Data As Bulks
            //SplashScreenManager.CloseForm();
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                SplashScreenManager.Default.SetWaitFormDescription("Updating Customers ..."); Application.DoEvents();
                if (!Customer.UpdateBulkCustomer(cmd, dsNM.Customer))
                    MsgDlg.Show("Update Customer Failed", Types.MessageType.Error);
                else
                    AddLog("New Customer Saved " + NewCustomerFounded);

                SplashScreenManager.Default.SetWaitFormDescription("Updating Equipment ..."); Application.DoEvents();
                if (!Equipment.UpdateBulkRouteEquipment(cmd, dsNM.Equipment))
                    MsgDlg.Show("Update Equipment Failed", Types.MessageType.Error);
                else
                {
                    AddLog("New Equipment Saved " + dsNM.Equipment.Count);
                    Logger.Debug("Bulk Saved ...");
                    output = true;
                }
                dtExcel.Rows.Clear();
                dsNM.Equipment.Clear();
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
        private short GetBrandId(string Text, DataSources.dsData.ProductBrandDataTable tbl)
        {
            short outPut = Product.UnknownBrandId;
            for (int i = 0; i < tbl.Count; i++)
            {
                DataSources.dsData.ProductBrandRow row = (DataSources.dsData.ProductBrandRow)tbl.Rows[i];
                if (row.Brand[0] == Text[Text.Length -1])
                    outPut = row.BrandId;
            }
            return outPut;
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
            Application.DoEvents();
            try
            {
                BackgroundWorker ImportWorker = new BackgroundWorker();
                ImportWorker.DoWork += ImportWorker_DoWork;
                ImportWorker.RunWorkerCompleted += ImportWorker_RunWorkerCompleted;
                ImportWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Faild to import Equipment from excel. - " + ex.Message, Types.MessageType.Error, ex);
            }
            
        }
        void ImportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (ImportEquipmentFromExcel())
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
                MsgDlg.Show("Equipment imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", Types.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }
        #endregion

    }
}
