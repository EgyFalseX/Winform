using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleICSales.Managers
{
    public static class Customer
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Customer));
        public static string DefaultCustomerName
        {
            get { return "Auto Generate Customer"; }
        }
        public static int UnknownCustomerId
        {
            get { return 999999999; }
        }
        public static int UnknownSubchannelId
        {
            get { return 999999999; }
        }
        public static int UnknownCustomerTypeId
        {
            get { return 999999999; }
        }
        public static int UnknownCustomerType2Id
        {
            get { return 999999999; }
        }
        public static int UnknownCustomerGroupId
        {
            get { return 999999999; }
        }
        public static int UnknownCityId
        {
            get { return 999999999; }
        }
        public static int UnknownCustHierLevel6Id
        {
            get { return 999999999; }
        }
        public static int CustomerGroupIdDirect
        {
            get { return 15; }
        }
        public static int CustomerTypeIdDirect
        {
            get { return 3; }
        }
        public static int CustomerType2IdDirect
        {
            get { return 2; }
        }
        public static int SubchannelIdDirect
        {
            get { return 1; }
        }

        public static void CreateDefaultCustomer(ref DataSources.dsData.CustomerRow row)
        {
            row.CustomerNameEn1 = DefaultCustomerName;
            row.CustomerNameEn2 = string.Empty;
            row.CustomerNameAr1 = string.Empty;
            row.CustomerNameAr2 = string.Empty;
            row.CustHierLevel6Id = UnknownCustHierLevel6Id;
            row.SubchannelId = Customer.SubchannelIdDirect;
            row.CustomerTypeId = Customer.CustomerTypeIdDirect;
            row.CustomerType2Id = Customer.CustomerType2IdDirect;
            row.CustomerGroupId = Customer.CustomerGroupIdDirect;
            //row.CreationDate = DataManager.defaultInstance.GetServerDatetime;
            row.CustomerAddress = string.Empty;
            row.CityId = UnknownCityId;
            //row.datein = row.CreationDate;
            //row.userin = UserManager.defaultInstance.UserInfo.UserID;
        }
        public static DataSources.dsData.CustomerRow GetCustomerRow(string CustomerId, DataSources.dsData.CustomerDataTable tbl)
        {
            DataSources.dsData.CustomerRow row = tbl.FindByCustomerId(Convert.ToInt32(CustomerId));
            if (row == null)
            {
                DataSources.dsData.CustomerRow CusRow = tbl.NewCustomerRow();
                CreateDefaultCustomer(ref CusRow);
                return CusRow;
            }
            else
                return row;
        }
        public static bool UpdateBulkCustomer(SqlCommand cmd, DataSources.dsData.CustomerDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("Customers{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM Customer WHERE 1 = 0;", BulkTableName);
            Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());


            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = Managers.DataManager.ConnectionTimeout;
                bulkCopy.BulkCopyTimeout = Managers.DataManager.ConnectionTimeout;

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
                Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save Customer Bulk - " + ex.Message, ex);
            }
            return outPut;
        }
        public static bool UpdateBulkCustomerBySalesSummary(SqlCommand cmd, DataSources.dsData.CustomerDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("Customers{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM Customer WHERE 1 = 0;", BulkTableName);
            Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = Managers.DataManager.ConnectionTimeout;
                bulkCopy.BulkCopyTimeout = Managers.DataManager.ConnectionTimeout;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("CustomerId", "CustomerId");
                bulkCopy.ColumnMappings.Add("CustomerNameEn1", "CustomerNameEn1"); bulkCopy.ColumnMappings.Add("CustomerNameEn2", "CustomerNameEn2");
                bulkCopy.ColumnMappings.Add("CustomerNameAr1", "CustomerNameAr1"); bulkCopy.ColumnMappings.Add("CustomerNameAr2", "CustomerNameAr2");
                bulkCopy.ColumnMappings.Add("CustHierLevel6Id", "CustHierLevel6Id"); bulkCopy.ColumnMappings.Add("SubchannelId", "SubchannelId");
                bulkCopy.ColumnMappings.Add("CustomerTypeId", "CustomerTypeId"); bulkCopy.ColumnMappings.Add("CustomerType2Id", "CustomerType2Id");
                bulkCopy.ColumnMappings.Add("CustomerGroupId", "CustomerGroupId"); bulkCopy.ColumnMappings.Add("CreationDate", "CreationDate");
                bulkCopy.ColumnMappings.Add("CustomerAddress", "CustomerAddress"); bulkCopy.ColumnMappings.Add("CityId", "CityId");
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
                Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save Customer Bulk - " + ex.Message, ex);
            }
            return outPut;
        }
        public static int GetLv6Code(string L6Code, DataSources.dsData.CustHierLevel6DataTable tbl)
        {
            int Lv6 = Customer.UnknownCustHierLevel6Id;
            if (L6Code.Contains(@"/") || L6Code.Contains(@"-"))
            {
                try
                { Lv6 = Convert.ToInt32(L6Code.Substring(11)); }
                catch { }
            }
            else if (L6Code.Trim().Length != 0)
            {
                if (int.TryParse(L6Code, out Lv6))
                {
                    if (Lv6 == 0)
                        Lv6 = Customer.UnknownCustHierLevel6Id;
                }
                else
                    Lv6 = Customer.UnknownCustHierLevel6Id;
            }
            DataSources.dsData.CustHierLevel6Row row = tbl.FindByCustHierLevel6Id(Lv6);
            if (row == null)
                Lv6 = Customer.UnknownCustHierLevel6Id;
            return Lv6;
        }
        public static int GetLv6Code(string DistributionChannel, string L3Code, string L3Name, string L4Code, string L4Name, string L5Code, string L5Name, string L6Code, string L6Name, 
            DataSources.dsData.DistributionChannelDataTable tblDC ,DataSources.dsData.CustHierLevel3DataTable tbl3, DataSources.dsData.CustHierLevel4DataTable tbl4, DataSources.dsData.CustHierLevel5DataTable tbl5, 
            DataSources.dsData.CustHierLevel6DataTable tbl6)
        {
            L6Code = L6Code.Substring(11);
            DataSources.dsData.CustHierLevel6Row rowLv6 = tbl6.FindByCustHierLevel6Id(Convert.ToInt32(L6Code));
            if (rowLv6 != null)
                return rowLv6.CustHierLevel6Id;
            
            L3Code = L3Code.Substring(11);
            L4Code = L4Code.Substring(11);
            L5Code = L5Code.Substring(11);

            //Insert DistributionChannel if not exists
            DataSources.dsData.DistributionChannelRow rowDC = tblDC.FindByDistributionChannelId(Convert.ToInt16(DistributionChannel));
            if (rowDC == null)
            {
                Managers.DataManager.defaultInstance.adpDisChannel.Insert(Convert.ToInt16(DistributionChannel), DistributionChannel, string.Empty);
                tblDC.AddDistributionChannelRow(Convert.ToInt16(DistributionChannel), DistributionChannel, string.Empty);
            }
                
            //Insert Lv3 if not exists
            DataSources.dsData.CustHierLevel3Row rowLv3 = tbl3.FindByCustHierLevel3Id(Convert.ToInt32(L3Code));
            if (rowLv3 == null)
            {
                Managers.DataManager.defaultInstance.adpCusLv3.Insert(Convert.ToInt32(L3Code), L3Name, Convert.ToInt16(DistributionChannel));
                DataSources.dsData.CustHierLevel3Row row = tbl3.NewCustHierLevel3Row();
                row.CustHierLevel3Id = Convert.ToInt32(L3Code); row.CustHierLevel3Name = L3Name; row.DistributionChannelId = Convert.ToInt16(DistributionChannel);
                tbl3.AddCustHierLevel3Row(row);
            }
                
            //Insert Lv4 if not exists
            DataSources.dsData.CustHierLevel4Row rowLv4 = tbl4.FindByCustHierLevel4Id(Convert.ToInt32(L4Code));
            if (rowLv4 == null)
            {
                Managers.DataManager.defaultInstance.adpCusLv4.Insert(Convert.ToInt32(L4Code), L4Name, Convert.ToInt32(L3Code));
                DataSources.dsData.CustHierLevel4Row row = tbl4.NewCustHierLevel4Row();
                row.CustHierLevel4Id = Convert.ToInt32(L4Code); row.CustHierLevel4Name = L4Name; row.CustHierLevel3Id = Convert.ToInt32(L3Code);
                tbl4.AddCustHierLevel4Row(row);
            }
            //Insert Lv5 if not exists
            DataSources.dsData.CustHierLevel5Row rowLv5 = tbl5.FindByCustHierLevel5Id(Convert.ToInt32(L5Code));
            if (rowLv5 == null)
            {
                Managers.DataManager.defaultInstance.adpCusLv5.Insert(Convert.ToInt32(L5Code), L5Name, Convert.ToInt32(L4Code));
                DataSources.dsData.CustHierLevel5Row row = tbl5.NewCustHierLevel5Row();
                row.CustHierLevel5Id = Convert.ToInt32(L5Code); row.CustHierLevel5Name = L5Name; row.CustHierLevel4Id = Convert.ToInt32(L4Code);
                tbl5.AddCustHierLevel5Row(row);
            }
            //Insert Lv6 if not exists
            rowLv6 = tbl6.FindByCustHierLevel6Id(Convert.ToInt32(L6Code));
            if (rowLv6 == null)
            {
                Managers.DataManager.defaultInstance.adpCusLv6.Insert(Convert.ToInt32(L6Code), L6Name, Convert.ToInt32(L5Code));
                DataSources.dsData.CustHierLevel6Row row = tbl6.NewCustHierLevel6Row();
                row.CustHierLevel6Id = Convert.ToInt32(L6Code); row.CustHierLevel6Name = L6Name; row.CustHierLevel6Id = Convert.ToInt32(L6Code);
                tbl6.AddCustHierLevel6Row(row);
            }

            return Convert.ToInt32(L6Code);

        }
        public static int GetSubchannelId(string SubchannelName)
        {
            int SubchannelId = Customer.UnknownSubchannelId;
            switch (SubchannelName.Trim())
            {
                case "Bazaar":
                    SubchannelId = 2;
                    break;
                case "BookShop":
                    SubchannelId = 3;
                    break;
                case "Café And Restaurants":
                    SubchannelId = 4;
                    break;
                case "Church":
                    SubchannelId = 5;
                    break;
                case "Cinemas":
                    SubchannelId = 6;
                    break;
                case "Clubs":
                    SubchannelId = 7;
                    break;
                case "Dairy Store":
                    SubchannelId = 8;
                    break;
                case "Discounters":
                    SubchannelId = 9;
                    break;
                case "Distributors":
                    SubchannelId = 10;
                    break;
                case "Export":
                    SubchannelId = 11;
                    break;
                case "Fruit Store":
                    SubchannelId = 12;
                    break;
                case "Grocery":
                    SubchannelId = 13;
                    break;
                case "Herbs shop":
                    SubchannelId = 14;
                    break;
                case "Hospital":
                    SubchannelId = 15;
                    break;
                case "Hotels":
                    SubchannelId = 16;
                    break;
                case "Hyper Markets":
                    SubchannelId = 17;
                    break;
                case "Juice Stores":
                    SubchannelId = 18;
                    break;
                case "Kiosk":
                    SubchannelId = 19;
                    break;
                case "Nestle Kiosks":
                    SubchannelId = 20;
                    break;
                case "Nestle Shop":
                    SubchannelId = 21;
                    break;
                case "Nuts Stores":
                    SubchannelId = 22;
                    break;
                case "Parks":
                    SubchannelId = 23;
                    break;
                case "Petrol Station":
                    SubchannelId = 24;
                    break;
                case "Salesman":
                    SubchannelId = 25;
                    break;
                case "Schools":
                    SubchannelId = 26;
                    break;
                case "Staff Sales":
                    SubchannelId = 27;
                    break;
                case "Street Box":
                    SubchannelId = 28;
                    break;
                case "Super Markets":
                    SubchannelId = 29;
                    break;
                case "Sweet Shops":
                    SubchannelId = 30;
                    break;
                case "Variety Store":
                    SubchannelId = 31;
                    break;
                case "Wholesaler":
                    SubchannelId = 32;
                    break;
            }
            return SubchannelId;
        }
        public static int GetSubchannelIdByCustomerName3(string CustomerName)
        {
            int SubchannelId = Customer.UnknownSubchannelId;

            if (CustomerName.Contains("Bazaar"))
            {
                SubchannelId = 2;
            }
            else if (CustomerName.ToLower().Contains("bookshop"))
            {
                SubchannelId = 3;
            }
            else if (CustomerName.ToLower().Contains("café") || CustomerName.ToLower().Contains("cafe"))
            {
                SubchannelId = 4;
            }
            else if (CustomerName.ToLower().Contains("church"))
            {
                SubchannelId = 5;
            }
            else if (CustomerName.ToLower().Contains("cinemas"))
            {
                SubchannelId = 6;
            }
            else if (CustomerName.ToLower().Contains("clubs"))
            {
                SubchannelId = 7;
            }
            else if (CustomerName.ToLower().Contains("dairy"))
            {
                SubchannelId = 8;
            }
            else if (CustomerName.ToLower().Contains("discounters"))
            {
                SubchannelId = 9;
            }
            else if (CustomerName.ToLower().Contains("distributors"))
            {
                SubchannelId = 10;
            }
            else if (CustomerName.ToLower().Contains("export"))
            {
                SubchannelId = 11;
            }
            else if (CustomerName.ToLower().Contains("fruit"))
            {
                SubchannelId = 12;
            }
            else if (CustomerName.ToLower().Contains("grocery"))
            {
                SubchannelId = 13;
            }
            else if (CustomerName.ToLower().Contains("herbs"))
            {
                SubchannelId = 14;
            }
            else if (CustomerName.ToLower().Contains("hospital"))
            {
                SubchannelId = 15;
            }
            else if (CustomerName.ToLower().Contains("hotels"))
            {
                SubchannelId = 16;
            }
            else if (CustomerName.ToLower().Contains("hyper"))
            {
                SubchannelId = 17;
            }
            else if (CustomerName.ToLower().Contains("juice"))
            {
                SubchannelId = 18;
            }
            else if (CustomerName.ToLower().Contains("kiosk"))
            {
                SubchannelId = 19;
            }
            else if (CustomerName.ToLower().Contains("nestle kiosk"))
            {
                SubchannelId = 20;
            }
            else if (CustomerName.ToLower().Contains("nestle shop"))
            {
                SubchannelId = 21;
            }
            else if (CustomerName.ToLower().Contains("nuts stores"))
            {
                SubchannelId = 22;
            }
            else if (CustomerName.ToLower().Contains("parks"))
            {
                SubchannelId = 23;
            }
            else if (CustomerName.ToLower().Contains("petrol"))
            {
                SubchannelId = 24;
            }
            else if (CustomerName.ToLower().Contains("salesman"))
            {
                SubchannelId = 25;
            }
            else if (CustomerName.ToLower().Contains("schools"))
            {
                SubchannelId = 26;
            }
            else if (CustomerName.ToLower().Contains("staff"))
            {
                SubchannelId = 27;
            }
            else if (CustomerName.ToLower().Contains("street"))
            {
                SubchannelId = 28;
            }
            else if (CustomerName.ToLower().Contains("super"))
            {
                SubchannelId = 29;
            }
            else if (CustomerName.ToLower().Contains("sweet"))
            {
                SubchannelId = 30;
            }
            else if (CustomerName.ToLower().Contains("variety"))
            {
                SubchannelId = 31;
            }
            else if (CustomerName.ToLower().Contains("wholesaler"))
            {
                SubchannelId = 32;
            }

            return SubchannelId;
        }
        public static int GetCustomerTypeId(string CustomerTypeName)
        {
            int CustomerTypeId = Customer.UnknownCustomerTypeId;
            switch (CustomerTypeName.Trim())
            {
                case "Cash":
                    CustomerTypeId = 2;
                    break;
                case "Direct":
                    CustomerTypeId = 3;
                    break;
                case "Direct Transferred":
                    CustomerTypeId = 4;
                    break;
                case "Distributors":
                    CustomerTypeId = 5;
                    break;
                case "Export":
                    CustomerTypeId = 6;
                    break;
                case "Key Account":
                    CustomerTypeId = 7;
                    break;
                case "Nestle Kiosks":
                    CustomerTypeId = 8;
                    break;
                case "Salesman":
                    CustomerTypeId = 9;
                    break;
                case "Same Wholesaler":
                    CustomerTypeId = 10;
                    break;
                case "Staff Sales":
                    CustomerTypeId = 11;
                    break;
                case "Wholesaler":
                    CustomerTypeId = 12;
                    break;
                case "Wholesaler Transferred":
                    CustomerTypeId = 13;
                    break;
            }
            return CustomerTypeId;
        }
        public static int GetCustomerType2Id(string CustomerType2Name)
        {
            int CustomerType2Id = Customer.UnknownCustomerType2Id;
            switch (CustomerType2Name.Trim())
            {
                case "Direct":
                    CustomerType2Id = 2;
                    break;
                case "FS":
                    CustomerType2Id = 3;
                    break;
                case "Key Account":
                    CustomerType2Id = 4;
                    break;
                case "Direct Transferred":
                    CustomerType2Id = 5;
                    break;
                case "Distributors":
                    CustomerType2Id = 6;
                    break;
                case "Export":
                    CustomerType2Id = 7;
                    break;
                case "Wholesaler Transferred":
                    CustomerType2Id = 8;
                    break;
            }
            return CustomerType2Id;
        }
        public static int GetCustomerType2IdByCustomerTypeId(int CustomerTypeId)
        {
            int CustomerType2Id = Customer.UnknownCustomerType2Id;
            switch (CustomerTypeId)
            {
                case 7:
                    CustomerType2Id = 4;
                    break;
                default:
                    CustomerType2Id = 2;
                    break;
            }
            return CustomerType2Id;
        }
        public static int GetCustomerGroupId(string CustomerGroupName)
        {
            int CustomerGroupId = Customer.UnknownCustomerGroupId;
            switch (CustomerGroupName.Trim())
            {
                case "Abba":
                    CustomerGroupId = 2;
                    break;
                case "Abou Ashra":
                    CustomerGroupId = 3;
                    break;
                case "Abou Zekry":
                    CustomerGroupId = 4;
                    break;
                case "Accour":
                    CustomerGroupId = 5;
                    break;
                case "Alfa":
                    CustomerGroupId = 6;
                    break;
                case "Awlad Ghanem":
                    CustomerGroupId = 7;
                    break;
                case "Awlad Ragab":
                    CustomerGroupId = 8;
                    break;
                case "Bim Stores":
                    CustomerGroupId = 9;
                    break;
                case "Caltex":
                    CustomerGroupId = 10;
                    break;
                case "Carrefour":
                    CustomerGroupId = 11;
                    break;
                case "Cash":
                    CustomerGroupId = 12;
                    break;
                case "Cash and Carry":
                    CustomerGroupId = 13;
                    break;
                case "Charisma":
                    CustomerGroupId = 14;
                    break;
                case "Direct":
                    CustomerGroupId = 15;
                    break;
                case "Distributors":
                    CustomerGroupId = 16;
                    break;
                case "Ebaid Copmany":
                    CustomerGroupId = 17;
                    break;
                case "El Etehad":
                    CustomerGroupId = 18;
                    break;
                case "EL Mahalawy":
                    CustomerGroupId = 19;
                    break;
                case "El Masria Market":
                    CustomerGroupId = 20;
                    break;
                case "El Nakar":
                    CustomerGroupId = 21;
                    break;
                case "Esso Mobil":
                    CustomerGroupId = 22;
                    break;
                case "Export":
                    CustomerGroupId = 23;
                    break;
                case "Exxon Mobile":
                    CustomerGroupId = 24;
                    break;
                case "Family Market":
                    CustomerGroupId = 25;
                    break;
                case "Farghaly":
                    CustomerGroupId = 26;
                    break;
                case "Fathallah":
                    CustomerGroupId = 27;
                    break;
                case "Hawary":
                    CustomerGroupId = 28;
                    break;
                case "Hayper One":
                    CustomerGroupId = 29;
                    break;
                case "Hayper Plus":
                    CustomerGroupId = 30;
                    break;
                case "Hotels":
                    CustomerGroupId = 31;
                    break;
                case "La poire":
                    CustomerGroupId = 32;
                    break;
                case "M.Matrouh":
                    CustomerGroupId = 33;
                    break;
                case "Mahmal":
                    CustomerGroupId = 34;
                    break;
                case "Markato":
                    CustomerGroupId = 35;
                    break;
                case "Mazarea Dina":
                    CustomerGroupId = 36;
                    break;
                case "Metro":
                    CustomerGroupId = 37;
                    break;
                case "Metro Khair Zaman":
                    CustomerGroupId = 38;
                    break;
                case "Mobile":
                    CustomerGroupId = 39;
                    break;
                case "Nestle Kiosks":
                    CustomerGroupId = 40;
                    break;
                case "Nestle Shop":
                    CustomerGroupId = 41;
                    break;
                case "New Market":
                    CustomerGroupId = 42;
                    break;
                case "Oscar":
                    CustomerGroupId = 43;
                    break;
                case "Petrol Station":
                    CustomerGroupId = 44;
                    break;
                case "Quick 24":
                    CustomerGroupId = 45;
                    break;
                case "Royal House":
                    CustomerGroupId = 46;
                    break;
                case "Salesman":
                    CustomerGroupId = 47;
                    break;
                case "Same Wholesaler":
                    CustomerGroupId = 48;
                    break;
                case "Saudi":
                    CustomerGroupId = 49;
                    break;
                case "Shoprite":
                    CustomerGroupId = 50;
                    break;
                case "Si Mart":
                    CustomerGroupId = 51;
                    break;
                case "Spinneys":
                    CustomerGroupId = 52;
                    break;
                case "Staff Sales":
                    CustomerGroupId = 53;
                    break;
                case "Street Ice Box":
                    CustomerGroupId = 54;
                    break;
                case "Watania":
                    CustomerGroupId = 55;
                    break;
                case "Wholesaler":
                    CustomerGroupId = 56;
                    break;
                case "Y N Center":
                    CustomerGroupId = 57;
                    break;
                case "Zad":
                    CustomerGroupId = 58;
                    break;
                case "Zahran":
                    CustomerGroupId = 59;
                    break;
            }
            return CustomerGroupId;
        }
        public static int GetCustomerTypeIdByL4Code(string L4Code)
        {
            int CustomerTypeId = Customer.UnknownCustomerTypeId;
            //00/07/EG10/1593415
            if (L4Code.Contains('/'))
                L4Code = L4Code.Substring(L4Code.LastIndexOf('/') + 1);
            
            switch (L4Code)
            {
                case "1593265"://L4 EG DD OOH Key Accounts
                case "3116652"://L4 EG Café And Restaurants
                case "3116660"://L4 EG Hotels
                case "3116661"://L4 EG Clubs
                case "3116662"://L4 EG Cinemas
                case "3116663"://L4 EG Juice Store
                case "3116664"://L4 EG Mobil Station
                case "3116670"://L4 EG Nuts Store
                case "3116672"://L4 EG Others
                case "3116673"://L4 EG Parks
                case "3116674"://L4 EG Schools
                case "3116675"://L4 EG Sweet Shop
                case "3134557"://L4 EG DD Direct Sales
                case "3134558"://L4 EG DD Semi Wholesalers
                case "3134562"://"L4 EG Super Markets
                    CustomerTypeId = 3;
                    break;
                case "1593263"://L4 EG TT Delta East
                case "1593267"://L4 EG TT Cairo
                case "1593314"://L4 EG TT Delta West
                case "1593315"://L4 EG TT Upper Egypt
                case "1593316"://L4 EG TT Red Sea
                    CustomerTypeId = 5;
                    break;
                case "3134561"://L4 EG DD Key Account
                    CustomerTypeId = 7;
                    break;
                case "1593310"://L4 EG Staff Sales One Time Donation
                    CustomerTypeId = 11;
                    break;
                case "3134560"://"L4 EG DD Wholesalers
                    CustomerTypeId = 12;
                    break;
                default:
                    break;
            }
            return CustomerTypeId;
        }

    }
}
