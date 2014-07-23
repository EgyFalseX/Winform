using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace GymSys
{
    static class Program
    {
        public static OleDbConnection Con;
        //public static OleDbTransaction Trn;
        public static OleDbCommand CMD;
        public static OleDbDataAdapter DataAdp;
        //public static OleDbDataReader DataRd;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Application.StartupPath + "\\DB\\GymDB.mdb\";Persist Security Info=True");
            CMD = new OleDbCommand("", Con);
            DataAdp = new OleDbDataAdapter("", Con);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SupplierFrm());
        }
        public static string EXECMD(string Command)
        {
            try
            {
                CMD.CommandText = Command;
                Con.Open();
                CMD.ExecuteNonQuery();
                Con.Close();
                return "تمــت العمليــه";
            }
            catch (Exception ex)
            {
                Con.Close();
                return ex.Message;
            }
        }
        public static string EXECMD(string Command,ref int EffectedID)
        {
            try
            {
                
                CMD.ExecuteNonQuery();
                CMD.CommandText = "Select @@identity";
                EffectedID= (int)CMD.ExecuteScalar();
                Con.Close();
                return EffectedID.ToString();
            }
            catch (Exception ex)
            {
                Con.Close();
                return ex.Message;
            }
        }
        public static DataTable CreatTable(string Command)
        {
            DataTable TableZ = new DataTable();
            try
                {
                    DataAdp.SelectCommand.CommandText = Command;
                    DataAdp.Fill(TableZ);
                }
            catch (Exception ex)
                {   MessageBox.Show(ex.Message); }
                    return TableZ;
        }

        public static string ExecuteScalar(string Command)
        {
            string Returner;
            try
            {
                CMD.CommandText = Command;
                Con.Open();
                Returner = CMD.ExecuteScalar().ToString();
                Con.Close();
                return Returner;
            }
            catch (Exception ex)
            { 
                Con.Close();
                return ex.Message;
            }

        }

        
    }
            
}
