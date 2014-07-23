using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Synricate
{
    public partial class SchedulerFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataSet SchedulerDataset = new DataSet();
        SqlDataAdapter AppointmentAdapter;
        SqlDataAdapter ResourcesAdapter;
        SqlDataAdapter AppointmentDependenciesAdapter;
        SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
        #endregion
        #region -   Functions   -
        public SchedulerFrm()
        {
            InitializeComponent();
            //schedulerAppointmentTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(Adapter_RowUpdated);
            //schedulerAppointmentTableAdapter.Adapter.RowUpdating += new System.Data.SqlClient.SqlRowUpdatingEventHandler(Adapter_RowUpdating);
        }
        #endregion
        #region - Event Handlers -
        private void SchedulerFrm_Load(object sender, EventArgs e)
        {
            //Appointment
            try
            {
                con.Open();
                AppointmentAdapter = new SqlDataAdapter(@"SELECT * FROM SchedulerAppointment", con);
                AppointmentAdapter.RowUpdated += AppointmentAdapter_RowUpdated;

                AppointmentAdapter.Fill(SchedulerDataset, "SchedulerAppointment");
                schedulerStorage1.Appointments.DataSource = SchedulerDataset;
                schedulerStorage1.Appointments.DataMember = "SchedulerAppointment";
                schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
                schedulerStorage1.Appointments.Mappings.AppointmentId = "AppointmentId";
                schedulerStorage1.Appointments.Mappings.Description = "Description";
                schedulerStorage1.Appointments.Mappings.End = "End";
                schedulerStorage1.Appointments.Mappings.Label = "Label";
                schedulerStorage1.Appointments.Mappings.Location = "Location";
                schedulerStorage1.Appointments.Mappings.PercentComplete = "PercentComplete";
                schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
                schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
                schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceId";
                schedulerStorage1.Appointments.Mappings.Start = "Start";
                schedulerStorage1.Appointments.Mappings.Status = "Status";
                schedulerStorage1.Appointments.Mappings.Subject = "Subject";
                schedulerStorage1.Appointments.Mappings.Type = "Type";

                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(AppointmentAdapter);
                AppointmentAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
                AppointmentAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                AppointmentAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();

            //Resources
            try
            {
                con.Open();
                ResourcesAdapter = new SqlDataAdapter(@"SELECT * FROM SchedulerResources", con);
                ResourcesAdapter.RowUpdated += ResourcesAdapter_RowUpdated;

                ResourcesAdapter.Fill(SchedulerDataset, "SchedulerResources");

                schedulerStorage1.Resources.DataSource = SchedulerDataset;
                schedulerStorage1.Resources.DataMember = "SchedulerResources";
                schedulerStorage1.Resources.Mappings.Caption = "Caption";
                schedulerStorage1.Resources.Mappings.Color = "Color";
                schedulerStorage1.Resources.Mappings.Id = "Id";
                schedulerStorage1.Resources.Mappings.Image = "Image";
                schedulerStorage1.Resources.Mappings.ParentId = "ParentId";

                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ResourcesAdapter);
                ResourcesAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
                ResourcesAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                ResourcesAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();

            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();

            //SchedulerAppointmentDependencies
            try
            {
                con.Open();
                AppointmentDependenciesAdapter = new SqlDataAdapter(@"SELECT * FROM SchedulerAppointmentDependencies", con);
                AppointmentDependenciesAdapter.RowUpdated += AppointmentDependenciesAdapter_RowUpdated;

                AppointmentDependenciesAdapter.Fill(SchedulerDataset, "SchedulerAppointmentDependencies");

                schedulerStorage1.AppointmentDependencies.DataSource = SchedulerDataset;
                schedulerStorage1.AppointmentDependencies.DataMember = "SchedulerAppointmentDependencies";
                schedulerStorage1.AppointmentDependencies.Mappings.DependentId = "DependentId";
                schedulerStorage1.AppointmentDependencies.Mappings.ParentId = "ParentId";
                schedulerStorage1.AppointmentDependencies.Mappings.Type = "Type";

                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(AppointmentDependenciesAdapter);
                AppointmentDependenciesAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
                AppointmentDependenciesAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                AppointmentDependenciesAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();

            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();

        }
        void AppointmentAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                int id = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('SchedulerAppointment')", con))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                e.Row["AppointmentId"] = id;
            }
        }
        void ResourcesAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                int id = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('SchedulerResources')", con))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                e.Row["Id"] = id;
            }
        }
        void AppointmentDependenciesAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                int id = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('SchedulerAppointmentDependencies')", con))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                e.Row["DependentId"] = id;
            }
        }
        private void OnApptChangedInsertedDeleted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            foreach (DataTable item in SchedulerDataset.Tables)
            {
                item.GetChanges();
            }
            AppointmentAdapter.Update(SchedulerDataset.Tables["SchedulerAppointment"]);
            AppointmentAdapter.Update(SchedulerDataset.Tables["SchedulerResources"]);
            AppointmentAdapter.Update(SchedulerDataset.Tables["SchedulerAppointmentDependencies"]);
            SchedulerDataset.AcceptChanges();
            
        }
        
        #endregion

        
    }
}