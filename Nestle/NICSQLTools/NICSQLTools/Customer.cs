using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Customer
    {
        //private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Customer));
        public static string DefaultCustomerName
        {
            get { return "Auto Generate Customer"; }
        }
        public static string CustomerGroupIdDirect
        {
            get { return "Direct"; }
        }
        public static string CustomerTypeIdDirect
        {
            get { return "Direct"; }
        }
        public static string CustomerType2IdDirect
        {
            get { return "Direct"; }
        }
        public static string SubchannelIdDirect
        {
            get { return "Direct"; }
        }
        public static int CustomerTypeCodeDirect
        {
            get { return 1; }
        }


        public static void CreateDefaultCustomer(ref Data.dsData._0_6_Customer_HNRow row)
        {
            //row.CustomerNameEn1 = DefaultCustomerName;
            //row.CustomerNameEn2 = string.Empty;
            //row.CustomerNameAr1 = string.Empty;
            //row.CustomerNameAr2 = string.Empty;
            //row.CustHierLevel6Id = UnknownCustHierLevel6Id;
            //row.SubchannelId = Customer.SubchannelIdDirect;
            //row.CustomerTypeId = Customer.CustomerTypeIdDirect;
            //row.CustomerType2Id = Customer.CustomerType2IdDirect;
            //row.CustomerGroupId = Customer.CustomerGroupIdDirect;
            //row.CustomerAddress = string.Empty;
            //row.CityId = UnknownCityId;
        }
        public static Data.dsData._0_6_Customer_HNRow GetCustomerRow(string CustomerId, Data.dsData._0_6_Customer_HNDataTable tbl)
        {
            //return null;
            Data.dsData._0_6_Customer_HNRow row = tbl.FindByCustomer_T(CustomerId);
            if (row == null)
            {
                Data.dsData._0_6_Customer_HNRow CusRow = tbl.New_0_6_Customer_HNRow();
                //////////////////Customer.CreateDefaultCustomer(ref CusRow);
                return CusRow;
            }
            else
                return row;
        }
        public static bool UpdateBulkCustomer(SqlCommand cmd, Data.dsData._0_6_Customer_HNDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("Customers{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM Customer WHERE 1 = 0;", BulkTableName);
            //Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());


            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("CustomerId", "CustomerId"); bulkCopy.ColumnMappings.Add("CustomerNameEn1", "CustomerNameEn1");
                bulkCopy.ColumnMappings.Add("CustomerNameEn2", "CustomerNameEn2"); bulkCopy.ColumnMappings.Add("CustomerNameAr1", "CustomerNameAr1");
                bulkCopy.ColumnMappings.Add("CustomerNameAr2", "CustomerNameAr2"); bulkCopy.ColumnMappings.Add("CustHierLevel6Id", "CustHierLevel6Id");
                bulkCopy.ColumnMappings.Add("SubchannelId", "SubchannelId"); bulkCopy.ColumnMappings.Add("CustomerTypeId", "CustomerTypeId");
                bulkCopy.ColumnMappings.Add("CustomerType2Id", "CustomerType2Id"); bulkCopy.ColumnMappings.Add("CustomerGroupId", "CustomerGroupId");
                bulkCopy.ColumnMappings.Add("CreationDate", "CreationDate"); bulkCopy.ColumnMappings.Add("CustomerAddress", "CustomerAddress");
                bulkCopy.ColumnMappings.Add("CityId", "CityId");
                bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"merge into Customer as Target 
                using {0} as Source on Target.CustomerId = Source.CustomerId when matched then 
                update set 
                Target.CustomerNameEn1 = Source.CustomerNameEn1,
                Target.CustomerNameEn2 = Source.CustomerNameEn2,
                Target.CustomerNameAr1 = Source.CustomerNameAr1,
                Target.CustomerNameAr2 = Source.CustomerNameAr2,
                Target.CustHierLevel6Id = Source.CustHierLevel6Id,
                Target.SubchannelId = Source.SubchannelId,
                Target.CustomerTypeId = Source.CustomerTypeId,
                Target.CustomerType2Id = Source.CustomerType2Id,
                Target.CustomerGroupId = Source.CustomerGroupId,
                Target.CreationDate = Source.CreationDate,
                Target.CustomerAddress = Source.CustomerAddress,
                Target.CityId = Source.CityId,
                Target.userin = Source.userin,
                Target.datein = Source.datein
                when not matched then 
                insert (CustomerId,CustomerNameEn1,CustomerNameEn2, CustomerNameAr1, CustomerNameAr2, CustHierLevel6Id, SubchannelId, CustomerTypeId, CustomerType2Id, CustomerGroupId, CreationDate, CustomerAddress, CityId, userin, datein) values 
                (Source.CustomerId, Source.CustomerNameEn1, Source.CustomerNameEn2, Source.CustomerNameAr1, Source.CustomerNameAr2, Source.CustHierLevel6Id, Source.SubchannelId, Source.CustomerTypeId, Source.CustomerType2Id, 
                Source.CustomerGroupId, Source.CreationDate, Source.CustomerAddress, Source.CityId, Source.userin, Source.datein);", BulkTableName);
                //Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                //Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                //Logger.Error("Error while trying to save Customer Bulk - " + ex.Message, ex);
                System.Windows.Forms.MessageBox.Show("Error while trying to save Customer Bulk - " + ex.Message);
            }
            return outPut;
        }
        

    }
}
