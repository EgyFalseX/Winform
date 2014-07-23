using log4net;
using NestleICSales.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleICSales.Managers
{
    public static class BillingDetails
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(BillingDetails));
        public static void GetConditionTypeId(string ConditionType, ref DataSources.dsData.BillingDetailsRow SqlRow)
        {
            ConditionType = ConditionType.ToUpper();
            if (ConditionType == Types.ConditionType.ZPR0.ToString())
                SqlRow.ConditionTypeId = (short)Types.ConditionType.ZPR0;
            else if (ConditionType == Types.ConditionType.Z001.ToString())
                SqlRow.ConditionTypeId = (short)Types.ConditionType.Z001;
            else if (ConditionType == Types.ConditionType.Z101.ToString())
                SqlRow.ConditionTypeId = (short)Types.ConditionType.Z101;
            else if (ConditionType == Types.ConditionType.R100.ToString())
                SqlRow.ConditionTypeId = (short)Types.ConditionType.R100;
        }
        public static void GetBillTypeId(string BillingType, ref DataSources.dsData.BillingDetailsRow SqlRow)
        {
            BillingType = BillingType.ToUpper();

            if (BillingType == Types.BillingType.F2.ToString())
                SqlRow.BillTypeId = (short)Types.BillingType.F2;
            else if (BillingType == Types.BillingType.RE.ToString())
                SqlRow.BillTypeId = (short)Types.BillingType.RE;
            else if (BillingType == Types.BillingType.S1.ToString())
                SqlRow.BillTypeId = (short)Types.BillingType.S1;
            else if (BillingType == Types.BillingType.S2.ToString())
                SqlRow.BillTypeId = (short)Types.BillingType.S2;
            else if (BillingType == Types.BillingType.ZG2Q.ToString())
                SqlRow.BillTypeId = (short)Types.BillingType.ZG2Q;
            else if (BillingType == Types.BillingType.ZL2Q.ToString())
                SqlRow.BillTypeId = (short)Types.BillingType.ZL2Q;
            else if (BillingType == Types.BillingType.ZRDD.ToString())
                SqlRow.BillTypeId = (short)Types.BillingType.ZRDD;
        }
        public static bool UpdateBulkBillingDetails(SqlCommand cmd, DataSources.dsData.BillingDetailsDataTable BulkTable)
        {
            bool outPut = false;
            
            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = Managers.DataManager.ConnectionTimeout;
                bulkCopy.BulkCopyTimeout = Managers.DataManager.ConnectionTimeout;
                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("BillingDetailsId", "BillingDetailsId"); bulkCopy.ColumnMappings.Add("BillingDocument", "BillingDocument");
                bulkCopy.ColumnMappings.Add("SoldToParty", "SoldToParty"); bulkCopy.ColumnMappings.Add("RouteNumber", "RouteNumber");
                bulkCopy.ColumnMappings.Add("BillingDate", "BillingDate"); bulkCopy.ColumnMappings.Add("ConditionTypeId", "ConditionTypeId");
                bulkCopy.ColumnMappings.Add("MaterialNumber", "MaterialNumber"); bulkCopy.ColumnMappings.Add("BillTypeId", "BillTypeId");
                bulkCopy.ColumnMappings.Add("ReferenceDocumentN", "ReferenceDocumentN"); bulkCopy.ColumnMappings.Add("ActualInvoicedQuan", "ActualInvoicedQuan");
                bulkCopy.ColumnMappings.Add("ConditionValue", "ConditionValue"); 
                bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

                bulkCopy.DestinationTableName = BulkTable.TableName;
                bulkCopy.BatchSize = BulkTable.Count;

                //deleting data before saving new 1
                var result = from row in BulkTable.AsEnumerable()
                             group row by row.BillingDate into grp
                             select new { BillingDate = grp.Key };
                cmd.CommandText = "delete from BillingDetails where BillingDate = @BillingDate";
                cmd.Parameters.Add(new SqlParameter("@BillingDate", SqlDbType.Date));
                foreach (var item in result)
                {
                    if (DevExpress.XtraSplashScreen.SplashScreenManager.Default.IsSplashFormVisible)
                        DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("Deleting Day " + item.BillingDate.ToShortDateString());
                        System.Windows.Forms.Application.DoEvents();
                    cmd.Parameters["@BillingDate"].Value = item.BillingDate;
                    cmd.ExecuteNonQuery();
                }
                //saving bulk
                if (DevExpress.XtraSplashScreen.SplashScreenManager.Default.IsSplashFormVisible)
                    DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("Saving Data ..");
                System.Windows.Forms.Application.DoEvents();
                bulkCopy.WriteToServer(BulkTable);
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save BillingDetails Bulk - " + ex.Message, ex);
            }
            return outPut;
        }

    }
}
