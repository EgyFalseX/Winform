using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Employee
{
    public partial class DatabaseManagerFrm : Form
    {
        #region -   Variables   -
        string BackupPath = @"C:\eschoolDatabaseBackup";
        #endregion
        #region -   Functions   -
        public DatabaseManagerFrm()
        {
            InitializeComponent();
        }
        private void LoadBackupList()
        {
            LBbackups.Items.Clear();
            //DataTable DT = FXFW.SqlDB.LoadDataTable(String.Format(@"EXEC master.dbo.xp_cmdshell 'DIR /b {0}\*.FXbak'", BackupPath));
            DataTable DT = FXFW.SqlDB.LoadDataTable(String.Format("EXEC Master..xp_DirTree \"{0}\",1,1", BackupPath));
            if (DT.Rows.Count != 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    if (row[0].ToString() != "File Not Found" && row[0].ToString().Trim().Length != 0)
                    {
                        if (row[0].ToString().Contains(".FXbak"))
                        {
                            LBbackups.Items.Add(row[0]);
                        }
                        
                    }
                }
            }
        }
        #endregion
        #region - Event Handlers -
        private void DatabaseManagerFrm_Load(object sender, EventArgs e)
        {
            BackupPath = FXFW.SqlDB.LoadDataTable(@"Select BackupPath From AppOptions Where OpCodeID = 1").Rows[0][0].ToString();
            TxtPath.Text = BackupPath;
            //Create Backup Directory if its not exists 
            if (!Directory.Exists(BackupPath))
                Directory.CreateDirectory(BackupPath);

            DataTable dt1 = FXFW.SqlDB.LoadDataTable(@"EXEC
                                                sp_configure 'show advanced options', 1
                                                -- To update the currently configured value for advanced options.
                                                RECONFIGURE
                                                -- To enable the feature.
                                                EXEC
                                                sp_configure 'xp_cmdshell', 1
                                                -- To update the currently configured value for this feature.
                                                RECONFIGURE ");
            LoadBackupList();
        }
        private void BtnchoosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog() { Description = "Select Folder To Save/Load Back Files...", ShowNewFolderButton = true };
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            BackupPath = FBD.SelectedPath;
            TxtPath.Text = FBD.SelectedPath;
        }
        private void BtnSavePath_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = String.Format(@"update AppOptions Set BackupPath = N'{0}' Where OpCodeID = 1", BackupPath);
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم حفظ المسار الجديد", false, this);
                Program.Logger.LogThis("تم حفظ المسار الجديد", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            LoadBackupList();
        }
        private void BtnBackup_Click(object sender, EventArgs e)
        {
            string DatabaseName = new SqlConnectionStringBuilder(FXFW.SqlDB.SqlConStr).InitialCatalog;

            PB.Visible = true;
            PB.Value = 2;
            Application.DoEvents();
            FXFW.SqlDB.BackupDatabase(DatabaseName, String.Format(@"{0}\{1}({2}.{3}.{4})({5}.{6}.{7}).FXbak", BackupPath, DatabaseName, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
            PB.Value = PB.Maximum;
            LoadBackupList();
            Program.ShowMsg("Backup successful ...!", false, this);
            PB.Value = 0;
            PB.Visible = false;
            Application.Restart();
        }
        private void BtnRestore_Click(object sender, EventArgs e)
        {
            if (LBbackups.SelectedIndex == -1)
            {
                Program.ShowMsg("Please select backup file from the list", true, this);
                return;
            }
            if (MessageBox.Show("Are you sure  ...?","Restore confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.No)
                return;

            string DatabaseName = new SqlConnectionStringBuilder(FXFW.SqlDB.SqlConStr).InitialCatalog;
            PB.Visible = true;
            PB.Value = 2;
            Application.DoEvents();
            FXFW.SqlDB.RestoreDatabase(DatabaseName, String.Format(@"{0}\{1}", BackupPath, LBbackups.Text));
            PB.Value = PB.Maximum;
            Program.ShowMsg("Restore successful ...!", false, this);
            PB.Value = 0;
            PB.Visible = false;
            Application.Restart();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LBbackups.SelectedIndex == -1)
            {
                Program.ShowMsg("Please select backup file from the list", true, this);
                return;
            }
            if (MessageBox.Show("Are you sure  ...?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            try
            {
                DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"xp_cmdshell 'del {0}\{1}'", BackupPath, LBbackups.Text));
                Program.ShowMsg("Backup deleted ...!", false, this);
                Program.Logger.LogThis("Backup deleted ...!", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadBackupList();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion

    }
}
