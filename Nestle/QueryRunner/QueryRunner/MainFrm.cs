using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QueryRunner
{
    public partial class MainFrm : Form
    {
        #region -   Variables   -
        public Macro MyData = new Macro();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        Utilities.UpdateInfo notify = null;
        
        #endregion
        #region -   Functions   -
        public MainFrm()
        {
            InitializeComponent();
            MyData.PropertyChanged += MyData_PropertyChanged;
            SetLBQueriesDataSource();
        }

        public void SetLBQueriesDataSource()
        {
            lblPath.DataBindings.Clear();
            lblPath.DataBindings.Add(new Binding("Text", MyData, "DatabaseFilePath"));

            LBQueries.DataSource = null;
            LBQueries.DataSource = MyData.Queries;
        }
        #endregion
        #region -   Event Handlers   -
        void MyData_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "DatabaseFilePath":
                    lblPath.Text = MyData.DatabaseFilePath;
                    break;
            }
        }
        private void btndbPath_Click(object sender, EventArgs e)
        {
            if (ofdDB.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            MyData.DatabaseFilePath = ofdDB.FileName;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbQueryName.Text.Trim() != string.Empty)
                MyData.Queries.Add(tbQueryName.Text);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (LBQueries.SelectedItem != null)
                MyData.Queries.RemoveAt(LBQueries.SelectedIndex);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdConfig.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            Program.ReadFile(ref MyData, ofdConfig.FileName);
            SetLBQueriesDataSource();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdConfig.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            Program.WriteFile(MyData, sfdConfig.FileName);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        #endregion

        private void btnRun_Click(object sender, EventArgs e)
        {
            //con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + MyData.DatabaseFilePath);
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MyData.DatabaseFilePath);
            cmd = new OleDbCommand("", con) { CommandTimeout = 0 };
            worker.RunWorkerAsync();
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(() => 
            {
                LVResult.Items.Clear();
                btnAdd.Enabled = false;
                btndbPath.Enabled = false;
                btnRemove.Enabled = false;
                btnRun.Enabled = false;
                menuStripMain.Enabled = false;
                btnStop.Enabled = true;
            }));

            notify = new Utilities.UpdateInfo();
            notify.AddItem(false);
            notify.AddItem(pb.Maximum); notify.AddItem(pb.Value);
            notify.AddItem(toolStripStatusLabelStatus.Text);
            notify.OnItemChanged += notifySendFiles_OnItemChanged;

            cmd.CommandType = CommandType.StoredProcedure;
            
            con.Open();
            notify.SetValue(1, LBQueries.Items.Count);

            for (int i = 0; i < LBQueries.Items.Count; i++)
            {
                DateTime dt = DateTime.Now;

                if ((bool)notify.GetValue(0) == true)
                {
                    MessageBox.Show("Execution Aported", "Aport", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cmd.CommandText = String.Format("[{0}]", LBQueries.Items[i]);
                notify.SetValue(3, "Execute: " +  LBQueries.Items[i].ToString());
                int result = 0;
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ListViewItem lvi = new ListViewItem() { Text = LBQueries.Items[i].ToString() };
                lvi.SubItems.Add(result.ToString());

                lvi.SubItems.Add(Math.Round(DateTime.Now.Subtract(dt).TotalMinutes, 2) + " Min");
                this.Invoke(new MethodInvoker(() =>
                { LVResult.Items.Add(lvi); }));
                notify.SetValue(2, i + 1);
            }
            con.Close();
        }
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            btnAdd.Enabled = true;
            btndbPath.Enabled = true;
            btnRemove.Enabled = true;
            btnRun.Enabled = true;
            menuStripMain.Enabled = true;
            btnStop.Enabled = false;
            pb.Value = 0;
            if ((bool)notify.GetValue(0) == false)
            {
                //MessageBox.Show("Execution Completed ...", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabelStatus.Text = "All Done ... :)";
            }
        }
        void notifySendFiles_OnItemChanged(int index, object value)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                switch (index)
                {
                    case 0://Canceled
                        break;
                    case 1:
                        pb.Maximum = Convert.ToInt32(value);
                        break;
                    case 2:
                        pb.Value = Convert.ToInt32(value);
                        break;
                    case 3:
                        toolStripStatusLabelStatus.Text = value.ToString();
                        break;
                }
            }));

        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            notify.SetValue(0, true);
        }
    }
}
