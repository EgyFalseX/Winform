using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleICSales.Managers
{

    public static class RouteCustomer
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(RouteCustomer));
        public static bool UpdateBulkRouteCustomer(SqlCommand cmd, DataSources.dsData.RouteCustomerDataTable BulkTable)
        {
            bool outPut = false;
            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("CustomerId", "CustomerId"); bulkCopy.ColumnMappings.Add("RouteNumber", "RouteNumber");
                bulkCopy.ColumnMappings.Add("RouteCustomerStateId", "RouteCustomerStateId"); bulkCopy.ColumnMappings.Add("DeliveryDay", "DeliveryDay");
                bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

                bulkCopy.DestinationTableName = BulkTable.TableName;
                bulkCopy.BatchSize = BulkTable.Count;

                //deleting data before saving new 1
                cmd.CommandText = "delete from RouteCustomer";
                cmd.ExecuteNonQuery();
                //saving bulk
                bulkCopy.WriteToServer(BulkTable);
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save RouteCustomer Bulk - " + ex.Message, ex);
            }
            return outPut;
        }
        public static string GetRouteNumberFromCustomerId(int CustomerId, string TripNum = "")
        {
            //DataSources.dsData.RouteCustomerDataTable tbl = adpRouteCustomerTable.GetDataByCustomerIdAndActive(CustomerId);
            if (TripNum != "")
            {
                if (TripNum.Substring(0, 2) == "CS")
                {
                    return TripNum.Substring(2, 6);
                }
            }
            object outPut = Managers.DataManager.defaultInstance.adpRouteCustomer.ScalarQueryActiveCustomerRoute(CustomerId);
            if (outPut == null)
                outPut = Route.UnknownRouteNumber;
            return outPut.ToString();
        }
    }

}
