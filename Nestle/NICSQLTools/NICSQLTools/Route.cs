using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Route
    {
        //private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Route));
        public static string DefaultRouteName
        {
            get { return "Auto Generate Route"; }
        }
        public static string UnknownRouteNumber
        {
            get { return "999999"; }
        }
        public static string DistributorsRouteId
        {
            get { return "000001"; }
        }
        public static string ErrorRouteId
        {
            get { return "999999"; }
        }
        public static short UnknownPlantSalesDistrictId
        {
            get { return 9999; }
        }
        public static short UnknownRouteStatusId
        {
            get { return 9999; }
        }
        public static short UnknownRouteBrandId
        {
            get { return 9999; }
        }
        public static void CreateDefaultRoute(ref Data.dsData._0_3__Route_DetailsRow row)
        {
            row.Route_Name = DefaultRouteName;
            row.Supervisor = string.Empty;
            row.ASM = string.Empty;
            row.RSM = string.Empty;
        }
        public static Data.dsData._0_3__Route_DetailsRow GetRouteNumber(string RouteNumber, Data.dsData._0_3__Route_DetailsDataTable tbl)
        {
            RouteNumber = RouteNumber.ToUpper();
            for (int i = 0; i < tbl.Count; i++)
            {
                if (tbl[i].Route_Number.ToUpper() == RouteNumber)
                    return tbl[i];
            }
            Data.dsData._0_3__Route_DetailsRow row = tbl.New_0_3__Route_DetailsRow();
            Route.CreateDefaultRoute(ref row);
            return row;
        }
        public static short GetPlantSalesDistrictId(string Plant, string SalesDistrict)
        {
            short PlantSalesDistrictId = Route.UnknownPlantSalesDistrictId;
            switch (SalesDistrict.Trim())
            {
                case "Cairo Distributors":
                    PlantSalesDistrictId = 46;//Cairo Distributors
                    break;
                case "Cairo East":
                    PlantSalesDistrictId = 56;//Cairo East 
                    break;
                case "Cairo North":
                    PlantSalesDistrictId = 57;//Cairo North
                    break;
                case "Cairo West":
                    PlantSalesDistrictId = 58;//Cairo West
                    break;
                case "Cairo Wholesale":
                    PlantSalesDistrictId = 12;//Cairo WHS
                    break;
                case "Delta East":
                    PlantSalesDistrictId = 60;//Mansoura
                    break;
                case "Delta East Dist.":
                    PlantSalesDistrictId = 47;//Delta East Distributors
                    break;
                case "Delta East WHS":
                    PlantSalesDistrictId = 22;//Mansoura WHS
                    break;
                case "Delta West":
                    PlantSalesDistrictId = 59;//Delta West
                    break;
                case "Delta West Dist.":
                    PlantSalesDistrictId = 48;//Delta West Distributors
                    break;
                case "Egypt Personal Sales":
                case "Head Office":
                case "Staff Sales":
                    PlantSalesDistrictId = 71;//Staff Sales - Egypt Personal Sales
                    break;
                case "S.SINAI":
                    PlantSalesDistrictId = 76;//S.SINAI
                    break;
                case "Special Market & KA Cairo":
                    PlantSalesDistrictId = 73;//Cairo Key Account & Special Market
                    break;
                case "Special Market & KA Hurghada":
                    PlantSalesDistrictId = 74;//Hurghada Key Account & Special Market
                    break;
                case "Special Market & KA Sharm":
                    PlantSalesDistrictId = 75;//Sharm Key Account & Special Market
                    break;
                case "Upper Egypt":
                    if (Plant.Trim().ToLower() == "assuit".ToLower())
                        PlantSalesDistrictId = 64;//Upper Egypt Assuit
                    else
                        PlantSalesDistrictId = 63;//Upper Egypt Luxor
                    break;
                case "Upper Egypt Dist":
                    if (Plant.Trim().ToLower() == "assuit".ToLower())
                        PlantSalesDistrictId = 49;//Upper Egypt Distributors Assuit
                    else
                        PlantSalesDistrictId = 72;//Upper Egypt Distributors Luxor
                    break;
                case "":
                    PlantSalesDistrictId = 1;
                    break;
                default:
                    //Logger.Error("Error while try to get PlantSalesDistrictId from '" + SalesDistrict + "'");
                    break;
            }
            return PlantSalesDistrictId;
        }
        public static short GetRouteBrandId(string RouteBrand)
        {
            short RouteBrandId = Route.UnknownRouteBrandId;
            switch (RouteBrand.Trim())
            {
                case "Common":
                    RouteBrandId = 4;
                    break;
                case "Dolce":
                    RouteBrandId = 3;
                    break;
                case "Legal Case":
                    RouteBrandId = 5;
                    break;
                case "Movenpick":
                    RouteBrandId = 6;
                    break;
                case "Nestle":
                    RouteBrandId = 2;
                    break;
            }
            return RouteBrandId;
        }
        public static bool UpdateBulkRoute(SqlCommand cmd, Data.dsData._0_3__Route_DetailsDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("Routes{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM Routes WHERE 1 = 0;", BulkTableName);
            //Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("RouteNumber", "RouteNumber");
                bulkCopy.ColumnMappings.Add("RouteName", "RouteName"); bulkCopy.ColumnMappings.Add("PlantSalesDistrictId", "PlantSalesDistrictId");
                bulkCopy.ColumnMappings.Add("Supervisor", "Supervisor"); bulkCopy.ColumnMappings.Add("ASM", "ASM");
                bulkCopy.ColumnMappings.Add("RSM", "RSM"); bulkCopy.ColumnMappings.Add("RouteBrandId", "RouteBrandId");
                bulkCopy.ColumnMappings.Add("RouteBrandIdOld", "RouteBrandIdOld"); bulkCopy.ColumnMappings.Add("RouteStatusId", "RouteStatusId");
                bulkCopy.ColumnMappings.Add("Descriptions", "Descriptions");
                bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"merge into Routes as Target 
            USING {0} AS Source on Target.RouteNumber = Source.RouteNumber WHEN MATCHED THEN 
            UPDATE SET 
                Target.RouteName = Source.RouteName,
                Target.PlantSalesDistrictId = Source.PlantSalesDistrictId,
                Target.Supervisor = Source.Supervisor,
                Target.ASM = Source.ASM,
                Target.RSM = Source.RSM,
                Target.RouteBrandId = Source.RouteBrandId,
                Target.Descriptions = Source.Descriptions,
                Target.userin = Source.userin,
                Target.datein = Source.datein
            WHEN NOT MATCHED THEN 
                INSERT (RouteNumber, RouteName, PlantSalesDistrictId, Supervisor, ASM, RSM, RouteBrandId, RouteBrandIdOld, RouteStatusId, Descriptions, userin, datein) values 
                (Source.RouteNumber, Source.RouteName, Source.PlantSalesDistrictId, Source.Supervisor, Source.ASM, Source.RSM, Source.RouteBrandId, Source.RouteBrandIdOld,
                Source.RouteStatusId, Source.Descriptions, Source.userin, Source.datein);", BulkTableName);
                //Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                //Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                //Logger.Error("Error while trying to save Route Bulk - " + ex.Message, ex);
            }
            return outPut;
        }

    }
}
