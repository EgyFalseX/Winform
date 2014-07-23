using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleICSales.Managers
{
    public static class RouteTarget
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(RouteTarget));
        public static void CreateDefaultRouteTarget(ref DataSources.dsData.RouteTargetRow row)
        {
            row.RouteNumber = Route.UnknownRouteNumber;
            row.TargetYear = 9999;
            row.TargetMonth = 1;
            row.TargetAPOSMonth = 0;
            row.TargetINVMonth = 0;
            row.TargetDSMonth = 0;
            row.TargetSalesMonth = 0;

            row.TargetAPOSWeek = 0;
            row.TargetINVWeek = 0;
            row.TargetSalesWeek = 0;

            row.TargetAPOSDay = 0;
            row.TargetINVDay = 0;
            row.TargetDSDay = 0;
            row.TargetSalesDay = 0;
            
            row.datein = DataManager.defaultInstance.GetServerDatetime;
            row.userin = UserManager.defaultInstance.UserInfo.UserID;
        }
        public static bool UpdateBulkRouteTarget(SqlCommand cmd, DataSources.dsData.RouteTargetDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("RouteTarget{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM RouteTarget WHERE 1 = 0;", BulkTableName);
            Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("RouteNumber", "RouteNumber");
                bulkCopy.ColumnMappings.Add("TargetYear", "TargetYear"); bulkCopy.ColumnMappings.Add("TargetMonth", "TargetMonth");

                bulkCopy.ColumnMappings.Add("TargetAPOSMonth", "TargetAPOSMonth"); bulkCopy.ColumnMappings.Add("TargetINVMonth", "TargetINVMonth");
                bulkCopy.ColumnMappings.Add("TargetDSMonth", "TargetDSMonth"); bulkCopy.ColumnMappings.Add("TargetSalesMonth", "TargetSalesMonth");

                bulkCopy.ColumnMappings.Add("TargetAPOSWeek", "TargetAPOSWeek"); bulkCopy.ColumnMappings.Add("TargetINVWeek", "TargetINVWeek");
                bulkCopy.ColumnMappings.Add("TargetDSWeek", "TargetDSWeek"); bulkCopy.ColumnMappings.Add("TargetSalesWeek", "TargetSalesWeek");

                bulkCopy.ColumnMappings.Add("TargetAPOSDay", "TargetAPOSDay"); bulkCopy.ColumnMappings.Add("TargetINVDay", "TargetINVDay");
                bulkCopy.ColumnMappings.Add("TargetDSDay", "TargetDSDay"); bulkCopy.ColumnMappings.Add("TargetSalesDay", "TargetSalesDay");

                bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"merge into RouteTarget as Target 
            USING {0} AS Source on Target.RouteNumber = Source.RouteNumber AND Target.TargetYear = Source.TargetYear AND Target.TargetMonth = Source.TargetMonth
            WHEN MATCHED THEN 
            UPDATE SET 
                Target.RouteNumber = Source.RouteNumber,
                Target.TargetYear = Source.TargetYear,
                Target.TargetMonth = Source.TargetMonth,
                Target.TargetAPOSMonth = Source.TargetAPOSMonth,
                Target.TargetINVMonth = Source.TargetINVMonth,
                Target.TargetDSMonth = Source.TargetDSMonth,
                Target.TargetSalesMonth = Source.TargetSalesMonth,
                Target.TargetAPOSWeek = Source.TargetAPOSWeek,
                Target.TargetINVWeek = Source.TargetINVWeek,
                Target.TargetDSWeek = Source.TargetDSWeek,
                Target.TargetSalesWeek = Source.TargetSalesWeek,
                Target.TargetAPOSDay = Source.TargetAPOSDay,
                Target.TargetINVDay = Source.TargetINVDay,
                Target.TargetDSDay = Source.TargetDSDay,
                Target.TargetSalesDay = Source.TargetSalesDay,
                Target.userin = Source.userin,
                Target.datein = Source.datein
            WHEN NOT MATCHED THEN 
                INSERT (RouteNumber, TargetYear, TargetMonth, TargetAPOSMonth, TargetINVMonth, TargetDSMonth, TargetSalesMonth, TargetAPOSWeek, TargetINVWeek, TargetDSWeek, TargetSalesWeek,
                TargetAPOSDay, TargetINVDay, TargetDSDay, TargetSalesDay, userin, datein) values 
                (Source.RouteNumber, Source.TargetYear, Source.TargetMonth, Source.TargetAPOSMonth, Source.TargetINVMonth, Source.TargetDSMonth, Source.TargetSalesMonth, Source.TargetAPOSWeek,
                Source.TargetINVWeek, Source.TargetDSWeek, Source.TargetSalesWeek, Source.TargetAPOSDay, Source.TargetINVDay, Source.TargetDSDay, Source.TargetSalesDay, Source.userin, Source.datein);",
                BulkTableName);
                Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save Route Bulk - " + ex.Message, ex);
            }
            return outPut;
        }

    }
}
