using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace TinyShop.dbTools
{
    class misc
    {
        public enum DBTablesNames
        {
            BillDetails,
            Bills,
            BillTypes,
            Customers,
            Products,
            Suppliers
        }
        public enum BillType : int
        {
            None = 0,
            Tawreed = 1,
            Baye3 = 2,
            Mortaga3 = 3,
            Hawaleek = 4
        }
        public struct UserInfo
        {
            public int UserID;
            public string UserName;
        }
        private static OleDbConnection GetConnection()
        {
            return new OleDbConnection(global::TinyShop.Properties.Settings.Default.TinyDataConnectionString);
        }
        public static string GetNewID(DBTablesNames TableName)
        {
            string ColunmName = string.Empty;
            string ReturnMe = string.Empty;
            switch (TableName)
            {
                case DBTablesNames.BillDetails:
                    ColunmName = "BillDetailID";
                    break;
                case DBTablesNames.Bills:
                    ColunmName = "BillID";
                    break;
                case DBTablesNames.BillTypes:
                    ColunmName = "BillTypeID";
                    break;
                case DBTablesNames.Customers:
                    ColunmName = "CustomerID";
                    break;
                case DBTablesNames.Products:
                    ColunmName = "ProductID";
                    break;
                case DBTablesNames.Suppliers:
                    ColunmName = "SupplierID";
                    break;
                default:
                    break;
            }
            using (OleDbConnection con = GetConnection())
            {
                
                OleDbCommand cmd = new OleDbCommand("", con);
                try
                {
                    con.Open();
                    cmd.CommandText = string.Format(@"SELECT IIF(IsNull(MAX({0})), 1, MAX({0}) + 1) AS NewID FROM {1}", ColunmName, TableName.ToString());
                    ReturnMe = cmd.ExecuteScalar().ToString();
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
                con.Close();
            }
            return ReturnMe;
        }

    }
}
