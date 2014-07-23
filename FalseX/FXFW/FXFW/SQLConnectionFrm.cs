using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FXFW
{
    public partial class SQLConnectionFrm : Form
    {
        #region -   Variables   -
        public string FullConString, DatabaseName;

        OpenFileDialog OFD = new OpenFileDialog();
        string DBPath = string.Empty;
        string DBLogPath = string.Empty;
        #endregion
        #region -   Functions   -
        public SQLConnectionFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region - Event Handlers -
        private void SQLConnectionFrm_Load(object sender, EventArgs e)
        {
            Text += " " + DatabaseName;

            CBSqlAuth.SelectedIndex = 0;
            CBUseExpress_CheckedChanged(CBUseExpress, new EventArgs());
        }
        private void CBUseExpress_CheckedChanged(object sender, EventArgs e)
        {
            if (CBUseExpress.Checked)
            {
                txtserver.Text = txtserver.Text + @"\SQLEXPRESS";
                TxtReportSrvName.Text = TxtReportSrvName.Text + @"_SQLEXPRESS";
            }
            else
            {
                if ((int)txtserver.Text.LastIndexOf("\\") > -1)
                    txtserver.Text = txtserver.Text.Substring(0, (int)txtserver.Text.LastIndexOf("\\"));
                else
                    txtserver.Text = Environment.MachineName.ToString();

                if ((int)TxtReportSrvName.Text.LastIndexOf("_") > -1)
                    TxtReportSrvName.Text = TxtReportSrvName.Text.Substring(0, (int)TxtReportSrvName.Text.LastIndexOf("_"));
                else
                    TxtReportSrvName.Text = "ReportServer";
            }
        }
        private void CBSqlAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSqlAuth.SelectedIndex == 0)// Sql Autherity
            {
                TxtID.Enabled = true;
                TxtPW.Enabled = true;
            }
            else// Windows Autherity
            {
                TxtID.Enabled = false;
                TxtPW.Enabled = false;
            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtserver.Text.Trim().Length == 0 || TxtID.Text.Trim().Length == 0 || TxtPW.Text.Trim().Length == 0)
                BtnConnect.Enabled = false;
            else
                BtnConnect.Enabled = true;
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (CBSqlAuth.SelectedIndex == 0)
                FullConString = SqlDB.ServerTest(txtserver.Text.Trim(), TxtID.Text.Trim(), TxtPW.Text.Trim());
            else if (CBSqlAuth.SelectedIndex == 1)
                FullConString = SqlDB.ServerTest(txtserver.Text.Trim());
            if (FullConString != string.Empty)
            {
                //GBSecurity.Enabled = false;
                GBDB.Visible = true;
                GBReport.Visible = true;
                RBAttached.Checked = true;
                btnstart.Visible = true;
                BtnEnd.Visible = true;
                RBAttached.Focus();
            }
            else
            {
                GBSecurity.Enabled = true;
                GBDB.Visible = false;
                GBReport.Visible = false;
                btnstart.Visible = false;
                BtnEnd.Visible = false;
                txtserver.Focus();
            }
        }
        private void RBAttached_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAttached.Checked)
            {
                PnlSelectDB.Visible = true;
                PnlAttachDB.Visible = false;
                CBDBName.Items.Clear();
                DataTable AllDB = SqlDB.GetAllDatabase(FullConString);
                if (AllDB.Rows.Count == 0)
                {
                    CBDBName.Enabled = false;
                    btnstart.Enabled = false;
                }
                else
                {
                    foreach (DataRow row in AllDB.Rows)
                    {
                        if (row[0].ToString().ToLower() == DatabaseName.ToLower())
                            CBDBName.Items.Add(row[0].ToString());
                    }
                    if (CBDBName.Items.Count == 0)
                    {
                        CBDBName.Enabled = false;
                        btnstart.Enabled = false;
                    }
                    else
                    {
                        CBDBName.SelectedIndex = 0;
                        CBDBName.Focus();
                        CBDBName.Enabled = true;
                        btnstart.Enabled = true;
                    }
                }

            }
        }
        private void RBNotAttached_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNotAttached.Checked)
            {
                PnlAttachDB.Visible = true;
                PnlSelectDB.Visible = false;
            }
        }
        private void BtnDB_Click(object sender, EventArgs e)
        {
            try
            {
                OFD.Filter = String.Format("{0} FileName | {0}.mdf", DatabaseName);
                OFD.Title = String.Format("من فضلك اختار مكان قاعدة البيانات \n{0}", DatabaseName);
                OFD.InitialDirectory = string.Empty;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    //LogLFD
                    string LogFile = string.Empty;
                    LogFile = OFD.FileName.Substring(0, OFD.FileName.Length - 4) + "_log.ldf";
                    if (System.IO.File.Exists(LogFile))
                        DBLogPath = LogFile;
                    else
                        DBLogPath = string.Empty;

                    DBPath = OFD.FileName;
                    btnstart.Enabled = true;
                    txtdatabase.Text = OFD.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            if (TxtReportSrvName.Text.Trim().Length == 0 || TxtReportSrvPort.Text.Trim().Length == 0 || TxtReportPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter Report Server, Port, Path", "Incomplate Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool OkiDoki = false;
            if (RBNotAttached.Checked)
            {
                if (DBPath != string.Empty && DBLogPath != string.Empty)// With Log
                {
                    OkiDoki = SqlDB.AttachDB(DatabaseName, DBPath, DBLogPath, FullConString);
                    if (OkiDoki)
                        FullConString += ";Initial Catalog=" + DatabaseName; //Set ConSTR in SQLCON and Registry
                    else
                        return;
                }
                else if (DBPath != string.Empty && DBLogPath == string.Empty)
                {
                    MessageBox.Show("NO Log Found.. !");
                    OkiDoki = SqlDB.AttachDB(DatabaseName, DBPath, FullConString);
                    if (OkiDoki)
                        FullConString += ";Initial Catalog=" + DatabaseName; //Set ConSTR in SQLCON and Registry
                    else
                        return;
                }
                else
                {
                    MessageBox.Show("Please Select Database Path", "Database information is missing..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
                FullConString += ";Initial Catalog=" + CBDBName.SelectedItem.ToString();

            //Report Saving Option
            if (CBUseExpress.Checked)
            {
                string servername = txtserver.Text;
                if ((int)txtserver.Text.LastIndexOf("\\") > -1)// Get only the server ip for the report url
                    servername = txtserver.Text.Substring(0, (int)txtserver.Text.LastIndexOf("\\"));
                SqlDB.ReportURL = String.Format("http://{0}:{1}/{2}", servername, TxtReportSrvPort.Text.Trim(), TxtReportSrvName.Text.Trim());
            }
            else
                SqlDB.ReportURL = String.Format("http://{0}:{1}/{2}", txtserver.Text.Trim(), TxtReportSrvPort.Text.Trim(), TxtReportSrvName.Text.Trim());
            char[] x = TxtReportPath.Text.Trim().ToCharArray();
            if (x[0].Equals('/') == false)
                TxtReportPath.Text = "/" + TxtReportPath.Text.Trim();
            if (x[x.Length - 1].Equals('/') == false)
                TxtReportPath.Text = TxtReportPath.Text.Trim() + "/";
            SqlDB.ReportPath = TxtReportPath.Text;
            SqlDB.SqlConStr = FullConString;// Activate SqlConstr
            SqlDB.SSRSUserName = TxtSSRSUserName.Text;
            SqlDB.SSRSPassword = TxtSSRSPassword.Text;
            SqlDB.SSRSDomain = TxtSSRSDomain.Text;
            SqlDB.SaveSQLDBPath();
            Application.Restart();
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            //Form me = (Form)this.Parent;
            //me.Close();
            Application.Exit();
        }
        #endregion         #region -   Variables   -
    }
}
