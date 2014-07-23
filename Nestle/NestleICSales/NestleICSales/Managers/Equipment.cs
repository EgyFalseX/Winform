using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleICSales.Managers
{
    public static class Equipment
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Equipment));
        public static void CreateDefaultEquipment(ref DataSources.dsData.EquipmentRow row)
        {
            DateTime now = DataManager.defaultInstance.GetServerDatetime;

            row.SerialNumber = "0000-00000";
            row.Material = 0;
            row.Description = string.Empty;
            row.FunctionalId = Customer.UnknownCustomerId;
            row.FunctionalLocation = string.Empty;
            row.ValidFrom = now;
            row.InventoryNo = string.Empty;
            row.ConstructYear = now.Year.ToString();
            row.BrandId = Product.UnknownBrandId;
            row.datein = now;
            row.userin = UserManager.defaultInstance.UserInfo.UserID;
        }
        public static bool UpdateBulkRouteEquipment(SqlCommand cmd, DataSources.dsData.EquipmentDataTable BulkTable)
        {
            bool outPut = false;
            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("EquipmentId", "EquipmentId"); bulkCopy.ColumnMappings.Add("SerialNumber", "SerialNumber");
                bulkCopy.ColumnMappings.Add("Material", "Material"); bulkCopy.ColumnMappings.Add("Description", "Description");
                bulkCopy.ColumnMappings.Add("FunctionalId", "FunctionalId"); bulkCopy.ColumnMappings.Add("FunctionalLocation", "FunctionalLocation");
                bulkCopy.ColumnMappings.Add("ValidFrom", "ValidFrom"); bulkCopy.ColumnMappings.Add("InventoryNo", "InventoryNo");
                bulkCopy.ColumnMappings.Add("ConstructYear", "ConstructYear"); bulkCopy.ColumnMappings.Add("BrandId", "BrandId");
                bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

                bulkCopy.DestinationTableName = BulkTable.TableName;
                bulkCopy.BatchSize = BulkTable.Count;

                //deleting data before saving new 1
                cmd.CommandText = "delete from Equipment";
                cmd.ExecuteNonQuery();
                //saving bulk
                bulkCopy.WriteToServer(BulkTable);
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save Equipment Bulk - " + ex.Message, ex);
            }
            return outPut;
        }

    }

}
