using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using DataCenter.Managers;


namespace DataCenter.Forms
{
    public partial class SQLConnectionFrm : Form
    {
        #region -   Variables   -
        public string FullConString, DatabaseName;

        OpenFileDialog OFD = new OpenFileDialog();
        string DBPath = string.Empty;
        string DBLogPath = string.Empty;
        string DBGenerateScript = string.Empty;
        #endregion
        #region -   Functions   -
        public SQLConnectionFrm()
        {
            InitializeComponent();
        }
        public static string ServerTest(string ServerName, string username, string pass)
        {
            using (SqlConnection Con = new SqlConnection(String.Format(@"Data Source={0};Persist Security Info=True;User ID={1};Password={2}", ServerName, username, pass)))
            {
                try
                {
                    Con.Open();
                    Con.Close();
                    return Con.ConnectionString;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
        }
        public static string ServerTest(string ServerName)
        {
            using (SqlConnection Con = new SqlConnection(String.Format(@"Data Source={0};Integrated Security=true", ServerName)))
            {
                try
                {
                    Con.Open();
                    Con.Close();
                    return Con.ConnectionString;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
        }
        public static DataTable GetAllDatabase(string Constr)
        {
            DataTable ReturnMe = new DataTable("FalseX2010");
            SqlConnection Con = new SqlConnection(Constr);
            SqlDataAdapter dr = new SqlDataAdapter("SELECT * FROM master.dbo.sysdatabases", Con);
            try
            {
                dr.Fill(ReturnMe);
            }
            catch (SqlException)
            {
            }
            return ReturnMe;
        }
        public static bool AttachDB(string DatabaseName, string DataPath, string LogPath, string ConStr)
        {
            bool ReturnMe = false;
            SqlConnection TempCon = new SqlConnection(ConStr);
            string PConStr = String.Format("Data Source={0};Integrated Security=true", TempCon.DataSource);
            SqlConnection Con = new SqlConnection(PConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = String.Format(@"EXEC sp_attach_db @dbname = N'{0}', @filename1 = N'{1}',@filename2 = N'{2}'",
                DatabaseName, DataPath, LogPath);
                if (Cmd.ExecuteNonQuery() != 0)
                    ReturnMe = true;
                else
                    ReturnMe = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                ReturnMe = false;
            }
            Con.Close();
            return ReturnMe;
        }
        public static bool AttachDB(string DatabaseName, string DataPath, string ConStr)
        {
            //FOR ATTACH_REBUILD_LOG
            bool ReturnMe = false;
            SqlConnection TempCon = new SqlConnection(ConStr);
            string PConStr = String.Format("Data Source={0};Integrated Security=true", TempCon.DataSource);
            SqlConnection Con = new SqlConnection(PConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = @"CREATE DATABASE " + DatabaseName + @"
                                    ON(NAME='" + DatabaseName + @"', FILENAME='" + DataPath + @"')
                                    FOR ATTACH_REBUILD_LOG;";
                if (Cmd.ExecuteNonQuery() != 0)
                    ReturnMe = true;
                else
                    ReturnMe = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                ReturnMe = false;
            }
            Con.Close();
            return ReturnMe;
        }
        public static bool CheckDBWorking(string AccessConnectionString)
        {
            using (SqlConnection con = new SqlConnection(AccessConnectionString))
            {
                try
                {
                    con.Open();
                    con.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static bool GenerateDatabase(string connectionstring, string scriptCreate)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                Server server = new Server(new ServerConnection(con));
                server.ConnectionContext.ExecuteNonQuery(scriptCreate);
                con.Dispose();
                return true;
            }
            catch (SqlException ex)
            {
                con.Dispose();
                MessageBox.Show(ex.Message);
                return false;
            }
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
                FullConString = ServerTest(txtserver.Text.Trim(), TxtID.Text.Trim(), TxtPW.Text.Trim());
            else if (CBSqlAuth.SelectedIndex == 1)
                FullConString = ServerTest(txtserver.Text.Trim());
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
                PnlCreate.Visible = false;
                CBDBName.Items.Clear();
                DataTable AllDB = GetAllDatabase(FullConString);
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
                PnlCreate.Visible = false;
            }
        }
        private void RBCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCreate.Checked)
            {
                PnlCreate.Visible = true;
                PnlAttachDB.Visible = false;
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
        private void BtnDBPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (System.IO.File.Exists(fbd.SelectedPath + @"\DataCenter.mdf") || System.IO.File.Exists(fbd.SelectedPath + @"\DataCenter_log.mdf"))
                    {
                        if (MessageBox.Show("File already exists, please select another path" + Environment.NewLine + "What to choose another path ?", "File Exists", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                            BtnDBPath_Click(sender, e);
                    }
                    else
                    {
                        txtdatabasePath.Text = fbd.SelectedPath;
                        DBGenerateScript = DataManager.GenerateDatabaseScript(fbd.SelectedPath);
                        btnstart.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    OkiDoki = AttachDB(DatabaseName, DBPath, DBLogPath, FullConString);
                    if (OkiDoki)
                        FullConString += ";Initial Catalog=" + DatabaseName; //Set ConSTR in SQLCON and Registry
                    else
                        return;
                }
                else if (DBPath != string.Empty && DBLogPath == string.Empty)
                {
                    MessageBox.Show("NO Log Found.. !");
                    OkiDoki = AttachDB(DatabaseName, DBPath, FullConString);
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
            else if (RBCreate.Checked)
            {
                // Create DB
                if (GenerateDatabase(FullConString, DBGenerateScript))
                    FullConString += ";Initial Catalog=DataCenter";
                else
                    return;
            }
            else
                FullConString += ";Initial Catalog=" + CBDBName.SelectedItem.ToString();

            //Report Saving Option
            if (CBUseExpress.Checked)
            {
                string servername = txtserver.Text;
                if ((int)txtserver.Text.LastIndexOf("\\") > -1)// Get only the server ip for the report url
                    servername = txtserver.Text.Substring(0, (int)txtserver.Text.LastIndexOf("\\"));
                AppManager.defaultInstance.ReportURL = String.Format("http://{0}:{1}/{2}", servername, TxtReportSrvPort.Text.Trim(), TxtReportSrvName.Text.Trim());
            }
            else
                AppManager.defaultInstance.ReportURL = String.Format("http://{0}:{1}/{2}", txtserver.Text.Trim(), TxtReportSrvPort.Text.Trim(), TxtReportSrvName.Text.Trim());
            char[] x = TxtReportPath.Text.Trim().ToCharArray();
            if (x[0].Equals('/') == false)
                TxtReportPath.Text = "/" + TxtReportPath.Text.Trim();
            if (x[x.Length - 1].Equals('/') == false)
                TxtReportPath.Text = TxtReportPath.Text.Trim() + "/";
            AppManager.defaultInstance.ReportPath = TxtReportPath.Text;
            AppManager.defaultInstance.SqlConStr = FullConString;// Activate SqlConstr
            AppManager.defaultInstance.SSRSUserName = TxtSSRSUserName.Text;
            AppManager.defaultInstance.SSRSPassword = TxtSSRSPassword.Text;
            AppManager.defaultInstance.SSRSDomain = TxtSSRSDomain.Text;
            AppManager.defaultInstance.SaveSQLDBPath();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion

    }
}

