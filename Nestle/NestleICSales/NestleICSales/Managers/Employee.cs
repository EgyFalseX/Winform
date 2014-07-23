using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleICSales.Managers
{
    public static class Employee
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Employee));
        public static string DefaultEmployeeName
        {
            get { return "Auto Generate Employee"; }
        }
        public static int UnknownEmployeeId
        {
            get { return 999999999; }
        }
        public static short UnknownJobTitleId
        {
            get { return 9999; }
        }
        public static void CreateDefaultEmployee(ref DataSources.dsData.EmployeeRow row)
        {
            row.EmployeeName = DefaultEmployeeName;
            row.EmployeeNameFull = DefaultEmployeeName;
            row.JobTitleId = UnknownJobTitleId;
            row.datein = DataManager.defaultInstance.GetServerDatetime;
            row.userin = UserManager.defaultInstance.UserInfo.UserID;
        }
        public static DataSources.dsData.EmployeeRow GetEmployeeRow(int EmployeeId, DataSources.dsData.EmployeeDataTable tbl)
        {
            DataSources.dsData.EmployeeRow row = tbl.FindByEmployeeId(EmployeeId);
            if (row == null)
            {
                DataSources.dsData.EmployeeRow NewRow = tbl.NewEmployeeRow();
                CreateDefaultEmployee(ref NewRow);
                return NewRow;
            }
            else
                return row;
        }
        public static short GetJobTitleId(string JobTitle, DataSources.dsData.JobTitleDataTable tbl)
        {
            short outPut = UnknownJobTitleId;
            string FilterString = string.Format(@"JobTitle like '{0}'", JobTitle);
            DataSources.dsData.JobTitleRow[] jobs = (DataSources.dsData.JobTitleRow[])tbl.Select(FilterString);
            if (jobs.Length != 0)
                outPut = jobs[0].JobTitleId;
            return outPut;
        }
        public static bool UpdateBulkEmployeeBySalesSummary(SqlCommand cmd, DataSources.dsData.EmployeeDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("Employee{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM Employee WHERE 1 = 0;", BulkTableName);
            Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("EmployeeId", "EmployeeId"); bulkCopy.ColumnMappings.Add("EmployeeName", "EmployeeName");
                bulkCopy.ColumnMappings.Add("EmployeeNameFull", "EmployeeNameFull"); bulkCopy.ColumnMappings.Add("JobTitleId", "JobTitleId");
                bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"MERGE INTO Employee AS Target 
                USING {0} AS Source on Target.EmployeeId = Source.EmployeeId WHEN MATCHED THEN 
                UPDATE SET
                Target.EmployeeNameFull = Source.EmployeeNameFull,
                Target.JobTitleId = Source.JobTitleId,
                Target.userin = Source.userin,
                Target.datein = Source.datein
                WHEN NOT MATCHED THEN 
                INSERT (EmployeeId, EmployeeName, EmployeeNameFull, JobTitleId, userin, datein) VALUES 
                (Source.EmployeeId, Source.EmployeeName, Source.EmployeeNameFull, Source.JobTitleId, 
                Source.userin, Source.datein);", BulkTableName);
                Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save Employee Bulk - " + ex.Message, ex);
            }
            return outPut;
        }

    }
}
