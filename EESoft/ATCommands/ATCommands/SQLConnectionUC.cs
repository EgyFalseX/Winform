using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ATCommands
{
    public partial class SQLConnectionUC : UserControl
    {
        #region -   Variables   -
        public string FullConString = string.Empty;
        public string DatabaseName = string.Empty;
        public string RegKeyName;
        OpenFileDialog OFD = new OpenFileDialog();
        string DBPath = string.Empty;
        string DBLogPath = string.Empty;
        #endregion
        #region -   Functions   -
        public SQLConnectionUC()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void SQLConnectionUC_Load(object sender, EventArgs e)
        {
            CBSqlAuth.SelectedIndex = 0;
            CBUseExpress_CheckedChanged(CBUseExpress, new EventArgs());
        }
        private void CBUseExpress_CheckedChanged(object sender, EventArgs e)
        {
            //if (CBUseExpress.Checked)
            //    txtserver.Text = System.Environment.MachineName.ToString() + @"\SQLEXPRESS";
            //else
            //    txtserver.Text = System.Environment.MachineName.ToString();
            if (CBUseExpress.Checked)
                txtserver.Text = txtserver.Text + @"\SQLEXPRESS";
            else
            {
                if ((int)txtserver.Text.LastIndexOf("\\") > -1)
                    txtserver.Text = txtserver.Text.Substring(0, (int)txtserver.Text.LastIndexOf("\\"));
                else
                    txtserver.Text = Environment.MachineName.ToString();
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
                FullConString = MyCL.ServerTest(txtserver.Text.Trim(), TxtID.Text.Trim(), TxtPW.Text.Trim());
            else if (CBSqlAuth.SelectedIndex == 1)
                FullConString = MyCL.ServerTest(txtserver.Text.Trim());
            if (FullConString != string.Empty)
            {
                //GBSecurity.Enabled = false;
                GBDB.Visible = true;
                RBAttached.Checked = true;
                btnstart.Visible = true;
                BtnEnd.Visible = true;
                RBAttached.Focus();
            }
            else
            {
                GBSecurity.Enabled = true;
                GBDB.Visible = false;
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
                DataTable AllDB = MyCL.GetAllDatabase(FullConString);
                if (AllDB.Rows.Count == 0)
                {
                    CBDBName.Enabled = false;
                    btnstart.Enabled = false;
                }
                else
                {
                    foreach (DataRow row in AllDB.Rows)
                    {
                        if (row[0].ToString() == "SMS")
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
            bool OkiDoki = false;
            if (RBNotAttached.Checked)
            {
                if (DBPath != string.Empty && DBLogPath != string.Empty)// With Log
                {
                    OkiDoki = MyCL.AttachDB(DatabaseName, DBPath, DBLogPath, FullConString);
                    if (OkiDoki)
                        FullConString += ";Initial Catalog=" + DatabaseName; //Set ConSTR in SQLCON and Registry
                    else
                        return;
                }
                else if (DBPath != string.Empty && DBLogPath == string.Empty)
                {
                    MessageBox.Show("NO Log Found.. !");
                    OkiDoki = MyCL.AttachDB(DatabaseName, DBPath, FullConString);
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
            
            MyCL.SqlConStr = FullConString;// Activate SqlConstr
            MyCL.SaveSQLDBPath();
            Application.Restart();
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}