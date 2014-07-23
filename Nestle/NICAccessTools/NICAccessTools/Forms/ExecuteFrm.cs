using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace NICAccessTools.Forms
{
    public partial class ExecuteFrm : DevExpress.XtraEditors.XtraForm
    {
        private Macro MyData = new Macro();
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        UpdateInfo notify = null;

        private Data.dsCfg.ExecutionLogsDataTable ExeData = new Data.dsCfg.ExecutionLogsDataTable();
        
        public ExecuteFrm()
        {
            InitializeComponent();
            //Execution Data
            gridControlData.DataSource = ExeData;
            //Procedures Data
            unitOfWorkProcedures.ConnectionString = Properties.Settings.Default.cfgConnectionString;
            xpCollectionProcedures.Session = unitOfWorkProcedures;
        }
        private void ExecuteFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCfg.Qry' table. You can move, or remove it, as needed.
            this.qryTableAdapter.Fill(this.dsCfg.Qry);
        }
        private void luePro_EditValueChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
            qryBindingSource.Filter = "ProcedureId = " + luePro.EditValue;
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Properties.Settings.Default.dbConnectionString);
            cmd = new OleDbCommand("", con) { CommandTimeout = 0 };
            worker.RunWorkerAsync();
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                ExeData.Clear();
                btnExecute.Enabled = false;
                luePro.Enabled = false;
                btnStop.Enabled = true;
                Application.DoEvents();
            }));

            notify = new UpdateInfo();
            notify.AddItem(false);
            notify.AddItem(pb.Properties.Maximum); notify.AddItem(pb.EditValue);
            notify.AddItem(lblState.Text);
            notify.OnItemChanged += notifySendFiles_OnItemChanged;

            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            DataView DV = (DataView)((BindingSource)lbQry.DataSource).List;
            notify.SetValue(1, DV.Count);
            for (int i = 0; i < DV.Count; i++)
            {
                Data.dsCfg.QryRow ROW = (Data.dsCfg.QryRow)DV[i].Row;
                DateTime dt = DateTime.Now;

                if ((bool)notify.GetValue(0) == true)
                {
                    MessageBox.Show("Execution Aported", "Aport", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cmd.CommandText = String.Format("[{0}]", ROW.QryName);
                notify.SetValue(3, "Execute: " + ROW.QryName);
                int result = 0;
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Invoke(new MethodInvoker(() =>
                {
                    Data.dsCfg.ExecutionLogsRow Log = ExeData.NewExecutionLogsRow();
                    Log.QueryName = ROW.QryName;
                    Log.EffectedRows = result.ToString();
                    Log.ExecutionTime = Math.Round(DateTime.Now.Subtract(dt).TotalMinutes, 2) + " Mins";
                    ExeData.AddExecutionLogsRow(Log);

                    gridViewData.RefreshData();
                }));
                

                notify.SetValue(2, i + 1);
            }
            con.Close();
        }
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnExecute.Enabled = true;
            luePro.Enabled = true;
            btnStop.Enabled = false;

            pb.EditValue = 0;
            if ((bool)notify.GetValue(0) == false)
            {
                //MessageBox.Show("Execution Completed ...", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblState.Text = "All Done ... :)";
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
                        pb.Properties.Maximum = Convert.ToInt32(value);
                        break;
                    case 2:
                        pb.EditValue = Convert.ToInt32(value);
                        break;
                    case 3:
                        lblState.Text = value.ToString();
                        break;
                    default:
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