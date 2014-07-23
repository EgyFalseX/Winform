using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ExcelToolVLookUp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void OpenUI(bool Open)
        {
            this.Invoke(new MethodInvoker(() => 
            {
                gb1.Enabled = Open;
                gb2.Enabled = Open;
                btnStart.Enabled = Open;
            }));
        }
        private void Add(string data)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                
                if (tbResult.Text == string.Empty)
                {
                    if (tbResult.Text.Contains(data))
                        return;
                    tbResult.AppendText(data);
                }
                else
                {
                    if (tbResult.Text.Contains(Environment.NewLine + data))
                        return;
                    tbResult.AppendText(Environment.NewLine + data);
                }
            }));
        }
        public static DataTable LoadExcelFile(string strFile, string sheetName, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection con = new OleDbConnection(strConnectionString);
                string query = string.Format("SELECT {0} FROM [{1}$]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While tring to open Excel File - " + ex.Message);
            }
            return dt;
        }
        public static DataTable LoadExcelFile(string strFile, int sheetIndex, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection con = new OleDbConnection(strConnectionString);
                con.Open();
                DataTable dtSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                con.Close();
                if (dtSchema == null)
                    return dt;
                string sheetName = dtSchema.Rows[sheetIndex]["TABLE_NAME"].ToString();
                string query = string.Format("SELECT {0} FROM [{1}]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While tring to open Excel File - " + ex.Message);
            }
            return dt;
        }
        private void btnFor_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            LblFor.Text = ofd.FileName;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            LblIn.Text = ofd.FileName;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (LblFor.Text == string.Empty || LblIn.Text == string.Empty || tbFieldFor.Text == string.Empty || tbFieldIn.Text == string.Empty)
            {
                MessageBox.Show("Please Enter all Required Options");
                return;
            }
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                OpenUI(false);
                try
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        tbResult.Clear();
                    }));
                    
                    DataTable dtFor = LoadExcelFile(LblFor.Text, 0, tbFieldFor.Text);
                    DataTable dtIn = LoadExcelFile(LblIn.Text, 0, tbFieldIn.Text);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pb.Maximum = dtFor.Rows.Count;
                    }));

                    
                    //dtFor.PrimaryKey = new DataColumn[] { dtFor.Columns[0] };
                    //dtIn.PrimaryKey = new DataColumn[] { dtIn.Columns[0] };
                    //DataView vFor = new DataView(dtFor);
                    //DataView vIn = new DataView(dtIn);
                    //vFor.Sort = tbFieldFor.Text; vIn.Sort = tbFieldIn.Text;

                    foreach (DataRow rowFor in dtFor.Rows)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            pb.Value = Convert.ToInt32(pb.Value) + 1;
                        }));
                        string filterstring = tbFieldIn.Text + " = '" + rowFor[tbFieldFor.Text].ToString().Trim() + "'";
                        DataRow[] found = dtIn.Select(filterstring);
                        if (found.Length == 0)
                        {
                            Add(rowFor[tbFieldFor.Text].ToString());
                        }
                    }

                    //if (dtIn.Rows.Find(rowFor[tbFieldFor.Text].ToString()) == null)
                    //{
                    //    Add(rowFor[tbFieldFor.Text].ToString());
                    //}
                    //vIn.RowFilter = tbFieldIn.Text + " = '" + rowFor[tbFieldFor.Text].ToString().Trim() + "'";
                    //if (vIn.Count == 0)
                    //{
                    //    Add(rowFor[tbFieldFor.Text].ToString());
                    //}

                    //foreach (DataRow rowFor in dtFor.Rows)
                    //{
                    //    this.Invoke(new MethodInvoker(() =>
                    //    {
                    //        pb.Value = Convert.ToInt32(pb.Value) + 1;
                    //    }));
                    //    vIn.RowFilter = tbFieldIn.Text + " = '" + rowFor[tbFieldFor.Text].ToString().Trim() + "'";
                    //    if (vIn.Count == 0)
                    //    {
                    //        Add(rowFor[tbFieldFor.Text].ToString());
                    //    }
                    //    bool Found = false;
                    //    if (dtIn.Rows.Find(rowFor[tbFieldFor.Text].ToString().Trim()) == null)
                    //    {
                    //        Add(rowFor[tbFieldFor.Text].ToString());
                    //    }
                    //    foreach (DataRow rowIn in dtIn.Rows)
                    //    {
                    //        if (rowFor[tbFieldFor.Text].ToString().Trim() == rowIn[tbFieldIn.Text].ToString().Trim())
                    //        {
                    //            Found = true;
                    //            break;
                    //        }
                    //    }
                    //    if (!Found)
                    //        Add(rowFor[tbFieldFor.Text].ToString());
                    //}

                    MessageBox.Show("Done ..." + tbResult.Lines.Length + " Found", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured  - " + ex.Message);
                }

                OpenUI(true);
                this.Invoke(new MethodInvoker(() =>
                {
                    pb.Maximum = 0;
                    pb.Value = 0;
                }));
            });
            
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            tbResult.SelectAll();
            tbResult.Copy();
            tbResult.Select(0, 0);
            MessageBox.Show("Copy Done ...", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
