using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace EESoft_Sync
{
    class MainClass
    {
        public struct ConnectionStringSTR
        {
            public string ConnectionStringServer;
            public string ConnectionStringClients;
            public string IntermediatorConnectionString;
            public string SchoolUniID;
        }
        public enum UpdateTypes
        {
            Inserting, Updating, Deleteing
        }
        public struct UpdateObjectSTR
        {
            public UpdateTypes UpdateType;
            public string DBName;
        }

        public ConnectionStringSTR[] SysConnectionStrings;
        public UpdateObjectSTR[] UpdateObjects;
        
        public string ConnectionStringServer, ConnectionStringClients, IntermediatorConnectionString;
        private string SysDBPath = Application.StartupPath + "\\SysDB";

        public MainClass()
        {
            ConnectionStringServer = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + SysDBPath + "\\dataschool.mdb\"";
            ConnectionStringClients = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\dataschool.mdb";
            IntermediatorConnectionString = "";
        }

        public void FillUpdatingList(String SrcConStr, String TrgConStr, UpdateObjectSTR CUpdateObject)
        {
            OleDbConnection SrcCon = new OleDbConnection(SrcConStr);
            OleDbConnection TrgCon = new OleDbConnection(TrgConStr);
            OleDbCommand SrcCMD = new OleDbCommand("", SrcCon);
            OleDbCommand TrgCMD = new OleDbCommand("", TrgCon);
            OleDbDataAdapter SrcDA = new OleDbDataAdapter("", SrcCon);
            OleDbDataAdapter TrgDA = new OleDbDataAdapter("", TrgCon);
            string[] restrictions = new string[4];
            restrictions[3] = "Table";
            try
            {
                SrcCon.Open();
                TrgCon.Open();
                DataTable SrcDTsNames = SrcCon.GetSchema("Tables", restrictions);
                DataTable TrgDTsNames = TrgCon.GetSchema("Tables", restrictions);
                DataTable SrcDTRows = new DataTable();
                DataTable TrgDTRows = new DataTable();
                
                foreach (DataRow SrcRow in SrcDTsNames.Rows)
                {
                    SrcDA.SelectCommand.CommandText = "Select * From [" + SrcRow[2].ToString() + "]";
                    SrcDA.Fill(SrcDTsNames);
                    //TrgDA.Fill(TrgDTs);
                    SrcDA.Fill(SrcDTRows);
                    //MessageBox.Show(SrcDTRows.PrimaryKey[0].ColumnName);
                }
            }
            catch (Exception ex)
            {
                
                //throw ex;
            }
            
        }
    }
}
