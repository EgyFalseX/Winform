using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Data.OleDb;

namespace Synricate
{
    public partial class ImportExcelDataFrm : Form
    {
        public DataTable Mobiles = new DataTable();
        public ImportExcelDataFrm()
        {
            InitializeComponent();
        }
        private void ImportExcelDataFrm_Load(object sender, EventArgs e)
        {
            DataColumn colmob = new DataColumn()
            {
                ColumnName = "mobile",
                Caption = "الموبيل",
                DataType = typeof(string)
            };
            DataColumn colchk = new DataColumn()
            {
                ColumnName = "checked",
                Caption = "استخدام",
                DataType = typeof(string)
            };
            Mobiles.Columns.Add(colmob);
            Mobiles.Columns.Add(colchk);

        }
        private void lbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataTable dt = FillDataTable(String.Format("SELECT * FROM [{0}]", lbSheets.SelectedItem), tbFileName.Text))
            {
                lbColumns.Items.Clear();
                foreach (DataColumn col in dt.Columns)
                {
                    lbColumns.Items.Add(col.ColumnName);
                }
            }
        }
        private void lbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataTable dt = FillDataTable(String.Format("SELECT {0} FROM [{1}]", lbColumns.SelectedItem, lbSheets.SelectedItem), tbFileName.Text))
            {
                lbData.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    lbData.Items.Add(row[0]);
                }
            }
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog() { 
                Title = "Select file", InitialDirectory = @"c:\", FileName = tbFileName.Text,
                Filter = "Excel Sheet 97-03(*.xls)|*.xls|Excel Sheet 2007(*.xlsx)|*.xlsx|All Files(*.*)|*.*", 
                FilterIndex = 1, RestoreDirectory = true };

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = fdlg.FileName;
                Application.DoEvents();
               
               string[] str = GetExcelSheetNames(tbFileName.Text);
               lbSheets.Items.Clear();
               foreach (string item in str)
               {
                   lbSheets.Items.Add(item);
               }
            }
        }
        /// <summary>
        /// This method retrieves the excel sheet names from 
        /// an excel workbook.
        /// </summary>
        /// <param name="excelFile">The excel file.</param>
        /// <returns>String[]</returns>
        private static String[] GetExcelSheetNames(string excelFile)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;
            try
            {
                // Connection String. Change the excel file to the file you
                // will search.
                String connString = GetConnectionString(excelFile);
                // Create connection object by using the preceding connection string.
                objConn = new OleDbConnection(connString);
                // Open connection with the database.
                objConn.Open();
                // Get the data table containg the schema guid.
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dt == null)
                    return null;
                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;
                // Add the sheet name to the string array.
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString();
                    i++;
                }
                // Loop through all of the sheets if you want too...
                //for (int j = 0; j < excelSheets.Length; j++)
                //{
                //    // Query each excel sheet.
                //}
                return excelSheets;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // Clean up.
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }
        private static string GetConnectionString(string filePath)
        {
            OleDbConnectionStringBuilder sbConnection = new OleDbConnectionStringBuilder();
            String strExtendedProperties = String.Empty;
            sbConnection.DataSource = filePath;
            if (Path.GetExtension(filePath).Equals(".xls"))//for 97-03 Excel file
            {
                sbConnection.Provider = "Microsoft.Jet.OLEDB.4.0";
                strExtendedProperties = "Excel 8.0;HDR=Yes;IMEX=1";//HDR=ColumnHeader,IMEX=InterMixed
            }
            else if (Path.GetExtension(filePath).Equals(".xlsx"))  //for 2007 Excel file
            {
                sbConnection.Provider = "Microsoft.ACE.OLEDB.12.0";
                strExtendedProperties = "Excel 12.0;HDR=Yes;IMEX=1";
            }
            sbConnection.Add("Extended Properties", strExtendedProperties);
            return sbConnection.ConnectionString;
        }
        private static DataTable FillDataTable(string commandstring, string filePath)
        {
            //"SELECT * FROM [" + SheetName + "]"
            DataTable dt = new DataTable();
            OleDbDataAdapter Adp = new OleDbDataAdapter(commandstring, GetConnectionString(filePath));
            Adp.Fill(dt);
            return dt;
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lbData.Items.Count == 0)
            {
                MessageBox.Show("لا يوجد بيانات لاستيرادها");
                return;
            }
            foreach (object item in lbData.Items)
            {
                DataRow row = Mobiles.NewRow();
                row["mobile"] = "0" + item.ToString();
                row["checked"] = "False";
                Mobiles.Rows.Add(row);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

    }
}
