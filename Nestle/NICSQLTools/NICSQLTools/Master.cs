using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Master
    {
        //private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Customer));

        public static bool UpdateBulkMaster(SqlCommand cmd, Data.dsData._0_1__Master_AllDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            //string BulkTableName = string.Format("Master{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            //cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM dbo.[0-1  Master All] WHERE 1 = 0;", BulkTableName);
            //Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Billing Document", "Billing Document"); bulkCopy.ColumnMappings.Add("Distribution Channel", "Distribution Channel");
                bulkCopy.ColumnMappings.Add("Sold-to party", "Sold-to party"); bulkCopy.ColumnMappings.Add("Route", "Route");
                bulkCopy.ColumnMappings.Add("Billing date for bil", "Billing date for bil"); bulkCopy.ColumnMappings.Add("Material Number", "Material Number");
                bulkCopy.ColumnMappings.Add("Billing Type", "Billing Type"); bulkCopy.ColumnMappings.Add("Sales Organization", "Sales Organization");
                bulkCopy.ColumnMappings.Add("Sales district", "Sales district"); bulkCopy.ColumnMappings.Add("Company Code", "Company Code");
                bulkCopy.ColumnMappings.Add("Payer", "Payer"); bulkCopy.ColumnMappings.Add("Reference Document N", "Reference Document N");
                bulkCopy.ColumnMappings.Add("Sales unit", "Sales unit"); bulkCopy.ColumnMappings.Add("Base Unit of Measure", "Base Unit of Measure");
                bulkCopy.ColumnMappings.Add("Plant", "Plant"); bulkCopy.ColumnMappings.Add("Condition type", "Condition type");
                bulkCopy.ColumnMappings.Add("G/L Account Number", "G/L Account Number"); bulkCopy.ColumnMappings.Add("Actual Invoiced Quan", "Actual Invoiced Quan");
                bulkCopy.ColumnMappings.Add("Condition base value", "Condition base value"); bulkCopy.ColumnMappings.Add("Condition value", "Condition value");
                bulkCopy.ColumnMappings.Add("Route & Sold", "Route & Sold"); bulkCopy.ColumnMappings.Add("yeard", "yeard");
                bulkCopy.ColumnMappings.Add("Month", "Month"); bulkCopy.ColumnMappings.Add("New Quanteite", "New Quanteite");

                bulkCopy.DestinationTableName = "[0-1  Master All]";
                bulkCopy.BatchSize = BulkTable.Count;
                
                
                bulkCopy.WriteToServer(BulkTable);

                outPut = true;
            }
            catch (SqlException ex)
            {
                //Logger.Error("Error while trying to save Customer Bulk - " + ex.Message, ex);
                System.Windows.Forms.MessageBox.Show("Error while trying to save Master Bulk - " + ex.Message);
            }
            return outPut;
        }
        

    }
}
