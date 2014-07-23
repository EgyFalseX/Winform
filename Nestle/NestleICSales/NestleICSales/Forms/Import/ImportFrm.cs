using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml.Linq;
using System.Linq;
using System.Data.SqlClient;
using System.Data.OleDb;
using NestleICSales.Utilities;
using NestleICSales.Managers;
using log4net;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraSplashScreen;



namespace NestleICSales.Forms.Import
{
    public partial class ImportFrm : DevExpress.XtraEditors.XtraForm
    {
        private string OleConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportFrm));
        DataSources.dsDataTableAdapters.RoutesTableAdapter adpRoute = new DataSources.dsDataTableAdapters.RoutesTableAdapter();
        DataSources.dsDataTableAdapters.CustomerTableAdapter adpCustomer = new DataSources.dsDataTableAdapters.CustomerTableAdapter();

        DataSet _DataSet = new DataSet();
        int tableIndex = 0;
        
        public ImportFrm()
        {
            InitializeComponent();
            GLUEReportType.Properties.DataSource = Managers.DataManager.defaultInstance.ExcelFileFormation;
        }
        private void btnViewXml_Click(object sender, EventArgs e)
        {
            if (GLUEReportType.EditValue == null || GLUEReportType.EditValue.ToString() == string.Empty)
            {
                MsgDlg.Show("Please Select A Report", Types.MessageType.Error);
                return;
            }
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            _DataSet.ReadXml(ofd.FileName);
            Utilities.Types.ReportsFormation formation = (Utilities.Types.ReportsFormation)GLUEReportType.GetSelectedDataRow();
            DataSources.dsData.R3DataTable R3Tbl = (DataSources.dsData.R3DataTable)Managers.DataManager.defaultInstance.FormationExcelTable(_DataSet, formation);
           
            //GLUEReportType.Properties.View.selected
            //XDocument doc = XDocument.Load(ofd.FileName);
            //tableIndex++;

            //System.Xml.XmlReader xx;
            
            //DataTable dtUniqRecords = dt.DefaultView.ToTable(true, "ID", "Name");
            //ds.Tables[0].DefaultView.ToTable(true, "ID", "Name");


            GridControlData.DataSource = R3Tbl;
            GridViewData.PopulateColumns();
            GridViewData.BestFitColumns();

        }
        private void btnViewExcelFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            //DataTable dt = importdatafromexcel(ofd.FileName);
            _DataSet.ReadXml(ofd.FileName);
            MessageBox.Show("Done ...");
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tableIndex >= _DataSet.Tables.Count)
            {
                tableIndex = 0;
            }
            GridControlData.DataSource = _DataSet.Tables[tableIndex];
            GridViewData.PopulateColumns();
            GridViewData.BestFitColumns();
            MessageBox.Show(_DataSet.Tables[tableIndex].TableName);
            tableIndex++;

        }
        private void btnFromExcel_Click(object sender, EventArgs e)
        {
            if (GLUEReportType.EditValue == null || GLUEReportType.EditValue.ToString() == string.Empty)
            {
                MsgDlg.Show("Please Select A Report Schema", Types.MessageType.Error);
                return;
            }

            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            Utilities.Types.ReportsFormation formation = (Utilities.Types.ReportsFormation)GLUEReportType.GetSelectedDataRow();

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            try
            {
              
                if (!CheckExcelSchema(xlRange, formation.FileType))
                {
                    MsgDlg.Show("Wrong Excel Schema ...", Types.MessageType.Error);
                    return;
                }
                DataTable dt = CreateTableSchema(xlRange, formation.FileType);
                if (dt == null)
                {
                    MsgDlg.Show("Unknown Excel File ...", Types.MessageType.Error);
                    return;
                }

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;


                for (int i = 2; i <= rowCount; i++)
                {
                    DataRow row = dt.NewRow();
                    for (int j = 1; j < colCount; j++)
                    {
                        row[j - 1] = xlRange.Cells[i, j].Value2;
                    }
                    dt.Rows.Add(row);
                }

                GridControlData.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            xlRange = null; xlWorksheet = null;
            xlWorkbook.Close(false, Type.Missing, Type.Missing);
            xlWorkbook = null; xlApp = null;
        }
        private bool CheckExcelSchema(Microsoft.Office.Interop.Excel.Range range, Utilities.Types.XmlFileType filetype)
        {
            switch (filetype)
            {
                case Types.XmlFileType.R3:
                    for (int i = 1; i < range.Columns.Count; i++)
                    {
                        if (range.Cells[1, i].Value2 != null)
                        {
                            if (range.Cells[1, i].Value2 != dsNM.R3.Columns[i - 1].ColumnName)
                                return false;
                        }
                        else
                            return false;
                    }
                    break;
                default:
                    return false;
            }
            return true;
        }
        private DataTable CreateTableSchema(Microsoft.Office.Interop.Excel.Range range, Utilities.Types.XmlFileType filetype)
        {
            switch (filetype)
            {
                case Types.XmlFileType.R3:
                    return new DataSources.dsData.R3DataTable();
                default:
                    return null;
            }
        }

        #region Import Customer
        private void btnImportCustomer_Click(object sender, EventArgs e)
        {
            xtraTabControlMain.Enabled = false;
            try
            {
                DateTime dt = DateTime.Now;
                if (ImportCustmerFromExcel())
                    Logger.InfoFormat("Customer imported in " + DateTime.Now.Subtract(dt).TotalMinutes);
                else
                    Logger.InfoFormat("Customer import failed");
                
            }
            catch (Exception ex)
            {
                Logger.Error("Faild to import customer from access. - " + ex.Message, ex);
            }
            ProgressBarMain.EditValue = 0;
            xtraTabControlMain.Enabled = true;
        }
        private void ImportCustmerFromAccess()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            DataSources.dsDataTableAdapters.CustHierLevel6TableAdapter adpLv6Code = new DataSources.dsDataTableAdapters.CustHierLevel6TableAdapter();
            adpLv6Code.Fill(dsNM.CustHierLevel6);
            DataSources.dsData.CustomerDataTable tbl = new DataSources.dsData.CustomerDataTable();
            DateTime TSStart = DateTime.Now;
            OleDbConnection accCon = new OleDbConnection(OleConnectionString + dlg.FileName);
            OleDbCommand accCmd = new OleDbCommand("", accCon);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            
            OleDbDataReader accDr = null;

            SqlBulkCopy bulkCopy = new SqlBulkCopy(con);
            bulkCopy.ColumnMappings.Clear();
            bulkCopy.ColumnMappings.Add("CustomerId", "CustomerId"); bulkCopy.ColumnMappings.Add("CustomerNameEn1", "CustomerNameEn1");
            bulkCopy.ColumnMappings.Add("CustomerNameEn2", "CustomerNameEn2"); bulkCopy.ColumnMappings.Add("CustomerNameAr1", "CustomerNameAr1");
            bulkCopy.ColumnMappings.Add("CustomerNameAr2", "CustomerNameAr2"); bulkCopy.ColumnMappings.Add("CustHierLevel6Id", "CustHierLevel6Id");
            bulkCopy.ColumnMappings.Add("SubchannelId", "SubchannelId"); bulkCopy.ColumnMappings.Add("CustomerTypeId", "CustomerTypeId");
            bulkCopy.ColumnMappings.Add("CustomerType2Id", "CustomerType2Id"); bulkCopy.ColumnMappings.Add("CustomerGroupId", "CustomerGroupId");
            bulkCopy.ColumnMappings.Add("CreationDate", "CreationDate"); bulkCopy.ColumnMappings.Add("CustomerAddress", "CustomerAddress");
            bulkCopy.ColumnMappings.Add("CityId", "CityId"); bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

            accCon.Open();
            con.Open();

            accCmd.CommandText = "select  count(Customer_T) from [0-6 Customer HN]";
            ProgressBarMain.Properties.Maximum = Convert.ToInt32(accCmd.ExecuteScalar());
            ProgressBarMain.EditValue = 0;
            accCmd.CommandText = @"SELECT  Customer, [Name 1 En], [Name 3 En], [Name 1 Ar], [Name 3 Ar], 
            [L6 Code], [Creation Date], [Address], [City EN], [Subchannel], [Customer Type], [Customer Type 2],
            [Customer Group] FROM [0-6 Customer HN]";
            accDr = accCmd.ExecuteReader();

            DateTime datein = Managers.DataManager.defaultInstance.GetServerDatetime;
            int userin = UserManager.defaultInstance.UserInfo.UserID;
            while (accDr.Read())
            {
                ProgressBarMain.EditValue = (int)ProgressBarMain.EditValue + 1;
                lblCount.Text = string.Format("{0}/{1}", ProgressBarMain.Properties.Maximum, ProgressBarMain.EditValue);
                double DonePercent = Convert.ToDouble(ProgressBarMain.EditValue) / ProgressBarMain.Properties.Maximum;
                if (DonePercent * 100 > 1)
                {
                    double sec = DateTime.Now.Subtract(TSStart).TotalSeconds / DonePercent;
                    DateTime endTime = DateTime.Now.AddSeconds(sec);
                    TimeSpan remainTime = DateTime.Now.AddSeconds(sec).Subtract(DateTime.Now);
                    lblEstTime.Text = string.Format("[{0}] mins", Convert.ToInt32(remainTime.TotalMinutes));
                }
                Application.DoEvents();
                DataSources.dsData.CustomerRow row = tbl.NewCustomerRow();
                row.CustomerId = Convert.ToInt32(accDr.GetValue(0).ToString().Trim());
                if (!Uti.IsNullOrEmpty(accDr.GetValue(1)))
                    row.CustomerNameEn1 = accDr.GetValue(1).ToString();
                if (!Uti.IsNullOrEmpty(accDr.GetValue(2)))
                    row.CustomerNameEn2 = accDr.GetValue(2).ToString();
                if (!Uti.IsNullOrEmpty(accDr.GetValue(3)))
                    row.CustomerNameAr1 = accDr.GetValue(3).ToString();
                if (!Uti.IsNullOrEmpty(accDr.GetValue(4)))
                    row.CustomerNameAr2 = accDr.GetValue(4).ToString();
                if (!Uti.IsNullOrEmpty(accDr.GetValue(5)))
                    row.CustHierLevel6Id = Managers.Customer.GetLv6Code(accDr.GetValue(5).ToString(), dsNM.CustHierLevel6);
                if (!Uti.IsNullOrEmpty(accDr.GetValue(6)))
                    row.CreationDate = Convert.ToDateTime(accDr.GetValue(6));
                if (!Uti.IsNullOrEmpty(accDr.GetValue(7)))
                    row.CustomerAddress = accDr.GetValue(7).ToString();
                if (!Uti.IsNullOrEmpty(accDr.GetValue(8)))
                    row.CityId = DataManager.GetCityId(accDr.GetValue(8).ToString());
                if (!Uti.IsNullOrEmpty(accDr.GetValue(9)))
                    row.SubchannelId = Managers.Customer.GetSubchannelId(accDr.GetValue(9).ToString());
                if (!Uti.IsNullOrEmpty(accDr.GetValue(10)))
                    row.CustomerTypeId = Managers.Customer.GetCustomerTypeId(accDr.GetValue(10).ToString());
                if (!Uti.IsNullOrEmpty(accDr.GetValue(11)))
                    row.CustomerType2Id = Managers.Customer.GetCustomerType2Id(accDr.GetValue(11).ToString());
                if (!Uti.IsNullOrEmpty(accDr.GetValue(12)))
                    row.CustomerGroupId = Managers.Customer.GetCustomerGroupId(accDr.GetValue(12).ToString());
                row.userin = UserManager.defaultInstance.UserInfo.UserID;
                row.datein = datein;
                tbl.AddCustomerRow(row);

            }
            string tablename = string.Format("Customer{0}{1}{2}{3}{4}{5}{6}",TSStart.Year, TSStart.Month, TSStart.Day, TSStart.Hour, TSStart.Minute, TSStart.Second, TSStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM Customer WHERE 1 = 0;", tablename);
            Logger.InfoFormat("Creating Temp table '{0}' - {1}", tablename, cmd.ExecuteNonQuery());

            bulkCopy.DestinationTableName = tablename;
            bulkCopy.BatchSize = tbl.Count;
            bulkCopy.WriteToServer(tbl);
            
            cmd.CommandText = string.Format(@"merge into Customer as Target 
            using {0} as Source on Target.CustomerId=Source.CustomerId when matched then 
            update set Target.CustomerNameEn1=Source.CustomerNameEn1,
            Target.CustomerNameEn2=Source.CustomerNameEn2,
            Target.CustomerNameAr1=Source.CustomerNameAr1,
            Target.CustomerNameAr2=Source.CustomerNameAr2,
            Target.CustHierLevel6Id=Source.CustHierLevel6Id,
            Target.SubchannelId=Source.SubchannelId,
            Target.CustomerTypeId=Source.CustomerTypeId,
            Target.CustomerType2Id=Source.CustomerType2Id,
            Target.CustomerGroupId=Source.CustomerGroupId,
            Target.CreationDate=Source.CreationDate,
            Target.CustomerAddress=Source.CustomerAddress,
            Target.CityId=Source.CityId,
            Target.userin=Source.userin,
            Target.datein=Source.datein
             when not matched then 
             insert (CustomerId,CustomerNameEn1,CustomerNameEn2, CustomerNameAr1, CustomerNameAr2, CustHierLevel6Id, SubchannelId, CustomerTypeId, CustomerType2Id, CustomerGroupId, CreationDate, CustomerAddress, CityId, userin, datein) values 
             (Source.CustomerId,Source.CustomerNameEn1,Source.CustomerNameEn2, Source.CustomerNameAr1, Source.CustomerNameAr2, Source.CustHierLevel6Id, Source.SubchannelId, Source.CustomerTypeId, Source.CustomerType2Id, 
             Source.CustomerGroupId, Source.CreationDate, Source.CustomerAddress, Source.CityId, Source.userin, Source.datein);", tablename);
            Logger.InfoFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
            cmd.CommandText = string.Format(@"DROP TABLE {0}", tablename);
            Logger.InfoFormat("Temp Table Droped - {0}", cmd.ExecuteNonQuery());

            ProgressBarMain.EditValue = 0;
            accDr.Close(); accDr.Dispose();
            accCon.Close(); accCon.Dispose();
            con.Close(); con.Dispose();
        }
        private bool ImportCustmerFromExcel()
        {
            bool output = false;
            dsNM.Customer.Clear();
            //DataSources.dsNM.CustomerDataTable Customers;
            DataTable dtExcel = new DataTable();
            DataSources.dsDataTableAdapters.CustHierLevel6TableAdapter adpLv6Code = new DataSources.dsDataTableAdapters.CustHierLevel6TableAdapter();

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return false;
            }
            //0-6 Customer HN
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            SplashScreenManager.Default.SetWaitFormDescription("Loading Excel File Contains");
            dtExcel = DataManager.LoadExcelFile(dlg.FileName, "0-6 Customer HN", @"[Customer_T], [Name 1 En], [Name 3 En], [Name 1 Ar], [Name 3 Ar], 
            [CustHier Level 6], [Creation Date], [Address], [City EN], [Subchannel], [Customer Type], [Customer Type 2], [Customer Group]");
            adpLv6Code.Fill(dsNM.CustHierLevel6);
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
            int i = 0;
            foreach (DataRow row in dtExcel.Rows)
            {
                i++;
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
                        
                    }));
                }
                Application.DoEvents();
                try
                {
                    DataSources.dsData.CustomerRow SqlRow = dsNM.Customer.NewCustomerRow();
                    Managers.Customer.CreateDefaultCustomer(ref SqlRow);

                    SqlRow.CustomerId = Convert.ToInt32(row["Customer_T"]);
                    SqlRow.CustomerNameEn1 = row["Name 1 EN"].ToString();
                    SqlRow.CustomerNameEn2 = row["Name 3 EN"].ToString();
                    SqlRow.CustomerNameAr1 = row["Name 1 Ar"].ToString();
                    SqlRow.CustomerNameAr2 = row["Name 3 Ar"].ToString();
                    SqlRow.CustHierLevel6Id = Managers.Customer.GetLv6Code(row["CustHier Level 6"].ToString(), dsNM.CustHierLevel6);
                    SqlRow.SubchannelId = Managers.Customer.GetSubchannelId(row["Subchannel"].ToString());
                    SqlRow.CustomerTypeId = Managers.Customer.GetCustomerTypeId(row["Customer Type"].ToString());
                    SqlRow.CustomerType2Id = Managers.Customer.GetCustomerType2Id(row["Customer Type 2"].ToString());
                    SqlRow.CustomerGroupId = Managers.Customer.GetCustomerGroupId(row["Customer Group"].ToString());

                    DateTime CreationDate = DateTime.Now;
                    if (DateTime.TryParse(row["Creation Date"].ToString(), out CreationDate))
                        SqlRow.CreationDate = CreationDate;

                    SqlRow.CustomerAddress = row["Address"].ToString();
                    SqlRow.CityId = DataManager.GetCityId(row["City EN"].ToString());
                    SqlRow.userin = userin;
                    SqlRow.datein = datein;
                    SqlRow.EndEdit();
                    dsNM.Customer.AddCustomerRow(SqlRow);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex.Message, ex);
                }
                
            }
            Logger.Debug("Bulk Generated ...");

            con.Open();
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                if (!Customer.UpdateBulkCustomer(cmd, dsNM.Customer))
                    MsgDlg.Show("Update Customer Failed", Types.MessageType.Error);
                else
                {
                    Logger.Debug("Customers Saved ...");
                    output = true;
                }
                dtExcel.Rows.Clear();
                dsNM.Customer.Clear();
                ProgressBarMain.EditValue = 0;
                con.Close(); con.Dispose();
            }));
            SplashScreenManager.CloseForm();
            return output;
        }
        
        #endregion

        #region Import Product
        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            xtraTabControlMain.Enabled = false;
            try
            {
                ImportProductFromAccess();
                Logger.Info("importing product Complated");

            }
            catch (Exception ex)
            {
                Logger.Error("Faild to import product from access. - " + ex.Message, ex);
            }
            ProgressBarMain.EditValue = 0;
            xtraTabControlMain.Enabled = true;
        }
        private void ImportProductFromAccess()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            DateTime TSStart = DateTime.Now;
            OleDbConnection accCon = new OleDbConnection();//Properties.Settings.Default.AccessdbConnectionString
            //accCon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dlg.FileName;
            accCon.ConnectionString = OleConnectionString + dlg.FileName;
            OleDbCommand accCmd = new OleDbCommand("", accCon);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            SqlCommand cmd2 = new SqlCommand("", con);
            OleDbDataReader accDr = null;
            accCon.Open();
            con.Open();
            accCmd.CommandText = "select count([Material Number]) from [0-4  Product Details]";
            ProgressBarMain.Properties.Maximum = Convert.ToInt32(accCmd.ExecuteScalar());
            ProgressBarMain.EditValue = 0;
            accCmd.CommandText = @"SELECT [Material Number], [Base Base Product], [Material Name], [Quin],
            [Volum Pice], [Volum], [Price Increas], [Price Point rang], [Trade Price/Carton], [Trade Price/Piece],
            [Consumer price /Carton], [Consumer price /Piece], [Pallet], [Split], [Material Type], [Flavor], [NPDS],
            [Valid Year], [Valid Month], [Price Point], [Price Point 2009], [Price Point 2010], [ML / L], [New Qu] FROM [0-4  Product Details]";
            accDr = accCmd.ExecuteReader();
            cmd.CommandText = @"IF((SELECT COUNT(*) FROM Product WHERE MaterialNumber = @MaterialNumber) = 0)
            BEGIN
            INSERT INTO [dbo].Product
                (MaterialNumber, MaterialName, ProductBaseId, Quantity, ActiveQuantity, VolumPiece, VolumCarton, PriceChangesId, PricePointRangId, TradePriceCarton, TradePricePiece,
	            ConsumerPriceCarton, ConsumerPricePiece, Pallet, Split, MaterialTypeId, FlavorId, NPDSId, ValidDateStart, ValidDateEnd, PricePoint, PricePointLastYear, PricePointOldYear, userin, datein)
            VALUES
                (@MaterialNumber, @MaterialName, @ProductBaseId, @Quantity, @ActiveQuantity, @VolumPiece, @VolumCarton, @PriceChangesId, @PricePointRangId, @TradePriceCarton, @TradePricePiece,
	            @ConsumerPriceCarton, @ConsumerPricePiece, @Pallet, @Split, @MaterialTypeId, @FlavorId, @NPDSId, @ValidDateStart, @ValidDateEnd, @PricePoint, @PricePointLastYear, @PricePointOldYear, @userin, GETDATE())
            END
            ELSE
            BEGIN
            UPDATE [dbo].Product SET 
                        MaterialName = @MaterialName, ProductBaseId = @ProductBaseId,
                        Quantity = @Quantity, ActiveQuantity = @ActiveQuantity, VolumPiece = @VolumPiece, VolumCarton = @VolumCarton, PriceChangesId = @PriceChangesId, PricePointRangId = @PricePointRangId,
                        TradePriceCarton = @TradePriceCarton, TradePricePiece = @TradePricePiece, ConsumerPriceCarton = @ConsumerPriceCarton, ConsumerPricePiece = @ConsumerPricePiece,
                        Pallet = @Pallet, Split = @Split, MaterialTypeId = @MaterialTypeId, FlavorId = @FlavorId, NPDSId = @NPDSId, ValidDateStart = @ValidDateStart, 
			            ValidDateEnd = @ValidDateEnd, PricePoint = @PricePoint, PricePointLastYear = @PricePointLastYear, PricePointOldYear = @PricePointOldYear, userin = @userin, 
			            datein = GETDATE() WHERE MaterialNumber = @MaterialNumber
            END ";
            
            cmd.Parameters.Add(new SqlParameter("@MaterialNumber", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@MaterialName", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@ProductBaseId", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ActiveQuantity", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@VolumPiece", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@VolumCarton", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@PriceChangesId", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@PricePointRangId", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@TradePriceCarton", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@TradePricePiece", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@ConsumerPriceCarton", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@ConsumerPricePiece", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@Pallet", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Split", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@MaterialTypeId", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@FlavorId", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@NPDSId", SqlDbType.SmallInt));
            cmd.Parameters.Add(new SqlParameter("@ValidDateStart", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@ValidDateEnd", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@PricePoint", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@PricePointLastYear", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@PricePointOldYear", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int));

            DateTime datein = Managers.DataManager.defaultInstance.GetServerDatetime;
            int userin = UserManager.defaultInstance.UserInfo.UserID;
            while (accDr.Read())
            {
                ProgressBarMain.EditValue = (int)ProgressBarMain.EditValue + 1;
              
                double DonePercent = Convert.ToDouble(ProgressBarMain.EditValue) / ProgressBarMain.Properties.Maximum;
                if (DonePercent * 100 > 1)
                {
                    double sec = DateTime.Now.Subtract(TSStart).TotalSeconds / DonePercent;
                    DateTime endTime = DateTime.Now.AddSeconds(sec);
                    TimeSpan remainTime = DateTime.Now.AddSeconds(sec).Subtract(DateTime.Now);
                    lblEstTime.Text = string.Format("[{0}] mins", Convert.ToInt32(remainTime.TotalMinutes));
                }
                Application.DoEvents();
                bool ML = false;
                if (accDr.GetValue(22).ToString().Trim().ToLower() == "ml")
                    ML = true;

                DataSources.dsData.CustomerRow row = dsNM.Customer.NewCustomerRow();
             
                cmd.Parameters["@MaterialNumber"].Value = Convert.ToInt32(accDr.GetValue(0).ToString().Trim());
                //if (accDr.GetValue(0).ToString().Trim() == "12251498")
                //{
                //    string x = "";
                //}
                if (!Uti.IsNullOrEmpty(accDr.GetValue(1)))
                    cmd.Parameters["@ProductBaseId"].Value = GetProductBaseId(accDr.GetValue(1).ToString().Trim());
                else
                    cmd.Parameters["@ProductBaseId"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(2)))
                    cmd.Parameters["@MaterialName"].Value = accDr.GetValue(2).ToString().Trim();
                else
                    cmd.Parameters["@MaterialName"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(3)))
                    cmd.Parameters["@Quantity"].Value = Convert.ToDouble(accDr.GetValue(3).ToString());
                else
                    cmd.Parameters["@Quantity"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(23)))
                    cmd.Parameters["@ActiveQuantity"].Value = Convert.ToDouble(accDr.GetValue(23).ToString());
                else
                    cmd.Parameters["@ActiveQuantity"].Value = DBNull.Value;
                //if (cmd.Parameters["@MaterialNumber"].Value.ToString() == "120031")
                //{
                //    string x = string.Empty;
                //}
                if (!Uti.IsNullOrEmpty(accDr.GetValue(4)))
                {
                    if (ML)
                        cmd.Parameters["@VolumPiece"].Value = Convert.ToDouble(accDr.GetValue(4).ToString().Trim()) / 1000;
                    else
                        cmd.Parameters["@VolumPiece"].Value = accDr.GetValue(4).ToString().Trim();
                }
                else
                    cmd.Parameters["@VolumPiece"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(5)))
                    cmd.Parameters["@VolumCarton"].Value = Convert.ToDouble(accDr.GetValue(5).ToString().Trim());
                else
                    cmd.Parameters["@VolumCarton"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(6)))
                    cmd.Parameters["@PriceChangesId"].Value = GetPriceChangesId(accDr.GetValue(6).ToString().Trim());
                else
                    cmd.Parameters["@PriceChangesId"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(7)))
                    cmd.Parameters["@PricePointRangId"].Value = GetPricePointRangId(accDr.GetValue(7).ToString().Trim());
                else
                    cmd.Parameters["@PricePointRangId"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(8)))
                    cmd.Parameters["@TradePriceCarton"].Value = Convert.ToDouble(accDr.GetValue(8).ToString().Trim());
                else
                    cmd.Parameters["@TradePriceCarton"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(9)))
                    cmd.Parameters["@TradePricePiece"].Value = Convert.ToDouble(accDr.GetValue(9).ToString().Trim());
                else
                    cmd.Parameters["@TradePricePiece"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(10)))
                    cmd.Parameters["@ConsumerPriceCarton"].Value = Convert.ToDouble(accDr.GetValue(10).ToString().Trim());
                else
                    cmd.Parameters["@ConsumerPriceCarton"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(11)))
                    cmd.Parameters["@ConsumerPricePiece"].Value = Convert.ToDouble(accDr.GetValue(11).ToString().Trim());
                else
                    cmd.Parameters["@ConsumerPricePiece"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(12)))
                    cmd.Parameters["@Pallet"].Value = Convert.ToInt16(accDr.GetValue(12).ToString().Trim());
                else
                    cmd.Parameters["@Pallet"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(13)))
                    cmd.Parameters["@Split"].Value = Convert.ToDouble(accDr.GetValue(13).ToString().Trim());
                else
                    cmd.Parameters["@Split"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(14)))
                    cmd.Parameters["@MaterialTypeId"].Value = GetMaterialTypeId(accDr.GetValue(14).ToString().Trim());
                else
                    cmd.Parameters["@MaterialTypeId"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(15)))
                    cmd.Parameters["@FlavorId"].Value = GetFlavorId(accDr.GetValue(15).ToString().Trim());
                else
                    cmd.Parameters["@FlavorId"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(16)))
                    cmd.Parameters["@NPDSId"].Value = GetNPDSId(accDr.GetValue(16).ToString().Trim());
                else
                    cmd.Parameters["@NPDSId"].Value = DBNull.Value;
                try
                {
                    if (!Uti.IsNullOrEmpty(accDr.GetValue(17)) && !Uti.IsNullOrEmpty(accDr.GetValue(18)))
                        cmd.Parameters["@ValidDateStart"].Value = Convert.ToDateTime("01-" + accDr.GetValue(18).ToString().Trim() + accDr.GetValue(17).ToString().Trim());
                    else
                        cmd.Parameters["@ValidDateStart"].Value = DBNull.Value;
                }
                catch (Exception ex)
                {
                    string aa = ex.Message;
                    cmd.Parameters["@ValidDateStart"].Value = DBNull.Value;
                }
                cmd.Parameters["@ValidDateEnd"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(19)))
                    cmd.Parameters["@PricePoint"].Value = Convert.ToDouble(accDr.GetValue(19).ToString().Trim());
                else
                    cmd.Parameters["@PricePoint"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(20)))
                    cmd.Parameters["@PricePointOldYear"].Value = Convert.ToDouble(accDr.GetValue(20).ToString().Trim());
                else
                    cmd.Parameters["@PricePointOldYear"].Value = DBNull.Value;
                if (!Uti.IsNullOrEmpty(accDr.GetValue(21)))
                {
                    try
                    {
                        cmd.Parameters["@PricePointLastYear"].Value = Convert.ToDouble(accDr.GetValue(21).ToString().Trim());
                    }
                    catch {
                        cmd.Parameters["@PricePointLastYear"].Value = Convert.ToDouble(accDr.GetValue(20).ToString().Trim());
                    }
                }
                else
                    cmd.Parameters["@PricePointLastYear"].Value = DBNull.Value;

                //MessageBox.Show(accDr.GetValue(20) + Environment.NewLine + );
                //if (Convert.ToInt16(accDr.GetValue(23)) == Convert.ToInt16(accDr.GetValue(3)))
                //{
                //    cmd2.CommandText = string.Format(@"select count(*) from product where ProductBaseId = {0} and ActiveCase = 1", cmd.Parameters["@ProductBaseId"].Value);
                //    if ((int)cmd2.ExecuteScalar() == 0)
                //        cmd.Parameters["@ActiveCase"].Value = true;
                //    else
                //        cmd.Parameters["@ActiveCase"].Value = false;
                //}
                //else 
                //    cmd.Parameters["@ActiveCase"].Value = false;

                cmd.Parameters["@userin"].Value = UserManager.defaultInstance.UserInfo.UserID;

                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    string x = string.Empty;
                    throw ex;
                }
            }
            ProgressBarMain.EditValue = 0;
            accDr.Close(); accDr.Dispose();
            accCon.Close(); accCon.Dispose();
            con.Close(); con.Dispose();
        }
        private int GetProductBaseId(string BaseProduct)
        {
            int ProductBaseId = 99999999;
            switch (BaseProduct.Trim())
            {
                case "DOLCE Choco Stick":
                    ProductBaseId = 1;
                    break;
                case "DOLCE DLST Granita Karkadee":
                    ProductBaseId = 2;
                    break;
                case "0":
                    ProductBaseId = 2;
                    break;
                case "DOLCE DOLCECA":
                    ProductBaseId = 3;
                    break;
                case "DOLCE DOLCECA AHLAWY":
                    ProductBaseId = 4;
                    break;
                case "DOLCE DOLCECA Bomb":
                    ProductBaseId = 5;
                    break;
                case "DOLCE DOLCECA DALAA":
                    ProductBaseId = 6;
                    break;
                case "DOLCE DOLCECA ZAMALKAWY":
                    ProductBaseId = 7;
                    break;
                case "DOLCE DOLI GENAN":
                    ProductBaseId = 8;
                    break;
                case "DOLCE DOLI UP":
                    ProductBaseId = 9;
                    break;
                case "DOLCE DOLSASA":
                    ProductBaseId = 10;
                    break;
                case "DOLCE DOLSASA BREEMO":
                    ProductBaseId = 11;
                    break;
                case "DOLCE DOLSTICK":
                    ProductBaseId = 12;
                    break;
                case "DOLCE Dolstick BEREMO":
                    ProductBaseId = 13;
                    break;
                case "DOLCE DOLSTICK Creemo":
                    ProductBaseId = 14;
                    break;
                case "DOLCE DOLSTICK Douda":
                    ProductBaseId = 15;
                    break;
                case "DOLCE DOLSTICK Ishara":
                    ProductBaseId = 16;
                    break;
                case "DOLCE Dolstick Msasa":
                    ProductBaseId = 17;
                    break;
                case "DOLCE DOLSTICK SHAKHABIT":
                    ProductBaseId = 18;
                    break;
                case "DOLCE FARFASHA":
                    ProductBaseId = 19;
                    break;
                case "DOLCE Grand":
                    ProductBaseId = 20;
                    break;
                case "DOLCE Ice Cocktail":
                    ProductBaseId = 21;
                    break;
                case "DOLCE JELLY Hop":
                    ProductBaseId = 22;
                    break;
                case "DOLCE Regular Litre":
                    ProductBaseId = 23;
                    break;
                case "DOLCE RIPPLE":
                    ProductBaseId = 24;
                    break;
                case "DOLCE Slushy":
                    ProductBaseId = 25;
                    break;
                case "DOLCE SUPER DOLSTICK":
                    ProductBaseId = 26;
                    break;
                case "DOLCE SUPER DOLSTICK Alwan":
                    ProductBaseId = 27;
                    break;
                case "DOLCE TANGO":
                    ProductBaseId = 28;
                    break;
                case "DOLCE TANGO MINI":
                    ProductBaseId = 29;
                    break;
                case "DOLCE TOM & JERRY":
                    ProductBaseId = 30;
                    break;
                case "DOLCE TOM & JERRY  Bucket":
                    ProductBaseId = 31;
                    break;
                case "DOLCE VITA":
                    ProductBaseId = 32;
                    break;
                case "DOLCE WICH":
                    ProductBaseId = 33;
                    break;
                case "DOLSTICK El Masry":
                    ProductBaseId = 34;
                    break;
                case "MOVENPICK  1 L":
                    ProductBaseId = 35;
                    break;
                case "MOVENPICK  5 L":
                    ProductBaseId = 36;
                    break;
                case "MOVENPICK  900ml":
                    ProductBaseId = 37;
                    break;
                case "MOVENPICK 150ml":
                    ProductBaseId = 38;
                    break;
                case "MOVENPICK 175ml":
                    ProductBaseId = 39;
                    break;
                case "MOVENPICK Waffle Mix":
                    ProductBaseId = 40;
                    break;
                case "Nestle Cake":
                    ProductBaseId = 41;
                    break;
                case "NESTLE CARNAVALITA":
                    ProductBaseId = 42;
                    break;
                case "NESTLE CARNAVALITA 1.5L":
                    ProductBaseId = 43;
                    break;
                case "NESTLE CARNAVALITA 2L":
                    ProductBaseId = 44;
                    break;
                case "NESTLE CHIKO":
                    ProductBaseId = 45;
                    break;
                case "NESTLE CHIKO  TAA TAA":
                    ProductBaseId = 46;
                    break;
                case "NESTLE CHIKO Douda":
                    ProductBaseId = 47;
                    break;
                case "NESTLE CHIKO ICE":
                    ProductBaseId = 48;
                    break;
                case "NESTLE CHIKO ICE JELLy":
                    ProductBaseId = 49;
                    break;
                case "NESTLE CHIKO ICE Millk":
                    ProductBaseId = 50;
                    break;
                case "NESTLE CHIKO Magic":
                    ProductBaseId = 51;
                    break;
                case "NESTLE CHIKO MOGHAMRA":
                    ProductBaseId = 52;
                    break;
                case "NESTLE EXTREME":
                    ProductBaseId = 53;
                    break;
                case "NESTLE EXTREME  CP":
                    ProductBaseId = 54;
                    break;
                case "NESTLE ICECAKE":
                    ProductBaseId = 55;
                    break;
                case "NESTLE JELLY STICK":
                    ProductBaseId = 56;
                    break;
                case "NESTLE KIMO AFLAM":
                    ProductBaseId = 57;
                    break;
                case "NESTLE KIMO Cola":
                    ProductBaseId = 58;
                    break;
                case "NESTLE KIMO CONO":
                    ProductBaseId = 59;
                    break;
                case "NESTLE KIMO CONO TWIST":
                    ProductBaseId = 60;
                    break;
                case "NESTLE KIMO ESKIMO":
                    ProductBaseId = 61;
                    break;
                case "NESTLE KIMO MAGIC":
                    ProductBaseId = 62;
                    break;
                case "NESTLE KIMO Moza":
                    ProductBaseId = 63;
                    break;
                case "NESTLE KIMO Rashash":
                    ProductBaseId = 64;
                    break;
                case "NESTLE KIMO Trio":
                    ProductBaseId = 65;
                    break;
                case "NESTLE KIT KAT":
                    ProductBaseId = 66;
                    break;
                case "NESTLE KIT KAT Litre":
                    ProductBaseId = 67;
                    break;
                case "NESTLE MAGIC":
                    ProductBaseId = 68;
                    break;
                case "NESTLE MAXIBON":
                    ProductBaseId = 69;
                    break;
                case "NESTLE MEGA":
                    ProductBaseId = 70;
                    break;
                case "NESTLE MEGA CP":
                    ProductBaseId = 71;
                    break;
                case "NESTLE NONSTOP":
                    ProductBaseId = 72;
                    break;
                case "NESTLE PARADISE Cup":
                    ProductBaseId = 73;
                    break;
                case "NESTLE PARADISE L":
                    ProductBaseId = 74;
                    break;
                case "NESTLE PARADISE Supreme":
                    ProductBaseId = 75;
                    break;
                case "NESTLE POPS":
                    ProductBaseId = 76;
                    break;
                case "NESTLE POPS Litre":
                    ProductBaseId = 77;
                    break;
                case "NESTLE Premium Gallon":
                    ProductBaseId = 78;
                    break;
                case "Nestle Regular Gallon":
                    ProductBaseId = 79;
                    break;
                case "NESTLE RIPPO":
                    ProductBaseId = 80;
                    break;
                case "NESTLE SPIDERMAN":
                    ProductBaseId = 81;
                    break;
                case "NESTLE SQUIZZ  Puree":
                    ProductBaseId = 82;
                    break;
                case "NESTLE SQUIZZ  UP":
                    ProductBaseId = 83;
                    break;
                case "NESTLE SQUIZZ & Cream":
                    ProductBaseId = 84;
                    break;
                case "NESTLE SQUIZZ STK":
                    ProductBaseId = 85;
                    break;
                case "NESTLE SUNDAE":
                    ProductBaseId = 86;
                    break;
                case "NESTLE SUPER CHIKO":
                    ProductBaseId = 87;
                    break;
                case "NESTLE SUPER CHIKO Cosmo":
                    ProductBaseId = 88;
                    break;
                case "NESTLE SUPER JELLY":
                    ProductBaseId = 89;
                    break;
                case "NESTLE SUPERMAN":
                    ProductBaseId = 90;
                    break;
                case "NESTLE Supper Chiko TRIO":
                    ProductBaseId = 91;
                    break;
                case "NESTLE Super KIMO ESKIMO":
                    ProductBaseId = 92;
                    break;
                case "DOLCE Super DOLSTICK Creemo":
                    ProductBaseId = 93;
                    break;
                case "DOLCE FARFASHA / Slushy":
                    ProductBaseId = 94;
                    break;
                case "KIMO Taraa":
                    ProductBaseId = 95;
                    break;
            }
            return ProductBaseId;
        }
        private int GetPriceChangesId(string PriceChanges)
        {
            int PriceChangesId = Product.UnknownPriceChangesId;
            switch (PriceChanges.Trim())
            {
                case "Same Price":
                    PriceChangesId = 1;
                    break;
                case "Price Increase":
                case "Price Increase in 2014":
                    PriceChangesId = 2;
                    break;
                default:
                    Logger.Error("Error while try to get PriceChangesId from '" + PriceChanges + "'");
                    break;
            }
            return PriceChangesId;
        }
        private int GetPricePointRangId(string PricePointRang)
        {
            int PricePointRangId = Product.UnknownPricePointRangId;
            switch (PricePointRang.Trim())
            {
                case "PPP":
                case "ppp":
                    PricePointRangId = 1;
                    break;
                case "Take Home":
                    PricePointRangId = 2;
                    break;
                case "Premium":
                    PricePointRangId = 3;
                    break;
                case "Mainstream":
                    PricePointRangId = 4;
                    break;
                default:
                    Logger.Error("Error while try to get PricePointRangId from '" + PricePointRang + "'");
                    break;
            }
            return PricePointRangId;
        }
        private int GetMaterialTypeId(string MaterialType)
        {
            int MaterialTypeId = Product.UnknownMaterialTypeId;
            switch (MaterialType.Trim())
            {
                case "Normal":
                    MaterialTypeId = 1;
                    break;
                case "Promotion":
                    MaterialTypeId = 2;
                    break;
                default:
                    Logger.Error("Error while try to get MaterialTypeId from '" + MaterialType + "'");
                    break;
            }
            return MaterialTypeId;
        }
        private int GetNPDSId(string NPDS)
        {
            int NPDSId = Product.UnknownNPDSId;
            switch (NPDS.Trim())
            {
                case "Normal":
                    NPDSId = 1;
                    break;
                case "NPD":
                    NPDSId = 2;
                    break;
                case "promotion":
                    NPDSId = 3;
                    break;
            }
            return NPDSId;
        }
        private int GetFlavorId(string Flavor)
        {
            int FlavorId = Product.UnknownFlavorId;
            switch (Flavor.Trim())
            {
                case "0":
                    FlavorId = 2;
                    break;
                case "Alwan":
                    FlavorId = 3;
                    break;
                case "Apple":
                    FlavorId = 4;
                    break;
                case "Asaliyyah":
                    FlavorId = 5;
                    break;
                case "Black And White":
                    FlavorId = 6;
                    break;
                case "Blackberry":
                    FlavorId = 7;
                    break;
                case "Brownies":
                    FlavorId = 8;
                    break;
                case "Caramel":
                    FlavorId = 9;
                    break;
                case "Caramelita":
                    FlavorId = 10;
                    break;
                case "Cassata":
                    FlavorId = 11;
                    break;
                case "Choc Fudge":
                    FlavorId = 12;
                    break;
                case "Choc Hzn":
                    FlavorId = 13;
                    break;
                case "Choc Mocca":
                    FlavorId = 14;
                    break;
                case "Chocolate":
                    FlavorId = 15;
                    break;
                case "Chocolate Fudge":
                    FlavorId = 16;
                    break;
                case "Chocolate Hzn":
                    FlavorId = 17;
                    break;
                case "Chocolate Mocca":
                    FlavorId = 18;
                    break;
                case "Cocktail":
                    FlavorId = 19;
                    break;
                case "Cola":
                    FlavorId = 20;
                    break;
                case "Cosmo":
                    FlavorId = 21;
                    break;
                case "Cream":
                    FlavorId = 22;
                    break;
                case "Cream Choc":
                    FlavorId = 23;
                    break;
                case "Creamo":
                    FlavorId = 24;
                    break;
                case "Creme Brulee":
                    FlavorId = 25;
                    break;
                case "Croquant":
                    FlavorId = 26;
                    break;
                case "Eshta":
                    FlavorId = 27;
                    break;
                case "ESKIMO":
                    FlavorId = 28;
                    break;
                case "Espresso Croquant":
                    FlavorId = 29;
                    break;
                case "GOLD":
                    FlavorId = 30;
                    break;
                case "GOLD Van Caramel":
                    FlavorId = 31;
                    break;
                case "Hazelnut":
                    FlavorId = 32;
                    break;
                case "Hibiscus":
                    FlavorId = 33;
                    break;
                case "Hny Cream":
                    FlavorId = 34;
                    break;
                case "Hzn Choc":
                    FlavorId = 35;
                    break;
                case "Ishara":
                    FlavorId = 36;
                    break;
                case "JELLY Van":
                    FlavorId = 37;
                    break;
                case "Karkadee":
                    FlavorId = 38;
                    break;
                case "KARKASHA":
                    FlavorId = 39;
                    break;
                case "KRIKO":
                    FlavorId = 40;
                    break;
                case "Lemon":
                    FlavorId = 41;
                    break;
                case "Low Fat":
                    FlavorId = 42;
                    break;
                case "Low Fat Van Choc":
                    FlavorId = 43;
                    break;
                case "Macadamia":
                    FlavorId = 44;
                    break;
                case "Mandarin":
                    FlavorId = 45;
                    break;
                case "Mango":
                    FlavorId = 46;
                    break;
                case "Mango Sorbet":
                    FlavorId = 47;
                    break;
                case "Maple Walnut":
                    FlavorId = 48;
                    break;
                case "Mastic":
                    FlavorId = 49;
                    break;
                case "Mastic Pistachio":
                    FlavorId = 50;
                    break;
                case "MIX Choc":
                    FlavorId = 51;
                    break;
                case "Mocca":
                    FlavorId = 52;
                    break;
                case "Mocha Croquant":
                    FlavorId = 53;
                    break;
                case "Mocha Croquanto":
                    FlavorId = 54;
                    break;
                case "Moza":
                    FlavorId = 55;
                    break;
                case "Nougat":
                    FlavorId = 56;
                    break;
                case "Papp":
                    FlavorId = 57;
                    break;
                case "Pineapple":
                    FlavorId = 58;
                    break;
                case "Pistachio":
                    FlavorId = 59;
                    break;
                case "Str":
                    FlavorId = 60;
                    break;
                case "Stracciatella":
                    FlavorId = 61;
                    break;
                case "Strawberry":
                    FlavorId = 62;
                    break;
                case "Strawberry Sorbet":
                    FlavorId = 63;
                    break;
                case "Strawberry Van":
                    FlavorId = 64;
                    break;
                case "Strw Mango":
                    FlavorId = 65;
                    break;
                case "Strw Papp":
                    FlavorId = 66;
                    break;
                case "Strw Van Mango":
                    FlavorId = 67;
                    break;
                case "Strw Vanil Apple":
                    FlavorId = 68;
                    break;
                case "StrwPapp":
                    FlavorId = 69;
                    break;
                case "TRIO":
                    FlavorId = 70;
                    break;
                case "Van":
                    FlavorId = 71;
                    break;
                case "Van Caramel":
                    FlavorId = 72;
                    break;
                case "Van Caramel Sce":
                    FlavorId = 73;
                    break;
                case "Van Choc":
                    FlavorId = 74;
                    break;
                case "Van Choc Crsp":
                    FlavorId = 75;
                    break;
                case "Van Choc Sauce":
                    FlavorId = 76;
                    break;
                case "Van Crisp":
                    FlavorId = 77;
                    break;
                case "Van Crml":
                    FlavorId = 78;
                    break;
                case "Van Mngo":
                    FlavorId = 79;
                    break;
                case "Van Mngo Sauce":
                    FlavorId = 80;
                    break;
                case "Van Nuts":
                    FlavorId = 81;
                    break;
                case "Van Strw":
                    FlavorId = 82;
                    break;
                case "Van W Dry Fruit":
                    FlavorId = 83;
                    break;
                case "Van White Choc":
                    FlavorId = 84;
                    break;
                case "VanChocCrsp":
                    FlavorId = 85;
                    break;
                case "Vanilla":
                    FlavorId = 86;
                    break;
                case "Vanilla Choc":
                    FlavorId = 87;
                    break;
                case "Vanilla Dream":
                    FlavorId = 88;
                    break;
                case "Vanilla Mango":
                    FlavorId = 89;
                    break;
                case "Vanilla Seperator":
                    FlavorId = 90;
                    break;
                case "Vanilla Straw":
                    FlavorId = 91;
                    break;
                case "Vanilla Strw":
                    FlavorId = 92;
                    break;
                case "Waffle Mix":
                    FlavorId = 93;
                    break;
                case "White":
                    FlavorId = 94;
                    break;
                case "Ygt":
                    FlavorId = 95;
                    break;
                case "Ygt W Blab":
                    FlavorId = 96;
                    break;
                case "Ygt W Blab Jam":
                    FlavorId = 97;
                    break;
                case "YgtWBlackberrySauce":
                    FlavorId = 98;
                    break;
            }
            return FlavorId;
        }

        #endregion
       
        #region ImportEmployee
       private void btnEmp_Click(object sender, EventArgs e)
       {
           xtraTabControlMain.Enabled = false;
           try
           {
               ImportEmpFromAccess();
               Logger.Info("importing Emp Complated");

           }
           catch (Exception ex)
           {
               Logger.Error("Faild to import Emp from access.", ex);
           }
           ProgressBarMain.EditValue = 0;
           xtraTabControlMain.Enabled = true;
       }
       private void ImportEmpFromAccess()
       {
           OleDbConnection accCon = new OleDbConnection(Properties.Settings.Default.AccessConnectionString);
           OleDbCommand accCmd = new OleDbCommand("", accCon);
           SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
           SqlCommand cmd = new SqlCommand("", con);
           OleDbDataReader accDr = null;
           accCon.Open();
           con.Open();

           accCmd.CommandText = @"SELECT ID, [Personnel Name], Region, Titil FROM Empp";
           accDr = accCmd.ExecuteReader();
           cmd.CommandText = @"IF((SELECT COUNT(*) FROM Employee WHERE EmployeeId = @EmployeeId) = 0)
            BEGIN
            INSERT INTO [dbo].[Employee]
                        (EmployeeId, EmployeeName, JobTitleId, userin, datein)
                    VALUES
                        (@EmployeeId, @EmployeeName, @JobTitleId, @userin, GETDATE())
            END
            ELSE
            BEGIN
            UPDATE [dbo].[Employee] SET 
                 EmployeeName = @EmployeeName, JobTitleId = @JobTitleId, userin = @userin, datein = GETDATE() WHERE EmployeeId = @EmployeeId
            END";
           cmd.Parameters.Add(new SqlParameter("@EmployeeId", SqlDbType.Int));
           cmd.Parameters.Add(new SqlParameter("@EmployeeName", SqlDbType.NVarChar));
           cmd.Parameters.Add(new SqlParameter("@JobTitleId", SqlDbType.SmallInt));
           cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = UserManager.defaultInstance.UserInfo.UserID });

           while (accDr.Read())
           {

               //ProgressBarMain.EditValue = (int)ProgressBarMain.EditValue + 1;
               //double DonePercent = Convert.ToDouble(ProgressBarMain.EditValue) / ProgressBarMain.Properties.Maximum;
               //if (DonePercent * 100 > 1)
               //{
               //    double sec = DateTime.Now.Subtract(TSStart).TotalSeconds / DonePercent;
               //    DateTime endTime = DateTime.Now.AddSeconds(sec);
               //    TimeSpan remainTime = DateTime.Now.AddSeconds(sec).Subtract(DateTime.Now);
               //    lblEstTime.Text = string.Format("[{0}] mins", Convert.ToInt32(remainTime.TotalMinutes));
               //}

               Application.DoEvents();
               //DataSources.dsNM.
               DataSources.dsData.CustomerRow row = dsNM.Customer.NewCustomerRow();

               cmd.Parameters["@EmployeeId"].Value = Convert.ToInt32(accDr.GetValue(0).ToString().Trim());
               if (!Uti.IsNullOrEmpty(accDr.GetValue(1)))
                   cmd.Parameters["@EmployeeName"].Value = accDr.GetValue(1).ToString();
               else
                   cmd.Parameters["@EmployeeName"].Value = DBNull.Value;

               if (!Uti.IsNullOrEmpty(accDr.GetValue(3)))
                   cmd.Parameters["@JobTitleId"].Value = GetJobTitleId(accDr.GetValue(3).ToString());
               else
                   cmd.Parameters["@JobTitleId"].Value = DBNull.Value;

               cmd.Parameters["@userin"].Value = UserManager.defaultInstance.UserInfo.UserID;

               cmd.ExecuteNonQuery();
           }
           ProgressBarMain.EditValue = 0;
           accDr.Close(); accDr.Dispose();
           accCon.Close(); accCon.Dispose();
           con.Close(); con.Dispose();

       }
       private void btnImportEmpExcel_Click(object sender, EventArgs e)
       {
           if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
               return;
           DataTable dt = GetTableFromExcelFile();

           SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
           SqlCommand cmd = new SqlCommand("", con);
           int userin = UserManager.defaultInstance.UserInfo.UserID;
           cmd.CommandText = @"if((select count(*) from Employee where EmployeeId = @EmployeeId) = 0)
                                    begin
                                    INSERT INTO [dbo].Employee
                                    (EmployeeId, EmployeeName, JobTitleId, userin, datein, FakeId)
                                    VALUES
                                    (@EmployeeId, @EmployeeName, @JobTitleId, @userin, GETDATE(), 0)
                                    end
                                    else
                                    begin
                                    UPDATE [dbo].Employee SET 
                                    EmployeeName = @EmployeeName, JobTitleId = @JobTitleId, userin = @userin, datein = GETDATE() WHERE EmployeeId = @EmployeeId
                                    end";
           cmd.Parameters.Add(new SqlParameter("@EmployeeId", SqlDbType.Int));
           cmd.Parameters.Add(new SqlParameter("@EmployeeName", SqlDbType.NVarChar));
           cmd.Parameters.Add(new SqlParameter("@JobTitleId", SqlDbType.SmallInt));
           cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = userin });
           try
           {
               con.Open();
               foreach (DataRow row in dt.Rows)
               {
                   cmd.Parameters["@EmployeeId"].Value = row[0];
                   cmd.Parameters["@EmployeeName"].Value = row[1];
                   cmd.Parameters["@JobTitleId"].Value = GetJobTitleId(row[2].ToString());
                   cmd.ExecuteNonQuery();
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
           if (con != null)
               con.Close();

       }
       private DataTable GetTableFromExcelFile()
       {
           
           Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
           Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
           Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Sheets[1];
           Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

           int rowCount = xlRange.Rows.Count;
           int colCount = xlRange.Columns.Count;

           DataTable dt = new DataTable();
           for (int i = 0; i < colCount; i++)
           {
               dt.Columns.Add(new DataColumn("Cell" + i));
           }

           for (int i = 2; i <= rowCount; i++)
           {
               DataRow row = dt.NewRow();
               for (int j = 1; j < colCount + 1; j++)
               {
                   row[j - 1] = xlRange.Cells[i, j].Value2;
               }
               dt.Rows.Add(row);
           }
           return dt;
       }
       private int GetJobTitleId(string JobTitle)
       {
           int JobTitleId = Employee.UnknownJobTitleId;
           switch (JobTitle.Trim())
           {
               case "Salesman":
               case "salesman'":
                   JobTitleId = 2;
                   break;
               case "Driver":
                   JobTitleId = 3;
                   break;
               case "Supervisor":
                   JobTitleId = 4;
                   break;
               case "Follow Up":
               case "Dis Follow UP":
               case "Follow up ":
                   JobTitleId = 5;
                   break;
               case "Area Manager":
                   JobTitleId = 6;
                   break;
               case "sales Admin":
                   JobTitleId = 7;
                   break;
               case "ASM":
                   JobTitleId = 6;
                   break;
               case "Cash ":
                   JobTitleId = 13;
                   break;
               case "CCSD Manager":
                   JobTitleId = 9;
                   break;
               case "Logistics Manager":
                   JobTitleId = 10;
                   break;
               case "RSM":
                   JobTitleId = 8;
                   break;
               case "Sales Support":
                   JobTitleId = 12;
                   break;
               case "Sales Support manager":
                   JobTitleId = 11;
                   break;
           }
           return JobTitleId;
       }

        #endregion
       
        #region ImportRoute
        private void btnImportRoute_Click(object sender, EventArgs e)
       {
           xtraTabControlMain.Enabled = false;
           try
           {
               ImportRouteFromAccess();
               Logger.Info("importing Route Complated");

           }
           catch (Exception ex)
           {
               Logger.Error("Faild to Route product from access. - " + ex.Message, ex);
           }
           ProgressBarMain.EditValue = 0;
           xtraTabControlMain.Enabled = true;
       }
        private void ImportRouteFromAccess()
       {
           DateTime TSStart = DateTime.Now;
           if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
           {
               return;
           }
           OleDbConnection accCon = new OleDbConnection(OleConnectionString + ofd.FileName);
           OleDbCommand accCmd = new OleDbCommand("", accCon);
           SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
           SqlCommand cmd = new SqlCommand("", con);
           OleDbDataReader accDr = null;
           accCon.Open();
           con.Open();
           /*
            *   [Route Name], 			    0
                [Route Number], 		    1
                [Route Number  system], 	2
                [Sales District #], 		3
                Region, 			        4
                Plant, 				        5
                [Sales District Name], 		6
                [Sales District], 		    7
                RSM, 				        8
                ASM, 				        9
                Supervisor, 			    10
                [Brand Route], 			    11
                [Distribution Channel], 	12
                [Route To Market], 		    13
                Notes				        14
                FROM [0-3  Route Details]
            */
           accCmd.CommandText = "select count(*) from [0-3  Route Details]";
           ProgressBarMain.Properties.Maximum = Convert.ToInt32(accCmd.ExecuteScalar());
           ProgressBarMain.EditValue = 0;
           accCmd.CommandText = @"SELECT [Route Name], [Route Number], [Route Number  system], [Sales District #], Region, 
           Plant, [Sales District Name], [Sales District], RSM, ASM, Supervisor, 
           [Brand Route], [Distribution Channel], [Route To Market], Notes FROM [0-3  Route Details]";
           accDr = accCmd.ExecuteReader();
           cmd.CommandText = @"INSERT INTO dbo.[Routes]
           (RouteId, RouteNumber, RouteName, PlantSalesDistrictId, Supervisor, ASM, RSM, RouteBrandId, RouteBrandIdOld
           , RouteStatusId, Descriptions, userin, datein)
            VALUES
           ((SELECT ISNULL(MAX(RouteId) + 1, 1) FROM  Routes), @RouteNumber, @RouteName, @PlantSalesDistrictId, @Supervisor, @ASM, @RSM, @RouteBrandId, @RouteBrandIdOld
           , @RouteStatusId, @Descriptions, @userin, GETDATE())";

           cmd.Parameters.Add(new SqlParameter("@RouteNumber", SqlDbType.NVarChar));
           cmd.Parameters.Add(new SqlParameter("@RouteName", SqlDbType.NVarChar));
           cmd.Parameters.Add(new SqlParameter("@PlantSalesDistrictId", SqlDbType.SmallInt));
           cmd.Parameters.Add(new SqlParameter("@Supervisor", SqlDbType.Int));
           cmd.Parameters.Add(new SqlParameter("@ASM", SqlDbType.Int));
           cmd.Parameters.Add(new SqlParameter("@RSM", SqlDbType.Int));
           cmd.Parameters.Add(new SqlParameter("@RouteBrandId", SqlDbType.SmallInt));
           cmd.Parameters.Add(new SqlParameter("@RouteBrandIdOld", SqlDbType.SmallInt));
           cmd.Parameters.Add(new SqlParameter("@RouteStatusId", SqlDbType.SmallInt));
           cmd.Parameters.Add(new SqlParameter("@Descriptions", SqlDbType.NVarChar));
           cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int));

           while (accDr.Read())
           {
               ProgressBarMain.EditValue = (int)ProgressBarMain.EditValue + 1;
               double DonePercent = Convert.ToDouble(ProgressBarMain.EditValue) / ProgressBarMain.Properties.Maximum;
               if (DonePercent * 100 > 1)
               {
                   double sec = DateTime.Now.Subtract(TSStart).TotalSeconds / DonePercent;
                   DateTime endTime = DateTime.Now.AddSeconds(sec);
                   TimeSpan remainTime = DateTime.Now.AddSeconds(sec).Subtract(DateTime.Now);
                   lblEstTime.Text = string.Format("[{0}] mins", Convert.ToInt32(remainTime.TotalMinutes));
               }
               Application.DoEvents();

               //DataSources.dsNM.RoutesRow row = dsNM.Routes.NewRoutesRow();

               cmd.Parameters["@RouteName"].Value = accDr.GetValue(0).ToString().Trim();
               cmd.Parameters["@RouteNumber"].Value = Convert.ToInt32(accDr.GetValue(1).ToString().Trim());
               if (!Uti.IsNullOrEmpty(accDr.GetValue(7)))
                   cmd.Parameters["@PlantSalesDistrictId"].Value = Route.GetPlantSalesDistrictId(accDr.GetValue(5).ToString().Trim(), accDr.GetValue(7).ToString().Trim());
               else
                   cmd.Parameters["@PlantSalesDistrictId"].Value = 1;

               if (!Uti.IsNullOrEmpty(accDr.GetValue(10)))
                   cmd.Parameters["@Supervisor"].Value = GetEmpId(accDr.GetValue(10).ToString());
               else 
                   cmd.Parameters["@Supervisor"].Value = 1;
               if (!Uti.IsNullOrEmpty(accDr.GetValue(9)))
                   cmd.Parameters["@ASM"].Value = GetEmpId(accDr.GetValue(9).ToString());
               else
                   cmd.Parameters["@ASM"].Value = 1;
               if (!Uti.IsNullOrEmpty(accDr.GetValue(8)))
                   cmd.Parameters["@RSM"].Value = GetEmpId(accDr.GetValue(8).ToString());
               else
                   cmd.Parameters["@RSM"].Value = 1;
               if (!Uti.IsNullOrEmpty(accDr.GetValue(11)))
               {
                   cmd.Parameters["@RouteBrandId"].Value = Route.GetRouteBrandId(accDr.GetValue(11).ToString());
                   cmd.Parameters["@RouteBrandIdOld"].Value = cmd.Parameters["@RouteBrandId"].Value;
               }
               else
               {
                   cmd.Parameters["@RouteBrandId"].Value = 1;
                   cmd.Parameters["@RouteBrandIdOld"].Value = 1;
               }
               cmd.Parameters["@RouteStatusId"].Value = (int)Types.RouteStatus.Online;
               if (!Uti.IsNullOrEmpty(accDr.GetValue(14)))
                   cmd.Parameters["@Descriptions"].Value = accDr.GetValue(14).ToString().Trim();
               else
                   cmd.Parameters["@Descriptions"].Value = DBNull.Value;

               cmd.Parameters["@userin"].Value = UserManager.defaultInstance.UserInfo.UserID;
               cmd.ExecuteNonQuery();
           }
           ProgressBarMain.EditValue = 0;
           accDr.Close(); accDr.Dispose();
           accCon.Close(); accCon.Dispose();
           con.Close(); con.Dispose();
       }
        private int GetEmpId(string EmpName)
        {
            int ID = Employee.UnknownEmployeeId;
            switch (EmpName.Trim())
            {
                case "Abdel Hamied El Atfe":
                    ID = 4250149;//Abdel-Hamid Aly El Atfy
                    break;
                case "Amir EL Hossary":
                    ID = 10247477;//Amir Hassan El Hossary 
                    break;
                case "Mohamed Abdel Monem":
                    ID = 10470684;//Mohamed AbdelMonem
                    break;
                case "Mohamed Salah":
                    ID = 4251452;//Mohamed Salah-El Din Mostafa
                    break;
                case "Zaki Selim":
                    ID = 10423596;//zaki slim
                    break;
                case "Ahmed Saad":
                    ID = 4251035;//Ahmed Saad Ibrahim
                    break;
                case "Alaa Mohamady":
                    ID = 4251541;//Alaa-El Din Mohammady Ibrahim
                    break;
                case "Askary Abdel Salam":
                    ID = 4250308;//Askari Abdel-Salam Youssef
                    break;
                case "Basem Hassan Anwar":
                    ID = 4251146;//Bassem Hassan Saleh
                    break;
                case "Ebrahim Esmaeil ":
                    ID = 4250966;//Ibrahim Ismail Bayoumy
                    break;
                case "Eid El Tanany ":
                    ID = 4250153;//Eid Abdel-Motteleb El Tanany
                    break;
                case "Hassan El Mahdy":
                    ID = 4250722;//Hassan Ibrahim El Mahdy
                    break;
                case "Medhat Yasin ":
                    ID = 4250786;//Medhat Mahmoud Abdel-Fattah
                    break;
                case "Mohamed El Shoura":
                    ID = 4251748;//Mohamed Amin El Shoura
                    break;
                case "Nader Mahfouz":
                    ID = 4250500;//Nader Mahfouz Mohamed
                    break;
                case "Salah Saad Ali ":
                    ID = 4250445;//Salah Saad Aly
                    break;
                case "Abd El Maksoud":
                    ID = 4250749;//Abdel Maksoud Mohamed
                    break;
                case "Abdel Baset Ali ":
                    ID = 4251152;//Abdel-Basset Aly El Atfy
                    break;
                case "Adel Mowafy ":
                    ID = 4251354;//Adel el mwafi Nour el den 
                    break;
                case "Ahmed Abdel Azim":
                    ID = 4251535;//Ahmed Abdel-Azim 
                    break;
                case "Ahmed Abdel Moneim":
                    ID = 4250075;//Ahmed Abdel-Moneim Ahmed
                    break;
                case "Ahmed Abdelhamid":
                    ID = 10084582;//Ahmed Abd el hamid
                    break;
                case "Ahmed Abo El Maaty ":
                    ID = 4251117;//Ahmed Abo-El Maaty Abdel-Razek
                    break;
                case "Ahmed Aly":
                case "Ahmed Ismaeal":
                    ID = 10234754;//Ahmed Ismail Aly
                    break;
                case "Ahmed Daif":
                    ID = 4251338;//Ahmed Mohamed-Deif El Mallah
                    break;
                case "Ahmed El sayed":
                    ID = 4251790;//Ahmed El Sayed Rezk
                    break;
                case "Ahmed Ibrahim Abd ELHafez":
                    ID = 10146724;//Ahmed Ibrahim Abdel-Hafez
                    break;
                case "Ahmed Rashed":
                    ID = 10081336;//Ahmed Rashed Mohamed
                    break;
                case "Ahmed Salah":
                case "Ahmed Saleh":
                    ID = 10095840;//Ahmed Salah
                    break;
                case "Ahmed Zain ":
                    ID = 10235927;//Ahmed zien
                    break;
                case "Alaa Abd El Rehem":
                    ID = 10082835;//Alaa Abdel-Rehim Sayed
                    break;
                case "Alaa Mohamed":
                    ID = 10088545;//Alaa Mohamed Sayed
                    break;
                case "Ali Abdalaa":
                    ID = 4250412;//Aly Abd-Allah Hussein
                    break;
                case "Aly Sharaf":
                    ID = 4251168;//Aly Sharaf Mohamed
                    break;
                case "Amr Tantawi":
                    ID = 10162958;//Amr eltantawy
                    break;
                case "Amro Esaid Mohamed Tolba":
                    ID = 10087913;//Amr El said Mohamed Tolba
                    break;
                case "Ashraf  Mahsoub":
                    ID = 4251542;//Ashraf mahsoob
                    break;
                case "Ashraf Farouk ":
                    ID = 4250543;//Ashraf Farouk Abdel-Kader
                    break;
                case "Ashraf Mohamed ":
                    ID = 10506485;//Ashraf Mohamed
                    break;
                case "Assem Abdelfatha":
                    ID = 4251008;//Assem Abdel-Fattah Khedr
                    break;
                case "Ayman Fathy Abd Elhady":
                    ID = 4251786;//Ayman Fathy Abdel-Hady
                    break;
                case "Baha El-Din Abbas":
                    ID = 4251286;//Bahaa AlDin Abbas
                    break;
                case "Ehab El Sayed Hassan":
                    ID = 4251013;//Ehab El Sayed Hassan
                    break;
                case "El-Sayed Mohamed Ateya Mosa":
                    ID = 4251434;//El Sayed Mohamed Attia
                    break;
                case "Emad Thabet ":
                    ID = 4251857;//Emad sabet
                    break;
                case "Essam El-Shazly":
                    ID = 4250926;//Essam El Shazly Mostafa
                    break;
                case "Gamal Abdel Hamied":
                    ID = 4250432;//Gamal Abdel-Hamid Aly
                    break;
                case "Gamal El Sayed":
                    ID = 4250839;//Gamal El Sayed Salem
                    break;
                case "Gomaa Mohamed":
                    ID = 4250232;//Gomaa Mohamed
                    break;
                case "Hamdy Abdel Maksoud ":
                    ID = 4251787;//Hamdy Abdel-Maksoud Hassan
                    break;
                case "Hamdy Ali Mahmoud Ali":
                    ID = 10088028;//Hamdy Ali
                    break;
                case "Hany Zein El Abdeen ":
                    ID = 10081269;//Hany Zain El-Aabedin Hassanien
                    break;
                case "Helmy Awad ":
                    ID = 4250082;//Helmy Awad
                    break;
                case "Hesham Fahmy ":
                    ID = 4250967;//Hesham Aly Fahmy
                    break;
                case "Hussein Hamed ":
                    ID = 10105283;//Hussein hamed 
                    break;
                case "Hussein Ibrahim ":
                    ID = 4250595;//Hussein Ibrahim Mohamed
                    break;
                case "Hussein Taher":
                    ID = 10081058;//Hussien Taher Morsi
                    break;
                case "Khaled  Abdel Salam":
                    ID = 4250729;//Khaled Abdel-Salam Sultan
                    break;
                case "Khaled Farooq":
                    ID = 4251532;//Khaled Farouk Mostafa
                    break;
                case "Khaled Meslhy":
                    ID = 4251515;//Khaled Ibrahim Meselhy
                    break;
                case "Khaled Youssief":
                    ID = 10090716;//Khaled Youssef Ahmed
                    break;
                case "Magdy Otish ":
                    ID = 4250310;//Magdy Oteish Gomaa
                    break;
                case "Mahmoud Ghita":
                    ID = 10506481;//Mahmoud Ahmed Ghita
                    break;
                case "Mahmoud Saad":
                    ID = 10336042;//Mahmoud Saad Ghareib
                    break;
                case "Mahmoud Shibl":
                    ID = 4251053;//Mahmoud Shebl El Azab
                    break;
                case "Mohamed  Ahmed Hashem":
                    ID = 4250717;//Mohamed Ahmed Mohmaed Hashem
                    break;
                case "Mohamed A. Wahab":
                    ID = 10234301;//Mohamed Abdel Wahab Selim
                    break;
                case "Mohamed Abo Zaid":
                    ID = 10110082;//Mohamed Samir Abou-Zaid
                    break;
                case "Mohamed Ali":
                    ID = 10163420;//Mohamed Aly Abdel -Rahim
                    break;
                case "Mohamed Eid":
                    ID = 10278734;//Mohamed Eid Hassan
                    break;
                case "Mohamed Ibrahim Aboelfotoh":
                    ID = 10081708;//Mahmoud Ibrahim
                    break;
                case "Mohamed Lotfy":
                    ID = 10147025;//Mohamed Lotfy
                    break;
                case "Mohamed Mohamady":
                    ID = 10080940;//Mohamed Mohammady Ibrahim
                    break;
                case "Mohamed Mosaad":
                    ID = 10496663;//Mohamed Mosaad Ibrahim
                    break;
                case "Mohamed Mostafa":
                    ID = 10229102;//Mohamed Mostafa El-Sayed
                    break;
                case "Mohamed Samir":
                    ID = 10110082;//Mohamed Samir Abou-Zaid
                    break;
                case "Mohamed Sanad":
                    ID = 4251803;//Mohamed Fathy Sanad
                    break;
                case "Mohammed Tawfek":
                    ID = 4251181;//Mohamed tawfik
                    break;
                case "Morad ahmed mahmoud gazy":
                    ID = 10100562;//Morad Ahmed Mahmoud
                    break;
                case "Mostafa El-Bakatoushy":
                    ID = 10088736;//Mostafa Mohamed El-Bakatoushy
                    break;
                case "Mostafa Gaber":
                    ID = 4250411;//Mostafa Gaber Mostafa
                    break;
                case "Omar Taha":
                    ID = 10081352;//Omer Taha El Kharsa
                    break;
                case "Omr A.Hady":
                    ID = 4251351;//Omar Ahmed Abdel-Hady
                    break;
                case "Rabeh El dosoky":
                    ID = 4251400;//Rabeh Ahmed El Desouky
                    break;
                case "Rabie Marzouk":
                    ID = 10081301;//Rabiea Marzouk Mohamed
                    break;
                case "Ramy Osman ":
                    ID = 10403120;//Ramy Osman Osman
                    break;
                case "Rashad Mohamed Mohamed Ibrahim ":
                    ID = 10088031;//Rashad Mohamed Ibrahim
                    break;
                case "Samhe Amin":
                    ID = 10088550;//Sameh Ahmed Amin
                    break;
                case "Samy Wassal":
                    ID = 4251687;//Samy Mohamed Wassal
                    break;
                case "Sayed Abd Allah":
                    ID = 4251045;//El Sayed Abd-Allah Mahmoud
                    break;
                case "Sayed Elwan":
                    ID = 10088543;//saied elwan
                    break;
                case "Sherif Ahmed ":
                    ID = 10081701;//Sherif Ahmed
                    break;
                case "Sherif El Baz":
                    ID = 10506478;//Shrif El Baz
                    break;
                case "Shokry Mohamed":
                    ID = 4250472;//Shokry Mohamed Fathy Abo El-Fetouh
                    break;
                case "Tamer mohamed Abd Elgawad":
                    ID = 10238630;//Tamer Mahmoud Abdel-Gawad
                    break;
                case "Waled Mohamed Abd Allaa":
                    ID = 10090698;//Walid Mohamed Abdallah
                    break;
                case "Yasser Abbas":
                    ID = 4251655;//Yasser Abbass Hassan
                    break;
                case "Yehia":
                    ID = 10169464;//Yehia Elsayed
                    break;
                case "Zakareya Megawry":
                    ID = 4250574;//Zakri maghawry
                    break;
            }
            return ID;
        }

        #endregion

        #region ImportMaster
        private void btnImportMaster_Click(object sender, EventArgs e)
        {
            xtraTabControlMain.Enabled = false;
            try
            {
                ImportMasterFromAccess();
                Logger.Info("importing Master Complated");

            }
            catch (Exception ex)
            {
                Logger.Error("Faild to Import Master from access. - " + ex.Message, ex);
            }
            ProgressBarMain.EditValue = 0;
            xtraTabControlMain.Enabled = true;
        }
        private bool ImportMasterFromAccess()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return false;

            bool output = false;
            dsNM.BillingDetails.Clear();
            int NewCustomerFounded = 0;
            int NewRouteFounded = 0;
            int NewProductFounded = 0;
            DataSources.dsDataTableAdapters.ProductTableAdapter adpProductTable = new DataSources.dsDataTableAdapters.ProductTableAdapter();
            DateTime dtStart = DateTime.Now;
            OleDbConnection accCon = new OleDbConnection(OleConnectionString + dlg.FileName);
            OleDbCommand accCmd = new OleDbCommand("", accCon);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            SqlCommand cmd2 = new SqlCommand("", con);
            OleDbDataReader accDr = null;
            DateTime datein = Managers.DataManager.defaultInstance.GetServerDatetime;
            int userin = UserManager.defaultInstance.UserInfo.UserID;

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                SplashScreenManager.Default.SetWaitFormDescription("Loading Customers Informations [2/4]");
                adpCustomer.Fill(dsNM.Customer);
                SplashScreenManager.Default.SetWaitFormDescription("Loading Routes Informations [3/4]");
                adpRoute.Fill(dsNM.Routes);
                SplashScreenManager.Default.SetWaitFormDescription("Loading Products Informations [4/4]");
                adpProductTable.Fill(dsNM.Product);
            }));
            SplashScreenManager.CloseForm();
            accCon.Open();
            con.Open();
            accCmd.CommandText = "select  count(*) from [0-1  Master] WHERE [Billing date for bil]";// BETWEEN #1/1/2013# AND #1/31/2013#

            int ProcessedCounter = 0;
            int ProcessedMax = Convert.ToInt32(accCmd.ExecuteScalar());
            this.Invoke(new MethodInvoker(() =>
            {
                ProgressBarMain.Properties.Maximum = ProcessedMax;
                ProgressBarMain.EditValue = ProcessedCounter;
            }));
//            accCmd.CommandText = @"SELECT [Billing Document], [Sold-to party], [Billing date for bil], [Material Number], [Billing Type], [Reference Document N], 
//            [Sales unit], [Condition type], [Actual Invoiced Quan], [Condition value], [Route & Sold], [Route OLD] FROM [0-1  Master] ";//WHERE [Billing date for bil] BETWEEN #1/1/2013# AND #1/31/2013#
            accCmd.CommandText = @"SELECT [Billing Document], [Sold-to party], [Billing date for bil], [Material Number], [Billing Type], [Reference Document N], 
            [Sales unit], [Condition type], [Actual Invoiced Quan], [Condition value], [Route & Sold] FROM [0-1  Master] ";//WHERE [Billing date for bil] BETWEEN #1/1/2013# AND #1/31/2013#
            accDr = accCmd.ExecuteReader();

            int i = 0;
            while (accDr.Read())
            {
                ProcessedCounter++;
                if (ProcessedCounter % 500 == 1)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        lblEstTime.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMain.EditValue = ProcessedCounter;
                        lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);
                        Application.DoEvents();
                    }));
                }
                DataSources.dsData.BillingDetailsRow row = dsNM.BillingDetails.NewBillingDetailsRow();
                
                try
                {
                    i++;
                    if (i.ToString() == "2607087")
                    {
                        string a = "";
                    }
                    if (accDr.GetValue(0).ToString().Trim().StartsWith("Dist"))
                    {
                        row.BillingDocument = Convert.ToInt64(Uti.ConvertStringToInt(accDr.GetValue(0).ToString().Trim()));
                        row.SoldToParty = Customer.UnknownCustomerId;
                        row.Unreal = true;
                    }
                    else
                    {
                        row.BillingDocument = Convert.ToInt64(accDr.GetValue(0).ToString().Trim());
                        row.SoldToParty = Convert.ToInt32(accDr.GetValue(1).ToString().Trim());
                        row.Unreal = false;
                    }
                    //if (accDr.GetValue(1).ToString().Trim() != string.Empty)
                    //{
                    //    row.SoldToParty = Convert.ToInt32(accDr.GetValue(1).ToString().Trim());
                    //}
                    row.BillingDate = Convert.ToDateTime(accDr.GetValue(2).ToString().Trim());
                    Managers.BillingDetails.GetConditionTypeId(accDr.GetValue(7).ToString(), ref row);
                    row.MaterialNumber = Convert.ToInt32(accDr.GetValue(3).ToString().Trim());
                    Managers.BillingDetails.GetBillTypeId(accDr.GetValue(4).ToString(), ref row);
                    row.ReferenceDocumentN = accDr.GetValue(5).ToString().Trim();

                    //row.RouteNumber = Route.GetRouteNumber(accDr.GetValue(10).ToString().Trim(), dsNM.Routes).RouteNumber;
                    //row.ActualRouteNumber = Route.GetRouteNumber(accDr.GetValue(11).ToString().Trim(), dsNM.Routes).RouteNumber;
                    //Route OLD

                    if (accDr.GetValue(10).ToString().Trim() == Route.DistributorsRouteId)//000001
                    {
                        row.RouteNumber = row.SoldToParty.ToString();
                        row.ActualRouteNumber = row.RouteNumber;
                    }
                    else if (accDr.GetValue(10).ToString().Trim() == Route.ErrorRouteId || accDr.GetValue(10).ToString().Trim() == string.Empty)//999999 or NULL
                    {
                        row.RouteNumber = Managers.RouteCustomer.GetRouteNumberFromCustomerId(row.SoldToParty);
                        row.ActualRouteNumber = row.RouteNumber;
                    }
                    else
                    {
                        DataSources.dsData.RoutesRow RouteRow = Route.GetRouteNumber(accDr.GetValue(10).ToString().Trim(), dsNM.Routes);
                        if (RouteRow.RowState == DataRowState.Detached)
                        {
                            RouteRow.RouteNumber = accDr.GetValue(10).ToString().Trim();
                            dsNM.Routes.AddRoutesRow(RouteRow);
                            RouteRow.EndEdit();
                            adpRoute.Update(RouteRow);
                            Logger.Info("[New Route Added] : " + row["Route"]);
                            NewRouteFounded++;
                        }
                        row.RouteNumber = RouteRow.RouteNumber;
                        row.ActualRouteNumber = row.RouteNumber;
                        //row.ActualRouteNumber = Route.GetRouteNumber(accDr.GetValue(11).ToString().Trim(), dsNM.Routes).RouteNumber;
                    }
                    
                    if (accDr.GetValue(6).ToString().Trim().ToLower() == "ea")
                        row.ActualInvoicedQuan = Convert.ToDouble(accDr.GetValue(8).ToString().Trim());
                    else if (accDr.GetValue(6).ToString().Trim().ToLower() == "cs")
                    {
                        row.ActualInvoicedQuan = dsNM.Product.FindByMaterialNumber(row.MaterialNumber).Quantity * Convert.ToDouble(accDr.GetValue(8).ToString().Trim());
                    }
                    else
                        throw new Exception("Error in [Sales unit] = " + accDr.GetValue(6).ToString());

                    row.ConditionValue = Convert.ToDouble(accDr.GetValue(9).ToString().Trim());
                    row.datein = datein;
                    row.userin = userin;
                    dsNM.BillingDetails.AddBillingDetailsRow(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(i.ToString());
                    string x = string.Empty;
                    //throw ex;
                }
            }
            Logger.Debug("Bulk Generated ...");

            //Saving Updated Data As Bulks
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            SplashScreenManager.Default.SetWaitFormDescription("Updating Billing Details ..."); Application.DoEvents();
            if (!BillingDetails.UpdateBulkBillingDetails(cmd, dsNM.BillingDetails))
                MsgDlg.Show("Update Billing Details Failed", Types.MessageType.Error);
            else
            {
                Logger.Info("New Billing Details Saved " + dsNM.BillingDetails.Count);
                output = true;
            }
            Logger.Info("New Customers Saved " + NewCustomerFounded); Logger.Info("New Routes Saved " + NewRouteFounded);
            Logger.Info("New Product Saved " + NewProductFounded); Logger.Info("New R3 Data Saved " + dsNM.BillingDetails.Count);
            Logger.Debug("Bulk Saved ...");

            dsNM.BillingDetails.Clear();
            dsNM.Customer.Clear();
            ProgressBarMain.EditValue = 0;
            accDr.Close(); accDr.Dispose();
            accCon.Close(); accCon.Dispose();
            con.Close(); con.Dispose();
            GC.Collect(); GC.WaitForPendingFinalizers();
            SplashScreenManager.CloseForm();

            return output;
        }
        private void ImportMasterFromAccess_Deleted()
        {
//            DataSources.dsDataTableAdapters.ProductTableAdapter adpProduct = new DataSources.dsDataTableAdapters.ProductTableAdapter();
//            DataSources.dsDataTableAdapters.RoutesTableAdapter adpRoute = new DataSources.dsDataTableAdapters.RoutesTableAdapter();
//            DataSources.dsData.BillingDetailsDataTable tbl = new DataSources.dsData.BillingDetailsDataTable();
//            DataSources.dsData.ProductDataTable tblProduct = new DataSources.dsData.ProductDataTable();
//            DataSources.dsData.RoutesDataTable tblRoute = new DataSources.dsData.RoutesDataTable();

//            DateTime TSStart = DateTime.Now;
//            OleDbConnection accCon = new OleDbConnection(Properties.Settings.Default.AccessConnectionString);
//            OleDbCommand accCmd = new OleDbCommand("", accCon);
//            SqlConnection con = new SqlConnection(Properties.Settings.Default.MainConnectionString);
//            SqlCommand cmd = new SqlCommand("", con);
//            SqlCommand cmd2 = new SqlCommand("", con);
//            OleDbDataReader accDr = null;

//            SqlBulkCopy bulkCopy = new SqlBulkCopy(con);
//            bulkCopy.ColumnMappings.Clear();
//            bulkCopy.ColumnMappings.Add("BillingDocument", "BillingDocument"); bulkCopy.ColumnMappings.Add("SoldToParty", "SoldToParty");
//            bulkCopy.ColumnMappings.Add("RouteId", "RouteId"); bulkCopy.ColumnMappings.Add("BillingDate", "BillingDate");
//            bulkCopy.ColumnMappings.Add("ConditionTypeId", "ConditionTypeId"); bulkCopy.ColumnMappings.Add("MaterialNumber", "MaterialNumber");
//            bulkCopy.ColumnMappings.Add("BillTypeId", "BillTypeId"); bulkCopy.ColumnMappings.Add("ReferenceDocumentN", "ReferenceDocumentN");
//            bulkCopy.ColumnMappings.Add("ActualInvoicedQuan", "ActualInvoicedQuan"); bulkCopy.ColumnMappings.Add("ConditionValue", "ConditionValue");
//            bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

//            adpProduct.Fill(tblProduct);
//            adpRoute.Fill(tblRoute);

//            accCon.Open();
//            con.Open();
//            accCmd.CommandText = "select  count(*) from [0-1  Master] WHERE [Billing date for bil] BETWEEN #1/1/2013# AND #1/31/2013#";
//            ProgressBarMain.Properties.Maximum = Convert.ToInt32(accCmd.ExecuteScalar());
//            ProgressBarMain.EditValue = 0;
//            accCmd.CommandText = @"SELECT [Billing Document], [Sold-to party], [Billing date for bil], [Material Number], [Billing Type], [Reference Document N], 
//            [Sales unit], [Condition type], [Actual Invoiced Quan], [Condition value], [Route & Sold] FROM [0-1  Master] WHERE [Billing date for bil] BETWEEN #1/1/2013# AND #1/31/2013#";
//            accDr = accCmd.ExecuteReader();
//            cmd.CommandText = @"IF((SELECT COUNT(*) FROM BillingDetails WHERE BillingDocument = @BillingDocument AND ConditionTypeId = @ConditionTypeId AND MaterialNumber = @MaterialNumber) = 0)
//            BEGIN
//            INSERT INTO [dbo].BillingDetails
//            (BillingDocument, SoldToParty, RouteId, BillingDate, ConditionTypeId, MaterialNumber, BillTypeId, ReferenceDocumentN, 
//            ActualInvoicedQuan, ConditionValue, userin, datein)
//            VALUES
//            (@BillingDocument, @SoldToParty, @RouteId, @BillingDate, @ConditionTypeId, @MaterialNumber, @BillTypeId, @ReferenceDocumentN, 
//            @ActualInvoicedQuan, @ConditionValue, @userin, GETDATE())
//            END
//            ELSE
//            BEGIN
//            UPDATE [dbo].BillingDetails SET BillingDocument = @BillingDocument, SoldToParty = @SoldToParty, RouteId = @RouteId, BillingDate = @BillingDate,
//            ConditionTypeId = @ConditionTypeId, MaterialNumber = @MaterialNumber, BillTypeId = @BillTypeId, ReferenceDocumentN = @ReferenceDocumentN,
//            ActualInvoicedQuan = @ActualInvoicedQuan, ConditionValue = @ConditionValue, userin = @userin, datein = GETDATE()
//            WHERE BillingDocument = @BillingDocument AND ConditionTypeId = @ConditionTypeId AND MaterialNumber = @MaterialNumber
//            END ";


//            DateTime datein = Managers.DataManager.defaultInstance.GetServerDatetime;
//            int userin = UserManager.defaultInstance.UserInfo.UserID;
//            while (accDr.Read())
//            {
//                ProgressBarMain.EditValue = (int)ProgressBarMain.EditValue + 1;
//                lblCount.Text = string.Format("{0}/{1}", ProgressBarMain.Properties.Maximum, ProgressBarMain.EditValue);
//                double DonePercent = Convert.ToDouble(ProgressBarMain.EditValue) / ProgressBarMain.Properties.Maximum;
//                if (DonePercent * 100 > 1)
//                {
//                    double sec = DateTime.Now.Subtract(TSStart).TotalSeconds / DonePercent;
//                    DateTime endTime = DateTime.Now.AddSeconds(sec);
//                    TimeSpan remainTime = DateTime.Now.AddSeconds(sec).Subtract(DateTime.Now);
//                    lblEstTime.Text = string.Format("[{0}] mins", Convert.ToInt32(remainTime.TotalMinutes));
//                }
//                Application.DoEvents();

//                DataSources.dsData.BillingDetailsRow row = tbl.NewBillingDetailsRow();
//                try
//                {
//                    MessageBox.Show(accDr.GetValue(0).ToString().Trim());
//                    row.BillingDocument = Convert.ToInt64(accDr.GetValue(0).ToString().Trim());
//                    if (accDr.GetValue(1).ToString().Trim() != string.Empty)
//                    {
//                        row.SoldToParty = Convert.ToInt32(accDr.GetValue(1).ToString().Trim());
//                    }
                    
//                    //cmd2.CommandText = string.Format(@"SELECT RouteId FROM Routes WHERE RouteNumber = {0}", accDr.GetValue(10).ToString().Trim());
//                    //row.RouteId = Convert.ToInt32(cmd2.ExecuteScalar());
//                    row.RouteNumber = Route.GetRouteNumber(accDr.GetValue(10).ToString().Trim(), tblRoute).RouteNumber;
//                    row.BillingDate = Convert.ToDateTime(accDr.GetValue(2).ToString().Trim());
//                    row.ConditionTypeId = GetConditionTypeId(accDr.GetValue(7).ToString());
//                    row.MaterialNumber = Convert.ToInt32(accDr.GetValue(3).ToString().Trim());
//                    row.BillTypeId = GetBillTypeId(accDr.GetValue(4).ToString());
//                    row.ReferenceDocumentN = accDr.GetValue(3).ToString().Trim();
//                    if (accDr.GetValue(6).ToString().Trim().ToLower() == "ea")
//                        row.ActualInvoicedQuan = Convert.ToDouble(accDr.GetValue(8).ToString().Trim());
//                    else if (accDr.GetValue(6).ToString().Trim().ToLower() == "cs")
//                    {
//                        //cmd2.CommandText = string.Format(@"SELECT Quantity FROM Product WHERE MaterialNumber = {0}", row.MaterialNumber);
//                        //row.ActualInvoicedQuan = Convert.ToDouble(cmd2.ExecuteScalar());
//                        row.ActualInvoicedQuan = tblProduct.FindByMaterialNumber(row.MaterialNumber).Quantity;
//                    }
//                    else
//                        throw new Exception("Error in [Sales unit] = " + accDr.GetValue(6).ToString());
//                    row.ConditionValue = Convert.ToDouble(accDr.GetValue(9).ToString().Trim());
//                    row.datein = datein;
//                    row.userin = userin;
//                    tbl.AddBillingDetailsRow(row);
//                }
//                catch (Exception ex)
//                {
//                    string x = string.Empty;
//                }
                


//                if (tbl.Count == 1000000 || !accDr.HasRows)
//                {
//                    string tablename = string.Format("BillingDetails{0}{1}{2}{3}{4}{5}{6}", TSStart.Year, TSStart.Month, TSStart.Day, TSStart.Hour, TSStart.Minute, TSStart.Second, TSStart.Millisecond);
//                    cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM BillingDetails WHERE 1 = 0;", tablename);
//                    Logger.InfoFormat("Creating Temp table '{0}' - {1}", tablename, cmd.ExecuteNonQuery());

//                    bulkCopy.DestinationTableName = tablename;
//                    bulkCopy.BatchSize = tbl.Count;
//                    bulkCopy.WriteToServer(tbl);

//                    cmd.CommandText = string.Format(@"merge into BillingDetails as Target 
//                    using {0} as Source on Target.BillingDetailsId=Source.BillingDetailsId
//                    when matched then 
//                    update set Target.BillingDocument=Source.BillingDocument,
//                    Target.SoldToParty=Source.SoldToParty,
//                    Target.RouteId=Source.RouteId,
//                    Target.BillingDate=Source.BillingDate,
//                    Target.ConditionTypeId=Source.ConditionTypeId,
//                    Target.MaterialNumber=Source.MaterialNumber,
//                    Target.BillTypeId=Source.BillTypeId,
//                    Target.ReferenceDocumentN=Source.ReferenceDocumentN,
//                    Target.ActualInvoicedQuan=Source.ActualInvoicedQuan,
//                    Target.ConditionValue=Source.ConditionValue,
//                    Target.userin=Source.userin,
//                    Target.datein=Source.datein
//                    when not matched then 
//                    insert (BillingDocument,SoldToParty, RouteId, BillingDate, ConditionTypeId, MaterialNumber, BillTypeId, ReferenceDocumentN, ActualInvoicedQuan, ConditionValue, userin, datein) values 
//                    (Source.BillingDocument,Source.SoldToParty, Source.RouteId, Source.BillingDate, Source.ConditionTypeId, Source.MaterialNumber, Source.BillTypeId, 
//                    Source.ReferenceDocumentN, Source.ActualInvoicedQuan, Source.ConditionValue, Source.userin, Source.datein);", tablename);
//                    Logger.InfoFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
//                    cmd.CommandText = string.Format(@"DROP TABLE {0}", tablename);
//                    Logger.InfoFormat("Temp Table Droped - {0}", cmd.ExecuteNonQuery());

//                    tbl.Rows.Clear();
//                }
//            }
            

//            ProgressBarMain.EditValue = 0;
//            accDr.Close(); accDr.Dispose();
//            accCon.Close(); accCon.Dispose();
//            con.Close(); con.Dispose();
        }
        
        #endregion
 
    } 
       
}
